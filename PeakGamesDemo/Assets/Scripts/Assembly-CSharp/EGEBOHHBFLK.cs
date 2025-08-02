using System;

public class EGEBOHHBFLK : BKFMFPGHIJB
{
	private readonly JGAFKLGGBGF OKDPJHOEPBJ;

	public JGAFKLGGBGF FNPELDEHJKL
	{
		get
		{
			return OKDPJHOEPBJ;
		}
	}

	public EGEBOHHBFLK(JGAFKLGGBGF OKDPJHOEPBJ, MJDENGGDLMJ IJJHBEECMBP)
		: this("EC", OKDPJHOEPBJ, IJJHBEECMBP)
	{
	}

	[Obsolete("Use version with explicit 'algorithm' parameter")]
	public EGEBOHHBFLK(JGAFKLGGBGF OKDPJHOEPBJ, KLKJHFKJLEM DHNJFHPNJLM)
		: base("ECGOST3410", false, DHNJFHPNJLM)
	{
		if (OKDPJHOEPBJ == null)
		{
			throw new ArgumentNullException("q");
		}
		this.OKDPJHOEPBJ = OKDPJHOEPBJ.MIHJHLFLHNA();
	}

	public EGEBOHHBFLK(string ADLMOHOLCGL, JGAFKLGGBGF OKDPJHOEPBJ, MJDENGGDLMJ IJJHBEECMBP)
		: base(ADLMOHOLCGL, false, IJJHBEECMBP)
	{
		if (OKDPJHOEPBJ == null)
		{
			throw new ArgumentNullException("q");
		}
		this.OKDPJHOEPBJ = OKDPJHOEPBJ.MIHJHLFLHNA();
	}

	public EGEBOHHBFLK(string ADLMOHOLCGL, JGAFKLGGBGF OKDPJHOEPBJ, KLKJHFKJLEM DHNJFHPNJLM)
		: base(ADLMOHOLCGL, false, DHNJFHPNJLM)
	{
		if (OKDPJHOEPBJ == null)
		{
			throw new ArgumentNullException("q");
		}
		this.OKDPJHOEPBJ = OKDPJHOEPBJ.MIHJHLFLHNA();
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == this)
		{
			return true;
		}
		EGEBOHHBFLK eGEBOHHBFLK = NEMEKIOEOLC as EGEBOHHBFLK;
		if (eGEBOHHBFLK == null)
		{
			return false;
		}
		return KIFDKLPDKMD(eGEBOHHBFLK);
	}

	protected bool KIFDKLPDKMD(EGEBOHHBFLK CJHEIBNHNNE)
	{
		return OKDPJHOEPBJ.KIFDKLPDKMD(CJHEIBNHNNE.OKDPJHOEPBJ) && KIFDKLPDKMD((BKFMFPGHIJB)CJHEIBNHNNE);
	}

	public override int GetHashCode()
	{
		return OKDPJHOEPBJ.GetHashCode() ^ base.GetHashCode();
	}
}
