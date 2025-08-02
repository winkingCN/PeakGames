using System;
using System.Globalization;

public class KAGLNJGDIPD : LNKPCJLANAO, MFHFAODDMLI
{
	private readonly EDOEBJJFOBM HFLODNLEGFL;

	public KAGLNJGDIPD(EDOEBJJFOBM HFLODNLEGFL)
	{
		if (HFLODNLEGFL == null)
		{
			throw new ArgumentNullException("time");
		}
		if (!(HFLODNLEGFL is ECAOIPMOFLJ) && !(HFLODNLEGFL is DHKNJKJFPIP))
		{
			throw new ArgumentException("unknown object passed to Time");
		}
		this.HFLODNLEGFL = HFLODNLEGFL;
	}

	public KAGLNJGDIPD(DateTime EFDBEGKAEHG)
	{
		string text = EFDBEGKAEHG.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture) + "Z";
		int num = int.Parse(text.Substring(0, 4));
		if (num < 1950 || num > 2049)
		{
			HFLODNLEGFL = new DHKNJKJFPIP(text);
		}
		else
		{
			HFLODNLEGFL = new ECAOIPMOFLJ(text.Substring(2));
		}
	}

	public static KAGLNJGDIPD BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DHGLJHFEJFL)
	{
		return BJLJCGFMFOO(NEMEKIOEOLC.NFMFKPLPLLH());
	}

	public static KAGLNJGDIPD BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is KAGLNJGDIPD)
		{
			return (KAGLNJGDIPD)NEMEKIOEOLC;
		}
		if (NEMEKIOEOLC is ECAOIPMOFLJ)
		{
			return new KAGLNJGDIPD((ECAOIPMOFLJ)NEMEKIOEOLC);
		}
		if (NEMEKIOEOLC is DHKNJKJFPIP)
		{
			return new KAGLNJGDIPD((DHKNJKJFPIP)NEMEKIOEOLC);
		}
		throw new ArgumentException("unknown object in factory: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC), "obj");
	}

	public string FPLOJBLADJG()
	{
		if (HFLODNLEGFL is ECAOIPMOFLJ)
		{
			return ((ECAOIPMOFLJ)HFLODNLEGFL).OOOIDLCADKD;
		}
		return ((DHKNJKJFPIP)HFLODNLEGFL).FPLOJBLADJG();
	}

	public DateTime EMPBKDFFLFI()
	{
		try
		{
			if (HFLODNLEGFL is ECAOIPMOFLJ)
			{
				return ((ECAOIPMOFLJ)HFLODNLEGFL).FIDJJDOBHOF();
			}
			return ((DHKNJKJFPIP)HFLODNLEGFL).EMPBKDFFLFI();
		}
		catch (FormatException ex)
		{
			throw new InvalidOperationException("invalid date string: " + ex.Message);
		}
	}

	public override EDOEBJJFOBM IIHKEACDNID()
	{
		return HFLODNLEGFL;
	}

	public override string ToString()
	{
		return FPLOJBLADJG();
	}
}
