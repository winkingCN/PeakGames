using System;
using System.Globalization;
using System.Text;

public class DHKNJKJFPIP : EDOEBJJFOBM
{
	private readonly string HFLODNLEGFL;

	public string HHNHEBFACPL
	{
		get
		{
			return HFLODNLEGFL;
		}
	}

	private bool FJAFOJBIDBD
	{
		get
		{
			return HFLODNLEGFL.IndexOf('.') == 14;
		}
	}

	public DHKNJKJFPIP(string HFLODNLEGFL)
	{
		this.HFLODNLEGFL = HFLODNLEGFL;
		try
		{
			EMPBKDFFLFI();
		}
		catch (FormatException ex)
		{
			throw new ArgumentException("invalid date string: " + ex.Message);
		}
	}

	public DHKNJKJFPIP(DateTime HFLODNLEGFL)
	{
		this.HFLODNLEGFL = HFLODNLEGFL.ToString("yyyyMMddHHmmss\\Z");
	}

	internal DHKNJKJFPIP(byte[] DIPNEDDIHBK)
	{
		HFLODNLEGFL = CCGLOIJJMKC.DNHBLFMKDDH(DIPNEDDIHBK);
	}

	public static DHKNJKJFPIP BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is DHKNJKJFPIP)
		{
			return (DHKNJKJFPIP)NEMEKIOEOLC;
		}
		throw new ArgumentException("illegal object in GetInstance: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC), "obj");
	}

	public static DHKNJKJFPIP BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DNBCBHLACCP)
	{
		EDOEBJJFOBM eDOEBJJFOBM = NEMEKIOEOLC.NFMFKPLPLLH();
		if (DNBCBHLACCP || eDOEBJJFOBM is DHKNJKJFPIP)
		{
			return BJLJCGFMFOO(eDOEBJJFOBM);
		}
		return new DHKNJKJFPIP(((PJGIGKJFGFI)eDOEBJJFOBM).KLHNEKMCKKI());
	}

	public string FPLOJBLADJG()
	{
		if (HFLODNLEGFL[HFLODNLEGFL.Length - 1] == 'Z')
		{
			return HFLODNLEGFL.Substring(0, HFLODNLEGFL.Length - 1) + "GMT+00:00";
		}
		int num = HFLODNLEGFL.Length - 5;
		char c = HFLODNLEGFL[num];
		if (c == '-' || c == '+')
		{
			return HFLODNLEGFL.Substring(0, num) + "GMT" + HFLODNLEGFL.Substring(num, 3) + ":" + HFLODNLEGFL.Substring(num + 3);
		}
		num = HFLODNLEGFL.Length - 3;
		c = HFLODNLEGFL[num];
		if (c == '-' || c == '+')
		{
			return HFLODNLEGFL.Substring(0, num) + "GMT" + HFLODNLEGFL.Substring(num) + ":00";
		}
		return HFLODNLEGFL + GGJIAAHFMNM();
	}

	private string GGJIAAHFMNM()
	{
		char c = '+';
		DateTime time = EMPBKDFFLFI();
		TimeSpan timeSpan = TimeZone.CurrentTimeZone.GetUtcOffset(time);
		if (timeSpan.CompareTo(TimeSpan.Zero) < 0)
		{
			c = '-';
			timeSpan = timeSpan.Duration();
		}
		int hours = timeSpan.Hours;
		int minutes = timeSpan.Minutes;
		return "GMT" + c + JEFLOGJKAMH(hours) + ":" + JEFLOGJKAMH(minutes);
	}

	private static string JEFLOGJKAMH(int HFLODNLEGFL)
	{
		if (HFLODNLEGFL < 10)
		{
			return "0" + HFLODNLEGFL;
		}
		return HFLODNLEGFL.ToString();
	}

	public DateTime EMPBKDFFLFI()
	{
		string text = HFLODNLEGFL;
		bool oCKCNPNCMCL = false;
		string mIIBBFPMFLH;
		if (LHFGHNFJIKM.BGIBPBNIHDL(text, "Z"))
		{
			if (FJAFOJBIDBD)
			{
				int eNMLICFLHAO = text.Length - text.IndexOf('.') - 2;
				mIIBBFPMFLH = "yyyyMMddHHmmss." + DIHIFOIINNO(eNMLICFLHAO) + "\\Z";
			}
			else
			{
				mIIBBFPMFLH = "yyyyMMddHHmmss\\Z";
			}
		}
		else if (HFLODNLEGFL.IndexOf('-') > 0 || HFLODNLEGFL.IndexOf('+') > 0)
		{
			text = FPLOJBLADJG();
			oCKCNPNCMCL = true;
			if (FJAFOJBIDBD)
			{
				int eNMLICFLHAO2 = LHFGHNFJIKM.NFLFPHCMIOK(text, "GMT") - 1 - text.IndexOf('.');
				mIIBBFPMFLH = "yyyyMMddHHmmss." + DIHIFOIINNO(eNMLICFLHAO2) + "'GMT'zzz";
			}
			else
			{
				mIIBBFPMFLH = "yyyyMMddHHmmss'GMT'zzz";
			}
		}
		else if (FJAFOJBIDBD)
		{
			int eNMLICFLHAO3 = text.Length - 1 - text.IndexOf('.');
			mIIBBFPMFLH = "yyyyMMddHHmmss." + DIHIFOIINNO(eNMLICFLHAO3);
		}
		else
		{
			mIIBBFPMFLH = "yyyyMMddHHmmss";
		}
		return EGNINLFNJEL(text, mIIBBFPMFLH, oCKCNPNCMCL);
	}

	private string DIHIFOIINNO(int ENMLICFLHAO)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < ENMLICFLHAO; i++)
		{
			stringBuilder.Append('f');
		}
		return stringBuilder.ToString();
	}

	private DateTime EGNINLFNJEL(string IBBBMACIBGK, string MIIBBFPMFLH, bool OCKCNPNCMCL)
	{
		DateTimeStyles dateTimeStyles = DateTimeStyles.None;
		if (LHFGHNFJIKM.BGIBPBNIHDL(MIIBBFPMFLH, "Z"))
		{
			try
			{
				dateTimeStyles = (DateTimeStyles)(object)APJJMPFMLBB.OAOMOAFOOKD(typeof(DateTimeStyles), "AssumeUniversal");
			}
			catch (Exception)
			{
			}
			dateTimeStyles |= DateTimeStyles.AdjustToUniversal;
		}
		DateTime dateTime = DateTime.ParseExact(IBBBMACIBGK, MIIBBFPMFLH, DateTimeFormatInfo.InvariantInfo, dateTimeStyles);
		return (!OCKCNPNCMCL) ? dateTime : dateTime.ToUniversalTime();
	}

	private byte[] KLHNEKMCKKI()
	{
		return CCGLOIJJMKC.IFHLAPJLHNG(HFLODNLEGFL);
	}

	internal override void LMDBBPLCJDM(JBLJHINPLMC NMHOOGAGLOA)
	{
		NMHOOGAGLOA.AGNEJPEMPAP(24, KLHNEKMCKKI());
	}

	protected override bool IMHPDJGGAGJ(EDOEBJJFOBM LABMKGMAEGK)
	{
		DHKNJKJFPIP dHKNJKJFPIP = LABMKGMAEGK as DHKNJKJFPIP;
		if (dHKNJKJFPIP == null)
		{
			return false;
		}
		return HFLODNLEGFL.Equals(dHKNJKJFPIP.HFLODNLEGFL);
	}

	protected override int BGFGDLGFEPI()
	{
		return HFLODNLEGFL.GetHashCode();
	}
}
