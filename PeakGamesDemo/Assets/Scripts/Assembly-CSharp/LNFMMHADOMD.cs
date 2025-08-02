using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Dialogs;
using UnityEngine;
using Utils;

public class LNFMMHADOMD : OOHGOOPDAEM
{
	private readonly bool DIMHJCAJFPB;

	public LNFMMHADOMD(bool CGOEOKBIJLD, Action<bool> IMHLFAHONPP)
		: base(IMHLFAHONPP)
	{
		CENGNKJGOGP = "ChampionsLeagueAnimation";
		DIMHJCAJFPB = CGOEOKBIJLD;
	}

	public override void GDGINCNCMDD(bool ODCADGABBHJ, bool DEIGFPCALOJ)
	{
		if (!CLEnterenceDialog.DialogActive && IDFPAFEJPPH.GABGKBAKHDP.HFAHKLBJAEC)
		{
			SpriteButtonListener.Instance.EnableClicks = true;
			GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.CLEnterenceDialog, DIMHJCAJFPB);
			CLEnterenceDialog component = gameObject.GetComponent<CLEnterenceDialog>();
			component.PrepareDialog(delegate
			{
				SpriteButtonListener.Instance.EnableClicks = false;
				if (CECMINAKHFJ != null)
				{
					CECMINAKHFJ(true);
				}
			});
		}
		else if (JHOAHCHHBCH.CCAJIIFJPFF() && !CLRewardsDialog.DialogActive && IDFPAFEJPPH.GABGKBAKHDP.GMLKJFHEDPF)
		{
			SpriteButtonListener.Instance.EnableClicks = true;
			GameObject gameObject2 = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.CLRewardsDialog, DIMHJCAJFPB);
			CLRewardsDialog component2 = gameObject2.GetComponent<CLRewardsDialog>();
			component2.PrepareDialog(delegate
			{
				SpriteButtonListener.Instance.EnableClicks = false;
				if (CECMINAKHFJ != null)
				{
					CECMINAKHFJ(true);
				}
			}, DEIGFPCALOJ);
		}
		else if (CECMINAKHFJ != null)
		{
			CECMINAKHFJ(false);
		}
	}

	public override bool PPOCOCCKKFF()
	{
		return !CLEnterenceDialog.DialogActive && (IDFPAFEJPPH.GABGKBAKHDP.HFAHKLBJAEC || IDFPAFEJPPH.GABGKBAKHDP.GMLKJFHEDPF);
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
