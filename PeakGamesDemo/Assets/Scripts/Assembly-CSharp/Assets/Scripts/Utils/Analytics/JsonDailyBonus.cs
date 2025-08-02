using System;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonDailyBonus : JsonBaseData
	{
		public JsonDailyBonusGifts gifts;

		public JsonInventory inventory;
	}
}
