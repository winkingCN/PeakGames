using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class HanoiItem : Item
	{
		public Animator CurrentAnimator;

		public SpriteRenderer[] SpriteRenderers;

		private int HBBBJLFIOCB = 4;

		private int IHDCPKDDGPM = -1;

		private int[] JBHLHMNMJFP;

		private int[] MHNJDEJJMFD;

		private int[] BEOHHHIPPGP;

		private CKKKELDIOLD KKCPOOALFAD;

		public override void OnItemCreated(KFCEILFGADG MGOFDOMDLCO)
		{
			base.OnItemCreated(MGOFDOMDLCO);
			JBHLHMNMJFP = new int[3]
			{
				Animator.StringToHash("Base Layer.HanoiTransform4-3"),
				Animator.StringToHash("Base Layer.HanoiTransform4-3vers2"),
				Animator.StringToHash("Base Layer.HanoiTransform4-3vers3")
			};
			MHNJDEJJMFD = new int[3]
			{
				Animator.StringToHash("Base Layer.HanoiTransform3-2"),
				Animator.StringToHash("Base Layer.HanoiTransform3-2vers2"),
				Animator.StringToHash("Base Layer.HanoiTransform3-2vers3")
			};
			BEOHHHIPPGP = new int[3]
			{
				Animator.StringToHash("Base Layer.HanoiTransform2-1"),
				Animator.StringToHash("Base Layer.HanoiTransform2-1vers2"),
				Animator.StringToHash("Base Layer.HanoiTransform2-1vers3")
			};
		}

		public override bool CanFall()
		{
			return false;
		}

		public override bool CanBeTapped()
		{
			return false;
		}

		public override bool CanShadowDrop()
		{
			return true;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return true;
		}

		public override int GetScore()
		{
			return 500;
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
					spriteRenderer.sortingOrder = KKCPOOALFAD.BHIJCAOHDCM + i;
				}
			}
		}

		public override CKKKELDIOLD GetSorting()
		{
			return KKCPOOALFAD;
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Hanoi;
		}

		public override int GetLayerCount()
		{
			return HBBBJLFIOCB;
		}

		public override void RemoveAllLayers()
		{
			HBBBJLFIOCB = 1;
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			RemoveAllLayers();
			base.ExplodeByBlasterItem(CCPAJBOJDMN);
		}

		public override void PlayExplodeAudio()
		{
			AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[1]);
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			if (HBBBJLFIOCB == 1)
			{
				return true;
			}
			HBBBJLFIOCB--;
			IJHJKAFNKJJ();
			return false;
		}

		protected override void EJCFANPAMMK()
		{
			ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[3], base.transform.position);
		}

		protected virtual void IJHJKAFNKJJ()
		{
			if (IHDCPKDDGPM == -1)
			{
				IHDCPKDDGPM = ENCFFNKONOO.X + ENCFFNKONOO.Y;
			}
			switch (HBBBJLFIOCB)
			{
			case 3:
				CurrentAnimator.Play(JBHLHMNMJFP[IHDCPKDDGPM % 3], -1, 0f);
				break;
			case 2:
				CurrentAnimator.Play(MHNJDEJJMFD[IHDCPKDDGPM % 3], -1, 0f);
				break;
			case 1:
				CurrentAnimator.Play(BEOHHHIPPGP[IHDCPKDDGPM % 3], -1, 0f);
				break;
			}
			int num = 3 - HBBBJLFIOCB;
			AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[0]);
			AudioManager.FilterQueue(KOOGPFAPGGD.ClassicExplode);
			ParticlePlayer particlePlayer = ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[num], base.transform.position);
			Quaternion identity = Quaternion.identity;
			identity.eulerAngles = ((Random.Range(0, 10) <= 5) ? new Vector3(0f, 0f, 0f) : new Vector3(0f, 180f, 0f));
			particlePlayer.MainParticle.transform.rotation = identity;
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 48;
			byte aINNOPBDDGL = (byte)HBBBJLFIOCB;
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}

		protected int[] LNLFJOOLNNE()
		{
			switch (HBBBJLFIOCB)
			{
			case 3:
				return JBHLHMNMJFP;
			case 2:
				return MHNJDEJJMFD;
			default:
				return BEOHHHIPPGP;
			}
		}

		protected void DGCBHOBKOCH(int PKHFDMGGGJN)
		{
			HBBBJLFIOCB = PKHFDMGGGJN;
		}
	}
}
