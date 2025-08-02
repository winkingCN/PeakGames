using UnityEngine;

public static class FNBPLBGNBNF
{
	public const int ICGIOMCECIP = 50;

	private const string JDDOOCNPJLA = "0";

	private const string HOPBPAIJNNH = "1";

	private const string BGFHKPHHPKH = "2";

	private const string MKNNHJAJLHE = "20190408_fun_levels_new";

	private const string BPJCBANKEHL = "503";

	private const string GLNKDDMGIHB = "504";

	public static void CGILBMHAIFJ(long BPKJLGJDFKG, bool EOHHFIPAAHM)
	{
		if (PlayerPrefs.HasKey("FunLevelAbEvt"))
		{
			PlayerPrefs.DeleteKey("FunLevelAbEvt");
			if (EOHHFIPAAHM)
			{
				KJOBGPIOCEJ("This was an old user, remove FunLevelAb.");
			}
			else
			{
				NANPEDFGNEP(BPKJLGJDFKG);
			}
		}
	}

	private static void KJOBGPIOCEJ(string OEFCOJLNCKP)
	{
		EKGLBJJKNBG.GABGKBAKHDP.FIMIAMGJADB("KeyAB_FunLevel", "0");
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AbTesting, OEFCOJLNCKP);
	}

	private static void NANPEDFGNEP(long BPKJLGJDFKG)
	{
		string text = EKGLBJJKNBG.GABGKBAKHDP.PGMJGDOBNGL("KeyAB_FunLevel");
		string pDDEAIPJEPL = ((!(text == "1")) ? "504" : "503");
		AFJPGLHKOID.CPIGOAGGLBM("ABTestEnter", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, BPKJLGJDFKG.ToString(), "20190408_fun_levels_new", pDDEAIPJEPL);
	}

	public static bool DMHOKIGLECN()
	{
		string text = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("KeyAB_FunLevel");
		return text != null && text == "2";
	}
}
