using Org.BouncyCastle.Math;

internal class ADLDIDKJJFG
{
	internal static readonly uint[] MBIJHANOCOC = new uint[7] { 1u, 0u, 0u, 4294967295u, 4294967295u, 4294967295u, 4294967295u };

	internal static readonly uint[] PKABKFGEMBB = new uint[14]
	{
		1u, 0u, 0u, 4294967294u, 4294967295u, 4294967295u, 0u, 2u, 0u, 0u,
		4294967294u, 4294967295u, 4294967295u, 4294967295u
	};

	private static readonly uint[] BPGLGHCLMCD = new uint[11]
	{
		4294967295u, 4294967295u, 4294967295u, 1u, 0u, 0u, 4294967295u, 4294967293u, 4294967295u, 4294967295u,
		1u
	};

	private const uint IMGACIMJBPO = uint.MaxValue;

	private const uint PPBCBABHIBL = uint.MaxValue;

	public static void JEACJNAKLDJ(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		if (MADOAPNPCCB.JEACJNAKLDJ(AMFCENFNAJJ, CNLILOEEBOJ, IGNEOOOFEMO) != 0 || (IGNEOOOFEMO[6] == uint.MaxValue && MADOAPNPCCB.CHCGDEIGIIA(IGNEOOOFEMO, MBIJHANOCOC)))
		{
			ICGGMECILDD(IGNEOOOFEMO);
		}
	}

	public static void KGBEKKMEBCN(uint[] HGHHJPDIMCI, uint[] IKEIELCEKPD, uint[] JMNJPLAGDDJ)
	{
		if ((BCMDHIIJKJE.JEACJNAKLDJ(14, HGHHJPDIMCI, IKEIELCEKPD, JMNJPLAGDDJ) != 0 || (JMNJPLAGDDJ[13] == uint.MaxValue && BCMDHIIJKJE.CHCGDEIGIIA(14, JMNJPLAGDDJ, PKABKFGEMBB))) && BCMDHIIJKJE.MAALDEFJPJA(BPGLGHCLMCD.Length, BPGLGHCLMCD, JMNJPLAGDDJ) != 0)
		{
			BCMDHIIJKJE.DKCBNAFCCMF(14, JMNJPLAGDDJ, BPGLGHCLMCD.Length);
		}
	}

	public static void AOAINNMNBHC(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		if (BCMDHIIJKJE.CKIHMFAAHLM(7, AMFCENFNAJJ, IGNEOOOFEMO) != 0 || (IGNEOOOFEMO[6] == uint.MaxValue && MADOAPNPCCB.CHCGDEIGIIA(IGNEOOOFEMO, MBIJHANOCOC)))
		{
			ICGGMECILDD(IGNEOOOFEMO);
		}
	}

	public static uint[] HFENNGHNFLF(BigInteger AMFCENFNAJJ)
	{
		uint[] array = MADOAPNPCCB.HFENNGHNFLF(AMFCENFNAJJ);
		if (array[6] == uint.MaxValue && MADOAPNPCCB.CHCGDEIGIIA(array, MBIJHANOCOC))
		{
			MADOAPNPCCB.DKAMAFLMHEJ(MBIJHANOCOC, array);
		}
		return array;
	}

	public static void CBGFKBFBIFD(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		if ((AMFCENFNAJJ[0] & 1) == 0)
		{
			BCMDHIIJKJE.POFAGJIFAIH(7, AMFCENFNAJJ, 0u, IGNEOOOFEMO);
			return;
		}
		uint fMFABAKPMLB = MADOAPNPCCB.JEACJNAKLDJ(AMFCENFNAJJ, MBIJHANOCOC, IGNEOOOFEMO);
		BCMDHIIJKJE.POFAGJIFAIH(7, IGNEOOOFEMO, fMFABAKPMLB);
	}

