using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class FireworksItem : Item
	{
		public SpriteRenderer[] SpriteRenderers;

		public GameObject State_0;

		public GameObject State_1;

		public static float RocketDelayTime = 0.12f;

		public static float ExtraTime = 0.15f;

		[HideInInspector]
		public int LayerCount = 2;

		private const int PPINLPDFPJE = 3;

		private bool CHLNFLCGABM = true;

		private bool PIGCJDKPMFL;

		private CKKKELDIOLD KKCPOOALFAD;

		public override void OnItemCreated(KFCEILFGADG MGOFDOMDLCO)
		{
			base.OnItemCreated(MGOFDOMDLCO);
			State_0.SetActive(true);
			State_1.SetActive(false);
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Fireworks;
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

		public override bool CanCastShadow()
		{
			return true;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			KKCPOOALFAD = IBBBMACIBGK;
			for (int i = 0; i < SpriteRenderers.Length; i++)
			{
				if (!(SpriteRenderers[i] == null))
				{
					SpriteRenderers[i].sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
					SpriteRenderers[i].sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + i;
				}
			}
		}

		public override int GetFireworksPriority()
		{
			return (!(ENCFFNKONOO != null) || !ENCFFNKONOO.HasBubble) ? (-1) : 3;
		}

		public override bool CanFall()
		{
			return CHLNFLCGABM;
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			RemoveAllLayers();
			base.ExplodeByBlasterItem(CCPAJBOJDMN);
		}

		public override void PlayExplodeAudio()
		{
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (PIGCJDKPMFL)
			{
				return false;
			}
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			if (LayerCount == 1)
			{
				PIGCJDKPMFL = true;
				CHLNFLCGABM = false;
				FireworksController.GABGKBAKHDP.AHPHKOBCJHP = ELFBOKDHKGG.JHDMFHDHIFN;
				StartCoroutine(MGGLACFJFIC());
				return false;
			}
			LayerCount--;
			APJLLOOPLNC();
			return false;
		}

		private void APJLLOOPLNC()
		{
			try
			{
				ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[0], base.transform.position);
				State_0.SetActive(false);
				State_1.SetActive(true);
				AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[0]);
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.FireworkItem, "There is an error transforming to next layer. Error:{0} Stack:{1}", ex.Message, ex.StackTrace);
			}
		}

		protected override void EJCFANPAMMK()
		{
		}

		private IEnumerator MGGLACFJFIC()
		{
			Vector3 frozenPosition = ENCFFNKONOO.GetFrozenPosition();
			frozenPosition.y -= 0.5f;
			if (ParticlePool.Instance != null)
			{
				ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[1], frozenPosition);
			}
			FallManager.IncreaseStatAnimation();
			yield return null;
			SpriteRenderers[1].enabled = false;
			Vector3 frozenPosition2 = ENCFFNKONOO.GetFrozenPosition();
			List<FireworksRocket> list = new List<FireworksRocket>();
			for (int i = 0; i < 3; i++)
			{
				FireworksRocket component = BBKCPPOFENL.Animators[0].JOBDHIPIMAG().GetComponent<FireworksRocket>();
				component.Prepare(frozenPosition2, i);
				list.Add(component);
			}
			for (int j = 0; j < 3; j++)
			{
				list[j].Launch();
				yield return new WaitForSeconds(RocketDelayTime);
			}
			yield return new WaitForSeconds(ExtraTime);
			FallManager.DecreaseStatAnimation();
			StartExplode();
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 100;
			byte aINNOPBDDGL = (byte)LayerCount;
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}
	}
}
