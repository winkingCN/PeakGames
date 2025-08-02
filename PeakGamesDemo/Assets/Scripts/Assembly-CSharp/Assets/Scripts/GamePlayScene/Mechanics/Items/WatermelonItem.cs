using System.Collections;
using Assets.Scripts.Utils;
using GamePlayScene.Mechanics;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Items
{
	public class WatermelonItem : Item
	{
		[HideInInspector]
		public int LayerCount = 3;

		public Animator CurrentAnimator;

		protected readonly int HMNAMEPBIJB = Animator.StringToHash("Base Layer.Watermelon3-2");

		protected readonly int BDLALILIOOE = Animator.StringToHash("Base Layer.Watermelon2-1");

		public SpriteRenderer[] Renderers;

		private CKKKELDIOLD KKCPOOALFAD;

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

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			RemoveAllLayers();
			base.ExplodeByBlasterItem(CCPAJBOJDMN);
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			KKCPOOALFAD = IBBBMACIBGK;
			for (int i = 0; i < Renderers.Length; i++)
			{
				SpriteRenderer spriteRenderer = Renderers[i];
				spriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
				spriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + i;
			}
		}

		public override CKKKELDIOLD GetSorting()
		{
			return KKCPOOALFAD;
		}

		public override bool CanCastShadow()
		{
			return true;
		}

		public override int GetLayerCount()
		{
			return LayerCount;
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
			APJLLOOPLNC();
			return false;
		}

		private void APJLLOOPLNC()
		{
			if (LayerCount == 2)
			{
				StartCoroutine(KJKLJPBEJNH(0));
				CurrentAnimator.Play(HMNAMEPBIJB, 0, 0f);
			}
			else if (LayerCount == 1)
			{
				StartCoroutine(KJKLJPBEJNH(1));
				CurrentAnimator.Play(BDLALILIOOE, 0, 0f);
			}
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[0]);
			}
		}

		private IEnumerator KJKLJPBEJNH(int EHJNMODJEAN)
		{
			yield return new WaitForSeconds(0.04f);
			if (ParticlePool.Instance != null && ItemResourcesManager.GABGKBAKHDP != null)
			{
				ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[EHJNMODJEAN], base.transform.position);
			}
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.WaterMelon;
		}

		protected override void EJCFANPAMMK()
		{
			if (ParticlePool.Instance != null && ItemResourcesManager.GABGKBAKHDP != null)
			{
				ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[2], base.transform.position);
			}
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 91;
			byte aINNOPBDDGL = (byte)GetLayerCount();
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}
	}
}
