using System;
using Org.BouncyCastle.Math;

public class FFFLPDDFAAK : LNKPCJLANAO
{
	private BigInteger ACOFJAHAMHM;

	private BigInteger PHAKMCGHMBA;

	public BigInteger FILOMPHGFKD
	{
		get
		{
			return ACOFJAHAMHM;
		}
	}

	public BigInteger IHOPDFAGDAF
	{
		get
		{
			return PHAKMCGHMBA;
		}
	}

	public FFFLPDDFAAK(BigInteger ACOFJAHAMHM, BigInteger PHAKMCGHMBA)
	{
		if (ACOFJAHAMHM == null)
		{
			throw new ArgumentNullException("modulus");
		}
		if (PHAKMCGHMBA == null)
		{
			throw new ArgumentNullException("publicExponent");
		}
		if (ACOFJAHAMHM.SignValue <= 0)
		{
			throw new ArgumentException("Not a valid RSA modulus", "modulus");
		}
		if (PHAKMCGHMBA.SignValue <= 0)
		{
			throw new ArgumentException("Not a valid RSA public exponent", "publicExponent");
		}
		this.ACOFJAHAMHM = ACOFJAHAMHM;
		this.PHAKMCGHMBA = PHAKMCGHMBA;
	}

	private FFFLPDDFAAK(ALLINHNNNJN MIABODPHOIP)
	{
		if (MIABODPHOIP.GMCGMPEEHJP != 2)
		{
			throw new ArgumentException("Bad sequence size: " + MIABODPHOIP.GMCGMPEEHJP);
		}
		ACOFJAHAMHM = GLFDIPNOLKN.BJLJCGFMFOO(MIABODPHOIP.ECNCPJGHBIG(0)).DMPHAJNKNKB;
		PHAKMCGHMBA = GLFDIPNOLKN.BJLJCGFMFOO(MIABODPHOIP.ECNCPJGHBIG(1)).DMPHAJNKNKB;
	}

	public static FFFLPDDFAAK BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DHGLJHFEJFL)
	{
		return BJLJCGFMFOO(ALLINHNNNJN.BJLJCGFMFOO(NEMEKIOEOLC, DHGLJHFEJFL));
	}

	public static FFFLPDDFAAK BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is FFFLPDDFAAK)
		{
			return (FFFLPDDFAAK)NEMEKIOEOLC;
		}
		if (NEMEKIOEOLC is ALLINHNNNJN)
		{
			return new FFFLPDDFAAK((ALLINHNNNJN)NEMEKIOEOLC);
		}
		throw new ArgumentException("Invalid RsaPublicKeyStructure: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC));
	}

	public override EDOEBJJFOBM IIHKEACDNID()
	{
		return new KOGPLMALOEH(new GLFDIPNOLKN(FILOMPHGFKD), new GLFDIPNOLKN(IHOPDFAGDAF));
	}
}
