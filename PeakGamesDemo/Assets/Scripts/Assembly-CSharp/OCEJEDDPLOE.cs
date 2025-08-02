using System;

public class OCEJEDDPLOE : JMPFLJGHAIM
{
	private const int ANKLOALOPKP = 8;

	private static readonly short[] GNPHFPDIFKG = new short[256]
	{
		163, 215, 9, 131, 248, 72, 246, 244, 179, 33,
		21, 120, 153, 177, 175, 249, 231, 45, 77, 138,
		206, 76, 202, 46, 82, 149, 217, 30, 78, 56,
		68, 40, 10, 223, 2, 160, 23, 241, 96, 104,
		18, 183, 122, 195, 233, 250, 61, 83, 150, 132,
		107, 186, 242, 99, 154, 25, 124, 174, 229, 245,
		247, 22, 106, 162, 57, 182, 123, 15, 193, 147,
		129, 27, 238, 180, 26, 234, 208, 145, 47, 184,
		85, 185, 218, 133, 63, 65, 191, 224, 90, 88,
		128, 95, 102, 11, 216, 144, 53, 213, 192, 167,
		51, 6, 101, 105, 69, 0, 148, 86, 109, 152,
		155, 118, 151, 252, 178, 194, 176, 254, 219, 32,
		225, 235, 214, 228, 221, 71, 74, 29, 66, 237,
		158, 110, 73, 60, 205, 67, 39, 210, 7, 212,
		222, 199, 103, 24, 137, 203, 48, 31, 141, 198,
		143, 170, 200, 116, 220, 201, 93, 92, 49, 164,
		112, 136, 97, 44, 159, 13, 43, 135, 80, 130,
		84, 100, 38, 125, 3, 64, 52, 75, 28, 115,
		209, 196, 253, 59, 204, 251, 127, 171, 230, 62,
		91, 165, 173, 4, 35, 156, 20, 81, 34, 240,
		41, 121, 113, 126, 255, 140, 14, 226, 12, 239,
		188, 114, 117, 111, 55, 161, 236, 211, 142, 98,
		139, 134, 16, 232, 8, 119, 17, 190, 146, 79,
		36, 197, 50, 54, 157, 207, 243, 166, 187, 172,
		94, 108, 169, 19, 87, 37, 181, 227, 189, 168,
		58, 1, 5, 89, 42, 70
	};

	private int[] PNGALPMEDIO;

	private int[] KBPEMMEJBNE;

	private int[] MDKCLIAAAPJ;

	private int[] JJICKLOLLJH;

