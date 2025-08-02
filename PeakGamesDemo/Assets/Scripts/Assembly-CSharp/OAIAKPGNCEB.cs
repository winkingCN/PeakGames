using System;

internal sealed class OAIAKPGNCEB
{
	private static readonly int[] OKODOAEILFA = new int[17]
	{
		0, 1, 3, 7, 15, 31, 63, 127, 255, 511,
		1023, 2047, 4095, 8191, 16383, 32767, 65535
	};

	private const int KKHDFMOFKNE = 0;

	private const int BECBHHLALAH = 1;

	private const int IFCBECJBKOD = 2;

	private const int FGFKAJJPPMK = -1;

	private const int DLMDNANOOJF = -2;

	private const int FMAKHMNJPBM = -3;

	private const int BHLHAIENNIN = -4;

	private const int EFNAHKCFCME = -5;

	private const int IPPHHEKPNPC = -6;

	private const int MAGIPBMEKHC = 0;

	private const int MOLJEDFIFLA = 1;

	private const int NMKLCCGBANI = 2;

	private const int HIFEFNIEHFI = 3;

	private const int GAFPFKJEIBN = 4;

	private const int AICHJCLBBGL = 5;

	private const int MFOBJKIODDF = 6;

	private const int HIKJJACAENC = 7;

	private const int IGNHPFAEAGD = 8;

	private const int BILDDAGKDCF = 9;

	private int LJCPOAOKFOE;

	private int NBEDPKHALCN;

	private int[] ACNCGKPOKIC;

	private int IIDHEODOIHD;

	private int CDGFDLPJJFG;

	private int GGCHBCEDHEL;

	private int CIPBKJMDBLK;

	private int INPALLMGBMF;

	private byte GKNKEDANFHE;

	private byte JLMAIMHELLF;

	private int[] JEPLFJDALAD;

	private int MPHBPKBLCPM;

	private int[] OPHFHHJKNDL;

	private int KDMGDHOGPHI;

	internal OAIAKPGNCEB()
	{
	}

	internal void BNOMLEDAFJI(int MCDADHPKAPD, int LBEHEOEKADL, int[] ALBJIKEFGNL, int CBCPCACBJPH, int[] EFGJEOFOHGP, int NAEIIBBFAHP, NNHGBFFHNMG IGNEOOOFEMO)
	{
		LJCPOAOKFOE = 0;
		GKNKEDANFHE = (byte)MCDADHPKAPD;
		JLMAIMHELLF = (byte)LBEHEOEKADL;
		JEPLFJDALAD = ALBJIKEFGNL;
		MPHBPKBLCPM = CBCPCACBJPH;
		OPHFHHJKNDL = EFGJEOFOHGP;
		KDMGDHOGPHI = NAEIIBBFAHP;
		ACNCGKPOKIC = null;
	}

