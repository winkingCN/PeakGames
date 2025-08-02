using System.Collections.Generic;
using TMPro;

public static class LOLKOAINBHK
{
	private static List<int> CGIGHGGOONF;

	public static TMP_FontAsset GOIMLDBOBEN(TMP_FontAsset ELKNHALJKNI, int AONJCHFEHOM, out TMP_Glyph FLPJKOEKMJJ)
	{
		if (CGIGHGGOONF == null)
		{
			CGIGHGGOONF = new List<int>();
		}
		CGIGHGGOONF.Clear();
		return ENBFKMAPFJF(ELKNHALJKNI, AONJCHFEHOM, out FLPJKOEKMJJ);
	}

	public static TMP_FontAsset GOIMLDBOBEN(List<TMP_FontAsset> JLEADOLCKAP, int AONJCHFEHOM, out TMP_Glyph FLPJKOEKMJJ)
	{
		return ENBFKMAPFJF(JLEADOLCKAP, AONJCHFEHOM, out FLPJKOEKMJJ);
	}

	private static TMP_FontAsset ENBFKMAPFJF(TMP_FontAsset ELKNHALJKNI, int AONJCHFEHOM, out TMP_Glyph FLPJKOEKMJJ)
	{
		FLPJKOEKMJJ = null;
		if (ELKNHALJKNI == null)
		{
			return null;
		}
		if (ELKNHALJKNI.characterDictionary.TryGetValue(AONJCHFEHOM, out FLPJKOEKMJJ))
		{
			return ELKNHALJKNI;
		}
		if (ELKNHALJKNI.fallbackFontAssets != null && ELKNHALJKNI.fallbackFontAssets.Count > 0)
		{
			for (int i = 0; i < ELKNHALJKNI.fallbackFontAssets.Count; i++)
			{
				if (FLPJKOEKMJJ != null)
				{
					break;
				}
				TMP_FontAsset tMP_FontAsset = ELKNHALJKNI.fallbackFontAssets[i];
				int instanceID = tMP_FontAsset.GetInstanceID();
				if (!(tMP_FontAsset == null) && !CGIGHGGOONF.Contains(instanceID))
				{
					CGIGHGGOONF.Add(instanceID);
					tMP_FontAsset = ENBFKMAPFJF(tMP_FontAsset, AONJCHFEHOM, out FLPJKOEKMJJ);
					if (tMP_FontAsset != null)
					{
						return tMP_FontAsset;
					}
				}
			}
		}
		return null;
	}

	private static TMP_FontAsset ENBFKMAPFJF(List<TMP_FontAsset> JLEADOLCKAP, int AONJCHFEHOM, out TMP_Glyph FLPJKOEKMJJ)
	{
		FLPJKOEKMJJ = null;
		if (JLEADOLCKAP != null && JLEADOLCKAP.Count > 0)
		{
			for (int i = 0; i < JLEADOLCKAP.Count; i++)
			{
				TMP_FontAsset tMP_FontAsset = ENBFKMAPFJF(JLEADOLCKAP[i], AONJCHFEHOM, out FLPJKOEKMJJ);
				if (tMP_FontAsset != null)
				{
					return tMP_FontAsset;
				}
			}
		}
		return null;
	}
}
