using System;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonFacebookConnectData : JsonBaseData
	{
		public int max_level_after;

		public string connect_from;
	}
}
