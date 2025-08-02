using System;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonFacebookDisconnectData : JsonFacebookConnectData
	{
		public string discon_type;
	}
}
