using System;
using System.Collections;
using Org.BouncyCastle.Security;

public class MEHKHDBEJDF : OHPHNNNHCOO
{
	private readonly DGCIOOEELCP NGDIDJDGKMJ = new ODMDKFPOHIL(new EPDGODLEJEF());

	private readonly COCECKPDIKC CNMAIKJICBJ;

	private readonly BJLAMONNNDD HABFKBCEIBN;

	private bool KGPBDABMHKH;

	private static readonly IDictionary JOHLELPLJLI;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return HABFKBCEIBN.KFKMEPMEBND + "withRSA";
		}
	}

	static MEHKHDBEJDF()
	{
		JOHLELPLJLI = LHFGHNFJIKM.JBEOCJEMGCE();
		JOHLELPLJLI["RIPEMD128"] = HECJIGBIHCA.KCPONBGBCIG;
		JOHLELPLJLI["RIPEMD160"] = HECJIGBIHCA.LNJCFFFDBMO;
		JOHLELPLJLI["RIPEMD256"] = HECJIGBIHCA.AEIDPDDECDO;
		JOHLELPLJLI["SHA-1"] = FBFBJFFFNOF.MEBPJCLMCDA;
		JOHLELPLJLI["SHA-224"] = HHKLFIFJNFO.NGAKIGLLNMJ;
		JOHLELPLJLI["SHA-256"] = HHKLFIFJNFO.OKLEKJJIGME;
		JOHLELPLJLI["SHA-384"] = HHKLFIFJNFO.EJIHFCHFMLO;
		JOHLELPLJLI["SHA-512"] = HHKLFIFJNFO.HBLLHCKNOKB;
		JOHLELPLJLI["MD2"] = NLPPJKFFBON.LEJDEOPIHPN;
		JOHLELPLJLI["MD4"] = NLPPJKFFBON.PKOKJMOJEHF;
		JOHLELPLJLI["MD5"] = NLPPJKFFBON.HCEBKEDMKGI;
	}

	public MEHKHDBEJDF(BJLAMONNNDD HABFKBCEIBN)
		: this(HABFKBCEIBN, (KLKJHFKJLEM)JOHLELPLJLI[HABFKBCEIBN.KFKMEPMEBND])
	{
	}

	public MEHKHDBEJDF(BJLAMONNNDD HABFKBCEIBN, KLKJHFKJLEM OOCCPEJBBPE)
		: this(HABFKBCEIBN, new COCECKPDIKC(OOCCPEJBBPE, HLAKNNHGPNP.GABGKBAKHDP))
	{
	}

	public MEHKHDBEJDF(BJLAMONNNDD HABFKBCEIBN, COCECKPDIKC CNMAIKJICBJ)
	{
		this.HABFKBCEIBN = HABFKBCEIBN;
		this.CNMAIKJICBJ = CNMAIKJICBJ;
	}

	public virtual void DIOELAHNLKJ(bool KGPBDABMHKH, IGMAJHKIIPK IJJHBEECMBP)
	{
		this.KGPBDABMHKH = KGPBDABMHKH;
		COEMJAGOFJJ cOEMJAGOFJJ = ((!(IJJHBEECMBP is MDAKJDOFCEP)) ? ((COEMJAGOFJJ)IJJHBEECMBP) : ((COEMJAGOFJJ)((MDAKJDOFCEP)IJJHBEECMBP).KPJHHAAOFOH));
		if (KGPBDABMHKH && !cOEMJAGOFJJ.CCLHEKOIIKM)
		{
			throw new InvalidKeyException("Signing requires private key.");
		}
		if (!KGPBDABMHKH && cOEMJAGOFJJ.CCLHEKOIIKM)
		{
			throw new InvalidKeyException("Verification requires public key.");
		}
		OMOKOKFNBKI();
		NGDIDJDGKMJ.DIOELAHNLKJ(KGPBDABMHKH, IJJHBEECMBP);
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
			throw new InvalidOperationException("RsaDigestSigner not initialised for signature generation.");
		}
		byte[] array = new byte[HABFKBCEIBN.EEMLLAMENHO()];
		HABFKBCEIBN.LCNOFBMOHHM(array, 0);
		byte[] array2 = GFNHKPOLEOL(array);
		return NGDIDJDGKMJ.DPACJDFHLKB(array2, 0, array2.Length);
	}

	public virtual bool HLJBBONKPDG(byte[] PINNJBGMGOA)
	{
		if (KGPBDABMHKH)
		{
			throw new InvalidOperationException("RsaDigestSigner not initialised for verification");
		}
		byte[] array = new byte[HABFKBCEIBN.EEMLLAMENHO()];
		HABFKBCEIBN.LCNOFBMOHHM(array, 0);
		byte[] array2;
		byte[] array3;
		try
		{
			array2 = NGDIDJDGKMJ.DPACJDFHLKB(PINNJBGMGOA, 0, PINNJBGMGOA.Length);
			array3 = GFNHKPOLEOL(array);
		}
		catch (Exception)
		{
			return false;
		}
		if (array2.Length == array3.Length)
		{
			return NOGCEBKPPJE.PBBFCJBKJEN(array2, array3);
		}
		if (array2.Length == array3.Length - 2)
		{
			int num = array2.Length - array.Length - 2;
			int num2 = array3.Length - array.Length - 2;
			array3[1] -= 2;
			array3[3] -= 2;
			int num3 = 0;
			for (int i = 0; i < array.Length; i++)
			{
				num3 |= array2[num + i] ^ array3[num2 + i];
			}
			for (int j = 0; j < num; j++)
			{
				num3 |= array2[j] ^ array3[j];
			}
			return num3 == 0;
		}
		return false;
	}

	public virtual void OMOKOKFNBKI()
	{
		HABFKBCEIBN.OMOKOKFNBKI();
	}

	private byte[] GFNHKPOLEOL(byte[] AIELCDIFLFB)
	{
		if (CNMAIKJICBJ == null)
		{
			return AIELCDIFLFB;
		}
		LFLPHPGFFKP lFLPHPGFFKP = new LFLPHPGFFKP(CNMAIKJICBJ, AIELCDIFLFB);
		return lFLPHPGFFKP.KMBJLPOKIAC();
	}
}
