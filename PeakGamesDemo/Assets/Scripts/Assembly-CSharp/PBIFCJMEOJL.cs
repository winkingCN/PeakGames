using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

public class PBIFCJMEOJL : IJNFIACGEKI
{
	private bool KGPBDABMHKH;

	private BKFMFPGHIJB IKNCPEPOKGJ;

	private FBIJJFGLKMK GECCLOFELEC;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return "ECNR";
		}
	}

	public virtual void DIOELAHNLKJ(bool KGPBDABMHKH, IGMAJHKIIPK IJJHBEECMBP)
	{
		this.KGPBDABMHKH = KGPBDABMHKH;
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
		if (!KGPBDABMHKH)
		{
			throw new InvalidOperationException("not initialised for signing");
		}
		BigInteger bigInteger = ((EKGPBAENHIF)IKNCPEPOKGJ).KPJHHAAOFOH.HNLMGJGNBDD;
		int bitLength = bigInteger.BitLength;
		BigInteger bigInteger2 = new BigInteger(1, OEFCOJLNCKP);
		int bitLength2 = bigInteger2.BitLength;
		EKGPBAENHIF eKGPBAENHIF = (EKGPBAENHIF)IKNCPEPOKGJ;
		if (bitLength2 > bitLength)
		{
			throw new DataLengthException("input too large for ECNR key.");
		}
		BigInteger bigInteger3 = null;
		BigInteger bigInteger4 = null;
		HOHJPJDGOLF hOHJPJDGOLF;
		do
		{
			JMLCKFLAGEF jMLCKFLAGEF = new JMLCKFLAGEF();
			jMLCKFLAGEF.DIOELAHNLKJ(new JDKCFKJJIHN(eKGPBAENHIF.KPJHHAAOFOH, GECCLOFELEC));
			hOHJPJDGOLF = jMLCKFLAGEF.LOFCKPBODIJ();
			EGEBOHHBFLK eGEBOHHBFLK = (EGEBOHHBFLK)hOHJPJDGOLF.OOOKGOFNBEG;
			BigInteger bigInteger5 = eGEBOHHBFLK.FNPELDEHJKL.HBEBMBOOIMD.DOJBPIFPALJ();
			bigInteger3 = bigInteger5.JEACJNAKLDJ(bigInteger2).MODIHOCEKBK(bigInteger);
		}
		while (bigInteger3.SignValue == 0);
		BigInteger hIMINGHNIKN = eKGPBAENHIF.INCIODEICNM;
		BigInteger bigInteger6 = ((EKGPBAENHIF)hOHJPJDGOLF.KIBEEKODFLC).INCIODEICNM;
		bigInteger4 = bigInteger6.FBGIHKPECCO(bigInteger3.IBJBIGNPNEM(hIMINGHNIKN)).MODIHOCEKBK(bigInteger);
		return new BigInteger[2] { bigInteger3, bigInteger4 };
	}

	public virtual bool HLJBBONKPDG(byte[] OEFCOJLNCKP, BigInteger GPGDCCMECGF, BigInteger IBBBMACIBGK)
	{
		if (KGPBDABMHKH)
		{
			throw new InvalidOperationException("not initialised for verifying");
		}
		EGEBOHHBFLK eGEBOHHBFLK = (EGEBOHHBFLK)IKNCPEPOKGJ;
		BigInteger bigInteger = eGEBOHHBFLK.KPJHHAAOFOH.HNLMGJGNBDD;
		int bitLength = bigInteger.BitLength;
		BigInteger bigInteger2 = new BigInteger(1, OEFCOJLNCKP);
		int bitLength2 = bigInteger2.BitLength;
		if (bitLength2 > bitLength)
		{
			throw new DataLengthException("input too large for ECNR key.");
		}
		if (GPGDCCMECGF.JLPDKNFCNPO(BigInteger.One) < 0 || GPGDCCMECGF.JLPDKNFCNPO(bigInteger) >= 0)
		{
			return false;
		}
		if (IBBBMACIBGK.JLPDKNFCNPO(BigInteger.Zero) < 0 || IBBBMACIBGK.JLPDKNFCNPO(bigInteger) >= 0)
		{
			return false;
		}
		JGAFKLGGBGF mBIJHANOCOC = eGEBOHHBFLK.KPJHHAAOFOH.HBGOKILMBJG;
		JGAFKLGGBGF fNPELDEHJKL = eGEBOHHBFLK.FNPELDEHJKL;
		JGAFKLGGBGF jGAFKLGGBGF = KHJLHEJBLOA.PCCKCCDMHGL(mBIJHANOCOC, IBBBMACIBGK, fNPELDEHJKL, GPGDCCMECGF).MIHJHLFLHNA();
		if (jGAFKLGGBGF.IFCDKFANPBO)
		{
			return false;
		}
		BigInteger iDHLPOFDLKJ = jGAFKLGGBGF.HBEBMBOOIMD.DOJBPIFPALJ();
		BigInteger bigInteger3 = GPGDCCMECGF.FBGIHKPECCO(iDHLPOFDLKJ).MODIHOCEKBK(bigInteger);
		return bigInteger3.Equals(bigInteger2);
	}
}
