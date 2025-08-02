using System;
using System.Text;

public class OGCOHFIOEED : LNKPCJLANAO
{
	internal readonly ALLINHNNNJN MIABODPHOIP;

	private OGCOHFIOEED(ALLINHNNNJN MIABODPHOIP)
	{
		this.MIABODPHOIP = MIABODPHOIP;
	}

	public OGCOHFIOEED(FBBFKLCIBLJ[] JJJGMPMMJIN)
	{
		MIABODPHOIP = new KOGPLMALOEH(JJJGMPMMJIN);
	}

	public static OGCOHFIOEED BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DHGLJHFEJFL)
	{
		return BJLJCGFMFOO(ALLINHNNNJN.BJLJCGFMFOO(NEMEKIOEOLC, DHGLJHFEJFL));
	}

	public static OGCOHFIOEED BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC is OGCOHFIOEED || NEMEKIOEOLC == null)
		{
			return (OGCOHFIOEED)NEMEKIOEOLC;
		}
		if (NEMEKIOEOLC is ALLINHNNNJN)
		{
			return new OGCOHFIOEED((ALLINHNNNJN)NEMEKIOEOLC);
		}
		throw new ArgumentException("unknown object in factory: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC), "obj");
	}

	public FBBFKLCIBLJ[] IHJCJOHHENA()
	{
		FBBFKLCIBLJ[] array = new FBBFKLCIBLJ[MIABODPHOIP.GMCGMPEEHJP];
		for (int i = 0; i != MIABODPHOIP.GMCGMPEEHJP; i++)
		{
			array[i] = FBBFKLCIBLJ.BJLJCGFMFOO(MIABODPHOIP.ECNCPJGHBIG(i));
		}
		return array;
	}

	public override EDOEBJJFOBM IIHKEACDNID()
	{
		return MIABODPHOIP;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		string iAHDCIONPPF = LHFGHNFJIKM.IAHDCIONPPF;
		stringBuilder.Append("CRLDistPoint:");
		stringBuilder.Append(iAHDCIONPPF);
		FBBFKLCIBLJ[] array = IHJCJOHHENA();
		for (int i = 0; i != array.Length; i++)
		{
			stringBuilder.Append("    ");
			stringBuilder.Append(array[i]);
			stringBuilder.Append(iAHDCIONPPF);
		}
		return stringBuilder.ToString();
	}
}
