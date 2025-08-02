using System;

public sealed class BJCPOLAOIAB : BJLAMONNNDD, MIPBJNJHNGA
{
	private const int DKJNJMLHHFD = 64;

	private const int DPOHBIDBMDP = 64;

	private const int DFBJOFIADHK = 10;

	private const int MMCIGPPODLJ = 285;

	private static readonly int[] DJBGHJGHICF;

	private static readonly long[] DMGCLBGPJEC;

	private static readonly long[] CIDLKLHOKHP;

	private static readonly long[] PLJEFFLCHFO;

	private static readonly long[] IMBAIFONFBO;

	private static readonly long[] DAOOGNMAHNK;

	private static readonly long[] PGKNGJGIKHK;

	private static readonly long[] BNENJNLBKKP;

	private static readonly long[] HKHBAEJBBDN;

	private readonly long[] LGOLHGMLNAM = new long[11];

	private static readonly short[] LNJILKGGEDP;

	private const int AAPPEANMDJF = 32;

	private byte[] JNFCEBOLANF = new byte[64];

	private int GLJGEKLFAMM;

	private short[] OCIOLDBDBJN = new short[32];

	private long[] ABLHHNNDLCP = new long[8];

	private long[] LAGKKAMIJON = new long[8];

	private long[] ABPHAOMIBJB = new long[8];

	private long[] OCLDEELPLFC = new long[8];

	private long[] AHEAGFKDBHP = new long[8];

	public string KFKMEPMEBND
	{
		get
		{
			return "Whirlpool";
		}
	}

	static BJCPOLAOIAB()
	{
		DJBGHJGHICF = new int[256]
		{
			24, 35, 198, 232, 135, 184, 1, 79, 54, 166,
			210, 245, 121, 111, 145, 82, 96, 188, 155, 142,
			163, 12, 123, 53, 29, 224, 215, 194, 46, 75,
			254, 87, 21, 119, 55, 229, 159, 240, 74, 218,
			88, 201, 41, 10, 177, 160, 107, 133, 189, 93,
			16, 244, 203, 62, 5, 103, 228, 39, 65, 139,
			167, 125, 149, 216, 251, 238, 124, 102, 221, 23,
			71, 158, 202, 45, 191, 7, 173, 90, 131, 51,
			99, 2, 170, 113, 200, 25, 73, 217, 242, 227,
			91, 136, 154, 38, 50, 176, 233, 15, 213, 128,
			190, 205, 52, 72, 255, 122, 144, 95, 32, 104,
			26, 174, 180, 84, 147, 34, 100, 241, 115, 18,
			64, 8, 195, 236, 219, 161, 141, 61, 151, 0,
			207, 43, 118, 130, 214, 27, 181, 175, 106, 80,
			69, 243, 48, 239, 63, 85, 162, 234, 101, 186,
			47, 192, 222, 28, 253, 77, 146, 117, 6, 138,
			178, 230, 14, 31, 98, 212, 168, 150, 249, 197,
			37, 89, 132, 114, 57, 76, 94, 120, 56, 140,
			209, 165, 226, 97, 179, 33, 156, 30, 67, 199,
			252, 4, 81, 153, 109, 13, 250, 223, 126, 36,
			59, 171, 206, 17, 143, 78, 183, 235, 60, 129,
			148, 247, 185, 19, 44, 211, 231, 110, 196, 3,
			86, 68, 127, 169, 42, 187, 193, 83, 220, 11,
			157, 108, 49, 116, 246, 70, 172, 137, 20, 225,
			22, 58, 105, 9, 112, 182, 208, 237, 204, 66,
			152, 164, 40, 92, 248, 134
		};
		DMGCLBGPJEC = new long[256];
		CIDLKLHOKHP = new long[256];
		PLJEFFLCHFO = new long[256];
		IMBAIFONFBO = new long[256];
		DAOOGNMAHNK = new long[256];
		PGKNGJGIKHK = new long[256];
		BNENJNLBKKP = new long[256];
		HKHBAEJBBDN = new long[256];
		LNJILKGGEDP = new short[32];
		LNJILKGGEDP[31] = 8;
		for (int i = 0; i < 256; i++)
		{
			int num = DJBGHJGHICF[i];
			int num2 = MFDPDALGGBG(num << 1);
			int num3 = MFDPDALGGBG(num2 << 1);
			int num4 = num3 ^ num;
			int num5 = MFDPDALGGBG(num3 << 1);
			int num6 = num5 ^ num;
			DMGCLBGPJEC[i] = FANNENEAGBF(num, num, num3, num, num5, num4, num2, num6);
			CIDLKLHOKHP[i] = FANNENEAGBF(num6, num, num, num3, num, num5, num4, num2);
			PLJEFFLCHFO[i] = FANNENEAGBF(num2, num6, num, num, num3, num, num5, num4);
			IMBAIFONFBO[i] = FANNENEAGBF(num4, num2, num6, num, num, num3, num, num5);
			DAOOGNMAHNK[i] = FANNENEAGBF(num5, num4, num2, num6, num, num, num3, num);
			PGKNGJGIKHK[i] = FANNENEAGBF(num, num5, num4, num2, num6, num, num, num3);
			BNENJNLBKKP[i] = FANNENEAGBF(num3, num, num5, num4, num2, num6, num, num);
			HKHBAEJBBDN[i] = FANNENEAGBF(num, num3, num, num5, num4, num2, num6, num);
		}
	}

