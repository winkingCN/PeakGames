using System;

public class EKOPFPAFGJO : LHPKOCNBCPP
{
	private readonly string GFPBBLPMOOL;

	public EKOPFPAFGJO(byte[] GFPBBLPMOOL)
		: this(CCGLOIJJMKC.DNHBLFMKDDH(GFPBBLPMOOL))
	{
	}

	public EKOPFPAFGJO(string GFPBBLPMOOL)
	{
		if (GFPBBLPMOOL == null)
		{
			throw new ArgumentNullException("str");
		}
		this.GFPBBLPMOOL = GFPBBLPMOOL;
	}

	public static EKOPFPAFGJO BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is EKOPFPAFGJO)
		{
			return (EKOPFPAFGJO)NEMEKIOEOLC;
		}
		if (NEMEKIOEOLC is PJGIGKJFGFI)
		{
			return new EKOPFPAFGJO(((PJGIGKJFGFI)NEMEKIOEOLC).KLHNEKMCKKI());
		}
		if (NEMEKIOEOLC is PAANMJLACEF)
		{
			return BJLJCGFMFOO(((PAANMJLACEF)NEMEKIOEOLC).NFMFKPLPLLH());
		}
		throw new ArgumentException("illegal object in GetInstance: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC));
	}

	public static EKOPFPAFGJO BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DHGLJHFEJFL)
	{
		return BJLJCGFMFOO(NEMEKIOEOLC.NFMFKPLPLLH());
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
		NMHOOGAGLOA.AGNEJPEMPAP(26, KLHNEKMCKKI());
	}

	protected override bool IMHPDJGGAGJ(EDOEBJJFOBM LABMKGMAEGK)
	{
		EKOPFPAFGJO eKOPFPAFGJO = LABMKGMAEGK as EKOPFPAFGJO;
		if (eKOPFPAFGJO == null)
		{
			return false;
		}
		return GFPBBLPMOOL.Equals(eKOPFPAFGJO.GFPBBLPMOOL);
	}

	protected override int BGFGDLGFEPI()
	{
		return GFPBBLPMOOL.GetHashCode();
	}
}
