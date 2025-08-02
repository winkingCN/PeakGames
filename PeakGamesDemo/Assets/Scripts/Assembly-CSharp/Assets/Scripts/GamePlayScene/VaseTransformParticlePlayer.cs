using UnityEngine;

namespace Assets.Scripts.GamePlayScene
{
	public class VaseTransformParticlePlayer : ParticlePlayer
	{
		private static readonly Color NMOBCJIGDFB = new Color(1f, 44f / 51f, 0f, 1f);

		private static readonly Color CMELIKAKIJM = new Color(41f / 51f, 1f / 51f, 5f / 51f, 1f);

		private static readonly Color JAFKHAAGNMC = new Color(4f / 51f, 35f / 51f, 1.02f, 1f);

		private static readonly Color HIKPFNHOOGF = new Color(4f / 51f, 0.7058824f, 4f / 51f, 1f);

		private static readonly Color AJBIJHCOHBG = new Color(0.7058824f, 4f / 51f, 41f / 51f, 1f);

		public ParticleSystem[] ParticlesToPaint;

		public ParticleSystem SmallParticles;

		public ParticleSystem MediumParticles;

		public ParticleSystem BigParticles;

		public void SetColor(LEDBLDKJBAI JOCKKMJBJLL)
		{
			ParticleSystem.TextureSheetAnimationModule textureSheetAnimation = SmallParticles.textureSheetAnimation;
			ParticleSystem.TextureSheetAnimationModule textureSheetAnimation2 = MediumParticles.textureSheetAnimation;
			ParticleSystem.TextureSheetAnimationModule textureSheetAnimation3 = BigParticles.textureSheetAnimation;
			float num = 0f;
			Color color;
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
			ParticleSystem.MinMaxCurve frameOverTime = (textureSheetAnimation2.frameOverTime = (textureSheetAnimation.frameOverTime = new ParticleSystem.MinMaxCurve(num / (float)textureSheetAnimation.spriteCount)));
			textureSheetAnimation3.frameOverTime = frameOverTime;
			for (int i = 0; i < ParticlesToPaint.Length; i++)
			{
				ParticleSystem.MainModule main = ParticlesToPaint[i].main;
				main.startColor = color;
			}
		}
	}
}
