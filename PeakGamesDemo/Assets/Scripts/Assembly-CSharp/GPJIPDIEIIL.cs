using System;

public class GPJIPDIEIIL
{
	internal int EHJNMODJEAN;

	internal string IOCMOCCFALN;

	internal GPJIPDIEIIL LIMMFGDCLAB;

	internal float EOFAGACBNFP;

	internal float AMFCENFNAJJ;

	internal float CNLILOEEBOJ;

	internal float ODLHFMOPCHL;

	internal float IAFNPOKEFMB = 1f;

	internal float GFMCPIJHIGD = 1f;

	internal float BALNAGONJDA;

	internal float DADFBNMBFCD;

	internal NGPCELMDKGK OJOPJNBLHLO;

	public int PENJCGPCHHD
	{
		get
		{
			return EHJNMODJEAN;
		}
	}

	public string PNGPLGHKFDI
	{
		get
		{
			return IOCMOCCFALN;
		}
	}

	public GPJIPDIEIIL KNIICKBBGJB
	{
		get
		{
			return LIMMFGDCLAB;
		}
	}

	public float EJIAJLPHOGC
	{
		get
		{
			return EOFAGACBNFP;
		}
		set
		{
			EOFAGACBNFP = value;
		}
	}

	public float CBPFFIBINEH
	{
		get
		{
			return AMFCENFNAJJ;
		}
		set
		{
			AMFCENFNAJJ = value;
		}
	}

	public float MOAGLBJDKKL
	{
		get
		{
			return CNLILOEEBOJ;
		}
		set
		{
			CNLILOEEBOJ = value;
		}
	}

	public float PMNEAMANOCD
	{
		get
		{
			return ODLHFMOPCHL;
		}
		set
		{
			ODLHFMOPCHL = value;
		}
	}

	public float FLDLCFHBMEA
	{
		get
		{
			return IAFNPOKEFMB;
		}
		set
		{
			IAFNPOKEFMB = value;
		}
	}

	public float DEFAMIAKKGM
	{
		get
		{
			return GFMCPIJHIGD;
		}
		set
		{
			GFMCPIJHIGD = value;
		}
	}

	public float LAAJNLAJDPI
	{
		get
		{
			return BALNAGONJDA;
		}
		set
		{
			BALNAGONJDA = value;
		}
	}

	public float DLIMGFDAGOJ
	{
		get
		{
			return DADFBNMBFCD;
		}
		set
		{
			DADFBNMBFCD = value;
		}
	}

	public NGPCELMDKGK NHAPJAEAPDP
	{
		get
		{
			return OJOPJNBLHLO;
		}
		set
		{
			OJOPJNBLHLO = value;
		}
	}

	public GPJIPDIEIIL(int EHJNMODJEAN, string IOCMOCCFALN, GPJIPDIEIIL LIMMFGDCLAB)
	{
		if (EHJNMODJEAN < 0)
		{
			throw new ArgumentException("index must be >= 0", "index");
		}
		if (IOCMOCCFALN == null)
		{
			throw new ArgumentNullException("name", "name cannot be null.");
		}
		this.EHJNMODJEAN = EHJNMODJEAN;
		this.IOCMOCCFALN = IOCMOCCFALN;
		this.LIMMFGDCLAB = LIMMFGDCLAB;
	}

	public override string ToString()
	{
		return IOCMOCCFALN;
	}
}
