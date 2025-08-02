using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using GamePlayScene.Mechanics.Animations;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class PotItem : Item
	{
		public SpriteRenderer[] SpriteRenderers;

		private Vector3 DDCJEDOPKGD;

		private CKKKELDIOLD IFIDCMMCNLE;

		private bool PIGCJDKPMFL;

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Pot;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			IFIDCMMCNLE = IBBBMACIBGK;
			for (int i = 0; i < SpriteRenderers.Length; i++)
			{
				SpriteRenderer spriteRenderer = SpriteRenderers[i];
				spriteRenderer.sortingLayerID = IFIDCMMCNLE.MMFFDANAEEI;
				spriteRenderer.sortingOrder = IFIDCMMCNLE.BHIJCAOHDCM + i;
			}
		}

		public override CKKKELDIOLD GetSorting()
		{
			return IFIDCMMCNLE;
		}

		public override bool CanFall()
		{
			return false;
		}

		public override bool CanBeTapped()
		{
			return true;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return true;
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
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			PIGCJDKPMFL = true;
			DDCJEDOPKGD = IDIOLIHBJBE.GetFrozenPosition();
			StartCoroutine(MGHAKELDMOK());
			return false;
		}

		private IEnumerator MGHAKELDMOK()
		{
			yield return null;
			CFOIPDKEFMM jHDMFHDHIFN = ELFBOKDHKGG.JHDMFHDHIFN;
			List<Cell> fFPHKNJCCIE = new List<Cell>
			{
				jHDMFHDHIFN.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Up),
				jHDMFHDHIFN.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.RightUp),
				jHDMFHDHIFN.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Right),
				jHDMFHDHIFN.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.RightDown),
				jHDMFHDHIFN.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Down),
				jHDMFHDHIFN.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.LeftDown),
				jHDMFHDHIFN.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Left),
				jHDMFHDHIFN.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.LeftUp),
				ENCFFNKONOO
			};
			PMNKPNIIINK(fFPHKNJCCIE);
			ELFBOKDHKGG.DJNEAFJLFIH(GetItemType());
			ELFBOKDHKGG.ACJOALJFMHN(GetItemType(), false);
			StartExplode();
		}

		private void PMNKPNIIINK(List<Cell> FFPHKNJCCIE)
		{
			if (FFPHKNJCCIE == null || FFPHKNJCCIE.Count == 0)
			{
				return;
			}
			bool flag = false;
			CFOIPDKEFMM jHDMFHDHIFN = ELFBOKDHKGG.JHDMFHDHIFN;
			int fHAMOHDEGMK = jHDMFHDHIFN.FHAMOHDEGMK;
			for (int num = FFPHKNJCCIE.Count - 1; num >= 0; num--)
			{
				Cell cell = FFPHKNJCCIE[num];
				if (!(cell == null) && cell.Exists && !cell.HasBubble && !cell.HFOKCLGLNOB && !cell.LMBJLCLEANK && !cell.CGLFCDDLOKA && !cell.HasCellItem() && (!cell.EAILOFHFNJO || cell.LBFCDKPCDPB.CanBeInsideCellItem()))
				{
					flag = true;
					cell.CGLFCDDLOKA = true;
					int num2 = (cell.X + cell.Y) % 2;
					GameObject gameObject = BBKCPPOFENL.Animators[num2].JOBDHIPIMAG(ENCFFNKONOO.GetFrozenPosition(), Quaternion.identity);
					IvySpreadAnimation component = gameObject.GetComponent<IvySpreadAnimation>();
					Cell cell2 = jHDMFHDHIFN.PHOOMEOBJCB(cell, IEKBFJBLGFM.Up);
					bool jFDHDIIDCMO = cell.Y == fHAMOHDEGMK - 1 || (cell2 != null && !cell2.Exists);
					component.Prepare(ENCFFNKONOO, cell, num2, jFDHDIIDCMO);
					ELFBOKDHKGG.JPAFPKIDJDJ(NOALGNJECAD.Ivy);
				}
			}
			if (flag)
			{
				AudioManager.PlayAudioPropsLater(0.23f, BBKCPPOFENL.AudioClips[0]);
			}
		}

		protected override void EJCFANPAMMK()
		{
			ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[0], DDCJEDOPKGD);
			AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[1]);
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 120;
		}
	}
}
