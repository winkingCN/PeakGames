using System;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonBaseData : JsonEventData
	{
		public string aid;

		public string device_id;

		public string app_version;

		public int cl_stage;

		public int cl_id;

		public int online;

		public string shared_id;

		public JsonBaseData()
		{
			if (PeakAnalytics.LOPFOEHECGB == null)
			{
				aid = string.Empty;
				device_id = string.Empty;
				shared_id = string.Empty;
			}
			else
			{
				aid = PeakAnalytics.CGFKMDLHNHP;
				device_id = PeakAnalytics.GetDeviceId();
				shared_id = PeakAnalytics.GetSharedId();
			}
			app_version = "4161";
		}

		public void LLGLAHKBJJG()
		{
			bool flag = IDFPAFEJPPH.GABGKBAKHDP.HGNJBHGBLIN;
			cl_stage = (flag ? IDFPAFEJPPH.GABGKBAKHDP.PDGLECFDLJJ : 0);
			cl_id = (flag ? IDFPAFEJPPH.GABGKBAKHDP.NBJMMBIGCOB : 0);
			online = (JHOAHCHHBCH.CCAJIIFJPFF() ? 1 : 0);
		}
	}
}
