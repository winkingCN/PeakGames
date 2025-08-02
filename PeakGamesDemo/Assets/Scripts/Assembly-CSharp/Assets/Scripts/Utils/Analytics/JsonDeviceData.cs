using System;
using UnityEngine;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonDeviceData : JsonSessionData
	{
		public static string OSVersion;

		public string device_model;

		public string os_version;

		public JsonDeviceData()
		{
			if (OSVersion == null)
			{
				OSVersion = SystemInfo.operatingSystem.Split('(')[0];
			}
			device_model = SystemInfo.deviceModel;
			os_version = OSVersion;
		}
	}
}
