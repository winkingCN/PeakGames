using Org.BouncyCastle.Math;

internal class EFCEDCELLNF : DJABAMMOHPF
{
	private const int ANBLPBAKAJK = 6;

	protected readonly IKOPBIPJFIK IAALHPOGFAN;

	public override int PJNLBAHOKGC
	{
		get
		{
			return 131;
		}
	}

	public override JGAFKLGGBGF EFOLNCNGADB
	{
		get
		{
			return IAALHPOGFAN;
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

	public EFCEDCELLNF()
		: base(131, 2, 3, 8)
	{
		IAALHPOGFAN = new IKOPBIPJFIK(this, null, null);
		CFJANGMBPML = HFENNGHNFLF(new BigInteger(1, DCDJMDOEKHC.ILOALOLANOL("03E5A88919D7CAFCBF415F07C2176573B2")));
		MPDGCILOEML = HFENNGHNFLF(new BigInteger(1, DCDJMDOEKHC.ILOALOLANOL("04B8266A46C55657AC734CE38F018F2192")));
		NNGLKCDBIBE = new BigInteger(1, DCDJMDOEKHC.ILOALOLANOL("0400000000000000016954A233049BA98F"));
		LDKJJAOPAAP = BigInteger.Two;
		NHKGIJJFPEK = 6;
	}

	protected override BHPIABAGAPB LNLMICLEEPK()
	{
		return new EFCEDCELLNF();
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
		return new IKOPBIPJFIK(this, AMFCENFNAJJ, CNLILOEEBOJ, HPGABKNMEAG);
	}

	protected internal override JGAFKLGGBGF IMOPAOHAOAN(KBINBLGGLNE AMFCENFNAJJ, KBINBLGGLNE CNLILOEEBOJ, KBINBLGGLNE[] IJGNIJAMCML, bool HPGABKNMEAG)
	{
		return new IKOPBIPJFIK(this, AMFCENFNAJJ, CNLILOEEBOJ, IJGNIJAMCML, HPGABKNMEAG);
	}
}
