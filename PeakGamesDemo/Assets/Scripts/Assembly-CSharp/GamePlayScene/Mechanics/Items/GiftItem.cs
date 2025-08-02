using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class GiftItem : Item
	{
		public GameObject SnowGlobeContainer;

		public Animator CurrentAnimator;

		public SnowParticlePlayer CurrentSnowParticlePlayer;

		public SpriteRenderer[] Renderers;

		private int IDGDPMJHEON;

		private int PFGCOPFPPFB;

		private static int[] EOJCKKEGKFK;

		private static int FKKMOBPIOKA;

		private static int HLBPNCIEOPF;

		private CKKKELDIOLD IFIDCMMCNLE;

		private bool CHLNFLCGABM;

		public override bool CanFall()
		{
			return CHLNFLCGABM;
		}

		public override void OnFallEnded()
		{
			base.OnFallEnded();
			if (EOJCKKEGKFK == null)
			{
				EOJCKKEGKFK = new int[5]
				{
					Animator.StringToHash("Base Layer.SnowGlobeBounceAnimation1"),
					Animator.StringToHash("Base Layer.SnowGlobeBounceAnimation2"),
					Animator.StringToHash("Base Layer.SnowGlobeBounceAnimation3"),
					Animator.StringToHash("Base Layer.SnowGlobeBounceAnimation4"),
					Animator.StringToHash("Base Layer.SnowGlobeBounceAnimation5")
				};
			}
			HLBPNCIEOPF++;
			CurrentAnimator.Play(EOJCKKEGKFK[HLBPNCIEOPF % 5], -1, 0f);
			CurrentSnowParticlePlayer.Shake();
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return true;
		}

		public override int GetScore()
		{
			return 500;
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Gift;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			for (int i = 0; i < Renderers.Length; i++)
			{
				SpriteRenderer spriteRenderer = Renderers[i];
				if (!(spriteRenderer == null))
				{
					spriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
					spriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + i * 2;
				}
			}
			IFIDCMMCNLE = IBBBMACIBGK;
			CKKKELDIOLD iBBBMACIBGK = IBBBMACIBGK;
			iBBBMACIBGK.BHIJCAOHDCM += 15;
			CurrentSnowParticlePlayer.UpdateSorting(iBBBMACIBGK);
		}

		public override CKKKELDIOLD GetSorting()
		{
			return IFIDCMMCNLE;
		}

		public override void PlayWrongMove()
		{
			base.PlayWrongMove();
			if (PFGCOPFPPFB == 1)
			{
				CurrentSnowParticlePlayer.Shake();
			}
		}

		public override bool CanShadowDrop()
		{
			return true;
		}

		public override int GetLayerCount()
		{
			return (PFGCOPFPPFB != 0) ? 1 : 2;
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			CHLNFLCGABM = true;
			PFGCOPFPPFB = 1;
			base.ExplodeByBlasterItem(CCPAJBOJDMN);
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			if (PFGCOPFPPFB == 0)
			{
				PFGCOPFPPFB = 1;
				CENPJAKPDEH();
				return false;
			}
			return true;
		}

		private void CENPJAKPDEH()
		{
			if (ParticlePool.Instance != null)
			{
				ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[0], ENCFFNKONOO.GetFrozenPosition());
			}
			AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[0]);
			if (FKKMOBPIOKA == 0)
			{
				FKKMOBPIOKA = Animator.StringToHash("Base Layer.SnowGlobeTransitionAnimation");
			}
			CurrentAnimator.Play(FKKMOBPIOKA, -1, 0f);
			SnowGlobeContainer.SetActive(true);
			Renderers[4].enabled = false;
			CurrentSnowParticlePlayer.gameObject.SetActive(true);
			CurrentSnowParticlePlayer.Init();
			CKKKELDIOLD iFIDCMMCNLE = IFIDCMMCNLE;
			iFIDCMMCNLE.BHIJCAOHDCM += 15;
			CurrentSnowParticlePlayer.UpdateSorting(iFIDCMMCNLE);
			CHLNFLCGABM = true;
			CurrentSnowParticlePlayer.Shake();
		}

		public override void PlayExplodeAudio()
		{
			AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[1]);
		}

		protected override void EJCFANPAMMK()
		{
			if (ParticlePool.Instance != null)
			{
				ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[1], base.transform.position);
			}
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 47;
			byte aINNOPBDDGL = (byte)PFGCOPFPPFB;
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}

		protected void GDKPEEKNOAO(int FMPOHHGCPHE)
		{
			PFGCOPFPPFB = FMPOHHGCPHE;
		}

		protected void DAMHAPJBMLH()
		{
			CHLNFLCGABM = true;
		}
	}
}
