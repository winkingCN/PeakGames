using System;
using System.Collections;
using System.IO;

public class AKBAHAJEILE : KKHDKCFMKNN
{
	protected EKFAMINKCJP PJMPLLIKCCG;

	protected int[] AJMLOOJHBBO;

	protected byte[] HLPGDFLIDKC;

	protected byte[] OEOBANOOGDJ;

	protected COEMJAGOFJJ CAACNJEGLIP;

	protected KLOLEKONHBE DPBONCANGGJ;

	protected EKGPBAENHIF GCHEOMCMMIF;

	protected EGEBOHHBFLK DNEOPOFKIEF;

	public override bool GPEPNOJIMAB
	{
		get
		{
			switch (MOCPBMMDBBD)
			{
			case 17:
			case 19:
			case 20:
				return true;
			default:
				return false;
			}
		}
	}

	public AKBAHAJEILE(int EBOOFBMGNDI, IList GMLLEBDADDP, int[] KJAHHLKPNIN, byte[] PFFOEKELMAF, byte[] IJDNPGHLBID)
		: base(EBOOFBMGNDI, GMLLEBDADDP)
	{
		switch (EBOOFBMGNDI)
		{
		case 19:
			PJMPLLIKCCG = new MIKBJEJODHC();
			break;
		case 17:
			PJMPLLIKCCG = new LKIBBJMDILG();
			break;
		case 16:
		case 18:
		case 20:
			PJMPLLIKCCG = null;
			break;
		default:
			throw new InvalidOperationException("unsupported key exchange algorithm");
		}
		AJMLOOJHBBO = KJAHHLKPNIN;
		HLPGDFLIDKC = PFFOEKELMAF;
		OEOBANOOGDJ = IJDNPGHLBID;
	}

	public override void DIOELAHNLKJ(CGDEGBGOKJO MBEMNOCDDBC)
	{
		base.DIOELAHNLKJ(MBEMNOCDDBC);
		if (PJMPLLIKCCG != null)
		{
			PJMPLLIKCCG.DIOELAHNLKJ(MBEMNOCDDBC);
		}
	}

	public override void PHFBGHEJBHM()
	{
		if (MOCPBMMDBBD != 20)
		{
			throw new DEIDBCPPCMB(10);
		}
	}

	public override void BGLKKBMEEEK(PAJJBHMEFKE EIMEPDCAJLE)
	{
		if (MOCPBMMDBBD == 20)
		{
			throw new DEIDBCPPCMB(10);
		}
		if (EIMEPDCAJLE.DHIKCKFGKID)
		{
			throw new DEIDBCPPCMB(42);
		}
		NGNPCPDMGBC nGNPCPDMGBC = EIMEPDCAJLE.IGGCPKOFOMP(0);
		MHBCFNELGOJ mJHHKCCPFEE = nGNPCPDMGBC.KBGJHCMPCGH;
		try
		{
			CAACNJEGLIP = JHGHHFDFJEG.HCBKCKKDGCP(mJHHKCCPFEE);
		}
		catch (Exception cEDNDOAMNOC)
		{
			throw new DEIDBCPPCMB(43, cEDNDOAMNOC);
		}
		if (PJMPLLIKCCG == null)
		{
			try
			{
				DNEOPOFKIEF = NKCEMDBADJF.LKAJBJKHDNC((EGEBOHHBFLK)CAACNJEGLIP);
			}
			catch (InvalidCastException cEDNDOAMNOC2)
			{
				throw new DEIDBCPPCMB(46, cEDNDOAMNOC2);
			}
			KINEBFNENMB.EPMGOMGGBIE(nGNPCPDMGBC, 8);
		}
		else
		{
			if (!PJMPLLIKCCG.GNODDNDEEMI(CAACNJEGLIP))
			{
				throw new DEIDBCPPCMB(46);
			}
			KINEBFNENMB.EPMGOMGGBIE(nGNPCPDMGBC, 128);
		}
		base.BGLKKBMEEEK(EIMEPDCAJLE);
	}

