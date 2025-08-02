using System;
using Org.BouncyCastle.Math;

public abstract class ABHJGAELGKM
{
	public static readonly string MIBNLJLILLI = "bc_wnaf";

	private static readonly int[] MNLEGJHHOHN = new int[6] { 13, 41, 121, 337, 897, 2305 };

	private static readonly byte[] IAKJJJBBBBC = new byte[0];

	private static readonly int[] DLLKBIOKOOF = new int[0];

	private static readonly JGAFKLGGBGF[] CGPEFLHJEGC = new JGAFKLGGBGF[0];

	public static int[] DBEPCCAPBPN(BigInteger BENKLGPHLGI)
	{
		if (BENKLGPHLGI.BitLength >> 16 != 0)
		{
			throw new ArgumentException("must have bitlength < 2^16", "k");
		}
		if (BENKLGPHLGI.SignValue == 0)
		{
			return DLLKBIOKOOF;
		}
		BigInteger bigInteger = BENKLGPHLGI.DOKHFLENGLF(1).JEACJNAKLDJ(BENKLGPHLGI);
		int bitLength = bigInteger.BitLength;
		int[] array = new int[bitLength >> 1];
		BigInteger bigInteger2 = bigInteger.FHLALGENPPH(BENKLGPHLGI);
		int num = bitLength - 1;
		int num2 = 0;
		int num3 = 0;
		for (int i = 1; i < num; i++)
		{
			if (!bigInteger2.NJHNJHGDCIJ(i))
			{
				num3++;
				continue;
			}
			int num4 = ((!BENKLGPHLGI.NJHNJHGDCIJ(i)) ? 1 : (-1));
			array[num2++] = (num4 << 16) | num3;
			num3 = 1;
			i++;
		}
		array[num2++] = 0x10000 | num3;
		if (array.Length > num2)
		{
			array = DPEHDOHMBPP(array, num2);
		}
		return array;
	}

	public static int[] GCJNNGOMNFC(int HHHMOGOKFHF, BigInteger BENKLGPHLGI)
	{
		switch (HHHMOGOKFHF)
		{
		case 2:
			return DBEPCCAPBPN(BENKLGPHLGI);
		default:
			throw new ArgumentException("must be in the range [2, 16]", "width");
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
		case 10:
		case 11:
		case 12:
		case 13:
		case 14:
		case 15:
		case 16:
		{
			if (BENKLGPHLGI.BitLength >> 16 != 0)
			{
				throw new ArgumentException("must have bitlength < 2^16", "k");
			}
			if (BENKLGPHLGI.SignValue == 0)
			{
				return DLLKBIOKOOF;
			}
			int[] array = new int[BENKLGPHLGI.BitLength / HHHMOGOKFHF + 1];
			int num = 1 << HHHMOGOKFHF;
			int num2 = num - 1;
			int num3 = num >> 1;
			bool flag = false;
			int num4 = 0;
			int num5 = 0;
			while (num5 <= BENKLGPHLGI.BitLength)
			{
				if (BENKLGPHLGI.NJHNJHGDCIJ(num5) == flag)
				{
					num5++;
					continue;
				}
				BENKLGPHLGI = BENKLGPHLGI.ABOIOKBIANB(num5);
				int num6 = BENKLGPHLGI.IntValue & num2;
				if (flag)
				{
					num6++;
				}
				flag = (num6 & num3) != 0;
				if (flag)
				{
					num6 -= num;
				}
				int num7 = ((num4 <= 0) ? num5 : (num5 - 1));
				array[num4++] = (num6 << 16) | num7;
				num5 = HHHMOGOKFHF;
			}
			if (array.Length > num4)
			{
				array = DPEHDOHMBPP(array, num4);
			}
			return array;
		}
		}
	}

