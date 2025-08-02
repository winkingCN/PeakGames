using System;
using Org.BouncyCastle.Math;

public class NFJLHCNCCHB : EBLJDAKGPFF
{
	private readonly BigInteger CNLILOEEBOJ;

	public BigInteger MOAGLBJDKKL
	{
		get
		{
			return CNLILOEEBOJ;
		}
	}

	public NFJLHCNCCHB(BigInteger CNLILOEEBOJ, JEHNKJOKBGF IJJHBEECMBP)
		: base(false, IJJHBEECMBP)
	{
		if (CNLILOEEBOJ == null)
		{
			throw new ArgumentNullException("y");
		}
		this.CNLILOEEBOJ = CNLILOEEBOJ;
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == this)
		{
			return true;
		}
		NFJLHCNCCHB nFJLHCNCCHB = NEMEKIOEOLC as NFJLHCNCCHB;
		if (nFJLHCNCCHB == null)
		{
			return false;
		}
		return KIFDKLPDKMD(nFJLHCNCCHB);
	}

	protected bool KIFDKLPDKMD(NFJLHCNCCHB CJHEIBNHNNE)
	{
		return CNLILOEEBOJ.Equals(CJHEIBNHNNE.CNLILOEEBOJ) && KIFDKLPDKMD((EBLJDAKGPFF)CJHEIBNHNNE);
	}

	public override int GetHashCode()
	{
		return CNLILOEEBOJ.GetHashCode() ^ base.GetHashCode();
	}
}
