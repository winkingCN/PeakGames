using Assets.Scripts.GamePlayScene;
using UnityEngine;

namespace GamePlayScene
{
	public class LogParticlePlayer : ShadowParticlePlayer
	{
		private readonly AnimationCurve EKEHNKAPCPF = new AnimationCurve(new Keyframe(0f, -4f), new Keyframe(1f, -2f));

		private readonly AnimationCurve OBLMIOLFIGD = new AnimationCurve(new Keyframe(0f, 4f), new Keyframe(1f, 2f));

		private readonly AnimationCurve KEAIEEIFOLO = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 0f));

		private readonly AnimationCurve FAGHJOHMHOJ = new AnimationCurve(new Keyframe(0f, 7f), new Keyframe(1f, 5f));

		private readonly AnimationCurve LPGCBJDJAIO = new AnimationCurve(new Keyframe(0f, -7f), new Keyframe(1f, -5f));

		private readonly AnimationCurve BFJKNLMADNP = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 0f));

		public void SetDirection(IEKBFJBLGFM AJLDJAHHGOJ)
		{
			if (Shadows.Length == 0)
			{
				return;
			}
			for (int i = 0; i < Shadows.Length && !(Shadows[i] == null); i++)
			{
				ParticleSystem.VelocityOverLifetimeModule velocityOverLifetime = Shadows[i].velocityOverLifetime;
				switch (AJLDJAHHGOJ)
				{
				case IEKBFJBLGFM.Left:
					velocityOverLifetime.x = new ParticleSystem.MinMaxCurve(1f, LPGCBJDJAIO, BFJKNLMADNP);
					break;
				case IEKBFJBLGFM.Right:
					velocityOverLifetime.x = new ParticleSystem.MinMaxCurve(1f, KEAIEEIFOLO, FAGHJOHMHOJ);
					break;
				case IEKBFJBLGFM.None:
					velocityOverLifetime.x = new ParticleSystem.MinMaxCurve(1f, EKEHNKAPCPF, OBLMIOLFIGD);
					break;
				}
			}
		}
	}
}
