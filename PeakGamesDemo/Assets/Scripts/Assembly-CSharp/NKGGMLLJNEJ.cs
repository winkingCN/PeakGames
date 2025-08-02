using System;

public class NKGGMLLJNEJ : LHPKOCNBCPP
{
	private readonly byte[] HMMCGFLKHKM;

	public NKGGMLLJNEJ(byte[] NJPMJNHGDNE)
	{
		HMMCGFLKHKM = NOGCEBKPPJE.IKBFGGABMKP(NJPMJNHGDNE);
	}

	public static NKGGMLLJNEJ BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is NKGGMLLJNEJ)
		{
			return (NKGGMLLJNEJ)NEMEKIOEOLC;
		}
		if (NEMEKIOEOLC is byte[])
		{
			try
			{
				return (NKGGMLLJNEJ)EDOEBJJFOBM.HPDCKMOPEMM((byte[])NEMEKIOEOLC);
			}
			catch (Exception ex)
			{
				throw new ArgumentException("encoding error in GetInstance: " + ex.ToString(), "obj");
			}
		}
		throw new ArgumentException("illegal object in GetInstance: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC), "obj");
	}

	public static NKGGMLLJNEJ BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DNBCBHLACCP)
	{
		EDOEBJJFOBM eDOEBJJFOBM = NEMEKIOEOLC.NFMFKPLPLLH();
		if (DNBCBHLACCP || eDOEBJJFOBM is NKGGMLLJNEJ)
		{
			return BJLJCGFMFOO(eDOEBJJFOBM);
		}
		return new NKGGMLLJNEJ(((PJGIGKJFGFI)eDOEBJJFOBM).KLHNEKMCKKI());
	}

	public override string JDANMONKNGD()
	{
		return CCGLOIJJMKC.HPDCKMOPEMM(HMMCGFLKHKM);
	}

	public byte[] KLHNEKMCKKI()
	{
		return NOGCEBKPPJE.IKBFGGABMKP(HMMCGFLKHKM);
	}

	internal override void LMDBBPLCJDM(JBLJHINPLMC NMHOOGAGLOA)
	{
		NMHOOGAGLOA.AGNEJPEMPAP(25, HMMCGFLKHKM);
	}

	protected override int BGFGDLGFEPI()
	{
		return NOGCEBKPPJE.ILMFICENEMK(HMMCGFLKHKM);
	}

	protected override bool IMHPDJGGAGJ(EDOEBJJFOBM LABMKGMAEGK)
	{
		NKGGMLLJNEJ nKGGMLLJNEJ = LABMKGMAEGK as NKGGMLLJNEJ;
		if (nKGGMLLJNEJ == null)
		{
			return false;
		}
		return NOGCEBKPPJE.ICKLINNFHKK(HMMCGFLKHKM, nKGGMLLJNEJ.HMMCGFLKHKM);
	}
}
