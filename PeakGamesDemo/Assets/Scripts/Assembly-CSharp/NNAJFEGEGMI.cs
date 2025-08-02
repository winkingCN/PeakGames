using System;
using Org.BouncyCastle.Math;

internal class NNAJFEGEGMI
{
	private static readonly BigInteger BEMMNBKIJHG = BigInteger.One.BHKOFHMDACN();

	private static readonly BigInteger EODLDGELENL = BigInteger.Two.BHKOFHMDACN();

	private static readonly BigInteger DHPPHMCCJAE = BigInteger.Three.BHKOFHMDACN();

	private static readonly BigInteger KOCFKICEECI = BigInteger.AGLOJCOAJIK(4L);

	public const sbyte EMFKAPJMDCC = 4;

	public const sbyte NOGHGAGCNIH = 16;

	public static readonly CNFFFHILNNA[] BNMKGLHKIKK = new CNFFFHILNNA[9]
	{
		null,
		new CNFFFHILNNA(BigInteger.One, BigInteger.Zero),
		null,
		new CNFFFHILNNA(DHPPHMCCJAE, BEMMNBKIJHG),
		null,
		new CNFFFHILNNA(BEMMNBKIJHG, BEMMNBKIJHG),
		null,
		new CNFFFHILNNA(BigInteger.One, BEMMNBKIJHG),
		null
	};

	public static readonly sbyte[][] BLKHJALFAOI = new sbyte[8][]
	{
		null,
		new sbyte[1] { 1 },
		null,
		new sbyte[3] { -1, 0, 1 },
		null,
		new sbyte[3] { 1, 0, 1 },
		null,
		new sbyte[4] { -1, 0, 0, 1 }
	};

	public static readonly CNFFFHILNNA[] PHCIMMNBODL = new CNFFFHILNNA[9]
	{
		null,
		new CNFFFHILNNA(BigInteger.One, BigInteger.Zero),
		null,
		new CNFFFHILNNA(DHPPHMCCJAE, BigInteger.One),
		null,
		new CNFFFHILNNA(BEMMNBKIJHG, BigInteger.One),
		null,
		new CNFFFHILNNA(BigInteger.One, BigInteger.One),
		null
	};

	public static readonly sbyte[][] MCLKKADJGDK = new sbyte[8][]
	{
		null,
		new sbyte[1] { 1 },
		null,
		new sbyte[3] { -1, 0, 1 },
		null,
		new sbyte[3] { 1, 0, 1 },
		null,
		new sbyte[4] { -1, 0, 0, -1 }
	};

	public static BigInteger DFLDIFBHJJE(sbyte PPFMEPBJCJC, CNFFFHILNNA ILPILGOPJLI)
	{
		BigInteger bigInteger = ILPILGOPJLI.OJOAGEHFPNP.IBJBIGNPNEM(ILPILGOPJLI.OJOAGEHFPNP);
		BigInteger bigInteger2 = ILPILGOPJLI.OJOAGEHFPNP.IBJBIGNPNEM(ILPILGOPJLI.AAIEJDNAODP);
		BigInteger eDDNOJDPMCF = ILPILGOPJLI.AAIEJDNAODP.IBJBIGNPNEM(ILPILGOPJLI.AAIEJDNAODP).DOKHFLENGLF(1);
		if (PPFMEPBJCJC == 1)
		{
			return bigInteger.JEACJNAKLDJ(bigInteger2).JEACJNAKLDJ(eDDNOJDPMCF);
		}
		if (PPFMEPBJCJC == -1)
		{
			return bigInteger.FBGIHKPECCO(bigInteger2).JEACJNAKLDJ(eDDNOJDPMCF);
		}
		throw new ArgumentException("mu must be 1 or -1");
	}

