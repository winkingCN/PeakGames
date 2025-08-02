using GamePlayScene.Mechanics;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Items
{
	public class ColoredCrateItem : CrateItem
	{
		private LEDBLDKJBAI GIGJIOHBALP = LEDBLDKJBAI.None;

		private Sprite[] DBEIPOMMPJA;

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.ColoredCrate;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return KOINNGEBMJI == GIGJIOHBALP;
		}

		public override bool CanShadowDrop()
		{
			return true;
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			LayerCount = 1;
			base.ExplodeByBlasterItem(CCPAJBOJDMN);
		}

		protected override void EJCFANPAMMK()
		{
			if (ParticlePool.Instance != null && ItemResourcesManager.GABGKBAKHDP != null)
			{
				ColoredCrateExplodeParticlePlayer coloredCrateExplodeParticlePlayer = ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[1], base.transform.position, false) as ColoredCrateExplodeParticlePlayer;
				coloredCrateExplodeParticlePlayer.SetColor(GIGJIOHBALP);
				coloredCrateExplodeParticlePlayer.Play();
			}
		}

		public void SetupItem(ALIFCLNJKPH NGCKFDDHOFB)
		{
			switch (NGCKFDDHOFB)
			{
			case ALIFCLNJKPH.ColorCrateYellow0:
			case ALIFCLNJKPH.ColorCrateRed0:
			case ALIFCLNJKPH.ColorCrateBlue0:
			case ALIFCLNJKPH.ColorCrateGreen0:
			case ALIFCLNJKPH.ColorCratePurple0:
			case ALIFCLNJKPH.ColorCrateOrange0:
				LayerCount = 1;
				break;
			case ALIFCLNJKPH.ColorCrateYellow1:
			case ALIFCLNJKPH.ColorCrateRed1:
			case ALIFCLNJKPH.ColorCrateBlue1:
			case ALIFCLNJKPH.ColorCrateGreen1:
			case ALIFCLNJKPH.ColorCratePurple1:
			case ALIFCLNJKPH.ColorCrateOrange1:
				LayerCount = 2;
				break;
			case ALIFCLNJKPH.ColorCrateYellow2:
			case ALIFCLNJKPH.ColorCrateRed2:
			case ALIFCLNJKPH.ColorCrateBlue2:
			case ALIFCLNJKPH.ColorCrateGreen2:
			case ALIFCLNJKPH.ColorCratePurple2:
			case ALIFCLNJKPH.ColorCrateOrange2:
				LayerCount = 3;
				break;
			}
			switch (NGCKFDDHOFB)
			{
			case ALIFCLNJKPH.ColorCrateYellow0:
			case ALIFCLNJKPH.ColorCrateYellow1:
			case ALIFCLNJKPH.ColorCrateYellow2:
				GIGJIOHBALP = LEDBLDKJBAI.Yellow;
				DBEIPOMMPJA = SharedImageLibrary.Instance.YellowCrateLayerSprites;
				break;
			case ALIFCLNJKPH.ColorCrateRed0:
			case ALIFCLNJKPH.ColorCrateRed1:
			case ALIFCLNJKPH.ColorCrateRed2:
				GIGJIOHBALP = LEDBLDKJBAI.Red;
				DBEIPOMMPJA = SharedImageLibrary.Instance.RedCrateLayerSprites;
				break;
			case ALIFCLNJKPH.ColorCrateBlue0:
			case ALIFCLNJKPH.ColorCrateBlue1:
			case ALIFCLNJKPH.ColorCrateBlue2:
				GIGJIOHBALP = LEDBLDKJBAI.Blue;
				DBEIPOMMPJA = SharedImageLibrary.Instance.BlueCrateLayerSprites;
				break;
			case ALIFCLNJKPH.ColorCrateGreen0:
			case ALIFCLNJKPH.ColorCrateGreen1:
			case ALIFCLNJKPH.ColorCrateGreen2:
				GIGJIOHBALP = LEDBLDKJBAI.Green;
				DBEIPOMMPJA = SharedImageLibrary.Instance.GreenCrateLayerSprites;
				break;
			case ALIFCLNJKPH.ColorCratePurple0:
			case ALIFCLNJKPH.ColorCratePurple1:
			case ALIFCLNJKPH.ColorCratePurple2:
				GIGJIOHBALP = LEDBLDKJBAI.Purple;
				DBEIPOMMPJA = SharedImageLibrary.Instance.PurpleCrateLayerSprites;
				break;
			case ALIFCLNJKPH.ColorCrateOrange0:
			case ALIFCLNJKPH.ColorCrateOrange1:
			case ALIFCLNJKPH.ColorCrateOrange2:
				GIGJIOHBALP = LEDBLDKJBAI.Orange;
				DBEIPOMMPJA = SharedImageLibrary.Instance.OrangeCrateLayerSprites;
				break;
			default:
				GIGJIOHBALP = LEDBLDKJBAI.Blue;
				DBEIPOMMPJA = SharedImageLibrary.Instance.BlueCrateLayerSprites;
				break;
			}
			CurrentSpriteRenderer.sprite = DBEIPOMMPJA[LayerCount - 1];
		}

		protected override void IJHJKAFNKJJ()
		{
			switch (LayerCount)
			{
			case 1:
			case 2:
				if (ParticlePool.Instance != null && ItemResourcesManager.GABGKBAKHDP != null)
				{
					ColoredCrateLayerRemovedParticlePlayer coloredCrateLayerRemovedParticlePlayer = ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[0], base.transform.position, false) as ColoredCrateLayerRemovedParticlePlayer;
					coloredCrateLayerRemovedParticlePlayer.SetColor(GIGJIOHBALP);
					coloredCrateLayerRemovedParticlePlayer.Play();
				}
				break;
			}
			int num = LayerCount - 1;
			if (num < DBEIPOMMPJA.Length)
			{
				CurrentSpriteRenderer.sprite = DBEIPOMMPJA[num];
			}
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			ALIFCLNJKPH aLIFCLNJKPH = ALIFCLNJKPH.Crate;
			switch (GIGJIOHBALP)
			{
			case LEDBLDKJBAI.Yellow:
				aLIFCLNJKPH = ALIFCLNJKPH.ColorCrateYellow0;
				break;
			case LEDBLDKJBAI.Red:
				aLIFCLNJKPH = ALIFCLNJKPH.ColorCrateRed0;
				break;
			case LEDBLDKJBAI.Blue:
				aLIFCLNJKPH = ALIFCLNJKPH.ColorCrateBlue0;
				break;
			case LEDBLDKJBAI.Green:
				aLIFCLNJKPH = ALIFCLNJKPH.ColorCrateGreen0;
				break;
			case LEDBLDKJBAI.Purple:
				aLIFCLNJKPH = ALIFCLNJKPH.ColorCratePurple0;
				break;
			case LEDBLDKJBAI.Orange:
				aLIFCLNJKPH = ALIFCLNJKPH.ColorCrateOrange0;
				break;
			}
			PNINCDLIDLL.EEFMIHDPJPG = (short)(aLIFCLNJKPH + LayerCount - 1);
		}
	}
}
