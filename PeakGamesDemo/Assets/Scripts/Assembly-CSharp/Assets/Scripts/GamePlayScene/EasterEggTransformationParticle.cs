using UnityEngine;

namespace Assets.Scripts.GamePlayScene
{
	public class EasterEggTransformationParticle : ParticlePlayer
	{
		public ParticleSystemRenderer MainRenderer;

		public void SetStartColors(Color ELLOILOPDJC, int GDDGFAKOCIL)
		{
			ParticleSystem.MainModule main = MainParticle.main;
			main.startColor = ELLOILOPDJC;
			MainRenderer.sortingOrder = GDDGFAKOCIL;
		}
	}
}
