using System;
using Org.BouncyCastle.Math;

public class EKGPBAENHIF : BKFMFPGHIJB
{
	private readonly BigInteger ELNCCDELMMH;

	public BigInteger INCIODEICNM
	{
		get
		{
			return ELNCCDELMMH;
		}
	}

	public EKGPBAENHIF(BigInteger ELNCCDELMMH, MJDENGGDLMJ IJJHBEECMBP)
		: this("EC", ELNCCDELMMH, IJJHBEECMBP)
	{
	}

	[Obsolete("Use version with explicit 'algorithm' parameter")]
	public EKGPBAENHIF(BigInteger ELNCCDELMMH, KLKJHFKJLEM DHNJFHPNJLM)
		: base("ECGOST3410", true, DHNJFHPNJLM)
	{
		if (ELNCCDELMMH == null)
		{
			throw new ArgumentNullException("d");
		}
		this.ELNCCDELMMH = ELNCCDELMMH;
	}

	public EKGPBAENHIF(string ADLMOHOLCGL, BigInteger ELNCCDELMMH, MJDENGGDLMJ IJJHBEECMBP)
		: base(ADLMOHOLCGL, true, IJJHBEECMBP)
	{
		if (ELNCCDELMMH == null)
		{
			throw new ArgumentNullException("d");
		}
		this.ELNCCDELMMH = ELNCCDELMMH;
	}

	public EKGPBAENHIF(string ADLMOHOLCGL, BigInteger ELNCCDELMMH, KLKJHFKJLEM DHNJFHPNJLM)
		: base(ADLMOHOLCGL, true, DHNJFHPNJLM)
	{
		if (ELNCCDELMMH == null)
		{
			throw new ArgumentNullException("d");
		}
		this.ELNCCDELMMH = ELNCCDELMMH;
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == this)
		{
			return true;
		}
		EKGPBAENHIF eKGPBAENHIF = NEMEKIOEOLC as EKGPBAENHIF;
		if (eKGPBAENHIF == null)
		{
			return false;
		}
		return KIFDKLPDKMD(eKGPBAENHIF);
	}

	protected bool KIFDKLPDKMD(EKGPBAENHIF CJHEIBNHNNE)
	{
		return ELNCCDELMMH.Equals(CJHEIBNHNNE.ELNCCDELMMH) && KIFDKLPDKMD((BKFMFPGHIJB)CJHEIBNHNNE);
	}

	public override int GetHashCode()
	{
		return ELNCCDELMMH.GetHashCode() ^ base.GetHashCode();
	}
}
