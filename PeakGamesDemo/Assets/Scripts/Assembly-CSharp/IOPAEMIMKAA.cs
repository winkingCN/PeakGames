using System;

public class IOPAEMIMKAA : LNKPCJLANAO, MFHFAODDMLI
{
	private readonly EDOEBJJFOBM OFLEHJFAPKH;

	public bool EKBDDOPLOLM
	{
		get
		{
			return OFLEHJFAPKH is KLKJHFKJLEM;
		}
	}

	public bool EBHPFBKEKOH
	{
		get
		{
			return OFLEHJFAPKH is OIONBALGCNP;
		}
	}

	public EDOEBJJFOBM KPJHHAAOFOH
	{
		get
		{
			return OFLEHJFAPKH;
		}
	}

	public IOPAEMIMKAA(JMLDNPGFBDA PDOJLPLFJCN)
	{
		OFLEHJFAPKH = PDOJLPLFJCN.IIHKEACDNID();
	}

	public IOPAEMIMKAA(KLKJHFKJLEM NELJNGEPEFH)
	{
		OFLEHJFAPKH = NELJNGEPEFH;
	}

	public IOPAEMIMKAA(EDOEBJJFOBM NEMEKIOEOLC)
	{
		OFLEHJFAPKH = NEMEKIOEOLC;
	}

	public static IOPAEMIMKAA BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is IOPAEMIMKAA)
		{
			return (IOPAEMIMKAA)NEMEKIOEOLC;
		}
		if (NEMEKIOEOLC is EDOEBJJFOBM)
		{
			return new IOPAEMIMKAA((EDOEBJJFOBM)NEMEKIOEOLC);
		}
		if (NEMEKIOEOLC is byte[])
		{
			try
			{
				return new IOPAEMIMKAA(EDOEBJJFOBM.HPDCKMOPEMM((byte[])NEMEKIOEOLC));
			}
			catch (Exception ex)
			{
				throw new ArgumentException("unable to parse encoded data: " + ex.Message, ex);
			}
		}
		throw new ArgumentException("unknown object in getInstance()");
	}

	public override EDOEBJJFOBM IIHKEACDNID()
	{
		return OFLEHJFAPKH;
	}
}
