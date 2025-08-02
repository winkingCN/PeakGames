using System;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Tutorials;
using UnityEngine;

public class IEHEPAFHKFG : BIMAONBKNOP
{
	private CKKKELDIOLD KKCPOOALFAD;

	private List<SpriteRenderer> LMGIGCGBOKK;

	public override void DIOELAHNLKJ(TutorialManager NGIFIPBOMBO)
	{
		base.DIOELAHNLKJ(NGIFIPBOMBO);
		EEABKKPJAOO = new string[1] { "Tutorial_0015" };
		KKCPOOALFAD = new CKKKELDIOLD(SortingLayer.NameToID("Dialogs"), 1020);
	}

	public override void BDAKKAIBMIM(Cell BBJPFHPBOHC = null, bool AEGOANBPCGB = false, bool PCCBMIJAFPK = false)
	{
		if (BBJPFHPBOHC != null)
		{
			if (BBJPFHPBOHC.LastBubbleRemoved > 0)
			{
				JCLBCFCCPGG++;
				GDGINCNCMDD(BBJPFHPBOHC);
			}
		}
		else
		{
			JCLBCFCCPGG++;
			GDGINCNCMDD(BBJPFHPBOHC);
		}
	}

	public override void GDGINCNCMDD(Cell BBJPFHPBOHC)
	{
		try
		{
			if (JCLBCFCCPGG == 1)
			{
				int[] fFPHKNJCCIE = new int[50]
				{
					1, 1, 1, 2, 1, 3, 1, 4, 1, 5,
					2, 1, 2, 2, 2, 3, 2, 4, 2, 5,
					3, 1, 3, 2, 3, 3, 3, 4, 3, 5,
					4, 1, 4, 2, 4, 3, 4, 4, 4, 5,
					5, 1, 5, 2, 5, 3, 5, 4, 5, 5
				};
				OBEJDLFFIPA(fFPHKNJCCIE);
				CGECKLIKPGE.BackgroundFadeIn();
				CGECKLIKPGE.ShowHighlighCells();
				CNFHIFJHOBL = false;
				CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[JCLBCFCCPGG - 1]), new float[2] { 3f, 7f }, false);
				CGECKLIKPGE.ShowFingerAnimation(ONCMBJKLKIL.HINDAIPFFJL, CGECKLIKPGE.GetGlobalCellPosition(3f, 3f));
				LMGIGCGBOKK = new List<SpriteRenderer>();
				int count = BALIENJLCLB.Count;
				for (int i = 0; i < count; i++)
				{
					Cell cell = BALIENJLCLB[i];
					SpriteRenderer bubbleSpriteRenderer = cell.BubbleSpriteRenderer;
					if (!(bubbleSpriteRenderer == null))
					{
						LMGIGCGBOKK.Add(bubbleSpriteRenderer);
						Vector3 localPosition = bubbleSpriteRenderer.transform.localPosition;
						localPosition.z = -0.3f;
						bubbleSpriteRenderer.transform.localPosition = localPosition;
						bubbleSpriteRenderer.sortingOrder -= 500;
						bubbleSpriteRenderer.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
					}
				}
			}
			else
			{
				CGECKLIKPGE.ClearCellHighlights();
				for (int j = 0; j < LMGIGCGBOKK.Count; j++)
				{
					SpriteRenderer spriteRenderer = LMGIGCGBOKK[j];
					spriteRenderer.sortingLayerID = SortingLayer.NameToID("Mechanics");
					spriteRenderer.sortingOrder += 500;
					Vector3 localPosition2 = spriteRenderer.transform.localPosition;
					localPosition2.z = 0f;
					spriteRenderer.transform.localPosition = localPosition2;
				}
				ECMJGGMIOJJ();
			}
		}
		catch (Exception ex)
		{
			ECMJGGMIOJJ();
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Tutorial, "Tutorial ID: 15 Error: {0} " + ex);
		}
	}
}
