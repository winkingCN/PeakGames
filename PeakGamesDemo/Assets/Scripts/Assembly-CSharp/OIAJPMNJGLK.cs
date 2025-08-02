using System;

public static class OIAJPMNJGLK
{
	public const string AKKPCJGDKCO = "key_chc";

	public const string IDDABPKFBNH = "ServerPingTime";

	private static DateTime HACPBKEHLGF;

	private static DateTime DBDLPCKGFLM;

	private static bool LAPDLELGNAH;

	private static LLCJMMBBLEH KJGMOGKBFJP;

	private static int JIGBDHFPGPL;

	public static KDIMALLNOFG JHJCHDODNMK
	{
		get
		{
			if (!LAPDLELGNAH)
			{
				return new KDIMALLNOFG(DateTime.UtcNow);
			}
			double totalSeconds = (DateTime.UtcNow - HACPBKEHLGF).TotalSeconds;
			DateTime gEFEKHEMPPD = DBDLPCKGFLM;
			if (totalSeconds > 0.0)
			{
				gEFEKHEMPPD = DBDLPCKGFLM.AddSeconds(totalSeconds);
			}
			return new KDIMALLNOFG(DateTime.UtcNow, gEFEKHEMPPD);
		}
	}

	public static bool CHHIMPENGBG()
	{
		return LAPDLELGNAH;
	}

	private static void GHBJBDACBAH(DateTime GMBFFEPCOKG)
	{
		long num = GMBFFEPCOKG.GMEBBNOHJFJ();
		HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("ServerPingTime", num.ToString());
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanDateTime, "Time from server is updated as:{0}", GMBFFEPCOKG);
		HACPBKEHLGF = DateTime.UtcNow;
		DBDLPCKGFLM = GMBFFEPCOKG;
		LAPDLELGNAH = true;
	}

	public static long HCBKKCHMJNA()
	{
		string text = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("ServerPingTime");
		return (text != null) ? long.Parse(text) : 0;
	}

	public static int HOGCELOOGEP()
	{
		JIGBDHFPGPL = (int)((JHJCHDODNMK.DBIMKDHPELE() - MCJHHDACJBG.FEMCHNPOIEB).TotalHours / 168.0);
		return JIGBDHFPGPL;
	}

	public static int GMNMOPJKJIE(DateTime ELNCCDELMMH)
	{
		TimeSpan fNJHPJDHLPE = ELNCCDELMMH - DateTime.Now;
		KDIMALLNOFG kDIMALLNOFG = JHJCHDODNMK;
		kDIMALLNOFG.JMCCKLJCKKH(fNJHPJDHLPE);
		JIGBDHFPGPL = (int)((kDIMALLNOFG.DBIMKDHPELE() - MCJHHDACJBG.FEMCHNPOIEB).TotalHours / 168.0);
		return JIGBDHFPGPL;
	}

	public static void OIOEHLJFLJG()
	{
		if (!EHABCKOMLLG())
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanDateTime, "Resetting previous time since online date is not available.");
			HJBLKNBHMFJ.GABGKBAKHDP.KFCIOFNMKDA("key_chc");
		}
	}

	public static void NMHNDKBIEJA(string IFKEEEFBFPI = null)
	{
		string text = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("key_chc");
		if (text == null && IFKEEEFBFPI != null)
		{
			try
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanDateTime, "No previous time in client, use from server.");
				KDIMALLNOFG kDIMALLNOFG = new KDIMALLNOFG(IFKEEEFBFPI);
				if (kDIMALLNOFG.KOOPOIBAFJO() && kDIMALLNOFG.KOOPOIBAFJO())
				{
					HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("key_chc", IFKEEEFBFPI);
					text = IFKEEEFBFPI;
				}
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.CaravanDateTime, "Invalid life time from server {}: {}.", IFKEEEFBFPI, ex.Message);
			}
		}
		if (text == null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanDateTime, "Saving previous time for the first time.");
			EHABCKOMLLG();
			return;
		}
		KDIMALLNOFG kDIMALLNOFG2 = new KDIMALLNOFG(text);
		if (KDIMALLNOFG.NJADEEMOMGL(kDIMALLNOFG2, JHJCHDODNMK))
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanDateTime, "Previous stored time was {0}", kDIMALLNOFG2);
			EHABCKOMLLG();
		}
		else
		{
			PJPPADHKGHN.GABGKBAKHDP.PIJMPOOEADM();
		}
	}

	private static bool EHABCKOMLLG()
	{
		KDIMALLNOFG kDIMALLNOFG = JHJCHDODNMK;
		if (!kDIMALLNOFG.DFMLFFJGHOM())
		{
			return false;
		}
		HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("key_chc", kDIMALLNOFG.ONBGDIHNPHI());
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanDateTime, "Previous time is set:{0}", kDIMALLNOFG.ToString());
		return true;
	}

	public static void DAGBPPPFPPK()
	{
		HACPBKEHLGF = DateTime.MinValue;
		DBDLPCKGFLM = DateTime.MinValue;
		LAPDLELGNAH = false;
	}

	public static void FCNGEIHAGIB(long GMBFFEPCOKG, string IFKEEEFBFPI = null)
	{
		GHBJBDACBAH(FIBJIOBINHL.IIDMAMGMAAA(GMBFFEPCOKG));
		NMHNDKBIEJA(IFKEEEFBFPI);
		PJPPADHKGHN.GABGKBAKHDP.CJDADPHKAFL();
	}
}
