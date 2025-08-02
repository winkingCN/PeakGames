using System;
using Org.BouncyCastle.Math;

public class PLGGNEJEIIP : COEMJAGOFJJ
{
	private readonly BigInteger ACOFJAHAMHM;

	private readonly BigInteger OAAKLECLNAK;

	public BigInteger FILOMPHGFKD
	{
		get
		{
			return ACOFJAHAMHM;
		}
	}

	public BigInteger MFIHJHFAEFB
	{
		get
		{
			return OAAKLECLNAK;
		}
	}

	public PLGGNEJEIIP(bool OFKEGLBCAJF, BigInteger ACOFJAHAMHM, BigInteger OAAKLECLNAK)
		: base(OFKEGLBCAJF)
	{
		if (ACOFJAHAMHM == null)
		{
			throw new ArgumentNullException("modulus");
		}
		if (OAAKLECLNAK == null)
		{
			throw new ArgumentNullException("exponent");
		}
		if (ACOFJAHAMHM.SignValue <= 0)
		{
			throw new ArgumentException("Not a valid RSA modulus", "modulus");
		}
		if (OAAKLECLNAK.SignValue <= 0)
		{
			throw new ArgumentException("Not a valid RSA exponent", "exponent");
		}
		this.ACOFJAHAMHM = ACOFJAHAMHM;
		this.OAAKLECLNAK = OAAKLECLNAK;
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		PLGGNEJEIIP pLGGNEJEIIP = NEMEKIOEOLC as PLGGNEJEIIP;
		if (pLGGNEJEIIP == null)
		{
			return false;
		}
		return pLGGNEJEIIP.CCLHEKOIIKM == base.CCLHEKOIIKM && pLGGNEJEIIP.FILOMPHGFKD.Equals(ACOFJAHAMHM) && pLGGNEJEIIP.MFIHJHFAEFB.Equals(OAAKLECLNAK);
	}

	public override int GetHashCode()
	{
		return ACOFJAHAMHM.GetHashCode() ^ OAAKLECLNAK.GetHashCode() ^ base.CCLHEKOIIKM.GetHashCode();
	}
}
