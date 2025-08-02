using System;
using Org.BouncyCastle.Math;

public class IDCNEBAGENN : PDOHMDOJDFK
{
	private readonly BigInteger AMFCENFNAJJ;

	public BigInteger CBPFFIBINEH
	{
		get
		{
			return AMFCENFNAJJ;
		}
	}

	public IDCNEBAGENN(BigInteger AMFCENFNAJJ, CFBBJKGJFPE IJJHBEECMBP)
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
		IDCNEBAGENN iDCNEBAGENN = NEMEKIOEOLC as IDCNEBAGENN;
		if (iDCNEBAGENN == null)
		{
			return false;
		}
		return KIFDKLPDKMD(iDCNEBAGENN);
	}

	protected bool KIFDKLPDKMD(IDCNEBAGENN CJHEIBNHNNE)
	{
		return CJHEIBNHNNE.AMFCENFNAJJ.Equals(AMFCENFNAJJ) && KIFDKLPDKMD((PDOHMDOJDFK)CJHEIBNHNNE);
	}

	public override int GetHashCode()
	{
		return AMFCENFNAJJ.GetHashCode() ^ base.GetHashCode();
	}
}
