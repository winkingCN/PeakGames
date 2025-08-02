using System.Runtime.CompilerServices;
using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;

namespace Dialogs
{
	public class CalendarOpenItem : CalendarItem
	{
		private const float FIKIBDNNCHK = 0.3f;

		private const float IJLMJDCNJLH = 0.1f;

		private const float DBDFMCFMJLO = 0.8f;

		private const float PFCPLLAHNJA = 0.05f;

		[CompilerGenerated]
		private static TweenCallback EBCOMJBLIPP;

		[CompilerGenerated]
		private static TweenCallback DNBOPLHGMHA;

		protected override float LIJNBINOGFD
		{
			get
			{
				return 1f;
			}
		}

		protected override void NPEABOBMDDI()
		{
			for (int i = 0; i < Rewards.Length; i++)
			{
				Rewards[i].gameObject.SetActive(false);
			}
		}

		protected override void OKFCLPDDFFF()
		{
			Sequence s = DOTween.Sequence().SetEase(Ease.Linear);
			s.InsertCallback(0.90000004f, delegate
			{
				HOGADMOHMCJ(RewardParticlePrefab);
				HOGADMOHMCJ((Day != 7) ? MOBGJOGHDJN.UnlockParticlePrefab : MOBGJOGHDJN.LongUnlockParticlePrefab);
			});
			s.InsertCallback(1f, delegate
			{
				AudioManager.Play(KOOGPFAPGGD.CalendarRewardPlace);
			});
			for (int i = 0; i < Rewards.Length; i++)
			{
				Transform transform = Rewards[i];
				Vector3 localScale = transform.localScale;
				s.Insert(0.6f + (float)i * 0.05f, transform.DOScale(1.5f * localScale, 0.3f).SetEase(Ease.OutCubic));
				s.Insert(0.6f + (float)i * 0.05f + 0.3f, transform.DOScale(0.8f * localScale, 0.1f).SetEase(Ease.OutSine));
				s.Insert(0.6f + (float)i * 0.05f + 0.3f + 0.1f, transform.DOScale(localScale, 0.8f).SetEase(Ease.OutElastic));
				if (Day != 7 || i % 2 == 1)
				{
					s.InsertCallback(0.6f + (float)i * 0.05f, delegate
					{
						AudioManager.Play(KOOGPFAPGGD.CalendarRewardFly);
					});
				}
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
			AudioManager.Play(KOOGPFAPGGD.CalendarRewardPlace);
		}

		[CompilerGenerated]
		private static void NNJBJNJPCIN()
		{
			AudioManager.Play(KOOGPFAPGGD.CalendarRewardFly);
		}
	}
}
