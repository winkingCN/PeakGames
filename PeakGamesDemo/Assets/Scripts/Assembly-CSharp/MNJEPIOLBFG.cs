using System;

public class MNJEPIOLBFG : LHPKOCNBCPP
{
	private readonly byte[] HMMCGFLKHKM;

	public MNJEPIOLBFG(byte[] NJPMJNHGDNE)
	{
		HMMCGFLKHKM = NOGCEBKPPJE.IKBFGGABMKP(NJPMJNHGDNE);
	}

	public static MNJEPIOLBFG BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is MNJEPIOLBFG)
		{
			return (MNJEPIOLBFG)NEMEKIOEOLC;
		}
		if (NEMEKIOEOLC is byte[])
		{
			try
			{
				return (MNJEPIOLBFG)EDOEBJJFOBM.HPDCKMOPEMM((byte[])NEMEKIOEOLC);
			}
			catch (Exception ex)
			{
				throw new ArgumentException("encoding error in GetInstance: " + ex.ToString(), "obj");
			}
		}
		throw new ArgumentException("illegal object in GetInstance: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC), "obj");
	}

	public static MNJEPIOLBFG BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DNBCBHLACCP)
	{
		EDOEBJJFOBM eDOEBJJFOBM = NEMEKIOEOLC.NFMFKPLPLLH();
		if (DNBCBHLACCP || eDOEBJJFOBM is MNJEPIOLBFG)
		{
			return BJLJCGFMFOO(eDOEBJJFOBM);
		}
		return new MNJEPIOLBFG(((PJGIGKJFGFI)eDOEBJJFOBM).KLHNEKMCKKI());
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
		NMHOOGAGLOA.AGNEJPEMPAP(21, HMMCGFLKHKM);
	}

	protected override int BGFGDLGFEPI()
	{
		return NOGCEBKPPJE.ILMFICENEMK(HMMCGFLKHKM);
	}

	protected override bool IMHPDJGGAGJ(EDOEBJJFOBM LABMKGMAEGK)
	{
		MNJEPIOLBFG mNJEPIOLBFG = LABMKGMAEGK as MNJEPIOLBFG;
		if (mNJEPIOLBFG == null)
		{
			return false;
		}
		return NOGCEBKPPJE.ICKLINNFHKK(HMMCGFLKHKM, mNJEPIOLBFG.HMMCGFLKHKM);
	}
}
