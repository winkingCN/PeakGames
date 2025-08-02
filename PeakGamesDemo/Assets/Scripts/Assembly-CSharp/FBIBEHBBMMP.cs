using System;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Tutorials;
using Assets.Scripts.GamePlayScene.UI;
using DG.Tweening;
using UnityEngine;

public class FBIBEHBBMMP : BIMAONBKNOP
{
	private const int OKIEADMLFBM = 0;

	public override void DIOELAHNLKJ(TutorialManager NGIFIPBOMBO)
	{
		base.DIOELAHNLKJ(NGIFIPBOMBO);
		EEABKKPJAOO = new string[2] { "Tutorial_0010_1", "Tutorial_0010_2" };
	}

	public override void GDGINCNCMDD(Cell BBJPFHPBOHC)
	{
		try
		{
			switch (JCLBCFCCPGG)
			{
			case 1:
			{
				CNFHIFJHOBL = false;
				TutorialManager.ShowBoosterPanel = false;
				CGECKLIKPGE.ShowBoosterHighlight(0);
				CGECKLIKPGE.BackgroundFadeIn();
				CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[JCLBCFCCPGG - 1]), new float[2] { 4f, 1.7f }, false);
				CGECKLIKPGE.RotateArrow(270);
				CGECKLIKPGE.ArrowShadow.enabled = true;
				CGECKLIKPGE.Arrow.enabled = true;
				CGECKLIKPGE.Arrow.transform.SetParent(SettingsPanel.Instance.CurrentBoosterManager.BoosterButtons[0].transform);
				CGECKLIKPGE.Arrow.transform.localPosition = new Vector3(-0.05f, 1.45f, 0f);
				CGECKLIKPGE.Arrow.transform.SetParent(CGECKLIKPGE.transform);
				float y = CGECKLIKPGE.Arrow.transform.localPosition.y;
				CGECKLIKPGE.Arrow.transform.DOLocalMoveY(y + 0.5f, 0.5f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
				break;
			}
			case 2:
			{
				int[] fFPHKNJCCIE = new int[2] { 4, 0 };
				OBEJDLFFIPA(fFPHKNJCCIE);
				CGECKLIKPGE.ShowHighlighCells();
				CGECKLIKPGE.Arrow.transform.DOKill();
				CGECKLIKPGE.ArrowShadow.enabled = false;
				CGECKLIKPGE.Arrow.enabled = false;
				CNFHIFJHOBL = false;
				CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[JCLBCFCCPGG - 1]), new float[2] { 4f, 3f }, false);
				CGECKLIKPGE.ShowFingerAnimation(ONCMBJKLKIL.HINDAIPFFJL, CGECKLIKPGE.GetGlobalCellPosition(4f, 0f));
				break;
			}
			default:
				CGECKLIKPGE.UnlockBoosterButtons();
				CGECKLIKPGE.BoosterButtonToBack(0);
				MKINMKEMBPL.GABGKBAKHDP.KMPGGMKICLB("Tutorial10");
				ECMJGGMIOJJ();
				break;
			}
		}
		catch (Exception ex)
		{
			CGECKLIKPGE.UnlockBoosterButtons();
			CGECKLIKPGE.BoosterButtonToBack(0);
			ECMJGGMIOJJ();
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Tutorial, "Tutorial ID: 10 Error: {0} " + ex);
		}
	}
}
