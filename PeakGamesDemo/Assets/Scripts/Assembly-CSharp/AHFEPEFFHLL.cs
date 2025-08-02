using System;

public class AHFEPEFFHLL : Exception
{
	public AHFEPEFFHLL()
	{
	}

	internal AHFEPEFFHLL(ONDKJBJAONJ DJJGDFFDGFN)
		: base(string.Format("Invalid token '{0}' in input string", DJJGDFFDGFN))
	{
	}

	internal AHFEPEFFHLL(ONDKJBJAONJ DJJGDFFDGFN, Exception GHBFGCLPBGD)
		: base(string.Format("Invalid token '{0}' in input string", DJJGDFFDGFN), GHBFGCLPBGD)
	{
	}

	internal AHFEPEFFHLL(int FMFABAKPMLB)
		: base(string.Format("Invalid character '{0}' in input string", (char)FMFABAKPMLB))
	{
	}

	internal AHFEPEFFHLL(int FMFABAKPMLB, Exception GHBFGCLPBGD)
		: base(string.Format("Invalid character '{0}' in input string", (char)FMFABAKPMLB), GHBFGCLPBGD)
	{
	}

	public AHFEPEFFHLL(string OEFCOJLNCKP)
		: base(OEFCOJLNCKP)
	{
	}

	public AHFEPEFFHLL(string OEFCOJLNCKP, Exception GHBFGCLPBGD)
		: base(OEFCOJLNCKP, GHBFGCLPBGD)
	{
	}
}
