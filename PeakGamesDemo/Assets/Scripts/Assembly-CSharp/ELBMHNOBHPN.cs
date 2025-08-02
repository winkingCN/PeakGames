using System;
using Assets.Scripts.Utils.Analytics;
using Facebook.Unity;

public static class ELBMHNOBHPN
{
	private const int MBPBFJONDFF = 5;

	private const int ABJKDHFCOOE = 3;

	private static NBMLNEENDHA JCCIHFEPIID;

	private static int GMNEBJPKOGF;

	private static bool POEHMEBOLEC;

	private static long PLJADAKJANN;

	public static bool LIGNHNEACJE { get; set; }

	public static bool GHDNFKHHCPP
	{
		get
		{
			return DateTime.UtcNow.TotalSeconds() - PLJADAKJANN > 5;
		}
	}

	public static bool EDAFBCMCHDH
	{
		get
		{
			return LIGNHNEACJE && OIAJPMNJGLK.HCBKKCHMJNA() != 0 && (DJGMHLLAGLE || !POEHMEBOLEC);
		}
	}

	public static bool DJGMHLLAGLE
	{
		get
		{
			return JCCIHFEPIID != null;
		}
	}

	public static bool IFBBNKJDOHE { get; private set; }

	public static void EGINHMIAEOB()
	{
		POEHMEBOLEC = false;
	}

	public static bool LEIIEJAJCHN()
	{
		POEHMEBOLEC = false;
		GMNEBJPKOGF++;
		if (GMNEBJPKOGF < 3)
		{
			return true;
		}
		GMNEBJPKOGF = 0;
		return false;
	}

	public static void KEIAPEBEGPL(bool IJECADJJAAN)
	{
		GMNEBJPKOGF = 0;
		if (!IJECADJJAAN)
		{
			OMOKOKFNBKI();
			return;
		}
		IFBBNKJDOHE = false;
		PLJADAKJANN = DateTime.UtcNow.TotalSeconds();
		NBMLNEENDHA nBMLNEENDHA = new NBMLNEENDHA();
		nBMLNEENDHA.KOPMPMIFHNF = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1;
		nBMLNEENDHA.AFOGPHMCPLN = (IDFPAFEJPPH.GABGKBAKHDP.HGNJBHGBLIN ? IDFPAFEJPPH.GABGKBAKHDP.PDGLECFDLJJ : 0);
		nBMLNEENDHA.CMKBDJLNCND = new JsonInventory();
		JCCIHFEPIID = nBMLNEENDHA;
		JCCIHFEPIID.CMKBDJLNCND.LDOCFEGBGNK();
	}

	public static void EIIELGHFBBG()
	{
		IFBBNKJDOHE = true;
	}

	public static void NANPEDFGNEP()
	{
		AFJPGLHKOID.IHKFEAOILLJ(JCCIHFEPIID, IFBBNKJDOHE);
		OMOKOKFNBKI();
	}

	private static void OMOKOKFNBKI()
	{
		JCCIHFEPIID = null;
		POEHMEBOLEC = true;
		PLJADAKJANN = 0L;
		IFBBNKJDOHE = false;
	}
}
