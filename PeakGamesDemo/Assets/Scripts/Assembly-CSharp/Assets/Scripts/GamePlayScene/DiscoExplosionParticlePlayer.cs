using UnityEngine;

namespace Assets.Scripts.GamePlayScene
{
	public class DiscoExplosionParticlePlayer : ParticlePlayer
	{
		public ParticleSystem ColorDependantParticleSystem;

		public Renderer[] SortOrder;

		public void Sort(int PLCFEOMGCFK)
		{
			for (int i = 0; i < SortOrder.Length; i++)
			{
				SortOrder[i].sortingOrder = i + PLCFEOMGCFK;
			}
		}

		public void SetColor(LEDBLDKJBAI CEKMAJAHNAG)
		{
			float num;
			switch (CEKMAJAHNAG)
			{
			case LEDBLDKJBAI.Yellow:
				num = 0f;
				break;
			case LEDBLDKJBAI.Red:
				num = 6f;
				break;
			case LEDBLDKJBAI.Blue:
				num = 30f;
				break;
			case LEDBLDKJBAI.Green:
				num = 24f;
				break;
			case LEDBLDKJBAI.Purple:
				num = 12f;
				break;
			default:
				num = 18f;
				break;
			}
			ParticleSystem.TextureSheetAnimationModule textureSheetAnimation = ColorDependantParticleSystem.textureSheetAnimation;
			textureSheetAnimation.startFrame = new ParticleSystem.MinMaxCurve(num / (float)ColorDependantParticleSystem.textureSheetAnimation.spriteCount);
		}
	}
}
