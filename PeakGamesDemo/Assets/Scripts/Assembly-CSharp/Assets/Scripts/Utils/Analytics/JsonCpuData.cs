using System;
using UnityEngine;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonCpuData
	{
		public string aid;

		public string device_id;

		public string user_id;

		public string wifi;

		public JsonCpuData()
		{
			aid = PeakAnalytics.LOPFOEHECGB.GetAnalyticsUserId();
			device_id = PeakAnalytics.GetDeviceId();
			user_id = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString();
			switch (Application.internetReachability)
			{
			case NetworkReachability.NotReachable:
				wifi = "offline";
				break;
			case NetworkReachability.ReachableViaCarrierDataNetwork:
				wifi = "mobile";
				break;
			case NetworkReachability.ReachableViaLocalAreaNetwork:
				wifi = "wifi";
				break;
			}
		}
	}
}
