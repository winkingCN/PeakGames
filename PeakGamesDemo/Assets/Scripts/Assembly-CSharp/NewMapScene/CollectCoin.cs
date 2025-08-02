using DG.Tweening;
using UnityEngine;

namespace NewMapScene
{
	public class CollectCoin : CollectPrefab
	{
		public Animator CoinAnimator;

		private void OnEnable()
		{
			float normalizedTime = Random.Range(0f, 0.1f);
			CoinAnimator.Play("CoinCollectAnimation", -1, normalizedTime);
			CollectSpriteRenderer.color = new Color(0.39607844f, 31f / 85f, 18f / 85f, 0f);
			CollectSpriteRenderer.DOColor(new Color(1f, 1f, 1f, 1f), 0.5f);
		}
	}
}
