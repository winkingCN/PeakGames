using UnityEngine;

namespace Assets.Scripts.GamePlayScene
{
	public class ColoredCrateExplodeParticlePlayer : ParticlePlayer
	{
		public static Color ColorYellow = new Color(1f, 46f / 51f, 0f, 1f);

		public static Color ColorRed = new Color(1f, 0.19215687f, 12f / 85f, 1f);

		public static Color ColorBlue = new Color(0.16078432f, 0.654902f, 1f, 1f);

		public static Color ColorGreen = new Color(31f / 85f, 1f, 0.16078432f, 1f);

		public static Color ColorPurple = new Color(0.8509804f, 0.16078432f, 1f, 1f);

		public static Color ColorOrange = new Color(1f, 22f / 51f, 5f / 51f, 1f);

		public ParticleSystem[] ParticlesToPaint;

		public void SetColor(LEDBLDKJBAI JOCKKMJBJLL)
		{
			Color color;
			switch (JOCKKMJBJLL)
			{
			case LEDBLDKJBAI.Yellow:
				color = ColorYellow;
				break;
			case LEDBLDKJBAI.Red:
				color = ColorRed;
				break;
			case LEDBLDKJBAI.Blue:
				color = ColorBlue;
				break;
			case LEDBLDKJBAI.Green:
				color = ColorGreen;
				break;
			case LEDBLDKJBAI.Purple:
				color = ColorPurple;
				break;
			default:
				color = ColorOrange;
				break;
			}
			for (int i = 0; i < ParticlesToPaint.Length; i++)
			{
				ParticleSystem.MainModule main = ParticlesToPaint[i].main;
				main.startColor = color;
			}
		}
	}
}
