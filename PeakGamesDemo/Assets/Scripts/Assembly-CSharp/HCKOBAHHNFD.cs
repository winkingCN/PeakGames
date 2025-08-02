using Org.BouncyCastle.Crypto;

public class HCKOBAHHNFD : ELGNLPAGPNI
{
	public string FKBFIEIHPOB
	{
		get
		{
			return "ISO7816-4";
		}
	}

	public void DIOELAHNLKJ(FBIJJFGLKMK GECCLOFELEC)
	{
	}

	public int MDNFIGPPOFC(byte[] MOPCLEEGDFB, int ELICNEDIBGB)
	{
		int result = MOPCLEEGDFB.Length - ELICNEDIBGB;
		MOPCLEEGDFB[ELICNEDIBGB] = 128;
		for (ELICNEDIBGB++; ELICNEDIBGB < MOPCLEEGDFB.Length; ELICNEDIBGB++)
		{
			MOPCLEEGDFB[ELICNEDIBGB] = 0;
		}
		return result;
	}

	public int HIEMLFAHLFO(byte[] MOPCLEEGDFB)
	{
		int num = MOPCLEEGDFB.Length - 1;
		while (num > 0 && MOPCLEEGDFB[num] == 0)
		{
			num--;
		}
		if (MOPCLEEGDFB[num] != 128)
		{
			throw new InvalidCipherTextException("pad block corrupted");
		}
		return MOPCLEEGDFB.Length - num;
	}
}
