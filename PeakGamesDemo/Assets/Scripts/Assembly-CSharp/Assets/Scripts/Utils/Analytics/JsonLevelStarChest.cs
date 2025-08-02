using System;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonLevelStarChest : JsonBaseData
	{
		public JsonStarChestGifts gifts;

		public JsonInventory inventory;
	}
}
