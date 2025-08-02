using System;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonTeamEdit : JsonBaseData
	{
		public string country;

		public string badge_id;

		public string team_description;

		public string team_description_before;

		public int required_level;

		public int required_level_before;

		public int team_type_before;
	}
}
