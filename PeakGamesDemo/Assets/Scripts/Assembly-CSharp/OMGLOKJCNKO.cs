using System;
using Org.BouncyCastle.Math;

public class OMGLOKJCNKO : EBLJDAKGPFF
{
	private readonly BigInteger AMFCENFNAJJ;

	public BigInteger CBPFFIBINEH
	{
		get
		{
			return AMFCENFNAJJ;
		}
	}

	public OMGLOKJCNKO(BigInteger AMFCENFNAJJ, JEHNKJOKBGF IJJHBEECMBP)
		: base(true, IJJHBEECMBP)
	{
		if (AMFCENFNAJJ == null)
		{
			throw new ArgumentNullException("x");
		}
		this.AMFCENFNAJJ = AMFCENFNAJJ;
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == this)
		{
			return true;
		}
		OMGLOKJCNKO oMGLOKJCNKO = NEMEKIOEOLC as OMGLOKJCNKO;
		if (oMGLOKJCNKO == null)
		{
			return false;
		}
		return KIFDKLPDKMD(oMGLOKJCNKO);
	}

	protected bool KIFDKLPDKMD(OMGLOKJCNKO CJHEIBNHNNE)
	{
		return AMFCENFNAJJ.Equals(CJHEIBNHNNE.AMFCENFNAJJ) && KIFDKLPDKMD((EBLJDAKGPFF)CJHEIBNHNNE);
	}

	public override int GetHashCode()
	{
		return AMFCENFNAJJ.GetHashCode() ^ base.GetHashCode();
	}
}
