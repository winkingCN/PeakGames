using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Tutorials
{
	public class TutorialCellDisplayer : MonoBehaviour
	{
		public Transform Mask;

		public SpriteRenderer TopLeft;

		public SpriteRenderer TopRight;

		public SpriteRenderer BottomLeft;

		public SpriteRenderer BottomRight;

		public void FadeIn()
		{
			Color color = new Color(1f, 1f, 1f, 0f);
			TopLeft.color = color;
			TopRight.color = color;
			BottomLeft.color = color;
			BottomRight.color = color;
			TopLeft.DOFade(32f / 51f, 0.3f);
			TopRight.DOFade(32f / 51f, 0.3f);
			BottomLeft.DOFade(32f / 51f, 0.3f);
			BottomRight.DOFade(32f / 51f, 0.3f);
		}
	}
}
