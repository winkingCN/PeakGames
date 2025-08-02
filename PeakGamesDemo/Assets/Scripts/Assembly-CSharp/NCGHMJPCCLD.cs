using System;
using Org.BouncyCastle.Math;

public class NCGHMJPCCLD : DJABAMMOHPF
{
	private const int CINFPKNELKP = 6;

	private readonly int CEKMAJAHNAG;

	private readonly int KDFFDKFCDKK;

	private readonly int FKOBMEPIABG;

	private readonly int KHNDCPCHOEM;

	protected readonly LPKAACGCLJA IAALHPOGFAN;

	public override int PJNLBAHOKGC
	{
		get
		{
			return CEKMAJAHNAG;
		}
	}

	public override JGAFKLGGBGF EFOLNCNGADB
	{
		get
		{
			return IAALHPOGFAN;
		}
	}

	public int IGBPKOOBCMA
	{
		get
		{
			return CEKMAJAHNAG;
		}
	}

	public int JDADINDBJLD
	{
		get
		{
			return KDFFDKFCDKK;
		}
	}

	public int AELMELOBNJJ
	{
		get
		{
			return FKOBMEPIABG;
		}
	}

	public int CKKHLMGICAB
	{
		get
		{
			return KHNDCPCHOEM;
		}
	}

	[Obsolete("Use 'Order' property instead")]
	public BigInteger HNLMGJGNBDD
	{
		get
		{
			return NNGLKCDBIBE;
		}
	}

	[Obsolete("Use 'Cofactor' property instead")]
	public BigInteger JGOHMOHEFMJ
	{
		get
		{
			return LDKJJAOPAAP;
		}
	}

	public NCGHMJPCCLD(int CEKMAJAHNAG, int BENKLGPHLGI, BigInteger MNIMEAMHNMI, BigInteger BCIHLCMFAEK)
		: this(CEKMAJAHNAG, BENKLGPHLGI, 0, 0, MNIMEAMHNMI, BCIHLCMFAEK, null, null)
	{
	}

	public NCGHMJPCCLD(int CEKMAJAHNAG, int BENKLGPHLGI, BigInteger MNIMEAMHNMI, BigInteger BCIHLCMFAEK, BigInteger CMAJLIAELDP, BigInteger GHOBJLLGPOE)
		: this(CEKMAJAHNAG, BENKLGPHLGI, 0, 0, MNIMEAMHNMI, BCIHLCMFAEK, CMAJLIAELDP, GHOBJLLGPOE)
	{
	}

	public NCGHMJPCCLD(int CEKMAJAHNAG, int KDFFDKFCDKK, int FKOBMEPIABG, int KHNDCPCHOEM, BigInteger MNIMEAMHNMI, BigInteger BCIHLCMFAEK)
		: this(CEKMAJAHNAG, KDFFDKFCDKK, FKOBMEPIABG, KHNDCPCHOEM, MNIMEAMHNMI, BCIHLCMFAEK, null, null)
	{
	}

	public NCGHMJPCCLD(int CEKMAJAHNAG, int KDFFDKFCDKK, int FKOBMEPIABG, int KHNDCPCHOEM, BigInteger MNIMEAMHNMI, BigInteger BCIHLCMFAEK, BigInteger CMAJLIAELDP, BigInteger GHOBJLLGPOE)
		: base(CEKMAJAHNAG, KDFFDKFCDKK, FKOBMEPIABG, KHNDCPCHOEM)
	{
		this.CEKMAJAHNAG = CEKMAJAHNAG;
		this.KDFFDKFCDKK = KDFFDKFCDKK;
		this.FKOBMEPIABG = FKOBMEPIABG;
		this.KHNDCPCHOEM = KHNDCPCHOEM;
		NNGLKCDBIBE = CMAJLIAELDP;
		LDKJJAOPAAP = GHOBJLLGPOE;
		IAALHPOGFAN = new LPKAACGCLJA(this, null, null);
		if (KDFFDKFCDKK == 0)
		{
			throw new ArgumentException("k1 must be > 0");
		}
		if (FKOBMEPIABG == 0)
		{
			if (KHNDCPCHOEM != 0)
			{
				throw new ArgumentException("k3 must be 0 if k2 == 0");
			}
		}
		else
		{
			if (FKOBMEPIABG <= KDFFDKFCDKK)
			{
				throw new ArgumentException("k2 must be > k1");
			}
			if (KHNDCPCHOEM <= FKOBMEPIABG)
			{
				throw new ArgumentException("k3 must be > k2");
			}
		}
		CFJANGMBPML = HFENNGHNFLF(MNIMEAMHNMI);
		MPDGCILOEML = HFENNGHNFLF(BCIHLCMFAEK);
		NHKGIJJFPEK = 6;
	}

