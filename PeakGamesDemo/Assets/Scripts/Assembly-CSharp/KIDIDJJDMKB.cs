using Org.BouncyCastle.Math;

internal class KIDIDJJDMKB
{
	internal static readonly uint[] MBIJHANOCOC = new uint[8] { 4294967295u, 4294967295u, 4294967295u, 0u, 0u, 0u, 1u, 4294967295u };

	internal static readonly uint[] PKABKFGEMBB = new uint[16]
	{
		1u, 0u, 0u, 4294967294u, 4294967295u, 4294967295u, 4294967294u, 1u, 4294967294u, 1u,
		4294967294u, 1u, 1u, 4294967294u, 2u, 4294967294u
	};

	internal const uint IIHHAHBGDFC = uint.MaxValue;

	internal const uint LDNLCGGHMJE = 4294967294u;

	public static void JEACJNAKLDJ(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		if (AKOICJCJNFB.JEACJNAKLDJ(AMFCENFNAJJ, CNLILOEEBOJ, IGNEOOOFEMO) != 0 || (IGNEOOOFEMO[7] == uint.MaxValue && AKOICJCJNFB.CHCGDEIGIIA(IGNEOOOFEMO, MBIJHANOCOC)))
		{
			ICGGMECILDD(IGNEOOOFEMO);
		}
	}

	public static void KGBEKKMEBCN(uint[] HGHHJPDIMCI, uint[] IKEIELCEKPD, uint[] JMNJPLAGDDJ)
	{
		if (BCMDHIIJKJE.JEACJNAKLDJ(16, HGHHJPDIMCI, IKEIELCEKPD, JMNJPLAGDDJ) != 0 || (JMNJPLAGDDJ[15] >= 4294967294u && BCMDHIIJKJE.CHCGDEIGIIA(16, JMNJPLAGDDJ, PKABKFGEMBB)))
		{
			BCMDHIIJKJE.DKAMAFLMHEJ(16, PKABKFGEMBB, JMNJPLAGDDJ);
		}
	}

	public static void AOAINNMNBHC(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		if (BCMDHIIJKJE.CKIHMFAAHLM(8, AMFCENFNAJJ, IGNEOOOFEMO) != 0 || (IGNEOOOFEMO[7] == uint.MaxValue && AKOICJCJNFB.CHCGDEIGIIA(IGNEOOOFEMO, MBIJHANOCOC)))
		{
			ICGGMECILDD(IGNEOOOFEMO);
		}
	}

	public static uint[] HFENNGHNFLF(BigInteger AMFCENFNAJJ)
	{
		uint[] array = AKOICJCJNFB.HFENNGHNFLF(AMFCENFNAJJ);
		if (array[7] == uint.MaxValue && AKOICJCJNFB.CHCGDEIGIIA(array, MBIJHANOCOC))
		{
			AKOICJCJNFB.DKAMAFLMHEJ(MBIJHANOCOC, array);
		}
		return array;
	}

	public static void CBGFKBFBIFD(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		if ((AMFCENFNAJJ[0] & 1) == 0)
		{
			BCMDHIIJKJE.POFAGJIFAIH(8, AMFCENFNAJJ, 0u, IGNEOOOFEMO);
			return;
		}
		uint fMFABAKPMLB = AKOICJCJNFB.JEACJNAKLDJ(AMFCENFNAJJ, MBIJHANOCOC, IGNEOOOFEMO);
		BCMDHIIJKJE.POFAGJIFAIH(8, IGNEOOOFEMO, fMFABAKPMLB);
	}

