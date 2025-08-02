using System;
using Assets.Scripts.GamePlayScene.Mechanics.Items.Features;
using Assets.Scripts.Utils;
using GamePlayScene.Mechanics;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Items
{
	public class CageItem : SpriteBasedItem
	{
		private Item NHFMFLNPHCP;

		private Vector3? GMDKONGGFMN;

		private Item DLGCLNKHLLM;

		public Item AFAIKIMJLBP
		{
			get
			{
				return NHFMFLNPHCP;
			}
			set
			{
				NHFMFLNPHCP = value;
				if (NHFMFLNPHCP == null)
				{
					GMDKONGGFMN = null;
					return;
				}
				GameObject relativeContainer = NHFMFLNPHCP.RelativeContainer;
				if (relativeContainer == null)
				{
					return;
				}
				GMDKONGGFMN = relativeContainer.transform.localScale;
				relativeContainer.transform.localScale = relativeContainer.transform.localScale * 0.9f;
				if (NHFMFLNPHCP.CanCastShadow())
				{
					CanCastShadowComponent shadowCaster = NHFMFLNPHCP.GetShadowCaster();
					if (shadowCaster != null)
					{
						shadowCaster.HideShadow();
					}
				}
			}
		}

		protected override void DEIFPMCEKCO()
		{
			base.DEIFPMCEKCO();
			if (NHFMFLNPHCP != null)
			{
				NHFMFLNPHCP.ParentCell = ENCFFNKONOO;
			}
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			Cell currentCell = ENCFFNKONOO;
			base.ExplodeByBlasterItem(CCPAJBOJDMN);
			Item item = ExtractSubItem();
			item.ENCFFNKONOO = currentCell;
			item.PreventRaiseScore();
			item.ExplodeByBlasterItem(MLENMAIAOHJ.BDAKKAIBMIM(CCPAJBOJDMN.ENBPGGCIADN));
		}

		public override bool CanFall()
		{
			return false;
		}

		public override bool CanBeTapped()
		{
			return false;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			if (AFAIKIMJLBP != null)
			{
				NOALGNJECAD itemType = NHFMFLNPHCP.GetItemType();
				if (itemType == NOALGNJECAD.Ufo)
				{
					IBBBMACIBGK.BHIJCAOHDCM -= 300;
				}
				AFAIKIMJLBP.ChangeSorting(IBBBMACIBGK);
				if (itemType == NOALGNJECAD.Ufo)
				{
					IBBBMACIBGK.BHIJCAOHDCM += 300;
				}
			}
			IBBBMACIBGK.BHIJCAOHDCM += 20;
			base.ChangeSorting(IBBBMACIBGK);
		}

		public override Item ExtractSubItem()
		{
			if (!(NHFMFLNPHCP == null))
			{
				Vector3? gMDKONGGFMN = GMDKONGGFMN;
				if (gMDKONGGFMN.HasValue)
				{
					GameObject relativeContainer = AFAIKIMJLBP.RelativeContainer;
					Transform obj = relativeContainer.transform;
					Vector3? gMDKONGGFMN2 = GMDKONGGFMN;
					obj.localScale = gMDKONGGFMN2.Value;
					AFAIKIMJLBP.ParentCell = null;
					AFAIKIMJLBP.AddToExploders(NGKLFNCDIJM);
					AFAIKIMJLBP.SetWaitTurnEndToChangeState();
					return AFAIKIMJLBP;
				}
			}
			return AFAIKIMJLBP;
		}

		public override bool CanShadowDrop()
		{
			return true;
		}

		public override void PlayExplodeAudio()
		{
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[0]);
			}
		}

		protected override void EJCFANPAMMK()
		{
			if (ParticlePool.Instance != null && ItemResourcesManager.GABGKBAKHDP != null)
			{
				ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[0], base.transform.position);
			}
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return true;
		}

		public override int GetScore()
		{
			return 0;
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Cage;
		}

		public override bool CanBeInsideBubble()
		{
			return false;
		}

		public override int GetFireworksPriority()
		{
			return (JLHIKIHDEIE > 0) ? NHFMFLNPHCP.GetFireworksPriority() : 0;
		}

		public override int SelectedByFireworks()
		{
			DLGCLNKHLLM = this;
			if (JLHIKIHDEIE == 0)
			{
				return base.SelectedByFireworks();
			}
			DLGCLNKHLLM = NHFMFLNPHCP;
			return NHFMFLNPHCP.SelectedByFireworks();
		}

		public override Item GetMasterTarget()
		{
			return DLGCLNKHLLM;
		}

		public override bool CanBeInsideCellItem()
		{
			return false;
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			AFAIKIMJLBP.GetItemSnapshotData(PNINCDLIDLL);
			byte[] bytes = BitConverter.GetBytes(PNINCDLIDLL.EEFMIHDPJPG);
			PNINCDLIDLL.BOPEPLONIFL();
			PNINCDLIDLL.EEFMIHDPJPG = 46;
			PNINCDLIDLL.DKJDLMNKFGM(bytes[BitConverter.IsLittleEndian ? 1 : 0]);
			PNINCDLIDLL.DKJDLMNKFGM(bytes[(!BitConverter.IsLittleEndian) ? 1u : 0u]);
		}
	}
}
