using DG.Tweening;
using UnityEngine;

namespace Dialogs
{
	public class CrownRushInfoDialogStage : MonoBehaviour
	{
		public Transform Crown;

		public Sprite ArrowNormal;

		public Sprite ArrowSelected;

		public SpriteRenderer[] Arrows;

		public SpriteRenderer[] Glows;

		public SpriteRenderer[] Highlights;

		public void SetStatus(bool MOBADLDCMNC, bool IJBFBKHPEMK)
		{
			int num = Arrows.Length;
			for (int i = 0; i < num; i++)
			{
				SpriteRenderer spriteRenderer = Arrows[i];
				if (spriteRenderer != null)
				{
					spriteRenderer.sprite = ((!MOBADLDCMNC) ? ArrowNormal : ArrowSelected);
				}
			}
			for (int j = 0; j < Glows.Length; j++)
			{
				Glows[j].enabled = MOBADLDCMNC;
			}
			if (!IJBFBKHPEMK)
			{
				for (int k = 0; k < Highlights.Length; k++)
				{
					Highlights[k].enabled = MOBADLDCMNC;
				}
			}
			else if (MOBADLDCMNC)
			{
				PlayFadeInAnimation();
			}
			else
			{
				PlayFadeOutAnimation();
			}
		}

		public void PlayBounceAnimation()
		{
			Vector3 localScale = Crown.localScale;
			Sequence s = DOTween.Sequence();
			s.Append(Crown.DOScale(1f, 0.1f).SetEase(Ease.OutCubic));
			s.Append(Crown.DOScale(0.6f, 0.1f).SetEase(Ease.OutSine));
			s.Append(Crown.DOScale(localScale, 0.8f).SetEase(Ease.OutElastic));
		}

		public void PlayFadeInAnimation()
		{
			for (int i = 0; i < Highlights.Length; i++)
			{
				Highlights[i].enabled = true;
				Highlights[i].color *= new Color(1f, 1f, 1f, 0f);
				Highlights[i].DOFade(1f, 1.2f);
			}
		}

		public void PlayFadeOutAnimation()
		{
			for (int i = 0; i < Highlights.Length; i++)
			{
				Highlights[i].DOFade(0f, 0.5f);
			}
		}
	}
}
