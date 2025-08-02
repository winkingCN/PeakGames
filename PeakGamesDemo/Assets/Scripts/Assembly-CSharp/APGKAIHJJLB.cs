public class APGKAIHJJLB
{
	private string IOCMOCCFALN;

	private string HIMINGHNIKN;

	public virtual string PNGPLGHKFDI
	{
		get
		{
			return IOCMOCCFALN;
		}
	}

	public virtual string JBGOANMLBFA
	{
		get
		{
			return HIMINGHNIKN;
		}
	}

	public APGKAIHJJLB(string IOCMOCCFALN, string HIMINGHNIKN)
	{
		this.IOCMOCCFALN = IOCMOCCFALN;
		this.HIMINGHNIKN = HIMINGHNIKN;
	}

	public override int GetHashCode()
	{
		return ILMFICENEMK(IOCMOCCFALN) + 31 * ILMFICENEMK(HIMINGHNIKN);
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == this)
		{
			return true;
		}
		if (!(NEMEKIOEOLC is APGKAIHJJLB))
		{
			return false;
		}
		APGKAIHJJLB aPGKAIHJJLB = (APGKAIHJJLB)NEMEKIOEOLC;
		return object.Equals(IOCMOCCFALN, aPGKAIHJJLB.IOCMOCCFALN) && object.Equals(HIMINGHNIKN, aPGKAIHJJLB.HIMINGHNIKN);
	}

	private int ILMFICENEMK(string IBBBMACIBGK)
	{
		if (IBBBMACIBGK == null)
		{
			return 1;
		}
		return IBBBMACIBGK.GetHashCode();
	}
}
