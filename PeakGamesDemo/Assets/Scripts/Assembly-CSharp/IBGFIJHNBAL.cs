using System;

public class IBGFIJHNBAL : JMPFLJGHAIM
{
	private static readonly byte[] CHEGBFGMICD = new byte[256]
	{
		217, 120, 249, 196, 25, 221, 181, 237, 40, 233,
		253, 121, 74, 160, 216, 157, 198, 126, 55, 131,
		43, 118, 83, 142, 98, 76, 100, 136, 68, 139,
		251, 162, 23, 154, 89, 245, 135, 179, 79, 19,
		97, 69, 109, 141, 9, 129, 125, 50, 189, 143,
		64, 235, 134, 183, 123, 11, 240, 149, 33, 34,
		92, 107, 78, 130, 84, 214, 101, 147, 206, 96,
		178, 28, 115, 86, 192, 20, 167, 140, 241, 220,
		18, 117, 202, 31, 59, 190, 228, 209, 66, 61,
		212, 48, 163, 60, 182, 38, 111, 191, 14, 218,
		70, 105, 7, 87, 39, 242, 29, 155, 188, 148,
		67, 3, 248, 17, 199, 246, 144, 239, 62, 231,
		6, 195, 213, 47, 200, 102, 30, 215, 8, 232,
		234, 222, 128, 82, 238, 247, 132, 170, 114, 172,
		53, 77, 106, 42, 150, 26, 210, 113, 90, 21,
		73, 116, 75, 159, 208, 94, 4, 24, 164, 236,
		194, 224, 65, 110, 15, 81, 203, 204, 36, 145,
		175, 80, 161, 244, 112, 57, 153, 124, 58, 133,
		35, 184, 180, 122, 252, 2, 54, 91, 37, 85,
		151, 49, 45, 93, 250, 152, 227, 138, 146, 174,
		5, 223, 41, 16, 103, 108, 186, 201, 211, 0,
		230, 207, 225, 158, 168, 44, 99, 22, 1, 63,
		88, 226, 137, 169, 13, 56, 52, 27, 171, 51,
		255, 176, 187, 72, 12, 95, 185, 177, 205, 46,
		197, 243, 219, 71, 229, 165, 156, 119, 10, 166,
		32, 104, 254, 127, 193, 173
	};

	private const int ANKLOALOPKP = 8;

	private int[] IOANFHFGPJK;

