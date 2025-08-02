using System;
using System.Text;

public class KPGIEFDJAEM : LHPKOCNBCPP
{
	private static readonly char[] AEPNIOFMGPL = new char[16]
	{
		'0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
		'A', 'B', 'C', 'D', 'E', 'F'
	};

	private readonly byte[] GFPBBLPMOOL;

	public KPGIEFDJAEM(byte[] GFPBBLPMOOL)
	{
		if (GFPBBLPMOOL == null)
		{
			throw new ArgumentNullException("str");
		}
		this.GFPBBLPMOOL = GFPBBLPMOOL;
	}

	public static KPGIEFDJAEM BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is KPGIEFDJAEM)
		{
			return (KPGIEFDJAEM)NEMEKIOEOLC;
		}
		throw new ArgumentException("illegal object in GetInstance: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC));
	}

	public static KPGIEFDJAEM BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DNBCBHLACCP)
	{
		EDOEBJJFOBM eDOEBJJFOBM = NEMEKIOEOLC.NFMFKPLPLLH();
		if (DNBCBHLACCP || eDOEBJJFOBM is KPGIEFDJAEM)
		{
			return BJLJCGFMFOO(eDOEBJJFOBM);
		}
		return new KPGIEFDJAEM(PJGIGKJFGFI.BJLJCGFMFOO(eDOEBJJFOBM).KLHNEKMCKKI());
	}

	public override string JDANMONKNGD()
	{
		StringBuilder stringBuilder = new StringBuilder("#");
		byte[] array = KMBJLPOKIAC();
		for (int i = 0; i != array.Length; i++)
		{
			uint num = array[i];
			stringBuilder.Append(AEPNIOFMGPL[(num >> 4) & 0xF]);
			stringBuilder.Append(AEPNIOFMGPL[array[i] & 0xF]);
		}
		return stringBuilder.ToString();
	}

	public byte[] KLHNEKMCKKI()
	{
		return (byte[])GFPBBLPMOOL.Clone();
	}

	internal override void LMDBBPLCJDM(JBLJHINPLMC NMHOOGAGLOA)
	{
		NMHOOGAGLOA.AGNEJPEMPAP(28, GFPBBLPMOOL);
	}

	protected override bool IMHPDJGGAGJ(EDOEBJJFOBM LABMKGMAEGK)
	{
		KPGIEFDJAEM kPGIEFDJAEM = LABMKGMAEGK as KPGIEFDJAEM;
		if (kPGIEFDJAEM == null)
		{
			return false;
		}
		return NOGCEBKPPJE.ICKLINNFHKK(GFPBBLPMOOL, kPGIEFDJAEM.GFPBBLPMOOL);
	}
}
