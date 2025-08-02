using System;

public class JAPCELIIFGK : PHFBFDEAHMD
{
	private const int NONHELBCKCH = 8;

	private const int DLFPGGOCGNE = 4;

	private int MNIGMJPFNDA;

	private byte[] GHPCHPOHELF;

	private byte[] LGMMFPHDIMH;

	private bool JPAICGIPPOB = true;

	private int[] IOANFHFGPJK;

	private byte[] PCPPGMNCBJG = new byte[128]
	{
		9, 6, 3, 2, 8, 11, 1, 7, 10, 4,
		14, 15, 12, 0, 13, 5, 3, 7, 14, 9,
		8, 10, 15, 0, 5, 2, 6, 12, 11, 4,
		13, 1, 14, 4, 6, 2, 11, 3, 13, 8,
		12, 15, 5, 10, 0, 7, 1, 9, 14, 7,
		10, 12, 13, 1, 3, 9, 0, 2, 11, 4,
		15, 8, 5, 6, 11, 5, 1, 9, 8, 13,
		15, 0, 14, 4, 2, 3, 12, 7, 10, 6,
		3, 10, 13, 12, 1, 2, 0, 11, 7, 5,
		9, 4, 8, 15, 14, 6, 1, 13, 2, 9,
		7, 10, 6, 0, 8, 12, 4, 5, 15, 3,
		11, 14, 11, 10, 15, 5, 0, 12, 14, 8,
		6, 2, 3, 9, 1, 7, 13, 4
	};

	public string KFKMEPMEBND
	{
		get
		{
			return "Gost28147Mac";
		}
	}

	public JAPCELIIFGK()
	{
		LGMMFPHDIMH = new byte[8];
		GHPCHPOHELF = new byte[8];
		MNIGMJPFNDA = 0;
	}

	private static int[] GIKFHLCLHDL(byte[] DEDPIJLBCKL)
	{
		if (DEDPIJLBCKL.Length != 32)
		{
			throw new ArgumentException("Key length invalid. Key needs to be 32 byte - 256 bit!!!");
		}
		int[] array = new int[8];
		for (int i = 0; i != 8; i++)
		{
			array[i] = MEJAAFCIBGE(DEDPIJLBCKL, i * 4);
		}
		return array;
	}

	public void DIOELAHNLKJ(IGMAJHKIIPK IJJHBEECMBP)
	{
		OMOKOKFNBKI();
		GHPCHPOHELF = new byte[8];
		if (IJJHBEECMBP is KPIGIPHDHAF)
		{
			KPIGIPHDHAF kPIGIPHDHAF = (KPIGIPHDHAF)IJJHBEECMBP;
			kPIGIPHDHAF.JCBMNCIEKKG().CopyTo(PCPPGMNCBJG, 0);
			if (kPIGIPHDHAF.KPJHHAAOFOH != null)
			{
				IOANFHFGPJK = GIKFHLCLHDL(((JEMNCGMEABF)kPIGIPHDHAF.KPJHHAAOFOH).MEGBFHFMBFI());
			}
		}
		else
		{
			if (!(IJJHBEECMBP is JEMNCGMEABF))
			{
				throw new ArgumentException("invalid parameter passed to Gost28147 init - " + LHFGHNFJIKM.JKHOEKAOLPM(IJJHBEECMBP));
			}
			IOANFHFGPJK = GIKFHLCLHDL(((JEMNCGMEABF)IJJHBEECMBP).MEGBFHFMBFI());
		}
	}

	public int BKGLOJPPBIG()
	{
		return 4;
	}

	private int MMCOPEILHHA(int KNCJIPNNOHO, int IKNCPEPOKGJ)
	{
		int num = IKNCPEPOKGJ + KNCJIPNNOHO;
		int num2 = PCPPGMNCBJG[(num >> 0) & 0xF] << 0;
		num2 += PCPPGMNCBJG[16 + ((num >> 4) & 0xF)] << 4;
		num2 += PCPPGMNCBJG[32 + ((num >> 8) & 0xF)] << 8;
		num2 += PCPPGMNCBJG[48 + ((num >> 12) & 0xF)] << 12;
		num2 += PCPPGMNCBJG[64 + ((num >> 16) & 0xF)] << 16;
		num2 += PCPPGMNCBJG[80 + ((num >> 20) & 0xF)] << 20;
		num2 += PCPPGMNCBJG[96 + ((num >> 24) & 0xF)] << 24;
		num2 += PCPPGMNCBJG[112 + ((num >> 28) & 0xF)] << 28;
		int num3 = num2 << 11;
		int num4 = (int)((uint)num2 >> 21);
		return num3 | num4;
	}

