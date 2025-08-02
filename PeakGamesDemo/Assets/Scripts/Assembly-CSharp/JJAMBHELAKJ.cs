using Org.BouncyCastle.Crypto;

public class JJAMBHELAKJ : ELGNLPAGPNI
{
	private FBIJJFGLKMK GECCLOFELEC;

	public string FKBFIEIHPOB
	{
		get
		{
			return "ISO10126-2";
		}
	}

	public void DIOELAHNLKJ(FBIJJFGLKMK GECCLOFELEC)
	{
		this.GECCLOFELEC = ((GECCLOFELEC == null) ? new FBIJJFGLKMK() : GECCLOFELEC);
	}

	public int MDNFIGPPOFC(byte[] MOPCLEEGDFB, int ELICNEDIBGB)
	{
		byte b = (byte)(MOPCLEEGDFB.Length - ELICNEDIBGB);
		while (ELICNEDIBGB < MOPCLEEGDFB.Length - 1)
		{
			MOPCLEEGDFB[ELICNEDIBGB] = (byte)GECCLOFELEC.LIFIMLDFLGI();
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
