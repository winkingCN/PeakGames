using System.Collections;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.Utils;
using GamePlayScene.Mechanics;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Items
{
	public class MagicHatItem : SpriteBasedItem
	{
		public GameObject CarrotParticle;

		public Animator CurrentAnimator;

		public bool SortingUpdated;

		private CKKKELDIOLD KKCPOOALFAD;

		private int OFGIBIKDOGB;

		private static int FELMPJHEBKM;

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

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.MagicHat;
		}

		public override bool CanFall()
		{
			return false;
		}

		public override bool CanBeTapped()
		{
			return false;
		}

		public override bool CanBeMatchable()
		{
			return false;
		}

		public override int GetScore()
		{
			return 500;
		}

		public override bool CanBeExplodedBySpecialItem()
		{
			return true;
		}

		public override bool CanBeExplodedByBooster()
		{
			return true;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return true;
		}

		public override bool CanCastShadow()
		{
			return true;
		}

		public void Start()
		{
			OFGIBIKDOGB = Animator.StringToHash("Base Layer.MagicHatThrowAnimation");
			DGJCDEGKOCP();
		}

		public override void StartCollect()
		{
			FELMPJHEBKM++;
			BAIKFFOGMCB();
			new LLCJMMBBLEH(POIKGNFHGHM());
		}

		private IEnumerator POIKGNFHGHM()
		{
			ItemResources itemResources = null;
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				itemResources = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType());
			}
			CurrentAnimator.Play(OFGIBIKDOGB, 0, 0f);
			if (itemResources != null)
			{
				AudioManager.PlayAudioProps(itemResources.AudioClips[0]);
			}
			yield return new WaitForSeconds(0.15f);
			if (!(ParticlePool.Instance == null))
			{
				GameObject gameObject = ELFBOKDHKGG.GIMBEKBFKMJ.GenericCollectItem.JOBDHIPIMAG(base.transform.position);
				ParticlePlayer particle = ParticlePool.Instance.PlayParticle(itemResources.Particles[0], Vector3.zero);
				CollectAnimation component = gameObject.GetComponent<CollectAnimation>();
				component.CollectSpriteRenderer.enabled = false;
				component.Prepare(ELFBOKDHKGG, NOALGNJECAD.Carrot, IPPOGIEPKEN.Collecting.EFLCPKAFOBA(), SharedImageLibrary.Instance.CarrotCollectingImage, ENCFFNKONOO).StartAnimation();
				component.SetParticle(particle);
			}
		}

		public void UpdateSorting(int CMAJLIAELDP = -1)
		{
			CurrentSpriteRenderer.sortingOrder = ((CMAJLIAELDP != -1) ? CMAJLIAELDP : (KKCPOOALFAD.BHIJCAOHDCM + 130));
			Cell cell = ENCFFNKONOO.CurrentGrid.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Down);
			if (!(cell == null) && cell.Exists && cell.EAILOFHFNJO && cell.LBFCDKPCDPB.GetItemType() == NOALGNJECAD.MagicHat)
			{
				MagicHatItem magicHatItem = cell.LBFCDKPCDPB as MagicHatItem;
				magicHatItem.UpdateSorting(CurrentSpriteRenderer.sortingOrder + 1);
			}
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			KKCPOOALFAD = IBBBMACIBGK;
			CurrentSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			CurrentSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 130;
		}

		public override bool CanGenerateScoreOnEachTryExplode()
		{
			return true;
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			if (!ELFBOKDHKGG.NODDCJJNJEC(NOALGNJECAD.Carrot))
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

		public override bool CanBeInsideBubble()
		{
			return false;
		}

		public override void OnSubItemCreated()
		{
			DGJCDEGKOCP();
		}

		private void DGJCDEGKOCP()
		{
			if (!(ENCFFNKONOO == null))
			{
				KKCPOOALFAD = PAFJGJOPLKB.LOPMMJANOFP(ENCFFNKONOO.Y);
				UpdateSorting();
			}
		}

		public override void AfterPoolInit()
		{
			base.AfterPoolInit();
			FELMPJHEBKM = 0;
		}

		public override int GetLayerCount()
		{
			return ELFBOKDHKGG.HEHOGLHPCGH(NOALGNJECAD.Carrot).BNNIJEPHLBJ - FELMPJHEBKM;
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 103;
		}
	}
}
