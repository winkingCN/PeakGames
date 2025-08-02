using System.Collections;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class SafeItem : Item
	{
		public DefaultFakeItem BottomRight;

		public DefaultFakeItem TopLeft;

		public DefaultFakeItem TopRight;

		public SpriteRenderer[] SpriteRenderers;

		public GameObject Door;

		public SafeGold[] Golds;

		public Transform ExplodePosition;

		public Animator CurrentAnimator;

		private const int NPJJCGDHKCI = 6;

		private const int GAEPGFKDBAP = 250;

		private int HBBBJLFIOCB = 7;

		private bool DJIFKHIOMNO;

		private CKKKELDIOLD KKCPOOALFAD;

		private readonly int PEMBBJMOHBG = Animator.StringToHash("Base Layer.SafeItemShakeAnimation");

		private Coroutine KHONFJIIIFE;

		private WaitForSeconds DDIPCHEENIH = new WaitForSeconds(0.15f);

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

		public void Awake()
		{
			for (int i = 0; i < Golds.Length; i++)
			{
				Golds[i].Id = i;
			}
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Safe;
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

		public override int GetScore()
		{
			return 0;
		}

		public override bool CanBeExplodedBySpecialItem()
		{
			return true;
		}

		public override bool CanBeExplodedByBooster()
		{
			return true;
		}

		public override bool CanFall()
		{
			return false;
		}

		public override bool CanGenerateScoreOnEachTryExplode()
		{
			return HBBBJLFIOCB <= 6;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return HBBBJLFIOCB <= 6;
		}

		public override bool CanBeInsideCellItem()
		{
			return false;
		}

		public override bool CanBeInsideBubble()
		{
			return false;
		}

		public override CollectAnimation GetCollectItem()
		{
			CollectAnimation component = BBKCPPOFENL.Animators[0].JOBDHIPIMAG().GetComponent<CollectAnimation>();
			component.Prepare(ELFBOKDHKGG, NOALGNJECAD.Gold, GetSorting(), SharedImageLibrary.Instance.GoldGoal, ENCFFNKONOO);
			return component;
		}

		public override int GetLayerCount()
		{
			return HBBBJLFIOCB;
		}

		public override Vector3 GetCenterPositionOffset(APBDPLNCDIJ CCPAJBOJDMN)
		{
			return new Vector3(0.5f, 0.5f, 0f);
		}

		public override void PlayExplodeAudio()
		{
			AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[2]);
		}

		protected override void EJCFANPAMMK()
		{
			DNNIKAGLDPA(BBKCPPOFENL.Particles[2], ExplodePosition.position);
		}

		public override void RemoveSelf()
		{
			base.RemoveSelf();
			BottomRight.RemoveSelf();
			TopLeft.RemoveSelf();
			TopRight.RemoveSelf();
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (DJIFKHIOMNO || CCPAJBOJDMN.ENBPGGCIADN == 13 || !LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			HBBBJLFIOCB--;
			if (BKOMFPLEMOM())
			{
				Door.SetActive(false);
				DNNIKAGLDPA(BBKCPPOFENL.Particles[0], ExplodePosition.position);
				AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[0]);
				KHONFJIIIFE = StartCoroutine(EECEHILMNBH());
			}
			else
			{
				SafeGold safeGold = Golds[5 - HBBBJLFIOCB];
				BCGBCMCJPJP(safeGold);
				AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[1]);
				ScoreManager.RaiseScore(250);
				safeGold.Remove();
				if (KHONFJIIIFE != null)
				{
					StopCoroutine(KHONFJIIIFE);
					KHONFJIIIFE = null;
				}
				GEBFBDKEKCL();
			}
			DJIFKHIOMNO = HBBBJLFIOCB <= 0;
			return DJIFKHIOMNO;
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (DJIFKHIOMNO)
			{
				return;
			}
			HBBBJLFIOCB = 0;
			for (int i = 0; i < Golds.Length; i++)
			{
				SafeGold safeGold = Golds[i];
				if (!(safeGold == null))
				{
					BCGBCMCJPJP(safeGold);
					ScoreManager.RaiseScore(250);
					safeGold.Remove();
				}
			}
			AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[1]);
			if (BKOMFPLEMOM())
			{
				AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[0]);
				DNNIKAGLDPA(BBKCPPOFENL.Particles[0], ExplodePosition.position);
			}
			DJIFKHIOMNO = true;
			PlayExplodeAudio();
			EJCFANPAMMK();
			RemoveSelf();
		}

		private IEnumerator EECEHILMNBH()
		{
			for (int i = 0; i < 2; i++)
			{
				GEBFBDKEKCL();
				yield return DDIPCHEENIH;
			}
		}

		private void BCGBCMCJPJP(SafeGold BBDBDJCKAJG)
		{
			DNNIKAGLDPA(BBKCPPOFENL.Particles[1], BBDBDJCKAJG.transform.position);
			CollectAnimation collectItem = GetCollectItem();
			collectItem.transform.position = BBDBDJCKAJG.transform.position;
			collectItem.transform.localScale = Vector3.one;
			collectItem.CollectSpriteRenderer.enabled = true;
			collectItem.CollectSpriteRenderer.sprite = BBDBDJCKAJG.CurrentSpriteRenderer.sprite;
			collectItem.CollectSpriteRenderer.flipX = BBDBDJCKAJG.CurrentSpriteRenderer.flipX;
			collectItem.SpriteRenderers[1].enabled = false;
			collectItem.SpriteRenderers[1].flipX = BBDBDJCKAJG.CurrentSpriteRenderer.flipX;
			Sprite sprite;
			switch (HBBBJLFIOCB)
			{
			case 1:
				sprite = BBKCPPOFENL.Sprites[2];
				break;
			case 2:
			case 3:
				sprite = BBKCPPOFENL.Sprites[3];
				break;
			case 4:
			case 5:
				sprite = BBKCPPOFENL.Sprites[1];
				break;
			default:
				sprite = BBKCPPOFENL.Sprites[0];
				break;
			}
			collectItem.SpriteRenderers[1].sprite = sprite;
			collectItem.StartAnimation();
		}

		private bool BKOMFPLEMOM()
		{
			return HBBBJLFIOCB >= 6;
		}

		private void DNNIKAGLDPA(ParticlePlayer BEDKKJIKDCM, Vector3 LDMDBPLADGD)
		{
			if (ParticlePool.Instance != null)
			{
				ParticlePool.Instance.PlayParticle(BEDKKJIKDCM, LDMDBPLADGD);
			}
		}

		private void GEBFBDKEKCL()
		{
			if (DJIFKHIOMNO)
			{
				return;
			}
			CurrentAnimator.Play(PEMBBJMOHBG, 0, 0f);
			int eHJNMODJEAN = Random.Range(0, 10);
			for (int i = 0; i < 6; i++)
			{
				SafeGold safeGold = Golds[i];
				if (safeGold != null)
				{
					safeGold.PlayShakeAnimation(HBBBJLFIOCB, eHJNMODJEAN);
				}
			}
		}

		protected void DGCBHOBKOCH(int PKHFDMGGGJN)
		{
			HBBBJLFIOCB = PKHFDMGGGJN;
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 32;
			byte aINNOPBDDGL = (byte)HBBBJLFIOCB;
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}
	}
}
