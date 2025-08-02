using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class CoconutItem : Item
	{
		public SpriteRenderer InitialSpriteRenderer;

		public SpriteRenderer BrokenSpriteRenderer;

		public SpriteRenderer BrokenBackSpriteRenderer;

		public SpriteRenderer ShadowSpriteRenderer;

		public Transform ShadowTransform;

		public Transform PositionFixer;

		public Animator CurrentAnimator;

		private static int[] DAJLHJICGJN;

		private CKKKELDIOLD KKCPOOALFAD;

		private int HBBBJLFIOCB = 2;

		private IEKBFJBLGFM PEAGKCJGHKE;

		private Sequence NNLIDBJHAEA;

		private Sequence CECMMIBAAIG;

		private bool MEJKLEDHHDI;

		private Sequence KEELJCBPPED;

		public void Start()
		{
			if (DAJLHJICGJN == null)
			{
				DAJLHJICGJN = new int[6];
				DAJLHJICGJN[0] = Animator.StringToHash("Base Layer.CoconutHitAnimation1");
				DAJLHJICGJN[1] = Animator.StringToHash("Base Layer.CoconutHitAnimation2");
				DAJLHJICGJN[2] = Animator.StringToHash("Base Layer.CoconutHitAnimation3");
				DAJLHJICGJN[3] = Animator.StringToHash("Base Layer.CoconutHitAnimation4");
				DAJLHJICGJN[4] = Animator.StringToHash("Base Layer.CoconutHitAnimation5");
				DAJLHJICGJN[5] = Animator.StringToHash("Base Layer.CoconutHitAnimation6");
			}
		}

		private void OnDestroy()
		{
			NNLIDBJHAEA.Kill();
			CECMMIBAAIG.Kill();
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Coconut;
		}

		public override int GetScore()
		{
			return 1000;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			KKCPOOALFAD = IBBBMACIBGK;
			InitialSpriteRenderer.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
			InitialSpriteRenderer.sortingOrder = KKCPOOALFAD.BHIJCAOHDCM;
			BrokenSpriteRenderer.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
			BrokenSpriteRenderer.sortingOrder = KKCPOOALFAD.BHIJCAOHDCM;
			BrokenBackSpriteRenderer.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
			BrokenBackSpriteRenderer.sortingOrder = KKCPOOALFAD.BHIJCAOHDCM + 1;
			ShadowSpriteRenderer.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
			ShadowSpriteRenderer.sortingOrder = KKCPOOALFAD.BHIJCAOHDCM - 1;
		}

		public override CKKKELDIOLD GetSorting()
		{
			return KKCPOOALFAD;
		}

		public override bool CanCastShadow()
		{
			return true;
		}

		public override int GetLayerCount()
		{
			return HBBBJLFIOCB;
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			float jFOLNLDEODF;
			switch (CCPAJBOJDMN.ENBPGGCIADN)
			{
			case 6:
				if (PEAGKCJGHKE == IEKBFJBLGFM.Up || PEAGKCJGHKE == IEKBFJBLGFM.Down)
				{
					MEJKLEDHHDI = true;
				}
				jFOLNLDEODF = 0.08f;
				break;
			case 8:
				jFOLNLDEODF = 0.08f;
				break;
			case 11:
				jFOLNLDEODF = 0.05f;
				break;
			case 5:
				MEJKLEDHHDI = true;
				jFOLNLDEODF = 0.15f;
				break;
			case 4:
				jFOLNLDEODF = 0.17f;
				break;
			default:
				jFOLNLDEODF = 0f;
				break;
			}
			if (HBBBJLFIOCB == 2)
			{
				HBBBJLFIOCB = 1;
				KJNCPPMHLPE(jFOLNLDEODF);
				return false;
			}
			CECMMIBAAIG.Kill();
			NNLIDBJHAEA.Kill();
			return true;
		}

		private void KJNCPPMHLPE(float JFOLNLDEODF)
		{
			if (ParticlePool.Instance != null)
			{
				ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[0], base.transform.position);
			}
			AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[0]);
			if (JFOLNLDEODF > 0f)
			{
				NNLIDBJHAEA = DOTween.Sequence();
				NNLIDBJHAEA.InsertCallback(JFOLNLDEODF, HHFELELNMMG);
			}
			else
			{
				HHFELELNMMG();
			}
		}

		private void HHFELELNMMG()
		{
			InitialSpriteRenderer.sprite = null;
			InitialSpriteRenderer.enabled = false;
			BrokenSpriteRenderer.enabled = true;
			BrokenBackSpriteRenderer.enabled = true;
			Vector3 position = ShadowTransform.position;
			position.y += 0.016f;
			ShadowTransform.position = position;
			BringToFront();
			CECMMIBAAIG = DOTween.Sequence();
			CECMMIBAAIG.InsertCallback(0.67f, SendToBack);
			CurrentAnimator.Play((!MEJKLEDHHDI) ? DAJLHJICGJN[Random.Range(0, 5)] : DAJLHJICGJN[5], -1, 0f);
		}

		public override void SetExplodeDirection(IEKBFJBLGFM AJLDJAHHGOJ)
		{
			PEAGKCJGHKE = AJLDJAHHGOJ;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return HBBBJLFIOCB == 1;
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			HBBBJLFIOCB = 1;
			base.ExplodeByBlasterItem(CCPAJBOJDMN);
		}

		public override void PlayExplodeAudio()
		{
			AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[1]);
		}

		protected override void EJCFANPAMMK()
		{
			if (ParticlePool.Instance != null)
			{
				ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[1], base.transform.position);
			}
		}

		public override void BringToFront()
		{
			base.BringToFront();
			CKKKELDIOLD kKCPOOALFAD = KKCPOOALFAD;
			KKCPOOALFAD.BHIJCAOHDCM += 100;
			ChangeSorting(KKCPOOALFAD);
			KKCPOOALFAD = kKCPOOALFAD;
		}

		public override void SendToBack()
		{
			base.SendToBack();
			ChangeSorting(KKCPOOALFAD);
		}

		public override void PlayWrongMove()
		{
			if (KEELJCBPPED != null)
			{
				KEELJCBPPED.Kill(true);
			}
			AudioManager.Play(KOOGPFAPGGD.InvalidTap);
			KEELJCBPPED = DOTween.Sequence();
			KEELJCBPPED.Append(PositionFixer.transform.DOLocalRotate(new Vector3(0f, 0f, 15f), 0.035f));
			KEELJCBPPED.Join(PositionFixer.transform.DOScale(0.93f, 0.035f));
			KEELJCBPPED.Append(PositionFixer.transform.DOLocalRotate(new Vector3(0f, 0f, -15f), 0.07f));
			KEELJCBPPED.Append(PositionFixer.transform.DOLocalRotate(new Vector3(0f, 0f, 0f), 0.035f));
			KEELJCBPPED.Append(PositionFixer.transform.DOLocalRotate(new Vector3(0f, 0f, 15f), 0.035f));
			KEELJCBPPED.Append(PositionFixer.transform.DOLocalRotate(new Vector3(0f, 0f, -15f), 0.07f));
			KEELJCBPPED.Append(PositionFixer.transform.DOLocalRotate(new Vector3(0f, 0f, 0f), 0.035f));
			KEELJCBPPED.Join(PositionFixer.transform.DOScale(1f, 0.035f));
			KEELJCBPPED.OnComplete(HCKMPDJJCLG);
		}

		private void HCKMPDJJCLG()
		{
			KEELJCBPPED = null;
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 80;
			byte aINNOPBDDGL = (byte)HBBBJLFIOCB;
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}

		protected void DGCBHOBKOCH(int PKHFDMGGGJN)
		{
			HBBBJLFIOCB = PKHFDMGGGJN;
		}
	}
}
