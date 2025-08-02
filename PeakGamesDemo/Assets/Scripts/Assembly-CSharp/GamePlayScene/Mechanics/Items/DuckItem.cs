using System.Collections;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class DuckItem : SpriteBasedItem
	{
		public Animator CurrentAnimator;

		private static int EFBMJDGOAGO;

		private static int[] DAJLHJICGJN;

		private static float FIDHDFBLPFC;

		private Sequence CECMMIBAAIG;

		private bool AKOILMHBBOH;

		private bool NHINLAKMBJI;

		public void Start()
		{
			if (DAJLHJICGJN == null)
			{
				DAJLHJICGJN = new int[2];
				DAJLHJICGJN[0] = Animator.StringToHash("Base Layer.DuckFallAnimation");
				DAJLHJICGJN[1] = Animator.StringToHash("Base Layer.DuckCollectAnimation");
			}
		}

		public override void OnItemCreated(KFCEILFGADG MGOFDOMDLCO)
		{
			base.OnItemCreated(MGOFDOMDLCO);
			FireworksController.GABGKBAKHDP.RegisterToy(this);
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Duck;
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

		public override int GetFireworksPriority()
		{
			return -1;
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			return CCPAJBOJDMN.ENBPGGCIADN == 1 && base.TryExplode(CCPAJBOJDMN);
		}

		public override CollectAnimation GetCollectItem()
		{
			Vector3 position = base.transform.position;
			position.y -= 0.09f;
			CollectAnimation component = ELFBOKDHKGG.GIMBEKBFKMJ.GenericCollectItem.JOBDHIPIMAG(position).GetComponent<CollectAnimation>();
			component.Prepare(ELFBOKDHKGG, GetItemType(), GetSorting(), CurrentSpriteRenderer.sprite, ENCFFNKONOO);
			return component;
		}

		public override void OnFallEnded()
		{
			base.OnFallEnded();
			CKKKELDIOLD sorting = GetSorting();
			sorting.BHIJCAOHDCM += 249;
			ChangeSorting(sorting);
			CurrentAnimator.Play(DAJLHJICGJN[0], -1, 0f);
			if (CECMMIBAAIG != null)
			{
				CECMMIBAAIG.Kill();
			}
			CECMMIBAAIG = DOTween.Sequence();
			CECMMIBAAIG.InsertCallback(0.35f, DEIFPMCEKCO);
		}

		private IEnumerator BLIHEKFCFON()
		{
			HAPDHAKJDBL();
			if (ParticlePool.Instance != null)
			{
				ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[0], base.transform.position);
			}
			AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[0]);
			CurrentAnimator.Play(DAJLHJICGJN[1], -1, 0f);
			yield return new WaitForSeconds(0.25f + 0.1f * (float)BIGLLOFCIHK());
			if (NHINLAKMBJI)
			{
				FallManager.DecreaseStatAnimation();
				NHINLAKMBJI = false;
			}
			if (ENCFFNKONOO != null)
			{
				ENCFFNKONOO.CurrentGrid.EJBPCMDJFEM(ENCFFNKONOO, MLENMAIAOHJ.BDAKKAIBMIM(1));
			}
			yield return null;
		}

		private void HAPDHAKJDBL()
		{
			CKKKELDIOLD cKKKELDIOLD = IPPOGIEPKEN.PlayDuckSorting.EFLCPKAFOBA();
			CurrentSpriteRenderer.sortingLayerID = cKKKELDIOLD.MMFFDANAEEI;
			CurrentSpriteRenderer.sortingOrder = cKKKELDIOLD.BHIJCAOHDCM;
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
			if (!AKOILMHBBOH && !SlowCheckTime.ShouldPass() && !IsFalling && !(ENCFFNKONOO == null) && ENCFFNKONOO.IsFloor && (!ENCFFNKONOO.IsFloor || (!ENCFFNKONOO.HasCellItem() && !ENCFFNKONOO.CGLFCDDLOKA)))
			{
				ELFBOKDHKGG.LCKKMCJDDBC(NOALGNJECAD.Duck);
				AKOILMHBBOH = true;
				if (!NHINLAKMBJI)
				{
					NHINLAKMBJI = true;
					FallManager.IncreaseStatAnimation();
				}
				StartCoroutine(BLIHEKFCFON());
			}
		}

		public void SetupItem(ALIFCLNJKPH LNBEKJLGPAC)
		{
			int num = -1;
			switch (LNBEKJLGPAC)
			{
			case ALIFCLNJKPH.Duck1:
				num = 0;
				break;
			case ALIFCLNJKPH.Duck2:
				num = 1;
				break;
			case ALIFCLNJKPH.Duck3:
				num = 2;
				break;
			case ALIFCLNJKPH.Duck4:
				num = 3;
				break;
			case ALIFCLNJKPH.Duck5:
				num = 4;
				break;
			}
			if (num >= 0)
			{
				CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.DuckSprites[num];
			}
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
			PNINCDLIDLL.EEFMIHDPJPG = 41;
		}
	}
}
