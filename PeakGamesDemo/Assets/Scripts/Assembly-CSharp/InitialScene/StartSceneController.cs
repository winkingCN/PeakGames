using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.SceneTransitions;
using Assets.Scripts.Utils;
using Assets.Scripts.Utils.Analytics;
using BestHTTP;
using DG.Tweening;
using Fabric.Answers;
using Facebook.Unity;
using TMPro;
using UnityEngine;

namespace InitialScene
{
	public class StartSceneController : MonoBehaviour
	{
		public TextMeshPro InfoText;

		private FJPHLKFHDOG AFCNOFMCOOP;

		[CompilerGenerated]
		private static InitDelegate JANLDOMIIEF;

		[CompilerGenerated]
		private static OneSignal.HMBEECHAIHA GEBGDBLHLKE;

		[CompilerGenerated]
		private static OneSignal.EJBNDCLLMCF FNBHFDJDLFP;

		[CompilerGenerated]
		private static OneSignal.KINAOEOAIHE CHPGAHFCLFK;

		private void Awake()
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.GameStarter, "Start Scene Started @:" + Time.realtimeSinceStartup);
			if (!OJLMMHJLHDI())
			{
				InfoText.enabled = true;
				InfoText.ANLKLKAINEO.position = Vector3.zero;
				InfoText.FCJBBPHFNPJ = "Reinstall game! Updated to wrong environment";
				return;
			}
			KCAELBCNKFN.GABGKBAKHDP.DIOELAHNLKJ();
			SlowCheckTime.Init();
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.InitialManager, "Init native tools: {0}", NAAGDFCLOPE.GABGKBAKHDP.KNLPPACLPOJ());
			if (!FB.IsInitialized)
			{
				FB.Init(PGACJHKJAHA.OCILGCNBNKO);
			}
			AFCNOFMCOOP = FJPHLKFHDOG.GABGKBAKHDP;
			AFCNOFMCOOP.DIOELAHNLKJ(DFDAOONHKIG);
			PeakAnalytics.OnDeviceIdReceived = COHNOPFKNNJ;
			PeakAnalytics.Init();
			KMBNIBGIHGH.GABGKBAKHDP.ACGKOEHCHHJ = true;
			PAFJGJOPLKB.DIOELAHNLKJ();
			string text = MDGKDGMGGCL.GABGKBAKHDP.PHOCMCOHANN();
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.InitialManager, "Initting game with language {0}", text);
			PNAJOCHGJFO.LMJKBCFGAIN(PNAJOCHGJFO.HNJPEIBFHJI(text), text, true, true);
			DOTween.Init(false, true, LogBehaviour.ErrorsOnly);
			DOTween.SetTweensCapacity(1000, 200);
			HTTPManager.MaxConnectionPerServer = 4;
			HTTPManager.TryToMinimizeTCPLatency = true;
			HTTPManager.Logger = new MALPINCHAMP();
			HTTPManager.Setup();
			CACKIGBBMPB.GABGKBAKHDP.PLPEELGIEHN();
			BOKGFGFPOHD.IGCBOOCJPGD();
			BOKGFGFPOHD.KNJGDDBPMED();
			IHMNJDMKMCN.DIOELAHNLKJ();
			if (LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM != 0)
			{
				DMEKKNGOCNH.GABGKBAKHDP.DJPPLNADDDA();
			}
			LevelBuilder.HashABLevels(Application.persistentDataPath);
			DGOMNDMPMBG.GABGKBAKHDP.DIOELAHNLKJ();
			GLPICIAEDKE.PGBBKNEAAPH();
			ILAMPCAFGIF.EPLFBPBJJBO();
			FocusListener.RestoreGamePlayCrash();
			HLKAEJCPMEB.IIABCIBMHJL();
			IHFEBJLNALF();
			if (PlayerPrefs.GetInt("MaxTextureSize", 0) != 1)
			{
				PlayerPrefs.SetInt("MaxTextureSize", 1);
				Answers.LogCustom("MaxTextureSize", new Dictionary<string, object> { 
				{
					"MaxTextureSize",
					SystemInfo.maxTextureSize.ToString()
				} });
			}
		}

		public void OnApplicationPause(bool MMMKENCKOAL)
		{
			if (AFCNOFMCOOP.FMPALJDNDEN())
			{
				if (MMMKENCKOAL)
				{
					NAAGDFCLOPE.GABGKBAKHDP.NKPAGBPCFMI();
				}
				else
				{
					AFCNOFMCOOP.EFBEHJNKFCD();
				}
			}
		}

		private static void IHFEBJLNALF()
		{
			if (!NAAGDFCLOPE.GABGKBAKHDP.KPBDKDPAKBC())
			{
				Answers.LogCustom("InvalidBinary");
				PlayerPrefs.SetInt("InvalidBinary", 1);
			}
			if (NAAGDFCLOPE.NGLAKDICBJJ())
			{
				Answers.LogCustom("BrokenBinary");
				PlayerPrefs.SetInt("BrokenBinary", 1);
			}
		}

		private bool OJLMMHJLHDI()
		{
			int num = ((!MCJHHDACJBG.DGDIEBKEMOL) ? 1 : 0);
			int @int = PlayerPrefs.GetInt("Environment", -1);
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.GameStarter, "Current Environment:{0} Saved Environment:{1}", num, @int);
			if (@int == -1)
			{
				PlayerPrefs.SetInt("Environment", num);
				PlayerPrefs.Save();
			}
			else if (@int != num)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.GameStarter, "!! Environment Changed !! Last Saved is:{0}. Current environment is:{1}. 0:Dev 1:Prod ", num, @int);
				return false;
			}
			return true;
		}

		private void COHNOPFKNNJ()
		{
			CDDOPBGDEJM();
			string bKMHJPECJAM = ((!MCJHHDACJBG.DGDIEBKEMOL) ? "a79cea57-dc7e-4abd-80b4-24a0ec65d17a" : "f386a99a-0816-4334-94c8-91379c5cfe5c");
			OneSignal.StartInit(bKMHJPECJAM).AGDNCKLIKOD(AGDNCKLIKOD).LLHFCAEPMHO(LLHFCAEPMHO)
				.HOOGMKJNOJD(OneSignal.NDNHJFICCIA.None)
				.ANMFNMEGOJA(new Dictionary<string, bool>
				{
					{ "kOSSettingsAutoPrompt", false },
					{ "kOSSettingsInAppLaunchURL", false }
				})
				.JAEKDGIAAKM();
			OneSignal.IdsAvailable(LKFFGGECIKC);
			JFLDPHFHJOL();
			KIIMLFPJHHD.DIOELAHNLKJ();
			LoadingScreenDisplayer.Instance.InstantFade = true;
			StartCoroutine(JPPAIBIKDIH());
		}

		private static void CDDOPBGDEJM()
		{
			string deviceId = PeakAnalytics.GetDeviceId();
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.InitialManager, " Auto Login Id is: {0}", deviceId);
			string @string = PlayerPrefs.GetString("LastDeviceId", string.Empty);
			if (!string.IsNullOrEmpty(@string) && @string != deviceId)
			{
				LECPGNKOABP.GABGKBAKHDP.AEMKFKIBDGO(true);
			}
		}

		private IEnumerator JPPAIBIKDIH()
		{
			yield return null;
			if (AFCNOFMCOOP.FMPALJDNDEN())
			{
				AFCNOFMCOOP.EFBEHJNKFCD();
				yield break;
			}
			OneSignal.RegisterForPushNotifications();
			KIIMLFPJHHD.HNCEPKJKAMC();
			DFDAOONHKIG();
		}

		private void DFDAOONHKIG()
		{
			PeakAnalytics.SetOnlineStatus(true);
			NAAGDFCLOPE.GABGKBAKHDP.KAMLFGLNNNE();
			FocusListener.Init();
			GEBAAFFGKJG.GABGKBAKHDP.CBANNNKPJAM();
			EIMPOHFHFMO.GBPHBJEJODP(true);
			AFCNOFMCOOP.PHHBNNGIKFF();
			LoadingScreenDisplayer.Instance.ShowLoading(KLKAGJKCKBE.Initial, delegate
			{
				StartCoroutine(LBFEJBGHMBO());
			});
		}

		private IEnumerator LBFEJBGHMBO()
		{
			yield return null;
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.GameStarter, "Start Scene Loading Next Started @:" + Time.realtimeSinceStartup);
			if (MDGKDGMGGCL.GABGKBAKHDP.BKKHDJKIIBP == 1)
			{
				MDGKDGMGGCL.GABGKBAKHDP.JFEDLJOAJEM(true);
				MDGKDGMGGCL.GABGKBAKHDP.OJKFPLOOKLA(true);
			}
			if (MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() == 0)
			{
				LevelBuilder.CurrentLevelNo = 1;
				LevelBuilder.KDBDBMBAKEL = "Automatic";
				CaravanSceneManager.Load(GKBHIKONCKJ.GamePlay);
			}
			else
			{
				CaravanSceneManager.Load(GKBHIKONCKJ.Map);
			}
			LoadingScreenDisplayer.Instance.InstantFade = false;
		}

		private static void LLHFCAEPMHO(BFIJOGBGCNK IDFKOGCNBHM)
		{
		}

		private static void AGDNCKLIKOD(LFMKFEKMMIK DIDHNNMKJFE)
		{
			try
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "App opened from notification:{0}", DIDHNNMKJFE.IDFKOGCNBHM.AHJMDABAPGK.FCEEGNFABAF);
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Notification, "App opened from notification error:{0} Stack:{1}", ex.Message, ex.StackTrace);
			}
		}

		private static void LKFFGGECIKC(string GGFBAOBHKCI, string FJALLAHCPMD)
		{
			KMBNIBGIHGH.GABGKBAKHDP.BDJMFMFGCPF(FJALLAHCPMD);
		}

		private static void JFLDPHFHJOL()
		{
			try
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.GameStarter, "Send OneSignal tags.");
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				if (LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA != null)
				{
					dictionary.Add("FacebookId", LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA);
				}
				else
				{
					OneSignal.DeleteTag("FacebookId");
				}
				if (LECPGNKOABP.GABGKBAKHDP.ILNAPPDKOOD)
				{
					dictionary.Add("PayerTag", "1");
				}
				dictionary.Add("LevelTag", (MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1).ToString());
				dictionary.Add("UserIdTag", LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString());
				dictionary.Add("TeamIdTag", LECPGNKOABP.GABGKBAKHDP.OADDPGNIINO.ToString());
				int num = TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).Hours;
				if (num > 12)
				{
					num -= 24;
				}
				else if (num < -11)
				{
					num += 24;
				}
				dictionary.Add("TimezoneTag", num.ToString());
				OneSignal.SendTags(dictionary);
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.GameStarter, "Error! {0} Stack:{1} ", ex.Message, ex.StackTrace);
			}
		}

		[CompilerGenerated]
		private void LOGNDCMDKFH()
		{
			StartCoroutine(LBFEJBGHMBO());
		}
	}
}
