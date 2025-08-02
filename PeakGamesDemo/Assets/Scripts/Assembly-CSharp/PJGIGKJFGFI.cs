using System;
using System.IO;

public abstract class PJGIGKJFGFI : EDOEBJJFOBM, FBDCBBCMCLK, HGIAHEKANFO
{
	internal byte[] GFPBBLPMOOL;

	public FBDCBBCMCLK NIJNIHGOKCA
	{
		get
		{
			return this;
		}
	}

	internal PJGIGKJFGFI(byte[] GFPBBLPMOOL)
	{
		if (GFPBBLPMOOL == null)
		{
			throw new ArgumentNullException("str");
		}
		this.GFPBBLPMOOL = GFPBBLPMOOL;
	}

	internal PJGIGKJFGFI(LNKPCJLANAO NEMEKIOEOLC)
	{
		try
		{
			GFPBBLPMOOL = NEMEKIOEOLC.PPCPBIEGJKM("DER");
		}
		catch (IOException ex)
		{
			throw new ArgumentException("Error processing object : " + ex.ToString());
		}
	}

	public static PJGIGKJFGFI BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DNBCBHLACCP)
	{
		EDOEBJJFOBM eDOEBJJFOBM = NEMEKIOEOLC.NFMFKPLPLLH();
		if (DNBCBHLACCP || eDOEBJJFOBM is PJGIGKJFGFI)
		{
			return BJLJCGFMFOO(eDOEBJJFOBM);
		}
		return OHNBHCLIOEI.PNDOAFIAFOE(ALLINHNNNJN.BJLJCGFMFOO(eDOEBJJFOBM));
	}

	public static PJGIGKJFGFI BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is PJGIGKJFGFI)
		{
			return (PJGIGKJFGFI)NEMEKIOEOLC;
		}
		if (NEMEKIOEOLC is PAANMJLACEF)
		{
			return BJLJCGFMFOO(((PAANMJLACEF)NEMEKIOEOLC).NFMFKPLPLLH());
		}
		throw new ArgumentException("illegal object in GetInstance: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC));
	}

	public Stream PKLNGAOHLDC()
	{
		return new MemoryStream(GFPBBLPMOOL, false);
	}

	public virtual byte[] KLHNEKMCKKI()
	{
		return GFPBBLPMOOL;
	}

	protected override int BGFGDLGFEPI()
	{
		return NOGCEBKPPJE.ILMFICENEMK(KLHNEKMCKKI());
	}

	protected override bool IMHPDJGGAGJ(EDOEBJJFOBM LABMKGMAEGK)
	{
		CFMJBFILJCB cFMJBFILJCB = LABMKGMAEGK as CFMJBFILJCB;
		if (cFMJBFILJCB == null)
		{
			return false;
		}
		return NOGCEBKPPJE.ICKLINNFHKK(KLHNEKMCKKI(), cFMJBFILJCB.KLHNEKMCKKI());
	}

	public override string ToString()
	{
		return "#" + DCDJMDOEKHC.ALIGGGKEJEN(GFPBBLPMOOL);
	}
}
