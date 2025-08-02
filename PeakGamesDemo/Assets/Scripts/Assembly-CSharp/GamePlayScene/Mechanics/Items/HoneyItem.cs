using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class HoneyItem : SpriteBasedItem
	{
		public Animator CurrentItemAnimator;

		private CKKKELDIOLD IFIDCMMCNLE;

		private bool KJNNJHJDNNC;

		private bool CHLNFLCGABM = true;

		private int HNHPBOOPHLK;

		public void Awake()
		{
			HNHPBOOPHLK = Animator.StringToHash("Base Layer.HoneyItemAnimation");
		}

		public override bool CanFall()
		{
			return CHLNFLCGABM;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return true;
		}

		public override bool CanCastShadow()
		{
			return true;
		}

		public override bool CanShadowDrop()
		{
			return true;
		}

		public override int GetScore()
		{
			return 500;
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Honey;
		}

		public override void BringToFront()
		{
			int bHIJCAOHDCM = 1300;
			if (ENCFFNKONOO != null)
			{
				bHIJCAOHDCM = 1300 + (10 - ENCFFNKONOO.Y * 10);
			}
			IFIDCMMCNLE.BHIJCAOHDCM = bHIJCAOHDCM;
			ChangeSorting(IFIDCMMCNLE);
			KJNNJHJDNNC = true;
		}

		public override void SendToBack()
		{
			KJNNJHJDNNC = false;
			DEIFPMCEKCO();
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			if (!KJNNJHJDNNC)
			{
				base.ChangeSorting(IBBBMACIBGK);
				IFIDCMMCNLE = IBBBMACIBGK;
			}
		}

		public override int GetLayerCount()
		{
			return (!CHLNFLCGABM) ? 1 : 2;
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			CHLNFLCGABM = false;
			base.ExplodeByBlasterItem(CCPAJBOJDMN);
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			if (CHLNFLCGABM)
			{
				CHLNFLCGABM = false;
				CurrentSpriteRenderer.sprite = BBKCPPOFENL.Sprites[0];
				ItemResources itemResources = null;
				if (ItemResourcesManager.GABGKBAKHDP != null)
				{
					itemResources = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType());
				}
				if (ParticlePool.Instance != null && itemResources != null)
				{
					ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[0], ENCFFNKONOO.GetFrozenPosition());
				}
				if (itemResources != null)
				{
					AudioManager.PlayAudioProps(itemResources.AudioClips[0]);
				}
				CurrentItemAnimator.Play(HNHPBOOPHLK, 0, 0f);
				return false;
			}
			return true;
		}

		public override void PlayExplodeAudio()
		{
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[1]);
			}
		}

		protected override void EJCFANPAMMK()
		{
			if (ParticlePool.Instance != null && ItemResourcesManager.GABGKBAKHDP != null)
			{
				ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[1], base.transform.position);
			}
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 95;
			byte aINNOPBDDGL = (byte)GetLayerCount();
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}

		protected int OGFGGPMEHCD()
		{
			return HNHPBOOPHLK;
		}

		protected void DGCBHOBKOCH(int PKHFDMGGGJN)
		{
			CHLNFLCGABM = PKHFDMGGGJN == 2;
		}
	}
}
