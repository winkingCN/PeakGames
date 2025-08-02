using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Mechanics.Items.SpecialItems;
using Assets.Scripts.Utils;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items.SpecialItems
{
	public class BombItem : SpecialItem
	{
		public GameObject Particle;

		private float GMHCHPCEEHL = 0.1f;

		public virtual void PlayExplodeParticle()
		{
			if (ParticlePool.Instance != null)
			{
				ParticlePool.Instance.PlayParticle(ParticlePool.Instance.BombExplodeParticle, base.transform.position);
			}
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Bomb;
		}

		public override bool CanCastShadow()
		{
			return true;
		}

		public override void OnCellItemExploded()
		{
			if (Particle != null && !Particle.activeSelf)
			{
				Particle.SetActive(true);
			}
		}

		public override void OnItemCreated(KFCEILFGADG MGOFDOMDLCO)
		{
			base.OnItemCreated(MGOFDOMDLCO);
			if (Particle != null)
			{
				Particle.SetActive(false);
			}
			if (CanCastShadow())
			{
				GetShadowCaster().HideShadow();
			}
		}

		protected override void DEIFPMCEKCO()
		{
			base.DEIFPMCEKCO();
			if (Particle != null)
			{
				Particle.SetActive(IsActive);
			}
		}

		public override void AfterPoolInit()
		{
			base.AfterPoolInit();
			GMHCHPCEEHL = 0f;
		}

		public override void RemoveSelf()
		{
			OnBeforeRemove();
			if (ShouldRecycleInstantly)
			{
				base.gameObject.MEJPNNFDEBD();
			}
			else
			{
				base.gameObject.SetActive(false);
			}
		}

		public override void OnCellItemCreated()
		{
			base.OnCellItemCreated();
			Particle.SetActive(false);
		}

		public override void StartAnimations()
		{
			Particle.SetActive(true);
		}

		protected override IEnumerator GIIEJHGNGJO()
		{
			List<Cell> list = EKGOFEBJDJD(1);
			AudioManager.Play(KOOGPFAPGGD.ItemSpecialBomb);
			yield return new WaitForSeconds(GMHCHPCEEHL);
			PlayExplodeParticle();
			yield return MCJHHDACJBG.CNDGGNLKOOC;
			int num = 0;
			APBDPLNCDIJ cCPAJBOJDMN = MLENMAIAOHJ.BDAKKAIBMIM(8);
			for (int i = 0; i < list.Count; i++)
			{
				Cell cell = list[i];
				cell.RejectsFallInside();
				if (cell.HasCellItem())
				{
					int score = cell.FEMFMBLMKHP.GetScore();
					if (ADCAOOPHFPK(cell, cCPAJBOJDMN))
					{
						num += score;
					}
					continue;
				}
				int num2 = 0;
				bool flag = false;
				Item currentItem = cell.LBFCDKPCDPB;
				if (cell.EAILOFHFNJO)
				{
					if (currentItem.GetItemType() == NOALGNJECAD.Bomb)
					{
						((BombItem)currentItem).GMHCHPCEEHL = 0.1f;
					}
					num2 = currentItem.GetScore();
					flag = currentItem.CanGenerateScoreWithoutExplode();
				}
				if (ADCAOOPHFPK(cell, cCPAJBOJDMN))
				{
					num += SpecialItem.LPKIMIHHJCK(currentItem, cell);
				}
				else if (cell.EAILOFHFNJO && cell.LBFCDKPCDPB.CanGenerateScoreOnEachTryExplode() && cell.LBFCDKPCDPB.CanGenerateScoreThisTurn())
				{
					num += num2;
				}
				else if (!cell.EAILOFHFNJO && flag && num > 0)
				{
					num += num2;
				}
			}
			ScoreManager.RaiseScore(GetScore() + num);
			yield return new WaitForSeconds(0.05f);
			foreach (Cell item in list)
			{
				item.AcceptsFallInside();
			}
			RemoveSelf();
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			if (CurrentComboHintParticle == null)
			{
				CurrentSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
				CurrentSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 1;
			}
			else
			{
				CurrentComboHintParticle.Sort(IBBBMACIBGK.BHIJCAOHDCM + 150);
				CurrentSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
				CurrentSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 152;
			}
		}

		protected List<Cell> EKGOFEBJDJD(int MOFHAKELNPN)
		{
			CFOIPDKEFMM currentGrid = ENCFFNKONOO.CurrentGrid;
			List<Cell> list = new List<Cell>();
			for (int i = ENCFFNKONOO.X - MOFHAKELNPN; i <= ENCFFNKONOO.X + MOFHAKELNPN; i++)
			{
				for (int j = ENCFFNKONOO.Y - MOFHAKELNPN; j <= ENCFFNKONOO.Y + MOFHAKELNPN; j++)
				{
					if (i >= 0 && i < currentGrid.EMFKAPJMDCC && j >= 0 && j < currentGrid.FHAMOHDEGMK)
					{
						list.Add(currentGrid.ECNCPJGHBIG(i, j));
					}
				}
			}
			return list;
		}

		public override int GetScore()
		{
			return 500;
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 83;
		}
	}
}
