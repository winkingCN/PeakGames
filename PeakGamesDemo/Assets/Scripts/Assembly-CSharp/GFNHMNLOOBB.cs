using Org.BouncyCastle.Math;

internal class GFNHMNLOOBB
{
	internal static readonly GFNHMNLOOBB GABGKBAKHDP = new GFNHMNLOOBB();

	private GFNHMNLOOBB()
	{
	}

	internal BigInteger ILJLFKLPKKM(CLBPDHGBHML IFEEEDFDKMB, FBIJJFGLKMK GECCLOFELEC)
	{
		int num = IFEEEDFDKMB.NBFDOJDLKOG;
		if (num != 0)
		{
			int num2 = num >> 2;
			BigInteger bigInteger;
			do
			{
				bigInteger = new BigInteger(num, GECCLOFELEC).KMDGKCFFPOP(num - 1);
			}
			while (ABHJGAELGKM.BKBGONMOPKI(bigInteger) < num2);
			return bigInteger;
		}
		BigInteger iJHGDODBFCD = BigInteger.Two;
		int num3 = IFEEEDFDKMB.IGBPKOOBCMA;
		if (num3 != 0)
		{
			iJHGDODBFCD = BigInteger.One.DOKHFLENGLF(num3 - 1);
		}
		BigInteger bigInteger2 = IFEEEDFDKMB.FNPELDEHJKL;
		if (bigInteger2 == null)
		{
			bigInteger2 = IFEEEDFDKMB.MBIJHANOCOC;
		}
		BigInteger bigInteger3 = bigInteger2.FBGIHKPECCO(BigInteger.Two);
		int num4 = bigInteger3.BitLength >> 2;
		BigInteger bigInteger4;
		do
		{
			bigInteger4 = ODBELJAHGIG.LJJCFCFGOCK(iJHGDODBFCD, bigInteger3, GECCLOFELEC);
		}
		while (ABHJGAELGKM.BKBGONMOPKI(bigInteger4) < num4);
		return bigInteger4;
	}

	internal BigInteger LEGMJIGOKFE(CLBPDHGBHML IFEEEDFDKMB, BigInteger AMFCENFNAJJ)
	{
		return IFEEEDFDKMB.HBGOKILMBJG.ICEOCBALAGC(AMFCENFNAJJ, IFEEEDFDKMB.MBIJHANOCOC);
	}
}
