using System;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Tutorials;
using DG.Tweening;
using UnityEngine;

public class FICHGANLHPB : GLDEFAIOJPP
{
	private Sequence BKAKLFDPKBD;

	public override void DIOELAHNLKJ(TutorialManager NGIFIPBOMBO)
	{
		base.DIOELAHNLKJ(NGIFIPBOMBO);
		EEABKKPJAOO = new string[1] { "Tutorial_0006" };
		IHKCOPJADPD = new float[2] { 4f, 8f };
		HBMJLKHHLFH = new int[72]
		{
			0, 0, 1, 0, 2, 0, 3, 0, 4, 0,
			5, 0, 6, 0, 7, 0, 8, 0, 0, 1,
			1, 1, 2, 1, 3, 1, 4, 1, 5, 1,
			6, 1, 7, 1, 8, 1, 0, 4, 1, 4,
			2, 4, 3, 4, 4, 4, 5, 4, 6, 4,
			7, 4, 8, 4, 0, 5, 1, 5, 2, 5,
			3, 5, 4, 5, 5, 5, 6, 5, 7, 5,
			8, 5
		};
	}

	public override void GDGINCNCMDD(Cell BBJPFHPBOHC)
	{
		base.GDGINCNCMDD(BBJPFHPBOHC);
		try
		{
			if (JCLBCFCCPGG == 1)
			{
				CGECKLIKPGE.RotateArrow(0);
				CGECKLIKPGE.ArrowShadow.enabled = true;
				CGECKLIKPGE.Arrow.enabled = true;
				CGECKLIKPGE.Arrow.transform.SetParent(CGECKLIKPGE.DialogPanel.transform);
				CGECKLIKPGE.Arrow.transform.localScale = new Vector3(0.8f, 0.7f, 1f);
				CGECKLIKPGE.Arrow.transform.localPosition = new Vector3(-10.619f, -1.63f, 0f);
				BKAKLFDPKBD = DOTween.Sequence();
				BKAKLFDPKBD.AppendInterval(1f);
				BKAKLFDPKBD.Append(CGECKLIKPGE.Arrow.transform.DOLocalMoveX(-2.619f, 0.5f).SetEase(Ease.OutSine));
				BKAKLFDPKBD.Append(CGECKLIKPGE.Arrow.transform.DOLocalMoveX(-3.14f, 0.5f).SetLoops(100, LoopType.Yoyo).SetEase(Ease.InOutSine));
			}
			else
			{
				BKAKLFDPKBD.Kill();
				ECMJGGMIOJJ();
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Tutorial, "Tutorial ID: 6 Error: {0} " + ex);
		}
	}
}
