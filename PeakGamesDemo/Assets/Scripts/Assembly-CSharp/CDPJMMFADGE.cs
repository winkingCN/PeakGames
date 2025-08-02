using System;
using Org.BouncyCastle.Math;

public class CDPJMMFADGE : AJJFGJKHKGH
{
	private readonly BigInteger AMFCENFNAJJ;

	public BigInteger CBPFFIBINEH
	{
		get
		{
			return AMFCENFNAJJ;
		}
	}

	public CDPJMMFADGE(BigInteger AMFCENFNAJJ, ALFDDLOKJAC IJJHBEECMBP)
		: base(true, IJJHBEECMBP)
	{
		if (AMFCENFNAJJ.SignValue < 1 || AMFCENFNAJJ.BitLength > 256 || AMFCENFNAJJ.JLPDKNFCNPO(base.KPJHHAAOFOH.FNPELDEHJKL) >= 0)
		{
			throw new ArgumentException("Invalid x for GOST3410 private key", "x");
		}
		this.AMFCENFNAJJ = AMFCENFNAJJ;
	}

	public CDPJMMFADGE(BigInteger AMFCENFNAJJ, KLKJHFKJLEM DHNJFHPNJLM)
		: base(true, DHNJFHPNJLM)
	{
		if (AMFCENFNAJJ.SignValue < 1 || AMFCENFNAJJ.BitLength > 256 || AMFCENFNAJJ.JLPDKNFCNPO(base.KPJHHAAOFOH.FNPELDEHJKL) >= 0)
		{
			throw new ArgumentException("Invalid x for GOST3410 private key", "x");
		}
		this.AMFCENFNAJJ = AMFCENFNAJJ;
	}
}