	public static byte[] MBPFFFKHLON(BigInteger HJMBDGKAOBP, BigInteger GPJDJCGDJDC)
	{
		int num = Math.Max(HJMBDGKAOBP.BitLength, GPJDJCGDJDC.BitLength) + 1;
		byte[] array = new byte[num];
		BigInteger bigInteger = HJMBDGKAOBP;
		BigInteger bigInteger2 = GPJDJCGDJDC;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		while ((num3 | num4) != 0 || bigInteger.BitLength > num5 || bigInteger2.BitLength > num5)
		{
			int num6 = ((int)((uint)bigInteger.IntValue >> num5) + num3) & 7;
			int num7 = ((int)((uint)bigInteger2.IntValue >> num5) + num4) & 7;
			int num8 = num6 & 1;
			if (num8 != 0)
			{
				num8 -= num6 & 2;
				if (num6 + num8 == 4 && (num7 & 3) == 2)
				{
					num8 = -num8;
				}
			}
			int num9 = num7 & 1;
			if (num9 != 0)
			{
				num9 -= num7 & 2;
				if (num7 + num9 == 4 && (num6 & 3) == 2)
				{
					num9 = -num9;
				}
			}
			if (num3 << 1 == 1 + num8)
			{
				num3 ^= 1;
			}
			if (num4 << 1 == 1 + num9)
			{
				num4 ^= 1;
			}
			if (++num5 == 30)
			{
				num5 = 0;
				bigInteger = bigInteger.ABOIOKBIANB(30);
				bigInteger2 = bigInteger2.ABOIOKBIANB(30);
			}
			array[num2++] = (byte)((uint)(num8 << 4) | ((uint)num9 & 0xFu));
		}
		if (array.Length > num2)
		{
			array = DPEHDOHMBPP(array, num2);
		}
		return array;
	}

	public static byte[] DLHBLBKFIOC(BigInteger BENKLGPHLGI)
	{
		if (BENKLGPHLGI.SignValue == 0)
		{
			return IAKJJJBBBBC;
		}
		BigInteger bigInteger = BENKLGPHLGI.DOKHFLENGLF(1).JEACJNAKLDJ(BENKLGPHLGI);
		int num = bigInteger.BitLength - 1;
		byte[] array = new byte[num];
		BigInteger bigInteger2 = bigInteger.FHLALGENPPH(BENKLGPHLGI);
		for (int i = 1; i < num; i++)
		{
			if (bigInteger2.NJHNJHGDCIJ(i))
			{
				array[i - 1] = (byte)((!BENKLGPHLGI.NJHNJHGDCIJ(i)) ? 1u : uint.MaxValue);
				i++;
			}
		}
		array[num - 1] = 1;
		return array;
	}

	public static byte[] DLOFMBAKCEG(int HHHMOGOKFHF, BigInteger BENKLGPHLGI)
	{
		switch (HHHMOGOKFHF)
		{
		case 2:
			return DLHBLBKFIOC(BENKLGPHLGI);
		default:
			throw new ArgumentException("must be in the range [2, 8]", "width");
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		{
			if (BENKLGPHLGI.SignValue == 0)
			{
				return IAKJJJBBBBC;
			}
			byte[] array = new byte[BENKLGPHLGI.BitLength + 1];
			int num = 1 << HHHMOGOKFHF;
			int num2 = num - 1;
			int num3 = num >> 1;
			bool flag = false;
			int num4 = 0;
			int num5 = 0;
			while (num5 <= BENKLGPHLGI.BitLength)
			{
				if (BENKLGPHLGI.NJHNJHGDCIJ(num5) == flag)
				{
					num5++;
					continue;
				}
				BENKLGPHLGI = BENKLGPHLGI.ABOIOKBIANB(num5);
				int num6 = BENKLGPHLGI.IntValue & num2;
				if (flag)
				{
					num6++;
				}
				flag = (num6 & num3) != 0;
				if (flag)
				{
					num6 -= num;
				}
				num4 += ((num4 <= 0) ? num5 : (num5 - 1));
				array[num4++] = (byte)num6;
				num5 = HHHMOGOKFHF;
			}
			if (array.Length > num4)
			{
				array = DPEHDOHMBPP(array, num4);
			}
			return array;
		}
		}
	}

	public static int BKBGONMOPKI(BigInteger BENKLGPHLGI)
	{
		if (BENKLGPHLGI.SignValue == 0)
		{
			return 0;
		}
		BigInteger bigInteger = BENKLGPHLGI.DOKHFLENGLF(1).JEACJNAKLDJ(BENKLGPHLGI);
		BigInteger bigInteger2 = bigInteger.FHLALGENPPH(BENKLGPHLGI);
		return bigInteger2.BitCount;
	}

