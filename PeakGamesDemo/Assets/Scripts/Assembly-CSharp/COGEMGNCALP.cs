using System;
using Org.BouncyCastle.Crypto;

public class COGEMGNCALP : EIFKCBHBLFB
{
	private readonly ELGNLPAGPNI HFHKPBBFDFD;

	public COGEMGNCALP(JMPFLJGHAIM IEDPBFAFGGJ, ELGNLPAGPNI HFHKPBBFDFD)
	{
		base.IEDPBFAFGGJ = IEDPBFAFGGJ;
		this.HFHKPBBFDFD = HFHKPBBFDFD;
		GHPCHPOHELF = new byte[IEDPBFAFGGJ.BDIGGHEPIIP()];
		MNIGMJPFNDA = 0;
	}

	public COGEMGNCALP(JMPFLJGHAIM IEDPBFAFGGJ)
		: this(IEDPBFAFGGJ, new LFOABAOFCGD())
	{
	}

	public override void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		base.MAEALKEJALK = MAEALKEJALK;
		FBIJJFGLKMK gECCLOFELEC = null;
		if (IJJHBEECMBP is MDAKJDOFCEP)
		{
			MDAKJDOFCEP mDAKJDOFCEP = (MDAKJDOFCEP)IJJHBEECMBP;
			gECCLOFELEC = mDAKJDOFCEP.IPFKDIJBGIM;
			IJJHBEECMBP = mDAKJDOFCEP.KPJHHAAOFOH;
		}
		OMOKOKFNBKI();
		HFHKPBBFDFD.DIOELAHNLKJ(gECCLOFELEC);
		IEDPBFAFGGJ.DIOELAHNLKJ(MAEALKEJALK, IJJHBEECMBP);
	}

	public override int ACLDAECDPFN(int EOFAGACBNFP)
	{
		int num = EOFAGACBNFP + MNIGMJPFNDA;
		int num2 = num % GHPCHPOHELF.Length;
		if (num2 == 0)
		{
			if (MAEALKEJALK)
			{
				return num + GHPCHPOHELF.Length;
			}
			return num;
		}
		return num - num2 + GHPCHPOHELF.Length;
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

	public override int HBCJNPGKMDP(byte MOPCLEEGDFB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		int result = 0;
		if (MNIGMJPFNDA == GHPCHPOHELF.Length)
		{
			result = IEDPBFAFGGJ.DPACJDFHLKB(GHPCHPOHELF, 0, BILGCJNPJGJ, EMAKNGBIFDC);
			MNIGMJPFNDA = 0;
		}
		GHPCHPOHELF[MNIGMJPFNDA++] = MOPCLEEGDFB;
		return result;
	}

	public override int POCAGALIPAI(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		if (EOFAGACBNFP < 0)
		{
			throw new ArgumentException("Can't have a negative input length!");
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
		return num3;
	}

	public override int LCNOFBMOHHM(byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		int num = IEDPBFAFGGJ.BDIGGHEPIIP();
		int num2 = 0;
		if (MAEALKEJALK)
		{
			if (MNIGMJPFNDA == num)
			{
				if (EMAKNGBIFDC + 2 * num > BILGCJNPJGJ.Length)
				{
					OMOKOKFNBKI();
					throw new OutputLengthException("output buffer too short");
				}
				num2 = IEDPBFAFGGJ.DPACJDFHLKB(GHPCHPOHELF, 0, BILGCJNPJGJ, EMAKNGBIFDC);
				MNIGMJPFNDA = 0;
			}
			HFHKPBBFDFD.MDNFIGPPOFC(GHPCHPOHELF, MNIGMJPFNDA);
			num2 += IEDPBFAFGGJ.DPACJDFHLKB(GHPCHPOHELF, 0, BILGCJNPJGJ, EMAKNGBIFDC + num2);
			OMOKOKFNBKI();
		}
		else
		{
			if (MNIGMJPFNDA != num)
			{
				OMOKOKFNBKI();
				throw new DataLengthException("last block incomplete in decryption");
			}
			num2 = IEDPBFAFGGJ.DPACJDFHLKB(GHPCHPOHELF, 0, GHPCHPOHELF, 0);
			MNIGMJPFNDA = 0;
			try
			{
				num2 -= HFHKPBBFDFD.HIEMLFAHLFO(GHPCHPOHELF);
				Array.Copy(GHPCHPOHELF, 0, BILGCJNPJGJ, EMAKNGBIFDC, num2);
			}
			finally
			{
				OMOKOKFNBKI();
			}
		}
		return num2;
	}
}
