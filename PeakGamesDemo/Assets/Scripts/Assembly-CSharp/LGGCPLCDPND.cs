public class LGGCPLCDPND : ELGNLPAGPNI
{
	public string FKBFIEIHPOB
	{
		get
		{
			return "TBC";
		}
	}

	public virtual void DIOELAHNLKJ(FBIJJFGLKMK GECCLOFELEC)
	{
	}

	public virtual int MDNFIGPPOFC(byte[] MOPCLEEGDFB, int ELICNEDIBGB)
	{
		int result = MOPCLEEGDFB.Length - ELICNEDIBGB;
		byte b = ((ELICNEDIBGB <= 0) ? ((byte)(((MOPCLEEGDFB[MOPCLEEGDFB.Length - 1] & 1) == 0) ? 255u : 0u)) : ((byte)(((MOPCLEEGDFB[ELICNEDIBGB - 1] & 1) == 0) ? 255u : 0u)));
		while (ELICNEDIBGB < MOPCLEEGDFB.Length)
		{
			MOPCLEEGDFB[ELICNEDIBGB] = b;
			ELICNEDIBGB++;
		}
		return result;
	}

	public virtual int HIEMLFAHLFO(byte[] MOPCLEEGDFB)
	{
		byte b = MOPCLEEGDFB[MOPCLEEGDFB.Length - 1];
		int num = MOPCLEEGDFB.Length - 1;
		while (num > 0 && MOPCLEEGDFB[num - 1] == b)
		{
			num--;
		}
		return MOPCLEEGDFB.Length - num;
	}
}
