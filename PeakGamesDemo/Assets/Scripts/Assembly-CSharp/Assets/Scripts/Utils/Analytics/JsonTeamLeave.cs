using System;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonTeamLeave : JsonTeamJoin
	{
		public int team_leader_id;
	}
}
