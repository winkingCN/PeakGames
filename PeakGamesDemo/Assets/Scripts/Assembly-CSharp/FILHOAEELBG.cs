using System;
using System.Collections;
using UnityEngine;

public static class FILHOAEELBG
{
	private static int IEINBFHKAIO;

	private static int JMPCIGGDGJB;

	private static bool JKJMHCCMHIM;

	public static void CGBOGMJLOGD(Action<string, float> IMHLFAHONPP)
	{
		Resolution currentResolution = Screen.currentResolution;
		int width = currentResolution.width;
		int height = currentResolution.height;
		if ((float)width > 800f && !KDAAPPLOOCH())
		{
			float num = (float)width * 0.8f;
			IEINBFHKAIO = (int)((!(num > 800f)) ? 800f : num);
			JMPCIGGDGJB = height * IEINBFHKAIO / width;
			Screen.SetResolution(IEINBFHKAIO, JMPCIGGDGJB, true);
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.InitialManager, "Set resolution to: {0}x{1}", JMPCIGGDGJB, IEINBFHKAIO);
			new LLCJMMBBLEH(ADJMOGECPKK(IMHLFAHONPP), true, IAJNLGPHGLO.App);
			new LLCJMMBBLEH(OKGEHFHMKKB(IMHLFAHONPP), true, IAJNLGPHGLO.App);
		}
		else
		{
			IMHLFAHONPP("Resolution Not Changed", 0f);
		}
	}

	private static IEnumerator ADJMOGECPKK(Action<string, float> IMHLFAHONPP)
	{
		while (Screen.width != IEINBFHKAIO)
		{
			yield return null;
		}
		yield return new WaitForEndOfFrame();
		if (!JKJMHCCMHIM)
		{
			JKJMHCCMHIM = true;
			if (IMHLFAHONPP != null)
			{
				IMHLFAHONPP("Resolution Changed", 0f);
			}
		}
	}

	private static IEnumerator OKGEHFHMKKB(Action<string, float> IMHLFAHONPP, float AAKHAPBEGDO = 2f)
	{
		yield return new WaitForSeconds(AAKHAPBEGDO);
		if (!JKJMHCCMHIM)
		{
			JKJMHCCMHIM = true;
			PlayerPrefs.SetInt("Resolution_Timeout", 1);
			if (IMHLFAHONPP != null)
			{
				IMHLFAHONPP("Resolution Timeout", AAKHAPBEGDO);
			}
		}
	}

	private static bool KDAAPPLOOCH()
	{
		if (PlayerPrefs.HasKey("Resolution_Timeout"))
		{
			return true;
		}
		return false;
	}
}
