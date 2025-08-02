using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Mechanics.Items.SpecialItems;
using Assets.Scripts.GamePlayScene.Tutorials;
using DG.Tweening;
using UnityEngine;

public class JOPNKHABPKE : BIMAONBKNOP
{
	private Item CFNGLJOCEHP;

	private CKKKELDIOLD KKCPOOALFAD;

	public override void DIOELAHNLKJ(TutorialManager NGIFIPBOMBO)
	{
		base.DIOELAHNLKJ(NGIFIPBOMBO);
		EEABKKPJAOO = new string[2] { "Tutorial_0002_1", "Tutorial_0002_2" };
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
				int[] fFPHKNJCCIE = new int[10] { 2, 4, 2, 5, 3, 4, 3, 5, 3, 6 };
				OBEJDLFFIPA(fFPHKNJCCIE);
				CGECKLIKPGE.BackgroundFadeIn();
				CGECKLIKPGE.ShowHighlighCells();
				CGECKLIKPGE.ShowFingerAnimation(ONCMBJKLKIL.HINDAIPFFJL, CGECKLIKPGE.GetGlobalCellPosition(3f, 4f));
				CNFHIFJHOBL = false;
				CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[JCLBCFCCPGG - 1]), new float[2] { 3f, 7.8f }, false);
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
				ECMJGGMIOJJ();
				break;
			}
		}
		catch (Exception ex)
		{
			ECMJGGMIOJJ();
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Tutorial, "Tutorial ID: 2 Error: {0} " + ex);
		}
	}

	private IEnumerator NKPJBCMPJMM()
	{
		yield return new WaitForSeconds(0.4f);
		while (FallManager.AreThereFallingItems() || FallManager.AreThereActiveAnimations())
		{
			yield return null;
		}
		CGECKLIKPGE.BackgroundFadeIn();
		CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[JCLBCFCCPGG - 1]), new float[2] { 3f, 6f }, false).OnComplete(delegate
		{
			CNFHIFJHOBL = true;
		});
		CFNGLJOCEHP.ChangeSorting(KKCPOOALFAD);
		BALIENJLCLB = new List<Cell> { CFNGLJOCEHP.ENCFFNKONOO };
		CGECKLIKPGE.ShowFingerAnimation(ONCMBJKLKIL.HINDAIPFFJL, CGECKLIKPGE.GetGlobalCellPosition(CFNGLJOCEHP.ENCFFNKONOO.X, CFNGLJOCEHP.ENCFFNKONOO.Y));
		yield return null;
	}
}
