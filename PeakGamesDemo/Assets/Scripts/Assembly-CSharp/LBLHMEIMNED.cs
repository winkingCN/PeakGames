using System;
using System.Text;

public class LBLHMEIMNED : LNKPCJLANAO
{
	private readonly CMOHOCOIBFO JENEJHNGGMC;

	private readonly bool NPMAMHPFDEB;

	private readonly bool MDPLFNHBLNN;

	private readonly NMBHFHPOABK NDOEHNBMICI;

	private readonly bool HCFNPFJJNFH;

	private readonly bool MLGNIGMLNDN;

	private readonly ALLINHNNNJN MIABODPHOIP;

	public bool GLGPIONHHNG
	{
		get
		{
			return NPMAMHPFDEB;
		}
	}

	public bool HOAMECCFGDI
	{
		get
		{
			return MDPLFNHBLNN;
		}
	}

	public bool KBKDMCLPFBJ
	{
		get
		{
			return HCFNPFJJNFH;
		}
	}

	public bool LJDHLBPOBFJ
	{
		get
		{
			return MLGNIGMLNDN;
		}
	}

	public CMOHOCOIBFO HPNAINFJKLJ
	{
		get
		{
			return JENEJHNGGMC;
		}
	}

	public NMBHFHPOABK NMPLBKMJKBP
	{
		get
		{
			return NDOEHNBMICI;
		}
	}

	public LBLHMEIMNED(CMOHOCOIBFO OONFAIPMMDI, bool GMFJOMDNBGD, bool JLMOMMDNEED, NMBHFHPOABK MNLNMCNCMMN, bool LPJLEFKJHEG, bool MKCHIIMJDNL)
	{
		JENEJHNGGMC = OONFAIPMMDI;
		HCFNPFJJNFH = LPJLEFKJHEG;
		MLGNIGMLNDN = MKCHIIMJDNL;
		MDPLFNHBLNN = JLMOMMDNEED;
		NPMAMHPFDEB = GMFJOMDNBGD;
		NDOEHNBMICI = MNLNMCNCMMN;
		DLDBGGDLOOO dLDBGGDLOOO = new DLDBGGDLOOO();
		if (OONFAIPMMDI != null)
		{
			dLDBGGDLOOO.JEACJNAKLDJ(new JIHIOOKBBLB(true, 0, OONFAIPMMDI));
		}
		if (GMFJOMDNBGD)
		{
			dLDBGGDLOOO.JEACJNAKLDJ(new JIHIOOKBBLB(false, 1, PNKAJJJPEPA.OKKOIIMLJOM));
		}
		if (JLMOMMDNEED)
		{
			dLDBGGDLOOO.JEACJNAKLDJ(new JIHIOOKBBLB(false, 2, PNKAJJJPEPA.OKKOIIMLJOM));
		}
		if (MNLNMCNCMMN != null)
		{
			dLDBGGDLOOO.JEACJNAKLDJ(new JIHIOOKBBLB(false, 3, MNLNMCNCMMN));
		}
		if (LPJLEFKJHEG)
		{
			dLDBGGDLOOO.JEACJNAKLDJ(new JIHIOOKBBLB(false, 4, PNKAJJJPEPA.OKKOIIMLJOM));
		}
		if (MKCHIIMJDNL)
		{
			dLDBGGDLOOO.JEACJNAKLDJ(new JIHIOOKBBLB(false, 5, PNKAJJJPEPA.OKKOIIMLJOM));
		}
		MIABODPHOIP = new KOGPLMALOEH(dLDBGGDLOOO);
	}

	private LBLHMEIMNED(ALLINHNNNJN MIABODPHOIP)
	{
		this.MIABODPHOIP = MIABODPHOIP;
		for (int i = 0; i != MIABODPHOIP.GMCGMPEEHJP; i++)
		{
			PAANMJLACEF pAANMJLACEF = PAANMJLACEF.BJLJCGFMFOO(MIABODPHOIP.ECNCPJGHBIG(i));
			switch (pAANMJLACEF.JPBIKBDCEKC)
			{
			case 0:
				JENEJHNGGMC = CMOHOCOIBFO.BJLJCGFMFOO(pAANMJLACEF, true);
				break;
			case 1:
				NPMAMHPFDEB = PNKAJJJPEPA.BJLJCGFMFOO(pAANMJLACEF, false).ELAOLKPILED;
				break;
			case 2:
				MDPLFNHBLNN = PNKAJJJPEPA.BJLJCGFMFOO(pAANMJLACEF, false).ELAOLKPILED;
				break;
			case 3:
				NDOEHNBMICI = new NMBHFHPOABK(FJMKMKNJKOI.BJLJCGFMFOO(pAANMJLACEF, false));
				break;
			case 4:
				HCFNPFJJNFH = PNKAJJJPEPA.BJLJCGFMFOO(pAANMJLACEF, false).ELAOLKPILED;
				break;
			case 5:
				MLGNIGMLNDN = PNKAJJJPEPA.BJLJCGFMFOO(pAANMJLACEF, false).ELAOLKPILED;
				break;
			default:
				throw new ArgumentException("unknown tag in IssuingDistributionPoint");
			}
		}
	}

	public static LBLHMEIMNED BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DHGLJHFEJFL)
	{
		return BJLJCGFMFOO(ALLINHNNNJN.BJLJCGFMFOO(NEMEKIOEOLC, DHGLJHFEJFL));
	}

	public static LBLHMEIMNED BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is LBLHMEIMNED)
		{
			return (LBLHMEIMNED)NEMEKIOEOLC;
		}
		if (NEMEKIOEOLC is ALLINHNNNJN)
		{
			return new LBLHMEIMNED((ALLINHNNNJN)NEMEKIOEOLC);
		}
		throw new ArgumentException("unknown object in factory: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC), "obj");
	}

	public override EDOEBJJFOBM IIHKEACDNID()
	{
		return MIABODPHOIP;
	}

	public override string ToString()
	{
		string iAHDCIONPPF = LHFGHNFJIKM.IAHDCIONPPF;
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("IssuingDistributionPoint: [");
		stringBuilder.Append(iAHDCIONPPF);
		if (JENEJHNGGMC != null)
		{
			NBOHCFMFHOG(stringBuilder, iAHDCIONPPF, "distributionPoint", JENEJHNGGMC.ToString());
		}
		if (NPMAMHPFDEB)
		{
			NBOHCFMFHOG(stringBuilder, iAHDCIONPPF, "onlyContainsUserCerts", NPMAMHPFDEB.ToString());
		}
		if (MDPLFNHBLNN)
		{
			NBOHCFMFHOG(stringBuilder, iAHDCIONPPF, "onlyContainsCACerts", MDPLFNHBLNN.ToString());
		}
		if (NDOEHNBMICI != null)
		{
			NBOHCFMFHOG(stringBuilder, iAHDCIONPPF, "onlySomeReasons", NDOEHNBMICI.ToString());
		}
		if (MLGNIGMLNDN)
		{
			NBOHCFMFHOG(stringBuilder, iAHDCIONPPF, "onlyContainsAttributeCerts", MLGNIGMLNDN.ToString());
		}
		if (HCFNPFJJNFH)
		{
			NBOHCFMFHOG(stringBuilder, iAHDCIONPPF, "indirectCRL", HCFNPFJJNFH.ToString());
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
