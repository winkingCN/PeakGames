using System;
using Org.BouncyCastle.Crypto;

public class EIFKCBHBLFB : HLDJIHIKIEB
{
	internal byte[] GHPCHPOHELF;

	internal int MNIGMJPFNDA;

	internal bool MAEALKEJALK;

	internal JMPFLJGHAIM IEDPBFAFGGJ;

	public override string KFKMEPMEBND
	{
		get
		{
			return IEDPBFAFGGJ.KFKMEPMEBND;
		}
	}

	protected EIFKCBHBLFB()
	{
	}

	public EIFKCBHBLFB(JMPFLJGHAIM IEDPBFAFGGJ)
	{
		if (IEDPBFAFGGJ == null)
		{
			throw new ArgumentNullException("cipher");
		}
		this.IEDPBFAFGGJ = IEDPBFAFGGJ;
		GHPCHPOHELF = new byte[IEDPBFAFGGJ.BDIGGHEPIIP()];
		MNIGMJPFNDA = 0;
	}

	public override void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		this.MAEALKEJALK = MAEALKEJALK;
		MDAKJDOFCEP mDAKJDOFCEP = IJJHBEECMBP as MDAKJDOFCEP;
		if (mDAKJDOFCEP != null)
		{
			IJJHBEECMBP = mDAKJDOFCEP.KPJHHAAOFOH;
		}
		OMOKOKFNBKI();
		IEDPBFAFGGJ.DIOELAHNLKJ(MAEALKEJALK, IJJHBEECMBP);
	}

	public override int BDIGGHEPIIP()
	{
		return IEDPBFAFGGJ.BDIGGHEPIIP();
	}

	public override int MIMJCMAODEK(int EOFAGACBNFP)
	{
		int num = EOFAGACBNFP + MNIGMJPFNDA;
		int num2 = num % GHPCHPOHELF.Length;
		return num - num2;
	}

	public override int ACLDAECDPFN(int EOFAGACBNFP)
	{
		return EOFAGACBNFP + MNIGMJPFNDA;
	}

	public override int HBCJNPGKMDP(byte MOPCLEEGDFB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		GHPCHPOHELF[MNIGMJPFNDA++] = MOPCLEEGDFB;
		if (MNIGMJPFNDA == GHPCHPOHELF.Length)
		{
			if (EMAKNGBIFDC + GHPCHPOHELF.Length > BILGCJNPJGJ.Length)
			{
				throw new DataLengthException("output buffer too short");
			}
			MNIGMJPFNDA = 0;
			return IEDPBFAFGGJ.DPACJDFHLKB(GHPCHPOHELF, 0, BILGCJNPJGJ, EMAKNGBIFDC);
		}
		return 0;
	}

	public override byte[] HBCJNPGKMDP(byte MOPCLEEGDFB)
	{
		int num = MIMJCMAODEK(1);
		byte[] array = ((num <= 0) ? null : new byte[num]);
		int num2 = HBCJNPGKMDP(MOPCLEEGDFB, array, 0);
		if (num > 0 && num2 < num)
		{
			byte[] array2 = new byte[num2];
			Array.Copy(array, 0, array2, 0, num2);
			array = array2;
		}
		return array;
	}

	public override byte[] POCAGALIPAI(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP)
	{
		if (MOPCLEEGDFB == null)
		{
			throw new ArgumentNullException("input");
		}
		if (EOFAGACBNFP < 1)
		{
			return null;
		}
		int num = MIMJCMAODEK(EOFAGACBNFP);
		byte[] array = ((num <= 0) ? null : new byte[num]);
		int num2 = POCAGALIPAI(MOPCLEEGDFB, ELICNEDIBGB, EOFAGACBNFP, array, 0);
		if (num > 0 && num2 < num)
		{
			byte[] array2 = new byte[num2];
			Array.Copy(array, 0, array2, 0, num2);
			array = array2;
		}
		return array;
	}

	public override int POCAGALIPAI(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		if (EOFAGACBNFP < 1)
		{
			if (EOFAGACBNFP < 0)
			{
				throw new ArgumentException("Can't have a negative input length!");
			}
			return 0;
		}
		int num = BDIGGHEPIIP();
		int num2 = MIMJCMAODEK(EOFAGACBNFP);
		if (num2 > 0)
		{
			AJLDFGNHDCA.KLPNFGNKNKB(BILGCJNPJGJ, EMAKNGBIFDC, num2, "output buffer too short");
		}
		int num3 = 0;
		int num4 = GHPCHPOHELF.Length - MNIGMJPFNDA;
		if (EOFAGACBNFP > num4)
		{
			Array.Copy(MOPCLEEGDFB, ELICNEDIBGB, GHPCHPOHELF, MNIGMJPFNDA, num4);
			num3 += IEDPBFAFGGJ.DPACJDFHLKB(GHPCHPOHELF, 0, BILGCJNPJGJ, EMAKNGBIFDC);
			MNIGMJPFNDA = 0;
			EOFAGACBNFP -= num4;
			ELICNEDIBGB += num4;
			while (EOFAGACBNFP > GHPCHPOHELF.Length)
			{
				num3 += IEDPBFAFGGJ.DPACJDFHLKB(MOPCLEEGDFB, ELICNEDIBGB, BILGCJNPJGJ, EMAKNGBIFDC + num3);
				EOFAGACBNFP -= num;
				ELICNEDIBGB += num;
			}
		}
		Array.Copy(MOPCLEEGDFB, ELICNEDIBGB, GHPCHPOHELF, MNIGMJPFNDA, EOFAGACBNFP);
		MNIGMJPFNDA += EOFAGACBNFP;
		if (MNIGMJPFNDA == GHPCHPOHELF.Length)
		{
			num3 += IEDPBFAFGGJ.DPACJDFHLKB(GHPCHPOHELF, 0, BILGCJNPJGJ, EMAKNGBIFDC + num3);
			MNIGMJPFNDA = 0;
		}
		return num3;
	}

	public override byte[] LCNOFBMOHHM()
	{
		byte[] array = HLDJIHIKIEB.FKFAEPHOLIB;
		int num = ACLDAECDPFN(0);
		if (num > 0)
		{
			array = new byte[num];
			int num2 = LCNOFBMOHHM(array, 0);
			if (num2 < array.Length)
			{
				byte[] array2 = new byte[num2];
				Array.Copy(array, 0, array2, 0, num2);
				array = array2;
			}
		}
		else
		{
			OMOKOKFNBKI();
		}
		return array;
	}

	public override byte[] LCNOFBMOHHM(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int DBGBBFPPDCE)
	{
		if (MOPCLEEGDFB == null)
		{
			throw new ArgumentNullException("input");
		}
		int num = ACLDAECDPFN(DBGBBFPPDCE);
		byte[] array = HLDJIHIKIEB.FKFAEPHOLIB;
		if (num > 0)
		{
			array = new byte[num];
			int num2 = ((DBGBBFPPDCE > 0) ? POCAGALIPAI(MOPCLEEGDFB, ELICNEDIBGB, DBGBBFPPDCE, array, 0) : 0);
			num2 += LCNOFBMOHHM(array, num2);
			if (num2 < array.Length)
			{
				byte[] array2 = new byte[num2];
				Array.Copy(array, 0, array2, 0, num2);
				array = array2;
			}
		}
		else
		{
			OMOKOKFNBKI();
		}
		return array;
	}

	public override int LCNOFBMOHHM(byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		try
		{
			if (MNIGMJPFNDA != 0)
			{
				AJLDFGNHDCA.OONDALLFPOP(!IEDPBFAFGGJ.ABNLKPDCGEF, "data not block size aligned");
				AJLDFGNHDCA.KLPNFGNKNKB(BILGCJNPJGJ, EMAKNGBIFDC, MNIGMJPFNDA, "output buffer too short for DoFinal()");
				IEDPBFAFGGJ.DPACJDFHLKB(GHPCHPOHELF, 0, GHPCHPOHELF, 0);
				Array.Copy(GHPCHPOHELF, 0, BILGCJNPJGJ, EMAKNGBIFDC, MNIGMJPFNDA);
			}
			return MNIGMJPFNDA;
		}
		finally
		{
			OMOKOKFNBKI();
		}
	}

	public override void OMOKOKFNBKI()
	{
		Array.Clear(GHPCHPOHELF, 0, GHPCHPOHELF.Length);
		MNIGMJPFNDA = 0;
		IEDPBFAFGGJ.OMOKOKFNBKI();
	}
}
