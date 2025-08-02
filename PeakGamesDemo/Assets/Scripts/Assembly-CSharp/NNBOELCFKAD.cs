using System;
using Org.BouncyCastle.Crypto;

public class NNBOELCFKAD : IEKIBBAKJDP
{
	private OJGBFLKAPOB MFMIFDMEPPO;

	private JEMNCGMEABF BOFHHECPKNF;

	private CHCELGDKEJG LKBCCFNAEGP;

	private byte[] NDEFBOJOALL;

	private bool CDOHJGCEGAJ;

	private static readonly byte[] DLFFGENGALL = new byte[8] { 74, 221, 162, 44, 121, 232, 33, 5 };

	private readonly BJLAMONNNDD MLBEIDJMHFI = new KALMDEHGEAC();

	private readonly byte[] HABFKBCEIBN = new byte[20];

	public virtual string KFKMEPMEBND
	{
		get
		{
			return "DESede";
		}
	}

	public virtual void DIOELAHNLKJ(bool CDOHJGCEGAJ, IGMAJHKIIPK IJJHBEECMBP)
	{
		this.CDOHJGCEGAJ = CDOHJGCEGAJ;
		MFMIFDMEPPO = new OJGBFLKAPOB(new KAMMIHKEGPK());
		FBIJJFGLKMK fBIJJFGLKMK;
		if (IJJHBEECMBP is MDAKJDOFCEP)
		{
			MDAKJDOFCEP mDAKJDOFCEP = (MDAKJDOFCEP)IJJHBEECMBP;
			IJJHBEECMBP = mDAKJDOFCEP.KPJHHAAOFOH;
			fBIJJFGLKMK = mDAKJDOFCEP.IPFKDIJBGIM;
		}
		else
		{
			fBIJJFGLKMK = new FBIJJFGLKMK();
		}
		if (IJJHBEECMBP is JEMNCGMEABF)
		{
			BOFHHECPKNF = (JEMNCGMEABF)IJJHBEECMBP;
			if (this.CDOHJGCEGAJ)
			{
				NDEFBOJOALL = new byte[8];
				fBIJJFGLKMK.NextBytes(NDEFBOJOALL);
				LKBCCFNAEGP = new CHCELGDKEJG(BOFHHECPKNF, NDEFBOJOALL);
			}
		}
		else if (IJJHBEECMBP is CHCELGDKEJG)
		{
			if (!CDOHJGCEGAJ)
			{
				throw new ArgumentException("You should not supply an IV for unwrapping");
			}
			LKBCCFNAEGP = (CHCELGDKEJG)IJJHBEECMBP;
			NDEFBOJOALL = LKBCCFNAEGP.OLAEDCABKDH();
			BOFHHECPKNF = (JEMNCGMEABF)LKBCCFNAEGP.KPJHHAAOFOH;
			if (NDEFBOJOALL.Length != 8)
			{
				throw new ArgumentException("IV is not 8 octets", "parameters");
			}
		}
	}

	public virtual byte[] LFAFFAHKPCD(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP)
	{
		if (!CDOHJGCEGAJ)
		{
			throw new InvalidOperationException("Not initialized for wrapping");
		}
		byte[] array = new byte[EOFAGACBNFP];
		Array.Copy(MOPCLEEGDFB, ELICNEDIBGB, array, 0, EOFAGACBNFP);
		byte[] array2 = KIBEBLJOBAF(array);
		byte[] array3 = new byte[array.Length + array2.Length];
		Array.Copy(array, 0, array3, 0, array.Length);
		Array.Copy(array2, 0, array3, array.Length, array2.Length);
		int num = MFMIFDMEPPO.BDIGGHEPIIP();
		if (array3.Length % num != 0)
		{
			throw new InvalidOperationException("Not multiple of block length");
		}
		MFMIFDMEPPO.DIOELAHNLKJ(true, LKBCCFNAEGP);
		byte[] array4 = new byte[array3.Length];
		for (int i = 0; i != array3.Length; i += num)
		{
			MFMIFDMEPPO.DPACJDFHLKB(array3, i, array4, i);
		}
		byte[] array5 = new byte[NDEFBOJOALL.Length + array4.Length];
		Array.Copy(NDEFBOJOALL, 0, array5, 0, NDEFBOJOALL.Length);
		Array.Copy(array4, 0, array5, NDEFBOJOALL.Length, array4.Length);
		byte[] array6 = CDCGFGHDMBA(array5);
		CHCELGDKEJG iJJHBEECMBP = new CHCELGDKEJG(BOFHHECPKNF, DLFFGENGALL);
		MFMIFDMEPPO.DIOELAHNLKJ(true, iJJHBEECMBP);
		for (int j = 0; j != array6.Length; j += num)
		{
			MFMIFDMEPPO.DPACJDFHLKB(array6, j, array6, j);
		}
		return array6;
	}