	public override byte[] DMJCNEDKPEA()
	{
		if (!GPEPNOJIMAB)
		{
			return null;
		}
		MemoryStream memoryStream = new MemoryStream();
		GCHEOMCMMIF = NKCEMDBADJF.KGOGEEJBEBL(COOBIGONLDK.KMLKPFPCFLA, AJMLOOJHBBO, HLPGDFLIDKC, memoryStream);
		return memoryStream.ToArray();
	}

	public override void OJGCPPFDPBN(Stream MOPCLEEGDFB)
	{
		if (!GPEPNOJIMAB)
		{
			throw new DEIDBCPPCMB(10);
		}
		MJDENGGDLMJ pGMJCMEMKIE = NKCEMDBADJF.BIENEPAPMJN(AJMLOOJHBBO, HLPGDFLIDKC, MOPCLEEGDFB);
		byte[] nJPMJNHGDNE = KINEBFNENMB.IEIMBOADGLL(MOPCLEEGDFB);
		DNEOPOFKIEF = NKCEMDBADJF.LKAJBJKHDNC(NKCEMDBADJF.CLFHBFJPMGE(HLPGDFLIDKC, pGMJCMEMKIE, nJPMJNHGDNE));
	}

	public override void JNMIHCPINHE(OOKLBMMBONO FJLPCHOBGAM)
	{
		byte[] array = FJLPCHOBGAM.JBMMCGPHNBP;
		for (int i = 0; i < array.Length; i++)
		{
			switch (array[i])
			{
			case 1:
			case 2:
			case 64:
			case 65:
			case 66:
				continue;
			}
			throw new DEIDBCPPCMB(47);
		}
	}

	public override void FBGFHDOCEOO(OPCLIKBOHJP CLBMIAJGDMO)
	{
		if (MOCPBMMDBBD == 20)
		{
			throw new DEIDBCPPCMB(80);
		}
		if (CLBMIAJGDMO is KLOLEKONHBE)
		{
			DPBONCANGGJ = (KLOLEKONHBE)CLBMIAJGDMO;
		}
		else if (!(CLBMIAJGDMO is IAJODODPMMG))
		{
			throw new DEIDBCPPCMB(80);
		}
	}

	public override void BAILJOPLLNN(Stream BILGCJNPJGJ)
	{
		if (DPBONCANGGJ == null)
		{
			GCHEOMCMMIF = NKCEMDBADJF.MAJEAJCJMKA(COOBIGONLDK.KMLKPFPCFLA, OEOBANOOGDJ, DNEOPOFKIEF.KPJHHAAOFOH, BILGCJNPJGJ);
		}
	}

	public override void KHJELAAEAPK(PAJJBHMEFKE HDJIOCGDIKM)
	{
		if (MOCPBMMDBBD == 20)
		{
			throw new DEIDBCPPCMB(10);
		}
	}

	public override void DHMEHGEGGCB(Stream MOPCLEEGDFB)
	{
		if (DNEOPOFKIEF == null)
		{
			byte[] nJPMJNHGDNE = KINEBFNENMB.IEIMBOADGLL(MOPCLEEGDFB);
			MJDENGGDLMJ pGMJCMEMKIE = GCHEOMCMMIF.KPJHHAAOFOH;
			DNEOPOFKIEF = NKCEMDBADJF.LKAJBJKHDNC(NKCEMDBADJF.CLFHBFJPMGE(OEOBANOOGDJ, pGMJCMEMKIE, nJPMJNHGDNE));
		}
	}

	public override byte[] CGMFKLNEDAP()
	{
		if (DPBONCANGGJ != null)
		{
			return DPBONCANGGJ.LEMDLODGMFN(DNEOPOFKIEF);
		}
		if (GCHEOMCMMIF != null)
		{
			return NKCEMDBADJF.JCCNGIECHGJ(DNEOPOFKIEF, GCHEOMCMMIF);
		}
		throw new DEIDBCPPCMB(80);
	}
}
