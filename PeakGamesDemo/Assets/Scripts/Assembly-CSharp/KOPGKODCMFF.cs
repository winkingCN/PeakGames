using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Assets.Scripts.MapScene;
using BestHTTP.SocketIO;

public class KOPGKODCMFF : MJLNBKKHIPP
{
	private readonly SocketManager NLFNJGBPDEL;

	private readonly EIPCLBONPLC LNDFJKGAJAK;

	private Dictionary<int, Action<bool, IOrderedEnumerable<NCGNBHMMFKN>>> EBMCLGHCIFM = new Dictionary<int, Action<bool, IOrderedEnumerable<NCGNBHMMFKN>>>();

	[CompilerGenerated]
	private static Func<object, PONCCEHNOOM> EBCOMJBLIPP;

	[CompilerGenerated]
	private static Func<NCGNBHMMFKN, long> DNBOPLHGMHA;

	[CompilerGenerated]
	private static Func<NCGNBHMMFKN, long> JFHCKLHBBDI;

	[CompilerGenerated]
	private static Func<NCGNBHMMFKN, long> NOGHOEBDKAH;

	public KOPGKODCMFF(SocketManager BMJLBDOKDPD, EIPCLBONPLC PEBICCFPCFE)
	{
		NLFNJGBPDEL = BMJLBDOKDPD;
		LNDFJKGAJAK = PEBICCFPCFE;
		NLFNJGBPDEL.Socket.On("response-suggest-team", BCPICMNOKNE);
		NLFNJGBPDEL.Socket.On("response-join-team", KBNKLOKJGNC);
		NLFNJGBPDEL.Socket.On("response-leave-team", JNELDOGIAGB);
		NLFNJGBPDEL.Socket.On("response-list-online", BLHAKBGCKJK);
		NLFNJGBPDEL.Socket.On("response-create-team", JONOBIPIHFG);
		NLFNJGBPDEL.Socket.On("response-search-team", OIPGPOLIHMA);
		NLFNJGBPDEL.Socket.On("response-accept-req", DJLCFJMFIAG);
		NLFNJGBPDEL.Socket.On("response-deny-req", JKHLDFGJGPL);
		NLFNJGBPDEL.Socket.On("response-help-user", EDBKPNBNMLJ);
		NLFNJGBPDEL.Socket.On("response-ask-help", BKJIMPDDMJK);
		NLFNJGBPDEL.Socket.On("response-read-inbox", KIBNHPCAHEF);
		NLFNJGBPDEL.Socket.On("response-show-my-help", JENBPMEHPBM);
		NLFNJGBPDEL.Socket.On("response-kick-user", FOGMKIIFPHI);
		NLFNJGBPDEL.Socket.On("response-team-members", INPHADGIGPF);
		NLFNJGBPDEL.Socket.On("response-edit-team-info", MBBIODALEOG);
		NLFNJGBPDEL.Socket.On("do-inform-can-join", BPJIGGFKLJB);
		NLFNJGBPDEL.Socket.On("do-list-requests", JFPBILNEOPA);
		NLFNJGBPDEL.Socket.On("do-inform-new-request", OBFHJMEMHOG);
		NLFNJGBPDEL.Socket.On("do-be-kicked", IKJBEFOOEGP);
	}

