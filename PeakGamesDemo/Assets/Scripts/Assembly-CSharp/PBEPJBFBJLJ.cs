using System;
using Org.BouncyCastle.Crypto;

public class PBEPJBFBJLJ : EIFKCBHBLFB
{
	private readonly int NONHELBCKCH;

	public PBEPJBFBJLJ(JMPFLJGHAIM IEDPBFAFGGJ)
	{
		if (IEDPBFAFGGJ is CGADDGJGEAD || IEDPBFAFGGJ is EELBPGHPLOO)
		{
			throw new ArgumentException("CtsBlockCipher can only accept ECB, or CBC ciphers");
		}
		base.IEDPBFAFGGJ = IEDPBFAFGGJ;
		NONHELBCKCH = IEDPBFAFGGJ.BDIGGHEPIIP();
		GHPCHPOHELF = new byte[NONHELBCKCH * 2];
		MNIGMJPFNDA = 0;
	}

	public override int MIMJCMAODEK(int EOFAGACBNFP)
	{
		int num = EOFAGACBNFP + MNIGMJPFNDA;
		int num2 = num % GHPCHPOHELF.Length;
		if (num2 == 0)
		{
			return num - GHPCHPOHELF.Length;
		}
		return num - num2;
	}

	public override int ACLDAECDPFN(int EOFAGACBNFP)
	{
		return EOFAGACBNFP + MNIGMJPFNDA;
	}

	public override int HBCJNPGKMDP(byte MOPCLEEGDFB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		int result = 0;
		if (MNIGMJPFNDA == GHPCHPOHELF.Length)
		{
			result = IEDPBFAFGGJ.DPACJDFHLKB(GHPCHPOHELF, 0, BILGCJNPJGJ, EMAKNGBIFDC);
			Array.Copy(GHPCHPOHELF, NONHELBCKCH, GHPCHPOHELF, 0, NONHELBCKCH);
			MNIGMJPFNDA = NONHELBCKCH;
		}
		GHPCHPOHELF[MNIGMJPFNDA++] = MOPCLEEGDFB;
		return result;
	}

	public override int POCAGALIPAI(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		if (EOFAGACBNFP < 0)
		{
			throw new ArgumentException("Can't have a negative input outLength!");
		}
		int num = BDIGGHEPIIP();
		int num2 = MIMJCMAODEK(EOFAGACBNFP);
		if (num2 > 0 && EMAKNGBIFDC + num2 > BILGCJNPJGJ.Length)
		{
			throw new DataLengthException("output buffer too short");
		}
		int num3 = 0;
		int num4 = GHPCHPOHELF.Length - MNIGMJPFNDA;
		if (EOFAGACBNFP > num4)
		{
			Array.Copy(MOPCLEEGDFB, ELICNEDIBGB, GHPCHPOHELF, MNIGMJPFNDA, num4);
			num3 += IEDPBFAFGGJ.DPACJDFHLKB(GHPCHPOHELF, 0, BILGCJNPJGJ, EMAKNGBIFDC);
			Array.Copy(GHPCHPOHELF, num, GHPCHPOHELF, 0, num);
			MNIGMJPFNDA = num;
			EOFAGACBNFP -= num4;
			ELICNEDIBGB += num4;
			while (EOFAGACBNFP > num)
			{
				Array.Copy(MOPCLEEGDFB, ELICNEDIBGB, GHPCHPOHELF, MNIGMJPFNDA, num);
				num3 += IEDPBFAFGGJ.DPACJDFHLKB(GHPCHPOHELF, 0, BILGCJNPJGJ, EMAKNGBIFDC + num3);
				Array.Copy(GHPCHPOHELF, num, GHPCHPOHELF, 0, num);
				EOFAGACBNFP -= num;
				ELICNEDIBGB += num;
			}
		}
		Array.Copy(MOPCLEEGDFB, ELICNEDIBGB, GHPCHPOHELF, MNIGMJPFNDA, EOFAGACBNFP);
		MNIGMJPFNDA += EOFAGACBNFP;
		return num3;
	}

	public override int LCNOFBMOHHM(byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		if (MNIGMJPFNDA + EMAKNGBIFDC > BILGCJNPJGJ.Length)
		{
			throw new DataLengthException("output buffer too small in doFinal");
		}
		int num = IEDPBFAFGGJ.BDIGGHEPIIP();
		int length = MNIGMJPFNDA - num;
		byte[] array = new byte[num];
		if (MAEALKEJALK)
		{
			IEDPBFAFGGJ.DPACJDFHLKB(GHPCHPOHELF, 0, array, 0);
			if (MNIGMJPFNDA < num)
			{
				throw new DataLengthException("need at least one block of input for CTS");
			}
			for (int i = MNIGMJPFNDA; i != GHPCHPOHELF.Length; i++)
			{
				GHPCHPOHELF[i] = array[i - num];
			}
			for (int j = num; j != MNIGMJPFNDA; j++)
			{
				GHPCHPOHELF[j] ^= array[j - num];
			}
			JMPFLJGHAIM jMPFLJGHAIM = ((!(IEDPBFAFGGJ is OJGBFLKAPOB)) ? IEDPBFAFGGJ : ((OJGBFLKAPOB)IEDPBFAFGGJ).GBHNDFALCDC());
			jMPFLJGHAIM.DPACJDFHLKB(GHPCHPOHELF, num, BILGCJNPJGJ, EMAKNGBIFDC);
			Array.Copy(array, 0, BILGCJNPJGJ, EMAKNGBIFDC + num, length);
		}
		else
		{
			byte[] array2 = new byte[num];
			JMPFLJGHAIM jMPFLJGHAIM2 = ((!(IEDPBFAFGGJ is OJGBFLKAPOB)) ? IEDPBFAFGGJ : ((OJGBFLKAPOB)IEDPBFAFGGJ).GBHNDFALCDC());
			jMPFLJGHAIM2.DPACJDFHLKB(GHPCHPOHELF, 0, array, 0);
			for (int k = num; k != MNIGMJPFNDA; k++)
			{
				array2[k - num] = (byte)(array[k - num] ^ GHPCHPOHELF[k]);
			}
			Array.Copy(GHPCHPOHELF, num, array, 0, length);
			IEDPBFAFGGJ.DPACJDFHLKB(array, 0, BILGCJNPJGJ, EMAKNGBIFDC);
			Array.Copy(array2, 0, BILGCJNPJGJ, EMAKNGBIFDC + num, length);
		}
		int mNIGMJPFNDA = MNIGMJPFNDA;
		OMOKOKFNBKI();
		return mNIGMJPFNDA;
	}
}
