using System;
using System.Collections;
using System.Text;

public abstract class FKHLBMJPCIM
{
	public static void OJCDNLBIAPD(IList BMIOECELGCA, IEnumerable HOEMCNIEFBG)
	{
		foreach (object item in HOEMCNIEFBG)
		{
			BMIOECELGCA.Add(item);
		}
	}

	public static bool NLNNPDAFNCP(IEnumerable EKFOKNPODBK, Type LLIEHCKNJEM)
	{
		foreach (object item in EKFOKNPODBK)
		{
			if (!LLIEHCKNJEM.IsInstanceOfType(item))
			{
				return false;
			}
		}
		return true;
	}

	public static IDictionary PNHDAKINPLD(IDictionary ELNCCDELMMH)
	{
		return ELNCCDELMMH;
	}

	public static IList PNHDAKINPLD(IList PHILIHLPDFD)
	{
		return PHILIHLPDFD;
	}

	public static LKBPEOBFKMJ PNHDAKINPLD(LKBPEOBFKMJ IBBBMACIBGK)
	{
		return IBBBMACIBGK;
	}

	public static string NHMGCGBMCNM(IEnumerable FMFABAKPMLB)
	{
		StringBuilder stringBuilder = new StringBuilder("[");
		IEnumerator enumerator = FMFABAKPMLB.GetEnumerator();
		if (enumerator.MoveNext())
		{
			stringBuilder.Append(enumerator.Current.ToString());
			while (enumerator.MoveNext())
			{
				stringBuilder.Append(", ");
				stringBuilder.Append(enumerator.Current.ToString());
			}
		}
		stringBuilder.Append(']');
		return stringBuilder.ToString();
	}
}
