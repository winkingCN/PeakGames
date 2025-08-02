using System;
using Org.BouncyCastle.Math;

internal class CNJNDHIODLJ
{
	private const ulong HFLNIMLDMAL = 1uL;

	private const ulong LHGDPOCNNIH = 562949953421311uL;

	public static void JEACJNAKLDJ(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] IGNEOOOFEMO)
	{
		IGNEOOOFEMO[0] = AMFCENFNAJJ[0] ^ CNLILOEEBOJ[0];
		IGNEOOOFEMO[1] = AMFCENFNAJJ[1] ^ CNLILOEEBOJ[1];
		IGNEOOOFEMO[2] = AMFCENFNAJJ[2] ^ CNLILOEEBOJ[2];
		IGNEOOOFEMO[3] = AMFCENFNAJJ[3] ^ CNLILOEEBOJ[3];
	}

	public static void KGBEKKMEBCN(ulong[] HGHHJPDIMCI, ulong[] IKEIELCEKPD, ulong[] JMNJPLAGDDJ)
	{
		JMNJPLAGDDJ[0] = HGHHJPDIMCI[0] ^ IKEIELCEKPD[0];
		JMNJPLAGDDJ[1] = HGHHJPDIMCI[1] ^ IKEIELCEKPD[1];
		JMNJPLAGDDJ[2] = HGHHJPDIMCI[2] ^ IKEIELCEKPD[2];
		JMNJPLAGDDJ[3] = HGHHJPDIMCI[3] ^ IKEIELCEKPD[3];
		JMNJPLAGDDJ[4] = HGHHJPDIMCI[4] ^ IKEIELCEKPD[4];
		JMNJPLAGDDJ[5] = HGHHJPDIMCI[5] ^ IKEIELCEKPD[5];
		JMNJPLAGDDJ[6] = HGHHJPDIMCI[6] ^ IKEIELCEKPD[6];
	}

	public static void AOAINNMNBHC(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		IGNEOOOFEMO[0] = AMFCENFNAJJ[0] ^ 1;
		IGNEOOOFEMO[1] = AMFCENFNAJJ[1];
		IGNEOOOFEMO[2] = AMFCENFNAJJ[2];
		IGNEOOOFEMO[3] = AMFCENFNAJJ[3];
	}

	public static ulong[] HFENNGHNFLF(BigInteger AMFCENFNAJJ)
	{
		ulong[] array = AKOICJCJNFB.NCFBIELMPAA(AMFCENFNAJJ);
		HPBHAFEBFAH(array, 0);
		return array;
	}

	public static void LEIECFOMCNL(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		if (AKOICJCJNFB.NKNOMEDBEDI(AMFCENFNAJJ))
		{
			throw new InvalidOperationException();
		}
		ulong[] array = AKOICJCJNFB.JLMPJDKAODG();
		ulong[] array2 = AKOICJCJNFB.JLMPJDKAODG();
		MIOEHGDPGAG(AMFCENFNAJJ, array);
		OIEFGPHNOFN(array, 1, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array2, 1, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array, 3, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array, 6, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array, 12, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array, 24, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array, 48, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array, 96, array2);
		IBJBIGNPNEM(array, array2, IGNEOOOFEMO);
	}

	public static void IBJBIGNPNEM(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] IGNEOOOFEMO)
	{
		ulong[] array = AKOICJCJNFB.JFMBFIGDFCE();
		NEIMDHAFMNO(AMFCENFNAJJ, CNLILOEEBOJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
	}

	public static void OMJFFHEIEFH(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] JMNJPLAGDDJ)
	{
		ulong[] array = AKOICJCJNFB.JFMBFIGDFCE();
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
		ulong num7 = HGHHJPDIMCI[6];
		num3 ^= num7 << 63;
		num4 ^= (num7 >> 1) ^ (num7 << 14);
		num5 ^= num7 >> 50;
		num2 ^= num6 << 63;
		num3 ^= (num6 >> 1) ^ (num6 << 14);
		num4 ^= num6 >> 50;
		num ^= num5 << 63;
		num2 ^= (num5 >> 1) ^ (num5 << 14);
		num3 ^= num5 >> 50;
		ulong num8 = num4 >> 1;
		IGNEOOOFEMO[0] = num ^ num8 ^ (num8 << 15);
		IGNEOOOFEMO[1] = num2 ^ (num8 >> 49);
		IGNEOOOFEMO[2] = num3;
		IGNEOOOFEMO[3] = num4 & 1;
	}

	public static void HPBHAFEBFAH(ulong[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = IGNEOOOFEMO[NDAAKFPMLOL + 3];
		ulong num2 = num >> 1;
		IGNEOOOFEMO[NDAAKFPMLOL] ^= num2 ^ (num2 << 15);
		IGNEOOOFEMO[NDAAKFPMLOL + 1] ^= num2 >> 49;
		IGNEOOOFEMO[NDAAKFPMLOL + 3] = num & 1;
	}

	public static void PAEDNKEIDOM(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		ulong num = CKHAEFEPMDE.CHBDGGMNNFA(AMFCENFNAJJ[0]);
		ulong num2 = CKHAEFEPMDE.CHBDGGMNNFA(AMFCENFNAJJ[1]);
		ulong num3 = (num & 0xFFFFFFFFu) | (num2 << 32);
		ulong num4 = (num >> 32) | (num2 & 0xFFFFFFFF00000000uL);
		num = CKHAEFEPMDE.CHBDGGMNNFA(AMFCENFNAJJ[2]);
		ulong num5 = (num & 0xFFFFFFFFu) ^ (AMFCENFNAJJ[3] << 32);
		ulong num6 = num >> 32;
		IGNEOOOFEMO[0] = num3 ^ (num4 << 8);
		IGNEOOOFEMO[1] = num5 ^ (num6 << 8) ^ (num4 >> 56) ^ (num4 << 33);
		IGNEOOOFEMO[2] = (num6 >> 56) ^ (num6 << 33) ^ (num4 >> 31);
		IGNEOOOFEMO[3] = num6 >> 31;
	}

	public static void MIOEHGDPGAG(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		ulong[] array = AKOICJCJNFB.JFMBFIGDFCE();
		MMBGDFPOOKF(AMFCENFNAJJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
	}

	public static void OALFNDHHFAA(ulong[] AMFCENFNAJJ, ulong[] JMNJPLAGDDJ)
	{
		ulong[] array = AKOICJCJNFB.JFMBFIGDFCE();
		MMBGDFPOOKF(AMFCENFNAJJ, array);
		KGBEKKMEBCN(JMNJPLAGDDJ, array, JMNJPLAGDDJ);
	}

	public static void OIEFGPHNOFN(ulong[] AMFCENFNAJJ, int IDHLPOFDLKJ, ulong[] IGNEOOOFEMO)
	{
		ulong[] array = AKOICJCJNFB.JFMBFIGDFCE();
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
		return (uint)(int)AMFCENFNAJJ[0] & 1u;
	}

	protected static void MFAKDNFHPLA(ulong[] JMNJPLAGDDJ)
	{
		ulong num = JMNJPLAGDDJ[0];
		ulong num2 = JMNJPLAGDDJ[1];
		ulong num3 = JMNJPLAGDDJ[2];
		ulong num4 = JMNJPLAGDDJ[3];
		ulong num5 = JMNJPLAGDDJ[4];
		ulong num6 = JMNJPLAGDDJ[5];
		ulong num7 = JMNJPLAGDDJ[6];
		ulong num8 = JMNJPLAGDDJ[7];
		JMNJPLAGDDJ[0] = num ^ (num2 << 49);
		JMNJPLAGDDJ[1] = (num2 >> 15) ^ (num3 << 34);
		JMNJPLAGDDJ[2] = (num3 >> 30) ^ (num4 << 19);
		JMNJPLAGDDJ[3] = (num4 >> 45) ^ (num5 << 4) ^ (num6 << 53);
		JMNJPLAGDDJ[4] = (num5 >> 60) ^ (num7 << 38) ^ (num6 >> 11);
		JMNJPLAGDDJ[5] = (num7 >> 26) ^ (num8 << 23);
		JMNJPLAGDDJ[6] = num8 >> 41;
		JMNJPLAGDDJ[7] = 0uL;
	}

	protected static void DGMNOJOHHNB(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		ulong num = AMFCENFNAJJ[0];
		ulong num2 = AMFCENFNAJJ[1];
		ulong num3 = AMFCENFNAJJ[2];
		ulong num4 = AMFCENFNAJJ[3];
		IGNEOOOFEMO[0] = num & 0x1FFFFFFFFFFFFuL;
		IGNEOOOFEMO[1] = ((num >> 49) ^ (num2 << 15)) & 0x1FFFFFFFFFFFFuL;
		IGNEOOOFEMO[2] = ((num2 >> 34) ^ (num3 << 30)) & 0x1FFFFFFFFFFFFuL;
		IGNEOOOFEMO[3] = (num3 >> 19) ^ (num4 << 45);
	}

	protected static void NEIMDHAFMNO(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] JMNJPLAGDDJ)
	{
		ulong[] array = new ulong[4];
		ulong[] array2 = new ulong[4];
		DGMNOJOHHNB(AMFCENFNAJJ, array);
		DGMNOJOHHNB(CNLILOEEBOJ, array2);
		IOCCHBHEBFJ(array[0], array2[0], JMNJPLAGDDJ, 0);
		IOCCHBHEBFJ(array[1], array2[1], JMNJPLAGDDJ, 1);
		IOCCHBHEBFJ(array[2], array2[2], JMNJPLAGDDJ, 2);
		IOCCHBHEBFJ(array[3], array2[3], JMNJPLAGDDJ, 3);
		for (int num = 5; num > 0; num--)
		{
			JMNJPLAGDDJ[num] ^= JMNJPLAGDDJ[num - 1];
		}
		IOCCHBHEBFJ(array[0] ^ array[1], array2[0] ^ array2[1], JMNJPLAGDDJ, 1);
		IOCCHBHEBFJ(array[2] ^ array[3], array2[2] ^ array2[3], JMNJPLAGDDJ, 3);
		for (int num2 = 7; num2 > 1; num2--)
		{
			JMNJPLAGDDJ[num2] ^= JMNJPLAGDDJ[num2 - 2];
		}
		ulong num3 = array[0] ^ array[2];
		ulong num4 = array[1] ^ array[3];
		ulong num5 = array2[0] ^ array2[2];
		ulong num6 = array2[1] ^ array2[3];
		IOCCHBHEBFJ(num3 ^ num4, num5 ^ num6, JMNJPLAGDDJ, 3);
		ulong[] array3 = new ulong[3];
		IOCCHBHEBFJ(num3, num5, array3, 0);
		IOCCHBHEBFJ(num4, num6, array3, 1);
		ulong num7 = array3[0];
		ulong num8 = array3[1];
		ulong num9 = array3[2];
		JMNJPLAGDDJ[2] ^= num7;
		JMNJPLAGDDJ[3] ^= num7 ^ num8;
		JMNJPLAGDDJ[4] ^= num9 ^ num8;
		JMNJPLAGDDJ[5] ^= num9;
		MFAKDNFHPLA(JMNJPLAGDDJ);
	}

	protected static void IOCCHBHEBFJ(ulong AMFCENFNAJJ, ulong CNLILOEEBOJ, ulong[] IGNEOOOFEMO, int NDAAKFPMLOL)
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
		ulong num3 = array[num & 7] ^ (array[(num >> 3) & 7] << 3);
		int num4 = 36;
		do
		{
			num = (uint)(AMFCENFNAJJ >> num4);
			ulong num5 = array[num & 7] ^ (array[(num >> 3) & 7] << 3) ^ (array[(num >> 6) & 7] << 6) ^ (array[(num >> 9) & 7] << 9) ^ (array[(num >> 12) & 7] << 12);
			num3 ^= num5 << num4;
			num2 ^= num5 >> -num4;
		}
		while ((num4 -= 15) > 0);
		IGNEOOOFEMO[NDAAKFPMLOL] ^= num3 & 0x1FFFFFFFFFFFFL;
		IGNEOOOFEMO[NDAAKFPMLOL + 1] ^= (num3 >> 49) ^ (num2 << 15);
	}

	protected static void MMBGDFPOOKF(ulong[] AMFCENFNAJJ, ulong[] JMNJPLAGDDJ)
	{
		CKHAEFEPMDE.NILPKHOFBII(AMFCENFNAJJ[0], JMNJPLAGDDJ, 0);
		CKHAEFEPMDE.NILPKHOFBII(AMFCENFNAJJ[1], JMNJPLAGDDJ, 2);
		CKHAEFEPMDE.NILPKHOFBII(AMFCENFNAJJ[2], JMNJPLAGDDJ, 4);
		JMNJPLAGDDJ[6] = AMFCENFNAJJ[3] & 1;
	}
}
