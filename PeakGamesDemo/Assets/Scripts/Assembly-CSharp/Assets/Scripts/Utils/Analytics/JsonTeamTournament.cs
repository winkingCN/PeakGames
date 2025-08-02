using System;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonTeamTournament : JsonBaseData
	{
		public int member_count;

		public JsonTeamChestGifts gifts;

		public JsonInventory inventory;
	}
}
