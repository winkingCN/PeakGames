using System;

public class HPBPDALECOG
{
	private FBIJJFGLKMK GECCLOFELEC;

	private int LOEMJLHDJAE;

	public FBIJJFGLKMK IPFKDIJBGIM
	{
		get
		{
			return GECCLOFELEC;
		}
	}

	public int IBANINMCJPP
	{
		get
		{
			return LOEMJLHDJAE;
		}
	}

	public HPBPDALECOG(FBIJJFGLKMK GECCLOFELEC, int LOEMJLHDJAE)
	{
		if (GECCLOFELEC == null)
		{
			throw new ArgumentNullException("random");
		}
		if (LOEMJLHDJAE < 1)
		{
			throw new ArgumentException("strength must be a positive value", "strength");
		}
		this.GECCLOFELEC = GECCLOFELEC;
		this.LOEMJLHDJAE = LOEMJLHDJAE;
	}
}
