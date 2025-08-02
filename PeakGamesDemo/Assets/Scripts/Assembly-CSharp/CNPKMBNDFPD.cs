using System;
using UnityEngine;

public class CNPKMBNDFPD : FMFLAPIFIED
{
	private AndroidJavaObject BKKEGNEMMLE;

	private static AndroidJavaClass DJFLDAOJGEC;

	private string GMBNJCKNOBD;

	private string FCEEGNFABAF;

	private string NKEEJAHBMII;

	private string KCIJNHPGJKF;

	private string KAHGCNJDNII;

	private string DCNDJMNBMDJ;

	private long JGHCLMIGPMI;

	private long FHFFNGKAOFC;

	private bool BOHCPCPJKHP;

	private bool FLAAGLFGJDJ;

	private int DCHJJKFOEGC;

	private CNPKMBNDFPD()
	{
		if (DJFLDAOJGEC == null || DJFLDAOJGEC.GetRawObject().ToInt32() == 0)
		{
			DJFLDAOJGEC = new AndroidJavaClass("com.helpshift.campaigns.models.InboxMessage");
		}
	}

	public string AONMFPNNLIM()
	{
		return GMBNJCKNOBD;
	}

	public string AENAALIAGII()
	{
		string result = null;
		try
		{
			result = BKKEGNEMMLE.Get<string>("coverImageFilePath");
		}
		catch (Exception ex)
		{
			Debug.Log("Error getting inbox message cover image :" + ex.Message);
		}
		try
		{
			BKKEGNEMMLE.Call<AndroidJavaObject>("getCoverImage", new object[0]);
		}
		catch (Exception ex2)
		{
			Debug.Log("Expected error. Java returning null for message cover image bitmap:" + ex2.Message);
		}
		return result;
	}

	public string OILBLNGAOLI()
	{
		try
		{
			return BKKEGNEMMLE.Get<string>("iconImageFilePath");
		}
		catch (Exception ex)
		{
			Debug.Log("Error getting inbox message icon image :" + ex.Message);
		}
		return null;
	}

	public string DNKACDHBHKN()
	{
		return FCEEGNFABAF;
	}

	public string FLDOKPAGCKL()
	{
		return NKEEJAHBMII;
	}

	public string PLPEAPFFJOH()
	{
		return KCIJNHPGJKF;
	}

	public string LPIEFCFABDD()
	{
		return KAHGCNJDNII;
	}

	public string ODPBBHCGPLH()
	{
		return DCNDJMNBMDJ;
	}

	public double ACNCDOAKHLF()
	{
		return Convert.ToDouble(JGHCLMIGPMI);
	}

	public double OJAEPEOMPPI()
	{
		return Convert.ToDouble(FHFFNGKAOFC);
	}

	public bool NOELCGDNPEI()
	{
		return FHFFNGKAOFC != DJFLDAOJGEC.GetStatic<long>("NO_EXPIRY_TIME_STAMP");
	}

	public bool IBCMHFCIFPO()
	{
		return BOHCPCPJKHP;
	}

	public bool DDFKLKLDMHJ()
	{
		return FLAAGLFGJDJ;
	}

	public int PENIEIEFMDN()
	{
		return DCHJJKFOEGC;
	}

	public string BAHIGHGMMBB(int EHJNMODJEAN)
	{
		return BKKEGNEMMLE.Call<string>("getActionTitle", new object[1] { EHJNMODJEAN });
	}

	public string JKPFAGHOBNI(int EHJNMODJEAN)
	{
		return BKKEGNEMMLE.Call<string>("getActionTitleColor", new object[1] { EHJNMODJEAN });
	}

	public bool IPLGJAJEANC(int EHJNMODJEAN)
	{
		return BKKEGNEMMLE.Call<bool>("isActionGoalCompletion", new object[1] { EHJNMODJEAN });
	}

	public void NOGLIIIOGGE(int EHJNMODJEAN, object EIKIFAIBFGJ)
	{
		if (EIKIFAIBFGJ == null)
		{
			AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
			EIKIFAIBFGJ = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
		}
		BKKEGNEMMLE.Call("executeAction", EHJNMODJEAN, EIKIFAIBFGJ);
	}

