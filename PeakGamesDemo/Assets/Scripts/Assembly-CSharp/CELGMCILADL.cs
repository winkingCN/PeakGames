using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Tutorials;
using DG.Tweening;
using UnityEngine;

public class CELGMCILADL : BIMAONBKNOP
{
	private bool GPHEGBDEMLP;

	private readonly string LJFNDBGECLB = "x";

	private readonly HashSet<string> GOMDNODGOFD = new HashSet<string> { "3x6", "4x6", "5x6" };

	public override void DIOELAHNLKJ(TutorialManager NGIFIPBOMBO)
	{
		base.DIOELAHNLKJ(NGIFIPBOMBO);
		EEABKKPJAOO = new string[2] { "Tutorial_Fun_0001_1", "Tutorial_Fun_0001_2" };
	}

	public override void GDGINCNCMDD(Cell BBJPFHPBOHC)
	{
		try
		{
			switch (JCLBCFCCPGG)
			{
			case 1:
			{
				int[] fFPHKNJCCIE = new int[150]
				{
					0, 0, 0, 1, 0, 2, 0, 3, 0, 4,
					0, 5, 0, 6, 0, 7, 0, 8, 1, 0,
					1, 1, 1, 2, 1, 3, 1, 4, 1, 5,
					1, 6, 1, 7, 1, 8, 2, 0, 2, 1,
					2, 2, 2, 3, 2, 4, 2, 5, 2, 6,
					2, 7, 2, 8, 3, 0, 3, 1, 3, 2,
					3, 3, 3, 4, 3, 5, 3, 6, 4, 0,
					4, 1, 4, 2, 4, 3, 4, 4, 4, 5,
					4, 6, 5, 0, 5, 1, 5, 2, 5, 3,
					5, 4, 5, 5, 5, 6, 6, 0, 6, 1,
					6, 2, 6, 3, 6, 4, 6, 5, 6, 6,
					6, 7, 6, 8, 7, 0, 7, 1, 7, 2,
					7, 3, 7, 4, 7, 5, 7, 6, 7, 7,
					7, 8, 8, 0, 8, 1, 8, 2, 8, 3,
					8, 4, 8, 5, 8, 6, 8, 7, 8, 8
				};
				OBEJDLFFIPA(fFPHKNJCCIE);
				CGECKLIKPGE.ShowHighlighCells();
				CGECKLIKPGE.BackgroundFadeIn();
				CNFHIFJHOBL = false;
				CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[JCLBCFCCPGG - 1]), new float[2] { 4f, 7.68f }, false);
				CGECKLIKPGE.ShowFingerAnimation(ONCMBJKLKIL.HINDAIPFFJL, CGECKLIKPGE.GetGlobalCellPosition(4f, 6f));
				break;
			}
			case 2:
				GPHEGBDEMLP = true;
				CNFHIFJHOBL = true;
				CGECKLIKPGE.ClearCellHighlights();
				CGECKLIKPGE.HideFingerAnimation();
				CGECKLIKPGE.HideBackground();
				CGECKLIKPGE.HideDialog();
				CHIPOHEMKEG();
				new LLCJMMBBLEH(DJIKFKIJNKM());
				break;
			default:
				CGECKLIKPGE.HideGoalHighlights();
				ECMJGGMIOJJ();
				break;
			}
		}
		catch (Exception ex)
		{
			CGECKLIKPGE.HideGoalHighlights();
			ECMJGGMIOJJ();
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Tutorial, "Tutorial ID: 1 Error: {0} " + ex);
		}
	}

	public override void BDAKKAIBMIM(Cell BBJPFHPBOHC = null, bool AEGOANBPCGB = false, bool PCCBMIJAFPK = false)
	{
		if (!GPHEGBDEMLP && (CNFHIFJHOBL || AEGOANBPCGB) && (!PCCBMIJAFPK || !(Time.time - JAPIODJLBKJ < JEONAPJKCAI)) && (!(BBJPFHPBOHC != null) || GOMDNODGOFD.Contains(BBJPFHPBOHC.X + LJFNDBGECLB + BBJPFHPBOHC.Y)))
		{
			JCLBCFCCPGG++;
			GDGINCNCMDD(BBJPFHPBOHC);
		}
	}

	private IEnumerator DJIKFKIJNKM()
	{
		yield return new WaitForSeconds(0.7f);
		GPHEGBDEMLP = false;
		CNFHIFJHOBL = false;
		JAPIODJLBKJ = Time.time;
		CGECKLIKPGE.BackImage.enabled = false;
		CGECKLIKPGE.DialogPanel.SetActive(false);
		while (FallManager.AreThereActiveAnimations())
		{
			yield return null;
		}
		CGECKLIKPGE.BackgroundFadeIn();
		CGECKLIKPGE.BackImage.enabled = true;
		Vector3 position = CGECKLIKPGE.GIMBEKBFKMJ.CurrentTopPanel.MovesLabelContainer.transform.TransformPoint(new Vector3(0f, -2.15f, 0f));
		CGECKLIKPGE.RotateArrow(90);
		CGECKLIKPGE.Arrow.transform.position = position;
		CGECKLIKPGE.Arrow.transform.localScale = Vector3.one;
		CGECKLIKPGE.Arrow.enabled = true;
		CGECKLIKPGE.ArrowShadow.enabled = true;
		CGECKLIKPGE.Arrow.transform.DOBlendableLocalMoveBy(new Vector3(0f, -0.46f, 0f), 0.5f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
		CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[JCLBCFCCPGG - 1]), new float[2] { 4f, 5.25f }, true);
		CGECKLIKPGE.ShowMovesHighlight();
		CGECKLIKPGE.BackgroundCollider.enabled = true;
	}
}
