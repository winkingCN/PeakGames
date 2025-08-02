using System;

public class IGKNEDGLOHA : MDMLFPDLFLE
{
	public delegate void CGGJNGDIKAA(bool EEKJMDHEJCK, long EMNOJOHFMEH);

	public event CGGJNGDIKAA BHAHMPONDOL;

	public IGKNEDGLOHA(EIPCLBONPLC JDFMMECNFKB)
		: base(JDFMMECNFKB, false)
	{
		ECCJDODDJMI = "EditTeamAction";
	}

	protected override void JFLAAOOBKJD(params object[] MIDCNFGAIFA)
	{
		JDFMMECNFKB.NMGBGAGMOGI.EGHCONCIBKE((string)MIDCNFGAIFA[0], (int)MIDCNFGAIFA[1], (int)MIDCNFGAIFA[2]);
	}

	protected override void DFGLIIBBFEI(params object[] MIDCNFGAIFA)
	{
		if ((bool)MIDCNFGAIFA[0])
		{
			long eMNOJOHFMEH = Convert.ToInt64(MIDCNFGAIFA[1]);
			this.BHAHMPONDOL(true, eMNOJOHFMEH);
			return;
		}
		NKILAONHNNE nKILAONHNNE = (NKILAONHNNE)MIDCNFGAIFA[2];
		GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.OneAction, "EditTeamAction PerformAfterAction Error:{0} Code:{1}", nKILAONHNNE.ELGCDBGLEIC, nKILAONHNNE.KJLHFILAKOB);
		this.BHAHMPONDOL(false, -1L);
	}
}
