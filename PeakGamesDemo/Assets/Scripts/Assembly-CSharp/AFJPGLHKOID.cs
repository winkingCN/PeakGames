using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using Assets.Scripts.Dialogs;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.Utils.Analytics;
using BestHTTP.SocketIO;
using BillingUnityLibraries;
using UnityEngine;

public static class AFJPGLHKOID
{
	private struct CCCFDFDODKE
	{
		public readonly string HNLMGJGNBDD;

		public int? NBFDOJDLKOG;

		public readonly int? GOCFBLLGPIL;

		public readonly string PEBNCILAMGI;

		public readonly string AHDOGBNEJFM;

		public readonly string IMPJKJJDODM;

		public readonly JsonEventData PPOADEAIACB;

		public CCCFDFDODKE(string IDHLPOFDLKJ, int? PHILIHLPDFD, int? AAIEJDNAODP, string DGGMHBKODNO, string DGFPCOODPCB, string PDDEAIPJEPL, JsonEventData LCPOFOEDKCA)
		{
			HNLMGJGNBDD = IDHLPOFDLKJ;
			NBFDOJDLKOG = PHILIHLPDFD;
			GOCFBLLGPIL = AAIEJDNAODP;
			PEBNCILAMGI = DGGMHBKODNO;
			AHDOGBNEJFM = DGFPCOODPCB;
			IMPJKJJDODM = PDDEAIPJEPL;
			PPOADEAIACB = LCPOFOEDKCA;
		}
	}

	[CompilerGenerated]
	private sealed class DDODJJEMMBO
	{
		internal List<IKDMCJPBBIH> HDECNOABBDG;

