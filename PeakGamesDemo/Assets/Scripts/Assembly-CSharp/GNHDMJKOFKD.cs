using System;

public class GNHDMJKOFKD : JMPFLJGHAIM
{
	private static readonly int EIPGPJENMOB = 64;

	private static readonly int MFANAJCHPHF = EIPGPJENMOB / 8;

	private int IALPHMOHPDI;

	private long[] PCIJPEKJHMB;

	private static readonly long NGJFDEFFCNC = -5196783011329398165L;

	private static readonly long OOGJGDLMJBC = -7046029254386353131L;

	private bool MAEALKEJALK;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return "RC5-64";
		}
	}

	public virtual bool ABNLKPDCGEF
	{
		get
		{
			return false;
		}
	}

	public GNHDMJKOFKD()
	{
		IALPHMOHPDI = 12;
	}

	public virtual int BDIGGHEPIIP()
	{
		return 2 * MFANAJCHPHF;
	}

	public virtual void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		if (!typeof(KNADOCBIBLO).IsInstanceOfType(IJJHBEECMBP))
		{
			throw new ArgumentException("invalid parameter passed to RC564 init - " + LHFGHNFJIKM.JKHOEKAOLPM(IJJHBEECMBP));
		}
		KNADOCBIBLO kNADOCBIBLO = (KNADOCBIBLO)IJJHBEECMBP;
		this.MAEALKEJALK = MAEALKEJALK;
		IALPHMOHPDI = kNADOCBIBLO.IPMOKLGGJIB;
		KBEFMBDOIJH(kNADOCBIBLO.MEGBFHFMBFI());
	}

	public virtual int DPACJDFHLKB(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		return (!MAEALKEJALK) ? GFKALHGNIOJ(MOPCLEEGDFB, ELICNEDIBGB, BILGCJNPJGJ, EMAKNGBIFDC) : HDOLNBOHAJA(MOPCLEEGDFB, ELICNEDIBGB, BILGCJNPJGJ, EMAKNGBIFDC);
	}

	public virtual void OMOKOKFNBKI()
	{
	}

	private void KBEFMBDOIJH(byte[] IKNCPEPOKGJ)
	{
		long[] array = new long[(IKNCPEPOKGJ.Length + (MFANAJCHPHF - 1)) / MFANAJCHPHF];
		for (int i = 0; i != IKNCPEPOKGJ.Length; i++)
		{
			array[i / MFANAJCHPHF] += (long)(IKNCPEPOKGJ[i] & 0xFF) << 8 * (i % MFANAJCHPHF);
		}
		PCIJPEKJHMB = new long[2 * (IALPHMOHPDI + 1)];
		PCIJPEKJHMB[0] = NGJFDEFFCNC;
		for (int j = 1; j < PCIJPEKJHMB.Length; j++)
		{
			PCIJPEKJHMB[j] = PCIJPEKJHMB[j - 1] + OOGJGDLMJBC;
		}
		int num = ((array.Length <= PCIJPEKJHMB.Length) ? (3 * PCIJPEKJHMB.Length) : (3 * array.Length));
		long num2 = 0L;
		long num3 = 0L;
		int num4 = 0;
		int num5 = 0;
		for (int k = 0; k < num; k++)
		{
			num2 = (PCIJPEKJHMB[num4] = MBBDJFKAACD(PCIJPEKJHMB[num4] + num2 + num3, 3L));
			num3 = (array[num5] = MBBDJFKAACD(array[num5] + num2 + num3, num2 + num3));
			num4 = (num4 + 1) % PCIJPEKJHMB.Length;
			num5 = (num5 + 1) % array.Length;
		}
	}

	private int HDOLNBOHAJA(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		long num = GAIIDMPAKMM(MOPCLEEGDFB, ELICNEDIBGB) + PCIJPEKJHMB[0];
		long num2 = GAIIDMPAKMM(MOPCLEEGDFB, ELICNEDIBGB + MFANAJCHPHF) + PCIJPEKJHMB[1];
		for (int i = 1; i <= IALPHMOHPDI; i++)
		{
			num = MBBDJFKAACD(num ^ num2, num2) + PCIJPEKJHMB[2 * i];
			num2 = MBBDJFKAACD(num2 ^ num, num) + PCIJPEKJHMB[2 * i + 1];
		}
		BBBGPLNNMDM(num, NGAGMIIBGKA, EMAKNGBIFDC);
		BBBGPLNNMDM(num2, NGAGMIIBGKA, EMAKNGBIFDC + MFANAJCHPHF);
		return 2 * MFANAJCHPHF;
	}

	private int GFKALHGNIOJ(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		long num = GAIIDMPAKMM(MOPCLEEGDFB, ELICNEDIBGB);
		long num2 = GAIIDMPAKMM(MOPCLEEGDFB, ELICNEDIBGB + MFANAJCHPHF);
		for (int num3 = IALPHMOHPDI; num3 >= 1; num3--)
		{
			num2 = AIFAMJPHAAF(num2 - PCIJPEKJHMB[2 * num3 + 1], num) ^ num;
			num = AIFAMJPHAAF(num - PCIJPEKJHMB[2 * num3], num2) ^ num2;
		}
		BBBGPLNNMDM(num - PCIJPEKJHMB[0], NGAGMIIBGKA, EMAKNGBIFDC);
		BBBGPLNNMDM(num2 - PCIJPEKJHMB[1], NGAGMIIBGKA, EMAKNGBIFDC + MFANAJCHPHF);
		return 2 * MFANAJCHPHF;
	}

	private long MBBDJFKAACD(long AMFCENFNAJJ, long CNLILOEEBOJ)
	{
		return (AMFCENFNAJJ << (int)(CNLILOEEBOJ & (EIPGPJENMOB - 1))) | (long)((ulong)AMFCENFNAJJ >> (int)(EIPGPJENMOB - (CNLILOEEBOJ & (EIPGPJENMOB - 1))));
	}

	private long AIFAMJPHAAF(long AMFCENFNAJJ, long CNLILOEEBOJ)
	{
		return (long)((ulong)AMFCENFNAJJ >> (int)(CNLILOEEBOJ & (EIPGPJENMOB - 1))) | (AMFCENFNAJJ << (int)(EIPGPJENMOB - (CNLILOEEBOJ & (EIPGPJENMOB - 1))));
	}

	private long GAIIDMPAKMM(byte[] ENICBMKPJJK, int DCFOILFMIEK)
	{
		long num = 0L;
		for (int num2 = MFANAJCHPHF - 1; num2 >= 0; num2--)
		{
			num = (num << 8) + (ENICBMKPJJK[num2 + DCFOILFMIEK] & 0xFF);
		}
		return num;
	}

	private void BBBGPLNNMDM(long BKKMJAIKJAL, byte[] PPFHFMDDDLM, int BJEPNGMGPDI)
	{
		for (int i = 0; i < MFANAJCHPHF; i++)
		{
			PPFHFMDDDLM[i + BJEPNGMGPDI] = (byte)BKKMJAIKJAL;
			BKKMJAIKJAL = (long)((ulong)BKKMJAIKJAL >> 8);
		}
	}
}
