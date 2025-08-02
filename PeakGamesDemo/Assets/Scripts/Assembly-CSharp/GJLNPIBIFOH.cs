using System;
using System.Collections;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Tutorials;
using DG.Tweening;
using UnityEngine;

public class GJLNPIBIFOH : BIMAONBKNOP
{
	public override void DIOELAHNLKJ(TutorialManager NGIFIPBOMBO)
	{
		base.DIOELAHNLKJ(NGIFIPBOMBO);
		EEABKKPJAOO = new string[2] { "Tutorial_0001_1", "Tutorial_0001_2" };
	}

	public override void GDGINCNCMDD(Cell BBJPFHPBOHC)
	{
		try
		{
			switch (JCLBCFCCPGG)
			{
			case 1:
			{
				int[] fFPHKNJCCIE = new int[4] { 3, 3, 3, 4 };
				OBEJDLFFIPA(fFPHKNJCCIE);
				CGECKLIKPGE.ShowHighlighCells();
				CGECKLIKPGE.BackgroundFadeIn();
				CNFHIFJHOBL = false;
				CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[JCLBCFCCPGG - 1]), new float[2] { 3f, 6f }, false);
				CGECKLIKPGE.ShowFingerAnimation(ONCMBJKLKIL.HINDAIPFFJL, CGECKLIKPGE.GetGlobalCellPosition(3f, 3f));
				break;
			}
			case 2:
				CHIPOHEMKEG();
				CGECKLIKPGE.ClearCellHighlights();
				CGECKLIKPGE.HideFingerAnimation();
				CGECKLIKPGE.BackImage.enabled = false;
				CGECKLIKPGE.DialogPanel.SetActive(false);
				CNFHIFJHOBL = false;
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

	private IEnumerator DJIKFKIJNKM()
	{
		while (FallManager.AreThereActiveAnimations())
		{
			yield return null;
		}
		CGECKLIKPGE.BackgroundFadeIn();
		CGECKLIKPGE.BackImage.enabled = true;
		Vector3 position = CGECKLIKPGE.GIMBEKBFKMJ.CurrentTopPanel.GoalPanelReference.transform.TransformPoint(new Vector3(0.112f, -1.91f, 0f));
		CGECKLIKPGE.RotateArrow(90);
		CGECKLIKPGE.Arrow.transform.position = position;
		CGECKLIKPGE.Arrow.transform.localScale = Vector3.one;
		CGECKLIKPGE.Arrow.enabled = true;
		CGECKLIKPGE.ArrowShadow.enabled = true;
		CGECKLIKPGE.Arrow.transform.DOBlendableLocalMoveBy(new Vector3(0f, -0.46f, 0f), 0.5f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
		CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[JCLBCFCCPGG - 1]), 3.7f, true);
		position.y -= 3f;
		CGECKLIKPGE.DialogPanel.transform.position = position;
		CGECKLIKPGE.ShowGoalHighlights();
		CGECKLIKPGE.BackgroundCollider.enabled = true;
	}
}