	public virtual byte[] FKFAOFJMEEF(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP)
	{
		if (CDOHJGCEGAJ)
		{
			throw new InvalidOperationException("Not set for unwrapping");
		}
		if (MOPCLEEGDFB == null)
		{
			throw new InvalidCipherTextException("Null pointer as ciphertext");
		}
		int num = MFMIFDMEPPO.BDIGGHEPIIP();
		if (EOFAGACBNFP % num != 0)
		{
			throw new InvalidCipherTextException("Ciphertext not multiple of " + num);
		}
		CHCELGDKEJG iJJHBEECMBP = new CHCELGDKEJG(BOFHHECPKNF, DLFFGENGALL);
		MFMIFDMEPPO.DIOELAHNLKJ(false, iJJHBEECMBP);
		byte[] array = new byte[EOFAGACBNFP];
		for (int i = 0; i != array.Length; i += num)
		{
			MFMIFDMEPPO.DPACJDFHLKB(MOPCLEEGDFB, ELICNEDIBGB + i, array, i);
		}
		byte[] array2 = CDCGFGHDMBA(array);
		NDEFBOJOALL = new byte[8];
		byte[] array3 = new byte[array2.Length - 8];
		Array.Copy(array2, 0, NDEFBOJOALL, 0, 8);
		Array.Copy(array2, 8, array3, 0, array2.Length - 8);
		LKBCCFNAEGP = new CHCELGDKEJG(BOFHHECPKNF, NDEFBOJOALL);
		MFMIFDMEPPO.DIOELAHNLKJ(false, LKBCCFNAEGP);
		byte[] array4 = new byte[array3.Length];
		for (int j = 0; j != array4.Length; j += num)
		{
			MFMIFDMEPPO.DPACJDFHLKB(array3, j, array4, j);
		}
		byte[] array5 = new byte[array4.Length - 8];
		byte[] array6 = new byte[8];
		Array.Copy(array4, 0, array5, 0, array4.Length - 8);
		Array.Copy(array4, array4.Length - 8, array6, 0, 8);
		if (!FAPDILANLEO(array5, array6))
		{
			throw new InvalidCipherTextException("Checksum inside ciphertext is corrupted");
		}
		return array5;
	}

	private byte[] KIBEBLJOBAF(byte[] IKNCPEPOKGJ)
	{
		MLBEIDJMHFI.GONEEEFEDGF(IKNCPEPOKGJ, 0, IKNCPEPOKGJ.Length);
		MLBEIDJMHFI.LCNOFBMOHHM(HABFKBCEIBN, 0);
		byte[] array = new byte[8];
		Array.Copy(HABFKBCEIBN, 0, array, 0, 8);
		return array;
	}

	private bool FAPDILANLEO(byte[] IKNCPEPOKGJ, byte[] NEOAHOMMJAG)
	{
		return NOGCEBKPPJE.PBBFCJBKJEN(KIBEBLJOBAF(IKNCPEPOKGJ), NEOAHOMMJAG);
	}

	private static byte[] CDCGFGHDMBA(byte[] FAPGOCDNGIB)
	{
		byte[] array = new byte[FAPGOCDNGIB.Length];
		for (int i = 0; i < FAPGOCDNGIB.Length; i++)
		{
			array[i] = FAPGOCDNGIB[FAPGOCDNGIB.Length - (i + 1)];
		}
		return array;
	}
}
