using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.Utils;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics
{
	public class BoxingGloveBooster : MonoBehaviour
	{
		public LevelBuilder CurrentLevelBuilder;

		public Animator BoxingGloveAnimator;

		public SpriteRenderer BoxingGloveSprite;

		public Transform Position;

		public ParticleSystem ExplodeParticle;

		public ParticleSystem HitParticle;

		private int MAHBIBIBLIP;

		private int MHGHAMNCMGD;

		private List<ShakeAnimation> FLMDMNCDOGI;

		public void Awake()
		{
			MAHBIBIBLIP = Animator.StringToHash("Base Layer.BoxingGloveInAnimation");
			MHGHAMNCMGD = Animator.StringToHash("Base Layer.BoxingGloveOutAnimation");
		}

		public void PlayAnimationIn(float GNGLLMMGOJI)
		{
			BoxingGloveAnimator.speed = 1f / GNGLLMMGOJI;
			BoxingGloveAnimator.Play(MAHBIBIBLIP, 0, 0f);
			ExplodeParticle.gameObject.SetActive(true);
			ExplodeParticle.Play();
			AudioManager.Play(KOOGPFAPGGD.BoosterBoxing);
		}

		public void PlayAnimationOut()
		{
			StartCoroutine(HBAOAACFOCE());
		}

		public void ShakeScreen()
		{
			HitParticle.Play();
			ExplodeParticle.Stop();
			FLMDMNCDOGI = new List<ShakeAnimation>();
			ShakeAnimation[] panelShakeAnimations = CurrentLevelBuilder.PanelShakeAnimations;
			foreach (ShakeAnimation shakeAnimation in panelShakeAnimations)
			{
				shakeAnimation.Shake(0.08f, 0.3f, 0.3f, ShakeAnimation.DBOGAHDJDBC.X);
				FLMDMNCDOGI.Add(shakeAnimation);
			}
		}

		private IEnumerator HBAOAACFOCE()
		{
			yield return MCJHHDACJBG.IONDKKIFPHN;
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
			BoxingGloveAnimator.speed = 1.42f;
			BoxingGloveAnimator.Play(MHGHAMNCMGD, 0, 0f);
		}
	}
}
