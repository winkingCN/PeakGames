using System.Collections.Generic;
using Assets.Scripts.MapScene;
using ToonSocial;
using ToonSocial.dialogs;

public class DAKLNDKNNII : MDMLFPDLFLE
{
	private readonly EIPCLBONPLC LNDFJKGAJAK;

	public DAKLNDKNNII(EIPCLBONPLC JDFMMECNFKB)
		: base(JDFMMECNFKB, true)
	{
		ECCJDODDJMI = "LeaveTeamAction";
		LNDFJKGAJAK = JDFMMECNFKB;
	}

	protected override void JFLAAOOBKJD(params object[] MIDCNFGAIFA)
	{
		JDFMMECNFKB.NMGBGAGMOGI.JDOEBMGJIMP();
	}

	protected override void AONDNIEFKII()
	{
		base.AONDNIEFKII();
		if (LeaveTeamDialog.ActiveOne != null)
		{
			LeaveTeamDialog.ActiveOne.SoftClose();
		}
	}

	protected override void DFGLIIBBFEI(params object[] MIDCNFGAIFA)
	{
		bool flag = (bool)MIDCNFGAIFA[0];
		NKILAONHNNE nKILAONHNNE = (NKILAONHNNE)MIDCNFGAIFA[2];
		if (!flag)
		{
			int kJLHFILAKOB = nKILAONHNNE.KJLHFILAKOB;
			if (kJLHFILAKOB == 1000)
			{
				LNDFJKGAJAK.FGEGJIFABCO(nKILAONHNNE.MBDEEBONIFB);
				FDNNLJLFMKI();
			}
			else if (nKILAONHNNE.KJLHFILAKOB > 0)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.LeaveTeamAction, "Can not leave team. Error no: {0} Error Msg: {1}", nKILAONHNNE.KJLHFILAKOB, nKILAONHNNE.ELGCDBGLEIC);
			}
		}
		else
		{
			AKGIJAMHMNA aKGIJAMHMNA = (AKGIJAMHMNA)MIDCNFGAIFA[1];
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LeaveTeamAction, "Leaved from team: {0}", aKGIJAMHMNA);
			IFKNKGAMEGA(aKGIJAMHMNA, LNDFJKGAJAK, 0);
		}
	}

	public static void IFKNKGAMEGA(AKGIJAMHMNA FMEJGLGPIBJ, EIPCLBONPLC PEBICCFPCFE, int ELFEHIKDLIM)
	{
		AFJPGLHKOID.CNAFBPLNECO(PEBICCFPCFE.COPDAKACHFM, FMEJGLGPIBJ.EEFMIHDPJPG, ELFEHIKDLIM);
		int eMNOJOHFMEH = (int)PEBICCFPCFE.COPDAKACHFM.EEFMIHDPJPG;
		int num = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1;
		if (IDFPAFEJPPH.GABGKBAKHDP.HGNJBHGBLIN)
		{
			num += IDFPAFEJPPH.GABGKBAKHDP.PDGLECFDLJJ;
		}
		HLFNMNPLJCP.GABGKBAKHDP.ALOPBFOLFOE(eMNOJOHFMEH, -num);
		FIFPLICICKP.GABGKBAKHDP.DIJBPMMKPAE(null);
		FFGIDMDAGOA.GABGKBAKHDP.DIJBPMMKPAE(null);
		if (MapManager.Instance != null)
		{
			MapManager.Instance.CurrentLeaderboardPageController.UpdateLeaderboardScrolls();
			MapManager.Instance.CurrentLeaderboardPageController.CurrentFacebookLeaderboardTabPage.UpdateNotConnectedContainer(null);
		}
		IIDDEGDKLBE(FMEJGLGPIBJ.EEFMIHDPJPG, PEBICCFPCFE.COPDAKACHFM.EEFMIHDPJPG);
		PEBICCFPCFE.COPDAKACHFM = null;
		PEBICCFPCFE.ADCMNJCINBO = FMEJGLGPIBJ;
		PEBICCFPCFE.IPCAELIMIBN.SwitchState(MGGEJMGBEBE.NotJoinedToAnyTeam);
		PEBICCFPCFE.IPCAELIMIBN.CurrentJoinedContainer.ChatTab.ClearAll();
		PEBICCFPCFE.IPCAELIMIBN.CurrentJoinedContainer.ChatTab.CurrentAskLifeNotificationIcon.UpdateCount(0);
		LECPGNKOABP.GABGKBAKHDP.AIFPMKNFFJI(0L, string.Empty, 0);
		if (ELFEHIKDLIM == 0 || ELFEHIKDLIM != 1)
		{
			SocialHelper.AKIJLCCOAPB = false;
		}
		else
		{
			PEBICCFPCFE.IPCAELIMIBN.CurrentJoinedContainer.ChatTab.UpdateSocialNoticeMark();
		}
		if (LeaveTeamDialog.ActiveOne != null)
		{
			LeaveTeamDialog.ActiveOne.SoftClose();
		}
	}

	private static void IIDDEGDKLBE(long BPKJLGJDFKG, long EMNOJOHFMEH)
	{
		KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
		{
			new JDOKMBCDMLO(2, BPKJLGJDFKG, EMNOJOHFMEH)
		});
		AAPMDEEMEMM aAPMDEEMEMM = DGOMNDMPMBG.GABGKBAKHDP.BHGCBNAMEFK;
		if (aAPMDEEMEMM != null)
		{
			aAPMDEEMEMM.LCBIJOLOHKM(false);
		}
		KCKDNJOMPJH kCKDNJOMPJH = DGOMNDMPMBG.GABGKBAKHDP.FABKMFCBELE;
		if (kCKDNJOMPJH != null)
		{
			kCKDNJOMPJH.LCBIJOLOHKM(kCKDNJOMPJH.AEPLIGFCGIF > 1);
		}
	}
}
