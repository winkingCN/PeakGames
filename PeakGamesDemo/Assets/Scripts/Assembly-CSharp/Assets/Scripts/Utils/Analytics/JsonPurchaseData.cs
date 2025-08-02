using System;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonPurchaseData : JsonBaseData
	{
		public string game_session_id;

		public string product_id;

		public string error_code;

		public string hc_before_purchase;

		public string trigger_reason;

		public string max_level;

		public string if_life_refill;

		public string transaction_id;

		public int genuiene;

		public int jail;

		public string orderId;

		public JsonInventory inventory;

		public JsonPurchaseData()
		{
			game_session_id = PeakAnalytics.SessionId;
		}
	}
}
