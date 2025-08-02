using UnityEngine;

namespace Assets.Scripts.MapScene
{
	public class LevelStar : MonoBehaviour
	{
		public ParticleSystem TrailParticle;

		public SpriteRenderer StarSpriteRenderer;

		public SpriteRenderer ShadowSpriteRenderer;

		public Sprite BlurSprite;

		public Sprite StarSprite;

		[SerializeField]
		public AnimationCurve StartScaleCurve = AnimationCurve.Linear(0f, 0f, 1f, 0f);

		[SerializeField]
		public AnimationCurve EndMoveCurve = AnimationCurve.Linear(0f, 0f, 1f, 0f);
	}
}
