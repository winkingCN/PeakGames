using System;
using Org.BouncyCastle.Math;

internal class GENOFEPDCFD
{
	private const ulong JKGNBGCJLAN = 134217727uL;

	private const ulong CEMFAFDFBKN = 144115188075855871uL;

	private static readonly ulong[] KGNHHCIOEBC = new ulong[5] { 878416384462358536uL, 3513665537849438403uL, 9369774767598502668uL, 585610922974906400uL, 34087042uL };

	public static void JEACJNAKLDJ(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] IGNEOOOFEMO)
	{
		IGNEOOOFEMO[0] = AMFCENFNAJJ[0] ^ CNLILOEEBOJ[0];
		IGNEOOOFEMO[1] = AMFCENFNAJJ[1] ^ CNLILOEEBOJ[1];
		IGNEOOOFEMO[2] = AMFCENFNAJJ[2] ^ CNLILOEEBOJ[2];
		IGNEOOOFEMO[3] = AMFCENFNAJJ[3] ^ CNLILOEEBOJ[3];
		IGNEOOOFEMO[4] = AMFCENFNAJJ[4] ^ CNLILOEEBOJ[4];
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
		JMNJPLAGDDJ[8] = HGHHJPDIMCI[8] ^ IKEIELCEKPD[8];
	}

	public static void AOAINNMNBHC(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		IGNEOOOFEMO[0] = AMFCENFNAJJ[0] ^ 1;
		IGNEOOOFEMO[1] = AMFCENFNAJJ[1];
		IGNEOOOFEMO[2] = AMFCENFNAJJ[2];
		IGNEOOOFEMO[3] = AMFCENFNAJJ[3];
		IGNEOOOFEMO[4] = AMFCENFNAJJ[4];
	}

	public static ulong[] HFENNGHNFLF(BigInteger AMFCENFNAJJ)
	{
		ulong[] array = IPPOAIBCANI.NCFBIELMPAA(AMFCENFNAJJ);
		JAGFPKMJKNA(array, 0);
		return array;
	}

	public static void LEIECFOMCNL(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		if (IPPOAIBCANI.NKNOMEDBEDI(AMFCENFNAJJ))
		{
			throw new InvalidOperationException();
		}
		ulong[] array = IPPOAIBCANI.JLMPJDKAODG();
		ulong[] array2 = IPPOAIBCANI.JLMPJDKAODG();
		MIOEHGDPGAG(AMFCENFNAJJ, array);
		IBJBIGNPNEM(array, AMFCENFNAJJ, array);
		OIEFGPHNOFN(array, 2, array2);
		IBJBIGNPNEM(array2, array, array2);
		OIEFGPHNOFN(array2, 4, array);
		IBJBIGNPNEM(array, array2, array);
		OIEFGPHNOFN(array, 8, array2);
		IBJBIGNPNEM(array2, array, array2);
		MIOEHGDPGAG(array2, array2);
		IBJBIGNPNEM(array2, AMFCENFNAJJ, array2);
		OIEFGPHNOFN(array2, 17, array);
		IBJBIGNPNEM(array, array2, array);
		MIOEHGDPGAG(array, array);
		IBJBIGNPNEM(array, AMFCENFNAJJ, array);
		OIEFGPHNOFN(array, 35, array2);
		IBJBIGNPNEM(array2, array, array2);
		OIEFGPHNOFN(array2, 70, array);
		IBJBIGNPNEM(array, array2, array);
		MIOEHGDPGAG(array, array);
		IBJBIGNPNEM(array, AMFCENFNAJJ, array);
		OIEFGPHNOFN(array, 141, array2);
		IBJBIGNPNEM(array2, array, array2);
		MIOEHGDPGAG(array2, IGNEOOOFEMO);
	}

	public static void IBJBIGNPNEM(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] IGNEOOOFEMO)
	{
		ulong[] array = IPPOAIBCANI.JFMBFIGDFCE();
		NEIMDHAFMNO(AMFCENFNAJJ, CNLILOEEBOJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
	}

	public static void OMJFFHEIEFH(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] JMNJPLAGDDJ)
	{
		ulong[] array = IPPOAIBCANI.JFMBFIGDFCE();
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
		ulong num9 = HGHHJPDIMCI[8];
		num4 ^= (num9 << 37) ^ (num9 << 42) ^ (num9 << 44) ^ (num9 << 49);
		num5 ^= (num9 >> 27) ^ (num9 >> 22) ^ (num9 >> 20) ^ (num9 >> 15);
		num3 ^= (num8 << 37) ^ (num8 << 42) ^ (num8 << 44) ^ (num8 << 49);
		num4 ^= (num8 >> 27) ^ (num8 >> 22) ^ (num8 >> 20) ^ (num8 >> 15);
		num2 ^= (num7 << 37) ^ (num7 << 42) ^ (num7 << 44) ^ (num7 << 49);
		num3 ^= (num7 >> 27) ^ (num7 >> 22) ^ (num7 >> 20) ^ (num7 >> 15);
		num ^= (num6 << 37) ^ (num6 << 42) ^ (num6 << 44) ^ (num6 << 49);
		num2 ^= (num6 >> 27) ^ (num6 >> 22) ^ (num6 >> 20) ^ (num6 >> 15);
		ulong num10 = num5 >> 27;
		IGNEOOOFEMO[0] = num ^ num10 ^ (num10 << 5) ^ (num10 << 7) ^ (num10 << 12);
		IGNEOOOFEMO[1] = num2;
		IGNEOOOFEMO[2] = num3;
		IGNEOOOFEMO[3] = num4;
		IGNEOOOFEMO[4] = num5 & 0x7FFFFFF;
	}

	public static void JAGFPKMJKNA(ulong[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = IGNEOOOFEMO[NDAAKFPMLOL + 4];
		ulong num2 = num >> 27;
		IGNEOOOFEMO[NDAAKFPMLOL] ^= num2 ^ (num2 << 5) ^ (num2 << 7) ^ (num2 << 12);
		IGNEOOOFEMO[NDAAKFPMLOL + 4] = num & 0x7FFFFFF;
	}

	public static void PAEDNKEIDOM(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		ulong[] array = IPPOAIBCANI.JLMPJDKAODG();
		ulong num = CKHAEFEPMDE.CHBDGGMNNFA(AMFCENFNAJJ[0]);
		ulong num2 = CKHAEFEPMDE.CHBDGGMNNFA(AMFCENFNAJJ[1]);
		ulong num3 = (num & 0xFFFFFFFFu) | (num2 << 32);
		array[0] = (num >> 32) | (num2 & 0xFFFFFFFF00000000uL);
		num = CKHAEFEPMDE.CHBDGGMNNFA(AMFCENFNAJJ[2]);
		num2 = CKHAEFEPMDE.CHBDGGMNNFA(AMFCENFNAJJ[3]);
		ulong num4 = (num & 0xFFFFFFFFu) | (num2 << 32);
		array[1] = (num >> 32) | (num2 & 0xFFFFFFFF00000000uL);
		num = CKHAEFEPMDE.CHBDGGMNNFA(AMFCENFNAJJ[4]);
		ulong num5 = num & 0xFFFFFFFFu;
		array[2] = num >> 32;
		IBJBIGNPNEM(array, KGNHHCIOEBC, IGNEOOOFEMO);
		IGNEOOOFEMO[0] ^= num3;
		IGNEOOOFEMO[1] ^= num4;
		IGNEOOOFEMO[2] ^= num5;
	}

	public static void MIOEHGDPGAG(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		ulong[] array = BCMDHIIJKJE.JLMPJDKAODG(9);
		MMBGDFPOOKF(AMFCENFNAJJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
	}

	public static void OALFNDHHFAA(ulong[] AMFCENFNAJJ, ulong[] JMNJPLAGDDJ)
	{
		ulong[] array = BCMDHIIJKJE.JLMPJDKAODG(9);
		MMBGDFPOOKF(AMFCENFNAJJ, array);
		KGBEKKMEBCN(JMNJPLAGDDJ, array, JMNJPLAGDDJ);
	}

	public static void OIEFGPHNOFN(ulong[] AMFCENFNAJJ, int IDHLPOFDLKJ, ulong[] IGNEOOOFEMO)
	{
		ulong[] array = BCMDHIIJKJE.JLMPJDKAODG(9);
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
		return (uint)(int)(AMFCENFNAJJ[0] ^ (AMFCENFNAJJ[4] >> 15)) & 1u;
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
		JMNJPLAGDDJ[0] = num ^ (num2 << 57);
		JMNJPLAGDDJ[1] = (num2 >> 7) ^ (num3 << 50);
		JMNJPLAGDDJ[2] = (num3 >> 14) ^ (num4 << 43);
		JMNJPLAGDDJ[3] = (num4 >> 21) ^ (num5 << 36);
		JMNJPLAGDDJ[4] = (num5 >> 28) ^ (num6 << 29);
		JMNJPLAGDDJ[5] = (num6 >> 35) ^ (num7 << 22);
		JMNJPLAGDDJ[6] = (num7 >> 42) ^ (num8 << 15);
		JMNJPLAGDDJ[7] = (num8 >> 49) ^ (num9 << 8);
		JMNJPLAGDDJ[8] = (num9 >> 56) ^ (num10 << 1);
		JMNJPLAGDDJ[9] = num10 >> 63;
	}

	protected static void DGMNOJOHHNB(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		ulong num = AMFCENFNAJJ[0];
		ulong num2 = AMFCENFNAJJ[1];
		ulong num3 = AMFCENFNAJJ[2];
		ulong num4 = AMFCENFNAJJ[3];
		ulong num5 = AMFCENFNAJJ[4];
		IGNEOOOFEMO[0] = num & 0x1FFFFFFFFFFFFFFuL;
		IGNEOOOFEMO[1] = ((num >> 57) ^ (num2 << 7)) & 0x1FFFFFFFFFFFFFFuL;
		IGNEOOOFEMO[2] = ((num2 >> 50) ^ (num3 << 14)) & 0x1FFFFFFFFFFFFFFuL;
		IGNEOOOFEMO[3] = ((num3 >> 43) ^ (num4 << 21)) & 0x1FFFFFFFFFFFFFFuL;
		IGNEOOOFEMO[4] = (num4 >> 36) ^ (num5 << 28);
	}

	protected static void NEIMDHAFMNO(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] JMNJPLAGDDJ)
	{
		ulong[] array = new ulong[5];
		ulong[] array2 = new ulong[5];
		DGMNOJOHHNB(AMFCENFNAJJ, array);
		DGMNOJOHHNB(CNLILOEEBOJ, array2);
		ulong[] array3 = new ulong[26];
		CNIBNFGPHFD(array[0], array2[0], array3, 0);
		CNIBNFGPHFD(array[1], array2[1], array3, 2);
		CNIBNFGPHFD(array[2], array2[2], array3, 4);
		CNIBNFGPHFD(array[3], array2[3], array3, 6);
		CNIBNFGPHFD(array[4], array2[4], array3, 8);
		ulong num = array[0] ^ array[1];
		ulong num2 = array2[0] ^ array2[1];
		ulong num3 = array[0] ^ array[2];
		ulong num4 = array2[0] ^ array2[2];
		ulong num5 = array[2] ^ array[4];
		ulong num6 = array2[2] ^ array2[4];
		ulong num7 = array[3] ^ array[4];
		ulong num8 = array2[3] ^ array2[4];
		CNIBNFGPHFD(num3 ^ array[3], num4 ^ array2[3], array3, 18);
		CNIBNFGPHFD(num5 ^ array[1], num6 ^ array2[1], array3, 20);
		ulong num9 = num ^ num7;
		ulong num10 = num2 ^ num8;
		ulong aMFCENFNAJJ = num9 ^ array[2];
		ulong cNLILOEEBOJ = num10 ^ array2[2];
		CNIBNFGPHFD(num9, num10, array3, 22);
		CNIBNFGPHFD(aMFCENFNAJJ, cNLILOEEBOJ, array3, 24);
		CNIBNFGPHFD(num, num2, array3, 10);
		CNIBNFGPHFD(num3, num4, array3, 12);
		CNIBNFGPHFD(num5, num6, array3, 14);
		CNIBNFGPHFD(num7, num8, array3, 16);
		JMNJPLAGDDJ[0] = array3[0];
		JMNJPLAGDDJ[9] = array3[9];
		ulong num11 = array3[0] ^ array3[1];
		ulong num12 = num11 ^ array3[2];
		ulong num13 = (JMNJPLAGDDJ[1] = num12 ^ array3[10]);
		ulong num14 = array3[3] ^ array3[4];
		ulong num15 = array3[11] ^ array3[12];
		ulong num16 = num14 ^ num15;
		ulong num17 = (JMNJPLAGDDJ[2] = num12 ^ num16);
		ulong num18 = num11 ^ num14;
		ulong num19 = array3[5] ^ array3[6];
		ulong num20 = num18 ^ num19;
		ulong num21 = num20 ^ array3[8];
		ulong num22 = array3[13] ^ array3[14];
		ulong num23 = num21 ^ num22;
		ulong num24 = array3[18] ^ array3[22];
		ulong num25 = num24 ^ array3[24];
		ulong num26 = num23 ^ num25;
		JMNJPLAGDDJ[3] = num26;
		ulong num27 = array3[7] ^ array3[8];
		ulong num28 = num27 ^ array3[9];
		ulong num29 = (JMNJPLAGDDJ[8] = num28 ^ array3[17]);
		ulong num30 = num28 ^ num19;
		ulong num31 = array3[15] ^ array3[16];
		ulong num32 = (JMNJPLAGDDJ[7] = num30 ^ num31) ^ num13;
		ulong num33 = array3[19] ^ array3[20];
		ulong num34 = array3[25] ^ array3[24];
		ulong num35 = array3[18] ^ array3[23];
		ulong num36 = num33 ^ num34;
		ulong num37 = num36 ^ num35;
		ulong num38 = num37 ^ num32;
		JMNJPLAGDDJ[4] = num38;
		ulong num39 = num17 ^ num29;
		ulong num40 = num36 ^ num39;
		ulong num41 = array3[21] ^ array3[22];
		ulong num42 = num40 ^ num41;
		JMNJPLAGDDJ[5] = num42;
		ulong num43 = num21 ^ array3[0];
		ulong num44 = num43 ^ array3[9];
		ulong num45 = num44 ^ num22;
		ulong num46 = num45 ^ array3[21];
		ulong num47 = num46 ^ array3[23];
		ulong num48 = num47 ^ array3[25];
		JMNJPLAGDDJ[6] = num48;
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
		for (int i = 0; i < 4; i++)
		{
			CKHAEFEPMDE.NILPKHOFBII(AMFCENFNAJJ[i], JMNJPLAGDDJ, i << 1);
		}
		JMNJPLAGDDJ[8] = CKHAEFEPMDE.BNODDEBMLOM((uint)AMFCENFNAJJ[4]);
	}
}
