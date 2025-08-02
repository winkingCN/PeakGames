using System;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonSpendData : JsonBaseData
	{
		public string game_session_id;

		public string hc_before_spending;

		public string max_level;

		public string if_life_refill;

		public JsonInventory inventory;
	}
}
