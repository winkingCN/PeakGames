using Assets.Scripts.GamePlayScene;
using UnityEngine;

namespace GamePlayScene
{
	public class PotionParticlePlayer : ParticlePlayer
	{
		private static readonly Color NMOBCJIGDFB = new Color(1f, 0.85f, 0.1f);

		private static readonly Color CMELIKAKIJM = new Color(1f, 0.18f, 0.18f);

		private static readonly Color JAFKHAAGNMC = new Color(0f, 0.65f, 1f);

		private static readonly Color HIKPFNHOOGF = new Color(0.17f, 1f, 0.17f);

		private static readonly Color AJBIJHCOHBG = new Color(0.96f, 0.2f, 1f);

		private static readonly Color FLHGKKJFMDJ = new Color(1f, 0.5f, 0f);

		public ParticleSystem[] ParticlesToPaint;

		public float ColorAlpha = 1f;

		public void SetColor(LEDBLDKJBAI JOCKKMJBJLL)
		{
			Color color;
			switch (JOCKKMJBJLL)
			{
			default:
				color = NMOBCJIGDFB;
				break;
			case LEDBLDKJBAI.Red:
				color = CMELIKAKIJM;
				break;
			case LEDBLDKJBAI.Blue:
				color = JAFKHAAGNMC;
				break;
			case LEDBLDKJBAI.Green:
				color = HIKPFNHOOGF;
				break;
			case LEDBLDKJBAI.Purple:
				color = AJBIJHCOHBG;
				break;
			case LEDBLDKJBAI.Orange:
				color = FLHGKKJFMDJ;
				break;
			}
			color.a = ColorAlpha;
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
