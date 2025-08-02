using System.Runtime.CompilerServices;
using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;

namespace Dialogs
{
	public class CalendarGiftItem : CalendarItem
	{
		[CompilerGenerated]
		private sealed class AEAAEENGFED
		{
			internal Animator NNHLFCCAAJG;

			internal int CMBFLHDAIHN;

			internal void AGFNGEFDHLA()
			{
				NNHLFCCAAJG.Play(CMBFLHDAIHN, 0, 0f);
			}
		}

		public Animator[] GiftAnimators;

		private const float FIKIBDNNCHK = 0.05f;

		private const float IJLMJDCNJLH = 0.8f;

		private const float OPLGCKCBLHO = 1.6f;

		private const float ALNOOIANEME = 1.5f;

		private static readonly int[] MIINKNOIAFF = new int[4]
		{
			Animator.StringToHash("Base Layer.CalendarGiftExplodeAnimation"),
			Animator.StringToHash("Base Layer.CalendarGiftExplodeMultipleAnimation1"),
			Animator.StringToHash("Base Layer.CalendarGiftExplodeMultipleAnimation2"),
			Animator.StringToHash("Base Layer.CalendarGiftExplodeMultipleAnimation3")
		};

		[CompilerGenerated]
		private static TweenCallback EBCOMJBLIPP;

		[CompilerGenerated]
		private static TweenCallback DNBOPLHGMHA;

		protected override float LIJNBINOGFD
		{
			get
			{
				return 1.6f;
			}
		}

		protected override void NPEABOBMDDI()
		{
			for (int i = 0; i < GiftAnimators.Length; i++)
			{
				GiftAnimators[i].gameObject.SetActive(false);
			}
		}

		protected override void OKFCLPDDFFF()
		{
			Sequence s = DOTween.Sequence().SetEase(Ease.Linear);
			s.InsertCallback(1.5f, delegate
			{
				HOGADMOHMCJ(RewardParticlePrefab);
				HOGADMOHMCJ((Day != 7) ? MOBGJOGHDJN.UnlockParticlePrefab : MOBGJOGHDJN.LongUnlockParticlePrefab);
			});
			s.InsertCallback(0.6f, delegate
			{
				AudioManager.Play(KOOGPFAPGGD.CalendarGiftExpand);
			});
			s.InsertCallback(1.6f, delegate
			{
				AudioManager.Play(KOOGPFAPGGD.CalendarGiftExplode);
			});
			int num = GiftAnimators.Length;
			for (int i = 0; i < num; i++)
			{
				Animator NNHLFCCAAJG = GiftAnimators[i];
				int CMBFLHDAIHN = LACKHMFGGPN(i);
				s.InsertCallback(0.6f, delegate
				{
					NNHLFCCAAJG.Play(CMBFLHDAIHN, 0, 0f);
				});
			}
			for (int j = 0; j < Rewards.Length; j++)
			{
				Transform transform = Rewards[j];
				Vector3 localScale = transform.localScale;
				s.Insert(1.6f, transform.DOScale(1.5f * localScale, 0.05f).SetEase(Ease.OutSine));
				Tweener tweener = transform.DOScale(localScale, 0.8f).SetEase(Ease.OutElastic);
				tweener.easeOvershootOrAmplitude = 1f;
				s.Insert(1.65f, tweener);
			}
			s.InsertCallback(1.6f, delegate
			{
				for (int k = 0; k < GiftAnimators.Length; k++)
				{
					GiftAnimators[k].gameObject.SetActive(false);
				}
				for (int l = 0; l < Rewards.Length; l++)
				{
					Rewards[l].gameObject.SetActive(true);
				}
			});
		}

		private int LACKHMFGGPN(int JOOGMNNFCLJ)
		{
			switch (Day)
			{
			case 1:
			case 2:
			case 3:
				return MIINKNOIAFF[0];
			case 4:
			case 5:
			case 6:
				return MIINKNOIAFF[JOOGMNNFCLJ + 1];
			case 7:
				return (JOOGMNNFCLJ != 0) ? MIINKNOIAFF[JOOGMNNFCLJ] : MIINKNOIAFF[3];
			default:
				return MIINKNOIAFF[0];
			}
		}

		[CompilerGenerated]
		private void BKEDKFDFHKI()
		{
			HOGADMOHMCJ(RewardParticlePrefab);
			HOGADMOHMCJ((Day != 7) ? MOBGJOGHDJN.UnlockParticlePrefab : MOBGJOGHDJN.LongUnlockParticlePrefab);
		}

		[CompilerGenerated]
		private static void AKEJODJMKKN()
		{
			AudioManager.Play(KOOGPFAPGGD.CalendarGiftExpand);
		}

		[CompilerGenerated]
		private static void NNJBJNJPCIN()
		{
			AudioManager.Play(KOOGPFAPGGD.CalendarGiftExplode);
		}

		[CompilerGenerated]
		private void OEDDJDIONBG()
		{
			for (int i = 0; i < GiftAnimators.Length; i++)
			{
				GiftAnimators[i].gameObject.SetActive(false);
			}
			for (int j = 0; j < Rewards.Length; j++)
			{
				Rewards[j].gameObject.SetActive(true);
			}
		}
	}
}
