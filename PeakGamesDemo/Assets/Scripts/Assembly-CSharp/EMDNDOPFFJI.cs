using System.Collections.Generic;
using UnityEngine;

public static class EMDNDOPFFJI
{
	public static void KFGEEKGAPDP<T>(this IList<T> PNKBIONHGEJ)
	{
		int num = PNKBIONHGEJ.Count;
		while (num > 1)
		{
			num--;
			int index = Random.Range(0, num + 1);
			T value = PNKBIONHGEJ[index];
			PNKBIONHGEJ[index] = PNKBIONHGEJ[num];
			PNKBIONHGEJ[num] = value;
		}
	}

	public static void KFGEEKGAPDP<T>(this IList<T> PNKBIONHGEJ, int GMANJFBCGFM)
	{
		int num = PNKBIONHGEJ.Count;
		while (num > 1)
		{
			num--;
			int index = BFGGHJGIHLJ.FDFDDKBDPEG(0, num + 1, GMANJFBCGFM);
			T value = PNKBIONHGEJ[index];
			PNKBIONHGEJ[index] = PNKBIONHGEJ[num];
			PNKBIONHGEJ[num] = value;
		}
	}

	public static List<int> IKBFGGABMKP(this List<int> EICLPBCDPJM)
	{
		if (EICLPBCDPJM == null)
		{
			return null;
		}
		List<int> list = new List<int>();
		foreach (int item in EICLPBCDPJM)
		{
			list.Add(item);
		}
		return list;
	}
}
