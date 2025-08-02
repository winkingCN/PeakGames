using System.Collections.Generic;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class BirdHouseItem : SpriteBasedItem
	{
		public Animator CurrentAnimator;

		public SpriteRenderer[] SortingLayers;

		public static readonly List<BirdHouseItem> BirdHouseItems = new List<BirdHouseItem>();

		private int OFGIBIKDOGB;

		private static int PACEOAECFFF;

		private static int BMLABDEBFII;

		public override int JLHIKIHDEIE
		{
			get
			{
				return BMLABDEBFII;
			}
			set
			{
				BMLABDEBFII = value;
			}
		}

		public void Start()
		{
			OFGIBIKDOGB = Animator.StringToHash("Base Layer.BirdHouseThrowAnimation");
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.BirdHouse;
		}

		public override int GetScore()
		{
			return 500;
		}

		public override bool CanFall()
		{
			return false;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return true;
		}

		public override bool CanGenerateScoreOnEachTryExplode()
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

		public override bool CanCastShadow()
		{
			return true;
		}

		public override void OnItemCreated(KFCEILFGADG MGOFDOMDLCO)
		{
			base.OnItemCreated(MGOFDOMDLCO);
			BirdHouseItems.Add(this);
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			if (SortingLayers.Length == 0)
			{
				return;
			}
			int i = 0;
			for (int num = SortingLayers.Length; i < num; i++)
			{
				SpriteRenderer spriteRenderer = SortingLayers[i];
				if (!(spriteRenderer == null))
				{
					spriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
					spriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + i;
				}
			}
		}

		public override void AfterPoolInit()
		{
			base.AfterPoolInit();
			PACEOAECFFF = 0;
		}

		public override int GetLayerCount()
		{
			return ELFBOKDHKGG.HEHOGLHPCGH(NOALGNJECAD.Bird).BNNIJEPHLBJ - PACEOAECFFF;
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			if (!ELFBOKDHKGG.NODDCJJNJEC(NOALGNJECAD.Bird))
			{
				return false;
			}
			StartCollect();
			if (CanRaiseScore())
			{
				ScoreManager.RaiseScore(GetScore());
			}
			return false;
		}

		public override void StartCollect()
		{
			PACEOAECFFF++;
			BAIKFFOGMCB();
			POIKGNFHGHM();
		}

		private void POIKGNFHGHM()
		{
			CurrentAnimator.Play(OFGIBIKDOGB, 0, 0f);
			CollectAnimation component = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Animators[0].JOBDHIPIMAG(base.transform.position).GetComponent<CollectAnimation>();
			component.Prepare(ELFBOKDHKGG, NOALGNJECAD.Bird, IPPOGIEPKEN.Collecting.EFLCPKAFOBA(), SharedImageLibrary.Instance.BirdSprite, ENCFFNKONOO).StartAnimation();
		}

		public override void PlayExplodeAudio()
		{
			AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[1]);
		}

		protected override void EJCFANPAMMK()
		{
			if (ParticlePool.Instance != null && ItemResourcesManager.GABGKBAKHDP != null)
			{
				ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[1], base.transform.position);
			}
		}

		public static void ClearAllBirdHouses()
		{
			KFCEILFGADG activeLevel = LevelBuilder.ActiveLevel;
			if (activeLevel == null)
			{
				return;
			}
			int i = 0;
			for (int count = BirdHouseItems.Count; i < count; i++)
			{
				BirdHouseItem birdHouseItem = BirdHouseItems[i];
				if (birdHouseItem != null)
				{
					birdHouseItem.StartExplode();
				}
			}
			BirdHouseItems.Clear();
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 54;
		}
	}
}
