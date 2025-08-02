using Spine.Unity;
using UnityEngine;

public static class LJDGBAMMEAM
{
	public static SkeletonDataAsset OPKJBDGCGHC(string DJJBOBEGEEB, string INDAALFMPFI)
	{
		Texture2D mainTexture = Resources.Load<Texture2D>(INDAALFMPFI);
		SkeletonDataAsset skeletonDataAsset = Resources.Load<SkeletonDataAsset>(DJJBOBEGEEB);
		skeletonDataAsset.atlasAssets[0].materials[0].mainTexture = mainTexture;
		return skeletonDataAsset;
	}

	public static Texture2D NKKJHAKFKEJ(string LCCKDPIBKPJ)
	{
		Texture2D texture2D = Resources.Load(LCCKDPIBKPJ, typeof(Texture2D)) as Texture2D;
		texture2D.name = "Navigation------------------------------------- " + LCCKDPIBKPJ;
		texture2D.wrapMode = TextureWrapMode.Clamp;
		texture2D.filterMode = FilterMode.Bilinear;
		return texture2D;
	}

	public static Sprite FPAMEPBLDPL(TextAsset HKLFKEFJAAE, int HHHMOGOKFHF, int JKNPBEOPMPK)
	{
		if (HKLFKEFJAAE == null)
		{
			return SharedImageLibrary.Instance.DefaultImage;
		}
		Texture2D texture2D = new Texture2D(HHHMOGOKFHF, JKNPBEOPMPK, TextureFormat.RGB24, false);
		texture2D.filterMode = FilterMode.Bilinear;
		Texture2D texture2D2 = texture2D;
		texture2D2.LoadImage(HKLFKEFJAAE.bytes, true);
		return Sprite.Create(texture2D2, new Rect(0f, 0f, HHHMOGOKFHF, JKNPBEOPMPK), new Vector2(0.5f, 0.5f), 100f, 0u, SpriteMeshType.FullRect);
	}
}
