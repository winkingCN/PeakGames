using System;
using NewMapScene;
using Utils;

public class AFBFCOONECN : OOHGOOPDAEM
{
	private readonly NewMapAnimationController FAKNOPAIHMM;

	public AFBFCOONECN(NewMapAnimationController KFIBCBIIFFA, Action<bool> IMHLFAHONPP)
		: base(IMHLFAHONPP)
	{
		FAKNOPAIHMM = KFIBCBIIFFA;
		CENGNKJGOGP = "FacebookStatusAnimation";
	}

	public override void GDGINCNCMDD(bool ODCADGABBHJ, bool DEIGFPCALOJ)
	{
		bool obj = false;
		if (FAKNOPAIHMM.BlockFacebookPopup)
		{
			FAKNOPAIHMM.BlockFacebookPopup = false;
			IIMOEAOONKA.IKIAIFNKFBK = KAKOONJCENE.None;
			if (CECMINAKHFJ != null)
			{
				CECMINAKHFJ(false);
			}
			return;
		}
		switch (IIMOEAOONKA.IKIAIFNKFBK)
		{
		case KAKOONJCENE.LoginInOk:
			FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.FacebookConnectedDialog, false, false, false, null, false);
			DialogLibrary.GABGKBAKHDP.ShowDialogBackgroundFast();
			obj = true;
			break;
		case KAKOONJCENE.LogOutOk:
			FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.FacebookLogoutSuccededDialog, false, false, false, null, false);
			DialogLibrary.GABGKBAKHDP.ShowDialogBackgroundFast();
			obj = true;
			break;
		case KAKOONJCENE.LogoutFailed:
			FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.FacebookLogoutFailedDialog, false, false, false, null, false);
			DialogLibrary.GABGKBAKHDP.ShowDialogBackgroundFast();
			obj = true;
			break;
		}
		IIMOEAOONKA.IKIAIFNKFBK = KAKOONJCENE.None;
		if (CECMINAKHFJ != null)
		{
			CECMINAKHFJ(obj);
		}
	}
}
