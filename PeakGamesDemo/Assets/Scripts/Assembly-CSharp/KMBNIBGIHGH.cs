using System;
using System.Collections.Generic;
using Assets.Scripts.MapScene;
using Assets.Scripts.Utils;
using UnityEngine;

public class KMBNIBGIHGH
{
	private const string IGBJOELNALL = "SupportHelperProxy";

	private const string NKFOABJLJND = "Player";

	private const string OMPGIBCBLFB = "2fe45e08527d6ad4a2d3b4bad9388ef3";

	private const string FGKNEMKHAIJ = "peakgames.helpshift.com";

	private const string DDDMMNPLDEJ = "peakgames_platform_20180117081200930-336799d13501c04";

	private const string LMLKKCKEOGF = "peakgames_platform_20180117081200181-eaa580b3479e3a8";

	private static KMBNIBGIHGH KNPOFJNFLJB;

	private NDBAKIHLPFG BJIENIICIEF;

	private Dictionary<string, object> GHDMEOGFJNC;

	private string KILNDOLGMEI;

	public int IOBIDNGDPIN { get; set; }

	public bool EGKCMNLKGHG
	{
		get
		{
			return BJIENIICIEF != null;
		}
	}

	public bool ACGKOEHCHHJ { get; set; }

	public static string CNLLFNKPIEG
	{
		get
		{
			return PlayerPrefs.GetString("LastLogFile");
		}
		private set
		{
			if (value == null)
			{
				PlayerPrefs.DeleteKey("LastLogFile");
			}
			else
			{
				PlayerPrefs.SetString("LastLogFile", value);
			}
		}
	}