	public static LADEDLPFBFM DFLDIFBHJJE(sbyte PPFMEPBJCJC, LADEDLPFBFM OJOAGEHFPNP, LADEDLPFBFM AAIEJDNAODP)
	{
		LADEDLPFBFM lADEDLPFBFM = OJOAGEHFPNP.IBJBIGNPNEM(OJOAGEHFPNP);
		LADEDLPFBFM bCIHLCMFAEK = OJOAGEHFPNP.IBJBIGNPNEM(AAIEJDNAODP);
		LADEDLPFBFM bCIHLCMFAEK2 = AAIEJDNAODP.IBJBIGNPNEM(AAIEJDNAODP).DOKHFLENGLF(1);
		if (PPFMEPBJCJC == 1)
		{
			return lADEDLPFBFM.JEACJNAKLDJ(bCIHLCMFAEK).JEACJNAKLDJ(bCIHLCMFAEK2);
		}
		if (PPFMEPBJCJC == -1)
		{
			return lADEDLPFBFM.FBGIHKPECCO(bCIHLCMFAEK).JEACJNAKLDJ(bCIHLCMFAEK2);
		}
		throw new ArgumentException("mu must be 1 or -1");
	}

	public static CNFFFHILNNA PPNDEMOHHCH(LADEDLPFBFM IINGDIFOPBK, LADEDLPFBFM OOCAGELGLEE, sbyte PPFMEPBJCJC)
	{
		int num = IINGDIFOPBK.GEBNMKAGJIG;
		if (OOCAGELGLEE.GEBNMKAGJIG != num)
		{
			throw new ArgumentException("lambda0 and lambda1 do not have same scale");
		}
		if (PPFMEPBJCJC != 1 && PPFMEPBJCJC != -1)
		{
			throw new ArgumentException("mu must be 1 or -1");
		}
		BigInteger bigInteger = IINGDIFOPBK.PPNDEMOHHCH();
		BigInteger bigInteger2 = OOCAGELGLEE.PPNDEMOHHCH();
		LADEDLPFBFM lADEDLPFBFM = IINGDIFOPBK.FBGIHKPECCO(bigInteger);
		LADEDLPFBFM lADEDLPFBFM2 = OOCAGELGLEE.FBGIHKPECCO(bigInteger2);
		LADEDLPFBFM lADEDLPFBFM3 = lADEDLPFBFM.JEACJNAKLDJ(lADEDLPFBFM);
		lADEDLPFBFM3 = ((PPFMEPBJCJC != 1) ? lADEDLPFBFM3.FBGIHKPECCO(lADEDLPFBFM2) : lADEDLPFBFM3.JEACJNAKLDJ(lADEDLPFBFM2));
		LADEDLPFBFM lADEDLPFBFM4 = lADEDLPFBFM2.JEACJNAKLDJ(lADEDLPFBFM2).JEACJNAKLDJ(lADEDLPFBFM2);
		LADEDLPFBFM bCIHLCMFAEK = lADEDLPFBFM4.JEACJNAKLDJ(lADEDLPFBFM2);
		LADEDLPFBFM lADEDLPFBFM5;
		LADEDLPFBFM lADEDLPFBFM6;
		if (PPFMEPBJCJC == 1)
		{
			lADEDLPFBFM5 = lADEDLPFBFM.FBGIHKPECCO(lADEDLPFBFM4);
			lADEDLPFBFM6 = lADEDLPFBFM.JEACJNAKLDJ(bCIHLCMFAEK);
		}
		else
		{
			lADEDLPFBFM5 = lADEDLPFBFM.JEACJNAKLDJ(lADEDLPFBFM4);
			lADEDLPFBFM6 = lADEDLPFBFM.FBGIHKPECCO(bCIHLCMFAEK);
		}
		sbyte b = 0;
		sbyte b2 = 0;
		if (lADEDLPFBFM3.JLPDKNFCNPO(BigInteger.One) >= 0)
		{
			if (lADEDLPFBFM5.JLPDKNFCNPO(BEMMNBKIJHG) < 0)
			{
				b2 = PPFMEPBJCJC;
			}
			else
			{
				b = 1;
			}
		}
		else if (lADEDLPFBFM6.JLPDKNFCNPO(BigInteger.Two) >= 0)
		{
			b2 = PPFMEPBJCJC;
		}
		if (lADEDLPFBFM3.JLPDKNFCNPO(BEMMNBKIJHG) < 0)
		{
			if (lADEDLPFBFM5.JLPDKNFCNPO(BigInteger.One) >= 0)
			{
				b2 = (sbyte)(-PPFMEPBJCJC);
			}
			else
			{
				b = -1;
			}
		}
		else if (lADEDLPFBFM6.JLPDKNFCNPO(EODLDGELENL) < 0)
		{
			b2 = (sbyte)(-PPFMEPBJCJC);
		}
		BigInteger oJOAGEHFPNP = bigInteger.JEACJNAKLDJ(BigInteger.AGLOJCOAJIK(b));
		BigInteger aAIEJDNAODP = bigInteger2.JEACJNAKLDJ(BigInteger.AGLOJCOAJIK(b2));
		return new CNFFFHILNNA(oJOAGEHFPNP, aAIEJDNAODP);
	}

