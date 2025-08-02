using System.Collections;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.Dialogs;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Tutorials;
using Assets.Scripts.SceneTransitions;
using Assets.Scripts.Utils;
using Dialogs;
using LevelLoaderScene;
using MapScene;
using NewMapScene;
using ToonSocial;
using UnityEngine;
using Utils;

namespace Assets.Scripts.MapScene
{
	public class MapManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class PFOHPNBJFEI
		{
			internal bool BECJCCINEHH;

			internal MapManager PDAPIGLEPGC;

			internal void AGFNGEFDHLA(bool PAEFDANMKNM)
			{
				PDAPIGLEPGC.NewMapContent.PrepareMapDisplays(BECJCCINEHH);
				if (PDAPIGLEPGC.NewMapContent.EINEBDMKFPJ != null)
				{
					PDAPIGLEPGC.NewMapContent.BackgroundImage.sprite = PDAPIGLEPGC.NewMapContent.EINEBDMKFPJ;
				}
				if (PAEFDANMKNM)
				{
					PDAPIGLEPGC.NewMapContent.PrepareChampionsLeagueDisplay(BECJCCINEHH);
				}
			}
		}

		public const int MAP_BACKGROUND_IMAGE_COUNT = 64;

		public const int TOTAL_LEVEL_COUNT = 2850;

		public static bool IsFirstTime = true;

		public static bool DidShowMoreLevelsPopup;

		public static string CurrentMapId = "1";

		public static MapManager Instance;

		public Camera CurrentCamera;

		public CameraSizer CurrentCameraSizer;

		public ContainerManager CurrentContainerManager;

		public SocialHelper CurrentSocialHelper;

		public NewMapAnimationController CurrentNewMapAnimationController;

		public LeaderboardPageController CurrentLeaderboardPageController;

		public MapPageSizer CurrentMapPageSizer;

		public SwipeManager CurrentSwipeManager;

		public Transform LivesConnectedContainer;

		public Transform LivesConnectedButtonPos;

		public Transform LivesNotConnectedContainer;

		public Transform LivesNotConnectedButtonPos;

		public Transform LivesTabButton;

		public Transform LivesTabButtonBackLeft;

		public Transform LivesTabButtonBackRight;

		public GameObject MapTutorialReference;

		public NewMapPage NewMapContent;

		public GameObject TopPanelBlocker;

		public MapSettingsDisplay MapSettingsDisplay;

		private bool BIELEFAPPBF;

		private bool MLOFDFAPEPB;

		private float HPDLLEPFGPC;

		public FadingAndFloatingText ErrorMessage;

		public bool EpisodeUnlocked;

		public GameObject CheatPanel;

		public int NNDCJLBBGAB { get; private set; }

		public int AGBOBACEIEP { get; private set; }

		public bool LMMGPLJKJHG
		{
			get
			{
				return NewMapContent.IsReady;
			}
		}

		public void ShowTopPanelBlocker(bool JIAPOBDACNL)
		{
			TopPanelBlocker.SetActive(JIAPOBDACNL);
		}

		public void ShowErrorMessage(string AELPGDIJOCN)
		{
			ErrorMessage.SetPosition(new Vector3(0f, -2.8f, 0f));
			BBFNAILAPBP(AELPGDIJOCN);
		}

		public void ShowErrorMessageAtPosition(string AELPGDIJOCN, Vector3 FADJPCHMMBH)
		{
			ErrorMessage.SetPosition(FADJPCHMMBH);
			BBFNAILAPBP(AELPGDIJOCN);
		}

		public void ShowErrorMessageAtPosition(string AELPGDIJOCN, Vector3 FADJPCHMMBH, float JCCOPGOBLLG, float CBPBPILHPCL, float EJFDHNPHLMM)
		{
			ErrorMessage.SetPosition(FADJPCHMMBH);
			ErrorMessage.TextItSelf.FCJBBPHFNPJ = AELPGDIJOCN;
			if (ErrorMessage.Shadow != null)
			{
				ErrorMessage.Shadow.FCJBBPHFNPJ = AELPGDIJOCN;
			}
			ErrorMessage.DoAnimation(JCCOPGOBLLG, CBPBPILHPCL, false);
		}

