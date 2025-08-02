using System.Collections.Generic;
using BestHTTP.Forms;
using BestHTTP.SignalR.Messages;

namespace BestHTTP.SignalR.Transports
{
	public abstract class PostSendTransportBase : TransportBase
	{
		protected List<HTTPRequest> sendRequestQueue = new List<HTTPRequest>();

		public PostSendTransportBase(string name, Connection con)
			: base(name, con)
		{
		}

		protected override void SendImpl(string json)
		{
			HTTPRequest hTTPRequest = new HTTPRequest(base.Connection.BuildUri(RequestTypes.Send, this), HTTPMethods.Post, true, true, OnSendRequestFinished);
			hTTPRequest.FormUsage = HTTPFormUsage.UrlEncoded;
			hTTPRequest.AddField("data", json);
			base.Connection.PrepareRequest(hTTPRequest, RequestTypes.Send);
			hTTPRequest.Priority = -1;
			hTTPRequest.Send();
			sendRequestQueue.Add(hTTPRequest);
		}

		private void OnSendRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
			sendRequestQueue.Remove(req);
			string text = string.Empty;
			switch (req.State)
			{
			case HTTPRequestStates.Finished:
				if (resp.IsSuccess)
				{
					HTTPManager.Logger.Information("Transport - " + base.Name, "Send - Request Finished Successfully! " + resp.DataAsText);
					if (!string.IsNullOrEmpty(resp.DataAsText))
					{
						IServerMessage serverMessage = TransportBase.Parse(base.Connection.JsonEncoder, resp.DataAsText);
						if (serverMessage != null)
						{
							base.Connection.OnMessage(serverMessage);
						}
					}
				}
				else
				{
					text = string.Format("Send - Request Finished Successfully, but the server sent an error. Status Code: {0}-{1} Message: {2}", resp.StatusCode, resp.Message, resp.DataAsText);
				}
				break;
			case HTTPRequestStates.Error:
				text = "Send - Request Finished with Error! " + ((req.Exception == null) ? "No Exception" : (req.Exception.Message + "\n" + req.Exception.StackTrace));
				break;
			case HTTPRequestStates.Aborted:
				text = "Send - Request Aborted!";
				break;
			case HTTPRequestStates.ConnectionTimedOut:
				text = "Send - Connection Timed Out!";
				break;
			case HTTPRequestStates.TimedOut:
				text = "Send - Processing the request Timed Out!";
				break;
			}
			if (!string.IsNullOrEmpty(text))
			{
				base.Connection.Error(text);
			}
		}
	}
}