	public static LADEDLPFBFM NOJCFEPEKKL(BigInteger BENKLGPHLGI, BigInteger IBBBMACIBGK, BigInteger NGHNDOOFCFA, sbyte MNIMEAMHNMI, int CEKMAJAHNAG, int FMFABAKPMLB)
	{
		int num = (CEKMAJAHNAG + 5) / 2 + FMFABAKPMLB;
		BigInteger hIMINGHNIKN = BENKLGPHLGI.ABOIOKBIANB(CEKMAJAHNAG - num - 2 + MNIMEAMHNMI);
		BigInteger bigInteger = IBBBMACIBGK.IBJBIGNPNEM(hIMINGHNIKN);
		BigInteger hIMINGHNIKN2 = bigInteger.ABOIOKBIANB(CEKMAJAHNAG);
		BigInteger eDDNOJDPMCF = NGHNDOOFCFA.IBJBIGNPNEM(hIMINGHNIKN2);
		BigInteger bigInteger2 = bigInteger.JEACJNAKLDJ(eDDNOJDPMCF);
		BigInteger bigInteger3 = bigInteger2.ABOIOKBIANB(num - FMFABAKPMLB);
		if (bigInteger2.NJHNJHGDCIJ(num - FMFABAKPMLB - 1))
		{
			bigInteger3 = bigInteger3.JEACJNAKLDJ(BigInteger.One);
		}
		return new LADEDLPFBFM(bigInteger3, FMFABAKPMLB);
	}

	public static sbyte[] GIMPMIODIDD(sbyte PPFMEPBJCJC, CNFFFHILNNA ILPILGOPJLI)
	{
		if (PPFMEPBJCJC != 1 && PPFMEPBJCJC != -1)
		{
			throw new ArgumentException("mu must be 1 or -1");
		}
		BigInteger bigInteger = DFLDIFBHJJE(PPFMEPBJCJC, ILPILGOPJLI);
		int bitLength = bigInteger.BitLength;
		int num = ((bitLength <= 30) ? 34 : (bitLength + 4));
		sbyte[] array = new sbyte[num];
		int num2 = 0;
		int num3 = 0;
		BigInteger bigInteger2 = ILPILGOPJLI.OJOAGEHFPNP;
		BigInteger bigInteger3 = ILPILGOPJLI.AAIEJDNAODP;
		while (!bigInteger2.Equals(BigInteger.Zero) || !bigInteger3.Equals(BigInteger.Zero))
		{
			if (bigInteger2.NJHNJHGDCIJ(0))
			{
				array[num2] = (sbyte)BigInteger.Two.FBGIHKPECCO(bigInteger2.FBGIHKPECCO(bigInteger3.DOKHFLENGLF(1)).MODIHOCEKBK(KOCFKICEECI)).IntValue;
				bigInteger2 = ((array[num2] != 1) ? bigInteger2.JEACJNAKLDJ(BigInteger.One) : bigInteger2.FKDNNOLIGPH(0));
				num3 = num2;
			}
			else
			{
				array[num2] = 0;
			}
			BigInteger bigInteger4 = bigInteger2;
			BigInteger bigInteger5 = bigInteger2.ABOIOKBIANB(1);
			bigInteger2 = ((PPFMEPBJCJC != 1) ? bigInteger3.FBGIHKPECCO(bigInteger5) : bigInteger3.JEACJNAKLDJ(bigInteger5));
			bigInteger3 = bigInteger4.ABOIOKBIANB(1).BHKOFHMDACN();
			num2++;
		}
		num3++;
		sbyte[] array2 = new sbyte[num3];
		Array.Copy(array, 0, array2, 0, num3);
		return array2;
	}

