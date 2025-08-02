using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.MapScene;
using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;

namespace NewMapScene
{
	public class CollectBooster : CollectPrefab
	{
		[CompilerGenerated]
		private sealed class OJNHPBJIMOJ
		{
			internal Action IMHLFAHONPP;

			internal CollectBooster PDAPIGLEPGC;

			internal void AGFNGEFDHLA()
			{
				AudioManager.Play(KOOGPFAPGGD.BoosterCollectAppear, GCEAKOOGDJK.Multiple);
				PDAPIGLEPGC.gameObject.SetActive(true);
				PDAPIGLEPGC.AppearParticle.Play(true);
			}

			internal void KDACLOKGNAM()
			{
				AudioManager.Play(KOOGPFAPGGD.BoosterCollectHit, GCEAKOOGDJK.Multiple);
				PDAPIGLEPGC.CurrentAnimator.gameObject.SetActive(false);
				PDAPIGLEPGC.HitParticle.Play(true);
				MapManager.Instance.CurrentNewMapAnimationController.LevelButton.PlayBoosterHitAnimation();
				MapManager.Instance.CurrentNewMapAnimationController.StageButton.PlayBoosterHitAnimation();
			}

			internal void DBLIJBPNCAN()
			{
				if (IMHLFAHONPP != null)
				{
					IMHLFAHONPP();
				}
				if (PDAPIGLEPGC.gameObject != null)
				{
					UnityEngine.Object.Destroy(PDAPIGLEPGC.gameObject);
				}
			}
		}

		public Animator CurrentAnimator;

		public ParticleSystem HitParticle;

		public ParticleSystem AppearParticle;

		public SpriteRenderer CurrentSpriteRenderer;

		public SpriteRenderer ShadowSpriteRenderer;

		public Transform ShadowPosition;

		private const float CMMDINNJKAC = 0.6f;

		private const float NJPPOBHELFC = 0.8f;

		private const float DCMLOJMPHAL = 0.4f;

		private const float KCEBPBFKFGE = 1f;

		private const float NEFHFBJJMID = 1f;

		private float CMLGJMMIAKC = 1f;

		public void Prepare(NAAHKHPBAPA MMHIFICGOHO, int CMAJLIAELDP, bool HBLPCAFIIAE, Transform LIMMFGDCLAB, Action IMHLFAHONPP)
		{
			ICCFMIPEMCK(MMHIFICGOHO, CMAJLIAELDP);
			BKFKLBADLEJ(CMAJLIAELDP, HBLPCAFIIAE, LIMMFGDCLAB);
			HCGFKKEMMLL(CMAJLIAELDP, IMHLFAHONPP);
		}

		private void ICCFMIPEMCK(NAAHKHPBAPA MMHIFICGOHO, int CMAJLIAELDP)
		{
			int num = 100 - CMAJLIAELDP * 2;
			CurrentSpriteRenderer.sortingOrder += num;
			ShadowSpriteRenderer.sortingOrder += num;
			switch (MMHIFICGOHO)
			{
			case NAAHKHPBAPA.Hammer:
				CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.Hammer;
				ShadowSpriteRenderer.sprite = SharedImageLibrary.Instance.HammerGlow;
				ShadowSpriteRenderer.transform.localScale = Vector3.one * 2.1f;
				ShadowPosition.transform.localPosition = new Vector3(0f, 0.151f);
				CMLGJMMIAKC = 1f;
				break;
			case NAAHKHPBAPA.Anvil:
				CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.Anvil;
				ShadowSpriteRenderer.sprite = SharedImageLibrary.Instance.AnvilGlow;
				ShadowSpriteRenderer.transform.localScale = Vector3.one * 2.1f;
				ShadowPosition.transform.localPosition = new Vector3(0f, 0.105f);
				CMLGJMMIAKC = 1f;
				break;
			case NAAHKHPBAPA.BoxingGlove:
				CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.BoxingGlove;
				ShadowSpriteRenderer.sprite = SharedImageLibrary.Instance.BoxingGloveGlow;
				ShadowSpriteRenderer.transform.localScale = Vector3.one * 1.7f;
				ShadowPosition.transform.localPosition = new Vector3(0f, 0.219f);
				CMLGJMMIAKC = 1.2f;
				break;
			case NAAHKHPBAPA.Dice:
				CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.Shuffle;
				ShadowSpriteRenderer.sprite = SharedImageLibrary.Instance.ShuffleGlow;
				ShadowSpriteRenderer.transform.localScale = new Vector3(2.3f, 1.4f);
				ShadowPosition.transform.localPosition = new Vector3(0.034f, -0.108f);
				ShadowSpriteRenderer.transform.localRotation = Quaternion.Euler(0f, 0f, 2.78f);
				CMLGJMMIAKC = 0.84f;
				break;
			case NAAHKHPBAPA.Rocket:
				CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.Rocket;
				ShadowSpriteRenderer.sprite = SharedImageLibrary.Instance.RocketGlow;
				ShadowSpriteRenderer.transform.localScale = new Vector3(2.5f, 2.3f);
				ShadowSpriteRenderer.transform.localRotation = Quaternion.Euler(0f, 0f, 45f);
				ShadowPosition.transform.localPosition = new Vector3(0.09f, 0.143f);
				CMLGJMMIAKC = 0.8f;
				break;
			case NAAHKHPBAPA.Bomb:
				CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.Bomb;
				ShadowSpriteRenderer.sprite = SharedImageLibrary.Instance.BombGlow;
				ShadowSpriteRenderer.transform.localScale = new Vector3(2.2f, 2.2f);
				ShadowPosition.transform.localPosition = new Vector3(0f, 0.143f);
				CMLGJMMIAKC = 0.97f;
				break;
			case NAAHKHPBAPA.DiscoBall:
				CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.DiscoBallUi;
				ShadowSpriteRenderer.sprite = SharedImageLibrary.Instance.DiscoBallUiGlow;
				ShadowSpriteRenderer.transform.localScale = new Vector3(2.2f, 2.2f);
				ShadowPosition.transform.localPosition = new Vector3(0f, 0.1f);
				CMLGJMMIAKC = 0.9f;
				break;
			case NAAHKHPBAPA.Extra5Moves:
				break;
			}
		}

