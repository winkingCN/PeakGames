using System;

public class MDAKJDOFCEP : IGMAJHKIIPK
{
	private readonly IGMAJHKIIPK IJJHBEECMBP;

	private readonly FBIJJFGLKMK GECCLOFELEC;

	public FBIJJFGLKMK IPFKDIJBGIM
	{
		get
		{
			return GECCLOFELEC;
		}
	}

	public IGMAJHKIIPK KPJHHAAOFOH
	{
		get
		{
			return IJJHBEECMBP;
		}
	}

	public MDAKJDOFCEP(IGMAJHKIIPK IJJHBEECMBP, FBIJJFGLKMK GECCLOFELEC)
	{
		if (IJJHBEECMBP == null)
		{
			throw new ArgumentNullException("parameters");
		}
		if (GECCLOFELEC == null)
		{
			throw new ArgumentNullException("random");
		}
		this.IJJHBEECMBP = IJJHBEECMBP;
		this.GECCLOFELEC = GECCLOFELEC;
	}

	public MDAKJDOFCEP(IGMAJHKIIPK IJJHBEECMBP)
		: this(IJJHBEECMBP, new FBIJJFGLKMK())
	{
	}

	[Obsolete("Use Random property instead")]
	public FBIJJFGLKMK JPDINPFFMOH()
	{
		return IPFKDIJBGIM;
	}
}
