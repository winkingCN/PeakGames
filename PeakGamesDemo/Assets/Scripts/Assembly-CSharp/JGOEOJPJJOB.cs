using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Mechanics.Items.SpecialItems;
using Assets.Scripts.GamePlayScene.Tutorials;
using UnityEngine;

public class JGOEOJPJJOB : BIMAONBKNOP
{
	private Item CFNGLJOCEHP;

	private CKKKELDIOLD KKCPOOALFAD;

	public override void DIOELAHNLKJ(TutorialManager NGIFIPBOMBO)
	{
		base.DIOELAHNLKJ(NGIFIPBOMBO);
		EEABKKPJAOO = new string[2] { "Tutorial_0004_1", "Tutorial_0004_2" };
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
				int[] fFPHKNJCCIE = new int[18]
				{
					2, 4, 2, 5, 3, 4, 3, 5, 4, 4,
					4, 5, 5, 4, 5, 5, 6, 4
				};
				OBEJDLFFIPA(fFPHKNJCCIE);
				CGECKLIKPGE.ShowHighlighCells();
				CGECKLIKPGE.BackgroundFadeIn();
				CNFHIFJHOBL = false;
				CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[JCLBCFCCPGG - 1]), new float[2] { 4f, 6.7f }, false);
				CGECKLIKPGE.ShowFingerAnimation(ONCMBJKLKIL.HINDAIPFFJL, CGECKLIKPGE.GetGlobalCellPosition(4f, 4f));
				break;
			}
			case 2:
				CHIPOHEMKEG();
				CGECKLIKPGE.ClearCellHighlights();
				CGECKLIKPGE.HideFingerAnimation();
				CGECKLIKPGE.BackImage.enabled = false;
				CGECKLIKPGE.DialogPanel.SetActive(false);
				CFNGLJOCEHP = BBJPFHPBOHC.LBFCDKPCDPB as SpecialItem;
				CNFHIFJHOBL = false;
				new LLCJMMBBLEH(NKPJBCMPJMM());
				break;
			default:
				CGECKLIKPGE.RemoveSelf();
				break;
			}
		}
		catch (Exception ex)
		{
			ECMJGGMIOJJ();
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Tutorial, "Tutorial ID: 4 Error: {0} " + ex);
		}
	}

	private IEnumerator NKPJBCMPJMM()
	{
		yield return new WaitForSeconds(0.4f);
		while (FallManager.AreThereFallingItems() || FallManager.AreThereActiveAnimations())
		{
			yield return null;
		}
		CFNGLJOCEHP.ChangeSorting(KKCPOOALFAD);
		BALIENJLCLB = new List<Cell> { CFNGLJOCEHP.ENCFFNKONOO };
		CGECKLIKPGE.BackgroundFadeIn();
		CGECKLIKPGE.ClearCellHighlights();
		CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[JCLBCFCCPGG - 1]), new float[2] { 4f, 6f }, false);
		Vector3 globalCellPosition = CGECKLIKPGE.GetGlobalCellPosition(CFNGLJOCEHP.ENCFFNKONOO.X, CFNGLJOCEHP.ENCFFNKONOO.Y);
		CGECKLIKPGE.ShowFingerAnimation(ONCMBJKLKIL.HINDAIPFFJL, globalCellPosition);
		yield return null;
	}
}
