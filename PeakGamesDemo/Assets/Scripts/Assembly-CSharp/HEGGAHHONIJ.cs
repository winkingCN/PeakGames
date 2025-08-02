using System;
using Org.BouncyCastle.Math;

internal class HEGGAHHONIJ
{
	private const ulong HIPDPLAGKED = 7uL;

	private const ulong FNCDFFIIIGG = 17592186044415uL;

	private static readonly ulong[] KGNHHCIOEBC = new ulong[3] { 2791191049453778211uL, 2791191049453778402uL, 6uL };

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
		CEHJDADPCGD(array, 0);
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
		IBJBIGNPNEM(array, AMFCENFNAJJ, array);
		OIEFGPHNOFN(array, 2, array2);
		IBJBIGNPNEM(array2, array, array2);
		OIEFGPHNOFN(array2, 4, array);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array, 8, array2);
		IBJBIGNPNEM(array2, array, array2);
		OIEFGPHNOFN(array2, 16, array);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array, 32, array2);
		IBJBIGNPNEM(array2, array, array2);
		MIOEHGDPGAG(array2, array2);
		IBJBIGNPNEM(array2, AMFCENFNAJJ, array2);
		OIEFGPHNOFN(array2, 65, array);
		IBJBIGNPNEM(array, array2, array);
		MIOEHGDPGAG(array, IGNEOOOFEMO);
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
		num2 ^= (num5 << 61) ^ (num5 << 63);
		num3 ^= (num5 >> 3) ^ (num5 >> 1) ^ num5 ^ (num5 << 5);
		num4 ^= num5 >> 59;
		num ^= (num4 << 61) ^ (num4 << 63);
		num2 ^= (num4 >> 3) ^ (num4 >> 1) ^ num4 ^ (num4 << 5);
		num3 ^= num4 >> 59;
		ulong num6 = num3 >> 3;
		IGNEOOOFEMO[0] = num ^ num6 ^ (num6 << 2) ^ (num6 << 3) ^ (num6 << 8);
		IGNEOOOFEMO[1] = num2 ^ (num6 >> 56);
		IGNEOOOFEMO[2] = num3 & 7;
	}

	public static void CEHJDADPCGD(ulong[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = IGNEOOOFEMO[NDAAKFPMLOL + 2];
		ulong num2 = num >> 3;
		IGNEOOOFEMO[NDAAKFPMLOL] ^= num2 ^ (num2 << 2) ^ (num2 << 3) ^ (num2 << 8);
		IGNEOOOFEMO[NDAAKFPMLOL + 1] ^= num2 >> 56;
		IGNEOOOFEMO[NDAAKFPMLOL + 2] = num & 7;
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
		ulong[] array = BCMDHIIJKJE.JLMPJDKAODG(5);
		MMBGDFPOOKF(AMFCENFNAJJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
	}

	public static void OALFNDHHFAA(ulong[] AMFCENFNAJJ, ulong[] JMNJPLAGDDJ)
	{
		ulong[] array = BCMDHIIJKJE.JLMPJDKAODG(5);
		MMBGDFPOOKF(AMFCENFNAJJ, array);
		KGBEKKMEBCN(JMNJPLAGDDJ, array, JMNJPLAGDDJ);
	}

	public static void OIEFGPHNOFN(ulong[] AMFCENFNAJJ, int IDHLPOFDLKJ, ulong[] IGNEOOOFEMO)
	{
		ulong[] array = BCMDHIIJKJE.JLMPJDKAODG(5);
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
		return (uint)(int)(AMFCENFNAJJ[0] ^ (AMFCENFNAJJ[1] >> 59) ^ (AMFCENFNAJJ[2] >> 1)) & 1u;
	}

	protected static void MFAKDNFHPLA(ulong[] JMNJPLAGDDJ)
	{
		ulong num = JMNJPLAGDDJ[0];
		ulong num2 = JMNJPLAGDDJ[1];
		ulong num3 = JMNJPLAGDDJ[2];
		ulong num4 = JMNJPLAGDDJ[3];
		ulong num5 = JMNJPLAGDDJ[4];
		ulong num6 = JMNJPLAGDDJ[5];
		JMNJPLAGDDJ[0] = num ^ (num2 << 44);
		JMNJPLAGDDJ[1] = (num2 >> 20) ^ (num3 << 24);
		JMNJPLAGDDJ[2] = (num3 >> 40) ^ (num4 << 4) ^ (num5 << 48);
		JMNJPLAGDDJ[3] = (num4 >> 60) ^ (num6 << 28) ^ (num5 >> 16);
		JMNJPLAGDDJ[4] = num6 >> 36;
		JMNJPLAGDDJ[5] = 0uL;
	}

	protected static void NEIMDHAFMNO(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] JMNJPLAGDDJ)
	{
		ulong num = AMFCENFNAJJ[0];
		ulong num2 = AMFCENFNAJJ[1];
		ulong num3 = AMFCENFNAJJ[2];
		num3 = ((num2 >> 24) ^ (num3 << 40)) & 0xFFFFFFFFFFFuL;
		num2 = ((num >> 44) ^ (num2 << 20)) & 0xFFFFFFFFFFFuL;
		num &= 0xFFFFFFFFFFFuL;
		ulong num4 = CNLILOEEBOJ[0];
		ulong num5 = CNLILOEEBOJ[1];
		ulong num6 = CNLILOEEBOJ[2];
		num6 = ((num5 >> 24) ^ (num6 << 40)) & 0xFFFFFFFFFFFuL;
		num5 = ((num4 >> 44) ^ (num5 << 20)) & 0xFFFFFFFFFFFuL;
		num4 &= 0xFFFFFFFFFFFuL;
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
		num20 ^= num19 >> 44;
		num19 &= 0xFFFFFFFFFFFuL;
		num21 ^= num20 >> 44;
		num20 &= 0xFFFFFFFFFFFuL;
		num19 = (num19 >> 1) ^ ((num20 & 1) << 43);
		num20 = (num20 >> 1) ^ ((num21 & 1) << 43);
		num21 >>= 1;
		num19 ^= num19 << 1;
		num19 ^= num19 << 2;
		num19 ^= num19 << 4;
		num19 ^= num19 << 8;
		num19 ^= num19 << 16;
		num19 ^= num19 << 32;
		num19 &= 0xFFFFFFFFFFFuL;
		num20 ^= num19 >> 43;
		num20 ^= num20 << 1;
		num20 ^= num20 << 2;
		num20 ^= num20 << 4;
		num20 ^= num20 << 8;
		num20 ^= num20 << 16;
		num20 ^= num20 << 32;
		num20 &= 0xFFFFFFFFFFFuL;
		num21 ^= num20 >> 43;
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
		ulong num3 = array[num & 7] ^ (array[(num >> 3) & 7] << 3) ^ (array[(num >> 6) & 7] << 6);
		int num4 = 33;
		do
		{
			num = (uint)(AMFCENFNAJJ >> num4);
			ulong num5 = array[num & 7] ^ (array[(num >> 3) & 7] << 3) ^ (array[(num >> 6) & 7] << 6) ^ (array[(num >> 9) & 7] << 9);
			num3 ^= num5 << num4;
			num2 ^= num5 >> -num4;
		}
		while ((num4 -= 12) > 0);
		IGNEOOOFEMO[NDAAKFPMLOL] = num3 & 0xFFFFFFFFFFFuL;
		IGNEOOOFEMO[NDAAKFPMLOL + 1] = (num3 >> 44) ^ (num2 << 20);
	}

	protected static void MMBGDFPOOKF(ulong[] AMFCENFNAJJ, ulong[] JMNJPLAGDDJ)
	{
		CKHAEFEPMDE.NILPKHOFBII(AMFCENFNAJJ[0], JMNJPLAGDDJ, 0);
		CKHAEFEPMDE.NILPKHOFBII(AMFCENFNAJJ[1], JMNJPLAGDDJ, 2);
		JMNJPLAGDDJ[4] = CKHAEFEPMDE.FMNKAFMKNLH((uint)AMFCENFNAJJ[2]);
	}
}
