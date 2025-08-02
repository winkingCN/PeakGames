using System;
using Org.BouncyCastle.Math;

public class GBBNCENGABI : IBAHDCNIFPI
{
	private readonly BigInteger CNLILOEEBOJ;

	public BigInteger MOAGLBJDKKL
	{
		get
		{
			return CNLILOEEBOJ;
		}
	}

	public GBBNCENGABI(BigInteger CNLILOEEBOJ, CLBPDHGBHML IJJHBEECMBP)
		: base(false, IJJHBEECMBP)
	{
		if (CNLILOEEBOJ == null)
		{
			throw new ArgumentNullException("y");
		}
		this.CNLILOEEBOJ = CNLILOEEBOJ;
	}

	public GBBNCENGABI(BigInteger CNLILOEEBOJ, CLBPDHGBHML IJJHBEECMBP, KLKJHFKJLEM KEJOEEMPKLM)
		: base(false, IJJHBEECMBP, KEJOEEMPKLM)
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
		GBBNCENGABI gBBNCENGABI = NEMEKIOEOLC as GBBNCENGABI;
		if (gBBNCENGABI == null)
		{
			return false;
		}
		return KIFDKLPDKMD(gBBNCENGABI);
	}

	protected bool KIFDKLPDKMD(GBBNCENGABI CJHEIBNHNNE)
	{
		return CNLILOEEBOJ.Equals(CJHEIBNHNNE.CNLILOEEBOJ) && KIFDKLPDKMD((IBAHDCNIFPI)CJHEIBNHNNE);
	}

	public override int GetHashCode()
	{
		return CNLILOEEBOJ.GetHashCode() ^ base.GetHashCode();
	}
}