	public static void IBJBIGNPNEM(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		uint[] array = AKOICJCJNFB.DCPJKFEDHOJ();
		AKOICJCJNFB.BMEIFJDODCF(AMFCENFNAJJ, CNLILOEEBOJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
	}

	public static void OMJFFHEIEFH(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] JMNJPLAGDDJ)
	{
		if (AKOICJCJNFB.HHMEIAJHDJM(AMFCENFNAJJ, CNLILOEEBOJ, JMNJPLAGDDJ) != 0 || (JMNJPLAGDDJ[15] >= 4294967294u && BCMDHIIJKJE.CHCGDEIGIIA(16, JMNJPLAGDDJ, PKABKFGEMBB)))
		{
			BCMDHIIJKJE.DKAMAFLMHEJ(16, PKABKFGEMBB, JMNJPLAGDDJ);
		}
	}

	public static void BHKOFHMDACN(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		if (AKOICJCJNFB.EJJHHCOFAAI(AMFCENFNAJJ))
		{
			AKOICJCJNFB.KEOKCFDNHPP(IGNEOOOFEMO);
		}
		else
		{
			AKOICJCJNFB.EAEONHFLEEN(MBIJHANOCOC, AMFCENFNAJJ, IGNEOOOFEMO);
		}
	}

	public static void BKCHMGKFECM(uint[] HGHHJPDIMCI, uint[] IGNEOOOFEMO)
	{
		long num = HGHHJPDIMCI[8];
		long num2 = HGHHJPDIMCI[9];
		long num3 = HGHHJPDIMCI[10];
		long num4 = HGHHJPDIMCI[11];
		long num5 = HGHHJPDIMCI[12];
		long num6 = HGHHJPDIMCI[13];
		long num7 = HGHHJPDIMCI[14];
		long num8 = HGHHJPDIMCI[15];
		num -= 6;
		long num9 = num + num2;
		long num10 = num2 + num3;
		long num11 = num3 + num4 - num8;
		long num12 = num4 + num5;
		long num13 = num5 + num6;
		long num14 = num6 + num7;
		long num15 = num7 + num8;
		long num16 = num14 - num9;
		long num17 = 0L;
		num17 += HGHHJPDIMCI[0] - num12 - num16;
		IGNEOOOFEMO[0] = (uint)num17;
		num17 >>= 32;
		num17 += HGHHJPDIMCI[1] + num10 - num13 - num15;
		IGNEOOOFEMO[1] = (uint)num17;
		num17 >>= 32;
		num17 += HGHHJPDIMCI[2] + num11 - num14;
		IGNEOOOFEMO[2] = (uint)num17;
		num17 >>= 32;
		num17 += HGHHJPDIMCI[3] + (num12 << 1) + num16 - num15;
		IGNEOOOFEMO[3] = (uint)num17;
		num17 >>= 32;
		num17 += HGHHJPDIMCI[4] + (num13 << 1) + num7 - num10;
		IGNEOOOFEMO[4] = (uint)num17;
		num17 >>= 32;
		num17 += HGHHJPDIMCI[5] + (num14 << 1) - num11;
		IGNEOOOFEMO[5] = (uint)num17;
		num17 >>= 32;
		num17 += HGHHJPDIMCI[6] + (num15 << 1) + num16;
		IGNEOOOFEMO[6] = (uint)num17;
		num17 >>= 32;
		num17 += HGHHJPDIMCI[7] + (num8 << 1) + num - num11 - num13;
		IGNEOOOFEMO[7] = (uint)num17;
		num17 >>= 32;
		num17 += 6;
		KKIGIOINLCI((uint)num17, IGNEOOOFEMO);
	}

	public static void KKIGIOINLCI(uint AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		long num = 0L;
		if (AMFCENFNAJJ != 0)
		{
			long num2 = AMFCENFNAJJ;
			num += IGNEOOOFEMO[0] + num2;
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
			num += IGNEOOOFEMO[3] - num2;
			IGNEOOOFEMO[3] = (uint)num;
			num >>= 32;
			if (num != 0)
			{
				num += IGNEOOOFEMO[4];
				IGNEOOOFEMO[4] = (uint)num;
				num >>= 32;
				num += IGNEOOOFEMO[5];
				IGNEOOOFEMO[5] = (uint)num;
				num >>= 32;
			}
			num += IGNEOOOFEMO[6] - num2;
			IGNEOOOFEMO[6] = (uint)num;
			num >>= 32;
			num += IGNEOOOFEMO[7] + num2;
			IGNEOOOFEMO[7] = (uint)num;
			num >>= 32;
		}
		if (num != 0 || (IGNEOOOFEMO[7] == uint.MaxValue && AKOICJCJNFB.CHCGDEIGIIA(IGNEOOOFEMO, MBIJHANOCOC)))
		{
			ICGGMECILDD(IGNEOOOFEMO);
		}
	}

