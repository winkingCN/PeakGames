using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.MapScene;
using UnityEngine;
using Utils;

public class AGHCCCFOBFA : OOHGOOPDAEM
{
	public AGHCCCFOBFA(Action<bool> IMHLFAHONPP)
		: base(IMHLFAHONPP)
	{
		CENGNKJGOGP = "LifeHackAnimation";
	}

	public override void GDGINCNCMDD(bool ODCADGABBHJ, bool DEIGFPCALOJ)
	{
		if (ELBMHNOBHPN.DJGMHLLAGLE)
		{
			SpriteButtonListener.Instance.EnableClicks = true;
			GJOOFNFENMI();
			GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.LifeHackDialog, false);
			DefaultDialog component = gameObject.GetComponent<DefaultDialog>();
			component.OnDialogClosedAction = delegate
			{
				if (PJPPADHKGHN.GABGKBAKHDP.PMBGCACJIHD().DLDHNNCGIPI != 0)
				{
					GJOOFNFENMI();
				}
				ELBMHNOBHPN.NANPEDFGNEP();
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

	private static void GJOOFNFENMI()
	{
		if (ELBMHNOBHPN.IFBBNKJDOHE)
		{
			PJPPADHKGHN.GABGKBAKHDP.JFPAMGINAEO();
			LevelBuilder.LastLevel.HLFNDDEDJOI = false;
			LevelBuilder.LastLevel.FDEODFEHEFB = 0;
			NDGOJGLPIJF.GABGKBAKHDP.AMKOJOKCELO = 0;
			if (MapManager.Instance != null)
			{
				MapManager.Instance.CurrentNewMapAnimationController.StarChestDisplay.UpdateDisplay();
			}
		}
		else
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.LifeStatusHelper, "Life hack detected but restore failed.");
		}
	}

	[CompilerGenerated]
	private void FKCNKMBEKDO()
	{
		if (PJPPADHKGHN.GABGKBAKHDP.PMBGCACJIHD().DLDHNNCGIPI != 0)
		{
			GJOOFNFENMI();
		}
		ELBMHNOBHPN.NANPEDFGNEP();
		SpriteButtonListener.Instance.EnableClicks = false;
		if (CECMINAKHFJ != null)
		{
			CECMINAKHFJ(true);
		}
	}
}