	public static void IBJBIGNPNEM(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		uint[] array = MADOAPNPCCB.DCPJKFEDHOJ();
		MADOAPNPCCB.BMEIFJDODCF(AMFCENFNAJJ, CNLILOEEBOJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
	}

	public static void OMJFFHEIEFH(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] JMNJPLAGDDJ)
	{
		if ((MADOAPNPCCB.HHMEIAJHDJM(AMFCENFNAJJ, CNLILOEEBOJ, JMNJPLAGDDJ) != 0 || (JMNJPLAGDDJ[13] == uint.MaxValue && BCMDHIIJKJE.CHCGDEIGIIA(14, JMNJPLAGDDJ, PKABKFGEMBB))) && BCMDHIIJKJE.MAALDEFJPJA(BPGLGHCLMCD.Length, BPGLGHCLMCD, JMNJPLAGDDJ) != 0)
		{
			BCMDHIIJKJE.DKCBNAFCCMF(14, JMNJPLAGDDJ, BPGLGHCLMCD.Length);
		}
	}

	public static void BHKOFHMDACN(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		if (MADOAPNPCCB.EJJHHCOFAAI(AMFCENFNAJJ))
		{
			MADOAPNPCCB.KEOKCFDNHPP(IGNEOOOFEMO);
		}
		else
		{
			MADOAPNPCCB.EAEONHFLEEN(MBIJHANOCOC, AMFCENFNAJJ, IGNEOOOFEMO);
		}
	}

	public static void BKCHMGKFECM(uint[] HGHHJPDIMCI, uint[] IGNEOOOFEMO)
	{
		long num = HGHHJPDIMCI[10];
		long num2 = HGHHJPDIMCI[11];
		long num3 = HGHHJPDIMCI[12];
		long num4 = HGHHJPDIMCI[13];
		long num5 = HGHHJPDIMCI[7] + num2 - 1;
		long num6 = HGHHJPDIMCI[8] + num3;
		long num7 = HGHHJPDIMCI[9] + num4;
		long num8 = 0L;
		num8 += HGHHJPDIMCI[0] - num5;
		long num9 = (uint)num8;
		num8 >>= 32;
		num8 += HGHHJPDIMCI[1] - num6;
		IGNEOOOFEMO[1] = (uint)num8;
		num8 >>= 32;
		num8 += HGHHJPDIMCI[2] - num7;
		IGNEOOOFEMO[2] = (uint)num8;
		num8 >>= 32;
		num8 += HGHHJPDIMCI[3] + num5 - num;
		long num10 = (uint)num8;
		num8 >>= 32;
		num8 += HGHHJPDIMCI[4] + num6 - num2;
		IGNEOOOFEMO[4] = (uint)num8;
		num8 >>= 32;
		num8 += HGHHJPDIMCI[5] + num7 - num3;
		IGNEOOOFEMO[5] = (uint)num8;
		num8 >>= 32;
		num8 += HGHHJPDIMCI[6] + num - num4;
		IGNEOOOFEMO[6] = (uint)num8;
		num8 >>= 32;
		num8++;
		num10 += num8;
		num9 -= num8;
		IGNEOOOFEMO[0] = (uint)num9;
		num8 = num9 >> 32;
		if (num8 != 0)
		{
			num8 += IGNEOOOFEMO[1];
			IGNEOOOFEMO[1] = (uint)num8;
			num8 >>= 32;
			num8 += IGNEOOOFEMO[2];
			IGNEOOOFEMO[2] = (uint)num8;
			num10 += num8 >> 32;
		}
		IGNEOOOFEMO[3] = (uint)num10;
		num8 = num10 >> 32;
		if ((num8 != 0 && BCMDHIIJKJE.DKCBNAFCCMF(7, IGNEOOOFEMO, 4) != 0) || (IGNEOOOFEMO[6] == uint.MaxValue && MADOAPNPCCB.CHCGDEIGIIA(IGNEOOOFEMO, MBIJHANOCOC)))
		{
			ICGGMECILDD(IGNEOOOFEMO);
		}
	}

