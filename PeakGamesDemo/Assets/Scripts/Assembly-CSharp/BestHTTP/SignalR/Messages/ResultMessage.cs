using System.Collections.Generic;

namespace BestHTTP.SignalR.Messages
{
	public sealed class ResultMessage : IServerMessage, IHubMessage
	{
		MessageTypes IServerMessage.Type
		{
			get
			{
				return MessageTypes.Result;
			}
		}

		public ulong InvocationId { get; private set; }

		public object ReturnValue { get; private set; }

		public IDictionary<string, object> State { get; private set; }

		void IServerMessage.Parse(object data)
		{
			IDictionary<string, object> dictionary = data as IDictionary<string, object>;
			InvocationId = ulong.Parse(dictionary["I"].ToString());
			object value;
			if (dictionary.TryGetValue("R", out value))
			{
				ReturnValue = value;
			}
			if (dictionary.TryGetValue("S", out value))
			{
				State = value as IDictionary<string, object>;
			}
		}
	}
}