		private void BBFNAILAPBP(string AELPGDIJOCN)
		{
			ErrorMessage.TextItSelf.FCJBBPHFNPJ = AELPGDIJOCN;
			if (ErrorMessage.Shadow != null)
			{
				ErrorMessage.Shadow.FCJBBPHFNPJ = AELPGDIJOCN;
			}
			ErrorMessage.DoAnimation();
		}

		public void StopErrorMessage()
		{
			ErrorMessage.KillAnimation();
		}

		public static int GetMapIdForLevel(int GIOFHACJEGA)
		{
			float value = ((GIOFHACJEGA < 201) ? (((float)GIOFHACJEGA - 1f) / 20f + 1f) : ((GIOFHACJEGA < 321) ? (((float)GIOFHACJEGA - 201f) / 40f + 11f) : ((GIOFHACJEGA >= 351) ? (((float)GIOFHACJEGA - 401f) / 50f + 16f) : 14f)));
			return (int)Mathf.Clamp(value, 1f, 64f);
		}

		public static Vector2 GetLevelsForEpisode(int FIAPMIFBLGK)
		{
			Vector2 result = new Vector2(0f, 0f);
			FIAPMIFBLGK = Mathf.Clamp(FIAPMIFBLGK, 1, 64);
			if (FIAPMIFBLGK < 11)
			{
				result.x = (float)(FIAPMIFBLGK - 1) * 20f + 1f;
				result.y = (float)FIAPMIFBLGK * 20f;
			}
			else if (FIAPMIFBLGK < 14)
			{
				result.x = (float)(FIAPMIFBLGK - 11) * 40f + 201f;
				result.y = (float)(FIAPMIFBLGK - 10) * 40f + 200f;
			}
			else if (FIAPMIFBLGK == 14)
			{
				result.x = 321f;
				result.y = 350f;
			}
			else
			{
				result.x = (float)(FIAPMIFBLGK - 16) * 50f + 401f;
				result.y = (float)(FIAPMIFBLGK - 15) * 50f + 400f;
			}
			return result;
		}

		public void OnMapAnimationsCompleted()
		{
			NewMapContent.PrepareMapDisplays(IDFPAFEJPPH.GABGKBAKHDP.HGNJBHGBLIN);
			if (MLOFDFAPEPB)
			{
				StartCoroutine(GJJDFOOGCMH());
			}
			else
			{
				GOAMHBIBLNC();
			}
		}

		private IEnumerator GJJDFOOGCMH()
		{
			yield return MCJHHDACJBG.CHFOIGLAMPN;
			GOAMHBIBLNC();
		}

		private void GOAMHBIBLNC()
		{
			if (!BIELEFAPPBF)
			{
				CurrentSocialHelper.StartSocialHelper();
			}
		}

		public void Awake()
		{
			LevelLoaderController.FakeLevelNo = -1;
			CACKIGBBMPB.GABGKBAKHDP.DLJPFGHEPLB = false;
			OCDFEHOJLPJ();
			Instance = this;
			KBEGNPKLMDE.IAEBCJLMJJO();
			ANGCNEFIIHE.GABGKBAKHDP.GIFMDPFFCDH();
			ANGCNEFIIHE.GABGKBAKHDP.MAJNMFPONHF();
			IIMOEAOONKA.HGABPIDMBEK = false;
			DMEKKNGOCNH.HJFAFDBCEMN();
			NewMapContent.gameObject.SetActive(false);
			MLOFDFAPEPB = NDGOJGLPIJF.GABGKBAKHDP.AMKOJOKCELO > 0;
			NNDCJLBBGAB = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1;
			AGBOBACEIEP = GetMapIdForLevel(NNDCJLBBGAB);
			ErrorMessage.gameObject.SetActive(false);
			NANPEDFGNEP();
		}

		private static void OCDFEHOJLPJ()
		{
			if (LevelLoaderController.IsOnlineLevel || LevelLoaderController.IsOfflineLevel)
			{
				LevelBuilder.CurrentLevelNo = 0;
				LevelLoaderController.IsOnlineLevel = false;
				LevelLoaderController.IsOfflineLevel = false;
			}
			LevelLoaderController.Record = null;
			LevelLoaderController.RandomSeed = 0;
			TutorialManager.ForceShowTutorials = false;
		}

