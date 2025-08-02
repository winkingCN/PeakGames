using System;
using System.Text;

public class MCPMNHLFDME : LNKPCJLANAO
{
	private readonly GGHMCHAHOCN[] ANNGLDLKCBL;

	public MCPMNHLFDME(GGHMCHAHOCN IOCMOCCFALN)
	{
		ANNGLDLKCBL = new GGHMCHAHOCN[1] { IOCMOCCFALN };
	}

	public MCPMNHLFDME(GGHMCHAHOCN[] ANNGLDLKCBL)
	{
		this.ANNGLDLKCBL = (GGHMCHAHOCN[])ANNGLDLKCBL.Clone();
	}

	private MCPMNHLFDME(ALLINHNNNJN MIABODPHOIP)
	{
		ANNGLDLKCBL = new GGHMCHAHOCN[MIABODPHOIP.GMCGMPEEHJP];
		for (int i = 0; i != MIABODPHOIP.GMCGMPEEHJP; i++)
		{
			ANNGLDLKCBL[i] = GGHMCHAHOCN.BJLJCGFMFOO(MIABODPHOIP.ECNCPJGHBIG(i));
		}
	}

	public static MCPMNHLFDME BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is MCPMNHLFDME)
		{
			return (MCPMNHLFDME)NEMEKIOEOLC;
		}
		if (NEMEKIOEOLC is ALLINHNNNJN)
		{
			return new MCPMNHLFDME((ALLINHNNNJN)NEMEKIOEOLC);
		}
		throw new ArgumentException("unknown object in factory: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC), "obj");
	}

	public static MCPMNHLFDME BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DHGLJHFEJFL)
	{
		return BJLJCGFMFOO(ALLINHNNNJN.BJLJCGFMFOO(NEMEKIOEOLC, DHGLJHFEJFL));
	}

	public GGHMCHAHOCN[] IHJHGEPHIOI()
	{
		return (GGHMCHAHOCN[])ANNGLDLKCBL.Clone();
	}

	public override EDOEBJJFOBM IIHKEACDNID()
	{
		return new KOGPLMALOEH(ANNGLDLKCBL);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		string iAHDCIONPPF = LHFGHNFJIKM.IAHDCIONPPF;
		stringBuilder.Append("GeneralNames:");
		stringBuilder.Append(iAHDCIONPPF);
		GGHMCHAHOCN[] aNNGLDLKCBL = ANNGLDLKCBL;
		foreach (GGHMCHAHOCN value in aNNGLDLKCBL)
		{
			stringBuilder.Append("    ");
			stringBuilder.Append(value);
			stringBuilder.Append(iAHDCIONPPF);
		}
		return stringBuilder.ToString();
	}
}
