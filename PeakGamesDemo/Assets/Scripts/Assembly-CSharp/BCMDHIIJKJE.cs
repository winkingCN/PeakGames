using System;
using Org.BouncyCastle.Math;

internal abstract class BCMDHIIJKJE
{
	private const ulong IGBPKOOBCMA = 4294967295uL;

	public static uint JEACJNAKLDJ(int NBEDPKHALCN, uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		ulong num = 0uL;
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			num += (ulong)((long)AMFCENFNAJJ[i] + (long)CNLILOEEBOJ[i]);
			IGNEOOOFEMO[i] = (uint)num;
			num >>= 32;
		}
		return (uint)num;
	}

	public static uint ODKLGEDHCPK(int NBEDPKHALCN, uint AMFCENFNAJJ, uint[] IGNEOOOFEMO, int DPAKEPKLHJF)
	{
		ulong num = (ulong)IGNEOOOFEMO[DPAKEPKLHJF] + (ulong)AMFCENFNAJJ;
		IGNEOOOFEMO[DPAKEPKLHJF] = (uint)num;
		num >>= 32;
		num += (ulong)((long)IGNEOOOFEMO[DPAKEPKLHJF + 1] + 1L);
		IGNEOOOFEMO[DPAKEPKLHJF + 1] = (uint)num;
		num >>= 32;
		return (num != 0) ? DKCBNAFCCMF(NBEDPKHALCN, IGNEOOOFEMO, DPAKEPKLHJF + 2) : 0u;
	}

	public static uint ODKLGEDHCPK(int NBEDPKHALCN, uint AMFCENFNAJJ, uint[] IGNEOOOFEMO, int NDAAKFPMLOL, int DPAKEPKLHJF)
	{
		ulong num = (ulong)IGNEOOOFEMO[NDAAKFPMLOL + DPAKEPKLHJF] + (ulong)AMFCENFNAJJ;
		IGNEOOOFEMO[NDAAKFPMLOL + DPAKEPKLHJF] = (uint)num;
		num >>= 32;
		num += (ulong)((long)IGNEOOOFEMO[NDAAKFPMLOL + DPAKEPKLHJF + 1] + 1L);
		IGNEOOOFEMO[NDAAKFPMLOL + DPAKEPKLHJF + 1] = (uint)num;
		num >>= 32;
		return (num != 0) ? DKCBNAFCCMF(NBEDPKHALCN, IGNEOOOFEMO, NDAAKFPMLOL, DPAKEPKLHJF + 2) : 0u;
	}

	public static uint BJPICMNLAOG(int NBEDPKHALCN, uint AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		ulong num = (ulong)IGNEOOOFEMO[0] + (ulong)AMFCENFNAJJ;
		IGNEOOOFEMO[0] = (uint)num;
		num >>= 32;
		num += (ulong)((long)IGNEOOOFEMO[1] + 1L);
		IGNEOOOFEMO[1] = (uint)num;
		num >>= 32;
		return (num != 0) ? DKCBNAFCCMF(NBEDPKHALCN, IGNEOOOFEMO, 2) : 0u;
	}

	public static uint BJPICMNLAOG(int NBEDPKHALCN, uint AMFCENFNAJJ, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = (ulong)IGNEOOOFEMO[NDAAKFPMLOL] + (ulong)AMFCENFNAJJ;
		IGNEOOOFEMO[NDAAKFPMLOL] = (uint)num;
		num >>= 32;
		num += (ulong)((long)IGNEOOOFEMO[NDAAKFPMLOL + 1] + 1L);
		IGNEOOOFEMO[NDAAKFPMLOL + 1] = (uint)num;
		num >>= 32;
		return (num != 0) ? DKCBNAFCCMF(NBEDPKHALCN, IGNEOOOFEMO, NDAAKFPMLOL, 2) : 0u;
	}

	public static uint FIBDFFPCDGC(int NBEDPKHALCN, uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		ulong num = 0uL;
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			num += (ulong)((long)AMFCENFNAJJ[i] + (long)CNLILOEEBOJ[i] + IGNEOOOFEMO[i]);
			IGNEOOOFEMO[i] = (uint)num;
			num >>= 32;
		}
		return (uint)num;
	}

	public static uint FIBDFFPCDGC(int NBEDPKHALCN, uint[] AMFCENFNAJJ, int ABBPDEOGNFE, uint[] CNLILOEEBOJ, int HGNFOMNFIDD, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = 0uL;
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			num += (ulong)((long)AMFCENFNAJJ[ABBPDEOGNFE + i] + (long)CNLILOEEBOJ[HGNFOMNFIDD + i] + IGNEOOOFEMO[NDAAKFPMLOL + i]);
			IGNEOOOFEMO[NDAAKFPMLOL + i] = (uint)num;
			num >>= 32;
		}
		return (uint)num;
	}

	public static uint ADKDJHEAANN(int NBEDPKHALCN, ulong AMFCENFNAJJ, uint[] IGNEOOOFEMO, int DPAKEPKLHJF)
	{
		ulong num = IGNEOOOFEMO[DPAKEPKLHJF] + (AMFCENFNAJJ & 0xFFFFFFFFu);
		IGNEOOOFEMO[DPAKEPKLHJF] = (uint)num;
		num >>= 32;
		num += IGNEOOOFEMO[DPAKEPKLHJF + 1] + (AMFCENFNAJJ >> 32);
		IGNEOOOFEMO[DPAKEPKLHJF + 1] = (uint)num;
		num >>= 32;
		return (num != 0) ? DKCBNAFCCMF(NBEDPKHALCN, IGNEOOOFEMO, DPAKEPKLHJF + 2) : 0u;
	}

	public static uint ADKDJHEAANN(int NBEDPKHALCN, ulong AMFCENFNAJJ, uint[] IGNEOOOFEMO, int NDAAKFPMLOL, int DPAKEPKLHJF)
	{
		ulong num = IGNEOOOFEMO[NDAAKFPMLOL + DPAKEPKLHJF] + (AMFCENFNAJJ & 0xFFFFFFFFu);
		IGNEOOOFEMO[NDAAKFPMLOL + DPAKEPKLHJF] = (uint)num;
		num >>= 32;
		num += IGNEOOOFEMO[NDAAKFPMLOL + DPAKEPKLHJF + 1] + (AMFCENFNAJJ >> 32);
		IGNEOOOFEMO[NDAAKFPMLOL + DPAKEPKLHJF + 1] = (uint)num;
		num >>= 32;
		return (num != 0) ? DKCBNAFCCMF(NBEDPKHALCN, IGNEOOOFEMO, NDAAKFPMLOL, DPAKEPKLHJF + 2) : 0u;
	}

	public static uint PIFHNLJPPDA(int NBEDPKHALCN, ulong AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		ulong num = IGNEOOOFEMO[0] + (AMFCENFNAJJ & 0xFFFFFFFFu);
		IGNEOOOFEMO[0] = (uint)num;
		num >>= 32;
		num += IGNEOOOFEMO[1] + (AMFCENFNAJJ >> 32);
		IGNEOOOFEMO[1] = (uint)num;
		num >>= 32;
		return (num != 0) ? DKCBNAFCCMF(NBEDPKHALCN, IGNEOOOFEMO, 2) : 0u;
	}

	public static uint PIFHNLJPPDA(int NBEDPKHALCN, ulong AMFCENFNAJJ, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = IGNEOOOFEMO[NDAAKFPMLOL] + (AMFCENFNAJJ & 0xFFFFFFFFu);
		IGNEOOOFEMO[NDAAKFPMLOL] = (uint)num;
		num >>= 32;
		num += IGNEOOOFEMO[NDAAKFPMLOL + 1] + (AMFCENFNAJJ >> 32);
		IGNEOOOFEMO[NDAAKFPMLOL + 1] = (uint)num;
		num >>= 32;
		return (num != 0) ? DKCBNAFCCMF(NBEDPKHALCN, IGNEOOOFEMO, NDAAKFPMLOL, 2) : 0u;
	}

	public static uint MAALDEFJPJA(int NBEDPKHALCN, uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		ulong num = 0uL;
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			num += (ulong)((long)AMFCENFNAJJ[i] + (long)IGNEOOOFEMO[i]);
			IGNEOOOFEMO[i] = (uint)num;
			num >>= 32;
		}
		return (uint)num;
	}

	public static uint MAALDEFJPJA(int NBEDPKHALCN, uint[] AMFCENFNAJJ, int ABBPDEOGNFE, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = 0uL;
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			num += (ulong)((long)AMFCENFNAJJ[ABBPDEOGNFE + i] + (long)IGNEOOOFEMO[NDAAKFPMLOL + i]);
			IGNEOOOFEMO[NDAAKFPMLOL + i] = (uint)num;
			num >>= 32;
		}
		return (uint)num;
	}

	public static uint HNPBCAPBDGJ(int NBEDPKHALCN, uint AMFCENFNAJJ, uint[] IGNEOOOFEMO, int DPAKEPKLHJF)
	{
		ulong num = (ulong)AMFCENFNAJJ + (ulong)IGNEOOOFEMO[DPAKEPKLHJF];
		IGNEOOOFEMO[DPAKEPKLHJF] = (uint)num;
		num >>= 32;
		return (num != 0) ? DKCBNAFCCMF(NBEDPKHALCN, IGNEOOOFEMO, DPAKEPKLHJF + 1) : 0u;
	}

	public static uint HNPBCAPBDGJ(int NBEDPKHALCN, uint AMFCENFNAJJ, uint[] IGNEOOOFEMO, int NDAAKFPMLOL, int DPAKEPKLHJF)
	{
		ulong num = (ulong)AMFCENFNAJJ + (ulong)IGNEOOOFEMO[NDAAKFPMLOL + DPAKEPKLHJF];
		IGNEOOOFEMO[NDAAKFPMLOL + DPAKEPKLHJF] = (uint)num;
		num >>= 32;
		return (num != 0) ? DKCBNAFCCMF(NBEDPKHALCN, IGNEOOOFEMO, NDAAKFPMLOL, DPAKEPKLHJF + 1) : 0u;
	}

	public static uint GEDBFLNFIHI(int NBEDPKHALCN, uint AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		ulong num = (ulong)AMFCENFNAJJ + (ulong)IGNEOOOFEMO[0];
		IGNEOOOFEMO[0] = (uint)num;
		num >>= 32;
		return (num != 0) ? DKCBNAFCCMF(NBEDPKHALCN, IGNEOOOFEMO, 1) : 0u;
	}

	public static uint GEDBFLNFIHI(int NBEDPKHALCN, uint AMFCENFNAJJ, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = (ulong)AMFCENFNAJJ + (ulong)IGNEOOOFEMO[NDAAKFPMLOL];
		IGNEOOOFEMO[NDAAKFPMLOL] = (uint)num;
		num >>= 32;
		return (num != 0) ? DKCBNAFCCMF(NBEDPKHALCN, IGNEOOOFEMO, NDAAKFPMLOL, 1) : 0u;
	}

	public static void FDCFKGAEJFF(int NBEDPKHALCN, uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		Array.Copy(AMFCENFNAJJ, 0, IGNEOOOFEMO, 0, NBEDPKHALCN);
	}

	public static uint[] FDCFKGAEJFF(int NBEDPKHALCN, uint[] AMFCENFNAJJ)
	{
		uint[] array = new uint[NBEDPKHALCN];
		Array.Copy(AMFCENFNAJJ, 0, array, 0, NBEDPKHALCN);
		return array;
	}

	public static uint[] PLIFFMMBNPM(int NBEDPKHALCN)
	{
		return new uint[NBEDPKHALCN];
	}

	public static ulong[] JLMPJDKAODG(int NBEDPKHALCN)
	{
		return new ulong[NBEDPKHALCN];
	}

	public static int KJFCLPNALMG(int NBEDPKHALCN, uint[] IGNEOOOFEMO)
	{
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			if (--IGNEOOOFEMO[i] != uint.MaxValue)
			{
				return 0;
			}
		}
		return -1;
	}

	public static int KJFCLPNALMG(int NBEDPKHALCN, uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		int i = 0;
		while (i < NBEDPKHALCN)
		{
			uint num = (IGNEOOOFEMO[i] = AMFCENFNAJJ[i] - 1);
			i++;
			if (num != uint.MaxValue)
			{
				for (; i < NBEDPKHALCN; i++)
				{
					IGNEOOOFEMO[i] = AMFCENFNAJJ[i];
				}
				return 0;
			}
		}
		return -1;
	}

	public static int MEJBLKJLLNK(int NBEDPKHALCN, uint[] IGNEOOOFEMO, int DPAKEPKLHJF)
	{
		for (int i = DPAKEPKLHJF; i < NBEDPKHALCN; i++)
		{
			if (--IGNEOOOFEMO[i] != uint.MaxValue)
			{
				return 0;
			}
		}
		return -1;
	}

	public static int MEJBLKJLLNK(int NBEDPKHALCN, uint[] IGNEOOOFEMO, int NDAAKFPMLOL, int DPAKEPKLHJF)
	{
		for (int i = DPAKEPKLHJF; i < NBEDPKHALCN; i++)
		{
			if (--IGNEOOOFEMO[NDAAKFPMLOL + i] != uint.MaxValue)
			{
				return 0;
			}
		}
		return -1;
	}

	public static bool HIPMIOOIEJO(int NBEDPKHALCN, uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ)
	{
		for (int num = NBEDPKHALCN - 1; num >= 0; num--)
		{
			if (AMFCENFNAJJ[num] != CNLILOEEBOJ[num])
			{
				return false;
			}
		}
		return true;
	}

	public static uint[] HFENNGHNFLF(int IODPDKHNDIE, BigInteger AMFCENFNAJJ)
	{
		if (AMFCENFNAJJ.SignValue < 0 || AMFCENFNAJJ.BitLength > IODPDKHNDIE)
		{
			throw new ArgumentException();
		}
		int nBEDPKHALCN = IODPDKHNDIE + 31 >> 5;
		uint[] array = PLIFFMMBNPM(nBEDPKHALCN);
		int num = 0;
		while (AMFCENFNAJJ.SignValue != 0)
		{
			array[num++] = (uint)AMFCENFNAJJ.IntValue;
			AMFCENFNAJJ = AMFCENFNAJJ.ABOIOKBIANB(32);
		}
		return array;
	}

	public static uint DOFLEKCIDCA(uint[] AMFCENFNAJJ, int DCBMAGOBBEC)
	{
		if (DCBMAGOBBEC == 0)
		{
			return AMFCENFNAJJ[0] & 1u;
		}
		int num = DCBMAGOBBEC >> 5;
		if (num < 0 || num >= AMFCENFNAJJ.Length)
		{
			return 0u;
		}
		int num2 = DCBMAGOBBEC & 0x1F;
		return (AMFCENFNAJJ[num] >> num2) & 1u;
	}

	public static bool CHCGDEIGIIA(int NBEDPKHALCN, uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ)
	{
		for (int num = NBEDPKHALCN - 1; num >= 0; num--)
		{
			uint num2 = AMFCENFNAJJ[num];
			uint num3 = CNLILOEEBOJ[num];
			if (num2 < num3)
			{
				return false;
			}
			if (num2 > num3)
			{
				return true;
			}
		}
		return true;
	}

	public static uint CKIHMFAAHLM(int NBEDPKHALCN, uint[] IGNEOOOFEMO)
	{
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			if (++IGNEOOOFEMO[i] != 0)
			{
				return 0u;
			}
		}
		return 1u;
	}

	public static uint CKIHMFAAHLM(int NBEDPKHALCN, uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		int i = 0;
		while (i < NBEDPKHALCN)
		{
			uint num = (IGNEOOOFEMO[i] = AMFCENFNAJJ[i] + 1);
			i++;
			if (num != 0)
			{
				for (; i < NBEDPKHALCN; i++)
				{
					IGNEOOOFEMO[i] = AMFCENFNAJJ[i];
				}
				return 0u;
			}
		}
		return 1u;
	}

	public static uint DKCBNAFCCMF(int NBEDPKHALCN, uint[] IGNEOOOFEMO, int DPAKEPKLHJF)
	{
		for (int i = DPAKEPKLHJF; i < NBEDPKHALCN; i++)
		{
			if (++IGNEOOOFEMO[i] != 0)
			{
				return 0u;
			}
		}
		return 1u;
	}

	public static uint DKCBNAFCCMF(int NBEDPKHALCN, uint[] IGNEOOOFEMO, int NDAAKFPMLOL, int DPAKEPKLHJF)
	{
		for (int i = DPAKEPKLHJF; i < NBEDPKHALCN; i++)
		{
			if (++IGNEOOOFEMO[NDAAKFPMLOL + i] != 0)
			{
				return 0u;
			}
		}
		return 1u;
	}

	public static bool EOJCHPEGABD(int NBEDPKHALCN, uint[] AMFCENFNAJJ)
	{
		if (AMFCENFNAJJ[0] != 1)
		{
			return false;
		}
		for (int i = 1; i < NBEDPKHALCN; i++)
		{
			if (AMFCENFNAJJ[i] != 0)
			{
				return false;
			}
		}
		return true;
	}

	public static bool EJJHHCOFAAI(int NBEDPKHALCN, uint[] AMFCENFNAJJ)
	{
		if (AMFCENFNAJJ[0] != 0)
		{
			return false;
		}
		for (int i = 1; i < NBEDPKHALCN; i++)
		{
			if (AMFCENFNAJJ[i] != 0)
			{
				return false;
			}
		}
		return true;
	}

	public static void BMEIFJDODCF(int NBEDPKHALCN, uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] JMNJPLAGDDJ)
	{
		JMNJPLAGDDJ[NBEDPKHALCN] = MGFGBGHAJNO(NBEDPKHALCN, AMFCENFNAJJ[0], CNLILOEEBOJ, JMNJPLAGDDJ);
		for (int i = 1; i < NBEDPKHALCN; i++)
		{
			JMNJPLAGDDJ[i + NBEDPKHALCN] = HAFIKHOEMNC(NBEDPKHALCN, AMFCENFNAJJ[i], CNLILOEEBOJ, 0, JMNJPLAGDDJ, i);
		}
	}

	public static void BMEIFJDODCF(int NBEDPKHALCN, uint[] AMFCENFNAJJ, int ABBPDEOGNFE, uint[] CNLILOEEBOJ, int HGNFOMNFIDD, uint[] JMNJPLAGDDJ, int IHCMHKCMELO)
	{
		JMNJPLAGDDJ[IHCMHKCMELO + NBEDPKHALCN] = MGFGBGHAJNO(NBEDPKHALCN, AMFCENFNAJJ[ABBPDEOGNFE], CNLILOEEBOJ, HGNFOMNFIDD, JMNJPLAGDDJ, IHCMHKCMELO);
		for (int i = 1; i < NBEDPKHALCN; i++)
		{
			JMNJPLAGDDJ[IHCMHKCMELO + i + NBEDPKHALCN] = HAFIKHOEMNC(NBEDPKHALCN, AMFCENFNAJJ[ABBPDEOGNFE + i], CNLILOEEBOJ, HGNFOMNFIDD, JMNJPLAGDDJ, IHCMHKCMELO + i);
		}
	}

	public static uint ACPCGFGJIHE(int NBEDPKHALCN, uint MNIMEAMHNMI, uint[] AMFCENFNAJJ, uint BCIHLCMFAEK, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = 0uL;
		ulong num2 = MNIMEAMHNMI;
		ulong num3 = BCIHLCMFAEK;
		int num4 = 0;
		do
		{
			num += num2 * AMFCENFNAJJ[num4] + num3 * CNLILOEEBOJ[num4] + IGNEOOOFEMO[NDAAKFPMLOL + num4];
			IGNEOOOFEMO[NDAAKFPMLOL + num4] = (uint)num;
			num >>= 32;
		}
		while (++num4 < NBEDPKHALCN);
		return (uint)num;
	}

	public static uint MGFGBGHAJNO(int NBEDPKHALCN, uint AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		ulong num = 0uL;
		ulong num2 = AMFCENFNAJJ;
		int num3 = 0;
		do
		{
			num += num2 * CNLILOEEBOJ[num3];
			IGNEOOOFEMO[num3] = (uint)num;
			num >>= 32;
		}
		while (++num3 < NBEDPKHALCN);
		return (uint)num;
	}

	public static uint MGFGBGHAJNO(int NBEDPKHALCN, uint AMFCENFNAJJ, uint[] CNLILOEEBOJ, int HGNFOMNFIDD, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = 0uL;
		ulong num2 = AMFCENFNAJJ;
		int num3 = 0;
		do
		{
			num += num2 * CNLILOEEBOJ[HGNFOMNFIDD + num3];
			IGNEOOOFEMO[NDAAKFPMLOL + num3] = (uint)num;
			num >>= 32;
		}
		while (++num3 < NBEDPKHALCN);
		return (uint)num;
	}

	public static uint HAFIKHOEMNC(int NBEDPKHALCN, uint AMFCENFNAJJ, uint[] CNLILOEEBOJ, int HGNFOMNFIDD, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = 0uL;
		ulong num2 = AMFCENFNAJJ;
		int num3 = 0;
		do
		{
			num += num2 * CNLILOEEBOJ[HGNFOMNFIDD + num3] + IGNEOOOFEMO[NDAAKFPMLOL + num3];
			IGNEOOOFEMO[NDAAKFPMLOL + num3] = (uint)num;
			num >>= 32;
		}
		while (++num3 < NBEDPKHALCN);
		return (uint)num;
	}

	public static uint LLFOALGKFEN(int NBEDPKHALCN, uint AMFCENFNAJJ, ulong CNLILOEEBOJ, uint[] IGNEOOOFEMO, int DPAKEPKLHJF)
	{
		ulong num = 0uL;
		ulong num2 = AMFCENFNAJJ;
		num += num2 * (uint)CNLILOEEBOJ + IGNEOOOFEMO[DPAKEPKLHJF];
		IGNEOOOFEMO[DPAKEPKLHJF] = (uint)num;
		num >>= 32;
		num += num2 * (CNLILOEEBOJ >> 32) + IGNEOOOFEMO[DPAKEPKLHJF + 1];
		IGNEOOOFEMO[DPAKEPKLHJF + 1] = (uint)num;
		num >>= 32;
		num += IGNEOOOFEMO[DPAKEPKLHJF + 2];
		IGNEOOOFEMO[DPAKEPKLHJF + 2] = (uint)num;
		num >>= 32;
		return (num != 0) ? DKCBNAFCCMF(NBEDPKHALCN, IGNEOOOFEMO, DPAKEPKLHJF + 3) : 0u;
	}

	public static uint POFAGJIFAIH(int NBEDPKHALCN, uint[] IGNEOOOFEMO, uint FMFABAKPMLB)
	{
		int num = NBEDPKHALCN;
		while (--num >= 0)
		{
			uint num2 = IGNEOOOFEMO[num];
			IGNEOOOFEMO[num] = (num2 >> 1) | (FMFABAKPMLB << 31);
			FMFABAKPMLB = num2;
		}
		return FMFABAKPMLB << 31;
	}

	public static uint POFAGJIFAIH(int NBEDPKHALCN, uint[] IGNEOOOFEMO, int NDAAKFPMLOL, uint FMFABAKPMLB)
	{
		int num = NBEDPKHALCN;
		while (--num >= 0)
		{
			uint num2 = IGNEOOOFEMO[NDAAKFPMLOL + num];
			IGNEOOOFEMO[NDAAKFPMLOL + num] = (num2 >> 1) | (FMFABAKPMLB << 31);
			FMFABAKPMLB = num2;
		}
		return FMFABAKPMLB << 31;
	}

	public static uint POFAGJIFAIH(int NBEDPKHALCN, uint[] AMFCENFNAJJ, uint FMFABAKPMLB, uint[] IGNEOOOFEMO)
	{
		int num = NBEDPKHALCN;
		while (--num >= 0)
		{
			uint num2 = AMFCENFNAJJ[num];
			IGNEOOOFEMO[num] = (num2 >> 1) | (FMFABAKPMLB << 31);
			FMFABAKPMLB = num2;
		}
		return FMFABAKPMLB << 31;
	}

	public static uint POFAGJIFAIH(int NBEDPKHALCN, uint[] AMFCENFNAJJ, int ABBPDEOGNFE, uint FMFABAKPMLB, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		int num = NBEDPKHALCN;
		while (--num >= 0)
		{
			uint num2 = AMFCENFNAJJ[ABBPDEOGNFE + num];
			IGNEOOOFEMO[NDAAKFPMLOL + num] = (num2 >> 1) | (FMFABAKPMLB << 31);
			FMFABAKPMLB = num2;
		}
		return FMFABAKPMLB << 31;
	}

	public static uint HKHBMKOABPB(int NBEDPKHALCN, uint[] IGNEOOOFEMO, int IODPDKHNDIE, uint FMFABAKPMLB)
	{
		int num = NBEDPKHALCN;
		while (--num >= 0)
		{
			uint num2 = IGNEOOOFEMO[num];
			IGNEOOOFEMO[num] = (num2 >> IODPDKHNDIE) | (FMFABAKPMLB << -IODPDKHNDIE);
			FMFABAKPMLB = num2;
		}
		return FMFABAKPMLB << -IODPDKHNDIE;
	}

	public static uint HKHBMKOABPB(int NBEDPKHALCN, uint[] IGNEOOOFEMO, int NDAAKFPMLOL, int IODPDKHNDIE, uint FMFABAKPMLB)
	{
		int num = NBEDPKHALCN;
		while (--num >= 0)
		{
			uint num2 = IGNEOOOFEMO[NDAAKFPMLOL + num];
			IGNEOOOFEMO[NDAAKFPMLOL + num] = (num2 >> IODPDKHNDIE) | (FMFABAKPMLB << -IODPDKHNDIE);
			FMFABAKPMLB = num2;
		}
		return FMFABAKPMLB << -IODPDKHNDIE;
	}

	public static uint HKHBMKOABPB(int NBEDPKHALCN, uint[] AMFCENFNAJJ, int IODPDKHNDIE, uint FMFABAKPMLB, uint[] IGNEOOOFEMO)
	{
		int num = NBEDPKHALCN;
		while (--num >= 0)
		{
			uint num2 = AMFCENFNAJJ[num];
			IGNEOOOFEMO[num] = (num2 >> IODPDKHNDIE) | (FMFABAKPMLB << -IODPDKHNDIE);
			FMFABAKPMLB = num2;
		}
		return FMFABAKPMLB << -IODPDKHNDIE;
	}

	public static uint HKHBMKOABPB(int NBEDPKHALCN, uint[] AMFCENFNAJJ, int ABBPDEOGNFE, int IODPDKHNDIE, uint FMFABAKPMLB, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		int num = NBEDPKHALCN;
		while (--num >= 0)
		{
			uint num2 = AMFCENFNAJJ[ABBPDEOGNFE + num];
			IGNEOOOFEMO[NDAAKFPMLOL + num] = (num2 >> IODPDKHNDIE) | (FMFABAKPMLB << -IODPDKHNDIE);
			FMFABAKPMLB = num2;
		}
		return FMFABAKPMLB << -IODPDKHNDIE;
	}

	public static uint HDHPODLDFNA(int NBEDPKHALCN, uint[] IGNEOOOFEMO, uint FMFABAKPMLB)
	{
		int num = NBEDPKHALCN;
		while (--num >= 0)
		{
			uint num2 = IGNEOOOFEMO[num];
			IGNEOOOFEMO[num] = FMFABAKPMLB;
			FMFABAKPMLB = num2;
		}
		return FMFABAKPMLB;
	}

	public static uint FKEFFJALNJM(int NBEDPKHALCN, uint[] IGNEOOOFEMO, uint FMFABAKPMLB)
	{
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			uint num = IGNEOOOFEMO[i];
			IGNEOOOFEMO[i] = (num << 1) | (FMFABAKPMLB >> 31);
			FMFABAKPMLB = num;
		}
		return FMFABAKPMLB >> 31;
	}

	public static uint FKEFFJALNJM(int NBEDPKHALCN, uint[] IGNEOOOFEMO, int NDAAKFPMLOL, uint FMFABAKPMLB)
	{
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			uint num = IGNEOOOFEMO[NDAAKFPMLOL + i];
			IGNEOOOFEMO[NDAAKFPMLOL + i] = (num << 1) | (FMFABAKPMLB >> 31);
			FMFABAKPMLB = num;
		}
		return FMFABAKPMLB >> 31;
	}

	public static uint FKEFFJALNJM(int NBEDPKHALCN, uint[] AMFCENFNAJJ, uint FMFABAKPMLB, uint[] IGNEOOOFEMO)
	{
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			uint num = AMFCENFNAJJ[i];
			IGNEOOOFEMO[i] = (num << 1) | (FMFABAKPMLB >> 31);
			FMFABAKPMLB = num;
		}
		return FMFABAKPMLB >> 31;
	}

	public static uint FKEFFJALNJM(int NBEDPKHALCN, uint[] AMFCENFNAJJ, int ABBPDEOGNFE, uint FMFABAKPMLB, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			uint num = AMFCENFNAJJ[ABBPDEOGNFE + i];
			IGNEOOOFEMO[NDAAKFPMLOL + i] = (num << 1) | (FMFABAKPMLB >> 31);
			FMFABAKPMLB = num;
		}
		return FMFABAKPMLB >> 31;
	}

	public static ulong KCONODDHKAH(int NBEDPKHALCN, ulong[] AMFCENFNAJJ, int ABBPDEOGNFE, ulong FMFABAKPMLB, ulong[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			ulong num = AMFCENFNAJJ[ABBPDEOGNFE + i];
			IGNEOOOFEMO[NDAAKFPMLOL + i] = (num << 1) | (FMFABAKPMLB >> 63);
			FMFABAKPMLB = num;
		}
		return FMFABAKPMLB >> 63;
	}

	public static uint BJPLEKMGBJA(int NBEDPKHALCN, uint[] IGNEOOOFEMO, int IODPDKHNDIE, uint FMFABAKPMLB)
	{
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			uint num = IGNEOOOFEMO[i];
			IGNEOOOFEMO[i] = (num << IODPDKHNDIE) | (FMFABAKPMLB >> -IODPDKHNDIE);
			FMFABAKPMLB = num;
		}
		return FMFABAKPMLB >> -IODPDKHNDIE;
	}

	public static uint BJPLEKMGBJA(int NBEDPKHALCN, uint[] IGNEOOOFEMO, int NDAAKFPMLOL, int IODPDKHNDIE, uint FMFABAKPMLB)
	{
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			uint num = IGNEOOOFEMO[NDAAKFPMLOL + i];
			IGNEOOOFEMO[NDAAKFPMLOL + i] = (num << IODPDKHNDIE) | (FMFABAKPMLB >> -IODPDKHNDIE);
			FMFABAKPMLB = num;
		}
		return FMFABAKPMLB >> -IODPDKHNDIE;
	}

	public static ulong IFHPIPOFGIN(int NBEDPKHALCN, ulong[] IGNEOOOFEMO, int NDAAKFPMLOL, int IODPDKHNDIE, ulong FMFABAKPMLB)
	{
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			ulong num = IGNEOOOFEMO[NDAAKFPMLOL + i];
			IGNEOOOFEMO[NDAAKFPMLOL + i] = (num << IODPDKHNDIE) | (FMFABAKPMLB >> -IODPDKHNDIE);
			FMFABAKPMLB = num;
		}
		return FMFABAKPMLB >> -IODPDKHNDIE;
	}

	public static uint BJPLEKMGBJA(int NBEDPKHALCN, uint[] AMFCENFNAJJ, int IODPDKHNDIE, uint FMFABAKPMLB, uint[] IGNEOOOFEMO)
	{
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			uint num = AMFCENFNAJJ[i];
			IGNEOOOFEMO[i] = (num << IODPDKHNDIE) | (FMFABAKPMLB >> -IODPDKHNDIE);
			FMFABAKPMLB = num;
		}
		return FMFABAKPMLB >> -IODPDKHNDIE;
	}

	public static uint BJPLEKMGBJA(int NBEDPKHALCN, uint[] AMFCENFNAJJ, int ABBPDEOGNFE, int IODPDKHNDIE, uint FMFABAKPMLB, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			uint num = AMFCENFNAJJ[ABBPDEOGNFE + i];
			IGNEOOOFEMO[NDAAKFPMLOL + i] = (num << IODPDKHNDIE) | (FMFABAKPMLB >> -IODPDKHNDIE);
			FMFABAKPMLB = num;
		}
		return FMFABAKPMLB >> -IODPDKHNDIE;
	}

	public static ulong IFHPIPOFGIN(int NBEDPKHALCN, ulong[] AMFCENFNAJJ, int ABBPDEOGNFE, int IODPDKHNDIE, ulong FMFABAKPMLB, ulong[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			ulong num = AMFCENFNAJJ[ABBPDEOGNFE + i];
			IGNEOOOFEMO[NDAAKFPMLOL + i] = (num << IODPDKHNDIE) | (FMFABAKPMLB >> -IODPDKHNDIE);
			FMFABAKPMLB = num;
		}
		return FMFABAKPMLB >> -IODPDKHNDIE;
	}

	public static void MIOEHGDPGAG(int NBEDPKHALCN, uint[] AMFCENFNAJJ, uint[] JMNJPLAGDDJ)
	{
		int num = NBEDPKHALCN << 1;
		uint num2 = 0u;
		int num3 = NBEDPKHALCN;
		int num4 = num;
		do
		{
			ulong num5 = AMFCENFNAJJ[--num3];
			ulong num6 = num5 * num5;
			JMNJPLAGDDJ[--num4] = (num2 << 31) | (uint)(int)(num6 >> 33);
			JMNJPLAGDDJ[--num4] = (uint)(num6 >> 1);
			num2 = (uint)num6;
		}
		while (num3 > 0);
		for (int i = 1; i < NBEDPKHALCN; i++)
		{
			num2 = JEHHLDJMJCM(AMFCENFNAJJ, i, JMNJPLAGDDJ);
			HNPBCAPBDGJ(num, num2, JMNJPLAGDDJ, i << 1);
		}
		FKEFFJALNJM(num, JMNJPLAGDDJ, AMFCENFNAJJ[0] << 31);
	}

	public static void MIOEHGDPGAG(int NBEDPKHALCN, uint[] AMFCENFNAJJ, int ABBPDEOGNFE, uint[] JMNJPLAGDDJ, int IHCMHKCMELO)
	{
		int num = NBEDPKHALCN << 1;
		uint num2 = 0u;
		int num3 = NBEDPKHALCN;
		int num4 = num;
		do
		{
			ulong num5 = AMFCENFNAJJ[ABBPDEOGNFE + --num3];
			ulong num6 = num5 * num5;
			JMNJPLAGDDJ[IHCMHKCMELO + --num4] = (num2 << 31) | (uint)(int)(num6 >> 33);
			JMNJPLAGDDJ[IHCMHKCMELO + --num4] = (uint)(num6 >> 1);
			num2 = (uint)num6;
		}
		while (num3 > 0);
		for (int i = 1; i < NBEDPKHALCN; i++)
		{
			num2 = JEHHLDJMJCM(AMFCENFNAJJ, ABBPDEOGNFE, i, JMNJPLAGDDJ, IHCMHKCMELO);
			HNPBCAPBDGJ(num, num2, JMNJPLAGDDJ, IHCMHKCMELO, i << 1);
		}
		FKEFFJALNJM(num, JMNJPLAGDDJ, IHCMHKCMELO, AMFCENFNAJJ[ABBPDEOGNFE] << 31);
	}

	public static uint JEHHLDJMJCM(uint[] AMFCENFNAJJ, int MPIPEENBKFK, uint[] IGNEOOOFEMO)
	{
		ulong num = 0uL;
		ulong num2 = AMFCENFNAJJ[MPIPEENBKFK];
		int num3 = 0;
		do
		{
			num += num2 * AMFCENFNAJJ[num3] + IGNEOOOFEMO[MPIPEENBKFK + num3];
			IGNEOOOFEMO[MPIPEENBKFK + num3] = (uint)num;
			num >>= 32;
		}
		while (++num3 < MPIPEENBKFK);
		return (uint)num;
	}

	public static uint JEHHLDJMJCM(uint[] AMFCENFNAJJ, int ABBPDEOGNFE, int MPIPEENBKFK, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = 0uL;
		ulong num2 = AMFCENFNAJJ[ABBPDEOGNFE + MPIPEENBKFK];
		int num3 = 0;
		do
		{
			num += num2 * ((ulong)AMFCENFNAJJ[ABBPDEOGNFE + num3] & 0xFFFFFFFFuL) + ((ulong)IGNEOOOFEMO[MPIPEENBKFK + NDAAKFPMLOL] & 0xFFFFFFFFuL);
			IGNEOOOFEMO[MPIPEENBKFK + NDAAKFPMLOL] = (uint)num;
			num >>= 32;
			NDAAKFPMLOL++;
		}
		while (++num3 < MPIPEENBKFK);
		return (uint)num;
	}

	public static int EAEONHFLEEN(int NBEDPKHALCN, uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		long num = 0L;
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			num += (long)AMFCENFNAJJ[i] - (long)CNLILOEEBOJ[i];
			IGNEOOOFEMO[i] = (uint)num;
			num >>= 32;
		}
		return (int)num;
	}

	public static int EAEONHFLEEN(int NBEDPKHALCN, uint[] AMFCENFNAJJ, int ABBPDEOGNFE, uint[] CNLILOEEBOJ, int HGNFOMNFIDD, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		long num = 0L;
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			num += (long)AMFCENFNAJJ[ABBPDEOGNFE + i] - (long)CNLILOEEBOJ[HGNFOMNFIDD + i];
			IGNEOOOFEMO[NDAAKFPMLOL + i] = (uint)num;
			num >>= 32;
		}
		return (int)num;
	}

	public static int DFKJGKLIGJF(int NBEDPKHALCN, uint AMFCENFNAJJ, uint[] IGNEOOOFEMO, int DPAKEPKLHJF)
	{
		long num = (long)IGNEOOOFEMO[DPAKEPKLHJF] - (long)AMFCENFNAJJ;
		IGNEOOOFEMO[DPAKEPKLHJF] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[DPAKEPKLHJF + 1] - 1L;
		IGNEOOOFEMO[DPAKEPKLHJF + 1] = (uint)num;
		num >>= 32;
		return (num != 0) ? MEJBLKJLLNK(NBEDPKHALCN, IGNEOOOFEMO, DPAKEPKLHJF + 2) : 0;
	}

	public static int DFKJGKLIGJF(int NBEDPKHALCN, uint AMFCENFNAJJ, uint[] IGNEOOOFEMO, int NDAAKFPMLOL, int DPAKEPKLHJF)
	{
		long num = (long)IGNEOOOFEMO[NDAAKFPMLOL + DPAKEPKLHJF] - (long)AMFCENFNAJJ;
		IGNEOOOFEMO[NDAAKFPMLOL + DPAKEPKLHJF] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[NDAAKFPMLOL + DPAKEPKLHJF + 1] - 1L;
		IGNEOOOFEMO[NDAAKFPMLOL + DPAKEPKLHJF + 1] = (uint)num;
		num >>= 32;
		return (num != 0) ? MEJBLKJLLNK(NBEDPKHALCN, IGNEOOOFEMO, NDAAKFPMLOL, DPAKEPKLHJF + 2) : 0;
	}

	public static int KGIMHKMDCKA(int NBEDPKHALCN, uint AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		long num = (long)IGNEOOOFEMO[0] - (long)AMFCENFNAJJ;
		IGNEOOOFEMO[0] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[1] - 1L;
		IGNEOOOFEMO[1] = (uint)num;
		num >>= 32;
		return (num != 0) ? MEJBLKJLLNK(NBEDPKHALCN, IGNEOOOFEMO, 2) : 0;
	}

	public static int KGIMHKMDCKA(int NBEDPKHALCN, uint AMFCENFNAJJ, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		long num = (long)IGNEOOOFEMO[NDAAKFPMLOL] - (long)AMFCENFNAJJ;
		IGNEOOOFEMO[NDAAKFPMLOL] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[NDAAKFPMLOL + 1] - 1L;
		IGNEOOOFEMO[NDAAKFPMLOL + 1] = (uint)num;
		num >>= 32;
		return (num != 0) ? MEJBLKJLLNK(NBEDPKHALCN, IGNEOOOFEMO, NDAAKFPMLOL, 2) : 0;
	}

	public static int DCBNMOKOJHD(int NBEDPKHALCN, uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		long num = 0L;
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			num += (long)IGNEOOOFEMO[i] - (long)AMFCENFNAJJ[i] - CNLILOEEBOJ[i];
			IGNEOOOFEMO[i] = (uint)num;
			num >>= 32;
		}
		return (int)num;
	}

	public static int DCBNMOKOJHD(int NBEDPKHALCN, uint[] AMFCENFNAJJ, int ABBPDEOGNFE, uint[] CNLILOEEBOJ, int HGNFOMNFIDD, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		long num = 0L;
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			num += (long)IGNEOOOFEMO[NDAAKFPMLOL + i] - (long)AMFCENFNAJJ[ABBPDEOGNFE + i] - CNLILOEEBOJ[HGNFOMNFIDD + i];
			IGNEOOOFEMO[NDAAKFPMLOL + i] = (uint)num;
			num >>= 32;
		}
		return (int)num;
	}

	public static int HHPIPPNGFOE(int NBEDPKHALCN, ulong AMFCENFNAJJ, uint[] IGNEOOOFEMO, int DPAKEPKLHJF)
	{
		long num = (long)(IGNEOOOFEMO[DPAKEPKLHJF] - (AMFCENFNAJJ & 0xFFFFFFFFu));
		IGNEOOOFEMO[DPAKEPKLHJF] = (uint)num;
		num >>= 32;
		num += (long)(IGNEOOOFEMO[DPAKEPKLHJF + 1] - (AMFCENFNAJJ >> 32));
		IGNEOOOFEMO[DPAKEPKLHJF + 1] = (uint)num;
		num >>= 32;
		return (num != 0) ? MEJBLKJLLNK(NBEDPKHALCN, IGNEOOOFEMO, DPAKEPKLHJF + 2) : 0;
	}

	public static int HHPIPPNGFOE(int NBEDPKHALCN, ulong AMFCENFNAJJ, uint[] IGNEOOOFEMO, int NDAAKFPMLOL, int DPAKEPKLHJF)
	{
		long num = (long)(IGNEOOOFEMO[NDAAKFPMLOL + DPAKEPKLHJF] - (AMFCENFNAJJ & 0xFFFFFFFFu));
		IGNEOOOFEMO[NDAAKFPMLOL + DPAKEPKLHJF] = (uint)num;
		num >>= 32;
		num += (long)(IGNEOOOFEMO[NDAAKFPMLOL + DPAKEPKLHJF + 1] - (AMFCENFNAJJ >> 32));
		IGNEOOOFEMO[NDAAKFPMLOL + DPAKEPKLHJF + 1] = (uint)num;
		num >>= 32;
		return (num != 0) ? MEJBLKJLLNK(NBEDPKHALCN, IGNEOOOFEMO, NDAAKFPMLOL, DPAKEPKLHJF + 2) : 0;
	}

	public static int DFDCGLLGMOH(int NBEDPKHALCN, ulong AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		long num = (long)(IGNEOOOFEMO[0] - (AMFCENFNAJJ & 0xFFFFFFFFu));
		IGNEOOOFEMO[0] = (uint)num;
		num >>= 32;
		num += (long)(IGNEOOOFEMO[1] - (AMFCENFNAJJ >> 32));
		IGNEOOOFEMO[1] = (uint)num;
		num >>= 32;
		return (num != 0) ? MEJBLKJLLNK(NBEDPKHALCN, IGNEOOOFEMO, 2) : 0;
	}

	public static int DFDCGLLGMOH(int NBEDPKHALCN, ulong AMFCENFNAJJ, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		long num = (long)(IGNEOOOFEMO[NDAAKFPMLOL] - (AMFCENFNAJJ & 0xFFFFFFFFu));
		IGNEOOOFEMO[NDAAKFPMLOL] = (uint)num;
		num >>= 32;
		num += (long)(IGNEOOOFEMO[NDAAKFPMLOL + 1] - (AMFCENFNAJJ >> 32));
		IGNEOOOFEMO[NDAAKFPMLOL + 1] = (uint)num;
		num >>= 32;
		return (num != 0) ? MEJBLKJLLNK(NBEDPKHALCN, IGNEOOOFEMO, NDAAKFPMLOL, 2) : 0;
	}

	public static int DKAMAFLMHEJ(int NBEDPKHALCN, uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		long num = 0L;
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			num += (long)IGNEOOOFEMO[i] - (long)AMFCENFNAJJ[i];
			IGNEOOOFEMO[i] = (uint)num;
			num >>= 32;
		}
		return (int)num;
	}

	public static int DKAMAFLMHEJ(int NBEDPKHALCN, uint[] AMFCENFNAJJ, int ABBPDEOGNFE, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		long num = 0L;
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			num += (long)IGNEOOOFEMO[NDAAKFPMLOL + i] - (long)AMFCENFNAJJ[ABBPDEOGNFE + i];
			IGNEOOOFEMO[NDAAKFPMLOL + i] = (uint)num;
			num >>= 32;
		}
		return (int)num;
	}

	public static int FOAJCCGCNAJ(int NBEDPKHALCN, uint AMFCENFNAJJ, uint[] IGNEOOOFEMO, int DPAKEPKLHJF)
	{
		long num = (long)IGNEOOOFEMO[DPAKEPKLHJF] - (long)AMFCENFNAJJ;
		IGNEOOOFEMO[DPAKEPKLHJF] = (uint)num;
		num >>= 32;
		return (num != 0) ? MEJBLKJLLNK(NBEDPKHALCN, IGNEOOOFEMO, DPAKEPKLHJF + 1) : 0;
	}

	public static int FOAJCCGCNAJ(int NBEDPKHALCN, uint AMFCENFNAJJ, uint[] IGNEOOOFEMO, int NDAAKFPMLOL, int DPAKEPKLHJF)
	{
		long num = (long)IGNEOOOFEMO[NDAAKFPMLOL + DPAKEPKLHJF] - (long)AMFCENFNAJJ;
		IGNEOOOFEMO[NDAAKFPMLOL + DPAKEPKLHJF] = (uint)num;
		num >>= 32;
		return (num != 0) ? MEJBLKJLLNK(NBEDPKHALCN, IGNEOOOFEMO, NDAAKFPMLOL, DPAKEPKLHJF + 1) : 0;
	}

	public static int DDKHLCMFEPM(int NBEDPKHALCN, uint AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		long num = (long)IGNEOOOFEMO[0] - (long)AMFCENFNAJJ;
		IGNEOOOFEMO[0] = (uint)num;
		num >>= 32;
		return (num != 0) ? MEJBLKJLLNK(NBEDPKHALCN, IGNEOOOFEMO, 1) : 0;
	}

	public static int DDKHLCMFEPM(int NBEDPKHALCN, uint AMFCENFNAJJ, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		long num = (long)IGNEOOOFEMO[NDAAKFPMLOL] - (long)AMFCENFNAJJ;
		IGNEOOOFEMO[NDAAKFPMLOL] = (uint)num;
		num >>= 32;
		return (num != 0) ? MEJBLKJLLNK(NBEDPKHALCN, IGNEOOOFEMO, NDAAKFPMLOL, 1) : 0;
	}

	public static BigInteger DOJBPIFPALJ(int NBEDPKHALCN, uint[] AMFCENFNAJJ)
	{
		byte[] array = new byte[NBEDPKHALCN << 2];
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			uint num = AMFCENFNAJJ[i];
			if (num != 0)
			{
				PGOKFBKEOAB.MPMAFPANDLC(num, array, NBEDPKHALCN - 1 - i << 2);
			}
		}
		return new BigInteger(1, array);
	}

	public static void KEOKCFDNHPP(int NBEDPKHALCN, uint[] IGNEOOOFEMO)
	{
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			IGNEOOOFEMO[i] = 0u;
		}
	}
}
