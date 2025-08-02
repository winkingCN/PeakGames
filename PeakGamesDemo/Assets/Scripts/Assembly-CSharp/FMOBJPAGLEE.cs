using System.Collections.Generic;
using TMPro;
using UnityEngine;

public struct FMOBJPAGLEE
{
	public int EHJNMODJEAN;

	public TMP_FontAsset PIJNMJOHBIE;

	public TMP_SpriteAsset GKDEMJDOOLB;

	public Material GHPFOPNNJOB;

	public bool PDLHEANIELH;

	public bool MNGFKMKDLPD;

	public Material PDKNCECBLAJ;

	public float HFHKPBBFDFD;

	public int OLEEIKHIDIB;

	public FMOBJPAGLEE(int EHJNMODJEAN, TMP_FontAsset PIJNMJOHBIE, TMP_SpriteAsset GKDEMJDOOLB, Material GHPFOPNNJOB, float HFHKPBBFDFD)
	{
		this.EHJNMODJEAN = EHJNMODJEAN;
		this.PIJNMJOHBIE = PIJNMJOHBIE;
		this.GKDEMJDOOLB = GKDEMJDOOLB;
		this.GHPFOPNNJOB = GHPFOPNNJOB;
		PDLHEANIELH = ((GHPFOPNNJOB.GetInstanceID() == PIJNMJOHBIE.material.GetInstanceID()) ? true : false);
		MNGFKMKDLPD = false;
		PDKNCECBLAJ = null;
		this.HFHKPBBFDFD = HFHKPBBFDFD;
		OLEEIKHIDIB = 0;
	}

	public static bool KMDACNACKII(FMOBJPAGLEE[] LJJLCGKINKO, TMP_FontAsset PIJNMJOHBIE)
	{
		int instanceID = PIJNMJOHBIE.GetInstanceID();
		for (int i = 0; i < LJJLCGKINKO.Length && LJJLCGKINKO[i].PIJNMJOHBIE != null; i++)
		{
			if (LJJLCGKINKO[i].PIJNMJOHBIE.GetInstanceID() == instanceID)
			{
				return true;
			}
		}
		return false;
	}

	public static int LBJKNANKAIP(Material GHPFOPNNJOB, TMP_FontAsset PIJNMJOHBIE, FMOBJPAGLEE[] LJJLCGKINKO, Dictionary<int, int> IAJFECFFGFP)
	{
		int instanceID = GHPFOPNNJOB.GetInstanceID();
		int value = 0;
		if (IAJFECFFGFP.TryGetValue(instanceID, out value))
		{
			return value;
		}
		value = (IAJFECFFGFP[instanceID] = IAJFECFFGFP.Count);
		LJJLCGKINKO[value].EHJNMODJEAN = value;
		LJJLCGKINKO[value].PIJNMJOHBIE = PIJNMJOHBIE;
		LJJLCGKINKO[value].GKDEMJDOOLB = null;
		LJJLCGKINKO[value].GHPFOPNNJOB = GHPFOPNNJOB;
		LJJLCGKINKO[value].PDLHEANIELH = ((instanceID == PIJNMJOHBIE.material.GetInstanceID()) ? true : false);
		LJJLCGKINKO[value].OLEEIKHIDIB = 0;
		return value;
	}

	public static int LBJKNANKAIP(Material GHPFOPNNJOB, TMP_SpriteAsset GKDEMJDOOLB, FMOBJPAGLEE[] LJJLCGKINKO, Dictionary<int, int> IAJFECFFGFP)
	{
		int instanceID = GHPFOPNNJOB.GetInstanceID();
		int value = 0;
		if (IAJFECFFGFP.TryGetValue(instanceID, out value))
		{
			return value;
		}
		value = (IAJFECFFGFP[instanceID] = IAJFECFFGFP.Count);
		LJJLCGKINKO[value].EHJNMODJEAN = value;
		LJJLCGKINKO[value].PIJNMJOHBIE = LJJLCGKINKO[0].PIJNMJOHBIE;
		LJJLCGKINKO[value].GKDEMJDOOLB = GKDEMJDOOLB;
		LJJLCGKINKO[value].GHPFOPNNJOB = GHPFOPNNJOB;
		LJJLCGKINKO[value].PDLHEANIELH = true;
		LJJLCGKINKO[value].OLEEIKHIDIB = 0;
		return value;
	}
}
