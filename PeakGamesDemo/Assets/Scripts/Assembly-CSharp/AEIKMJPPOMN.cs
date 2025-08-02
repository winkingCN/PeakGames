using Org.BouncyCastle.Math;

public class AEIKMJPPOMN : IBAHDCNIFPI
{
	private readonly BigInteger AMFCENFNAJJ;

	public BigInteger CBPFFIBINEH
	{
		get
		{
			return AMFCENFNAJJ;
		}
	}

	public AEIKMJPPOMN(BigInteger AMFCENFNAJJ, CLBPDHGBHML IJJHBEECMBP)
		: base(true, IJJHBEECMBP)
	{
		this.AMFCENFNAJJ = AMFCENFNAJJ;
	}

	public AEIKMJPPOMN(BigInteger AMFCENFNAJJ, CLBPDHGBHML IJJHBEECMBP, KLKJHFKJLEM KEJOEEMPKLM)
		: base(true, IJJHBEECMBP, KEJOEEMPKLM)
	{
		this.AMFCENFNAJJ = AMFCENFNAJJ;
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == this)
		{
			return true;
		}
		AEIKMJPPOMN aEIKMJPPOMN = NEMEKIOEOLC as AEIKMJPPOMN;
		if (aEIKMJPPOMN == null)
		{
			return false;
		}
		return KIFDKLPDKMD(aEIKMJPPOMN);
	}

	protected bool KIFDKLPDKMD(AEIKMJPPOMN CJHEIBNHNNE)
	{
		return AMFCENFNAJJ.Equals(CJHEIBNHNNE.AMFCENFNAJJ) && KIFDKLPDKMD((IBAHDCNIFPI)CJHEIBNHNNE);
	}

	public override int GetHashCode()
	{
		return AMFCENFNAJJ.GetHashCode() ^ base.GetHashCode();
	}
}
