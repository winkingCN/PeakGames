using Org.BouncyCastle.Math;

internal class OGEODCDNDPA
{
	internal static readonly uint[] MBIJHANOCOC = new uint[6] { 4294967295u, 4294967295u, 4294967294u, 4294967295u, 4294967295u, 4294967295u };

	internal static readonly uint[] PKABKFGEMBB = new uint[12]
	{
		1u, 0u, 2u, 0u, 1u, 0u, 4294967294u, 4294967295u, 4294967293u, 4294967295u,
		4294967295u, 4294967295u
	};

	private static readonly uint[] BPGLGHCLMCD = new uint[9] { 4294967295u, 4294967295u, 4294967293u, 4294967295u, 4294967294u, 4294967295u, 1u, 0u, 2u };

	private const uint AEEBNAHFLBN = uint.MaxValue;

	private const uint PFEOKJIFAME = uint.MaxValue;

	public static void JEACJNAKLDJ(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		if (PHEKPHCPKLA.JEACJNAKLDJ(AMFCENFNAJJ, CNLILOEEBOJ, IGNEOOOFEMO) != 0 || (IGNEOOOFEMO[5] == uint.MaxValue && PHEKPHCPKLA.CHCGDEIGIIA(IGNEOOOFEMO, MBIJHANOCOC)))
		{
			ICGGMECILDD(IGNEOOOFEMO);
		}
	}

	public static void KGBEKKMEBCN(uint[] HGHHJPDIMCI, uint[] IKEIELCEKPD, uint[] JMNJPLAGDDJ)
	{
		if ((BCMDHIIJKJE.JEACJNAKLDJ(12, HGHHJPDIMCI, IKEIELCEKPD, JMNJPLAGDDJ) != 0 || (JMNJPLAGDDJ[11] == uint.MaxValue && BCMDHIIJKJE.CHCGDEIGIIA(12, JMNJPLAGDDJ, PKABKFGEMBB))) && BCMDHIIJKJE.MAALDEFJPJA(BPGLGHCLMCD.Length, BPGLGHCLMCD, JMNJPLAGDDJ) != 0)
		{
			BCMDHIIJKJE.DKCBNAFCCMF(12, JMNJPLAGDDJ, BPGLGHCLMCD.Length);
		}
	}

	public static void AOAINNMNBHC(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		if (BCMDHIIJKJE.CKIHMFAAHLM(6, AMFCENFNAJJ, IGNEOOOFEMO) != 0 || (IGNEOOOFEMO[5] == uint.MaxValue && PHEKPHCPKLA.CHCGDEIGIIA(IGNEOOOFEMO, MBIJHANOCOC)))
		{
			ICGGMECILDD(IGNEOOOFEMO);
		}
	}

	public static uint[] HFENNGHNFLF(BigInteger AMFCENFNAJJ)
	{
		uint[] array = PHEKPHCPKLA.HFENNGHNFLF(AMFCENFNAJJ);
		if (array[5] == uint.MaxValue && PHEKPHCPKLA.CHCGDEIGIIA(array, MBIJHANOCOC))
		{
			PHEKPHCPKLA.DKAMAFLMHEJ(MBIJHANOCOC, array);
		}
		return array;
	}

	public static void CBGFKBFBIFD(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		if ((AMFCENFNAJJ[0] & 1) == 0)
		{
			BCMDHIIJKJE.POFAGJIFAIH(6, AMFCENFNAJJ, 0u, IGNEOOOFEMO);
			return;
		}
		uint fMFABAKPMLB = PHEKPHCPKLA.JEACJNAKLDJ(AMFCENFNAJJ, MBIJHANOCOC, IGNEOOOFEMO);
		BCMDHIIJKJE.POFAGJIFAIH(6, IGNEOOOFEMO, fMFABAKPMLB);
	}

	public static void IBJBIGNPNEM(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		uint[] array = PHEKPHCPKLA.DCPJKFEDHOJ();
		PHEKPHCPKLA.BMEIFJDODCF(AMFCENFNAJJ, CNLILOEEBOJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
	}

	public static void OMJFFHEIEFH(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] JMNJPLAGDDJ)
	{
		if ((PHEKPHCPKLA.HHMEIAJHDJM(AMFCENFNAJJ, CNLILOEEBOJ, JMNJPLAGDDJ) != 0 || (JMNJPLAGDDJ[11] == uint.MaxValue && BCMDHIIJKJE.CHCGDEIGIIA(12, JMNJPLAGDDJ, PKABKFGEMBB))) && BCMDHIIJKJE.MAALDEFJPJA(BPGLGHCLMCD.Length, BPGLGHCLMCD, JMNJPLAGDDJ) != 0)
		{
			BCMDHIIJKJE.DKCBNAFCCMF(12, JMNJPLAGDDJ, BPGLGHCLMCD.Length);
		}
	}

	public static void BHKOFHMDACN(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		if (PHEKPHCPKLA.EJJHHCOFAAI(AMFCENFNAJJ))
		{
			PHEKPHCPKLA.KEOKCFDNHPP(IGNEOOOFEMO);
		}
		else
		{
			PHEKPHCPKLA.EAEONHFLEEN(MBIJHANOCOC, AMFCENFNAJJ, IGNEOOOFEMO);
		}
	}

