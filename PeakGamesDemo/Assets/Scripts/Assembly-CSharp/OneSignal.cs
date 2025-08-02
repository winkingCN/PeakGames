using System;
using System.Collections.Generic;
using UnityEngine;

public class OneSignal : MonoBehaviour
{
	public delegate void EJBNDCLLMCF(BFIJOGBGCNK IDFKOGCNBHM);

	public delegate void JAPOENDFIDB();

	public delegate void BCLDBAPELON(Dictionary<string, object> LENFKJMEBFP);

	public delegate void AAMNCBEDHGI();

	public delegate void CPOHOPNDPPK(Dictionary<string, object> LENFKJMEBFP);

	public delegate void HMBEECHAIHA(LFMKFEKMMIK DIDHNNMKJFE);

	public delegate void KINAOEOAIHE(string LBDCIEBBJOK, string IEOMNLGGALD);

	public delegate void DAGLNKFIOED(Dictionary<string, object> NIJLMBACDIN);

	public delegate void AGLAELMDGBJ(bool NNGJNLLNBDC);

	public delegate void FPOGNEPMCMN(Dictionary<string, object> OMJOIIOONMO);

	public delegate void HILLAOIIILG(Dictionary<string, object> OMJOIIOONMO);

	public delegate void NGMDCKPIBKF(MIKPOELFDIL DBDNMMJGNBL);

	public delegate void JJADKOBEHKC(OAEFFLGOHEC DBDNMMJGNBL);

	public delegate void ODDFJIHBFKE(EJJOFNDGMNL DBDNMMJGNBL);

	public enum IGBMNDNCLPK
	{
		NONE = 0,
		FATAL = 1,
		ERROR = 2,
		WARN = 3,
		INFO = 4,
		DEBUG = 5,
		VERBOSE = 6
	}

	public enum NDNHJFICCIA
	{
		None = 0,
		InAppAlert = 1,
		Notification = 2
	}

	public class DNECJADMMIA
	{
		public string BKMHJPECJAM;

		public string MPHIKFAGGOO;

		public Dictionary<string, bool> IKLEDNGHOBF;

		public EJBNDCLLMCF MBBKGGICGPE;

		public HMBEECHAIHA PHAEAGHNMDG;

		public DNECJADMMIA LLHFCAEPMHO(EJBNDCLLMCF PJAGIAJAHBN)
		{
			MBBKGGICGPE = PJAGIAJAHBN;
			return this;
		}

		public DNECJADMMIA AGDNCKLIKOD(HMBEECHAIHA LIINDKHKIOJ)
		{
			PHAEAGHNMDG = LIINDKHKIOJ;
			return this;
		}

		public DNECJADMMIA HOOGMKJNOJD(NDNHJFICCIA KACNEFJPIPK)
		{
			NFOEKFNKHNO = KACNEFJPIPK;
			return this;
		}

		public DNECJADMMIA ANMFNMEGOJA(Dictionary<string, bool> EFHGEMMPDPC)
		{
			return this;
		}

		public void JAEKDGIAAKM()
		{
			DIOELAHNLKJ();
		}

		public DNECJADMMIA DDJHDBCEMLC(bool HBEHEELHKLP)
		{
			DCMEAEEBJLH = true;
			return this;
		}
	}

	public static KINAOEOAIHE idsAvailableDelegate;

	public static DAGLNKFIOED tagsReceivedDelegate;

	private static AGLAELMDGBJ MFPGNEGBJEN;

	private static NGMDCKPIBKF KOEDAJFKBFE;

	private static bool IFFGAEHGADH;

	private static JJADKOBEHKC CKFMLIGNNPD;

	private static bool NEKANEFMMMJ;

	private static ODDFJIHBFKE NHKFLIPKFCH;

	private static bool NPNOEHNNIOB;

	public const string kOSSettingsAutoPrompt = "kOSSettingsAutoPrompt";

	public const string kOSSettingsInAppLaunchURL = "kOSSettingsInAppLaunchURL";

