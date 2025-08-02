using System.Collections;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using GamePlayScene.Mechanics.Animations;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class UfoItem : Item, LAGOKFDALBI
	{
		public SwapAnimation SwapAnimation;

		public Animator CurrentAnimator;

		public SpriteRenderer[] SpriteRenderers;

		private CKKKELDIOLD KKCPOOALFAD;

		private int LGKBEADLKFM;

		private int EFBMJDGOAGO;

		private int KHCNHJCOJHH;

		private int MMPCBCHKLMG;

		private bool DOPLEHGJGGB;

		private bool MNKPICPHELJ;

		private bool NHINLAKMBJI;

		private bool AKOILMHBBOH;

		private float FIDHDFBLPFC;

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Ufo;
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

		public override int GetScore()
		{
			return 2500;
		}

		protected override void EJCFANPAMMK()
		{
		}

		public override void PlayExplodeAudio()
		{
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (ENCFFNKONOO.HasBubble)
			{
				ENCFFNKONOO.RemoveBubble();
			}
		}

		public override bool CanCastShadow()
		{
			return true;
		}

		public override bool CanBeCollectedWithAnimation()
		{
			return true;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			KKCPOOALFAD = IBBBMACIBGK;
			int i = 0;
			for (int num = SpriteRenderers.Length; i < num; i++)
			{
				SpriteRenderer spriteRenderer = SpriteRenderers[i];
				if (!(spriteRenderer == null))
				{
					spriteRenderer.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
					spriteRenderer.sortingOrder = KKCPOOALFAD.BHIJCAOHDCM + 200 + i;
				}
			}
		}

		public override CKKKELDIOLD GetSorting()
		{
			return KKCPOOALFAD;
		}

		public void Start()
		{
			CurrentAnimator.StopPlayback();
			CurrentAnimator.Play(Animator.StringToHash("Base Layer.UfoItemIdleAnimation"), -1, Random.Range(0f, 1f));
		}

		public override int GetFireworksPriority()
		{
			return -1;
		}

		public override void OnItemCreated(KFCEILFGADG MGOFDOMDLCO)
		{
			base.OnItemCreated(MGOFDOMDLCO);
			FireworksController.GABGKBAKHDP.RegisterToy(this);
			UfoController.GABGKBAKHDP.RegisterUfoItem(this);
			ELFBOKDHKGG.OGLGBIKJDCP.Add(this);
			SwapAnimation.OnComplete = JMGLLENHCJF;
			KHCNHJCOJHH = ELFBOKDHKGG.ABNJCFOELCB;
			MMPCBCHKLMG = Animator.StringToHash("Base Layer.UfoItemSwapAnimation");
		}

		private void JMGLLENHCJF()
		{
			MNKPICPHELJ = false;
		}

		public void TouchOccured()
		{
			LGKBEADLKFM = Time.frameCount;
			int num = ELFBOKDHKGG.ABNJCFOELCB;
			if (KHCNHJCOJHH != num)
			{
				DOPLEHGJGGB = true;
				KHCNHJCOJHH = num;
			}
		}

		public override void OnFallUpdated()
		{
			base.OnFallUpdated();
			DOPLEHGJGGB = false;
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			return CCPAJBOJDMN.ENBPGGCIADN == 1 && base.TryExplode(CCPAJBOJDMN);
		}

		public bool TrySwap()
		{
			if (MNKPICPHELJ || !DOPLEHGJGGB || LGKBEADLKFM == Time.frameCount || ENCFFNKONOO == null || (!ENCFFNKONOO.HasCellItem() && ENCFFNKONOO.IsFloor) || FallManager.AreThereMechanicAnimations() || AJGHBDAAPAF())
			{
				return false;
			}
			DOPLEHGJGGB = false;
			MFACMIENDHB();
			return true;
		}

		private bool AJGHBDAAPAF()
		{
			CFOIPDKEFMM jHDMFHDHIFN = ELFBOKDHKGG.JHDMFHDHIFN;
			int x = ENCFFNKONOO.X;
			int y = ENCFFNKONOO.Y;
			for (int num = y; num >= 0; num--)
			{
				Cell cell = jHDMFHDHIFN.ECNCPJGHBIG(x, num);
				if (cell.Exists && cell.EAILOFHFNJO && cell.LBFCDKPCDPB.IsFalling)
				{
					return true;
				}
			}
			return false;
		}

		public void TryFall()
		{
			if (!AKOILMHBBOH && !IsFalling && !(ENCFFNKONOO == null) && ENCFFNKONOO.IsFloor && !ENCFFNKONOO.HasCellItem() && !ENCFFNKONOO.CGLFCDDLOKA)
			{
				ELFBOKDHKGG.LCKKMCJDDBC(NOALGNJECAD.Ufo);
				AKOILMHBBOH = true;
				if (!NHINLAKMBJI)
				{
					NHINLAKMBJI = true;
					FallManager.IncreaseStatAnimation();
				}
				StartCoroutine(MJKEOIILNCH());
			}
		}

		private void MFACMIENDHB()
		{
			Cell cell = ENCFFNKONOO.CurrentGrid.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Up);
			if (cell == null || !cell.Exists || cell.LMBJLCLEANK)
			{
				return;
			}
			if (!cell.EAILOFHFNJO)
			{
				CFOIPDKEFMM jHDMFHDHIFN = ELFBOKDHKGG.JHDMFHDHIFN;
				int x = ENCFFNKONOO.X;
				int y = ENCFFNKONOO.Y;
				for (int i = y + 1; i < jHDMFHDHIFN.FHAMOHDEGMK; i++)
				{
					Cell cell2 = jHDMFHDHIFN.ECNCPJGHBIG(x, i);
					if (cell2.Exists && cell2.EAILOFHFNJO)
					{
						if (cell2.LBFCDKPCDPB.CanFall())
						{
							DOPLEHGJGGB = true;
						}
						return;
					}
				}
				DOPLEHGJGGB = true;
				return;
			}
			Item currentItem = cell.LBFCDKPCDPB;
			NOALGNJECAD itemType = currentItem.GetItemType();
			if (currentItem.CanFall() && itemType != NOALGNJECAD.GiantDuck && itemType != NOALGNJECAD.Ufo)
			{
				if (currentItem.IsFalling)
				{
					DOPLEHGJGGB = true;
					return;
				}
				SwapAnimation.Swap(currentItem);
				MNKPICPHELJ = true;
			}
		}

		public void PlaySwapAnimation()
		{
			AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[0]);
			CurrentAnimator.Play(MMPCBCHKLMG, -1, 0f);
		}

		public override CollectAnimation GetCollectItem()
		{
			CollectAnimation component = Object.Instantiate(BBKCPPOFENL.Animators[0], ENCFFNKONOO.GetFrozenPosition(), Quaternion.identity).GetComponent<CollectAnimation>();
			component.Prepare(ELFBOKDHKGG, GetItemType(), GetSorting(), SharedImageLibrary.Instance.UfoGoal, ENCFFNKONOO);
			return component;
		}

		private IEnumerator MJKEOIILNCH()
		{
			if (NHINLAKMBJI)
			{
				FallManager.DecreaseStatAnimation();
				NHINLAKMBJI = false;
			}
			ENCFFNKONOO.RejectsFallInside();
			if (ENCFFNKONOO != null)
			{
				ENCFFNKONOO.CurrentGrid.EJBPCMDJFEM(ENCFFNKONOO, MLENMAIAOHJ.BDAKKAIBMIM(1));
			}
			yield return null;
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 51;
		}
	}
}
