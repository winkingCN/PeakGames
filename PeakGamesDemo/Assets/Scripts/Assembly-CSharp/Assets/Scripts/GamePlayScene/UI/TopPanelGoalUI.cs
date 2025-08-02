using System.Collections;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.Utils;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.UI
{
	public class TopPanelGoalUI : MonoBehaviour
	{
		private float CGNDMLNEJNC = 1f;

		private int GCEPGEFGEBO;

		private int OBMBBNAOEPL;

		private Tween LOLAENDBDNB;

		public GameObject CheckImage;

		public ParticleSystem CheckParticle;

		public TextMeshPro CountText;

		public SpriteRenderer GoalImage;

		public ParticleSystem RingParticle;

		public ParticleSystem StarParticle;

		private float AKJEEHHNKOP;

		private bool PAJFNNAFJFM;

		private Vector3 HEJIOPNAEGG;

		public void Awake()
		{
			HEJIOPNAEGG = GoalImage.transform.localScale;
		}

		public void Init(OGIFMLFEAEM JKHLMLIANAI, bool OPJJAJLHNNO)
		{
			base.gameObject.SetActive(true);
			if (OPJJAJLHNNO)
			{
				CGNDMLNEJNC = 0.85f;
				Vector3 localPosition = CheckImage.transform.localPosition;
				localPosition.y = -0.358f;
				CheckImage.transform.localPosition = localPosition;
			}
			GCEPGEFGEBO = 0;
			OBMBBNAOEPL = 0;
			LOLAENDBDNB = null;
			GoalImage.sprite = SharedImageLibrary.Instance.GetGoalSpriteByItemType(JKHLMLIANAI.ENBPGGCIADN);
			AKJEEHHNKOP = SharedImageLibrary.Instance.GoalImageScale(JKHLMLIANAI.ENBPGGCIADN);
			GoalImage.transform.localScale = HEJIOPNAEGG * AKJEEHHNKOP;
			CountText.gameObject.SetActive(true);
			CountText.FCJBBPHFNPJ = JKHLMLIANAI.GMCGMPEEHJP.ToString();
			CheckImage.SetActive(false);
			CountText.gameObject.SetActive(true);
			PAJFNNAFJFM = false;
		}

		public void IncreaseActiveCollectAnimationtCount()
		{
			GCEPGEFGEBO++;
		}

		public int GetActiveCollectAnimationsCount()
		{
			return GCEPGEFGEBO;
		}

		public void PlayGoalCollectHit()
		{
			GCEPGEFGEBO--;
			RingParticle.Play();
			if (LOLAENDBDNB == null)
			{
				LOLAENDBDNB = GoalImage.transform.DOShakeScale(0.22f, 0.2f).OnComplete(HICKPDDFNGK);
			}
			else
			{
				GoalImage.transform.localScale = AKJEEHHNKOP * Vector3.one;
				LOLAENDBDNB.Kill();
				LOLAENDBDNB = GoalImage.transform.DOShakeScale(0.22f, 0.2f).OnComplete(HICKPDDFNGK);
			}
			if (GCEPGEFGEBO < 1)
			{
				StarParticle.Play();
			}
		}

		private void HICKPDDFNGK()
		{
			LOLAENDBDNB = null;
		}

		public void UpdateGoalCount(int ENMLICFLHAO, bool LMJOJPKEAGA)
		{
			if (LMJOJPKEAGA)
			{
				CountText.FCJBBPHFNPJ = ENMLICFLHAO.ToString();
				OBMBBNAOEPL = ENMLICFLHAO;
				return;
			}
			if (ENMLICFLHAO == 0 && CountText.gameObject.activeSelf)
			{
				CountText.gameObject.SetActive(false);
			}
			CountText.FCJBBPHFNPJ = ENMLICFLHAO.ToString();
			OBMBBNAOEPL = ENMLICFLHAO;
			if (OBMBBNAOEPL == 0 && !PAJFNNAFJFM)
			{
				StartCoroutine(FOCPMNCBNIE());
			}
		}

		private IEnumerator FOCPMNCBNIE()
		{
			if (!PAJFNNAFJFM)
			{
				PAJFNNAFJFM = true;
				while (GCEPGEFGEBO > 0)
				{
					yield return null;
				}
				HintManager.Instance.UpdateGoalHints();
				CountText.gameObject.SetActive(false);
				CheckImage.SetActive(true);
				AudioManager.Play(KOOGPFAPGGD.UiGoalComplete);
				CheckImage.transform.localScale = 3f * Vector3.one;
				Sequence s = DOTween.Sequence();
				Tweener tweener = CheckImage.transform.DOScale(CGNDMLNEJNC, 0.3f).SetEase(Ease.OutBack);
				tweener.easeOvershootOrAmplitude = 2f;
				s.Append(tweener);
				s.InsertCallback(0.1f, CheckParticle.Play);
			}
		}

		public void RevertCheckMarkForSnapshot()
		{
			StopAllCoroutines();
			PAJFNNAFJFM = false;
			CountText.gameObject.SetActive(true);
			CheckImage.SetActive(false);
		}
	}
}
