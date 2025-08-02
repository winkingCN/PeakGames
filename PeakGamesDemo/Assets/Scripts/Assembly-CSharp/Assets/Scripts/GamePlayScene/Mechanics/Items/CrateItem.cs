using Assets.Scripts.Utils;
using GamePlayScene.Mechanics;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Items
{
	public class CrateItem : SpriteBasedItem
	{
		[HideInInspector]
		public int LayerCount;

		public override bool CanFall()
		{
			return false;
		}

		public override bool CanBeTapped()
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

		public override int GetScore()
		{
			return 500;
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Crate;
		}

		public override void RemoveAllLayers()
		{
			LayerCount = 1;
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			RemoveAllLayers();
			base.ExplodeByBlasterItem(CCPAJBOJDMN);
		}

		public override int GetLayerCount()
		{
			return LayerCount;
		}

		public override void PlayExplodeAudio()
		{
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[0]);
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
			IJHJKAFNKJJ();
			return false;
		}

		protected override void EJCFANPAMMK()
		{
			if (ParticlePool.Instance != null && ItemResourcesManager.GABGKBAKHDP != null)
			{
				ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[1], base.transform.position);
			}
		}

		protected virtual void IJHJKAFNKJJ()
		{
			int layerCount = LayerCount;
			if ((layerCount == 3 || layerCount == 2 || layerCount == 1) && ParticlePool.Instance != null && ItemResourcesManager.GABGKBAKHDP != null)
			{
				AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[1]);
				ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[0], base.transform.position);
			}
			int num = LayerCount - 1;
			if (num < SharedImageLibrary.Instance.CrateLayerSprites.Length)
			{
				CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.CrateLayerSprites[num];
			}
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = (short)(65 + LayerCount - 1);
		}
	}
}