	internal static DNECJADMMIA OFIAADJFEDJ;

	private static MFCJIFNNIHI BKBJEDJOMCF;

	private const string HIFGMOMJMLH = "OneSignalRuntimeObject_KEEP";

	private static IGBMNDNCLPK PDGNEDBOGLE = IGBMNDNCLPK.INFO;

	private static IGBMNDNCLPK HCFFMBMDKNF;

	internal static bool DCMEAEEBJLH;

	internal static FPOGNEPMCMN NBIAPCNNLDB;

	internal static HILLAOIIILG ONJBGFFCMDM;

	internal static JAPOENDFIDB DMIHKIPFPLG;

	internal static BCLDBAPELON MCJJOJJBJDK;

	internal static AAMNCBEDHGI EBIHJCKODFC;

	internal static CPOHOPNDPPK DNAEMJEFMMH;

	private static NDNHJFICCIA NHMDALBFDON = NDNHJFICCIA.InAppAlert;

	public static NDNHJFICCIA NFOEKFNKHNO
	{
		get
		{
			return NHMDALBFDON;
		}
		set
		{
			NHMDALBFDON = value;
			if (BKBJEDJOMCF != null)
			{
				BKBJEDJOMCF.AIJCJPAPNCP(NHMDALBFDON);
			}
		}
	}

	public static event NGMDCKPIBKF OJOKHMBEFED
	{
		add
		{
			if (BKBJEDJOMCF != null)
			{
				KOEDAJFKBFE = (NGMDCKPIBKF)Delegate.Combine(KOEDAJFKBFE, value);
				COEAOFJJANM();
			}
		}
		remove
		{
			if (BKBJEDJOMCF != null)
			{
				KOEDAJFKBFE = (NGMDCKPIBKF)Delegate.Remove(KOEDAJFKBFE, value);
				if (IFFGAEHGADH && KOEDAJFKBFE.GetInvocationList().Length == 0)
				{
					IFFGAEHGADH = false;
					BKBJEDJOMCF.IJKJFPJHFHD();
				}
			}
		}
	}

	public static event JJADKOBEHKC NEHCPDGCAKP
	{
		add
		{
			if (BKBJEDJOMCF != null)
			{
				CKFMLIGNNPD = (JJADKOBEHKC)Delegate.Combine(CKFMLIGNNPD, value);
				BFFJKLFFKBF();
			}
		}
		remove
		{
			if (BKBJEDJOMCF != null)
			{
				CKFMLIGNNPD = (JJADKOBEHKC)Delegate.Remove(CKFMLIGNNPD, value);
				if (NEKANEFMMMJ && CKFMLIGNNPD.GetInvocationList().Length == 0)
				{
					BKBJEDJOMCF.PFCFFFLDMDE();
				}
			}
		}
	}

	public static event ODDFJIHBFKE HHGOBCHEGPC
	{
		add
		{
			if (BKBJEDJOMCF != null)
			{
				NHKFLIPKFCH = (ODDFJIHBFKE)Delegate.Combine(NHKFLIPKFCH, value);
				CDFIEJNIDEA();
			}
		}
		remove
		{
			if (BKBJEDJOMCF != null)
			{
				NHKFLIPKFCH = (ODDFJIHBFKE)Delegate.Remove(NHKFLIPKFCH, value);
				if (NPNOEHNNIOB && NHKFLIPKFCH.GetInvocationList().Length == 0)
				{
					BKBJEDJOMCF.JJBOHMCEBPH();
				}
			}
		}
	}

	private static void COEAOFJJANM()
	{
		if (!IFFGAEHGADH && KOEDAJFKBFE != null && KOEDAJFKBFE.GetInvocationList().Length > 0)
		{
			IFFGAEHGADH = true;
			BKBJEDJOMCF.COEAOFJJANM();
		}
	}

	private static void BFFJKLFFKBF()
	{
		if (!NEKANEFMMMJ && CKFMLIGNNPD != null && CKFMLIGNNPD.GetInvocationList().Length > 0)
		{
			NEKANEFMMMJ = true;
			BKBJEDJOMCF.BFFJKLFFKBF();
		}
	}