	private bool LFBBFLCMAHI;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return "RC2";
		}
	}

	public virtual bool ABNLKPDCGEF
	{
		get
		{
			return false;
		}
	}

	private int[] DNIOCLEEKMH(byte[] IKNCPEPOKGJ, int IODPDKHNDIE)
	{
		int[] array = new int[128];
		for (int i = 0; i != IKNCPEPOKGJ.Length; i++)
		{
			array[i] = IKNCPEPOKGJ[i] & 0xFF;
		}
		int num = IKNCPEPOKGJ.Length;
		int num3;
		if (num < 128)
		{
			int num2 = 0;
			num3 = array[num - 1];
			do
			{
				num3 = CHEGBFGMICD[(num3 + array[num2++]) & 0xFF] & 0xFF;
				array[num++] = num3;
			}
			while (num < 128);
		}
		num = IODPDKHNDIE + 7 >> 3;
		num3 = (array[128 - num] = CHEGBFGMICD[array[128 - num] & (255 >> (7 & -IODPDKHNDIE))] & 0xFF);
		for (int num4 = 128 - num - 1; num4 >= 0; num4--)
		{
			num3 = (array[num4] = CHEGBFGMICD[num3 ^ array[num4 + num]] & 0xFF);
		}
		int[] array2 = new int[64];
		for (int j = 0; j != array2.Length; j++)
		{
			array2[j] = array[2 * j] + (array[2 * j + 1] << 8);
		}
		return array2;
	}

	public virtual void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		LFBBFLCMAHI = MAEALKEJALK;
		if (IJJHBEECMBP is IMLEOOAPMMC)
		{
			IMLEOOAPMMC iMLEOOAPMMC = (IMLEOOAPMMC)IJJHBEECMBP;
			IOANFHFGPJK = DNIOCLEEKMH(iMLEOOAPMMC.MEGBFHFMBFI(), iMLEOOAPMMC.PMGBFMBJDJL);
			return;
		}
		if (IJJHBEECMBP is JEMNCGMEABF)
		{
			JEMNCGMEABF jEMNCGMEABF = (JEMNCGMEABF)IJJHBEECMBP;
			byte[] array = jEMNCGMEABF.MEGBFHFMBFI();
			IOANFHFGPJK = DNIOCLEEKMH(array, array.Length * 8);
			return;
		}
		throw new ArgumentException("invalid parameter passed to RC2 init - " + LHFGHNFJIKM.JKHOEKAOLPM(IJJHBEECMBP));
	}

	public virtual void OMOKOKFNBKI()
	{
	}

	public virtual int BDIGGHEPIIP()
	{
		return 8;
	}

	public virtual int DPACJDFHLKB(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		if (IOANFHFGPJK == null)
		{
			throw new InvalidOperationException("RC2 engine not initialised");
		}
		AJLDFGNHDCA.OONDALLFPOP(MOPCLEEGDFB, ELICNEDIBGB, 8, "input buffer too short");
		AJLDFGNHDCA.KLPNFGNKNKB(BILGCJNPJGJ, EMAKNGBIFDC, 8, "output buffer too short");
		if (LFBBFLCMAHI)
		{
			HDOLNBOHAJA(MOPCLEEGDFB, ELICNEDIBGB, BILGCJNPJGJ, EMAKNGBIFDC);
		}
		else
		{
			GFKALHGNIOJ(MOPCLEEGDFB, ELICNEDIBGB, BILGCJNPJGJ, EMAKNGBIFDC);
		}
		return 8;
	}

	private int CAHFCFEFPGJ(int AMFCENFNAJJ, int CNLILOEEBOJ)
	{
		AMFCENFNAJJ &= 0xFFFF;
		return (AMFCENFNAJJ << CNLILOEEBOJ) | (AMFCENFNAJJ >> 16 - CNLILOEEBOJ);
	}

	private void HDOLNBOHAJA(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		int num = ((MOPCLEEGDFB[ELICNEDIBGB + 7] & 0xFF) << 8) + (MOPCLEEGDFB[ELICNEDIBGB + 6] & 0xFF);
		int num2 = ((MOPCLEEGDFB[ELICNEDIBGB + 5] & 0xFF) << 8) + (MOPCLEEGDFB[ELICNEDIBGB + 4] & 0xFF);
		int num3 = ((MOPCLEEGDFB[ELICNEDIBGB + 3] & 0xFF) << 8) + (MOPCLEEGDFB[ELICNEDIBGB + 2] & 0xFF);
		int num4 = ((MOPCLEEGDFB[ELICNEDIBGB + 1] & 0xFF) << 8) + (MOPCLEEGDFB[ELICNEDIBGB] & 0xFF);
		for (int i = 0; i <= 16; i += 4)
		{
			num4 = CAHFCFEFPGJ(num4 + (num3 & ~num) + (num2 & num) + IOANFHFGPJK[i], 1);
			num3 = CAHFCFEFPGJ(num3 + (num2 & ~num4) + (num & num4) + IOANFHFGPJK[i + 1], 2);
			num2 = CAHFCFEFPGJ(num2 + (num & ~num3) + (num4 & num3) + IOANFHFGPJK[i + 2], 3);
			num = CAHFCFEFPGJ(num + (num4 & ~num2) + (num3 & num2) + IOANFHFGPJK[i + 3], 5);
		}
		num4 += IOANFHFGPJK[num & 0x3F];
		num3 += IOANFHFGPJK[num4 & 0x3F];
		num2 += IOANFHFGPJK[num3 & 0x3F];
		num += IOANFHFGPJK[num2 & 0x3F];
		for (int j = 20; j <= 40; j += 4)
		{
			num4 = CAHFCFEFPGJ(num4 + (num3 & ~num) + (num2 & num) + IOANFHFGPJK[j], 1);
			num3 = CAHFCFEFPGJ(num3 + (num2 & ~num4) + (num & num4) + IOANFHFGPJK[j + 1], 2);
			num2 = CAHFCFEFPGJ(num2 + (num & ~num3) + (num4 & num3) + IOANFHFGPJK[j + 2], 3);
			num = CAHFCFEFPGJ(num + (num4 & ~num2) + (num3 & num2) + IOANFHFGPJK[j + 3], 5);
		}
		num4 += IOANFHFGPJK[num & 0x3F];
		num3 += IOANFHFGPJK[num4 & 0x3F];
		num2 += IOANFHFGPJK[num3 & 0x3F];
		num += IOANFHFGPJK[num2 & 0x3F];
		for (int k = 44; k < 64; k += 4)
		{
			num4 = CAHFCFEFPGJ(num4 + (num3 & ~num) + (num2 & num) + IOANFHFGPJK[k], 1);
			num3 = CAHFCFEFPGJ(num3 + (num2 & ~num4) + (num & num4) + IOANFHFGPJK[k + 1], 2);
			num2 = CAHFCFEFPGJ(num2 + (num & ~num3) + (num4 & num3) + IOANFHFGPJK[k + 2], 3);
			num = CAHFCFEFPGJ(num + (num4 & ~num2) + (num3 & num2) + IOANFHFGPJK[k + 3], 5);
		}
		NGAGMIIBGKA[EMAKNGBIFDC] = (byte)num4;
		NGAGMIIBGKA[EMAKNGBIFDC + 1] = (byte)(num4 >> 8);
		NGAGMIIBGKA[EMAKNGBIFDC + 2] = (byte)num3;
		NGAGMIIBGKA[EMAKNGBIFDC + 3] = (byte)(num3 >> 8);
		NGAGMIIBGKA[EMAKNGBIFDC + 4] = (byte)num2;
		NGAGMIIBGKA[EMAKNGBIFDC + 5] = (byte)(num2 >> 8);
		NGAGMIIBGKA[EMAKNGBIFDC + 6] = (byte)num;
		NGAGMIIBGKA[EMAKNGBIFDC + 7] = (byte)(num >> 8);
	}

	private void GFKALHGNIOJ(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		int num = ((MOPCLEEGDFB[ELICNEDIBGB + 7] & 0xFF) << 8) + (MOPCLEEGDFB[ELICNEDIBGB + 6] & 0xFF);
		int num2 = ((MOPCLEEGDFB[ELICNEDIBGB + 5] & 0xFF) << 8) + (MOPCLEEGDFB[ELICNEDIBGB + 4] & 0xFF);
		int num3 = ((MOPCLEEGDFB[ELICNEDIBGB + 3] & 0xFF) << 8) + (MOPCLEEGDFB[ELICNEDIBGB + 2] & 0xFF);
		int num4 = ((MOPCLEEGDFB[ELICNEDIBGB + 1] & 0xFF) << 8) + (MOPCLEEGDFB[ELICNEDIBGB] & 0xFF);
		for (int num5 = 60; num5 >= 44; num5 -= 4)
		{
			num = CAHFCFEFPGJ(num, 11) - ((num4 & ~num2) + (num3 & num2) + IOANFHFGPJK[num5 + 3]);
			num2 = CAHFCFEFPGJ(num2, 13) - ((num & ~num3) + (num4 & num3) + IOANFHFGPJK[num5 + 2]);
			num3 = CAHFCFEFPGJ(num3, 14) - ((num2 & ~num4) + (num & num4) + IOANFHFGPJK[num5 + 1]);
			num4 = CAHFCFEFPGJ(num4, 15) - ((num3 & ~num) + (num2 & num) + IOANFHFGPJK[num5]);
		}
		num -= IOANFHFGPJK[num2 & 0x3F];
		num2 -= IOANFHFGPJK[num3 & 0x3F];
		num3 -= IOANFHFGPJK[num4 & 0x3F];
		num4 -= IOANFHFGPJK[num & 0x3F];
		for (int num6 = 40; num6 >= 20; num6 -= 4)
		{
			num = CAHFCFEFPGJ(num, 11) - ((num4 & ~num2) + (num3 & num2) + IOANFHFGPJK[num6 + 3]);
			num2 = CAHFCFEFPGJ(num2, 13) - ((num & ~num3) + (num4 & num3) + IOANFHFGPJK[num6 + 2]);
			num3 = CAHFCFEFPGJ(num3, 14) - ((num2 & ~num4) + (num & num4) + IOANFHFGPJK[num6 + 1]);
			num4 = CAHFCFEFPGJ(num4, 15) - ((num3 & ~num) + (num2 & num) + IOANFHFGPJK[num6]);
		}
		num -= IOANFHFGPJK[num2 & 0x3F];
		num2 -= IOANFHFGPJK[num3 & 0x3F];
		num3 -= IOANFHFGPJK[num4 & 0x3F];
		num4 -= IOANFHFGPJK[num & 0x3F];
		for (int num7 = 16; num7 >= 0; num7 -= 4)
		{
			num = CAHFCFEFPGJ(num, 11) - ((num4 & ~num2) + (num3 & num2) + IOANFHFGPJK[num7 + 3]);
			num2 = CAHFCFEFPGJ(num2, 13) - ((num & ~num3) + (num4 & num3) + IOANFHFGPJK[num7 + 2]);
			num3 = CAHFCFEFPGJ(num3, 14) - ((num2 & ~num4) + (num & num4) + IOANFHFGPJK[num7 + 1]);
			num4 = CAHFCFEFPGJ(num4, 15) - ((num3 & ~num) + (num2 & num) + IOANFHFGPJK[num7]);
		}
		NGAGMIIBGKA[EMAKNGBIFDC] = (byte)num4;
		NGAGMIIBGKA[EMAKNGBIFDC + 1] = (byte)(num4 >> 8);
		NGAGMIIBGKA[EMAKNGBIFDC + 2] = (byte)num3;
		NGAGMIIBGKA[EMAKNGBIFDC + 3] = (byte)(num3 >> 8);
		NGAGMIIBGKA[EMAKNGBIFDC + 4] = (byte)num2;
		NGAGMIIBGKA[EMAKNGBIFDC + 5] = (byte)(num2 >> 8);
		NGAGMIIBGKA[EMAKNGBIFDC + 6] = (byte)num;
		NGAGMIIBGKA[EMAKNGBIFDC + 7] = (byte)(num >> 8);
	}
}
