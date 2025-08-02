using Org.BouncyCastle.Math;

internal class BOKPIHHFBKJ
{
	internal static readonly uint[] MBIJHANOCOC = new uint[4] { 4294967295u, 4294967295u, 4294967295u, 4294967293u };

	internal static readonly uint[] PKABKFGEMBB = new uint[8] { 1u, 0u, 0u, 4u, 4294967294u, 4294967295u, 3u, 4294967292u };

	private static readonly uint[] BPGLGHCLMCD = new uint[8] { 4294967295u, 4294967295u, 4294967295u, 4294967291u, 1u, 0u, 4294967292u, 3u };

	private const uint DMEJMKIPNJG = 4294967293u;

	private const uint NPDKMKGKOPC = 4294967292u;

	public static void JEACJNAKLDJ(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		if (LAFMGEKEGBF.JEACJNAKLDJ(AMFCENFNAJJ, CNLILOEEBOJ, IGNEOOOFEMO) != 0 || (IGNEOOOFEMO[3] == 4294967293u && LAFMGEKEGBF.CHCGDEIGIIA(IGNEOOOFEMO, MBIJHANOCOC)))
		{
			ICGGMECILDD(IGNEOOOFEMO);
		}
	}

	public static void KGBEKKMEBCN(uint[] HGHHJPDIMCI, uint[] IKEIELCEKPD, uint[] JMNJPLAGDDJ)
	{
		if (AKOICJCJNFB.JEACJNAKLDJ(HGHHJPDIMCI, IKEIELCEKPD, JMNJPLAGDDJ) != 0 || (JMNJPLAGDDJ[7] == 4294967292u && AKOICJCJNFB.CHCGDEIGIIA(JMNJPLAGDDJ, PKABKFGEMBB)))
		{
			BCMDHIIJKJE.MAALDEFJPJA(BPGLGHCLMCD.Length, BPGLGHCLMCD, JMNJPLAGDDJ);
		}
	}

	public static void AOAINNMNBHC(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		if (BCMDHIIJKJE.CKIHMFAAHLM(4, AMFCENFNAJJ, IGNEOOOFEMO) != 0 || (IGNEOOOFEMO[3] == 4294967293u && LAFMGEKEGBF.CHCGDEIGIIA(IGNEOOOFEMO, MBIJHANOCOC)))
		{
			ICGGMECILDD(IGNEOOOFEMO);
		}
	}

	public static uint[] HFENNGHNFLF(BigInteger AMFCENFNAJJ)
	{
		uint[] array = LAFMGEKEGBF.HFENNGHNFLF(AMFCENFNAJJ);
		if (array[3] == 4294967293u && LAFMGEKEGBF.CHCGDEIGIIA(array, MBIJHANOCOC))
		{
			LAFMGEKEGBF.DKAMAFLMHEJ(MBIJHANOCOC, array);
		}
		return array;
	}

	public static void CBGFKBFBIFD(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		if ((AMFCENFNAJJ[0] & 1) == 0)
		{
			BCMDHIIJKJE.POFAGJIFAIH(4, AMFCENFNAJJ, 0u, IGNEOOOFEMO);
			return;
		}
		uint fMFABAKPMLB = LAFMGEKEGBF.JEACJNAKLDJ(AMFCENFNAJJ, MBIJHANOCOC, IGNEOOOFEMO);
		BCMDHIIJKJE.POFAGJIFAIH(4, IGNEOOOFEMO, fMFABAKPMLB);
	}

	public static void IBJBIGNPNEM(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		uint[] array = LAFMGEKEGBF.DCPJKFEDHOJ();
		LAFMGEKEGBF.BMEIFJDODCF(AMFCENFNAJJ, CNLILOEEBOJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
	}

	public static void OMJFFHEIEFH(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] JMNJPLAGDDJ)
	{
		if (LAFMGEKEGBF.HHMEIAJHDJM(AMFCENFNAJJ, CNLILOEEBOJ, JMNJPLAGDDJ) != 0 || (JMNJPLAGDDJ[7] == 4294967292u && AKOICJCJNFB.CHCGDEIGIIA(JMNJPLAGDDJ, PKABKFGEMBB)))
		{
			BCMDHIIJKJE.MAALDEFJPJA(BPGLGHCLMCD.Length, BPGLGHCLMCD, JMNJPLAGDDJ);
		}
	}

	public static void BHKOFHMDACN(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		if (LAFMGEKEGBF.EJJHHCOFAAI(AMFCENFNAJJ))
		{
			LAFMGEKEGBF.KEOKCFDNHPP(IGNEOOOFEMO);
		}
		else
		{
			LAFMGEKEGBF.EAEONHFLEEN(MBIJHANOCOC, AMFCENFNAJJ, IGNEOOOFEMO);
		}
	}

