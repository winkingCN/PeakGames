using System;
using Org.BouncyCastle.Math;

public class JEHNKJOKBGF : IGMAJHKIIPK
{
	private readonly BigInteger HPHBDNBJPHB;

	private readonly BigInteger OKDPJHOEPBJ;

	private readonly BigInteger HJMBDGKAOBP;

	private readonly CFHBDCOKAPL CANIMMGDFPJ;

	public BigInteger MBIJHANOCOC
	{
		get
		{
			return HPHBDNBJPHB;
		}
	}

	public BigInteger FNPELDEHJKL
	{
		get
		{
			return OKDPJHOEPBJ;
		}
	}

	public BigInteger HBGOKILMBJG
	{
		get
		{
			return HJMBDGKAOBP;
		}
	}

	public CFHBDCOKAPL OAMDEKMPJIL
	{
		get
		{
			return CANIMMGDFPJ;
		}
	}

	public JEHNKJOKBGF(BigInteger HPHBDNBJPHB, BigInteger OKDPJHOEPBJ, BigInteger HJMBDGKAOBP)
		: this(HPHBDNBJPHB, OKDPJHOEPBJ, HJMBDGKAOBP, null)
	{
	}

	public JEHNKJOKBGF(BigInteger HPHBDNBJPHB, BigInteger OKDPJHOEPBJ, BigInteger HJMBDGKAOBP, CFHBDCOKAPL IJJHBEECMBP)
	{
		if (HPHBDNBJPHB == null)
		{
			throw new ArgumentNullException("p");
		}
		if (OKDPJHOEPBJ == null)
		{
			throw new ArgumentNullException("q");
		}
		if (HJMBDGKAOBP == null)
		{
			throw new ArgumentNullException("g");
		}
		this.HPHBDNBJPHB = HPHBDNBJPHB;
		this.OKDPJHOEPBJ = OKDPJHOEPBJ;
		this.HJMBDGKAOBP = HJMBDGKAOBP;
		CANIMMGDFPJ = IJJHBEECMBP;
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == this)
		{
			return true;
		}
		JEHNKJOKBGF jEHNKJOKBGF = NEMEKIOEOLC as JEHNKJOKBGF;
		if (jEHNKJOKBGF == null)
		{
			return false;
		}
		return KIFDKLPDKMD(jEHNKJOKBGF);
	}

	protected bool KIFDKLPDKMD(JEHNKJOKBGF CJHEIBNHNNE)
	{
		return HPHBDNBJPHB.Equals(CJHEIBNHNNE.HPHBDNBJPHB) && OKDPJHOEPBJ.Equals(CJHEIBNHNNE.OKDPJHOEPBJ) && HJMBDGKAOBP.Equals(CJHEIBNHNNE.HJMBDGKAOBP);
	}

	public override int GetHashCode()
	{
		return HPHBDNBJPHB.GetHashCode() ^ OKDPJHOEPBJ.GetHashCode() ^ HJMBDGKAOBP.GetHashCode();
	}
}
