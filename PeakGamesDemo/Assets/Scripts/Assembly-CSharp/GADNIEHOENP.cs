using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.Dialogs;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Tutorials;
using DG.Tweening;
using Utils;

public class GADNIEHOENP : OOHGOOPDAEM
{
	[CompilerGenerated]
	private sealed class NCEBMEOHMAC
	{
		internal NAAHKHPBAPA DGNPPAOIPIA;

		internal GADNIEHOENP PDAPIGLEPGC;

		internal void AGFNGEFDHLA()
		{
			SpriteButtonListener.Instance.EnableClicks = true;
			BoosterUnlockedDialog component = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.BoosterUnlockedDialog, true).GetComponent<BoosterUnlockedDialog>();
			if (!(component != null))
			{
				return;
			}
			component.SetResourceItem(DGNPPAOIPIA, delegate
			{
				SpriteButtonListener.Instance.EnableClicks = false;
				if (PDAPIGLEPGC.CECMINAKHFJ != null)
				{
					PDAPIGLEPGC.CECMINAKHFJ(true);
				}
			});
		}

		internal void KDACLOKGNAM()
		{
			SpriteButtonListener.Instance.EnableClicks = false;
			if (PDAPIGLEPGC.CECMINAKHFJ != null)
			{
				PDAPIGLEPGC.CECMINAKHFJ(true);
			}
		}
	}

	private readonly float DOAKDOGFPPL;

	public GADNIEHOENP(float DKIPEJPGACG, Action<bool> IMHLFAHONPP)
		: base(IMHLFAHONPP)
	{
		CENGNKJGOGP = "BoosterUnlockAnimation";
		DOAKDOGFPPL = DKIPEJPGACG;
		CECMINAKHFJ = IMHLFAHONPP;
	}

	public override void GDGINCNCMDD(bool ODCADGABBHJ, bool DEIGFPCALOJ)
	{
		NAAHKHPBAPA DGNPPAOIPIA = POEGFPJEHHB(MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC());
		if (DGNPPAOIPIA != 0)
		{
			Sequence s = DOTween.Sequence();
			s.InsertCallback(DOAKDOGFPPL, delegate
			{
				SpriteButtonListener.Instance.EnableClicks = true;
				BoosterUnlockedDialog component = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.BoosterUnlockedDialog, true).GetComponent<BoosterUnlockedDialog>();
				if (component != null)
				{
					component.SetResourceItem(DGNPPAOIPIA, delegate
					{
						SpriteButtonListener.Instance.EnableClicks = false;
						if (CECMINAKHFJ != null)
						{
							CECMINAKHFJ(true);
						}
					});
				}
			});
		}
		else if (CECMINAKHFJ != null)
		{
			CECMINAKHFJ(false);
		}
	}

	private static NAAHKHPBAPA POEGFPJEHHB(int MELFMFDHPBO)
	{
		NAAHKHPBAPA result = NAAHKHPBAPA.None;
		if (!TutorialManager.ShouldDisplayBoosterTutorial)
		{
			return result;
		}
		TutorialManager.ShouldDisplayBoosterTutorial = false;
		if (MELFMFDHPBO == 9 && !MKINMKEMBPL.GABGKBAKHDP.HEANMKDLPGF("HammerUnlocked"))
		{
			result = NAAHKHPBAPA.Hammer;
			MKINMKEMBPL.GABGKBAKHDP.KMPGGMKICLB("HammerUnlocked");
		}
		else if (MELFMFDHPBO == 12 && !MKINMKEMBPL.GABGKBAKHDP.HEANMKDLPGF("BoxingGloveUnlocked"))
		{
			result = NAAHKHPBAPA.BoxingGlove;
			MKINMKEMBPL.GABGKBAKHDP.KMPGGMKICLB("BoxingGloveUnlocked");
		}
		else if (MELFMFDHPBO == 16 && !MKINMKEMBPL.GABGKBAKHDP.HEANMKDLPGF("AnvilUnlocked"))
		{
			result = NAAHKHPBAPA.Anvil;
			MKINMKEMBPL.GABGKBAKHDP.KMPGGMKICLB("AnvilUnlocked");
		}
		else if (MELFMFDHPBO == BoosterManager.EOEHGMKBEHF && !MKINMKEMBPL.GABGKBAKHDP.HEANMKDLPGF("ShuffleUnlocked"))
		{
			result = NAAHKHPBAPA.Dice;
			MKINMKEMBPL.GABGKBAKHDP.KMPGGMKICLB("ShuffleUnlocked");
		}
		return result;
	}
}