	public static void BKCHMGKFECM(uint[] HGHHJPDIMCI, uint[] IGNEOOOFEMO)
	{
		ulong num = HGHHJPDIMCI[0];
		ulong num2 = HGHHJPDIMCI[1];
		ulong num3 = HGHHJPDIMCI[2];
		ulong num4 = HGHHJPDIMCI[3];
		ulong num5 = HGHHJPDIMCI[4];
		ulong num6 = HGHHJPDIMCI[5];
		ulong num7 = HGHHJPDIMCI[6];
		ulong num8 = HGHHJPDIMCI[7];
		num4 += num8;
		num7 += num8 << 1;
		num3 += num7;
		num6 += num7 << 1;
		num2 += num6;
		num5 += num6 << 1;
		num += num5;
		num4 += num5 << 1;
		IGNEOOOFEMO[0] = (uint)num;
		num2 += num >> 32;
		IGNEOOOFEMO[1] = (uint)num2;
		num3 += num2 >> 32;
		IGNEOOOFEMO[2] = (uint)num3;
		num4 += num3 >> 32;
		IGNEOOOFEMO[3] = (uint)num4;
		KKIGIOINLCI((uint)(num4 >> 32), IGNEOOOFEMO);
	}

	public static void KKIGIOINLCI(uint AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		while (AMFCENFNAJJ != 0)
		{
			ulong num = AMFCENFNAJJ;
			ulong num2 = IGNEOOOFEMO[0] + num;
			IGNEOOOFEMO[0] = (uint)num2;
			num2 >>= 32;
			if (num2 != 0)
			{
				num2 += IGNEOOOFEMO[1];
				IGNEOOOFEMO[1] = (uint)num2;
				num2 >>= 32;
				num2 += IGNEOOOFEMO[2];
				IGNEOOOFEMO[2] = (uint)num2;
				num2 >>= 32;
			}
			num2 += IGNEOOOFEMO[3] + (num << 1);
			IGNEOOOFEMO[3] = (uint)num2;
			num2 >>= 32;
			AMFCENFNAJJ = (uint)num2;
		}
	}

	public static void MIOEHGDPGAG(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		uint[] array = LAFMGEKEGBF.DCPJKFEDHOJ();
		LAFMGEKEGBF.MIOEHGDPGAG(AMFCENFNAJJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
	}

	public static void OIEFGPHNOFN(uint[] AMFCENFNAJJ, int IDHLPOFDLKJ, uint[] IGNEOOOFEMO)
	{
		uint[] array = LAFMGEKEGBF.DCPJKFEDHOJ();
		LAFMGEKEGBF.MIOEHGDPGAG(AMFCENFNAJJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
		while (--IDHLPOFDLKJ > 0)
		{
			LAFMGEKEGBF.MIOEHGDPGAG(IGNEOOOFEMO, array);
			BKCHMGKFECM(array, IGNEOOOFEMO);
		}
	}

	public static void FBGIHKPECCO(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		if (LAFMGEKEGBF.EAEONHFLEEN(AMFCENFNAJJ, CNLILOEEBOJ, IGNEOOOFEMO) != 0)
		{
			ECFPDKDNIKD(IGNEOOOFEMO);
		}
	}

	public static void OIKFFIIOCPO(uint[] HGHHJPDIMCI, uint[] IKEIELCEKPD, uint[] JMNJPLAGDDJ)
	{
		if (BCMDHIIJKJE.EAEONHFLEEN(10, HGHHJPDIMCI, IKEIELCEKPD, JMNJPLAGDDJ) != 0)
		{
			BCMDHIIJKJE.DKAMAFLMHEJ(BPGLGHCLMCD.Length, BPGLGHCLMCD, JMNJPLAGDDJ);
		}
	}

	public static void LLGLJBDLBOP(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		if (BCMDHIIJKJE.FKEFFJALNJM(4, AMFCENFNAJJ, 0u, IGNEOOOFEMO) != 0 || (IGNEOOOFEMO[3] == 4294967293u && LAFMGEKEGBF.CHCGDEIGIIA(IGNEOOOFEMO, MBIJHANOCOC)))
		{
			ICGGMECILDD(IGNEOOOFEMO);
		}
	}

	private static void ICGGMECILDD(uint[] IGNEOOOFEMO)
	{
		long num = (long)IGNEOOOFEMO[0] + 1L;
		IGNEOOOFEMO[0] = (uint)num;
		num >>= 32;
		if (num != 0)
		{
			num += IGNEOOOFEMO[1];
			IGNEOOOFEMO[1] = (uint)num;
			num >>= 32;
			num += IGNEOOOFEMO[2];
			IGNEOOOFEMO[2] = (uint)num;
			num >>= 32;
		}
		num += (long)IGNEOOOFEMO[3] + 2L;
		IGNEOOOFEMO[3] = (uint)num;
	}

	private static void ECFPDKDNIKD(uint[] IGNEOOOFEMO)
	{
		long num = (long)IGNEOOOFEMO[0] - 1L;
		IGNEOOOFEMO[0] = (uint)num;
		num >>= 32;
		if (num != 0)
		{
			num += IGNEOOOFEMO[1];
			IGNEOOOFEMO[1] = (uint)num;
			num >>= 32;
			num += IGNEOOOFEMO[2];
			IGNEOOOFEMO[2] = (uint)num;
			num >>= 32;
		}
		num += (long)IGNEOOOFEMO[3] - 2L;
		IGNEOOOFEMO[3] = (uint)num;
	}
}
