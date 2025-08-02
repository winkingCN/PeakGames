using System;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene
{
	public class ShadowParticlePlayer : ParticlePlayer
	{
		public ParticleSystem[] Shadows;

		public override void Play()
		{
			try
			{
				if (Shadows.Length == 0)
				{
					return;
				}
				uint randomSeed = (uint)UnityEngine.Random.Range(0, 10000);
				for (int i = 0; i < Shadows.Length; i++)
				{
					if (Shadows[i] == null)
					{
						return;
					}
					if (i % 2 == 0)
					{
						randomSeed = (uint)UnityEngine.Random.Range(0, 10000);
					}
					Shadows[i].randomSeed = randomSeed;
				}
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Particles, "Shadow Particle Player Exception: {0} Stack:{1}", ex.Message, ex.StackTrace);
			}
			base.Play();
		}
	}
}
