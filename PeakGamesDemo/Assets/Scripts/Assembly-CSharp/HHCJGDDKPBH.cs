using Org.BouncyCastle.Math;

internal class HHCJGDDKPBH : AIGKJBLDPNN, IMLHJNECCMA, AGBPCEHDLOH
{
	protected readonly AGBPCEHDLOH HCJKNMIOHDC;

	protected readonly LCDKCHNAIGN IBCEDCLEJGJ;

	public virtual BigInteger HJKCMCLHBEN
	{
		get
		{
			return HCJKNMIOHDC.HJKCMCLHBEN;
		}
	}

	public virtual int BABIEELHGOK
	{
		get
		{
			return HCJKNMIOHDC.BABIEELHGOK * IBCEDCLEJGJ.NMAPLGALKKK;
		}
	}

	public virtual AGBPCEHDLOH KFDPBPMMOAB
	{
		get
		{
			return HCJKNMIOHDC;
		}
	}

	public virtual int NMAPLGALKKK
	{
		get
		{
			return IBCEDCLEJGJ.NMAPLGALKKK;
		}
	}

	public virtual LCDKCHNAIGN AJFCOOELGPF
	{
		get
		{
			return IBCEDCLEJGJ;
		}
	}

	internal HHCJGDDKPBH(AGBPCEHDLOH HCJKNMIOHDC, LCDKCHNAIGN LIJDCBPPMNE)
	{
		this.HCJKNMIOHDC = HCJKNMIOHDC;
		IBCEDCLEJGJ = LIJDCBPPMNE;
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (this == NEMEKIOEOLC)
		{
			return true;
		}
		HHCJGDDKPBH hHCJGDDKPBH = NEMEKIOEOLC as HHCJGDDKPBH;
		if (hHCJGDDKPBH == null)
		{
			return false;
		}
		return HCJKNMIOHDC.Equals(hHCJGDDKPBH.HCJKNMIOHDC) && IBCEDCLEJGJ.Equals(hHCJGDDKPBH.IBCEDCLEJGJ);
	}

	public override int GetHashCode()
	{
		return HCJKNMIOHDC.GetHashCode() ^ MKDODBDPJII.MBBDJFKAACD(IBCEDCLEJGJ.GetHashCode(), 16);
	}
}