	public static void MIOEHGDPGAG(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		uint[] array = AKOICJCJNFB.DCPJKFEDHOJ();
		AKOICJCJNFB.MIOEHGDPGAG(AMFCENFNAJJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
	}

	public static void OIEFGPHNOFN(uint[] AMFCENFNAJJ, int IDHLPOFDLKJ, uint[] IGNEOOOFEMO)
	{
		uint[] array = AKOICJCJNFB.DCPJKFEDHOJ();
		AKOICJCJNFB.MIOEHGDPGAG(AMFCENFNAJJ, array);
		BKCHMGKFECM(array, IGNEOOOFEMO);
		while (--IDHLPOFDLKJ > 0)
		{
			AKOICJCJNFB.MIOEHGDPGAG(IGNEOOOFEMO, array);
			BKCHMGKFECM(array, IGNEOOOFEMO);
		}
	}

	public static void FBGIHKPECCO(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		if (AKOICJCJNFB.EAEONHFLEEN(AMFCENFNAJJ, CNLILOEEBOJ, IGNEOOOFEMO) != 0)
		{
			ECFPDKDNIKD(IGNEOOOFEMO);
		}
	}

	public static void OIKFFIIOCPO(uint[] HGHHJPDIMCI, uint[] IKEIELCEKPD, uint[] JMNJPLAGDDJ)
	{
		if (BCMDHIIJKJE.EAEONHFLEEN(16, HGHHJPDIMCI, IKEIELCEKPD, JMNJPLAGDDJ) != 0)
		{
			BCMDHIIJKJE.MAALDEFJPJA(16, PKABKFGEMBB, JMNJPLAGDDJ);
		}
	}

	public static void LLGLJBDLBOP(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		if (BCMDHIIJKJE.FKEFFJALNJM(8, AMFCENFNAJJ, 0u, IGNEOOOFEMO) != 0 || (IGNEOOOFEMO[7] == uint.MaxValue && AKOICJCJNFB.CHCGDEIGIIA(IGNEOOOFEMO, MBIJHANOCOC)))
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
		num += (long)IGNEOOOFEMO[3] - 1L;
		IGNEOOOFEMO[3] = (uint)num;
		num >>= 32;
		if (num != 0)
		{
			num += IGNEOOOFEMO[4];
			IGNEOOOFEMO[4] = (uint)num;
			num >>= 32;
			num += IGNEOOOFEMO[5];
			IGNEOOOFEMO[5] = (uint)num;
			num >>= 32;
		}
		num += (long)IGNEOOOFEMO[6] - 1L;
		IGNEOOOFEMO[6] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[7] + 1L;
		IGNEOOOFEMO[7] = (uint)num;
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
		num += (long)IGNEOOOFEMO[3] + 1L;
		IGNEOOOFEMO[3] = (uint)num;
		num >>= 32;
		if (num != 0)
		{
			num += IGNEOOOFEMO[4];
			IGNEOOOFEMO[4] = (uint)num;
			num >>= 32;
			num += IGNEOOOFEMO[5];
			IGNEOOOFEMO[5] = (uint)num;
			num >>= 32;
		}
		num += (long)IGNEOOOFEMO[6] + 1L;
		IGNEOOOFEMO[6] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[7] - 1L;
		IGNEOOOFEMO[7] = (uint)num;
	}
}
