using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Math;

public abstract class NKCEMDBADJF
{
	private static readonly string[] JKMLILMNIMM = new string[28]
	{
		"sect163k1", "sect163r1", "sect163r2", "sect193r1", "sect193r2", "sect233k1", "sect233r1", "sect239k1", "sect283k1", "sect283r1",
		"sect409k1", "sect409r1", "sect571k1", "sect571r1", "secp160k1", "secp160r1", "secp160r2", "secp192k1", "secp192r1", "secp224k1",
		"secp224r1", "secp256k1", "secp256r1", "secp384r1", "secp521r1", "brainpoolP256r1", "brainpoolP384r1", "brainpoolP512r1"
	};

	public static void DJHEKAPGBFL(IDictionary GPFBAMMMLIA, int[] KJAHHLKPNIN)
	{
		GPFBAMMMLIA[10] = OIKFMIAFPKG(KJAHHLKPNIN);
	}

	public static void JFCKEJADMLN(IDictionary GPFBAMMMLIA, byte[] MAHJBOHDFDJ)
	{
		GPFBAMMMLIA[11] = NEMPNGKJGIP(MAHJBOHDFDJ);
	}

	public static int[] DJICAEHEDOL(IDictionary GPFBAMMMLIA)
	{
		byte[] array = KINEBFNENMB.MHMMGPFEAJM(GPFBAMMMLIA, 10);
		return (array != null) ? KKNHEHDAHKB(array) : null;
	}

	public static byte[] PIINMMAGLHI(IDictionary GPFBAMMMLIA)
	{
		byte[] array = KINEBFNENMB.MHMMGPFEAJM(GPFBAMMMLIA, 11);
		return (array != null) ? HKDJPPMLHFF(array) : null;
	}

	public static byte[] OIKFMIAFPKG(int[] KJAHHLKPNIN)
	{
		if (KJAHHLKPNIN == null || KJAHHLKPNIN.Length < 1)
		{
			throw new DEIDBCPPCMB(80);
		}
		return KINEBFNENMB.FMONAEDILAB(KJAHHLKPNIN);
	}

	public static byte[] NEMPNGKJGIP(byte[] MAHJBOHDFDJ)
	{
		if (MAHJBOHDFDJ == null || !NOGCEBKPPJE.KMDACNACKII(MAHJBOHDFDJ, 0))
		{
			MAHJBOHDFDJ = NOGCEBKPPJE.GBKNDKCPBEH(MAHJBOHDFDJ, 0);
		}
		return KINEBFNENMB.CKGMDCDMKIJ(MAHJBOHDFDJ);
	}

