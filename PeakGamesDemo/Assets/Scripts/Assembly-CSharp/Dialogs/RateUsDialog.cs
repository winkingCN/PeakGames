using System;
using System.Linq;
using Assets.Scripts.Dialogs;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.MapScene;
using UnityEngine;

namespace Dialogs
{
	public class RateUsDialog : SimpleDialog
	{
		public const string KeyRateUs = "Key_Rate_Us";

		public static readonly int[] RateLevels = new int[10] { 10, 26, 45, 68, 95, 113, 137, 154, 178, 205 };

		public Action OnClose;

		public static bool ShouldDisplayRateUsForLevel(int GIOFHACJEGA)
		{
			if (!JHOAHCHHBCH.CCAJIIFJPFF())
			{
				return false;
			}
			if (!LevelBuilder.LastLevel.HLFNDDEDJOI)
			{
				return false;
			}
			string text = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("Key_Rate_Us");
			return text == null && OJEBOCKIPOE(GIOFHACJEGA);
		}

		private static bool OJEBOCKIPOE(int GIOFHACJEGA)
		{
			if (RateLevels.Contains(GIOFHACJEGA))
			{
				return true;
			}
			if (GIOFHACJEGA < RateLevels[RateLevels.Length - 1])
			{
				return false;
			}
			int mapIdForLevel = MapManager.GetMapIdForLevel(GIOFHACJEGA);
			return (float)GIOFHACJEGA == MapManager.GetLevelsForEpisode(mapIdForLevel).x + 1f && NAAGDFCLOPE.GABGKBAKHDP.KJNBMEGHDGE();
		}

		public void OnRateClick()
		{
			Application.OpenURL(MCJHHDACJBG.OLCJMEAHEHG);
			HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("Key_Rate_Us", "1");
			Close();
		}

		public override void OnDialogClosed()
		{
			base.OnDialogClosed();
			if (OnClose != null)
			{
				OnClose();
			}
		}
	}
}
