using System;
using System.Collections.Generic;
using System.IO;
using BestHTTP.Decompression.Zlib;
using BestHTTP.Extensions;
using BestHTTP.WebSocket.Frames;

namespace BestHTTP.WebSocket.Extensions
{
	public sealed class PerMessageCompression : IExtension
	{
		private static readonly byte[] Trailer = new byte[4] { 0, 0, 255, 255 };

		private MemoryStream compressorOutputStream;

		private DeflateStream compressorDeflateStream;

		private MemoryStream decompressorInputStream;

		private MemoryStream decompressorOutputStream;

		private DeflateStream decompressorDeflateStream;

		private byte[] copyBuffer = new byte[1024];

		public bool ClientNoContextTakeover { get; private set; }

		public bool ServerNoContextTakeover { get; private set; }

		public int ClientMaxWindowBits { get; private set; }

		public int ServerMaxWindowBits { get; private set; }

		public CompressionLevel Level { get; private set; }

		public int MinimumDataLegthToCompress { get; set; }

		public PerMessageCompression()
			: this(CompressionLevel.Default, false, false, 15, 15, 10)
		{
		}

		public PerMessageCompression(CompressionLevel level, bool clientNoContextTakeover, bool serverNoContextTakeover, int desiredClientMaxWindowBits, int desiredServerMaxWindowBits, int minDatalengthToCompress)
		{
			Level = level;
			ClientNoContextTakeover = clientNoContextTakeover;
			ServerNoContextTakeover = ServerNoContextTakeover;
			ClientMaxWindowBits = desiredClientMaxWindowBits;
			ServerMaxWindowBits = desiredServerMaxWindowBits;
			MinimumDataLegthToCompress = minDatalengthToCompress;
		}

		public void AddNegotiation(HTTPRequest request)
		{
			string text = "permessage-deflate";
			if (ServerNoContextTakeover)
			{
				text += "; server_no_context_takeover";
			}
			if (ClientNoContextTakeover)
			{
				text += "; client_no_context_takeover";
			}
			if (ServerMaxWindowBits != 15)
			{
				text = text + "; server_max_window_bits=" + ServerMaxWindowBits;
			}
			else
			{
				ServerMaxWindowBits = 15;
			}
			if (ClientMaxWindowBits != 15)
			{
				text = text + "; client_max_window_bits=" + ClientMaxWindowBits;
			}
			else
			{
				text += "; client_max_window_bits";
				ClientMaxWindowBits = 15;
			}
			request.AddHeader("Sec-WebSocket-Extensions", text);
		}

		public bool ParseNegotiation(WebSocketResponse resp)
		{
			List<string> headerValues = resp.GetHeaderValues("Sec-WebSocket-Extensions");
			if (headerValues == null)
			{
				return false;
			}
			for (int i = 0; i < headerValues.Count; i++)
			{
				HeaderParser headerParser = new HeaderParser(headerValues[i]);
				for (int j = 0; j < headerParser.Values.Count; j++)
				{
					HeaderValue headerValue = headerParser.Values[i];
					if (!string.IsNullOrEmpty(headerValue.Key) && headerValue.Key.StartsWith("permessage-deflate", StringComparison.OrdinalIgnoreCase))
					{
						HTTPManager.Logger.Information("PerMessageCompression", "Enabled with header: " + headerValues[i]);
						HeaderValue option;
						if (headerValue.TryGetOption("client_no_context_takeover", out option))
						{
							ClientNoContextTakeover = true;
						}
						if (headerValue.TryGetOption("server_no_context_takeover", out option))
						{
							ServerNoContextTakeover = true;
						}
						int result;
						if (headerValue.TryGetOption("client_max_window_bits", out option) && option.HasValue && int.TryParse(option.Value, out result))
						{
							ClientMaxWindowBits = result;
						}
						int result2;
						if (headerValue.TryGetOption("server_max_window_bits", out option) && option.HasValue && int.TryParse(option.Value, out result2))
						{
							ServerMaxWindowBits = result2;
						}
						return true;
					}
				}
			}
			return false;
		}

		public byte GetFrameHeader(WebSocketFrame writer, byte inFlag)
		{
			if ((writer.Type == WebSocketFrameTypes.Binary || writer.Type == WebSocketFrameTypes.Text) && writer.Data != null && writer.Data.Length >= MinimumDataLegthToCompress)
			{
				return (byte)(inFlag | 0x40u);
			}
			return inFlag;
		}

		public byte[] Encode(WebSocketFrame writer)
		{
			if (writer.Data == null)
			{
				return WebSocketFrame.NoData;
			}
			if ((writer.Header & 0x40u) != 0)
			{
				return Compress(writer.Data);
			}
			return writer.Data;
		}

		public byte[] Decode(byte header, byte[] data)
		{
			if ((header & 0x40u) != 0)
			{
				return Decompress(data);
			}
			return data;
		}

		private byte[] Compress(byte[] data)
		{
			if (compressorOutputStream == null)
			{
				compressorOutputStream = new MemoryStream();
			}
			compressorOutputStream.SetLength(0L);
			if (compressorDeflateStream == null)
			{
				compressorDeflateStream = new DeflateStream(compressorOutputStream, CompressionMode.Compress, Level, true, ClientMaxWindowBits);
				compressorDeflateStream.FlushMode = FlushType.Sync;
			}
			byte[] array = null;
			try
			{
				compressorDeflateStream.Write(data, 0, data.Length);
				compressorDeflateStream.Flush();
				compressorOutputStream.Position = 0L;
				compressorOutputStream.SetLength(compressorOutputStream.Length - 4);
				return compressorOutputStream.ToArray();
			}
			finally
			{
				if (ClientNoContextTakeover)
				{
					compressorDeflateStream.Dispose();
					compressorDeflateStream = null;
				}
			}
		}

		private byte[] Decompress(byte[] data)
		{
			if (decompressorInputStream == null)
			{
				decompressorInputStream = new MemoryStream(data.Length + 4);
			}
			decompressorInputStream.Write(data, 0, data.Length);
			decompressorInputStream.Write(Trailer, 0, Trailer.Length);
			decompressorInputStream.Position = 0L;
			if (decompressorDeflateStream == null)
			{
				decompressorDeflateStream = new DeflateStream(decompressorInputStream, CompressionMode.Decompress, CompressionLevel.Default, true, ServerMaxWindowBits);
				decompressorDeflateStream.FlushMode = FlushType.Sync;
			}
			if (decompressorOutputStream == null)
			{
				decompressorOutputStream = new MemoryStream();
			}
			decompressorOutputStream.SetLength(0L);
			int count;
			while ((count = decompressorDeflateStream.Read(copyBuffer, 0, copyBuffer.Length)) != 0)
			{
				decompressorOutputStream.Write(copyBuffer, 0, count);
			}
			decompressorDeflateStream.SetLength(0L);
			byte[] result = decompressorOutputStream.ToArray();
			if (ServerNoContextTakeover)
			{
				decompressorDeflateStream.Dispose();
				decompressorDeflateStream = null;
			}
			return result;
		}
	}
}
