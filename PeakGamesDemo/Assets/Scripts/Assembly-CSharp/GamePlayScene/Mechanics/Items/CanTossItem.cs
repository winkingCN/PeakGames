using System.Collections;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class CanTossItem : SpriteBasedItem
	{
		public CanTossFakeItem BottomRight;

		public CanTossFakeItem TopLeft;

		public CanTossFakeItem TopRight;

		public CanBox[] Cans;

		public Transform ExplodePosition;

		public Animator CanTossAnimation;

		private int GAEPGFKDBAP = 250;

		private int KHHEIFOGDPG = 9;

		private bool OJFCAALFANF;

		private bool DJIFKHIOMNO;

		private int LDNEMMNPKKJ;

		private int DHLIPHHBOOG;

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
			LDNEMMNPKKJ = Animator.StringToHash("Base Layer.CanTossAnimation");
			int num = Cans.Length;
			for (int i = 0; i < num; i++)
			{
				Cans[i].Id = i;
			}
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.CanToss;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			CurrentSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			CurrentSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM;
			int num = Cans.Length;
			for (int i = 0; i < num; i++)
			{
				Cans[i].CurrentSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
				Cans[i].CurrentSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM - i + 10;
			}
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
			return true;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return true;
		}

		public override bool CanBeInsideCellItem()
		{
			return false;
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (CCPAJBOJDMN.ENBPGGCIADN == 13)
			{
				return false;
			}
			if (!ELFBOKDHKGG.NODDCJJNJEC(NOALGNJECAD.CanToss))
			{
				return false;
			}
			if (NGKLFNCDIJM.Contains(CCPAJBOJDMN.EEFMIHDPJPG))
			{
				return false;
			}
			if (CCPAJBOJDMN.ENBPGGCIADN == 8 || CCPAJBOJDMN.ENBPGGCIADN == 16)
			{
				if (!LAGEBFBEINC(CCPAJBOJDMN))
				{
					return false;
				}
				if (PKECJEGOFDN())
				{
					return true;
				}
			}
			return PKECJEGOFDN();
		}

		private bool PKECJEGOFDN()
		{
			if (DJIFKHIOMNO)
			{
				return false;
			}
			CanBox canBox = Cans[9 - KHHEIFOGDPG];
			canBox.Remove();
			NNGHEGMABCP(canBox);
			AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[DHLIPHHBOOG++ % 3]);
			if (KHHEIFOGDPG > 1)
			{
				ELFBOKDHKGG.ACJOALJFMHN(NOALGNJECAD.CanToss, false);
			}
			KHHEIFOGDPG--;
			DJIFKHIOMNO = KHHEIFOGDPG <= 0;
			GEBFBDKEKCL();
			ScoreManager.RaiseScore(GAEPGFKDBAP);
			ELFBOKDHKGG.BIFLJLPOELJ();
			new LLCJMMBBLEH(IIELOOINIEK(ELFBOKDHKGG), true);
			return DJIFKHIOMNO;
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (DJIFKHIOMNO)
			{
				return;
			}
			int kHHEIFOGDPG = KHHEIFOGDPG;
			KHHEIFOGDPG = 0;
			for (int i = 0; i < kHHEIFOGDPG; i++)
			{
				CanBox canBox = Cans[i];
				if (canBox != null)
				{
					canBox.Remove();
					ELFBOKDHKGG.ACJOALJFMHN(NOALGNJECAD.CanToss, false);
					NNGHEGMABCP(canBox);
					if (i > 0)
					{
						ScoreManager.RaiseScore(GAEPGFKDBAP);
					}
				}
			}
			AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[DHLIPHHBOOG++ % 3]);
			DJIFKHIOMNO = true;
			ELFBOKDHKGG.BIFLJLPOELJ();
			new LLCJMMBBLEH(IIELOOINIEK(ELFBOKDHKGG), true);
			PlayExplodeAudio();
			EJCFANPAMMK();
			RemoveSelf();
		}

		private void NNGHEGMABCP(CanBox IGPLJLCABOF)
		{
			if (!(ParticlePool.Instance == null))
			{
				ParticlePlayer particlePlayer = ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[0], IGPLJLCABOF.transform.position);
				Quaternion identity = Quaternion.identity;
				identity.eulerAngles = ((Random.Range(0, 10) <= 5) ? new Vector3(-102.4f, 90f, 0f) : new Vector3(-76.5f, 90f, 0f));
				particlePlayer.MainParticle.transform.rotation = identity;
			}
		}

		private static IEnumerator IIELOOINIEK(KFCEILFGADG GIOFHACJEGA)
		{
			yield return MCJHHDACJBG.CHFOIGLAMPN;
			GIOFHACJEGA.GIMHNADJNIK();
		}

		public override void PlayExplodeAudio()
		{
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[3]);
			}
		}

		public override void RemoveSelf()
		{
			base.RemoveSelf();
			BottomRight.RemoveSelf();
			TopLeft.RemoveSelf();
			TopRight.RemoveSelf();
		}

		private void GEBFBDKEKCL()
		{
			CanTossAnimation.Play(LDNEMMNPKKJ, 0, 0f);
			for (int i = 0; i <= 8; i++)
			{
				CanBox canBox = Cans[i];
				canBox.PlayShakeAnimation(KHHEIFOGDPG);
			}
		}

		protected override void EJCFANPAMMK()
		{
			if (ParticlePool.Instance != null && ItemResourcesManager.GABGKBAKHDP != null)
			{
				ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[1], ExplodePosition.position);
			}
		}

		public override bool CanBeInsideBubble()
		{
			return false;
		}

		public override int GetLayerCount()
		{
			return (KHHEIFOGDPG + 1) / 2;
		}

		public override Vector3 GetCenterPositionOffset(APBDPLNCDIJ CCPAJBOJDMN)
		{
			return new Vector3(0.5f, 0.5f, 0f);
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 69;
			byte aINNOPBDDGL = (byte)KHHEIFOGDPG;
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}

		protected void LEIOHOPGIDO(byte BEBJNOKJNJN)
		{
			KHHEIFOGDPG = BEBJNOKJNJN;
		}
	}
}
