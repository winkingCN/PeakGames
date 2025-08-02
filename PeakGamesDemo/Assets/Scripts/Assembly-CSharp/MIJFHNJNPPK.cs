using System;
using Org.BouncyCastle.Math;

internal class MIJFHNJNPPK
{
	private const ulong CFHCFIGNOIM = 576460752303423487uL;

	private const ulong ECMGLFHLFGH = 17256631552825064414uL;

	private static readonly ulong[] KGNHHCIOEBC = new ulong[9] { 3161836309350906777uL, 10804290191530228771uL, 14625517132619890193uL, 7312758566309945096uL, 17890083061325672324uL, 8945041530681231562uL, 13695892802195391589uL, 6847946401097695794uL, 541669439031730457uL };

	public static void JEACJNAKLDJ(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] IGNEOOOFEMO)
	{
		for (int i = 0; i < 9; i++)
		{
			IGNEOOOFEMO[i] = AMFCENFNAJJ[i] ^ CNLILOEEBOJ[i];
		}
	}

	private static void JEACJNAKLDJ(ulong[] AMFCENFNAJJ, int ABBPDEOGNFE, ulong[] CNLILOEEBOJ, int HGNFOMNFIDD, ulong[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		for (int i = 0; i < 9; i++)
		{
			IGNEOOOFEMO[NDAAKFPMLOL + i] = AMFCENFNAJJ[ABBPDEOGNFE + i] ^ CNLILOEEBOJ[HGNFOMNFIDD + i];
		}
	}

	private static void FIBDFFPCDGC(ulong[] AMFCENFNAJJ, int ABBPDEOGNFE, ulong[] CNLILOEEBOJ, int HGNFOMNFIDD, ulong[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		for (int i = 0; i < 9; i++)
		{
			IGNEOOOFEMO[NDAAKFPMLOL + i] ^= AMFCENFNAJJ[ABBPDEOGNFE + i] ^ CNLILOEEBOJ[HGNFOMNFIDD + i];
		}
	}

	public static void KGBEKKMEBCN(ulong[] HGHHJPDIMCI, ulong[] IKEIELCEKPD, ulong[] JMNJPLAGDDJ)
	{
		for (int i = 0; i < 18; i++)
		{
			JMNJPLAGDDJ[i] = HGHHJPDIMCI[i] ^ IKEIELCEKPD[i];
		}
	}

	public static void AOAINNMNBHC(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		IGNEOOOFEMO[0] = AMFCENFNAJJ[0] ^ 1;
		for (int i = 1; i < 9; i++)
		{
			IGNEOOOFEMO[i] = AMFCENFNAJJ[i];
		}
	}

	public static ulong[] HFENNGHNFLF(BigInteger AMFCENFNAJJ)
	{
		ulong[] array = OHEOKKIDGLP.NCFBIELMPAA(AMFCENFNAJJ);
		MADIFOFNIIK(array, 0);
		return array;
	}

	public static void LEIECFOMCNL(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		if (OHEOKKIDGLP.NKNOMEDBEDI(AMFCENFNAJJ))
		{
			throw new InvalidOperationException();
		}
		ulong[] array = OHEOKKIDGLP.JLMPJDKAODG();
		ulong[] array2 = OHEOKKIDGLP.JLMPJDKAODG();
		ulong[] array3 = OHEOKKIDGLP.JLMPJDKAODG();
		MIOEHGDPGAG(AMFCENFNAJJ, array3);
		MIOEHGDPGAG(array3, array);
		MIOEHGDPGAG(array, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array, 2, array2);
		IBJBIGNPNEM(array, array2, array);
		IBJBIGNPNEM(array, array3, array);
		OIEFGPHNOFN(array, 5, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array2, 5, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array, 15, array2);
		IBJBIGNPNEM(array, array2, array3);
		OIEFGPHNOFN(array3, 30, array);
		OIEFGPHNOFN(array, 30, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array, 60, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array2, 60, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array, 180, array2);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array2, 180, array2);
		IBJBIGNPNEM(array, array2, array);
		IBJBIGNPNEM(array, array3, IGNEOOOFEMO);
	}

	public static void IBJBIGNPNEM(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] IGNEOOOFEMO)
	{
		ulong[] array = OHEOKKIDGLP.JFMBFIGDFCE();
		NEIMDHAFMNO(AMFCENFNAJJ, CNLILOEEBOJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
	}

	public static void OMJFFHEIEFH(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] JMNJPLAGDDJ)
	{
		ulong[] array = OHEOKKIDGLP.JFMBFIGDFCE();
		NEIMDHAFMNO(AMFCENFNAJJ, CNLILOEEBOJ, array);
		KGBEKKMEBCN(JMNJPLAGDDJ, array, JMNJPLAGDDJ);
	}

	public static void BKCHMGKFECM(ulong[] HGHHJPDIMCI, ulong[] IGNEOOOFEMO)
	{
		ulong num = HGHHJPDIMCI[9];
		ulong num2 = HGHHJPDIMCI[17];
		ulong num3 = num;
		num = num3 ^ (num2 >> 59) ^ (num2 >> 57) ^ (num2 >> 54) ^ (num2 >> 49);
		num3 = HGHHJPDIMCI[8] ^ (num2 << 5) ^ (num2 << 7) ^ (num2 << 10) ^ (num2 << 15);
		for (int num4 = 16; num4 >= 10; num4--)
		{
			num2 = HGHHJPDIMCI[num4];
			IGNEOOOFEMO[num4 - 8] = num3 ^ (num2 >> 59) ^ (num2 >> 57) ^ (num2 >> 54) ^ (num2 >> 49);
			num3 = HGHHJPDIMCI[num4 - 9] ^ (num2 << 5) ^ (num2 << 7) ^ (num2 << 10) ^ (num2 << 15);
		}
		num2 = num;
		IGNEOOOFEMO[1] = num3 ^ (num2 >> 59) ^ (num2 >> 57) ^ (num2 >> 54) ^ (num2 >> 49);
		num3 = HGHHJPDIMCI[0] ^ (num2 << 5) ^ (num2 << 7) ^ (num2 << 10) ^ (num2 << 15);
		ulong num5 = IGNEOOOFEMO[8];
		ulong num6 = num5 >> 59;
		IGNEOOOFEMO[0] = num3 ^ num6 ^ (num6 << 2) ^ (num6 << 5) ^ (num6 << 10);
		IGNEOOOFEMO[8] = num5 & 0x7FFFFFFFFFFFFFFuL;
	}

	public static void MADIFOFNIIK(ulong[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = IGNEOOOFEMO[NDAAKFPMLOL + 8];
		ulong num2 = num >> 59;
		IGNEOOOFEMO[NDAAKFPMLOL] ^= num2 ^ (num2 << 2) ^ (num2 << 5) ^ (num2 << 10);
		IGNEOOOFEMO[NDAAKFPMLOL + 8] = num & 0x7FFFFFFFFFFFFFFuL;
	}

	public static void PAEDNKEIDOM(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		ulong[] array = OHEOKKIDGLP.JLMPJDKAODG();
		ulong[] array2 = OHEOKKIDGLP.JLMPJDKAODG();
		int num = 0;
		for (int i = 0; i < 4; i++)
		{
			ulong num2 = CKHAEFEPMDE.CHBDGGMNNFA(AMFCENFNAJJ[num++]);
			ulong num3 = CKHAEFEPMDE.CHBDGGMNNFA(AMFCENFNAJJ[num++]);
			array[i] = (num2 & 0xFFFFFFFFu) | (num3 << 32);
			array2[i] = (num2 >> 32) | (num3 & 0xFFFFFFFF00000000uL);
		}
		ulong num4 = CKHAEFEPMDE.CHBDGGMNNFA(AMFCENFNAJJ[num]);
		array[4] = num4 & 0xFFFFFFFFu;
		array2[4] = num4 >> 32;
		IBJBIGNPNEM(array2, KGNHHCIOEBC, IGNEOOOFEMO);
		JEACJNAKLDJ(IGNEOOOFEMO, array, IGNEOOOFEMO);
	}

	public static void MIOEHGDPGAG(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		ulong[] array = OHEOKKIDGLP.JFMBFIGDFCE();
		MMBGDFPOOKF(AMFCENFNAJJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
	}

	public static void OALFNDHHFAA(ulong[] AMFCENFNAJJ, ulong[] JMNJPLAGDDJ)
	{
		ulong[] array = OHEOKKIDGLP.JFMBFIGDFCE();
		MMBGDFPOOKF(AMFCENFNAJJ, array);
		KGBEKKMEBCN(JMNJPLAGDDJ, array, JMNJPLAGDDJ);
	}

	public static void OIEFGPHNOFN(ulong[] AMFCENFNAJJ, int IDHLPOFDLKJ, ulong[] IGNEOOOFEMO)
	{
		ulong[] array = OHEOKKIDGLP.JFMBFIGDFCE();
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
		return (uint)(int)(AMFCENFNAJJ[0] ^ (AMFCENFNAJJ[8] >> 49) ^ (AMFCENFNAJJ[8] >> 57)) & 1u;
	}

	protected static void NEIMDHAFMNO(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] JMNJPLAGDDJ)
	{
		ulong[] array = new ulong[144];
		Array.Copy(CNLILOEEBOJ, 0, array, 9, 9);
		int num = 0;
		for (int num2 = 7; num2 > 0; num2--)
		{
			num += 18;
			BCMDHIIJKJE.KCONODDHKAH(9, array, num >> 1, 0uL, array, num);
			MADIFOFNIIK(array, num);
			JEACJNAKLDJ(array, 9, array, num, array, num + 9);
		}
		ulong[] array2 = new ulong[array.Length];
		BCMDHIIJKJE.IFHPIPOFGIN(array.Length, array, 0, 4, 0uL, array2, 0);
		uint num3 = 15u;
		for (int num4 = 56; num4 >= 0; num4 -= 8)
		{
			for (int i = 1; i < 9; i += 2)
			{
				uint num5 = (uint)(AMFCENFNAJJ[i] >> num4);
				uint num6 = num5 & num3;
				uint num7 = (num5 >> 4) & num3;
				FIBDFFPCDGC(array, (int)(9 * num6), array2, (int)(9 * num7), JMNJPLAGDDJ, i - 1);
			}
			BCMDHIIJKJE.IFHPIPOFGIN(16, JMNJPLAGDDJ, 0, 8, 0uL);
		}
		for (int num8 = 56; num8 >= 0; num8 -= 8)
		{
			for (int j = 0; j < 9; j += 2)
			{
				uint num9 = (uint)(AMFCENFNAJJ[j] >> num8);
				uint num10 = num9 & num3;
				uint num11 = (num9 >> 4) & num3;
				FIBDFFPCDGC(array, (int)(9 * num10), array2, (int)(9 * num11), JMNJPLAGDDJ, j);
			}
			if (num8 > 0)
			{
				BCMDHIIJKJE.IFHPIPOFGIN(18, JMNJPLAGDDJ, 0, 8, 0uL);
			}
		}
	}

	protected static void IOCCHBHEBFJ(ulong[] BMOHGJOJLOL, ulong CNLILOEEBOJ, ulong[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong[] array = new ulong[32];
		array[1] = CNLILOEEBOJ;
		for (int i = 2; i < 32; i += 2)
		{
			array[i] = array[i >> 1] << 1;
			array[i + 1] = array[i] ^ CNLILOEEBOJ;
		}
		ulong num = 0uL;
		for (int j = 0; j < 9; j++)
		{
			ulong num2 = BMOHGJOJLOL[j];
			uint num3 = (uint)num2;
			num ^= array[num3 & 0x1F];
			ulong num4 = 0uL;
			int num5 = 60;
			do
			{
				num3 = (uint)(num2 >> num5);
				ulong num6 = array[num3 & 0x1F];
				num ^= num6 << num5;
				num4 ^= num6 >> -num5;
			}
			while ((num5 -= 5) > 0);
			for (int k = 0; k < 4; k++)
			{
				num2 = (num2 & 0xEF7BDEF7BDEF7BDEuL) >> 1;
				num4 ^= num2 & (ulong)((long)(CNLILOEEBOJ << k) >> 63);
			}
			IGNEOOOFEMO[NDAAKFPMLOL + j] ^= num;
			num = num4;
		}
		IGNEOOOFEMO[NDAAKFPMLOL + 9] ^= num;
	}

	protected static void MMBGDFPOOKF(ulong[] AMFCENFNAJJ, ulong[] JMNJPLAGDDJ)
	{
		for (int i = 0; i < 9; i++)
		{
			CKHAEFEPMDE.NILPKHOFBII(AMFCENFNAJJ[i], JMNJPLAGDDJ, i << 1);
		}
	}
}
