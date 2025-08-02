using System;
using System.Collections;

public class NIAFGAPALCG : JMPFLJGHAIM
{
	private const int OBDGIDCKDFM = 8;

	private int[] IOANFHFGPJK;

	private bool MAEALKEJALK;

	private byte[] PCPPGMNCBJG = JHAFPDHDODK;

	private static readonly byte[] JHAFPDHDODK;

	private static readonly byte[] AHMAEGFBJPB;

	private static readonly byte[] NMNHBBBGEIE;

	private static readonly byte[] GPICHPCAMGH;

	private static readonly byte[] BJHADECGDIH;

	private static readonly byte[] CLOHLOLOFOP;

	private static readonly byte[] NHABNAFPFAH;

	private static readonly byte[] OJNDOFKGHIB;

	private static readonly IDictionary ONKGGPJKCED;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return "Gost28147";
		}
	}

	public virtual bool ABNLKPDCGEF
	{
		get
		{
			return false;
		}
	}

	static NIAFGAPALCG()
	{
		JHAFPDHDODK = new byte[128]
		{
			4, 10, 9, 2, 13, 8, 0, 14, 6, 11,
			1, 12, 7, 15, 5, 3, 14, 11, 4, 12,
			6, 13, 15, 10, 2, 3, 8, 1, 0, 7,
			5, 9, 5, 8, 1, 13, 10, 3, 4, 2,
			14, 15, 12, 7, 6, 0, 9, 11, 7, 13,
			10, 1, 0, 8, 9, 15, 14, 4, 6, 12,
			11, 2, 5, 3, 6, 12, 7, 1, 5, 15,
			13, 8, 4, 10, 9, 14, 0, 3, 11, 2,
			4, 11, 10, 0, 7, 2, 1, 13, 3, 6,
			8, 5, 9, 12, 15, 14, 13, 11, 4, 1,
			3, 15, 5, 9, 0, 10, 14, 7, 6, 8,
			2, 12, 1, 15, 13, 0, 5, 7, 10, 4,
			9, 2, 3, 14, 6, 11, 8, 12
		};
		AHMAEGFBJPB = new byte[128]
		{
			4, 2, 15, 5, 9, 1, 0, 8, 14, 3,
			11, 12, 13, 7, 10, 6, 12, 9, 15, 14,
			8, 1, 3, 10, 2, 7, 4, 13, 6, 0,
			11, 5, 13, 8, 14, 12, 7, 3, 9, 10,
			1, 5, 2, 4, 6, 15, 0, 11, 14, 9,
			11, 2, 5, 15, 7, 1, 0, 13, 12, 6,
			10, 4, 3, 8, 3, 14, 5, 9, 6, 8,
			0, 13, 10, 11, 7, 12, 2, 1, 15, 4,
			8, 15, 6, 11, 1, 9, 12, 5, 13, 3,
			7, 10, 0, 14, 2, 4, 9, 11, 12, 0,
			3, 6, 7, 5, 4, 8, 14, 15, 1, 10,
			2, 13, 12, 6, 5, 2, 11, 0, 9, 13,
			3, 14, 7, 10, 15, 4, 1, 8
		};
		NMNHBBBGEIE = new byte[128]
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
		GPICHPCAMGH = new byte[128]
		{
			8, 4, 11, 1, 3, 5, 0, 9, 2, 14,
			10, 12, 13, 6, 7, 15, 0, 1, 2, 10,
			4, 13, 5, 12, 9, 7, 3, 15, 11, 8,
			6, 14, 14, 12, 0, 10, 9, 2, 13, 11,
			7, 5, 8, 15, 3, 6, 1, 4, 7, 5,
			0, 13, 11, 6, 1, 2, 3, 10, 12, 15,
			4, 14, 9, 8, 2, 7, 12, 15, 9, 5,
			10, 11, 1, 4, 0, 13, 6, 8, 14, 3,
			8, 3, 2, 6, 4, 13, 14, 11, 12, 1,
			7, 15, 10, 0, 9, 5, 5, 2, 10, 11,
			9, 1, 12, 3, 7, 4, 13, 0, 6, 15,
			8, 14, 0, 4, 11, 14, 8, 3, 7, 1,
			10, 2, 9, 6, 15, 13, 5, 12
		};
		BJHADECGDIH = new byte[128]
		{
			1, 11, 12, 2, 9, 13, 0, 15, 4, 5,
			8, 14, 10, 7, 6, 3, 0, 1, 7, 13,
			11, 4, 5, 2, 8, 14, 15, 12, 9, 10,
			6, 3, 8, 2, 5, 0, 4, 9, 15, 10,
			3, 7, 12, 13, 6, 14, 1, 11, 3, 6,
			0, 1, 5, 13, 10, 8, 11, 2, 9, 7,
			14, 15, 12, 4, 8, 13, 11, 0, 4, 5,
			1, 2, 9, 3, 12, 14, 6, 15, 10, 7,
			12, 9, 11, 1, 8, 14, 2, 4, 7, 3,
			6, 5, 10, 0, 15, 13, 10, 9, 6, 8,
			13, 14, 2, 0, 15, 3, 5, 11, 4, 1,
			12, 7, 7, 4, 0, 5, 10, 2, 15, 14,
			12, 6, 1, 11, 13, 9, 3, 8
		};
		CLOHLOLOFOP = new byte[128]
		{
			15, 12, 2, 10, 6, 4, 5, 0, 7, 9,
			14, 13, 1, 11, 8, 3, 11, 6, 3, 4,
			12, 15, 14, 2, 7, 13, 8, 0, 5, 10,
			9, 1, 1, 12, 11, 0, 15, 14, 6, 5,
			10, 13, 4, 8, 9, 3, 7, 2, 1, 5,
			14, 12, 10, 7, 0, 13, 6, 2, 11, 4,
			9, 3, 15, 8, 0, 12, 8, 9, 13, 2,
			10, 11, 7, 3, 6, 5, 4, 14, 15, 1,
			8, 0, 15, 3, 2, 5, 14, 11, 1, 10,
			4, 7, 12, 9, 13, 6, 3, 0, 6, 15,
			1, 14, 9, 2, 13, 8, 12, 4, 11, 10,
			5, 7, 1, 10, 6, 8, 15, 11, 0, 4,
			12, 3, 5, 9, 7, 13, 2, 14
		};
		NHABNAFPFAH = new byte[128]
		{
			4, 10, 9, 2, 13, 8, 0, 14, 6, 11,
			1, 12, 7, 15, 5, 3, 14, 11, 4, 12,
			6, 13, 15, 10, 2, 3, 8, 1, 0, 7,
			5, 9, 5, 8, 1, 13, 10, 3, 4, 2,
			14, 15, 12, 7, 6, 0, 9, 11, 7, 13,
			10, 1, 0, 8, 9, 15, 14, 4, 6, 12,
			11, 2, 5, 3, 6, 12, 7, 1, 5, 15,
			13, 8, 4, 10, 9, 14, 0, 3, 11, 2,
			4, 11, 10, 0, 7, 2, 1, 13, 3, 6,
			8, 5, 9, 12, 15, 14, 13, 11, 4, 1,
			3, 15, 5, 9, 0, 10, 14, 7, 6, 8,
			2, 12, 1, 15, 13, 0, 5, 7, 10, 4,
			9, 2, 3, 14, 6, 11, 8, 12
		};
		OJNDOFKGHIB = new byte[128]
		{
			10, 4, 5, 6, 8, 1, 3, 7, 13, 12,
			14, 0, 9, 2, 11, 15, 5, 15, 4, 0,
			2, 13, 11, 9, 1, 7, 6, 3, 12, 14,
			10, 8, 7, 15, 12, 14, 9, 4, 1, 0,
			3, 11, 5, 2, 6, 10, 8, 13, 4, 10,
			7, 12, 0, 15, 2, 8, 14, 1, 6, 5,
			13, 11, 9, 3, 7, 6, 4, 11, 9, 12,
			2, 10, 1, 8, 0, 14, 15, 13, 3, 5,
			7, 6, 2, 4, 13, 9, 15, 0, 10, 1,
			5, 11, 8, 14, 12, 3, 13, 14, 4, 1,
			7, 0, 5, 10, 3, 12, 8, 15, 6, 2,
			9, 11, 1, 3, 10, 9, 5, 11, 4, 15,
			8, 6, 7, 14, 13, 0, 2, 12
		};
		ONKGGPJKCED = LHFGHNFJIKM.JBEOCJEMGCE();
		OCEMHPONHJC("Default", JHAFPDHDODK);
		OCEMHPONHJC("E-TEST", AHMAEGFBJPB);
		OCEMHPONHJC("E-A", NMNHBBBGEIE);
		OCEMHPONHJC("E-B", GPICHPCAMGH);
		OCEMHPONHJC("E-C", BJHADECGDIH);
		OCEMHPONHJC("E-D", CLOHLOLOFOP);
		OCEMHPONHJC("D-TEST", NHABNAFPFAH);
		OCEMHPONHJC("D-A", OJNDOFKGHIB);
	}

	private static void OCEMHPONHJC(string BAFEEDJOBLK, byte[] GFKMKGFENOL)
	{
		ONKGGPJKCED.Add(LHFGHNFJIKM.OGLCLCODHJI(BAFEEDJOBLK), GFKMKGFENOL);
	}

	public virtual void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		if (IJJHBEECMBP is KPIGIPHDHAF)
		{
			KPIGIPHDHAF kPIGIPHDHAF = (KPIGIPHDHAF)IJJHBEECMBP;
			byte[] array = kPIGIPHDHAF.JCBMNCIEKKG();
			if (array.Length != JHAFPDHDODK.Length)
			{
				throw new ArgumentException("invalid S-box passed to GOST28147 init");
			}
			PCPPGMNCBJG = NOGCEBKPPJE.IKBFGGABMKP(array);
			if (kPIGIPHDHAF.KPJHHAAOFOH != null)
			{
				IOANFHFGPJK = GIKFHLCLHDL(MAEALKEJALK, ((JEMNCGMEABF)kPIGIPHDHAF.KPJHHAAOFOH).MEGBFHFMBFI());
			}
		}
		else if (IJJHBEECMBP is JEMNCGMEABF)
		{
			IOANFHFGPJK = GIKFHLCLHDL(MAEALKEJALK, ((JEMNCGMEABF)IJJHBEECMBP).MEGBFHFMBFI());
		}
		else if (IJJHBEECMBP != null)
		{
			throw new ArgumentException("invalid parameter passed to Gost28147 init - " + LHFGHNFJIKM.JKHOEKAOLPM(IJJHBEECMBP));
		}
	}

	public virtual int BDIGGHEPIIP()
	{
		return 8;
	}

	public virtual int DPACJDFHLKB(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		if (IOANFHFGPJK == null)
		{
			throw new InvalidOperationException("Gost28147 engine not initialised");
		}
		AJLDFGNHDCA.OONDALLFPOP(MOPCLEEGDFB, ELICNEDIBGB, 8, "input buffer too short");
		AJLDFGNHDCA.KLPNFGNKNKB(BILGCJNPJGJ, EMAKNGBIFDC, 8, "output buffer too short");
		BKNHOOFAAKI(IOANFHFGPJK, MOPCLEEGDFB, ELICNEDIBGB, BILGCJNPJGJ, EMAKNGBIFDC);
		return 8;
	}

	public virtual void OMOKOKFNBKI()
	{
	}

	private int[] GIKFHLCLHDL(bool MAEALKEJALK, byte[] DEDPIJLBCKL)
	{
		this.MAEALKEJALK = MAEALKEJALK;
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

	private int AOKIHJFJFBJ(int KNCJIPNNOHO, int IKNCPEPOKGJ)
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

	private void BKNHOOFAAKI(int[] IOANFHFGPJK, byte[] AIFKJBMJOMK, int ELICNEDIBGB, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		int num = MEJAAFCIBGE(AIFKJBMJOMK, ELICNEDIBGB);
		int num2 = MEJAAFCIBGE(AIFKJBMJOMK, ELICNEDIBGB + 4);
		if (MAEALKEJALK)
		{
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					int num3 = num;
					int num4 = AOKIHJFJFBJ(num, IOANFHFGPJK[j]);
					num = num2 ^ num4;
					num2 = num3;
				}
			}
			for (int num5 = 7; num5 > 0; num5--)
			{
				int num3 = num;
				num = num2 ^ AOKIHJFJFBJ(num, IOANFHFGPJK[num5]);
				num2 = num3;
			}
		}
		else
		{
			for (int k = 0; k < 8; k++)
			{
				int num3 = num;
				num = num2 ^ AOKIHJFJFBJ(num, IOANFHFGPJK[k]);
				num2 = num3;
			}
			for (int l = 0; l < 3; l++)
			{
				int num6 = 7;
				while (num6 >= 0 && (l != 2 || num6 != 0))
				{
					int num3 = num;
					num = num2 ^ AOKIHJFJFBJ(num, IOANFHFGPJK[num6]);
					num2 = num3;
					num6--;
				}
			}
		}
		num2 ^= AOKIHJFJFBJ(num, IOANFHFGPJK[0]);
		DLGDEJANENH(num, NGAGMIIBGKA, EMAKNGBIFDC);
		DLGDEJANENH(num2, NGAGMIIBGKA, EMAKNGBIFDC + 4);
	}

	private static int MEJAAFCIBGE(byte[] AIFKJBMJOMK, int ELICNEDIBGB)
	{
		return (int)((AIFKJBMJOMK[ELICNEDIBGB + 3] << 24) & 0xFF000000u) + ((AIFKJBMJOMK[ELICNEDIBGB + 2] << 16) & 0xFF0000) + ((AIFKJBMJOMK[ELICNEDIBGB + 1] << 8) & 0xFF00) + (AIFKJBMJOMK[ELICNEDIBGB] & 0xFF);
	}

	private static void DLGDEJANENH(int AAEGOMKANGC, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		NGAGMIIBGKA[EMAKNGBIFDC + 3] = (byte)(AAEGOMKANGC >> 24);
		NGAGMIIBGKA[EMAKNGBIFDC + 2] = (byte)(AAEGOMKANGC >> 16);
		NGAGMIIBGKA[EMAKNGBIFDC + 1] = (byte)(AAEGOMKANGC >> 8);
		NGAGMIIBGKA[EMAKNGBIFDC] = (byte)AAEGOMKANGC;
	}

	public static byte[] JCBMNCIEKKG(string BAFEEDJOBLK)
	{
		byte[] array = (byte[])ONKGGPJKCED[LHFGHNFJIKM.OGLCLCODHJI(BAFEEDJOBLK)];
		if (array == null)
		{
			throw new ArgumentException("Unknown S-Box - possible types: \"Default\", \"E-Test\", \"E-A\", \"E-B\", \"E-C\", \"E-D\", \"D-Test\", \"D-A\".");
		}
		return NOGCEBKPPJE.IKBFGGABMKP(array);
	}
}
