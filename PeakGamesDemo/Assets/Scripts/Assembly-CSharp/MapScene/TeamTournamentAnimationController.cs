using UnityEngine;

namespace MapScene
{
	public class TeamTournamentAnimationController : MonoBehaviour
	{
		public ParticleSystem[] BackgroundParticles;

		public ParticleSystem FlameParticle;

		public void PlayParticle()
		{
			FlameParticle.Play();
		}

		public void StartParticles()
		{
			for (int i = 0; i < BackgroundParticles.Length; i++)
			{
				BackgroundParticles[i].Play();
				BackgroundParticles[i].playOnAwake = true;
			}
		}
	}
}
