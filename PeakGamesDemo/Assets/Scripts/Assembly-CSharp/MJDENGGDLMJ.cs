using System;
using Org.BouncyCastle.Math;

public class MJDENGGDLMJ
{
	internal BHPIABAGAPB NINILENHPHE;

	internal byte[] HJBOEOOLOOE;

	internal JGAFKLGGBGF HJMBDGKAOBP;

	internal BigInteger IDHLPOFDLKJ;

	internal BigInteger GPJDJCGDJDC;

	public BHPIABAGAPB ECFGFKNLLGH
	{
		get
		{
			return NINILENHPHE;
		}
	}

	public JGAFKLGGBGF HBGOKILMBJG
	{
		get
		{
			return HJMBDGKAOBP;
		}
	}

	public BigInteger HNLMGJGNBDD
	{
		get
		{
			return IDHLPOFDLKJ;
		}
	}

	public BigInteger JGOHMOHEFMJ
	{
		get
		{
			return GPJDJCGDJDC;
		}
	}

	public MJDENGGDLMJ(BHPIABAGAPB NINILENHPHE, JGAFKLGGBGF HJMBDGKAOBP, BigInteger IDHLPOFDLKJ)
		: this(NINILENHPHE, HJMBDGKAOBP, IDHLPOFDLKJ, BigInteger.One)
	{
	}

	public MJDENGGDLMJ(BHPIABAGAPB NINILENHPHE, JGAFKLGGBGF HJMBDGKAOBP, BigInteger IDHLPOFDLKJ, BigInteger GPJDJCGDJDC)
		: this(NINILENHPHE, HJMBDGKAOBP, IDHLPOFDLKJ, GPJDJCGDJDC, null)
	{
	}

	public MJDENGGDLMJ(BHPIABAGAPB NINILENHPHE, JGAFKLGGBGF HJMBDGKAOBP, BigInteger IDHLPOFDLKJ, BigInteger GPJDJCGDJDC, byte[] HJBOEOOLOOE)
	{
		if (NINILENHPHE == null)
		{
			throw new ArgumentNullException("curve");
		}
		if (HJMBDGKAOBP == null)
		{
			throw new ArgumentNullException("g");
		}
		if (IDHLPOFDLKJ == null)
		{
			throw new ArgumentNullException("n");
		}
		if (GPJDJCGDJDC == null)
		{
			throw new ArgumentNullException("h");
		}
		this.NINILENHPHE = NINILENHPHE;
		this.HJMBDGKAOBP = HJMBDGKAOBP.MIHJHLFLHNA();
		this.IDHLPOFDLKJ = IDHLPOFDLKJ;
		this.GPJDJCGDJDC = GPJDJCGDJDC;
		this.HJBOEOOLOOE = NOGCEBKPPJE.IKBFGGABMKP(HJBOEOOLOOE);
	}

	public byte[] GKBBKKNGJAK()
	{
		return NOGCEBKPPJE.IKBFGGABMKP(HJBOEOOLOOE);
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == this)
		{
			return true;
		}
		MJDENGGDLMJ mJDENGGDLMJ = NEMEKIOEOLC as MJDENGGDLMJ;
		if (mJDENGGDLMJ == null)
		{
			return false;
		}
		return KIFDKLPDKMD(mJDENGGDLMJ);
	}

	protected virtual bool KIFDKLPDKMD(MJDENGGDLMJ CJHEIBNHNNE)
	{
		return NINILENHPHE.KIFDKLPDKMD(CJHEIBNHNNE.NINILENHPHE) && HJMBDGKAOBP.KIFDKLPDKMD(CJHEIBNHNNE.HJMBDGKAOBP) && IDHLPOFDLKJ.Equals(CJHEIBNHNNE.IDHLPOFDLKJ) && GPJDJCGDJDC.Equals(CJHEIBNHNNE.GPJDJCGDJDC);
	}

	public override int GetHashCode()
	{
		int hashCode = NINILENHPHE.GetHashCode();
		hashCode *= 37;
		hashCode ^= HJMBDGKAOBP.GetHashCode();
		hashCode *= 37;
		hashCode ^= IDHLPOFDLKJ.GetHashCode();
		hashCode *= 37;
		return hashCode ^ GPJDJCGDJDC.GetHashCode();
	}
}
