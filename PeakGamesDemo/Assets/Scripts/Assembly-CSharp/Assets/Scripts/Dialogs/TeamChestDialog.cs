using System;
using System.Collections.Generic;
using Assets.Scripts.CasualTools.Dialogs;
using NewMapScene;
using UnityEngine;

namespace Assets.Scripts.Dialogs
{
	public class TeamChestDialog : ToonChestDialog
	{
		private Action JCOKJJGCPHI;

		private bool EKCINKDJPDI;

		public override void UpdateAnimationIds()
		{
			JFKGAJEFMNP = new string[5] { "idle_mobile", "idle_mobile2", "idle_mobile3", "idle_mobile4", "idle_mobile5" };
			AKNGCJLOOCA = "open_last";
			KEFDLMDHKBF = "open";
			ICPHLOGLEDE = "open2";
			FKCKMLNPALG = "open_idle";
			CKLPLHKILDJ = "SpineAnimations/TeamChest/open_chest_SkeletonData";
			MHHELNHGHGM = "SpineAnimations/TeamChest/open_chest";
			CENGNKJGOGP = "fall";
		}

		public override void PrepareRewards()
		{
			MBODHMOEJEO = NDGOJGLPIJF.GABGKBAKHDP.PIMFKHOCLPO();
		}

		protected override void EENDAPOEEFK(int EHJNMODJEAN, bool KMJFJLCCKDF, float BBDDGAOPJBG = 0f)
		{
			base.EENDAPOEEFK(EHJNMODJEAN, true, BBDDGAOPJBG);
		}

		public override void ExecuteOpenChest(Dictionary<NAAHKHPBAPA, int> GKNKMDIPAIK)
		{
			foreach (KeyValuePair<NAAHKHPBAPA, int> item in MBODHMOEJEO)
			{
				NAAHKHPBAPA key = item.Key;
				int value = item.Value;
				if (key == NAAHKHPBAPA.Coins)
				{
					DIDFHGBGKFJ = value;
					int aCFDIDGFPKJ = GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(key, value, false);
					GEBAAFFGKJG.GABGKBAKHDP.IBFMAELGBGP(aCFDIDGFPKJ);
				}
				else
				{
					GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(key, value, false);
				}
			}
			AAPMDEEMEMM aAPMDEEMEMM = DGOMNDMPMBG.GABGKBAKHDP.BHGCBNAMEFK;
			if (aAPMDEEMEMM != null)
			{
				aAPMDEEMEMM.LCEPBBLJGCG(MBODHMOEJEO);
			}
			if (OnChestClaimed != null)
			{
				OnChestClaimed();
			}
		}

		public void PrepareDialog(Action IMHLFAHONPP, bool OKAGICINMBN)
		{
			JCOKJJGCPHI = IMHLFAHONPP;
			EKCINKDJPDI = OKAGICINMBN;
		}

		protected override void POIKGNFHGHM()
		{
			MapUIAnimationController instance = MapUIAnimationController.Instance;
			if (DIDFHGBGKFJ <= 0 || instance == null)
			{
				if (JCOKJJGCPHI != null)
				{
					JCOKJJGCPHI();
				}
				return;
			}
			if (EKCINKDJPDI)
			{
				SpriteButtonListener.Instance.EnableClicks = false;
			}
			int eNMLICFLHAO = Mathf.Min(DIDFHGBGKFJ / 2, 15);
			if (JCOKJJGCPHI != null)
			{
				instance.StartCoinCollectAnimation(DIDFHGBGKFJ, JCOKJJGCPHI, eNMLICFLHAO, NewMapPage.CoinAnimationStartPosition);
			}
			else
			{
				instance.StartCoinCollectAnimation(DIDFHGBGKFJ, eNMLICFLHAO, NewMapPage.CoinAnimationStartPosition);
			}
		}
	}
}
