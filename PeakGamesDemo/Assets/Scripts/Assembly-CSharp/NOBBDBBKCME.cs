using System;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Tutorials;

public class NOBBDBBKCME : BIMAONBKNOP
{
	public int[] HBMJLKHHLFH;

	public float[] IHKCOPJADPD;

	public override void DIOELAHNLKJ(TutorialManager NGIFIPBOMBO)
	{
		base.DIOELAHNLKJ(NGIFIPBOMBO);
		EEABKKPJAOO = new string[1] { "Tutorial_1501" };
		IHKCOPJADPD = new float[2] { 3.5f, 4.72f };
		HBMJLKHHLFH = new int[128]
		{
			0, 0, 1, 0, 2, 0, 3, 0, 4, 0,
			5, 0, 6, 0, 7, 0, 0, 1, 1, 1,
			2, 1, 3, 1, 4, 1, 5, 1, 6, 1,
			7, 1, 0, 2, 1, 2, 2, 2, 3, 2,
			4, 2, 5, 2, 6, 2, 7, 2, 0, 3,
			1, 3, 2, 3, 3, 3, 4, 3, 5, 3,
			6, 3, 7, 3, 0, 4, 1, 4, 2, 4,
			3, 4, 4, 4, 5, 4, 6, 4, 7, 4,
			0, 5, 1, 5, 2, 5, 3, 5, 4, 5,
			5, 5, 6, 5, 7, 5, 0, 6, 1, 6,
			2, 6, 3, 6, 4, 6, 5, 6, 6, 6,
			7, 6, 0, 7, 1, 7, 2, 7, 3, 7,
			4, 7, 5, 7, 6, 7, 7, 7
		};
	}

	public override void GDGINCNCMDD(Cell BBJPFHPBOHC)
	{
		if (HBMJLKHHLFH == null)
		{
			return;
		}
		try
		{
			if (JCLBCFCCPGG == 1)
			{
				OBEJDLFFIPA(HBMJLKHHLFH);
				CGECKLIKPGE.ShowHighlightCellsWithBorders();
				CGECKLIKPGE.BackgroundFadeIn();
				CGECKLIKPGE.BackgroundCollider.enabled = true;
				CNFHIFJHOBL = false;
				CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[JCLBCFCCPGG - 1]), IHKCOPJADPD, true, 0.59f);
			}
			else
			{
				ECMJGGMIOJJ();
			}
		}
		catch (Exception ex)
		{
			ECMJGGMIOJJ();
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Tutorial, "Tutorial ID: {0} Error: {1} ", ToString(), ex);
		}
	}
}
