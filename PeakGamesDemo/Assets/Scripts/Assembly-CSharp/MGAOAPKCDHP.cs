using System;
using System.Collections.Generic;

public abstract class MGAOAPKCDHP
{
	public static string JDANMONKNGD(string IKNCPEPOKGJ, Dictionary<string, object> EAPGOBAJLJE)
	{
		if (EAPGOBAJLJE == null)
		{
			return null;
		}
		object value;
		EAPGOBAJLJE.TryGetValue(IKNCPEPOKGJ, out value);
		return value as string;
	}

	public static long EICLJDHEHHP(string IKNCPEPOKGJ, Dictionary<string, object> EAPGOBAJLJE, long DLJMKKALKBD = 0L)
	{
		if (EAPGOBAJLJE == null)
		{
			return DLJMKKALKBD;
		}
		object value;
		EAPGOBAJLJE.TryGetValue(IKNCPEPOKGJ, out value);
		return Convert.ToInt64(value);
	}

	public static Dictionary<long, AKGIJAMHMNA> EFEKGCOJIFA(string IKNCPEPOKGJ, Dictionary<string, object> EAPGOBAJLJE)
	{
		Dictionary<long, AKGIJAMHMNA> dictionary = new Dictionary<long, AKGIJAMHMNA>();
		object value;
		if (!EAPGOBAJLJE.TryGetValue(IKNCPEPOKGJ, out value))
		{
			return dictionary;
		}
		Dictionary<string, object> dictionary2 = (Dictionary<string, object>)value;
		foreach (string key in dictionary2.Keys)
		{
			dictionary.Add(int.Parse(key), new AKGIJAMHMNA((Dictionary<string, object>)dictionary2[key]));
		}
		return dictionary;
	}

	public static Dictionary<long, NBBAAJENFFN> ACFBICEMOOF(string IKNCPEPOKGJ, Dictionary<string, object> EAPGOBAJLJE)
	{
		Dictionary<long, NBBAAJENFFN> dictionary = new Dictionary<long, NBBAAJENFFN>();
		object value;
		if (!EAPGOBAJLJE.TryGetValue(IKNCPEPOKGJ, out value))
		{
			return dictionary;
		}
		Dictionary<string, object> dictionary2 = (Dictionary<string, object>)value;
		foreach (string key in dictionary2.Keys)
		{
			dictionary.Add(int.Parse(key), new NBBAAJENFFN((Dictionary<string, object>)dictionary2[key]));
		}
		return dictionary;
	}
}
