using System.Collections.Generic;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Mechanics.Items.SpecialItems;
using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class BarrelItem : Item
	{
		public SpriteRenderer CurrentSpriteRenderer;

		public Animator CurrentAnimator;

		public AnimationCurve AnimCurve;

		[HideInInspector]
		public int LayerCount = 3;

		private CKKKELDIOLD KKCPOOALFAD;

		private FCPPDOMBLHL AJPNGAEMOMC;

		private readonly int JJDDHAKLMLB = Animator.StringToHash("Base Layer.Barrel2-1");

		private Item BOMOBAHIHGJ;

		public void Init(FCPPDOMBLHL KEKPBEKCPNN)
		{
			AJPNGAEMOMC = KEKPBEKCPNN;
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Barrel;
		}

		public override int GetScore()
		{
			return 0;
		}

		public override CKKKELDIOLD GetSorting()
		{
			return KKCPOOALFAD;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return true;
		}

		public override void RemoveAllLayers()
		{
			LayerCount = 1;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			KKCPOOALFAD = IBBBMACIBGK;
			CurrentSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			CurrentSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM;
			SpriteRenderer shadowSpriteRenderer = GetShadowCaster().ShadowSpriteRenderer;
			shadowSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			shadowSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM - 1;
		}

		public override bool CanCastShadow()
		{
			return true;
		}

		public override int GetFireworksPriority()
		{
			return 2;
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			RemoveAllLayers();
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
			APJLLOOPLNC();
			return false;
		}

		public override Item ExtractSubItem()
		{
			Dictionary<FCPPDOMBLHL, HICNCEMBCBG> dCJNBADOLGD = ELFBOKDHKGG.DCJNBADOLGD;
			if (dCJNBADOLGD != null && dCJNBADOLGD.ContainsKey(AJPNGAEMOMC))
			{
				NOALGNJECAD nBFBPNNEKMN = dCJNBADOLGD[AJPNGAEMOMC].IBPKFANBLIG();
				BOMOBAHIHGJ = ELFBOKDHKGG.GIMBEKBFKMJ.CreateSpecialItemWithoutCell(nBFBPNNEKMN, LEDBLDKJBAI.None, base.transform.position);
				BOMOBAHIHGJ.transform.localScale = Vector3.one * 0.5f;
				Tweener t = BOMOBAHIHGJ.transform.DOScale(1f, 0.4f);
				t.SetEase(AnimCurve);
				((SpecialItem)BOMOBAHIHGJ).StartAnimations();
				BOMOBAHIHGJ.AddToExploders(NGKLFNCDIJM);
				return BOMOBAHIHGJ;
			}
			return null;
		}

		private void APJLLOOPLNC()
		{
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				ItemResources resources = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType());
				if (LayerCount == 2)
				{
					CurrentSpriteRenderer.sprite = resources.Sprites[1];
					CurrentAnimator.Play(JJDDHAKLMLB, 0, 0f);
					ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[0], base.transform.position);
				}
				else if (LayerCount == 1)
				{
					CurrentSpriteRenderer.sprite = resources.Sprites[0];
					CurrentAnimator.Play(JJDDHAKLMLB, 0, 0f);
					ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[0], base.transform.position);
				}
				AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[0]);
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
			PNINCDLIDLL.EEFMIHDPJPG = 79;
			byte aINNOPBDDGL = (byte)LayerCount;
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}
	}
}
