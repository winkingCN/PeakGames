using System;

public class KCKEFHLLGIO : LHPKOCNBCPP
{
	private readonly string GFPBBLPMOOL;

	public KCKEFHLLGIO(byte[] GFPBBLPMOOL)
		: this(CCGLOIJJMKC.DNHBLFMKDDH(GFPBBLPMOOL), false)
	{
	}

	public KCKEFHLLGIO(string GFPBBLPMOOL)
		: this(GFPBBLPMOOL, false)
	{
	}

	public KCKEFHLLGIO(string GFPBBLPMOOL, bool DKNEEIJCCCG)
	{
		if (GFPBBLPMOOL == null)
		{
			throw new ArgumentNullException("str");
		}
		if (DKNEEIJCCCG && !ABPMKCODPCI(GFPBBLPMOOL))
		{
			throw new ArgumentException("string contains illegal characters", "str");
		}
		this.GFPBBLPMOOL = GFPBBLPMOOL;
	}

	public static KCKEFHLLGIO BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is KCKEFHLLGIO)
		{
			return (KCKEFHLLGIO)NEMEKIOEOLC;
		}
		throw new ArgumentException("illegal object in GetInstance: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC));
	}

	public static KCKEFHLLGIO BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DNBCBHLACCP)
	{
		EDOEBJJFOBM eDOEBJJFOBM = NEMEKIOEOLC.NFMFKPLPLLH();
		if (DNBCBHLACCP || eDOEBJJFOBM is KCKEFHLLGIO)
		{
			return BJLJCGFMFOO(eDOEBJJFOBM);
		}
		return new KCKEFHLLGIO(((PJGIGKJFGFI)eDOEBJJFOBM).KLHNEKMCKKI());
	}

	public override string JDANMONKNGD()
	{
		return GFPBBLPMOOL;
	}

	public byte[] KLHNEKMCKKI()
	{
		return CCGLOIJJMKC.IFHLAPJLHNG(GFPBBLPMOOL);
	}

	internal override void LMDBBPLCJDM(JBLJHINPLMC NMHOOGAGLOA)
	{
		NMHOOGAGLOA.AGNEJPEMPAP(22, KLHNEKMCKKI());
	}

	protected override int BGFGDLGFEPI()
	{
		return GFPBBLPMOOL.GetHashCode();
	}

	protected override bool IMHPDJGGAGJ(EDOEBJJFOBM LABMKGMAEGK)
	{
		KCKEFHLLGIO kCKEFHLLGIO = LABMKGMAEGK as KCKEFHLLGIO;
		if (kCKEFHLLGIO == null)
		{
			return false;
		}
		return GFPBBLPMOOL.Equals(kCKEFHLLGIO.GFPBBLPMOOL);
	}

	public static bool ABPMKCODPCI(string GFPBBLPMOOL)
	{
		foreach (char c in GFPBBLPMOOL)
		{
			if (c > '\u007f')
			{
				return false;
			}
		}
		return true;
	}
}
