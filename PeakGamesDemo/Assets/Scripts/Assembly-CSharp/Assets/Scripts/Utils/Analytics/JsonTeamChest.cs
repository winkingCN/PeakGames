using System;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonTeamChest : JsonBaseData
	{
		public int star_count_goal;

		public int star_count_collected;

		public JsonTeamChestGifts gifts;

		public JsonInventory inventory;
	}
}
