using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.Dialogs;
using Assets.Scripts.MapScene;
using UnityEngine;
using Utils;

public class GEOHHDNOOEM : OOHGOOPDAEM
{
	private readonly int MEHJHMKEKML;

	public GEOHHDNOOEM(int HOFIKCKJGBA, Action<bool> IMHLFAHONPP)
		: base(IMHLFAHONPP)
	{
		CENGNKJGOGP = "MoreLevelsDialogAnimation";
		MEHJHMKEKML = HOFIKCKJGBA;
	}

	public override void GDGINCNCMDD(bool ODCADGABBHJ, bool DEIGFPCALOJ)
	{
		if (IIMOEAOONKA.IKIAIFNKFBK == KAKOONJCENE.None && MEHJHMKEKML + 1 > 2850 && !MapManager.DidShowMoreLevelsPopup && IDFPAFEJPPH.GABGKBAKHDP.BKHKOOOFMBI)
		{
			SpriteButtonListener.Instance.EnableClicks = true;
			MapManager.DidShowMoreLevelsPopup = true;
			GameObject gameObject = null;
			int num = IMLNKMACKMF.GABGKBAKHDP.PCBNDMDMAHJ;
			gameObject = ((num <= MEHJHMKEKML) ? FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.MoreLevelsDialog, false) : FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.NewLevelsDialog, false));
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
