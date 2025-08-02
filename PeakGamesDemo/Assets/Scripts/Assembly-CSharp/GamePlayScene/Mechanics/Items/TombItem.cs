using System.Collections;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class TombItem : Item, KABFIFMCFIJ
	{
		private const float JEJIBCCJHKL = 0.25f;

		private const float PGFKNEDHIKB = 0.12f;

		private const float GPKNPAJMDLF = 0.1f;

		public Animator CurrentAnimator;

		public SpriteRenderer Door;

		public SpriteRenderer[] SpriteRenderers;

		private readonly int[] BLDJELKDPIO = new int[3]
		{
			Animator.StringToHash("Base Layer.TombTransformAnimation1"),
			Animator.StringToHash("Base Layer.TombTransformAnimation2"),
			Animator.StringToHash("Base Layer.TombTransformAnimation3")
		};

		private readonly int FCNABIBBFPN = Animator.StringToHash("Base Layer.TombElixirWrongMoveAnimation");

		private static int EFOAFHLDPJA;

		private CKKKELDIOLD KKCPOOALFAD;

		private int HBBBJLFIOCB = 2;

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Tomb;
		}

		public override int GetScore()
		{
			return 1000;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			KKCPOOALFAD = IBBBMACIBGK;
			for (int i = 0; i < SpriteRenderers.Length; i++)
			{
				SpriteRenderer spriteRenderer = SpriteRenderers[i];
				if (!(spriteRenderer == null))
				{
					spriteRenderer.sortingOrder = KKCPOOALFAD.BHIJCAOHDCM + i;
					spriteRenderer.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
				}
			}
		}

		public override CKKKELDIOLD GetSorting()
		{
			return KKCPOOALFAD;
		}

		public override int GetLayerCount()
		{
			return HBBBJLFIOCB;
		}

		public override bool CanFall()
		{
			return false;
		}

		public override void OnItemCreated(KFCEILFGADG MGOFDOMDLCO)
		{
			base.OnItemCreated(MGOFDOMDLCO);
			EFOAFHLDPJA = 0;
		}

		public override void PlayWrongMove()
		{
			base.PlayWrongMove();
			if (HBBBJLFIOCB == 1)
			{
				CurrentAnimator.Play(FCNABIBBFPN, 0, 0f);
			}
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			if (HBBBJLFIOCB == 2)
			{
				HBBBJLFIOCB = 1;
				StartCoroutine(KJNCPPMHLPE(CCPAJBOJDMN.ENBPGGCIADN));
				return false;
			}
			return true;
		}

		private float KEAFMCOHDOP(int LEPKHLPKHMF)
		{
			switch (LEPKHLPKHMF)
			{
			case 9:
				return 0.25f;
			case 5:
				return 0.12f;
			case 3:
				return 0.1f;
			default:
				return 0f;
			}
		}

		private IEnumerator KJNCPPMHLPE(int LEPKHLPKHMF)
		{
			NJHNBPANPAF();
			if (ParticlePool.Instance != null)
			{
				ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[0], base.transform.position);
			}
			AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[0]);
			yield return new WaitForSeconds(KEAFMCOHDOP(LEPKHLPKHMF));
			EFOAFHLDPJA++;
			CurrentAnimator.Play(BLDJELKDPIO[EFOAFHLDPJA % 3], 0, 0f);
		}

		private void NJHNBPANPAF()
		{
			Door.enabled = false;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return HBBBJLFIOCB == 1;
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			HBBBJLFIOCB = 1;
			base.ExplodeByBlasterItem(CCPAJBOJDMN);
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
			PNINCDLIDLL.EEFMIHDPJPG = 140;
			byte aINNOPBDDGL = (byte)HBBBJLFIOCB;
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}

		public void SetState(MDMICLOPLPC DJDKLOJBJCO)
		{
			if ((HBBBJLFIOCB = DJDKLOJBJCO.GNNOGGGHPLA()) == 1)
			{
				NJHNBPANPAF();
			}
		}
	}
}
