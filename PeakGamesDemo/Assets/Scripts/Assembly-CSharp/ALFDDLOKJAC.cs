using System;
using Org.BouncyCastle.Math;

public class ALFDDLOKJAC : IGMAJHKIIPK
{
	private readonly BigInteger HPHBDNBJPHB;

	private readonly BigInteger OKDPJHOEPBJ;

	private readonly BigInteger MNIMEAMHNMI;

	private readonly GDMHLBGPKKL CANIMMGDFPJ;

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

	public BigInteger JEHECJGFJEB
	{
		get
		{
			return MNIMEAMHNMI;
		}
	}

	public GDMHLBGPKKL OAMDEKMPJIL
	{
		get
		{
			return CANIMMGDFPJ;
		}
	}

	public ALFDDLOKJAC(BigInteger HPHBDNBJPHB, BigInteger OKDPJHOEPBJ, BigInteger MNIMEAMHNMI)
		: this(HPHBDNBJPHB, OKDPJHOEPBJ, MNIMEAMHNMI, null)
	{
	}

	public ALFDDLOKJAC(BigInteger HPHBDNBJPHB, BigInteger OKDPJHOEPBJ, BigInteger MNIMEAMHNMI, GDMHLBGPKKL CANIMMGDFPJ)
	{
		if (HPHBDNBJPHB == null)
		{
			throw new ArgumentNullException("p");
		}
		if (OKDPJHOEPBJ == null)
		{
			throw new ArgumentNullException("q");
		}
		if (MNIMEAMHNMI == null)
		{
			throw new ArgumentNullException("a");
		}
		this.HPHBDNBJPHB = HPHBDNBJPHB;
		this.OKDPJHOEPBJ = OKDPJHOEPBJ;
		this.MNIMEAMHNMI = MNIMEAMHNMI;
		this.CANIMMGDFPJ = CANIMMGDFPJ;
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == this)
		{
			return true;
		}
		ALFDDLOKJAC aLFDDLOKJAC = NEMEKIOEOLC as ALFDDLOKJAC;
		if (aLFDDLOKJAC == null)
		{
			return false;
		}
		return KIFDKLPDKMD(aLFDDLOKJAC);
	}

	protected bool KIFDKLPDKMD(ALFDDLOKJAC CJHEIBNHNNE)
	{
		return HPHBDNBJPHB.Equals(CJHEIBNHNNE.HPHBDNBJPHB) && OKDPJHOEPBJ.Equals(CJHEIBNHNNE.OKDPJHOEPBJ) && MNIMEAMHNMI.Equals(CJHEIBNHNNE.MNIMEAMHNMI);
	}

	public override int GetHashCode()
	{
		return HPHBDNBJPHB.GetHashCode() ^ OKDPJHOEPBJ.GetHashCode() ^ MNIMEAMHNMI.GetHashCode();
	}
}
