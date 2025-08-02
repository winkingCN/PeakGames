using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.Utils.NativeTools.impls;
using UnityEngine;

public class ICLJKKIOKKF : CFDGIGBLONH
{
	[CompilerGenerated]
	private sealed class MMGPJNMPEJO
	{
		internal string OEFCOJLNCKP;

		internal string NIIMJJEBHCA;

		internal string LNCBFPEKHDJ;

		internal ICLJKKIOKKF PDAPIGLEPGC;

		internal void AGFNGEFDHLA()
		{
			PDAPIGLEPGC.GJKIIBFNKIJ.CallStatic("showForceUpdatePopup", OEFCOJLNCKP, NIIMJJEBHCA, LNCBFPEKHDJ);
		}
	}

	[CompilerGenerated]
	private sealed class NEOGINEOMBI
	{
		internal string FCEEGNFABAF;

		internal string HOMONAAFMFH;

		internal string LDHECNOPBNK;

		internal string ICPIDDPDMKP;

		internal string KMJJAKAMOKO;

		internal string OELLFNCIJFH;

		internal string KGKGAEMGFIF;

		internal ICLJKKIOKKF PDAPIGLEPGC;

		internal void AGFNGEFDHLA()
		{
			PDAPIGLEPGC.GJKIIBFNKIJ.CallStatic("showConsentPopup", FCEEGNFABAF, HOMONAAFMFH, LDHECNOPBNK, ICPIDDPDMKP, KMJJAKAMOKO, OELLFNCIJFH, KGKGAEMGFIF);
		}
	}

	private readonly string EGMKNFGNOFH;

	private AndroidJavaObject GJKIIBFNKIJ;

	private AndroidCaravanNativeToolsCallbacks EBMCLGHCIFM;

	public ICLJKKIOKKF()
	{
		GJKIIBFNKIJ = new AndroidJavaObject("caravan.peakgames.net.caravanandroidtools.CaravanTools");
		EGMKNFGNOFH = GJKIIBFNKIJ.GetStatic<string>("InternalStoragePath");
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AndroidCaravanNativeTools, "Internal storage path is: {0}", EGMKNFGNOFH);
		EBMCLGHCIFM = CFDGIGBLONH.FGPNJAEOONM.AddComponent<AndroidCaravanNativeToolsCallbacks>();
	}

	public override string KNLPPACLPOJ()
	{
		return EGMKNFGNOFH;
	}

	public override void OGNENMNMAIN(string FCEEGNFABAF, string OEFCOJLNCKP, string NIIMJJEBHCA, string LNCBFPEKHDJ)
	{
		AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		AndroidJavaObject @static = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
		@static.Call("runOnUiThread", (AndroidJavaRunnable)delegate
		{
			GJKIIBFNKIJ.CallStatic("showForceUpdatePopup", OEFCOJLNCKP, NIIMJJEBHCA, LNCBFPEKHDJ);
		});
	}

	public override void EFBEHJNKFCD(string FCEEGNFABAF, string HOMONAAFMFH, string LDHECNOPBNK, string ICPIDDPDMKP, string KMJJAKAMOKO, string OELLFNCIJFH, string KGKGAEMGFIF)
	{
		AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		AndroidJavaObject @static = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
		@static.Call("runOnUiThread", (AndroidJavaRunnable)delegate
		{
			GJKIIBFNKIJ.CallStatic("showConsentPopup", FCEEGNFABAF, HOMONAAFMFH, LDHECNOPBNK, ICPIDDPDMKP, KMJJAKAMOKO, OELLFNCIJFH, KGKGAEMGFIF);
		});
	}

	public override void NKPAGBPCFMI()
	{
		AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		AndroidJavaObject @static = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
		@static.Call("runOnUiThread", (AndroidJavaRunnable)delegate
		{
			GJKIIBFNKIJ.CallStatic("hideNativePopup");
		});
	}

	public override void JNOCJCGINCB()
	{
		GJKIIBFNKIJ.CallStatic("cancelForceUpdatePopup");
	}

	public override bool KJNBMEGHDGE()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AndroidCaravanNativeTools, "Native request review popup is not supported.");
		return false;
	}

	public override bool GFMLBLFOHDG()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AndroidCaravanNativeTools, "Native request review popup is not supported.");
		return false;
	}

	public override bool KPBDKDPAKBC()
	{
		string text = GJKIIBFNKIJ.CallStatic<string>("getSignatureText", new object[0]);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AndroidCaravanNativeTools, "Native signature text is {0}", text);
		return !string.IsNullOrEmpty(text) && text.Contains("62:37:75:65:24");
	}

	public override void NJJBJKCPJLA(string HHIHHPHCEJG)
	{
	}

	public override void LMGDDIIJMHF(string IKNCPEPOKGJ, Action<string> CMACNIMFJHP)
	{
		EBMCLGHCIFM.OnRead = CMACNIMFJHP;
		GJKIIBFNKIJ.CallStatic("restoreData", IKNCPEPOKGJ);
	}

	public override void EGGICLINDJH(string IKNCPEPOKGJ, string EDDNOJDPMCF)
	{
		GJKIIBFNKIJ.CallStatic("backupData", IKNCPEPOKGJ, EDDNOJDPMCF);
	}

	public override LEJICLFDBAJ BEEIBDODHCD()
	{
		return default(LEJICLFDBAJ);
	}

	[CompilerGenerated]
	private void AKFHKLCNCOC()
	{
		GJKIIBFNKIJ.CallStatic("hideNativePopup");
	}
}