	public static void KKIGIOINLCI(uint AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		long num = 0L;
		if (AMFCENFNAJJ != 0)
		{
			long num2 = AMFCENFNAJJ;
			num += IGNEOOOFEMO[0] - num2;
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
			num += IGNEOOOFEMO[3] + num2;
			IGNEOOOFEMO[3] = (uint)num;
			num >>= 32;
		}
		if ((num != 0 && BCMDHIIJKJE.DKCBNAFCCMF(7, IGNEOOOFEMO, 4) != 0) || (IGNEOOOFEMO[6] == uint.MaxValue && MADOAPNPCCB.CHCGDEIGIIA(IGNEOOOFEMO, MBIJHANOCOC)))
		{
			ICGGMECILDD(IGNEOOOFEMO);
		}
	}

	public static void MIOEHGDPGAG(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		uint[] array = MADOAPNPCCB.DCPJKFEDHOJ();
		MADOAPNPCCB.MIOEHGDPGAG(AMFCENFNAJJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
	}

	public static void OIEFGPHNOFN(uint[] AMFCENFNAJJ, int IDHLPOFDLKJ, uint[] IGNEOOOFEMO)
	{
		uint[] array = MADOAPNPCCB.DCPJKFEDHOJ();
		MADOAPNPCCB.MIOEHGDPGAG(AMFCENFNAJJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
		while (--IDHLPOFDLKJ > 0)
		{
			MADOAPNPCCB.MIOEHGDPGAG(IGNEOOOFEMO, array);
			BKCHMGKFECM(array, IGNEOOOFEMO);
		}
	}

	public static void FBGIHKPECCO(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		if (MADOAPNPCCB.EAEONHFLEEN(AMFCENFNAJJ, CNLILOEEBOJ, IGNEOOOFEMO) != 0)
		{
			ECFPDKDNIKD(IGNEOOOFEMO);
		}
	}

	public static void OIKFFIIOCPO(uint[] HGHHJPDIMCI, uint[] IKEIELCEKPD, uint[] JMNJPLAGDDJ)
	{
		if (BCMDHIIJKJE.EAEONHFLEEN(14, HGHHJPDIMCI, IKEIELCEKPD, JMNJPLAGDDJ) != 0 && BCMDHIIJKJE.DKAMAFLMHEJ(BPGLGHCLMCD.Length, BPGLGHCLMCD, JMNJPLAGDDJ) != 0)
		{
			BCMDHIIJKJE.MEJBLKJLLNK(14, JMNJPLAGDDJ, BPGLGHCLMCD.Length);
		}
	}

	public static void LLGLJBDLBOP(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		if (BCMDHIIJKJE.FKEFFJALNJM(7, AMFCENFNAJJ, 0u, IGNEOOOFEMO) != 0 || (IGNEOOOFEMO[6] == uint.MaxValue && MADOAPNPCCB.CHCGDEIGIIA(IGNEOOOFEMO, MBIJHANOCOC)))
		{
			ICGGMECILDD(IGNEOOOFEMO);
		}
	}

	private static void ICGGMECILDD(uint[] IGNEOOOFEMO)
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
		num += (long)IGNEOOOFEMO[3] + 1L;
		IGNEOOOFEMO[3] = (uint)num;
		num >>= 32;
		if (num != 0)
		{
			BCMDHIIJKJE.DKCBNAFCCMF(7, IGNEOOOFEMO, 4);
		}
	}

	private static void ECFPDKDNIKD(uint[] IGNEOOOFEMO)
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
		num += (long)IGNEOOOFEMO[3] - 1L;
		IGNEOOOFEMO[3] = (uint)num;
		num >>= 32;
		if (num != 0)
		{
			BCMDHIIJKJE.MEJBLKJLLNK(7, IGNEOOOFEMO, 4);
		}
	}
}
