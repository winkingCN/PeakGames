using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.MapScene;
using DG.Tweening;
using MapScene;

public class GCOPIPGDCBP : OOHGOOPDAEM
{
	[CompilerGenerated]
	private sealed class LBCOPNAFBOH
	{
		internal IDFPAFEJPPH BAHPHINCAAM;

		internal GCOPIPGDCBP PDAPIGLEPGC;

		internal void AGFNGEFDHLA()
		{
			if (PDAPIGLEPGC.KHHALBKHEMI.gameObject.activeSelf && !BAHPHINCAAM.HGNJBHGBLIN)
			{
				PDAPIGLEPGC.KHHALBKHEMI.PlayButtonAnimation();
			}
			else if (PDAPIGLEPGC.OEJBIFGBHJJ.gameObject.activeSelf && BAHPHINCAAM.HGNJBHGBLIN)
			{
				PDAPIGLEPGC.OEJBIFGBHJJ.PlayButtonAnimation();
			}
			PDAPIGLEPGC.HDHCLKHLCEB.CurrentNewMapAnimationController.StarTournamentDisplay.PlayStarCollectAnimation();
			PDAPIGLEPGC.HDHCLKHLCEB.CurrentNewMapAnimationController.TeamTournamentDisplay.StartIconAnimation(true);
		}

		internal void KDACLOKGNAM()
		{
			if (PDAPIGLEPGC.CECMINAKHFJ != null)
			{
				PDAPIGLEPGC.CECMINAKHFJ(true);
			}
		}
	}

	private readonly LevelButton KHHALBKHEMI;

	private readonly LevelButton OEJBIFGBHJJ;

	private readonly MapManager HDHCLKHLCEB;

	public GCOPIPGDCBP(MapManager GCONMABJKBG, LevelButton CGLHLOCLIJL, LevelButton COMOJCINGGL, Action<bool> IMHLFAHONPP)
		: base(IMHLFAHONPP)
	{
		CENGNKJGOGP = "LevelUnlockedAnimation";
		KHHALBKHEMI = COMOJCINGGL;
		OEJBIFGBHJJ = CGLHLOCLIJL;
		HDHCLKHLCEB = GCONMABJKBG;
	}

	public override void GDGINCNCMDD(bool ODCADGABBHJ, bool DEIGFPCALOJ)
	{
		if (LevelBuilder.LastLevel.HLFNDDEDJOI && !HDHCLKHLCEB.EpisodeUnlocked)
		{
			IDFPAFEJPPH BAHPHINCAAM = IDFPAFEJPPH.GABGKBAKHDP;
			Sequence sequence = DOTween.Sequence();
			sequence.AppendCallback(delegate
			{
				if (KHHALBKHEMI.gameObject.activeSelf && !BAHPHINCAAM.HGNJBHGBLIN)
				{
					KHHALBKHEMI.PlayButtonAnimation();
				}
				else if (OEJBIFGBHJJ.gameObject.activeSelf && BAHPHINCAAM.HGNJBHGBLIN)
				{
					OEJBIFGBHJJ.PlayButtonAnimation();
				}
				HDHCLKHLCEB.CurrentNewMapAnimationController.StarTournamentDisplay.PlayStarCollectAnimation();
				HDHCLKHLCEB.CurrentNewMapAnimationController.TeamTournamentDisplay.StartIconAnimation(true);
			});
			sequence.AppendInterval((!DEIGFPCALOJ && !NDGOJGLPIJF.GABGKBAKHDP.BMKIICIJGEK()) ? 0.85f : 1.8f);
			sequence.OnComplete(delegate
			{
				if (CECMINAKHFJ != null)
				{
					CECMINAKHFJ(true);
				}
			});
		}
		else
		{
			HDHCLKHLCEB.CurrentNewMapAnimationController.TeamTournamentDisplay.StartIconAnimation(true);
			if (CECMINAKHFJ != null)
			{
				CECMINAKHFJ(false);
			}
		}
	}
}
