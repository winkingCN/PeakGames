using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using DG.Tweening;
using UnityEngine;

public class JDEEAANINKF : BIMAONBKNOP
{
	private Dictionary<Item, CKKKELDIOLD> PHOLJHAPIOB;

	private CKKKELDIOLD KKCPOOALFAD = new CKKKELDIOLD(0, 0);

	protected int[] HBMJLKHHLFH;

	protected float[] IHKCOPJADPD;

	protected float MIFPEGLLOKK;

	protected NOALGNJECAD JKGGHKMHGPF;

	public override void GDGINCNCMDD(Cell BBJPFHPBOHC)
	{
		if (KKCPOOALFAD.MMFFDANAEEI == 0 && KKCPOOALFAD.BHIJCAOHDCM == 0)
		{
			KKCPOOALFAD = new CKKKELDIOLD(SortingLayer.NameToID("Dialogs"), 1020);
		}
		try
		{
			if (JCLBCFCCPGG == 1)
			{
				CGECKLIKPGE.DialogPanel.SetActive(false);
				CGECKLIKPGE.BackImage.color = new Color(1f, 1f, 1f, 0f);
				new LLCJMMBBLEH(AJDGPJLLPFB());
				return;
			}
			foreach (KeyValuePair<Item, CKKKELDIOLD> item in PHOLJHAPIOB)
			{
				item.Key.ChangeSorting(item.Value);
			}
			KPICIMKMOJC(Color.white, true);
			ECMJGGMIOJJ();
		}
		catch (Exception ex)
		{
			KPICIMKMOJC(Color.white, true);
			ECMJGGMIOJJ();
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Tutorial, "Tutorial ID: {0} Error: {1} ", 0, ex);
		}
	}

	private IEnumerator AJDGPJLLPFB()
	{
		yield return MCJHHDACJBG.CNDGGNLKOOC;
		CGECKLIKPGE.DialogPanel.SetActive(true);
		OBEJDLFFIPA(HBMJLKHHLFH);
		KPICIMKMOJC(new Color(20f / 51f, 20f / 51f, 20f / 51f), false);
		CGECKLIKPGE.BackgroundFadeIn();
		CGECKLIKPGE.BackgroundCollider.enabled = true;
		CNFHIFJHOBL = false;
		PHOLJHAPIOB = new Dictionary<Item, CKKKELDIOLD>();
		int count = BALIENJLCLB.Count;
		for (int i = 0; i < count; i++)
		{
			Cell cell = BALIENJLCLB[i];
			Item currentItem = cell.LBFCDKPCDPB;
			if (!(currentItem == null))
			{
				CKKKELDIOLD sorting = currentItem.GetSorting();
				PHOLJHAPIOB.Add(currentItem, sorting);
				KKCPOOALFAD.BHIJCAOHDCM = 1020 + sorting.BHIJCAOHDCM;
				currentItem.ChangeSorting(KKCPOOALFAD);
			}
		}
		CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[JCLBCFCCPGG - 1]), IHKCOPJADPD, true, MIFPEGLLOKK);
	}

	private void KPICIMKMOJC(Color ICEFPJCHGBJ, bool GCDKMDBGIDA)
	{
		for (int i = 0; i < BALIENJLCLB.Count; i++)
		{
			if (BALIENJLCLB[i].LBFCDKPCDPB.GetItemType() != JKGGHKMHGPF)
			{
				SpriteBasedItem spriteBasedItem = BALIENJLCLB[i].LBFCDKPCDPB as SpriteBasedItem;
				if (spriteBasedItem != null)
				{
					spriteBasedItem.CurrentSpriteRenderer.DOColor(ICEFPJCHGBJ, (!GCDKMDBGIDA) ? 0.3f : 0f);
				}
			}
		}
	}
}
