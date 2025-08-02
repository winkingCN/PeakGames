using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

public class BKBFGOOKCEF : IJNFIACGEKI
{
	private BKFMFPGHIJB IKNCPEPOKGJ;

	private FBIJJFGLKMK GECCLOFELEC;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return "ECGOST3410";
		}
	}

	public virtual void DIOELAHNLKJ(bool KGPBDABMHKH, IGMAJHKIIPK IJJHBEECMBP)
	{
		if (KGPBDABMHKH)
		{
			if (IJJHBEECMBP is MDAKJDOFCEP)
			{
				MDAKJDOFCEP mDAKJDOFCEP = (MDAKJDOFCEP)IJJHBEECMBP;
				GECCLOFELEC = mDAKJDOFCEP.IPFKDIJBGIM;
				IJJHBEECMBP = mDAKJDOFCEP.KPJHHAAOFOH;
			}
			else
			{
				GECCLOFELEC = new FBIJJFGLKMK();
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
	}

	public virtual BigInteger[] HMJHAKCMGHC(byte[] OEFCOJLNCKP)
	{
		byte[] array = new byte[OEFCOJLNCKP.Length];
		for (int i = 0; i != array.Length; i++)
		{
			array[i] = OEFCOJLNCKP[array.Length - 1 - i];
		}
		BigInteger hIMINGHNIKN = new BigInteger(1, array);
		MJDENGGDLMJ mJDENGGDLMJ = IKNCPEPOKGJ.KPJHHAAOFOH;
		BigInteger bigInteger = mJDENGGDLMJ.HNLMGJGNBDD;
		BigInteger bigInteger2 = ((EKGPBAENHIF)IKNCPEPOKGJ).INCIODEICNM;
		BigInteger bigInteger3 = null;
		FFPNOKBELNH fFPNOKBELNH = MNNAMFOOBIC();
		BigInteger bigInteger5;
		while (true)
		{
			BigInteger bigInteger4 = new BigInteger(bigInteger.BitLength, GECCLOFELEC);
			if (bigInteger4.SignValue == 0)
			{
				continue;
			}
			JGAFKLGGBGF jGAFKLGGBGF = fFPNOKBELNH.IBJBIGNPNEM(mJDENGGDLMJ.HBGOKILMBJG, bigInteger4).MIHJHLFLHNA();
			bigInteger5 = jGAFKLGGBGF.HBEBMBOOIMD.DOJBPIFPALJ().MODIHOCEKBK(bigInteger);
			if (bigInteger5.SignValue != 0)
			{
				bigInteger3 = bigInteger4.IBJBIGNPNEM(hIMINGHNIKN).JEACJNAKLDJ(bigInteger2.IBJBIGNPNEM(bigInteger5)).MODIHOCEKBK(bigInteger);
				if (bigInteger3.SignValue != 0)
				{
					break;
				}
			}
		}
		return new BigInteger[2] { bigInteger5, bigInteger3 };
	}

	public virtual bool HLJBBONKPDG(byte[] OEFCOJLNCKP, BigInteger GPGDCCMECGF, BigInteger IBBBMACIBGK)
	{
		byte[] array = new byte[OEFCOJLNCKP.Length];
		for (int i = 0; i != array.Length; i++)
		{
			array[i] = OEFCOJLNCKP[array.Length - 1 - i];
		}
		BigInteger bigInteger = new BigInteger(1, array);
		BigInteger bigInteger2 = IKNCPEPOKGJ.KPJHHAAOFOH.HNLMGJGNBDD;
		if (GPGDCCMECGF.JLPDKNFCNPO(BigInteger.One) < 0 || GPGDCCMECGF.JLPDKNFCNPO(bigInteger2) >= 0)
		{
			return false;
		}
		if (IBBBMACIBGK.JLPDKNFCNPO(BigInteger.One) < 0 || IBBBMACIBGK.JLPDKNFCNPO(bigInteger2) >= 0)
		{
			return false;
		}
		BigInteger hIMINGHNIKN = bigInteger.DDENLEMHHAM(bigInteger2);
		BigInteger mNIMEAMHNMI = IBBBMACIBGK.IBJBIGNPNEM(hIMINGHNIKN).MODIHOCEKBK(bigInteger2);
		BigInteger bCIHLCMFAEK = bigInteger2.FBGIHKPECCO(GPGDCCMECGF).IBJBIGNPNEM(hIMINGHNIKN).MODIHOCEKBK(bigInteger2);
		JGAFKLGGBGF mBIJHANOCOC = IKNCPEPOKGJ.KPJHHAAOFOH.HBGOKILMBJG;
		JGAFKLGGBGF fNPELDEHJKL = ((EGEBOHHBFLK)IKNCPEPOKGJ).FNPELDEHJKL;
		JGAFKLGGBGF jGAFKLGGBGF = KHJLHEJBLOA.PCCKCCDMHGL(mBIJHANOCOC, mNIMEAMHNMI, fNPELDEHJKL, bCIHLCMFAEK).MIHJHLFLHNA();
		if (jGAFKLGGBGF.IFCDKFANPBO)
		{
			return false;
		}
		BigInteger bigInteger3 = jGAFKLGGBGF.HBEBMBOOIMD.DOJBPIFPALJ().MODIHOCEKBK(bigInteger2);
		return bigInteger3.Equals(GPGDCCMECGF);
	}

	protected virtual FFPNOKBELNH MNNAMFOOBIC()
	{
		return new JPEIAFMHCOG();
	}
}
