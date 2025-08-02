using System;
using Org.BouncyCastle.Math;

public abstract class ODBELJAHGIG
{
	private const int JOFDOICDMOA = 1000;

	public static byte[] HOGKINKACAF(BigInteger IDHLPOFDLKJ)
	{
		return IDHLPOFDLKJ.MEOCDOOKOLH();
	}

	public static byte[] HOGKINKACAF(int EOFAGACBNFP, BigInteger IDHLPOFDLKJ)
	{
		byte[] array = IDHLPOFDLKJ.MEOCDOOKOLH();
		if (array.Length > EOFAGACBNFP)
		{
			throw new ArgumentException("standard length exceeded", "n");
		}
		if (array.Length == EOFAGACBNFP)
		{
			return array;
		}
		byte[] array2 = new byte[EOFAGACBNFP];
		Array.Copy(array, 0, array2, array2.Length - array.Length, array.Length);
		return array2;
	}

	public static BigInteger LJJCFCFGOCK(BigInteger IJHGDODBFCD, BigInteger NHLJFKPLKLI, FBIJJFGLKMK GECCLOFELEC)
	{
		int num = IJHGDODBFCD.JLPDKNFCNPO(NHLJFKPLKLI);
		if (num >= 0)
		{
			if (num > 0)
			{
				throw new ArgumentException("'min' may not be greater than 'max'");
			}
			return IJHGDODBFCD;
		}
		if (IJHGDODBFCD.BitLength > NHLJFKPLKLI.BitLength / 2)
		{
			return LJJCFCFGOCK(BigInteger.Zero, NHLJFKPLKLI.FBGIHKPECCO(IJHGDODBFCD), GECCLOFELEC).JEACJNAKLDJ(IJHGDODBFCD);
		}
		for (int i = 0; i < 1000; i++)
		{
			BigInteger bigInteger = new BigInteger(NHLJFKPLKLI.BitLength, GECCLOFELEC);
			if (bigInteger.JLPDKNFCNPO(IJHGDODBFCD) >= 0 && bigInteger.JLPDKNFCNPO(NHLJFKPLKLI) <= 0)
			{
				return bigInteger;
			}
		}
		return new BigInteger(NHLJFKPLKLI.FBGIHKPECCO(IJHGDODBFCD).BitLength - 1, GECCLOFELEC).JEACJNAKLDJ(IJHGDODBFCD);
	}
}