		private static void INJHFIFHKOB()
		{
			Instance = null;
		}

		public void OnDestroy()
		{
			BIELEFAPPBF = true;
			INJHFIFHKOB();
		}

		public void Start()
		{
			TopPanelBlocker.SetActive(false);
			CurrentSwipeManager.EnableScroll(false);
			DialogLibrary.GABGKBAKHDP.PrelevelDialog.FLFDKMOOIFL(1);
			StartCoroutine(CEFEOMACCDO());
			if (!MKINMKEMBPL.GABGKBAKHDP.HEANMKDLPGF("UserEnteredMap"))
			{
				MKINMKEMBPL.GABGKBAKHDP.KMPGGMKICLB("UserEnteredMap");
			}
			float hJLOCAEAFMJ = CurrentCamera.orthographicSize * 2f * CurrentCamera.aspect / 10.24f;
			NewMapContent.gameObject.SetActive(true);
			NewMapContent.Prepare(NNDCJLBBGAB, hJLOCAEAFMJ);
			if (!FIFHGMECPMI())
			{
				LCHNACPGJFN();
			}
			CheatPanel.SetActive(false);
			if (LECPGNKOABP.GABGKBAKHDP.FBJPAPPABGJ)
			{
				FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.DeviceBanDialog, false);
			}
		}

		private void LCHNACPGJFN()
		{
			if (IDFPAFEJPPH.GABGKBAKHDP.HGNJBHGBLIN)
			{
				NewMapContent.LoadMapAsset(0, LKAEBIGNLLG);
				return;
			}
			AGBOBACEIEP = GetMapIdForLevel(NNDCJLBBGAB);
			if (LevelBuilder.LastLevel.HLFNDDEDJOI && (float)NNDCJLBBGAB == GetLevelsForEpisode(AGBOBACEIEP).x)
			{
				NewMapContent.LoadMapAsset(AGBOBACEIEP - 1, LKAEBIGNLLG);
				EpisodeUnlocked = true;
			}
			else
			{
				NewMapContent.LoadMapAsset(AGBOBACEIEP, LKAEBIGNLLG);
				EpisodeUnlocked = false;
			}
		}

		private void LKAEBIGNLLG(bool PAEFDANMKNM)
		{
			if (NewMapContent.EINEBDMKFPJ != null)
			{
				NewMapContent.BackgroundImage.sprite = NewMapContent.EINEBDMKFPJ;
				if (IDFPAFEJPPH.GABGKBAKHDP.HGNJBHGBLIN && NewMapContent.EINEBDMKFPJ.name != 0.ToString())
				{
					LCHNACPGJFN();
					return;
				}
			}
			StartCoroutine(KMMDGJPKEGO());
		}

		private IEnumerator KMMDGJPKEGO()
		{
			NewMapContent.PrepareMapDisplays(IDFPAFEJPPH.GABGKBAKHDP.HGNJBHGBLIN);
			yield return null;
			CurrentNewMapAnimationController.LNGHOBJLPGL = false;
			CurrentNewMapAnimationController.StartAnimationFlow();
			CurrentNewMapAnimationController.OnAnimationCompleted = Instance.OnMapAnimationsCompleted;
		}

		private bool FIFHGMECPMI()
		{
			if (CaravanSceneManager.PreviousScene == GKBHIKONCKJ.GamePlay || CaravanSceneManager.PreviousScene == GKBHIKONCKJ.LevelLoader || !CACKIGBBMPB.GABGKBAKHDP.CLNAHDCHOFI)
			{
				return false;
			}
			if (AGBOBACEIEP != 64)
			{
				return false;
			}
			if ((float)NNDCJLBBGAB != GetLevelsForEpisode(AGBOBACEIEP).x)
			{
				return false;
			}
			if (AGBOBACEIEP == PlayerPrefs.GetInt("UnlockedEpisode", 0))
			{
				return false;
			}
			if (!IMINNGDLCCE.EHFANHPHHEB(AGBOBACEIEP))
			{
				return false;
			}
			CurrentNewMapAnimationController.LNGHOBJLPGL = true;
			PlayerPrefs.SetInt("UnlockedEpisode", AGBOBACEIEP);
			GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.EpisodeUnlockedDialog, false, false, false, null, false);
			EpisodeUnlockedDialog component = gameObject.GetComponent<EpisodeUnlockedDialog>();
			component.PrepareDialog(delegate
			{
				LKAEBIGNLLG(false);
			});
			return true;
		}

		public void EnableTaps(bool IEGIOBJMGKJ)
		{
			if (CurrentSwipeManager != null)
			{
				CurrentSwipeManager.EnableScroll(IEGIOBJMGKJ);
			}
			SpriteButtonListener.Instance.EnableClicks = IEGIOBJMGKJ;
		}

		private IEnumerator CEFEOMACCDO()
		{
			while (CaravanSceneManager.GDLJAINDFOJ)
			{
				yield return null;
			}
			AudioManager.PlaySong();
		}

		public void OnSettingsClick()
		{
			FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.SettingsDialog, false);
		}

		public void OnLevelStopClick(int KIGOGMKCDKN)
		{
			if (!FHAAAFAAMDO.GABGKBAKHDP.COCNAAGPOMN)
			{
				GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.PrelevelDialog, false, false, true);
				PrelevelDialog component = gameObject.GetComponent<PrelevelDialog>();
				if (component != null)
				{
					component.SetContent(KIGOGMKCDKN);
				}
			}
		}

		public void ContinueSocialTutorial(int JOLLBLJKOGA)
		{
			if (CurrentNewMapAnimationController.FLJGANLMLJD is GFIEJLKCDDD)
			{
				GFIEJLKCDDD gFIEJLKCDDD = CurrentNewMapAnimationController.FLJGANLMLJD as GFIEJLKCDDD;
				gFIEJLKCDDD.GNKFLPGAPKK(JOLLBLJKOGA);
			}
		}

		public void OnMapTouch()
		{
			AudioManager.Play(KOOGPFAPGGD.UiClick, GCEAKOOGDJK.Multiple);
			FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.EpisodeNavigationDialog, false, false, false, null, false);
		}

		public void ShouldShowChampionsLeague()
		{
			int bDKFNEDHAOJ = AGBOBACEIEP;
			IDFPAFEJPPH iDFPAFEJPPH = IDFPAFEJPPH.GABGKBAKHDP;
			bool BECJCCINEHH = iDFPAFEJPPH.HGNJBHGBLIN && iDFPAFEJPPH.AEBACBBGHKI > 0;
			if (BECJCCINEHH)
			{
				bDKFNEDHAOJ = 0;
			}
			NewMapContent.LoadMapAsset(bDKFNEDHAOJ, delegate(bool PAEFDANMKNM)
			{
				NewMapContent.PrepareMapDisplays(BECJCCINEHH);
				if (NewMapContent.EINEBDMKFPJ != null)
				{
					NewMapContent.BackgroundImage.sprite = NewMapContent.EINEBDMKFPJ;
				}
				if (PAEFDANMKNM)
				{
					NewMapContent.PrepareChampionsLeagueDisplay(BECJCCINEHH);
				}
			});
		}

		public void UpdateChampionsLeagueRank(int JEAAHAFHDEG)
		{
			NewMapContent.CLRankDisplay.UpdateRank(JEAAHAFHDEG);
		}

		private void NANPEDFGNEP()
		{
			if (LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM > 0)
			{
				if (PlayerPrefs.HasKey("InvalidBinary"))
				{
					AFJPGLHKOID.CPIGOAGGLBM("RenderType", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, 3, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString());
					PlayerPrefs.DeleteKey("InvalidBinary");
				}
				if (PlayerPrefs.HasKey("BrokenBinary"))
				{
					AFJPGLHKOID.CPIGOAGGLBM("RenderType", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, 5, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString());
					PlayerPrefs.DeleteKey("BrokenBinary");
				}
			}
		}

		[CompilerGenerated]
		private void BGELHPJEGCB()
		{
			LKAEBIGNLLG(false);
		}
	}
}
