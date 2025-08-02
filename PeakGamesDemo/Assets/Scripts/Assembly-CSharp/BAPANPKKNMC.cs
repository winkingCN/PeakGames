using Org.BouncyCastle.Crypto;

public class BAPANPKKNMC : ELGNLPAGPNI
{
	private FBIJJFGLKMK GECCLOFELEC;

	public string FKBFIEIHPOB
	{
		get
		{
			return "X9.23";
		}
	}

	public void DIOELAHNLKJ(FBIJJFGLKMK GECCLOFELEC)
	{
		this.GECCLOFELEC = GECCLOFELEC;
	}

	public int MDNFIGPPOFC(byte[] MOPCLEEGDFB, int ELICNEDIBGB)
	{
		byte b = (byte)(MOPCLEEGDFB.Length - ELICNEDIBGB);
		while (ELICNEDIBGB < MOPCLEEGDFB.Length - 1)
		{
			if (GECCLOFELEC == null)
			{
				MOPCLEEGDFB[ELICNEDIBGB] = 0;
			}
			else
			{
				MOPCLEEGDFB[ELICNEDIBGB] = (byte)GECCLOFELEC.LIFIMLDFLGI();
			}
			ELICNEDIBGB++;
		}
		MOPCLEEGDFB[ELICNEDIBGB] = b;
		return b;
	}

	public int HIEMLFAHLFO(byte[] MOPCLEEGDFB)
	{
		int num = MOPCLEEGDFB[MOPCLEEGDFB.Length - 1] & 0xFF;
		if (num > MOPCLEEGDFB.Length)
		{
			throw new InvalidCipherTextException("pad block corrupted");
		}
		return num;
	}
}
