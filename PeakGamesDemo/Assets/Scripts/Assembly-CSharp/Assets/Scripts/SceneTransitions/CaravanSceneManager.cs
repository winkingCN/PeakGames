using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.GamePlayScene.UI;
using Assets.Scripts.MapScene;
using Assets.Scripts.Utils;
using GamePlayScene.UI;
using NewMapScene;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.SceneTransitions
{
	public class CaravanSceneManager : MonoBehaviour
	{
		private static bool GPPJHILMNLI;

		private const string EDOKBMFGFKI = "EmptyScene";

		public static GKBHIKONCKJ SceneToBeLoaded;

		public static GKBHIKONCKJ PreviousScene;

		public static GKBHIKONCKJ CurrentScene = GKBHIKONCKJ.Start;

		private static CaravanSceneManager ADDMCENEKJC;

		public LoadingScreenDisplayer CurrentLoadingScreenDisplayer;

		private readonly Dictionary<int, KLKAGJKCKBE> ABBEAPHMMPM = new Dictionary<int, KLKAGJKCKBE>
		{
			{
				1,
				KLKAGJKCKBE.Rocket
			},
			{
				2,
				KLKAGJKCKBE.Rocket
			},
			{
				3,
				KLKAGJKCKBE.Bomb
			},
			{
				4,
				KLKAGJKCKBE.Discoball
			},
			{
				5,
				KLKAGJKCKBE.RocketBomb
			},
			{
				6,
				KLKAGJKCKBE.DoubleBomb
			},
			{
				7,
				KLKAGJKCKBE.RandomRocket
			}
		};

		private int MOFJJEKCBJH;

		public static bool GDLJAINDFOJ
		{
			get
			{
				return GPPJHILMNLI;
			}
			private set
			{
				GPPJHILMNLI = value;
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanSceneManager, "Scene loading flag is: {0}", value);
			}
		}

		public static void ShowLoading(KLKAGJKCKBE NBFBPNNEKMN)
		{
			ADDMCENEKJC.CurrentLoadingScreenDisplayer.ShowLoading(NBFBPNNEKMN);
		}

		public static void HideLoading()
		{
			ADDMCENEKJC.CurrentLoadingScreenDisplayer.StartFadeOut();
		}

		public void Awake()
		{
			if (ADDMCENEKJC != null)
			{
				Object.Destroy(ADDMCENEKJC.gameObject);
			}
			ADDMCENEKJC = this;
			Object.DontDestroyOnLoad(base.gameObject);
		}

		public static void Load(GKBHIKONCKJ HPLOBNMLMMP, string MMBIKIOIIPH = null)
		{
			if (ADDMCENEKJC == null)
			{
				DEJDIOFGNEN(HPLOBNMLMMP);
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanSceneManager, "Fast loading scene {0} with bottomLineKey:{1}", HPLOBNMLMMP, MMBIKIOIIPH);
				AudioManager.StopSong();
				SceneManager.LoadScene(LEIDGGDLNMC(HPLOBNMLMMP));
				GDLJAINDFOJ = false;
				CurrentScene = HPLOBNMLMMP;
				SceneToBeLoaded = GKBHIKONCKJ.None;
			}
			else
			{
				ADDMCENEKJC.StartCoroutine(ADDMCENEKJC.DEDFMNDMPAH(HPLOBNMLMMP, MMBIKIOIIPH));
			}
		}

		private static void DEJDIOFGNEN(GKBHIKONCKJ HPLOBNMLMMP)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanSceneManager, "Resetting for scene {0}", HPLOBNMLMMP);
			GDLJAINDFOJ = true;
			if (MapUIAnimationController.Instance != null)
			{
				MapUIAnimationController.Instance.ResetSelf();
			}
			ParticlePool.ResetSelf();
			ScoreManager.ResetSelf();
			FallManager.ResetSelf();
			FHAAAFAAMDO.GABGKBAKHDP.FPGFIAKIIID();
			HintManager.INJHFIFHKOB();
			BlackPanel.ResetSelf();
			SettingsPanel.ResetSelf();
			CollectManager.ResetSelf();
			BlasterCollectManager.ResetSelf();
			MJPAKGMNFAC.INJHFIFHKOB();
			LLJLGKECBBE.INJHFIFHKOB();
			NLMLKADGECN.INJHFIFHKOB();
			AudioManager.ResetExternalAudioSources();
			LevelBuilder.BackgroundAssetsLoaded = false;
			if (CurrentScene == GKBHIKONCKJ.Map && HPLOBNMLMMP != GKBHIKONCKJ.Map)
			{
				NewMapAnimationController currentNewMapAnimationController = MapManager.Instance.CurrentNewMapAnimationController;
				if (currentNewMapAnimationController.LPIEKIDOGNI)
				{
					currentNewMapAnimationController.Reset();
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.MapAnimationController, "Animation flow stopped because of scene change.");
				}
				currentNewMapAnimationController.StopFocusAnimationCoroutine();
			}
			switch (HPLOBNMLMMP)
			{
			case GKBHIKONCKJ.Map:
				AudioManager.LoadMapAudioFiles();
				break;
			case GKBHIKONCKJ.GamePlay:
				AudioManager.LoadGameplayAudioFiles();
				break;
			}
			if (HPLOBNMLMMP != GKBHIKONCKJ.GamePlay)
			{
				LevelBuilder.ShouldRemoveBackgroundImagesOnDestroy = true;
			}
			PreviousScene = CurrentScene;
			SceneToBeLoaded = HPLOBNMLMMP;
		}

		private static void LODAFCLDMAO()
		{
			FMEFHCIEJDO.INJHFIFHKOB();
		}

		private IEnumerator DEDFMNDMPAH(GKBHIKONCKJ HPLOBNMLMMP, string MMBIKIOIIPH = null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanSceneManager, "Async loading scene {0}", HPLOBNMLMMP);
			MOFJJEKCBJH++;
			if (GDLJAINDFOJ)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanSceneManager, "Will wait previous loading.");
				while (GDLJAINDFOJ)
				{
					yield return null;
				}
			}
			DEJDIOFGNEN(HPLOBNMLMMP);
			if (!CurrentLoadingScreenDisplayer.CDIJIMCMCOE)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanSceneManager, "Selecting loading type for {0}", HPLOBNMLMMP);
				KLKAGJKCKBE value = KLKAGJKCKBE.Default;
				if (CurrentScene == GKBHIKONCKJ.GamePlay && HPLOBNMLMMP == GKBHIKONCKJ.Map)
				{
					value = KLKAGJKCKBE.ToMap;
				}
				else if (CurrentScene == GKBHIKONCKJ.Start)
				{
					value = KLKAGJKCKBE.Initial;
				}
				else if ((HPLOBNMLMMP == GKBHIKONCKJ.GamePlay || CurrentScene == GKBHIKONCKJ.GamePlay) && !ABBEAPHMMPM.TryGetValue(LevelBuilder.CurrentLevelNo, out value))
				{
					KLKAGJKCKBE[] array = new KLKAGJKCKBE[6]
					{
						KLKAGJKCKBE.Bomb,
						KLKAGJKCKBE.Discoball,
						KLKAGJKCKBE.Rocket,
						KLKAGJKCKBE.DoubleBomb,
						KLKAGJKCKBE.RocketBomb,
						KLKAGJKCKBE.RandomRocket
					};
					value = array[Random.Range(0, array.Length)];
				}
				IEnumerator showLoadingEnumerator = CurrentLoadingScreenDisplayer.GetShowLoadingEnumerator(value, null, MMBIKIOIIPH);
				while (showLoadingEnumerator.MoveNext())
				{
					yield return showLoadingEnumerator.Current;
				}
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanSceneManager, "GetShowLoadingEnumerator completed for {0}", HPLOBNMLMMP);
			}
			LODAFCLDMAO();
			string sceneName = LEIDGGDLNMC(HPLOBNMLMMP);
			AudioManager.StopSong();
			if (SceneToBeLoaded == GKBHIKONCKJ.GamePlay)
			{
				TMP_Settings.defaultSpriteAsset = null;
			}
			else if (TMP_Settings.defaultSpriteAsset == null)
			{
				TMP_Settings.defaultSpriteAsset = Resources.Load("Font/Emoji Sprite Asset") as TMP_SpriteAsset;
			}
			yield return SceneManager.LoadSceneAsync("EmptyScene");
			yield return SceneManager.LoadSceneAsync(sceneName);
			FHAAAFAAMDO.GABGKBAKHDP.FPGFIAKIIID();
			switch (SceneToBeLoaded)
			{
			case GKBHIKONCKJ.Map:
				if (MapManager.Instance == null || !MapManager.Instance.LMMGPLJKJHG)
				{
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanSceneManager, "Waiting map to be loaded.");
					float time2 = Time.time;
					while (MapManager.Instance == null || !MapManager.Instance.LMMGPLJKJHG)
					{
						yield return null;
					}
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanSceneManager, "Map loaded in {0} secs.", Time.time - time2);
				}
				break;
			case GKBHIKONCKJ.GamePlay:
				if (!LevelBuilder.BackgroundAssetsLoaded)
				{
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanSceneManager, "Waiting GamePlay to be loaded");
					float time = Time.time;
					while (!LevelBuilder.BackgroundAssetsLoaded)
					{
						yield return null;
					}
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanSceneManager, "GamePlay loaded in {0} sec.", Time.time - time);
				}
				break;
			}
			MOFJJEKCBJH--;
			if (MOFJJEKCBJH == 0)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanSceneManager, "Async loading is completed. Starting fadeout. {0}", HPLOBNMLMMP);
				CurrentLoadingScreenDisplayer.StartFadeOut();
			}
			if (SceneToBeLoaded == GKBHIKONCKJ.Map)
			{
				yield return MCJHHDACJBG.CHFOIGLAMPN;
			}
			CurrentScene = SceneToBeLoaded;
			SceneToBeLoaded = GKBHIKONCKJ.None;
			GDLJAINDFOJ = false;
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanSceneManager, "Loading logic completed for scene {0}", HPLOBNMLMMP);
		}

		private static string LEIDGGDLNMC(GKBHIKONCKJ HPLOBNMLMMP)
		{
			switch (HPLOBNMLMMP)
			{
			case GKBHIKONCKJ.GamePlay:
				return "GamePlayScene";
			case GKBHIKONCKJ.Map:
				return "NewMapScene";
			case GKBHIKONCKJ.Start:
				return "StartScene";
			case GKBHIKONCKJ.LevelLoader:
				return "LevelLoaderScene";
			case GKBHIKONCKJ.Empty:
				return "EmptyScene";
			default:
				return "NewMapScene";
			}
		}
	}
}
