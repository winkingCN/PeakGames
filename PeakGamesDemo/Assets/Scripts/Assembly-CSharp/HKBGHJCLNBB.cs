using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.Dialogs;
using Assets.Scripts.MapScene;
using UnityEngine;
using Utils;

public class HKBGHJCLNBB : OOHGOOPDAEM
{
	public HKBGHJCLNBB(Action<bool> IMHLFAHONPP)
		: base(IMHLFAHONPP)
	{
		CENGNKJGOGP = "InitialDialogsAnimation";
	}

	public override void GDGINCNCMDD(bool ODCADGABBHJ, bool DEIGFPCALOJ)
	{
		if (ODCADGABBHJ || !IDFPAFEJPPH.GABGKBAKHDP.BKHKOOOFMBI)
		{
			if (CECMINAKHFJ != null)
			{
				CECMINAKHFJ(false);
			}
			return;
		}
		SpriteButtonListener.Instance.EnableClicks = true;
		int num = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC();
		if (num + 1 > 2850 && !MapManager.DidShowMoreLevelsPopup)
		{
			MapManager.DidShowMoreLevelsPopup = true;
			GameObject gameObject = null;
			int num2 = IMLNKMACKMF.GABGKBAKHDP.PCBNDMDMAHJ;
			gameObject = ((num2 <= num + 1) ? FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.MoreLevelsDialog, false) : FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.NewLevelsDialog, false));
			GenericMessageDialog component = gameObject.GetComponent<GenericMessageDialog>();
			component.ActionToPerformOnClose = delegate
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
