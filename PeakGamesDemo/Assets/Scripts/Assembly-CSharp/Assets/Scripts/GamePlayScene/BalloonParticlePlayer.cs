using UnityEngine;

namespace Assets.Scripts.GamePlayScene
{
	public class BalloonParticlePlayer : ParticlePlayer
	{
		public static Color ColorPink = new Color(1f, 13f / 51f, 29f / 51f, 1f);

		public ParticleSystem[] ParticlesToPaint;

		public void SetColor()
		{
			for (int i = 0; i < ParticlesToPaint.Length; i++)
			{
				ParticleSystem.MainModule main = ParticlesToPaint[i].main;
				main.startColor = ColorPink;
			}
		}
	}
}
