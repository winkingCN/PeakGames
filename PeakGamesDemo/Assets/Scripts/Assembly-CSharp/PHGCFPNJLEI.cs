using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Tutorials;
using Assets.Scripts.MapScene;
using Dialogs;
using ToonSocial;
using ToonSocial.dialogs;
using ToonSocial.ui.joined;
using UnityEngine;
using caravan.protobuf.messages;

public class PHGCFPNJLEI : MDMLFPDLFLE
{
	[CompilerGenerated]
	private sealed class DJHGKDHHCNB
	{
		internal DKBEJLGEAOA IIIMBFFNNBN;

		internal PHGCFPNJLEI PDAPIGLEPGC;

		internal void AGFNGEFDHLA(bool EEKJMDHEJCK, ClUserScoresResponseMessage OMJOIIOONMO)
		{
			if (!EEKJMDHEJCK || OMJOIIOONMO.member == null || OMJOIIOONMO.member.Count <= 0)
			{
				PDAPIGLEPGC.LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.MyTeamTab.UpdateTeamMembers();
				return;
			}
			foreach (ClMember item in OMJOIIOONMO.member)
			{
				long result;
				long.TryParse(item.id, out result);
				if (result != 0)
				{
					IIIMBFFNNBN.HOINIMJNGFK[result].GGBEMNJNAEE = item.score;
				}
			}
			PDAPIGLEPGC.LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.MyTeamTab.UpdateTeamMembers();
		}
	}

	private readonly EIPCLBONPLC LNDFJKGAJAK;

	private long NAFGCOIHBGL;

	private TeamEntry DAPGKJKKBJC;

	private int FCOGHAOPNEH;

	public const int IMHDDJCCCOF = 0;

	public const int NBKKOPDPAPG = 1;

	public const int KFHHNACHBKM = 2;

	public const int MGFPMLIJDFJ = 3;

	public const int HNFMAFHJJPP = 4;

	public const int LEKOFJHLDLF = 5;

	public const int CKMJDAAIOLC = 6;

	public const int PHAEJNKJCOC = 7;

	public static int? DEIDLKIBDOB;

	public const string OBEOMOGKEOC = "Join";

	public const string NDADHAOJILN = "Change";

	public const string OMLIBNHECNO = "Create";

	public const string GJJKDDMJHGN = "Accept";

	public static string DCPADMOLNML = string.Empty;

	public const string KAPOMHJEOJF = "social_team_";

	public PHGCFPNJLEI(EIPCLBONPLC JDFMMECNFKB)
		: base(JDFMMECNFKB, true)
	{
		ECCJDODDJMI = "JoinTeamAction";
		LNDFJKGAJAK = JDFMMECNFKB;
	}

