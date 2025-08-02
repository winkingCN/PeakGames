using UnityEngine;

namespace Assets.Scripts.GamePlayScene
{
	public class ColoredCrateLayerRemovedParticlePlayer : ParticlePlayer
	{
		public static Color ColorYellow = new Color(1f, 0.70980394f, 0f, 1f);

		public static Color ColorRed = new Color(78f / 85f, 12f / 85f, 12f / 85f, 1f);

		public static Color ColorBlue = new Color(0.03137255f, 0.4862745f, 1f, 1f);

		public static Color ColorGreen = new Color(6f / 85f, 0.78039217f, 0.12156863f, 1f);

		public static Color ColorPurple = new Color(0.7019608f, 2f / 15f, 1f, 1f);

		public static Color ColorOrange = new Color(1f, 0.4745098f, 1f / 17f, 1f);

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
