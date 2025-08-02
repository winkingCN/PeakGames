using System;
using Assets.Scripts.CasualTools.Dialogs;
using Dialogs;
using UnityEngine;
using Utils;

public class FOJIFKGIDJN : OOHGOOPDAEM
{
	public FOJIFKGIDJN(Action<bool> IMHLFAHONPP)
		: base(IMHLFAHONPP)
	{
		CENGNKJGOGP = "CalendarAnimation";
	}

	public override void GDGINCNCMDD(bool ODCADGABBHJ, bool DEIGFPCALOJ)
	{
		string text = EKGLBJJKNBG.GABGKBAKHDP.PGMJGDOBNGL("KeyAB_Calendar");
		if (text != null && !text.Equals("0") && BPPNANHCLJI.GABGKBAKHDP.EENHGEBKDLD())
		{
			SpriteButtonListener.Instance.EnableClicks = true;
			GameObject gameObject = ((!text.Equals("1")) ? FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.CalendarGiftDialog, false) : FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.CalendarOpenDialog, false));
			CalendarDialog component = gameObject.GetComponent<CalendarDialog>();
			component.PrepareDialog(EGFKMPGIFJB, DEIGFPCALOJ);
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
		return BPPNANHCLJI.GABGKBAKHDP.EENHGEBKDLD();
	}

	public override bool HDLHHPFDHIK()
	{
		return true;
	}
}
