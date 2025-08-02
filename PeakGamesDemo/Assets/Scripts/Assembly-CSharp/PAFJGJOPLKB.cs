using UnityEngine;

public static class PAFJGJOPLKB
{
	private static int LHIKBHGJPBM;

	private static int AKCJHJJMFCE;

	private static bool HDCEEADEFOO;

	public static CKKKELDIOLD EFLCPKAFOBA(this IPPOGIEPKEN KHFBHDLBLJH)
	{
		if (!HDCEEADEFOO)
		{
			DIOELAHNLKJ();
		}
		switch (KHFBHDLBLJH)
		{
		case IPPOGIEPKEN.Borders:
			return new CKKKELDIOLD(LHIKBHGJPBM, 5);
		case IPPOGIEPKEN.Scores:
			return new CKKKELDIOLD(AKCJHJJMFCE, 50);
		case IPPOGIEPKEN.Bubbles:
			return new CKKKELDIOLD(LHIKBHGJPBM, 1500);
		case IPPOGIEPKEN.Collecting:
			return new CKKKELDIOLD(AKCJHJJMFCE, 40);
		case IPPOGIEPKEN.PlayDuckSorting:
			return new CKKKELDIOLD(LHIKBHGJPBM, 2650);
		case IPPOGIEPKEN.DiscoBallExplode:
			return new CKKKELDIOLD(LHIKBHGJPBM, 1650);
		case IPPOGIEPKEN.Items:
			return new CKKKELDIOLD(LHIKBHGJPBM, 0);
		default:
			return default(CKKKELDIOLD);
		}
	}

	public static CKKKELDIOLD LOPMMJANOFP(int CNLILOEEBOJ)
	{
		if (!HDCEEADEFOO)
		{
			DIOELAHNLKJ();
		}
		return new CKKKELDIOLD(LHIKBHGJPBM, 100 * (CNLILOEEBOJ + 3));
	}

	public static void DIOELAHNLKJ()
	{
		LHIKBHGJPBM = SortingLayer.NameToID("Mechanics");
		AKCJHJJMFCE = SortingLayer.NameToID("UI");
		HDCEEADEFOO = true;
	}
}