	internal int NEGIBIGJEKE(JMDKLJDMAPK IBBBMACIBGK, NNHGBFFHNMG IGNEOOOFEMO, int GPGDCCMECGF)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		num3 = IGNEOOOFEMO.HBCHEGLPAIJ;
		int num4 = IGNEOOOFEMO.HCNAGHNCFLL;
		num = IBBBMACIBGK.DCLKKOJJELJ;
		num2 = IBBBMACIBGK.GCNDOBHMGOP;
		int num5 = IBBBMACIBGK.CALCGCAOAKI;
		int num6 = ((num5 >= IBBBMACIBGK.ABGLICODIMA) ? (IBBBMACIBGK.AHPGGJALELA - num5) : (IBBBMACIBGK.ABGLICODIMA - num5 - 1));
		while (true)
		{
			switch (LJCPOAOKFOE)
			{
			case 0:
				if (num6 >= 258 && num4 >= 10)
				{
					IBBBMACIBGK.DCLKKOJJELJ = num;
					IBBBMACIBGK.GCNDOBHMGOP = num2;
					IGNEOOOFEMO.HCNAGHNCFLL = num4;
					IGNEOOOFEMO.IOKPEPLADED += num3 - IGNEOOOFEMO.HBCHEGLPAIJ;
					IGNEOOOFEMO.HBCHEGLPAIJ = num3;
					IBBBMACIBGK.CALCGCAOAKI = num5;
					GPGDCCMECGF = DFPMMJKPMCE(GKNKEDANFHE, JLMAIMHELLF, JEPLFJDALAD, MPHBPKBLCPM, OPHFHHJKNDL, KDMGDHOGPHI, IBBBMACIBGK, IGNEOOOFEMO);
					num3 = IGNEOOOFEMO.HBCHEGLPAIJ;
					num4 = IGNEOOOFEMO.HCNAGHNCFLL;
					num = IBBBMACIBGK.DCLKKOJJELJ;
					num2 = IBBBMACIBGK.GCNDOBHMGOP;
					num5 = IBBBMACIBGK.CALCGCAOAKI;
					num6 = ((num5 >= IBBBMACIBGK.ABGLICODIMA) ? (IBBBMACIBGK.AHPGGJALELA - num5) : (IBBBMACIBGK.ABGLICODIMA - num5 - 1));
					if (GPGDCCMECGF != 0)
					{
						LJCPOAOKFOE = ((GPGDCCMECGF != 1) ? 9 : 7);
						break;
					}
				}
				CDGFDLPJJFG = GKNKEDANFHE;
				ACNCGKPOKIC = JEPLFJDALAD;
				IIDHEODOIHD = MPHBPKBLCPM;
				LJCPOAOKFOE = 1;
				goto case 1;
			case 1:
			{
				int cIPBKJMDBLK;
				for (cIPBKJMDBLK = CDGFDLPJJFG; num2 < cIPBKJMDBLK; num2 += 8)
				{
					if (num4 != 0)
					{
						GPGDCCMECGF = 0;
						num4--;
						num |= (IGNEOOOFEMO.BLJFIEBCEPL[num3++] & 0xFF) << num2;
						continue;
					}
					IBBBMACIBGK.DCLKKOJJELJ = num;
					IBBBMACIBGK.GCNDOBHMGOP = num2;
					IGNEOOOFEMO.HCNAGHNCFLL = num4;
					IGNEOOOFEMO.IOKPEPLADED += num3 - IGNEOOOFEMO.HBCHEGLPAIJ;
					IGNEOOOFEMO.HBCHEGLPAIJ = num3;
					IBBBMACIBGK.CALCGCAOAKI = num5;
					return IBBBMACIBGK.BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
				}
				int num7 = (IIDHEODOIHD + (num & OKODOAEILFA[cIPBKJMDBLK])) * 3;
				num >>= ACNCGKPOKIC[num7 + 1];
				num2 -= ACNCGKPOKIC[num7 + 1];
				int num8 = ACNCGKPOKIC[num7];
				if (num8 == 0)
				{
					GGCHBCEDHEL = ACNCGKPOKIC[num7 + 2];
					LJCPOAOKFOE = 6;
					break;
				}
				if (((uint)num8 & 0x10u) != 0)
				{
					CIPBKJMDBLK = num8 & 0xF;
					NBEDPKHALCN = ACNCGKPOKIC[num7 + 2];
					LJCPOAOKFOE = 2;
					break;
				}
				if ((num8 & 0x40) == 0)
				{
					CDGFDLPJJFG = num8;
					IIDHEODOIHD = num7 / 3 + ACNCGKPOKIC[num7 + 2];
					break;
				}
				if (((uint)num8 & 0x20u) != 0)
				{
					LJCPOAOKFOE = 7;
					break;
				}
				LJCPOAOKFOE = 9;
				IGNEOOOFEMO.NOIOHIPHFHA = "invalid literal/length code";
				GPGDCCMECGF = -3;
				IBBBMACIBGK.DCLKKOJJELJ = num;
				IBBBMACIBGK.GCNDOBHMGOP = num2;
				IGNEOOOFEMO.HCNAGHNCFLL = num4;
				IGNEOOOFEMO.IOKPEPLADED += num3 - IGNEOOOFEMO.HBCHEGLPAIJ;
				IGNEOOOFEMO.HBCHEGLPAIJ = num3;
				IBBBMACIBGK.CALCGCAOAKI = num5;
				return IBBBMACIBGK.BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
			}
			case 2:
			{
				int cIPBKJMDBLK;
				for (cIPBKJMDBLK = CIPBKJMDBLK; num2 < cIPBKJMDBLK; num2 += 8)
				{
					if (num4 != 0)
					{
						GPGDCCMECGF = 0;
						num4--;
						num |= (IGNEOOOFEMO.BLJFIEBCEPL[num3++] & 0xFF) << num2;
						continue;
					}
					IBBBMACIBGK.DCLKKOJJELJ = num;
					IBBBMACIBGK.GCNDOBHMGOP = num2;
					IGNEOOOFEMO.HCNAGHNCFLL = num4;
					IGNEOOOFEMO.IOKPEPLADED += num3 - IGNEOOOFEMO.HBCHEGLPAIJ;
					IGNEOOOFEMO.HBCHEGLPAIJ = num3;
					IBBBMACIBGK.CALCGCAOAKI = num5;
					return IBBBMACIBGK.BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
				}
				NBEDPKHALCN += num & OKODOAEILFA[cIPBKJMDBLK];
				num >>= cIPBKJMDBLK;
				num2 -= cIPBKJMDBLK;
				CDGFDLPJJFG = JLMAIMHELLF;
				ACNCGKPOKIC = OPHFHHJKNDL;
				IIDHEODOIHD = KDMGDHOGPHI;
				LJCPOAOKFOE = 3;
				goto case 3;
			}
			case 3:
			{
				int cIPBKJMDBLK;
				for (cIPBKJMDBLK = CDGFDLPJJFG; num2 < cIPBKJMDBLK; num2 += 8)
				{
					if (num4 != 0)
					{
						GPGDCCMECGF = 0;
						num4--;
						num |= (IGNEOOOFEMO.BLJFIEBCEPL[num3++] & 0xFF) << num2;
						continue;
					}
					IBBBMACIBGK.DCLKKOJJELJ = num;
					IBBBMACIBGK.GCNDOBHMGOP = num2;
					IGNEOOOFEMO.HCNAGHNCFLL = num4;
					IGNEOOOFEMO.IOKPEPLADED += num3 - IGNEOOOFEMO.HBCHEGLPAIJ;
					IGNEOOOFEMO.HBCHEGLPAIJ = num3;
					IBBBMACIBGK.CALCGCAOAKI = num5;
					return IBBBMACIBGK.BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
				}
				int num7 = (IIDHEODOIHD + (num & OKODOAEILFA[cIPBKJMDBLK])) * 3;
				num >>= ACNCGKPOKIC[num7 + 1];
				num2 -= ACNCGKPOKIC[num7 + 1];
				int num8 = ACNCGKPOKIC[num7];
				if (((uint)num8 & 0x10u) != 0)
				{
					CIPBKJMDBLK = num8 & 0xF;
					INPALLMGBMF = ACNCGKPOKIC[num7 + 2];
					LJCPOAOKFOE = 4;
					break;
				}
				if ((num8 & 0x40) == 0)
				{
					CDGFDLPJJFG = num8;
					IIDHEODOIHD = num7 / 3 + ACNCGKPOKIC[num7 + 2];
					break;
				}
				LJCPOAOKFOE = 9;
				IGNEOOOFEMO.NOIOHIPHFHA = "invalid distance code";
				GPGDCCMECGF = -3;
				IBBBMACIBGK.DCLKKOJJELJ = num;
				IBBBMACIBGK.GCNDOBHMGOP = num2;
				IGNEOOOFEMO.HCNAGHNCFLL = num4;
				IGNEOOOFEMO.IOKPEPLADED += num3 - IGNEOOOFEMO.HBCHEGLPAIJ;
				IGNEOOOFEMO.HBCHEGLPAIJ = num3;
				IBBBMACIBGK.CALCGCAOAKI = num5;
				return IBBBMACIBGK.BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
			}
			case 4:
			{
				int cIPBKJMDBLK;
				for (cIPBKJMDBLK = CIPBKJMDBLK; num2 < cIPBKJMDBLK; num2 += 8)
				{
					if (num4 != 0)
					{
						GPGDCCMECGF = 0;
						num4--;
						num |= (IGNEOOOFEMO.BLJFIEBCEPL[num3++] & 0xFF) << num2;
						continue;
					}
					IBBBMACIBGK.DCLKKOJJELJ = num;
					IBBBMACIBGK.GCNDOBHMGOP = num2;
					IGNEOOOFEMO.HCNAGHNCFLL = num4;
					IGNEOOOFEMO.IOKPEPLADED += num3 - IGNEOOOFEMO.HBCHEGLPAIJ;
					IGNEOOOFEMO.HBCHEGLPAIJ = num3;
					IBBBMACIBGK.CALCGCAOAKI = num5;
					return IBBBMACIBGK.BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
				}
				INPALLMGBMF += num & OKODOAEILFA[cIPBKJMDBLK];
				num >>= cIPBKJMDBLK;
				num2 -= cIPBKJMDBLK;
				LJCPOAOKFOE = 5;
				goto case 5;
			}
			case 5:
			{
				int i;
				for (i = num5 - INPALLMGBMF; i < 0; i += IBBBMACIBGK.AHPGGJALELA)
				{
				}
				while (NBEDPKHALCN != 0)
				{
					if (num6 == 0)
					{
						if (num5 == IBBBMACIBGK.AHPGGJALELA && IBBBMACIBGK.ABGLICODIMA != 0)
						{
							num5 = 0;
							num6 = ((num5 >= IBBBMACIBGK.ABGLICODIMA) ? (IBBBMACIBGK.AHPGGJALELA - num5) : (IBBBMACIBGK.ABGLICODIMA - num5 - 1));
						}
						if (num6 == 0)
						{
							IBBBMACIBGK.CALCGCAOAKI = num5;
							GPGDCCMECGF = IBBBMACIBGK.BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
							num5 = IBBBMACIBGK.CALCGCAOAKI;
							num6 = ((num5 >= IBBBMACIBGK.ABGLICODIMA) ? (IBBBMACIBGK.AHPGGJALELA - num5) : (IBBBMACIBGK.ABGLICODIMA - num5 - 1));
							if (num5 == IBBBMACIBGK.AHPGGJALELA && IBBBMACIBGK.ABGLICODIMA != 0)
							{
								num5 = 0;
								num6 = ((num5 >= IBBBMACIBGK.ABGLICODIMA) ? (IBBBMACIBGK.AHPGGJALELA - num5) : (IBBBMACIBGK.ABGLICODIMA - num5 - 1));
							}
							if (num6 == 0)
							{
								IBBBMACIBGK.DCLKKOJJELJ = num;
								IBBBMACIBGK.GCNDOBHMGOP = num2;
								IGNEOOOFEMO.HCNAGHNCFLL = num4;
								IGNEOOOFEMO.IOKPEPLADED += num3 - IGNEOOOFEMO.HBCHEGLPAIJ;
								IGNEOOOFEMO.HBCHEGLPAIJ = num3;
								IBBBMACIBGK.CALCGCAOAKI = num5;
								return IBBBMACIBGK.BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
							}
						}
					}
					IBBBMACIBGK.IMHIHJLIEBK[num5++] = IBBBMACIBGK.IMHIHJLIEBK[i++];
					num6--;
					if (i == IBBBMACIBGK.AHPGGJALELA)
					{
						i = 0;
					}
					NBEDPKHALCN--;
				}
				LJCPOAOKFOE = 0;
				break;
			}
			case 6:
				if (num6 == 0)
				{
					if (num5 == IBBBMACIBGK.AHPGGJALELA && IBBBMACIBGK.ABGLICODIMA != 0)
					{
						num5 = 0;
						num6 = ((num5 >= IBBBMACIBGK.ABGLICODIMA) ? (IBBBMACIBGK.AHPGGJALELA - num5) : (IBBBMACIBGK.ABGLICODIMA - num5 - 1));
					}
					if (num6 == 0)
					{
						IBBBMACIBGK.CALCGCAOAKI = num5;
						GPGDCCMECGF = IBBBMACIBGK.BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
						num5 = IBBBMACIBGK.CALCGCAOAKI;
						num6 = ((num5 >= IBBBMACIBGK.ABGLICODIMA) ? (IBBBMACIBGK.AHPGGJALELA - num5) : (IBBBMACIBGK.ABGLICODIMA - num5 - 1));
						if (num5 == IBBBMACIBGK.AHPGGJALELA && IBBBMACIBGK.ABGLICODIMA != 0)
						{
							num5 = 0;
							num6 = ((num5 >= IBBBMACIBGK.ABGLICODIMA) ? (IBBBMACIBGK.AHPGGJALELA - num5) : (IBBBMACIBGK.ABGLICODIMA - num5 - 1));
						}
						if (num6 == 0)
						{
							IBBBMACIBGK.DCLKKOJJELJ = num;
							IBBBMACIBGK.GCNDOBHMGOP = num2;
							IGNEOOOFEMO.HCNAGHNCFLL = num4;
							IGNEOOOFEMO.IOKPEPLADED += num3 - IGNEOOOFEMO.HBCHEGLPAIJ;
							IGNEOOOFEMO.HBCHEGLPAIJ = num3;
							IBBBMACIBGK.CALCGCAOAKI = num5;
							return IBBBMACIBGK.BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
						}
					}
				}
				GPGDCCMECGF = 0;
				IBBBMACIBGK.IMHIHJLIEBK[num5++] = (byte)GGCHBCEDHEL;
				num6--;
				LJCPOAOKFOE = 0;
				break;
			case 7:
				if (num2 > 7)
				{
					num2 -= 8;
					num4++;
					num3--;
				}
				IBBBMACIBGK.CALCGCAOAKI = num5;
				GPGDCCMECGF = IBBBMACIBGK.BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
				num5 = IBBBMACIBGK.CALCGCAOAKI;
				num6 = ((num5 >= IBBBMACIBGK.ABGLICODIMA) ? (IBBBMACIBGK.AHPGGJALELA - num5) : (IBBBMACIBGK.ABGLICODIMA - num5 - 1));
				if (IBBBMACIBGK.ABGLICODIMA != IBBBMACIBGK.CALCGCAOAKI)
				{
					IBBBMACIBGK.DCLKKOJJELJ = num;
					IBBBMACIBGK.GCNDOBHMGOP = num2;
					IGNEOOOFEMO.HCNAGHNCFLL = num4;
					IGNEOOOFEMO.IOKPEPLADED += num3 - IGNEOOOFEMO.HBCHEGLPAIJ;
					IGNEOOOFEMO.HBCHEGLPAIJ = num3;
					IBBBMACIBGK.CALCGCAOAKI = num5;
					return IBBBMACIBGK.BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
				}
				LJCPOAOKFOE = 8;
				goto case 8;
			case 8:
				GPGDCCMECGF = 1;
				IBBBMACIBGK.DCLKKOJJELJ = num;
				IBBBMACIBGK.GCNDOBHMGOP = num2;
				IGNEOOOFEMO.HCNAGHNCFLL = num4;
				IGNEOOOFEMO.IOKPEPLADED += num3 - IGNEOOOFEMO.HBCHEGLPAIJ;
				IGNEOOOFEMO.HBCHEGLPAIJ = num3;
				IBBBMACIBGK.CALCGCAOAKI = num5;
				return IBBBMACIBGK.BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
			case 9:
				GPGDCCMECGF = -3;
				IBBBMACIBGK.DCLKKOJJELJ = num;
				IBBBMACIBGK.GCNDOBHMGOP = num2;
				IGNEOOOFEMO.HCNAGHNCFLL = num4;
				IGNEOOOFEMO.IOKPEPLADED += num3 - IGNEOOOFEMO.HBCHEGLPAIJ;
				IGNEOOOFEMO.HBCHEGLPAIJ = num3;
				IBBBMACIBGK.CALCGCAOAKI = num5;
				return IBBBMACIBGK.BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
			default:
				GPGDCCMECGF = -2;
				IBBBMACIBGK.DCLKKOJJELJ = num;
				IBBBMACIBGK.GCNDOBHMGOP = num2;
				IGNEOOOFEMO.HCNAGHNCFLL = num4;
				IGNEOOOFEMO.IOKPEPLADED += num3 - IGNEOOOFEMO.HBCHEGLPAIJ;
				IGNEOOOFEMO.HBCHEGLPAIJ = num3;
				IBBBMACIBGK.CALCGCAOAKI = num5;
				return IBBBMACIBGK.BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
			}
		}
	}

	internal void KNLOBIILDMP(NNHGBFFHNMG IGNEOOOFEMO)
	{
	}

	internal int DFPMMJKPMCE(int MCDADHPKAPD, int LBEHEOEKADL, int[] ALBJIKEFGNL, int CBCPCACBJPH, int[] EFGJEOFOHGP, int NAEIIBBFAHP, JMDKLJDMAPK IBBBMACIBGK, NNHGBFFHNMG IGNEOOOFEMO)
	{
		int hBCHEGLPAIJ = IGNEOOOFEMO.HBCHEGLPAIJ;
		int num = IGNEOOOFEMO.HCNAGHNCFLL;
		int num2 = IBBBMACIBGK.DCLKKOJJELJ;
		int num3 = IBBBMACIBGK.GCNDOBHMGOP;
		int num4 = IBBBMACIBGK.CALCGCAOAKI;
		int num5 = ((num4 >= IBBBMACIBGK.ABGLICODIMA) ? (IBBBMACIBGK.AHPGGJALELA - num4) : (IBBBMACIBGK.ABGLICODIMA - num4 - 1));
		int num6 = OKODOAEILFA[MCDADHPKAPD];
		int num7 = OKODOAEILFA[LBEHEOEKADL];
		int num12;
		while (true)
		{
			if (num3 < 20)
			{
				num--;
				num2 |= (IGNEOOOFEMO.BLJFIEBCEPL[hBCHEGLPAIJ++] & 0xFF) << num3;
				num3 += 8;
				continue;
			}
			int num8 = num2 & num6;
			int[] array = ALBJIKEFGNL;
			int num9 = CBCPCACBJPH;
			int num10 = (num9 + num8) * 3;
			int num11;
			if ((num11 = array[num10]) == 0)
			{
				num2 >>= array[num10 + 1];
				num3 -= array[num10 + 1];
				IBBBMACIBGK.IMHIHJLIEBK[num4++] = (byte)array[num10 + 2];
				num5--;
			}
			else
			{
				while (true)
				{
					num2 >>= array[num10 + 1];
					num3 -= array[num10 + 1];
					if (((uint)num11 & 0x10u) != 0)
					{
						num11 &= 0xF;
						num12 = array[num10 + 2] + (num2 & OKODOAEILFA[num11]);
						num2 >>= num11;
						for (num3 -= num11; num3 < 15; num3 += 8)
						{
							num--;
							num2 |= (IGNEOOOFEMO.BLJFIEBCEPL[hBCHEGLPAIJ++] & 0xFF) << num3;
						}
						num8 = num2 & num7;
						array = EFGJEOFOHGP;
						num9 = NAEIIBBFAHP;
						num10 = (num9 + num8) * 3;
						num11 = array[num10];
						while (true)
						{
							num2 >>= array[num10 + 1];
							num3 -= array[num10 + 1];
							if (((uint)num11 & 0x10u) != 0)
							{
								break;
							}
							if ((num11 & 0x40) == 0)
							{
								num8 += array[num10 + 2];
								num8 += num2 & OKODOAEILFA[num11];
								num10 = (num9 + num8) * 3;
								num11 = array[num10];
								continue;
							}
							IGNEOOOFEMO.NOIOHIPHFHA = "invalid distance code";
							num12 = IGNEOOOFEMO.HCNAGHNCFLL - num;
							num12 = ((num3 >> 3 >= num12) ? num12 : (num3 >> 3));
							num += num12;
							hBCHEGLPAIJ -= num12;
							num3 -= num12 << 3;
							IBBBMACIBGK.DCLKKOJJELJ = num2;
							IBBBMACIBGK.GCNDOBHMGOP = num3;
							IGNEOOOFEMO.HCNAGHNCFLL = num;
							IGNEOOOFEMO.IOKPEPLADED += hBCHEGLPAIJ - IGNEOOOFEMO.HBCHEGLPAIJ;
							IGNEOOOFEMO.HBCHEGLPAIJ = hBCHEGLPAIJ;
							IBBBMACIBGK.CALCGCAOAKI = num4;
							return -3;
						}
						for (num11 &= 0xF; num3 < num11; num3 += 8)
						{
							num--;
							num2 |= (IGNEOOOFEMO.BLJFIEBCEPL[hBCHEGLPAIJ++] & 0xFF) << num3;
						}
						int num13 = array[num10 + 2] + (num2 & OKODOAEILFA[num11]);
						num2 >>= num11;
						num3 -= num11;
						num5 -= num12;
						int num14;
						if (num4 >= num13)
						{
							num14 = num4 - num13;
							if (num4 - num14 > 0 && 2 > num4 - num14)
							{
								IBBBMACIBGK.IMHIHJLIEBK[num4++] = IBBBMACIBGK.IMHIHJLIEBK[num14++];
								IBBBMACIBGK.IMHIHJLIEBK[num4++] = IBBBMACIBGK.IMHIHJLIEBK[num14++];
								num12 -= 2;
							}
							else
							{
								Array.Copy(IBBBMACIBGK.IMHIHJLIEBK, num14, IBBBMACIBGK.IMHIHJLIEBK, num4, 2);
								num4 += 2;
								num14 += 2;
								num12 -= 2;
							}
						}
						else
						{
							num14 = num4 - num13;
							do
							{
								num14 += IBBBMACIBGK.AHPGGJALELA;
							}
							while (num14 < 0);
							num11 = IBBBMACIBGK.AHPGGJALELA - num14;
							if (num12 > num11)
							{
								num12 -= num11;
								if (num4 - num14 > 0 && num11 > num4 - num14)
								{
									do
									{
										IBBBMACIBGK.IMHIHJLIEBK[num4++] = IBBBMACIBGK.IMHIHJLIEBK[num14++];
									}
									while (--num11 != 0);
								}
								else
								{
									Array.Copy(IBBBMACIBGK.IMHIHJLIEBK, num14, IBBBMACIBGK.IMHIHJLIEBK, num4, num11);
									num4 += num11;
									num14 += num11;
									num11 = 0;
								}
								num14 = 0;
							}
						}
						if (num4 - num14 > 0 && num12 > num4 - num14)
						{
							do
							{
								IBBBMACIBGK.IMHIHJLIEBK[num4++] = IBBBMACIBGK.IMHIHJLIEBK[num14++];
							}
							while (--num12 != 0);
							break;
						}
						Array.Copy(IBBBMACIBGK.IMHIHJLIEBK, num14, IBBBMACIBGK.IMHIHJLIEBK, num4, num12);
						num4 += num12;
						num14 += num12;
						num12 = 0;
						break;
					}
					if ((num11 & 0x40) == 0)
					{
						num8 += array[num10 + 2];
						num8 += num2 & OKODOAEILFA[num11];
						num10 = (num9 + num8) * 3;
						if ((num11 = array[num10]) == 0)
						{
							num2 >>= array[num10 + 1];
							num3 -= array[num10 + 1];
							IBBBMACIBGK.IMHIHJLIEBK[num4++] = (byte)array[num10 + 2];
							num5--;
							break;
						}
						continue;
					}
					if (((uint)num11 & 0x20u) != 0)
					{
						num12 = IGNEOOOFEMO.HCNAGHNCFLL - num;
						num12 = ((num3 >> 3 >= num12) ? num12 : (num3 >> 3));
						num += num12;
						hBCHEGLPAIJ -= num12;
						num3 -= num12 << 3;
						IBBBMACIBGK.DCLKKOJJELJ = num2;
						IBBBMACIBGK.GCNDOBHMGOP = num3;
						IGNEOOOFEMO.HCNAGHNCFLL = num;
						IGNEOOOFEMO.IOKPEPLADED += hBCHEGLPAIJ - IGNEOOOFEMO.HBCHEGLPAIJ;
						IGNEOOOFEMO.HBCHEGLPAIJ = hBCHEGLPAIJ;
						IBBBMACIBGK.CALCGCAOAKI = num4;
						return 1;
					}
					IGNEOOOFEMO.NOIOHIPHFHA = "invalid literal/length code";
					num12 = IGNEOOOFEMO.HCNAGHNCFLL - num;
					num12 = ((num3 >> 3 >= num12) ? num12 : (num3 >> 3));
					num += num12;
					hBCHEGLPAIJ -= num12;
					num3 -= num12 << 3;
					IBBBMACIBGK.DCLKKOJJELJ = num2;
					IBBBMACIBGK.GCNDOBHMGOP = num3;
					IGNEOOOFEMO.HCNAGHNCFLL = num;
					IGNEOOOFEMO.IOKPEPLADED += hBCHEGLPAIJ - IGNEOOOFEMO.HBCHEGLPAIJ;
					IGNEOOOFEMO.HBCHEGLPAIJ = hBCHEGLPAIJ;
					IBBBMACIBGK.CALCGCAOAKI = num4;
					return -3;
				}
			}
			if (num5 < 258 || num < 10)
			{
				break;
			}
		}
		num12 = IGNEOOOFEMO.HCNAGHNCFLL - num;
		num12 = ((num3 >> 3 >= num12) ? num12 : (num3 >> 3));
		num += num12;
		hBCHEGLPAIJ -= num12;
		num3 -= num12 << 3;
		IBBBMACIBGK.DCLKKOJJELJ = num2;
		IBBBMACIBGK.GCNDOBHMGOP = num3;
		IGNEOOOFEMO.HCNAGHNCFLL = num;
		IGNEOOOFEMO.IOKPEPLADED += hBCHEGLPAIJ - IGNEOOOFEMO.HBCHEGLPAIJ;
		IGNEOOOFEMO.HBCHEGLPAIJ = hBCHEGLPAIJ;
		IBBBMACIBGK.CALCGCAOAKI = num4;
		return 0;
	}
}
