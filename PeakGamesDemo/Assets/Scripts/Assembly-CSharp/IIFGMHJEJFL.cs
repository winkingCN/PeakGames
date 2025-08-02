public class IIFGMHJEJFL : ELGNLPAGPNI
{
	public string FKBFIEIHPOB
	{
		get
		{
			return "ZeroBytePadding";
		}
	}

	public void DIOELAHNLKJ(FBIJJFGLKMK GECCLOFELEC)
	{
	}

	public int MDNFIGPPOFC(byte[] MOPCLEEGDFB, int ELICNEDIBGB)
	{
		int result = MOPCLEEGDFB.Length - ELICNEDIBGB;
		while (ELICNEDIBGB < MOPCLEEGDFB.Length)
		{
			MOPCLEEGDFB[ELICNEDIBGB] = 0;
			ELICNEDIBGB++;
		}
		return result;
	}

	public int HIEMLFAHLFO(byte[] MOPCLEEGDFB)
	{
		int num = MOPCLEEGDFB.Length;
		while (num > 0 && MOPCLEEGDFB[num - 1] == 0)
		{
			num--;
		}
		return MOPCLEEGDFB.Length - num;
	}
}
