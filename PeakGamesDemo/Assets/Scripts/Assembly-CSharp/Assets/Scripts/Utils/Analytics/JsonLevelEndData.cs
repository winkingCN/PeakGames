using System;
using Assets.Scripts.GamePlayScene.Mechanics;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonLevelEndData : JsonEventData
	{
		public string aid;

		public string device_id;

		public string app_version;

		public int cl_stage;

		public int cl_id;

		public string game_session_id;

		public string gameplay_id;

		public string user_id;

		public int level;

		public int level_max;

		public string level_name;

		public int number_of_ego_shown;

		public int result;

		public int user_score;

		public int moves_given;

		public int moves_made;

		public int duration;

		public string min_fps;

		public string avg_fps;

		public string max_fps;

		public int under_50_fps;

		public JsonLevelEndInventory data;

		public JsonLevelEndData()
		{
			game_session_id = PeakAnalytics.SessionId;
			gameplay_id = ((LevelBuilder.ActiveLevel != null) ? LevelBuilder.ActiveLevel.BHHFNLJCCKC : string.Empty);
			aid = ((PeakAnalytics.LOPFOEHECGB != null) ? PeakAnalytics.CGFKMDLHNHP : string.Empty);
			device_id = ((PeakAnalytics.LOPFOEHECGB != null) ? PeakAnalytics.GetDeviceId() : string.Empty);
			app_version = "4161";
		}

		public void LLGLAHKBJJG()
		{
			bool flag = IDFPAFEJPPH.GABGKBAKHDP.HGNJBHGBLIN;
			cl_stage = (flag ? IDFPAFEJPPH.GABGKBAKHDP.PDGLECFDLJJ : 0);
			cl_id = (flag ? IDFPAFEJPPH.GABGKBAKHDP.NBJMMBIGCOB : 0);
		}
	}
}
