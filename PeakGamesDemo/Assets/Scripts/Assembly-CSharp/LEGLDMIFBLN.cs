using System;
using System.Runtime.CompilerServices;

public struct LEGLDMIFBLN
{
	public static readonly LEGLDMIFBLN JIKOOGGLMBO = new LEGLDMIFBLN(Guid.Empty);

	private Guid NMGKOOLOPKJ;

	private string DMHJCFJPAGA;

	public Guid GPIIGHOGOCH
	{
		get
		{
			return NMGKOOLOPKJ;
		}
		set
		{
			if (value != NMGKOOLOPKJ)
			{
				NMGKOOLOPKJ = value;
				DMHJCFJPAGA = LMDBBPLCJDM(value);
			}
		}
	}

	public string JBGOANMLBFA
	{
		get
		{
			return DMHJCFJPAGA;
		}
		set
		{
			if (value != DMHJCFJPAGA)
			{
				DMHJCFJPAGA = value;
				NMGKOOLOPKJ = ILOALOLANOL(value);
			}
		}
	}

	public LEGLDMIFBLN(string EDDNOJDPMCF)
	{
		DMHJCFJPAGA = EDDNOJDPMCF;
		NMGKOOLOPKJ = ILOALOLANOL(EDDNOJDPMCF);
	}

	public LEGLDMIFBLN(Guid FAPFIHABIPO)
	{
		DMHJCFJPAGA = LMDBBPLCJDM(FAPFIHABIPO);
		NMGKOOLOPKJ = FAPFIHABIPO;
	}

	public override string ToString()
	{
		return DMHJCFJPAGA;
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC is LEGLDMIFBLN)
		{
			return NMGKOOLOPKJ.Equals(((LEGLDMIFBLN)NEMEKIOEOLC).NMGKOOLOPKJ);
		}
		if (NEMEKIOEOLC is Guid)
		{
			return NMGKOOLOPKJ.Equals((Guid)NEMEKIOEOLC);
		}
		if (NEMEKIOEOLC is string)
		{
			return NMGKOOLOPKJ.Equals(((LEGLDMIFBLN)NEMEKIOEOLC).NMGKOOLOPKJ);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return NMGKOOLOPKJ.GetHashCode();
	}

	public static LEGLDMIFBLN NMLEKDPKNLB()
	{
		return new LEGLDMIFBLN(Guid.NewGuid());
	}

	public static string LMDBBPLCJDM(string EDDNOJDPMCF)
	{
		Guid fAPFIHABIPO = new Guid(EDDNOJDPMCF);
		return LMDBBPLCJDM(fAPFIHABIPO);
	}

	public static string LMDBBPLCJDM(Guid FAPFIHABIPO)
	{
		string text = Convert.ToBase64String(FAPFIHABIPO.ToByteArray());
		text = text.Replace("/", "_").Replace("+", "-");
		return text.Substring(0, 22);
	}

	public static Guid ILOALOLANOL(string EDDNOJDPMCF)
	{
		EDDNOJDPMCF = EDDNOJDPMCF.Replace("_", "/").Replace("-", "+");
		byte[] b = Convert.FromBase64String(EDDNOJDPMCF + "==");
		return new Guid(b);
	}

	[SpecialName]
	public static bool OCAFFLHPIMM(LEGLDMIFBLN AMFCENFNAJJ, LEGLDMIFBLN CNLILOEEBOJ)
	{
		if ((object)AMFCENFNAJJ == null)
		{
			return (object)CNLILOEEBOJ == null;
		}
		return AMFCENFNAJJ.NMGKOOLOPKJ == CNLILOEEBOJ.NMGKOOLOPKJ;
	}

	[SpecialName]
	public static bool BLPPLFIKFPN(LEGLDMIFBLN AMFCENFNAJJ, LEGLDMIFBLN CNLILOEEBOJ)
	{
		return !OCAFFLHPIMM(AMFCENFNAJJ, CNLILOEEBOJ);
	}

	[SpecialName]
	public static string AGIIAGNEIKI(LEGLDMIFBLN LIMFJKPCEPP)
	{
		return LIMFJKPCEPP.DMHJCFJPAGA;
	}

	[SpecialName]
	public static Guid AGIIAGNEIKI(LEGLDMIFBLN LIMFJKPCEPP)
	{
		return LIMFJKPCEPP.NMGKOOLOPKJ;
	}

	[SpecialName]
	public static LEGLDMIFBLN AGIIAGNEIKI(string LIMFJKPCEPP)
	{
		return new LEGLDMIFBLN(LIMFJKPCEPP);
	}

	[SpecialName]
	public static LEGLDMIFBLN AGIIAGNEIKI(Guid FAPFIHABIPO)
	{
		return new LEGLDMIFBLN(FAPFIHABIPO);
	}
}
