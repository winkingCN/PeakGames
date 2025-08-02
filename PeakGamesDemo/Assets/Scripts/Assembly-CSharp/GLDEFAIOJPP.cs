using System;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using UnityEngine;

public class GLDEFAIOJPP : BIMAONBKNOP
{
	public Dictionary<Item, CKKKELDIOLD> ANHNLBFAIDO;

	public CKKKELDIOLD LAKLPDLLHLB = new CKKKELDIOLD(0, 0);

	public int[] HBMJLKHHLFH;

	public float[] IHKCOPJADPD;

	public float MIFPEGLLOKK;

	public override void GDGINCNCMDD(Cell BBJPFHPBOHC)
	{
		if (LAKLPDLLHLB.MMFFDANAEEI == 0 && LAKLPDLLHLB.BHIJCAOHDCM == 0)
		{
			LAKLPDLLHLB = new CKKKELDIOLD(SortingLayer.NameToID("Dialogs"), 1020);
		}
		try
		{
			if (JCLBCFCCPGG == 1)
			{
				OBEJDLFFIPA(HBMJLKHHLFH);
				CGECKLIKPGE.BackgroundFadeIn();
				CGECKLIKPGE.BackgroundCollider.enabled = true;
				CNFHIFJHOBL = false;
				ANHNLBFAIDO = new Dictionary<Item, CKKKELDIOLD>();
				int count = BALIENJLCLB.Count;
				for (int i = 0; i < count; i++)
				{
					Cell cell = BALIENJLCLB[i];
					Item currentItem = cell.LBFCDKPCDPB;
					if (!(currentItem == null))
					{
						CKKKELDIOLD sorting = currentItem.GetSorting();
						ANHNLBFAIDO.Add(currentItem, sorting);
						LAKLPDLLHLB.BHIJCAOHDCM = 1020 + sorting.BHIJCAOHDCM;
						currentItem.ChangeSorting(LAKLPDLLHLB);
					}
				}
				if (MIFPEGLLOKK > 0f)
				{
					CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[JCLBCFCCPGG - 1]), IHKCOPJADPD, true, MIFPEGLLOKK);
				}
				else
				{
					CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[JCLBCFCCPGG - 1]), IHKCOPJADPD, true);
				}
				return;
			}
			foreach (KeyValuePair<Item, CKKKELDIOLD> item in ANHNLBFAIDO)
			{
				item.Key.ChangeSorting(item.Value);
			}
			ECMJGGMIOJJ();
		}
		catch (Exception ex)
		{
			ECMJGGMIOJJ();
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Tutorial, "Tutorial ID: {0} Error: {1} ", 0, ex);
		}
	}
}
