using System;
using Assets.Scripts.GamePlayScene.Mechanics;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonSessionDataWithInventory : JsonBaseData
	{
		public string game_session_id;

		public string gameplay_id;

		public JsonInventory inventory;

		public JsonSessionDataWithInventory()
		{
			game_session_id = PeakAnalytics.SessionId;
			gameplay_id = ((LevelBuilder.ActiveLevel != null) ? LevelBuilder.ActiveLevel.BHHFNLJCCKC : string.Empty);
			inventory = new JsonInventory();
			inventory.LDOCFEGBGNK();
		}
	}
}
