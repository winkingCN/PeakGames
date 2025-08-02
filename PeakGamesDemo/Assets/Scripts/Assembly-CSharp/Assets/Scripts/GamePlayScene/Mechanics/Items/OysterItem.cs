using Assets.Scripts.Utils;
using GamePlayScene.Mechanics;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Items
{
	public class OysterItem : SpriteBasedItem, JFIEHOCCBNG
	{
		public Animator CurrentAnimator;

		public SpriteRenderer[] SpriteRenderers;

		private int JEDDCLEDIPI = -1;

		private int AHEAGFKDBHP;

		private int EJNFKHLKLPG = Animator.StringToHash("Base Layer.OysterOpenAnimation");

		private int AKLLFOKCGKK = Animator.StringToHash("Base Layer.OysterCloseAnimation");

		private int OIMJNGAAAND;

		private bool PIGCJDKPMFL;

		private bool KJNNJHJDNNC;

		private CKKKELDIOLD IFIDCMMCNLE;

		public void Awake()
		{
			EJNFKHLKLPG = Animator.StringToHash("Base Layer.OysterOpenAnimation");
			AKLLFOKCGKK = Animator.StringToHash("Base Layer.OysterCloseAnimation");
		}

		public override void OnItemCreated(KFCEILFGADG MGOFDOMDLCO)
		{
			base.OnItemCreated(MGOFDOMDLCO);
			ELFBOKDHKGG.OGIJEDJHMNG.Add(this);
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Oyster;
		}

		public override int GetScore()
		{
			return 500;
		}

		public override bool CanCastShadow()
		{
			return true;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return true;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			if (KJNNJHJDNNC)
			{
				return;
			}
			base.ChangeSorting(IBBBMACIBGK);
			IFIDCMMCNLE = IBBBMACIBGK;
			int num = SpriteRenderers.Length;
			for (int i = 0; i < num; i++)
			{
				SpriteRenderer spriteRenderer = SpriteRenderers[i];
				if (!(spriteRenderer == null))
				{
					spriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
					spriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + i;
				}
			}
		}

		public override void BringToFront()
		{
			int bHIJCAOHDCM = 1300;
			if (ENCFFNKONOO != null)
			{
				bHIJCAOHDCM = 1300 + (10 - ENCFFNKONOO.Y * 10);
			}
			IFIDCMMCNLE.BHIJCAOHDCM = bHIJCAOHDCM;
			ChangeSorting(IFIDCMMCNLE);
			KJNNJHJDNNC = true;
		}

		public override void SendToBack()
		{
			KJNNJHJDNNC = false;
			DEIFPMCEKCO();
		}

		public override int GetLayerCount()
		{
			return (AHEAGFKDBHP != 0) ? 1 : 2;
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (!PIGCJDKPMFL)
			{
				JEDDCLEDIPI = ELFBOKDHKGG.EBMFPDNPIEM + 1;
				AHEAGFKDBHP = 1;
				base.ExplodeByBlasterItem(CCPAJBOJDMN);
			}
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			int jEDDCLEDIPI = JEDDCLEDIPI;
			JEDDCLEDIPI = ELFBOKDHKGG.EBMFPDNPIEM;
			if (AHEAGFKDBHP == 0)
			{
				MJHIKOODBMD(1);
				return false;
			}
			PIGCJDKPMFL = jEDDCLEDIPI - JEDDCLEDIPI <= 1;
			if (PIGCJDKPMFL)
			{
				ELFBOKDHKGG.OGIJEDJHMNG.Remove(this);
			}
			return PIGCJDKPMFL;
		}

		public override void PlayExplodeAudio()
		{
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[1]);
			}
		}

		protected override void EJCFANPAMMK()
		{
			if (ParticlePool.Instance != null)
			{
				ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[2], base.transform.position);
			}
		}

		public override void OnCellItemExploded()
		{
			base.OnCellItemExploded();
			OIMJNGAAAND = ELFBOKDHKGG.EBMFPDNPIEM;
		}

		public void ExplosionOccured(int CIDKKPKJJAE)
		{
			if (ENCFFNKONOO != null && (ENCFFNKONOO.HasCellItem() || ENCFFNKONOO.CGLFCDDLOKA))
			{
				JEDDCLEDIPI = CIDKKPKJJAE;
			}
			else if (OIMJNGAAAND == CIDKKPKJJAE)
			{
				JEDDCLEDIPI = CIDKKPKJJAE;
			}
			else if (CIDKKPKJJAE != JEDDCLEDIPI)
			{
				MJHIKOODBMD(0);
			}
		}

		private void MJHIKOODBMD(int PLCFEOMGCFK)
		{
			if (PIGCJDKPMFL || CurrentSpriteRenderer == null || AHEAGFKDBHP == PLCFEOMGCFK)
			{
				return;
			}
			AHEAGFKDBHP = PLCFEOMGCFK;
			switch (AHEAGFKDBHP)
			{
			case 0:
				CurrentAnimator.Play(AKLLFOKCGKK, 0, 0f);
				if (ParticlePool.Instance != null)
				{
					ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[1], this);
				}
				break;
			case 1:
				CurrentAnimator.Play(EJNFKHLKLPG, 0, 0f);
				if (ParticlePool.Instance != null)
				{
					ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[0], this);
				}
				AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[0]);
				break;
			}
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 90;
			byte aINNOPBDDGL = (byte)AHEAGFKDBHP;
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}

		protected void DFBDGLFPFAB(int BGEDKGLJIGM)
		{
			AHEAGFKDBHP = BGEDKGLJIGM;
			if (AHEAGFKDBHP == 1)
			{
				JEDDCLEDIPI = ELFBOKDHKGG.EBMFPDNPIEM;
			}
		}

		protected int OEIPPNANNKK()
		{
			return EJNFKHLKLPG;
		}
	}
}
