using System;
using System.Text;

public class CMOHOCOIBFO : LNKPCJLANAO, MFHFAODDMLI
{
	internal readonly LNKPCJLANAO IOCMOCCFALN;

	internal readonly int NBFBPNNEKMN;

	public const int FFLOAAHALLL = 0;

	public const int FDGGOACNAOO = 1;

	public int AACFNIOBLKO
	{
		get
		{
			return NBFBPNNEKMN;
		}
	}

	public LNKPCJLANAO PNGPLGHKFDI
	{
		get
		{
			return IOCMOCCFALN;
		}
	}

	public CMOHOCOIBFO(int NBFBPNNEKMN, LNKPCJLANAO IOCMOCCFALN)
	{
		this.NBFBPNNEKMN = NBFBPNNEKMN;
		this.IOCMOCCFALN = IOCMOCCFALN;
	}

	public CMOHOCOIBFO(MCPMNHLFDME IOCMOCCFALN)
		: this(0, IOCMOCCFALN)
	{
	}

	public CMOHOCOIBFO(PAANMJLACEF NEMEKIOEOLC)
	{
		NBFBPNNEKMN = NEMEKIOEOLC.JPBIKBDCEKC;
		if (NBFBPNNEKMN == 0)
		{
			IOCMOCCFALN = MCPMNHLFDME.BJLJCGFMFOO(NEMEKIOEOLC, false);
		}
		else
		{
			IOCMOCCFALN = FAGODOKGMEH.BJLJCGFMFOO(NEMEKIOEOLC, false);
		}
	}

	public static CMOHOCOIBFO BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DHGLJHFEJFL)
	{
		return BJLJCGFMFOO(PAANMJLACEF.BJLJCGFMFOO(NEMEKIOEOLC, true));
	}

	public static CMOHOCOIBFO BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is CMOHOCOIBFO)
		{
			return (CMOHOCOIBFO)NEMEKIOEOLC;
		}
		if (NEMEKIOEOLC is PAANMJLACEF)
		{
			return new CMOHOCOIBFO((PAANMJLACEF)NEMEKIOEOLC);
		}
		throw new ArgumentException("unknown object in factory: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC), "obj");
	}

	public override EDOEBJJFOBM IIHKEACDNID()
	{
		return new JIHIOOKBBLB(false, NBFBPNNEKMN, IOCMOCCFALN);
	}

	public override string ToString()
	{
		string iAHDCIONPPF = LHFGHNFJIKM.IAHDCIONPPF;
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("DistributionPointName: [");
		stringBuilder.Append(iAHDCIONPPF);
		if (NBFBPNNEKMN == 0)
		{
			NBOHCFMFHOG(stringBuilder, iAHDCIONPPF, "fullName", IOCMOCCFALN.ToString());
		}
		else
		{
			NBOHCFMFHOG(stringBuilder, iAHDCIONPPF, "nameRelativeToCRLIssuer", IOCMOCCFALN.ToString());
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