	public string EKNNCGHEDNA(int EHJNMODJEAN)
	{
		return BKKEGNEMMLE.Call<string>("getActionData", new object[1] { EHJNMODJEAN });
	}

	public HKELKEKNLIC LCJFOMPGBNI(int EHJNMODJEAN)
	{
		AndroidJavaObject androidJavaObject = BKKEGNEMMLE.Call<AndroidJavaObject>("getActionType", new object[1] { EHJNMODJEAN });
		int num = androidJavaObject.Call<int>("ordinal", new object[0]);
		HKELKEKNLIC result = HKELKEKNLIC.UNKNOWN;
		switch (num)
		{
		case 0:
			result = HKELKEKNLIC.UNKNOWN;
			break;
		case 1:
			result = HKELKEKNLIC.OPEN_DEEP_LINK;
			break;
		case 2:
			result = HKELKEKNLIC.SHOW_FAQS;
			break;
		case 3:
			result = HKELKEKNLIC.SHOW_FAQ_SECTION;
			break;
		case 4:
			result = HKELKEKNLIC.SHOW_CONVERSATION;
			break;
		case 5:
			result = HKELKEKNLIC.SHOW_SINGLE_FAQ;
			break;
		case 6:
			result = HKELKEKNLIC.SHOW_ALERT_TO_RATE_APP;
			break;
		}
		return result;
	}

	public static CNPKMBNDFPD IAPNPECKPPL(AndroidJavaObject OEFCOJLNCKP)
	{
		if (OEFCOJLNCKP == null || OEFCOJLNCKP.GetRawObject().ToInt32() == 0)
		{
			return null;
		}
		CNPKMBNDFPD cNPKMBNDFPD = new CNPKMBNDFPD();
		cNPKMBNDFPD.BKKEGNEMMLE = OEFCOJLNCKP;
		cNPKMBNDFPD.GMBNJCKNOBD = OEFCOJLNCKP.Call<string>("getIdentifier", new object[0]);
		cNPKMBNDFPD.FCEEGNFABAF = OEFCOJLNCKP.Call<string>("getTitle", new object[0]);
		cNPKMBNDFPD.NKEEJAHBMII = OEFCOJLNCKP.Call<string>("getTitleColor", new object[0]);
		cNPKMBNDFPD.KCIJNHPGJKF = OEFCOJLNCKP.Call<string>("getBody", new object[0]);
		cNPKMBNDFPD.KAHGCNJDNII = OEFCOJLNCKP.Call<string>("getBodyColor", new object[0]);
		cNPKMBNDFPD.DCNDJMNBMDJ = OEFCOJLNCKP.Call<string>("getBackgroundColor", new object[0]);
		cNPKMBNDFPD.JGHCLMIGPMI = OEFCOJLNCKP.Call<long>("getCreatedAt", new object[0]);
		cNPKMBNDFPD.FHFFNGKAOFC = OEFCOJLNCKP.Call<long>("getExpiryTimeStamp", new object[0]);
		cNPKMBNDFPD.FLAAGLFGJDJ = OEFCOJLNCKP.Call<bool>("getSeenStatus", new object[0]);
		cNPKMBNDFPD.BOHCPCPJKHP = OEFCOJLNCKP.Call<bool>("getReadStatus", new object[0]);
		cNPKMBNDFPD.DCHJJKFOEGC = OEFCOJLNCKP.Call<int>("getCountOfActions", new object[0]);
		return cNPKMBNDFPD;
	}

	public override string ToString()
	{
		return "Title : " + FCEEGNFABAF + "  Identifier : " + GMBNJCKNOBD + "\n Body : " + KCIJNHPGJKF + "  CreatedAt : " + JGHCLMIGPMI + "\n Seen state :" + FLAAGLFGJDJ + "  Read state : " + BOHCPCPJKHP + "\n Count of Actions :" + DCHJJKFOEGC + "  Expiry : " + FHFFNGKAOFC + "\n BodyColor : " + KAHGCNJDNII + " BackgroundColor : " + DCNDJMNBMDJ + "\n Action count : " + DCHJJKFOEGC;
	}
}
