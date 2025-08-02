using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items.SpecialItems;
using Assets.Scripts.GamePlayScene.Touches;
using Assets.Scripts.GamePlayScene.UI;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Tutorials
{
	public class TutorialManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class OMHLGPGICLN
		{
			internal BoosterManager DMOIJBGJHML;

			internal int IEMNPLMPCNF;

			internal TutorialManager PDAPIGLEPGC;

			internal void AGFNGEFDHLA(NAAHKHPBAPA P_0)
			{
				DMOIJBGJHML.ButtonsLocked = true;
				DMOIJBGJHML.BoosterButtonColliders[IEMNPLMPCNF].tag = "SpriteButton";
				DMOIJBGJHML.OnItemClicked = null;
				PDAPIGLEPGC.Next(null, true);
			}
		}

		private const int LFCLBGGENPP = 160;

		public static bool ShouldDisplayBoosterTutorial;

		public static bool ShouldDisplayPrelevelTutorial;

		public GameObject TutorialCellDisplayerPrefab;

		public GameObject TutorialGoalDisplayerPrefab;

		public GameObject TutorialMovesDisplayerPrefab;

		public GameObject TutorialBoosterDisplayerPrefab;

		public GameObject DialogPanel;

		public GameObject ButtonPanel;

		public GameObject RedPanel;

		public TextMeshPro TutorialText;

		public GameObject ConfirmationButton;

		public SpriteRenderer BackImage;

		public SpriteRenderer Arrow;

		public SpriteRenderer ArrowShadow;

		public Animator FingerAnimator;

		public GameObject FingerAnimationContainer;

		public BoxCollider2D BackgroundCollider;

		public Sprite ArrowMini;

		public static bool ForceShowTutorials;

		public static bool TutorialActive;

		public static bool IsThereComboTutorial;

		private readonly TutorialCellDisplayer[,] HPGILDMEKCI = new TutorialCellDisplayer[9, 9];

		private readonly HashSet<Cell> MKAOJIGPOHP = new HashSet<Cell>();

		public static bool ShowBoosterPanel = true;

		private LevelBuilder IDJEJKNPHFH;

		private BIMAONBKNOP HKOEDNGMACH;

		private GameObject HJLKGIGBNHP;

		private GameObject BGGGBAILHIF;

		private List<TutorialCellDisplayer> LIMDOLKFJDH;

		private int LAGIFMAIEBO;

		private int AKCJHJJMFCE;

		public static TutorialManager Instance;

		public LevelBuilder GIMBEKBFKMJ
		{
			get
			{
				return IDJEJKNPHFH;
			}
		}

		public static BIMAONBKNOP GetTutorialForLevel(int KIGOGMKCDKN, bool CELKBIHEFHP)
		{
			if (CELKBIHEFHP)
			{
				switch (KIGOGMKCDKN)
				{
				case 1:
					return new CELGMCILADL();
				case 4:
					return new PMJCNCKPAGL();
				case 10:
					return (!BBKKIAAILBA("Tutorial10") || GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Hammer) <= 0) ? null : new BGHAMOMOAPG();
				case 11:
					return new IEHEPAFHKFG();
				case 13:
					return (!BBKKIAAILBA("Tutorial13")) ? null : new FDDNFODAEJJ();
				case 17:
					return (!BBKKIAAILBA("Tutorial17")) ? null : new KJGDDGFBCFL();
				case 19:
					return (!BBKKIAAILBA("Tutorial20")) ? null : new MNBFECHJMDB();
				case 21:
					return new PHCJCAPOJLA();
				case 31:
					return new ANCKBOHMNJI();
				case 41:
					return new CGLGJGDFPAL();
				default:
					return null;
				}
			}
			switch (KIGOGMKCDKN)
			{
			case 1:
				return new GJLNPIBIFOH();
			case 2:
				return new JOPNKHABPKE();
			case 3:
				return new EONAPAEGAJD();
			case 4:
				return new JGOEOJPJJOB();
			case 5:
				return new HCOJMIFFGEI();
			case 6:
				return new FICHGANLHPB();
			case 9:
				return new JFNCKIKOGGP();
			case 10:
				return (!BBKKIAAILBA("Tutorial10") || GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Hammer) <= 0) ? null : new FBIBEHBBMMP();
			case 13:
				return (!BBKKIAAILBA("Tutorial13")) ? null : new FDDNFODAEJJ();
			case 15:
				return new IEHEPAFHKFG();
			case 17:
				return (!BBKKIAAILBA("Tutorial17")) ? null : new KJGDDGFBCFL();
			case 20:
				return (!BBKKIAAILBA("Tutorial20")) ? null : new MNBFECHJMDB();
			case 21:
				return new HKKNJPEOJIM();
			case 31:
				return new FIDMIDNBCED();
			case 41:
				return new DDDEONPDABD();
			case 51:
				return new EJJDKGHHAHM();
			case 61:
				return new JOLNECDMNCC();
			case 71:
				return new EJEJIFBMFJA();
			case 81:
				return new IMAAMJPELHC();
			case 101:
				return new FCFGPLKJJNO();
			case 121:
				return new IHBIMHIAMBC();
			case 141:
				return new KJICFKIAAHA();
			case 161:
				return new CNAHPNEMOEH();
			case 181:
				return new PBMINMLHNEM();
			case 201:
				return new EKDHJFCMELC();
			case 241:
				return new KPDDEJLOONC();
			case 281:
				return new DELAAIMMAHE();
			case 321:
				return new CCJDHAMHNGF();
			case 351:
				return new IAMDCKJJJIH();
			case 401:
				return new JOHKPPODFFJ();
			case 451:
				return new LHAKOMAPGAA();
			case 501:
				return new JALHNBCDMIA();
			case 551:
				return new DFNFJMCJMIK();
			case 601:
				return new IMHMOJHNNOE();
			case 651:
				return new PFIFFNKEJIH();
			case 701:
				return new ABJDEOFGEPI();
			case 751:
				return new HONDPMDGIAH();
			case 801:
				return new KMHKODHNHFK();
			case 851:
				return new HDOBNANOPLM();
			case 901:
				return new FHDKPECBKEE();
			case 951:
				return new GEOGKIMPJFC();
			case 1001:
				return new FFIPDNKFBKM();
			case 1101:
				return new HNNHHKJOADE();
			case 1201:
				return new CPGEPCEMCOF();
			case 1301:
				return new PCJPIPMBPDC();
			case 1401:
				return new MJJMMFFKHLI();
			case 1501:
				return new NOBBDBBKCME();
			case 1601:
				return new EOCOMDKCGBB();
			case 1701:
				return new JKFCFEGACJL();
			case 1801:
				return new HCHHJPMCFHF();
			case 1901:
				return new AAMBNEEGGPA();
			case 2001:
				return new JFHJMOAMJAL();
			case 2201:
				return new AEKOOGEIIIH();
			case 2401:
				return new FMJJGKEGCAC();
			case 2601:
				return new OHKOGPNGMIH();
			case 2801:
				return new IPFFKFILBKL();
			default:
				return null;
			}
		}

		public static BIMAONBKNOP GetTutorialForSpecialItem(SpecialItem ALAJBEFFOKB)
		{
			switch (ALAJBEFFOKB.GetItemType())
			{
			case NOALGNJECAD.Bomb:
			case NOALGNJECAD.Rocket:
			case NOALGNJECAD.DiscoBall:
				return (!ForceShowTutorials && HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("TutorialSpecial") != null) ? null : new IFBBDDOBOGI(ALAJBEFFOKB);
			default:
				return null;
			}
		}

		public static BIMAONBKNOP GetTutorialForComboItem(PBLOIKDOPAJ CNKHNFDJJBB)
		{
			NOALGNJECAD cDAJIPHMCDN = CNKHNFDJJBB.CDAJIPHMCDN;
			if (cDAJIPHMCDN == NOALGNJECAD.DoubleBomb || cDAJIPHMCDN == NOALGNJECAD.RocketAndBomb || cDAJIPHMCDN == NOALGNJECAD.DoubleDiscoBall || cDAJIPHMCDN == NOALGNJECAD.DiscoBallAndBomb || cDAJIPHMCDN == NOALGNJECAD.DiscoBallAndRocket)
			{
				return (!ForceShowTutorials && HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("TutorialCombo") != null) ? null : new HHJGFCGAGJG(CNKHNFDJJBB);
			}
			return null;
		}

		private static bool BBKKIAAILBA(string IKNCPEPOKGJ)
		{
			return ForceShowTutorials || !MKINMKEMBPL.GABGKBAKHDP.HEANMKDLPGF(IKNCPEPOKGJ);
		}

		public void Awake()
		{
			LAGIFMAIEBO = SortingLayer.NameToID("Dialogs");
			AKCJHJJMFCE = SortingLayer.NameToID("UI");
			TapListener.Instance.RegisterTutorial(this);
			TutorialActive = true;
			FingerAnimationContainer.SetActive(false);
			BackgroundCollider.enabled = false;
			Instance = this;
		}

		public void OnDestroy()
		{
			Instance = null;
		}

		public void Start()
		{
			if (BoosterTapListener.Instance != null)
			{
				BoosterTapListener.Instance.RegisterTutorial(this);
			}
			Vector3 eAECKBNBAJC = ONCMBJKLKIL.EAECKBNBAJC;
			eAECKBNBAJC.z = -0.1f;
			BackImage.transform.position = eAECKBNBAJC;
			BackImage.transform.localScale = Vector3.one * (ONCMBJKLKIL.NNOBNMCLIBC * 20f);
			Next();
		}

		public void Init(LevelBuilder IPKNOODAMIJ, BIMAONBKNOP BDMFBFDKAJI)
		{
			IDJEJKNPHFH = IPKNOODAMIJ;
			IDJEJKNPHFH.TutorialBearPanel.gameObject.SetActive(true);
			HKOEDNGMACH = BDMFBFDKAJI;
			if (HKOEDNGMACH != null)
			{
				IDJEJKNPHFH.CurrentTopPanel.CharacterAnimationBottom.sortingLayerID = LAGIFMAIEBO;
				IDJEJKNPHFH.CurrentTopPanel.CharacterAnimationBottom.sortingOrder = 2001;
				IDJEJKNPHFH.CurrentTopPanel.CharacterAnimationTop.sortingLayerID = LAGIFMAIEBO;
				IDJEJKNPHFH.CurrentTopPanel.CharacterAnimationTop.sortingOrder = 2005;
				IDJEJKNPHFH.CurrentTopPanel.CharacterAnimationSeparator.sortingLayerID = LAGIFMAIEBO;
				IDJEJKNPHFH.CurrentTopPanel.CharacterAnimationSeparator.sortingOrder = 2002;
				HKOEDNGMACH.DIOELAHNLKJ(this);
			}
			else
			{
				RemoveSelf();
			}
		}

		public void RemoveSelf()
		{
			ShowBoosterPanel = true;
			TutorialActive = false;
			IDJEJKNPHFH.TutorialBearPanel.gameObject.SetActive(false);
			Object.Destroy(base.gameObject);
			TapListener.Instance.RegisterTutorial(null);
			if (BoosterTapListener.Instance != null)
			{
				BoosterTapListener.Instance.RegisterTutorial(null);
			}
			IDJEJKNPHFH.CurrentTopPanel.CharacterAnimationBottom.sortingLayerID = AKCJHJJMFCE;
			IDJEJKNPHFH.CurrentTopPanel.CharacterAnimationBottom.sortingOrder = 12;
			IDJEJKNPHFH.CurrentTopPanel.CharacterAnimationTop.sortingLayerID = AKCJHJJMFCE;
			IDJEJKNPHFH.CurrentTopPanel.CharacterAnimationTop.sortingOrder = 14;
			IDJEJKNPHFH.CurrentTopPanel.CharacterAnimationSeparator.sortingLayerID = AKCJHJJMFCE;
			IDJEJKNPHFH.CurrentTopPanel.CharacterAnimationSeparator.sortingOrder = 19;
		}

		public void Next(Cell BBJPFHPBOHC = null, bool AEGOANBPCGB = false, bool PCCBMIJAFPK = false)
		{
			if (HKOEDNGMACH != null)
			{
				HKOEDNGMACH.BDAKKAIBMIM(BBJPFHPBOHC, AEGOANBPCGB, PCCBMIJAFPK);
			}
		}

		public void ContinueClicked()
		{
			Next();
		}

		public void BackgroundClicked()
		{
			Next(null, false, true);
		}

		public bool CanClick(Cell DLINGFOABLL)
		{
			if (DLINGFOABLL != null && HKOEDNGMACH != null && HKOEDNGMACH.CNFHIFJHOBL && HKOEDNGMACH.BALIENJLCLB != null)
			{
				return HKOEDNGMACH.BALIENJLCLB.Contains(DLINGFOABLL);
			}
			return false;
		}

		private void EOBDANKMCBK(string OEFCOJLNCKP, bool IMKNEHHBGNA)
		{
			DialogPanel.SetActive(true);
			TutorialText.FCJBBPHFNPJ = OEFCOJLNCKP;
			ButtonPanel.SetActive(IMKNEHHBGNA);
			RedPanel.SetActive(!IMKNEHHBGNA);
		}

		public Tweener ShowDialog(string OEFCOJLNCKP, float MLEMEPJJEKN, bool IMKNEHHBGNA)
		{
			EOBDANKMCBK(OEFCOJLNCKP, IMKNEHHBGNA);
			Vector3 position = DialogPanel.transform.position;
			position.y = ONCMBJKLKIL.HINDAIPFFJL.y + MLEMEPJJEKN;
			position.x = 0f;
			DialogPanel.transform.position = position;
			return OIAIIHHKLKI();
		}

		public void RotateArrow(int GGELLLADCFC)
		{
			switch (GGELLLADCFC % 360)
			{
			default:
				ArrowShadow.transform.localPosition = new Vector3(0f, -0.097f, 0f);
				break;
			case 90:
				ArrowShadow.transform.localPosition = new Vector3(-0.097f, 0f, 0f);
				break;
			case 180:
				ArrowShadow.transform.localPosition = new Vector3(0f, 0.097f, 0f);
				break;
			case 270:
				ArrowShadow.transform.localPosition = new Vector3(0.097f, 0f, 0f);
				break;
			}
			Arrow.transform.eulerAngles = new Vector3(0f, 0f, GGELLLADCFC);
		}

		public void HideDialog()
		{
			DialogPanel.SetActive(false);
		}

		public Tweener ShowDialog(string OEFCOJLNCKP, float[] DDMJPLINDMO, bool IMKNEHHBGNA, float DGLOHLPKABM = 5.9f)
		{
			TutorialText.DGLOHLPKABM = DGLOHLPKABM;
			EOBDANKMCBK(OEFCOJLNCKP, IMKNEHHBGNA);
			Vector3 position = IDJEJKNPHFH.CellContainer.transform.TransformPoint(new Vector3(DDMJPLINDMO[0], DDMJPLINDMO[1], 0f));
			DialogPanel.transform.position = position;
			return OIAIIHHKLKI();
		}

		private Tweener OIAIIHHKLKI()
		{
			DialogPanel.transform.localScale = Vector3.one * 0.5f;
			return DialogPanel.transform.DOScale(Vector3.one * 0.85f, 0.4f).SetEase(Ease.OutBack).OnComplete(delegate
			{
				HKOEDNGMACH.CNFHIFJHOBL = true;
			});
		}

		public void ShowFingerAnimation(Vector3 LLAEDBFNCCP, Vector3 BMIOECELGCA)
		{
			FingerAnimationContainer.SetActive(true);
			FingerAnimationContainer.transform.position = BMIOECELGCA;
			FingerAnimationContainer.transform.localScale = Vector3.one * 0.1f;
			FingerAnimationContainer.transform.DOScale(1f, 0.4f);
		}

		public void HideFingerAnimation()
		{
			if (!(FingerAnimator == null))
			{
				FingerAnimator.transform.DOKill();
				FingerAnimationContainer.SetActive(false);
			}
		}

		public void ShowGoalHighlights()
		{
			if (!(HJLKGIGBNHP != null))
			{
				HJLKGIGBNHP = Object.Instantiate(TutorialGoalDisplayerPrefab, IDJEJKNPHFH.CurrentTopPanel.GoalPanelReference);
				if (HJLKGIGBNHP != null)
				{
					HJLKGIGBNHP.transform.localPosition = Vector3.zero;
					HJLKGIGBNHP.transform.SetParent(base.transform);
					HJLKGIGBNHP.transform.localScale = IDJEJKNPHFH.CurrentTopPanel.GoalPanelReference.lossyScale;
				}
				GIMBEKBFKMJ.CurrentTopPanel.ChangeLabelSorting(IDJEJKNPHFH.CurrentTopPanel.GoalLabelContainer.transform, true);
			}
		}

		public void ShowMovesHighlight()
		{
			if (!(BGGGBAILHIF != null))
			{
				BGGGBAILHIF = Object.Instantiate(TutorialMovesDisplayerPrefab, IDJEJKNPHFH.CurrentTopPanel.MovesLeftText.ANLKLKAINEO);
				if (BGGGBAILHIF != null)
				{
					BGGGBAILHIF.transform.localPosition = Vector3.zero;
					BGGGBAILHIF.transform.SetParent(base.transform);
					BGGGBAILHIF.transform.localScale = IDJEJKNPHFH.CurrentTopPanel.MovesLabelContainer.transform.lossyScale;
				}
				GIMBEKBFKMJ.CurrentTopPanel.ChangeLabelSorting(IDJEJKNPHFH.CurrentTopPanel.MovesLabelContainer.transform, true);
			}
		}

		public void HideGoalHighlights()
		{
			if (HJLKGIGBNHP != null)
			{
				Object.Destroy(HJLKGIGBNHP.gameObject);
			}
			HJLKGIGBNHP = null;
			if (BGGGBAILHIF != null)
			{
				Object.Destroy(BGGGBAILHIF.gameObject);
			}
			BGGGBAILHIF = null;
			GIMBEKBFKMJ.CurrentTopPanel.ChangeLabelSorting(IDJEJKNPHFH.CurrentTopPanel.GoalLabelContainer.transform);
			GIMBEKBFKMJ.CurrentTopPanel.ChangeLabelSorting(IDJEJKNPHFH.CurrentTopPanel.MovesLabelContainer.transform);
		}

		public void HideBackground()
		{
			BackImage.enabled = true;
			BackImage.color = new Color(1f, 1f, 1f, 0f);
		}

		public Tweener BackgroundFadeIn()
		{
			BackImage.enabled = true;
			BackImage.color = new Color(1f, 1f, 1f, 0f);
			if (LIMDOLKFJDH == null || LIMDOLKFJDH.Count <= 0)
			{
				return BackImage.DOFade(32f / 51f, 0.3f);
			}
			int count = LIMDOLKFJDH.Count;
			for (int i = 0; i < count; i++)
			{
				LIMDOLKFJDH[i].FadeIn();
			}
			return BackImage.DOFade(32f / 51f, 0.3f);
		}

		public void ShowHighlighCells()
		{
			if (LIMDOLKFJDH == null)
			{
				LIMDOLKFJDH = new List<TutorialCellDisplayer>();
			}
			int count = HKOEDNGMACH.BALIENJLCLB.Count;
			for (int i = 0; i < count; i++)
			{
				Cell cell = HKOEDNGMACH.BALIENJLCLB[i];
				GameObject gameObject = Object.Instantiate(TutorialCellDisplayerPrefab, base.transform);
				if (!(gameObject == null))
				{
					gameObject.transform.position = cell.GetFrozenPosition();
					TutorialCellDisplayer component = gameObject.GetComponent<TutorialCellDisplayer>();
					HPGILDMEKCI[cell.X, cell.Y] = component;
					MKAOJIGPOHP.Add(cell);
					LIMDOLKFJDH.Add(component);
				}
			}
			for (int j = 0; j < 9; j++)
			{
				for (int k = 0; k < 9; k++)
				{
					TutorialCellDisplayer tutorialCellDisplayer = HPGILDMEKCI[j, k];
					if (!(tutorialCellDisplayer == null))
					{
						bool flag = j > 0 && HPGILDMEKCI[j - 1, k] != null;
						bool flag2 = j < 8 && HPGILDMEKCI[j + 1, k] != null;
						bool flag3 = k < 8 && HPGILDMEKCI[j, k + 1] != null;
						bool flag4 = k > 0 && HPGILDMEKCI[j, k - 1] != null;
						if (!flag && !flag3)
						{
							tutorialCellDisplayer.TopLeft.gameObject.SetActive(true);
						}
						if (!flag2 && !flag3)
						{
							tutorialCellDisplayer.TopRight.gameObject.SetActive(true);
						}
						if (!flag && !flag4)
						{
							tutorialCellDisplayer.BottomLeft.gameObject.SetActive(true);
						}
						if (!flag2 && !flag4)
						{
							tutorialCellDisplayer.BottomRight.gameObject.SetActive(true);
						}
					}
				}
			}
		}

		public void ShowHighlightCellsWithBorders()
		{
			if (LIMDOLKFJDH == null)
			{
				LIMDOLKFJDH = new List<TutorialCellDisplayer>();
			}
			int count = HKOEDNGMACH.BALIENJLCLB.Count;
			for (int i = 0; i < count; i++)
			{
				Cell cell = HKOEDNGMACH.BALIENJLCLB[i];
				GameObject gameObject = Object.Instantiate(TutorialCellDisplayerPrefab, base.transform);
				if (!(gameObject == null))
				{
					gameObject.transform.position = cell.GetFrozenPosition();
					TutorialCellDisplayer component = gameObject.GetComponent<TutorialCellDisplayer>();
					HPGILDMEKCI[cell.X, cell.Y] = component;
					MKAOJIGPOHP.Add(cell);
					LIMDOLKFJDH.Add(component);
				}
			}
			for (int j = 0; j < 9; j++)
			{
				for (int k = 0; k < 9; k++)
				{
					TutorialCellDisplayer tutorialCellDisplayer = HPGILDMEKCI[j, k];
					if (!(tutorialCellDisplayer == null))
					{
						bool flag = j > 0 && HPGILDMEKCI[j - 1, k] != null;
						bool flag2 = j < 8 && HPGILDMEKCI[j + 1, k] != null;
						bool flag3 = k < 8 && HPGILDMEKCI[j, k + 1] != null;
						bool flag4 = k > 0 && HPGILDMEKCI[j, k - 1] != null;
						if (!flag && !flag3)
						{
							tutorialCellDisplayer.TopLeft.gameObject.SetActive(true);
							tutorialCellDisplayer.TopLeft.transform.localPosition = new Vector3(-0.42f, 0.52f);
							tutorialCellDisplayer.TopLeft.transform.localScale = Vector3.one * 1.5f;
						}
						if (!flag2 && !flag3)
						{
							tutorialCellDisplayer.TopRight.gameObject.SetActive(true);
							tutorialCellDisplayer.TopRight.transform.localPosition = new Vector3(0.42f, 0.52f);
							tutorialCellDisplayer.TopRight.transform.localScale = Vector3.one * 1.5f;
						}
						if (!flag && !flag4)
						{
							tutorialCellDisplayer.BottomLeft.gameObject.SetActive(true);
							tutorialCellDisplayer.BottomLeft.transform.localPosition = new Vector3(-0.42f, -0.52f);
							tutorialCellDisplayer.BottomLeft.transform.localScale = Vector3.one * 1.5f;
						}
						if (!flag2 && !flag4)
						{
							tutorialCellDisplayer.BottomRight.gameObject.SetActive(true);
							tutorialCellDisplayer.BottomRight.transform.localPosition = new Vector3(0.42f, -0.52f);
							tutorialCellDisplayer.BottomRight.transform.localScale = Vector3.one * 1.5f;
						}
						if (!flag || !flag2)
						{
							tutorialCellDisplayer.Mask.localScale = Vector3.one * 1.2f;
						}
						if (!flag3)
						{
							Vector3 localScale = tutorialCellDisplayer.Mask.localScale;
							localScale.y = 1.56f;
							tutorialCellDisplayer.Mask.localScale = localScale;
						}
						if (!flag4)
						{
							Vector3 localScale2 = tutorialCellDisplayer.Mask.localScale;
							localScale2.y = 1.24f;
							tutorialCellDisplayer.Mask.localScale = localScale2;
						}
					}
				}
			}
		}

		public void ClearCellHighlights()
		{
			if (LIMDOLKFJDH != null && LIMDOLKFJDH.Count > 0)
			{
				while (LIMDOLKFJDH.Count > 0)
				{
					int index = LIMDOLKFJDH.Count - 1;
					Object.Destroy(LIMDOLKFJDH[index].gameObject);
					LIMDOLKFJDH.RemoveAt(index);
				}
			}
		}

		public Vector3 GetGlobalCellPosition(float AMFCENFNAJJ, float CNLILOEEBOJ)
		{
			return IDJEJKNPHFH.CellContainer.transform.TransformPoint(new Vector3(AMFCENFNAJJ, CNLILOEEBOJ, 0f));
		}

		public void BoosterButtonToFront(int IEMNPLMPCNF)
		{
			BoosterManager currentBoosterManager = SettingsPanel.Instance.CurrentBoosterManager;
			currentBoosterManager.BaseSortingOrder = 1000;
			currentBoosterManager.BoosterButtons[IEMNPLMPCNF].sortingLayerID = LAGIFMAIEBO;
			currentBoosterManager.BoosterImages[IEMNPLMPCNF].sortingLayerID = LAGIFMAIEBO;
			currentBoosterManager.BoosterAmounts[IEMNPLMPCNF].IKJGCDCDCCJ = LAGIFMAIEBO;
			currentBoosterManager.BoosterButtons[IEMNPLMPCNF].sortingOrder = 1020;
			currentBoosterManager.BoosterImages[IEMNPLMPCNF].sortingOrder = 1021;
			currentBoosterManager.BoosterAmounts[IEMNPLMPCNF].GDDGFAKOCIL = 1022;
			SettingsPanel.Instance.CurrentBoosterManager.ChangeParticleSorting(LAGIFMAIEBO, 400);
		}

		public void BoosterButtonToBack(int IEMNPLMPCNF)
		{
			BoosterManager currentBoosterManager = SettingsPanel.Instance.CurrentBoosterManager;
			currentBoosterManager.BaseSortingOrder = 0;
			currentBoosterManager.BoosterButtons[IEMNPLMPCNF].sortingLayerID = AKCJHJJMFCE;
			currentBoosterManager.BoosterImages[IEMNPLMPCNF].sortingLayerID = AKCJHJJMFCE;
			currentBoosterManager.BoosterAmounts[IEMNPLMPCNF].IKJGCDCDCCJ = AKCJHJJMFCE;
			currentBoosterManager.BoosterButtons[IEMNPLMPCNF].sortingOrder = 20;
			currentBoosterManager.BoosterImages[IEMNPLMPCNF].sortingOrder = 21;
			currentBoosterManager.BoosterAmounts[IEMNPLMPCNF].GDDGFAKOCIL = 22;
			SettingsPanel.Instance.CurrentBoosterManager.ChangeParticleSorting(AKCJHJJMFCE, 400);
		}

		public void HideBoosterHighlight(int IEMNPLMPCNF)
		{
			IEMNPLMPCNF = Mathf.Clamp(IEMNPLMPCNF, 0, 3);
			BoosterManager currentBoosterManager = SettingsPanel.Instance.CurrentBoosterManager;
			BoosterButtonToBack(IEMNPLMPCNF);
			currentBoosterManager.BoosterButtonColliders[IEMNPLMPCNF].tag = "SpriteButton";
			currentBoosterManager.OnItemClicked = null;
		}

		public void UnlockBoosterButtons()
		{
			BoosterManager currentBoosterManager = SettingsPanel.Instance.CurrentBoosterManager;
			currentBoosterManager.ButtonsLocked = false;
		}

		public void ShowBoosterHighlight(int IEMNPLMPCNF)
		{
			IEMNPLMPCNF = Mathf.Clamp(IEMNPLMPCNF, 0, 3);
			BoosterManager DMOIJBGJHML = SettingsPanel.Instance.CurrentBoosterManager;
			BoosterButtonToFront(IEMNPLMPCNF);
			DMOIJBGJHML.BoosterButtonColliders[IEMNPLMPCNF].tag = "DialogSpriteButton";
			DMOIJBGJHML.OnItemClicked = delegate
			{
				DMOIJBGJHML.ButtonsLocked = true;
				DMOIJBGJHML.BoosterButtonColliders[IEMNPLMPCNF].tag = "SpriteButton";
				DMOIJBGJHML.OnItemClicked = null;
				Next(null, true);
			};
		}

		[CompilerGenerated]
		private void MINHLEHHPKP()
		{
			HKOEDNGMACH.CNFHIFJHOBL = true;
		}
	}
}
