using System;
using Assets.Scripts.GamePlayScene.Mechanics;

public class EMGJANDMIPL : BIMAONBKNOP
{
	public int[] HBMJLKHHLFH;

	public float[] IHKCOPJADPD;

	public float MIFPEGLLOKK;

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
				CGECKLIKPGE.BackgroundFadeIn();
				CGECKLIKPGE.ShowHighlighCells();
				CGECKLIKPGE.BackgroundCollider.enabled = true;
				CNFHIFJHOBL = false;
				if (MIFPEGLLOKK > 0f)
				{
					CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[JCLBCFCCPGG - 1]), IHKCOPJADPD, true, MIFPEGLLOKK);
				}
				else
				{
					CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[JCLBCFCCPGG - 1]), IHKCOPJADPD, true);
				}
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
