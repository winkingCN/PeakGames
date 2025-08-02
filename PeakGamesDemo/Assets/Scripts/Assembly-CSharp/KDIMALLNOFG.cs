using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public struct KDIMALLNOFG
{
	public DateTime CNBGPDDMHIL;

	public DateTime FODMIABOAFM;

	public KDIMALLNOFG(string GLMLFOOCLPJ)
	{
		CNBGPDDMHIL = DateTime.MinValue;
		FODMIABOAFM = DateTime.MinValue;
		if (GLMLFOOCLPJ != null)
		{
			int num = GLMLFOOCLPJ.IndexOf(" ");
			long result;
			long.TryParse(GLMLFOOCLPJ.Substring(0, num), out result);
			long result2;
			long.TryParse(GLMLFOOCLPJ.Substring(num + 1), out result2);
			if (result > 0)
			{
				CNBGPDDMHIL = DGOIABOILEG(result);
			}
			FODMIABOAFM = DGOIABOILEG(result2);
		}
	}

	public KDIMALLNOFG(DateTime DCOMPHKNBHJ)
	{
		FODMIABOAFM = DCOMPHKNBHJ;
		CNBGPDDMHIL = DateTime.MinValue;
	}

	public KDIMALLNOFG(DateTime DCOMPHKNBHJ, DateTime GEFEKHEMPPD)
	{
		FODMIABOAFM = DCOMPHKNBHJ;
		CNBGPDDMHIL = GEFEKHEMPPD;
	}

	public bool DFMLFFJGHOM()
	{
		return CNBGPDDMHIL > DateTime.MinValue;
	}

	public bool KOOPOIBAFJO()
	{
		return FODMIABOAFM > DateTime.MinValue;
	}

	public void JMCCKLJCKKH(TimeSpan FNJHPJDHLPE)
	{
		FODMIABOAFM = FODMIABOAFM.Add(FNJHPJDHLPE);
		if (DFMLFFJGHOM())
		{
			CNBGPDDMHIL = CNBGPDDMHIL.Add(FNJHPJDHLPE);
		}
	}

	public void FKBJBNOGFLE(TimeSpan FNJHPJDHLPE)
	{
		FODMIABOAFM = FODMIABOAFM.Subtract(FNJHPJDHLPE);
		if (DFMLFFJGHOM())
		{
			CNBGPDDMHIL = CNBGPDDMHIL.Subtract(FNJHPJDHLPE);
		}
	}

	[SpecialName]
	public static TimeSpan IHHPDAKLIGF(KDIMALLNOFG LEPEJBPNEGF, KDIMALLNOFG MPEHCEJCOBE)
	{
		if (LEPEJBPNEGF.DFMLFFJGHOM() && MPEHCEJCOBE.DFMLFFJGHOM())
		{
			return LEPEJBPNEGF.CNBGPDDMHIL - MPEHCEJCOBE.CNBGPDDMHIL;
		}
		return LEPEJBPNEGF.FODMIABOAFM - MPEHCEJCOBE.FODMIABOAFM;
	}

	public static bool NJADEEMOMGL(KDIMALLNOFG ICFNEGLFCAP, KDIMALLNOFG CGAHNAJBIBN)
	{
		bool flag = (CGAHNAJBIBN.FODMIABOAFM - ICFNEGLFCAP.FODMIABOAFM).TotalSeconds > -30.0;
		if (!flag)
		{
			return false;
		}
		if (!ICFNEGLFCAP.DFMLFFJGHOM() || !CGAHNAJBIBN.DFMLFFJGHOM())
		{
			return flag;
		}
		if ((CGAHNAJBIBN.CNBGPDDMHIL - ICFNEGLFCAP.CNBGPDDMHIL).TotalSeconds < -120.0)
		{
			return false;
		}
		return Mathf.Abs(ICFNEGLFCAP.COOLFBDPHEO() - CGAHNAJBIBN.COOLFBDPHEO()) < 900f;
	}

	private float COOLFBDPHEO()
	{
		return Mathf.Abs((float)(CNBGPDDMHIL.ToUniversalTime() - FODMIABOAFM.ToUniversalTime()).TotalSeconds);
	}

	public string ONBGDIHNPHI()
	{
		long num = ((!DFMLFFJGHOM()) ? 0 : NACBGDKBMGB(CNBGPDDMHIL));
		return num + " " + NACBGDKBMGB(FODMIABOAFM);
	}

	public override string ToString()
	{
		return string.Format("Online: {0}, Offline: {1} with Diff: {2}", CNBGPDDMHIL, FODMIABOAFM, COOLFBDPHEO());
	}

	public static DateTime DGOIABOILEG(long FGEFLFBMPNE)
	{
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		try
		{
			return dateTime.AddSeconds(FGEFLFBMPNE);
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		return DateTime.Now;
	}

	public static long NACBGDKBMGB(DateTime EFDBEGKAEHG)
	{
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		return Convert.ToInt64((EFDBEGKAEHG - dateTime).TotalSeconds);
	}

	public bool ECGBOAIAJOO()
	{
		return !KOOPOIBAFJO() && !DFMLFFJGHOM();
	}

	public DateTime DBIMKDHPELE()
	{
		return (!DFMLFFJGHOM()) ? FODMIABOAFM : CNBGPDDMHIL;
	}

	public bool AMFFIMFBOEF(KDIMALLNOFG MFGDDLJGLFE)
	{
		if (DFMLFFJGHOM() && MFGDDLJGLFE.DFMLFFJGHOM())
		{
			return (MFGDDLJGLFE.CNBGPDDMHIL - CNBGPDDMHIL).TotalSeconds > -120.0;
		}
		return (MFGDDLJGLFE.FODMIABOAFM - FODMIABOAFM).TotalSeconds > -30.0;
	}
}
