using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Utils.Analytics;
using BestHTTP;
using NotificationsUnityLibraries;
using UnityEngine;

public static class KIIMLFPJHHD
{
	private const string DGFEAGBPDHJ = "https://toon-notification.pkgms.com/";

	private const string LIKAPMFOKEK = "fcm";

	private const string FIEPEHFJEPP = "apns";

	private static bool GDNBPNHOKNL;

	private static bool GBNFDGAGDKO;

	private static readonly Dictionary<string, string> DCAIILOMKHA = new Dictionary<string, string>();

	[CompilerGenerated]
	private static LogCallback JANLDOMIIEF;

	[CompilerGenerated]
	private static FcmTokenReceivedCallback GEBGDBLHLKE;

	[CompilerGenerated]
	private static ApnsTokenReceivedCallback FNBHFDJDLFP;

	[CompilerGenerated]
	private static TokenFailedCallback CHPGAHFCLFK;

	private static bool EHHNDILFDAB
	{
		get
		{
			return PlayerPrefs.GetInt("PeakNotifications", 0) == 1;
		}
	}

	public static void DIOELAHNLKJ()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Peak Notifications init called.");
		NotificationsFacade.Instance.OnLog += DAOPMOOMCDB;
		NotificationsFacade.Instance.OnFcmTokenReceived += DDJIKAAGNJN;
		NotificationsFacade.Instance.OnApnsTokenReceived += OHPKBOAKLNA;
		NotificationsFacade.Instance.OnTokenFailed += HPEJOBHFGAB;
		NotificationsFacade.Instance.Init();
		BOPEPLONIFL();
		PlayerPrefs.DeleteKey("FcmToken");
		PlayerPrefs.DeleteKey("ApnsToken");
	}

	public static void BOPEPLONIFL()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Peak Notifications clear called.");
		NotificationsFacade.Instance.ClearNotifications();
	}

	public static void HNCEPKJKAMC()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Peak Notifications register called.");
		NotificationsFacade.Instance.RegisterNotifications();
	}

	public static void LAEKPGADAHF()
	{
		KHNLJAHGDPF.JIMBAPGACIJ();
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "*******❤\ufe0f❤\ufe0f LOCAL NOTIFICATIONS ARE SET ❤\ufe0f❤\ufe0f********");
	}

	public static void NPHADJONJOI(int DKIPEJPGACG, string OEFCOJLNCKP, string FCEEGNFABAF = null)
	{
		if (MCJHHDACJBG.MCPELNPBPIF && FCEEGNFABAF == null)
		{
			FCEEGNFABAF = "Toon Blast";
		}
		NotificationsFacade.Instance.ScheduleNotification(DKIPEJPGACG, FCEEGNFABAF, OEFCOJLNCKP);
	}

	public static void JEBHHLBDPCF(long BPKJLGJDFKG)
	{
		if (BPKJLGJDFKG > 0 && EHHNDILFDAB)
		{
			HTTPRequest hTTPRequest = JIOHHCNONIK(BPKJLGJDFKG, "register/user");
			hTTPRequest.Send();
		}
	}

	private static void HPEJOBHFGAB(string OEFCOJLNCKP)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Token failed: {0}", OEFCOJLNCKP);
	}

	private static void OHPKBOAKLNA(string DJJGDFFDGFN)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "APNS Token: {0}", DJJGDFFDGFN);
		KMBNIBGIHGH.GABGKBAKHDP.BDJMFMFGCPF(DJJGDFFDGFN);
		if (!EHHNDILFDAB)
		{
			return;
		}
		long num = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
		if (num > 0 && !string.IsNullOrEmpty(DJJGDFFDGFN) && !GDNBPNHOKNL)
		{
			GDNBPNHOKNL = true;
			if (DCAIILOMKHA.Count == 0)
			{
				new LLCJMMBBLEH(CIHOGKLNIFO(num), true, IAJNLGPHGLO.App);
			}
			DCAIILOMKHA.Add("apns", DJJGDFFDGFN);
		}
	}

	private static void DDJIKAAGNJN(string DJJGDFFDGFN)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "FCM Token: {0}", DJJGDFFDGFN);
		if (MCJHHDACJBG.MCPELNPBPIF)
		{
			KMBNIBGIHGH.GABGKBAKHDP.BDJMFMFGCPF(DJJGDFFDGFN);
		}
		if (!EHHNDILFDAB)
		{
			return;
		}
		long num = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
		if (num > 0 && !string.IsNullOrEmpty(DJJGDFFDGFN) && !GBNFDGAGDKO)
		{
			GBNFDGAGDKO = true;
			if (DCAIILOMKHA.Count == 0)
			{
				new LLCJMMBBLEH(CIHOGKLNIFO(num), true, IAJNLGPHGLO.App);
			}
			DCAIILOMKHA.Add("fcm", DJJGDFFDGFN);
		}
	}

	private static HTTPRequest JIOHHCNONIK(long BPKJLGJDFKG, string CCMKBJDPCGF)
	{
		HTTPRequest hTTPRequest = new HTTPRequest(new Uri("https://toon-notification.pkgms.com/" + CCMKBJDPCGF), HTTPMethods.Post);
		hTTPRequest.AddField("user", BPKJLGJDFKG.ToString());
		hTTPRequest.AddField("device", PeakAnalytics.GetDeviceId());
		hTTPRequest.AddField("language", MDGKDGMGGCL.GABGKBAKHDP.PHOCMCOHANN());
		hTTPRequest.AddField("level", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC().ToString());
		hTTPRequest.AddField("version", "4161");
		hTTPRequest.AddField("platform", (!MCJHHDACJBG.NDNBMGMPBLF) ? "android" : "ios");
		int num = TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).Hours;
		if (num > 12)
		{
			num -= 24;
		}
		else if (num < -11)
		{
			num += 24;
		}
		hTTPRequest.AddField("timezone", num.ToString());
		return hTTPRequest;
	}

	private static IEnumerator CIHOGKLNIFO(long BPKJLGJDFKG)
	{
		yield return MCJHHDACJBG.DBKEKNNJLNO;
		bool flag = DCAIILOMKHA.ContainsKey("fcm");
		bool flag2 = DCAIILOMKHA.ContainsKey("apns");
		string text;
		if (flag && flag2)
		{
			text = "register";
		}
		else if (flag)
		{
			text = "register/fcm";
		}
		else
		{
			if (!flag2)
			{
				yield break;
			}
			text = "register/apns";
		}
		HTTPRequest hTTPRequest = JIOHHCNONIK(BPKJLGJDFKG, text);
		foreach (KeyValuePair<string, string> item in DCAIILOMKHA)
		{
			hTTPRequest.AddField(item.Key, item.Value);
		}
		DCAIILOMKHA.Clear();
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Update backend with new tokens at endpoint {0}.", text);
		hTTPRequest.Send();
	}

	private static void DAOPMOOMCDB(string OEFCOJLNCKP)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, OEFCOJLNCKP);
	}
}
