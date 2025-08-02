using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class PenguinItem : SpriteBasedItem
	{
		private int AJGPGBIEPJC = 1;

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Penguin;
		}

		public override bool CanFall()
		{
			return true;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return true;
		}

		public override int GetLayerCount()
		{
			return 5 - AJGPGBIEPJC;
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			if (AJGPGBIEPJC > 5)
			{
				return false;
			}
			NEOOKPAGHIN();
			if (AJGPGBIEPJC == 5)
			{
				return true;
			}
			return false;
		}

		private void NEOOKPAGHIN()
		{
			AJGPGBIEPJC++;
			ItemResources resources = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType());
			Sprite sprite = SharedImageLibrary.Instance.PenguinSprites[0];
			if (AJGPGBIEPJC == 2)
			{
				sprite = SharedImageLibrary.Instance.PenguinSprites[1];
				ParticlePool.Instance.PlayParticle(resources.Particles[0], this);
				AudioManager.PlayAudioProps(resources.AudioClips[0]);
			}
			else if (AJGPGBIEPJC == 3)
			{
				sprite = SharedImageLibrary.Instance.PenguinSprites[2];
				ParticlePool.Instance.PlayParticle(resources.Particles[1], this);
				AudioManager.PlayAudioProps(resources.AudioClips[1]);
			}
			else if (AJGPGBIEPJC == 4)
			{
				sprite = SharedImageLibrary.Instance.PenguinSprites[3];
				ParticlePool.Instance.PlayParticle(resources.Particles[2], this);
				AudioManager.PlayAudioProps(resources.AudioClips[1]);
			}
			CurrentSpriteRenderer.sprite = sprite;
		}

		public override int GetScore()
		{
			return 500;
		}

		public override void PlayExplodeAudio()
		{
			AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[2]);
		}

		protected override void EJCFANPAMMK()
		{
			ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[3], base.transform.position);
		}

		public override void RemoveAllLayers()
		{
			AJGPGBIEPJC = 4;
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			RemoveAllLayers();
			base.ExplodeByBlasterItem(CCPAJBOJDMN);
		}

		public override bool CanBeCollectedWithAnimation()
		{
			return true;
		}

		public override CollectAnimation GetCollectItem()
		{
			CollectAnimation component = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Animators[0].JOBDHIPIMAG(base.transform.position).GetComponent<CollectAnimation>();
			component.Prepare(ELFBOKDHKGG, GetItemType(), GetSorting(), null, ENCFFNKONOO);
			return component;
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 78;
			byte aINNOPBDDGL = (byte)GetLayerCount();
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}

		protected void DFBDGLFPFAB(int BGEDKGLJIGM)
		{
			AJGPGBIEPJC = BGEDKGLJIGM;
		}
	}
}