	public BJCPOLAOIAB()
	{
		LGOLHGMLNAM[0] = 0L;
		for (int i = 1; i <= 10; i++)
		{
			int num = 8 * (i - 1);
			LGOLHGMLNAM[i] = (DMGCLBGPJEC[num] & -72057594037927936L) ^ (CIDLKLHOKHP[num + 1] & 0xFF000000000000L) ^ (PLJEFFLCHFO[num + 2] & 0xFF0000000000L) ^ (IMBAIFONFBO[num + 3] & 0xFF00000000L) ^ (DAOOGNMAHNK[num + 4] & 0xFF000000u) ^ (PGKNGJGIKHK[num + 5] & 0xFF0000) ^ (BNENJNLBKKP[num + 6] & 0xFF00) ^ (HKHBAEJBBDN[num + 7] & 0xFF);
		}
	}

	public BJCPOLAOIAB(BJCPOLAOIAB EFAGJODEIPL)
	{
		OMOKOKFNBKI(EFAGJODEIPL);
	}

	private static long FANNENEAGBF(int GALPMHKNNJJ, int EDIJDAAOGEB, int APMJKHGANNE, int JOPHHGJACHN, int BCNHIBDMJPB, int DLGDBCBCIED, int NEHOIIIODHC, int KOMEOAGGJBI)
	{
		return ((long)GALPMHKNNJJ << 56) ^ ((long)EDIJDAAOGEB << 48) ^ ((long)APMJKHGANNE << 40) ^ ((long)JOPHHGJACHN << 32) ^ ((long)BCNHIBDMJPB << 24) ^ ((long)DLGDBCBCIED << 16) ^ ((long)NEHOIIIODHC << 8) ^ KOMEOAGGJBI;
	}

	private static int MFDPDALGGBG(int MOPCLEEGDFB)
	{
		int num = MOPCLEEGDFB;
		if ((long)num >= 256L)
		{
			num ^= 0x11D;
		}
		return num;
	}

	public int EEMLLAMENHO()
	{
		return 64;
	}

	public int LCNOFBMOHHM(byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		JGJKCJOJLDG();
		for (int i = 0; i < 8; i++)
		{
			NLHLIOAPPNI(ABLHHNNDLCP[i], BILGCJNPJGJ, EMAKNGBIFDC + i * 8);
		}
		OMOKOKFNBKI();
		return EEMLLAMENHO();
	}

	public void OMOKOKFNBKI()
	{
		GLJGEKLFAMM = 0;
		Array.Clear(OCIOLDBDBJN, 0, OCIOLDBDBJN.Length);
		Array.Clear(JNFCEBOLANF, 0, JNFCEBOLANF.Length);
		Array.Clear(ABLHHNNDLCP, 0, ABLHHNNDLCP.Length);
		Array.Clear(LAGKKAMIJON, 0, LAGKKAMIJON.Length);
		Array.Clear(ABPHAOMIBJB, 0, ABPHAOMIBJB.Length);
		Array.Clear(OCLDEELPLFC, 0, OCLDEELPLFC.Length);
		Array.Clear(AHEAGFKDBHP, 0, AHEAGFKDBHP.Length);
	}

	private void MCODIKGMECH()
	{
		for (int i = 0; i < AHEAGFKDBHP.Length; i++)
		{
			OCLDEELPLFC[i] = CEEIGHJNCGB(JNFCEBOLANF, i * 8);
		}
		PLBMMDHPFLI();
		GLJGEKLFAMM = 0;
		Array.Clear(JNFCEBOLANF, 0, JNFCEBOLANF.Length);
	}

