using System;
using Org.BouncyCastle.Math;

public abstract class FGALCADFLCL
{
	internal static readonly AGBPCEHDLOH PPBIJJDABBA = new NPKAGNBLHGA(BigInteger.AGLOJCOAJIK(2L));

	internal static readonly AGBPCEHDLOH DABFBNFLMOB = new NPKAGNBLHGA(BigInteger.AGLOJCOAJIK(3L));

	public static AIGKJBLDPNN AKPPBGAEPAL(int[] GJPIIMLNKMN)
	{
		if (GJPIIMLNKMN[0] != 0)
		{
			throw new ArgumentException("Irreducible polynomials in GF(2) must have constant term", "exponents");
		}
		for (int i = 1; i < GJPIIMLNKMN.Length; i++)
		{
			if (GJPIIMLNKMN[i] <= GJPIIMLNKMN[i - 1])
			{
				throw new ArgumentException("Polynomial exponents must be montonically increasing", "exponents");
			}
		}
		return new HHCJGDDKPBH(PPBIJJDABBA, new AMCHOOAADCL(GJPIIMLNKMN));
	}

	public static AGBPCEHDLOH BMFGIJEIHEK(BigInteger AIHIGPPIFGH)
	{
		int bitLength = AIHIGPPIFGH.BitLength;
		if (AIHIGPPIFGH.SignValue <= 0 || bitLength < 2)
		{
			throw new ArgumentException("Must be >= 2", "characteristic");
		}
		if (bitLength < 3)
		{
			switch (AIHIGPPIFGH.IntValue)
			{
			case 2:
				return PPBIJJDABBA;
			case 3:
				return DABFBNFLMOB;
			}
		}
		return new NPKAGNBLHGA(AIHIGPPIFGH);
	}
}
