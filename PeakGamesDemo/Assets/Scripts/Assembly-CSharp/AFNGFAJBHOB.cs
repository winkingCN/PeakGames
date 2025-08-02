using Org.BouncyCastle.Math;

internal class AFNGFAJBHOB : DJABAMMOHPF
{
	private const int LBFDFIJAECN = 6;

	protected readonly APFAAGMGJMO IAALHPOGFAN;

	public override JGAFKLGGBGF EFOLNCNGADB
	{
		get
		{
			return IAALHPOGFAN;
		}
	}

	public override int PJNLBAHOKGC
	{
		get
		{
			return 131;
		}
	}

	public override bool FNJONABMLNB
	{
		get
		{
			return false;
		}
	}

	public virtual int IGBPKOOBCMA
	{
		get
		{
			return 131;
		}
	}

	public virtual bool DDCOOIKBMFC
	{
		get
		{
			return false;
		}
	}

	public virtual int JDADINDBJLD
	{
		get
		{
			return 2;
		}
	}

	public virtual int AELMELOBNJJ
	{
		get
		{
			return 3;
		}
	}

	public virtual int CKKHLMGICAB
	{
		get
		{
			return 8;
		}
	}

	public AFNGFAJBHOB()
		: base(131, 2, 3, 8)
	{
		IAALHPOGFAN = new APFAAGMGJMO(this, null, null);
		CFJANGMBPML = HFENNGHNFLF(new BigInteger(1, DCDJMDOEKHC.ILOALOLANOL("07A11B09A76B562144418FF3FF8C2570B8")));
		MPDGCILOEML = HFENNGHNFLF(new BigInteger(1, DCDJMDOEKHC.ILOALOLANOL("0217C05610884B63B9C6C7291678F9D341")));
		NNGLKCDBIBE = new BigInteger(1, DCDJMDOEKHC.ILOALOLANOL("0400000000000000023123953A9464B54D"));
		LDKJJAOPAAP = BigInteger.Two;
		NHKGIJJFPEK = 6;
	}

	protected override BHPIABAGAPB LNLMICLEEPK()
	{
		return new AFNGFAJBHOB();
	}

	public override bool ELIMDCKLHCJ(int FOOJPIGHMKH)
	{
		if (FOOJPIGHMKH == 6)
		{
			return true;
		}
		return false;
	}

	public override KBINBLGGLNE HFENNGHNFLF(BigInteger AMFCENFNAJJ)
	{
		return new KODFKDGEPMI(AMFCENFNAJJ);
	}

	protected internal override JGAFKLGGBGF IMOPAOHAOAN(KBINBLGGLNE AMFCENFNAJJ, KBINBLGGLNE CNLILOEEBOJ, bool HPGABKNMEAG)
	{
		return new APFAAGMGJMO(this, AMFCENFNAJJ, CNLILOEEBOJ, HPGABKNMEAG);
	}

	protected internal override JGAFKLGGBGF IMOPAOHAOAN(KBINBLGGLNE AMFCENFNAJJ, KBINBLGGLNE CNLILOEEBOJ, KBINBLGGLNE[] IJGNIJAMCML, bool HPGABKNMEAG)
	{
		return new APFAAGMGJMO(this, AMFCENFNAJJ, CNLILOEEBOJ, IJGNIJAMCML, HPGABKNMEAG);
	}
}
