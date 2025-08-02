using System.Runtime.CompilerServices;
using Assets.Scripts.Utils;
using DG.Tweening;
using TMPro;
using UnityEngine;
using Utils.TextEffects;

namespace Dialogs
{
	public abstract class CalendarItem : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class LEBHCHELKOB
		{
			internal SpriteRenderer BDPLPGPDHIB;

			internal void AGFNGEFDHLA()
			{
				BDPLPGPDHIB.enabled = true;
			}
		}

		[CompilerGenerated]
		private sealed class IBPGJIBDCFP
		{
			internal SpriteRenderer BDPLPGPDHIB;

			internal void AGFNGEFDHLA()
			{
				BDPLPGPDHIB.enabled = true;
			}
		}

		public int Day;

		public TM_WaveScale DayWaveScale;

		public TextMeshPro DayTextClaimed;

		public TextMeshPro DayTextNotClaimed;

		public SpriteRenderer CheckMark;

		public SpriteRenderer JapaneseSun;

		public SpriteRenderer[] Background;

		public int[] BackgroundSpriteReferenceOrders;

		public ParticleSystem RewardParticlePrefab;

		public Transform[] Rewards;

		protected CalendarDialog MOBGJOGHDJN;

		protected const float ILHBCOIPEBE = 0.6f;

		private const float GOIFGNODPLE = 0.2f;

		protected abstract float LIJNBINOGFD { get; }

		public void PrepareCalendarItem()
		{
			string text = string.Format(NKILHODNBDE.GHBGCADFLFB("DayWithNumber"), Day);
			DayTextClaimed.FCJBBPHFNPJ = text;
			DayTextNotClaimed.FCJBBPHFNPJ = text;
		}

		public void EnableCalendarItem(CalendarDialog PDMCEIHCOLD, bool BKIGFEAPLIH)
		{
			MOBGJOGHDJN = PDMCEIHCOLD;
			if (BKIGFEAPLIH)
			{
				FLOHEGJPLPJ();
				GGPLAKKIDNO(LIJNBINOGFD);
				OKFCLPDDFFF();
				return;
			}
			DayTextNotClaimed.enabled = false;
			DayTextClaimed.enabled = true;
			JapaneseSun.enabled = false;
			CheckMark.enabled = true;
			for (int i = 0; i < Background.Length; i++)
			{
				Background[i].sprite = MOBGJOGHDJN.ClaimedSprites[BackgroundSpriteReferenceOrders[i]];
			}
			NPEABOBMDDI();
		}

		private void FLOHEGJPLPJ()
		{
			AudioManager.Play(KOOGPFAPGGD.CalendarTextEnter);
			DayTextNotClaimed.enabled = false;
			DayWaveScale.SetParameters(1f, 0.05f, 1f);
			Sequence s = DOTween.Sequence().SetEase(Ease.Linear);
			s.InsertCallback(0.2f, delegate
			{
				DayTextNotClaimed.enabled = true;
				DayWaveScale.Animate(Ease.OutElastic);
			});
		}

		private void GGPLAKKIDNO(float DKIPEJPGACG)
		{
			if (Day == 7)
			{
				MOBGJOGHDJN.LongClaimedBackground.localPosition = base.transform.localPosition;
			}
			else
			{
				MOBGJOGHDJN.ClaimedBackground.localPosition = base.transform.localPosition;
				for (int i = 0; i < Background.Length; i++)
				{
					MOBGJOGHDJN.ClaimedBackgroundRenderers[i].sprite = MOBGJOGHDJN.ClaimedSprites[BackgroundSpriteReferenceOrders[i]];
				}
			}
			Sequence s = DOTween.Sequence().SetEase(Ease.Linear);
			s.InsertCallback(DKIPEJPGACG, delegate
			{
				DayTextNotClaimed.enabled = false;
				DayTextClaimed.enabled = true;
				JapaneseSun.enabled = false;
			});
			Color color = new Color(1f, 1f, 1f, 0f);
			for (int j = 0; j < MOBGJOGHDJN.ClaimedBackgroundRenderers.Length; j++)
			{
				if (Day == 7)
				{
					SpriteRenderer BDPLPGPDHIB = MOBGJOGHDJN.LongClaimedBackgroundRenderers[j];
					BDPLPGPDHIB.color = color;
					s.InsertCallback(DKIPEJPGACG, delegate
					{
						BDPLPGPDHIB.enabled = true;
					});
					s.Insert(DKIPEJPGACG, BDPLPGPDHIB.DOFade(1f, 0.1f));
				}
				else
				{
					SpriteRenderer BDPLPGPDHIB2 = MOBGJOGHDJN.ClaimedBackgroundRenderers[j];
					BDPLPGPDHIB2.color = color;
					s.InsertCallback(DKIPEJPGACG, delegate
					{
						BDPLPGPDHIB2.enabled = true;
					});
					s.Insert(DKIPEJPGACG, BDPLPGPDHIB2.DOFade(1f, 0.02f));
				}
			}
		}

		protected void HOGADMOHMCJ(ParticleSystem KFLPMEHKPPE)
		{
			ParticleSystem particleSystem = Object.Instantiate(KFLPMEHKPPE, base.transform);
			particleSystem.transform.localPosition = Vector3.zero;
			particleSystem.transform.localScale = Vector3.one;
			particleSystem.Play();
		}

		protected abstract void OKFCLPDDFFF();

		protected abstract void NPEABOBMDDI();

		[CompilerGenerated]
		private void HGDIGOBBOIG()
		{
			DayTextNotClaimed.enabled = true;
			DayWaveScale.Animate(Ease.OutElastic);
		}

		[CompilerGenerated]
		private void DADFHECGEIN()
		{
			DayTextNotClaimed.enabled = false;
			DayTextClaimed.enabled = true;
			JapaneseSun.enabled = false;
		}
	}
}