	private bool LFBBFLCMAHI;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return "SKIPJACK";
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
			throw new ArgumentException("invalid parameter passed to SKIPJACK init - " + LHFGHNFJIKM.JKHOEKAOLPM(IJJHBEECMBP));
		}
		byte[] array = ((JEMNCGMEABF)IJJHBEECMBP).MEGBFHFMBFI();
		LFBBFLCMAHI = MAEALKEJALK;
		PNGALPMEDIO = new int[32];
		KBPEMMEJBNE = new int[32];
		MDKCLIAAAPJ = new int[32];
		JJICKLOLLJH = new int[32];
		for (int i = 0; i < 32; i++)
		{
			PNGALPMEDIO[i] = array[i * 4 % 10] & 0xFF;
			KBPEMMEJBNE[i] = array[(i * 4 + 1) % 10] & 0xFF;
			MDKCLIAAAPJ[i] = array[(i * 4 + 2) % 10] & 0xFF;
			JJICKLOLLJH[i] = array[(i * 4 + 3) % 10] & 0xFF;
		}
	}

	public virtual int BDIGGHEPIIP()
	{
		return 8;
	}

	public virtual int DPACJDFHLKB(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		if (KBPEMMEJBNE == null)
		{
			throw new InvalidOperationException("SKIPJACK engine not initialised");
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

	public virtual void OMOKOKFNBKI()
	{
	}

	private int HBGOKILMBJG(int BENKLGPHLGI, int PHFLBLJJMLI)
	{
		int num = (PHFLBLJJMLI >> 8) & 0xFF;
		int num2 = PHFLBLJJMLI & 0xFF;
		int num3 = GNPHFPDIFKG[num2 ^ PNGALPMEDIO[BENKLGPHLGI]] ^ num;
		int num4 = GNPHFPDIFKG[num3 ^ KBPEMMEJBNE[BENKLGPHLGI]] ^ num2;
		int num5 = GNPHFPDIFKG[num4 ^ MDKCLIAAAPJ[BENKLGPHLGI]] ^ num3;
		int num6 = GNPHFPDIFKG[num5 ^ JJICKLOLLJH[BENKLGPHLGI]] ^ num4;
		return (num5 << 8) + num6;
	}

	public virtual int HDOLNBOHAJA(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		int num = (MOPCLEEGDFB[ELICNEDIBGB] << 8) + (MOPCLEEGDFB[ELICNEDIBGB + 1] & 0xFF);
		int num2 = (MOPCLEEGDFB[ELICNEDIBGB + 2] << 8) + (MOPCLEEGDFB[ELICNEDIBGB + 3] & 0xFF);
		int num3 = (MOPCLEEGDFB[ELICNEDIBGB + 4] << 8) + (MOPCLEEGDFB[ELICNEDIBGB + 5] & 0xFF);
		int num4 = (MOPCLEEGDFB[ELICNEDIBGB + 6] << 8) + (MOPCLEEGDFB[ELICNEDIBGB + 7] & 0xFF);
		int num5 = 0;
		for (int i = 0; i < 2; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				int num6 = num4;
				num4 = num3;
				num3 = num2;
				num2 = HBGOKILMBJG(num5, num);
				num = num2 ^ num6 ^ (num5 + 1);
				num5++;
			}
			for (int k = 0; k < 8; k++)
			{
				int num7 = num4;
				num4 = num3;
				num3 = num ^ num2 ^ (num5 + 1);
				num2 = HBGOKILMBJG(num5, num);
				num = num7;
				num5++;
			}
		}
		NGAGMIIBGKA[EMAKNGBIFDC] = (byte)(num >> 8);
		NGAGMIIBGKA[EMAKNGBIFDC + 1] = (byte)num;
		NGAGMIIBGKA[EMAKNGBIFDC + 2] = (byte)(num2 >> 8);
		NGAGMIIBGKA[EMAKNGBIFDC + 3] = (byte)num2;
		NGAGMIIBGKA[EMAKNGBIFDC + 4] = (byte)(num3 >> 8);
		NGAGMIIBGKA[EMAKNGBIFDC + 5] = (byte)num3;
		NGAGMIIBGKA[EMAKNGBIFDC + 6] = (byte)(num4 >> 8);
		NGAGMIIBGKA[EMAKNGBIFDC + 7] = (byte)num4;
		return 8;
	}

	private int JGOHMOHEFMJ(int BENKLGPHLGI, int PHFLBLJJMLI)
	{
		int num = PHFLBLJJMLI & 0xFF;
		int num2 = (PHFLBLJJMLI >> 8) & 0xFF;
		int num3 = GNPHFPDIFKG[num2 ^ JJICKLOLLJH[BENKLGPHLGI]] ^ num;
		int num4 = GNPHFPDIFKG[num3 ^ MDKCLIAAAPJ[BENKLGPHLGI]] ^ num2;
		int num5 = GNPHFPDIFKG[num4 ^ KBPEMMEJBNE[BENKLGPHLGI]] ^ num3;
		int num6 = GNPHFPDIFKG[num5 ^ PNGALPMEDIO[BENKLGPHLGI]] ^ num4;
		return (num6 << 8) + num5;
	}

	public virtual int GFKALHGNIOJ(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		int num = (MOPCLEEGDFB[ELICNEDIBGB] << 8) + (MOPCLEEGDFB[ELICNEDIBGB + 1] & 0xFF);
		int num2 = (MOPCLEEGDFB[ELICNEDIBGB + 2] << 8) + (MOPCLEEGDFB[ELICNEDIBGB + 3] & 0xFF);
		int num3 = (MOPCLEEGDFB[ELICNEDIBGB + 4] << 8) + (MOPCLEEGDFB[ELICNEDIBGB + 5] & 0xFF);
		int num4 = (MOPCLEEGDFB[ELICNEDIBGB + 6] << 8) + (MOPCLEEGDFB[ELICNEDIBGB + 7] & 0xFF);
		int num5 = 31;
		for (int i = 0; i < 2; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				int num6 = num3;
				num3 = num4;
				num4 = num;
				num = JGOHMOHEFMJ(num5, num2);
				num2 = num ^ num6 ^ (num5 + 1);
				num5--;
			}
			for (int k = 0; k < 8; k++)
			{
				int num7 = num3;
				num3 = num4;
				num4 = num2 ^ num ^ (num5 + 1);
				num = JGOHMOHEFMJ(num5, num2);
				num2 = num7;
				num5--;
			}
		}
		NGAGMIIBGKA[EMAKNGBIFDC] = (byte)(num >> 8);
		NGAGMIIBGKA[EMAKNGBIFDC + 1] = (byte)num;
		NGAGMIIBGKA[EMAKNGBIFDC + 2] = (byte)(num2 >> 8);
		NGAGMIIBGKA[EMAKNGBIFDC + 3] = (byte)num2;
		NGAGMIIBGKA[EMAKNGBIFDC + 4] = (byte)(num3 >> 8);
		NGAGMIIBGKA[EMAKNGBIFDC + 5] = (byte)num3;
		NGAGMIIBGKA[EMAKNGBIFDC + 6] = (byte)(num4 >> 8);
		NGAGMIIBGKA[EMAKNGBIFDC + 7] = (byte)num4;
		return 8;
	}
}
