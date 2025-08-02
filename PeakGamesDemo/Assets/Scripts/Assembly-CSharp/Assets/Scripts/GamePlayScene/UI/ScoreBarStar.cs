using System.Runtime.CompilerServices;
using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.UI
{
	public class ScoreBarStar : MonoBehaviour
	{
		public ParticleSystem Particle;

		public GameObject WinStar;

		public void Start()
		{
			WinStar.SetActive(false);
		}

		public void PlayWinAnimation(int NNOMMHOEBGD)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ScoreBarStar, "Playing star {0}", NNOMMHOEBGD);
			switch (NNOMMHOEBGD)
			{
			case 0:
				AudioManager.Play(KOOGPFAPGGD.UiGameplayStar1);
				break;
			case 1:
				AudioManager.Play(KOOGPFAPGGD.UiGameplayStar2);
				break;
			case 2:
				AudioManager.Play(KOOGPFAPGGD.UiGameplayStar3);
				break;
			}
			WinStar.SetActive(true);
			WinStar.transform.localScale = Vector3.one * 0.25f;
			SpriteRenderer component = WinStar.GetComponent<SpriteRenderer>();
			component.color = new Color(1f, 1f, 1f, 0f);
			Sequence s = DOTween.Sequence();
			s.Append(component.DOColor(new Color(1f, 1f, 1f, 1f), 0.045f).SetEase(Ease.OutQuad));
			s.Join(WinStar.transform.DOScale(1.5f, 0.18f).SetEase(Ease.OutQuad));
			s.Append(WinStar.transform.DOScale(0.5f, 0.18f).SetEase(Ease.OutQuad));
			s.InsertCallback(0.225f, delegate
			{
				if (Particle != null)
				{
					Particle.Play();
				}
			});
		}

		public void ResetStar()
		{
			WinStar.SetActive(false);
			Particle.Stop();
		}

		[CompilerGenerated]
		private void FFMAKGMNCJE()
		{
			if (Particle != null)
			{
				Particle.Play();
			}
		}
	}
}
