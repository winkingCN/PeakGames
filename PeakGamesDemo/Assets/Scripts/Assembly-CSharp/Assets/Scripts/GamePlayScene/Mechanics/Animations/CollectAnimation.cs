using System.Collections;
using Assets.Scripts.GamePlayScene.UI;
using UnityEngine;
using UnityEngine.Rendering;

namespace Assets.Scripts.GamePlayScene.Mechanics.Animations
{
	public class CollectAnimation : MonoBehaviour
	{
		public SpriteRenderer CollectSpriteRenderer;

		public Animator CollectAnimator;

		[HideInInspector]
		public Cell ReferencedCell;

		[HideInInspector]
		public KFCEILFGADG CurrentLevel;

		[HideInInspector]
		public float CurveDuration;

		[HideInInspector]
		public NOALGNJECAD GoalType;

		[HideInInspector]
		public Vector3 MiddlePoint;

		[HideInInspector]
		public CaravanTopPanel TopPanel;

		[HideInInspector]
		public int TopPanelGoalId;

		[HideInInspector]
		public CKKKELDIOLD CollectSorting;

		[HideInInspector]
		public Vector3 TargetPosition;

		[HideInInspector]
		public float XDelay;

		[HideInInspector]
		public float YDelay;

		private int JGFFOBIOJDM;

		private bool EKDBBIIFGMK;

		private bool DBGBDFCPKCP = true;

		private ParticlePlayer MHMIDCKIHOD;

		public static PIHMIJMOBJB duck;

		public static PIHMIJMOBJB carrot;

		public static PIHMIJMOBJB solidColor;

		public static PIHMIJMOBJB defaultStrategy;

		public static PIHMIJMOBJB penguin;

		public static PIHMIJMOBJB bird;

		public static PIHMIJMOBJB ufo;

		public static PIHMIJMOBJB gold;

		public float GoalImageScale = 1f;

		public SortingGroup ShadowSortingGroup;

		public SortingGroup SortingGroup;

		public Transform AnimationTransform;

		public SpriteRenderer[] SpriteRenderers;

		public void Awake()
		{
			DIOELAHNLKJ();
		}

		protected void DIOELAHNLKJ()
		{
			CollectSorting = IPPOGIEPKEN.Collecting.EFLCPKAFOBA();
			if (defaultStrategy == null)
			{
				duck = new CHNMJAGKGOL();
				carrot = new AAIDOAKCCHF();
				defaultStrategy = new GPDHNEPBDFP();
				solidColor = new BPAHGMICGHG();
				penguin = new LPKJDFDMGEC();
				bird = new HDDDNLINKFO();
				ufo = new LKGNGPNLEDE();
				gold = new FJFLOLGAOKD();
			}
		}

		public void SetParticle(ParticlePlayer BEDKKJIKDCM)
		{
			MHMIDCKIHOD = BEDKKJIKDCM;
			MHMIDCKIHOD.transform.SetParent(base.transform);
			MHMIDCKIHOD.transform.localPosition = Vector3.zero;
		}

		public CollectAnimation Prepare(KFCEILFGADG MGOFDOMDLCO, NOALGNJECAD ECOPIDONACO, CKKKELDIOLD IBBBMACIBGK, Sprite MJOJAOIHCIO, Cell EEABGAIFMCP)
		{
			CurrentLevel = MGOFDOMDLCO;
			MGOFDOMDLCO.LCKKMCJDDBC(ECOPIDONACO);
			if (EKDBBIIFGMK)
			{
				return this;
			}
			EKDBBIIFGMK = true;
			MGOFDOMDLCO.DJNEAFJLFIH(ECOPIDONACO);
			MGOFDOMDLCO.OEOBPBFCEPB[(int)ECOPIDONACO]++;
			MGOFDOMDLCO.MLAGNJGFOND(ECOPIDONACO);
			ReferencedCell = EEABGAIFMCP;
			GoalType = ECOPIDONACO;
			TopPanel = CurrentLevel.GIMBEKBFKMJ.CurrentTopPanel;
			TopPanelGoalId = TopPanel.FindGoalIndex(GoalType);
			Transform transform = TopPanel.GoalUIList[TopPanelGoalId].GoalImage.transform;
			TargetPosition = transform.position;
			FallManager.IncreaseStatAnimation();
			if (MJOJAOIHCIO == null)
			{
				MJOJAOIHCIO = SharedImageLibrary.Instance.GetGoalSpriteByItemType(ECOPIDONACO);
			}
			GoalImageScale = transform.parent.localScale.x * SharedImageLibrary.Instance.GoalImageScale(ECOPIDONACO);
			base.transform.localScale = Vector3.one;
			if (CollectSpriteRenderer != null)
			{
				CollectSpriteRenderer.sprite = MJOJAOIHCIO;
			}
			UpdateSorting(IBBBMACIBGK);
			if (CollectManager.Instance != null)
			{
				CollectManager.Instance.Register(this);
			}
			return this;
		}

		public virtual void UpdateSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			if (CollectSpriteRenderer != null)
			{
				CollectSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM;
				CollectSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			}
		}

