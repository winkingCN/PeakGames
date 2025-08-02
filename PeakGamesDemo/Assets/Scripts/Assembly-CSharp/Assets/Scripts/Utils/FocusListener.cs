using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.SceneTransitions;
using Assets.Scripts.Utils.Analytics;
using Fabric.Answers;
using Facebook.Unity;
using UnityEngine;

namespace Assets.Scripts.Utils
{
	public class FocusListener : MonoBehaviour
	{
		public static float LastTimeFocused;

		private static float KLFOJOCCDMO;

		private static float KNEPJCAKPEA;

		private static FocusListener KNPOFJNFLJB;

		[CompilerGenerated]
		private static InitDelegate JANLDOMIIEF;

		public static float EOFACIOAGKE
		{
			get
			{
				return KNEPJCAKPEA + Time.realtimeSinceStartup;
			}
		}

		public static int MOGJKPIEGGL { get; private set; }

		public static void Init()
		{
			if (KNPOFJNFLJB != null)
			{
				UnityEngine.Object.Destroy(KNPOFJNFLJB.gameObject);
			}
			GameObject gameObject = new GameObject();
			gameObject.name = "FocusListener";
			GameObject gameObject2 = gameObject;
			KNPOFJNFLJB = gameObject2.AddComponent<FocusListener>();
			UnityEngine.Object.DontDestroyOnLoad(gameObject2);
		}

		public void Awake()
		{
			KNEPJCAKPEA = PlayerPrefs.GetFloat("RTSM", 0f);
		}

		public void OnApplicationPause(bool APMMLLCMAKI)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FocusListener, "Game paused: {0}", APMMLLCMAKI);
			if (APMMLLCMAKI)
			{
				KCAELBCNKFN.GABGKBAKHDP.NKKOEHGDNKD();
			}
			PMGKCJELDBI(APMMLLCMAKI);
			EEDEHJEPPCJ(APMMLLCMAKI);
		}

		public void OnApplicationQuit()
		{
			EEDEHJEPPCJ(true);
			PlayerPrefs.SetFloat("RTSM", EOFACIOAGKE);
			AFJPGLHKOID.PCHCAFHEJJM();
			PeakAnalytics.StopAnalytics();
			KCAELBCNKFN.GABGKBAKHDP.NKKOEHGDNKD();
			KMBNIBGIHGH.GABGKBAKHDP.JFMCKFEONEC();
			GBFAPADEBEC.IOCHPGEBNEE();
		}

		private static void PMGKCJELDBI(bool FCEKBIGMPIK)
		{
			MOGJKPIEGGL++;
			try
			{
				if (FCEKBIGMPIK)
				{
					float num = Time.realtimeSinceStartup - KLFOJOCCDMO;
					KLFOJOCCDMO = Time.realtimeSinceStartup;
					if (num / 60f > 10f)
					{
						PeakAnalytics.UpdateSessionId();
					}
					PeakAnalytics.StopAnalytics();
					DGJOFDEJIPE(FCEKBIGMPIK);
					PJPPADHKGHN.GABGKBAKHDP.GCIDCPDFFCL();
					PlayerPrefs.SetFloat("RTSM", EOFACIOAGKE);
					DGOMNDMPMBG.GABGKBAKHDP.ONKHPNEGKMD();
				}
				else
				{
					LastTimeFocused = Time.time;
					PeakAnalytics.StartAnalytics();
					DGJOFDEJIPE(FCEKBIGMPIK);
					OPMJPIEDGGI();
					GBDGNKHCPLC();
					DGOMNDMPMBG.GABGKBAKHDP.DMMDHDKFEEL();
					KMBNIBGIHGH.GABGKBAKHDP.OMIKDFPHGBA();
				}
				if (FJPHLKFHDOG.GABGKBAKHDP.FMPALJDNDEN())
				{
					if (FCEKBIGMPIK)
					{
						NAAGDFCLOPE.GABGKBAKHDP.NKPAGBPCFMI();
					}
					else
					{
						FJPHLKFHDOG.GABGKBAKHDP.EFBEHJNKFCD();
					}
				}
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FocusListener, "Can not handle resume or pause application: {0}", ex.Message);
			}
		}

		private static void OPMJPIEDGGI()
		{
			if (OIAJPMNJGLK.HCBKKCHMJNA() == 0 && CACKIGBBMPB.GABGKBAKHDP.DLJPFGHEPLB)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FocusListener, "Prevented focus in commands because there is no recorded server time.");
			}
			else if (ANGCNEFIIHE.GABGKBAKHDP.JPOJKMBOLIJ && LoadingScreenDisplayer.Instance.CDIJIMCMCOE)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FocusListener, "Prevented focus in commands because there is an ongoing purchase.");
			}
			else if (IIMOEAOONKA.HGABPIDMBEK && LoadingScreenDisplayer.Instance.CDIJIMCMCOE)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FocusListener, "Prevented focus in commands because there is an ongoing facebook login.");
			}
			else if (Time.realtimeSinceStartup - GEBAAFFGKJG.JPNPCPMAMFL < 5f)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FocusListener, "Prevented focus in commands because delta sync is in progress.");
			}
			else
			{
				KBEGNPKLMDE.BHGNAHECMDH();
			}
		}

		private static void GBDGNKHCPLC()
		{
			if (FB.IsInitialized)
			{
				FB.ActivateApp();
			}
			else
			{
				FB.Init(FB.ActivateApp);
			}
		}

		public static void MarkTime()
		{
			KNEPJCAKPEA = -1f * Time.realtimeSinceStartup;
		}

		private static void DGJOFDEJIPE(bool MMMKENCKOAL)
		{
			if (MMMKENCKOAL)
			{
				if (NAAGDFCLOPE.GABGKBAKHDP.AJJAPHGCFDD)
				{
					NAAGDFCLOPE.GABGKBAKHDP.NKPAGBPCFMI();
				}
				KIIMLFPJHHD.LAEKPGADAHF();
			}
			else
			{
				if (NAAGDFCLOPE.GABGKBAKHDP.AJJAPHGCFDD)
				{
					NAAGDFCLOPE.GABGKBAKHDP.BNJIGCHGOAJ();
				}
				KIIMLFPJHHD.BOPEPLONIFL();
			}
		}

		private static void EEDEHJEPPCJ(bool MMMKENCKOAL)
		{
			if (MMMKENCKOAL)
			{
				ResetGamePlayCrash();
			}
			else if (CaravanSceneManager.CurrentScene == GKBHIKONCKJ.GamePlay)
			{
				SetGamePlayCrash();
			}
		}

		public static void RestoreGamePlayCrash()
		{
			if (PlayerPrefs.GetInt("GamePlayCrash", 0) == 1)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FocusListener, "One life and crown will be restored because of game play crash.");
				PJPPADHKGHN.GABGKBAKHDP.CJNFILFKEAC();
				DIGGBGADIGJ.GDBLPMMEOGF();
				PlayerPrefs.DeleteKey("GamePlayCrash");
				PlayerPrefs.Save();
				Answers.LogCustom("GamePlayCrash");
			}
		}

		public static void SetGamePlayCrash()
		{
			PlayerPrefs.SetInt("GamePlayCrash", 1);
			PlayerPrefs.Save();
		}

		public static void ResetGamePlayCrash()
		{
			PlayerPrefs.DeleteKey("GamePlayCrash");
			PlayerPrefs.Save();
		}
	}
}