	public static EJLHHPBLEMF MHEOOOAHMCC(EJLHHPBLEMF HPHBDNBJPHB)
	{
		return HPHBDNBJPHB.MHEOOOAHMCC();
	}

	public static sbyte GFBKMOHINEI(DJABAMMOHPF NINILENHPHE)
	{
		BigInteger bigInteger = NINILENHPHE.JEHECJGFJEB.DOJBPIFPALJ();
		if (bigInteger.SignValue == 0)
		{
			return -1;
		}
		if (bigInteger.Equals(BigInteger.One))
		{
			return 1;
		}
		throw new ArgumentException("No Koblitz curve (ABC), TNAF multiplication not possible");
	}

	public static sbyte GFBKMOHINEI(KBINBLGGLNE LCCNNAFONOC)
	{
		return (sbyte)((!LCCNNAFONOC.EJJHHCOFAAI) ? 1 : (-1));
	}

	public static sbyte GFBKMOHINEI(int LCCNNAFONOC)
	{
		return (sbyte)((LCCNNAFONOC != 0) ? 1 : (-1));
	}

	public static BigInteger[] JOGHEACCEPA(sbyte PPFMEPBJCJC, int BENKLGPHLGI, bool JBEPHBJKMFG)
	{
		if (PPFMEPBJCJC != 1 && PPFMEPBJCJC != -1)
		{
			throw new ArgumentException("mu must be 1 or -1");
		}
		BigInteger bigInteger;
		BigInteger bigInteger2;
		if (JBEPHBJKMFG)
		{
			bigInteger = BigInteger.Two;
			bigInteger2 = BigInteger.AGLOJCOAJIK(PPFMEPBJCJC);
		}
		else
		{
			bigInteger = BigInteger.Zero;
			bigInteger2 = BigInteger.One;
		}
		for (int i = 1; i < BENKLGPHLGI; i++)
		{
			BigInteger bigInteger3 = null;
			bigInteger3 = ((PPFMEPBJCJC != 1) ? bigInteger2.BHKOFHMDACN() : bigInteger2);
			BigInteger bigInteger4 = bigInteger3.FBGIHKPECCO(bigInteger.DOKHFLENGLF(1));
			bigInteger = bigInteger2;
			bigInteger2 = bigInteger4;
		}
		return new BigInteger[2] { bigInteger, bigInteger2 };
	}

	public static BigInteger MCPAMPKHMCI(sbyte PPFMEPBJCJC, int PHFLBLJJMLI)
	{
		if (PHFLBLJJMLI == 4)
		{
			if (PPFMEPBJCJC == 1)
			{
				return BigInteger.AGLOJCOAJIK(6L);
			}
			return BigInteger.AGLOJCOAJIK(10L);
		}
		BigInteger[] array = JOGHEACCEPA(PPFMEPBJCJC, PHFLBLJJMLI, false);
		BigInteger cEKMAJAHNAG = BigInteger.Zero.KMDGKCFFPOP(PHFLBLJJMLI);
		BigInteger hIMINGHNIKN = array[1].DDENLEMHHAM(cEKMAJAHNAG);
		return BigInteger.Two.IBJBIGNPNEM(array[0]).IBJBIGNPNEM(hIMINGHNIKN).MODIHOCEKBK(cEKMAJAHNAG);
	}

