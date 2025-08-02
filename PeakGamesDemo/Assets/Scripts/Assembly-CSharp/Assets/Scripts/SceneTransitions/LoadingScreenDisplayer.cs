using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Mechanics;
using DG.Tweening;
using InitialScene;
using Spine.Unity;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.SceneTransitions
{
	public class LoadingScreenDisplayer : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class JBIKMKNKGBB
		{
			internal Action IMHLFAHONPP;

			internal LoadingScreenDisplayer PDAPIGLEPGC;

			internal void AGFNGEFDHLA()
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LoadingScreenDisplayer, "Loading Fade Out Completed");
				PDAPIGLEPGC.CDIJIMCMCOE = false;
				PDAPIGLEPGC.RenderGroup.gameObject.SetActive(false);
				PDAPIGLEPGC.BackgroundSpriteRenderer.sprite = null;
				if (PDAPIGLEPGC.FDOOLENAPCC.Count > 0)
				{
					while (PDAPIGLEPGC.FDOOLENAPCC.Count > 0)
					{
						int index = PDAPIGLEPGC.FDOOLENAPCC.Count - 1;
						PDAPIGLEPGC.FDOOLENAPCC.RemoveAt(index);
					}
					if (PDAPIGLEPGC.EGJHPNKHFOL != null)
					{
						UnityEngine.Object.Destroy(PDAPIGLEPGC.EGJHPNKHFOL.gameObject);
						PDAPIGLEPGC.EGJHPNKHFOL = null;
					}
				}
				if (PDAPIGLEPGC.CarLoading.activeSelf)
				{
					MeshRenderer component = PDAPIGLEPGC.CarAnimation.GetComponent<MeshRenderer>();
					if (component != null && component.materials.Length > 0)
					{
						Resources.UnloadAsset(component.materials[0].mainTexture);
					}
				}
				else
				{
					Resources.UnloadUnusedAssets();
				}
				if (IMHLFAHONPP != null)
				{
					IMHLFAHONPP();
				}
				PDAPIGLEPGC.JIEEDECENPC = null;
			}
		}

		public const float FadeDuration = 0.3f;

		public bool InstantFade;

		public static LoadingScreenDisplayer Instance;

		public SkeletonAnimation CarAnimation;

		public LoadingScreenResizer RenderGroup;

		public SpriteRenderer Logo;

		public SpriteRenderer LogoShadow;

		public SpriteRenderer BackgroundSpriteRenderer;

		public SpriteRenderer BackgroundTopSpriteRenderer;

		public SpriteRenderer BackgroundBottomSpriteRenderer;

		public GameObject CarLoading;

		public SpriteRenderer CarLoadingBackground;

		private readonly Color FAAKILMDOJK = new Color(64f / 85f, 0.23921569f, 0.28627452f, 1f);

		private readonly Color CGNOCAJPNPO = new Color(0f, 0f, 0f, 32f / 51f);

		private Sequence JIEEDECENPC;

		private KLKAGJKCKBE MHNACPEADLF;

		public TextMeshPro LoadingText;

		private List<UnityEngine.Object> FDOOLENAPCC;

		private LoadingInfoDialog EGJHPNKHFOL;

		private const string EJOOEKMPAND = "Loading/";

		private readonly Dictionary<KLKAGJKCKBE, string> KFNPPFJEONF = new Dictionary<KLKAGJKCKBE, string>
		{
			{
				KLKAGJKCKBE.Rocket,
				"Loading/Loading_Rocket"
			},
			{
				KLKAGJKCKBE.Bomb,
				"Loading/Loading_Bomb"
			},
			{
				KLKAGJKCKBE.Discoball,
				"Loading/Loading_Disco"
			},
			{
				KLKAGJKCKBE.DoubleBomb,
				"Loading/Loading_DoubleBomb"
			},
			{
				KLKAGJKCKBE.DoubleRocket,
				"Loading/Loading_DoubleRocket"
			},
			{
				KLKAGJKCKBE.RocketBomb,
				"Loading/Loading_RocketBomb"
			},
			{
				KLKAGJKCKBE.Bruno,
				"Loading/Loading_Bruno"
			},
			{
				KLKAGJKCKBE.Wally,
				"Loading/Loading_Wally"
			},
			{
				KLKAGJKCKBE.Cooper,
				"Loading/Loading_Cooper"
			},
			{
				KLKAGJKCKBE.RandomRocket,
				"Loading/Loading_RandomRocket"
			}
		};

		private static readonly KLKAGJKCKBE[] CDPIPMGHLMG = new KLKAGJKCKBE[3]
		{
			KLKAGJKCKBE.Bruno,
			KLKAGJKCKBE.Wally,
			KLKAGJKCKBE.Cooper
		};

		private bool PCFAOPLFOOP;

		public bool CDIJIMCMCOE
		{
			get
			{
				return PCFAOPLFOOP;
			}
			private set
			{
				PCFAOPLFOOP = value;
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LoadingScreenDisplayer, "Is loading being displayed: {0}", value);
			}
		}

		public void Awake()
		{
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			NDCHDLEOFDP();
			FDOOLENAPCC = new List<UnityEngine.Object>();
			Logo.color = new Color(1f, 1f, 1f, 0f);
			LogoShadow.color = new Color(1f, 1f, 1f, 0f);
			if (Instance != null)
			{
				UnityEngine.Object.DestroyImmediate(Instance.gameObject);
			}
			Instance = this;
		}

		private void NDCHDLEOFDP()
		{
			float aspect = RenderGroup.CurrentMainCamera.aspect;
			float bottomInset = RenderGroup.GetBottomInset();
			if (bottomInset > 0f)
			{
				Vector3 localPosition = RenderGroup.LoadingText.ANLKLKAINEO.localPosition;
				localPosition.y = bottomInset + 1.5f;
				RenderGroup.LoadingText.ANLKLKAINEO.localPosition = localPosition;
			}
			else if (aspect >= 0.75f)
			{
				RenderGroup.LoadingText.DGLOHLPKABM = 7f;
				Vector3 localPosition2 = RenderGroup.LoadingText.ANLKLKAINEO.localPosition;
				localPosition2.y = 0.7f;
				RenderGroup.LoadingText.ANLKLKAINEO.localPosition = localPosition2;
			}
			else if (!((double)aspect >= 0.6666666))
			{
				Vector3 localPosition3 = RenderGroup.LoadingText.ANLKLKAINEO.localPosition;
				localPosition3.y = 1.45f;
				RenderGroup.LoadingText.ANLKLKAINEO.localPosition = localPosition3;
			}
			float num = RenderGroup.CurrentMainCamera.orthographicSize * 2f;
			float x = aspect * num;
			CarLoadingBackground.transform.localScale = new Vector3(x, num);
		}

		public void OnDestroy()
		{
			Instance = null;
		}

		private IEnumerator NKAHLAGJIME<T>(string LCCKDPIBKPJ, Action<UnityEngine.Object> ENHHMGIJPOA)
		{
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			ResourceRequest resourceRequest = Resources.LoadAsync(LCCKDPIBKPJ, typeof(T));
			while (!resourceRequest.isDone && Time.realtimeSinceStartup - realtimeSinceStartup < 10f)
			{
				yield return null;
			}
			if (resourceRequest.asset != null)
			{
				FDOOLENAPCC.Add(resourceRequest.asset);
			}
			if (ENHHMGIJPOA != null)
			{
				ENHHMGIJPOA(resourceRequest.asset);
			}
		}

		private IEnumerator CFCJEGHDJDP(Action IMHLFAHONPP, string JIABOFLJKJA = null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LoadingScreenDisplayer, "Loading Fade In Started");
			bool flag = false;
			string text = null;
			CarLoading.SetActive(false);
			RenderGroup.gameObject.SetActive(true);
			BackgroundSpriteRenderer.enabled = false;
			BackgroundTopSpriteRenderer.enabled = false;
			BackgroundBottomSpriteRenderer.enabled = false;
			RenderGroup.LoadingText.enabled = false;
			Logo.enabled = false;
			LogoShadow.enabled = false;
			CarLoadingBackground.enabled = false;
			RenderGroup.LoadingText.color = new Color(1f, 1f, 1f, 0f);
			bool flag2 = false;
			bool flag3 = false;
			switch (MHNACPEADLF)
			{
			case KLKAGJKCKBE.ToMap:
			{
				int currentLevelNo = LevelBuilder.CurrentLevelNo;
				if (JIABOFLJKJA != null && JIABOFLJKJA.Equals("Refreshing"))
				{
					text = KFNPPFJEONF[KLKAGJKCKBE.Bruno];
				}
				else
				{
					switch (currentLevelNo)
					{
					case 1:
					case 3:
						text = KFNPPFJEONF[KLKAGJKCKBE.Wally];
						break;
					case 2:
						text = KFNPPFJEONF[KLKAGJKCKBE.Bruno];
						break;
					case 4:
						text = KFNPPFJEONF[KLKAGJKCKBE.Cooper];
						break;
					case 5:
						text = KFNPPFJEONF[KLKAGJKCKBE.RandomRocket];
						break;
					default:
					{
						int num = UnityEngine.Random.Range(0, CDPIPMGHLMG.Length);
						text = KFNPPFJEONF[CDPIPMGHLMG[num]];
						break;
					}
					}
				}
				RenderGroup.LoadingText.enabled = true;
				break;
			}
			case KLKAGJKCKBE.Initial:
				flag = true;
				RenderGroup.LoadingText.enabled = true;
				flag3 = true;
				Logo.enabled = true;
				LogoShadow.enabled = true;
				break;
			case KLKAGJKCKBE.Loading:
				flag2 = true;
				CarLoading.SetActive(true);
				CarLoadingBackground.enabled = true;
				CarLoadingBackground.color = CGNOCAJPNPO;
				break;
			case KLKAGJKCKBE.FacebookLoading:
				flag2 = true;
				CarLoading.SetActive(true);
				CarLoadingBackground.enabled = true;
				CarLoadingBackground.color = FAAKILMDOJK;
				break;
			case KLKAGJKCKBE.Rocket:
			case KLKAGJKCKBE.Bomb:
			case KLKAGJKCKBE.Discoball:
			case KLKAGJKCKBE.DoubleBomb:
			case KLKAGJKCKBE.DoubleRocket:
			case KLKAGJKCKBE.RocketBomb:
			case KLKAGJKCKBE.Bruno:
			case KLKAGJKCKBE.Wally:
			case KLKAGJKCKBE.Cooper:
			case KLKAGJKCKBE.RandomRocket:
				text = KFNPPFJEONF[MHNACPEADLF];
				RenderGroup.LoadingText.enabled = true;
				break;
			default:
				text = KFNPPFJEONF[KLKAGJKCKBE.Bruno];
				break;
			}
			if (flag2)
			{
				CarAnimation.skeletonDataAsset = LJDGBAMMEAM.OPKJBDGCGHC("SpineAnimations/LoadingCar/loading_anim_SkeletonData", "SpineAnimations/LoadingCar/loading_anim");
				CarAnimation.CENGNKJGOGP = "loading_animation";
				CarAnimation.loop = true;
				CarAnimation.Initialize(true);
			}
			LoadingText.FCJBBPHFNPJ = ((JIABOFLJKJA != null) ? NKILHODNBDE.GHBGCADFLFB(JIABOFLJKJA) : NKILHODNBDE.GHBGCADFLFB("Loading"));
			if (JIABOFLJKJA != null)
			{
				LoadingText.enabled = true;
			}
			if (flag)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LoadingScreenDisplayer, "Will load background.");
				BackgroundSpriteRenderer.color = new Color(1f, 1f, 1f, 0f);
				TextAsset hKLFKEFJAAE = Resources.Load<TextAsset>("Loading/Splash_Screen");
				Sprite sprite = LJDGBAMMEAM.FPAMEPBLDPL(hKLFKEFJAAE, 1024, 1822);
				BackgroundSpriteRenderer.enabled = true;
				BackgroundSpriteRenderer.sprite = sprite;
				TextAsset hKLFKEFJAAE2 = Resources.Load<TextAsset>("Loading/Splash_Screen_Up");
				sprite = LJDGBAMMEAM.FPAMEPBLDPL(hKLFKEFJAAE2, 1024, 215);
				BackgroundTopSpriteRenderer.sprite = sprite;
				TextAsset hKLFKEFJAAE3 = Resources.Load<TextAsset>("Loading/Splash_Screen_Down");
				sprite = LJDGBAMMEAM.FPAMEPBLDPL(hKLFKEFJAAE3, 1024, 215);
				BackgroundBottomSpriteRenderer.sprite = sprite;
				if (InitialSceneController.Instance != null)
				{
					UnityEngine.Object.Destroy(InitialSceneController.Instance.gameObject);
					InitialSceneController.Instance = null;
				}
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LoadingScreenDisplayer, "Backgrounds completed.");
			}
			if (flag3)
			{
				BackgroundTopSpriteRenderer.enabled = true;
				BackgroundBottomSpriteRenderer.enabled = true;
			}
			if (text != null)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LoadingScreenDisplayer, "Will load info.");
				IEnumerator enumerator = NKAHLAGJIME<GameObject>(text, delegate(UnityEngine.Object HKLFKEFJAAE)
				{
					if (!(HKLFKEFJAAE == null))
					{
						GameObject gameObject = UnityEngine.Object.Instantiate(HKLFKEFJAAE) as GameObject;
						if (!(gameObject == null))
						{
							gameObject.transform.SetParent(RenderGroup.CenterPanel.transform);
							LoadingInfoDialog component = gameObject.GetComponent<LoadingInfoDialog>();
							if (!(component == null))
							{
								EGJHPNKHFOL = component;
								component.Init(RenderGroup.CurrentMainCamera);
								component.Fade(0f, 1f, 0.3f);
							}
						}
					}
				});
				while (enumerator.MoveNext())
				{
					yield return enumerator.Current;
				}
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LoadingScreenDisplayer, "Info load completed.");
			}
			KEENDFGFCOF(0f, 1f, InstantFade || MHNACPEADLF == KLKAGJKCKBE.Initial);
			JIEEDECENPC.OnComplete(delegate
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LoadingScreenDisplayer, "Loading Fade In Completed");
				if (IMHLFAHONPP != null)
				{
					IMHLFAHONPP();
				}
				JIEEDECENPC = null;
			});
			yield return JIEEDECENPC.WaitForCompletion();
		}

		public void ShowLoading(KLKAGJKCKBE PIEJMAICAND = KLKAGJKCKBE.Default, Action IMHLFAHONPP = null, string MMBIKIOIIPH = null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LoadingScreenDisplayer, "Loading screen with (1) type {0}", PIEJMAICAND);
			CDIJIMCMCOE = true;
			MHNACPEADLF = PIEJMAICAND;
			GNIKMMDHAPL();
			StartCoroutine(CFCJEGHDJDP(IMHLFAHONPP, MMBIKIOIIPH));
		}

		private void GNIKMMDHAPL()
		{
			if (JIEEDECENPC != null && JIEEDECENPC.IsPlaying())
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LoadingScreenDisplayer, "Killing old sequence");
				JIEEDECENPC.Kill();
				JIEEDECENPC = null;
			}
		}

		public IEnumerator GetShowLoadingEnumerator(KLKAGJKCKBE PIEJMAICAND = KLKAGJKCKBE.Default, Action IMHLFAHONPP = null, string MMBIKIOIIPH = null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LoadingScreenDisplayer, "Loading screen with (2) type {0}", PIEJMAICAND);
			CDIJIMCMCOE = true;
			MHNACPEADLF = PIEJMAICAND;
			GNIKMMDHAPL();
			return CFCJEGHDJDP(IMHLFAHONPP, MMBIKIOIIPH);
		}

		public void StartFadeOut(Action IMHLFAHONPP = null, bool GFEKACNPGPP = false)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LoadingScreenDisplayer, "Fade out requested.");
			if (GFEKACNPGPP)
			{
				BackgroundSpriteRenderer.enabled = false;
				CarLoading.SetActive(false);
			}
			if (EGJHPNKHFOL != null)
			{
				EGJHPNKHFOL.Fade(1f, 0f, 0.3f);
			}
			KEENDFGFCOF(1f, 0f, InstantFade);
			JIEEDECENPC.OnComplete(delegate
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LoadingScreenDisplayer, "Loading Fade Out Completed");
				CDIJIMCMCOE = false;
				RenderGroup.gameObject.SetActive(false);
				BackgroundSpriteRenderer.sprite = null;
				if (FDOOLENAPCC.Count > 0)
				{
					while (FDOOLENAPCC.Count > 0)
					{
						int index = FDOOLENAPCC.Count - 1;
						FDOOLENAPCC.RemoveAt(index);
					}
					if (EGJHPNKHFOL != null)
					{
						UnityEngine.Object.Destroy(EGJHPNKHFOL.gameObject);
						EGJHPNKHFOL = null;
					}
				}
				if (CarLoading.activeSelf)
				{
					MeshRenderer component = CarAnimation.GetComponent<MeshRenderer>();
					if (component != null && component.materials.Length > 0)
					{
						Resources.UnloadAsset(component.materials[0].mainTexture);
					}
				}
				else
				{
					Resources.UnloadUnusedAssets();
				}
				if (IMHLFAHONPP != null)
				{
					IMHLFAHONPP();
				}
				JIEEDECENPC = null;
			});
		}

		private void KEENDFGFCOF(float EHGOOEHDNMM, float AHPGGJALELA, bool ALKBJGIPKEE = false)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LoadingScreenDisplayer, "DoFade > start:{0} end:{1} instant:{2}", EHGOOEHDNMM, AHPGGJALELA, ALKBJGIPKEE);
			GNIKMMDHAPL();
			Color white = Color.white;
			JIEEDECENPC = DOTween.Sequence();
			if (ALKBJGIPKEE)
			{
				white.a = AHPGGJALELA;
				RenderGroup.CurrentBackgroundSpriteRenderer.color = white;
				RenderGroup.LoadingText.color = white;
				Logo.color = white;
				Color white2 = Color.white;
				white2.a = 0.392f;
				LogoShadow.color = white2;
				return;
			}
			white.a = EHGOOEHDNMM;
			RenderGroup.CurrentBackgroundSpriteRenderer.color = white;
			RenderGroup.LoadingText.color = white;
			JIEEDECENPC.Append(RenderGroup.CurrentBackgroundSpriteRenderer.DOFade(AHPGGJALELA, 0.3f));
			if (BackgroundTopSpriteRenderer.sprite != null && BackgroundTopSpriteRenderer.color.a > 0f)
			{
				JIEEDECENPC.Join(BackgroundTopSpriteRenderer.DOFade(AHPGGJALELA, 0.3f));
				JIEEDECENPC.Join(BackgroundBottomSpriteRenderer.DOFade(AHPGGJALELA, 0.3f));
			}
			if (RenderGroup.LoadingText.enabled)
			{
				JIEEDECENPC.Join(RenderGroup.LoadingText.OCHJNKODKNO(AHPGGJALELA, 0.3f));
			}
			if (Logo.enabled && Logo != null)
			{
				JIEEDECENPC.Join(Logo.DOFade(AHPGGJALELA, 0.3f));
				JIEEDECENPC.Join(LogoShadow.DOFade(AHPGGJALELA, 0.3f));
				JIEEDECENPC.InsertCallback(0.3f, delegate
				{
					Logo.sprite = null;
					LogoShadow.sprite = null;
					BackgroundTopSpriteRenderer.sprite = null;
					BackgroundBottomSpriteRenderer.sprite = null;
				});
			}
		}

		[CompilerGenerated]
		private void NDEFNHHOHPN()
		{
			Logo.sprite = null;
			LogoShadow.sprite = null;
			BackgroundTopSpriteRenderer.sprite = null;
			BackgroundBottomSpriteRenderer.sprite = null;
		}
	}
}
