using System;
using Org.BouncyCastle.Math;

public class CFBBJKGJFPE : IGMAJHKIIPK
{
	private readonly BigInteger HPHBDNBJPHB;

	private readonly BigInteger HJMBDGKAOBP;

	private readonly int PHILIHLPDFD;

	public BigInteger MBIJHANOCOC
	{
		get
		{
			return HPHBDNBJPHB;
		}
	}

	public BigInteger HBGOKILMBJG
	{
		get
		{
			return HJMBDGKAOBP;
		}
	}

	public int NBFDOJDLKOG
	{
		get
		{
			return PHILIHLPDFD;
		}
	}

	public CFBBJKGJFPE(BigInteger HPHBDNBJPHB, BigInteger HJMBDGKAOBP)
		: this(HPHBDNBJPHB, HJMBDGKAOBP, 0)
	{
	}

	public CFBBJKGJFPE(BigInteger HPHBDNBJPHB, BigInteger HJMBDGKAOBP, int PHILIHLPDFD)
	{
		if (HPHBDNBJPHB == null)
		{
			throw new ArgumentNullException("p");
		}
		if (HJMBDGKAOBP == null)
		{
			throw new ArgumentNullException("g");
		}
		this.HPHBDNBJPHB = HPHBDNBJPHB;
		this.HJMBDGKAOBP = HJMBDGKAOBP;
		this.PHILIHLPDFD = PHILIHLPDFD;
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == this)
		{
			return true;
		}
		CFBBJKGJFPE cFBBJKGJFPE = NEMEKIOEOLC as CFBBJKGJFPE;
		if (cFBBJKGJFPE == null)
		{
			return false;
		}
		return KIFDKLPDKMD(cFBBJKGJFPE);
	}

	protected bool KIFDKLPDKMD(CFBBJKGJFPE CJHEIBNHNNE)
	{
		return HPHBDNBJPHB.Equals(CJHEIBNHNNE.HPHBDNBJPHB) && HJMBDGKAOBP.Equals(CJHEIBNHNNE.HJMBDGKAOBP) && PHILIHLPDFD == CJHEIBNHNNE.PHILIHLPDFD;
	}

	public override int GetHashCode()
	{
		return HPHBDNBJPHB.GetHashCode() ^ HJMBDGKAOBP.GetHashCode() ^ PHILIHLPDFD;
	}
}
