using UnityEngine;

namespace GamePlayScene
{
	public class TubeBubbleParticlePlayer : MonoBehaviour
	{
		public ParticleSystem BubbleParticle;

		public ParticleSystemRenderer BubbleParticleRenderer;

		private static readonly Color GLAHBLJEOEE = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 110);

		private static readonly Color ENEOJOGBFLB = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 125);

		public void SetColor(LEDBLDKJBAI JOCKKMJBJLL)
		{
			Color color = ((JOCKKMJBJLL != 0) ? GLAHBLJEOEE : ENEOJOGBFLB);
			ParticleSystem.MainModule main = BubbleParticle.main;
			main.startColor = color;
		}

		public void SetQuality(int DOEJONCJABI)
		{
			if (DOEJONCJABI < 4)
			{
				Object.Destroy(base.gameObject);
				base.gameObject.SetActive(false);
			}
		}
	}
}