	public static PPENFIKGBIK BLEABBDGPNI(JGAFKLGGBGF HPHBDNBJPHB)
	{
		return BLEABBDGPNI(HPHBDNBJPHB.ECFGFKNLLGH.IBLDMGPNNBD(HPHBDNBJPHB, MIBNLJLILLI));
	}

	public static PPENFIKGBIK BLEABBDGPNI(LJCCHFLFGJG DAPLBLGNCPK)
	{
		if (DAPLBLGNCPK != null && DAPLBLGNCPK is PPENFIKGBIK)
		{
			return (PPENFIKGBIK)DAPLBLGNCPK;
		}
		return new PPENFIKGBIK();
	}

	public static int PKCOEDNEJGL(int IODPDKHNDIE)
	{
		return PKCOEDNEJGL(IODPDKHNDIE, MNLEGJHHOHN);
	}

	public static int PKCOEDNEJGL(int IODPDKHNDIE, int[] HMJPKJNONBO)
	{
		int i;
		for (i = 0; i < HMJPKJNONBO.Length && IODPDKHNDIE >= HMJPKJNONBO[i]; i++)
		{
		}
		return i + 2;
	}

	public static JGAFKLGGBGF ACMLIGOIIJF(JGAFKLGGBGF HPHBDNBJPHB, int HHHMOGOKFHF, bool NFNLDDAPNJK, LFADADGHPPC KMLMLMCIKOG)
	{
		BHPIABAGAPB bHPIABAGAPB = HPHBDNBJPHB.ECFGFKNLLGH;
		PPENFIKGBIK pPENFIKGBIK = KPMDCFDMLFE(HPHBDNBJPHB, HHHMOGOKFHF, NFNLDDAPNJK);
		JGAFKLGGBGF jGAFKLGGBGF = KMLMLMCIKOG.FBDFAFGCDIO(HPHBDNBJPHB);
		PPENFIKGBIK pPENFIKGBIK2 = BLEABBDGPNI(bHPIABAGAPB.IBLDMGPNNBD(jGAFKLGGBGF, MIBNLJLILLI));
		JGAFKLGGBGF jGAFKLGGBGF2 = pPENFIKGBIK.LLGLJBDLBOP;
		if (jGAFKLGGBGF2 != null)
		{
			JGAFKLGGBGF eDDNOJDPMCF = KMLMLMCIKOG.FBDFAFGCDIO(jGAFKLGGBGF2);
			pPENFIKGBIK2.LLGLJBDLBOP = eDDNOJDPMCF;
		}
		JGAFKLGGBGF[] array = pPENFIKGBIK.JJFOMCAIJPO;
		JGAFKLGGBGF[] array2 = new JGAFKLGGBGF[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = KMLMLMCIKOG.FBDFAFGCDIO(array[i]);
		}
		pPENFIKGBIK2.JJFOMCAIJPO = array2;
		if (NFNLDDAPNJK)
		{
			JGAFKLGGBGF[] array3 = new JGAFKLGGBGF[array2.Length];
			for (int j = 0; j < array3.Length; j++)
			{
				array3[j] = array2[j].BHKOFHMDACN();
			}
			pPENFIKGBIK2.JNABIODEPNL = array3;
		}
		bHPIABAGAPB.OOGGMOCFMHH(jGAFKLGGBGF, MIBNLJLILLI, pPENFIKGBIK2);
		return jGAFKLGGBGF;
	}

