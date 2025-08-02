using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Mechanics.Items.SpecialItems;
using Assets.Scripts.GamePlayScene.Tutorials;
using UnityEngine;

public class EONAPAEGAJD : BIMAONBKNOP
{
	private Item CFNGLJOCEHP;

	private CKKKELDIOLD KKCPOOALFAD;

	private CKKKELDIOLD AFIGMNIKJNM;

	public override void DIOELAHNLKJ(TutorialManager NGIFIPBOMBO)
	{
		base.DIOELAHNLKJ(NGIFIPBOMBO);
		EEABKKPJAOO = new string[2] { "Tutorial_0003_1", "Tutorial_0003_2" };
		KKCPOOALFAD = new CKKKELDIOLD(SortingLayer.NameToID("Dialogs"), 1020);
	}

	public override void GDGINCNCMDD(Cell BBJPFHPBOHC)
	{
		try
		{
			switch (JCLBCFCCPGG)
			{
			case 1:
			{
				int[] fFPHKNJCCIE = new int[14]
				{
					3, 4, 3, 5, 4, 4, 4, 5, 4, 6,
					5, 4, 5, 5
				};
				OBEJDLFFIPA(fFPHKNJCCIE);
				CGECKLIKPGE.BackgroundFadeIn();
				CGECKLIKPGE.ShowHighlighCells();
				CNFHIFJHOBL = false;
				CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[JCLBCFCCPGG - 1]), new float[2] { 4f, 7.6f }, false);
				CGECKLIKPGE.ShowFingerAnimation(ONCMBJKLKIL.HINDAIPFFJL, CGECKLIKPGE.GetGlobalCellPosition(4f, 4f));
				break;
			}
			case 2:
				CNFHIFJHOBL = false;
				CHIPOHEMKEG();
				CGECKLIKPGE.ClearCellHighlights();
				CGECKLIKPGE.HideFingerAnimation();
				CGECKLIKPGE.BackImage.enabled = false;
				CGECKLIKPGE.DialogPanel.SetActive(false);
				CFNGLJOCEHP = BBJPFHPBOHC.LBFCDKPCDPB as SpecialItem;
				new LLCJMMBBLEH(NKPJBCMPJMM());
				break;
			default:
				CFNGLJOCEHP.ChangeSorting(AFIGMNIKJNM);
				ECMJGGMIOJJ();
				break;
			}
		}
		catch (Exception ex)
		{
			ECMJGGMIOJJ();
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Tutorial, "Tutorial ID: 3 Error: {0} " + ex);
		}
	}

	private IEnumerator NKPJBCMPJMM()
	{
		yield return new WaitForSeconds(0.4f);
		while (FallManager.AreThereFallingItems() || FallManager.AreThereActiveAnimations())
		{
			yield return null;
		}
		BALIENJLCLB = new List<Cell> { CFNGLJOCEHP.ENCFFNKONOO };
		CGECKLIKPGE.BackgroundFadeIn();
		CGECKLIKPGE.ClearCellHighlights();
		AFIGMNIKJNM = CFNGLJOCEHP.GetSorting();
		CFNGLJOCEHP.ChangeSorting(KKCPOOALFAD);
		CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[JCLBCFCCPGG - 1]), new float[2] { 4f, 6.55f }, false);
		CGECKLIKPGE.ShowFingerAnimation(ONCMBJKLKIL.HINDAIPFFJL, CGECKLIKPGE.GetGlobalCellPosition(CFNGLJOCEHP.ENCFFNKONOO.X, CFNGLJOCEHP.ENCFFNKONOO.Y));
	}
}
