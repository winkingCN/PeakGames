using System;

public abstract class FPKDGILKICO : JMPFLJGHAIM
{
	protected static readonly int OBDGIDCKDFM = 16;

	internal const int DFBJOFIADHK = 32;

	internal const int LOONFDBILFK = -1640531527;

	protected bool LFBBFLCMAHI;

	protected int[] IIIGKBPIKGE;

	protected int PHJLFAEPHKF;

	protected int JCJOMANHEBB;

	protected int IKFOEMCJCLB;

	protected int INJJCOCLHNO;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return "Serpent";
		}
	}

	public virtual bool ABNLKPDCGEF
	{
		get
		{
			return false;
		}
	}

	public virtual void DIOELAHNLKJ(bool LFBBFLCMAHI, IGMAJHKIIPK IJJHBEECMBP)
	{
		if (!(IJJHBEECMBP is JEMNCGMEABF))
		{
			throw new ArgumentException("invalid parameter passed to " + KFKMEPMEBND + " init - " + LHFGHNFJIKM.JKHOEKAOLPM(IJJHBEECMBP));
		}
		this.LFBBFLCMAHI = LFBBFLCMAHI;
		IIIGKBPIKGE = HLJJADHKDFK(((JEMNCGMEABF)IJJHBEECMBP).MEGBFHFMBFI());
	}

	public virtual int BDIGGHEPIIP()
	{
		return OBDGIDCKDFM;
	}

	public int DPACJDFHLKB(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		if (IIIGKBPIKGE == null)
		{
			throw new InvalidOperationException(KFKMEPMEBND + " not initialised");
		}
		AJLDFGNHDCA.OONDALLFPOP(MOPCLEEGDFB, ELICNEDIBGB, OBDGIDCKDFM, "input buffer too short");
		AJLDFGNHDCA.KLPNFGNKNKB(BILGCJNPJGJ, EMAKNGBIFDC, OBDGIDCKDFM, "output buffer too short");
		if (LFBBFLCMAHI)
		{
			HDOLNBOHAJA(MOPCLEEGDFB, ELICNEDIBGB, BILGCJNPJGJ, EMAKNGBIFDC);
		}
		else
		{
			GFKALHGNIOJ(MOPCLEEGDFB, ELICNEDIBGB, BILGCJNPJGJ, EMAKNGBIFDC);
		}
		return OBDGIDCKDFM;
	}

	public virtual void OMOKOKFNBKI()
	{
	}

	protected static int MBBDJFKAACD(int AMFCENFNAJJ, int IODPDKHNDIE)
	{
		return (AMFCENFNAJJ << IODPDKHNDIE) | (int)((uint)AMFCENFNAJJ >> 32 - IODPDKHNDIE);
	}

	private static int AIFAMJPHAAF(int AMFCENFNAJJ, int IODPDKHNDIE)
	{
		return (int)((uint)AMFCENFNAJJ >> IODPDKHNDIE) | (AMFCENFNAJJ << 32 - IODPDKHNDIE);
	}

	protected void KIPCEBJGHJK(int MNIMEAMHNMI, int BCIHLCMFAEK, int FMFABAKPMLB, int ELNCCDELMMH)
	{
		int num = MNIMEAMHNMI ^ ELNCCDELMMH;
		int num2 = FMFABAKPMLB ^ num;
		int num3 = BCIHLCMFAEK ^ num2;
		INJJCOCLHNO = (MNIMEAMHNMI & ELNCCDELMMH) ^ num3;
		int num4 = MNIMEAMHNMI ^ (BCIHLCMFAEK & num);
		IKFOEMCJCLB = num3 ^ (FMFABAKPMLB | num4);
		int num5 = INJJCOCLHNO & (num2 ^ num4);
		JCJOMANHEBB = ~num2 ^ num5;
		PHJLFAEPHKF = num5 ^ ~num4;
	}

	protected void IMHKEOHPEAE(int MNIMEAMHNMI, int BCIHLCMFAEK, int FMFABAKPMLB, int ELNCCDELMMH)
	{
		int num = ~MNIMEAMHNMI;
		int num2 = MNIMEAMHNMI ^ BCIHLCMFAEK;
		int num3 = ELNCCDELMMH ^ (num | num2);
		int num4 = FMFABAKPMLB ^ num3;
		IKFOEMCJCLB = num2 ^ num4;
		int num5 = num ^ (ELNCCDELMMH & num2);
		JCJOMANHEBB = num3 ^ (IKFOEMCJCLB & num5);
		INJJCOCLHNO = (MNIMEAMHNMI & num3) ^ (num4 | JCJOMANHEBB);
		PHJLFAEPHKF = INJJCOCLHNO ^ (num4 ^ num5);
	}

	protected void AMFBGKBELLA(int MNIMEAMHNMI, int BCIHLCMFAEK, int FMFABAKPMLB, int ELNCCDELMMH)
	{
		int num = BCIHLCMFAEK ^ ~MNIMEAMHNMI;
		int num2 = FMFABAKPMLB ^ (MNIMEAMHNMI | num);
		IKFOEMCJCLB = ELNCCDELMMH ^ num2;
		int num3 = BCIHLCMFAEK ^ (ELNCCDELMMH | num);
		int num4 = num ^ IKFOEMCJCLB;
		INJJCOCLHNO = num4 ^ (num2 & num3);
		int num5 = num2 ^ num3;
		JCJOMANHEBB = INJJCOCLHNO ^ num5;
		PHJLFAEPHKF = num2 ^ (num4 & num5);
	}

	protected void NCPIOIPIJEC(int MNIMEAMHNMI, int BCIHLCMFAEK, int FMFABAKPMLB, int ELNCCDELMMH)
	{
		int num = BCIHLCMFAEK ^ ELNCCDELMMH;
		int num2 = MNIMEAMHNMI ^ (BCIHLCMFAEK & num);
		int num3 = num ^ num2;
		INJJCOCLHNO = FMFABAKPMLB ^ num3;
		int num4 = BCIHLCMFAEK ^ (num & num2);
		int num5 = INJJCOCLHNO | num4;
		JCJOMANHEBB = num2 ^ num5;
		int num6 = ~JCJOMANHEBB;
		int num7 = INJJCOCLHNO ^ num4;
		PHJLFAEPHKF = num6 ^ num7;
		IKFOEMCJCLB = num3 ^ (num6 | num7);
	}

	protected void IPBLFGNOGMM(int MNIMEAMHNMI, int BCIHLCMFAEK, int FMFABAKPMLB, int ELNCCDELMMH)
	{
		int num = ~MNIMEAMHNMI;
		int num2 = BCIHLCMFAEK ^ ELNCCDELMMH;
		int num3 = FMFABAKPMLB & num;
		PHJLFAEPHKF = num2 ^ num3;
		int num4 = FMFABAKPMLB ^ num;
		int num5 = FMFABAKPMLB ^ PHJLFAEPHKF;
		int num6 = BCIHLCMFAEK & num5;
		INJJCOCLHNO = num4 ^ num6;
		IKFOEMCJCLB = MNIMEAMHNMI ^ ((ELNCCDELMMH | num6) & (PHJLFAEPHKF | num4));
		JCJOMANHEBB = num2 ^ INJJCOCLHNO ^ (IKFOEMCJCLB ^ (ELNCCDELMMH | num));
	}

	protected void KHCNEPKHEMD(int MNIMEAMHNMI, int BCIHLCMFAEK, int FMFABAKPMLB, int ELNCCDELMMH)
	{
		int num = BCIHLCMFAEK ^ ELNCCDELMMH;
		int num2 = ~num;
		int num3 = MNIMEAMHNMI ^ FMFABAKPMLB;
		int num4 = FMFABAKPMLB ^ num;
		int num5 = BCIHLCMFAEK & num4;
		PHJLFAEPHKF = num3 ^ num5;
		int num6 = MNIMEAMHNMI | num2;
		int num7 = ELNCCDELMMH ^ num6;
		int num8 = num3 | num7;
		INJJCOCLHNO = num ^ num8;
		int num9 = ~num4;
		int num10 = PHJLFAEPHKF | INJJCOCLHNO;
		JCJOMANHEBB = num9 ^ num10;
		IKFOEMCJCLB = (ELNCCDELMMH & num9) ^ (num3 ^ num10);
	}

	protected void KCPIOOIIJDE(int MNIMEAMHNMI, int BCIHLCMFAEK, int FMFABAKPMLB, int ELNCCDELMMH)
	{
		int num = MNIMEAMHNMI ^ BCIHLCMFAEK;
		int num2 = MNIMEAMHNMI & FMFABAKPMLB;
		int num3 = MNIMEAMHNMI | ELNCCDELMMH;
		int num4 = FMFABAKPMLB ^ ELNCCDELMMH;
		int num5 = num & num3;
		int num6 = num2 | num5;
		IKFOEMCJCLB = num4 ^ num6;
		int num7 = BCIHLCMFAEK ^ num3;
		int num8 = num6 ^ num7;
		int num9 = num4 & num8;
		PHJLFAEPHKF = num ^ num9;
		int num10 = IKFOEMCJCLB & PHJLFAEPHKF;
		JCJOMANHEBB = num8 ^ num10;
		INJJCOCLHNO = (BCIHLCMFAEK | ELNCCDELMMH) ^ (num4 ^ num10);
	}

	protected void OCJEMLLIECI(int MNIMEAMHNMI, int BCIHLCMFAEK, int FMFABAKPMLB, int ELNCCDELMMH)
	{
		int num = MNIMEAMHNMI | BCIHLCMFAEK;
		int num2 = BCIHLCMFAEK ^ FMFABAKPMLB;
		int num3 = BCIHLCMFAEK & num2;
		int num4 = MNIMEAMHNMI ^ num3;
		int num5 = FMFABAKPMLB ^ num4;
		int num6 = ELNCCDELMMH | num4;
		PHJLFAEPHKF = num2 ^ num6;
		int num7 = num2 | num6;
		int num8 = ELNCCDELMMH ^ num7;
		IKFOEMCJCLB = num5 ^ num8;
		int num9 = num ^ num8;
		int num10 = PHJLFAEPHKF & num9;
		INJJCOCLHNO = num4 ^ num10;
		JCJOMANHEBB = INJJCOCLHNO ^ (PHJLFAEPHKF ^ num9);
	}

	protected void MHIIDLDCOIG(int MNIMEAMHNMI, int BCIHLCMFAEK, int FMFABAKPMLB, int ELNCCDELMMH)
	{
		int num = MNIMEAMHNMI ^ ELNCCDELMMH;
		int num2 = ELNCCDELMMH & num;
		int num3 = FMFABAKPMLB ^ num2;
		int num4 = BCIHLCMFAEK | num3;
		INJJCOCLHNO = num ^ num4;
		int num5 = ~BCIHLCMFAEK;
		int num6 = num | num5;
		PHJLFAEPHKF = num3 ^ num6;
		int num7 = MNIMEAMHNMI & PHJLFAEPHKF;
		int num8 = num ^ num5;
		int num9 = num4 & num8;
		IKFOEMCJCLB = num7 ^ num9;
		JCJOMANHEBB = MNIMEAMHNMI ^ num3 ^ (num8 & IKFOEMCJCLB);
	}

	protected void BOBLPKBIJHA(int MNIMEAMHNMI, int BCIHLCMFAEK, int FMFABAKPMLB, int ELNCCDELMMH)
	{
		int num = FMFABAKPMLB | ELNCCDELMMH;
		int num2 = MNIMEAMHNMI & num;
		int num3 = BCIHLCMFAEK ^ num2;
		int num4 = MNIMEAMHNMI & num3;
		int num5 = FMFABAKPMLB ^ num4;
		JCJOMANHEBB = ELNCCDELMMH ^ num5;
		int num6 = ~MNIMEAMHNMI;
		int num7 = num5 & JCJOMANHEBB;
		INJJCOCLHNO = num3 ^ num7;
		int num8 = JCJOMANHEBB | num6;
		int num9 = ELNCCDELMMH ^ num8;
		PHJLFAEPHKF = INJJCOCLHNO ^ num9;
		IKFOEMCJCLB = (num3 & num9) ^ (JCJOMANHEBB ^ num6);
	}

	protected void FGOLHEDHDKO(int MNIMEAMHNMI, int BCIHLCMFAEK, int FMFABAKPMLB, int ELNCCDELMMH)
	{
		int num = ~MNIMEAMHNMI;
		int num2 = MNIMEAMHNMI ^ BCIHLCMFAEK;
		int num3 = MNIMEAMHNMI ^ ELNCCDELMMH;
		int num4 = FMFABAKPMLB ^ num;
		int num5 = num2 | num3;
		PHJLFAEPHKF = num4 ^ num5;
		int num6 = ELNCCDELMMH & PHJLFAEPHKF;
		int num7 = num2 ^ PHJLFAEPHKF;
		JCJOMANHEBB = num6 ^ num7;
		int num8 = num | PHJLFAEPHKF;
		int num9 = num2 | num6;
		int num10 = num3 ^ num8;
		IKFOEMCJCLB = num9 ^ num10;
		INJJCOCLHNO = BCIHLCMFAEK ^ num6 ^ (JCJOMANHEBB & num10);
	}

	protected void ICFGOEMINND(int MNIMEAMHNMI, int BCIHLCMFAEK, int FMFABAKPMLB, int ELNCCDELMMH)
	{
		int num = ~FMFABAKPMLB;
		int num2 = BCIHLCMFAEK & num;
		int num3 = ELNCCDELMMH ^ num2;
		int num4 = MNIMEAMHNMI & num3;
		int num5 = BCIHLCMFAEK ^ num;
		INJJCOCLHNO = num4 ^ num5;
		int num6 = BCIHLCMFAEK | INJJCOCLHNO;
		int num7 = MNIMEAMHNMI & num6;
		JCJOMANHEBB = num3 ^ num7;
		int num8 = MNIMEAMHNMI | ELNCCDELMMH;
		int num9 = num ^ num6;
		PHJLFAEPHKF = num8 ^ num9;
		IKFOEMCJCLB = (BCIHLCMFAEK & num8) ^ (num4 | (MNIMEAMHNMI ^ FMFABAKPMLB));
	}

	protected void OLJNLFCDPKD(int MNIMEAMHNMI, int BCIHLCMFAEK, int FMFABAKPMLB, int ELNCCDELMMH)
	{
		int num = ~MNIMEAMHNMI;
		int num2 = MNIMEAMHNMI ^ ELNCCDELMMH;
		int num3 = BCIHLCMFAEK ^ num2;
		int num4 = num | num2;
		int num5 = FMFABAKPMLB ^ num4;
		JCJOMANHEBB = BCIHLCMFAEK ^ num5;
		int num6 = num2 | JCJOMANHEBB;
		int num7 = ELNCCDELMMH ^ num6;
		int num8 = num5 & num7;
		IKFOEMCJCLB = num3 ^ num8;
		int num9 = num5 ^ num7;
		PHJLFAEPHKF = IKFOEMCJCLB ^ num9;
		INJJCOCLHNO = ~num5 ^ (num3 & num9);
	}

	protected void NEHAMLNENFP(int MNIMEAMHNMI, int BCIHLCMFAEK, int FMFABAKPMLB, int ELNCCDELMMH)
	{
		int num = ~MNIMEAMHNMI;
		int num2 = MNIMEAMHNMI ^ BCIHLCMFAEK;
		int num3 = FMFABAKPMLB ^ num2;
		int num4 = FMFABAKPMLB | num;
		int num5 = ELNCCDELMMH ^ num4;
		JCJOMANHEBB = num3 ^ num5;
		int num6 = num3 & num5;
		int num7 = num2 ^ num6;
		int num8 = BCIHLCMFAEK | num7;
		INJJCOCLHNO = num5 ^ num8;
		int num9 = BCIHLCMFAEK | INJJCOCLHNO;
		PHJLFAEPHKF = num7 ^ num9;
		IKFOEMCJCLB = (ELNCCDELMMH & num) ^ (num3 ^ num9);
	}

	protected void FPNCLDPHOIJ(int MNIMEAMHNMI, int BCIHLCMFAEK, int FMFABAKPMLB, int ELNCCDELMMH)
	{
		int num = BCIHLCMFAEK ^ FMFABAKPMLB;
		int num2 = FMFABAKPMLB & num;
		int num3 = ELNCCDELMMH ^ num2;
		int num4 = MNIMEAMHNMI ^ num3;
		int num5 = ELNCCDELMMH | num;
		int num6 = num4 & num5;
		JCJOMANHEBB = BCIHLCMFAEK ^ num6;
		int num7 = num3 | JCJOMANHEBB;
		int num8 = MNIMEAMHNMI & num4;
		INJJCOCLHNO = num ^ num8;
		int num9 = num4 ^ num7;
		int num10 = INJJCOCLHNO & num9;
		IKFOEMCJCLB = num3 ^ num10;
		PHJLFAEPHKF = ~num9 ^ (INJJCOCLHNO & IKFOEMCJCLB);
	}

	protected void LDDBJAEMDBF(int MNIMEAMHNMI, int BCIHLCMFAEK, int FMFABAKPMLB, int ELNCCDELMMH)
	{
		int num = FMFABAKPMLB | (MNIMEAMHNMI & BCIHLCMFAEK);
		int num2 = ELNCCDELMMH & (MNIMEAMHNMI | BCIHLCMFAEK);
		INJJCOCLHNO = num ^ num2;
		int num3 = ~ELNCCDELMMH;
		int num4 = BCIHLCMFAEK ^ num2;
		int num5 = num4 | (INJJCOCLHNO ^ num3);
		JCJOMANHEBB = MNIMEAMHNMI ^ num5;
		PHJLFAEPHKF = FMFABAKPMLB ^ num4 ^ (ELNCCDELMMH | JCJOMANHEBB);
		IKFOEMCJCLB = num ^ JCJOMANHEBB ^ (PHJLFAEPHKF ^ (MNIMEAMHNMI & INJJCOCLHNO));
	}

	protected void CDIAGCMJAMM()
	{
		int num = MBBDJFKAACD(PHJLFAEPHKF, 13);
		int num2 = MBBDJFKAACD(IKFOEMCJCLB, 3);
		int aMFCENFNAJJ = JCJOMANHEBB ^ num ^ num2;
		int aMFCENFNAJJ2 = INJJCOCLHNO ^ num2 ^ (num << 3);
		JCJOMANHEBB = MBBDJFKAACD(aMFCENFNAJJ, 1);
		INJJCOCLHNO = MBBDJFKAACD(aMFCENFNAJJ2, 7);
		PHJLFAEPHKF = MBBDJFKAACD(num ^ JCJOMANHEBB ^ INJJCOCLHNO, 5);
		IKFOEMCJCLB = MBBDJFKAACD(num2 ^ INJJCOCLHNO ^ (JCJOMANHEBB << 7), 22);
	}

	protected void BHNHEBHCDOP()
	{
		int num = AIFAMJPHAAF(IKFOEMCJCLB, 22) ^ INJJCOCLHNO ^ (JCJOMANHEBB << 7);
		int num2 = AIFAMJPHAAF(PHJLFAEPHKF, 5) ^ JCJOMANHEBB ^ INJJCOCLHNO;
		int num3 = AIFAMJPHAAF(INJJCOCLHNO, 7);
		int num4 = AIFAMJPHAAF(JCJOMANHEBB, 1);
		INJJCOCLHNO = num3 ^ num ^ (num2 << 3);
		JCJOMANHEBB = num4 ^ num2 ^ num;
		IKFOEMCJCLB = AIFAMJPHAAF(num, 3);
		PHJLFAEPHKF = AIFAMJPHAAF(num2, 13);
	}

	protected abstract int[] HLJJADHKDFK(byte[] IKNCPEPOKGJ);

	protected abstract void HDOLNBOHAJA(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC);

	protected abstract void GFKALHGNIOJ(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC);
}