		internal void AGFNGEFDHLA(JsonPingData MBBPBGHKLJM)
		{
			int count = HDECNOABBDG.Count;
			JsonTimeout jsonTimeout = new JsonTimeout
			{
				ping = MBBPBGHKLJM
			};
			jsonTimeout.LLGLAHKBJJG();
			int num = 0;
			string text = string.Empty;
			string text2 = " ";
			for (int i = 0; i < count; i++)
			{
				text = string.Concat(text, HDECNOABBDG[i].LOICNFDHCJK, text2);
				num = HDECNOABBDG[i].MCFABAAMELG();
			}
			JLJGBGFPKKC("ServerTimeout", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), text, num.ToString(), jsonTimeout);
		}
	}

	[CompilerGenerated]
	private sealed class BAAIFDCOBPG
	{
		internal List<IKDMCJPBBIH> HDECNOABBDG;

		internal string LENFKJMEBFP;

		internal void AGFNGEFDHLA(JsonPingData MBBPBGHKLJM)
		{
			int count = HDECNOABBDG.Count;
			JsonTimeout jsonTimeout = new JsonTimeout
			{
				ping = MBBPBGHKLJM
			};
			jsonTimeout.LLGLAHKBJJG();
			string text = string.Empty;
			for (int i = 0; i < count; i++)
			{
				text += HDECNOABBDG[i].LOICNFDHCJK;
			}
			if (LENFKJMEBFP != null && LENFKJMEBFP.Length > 100)
			{
				LENFKJMEBFP = LENFKJMEBFP.Substring(0, 100);
			}
			JLJGBGFPKKC("ServerError", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), text, LENFKJMEBFP, jsonTimeout);
		}
	}

	[CompilerGenerated]
	private sealed class LKEKDPEMDKP
	{
		internal List<IKDMCJPBBIH> HDECNOABBDG;

		internal void AGFNGEFDHLA(JsonPingData MBBPBGHKLJM)
		{
			JsonTimeout jsonTimeout = new JsonTimeout
			{
				ping = MBBPBGHKLJM
			};
			jsonTimeout.LLGLAHKBJJG();
			int count = HDECNOABBDG.Count;
			string text = string.Empty;
			for (int i = 0; i < count; i++)
			{
				text += HDECNOABBDG[i].LOICNFDHCJK;
			}
			JLJGBGFPKKC("ServerAbort", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), text, "Aborted", jsonTimeout);
		}
	}

	[CompilerGenerated]
	private sealed class KNBJBGOBGAO
	{
		internal bool OGAEECANDHB;

		internal void AGFNGEFDHLA(JsonPingData MBBPBGHKLJM)
		{
			JsonTimeout jsonTimeout = new JsonTimeout
			{
				ping = MBBPBGHKLJM
			};
			jsonTimeout.LLGLAHKBJJG();
			JLJGBGFPKKC("ServerFallback", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), (!OGAEECANDHB) ? "fail" : "success", null, jsonTimeout);
		}
	}

	[CompilerGenerated]
	private sealed class IHBFBCMOEJN
	{
		internal Error LENFKJMEBFP;

		internal void AGFNGEFDHLA(JsonPingData MBBPBGHKLJM)
		{
			JsonTimeout jsonTimeout = new JsonTimeout
			{
				ping = MBBPBGHKLJM
			};
			jsonTimeout.LLGLAHKBJJG();
			string dGFPCOODPCB = ((LENFKJMEBFP != null) ? LENFKJMEBFP.Code.ToString() : null);
			string text = ((LENFKJMEBFP != null) ? LENFKJMEBFP.Message : null);
			if (text != null && text.Length > 100)
			{
				text = text.Substring(0, 100);
			}
			JLJGBGFPKKC("SocketDisconnected", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), dGFPCOODPCB, text, jsonTimeout);
		}
	}

	[CompilerGenerated]
	private sealed class LJEPMDDGKMC
	{
		internal int AAKHAPBEGDO;

		internal void AGFNGEFDHLA(JsonPingData MBBPBGHKLJM)
		{
			JsonTimeout jsonTimeout = new JsonTimeout
			{
				ping = MBBPBGHKLJM
			};
			jsonTimeout.LLGLAHKBJJG();
			JLJGBGFPKKC("SocketConnectionError", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), null, AAKHAPBEGDO.ToString(), jsonTimeout);
		}
	}

	private static Thread MAKLCNFAAFM;

	private static readonly Queue<CCCFDFDODKE> HFILKHIGBOD = new Queue<CCCFDFDODKE>();

	private static readonly CCCFDFDODKE DONICNOIADK = new CCCFDFDODKE(string.Empty, 0, 0, string.Empty, string.Empty, string.Empty, null);

	private static readonly List<IGNIBAHDGLL> OCPINGOEILD = new List<IGNIBAHDGLL>();

	private static volatile bool JGMLKGCLMME;

	private static readonly object BAFODPMFGPF = new object();

	private static bool GKAELLKBDAH;

	private static readonly Regex EAHMCIHAAHB = new Regex("(Code.*)UserInfo");

	[CompilerGenerated]
	private static ThreadStart JANLDOMIIEF;

	[CompilerGenerated]
	private static Dictionary<string, int> JMOAIJPNMKG;

	[CompilerGenerated]
	private static Func<AKGIJAMHMNA, long> EBCOMJBLIPP;

	[CompilerGenerated]
	private static Func<AKGIJAMHMNA, long> DNBOPLHGMHA;

	public static void BAMKBCHHLGP()
	{
		if (MAKLCNFAAFM == null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.EventSender, "Event Sender is started.");
			JGMLKGCLMME = true;
			Thread thread = new Thread(NJFBDIOKCJE);
			thread.Priority = System.Threading.ThreadPriority.Normal;
			thread.Name = "EventThread";
			MAKLCNFAAFM = thread;
			MAKLCNFAAFM.Start();
		}
	}

	public static void PCHCAFHEJJM()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.EventSender, "Event Sender is disposed.");
		try
		{
			HFPGJBIHLHE();
			LLAHEOHDBJD();
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.EventSender, "Exception on dispose Error:{0}, Stack:{1}", ex.Message, ex.StackTrace);
		}
		JGMLKGCLMME = false;
	}

	private static void NJFBDIOKCJE()
	{
		AndroidJNI.AttachCurrentThread();
		while (JGMLKGCLMME)
		{
			Thread.Sleep(100);
			HFPGJBIHLHE();
		}
		try
		{
			MAKLCNFAAFM.Abort();
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.EventSender, "Consume event thread could not aborted Error:{0}, Stack:{1}", ex.Message, ex.StackTrace);
		}
		AndroidJNI.DetachCurrentThread();
	}

	private static void HFPGJBIHLHE()
	{
		CCCFDFDODKE dONICNOIADK = DONICNOIADK;
		while (HFILKHIGBOD.Count > 0)
		{
			dONICNOIADK = DONICNOIADK;
			lock (BAFODPMFGPF)
			{
				if (HFILKHIGBOD.Count > 0)
				{
					dONICNOIADK = HFILKHIGBOD.Dequeue();
				}
			}
			try
			{
				if (dONICNOIADK.HNLMGJGNBDD != string.Empty)
				{
					JJOGJLACGIL(dONICNOIADK);
				}
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.EventSender, "Can not consume event {0}, Error:{1}, Stack:{2}", dONICNOIADK.HNLMGJGNBDD, ex.Message, ex.StackTrace);
			}
		}
	}

	private static void JJOGJLACGIL(CCCFDFDODKE HMIFPEJKHHH)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.EventSender, "Consuming event > {0}", HMIFPEJKHHH.HNLMGJGNBDD);
		if (PeakAnalytics.NDODOKFECKE && PeakAnalytics.LOPFOEHECGB != null)
		{
			PeakAnalytics.LOPFOEHECGB.SendEvent(HMIFPEJKHHH.HNLMGJGNBDD, HMIFPEJKHHH.NBFDOJDLKOG, HMIFPEJKHHH.GOCFBLLGPIL, HMIFPEJKHHH.PEBNCILAMGI, HMIFPEJKHHH.AHDOGBNEJFM, HMIFPEJKHHH.IMPJKJJDODM, JsonUtility.ToJson(HMIFPEJKHHH.PPOADEAIACB));
		}
		else
		{
			OCPINGOEILD.Add(new IGNIBAHDGLL(HMIFPEJKHHH.HNLMGJGNBDD, HMIFPEJKHHH.NBFDOJDLKOG, HMIFPEJKHHH.GOCFBLLGPIL, HMIFPEJKHHH.PEBNCILAMGI, HMIFPEJKHHH.AHDOGBNEJFM, HMIFPEJKHHH.IMPJKJJDODM, JsonUtility.ToJson(HMIFPEJKHHH.PPOADEAIACB)));
		}
	}

	private static void JLJGBGFPKKC(string IDHLPOFDLKJ, int? PHILIHLPDFD = null, int? AAIEJDNAODP = null, string DGGMHBKODNO = null, string DGFPCOODPCB = null, string PDDEAIPJEPL = null, JsonEventData LCPOFOEDKCA = null)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.EventSender, "Adding new event to queue > {0}", IDHLPOFDLKJ);
		if (LCPOFOEDKCA == null)
		{
			switch (IDHLPOFDLKJ)
			{
			case "LevelStart":
			case "RenderType":
			{
				JsonStartLevel jsonStartLevel = new JsonStartLevel();
				jsonStartLevel.LLGLAHKBJJG();
				jsonStartLevel.inventory = new JsonInventory();
				jsonStartLevel.inventory.LDOCFEGBGNK();
				jsonStartLevel.number_of_inbox_lives = CAGBGIHKHEJ.GABGKBAKHDP.ELEKFHDLKJJ().ToString();
				LCPOFOEDKCA = jsonStartLevel;
				break;
			}
			case "BoosterUse":
			{
				JsonSessionDataWithInventory jsonSessionDataWithInventory = new JsonSessionDataWithInventory();
				jsonSessionDataWithInventory.LLGLAHKBJJG();
				LCPOFOEDKCA = jsonSessionDataWithInventory;
				break;
			}
			case "ABTestEnter":
			case "FacebookConnect":
			case "MusicStatusChanged":
			case "SoundStatusChanged":
			case "FriendStatus":
			case "Search":
			case "ClosedTeamRespond":
			case "ClosedTeamRequest":
			case "LifeUse":
			case "EpisodeNavigationClose":
			case "CLLeaderboardOpen":
			case "SupportSend":
			case "SuggestedTeamFull":
			case "LifeInboxError":
			case "ConsentPopup":
			{
				JsonBaseData jsonBaseData = new JsonBaseData();
				jsonBaseData.LLGLAHKBJJG();
				LCPOFOEDKCA = jsonBaseData;
				break;
			}
			}
		}
		if (PHILIHLPDFD.HasValue && IDFPAFEJPPH.GABGKBAKHDP.HGNJBHGBLIN)
		{
			PHILIHLPDFD = -1 * IDFPAFEJPPH.GABGKBAKHDP.KOPMPMIFHNF;
		}
		lock (BAFODPMFGPF)
		{
			CCCFDFDODKE item = new CCCFDFDODKE(IDHLPOFDLKJ, PHILIHLPDFD, AAIEJDNAODP, DGGMHBKODNO, DGFPCOODPCB, PDDEAIPJEPL, LCPOFOEDKCA);
			HFILKHIGBOD.Enqueue(item);
		}
	}

	public static void CPIGOAGGLBM(string IDHLPOFDLKJ, int? PHILIHLPDFD = null, int? AAIEJDNAODP = null, string DGGMHBKODNO = null, string DGFPCOODPCB = null, string PDDEAIPJEPL = null)
	{
		JLJGBGFPKKC(IDHLPOFDLKJ, PHILIHLPDFD, AAIEJDNAODP, DGGMHBKODNO, DGFPCOODPCB, PDDEAIPJEPL);
	}

	public static void LLAHEOHDBJD()
	{
		if (PeakAnalytics.LOPFOEHECGB == null)
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.PeakAnalytics, "Trying to send event but Facade is not ready!");
		}
		else if (OCPINGOEILD != null && OCPINGOEILD.Count != 0)
		{
			while (OCPINGOEILD.Count > 0)
			{
				int index = OCPINGOEILD.Count - 1;
				IGNIBAHDGLL iGNIBAHDGLL = OCPINGOEILD[index];
				PeakAnalytics.LOPFOEHECGB.SendEvent(iGNIBAHDGLL.IDHLPOFDLKJ, iGNIBAHDGLL.PHILIHLPDFD, iGNIBAHDGLL.AAIEJDNAODP, iGNIBAHDGLL.DGGMHBKODNO, iGNIBAHDGLL.DGFPCOODPCB, iGNIBAHDGLL.PDDEAIPJEPL, iGNIBAHDGLL.MBBPBGHKLJM);
				OCPINGOEILD.RemoveAt(index);
			}
		}
	}

	private static string BMHANMHADDG()
	{
		JsonBaseData jsonBaseData = new JsonBaseData();
		jsonBaseData.LLGLAHKBJJG();
		return JsonUtility.ToJson(jsonBaseData);
	}

	public static int EGPIKEDHAKN()
	{
		if (LevelBuilder.ActiveLevel == null)
		{
			if (PrelevelDialog.ChosenLevel != -1)
			{
				return PrelevelDialog.ChosenLevel;
			}
			return MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1;
		}
		return LevelBuilder.CurrentLevelNo;
	}

	public static void LCLPALMIKKO(int INIJLAGDMPI, string FAECHGOHJKJ, string MJIOMBCHMNO)
	{
		int num = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1;
		JLJGBGFPKKC("FacebookConnect", num, INIJLAGDMPI, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA, FAECHGOHJKJ, new JsonFacebookConnectData
		{
			max_level_after = num,
			connect_from = MJIOMBCHMNO
		});
	}

	public static void GIGKJIFHNIF(int INIJLAGDMPI, string ALDEMAHJJNA, string FAECHGOHJKJ)
	{
		int num = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1;
		JsonFacebookDisconnectData jsonFacebookDisconnectData = new JsonFacebookDisconnectData();
		jsonFacebookDisconnectData.discon_type = "UserDisconnect";
		jsonFacebookDisconnectData.max_level_after = num;
		JsonFacebookDisconnectData jsonFacebookDisconnectData2 = jsonFacebookDisconnectData;
		jsonFacebookDisconnectData2.LLGLAHKBJJG();
		JLJGBGFPKKC("FacebookDisconnect", num, INIJLAGDMPI, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), ALDEMAHJJNA, FAECHGOHJKJ, jsonFacebookDisconnectData2);
	}

	public static void NLDLHDAODGO()
	{
		if (!GKAELLKBDAH && JCGLFEMHECF.GABGKBAKHDP != null && JCGLFEMHECF.GABGKBAKHDP.OHGJJONIHKM != null)
		{
			FFGIDMDAGOA fFGIDMDAGOA = FFGIDMDAGOA.GABGKBAKHDP;
			int val = fFGIDMDAGOA.ADNBNEFJGFF();
			val = Math.Max(0, val);
			int val2 = fFGIDMDAGOA.PLKAJICLGJB();
			val2 = Math.Max(0, val2);
			JLJGBGFPKKC("FriendStatus", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, val2, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), val.ToString());
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FBFriendsManager, "Sending FRIEND_STATUS Event. GameFriendCount:" + val);
			GKAELLKBDAH = true;
		}
	}

	public static void EPPPDABGAFO(int KIGOGMKCDKN, string JINEOGKAJCI, string NMJLODIEFJE)
	{
		JLJGBGFPKKC("LevelStart", KIGOGMKCDKN, MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), JINEOGKAJCI, NMJLODIEFJE);
		PeakAnalytics.SendRetentionEvents();
	}

	public static void CIBKGNFLBDE(JsonLevelEndData AKGPMBFANJB)
	{
		JLJGBGFPKKC("_custom", null, null, "level_end", null, null, AKGPMBFANJB);
		if (AKGPMBFANJB != null && AKGPMBFANJB.level == 25)
		{
			PeakAnalytics.SendD1Level25();
		}
	}

	public static void IJPMIOFMCPJ(string JOMMFPHFDIG)
	{
		JLJGBGFPKKC("BoosterUse", LevelBuilder.CurrentLevelNo, MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), JOMMFPHFDIG, (LevelBuilder.ActiveLevel != null) ? LevelBuilder.ActiveLevel.PNGPLGHKFDI : string.Empty);
	}

	public static void GEEIAHDELAO(string NBFBPNNEKMN, int JFLJEAAONLI, int DNLCHHKBDOG, bool EEKJMDHEJCK, string OOOMNPKODJA = null)
	{
		JsonInventory jsonInventory = new JsonInventory();
		jsonInventory.LDOCFEGBGNK();
		JsonSpendData jsonSpendData = new JsonSpendData();
		jsonSpendData.game_session_id = PeakAnalytics.SessionId;
		jsonSpendData.hc_before_spending = JFLJEAAONLI.ToString();
		jsonSpendData.max_level = (MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1).ToString();
		jsonSpendData.if_life_refill = OOOMNPKODJA;
		jsonSpendData.inventory = jsonInventory;
		JsonSpendData jsonSpendData2 = jsonSpendData;
		jsonSpendData2.LLGLAHKBJJG();
		JLJGBGFPKKC((!EEKJMDHEJCK) ? "SpendingFail" : "SpendingSuccess", EGPIKEDHAKN(), DNLCHHKBDOG, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), NBFBPNNEKMN, null, jsonSpendData2);
	}

	public static void GOJOHDKEAGC(bool EEKJMDHEJCK, BillingProduct MHCFFEOFFOB, string LFCPPDHKCOA, string HCJOGBJOGAH, int JFLJEAAONLI, string IIHLJOKODJG, string LENFKJMEBFP)
	{
		try
		{
			if (MHCFFEOFFOB == null)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.CaravanBillingHelper, "Null empty billing product.");
				return;
			}
			string error_code = string.Empty;
			if (LENFKJMEBFP != null)
			{
				Match match = EAHMCIHAAHB.Match(LENFKJMEBFP);
				if (match.Success)
				{
					error_code = match.Groups[0].Value;
				}
			}
			JsonInventory jsonInventory = new JsonInventory();
			jsonInventory.LDOCFEGBGNK();
			JsonPurchaseData jsonPurchaseData = new JsonPurchaseData();
			jsonPurchaseData.hc_before_purchase = JFLJEAAONLI.ToString();
			jsonPurchaseData.product_id = MHCFFEOFFOB.Identifier;
			jsonPurchaseData.error_code = error_code;
			jsonPurchaseData.trigger_reason = IIHLJOKODJG;
			jsonPurchaseData.max_level = (MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1).ToString();
			jsonPurchaseData.if_life_refill = OutOfLivesDialog.RefillStatus;
			jsonPurchaseData.transaction_id = LFCPPDHKCOA;
			jsonPurchaseData.inventory = jsonInventory;
			jsonPurchaseData.orderId = HCJOGBJOGAH;
			JsonPurchaseData jsonPurchaseData2 = jsonPurchaseData;
			jsonPurchaseData2.LLGLAHKBJJG();
			JLJGBGFPKKC((!EEKJMDHEJCK) ? "PurchaseFail" : "PurchaseSuccess", EGPIKEDHAKN(), JFLJEAAONLI, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), MHCFFEOFFOB.Price, MHCFFEOFFOB.Currency, jsonPurchaseData2);
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.CaravanBillingHelper, "Can not send purchase event: {0}", ex.Message);
		}
	}

	public static void DJDGHLNEAHB(Dictionary<NAAHKHPBAPA, int> GKNKMDIPAIK)
	{
		JsonLevelChest jsonLevelChest = new JsonLevelChest();
		jsonLevelChest.gifts = new JsonToonChestGifts();
		JsonLevelChest jsonLevelChest2 = jsonLevelChest;
		foreach (KeyValuePair<NAAHKHPBAPA, int> item in GKNKMDIPAIK)
		{
			switch (item.Key)
			{
			case NAAHKHPBAPA.Coins:
				jsonLevelChest2.gifts.coin = item.Value;
				break;
			case NAAHKHPBAPA.Hammer:
				jsonLevelChest2.gifts.hammer = item.Value;
				break;
			case NAAHKHPBAPA.Anvil:
				jsonLevelChest2.gifts.anvil = item.Value;
				break;
			case NAAHKHPBAPA.BoxingGlove:
				jsonLevelChest2.gifts.boxingglove = item.Value;
				break;
			case NAAHKHPBAPA.Rocket:
				jsonLevelChest2.gifts.rocket = item.Value;
				break;
			case NAAHKHPBAPA.Bomb:
				jsonLevelChest2.gifts.bomb = item.Value;
				break;
			case NAAHKHPBAPA.DiscoBall:
				jsonLevelChest2.gifts.discoball = item.Value;
				break;
			case NAAHKHPBAPA.Dice:
				jsonLevelChest2.gifts.dice = item.Value;
				break;
			default:
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Events, "Error creating SendChest Event");
				break;
			case NAAHKHPBAPA.None:
			case NAAHKHPBAPA.Extra5Moves:
			case NAAHKHPBAPA.UserType:
			case NAAHKHPBAPA.PaintBrush:
				break;
			}
		}
		JsonInventory jsonInventory = new JsonInventory();
		jsonInventory.LDOCFEGBGNK();
		jsonLevelChest2.inventory = jsonInventory;
		jsonLevelChest2.LLGLAHKBJJG();
		JLJGBGFPKKC("ToonChest", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), null, null, jsonLevelChest2);
	}

	public static void JIINLAEELCB(Dictionary<NAAHKHPBAPA, int> GKNKMDIPAIK)
	{
		JsonStarChestGifts jsonStarChestGifts = new JsonStarChestGifts();
		jsonStarChestGifts.life_refill = 0;
		JsonStarChestGifts jsonStarChestGifts2 = jsonStarChestGifts;
		foreach (KeyValuePair<NAAHKHPBAPA, int> item in GKNKMDIPAIK)
		{
			NAAHKHPBAPA key = item.Key;
			int value = item.Value;
			switch (key)
			{
			case NAAHKHPBAPA.Coins:
				jsonStarChestGifts2.coin = value;
				break;
			case NAAHKHPBAPA.Hammer:
				jsonStarChestGifts2.hammer = value;
				break;
			case NAAHKHPBAPA.Anvil:
				jsonStarChestGifts2.anvil = value;
				break;
			case NAAHKHPBAPA.BoxingGlove:
				jsonStarChestGifts2.boxingglove = value;
				break;
			case NAAHKHPBAPA.Rocket:
				jsonStarChestGifts2.rocket = value;
				break;
			case NAAHKHPBAPA.Bomb:
				jsonStarChestGifts2.bomb = value;
				break;
			case NAAHKHPBAPA.DiscoBall:
				jsonStarChestGifts2.discoball = value;
				break;
			case NAAHKHPBAPA.Dice:
				jsonStarChestGifts2.dice = value;
				break;
			case NAAHKHPBAPA.Life:
				jsonStarChestGifts2.life_refill = 1;
				break;
			}
		}
		JsonInventory jsonInventory = new JsonInventory();
		jsonInventory.LDOCFEGBGNK();
		JsonLevelStarChest jsonLevelStarChest = new JsonLevelStarChest();
		jsonLevelStarChest.gifts = jsonStarChestGifts2;
		jsonLevelStarChest.inventory = jsonInventory;
		JsonLevelStarChest jsonLevelStarChest2 = jsonLevelStarChest;
		jsonLevelStarChest2.LLGLAHKBJJG();
		JLJGBGFPKKC("StarChest", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), null, null, jsonLevelStarChest2);
	}

	public static void FJAGKJJLIGH(NAAHKHPBAPA GEKKLIKPAPP, int NNIDKMJGAJO)
	{
		JsonDailyBonusGifts jsonDailyBonusGifts = new JsonDailyBonusGifts();
		switch (GEKKLIKPAPP)
		{
		case NAAHKHPBAPA.Coins:
			jsonDailyBonusGifts.coin = NNIDKMJGAJO;
			break;
		case NAAHKHPBAPA.Hammer:
			jsonDailyBonusGifts.hammer = NNIDKMJGAJO;
			break;
		case NAAHKHPBAPA.Anvil:
			jsonDailyBonusGifts.anvil = NNIDKMJGAJO;
			break;
		case NAAHKHPBAPA.BoxingGlove:
			jsonDailyBonusGifts.boxingglove = NNIDKMJGAJO;
			break;
		case NAAHKHPBAPA.Rocket:
			jsonDailyBonusGifts.rocket = NNIDKMJGAJO;
			break;
		case NAAHKHPBAPA.Bomb:
			jsonDailyBonusGifts.bomb = NNIDKMJGAJO;
			break;
		case NAAHKHPBAPA.DiscoBall:
			jsonDailyBonusGifts.discoball = NNIDKMJGAJO;
			break;
		case NAAHKHPBAPA.Dice:
			jsonDailyBonusGifts.dice = NNIDKMJGAJO;
			break;
		case NAAHKHPBAPA.Life:
			jsonDailyBonusGifts.life = NNIDKMJGAJO;
			break;
		}
		JsonInventory jsonInventory = new JsonInventory();
		jsonInventory.LDOCFEGBGNK();
		JsonDailyBonus jsonDailyBonus = new JsonDailyBonus();
		jsonDailyBonus.gifts = jsonDailyBonusGifts;
		jsonDailyBonus.inventory = jsonInventory;
		JsonDailyBonus jsonDailyBonus2 = jsonDailyBonus;
		jsonDailyBonus2.LLGLAHKBJJG();
		JLJGBGFPKKC("DailyBonusClaim", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), null, GEKKLIKPAPP.ToString(), jsonDailyBonus2);
	}

	public static void HNPNNHONACO(Dictionary<NAAHKHPBAPA, int> JEAHDBDNJOA, int CIPBDDKIDEF)
	{
		JsonDailyBonusGifts jsonDailyBonusGifts = new JsonDailyBonusGifts();
		foreach (KeyValuePair<NAAHKHPBAPA, int> item in JEAHDBDNJOA)
		{
			switch (item.Key)
			{
			case NAAHKHPBAPA.Coins:
				jsonDailyBonusGifts.coin = item.Value;
				break;
			case NAAHKHPBAPA.Hammer:
				jsonDailyBonusGifts.hammer = item.Value;
				break;
			case NAAHKHPBAPA.Anvil:
				jsonDailyBonusGifts.anvil = item.Value;
				break;
			case NAAHKHPBAPA.BoxingGlove:
				jsonDailyBonusGifts.boxingglove = item.Value;
				break;
			case NAAHKHPBAPA.Rocket:
				jsonDailyBonusGifts.rocket = item.Value;
				break;
			case NAAHKHPBAPA.Bomb:
				jsonDailyBonusGifts.bomb = item.Value;
				break;
			case NAAHKHPBAPA.DiscoBall:
				jsonDailyBonusGifts.discoball = item.Value;
				break;
			case NAAHKHPBAPA.Dice:
				jsonDailyBonusGifts.dice = item.Value;
				break;
			}
		}
		JsonInventory jsonInventory = new JsonInventory();
		jsonInventory.LDOCFEGBGNK();
		JsonDailyBonus jsonDailyBonus = new JsonDailyBonus();
		jsonDailyBonus.gifts = jsonDailyBonusGifts;
		jsonDailyBonus.inventory = jsonInventory;
		JsonDailyBonus jsonDailyBonus2 = jsonDailyBonus;
		jsonDailyBonus2.LLGLAHKBJJG();
		JLJGBGFPKKC("Calendar", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, CIPBDDKIDEF, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), null, null, jsonDailyBonus2);
	}

	public static void KNAEDLINDAG(JsonLevelStarChest DKFEDBOLEKA)
	{
		JLJGBGFPKKC("CLRewardClaim", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), null, null, DKFEDBOLEKA);
	}

	public static void FIBBNCGGJFN(int GCKOBKBPOBE, int JEAAHAFHDEG, JsonLevelStarChest DKFEDBOLEKA)
	{
		JLJGBGFPKKC("STClaim", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, JEAAHAFHDEG, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), LECPGNKOABP.GABGKBAKHDP.KJACEODCOHN, GCKOBKBPOBE.ToString(), DKFEDBOLEKA);
	}

	public static void NPHHNNEIBOA(int GCKOBKBPOBE, int JEAAHAFHDEG, JsonTeamTournament AJCBKGCKPEJ)
	{
		JLJGBGFPKKC("TTClaim", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, JEAAHAFHDEG, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), LECPGNKOABP.GABGKBAKHDP.OADDPGNIINO.ToString(), GCKOBKBPOBE.ToString(), AJCBKGCKPEJ);
	}

	public static void IHKFEAOILLJ(NBMLNEENDHA MBBPBGHKLJM, bool EOHHFIPAAHM)
	{
		JsonLifeHack jsonLifeHack = new JsonLifeHack();
		jsonLifeHack.inventory = new JsonInventory();
		jsonLifeHack.hacked_cl_stage = MBBPBGHKLJM.AFOGPHMCPLN;
		jsonLifeHack.hacked_inventory = MBBPBGHKLJM.CMKBDJLNCND;
		JsonLifeHack jsonLifeHack2 = jsonLifeHack;
		jsonLifeHack2.inventory.LDOCFEGBGNK();
		jsonLifeHack2.LLGLAHKBJJG();
		JLJGBGFPKKC("LifeHackRestore", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, MBBPBGHKLJM.KOPMPMIFHNF, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), (!EOHHFIPAAHM) ? "0" : "1", null, jsonLifeHack2);
	}

	public static void FKKAMHFBIFI(int FADKFJJBNCL, string EAFCJLOFBLP)
	{
		JsonBuyCoinsData jsonBuyCoinsData = new JsonBuyCoinsData();
		jsonBuyCoinsData.if_life_refill = OutOfLivesDialog.RefillStatus;
		JsonBuyCoinsData jsonBuyCoinsData2 = jsonBuyCoinsData;
		jsonBuyCoinsData2.LLGLAHKBJJG();
		JLJGBGFPKKC("BuyCoinsPopupOpened", EGPIKEDHAKN(), FADKFJJBNCL, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), null, EAFCJLOFBLP, jsonBuyCoinsData2);
	}

	public static void AGEANPJMOHG(long EMNOJOHFMEH, int GCKOBKBPOBE, int KHJFCFLFCCN, int CAEMELGEOAE, Dictionary<NAAHKHPBAPA, int> GKNKMDIPAIK)
	{
		JsonTeamChest jsonTeamChest = new JsonTeamChest();
		jsonTeamChest.star_count_goal = CAEMELGEOAE;
		jsonTeamChest.star_count_collected = KHJFCFLFCCN;
		JsonTeamChest jsonTeamChest2 = jsonTeamChest;
		if (GKNKMDIPAIK != null)
		{
			jsonTeamChest2.gifts = new JsonTeamChestGifts();
			foreach (KeyValuePair<NAAHKHPBAPA, int> item in GKNKMDIPAIK)
			{
				switch (item.Key)
				{
				case NAAHKHPBAPA.Coins:
					jsonTeamChest2.gifts.coin = item.Value;
					break;
				case NAAHKHPBAPA.Hammer:
					jsonTeamChest2.gifts.hammer = item.Value;
					break;
				case NAAHKHPBAPA.Anvil:
					jsonTeamChest2.gifts.anvil = item.Value;
					break;
				case NAAHKHPBAPA.BoxingGlove:
					jsonTeamChest2.gifts.boxingglove = item.Value;
					break;
				case NAAHKHPBAPA.Rocket:
					jsonTeamChest2.gifts.rocket = item.Value;
					break;
				case NAAHKHPBAPA.Bomb:
					jsonTeamChest2.gifts.bomb = item.Value;
					break;
				case NAAHKHPBAPA.DiscoBall:
					jsonTeamChest2.gifts.discoball = item.Value;
					break;
				case NAAHKHPBAPA.Dice:
					jsonTeamChest2.gifts.dice = item.Value;
					break;
				default:
					GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Events, "Error creating SendChest Event");
					break;
				case NAAHKHPBAPA.None:
				case NAAHKHPBAPA.Extra5Moves:
				case NAAHKHPBAPA.UserType:
				case NAAHKHPBAPA.PaintBrush:
					break;
				}
			}
		}
		JsonInventory jsonInventory = new JsonInventory();
		jsonInventory.LDOCFEGBGNK();
		jsonTeamChest2.inventory = jsonInventory;
		jsonTeamChest2.LLGLAHKBJJG();
		JLJGBGFPKKC("TeamChest", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, (GKNKMDIPAIK != null) ? 1 : 0, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), EMNOJOHFMEH.ToString(), GCKOBKBPOBE.ToString(), jsonTeamChest2);
	}

	public static void BKFLNLDNEPM(int GCKOBKBPOBE, int KHJFCFLFCCN, int CAEMELGEOAE, Dictionary<NAAHKHPBAPA, int> GKNKMDIPAIK)
	{
		JsonTreasureHunt jsonTreasureHunt = new JsonTreasureHunt();
		jsonTreasureHunt.key_goal = CAEMELGEOAE;
		jsonTreasureHunt.key_collected = KHJFCFLFCCN;
		JsonTreasureHunt jsonTreasureHunt2 = jsonTreasureHunt;
		if (GKNKMDIPAIK != null)
		{
			jsonTreasureHunt2.gifts = new JsonTreasureHuntGifts();
			foreach (KeyValuePair<NAAHKHPBAPA, int> item in GKNKMDIPAIK)
			{
				switch (item.Key)
				{
				case NAAHKHPBAPA.Coins:
					jsonTreasureHunt2.gifts.coin = item.Value;
					break;
				case NAAHKHPBAPA.Hammer:
					jsonTreasureHunt2.gifts.hammer = item.Value;
					break;
				case NAAHKHPBAPA.Anvil:
					jsonTreasureHunt2.gifts.anvil = item.Value;
					break;
				case NAAHKHPBAPA.BoxingGlove:
					jsonTreasureHunt2.gifts.boxingglove = item.Value;
					break;
				case NAAHKHPBAPA.Rocket:
					jsonTreasureHunt2.gifts.rocket = item.Value;
					break;
				case NAAHKHPBAPA.Bomb:
					jsonTreasureHunt2.gifts.bomb = item.Value;
					break;
				case NAAHKHPBAPA.DiscoBall:
					jsonTreasureHunt2.gifts.discoball = item.Value;
					break;
				case NAAHKHPBAPA.Dice:
					jsonTreasureHunt2.gifts.dice = item.Value;
					break;
				case NAAHKHPBAPA.Life:
					jsonTreasureHunt2.gifts.life = item.Value;
					break;
				default:
					GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Events, "Error creating SendTreasureHunt Event");
					break;
				case NAAHKHPBAPA.None:
				case NAAHKHPBAPA.Extra5Moves:
				case NAAHKHPBAPA.UserType:
				case NAAHKHPBAPA.PaintBrush:
					break;
				}
			}
		}
		JsonInventory jsonInventory = new JsonInventory();
		jsonInventory.LDOCFEGBGNK();
		jsonTreasureHunt2.inventory = jsonInventory;
		jsonTreasureHunt2.LLGLAHKBJJG();
		JLJGBGFPKKC("TreasureHunt", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, (GKNKMDIPAIK != null) ? 1 : 0, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), LECPGNKOABP.GABGKBAKHDP.OADDPGNIINO.ToString(), GCKOBKBPOBE.ToString(), jsonTreasureHunt2);
	}

	public static void NMOKOLHHNIH(string DBCKEALABNC, string GNLHNMLIEFN)
	{
		JsonChangeName jsonChangeName = new JsonChangeName();
		jsonChangeName.LLGLAHKBJJG();
		jsonChangeName.old_name = DBCKEALABNC;
		jsonChangeName.new_name = GNLHNMLIEFN;
		JLJGBGFPKKC("ChangeName", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), null, null, jsonChangeName);
	}

	public static void JIPLLFBJBIL(string FBKDKPCDMMK, int PLOIEOAAOLA)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PeakAnalytics, "Event Triggered Nickname >UserId:{0} Nick:{1} CreateType:{2}", LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM, FBKDKPCDMMK, PLOIEOAAOLA);
		JsonSocialNickname jsonSocialNickname = new JsonSocialNickname();
		jsonSocialNickname.country = string.Empty;
		jsonSocialNickname.inventory = new JsonSocialInventoryHC
		{
			HC = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins)
		};
		JsonSocialNickname jsonSocialNickname2 = jsonSocialNickname;
		jsonSocialNickname2.LLGLAHKBJJG();
		JLJGBGFPKKC("Nickname", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, PLOIEOAAOLA, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), string.Empty, FBKDKPCDMMK, jsonSocialNickname2);
	}

	public static void JIPLLFBJBIL(AKGIJAMHMNA FMEJGLGPIBJ, int PLOIEOAAOLA)
	{
		if (MDMLFPDLFLE.OMHOPHKCJNI)
		{
			MDMLFPDLFLE.OMHOPHKCJNI = false;
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PeakAnalytics, "Event Triggered Nickname >UserId:{0} Nick:{1} TeamId:{2} CreateType:{3}", LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM, FMEJGLGPIBJ.EALJKKBHDHK, FMEJGLGPIBJ.OADDPGNIINO, (PLOIEOAAOLA != 0) ? "Create" : "Join");
			JsonSocialNickname jsonSocialNickname = new JsonSocialNickname();
			jsonSocialNickname.country = FMEJGLGPIBJ.NKOHDLBCJBK;
			jsonSocialNickname.inventory = new JsonSocialInventoryHC
			{
				HC = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins) + BOKGFGFPOHD.MFDPEOHIKKH.FDNCJEHPFFJ
			};
			JsonSocialNickname lCPOFOEDKCA = jsonSocialNickname;
			JLJGBGFPKKC("Nickname", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, PLOIEOAAOLA, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), FMEJGLGPIBJ.OADDPGNIINO.ToString(), FMEJGLGPIBJ.EALJKKBHDHK, lCPOFOEDKCA);
		}
	}

	public static void LLKGLKPILOK(JPLIGBJJCOE ECBDGMPPBKF, string FKEJDEKFLCJ, int? DOJJAMKKINP, int? BPKJLGJDFKG = null)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PeakAnalytics, "Event Triggered TeamJoin > TeamId:{0} Channel:{1} Referral:{2}", ECBDGMPPBKF.NJHFLHNDFHH.EEFMIHDPJPG.ToString(), FKEJDEKFLCJ, DOJJAMKKINP);
		int num = OIAJPMNJGLK.HOGCELOOGEP();
		int weekly_helps = 0;
		if (num == (int)ECBDGMPPBKF.NJHFLHNDFHH.KEMNAAPNAPA)
		{
			weekly_helps = (int)ECBDGMPPBKF.NJHFLHNDFHH.AKNLLPAHFOK;
		}
		JsonTeamJoin jsonTeamJoin = new JsonTeamJoin();
		jsonTeamJoin.team_member_count_after = ECBDGMPPBKF.NJHFLHNDFHH.HOINIMJNGFK.Count;
		jsonTeamJoin.team_score = (int)ECBDGMPPBKF.NJHFLHNDFHH.HOINIMJNGFK.Values.Sum((AKGIJAMHMNA IBBBMACIBGK) => IBBBMACIBGK.CALJBGILMOL);
		jsonTeamJoin.weekly_helps = weekly_helps;
		JsonTeamJoin jsonTeamJoin2 = jsonTeamJoin;
		jsonTeamJoin2.LLGLAHKBJJG();
		JLJGBGFPKKC("TeamJoin", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, DOJJAMKKINP, BPKJLGJDFKG.HasValue ? BPKJLGJDFKG.ToString() : LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), ECBDGMPPBKF.NJHFLHNDFHH.EEFMIHDPJPG.ToString(), FKEJDEKFLCJ, jsonTeamJoin2);
		DJFPMCMLPJJ.LLKGLKPILOK();
		NFDHFOAMOCD.BEKHANMCLGP();
	}

	public static void CNAFBPLNECO(DKBEJLGEAOA IIIMBFFNNBN, long BPKJLGJDFKG, int NBFBPNNEKMN)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PeakAnalytics, "Event Triggered TeamLeave > TeamId:{0} UserId:{1} Referral:{2}", IIIMBFFNNBN.EEFMIHDPJPG.ToString(), BPKJLGJDFKG, (NBFBPNNEKMN != 0) ? "Kick" : "Leave");
		int num = OIAJPMNJGLK.HOGCELOOGEP();
		int weekly_helps = 0;
		if (num == (int)IIIMBFFNNBN.KEMNAAPNAPA)
		{
			weekly_helps = (int)IIIMBFFNNBN.AKNLLPAHFOK;
		}
		JsonTeamLeave jsonTeamLeave = new JsonTeamLeave();
		jsonTeamLeave.team_member_count_after = (int)IIIMBFFNNBN.GMCGMPEEHJP - 1;
		jsonTeamLeave.team_score = (int)IIIMBFFNNBN.HOINIMJNGFK.Values.Sum((AKGIJAMHMNA IBBBMACIBGK) => IBBBMACIBGK.CALJBGILMOL);
		jsonTeamLeave.team_leader_id = (int)IIIMBFFNNBN.AFPDGDAEENM;
		jsonTeamLeave.weekly_helps = weekly_helps;
		JsonTeamLeave jsonTeamLeave2 = jsonTeamLeave;
		jsonTeamLeave2.LLGLAHKBJJG();
		JLJGBGFPKKC("TeamLeave", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, BPKJLGJDFKG.ToString(), IIIMBFFNNBN.EEFMIHDPJPG.ToString(), (NBFBPNNEKMN != 0) ? "Kick" : "Leave", jsonTeamLeave2);
	}

	public static void MDMPINKGLGH(bool LDHECNOPBNK, long? EMNOJOHFMEH, long? PEHFPDCGFCG)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PeakAnalytics, "Event Triggered {0} > Accepted:{1} TeamId:{2} Leader:{3}", "ClosedTeamRespond", LDHECNOPBNK, EMNOJOHFMEH, PEHFPDCGFCG);
		JLJGBGFPKKC("ClosedTeamRespond", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, LDHECNOPBNK ? 1 : 0, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), EMNOJOHFMEH.HasValue ? EMNOJOHFMEH.ToString() : string.Empty, PEHFPDCGFCG.HasValue ? PEHFPDCGFCG.ToString() : string.Empty);
	}

	public static void EMAFFMGNPEO(int EMNOJOHFMEH, int MLAKFABEIIE)
	{
		JLJGBGFPKKC("SuggestedTeamFull", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, MLAKFABEIIE, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), EMNOJOHFMEH.ToString());
	}

	public static void BPEPHMJPIDE(Dictionary<string, object> LEPMLBKFMCK, EIPCLBONPLC PEBICCFPCFE)
	{
		JsonTeamCreate jsonTeamCreate = new JsonTeamCreate();
		jsonTeamCreate.required_level = (int)LEPMLBKFMCK["level"];
		jsonTeamCreate.country = PEBICCFPCFE.ADCMNJCINBO.NKOHDLBCJBK;
		jsonTeamCreate.badge_id = (string)LEPMLBKFMCK["badge"];
		jsonTeamCreate.team_description = HFFNPEPPBCC.OJHJEGCAPLF((string)LEPMLBKFMCK["desc"]);
		jsonTeamCreate.inventory = new JsonSocialInventoryHC
		{
			HC = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins)
		};
		JsonTeamCreate jsonTeamCreate2 = jsonTeamCreate;
		jsonTeamCreate2.LLGLAHKBJJG();
		JLJGBGFPKKC("TeamCreate", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, (int)LEPMLBKFMCK["closed"], LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), PEBICCFPCFE.ADCMNJCINBO.OADDPGNIINO.ToString(), (string)LEPMLBKFMCK["name"], jsonTeamCreate2);
	}

	public static void DBMNKIFNEHH(JsonTeamEdit BIPAJFCNEOB, bool MODOJGIGGJB, string JIJPBPPCLFG)
	{
		JLJGBGFPKKC("TeamEdit", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, MODOJGIGGJB ? 1 : 0, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), JIJPBPPCLFG, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), BIPAJFCNEOB);
	}

	public static void PEKCICFOPDG(EIPCLBONPLC PEBICCFPCFE, string OKAFCGEBIII)
	{
		int num = OIAJPMNJGLK.HOGCELOOGEP();
		int weekly_helps = 0;
		if (num == (int)PEBICCFPCFE.COPDAKACHFM.KEMNAAPNAPA)
		{
			weekly_helps = (int)PEBICCFPCFE.COPDAKACHFM.AKNLLPAHFOK;
		}
		JsonLifeAsk jsonLifeAsk = new JsonLifeAsk();
		jsonLifeAsk.team_member_count = (int)PEBICCFPCFE.COPDAKACHFM.GMCGMPEEHJP;
		jsonLifeAsk.weekly_helps = weekly_helps;
		JsonLifeAsk jsonLifeAsk2 = jsonLifeAsk;
		jsonLifeAsk2.LLGLAHKBJJG();
		JLJGBGFPKKC("LifeAsk", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), PEBICCFPCFE.COPDAKACHFM.EEFMIHDPJPG.ToString(), OKAFCGEBIII, jsonLifeAsk2);
	}

	public static void IIEPJFFOJPF(EIPCLBONPLC PEBICCFPCFE)
	{
		JLJGBGFPKKC("LifeInboxError", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), (PEBICCFPCFE.COPDAKACHFM != null) ? PEBICCFPCFE.COPDAKACHFM.EEFMIHDPJPG.ToString() : string.Empty, PEBICCFPCFE.HNOMLCAEBJP);
	}

	public static void ECOEKHPKHAM(EIPCLBONPLC PEBICCFPCFE, string OKAFCGEBIII)
	{
		int num = OIAJPMNJGLK.HOGCELOOGEP();
		int num2 = 0;
		if (num == (int)PEBICCFPCFE.COPDAKACHFM.KEMNAAPNAPA)
		{
			num2 = (int)PEBICCFPCFE.COPDAKACHFM.AKNLLPAHFOK;
		}
		JsonLifeHelp jsonLifeHelp = new JsonLifeHelp();
		jsonLifeHelp.team_member_count = (int)PEBICCFPCFE.COPDAKACHFM.GMCGMPEEHJP;
		jsonLifeHelp.weekly_helps = num2 + 1;
		jsonLifeHelp.inventory = new JsonSocialInventoryHC
		{
			HC = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins)
		};
		JsonLifeHelp jsonLifeHelp2 = jsonLifeHelp;
		jsonLifeHelp2.LLGLAHKBJJG();
		JLJGBGFPKKC("LifeHelp", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), PEBICCFPCFE.COPDAKACHFM.EEFMIHDPJPG.ToString(), OKAFCGEBIII, jsonLifeHelp2);
	}

	public static void GGEHLGGLMLP(List<IKDMCJPBBIH> HDECNOABBDG)
	{
		if (HDECNOABBDG == null || HDECNOABBDG.Count == 0 || !JHOAHCHHBCH.CCAJIIFJPFF())
		{
			return;
		}
		JHOAHCHHBCH.DOEPBGGEEEH(delegate(JsonPingData MBBPBGHKLJM)
		{
			int count = HDECNOABBDG.Count;
			JsonTimeout jsonTimeout = new JsonTimeout
			{
				ping = MBBPBGHKLJM
			};
			jsonTimeout.LLGLAHKBJJG();
			int num = 0;
			string text = string.Empty;
			string text2 = " ";
			for (int i = 0; i < count; i++)
			{
				text = string.Concat(text, HDECNOABBDG[i].LOICNFDHCJK, text2);
				num = HDECNOABBDG[i].MCFABAAMELG();
			}
			JLJGBGFPKKC("ServerTimeout", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), text, num.ToString(), jsonTimeout);
		});
	}

	public static void KKMLABPMGIB(List<IKDMCJPBBIH> HDECNOABBDG, string LENFKJMEBFP)
	{
		if (HDECNOABBDG == null || HDECNOABBDG.Count == 0 || !JHOAHCHHBCH.CCAJIIFJPFF())
		{
			return;
		}
		JHOAHCHHBCH.DOEPBGGEEEH(delegate(JsonPingData MBBPBGHKLJM)
		{
			int count = HDECNOABBDG.Count;
			JsonTimeout jsonTimeout = new JsonTimeout
			{
				ping = MBBPBGHKLJM
			};
			jsonTimeout.LLGLAHKBJJG();
			string text = string.Empty;
			for (int i = 0; i < count; i++)
			{
				text += HDECNOABBDG[i].LOICNFDHCJK;
			}
			if (LENFKJMEBFP != null && LENFKJMEBFP.Length > 100)
			{
				LENFKJMEBFP = LENFKJMEBFP.Substring(0, 100);
			}
			JLJGBGFPKKC("ServerError", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), text, LENFKJMEBFP, jsonTimeout);
		});
	}

	public static void FCAEELLNLFA(List<IKDMCJPBBIH> HDECNOABBDG)
	{
		if (HDECNOABBDG == null || HDECNOABBDG.Count == 0 || !JHOAHCHHBCH.CCAJIIFJPFF())
		{
			return;
		}
		JHOAHCHHBCH.DOEPBGGEEEH(delegate(JsonPingData MBBPBGHKLJM)
		{
			JsonTimeout jsonTimeout = new JsonTimeout
			{
				ping = MBBPBGHKLJM
			};
			jsonTimeout.LLGLAHKBJJG();
			int count = HDECNOABBDG.Count;
			string text = string.Empty;
			for (int i = 0; i < count; i++)
			{
				text += HDECNOABBDG[i].LOICNFDHCJK;
			}
			JLJGBGFPKKC("ServerAbort", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), text, "Aborted", jsonTimeout);
		});
	}

	public static void LNAGBLOFBIN(bool OGAEECANDHB)
	{
		if (JHOAHCHHBCH.CCAJIIFJPFF())
		{
			JHOAHCHHBCH.DOEPBGGEEEH(delegate(JsonPingData MBBPBGHKLJM)
			{
				JsonTimeout jsonTimeout = new JsonTimeout
				{
					ping = MBBPBGHKLJM
				};
				jsonTimeout.LLGLAHKBJJG();
				JLJGBGFPKKC("ServerFallback", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), (!OGAEECANDHB) ? "fail" : "success", null, jsonTimeout);
			});
		}
	}

	public static void LCACHLKLPCO(Error LENFKJMEBFP)
	{
		JHOAHCHHBCH.DOEPBGGEEEH(delegate(JsonPingData MBBPBGHKLJM)
		{
			JsonTimeout jsonTimeout = new JsonTimeout
			{
				ping = MBBPBGHKLJM
			};
			jsonTimeout.LLGLAHKBJJG();
			string dGFPCOODPCB = ((LENFKJMEBFP != null) ? LENFKJMEBFP.Code.ToString() : null);
			string text = ((LENFKJMEBFP != null) ? LENFKJMEBFP.Message : null);
			if (text != null && text.Length > 100)
			{
				text = text.Substring(0, 100);
			}
			JLJGBGFPKKC("SocketDisconnected", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), dGFPCOODPCB, text, jsonTimeout);
		});
	}

	public static void OEFHHOFLGFN(int AAKHAPBEGDO)
	{
		JHOAHCHHBCH.DOEPBGGEEEH(delegate(JsonPingData MBBPBGHKLJM)
		{
			JsonTimeout jsonTimeout = new JsonTimeout
			{
				ping = MBBPBGHKLJM
			};
			jsonTimeout.LLGLAHKBJJG();
			JLJGBGFPKKC("SocketConnectionError", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), null, AAKHAPBEGDO.ToString(), jsonTimeout);
		});
	}

	[CompilerGenerated]
	private static long LFOHKHEDJCI(AKGIJAMHMNA IBBBMACIBGK)
	{
		return IBBBMACIBGK.CALJBGILMOL;
	}

	[CompilerGenerated]
	private static long CFGPJKLFMHC(AKGIJAMHMNA IBBBMACIBGK)
	{
		return IBBBMACIBGK.CALJBGILMOL;
	}
}
