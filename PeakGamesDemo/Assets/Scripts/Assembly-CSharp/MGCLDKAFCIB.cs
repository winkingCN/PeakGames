public class MGCLDKAFCIB : LJPHFIKMDHN
{
	internal float MBHOIJFNKPO;

	internal float JGEIMMGNNFN;

	internal float ECJFPIOKKGN;

	internal float MJCEICPLJKP;

	internal float LBNLLJNGJHP;

	internal float HLMKOMNGAMA;

	private MGCLDKAFCIB ADCHJGIDENN;

	internal float[] NDIFGLEBDLE;

	internal float[] OJKLIMMHOEH;

	internal int[] NPDGLMEOKIO;

	internal float GPGDCCMECGF = 1f;

	internal float HJMBDGKAOBP = 1f;

	internal float BCIHLCMFAEK = 1f;

	internal float MNIMEAMHNMI = 1f;

	internal int DCPJBPJHJJK;

	internal bool HMGOODNADED;

	public object HIPOEPNPBPO;

	public int FMABFHBBBJG
	{
		get
		{
			return DCPJBPJHJJK;
		}
		set
		{
			DCPJBPJHJJK = value;
		}
	}

	public float[] FLBHKDLKCMP
	{
		get
		{
			return OJKLIMMHOEH;
		}
		set
		{
			OJKLIMMHOEH = value;
		}
	}

	public float[] PANOGEBNCAH
	{
		get
		{
			return NDIFGLEBDLE;
		}
		set
		{
			NDIFGLEBDLE = value;
		}
	}

	public int[] EOBOEPPBIHI
	{
		get
		{
			return NPDGLMEOKIO;
		}
		set
		{
			NPDGLMEOKIO = value;
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

	public string MJCBDBIDMGF { get; set; }

	public float AMPGPNLBJKC { get; set; }

	public float INFIMLAEHGL { get; set; }

	public float GGHFMMGLANA { get; set; }

	public float HDCMGPKKCEJ { get; set; }

	public bool GCNJNMPFNJC { get; set; }

	public float GDKDKELBACM
	{
		get
		{
			return MBHOIJFNKPO;
		}
		set
		{
			MBHOIJFNKPO = value;
		}
	}

	public float FDAOBNHPPKO
	{
		get
		{
			return JGEIMMGNNFN;
		}
		set
		{
			JGEIMMGNNFN = value;
		}
	}

	public float POMNBHFKCHA
	{
		get
		{
			return ECJFPIOKKGN;
		}
		set
		{
			ECJFPIOKKGN = value;
		}
	}

	public float DIFDGOAIOGG
	{
		get
		{
			return MJCEICPLJKP;
		}
		set
		{
			MJCEICPLJKP = value;
		}
	}

	public float OPELOOBFJPM
	{
		get
		{
			return LBNLLJNGJHP;
		}
		set
		{
			LBNLLJNGJHP = value;
		}
	}

	public float EHJAFDKAEDD
	{
		get
		{
			return HLMKOMNGAMA;
		}
		set
		{
			HLMKOMNGAMA = value;
		}
	}

	public bool CGMJOIHFNOC
	{
		get
		{
			return HMGOODNADED;
		}
		set
		{
			HMGOODNADED = value;
		}
	}

	public MGCLDKAFCIB EJEBCFHLAFF
	{
		get
		{
			return ADCHJGIDENN;
		}
		set
		{
			ADCHJGIDENN = value;
			if (value != null)
			{
				LIKIOBHLHHF = value.LIKIOBHLHHF;
				FHBFCAEGPOH = value.FHBFCAEGPOH;
				MCCBDCEJDBC = value.MCCBDCEJDBC;
				OJKLIMMHOEH = value.OJKLIMMHOEH;
				NPDGLMEOKIO = value.NPDGLMEOKIO;
				FMABFHBBBJG = value.FMABFHBBBJG;
				PEMDNNKKDPG = value.PEMDNNKKDPG;
				EMFKAPJMDCC = value.EMFKAPJMDCC;
				FHAMOHDEGMK = value.FHAMOHDEGMK;
			}
		}
	}

	public int[] PEMDNNKKDPG { get; set; }

	public float EMFKAPJMDCC { get; set; }

	public float FHAMOHDEGMK { get; set; }

	public MGCLDKAFCIB(string IOCMOCCFALN)
		: base(IOCMOCCFALN)
	{
	}

	public void IFAIOMLBIAD()
	{
		float num = AMPGPNLBJKC;
		float num2 = INFIMLAEHGL;
		float num3 = GGHFMMGLANA - AMPGPNLBJKC;
		float num4 = HDCMGPKKCEJ - INFIMLAEHGL;
		float[] oJKLIMMHOEH = OJKLIMMHOEH;
		if (NDIFGLEBDLE == null || NDIFGLEBDLE.Length != oJKLIMMHOEH.Length)
		{
			NDIFGLEBDLE = new float[oJKLIMMHOEH.Length];
		}
		float[] nDIFGLEBDLE = NDIFGLEBDLE;
		if (GCNJNMPFNJC)
		{
			int i = 0;
			for (int num5 = nDIFGLEBDLE.Length; i < num5; i += 2)
			{
				nDIFGLEBDLE[i] = num + oJKLIMMHOEH[i + 1] * num3;
				nDIFGLEBDLE[i + 1] = num2 + num4 - oJKLIMMHOEH[i] * num4;
			}
		}
		else
		{
			int j = 0;
			for (int num6 = nDIFGLEBDLE.Length; j < num6; j += 2)
			{
				nDIFGLEBDLE[j] = num + oJKLIMMHOEH[j] * num3;
				nDIFGLEBDLE[j + 1] = num2 + oJKLIMMHOEH[j + 1] * num4;
			}
		}
	}

	public override bool OPPJKMMOONJ(LJPHFIKMDHN OLBMEPMFMPF)
	{
		return this == OLBMEPMFMPF || (HMGOODNADED && ADCHJGIDENN == OLBMEPMFMPF);
	}
}