	protected NCGHMJPCCLD(int CEKMAJAHNAG, int KDFFDKFCDKK, int FKOBMEPIABG, int KHNDCPCHOEM, KBINBLGGLNE MNIMEAMHNMI, KBINBLGGLNE BCIHLCMFAEK, BigInteger CMAJLIAELDP, BigInteger GHOBJLLGPOE)
		: base(CEKMAJAHNAG, KDFFDKFCDKK, FKOBMEPIABG, KHNDCPCHOEM)
	{
		this.CEKMAJAHNAG = CEKMAJAHNAG;
		this.KDFFDKFCDKK = KDFFDKFCDKK;
		this.FKOBMEPIABG = FKOBMEPIABG;
		this.KHNDCPCHOEM = KHNDCPCHOEM;
		NNGLKCDBIBE = CMAJLIAELDP;
		LDKJJAOPAAP = GHOBJLLGPOE;
		IAALHPOGFAN = new LPKAACGCLJA(this, null, null);
		CFJANGMBPML = MNIMEAMHNMI;
		MPDGCILOEML = BCIHLCMFAEK;
		NHKGIJJFPEK = 6;
	}

	protected override BHPIABAGAPB LNLMICLEEPK()
	{
		return new NCGHMJPCCLD(CEKMAJAHNAG, KDFFDKFCDKK, FKOBMEPIABG, KHNDCPCHOEM, CFJANGMBPML, MPDGCILOEML, NNGLKCDBIBE, LDKJJAOPAAP);
	}

	public override bool ELIMDCKLHCJ(int FOOJPIGHMKH)
	{
		if (FOOJPIGHMKH == 0 || FOOJPIGHMKH == 1 || FOOJPIGHMKH == 6)
		{
			return true;
		}
		return false;
	}

	protected override FFPNOKBELNH EGMDJDFBANH()
	{
		if (FNJONABMLNB)
		{
			return new MCONFEBHMDC();
		}
		return base.EGMDJDFBANH();
	}

	public override KBINBLGGLNE HFENNGHNFLF(BigInteger AMFCENFNAJJ)
	{
		return new HMFDKDDBGPO(CEKMAJAHNAG, KDFFDKFCDKK, FKOBMEPIABG, KHNDCPCHOEM, AMFCENFNAJJ);
	}

	protected internal override JGAFKLGGBGF IMOPAOHAOAN(KBINBLGGLNE AMFCENFNAJJ, KBINBLGGLNE CNLILOEEBOJ, bool HPGABKNMEAG)
	{
		return new LPKAACGCLJA(this, AMFCENFNAJJ, CNLILOEEBOJ, HPGABKNMEAG);
	}

	protected internal override JGAFKLGGBGF IMOPAOHAOAN(KBINBLGGLNE AMFCENFNAJJ, KBINBLGGLNE CNLILOEEBOJ, KBINBLGGLNE[] IJGNIJAMCML, bool HPGABKNMEAG)
	{
		return new LPKAACGCLJA(this, AMFCENFNAJJ, CNLILOEEBOJ, IJGNIJAMCML, HPGABKNMEAG);
	}

	public bool DDCOOIKBMFC()
	{
		return FKOBMEPIABG == 0 && KHNDCPCHOEM == 0;
	}
}