	public static KMBNIBGIHGH GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB != null)
			{
				return KNPOFJNFLJB;
			}
			KNPOFJNFLJB = new KMBNIBGIHGH();
			GameObject gameObject = new GameObject("SupportHelperProxy");
			gameObject.AddComponent<HelpshiftCallbacks>();
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			return KNPOFJNFLJB;
		}
	}

	public static void LFPDGNCFIMP(bool IEGIOBJMGKJ)
	{
		GABGKBAKHDP.ACGKOEHCHHJ = IEGIOBJMGKJ;
		if (GABGKBAKHDP.ACGKOEHCHHJ)
		{
			GABGKBAKHDP.AMGPDMNGBLO();
		}
		else
		{
			GABGKBAKHDP.HNEGFLBPLJN();
		}
	}

	public void AMGPDMNGBLO()
	{
		if (BJIENIICIEF != null)
		{
			return;
		}
		try
		{
			LJJGOOKKHHE();
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Support, "Helpshift is not installed. Error:{0} Stack{1}", ex.Message, ex.StackTrace);
			BJIENIICIEF = null;
		}
	}

	private void LJJGOOKKHHE()
	{
		BJIENIICIEF = null;
		if (MCJHHDACJBG.OCLBKDOFADM)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Support, "Helpshift is not supported on Unity Editor.");
			return;
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add("unityGameObject", "SupportHelperProxy");
		dictionary.Add("enableInAppNotification", "no");
		dictionary.Add("enableLogging", "no");
		dictionary.Add("enableInboxPolling", "no");
		dictionary.Add("enableDefaultFallbackLanguage", "yes");
		dictionary.Add("screenOrientation", 1);
		dictionary.Add("disableEntryExitAnimations", "no");
		dictionary.Add("notificationIcon", "icon");
		dictionary.Add("largeNotificationIcon", "icon_large");
		Dictionary<string, object> fNMFAGBJBPG = dictionary;
		BJIENIICIEF = NDBAKIHLPFG.FFKACBMBNNP();
		BJIENIICIEF.NNGPBLGDBFG("2fe45e08527d6ad4a2d3b4bad9388ef3", "peakgames.helpshift.com", "peakgames_platform_20180117081200930-336799d13501c04", fNMFAGBJBPG);
		BJIENIICIEF.IJIHEHCKMDE();
		BJIENIICIEF.PDAGIHKGIOM(LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), MGEJHPBLPKE(), null);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Support, "Helpshift installed successfully.");
		BDJMFMFGCPF(KILNDOLGMEI);
	}

	public void BDJMFMFGCPF(string DJJGDFFDGFN)
	{
		if (!string.IsNullOrEmpty(DJJGDFFDGFN))
		{
			KILNDOLGMEI = DJJGDFFDGFN;
			if (BJIENIICIEF != null)
			{
				BJIENIICIEF.GIPAOONBAPG(DJJGDFFDGFN);
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Support, "Helpshift device token is registered.");
			}
		}
	}

	public void MJGCHNMPAKJ()
	{
		if (BJIENIICIEF != null)
		{
			LECPGNKOABP lECPGNKOABP = LECPGNKOABP.GABGKBAKHDP;
			BJIENIICIEF.PDAGIHKGIOM(LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), MGEJHPBLPKE(), null);
			BJIENIICIEF.MMIFDJIHPKN(MGEJHPBLPKE(), null);
			if (string.IsNullOrEmpty(CNLLFNKPIEG))
			{
				CNLLFNKPIEG = Guid.NewGuid().ToString();
			}
			string text = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("Country");
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("User", lECPGNKOABP.GDMECFECCOM + " - https://admin.toonblast.net/admin/users/" + lECPGNKOABP.GDMECFECCOM);
			dictionary.Add("Team", (lECPGNKOABP.OADDPGNIINO != 0) ? (lECPGNKOABP.EFHEIFMEJCN + " - https://admin.toonblast.net/admin/teams/" + lECPGNKOABP.OADDPGNIINO) : "N/A");
			dictionary.Add("Level", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1);
			dictionary.Add("Location", (!string.IsNullOrEmpty(text)) ? text : "Local");
			dictionary.Add("Coins", GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins));
			dictionary.Add("Paying User", LECPGNKOABP.GABGKBAKHDP.ILNAPPDKOOD);
			dictionary.Add("Log File", "https://logs.toonblast.net/logger/index.php?userId=" + lECPGNKOABP.GDMECFECCOM + "&filename=" + CNLLFNKPIEG);
			Dictionary<string, object> value = dictionary;
			Dictionary<string, object> dictionary2 = FBEDFJJGKHK();
			dictionary2.Remove("hs-custom-metadata");
			dictionary2.Add("hs-custom-metadata", value);
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Support, "Helpshift window showed with unread message count = {0}", IOBIDNGDPIN);
			if (IOBIDNGDPIN > 0)
			{
				BJIENIICIEF.JDOEPIMFLEH(dictionary2);
			}
			else
			{
				BJIENIICIEF.JCJJEFGELBM(dictionary2);
			}
		}
	}

	public void AHPBINLMNAM()
	{
		if (BJIENIICIEF == null)
		{
			return;
		}
		try
		{
			BJIENIICIEF.DPOMBKDCCBA();
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Support, "Exception on CheckIfConversationActive: {0}", ex.Message);
		}
	}

	public void OMIKDFPHGBA()
	{
		if (BJIENIICIEF != null)
		{
			BJIENIICIEF.IJCFKPNEKBP(true);
		}
	}

	public void JFMCKFEONEC()
	{
		IOBIDNGDPIN = 0;
		if (BJIENIICIEF != null)
		{
			if (MCJHHDACJBG.MCPELNPBPIF)
			{
				BJIENIICIEF.MPFKABENODH();
			}
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Support, "Helpshift resources cleared.");
		}
	}

	public void HNEGFLBPLJN()
	{
		JFMCKFEONEC();
		ENJDLHOLKJA();
		BJIENIICIEF = null;
	}

	public static void CNDHPGOOPKO()
	{
		CNLLFNKPIEG = null;
	}

	public void ENJDLHOLKJA()
	{
		MapManager instance = MapManager.Instance;
		if (!(instance == null))
		{
			instance.MapSettingsDisplay.ActivateNotificationIndicator(IOBIDNGDPIN > 0);
		}
	}

	private Dictionary<string, object> FBEDFJJGKHK()
	{
		if (GHDMEOGFJNC != null)
		{
			return GHDMEOGFJNC;
		}
		GHDMEOGFJNC = new Dictionary<string, object>
		{
			{ "gotoConversationAfterContactUs", "yes" },
			{ "showSearchOnNewConversation", "yes" },
			{ "showConversationResolutionQuestion", "no" },
			{ "enableTypingIndicator", "yes" },
			{ "requireEmail", "no" }
		};
		return GHDMEOGFJNC;
	}

	private static string MGEJHPBLPKE()
	{
		return LECPGNKOABP.GABGKBAKHDP.KJACEODCOHN ?? "Player";
	}
}
