using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class WasherItem : Item
	{
		public DefaultFakeItem BottomRight;

		public DefaultFakeItem TopLeft;

		public DefaultFakeItem TopRight;

		public Transform ExplodePosition;

		public Animator CurrentAnimator;

		public ParticleSystem SmokeParticle;

		public SpriteRenderer[] SpriteRenderers;

		public AudioSource LoopAudioSource;

		private int HBBBJLFIOCB = 5;

		private bool FOIOHOPOCMC;

		private int[] MOJNGNDOANN = new int[4]
		{
			Animator.StringToHash("Base Layer.WasherItemTransform2-1"),
			Animator.StringToHash("Base Layer.WasherItemTransform3-2"),
			Animator.StringToHash("Base Layer.WasherItemTransform4-3"),
			Animator.StringToHash("Base Layer.WasherItemTransform5-4")
		};

		private bool PIGCJDKPMFL;

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

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Washer;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
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

		public override CKKKELDIOLD GetSorting()
		{
			return new CKKKELDIOLD(SpriteRenderers[0].sortingLayerID, SpriteRenderers[0].sortingOrder);
		}

		public override bool CanFall()
		{
			return false;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return true;
		}

		public override void RemoveAllLayers()
		{
			HBBBJLFIOCB = 0;
		}

		public override Vector3 GetCenterPositionOffset(APBDPLNCDIJ CCPAJBOJDMN)
		{
			return new Vector3(0.5f, 0.5f, 0f);
		}

		public override int GetLayerCount()
		{
			return HBBBJLFIOCB;
		}

		public override int GetScore()
		{
			return 0;
		}

		public override bool CanBeInsideBubble()
		{
			return FOIOHOPOCMC;
		}

		public override bool CanBeInsideCellItem()
		{
			return false;
		}

		public override void OnItemCreated(KFCEILFGADG MGOFDOMDLCO)
		{
			base.OnItemCreated(MGOFDOMDLCO);
			AudioManager.RegisterExternalAudioSource(LoopAudioSource);
		}

		public override void PlayExplodeAudio()
		{
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (PIGCJDKPMFL)
			{
				return false;
			}
			if (CCPAJBOJDMN.ENBPGGCIADN == 13)
			{
				return false;
			}
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			HBBBJLFIOCB--;
			if (HBBBJLFIOCB > 0)
			{
				IGOEIKBGIIJ();
				return false;
			}
			PIGCJDKPMFL = true;
			FOIOHOPOCMC = true;
			StartCoroutine(MGHAKELDMOK());
			return false;
		}

		private void IGOEIKBGIIJ()
		{
			int num = HBBBJLFIOCB - 1;
			CurrentAnimator.Play(MOJNGNDOANN[num], -1, 0f);
			ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[num], ExplodePosition.position);
			if (HBBBJLFIOCB == 1)
			{
				SmokeParticle.Play();
				StartCoroutine(PHHGCKDLJJN());
			}
			else
			{
				AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[num]);
			}
		}

		protected IEnumerator PHHGCKDLJJN()
		{
			AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[0]);
			yield return new WaitForSeconds(1f);
			LoopAudioSource.Play();
			if (!AudioManager.NAEBPOAPIFP)
			{
				LoopAudioSource.mute = true;
			}
		}

		private IEnumerator MGHAKELDMOK()
		{
			LoopAudioSource.Stop();
			AudioManager.DeRegisterExternalAudioSource(LoopAudioSource);
			SmokeParticle.Stop();
			ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[4], ExplodePosition.position);
			AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[5]);
			CFOIPDKEFMM jHDMFHDHIFN = ELFBOKDHKGG.JHDMFHDHIFN;
			List<Cell> FFPHKNJCCIE = new List<Cell>();
			int num = Mathf.Max(0, ENCFFNKONOO.X - 1);
			int num2 = Mathf.Min(jHDMFHDHIFN.EMFKAPJMDCC - 1, ENCFFNKONOO.X + 2);
			int num3 = Mathf.Max(0, ENCFFNKONOO.Y - 1);
			int num4 = Mathf.Min(jHDMFHDHIFN.FHAMOHDEGMK - 1, ENCFFNKONOO.Y + 2);
			for (int i = num; i <= num2; i++)
			{
				for (int j = num3; j <= num4; j++)
				{
					FFPHKNJCCIE.Add(jHDMFHDHIFN.ECNCPJGHBIG(i, j));
				}
			}
			LLJLGKECBBE.GABGKBAKHDP.MEBOIANIOCH(ref FFPHKNJCCIE);
			MNDFGCNLHHA(FFPHKNJCCIE);
			yield return null;
		}

		private void MNDFGCNLHHA(List<Cell> FFPHKNJCCIE)
		{
			int count = FFPHKNJCCIE.Count;
			for (int i = 0; i < count; i++)
			{
				Cell cell = FFPHKNJCCIE[i];
				cell.AddBubble(true);
				GameObject gameObject = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Animators[0].JOBDHIPIMAG();
				gameObject.transform.position = ExplodePosition.position;
				WasherBubbleAnimation component = gameObject.GetComponent<WasherBubbleAnimation>();
				component.Prepare(cell);
				ELFBOKDHKGG.JPAFPKIDJDJ(NOALGNJECAD.Bubble);
			}
			ELFBOKDHKGG.DJNEAFJLFIH(GetItemType());
			ELFBOKDHKGG.ACJOALJFMHN(GetItemType(), false);
			StartExplode();
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			RemoveAllLayers();
			base.ExplodeByBlasterItem(CCPAJBOJDMN);
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 179;
			byte aINNOPBDDGL = (byte)GetLayerCount();
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}

		protected void DGCBHOBKOCH(int PKHFDMGGGJN)
		{
			HBBBJLFIOCB = PKHFDMGGGJN;
		}

		protected int[] GOFDKKDJODP()
		{
			return MOJNGNDOANN;
		}
	}
}
