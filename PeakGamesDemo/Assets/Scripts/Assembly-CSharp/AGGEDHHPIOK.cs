using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AGGEDHHPIOK
{
	private static AGGEDHHPIOK JGODGGLOOGM;

	private Dictionary<int, Material> ACIMHHICLHC = new Dictionary<int, Material>();

	private Dictionary<int, TMP_FontAsset> KGFCPIAKJEM = new Dictionary<int, TMP_FontAsset>();

	private Dictionary<int, TMP_SpriteAsset> GALCAFKGNCL = new Dictionary<int, TMP_SpriteAsset>();

	public static AGGEDHHPIOK IACLMEKOOJO
	{
		get
		{
			if (JGODGGLOOGM == null)
			{
				JGODGGLOOGM = new AGGEDHHPIOK();
			}
			return JGODGGLOOGM;
		}
	}

	public static void ELEIKNDCBBE(TMP_FontAsset PIJNMJOHBIE)
	{
		IACLMEKOOJO.CKDAEGFIPKC(PIJNMJOHBIE);
	}

	private void CKDAEGFIPKC(TMP_FontAsset PIJNMJOHBIE)
	{
		if (!KGFCPIAKJEM.ContainsKey(PIJNMJOHBIE.hashCode))
		{
			KGFCPIAKJEM.Add(PIJNMJOHBIE.hashCode, PIJNMJOHBIE);
			ACIMHHICLHC.Add(PIJNMJOHBIE.materialHashCode, PIJNMJOHBIE.material);
		}
	}

	public static void CNNEKEDEJBB(TMP_SpriteAsset GKDEMJDOOLB)
	{
		IACLMEKOOJO.EHAOBPNEBNO(GKDEMJDOOLB);
	}

	private void EHAOBPNEBNO(TMP_SpriteAsset GKDEMJDOOLB)
	{
		if (!GALCAFKGNCL.ContainsKey(GKDEMJDOOLB.hashCode))
		{
			GALCAFKGNCL.Add(GKDEMJDOOLB.hashCode, GKDEMJDOOLB);
			ACIMHHICLHC.Add(GKDEMJDOOLB.hashCode, GKDEMJDOOLB.material);
		}
	}

	public static void CNNEKEDEJBB(int CKFJKOFGBOL, TMP_SpriteAsset GKDEMJDOOLB)
	{
		IACLMEKOOJO.EHAOBPNEBNO(CKFJKOFGBOL, GKDEMJDOOLB);
	}

	private void EHAOBPNEBNO(int CKFJKOFGBOL, TMP_SpriteAsset GKDEMJDOOLB)
	{
		if (!GALCAFKGNCL.ContainsKey(CKFJKOFGBOL))
		{
			GALCAFKGNCL.Add(CKFJKOFGBOL, GKDEMJDOOLB);
			ACIMHHICLHC.Add(CKFJKOFGBOL, GKDEMJDOOLB.material);
			if (GKDEMJDOOLB.hashCode == 0)
			{
				GKDEMJDOOLB.hashCode = CKFJKOFGBOL;
			}
		}
	}

	public static void PKICMMCLKJA(int CKFJKOFGBOL, Material GHPFOPNNJOB)
	{
		IACLMEKOOJO.BIHMAPOIIPI(CKFJKOFGBOL, GHPFOPNNJOB);
	}

	private void BIHMAPOIIPI(int CKFJKOFGBOL, Material GHPFOPNNJOB)
	{
		ACIMHHICLHC.Add(CKFJKOFGBOL, GHPFOPNNJOB);
	}

	public bool KMDACNACKII(TMP_FontAsset ELKNHALJKNI)
	{
		if (KGFCPIAKJEM.ContainsKey(ELKNHALJKNI.hashCode))
		{
			return true;
		}
		return false;
	}

	public bool KMDACNACKII(TMP_SpriteAsset MJOJAOIHCIO)
	{
		if (KGFCPIAKJEM.ContainsKey(MJOJAOIHCIO.hashCode))
		{
			return true;
		}
		return false;
	}

	public static bool OIGAADCABKO(int CKFJKOFGBOL, out TMP_FontAsset PIJNMJOHBIE)
	{
		return IACLMEKOOJO.NJLPKHHBMJE(CKFJKOFGBOL, out PIJNMJOHBIE);
	}

	private bool NJLPKHHBMJE(int CKFJKOFGBOL, out TMP_FontAsset PIJNMJOHBIE)
	{
		PIJNMJOHBIE = null;
		if (KGFCPIAKJEM.TryGetValue(CKFJKOFGBOL, out PIJNMJOHBIE))
		{
			return true;
		}
		return false;
	}

	public static bool KBGHDGBMIJH(int CKFJKOFGBOL, out TMP_SpriteAsset GKDEMJDOOLB)
	{
		return IACLMEKOOJO.HCAFCFFLAHA(CKFJKOFGBOL, out GKDEMJDOOLB);
	}

	private bool HCAFCFFLAHA(int CKFJKOFGBOL, out TMP_SpriteAsset GKDEMJDOOLB)
	{
		GKDEMJDOOLB = null;
		if (GALCAFKGNCL.TryGetValue(CKFJKOFGBOL, out GKDEMJDOOLB))
		{
			return true;
		}
		return false;
	}

	public static bool EOHJHBCMBBC(int CKFJKOFGBOL, out Material GHPFOPNNJOB)
	{
		return IACLMEKOOJO.BFALBEPIHBG(CKFJKOFGBOL, out GHPFOPNNJOB);
	}

	private bool BFALBEPIHBG(int CKFJKOFGBOL, out Material GHPFOPNNJOB)
	{
		GHPFOPNNJOB = null;
		if (ACIMHHICLHC.TryGetValue(CKFJKOFGBOL, out GHPFOPNNJOB))
		{
			return true;
		}
		return false;
	}
}
