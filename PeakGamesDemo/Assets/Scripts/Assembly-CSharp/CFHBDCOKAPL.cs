using System;

public class CFHBDCOKAPL
{
	private readonly byte[] HJBOEOOLOOE;

	private readonly int CKKJMJHIJBN;

	private readonly int MOEIOBEIDFC;

	public virtual int NBACENGNIBB
	{
		get
		{
			return CKKJMJHIJBN;
		}
	}

	public virtual int FBLPDDIHHOC
	{
		get
		{
			return MOEIOBEIDFC;
		}
	}

	public CFHBDCOKAPL(byte[] HJBOEOOLOOE, int CKKJMJHIJBN)
		: this(HJBOEOOLOOE, CKKJMJHIJBN, -1)
	{
	}

	public CFHBDCOKAPL(byte[] HJBOEOOLOOE, int CKKJMJHIJBN, int MOEIOBEIDFC)
	{
		if (HJBOEOOLOOE == null)
		{
			throw new ArgumentNullException("seed");
		}
		this.HJBOEOOLOOE = (byte[])HJBOEOOLOOE.Clone();
		this.CKKJMJHIJBN = CKKJMJHIJBN;
		this.MOEIOBEIDFC = MOEIOBEIDFC;
	}

	public virtual byte[] GKBBKKNGJAK()
	{
		return (byte[])HJBOEOOLOOE.Clone();
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == this)
		{
			return true;
		}
		CFHBDCOKAPL cFHBDCOKAPL = NEMEKIOEOLC as CFHBDCOKAPL;
		if (cFHBDCOKAPL == null)
		{
			return false;
		}
		return KIFDKLPDKMD(cFHBDCOKAPL);
	}

	protected virtual bool KIFDKLPDKMD(CFHBDCOKAPL CJHEIBNHNNE)
	{
		return CKKJMJHIJBN == CJHEIBNHNNE.CKKJMJHIJBN && NOGCEBKPPJE.ICKLINNFHKK(HJBOEOOLOOE, CJHEIBNHNNE.HJBOEOOLOOE);
	}

	public override int GetHashCode()
	{
		return CKKJMJHIJBN.GetHashCode() ^ NOGCEBKPPJE.ILMFICENEMK(HJBOEOOLOOE);
	}
}
