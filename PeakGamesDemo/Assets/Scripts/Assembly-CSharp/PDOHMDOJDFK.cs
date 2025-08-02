public class PDOHMDOJDFK : COEMJAGOFJJ
{
	private readonly CFBBJKGJFPE IJJHBEECMBP;

	public CFBBJKGJFPE KPJHHAAOFOH
	{
		get
		{
			return IJJHBEECMBP;
		}
	}

	protected PDOHMDOJDFK(bool OFKEGLBCAJF, CFBBJKGJFPE IJJHBEECMBP)
		: base(OFKEGLBCAJF)
	{
		this.IJJHBEECMBP = IJJHBEECMBP;
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == this)
		{
			return true;
		}
		PDOHMDOJDFK pDOHMDOJDFK = NEMEKIOEOLC as PDOHMDOJDFK;
		if (pDOHMDOJDFK == null)
		{
			return false;
		}
		return KIFDKLPDKMD(pDOHMDOJDFK);
	}

	protected bool KIFDKLPDKMD(PDOHMDOJDFK CJHEIBNHNNE)
	{
		return object.Equals(IJJHBEECMBP, CJHEIBNHNNE.IJJHBEECMBP) && KIFDKLPDKMD((COEMJAGOFJJ)CJHEIBNHNNE);
	}

	public override int GetHashCode()
	{
		int num = base.GetHashCode();
		if (IJJHBEECMBP != null)
		{
			num ^= IJJHBEECMBP.GetHashCode();
		}
		return num;
	}
}
