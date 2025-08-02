using System;

public class PLIOBFEGIAA : JMPFLJGHAIM
{
	private static readonly int EIPGPJENMOB = 32;

	private static readonly int MFANAJCHPHF = EIPGPJENMOB / 8;

	private static readonly int IALPHMOHPDI = 20;

	private int[] PCIJPEKJHMB;

	private static readonly int JBHPMAOKAGJ = -1209970333;

	private static readonly int NJEHBIONCHO = -1640531527;

	private static readonly int CLMMJCICIBE = 5;

	private bool MAEALKEJALK;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return "RC6";
		}
	}

	public virtual bool ABNLKPDCGEF
	{
		get
		{
			return false;
		}
	}

	public virtual int BDIGGHEPIIP()
	{
		return 4 * MFANAJCHPHF;
	}

	public virtual void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		if (!(IJJHBEECMBP is JEMNCGMEABF))
		{
			throw new ArgumentException("invalid parameter passed to RC6 init - " + LHFGHNFJIKM.JKHOEKAOLPM(IJJHBEECMBP));
		}
		this.MAEALKEJALK = MAEALKEJALK;
		JEMNCGMEABF jEMNCGMEABF = (JEMNCGMEABF)IJJHBEECMBP;
		KBEFMBDOIJH(jEMNCGMEABF.MEGBFHFMBFI());
	}

	public virtual int DPACJDFHLKB(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		int nBEDPKHALCN = BDIGGHEPIIP();
		if (PCIJPEKJHMB == null)
		{
			throw new InvalidOperationException("RC6 engine not initialised");
		}
		AJLDFGNHDCA.OONDALLFPOP(MOPCLEEGDFB, ELICNEDIBGB, nBEDPKHALCN, "input buffer too short");
		AJLDFGNHDCA.KLPNFGNKNKB(BILGCJNPJGJ, EMAKNGBIFDC, nBEDPKHALCN, "output buffer too short");
		return (!MAEALKEJALK) ? GFKALHGNIOJ(MOPCLEEGDFB, ELICNEDIBGB, BILGCJNPJGJ, EMAKNGBIFDC) : HDOLNBOHAJA(MOPCLEEGDFB, ELICNEDIBGB, BILGCJNPJGJ, EMAKNGBIFDC);
	}

	public virtual void OMOKOKFNBKI()
	{
	}

	private void KBEFMBDOIJH(byte[] IKNCPEPOKGJ)
	{
		if ((IKNCPEPOKGJ.Length + (MFANAJCHPHF - 1)) / MFANAJCHPHF == 0)
		{
			int num = 1;
		}
		int[] array = new int[(IKNCPEPOKGJ.Length + MFANAJCHPHF - 1) / MFANAJCHPHF];
		for (int num2 = IKNCPEPOKGJ.Length - 1; num2 >= 0; num2--)
		{
			array[num2 / MFANAJCHPHF] = (array[num2 / MFANAJCHPHF] << 8) + (IKNCPEPOKGJ[num2] & 0xFF);
		}
		PCIJPEKJHMB = new int[2 + 2 * IALPHMOHPDI + 2];
		PCIJPEKJHMB[0] = JBHPMAOKAGJ;
		for (int i = 1; i < PCIJPEKJHMB.Length; i++)
		{
			PCIJPEKJHMB[i] = PCIJPEKJHMB[i - 1] + NJEHBIONCHO;
		}
		int num3 = ((array.Length <= PCIJPEKJHMB.Length) ? (3 * PCIJPEKJHMB.Length) : (3 * array.Length));
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		for (int j = 0; j < num3; j++)
		{
			num4 = (PCIJPEKJHMB[num6] = MBBDJFKAACD(PCIJPEKJHMB[num6] + num4 + num5, 3));
			num5 = (array[num7] = MBBDJFKAACD(array[num7] + num4 + num5, num4 + num5));
			num6 = (num6 + 1) % PCIJPEKJHMB.Length;
			num7 = (num7 + 1) % array.Length;
		}
	}

	private int HDOLNBOHAJA(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		int num = GAIIDMPAKMM(MOPCLEEGDFB, ELICNEDIBGB);
		int num2 = GAIIDMPAKMM(MOPCLEEGDFB, ELICNEDIBGB + MFANAJCHPHF);
		int num3 = GAIIDMPAKMM(MOPCLEEGDFB, ELICNEDIBGB + MFANAJCHPHF * 2);
		int num4 = GAIIDMPAKMM(MOPCLEEGDFB, ELICNEDIBGB + MFANAJCHPHF * 3);
		num2 += PCIJPEKJHMB[0];
		num4 += PCIJPEKJHMB[1];
		for (int i = 1; i <= IALPHMOHPDI; i++)
		{
			int num5 = 0;
			int num6 = 0;
			num5 = num2 * (2 * num2 + 1);
			num5 = MBBDJFKAACD(num5, 5);
			num6 = num4 * (2 * num4 + 1);
			num6 = MBBDJFKAACD(num6, 5);
			num ^= num5;
			num = MBBDJFKAACD(num, num6);
			num += PCIJPEKJHMB[2 * i];
			num3 ^= num6;
			num3 = MBBDJFKAACD(num3, num5);
			num3 += PCIJPEKJHMB[2 * i + 1];
			int num7 = num;
			num = num2;
			num2 = num3;
			num3 = num4;
			num4 = num7;
		}
		num += PCIJPEKJHMB[2 * IALPHMOHPDI + 2];
		num3 += PCIJPEKJHMB[2 * IALPHMOHPDI + 3];
		BBBGPLNNMDM(num, NGAGMIIBGKA, EMAKNGBIFDC);
		BBBGPLNNMDM(num2, NGAGMIIBGKA, EMAKNGBIFDC + MFANAJCHPHF);
		BBBGPLNNMDM(num3, NGAGMIIBGKA, EMAKNGBIFDC + MFANAJCHPHF * 2);
		BBBGPLNNMDM(num4, NGAGMIIBGKA, EMAKNGBIFDC + MFANAJCHPHF * 3);
		return 4 * MFANAJCHPHF;
	}

	private int GFKALHGNIOJ(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		int num = GAIIDMPAKMM(MOPCLEEGDFB, ELICNEDIBGB);
		int num2 = GAIIDMPAKMM(MOPCLEEGDFB, ELICNEDIBGB + MFANAJCHPHF);
		int num3 = GAIIDMPAKMM(MOPCLEEGDFB, ELICNEDIBGB + MFANAJCHPHF * 2);
		int num4 = GAIIDMPAKMM(MOPCLEEGDFB, ELICNEDIBGB + MFANAJCHPHF * 3);
		num3 -= PCIJPEKJHMB[2 * IALPHMOHPDI + 3];
		num -= PCIJPEKJHMB[2 * IALPHMOHPDI + 2];
		for (int num5 = IALPHMOHPDI; num5 >= 1; num5--)
		{
			int num6 = 0;
			int num7 = 0;
			int num8 = num4;
			num4 = num3;
			num3 = num2;
			num2 = num;
			num = num8;
			num6 = num2 * (2 * num2 + 1);
			num6 = MBBDJFKAACD(num6, CLMMJCICIBE);
			num7 = num4 * (2 * num4 + 1);
			num7 = MBBDJFKAACD(num7, CLMMJCICIBE);
			num3 -= PCIJPEKJHMB[2 * num5 + 1];
			num3 = AIFAMJPHAAF(num3, num6);
			num3 ^= num7;
			num -= PCIJPEKJHMB[2 * num5];
			num = AIFAMJPHAAF(num, num7);
			num ^= num6;
		}
		num4 -= PCIJPEKJHMB[1];
		num2 -= PCIJPEKJHMB[0];
		BBBGPLNNMDM(num, NGAGMIIBGKA, EMAKNGBIFDC);
		BBBGPLNNMDM(num2, NGAGMIIBGKA, EMAKNGBIFDC + MFANAJCHPHF);
		BBBGPLNNMDM(num3, NGAGMIIBGKA, EMAKNGBIFDC + MFANAJCHPHF * 2);
		BBBGPLNNMDM(num4, NGAGMIIBGKA, EMAKNGBIFDC + MFANAJCHPHF * 3);
		return 4 * MFANAJCHPHF;
	}

	private int MBBDJFKAACD(int AMFCENFNAJJ, int CNLILOEEBOJ)
	{
		return (AMFCENFNAJJ << (CNLILOEEBOJ & (EIPGPJENMOB - 1))) | (int)((uint)AMFCENFNAJJ >> EIPGPJENMOB - (CNLILOEEBOJ & (EIPGPJENMOB - 1)));
	}

	private int AIFAMJPHAAF(int AMFCENFNAJJ, int CNLILOEEBOJ)
	{
		return (int)((uint)AMFCENFNAJJ >> (CNLILOEEBOJ & (EIPGPJENMOB - 1))) | (AMFCENFNAJJ << EIPGPJENMOB - (CNLILOEEBOJ & (EIPGPJENMOB - 1)));
	}

	private int GAIIDMPAKMM(byte[] ENICBMKPJJK, int DCFOILFMIEK)
	{
		int num = 0;
		for (int num2 = MFANAJCHPHF - 1; num2 >= 0; num2--)
		{
			num = (num << 8) + (ENICBMKPJJK[num2 + DCFOILFMIEK] & 0xFF);
		}
		return num;
	}

	private void BBBGPLNNMDM(int BKKMJAIKJAL, byte[] PPFHFMDDDLM, int BJEPNGMGPDI)
	{
		for (int i = 0; i < MFANAJCHPHF; i++)
		{
			PPFHFMDDDLM[i + BJEPNGMGPDI] = (byte)BKKMJAIKJAL;
			BKKMJAIKJAL = (int)((uint)BKKMJAIKJAL >> 8);
		}
	}
}
