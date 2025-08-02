using System;
using Assets.Scripts.CasualTools.Common.DB;

namespace DAO.Entity
{
	[Serializable]
	public class EventEntity : Assets.Scripts.CasualTools.Common.DB.Entity
	{
		public new int Id;

		public int Type;

		public int EndTime;

		public int MinLevel;

		public int MaxLevel;

		public int Version;

		public int Eligible;

		public string Data;

		public int Filter;

		public EventEntity(int BDKFNEDHAOJ, int NBFBPNNEKMN, int HMBONMAMAKL, int LNGKCGBLFPA, int OJFPANPILAK, int IJCIIHNLIKA, int DFCJKBHFPMG, int AMGEDPDJPNE, string MBBPBGHKLJM)
		{
			PNLKNJNILDD(BDKFNEDHAOJ);
			Id = BDKFNEDHAOJ;
			Type = NBFBPNNEKMN;
			EndTime = HMBONMAMAKL;
			MinLevel = LNGKCGBLFPA;
			MaxLevel = OJFPANPILAK;
			Filter = IJCIIHNLIKA;
			Version = DFCJKBHFPMG;
			Eligible = AMGEDPDJPNE;
			Data = MBBPBGHKLJM;
		}
	}
}
