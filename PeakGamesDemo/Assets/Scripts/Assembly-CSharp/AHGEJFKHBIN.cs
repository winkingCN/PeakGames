using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

public class AHGEJFKHBIN : IJNFIACGEKI
{
	private static readonly BigInteger COOAFHOLHGF = BigInteger.AGLOJCOAJIK(8L);

	protected readonly ADIMNCBLPFK KFEHJEMADHH;

	protected BKFMFPGHIJB IKNCPEPOKGJ;

	protected FBIJJFGLKMK GECCLOFELEC;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return "ECDSA";
		}
	}

	public AHGEJFKHBIN()
	{
		KFEHJEMADHH = new LAHPIEPNMBJ();
	}

	public AHGEJFKHBIN(ADIMNCBLPFK KFEHJEMADHH)
	{
		this.KFEHJEMADHH = KFEHJEMADHH;
	}

	public virtual void DIOELAHNLKJ(bool KGPBDABMHKH, IGMAJHKIIPK IJJHBEECMBP)
	{
		FBIJJFGLKMK mLJKIJIANBL = null;
		if (KGPBDABMHKH)
		{
			if (IJJHBEECMBP is MDAKJDOFCEP)
			{
				MDAKJDOFCEP mDAKJDOFCEP = (MDAKJDOFCEP)IJJHBEECMBP;
				mLJKIJIANBL = mDAKJDOFCEP.IPFKDIJBGIM;
				IJJHBEECMBP = mDAKJDOFCEP.KPJHHAAOFOH;
			}
			if (!(IJJHBEECMBP is EKGPBAENHIF))
			{
				throw new InvalidKeyException("EC private key required for signing");
			}
			IKNCPEPOKGJ = (EKGPBAENHIF)IJJHBEECMBP;
		}
		else
		{
			if (!(IJJHBEECMBP is EGEBOHHBFLK))
			{
				throw new InvalidKeyException("EC public key required for verification");
			}
			IKNCPEPOKGJ = (EGEBOHHBFLK)IJJHBEECMBP;
		}
		GECCLOFELEC = PMFIFBKAIBN(KGPBDABMHKH && !KFEHJEMADHH.GFIOEICPIKI, mLJKIJIANBL);
	}

	public virtual BigInteger[] HMJHAKCMGHC(byte[] OEFCOJLNCKP)
	{
		MJDENGGDLMJ mJDENGGDLMJ = IKNCPEPOKGJ.KPJHHAAOFOH;
		BigInteger bigInteger = mJDENGGDLMJ.HNLMGJGNBDD;
		BigInteger bigInteger2 = OKNFNHPECJN(bigInteger, OEFCOJLNCKP);
		BigInteger bigInteger3 = ((EKGPBAENHIF)IKNCPEPOKGJ).INCIODEICNM;
		if (KFEHJEMADHH.GFIOEICPIKI)
		{
			KFEHJEMADHH.DIOELAHNLKJ(bigInteger, bigInteger3, OEFCOJLNCKP);
		}
		else
		{
			KFEHJEMADHH.DIOELAHNLKJ(bigInteger, GECCLOFELEC);
		}
		FFPNOKBELNH fFPNOKBELNH = MNNAMFOOBIC();
		BigInteger bigInteger5;
		BigInteger bigInteger6;
		while (true)
		{
			BigInteger bigInteger4 = KFEHJEMADHH.BEEIBADAJMB();
			JGAFKLGGBGF jGAFKLGGBGF = fFPNOKBELNH.IBJBIGNPNEM(mJDENGGDLMJ.HBGOKILMBJG, bigInteger4).MIHJHLFLHNA();
			bigInteger5 = jGAFKLGGBGF.HBEBMBOOIMD.DOJBPIFPALJ().MODIHOCEKBK(bigInteger);
			if (bigInteger5.SignValue != 0)
			{
				bigInteger6 = bigInteger4.DDENLEMHHAM(bigInteger).IBJBIGNPNEM(bigInteger2.JEACJNAKLDJ(bigInteger3.IBJBIGNPNEM(bigInteger5))).MODIHOCEKBK(bigInteger);
				if (bigInteger6.SignValue != 0)
				{
					break;
				}
			}
		}
		return new BigInteger[2] { bigInteger5, bigInteger6 };
	}

	public virtual bool HLJBBONKPDG(byte[] OEFCOJLNCKP, BigInteger GPGDCCMECGF, BigInteger IBBBMACIBGK)
	{
		BigInteger bigInteger = IKNCPEPOKGJ.KPJHHAAOFOH.HNLMGJGNBDD;
		if (GPGDCCMECGF.SignValue < 1 || IBBBMACIBGK.SignValue < 1 || GPGDCCMECGF.JLPDKNFCNPO(bigInteger) >= 0 || IBBBMACIBGK.JLPDKNFCNPO(bigInteger) >= 0)
		{
			return false;
		}
		BigInteger bigInteger2 = OKNFNHPECJN(bigInteger, OEFCOJLNCKP);
		BigInteger hIMINGHNIKN = IBBBMACIBGK.DDENLEMHHAM(bigInteger);
		BigInteger mNIMEAMHNMI = bigInteger2.IBJBIGNPNEM(hIMINGHNIKN).MODIHOCEKBK(bigInteger);
		BigInteger bCIHLCMFAEK = GPGDCCMECGF.IBJBIGNPNEM(hIMINGHNIKN).MODIHOCEKBK(bigInteger);
		JGAFKLGGBGF mBIJHANOCOC = IKNCPEPOKGJ.KPJHHAAOFOH.HBGOKILMBJG;
		JGAFKLGGBGF fNPELDEHJKL = ((EGEBOHHBFLK)IKNCPEPOKGJ).FNPELDEHJKL;
		JGAFKLGGBGF jGAFKLGGBGF = KHJLHEJBLOA.PCCKCCDMHGL(mBIJHANOCOC, mNIMEAMHNMI, fNPELDEHJKL, bCIHLCMFAEK);
		if (jGAFKLGGBGF.IFCDKFANPBO)
		{
			return false;
		}
		BHPIABAGAPB bHPIABAGAPB = jGAFKLGGBGF.ECFGFKNLLGH;
		if (bHPIABAGAPB != null)
		{
			BigInteger bigInteger3 = bHPIABAGAPB.PPPAFJOLKPD;
			if (bigInteger3 != null && bigInteger3.JLPDKNFCNPO(COOAFHOLHGF) <= 0)
			{
				KBINBLGGLNE kBINBLGGLNE = BFJKFCLPIHC(bHPIABAGAPB.DHBHKHGFIKI, jGAFKLGGBGF);
				if (kBINBLGGLNE != null && !kBINBLGGLNE.EJJHHCOFAAI)
				{
					KBINBLGGLNE cJHEIBNHNNE = jGAFKLGGBGF.OBCJFNBLIPG;
					while (bHPIABAGAPB.DBFKLCPIHOI(GPGDCCMECGF))
					{
						KBINBLGGLNE kBINBLGGLNE2 = bHPIABAGAPB.HFENNGHNFLF(GPGDCCMECGF).IBJBIGNPNEM(kBINBLGGLNE);
						if (kBINBLGGLNE2.KIFDKLPDKMD(cJHEIBNHNNE))
						{
							return true;
						}
						GPGDCCMECGF = GPGDCCMECGF.JEACJNAKLDJ(bigInteger);
					}
					return false;
				}
			}
		}
		BigInteger bigInteger4 = jGAFKLGGBGF.MIHJHLFLHNA().HBEBMBOOIMD.DOJBPIFPALJ().MODIHOCEKBK(bigInteger);
		return bigInteger4.Equals(GPGDCCMECGF);
	}

	protected virtual BigInteger OKNFNHPECJN(BigInteger IDHLPOFDLKJ, byte[] OEFCOJLNCKP)
	{
		int num = OEFCOJLNCKP.Length * 8;
		BigInteger bigInteger = new BigInteger(1, OEFCOJLNCKP);
		if (IDHLPOFDLKJ.BitLength < num)
		{
			bigInteger = bigInteger.ABOIOKBIANB(num - IDHLPOFDLKJ.BitLength);
		}
		return bigInteger;
	}

	protected virtual FFPNOKBELNH MNNAMFOOBIC()
	{
		return new JPEIAFMHCOG();
	}

	protected virtual KBINBLGGLNE BFJKFCLPIHC(int POHMPJDPICB, JGAFKLGGBGF HPHBDNBJPHB)
	{
		switch (POHMPJDPICB)
		{
		case 1:
		case 6:
		case 7:
			return HPHBDNBJPHB.NOIPJPPAFOH(0);
		case 2:
		case 3:
		case 4:
			return HPHBDNBJPHB.NOIPJPPAFOH(0).MIOEHGDPGAG();
		default:
			return null;
		}
	}

	protected virtual FBIJJFGLKMK PMFIFBKAIBN(bool EJICKCGPFAH, FBIJJFGLKMK MLJKIJIANBL)
	{
		return (!EJICKCGPFAH) ? null : ((MLJKIJIANBL == null) ? new FBIJJFGLKMK() : MLJKIJIANBL);
	}
}
