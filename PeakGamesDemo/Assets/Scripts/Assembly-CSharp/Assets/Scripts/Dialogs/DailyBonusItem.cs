using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.Utils;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.Dialogs
{
	public class DailyBonusItem : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class OCDPNCCMBCF
		{
			internal float NKOFHIJJHNI;

			internal DailyBonusItem PDAPIGLEPGC;

			internal void AGFNGEFDHLA()
			{
				PDAPIGLEPGC.DNNIKAGLDPA();
				AudioManager.Play(KOOGPFAPGGD.DailyBonusCardLand);
			}

			internal void KDACLOKGNAM()
			{
				PDAPIGLEPGC.Front.SetActive(true);
				PDAPIGLEPGC.Back.SetActive(false);
				PDAPIGLEPGC.CardBackgroundTranform.localPosition = new Vector3(0f, 0f, -0.15f);
				PDAPIGLEPGC.CardAnimator.transform.DOLocalRotate(new Vector3(0f, 0f, 0f), NKOFHIJJHNI).SetEase(Ease.Linear);
			}
		}

		public Transform CardBackgroundTranform;

		public SpriteRenderer[] SpriteRenderers;

		public SpriteRenderer RewardSpriteRenderer;

		public SpriteRenderer RewardGlowSpriteRenderer;

		public SpriteRenderer CardGlow;

		public TextMeshPro CountText;

		public Animator CardAnimator;

		public GameObject Front;

		public GameObject Back;

		public ParticleSystem ExplosionParticle;

		private int JBLICAMFEIC;

		private DailyBonusDialog FGMHMHHMICB;

		private readonly int POECIBHKMGH = Animator.StringToHash("Base Layer.DailyBonusItemIdleAnimation1");

		private void Start()
		{
			CardAnimator.Play(POECIBHKMGH, -1, Random.Range(0f, 2f));
		}

		public void PlayRareIdleAnimation(bool KLBCIKPECCC)
		{
			if (KLBCIKPECCC)
			{
				CardAnimator.SetTrigger((!(Random.Range(0f, 10f) > 5f)) ? "PlayRareIdleAnimation2" : "PlayRareIdleAnimation1");
				return;
			}
			CardAnimator.ResetTrigger("PlayRareIdleAnimation1");
			CardAnimator.ResetTrigger("PlayRareIdleAnimation2");
		}

		public void SetContent(NAAHKHPBAPA IEGDGGBFLBJ, int MPCNGDPJABL, int HBMKHCHGHHF, DailyBonusDialog AHFDNHEPKIP)
		{
			Sprite sprite = null;
			JBLICAMFEIC = HBMKHCHGHHF;
			FGMHMHHMICB = AHFDNHEPKIP;
			CountText.FCJBBPHFNPJ = "+" + MPCNGDPJABL;
			Vector3 localPosition = new Vector3(-0.007f, -0.02f);
			Vector3 localPosition2 = new Vector3(0.034f, -0.046f);
			Vector3 localEulerAngles = Vector3.zero;
			Vector3 localPosition3 = new Vector3(0f, -0.718f);
			float num = 0.85f;
			float num2 = 1.95f;
			bool flag = false;
			switch (IEGDGGBFLBJ)
			{
			case NAAHKHPBAPA.Coins:
				sprite = SharedImageLibrary.Instance.NewCoins;
				num = 1f;
				localPosition.x = -0.022f;
				localPosition.y = 0.02f;
				num2 = 2.1f;
				localPosition2.x = 0.036f;
				localPosition2.y = 0.059f;
				localPosition3.x = 0f;
				localPosition3.y = -0.718f;
				flag = true;
				break;
			case NAAHKHPBAPA.Hammer:
				num = 0.85f;
				localEulerAngles = Vector3.forward * -4.2f;
				break;
			case NAAHKHPBAPA.Anvil:
				num = 0.82f;
				localPosition.x = 0.053f;
				localPosition.y = -0.088f;
				num2 = 1.9f;
				localPosition2.x = 0.05f;
				localPosition2.y = -0.08f;
				break;
			case NAAHKHPBAPA.BoxingGlove:
				num = 1f;
				localPosition.x = 0.025f;
				localPosition.y = 0.008f;
				num2 = 1.8f;
				localPosition2.x = 0.026f;
				localPosition2.y = 0.001f;
				break;
			case NAAHKHPBAPA.Rocket:
				num = 0.72f;
				localPosition.x = 0f;
				localPosition.y = -0.08f;
				num2 = 2f;
				localPosition2.x = 0.02f;
				localPosition2.y = -0.09f;
				localEulerAngles = Vector3.forward * 45f;
				break;
			case NAAHKHPBAPA.Bomb:
				num = 0.81f;
				localPosition.x = 0.052f;
				localPosition.y = -0.132f;
				num2 = 1.9f;
				localPosition2.x = 0.049f;
				localPosition2.y = -0.137f;
				break;
			case NAAHKHPBAPA.DiscoBall:
				num = 0.82f;
				localPosition.x = 0f;
				localPosition.y = -0.045f;
				num2 = 2f;
				localPosition2.x = 0f;
				localPosition2.y = -0.054f;
				break;
			case NAAHKHPBAPA.Dice:
				num = 0.7f;
				localPosition.x = 0.009f;
				localPosition.y = -0.054f;
				num2 = 1.8f;
				localPosition2.x = 0f;
				localPosition2.y = -0.054f;
				break;
			case NAAHKHPBAPA.Life:
				num = 0.84f;
				localPosition.x = 0f;
				localPosition.y = -0.09f;
				num2 = 1.8f;
				localPosition2.x = 0.018f;
				localPosition2.y = -0.098f;
				localPosition3.x = -0.02f;
				localPosition3.y = -0.087f;
				flag = true;
				break;
			}
			sprite = sprite ?? SharedImageLibrary.Instance.GetSpriteByInventoryType(IEGDGGBFLBJ);
			RewardSpriteRenderer.sprite = sprite;
			RewardSpriteRenderer.transform.localScale = Vector3.one * num;
			RewardSpriteRenderer.transform.localPosition = localPosition;
			RewardGlowSpriteRenderer.sprite = SharedImageLibrary.Instance.GetGlowSpriteByItemType(IEGDGGBFLBJ);
			RewardGlowSpriteRenderer.transform.localScale = Vector3.one * num2;
			RewardGlowSpriteRenderer.transform.localPosition = localPosition2;
			RewardGlowSpriteRenderer.transform.localEulerAngles = localEulerAngles;
			CountText.ANLKLKAINEO.localPosition = localPosition3;
			CountText.enabled = flag;
		}

		public void EnableItem(bool EDDNOJDPMCF)
		{
			GetComponent<EventBasedSpriteButton>().CanBeClicked = EDDNOJDPMCF;
		}

		public void OnClick()
		{
			PlayTurnAnimation(0f, 0.2f, true);
			if (FGMHMHHMICB != null)
			{
				FGMHMHHMICB.OnItemClicked(JBLICAMFEIC);
			}
		}

		public void PlayTurnAnimation(float JFOLNLDEODF, float NKOFHIJJHNI, bool OGNMMBFFBKO)
		{
			if (OGNMMBFFBKO)
			{
				CardAnimator.Play(POECIBHKMGH);
			}
			Sequence s = DOTween.Sequence();
			s.Insert(JFOLNLDEODF, CardAnimator.transform.DOLocalRotate(new Vector3(0f, -90f, 0f), NKOFHIJJHNI).SetEase(Ease.Linear));
			if (OGNMMBFFBKO)
			{
				OJFCEKJGFMO(300);
				AudioManager.Play(KOOGPFAPGGD.DailyBonusCardTurn);
				s.Insert(0f, CardAnimator.transform.DOScale(Vector3.one * 1.7f, 0.2f).SetEase(Ease.OutExpo));
				s.Insert(0.2f, CardAnimator.transform.DOScale(Vector3.one * 1.2f, 0.2f).SetEase(Ease.InExpo));
				s.InsertCallback(0.45f, delegate
				{
					DNNIKAGLDPA();
					AudioManager.Play(KOOGPFAPGGD.DailyBonusCardLand);
				});
			}
			s.InsertCallback(JFOLNLDEODF + NKOFHIJJHNI, delegate
			{
				Front.SetActive(true);
				Back.SetActive(false);
				CardBackgroundTranform.localPosition = new Vector3(0f, 0f, -0.15f);
				CardAnimator.transform.DOLocalRotate(new Vector3(0f, 0f, 0f), NKOFHIJJHNI).SetEase(Ease.Linear);
			});
		}

		private void OJFCEKJGFMO(int NNIDKMJGAJO)
		{
			int num = SpriteRenderers.Length;
			for (int i = 0; i < num; i++)
			{
				SpriteRenderer spriteRenderer = SpriteRenderers[i];
				if (spriteRenderer != null)
				{
					spriteRenderer.sortingOrder += NNIDKMJGAJO;
				}
			}
			CountText.GDDGFAKOCIL += NNIDKMJGAJO;
		}

		private void DNNIKAGLDPA()
		{
			ExplosionParticle.Play();
			CardGlow.enabled = true;
			CardGlow.transform.DOScale(5.2f, 1f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
		}
	}
}
