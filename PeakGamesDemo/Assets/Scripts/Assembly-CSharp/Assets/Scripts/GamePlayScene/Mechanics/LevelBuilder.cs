using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Assets.Scripts.Dialogs;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Mechanics.Items.Features;
using Assets.Scripts.GamePlayScene.Mechanics.Items.SpecialItems;
using Assets.Scripts.GamePlayScene.Touches;
using Assets.Scripts.GamePlayScene.Tutorials;
using Assets.Scripts.GamePlayScene.UI;
using Assets.Scripts.MapScene;
using Assets.Scripts.SceneTransitions;
using Assets.Scripts.Utils;
using Caravan.Meta.LevelMeta;
using DG.Tweening;
using GamePlayScene.Mechanics;
using GamePlayScene.Mechanics.Items;
using GamePlayScene.Mechanics.Items.ComboItems;
using GamePlayScene.Mechanics.Items.SpecialItems;
using GamePlayScene.UI;
using LevelLoaderScene;
using ProtoBuf;
using TMPro;
using UnityEngine;
using Utils;
using Utils.Game;

namespace Assets.Scripts.GamePlayScene.Mechanics
{
	public class LevelBuilder : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class IFDKODPBLLL
		{
			internal bool NIEHLOMGPLC;

			internal LevelBuilder PDAPIGLEPGC;

			internal void AGFNGEFDHLA()
			{
				PDAPIGLEPGC.NBJJOILLPLP();
				bool nBGIEJKPDON = false;
				bool cELKBIHEFHP = CurrentLevelNo < 50 && PDAPIGLEPGC.PKPBMFKPGFE;
				BIMAONBKNOP tutorialForLevel = TutorialManager.GetTutorialForLevel(CurrentLevelNo, cELKBIHEFHP);
				if (!PDAPIGLEPGC.OBOHCGCDMIL() && tutorialForLevel != null)
				{
					PDAPIGLEPGC.NKMANNPOAGM(tutorialForLevel);
					nBGIEJKPDON = true;
				}
				if (NIEHLOMGPLC)
				{
					GamePlayRecord record = LevelLoaderController.Record;
					PDAPIGLEPGC.IFLNNILPLIG(record.p, record.c);
					PDAPIGLEPGC.ReplayManager.PlayRecord(record);
				}
				else
				{
					PDAPIGLEPGC.IKGBNGMIBCJ((tutorialForLevel != null) ? tutorialForLevel.BALIENJLCLB : null, nBGIEJKPDON);
				}
			}
		}

		[CompilerGenerated]
		private sealed class JOJJOCDADGA
		{
			internal bool NBGIEJKPDON;

			internal bool FEHACKOBGBL;
		}

		[CompilerGenerated]
		private sealed class BPDINBICGEJ
		{
			internal SpecialItem BBHFBHMLHPN;

			internal Cell LBHDELJBONF;

			internal Item MFLAFJACJPO;

			internal JOJJOCDADGA EDLEPJMMJBA;

			internal void AGFNGEFDHLA()
			{
				BBHFBHMLHPN.CurrentSpriteRenderer.color = new Color(1f, 1f, 1f, 0f);
			}

			internal void KDACLOKGNAM()
			{
				LBHDELJBONF.LBFCDKPCDPB = BBHFBHMLHPN;
				if (MFLAFJACJPO != null)
				{
					MFLAFJACJPO.RemoveSelf();
				}
				CanCastShadowComponent.CastShadowIfPossible(LBHDELJBONF);
				if (!EDLEPJMMJBA.NBGIEJKPDON)
				{
					if (EDLEPJMMJBA.FEHACKOBGBL)
					{
						ParticlePool.Instance.PlayParticle(ParticlePool.Instance.SpecialItemPlaceParticle, LBHDELJBONF.GetFrozenPosition());
					}
					AudioManager.Play(KOOGPFAPGGD.SpecialItemPlace);
				}
				if (BBHFBHMLHPN is BombItem)
				{
					BBHFBHMLHPN.StartAnimations();
				}
			}
		}

		private readonly LevelDataMetaSerializer GJBNLEPCELA = new LevelDataMetaSerializer();

		public static DPKNJMPFNGC LastLevel;

		public static KFCEILFGADG ActiveLevel;

		public static MLPHFMDIMLB Recorder;

		private static HashSet<string> DNMNOCJAPDP;

		public static bool BackgroundAssetsLoaded;

		public static bool ShouldRemoveBackgroundImagesOnDestroy = true;

		public static bool IsLevelDataLoaded;

		public static long GameplayUserId;

		public static bool DidUseLife;

		public static int CurrentLevelNo;

		public static string CurrentLevelPath;

		private bool PKPBMFKPGFE;

		public const string LevelStart_Map = "Map";

		public const string LevelStart_TryAgain = "TryAgain";

		public const string LevelStart_Restart = "Restart";

		public const string LevelStart_Auto = "Automatic";

		public const string TapToSkipKey = "TapToSkipCount";

		public TextMeshPro RandomTypeText;

		public SpriteRenderer NewMapBackgroundImage;

		public KFCEILFGADG CurrentLevel;

		public GameObject TutorialBearPanel;

		public FPSMeter FPSMeter;

		public ReplayManager ReplayManager;

		private LevelMetaData GGDDNIIEFFF;

		private ItemResourcesManager HNPADMPIFDA;

		private int BHOEGFGLFNM;

		private List<GameObject> CPFIMFEHJGJ;

		private Dictionary<NOALGNJECAD, List<Item>> KCIONBHDHEO;

		private Dictionary<int, Cell> KEFMJJAJAPB;

		private bool FLANIJLBDMP;

		private bool EBMLBHAGAII = true;

		private const int EAGHNIKGIOK = 60;

		private const int PKABCBEBHIF = 60;

		private bool AOOIPIIBPLH;

		public Dictionary<NOALGNJECAD, int> GoalCountDict;

		private bool KCEOIKDCGGL;

		public HintManager CurrentHintManager;

		public Transform CellContainer;

		public Transform ItemContainer;

		public CaravanTopPanel CurrentTopPanel;

		public ShakeAnimation[] PanelShakeAnimations;

		public GameObject CellPrefab;

		public Sprite[] BorderImages;

		private GameObject PFDAAAAPJED;

		private GameObject CFPBIMCGOML;

		private GameObject AHGBGKFOEML;

		private GameObject DJADHIALFMB;

		private GameObject PLKAAPLNNMK;

		public GameObject TutorialManagerPrefab;

		public WinLogoAnimation WinLogoAnimation;

		public WinCharsAnimation WinCharsAnimation;

		public TextMeshPro TapToSkipText;

		public BoxCollider2D TapToSkipCollider;

		public Transform BoosterPanel;

		public GameObject GenericCollectItem;

		public GameObject BlasterItemCollectAnimation;

		public GamePlayCameraSizer CurrentCameraSizer;

		private KLKAGJKCKBE[] LEMANCBLOGA = new KLKAGJKCKBE[6]
		{
			KLKAGJKCKBE.Bomb,
			KLKAGJKCKBE.Discoball,
			KLKAGJKCKBE.Rocket,
			KLKAGJKCKBE.DoubleBomb,
			KLKAGJKCKBE.RocketBomb,
			KLKAGJKCKBE.RandomRocket
		};

		[CompilerGenerated]
		private static Comparison<OGIFMLFEAEM> EBCOMJBLIPP;

		[CompilerGenerated]
		private static TweenCallback DNBOPLHGMHA;

		public static string KDBDBMBAKEL { get; set; }

		public static bool EEPCGJDBPAE { get; set; }

		public ShakeAnimation FOOIMKGODLK
		{
			get
			{
				return PanelShakeAnimations[1];
			}
		}

		public static void RemoveABLevels(string LCCKDPIBKPJ)
		{
			DNMNOCJAPDP = null;
			string path = Path.Combine(LCCKDPIBKPJ, "ablevels/");
			if (!Directory.Exists(path))
			{
				return;
			}
			string[] files = Directory.GetFiles(path);
			int num = files.Length;
			if (num > 0)
			{
				for (int i = 0; i < num; i++)
				{
					File.Delete(files[i]);
				}
			}
			Directory.Delete(path);
		}

		public static void HashABLevels(string LCCKDPIBKPJ)
		{
			string path = Path.Combine(LCCKDPIBKPJ, "ablevels/");
			if (!Directory.Exists(path))
			{
				return;
			}
			string[] files = Directory.GetFiles(path);
			int num = files.Length;
			if (num != 0)
			{
				DNMNOCJAPDP = new HashSet<string>();
				for (int i = 0; i < num; i++)
				{
					string item = Path.GetFileName(files[i]).Split('.')[0];
					DNMNOCJAPDP.Add(item);
				}
			}
		}

		public void TapToSkip()
		{
			if (!AOOIPIIBPLH && CurrentLevel != null && CurrentLevel.NPMIKDPNBIA && CurrentLevel.EPGNODLFKDC)
			{
				AOOIPIIBPLH = true;
				CurrentLevel.FDALIJBFECF();
			}
		}

		private void JHICENAEPPG()
		{
			HJBLKNBHMFJ hJBLKNBHMFJ = HJBLKNBHMFJ.GABGKBAKHDP;
			string text = hJBLKNBHMFJ.LIANKDMAHFM("TapToSkipCount");
			if (text == null)
			{
				hJBLKNBHMFJ.JGMDDMNGDJO("TapToSkipCount", "0");
			}
			else
			{
				int.TryParse(text, out BHOEGFGLFNM);
			}
		}

		public void IncreaseTapToSkipCount()
		{
			HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("TapToSkipCount", (BHOEGFGLFNM + 1).ToString());
		}

		public bool ShouldDisplayTapToSkipContent()
		{
			return BHOEGFGLFNM < 30;
		}

		public bool IsTapToSkipEnabled()
		{
			return CurrentLevelNo > 2;
		}

		public void OnDestroy()
		{
			ActiveLevel = null;
			AudioManager.StopSong();
		}

