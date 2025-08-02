using System;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonBuyCoinsData : JsonSessionData
	{
		public string max_level;

		public string if_life_refill;

		public JsonInventory inventory;

		public JsonBuyCoinsData()
		{
			max_level = (MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1).ToString();
			inventory = new JsonInventory();
			inventory.LDOCFEGBGNK();
		}
	}
}