	private void JENBPMEHPBM(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		NKILAONHNNE nKILAONHNNE = ADBKCDPFMGN(MIDCNFGAIFA);
		if (nKILAONHNNE == null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SocialTeamModule, "Response to ResponseShowMyHelp OK.");
			object obj = MIDCNFGAIFA[1];
			NBBAAJENFFN nBBAAJENFFN = new NBBAAJENFFN((Dictionary<string, object>)obj);
			LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.ChatTab.SetAskLifeTime(nBBAAJENFFN.FLPEILFNDPO, nBBAAJENFFN.GKHHFKEJNAL);
		}
		else
		{
			LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.ChatTab.SetAskLifeTime(nKILAONHNNE.FLPEILFNDPO, nKILAONHNNE.PFNNFPIDHFN);
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.SocialTeamModule, "Response to ResponseShowMyHelp PROBLEM:{1} / {0}", nKILAONHNNE.ELGCDBGLEIC, nKILAONHNNE.KJLHFILAKOB);
		}
	}

	private void EDBKPNBNMLJ(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		NKILAONHNNE nKILAONHNNE = ADBKCDPFMGN(MIDCNFGAIFA);
		if (nKILAONHNNE == null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SocialTeamModule, "Response to ResponseHelpUser OK.");
			object obj = MIDCNFGAIFA[1];
			NBBAAJENFFN nBBAAJENFFN = new NBBAAJENFFN((Dictionary<string, object>)obj);
			int aCFDIDGFPKJ = GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Coins, BOKGFGFPOHD.AKELGEHLLNC.FDNCJEHPFFJ);
			GEBAAFFGKJG.GABGKBAKHDP.IBFMAELGBGP(aCFDIDGFPKJ);
			LNDFJKGAJAK.IPCAELIMIBN.CurrentMapUIAnimationController.StartCoinCollectAnimationWithKey(BOKGFGFPOHD.AKELGEHLLNC.FDNCJEHPFFJ, "LifeReq" + nBBAAJENFFN.OCHADBCJEDP);
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PeakAnalytics, "Event Triggered {0} > TeamId:{1} MemberCount:{2} OnlineCount:{3}", "LifeHelp", LNDFJKGAJAK.COPDAKACHFM.EEFMIHDPJPG.ToString(), LNDFJKGAJAK.COPDAKACHFM.GMCGMPEEHJP, LNDFJKGAJAK.COPDAKACHFM.GMCGMPEEHJP);
			AFJPGLHKOID.ECOEKHPKHAM(LNDFJKGAJAK, nBBAAJENFFN.MDGBOKGEBHM);
		}
		else if (nKILAONHNNE.KJLHFILAKOB == 3016)
		{
			int num = (int)(nKILAONHNNE.PFNNFPIDHFN / 1000);
			int gDMECFECCOM = nKILAONHNNE.GDMECFECCOM;
			LNDFJKGAJAK.IPCAELIMIBN.CurrentMapUIAnimationController.InformTeamLeaveAndRequestLimit(num, gDMECFECCOM);
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SocialTeamModule, "Leave team cooldown to help user");
		}
		else
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.SocialTeamModule, "Response to ResponseHelpUser PROBLEM:{1} / {0}", nKILAONHNNE.ELGCDBGLEIC, nKILAONHNNE.KJLHFILAKOB);
		}
	}

	private void BKJIMPDDMJK(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		NKILAONHNNE nKILAONHNNE = ADBKCDPFMGN(MIDCNFGAIFA);
		if (nKILAONHNNE == null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SocialTeamModule, "Response to ResponseAskHelp OK.");
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PeakAnalytics, "Event Triggered {0} > TeamId:{1} MemberCount:{2} OnlineCount:{3}", "LifeAsk", LNDFJKGAJAK.COPDAKACHFM.EEFMIHDPJPG.ToString(), LNDFJKGAJAK.COPDAKACHFM.GMCGMPEEHJP, LNDFJKGAJAK.COPDAKACHFM.GMCGMPEEHJP);
			NBBAAJENFFN nBBAAJENFFN = new NBBAAJENFFN((Dictionary<string, object>)MIDCNFGAIFA[1]);
			LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.ChatTab.SetAskLifeTime(nBBAAJENFFN.FLPEILFNDPO, nBBAAJENFFN.GKHHFKEJNAL);
			AFJPGLHKOID.PEKCICFOPDG(LNDFJKGAJAK, nBBAAJENFFN.MDGBOKGEBHM);
			DJFPMCMLPJJ.PEKCICFOPDG();
		}
		else
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.SocialTeamModule, "Response to ResponseAskHelp PROBLEM:{1} / {0}", nKILAONHNNE.ELGCDBGLEIC, nKILAONHNNE.KJLHFILAKOB);
			if (nKILAONHNNE.KJLHFILAKOB == 3009)
			{
				float num = (float)nKILAONHNNE.FLPEILFNDPO / 1000f;
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Wait"));
				LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.ChatTab.SetAskLifeTime(nKILAONHNNE.FLPEILFNDPO, nKILAONHNNE.PFNNFPIDHFN);
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.SocialTeamModule, "Set AskLife Time> TimeLeft:{0}", num);
			}
		}
	}

	private void DJLCFJMFIAG(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		if (MPDHPEIDDOO(MIDCNFGAIFA))
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SocialTeamModule, "Join Request Accepted", MIDCNFGAIFA[1]);
			IGIMHGCIPKC(PCAOOMAAMBE, DFNAOGFJDMF, MIDCNFGAIFA);
		}
		else
		{
			MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_TryAgain"));
		}
	}

	private void JKHLDFGJGPL(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		if (MPDHPEIDDOO(MIDCNFGAIFA))
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SocialTeamModule, "Join Request Rejected", MIDCNFGAIFA[1]);
			IGIMHGCIPKC(PCAOOMAAMBE, DFNAOGFJDMF, MIDCNFGAIFA);
		}
		else
		{
			MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_TryAgain"));
		}
	}

	private void IGIMHGCIPKC(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		if (MPDHPEIDDOO(MIDCNFGAIFA))
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SocialTeamModule, "Remove Join Request: args1:{0}", MIDCNFGAIFA[1]);
			try
			{
				int num = (int)MIDCNFGAIFA[1];
				LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.ChatTab.RemoveRequest(num);
				return;
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SocialTeamModule, "Error Removing Join Request. Error:{0} Stack:{1}", ex.Message, ex.StackTrace);
				return;
			}
		}
		MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_TryAgain"));
	}

	private void OBFHJMEMHOG(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		PONCCEHNOOM fCCCBKMDAOM = new PONCCEHNOOM((Dictionary<string, object>)MIDCNFGAIFA[0]);
		LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.ChatTab.AddJoinRequest(fCCCBKMDAOM);
	}

	private void JFPBILNEOPA(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		object[] source = (object[])MIDCNFGAIFA[0];
		List<PONCCEHNOOM> mIPIMDLEMDN = source.Select((object EDOHEFDJFKF) => new PONCCEHNOOM((Dictionary<string, object>)EDOHEFDJFKF)).ToList();
		LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.ChatTab.AddJoinRequests(mIPIMDLEMDN);
	}

	private void BPJIGGFKLJB(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		int num = (int)MIDCNFGAIFA[0];
		LNDFJKGAJAK.IPCAELIMIBN.JoinToTeam(num, null);
		PHGCFPNJLEI.DCPADMOLNML = "Accept";
		PHGCFPNJLEI.DEIDLKIBDOB = 1;
		AFJPGLHKOID.MDMPINKGLGH(true, num, null);
	}

	private void BLHAKBGCKJK(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		NKILAONHNNE nKILAONHNNE = ADBKCDPFMGN(MIDCNFGAIFA);
		if (nKILAONHNNE != null || MIDCNFGAIFA.Length < 2)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.SocialTeamModule, "Can not fetch online users. {0} / {1}", nKILAONHNNE.KJLHFILAKOB, nKILAONHNNE.ELGCDBGLEIC);
			return;
		}
		HashSet<AKGIJAMHMNA> hashSet = new HashSet<AKGIJAMHMNA>();
		if (MIDCNFGAIFA[1] != null)
		{
			Dictionary<string, object> dictionary = (Dictionary<string, object>)MIDCNFGAIFA[1];
			foreach (string key in dictionary.Keys)
			{
				Dictionary<string, object> dictionary2 = dictionary[key] as Dictionary<string, object>;
				if (dictionary2 != null)
				{
					hashSet.Add(new AKGIJAMHMNA(dictionary2));
				}
			}
		}
		LNDFJKGAJAK.FPILBAGGALI = hashSet;
		LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.UpdateOnlineUserCounts();
	}

	public void BHOIPLKJLFG()
	{
		NLFNJGBPDEL.Socket.Emit("request-suggest-team", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1);
	}

	public void BCPICMNOKNE(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SocialTeamModule, "Reply arrived: " + DFNAOGFJDMF.EventName);
		bool dIDHNNMKJFE = MPDHPEIDDOO(MIDCNFGAIFA) && MIDCNFGAIFA.Length == 2 && MIDCNFGAIFA[1] != null;
		List<BGMENKMNLCH> fOBMKHBPFMG = NJLNKEAKDKH(MIDCNFGAIFA, dIDHNNMKJFE);
		LNDFJKGAJAK.IPCAELIMIBN.SuggestedTeamsFetched(dIDHNNMKJFE, fOBMKHBPFMG);
	}

	private static List<BGMENKMNLCH> NJLNKEAKDKH(object[] MIDCNFGAIFA, bool DIDHNNMKJFE)
	{
		List<BGMENKMNLCH> list = new List<BGMENKMNLCH>();
		if (!DIDHNNMKJFE)
		{
			return list;
		}
		object[] array = MIDCNFGAIFA[1] as object[];
		for (int i = 0; i < array.Length; i++)
		{
			Dictionary<string, object> eAPGOBAJLJE = array[i] as Dictionary<string, object>;
			list.Add(new BGMENKMNLCH(eAPGOBAJLJE));
		}
		return list;
	}

	public void PECEKGJPKAI(long EMNOJOHFMEH)
	{
		NLFNJGBPDEL.Socket.Emit("request-join-team", EMNOJOHFMEH, JHDPFMPOPKD.HBIIHGPDLCM());
	}

	public void JIJCMCPHPLG()
	{
		NLFNJGBPDEL.Socket.Emit("request-list-online");
	}

	public void KBNKLOKJGNC(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		NKILAONHNNE nKILAONHNNE = ADBKCDPFMGN(MIDCNFGAIFA);
		if (nKILAONHNNE != null || MIDCNFGAIFA == null || MIDCNFGAIFA.Length < 2)
		{
			LNDFJKGAJAK.IPCAELIMIBN.JoinToTeamEnded(false, null, nKILAONHNNE);
			return;
		}
		object obj = MIDCNFGAIFA[1];
		if (obj != null)
		{
			LNDFJKGAJAK.IPCAELIMIBN.JoinToTeamEnded(true, new JPLIGBJJCOE((Dictionary<string, object>)obj), null);
		}
	}

	public void JDOEBMGJIMP()
	{
		NLFNJGBPDEL.Socket.Emit("request-leave-team");
	}

	public void JNELDOGIAGB(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		NKILAONHNNE nKILAONHNNE = ADBKCDPFMGN(MIDCNFGAIFA);
		if (nKILAONHNNE != null || MIDCNFGAIFA == null || MIDCNFGAIFA.Length < 2)
		{
			LNDFJKGAJAK.IPCAELIMIBN.LeaveTeamEnded(false, null, nKILAONHNNE);
			return;
		}
		object obj = MIDCNFGAIFA[1];
		if (obj != null)
		{
			LNDFJKGAJAK.IPCAELIMIBN.LeaveTeamEnded(true, new AKGIJAMHMNA((Dictionary<string, object>)obj), null);
		}
	}

	private void IKJBEFOOEGP(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		AKGIJAMHMNA aKGIJAMHMNA = new AKGIJAMHMNA((Dictionary<string, object>)MIDCNFGAIFA[0]);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SocialTeamModule, "Kicked from team, new user: {0}", aKGIJAMHMNA);
		DAKLNDKNNII.IFKNKGAMEGA(aKGIJAMHMNA, LNDFJKGAJAK, 1);
	}

	public void IEJDIMGBMCN(string OEFCOJLNCKP)
	{
		NLFNJGBPDEL.Socket.Emit("request-msg", OEFCOJLNCKP);
	}

	public void POKBINCNOHP(Dictionary<string, object> LEPMLBKFMCK)
	{
		NLFNJGBPDEL.Socket.Emit("request-create-team", LEPMLBKFMCK);
	}

	public void ADEPCGKPKLC(long BPKJLGJDFKG)
	{
		NLFNJGBPDEL.Socket.Emit("request-accept-req", BPKJLGJDFKG);
	}

	public void PLNJECGIDAI(long BPKJLGJDFKG)
	{
		NLFNJGBPDEL.Socket.Emit("request-deny-req", BPKJLGJDFKG);
	}

	private void JONOBIPIHFG(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		NKILAONHNNE nKILAONHNNE = ADBKCDPFMGN(MIDCNFGAIFA);
		if (nKILAONHNNE != null || MIDCNFGAIFA == null || MIDCNFGAIFA.Length < 2)
		{
			LNDFJKGAJAK.IPCAELIMIBN.CreateTeamEnded(false, null, nKILAONHNNE);
			return;
		}
		int value = (int)MIDCNFGAIFA[1];
		bool flag = GEBAAFFGKJG.GABGKBAKHDP.DCAKPPKFOEP(NAAHKHPBAPA.Coins, BOKGFGFPOHD.JNIADGLOLMP.FDNCJEHPFFJ);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SocialTeamModule, " Spent " + BOKGFGFPOHD.JNIADGLOLMP.FDNCJEHPFFJ + " coins for team creation. Result: {0}", flag);
		LNDFJKGAJAK.IPCAELIMIBN.CreateTeamEnded(true, value, null);
	}

	public void OJIIDKOGKDC(string FCJBBPHFNPJ)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary["name"] = FCJBBPHFNPJ;
		NLFNJGBPDEL.Socket.Emit("request-search-team", dictionary);
	}

	public void EGHCONCIBKE(string GFLHOMACBOE, int GIOFHACJEGA, int MBEOPLHLANP)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary["desc"] = GFLHOMACBOE;
		dictionary["level"] = GIOFHACJEGA;
		dictionary["closed"] = MBEOPLHLANP;
		NLFNJGBPDEL.Socket.Emit("request-edit-team-info", dictionary);
	}

	private void MBBIODALEOG(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		NKILAONHNNE nKILAONHNNE = ADBKCDPFMGN(MIDCNFGAIFA);
		if (nKILAONHNNE != null || MIDCNFGAIFA == null || MIDCNFGAIFA.Length < 1)
		{
			LNDFJKGAJAK.IPCAELIMIBN.EditTeamResponse(false, -1, nKILAONHNNE);
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.SocialTeamModule, "Response to OnResponseTeamEdit PROBLEM:{1} / {0}", nKILAONHNNE.ELGCDBGLEIC, nKILAONHNNE.KJLHFILAKOB);
		}
		else
		{
			LNDFJKGAJAK.IPCAELIMIBN.EditTeamResponse(true, Convert.ToInt32(MIDCNFGAIFA[1]));
		}
	}

	private void OIPGPOLIHMA(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		NKILAONHNNE nKILAONHNNE = ADBKCDPFMGN(MIDCNFGAIFA);
		if (nKILAONHNNE != null || MIDCNFGAIFA == null || MIDCNFGAIFA.Length < 2)
		{
			LNDFJKGAJAK.IPCAELIMIBN.SearchTeamEnded(false, null, nKILAONHNNE);
			return;
		}
		List<BGMENKMNLCH> iMCILJFAPPB = NJLNKEAKDKH(MIDCNFGAIFA, nKILAONHNNE == null);
		LNDFJKGAJAK.IPCAELIMIBN.SearchTeamEnded(true, iMCILJFAPPB, nKILAONHNNE);
	}

	public void EIABEOOGKNK(long IJHHCJOBPNF)
	{
		NLFNJGBPDEL.Socket.Emit("request-help-user", IJHHCJOBPNF, "4161");
	}

	public void LKPMIAFIDJP()
	{
		NLFNJGBPDEL.Socket.Emit("request-ask-help");
	}

	public void OLAHHONIHDA()
	{
		NLFNJGBPDEL.Socket.Emit("request-read-inbox");
	}

	public void HOLOADDJPPB(string DLALMJPFFMK, long DIKEGACKFFH)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("messageId", DLALMJPFFMK);
		dictionary.Add("fromId", DIKEGACKFFH.ToString());
		Dictionary<string, string> dictionary2 = dictionary;
		NLFNJGBPDEL.Socket.Emit("request-inbox-consumed", dictionary2);
	}

	private void KIBNHPCAHEF(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		NKILAONHNNE nKILAONHNNE = ADBKCDPFMGN(MIDCNFGAIFA);
		if (nKILAONHNNE == null && MIDCNFGAIFA.Length > 0)
		{
			CCMHBMFDBEP cCMHBMFDBEP = new CCMHBMFDBEP((Dictionary<string, object>)MIDCNFGAIFA[1]);
			cCMHBMFDBEP.JFLAAOOBKJD(LNDFJKGAJAK);
		}
		else if (nKILAONHNNE == null)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.SocialTeamModule, "Unexpected inbox reply.");
		}
	}

	public void LOMBPFAIGKF()
	{
		NLFNJGBPDEL.Socket.Emit("request-show-my-help");
	}

	public void FHMAKHMJFKF(long BPKJLGJDFKG)
	{
		NLFNJGBPDEL.Socket.Emit("request-kick-user", BPKJLGJDFKG);
	}

	private void FOGMKIIFPHI(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		NKILAONHNNE nKILAONHNNE = ADBKCDPFMGN(MIDCNFGAIFA);
		if (nKILAONHNNE == null)
		{
			Dictionary<string, object> jLKANDLHAOM = (Dictionary<string, object>)MIDCNFGAIFA[1];
			AKGIJAMHMNA aKGIJAMHMNA = new AKGIJAMHMNA(jLKANDLHAOM);
			LNDFJKGAJAK.COPDAKACHFM.BHBHEIAPLMK(aKGIJAMHMNA.EEFMIHDPJPG);
			LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.MyTeamTab.UpdateTeamMembers();
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SocialTeamModule, "Response to OnResponseKickUser OK." + aKGIJAMHMNA.EEFMIHDPJPG);
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
			{
				new JDOKMBCDMLO(3, aKGIJAMHMNA.EEFMIHDPJPG, aKGIJAMHMNA.OADDPGNIINO)
			});
		}
		else
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.SocialTeamModule, "Response to OnResponseKickUser PROBLEM:{1} / {0}", nKILAONHNNE.ELGCDBGLEIC, nKILAONHNNE.KJLHFILAKOB);
		}
	}

	public void GKGLEBDDKBP(int EMNOJOHFMEH, Action<bool, IOrderedEnumerable<NCGNBHMMFKN>> BLGONBMOFEG)
	{
		EBMCLGHCIFM[EMNOJOHFMEH] = BLGONBMOFEG;
		NLFNJGBPDEL.Socket.Emit("request-team-members", EMNOJOHFMEH);
	}

	private void INPHADGIGPF(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		NKILAONHNNE nKILAONHNNE = ADBKCDPFMGN(MIDCNFGAIFA);
		if (nKILAONHNNE == null)
		{
			Dictionary<string, object> dictionary = (Dictionary<string, object>)MIDCNFGAIFA[1];
			double num = (double)dictionary["teamId"];
			Action<bool, IOrderedEnumerable<NCGNBHMMFKN>> value;
			if (EBMCLGHCIFM.TryGetValue((int)num, out value))
			{
				object[] array = (object[])dictionary["members"];
				List<NCGNBHMMFKN> list = new List<NCGNBHMMFKN>();
				int num2 = OIAJPMNJGLK.HOGCELOOGEP();
				foreach (object obj in array)
				{
					NCGNBHMMFKN nCGNBHMMFKN = new NCGNBHMMFKN((Dictionary<string, object>)obj);
					if (num2 > nCGNBHMMFKN.KEMNAAPNAPA)
					{
						nCGNBHMMFKN.KFBCFDALGBB = 0L;
					}
					list.Add(nCGNBHMMFKN);
				}
				IOrderedEnumerable<NCGNBHMMFKN> arg = from IBBBMACIBGK in list
					orderby IBBBMACIBGK.CALJBGILMOL descending, IBBBMACIBGK.KEMNAAPNAPA descending, IBBBMACIBGK.KFBCFDALGBB descending
					select IBBBMACIBGK;
				value(true, arg);
			}
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SocialTeamModule, "Response to OnRequestTeamMember OK.");
		}
		else
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.SocialTeamModule, "Response to OnRequestTeamMember PROBLEM:{1} / {0}", nKILAONHNNE.ELGCDBGLEIC, nKILAONHNNE.KJLHFILAKOB);
			int oADDPGNIINO = nKILAONHNNE.OADDPGNIINO;
			Action<bool, IOrderedEnumerable<NCGNBHMMFKN>> value2;
			if (EBMCLGHCIFM.TryGetValue(oADDPGNIINO, out value2))
			{
				value2(false, null);
			}
		}
	}

	[CompilerGenerated]
	private static PONCCEHNOOM JBAJJNJMLOH(object EDOHEFDJFKF)
	{
		return new PONCCEHNOOM((Dictionary<string, object>)EDOHEFDJFKF);
	}

	[CompilerGenerated]
	private static long LOKLBKAEJHB(NCGNBHMMFKN IBBBMACIBGK)
	{
		return IBBBMACIBGK.CALJBGILMOL;
	}

	[CompilerGenerated]
	private static long CHBKPODGBHG(NCGNBHMMFKN IBBBMACIBGK)
	{
		return IBBBMACIBGK.KEMNAAPNAPA;
	}

	[CompilerGenerated]
	private static long DLJCEHKONMC(NCGNBHMMFKN IBBBMACIBGK)
	{
		return IBBBMACIBGK.KFBCFDALGBB;
	}
}
