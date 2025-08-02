using Assets.Scripts.Utils;
using GamePlayScene.Mechanics;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Items
{
	public class LightBulbItem : SpriteBasedItem
	{
		[HideInInspector]
		public int LayerCount = 2;

		public SpriteRenderer LightOnBulb;

		public SpriteRenderer LightOnBase;

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return true;
		}

		public override void RemoveAllLayers()
		{
			LayerCount = 1;
		}

		public override int GetScore()
		{
			return 500;
		}

		public override bool CanCastShadow()
		{
			return true;
		}

		public override int GetLayerCount()
		{
			return LayerCount;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			CurrentSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			CurrentSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM;
			LightOnBulb.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			LightOnBulb.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 2;
			LightOnBase.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			LightOnBase.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM;
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			LayerCount = 1;
			base.ExplodeByBlasterItem(CCPAJBOJDMN);
		}

		public override void PlayExplodeAudio()
		{
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[1]);
			}
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			if (LayerCount == 1)
			{
				return true;
			}
			LayerCount--;
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[0]);
			}
			GAKBDCFGHFP();
			return false;
		}

		private void GAKBDCFGHFP()
		{
			if (LayerCount == 1)
			{
				CurrentSpriteRenderer.enabled = false;
				LightOnBulb.gameObject.SetActive(true);
				if (ParticlePool.Instance != null && ItemResourcesManager.GABGKBAKHDP != null)
				{
					SortingParticlePlayer sortingParticlePlayer = ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[0], RelativeContainer.transform.position) as SortingParticlePlayer;
					sortingParticlePlayer.Sort(CurrentSpriteRenderer.sortingOrder + 1);
					sortingParticlePlayer.transform.SetParent(base.gameObject.transform);
					sortingParticlePlayer.Play();
				}
			}
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.LightBulb;
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
			PNINCDLIDLL.EEFMIHDPJPG = 64;
			byte aINNOPBDDGL = (byte)LayerCount;
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}
	}
}
