using System.Collections.Generic;
using UnityEngine;

public static class AAPFNDAOGGG
{
	public static string IMECGGECFLK(this char[] FBPAOINOCHI)
	{
		string text = string.Empty;
		for (int i = 0; i < FBPAOINOCHI.Length && FBPAOINOCHI[i] != 0; i++)
		{
			text += FBPAOINOCHI[i];
		}
		return text;
	}

	public static int MKHENMDGCJN<T>(this List<T> PNKBIONHGEJ, T CAEMELGEOAE) where T : Object
	{
		int instanceID = CAEMELGEOAE.GetInstanceID();
		for (int i = 0; i < PNKBIONHGEJ.Count; i++)
		{
			T val = PNKBIONHGEJ[i];
			if (val.GetInstanceID() == instanceID)
			{
				return i;
			}
		}
		return -1;
	}

	public static bool ICKHMPOCMAJ(this Color32 MNIMEAMHNMI, Color32 BCIHLCMFAEK)
	{
		return MNIMEAMHNMI.r == BCIHLCMFAEK.r && MNIMEAMHNMI.g == BCIHLCMFAEK.g && MNIMEAMHNMI.b == BCIHLCMFAEK.b && MNIMEAMHNMI.a == BCIHLCMFAEK.a;
	}

	public static bool PNNENIHOGIM(this Color32 MNIMEAMHNMI, Color32 BCIHLCMFAEK)
	{
		return MNIMEAMHNMI.r == BCIHLCMFAEK.r && MNIMEAMHNMI.g == BCIHLCMFAEK.g && MNIMEAMHNMI.b == BCIHLCMFAEK.b;
	}

	public static bool ICKHMPOCMAJ(this Color MNIMEAMHNMI, Color BCIHLCMFAEK)
	{
		return MNIMEAMHNMI.r == BCIHLCMFAEK.r && MNIMEAMHNMI.g == BCIHLCMFAEK.g && MNIMEAMHNMI.b == BCIHLCMFAEK.b && MNIMEAMHNMI.a == BCIHLCMFAEK.a;
	}

	public static bool PNNENIHOGIM(this Color MNIMEAMHNMI, Color BCIHLCMFAEK)
	{
		return MNIMEAMHNMI.r == BCIHLCMFAEK.r && MNIMEAMHNMI.g == BCIHLCMFAEK.g && MNIMEAMHNMI.b == BCIHLCMFAEK.b;
	}

	public static Color32 IBJBIGNPNEM(this Color32 DJAFLPBMOGI, Color32 AAGMIAIANDD)
	{
		byte r = (byte)((float)(int)DJAFLPBMOGI.r / 255f * ((float)(int)AAGMIAIANDD.r / 255f) * 255f);
		byte g = (byte)((float)(int)DJAFLPBMOGI.g / 255f * ((float)(int)AAGMIAIANDD.g / 255f) * 255f);
		byte b = (byte)((float)(int)DJAFLPBMOGI.b / 255f * ((float)(int)AAGMIAIANDD.b / 255f) * 255f);
		byte a = (byte)((float)(int)DJAFLPBMOGI.a / 255f * ((float)(int)AAGMIAIANDD.a / 255f) * 255f);
		return new Color32(r, g, b, a);
	}

	public static Color32 GJBOGDJACKJ(this Color32 DJAFLPBMOGI, Color32 AAGMIAIANDD)
	{
		byte r = (byte)((float)(int)DJAFLPBMOGI.r / 255f * ((float)(int)AAGMIAIANDD.r / 255f) * 255f);
		byte g = (byte)((float)(int)DJAFLPBMOGI.g / 255f * ((float)(int)AAGMIAIANDD.g / 255f) * 255f);
		byte b = (byte)((float)(int)DJAFLPBMOGI.b / 255f * ((float)(int)AAGMIAIANDD.b / 255f) * 255f);
		byte a = (byte)((float)(int)DJAFLPBMOGI.a / 255f * ((float)(int)AAGMIAIANDD.a / 255f) * 255f);
		return new Color32(r, g, b, a);
	}

	public static Color32 GJBOGDJACKJ(this Color32 DJAFLPBMOGI, float IPCBEHBKIHJ)
	{
		byte r = (byte)Mathf.Clamp((float)(int)DJAFLPBMOGI.r / 255f * IPCBEHBKIHJ * 255f, 0f, 255f);
		byte g = (byte)Mathf.Clamp((float)(int)DJAFLPBMOGI.g / 255f * IPCBEHBKIHJ * 255f, 0f, 255f);
		byte b = (byte)Mathf.Clamp((float)(int)DJAFLPBMOGI.b / 255f * IPCBEHBKIHJ * 255f, 0f, 255f);
		byte a = (byte)Mathf.Clamp((float)(int)DJAFLPBMOGI.a / 255f * IPCBEHBKIHJ * 255f, 0f, 255f);
		return new Color32(r, g, b, a);
	}

	public static bool ICKHMPOCMAJ(this Vector3 PKIBIMAALJE, Vector3 OFFFLJCPAJE, int GKOCEILIEBB)
	{
		bool flag = (int)(PKIBIMAALJE.x * (float)GKOCEILIEBB) == (int)(OFFFLJCPAJE.x * (float)GKOCEILIEBB);
		bool flag2 = (int)(PKIBIMAALJE.y * (float)GKOCEILIEBB) == (int)(OFFFLJCPAJE.y * (float)GKOCEILIEBB);
		bool flag3 = (int)(PKIBIMAALJE.z * (float)GKOCEILIEBB) == (int)(OFFFLJCPAJE.z * (float)GKOCEILIEBB);
		return flag && flag2 && flag3;
	}

	public static bool ICKHMPOCMAJ(this Quaternion EGLANKPNBPP, Quaternion PFFAGPDJJLH, int GKOCEILIEBB)
	{
		bool flag = (int)(EGLANKPNBPP.x * (float)GKOCEILIEBB) == (int)(PFFAGPDJJLH.x * (float)GKOCEILIEBB);
		bool flag2 = (int)(EGLANKPNBPP.y * (float)GKOCEILIEBB) == (int)(PFFAGPDJJLH.y * (float)GKOCEILIEBB);
		bool flag3 = (int)(EGLANKPNBPP.z * (float)GKOCEILIEBB) == (int)(PFFAGPDJJLH.z * (float)GKOCEILIEBB);
		bool flag4 = (int)(EGLANKPNBPP.w * (float)GKOCEILIEBB) == (int)(PFFAGPDJJLH.w * (float)GKOCEILIEBB);
		return flag && flag2 && flag3 && flag4;
	}
}
