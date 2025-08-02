using System;

public class GFMDJNIDEDM : LHPKOCNBCPP
{
	private readonly string GFPBBLPMOOL;

	public GFMDJNIDEDM(byte[] GFPBBLPMOOL)
	{
		if (GFPBBLPMOOL == null)
		{
			throw new ArgumentNullException("str");
		}
		char[] array = new char[GFPBBLPMOOL.Length / 2];
		for (int i = 0; i != array.Length; i++)
		{
			array[i] = (char)((uint)(GFPBBLPMOOL[2 * i] << 8) | (GFPBBLPMOOL[2 * i + 1] & 0xFFu));
		}
		this.GFPBBLPMOOL = new string(array);
	}

	public GFMDJNIDEDM(string GFPBBLPMOOL)
	{
		if (GFPBBLPMOOL == null)
		{
			throw new ArgumentNullException("str");
		}
		this.GFPBBLPMOOL = GFPBBLPMOOL;
	}

	public static GFMDJNIDEDM BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is GFMDJNIDEDM)
		{
			return (GFMDJNIDEDM)NEMEKIOEOLC;
		}
		throw new ArgumentException("illegal object in GetInstance: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC));
	}

	public static GFMDJNIDEDM BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DNBCBHLACCP)
	{
		EDOEBJJFOBM eDOEBJJFOBM = NEMEKIOEOLC.NFMFKPLPLLH();
		if (DNBCBHLACCP || eDOEBJJFOBM is GFMDJNIDEDM)
		{
			return BJLJCGFMFOO(eDOEBJJFOBM);
		}
		return new GFMDJNIDEDM(PJGIGKJFGFI.BJLJCGFMFOO(eDOEBJJFOBM).KLHNEKMCKKI());
	}

	public override string JDANMONKNGD()
	{
		return GFPBBLPMOOL;
	}

	protected override bool IMHPDJGGAGJ(EDOEBJJFOBM LABMKGMAEGK)
	{
		GFMDJNIDEDM gFMDJNIDEDM = LABMKGMAEGK as GFMDJNIDEDM;
		if (gFMDJNIDEDM == null)
		{
			return false;
		}
		return GFPBBLPMOOL.Equals(gFMDJNIDEDM.GFPBBLPMOOL);
	}

	internal override void LMDBBPLCJDM(JBLJHINPLMC NMHOOGAGLOA)
	{
		char[] array = GFPBBLPMOOL.ToCharArray();
		byte[] array2 = new byte[array.Length * 2];
		for (int i = 0; i != array.Length; i++)
		{
			array2[2 * i] = (byte)((int)array[i] >> 8);
			array2[2 * i + 1] = (byte)array[i];
		}
		NMHOOGAGLOA.AGNEJPEMPAP(30, array2);
	}
}
