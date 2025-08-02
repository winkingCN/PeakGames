using System;
using Org.BouncyCastle.Math;

internal class CGKKCLEDEDL
{
	private const ulong LHGDPOCNNIH = 562949953421311uL;

	private const ulong CEMFAFDFBKN = 144115188075855871uL;

	public static void JEACJNAKLDJ(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] IGNEOOOFEMO)
	{
		IGNEOOOFEMO[0] = AMFCENFNAJJ[0] ^ CNLILOEEBOJ[0];
		IGNEOOOFEMO[1] = AMFCENFNAJJ[1] ^ CNLILOEEBOJ[1];
	}

	public static void KGBEKKMEBCN(ulong[] HGHHJPDIMCI, ulong[] IKEIELCEKPD, ulong[] JMNJPLAGDDJ)
	{
		JMNJPLAGDDJ[0] = HGHHJPDIMCI[0] ^ IKEIELCEKPD[0];
		JMNJPLAGDDJ[1] = HGHHJPDIMCI[1] ^ IKEIELCEKPD[1];
		JMNJPLAGDDJ[2] = HGHHJPDIMCI[2] ^ IKEIELCEKPD[2];
		JMNJPLAGDDJ[3] = HGHHJPDIMCI[3] ^ IKEIELCEKPD[3];
	}

	public static void AOAINNMNBHC(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		IGNEOOOFEMO[0] = AMFCENFNAJJ[0] ^ 1;
		IGNEOOOFEMO[1] = AMFCENFNAJJ[1];
	}

	public static ulong[] HFENNGHNFLF(BigInteger AMFCENFNAJJ)
	{
		ulong[] array = LAFMGEKEGBF.NCFBIELMPAA(AMFCENFNAJJ);
		BIOEFDJDKFK(array, 0);
		return array;
	}

	public static void LEIECFOMCNL(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		if (LAFMGEKEGBF.NKNOMEDBEDI(AMFCENFNAJJ))
		{
			throw new InvalidOperationException();
		}
		ulong[] array = LAFMGEKEGBF.JLMPJDKAODG();
		ulong[] array2 = LAFMGEKEGBF.JLMPJDKAODG();
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
		OIEFGPHNOFN(array2, 28, array);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array, 56, array2);
		IBJBIGNPNEM(array2, array, array2);
		MIOEHGDPGAG(array2, IGNEOOOFEMO);
	}

	public static void IBJBIGNPNEM(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] IGNEOOOFEMO)
	{
		ulong[] array = LAFMGEKEGBF.JFMBFIGDFCE();
		NEIMDHAFMNO(AMFCENFNAJJ, CNLILOEEBOJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
	}

	public static void OMJFFHEIEFH(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] JMNJPLAGDDJ)
	{
		ulong[] array = LAFMGEKEGBF.JFMBFIGDFCE();
		NEIMDHAFMNO(AMFCENFNAJJ, CNLILOEEBOJ, array);
		KGBEKKMEBCN(JMNJPLAGDDJ, array, JMNJPLAGDDJ);
	}

	public static void BKCHMGKFECM(ulong[] HGHHJPDIMCI, ulong[] IGNEOOOFEMO)
	{
		ulong num = HGHHJPDIMCI[0];
		ulong num2 = HGHHJPDIMCI[1];
		ulong num3 = HGHHJPDIMCI[2];
		ulong num4 = HGHHJPDIMCI[3];
		num2 ^= (num4 << 15) ^ (num4 << 24);
		num3 ^= (num4 >> 49) ^ (num4 >> 40);
		num ^= (num3 << 15) ^ (num3 << 24);
		num2 ^= (num3 >> 49) ^ (num3 >> 40);
		ulong num5 = num2 >> 49;
		IGNEOOOFEMO[0] = num ^ num5 ^ (num5 << 9);
		IGNEOOOFEMO[1] = num2 & 0x1FFFFFFFFFFFFuL;
	}

	public static void BIOEFDJDKFK(ulong[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = IGNEOOOFEMO[NDAAKFPMLOL + 1];
		ulong num2 = num >> 49;
		IGNEOOOFEMO[NDAAKFPMLOL] ^= num2 ^ (num2 << 9);
		IGNEOOOFEMO[NDAAKFPMLOL + 1] = num & 0x1FFFFFFFFFFFFuL;
	}

	public static void PAEDNKEIDOM(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		ulong num = CKHAEFEPMDE.CHBDGGMNNFA(AMFCENFNAJJ[0]);
		ulong num2 = CKHAEFEPMDE.CHBDGGMNNFA(AMFCENFNAJJ[1]);
		ulong num3 = (num & 0xFFFFFFFFu) | (num2 << 32);
		ulong num4 = (num >> 32) | (num2 & 0xFFFFFFFF00000000uL);
		IGNEOOOFEMO[0] = num3 ^ (num4 << 57) ^ (num4 << 5);
		IGNEOOOFEMO[1] = (num4 >> 7) ^ (num4 >> 59);
	}

	public static void MIOEHGDPGAG(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		ulong[] array = LAFMGEKEGBF.JFMBFIGDFCE();
		MMBGDFPOOKF(AMFCENFNAJJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
	}

	public static void OALFNDHHFAA(ulong[] AMFCENFNAJJ, ulong[] JMNJPLAGDDJ)
	{
		ulong[] array = LAFMGEKEGBF.JFMBFIGDFCE();
		MMBGDFPOOKF(AMFCENFNAJJ, array);
		KGBEKKMEBCN(JMNJPLAGDDJ, array, JMNJPLAGDDJ);
	}

	public static void OIEFGPHNOFN(ulong[] AMFCENFNAJJ, int IDHLPOFDLKJ, ulong[] IGNEOOOFEMO)
	{
		ulong[] array = LAFMGEKEGBF.JFMBFIGDFCE();
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

	protected static void NEIMDHAFMNO(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] JMNJPLAGDDJ)
	{
		ulong num = AMFCENFNAJJ[0];
		ulong num2 = AMFCENFNAJJ[1];
		num2 = ((num >> 57) ^ (num2 << 7)) & 0x1FFFFFFFFFFFFFFuL;
		num &= 0x1FFFFFFFFFFFFFFuL;
		ulong num3 = CNLILOEEBOJ[0];
		ulong num4 = CNLILOEEBOJ[1];
		num4 = ((num3 >> 57) ^ (num4 << 7)) & 0x1FFFFFFFFFFFFFFuL;
		num3 &= 0x1FFFFFFFFFFFFFFuL;
		ulong[] array = new ulong[6];
		CNIBNFGPHFD(num, num3, array, 0);
		CNIBNFGPHFD(num2, num4, array, 2);
		CNIBNFGPHFD(num ^ num2, num3 ^ num4, array, 4);
		ulong num5 = array[1] ^ array[2];
		ulong num6 = array[0];
		ulong num7 = array[3];
		ulong num8 = array[4] ^ num6 ^ num5;
		ulong num9 = array[5] ^ num7 ^ num5;
		JMNJPLAGDDJ[0] = num6 ^ (num8 << 57);
		JMNJPLAGDDJ[1] = (num8 >> 7) ^ (num9 << 50);
		JMNJPLAGDDJ[2] = (num9 >> 14) ^ (num7 << 43);
		JMNJPLAGDDJ[3] = num7 >> 21;
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
		ulong num3 = array[num & 7];
		int num4 = 48;
		do
		{
			num = (uint)(AMFCENFNAJJ >> num4);
			ulong num5 = array[num & 7] ^ (array[(num >> 3) & 7] << 3) ^ (array[(num >> 6) & 7] << 6);
			num3 ^= num5 << num4;
			num2 ^= num5 >> -num4;
		}
		while ((num4 -= 9) > 0);
		num2 ^= (AMFCENFNAJJ & 0x100804020100800L & (ulong)((long)(CNLILOEEBOJ << 7) >> 63)) >> 8;
		IGNEOOOFEMO[NDAAKFPMLOL] = num3 & 0x1FFFFFFFFFFFFFFuL;
		IGNEOOOFEMO[NDAAKFPMLOL + 1] = (num3 >> 57) ^ (num2 << 7);
	}

	protected static void MMBGDFPOOKF(ulong[] AMFCENFNAJJ, ulong[] JMNJPLAGDDJ)
	{
		CKHAEFEPMDE.NILPKHOFBII(AMFCENFNAJJ[0], JMNJPLAGDDJ, 0);
		CKHAEFEPMDE.NILPKHOFBII(AMFCENFNAJJ[1], JMNJPLAGDDJ, 2);
	}
}
