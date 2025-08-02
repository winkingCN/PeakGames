using System.Collections.Generic;
using ToonSocial.dialogs;

public class MDFABKJBMNB : MDMLFPDLFLE
{
	private readonly EIPCLBONPLC LNDFJKGAJAK;

	private Dictionary<string, object> LKCKBCLBMMA;

	public MDFABKJBMNB(EIPCLBONPLC JDFMMECNFKB)
		: base(JDFMMECNFKB, true)
	{
		ECCJDODDJMI = "CreateTeamAction";
		LNDFJKGAJAK = JDFMMECNFKB;
	}

	protected override void JFLAAOOBKJD(params object[] MIDCNFGAIFA)
	{
		LNDFJKGAJAK.IPCAELIMIBN.CurrentNotJoinedContainer.CurrentCreateTeamTab.LockFields();
		string value = (string)MIDCNFGAIFA[0];
		string value2 = (string)MIDCNFGAIFA[1];
		string value3 = (string)MIDCNFGAIFA[2];
		int num = (int)MIDCNFGAIFA[3];
		bool flag = (bool)MIDCNFGAIFA[4];
		LKCKBCLBMMA = new Dictionary<string, object>();
		LKCKBCLBMMA["name"] = value;
		LKCKBCLBMMA["desc"] = value2;
		LKCKBCLBMMA["level"] = num;
		LKCKBCLBMMA["badge"] = value3;
		LKCKBCLBMMA["closed"] = (flag ? 1 : 0);
		JDFMMECNFKB.NMGBGAGMOGI.POKBINCNOHP(LKCKBCLBMMA);
	}

	protected override void AONDNIEFKII()
	{
		base.AONDNIEFKII();
		SocialCreateUserDialog.CloseActiveOne();
		LNDFJKGAJAK.IPCAELIMIBN.CurrentNotJoinedContainer.CurrentCreateTeamTab.UnLockFields();
	}

	protected override void DFGLIIBBFEI(params object[] MIDCNFGAIFA)
	{
		bool flag = (bool)MIDCNFGAIFA[0];
		NKILAONHNNE nKILAONHNNE = (NKILAONHNNE)MIDCNFGAIFA[2];
		if (!flag)
		{
			if (nKILAONHNNE.KJLHFILAKOB > 0)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.CreateTeamAction, "Can not create team. Error no: {0} Error Msg: {1}", nKILAONHNNE.KJLHFILAKOB, nKILAONHNNE.ELGCDBGLEIC);
			}
			LNDFJKGAJAK.IPCAELIMIBN.CurrentNotJoinedContainer.CurrentCreateTeamTab.UnLockFields();
		}
		else
		{
			LNDFJKGAJAK.ADCMNJCINBO.OADDPGNIINO = (int)MIDCNFGAIFA[1];
			AFJPGLHKOID.JIPLLFBJBIL(LNDFJKGAJAK.ADCMNJCINBO, 1);
			LNDFJKGAJAK.IPCAELIMIBN.JoinToTeam(LNDFJKGAJAK.ADCMNJCINBO.OADDPGNIINO, null);
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PeakAnalytics, "Event Triggered TeamCreate > TeamId:{0} TeamName:{1} Closed:{2}", LNDFJKGAJAK.ADCMNJCINBO.OADDPGNIINO, LKCKBCLBMMA["name"], ((int)LKCKBCLBMMA["closed"] != 1) ? "Open" : "Closed");
			AFJPGLHKOID.BPEPHMJPIDE(LKCKBCLBMMA, LNDFJKGAJAK);
			MKINMKEMBPL.GABGKBAKHDP.KMPGGMKICLB("JoinTeam");
		}
	}
}
