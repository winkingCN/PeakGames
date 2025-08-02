using System;
using Org.BouncyCastle.Math;

public class EBIECGDGAPI : AJJFGJKHKGH
{
	private readonly BigInteger CNLILOEEBOJ;

	public BigInteger MOAGLBJDKKL
	{
		get
		{
			return CNLILOEEBOJ;
		}
	}

	public EBIECGDGAPI(BigInteger CNLILOEEBOJ, ALFDDLOKJAC IJJHBEECMBP)
		: base(false, IJJHBEECMBP)
	{
		if (CNLILOEEBOJ.SignValue < 1 || CNLILOEEBOJ.JLPDKNFCNPO(base.KPJHHAAOFOH.MBIJHANOCOC) >= 0)
		{
			throw new ArgumentException("Invalid y for GOST3410 public key", "y");
		}
		this.CNLILOEEBOJ = CNLILOEEBOJ;
	}

	public EBIECGDGAPI(BigInteger CNLILOEEBOJ, KLKJHFKJLEM DHNJFHPNJLM)
		: base(false, DHNJFHPNJLM)
	{
		if (CNLILOEEBOJ.SignValue < 1 || CNLILOEEBOJ.JLPDKNFCNPO(base.KPJHHAAOFOH.MBIJHANOCOC) >= 0)
		{
			throw new ArgumentException("Invalid y for GOST3410 public key", "y");
		}
		this.CNLILOEEBOJ = CNLILOEEBOJ;
	}
}
