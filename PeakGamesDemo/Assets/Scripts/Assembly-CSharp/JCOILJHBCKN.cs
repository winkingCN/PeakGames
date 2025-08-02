using Org.BouncyCastle.Math;

public class JCOILJHBCKN : HPBPDALECOG
{
	private readonly BigInteger PHAKMCGHMBA;

	private readonly int CFGADBIOJFG;

	public BigInteger IHOPDFAGDAF
	{
		get
		{
			return PHAKMCGHMBA;
		}
	}

	public int NPKPLHGJFAJ
	{
		get
		{
			return CFGADBIOJFG;
		}
	}

	public JCOILJHBCKN(BigInteger PHAKMCGHMBA, FBIJJFGLKMK GECCLOFELEC, int LOEMJLHDJAE, int CFGADBIOJFG)
		: base(GECCLOFELEC, LOEMJLHDJAE)
	{
		this.PHAKMCGHMBA = PHAKMCGHMBA;
		this.CFGADBIOJFG = CFGADBIOJFG;
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		JCOILJHBCKN jCOILJHBCKN = NEMEKIOEOLC as JCOILJHBCKN;
		if (jCOILJHBCKN == null)
		{
			return false;
		}
		return CFGADBIOJFG == jCOILJHBCKN.CFGADBIOJFG && PHAKMCGHMBA.Equals(jCOILJHBCKN.PHAKMCGHMBA);
	}

	public override int GetHashCode()
	{
		return CFGADBIOJFG.GetHashCode() ^ PHAKMCGHMBA.GetHashCode();
	}
}