	public static void BKCHMGKFECM(uint[] HGHHJPDIMCI, uint[] IGNEOOOFEMO)
	{
		ulong num = HGHHJPDIMCI[6];
		ulong num2 = HGHHJPDIMCI[7];
		ulong num3 = HGHHJPDIMCI[8];
		ulong num4 = HGHHJPDIMCI[9];
		ulong num5 = HGHHJPDIMCI[10];
		ulong num6 = HGHHJPDIMCI[11];
		ulong num7 = num + num5;
		ulong num8 = num2 + num6;
		ulong num9 = 0uL;
		num9 += HGHHJPDIMCI[0] + num7;
		uint num10 = (uint)num9;
		num9 >>= 32;
		num9 += HGHHJPDIMCI[1] + num8;
		IGNEOOOFEMO[1] = (uint)num9;
		num9 >>= 32;
		num7 += num3;
		num8 += num4;
		num9 += HGHHJPDIMCI[2] + num7;
		ulong num11 = (uint)num9;
		num9 >>= 32;
		num9 += HGHHJPDIMCI[3] + num8;
		IGNEOOOFEMO[3] = (uint)num9;
		num9 >>= 32;
		num7 -= num;
		num8 -= num2;
		num9 += HGHHJPDIMCI[4] + num7;
		IGNEOOOFEMO[4] = (uint)num9;
		num9 >>= 32;
		num9 += HGHHJPDIMCI[5] + num8;
		IGNEOOOFEMO[5] = (uint)num9;
		num9 >>= 32;
		num11 += num9;
		num9 += num10;
		IGNEOOOFEMO[0] = (uint)num9;
		num9 >>= 32;
		if (num9 != 0)
		{
			num9 += IGNEOOOFEMO[1];
			IGNEOOOFEMO[1] = (uint)num9;
			num11 += num9 >> 32;
		}
		IGNEOOOFEMO[2] = (uint)num11;
		num9 = num11 >> 32;
		if ((num9 != 0 && BCMDHIIJKJE.DKCBNAFCCMF(6, IGNEOOOFEMO, 3) != 0) || (IGNEOOOFEMO[5] == uint.MaxValue && PHEKPHCPKLA.CHCGDEIGIIA(IGNEOOOFEMO, MBIJHANOCOC)))
		{
			ICGGMECILDD(IGNEOOOFEMO);
		}
	}

	public static void KKIGIOINLCI(uint AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		ulong num = 0uL;
		if (AMFCENFNAJJ != 0)
		{
			num += (ulong)((long)IGNEOOOFEMO[0] + (long)AMFCENFNAJJ);
			IGNEOOOFEMO[0] = (uint)num;
			num >>= 32;
			if (num != 0)
			{
				num += IGNEOOOFEMO[1];
				IGNEOOOFEMO[1] = (uint)num;
				num >>= 32;
			}
			num += (ulong)((long)IGNEOOOFEMO[2] + (long)AMFCENFNAJJ);
			IGNEOOOFEMO[2] = (uint)num;
			num >>= 32;
		}
		if ((num != 0 && BCMDHIIJKJE.DKCBNAFCCMF(6, IGNEOOOFEMO, 3) != 0) || (IGNEOOOFEMO[5] == uint.MaxValue && PHEKPHCPKLA.CHCGDEIGIIA(IGNEOOOFEMO, MBIJHANOCOC)))
		{
			ICGGMECILDD(IGNEOOOFEMO);
		}
	}

	public static void MIOEHGDPGAG(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		uint[] array = PHEKPHCPKLA.DCPJKFEDHOJ();
		PHEKPHCPKLA.MIOEHGDPGAG(AMFCENFNAJJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
	}

	public static void OIEFGPHNOFN(uint[] AMFCENFNAJJ, int IDHLPOFDLKJ, uint[] IGNEOOOFEMO)
	{
		uint[] array = PHEKPHCPKLA.DCPJKFEDHOJ();
		PHEKPHCPKLA.MIOEHGDPGAG(AMFCENFNAJJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
		while (--IDHLPOFDLKJ > 0)
		{
			PHEKPHCPKLA.MIOEHGDPGAG(IGNEOOOFEMO, array);
			BKCHMGKFECM(array, IGNEOOOFEMO);
		}
	}

	public static void FBGIHKPECCO(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		if (PHEKPHCPKLA.EAEONHFLEEN(AMFCENFNAJJ, CNLILOEEBOJ, IGNEOOOFEMO) != 0)
		{
			ECFPDKDNIKD(IGNEOOOFEMO);
		}
	}

	public static void OIKFFIIOCPO(uint[] HGHHJPDIMCI, uint[] IKEIELCEKPD, uint[] JMNJPLAGDDJ)
	{
		if (BCMDHIIJKJE.EAEONHFLEEN(12, HGHHJPDIMCI, IKEIELCEKPD, JMNJPLAGDDJ) != 0 && BCMDHIIJKJE.DKAMAFLMHEJ(BPGLGHCLMCD.Length, BPGLGHCLMCD, JMNJPLAGDDJ) != 0)
		{
			BCMDHIIJKJE.MEJBLKJLLNK(12, JMNJPLAGDDJ, BPGLGHCLMCD.Length);
		}
	}

	public static void LLGLJBDLBOP(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		if (BCMDHIIJKJE.FKEFFJALNJM(6, AMFCENFNAJJ, 0u, IGNEOOOFEMO) != 0 || (IGNEOOOFEMO[5] == uint.MaxValue && PHEKPHCPKLA.CHCGDEIGIIA(IGNEOOOFEMO, MBIJHANOCOC)))
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
		}
		num += (long)IGNEOOOFEMO[2] + 1L;
		IGNEOOOFEMO[2] = (uint)num;
		num >>= 32;
		if (num != 0)
		{
			BCMDHIIJKJE.DKCBNAFCCMF(6, IGNEOOOFEMO, 3);
		}
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
		}
		num += (long)IGNEOOOFEMO[2] - 1L;
		IGNEOOOFEMO[2] = (uint)num;
		num >>= 32;
		if (num != 0)
		{
			BCMDHIIJKJE.MEJBLKJLLNK(6, IGNEOOOFEMO, 3);
		}
	}
}