		public void Awake()
		{
			if (ELBMHNOBHPN.DJGMHLLAGLE || LECPGNKOABP.GABGKBAKHDP.FBJPAPPABGJ)
			{
				CaravanSceneManager.Load(GKBHIKONCKJ.Map);
			}
			if (!EEPCGJDBPAE)
			{
				EEPCGJDBPAE = true;
			}
			IsLevelDataLoaded = false;
			try
			{
				JHICENAEPPG();
				Sprite sprite = null;
				if (LevelLoaderController.IsMarketingLevel && LevelLoaderController.IsOnlineLevel)
				{
					string path = Application.persistentDataPath + "/marketingBackgroundImage.png";
					if (File.Exists(path))
					{
						Texture2D texture2D = new Texture2D(1024, 2048, TextureFormat.RGB24, false);
						texture2D.filterMode = FilterMode.Bilinear;
						Texture2D texture2D2 = texture2D;
						byte[] data = File.ReadAllBytes(path);
						texture2D2.LoadImage(data);
						texture2D2.name = "MarketingBackgroundImageTexture";
						Sprite sprite2 = Sprite.Create(texture2D2, new Rect(0f, 0f, texture2D2.width, texture2D2.height), new Vector2(0.5f, 0.5f), 100f, 0u, SpriteMeshType.FullRect);
						sprite = sprite2;
						sprite.name = "MarketingBackgroundImageSprite";
					}
				}
				else if (MCJHHDACJBG.CHEFIFGMHHB)
				{
					EBMLBHAGAII = false;
					StartCoroutine(BHPBLOBAKKA(MapManager.CurrentMapId));
				}
				else
				{
					sprite = OCJIMKMCCPD.OGFBMKPFHLE(MapManager.CurrentMapId);
				}
				float num = ONCMBJKLKIL.EMFKAPJMDCC / 10.24f;
				NewMapBackgroundImage.transform.localScale = Vector3.one * num;
				NewMapBackgroundImage.sprite = sprite;
				NewMapBackgroundImage.color = new Color(44f / 51f, 44f / 51f, 44f / 51f);
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.LevelBuilder, "Cannot Set Background Images. Error: {0} | Stack: {1} ", ex.Message, ex.StackTrace);
			}
			MKJBCPCNDIJ();
		}

		private IEnumerator BHPBLOBAKKA(string CHHHPCOIFJJ)
		{
			OCJIMKMCCPD oCJIMKMCCPD = OCJIMKMCCPD.CGPEONBEMMM(CHHHPCOIFJJ, "NewMapGame");
			while (!oCJIMKMCCPD.DCKHOAHIFDH)
			{
				yield return null;
			}
			NewMapBackgroundImage.sprite = oCJIMKMCCPD.BBOBCJAHPJM;
			EBMLBHAGAII = true;
		}

		private void MKJBCPCNDIJ()
		{
			GEBAAFFGKJG.GABGKBAKHDP.NPGEJMKGJON(0);
			PJPPADHKGHN.GABGKBAKHDP.EFFMBBAJLCF = 0;
			IIMOEAOONKA.IKIAIFNKFBK = KAKOONJCENE.None;
		}

		public IEnumerator Start()
		{
			if (MCJHHDACJBG.CHEFIFGMHHB)
			{
				while (!EBMLBHAGAII)
				{
					yield return null;
				}
			}
			DialogLibrary.GABGKBAKHDP.EgoDialogs[0].FLFDKMOOIFL(1);
			byte[] buffer = null;
			TextAsset textAsset = null;
			string empty = string.Empty;
			char c = '|';
			string text = string.Empty;
			if (LevelLoaderController.IsOnlineLevel)
			{
				string[] array = CurrentLevelPath.Split(c);
				if (array.Length > 1)
				{
					PKPBMFKPGFE = true;
				}
				string path = Path.Combine(Application.persistentDataPath, "onlinelevels/");
				string path2 = Path.Combine(path, array[0]);
				buffer = File.ReadAllBytes(path2);
			}
			else if (LevelLoaderController.IsOfflineLevel)
			{
				string[] array2 = CurrentLevelPath.Split(c);
				if (array2.Length > 1)
				{
					PKPBMFKPGFE = true;
				}
				text = Path.Combine(empty + Application.streamingAssetsPath, "peak/" + array2[0] + ".bin");
			}
			else
			{
				string text2 = CurrentLevelNo.ToString().PadLeft(4, '0');
				PKPBMFKPGFE = FNBPLBGNBNF.DMHOKIGLECN();
				string text3 = ((!PKPBMFKPGFE || CurrentLevelNo > 50) ? "ToonRocks" : "ToonRocksFun");
				string text4 = MJJHFBBMHAO.CJENHJMDHFN(text3 + CurrentLevelNo);
				if (DNMNOCJAPDP != null && DNMNOCJAPDP.Contains(text2))
				{
					string path2 = Path.Combine(Application.persistentDataPath, "ablevels/" + text2 + ".txt");
					buffer = File.ReadAllBytes(path2);
				}
				else
				{
					text = Path.Combine(empty + Application.streamingAssetsPath, "peak/" + text4 + ".bin");
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				WWW wWW = new WWW(text);
				while (!wWW.isDone)
				{
					yield return null;
				}
				if (!string.IsNullOrEmpty(wWW.error))
				{
					GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.LevelBuilder, "Error Loading Level File. Path:{0} Error:{1}", text, wWW.error);
					CaravanSceneManager.Load(GKBHIKONCKJ.Map);
					yield break;
				}
				buffer = wWW.bytes;
			}
			using (Stream source = new MemoryStream(buffer))
			{
				try
				{
					GGDDNIIEFFF = GJBNLEPCELA.DeserializeWithLengthPrefix(source, null, typeof(LevelMetaData), PrefixStyle.Fixed32BigEndian, 3) as LevelMetaData;
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LevelBuilder, "Loaded Level name is:{0}", GGDDNIIEFFF.Name);
				}
				catch (Exception ex)
				{
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LevelBuilder, "Can not Deserialize levels:{0} ", ex.Message);
					CaravanSceneManager.Load(GKBHIKONCKJ.Map);
				}
				finally
				{
					if (textAsset != null)
					{
						Resources.UnloadAsset(textAsset);
					}
				}
			}
			MLGPKDACMOD();
			SceneReloadedSetups();
			yield return null;
			yield return null;
			IsLevelDataLoaded = true;
			yield return Resources.UnloadUnusedAssets();
			BackgroundAssetsLoaded = true;
			yield return null;
			TapToSkipCollider.size = new Vector2(ONCMBJKLKIL.EMFKAPJMDCC, ONCMBJKLKIL.FHAMOHDEGMK);
			TapToSkipCollider.offset = new Vector2(0f, (0f - CurrentCameraSizer.HeightOfTopPanel) * CurrentCameraSizer.TopPanel.transform.localScale.x);
			Vector3 localPosition = TapToSkipText.ANLKLKAINEO.localPosition;
			int fHAMOHDEGMK = CurrentLevel.JHDMFHDHIFN.FHAMOHDEGMK;
			if (ONCMBJKLKIL.PEFHCKMBHOM && fHAMOHDEGMK == 9)
			{
				localPosition.y = -5.03f;
			}
			else if (ONCMBJKLKIL.PEFHCKMBHOM && fHAMOHDEGMK == 8)
			{
				localPosition.y = -5.44f;
			}
			else if (ONCMBJKLKIL.GGPFFOOIGHG && fHAMOHDEGMK == 9)
			{
				localPosition.y = -4.86f;
			}
			else
			{
				float x = CurrentCameraSizer.TopPanel.transform.localScale.x;
				float num = ONCMBJKLKIL.FHAMOHDEGMK * 0.5f - CurrentCameraSizer.HeightOfBottomPanel * x;
				float num2 = num - (float)fHAMOHDEGMK * 0.5f;
				localPosition.y = CurrentCameraSizer.CenterPanel.transform.localPosition.y - (num2 + (float)fHAMOHDEGMK) * 0.5f + 0.27f;
				if (ONCMBJKLKIL.GNGIGAPBFCN.HINDAIPFFJL > 0f)
				{
					localPosition.y += ONCMBJKLKIL.GNGIGAPBFCN.HINDAIPFFJL - 0.12f;
				}
			}
			TapToSkipText.ANLKLKAINEO.localPosition = localPosition;
		}

		private void NKMANNPOAGM(BIMAONBKNOP BDMFBFDKAJI)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(TutorialManagerPrefab, CellContainer);
			gameObject.transform.localPosition = Vector3.zero;
			TutorialManager component = gameObject.GetComponent<TutorialManager>();
			component.Init(this, BDMFBFDKAJI);
		}

		private void MLGPKDACMOD()
		{
			try
			{
				HNPADMPIFDA = ItemResourcesManager.GABGKBAKHDP;
				if (HNPADMPIFDA == null)
				{
					GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.LevelBuilder, "Item Resource Manger is NULL");
				}
				PFDAAAAPJED = HNPADMPIFDA.GetResources(NOALGNJECAD.SolidColor1).Prefab;
				CFPBIMCGOML = HNPADMPIFDA.GetResources(NOALGNJECAD.Rocket).Animators[0];
				AHGBGKFOEML = HNPADMPIFDA.GetResources(NOALGNJECAD.Rocket).Prefab;
				DJADHIALFMB = HNPADMPIFDA.GetResources(NOALGNJECAD.DiscoBall).Prefab;
				PLKAAPLNNMK = HNPADMPIFDA.GetResources(NOALGNJECAD.Bomb).Prefab;
				PFDAAAAPJED.FLFDKMOOIFL(165);
				CFPBIMCGOML.FLFDKMOOIFL(10);
				AHGBGKFOEML.FLFDKMOOIFL(10);
				DJADHIALFMB.FLFDKMOOIFL(2);
				PLKAAPLNNMK.FLFDKMOOIFL(10);
				LastLevel.EKGHEGKILLC = IDFPAFEJPPH.GABGKBAKHDP.HGNJBHGBLIN;
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.LevelBuilder, "SceneCreatedSetups ERROR:{0} STACK:{1}", ex.Message, ex.StackTrace);
			}
		}

		public void SceneReloadedSetups()
		{
			bool NIEHLOMGPLC = LevelLoaderController.Record != null;
			if (NIEHLOMGPLC)
			{
				ReplayManager.StopReplay();
			}
			EIAGCGNPMGO gMANJFBCGFM = HKIHHLKDLMO();
			int hJBOEOOLOOE = BFGGHJGIHLJ.DIOELAHNLKJ(gMANJFBCGFM, LevelLoaderController.RandomSeed);
			Recorder = new MLPHFMDIMLB(hJBOEOOLOOE, NIEHLOMGPLC);
			ShakeAnimation[] panelShakeAnimations = PanelShakeAnimations;
			foreach (ShakeAnimation shakeAnimation in panelShakeAnimations)
			{
				if (shakeAnimation.IsShaking)
				{
					shakeAnimation.StopShake();
				}
			}
			AudioManager.ResetExternalAudioSources();
			KCEOIKDCGGL = false;
			DidUseLife = PJPPADHKGHN.GABGKBAKHDP.MFDIAGADLNJ();
			GameplayUserId = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
			FocusListener.SetGamePlayCrash();
			ActiveLevel = null;
			CurrentLevel = null;
			BDGFEIGMLFK();
			NIMIEJNELGF();
			Transform parent = CellContainer.parent;
			Vector3 localPosition = CellContainer.transform.localPosition;
			UnityEngine.Object.Destroy(CellContainer.gameObject);
			GameObject gameObject = new GameObject();
			gameObject.name = "CellContainer";
			GameObject gameObject2 = gameObject;
			gameObject2.transform.SetParent(parent);
			gameObject2.transform.localPosition = localPosition;
			gameObject = new GameObject();
			gameObject.name = "ItemContainer";
			GameObject gameObject3 = gameObject;
			gameObject3.transform.SetParent(gameObject2.transform);
			gameObject3.transform.localPosition = Vector3.zero;
			CellContainer = gameObject2.transform;
			ItemContainer = gameObject3.transform;
			KFDEDECPNGP();
			EJHFBPIEMFA(GGDDNIIEFFF);
			GNPMNAAHLKM();
			if (CurrentLevel.NJHCINMDGKB[43] > 0 && BlasterItemCollectAnimation.IBEJCICEBIH() == 0)
			{
				BlasterItemCollectAnimation.FLFDKMOOIFL(10);
			}
			if (!JGHDHLKGJGH(CurrentLevel))
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LevelBuilder, "!! There is no match at the grid. Trying to create one");
				ICCBMHIEEPO(CurrentLevel);
			}
			GameObject gameObject4 = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.GoalsBannerDialog, false, true);
			GoalsBannerDialog component = gameObject4.GetComponent<GoalsBannerDialog>();
			KCEOIKDCGGL = false;
			StartCoroutine(DFHDBMINJHC());
			component.AfterExit(delegate
			{
				NBJJOILLPLP();
				bool nBGIEJKPDON = false;
				bool cELKBIHEFHP = CurrentLevelNo < 50 && PKPBMFKPGFE;
				BIMAONBKNOP tutorialForLevel = TutorialManager.GetTutorialForLevel(CurrentLevelNo, cELKBIHEFHP);
				if (!OBOHCGCDMIL() && tutorialForLevel != null)
				{
					NKMANNPOAGM(tutorialForLevel);
					nBGIEJKPDON = true;
				}
				if (NIEHLOMGPLC)
				{
					GamePlayRecord record = LevelLoaderController.Record;
					IFLNNILPLIG(record.p, record.c);
					ReplayManager.PlayRecord(record);
				}
				else
				{
					IKGBNGMIBCJ((tutorialForLevel != null) ? tutorialForLevel.BALIENJLCLB : null, nBGIEJKPDON);
				}
			});
			CurrentTopPanel.SceneReloadedSetups();
			CurrentTopPanel.InitStars(CurrentLevel.EMNDJNDGANP);
			TapListener.Instance.ResetCount();
			BoosterTapListener.Instance.ResetCount();
			BoosterTapListener.Instance.gameObject.SetActive(false);
			HintManager.Instance.SceneReloadedSetups();
			FallManager.Instance.SceneReloadedSetups();
			ScoreManager.Instance.SceneReloadedSetups(CurrentLevel);
			SettingsPanel.Instance.EnableBottomPanel();
			MLENMAIAOHJ.OMOKOKFNBKI();
			Recorder.PACCFEDLNAL(CurrentLevel);
			AFJPGLHKOID.EPPPDABGAFO(CurrentLevel.PDGLECFDLJJ, KDBDBMBAKEL, CurrentLevel.PNGPLGHKFDI);
		}

		private void KFDEDECPNGP()
		{
			PFDAAAAPJED.AACDKEGKCOL();
			CFPBIMCGOML.AACDKEGKCOL();
			AHGBGKFOEML.AACDKEGKCOL();
			DJADHIALFMB.AACDKEGKCOL();
			PLKAAPLNNMK.AACDKEGKCOL();
			GenericCollectItem.AACDKEGKCOL();
			if (BlasterItemCollectAnimation.EEKDOONIFLD() > 0)
			{
				BlasterItemCollectAnimation.AACDKEGKCOL();
			}
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				ItemResourcesManager.GABGKBAKHDP.RecycleAll();
			}
			PFDAAAAPJED.LAOADDPHIAE(OMCPCOGODHM);
			CFPBIMCGOML.LAOADDPHIAE(OMCPCOGODHM);
			AHGBGKFOEML.LAOADDPHIAE(OMCPCOGODHM);
			DJADHIALFMB.LAOADDPHIAE(OMCPCOGODHM);
			PLKAAPLNNMK.LAOADDPHIAE(OMCPCOGODHM);
		}

		private static void BDGFEIGMLFK()
		{
			BirdHouseItem.BirdHouseItems.Clear();
			LLJLGKECBBE.GABGKBAKHDP.KNGDPCBKCJK();
			LLJLGKECBBE.GABGKBAKHDP.LENKLFIPLIH();
			MJPAKGMNFAC.GABGKBAKHDP.FJLHDCOCLEH();
			NLMLKADGECN.GABGKBAKHDP.OMOKOKFNBKI();
			UfoController.ResetSelf();
			ChainController.ResetSelf();
			FireworksController.ResetSelf();
			IvyItem.InitSortingOrders();
			HintManager.Instance.Reset();
			LogItem.ResetSounds();
			LastLevel.KMBHLPKMOEC.OMOKOKFNBKI();
		}

		private static EIAGCGNPMGO HKIHHLKDLMO()
		{
			if (CurrentLevelNo > 1000 && CurrentLevelNo <= 2750)
			{
				return EIAGCGNPMGO.Csharp;
			}
			return EIAGCGNPMGO.PeakXorShift;
		}

		private bool OBOHCGCDMIL()
		{
			return IDFPAFEJPPH.GABGKBAKHDP.HGNJBHGBLIN || (LevelLoaderController.BLPJIDEKMMG && !TutorialManager.ForceShowTutorials);
		}

		private void NIMIEJNELGF()
		{
			if (CPFIMFEHJGJ == null)
			{
				return;
			}
			for (int i = 0; i < CPFIMFEHJGJ.Count; i++)
			{
				GameObject aGIOLFBGANM = CPFIMFEHJGJ[i];
				List<GameObject> list = aGIOLFBGANM.IMJFPFCFEMD();
				for (int j = 0; j < list.Count; j++)
				{
					CellItem component = list[j].GetComponent<CellItem>();
					if (component != null)
					{
						component.DoRecycle();
					}
				}
			}
		}

		private void OMCPCOGODHM(GameObject NEMEKIOEOLC)
		{
			Item component = NEMEKIOEOLC.GetComponent<Item>();
			try
			{
				component.OnBeforeRemove();
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.LevelBuilder, "Preparing items on reload failed. {0}", ex.Message);
			}
			component.gameObject.transform.SetParent(ItemContainer);
			component.OnBeforeNewLevel();
		}

		private void EJHFBPIEMFA(LevelMetaData LABOAPPCOCK)
		{
			GoalCountDict = new Dictionary<NOALGNJECAD, int>();
			for (int i = 0; i < GGDDNIIEFFF.GoalList.Count; i++)
			{
				GoalMetaData goalMetaData = LABOAPPCOCK.GoalList[i];
				NOALGNJECAD key = OGIFMLFEAEM.GFIJHHFKCAJ(goalMetaData.Name.ToLowerInvariant());
				GoalCountDict.Add(key, goalMetaData.Count);
			}
		}

		private IEnumerator DFHDBMINJHC()
		{
			yield return new WaitForSeconds(0.92f);
			yield return new WaitForSeconds(2.95f);
			NBJJOILLPLP();
		}

		private void NBJJOILLPLP()
		{
			if (!KCEOIKDCGGL)
			{
				KCEOIKDCGGL = true;
				AudioManager.IncreaseSongCounter();
				AudioManager.PlaySong();
			}
		}

		private void GNPMNAAHLKM()
		{
			Dictionary<FCPPDOMBLHL, HICNCEMBCBG> dictionary = ALMCNBDKKHH(GGDDNIIEFFF);
			int num = GGDDNIIEFFF.MoveCount;
			if (!LevelLoaderController.BLPJIDEKMMG && LastLevel.EKGHEGKILLC)
			{
				num += IDFPAFEJPPH.GABGKBAKHDP.BFBNJLMHPFA;
			}
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LevelBuilder, "Starting LevelName:{0} LevelNo:{1} MoveCount:{2} CL:{3}", GGDDNIIEFFF.Name, CurrentLevelNo, num, LastLevel.EKGHEGKILLC);
			KFCEILFGADG kFCEILFGADG = new KFCEILFGADG();
			kFCEILFGADG.PDGLECFDLJJ = CurrentLevelNo;
			kFCEILFGADG.DCJNBADOLGD = dictionary;
			kFCEILFGADG.KOJNPMCHBAE = num;
			kFCEILFGADG.HJCPDOGONIG = GGDDNIIEFFF.MoveCount;
			kFCEILFGADG.EMNDJNDGANP = GGDDNIIEFFF.Stars.ToArray();
			kFCEILFGADG.PNGPLGHKFDI = GGDDNIIEFFF.Name;
			kFCEILFGADG.GIMBEKBFKMJ = this;
			kFCEILFGADG.BJEPPNGPMKO = CurrentTopPanel;
			KFCEILFGADG kFCEILFGADG2 = kFCEILFGADG;
			int num2 = int.Parse(kFCEILFGADG2.PNGPLGHKFDI.Split('_')[0]);
			if (CurrentLevelNo != num2)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.LevelBuilder, "Proto Level is:{0} Current Level is:{1}. Possible Level Hack!", num2, CurrentLevelNo);
				AFJPGLHKOID.CPIGOAGGLBM("RenderType", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, 2, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString());
			}
			CurrentLevel = kFCEILFGADG2;
			ActiveLevel = CurrentLevel;
			NIGFCEFLHML nIGFCEFLHML = MADFPPJCOIM.GABGKBAKHDP.ACDBBJACJOE(CurrentLevelNo);
			CurrentLevel.LJLIBGMBIGC = nIGFCEFLHML != null && nIGFCEFLHML.DJADMBLKBKJ > 0;
			kFCEILFGADG2.JHDMFHDHIFN = NPHFDPHMEHB(GGDDNIIEFFF.Width, GGDDNIIEFFF.Height, dictionary);
			kFCEILFGADG2.JHDMFHDHIFN.ELFBOKDHKGG = kFCEILFGADG2;
			kFCEILFGADG2.JHDMFHDHIFN.NCHIPIJGIKB = PKPBMFKPGFE && CurrentLevelNo <= 10;
			if (CurrentHintManager != null)
			{
				CurrentHintManager.ShouldCheckComboTutorial = PKPBMFKPGFE && CurrentLevelNo <= 10;
			}
			KEFMJJAJAPB = new Dictionary<int, Cell>();
			foreach (Cell item3 in kFCEILFGADG2.JHDMFHDHIFN.IOFOFDLJDAA())
			{
				Cell cell = kFCEILFGADG2.JHDMFHDHIFN.PHOOMEOBJCB(item3, IEKBFJBLGFM.Up);
				if (cell == null || !cell.Exists)
				{
					if (KEFMJJAJAPB.ContainsKey(item3.X))
					{
						if (KEFMJJAJAPB[item3.X].Y < item3.Y)
						{
							KEFMJJAJAPB[item3.X] = item3;
						}
					}
					else
					{
						KEFMJJAJAPB[item3.X] = item3;
					}
				}
				item3.FirstExistingBottomCell = KNKKDPJFBGI(item3);
				if (item3.Y > 0)
				{
					Cell cell2 = item3.CurrentGrid.ECNCPJGHBIG(item3.X, item3.Y - 1);
					if (cell2.Exists)
					{
						item3.JustBelowCell = cell2;
					}
				}
				if (item3.Y + 1 < item3.CurrentGrid.FHAMOHDEGMK)
				{
					Cell cell3 = item3.CurrentGrid.ECNCPJGHBIG(item3.X, item3.Y + 1);
					if (cell3.Exists)
					{
						item3.JustAboveCell = cell3;
					}
				}
				item3.IsFloor = item3.FirstExistingBottomCell == null;
				if (!item3.EAILOFHFNJO)
				{
					continue;
				}
				Cell justBelowCell = item3.JustBelowCell;
				if (justBelowCell == null || !justBelowCell.EAILOFHFNJO)
				{
					if (item3.LBFCDKPCDPB.CanCastShadow())
					{
						item3.LBFCDKPCDPB.GetShadowCaster().HideShadow();
					}
				}
				else if (item3.LBFCDKPCDPB.CanCastShadow())
				{
					if (justBelowCell.LBFCDKPCDPB.CanShadowDrop())
					{
						item3.LBFCDKPCDPB.GetShadowCaster().CastShadow();
					}
					else
					{
						item3.LBFCDKPCDPB.GetShadowCaster().HideShadow();
					}
				}
			}
			int num3 = 0;
			foreach (Cell item4 in kFCEILFGADG2.JHDMFHDHIFN.ECNKPIEGILI())
			{
				item4.FreezePosition();
				if (!item4.Exists || !item4.EAILOFHFNJO)
				{
					continue;
				}
				GKFOADDKNHO(item4);
				GeneratorBasedItem generatorBasedItem = item4.LBFCDKPCDPB as GeneratorBasedItem;
				if (generatorBasedItem != null && generatorBasedItem.GenerateItemType != 0)
				{
					ItemResourcesManager.GABGKBAKHDP.InitItem(generatorBasedItem.GenerateItemType);
				}
				FishItem fishItem = item4.LBFCDKPCDPB as FishItem;
				if (fishItem != null)
				{
					ItemResourcesManager.GABGKBAKHDP.InitItem(NOALGNJECAD.Bubble);
				}
				if (num3 >= 60 || item4.LBFCDKPCDPB.GetItemType() != NOALGNJECAD.Pot)
				{
					continue;
				}
				Cell[] cachedNeigbours = item4.GetCachedNeigbours(true);
				for (int i = 0; i < cachedNeigbours.Length + 1; i++)
				{
					if (num3 >= 60)
					{
						break;
					}
					num3++;
				}
			}
			if (num3 > 0)
			{
				FJCDDBHKBGP(NOALGNJECAD.Ivy, num3);
				OJKFBMGJJKD(NOALGNJECAD.Ivy, (num3 + 1) / 2);
				OJKFBMGJJKD(NOALGNJECAD.Pot, 18);
			}
			int num4 = 0;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			foreach (GoalMetaData goal in GGDDNIIEFFF.GoalList)
			{
				OGIFMLFEAEM oGIFMLFEAEM = new OGIFMLFEAEM(goal.Name, goal.Count);
				if (oGIFMLFEAEM.ENBPGGCIADN != 0)
				{
					kFCEILFGADG2.JKKJLDLMIOG.Add(oGIFMLFEAEM);
				}
				if (oGIFMLFEAEM.ENBPGGCIADN == NOALGNJECAD.Bubble)
				{
					flag = true;
				}
				if (oGIFMLFEAEM.ENBPGGCIADN == NOALGNJECAD.Soap || oGIFMLFEAEM.ENBPGGCIADN == NOALGNJECAD.Washer)
				{
					flag2 = true;
				}
				if (oGIFMLFEAEM.ENBPGGCIADN == NOALGNJECAD.Ivy)
				{
					flag4 = true;
				}
				if (oGIFMLFEAEM.ENBPGGCIADN == NOALGNJECAD.Pot)
				{
					flag3 = true;
				}
				if (oGIFMLFEAEM.ENBPGGCIADN == NOALGNJECAD.SolidColor1 || oGIFMLFEAEM.ENBPGGCIADN == NOALGNJECAD.SolidColor2 || oGIFMLFEAEM.ENBPGGCIADN == NOALGNJECAD.SolidColor3 || oGIFMLFEAEM.ENBPGGCIADN == NOALGNJECAD.SolidColor4 || oGIFMLFEAEM.ENBPGGCIADN == NOALGNJECAD.SolidColor5 || oGIFMLFEAEM.ENBPGGCIADN == NOALGNJECAD.Diamond || oGIFMLFEAEM.ENBPGGCIADN == NOALGNJECAD.Duck || oGIFMLFEAEM.ENBPGGCIADN == NOALGNJECAD.Carrot)
				{
					num4 += oGIFMLFEAEM.GMCGMPEEHJP;
				}
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LevelBuilder, "Goal Added: {0}", oGIFMLFEAEM);
			}
			GenericCollectItem.FLFDKMOOIFL((num4 <= 60) ? num4 : 60);
			if (!flag && flag2)
			{
				OGIFMLFEAEM item = new OGIFMLFEAEM("bubblegoal", 0);
				kFCEILFGADG2.JKKJLDLMIOG.Add(item);
			}
			if (!flag4 && flag3)
			{
				OGIFMLFEAEM item2 = new OGIFMLFEAEM("ivygoal", 0);
				kFCEILFGADG2.JKKJLDLMIOG.Add(item2);
			}
			kFCEILFGADG2.JKKJLDLMIOG.Sort((OGIFMLFEAEM AMFCENFNAJJ, OGIFMLFEAEM CNLILOEEBOJ) => (AMFCENFNAJJ.BHIJCAOHDCM >= CNLILOEEBOJ.BHIJCAOHDCM) ? 1 : (-1));
			DCDPMCIAFGM(kFCEILFGADG2, KEFMJJAJAPB);
		}

		private static void GKFOADDKNHO(Cell LBHDELJBONF)
		{
			BillboardItem billboardItem = LBHDELJBONF.LBFCDKPCDPB as BillboardItem;
			if (billboardItem != null && billboardItem.MasterItem == null)
			{
				billboardItem.LinkNeighbours(LBHDELJBONF);
			}
			StoneItem stoneItem = LBHDELJBONF.LBFCDKPCDPB as StoneItem;
			if (stoneItem != null && stoneItem.MasterItem == null)
			{
				stoneItem.LinkNeighbours(LBHDELJBONF);
			}
			WallItem wallItem = LBHDELJBONF.LBFCDKPCDPB as WallItem;
			if (wallItem != null && wallItem.MasterItem == null)
			{
				wallItem.LinkNeighbours(LBHDELJBONF);
			}
			LogItem logItem = LBHDELJBONF.LBFCDKPCDPB as LogItem;
			if (logItem != null)
			{
				logItem.LinkNeighbours();
			}
		}

		private void FJCDDBHKBGP(NOALGNJECAD HBBIFNLDKPO, int PECIDFMIPIN)
		{
			HNPADMPIFDA.InitItem(HBBIFNLDKPO);
			GameObject prefab = HNPADMPIFDA.GetResources(HBBIFNLDKPO).Prefab;
			prefab.FLFDKMOOIFL(PECIDFMIPIN);
			if (CPFIMFEHJGJ == null)
			{
				CPFIMFEHJGJ = new List<GameObject> { prefab };
			}
			else if (!CPFIMFEHJGJ.Contains(prefab))
			{
				CPFIMFEHJGJ.Add(prefab);
			}
		}

		private void OJKFBMGJJKD(NOALGNJECAD HBBIFNLDKPO, int PECIDFMIPIN)
		{
			HNPADMPIFDA.InitItem(HBBIFNLDKPO);
			GameObject[] animators = HNPADMPIFDA.GetResources(HBBIFNLDKPO).Animators;
			for (int i = 0; i < animators.Length; i++)
			{
				animators[i].FLFDKMOOIFL(PECIDFMIPIN);
			}
		}

		private void ICCBMHIEEPO(KFCEILFGADG GIOFHACJEGA)
		{
			int eMFKAPJMDCC = GIOFHACJEGA.JHDMFHDHIFN.EMFKAPJMDCC;
			int fHAMOHDEGMK = GIOFHACJEGA.JHDMFHDHIFN.FHAMOHDEGMK;
			int height = GGDDNIIEFFF.Height;
			for (int i = 0; i < eMFKAPJMDCC; i++)
			{
				for (int j = 0; j < fHAMOHDEGMK; j++)
				{
					Cell cell = GIOFHACJEGA.JHDMFHDHIFN.ECNCPJGHBIG(i, j);
					if (!cell.Exists || !cell.EAILOFHFNJO || cell.HasCellItem())
					{
						continue;
					}
					NOALGNJECAD itemType = cell.LBFCDKPCDPB.GetItemType();
					if (itemType == NOALGNJECAD.SolidColor1 || itemType == NOALGNJECAD.SolidColor2 || itemType == NOALGNJECAD.SolidColor3 || itemType == NOALGNJECAD.SolidColor4 || itemType == NOALGNJECAD.SolidColor5 || itemType == NOALGNJECAD.SolidColor6)
					{
						CellMetaData cellMetaData = GGDDNIIEFFF.CellList[JDPJOPDFEMJ(i, j, eMFKAPJMDCC, height)];
						FCPPDOMBLHL fCPPDOMBLHL = ((ALIFCLNJKPH)cellMetaData.TiledObject.Id).HMMIDIGLBLM();
						if (fCPPDOMBLHL != 0 && ((i + 1 < eMFKAPJMDCC && GFGBDFCPBFM(GIOFHACJEGA, fCPPDOMBLHL, itemType, i + 1, j, eMFKAPJMDCC, height)) || (j + 1 < fHAMOHDEGMK && GFGBDFCPBFM(GIOFHACJEGA, fCPPDOMBLHL, itemType, i, j + 1, eMFKAPJMDCC, height))))
						{
							return;
						}
					}
				}
			}
		}

		private bool GFGBDFCPBFM(KFCEILFGADG GIOFHACJEGA, FCPPDOMBLHL KEKPBEKCPNN, NOALGNJECAD HBBIFNLDKPO, int AMFCENFNAJJ, int CNLILOEEBOJ, int PHFLBLJJMLI, int GPJDJCGDJDC)
		{
			CellMetaData cellMetaData = GGDDNIIEFFF.CellList[JDPJOPDFEMJ(AMFCENFNAJJ, CNLILOEEBOJ, PHFLBLJJMLI, GPJDJCGDJDC)];
			FCPPDOMBLHL fCPPDOMBLHL = ((ALIFCLNJKPH)cellMetaData.TiledObject.Id).HMMIDIGLBLM();
			if (fCPPDOMBLHL != KEKPBEKCPNN)
			{
				return false;
			}
			Cell cell = GIOFHACJEGA.JHDMFHDHIFN.ECNCPJGHBIG(AMFCENFNAJJ, CNLILOEEBOJ);
			if (!cell.Exists || !cell.EAILOFHFNJO || cell.HasCellItem())
			{
				return false;
			}
			cell.LBFCDKPCDPB.RemoveSelf();
			cell.LBFCDKPCDPB = CreateItem(new DNJKLNPHPOF(HBBIFNLDKPO));
			cell.LBFCDKPCDPB.transform.position = cell.GetFrozenPosition();
			return true;
		}

		private static bool JGHDHLKGJGH(KFCEILFGADG GIOFHACJEGA)
		{
			List<PBLOIKDOPAJ> list = new List<PBLOIKDOPAJ>(100);
			GIOFHACJEGA.JHDMFHDHIFN.DGINICFFFFP(list);
			int count = list.Count;
			for (int i = 0; i < count; i++)
			{
				PBLOIKDOPAJ pBLOIKDOPAJ = list[i];
				if (pBLOIKDOPAJ.IJILFJHCFKM && pBLOIKDOPAJ.BFCMNIPBDIE.EAILOFHFNJO && !pBLOIKDOPAJ.BFCMNIPBDIE.LBFCDKPCDPB.IsSpecialItem())
				{
					return true;
				}
			}
			return false;
		}

		private static Dictionary<FCPPDOMBLHL, HICNCEMBCBG> ALMCNBDKKHH(LevelMetaData BCLCEPDGCJI)
		{
			Dictionary<FCPPDOMBLHL, HICNCEMBCBG> dictionary = new Dictionary<FCPPDOMBLHL, HICNCEMBCBG>(new HGCPOFLPLJC());
			if (BCLCEPDGCJI == null || BCLCEPDGCJI.GroupList == null)
			{
				return dictionary;
			}
			for (int i = 0; i < BCLCEPDGCJI.GroupList.Count; i++)
			{
				FCPPDOMBLHL fCPPDOMBLHL = BCLCEPDGCJI.GroupList[i].Name.HMMIDIGLBLM();
				dictionary[fCPPDOMBLHL] = new HICNCEMBCBG(BCLCEPDGCJI.GroupList[i], fCPPDOMBLHL);
			}
			return dictionary;
		}

		private void ECELMIELDDI()
		{
			if (KCIONBHDHEO == null)
			{
				return;
			}
			foreach (KeyValuePair<NOALGNJECAD, List<Item>> item2 in KCIONBHDHEO)
			{
				if (item2.Value.Count == 0)
				{
					continue;
				}
				for (int i = 0; i < item2.Value.Count; i++)
				{
					Item item = item2.Value[i];
					if (!(item == null))
					{
						UnityEngine.Object.Destroy(item.gameObject);
					}
				}
			}
			KCIONBHDHEO.Clear();
		}

		private Item FHAKPMPDKJH(NOALGNJECAD HBBIFNLDKPO)
		{
			if (KCIONBHDHEO == null || !KCIONBHDHEO.ContainsKey(HBBIFNLDKPO))
			{
				return null;
			}
			int count = KCIONBHDHEO[HBBIFNLDKPO].Count;
			if (count > 0)
			{
				Item result = KCIONBHDHEO[HBBIFNLDKPO][count - 1];
				KCIONBHDHEO[HBBIFNLDKPO].RemoveAt(count - 1);
				if (KCIONBHDHEO[HBBIFNLDKPO].Count == 0)
				{
					KCIONBHDHEO.Remove(HBBIFNLDKPO);
				}
				return result;
			}
			return null;
		}

		private CFOIPDKEFMM NPHFDPHMEHB(int HHHMOGOKFHF, int JKNPBEOPMPK, Dictionary<FCPPDOMBLHL, HICNCEMBCBG> MMJECNJJJDO)
		{
			FLANIJLBDMP = false;
			int num = JKNPBEOPMPK;
			for (int i = 0; i < JKNPBEOPMPK; i++)
			{
				CellMetaData cellMetaData = GGDDNIIEFFF.CellList[JDPJOPDFEMJ(0, i, HHHMOGOKFHF, JKNPBEOPMPK)];
				if (cellMetaData != null && cellMetaData.TiledObject.Id == 10)
				{
					FLANIJLBDMP = true;
					JKNPBEOPMPK = i;
					break;
				}
			}
			if (FLANIJLBDMP)
			{
				ECELMIELDDI();
				if (KCIONBHDHEO == null)
				{
					KCIONBHDHEO = new Dictionary<NOALGNJECAD, List<Item>>();
				}
				Dictionary<int, Queue<DNJKLNPHPOF>> dictionary = new Dictionary<int, Queue<DNJKLNPHPOF>>();
				for (int j = 0; j < HHHMOGOKFHF; j++)
				{
					dictionary[j] = new Queue<DNJKLNPHPOF>();
					for (int k = JKNPBEOPMPK + 1; k < num; k++)
					{
						CellMetaData cellMetaData2 = GGDDNIIEFFF.CellList[JDPJOPDFEMJ(j, k, HHHMOGOKFHF, num)];
						ALIFCLNJKPH aLIFCLNJKPH = (ALIFCLNJKPH)cellMetaData2.TiledObject.Id;
						FCPPDOMBLHL fCPPDOMBLHL = aLIFCLNJKPH.HMMIDIGLBLM();
						if (fCPPDOMBLHL != 0 && MMJECNJJJDO.ContainsKey(fCPPDOMBLHL))
						{
							aLIFCLNJKPH = (ALIFCLNJKPH)MMJECNJJJDO[fCPPDOMBLHL].PDNDANPPGMK();
						}
						NOALGNJECAD nOALGNJECAD = aLIFCLNJKPH.AMLEHGPGGIC();
						if (nOALGNJECAD != 0)
						{
							DNJKLNPHPOF item = new DNJKLNPHPOF(nOALGNJECAD, aLIFCLNJKPH, new DLKLKMDJOOJ(cellMetaData2.TiledObject.Properties), fCPPDOMBLHL);
							dictionary[j].Enqueue(item);
							if (!nOALGNJECAD.EBAJIHOCKGM() && !nOALGNJECAD.MCMDJCBFENO())
							{
								JNMMNHOOAJA(item.OCHKLAKCFJC);
							}
						}
					}
				}
				CurrentLevel.DJPJLDLJPBD(dictionary);
			}
			Cell[,] array = new Cell[HHHMOGOKFHF, JKNPBEOPMPK];
			for (int l = 0; l < HHHMOGOKFHF; l++)
			{
				for (int m = 0; m < JKNPBEOPMPK; m++)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate(CellPrefab);
					if (!(gameObject == null))
					{
						gameObject.transform.SetParent(CellContainer);
						gameObject.transform.localPosition = new Vector3(l, m, 0f);
						Cell component = gameObject.GetComponent<Cell>();
						component.X = l;
						component.Y = m;
						component.gameObject.name = string.Format("Cell_X{0}_Y{1}", l, m);
						CellMetaData iJONIHMEGBD = GGDDNIIEFFF.CellList[JDPJOPDFEMJ(l, m, HHHMOGOKFHF, num)];
						KGEGKEINGPA(component, iJONIHMEGBD);
						array[l, m] = component;
					}
				}
			}
			CFOIPDKEFMM cFOIPDKEFMM = new CFOIPDKEFMM(array);
			for (int n = 0; n < HHHMOGOKFHF; n++)
			{
				for (int num2 = 0; num2 < JKNPBEOPMPK; num2++)
				{
					Cell cell = cFOIPDKEFMM.ECNCPJGHBIG(n, num2);
					cell.CurrentGrid = cFOIPDKEFMM;
					cell.OnCellGridChange(cFOIPDKEFMM);
					CellMetaData cellMetaData3 = GGDDNIIEFFF.CellList[JDPJOPDFEMJ(n, num2, HHHMOGOKFHF, num)];
					KIBCLGLABCB kIBCLGLABCB = new KIBCLGLABCB();
					kIBCLGLABCB.BACBOALBHEA = cellMetaData3.TiledObject.Id;
					KIBCLGLABCB iJONIHMEGBD2 = kIBCLGLABCB;
					List<MapFieldEntry> properties = cellMetaData3.TiledObject.Properties;
					MIEKCKDNALC(cell, iJONIHMEGBD2, MMJECNJJJDO, properties);
				}
			}
			LLJLGKECBBE.GABGKBAKHDP.KCDFMMEGJMB(cFOIPDKEFMM);
			MJPAKGMNFAC.GABGKBAKHDP.KCDFMMEGJMB(cFOIPDKEFMM);
			new IGNOFJEBDOM(cFOIPDKEFMM, BorderImages).HOEJFJPHGDO();
			CellContainer.localPosition = new Vector3((float)(-cFOIPDKEFMM.EMFKAPJMDCC) / 2f + 0.5f, (float)(-cFOIPDKEFMM.FHAMOHDEGMK) / 2f + 0.5f, 0f);
			return cFOIPDKEFMM;
		}

		private void JNMMNHOOAJA(NOALGNJECAD HBBIFNLDKPO)
		{
			if (!KCIONBHDHEO.ContainsKey(HBBIFNLDKPO))
			{
				KCIONBHDHEO.Add(HBBIFNLDKPO, new List<Item>());
			}
			GameObject gameObject = UnityEngine.Object.Instantiate(HNPADMPIFDA.GetResources(HBBIFNLDKPO).Prefab, Vector3.zero, Quaternion.identity, ItemContainer.transform);
			gameObject.transform.position = new Vector3(100f, 100f, 0f);
			gameObject.gameObject.SetActive(false);
			KCIONBHDHEO[HBBIFNLDKPO].Add(gameObject.GetComponent<Item>());
		}

		private static void DCDPMCIAFGM(KFCEILFGADG GIOFHACJEGA, Dictionary<int, Cell> ACMEAKKIJJI)
		{
			if (ACMEAKKIJJI != null && ACMEAKKIJJI.Count > 0 && GIOFHACJEGA.DCJNBADOLGD != null && GIOFHACJEGA.DCJNBADOLGD.Count > 0)
			{
				foreach (KeyValuePair<FCPPDOMBLHL, HICNCEMBCBG> item in GIOFHACJEGA.DCJNBADOLGD)
				{
					FCPPDOMBLHL key = item.Key;
					HICNCEMBCBG value = item.Value;
					if (value.FBMKCAPINBJ)
					{
						value.LKGFHCJKIPE(GIOFHACJEGA);
						if (value.COMOHDMIFJN && !GIOFHACJEGA.CIPIEIHKJHN)
						{
							GIOFHACJEGA.CIPIEIHKJHN = true;
						}
						bool flag = value.DBLFDGPOLNG.Count == 0;
						foreach (Cell value2 in ACMEAKKIJJI.Values)
						{
							value2.IsFilling = true;
							bool flag2 = false;
							if (flag)
							{
								flag2 = true;
							}
							else
							{
								for (int i = 0; i < value.DBLFDGPOLNG.Count; i++)
								{
									int num = value.DBLFDGPOLNG[i];
									if (num == value2.X)
									{
										flag2 = true;
									}
								}
							}
							if (flag2)
							{
								if (value.COMOHDMIFJN)
								{
									value2.AddIntervalGroupId(key);
								}
								else
								{
									value2.AddFillGroupId(key, value.NOKHLKEMOCF);
								}
							}
						}
					}
				}
				return;
			}
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.LevelBuilder, "Cannot update fill layers!");
		}

		private void MIEKCKDNALC(Cell LBHDELJBONF, KIBCLGLABCB IJONIHMEGBD, Dictionary<FCPPDOMBLHL, HICNCEMBCBG> MMJECNJJJDO, List<MapFieldEntry> GBBCHGMFNFH = null)
		{
			FCPPDOMBLHL fCPPDOMBLHL = ((ALIFCLNJKPH)IJONIHMEGBD.BACBOALBHEA).HMMIDIGLBLM();
			if (fCPPDOMBLHL != 0 && MMJECNJJJDO.ContainsKey(fCPPDOMBLHL))
			{
				IJONIHMEGBD.BACBOALBHEA = MMJECNJJJDO[fCPPDOMBLHL].PDNDANPPGMK();
				IJONIHMEGBD.INFAGKCBEHL = fCPPDOMBLHL;
			}
			if (!LBHDELJBONF.Exists)
			{
				return;
			}
			Item item = null;
			if (IJONIHMEGBD.BACBOALBHEA == 9)
			{
				item = MIJOANINOGO(IJONIHMEGBD, GBBCHGMFNFH);
				if (item == null)
				{
					return;
				}
			}
			if (item == null)
			{
				item = CreateItemFromMetaData(IJONIHMEGBD, GBBCHGMFNFH);
			}
			if (!(item == null))
			{
				LBHDELJBONF.LBFCDKPCDPB = item;
				item.transform.position = LBHDELJBONF.transform.position;
			}
		}

		private Item MIJOANINOGO(KIBCLGLABCB IDBCMADOBPF, List<MapFieldEntry> GKCPHEMMHNA)
		{
			Item result = null;
			ALIFCLNJKPH bACBOALBHEA = (ALIFCLNJKPH)IDBCMADOBPF.BACBOALBHEA;
			DNJKLNPHPOF dNJKLNPHPOF = new DNJKLNPHPOF(bACBOALBHEA.AMLEHGPGGIC(), bACBOALBHEA, new DLKLKMDJOOJ(GKCPHEMMHNA), IDBCMADOBPF.INFAGKCBEHL);
			if (dNJKLNPHPOF.GBBCHGMFNFH.AOMJLDBPDKP == null)
			{
				return result;
			}
			NOALGNJECAD hBBIFNLDKPO = NOALGNJECAD.Wall;
			DLKLKMDJOOJ gKCPHEMMHNA = dNJKLNPHPOF.GBBCHGMFNFH;
			result = (WallItem)FDKCHCMPDOG(new DNJKLNPHPOF(hBBIFNLDKPO, ALIFCLNJKPH.None, gKCPHEMMHNA));
			result.AfterPoolInit();
			result.OnItemCreated(CurrentLevel);
			return result;
		}

		private void KGEGKEINGPA(Cell LBHDELJBONF, CellMetaData IJONIHMEGBD)
		{
			if (IJONIHMEGBD.BubbleCount > 0)
			{
				LBHDELJBONF.AddBubble();
			}
			if (IJONIHMEGBD.CellItemId > 0)
			{
				LBHDELJBONF.AddCellItem(IJONIHMEGBD.CellItemId, CurrentLevel);
			}
			LBHDELJBONF.Exists = IJONIHMEGBD.TiledObject.Id != 0;
			if (LBHDELJBONF.Exists)
			{
				LBHDELJBONF.Collider.enabled = true;
			}
		}

		private static int JDPJOPDFEMJ(int AMFCENFNAJJ, int CNLILOEEBOJ, int PHFLBLJJMLI, int GPJDJCGDJDC)
		{
			return AMFCENFNAJJ + (GPJDJCGDJDC - 1 - CNLILOEEBOJ) * PHFLBLJJMLI;
		}

		public Item CreateItemFromItemGroupEntry(DNJKLNPHPOF NBHMBPFKCMI)
		{
			return CreateItem(NBHMBPFKCMI);
		}

		public Item CreateItemFromMetaData(KIBCLGLABCB IDBCMADOBPF, List<MapFieldEntry> GKCPHEMMHNA = null)
		{
			ALIFCLNJKPH bACBOALBHEA = (ALIFCLNJKPH)IDBCMADOBPF.BACBOALBHEA;
			DNJKLNPHPOF nBHMBPFKCMI = new DNJKLNPHPOF(bACBOALBHEA.AMLEHGPGGIC(), bACBOALBHEA, new DLKLKMDJOOJ(GKCPHEMMHNA), IDBCMADOBPF.INFAGKCBEHL);
			return CreateItem(nBHMBPFKCMI, false);
		}

		public Item CreateItem(DNJKLNPHPOF NBHMBPFKCMI, bool IAHNHLDDJCO = true)
		{
			Item item = FDKCHCMPDOG(NBHMBPFKCMI, IAHNHLDDJCO);
			if (item == null)
			{
				return item;
			}
			item.AfterPoolInit();
			item.OnItemCreated(CurrentLevel);
			if (NBHMBPFKCMI.GBBCHGMFNFH == null)
			{
				return item;
			}
			if (NBHMBPFKCMI.GBBCHGMFNFH.KAMLOHKHBNK)
			{
				CageItem cageItem = (CageItem)FDKCHCMPDOG(new DNJKLNPHPOF(NOALGNJECAD.Cage));
				cageItem.AFAIKIMJLBP = item;
				cageItem.AfterPoolInit();
				cageItem.OnItemCreated(CurrentLevel);
				item.gameObject.transform.SetParent(cageItem.RelativeContainer.transform);
				item.gameObject.transform.localPosition = Vector3.zero;
				item = cageItem;
			}
			if (NBHMBPFKCMI.GBBCHGMFNFH.AOMJLDBPDKP != null)
			{
				NOALGNJECAD hBBIFNLDKPO = NOALGNJECAD.Wall;
				DLKLKMDJOOJ gKCPHEMMHNA = NBHMBPFKCMI.GBBCHGMFNFH;
				WallItem wallItem = (WallItem)FDKCHCMPDOG(new DNJKLNPHPOF(hBBIFNLDKPO, ALIFCLNJKPH.None, gKCPHEMMHNA));
				wallItem.AFAIKIMJLBP = item;
				wallItem.AfterPoolInit();
				wallItem.OnItemCreated(CurrentLevel);
				item.gameObject.transform.SetParent(wallItem.RelativeContainer.transform);
				item.gameObject.transform.localPosition = Vector3.zero;
				item = wallItem;
			}
			return item;
		}

		public bool CreateItemAtCell(NOALGNJECAD HBBIFNLDKPO, Cell LBHDELJBONF)
		{
			DNJKLNPHPOF nBHMBPFKCMI = new DNJKLNPHPOF(HBBIFNLDKPO);
			Item item = FDKCHCMPDOG(nBHMBPFKCMI);
			if (item == null)
			{
				return false;
			}
			item.AfterPoolInit();
			item.OnItemCreated(CurrentLevel);
			LBHDELJBONF.LBFCDKPCDPB = item;
			item.transform.position = LBHDELJBONF.transform.position;
			return true;
		}

		private Item HJGDKKDFNLL(Cell LBHDELJBONF, NOALGNJECAD HBBIFNLDKPO, ALIFCLNJKPH LNBEKJLGPAC, MDMICLOPLPC DJDKLOJBJCO)
		{
			Item item = null;
			DNJKLNPHPOF nBHMBPFKCMI;
			switch (HBBIFNLDKPO)
			{
			case NOALGNJECAD.Blaster:
				nBHMBPFKCMI = new DNJKLNPHPOF(HBBIFNLDKPO, LNBEKJLGPAC, IGHPOPEIGFM(LBHDELJBONF));
				break;
			case NOALGNJECAD.Wall:
			{
				ALIFCLNJKPH aLIFCLNJKPH2 = (ALIFCLNJKPH)DJDKLOJBJCO.PENAHNOJCGF(true);
				if (aLIFCLNJKPH2 == ALIFCLNJKPH.None || aLIFCLNJKPH2 == ALIFCLNJKPH.Empty)
				{
					CellMetaData cellMetaData = GLLGGHMEIPA(LBHDELJBONF);
					item = MIJOANINOGO(new KIBCLGLABCB
					{
						BACBOALBHEA = 9
					}, cellMetaData.TiledObject.Properties);
				}
				nBHMBPFKCMI = new DNJKLNPHPOF(aLIFCLNJKPH2.AMLEHGPGGIC(), aLIFCLNJKPH2, IGHPOPEIGFM(LBHDELJBONF));
				break;
			}
			case NOALGNJECAD.Cage:
			{
				ALIFCLNJKPH aLIFCLNJKPH = (ALIFCLNJKPH)DJDKLOJBJCO.PENAHNOJCGF(true);
				nBHMBPFKCMI = new DNJKLNPHPOF(aLIFCLNJKPH.AMLEHGPGGIC(), aLIFCLNJKPH, IGHPOPEIGFM(LBHDELJBONF));
				break;
			}
			case NOALGNJECAD.Barrel:
			{
				FCPPDOMBLHL kEKPBEKCPNN = FCPPDOMBLHL.Group9;
				nBHMBPFKCMI = new DNJKLNPHPOF(HBBIFNLDKPO, LNBEKJLGPAC, null, kEKPBEKCPNN);
				break;
			}
			default:
				nBHMBPFKCMI = new DNJKLNPHPOF(HBBIFNLDKPO, LNBEKJLGPAC);
				break;
			}
			if (item == null)
			{
				item = CreateItem(nBHMBPFKCMI);
			}
			item.ENCFFNKONOO = LBHDELJBONF;
			item.transform.position = LBHDELJBONF.GetFrozenPosition();
			LBHDELJBONF.ApplyShadowIfPossible();
			return item;
		}

		private Item FDKCHCMPDOG(DNJKLNPHPOF NBHMBPFKCMI, bool IAHNHLDDJCO = true)
		{
			GameObject gameObject = null;
			bool flag = true;
			switch (NBHMBPFKCMI.OCHKLAKCFJC)
			{
			case NOALGNJECAD.Bomb:
			case NOALGNJECAD.Rocket:
			case NOALGNJECAD.DiscoBall:
			case NOALGNJECAD.SolidColor1:
			case NOALGNJECAD.SolidColor2:
			case NOALGNJECAD.SolidColor3:
			case NOALGNJECAD.SolidColor4:
			case NOALGNJECAD.SolidColor5:
			case NOALGNJECAD.SolidColor6:
				flag = false;
				break;
			}
			bool flag2 = true;
			if (flag)
			{
				if (FLANIJLBDMP && IAHNHLDDJCO)
				{
					Item item = FHAKPMPDKJH(NBHMBPFKCMI.OCHKLAKCFJC);
					if (item != null)
					{
						item.gameObject.SetActive(true);
						item.transform.SetParent(ItemContainer.transform);
						item.transform.localPosition = Vector3.zero;
						gameObject = item.gameObject;
						flag2 = false;
					}
				}
				if (flag2)
				{
					gameObject = UnityEngine.Object.Instantiate(HNPADMPIFDA.GetResources(NBHMBPFKCMI.OCHKLAKCFJC).Prefab, Vector3.zero, Quaternion.identity, ItemContainer.transform);
				}
			}
			switch (NBHMBPFKCMI.OCHKLAKCFJC)
			{
			case NOALGNJECAD.SolidColor1:
			case NOALGNJECAD.SolidColor2:
			case NOALGNJECAD.SolidColor3:
			case NOALGNJECAD.SolidColor4:
			case NOALGNJECAD.SolidColor5:
			case NOALGNJECAD.SolidColor6:
			{
				SolidColorItem component14 = PFDAAAAPJED.JOBDHIPIMAG().GetComponent<SolidColorItem>();
				component14.transform.SetParent(ItemContainer.transform);
				component14.SetupItem(NBHMBPFKCMI.OCHKLAKCFJC);
				if (CurrentLevel.LLMDNGHAJDO != null)
				{
					CurrentLevel.LLMDNGHAJDO.Add(component14.GetMatchType());
				}
				return component14;
			}
			case NOALGNJECAD.Jelly:
				return gameObject.GetComponent<JellyItem>();
			case NOALGNJECAD.ColoredBalloon:
			{
				ColoredBalloonItem component19 = gameObject.GetComponent<ColoredBalloonItem>();
				IIKJJFHPHOL nBFBPNNEKMN = IIKJJFHPHOL.None;
				switch (NBHMBPFKCMI.BFBNLNAHLHA)
				{
				case ALIFCLNJKPH.ColoredBallon1:
					nBFBPNNEKMN = IIKJJFHPHOL.Balloon1;
					break;
				case ALIFCLNJKPH.ColoredBallon2:
					nBFBPNNEKMN = IIKJJFHPHOL.Balloon2;
					break;
				case ALIFCLNJKPH.ColoredBallon3:
					nBFBPNNEKMN = IIKJJFHPHOL.Balloon3;
					break;
				case ALIFCLNJKPH.ColoredBallon4:
					nBFBPNNEKMN = IIKJJFHPHOL.Balloon4;
					break;
				case ALIFCLNJKPH.ColoredBallon5:
					nBFBPNNEKMN = IIKJJFHPHOL.Balloon5;
					break;
				case ALIFCLNJKPH.ColoredBallon6:
					nBFBPNNEKMN = IIKJJFHPHOL.Balloon6;
					break;
				}
				component19.SetupItem(nBFBPNNEKMN);
				return component19;
			}
			case NOALGNJECAD.Vase:
			{
				VaseItem component20 = gameObject.GetComponent<VaseItem>();
				LKDHEOPBAFN nBFBPNNEKMN2 = LKDHEOPBAFN.None;
				switch (NBHMBPFKCMI.BFBNLNAHLHA)
				{
				case ALIFCLNJKPH.VaseYellow:
					nBFBPNNEKMN2 = LKDHEOPBAFN.VaseYellow;
					break;
				case ALIFCLNJKPH.VaseRed:
					nBFBPNNEKMN2 = LKDHEOPBAFN.VaseRed;
					break;
				case ALIFCLNJKPH.VaseBlue:
					nBFBPNNEKMN2 = LKDHEOPBAFN.VaseBlue;
					break;
				case ALIFCLNJKPH.VaseGreen:
					nBFBPNNEKMN2 = LKDHEOPBAFN.VaseGreen;
					break;
				case ALIFCLNJKPH.VasePurple:
					nBFBPNNEKMN2 = LKDHEOPBAFN.VasePurple;
					break;
				case ALIFCLNJKPH.VaseOrange:
					nBFBPNNEKMN2 = LKDHEOPBAFN.VaseOrange;
					break;
				}
				component20.SetupItem(nBFBPNNEKMN2);
				return component20;
			}
			case NOALGNJECAD.BirdHouse:
				return gameObject.GetComponent<BirdHouseItem>();
			case NOALGNJECAD.Ufo:
				return gameObject.GetComponent<UfoItem>();
			case NOALGNJECAD.Duck:
			{
				DuckItem component17 = gameObject.GetComponent<DuckItem>();
				component17.SetupItem(NBHMBPFKCMI.BFBNLNAHLHA);
				return component17;
			}
			case NOALGNJECAD.Cage:
				return gameObject.GetComponent<CageItem>();
			case NOALGNJECAD.Crate:
			{
				CrateItem component15 = gameObject.GetComponent<CrateItem>();
				switch (NBHMBPFKCMI.BFBNLNAHLHA)
				{
				case ALIFCLNJKPH.Crate:
					component15.LayerCount = 1;
					break;
				case ALIFCLNJKPH.CrateLayer1:
					component15.LayerCount = 2;
					break;
				case ALIFCLNJKPH.CrateLayer2:
					component15.LayerCount = 3;
					break;
				case ALIFCLNJKPH.CrateLayer3:
					component15.LayerCount = 4;
					break;
				}
				component15.CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.CrateLayerSprites[component15.LayerCount - 1];
				return component15;
			}
			case NOALGNJECAD.ColoredCrate:
			{
				ColoredCrateItem component10 = gameObject.GetComponent<ColoredCrateItem>();
				component10.SetupItem(NBHMBPFKCMI.BFBNLNAHLHA);
				return component10;
			}
			case NOALGNJECAD.Balloon:
				return gameObject.GetComponent<BalloonItem>();
			case NOALGNJECAD.WaterMelon:
				return gameObject.GetComponent<WatermelonItem>();
			case NOALGNJECAD.Penguin:
				return gameObject.GetComponent<PenguinItem>();
			case NOALGNJECAD.Hanoi:
				return gameObject.GetComponent<HanoiItem>();
			case NOALGNJECAD.Soap:
				return gameObject.GetComponent<SoapItem>();
			case NOALGNJECAD.Gift:
				return gameObject.GetComponent<GiftItem>();
			case NOALGNJECAD.Pinata:
				return gameObject.GetComponent<PinataItem>();
			case NOALGNJECAD.Coconut:
				return gameObject.GetComponent<CoconutItem>();
			case NOALGNJECAD.MetalCrate:
				return gameObject.GetComponent<MetalCrateItem>();
			case NOALGNJECAD.LightBulb:
				return gameObject.GetComponent<LightBulbItem>();
			case NOALGNJECAD.Oyster:
				return gameObject.GetComponent<OysterItem>();
			case NOALGNJECAD.Mole:
				return gameObject.GetComponent<MoleItem>();
			case NOALGNJECAD.GiantDuck:
				return gameObject.GetComponent<GiantDuckItem>();
			case NOALGNJECAD.GiantPinata:
				return gameObject.GetComponent<GiantPinataItem>();
			case NOALGNJECAD.Soda:
			{
				SodaItem component18 = gameObject.GetComponent<SodaItem>();
				component18.Init((NBHMBPFKCMI.BFBNLNAHLHA != ALIFCLNJKPH.Soda4) ? 5 : 4);
				return component18;
			}
			case NOALGNJECAD.EasterEgg:
				return gameObject.GetComponent<EasterEggItem>();
			case NOALGNJECAD.CanToss:
				return gameObject.GetComponent<CanTossItem>();
			case NOALGNJECAD.Safe:
				return gameObject.GetComponent<SafeItem>();
			case NOALGNJECAD.Washer:
				return gameObject.GetComponent<WasherItem>();
			case NOALGNJECAD.MagicHat:
				return gameObject.GetComponent<MagicHatItem>();
			case NOALGNJECAD.Fish:
			{
				FishItem component16 = gameObject.GetComponent<FishItem>();
				int direction2 = ((NBHMBPFKCMI.BFBNLNAHLHA != ALIFCLNJKPH.Fish1) ? 1 : 0);
				component16.SetDirection(direction2);
				return component16;
			}
			case NOALGNJECAD.BalloonGenerator:
			{
				BalloonGeneratorItem component13 = gameObject.GetComponent<BalloonGeneratorItem>();
				int direction = ((NBHMBPFKCMI.BFBNLNAHLHA != ALIFCLNJKPH.BalloonGenerator1) ? 1 : 0);
				component13.SetDirection(direction);
				return component13;
			}
			case NOALGNJECAD.Honey:
				return gameObject.GetComponent<HoneyItem>();
			case NOALGNJECAD.Diamond:
			{
				DiamondItem component12 = gameObject.GetComponent<DiamondItem>();
				component12.ChangeState(NBHMBPFKCMI.BFBNLNAHLHA == ALIFCLNJKPH.DiamondOpen, false);
				return component12;
			}
			case NOALGNJECAD.Billboard:
				return gameObject.GetComponent<BillboardItem>();
			case NOALGNJECAD.Stone:
				return gameObject.GetComponent<StoneItem>();
			case NOALGNJECAD.Barrel:
			{
				BarrelItem component11 = gameObject.GetComponent<BarrelItem>();
				component11.Init(NBHMBPFKCMI.INFAGKCBEHL);
				return component11;
			}
			case NOALGNJECAD.ColoredSoda:
			{
				ColoredSodaItem component9 = gameObject.GetComponent<ColoredSodaItem>();
				LEDBLDKJBAI jOCKKMJBJLL3 = LEDBLDKJBAI.None;
				switch (NBHMBPFKCMI.BFBNLNAHLHA)
				{
				case ALIFCLNJKPH.ColoredSodaYellow:
					jOCKKMJBJLL3 = LEDBLDKJBAI.Yellow;
					break;
				case ALIFCLNJKPH.ColoredSodaRed:
					jOCKKMJBJLL3 = LEDBLDKJBAI.Red;
					break;
				case ALIFCLNJKPH.ColoredSodaBlue:
					jOCKKMJBJLL3 = LEDBLDKJBAI.Blue;
					break;
				case ALIFCLNJKPH.ColoredSodaGreen:
					jOCKKMJBJLL3 = LEDBLDKJBAI.Green;
					break;
				case ALIFCLNJKPH.ColoredSodaPurple:
					jOCKKMJBJLL3 = LEDBLDKJBAI.Purple;
					break;
				}
				component9.Init(jOCKKMJBJLL3);
				return component9;
			}
			case NOALGNJECAD.Potion:
			{
				PotionItem component8 = gameObject.GetComponent<PotionItem>();
				LEDBLDKJBAI jOCKKMJBJLL2 = LEDBLDKJBAI.None;
				switch (NBHMBPFKCMI.BFBNLNAHLHA)
				{
				case ALIFCLNJKPH.PotionYellow:
					jOCKKMJBJLL2 = LEDBLDKJBAI.Yellow;
					break;
				case ALIFCLNJKPH.PotionRed:
					jOCKKMJBJLL2 = LEDBLDKJBAI.Red;
					break;
				case ALIFCLNJKPH.PotionBlue:
					jOCKKMJBJLL2 = LEDBLDKJBAI.Blue;
					break;
				case ALIFCLNJKPH.PotionGreen:
					jOCKKMJBJLL2 = LEDBLDKJBAI.Green;
					break;
				case ALIFCLNJKPH.PotionPurple:
					jOCKKMJBJLL2 = LEDBLDKJBAI.Purple;
					break;
				case ALIFCLNJKPH.PotionOrange:
					jOCKKMJBJLL2 = LEDBLDKJBAI.Orange;
					break;
				}
				CurrentLevel.NBAMJKCNMHP(NOALGNJECAD.Potion, GGDDNIIEFFF.PotionColorData, CurrentLevel.DCJNBADOLGD);
				component8.Init(jOCKKMJBJLL2);
				return component8;
			}
			case NOALGNJECAD.Tube:
			{
				TubeItem component7 = gameObject.GetComponent<TubeItem>();
				LEDBLDKJBAI pFDINDHJOCC = LEDBLDKJBAI.None;
				switch (NBHMBPFKCMI.BFBNLNAHLHA)
				{
				case ALIFCLNJKPH.TubeYellow:
					pFDINDHJOCC = LEDBLDKJBAI.Yellow;
					break;
				case ALIFCLNJKPH.TubeRed:
					pFDINDHJOCC = LEDBLDKJBAI.Red;
					break;
				case ALIFCLNJKPH.TubeBlue:
					pFDINDHJOCC = LEDBLDKJBAI.Blue;
					break;
				case ALIFCLNJKPH.TubeGreen:
					pFDINDHJOCC = LEDBLDKJBAI.Green;
					break;
				case ALIFCLNJKPH.TubePurple:
					pFDINDHJOCC = LEDBLDKJBAI.Purple;
					break;
				}
				CurrentLevel.NBAMJKCNMHP(NOALGNJECAD.Tube, GGDDNIIEFFF.TubeColorData, CurrentLevel.DCJNBADOLGD);
				component7.Init(pFDINDHJOCC);
				return component7;
			}
			case NOALGNJECAD.Log:
				return gameObject.GetComponent<LogItem>();
			case NOALGNJECAD.LogFake:
			{
				LogFakeItem component6 = gameObject.GetComponent<LogFakeItem>();
				switch (NBHMBPFKCMI.BFBNLNAHLHA)
				{
				case ALIFCLNJKPH.LogLeft:
					component6.Prepare(IEKBFJBLGFM.Left);
					break;
				case ALIFCLNJKPH.LogRight:
					component6.Prepare(IEKBFJBLGFM.Right);
					break;
				case ALIFCLNJKPH.LogUp:
					component6.Prepare(IEKBFJBLGFM.Up);
					break;
				case ALIFCLNJKPH.LogDown:
					component6.Prepare(IEKBFJBLGFM.Down);
					break;
				}
				return component6;
			}
			case NOALGNJECAD.Pot:
				return gameObject.GetComponent<PotItem>();
			case NOALGNJECAD.Tomb:
				return gameObject.GetComponent<TombItem>();
			case NOALGNJECAD.Blaster:
			{
				BlasterItem component5 = gameObject.GetComponent<BlasterItem>();
				int mDPEMCMPAMB = NBHMBPFKCMI.GBBCHGMFNFH.LJNDDJECANK;
				int cMAJLIAELDP = NBHMBPFKCMI.GBBCHGMFNFH.BHIJCAOHDCM;
				IEKBFJBLGFM aJLDJAHHGOJ = NBHMBPFKCMI.GBBCHGMFNFH.AKDMMEEHGHB;
				LEDBLDKJBAI jOCKKMJBJLL = NBHMBPFKCMI.GBBCHGMFNFH.BPLHOCDDLCG;
				component5.Prepare(aJLDJAHHGOJ, mDPEMCMPAMB, cMAJLIAELDP, jOCKKMJBJLL);
				return component5;
			}
			case NOALGNJECAD.Wall:
			{
				WallItem component4 = gameObject.GetComponent<WallItem>();
				component4.Prepare(NBHMBPFKCMI.GBBCHGMFNFH);
				return component4;
			}
			case NOALGNJECAD.Fireworks:
				return gameObject.GetComponent<FireworksItem>();
			case NOALGNJECAD.DiscoBall:
			{
				DiscoBallItem component3 = DJADHIALFMB.JOBDHIPIMAG().GetComponent<DiscoBallItem>();
				component3.transform.SetParent(ItemContainer.transform);
				LEDBLDKJBAI lEDBLDKJBAI = LEDBLDKJBAI.None;
				switch (NBHMBPFKCMI.BFBNLNAHLHA)
				{
				case ALIFCLNJKPH.DiscoBallColor1:
					lEDBLDKJBAI = LEDBLDKJBAI.Yellow;
					break;
				case ALIFCLNJKPH.DiscoBallColor2:
					lEDBLDKJBAI = LEDBLDKJBAI.Red;
					break;
				case ALIFCLNJKPH.DiscoBallColor3:
					lEDBLDKJBAI = LEDBLDKJBAI.Blue;
					break;
				case ALIFCLNJKPH.DiscoBallColor4:
					lEDBLDKJBAI = LEDBLDKJBAI.Green;
					break;
				case ALIFCLNJKPH.DiscoBallColor5:
					lEDBLDKJBAI = LEDBLDKJBAI.Purple;
					break;
				case ALIFCLNJKPH.DiscoBallColor6:
					lEDBLDKJBAI = LEDBLDKJBAI.Orange;
					break;
				}
				if (lEDBLDKJBAI == LEDBLDKJBAI.None && CurrentLevel.LLMDNGHAJDO.Count > 0)
				{
					lEDBLDKJBAI = CurrentLevel.LLMDNGHAJDO.ElementAt(BFGGHJGIHLJ.FDFDDKBDPEG(0, CurrentLevel.LLMDNGHAJDO.Count, 10));
				}
				component3.EffectiveItemType = lEDBLDKJBAI;
				component3.SetTintColor(lEDBLDKJBAI);
				return component3;
			}
			case NOALGNJECAD.Rocket:
			{
				SpecialItem specialItem = null;
				switch (NBHMBPFKCMI.BFBNLNAHLHA)
				{
				case ALIFCLNJKPH.RocketHorizantal:
					specialItem = AHGBGKFOEML.JOBDHIPIMAG().GetComponent<HorizontalRocketItem>();
					break;
				case ALIFCLNJKPH.RocketVertical:
					specialItem = CFPBIMCGOML.JOBDHIPIMAG().GetComponent<VerticalRocketItem>();
					break;
				}
				if (specialItem.gameObject.transform.parent == null)
				{
					specialItem.transform.SetParent(ItemContainer.transform);
				}
				return specialItem;
			}
			case NOALGNJECAD.Bomb:
			{
				BombItem component2 = PLKAAPLNNMK.JOBDHIPIMAG().GetComponent<BombItem>();
				if (component2.transform.parent == null)
				{
					component2.transform.SetParent(ItemContainer.transform);
				}
				return component2;
			}
			case NOALGNJECAD.DoubleDiscoBall:
				return gameObject.GetComponent<DoubleDiscoBallItem>();
			case NOALGNJECAD.DoubleRocket:
				return gameObject.GetComponent<DoubleRocketItem>();
			case NOALGNJECAD.DoubleBomb:
			{
				DoubleBombItem component = gameObject.GetComponent<DoubleBombItem>();
				component.AddShakeReferences(PanelShakeAnimations);
				return component;
			}
			case NOALGNJECAD.DiscoBallAndRocket:
				return gameObject.GetComponent<DiscoBallAndRocketItem>();
			case NOALGNJECAD.DiscoBallAndBomb:
				return gameObject.GetComponent<DiscoBallAndBombItem>();
			case NOALGNJECAD.RocketAndBomb:
				return gameObject.GetComponent<RocketAndBombItem>();
			default:
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.LevelBuilder, "Unexpected type: {0}:", NBHMBPFKCMI.OCHKLAKCFJC);
				return null;
			}
		}

		public CellItem CreateCellItem(NOALGNJECAD HBBIFNLDKPO, bool BOBCMAOIJGM)
		{
			HNPADMPIFDA.InitItem(HBBIFNLDKPO);
			if (BOBCMAOIJGM)
			{
				GameObject gameObject = HNPADMPIFDA.GetResources(HBBIFNLDKPO).Prefab.JOBDHIPIMAG();
				CellItem component = gameObject.GetComponent<CellItem>();
				component.IsRecyclable = true;
				return component;
			}
			GameObject gameObject2 = UnityEngine.Object.Instantiate(ItemResourcesManager.GABGKBAKHDP.GetResources(HBBIFNLDKPO).Prefab, Vector3.zero, Quaternion.identity, base.transform);
			CellItem component2 = gameObject2.GetComponent<CellItem>();
			component2.IsRecyclable = false;
			return component2;
		}

		public HorizontalRocketItem CreateRandomRocket(Vector3 LDMDBPLADGD)
		{
			return (BFGGHJGIHLJ.FDFDDKBDPEG(0, 10, 11) >= 5) ? CreateVerticallRocket(LDMDBPLADGD) : CreateHorizantalRocket(LDMDBPLADGD);
		}

		public HorizontalRocketItem CreateHorizantalRocket(Vector3 LDMDBPLADGD)
		{
			HorizontalRocketItem horizontalRocketItem = CreateItem(new DNJKLNPHPOF(NOALGNJECAD.Rocket, ALIFCLNJKPH.RocketHorizantal)) as HorizontalRocketItem;
			horizontalRocketItem.transform.position = LDMDBPLADGD;
			return horizontalRocketItem;
		}

		public VerticalRocketItem CreateVerticallRocket(Vector3 LDMDBPLADGD)
		{
			VerticalRocketItem verticalRocketItem = CreateItem(new DNJKLNPHPOF(NOALGNJECAD.Rocket, ALIFCLNJKPH.RocketVertical)) as VerticalRocketItem;
			verticalRocketItem.transform.position = LDMDBPLADGD;
			return verticalRocketItem;
		}

		public SpecialItem CreateSpecialItem(NOALGNJECAD NBFBPNNEKMN, LEDBLDKJBAI CEKMAJAHNAG, Vector3 LDMDBPLADGD, Cell LBHDELJBONF)
		{
			if (!PKPBMFKPGFE && CurrentLevel.PDGLECFDLJJ == 2 && NBFBPNNEKMN == NOALGNJECAD.Rocket)
			{
				if (LBHDELJBONF.Y > 3 && LBHDELJBONF.X < 2)
				{
					return CreateVerticallRocket(LDMDBPLADGD);
				}
				if (LBHDELJBONF.X > 1 && LBHDELJBONF.X < 5 && LBHDELJBONF.Y > 2 && LBHDELJBONF.Y < 7)
				{
					return CreateVerticallRocket(LDMDBPLADGD);
				}
				if (LBHDELJBONF.X > 4 && LBHDELJBONF.Y < 3)
				{
					return CreateHorizantalRocket(LDMDBPLADGD);
				}
				return CreateRandomRocket(LDMDBPLADGD);
			}
			if (CurrentLevel.PDGLECFDLJJ == 11 && NBFBPNNEKMN == NOALGNJECAD.Rocket)
			{
				for (int i = 0; i < CurrentLevel.JKKJLDLMIOG.Count; i++)
				{
					OGIFMLFEAEM oGIFMLFEAEM = CurrentLevel.JKKJLDLMIOG[i];
					if (oGIFMLFEAEM.ENBPGGCIADN == NOALGNJECAD.GiantDuck && oGIFMLFEAEM.GMCGMPEEHJP > 0)
					{
						return CreateVerticallRocket(LDMDBPLADGD);
					}
				}
			}
			return CreateSpecialItemWithoutCell(NBFBPNNEKMN, CEKMAJAHNAG, LDMDBPLADGD);
		}

		public SpecialItem CreateSpecialItemWithoutCell(NOALGNJECAD NBFBPNNEKMN, LEDBLDKJBAI CEKMAJAHNAG, Vector3 LDMDBPLADGD)
		{
			SpecialItem specialItem;
			switch (NBFBPNNEKMN)
			{
			case NOALGNJECAD.Rocket:
				specialItem = CreateRandomRocket(LDMDBPLADGD);
				break;
			case NOALGNJECAD.Bomb:
				specialItem = CreateItem(new DNJKLNPHPOF(NOALGNJECAD.Bomb)) as SpecialItem;
				specialItem.transform.position = LDMDBPLADGD;
				break;
			case NOALGNJECAD.DiscoBall:
			{
				if (CEKMAJAHNAG == LEDBLDKJBAI.None)
				{
					CEKMAJAHNAG = CurrentLevel.LLMDNGHAJDO.ElementAt(BFGGHJGIHLJ.FDFDDKBDPEG(0, CurrentLevel.LLMDNGHAJDO.Count, 11));
				}
				DiscoBallItem discoBallItem = (DiscoBallItem)CreateItem(new DNJKLNPHPOF(NOALGNJECAD.DiscoBall, (ALIFCLNJKPH)(84 + CEKMAJAHNAG)));
				discoBallItem.EffectiveItemType = CEKMAJAHNAG;
				discoBallItem.SetTintColor(CEKMAJAHNAG);
				specialItem = discoBallItem;
				specialItem.transform.position = LDMDBPLADGD;
				break;
			}
			default:
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.LevelBuilder, "Can not build special item. Unknown type:{0}", NBFBPNNEKMN);
				return null;
			}
			return specialItem;
		}

		public SpecialItem CreateComboItem(PBLOIKDOPAJ FNEALCOPNND, Vector3 LDMDBPLADGD)
		{
			SpecialItem specialItem = CreateItem(new DNJKLNPHPOF(FNEALCOPNND.CDAJIPHMCDN)) as SpecialItem;
			if (FNEALCOPNND.CDAJIPHMCDN == NOALGNJECAD.DiscoBallAndBomb || FNEALCOPNND.CDAJIPHMCDN == NOALGNJECAD.DiscoBallAndRocket)
			{
				DiscoBallItem discoBallItem = specialItem as DiscoBallItem;
				discoBallItem.EffectiveItemType = FNEALCOPNND.PEMKDIIEPPJ().EffectiveItemType;
				discoBallItem.SetTintColor(discoBallItem.EffectiveItemType);
			}
			specialItem.transform.position = LDMDBPLADGD;
			((PGCMDKBCMHI)specialItem).SetComboGroup(FNEALCOPNND);
			return specialItem;
		}

		private static Cell KNKKDPJFBGI(Cell LBHDELJBONF)
		{
			CFOIPDKEFMM currentGrid = LBHDELJBONF.CurrentGrid;
			if (LBHDELJBONF.Y == 0)
			{
				return null;
			}
			for (int num = LBHDELJBONF.Y - 1; num >= 0; num--)
			{
				Cell cell = currentGrid.ECNCPJGHBIG(LBHDELJBONF.X, num);
				if (cell.Exists)
				{
					return cell;
				}
			}
			return null;
		}

		public void PopulateEgoItems()
		{
			if (EgoDialog.EGOItems != null && EgoDialog.EGOItems.Count != 0)
			{
				List<NOALGNJECAD> eGOItems = EgoDialog.EGOItems;
				EgoDialog.EGOItems = null;
				NOGNOHGDKNB(null, eGOItems, true);
			}
		}

		private void IKGBNGMIBCJ(List<Cell> ADEIHGLOEEF, bool NBGIEJKPDON)
		{
			bool flag = false;
			List<NOALGNJECAD> latestSelectedItems = BoosterSelectDialog.LatestSelectedItems;
			if (latestSelectedItems != null && latestSelectedItems.Count > 0)
			{
				Recorder.CGGNCAIKEGN(latestSelectedItems);
				flag = true;
				BoosterSelectDialog.LatestSelectedItems = null;
			}
			DIGGBGADIGJ dIGGBGADIGJ = DIGGBGADIGJ.GABGKBAKHDP;
			if (DIGGBGADIGJ.DFGKPMCBFNL)
			{
				dIGGBGADIGJ.MAFEKIKFNIJ();
				if (dIGGBGADIGJ.BGKIIAJNHLL > 0)
				{
					Recorder.HMCHBHEIDNJ(dIGGBGADIGJ.BGKIIAJNHLL);
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LevelBuilder, "CrownRush Stage:{0} ", dIGGBGADIGJ.BGKIIAJNHLL);
					flag = true;
				}
			}
			if (flag)
			{
				HashSet<Cell> hashSet = ((ADEIHGLOEEF != null) ? new HashSet<Cell>(ADEIHGLOEEF) : new HashSet<Cell>());
				if (CurrentLevelNo == 10)
				{
					hashSet.Add(CurrentLevel.JHDMFHDHIFN.ECNCPJGHBIG(4, 0));
				}
				NOGNOHGDKNB(latestSelectedItems, (!DIGGBGADIGJ.DFGKPMCBFNL) ? null : dIGGBGADIGJ.HKNLBCLNKED(), true, hashSet, NBGIEJKPDON);
			}
		}

		private void IFLNNILPLIG(int HFPMOPDEDJF, int GEMCBIEANPE)
		{
			List<NOALGNJECAD> list = new List<NOALGNJECAD>();
			if (CCJBDEGNEAL.GKIBJAOFBHB(HFPMOPDEDJF, 0))
			{
				list.Add(NOALGNJECAD.Rocket);
			}
			if (CCJBDEGNEAL.GKIBJAOFBHB(HFPMOPDEDJF, 1))
			{
				list.Add(NOALGNJECAD.Bomb);
			}
			if (CCJBDEGNEAL.GKIBJAOFBHB(HFPMOPDEDJF, 2))
			{
				list.Add(NOALGNJECAD.DiscoBall);
			}
			List<NOALGNJECAD> list2 = DIGGBGADIGJ.BLIBIINIGAI(GEMCBIEANPE);
			if (list.Count + list2.Count > 0)
			{
				NOGNOHGDKNB(list, list2, true);
			}
		}

		private void NOGNOHGDKNB(List<NOALGNJECAD> MKHCLBCMDHH, List<NOALGNJECAD> GBPEKNACIDB, bool FEHACKOBGBL = false, HashSet<Cell> ADEIHGLOEEF = null, bool NBGIEJKPDON = false)
		{
			List<Cell> list = new List<Cell>(91);
			List<Cell> list2 = new List<Cell>(91);
			foreach (Cell item in CurrentLevel.JHDMFHDHIFN.IOFOFDLJDAA())
			{
				if (item.EAILOFHFNJO && !item.HasCellItem() && item.LBFCDKPCDPB.CanBeReplacedByPreLevelBooster() && (ADEIHGLOEEF == null || !ADEIHGLOEEF.Contains(item)))
				{
					SolidColorItem solidColorItem = item.LBFCDKPCDPB as SolidColorItem;
					if (solidColorItem != null && solidColorItem.DAPJNCFCBHD)
					{
						list2.Add(item);
					}
					else
					{
						list.Add(item);
					}
				}
			}
			List<NOALGNJECAD> list3 = new List<NOALGNJECAD>();
			if (GBPEKNACIDB != null)
			{
				list3.AddRange(GBPEKNACIDB);
			}
			if (MKHCLBCMDHH != null)
			{
				list3.AddRange(MKHCLBCMDHH);
			}
			list.KFGEEKGAPDP(11);
			list2.KFGEEKGAPDP(11);
			list.AddRange(list2);
			TapListener.Instance.IncreaseBlockRequests();
			FallManager.IncreaseWaitingFallBlocker();
			Sequence sequence = DOTween.Sequence();
			if (NBGIEJKPDON)
			{
				sequence.timeScale = 100f;
			}
			sequence.OnComplete(delegate
			{
				TapListener.Instance.DecreaseBlockRequests();
				FallManager.DecreaseWaitingFallBlocker();
			});
			int num = 0;
			float num2 = 0f;
			int i = 0;
			for (int num3 = Mathf.Min(list.Count, list3.Count); i < num3; i++)
			{
				NOALGNJECAD nOALGNJECAD = list3[i];
				Cell LBHDELJBONF = list[i];
				LEDBLDKJBAI lEDBLDKJBAI = LBHDELJBONF.LBFCDKPCDPB.GetMatchType();
				if (lEDBLDKJBAI == LEDBLDKJBAI.None)
				{
					lEDBLDKJBAI = (LEDBLDKJBAI)BFGGHJGIHLJ.FDFDDKBDPEG(0, 6, 11);
				}
				SpecialItem BBHFBHMLHPN = CreateSpecialItem(nOALGNJECAD, lEDBLDKJBAI, LBHDELJBONF.GetFrozenPosition(), LBHDELJBONF);
				Item MFLAFJACJPO = LBHDELJBONF.LBFCDKPCDPB;
				BBHFBHMLHPN.BringToFront();
				BBHFBHMLHPN.transform.localScale = Vector3.one * 3.5f;
				BBHFBHMLHPN.CurrentSpriteRenderer.color = new Color(1f, 1f, 1f, 0f);
				Sequence sequence2 = DOTween.Sequence();
				sequence2.Append(BBHFBHMLHPN.transform.DOScale(Vector3.one * 0.7f, 0.38f).SetEase(Ease.InCubic));
				sequence2.Append(BBHFBHMLHPN.transform.DOScale(Vector3.one * 1.15f, 0.1f).SetEase(Ease.OutSine));
				sequence2.Append(BBHFBHMLHPN.transform.DOScale(Vector3.one * 0.925f, 0.1f).SetEase(Ease.InOutSine));
				sequence2.Append(BBHFBHMLHPN.transform.DOScale(Vector3.one, 0.1f).SetEase(Ease.InOutSine));
				sequence2.InsertCallback(0f, delegate
				{
					BBHFBHMLHPN.CurrentSpriteRenderer.color = new Color(1f, 1f, 1f, 0f);
				});
				sequence2.Insert(0.01f, BBHFBHMLHPN.CurrentSpriteRenderer.DOColor(new Color(1f, 1f, 1f, 1f), 0.38f).SetEase(Ease.InOutSine));
				sequence2.InsertCallback(0.38f, delegate
				{
					LBHDELJBONF.LBFCDKPCDPB = BBHFBHMLHPN;
					if (MFLAFJACJPO != null)
					{
						MFLAFJACJPO.RemoveSelf();
					}
					CanCastShadowComponent.CastShadowIfPossible(LBHDELJBONF);
					if (!NBGIEJKPDON)
					{
						if (FEHACKOBGBL)
						{
							ParticlePool.Instance.PlayParticle(ParticlePool.Instance.SpecialItemPlaceParticle, LBHDELJBONF.GetFrozenPosition());
						}
						AudioManager.Play(KOOGPFAPGGD.SpecialItemPlace);
					}
					if (BBHFBHMLHPN is BombItem)
					{
						BBHFBHMLHPN.StartAnimations();
					}
				});
				float num4 = Mathf.Max(0.25f, 0.4f - 0.03f * (float)i);
				if (i > 0)
				{
					num2 += num4;
				}
				sequence.Insert(num2, sequence2);
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LevelBuilder, "Populating prelevel item:{0} ", nOALGNJECAD);
				num++;
			}
			if (MKHCLBCMDHH == null || MKHCLBCMDHH.Count <= 0)
			{
				return;
			}
			int num5 = ((GBPEKNACIDB != null) ? GBPEKNACIDB.Count : 0);
			int val = ((MKHCLBCMDHH != null) ? MKHCLBCMDHH.Count : 0);
			int val2 = num - num5;
			int j = 0;
			for (int num6 = Math.Min(val, val2); j < num6; j++)
			{
				NOALGNJECAD nOALGNJECAD2 = MKHCLBCMDHH[j];
				switch (nOALGNJECAD2)
				{
				case NOALGNJECAD.Rocket:
					CurrentLevel.CFDBAMKOABO[NAAHKHPBAPA.Rocket]++;
					GEBAAFFGKJG.GABGKBAKHDP.DCAKPPKFOEP(NAAHKHPBAPA.Rocket, 1);
					break;
				case NOALGNJECAD.Bomb:
					CurrentLevel.CFDBAMKOABO[NAAHKHPBAPA.Bomb]++;
					GEBAAFFGKJG.GABGKBAKHDP.DCAKPPKFOEP(NAAHKHPBAPA.Bomb, 1);
					break;
				case NOALGNJECAD.DiscoBall:
					CurrentLevel.CFDBAMKOABO[NAAHKHPBAPA.DiscoBall]++;
					GEBAAFFGKJG.GABGKBAKHDP.DCAKPPKFOEP(NAAHKHPBAPA.DiscoBall, 1);
					break;
				}
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LevelBuilder, "Paid prelevel item:{0} ", nOALGNJECAD2);
				AFJPGLHKOID.IJPMIOFMCPJ(nOALGNJECAD2.ToString());
			}
		}

		public static void Reset()
		{
			CurrentLevelNo = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC();
			LastLevel.OMOKOKFNBKI();
			LastLevel.EKGHEGKILLC = false;
			NDGOJGLPIJF.GABGKBAKHDP.AMKOJOKCELO = 0;
		}

		public void RestartLevel()
		{
			KDBDBMBAKEL = "Restart";
			JNEKECPDMJH();
		}

		public void RetryLevel()
		{
			KDBDBMBAKEL = "TryAgain";
			JNEKECPDMJH();
		}

		public void TryPlaySpecialItemTutorial(SpecialItem ALAJBEFFOKB)
		{
			if (CurrentLevel.EBMFPDNPIEM > 0)
			{
				BIMAONBKNOP tutorialForSpecialItem = TutorialManager.GetTutorialForSpecialItem(ALAJBEFFOKB);
				if (tutorialForSpecialItem != null)
				{
					NKMANNPOAGM(tutorialForSpecialItem);
				}
			}
		}

		public void TryPlayComboItemTutorial(PBLOIKDOPAJ CNKHNFDJJBB)
		{
			if (CurrentLevel.EBMFPDNPIEM > 0)
			{
				BIMAONBKNOP tutorialForComboItem = TutorialManager.GetTutorialForComboItem(CNKHNFDJJBB);
				if (tutorialForComboItem != null)
				{
					NKMANNPOAGM(tutorialForComboItem);
				}
			}
		}

		private void JNEKECPDMJH()
		{
			if (FallManager.AreThereActiveAnimations() || FallManager.AreFallsBlocked())
			{
				StartCoroutine(CDNANIBCBDG());
			}
			else
			{
				SceneReloadedSetups();
			}
		}

		private IEnumerator CDNANIBCBDG()
		{
			CaravanSceneManager.ShowLoading(LEMANCBLOGA[UnityEngine.Random.Range(0, LEMANCBLOGA.Length)]);
			AudioManager.NAEBPOAPIFP = false;
			AudioManager.ForceStopAll();
			yield return MCJHHDACJBG.CNDGGNLKOOC;
			bool flag = FallManager.AreThereActiveAnimations();
			while (FallManager.AreThereActiveAnimations() || FallManager.AreFallsBlocked())
			{
				yield return MCJHHDACJBG.CNDGGNLKOOC;
			}
			if (flag)
			{
				yield return new WaitForSeconds(1.1f);
			}
			CaravanSceneManager.HideLoading();
			SceneReloadedSetups();
			AudioManager.NAEBPOAPIFP = MDGKDGMGGCL.GABGKBAKHDP.NBJEKKIECGE();
		}

		public void ClearGridForSnapshot()
		{
			FireworksController.GABGKBAKHDP.ClearRockets();
			CurrentLevel.ELEHIDCIDJN = new DGFHEKMMJHL(CurrentLevel);
			BDGFEIGMLFK();
			NIMIEJNELGF();
			KFDEDECPNGP();
			foreach (Cell item in CurrentLevel.JHDMFHDHIFN.IOFOFDLJDAA())
			{
				item.ResetStateForSnapshot();
			}
			Dictionary<FCPPDOMBLHL, HICNCEMBCBG> dCJNBADOLGD = ALMCNBDKKHH(GGDDNIIEFFF);
			CurrentLevel.DCJNBADOLGD = dCJNBADOLGD;
			DCDPMCIAFGM(CurrentLevel, KEFMJJAJAPB);
			CurrentLevel.KIOHBMGLOMM();
		}

		public void ProcessGridForSnapshot()
		{
			for (int i = 0; i < CurrentLevel.JKKJLDLMIOG.Count; i++)
			{
				CurrentLevel.MLAGNJGFOND(CurrentLevel.JKKJLDLMIOG[i].ENBPGGCIADN);
			}
			foreach (Cell item in CurrentLevel.JHDMFHDHIFN.ECNKPIEGILI())
			{
				if (item.Exists && item.EAILOFHFNJO)
				{
					GKFOADDKNHO(item);
				}
			}
			foreach (Cell item2 in CurrentLevel.JHDMFHDHIFN.IOFOFDLJDAA())
			{
				item2.OnCellGridChange(CurrentLevel.JHDMFHDHIFN);
			}
			if (CurrentLevel.CICDFLLGAHA() < 1)
			{
				LLJLGKECBBE.GABGKBAKHDP.CDCGBANMJDF();
			}
			if (CurrentLevel.NJHCINMDGKB[38] > 0 && CurrentLevel.GEHOAFJDMPE(NOALGNJECAD.Balloon) < 1)
			{
				MJPAKGMNFAC.GABGKBAKHDP.CDCGBANMJDF(NOALGNJECAD.Balloon);
			}
		}

		public void CreateSnapshotItem(Cell LBHDELJBONF, short HBMKHCHGHHF, MDMICLOPLPC DJDKLOJBJCO, bool OLCNADKIEMK = false)
		{
			if (HBMKHCHGHHF != 0)
			{
				NOALGNJECAD nOALGNJECAD = ((ALIFCLNJKPH)HBMKHCHGHHF).AMLEHGPGGIC();
				Item item;
				if (OLCNADKIEMK)
				{
					LBHDELJBONF.AddCellItemToCurrentLevel(nOALGNJECAD);
					item = LBHDELJBONF.FEMFMBLMKHP;
				}
				else
				{
					item = HJGDKKDFNLL(LBHDELJBONF, nOALGNJECAD, (ALIFCLNJKPH)HBMKHCHGHHF, DJDKLOJBJCO);
				}
				KABFIFMCFIJ kABFIFMCFIJ = item as KABFIFMCFIJ;
				if (kABFIFMCFIJ != null)
				{
					kABFIFMCFIJ.SetState(DJDKLOJBJCO);
				}
			}
		}

		private DLKLKMDJOOJ IGHPOPEIGFM(Cell LBHDELJBONF)
		{
			CellMetaData cellMetaData = GLLGGHMEIPA(LBHDELJBONF);
			return new DLKLKMDJOOJ(cellMetaData.TiledObject.Properties);
		}

		private CellMetaData GLLGGHMEIPA(Cell LBHDELJBONF)
		{
			return GGDDNIIEFFF.CellList[JDPJOPDFEMJ(LBHDELJBONF.X, LBHDELJBONF.Y, GGDDNIIEFFF.Width, GGDDNIIEFFF.Height)];
		}

		[CompilerGenerated]
		private static int IOFCOFHAKBJ(OGIFMLFEAEM AMFCENFNAJJ, OGIFMLFEAEM CNLILOEEBOJ)
		{
			return (AMFCENFNAJJ.BHIJCAOHDCM >= CNLILOEEBOJ.BHIJCAOHDCM) ? 1 : (-1);
		}

		[CompilerGenerated]
		private static void CHNBKLAHJGI()
		{
			TapListener.Instance.DecreaseBlockRequests();
			FallManager.DecreaseWaitingFallBlocker();
		}
	}
}
