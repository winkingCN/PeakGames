using System.Collections;
using DG.Tweening;
using UnityEngine;

namespace StartScene
{
	public class FacebookButtonTween : MonoBehaviour
	{
		public IEnumerator Start()
		{
			yield return MCJHHDACJBG.CHFOIGLAMPN;
			Sequence sequence = DOTween.Sequence();
			sequence.SetEase(Ease.Linear);
			sequence.Append(base.transform.DOScale(Vector3.one * 1.08f, 0.5f).SetEase(Ease.OutSine));
			sequence.Append(base.transform.DOScale(Vector3.one * 1f, 0.5f).SetEase(Ease.InSine));
			sequence.SetLoops(-1, LoopType.Yoyo);
		}
	}
}
