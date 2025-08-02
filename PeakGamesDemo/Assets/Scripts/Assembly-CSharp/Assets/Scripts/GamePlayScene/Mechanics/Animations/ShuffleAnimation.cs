using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Animations
{
	public class ShuffleAnimation : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class GDHOBKNAGPB
		{
			internal LEDBLDKJBAI IINIKGMHFFM;

			internal int HDHPGJPGNPF;

			internal ShuffleAnimation PDAPIGLEPGC;

			internal void AGFNGEFDHLA()
			{
				PDAPIGLEPGC.LNMHNJEIGBH.ChangeSorting(PDAPIGLEPGC.FGFMNKOMEIM);
			}

			internal void KDACLOKGNAM()
			{
				PDAPIGLEPGC.FGFMNKOMEIM.BHIJCAOHDCM = HDHPGJPGNPF;
				PDAPIGLEPGC.LNMHNJEIGBH.ChangeSorting(PDAPIGLEPGC.FGFMNKOMEIM);
			}
		}

		[CompilerGenerated]
		private sealed class KGJABEMKCPO
		{
			internal SolidColorItem BDFKLKBMFLL;

			internal GDHOBKNAGPB OMKIMGJICPM;

			internal void AGFNGEFDHLA()
			{
				OMKIMGJICPM.PDAPIGLEPGC.LNMHNJEIGBH.ChangeSorting(OMKIMGJICPM.PDAPIGLEPGC.FGFMNKOMEIM);
			}

			internal void KDACLOKGNAM()
			{
				BDFKLKBMFLL.ChangeMatchType(OMKIMGJICPM.IINIKGMHFFM);
			}
		}

		private Item LNMHNJEIGBH;

		private bool CCNMKIHBCJH;

		private Cell GIKPDAJONLB;

		private CKKKELDIOLD FGFMNKOMEIM;

		public static float Delay = 0.3f;

		public static float AnimationDuration = 0.9f;

		public static float ChangeSortingTime = 0.5f;

		public static float ChangeMatchTime = 0.45f;

		public static float OverShoot = 1.2f;

		[CompilerGenerated]
		private static TweenCallback EBCOMJBLIPP;

		public void OnDestroy()
		{
			FallManager.DecreaseMechanicAnimation();
			FallManager.DecreaseWaitingFallBlocker();
		}

		public void ShuffleWith(Cell DONKLGJKLGC, Cell FIICENBDLDC, int HDHPGJPGNPF, LEDBLDKJBAI IINIKGMHFFM = LEDBLDKJBAI.None)
		{
			GIKPDAJONLB = FIICENBDLDC;
			if (!CCNMKIHBCJH)
			{
				CCNMKIHBCJH = true;
				FallManager.IncreaseMechanicAnimation();
				FallManager.IncreaseWaitingFallBlocker();
			}
			Sequence sequence = DOTween.Sequence();
			Tweener tweener = base.gameObject.transform.DOMove(GIKPDAJONLB.GetFrozenPosition(), AnimationDuration).SetEase(Ease.InOutBack).SetDelay(Delay)
				.OnComplete(ALBEECHKMAL);
			tweener.easeOvershootOrAmplitude = OverShoot;
			sequence.Append(tweener);
			sequence.InsertCallback(AnimationDuration * 0.5f, delegate
			{
				AudioManager.Play(KOOGPFAPGGD.BoosterDice);
			});
			if (IINIKGMHFFM != LEDBLDKJBAI.None)
			{
				SolidColorItem BDFKLKBMFLL = LNMHNJEIGBH as SolidColorItem;
				if (BDFKLKBMFLL != null)
				{
					int num = ((!(DONKLGJKLGC == null)) ? Mathf.Abs(FIICENBDLDC.Y - DONKLGJKLGC.Y) : 0);
					if (num > 0)
					{
						sequence.InsertCallback(ChangeMatchTime + Delay - 0.1f, delegate
						{
							LNMHNJEIGBH.ChangeSorting(FGFMNKOMEIM);
						});
					}
					else
					{
						LNMHNJEIGBH.ChangeSorting(FGFMNKOMEIM);
					}
					sequence.InsertCallback(ChangeMatchTime + Delay, delegate
					{
						BDFKLKBMFLL.ChangeMatchType(IINIKGMHFFM);
					});
				}
			}
			else
			{
				sequence.InsertCallback(ChangeSortingTime + Delay, delegate
				{
					LNMHNJEIGBH.ChangeSorting(FGFMNKOMEIM);
				});
			}
			sequence.OnComplete(delegate
			{
				FGFMNKOMEIM.BHIJCAOHDCM = HDHPGJPGNPF;
				LNMHNJEIGBH.ChangeSorting(FGFMNKOMEIM);
			});
		}

		private void ALBEECHKMAL()
		{
			Object.Destroy(this);
		}

		internal void CJJAIFCFLCF(Item EJCNAJOHBFI, CKKKELDIOLD KHFBHDLBLJH)
		{
			LNMHNJEIGBH = EJCNAJOHBFI;
			FGFMNKOMEIM = KHFBHDLBLJH;
		}

		[CompilerGenerated]
		private static void MEPOKDGKLAB()
		{
			AudioManager.Play(KOOGPFAPGGD.BoosterDice);
		}
	}
}
