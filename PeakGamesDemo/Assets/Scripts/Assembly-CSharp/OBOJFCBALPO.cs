using System;
using System.IO;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

public class OBOJFCBALPO : OHPHNNNHCOO
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

	public OBOJFCBALPO(IJNFIACGEKI JFBOCCEMONP, BJLAMONNNDD HABFKBCEIBN)
	{
		this.HABFKBCEIBN = HABFKBCEIBN;
		BKGBKJJAGHA = JFBOCCEMONP;
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
			throw new InvalidOperationException("DSADigestSigner not initialised for signature generation.");
		}
		byte[] array = new byte[HABFKBCEIBN.EEMLLAMENHO()];
		HABFKBCEIBN.LCNOFBMOHHM(array, 0);
		BigInteger[] array2 = BKGBKJJAGHA.HMJHAKCMGHC(array);
		return GFNHKPOLEOL(array2[0], array2[1]);
	}

	public virtual bool HLJBBONKPDG(byte[] PINNJBGMGOA)
	{
		if (KGPBDABMHKH)
		{
			throw new InvalidOperationException("DSADigestSigner not initialised for verification");
		}
		byte[] array = new byte[HABFKBCEIBN.EEMLLAMENHO()];
		HABFKBCEIBN.LCNOFBMOHHM(array, 0);
		try
		{
			BigInteger[] array2 = DIPHDGJJMBH(PINNJBGMGOA);
			return BKGBKJJAGHA.HLJBBONKPDG(array, array2[0], array2[1]);
		}
		catch (IOException)
		{
			return false;
		}
	}

	public virtual void OMOKOKFNBKI()
	{
		HABFKBCEIBN.OMOKOKFNBKI();
	}

	private byte[] GFNHKPOLEOL(BigInteger GPGDCCMECGF, BigInteger IBBBMACIBGK)
	{
		return new KOGPLMALOEH(new GLFDIPNOLKN(GPGDCCMECGF), new GLFDIPNOLKN(IBBBMACIBGK)).KMBJLPOKIAC();
	}

	private BigInteger[] DIPHDGJJMBH(byte[] NJPMJNHGDNE)
	{
		ALLINHNNNJN aLLINHNNNJN = (ALLINHNNNJN)EDOEBJJFOBM.HPDCKMOPEMM(NJPMJNHGDNE);
		return new BigInteger[2]
		{
			((GLFDIPNOLKN)aLLINHNNNJN.ECNCPJGHBIG(0)).JBGOANMLBFA,
			((GLFDIPNOLKN)aLLINHNNNJN.ECNCPJGHBIG(1)).JBGOANMLBFA
		};
	}
}