		protected virtual void LOKNAOINCHB(int CMAJLIAELDP)
		{
			if (CollectSpriteRenderer != null)
			{
				CollectSpriteRenderer.sortingOrder = CMAJLIAELDP;
			}
		}

		public void InsertDelays(HMPAMDCECFJ FMFABAKPMLB, Cell AGAPCDLKLLK)
		{
			DBGBDFCPKCP = FMFABAKPMLB.NPGABPICIAD;
			int num = FMFABAKPMLB.FGMDLNBGFJB(AGAPCDLKLLK.X);
			YDelay = AGAPCDLKLLK.Y - num;
			XDelay = AGAPCDLKLLK.X - FMFABAKPMLB.DGMLPAAGIJF;
			if (!DBGBDFCPKCP)
			{
				XDelay = (float)(FMFABAKPMLB.BFBEDEPAOLB - FMFABAKPMLB.DGMLPAAGIJF) - XDelay;
			}
			if (CollectSpriteRenderer != null)
			{
				LOKNAOINCHB(CollectSpriteRenderer.sortingOrder - 50 + (int)YDelay);
			}
			JGFFOBIOJDM = (int)YDelay;
		}

		public void StartAnimation()
		{
			StartCoroutine(WaitOneFrameAndStart());
		}

		public IEnumerator WaitOneFrameAndStart()
		{
			yield return null;
			switch (GoalType)
			{
			case NOALGNJECAD.Duck:
			case NOALGNJECAD.GiantDuck:
				duck.HCGFKKEMMLL(this);
				break;
			case NOALGNJECAD.Carrot:
				carrot.HCGFKKEMMLL(this);
				break;
			case NOALGNJECAD.Bird:
				bird.HCGFKKEMMLL(this);
				break;
			case NOALGNJECAD.Penguin:
				penguin.HCGFKKEMMLL(this);
				break;
			case NOALGNJECAD.Ufo:
				ufo.HCGFKKEMMLL(this);
				break;
			case NOALGNJECAD.Gold:
				gold.HCGFKKEMMLL(this);
				break;
			case NOALGNJECAD.SolidColor1:
			case NOALGNJECAD.SolidColor2:
			case NOALGNJECAD.SolidColor3:
			case NOALGNJECAD.SolidColor4:
			case NOALGNJECAD.SolidColor5:
			case NOALGNJECAD.SolidColor6:
				solidColor.HCGFKKEMMLL(this);
				break;
			default:
				defaultStrategy.HCGFKKEMMLL(this);
				break;
			}
			yield return null;
		}

		public void UpdateSortingAfterDownAnimation()
		{
			if (CollectSpriteRenderer != null)
			{
				CollectSpriteRenderer.sortingLayerID = CollectSorting.MMFFDANAEEI;
				CollectSpriteRenderer.sortingOrder = CollectSorting.BHIJCAOHDCM - JGFFOBIOJDM;
			}
		}

		public void DownAnimationEnded()
		{
			UpdateSortingAfterDownAnimation();
			StartCoroutine(base.transform.EJBPPMACIKI(MiddlePoint, TargetPosition, CurveDuration, BJCJEPIOBMA.QuadOut));
		}

		public void DoRecycle()
		{
			if (MHMIDCKIHOD != null)
			{
				MHMIDCKIHOD.HardStop();
			}
			FallManager.DecreaseStatAnimation();
			base.transform.localScale = Vector3.one;
			base.transform.localRotation = Quaternion.identity;
			CurrentLevel = null;
			CurveDuration = 0f;
			GoalType = NOALGNJECAD.None;
			MiddlePoint = Vector3.zero;
			TopPanel = null;
			TopPanelGoalId = 0;
			GoalImageScale = 1f;
			TargetPosition = Vector3.zero;
			XDelay = 0f;
			YDelay = 0f;
			EKDBBIIFGMK = false;
			MHMIDCKIHOD = null;
			DBGBDFCPKCP = true;
			base.gameObject.MEJPNNFDEBD();
		}

		public void MoveCompleted()
		{
			CurrentLevel.OEOBPBFCEPB[(int)GoalType]--;
			switch (GoalType)
			{
			case NOALGNJECAD.Duck:
			case NOALGNJECAD.GiantDuck:
				duck.PMPJJACINHL(this);
				break;
			case NOALGNJECAD.Carrot:
				carrot.PMPJJACINHL(this);
				break;
			case NOALGNJECAD.Bird:
				bird.PMPJJACINHL(this);
				break;
			case NOALGNJECAD.Penguin:
				penguin.PMPJJACINHL(this);
				break;
			case NOALGNJECAD.Ufo:
				ufo.PMPJJACINHL(this);
				break;
			case NOALGNJECAD.Gold:
				gold.PMPJJACINHL(this);
				break;
			case NOALGNJECAD.SolidColor1:
			case NOALGNJECAD.SolidColor2:
			case NOALGNJECAD.SolidColor3:
			case NOALGNJECAD.SolidColor4:
			case NOALGNJECAD.SolidColor5:
			case NOALGNJECAD.SolidColor6:
				solidColor.PMPJJACINHL(this);
				break;
			default:
				defaultStrategy.PMPJJACINHL(this);
				break;
			}
		}
	}
}
