using System;
using UnityEngine;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonCpu
	{
		public string user_id;

		public string wifi;

		public string shared_id;

		public JsonCpu()
		{
			user_id = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString();
			shared_id = PeakAnalytics.GetSharedId();
			switch (Application.internetReachability)
			{
			default:
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
