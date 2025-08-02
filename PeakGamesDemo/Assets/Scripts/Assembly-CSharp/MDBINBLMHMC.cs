using System;

public class MDBINBLMHMC
{
	internal string IOCMOCCFALN;

	public string PNGPLGHKFDI
	{
		get
		{
			return IOCMOCCFALN;
		}
	}

	public int IOCBLKCOMGI { get; set; }

	public float NCGJMNFFOJH { get; set; }

	public string BECLAMGPAGN { get; set; }

	public MDBINBLMHMC(string IOCMOCCFALN)
	{
		if (IOCMOCCFALN == null)
		{
			throw new ArgumentNullException("name", "name cannot be null.");
		}
		this.IOCMOCCFALN = IOCMOCCFALN;
	}

	public override string ToString()
	{
		return PNGPLGHKFDI;
	}
}
