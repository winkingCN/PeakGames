using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using UnityEngine;

public class AnvilBooster : MonoBehaviour
{
	public SpriteRenderer AnvilSpriteRenderer;

	public ParticleSystem TrailSmokeParticle;

	public LevelBuilder CurrentLevelBuilder;

	private List<ShakeAnimation> FLMDMNCDOGI;

	public void PlayHit()
	{
		TrailSmokeParticle.Stop();
		Vector3 position = base.transform.position;
		position.y += 1.95f;
		ParticlePool.Instance.PlayParticle(ParticlePool.Instance.AnvilHitParticle, position);
		AnvilSpriteRenderer.enabled = false;
		FLMDMNCDOGI = new List<ShakeAnimation>();
		for (int i = 0; i < CurrentLevelBuilder.PanelShakeAnimations.Length; i++)
		{
			ShakeAnimation shakeAnimation = CurrentLevelBuilder.PanelShakeAnimations[i];
			shakeAnimation.Shake(0.2f, 0.3f, 0f, ShakeAnimation.DBOGAHDJDBC.Y);
			FLMDMNCDOGI.Add(shakeAnimation);
		}
	}

	public IEnumerator GetWaiter()
	{
		if (FLMDMNCDOGI != null)
		{
			for (int i = 0; i < FLMDMNCDOGI.Count; i++)
			{
				if (FLMDMNCDOGI[i].IsShaking)
				{
					yield return null;
				}
			}
		}
		yield return null;
	}
}
