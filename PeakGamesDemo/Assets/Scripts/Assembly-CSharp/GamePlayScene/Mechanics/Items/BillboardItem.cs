using System.Collections.Generic;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class BillboardItem : SpriteBasedItem
	{
		public SpriteRenderer[] BillboardSpriteRenderers;

		public SpriteRenderer PlugSpriteRenderer;

		public SpriteRenderer GlowSpriteRenderer;

		[HideInInspector]
		public BillboardItem MasterItem;

		[HideInInspector]
		public bool IsMasterItem;

		[HideInInspector]
		public int BillboardId;

		private static int CDHPFIBLBLO;

		protected List<BillboardItem> LNOLHNHBOFL;

		protected int OFBJAPEKABK;

		protected bool NMHGGIFDPOB;

		private int LOMAIAPMHED;

		private bool PHFMLILLELO = true;

		private CKKKELDIOLD KKCPOOALFAD;

		private readonly int[] BAJHMMMEJLN = new int[4];

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Billboard;
		}

		public override int GetScore()
		{
			return 500;
		}

		public override bool CanRaiseScore()
		{
			return true;
		}

		public override bool CanFall()
		{
			return false;
		}

		public override bool CanShadowDrop()
		{
			return true;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return true;
		}

		public override bool CanGenerateScoreOnEachTryExplode()
		{
			return PHFMLILLELO;
		}

		public override bool CanBeTapped()
		{
			return false;
		}

		public override bool CanGenerateScoreWithoutExplode()
		{
			return true;
		}

		public override bool CanBeInsideBubble()
		{
			return false;
		}

		public override bool CanBeInsideCellItem()
		{
			return false;
		}

		public override void PlayWrongMove()
		{
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			KKCPOOALFAD = IBBBMACIBGK;
			int num = BillboardSpriteRenderers.Length;
			PlugSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			PlugSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 60;
			for (int i = 0; i < num; i++)
			{
				BillboardSpriteRenderers[i].sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
				BillboardSpriteRenderers[i].sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + BAJHMMMEJLN[i];
			}
			CurrentSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			CurrentSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 70;
			GlowSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			GlowSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 101;
		}

		public override int GetLayerCount()
		{
			return (!NMHGGIFDPOB) ? 1 : 0;
		}

		private void PHNNOICOIAE()
		{
			CFOIPDKEFMM currentGrid = ENCFFNKONOO.CurrentGrid;
			bool cNLILOEEBOJ = KAKNFABBOIC(currentGrid.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Up));
			bool cNLILOEEBOJ2 = KAKNFABBOIC(currentGrid.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Down));
			bool aMFCENFNAJJ = KAKNFABBOIC(currentGrid.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Left));
			bool aMFCENFNAJJ2 = KAKNFABBOIC(currentGrid.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Right));
			BHFGLGPDLIC(BillboardSpriteRenderers[0], aMFCENFNAJJ, cNLILOEEBOJ, IEKBFJBLGFM.LeftUp, false, false);
			BHFGLGPDLIC(BillboardSpriteRenderers[1], aMFCENFNAJJ2, cNLILOEEBOJ, IEKBFJBLGFM.RightUp, true, false);
			BHFGLGPDLIC(BillboardSpriteRenderers[2], aMFCENFNAJJ2, cNLILOEEBOJ2, IEKBFJBLGFM.RightDown, true, true);
			BHFGLGPDLIC(BillboardSpriteRenderers[3], aMFCENFNAJJ, cNLILOEEBOJ2, IEKBFJBLGFM.LeftDown, false, true);
		}

		private void BHFGLGPDLIC(SpriteRenderer CGGMEBGANNC, bool AMFCENFNAJJ, bool CNLILOEEBOJ, IEKBFJBLGFM DGPLFNDFALP, bool MPOPLONGCDK, bool EDPLFAIMJLH)
		{
			Sprite sprite;
			if (!AMFCENFNAJJ || !CNLILOEEBOJ)
			{
				sprite = (AMFCENFNAJJ ? ((!EDPLFAIMJLH) ? SharedImageLibrary.Instance.Billboard_B_Up : SharedImageLibrary.Instance.Billboard_B_Down) : ((!CNLILOEEBOJ) ? ((!EDPLFAIMJLH) ? SharedImageLibrary.Instance.Billboard_A_Up : SharedImageLibrary.Instance.Billboard_A_Down) : ((!EDPLFAIMJLH) ? SharedImageLibrary.Instance.Billboard_E_Up : SharedImageLibrary.Instance.Billboard_E_Down)));
			}
			else if (KAKNFABBOIC(ENCFFNKONOO.CurrentGrid.PHOOMEOBJCB(ENCFFNKONOO, DGPLFNDFALP)))
			{
				sprite = ((!EDPLFAIMJLH) ? SharedImageLibrary.Instance.Billboard_D_Up : SharedImageLibrary.Instance.Billboard_D_Down);
			}
			else
			{
				sprite = ((!EDPLFAIMJLH) ? SharedImageLibrary.Instance.Billboard_C_Up : SharedImageLibrary.Instance.Billboard_C_Down);
				CGGMEBGANNC.transform.localPosition = new Vector3((!MPOPLONGCDK) ? (-0.5f) : 0.5f, (!EDPLFAIMJLH) ? 0.4f : (-0.6f), 0f);
				CurrentSpriteRenderer.transform.localPosition = ((!EDPLFAIMJLH) ? new Vector3(0f, -0.03f, 0f) : new Vector3(0f, -0.15f, 0f));
				PlugSpriteRenderer.transform.localPosition = ((!EDPLFAIMJLH) ? new Vector3(0f, -0.052f, 0f) : new Vector3(0f, -0.1f, 0f));
				IEKBFJBLGFM aJLDJAHHGOJ = ((!EDPLFAIMJLH) ? IEKBFJBLGFM.Up : ((!MPOPLONGCDK) ? IEKBFJBLGFM.Left : IEKBFJBLGFM.Right));
				Cell cell = ENCFFNKONOO.CurrentGrid.PHOOMEOBJCB(ENCFFNKONOO, aJLDJAHHGOJ);
				if (cell != null && cell.EAILOFHFNJO)
				{
					BillboardItem component = cell.LBFCDKPCDPB.GetComponent<BillboardItem>();
					SpriteRenderer spriteRenderer = ((!MPOPLONGCDK) ? component.BillboardSpriteRenderers[(!EDPLFAIMJLH) ? 3 : 2] : component.BillboardSpriteRenderers[(!EDPLFAIMJLH) ? 2 : 3]);
					if (spriteRenderer.enabled)
					{
						spriteRenderer.enabled = false;
					}
				}
				if (EDPLFAIMJLH)
				{
					BAJHMMMEJLN[(!MPOPLONGCDK) ? 3 : 2] = -80;
				}
				else
				{
					BAJHMMMEJLN[MPOPLONGCDK ? 1 : 0] = 1;
				}
				ChangeSorting(KKCPOOALFAD);
			}
			CGGMEBGANNC.sprite = sprite;
			CGGMEBGANNC.flipX = MPOPLONGCDK;
		}

		private bool KAKNFABBOIC(Cell LBHDELJBONF)
		{
			return LBHDELJBONF != null && LBHDELJBONF.Exists && LBHDELJBONF.EAILOFHFNJO && LBHDELJBONF.LBFCDKPCDPB is BillboardItem && ((BillboardItem)LBHDELJBONF.LBFCDKPCDPB).BillboardId == BillboardId;
		}

		public virtual void LinkNeighbours(Cell LBHDELJBONF)
		{
			if (!LBHDELJBONF.Exists || !LBHDELJBONF.EAILOFHFNJO)
			{
				return;
			}
			BillboardItem billboardItem = LBHDELJBONF.LBFCDKPCDPB as BillboardItem;
			if (billboardItem == null || billboardItem.MasterItem != null || billboardItem.IsMasterItem)
			{
				billboardItem = LBHDELJBONF.LBFCDKPCDPB.GetSubItem() as BillboardItem;
				if (billboardItem == null || billboardItem.MasterItem != null || billboardItem.IsMasterItem)
				{
					return;
				}
			}
			if (billboardItem == this)
			{
				IsMasterItem = true;
				OFBJAPEKABK = 1;
				BillboardId = CDHPFIBLBLO;
				CDHPFIBLBLO++;
				if (LNOLHNHBOFL == null)
				{
					LNOLHNHBOFL = new List<BillboardItem>();
				}
			}
			else
			{
				OFBJAPEKABK++;
				billboardItem.MasterItem = this;
				billboardItem.BillboardId = BillboardId;
				LNOLHNHBOFL.Add(billboardItem);
			}
			CFOIPDKEFMM currentGrid = LBHDELJBONF.CurrentGrid;
			Cell cell = currentGrid.PHOOMEOBJCB(LBHDELJBONF, IEKBFJBLGFM.Left);
			if (cell != null)
			{
				LinkNeighbours(cell);
			}
			Cell cell2 = currentGrid.PHOOMEOBJCB(LBHDELJBONF, IEKBFJBLGFM.Right);
			if (cell2 != null)
			{
				LinkNeighbours(cell2);
			}
			Cell cell3 = currentGrid.PHOOMEOBJCB(LBHDELJBONF, IEKBFJBLGFM.Up);
			if (cell3 != null)
			{
				LinkNeighbours(cell3);
			}
			Cell cell4 = currentGrid.PHOOMEOBJCB(LBHDELJBONF, IEKBFJBLGFM.Down);
			if (cell4 != null)
			{
				LinkNeighbours(cell4);
			}
			billboardItem.PHNNOICOIAE();
		}

		public override void PlayExplodeAudio()
		{
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[2]);
			}
		}

		protected override void EJCFANPAMMK()
		{
			if (ParticlePool.Instance != null && ItemResourcesManager.GABGKBAKHDP != null)
			{
				ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[1], base.transform.position);
			}
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			LOMAIAPMHED++;
			if (LOMAIAPMHED > 1)
			{
				PHFMLILLELO = false;
			}
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			if (NMHGGIFDPOB)
			{
				return false;
			}
			NMHGGIFDPOB = true;
			ELFBOKDHKGG.ACJOALJFMHN(NOALGNJECAD.Billboard, false);
			CurrentSpriteRenderer.enabled = false;
			GlowSpriteRenderer.enabled = false;
			ItemResources itemResources = null;
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				itemResources = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType());
			}
			if (ParticlePool.Instance != null && itemResources != null)
			{
				ParticlePool.Instance.PlayParticle(itemResources.Particles[0], base.transform.position);
			}
			if (itemResources != null)
			{
				AudioManager.PlayAudioProps(itemResources.AudioClips[0]);
			}
			if (MasterItem != null)
			{
				MasterItem.NotifyItemCollected();
			}
			else
			{
				NotifyItemCollected();
			}
			if (CCPAJBOJDMN.JKJHJDLHCMD)
			{
				ScoreManager.RaiseScore(GetScore());
			}
			return false;
		}

		public void NotifyItemCollected()
		{
			OFBJAPEKABK--;
			if (OFBJAPEKABK != 0)
			{
				return;
			}
			if (LNOLHNHBOFL != null && LNOLHNHBOFL.Count > 0)
			{
				int count = LNOLHNHBOFL.Count;
				for (int i = 0; i < count; i++)
				{
					LNOLHNHBOFL[i].StartExplode();
				}
				LNOLHNHBOFL = null;
			}
			StartExplode();
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[1]);
			}
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 98;
			byte aINNOPBDDGL = (byte)GetLayerCount();
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}
	}
}
