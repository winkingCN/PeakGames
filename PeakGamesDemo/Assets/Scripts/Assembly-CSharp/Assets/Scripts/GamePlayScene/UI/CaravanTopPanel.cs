using System;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using DG.Tweening;
using TMPro;
using UnityEngine;
using Utils;

namespace Assets.Scripts.GamePlayScene.UI
{
	public class CaravanTopPanel : MonoBehaviour
	{
		private KFCEILFGADG NLKHKDBCLMB;

		private int KNLIJPKGOIP;

		private int OKLJPCGNACH;

		private int[] MLKFMAKJLBI;

		private Tween KGAPBECFPAG;

		private float FALLKHIDDLI;

		public LevelBuilder CurrentlLevelBuilder;

		public GameObject TimeScaler;

		public TopPanelGoalUI[] GoalUIList;

		public TextMeshPro MovesLeftText;

		public Transform StarFillLayer;

		public ScoreBarStar[] Stars;

		public BezierCurve StarsCurve;

		public Transform GoalPanelReference;

		public GameObject GoalLabelContainer;

		public GameObject MovesLabelContainer;

		public MeshRenderer CharacterAnimationBottom;

		public MeshRenderer CharacterAnimationTop;

		public MeshRenderer CharacterAnimationSeparator;

		public GameObject[] winColliders;

		public GameObject AudioDownloadButton;

		public Last5MovesController CurrentLast5MovesController;

		[HideInInspector]
		public NOALGNJECAD[] GoalTypes;

		private float OKJLEOOMELO = -4.911f;

		private float MDDANLNAMFI = -0.304f;

		private float LMADMCKFIKN;

		private float[] IOMMCBLECPF = new float[3] { -10f, -10f, -10f };

		private float JIHFFFEMEIB;

		public bool AEKDDJFCIBF { get; set; }

		private void Awake()
		{
			AudioDownloadButton.SetActive(false);
			TimeScaler.SetActive(false);
		}

		private void MKFEANHLMEG()
		{
			CurrentLast5MovesController.ResetLast5MovesWarning();
		}

		public void StartLast5MovesAnimation()
		{
			CurrentLast5MovesController.StartLast5MovesAnimation();
		}

		public void StopLast5Moves()
		{
			CurrentLast5MovesController.StopLast5Moves();
		}

		public void SceneReloadedSetups()
		{
			KNLIJPKGOIP = 0;
			OKLJPCGNACH = 0;
			MLKFMAKJLBI = null;
			KGAPBECFPAG = null;
			FALLKHIDDLI = 0f;
			GoalTypes = new NOALGNJECAD[4];
			NLKHKDBCLMB = CurrentlLevelBuilder.CurrentLevel;
			JAFHGNDILFF(NLKHKDBCLMB.JKKJLDLMIOG);
			MovesLeftText.FCJBBPHFNPJ = NLKHKDBCLMB.EBMFPDNPIEM.CMACDGCBKLO();
			PlayRandomSpineAnimations.ComboItemWillExplode = false;
			MKFEANHLMEG();
		}

		public void SwitchTimeScalerVisibility()
		{
		}

		public void WinGame(int BICBELADBDI)
		{
		}

		public void ChangeLabelSorting(Transform BFHFKDHGGLI, bool PPNHJIKJPFK = false)
		{
			int sortingLayerID = ((!PPNHJIKJPFK) ? SortingLayer.NameToID("UI") : SortingLayer.NameToID("Dialogs"));
			int sortingOrder = ((!PPNHJIKJPFK) ? 24 : 1001);
			int sortingOrder2 = ((!PPNHJIKJPFK) ? 5 : 1000);
			int num = (PPNHJIKJPFK ? (-1) : 0);
			int childCount = BFHFKDHGGLI.childCount;
			for (int i = 0; i < childCount; i++)
			{
				Transform child = BFHFKDHGGLI.GetChild(i);
				TextMeshPro component = child.GetComponent<TextMeshPro>();
				SpriteRenderer component2 = child.GetComponent<SpriteRenderer>();
				if (component != null)
				{
					component.IKJGCDCDCCJ = sortingLayerID;
					component.GDDGFAKOCIL = sortingOrder;
				}
				else if (component2 != null)
				{
					component2.sortingLayerID = sortingLayerID;
					component2.sortingOrder = sortingOrder2;
				}
				Vector3 localPosition = child.localPosition;
				localPosition.z = num;
				child.localPosition = localPosition;
			}
		}

		private void JAFHGNDILFF(List<OGIFMLFEAEM> CDAEMCDOHPC)
		{
			int count = CDAEMCDOHPC.Count;
			bool flag = count == 4;
			float num = ((!flag) ? 0.8f : 0.7f);
			float num2 = (3.6f - (float)count * num) / ((float)count + 1f);
			for (int i = 0; i < CDAEMCDOHPC.Count; i++)
			{
				OGIFMLFEAEM oGIFMLFEAEM = NLKHKDBCLMB.JKKJLDLMIOG[i];
				GoalTypes[i] = oGIFMLFEAEM.ENBPGGCIADN;
				GoalUIList[i].Init(oGIFMLFEAEM, flag);
				int num3 = i + 1;
				Vector3 localPosition = GoalUIList[i].transform.localPosition;
				localPosition.x = (float)num3 * num2 + (float)i * num + 0.5f * num - 1.8f;
				GoalUIList[i].transform.localPosition = localPosition;
				GoalUIList[i].transform.localScale = Vector3.one * num;
			}
		}

