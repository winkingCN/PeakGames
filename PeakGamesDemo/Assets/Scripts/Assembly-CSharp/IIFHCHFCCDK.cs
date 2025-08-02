using System;

internal class IIFHCHFCCDK : POBPBLILLLP
{
	internal readonly byte[] PEOEEHMNKCH;

	internal CBKKCJFENJM KBNPIGOEJEE;

	public virtual byte[] GLPODMDPMAK
	{
		get
		{
			lock (this)
			{
				return PEOEEHMNKCH;
			}
		}
	}

	public virtual bool JLHAIGPFGAL
	{
		get
		{
			lock (this)
			{
				return KBNPIGOEJEE != null;
			}
		}
	}

	internal IIFHCHFCCDK(byte[] OEPIOANFJDF, CBKKCJFENJM PPPNGBDMPGG)
	{
		if (OEPIOANFJDF == null)
		{
			throw new ArgumentNullException("sessionID");
		}
		if (OEPIOANFJDF.Length < 1 || OEPIOANFJDF.Length > 32)
		{
			throw new ArgumentException("must have length between 1 and 32 bytes, inclusive", "sessionID");
		}
		PEOEEHMNKCH = NOGCEBKPPJE.IKBFGGABMKP(OEPIOANFJDF);
		KBNPIGOEJEE = PPPNGBDMPGG;
	}

	public virtual CBKKCJFENJM BBELHFEBKHO()
	{
		lock (this)
		{
			return (KBNPIGOEJEE != null) ? KBNPIGOEJEE.FDCFKGAEJFF() : null;
		}
	}

	public virtual void OBDGHOPPKOJ()
	{
		lock (this)
		{
			if (KBNPIGOEJEE != null)
			{
				KBNPIGOEJEE.BOPEPLONIFL();
				KBNPIGOEJEE = null;
			}
		}
	}
}
