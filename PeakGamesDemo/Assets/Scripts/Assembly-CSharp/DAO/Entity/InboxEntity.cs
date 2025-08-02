using System;
using Assets.Scripts.CasualTools.Common.DB;

namespace DAO.Entity
{
	[Serializable]
	public class InboxEntity : Assets.Scripts.CasualTools.Common.DB.Entity
	{
		public string From;

		public string MessageId;

		public int FromId;

		public int Type;

		public InboxEntity(int? BDKFNEDHAOJ, string LLAEDBFNCCP, string DLALMJPFFMK, int DIKEGACKFFH, int NBFBPNNEKMN)
		{
			PNLKNJNILDD(BDKFNEDHAOJ);
			From = LLAEDBFNCCP;
			MessageId = DLALMJPFFMK;
			FromId = DIKEGACKFFH;
			Type = NBFBPNNEKMN;
		}
	}
}
