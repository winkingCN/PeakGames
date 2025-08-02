using System;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonTeamJoin : JsonBaseData
	{
		public int team_member_count_after;

		public int team_score;

		public int weekly_helps;
	}
}
