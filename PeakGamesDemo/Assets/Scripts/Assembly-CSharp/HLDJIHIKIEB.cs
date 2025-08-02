using Org.BouncyCastle.Crypto;

public abstract class HLDJIHIKIEB : AMNDAOFCJPG
{
	protected static readonly byte[] FKFAEPHOLIB = new byte[0];

	public abstract string KFKMEPMEBND { get; }

	public abstract void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP);

	public abstract int BDIGGHEPIIP();

	public abstract int ACLDAECDPFN(int HAPPHECIDKJ);

	public abstract int MIMJCMAODEK(int HAPPHECIDKJ);

	public abstract byte[] HBCJNPGKMDP(byte MOPCLEEGDFB);

	public virtual int HBCJNPGKMDP(byte MOPCLEEGDFB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		byte[] array = HBCJNPGKMDP(MOPCLEEGDFB);
		if (array == null)
		{
			return 0;
		}
		if (EMAKNGBIFDC + array.Length > BILGCJNPJGJ.Length)
		{
			throw new DataLengthException("output buffer too short");
		}
		array.CopyTo(BILGCJNPJGJ, EMAKNGBIFDC);
		return array.Length;
	}

	public virtual byte[] POCAGALIPAI(byte[] MOPCLEEGDFB)
	{
		return POCAGALIPAI(MOPCLEEGDFB, 0, MOPCLEEGDFB.Length);
	}

	public abstract byte[] POCAGALIPAI(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP);

	public virtual int POCAGALIPAI(byte[] MOPCLEEGDFB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		return POCAGALIPAI(MOPCLEEGDFB, 0, MOPCLEEGDFB.Length, BILGCJNPJGJ, EMAKNGBIFDC);
	}

	public virtual int POCAGALIPAI(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		byte[] array = POCAGALIPAI(MOPCLEEGDFB, ELICNEDIBGB, EOFAGACBNFP);
		if (array == null)
		{
			return 0;
		}
		if (EMAKNGBIFDC + array.Length > BILGCJNPJGJ.Length)
		{
			throw new DataLengthException("output buffer too short");
		}
		array.CopyTo(BILGCJNPJGJ, EMAKNGBIFDC);
		return array.Length;
	}

	public abstract byte[] LCNOFBMOHHM();

	public virtual byte[] LCNOFBMOHHM(byte[] MOPCLEEGDFB)
	{
		return LCNOFBMOHHM(MOPCLEEGDFB, 0, MOPCLEEGDFB.Length);
	}

	public abstract byte[] LCNOFBMOHHM(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP);

	public virtual int LCNOFBMOHHM(byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		byte[] array = LCNOFBMOHHM();
		if (EMAKNGBIFDC + array.Length > BILGCJNPJGJ.Length)
		{
			throw new DataLengthException("output buffer too short");
		}
		array.CopyTo(BILGCJNPJGJ, EMAKNGBIFDC);
		return array.Length;
	}

	public virtual int LCNOFBMOHHM(byte[] MOPCLEEGDFB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		return LCNOFBMOHHM(MOPCLEEGDFB, 0, MOPCLEEGDFB.Length, BILGCJNPJGJ, EMAKNGBIFDC);
	}

	public virtual int LCNOFBMOHHM(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		int num = POCAGALIPAI(MOPCLEEGDFB, ELICNEDIBGB, EOFAGACBNFP, BILGCJNPJGJ, EMAKNGBIFDC);
		return num + LCNOFBMOHHM(BILGCJNPJGJ, EMAKNGBIFDC + num);
	}

	public abstract void OMOKOKFNBKI();
}
