using System.Collections.Generic;
using Assets.Scripts.Dialogs;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.UI;
using Assets.Scripts.Utils.Analytics;
using UnityEngine;

namespace Dialogs
{
	public class NoPossibleMovesDialog : SimpleDialog
	{
		private KFCEILFGADG NLKHKDBCLMB;

		public override void OnDialogClosed()
		{
			if (NLKHKDBCLMB != null)
			{
				NLKHKDBCLMB.GIMBEKBFKMJ.RestartLevel();
			}
		}

		public void SetContent(KFCEILFGADG GIOFHACJEGA)
		{
			NLKHKDBCLMB = GIOFHACJEGA;
			LevelBuilder.Recorder.GAMDCIKLKJC(true);
			CIBKGNFLBDE(NLKHKDBCLMB);
			PJPPADHKGHN.GABGKBAKHDP.CJNFILFKEAC();
			List<NOALGNJECAD> list = new List<NOALGNJECAD>(3);
			foreach (KeyValuePair<NAAHKHPBAPA, int> item in NLKHKDBCLMB.CFDBAMKOABO)
			{
				switch (item.Key)
				{
				case NAAHKHPBAPA.Rocket:
					if (item.Value > 0)
					{
						list.Add(NOALGNJECAD.Rocket);
					}
					break;
				case NAAHKHPBAPA.Bomb:
					if (item.Value > 0)
					{
						list.Add(NOALGNJECAD.Bomb);
					}
					break;
				case NAAHKHPBAPA.DiscoBall:
					if (item.Value > 0)
					{
						list.Add(NOALGNJECAD.DiscoBall);
					}
					break;
				}
				GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(item.Key, item.Value);
			}
			if (list.Count > 0)
			{
				BoosterSelectDialog.LatestSelectedItems = list;
			}
			SettingsPanel.Instance.CurrentBoosterManager.UpdateBoosterCounts();
		}

		private static void CIBKGNFLBDE(KFCEILFGADG GIOFHACJEGA)
		{
			JsonLevelEndInventory jsonLevelEndInventory = new JsonLevelEndInventory();
			jsonLevelEndInventory.inventory = new JsonInventory();
			JsonLevelEndInventory jsonLevelEndInventory2 = jsonLevelEndInventory;
			jsonLevelEndInventory2.inventory.LDOCFEGBGNK();
			jsonLevelEndInventory2.NMCGKNPBGKC(true);
			int moves_given = GIOFHACJEGA.HJCPDOGONIG + (LevelBuilder.LastLevel.EKGHEGKILLC ? IDFPAFEJPPH.GABGKBAKHDP.BFBNJLMHPFA : 0);
			JsonLevelEndData jsonLevelEndData = new JsonLevelEndData();
			jsonLevelEndData.user_id = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString();
			jsonLevelEndData.level = ((!LevelBuilder.LastLevel.EKGHEGKILLC) ? GIOFHACJEGA.PDGLECFDLJJ : (-1 * GIOFHACJEGA.PDGLECFDLJJ));
			jsonLevelEndData.level_name = GIOFHACJEGA.PNGPLGHKFDI;
			jsonLevelEndData.level_max = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1;
			jsonLevelEndData.number_of_ego_shown = GIOFHACJEGA.KFHIMNCFLFD;
			jsonLevelEndData.result = 0;
			jsonLevelEndData.user_score = ScoreManager.DJADMBLKBKJ;
			jsonLevelEndData.moves_given = moves_given;
			jsonLevelEndData.moves_made = GIOFHACJEGA.EPLKIIOCNPE;
			jsonLevelEndData.duration = (int)((GIOFHACJEGA.NAFLKPJGHHD != 0f) ? (Time.realtimeSinceStartup - GIOFHACJEGA.NAFLKPJGHHD) : 0f);
			jsonLevelEndData.min_fps = GIOFHACJEGA.GIMBEKBFKMJ.FPSMeter.MinimumFps().ToString();
			jsonLevelEndData.max_fps = GIOFHACJEGA.GIMBEKBFKMJ.FPSMeter.MaximumFps().ToString();
			jsonLevelEndData.avg_fps = GIOFHACJEGA.GIMBEKBFKMJ.FPSMeter.AverageFps().ToString();
			jsonLevelEndData.under_50_fps = GIOFHACJEGA.GIMBEKBFKMJ.FPSMeter.SpikeCount();
			jsonLevelEndData.data = jsonLevelEndInventory2;
			JsonLevelEndData jsonLevelEndData2 = jsonLevelEndData;
			jsonLevelEndData2.LLGLAHKBJJG();
			AFJPGLHKOID.CIBKGNFLBDE(jsonLevelEndData2);
		}

		public override bool CanCloseOnBlackPanelTouch()
		{
			return false;
		}
	}
}
