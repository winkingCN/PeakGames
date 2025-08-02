using System.Runtime.CompilerServices;
using Assets.Scripts.Dialogs;
using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Tutorials
{
	public class PrelevelTutorial : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class EADGGFOMDJC
		{
			internal PrelevelDialog ALLJGKCBBMA;

			internal PrelevelTutorial PDAPIGLEPGC;

			internal void AGFNGEFDHLA()
			{
				PDAPIGLEPGC.NHHOIGDCNMP = true;
				ALLJGKCBBMA.EnableButtons();
			}
		}

		public SpriteRenderer[] FadeImages;

		public Transform Dialog;

		private bool NHHOIGDCNMP;

		public void Close()
		{
			if (NHHOIGDCNMP)
			{
				Object.Destroy(base.gameObject);
			}
		}

		public void Init(PrelevelDialog ALLJGKCBBMA)
		{
			int num = FadeImages.Length;
			for (int i = 0; i < num; i++)
			{
				FadeImages[i].color = new Color(1f, 1f, 1f, 0f);
				FadeImages[i].DOFade(32f / 51f, 0.3f);
			}
			Dialog.localScale = Vector3.one * 0.5f;
			Dialog.DOScale(Vector3.one * 0.85f, 0.4f).SetEase(Ease.OutBack).OnComplete(delegate
			{
				NHHOIGDCNMP = true;
				ALLJGKCBBMA.EnableButtons();
			});
		}
	}
}
