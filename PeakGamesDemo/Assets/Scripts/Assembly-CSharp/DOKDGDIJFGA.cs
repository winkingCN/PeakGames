using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using UnityEngine;
using Utils;

public class DOKDGDIJFGA : OOHGOOPDAEM
{
	public DOKDGDIJFGA(Action<bool> IMHLFAHONPP)
		: base(IMHLFAHONPP)
	{
		CENGNKJGOGP = "PurchaseRetrySuccessAnimation";
	}

	public override void GDGINCNCMDD(bool ODCADGABBHJ, bool DEIGFPCALOJ)
	{
		if (ANGCNEFIIHE.GABGKBAKHDP.KBMLOIMHBCB)
		{
			SpriteButtonListener.Instance.EnableClicks = true;
			ANGCNEFIIHE.GABGKBAKHDP.KBMLOIMHBCB = false;
			GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.PurchaseRetryCompletedDialog, false);
			DefaultDialog component = gameObject.GetComponent<DefaultDialog>();
			component.OnDialogClosedAction = delegate
			{
				SpriteButtonListener.Instance.EnableClicks = false;
				if (CECMINAKHFJ != null)
				{
					CECMINAKHFJ(true);
				}
			};
		}
		else if (CECMINAKHFJ != null)
		{
			CECMINAKHFJ(false);
		}
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
