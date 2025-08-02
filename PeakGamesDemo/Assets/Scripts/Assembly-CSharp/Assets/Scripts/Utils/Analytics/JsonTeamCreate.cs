using System;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonTeamCreate : JsonBaseData
	{
		public int required_level;

		public string country;

		public string badge_id;

		public string team_description;

		public JsonSocialInventoryHC inventory;
	}
}