	private static void CDFIEJNIDEA()
	{
		if (!NPNOEHNNIOB && NHKFLIPKFCH != null && NHKFLIPKFCH.GetInvocationList().Length > 0)
		{
			NPNOEHNNIOB = true;
			BKBJEDJOMCF.CDFIEJNIDEA();
		}
	}

	public static DNECJADMMIA StartInit(string BKMHJPECJAM, string MPHIKFAGGOO = null)
	{
		if (OFIAADJFEDJ == null)
		{
			OFIAADJFEDJ = new DNECJADMMIA();
		}
		OFIAADJFEDJ.BKMHJPECJAM = BKMHJPECJAM;
		OFIAADJFEDJ.MPHIKFAGGOO = MPHIKFAGGOO;
		return OFIAADJFEDJ;
	}

	private static void DIOELAHNLKJ()
	{
		AIOIBENNNBB();
	}

	private static void AIOIBENNNBB()
	{
		if (BKBJEDJOMCF == null && OFIAADJFEDJ != null)
		{
			GEEAMOCHJDB();
			GameObject gameObject = new GameObject("OneSignalRuntimeObject_KEEP");
			gameObject.AddComponent<OneSignal>();
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			COEAOFJJANM();
			BFFJKLFFKBF();
		}
	}

	private static void GEEAMOCHJDB()
	{
		BKBJEDJOMCF = new DFJECMCCJGC("OneSignalRuntimeObject_KEEP", OFIAADJFEDJ.MPHIKFAGGOO, OFIAADJFEDJ.BKMHJPECJAM, NFOEKFNKHNO, PDGNEDBOGLE, HCFFMBMDKNF, DCMEAEEBJLH);
	}

	private static void GFGPHLMJDLL()
	{
		MonoBehaviour.print("Please run OneSignal on a device to see push notifications.");
	}

	public static void SetLogLevel(IGBMNDNCLPK ONBOAPLKAIG, IGBMNDNCLPK JCGLMKADEEP)
	{
		PDGNEDBOGLE = ONBOAPLKAIG;
		HCFFMBMDKNF = JCGLMKADEEP;
	}

	public static void SetLocationShared(bool DIHAHEPGCLB)
	{
		Debug.Log("Called OneSignal.cs SetLocationShared");
		BKBJEDJOMCF.EHAGACDCKFK(DIHAHEPGCLB);
	}

	public static void SendTag(string MELLKFCHLCG, string MNCFEDGGAJM)
	{
		BKBJEDJOMCF.EFMGJJAMOLL(MELLKFCHLCG, MNCFEDGGAJM);
	}

	public static void SendTags(Dictionary<string, string> NIJLMBACDIN)
	{
		BKBJEDJOMCF.FFHDGIBPADH(NIJLMBACDIN);
	}

	public static void GetTags(DAGLNKFIOED PIMEMIPFEJE)
	{
		tagsReceivedDelegate = PIMEMIPFEJE;
		BKBJEDJOMCF.MGKBPJLBNLA();
	}

	public static void GetTags()
	{
		BKBJEDJOMCF.MGKBPJLBNLA();
	}

	public static void DeleteTag(string IKNCPEPOKGJ)
	{
		BKBJEDJOMCF.GJMCAGHFOAO(IKNCPEPOKGJ);
	}

	public static void DeleteTags(IList<string> JFPPHGPOOAA)
	{
		BKBJEDJOMCF.ENHDPFKMALA(JFPPHGPOOAA);
	}

	public static void RegisterForPushNotifications()
	{
		BKBJEDJOMCF.CGPGIHFFLLI();
	}

	public static void PromptForPushNotificationsWithUserResponse(AGLAELMDGBJ OCINAFCMBFH)
	{
		MFPGNEGBJEN = OCINAFCMBFH;
		BKBJEDJOMCF.KINGLACPPID();
	}

