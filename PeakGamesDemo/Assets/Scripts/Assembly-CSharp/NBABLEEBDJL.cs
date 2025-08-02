using System.Collections;
using Org.BouncyCastle.Math;

public class NBABLEEBDJL : LNKPCJLANAO
{
	internal GLFDIPNOLKN HPHBDNBJPHB;

	internal GLFDIPNOLKN HJMBDGKAOBP;

	internal GLFDIPNOLKN PHILIHLPDFD;

	public BigInteger MBIJHANOCOC
	{
		get
		{
			return HPHBDNBJPHB.DMPHAJNKNKB;
		}
	}

	public BigInteger HBGOKILMBJG
	{
		get
		{
			return HJMBDGKAOBP.DMPHAJNKNKB;
		}
	}

	public BigInteger NBFDOJDLKOG
	{
		get
		{
			return (PHILIHLPDFD != null) ? PHILIHLPDFD.DMPHAJNKNKB : null;
		}
	}

	public NBABLEEBDJL(BigInteger HPHBDNBJPHB, BigInteger HJMBDGKAOBP, int PHILIHLPDFD)
	{
		this.HPHBDNBJPHB = new GLFDIPNOLKN(HPHBDNBJPHB);
		this.HJMBDGKAOBP = new GLFDIPNOLKN(HJMBDGKAOBP);
		if (PHILIHLPDFD != 0)
		{
			this.PHILIHLPDFD = new GLFDIPNOLKN(PHILIHLPDFD);
		}
	}

	public NBABLEEBDJL(ALLINHNNNJN MIABODPHOIP)
	{
		IEnumerator enumerator = MIABODPHOIP.GetEnumerator();
		enumerator.MoveNext();
		HPHBDNBJPHB = (GLFDIPNOLKN)enumerator.Current;
		enumerator.MoveNext();
		HJMBDGKAOBP = (GLFDIPNOLKN)enumerator.Current;
		if (enumerator.MoveNext())
		{
			PHILIHLPDFD = (GLFDIPNOLKN)enumerator.Current;
		}
	}

	public override EDOEBJJFOBM IIHKEACDNID()
	{
		DLDBGGDLOOO dLDBGGDLOOO = new DLDBGGDLOOO(HPHBDNBJPHB, HJMBDGKAOBP);
		if (PHILIHLPDFD != null)
		{
			dLDBGGDLOOO.JEACJNAKLDJ(PHILIHLPDFD);
		}
		return new KOGPLMALOEH(dLDBGGDLOOO);
	}
}
