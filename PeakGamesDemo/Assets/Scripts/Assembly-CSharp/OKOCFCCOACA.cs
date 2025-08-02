using System;
using Org.BouncyCastle.Crypto;

public class OKOCFCCOACA : HLDJIHIKIEB
{
	private readonly KPMKFMEEJCJ IEDPBFAFGGJ;

	public override string KFKMEPMEBND
	{
		get
		{
			return IEDPBFAFGGJ.KFKMEPMEBND;
		}
	}

	public OKOCFCCOACA(KPMKFMEEJCJ IEDPBFAFGGJ)
	{
		if (IEDPBFAFGGJ == null)
		{
			throw new ArgumentNullException("cipher");
		}
		this.IEDPBFAFGGJ = IEDPBFAFGGJ;
	}

	public override void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		if (IJJHBEECMBP is MDAKJDOFCEP)
		{
			IJJHBEECMBP = ((MDAKJDOFCEP)IJJHBEECMBP).KPJHHAAOFOH;
		}
		IEDPBFAFGGJ.DIOELAHNLKJ(MAEALKEJALK, IJJHBEECMBP);
	}

	public override int BDIGGHEPIIP()
	{
		return 0;
	}

	public override int ACLDAECDPFN(int HAPPHECIDKJ)
	{
		return HAPPHECIDKJ;
	}

	public override int MIMJCMAODEK(int HAPPHECIDKJ)
	{
		return HAPPHECIDKJ;
	}

	public override byte[] HBCJNPGKMDP(byte MOPCLEEGDFB)
	{
		return new byte[1] { IEDPBFAFGGJ.IODEANDNHIP(MOPCLEEGDFB) };
	}

	public override int HBCJNPGKMDP(byte MOPCLEEGDFB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		if (EMAKNGBIFDC >= BILGCJNPJGJ.Length)
		{
			throw new DataLengthException("output buffer too short");
		}
		BILGCJNPJGJ[EMAKNGBIFDC] = IEDPBFAFGGJ.IODEANDNHIP(MOPCLEEGDFB);
		return 1;
	}

	public override byte[] POCAGALIPAI(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP)
	{
		if (EOFAGACBNFP < 1)
		{
			return null;
		}
		byte[] array = new byte[EOFAGACBNFP];
		IEDPBFAFGGJ.POCAGALIPAI(MOPCLEEGDFB, ELICNEDIBGB, EOFAGACBNFP, array, 0);
		return array;
	}

	public override int POCAGALIPAI(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		if (EOFAGACBNFP < 1)
		{
			return 0;
		}
		if (EOFAGACBNFP > 0)
		{
			IEDPBFAFGGJ.POCAGALIPAI(MOPCLEEGDFB, ELICNEDIBGB, EOFAGACBNFP, BILGCJNPJGJ, EMAKNGBIFDC);
		}
		return EOFAGACBNFP;
	}

	public override byte[] LCNOFBMOHHM()
	{
		OMOKOKFNBKI();
		return HLDJIHIKIEB.FKFAEPHOLIB;
	}

	public override byte[] LCNOFBMOHHM(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP)
	{
		if (EOFAGACBNFP < 1)
		{
			return HLDJIHIKIEB.FKFAEPHOLIB;
		}
		byte[] result = POCAGALIPAI(MOPCLEEGDFB, ELICNEDIBGB, EOFAGACBNFP);
		OMOKOKFNBKI();
		return result;
	}

	public override void OMOKOKFNBKI()
	{
		IEDPBFAFGGJ.OMOKOKFNBKI();
	}
}