	public static int[] KKNHEHDAHKB(byte[] NIHLDDGDKGP)
	{
		if (NIHLDDGDKGP == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		MemoryStream memoryStream = new MemoryStream(NIHLDDGDKGP, false);
		int num = KINEBFNENMB.DMHJEBHACNN(memoryStream);
		if (num < 2 || ((uint)num & (true ? 1u : 0u)) != 0)
		{
			throw new DEIDBCPPCMB(50);
		}
		int[] result = KINEBFNENMB.DNOEBHEJDPG(num / 2, memoryStream);
		HEMGBKNMOKB.JILHFDBGNGE(memoryStream);
		return result;
	}

	public static byte[] HKDJPPMLHFF(byte[] NIHLDDGDKGP)
	{
		if (NIHLDDGDKGP == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		MemoryStream memoryStream = new MemoryStream(NIHLDDGDKGP, false);
		byte b = KINEBFNENMB.HEEOKPLLJMG(memoryStream);
		if (b < 1)
		{
			throw new DEIDBCPPCMB(50);
		}
		byte[] array = KINEBFNENMB.HACGMELPFGO(b, memoryStream);
		HEMGBKNMOKB.JILHFDBGNGE(memoryStream);
		if (!NOGCEBKPPJE.KMDACNACKII(array, 0))
		{
			throw new DEIDBCPPCMB(47);
		}
		return array;
	}

	public static string EJEJDBACIJG(int NELJNGEPEFH)
	{
		return (!BFJCEOAGNNI(NELJNGEPEFH)) ? null : JKMLILMNIMM[NELJNGEPEFH - 1];
	}

	public static MJDENGGDLMJ PIIHJLCCMHE(int NELJNGEPEFH)
	{
		string text = EJEJDBACIJG(NELJNGEPEFH);
		if (text == null)
		{
			return null;
		}
		JMLDNPGFBDA jMLDNPGFBDA = FNGEMGAMEDA.KJOGHMPFOHL(text);
		if (jMLDNPGFBDA == null)
		{
			jMLDNPGFBDA = BBLDODBKNIN.KJOGHMPFOHL(text);
			if (jMLDNPGFBDA == null)
			{
				return null;
			}
		}
		return new MJDENGGDLMJ(jMLDNPGFBDA.ECFGFKNLLGH, jMLDNPGFBDA.HBGOKILMBJG, jMLDNPGFBDA.HNLMGJGNBDD, jMLDNPGFBDA.JGOHMOHEFMJ, jMLDNPGFBDA.GKBBKKNGJAK());
	}

	public static bool KPGLPFPHMJO()
	{
		return JKMLILMNIMM.Length > 0;
	}

	public static bool FAAOILCCCKB(int[] GKHIJGCCECN)
	{
		for (int i = 0; i < GKHIJGCCECN.Length; i++)
		{
			if (BIBJBEEPJMP(GKHIJGCCECN[i]))
			{
				return true;
			}
		}
		return false;
	}

	public static bool BIBJBEEPJMP(int DHDNFGLNBGJ)
	{
		switch (DHDNFGLNBGJ)
		{
		case 49153:
		case 49154:
		case 49155:
		case 49156:
		case 49157:
		case 49158:
		case 49159:
		case 49160:
		case 49161:
		case 49162:
		case 49163:
		case 49164:
		case 49165:
		case 49166:
		case 49167:
		case 49168:
		case 49169:
		case 49170:
		case 49171:
		case 49172:
		case 49173:
		case 49174:
		case 49175:
		case 49176:
		case 49177:
		case 49187:
		case 49188:
		case 49189:
		case 49190:
		case 49191:
		case 49192:
		case 49193:
		case 49194:
		case 49195:
		case 49196:
		case 49197:
		case 49198:
		case 49199:
		case 49200:
		case 49201:
		case 49202:
		case 49203:
		case 49204:
		case 49205:
		case 49206:
		case 49207:
		case 49208:
		case 49209:
		case 49210:
		case 49211:
		case 49266:
		case 49267:
		case 49268:
		case 49269:
		case 49270:
		case 49271:
		case 49272:
		case 49273:
		case 49286:
		case 49287:
		case 49288:
		case 49289:
		case 49290:
		case 49291:
		case 49292:
		case 49293:
		case 49306:
		case 49307:
		case 49324:
		case 49325:
		case 49326:
		case 49327:
		case 52392:
		case 52393:
		case 52396:
		case 65282:
		case 65283:
		case 65284:
		case 65285:
		case 65300:
		case 65301:
			return true;
		default:
			return false;
		}
	}

	public static bool BOKLAGPMPMK(MJDENGGDLMJ MNIMEAMHNMI, MJDENGGDLMJ BCIHLCMFAEK)
	{
		return MNIMEAMHNMI != null && MNIMEAMHNMI.Equals(BCIHLCMFAEK);
	}

	public static bool BFJCEOAGNNI(int NELJNGEPEFH)
	{
		return NELJNGEPEFH > 0 && NELJNGEPEFH <= JKMLILMNIMM.Length;
	}

	public static bool BJFEINKLMDD(byte[] MAHJBOHDFDJ, byte COPLNHEKMAK)
	{
		if (MAHJBOHDFDJ == null)
		{
			return false;
		}
		foreach (byte b in MAHJBOHDFDJ)
		{
			if (b == 0)
			{
				return false;
			}
			if (b == COPLNHEKMAK)
			{
				return true;
			}
		}
		return false;
	}

	public static byte[] DFDFICMPKDH(int GJDKDMFAABP, BigInteger AMFCENFNAJJ)
	{
		return ODBELJAHGIG.HOGKINKACAF((GJDKDMFAABP + 7) / 8, AMFCENFNAJJ);
	}

	public static byte[] FOHMIANCLHI(byte[] MAHJBOHDFDJ, JGAFKLGGBGF KJPPPBMDJKG)
	{
		BHPIABAGAPB fMFABAKPMLB = KJPPPBMDJKG.ECFGFKNLLGH;
		bool bDKLBMAKEIN = false;
		if (KHJLHEJBLOA.FNAAANIPFOP(fMFABAKPMLB))
		{
			bDKLBMAKEIN = BJFEINKLMDD(MAHJBOHDFDJ, 1);
		}
		else if (KHJLHEJBLOA.BDGICGJIGPF(fMFABAKPMLB))
		{
			bDKLBMAKEIN = BJFEINKLMDD(MAHJBOHDFDJ, 2);
		}
		return KJPPPBMDJKG.PPCPBIEGJKM(bDKLBMAKEIN);
	}

	public static byte[] IPDHKIMJBHN(byte[] MAHJBOHDFDJ, EGEBOHHBFLK ELCJANHBOJD)
	{
		return FOHMIANCLHI(MAHJBOHDFDJ, ELCJANHBOJD.FNPELDEHJKL);
	}

	public static BigInteger INILJKPEPBA(int GJDKDMFAABP, byte[] NJPMJNHGDNE)
	{
		int num = (GJDKDMFAABP + 7) / 8;
		if (NJPMJNHGDNE.Length != num)
		{
			throw new DEIDBCPPCMB(50);
		}
		return new BigInteger(1, NJPMJNHGDNE);
	}

	public static JGAFKLGGBGF KELEKEJNPHP(byte[] MAHJBOHDFDJ, BHPIABAGAPB NINILENHPHE, byte[] NJPMJNHGDNE)
	{
		if (NJPMJNHGDNE == null || NJPMJNHGDNE.Length < 1)
		{
			throw new DEIDBCPPCMB(47);
		}
		byte b;
		switch (NJPMJNHGDNE[0])
		{
		case 2:
		case 3:
			if (KHJLHEJBLOA.BDGICGJIGPF(NINILENHPHE))
			{
				b = 2;
				break;
			}
			if (KHJLHEJBLOA.FNAAANIPFOP(NINILENHPHE))
			{
				b = 1;
				break;
			}
			throw new DEIDBCPPCMB(47);
		case 4:
			b = 0;
			break;
		default:
			throw new DEIDBCPPCMB(47);
		}
		if (b != 0 && (MAHJBOHDFDJ == null || !NOGCEBKPPJE.KMDACNACKII(MAHJBOHDFDJ, b)))
		{
			throw new DEIDBCPPCMB(47);
		}
		return NINILENHPHE.BJBGPDHADCH(NJPMJNHGDNE);
	}

	public static EGEBOHHBFLK CLFHBFJPMGE(byte[] MAHJBOHDFDJ, MJDENGGDLMJ PGMJCMEMKIE, byte[] NJPMJNHGDNE)
	{
		try
		{
			JGAFKLGGBGF oKDPJHOEPBJ = KELEKEJNPHP(MAHJBOHDFDJ, PGMJCMEMKIE.ECFGFKNLLGH, NJPMJNHGDNE);
			return new EGEBOHHBFLK(oKDPJHOEPBJ, PGMJCMEMKIE);
		}
		catch (Exception cEDNDOAMNOC)
		{
			throw new DEIDBCPPCMB(47, cEDNDOAMNOC);
		}
	}

	public static byte[] JCCNGIECHGJ(EGEBOHHBFLK ECPKCNOAOAJ, EKGPBAENHIF JMNLHNOGILL)
	{
		LIMDDDMOCCB lIMDDDMOCCB = new LIMDDDMOCCB();
		lIMDDDMOCCB.DIOELAHNLKJ(JMNLHNOGILL);
		BigInteger iDHLPOFDLKJ = lIMDDDMOCCB.CFEKCGNAKCD(ECPKCNOAOAJ);
		return ODBELJAHGIG.HOGKINKACAF(lIMDDDMOCCB.BGGKNJOAMKN(), iDHLPOFDLKJ);
	}

	public static HOHJPJDGOLF AHIMDBEDBOJ(FBIJJFGLKMK GECCLOFELEC, MJDENGGDLMJ IEGAJCCPJLB)
	{
		JMLCKFLAGEF jMLCKFLAGEF = new JMLCKFLAGEF();
		jMLCKFLAGEF.DIOELAHNLKJ(new JDKCFKJJIHN(IEGAJCCPJLB, GECCLOFELEC));
		return jMLCKFLAGEF.LOFCKPBODIJ();
	}

	public static EKGPBAENHIF MAJEAJCJMKA(FBIJJFGLKMK GECCLOFELEC, byte[] MAHJBOHDFDJ, MJDENGGDLMJ IEGAJCCPJLB, Stream BILGCJNPJGJ)
	{
		HOHJPJDGOLF hOHJPJDGOLF = AHIMDBEDBOJ(GECCLOFELEC, IEGAJCCPJLB);
		EGEBOHHBFLK eGEBOHHBFLK = (EGEBOHHBFLK)hOHJPJDGOLF.OOOKGOFNBEG;
		DAHMDNHLIEM(MAHJBOHDFDJ, eGEBOHHBFLK.FNPELDEHJKL, BILGCJNPJGJ);
		return (EKGPBAENHIF)hOHJPJDGOLF.KIBEEKODFLC;
	}

	internal static EKGPBAENHIF KGOGEEJBEBL(FBIJJFGLKMK GECCLOFELEC, int[] KJAHHLKPNIN, byte[] MAHJBOHDFDJ, Stream BILGCJNPJGJ)
	{
		int num = -1;
		if (KJAHHLKPNIN == null)
		{
			num = 23;
		}
		else
		{
			foreach (int num2 in KJAHHLKPNIN)
			{
				if (GCEKOHNJPJE.NAFCDEECGEF(num2) && BFJCEOAGNNI(num2))
				{
					num = num2;
					break;
				}
			}
		}
		MJDENGGDLMJ mJDENGGDLMJ = null;
		if (num >= 0)
		{
			mJDENGGDLMJ = PIIHJLCCMHE(num);
		}
		else if (NOGCEBKPPJE.KMDACNACKII(KJAHHLKPNIN, 65281))
		{
			mJDENGGDLMJ = PIIHJLCCMHE(23);
		}
		else if (NOGCEBKPPJE.KMDACNACKII(KJAHHLKPNIN, 65282))
		{
			mJDENGGDLMJ = PIIHJLCCMHE(10);
		}
		if (mJDENGGDLMJ == null)
		{
			throw new DEIDBCPPCMB(80);
		}
		if (num < 0)
		{
			HDDLKMIFKCM(MAHJBOHDFDJ, mJDENGGDLMJ, BILGCJNPJGJ);
		}
		else
		{
			JKPBHADNBJB(num, BILGCJNPJGJ);
		}
		return MAJEAJCJMKA(GECCLOFELEC, MAHJBOHDFDJ, mJDENGGDLMJ, BILGCJNPJGJ);
	}

	public static EGEBOHHBFLK LKAJBJKHDNC(EGEBOHHBFLK IKNCPEPOKGJ)
	{
		return IKNCPEPOKGJ;
	}

	public static int OOLAHFAPNNA(int GJDKDMFAABP, Stream MOPCLEEGDFB)
	{
		BigInteger bigInteger = CGMDDFBKMPP(MOPCLEEGDFB);
		if (bigInteger.BitLength < 32)
		{
			int intValue = bigInteger.IntValue;
			if (intValue > 0 && intValue < GJDKDMFAABP)
			{
				return intValue;
			}
		}
		throw new DEIDBCPPCMB(47);
	}

	public static BigInteger FLEOLBBCCKB(int GJDKDMFAABP, Stream MOPCLEEGDFB)
	{
		return INILJKPEPBA(GJDKDMFAABP, KINEBFNENMB.IEIMBOADGLL(MOPCLEEGDFB));
	}

	public static BigInteger CGMDDFBKMPP(Stream MOPCLEEGDFB)
	{
		return new BigInteger(1, KINEBFNENMB.IEIMBOADGLL(MOPCLEEGDFB));
	}

	public static MJDENGGDLMJ BIENEPAPMJN(int[] KJAHHLKPNIN, byte[] MAHJBOHDFDJ, Stream MOPCLEEGDFB)
	{
		try
		{
			switch (KINEBFNENMB.HEEOKPLLJMG(MOPCLEEGDFB))
			{
			case 1:
			{
				CICIOBFDAEE(KJAHHLKPNIN, 65281);
				BigInteger bigInteger3 = CGMDDFBKMPP(MOPCLEEGDFB);
				BigInteger mNIMEAMHNMI2 = FLEOLBBCCKB(bigInteger3.BitLength, MOPCLEEGDFB);
				BigInteger bCIHLCMFAEK2 = FLEOLBBCCKB(bigInteger3.BitLength, MOPCLEEGDFB);
				byte[] nJPMJNHGDNE2 = KINEBFNENMB.IEIMBOADGLL(MOPCLEEGDFB);
				BigInteger bigInteger4 = CGMDDFBKMPP(MOPCLEEGDFB);
				BigInteger bigInteger5 = CGMDDFBKMPP(MOPCLEEGDFB);
				BHPIABAGAPB nINILENHPHE2 = new BMIMOOLAJAL(bigInteger3, mNIMEAMHNMI2, bCIHLCMFAEK2, bigInteger4, bigInteger5);
				JGAFKLGGBGF hJMBDGKAOBP2 = KELEKEJNPHP(MAHJBOHDFDJ, nINILENHPHE2, nJPMJNHGDNE2);
				return new MJDENGGDLMJ(nINILENHPHE2, hJMBDGKAOBP2, bigInteger4, bigInteger5);
			}
			case 2:
			{
				CICIOBFDAEE(KJAHHLKPNIN, 65282);
				int num = KINEBFNENMB.DMHJEBHACNN(MOPCLEEGDFB);
				byte b = KINEBFNENMB.HEEOKPLLJMG(MOPCLEEGDFB);
				if (!BMOOBOCDLGK.NAFCDEECGEF(b))
				{
					throw new DEIDBCPPCMB(47);
				}
				int num2 = OOLAHFAPNNA(num, MOPCLEEGDFB);
				int fKOBMEPIABG = -1;
				int kHNDCPCHOEM = -1;
				if (b == 2)
				{
					fKOBMEPIABG = OOLAHFAPNNA(num, MOPCLEEGDFB);
					kHNDCPCHOEM = OOLAHFAPNNA(num, MOPCLEEGDFB);
				}
				BigInteger mNIMEAMHNMI = FLEOLBBCCKB(num, MOPCLEEGDFB);
				BigInteger bCIHLCMFAEK = FLEOLBBCCKB(num, MOPCLEEGDFB);
				byte[] nJPMJNHGDNE = KINEBFNENMB.IEIMBOADGLL(MOPCLEEGDFB);
				BigInteger bigInteger = CGMDDFBKMPP(MOPCLEEGDFB);
				BigInteger bigInteger2 = CGMDDFBKMPP(MOPCLEEGDFB);
				BHPIABAGAPB nINILENHPHE = ((b != 2) ? new NCGHMJPCCLD(num, num2, mNIMEAMHNMI, bCIHLCMFAEK, bigInteger, bigInteger2) : new NCGHMJPCCLD(num, num2, fKOBMEPIABG, kHNDCPCHOEM, mNIMEAMHNMI, bCIHLCMFAEK, bigInteger, bigInteger2));
				JGAFKLGGBGF hJMBDGKAOBP = KELEKEJNPHP(MAHJBOHDFDJ, nINILENHPHE, nJPMJNHGDNE);
				return new MJDENGGDLMJ(nINILENHPHE, hJMBDGKAOBP, bigInteger, bigInteger2);
			}
			case 3:
			{
				int nELJNGEPEFH = KINEBFNENMB.DMHJEBHACNN(MOPCLEEGDFB);
				if (!GCEKOHNJPJE.JKECGIEKIOB(nELJNGEPEFH))
				{
					throw new DEIDBCPPCMB(47);
				}
				CICIOBFDAEE(KJAHHLKPNIN, nELJNGEPEFH);
				return PIIHJLCCMHE(nELJNGEPEFH);
			}
			default:
				throw new DEIDBCPPCMB(47);
			}
		}
		catch (Exception cEDNDOAMNOC)
		{
			throw new DEIDBCPPCMB(47, cEDNDOAMNOC);
		}
	}

	private static void CICIOBFDAEE(int[] KJAHHLKPNIN, int NELJNGEPEFH)
	{
		if (KJAHHLKPNIN != null && !NOGCEBKPPJE.KMDACNACKII(KJAHHLKPNIN, NELJNGEPEFH))
		{
			throw new DEIDBCPPCMB(47);
		}
	}

	public static void MLNLOJDJPCF(int BENKLGPHLGI, Stream BILGCJNPJGJ)
	{
		BigInteger aMFCENFNAJJ = BigInteger.AGLOJCOAJIK(BENKLGPHLGI);
		HLFNNFKNEEP(aMFCENFNAJJ, BILGCJNPJGJ);
	}

	public static void JAPHPFBBHNI(KBINBLGGLNE AMFCENFNAJJ, Stream BILGCJNPJGJ)
	{
		KINEBFNENMB.GECPGLGLIBE(AMFCENFNAJJ.PPCPBIEGJKM(), BILGCJNPJGJ);
	}

	public static void JAPHPFBBHNI(int GJDKDMFAABP, BigInteger AMFCENFNAJJ, Stream BILGCJNPJGJ)
	{
		KINEBFNENMB.GECPGLGLIBE(DFDFICMPKDH(GJDKDMFAABP, AMFCENFNAJJ), BILGCJNPJGJ);
	}

	public static void HLFNNFKNEEP(BigInteger AMFCENFNAJJ, Stream BILGCJNPJGJ)
	{
		KINEBFNENMB.GECPGLGLIBE(ODBELJAHGIG.HOGKINKACAF(AMFCENFNAJJ), BILGCJNPJGJ);
	}

	public static void HDDLKMIFKCM(byte[] MAHJBOHDFDJ, MJDENGGDLMJ PDOJLPLFJCN, Stream BILGCJNPJGJ)
	{
		BHPIABAGAPB bHPIABAGAPB = PDOJLPLFJCN.ECFGFKNLLGH;
		if (KHJLHEJBLOA.FNAAANIPFOP(bHPIABAGAPB))
		{
			KINEBFNENMB.JBOHOOBEPAM(1, BILGCJNPJGJ);
			HLFNNFKNEEP(bHPIABAGAPB.LLHBLBINBOA.HJKCMCLHBEN, BILGCJNPJGJ);
		}
		else
		{
			if (!KHJLHEJBLOA.BDGICGJIGPF(bHPIABAGAPB))
			{
				throw new ArgumentException("'ecParameters' not a known curve type");
			}
			AIGKJBLDPNN aIGKJBLDPNN = (AIGKJBLDPNN)bHPIABAGAPB.LLHBLBINBOA;
			int[] array = aIGKJBLDPNN.AJFCOOELGPF.KOHLMNNELKF();
			KINEBFNENMB.JBOHOOBEPAM(2, BILGCJNPJGJ);
			int pLCFEOMGCFK = array[array.Length - 1];
			KINEBFNENMB.AKGIEBIEJJL(pLCFEOMGCFK);
			KINEBFNENMB.PGBAOHFKNHN(pLCFEOMGCFK, BILGCJNPJGJ);
			if (array.Length == 3)
			{
				KINEBFNENMB.JBOHOOBEPAM(1, BILGCJNPJGJ);
				MLNLOJDJPCF(array[1], BILGCJNPJGJ);
			}
			else
			{
				if (array.Length != 5)
				{
					throw new ArgumentException("Only trinomial and pentomial curves are supported");
				}
				KINEBFNENMB.JBOHOOBEPAM(2, BILGCJNPJGJ);
				MLNLOJDJPCF(array[1], BILGCJNPJGJ);
				MLNLOJDJPCF(array[2], BILGCJNPJGJ);
				MLNLOJDJPCF(array[3], BILGCJNPJGJ);
			}
		}
		JAPHPFBBHNI(bHPIABAGAPB.JEHECJGFJEB, BILGCJNPJGJ);
		JAPHPFBBHNI(bHPIABAGAPB.FPKDKHJKEEF, BILGCJNPJGJ);
		KINEBFNENMB.GECPGLGLIBE(FOHMIANCLHI(MAHJBOHDFDJ, PDOJLPLFJCN.HBGOKILMBJG), BILGCJNPJGJ);
		HLFNNFKNEEP(PDOJLPLFJCN.HNLMGJGNBDD, BILGCJNPJGJ);
		HLFNNFKNEEP(PDOJLPLFJCN.JGOHMOHEFMJ, BILGCJNPJGJ);
	}

	public static void DAHMDNHLIEM(byte[] MAHJBOHDFDJ, JGAFKLGGBGF KJPPPBMDJKG, Stream BILGCJNPJGJ)
	{
		KINEBFNENMB.GECPGLGLIBE(FOHMIANCLHI(MAHJBOHDFDJ, KJPPPBMDJKG), BILGCJNPJGJ);
	}

	public static void JKPBHADNBJB(int NELJNGEPEFH, Stream BILGCJNPJGJ)
	{
		if (!GCEKOHNJPJE.JKECGIEKIOB(NELJNGEPEFH))
		{
			throw new DEIDBCPPCMB(80);
		}
		KINEBFNENMB.JBOHOOBEPAM(3, BILGCJNPJGJ);
		KINEBFNENMB.AKGIEBIEJJL(NELJNGEPEFH);
		KINEBFNENMB.PGBAOHFKNHN(NELJNGEPEFH, BILGCJNPJGJ);
	}
}
