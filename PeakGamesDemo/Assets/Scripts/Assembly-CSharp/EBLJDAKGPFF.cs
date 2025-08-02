public abstract class EBLJDAKGPFF : COEMJAGOFJJ
{
	private readonly JEHNKJOKBGF IJJHBEECMBP;

	public JEHNKJOKBGF KPJHHAAOFOH
	{
		get
		{
			return IJJHBEECMBP;
		}
	}

	protected EBLJDAKGPFF(bool OFKEGLBCAJF, JEHNKJOKBGF IJJHBEECMBP)
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
		EBLJDAKGPFF eBLJDAKGPFF = NEMEKIOEOLC as EBLJDAKGPFF;
		if (eBLJDAKGPFF == null)
		{
			return false;
		}
		return KIFDKLPDKMD(eBLJDAKGPFF);
	}

	protected bool KIFDKLPDKMD(EBLJDAKGPFF CJHEIBNHNNE)
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
