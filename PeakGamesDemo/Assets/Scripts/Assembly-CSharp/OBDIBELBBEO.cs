using System;

public sealed class OBDIBELBBEO
{
	public static readonly OBDIBELBBEO IMMFLDCIBJC = new OBDIBELBBEO(768, "SSL 3.0");

	public static readonly OBDIBELBBEO PBNEGCKIBHE = new OBDIBELBBEO(769, "TLS 1.0");

	public static readonly OBDIBELBBEO FINBKBPMNOH = new OBDIBELBBEO(770, "TLS 1.1");

	public static readonly OBDIBELBBEO JIBPNECGBPK = new OBDIBELBBEO(771, "TLS 1.2");

	public static readonly OBDIBELBBEO PPLJKHLBLAC = new OBDIBELBBEO(65279, "DTLS 1.0");

	public static readonly OBDIBELBBEO PDHBDKKNIMB = new OBDIBELBBEO(65277, "DTLS 1.2");

	private readonly int DFCJKBHFPMG;

	private readonly string IOCMOCCFALN;

	public int MFDKBMJLLBB
	{
		get
		{
			return DFCJKBHFPMG;
		}
	}

	public int LHJCOHDLJAO
	{
		get
		{
			return DFCJKBHFPMG >> 8;
		}
	}

	public int JBFBIHMBNDA
	{
		get
		{
			return DFCJKBHFPMG & 0xFF;
		}
	}

	public bool KEDPJOBAJBA
	{
		get
		{
			return LHJCOHDLJAO == 254;
		}
	}

	public bool NFEADLBGDGE
	{
		get
		{
			return this == IMMFLDCIBJC;
		}
	}

	public bool CNOJNEGPDLN
	{
		get
		{
			return LHJCOHDLJAO == 3;
		}
	}

	private OBDIBELBBEO(int AAIEJDNAODP, string IOCMOCCFALN)
	{
		DFCJKBHFPMG = AAIEJDNAODP & 0xFFFF;
		this.IOCMOCCFALN = IOCMOCCFALN;
	}

	public OBDIBELBBEO EMPACBICMIM()
	{
		if (!KEDPJOBAJBA)
		{
			return this;
		}
		if (this == PPLJKHLBLAC)
		{
			return FINBKBPMNOH;
		}
		return JIBPNECGBPK;
	}

	public bool BMJPEMBKPII(OBDIBELBBEO DFCJKBHFPMG)
	{
		if (LHJCOHDLJAO != DFCJKBHFPMG.LHJCOHDLJAO)
		{
			return false;
		}
		int num = DFCJKBHFPMG.JBFBIHMBNDA - JBFBIHMBNDA;
		return (!KEDPJOBAJBA) ? (num >= 0) : (num <= 0);
	}

	public bool BPNNNAMIOJN(OBDIBELBBEO DFCJKBHFPMG)
	{
		if (LHJCOHDLJAO != DFCJKBHFPMG.LHJCOHDLJAO)
		{
			return false;
		}
		int num = DFCJKBHFPMG.JBFBIHMBNDA - JBFBIHMBNDA;
		return (!KEDPJOBAJBA) ? (num < 0) : (num > 0);
	}

	public override bool Equals(object CJHEIBNHNNE)
	{
		return this == CJHEIBNHNNE || (CJHEIBNHNNE is OBDIBELBBEO && KIFDKLPDKMD((OBDIBELBBEO)CJHEIBNHNNE));
	}

	public bool KIFDKLPDKMD(OBDIBELBBEO CJHEIBNHNNE)
	{
		return CJHEIBNHNNE != null && DFCJKBHFPMG == CJHEIBNHNNE.DFCJKBHFPMG;
	}

	public override int GetHashCode()
	{
		return DFCJKBHFPMG;
	}

	public static OBDIBELBBEO GHBGCADFLFB(int PNMGIIIFEGM, int MAHHNNMKOCM)
	{
		switch (PNMGIIIFEGM)
		{
		case 3:
			switch (MAHHNNMKOCM)
			{
			case 0:
				return IMMFLDCIBJC;
			case 1:
				return PBNEGCKIBHE;
			case 2:
				return FINBKBPMNOH;
			case 3:
				return JIBPNECGBPK;
			default:
				return NHFIONINIOF(PNMGIIIFEGM, MAHHNNMKOCM, "TLS");
			}
		case 254:
			switch (MAHHNNMKOCM)
			{
			case 255:
				return PPLJKHLBLAC;
			case 254:
				throw new DEIDBCPPCMB(47);
			case 253:
				return PDHBDKKNIMB;
			default:
				return NHFIONINIOF(PNMGIIIFEGM, MAHHNNMKOCM, "DTLS");
			}
		default:
			throw new DEIDBCPPCMB(47);
		}
	}

	public override string ToString()
	{
		return IOCMOCCFALN;
	}

	private static OBDIBELBBEO NHFIONINIOF(int PNMGIIIFEGM, int MAHHNNMKOCM, string AEKIHILHNPD)
	{
		KINEBFNENMB.PMEHMKFPAEC(PNMGIIIFEGM);
		KINEBFNENMB.PMEHMKFPAEC(MAHHNNMKOCM);
		int num = (PNMGIIIFEGM << 8) | MAHHNNMKOCM;
		string text = LHFGHNFJIKM.OGLCLCODHJI(Convert.ToString(0x10000 | num, 16).Substring(1));
		return new OBDIBELBBEO(num, AEKIHILHNPD + " 0x" + text);
	}
}