	public static PPENFIKGBIK KPMDCFDMLFE(JGAFKLGGBGF HPHBDNBJPHB, int HHHMOGOKFHF, bool NFNLDDAPNJK)
	{
		BHPIABAGAPB bHPIABAGAPB = HPHBDNBJPHB.ECFGFKNLLGH;
		PPENFIKGBIK pPENFIKGBIK = BLEABBDGPNI(bHPIABAGAPB.IBLDMGPNNBD(HPHBDNBJPHB, MIBNLJLILLI));
		int num = 0;
		int num2 = 1 << Math.Max(0, HHHMOGOKFHF - 2);
		JGAFKLGGBGF[] array = pPENFIKGBIK.JJFOMCAIJPO;
		if (array == null)
		{
			array = CGPEFLHJEGC;
		}
		else
		{
			num = array.Length;
		}
		if (num < num2)
		{
			array = OODCFAFKHMK(array, num2);
			if (num2 == 1)
			{
				array[0] = HPHBDNBJPHB.MIHJHLFLHNA();
			}
			else
			{
				int num3 = num;
				if (num3 == 0)
				{
					array[0] = HPHBDNBJPHB;
					num3 = 1;
				}
				KBINBLGGLNE kBINBLGGLNE = null;
				if (num2 == 2)
				{
					array[1] = HPHBDNBJPHB.LFFNDDCHCMH();
				}
				else
				{
					JGAFKLGGBGF jGAFKLGGBGF = pPENFIKGBIK.LLGLJBDLBOP;
					JGAFKLGGBGF jGAFKLGGBGF2 = array[num3 - 1];
					if (jGAFKLGGBGF == null)
					{
						jGAFKLGGBGF = (pPENFIKGBIK.LLGLJBDLBOP = array[0].LLGLJBDLBOP());
						if (KHJLHEJBLOA.FNAAANIPFOP(bHPIABAGAPB) && bHPIABAGAPB.PJNLBAHOKGC >= 64)
						{
							int num4 = bHPIABAGAPB.DHBHKHGFIKI;
							if (num4 == 2 || num4 == 3 || num4 == 4)
							{
								kBINBLGGLNE = jGAFKLGGBGF.NOIPJPPAFOH(0);
								jGAFKLGGBGF = bHPIABAGAPB.IIDKCEOFIBH(jGAFKLGGBGF.OBCJFNBLIPG.DOJBPIFPALJ(), jGAFKLGGBGF.LGFGMGPDEIB.DOJBPIFPALJ());
								KBINBLGGLNE kBINBLGGLNE2 = kBINBLGGLNE.MIOEHGDPGAG();
								KBINBLGGLNE hJLOCAEAFMJ = kBINBLGGLNE2.IBJBIGNPNEM(kBINBLGGLNE);
								jGAFKLGGBGF2 = jGAFKLGGBGF2.FLDLCFHBMEA(kBINBLGGLNE2).DEFAMIAKKGM(hJLOCAEAFMJ);
								if (num == 0)
								{
									array[0] = jGAFKLGGBGF2;
								}
							}
						}
					}
					while (num3 < num2)
					{
						jGAFKLGGBGF2 = (array[num3++] = jGAFKLGGBGF2.JEACJNAKLDJ(jGAFKLGGBGF));
					}
				}
				bHPIABAGAPB.NPDHPEDPAPA(array, num, num2 - num, kBINBLGGLNE);
			}
		}
		pPENFIKGBIK.JJFOMCAIJPO = array;
		if (NFNLDDAPNJK)
		{
			JGAFKLGGBGF[] array2 = pPENFIKGBIK.JNABIODEPNL;
			int i;
			if (array2 == null)
			{
				i = 0;
				array2 = new JGAFKLGGBGF[num2];
			}
			else
			{
				i = array2.Length;
				if (i < num2)
				{
					array2 = OODCFAFKHMK(array2, num2);
				}
			}
			for (; i < num2; i++)
			{
				array2[i] = array[i].BHKOFHMDACN();
			}
			pPENFIKGBIK.JNABIODEPNL = array2;
		}
		bHPIABAGAPB.OOGGMOCFMHH(HPHBDNBJPHB, MIBNLJLILLI, pPENFIKGBIK);
		return pPENFIKGBIK;
	}

	private static byte[] DPEHDOHMBPP(byte[] MNIMEAMHNMI, int EOFAGACBNFP)
	{
		byte[] array = new byte[EOFAGACBNFP];
		Array.Copy(MNIMEAMHNMI, 0, array, 0, array.Length);
		return array;
	}

	private static int[] DPEHDOHMBPP(int[] MNIMEAMHNMI, int EOFAGACBNFP)
	{
		int[] array = new int[EOFAGACBNFP];
		Array.Copy(MNIMEAMHNMI, 0, array, 0, array.Length);
		return array;
	}

	private static JGAFKLGGBGF[] OODCFAFKHMK(JGAFKLGGBGF[] MNIMEAMHNMI, int EOFAGACBNFP)
	{
		JGAFKLGGBGF[] array = new JGAFKLGGBGF[EOFAGACBNFP];
		Array.Copy(MNIMEAMHNMI, 0, array, 0, MNIMEAMHNMI.Length);
		return array;
	}
}
