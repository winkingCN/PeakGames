using System;

public class HOHJPJDGOLF
{
	private readonly COEMJAGOFJJ IGGIBDAKJDC;

	private readonly COEMJAGOFJJ HNCBOJMAALP;

	public COEMJAGOFJJ OOOKGOFNBEG
	{
		get
		{
			return IGGIBDAKJDC;
		}
	}

	public COEMJAGOFJJ KIBEEKODFLC
	{
		get
		{
			return HNCBOJMAALP;
		}
	}

	public HOHJPJDGOLF(COEMJAGOFJJ IGGIBDAKJDC, COEMJAGOFJJ HNCBOJMAALP)
	{
		if (IGGIBDAKJDC.CCLHEKOIIKM)
		{
			throw new ArgumentException("Expected a public key", "publicParameter");
		}
		if (!HNCBOJMAALP.CCLHEKOIIKM)
		{
			throw new ArgumentException("Expected a private key", "privateParameter");
		}
		this.IGGIBDAKJDC = IGGIBDAKJDC;
		this.HNCBOJMAALP = HNCBOJMAALP;
	}
}
