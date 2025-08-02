using UnityEngine;

namespace GamePlayScene
{
	public class TubeSmokeParticlePlayer : MonoBehaviour
	{
		public ParticleSystem SmokeParticle;

		public ParticleSystemRenderer SmokeParticleRenderer;

		private static readonly Color MAGHPANEGDI = new Color32(byte.MaxValue, byte.MaxValue, 212, 175);

		private static readonly Color BOGGILPHKDP = new Color32(251, 205, 205, 175);

		private static readonly Color NMMMALFBGHB = new Color32(202, 236, byte.MaxValue, 175);

		private static readonly Color HFOJKMEHJJO = new Color32(189, 238, 161, 175);

		private static readonly Color HKILIDBIOMF = new Color32(238, 204, byte.MaxValue, 175);

		public void SetColor(LEDBLDKJBAI JOCKKMJBJLL)
		{
			Color color;
			switch (JOCKKMJBJLL)
			{
			default:
				color = MAGHPANEGDI;
				break;
			case LEDBLDKJBAI.Red:
				color = BOGGILPHKDP;
				break;
			case LEDBLDKJBAI.Blue:
				color = NMMMALFBGHB;
				break;
			case LEDBLDKJBAI.Green:
				color = HFOJKMEHJJO;
				break;
			case LEDBLDKJBAI.Purple:
				color = HKILIDBIOMF;
				break;
			}
			ParticleSystem.MainModule main = SmokeParticle.main;
			main.startColor = color;
		}

		public void SetQuality(int DOEJONCJABI)
		{
			if (DOEJONCJABI < 3)
			{
				Object.Destroy(base.gameObject);
			}
			else if (DOEJONCJABI < 4)
			{
				ParticleSystem.EmissionModule emission = SmokeParticle.emission;
				emission.rateOverTime = SmokeParticle.emission.rateOverTime.constant / 2f;
			}
		}
	}
}
