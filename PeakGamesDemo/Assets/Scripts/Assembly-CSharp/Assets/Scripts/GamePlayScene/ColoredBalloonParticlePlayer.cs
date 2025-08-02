using UnityEngine;

namespace Assets.Scripts.GamePlayScene
{
	public class ColoredBalloonParticlePlayer : ParticlePlayer
	{
		private static readonly Color NMOBCJIGDFB = new Color(1f, 44f / 51f, 0f, 1f);

		private static readonly Color CMELIKAKIJM = new Color(41f / 51f, 1f / 51f, 5f / 51f, 1f);

		private static readonly Color JAFKHAAGNMC = new Color(4f / 51f, 0.5882353f, 1.02f, 1f);

		private static readonly Color HIKPFNHOOGF = new Color(4f / 51f, 0.7058824f, 4f / 51f, 1f);

		private static readonly Color AJBIJHCOHBG = new Color(0.7058824f, 4f / 51f, 41f / 51f, 1f);

		public ParticleSystem[] ParticlesToPaint;

		public ParticleSystem HeadParticle;

		public ParticleSystem TailParticle;

		public void SetColor(LEDBLDKJBAI JOCKKMJBJLL)
		{
			ParticleSystem.TextureSheetAnimationModule textureSheetAnimation = HeadParticle.textureSheetAnimation;
			ParticleSystem.TextureSheetAnimationModule textureSheetAnimation2 = TailParticle.textureSheetAnimation;
			float num = 4f;
			float num2 = 0f;
			Color color;
			switch (JOCKKMJBJLL)
			{
			default:
				color = NMOBCJIGDFB;
				num2 = 0f;
				break;
			case LEDBLDKJBAI.Red:
				color = CMELIKAKIJM;
				num2 = 4f / num;
				break;
			case LEDBLDKJBAI.Blue:
				color = JAFKHAAGNMC;
				num2 = 3f / num;
				break;
			case LEDBLDKJBAI.Green:
				color = HIKPFNHOOGF;
				num2 = 1f / num;
				break;
			case LEDBLDKJBAI.Purple:
				color = AJBIJHCOHBG;
				num2 = 2f / num;
				break;
			}
			textureSheetAnimation.frameOverTime = new ParticleSystem.MinMaxCurve(num2);
			textureSheetAnimation2.frameOverTime = new ParticleSystem.MinMaxCurve(num2);
			for (int i = 0; i < ParticlesToPaint.Length; i++)
			{
				ParticleSystem.MainModule main = ParticlesToPaint[i].main;
				main.startColor = color;
			}
		}
	}
}
