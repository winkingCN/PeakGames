using System;
using BillingUnityLibraries;
using com.adjust.sdk;

public class DJFPMCMLPJJ
{
	public const string HOKIJKPIENB = "kt3zew";

	public const string POKFJPIELOI = "bu6194";

	public const string NHGMJMHAJPH = "666bzt";

	public const string AJKOKECAJMH = "ts7a89";

	public const string IDDMPAGLNGG = "x2hp2h";

	public const string BAOHAABJOII = "qphk2t";

	public const string NOHGDNEEJNB = "wrb6ko";

	public const string ALOCBODHJHL = "8mcq5j";

	public const string NIKGODCBHPK = "uxtz6v";

	public const string ONFFEFNKKOA = "e3c4lr";

	public const string KHPJMPKOGLM = "j565f4";

	public const string OGBHOCJPFLN = "wq900a";

	public const string FICBLDLHNBH = "bwsxrb";

	public const string DADKAELJCJD = "x5kq6f";

	public const string EPFEAABJBFI = "h2rvik";

	public const string ELKMFOOGDJD = "j4vuq7";

	public const string ILFLGGFJJNF = "5wkccv";

	private static bool KPABFJLGHLN;

	private static bool IJJFBEJCBAN;

	public static void CIBKGNFLBDE(int KIGOGMKCDKN)
	{
		if (KIGOGMKCDKN != 1 && KIGOGMKCDKN != 5 && KIGOGMKCDKN != 15 && KIGOGMKCDKN != 30 && KIGOGMKCDKN != 45)
		{
			return;
		}
		string iKNCPEPOKGJ = "LevelCompleted_" + KIGOGMKCDKN;
		if (MKINMKEMBPL.GABGKBAKHDP.HEANMKDLPGF(iKNCPEPOKGJ))
		{
			return;
		}
		string bCBPCIDMPKH = string.Empty;
		switch (KIGOGMKCDKN)
		{
		case 1:
			bCBPCIDMPKH = "x2hp2h";
			break;
		case 5:
			bCBPCIDMPKH = "qphk2t";
			break;
		case 15:
			bCBPCIDMPKH = "wrb6ko";
			break;
		case 30:
			bCBPCIDMPKH = "8mcq5j";
			break;
		case 45:
			bCBPCIDMPKH = "uxtz6v";
			break;
		}
		try
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AdjustHelper, "SendLevelEndEvent LevelId:{0}", KIGOGMKCDKN);
			Adjust.trackEvent(new EHLDLBPDDCA(bCBPCIDMPKH));
			MKINMKEMBPL.GABGKBAKHDP.KMPGGMKICLB(iKNCPEPOKGJ);
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.AdjustHelper, "SendLevelEndEvent Error:{0} Stack:{1}", ex.Message, ex.StackTrace);
		}
	}

	public static void PEKCICFOPDG()
	{
		Adjust.trackEvent(new EHLDLBPDDCA("wq900a"));
	}

	public static void LLKGLKPILOK()
	{
		Adjust.trackEvent(new EHLDLBPDDCA("bwsxrb"));
	}

	public static void JMHBLDGOOCD()
	{
		Adjust.trackEvent(new EHLDLBPDDCA("x5kq6f"));
	}

	public static void FFKDBKDOJEJ()
	{
		Adjust.trackEvent(new EHLDLBPDDCA("h2rvik"));
	}

	public static void HFKPGFGHEAK()
	{
		Adjust.trackEvent(new EHLDLBPDDCA("j4vuq7"));
	}

	public static void CEKGGBMNANA()
	{
		Adjust.trackEvent(new EHLDLBPDDCA("5wkccv"));
	}

	public static void CODIOHDGNGC(BillingProduct MHCFFEOFFOB)
	{
		try
		{
			if (MHCFFEOFFOB != null)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AdjustHelper, "SendPurchaseEvent Revenue:{0} Currency:{1}", MHCFFEOFFOB.PriceAsFloat(), MHCFFEOFFOB.Currency);
				EHLDLBPDDCA eHLDLBPDDCA = new EHLDLBPDDCA("j565f4");
				eHLDLBPDDCA.KKIFGBLLNEK(MHCFFEOFFOB.PriceAsFloat(), MHCFFEOFFOB.Currency);
				Adjust.trackEvent(eHLDLBPDDCA);
			}
			Adjust.trackEvent(new EHLDLBPDDCA("e3c4lr"));
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.AdjustHelper, "SendPurchaseEvent Error:{0} Stack:{1}", ex.Message, ex.StackTrace);
		}
	}

	public static void CDDEPINEGBP(BillingProduct MHCFFEOFFOB)
	{
		try
		{
			if (MHCFFEOFFOB != null)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AdjustHelper, "SendFirstPurchaseEvent Revenue:{0} Currency:{1}", MHCFFEOFFOB.PriceAsFloat(), MHCFFEOFFOB.Currency);
				EHLDLBPDDCA eHLDLBPDDCA = new EHLDLBPDDCA("bu6194");
				eHLDLBPDDCA.KKIFGBLLNEK(MHCFFEOFFOB.PriceAsFloat(), MHCFFEOFFOB.Currency);
				Adjust.trackEvent(eHLDLBPDDCA);
			}
			Adjust.trackEvent(new EHLDLBPDDCA("kt3zew"));
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.AdjustHelper, "SendFirstPurchaseEvent Error:{0} Stack:{1}", ex.Message, ex.StackTrace);
		}
	}

	public static void JMJBMFODBLO(string LGGHMBDBFCA)
	{
		try
		{
			if (!KPABFJLGHLN)
			{
				KPABFJLGHLN = true;
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AdjustHelper, "SendLogin SenderId:{0} IsEnabled:{1}", LGGHMBDBFCA, Adjust.isEnabled());
				EHLDLBPDDCA eHLDLBPDDCA = new EHLDLBPDDCA("ts7a89");
				eHLDLBPDDCA.DECKANCHOJE("s", LGGHMBDBFCA);
				Adjust.trackEvent(eHLDLBPDDCA);
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.AdjustHelper, "SendInitLogin Error:{0} Stack:{1}", ex.Message, ex.StackTrace);
		}
	}

	public static void MKHCFGLBCCD(string LGGHMBDBFCA, string BPKJLGJDFKG)
	{
		try
		{
			if (!IJJFBEJCBAN)
			{
				IJJFBEJCBAN = true;
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AdjustHelper, "SendInitLogin SenderId:{0} UserId:{1} IsEnabled:{2}", LGGHMBDBFCA, BPKJLGJDFKG, Adjust.isEnabled());
				EHLDLBPDDCA eHLDLBPDDCA = new EHLDLBPDDCA("666bzt");
				eHLDLBPDDCA.DECKANCHOJE("s", LGGHMBDBFCA);
				eHLDLBPDDCA.DECKANCHOJE("user_id", BPKJLGJDFKG);
				Adjust.trackEvent(eHLDLBPDDCA);
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AdjustHelper, "Send Init Login> SenderId:{0} UserId:{1} ", LGGHMBDBFCA, BPKJLGJDFKG);
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.AdjustHelper, "SendLogin Error:{0} Stack:{1}", ex.Message, ex.StackTrace);
		}
	}
}
