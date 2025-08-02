using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;

public static class OKJKJLMEEOB
{
	public static Vector2 NKMNHPFNJAH(this Vector3 AAIEJDNAODP)
	{
		return new Vector2(AAIEJDNAODP.x, AAIEJDNAODP.z);
	}

	public static Vector2[] NKMNHPFNJAH(this Vector3[] AAIEJDNAODP)
	{
		Vector2[] array = new Vector2[AAIEJDNAODP.Length];
		for (int i = 0; i < AAIEJDNAODP.Length; i++)
		{
			array[i] = new Vector2(AAIEJDNAODP[i].x, AAIEJDNAODP[i].z);
		}
		return array;
	}

	public static float KDFMLCHNNLL(this float EDDNOJDPMCF, float FOHGIJNOKOD, float LJOPEGDPPIC, float GGNKKDMCOHL, float GIDDNCEEJCK)
	{
		return (EDDNOJDPMCF - FOHGIJNOKOD) / (LJOPEGDPPIC - FOHGIJNOKOD) * (GIDDNCEEJCK - GGNKKDMCOHL) + GGNKKDMCOHL;
	}

	public static string BDHGBNHEDCP(this string PPHLHPFJKLO)
	{
		return Regex.Replace(PPHLHPFJKLO, "([a-z](?=[A-Z])|[A-Z](?=[A-Z][a-z]))", "$1 ").Trim();
	}

	public static bool KMDACNACKII(this string JKHLMLIANAI, string LPBLFPGINEN, StringComparison IJLKCOHLILI)
	{
		return JKHLMLIANAI != null && LPBLFPGINEN != null && JKHLMLIANAI.IndexOf(LPBLFPGINEN, IJLKCOHLILI) >= 0;
	}

	public static void IMFMCDNMPAM<T>(this List<T> ANBAEMOIGNA)
	{
		ANBAEMOIGNA = ANBAEMOIGNA.Cast<T>().ToList();
	}

	public static bool ENEDPNKHCLN<T>(this Enum NBFBPNNEKMN, T EDDNOJDPMCF)
	{
		try
		{
			return ((int)(object)NBFBPNNEKMN & (int)(object)EDDNOJDPMCF) == (int)(object)EDDNOJDPMCF;
		}
		catch
		{
			return false;
		}
	}

	public static bool JPPOJKAEJKL<T>(this Enum NBFBPNNEKMN, T EDDNOJDPMCF)
	{
		try
		{
			return (int)(object)NBFBPNNEKMN == (int)(object)EDDNOJDPMCF;
		}
		catch
		{
			return false;
		}
	}

	public static T JEACJNAKLDJ<T>(this Enum NBFBPNNEKMN, T EDDNOJDPMCF)
	{
		try
		{
			return (T)(object)((int)(object)NBFBPNNEKMN | (int)(object)EDDNOJDPMCF);
		}
		catch (Exception innerException)
		{
			throw new ArgumentException(string.Format("Could not append value from enumerated type '{0}'.", typeof(T).Name), innerException);
		}
	}

	public static T CJOHLENDJGO<T>(this Enum NBFBPNNEKMN, T EDDNOJDPMCF)
	{
		try
		{
			return (T)(object)((int)(object)NBFBPNNEKMN & ~(int)(object)EDDNOJDPMCF);
		}
		catch (Exception innerException)
		{
			throw new ArgumentException(string.Format("Could not remove value from enumerated type '{0}'.", typeof(T).Name), innerException);
		}
	}

	public static Color ACPFDKCODBP(this Color MFODILBOMGD, float KBKMPEOMABI)
	{
		Color result = MFODILBOMGD;
		result.a = KBKMPEOMABI;
		return result;
	}
}
