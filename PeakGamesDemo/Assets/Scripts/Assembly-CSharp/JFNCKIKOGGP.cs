using System;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Tutorials;
using DG.Tweening;
using GamePlayScene.Mechanics.Items;
using UnityEngine;

public class JFNCKIKOGGP : BIMAONBKNOP
{
	private Dictionary<DuckItem, CKKKELDIOLD> GFCINOIEBDJ;

	public override void DIOELAHNLKJ(TutorialManager NGIFIPBOMBO)
	{
		base.DIOELAHNLKJ(NGIFIPBOMBO);
		EEABKKPJAOO = new string[1] { "Tutorial_0009" };
	}

	public override void GDGINCNCMDD(Cell BBJPFHPBOHC)
	{
		try
		{
			if (JCLBCFCCPGG == 1)
			{
				int[] fFPHKNJCCIE = new int[6] { 1, 8, 4, 8, 7, 8 };
				OBEJDLFFIPA(fFPHKNJCCIE);
				CGECKLIKPGE.ShowGoalHighlights();
				CGECKLIKPGE.BackgroundFadeIn();
				CNFHIFJHOBL = false;
				CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[JCLBCFCCPGG - 1]), new float[2] { 4f, 4f }, true);
				CGECKLIKPGE.Arrow.enabled = true;
				CGECKLIKPGE.Arrow.sprite = CGECKLIKPGE.ArrowMini;
				CGECKLIKPGE.Arrow.transform.eulerAngles = new Vector3(0f, 0f, 0f);
				CGECKLIKPGE.Arrow.transform.position = CGECKLIKPGE.GIMBEKBFKMJ.CellContainer.TransformPoint(new Vector3(1f, 6.5f));
				SpriteRenderer spriteRenderer = UnityEngine.Object.Instantiate(CGECKLIKPGE.Arrow);
				spriteRenderer.transform.SetParent(CGECKLIKPGE.transform);
				spriteRenderer.transform.position = CGECKLIKPGE.GIMBEKBFKMJ.CellContainer.TransformPoint(new Vector3(4f, 6.5f));
				SpriteRenderer spriteRenderer2 = UnityEngine.Object.Instantiate(CGECKLIKPGE.Arrow);
				spriteRenderer2.transform.SetParent(CGECKLIKPGE.transform);
				spriteRenderer2.transform.position = CGECKLIKPGE.GIMBEKBFKMJ.CellContainer.TransformPoint(new Vector3(7f, 6.5f));
				GFCINOIEBDJ = new Dictionary<DuckItem, CKKKELDIOLD>();
				CKKKELDIOLD iBBBMACIBGK = new CKKKELDIOLD(SortingLayer.NameToID("Dialogs"), 1020);
				int count = BALIENJLCLB.Count;
				for (int i = 0; i < count; i++)
				{
					Cell cell = BALIENJLCLB[i];
					DuckItem duckItem = cell.LBFCDKPCDPB as DuckItem;
					if (duckItem != null)
					{
						GFCINOIEBDJ.Add(duckItem, duckItem.GetSorting());
						duckItem.ChangeSorting(iBBBMACIBGK);
					}
				}
				CGECKLIKPGE.Arrow.transform.DOLocalMoveY(6.8f, 0.5f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
				spriteRenderer.transform.DOLocalMoveY(6.8f, 0.5f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
				spriteRenderer2.transform.DOLocalMoveY(6.8f, 0.5f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
				CGECKLIKPGE.BackgroundCollider.enabled = true;
				return;
			}
			foreach (KeyValuePair<DuckItem, CKKKELDIOLD> item in GFCINOIEBDJ)
			{
				item.Key.ChangeSorting(item.Value);
			}
			CGECKLIKPGE.HideGoalHighlights();
			ECMJGGMIOJJ();
		}
		catch (Exception ex)
		{
			CGECKLIKPGE.HideGoalHighlights();
			ECMJGGMIOJJ();
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Tutorial, "Tutorial ID: 9 Error: {0} " + ex);
		}
	}
}
