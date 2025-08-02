using System;
using Org.BouncyCastle.Math;

internal class OHFOBGJKMAH
{
	private const ulong KADHJCDDFMP = 33554431uL;

	private const ulong CFHCFIGNOIM = 576460752303423487uL;

	public static void JEACJNAKLDJ(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] IGNEOOOFEMO)
	{
		IGNEOOOFEMO[0] = AMFCENFNAJJ[0] ^ CNLILOEEBOJ[0];
		IGNEOOOFEMO[1] = AMFCENFNAJJ[1] ^ CNLILOEEBOJ[1];
		IGNEOOOFEMO[2] = AMFCENFNAJJ[2] ^ CNLILOEEBOJ[2];
		IGNEOOOFEMO[3] = AMFCENFNAJJ[3] ^ CNLILOEEBOJ[3];
		IGNEOOOFEMO[4] = AMFCENFNAJJ[4] ^ CNLILOEEBOJ[4];
		IGNEOOOFEMO[5] = AMFCENFNAJJ[5] ^ CNLILOEEBOJ[5];
		IGNEOOOFEMO[6] = AMFCENFNAJJ[6] ^ CNLILOEEBOJ[6];
	}

	public static void KGBEKKMEBCN(ulong[] HGHHJPDIMCI, ulong[] IKEIELCEKPD, ulong[] JMNJPLAGDDJ)
	{
		for (int i = 0; i < 13; i++)
		{
			JMNJPLAGDDJ[i] = HGHHJPDIMCI[i] ^ IKEIELCEKPD[i];
		}
	}

	public static void AOAINNMNBHC(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		IGNEOOOFEMO[0] = AMFCENFNAJJ[0] ^ 1;
		IGNEOOOFEMO[1] = AMFCENFNAJJ[1];
		IGNEOOOFEMO[2] = AMFCENFNAJJ[2];
		IGNEOOOFEMO[3] = AMFCENFNAJJ[3];
		IGNEOOOFEMO[4] = AMFCENFNAJJ[4];
		IGNEOOOFEMO[5] = AMFCENFNAJJ[5];
		IGNEOOOFEMO[6] = AMFCENFNAJJ[6];
	}

	public static ulong[] HFENNGHNFLF(BigInteger AMFCENFNAJJ)
	{
		ulong[] array = KAPHDADJNME.NCFBIELMPAA(AMFCENFNAJJ);
		CNCLDMEMOEP(array, 0);
		return array;
	}

	public static void LEIECFOMCNL(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		if (KAPHDADJNME.NKNOMEDBEDI(AMFCENFNAJJ))
		{
			throw new InvalidOperationException();
		}
		ulong[] array = KAPHDADJNME.JLMPJDKAODG();
		ulong[] array2 = KAPHDADJNME.JLMPJDKAODG();
		ulong[] array3 = KAPHDADJNME.JLMPJDKAODG();
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
		IBJBIGNPNEM(array, array2, array3);
		OIEFGPHNOFN(array3, 24, array);
		OIEFGPHNOFN(array, 24, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array, 48, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array, 96, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array, 192, array2);
		IBJBIGNPNEM(array, array2, array);
		IBJBIGNPNEM(array, array3, IGNEOOOFEMO);
	}

	public static void IBJBIGNPNEM(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] IGNEOOOFEMO)
	{
		ulong[] array = KAPHDADJNME.JFMBFIGDFCE();
		NEIMDHAFMNO(AMFCENFNAJJ, CNLILOEEBOJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
	}

	public static void OMJFFHEIEFH(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] JMNJPLAGDDJ)
	{
		ulong[] array = KAPHDADJNME.JFMBFIGDFCE();
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
		ulong num9 = HGHHJPDIMCI[12];
		num6 ^= num9 << 39;
		num7 ^= (num9 >> 25) ^ (num9 << 62);
		num8 ^= num9 >> 2;
		num9 = HGHHJPDIMCI[11];
		num5 ^= num9 << 39;
		num6 ^= (num9 >> 25) ^ (num9 << 62);
		num7 ^= num9 >> 2;
		num9 = HGHHJPDIMCI[10];
		num4 ^= num9 << 39;
		num5 ^= (num9 >> 25) ^ (num9 << 62);
		num6 ^= num9 >> 2;
		num9 = HGHHJPDIMCI[9];
		num3 ^= num9 << 39;
		num4 ^= (num9 >> 25) ^ (num9 << 62);
		num5 ^= num9 >> 2;
		num9 = HGHHJPDIMCI[8];
		num2 ^= num9 << 39;
		num3 ^= (num9 >> 25) ^ (num9 << 62);
		num4 ^= num9 >> 2;
		num9 = num8;
		num ^= num9 << 39;
		num2 ^= (num9 >> 25) ^ (num9 << 62);
		num3 ^= num9 >> 2;
		ulong num10 = num7 >> 25;
		IGNEOOOFEMO[0] = num ^ num10;
		IGNEOOOFEMO[1] = num2 ^ (num10 << 23);
		IGNEOOOFEMO[2] = num3;
		IGNEOOOFEMO[3] = num4;
		IGNEOOOFEMO[4] = num5;
		IGNEOOOFEMO[5] = num6;
		IGNEOOOFEMO[6] = num7 & 0x1FFFFFF;
	}

	public static void CNCLDMEMOEP(ulong[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = IGNEOOOFEMO[NDAAKFPMLOL + 6];
		ulong num2 = num >> 25;
		IGNEOOOFEMO[NDAAKFPMLOL] ^= num2;
		IGNEOOOFEMO[NDAAKFPMLOL + 1] ^= num2 << 23;
		IGNEOOOFEMO[NDAAKFPMLOL + 6] = num & 0x1FFFFFF;
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
		num = CKHAEFEPMDE.CHBDGGMNNFA(AMFCENFNAJJ[4]);
		num2 = CKHAEFEPMDE.CHBDGGMNNFA(AMFCENFNAJJ[5]);
		ulong num7 = (num & 0xFFFFFFFFu) | (num2 << 32);
		ulong num8 = (num >> 32) | (num2 & 0xFFFFFFFF00000000uL);
		num = CKHAEFEPMDE.CHBDGGMNNFA(AMFCENFNAJJ[6]);
		ulong num9 = num & 0xFFFFFFFFu;
		ulong num10 = num >> 32;
		IGNEOOOFEMO[0] = num3 ^ (num4 << 44);
		IGNEOOOFEMO[1] = num5 ^ (num6 << 44) ^ (num4 >> 20);
		IGNEOOOFEMO[2] = num7 ^ (num8 << 44) ^ (num6 >> 20);
		IGNEOOOFEMO[3] = num9 ^ (num10 << 44) ^ (num8 >> 20) ^ (num4 << 13);
		IGNEOOOFEMO[4] = (num10 >> 20) ^ (num6 << 13) ^ (num4 >> 51);
		IGNEOOOFEMO[5] = (num8 << 13) ^ (num6 >> 51);
		IGNEOOOFEMO[6] = (num10 << 13) ^ (num8 >> 51);
	}

	public static void MIOEHGDPGAG(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		ulong[] array = BCMDHIIJKJE.JLMPJDKAODG(13);
		MMBGDFPOOKF(AMFCENFNAJJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
	}

	public static void OALFNDHHFAA(ulong[] AMFCENFNAJJ, ulong[] JMNJPLAGDDJ)
	{
		ulong[] array = BCMDHIIJKJE.JLMPJDKAODG(13);
		MMBGDFPOOKF(AMFCENFNAJJ, array);
		KGBEKKMEBCN(JMNJPLAGDDJ, array, JMNJPLAGDDJ);
	}

	public static void OIEFGPHNOFN(ulong[] AMFCENFNAJJ, int IDHLPOFDLKJ, ulong[] IGNEOOOFEMO)
	{
		ulong[] array = BCMDHIIJKJE.JLMPJDKAODG(13);
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
		ulong num9 = JMNJPLAGDDJ[8];
		ulong num10 = JMNJPLAGDDJ[9];
		ulong num11 = JMNJPLAGDDJ[10];
		ulong num12 = JMNJPLAGDDJ[11];
		ulong num13 = JMNJPLAGDDJ[12];
		ulong num14 = JMNJPLAGDDJ[13];
		JMNJPLAGDDJ[0] = num ^ (num2 << 59);
		JMNJPLAGDDJ[1] = (num2 >> 5) ^ (num3 << 54);
		JMNJPLAGDDJ[2] = (num3 >> 10) ^ (num4 << 49);
		JMNJPLAGDDJ[3] = (num4 >> 15) ^ (num5 << 44);
		JMNJPLAGDDJ[4] = (num5 >> 20) ^ (num6 << 39);
		JMNJPLAGDDJ[5] = (num6 >> 25) ^ (num7 << 34);
		JMNJPLAGDDJ[6] = (num7 >> 30) ^ (num8 << 29);
		JMNJPLAGDDJ[7] = (num8 >> 35) ^ (num9 << 24);
		JMNJPLAGDDJ[8] = (num9 >> 40) ^ (num10 << 19);
		JMNJPLAGDDJ[9] = (num10 >> 45) ^ (num11 << 14);
		JMNJPLAGDDJ[10] = (num11 >> 50) ^ (num12 << 9);
		JMNJPLAGDDJ[11] = (num12 >> 55) ^ (num13 << 4) ^ (num14 << 63);
		JMNJPLAGDDJ[12] = (num13 >> 60) ^ (num14 >> 1);
		JMNJPLAGDDJ[13] = 0uL;
	}

	protected static void DGMNOJOHHNB(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		ulong num = AMFCENFNAJJ[0];
		ulong num2 = AMFCENFNAJJ[1];
		ulong num3 = AMFCENFNAJJ[2];
		ulong num4 = AMFCENFNAJJ[3];
		ulong num5 = AMFCENFNAJJ[4];
		ulong num6 = AMFCENFNAJJ[5];
		ulong num7 = AMFCENFNAJJ[6];
		IGNEOOOFEMO[0] = num & 0x7FFFFFFFFFFFFFFuL;
		IGNEOOOFEMO[1] = ((num >> 59) ^ (num2 << 5)) & 0x7FFFFFFFFFFFFFFuL;
		IGNEOOOFEMO[2] = ((num2 >> 54) ^ (num3 << 10)) & 0x7FFFFFFFFFFFFFFuL;
		IGNEOOOFEMO[3] = ((num3 >> 49) ^ (num4 << 15)) & 0x7FFFFFFFFFFFFFFuL;
		IGNEOOOFEMO[4] = ((num4 >> 44) ^ (num5 << 20)) & 0x7FFFFFFFFFFFFFFuL;
		IGNEOOOFEMO[5] = ((num5 >> 39) ^ (num6 << 25)) & 0x7FFFFFFFFFFFFFFuL;
		IGNEOOOFEMO[6] = (num6 >> 34) ^ (num7 << 30);
	}

	protected static void NEIMDHAFMNO(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] JMNJPLAGDDJ)
	{
		ulong[] array = new ulong[7];
		ulong[] array2 = new ulong[7];
		DGMNOJOHHNB(AMFCENFNAJJ, array);
		DGMNOJOHHNB(CNLILOEEBOJ, array2);
		for (int i = 0; i < 7; i++)
		{
			IOCCHBHEBFJ(array, array2[i], JMNJPLAGDDJ, i);
		}
		MFAKDNFHPLA(JMNJPLAGDDJ);
	}

	protected static void IOCCHBHEBFJ(ulong[] BMOHGJOJLOL, ulong CNLILOEEBOJ, ulong[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong[] array = new ulong[8];
		array[1] = CNLILOEEBOJ;
		array[2] = array[1] << 1;
		array[3] = array[2] ^ CNLILOEEBOJ;
		array[4] = array[2] << 1;
		array[5] = array[4] ^ CNLILOEEBOJ;
		array[6] = array[3] << 1;
		array[7] = array[6] ^ CNLILOEEBOJ;
		for (int i = 0; i < 7; i++)
		{
			ulong num = BMOHGJOJLOL[i];
			uint num2 = (uint)num;
			ulong num3 = 0uL;
			ulong num4 = array[num2 & 7] ^ (array[(num2 >> 3) & 7] << 3);
			int num5 = 54;
			do
			{
				num2 = (uint)(num >> num5);
				ulong num6 = array[num2 & 7] ^ (array[(num2 >> 3) & 7] << 3);
				num4 ^= num6 << num5;
				num3 ^= num6 >> -num5;
			}
			while ((num5 -= 6) > 0);
			IGNEOOOFEMO[NDAAKFPMLOL + i] ^= num4 & 0x7FFFFFFFFFFFFFFL;
			IGNEOOOFEMO[NDAAKFPMLOL + i + 1] ^= (num4 >> 59) ^ (num3 << 5);
		}
	}

	protected static void MMBGDFPOOKF(ulong[] AMFCENFNAJJ, ulong[] JMNJPLAGDDJ)
	{
		for (int i = 0; i < 6; i++)
		{
			CKHAEFEPMDE.NILPKHOFBII(AMFCENFNAJJ[i], JMNJPLAGDDJ, i << 1);
		}
		JMNJPLAGDDJ[12] = CKHAEFEPMDE.BNODDEBMLOM((uint)AMFCENFNAJJ[6]);
	}
}
