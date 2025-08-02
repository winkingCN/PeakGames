using System;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonTreasureHunt : JsonBaseData
	{
		public int key_goal;

		public int key_collected;

		public JsonTreasureHuntGifts gifts;

		public JsonInventory inventory;
	}
}
