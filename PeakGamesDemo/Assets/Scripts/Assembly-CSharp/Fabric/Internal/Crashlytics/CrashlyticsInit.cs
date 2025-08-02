using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Fabric.Internal.Crashlytics
{
	public class CrashlyticsInit : MonoBehaviour
	{
		private static readonly string NALFIFKHJOE = "Crashlytics";

		private static CrashlyticsInit IACLMEKOOJO;

		[CompilerGenerated]
		private static UnhandledExceptionEventHandler JANLDOMIIEF;

		[CompilerGenerated]
		private static Application.LogCallback GEBGDBLHLKE;

		private void Awake()
		{
			if (IACLMEKOOJO == null)
			{
				BOCKDABELAM();
				IACLMEKOOJO = this;
				UnityEngine.Object.DontDestroyOnLoad(this);
			}
			else if (IACLMEKOOJO != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}

		private void BOCKDABELAM()
		{
			EDPADFJALKI();
		}

		private static void EDPADFJALKI()
		{
			if (NLAKPKBBEEG())
			{
				AOJMDKPBIKH.ILNNDCGJCKG(NALFIFKHJOE, "Registering exception handlers");
				AppDomain.CurrentDomain.UnhandledException += DKFAPCELIKL;
				Application.logMessageReceived += LNPPABIGOHF;
			}
			else
			{
				AOJMDKPBIKH.ILNNDCGJCKG(NALFIFKHJOE, "Did not register exception handlers: Crashlytics SDK was not initialized");
			}
		}

		private static bool NLAKPKBBEEG()
		{
			AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.crashlytics.android.Crashlytics");
			AndroidJavaObject androidJavaObject = null;
			try
			{
				androidJavaObject = androidJavaClass.CallStatic<AndroidJavaObject>("getInstance", new object[0]);
			}
			catch
			{
				androidJavaObject = null;
			}
			return androidJavaObject != null;
		}

		private static void DKFAPCELIKL(object KCEIOCLJEHI, UnhandledExceptionEventArgs FOKGGLEKCIB)
		{
			Exception ex = (Exception)FOKGGLEKCIB.ExceptionObject;
			LNPPABIGOHF(ex.Message.ToString(), ex.StackTrace.ToString(), LogType.Exception);
		}

		private static void LNPPABIGOHF(string OEFCOJLNCKP, string OEJFCIGGCHA, LogType NBFBPNNEKMN)
		{
			if (NBFBPNNEKMN == LogType.Exception)
			{
				AOJMDKPBIKH.ILNNDCGJCKG(NALFIFKHJOE, "Recording exception: " + OEFCOJLNCKP);
				AOJMDKPBIKH.ILNNDCGJCKG(NALFIFKHJOE, "Exception stack trace: " + OEJFCIGGCHA);
				string[] array = HDDPJFIHEDM(OEFCOJLNCKP);
				NHNBFBDHKGN.JFPLDMEBIJH(array[0], array[1], OEJFCIGGCHA);
			}
		}

		private static string[] HDDPJFIHEDM(string OEFCOJLNCKP)
		{
			char[] separator = new char[1] { ':' };
			string[] array = OEFCOJLNCKP.Split(separator, 2, StringSplitOptions.None);
			string[] array2 = array;
			foreach (string text in array2)
			{
				text.Trim();
			}
			if (array.Length == 2)
			{
				return array;
			}
			return new string[2] { "Exception", OEFCOJLNCKP };
		}
	}
}
