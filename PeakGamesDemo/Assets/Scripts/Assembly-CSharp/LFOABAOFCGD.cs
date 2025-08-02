using Org.BouncyCastle.Crypto;

public class LFOABAOFCGD : ELGNLPAGPNI
{
	public string FKBFIEIHPOB
	{
		get
		{
			return "PKCS7";
		}
	}

	public void DIOELAHNLKJ(FBIJJFGLKMK GECCLOFELEC)
	{
	}

	public int MDNFIGPPOFC(byte[] MOPCLEEGDFB, int ELICNEDIBGB)
	{
		byte b = (byte)(MOPCLEEGDFB.Length - ELICNEDIBGB);
		while (ELICNEDIBGB < MOPCLEEGDFB.Length)
		{
			MOPCLEEGDFB[ELICNEDIBGB] = b;
			ELICNEDIBGB++;
		}
		return b;
	}

	public int HIEMLFAHLFO(byte[] MOPCLEEGDFB)
	{
		byte b = MOPCLEEGDFB[MOPCLEEGDFB.Length - 1];
		int num = b;
		if (num < 1 || num > MOPCLEEGDFB.Length)
		{
			throw new InvalidCipherTextException("pad block corrupted");
		}
		for (int i = 2; i <= num; i++)
		{
			if (MOPCLEEGDFB[MOPCLEEGDFB.Length - i] != b)
			{
				throw new InvalidCipherTextException("pad block corrupted");
			}
		}
		return num;
	}
}
