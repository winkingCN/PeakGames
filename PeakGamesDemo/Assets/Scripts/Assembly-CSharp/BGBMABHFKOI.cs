using UnityEngine;

public static class BGBMABHFKOI
{
	public static void FKMHHHBDDBF(this Texture2D CGIOFLEGCHD, int HHHMOGOKFHF, int JKNPBEOPMPK)
	{
		FCHLOGCODOA(ref CGIOFLEGCHD, HHHMOGOKFHF, JKNPBEOPMPK, CGIOFLEGCHD.format, true);
	}

	public static void FKMHHHBDDBF(this Texture2D CGIOFLEGCHD, int HHHMOGOKFHF, int JKNPBEOPMPK, TextureFormat MIIBBFPMFLH, bool FLEKDDHMPEF)
	{
		FCHLOGCODOA(ref CGIOFLEGCHD, HHHMOGOKFHF, JKNPBEOPMPK, MIIBBFPMFLH, FLEKDDHMPEF);
	}

	private static void FCHLOGCODOA(ref Texture2D CGIOFLEGCHD, int JHMHKEEPEFH, int HGPPACPGBCG, TextureFormat NAANBLNPPFD, bool FLEKDDHMPEF)
	{
		if (JHMHKEEPEFH < 1)
		{
			JHMHKEEPEFH = 1;
		}
		if (HGPPACPGBCG < 1)
		{
			HGPPACPGBCG = 1;
		}
		RenderTexture temporary = RenderTexture.GetTemporary(JHMHKEEPEFH, HGPPACPGBCG);
		temporary.Create();
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = temporary;
		Graphics.Blit(CGIOFLEGCHD, temporary);
		CGIOFLEGCHD.Resize(JHMHKEEPEFH, HGPPACPGBCG, NAANBLNPPFD, FLEKDDHMPEF);
		CGIOFLEGCHD.filterMode = FilterMode.Bilinear;
		CGIOFLEGCHD.ReadPixels(new Rect(0f, 0f, JHMHKEEPEFH, HGPPACPGBCG), 0, 0);
		CGIOFLEGCHD.Apply();
		RenderTexture.active = ((!Application.isPlaying) ? null : active);
		RenderTexture.ReleaseTemporary(temporary);
	}
}