	public static void IdsAvailable(KINAOEOAIHE GDMOKEKACNN)
	{
		idsAvailableDelegate = GDMOKEKACNN;
		BKBJEDJOMCF.ILOJEBPJOBD();
	}

	public static void IdsAvailable()
	{
		BKBJEDJOMCF.ILOJEBPJOBD();
	}

	public static void EnableVibrate(bool DOKMPEOLBGO)
	{
		((DFJECMCCJGC)BKBJEDJOMCF).JNMHIBFHPJF(DOKMPEOLBGO);
	}

	public static void EnableSound(bool DOKMPEOLBGO)
	{
		((DFJECMCCJGC)BKBJEDJOMCF).MIPHODFHOGJ(DOKMPEOLBGO);
	}

	public static void ClearOneSignalNotifications()
	{
		((DFJECMCCJGC)BKBJEDJOMCF).GHBDDIGJLBL();
	}

	public static void SetSubscription(bool DOKMPEOLBGO)
	{
		BKBJEDJOMCF.NNNGBMJPBDG(DOKMPEOLBGO);
	}

	public static void PostNotification(Dictionary<string, object> MBBPBGHKLJM)
	{
		PostNotification(MBBPBGHKLJM, null, null);
	}

	public static void SetEmail(string HCMFNNPEKDN, JAPOENDFIDB CPNLPPGFMEG, BCLDBAPELON CCJAMDKPGMD)
	{
		DMIHKIPFPLG = CPNLPPGFMEG;
		MCJJOJJBJDK = CCJAMDKPGMD;
		BKBJEDJOMCF.MABLPNJIOMF(HCMFNNPEKDN);
	}

	public static void SetEmail(string HCMFNNPEKDN, string LNLGEFGDJAM, JAPOENDFIDB CPNLPPGFMEG, BCLDBAPELON CCJAMDKPGMD)
	{
		DMIHKIPFPLG = CPNLPPGFMEG;
		MCJJOJJBJDK = CCJAMDKPGMD;
		BKBJEDJOMCF.MABLPNJIOMF(HCMFNNPEKDN, LNLGEFGDJAM);
	}

	public static void LogoutEmail(AAMNCBEDHGI CPNLPPGFMEG, CPOHOPNDPPK CCJAMDKPGMD)
	{
		EBIHJCKODFC = CPNLPPGFMEG;
		DNAEMJEFMMH = CCJAMDKPGMD;
		BKBJEDJOMCF.NFGIGGCADPP();
	}

	public static void SetEmail(string HCMFNNPEKDN)
	{
		BKBJEDJOMCF.MABLPNJIOMF(HCMFNNPEKDN);
	}

	public static void SetEmail(string HCMFNNPEKDN, string LNLGEFGDJAM)
	{
		BKBJEDJOMCF.MABLPNJIOMF(HCMFNNPEKDN, LNLGEFGDJAM);
	}

	public static void LogoutEmail()
	{
		BKBJEDJOMCF.NFGIGGCADPP();
	}

	public static void PostNotification(Dictionary<string, object> MBBPBGHKLJM, FPOGNEPMCMN MGOCKGELINP, HILLAOIIILG PFPNLMIBECH)
	{
		NBIAPCNNLDB = MGOCKGELINP;
		ONJBGFFCMDM = PFPNLMIBECH;
		BKBJEDJOMCF.DHJLPDPDNEB(MBBPBGHKLJM);
	}

	public static void SyncHashedEmail(string HCMFNNPEKDN)
	{
		BKBJEDJOMCF.FFEJJJNDGDH(HCMFNNPEKDN);
	}

	public static void PromptLocation()
	{
		BKBJEDJOMCF.HBHFHKNLPEN();
	}

	public static AMLCGIGPHEJ GetPermissionSubscriptionState()
	{
		return BKBJEDJOMCF.IIDINNBDNLD();
	}

	public static void UserDidProvideConsent(bool JCDGKPPFIMO)
	{
		BKBJEDJOMCF.GBJHBBFCFHG(JCDGKPPFIMO);
	}

