using System;
using Org.BouncyCastle.Math;

internal abstract class KAPHDADJNME
{
	public static void MDFKEHIKPBA(ulong[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		IGNEOOOFEMO[0] = AMFCENFNAJJ[0];
		IGNEOOOFEMO[1] = AMFCENFNAJJ[1];
		IGNEOOOFEMO[2] = AMFCENFNAJJ[2];
		IGNEOOOFEMO[3] = AMFCENFNAJJ[3];
		IGNEOOOFEMO[4] = AMFCENFNAJJ[4];
		IGNEOOOFEMO[5] = AMFCENFNAJJ[5];
		IGNEOOOFEMO[6] = AMFCENFNAJJ[6];
	}

	public static ulong[] JLMPJDKAODG()
	{
		return new ulong[7];
	}

	public static ulong[] JFMBFIGDFCE()
	{
		return new ulong[14];
	}

	public static bool BIMHNKJNNFO(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ)
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

	public static ulong[] NCFBIELMPAA(BigInteger AMFCENFNAJJ)
	{
		if (AMFCENFNAJJ.SignValue < 0 || AMFCENFNAJJ.BitLength > 448)
		{
			throw new ArgumentException();
		}
		ulong[] array = JLMPJDKAODG();
		int num = 0;
		while (AMFCENFNAJJ.SignValue != 0)
		{
			array[num++] = (ulong)AMFCENFNAJJ.LongValue;
			AMFCENFNAJJ = AMFCENFNAJJ.ABOIOKBIANB(64);
		}
		return array;
	}

	public static bool OAHHAKMHOKG(ulong[] AMFCENFNAJJ)
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

	public static bool NKNOMEDBEDI(ulong[] AMFCENFNAJJ)
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

	public static BigInteger CLJANJOEBFJ(ulong[] AMFCENFNAJJ)
	{
		byte[] array = new byte[56];
		for (int i = 0; i < 7; i++)
		{
			ulong num = AMFCENFNAJJ[i];
			if (num != 0)
			{
				PGOKFBKEOAB.LHKOONEHKNH(num, array, 6 - i << 3);
			}
		}
		return new BigInteger(1, array);
	}
}
