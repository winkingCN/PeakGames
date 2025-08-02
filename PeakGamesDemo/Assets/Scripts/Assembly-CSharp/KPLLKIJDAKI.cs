using System;
using Org.BouncyCastle.Crypto;

public class KPLLKIJDAKI : IEKIBBAKJDP
{
	private OJGBFLKAPOB MFMIFDMEPPO;

	private IGMAJHKIIPK IJJHBEECMBP;

	private CHCELGDKEJG LKBCCFNAEGP;

	private byte[] NDEFBOJOALL;

	private bool CDOHJGCEGAJ;

	private FBIJJFGLKMK PMEDIPOOFHE;

	private static readonly byte[] DLFFGENGALL = new byte[8] { 74, 221, 162, 44, 121, 232, 33, 5 };

	private BJLAMONNNDD MLBEIDJMHFI = new KALMDEHGEAC();

	private byte[] HABFKBCEIBN = new byte[20];

	public virtual string KFKMEPMEBND
	{
		get
		{
			return "RC2";
		}
	}

	public virtual void DIOELAHNLKJ(bool CDOHJGCEGAJ, IGMAJHKIIPK IJJHBEECMBP)
	{
		this.CDOHJGCEGAJ = CDOHJGCEGAJ;
		MFMIFDMEPPO = new OJGBFLKAPOB(new IBGFIJHNBAL());
		if (IJJHBEECMBP is MDAKJDOFCEP)
		{
			MDAKJDOFCEP mDAKJDOFCEP = (MDAKJDOFCEP)IJJHBEECMBP;
			PMEDIPOOFHE = mDAKJDOFCEP.IPFKDIJBGIM;
			IJJHBEECMBP = mDAKJDOFCEP.KPJHHAAOFOH;
		}
		else
		{
			PMEDIPOOFHE = new FBIJJFGLKMK();
		}
		if (IJJHBEECMBP is CHCELGDKEJG)
		{
			if (!CDOHJGCEGAJ)
			{
				throw new ArgumentException("You should not supply an IV for unwrapping");
			}
			LKBCCFNAEGP = (CHCELGDKEJG)IJJHBEECMBP;
			NDEFBOJOALL = LKBCCFNAEGP.OLAEDCABKDH();
			this.IJJHBEECMBP = LKBCCFNAEGP.KPJHHAAOFOH;
			if (NDEFBOJOALL.Length != 8)
			{
				throw new ArgumentException("IV is not 8 octets");
			}
		}
		else
		{
			this.IJJHBEECMBP = IJJHBEECMBP;
			if (this.CDOHJGCEGAJ)
			{
				NDEFBOJOALL = new byte[8];
				PMEDIPOOFHE.NextBytes(NDEFBOJOALL);
				LKBCCFNAEGP = new CHCELGDKEJG(this.IJJHBEECMBP, NDEFBOJOALL);
			}
		}
	}

