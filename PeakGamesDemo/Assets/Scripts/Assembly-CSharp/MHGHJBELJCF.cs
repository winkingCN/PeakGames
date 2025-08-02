using System.Collections.Generic;

public static class MHGHJBELJCF
{
	public static int LLJKKEKFPFG(this int[] DAJJOELBDGK, int NMPJCKJIOKL)
	{
		if (DAJJOELBDGK.Length == 1)
		{
			return 0;
		}
		int num = BFGGHJGIHLJ.FDFDDKBDPEG(0, DAJJOELBDGK[DAJJOELBDGK.Length - 1], NMPJCKJIOKL);
		for (int i = 0; i < DAJJOELBDGK.Length; i++)
		{
			if (num < DAJJOELBDGK[i])
			{
				return i;
			}
		}
		return -1;
	}

	public static void MJIJGDHOEBN(this int[] DAJJOELBDGK)
	{
		for (int i = 1; i < DAJJOELBDGK.Length; i++)
		{
			DAJJOELBDGK[i] += DAJJOELBDGK[i - 1];
		}
	}

	public static int LLJKKEKFPFG(this IList<int> DAJJOELBDGK)
	{
		if (DAJJOELBDGK.Count == 1)
		{
			return 0;
		}
		int num = BFGGHJGIHLJ.FDFDDKBDPEG(0, DAJJOELBDGK[DAJJOELBDGK.Count - 1], 15);
		for (int i = 0; i < DAJJOELBDGK.Count; i++)
		{
			if (num < DAJJOELBDGK[i])
			{
				return i;
			}
		}
		return -1;
	}
}
