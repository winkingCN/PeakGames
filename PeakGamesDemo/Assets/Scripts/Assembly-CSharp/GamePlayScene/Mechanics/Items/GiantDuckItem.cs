using System.Collections;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Mechanics.Items.Features;
using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class GiantDuckItem : SpriteBasedItem, JFIEHOCCBNG
	{
		public Animator CurrentAnimator;

		public GiantDuckFakeItem BottomRight;

		public GiantDuckFakeItem TopLeft;

		public GiantDuckFakeItem TopRight;

		public SpriteRenderer[] SpriteRenderers;

		private bool AKOILMHBBOH;

		private bool NHINLAKMBJI;

		private bool DCLNINACKPD;

		private bool IPBHPDGMEIO;

		private static int EFBMJDGOAGO;

		private static int[] DAJLHJICGJN;

		private static float FIDHDFBLPFC;

		private Sequence CECMMIBAAIG;

		public override Cell ENCFFNKONOO
		{
			get
			{
				return base.ENCFFNKONOO;
			}
			set
			{
				base.ENCFFNKONOO = value;
				if (ENCFFNKONOO != null)
				{
					TopLeft.ENCFFNKONOO = ENCFFNKONOO.CurrentGrid.ECNCPJGHBIG(ENCFFNKONOO.X, ENCFFNKONOO.Y + 1);
					TopRight.ENCFFNKONOO = ENCFFNKONOO.CurrentGrid.ECNCPJGHBIG(ENCFFNKONOO.X + 1, ENCFFNKONOO.Y + 1);
					BottomRight.ENCFFNKONOO = ENCFFNKONOO.CurrentGrid.ECNCPJGHBIG(ENCFFNKONOO.X + 1, ENCFFNKONOO.Y);
				}
				else
				{
					TopLeft.ENCFFNKONOO = null;
					TopRight.ENCFFNKONOO = null;
					BottomRight.ENCFFNKONOO = null;
				}
			}
		}

		public void Start()
		{
			if (DAJLHJICGJN == null)
			{
				DAJLHJICGJN = new int[5];
				DAJLHJICGJN[0] = Animator.StringToHash("Base Layer.GiantDuckFallAnimation");
				DAJLHJICGJN[1] = Animator.StringToHash("Base Layer.GiantDuckCollectAnimation");
				DAJLHJICGJN[2] = Animator.StringToHash("Base Layer.GiantDuckBottomLeftAnimation");
				DAJLHJICGJN[3] = Animator.StringToHash("Base Layer.GiantDuckBottomRightAnimation");
				DAJLHJICGJN[4] = Animator.StringToHash("Base Layer.GiantDuckIdleAnimation");
			}
		}

		protected override void EJCFANPAMMK()
		{
		}

		public override CollectAnimation GetCollectItem()
		{
			Vector3 position = base.transform.position;
			position.x += 0.5f;
			position.y += 0.4f;
			CollectAnimation component = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Animators[0].JOBDHIPIMAG(position).GetComponent<CollectAnimation>();
			component.Prepare(ELFBOKDHKGG, GetItemType(), GetSorting(), null, ENCFFNKONOO);
			return component;
		}

		public override void OnFallEnded()
		{
			base.OnFallEnded();
			OIEHILMEAAM();
			CurrentAnimator.Play(DAJLHJICGJN[0], -1, 0f);
			Cell currentCell = BottomRight.ENCFFNKONOO;
			if (currentCell != null)
			{
				CanCastShadowComponent.CastShadowIfPossible(currentCell);
			}
			CAEPAIMCOOK();
		}

		public override void OnFallUpdated()
		{
			base.OnFallUpdated();
			CurrentAnimator.Play(DAJLHJICGJN[4], -1, 0f);
		}

		public void ExplosionOccured(int CIDKKPKJJAE)
		{
			StartCoroutine(OHOPIODFEFA());
		}

		public override void OnItemCreated(KFCEILFGADG MGOFDOMDLCO)
		{
			base.OnItemCreated(MGOFDOMDLCO);
			FireworksController.GABGKBAKHDP.RegisterToy(this);
			FireworksController.GABGKBAKHDP.RegisterToy(BottomRight);
			ELFBOKDHKGG.OGIJEDJHMNG.Add(this);
			ELFBOKDHKGG.OGIJEDJHMNG.Add(BottomRight);
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			CurrentSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			CurrentSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 101;
			int i = 0;
			for (int num = SpriteRenderers.Length; i < num; i++)
			{
				if (!(SpriteRenderers[i] == null))
				{
					SpriteRenderers[i].sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
					SpriteRenderers[i].sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 101 + i;
				}
			}
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return true;
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (DCLNINACKPD)
			{
				ELFBOKDHKGG.OGIJEDJHMNG.Remove(this);
				ELFBOKDHKGG.OGIJEDJHMNG.Remove(BottomRight);
				return base.TryExplode(CCPAJBOJDMN);
			}
			if (!FallManager.AreThereMechanicAnimations())
			{
				AnimateOnBottomExplosion();
			}
			return false;
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.GiantDuck;
		}

		public override int GetScore()
		{
			return 10000;
		}

		public override bool CanCastShadow()
		{
			return true;
		}

		public override bool CanBeExplodedBySpecialItem()
		{
			return false;
		}

		public override bool CanBeTapped()
		{
			return false;
		}

		public override bool CanBeExplodedByBooster()
		{
			return false;
		}

		public override bool BoosterAnvilCanBeUsed()
		{
			return true;
		}

		public override bool BoosterBoxingGloveCanBeUsed()
		{
			return true;
		}

		public override bool BoosterHammerCanBeUsed()
		{
			return false;
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
		}

		public override void PlayExplodeAudio()
		{
		}

		public override int GetFireworksPriority()
		{
			return -1;
		}

		public override bool CanFall()
		{
			Cell currentCell = BottomRight.ENCFFNKONOO;
			Cell firstExistingBottomCell = currentCell.FirstExistingBottomCell;
			return !currentCell.Exists || (firstExistingBottomCell != null && firstExistingBottomCell.Exists && !firstExistingBottomCell.EAILOFHFNJO && firstExistingBottomCell.CanItemsFallInside());
		}

		private IEnumerator DOKCOLJIDGJ()
		{
			HAPDHAKJDBL();
			Vector3 position = base.transform.position;
			position.y += 0.4f;
			if (ParticlePool.Instance != null)
			{
				ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[0], position);
			}
			AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[0]);
			CurrentAnimator.Play(DAJLHJICGJN[1], -1, 0f);
			yield return new WaitForSeconds(0.25f + 0.1f * (float)BIGLLOFCIHK());
			if (NHINLAKMBJI)
			{
				FallManager.DecreaseStatAnimation();
				NHINLAKMBJI = false;
			}
			DCLNINACKPD = true;
			if (ENCFFNKONOO != null)
			{
				ENCFFNKONOO.CurrentGrid.EJBPCMDJFEM(ENCFFNKONOO, MLENMAIAOHJ.BDAKKAIBMIM(1));
			}
		}

		private void HAPDHAKJDBL()
		{
			CKKKELDIOLD iBBBMACIBGK = IPPOGIEPKEN.PlayDuckSorting.EFLCPKAFOBA();
			ChangeSorting(iBBBMACIBGK);
		}

		private void OIEHILMEAAM()
		{
			if (CECMMIBAAIG != null)
			{
				CECMMIBAAIG.Kill(true);
			}
			CECMMIBAAIG = DOTween.Sequence();
			CKKKELDIOLD sorting = GetSorting();
			sorting.BHIJCAOHDCM += 249;
			ChangeSorting(sorting);
			CECMMIBAAIG.SetDelay(0.45f);
			CECMMIBAAIG.OnComplete(DEIFPMCEKCO);
		}

		private static int BIGLLOFCIHK()
		{
			float time = Time.time;
			if (time - FIDHDFBLPFC > 0.1f)
			{
				EFBMJDGOAGO = 0;
				FIDHDFBLPFC = time;
				return EFBMJDGOAGO;
			}
			EFBMJDGOAGO++;
			FIDHDFBLPFC = time;
			return EFBMJDGOAGO;
		}

		public void Update()
		{
			if (AKOILMHBBOH || SlowCheckTime.ShouldPass() || IsFalling)
			{
				return;
			}
			Cell currentCell = BottomRight.ENCFFNKONOO;
			if (((!(ENCFFNKONOO == null) && ENCFFNKONOO.IsFloor) || (!(currentCell == null) && currentCell.IsFloor)) && !ENCFFNKONOO.HasCellItem() && !currentCell.HasCellItem() && !ENCFFNKONOO.CGLFCDDLOKA && !currentCell.CGLFCDDLOKA)
			{
				AKOILMHBBOH = true;
				ELFBOKDHKGG.LCKKMCJDDBC(NOALGNJECAD.Duck);
				if (!NHINLAKMBJI)
				{
					NHINLAKMBJI = true;
					FallManager.IncreaseStatAnimation();
				}
				StartCoroutine(DOKCOLJIDGJ());
			}
		}

		public void AnimateOnBottomExplosion()
		{
			if (IPBHPDGMEIO || ENCFFNKONOO == null || BottomRight.ENCFFNKONOO == null)
			{
				return;
			}
			Cell cell = ENCFFNKONOO.CurrentGrid.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Down);
			Cell cell2 = ENCFFNKONOO.CurrentGrid.PHOOMEOBJCB(BottomRight.ENCFFNKONOO, IEKBFJBLGFM.Down);
			if (cell == null || cell2 == null)
			{
				return;
			}
			bool hasItem = cell.EAILOFHFNJO;
			bool hasItem2 = cell2.EAILOFHFNJO;
			if (hasItem || hasItem2)
			{
				if (!hasItem)
				{
					CurrentAnimator.Play(DAJLHJICGJN[2], -1, 0f);
					OIEHILMEAAM();
					IPBHPDGMEIO = true;
				}
				if (!hasItem2)
				{
					CurrentAnimator.Play(DAJLHJICGJN[3], -1, 0f);
					OIEHILMEAAM();
					IPBHPDGMEIO = true;
				}
			}
		}

		private IEnumerator OHOPIODFEFA()
		{
			yield return null;
			CAEPAIMCOOK();
		}

		private void CAEPAIMCOOK()
		{
			if (ENCFFNKONOO == null || BottomRight.ENCFFNKONOO == null)
			{
				return;
			}
			Cell cell = ENCFFNKONOO.CurrentGrid.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Down);
			Cell cell2 = ENCFFNKONOO.CurrentGrid.PHOOMEOBJCB(BottomRight.ENCFFNKONOO, IEKBFJBLGFM.Down);
			if (cell == null || cell2 == null)
			{
				IPBHPDGMEIO = false;
				return;
			}
			if (cell.EAILOFHFNJO && cell2.EAILOFHFNJO)
			{
				IPBHPDGMEIO = false;
			}
			if (!cell.EAILOFHFNJO || !cell2.EAILOFHFNJO)
			{
				IPBHPDGMEIO = true;
			}
		}

		public override bool CanBeInsideBubble()
		{
			return false;
		}

		public override bool CanBeCollectedWithAnimation()
		{
			return true;
		}

		private void OnDestroy()
		{
			if (CECMMIBAAIG != null)
			{
				CECMMIBAAIG.Kill();
			}
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 121;
		}
	}
}