	public static bool UserProvidedConsent()
	{
		return BKBJEDJOMCF.CDPNAOABJOF();
	}

	public static void SetRequiresUserPrivacyConsent(bool HBEHEELHKLP)
	{
		DCMEAEEBJLH = HBEHEELHKLP;
	}

	private BFIJOGBGCNK IOEADPPCGDD(Dictionary<string, object> NMFKGJMADEK)
	{
		BFIJOGBGCNK bFIJOGBGCNK = new BFIJOGBGCNK();
		BABCGLCEOOG bABCGLCEOOG = new BABCGLCEOOG();
		Dictionary<string, object> dictionary = NMFKGJMADEK["payload"] as Dictionary<string, object>;
		if (dictionary.ContainsKey("notificationID"))
		{
			bABCGLCEOOG.CMLKBABBIDE = dictionary["notificationID"] as string;
		}
		if (dictionary.ContainsKey("sound"))
		{
			bABCGLCEOOG.MMJGACMGOOP = dictionary["sound"] as string;
		}
		if (dictionary.ContainsKey("title"))
		{
			bABCGLCEOOG.FCEEGNFABAF = dictionary["title"] as string;
		}
		if (dictionary.ContainsKey("body"))
		{
			bABCGLCEOOG.KCIJNHPGJKF = dictionary["body"] as string;
		}
		if (dictionary.ContainsKey("subtitle"))
		{
			bABCGLCEOOG.FOJEGGDPNDI = dictionary["subtitle"] as string;
		}
		if (dictionary.ContainsKey("launchURL"))
		{
			bABCGLCEOOG.DEOKNANCLND = dictionary["launchURL"] as string;
		}
		if (dictionary.ContainsKey("additionalData"))
		{
			if (dictionary["additionalData"] is string)
			{
				bABCGLCEOOG.IBCOLBMIDPG = DINBABILEHB.NBPMNECNBHJ(dictionary["additionalData"] as string) as Dictionary<string, object>;
			}
			else
			{
				bABCGLCEOOG.IBCOLBMIDPG = dictionary["additionalData"] as Dictionary<string, object>;
			}
		}
		if (dictionary.ContainsKey("actionButtons"))
		{
			if (dictionary["actionButtons"] is string)
			{
				bABCGLCEOOG.FBOELJDJFLH = DINBABILEHB.NBPMNECNBHJ(dictionary["actionButtons"] as string) as Dictionary<string, object>;
			}
			else
			{
				bABCGLCEOOG.FBOELJDJFLH = dictionary["actionButtons"] as Dictionary<string, object>;
			}
		}
		if (dictionary.ContainsKey("contentAvailable"))
		{
			bABCGLCEOOG.OKABMIPOGID = (bool)dictionary["contentAvailable"];
		}
		if (dictionary.ContainsKey("badge"))
		{
			bABCGLCEOOG.PMKHOPIMKNH = Convert.ToInt32(dictionary["badge"]);
		}
		if (dictionary.ContainsKey("smallIcon"))
		{
			bABCGLCEOOG.HGIDDGDIONI = dictionary["smallIcon"] as string;
		}
		if (dictionary.ContainsKey("largeIcon"))
		{
			bABCGLCEOOG.KPOCMLKBCEC = dictionary["largeIcon"] as string;
		}
		if (dictionary.ContainsKey("bigPicture"))
		{
			bABCGLCEOOG.NDDFBELFEFE = dictionary["bigPicture"] as string;
		}
		if (dictionary.ContainsKey("smallIconAccentColor"))
		{
			bABCGLCEOOG.BAEMCCJEDEN = dictionary["smallIconAccentColor"] as string;
		}
		if (dictionary.ContainsKey("ledColor"))
		{
			bABCGLCEOOG.OGCJFONOAGM = dictionary["ledColor"] as string;
		}
		if (dictionary.ContainsKey("lockScreenVisibility"))
		{
			bABCGLCEOOG.PPJBFLEIMOD = Convert.ToInt32(dictionary["lockScreenVisibility"]);
		}
		if (dictionary.ContainsKey("groupKey"))
		{
			bABCGLCEOOG.BMNMLPLKCMC = dictionary["groupKey"] as string;
		}
		if (dictionary.ContainsKey("groupMessage"))
		{
			bABCGLCEOOG.MMKEELOEDND = dictionary["groupMessage"] as string;
		}
		if (dictionary.ContainsKey("fromProjectNumber"))
		{
			bABCGLCEOOG.GDFDKGODIHM = dictionary["fromProjectNumber"] as string;
		}
		bFIJOGBGCNK.AHJMDABAPGK = bABCGLCEOOG;
		if (NMFKGJMADEK.ContainsKey("isAppInFocus"))
		{
			bFIJOGBGCNK.BGBLKLOCKFA = (bool)NMFKGJMADEK["isAppInFocus"];
		}
		if (NMFKGJMADEK.ContainsKey("shown"))
		{
			bFIJOGBGCNK.MIPNFDDGCMF = (bool)NMFKGJMADEK["shown"];
		}
		if (NMFKGJMADEK.ContainsKey("silentNotification"))
		{
			bFIJOGBGCNK.DPHLADBLGEA = (bool)NMFKGJMADEK["silentNotification"];
		}
		if (NMFKGJMADEK.ContainsKey("androidNotificationId"))
		{
			bFIJOGBGCNK.PPKHOJALPAJ = Convert.ToInt32(NMFKGJMADEK["androidNotificationId"]);
		}
		if (NMFKGJMADEK.ContainsKey("displayType"))
		{
			bFIJOGBGCNK.HPANKMIPECP = (BFIJOGBGCNK.HFCNLPGHMIK)Convert.ToInt32(NMFKGJMADEK["displayType"]);
		}
		return bFIJOGBGCNK;
	}

