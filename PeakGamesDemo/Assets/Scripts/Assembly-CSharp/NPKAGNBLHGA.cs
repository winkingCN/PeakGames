using Org.BouncyCastle.Math;

internal class NPKAGNBLHGA : AGBPCEHDLOH
{
	protected readonly BigInteger AIHIGPPIFGH;

	public virtual BigInteger HJKCMCLHBEN
	{
		get
		{
			return AIHIGPPIFGH;
		}
	}

	public virtual int BABIEELHGOK
	{
		get
		{
			return 1;
		}
	}

	internal NPKAGNBLHGA(BigInteger AIHIGPPIFGH)
	{
		this.AIHIGPPIFGH = AIHIGPPIFGH;
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (this == NEMEKIOEOLC)
		{
			return true;
		}
		NPKAGNBLHGA nPKAGNBLHGA = NEMEKIOEOLC as NPKAGNBLHGA;
		if (nPKAGNBLHGA == null)
		{
			return false;
		}
		return AIHIGPPIFGH.Equals(nPKAGNBLHGA.AIHIGPPIFGH);
	}

	public override int GetHashCode()
	{
		return AIHIGPPIFGH.GetHashCode();
	}
}