	public static BigInteger[] GIFOICAMFFP(DJABAMMOHPF NINILENHPHE)
	{
		if (!NINILENHPHE.FNJONABMLNB)
		{
			throw new ArgumentException("si is defined for Koblitz curves only");
		}
		int num = NINILENHPHE.PJNLBAHOKGC;
		int intValue = NINILENHPHE.JEHECJGFJEB.DOJBPIFPALJ().IntValue;
		sbyte b = GFBKMOHINEI(intValue);
		int iDHLPOFDLKJ = IANIDMACNID(NINILENHPHE.PPPAFJOLKPD);
		int bENKLGPHLGI = num + 3 - intValue;
		BigInteger[] array = JOGHEACCEPA(b, bENKLGPHLGI, false);
		if (b == 1)
		{
			array[0] = array[0].BHKOFHMDACN();
			array[1] = array[1].BHKOFHMDACN();
		}
		BigInteger bigInteger = BigInteger.One.JEACJNAKLDJ(array[1]).ABOIOKBIANB(iDHLPOFDLKJ);
		BigInteger bigInteger2 = BigInteger.One.JEACJNAKLDJ(array[0]).ABOIOKBIANB(iDHLPOFDLKJ).BHKOFHMDACN();
		return new BigInteger[2] { bigInteger, bigInteger2 };
	}

	public static BigInteger[] GIFOICAMFFP(int GJDKDMFAABP, int LCCNNAFONOC, BigInteger GHOBJLLGPOE)
	{
		sbyte b = GFBKMOHINEI(LCCNNAFONOC);
		int iDHLPOFDLKJ = IANIDMACNID(GHOBJLLGPOE);
		int bENKLGPHLGI = GJDKDMFAABP + 3 - LCCNNAFONOC;
		BigInteger[] array = JOGHEACCEPA(b, bENKLGPHLGI, false);
		if (b == 1)
		{
			array[0] = array[0].BHKOFHMDACN();
			array[1] = array[1].BHKOFHMDACN();
		}
		BigInteger bigInteger = BigInteger.One.JEACJNAKLDJ(array[1]).ABOIOKBIANB(iDHLPOFDLKJ);
		BigInteger bigInteger2 = BigInteger.One.JEACJNAKLDJ(array[0]).ABOIOKBIANB(iDHLPOFDLKJ).BHKOFHMDACN();
		return new BigInteger[2] { bigInteger, bigInteger2 };
	}

	protected static int IANIDMACNID(BigInteger GPJDJCGDJDC)
	{
		if (GPJDJCGDJDC != null && GPJDJCGDJDC.BitLength < 4)
		{
			switch (GPJDJCGDJDC.IntValue)
			{
			case 2:
				return 1;
			case 4:
				return 2;
			}
		}
		throw new ArgumentException("h (Cofactor) must be 2 or 4");
	}

	public static CNFFFHILNNA JICLJHPHGHI(BigInteger BENKLGPHLGI, int CEKMAJAHNAG, sbyte MNIMEAMHNMI, BigInteger[] IBBBMACIBGK, sbyte PPFMEPBJCJC, sbyte FMFABAKPMLB)
	{
		BigInteger bigInteger = ((PPFMEPBJCJC != 1) ? IBBBMACIBGK[0].FBGIHKPECCO(IBBBMACIBGK[1]) : IBBBMACIBGK[0].JEACJNAKLDJ(IBBBMACIBGK[1]));
		BigInteger[] array = JOGHEACCEPA(PPFMEPBJCJC, CEKMAJAHNAG, true);
		BigInteger nGHNDOOFCFA = array[1];
		LADEDLPFBFM iINGDIFOPBK = NOJCFEPEKKL(BENKLGPHLGI, IBBBMACIBGK[0], nGHNDOOFCFA, MNIMEAMHNMI, CEKMAJAHNAG, FMFABAKPMLB);
		LADEDLPFBFM oOCAGELGLEE = NOJCFEPEKKL(BENKLGPHLGI, IBBBMACIBGK[1], nGHNDOOFCFA, MNIMEAMHNMI, CEKMAJAHNAG, FMFABAKPMLB);
		CNFFFHILNNA cNFFFHILNNA = PPNDEMOHHCH(iINGDIFOPBK, oOCAGELGLEE, PPFMEPBJCJC);
		BigInteger oJOAGEHFPNP = BENKLGPHLGI.FBGIHKPECCO(bigInteger.IBJBIGNPNEM(cNFFFHILNNA.OJOAGEHFPNP)).FBGIHKPECCO(BigInteger.AGLOJCOAJIK(2L).IBJBIGNPNEM(IBBBMACIBGK[1]).IBJBIGNPNEM(cNFFFHILNNA.AAIEJDNAODP));
		BigInteger aAIEJDNAODP = IBBBMACIBGK[1].IBJBIGNPNEM(cNFFFHILNNA.OJOAGEHFPNP).FBGIHKPECCO(IBBBMACIBGK[0].IBJBIGNPNEM(cNFFFHILNNA.AAIEJDNAODP));
		return new CNFFFHILNNA(oJOAGEHFPNP, aAIEJDNAODP);
	}

