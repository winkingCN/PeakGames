using System;

public class JLGEDJAOAIJ : LHPKOCNBCPP
{
	private readonly string GFPBBLPMOOL;

	public JLGEDJAOAIJ(byte[] GFPBBLPMOOL)
		: this(CCGLOIJJMKC.DNHBLFMKDDH(GFPBBLPMOOL), false)
	{
	}

	public JLGEDJAOAIJ(string GFPBBLPMOOL)
		: this(GFPBBLPMOOL, false)
	{
	}

	public JLGEDJAOAIJ(string GFPBBLPMOOL, bool DKNEEIJCCCG)
	{
		if (GFPBBLPMOOL == null)
		{
			throw new ArgumentNullException("str");
		}
		if (DKNEEIJCCCG && !NOCNDAGADMM(GFPBBLPMOOL))
		{
			throw new ArgumentException("string contains illegal characters", "str");
		}
		this.GFPBBLPMOOL = GFPBBLPMOOL;
	}

	public static JLGEDJAOAIJ BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is JLGEDJAOAIJ)
		{
			return (JLGEDJAOAIJ)NEMEKIOEOLC;
		}
		throw new ArgumentException("illegal object in GetInstance: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC));
	}

	public static JLGEDJAOAIJ BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DNBCBHLACCP)
	{
		EDOEBJJFOBM eDOEBJJFOBM = NEMEKIOEOLC.NFMFKPLPLLH();
		if (DNBCBHLACCP || eDOEBJJFOBM is JLGEDJAOAIJ)
		{
			return BJLJCGFMFOO(eDOEBJJFOBM);
		}
		return new JLGEDJAOAIJ(PJGIGKJFGFI.BJLJCGFMFOO(eDOEBJJFOBM).KLHNEKMCKKI());
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
		NMHOOGAGLOA.AGNEJPEMPAP(19, KLHNEKMCKKI());
	}

	protected override bool IMHPDJGGAGJ(EDOEBJJFOBM LABMKGMAEGK)
	{
		JLGEDJAOAIJ jLGEDJAOAIJ = LABMKGMAEGK as JLGEDJAOAIJ;
		if (jLGEDJAOAIJ == null)
		{
			return false;
		}
		return GFPBBLPMOOL.Equals(jLGEDJAOAIJ.GFPBBLPMOOL);
	}

	public static bool NOCNDAGADMM(string GFPBBLPMOOL)
	{
		foreach (char c in GFPBBLPMOOL)
		{
			if (c > '\u007f')
			{
				return false;
			}
			if (!char.IsLetterOrDigit(c))
			{
				switch (c)
				{
				case ' ':
				case '\'':
				case '(':
				case ')':
				case '+':
				case ',':
				case '-':
				case '.':
				case '/':
				case ':':
				case '=':
				case '?':
					continue;
				}
				return false;
			}
		}
		return true;
	}
}
