using UnityEngine;

namespace Assets.Scripts.GamePlayScene
{
	public class SortingParticlePlayer : ParticlePlayer
	{
		public ParticleSystemRenderer FirstParticle;

		public ParticleSystemRenderer SecondParticle;

		public virtual void Sort(int EHGOOEHDNMM, int HCPGBNNFNCO = 1)
		{
			if (FirstParticle != null)
			{
				FirstParticle.sortingOrder = EHGOOEHDNMM;
			}
			if (SecondParticle != null)
			{
				SecondParticle.sortingOrder = EHGOOEHDNMM + HCPGBNNFNCO;
			}
		}
	}
}