	public static EJLHHPBLEMF NFGLKAONIGA(EJLHHPBLEMF HPHBDNBJPHB, BigInteger BENKLGPHLGI)
	{
		DJABAMMOHPF dJABAMMOHPF = (DJABAMMOHPF)HPHBDNBJPHB.ECFGFKNLLGH;
		int cEKMAJAHNAG = dJABAMMOHPF.PJNLBAHOKGC;
		int intValue = dJABAMMOHPF.JEHECJGFJEB.DOJBPIFPALJ().IntValue;
		sbyte pPFMEPBJCJC = GFBKMOHINEI(intValue);
		BigInteger[] iBBBMACIBGK = dJABAMMOHPF.GIFOICAMFFP();
		CNFFFHILNNA iLPILGOPJLI = JICLJHPHGHI(BENKLGPHLGI, cEKMAJAHNAG, (sbyte)intValue, iBBBMACIBGK, pPFMEPBJCJC, 10);
		return ADCIFNAPGEF(HPHBDNBJPHB, iLPILGOPJLI);
	}

	public static EJLHHPBLEMF ADCIFNAPGEF(EJLHHPBLEMF HPHBDNBJPHB, CNFFFHILNNA ILPILGOPJLI)
	{
		DJABAMMOHPF dJABAMMOHPF = (DJABAMMOHPF)HPHBDNBJPHB.ECFGFKNLLGH;
		sbyte pPFMEPBJCJC = GFBKMOHINEI(dJABAMMOHPF.JEHECJGFJEB);
		sbyte[] oJOAGEHFPNP = GIMPMIODIDD(pPFMEPBJCJC, ILPILGOPJLI);
		return FKFOBDINPFP(HPHBDNBJPHB, oJOAGEHFPNP);
	}

	public static EJLHHPBLEMF FKFOBDINPFP(EJLHHPBLEMF HPHBDNBJPHB, sbyte[] OJOAGEHFPNP)
	{
		BHPIABAGAPB bHPIABAGAPB = HPHBDNBJPHB.ECFGFKNLLGH;
		EJLHHPBLEMF eJLHHPBLEMF = (EJLHHPBLEMF)bHPIABAGAPB.EFOLNCNGADB;
		EJLHHPBLEMF eJLHHPBLEMF2 = (EJLHHPBLEMF)HPHBDNBJPHB.BHKOFHMDACN();
		int num = 0;
		for (int num2 = OJOAGEHFPNP.Length - 1; num2 >= 0; num2--)
		{
			num++;
			sbyte b = OJOAGEHFPNP[num2];
			if (b != 0)
			{
				eJLHHPBLEMF = eJLHHPBLEMF.HHBAGDLPLMK(num);
				num = 0;
				JGAFKLGGBGF bCIHLCMFAEK = ((b <= 0) ? eJLHHPBLEMF2 : HPHBDNBJPHB);
				eJLHHPBLEMF = (EJLHHPBLEMF)eJLHHPBLEMF.JEACJNAKLDJ(bCIHLCMFAEK);
			}
		}
		if (num > 0)
		{
			eJLHHPBLEMF = eJLHHPBLEMF.HHBAGDLPLMK(num);
		}
		return eJLHHPBLEMF;
	}

