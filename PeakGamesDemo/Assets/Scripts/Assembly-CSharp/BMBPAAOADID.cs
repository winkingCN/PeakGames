using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

public class BMBPAAOADID : OHPHNNNHCOO
{
	private readonly BJLAMONNNDD HABFKBCEIBN;

	private readonly IJNFIACGEKI BKGBKJJAGHA;

	private bool KGPBDABMHKH;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return HABFKBCEIBN.KFKMEPMEBND + "with" + BKGBKJJAGHA.KFKMEPMEBND;
		}
	}

	public BMBPAAOADID(IJNFIACGEKI JFBOCCEMONP, BJLAMONNNDD HABFKBCEIBN)
	{
		BKGBKJJAGHA = JFBOCCEMONP;
		this.HABFKBCEIBN = HABFKBCEIBN;
	}

	public virtual void DIOELAHNLKJ(bool KGPBDABMHKH, IGMAJHKIIPK IJJHBEECMBP)
	{
		this.KGPBDABMHKH = KGPBDABMHKH;
		COEMJAGOFJJ cOEMJAGOFJJ = ((!(IJJHBEECMBP is MDAKJDOFCEP)) ? ((COEMJAGOFJJ)IJJHBEECMBP) : ((COEMJAGOFJJ)((MDAKJDOFCEP)IJJHBEECMBP).KPJHHAAOFOH));
		if (KGPBDABMHKH && !cOEMJAGOFJJ.CCLHEKOIIKM)
		{
			throw new InvalidKeyException("Signing Requires Private Key.");
		}
		if (!KGPBDABMHKH && cOEMJAGOFJJ.CCLHEKOIIKM)
		{
			throw new InvalidKeyException("Verification Requires Public Key.");
		}
		OMOKOKFNBKI();
		BKGBKJJAGHA.DIOELAHNLKJ(KGPBDABMHKH, IJJHBEECMBP);
	}

	public virtual void BPAJGOINFNL(byte MOPCLEEGDFB)
	{
		HABFKBCEIBN.BPAJGOINFNL(MOPCLEEGDFB);
	}

	public virtual void GONEEEFEDGF(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP)
	{
		HABFKBCEIBN.GONEEEFEDGF(MOPCLEEGDFB, ELICNEDIBGB, EOFAGACBNFP);
	}

	public virtual byte[] HMJHAKCMGHC()
	{
		if (!KGPBDABMHKH)
		{
			throw new InvalidOperationException("GOST3410DigestSigner not initialised for signature generation.");
		}
		byte[] array = new byte[HABFKBCEIBN.EEMLLAMENHO()];
		HABFKBCEIBN.LCNOFBMOHHM(array, 0);
		try
		{
			BigInteger[] array2 = BKGBKJJAGHA.HMJHAKCMGHC(array);
			byte[] array3 = new byte[64];
			byte[] array4 = array2[0].MEOCDOOKOLH();
			byte[] array5 = array2[1].MEOCDOOKOLH();
			array5.CopyTo(array3, 32 - array5.Length);
			array4.CopyTo(array3, 64 - array4.Length);
			return array3;
		}
		catch (Exception ex)
		{
			throw new SignatureException(ex.Message, ex);
		}
	}

	public virtual bool HLJBBONKPDG(byte[] PINNJBGMGOA)
	{
		if (KGPBDABMHKH)
		{
			throw new InvalidOperationException("DSADigestSigner not initialised for verification");
		}
		byte[] array = new byte[HABFKBCEIBN.EEMLLAMENHO()];
		HABFKBCEIBN.LCNOFBMOHHM(array, 0);
		BigInteger gPGDCCMECGF;
		BigInteger iBBBMACIBGK;
		try
		{
			gPGDCCMECGF = new BigInteger(1, PINNJBGMGOA, 32, 32);
			iBBBMACIBGK = new BigInteger(1, PINNJBGMGOA, 0, 32);
		}
		catch (Exception fGDHECKFFDP)
		{
			throw new SignatureException("error decoding signature bytes.", fGDHECKFFDP);
		}
		return BKGBKJJAGHA.HLJBBONKPDG(array, gPGDCCMECGF, iBBBMACIBGK);
	}

	public virtual void OMOKOKFNBKI()
	{
		HABFKBCEIBN.OMOKOKFNBKI();
	}
}
