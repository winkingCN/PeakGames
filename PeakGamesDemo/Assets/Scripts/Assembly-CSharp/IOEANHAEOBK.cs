using System;
using Org.BouncyCastle.Math;

public class IOEANHAEOBK : PDOHMDOJDFK
{
	private readonly BigInteger CNLILOEEBOJ;

	public BigInteger MOAGLBJDKKL
	{
		get
		{
			return CNLILOEEBOJ;
		}
	}

	public IOEANHAEOBK(BigInteger CNLILOEEBOJ, CFBBJKGJFPE IJJHBEECMBP)
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
		IOEANHAEOBK iOEANHAEOBK = NEMEKIOEOLC as IOEANHAEOBK;
		if (iOEANHAEOBK == null)
		{
			return false;
		}
		return KIFDKLPDKMD(iOEANHAEOBK);
	}

	protected bool KIFDKLPDKMD(IOEANHAEOBK CJHEIBNHNNE)
	{
		return CNLILOEEBOJ.Equals(CJHEIBNHNNE.CNLILOEEBOJ) && KIFDKLPDKMD((PDOHMDOJDFK)CJHEIBNHNNE);
	}

	public override int GetHashCode()
	{
		return CNLILOEEBOJ.GetHashCode() ^ base.GetHashCode();
	}
}