	private void JFLICLHBCPI(int[] IOANFHFGPJK, byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		int num = MEJAAFCIBGE(MOPCLEEGDFB, ELICNEDIBGB);
		int num2 = MEJAAFCIBGE(MOPCLEEGDFB, ELICNEDIBGB + 4);
		for (int i = 0; i < 2; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				int num3 = num;
				num = num2 ^ MMCOPEILHHA(num, IOANFHFGPJK[j]);
				num2 = num3;
			}
		}
		DLGDEJANENH(num, BILGCJNPJGJ, EMAKNGBIFDC);
		DLGDEJANENH(num2, BILGCJNPJGJ, EMAKNGBIFDC + 4);
	}

	private static int MEJAAFCIBGE(byte[] MOPCLEEGDFB, int ELICNEDIBGB)
	{
		return (int)((MOPCLEEGDFB[ELICNEDIBGB + 3] << 24) & 0xFF000000u) + ((MOPCLEEGDFB[ELICNEDIBGB + 2] << 16) & 0xFF0000) + ((MOPCLEEGDFB[ELICNEDIBGB + 1] << 8) & 0xFF00) + (MOPCLEEGDFB[ELICNEDIBGB] & 0xFF);
	}

	private static void DLGDEJANENH(int AAEGOMKANGC, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		BILGCJNPJGJ[EMAKNGBIFDC + 3] = (byte)(AAEGOMKANGC >> 24);
		BILGCJNPJGJ[EMAKNGBIFDC + 2] = (byte)(AAEGOMKANGC >> 16);
		BILGCJNPJGJ[EMAKNGBIFDC + 1] = (byte)(AAEGOMKANGC >> 8);
		BILGCJNPJGJ[EMAKNGBIFDC] = (byte)AAEGOMKANGC;
	}

	private static byte[] NBBLNNIEFBC(byte[] GHPCHPOHELF, int MNIGMJPFNDA, byte[] LGMMFPHDIMH)
	{
		byte[] array = new byte[GHPCHPOHELF.Length - MNIGMJPFNDA];
		Array.Copy(GHPCHPOHELF, MNIGMJPFNDA, array, 0, LGMMFPHDIMH.Length);
		for (int i = 0; i != LGMMFPHDIMH.Length; i++)
		{
			array[i] ^= LGMMFPHDIMH[i];
		}
		return array;
	}

	public void BPAJGOINFNL(byte MOPCLEEGDFB)
	{
		if (MNIGMJPFNDA == GHPCHPOHELF.Length)
		{
			byte[] array = new byte[GHPCHPOHELF.Length];
			Array.Copy(GHPCHPOHELF, 0, array, 0, LGMMFPHDIMH.Length);
			if (JPAICGIPPOB)
			{
				JPAICGIPPOB = false;
			}
			else
			{
				array = NBBLNNIEFBC(GHPCHPOHELF, 0, LGMMFPHDIMH);
			}
			JFLICLHBCPI(IOANFHFGPJK, array, 0, LGMMFPHDIMH, 0);
			MNIGMJPFNDA = 0;
		}
		GHPCHPOHELF[MNIGMJPFNDA++] = MOPCLEEGDFB;
	}

	public void GONEEEFEDGF(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int NBEDPKHALCN)
	{
		if (NBEDPKHALCN < 0)
		{
			throw new ArgumentException("Can't have a negative input length!");
		}
		int num = 8 - MNIGMJPFNDA;
		if (NBEDPKHALCN > num)
		{
			Array.Copy(MOPCLEEGDFB, ELICNEDIBGB, GHPCHPOHELF, MNIGMJPFNDA, num);
			byte[] array = new byte[GHPCHPOHELF.Length];
			Array.Copy(GHPCHPOHELF, 0, array, 0, LGMMFPHDIMH.Length);
			if (JPAICGIPPOB)
			{
				JPAICGIPPOB = false;
			}
			else
			{
				array = NBBLNNIEFBC(GHPCHPOHELF, 0, LGMMFPHDIMH);
			}
			JFLICLHBCPI(IOANFHFGPJK, array, 0, LGMMFPHDIMH, 0);
			MNIGMJPFNDA = 0;
			NBEDPKHALCN -= num;
			ELICNEDIBGB += num;
			while (NBEDPKHALCN > 8)
			{
				array = NBBLNNIEFBC(MOPCLEEGDFB, ELICNEDIBGB, LGMMFPHDIMH);
				JFLICLHBCPI(IOANFHFGPJK, array, 0, LGMMFPHDIMH, 0);
				NBEDPKHALCN -= 8;
				ELICNEDIBGB += 8;
			}
		}
		Array.Copy(MOPCLEEGDFB, ELICNEDIBGB, GHPCHPOHELF, MNIGMJPFNDA, NBEDPKHALCN);
		MNIGMJPFNDA += NBEDPKHALCN;
	}

	public int LCNOFBMOHHM(byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		while (MNIGMJPFNDA < 8)
		{
			GHPCHPOHELF[MNIGMJPFNDA++] = 0;
		}
		byte[] array = new byte[GHPCHPOHELF.Length];
		Array.Copy(GHPCHPOHELF, 0, array, 0, LGMMFPHDIMH.Length);
		if (JPAICGIPPOB)
		{
			JPAICGIPPOB = false;
		}
		else
		{
			array = NBBLNNIEFBC(GHPCHPOHELF, 0, LGMMFPHDIMH);
		}
		JFLICLHBCPI(IOANFHFGPJK, array, 0, LGMMFPHDIMH, 0);
		Array.Copy(LGMMFPHDIMH, LGMMFPHDIMH.Length / 2 - 4, BILGCJNPJGJ, EMAKNGBIFDC, 4);
		OMOKOKFNBKI();
		return 4;
	}

	public void OMOKOKFNBKI()
	{
		Array.Clear(GHPCHPOHELF, 0, GHPCHPOHELF.Length);
		MNIGMJPFNDA = 0;
		JPAICGIPPOB = true;
	}
}