	public static sbyte[] IHFIFLFJGEK(sbyte PPFMEPBJCJC, CNFFFHILNNA ILPILGOPJLI, sbyte HHHMOGOKFHF, BigInteger CHPFGBJOGBH, BigInteger OFODBIAOKEP, CNFFFHILNNA[] KBKMPEOMABI)
	{
		if (PPFMEPBJCJC != 1 && PPFMEPBJCJC != -1)
		{
			throw new ArgumentException("mu must be 1 or -1");
		}
		BigInteger bigInteger = DFLDIFBHJJE(PPFMEPBJCJC, ILPILGOPJLI);
		int bitLength = bigInteger.BitLength;
		int num = ((bitLength <= 30) ? (34 + HHHMOGOKFHF) : (bitLength + 4 + HHHMOGOKFHF));
		sbyte[] array = new sbyte[num];
		BigInteger eDDNOJDPMCF = CHPFGBJOGBH.ABOIOKBIANB(1);
		BigInteger bigInteger2 = ILPILGOPJLI.OJOAGEHFPNP;
		BigInteger bigInteger3 = ILPILGOPJLI.AAIEJDNAODP;
		int num2 = 0;
		while (!bigInteger2.Equals(BigInteger.Zero) || !bigInteger3.Equals(BigInteger.Zero))
		{
			if (bigInteger2.NJHNJHGDCIJ(0))
			{
				BigInteger bigInteger4 = bigInteger2.JEACJNAKLDJ(bigInteger3.IBJBIGNPNEM(OFODBIAOKEP)).MODIHOCEKBK(CHPFGBJOGBH);
				sbyte b = (array[num2] = ((bigInteger4.JLPDKNFCNPO(eDDNOJDPMCF) < 0) ? ((sbyte)bigInteger4.IntValue) : ((sbyte)bigInteger4.FBGIHKPECCO(CHPFGBJOGBH).IntValue)));
				bool flag = true;
				if (b < 0)
				{
					flag = false;
					b = (sbyte)(-b);
				}
				if (flag)
				{
					bigInteger2 = bigInteger2.FBGIHKPECCO(KBKMPEOMABI[b].OJOAGEHFPNP);
					bigInteger3 = bigInteger3.FBGIHKPECCO(KBKMPEOMABI[b].AAIEJDNAODP);
				}
				else
				{
					bigInteger2 = bigInteger2.JEACJNAKLDJ(KBKMPEOMABI[b].OJOAGEHFPNP);
					bigInteger3 = bigInteger3.JEACJNAKLDJ(KBKMPEOMABI[b].AAIEJDNAODP);
				}
			}
			else
			{
				array[num2] = 0;
			}
			BigInteger bigInteger5 = bigInteger2;
			bigInteger2 = ((PPFMEPBJCJC != 1) ? bigInteger3.FBGIHKPECCO(bigInteger2.ABOIOKBIANB(1)) : bigInteger3.JEACJNAKLDJ(bigInteger2.ABOIOKBIANB(1)));
			bigInteger3 = bigInteger5.ABOIOKBIANB(1).BHKOFHMDACN();
			num2++;
		}
		return array;
	}

	public static EJLHHPBLEMF[] GACNJDOFGMG(EJLHHPBLEMF HPHBDNBJPHB, sbyte MNIMEAMHNMI)
	{
		sbyte[][] array = ((MNIMEAMHNMI != 0) ? MCLKKADJGDK : BLKHJALFAOI);
		EJLHHPBLEMF[] array2 = new EJLHHPBLEMF[(uint)(array.Length + 1) >> 1];
		array2[0] = HPHBDNBJPHB;
		uint num = (uint)array.Length;
		for (uint num2 = 3u; num2 < num; num2 += 2)
		{
			array2[num2 >> 1] = FKFOBDINPFP(HPHBDNBJPHB, array[num2]);
		}
		HPHBDNBJPHB.ECFGFKNLLGH.NPDHPEDPAPA(array2);
		return array2;
	}
}
