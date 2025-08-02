using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;

namespace NewMapScene
{
	public class CollectTreasureKey : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class MMLDDCPGJCC
		{
			internal Action PEKBLCJKJFL;

			internal Action<bool> IMHLFAHONPP;

			internal CollectTreasureKey PDAPIGLEPGC;

			internal void AGFNGEFDHLA()
			{
				PDAPIGLEPGC.CIHBAHIBKPO(1f, 1.21f, Ease.InSine);
			}

			internal void KDACLOKGNAM()
			{
				PDAPIGLEPGC.CIHBAHIBKPO(3.5f, 0.8f, Ease.Linear);
			}

			internal void DBLIJBPNCAN()
			{
				if (PEKBLCJKJFL != null)
				{
					PEKBLCJKJFL();
				}
				PDAPIGLEPGC.TreasureKeyAnimator.gameObject.SetActive(false);
				PDAPIGLEPGC.TrailParticle.Stop();
			}

			internal void EFLLCMEPAEM()
			{
				UnityEngine.Object.Destroy(PDAPIGLEPGC.gameObject);
			}

			internal void NNINHCPIBHO()
			{
				if (IMHLFAHONPP != null)
				{
					IMHLFAHONPP(true);
				}
			}
		}

		[CompilerGenerated]
		private sealed class LDJHCMOGPEB
		{
			internal float INIGLDNBNJD;

			internal CollectTreasureKey PDAPIGLEPGC;

			internal float AGFNGEFDHLA()
			{
				return INIGLDNBNJD;
			}

			internal void KDACLOKGNAM(float AMFCENFNAJJ)
			{
				INIGLDNBNJD = AMFCENFNAJJ;
			}

			internal void DBLIJBPNCAN()
			{
				PDAPIGLEPGC.TreasureKeyAnimator.speed = INIGLDNBNJD;
			}
		}

		public Animator TreasureKeyAnimator;

		public AnimationCurve ScaleAnimationCurve;

		public AnimationCurve PositionAnimationCurve;

		public AnimationCurve RotationAnimationCurve;

		public SpriteRenderer TreasureKeySpriteRenderer;

		public ParticleSystem TrailParticle;

		[CompilerGenerated]
		private static TweenCallback EBCOMJBLIPP;

		public void StartCollectAnimation(Vector3 HBKDNOHDOFG, Action PEKBLCJKJFL, Action<bool> IMHLFAHONPP)
		{
			TreasureKeyAnimator.speed = 4f;
			base.transform.localScale = Vector3.zero;
			Sequence sequence = DOTween.Sequence().AppendCallback(delegate
			{
				CIHBAHIBKPO(1f, 1.21f, Ease.InSine);
			}).Join(base.transform.DOScale(Vector3.one * 2f, 1.21f).SetEase(ScaleAnimationCurve))
				.Join(base.transform.DOMove(Vector3.down * 1.2f, 1.21f).SetEase(PositionAnimationCurve))
				.AppendCallback(delegate
				{
					CIHBAHIBKPO(3.5f, 0.8f, Ease.Linear);
				})
				.Join(base.transform.DOScale(Vector3.one * 1.3f, 0.8f).SetEase(Ease.InBack))
				.Join(base.transform.DOMove(HBKDNOHDOFG, 0.8f).SetEase(Ease.InBack))
				.AppendCallback(delegate
				{
					if (PEKBLCJKJFL != null)
					{
						PEKBLCJKJFL();
					}
					TreasureKeyAnimator.gameObject.SetActive(false);
					TrailParticle.Stop();
				})
				.AppendInterval(0.5f)
				.OnComplete(delegate
				{
					UnityEngine.Object.Destroy(base.gameObject);
				})
				.Insert(0f, base.transform.DORotate(Vector3.back * 42f, 2.01f).SetEase(RotationAnimationCurve))
				.InsertCallback(0.27f, delegate
				{
					AudioManager.Play(KOOGPFAPGGD.TreasureKeyFly);
				});
			sequence.InsertCallback(sequence.Duration() - 0.6f, delegate
			{
				if (IMHLFAHONPP != null)
				{
					IMHLFAHONPP(true);
				}
			});
		}

		public void ChangeSortingLayer(CKKKELDIOLD IBBBMACIBGK)
		{
			TreasureKeySpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			TreasureKeySpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM;
		}

		private void CIHBAHIBKPO(float CAEMELGEOAE, float FMPBJJMKCIG, Ease LMGHDHGABOL)
		{
			float INIGLDNBNJD = TreasureKeyAnimator.speed;
			DOTween.To(() => INIGLDNBNJD, delegate(float AMFCENFNAJJ)
			{
				INIGLDNBNJD = AMFCENFNAJJ;
			}, CAEMELGEOAE, FMPBJJMKCIG).SetEase(LMGHDHGABOL).OnUpdate(delegate
			{
				TreasureKeyAnimator.speed = INIGLDNBNJD;
			});
		}

		[CompilerGenerated]
		private static void PFCDMFINOEJ()
		{
			AudioManager.Play(KOOGPFAPGGD.TreasureKeyFly);
		}
	}
}