	private void IICKMIFEMBN(string HDGFMHEHJBG)
	{
		if (OFIAADJFEDJ.MBBKGGICGPE != null)
		{
			Dictionary<string, object> nMFKGJMADEK = DINBABILEHB.NBPMNECNBHJ(HDGFMHEHJBG) as Dictionary<string, object>;
			OFIAADJFEDJ.MBBKGGICGPE(IOEADPPCGDD(nMFKGJMADEK));
		}
	}

	private void BHOALLADDIA(string HDGFMHEHJBG)
	{
		if (OFIAADJFEDJ.PHAEAGHNMDG == null)
		{
			return;
		}
		Dictionary<string, object> dictionary = DINBABILEHB.NBPMNECNBHJ(HDGFMHEHJBG) as Dictionary<string, object>;
		FGLNAAKGCPN fGLNAAKGCPN = new FGLNAAKGCPN();
		if (dictionary.ContainsKey("action"))
		{
			Dictionary<string, object> dictionary2 = dictionary["action"] as Dictionary<string, object>;
			if (dictionary2.ContainsKey("actionID"))
			{
				fGLNAAKGCPN.HHLPDCEDBHB = dictionary2["actionID"] as string;
			}
			if (dictionary2.ContainsKey("type"))
			{
				fGLNAAKGCPN.NBFBPNNEKMN = (FGLNAAKGCPN.LIIKHHNCPJF)Convert.ToInt32(dictionary2["type"]);
			}
		}
		LFMKFEKMMIK lFMKFEKMMIK = new LFMKFEKMMIK();
		lFMKFEKMMIK.IDFKOGCNBHM = IOEADPPCGDD((Dictionary<string, object>)dictionary["notification"]);
		lFMKFEKMMIK.GPLIOLJFDPM = fGLNAAKGCPN;
		OFIAADJFEDJ.PHAEAGHNMDG(lFMKFEKMMIK);
	}

	private void AMEFMKBEDKA(string HDGFMHEHJBG)
	{
		if (idsAvailableDelegate != null)
		{
			Dictionary<string, object> dictionary = DINBABILEHB.NBPMNECNBHJ(HDGFMHEHJBG) as Dictionary<string, object>;
			idsAvailableDelegate((string)dictionary["userId"], (string)dictionary["pushToken"]);
		}
	}

