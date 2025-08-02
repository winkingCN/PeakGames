using System;
using Org.BouncyCastle.Math;

internal class NDCMHJHOLJP
{
	private const ulong HNBNFIOFGNH = 2199023255551uL;

	private const ulong CFHCFIGNOIM = 576460752303423487uL;

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
		JMNJPLAGDDJ[7] = HGHHJPDIMCI[7] ^ IKEIELCEKPD[7];
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
		LJNDDEIFKPD(array, 0);
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
		IBJBIGNPNEM(array, AMFCENFNAJJ, array);
		MIOEHGDPGAG(array, array);
		IBJBIGNPNEM(array, AMFCENFNAJJ, array);
		OIEFGPHNOFN(array, 3, array2);
		IBJBIGNPNEM(array2, array, array2);
		MIOEHGDPGAG(array2, array2);
		IBJBIGNPNEM(array2, AMFCENFNAJJ, array2);
		OIEFGPHNOFN(array2, 7, array);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array, 14, array2);
		IBJBIGNPNEM(array2, array, array2);
		MIOEHGDPGAG(array2, array2);
		IBJBIGNPNEM(array2, AMFCENFNAJJ, array2);
		OIEFGPHNOFN(array2, 29, array);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array, 58, array2);
		IBJBIGNPNEM(array2, array, array2);
		OIEFGPHNOFN(array2, 116, array);
		IBJBIGNPNEM(array, array2, array);
		MIOEHGDPGAG(array, IGNEOOOFEMO);
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
		ulong num8 = HGHHJPDIMCI[7];
		num4 ^= num8 << 23;
		num5 ^= (num8 >> 41) ^ (num8 << 33);
		num6 ^= num8 >> 31;
		num3 ^= num7 << 23;
		num4 ^= (num7 >> 41) ^ (num7 << 33);
		num5 ^= num7 >> 31;
		num2 ^= num6 << 23;
		num3 ^= (num6 >> 41) ^ (num6 << 33);
		num4 ^= num6 >> 31;
		num ^= num5 << 23;
		num2 ^= (num5 >> 41) ^ (num5 << 33);
		num3 ^= num5 >> 31;
		ulong num9 = num4 >> 41;
		IGNEOOOFEMO[0] = num ^ num9;
		IGNEOOOFEMO[1] = num2 ^ (num9 << 10);
		IGNEOOOFEMO[2] = num3;
		IGNEOOOFEMO[3] = num4 & 0x1FFFFFFFFFFuL;
	}

	public static void LJNDDEIFKPD(ulong[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = IGNEOOOFEMO[NDAAKFPMLOL + 3];
		ulong num2 = num >> 41;
		IGNEOOOFEMO[NDAAKFPMLOL] ^= num2;
		IGNEOOOFEMO[NDAAKFPMLOL + 1] ^= num2 << 10;
		IGNEOOOFEMO[NDAAKFPMLOL + 3] = num & 0x1FFFFFFFFFFuL;
	}

	public static void PAEDNKEIDOM(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		ulong num = CKHAEFEPMDE.CHBDGGMNNFA(AMFCENFNAJJ[0]);
		ulong num2 = CKHAEFEPMDE.CHBDGGMNNFA(AMFCENFNAJJ[1]);
		ulong num3 = (num & 0xFFFFFFFFu) | (num2 << 32);
		ulong num4 = (num >> 32) | (num2 & 0xFFFFFFFF00000000uL);
		num = CKHAEFEPMDE.CHBDGGMNNFA(AMFCENFNAJJ[2]);
		num2 = CKHAEFEPMDE.CHBDGGMNNFA(AMFCENFNAJJ[3]);
		ulong num5 = (num & 0xFFFFFFFFu) | (num2 << 32);
		ulong num6 = (num >> 32) | (num2 & 0xFFFFFFFF00000000uL);
		ulong num7 = num6 >> 27;
		num6 ^= (num4 >> 27) | (num6 << 37);
		num4 ^= num4 << 37;
		ulong[] array = AKOICJCJNFB.JFMBFIGDFCE();
		int[] array2 = new int[3] { 32, 117, 191 };
		for (int i = 0; i < array2.Length; i++)
		{
			int num8 = array2[i] >> 6;
			int num9 = array2[i] & 0x3F;
			array[num8] ^= num4 << num9;
			array[num8 + 1] ^= (num6 << num9) | (num4 >> -num9);
			array[num8 + 2] ^= (num7 << num9) | (num6 >> -num9);
			array[num8 + 3] ^= num7 >> -num9;
		}
		BKCHMGKFECM(array, IGNEOOOFEMO);
		IGNEOOOFEMO[0] ^= num3;
		IGNEOOOFEMO[1] ^= num5;
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
		return (uint)(int)(AMFCENFNAJJ[0] ^ (AMFCENFNAJJ[2] >> 31)) & 1u;
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
		JMNJPLAGDDJ[0] = num ^ (num2 << 59);
		JMNJPLAGDDJ[1] = (num2 >> 5) ^ (num3 << 54);
		JMNJPLAGDDJ[2] = (num3 >> 10) ^ (num4 << 49);
		JMNJPLAGDDJ[3] = (num4 >> 15) ^ (num5 << 44);
		JMNJPLAGDDJ[4] = (num5 >> 20) ^ (num6 << 39);
		JMNJPLAGDDJ[5] = (num6 >> 25) ^ (num7 << 34);
		JMNJPLAGDDJ[6] = (num7 >> 30) ^ (num8 << 29);
		JMNJPLAGDDJ[7] = num8 >> 35;
	}

	protected static void DGMNOJOHHNB(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		ulong num = AMFCENFNAJJ[0];
		ulong num2 = AMFCENFNAJJ[1];
		ulong num3 = AMFCENFNAJJ[2];
		ulong num4 = AMFCENFNAJJ[3];
		IGNEOOOFEMO[0] = num & 0x7FFFFFFFFFFFFFFuL;
		IGNEOOOFEMO[1] = ((num >> 59) ^ (num2 << 5)) & 0x7FFFFFFFFFFFFFFuL;
		IGNEOOOFEMO[2] = ((num2 >> 54) ^ (num3 << 10)) & 0x7FFFFFFFFFFFFFFuL;
		IGNEOOOFEMO[3] = (num3 >> 49) ^ (num4 << 15);
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
		int num4 = 54;
		do
		{
			num = (uint)(AMFCENFNAJJ >> num4);
			ulong num5 = array[num & 7] ^ (array[(num >> 3) & 7] << 3);
			num3 ^= num5 << num4;
			num2 ^= num5 >> -num4;
		}
		while ((num4 -= 6) > 0);
		IGNEOOOFEMO[NDAAKFPMLOL] ^= num3 & 0x7FFFFFFFFFFFFFFL;
		IGNEOOOFEMO[NDAAKFPMLOL + 1] ^= (num3 >> 59) ^ (num2 << 5);
	}

	protected static void MMBGDFPOOKF(ulong[] AMFCENFNAJJ, ulong[] JMNJPLAGDDJ)
	{
		CKHAEFEPMDE.NILPKHOFBII(AMFCENFNAJJ[0], JMNJPLAGDDJ, 0);
		CKHAEFEPMDE.NILPKHOFBII(AMFCENFNAJJ[1], JMNJPLAGDDJ, 2);
		CKHAEFEPMDE.NILPKHOFBII(AMFCENFNAJJ[2], JMNJPLAGDDJ, 4);
		ulong num = AMFCENFNAJJ[3];
		JMNJPLAGDDJ[6] = CKHAEFEPMDE.BNODDEBMLOM((uint)num);
		JMNJPLAGDDJ[7] = CKHAEFEPMDE.OJEPCJEJJPL((uint)(num >> 32));
	}
}
