using UnityEngine;

namespace Assets.Scripts.GamePlayScene
{
	public class EasterEggExplosionParticle : ParticlePlayer
	{
		private static readonly Color NMOBCJIGDFB = new Color(1f, 44f / 51f, 0f, 1f);

		private static readonly Color CMELIKAKIJM = new Color(41f / 51f, 1f / 51f, 5f / 51f, 1f);

		private static readonly Color JAFKHAAGNMC = new Color(4f / 51f, 0.5882353f, 1.02f, 1f);

		private static readonly Color HIKPFNHOOGF = new Color(4f / 51f, 0.7058824f, 4f / 51f, 1f);

		private static readonly Color AJBIJHCOHBG = new Color(0.7058824f, 4f / 51f, 41f / 51f, 1f);

		public ParticleSystem[] ParticlesToPaint;

		public ParticleSystem TexturedParticle1;

		public ParticleSystem TexturedParticle2;

		public void SetColor(LEDBLDKJBAI JOCKKMJBJLL)
		{
			Color color;
			float num;
			switch (JOCKKMJBJLL)
			{
			default:
				color = NMOBCJIGDFB;
				num = 0f;
				break;
			case LEDBLDKJBAI.Red:
				color = CMELIKAKIJM;
				num = 1f;
				break;
			case LEDBLDKJBAI.Blue:
				color = JAFKHAAGNMC;
				num = 2f;
				break;
			case LEDBLDKJBAI.Green:
				color = HIKPFNHOOGF;
				num = 3f;
				break;
			case LEDBLDKJBAI.Purple:
				color = AJBIJHCOHBG;
				num = 4f;
				break;
			}
			ParticleSystem.MinMaxCurve frameOverTime = new ParticleSystem.MinMaxCurve(num / (float)TexturedParticle1.textureSheetAnimation.spriteCount);
			ParticleSystem.TextureSheetAnimationModule textureSheetAnimation = TexturedParticle1.textureSheetAnimation;
			textureSheetAnimation.frameOverTime = frameOverTime;
			ParticleSystem.TextureSheetAnimationModule textureSheetAnimation2 = TexturedParticle2.textureSheetAnimation;
			textureSheetAnimation2.frameOverTime = frameOverTime;
			for (int i = 0; i < ParticlesToPaint.Length; i++)
			{
				if (!(ParticlesToPaint[i] == null))
				{
					ParticleSystem.MainModule main = ParticlesToPaint[i].main;
					main.startColor = color;
				}
			}
		}
	}
}
