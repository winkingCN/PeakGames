using System;

public class FPCIFCOMPHB : HLDJIHIKIEB
{
	private readonly KJLBDGGBCCF IEDPBFAFGGJ;

	public override string KFKMEPMEBND
	{
		get
		{
			return IEDPBFAFGGJ.KFKMEPMEBND;
		}
	}

	public FPCIFCOMPHB(KJLBDGGBCCF IEDPBFAFGGJ)
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
		return IEDPBFAFGGJ.BDIGGHEPIIP();
	}

	public override int MIMJCMAODEK(int EOFAGACBNFP)
	{
		return IEDPBFAFGGJ.MIMJCMAODEK(EOFAGACBNFP);
	}

	public override int ACLDAECDPFN(int EOFAGACBNFP)
	{
		return IEDPBFAFGGJ.ACLDAECDPFN(EOFAGACBNFP);
	}

	public override int HBCJNPGKMDP(byte MOPCLEEGDFB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		return IEDPBFAFGGJ.HBCJNPGKMDP(MOPCLEEGDFB, BILGCJNPJGJ, EMAKNGBIFDC);
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
		return IEDPBFAFGGJ.POCAGALIPAI(MOPCLEEGDFB, ELICNEDIBGB, EOFAGACBNFP, BILGCJNPJGJ, EMAKNGBIFDC);
	}

	public override byte[] LCNOFBMOHHM()
	{
		byte[] array = new byte[ACLDAECDPFN(0)];
		int num = LCNOFBMOHHM(array, 0);
		if (num < array.Length)
		{
			byte[] array2 = new byte[num];
			Array.Copy(array, 0, array2, 0, num);
			array = array2;
		}
		return array;
	}

	public override byte[] LCNOFBMOHHM(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int DBGBBFPPDCE)
	{
		if (MOPCLEEGDFB == null)
		{
			throw new ArgumentNullException("input");
		}
		byte[] array = new byte[ACLDAECDPFN(DBGBBFPPDCE)];
		int num = ((DBGBBFPPDCE > 0) ? POCAGALIPAI(MOPCLEEGDFB, ELICNEDIBGB, DBGBBFPPDCE, array, 0) : 0);
		num += LCNOFBMOHHM(array, num);
		if (num < array.Length)
		{
			byte[] array2 = new byte[num];
			Array.Copy(array, 0, array2, 0, num);
			array = array2;
		}
		return array;
	}

	public override int LCNOFBMOHHM(byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		return IEDPBFAFGGJ.LCNOFBMOHHM(BILGCJNPJGJ, EMAKNGBIFDC);
	}

	public override void OMOKOKFNBKI()
	{
		IEDPBFAFGGJ.OMOKOKFNBKI();
	}
}
