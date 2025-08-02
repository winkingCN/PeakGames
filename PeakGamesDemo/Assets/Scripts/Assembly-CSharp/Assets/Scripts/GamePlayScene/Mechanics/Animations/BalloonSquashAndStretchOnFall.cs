using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Animations
{
	public class BalloonSquashAndStretchOnFall : SquashAndStrechOnFall
	{
		protected override void OMFHEMIPDPL(Transform DHHMKEJENIE, float AEDMMCMLKDJ)
		{
			if (AEDMMCMLKDJ < 0f)
			{
				GOLDJAKMEDG(DHHMKEJENIE, 0.97f, 0.04f, 0f, Ease.OutQuad);
				GOLDJAKMEDG(DHHMKEJENIE, 1.05f, 0.08f, 0f, Ease.OutQuad);
				GOLDJAKMEDG(DHHMKEJENIE, 1f, 0.08f, 0f, Ease.InQuad);
			}
			else
			{
				GOLDJAKMEDG(DHHMKEJENIE, 0.97f, 0.06f, 0f, Ease.OutQuad);
				GOLDJAKMEDG(DHHMKEJENIE, 1.02f, 0.06f, 0f, Ease.OutQuad);
				GOLDJAKMEDG(DHHMKEJENIE, 1f, 0.03f, 0f, Ease.InQuad);
			}
		}
	}
}
