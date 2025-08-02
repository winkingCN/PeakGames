using System;
using System.IO;
using UnityEngine;

public class LFJJCHNGDLJ
{
	public Action CECMINAKHFJ;

	public Action<Sprite, string> IPAKPIGIJHK;

	public Action MAMDEOJCFEI;

	public bool HAOHFJKKHBO;

	public void KEJEHBBLDPO(string IGJEENPLFPB, bool EEKJMDHEJCK)
	{
		string text = DILKBHCCINN.FHKPGGMPOGL(IGJEENPLFPB);
		try
		{
			Sprite sprite = FMEFHCIEJDO.LOMFGHLLPHE(text);
			if (sprite == null)
			{
				Texture2D texture2D = new Texture2D(100, 100, TextureFormat.RGB24, false);
				texture2D.filterMode = FilterMode.Bilinear;
				Texture2D texture2D2 = texture2D;
				if (GLPICIAEDKE.AONKBLIBOCE(text))
				{
					string path = GLPICIAEDKE.ODGJADGNMGD(text);
					byte[] data = File.ReadAllBytes(path);
					texture2D2.LoadImage(data);
					string text2 = IGJEENPLFPB.Substring(0, Mathf.Min(18, IGJEENPLFPB.Length));
					texture2D2.name = "DynamicFBTexture" + text2;
					sprite = Sprite.Create(texture2D2, new Rect(0f, 0f, 100f, 100f), new Vector2(0.5f, 0.5f), 100f, 0u, SpriteMeshType.FullRect);
					sprite.name = "DynamicFBSprite" + text2;
					FMEFHCIEJDO.CIAHBJOLBOA(text, sprite);
				}
			}
			if (IPAKPIGIJHK != null)
			{
				IPAKPIGIJHK(sprite, IGJEENPLFPB);
			}
		}
		catch (Exception ex)
		{
			if (MAMDEOJCFEI != null)
			{
				MAMDEOJCFEI();
			}
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.AvatarAnimation, "Error loading user image | id:{0} Error:{1}", IGJEENPLFPB, ex.Message);
		}
		finally
		{
			if (CECMINAKHFJ != null)
			{
				CECMINAKHFJ();
			}
		}
	}
}
