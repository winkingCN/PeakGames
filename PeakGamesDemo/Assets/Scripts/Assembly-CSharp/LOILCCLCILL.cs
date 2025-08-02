using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.Utils;
using DG.Tweening;
using Dialogs;
using UnityEngine;
using Utils;

public class LOILCCLCILL : OOHGOOPDAEM
{
	private readonly int OCEANCKNAOH;

	private readonly int KHAGBPDKPAH;

	private readonly float DOAKDOGFPPL;

	public LOILCCLCILL(float DKIPEJPGACG, int ABJDELCBHCM, int MBOBPGKGKLH, Action<bool> IMHLFAHONPP)
		: base(IMHLFAHONPP)
	{
		CENGNKJGOGP = "RateUsDialogAnimation";
		OCEANCKNAOH = ABJDELCBHCM;
		KHAGBPDKPAH = MBOBPGKGKLH;
		DOAKDOGFPPL = DKIPEJPGACG;
	}

	public override void GDGINCNCMDD(bool ODCADGABBHJ, bool DEIGFPCALOJ)
	{
		if (KHAGBPDKPAH == FocusListener.MOGJKPIEGGL && JHOAHCHHBCH.IGAHBMBJMAB < 500 && RateUsDialog.ShouldDisplayRateUsForLevel(OCEANCKNAOH - 1))
		{
			if (NAAGDFCLOPE.GABGKBAKHDP.GFMLBLFOHDG())
			{
				if (CECMINAKHFJ != null)
				{
					CECMINAKHFJ(true);
				}
				return;
			}
			Sequence s = DOTween.Sequence();
			s.InsertCallback(DOAKDOGFPPL, delegate
			{
				SpriteButtonListener.Instance.EnableClicks = true;
				GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.RateUsDialog, true);
				RateUsDialog component = gameObject.GetComponent<RateUsDialog>();
				component.OnClose = delegate
				{
					SpriteButtonListener.Instance.EnableClicks = false;
					if (CECMINAKHFJ != null)
					{
						CECMINAKHFJ(true);
					}
				};
			});
		}
		else if (CECMINAKHFJ != null)
		{
			CECMINAKHFJ(false);
		}
	}

	public override bool PPOCOCCKKFF()
	{
		return RateUsDialog.ShouldDisplayRateUsForLevel(OCEANCKNAOH - 1);
	}

	[CompilerGenerated]
	private void FKCNKMBEKDO()
	{
		SpriteButtonListener.Instance.EnableClicks = true;
		GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.RateUsDialog, true);
		RateUsDialog component = gameObject.GetComponent<RateUsDialog>();
		component.OnClose = delegate
		{
			SpriteButtonListener.Instance.EnableClicks = false;
			if (CECMINAKHFJ != null)
			{
				CECMINAKHFJ(true);
			}
		};
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
