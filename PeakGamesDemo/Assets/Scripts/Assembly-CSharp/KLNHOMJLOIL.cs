using System;
using Org.BouncyCastle.Math;

internal class KLNHOMJLOIL
{
	private const ulong FGIPJCKCDJK = 34359738367uL;

	private const ulong BECOECPOHIM = 36028797018963967uL;

	private static readonly ulong[] KGNHHCIOEBC = new ulong[3] { 13176245766935393968uL, 5270498306774195053uL, 19634136210uL };

	public static void JEACJNAKLDJ(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] IGNEOOOFEMO)
	{
		IGNEOOOFEMO[0] = AMFCENFNAJJ[0] ^ CNLILOEEBOJ[0];
		IGNEOOOFEMO[1] = AMFCENFNAJJ[1] ^ CNLILOEEBOJ[1];
		IGNEOOOFEMO[2] = AMFCENFNAJJ[2] ^ CNLILOEEBOJ[2];
	}

	public static void KGBEKKMEBCN(ulong[] HGHHJPDIMCI, ulong[] IKEIELCEKPD, ulong[] JMNJPLAGDDJ)
	{
		JMNJPLAGDDJ[0] = HGHHJPDIMCI[0] ^ IKEIELCEKPD[0];
		JMNJPLAGDDJ[1] = HGHHJPDIMCI[1] ^ IKEIELCEKPD[1];
		JMNJPLAGDDJ[2] = HGHHJPDIMCI[2] ^ IKEIELCEKPD[2];
		JMNJPLAGDDJ[3] = HGHHJPDIMCI[3] ^ IKEIELCEKPD[3];
		JMNJPLAGDDJ[4] = HGHHJPDIMCI[4] ^ IKEIELCEKPD[4];
		JMNJPLAGDDJ[5] = HGHHJPDIMCI[5] ^ IKEIELCEKPD[5];
	}

	public static void AOAINNMNBHC(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		IGNEOOOFEMO[0] = AMFCENFNAJJ[0] ^ 1;
		IGNEOOOFEMO[1] = AMFCENFNAJJ[1];
		IGNEOOOFEMO[2] = AMFCENFNAJJ[2];
	}

	public static ulong[] HFENNGHNFLF(BigInteger AMFCENFNAJJ)
	{
		ulong[] array = PHEKPHCPKLA.NCFBIELMPAA(AMFCENFNAJJ);
		LHHJOICLDAO(array, 0);
		return array;
	}

	public static void LEIECFOMCNL(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		if (PHEKPHCPKLA.NKNOMEDBEDI(AMFCENFNAJJ))
		{
			throw new InvalidOperationException();
		}
		ulong[] array = PHEKPHCPKLA.JLMPJDKAODG();
		ulong[] array2 = PHEKPHCPKLA.JLMPJDKAODG();
		MIOEHGDPGAG(AMFCENFNAJJ, array);
		OIEFGPHNOFN(array, 1, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array2, 1, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array, 3, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array2, 3, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array, 9, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array2, 9, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array, 27, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array2, 27, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array, 81, array2);
		IBJBIGNPNEM(array, array2, IGNEOOOFEMO);
	}

	public static void IBJBIGNPNEM(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] IGNEOOOFEMO)
	{
		ulong[] array = PHEKPHCPKLA.JFMBFIGDFCE();
		NEIMDHAFMNO(AMFCENFNAJJ, CNLILOEEBOJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
	}

	public static void OMJFFHEIEFH(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] JMNJPLAGDDJ)
	{
		ulong[] array = PHEKPHCPKLA.JFMBFIGDFCE();
		NEIMDHAFMNO(AMFCENFNAJJ, CNLILOEEBOJ, array);
		KGBEKKMEBCN(JMNJPLAGDDJ, array, JMNJPLAGDDJ);
	}

	public static void BKCHMGKFECM(ulong[] HGHHJPDIMCI, ulong[] IGNEOOOFEMO)
	{
		ulong num = HGHHJPDIMCI[0];
		ulong num2 = HGHHJPDIMCI[1];
		ulong num3 = HGHHJPDIMCI[2];
		ulong num4 = HGHHJPDIMCI[3];
		ulong num5 = HGHHJPDIMCI[4];
		ulong num6 = HGHHJPDIMCI[5];
		num3 ^= (num6 << 29) ^ (num6 << 32) ^ (num6 << 35) ^ (num6 << 36);
		num4 ^= (num6 >> 35) ^ (num6 >> 32) ^ (num6 >> 29) ^ (num6 >> 28);
		num2 ^= (num5 << 29) ^ (num5 << 32) ^ (num5 << 35) ^ (num5 << 36);
		num3 ^= (num5 >> 35) ^ (num5 >> 32) ^ (num5 >> 29) ^ (num5 >> 28);
		num ^= (num4 << 29) ^ (num4 << 32) ^ (num4 << 35) ^ (num4 << 36);
		num2 ^= (num4 >> 35) ^ (num4 >> 32) ^ (num4 >> 29) ^ (num4 >> 28);
		ulong num7 = num3 >> 35;
		IGNEOOOFEMO[0] = num ^ num7 ^ (num7 << 3) ^ (num7 << 6) ^ (num7 << 7);
		IGNEOOOFEMO[1] = num2;
		IGNEOOOFEMO[2] = num3 & 0x7FFFFFFFFuL;
	}

	public static void LHHJOICLDAO(ulong[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = IGNEOOOFEMO[NDAAKFPMLOL + 2];
		ulong num2 = num >> 35;
		IGNEOOOFEMO[NDAAKFPMLOL] ^= num2 ^ (num2 << 3) ^ (num2 << 6) ^ (num2 << 7);
		IGNEOOOFEMO[NDAAKFPMLOL + 2] = num & 0x7FFFFFFFFuL;
	}

	public static void PAEDNKEIDOM(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		ulong[] array = PHEKPHCPKLA.JLMPJDKAODG();
		ulong num = CKHAEFEPMDE.CHBDGGMNNFA(AMFCENFNAJJ[0]);
		ulong num2 = CKHAEFEPMDE.CHBDGGMNNFA(AMFCENFNAJJ[1]);
		ulong num3 = (num & 0xFFFFFFFFu) | (num2 << 32);
		array[0] = (num >> 32) | (num2 & 0xFFFFFFFF00000000uL);
		num = CKHAEFEPMDE.CHBDGGMNNFA(AMFCENFNAJJ[2]);
		ulong num4 = num & 0xFFFFFFFFu;
		array[1] = num >> 32;
		IBJBIGNPNEM(array, KGNHHCIOEBC, IGNEOOOFEMO);
		IGNEOOOFEMO[0] ^= num3;
		IGNEOOOFEMO[1] ^= num4;
	}

	public static void MIOEHGDPGAG(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		ulong[] array = PHEKPHCPKLA.JFMBFIGDFCE();
		MMBGDFPOOKF(AMFCENFNAJJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
	}

	public static void OALFNDHHFAA(ulong[] AMFCENFNAJJ, ulong[] JMNJPLAGDDJ)
	{
		ulong[] array = PHEKPHCPKLA.JFMBFIGDFCE();
		MMBGDFPOOKF(AMFCENFNAJJ, array);
		KGBEKKMEBCN(JMNJPLAGDDJ, array, JMNJPLAGDDJ);
	}

	public static void OIEFGPHNOFN(ulong[] AMFCENFNAJJ, int IDHLPOFDLKJ, ulong[] IGNEOOOFEMO)
	{
		ulong[] array = PHEKPHCPKLA.JFMBFIGDFCE();
		MMBGDFPOOKF(AMFCENFNAJJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
		while (--IDHLPOFDLKJ > 0)
		{
			MMBGDFPOOKF(IGNEOOOFEMO, array);
			BKCHMGKFECM(array, IGNEOOOFEMO);
		}
	}

	public static uint AKGCNGCBEKB(ulong[] AMFCENFNAJJ)
	{
		return (uint)(int)(AMFCENFNAJJ[0] ^ (AMFCENFNAJJ[2] >> 29)) & 1u;
	}

	protected static void MFAKDNFHPLA(ulong[] JMNJPLAGDDJ)
	{
		ulong num = JMNJPLAGDDJ[0];
		ulong num2 = JMNJPLAGDDJ[1];
		ulong num3 = JMNJPLAGDDJ[2];
		ulong num4 = JMNJPLAGDDJ[3];
		ulong num5 = JMNJPLAGDDJ[4];
		ulong num6 = JMNJPLAGDDJ[5];
		JMNJPLAGDDJ[0] = num ^ (num2 << 55);
		JMNJPLAGDDJ[1] = (num2 >> 9) ^ (num3 << 46);
		JMNJPLAGDDJ[2] = (num3 >> 18) ^ (num4 << 37);
		JMNJPLAGDDJ[3] = (num4 >> 27) ^ (num5 << 28);
		JMNJPLAGDDJ[4] = (num5 >> 36) ^ (num6 << 19);
		JMNJPLAGDDJ[5] = num6 >> 45;
	}

	protected static void NEIMDHAFMNO(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] JMNJPLAGDDJ)
	{
		ulong num = AMFCENFNAJJ[0];
		ulong num2 = AMFCENFNAJJ[1];
		ulong num3 = AMFCENFNAJJ[2];
		num3 = (num2 >> 46) ^ (num3 << 18);
		num2 = ((num >> 55) ^ (num2 << 9)) & 0x7FFFFFFFFFFFFFuL;
		num &= 0x7FFFFFFFFFFFFFuL;
		ulong num4 = CNLILOEEBOJ[0];
		ulong num5 = CNLILOEEBOJ[1];
		ulong num6 = CNLILOEEBOJ[2];
		num6 = (num5 >> 46) ^ (num6 << 18);
		num5 = ((num4 >> 55) ^ (num5 << 9)) & 0x7FFFFFFFFFFFFFuL;
		num4 &= 0x7FFFFFFFFFFFFFuL;
		ulong[] array = new ulong[10];
		CNIBNFGPHFD(num, num4, array, 0);
		CNIBNFGPHFD(num3, num6, array, 2);
		ulong num7 = num ^ num2 ^ num3;
		ulong num8 = num4 ^ num5 ^ num6;
		CNIBNFGPHFD(num7, num8, array, 4);
		ulong num9 = (num2 << 1) ^ (num3 << 2);
		ulong num10 = (num5 << 1) ^ (num6 << 2);
		CNIBNFGPHFD(num ^ num9, num4 ^ num10, array, 6);
		CNIBNFGPHFD(num7 ^ num9, num8 ^ num10, array, 8);
		ulong num11 = array[6] ^ array[8];
		ulong num12 = array[7] ^ array[9];
		ulong num13 = (num11 << 1) ^ array[6];
		ulong num14 = num11 ^ (num12 << 1) ^ array[7];
		ulong num15 = num12;
		ulong num16 = array[0];
		ulong num17 = array[1] ^ array[0] ^ array[4];
		ulong num18 = array[1] ^ array[5];
		ulong num19 = num16 ^ num13 ^ (array[2] << 4) ^ (array[2] << 1);
		ulong num20 = num17 ^ num14 ^ (array[3] << 4) ^ (array[3] << 1);
		ulong num21 = num18 ^ num15;
		num20 ^= num19 >> 55;
		num19 &= 0x7FFFFFFFFFFFFFuL;
		num21 ^= num20 >> 55;
		num20 &= 0x7FFFFFFFFFFFFFuL;
		num19 = (num19 >> 1) ^ ((num20 & 1) << 54);
		num20 = (num20 >> 1) ^ ((num21 & 1) << 54);
		num21 >>= 1;
		num19 ^= num19 << 1;
		num19 ^= num19 << 2;
		num19 ^= num19 << 4;
		num19 ^= num19 << 8;
		num19 ^= num19 << 16;
		num19 ^= num19 << 32;
		num19 &= 0x7FFFFFFFFFFFFFuL;
		num20 ^= num19 >> 54;
		num20 ^= num20 << 1;
		num20 ^= num20 << 2;
		num20 ^= num20 << 4;
		num20 ^= num20 << 8;
		num20 ^= num20 << 16;
		num20 ^= num20 << 32;
		num20 &= 0x7FFFFFFFFFFFFFuL;
		num21 ^= num20 >> 54;
		num21 ^= num21 << 1;
		num21 ^= num21 << 2;
		num21 ^= num21 << 4;
		num21 ^= num21 << 8;
		num21 ^= num21 << 16;
		num21 ^= num21 << 32;
		JMNJPLAGDDJ[0] = num16;
		JMNJPLAGDDJ[1] = num17 ^ num19 ^ array[2];
		JMNJPLAGDDJ[2] = num18 ^ num20 ^ num19 ^ array[3];
		JMNJPLAGDDJ[3] = num21 ^ num20;
		JMNJPLAGDDJ[4] = num21 ^ array[2];
		JMNJPLAGDDJ[5] = array[3];
		MFAKDNFHPLA(JMNJPLAGDDJ);
	}

	protected static void CNIBNFGPHFD(ulong AMFCENFNAJJ, ulong CNLILOEEBOJ, ulong[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong[] array = new ulong[8];
		array[1] = CNLILOEEBOJ;
		array[2] = array[1] << 1;
		array[3] = array[2] ^ CNLILOEEBOJ;
		array[4] = array[2] << 1;
		array[5] = array[4] ^ CNLILOEEBOJ;
		array[6] = array[3] << 1;
		array[7] = array[6] ^ CNLILOEEBOJ;
		uint num = (uint)AMFCENFNAJJ;
		ulong num2 = 0uL;
		ulong num3 = array[num & 3];
		int num4 = 47;
		do
		{
			num = (uint)(AMFCENFNAJJ >> num4);
			ulong num5 = array[num & 7] ^ (array[(num >> 3) & 7] << 3) ^ (array[(num >> 6) & 7] << 6);
			num3 ^= num5 << num4;
			num2 ^= num5 >> -num4;
		}
		while ((num4 -= 9) > 0);
		IGNEOOOFEMO[NDAAKFPMLOL] = num3 & 0x7FFFFFFFFFFFFFuL;
		IGNEOOOFEMO[NDAAKFPMLOL + 1] = (num3 >> 55) ^ (num2 << 9);
	}

	protected static void MMBGDFPOOKF(ulong[] AMFCENFNAJJ, ulong[] JMNJPLAGDDJ)
	{
		CKHAEFEPMDE.NILPKHOFBII(AMFCENFNAJJ[0], JMNJPLAGDDJ, 0);
		CKHAEFEPMDE.NILPKHOFBII(AMFCENFNAJJ[1], JMNJPLAGDDJ, 2);
		ulong num = AMFCENFNAJJ[2];
		JMNJPLAGDDJ[4] = CKHAEFEPMDE.BNODDEBMLOM((uint)num);
		JMNJPLAGDDJ[5] = CKHAEFEPMDE.FMNKAFMKNLH((uint)(num >> 32));
	}
}
