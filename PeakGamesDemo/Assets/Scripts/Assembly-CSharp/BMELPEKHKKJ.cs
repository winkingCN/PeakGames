using System;
using System.Collections.Generic;

public class BMELPEKHKKJ
{
	internal string IOCMOCCFALN;

	internal int CMAJLIAELDP;

	internal List<GPJIPDIEIIL> LIKIOBHLHHF = new List<GPJIPDIEIIL>();

	internal GPJIPDIEIIL CAEMELGEOAE;

	internal int IEFNLGDAINN = 1;

	internal float MIIHPKNIPAB = 1f;

	public string PNGPLGHKFDI
	{
		get
		{
			return IOCMOCCFALN;
		}
	}

	public int BHIJCAOHDCM
	{
		get
		{
			return CMAJLIAELDP;
		}
		set
		{
			CMAJLIAELDP = value;
		}
	}

	public List<GPJIPDIEIIL> PGACGAFEFHD
	{
		get
		{
			return LIKIOBHLHHF;
		}
	}

	public GPJIPDIEIIL IPLKKJOIMPM
	{
		get
		{
			return CAEMELGEOAE;
		}
		set
		{
			CAEMELGEOAE = value;
		}
	}

	public int AGEINJMHJAA
	{
		get
		{
			return IEFNLGDAINN;
		}
		set
		{
			IEFNLGDAINN = value;
		}
	}

	public float FABMAMDLDKF
	{
		get
		{
			return MIIHPKNIPAB;
		}
		set
		{
			MIIHPKNIPAB = value;
		}
	}

	public BMELPEKHKKJ(string IOCMOCCFALN)
	{
		if (IOCMOCCFALN == null)
		{
			throw new ArgumentNullException("name", "name cannot be null.");
		}
		this.IOCMOCCFALN = IOCMOCCFALN;
	}

	public override string ToString()
	{
		return IOCMOCCFALN;
	}
}
