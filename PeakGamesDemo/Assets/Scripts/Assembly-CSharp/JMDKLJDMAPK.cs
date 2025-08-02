using System;

internal sealed class JMDKLJDMAPK
{
	private const int PJKENOENNBA = 1440;

	private static readonly int[] OKODOAEILFA = new int[17]
	{
		0, 1, 3, 7, 15, 31, 63, 127, 255, 511,
		1023, 2047, 4095, 8191, 16383, 32767, 65535
	};

	private static readonly int[] NOEGCMCJPGL = new int[19]
	{
		16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
		11, 4, 12, 3, 13, 2, 14, 1, 15
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

	private const int DOJIACLABHN = 0;

	private const int MJMCGKDHJPB = 1;

	private const int GJIOMEEEMAN = 2;

	private const int GCPCHAGNLBH = 3;

	private const int LFEPAMFAKHL = 4;

	private const int GCAEOIPJGGI = 5;

	private const int DNFKBOAEBDB = 6;

	private const int IEPAHPNBCNI = 7;

	private const int EHPFOPCBJCK = 8;

	private const int PDEDELKPNFE = 9;

	internal int LJCPOAOKFOE;

	internal int BICBELADBDI;

	internal int AEPNIOFMGPL;

	internal int EHJNMODJEAN;

	internal int[] CCEGOJIDPLO;

	internal int[] KAOMHECDHKK = new int[1];

	internal int[] BIMBLNDJKOD = new int[1];

	internal OAIAKPGNCEB IJKKGJCDEPB = new OAIAKPGNCEB();

	private int GPFODPAOJOM;

	internal int GCNDOBHMGOP;

	internal int DCLKKOJJELJ;

	internal int[] KKEAHMNDDOB;

	internal byte[] IMHIHJLIEBK;

	internal int AHPGGJALELA;

	internal int ABGLICODIMA;

	internal int CALCGCAOAKI;

	internal object CGJKHIFGCKO;

	internal long IMHPKDDKJMH;

	internal OJLGLCMPHNF ANDILBCIEJC = new OJLGLCMPHNF();

	internal JMDKLJDMAPK(NNHGBFFHNMG IGNEOOOFEMO, object CGJKHIFGCKO, int PHFLBLJJMLI)
	{
		KKEAHMNDDOB = new int[4320];
		IMHIHJLIEBK = new byte[PHFLBLJJMLI];
		AHPGGJALELA = PHFLBLJJMLI;
		this.CGJKHIFGCKO = CGJKHIFGCKO;
		LJCPOAOKFOE = 0;
		PBKKHDHKMFG(IGNEOOOFEMO, null);
	}

	internal void PBKKHDHKMFG(NNHGBFFHNMG IGNEOOOFEMO, long[] FMFABAKPMLB)
	{
		if (FMFABAKPMLB != null)
		{
			FMFABAKPMLB[0] = IMHPKDDKJMH;
		}
		if (LJCPOAOKFOE == 4 || LJCPOAOKFOE == 5)
		{
		}
		if (LJCPOAOKFOE == 6)
		{
			IJKKGJCDEPB.KNLOBIILDMP(IGNEOOOFEMO);
		}
		LJCPOAOKFOE = 0;
		GCNDOBHMGOP = 0;
		DCLKKOJJELJ = 0;
		ABGLICODIMA = (CALCGCAOAKI = 0);
		if (CGJKHIFGCKO != null)
		{
			IGNEOOOFEMO.LEIJBCJFPGI = (IMHPKDDKJMH = IGNEOOOFEMO.JHMLJILAIMK.IKGHHFMJBJG(0L, null, 0, 0));
		}
	}

	internal int NEGIBIGJEKE(NNHGBFFHNMG IGNEOOOFEMO, int GPGDCCMECGF)
	{
		int num = IGNEOOOFEMO.HBCHEGLPAIJ;
		int num2 = IGNEOOOFEMO.HCNAGHNCFLL;
		int num3 = DCLKKOJJELJ;
		int i = GCNDOBHMGOP;
		int num4 = CALCGCAOAKI;
		int num5 = ((num4 >= ABGLICODIMA) ? (AHPGGJALELA - num4) : (ABGLICODIMA - num4 - 1));
		while (true)
		{
			switch (LJCPOAOKFOE)
			{
			case 0:
			{
				for (; i < 3; i += 8)
				{
					if (num2 != 0)
					{
						GPGDCCMECGF = 0;
						num2--;
						num3 |= (IGNEOOOFEMO.BLJFIEBCEPL[num++] & 0xFF) << i;
						continue;
					}
					DCLKKOJJELJ = num3;
					GCNDOBHMGOP = i;
					IGNEOOOFEMO.HCNAGHNCFLL = num2;
					IGNEOOOFEMO.IOKPEPLADED += num - IGNEOOOFEMO.HBCHEGLPAIJ;
					IGNEOOOFEMO.HBCHEGLPAIJ = num;
					CALCGCAOAKI = num4;
					return BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
				}
				int num6 = num3 & 7;
				GPFODPAOJOM = num6 & 1;
				switch (num6 >> 1)
				{
				case 0:
					num3 >>= 3;
					i -= 3;
					num6 = i & 7;
					num3 >>= num6;
					i -= num6;
					LJCPOAOKFOE = 1;
					break;
				case 1:
				{
					int[] array = new int[1];
					int[] array2 = new int[1];
					int[][] array3 = new int[1][];
					int[][] array4 = new int[1][];
					OJLGLCMPHNF.OLACIDBLFII(array, array2, array3, array4, IGNEOOOFEMO);
					IJKKGJCDEPB.BNOMLEDAFJI(array[0], array2[0], array3[0], 0, array4[0], 0, IGNEOOOFEMO);
					num3 >>= 3;
					i -= 3;
					LJCPOAOKFOE = 6;
					break;
				}
				case 2:
					num3 >>= 3;
					i -= 3;
					LJCPOAOKFOE = 3;
					break;
				case 3:
					num3 >>= 3;
					i -= 3;
					LJCPOAOKFOE = 9;
					IGNEOOOFEMO.NOIOHIPHFHA = "invalid block type";
					GPGDCCMECGF = -3;
					DCLKKOJJELJ = num3;
					GCNDOBHMGOP = i;
					IGNEOOOFEMO.HCNAGHNCFLL = num2;
					IGNEOOOFEMO.IOKPEPLADED += num - IGNEOOOFEMO.HBCHEGLPAIJ;
					IGNEOOOFEMO.HBCHEGLPAIJ = num;
					CALCGCAOAKI = num4;
					return BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
				}
				break;
			}
			case 1:
				for (; i < 32; i += 8)
				{
					if (num2 != 0)
					{
						GPGDCCMECGF = 0;
						num2--;
						num3 |= (IGNEOOOFEMO.BLJFIEBCEPL[num++] & 0xFF) << i;
						continue;
					}
					DCLKKOJJELJ = num3;
					GCNDOBHMGOP = i;
					IGNEOOOFEMO.HCNAGHNCFLL = num2;
					IGNEOOOFEMO.IOKPEPLADED += num - IGNEOOOFEMO.HBCHEGLPAIJ;
					IGNEOOOFEMO.HBCHEGLPAIJ = num;
					CALCGCAOAKI = num4;
					return BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
				}
				if (((~num3 >> 16) & 0xFFFF) != (num3 & 0xFFFF))
				{
					LJCPOAOKFOE = 9;
					IGNEOOOFEMO.NOIOHIPHFHA = "invalid stored block lengths";
					GPGDCCMECGF = -3;
					DCLKKOJJELJ = num3;
					GCNDOBHMGOP = i;
					IGNEOOOFEMO.HCNAGHNCFLL = num2;
					IGNEOOOFEMO.IOKPEPLADED += num - IGNEOOOFEMO.HBCHEGLPAIJ;
					IGNEOOOFEMO.HBCHEGLPAIJ = num;
					CALCGCAOAKI = num4;
					return BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
				}
				BICBELADBDI = num3 & 0xFFFF;
				num3 = (i = 0);
				LJCPOAOKFOE = ((BICBELADBDI != 0) ? 2 : ((GPFODPAOJOM != 0) ? 7 : 0));
				break;
			case 2:
			{
				if (num2 == 0)
				{
					DCLKKOJJELJ = num3;
					GCNDOBHMGOP = i;
					IGNEOOOFEMO.HCNAGHNCFLL = num2;
					IGNEOOOFEMO.IOKPEPLADED += num - IGNEOOOFEMO.HBCHEGLPAIJ;
					IGNEOOOFEMO.HBCHEGLPAIJ = num;
					CALCGCAOAKI = num4;
					return BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
				}
				if (num5 == 0)
				{
					if (num4 == AHPGGJALELA && ABGLICODIMA != 0)
					{
						num4 = 0;
						num5 = ((num4 >= ABGLICODIMA) ? (AHPGGJALELA - num4) : (ABGLICODIMA - num4 - 1));
					}
					if (num5 == 0)
					{
						CALCGCAOAKI = num4;
						GPGDCCMECGF = BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
						num4 = CALCGCAOAKI;
						num5 = ((num4 >= ABGLICODIMA) ? (AHPGGJALELA - num4) : (ABGLICODIMA - num4 - 1));
						if (num4 == AHPGGJALELA && ABGLICODIMA != 0)
						{
							num4 = 0;
							num5 = ((num4 >= ABGLICODIMA) ? (AHPGGJALELA - num4) : (ABGLICODIMA - num4 - 1));
						}
						if (num5 == 0)
						{
							DCLKKOJJELJ = num3;
							GCNDOBHMGOP = i;
							IGNEOOOFEMO.HCNAGHNCFLL = num2;
							IGNEOOOFEMO.IOKPEPLADED += num - IGNEOOOFEMO.HBCHEGLPAIJ;
							IGNEOOOFEMO.HBCHEGLPAIJ = num;
							CALCGCAOAKI = num4;
							return BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
						}
					}
				}
				GPGDCCMECGF = 0;
				int num6 = BICBELADBDI;
				if (num6 > num2)
				{
					num6 = num2;
				}
				if (num6 > num5)
				{
					num6 = num5;
				}
				Array.Copy(IGNEOOOFEMO.BLJFIEBCEPL, num, IMHIHJLIEBK, num4, num6);
				num += num6;
				num2 -= num6;
				num4 += num6;
				num5 -= num6;
				if ((BICBELADBDI -= num6) == 0)
				{
					LJCPOAOKFOE = ((GPFODPAOJOM != 0) ? 7 : 0);
				}
				break;
			}
			case 3:
			{
				for (; i < 14; i += 8)
				{
					if (num2 != 0)
					{
						GPGDCCMECGF = 0;
						num2--;
						num3 |= (IGNEOOOFEMO.BLJFIEBCEPL[num++] & 0xFF) << i;
						continue;
					}
					DCLKKOJJELJ = num3;
					GCNDOBHMGOP = i;
					IGNEOOOFEMO.HCNAGHNCFLL = num2;
					IGNEOOOFEMO.IOKPEPLADED += num - IGNEOOOFEMO.HBCHEGLPAIJ;
					IGNEOOOFEMO.HBCHEGLPAIJ = num;
					CALCGCAOAKI = num4;
					return BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
				}
				int num6 = (AEPNIOFMGPL = num3 & 0x3FFF);
				if ((num6 & 0x1F) > 29 || ((num6 >> 5) & 0x1F) > 29)
				{
					LJCPOAOKFOE = 9;
					IGNEOOOFEMO.NOIOHIPHFHA = "too many length or distance symbols";
					GPGDCCMECGF = -3;
					DCLKKOJJELJ = num3;
					GCNDOBHMGOP = i;
					IGNEOOOFEMO.HCNAGHNCFLL = num2;
					IGNEOOOFEMO.IOKPEPLADED += num - IGNEOOOFEMO.HBCHEGLPAIJ;
					IGNEOOOFEMO.HBCHEGLPAIJ = num;
					CALCGCAOAKI = num4;
					return BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
				}
				num6 = 258 + (num6 & 0x1F) + ((num6 >> 5) & 0x1F);
				if (CCEGOJIDPLO == null || CCEGOJIDPLO.Length < num6)
				{
					CCEGOJIDPLO = new int[num6];
				}
				else
				{
					for (int j = 0; j < num6; j++)
					{
						CCEGOJIDPLO[j] = 0;
					}
				}
				num3 >>= 14;
				i -= 14;
				EHJNMODJEAN = 0;
				LJCPOAOKFOE = 4;
				goto case 4;
			}
			case 4:
			{
				while (EHJNMODJEAN < 4 + (AEPNIOFMGPL >> 10))
				{
					for (; i < 3; i += 8)
					{
						if (num2 != 0)
						{
							GPGDCCMECGF = 0;
							num2--;
							num3 |= (IGNEOOOFEMO.BLJFIEBCEPL[num++] & 0xFF) << i;
							continue;
						}
						DCLKKOJJELJ = num3;
						GCNDOBHMGOP = i;
						IGNEOOOFEMO.HCNAGHNCFLL = num2;
						IGNEOOOFEMO.IOKPEPLADED += num - IGNEOOOFEMO.HBCHEGLPAIJ;
						IGNEOOOFEMO.HBCHEGLPAIJ = num;
						CALCGCAOAKI = num4;
						return BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
					}
					CCEGOJIDPLO[NOEGCMCJPGL[EHJNMODJEAN++]] = num3 & 7;
					num3 >>= 3;
					i -= 3;
				}
				while (EHJNMODJEAN < 19)
				{
					CCEGOJIDPLO[NOEGCMCJPGL[EHJNMODJEAN++]] = 0;
				}
				KAOMHECDHKK[0] = 7;
				int num6 = ANDILBCIEJC.AAFKEDFLBKO(CCEGOJIDPLO, KAOMHECDHKK, BIMBLNDJKOD, KKEAHMNDDOB, IGNEOOOFEMO);
				if (num6 != 0)
				{
					GPGDCCMECGF = num6;
					if (GPGDCCMECGF == -3)
					{
						CCEGOJIDPLO = null;
						LJCPOAOKFOE = 9;
					}
					DCLKKOJJELJ = num3;
					GCNDOBHMGOP = i;
					IGNEOOOFEMO.HCNAGHNCFLL = num2;
					IGNEOOOFEMO.IOKPEPLADED += num - IGNEOOOFEMO.HBCHEGLPAIJ;
					IGNEOOOFEMO.HBCHEGLPAIJ = num;
					CALCGCAOAKI = num4;
					return BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
				}
				EHJNMODJEAN = 0;
				LJCPOAOKFOE = 5;
				goto case 5;
			}
			case 5:
			{
				int num6;
				while (true)
				{
					num6 = AEPNIOFMGPL;
					if (EHJNMODJEAN >= 258 + (num6 & 0x1F) + ((num6 >> 5) & 0x1F))
					{
						break;
					}
					for (num6 = KAOMHECDHKK[0]; i < num6; i += 8)
					{
						if (num2 != 0)
						{
							GPGDCCMECGF = 0;
							num2--;
							num3 |= (IGNEOOOFEMO.BLJFIEBCEPL[num++] & 0xFF) << i;
							continue;
						}
						DCLKKOJJELJ = num3;
						GCNDOBHMGOP = i;
						IGNEOOOFEMO.HCNAGHNCFLL = num2;
						IGNEOOOFEMO.IOKPEPLADED += num - IGNEOOOFEMO.HBCHEGLPAIJ;
						IGNEOOOFEMO.HBCHEGLPAIJ = num;
						CALCGCAOAKI = num4;
						return BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
					}
					if (BIMBLNDJKOD[0] == -1)
					{
					}
					num6 = KKEAHMNDDOB[(BIMBLNDJKOD[0] + (num3 & OKODOAEILFA[num6])) * 3 + 1];
					int num7 = KKEAHMNDDOB[(BIMBLNDJKOD[0] + (num3 & OKODOAEILFA[num6])) * 3 + 2];
					if (num7 < 16)
					{
						num3 >>= num6;
						i -= num6;
						CCEGOJIDPLO[EHJNMODJEAN++] = num7;
						continue;
					}
					int num8 = ((num7 != 18) ? (num7 - 14) : 7);
					int num9 = ((num7 != 18) ? 3 : 11);
					for (; i < num6 + num8; i += 8)
					{
						if (num2 != 0)
						{
							GPGDCCMECGF = 0;
							num2--;
							num3 |= (IGNEOOOFEMO.BLJFIEBCEPL[num++] & 0xFF) << i;
							continue;
						}
						DCLKKOJJELJ = num3;
						GCNDOBHMGOP = i;
						IGNEOOOFEMO.HCNAGHNCFLL = num2;
						IGNEOOOFEMO.IOKPEPLADED += num - IGNEOOOFEMO.HBCHEGLPAIJ;
						IGNEOOOFEMO.HBCHEGLPAIJ = num;
						CALCGCAOAKI = num4;
						return BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
					}
					num3 >>= num6;
					i -= num6;
					num9 += num3 & OKODOAEILFA[num8];
					num3 >>= num8;
					i -= num8;
					num8 = EHJNMODJEAN;
					num6 = AEPNIOFMGPL;
					if (num8 + num9 > 258 + (num6 & 0x1F) + ((num6 >> 5) & 0x1F) || (num7 == 16 && num8 < 1))
					{
						CCEGOJIDPLO = null;
						LJCPOAOKFOE = 9;
						IGNEOOOFEMO.NOIOHIPHFHA = "invalid bit length repeat";
						GPGDCCMECGF = -3;
						DCLKKOJJELJ = num3;
						GCNDOBHMGOP = i;
						IGNEOOOFEMO.HCNAGHNCFLL = num2;
						IGNEOOOFEMO.IOKPEPLADED += num - IGNEOOOFEMO.HBCHEGLPAIJ;
						IGNEOOOFEMO.HBCHEGLPAIJ = num;
						CALCGCAOAKI = num4;
						return BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
					}
					num7 = ((num7 == 16) ? CCEGOJIDPLO[num8 - 1] : 0);
					do
					{
						CCEGOJIDPLO[num8++] = num7;
					}
					while (--num9 != 0);
					EHJNMODJEAN = num8;
				}
				BIMBLNDJKOD[0] = -1;
				int[] array5 = new int[1];
				int[] array6 = new int[1];
				int[] array7 = new int[1];
				int[] array8 = new int[1];
				array5[0] = 9;
				array6[0] = 6;
				num6 = AEPNIOFMGPL;
				num6 = ANDILBCIEJC.GMGIOHAGBJP(257 + (num6 & 0x1F), 1 + ((num6 >> 5) & 0x1F), CCEGOJIDPLO, array5, array6, array7, array8, KKEAHMNDDOB, IGNEOOOFEMO);
				if (num6 != 0)
				{
					if (num6 == -3)
					{
						CCEGOJIDPLO = null;
						LJCPOAOKFOE = 9;
					}
					GPGDCCMECGF = num6;
					DCLKKOJJELJ = num3;
					GCNDOBHMGOP = i;
					IGNEOOOFEMO.HCNAGHNCFLL = num2;
					IGNEOOOFEMO.IOKPEPLADED += num - IGNEOOOFEMO.HBCHEGLPAIJ;
					IGNEOOOFEMO.HBCHEGLPAIJ = num;
					CALCGCAOAKI = num4;
					return BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
				}
				IJKKGJCDEPB.BNOMLEDAFJI(array5[0], array6[0], KKEAHMNDDOB, array7[0], KKEAHMNDDOB, array8[0], IGNEOOOFEMO);
				LJCPOAOKFOE = 6;
				goto case 6;
			}
			case 6:
				DCLKKOJJELJ = num3;
				GCNDOBHMGOP = i;
				IGNEOOOFEMO.HCNAGHNCFLL = num2;
				IGNEOOOFEMO.IOKPEPLADED += num - IGNEOOOFEMO.HBCHEGLPAIJ;
				IGNEOOOFEMO.HBCHEGLPAIJ = num;
				CALCGCAOAKI = num4;
				if ((GPGDCCMECGF = IJKKGJCDEPB.NEGIBIGJEKE(this, IGNEOOOFEMO, GPGDCCMECGF)) != 1)
				{
					return BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
				}
				GPGDCCMECGF = 0;
				IJKKGJCDEPB.KNLOBIILDMP(IGNEOOOFEMO);
				num = IGNEOOOFEMO.HBCHEGLPAIJ;
				num2 = IGNEOOOFEMO.HCNAGHNCFLL;
				num3 = DCLKKOJJELJ;
				i = GCNDOBHMGOP;
				num4 = CALCGCAOAKI;
				num5 = ((num4 >= ABGLICODIMA) ? (AHPGGJALELA - num4) : (ABGLICODIMA - num4 - 1));
				if (GPFODPAOJOM == 0)
				{
					LJCPOAOKFOE = 0;
					break;
				}
				LJCPOAOKFOE = 7;
				goto case 7;
			case 7:
				CALCGCAOAKI = num4;
				GPGDCCMECGF = BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
				num4 = CALCGCAOAKI;
				num5 = ((num4 >= ABGLICODIMA) ? (AHPGGJALELA - num4) : (ABGLICODIMA - num4 - 1));
				if (ABGLICODIMA != CALCGCAOAKI)
				{
					DCLKKOJJELJ = num3;
					GCNDOBHMGOP = i;
					IGNEOOOFEMO.HCNAGHNCFLL = num2;
					IGNEOOOFEMO.IOKPEPLADED += num - IGNEOOOFEMO.HBCHEGLPAIJ;
					IGNEOOOFEMO.HBCHEGLPAIJ = num;
					CALCGCAOAKI = num4;
					return BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
				}
				LJCPOAOKFOE = 8;
				goto case 8;
			case 8:
				GPGDCCMECGF = 1;
				DCLKKOJJELJ = num3;
				GCNDOBHMGOP = i;
				IGNEOOOFEMO.HCNAGHNCFLL = num2;
				IGNEOOOFEMO.IOKPEPLADED += num - IGNEOOOFEMO.HBCHEGLPAIJ;
				IGNEOOOFEMO.HBCHEGLPAIJ = num;
				CALCGCAOAKI = num4;
				return BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
			case 9:
				GPGDCCMECGF = -3;
				DCLKKOJJELJ = num3;
				GCNDOBHMGOP = i;
				IGNEOOOFEMO.HCNAGHNCFLL = num2;
				IGNEOOOFEMO.IOKPEPLADED += num - IGNEOOOFEMO.HBCHEGLPAIJ;
				IGNEOOOFEMO.HBCHEGLPAIJ = num;
				CALCGCAOAKI = num4;
				return BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
			default:
				GPGDCCMECGF = -2;
				DCLKKOJJELJ = num3;
				GCNDOBHMGOP = i;
				IGNEOOOFEMO.HCNAGHNCFLL = num2;
				IGNEOOOFEMO.IOKPEPLADED += num - IGNEOOOFEMO.HBCHEGLPAIJ;
				IGNEOOOFEMO.HBCHEGLPAIJ = num;
				CALCGCAOAKI = num4;
				return BDEHPIDGJJL(IGNEOOOFEMO, GPGDCCMECGF);
			}
		}
	}

	internal void KNLOBIILDMP(NNHGBFFHNMG IGNEOOOFEMO)
	{
		PBKKHDHKMFG(IGNEOOOFEMO, null);
		IMHIHJLIEBK = null;
		KKEAHMNDDOB = null;
	}

	internal void OMGAEBKAGLJ(byte[] ELNCCDELMMH, int EHGOOEHDNMM, int IDHLPOFDLKJ)
	{
		Array.Copy(ELNCCDELMMH, EHGOOEHDNMM, IMHIHJLIEBK, 0, IDHLPOFDLKJ);
		ABGLICODIMA = (CALCGCAOAKI = IDHLPOFDLKJ);
	}

	internal int EPMJFDEIOIK()
	{
		return (LJCPOAOKFOE == 1) ? 1 : 0;
	}

	internal int BDEHPIDGJJL(NNHGBFFHNMG IGNEOOOFEMO, int GPGDCCMECGF)
	{
		int fOJDONLMBLJ = IGNEOOOFEMO.FOJDONLMBLJ;
		int aBGLICODIMA = ABGLICODIMA;
		int num = ((aBGLICODIMA > CALCGCAOAKI) ? AHPGGJALELA : CALCGCAOAKI) - aBGLICODIMA;
		if (num > IGNEOOOFEMO.PMJBPCFCGJO)
		{
			num = IGNEOOOFEMO.PMJBPCFCGJO;
		}
		if (num != 0 && GPGDCCMECGF == -5)
		{
			GPGDCCMECGF = 0;
		}
		IGNEOOOFEMO.PMJBPCFCGJO -= num;
		IGNEOOOFEMO.MDLEDIJMGHC += num;
		if (CGJKHIFGCKO != null)
		{
			IGNEOOOFEMO.LEIJBCJFPGI = (IMHPKDDKJMH = IGNEOOOFEMO.JHMLJILAIMK.IKGHHFMJBJG(IMHPKDDKJMH, IMHIHJLIEBK, aBGLICODIMA, num));
		}
		Array.Copy(IMHIHJLIEBK, aBGLICODIMA, IGNEOOOFEMO.BHHDNEGGGGJ, fOJDONLMBLJ, num);
		fOJDONLMBLJ += num;
		aBGLICODIMA += num;
		if (aBGLICODIMA == AHPGGJALELA)
		{
			aBGLICODIMA = 0;
			if (CALCGCAOAKI == AHPGGJALELA)
			{
				CALCGCAOAKI = 0;
			}
			num = CALCGCAOAKI - aBGLICODIMA;
			if (num > IGNEOOOFEMO.PMJBPCFCGJO)
			{
				num = IGNEOOOFEMO.PMJBPCFCGJO;
			}
			if (num != 0 && GPGDCCMECGF == -5)
			{
				GPGDCCMECGF = 0;
			}
			IGNEOOOFEMO.PMJBPCFCGJO -= num;
			IGNEOOOFEMO.MDLEDIJMGHC += num;
			if (CGJKHIFGCKO != null)
			{
				IGNEOOOFEMO.LEIJBCJFPGI = (IMHPKDDKJMH = IGNEOOOFEMO.JHMLJILAIMK.IKGHHFMJBJG(IMHPKDDKJMH, IMHIHJLIEBK, aBGLICODIMA, num));
			}
			Array.Copy(IMHIHJLIEBK, aBGLICODIMA, IGNEOOOFEMO.BHHDNEGGGGJ, fOJDONLMBLJ, num);
			fOJDONLMBLJ += num;
			aBGLICODIMA += num;
		}
		IGNEOOOFEMO.FOJDONLMBLJ = fOJDONLMBLJ;
		ABGLICODIMA = aBGLICODIMA;
		return GPGDCCMECGF;
	}
}
