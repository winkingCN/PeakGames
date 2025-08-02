using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.MapScene;
using DG.Tweening;
using Dialogs;
using UnityEngine;
using Utils;

public class MPJFFCOPDHO : OOHGOOPDAEM
{
	public MPJFFCOPDHO(Action<bool> IMHLFAHONPP)
		: base(IMHLFAHONPP)
	{
		CENGNKJGOGP = "EpisodeUnlockedAnimation";
	}

	public override void GDGINCNCMDD(bool ODCADGABBHJ, bool DEIGFPCALOJ)
	{
		if (ODCADGABBHJ)
		{
			if (CECMINAKHFJ != null)
			{
				CECMINAKHFJ(false);
			}
		}
		else if (MapManager.Instance.EpisodeUnlocked && IMINNGDLCCE.EHFANHPHHEB(MapManager.Instance.AGBOBACEIEP))
		{
			DOTween.Sequence().InsertCallback(0.5f, delegate
			{
				MapManager.Instance.EpisodeUnlocked = false;
				SpriteButtonListener.Instance.EnableClicks = true;
				GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.EpisodeUnlockedDialog, false, false, false, null, false);
				EpisodeUnlockedDialog component = gameObject.GetComponent<EpisodeUnlockedDialog>();
				component.PrepareDialog(delegate
				{
					SpriteButtonListener.Instance.EnableClicks = false;
					if (CECMINAKHFJ != null)
					{
						CECMINAKHFJ(true);
					}
				});
			});
		}
		else if (CECMINAKHFJ != null)
		{
			CECMINAKHFJ(false);
		}
	}

	public override bool PPOCOCCKKFF()
	{
		return MapManager.Instance.EpisodeUnlocked;
	}

	[CompilerGenerated]
	private void FKCNKMBEKDO()
	{
		MapManager.Instance.EpisodeUnlocked = false;
		SpriteButtonListener.Instance.EnableClicks = true;
		GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.EpisodeUnlockedDialog, false, false, false, null, false);
		EpisodeUnlockedDialog component = gameObject.GetComponent<EpisodeUnlockedDialog>();
		component.PrepareDialog(delegate
		{
			SpriteButtonListener.Instance.EnableClicks = false;
			if (CECMINAKHFJ != null)
			{
				CECMINAKHFJ(true);
			}
		});
	}

	[CompilerGenerated]
	private void DFBDKCLJKHB()
	{
		SpriteButtonListener.Instance.EnableClicks = false;
		if (CECMINAKHFJ != null)
		{
			CECMINAKHFJ(true);
		}
	}
}
