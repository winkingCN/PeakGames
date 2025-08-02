using System;

public abstract class EEBNPONHKOK : BJLAMONNNDD, MIPBJNJHNGA
{
	private const int DKJNJMLHHFD = 64;

	private byte[] LNELIAIKLBD;

	private int KBDJMHLAHLE;

	private long NAAHEJKGFAA;

	public abstract string KFKMEPMEBND { get; }

	internal EEBNPONHKOK()
	{
		LNELIAIKLBD = new byte[4];
	}

	internal EEBNPONHKOK(EEBNPONHKOK LLIEHCKNJEM)
	{
		LNELIAIKLBD = new byte[LLIEHCKNJEM.LNELIAIKLBD.Length];
		AKBPCECABIO(LLIEHCKNJEM);
	}

	protected void AKBPCECABIO(EEBNPONHKOK LLIEHCKNJEM)
	{
		Array.Copy(LLIEHCKNJEM.LNELIAIKLBD, 0, LNELIAIKLBD, 0, LLIEHCKNJEM.LNELIAIKLBD.Length);
		KBDJMHLAHLE = LLIEHCKNJEM.KBDJMHLAHLE;
		NAAHEJKGFAA = LLIEHCKNJEM.NAAHEJKGFAA;
	}

	public void BPAJGOINFNL(byte MOPCLEEGDFB)
	{
		LNELIAIKLBD[KBDJMHLAHLE++] = MOPCLEEGDFB;
		if (KBDJMHLAHLE == LNELIAIKLBD.Length)
		{
			ICKIHAABCPI(LNELIAIKLBD, 0);
			KBDJMHLAHLE = 0;
		}
		NAAHEJKGFAA++;
	}

	public void GONEEEFEDGF(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP)
	{
		EOFAGACBNFP = Math.Max(0, EOFAGACBNFP);
		int i = 0;
		if (KBDJMHLAHLE != 0)
		{
			while (i < EOFAGACBNFP)
			{
				LNELIAIKLBD[KBDJMHLAHLE++] = MOPCLEEGDFB[ELICNEDIBGB + i++];
				if (KBDJMHLAHLE == 4)
				{
					ICKIHAABCPI(LNELIAIKLBD, 0);
					KBDJMHLAHLE = 0;
					break;
				}
			}
		}
		for (int num = ((EOFAGACBNFP - i) & -4) + i; i < num; i += 4)
		{
			ICKIHAABCPI(MOPCLEEGDFB, ELICNEDIBGB + i);
		}
		while (i < EOFAGACBNFP)
		{
			LNELIAIKLBD[KBDJMHLAHLE++] = MOPCLEEGDFB[ELICNEDIBGB + i++];
		}
		NAAHEJKGFAA += EOFAGACBNFP;
	}

	public void OJILOEAPDCL()
	{
		long eAJFCEBGGIG = NAAHEJKGFAA << 3;
		BPAJGOINFNL(128);
		while (KBDJMHLAHLE != 0)
		{
			BPAJGOINFNL(0);
		}
		IIENDLEDGMC(eAJFCEBGGIG);
		DPACJDFHLKB();
	}

	public virtual void OMOKOKFNBKI()
	{
		NAAHEJKGFAA = 0L;
		KBDJMHLAHLE = 0;
		Array.Clear(LNELIAIKLBD, 0, LNELIAIKLBD.Length);
	}

	public int MNAIJEEKPCP()
	{
		return 64;
	}

	internal abstract void ICKIHAABCPI(byte[] MOPCLEEGDFB, int ELICNEDIBGB);

	internal abstract void IIENDLEDGMC(long EAJFCEBGGIG);

	internal abstract void DPACJDFHLKB();

	public abstract int EEMLLAMENHO();

	public abstract int LCNOFBMOHHM(byte[] BILGCJNPJGJ, int EMAKNGBIFDC);

	public abstract MIPBJNJHNGA FDCFKGAEJFF();

	public abstract void OMOKOKFNBKI(MIPBJNJHNGA LLIEHCKNJEM);
}
