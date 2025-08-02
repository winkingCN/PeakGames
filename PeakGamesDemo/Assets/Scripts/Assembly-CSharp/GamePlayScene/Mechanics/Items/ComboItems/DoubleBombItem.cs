using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Mechanics.Items.SpecialItems;
using Assets.Scripts.Utils;
using DG.Tweening;
using GamePlayScene.Mechanics.Items.SpecialItems;
using UnityEngine;
using Utils;

namespace GamePlayScene.Mechanics.Items.ComboItems
{
	public class DoubleBombItem : BombItem, PGCMDKBCMHI
	{
		private ShakeAnimation[] GIEPEFMHIPA;

		public ParticleSystem[] CloseParticles;

		public SpriteRenderer GlowSprite;

		public ShakeAnimation RelativeContainerShakeAnimation;

		public ParticleSystem Sparks;

		public ParticleSystem StarGlow;

		private PBLOIKDOPAJ KPAKBHKNCNP;

		private int DLDOMGCNDLN;

		public void SetComboGroup(PBLOIKDOPAJ FNEALCOPNND)
		{
			KPAKBHKNCNP = FNEALCOPNND;
		}

		public override bool CanCastShadow()
		{
			return false;
		}

		public override void RemoveSelf()
		{
			OnBeforeRemove();
			Object.Destroy(base.gameObject);
		}

		public void AddScore(int AAIEJDNAODP)
		{
			DLDOMGCNDLN += AAIEJDNAODP;
		}

		public void Awake()
		{
			RelativeContainer.SetActive(false);
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.DoubleBomb;
		}

		public override int GetScore()
		{
			return 1000 + DLDOMGCNDLN;
		}

		public override bool CanRaiseScore()
		{
			return false;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
		}

		protected override void OOCKFIDFIPL()
		{
			ParticlePool.Instance.PlayParticle(ParticlePool.Instance.ComboCreationParticle, ENCFFNKONOO.GetFrozenPosition());
		}

		public override void PlayExplodeParticle()
		{
			ParticlePool.Instance.PlayParticle(ParticlePool.Instance.DoubleBombExplodeParticle, base.transform.position);
		}

		protected override IEnumerator GIIEJHGNGJO()
		{
			PlayRandomSpineAnimations.ComboItemWillExplode = true;
			AudioManager.Play(KOOGPFAPGGD.ComboBombBomb);
			List<Cell> list = EKGOFEBJDJD(3);
			int num = 0;
			RelativeContainer.SetActive(true);
			RelativeContainer.transform.localPosition = new Vector3(0f, -0.06f, 0f);
			Sparks.Play();
			yield return new WaitForSeconds(1.2f);
			ParticleSystem[] closeParticles = CloseParticles;
			foreach (ParticleSystem particleSystem in closeParticles)
			{
				particleSystem.Stop();
			}
			yield return new WaitForSeconds(0.2f);
			StarGlow.Play();
			GlowSprite.enabled = true;
			GlowSprite.color = new Color(1f, 1f, 1f, 0.5f);
			GlowSprite.DOColor(new Color(1f, 1f, 1f, 1f), 0.07f).SetLoops(100, LoopType.Yoyo);
			yield return MCJHHDACJBG.CNDGGNLKOOC;
			RelativeContainerShakeAnimation.Shake(0.7f, 0.06f, 0.06f);
			while (RelativeContainerShakeAnimation.IsShaking)
			{
				yield return null;
			}
			PlayExplodeParticle();
			List<ShakeAnimation> list2 = new List<ShakeAnimation>();
			for (int j = 0; j < GIEPEFMHIPA.Length; j++)
			{
				ShakeAnimation shakeAnimation = GIEPEFMHIPA[j];
				shakeAnimation.Shake(0.4f, 0.2f, 0.2f);
				list2.Add(shakeAnimation);
			}
			APBDPLNCDIJ cCPAJBOJDMN = MLENMAIAOHJ.BDAKKAIBMIM(9);
			foreach (Cell item in list)
			{
				item.RejectsFallInside();
				if (item.HasCellItem())
				{
					int score = item.FEMFMBLMKHP.GetScore();
					if (ADCAOOPHFPK(item, cCPAJBOJDMN))
					{
						num += score;
					}
					continue;
				}
				int num2 = 0;
				bool flag = false;
				Item currentItem = item.LBFCDKPCDPB;
				if (item.EAILOFHFNJO)
				{
					num2 = currentItem.GetScore();
					flag = currentItem.CanGenerateScoreWithoutExplode();
				}
				if (ADCAOOPHFPK(item, cCPAJBOJDMN))
				{
					num += SpecialItem.LPKIMIHHJCK(currentItem, item);
				}
				else if (item.EAILOFHFNJO && item.LBFCDKPCDPB.CanGenerateScoreOnEachTryExplode() && item.LBFCDKPCDPB.CanGenerateScoreThisTurn())
				{
					num += num2;
				}
				else if (!item.EAILOFHFNJO && flag && num > 0)
				{
					num += num2;
				}
			}
			ScoreManager.RaiseScore(GetScore() + num);
			RelativeContainer.SetActive(false);
			yield return new WaitForSeconds(0.41f);
			foreach (ShakeAnimation item2 in list2)
			{
				while (item2.IsShaking)
				{
					yield return null;
				}
			}
			foreach (Cell item3 in list)
			{
				item3.AcceptsFallInside();
			}
			RemoveSelf();
		}

		public override void OnBeforeRemove()
		{
			base.OnBeforeRemove();
			foreach (Cell item in KPAKBHKNCNP.OABGDODKPKM)
			{
				item.AcceptsFallInside();
			}
			FallManager.DecreaseWaitingFallBlocker();
		}

		public void AddShakeReferences(ShakeAnimation[] NCLBDOKGLIG)
		{
			GIEPEFMHIPA = NCLBDOKGLIG;
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 0;
		}
	}
}
