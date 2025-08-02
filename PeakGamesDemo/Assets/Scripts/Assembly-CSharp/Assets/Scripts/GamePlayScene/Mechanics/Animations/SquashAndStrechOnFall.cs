using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Animations
{
	public class SquashAndStrechOnFall : FallListener
	{
		private const float MHPONOLMGAJ = 12f;

		private const float FMEDJGFJIAP = 0.2f;

		private const float ACDPFPIIKIA = 0.025f;

		private const float COEBLGKPCFL = 40f;

		public const float CrashEffect = 0.8f;

		public Sequence FallDeformAnimation;

		protected virtual float MDPHMDLJIME()
		{
			return 1.21f;
		}

		public override void StartFall()
		{
			if (FallDeformAnimation != null)
			{
				FallDeformAnimation.Kill();
			}
			FallDeformAnimation = DOTween.Sequence();
			Transform dHHMKEJENIE = base.gameObject.transform;
			GOLDJAKMEDG(dHHMKEJENIE, 1.025f, 0.1f, 0f);
			FallDeformAnimation.OnComplete(EOAKOGMGPGD);
		}

		public override void EndFall(float AEDMMCMLKDJ)
		{
			if (FallDeformAnimation != null)
			{
				FallDeformAnimation.Kill();
			}
			Transform dHHMKEJENIE = base.gameObject.transform;
			FallDeformAnimation = DOTween.Sequence();
			OMFHEMIPDPL(dHHMKEJENIE, AEDMMCMLKDJ);
			FallDeformAnimation.SetEase(Ease.Linear);
			FallDeformAnimation.OnComplete(EOAKOGMGPGD);
		}

		private void EOAKOGMGPGD()
		{
			FallDeformAnimation = null;
		}

		protected void GOLDJAKMEDG(Transform DHHMKEJENIE, float FNLMFCLDCOD, float HFLODNLEGFL, float KDGECKDNHOD, Ease EKFOKNPODBK = Ease.Linear)
		{
			float num = MDPHMDLJIME();
			FallDeformAnimation.Append(DHHMKEJENIE.DOScale(new Vector3(1f / FNLMFCLDCOD, FNLMFCLDCOD), HFLODNLEGFL).SetEase(EKFOKNPODBK));
			float num2 = num * (FNLMFCLDCOD - 1f) / 2f;
			num2 += KDGECKDNHOD;
			FallDeformAnimation.Join(DHHMKEJENIE.DOLocalMoveY(num2, HFLODNLEGFL).SetEase(EKFOKNPODBK));
		}

		protected virtual void OMFHEMIPDPL(Transform DHHMKEJENIE, float AEDMMCMLKDJ)
		{
			AEDMMCMLKDJ = (AEDMMCMLKDJ - 12f) / 18f;
			if (AEDMMCMLKDJ < 0f)
			{
				AEDMMCMLKDJ = 0f;
			}
			if (AEDMMCMLKDJ > 1f)
			{
				AEDMMCMLKDJ = 1f;
			}
			float num = Mathf.Max(0.2f * AEDMMCMLKDJ, 0.025f);
			float num2 = AEDMMCMLKDJ / 40f;
			float duration = Mathf.Sqrt(2f * num / 40f);
			GOLDJAKMEDG(DHHMKEJENIE, 0.98f - num2, 0.01f, 0f, Ease.OutQuad);
			GOLDJAKMEDG(DHHMKEJENIE, 1f, 0.03f, 0f, Ease.InQuad);
			FallDeformAnimation.Append(DHHMKEJENIE.DOLocalMoveY(num, duration).SetEase(Ease.OutQuad));
			FallDeformAnimation.Append(DHHMKEJENIE.DOLocalMoveY(0f, duration).SetEase(Ease.InQuad));
		}
	}
}
