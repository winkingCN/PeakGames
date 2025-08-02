using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class HJDLAJHHFPA
{
	private static readonly List<AssetBundle> NAOKBPMHADJ = new List<AssetBundle>(10);

	public static string IJNPLODONEP(RuntimePlatform EDJBGBAEAPE)
	{
		switch (EDJBGBAEAPE)
		{
		case RuntimePlatform.Android:
			return "Android";
		case RuntimePlatform.IPhonePlayer:
			return "iOS";
		case RuntimePlatform.WindowsEditor:
			return "Windows";
		case RuntimePlatform.OSXEditor:
			return "OSX";
		default:
			return "No matching Folder for platform";
		}
	}

	public static IEnumerator LCHNACPGJFN(int LEIBKEGJILK, Action<UnityEngine.Object> ENGMIAPIACK)
	{
		string text = LEIBKEGJILK.ToString().PadLeft(3, '0');
		string text2 = Path.Combine(path2: string.Concat(str3: "map" + text, str0: "Maps/", str1: IJNPLODONEP(Application.platform), str2: "/"), path1: Application.streamingAssetsPath);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AssetBundleUtils, "LoadMapAsset > Path:" + text2);
		AssetBundle assetBundle = AssetBundle.LoadFromFile(text2);
		NAOKBPMHADJ.Add(assetBundle);
		if (assetBundle == null)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.AssetBundleUtils, "Loading bundle request failed!");
			if (ENGMIAPIACK != null)
			{
				ENGMIAPIACK(null);
			}
			yield break;
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AssetBundleUtils, "Start getting prefab from bundle:{0}", text2);
		yield return null;
		try
		{
			GameObject obj2 = assetBundle.LoadAsset<GameObject>("MapPage" + text + ".prefab");
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AssetBundleUtils, "Load Asset Async:{0} : Prefab:{1}", text2, "MapPage" + text + ".prefab");
			if (ENGMIAPIACK != null)
			{
				ENGMIAPIACK(obj2);
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.AssetBundleUtils, "LoadMapAsset > Error Loading Bundle:" + ex.Message + " Stack:" + ex.StackTrace);
			if (ENGMIAPIACK != null)
			{
				ENGMIAPIACK(null);
			}
		}
		finally
		{
			if (assetBundle != null)
			{
				assetBundle.Unload(false);
				NAOKBPMHADJ.Remove(assetBundle);
			}
		}
		yield return null;
	}

	public static void CBBLJENLMBI()
	{
		foreach (AssetBundle item in NAOKBPMHADJ)
		{
			item.Unload(false);
		}
		NAOKBPMHADJ.Clear();
	}
}