	public virtual byte[] LFAFFAHKPCD(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP)
	{
		if (!CDOHJGCEGAJ)
		{
			throw new InvalidOperationException("Not initialized for wrapping");
		}
		int num = EOFAGACBNFP + 1;
		if (num % 8 != 0)
		{
			num += 8 - num % 8;
		}
		byte[] array = new byte[num];
		array[0] = (byte)EOFAGACBNFP;
		Array.Copy(MOPCLEEGDFB, ELICNEDIBGB, array, 1, EOFAGACBNFP);
		byte[] array2 = new byte[array.Length - EOFAGACBNFP - 1];
		if (array2.Length > 0)
		{
			PMEDIPOOFHE.NextBytes(array2);
			Array.Copy(array2, 0, array, EOFAGACBNFP + 1, array2.Length);
		}
		byte[] array3 = KIBEBLJOBAF(array);
		byte[] array4 = new byte[array.Length + array3.Length];
		Array.Copy(array, 0, array4, 0, array.Length);
		Array.Copy(array3, 0, array4, array.Length, array3.Length);
		byte[] array5 = new byte[array4.Length];
		Array.Copy(array4, 0, array5, 0, array4.Length);
		int num2 = array4.Length / MFMIFDMEPPO.BDIGGHEPIIP();
		if (array4.Length % MFMIFDMEPPO.BDIGGHEPIIP() != 0)
		{
			throw new InvalidOperationException("Not multiple of block length");
		}
		MFMIFDMEPPO.DIOELAHNLKJ(true, LKBCCFNAEGP);
		for (int i = 0; i < num2; i++)
		{
			int num3 = i * MFMIFDMEPPO.BDIGGHEPIIP();
			MFMIFDMEPPO.DPACJDFHLKB(array5, num3, array5, num3);
		}
		byte[] array6 = new byte[NDEFBOJOALL.Length + array5.Length];
		Array.Copy(NDEFBOJOALL, 0, array6, 0, NDEFBOJOALL.Length);
		Array.Copy(array5, 0, array6, NDEFBOJOALL.Length, array5.Length);
		byte[] array7 = new byte[array6.Length];
		for (int j = 0; j < array6.Length; j++)
		{
			array7[j] = array6[array6.Length - (j + 1)];
		}
		CHCELGDKEJG iJJHBEECMBP = new CHCELGDKEJG(IJJHBEECMBP, DLFFGENGALL);
		MFMIFDMEPPO.DIOELAHNLKJ(true, iJJHBEECMBP);
		for (int k = 0; k < num2 + 1; k++)
		{
			int num4 = k * MFMIFDMEPPO.BDIGGHEPIIP();
			MFMIFDMEPPO.DPACJDFHLKB(array7, num4, array7, num4);
		}
		return array7;
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
		if (EOFAGACBNFP % MFMIFDMEPPO.BDIGGHEPIIP() != 0)
		{
			throw new InvalidCipherTextException("Ciphertext not multiple of " + MFMIFDMEPPO.BDIGGHEPIIP());
		}
		CHCELGDKEJG iJJHBEECMBP = new CHCELGDKEJG(IJJHBEECMBP, DLFFGENGALL);
		MFMIFDMEPPO.DIOELAHNLKJ(false, iJJHBEECMBP);
		byte[] array = new byte[EOFAGACBNFP];
		Array.Copy(MOPCLEEGDFB, ELICNEDIBGB, array, 0, EOFAGACBNFP);
		for (int i = 0; i < array.Length / MFMIFDMEPPO.BDIGGHEPIIP(); i++)
		{
			int num = i * MFMIFDMEPPO.BDIGGHEPIIP();
			MFMIFDMEPPO.DPACJDFHLKB(array, num, array, num);
		}
		byte[] array2 = new byte[array.Length];
		for (int j = 0; j < array.Length; j++)
		{
			array2[j] = array[array.Length - (j + 1)];
		}
		NDEFBOJOALL = new byte[8];
		byte[] array3 = new byte[array2.Length - 8];
		Array.Copy(array2, 0, NDEFBOJOALL, 0, 8);
		Array.Copy(array2, 8, array3, 0, array2.Length - 8);
		LKBCCFNAEGP = new CHCELGDKEJG(IJJHBEECMBP, NDEFBOJOALL);
		MFMIFDMEPPO.DIOELAHNLKJ(false, LKBCCFNAEGP);
		byte[] array4 = new byte[array3.Length];
		Array.Copy(array3, 0, array4, 0, array3.Length);
		for (int k = 0; k < array4.Length / MFMIFDMEPPO.BDIGGHEPIIP(); k++)
		{
			int num2 = k * MFMIFDMEPPO.BDIGGHEPIIP();
			MFMIFDMEPPO.DPACJDFHLKB(array4, num2, array4, num2);
		}
		byte[] array5 = new byte[array4.Length - 8];
		byte[] array6 = new byte[8];
		Array.Copy(array4, 0, array5, 0, array4.Length - 8);
		Array.Copy(array4, array4.Length - 8, array6, 0, 8);
		if (!FAPDILANLEO(array5, array6))
		{
			throw new InvalidCipherTextException("Checksum inside ciphertext is corrupted");
		}
		if (array5.Length - ((array5[0] & 0xFF) + 1) > 7)
		{
			throw new InvalidCipherTextException("too many pad bytes (" + (array5.Length - ((array5[0] & 0xFF) + 1)) + ")");
		}
		byte[] array7 = new byte[array5[0]];
		Array.Copy(array5, 1, array7, 0, array7.Length);
		return array7;
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
}
