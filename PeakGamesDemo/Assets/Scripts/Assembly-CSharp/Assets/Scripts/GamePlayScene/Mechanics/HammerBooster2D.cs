using System;
using System.Collections;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics
{
	public class HammerBooster2D : MonoBehaviour
	{
		public Animator HitAnimator;

		public ParticleSystem ExplodeParticle;

		public LevelBuilder CurrentLevelBuilder;

		public IEnumerator PlayIn(Vector3 LDMDBPLADGD, Action AFJBKCAHEIB)
		{
			yield return null;
			AudioManager.Play(KOOGPFAPGGD.BoosterHammerEnter);
			Vector3 position = base.gameObject.transform.position;
			Vector3 value = LDMDBPLADGD - position;
			value = Vector3.Normalize(value);
			Vector3 vector = LDMDBPLADGD - 0.6f * value;
			Sequence sequence = DOTween.Sequence();
			sequence.Append(ShortcutExtensions.DOMove(duration: Vector3.Distance(position, vector) * 0.35f / 8f, target: base.gameObject.transform, endValue: vector).SetEase(Ease.Linear));
			sequence.Append(base.gameObject.transform.DOMove(LDMDBPLADGD, 1.4f).SetEase(Ease.OutElastic));
			sequence.SetEase(Ease.Linear);
			yield return new WaitForSeconds(sequence.Duration() - 1f);
			HitAnimator.SetTrigger("Hit");
			AudioManager.Play(KOOGPFAPGGD.BoosterHammerUse);
			yield return new WaitForSeconds(0.733f);
			if (AFJBKCAHEIB != null)
			{
				AFJBKCAHEIB();
			}
			ExplodeParticle.Play();
			ShakeAnimation gridShakeAnimation = CurrentLevelBuilder.FOOIMKGODLK;
			gridShakeAnimation.Shake(0.08f, 0.3f, 0.3f);
			while (gridShakeAnimation.IsShaking)
			{
				yield return null;
			}
		}
	}
}
