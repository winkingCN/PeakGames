using System;

internal abstract class APJJMPFMLBB
{
	internal static Enum OAOMOAFOOKD(Type LIOKHLCAHBJ, string IBBBMACIBGK)
	{
		if (IBBBMACIBGK.Length > 0 && char.IsLetter(IBBBMACIBGK[0]) && IBBBMACIBGK.IndexOf(',') < 0)
		{
			IBBBMACIBGK = IBBBMACIBGK.Replace('-', '_');
			IBBBMACIBGK = IBBBMACIBGK.Replace('/', '_');
			return (Enum)Enum.Parse(LIOKHLCAHBJ, IBBBMACIBGK, false);
		}
		throw new ArgumentException();
	}

	internal static Array MFBALCAMEIN(Type LIOKHLCAHBJ)
	{
		return Enum.GetValues(LIOKHLCAHBJ);
	}

	internal static Enum CHNBJKHAAJH(Type LIOKHLCAHBJ)
	{
		Array array = MFBALCAMEIN(LIOKHLCAHBJ);
		int index = (int)(MBHFAHIPABH.NGABLLHKHJJ() & 0x7FFFFFFF) % array.Length;
		return (Enum)array.GetValue(index);
	}

	internal static bool OPABEMNHIHH(Type LLIEHCKNJEM)
	{
		return LLIEHCKNJEM.IsEnum;
	}
}