	protected override void JFLAAOOBKJD(params object[] MIDCNFGAIFA)
	{
		LNDFJKGAJAK.IPCAELIMIBN.CurrentNotJoinedContainer.CurrentCreateTeamTab.LockFields();
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.JoinTeamAction, "Performing joining to team.");
		LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.ChatTab.ClearAll();
		NAFGCOIHBGL = (long)MIDCNFGAIFA[0];
		DAPGKJKKBJC = (TeamEntry)MIDCNFGAIFA[1];
		FCOGHAOPNEH = 0;
		if (DAPGKJKKBJC != null && DAPGKJKKBJC.MMDABIBEGEO != null)
		{
			FCOGHAOPNEH = (int)(Time.realtimeSinceStartup - DAPGKJKKBJC.MMDABIBEGEO.FGEEJNGADHH);
		}
		JDFMMECNFKB.NMGBGAGMOGI.PECEKGJPKAI(NAFGCOIHBGL);
	}

	protected override void AONDNIEFKII()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.JoinTeamAction, "Cancelling joining to team.");
		base.AONDNIEFKII();
		SocialCreateUserDialog.CloseActiveOne();
		TeamInfoJoinDialog.CloseActiveOne();
	}

	protected override void DFGLIIBBFEI(params object[] MIDCNFGAIFA)
	{
		bool flag = (bool)MIDCNFGAIFA[0];
		LNDFJKGAJAK.IPCAELIMIBN.CurrentNotJoinedContainer.CurrentCreateTeamTab.UnLockFields();
		if (!flag)
		{
			NKILAONHNNE nKILAONHNNE = (NKILAONHNNE)MIDCNFGAIFA[2];
			switch (nKILAONHNNE.KJLHFILAKOB)
			{
			case 1000:
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.JoinTeamAction, "Host change is needed:" + nKILAONHNNE.MBDEEBONIFB);
				LNDFJKGAJAK.FGEGJIFABCO(nKILAONHNNE.MBDEEBONIFB);
				FDNNLJLFMKI(NAFGCOIHBGL, DAPGKJKKBJC);
				break;
			case 3004:
			{
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Pending"));
				if (GFIEJLKCDDD.GABGKBAKHDP != null)
				{
					GFIEJLKCDDD.GABGKBAKHDP.NDAIFGNIADD();
				}
				string iKNCPEPOKGJ = HMHDPEOJPNJ(NAFGCOIHBGL);
				MKINMKEMBPL.GABGKBAKHDP.KMPGGMKICLB(iKNCPEPOKGJ);
				string text = string.Empty;
				if (DAPGKJKKBJC != null)
				{
					text = DAPGKJKKBJC.MMDABIBEGEO.AFPDGDAEENM.ToString();
				}
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PeakAnalytics, "Event Triggered {0} > TeamId:{1} Manager:{2}", "ClosedTeamRequest", NAFGCOIHBGL, text);
				AFJPGLHKOID.CPIGOAGGLBM("ClosedTeamRequest", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), NAFGCOIHBGL.ToString(), text);
				if (!(DAPGKJKKBJC == null))
				{
					DAPGKJKKBJC.UpdateButtonStyle();
				}
				break;
			}
			case 3015:
			{
				int num = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1;
				int kOPMPMIFHNF = nKILAONHNNE.KOPMPMIFHNF;
				if (num < kOPMPMIFHNF)
				{
					MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_LowLevel"));
					break;
				}
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.JoinTeamAction, "Can not join. Client: {0}. Server:{1}. Message:{2}", num, kOPMPMIFHNF, nKILAONHNNE.ELGCDBGLEIC);
				LNDFJKGAJAK.IPCAELIMIBN.RequestLevelUpdate();
				FDNNLJLFMKI(NAFGCOIHBGL, DAPGKJKKBJC);
				break;
			}
			case 3005:
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.JoinTeamAction, "User is rejected from team:");
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Rejected"));
				break;
			case 3003:
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.JoinTeamAction, "Team is full");
				if (DAPGKJKKBJC.getReferal() == 0)
				{
					AFJPGLHKOID.EMAFFMGNPEO(DAPGKJKKBJC.OADDPGNIINO, FCOGHAOPNEH);
				}
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_TeamFull"));
				break;
			case 3006:
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.JoinTeamAction, "User is kicked from team");
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Kicked"));
				break;
			default:
				if (nKILAONHNNE.KJLHFILAKOB > 0)
				{
					GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.JoinTeamAction, "Can not join to team. Error no: {0} Error Msg: {1}", nKILAONHNNE.KJLHFILAKOB, nKILAONHNNE.ELGCDBGLEIC);
				}
				break;
			}
			return;
		}
		JPLIGBJJCOE jPLIGBJJCOE = (JPLIGBJJCOE)MIDCNFGAIFA[1];
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.JoinTeamAction, "Join team succeded.");
		if (!DCPADMOLNML.Equals(string.Empty) && (!GFHPEDILAJG.GABGKBAKHDP.ODMCGBLJFKM || (LNDFJKGAJAK.COPDAKACHFM != null && LNDFJKGAJAK.COPDAKACHFM.EEFMIHDPJPG != jPLIGBJJCOE.NJHFLHNDFHH.EEFMIHDPJPG)))
		{
			AFJPGLHKOID.LLKGLKPILOK(jPLIGBJJCOE, DCPADMOLNML, DEIDLKIBDOB);
			int num2 = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1;
			if (IDFPAFEJPPH.GABGKBAKHDP.HGNJBHGBLIN)
			{
				num2 += IDFPAFEJPPH.GABGKBAKHDP.PDGLECFDLJJ;
			}
			DKBEJLGEAOA nJHFLHNDFHH = jPLIGBJJCOE.NJHFLHNDFHH;
			HLFNMNPLJCP.GABGKBAKHDP.ALOPBFOLFOE((int)nJHFLHNDFHH.EEFMIHDPJPG, num2);
			FIFPLICICKP.GABGKBAKHDP.DIJBPMMKPAE(nJHFLHNDFHH);
			FFGIDMDAGOA.GABGKBAKHDP.DIJBPMMKPAE(nJHFLHNDFHH);
			if (MapManager.Instance != null)
			{
				MapManager.Instance.CurrentLeaderboardPageController.UpdateLeaderboardScrolls();
				MapManager.Instance.CurrentLeaderboardPageController.CurrentFacebookLeaderboardTabPage.UpdateNotConnectedContainer(nJHFLHNDFHH);
			}
		}
		GFHPEDILAJG.GABGKBAKHDP.ODMCGBLJFKM = true;
		IKFJHGLKAHI();
		MapTutorial.CompleteSocialTutorial();
		int num3 = OIAJPMNJGLK.HOGCELOOGEP();
		foreach (KeyValuePair<long, AKGIJAMHMNA> item in jPLIGBJJCOE.NJHFLHNDFHH.HOINIMJNGFK)
		{
			if (num3 > item.Value.KEMNAAPNAPA)
			{
				item.Value.KFBCFDALGBB = 0L;
			}
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.JoinTeamAction, "Joined to team: {0}", jPLIGBJJCOE.NJHFLHNDFHH);
		NFOHNGBMIMG(jPLIGBJJCOE.NJHFLHNDFHH);
		LNDFJKGAJAK.COPDAKACHFM = jPLIGBJJCOE.NJHFLHNDFHH;
		LNDFJKGAJAK.ADCMNJCINBO.OADDPGNIINO = LNDFJKGAJAK.COPDAKACHFM.EEFMIHDPJPG;
		LNDFJKGAJAK.NMGBGAGMOGI.JIJCMCPHPLG();
		LNDFJKGAJAK.IPCAELIMIBN.CurrentNotJoinedContainer.CurrentSearchTab.ClearText();
		LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.UpdateOfflineUserCounts();
		LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.UpdateTeamNames();
		OPMMGIBKNHH(jPLIGBJJCOE);
		LNDFJKGAJAK.IPCAELIMIBN.SwitchState(MGGEJMGBEBE.JoinedToTeam);
		LNDFJKGAJAK.IPCAELIMIBN.RequestInbox();
		MKINMKEMBPL.GABGKBAKHDP.JIIFLHPECME("social_team_");
		IBNAFFHFMGC(jPLIGBJJCOE.FLPEILFNDPO);
		DKBEJLGEAOA dKBEJLGEAOA = LNDFJKGAJAK.COPDAKACHFM;
		int mIJNCHHBBCA = ((dKBEJLGEAOA.HOINIMJNGFK != null) ? dKBEJLGEAOA.HOINIMJNGFK.Count : 0);
		LECPGNKOABP.GABGKBAKHDP.AIFPMKNFFJI(dKBEJLGEAOA.EEFMIHDPJPG, dKBEJLGEAOA.PNGPLGHKFDI, mIJNCHHBBCA);
		AFJPGLHKOID.JIPLLFBJBIL(LNDFJKGAJAK.ADCMNJCINBO, 0);
		LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.ChatTab.ResetMessages();
		for (int num4 = jPLIGBJJCOE.GEPCKJFBMGK.Count - 1; num4 >= 0; num4--)
		{
			if (!jPLIGBJJCOE.BPDHDONGANE.Contains(jPLIGBJJCOE.GEPCKJFBMGK[num4].EEFMIHDPJPG))
			{
				LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.ChatTab.AddMessage(jPLIGBJJCOE.GEPCKJFBMGK[num4], true);
			}
		}
		LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.ChatTab.ScrollToBottom();
		if (MapManager.Instance != null)
		{
			MapManager.Instance.CurrentLeaderboardPageController.CurrentFacebookLeaderboardTabPage.UpdateNotConnectedContainer(LNDFJKGAJAK.COPDAKACHFM);
		}
		if (GFIEJLKCDDD.GABGKBAKHDP != null)
		{
			GFIEJLKCDDD.GABGKBAKHDP.NDAIFGNIADD();
		}
		MKINMKEMBPL.GABGKBAKHDP.KMPGGMKICLB("JoinTeam");
	}

	private void IKFJHGLKAHI()
	{
		LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.ChatTab.UpdateSocialNoticeMark();
		SocialHelper.AKIJLCCOAPB = true;
	}

	public static string HMHDPEOJPNJ(long OKKNDAJHPOJ)
	{
		return "social_team_" + OKKNDAJHPOJ;
	}

	private void OPMMGIBKNHH(JPLIGBJJCOE ECBDGMPPBKF)
	{
		Sprite badge = LNDFJKGAJAK.IPCAELIMIBN.BadgesDictionary.GetBadge(ECBDGMPPBKF.NJHFLHNDFHH.FGPGOGEKDAM);
		LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.MyTeamTab.TeamBadge.sprite = badge;
		LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.ChatTab.TeamBadge.sprite = badge;
	}

	private void IBNAFFHFMGC(long GMBFFEPCOKG)
	{
		NBBAAJENFFN value;
		LNDFJKGAJAK.COPDAKACHFM.MCDNAIGOMAK.TryGetValue(LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM, out value);
		bool flag = false;
		if (value != null && value.GKHHFKEJNAL - GMBFFEPCOKG > 0)
		{
			flag = true;
			LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.ChatTab.SetAskLifeTime(GMBFFEPCOKG, value.GKHHFKEJNAL);
		}
		if (!flag)
		{
			LNDFJKGAJAK.NMGBGAGMOGI.LOMBPFAIGKF();
		}
	}

	private NCJDJEAGMLL FDIPDCBHOMM(DKBEJLGEAOA IIIMBFFNNBN)
	{
		if (IIIMBFFNNBN == null || IIIMBFFNNBN.HOINIMJNGFK == null || IIIMBFFNNBN.HOINIMJNGFK.Count <= 0)
		{
			LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.MyTeamTab.UpdateTeamMembers();
			return null;
		}
		List<long> list = new List<long>();
		foreach (KeyValuePair<long, AKGIJAMHMNA> item in IIIMBFFNNBN.HOINIMJNGFK)
		{
			if (item.Value != null && item.Value.CALJBGILMOL >= IMLNKMACKMF.GABGKBAKHDP.PCBNDMDMAHJ)
			{
				list.Add(item.Value.EEFMIHDPJPG);
			}
		}
		if (list.Count <= 0)
		{
			LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.MyTeamTab.UpdateTeamMembers();
			return null;
		}
		return new NCJDJEAGMLL(list, delegate(bool EEKJMDHEJCK, ClUserScoresResponseMessage OMJOIIOONMO)
		{
			if (!EEKJMDHEJCK || OMJOIIOONMO.member == null || OMJOIIOONMO.member.Count <= 0)
			{
				LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.MyTeamTab.UpdateTeamMembers();
			}
			else
			{
				foreach (ClMember item2 in OMJOIIOONMO.member)
				{
					long result;
					long.TryParse(item2.id, out result);
					if (result != 0)
					{
						IIIMBFFNNBN.HOINIMJNGFK[result].GGBEMNJNAEE = item2.score;
					}
				}
				LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.MyTeamTab.UpdateTeamMembers();
			}
		});
	}

	private static IOCEEPMIBLN MPDDEMLPOAP(DKBEJLGEAOA IIIMBFFNNBN)
	{
		if (IIIMBFFNNBN == null || IIIMBFFNNBN.EEFMIHDPJPG == 0)
		{
			return null;
		}
		AAPMDEEMEMM aAPMDEEMEMM = DGOMNDMPMBG.GABGKBAKHDP.BHGCBNAMEFK;
		if (aAPMDEEMEMM == null)
		{
			return null;
		}
		if (LECPGNKOABP.GABGKBAKHDP.OADDPGNIINO != 0 && aAPMDEEMEMM.OPBAEEEGPDE != null)
		{
			return null;
		}
		aAPMDEEMEMM.LCBIJOLOHKM(true);
		aAPMDEEMEMM = DGOMNDMPMBG.GABGKBAKHDP.BHGCBNAMEFK;
		return (aAPMDEEMEMM != null) ? new IOCEEPMIBLN(IIIMBFFNNBN.EEFMIHDPJPG, aAPMDEEMEMM.IFOAAOCJODG) : null;
	}

	private static List<IKDMCJPBBIH> IPNMGALACFO(DKBEJLGEAOA IIIMBFFNNBN)
	{
		List<IKDMCJPBBIH> list = new List<IKDMCJPBBIH>();
		if (IIIMBFFNNBN == null || IIIMBFFNNBN.EEFMIHDPJPG == 0)
		{
			return list;
		}
		LECPGNKOABP lECPGNKOABP = LECPGNKOABP.GABGKBAKHDP;
		if (lECPGNKOABP.OADDPGNIINO == IIIMBFFNNBN.EEFMIHDPJPG)
		{
			return list;
		}
		list.Add(new JDOKMBCDMLO(1, lECPGNKOABP.GDMECFECCOM, IIIMBFFNNBN.EEFMIHDPJPG));
		KCKDNJOMPJH kCKDNJOMPJH = DGOMNDMPMBG.GABGKBAKHDP.FABKMFCBELE;
		if (kCKDNJOMPJH == null)
		{
			return list;
		}
		list.Add(new FBNFMCGHLEE(kCKDNJOMPJH.IFOAAOCJODG, kCKDNJOMPJH.INFAGKCBEHL, IIIMBFFNNBN.EEFMIHDPJPG));
		return list;
	}

	private void NFOHNGBMIMG(DKBEJLGEAOA IIIMBFFNNBN)
	{
		NCJDJEAGMLL nCJDJEAGMLL = FDIPDCBHOMM(IIIMBFFNNBN);
		IOCEEPMIBLN iOCEEPMIBLN = MPDDEMLPOAP(IIIMBFFNNBN);
		List<IKDMCJPBBIH> list = IPNMGALACFO(IIIMBFFNNBN);
		List<IKDMCJPBBIH> list2 = new List<IKDMCJPBBIH>();
		if (nCJDJEAGMLL != null)
		{
			list2.Add(nCJDJEAGMLL);
		}
		if (iOCEEPMIBLN != null)
		{
			list2.Add(iOCEEPMIBLN);
		}
		if (list.Count > 0)
		{
			list2.AddRange(list);
		}
		if (list2.Count > 0)
		{
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(list2);
		}
	}
}
