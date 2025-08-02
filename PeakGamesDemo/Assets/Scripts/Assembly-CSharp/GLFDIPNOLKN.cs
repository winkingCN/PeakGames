using System;
using Org.BouncyCastle.Math;

public class GLFDIPNOLKN : EDOEBJJFOBM
{
	private readonly byte[] DIPNEDDIHBK;

	public BigInteger JBGOANMLBFA
	{
		get
		{
			return new BigInteger(DIPNEDDIHBK);
		}
	}

	public BigInteger DMPHAJNKNKB
	{
		get
		{
			return new BigInteger(1, DIPNEDDIHBK);
		}
	}

	public GLFDIPNOLKN(int EDDNOJDPMCF)
	{
		DIPNEDDIHBK = BigInteger.AGLOJCOAJIK(EDDNOJDPMCF).EDHFCNLPGJC();
	}

	public GLFDIPNOLKN(BigInteger EDDNOJDPMCF)
	{
		if (EDDNOJDPMCF == null)
		{
			throw new ArgumentNullException("value");
		}
		DIPNEDDIHBK = EDDNOJDPMCF.EDHFCNLPGJC();
	}

	public GLFDIPNOLKN(byte[] DIPNEDDIHBK)
	{
		this.DIPNEDDIHBK = DIPNEDDIHBK;
	}

	public static GLFDIPNOLKN BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is GLFDIPNOLKN)
		{
			return (GLFDIPNOLKN)NEMEKIOEOLC;
		}
		throw new ArgumentException("illegal object in GetInstance: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC));
	}

	public static GLFDIPNOLKN BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DNBCBHLACCP)
	{
		if (NEMEKIOEOLC == null)
		{
			throw new ArgumentNullException("obj");
		}
		EDOEBJJFOBM eDOEBJJFOBM = NEMEKIOEOLC.NFMFKPLPLLH();
		if (DNBCBHLACCP || eDOEBJJFOBM is GLFDIPNOLKN)
		{
			return BJLJCGFMFOO(eDOEBJJFOBM);
		}
		return new GLFDIPNOLKN(PJGIGKJFGFI.BJLJCGFMFOO(eDOEBJJFOBM).KLHNEKMCKKI());
	}

	internal override void LMDBBPLCJDM(JBLJHINPLMC NMHOOGAGLOA)
	{
		NMHOOGAGLOA.AGNEJPEMPAP(2, DIPNEDDIHBK);
	}

	protected override int BGFGDLGFEPI()
	{
		return NOGCEBKPPJE.ILMFICENEMK(DIPNEDDIHBK);
	}

	protected override bool IMHPDJGGAGJ(EDOEBJJFOBM LABMKGMAEGK)
	{
		GLFDIPNOLKN gLFDIPNOLKN = LABMKGMAEGK as GLFDIPNOLKN;
		if (gLFDIPNOLKN == null)
		{
			return false;
		}
		return NOGCEBKPPJE.ICKLINNFHKK(DIPNEDDIHBK, gLFDIPNOLKN.DIPNEDDIHBK);
	}

	public override string ToString()
	{
		return JBGOANMLBFA.ToString();
	}
}
