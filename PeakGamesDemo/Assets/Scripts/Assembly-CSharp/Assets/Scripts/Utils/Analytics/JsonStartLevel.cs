using System;
using UnityEngine;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonStartLevel : JsonSessionData
	{
		public static string OSVersion;

		public string device_model;

		public string os_version;

		public string number_of_inbox_lives;

		public JsonInventory inventory;

		public int crown;

		public JsonStartLevel()
		{
			if (OSVersion == null)
			{
				OSVersion = SystemInfo.operatingSystem.Split('(')[0];
			}
			device_model = SystemInfo.deviceModel;
			os_version = OSVersion;
			crown = ((!DIGGBGADIGJ.DFGKPMCBFNL) ? (-1) : DIGGBGADIGJ.GABGKBAKHDP.BGKIIAJNHLL);
		}
	}
}
