using System;
using Org.BouncyCastle.Security;

public class NFONJENKCCJ : OHPHNNNHCOO
{
	private readonly DGCIOOEELCP MFMIFDMEPPO;

	private readonly BJLAMONNNDD HABFKBCEIBN;

	private bool KGPBDABMHKH;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return "Generic(" + MFMIFDMEPPO.KFKMEPMEBND + "/" + HABFKBCEIBN.KFKMEPMEBND + ")";
		}
	}

	public NFONJENKCCJ(DGCIOOEELCP MFMIFDMEPPO, BJLAMONNNDD HABFKBCEIBN)
	{
		this.MFMIFDMEPPO = MFMIFDMEPPO;
		this.HABFKBCEIBN = HABFKBCEIBN;
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
		MFMIFDMEPPO.DIOELAHNLKJ(KGPBDABMHKH, IJJHBEECMBP);
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
			throw new InvalidOperationException("GenericSigner not initialised for signature generation.");
		}
		byte[] array = new byte[HABFKBCEIBN.EEMLLAMENHO()];
		HABFKBCEIBN.LCNOFBMOHHM(array, 0);
		return MFMIFDMEPPO.DPACJDFHLKB(array, 0, array.Length);
	}

	public virtual bool HLJBBONKPDG(byte[] PINNJBGMGOA)
	{
		if (KGPBDABMHKH)
		{
			throw new InvalidOperationException("GenericSigner not initialised for verification");
		}
		byte[] array = new byte[HABFKBCEIBN.EEMLLAMENHO()];
		HABFKBCEIBN.LCNOFBMOHHM(array, 0);
		try
		{
			byte[] array2 = MFMIFDMEPPO.DPACJDFHLKB(PINNJBGMGOA, 0, PINNJBGMGOA.Length);
			if (array2.Length < array.Length)
			{
				byte[] array3 = new byte[array.Length];
				Array.Copy(array2, 0, array3, array3.Length - array2.Length, array2.Length);
				array2 = array3;
			}
			return NOGCEBKPPJE.PBBFCJBKJEN(array2, array);
		}
		catch (Exception)
		{
			return false;
		}
	}

	public virtual void OMOKOKFNBKI()
	{
		HABFKBCEIBN.OMOKOKFNBKI();
	}
}
