using System;
using System.Text;

public class GKCJIKGJBJA : LHPKOCNBCPP
{
	private readonly string GFPBBLPMOOL;

	public GKCJIKGJBJA(byte[] GFPBBLPMOOL)
		: this(Encoding.UTF8.GetString(GFPBBLPMOOL, 0, GFPBBLPMOOL.Length))
	{
	}

	public GKCJIKGJBJA(string GFPBBLPMOOL)
	{
		if (GFPBBLPMOOL == null)
		{
			throw new ArgumentNullException("str");
		}
		this.GFPBBLPMOOL = GFPBBLPMOOL;
	}

	public static GKCJIKGJBJA BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is GKCJIKGJBJA)
		{
			return (GKCJIKGJBJA)NEMEKIOEOLC;
		}
		throw new ArgumentException("illegal object in GetInstance: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC));
	}

	public static GKCJIKGJBJA BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DNBCBHLACCP)
	{
		EDOEBJJFOBM eDOEBJJFOBM = NEMEKIOEOLC.NFMFKPLPLLH();
		if (DNBCBHLACCP || eDOEBJJFOBM is GKCJIKGJBJA)
		{
			return BJLJCGFMFOO(eDOEBJJFOBM);
		}
		return new GKCJIKGJBJA(PJGIGKJFGFI.BJLJCGFMFOO(eDOEBJJFOBM).KLHNEKMCKKI());
	}

	public override string JDANMONKNGD()
	{
		return GFPBBLPMOOL;
	}

	protected override bool IMHPDJGGAGJ(EDOEBJJFOBM LABMKGMAEGK)
	{
		GKCJIKGJBJA gKCJIKGJBJA = LABMKGMAEGK as GKCJIKGJBJA;
		if (gKCJIKGJBJA == null)
		{
			return false;
		}
		return GFPBBLPMOOL.Equals(gKCJIKGJBJA.GFPBBLPMOOL);
	}

	internal override void LMDBBPLCJDM(JBLJHINPLMC NMHOOGAGLOA)
	{
		NMHOOGAGLOA.AGNEJPEMPAP(12, Encoding.UTF8.GetBytes(GFPBBLPMOOL));
	}
}
