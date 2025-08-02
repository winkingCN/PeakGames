using System;
using System.Text;

public class FBBFKLCIBLJ : LNKPCJLANAO
{
	internal readonly CMOHOCOIBFO OONFAIPMMDI;

	internal readonly NMBHFHPOABK KIPPHCBGACN;

	internal readonly MCPMNHLFDME DPBAIPOPEHI;

	public CMOHOCOIBFO LIIHBAAAADK
	{
		get
		{
			return OONFAIPMMDI;
		}
	}

	public NMBHFHPOABK HHPCNFFGDMA
	{
		get
		{
			return KIPPHCBGACN;
		}
	}

	public MCPMNHLFDME KADOMFNJCPO
	{
		get
		{
			return DPBAIPOPEHI;
		}
	}

	private FBBFKLCIBLJ(ALLINHNNNJN MIABODPHOIP)
	{
		for (int i = 0; i != MIABODPHOIP.GMCGMPEEHJP; i++)
		{
			PAANMJLACEF pAANMJLACEF = PAANMJLACEF.BJLJCGFMFOO(MIABODPHOIP.ECNCPJGHBIG(i));
			switch (pAANMJLACEF.JPBIKBDCEKC)
			{
			case 0:
				OONFAIPMMDI = CMOHOCOIBFO.BJLJCGFMFOO(pAANMJLACEF, true);
				break;
			case 1:
				KIPPHCBGACN = new NMBHFHPOABK(FJMKMKNJKOI.BJLJCGFMFOO(pAANMJLACEF, false));
				break;
			case 2:
				DPBAIPOPEHI = MCPMNHLFDME.BJLJCGFMFOO(pAANMJLACEF, false);
				break;
			}
		}
	}

	public FBBFKLCIBLJ(CMOHOCOIBFO OFBBOAMFPOK, NMBHFHPOABK KIPPHCBGACN, MCPMNHLFDME IGGDMEBLMOC)
	{
		OONFAIPMMDI = OFBBOAMFPOK;
		this.KIPPHCBGACN = KIPPHCBGACN;
		DPBAIPOPEHI = IGGDMEBLMOC;
	}

	public static FBBFKLCIBLJ BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DHGLJHFEJFL)
	{
		return BJLJCGFMFOO(ALLINHNNNJN.BJLJCGFMFOO(NEMEKIOEOLC, DHGLJHFEJFL));
	}

	public static FBBFKLCIBLJ BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is FBBFKLCIBLJ)
		{
			return (FBBFKLCIBLJ)NEMEKIOEOLC;
		}
		if (NEMEKIOEOLC is ALLINHNNNJN)
		{
			return new FBBFKLCIBLJ((ALLINHNNNJN)NEMEKIOEOLC);
		}
		throw new ArgumentException("Invalid DistributionPoint: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC));
	}

	public override EDOEBJJFOBM IIHKEACDNID()
	{
		DLDBGGDLOOO dLDBGGDLOOO = new DLDBGGDLOOO();
		if (OONFAIPMMDI != null)
		{
			dLDBGGDLOOO.JEACJNAKLDJ(new JIHIOOKBBLB(0, OONFAIPMMDI));
		}
		if (KIPPHCBGACN != null)
		{
			dLDBGGDLOOO.JEACJNAKLDJ(new JIHIOOKBBLB(false, 1, KIPPHCBGACN));
		}
		if (DPBAIPOPEHI != null)
		{
			dLDBGGDLOOO.JEACJNAKLDJ(new JIHIOOKBBLB(false, 2, DPBAIPOPEHI));
		}
		return new KOGPLMALOEH(dLDBGGDLOOO);
	}

	public override string ToString()
	{
		string iAHDCIONPPF = LHFGHNFJIKM.IAHDCIONPPF;
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("DistributionPoint: [");
		stringBuilder.Append(iAHDCIONPPF);
		if (OONFAIPMMDI != null)
		{
			NBOHCFMFHOG(stringBuilder, iAHDCIONPPF, "distributionPoint", OONFAIPMMDI.ToString());
		}
		if (KIPPHCBGACN != null)
		{
			NBOHCFMFHOG(stringBuilder, iAHDCIONPPF, "reasons", KIPPHCBGACN.ToString());
		}
		if (DPBAIPOPEHI != null)
		{
			NBOHCFMFHOG(stringBuilder, iAHDCIONPPF, "cRLIssuer", DPBAIPOPEHI.ToString());
		}
		stringBuilder.Append("]");
		stringBuilder.Append(iAHDCIONPPF);
		return stringBuilder.ToString();
	}

	private void NBOHCFMFHOG(StringBuilder GHPCHPOHELF, string CKJOLFKKDEB, string IOCMOCCFALN, string HIMINGHNIKN)
	{
		string value = "    ";
		GHPCHPOHELF.Append(value);
		GHPCHPOHELF.Append(IOCMOCCFALN);
		GHPCHPOHELF.Append(":");
		GHPCHPOHELF.Append(CKJOLFKKDEB);
		GHPCHPOHELF.Append(value);
		GHPCHPOHELF.Append(value);
		GHPCHPOHELF.Append(HIMINGHNIKN);
		GHPCHPOHELF.Append(CKJOLFKKDEB);
	}
}
