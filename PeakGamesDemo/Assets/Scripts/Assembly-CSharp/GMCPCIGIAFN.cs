using Org.BouncyCastle.Math;

internal class GMCPCIGIAFN
{
	private static readonly BigInteger GKFELMANPEH = BigInteger.AGLOJCOAJIK(6L);

	private static readonly int[][] FCMLMBFIPGE = BigInteger.primeLists;

	private static readonly int[] CDNNCPDGMAF = BigInteger.primeProducts;

	private static readonly BigInteger[] NOKGBOHBOEO = LKAAEEEBJFO(CDNNCPDGMAF);

	private static BigInteger[] LKAAEEEBJFO(int[] CDNNCPDGMAF)
	{
		BigInteger[] array = new BigInteger[CDNNCPDGMAF.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = BigInteger.AGLOJCOAJIK(CDNNCPDGMAF[i]);
		}
		return array;
	}

	internal static BigInteger[] NLAHLCJFJAF(int MOFHAKELNPN, int CFGADBIOJFG, FBIJJFGLKMK GECCLOFELEC)
	{
		int num = MOFHAKELNPN - 1;
		int num2 = MOFHAKELNPN >> 2;
		BigInteger bigInteger;
		BigInteger bigInteger2;
		if (MOFHAKELNPN <= 32)
		{
			do
			{
				bigInteger = new BigInteger(num, 2, GECCLOFELEC);
				bigInteger2 = bigInteger.DOKHFLENGLF(1).JEACJNAKLDJ(BigInteger.One);
			}
			while (!bigInteger2.LKECIHLDEIP(CFGADBIOJFG, true) || (CFGADBIOJFG > 2 && !bigInteger.LKECIHLDEIP(CFGADBIOJFG, true)));
		}
		else
		{
			while (true)
			{
				bigInteger = new BigInteger(num, 0, GECCLOFELEC);
				while (true)
				{
					for (int i = 0; i < FCMLMBFIPGE.Length; i++)
					{
						int num3 = bigInteger.FGLDMFGEDAD(NOKGBOHBOEO[i]).IntValue;
						if (i == 0)
						{
							int num4 = num3 % 3;
							if (num4 != 2)
							{
								int num5 = 2 * num4 + 2;
								bigInteger = bigInteger.JEACJNAKLDJ(BigInteger.AGLOJCOAJIK(num5));
								num3 = (num3 + num5) % CDNNCPDGMAF[i];
							}
						}
						int[] array = FCMLMBFIPGE[i];
						foreach (int num6 in array)
						{
							int num7 = num3 % num6;
							if (num7 == 0 || num7 == num6 >> 1)
							{
								goto IL_0103;
							}
						}
					}
					break;
					IL_0103:
					bigInteger = bigInteger.JEACJNAKLDJ(GKFELMANPEH);
				}
				if (bigInteger.BitLength == num && bigInteger.GPDICEJKJAN(2, GECCLOFELEC, true))
				{
					bigInteger2 = bigInteger.DOKHFLENGLF(1).JEACJNAKLDJ(BigInteger.One);
					if (bigInteger2.GPDICEJKJAN(CFGADBIOJFG, GECCLOFELEC, true) && (CFGADBIOJFG <= 2 || bigInteger.GPDICEJKJAN(CFGADBIOJFG - 2, GECCLOFELEC, true)) && ABHJGAELGKM.BKBGONMOPKI(bigInteger2) >= num2)
					{
						break;
					}
				}
			}
		}
		return new BigInteger[2] { bigInteger2, bigInteger };
	}

	internal static BigInteger JHAOPAIMHJM(BigInteger HPHBDNBJPHB, BigInteger OKDPJHOEPBJ, FBIJJFGLKMK GECCLOFELEC)
	{
		BigInteger nHLJFKPLKLI = HPHBDNBJPHB.FBGIHKPECCO(BigInteger.Two);
		BigInteger bigInteger2;
		do
		{
			BigInteger bigInteger = ODBELJAHGIG.LJJCFCFGOCK(BigInteger.Two, nHLJFKPLKLI, GECCLOFELEC);
			bigInteger2 = bigInteger.ICEOCBALAGC(BigInteger.Two, HPHBDNBJPHB);
		}
		while (bigInteger2.Equals(BigInteger.One));
		return bigInteger2;
	}
}
