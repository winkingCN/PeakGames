using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene
{
	public class BurstModifierParticlePlayer : ParticlePlayer
	{
		public ParticleSystem[] BurstModifierParticles;

		private bool KBJHHJKDAEH;

		private List<ParticleSystem.Burst[]> NCFEAELNDOB;

		protected override void CGLBGMAHCDP()
		{
			ResetParticleCounts();
			base.CGLBGMAHCDP();
		}

		public void ResetParticleCounts()
		{
			if (NCFEAELNDOB != null && KBJHHJKDAEH)
			{
				int num = BurstModifierParticles.Length;
				for (int i = 0; i < num; i++)
				{
					ParticleSystem particleSystem = BurstModifierParticles[i];
					particleSystem.emission.SetBursts(NCFEAELNDOB[i]);
				}
			}
		}

		public void SetParticleCount(float AGFONDKEPFO)
		{
			if (NCFEAELNDOB == null)
			{
				NCFEAELNDOB = new List<ParticleSystem.Burst[]>();
				int num = BurstModifierParticles.Length;
				for (int i = 0; i < num; i++)
				{
					ParticleSystem.EmissionModule emission = BurstModifierParticles[i].emission;
					ParticleSystem.Burst[] array = new ParticleSystem.Burst[emission.burstCount];
					emission.GetBursts(array);
					NCFEAELNDOB.Add(array);
				}
			}
			int num2 = BurstModifierParticles.Length;
			for (int j = 0; j < num2; j++)
			{
				ParticleSystem.Burst[] array2 = NCFEAELNDOB[j];
				int num3 = array2.Length;
				ParticleSystem.Burst[] array3 = new ParticleSystem.Burst[num3];
				ParticleSystem.EmissionModule emission2 = BurstModifierParticles[j].emission;
				for (int k = 0; k < num3; k++)
				{
					array3[k] = array2[k];
					array3[k].minCount = (short)((float)array2[k].minCount * AGFONDKEPFO);
					array3[k].maxCount = (short)((float)array2[k].maxCount * AGFONDKEPFO);
				}
				emission2.SetBursts(array3);
			}
			KBJHHJKDAEH = true;
		}
	}
}
