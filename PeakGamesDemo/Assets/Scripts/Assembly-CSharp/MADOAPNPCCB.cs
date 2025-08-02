using System;
using Org.BouncyCastle.Math;

internal abstract class MADOAPNPCCB
{
	private const ulong IGBPKOOBCMA = 4294967295uL;

	public static uint JEACJNAKLDJ(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		ulong num = 0uL;
		num += (ulong)((long)AMFCENFNAJJ[0] + (long)CNLILOEEBOJ[0]);
		IGNEOOOFEMO[0] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[1] + (long)CNLILOEEBOJ[1]);
		IGNEOOOFEMO[1] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[2] + (long)CNLILOEEBOJ[2]);
		IGNEOOOFEMO[2] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[3] + (long)CNLILOEEBOJ[3]);
		IGNEOOOFEMO[3] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[4] + (long)CNLILOEEBOJ[4]);
		IGNEOOOFEMO[4] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[5] + (long)CNLILOEEBOJ[5]);
		IGNEOOOFEMO[5] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[6] + (long)CNLILOEEBOJ[6]);
		IGNEOOOFEMO[6] = (uint)num;
		num >>= 32;
		return (uint)num;
	}

	public static uint JEACJNAKLDJ(uint[] AMFCENFNAJJ, int ABBPDEOGNFE, uint[] CNLILOEEBOJ, int HGNFOMNFIDD, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = 0uL;
		num += (ulong)((long)AMFCENFNAJJ[ABBPDEOGNFE] + (long)CNLILOEEBOJ[HGNFOMNFIDD]);
		IGNEOOOFEMO[NDAAKFPMLOL] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[ABBPDEOGNFE + 1] + (long)CNLILOEEBOJ[HGNFOMNFIDD + 1]);
		IGNEOOOFEMO[NDAAKFPMLOL + 1] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[ABBPDEOGNFE + 2] + (long)CNLILOEEBOJ[HGNFOMNFIDD + 2]);
		IGNEOOOFEMO[NDAAKFPMLOL + 2] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[ABBPDEOGNFE + 3] + (long)CNLILOEEBOJ[HGNFOMNFIDD + 3]);
		IGNEOOOFEMO[NDAAKFPMLOL + 3] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[ABBPDEOGNFE + 4] + (long)CNLILOEEBOJ[HGNFOMNFIDD + 4]);
		IGNEOOOFEMO[NDAAKFPMLOL + 4] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[ABBPDEOGNFE + 5] + (long)CNLILOEEBOJ[HGNFOMNFIDD + 5]);
		IGNEOOOFEMO[NDAAKFPMLOL + 5] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[ABBPDEOGNFE + 6] + (long)CNLILOEEBOJ[HGNFOMNFIDD + 6]);
		IGNEOOOFEMO[NDAAKFPMLOL + 6] = (uint)num;
		num >>= 32;
		return (uint)num;
	}

	public static uint FIBDFFPCDGC(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		ulong num = 0uL;
		num += (ulong)((long)AMFCENFNAJJ[0] + (long)CNLILOEEBOJ[0] + IGNEOOOFEMO[0]);
		IGNEOOOFEMO[0] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[1] + (long)CNLILOEEBOJ[1] + IGNEOOOFEMO[1]);
		IGNEOOOFEMO[1] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[2] + (long)CNLILOEEBOJ[2] + IGNEOOOFEMO[2]);
		IGNEOOOFEMO[2] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[3] + (long)CNLILOEEBOJ[3] + IGNEOOOFEMO[3]);
		IGNEOOOFEMO[3] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[4] + (long)CNLILOEEBOJ[4] + IGNEOOOFEMO[4]);
		IGNEOOOFEMO[4] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[5] + (long)CNLILOEEBOJ[5] + IGNEOOOFEMO[5]);
		IGNEOOOFEMO[5] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[6] + (long)CNLILOEEBOJ[6] + IGNEOOOFEMO[6]);
		IGNEOOOFEMO[6] = (uint)num;
		num >>= 32;
		return (uint)num;
	}

	public static uint FIBDFFPCDGC(uint[] AMFCENFNAJJ, int ABBPDEOGNFE, uint[] CNLILOEEBOJ, int HGNFOMNFIDD, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = 0uL;
		num += (ulong)((long)AMFCENFNAJJ[ABBPDEOGNFE] + (long)CNLILOEEBOJ[HGNFOMNFIDD] + IGNEOOOFEMO[NDAAKFPMLOL]);
		IGNEOOOFEMO[NDAAKFPMLOL] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[ABBPDEOGNFE + 1] + (long)CNLILOEEBOJ[HGNFOMNFIDD + 1] + IGNEOOOFEMO[NDAAKFPMLOL + 1]);
		IGNEOOOFEMO[NDAAKFPMLOL + 1] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[ABBPDEOGNFE + 2] + (long)CNLILOEEBOJ[HGNFOMNFIDD + 2] + IGNEOOOFEMO[NDAAKFPMLOL + 2]);
		IGNEOOOFEMO[NDAAKFPMLOL + 2] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[ABBPDEOGNFE + 3] + (long)CNLILOEEBOJ[HGNFOMNFIDD + 3] + IGNEOOOFEMO[NDAAKFPMLOL + 3]);
		IGNEOOOFEMO[NDAAKFPMLOL + 3] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[ABBPDEOGNFE + 4] + (long)CNLILOEEBOJ[HGNFOMNFIDD + 4] + IGNEOOOFEMO[NDAAKFPMLOL + 4]);
		IGNEOOOFEMO[NDAAKFPMLOL + 4] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[ABBPDEOGNFE + 5] + (long)CNLILOEEBOJ[HGNFOMNFIDD + 5] + IGNEOOOFEMO[NDAAKFPMLOL + 5]);
		IGNEOOOFEMO[NDAAKFPMLOL + 5] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[ABBPDEOGNFE + 6] + (long)CNLILOEEBOJ[HGNFOMNFIDD + 6] + IGNEOOOFEMO[NDAAKFPMLOL + 6]);
		IGNEOOOFEMO[NDAAKFPMLOL + 6] = (uint)num;
		num >>= 32;
		return (uint)num;
	}

	public static uint MAALDEFJPJA(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		ulong num = 0uL;
		num += (ulong)((long)AMFCENFNAJJ[0] + (long)IGNEOOOFEMO[0]);
		IGNEOOOFEMO[0] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[1] + (long)IGNEOOOFEMO[1]);
		IGNEOOOFEMO[1] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[2] + (long)IGNEOOOFEMO[2]);
		IGNEOOOFEMO[2] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[3] + (long)IGNEOOOFEMO[3]);
		IGNEOOOFEMO[3] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[4] + (long)IGNEOOOFEMO[4]);
		IGNEOOOFEMO[4] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[5] + (long)IGNEOOOFEMO[5]);
		IGNEOOOFEMO[5] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[6] + (long)IGNEOOOFEMO[6]);
		IGNEOOOFEMO[6] = (uint)num;
		num >>= 32;
		return (uint)num;
	}

	public static uint MAALDEFJPJA(uint[] AMFCENFNAJJ, int ABBPDEOGNFE, uint[] IGNEOOOFEMO, int NDAAKFPMLOL, uint EFEEMAAFCMH)
	{
		ulong num = EFEEMAAFCMH;
		num += (ulong)((long)AMFCENFNAJJ[ABBPDEOGNFE] + (long)IGNEOOOFEMO[NDAAKFPMLOL]);
		IGNEOOOFEMO[NDAAKFPMLOL] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[ABBPDEOGNFE + 1] + (long)IGNEOOOFEMO[NDAAKFPMLOL + 1]);
		IGNEOOOFEMO[NDAAKFPMLOL + 1] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[ABBPDEOGNFE + 2] + (long)IGNEOOOFEMO[NDAAKFPMLOL + 2]);
		IGNEOOOFEMO[NDAAKFPMLOL + 2] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[ABBPDEOGNFE + 3] + (long)IGNEOOOFEMO[NDAAKFPMLOL + 3]);
		IGNEOOOFEMO[NDAAKFPMLOL + 3] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[ABBPDEOGNFE + 4] + (long)IGNEOOOFEMO[NDAAKFPMLOL + 4]);
		IGNEOOOFEMO[NDAAKFPMLOL + 4] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[ABBPDEOGNFE + 5] + (long)IGNEOOOFEMO[NDAAKFPMLOL + 5]);
		IGNEOOOFEMO[NDAAKFPMLOL + 5] = (uint)num;
		num >>= 32;
		num += (ulong)((long)AMFCENFNAJJ[ABBPDEOGNFE + 6] + (long)IGNEOOOFEMO[NDAAKFPMLOL + 6]);
		IGNEOOOFEMO[NDAAKFPMLOL + 6] = (uint)num;
		num >>= 32;
		return (uint)num;
	}

	public static uint HFHBOBLBLDH(uint[] OJOAGEHFPNP, int AMLHEOCHLKC, uint[] AAIEJDNAODP, int FOKCGBLKIGD)
	{
		ulong num = 0uL;
		num += (ulong)((long)OJOAGEHFPNP[AMLHEOCHLKC] + (long)AAIEJDNAODP[FOKCGBLKIGD]);
		OJOAGEHFPNP[AMLHEOCHLKC] = (uint)num;
		AAIEJDNAODP[FOKCGBLKIGD] = (uint)num;
		num >>= 32;
		num += (ulong)((long)OJOAGEHFPNP[AMLHEOCHLKC + 1] + (long)AAIEJDNAODP[FOKCGBLKIGD + 1]);
		OJOAGEHFPNP[AMLHEOCHLKC + 1] = (uint)num;
		AAIEJDNAODP[FOKCGBLKIGD + 1] = (uint)num;
		num >>= 32;
		num += (ulong)((long)OJOAGEHFPNP[AMLHEOCHLKC + 2] + (long)AAIEJDNAODP[FOKCGBLKIGD + 2]);
		OJOAGEHFPNP[AMLHEOCHLKC + 2] = (uint)num;
		AAIEJDNAODP[FOKCGBLKIGD + 2] = (uint)num;
		num >>= 32;
		num += (ulong)((long)OJOAGEHFPNP[AMLHEOCHLKC + 3] + (long)AAIEJDNAODP[FOKCGBLKIGD + 3]);
		OJOAGEHFPNP[AMLHEOCHLKC + 3] = (uint)num;
		AAIEJDNAODP[FOKCGBLKIGD + 3] = (uint)num;
		num >>= 32;
		num += (ulong)((long)OJOAGEHFPNP[AMLHEOCHLKC + 4] + (long)AAIEJDNAODP[FOKCGBLKIGD + 4]);
		OJOAGEHFPNP[AMLHEOCHLKC + 4] = (uint)num;
		AAIEJDNAODP[FOKCGBLKIGD + 4] = (uint)num;
		num >>= 32;
		num += (ulong)((long)OJOAGEHFPNP[AMLHEOCHLKC + 5] + (long)AAIEJDNAODP[FOKCGBLKIGD + 5]);
		OJOAGEHFPNP[AMLHEOCHLKC + 5] = (uint)num;
		AAIEJDNAODP[FOKCGBLKIGD + 5] = (uint)num;
		num >>= 32;
		num += (ulong)((long)OJOAGEHFPNP[AMLHEOCHLKC + 6] + (long)AAIEJDNAODP[FOKCGBLKIGD + 6]);
		OJOAGEHFPNP[AMLHEOCHLKC + 6] = (uint)num;
		AAIEJDNAODP[FOKCGBLKIGD + 6] = (uint)num;
		num >>= 32;
		return (uint)num;
	}

	public static void FDCFKGAEJFF(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		IGNEOOOFEMO[0] = AMFCENFNAJJ[0];
		IGNEOOOFEMO[1] = AMFCENFNAJJ[1];
		IGNEOOOFEMO[2] = AMFCENFNAJJ[2];
		IGNEOOOFEMO[3] = AMFCENFNAJJ[3];
		IGNEOOOFEMO[4] = AMFCENFNAJJ[4];
		IGNEOOOFEMO[5] = AMFCENFNAJJ[5];
		IGNEOOOFEMO[6] = AMFCENFNAJJ[6];
	}

	public static uint[] PLIFFMMBNPM()
	{
		return new uint[7];
	}

	public static uint[] DCPJKFEDHOJ()
	{
		return new uint[14];
	}

	public static bool COOLFBDPHEO(uint[] AMFCENFNAJJ, int ABBPDEOGNFE, uint[] CNLILOEEBOJ, int HGNFOMNFIDD, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		bool flag = CHCGDEIGIIA(AMFCENFNAJJ, ABBPDEOGNFE, CNLILOEEBOJ, HGNFOMNFIDD);
		if (flag)
		{
			EAEONHFLEEN(AMFCENFNAJJ, ABBPDEOGNFE, CNLILOEEBOJ, HGNFOMNFIDD, IGNEOOOFEMO, NDAAKFPMLOL);
		}
		else
		{
			EAEONHFLEEN(CNLILOEEBOJ, HGNFOMNFIDD, AMFCENFNAJJ, ABBPDEOGNFE, IGNEOOOFEMO, NDAAKFPMLOL);
		}
		return flag;
	}

	public static bool HIPMIOOIEJO(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ)
	{
		for (int num = 6; num >= 0; num--)
		{
			if (AMFCENFNAJJ[num] != CNLILOEEBOJ[num])
			{
				return false;
			}
		}
		return true;
	}

	public static uint[] HFENNGHNFLF(BigInteger AMFCENFNAJJ)
	{
		if (AMFCENFNAJJ.SignValue < 0 || AMFCENFNAJJ.BitLength > 224)
		{
			throw new ArgumentException();
		}
		uint[] array = PLIFFMMBNPM();
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
		if (num < 0 || num >= 7)
		{
			return 0u;
		}
		int num2 = DCBMAGOBBEC & 0x1F;
		return (AMFCENFNAJJ[num] >> num2) & 1u;
	}

	public static bool CHCGDEIGIIA(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ)
	{
		for (int num = 6; num >= 0; num--)
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

	public static bool CHCGDEIGIIA(uint[] AMFCENFNAJJ, int ABBPDEOGNFE, uint[] CNLILOEEBOJ, int HGNFOMNFIDD)
	{
		for (int num = 6; num >= 0; num--)
		{
			uint num2 = AMFCENFNAJJ[ABBPDEOGNFE + num];
			uint num3 = CNLILOEEBOJ[HGNFOMNFIDD + num];
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

	public static bool EOJCHPEGABD(uint[] AMFCENFNAJJ)
	{
		if (AMFCENFNAJJ[0] != 1)
		{
			return false;
		}
		for (int i = 1; i < 7; i++)
		{
			if (AMFCENFNAJJ[i] != 0)
			{
				return false;
			}
		}
		return true;
	}

	public static bool EJJHHCOFAAI(uint[] AMFCENFNAJJ)
	{
		for (int i = 0; i < 7; i++)
		{
			if (AMFCENFNAJJ[i] != 0)
			{
				return false;
			}
		}
		return true;
	}

	public static void BMEIFJDODCF(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] JMNJPLAGDDJ)
	{
		ulong num = CNLILOEEBOJ[0];
		ulong num2 = CNLILOEEBOJ[1];
		ulong num3 = CNLILOEEBOJ[2];
		ulong num4 = CNLILOEEBOJ[3];
		ulong num5 = CNLILOEEBOJ[4];
		ulong num6 = CNLILOEEBOJ[5];
		ulong num7 = CNLILOEEBOJ[6];
		ulong num8 = 0uL;
		ulong num9 = AMFCENFNAJJ[0];
		num8 += num9 * num;
		JMNJPLAGDDJ[0] = (uint)num8;
		num8 >>= 32;
		num8 += num9 * num2;
		JMNJPLAGDDJ[1] = (uint)num8;
		num8 >>= 32;
		num8 += num9 * num3;
		JMNJPLAGDDJ[2] = (uint)num8;
		num8 >>= 32;
		num8 += num9 * num4;
		JMNJPLAGDDJ[3] = (uint)num8;
		num8 >>= 32;
		num8 += num9 * num5;
		JMNJPLAGDDJ[4] = (uint)num8;
		num8 >>= 32;
		num8 += num9 * num6;
		JMNJPLAGDDJ[5] = (uint)num8;
		num8 >>= 32;
		num8 += num9 * num7;
		JMNJPLAGDDJ[6] = (uint)num8;
		num8 >>= 32;
		JMNJPLAGDDJ[7] = (uint)num8;
		for (int i = 1; i < 7; i++)
		{
			ulong num10 = 0uL;
			ulong num11 = AMFCENFNAJJ[i];
			num10 += num11 * num + JMNJPLAGDDJ[i];
			JMNJPLAGDDJ[i] = (uint)num10;
			num10 >>= 32;
			num10 += num11 * num2 + JMNJPLAGDDJ[i + 1];
			JMNJPLAGDDJ[i + 1] = (uint)num10;
			num10 >>= 32;
			num10 += num11 * num3 + JMNJPLAGDDJ[i + 2];
			JMNJPLAGDDJ[i + 2] = (uint)num10;
			num10 >>= 32;
			num10 += num11 * num4 + JMNJPLAGDDJ[i + 3];
			JMNJPLAGDDJ[i + 3] = (uint)num10;
			num10 >>= 32;
			num10 += num11 * num5 + JMNJPLAGDDJ[i + 4];
			JMNJPLAGDDJ[i + 4] = (uint)num10;
			num10 >>= 32;
			num10 += num11 * num6 + JMNJPLAGDDJ[i + 5];
			JMNJPLAGDDJ[i + 5] = (uint)num10;
			num10 >>= 32;
			num10 += num11 * num7 + JMNJPLAGDDJ[i + 6];
			JMNJPLAGDDJ[i + 6] = (uint)num10;
			num10 >>= 32;
			JMNJPLAGDDJ[i + 7] = (uint)num10;
		}
	}

	public static void BMEIFJDODCF(uint[] AMFCENFNAJJ, int ABBPDEOGNFE, uint[] CNLILOEEBOJ, int HGNFOMNFIDD, uint[] JMNJPLAGDDJ, int IHCMHKCMELO)
	{
		ulong num = CNLILOEEBOJ[HGNFOMNFIDD];
		ulong num2 = CNLILOEEBOJ[HGNFOMNFIDD + 1];
		ulong num3 = CNLILOEEBOJ[HGNFOMNFIDD + 2];
		ulong num4 = CNLILOEEBOJ[HGNFOMNFIDD + 3];
		ulong num5 = CNLILOEEBOJ[HGNFOMNFIDD + 4];
		ulong num6 = CNLILOEEBOJ[HGNFOMNFIDD + 5];
		ulong num7 = CNLILOEEBOJ[HGNFOMNFIDD + 6];
		ulong num8 = 0uL;
		ulong num9 = AMFCENFNAJJ[ABBPDEOGNFE];
		num8 += num9 * num;
		JMNJPLAGDDJ[IHCMHKCMELO] = (uint)num8;
		num8 >>= 32;
		num8 += num9 * num2;
		JMNJPLAGDDJ[IHCMHKCMELO + 1] = (uint)num8;
		num8 >>= 32;
		num8 += num9 * num3;
		JMNJPLAGDDJ[IHCMHKCMELO + 2] = (uint)num8;
		num8 >>= 32;
		num8 += num9 * num4;
		JMNJPLAGDDJ[IHCMHKCMELO + 3] = (uint)num8;
		num8 >>= 32;
		num8 += num9 * num5;
		JMNJPLAGDDJ[IHCMHKCMELO + 4] = (uint)num8;
		num8 >>= 32;
		num8 += num9 * num6;
		JMNJPLAGDDJ[IHCMHKCMELO + 5] = (uint)num8;
		num8 >>= 32;
		num8 += num9 * num7;
		JMNJPLAGDDJ[IHCMHKCMELO + 6] = (uint)num8;
		num8 >>= 32;
		JMNJPLAGDDJ[IHCMHKCMELO + 7] = (uint)num8;
		for (int i = 1; i < 7; i++)
		{
			IHCMHKCMELO++;
			ulong num10 = 0uL;
			ulong num11 = AMFCENFNAJJ[ABBPDEOGNFE + i];
			num10 += num11 * num + JMNJPLAGDDJ[IHCMHKCMELO];
			JMNJPLAGDDJ[IHCMHKCMELO] = (uint)num10;
			num10 >>= 32;
			num10 += num11 * num2 + JMNJPLAGDDJ[IHCMHKCMELO + 1];
			JMNJPLAGDDJ[IHCMHKCMELO + 1] = (uint)num10;
			num10 >>= 32;
			num10 += num11 * num3 + JMNJPLAGDDJ[IHCMHKCMELO + 2];
			JMNJPLAGDDJ[IHCMHKCMELO + 2] = (uint)num10;
			num10 >>= 32;
			num10 += num11 * num4 + JMNJPLAGDDJ[IHCMHKCMELO + 3];
			JMNJPLAGDDJ[IHCMHKCMELO + 3] = (uint)num10;
			num10 >>= 32;
			num10 += num11 * num5 + JMNJPLAGDDJ[IHCMHKCMELO + 4];
			JMNJPLAGDDJ[IHCMHKCMELO + 4] = (uint)num10;
			num10 >>= 32;
			num10 += num11 * num6 + JMNJPLAGDDJ[IHCMHKCMELO + 5];
			JMNJPLAGDDJ[IHCMHKCMELO + 5] = (uint)num10;
			num10 >>= 32;
			num10 += num11 * num7 + JMNJPLAGDDJ[IHCMHKCMELO + 6];
			JMNJPLAGDDJ[IHCMHKCMELO + 6] = (uint)num10;
			num10 >>= 32;
			JMNJPLAGDDJ[IHCMHKCMELO + 7] = (uint)num10;
		}
	}

	public static uint HHMEIAJHDJM(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] JMNJPLAGDDJ)
	{
		ulong num = CNLILOEEBOJ[0];
		ulong num2 = CNLILOEEBOJ[1];
		ulong num3 = CNLILOEEBOJ[2];
		ulong num4 = CNLILOEEBOJ[3];
		ulong num5 = CNLILOEEBOJ[4];
		ulong num6 = CNLILOEEBOJ[5];
		ulong num7 = CNLILOEEBOJ[6];
		ulong num8 = 0uL;
		for (int i = 0; i < 7; i++)
		{
			ulong num9 = 0uL;
			ulong num10 = AMFCENFNAJJ[i];
			num9 += num10 * num + JMNJPLAGDDJ[i];
			JMNJPLAGDDJ[i] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num2 + JMNJPLAGDDJ[i + 1];
			JMNJPLAGDDJ[i + 1] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num3 + JMNJPLAGDDJ[i + 2];
			JMNJPLAGDDJ[i + 2] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num4 + JMNJPLAGDDJ[i + 3];
			JMNJPLAGDDJ[i + 3] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num5 + JMNJPLAGDDJ[i + 4];
			JMNJPLAGDDJ[i + 4] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num6 + JMNJPLAGDDJ[i + 5];
			JMNJPLAGDDJ[i + 5] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num7 + JMNJPLAGDDJ[i + 6];
			JMNJPLAGDDJ[i + 6] = (uint)num9;
			num9 >>= 32;
			num9 += num8 + JMNJPLAGDDJ[i + 7];
			JMNJPLAGDDJ[i + 7] = (uint)num9;
			num8 = num9 >> 32;
		}
		return (uint)num8;
	}

	public static uint HHMEIAJHDJM(uint[] AMFCENFNAJJ, int ABBPDEOGNFE, uint[] CNLILOEEBOJ, int HGNFOMNFIDD, uint[] JMNJPLAGDDJ, int IHCMHKCMELO)
	{
		ulong num = CNLILOEEBOJ[HGNFOMNFIDD];
		ulong num2 = CNLILOEEBOJ[HGNFOMNFIDD + 1];
		ulong num3 = CNLILOEEBOJ[HGNFOMNFIDD + 2];
		ulong num4 = CNLILOEEBOJ[HGNFOMNFIDD + 3];
		ulong num5 = CNLILOEEBOJ[HGNFOMNFIDD + 4];
		ulong num6 = CNLILOEEBOJ[HGNFOMNFIDD + 5];
		ulong num7 = CNLILOEEBOJ[HGNFOMNFIDD + 6];
		ulong num8 = 0uL;
		for (int i = 0; i < 7; i++)
		{
			ulong num9 = 0uL;
			ulong num10 = AMFCENFNAJJ[ABBPDEOGNFE + i];
			num9 += num10 * num + JMNJPLAGDDJ[IHCMHKCMELO];
			JMNJPLAGDDJ[IHCMHKCMELO] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num2 + JMNJPLAGDDJ[IHCMHKCMELO + 1];
			JMNJPLAGDDJ[IHCMHKCMELO + 1] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num3 + JMNJPLAGDDJ[IHCMHKCMELO + 2];
			JMNJPLAGDDJ[IHCMHKCMELO + 2] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num4 + JMNJPLAGDDJ[IHCMHKCMELO + 3];
			JMNJPLAGDDJ[IHCMHKCMELO + 3] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num5 + JMNJPLAGDDJ[IHCMHKCMELO + 4];
			JMNJPLAGDDJ[IHCMHKCMELO + 4] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num6 + JMNJPLAGDDJ[IHCMHKCMELO + 5];
			JMNJPLAGDDJ[IHCMHKCMELO + 5] = (uint)num9;
			num9 >>= 32;
			num9 += num10 * num7 + JMNJPLAGDDJ[IHCMHKCMELO + 6];
			JMNJPLAGDDJ[IHCMHKCMELO + 6] = (uint)num9;
			num9 >>= 32;
			num9 += num8 + JMNJPLAGDDJ[IHCMHKCMELO + 7];
			JMNJPLAGDDJ[IHCMHKCMELO + 7] = (uint)num9;
			num8 = num9 >> 32;
			IHCMHKCMELO++;
		}
		return (uint)num8;
	}

	public static ulong FGMIACGNJLN(uint PHFLBLJJMLI, uint[] AMFCENFNAJJ, int ABBPDEOGNFE, uint[] CNLILOEEBOJ, int HGNFOMNFIDD, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = 0uL;
		ulong num2 = PHFLBLJJMLI;
		ulong num3 = AMFCENFNAJJ[ABBPDEOGNFE];
		num += num2 * num3 + CNLILOEEBOJ[HGNFOMNFIDD];
		IGNEOOOFEMO[NDAAKFPMLOL] = (uint)num;
		num >>= 32;
		ulong num4 = AMFCENFNAJJ[ABBPDEOGNFE + 1];
		num += num2 * num4 + num3 + CNLILOEEBOJ[HGNFOMNFIDD + 1];
		IGNEOOOFEMO[NDAAKFPMLOL + 1] = (uint)num;
		num >>= 32;
		ulong num5 = AMFCENFNAJJ[ABBPDEOGNFE + 2];
		num += num2 * num5 + num4 + CNLILOEEBOJ[HGNFOMNFIDD + 2];
		IGNEOOOFEMO[NDAAKFPMLOL + 2] = (uint)num;
		num >>= 32;
		ulong num6 = AMFCENFNAJJ[ABBPDEOGNFE + 3];
		num += num2 * num6 + num5 + CNLILOEEBOJ[HGNFOMNFIDD + 3];
		IGNEOOOFEMO[NDAAKFPMLOL + 3] = (uint)num;
		num >>= 32;
		ulong num7 = AMFCENFNAJJ[ABBPDEOGNFE + 4];
		num += num2 * num7 + num6 + CNLILOEEBOJ[HGNFOMNFIDD + 4];
		IGNEOOOFEMO[NDAAKFPMLOL + 4] = (uint)num;
		num >>= 32;
		ulong num8 = AMFCENFNAJJ[ABBPDEOGNFE + 5];
		num += num2 * num8 + num7 + CNLILOEEBOJ[HGNFOMNFIDD + 5];
		IGNEOOOFEMO[NDAAKFPMLOL + 5] = (uint)num;
		num >>= 32;
		ulong num9 = AMFCENFNAJJ[ABBPDEOGNFE + 6];
		num += num2 * num9 + num8 + CNLILOEEBOJ[HGNFOMNFIDD + 6];
		IGNEOOOFEMO[NDAAKFPMLOL + 6] = (uint)num;
		num >>= 32;
		return num + num9;
	}

	public static uint DIIFNHFLJGM(uint AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		ulong num = 0uL;
		ulong num2 = AMFCENFNAJJ;
		num += num2 * IGNEOOOFEMO[0];
		IGNEOOOFEMO[0] = (uint)num;
		num >>= 32;
		num += num2 * IGNEOOOFEMO[1];
		IGNEOOOFEMO[1] = (uint)num;
		num >>= 32;
		num += num2 * IGNEOOOFEMO[2];
		IGNEOOOFEMO[2] = (uint)num;
		num >>= 32;
		num += num2 * IGNEOOOFEMO[3];
		IGNEOOOFEMO[3] = (uint)num;
		num >>= 32;
		num += num2 * IGNEOOOFEMO[4];
		IGNEOOOFEMO[4] = (uint)num;
		num >>= 32;
		num += num2 * IGNEOOOFEMO[5];
		IGNEOOOFEMO[5] = (uint)num;
		num >>= 32;
		num += num2 * IGNEOOOFEMO[6];
		IGNEOOOFEMO[6] = (uint)num;
		num >>= 32;
		return (uint)num;
	}

	public static uint MMHMACBLBPN(uint AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		ulong num = 0uL;
		ulong num2 = AMFCENFNAJJ;
		num += num2 * IGNEOOOFEMO[0] + CNLILOEEBOJ[0];
		IGNEOOOFEMO[0] = (uint)num;
		num >>= 32;
		num += num2 * IGNEOOOFEMO[1] + CNLILOEEBOJ[1];
		IGNEOOOFEMO[1] = (uint)num;
		num >>= 32;
		num += num2 * IGNEOOOFEMO[2] + CNLILOEEBOJ[2];
		IGNEOOOFEMO[2] = (uint)num;
		num >>= 32;
		num += num2 * IGNEOOOFEMO[3] + CNLILOEEBOJ[3];
		IGNEOOOFEMO[3] = (uint)num;
		num >>= 32;
		num += num2 * IGNEOOOFEMO[4] + CNLILOEEBOJ[4];
		IGNEOOOFEMO[4] = (uint)num;
		num >>= 32;
		num += num2 * IGNEOOOFEMO[5] + CNLILOEEBOJ[5];
		IGNEOOOFEMO[5] = (uint)num;
		num >>= 32;
		num += num2 * IGNEOOOFEMO[6] + CNLILOEEBOJ[6];
		IGNEOOOFEMO[6] = (uint)num;
		num >>= 32;
		return (uint)num;
	}

	public static uint HAFIKHOEMNC(uint AMFCENFNAJJ, uint[] CNLILOEEBOJ, int HGNFOMNFIDD, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = 0uL;
		ulong num2 = AMFCENFNAJJ;
		num += num2 * CNLILOEEBOJ[HGNFOMNFIDD] + IGNEOOOFEMO[NDAAKFPMLOL];
		IGNEOOOFEMO[NDAAKFPMLOL] = (uint)num;
		num >>= 32;
		num += num2 * CNLILOEEBOJ[HGNFOMNFIDD + 1] + IGNEOOOFEMO[NDAAKFPMLOL + 1];
		IGNEOOOFEMO[NDAAKFPMLOL + 1] = (uint)num;
		num >>= 32;
		num += num2 * CNLILOEEBOJ[HGNFOMNFIDD + 2] + IGNEOOOFEMO[NDAAKFPMLOL + 2];
		IGNEOOOFEMO[NDAAKFPMLOL + 2] = (uint)num;
		num >>= 32;
		num += num2 * CNLILOEEBOJ[HGNFOMNFIDD + 3] + IGNEOOOFEMO[NDAAKFPMLOL + 3];
		IGNEOOOFEMO[NDAAKFPMLOL + 3] = (uint)num;
		num >>= 32;
		num += num2 * CNLILOEEBOJ[HGNFOMNFIDD + 4] + IGNEOOOFEMO[NDAAKFPMLOL + 4];
		IGNEOOOFEMO[NDAAKFPMLOL + 4] = (uint)num;
		num >>= 32;
		num += num2 * CNLILOEEBOJ[HGNFOMNFIDD + 5] + IGNEOOOFEMO[NDAAKFPMLOL + 5];
		IGNEOOOFEMO[NDAAKFPMLOL + 5] = (uint)num;
		num >>= 32;
		num += num2 * CNLILOEEBOJ[HGNFOMNFIDD + 6] + IGNEOOOFEMO[NDAAKFPMLOL + 6];
		IGNEOOOFEMO[NDAAKFPMLOL + 6] = (uint)num;
		num >>= 32;
		return (uint)num;
	}

	public static uint CDNAAKLGHLD(uint AMFCENFNAJJ, ulong CNLILOEEBOJ, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = 0uL;
		ulong num2 = AMFCENFNAJJ;
		ulong num3 = CNLILOEEBOJ & 0xFFFFFFFFu;
		num += num2 * num3 + IGNEOOOFEMO[NDAAKFPMLOL];
		IGNEOOOFEMO[NDAAKFPMLOL] = (uint)num;
		num >>= 32;
		ulong num4 = CNLILOEEBOJ >> 32;
		num += num2 * num4 + num3 + IGNEOOOFEMO[NDAAKFPMLOL + 1];
		IGNEOOOFEMO[NDAAKFPMLOL + 1] = (uint)num;
		num >>= 32;
		num += num4 + IGNEOOOFEMO[NDAAKFPMLOL + 2];
		IGNEOOOFEMO[NDAAKFPMLOL + 2] = (uint)num;
		num >>= 32;
		num += IGNEOOOFEMO[NDAAKFPMLOL + 3];
		IGNEOOOFEMO[NDAAKFPMLOL + 3] = (uint)num;
		num >>= 32;
		return (num != 0) ? BCMDHIIJKJE.DKCBNAFCCMF(7, IGNEOOOFEMO, NDAAKFPMLOL, 4) : 0u;
	}

	public static uint KDGIJAIDNND(uint AMFCENFNAJJ, uint CNLILOEEBOJ, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = 0uL;
		ulong num2 = CNLILOEEBOJ;
		num += num2 * AMFCENFNAJJ + IGNEOOOFEMO[NDAAKFPMLOL];
		IGNEOOOFEMO[NDAAKFPMLOL] = (uint)num;
		num >>= 32;
		num += num2 + IGNEOOOFEMO[NDAAKFPMLOL + 1];
		IGNEOOOFEMO[NDAAKFPMLOL + 1] = (uint)num;
		num >>= 32;
		num += IGNEOOOFEMO[NDAAKFPMLOL + 2];
		IGNEOOOFEMO[NDAAKFPMLOL + 2] = (uint)num;
		num >>= 32;
		return (num != 0) ? BCMDHIIJKJE.DKCBNAFCCMF(7, IGNEOOOFEMO, NDAAKFPMLOL, 3) : 0u;
	}

	public static uint CAOKDJHFPEC(uint AMFCENFNAJJ, ulong CNLILOEEBOJ, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = 0uL;
		ulong num2 = AMFCENFNAJJ;
		num += num2 * CNLILOEEBOJ + IGNEOOOFEMO[NDAAKFPMLOL];
		IGNEOOOFEMO[NDAAKFPMLOL] = (uint)num;
		num >>= 32;
		num += num2 * (CNLILOEEBOJ >> 32) + IGNEOOOFEMO[NDAAKFPMLOL + 1];
		IGNEOOOFEMO[NDAAKFPMLOL + 1] = (uint)num;
		num >>= 32;
		num += IGNEOOOFEMO[NDAAKFPMLOL + 2];
		IGNEOOOFEMO[NDAAKFPMLOL + 2] = (uint)num;
		num >>= 32;
		return (num != 0) ? BCMDHIIJKJE.DKCBNAFCCMF(7, IGNEOOOFEMO, NDAAKFPMLOL, 3) : 0u;
	}

	public static uint MGFGBGHAJNO(uint AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		ulong num = 0uL;
		ulong num2 = AMFCENFNAJJ;
		int num3 = 0;
		do
		{
			num += num2 * CNLILOEEBOJ[num3];
			IGNEOOOFEMO[NDAAKFPMLOL + num3] = (uint)num;
			num >>= 32;
		}
		while (++num3 < 7);
		return (uint)num;
	}

	public static void MIOEHGDPGAG(uint[] AMFCENFNAJJ, uint[] JMNJPLAGDDJ)
	{
		ulong num = AMFCENFNAJJ[0];
		uint num2 = 0u;
		int num3 = 6;
		int num4 = 14;
		do
		{
			ulong num5 = AMFCENFNAJJ[num3--];
			ulong num6 = num5 * num5;
			JMNJPLAGDDJ[--num4] = (num2 << 31) | (uint)(int)(num6 >> 33);
			JMNJPLAGDDJ[--num4] = (uint)(num6 >> 1);
			num2 = (uint)num6;
		}
		while (num3 > 0);
		ulong num7 = num * num;
		ulong num8 = (num2 << 31) | (num7 >> 33);
		JMNJPLAGDDJ[0] = (uint)num7;
		num2 = (uint)(int)(num7 >> 32) & 1u;
		ulong num9 = AMFCENFNAJJ[1];
		ulong num10 = JMNJPLAGDDJ[2];
		num8 += num9 * num;
		uint num11 = (uint)num8;
		JMNJPLAGDDJ[1] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num10 += num8 >> 32;
		ulong num12 = AMFCENFNAJJ[2];
		ulong num13 = JMNJPLAGDDJ[3];
		ulong num14 = JMNJPLAGDDJ[4];
		num10 += num12 * num;
		num11 = (uint)num10;
		JMNJPLAGDDJ[2] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num13 += (num10 >> 32) + num12 * num9;
		num14 += num13 >> 32;
		num13 &= 0xFFFFFFFFu;
		ulong num15 = AMFCENFNAJJ[3];
		ulong num16 = JMNJPLAGDDJ[5];
		ulong num17 = JMNJPLAGDDJ[6];
		num13 += num15 * num;
		num11 = (uint)num13;
		JMNJPLAGDDJ[3] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num14 += (num13 >> 32) + num15 * num9;
		num16 += (num14 >> 32) + num15 * num12;
		num14 &= 0xFFFFFFFFu;
		num17 += num16 >> 32;
		num16 &= 0xFFFFFFFFu;
		ulong num18 = AMFCENFNAJJ[4];
		ulong num19 = JMNJPLAGDDJ[7];
		ulong num20 = JMNJPLAGDDJ[8];
		num14 += num18 * num;
		num11 = (uint)num14;
		JMNJPLAGDDJ[4] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num16 += (num14 >> 32) + num18 * num9;
		num17 += (num16 >> 32) + num18 * num12;
		num16 &= 0xFFFFFFFFu;
		num19 += (num17 >> 32) + num18 * num15;
		num17 &= 0xFFFFFFFFu;
		num20 += num19 >> 32;
		num19 &= 0xFFFFFFFFu;
		ulong num21 = AMFCENFNAJJ[5];
		ulong num22 = JMNJPLAGDDJ[9];
		ulong num23 = JMNJPLAGDDJ[10];
		num16 += num21 * num;
		num11 = (uint)num16;
		JMNJPLAGDDJ[5] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num17 += (num16 >> 32) + num21 * num9;
		num19 += (num17 >> 32) + num21 * num12;
		num17 &= 0xFFFFFFFFu;
		num20 += (num19 >> 32) + num21 * num15;
		num19 &= 0xFFFFFFFFu;
		num22 += (num20 >> 32) + num21 * num18;
		num20 &= 0xFFFFFFFFu;
		num23 += num22 >> 32;
		num22 &= 0xFFFFFFFFu;
		ulong num24 = AMFCENFNAJJ[6];
		ulong num25 = JMNJPLAGDDJ[11];
		ulong num26 = JMNJPLAGDDJ[12];
		num17 += num24 * num;
		num11 = (uint)num17;
		JMNJPLAGDDJ[6] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num19 += (num17 >> 32) + num24 * num9;
		num20 += (num19 >> 32) + num24 * num12;
		num22 += (num20 >> 32) + num24 * num15;
		num23 += (num22 >> 32) + num24 * num18;
		num25 += (num23 >> 32) + num24 * num21;
		num26 += num25 >> 32;
		num11 = (uint)num19;
		JMNJPLAGDDJ[7] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num11 = (uint)num20;
		JMNJPLAGDDJ[8] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num11 = (uint)num22;
		JMNJPLAGDDJ[9] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num11 = (uint)num23;
		JMNJPLAGDDJ[10] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num11 = (uint)num25;
		JMNJPLAGDDJ[11] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num11 = (uint)num26;
		JMNJPLAGDDJ[12] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num11 = JMNJPLAGDDJ[13] + (uint)(int)(num26 >> 32);
		JMNJPLAGDDJ[13] = (num11 << 1) | num2;
	}

	public static void MIOEHGDPGAG(uint[] AMFCENFNAJJ, int ABBPDEOGNFE, uint[] JMNJPLAGDDJ, int IHCMHKCMELO)
	{
		ulong num = AMFCENFNAJJ[ABBPDEOGNFE];
		uint num2 = 0u;
		int num3 = 6;
		int num4 = 14;
		do
		{
			ulong num5 = AMFCENFNAJJ[ABBPDEOGNFE + num3--];
			ulong num6 = num5 * num5;
			JMNJPLAGDDJ[IHCMHKCMELO + --num4] = (num2 << 31) | (uint)(int)(num6 >> 33);
			JMNJPLAGDDJ[IHCMHKCMELO + --num4] = (uint)(num6 >> 1);
			num2 = (uint)num6;
		}
		while (num3 > 0);
		ulong num7 = num * num;
		ulong num8 = (num2 << 31) | (num7 >> 33);
		JMNJPLAGDDJ[IHCMHKCMELO] = (uint)num7;
		num2 = (uint)(int)(num7 >> 32) & 1u;
		ulong num9 = AMFCENFNAJJ[ABBPDEOGNFE + 1];
		ulong num10 = JMNJPLAGDDJ[IHCMHKCMELO + 2];
		num8 += num9 * num;
		uint num11 = (uint)num8;
		JMNJPLAGDDJ[IHCMHKCMELO + 1] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num10 += num8 >> 32;
		ulong num12 = AMFCENFNAJJ[ABBPDEOGNFE + 2];
		ulong num13 = JMNJPLAGDDJ[IHCMHKCMELO + 3];
		ulong num14 = JMNJPLAGDDJ[IHCMHKCMELO + 4];
		num10 += num12 * num;
		num11 = (uint)num10;
		JMNJPLAGDDJ[IHCMHKCMELO + 2] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num13 += (num10 >> 32) + num12 * num9;
		num14 += num13 >> 32;
		num13 &= 0xFFFFFFFFu;
		ulong num15 = AMFCENFNAJJ[ABBPDEOGNFE + 3];
		ulong num16 = JMNJPLAGDDJ[IHCMHKCMELO + 5];
		ulong num17 = JMNJPLAGDDJ[IHCMHKCMELO + 6];
		num13 += num15 * num;
		num11 = (uint)num13;
		JMNJPLAGDDJ[IHCMHKCMELO + 3] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num14 += (num13 >> 32) + num15 * num9;
		num16 += (num14 >> 32) + num15 * num12;
		num14 &= 0xFFFFFFFFu;
		num17 += num16 >> 32;
		num16 &= 0xFFFFFFFFu;
		ulong num18 = AMFCENFNAJJ[ABBPDEOGNFE + 4];
		ulong num19 = JMNJPLAGDDJ[IHCMHKCMELO + 7];
		ulong num20 = JMNJPLAGDDJ[IHCMHKCMELO + 8];
		num14 += num18 * num;
		num11 = (uint)num14;
		JMNJPLAGDDJ[IHCMHKCMELO + 4] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num16 += (num14 >> 32) + num18 * num9;
		num17 += (num16 >> 32) + num18 * num12;
		num16 &= 0xFFFFFFFFu;
		num19 += (num17 >> 32) + num18 * num15;
		num17 &= 0xFFFFFFFFu;
		num20 += num19 >> 32;
		num19 &= 0xFFFFFFFFu;
		ulong num21 = AMFCENFNAJJ[ABBPDEOGNFE + 5];
		ulong num22 = JMNJPLAGDDJ[IHCMHKCMELO + 9];
		ulong num23 = JMNJPLAGDDJ[IHCMHKCMELO + 10];
		num16 += num21 * num;
		num11 = (uint)num16;
		JMNJPLAGDDJ[IHCMHKCMELO + 5] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num17 += (num16 >> 32) + num21 * num9;
		num19 += (num17 >> 32) + num21 * num12;
		num17 &= 0xFFFFFFFFu;
		num20 += (num19 >> 32) + num21 * num15;
		num19 &= 0xFFFFFFFFu;
		num22 += (num20 >> 32) + num21 * num18;
		num20 &= 0xFFFFFFFFu;
		num23 += num22 >> 32;
		num22 &= 0xFFFFFFFFu;
		ulong num24 = AMFCENFNAJJ[ABBPDEOGNFE + 6];
		ulong num25 = JMNJPLAGDDJ[IHCMHKCMELO + 11];
		ulong num26 = JMNJPLAGDDJ[IHCMHKCMELO + 12];
		num17 += num24 * num;
		num11 = (uint)num17;
		JMNJPLAGDDJ[IHCMHKCMELO + 6] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num19 += (num17 >> 32) + num24 * num9;
		num20 += (num19 >> 32) + num24 * num12;
		num22 += (num20 >> 32) + num24 * num15;
		num23 += (num22 >> 32) + num24 * num18;
		num25 += (num23 >> 32) + num24 * num21;
		num26 += num25 >> 32;
		num11 = (uint)num19;
		JMNJPLAGDDJ[IHCMHKCMELO + 7] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num11 = (uint)num20;
		JMNJPLAGDDJ[IHCMHKCMELO + 8] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num11 = (uint)num22;
		JMNJPLAGDDJ[IHCMHKCMELO + 9] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num11 = (uint)num23;
		JMNJPLAGDDJ[IHCMHKCMELO + 10] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num11 = (uint)num25;
		JMNJPLAGDDJ[IHCMHKCMELO + 11] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num11 = (uint)num26;
		JMNJPLAGDDJ[IHCMHKCMELO + 12] = (num11 << 1) | num2;
		num2 = num11 >> 31;
		num11 = JMNJPLAGDDJ[IHCMHKCMELO + 13] + (uint)(int)(num26 >> 32);
		JMNJPLAGDDJ[IHCMHKCMELO + 13] = (num11 << 1) | num2;
	}

	public static int EAEONHFLEEN(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		long num = 0L;
		num += (long)AMFCENFNAJJ[0] - (long)CNLILOEEBOJ[0];
		IGNEOOOFEMO[0] = (uint)num;
		num >>= 32;
		num += (long)AMFCENFNAJJ[1] - (long)CNLILOEEBOJ[1];
		IGNEOOOFEMO[1] = (uint)num;
		num >>= 32;
		num += (long)AMFCENFNAJJ[2] - (long)CNLILOEEBOJ[2];
		IGNEOOOFEMO[2] = (uint)num;
		num >>= 32;
		num += (long)AMFCENFNAJJ[3] - (long)CNLILOEEBOJ[3];
		IGNEOOOFEMO[3] = (uint)num;
		num >>= 32;
		num += (long)AMFCENFNAJJ[4] - (long)CNLILOEEBOJ[4];
		IGNEOOOFEMO[4] = (uint)num;
		num >>= 32;
		num += (long)AMFCENFNAJJ[5] - (long)CNLILOEEBOJ[5];
		IGNEOOOFEMO[5] = (uint)num;
		num >>= 32;
		num += (long)AMFCENFNAJJ[6] - (long)CNLILOEEBOJ[6];
		IGNEOOOFEMO[6] = (uint)num;
		num >>= 32;
		return (int)num;
	}

	public static int EAEONHFLEEN(uint[] AMFCENFNAJJ, int ABBPDEOGNFE, uint[] CNLILOEEBOJ, int HGNFOMNFIDD, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		long num = 0L;
		num += (long)AMFCENFNAJJ[ABBPDEOGNFE] - (long)CNLILOEEBOJ[HGNFOMNFIDD];
		IGNEOOOFEMO[NDAAKFPMLOL] = (uint)num;
		num >>= 32;
		num += (long)AMFCENFNAJJ[ABBPDEOGNFE + 1] - (long)CNLILOEEBOJ[HGNFOMNFIDD + 1];
		IGNEOOOFEMO[NDAAKFPMLOL + 1] = (uint)num;
		num >>= 32;
		num += (long)AMFCENFNAJJ[ABBPDEOGNFE + 2] - (long)CNLILOEEBOJ[HGNFOMNFIDD + 2];
		IGNEOOOFEMO[NDAAKFPMLOL + 2] = (uint)num;
		num >>= 32;
		num += (long)AMFCENFNAJJ[ABBPDEOGNFE + 3] - (long)CNLILOEEBOJ[HGNFOMNFIDD + 3];
		IGNEOOOFEMO[NDAAKFPMLOL + 3] = (uint)num;
		num >>= 32;
		num += (long)AMFCENFNAJJ[ABBPDEOGNFE + 4] - (long)CNLILOEEBOJ[HGNFOMNFIDD + 4];
		IGNEOOOFEMO[NDAAKFPMLOL + 4] = (uint)num;
		num >>= 32;
		num += (long)AMFCENFNAJJ[ABBPDEOGNFE + 5] - (long)CNLILOEEBOJ[HGNFOMNFIDD + 5];
		IGNEOOOFEMO[NDAAKFPMLOL + 5] = (uint)num;
		num >>= 32;
		num += (long)AMFCENFNAJJ[ABBPDEOGNFE + 6] - (long)CNLILOEEBOJ[HGNFOMNFIDD + 6];
		IGNEOOOFEMO[NDAAKFPMLOL + 6] = (uint)num;
		num >>= 32;
		return (int)num;
	}

	public static int DCBNMOKOJHD(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		long num = 0L;
		num += (long)IGNEOOOFEMO[0] - (long)AMFCENFNAJJ[0] - CNLILOEEBOJ[0];
		IGNEOOOFEMO[0] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[1] - (long)AMFCENFNAJJ[1] - CNLILOEEBOJ[1];
		IGNEOOOFEMO[1] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[2] - (long)AMFCENFNAJJ[2] - CNLILOEEBOJ[2];
		IGNEOOOFEMO[2] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[3] - (long)AMFCENFNAJJ[3] - CNLILOEEBOJ[3];
		IGNEOOOFEMO[3] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[4] - (long)AMFCENFNAJJ[4] - CNLILOEEBOJ[4];
		IGNEOOOFEMO[4] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[5] - (long)AMFCENFNAJJ[5] - CNLILOEEBOJ[5];
		IGNEOOOFEMO[5] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[6] - (long)AMFCENFNAJJ[6] - CNLILOEEBOJ[6];
		IGNEOOOFEMO[6] = (uint)num;
		num >>= 32;
		return (int)num;
	}

	public static int DKAMAFLMHEJ(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		long num = 0L;
		num += (long)IGNEOOOFEMO[0] - (long)AMFCENFNAJJ[0];
		IGNEOOOFEMO[0] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[1] - (long)AMFCENFNAJJ[1];
		IGNEOOOFEMO[1] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[2] - (long)AMFCENFNAJJ[2];
		IGNEOOOFEMO[2] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[3] - (long)AMFCENFNAJJ[3];
		IGNEOOOFEMO[3] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[4] - (long)AMFCENFNAJJ[4];
		IGNEOOOFEMO[4] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[5] - (long)AMFCENFNAJJ[5];
		IGNEOOOFEMO[5] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[6] - (long)AMFCENFNAJJ[6];
		IGNEOOOFEMO[6] = (uint)num;
		num >>= 32;
		return (int)num;
	}

	public static int DKAMAFLMHEJ(uint[] AMFCENFNAJJ, int ABBPDEOGNFE, uint[] IGNEOOOFEMO, int NDAAKFPMLOL)
	{
		long num = 0L;
		num += (long)IGNEOOOFEMO[NDAAKFPMLOL] - (long)AMFCENFNAJJ[ABBPDEOGNFE];
		IGNEOOOFEMO[NDAAKFPMLOL] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[NDAAKFPMLOL + 1] - (long)AMFCENFNAJJ[ABBPDEOGNFE + 1];
		IGNEOOOFEMO[NDAAKFPMLOL + 1] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[NDAAKFPMLOL + 2] - (long)AMFCENFNAJJ[ABBPDEOGNFE + 2];
		IGNEOOOFEMO[NDAAKFPMLOL + 2] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[NDAAKFPMLOL + 3] - (long)AMFCENFNAJJ[ABBPDEOGNFE + 3];
		IGNEOOOFEMO[NDAAKFPMLOL + 3] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[NDAAKFPMLOL + 4] - (long)AMFCENFNAJJ[ABBPDEOGNFE + 4];
		IGNEOOOFEMO[NDAAKFPMLOL + 4] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[NDAAKFPMLOL + 5] - (long)AMFCENFNAJJ[ABBPDEOGNFE + 5];
		IGNEOOOFEMO[NDAAKFPMLOL + 5] = (uint)num;
		num >>= 32;
		num += (long)IGNEOOOFEMO[NDAAKFPMLOL + 6] - (long)AMFCENFNAJJ[ABBPDEOGNFE + 6];
		IGNEOOOFEMO[NDAAKFPMLOL + 6] = (uint)num;
		num >>= 32;
		return (int)num;
	}

	public static BigInteger DOJBPIFPALJ(uint[] AMFCENFNAJJ)
	{
		byte[] array = new byte[28];
		for (int i = 0; i < 7; i++)
		{
			uint num = AMFCENFNAJJ[i];
			if (num != 0)
			{
				PGOKFBKEOAB.MPMAFPANDLC(num, array, 6 - i << 2);
			}
		}
		return new BigInteger(1, array);
	}

	public static void KEOKCFDNHPP(uint[] IGNEOOOFEMO)
	{
		IGNEOOOFEMO[0] = 0u;
		IGNEOOOFEMO[1] = 0u;
		IGNEOOOFEMO[2] = 0u;
		IGNEOOOFEMO[3] = 0u;
		IGNEOOOFEMO[4] = 0u;
		IGNEOOOFEMO[5] = 0u;
		IGNEOOOFEMO[6] = 0u;
	}
}
