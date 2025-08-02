using System;
using Org.BouncyCastle.Math;

internal class MAKNBIJADHA
{
	private const ulong LBKKGBDEKMJ = 140737488355327uL;

	private const ulong FDBPCDJGAIJ = 1152921504606846975uL;

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
		NAMFEFNOFCH(array, 0);
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
		MIOEHGDPGAG(array, array);
		IBJBIGNPNEM(array, AMFCENFNAJJ, array);
		OIEFGPHNOFN(array, 59, array2);
		IBJBIGNPNEM(array2, array, array2);
		MIOEHGDPGAG(array2, array2);
		IBJBIGNPNEM(array2, AMFCENFNAJJ, array2);
		OIEFGPHNOFN(array2, 119, array);
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
		num4 ^= num8 << 17;
		num5 ^= num8 >> 47;
		num6 ^= num8 << 47;
		num7 ^= num8 >> 17;
		num3 ^= num7 << 17;
		num4 ^= num7 >> 47;
		num5 ^= num7 << 47;
		num6 ^= num7 >> 17;
		num2 ^= num6 << 17;
		num3 ^= num6 >> 47;
		num4 ^= num6 << 47;
		num5 ^= num6 >> 17;
		num ^= num5 << 17;
		num2 ^= num5 >> 47;
		num3 ^= num5 << 47;
		num4 ^= num5 >> 17;
		ulong num9 = num4 >> 47;
		IGNEOOOFEMO[0] = num ^ num9;
		IGNEOOOFEMO[1] = num2;
		IGNEOOOFEMO[2] = num3 ^ (num9 << 30);
		IGNEOOOFEMO[3] = num4 & 0x7FFFFFFFFFFFuL;
	}

	public static void NAMFEFNOFCH(ulong[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = IGNEOOOFEMO[NDAAKFPMLOL + 3];
		ulong num2 = num >> 47;
		IGNEOOOFEMO[NDAAKFPMLOL] ^= num2;
		IGNEOOOFEMO[NDAAKFPMLOL + 2] ^= num2 << 30;
		IGNEOOOFEMO[NDAAKFPMLOL + 3] = num & 0x7FFFFFFFFFFFuL;
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
		ulong num7 = num6 >> 49;
		ulong num8 = (num4 >> 49) | (num6 << 15);
		num6 ^= num4 << 15;
		ulong[] array = AKOICJCJNFB.JFMBFIGDFCE();
		int[] array2 = new int[2] { 39, 120 };
		for (int i = 0; i < array2.Length; i++)
		{
			int num9 = array2[i] >> 6;
			int num10 = array2[i] & 0x3F;
			array[num9] ^= num4 << num10;
			array[num9 + 1] ^= (num6 << num10) | (num4 >> -num10);
			array[num9 + 2] ^= (num8 << num10) | (num6 >> -num10);
			array[num9 + 3] ^= (num7 << num10) | (num8 >> -num10);
			array[num9 + 4] ^= num7 >> -num10;
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
		return (uint)(int)(AMFCENFNAJJ[0] ^ (AMFCENFNAJJ[1] >> 17) ^ (AMFCENFNAJJ[2] >> 34)) & 1u;
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
		JMNJPLAGDDJ[0] = num ^ (num2 << 60);
		JMNJPLAGDDJ[1] = (num2 >> 4) ^ (num3 << 56);
		JMNJPLAGDDJ[2] = (num3 >> 8) ^ (num4 << 52);
		JMNJPLAGDDJ[3] = (num4 >> 12) ^ (num5 << 48);
		JMNJPLAGDDJ[4] = (num5 >> 16) ^ (num6 << 44);
		JMNJPLAGDDJ[5] = (num6 >> 20) ^ (num7 << 40);
		JMNJPLAGDDJ[6] = (num7 >> 24) ^ (num8 << 36);
		JMNJPLAGDDJ[7] = num8 >> 28;
	}

	protected static void DGMNOJOHHNB(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		ulong num = AMFCENFNAJJ[0];
		ulong num2 = AMFCENFNAJJ[1];
		ulong num3 = AMFCENFNAJJ[2];
		ulong num4 = AMFCENFNAJJ[3];
		IGNEOOOFEMO[0] = num & 0xFFFFFFFFFFFFFFFuL;
		IGNEOOOFEMO[1] = ((num >> 60) ^ (num2 << 4)) & 0xFFFFFFFFFFFFFFFuL;
		IGNEOOOFEMO[2] = ((num2 >> 56) ^ (num3 << 8)) & 0xFFFFFFFFFFFFFFFuL;
		IGNEOOOFEMO[3] = (num3 >> 52) ^ (num4 << 12);
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
		num2 ^= (AMFCENFNAJJ & 0x820820820820820L & (ulong)((long)(CNLILOEEBOJ << 4) >> 63)) >> 5;
		IGNEOOOFEMO[NDAAKFPMLOL] ^= num3 & 0xFFFFFFFFFFFFFFFL;
		IGNEOOOFEMO[NDAAKFPMLOL + 1] ^= (num3 >> 60) ^ (num2 << 4);
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
