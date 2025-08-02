using System;
using Spine;

public class LBBAMMPJKDA
{
	internal HMGLMNHOBHA MBBPBGHKLJM;

	internal NBKCFDOMAPI JEBEPBEGCCF;

	internal float GPGDCCMECGF;

	internal float HJMBDGKAOBP;

	internal float BCIHLCMFAEK;

	internal float MNIMEAMHNMI;

	internal float FHPFAEDHEGG;

	internal float AONHFIBNFLD;

	internal float DLGDBCBCIED;

	internal bool CKPBGCMIIJL;

	internal OAMNGFLKEFI DFHHMKMLCFF;

	internal float HEINGMAKEGD;

	internal ExposedList<float> ADAMNKAAPII = new ExposedList<float>();

	public HMGLMNHOBHA LJDLCPHOBHB
	{
		get
		{
			return MBBPBGHKLJM;
		}
	}

	public NBKCFDOMAPI LKMOJLJHLCN
	{
		get
		{
			return JEBEPBEGCCF;
		}
	}

	public GCJKICAPOFL LICMNMABJGL
	{
		get
		{
			return JEBEPBEGCCF.GDNININLMFD;
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
			return MBBPBGHKLJM.CKPBGCMIIJL;
		}
		set
		{
			MBBPBGHKLJM.CKPBGCMIIJL = value;
		}
	}

	public OAMNGFLKEFI AIKFOHCPLKG
	{
		get
		{
			return DFHHMKMLCFF;
		}
		set
		{
			if (DFHHMKMLCFF != value)
			{
				DFHHMKMLCFF = value;
				HEINGMAKEGD = JEBEPBEGCCF.GDNININLMFD.HFLODNLEGFL;
				ADAMNKAAPII.BOPEPLONIFL(false);
			}
		}
	}

	public float JDPHPGCKJEE
	{
		get
		{
			return JEBEPBEGCCF.GDNININLMFD.HFLODNLEGFL - HEINGMAKEGD;
		}
		set
		{
			HEINGMAKEGD = JEBEPBEGCCF.GDNININLMFD.HFLODNLEGFL - value;
		}
	}

	public ExposedList<float> FDMGPJEOCMG
	{
		get
		{
			return ADAMNKAAPII;
		}
		set
		{
			ADAMNKAAPII = value;
		}
	}

	public LBBAMMPJKDA(HMGLMNHOBHA MBBPBGHKLJM, NBKCFDOMAPI JEBEPBEGCCF)
	{
		if (MBBPBGHKLJM == null)
		{
			throw new ArgumentNullException("data", "data cannot be null.");
		}
		if (JEBEPBEGCCF == null)
		{
			throw new ArgumentNullException("bone", "bone cannot be null.");
		}
		this.MBBPBGHKLJM = MBBPBGHKLJM;
		this.JEBEPBEGCCF = JEBEPBEGCCF;
		ODJKPILHIOD();
	}

	public void ODJKPILHIOD()
	{
		GPGDCCMECGF = MBBPBGHKLJM.GPGDCCMECGF;
		HJMBDGKAOBP = MBBPBGHKLJM.HJMBDGKAOBP;
		BCIHLCMFAEK = MBBPBGHKLJM.BCIHLCMFAEK;
		MNIMEAMHNMI = MBBPBGHKLJM.MNIMEAMHNMI;
		if (MBBPBGHKLJM.FKAJNAAKEFH == null)
		{
			AIKFOHCPLKG = null;
			return;
		}
		DFHHMKMLCFF = null;
		AIKFOHCPLKG = JEBEPBEGCCF.GDNININLMFD.JGHJDGIANDD(MBBPBGHKLJM.EHJNMODJEAN, MBBPBGHKLJM.FKAJNAAKEFH);
	}

	public override string ToString()
	{
		return MBBPBGHKLJM.IOCMOCCFALN;
	}
}
