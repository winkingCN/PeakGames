using System;

public class EMABOFELCJN : JMPFLJGHAIM
{
	private const int ANKLOALOPKP = 8;

	private int[] IOANFHFGPJK;

	private static readonly int EJILLLBOHGM = 65535;

	private static readonly int PCFDNBPMJEC = 65537;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return "IDEA";
		}
	}

	public virtual bool ABNLKPDCGEF
	{
		get
		{
			return false;
		}
	}

	public virtual void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		if (!(IJJHBEECMBP is JEMNCGMEABF))
		{
			throw new ArgumentException("invalid parameter passed to IDEA init - " + LHFGHNFJIKM.JKHOEKAOLPM(IJJHBEECMBP));
		}
		IOANFHFGPJK = DNIOCLEEKMH(MAEALKEJALK, ((JEMNCGMEABF)IJJHBEECMBP).MEGBFHFMBFI());
	}

	public virtual int BDIGGHEPIIP()
	{
		return 8;
	}

	public virtual int DPACJDFHLKB(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		if (IOANFHFGPJK == null)
		{
			throw new InvalidOperationException("IDEA engine not initialised");
		}
		AJLDFGNHDCA.OONDALLFPOP(MOPCLEEGDFB, ELICNEDIBGB, 8, "input buffer too short");
		AJLDFGNHDCA.KLPNFGNKNKB(BILGCJNPJGJ, EMAKNGBIFDC, 8, "output buffer too short");
		MINJNAACGMO(IOANFHFGPJK, MOPCLEEGDFB, ELICNEDIBGB, BILGCJNPJGJ, EMAKNGBIFDC);
		return 8;
	}

	public virtual void OMOKOKFNBKI()
	{
	}

	private int GAIIDMPAKMM(byte[] MOPCLEEGDFB, int ELICNEDIBGB)
	{
		return ((MOPCLEEGDFB[ELICNEDIBGB] << 8) & 0xFF00) + (MOPCLEEGDFB[ELICNEDIBGB + 1] & 0xFF);
	}

	private void BBBGPLNNMDM(int BKKMJAIKJAL, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		NGAGMIIBGKA[EMAKNGBIFDC] = (byte)((uint)BKKMJAIKJAL >> 8);
		NGAGMIIBGKA[EMAKNGBIFDC + 1] = (byte)BKKMJAIKJAL;
	}

	private int BMEIFJDODCF(int AMFCENFNAJJ, int CNLILOEEBOJ)
	{
		if (AMFCENFNAJJ == 0)
		{
			AMFCENFNAJJ = PCFDNBPMJEC - CNLILOEEBOJ;
		}
		else if (CNLILOEEBOJ == 0)
		{
			AMFCENFNAJJ = PCFDNBPMJEC - AMFCENFNAJJ;
		}
		else
		{
			int num = AMFCENFNAJJ * CNLILOEEBOJ;
			CNLILOEEBOJ = num & EJILLLBOHGM;
			AMFCENFNAJJ = (int)((uint)num >> 16);
			AMFCENFNAJJ = CNLILOEEBOJ - AMFCENFNAJJ + ((CNLILOEEBOJ < AMFCENFNAJJ) ? 1 : 0);
		}
		return AMFCENFNAJJ & EJILLLBOHGM;
	}

	private void MINJNAACGMO(int[] IOANFHFGPJK, byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		int num = 0;
		int aMFCENFNAJJ = GAIIDMPAKMM(MOPCLEEGDFB, ELICNEDIBGB);
		int num2 = GAIIDMPAKMM(MOPCLEEGDFB, ELICNEDIBGB + 2);
		int num3 = GAIIDMPAKMM(MOPCLEEGDFB, ELICNEDIBGB + 4);
		int aMFCENFNAJJ2 = GAIIDMPAKMM(MOPCLEEGDFB, ELICNEDIBGB + 6);
		for (int i = 0; i < 8; i++)
		{
			aMFCENFNAJJ = BMEIFJDODCF(aMFCENFNAJJ, IOANFHFGPJK[num++]);
			num2 += IOANFHFGPJK[num++];
			num2 &= EJILLLBOHGM;
			num3 += IOANFHFGPJK[num++];
			num3 &= EJILLLBOHGM;
			aMFCENFNAJJ2 = BMEIFJDODCF(aMFCENFNAJJ2, IOANFHFGPJK[num++]);
			int num4 = num2;
			int num5 = num3;
			num3 ^= aMFCENFNAJJ;
			num2 ^= aMFCENFNAJJ2;
			num3 = BMEIFJDODCF(num3, IOANFHFGPJK[num++]);
			num2 += num3;
			num2 &= EJILLLBOHGM;
			num2 = BMEIFJDODCF(num2, IOANFHFGPJK[num++]);
			num3 += num2;
			num3 &= EJILLLBOHGM;
			aMFCENFNAJJ ^= num2;
			aMFCENFNAJJ2 ^= num3;
			num2 ^= num5;
			num3 ^= num4;
		}
		BBBGPLNNMDM(BMEIFJDODCF(aMFCENFNAJJ, IOANFHFGPJK[num++]), NGAGMIIBGKA, EMAKNGBIFDC);
		BBBGPLNNMDM(num3 + IOANFHFGPJK[num++], NGAGMIIBGKA, EMAKNGBIFDC + 2);
		BBBGPLNNMDM(num2 + IOANFHFGPJK[num++], NGAGMIIBGKA, EMAKNGBIFDC + 4);
		BBBGPLNNMDM(BMEIFJDODCF(aMFCENFNAJJ2, IOANFHFGPJK[num]), NGAGMIIBGKA, EMAKNGBIFDC + 6);
	}

	private int[] KDHLCJJNMNO(byte[] CCHMNOIFDKI)
	{
		int[] array = new int[52];
		if (CCHMNOIFDKI.Length < 16)
		{
			byte[] array2 = new byte[16];
			Array.Copy(CCHMNOIFDKI, 0, array2, array2.Length - CCHMNOIFDKI.Length, CCHMNOIFDKI.Length);
			CCHMNOIFDKI = array2;
		}
		for (int i = 0; i < 8; i++)
		{
			array[i] = GAIIDMPAKMM(CCHMNOIFDKI, i * 2);
		}
		for (int j = 8; j < 52; j++)
		{
			if ((j & 7) < 6)
			{
				array[j] = (((array[j - 7] & 0x7F) << 9) | (array[j - 6] >> 7)) & EJILLLBOHGM;
			}
			else if ((j & 7) == 6)
			{
				array[j] = (((array[j - 7] & 0x7F) << 9) | (array[j - 14] >> 7)) & EJILLLBOHGM;
			}
			else
			{
				array[j] = (((array[j - 15] & 0x7F) << 9) | (array[j - 14] >> 7)) & EJILLLBOHGM;
			}
		}
		return array;
	}

	private int LOAGKENLIHO(int AMFCENFNAJJ)
	{
		if (AMFCENFNAJJ < 2)
		{
			return AMFCENFNAJJ;
		}
		int num = 1;
		int num2 = PCFDNBPMJEC / AMFCENFNAJJ;
		int num3 = PCFDNBPMJEC % AMFCENFNAJJ;
		while (num3 != 1)
		{
			int num4 = AMFCENFNAJJ / num3;
			AMFCENFNAJJ %= num3;
			num = (num + num2 * num4) & EJILLLBOHGM;
			if (AMFCENFNAJJ == 1)
			{
				return num;
			}
			num4 = num3 / AMFCENFNAJJ;
			num3 %= AMFCENFNAJJ;
			num2 = (num2 + num * num4) & EJILLLBOHGM;
		}
		return (1 - num2) & EJILLLBOHGM;
	}

	private int ECKDEIGNFJK(int AMFCENFNAJJ)
	{
		return -AMFCENFNAJJ & EJILLLBOHGM;
	}

	private int[] KENFGGKFFMI(int[] OICMPEHMBIB)
	{
		int num = 52;
		int[] array = new int[52];
		int num2 = 0;
		int num3 = LOAGKENLIHO(OICMPEHMBIB[num2++]);
		int num4 = ECKDEIGNFJK(OICMPEHMBIB[num2++]);
		int num5 = ECKDEIGNFJK(OICMPEHMBIB[num2++]);
		int num6 = LOAGKENLIHO(OICMPEHMBIB[num2++]);
		array[--num] = num6;
		array[--num] = num5;
		array[--num] = num4;
		array[--num] = num3;
		for (int i = 1; i < 8; i++)
		{
			num3 = OICMPEHMBIB[num2++];
			num4 = OICMPEHMBIB[num2++];
			array[--num] = num4;
			array[--num] = num3;
			num3 = LOAGKENLIHO(OICMPEHMBIB[num2++]);
			num4 = ECKDEIGNFJK(OICMPEHMBIB[num2++]);
			num5 = ECKDEIGNFJK(OICMPEHMBIB[num2++]);
			num6 = LOAGKENLIHO(OICMPEHMBIB[num2++]);
			array[--num] = num6;
			array[--num] = num4;
			array[--num] = num5;
			array[--num] = num3;
		}
		num3 = OICMPEHMBIB[num2++];
		num4 = OICMPEHMBIB[num2++];
		array[--num] = num4;
		array[--num] = num3;
		num3 = LOAGKENLIHO(OICMPEHMBIB[num2++]);
		num4 = ECKDEIGNFJK(OICMPEHMBIB[num2++]);
		num5 = ECKDEIGNFJK(OICMPEHMBIB[num2++]);
		num6 = LOAGKENLIHO(OICMPEHMBIB[num2]);
		array[--num] = num6;
		array[--num] = num5;
		array[--num] = num4;
		array[--num] = num3;
		return array;
	}

	private int[] DNIOCLEEKMH(bool MAEALKEJALK, byte[] DEDPIJLBCKL)
	{
		if (MAEALKEJALK)
		{
			return KDHLCJJNMNO(DEDPIJLBCKL);
		}
		return KENFGGKFFMI(KDHLCJJNMNO(DEDPIJLBCKL));
	}
}
