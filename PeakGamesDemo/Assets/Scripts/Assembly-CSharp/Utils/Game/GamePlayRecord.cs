using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using BestHTTP.Decompression.Zlib;
using UnityEngine;

namespace Utils.Game
{
	[Serializable]
	public class GamePlayRecord
	{
		public int v = 4;

		public int s;

		public int l;

		public string n;

		public int c;

		public int p;

		public List<int> b;

		public List<int> e;

		public List<int> w;

		public List<int> m;

		public string k;

		[NonSerialized]
		public List<byte[]> snapshots;

		public GamePlayRecord(int HJBOEOOLOOE)
		{
			s = HJBOEOOLOOE;
			b = new List<int>();
			e = new List<int>();
			w = new List<int>();
			m = new List<int>();
		}

		public override string ToString()
		{
			return LFIJNCAPDMO();
		}

		private string LFIJNCAPDMO()
		{
			k = ANJFOANOFAN(snapshots);
			return JsonUtility.ToJson(this);
		}

		public static GamePlayRecord NBPMNECNBHJ(string BIPAJFCNEOB)
		{
			GamePlayRecord gamePlayRecord = JsonUtility.FromJson<GamePlayRecord>(BIPAJFCNEOB);
			gamePlayRecord.snapshots = NJPBKEDEFFC(gamePlayRecord.k);
			return gamePlayRecord;
		}

		private static string ANJFOANOFAN(List<byte[]> ACHCIOHJJNP)
		{
			string result = string.Empty;
			try
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (MemoryStream memoryStream2 = new MemoryStream())
					{
						using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress))
						{
							foreach (byte[] item in ACHCIOHJJNP)
							{
								short num = (short)item.Length;
								byte[] bytes = BitConverter.GetBytes(num);
								if (BitConverter.IsLittleEndian)
								{
									LJMBLGMIKCJ(bytes);
								}
								gZipStream.Write(bytes, 0, 2);
								gZipStream.Write(item, 0, num);
							}
						}
						byte[] array = memoryStream.ToArray();
						LHLJMOICCOC lHLJMOICCOC = new LHLJMOICCOC();
						lHLJMOICCOC.LMDBBPLCJDM(array, 0, array.Length, memoryStream2);
						result = Encoding.ASCII.GetString(memoryStream2.ToArray());
					}
				}
			}
			catch (Exception ex)
			{
				NHNBFBDHKGN.JFPLDMEBIJH("Snapshot Base64 Conversion", ex.Message, ex.StackTrace);
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Replay, "Snapshot Base64 Conversion Exception. Reason: {0} Stack: {1}", ex.Message, ex.StackTrace);
			}
			return result;
		}

		private static List<byte[]> NJPBKEDEFFC(string CKANDONFNPG)
		{
			List<byte[]> list = new List<byte[]>();
			if (CKANDONFNPG.Length == 0)
			{
				return list;
			}
			byte[] array = new byte[2];
			using (MemoryStream memoryStream = new MemoryStream())
			{
				LHLJMOICCOC lHLJMOICCOC = new LHLJMOICCOC();
				byte[] bytes = Encoding.ASCII.GetBytes(CKANDONFNPG);
				lHLJMOICCOC.ILOALOLANOL(bytes, 0, bytes.Length, memoryStream);
				memoryStream.Seek(0L, SeekOrigin.Begin);
				using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
				{
					while (gZipStream.Read(array, 0, 2) > 0)
					{
						if (BitConverter.IsLittleEndian)
						{
							LJMBLGMIKCJ(array);
						}
						short num = BitConverter.ToInt16(array, 0);
						byte[] array2 = new byte[num];
						gZipStream.Read(array2, 0, num);
						list.Add(array2);
					}
					return list;
				}
			}
		}

		private static void LJMBLGMIKCJ(byte[] DIPNEDDIHBK)
		{
			byte b = DIPNEDDIHBK[0];
			DIPNEDDIHBK[0] = DIPNEDDIHBK[1];
			DIPNEDDIHBK[1] = b;
		}
	}
}
