using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Dialogs;
using UnityEngine;
using Utils;

public class LCBBCGAOLMK : OOHGOOPDAEM
{
	public LCBBCGAOLMK(Action<bool> IMHLFAHONPP)
		: base(IMHLFAHONPP)
	{
		CENGNKJGOGP = "CrownRushAnimation";
	}

	public override void GDGINCNCMDD(bool ODCADGABBHJ, bool DEIGFPCALOJ)
	{
		DIGGBGADIGJ dIGGBGADIGJ = DIGGBGADIGJ.GABGKBAKHDP;
		if (DIGGBGADIGJ.DFGKPMCBFNL && dIGGBGADIGJ.ICNIGMDCCLN)
		{
			SpriteButtonListener.Instance.EnableClicks = true;
			GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.CrownRushInfoDialog, false);
			CrownRushInfoDialog component = gameObject.GetComponent<CrownRushInfoDialog>();
			component.PrepareDialog(delegate
			{
				SpriteButtonListener.Instance.EnableClicks = false;
				if (CECMINAKHFJ != null)
				{
					CECMINAKHFJ(true);
				}
			});
		}
		else if (CECMINAKHFJ != null)
		{
			CECMINAKHFJ(false);
		}
	}

	public override bool PPOCOCCKKFF()
	{
		return DIGGBGADIGJ.DFGKPMCBFNL && DIGGBGADIGJ.GABGKBAKHDP.ICNIGMDCCLN;
	}

	public override bool HDLHHPFDHIK()
	{
		return true;
	}

	[CompilerGenerated]
	private void FKCNKMBEKDO()
	{
		SpriteButtonListener.Instance.EnableClicks = false;
		if (CECMINAKHFJ != null)
		{
			CECMINAKHFJ(true);
		}
	}
}
