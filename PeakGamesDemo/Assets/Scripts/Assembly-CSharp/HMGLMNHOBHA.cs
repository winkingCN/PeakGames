using System;

public class HMGLMNHOBHA
{
	internal int EHJNMODJEAN;

	internal string IOCMOCCFALN;

	internal GPJIPDIEIIL JJLEOELOOJP;

	internal float GPGDCCMECGF = 1f;

	internal float HJMBDGKAOBP = 1f;

	internal float BCIHLCMFAEK = 1f;

	internal float MNIMEAMHNMI = 1f;

	internal float FHPFAEDHEGG;

	internal float AONHFIBNFLD;

	internal float DLGDBCBCIED;

	internal bool CKPBGCMIIJL;

	internal string FKAJNAAKEFH;

	internal AOOPCGDMICP DNLHLBINHHE;

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

	public GPJIPDIEIIL NGJJONODPKN
	{
		get
		{
			return JJLEOELOOJP;
		}
	}

	public float GOEFJMNOBHA
	{
		get
		{
			return GPGDCCMECGF;
		}
		set
		{
			GPGDCCMECGF = value;
		}
	}

	public float HBGOKILMBJG
	{
		get
		{
			return HJMBDGKAOBP;
		}
		set
		{
			HJMBDGKAOBP = value;
		}
	}

	public float FPKDKHJKEEF
	{
		get
		{
			return BCIHLCMFAEK;
		}
		set
		{
			BCIHLCMFAEK = value;
		}
	}

	public float JEHECJGFJEB
	{
		get
		{
			return MNIMEAMHNMI;
		}
		set
		{
			MNIMEAMHNMI = value;
		}
	}

	public float HNHLEKDNBDN
	{
		get
		{
			return FHPFAEDHEGG;
		}
		set
		{
			FHPFAEDHEGG = value;
		}
	}

	public float ACBLCPEFOMO
	{
		get
		{
			return AONHFIBNFLD;
		}
		set
		{
			AONHFIBNFLD = value;
		}
	}

	public float IBFEPDEPOKB
	{
		get
		{
			return DLGDBCBCIED;
		}
		set
		{
			DLGDBCBCIED = value;
		}
	}

	public bool BNOAMBJMGDI
	{
		get
		{
			return CKPBGCMIIJL;
		}
		set
		{
			CKPBGCMIIJL = value;
		}
	}

	public string BGKJFCFLLKJ
	{
		get
		{
			return FKAJNAAKEFH;
		}
		set
		{
			FKAJNAAKEFH = value;
		}
	}

	public AOOPCGDMICP CJFLEJNJGNP
	{
		get
		{
			return DNLHLBINHHE;
		}
		set
		{
			DNLHLBINHHE = value;
		}
	}

	public HMGLMNHOBHA(int EHJNMODJEAN, string IOCMOCCFALN, GPJIPDIEIIL JJLEOELOOJP)
	{
		if (EHJNMODJEAN < 0)
		{
			throw new ArgumentException("index must be >= 0.", "index");
		}
		if (IOCMOCCFALN == null)
		{
			throw new ArgumentNullException("name", "name cannot be null.");
		}
		if (JJLEOELOOJP == null)
		{
			throw new ArgumentNullException("boneData", "boneData cannot be null.");
		}
		this.EHJNMODJEAN = EHJNMODJEAN;
		this.IOCMOCCFALN = IOCMOCCFALN;
		this.JJLEOELOOJP = JJLEOELOOJP;
	}

	public override string ToString()
	{
		return IOCMOCCFALN;
	}
}
