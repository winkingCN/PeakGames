using System;

public class FMFNPJJEPBF : JMPFLJGHAIM
{
	private int IALPHMOHPDI;

	private int[] PCIJPEKJHMB;

	private static readonly int JBHPMAOKAGJ = -1209970333;

	private static readonly int NJEHBIONCHO = -1640531527;

	private bool MAEALKEJALK;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return "RC5-32";
		}
	}

	public virtual bool ABNLKPDCGEF
	{
		get
		{
			return false;
		}
	}

	public FMFNPJJEPBF()
	{
		IALPHMOHPDI = 12;
	}

	public virtual int BDIGGHEPIIP()
	{
		return 8;
	}

	public virtual void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		if (typeof(KNADOCBIBLO).IsInstanceOfType(IJJHBEECMBP))
		{
			KNADOCBIBLO kNADOCBIBLO = (KNADOCBIBLO)IJJHBEECMBP;
			IALPHMOHPDI = kNADOCBIBLO.IPMOKLGGJIB;
			KBEFMBDOIJH(kNADOCBIBLO.MEGBFHFMBFI());
		}
		else
		{
			if (!typeof(JEMNCGMEABF).IsInstanceOfType(IJJHBEECMBP))
			{
				throw new ArgumentException("invalid parameter passed to RC532 init - " + LHFGHNFJIKM.JKHOEKAOLPM(IJJHBEECMBP));
			}
			JEMNCGMEABF jEMNCGMEABF = (JEMNCGMEABF)IJJHBEECMBP;
			KBEFMBDOIJH(jEMNCGMEABF.MEGBFHFMBFI());
		}
		this.MAEALKEJALK = MAEALKEJALK;
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
		int[] array = new int[(IKNCPEPOKGJ.Length + 3) / 4];
		for (int i = 0; i != IKNCPEPOKGJ.Length; i++)
		{
			array[i / 4] += (IKNCPEPOKGJ[i] & 0xFF) << 8 * (i % 4);
		}
		PCIJPEKJHMB = new int[2 * (IALPHMOHPDI + 1)];
		PCIJPEKJHMB[0] = JBHPMAOKAGJ;
		for (int j = 1; j < PCIJPEKJHMB.Length; j++)
		{
			PCIJPEKJHMB[j] = PCIJPEKJHMB[j - 1] + NJEHBIONCHO;
		}
		int num = ((array.Length <= PCIJPEKJHMB.Length) ? (3 * PCIJPEKJHMB.Length) : (3 * array.Length));
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		for (int k = 0; k < num; k++)
		{
			num2 = (PCIJPEKJHMB[num4] = MBBDJFKAACD(PCIJPEKJHMB[num4] + num2 + num3, 3));
			num3 = (array[num5] = MBBDJFKAACD(array[num5] + num2 + num3, num2 + num3));
			num4 = (num4 + 1) % PCIJPEKJHMB.Length;
			num5 = (num5 + 1) % array.Length;
		}
	}

	private int HDOLNBOHAJA(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		int num = GAIIDMPAKMM(MOPCLEEGDFB, ELICNEDIBGB) + PCIJPEKJHMB[0];
		int num2 = GAIIDMPAKMM(MOPCLEEGDFB, ELICNEDIBGB + 4) + PCIJPEKJHMB[1];
		for (int i = 1; i <= IALPHMOHPDI; i++)
		{
			num = MBBDJFKAACD(num ^ num2, num2) + PCIJPEKJHMB[2 * i];
			num2 = MBBDJFKAACD(num2 ^ num, num) + PCIJPEKJHMB[2 * i + 1];
		}
		BBBGPLNNMDM(num, NGAGMIIBGKA, EMAKNGBIFDC);
		BBBGPLNNMDM(num2, NGAGMIIBGKA, EMAKNGBIFDC + 4);
		return 8;
	}

	private int GFKALHGNIOJ(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		int num = GAIIDMPAKMM(MOPCLEEGDFB, ELICNEDIBGB);
		int num2 = GAIIDMPAKMM(MOPCLEEGDFB, ELICNEDIBGB + 4);
		for (int num3 = IALPHMOHPDI; num3 >= 1; num3--)
		{
			num2 = AIFAMJPHAAF(num2 - PCIJPEKJHMB[2 * num3 + 1], num) ^ num;
			num = AIFAMJPHAAF(num - PCIJPEKJHMB[2 * num3], num2) ^ num2;
		}
		BBBGPLNNMDM(num - PCIJPEKJHMB[0], NGAGMIIBGKA, EMAKNGBIFDC);
		BBBGPLNNMDM(num2 - PCIJPEKJHMB[1], NGAGMIIBGKA, EMAKNGBIFDC + 4);
		return 8;
	}

	private int MBBDJFKAACD(int AMFCENFNAJJ, int CNLILOEEBOJ)
	{
		return (AMFCENFNAJJ << (CNLILOEEBOJ & 0x1F)) | (int)((uint)AMFCENFNAJJ >> 32 - (CNLILOEEBOJ & 0x1F));
	}

	private int AIFAMJPHAAF(int AMFCENFNAJJ, int CNLILOEEBOJ)
	{
		return (int)((uint)AMFCENFNAJJ >> (CNLILOEEBOJ & 0x1F)) | (AMFCENFNAJJ << 32 - (CNLILOEEBOJ & 0x1F));
	}

	private int GAIIDMPAKMM(byte[] ENICBMKPJJK, int DCFOILFMIEK)
	{
		return (ENICBMKPJJK[DCFOILFMIEK] & 0xFF) | ((ENICBMKPJJK[DCFOILFMIEK + 1] & 0xFF) << 8) | ((ENICBMKPJJK[DCFOILFMIEK + 2] & 0xFF) << 16) | ((ENICBMKPJJK[DCFOILFMIEK + 3] & 0xFF) << 24);
	}

	private void BBBGPLNNMDM(int BKKMJAIKJAL, byte[] PPFHFMDDDLM, int BJEPNGMGPDI)
	{
		PPFHFMDDDLM[BJEPNGMGPDI] = (byte)BKKMJAIKJAL;
		PPFHFMDDDLM[BJEPNGMGPDI + 1] = (byte)(BKKMJAIKJAL >> 8);
		PPFHFMDDDLM[BJEPNGMGPDI + 2] = (byte)(BKKMJAIKJAL >> 16);
		PPFHFMDDDLM[BJEPNGMGPDI + 3] = (byte)(BKKMJAIKJAL >> 24);
	}
}