	private void AFFGOBPNGCI(string HDGFMHEHJBG)
	{
		if (tagsReceivedDelegate != null)
		{
			tagsReceivedDelegate(DINBABILEHB.NBPMNECNBHJ(HDGFMHEHJBG) as Dictionary<string, object>);
		}
	}

	private void EAOODFHNCIK(string OMJOIIOONMO)
	{
		if (NBIAPCNNLDB != null)
		{
			FPOGNEPMCMN nBIAPCNNLDB = NBIAPCNNLDB;
			ONJBGFFCMDM = null;
			NBIAPCNNLDB = null;
			nBIAPCNNLDB(DINBABILEHB.NBPMNECNBHJ(OMJOIIOONMO) as Dictionary<string, object>);
		}
	}

	private void EGHOLIHDGLO()
	{
		if (DMIHKIPFPLG != null)
		{
			JAPOENDFIDB dMIHKIPFPLG = DMIHKIPFPLG;
			DMIHKIPFPLG = null;
			MCJJOJJBJDK = null;
			dMIHKIPFPLG();
		}
	}

	private void OLGNALAGCKG(string LENFKJMEBFP)
	{
		if (MCJJOJJBJDK != null)
		{
			BCLDBAPELON mCJJOJJBJDK = MCJJOJJBJDK;
			MCJJOJJBJDK = null;
			DMIHKIPFPLG = null;
			mCJJOJJBJDK(DINBABILEHB.NBPMNECNBHJ(LENFKJMEBFP) as Dictionary<string, object>);
		}
	}

	private void GKPKNIBLIAD()
	{
		if (EBIHJCKODFC != null)
		{
			AAMNCBEDHGI eBIHJCKODFC = EBIHJCKODFC;
			EBIHJCKODFC = null;
			DNAEMJEFMMH = null;
			eBIHJCKODFC();
		}
	}

	private void GKDHBMOECEH(string LENFKJMEBFP)
	{
		if (DNAEMJEFMMH != null)
		{
			CPOHOPNDPPK dNAEMJEFMMH = DNAEMJEFMMH;
			DNAEMJEFMMH = null;
			EBIHJCKODFC = null;
			dNAEMJEFMMH(DINBABILEHB.NBPMNECNBHJ(LENFKJMEBFP) as Dictionary<string, object>);
		}
	}

	private void IOAIDCJMNGB(string OMJOIIOONMO)
	{
		if (ONJBGFFCMDM != null)
		{
			HILLAOIIILG oNJBGFFCMDM = ONJBGFFCMDM;
			ONJBGFFCMDM = null;
			NBIAPCNNLDB = null;
			oNJBGFFCMDM(DINBABILEHB.NBPMNECNBHJ(OMJOIIOONMO) as Dictionary<string, object>);
		}
	}

	private void GGCOABFMNJC(string CMECJOGHCCJ)
	{
		MIKPOELFDIL dBDNMMJGNBL = BKBJEDJOMCF.GMBFGDFNDHL(CMECJOGHCCJ);
		KOEDAJFKBFE(dBDNMMJGNBL);
	}

	private void CGMAAFBKJCB(string CMECJOGHCCJ)
	{
		OAEFFLGOHEC dBDNMMJGNBL = BKBJEDJOMCF.HBJBJGILCLI(CMECJOGHCCJ);
		CKFMLIGNNPD(dBDNMMJGNBL);
	}

	private void GEFFHLHMEEL(string CMECJOGHCCJ)
	{
		EJJOFNDGMNL dBDNMMJGNBL = BKBJEDJOMCF.HILMODDJFFC(CMECJOGHCCJ);
		NHKFLIPKFCH(dBDNMMJGNBL);
	}

	private void JGNMMCEDIDN(string NNGJNLLNBDC)
	{
		MFPGNEGBJEN(Convert.ToBoolean(NNGJNLLNBDC));
	}
}