		private void BKFKLBADLEJ(int CMAJLIAELDP, bool HBLPCAFIIAE, Transform LIMMFGDCLAB)
		{
			base.transform.SetParent(LIMMFGDCLAB);
			CurrentAnimator.transform.localScale = Vector3.one * CMLGJMMIAKC;
			if (CMAJLIAELDP == 0)
			{
				base.transform.position = Vector3.zero;
			}
			else
			{
				Vector3 zero = Vector3.zero;
				if (CMAJLIAELDP % 2 == 0)
				{
					zero.x += ((!HBLPCAFIIAE) ? 1f : UnityEngine.Random.Range(-1f, 0f));
				}
				else
				{
					zero.x += ((!HBLPCAFIIAE) ? (-1f) : UnityEngine.Random.Range(0f, 1f));
				}
				float num = (float)CMAJLIAELDP * (1f - (float)CMAJLIAELDP * 0.1f);
				zero.y += num;
				base.transform.position = zero;
				float num2 = CMLGJMMIAKC * 0.05f;
				CMLGJMMIAKC = Mathf.Max(CMLGJMMIAKC * 0.7f, CMLGJMMIAKC - (float)CMAJLIAELDP * num2);
				CurrentAnimator.transform.localScale = Vector3.one * CMLGJMMIAKC;
			}
			base.gameObject.SetActive(false);
		}

		private void HCGFKKEMMLL(int CMAJLIAELDP, Action IMHLFAHONPP)
		{
			Vector3 position = MapManager.Instance.NewMapContent.LevelButton.transform.position;
			float num = (float)CMAJLIAELDP * 0.1f;
			Sequence sequence = DOTween.Sequence();
			sequence.AppendInterval(num);
			sequence.AppendCallback(delegate
			{
				AudioManager.Play(KOOGPFAPGGD.BoosterCollectAppear, GCEAKOOGDJK.Multiple);
				base.gameObject.SetActive(true);
				AppearParticle.Play(true);
			});
			sequence.AppendInterval(0.8f);
			sequence.Append(base.transform.DOLocalMoveX(position.x, 0.6f).SetEase(Ease.InSine));
			sequence.Join(base.transform.DOLocalMoveY(position.y, 0.6f).SetEase(Ease.InBack));
			sequence.AppendCallback(delegate
			{
				AudioManager.Play(KOOGPFAPGGD.BoosterCollectHit, GCEAKOOGDJK.Multiple);
				CurrentAnimator.gameObject.SetActive(false);
				HitParticle.Play(true);
				MapManager.Instance.CurrentNewMapAnimationController.LevelButton.PlayBoosterHitAnimation();
				MapManager.Instance.CurrentNewMapAnimationController.StageButton.PlayBoosterHitAnimation();
			});
			sequence.AppendInterval(1f);
			sequence.OnComplete(delegate
			{
				if (IMHLFAHONPP != null)
				{
					IMHLFAHONPP();
				}
				if (base.gameObject != null)
				{
					UnityEngine.Object.Destroy(base.gameObject);
				}
			});
			sequence.Insert(num + 0.8f, CurrentAnimator.transform.DOScale(CMLGJMMIAKC * 1.3f, 0.4f).SetEase(Ease.OutSine));
			sequence.Insert(num + 0.8f + 0.4f, CurrentAnimator.transform.DOScale(CMLGJMMIAKC * 0.6f, 0.20000002f).SetEase(Ease.InSine));
		}
	}
}
