using System;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.UI;
using DG.Tweening;
using UnityEngine;

public class KBFKGGLDGKJ : BIMAONBKNOP
{
	public int OKIEADMLFBM;

	public string KMPGGMKICLB;

	public override void GDGINCNCMDD(Cell BBJPFHPBOHC)
	{
		try
		{
			if (JCLBCFCCPGG == 1)
			{
				CNFHIFJHOBL = false;
				CGECKLIKPGE.BackgroundCollider.enabled = true;
				CGECKLIKPGE.ShowBoosterHighlight(OKIEADMLFBM);
				CGECKLIKPGE.BackgroundFadeIn();
				CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[JCLBCFCCPGG - 1]), new float[2] { 4f, 3f }, true);
				CGECKLIKPGE.RotateArrow(270);
				CGECKLIKPGE.ArrowShadow.enabled = true;
				CGECKLIKPGE.Arrow.enabled = true;
				CGECKLIKPGE.Arrow.transform.SetParent(SettingsPanel.Instance.CurrentBoosterManager.BoosterButtons[OKIEADMLFBM].transform);
				CGECKLIKPGE.Arrow.transform.localPosition = new Vector3(-0.05f, 1.45f, 0f);
				CGECKLIKPGE.Arrow.transform.SetParent(CGECKLIKPGE.transform);
				float y = CGECKLIKPGE.Arrow.transform.localPosition.y;
				CGECKLIKPGE.Arrow.transform.DOLocalMoveY(y + 0.5f, 0.5f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
			}
			else
			{
				CGECKLIKPGE.UnlockBoosterButtons();
				if (KMPGGMKICLB != null)
				{
					MKINMKEMBPL.GABGKBAKHDP.KMPGGMKICLB(KMPGGMKICLB);
				}
				CGECKLIKPGE.HideBoosterHighlight(OKIEADMLFBM);
				ECMJGGMIOJJ();
			}
		}
		catch (Exception ex)
		{
			CGECKLIKPGE.UnlockBoosterButtons();
			CGECKLIKPGE.BoosterButtonToBack(OKIEADMLFBM);
			ECMJGGMIOJJ();
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Tutorial, "Tutorial Error: {0} " + ex);
		}
	}
}
