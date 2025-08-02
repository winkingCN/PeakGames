using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items.SpecialItems;
using UnityEngine;

public class IFBBDDOBOGI : BIMAONBKNOP
{
	public const string GMLFJGHDOHA = "TutorialSpecial";

	private readonly SpecialItem CFNGLJOCEHP;

	private readonly CKKKELDIOLD KKCPOOALFAD = new CKKKELDIOLD(SortingLayer.NameToID("Dialogs"), 1020);

	private CKKKELDIOLD AFIGMNIKJNM;

	public IFBBDDOBOGI(SpecialItem ALAJBEFFOKB)
	{
		CFNGLJOCEHP = ALAJBEFFOKB;
		switch (ALAJBEFFOKB.GetItemType())
		{
		case NOALGNJECAD.Rocket:
			EEABKKPJAOO = new string[1] { "Tutorial_0002_2" };
			break;
		case NOALGNJECAD.Bomb:
			EEABKKPJAOO = new string[1] { "Tutorial_0003_2" };
			break;
		case NOALGNJECAD.DiscoBall:
			EEABKKPJAOO = new string[1] { "Tutorial_Fun_0004_2" };
			break;
		default:
			EEABKKPJAOO = new string[1] { "Tutorial_0002_2" };
			break;
		}
	}

	public override void GDGINCNCMDD(Cell BBJPFHPBOHC)
	{
		int jCLBCFCCPGG = JCLBCFCCPGG;
		if (jCLBCFCCPGG == 1)
		{
			CGECKLIKPGE.HideBackground();
			CGECKLIKPGE.HideDialog();
			CNFHIFJHOBL = false;
			new LLCJMMBBLEH(NKPJBCMPJMM());
		}
		else
		{
			CFNGLJOCEHP.ChangeSorting(AFIGMNIKJNM);
			HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("TutorialSpecial", "1");
			ECMJGGMIOJJ();
		}
	}

	private IEnumerator NKPJBCMPJMM()
	{
		yield return new WaitForSeconds(0.4f);
		while (FallManager.AreThereFallingItems() || FallManager.AreThereActiveAnimations())
		{
			yield return null;
		}
		float num = (float)(CFNGLJOCEHP.ENCFFNKONOO.CurrentGrid.EMFKAPJMDCC - 1) / 2f;
		int num2 = ((CFNGLJOCEHP.ENCFFNKONOO.Y <= 5) ? (CFNGLJOCEHP.ENCFFNKONOO.Y + 2) : (CFNGLJOCEHP.ENCFFNKONOO.Y - 4));
		CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[0]), new float[2] { num, num2 }, false);
		CGECKLIKPGE.BackgroundFadeIn();
		AFIGMNIKJNM = CFNGLJOCEHP.GetSorting();
		CFNGLJOCEHP.ChangeSorting(KKCPOOALFAD);
		BALIENJLCLB = new List<Cell> { CFNGLJOCEHP.ENCFFNKONOO };
		CGECKLIKPGE.ShowFingerAnimation(ONCMBJKLKIL.HINDAIPFFJL, CGECKLIKPGE.GetGlobalCellPosition(CFNGLJOCEHP.ENCFFNKONOO.X, CFNGLJOCEHP.ENCFFNKONOO.Y));
		yield return null;
	}
}
