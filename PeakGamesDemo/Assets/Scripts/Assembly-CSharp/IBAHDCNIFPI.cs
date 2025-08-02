public class IBAHDCNIFPI : COEMJAGOFJJ
{
	private readonly CLBPDHGBHML IJJHBEECMBP;

	private readonly KLKJHFKJLEM KEJOEEMPKLM;

	public CLBPDHGBHML KPJHHAAOFOH
	{
		get
		{
			return IJJHBEECMBP;
		}
	}

	public KLKJHFKJLEM IMDHMFELAAB
	{
		get
		{
			return KEJOEEMPKLM;
		}
	}

	protected IBAHDCNIFPI(bool OFKEGLBCAJF, CLBPDHGBHML IJJHBEECMBP)
		: this(OFKEGLBCAJF, IJJHBEECMBP, NLPPJKFFBON.JDDKJFLACKJ)
	{
	}

	protected IBAHDCNIFPI(bool OFKEGLBCAJF, CLBPDHGBHML IJJHBEECMBP, KLKJHFKJLEM KEJOEEMPKLM)
		: base(OFKEGLBCAJF)
	{
		this.IJJHBEECMBP = IJJHBEECMBP;
		this.KEJOEEMPKLM = KEJOEEMPKLM;
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == this)
		{
			return true;
		}
		IBAHDCNIFPI iBAHDCNIFPI = NEMEKIOEOLC as IBAHDCNIFPI;
		if (iBAHDCNIFPI == null)
		{
			return false;
		}
		return KIFDKLPDKMD(iBAHDCNIFPI);
	}

	protected bool KIFDKLPDKMD(IBAHDCNIFPI CJHEIBNHNNE)
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
