using System;
using Assets.Scripts.CasualTools.Dialogs;
using Dialogs;
using UnityEngine;
using Utils;

public class JNBLANLHOMI : OOHGOOPDAEM
{
	public JNBLANLHOMI(Action<bool> IMHLFAHONPP)
		: base(IMHLFAHONPP)
	{
		CENGNKJGOGP = "StarTournamentAnimation";
	}

	public override void GDGINCNCMDD(bool ODCADGABBHJ, bool DEIGFPCALOJ)
	{
		GPAFPAEDOHM gPAFPAEDOHM = DGOMNDMPMBG.GABGKBAKHDP.IIEALLANECJ;
		if (gPAFPAEDOHM != null)
		{
			if (gPAFPAEDOHM.LMIPACNFAAB && !StarTournamentRewardsDialog.DialogActive)
			{
				SpriteButtonListener.Instance.EnableClicks = true;
				FHAAAFAAMDO.GABGKBAKHDP.FPGFIAKIIID(true);
				GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.StarTournamentRewardsDialog, false);
				StarTournamentRewardsDialog component = gameObject.GetComponent<StarTournamentRewardsDialog>();
				component.PrepareDialog(EGFKMPGIFJB, DEIGFPCALOJ);
			}
			else if (gPAFPAEDOHM.BPDNGDOGLIO)
			{
				SpriteButtonListener.Instance.EnableClicks = true;
				GameObject gameObject2 = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.StarTournamentInfoDialog, false);
				StarTournamentInfoDialog component2 = gameObject2.GetComponent<StarTournamentInfoDialog>();
				component2.SetOnDialogClosedCallback(EGFKMPGIFJB);
				gPAFPAEDOHM.BCBDPNPEKFI();
				gPAFPAEDOHM.JDBFNCMJMCH();
			}
			else if (gPAFPAEDOHM.LJGNJNOIAPH)
			{
				SpriteButtonListener.Instance.EnableClicks = true;
				GameObject gameObject3 = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.StarTournamentAnnouncementDialog, false);
				OnCloseCallbackDialog component3 = gameObject3.GetComponent<OnCloseCallbackDialog>();
				component3.SetOnDialogClosedCallback(EGFKMPGIFJB);
				gPAFPAEDOHM.JDBFNCMJMCH();
			}
			else if (CECMINAKHFJ != null)
			{
				CECMINAKHFJ(false);
			}
		}
		else if (CECMINAKHFJ != null)
		{
			CECMINAKHFJ(false);
		}
	}

	private void EGFKMPGIFJB()
	{
		SpriteButtonListener.Instance.EnableClicks = false;
		if (CECMINAKHFJ != null)
		{
			CECMINAKHFJ(true);
		}
	}

	public override bool PPOCOCCKKFF()
	{
		GPAFPAEDOHM gPAFPAEDOHM = DGOMNDMPMBG.GABGKBAKHDP.IIEALLANECJ;
		return gPAFPAEDOHM != null && ((gPAFPAEDOHM.LMIPACNFAAB && !StarTournamentRewardsDialog.DialogActive) || gPAFPAEDOHM.BPDNGDOGLIO || gPAFPAEDOHM.LJGNJNOIAPH);
	}

	public override bool HDLHHPFDHIK()
	{
		return true;
	}
}