		public void UpdateGoalCount(int BDKFNEDHAOJ, int ENMLICFLHAO, bool LMJOJPKEAGA = false)
		{
			GoalUIList[BDKFNEDHAOJ].UpdateGoalCount(ENMLICFLHAO, LMJOJPKEAGA);
		}

		public int GetActiveCollectAnimationsCount(int BDKFNEDHAOJ)
		{
			return GoalUIList[BDKFNEDHAOJ].GetActiveCollectAnimationsCount();
		}

		public void IncreaseActiveCollectAnimationtCount(int BDKFNEDHAOJ)
		{
			GoalUIList[BDKFNEDHAOJ].IncreaseActiveCollectAnimationtCount();
		}

		public void PlayGoalCollectHit(int DEBLPBDEOOA)
		{
			GoalUIList[DEBLPBDEOOA].PlayGoalCollectHit();
		}

		public int FindGoalIndex(NOALGNJECAD HBBIFNLDKPO)
		{
			for (int i = 0; i < NLKHKDBCLMB.JKKJLDLMIOG.Count; i++)
			{
				if (NLKHKDBCLMB.JKKJLDLMIOG[i].ENBPGGCIADN == HBBIFNLDKPO)
				{
					return i;
				}
			}
			return 0;
		}

		public void InitStars(int[] GFOOKBJLPDL)
		{
			LMADMCKFIKN = MDDANLNAMFI - OKJLEOOMELO;
			MLKFMAKJLBI = GFOOKBJLPDL;
			OKLJPCGNACH = MLKFMAKJLBI[2];
			if (IOMMCBLECPF == null)
			{
				IOMMCBLECPF = new float[3];
			}
			float num = 2.4f;
			Vector3 localPosition = StarFillLayer.transform.localPosition;
			localPosition.x = OKJLEOOMELO;
			StarFillLayer.transform.localPosition = localPosition;
			float num2 = OKJLEOOMELO + num + 0.16f;
			for (int i = 0; i < MLKFMAKJLBI.Length; i++)
			{
				float num3 = Mathf.Min((float)MLKFMAKJLBI[i] / (float)OKLJPCGNACH, 1f);
				if (IOMMCBLECPF[i] <= -10f)
				{
					Vector3 vector = Stars[i].transform.InverseTransformPoint(StarsCurve.GetPointAt(num3));
					IOMMCBLECPF[i] = vector.y;
				}
				Vector3 localPosition2 = new Vector3(num2 + LMADMCKFIKN * num3, IOMMCBLECPF[i], 0f);
				Stars[i].transform.localPosition = localPosition2;
				Stars[i].ResetStar();
			}
			StarsCurve.gameObject.SetActive(false);
		}

		public void UpdateScoreBar(int MGCMMJPNJPH)
		{
			if (!AEKDDJFCIBF && !(StarFillLayer.transform.localPosition.x >= 0f))
			{
				float to = Mathf.Min((float)MGCMMJPNJPH, (float)OKLJPCGNACH);
				if (KGAPBECFPAG != null)
				{
					KGAPBECFPAG.Kill();
				}
				KGAPBECFPAG = DOVirtual.Float(FALLKHIDDLI, to, 0.4f, IFJMAKHBBIH).SetEase(Ease.Linear).OnComplete(CKMNNPMODMB);
			}
		}

		private void CKMNNPMODMB()
		{
			KGAPBECFPAG = null;
		}

		private void IFJMAKHBBIH(float HIMINGHNIKN)
		{
			try
			{
				if (!(StarFillLayer == null) && Stars != null && Stars.Length >= KNLIJPKGOIP)
				{
					FALLKHIDDLI = HIMINGHNIKN;
					float a = FALLKHIDDLI / (float)OKLJPCGNACH;
					a = Mathf.Min(a, 1f);
					if (Math.Abs(a - JIHFFFEMEIB) > 0.001f)
					{
						JIHFFFEMEIB = a;
						Vector3 localPosition = StarFillLayer.transform.localPosition;
						localPosition.x = a * LMADMCKFIKN + OKJLEOOMELO;
						StarFillLayer.transform.localPosition = localPosition;
					}
					if (KNLIJPKGOIP < 3 && FALLKHIDDLI >= (float)MLKFMAKJLBI[KNLIJPKGOIP])
					{
						Stars[KNLIJPKGOIP].PlayWinAnimation(KNLIJPKGOIP);
						KNLIJPKGOIP++;
					}
				}
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.ScoreBarStar, "Error updating star bar stars. Error:{0} Stack{1}", ex.Message, ex.StackTrace);
			}
		}
	}
}
