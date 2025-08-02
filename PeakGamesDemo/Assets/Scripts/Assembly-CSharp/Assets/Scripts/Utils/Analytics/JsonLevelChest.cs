using System;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonLevelChest : JsonBaseData
	{
		public JsonToonChestGifts gifts;

		public JsonInventory inventory;
	}
}
