using System;

public class LDEOEEPIHGE : LHPKOCNBCPP
{
	private readonly string GFPBBLPMOOL;

	public LDEOEEPIHGE(byte[] GFPBBLPMOOL)
		: this(CCGLOIJJMKC.DNHBLFMKDDH(GFPBBLPMOOL), false)
	{
	}

	public LDEOEEPIHGE(string GFPBBLPMOOL)
		: this(GFPBBLPMOOL, false)
	{
	}

	public LDEOEEPIHGE(string GFPBBLPMOOL, bool DKNEEIJCCCG)
	{
		if (GFPBBLPMOOL == null)
		{
			throw new ArgumentNullException("str");
		}
		if (DKNEEIJCCCG && !CMAOOOJONFL(GFPBBLPMOOL))
		{
			throw new ArgumentException("string contains illegal characters", "str");
		}
		this.GFPBBLPMOOL = GFPBBLPMOOL;
	}

	public static LDEOEEPIHGE BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is LDEOEEPIHGE)
		{
			return (LDEOEEPIHGE)NEMEKIOEOLC;
		}
		throw new ArgumentException("illegal object in GetInstance: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC));
	}

	public static LDEOEEPIHGE BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DNBCBHLACCP)
	{
		EDOEBJJFOBM eDOEBJJFOBM = NEMEKIOEOLC.NFMFKPLPLLH();
		if (DNBCBHLACCP || eDOEBJJFOBM is LDEOEEPIHGE)
		{
			return BJLJCGFMFOO(eDOEBJJFOBM);
		}
		return new LDEOEEPIHGE(PJGIGKJFGFI.BJLJCGFMFOO(eDOEBJJFOBM).KLHNEKMCKKI());
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
		NMHOOGAGLOA.AGNEJPEMPAP(18, KLHNEKMCKKI());
	}

	protected override bool IMHPDJGGAGJ(EDOEBJJFOBM LABMKGMAEGK)
	{
		LDEOEEPIHGE lDEOEEPIHGE = LABMKGMAEGK as LDEOEEPIHGE;
		if (lDEOEEPIHGE == null)
		{
			return false;
		}
		return GFPBBLPMOOL.Equals(lDEOEEPIHGE.GFPBBLPMOOL);
	}

	public static bool CMAOOOJONFL(string GFPBBLPMOOL)
	{
		foreach (char c in GFPBBLPMOOL)
		{
			if (c > '\u007f' || (c != ' ' && !char.IsDigit(c)))
			{
				return false;
			}
		}
		return true;
	}
}