	private static long CEEIGHJNCGB(byte[] DJDKLOJBJCO, int NBOLDLDHNGE)
	{
		return (long)((((ulong)(int)DJDKLOJBJCO[NBOLDLDHNGE] & 0xFFuL) << 56) | (((ulong)(int)DJDKLOJBJCO[NBOLDLDHNGE + 1] & 0xFFuL) << 48) | (((ulong)(int)DJDKLOJBJCO[NBOLDLDHNGE + 2] & 0xFFuL) << 40) | (((ulong)(int)DJDKLOJBJCO[NBOLDLDHNGE + 3] & 0xFFuL) << 32) | (((ulong)(int)DJDKLOJBJCO[NBOLDLDHNGE + 4] & 0xFFuL) << 24) | (((ulong)(int)DJDKLOJBJCO[NBOLDLDHNGE + 5] & 0xFFuL) << 16) | (((ulong)(int)DJDKLOJBJCO[NBOLDLDHNGE + 6] & 0xFFuL) << 8)) | ((long)(int)DJDKLOJBJCO[NBOLDLDHNGE + 7] & 0xFFL);
	}

	private static void NLHLIOAPPNI(long ILDKJAIIHAB, byte[] JJENKIPKEHA, int AFEFGFIAJOF)
	{
		for (int i = 0; i < 8; i++)
		{
			JJENKIPKEHA[AFEFGFIAJOF + i] = (byte)((ILDKJAIIHAB >> 56 - i * 8) & 0xFF);
		}
	}

	private void PLBMMDHPFLI()
	{
		for (int i = 0; i < 8; i++)
		{
			AHEAGFKDBHP[i] = OCLDEELPLFC[i] ^ (LAGKKAMIJON[i] = ABLHHNNDLCP[i]);
		}
		for (int j = 1; j <= 10; j++)
		{
			for (int k = 0; k < 8; k++)
			{
				ABPHAOMIBJB[k] = 0L;
				ABPHAOMIBJB[k] ^= DMGCLBGPJEC[(int)(LAGKKAMIJON[k & 7] >> 56) & 0xFF];
				ABPHAOMIBJB[k] ^= CIDLKLHOKHP[(int)(LAGKKAMIJON[(k - 1) & 7] >> 48) & 0xFF];
				ABPHAOMIBJB[k] ^= PLJEFFLCHFO[(int)(LAGKKAMIJON[(k - 2) & 7] >> 40) & 0xFF];
				ABPHAOMIBJB[k] ^= IMBAIFONFBO[(int)(LAGKKAMIJON[(k - 3) & 7] >> 32) & 0xFF];
				ABPHAOMIBJB[k] ^= DAOOGNMAHNK[(int)(LAGKKAMIJON[(k - 4) & 7] >> 24) & 0xFF];
				ABPHAOMIBJB[k] ^= PGKNGJGIKHK[(int)(LAGKKAMIJON[(k - 5) & 7] >> 16) & 0xFF];
				ABPHAOMIBJB[k] ^= BNENJNLBKKP[(int)(LAGKKAMIJON[(k - 6) & 7] >> 8) & 0xFF];
				ABPHAOMIBJB[k] ^= HKHBAEJBBDN[(int)LAGKKAMIJON[(k - 7) & 7] & 0xFF];
			}
			Array.Copy(ABPHAOMIBJB, 0, LAGKKAMIJON, 0, LAGKKAMIJON.Length);
			LAGKKAMIJON[0] ^= LGOLHGMLNAM[j];
			for (int l = 0; l < 8; l++)
			{
				ABPHAOMIBJB[l] = LAGKKAMIJON[l];
				ABPHAOMIBJB[l] ^= DMGCLBGPJEC[(int)(AHEAGFKDBHP[l & 7] >> 56) & 0xFF];
				ABPHAOMIBJB[l] ^= CIDLKLHOKHP[(int)(AHEAGFKDBHP[(l - 1) & 7] >> 48) & 0xFF];
				ABPHAOMIBJB[l] ^= PLJEFFLCHFO[(int)(AHEAGFKDBHP[(l - 2) & 7] >> 40) & 0xFF];
				ABPHAOMIBJB[l] ^= IMBAIFONFBO[(int)(AHEAGFKDBHP[(l - 3) & 7] >> 32) & 0xFF];
				ABPHAOMIBJB[l] ^= DAOOGNMAHNK[(int)(AHEAGFKDBHP[(l - 4) & 7] >> 24) & 0xFF];
				ABPHAOMIBJB[l] ^= PGKNGJGIKHK[(int)(AHEAGFKDBHP[(l - 5) & 7] >> 16) & 0xFF];
				ABPHAOMIBJB[l] ^= BNENJNLBKKP[(int)(AHEAGFKDBHP[(l - 6) & 7] >> 8) & 0xFF];
				ABPHAOMIBJB[l] ^= HKHBAEJBBDN[(int)AHEAGFKDBHP[(l - 7) & 7] & 0xFF];
			}
			Array.Copy(ABPHAOMIBJB, 0, AHEAGFKDBHP, 0, AHEAGFKDBHP.Length);
		}
		for (int m = 0; m < 8; m++)
		{
			ABLHHNNDLCP[m] ^= AHEAGFKDBHP[m] ^ OCLDEELPLFC[m];
		}
	}

