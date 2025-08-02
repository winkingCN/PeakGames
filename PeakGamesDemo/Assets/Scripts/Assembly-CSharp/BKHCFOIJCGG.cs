using System;
using Org.BouncyCastle.Crypto;

public class BKHCFOIJCGG : IEKIBBAKJDP
{
	private readonly JMPFLJGHAIM MFMIFDMEPPO;

	private JEMNCGMEABF BOFHHECPKNF;

	private bool CDOHJGCEGAJ;

	private byte[] NDEFBOJOALL = new byte[8] { 166, 166, 166, 166, 166, 166, 166, 166 };

	public virtual string KFKMEPMEBND
	{
		get
		{
			return MFMIFDMEPPO.KFKMEPMEBND;
		}
	}

	public BKHCFOIJCGG(JMPFLJGHAIM MFMIFDMEPPO)
	{
		this.MFMIFDMEPPO = MFMIFDMEPPO;
	}

	public virtual void DIOELAHNLKJ(bool CDOHJGCEGAJ, IGMAJHKIIPK IJJHBEECMBP)
	{
		this.CDOHJGCEGAJ = CDOHJGCEGAJ;
		if (IJJHBEECMBP is MDAKJDOFCEP)
		{
			IJJHBEECMBP = ((MDAKJDOFCEP)IJJHBEECMBP).KPJHHAAOFOH;
		}
		if (IJJHBEECMBP is JEMNCGMEABF)
		{
			BOFHHECPKNF = (JEMNCGMEABF)IJJHBEECMBP;
		}
		else if (IJJHBEECMBP is CHCELGDKEJG)
		{
			CHCELGDKEJG cHCELGDKEJG = (CHCELGDKEJG)IJJHBEECMBP;
			byte[] array = cHCELGDKEJG.OLAEDCABKDH();
			if (array.Length != 8)
			{
				throw new ArgumentException("IV length not equal to 8", "parameters");
			}
			NDEFBOJOALL = array;
			BOFHHECPKNF = (JEMNCGMEABF)cHCELGDKEJG.KPJHHAAOFOH;
		}
	}

	public virtual byte[] LFAFFAHKPCD(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int DBGBBFPPDCE)
	{
		if (!CDOHJGCEGAJ)
		{
			throw new InvalidOperationException("not set for wrapping");
		}
		int num = DBGBBFPPDCE / 8;
		if (num * 8 != DBGBBFPPDCE)
		{
			throw new DataLengthException("wrap data must be a multiple of 8 bytes");
		}
		byte[] array = new byte[DBGBBFPPDCE + NDEFBOJOALL.Length];
		byte[] array2 = new byte[8 + NDEFBOJOALL.Length];
		Array.Copy(NDEFBOJOALL, 0, array, 0, NDEFBOJOALL.Length);
		Array.Copy(MOPCLEEGDFB, ELICNEDIBGB, array, NDEFBOJOALL.Length, DBGBBFPPDCE);
		MFMIFDMEPPO.DIOELAHNLKJ(true, BOFHHECPKNF);
		for (int i = 0; i != 6; i++)
		{
			for (int j = 1; j <= num; j++)
			{
				Array.Copy(array, 0, array2, 0, NDEFBOJOALL.Length);
				Array.Copy(array, 8 * j, array2, NDEFBOJOALL.Length, 8);
				MFMIFDMEPPO.DPACJDFHLKB(array2, 0, array2, 0);
				int num2 = num * i + j;
				int num3 = 1;
				while (num2 != 0)
				{
					byte b = (byte)num2;
					array2[NDEFBOJOALL.Length - num3] ^= b;
					num2 = (int)((uint)num2 >> 8);
					num3++;
				}
				Array.Copy(array2, 0, array, 0, 8);
				Array.Copy(array2, 8, array, 8 * j, 8);
			}
		}
		return array;
	}

	public virtual byte[] FKFAOFJMEEF(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int DBGBBFPPDCE)
	{
		if (CDOHJGCEGAJ)
		{
			throw new InvalidOperationException("not set for unwrapping");
		}
		int num = DBGBBFPPDCE / 8;
		if (num * 8 != DBGBBFPPDCE)
		{
			throw new InvalidCipherTextException("unwrap data must be a multiple of 8 bytes");
		}
		byte[] array = new byte[DBGBBFPPDCE - NDEFBOJOALL.Length];
		byte[] array2 = new byte[NDEFBOJOALL.Length];
		byte[] array3 = new byte[8 + NDEFBOJOALL.Length];
		Array.Copy(MOPCLEEGDFB, ELICNEDIBGB, array2, 0, NDEFBOJOALL.Length);
		Array.Copy(MOPCLEEGDFB, ELICNEDIBGB + NDEFBOJOALL.Length, array, 0, DBGBBFPPDCE - NDEFBOJOALL.Length);
		MFMIFDMEPPO.DIOELAHNLKJ(false, BOFHHECPKNF);
		num--;
		for (int num2 = 5; num2 >= 0; num2--)
		{
			for (int num3 = num; num3 >= 1; num3--)
			{
				Array.Copy(array2, 0, array3, 0, NDEFBOJOALL.Length);
				Array.Copy(array, 8 * (num3 - 1), array3, NDEFBOJOALL.Length, 8);
				int num4 = num * num2 + num3;
				int num5 = 1;
				while (num4 != 0)
				{
					byte b = (byte)num4;
					array3[NDEFBOJOALL.Length - num5] ^= b;
					num4 = (int)((uint)num4 >> 8);
					num5++;
				}
				MFMIFDMEPPO.DPACJDFHLKB(array3, 0, array3, 0);
				Array.Copy(array3, 0, array2, 0, 8);
				Array.Copy(array3, 8, array, 8 * (num3 - 1), 8);
			}
		}
		if (!NOGCEBKPPJE.PBBFCJBKJEN(array2, NDEFBOJOALL))
		{
			throw new InvalidCipherTextException("checksum failed");
		}
		return array;
	}
}
