using System;
using System.Globalization;

public class ECAOIPMOFLJ : EDOEBJJFOBM
{
	private readonly string HFLODNLEGFL;

	public string HHNHEBFACPL
	{
		get
		{
			if (HFLODNLEGFL.IndexOf('-') < 0 && HFLODNLEGFL.IndexOf('+') < 0)
			{
				if (HFLODNLEGFL.Length == 11)
				{
					return HFLODNLEGFL.Substring(0, 10) + "00GMT+00:00";
				}
				return HFLODNLEGFL.Substring(0, 12) + "GMT+00:00";
			}
			int num = HFLODNLEGFL.IndexOf('-');
			if (num < 0)
			{
				num = HFLODNLEGFL.IndexOf('+');
			}
			string text = HFLODNLEGFL;
			if (num == HFLODNLEGFL.Length - 3)
			{
				text += "00";
			}
			if (num == 10)
			{
				return text.Substring(0, 10) + "00GMT" + text.Substring(10, 3) + ":" + text.Substring(13, 2);
			}
			return text.Substring(0, 12) + "GMT" + text.Substring(12, 3) + ":" + text.Substring(15, 2);
		}
	}

	[Obsolete("Use 'AdjustedTimeString' property instead")]
	public string DJKAPIEJJBK
	{
		get
		{
			return OOOIDLCADKD;
		}
	}

	public string OOOIDLCADKD
	{
		get
		{
			string text = HHNHEBFACPL;
			string text2 = ((text[0] >= '5') ? "19" : "20");
			return text2 + text;
		}
	}

	public ECAOIPMOFLJ(string HFLODNLEGFL)
	{
		if (HFLODNLEGFL == null)
		{
			throw new ArgumentNullException("time");
		}
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

	public ECAOIPMOFLJ(DateTime HFLODNLEGFL)
	{
		this.HFLODNLEGFL = HFLODNLEGFL.ToString("yyMMddHHmmss", CultureInfo.InvariantCulture) + "Z";
	}

	internal ECAOIPMOFLJ(byte[] DIPNEDDIHBK)
	{
		HFLODNLEGFL = CCGLOIJJMKC.DNHBLFMKDDH(DIPNEDDIHBK);
	}

	public static ECAOIPMOFLJ BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is ECAOIPMOFLJ)
		{
			return (ECAOIPMOFLJ)NEMEKIOEOLC;
		}
		throw new ArgumentException("illegal object in GetInstance: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC));
	}

	public static ECAOIPMOFLJ BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DNBCBHLACCP)
	{
		EDOEBJJFOBM eDOEBJJFOBM = NEMEKIOEOLC.NFMFKPLPLLH();
		if (DNBCBHLACCP || eDOEBJJFOBM is ECAOIPMOFLJ)
		{
			return BJLJCGFMFOO(eDOEBJJFOBM);
		}
		return new ECAOIPMOFLJ(((PJGIGKJFGFI)eDOEBJJFOBM).KLHNEKMCKKI());
	}

	public DateTime EMPBKDFFLFI()
	{
		return EGNINLFNJEL(HHNHEBFACPL, "yyMMddHHmmss'GMT'zzz");
	}

	public DateTime FIDJJDOBHOF()
	{
		return EGNINLFNJEL(OOOIDLCADKD, "yyyyMMddHHmmss'GMT'zzz");
	}

	private DateTime EGNINLFNJEL(string KCHMLNKHIHL, string GDFLOJBIAOO)
	{
		return DateTime.ParseExact(KCHMLNKHIHL, GDFLOJBIAOO, DateTimeFormatInfo.InvariantInfo).ToUniversalTime();
	}

	private byte[] KLHNEKMCKKI()
	{
		return CCGLOIJJMKC.IFHLAPJLHNG(HFLODNLEGFL);
	}

	internal override void LMDBBPLCJDM(JBLJHINPLMC NMHOOGAGLOA)
	{
		NMHOOGAGLOA.AGNEJPEMPAP(23, KLHNEKMCKKI());
	}

	protected override bool IMHPDJGGAGJ(EDOEBJJFOBM LABMKGMAEGK)
	{
		ECAOIPMOFLJ eCAOIPMOFLJ = LABMKGMAEGK as ECAOIPMOFLJ;
		if (eCAOIPMOFLJ == null)
		{
			return false;
		}
		return HFLODNLEGFL.Equals(eCAOIPMOFLJ.HFLODNLEGFL);
	}

	protected override int BGFGDLGFEPI()
	{
		return HFLODNLEGFL.GetHashCode();
	}

	public override string ToString()
	{
		return HFLODNLEGFL;
	}
}
