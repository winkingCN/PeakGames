using System;
using System.Collections.Generic;
using System.Text;
using BestHTTP.SignalR.Messages;

namespace BestHTTP.SignalR.Hubs
{
	public class Hub : IHub
	{
		private Dictionary<string, object> state;

		private Dictionary<ulong, ClientMessage> SentMessages = new Dictionary<ulong, ClientMessage>();

		private Dictionary<string, OnMethodCallCallbackDelegate> MethodTable = new Dictionary<string, OnMethodCallCallbackDelegate>();

		private StringBuilder builder = new StringBuilder();

		Connection IHub.Connection { get; set; }

		public string Name { get; private set; }

		public Dictionary<string, object> State
		{
			get
			{
				if (state == null)
				{
					state = new Dictionary<string, object>();
				}
				return state;
			}
		}

		public event OnMethodCallDelegate OnMethodCall;

		public Hub(string name)
			: this(name, null)
		{
		}

		public Hub(string name, Connection manager)
		{
			Name = name;
			((IHub)this).Connection = manager;
		}

		public void On(string method, OnMethodCallCallbackDelegate callback)
		{
			MethodTable[method] = callback;
		}

		public void Off(string method)
		{
			MethodTable[method] = null;
		}

		public bool Call(string method, params object[] args)
		{
			return Call(method, null, null, null, args);
		}

		public bool Call(string method, OnMethodResultDelegate onResult, params object[] args)
		{
			return Call(method, onResult, null, null, args);
		}

		public bool Call(string method, OnMethodResultDelegate onResult, OnMethodFailedDelegate onResultError, params object[] args)
		{
			return Call(method, onResult, onResultError, null, args);
		}

		public bool Call(string method, OnMethodResultDelegate onResult, OnMethodProgressDelegate onProgress, params object[] args)
		{
			return Call(method, onResult, null, onProgress, args);
		}

		public bool Call(string method, OnMethodResultDelegate onResult, OnMethodFailedDelegate onResultError, OnMethodProgressDelegate onProgress, params object[] args)
		{
			lock (((IHub)this).Connection.SyncRoot)
			{
				((IHub)this).Connection.ClientMessageCounter %= ulong.MaxValue;
				return ((IHub)this).Call(new ClientMessage(this, method, args, ((IHub)this).Connection.ClientMessageCounter++, onResult, onResultError, onProgress));
			}
		}

		bool IHub.Call(ClientMessage msg)
		{
			lock (((IHub)this).Connection.SyncRoot)
			{
				if (!((IHub)this).Connection.SendJson(BuildMessage(msg)))
				{
					return false;
				}
				SentMessages.Add(msg.CallIdx, msg);
			}
			return true;
		}

		bool IHub.HasSentMessageId(ulong id)
		{
			return SentMessages.ContainsKey(id);
		}

		void IHub.Close()
		{
			SentMessages.Clear();
		}

		void IHub.OnMethod(MethodCallMessage msg)
		{
			MergeState(msg.State);
			if (this.OnMethodCall != null)
			{
				try
				{
					this.OnMethodCall(this, msg.Method, msg.Arguments);
				}
				catch (Exception ex)
				{
					HTTPManager.Logger.Exception("Hub - " + Name, "IHub.OnMethod - OnMethodCall", ex);
				}
			}
			OnMethodCallCallbackDelegate value;
			if (MethodTable.TryGetValue(msg.Method, out value) && value != null)
			{
				try
				{
					value(this, msg);
					return;
				}
				catch (Exception ex2)
				{
					HTTPManager.Logger.Exception("Hub - " + Name, "IHub.OnMethod - callback", ex2);
					return;
				}
			}
			HTTPManager.Logger.Warning("Hub - " + Name, string.Format("[Client] {0}.{1} (args: {2})", Name, msg.Method, msg.Arguments.Length));
		}

		void IHub.OnMessage(IServerMessage msg)
		{
			ulong invocationId = (msg as IHubMessage).InvocationId;
			ClientMessage value;
			if (!SentMessages.TryGetValue(invocationId, out value))
			{
				HTTPManager.Logger.Warning("Hub - " + Name, "OnMessage - Sent message not found with id: " + invocationId);
				return;
			}
			switch (msg.Type)
			{
			case MessageTypes.Result:
			{
				ResultMessage resultMessage = msg as ResultMessage;
				MergeState(resultMessage.State);
				if (value.ResultCallback != null)
				{
					try
					{
						value.ResultCallback(this, value, resultMessage);
					}
					catch (Exception ex2)
					{
						HTTPManager.Logger.Exception("Hub " + Name, "IHub.OnMessage - ResultCallback", ex2);
					}
				}
				SentMessages.Remove(invocationId);
				break;
			}
			case MessageTypes.Failure:
			{
				FailureMessage failureMessage = msg as FailureMessage;
				MergeState(failureMessage.State);
				if (value.ResultErrorCallback != null)
				{
					try
					{
						value.ResultErrorCallback(this, value, failureMessage);
					}
					catch (Exception ex3)
					{
						HTTPManager.Logger.Exception("Hub " + Name, "IHub.OnMessage - ResultErrorCallback", ex3);
					}
				}
				SentMessages.Remove(invocationId);
				break;
			}
			case MessageTypes.Progress:
				if (value.ProgressCallback != null)
				{
					try
					{
						value.ProgressCallback(this, value, msg as ProgressMessage);
						break;
					}
					catch (Exception ex)
					{
						HTTPManager.Logger.Exception("Hub " + Name, "IHub.OnMessage - ProgressCallback", ex);
						break;
					}
				}
				break;
			}
		}

		private void MergeState(IDictionary<string, object> state)
		{
			if (state == null || state.Count <= 0)
			{
				return;
			}
			foreach (KeyValuePair<string, object> item in state)
			{
				State[item.Key] = item.Value;
			}
		}

		private string BuildMessage(ClientMessage msg)
		{
			try
			{
				builder.Append("{\"H\":\"");
				builder.Append(Name);
				builder.Append("\",\"M\":\"");
				builder.Append(msg.Method);
				builder.Append("\",\"A\":");
				string empty = string.Empty;
				empty = ((msg.Args == null || msg.Args.Length <= 0) ? "[]" : ((IHub)this).Connection.JsonEncoder.Encode(msg.Args));
				builder.Append(empty);
				builder.Append(",\"I\":\"");
				builder.Append(msg.CallIdx.ToString());
				builder.Append("\"");
				if (msg.Hub.state != null && msg.Hub.state.Count > 0)
				{
					builder.Append(",\"S\":");
					empty = ((IHub)this).Connection.JsonEncoder.Encode(msg.Hub.state);
					builder.Append(empty);
				}
				builder.Append("}");
				return builder.ToString();
			}
			catch (Exception ex)
			{
				HTTPManager.Logger.Exception("Hub - " + Name, "Send", ex);
				return null;
			}
			finally
			{
				builder.Length = 0;
			}
		}
	}
}
