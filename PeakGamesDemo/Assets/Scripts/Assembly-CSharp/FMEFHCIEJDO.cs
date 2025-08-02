using System.Collections.Generic;
using UnityEngine;

public static class FMEFHCIEJDO
{
	private static readonly Dictionary<string, Sprite> IOGICAIJHHA = new Dictionary<string, Sprite>();

	public static Sprite LOMFGHLLPHE(string IGJEENPLFPB)
	{
		Sprite value;
		IOGICAIJHHA.TryGetValue(IGJEENPLFPB, out value);
		return value;
	}

	public static void CIAHBJOLBOA(string IGJEENPLFPB, Sprite BJBFPCKKOLM)
	{
		IOGICAIJHHA[IGJEENPLFPB] = BJBFPCKKOLM;
	}

	public static void OIOPIEFFMFM()
	{
		foreach (KeyValuePair<string, Sprite> item in IOGICAIJHHA)
		{
			if (!(item.Value == null))
			{
				Object.Destroy(item.Value.texture);
				Object.Destroy(item.Value);
			}
		}
		IOGICAIJHHA.Clear();
	}

	public static void INJHFIFHKOB()
	{
		OIOPIEFFMFM();
	}
}
