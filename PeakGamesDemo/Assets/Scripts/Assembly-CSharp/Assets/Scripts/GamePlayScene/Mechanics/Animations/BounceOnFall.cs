using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Animations
{
	public class BounceOnFall : FallListener
	{
		private const float PCHOBDHIDDC = 0.08f;

		private const float GMNHHBBCIAH = 0.12f;

		private Sequence EMOPIKGMCAA;

		public override void StartFall()
		{
			if (EMOPIKGMCAA != null)
			{
				EMOPIKGMCAA.Kill();
			}
		}

		public override void EndFall(float AEDMMCMLKDJ)
		{
			float y = base.gameObject.transform.position.y;
			EMOPIKGMCAA = DOTween.Sequence();
			float num = 0.08f * AEDMMCMLKDJ / 30f;
			float num2 = num * 1.5f;
			Transform target = base.gameObject.transform;
			EMOPIKGMCAA.Append(target.DOMoveY(y + num, num2).SetEase(Ease.OutSine));
			EMOPIKGMCAA.Append(target.DOMoveY(y, num2).SetEase(Ease.InSine));
			float num3 = num / 3f;
			EMOPIKGMCAA.Append(target.DOMoveY(y + num3, num2 / 3f).SetEase(Ease.OutSine));
			EMOPIKGMCAA.Append(target.DOMoveY(y, num2 / 3f).SetEase(Ease.InSine));
			EMOPIKGMCAA.SetEase(Ease.Linear);
		}
	}
}
