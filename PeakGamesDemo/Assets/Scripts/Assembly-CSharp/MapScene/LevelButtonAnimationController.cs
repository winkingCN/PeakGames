using Assets.Scripts.Utils;
using UnityEngine;

namespace MapScene
{
	public class LevelButtonAnimationController : MonoBehaviour
	{
		public LevelButton Button;

		public ParticleSystem[] CrownParticles;

		public void StartParticles()
		{
			Button.CurrentParticle.Play();
			AudioManager.Play(KOOGPFAPGGD.UiLevelUnlock);
		}

		public void ChangeLevelText()
		{
			Button.UpdateLevelButtonText(true);
		}

		public void StartCrownParticles()
		{
			if (!Button.IsCrownEventAvailable())
			{
				return;
			}
			Button.UpdateCrownStage(true);
			if (DIGGBGADIGJ.DFGKPMCBFNL)
			{
				switch (DIGGBGADIGJ.GABGKBAKHDP.GKKBMMHNFLE)
				{
				case 0:
					CrownParticles[0].Play();
					break;
				case 1:
					CrownParticles[1].Play();
					break;
				case 2:
					CrownParticles[1].Play();
					break;
				case 3:
					break;
				}
			}
		}
	}
}