	public void BPAJGOINFNL(byte MOPCLEEGDFB)
	{
		JNFCEBOLANF[GLJGEKLFAMM] = MOPCLEEGDFB;
		GLJGEKLFAMM++;
		if (GLJGEKLFAMM == JNFCEBOLANF.Length)
		{
			MCODIKGMECH();
		}
		GLCKKDDELKL();
	}

	private void GLCKKDDELKL()
	{
		int num = 0;
		for (int num2 = OCIOLDBDBJN.Length - 1; num2 >= 0; num2--)
		{
			int num3 = (OCIOLDBDBJN[num2] & 0xFF) + LNJILKGGEDP[num2] + num;
			num = num3 >> 8;
			OCIOLDBDBJN[num2] = (short)(num3 & 0xFF);
		}
	}

	public void GONEEEFEDGF(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP)
	{
		while (EOFAGACBNFP > 0)
		{
			BPAJGOINFNL(MOPCLEEGDFB[ELICNEDIBGB]);
			ELICNEDIBGB++;
			EOFAGACBNFP--;
		}
	}

	private void JGJKCJOJLDG()
	{
		byte[] array = OBGDIDNLAGA();
		JNFCEBOLANF[GLJGEKLFAMM++] |= 128;
		if (GLJGEKLFAMM == JNFCEBOLANF.Length)
		{
			MCODIKGMECH();
		}
		if (GLJGEKLFAMM > 32)
		{
			while (GLJGEKLFAMM != 0)
			{
				BPAJGOINFNL(0);
			}
		}
		while (GLJGEKLFAMM <= 32)
		{
			BPAJGOINFNL(0);
		}
		Array.Copy(array, 0, JNFCEBOLANF, 32, array.Length);
		MCODIKGMECH();
	}

	private byte[] OBGDIDNLAGA()
	{
		byte[] array = new byte[32];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (byte)((uint)OCIOLDBDBJN[i] & 0xFFu);
		}
		return array;
	}

	public int MNAIJEEKPCP()
	{
		return 64;
	}

	public MIPBJNJHNGA FDCFKGAEJFF()
	{
		return new BJCPOLAOIAB(this);
	}

	public void OMOKOKFNBKI(MIPBJNJHNGA CJHEIBNHNNE)
	{
		BJCPOLAOIAB bJCPOLAOIAB = (BJCPOLAOIAB)CJHEIBNHNNE;
		Array.Copy(bJCPOLAOIAB.LGOLHGMLNAM, 0, LGOLHGMLNAM, 0, LGOLHGMLNAM.Length);
		Array.Copy(bJCPOLAOIAB.JNFCEBOLANF, 0, JNFCEBOLANF, 0, JNFCEBOLANF.Length);
		GLJGEKLFAMM = bJCPOLAOIAB.GLJGEKLFAMM;
		Array.Copy(bJCPOLAOIAB.OCIOLDBDBJN, 0, OCIOLDBDBJN, 0, OCIOLDBDBJN.Length);
		Array.Copy(bJCPOLAOIAB.ABLHHNNDLCP, 0, ABLHHNNDLCP, 0, ABLHHNNDLCP.Length);
		Array.Copy(bJCPOLAOIAB.LAGKKAMIJON, 0, LAGKKAMIJON, 0, LAGKKAMIJON.Length);
		Array.Copy(bJCPOLAOIAB.ABPHAOMIBJB, 0, ABPHAOMIBJB, 0, ABPHAOMIBJB.Length);
		Array.Copy(bJCPOLAOIAB.OCLDEELPLFC, 0, OCLDEELPLFC, 0, OCLDEELPLFC.Length);
		Array.Copy(bJCPOLAOIAB.AHEAGFKDBHP, 0, AHEAGFKDBHP, 0, AHEAGFKDBHP.Length);
	}
}
