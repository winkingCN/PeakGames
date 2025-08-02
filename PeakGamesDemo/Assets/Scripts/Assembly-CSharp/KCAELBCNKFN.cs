using System.IO;

public class KCAELBCNKFN
{
	private const string MNNOLIEHPJI = "peakgames.db";

	private static KCAELBCNKFN KNPOFJNFLJB;

	private readonly ODDNDHNOADI DKPPCEMFICG;

	private static string LOCNNPKHFAA;

	public static KCAELBCNKFN GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB != null)
			{
				return KNPOFJNFLJB;
			}
			if (NAAGDFCLOPE.GABGKBAKHDP == null || NAAGDFCLOPE.GABGKBAKHDP.KNLPPACLPOJ() == null)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.DatabaseManager, "First init CaravanNativeTools!");
				return null;
			}
			KNPOFJNFLJB = new KCAELBCNKFN();
			return KNPOFJNFLJB;
		}
	}

	public static string LCNEDGBJJCJ
	{
		get
		{
			if (LOCNNPKHFAA == null)
			{
				LOCNNPKHFAA = Path.Combine(NAAGDFCLOPE.GABGKBAKHDP.KNLPPACLPOJ(), "peakgames.db");
			}
			return LOCNNPKHFAA;
		}
	}

	private KCAELBCNKFN()
	{
		if (DKPPCEMFICG == null)
		{
			DKPPCEMFICG = new ODDNDHNOADI("peakgames.db", LCNEDGBJJCJ);
		}
	}

	public void DIOELAHNLKJ()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.DatabaseManager, "DB is ready.");
	}

	public void OMBKLCBCMGP(string HKCKEACCMMA)
	{
		DKPPCEMFICG.OMBKLCBCMGP(HKCKEACCMMA);
	}

	public MBBJJJGFIKD KLGGEBEDDJJ(string HKCKEACCMMA)
	{
		return DKPPCEMFICG.KLGGEBEDDJJ(HKCKEACCMMA);
	}

	public void NKKOEHGDNKD()
	{
		DKPPCEMFICG.NKKOEHGDNKD();
	}
}
