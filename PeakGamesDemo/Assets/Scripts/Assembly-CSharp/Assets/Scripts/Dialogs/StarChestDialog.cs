using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Tutorials;
using Assets.Scripts.MapScene;
using NewMapScene;
using UnityEngine;

namespace Assets.Scripts.Dialogs
{
	public class StarChestDialog : ToonChestDialog
	{
		private int BNIILDAPAAC;

		public override void UpdateAnimationIds()
		{
			JFKGAJEFMNP = new string[5] { "StarChest_idle_mobile", "StarChest_idle_mobile2", "StarChest_idle_mobile3", "StarChest_idle_mobile4", "StarChest_idle_mobile5" };
			AKNGCJLOOCA = "StarChest_open_last";
			KEFDLMDHKBF = "StarChest_open";
			ICPHLOGLEDE = "StarChest_open2";
			FKCKMLNPALG = "StarChest_open_idle";
			CKLPLHKILDJ = "SpineAnimations/StarChest/open_chest_SkeletonData";
			MHHELNHGHGM = "SpineAnimations/StarChest/open_chest";
			CENGNKJGOGP = "StarChest_fall";
		}

		public override void PrepareRewards()
		{
			MBODHMOEJEO = NDGOJGLPIJF.GABGKBAKHDP.DPDDOCIJHEG();
		}

		public override void ExecuteOpenChest(Dictionary<NAAHKHPBAPA, int> GKNKMDIPAIK)
		{
			if (!NDGOJGLPIJF.GABGKBAKHDP.AEFOGGAOFEE())
			{
				GEBAAFFGKJG.GABGKBAKHDP.MDCKDPBIIEN(NAAHKHPBAPA.Stars, 0);
			}
			else
			{
				int num = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Stars);
				int nNIDKMJGAJO = (num - NDGOJGLPIJF.DGIKLPPBGHJ) % NDGOJGLPIJF.DGIKLPPBGHJ;
				GEBAAFFGKJG.GABGKBAKHDP.MDCKDPBIIEN(NAAHKHPBAPA.Stars, nNIDKMJGAJO, true);
			}
			foreach (KeyValuePair<NAAHKHPBAPA, int> item in MBODHMOEJEO)
			{
				NAAHKHPBAPA key = item.Key;
				int value = item.Value;
				switch (key)
				{
				case NAAHKHPBAPA.Life:
					BNIILDAPAAC = value;
					CAGBGIHKHEJ.GABGKBAKHDP.OJHLFGFJFBH(value);
					break;
				case NAAHKHPBAPA.Coins:
				{
					DIDFHGBGKFJ = value;
					int aCFDIDGFPKJ = GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(key, value);
					GEBAAFFGKJG.GABGKBAKHDP.IBFMAELGBGP(aCFDIDGFPKJ);
					break;
				}
				default:
					GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(key, value);
					break;
				}
			}
			AFJPGLHKOID.JIINLAEELCB(MBODHMOEJEO);
			MapTutorial.CompleteStarChestOpenTutorial();
			if (OnChestClaimed != null)
			{
				OnChestClaimed();
			}
		}

		public override void OnDialogClosed()
		{
			base.OnDialogClosed();
			if (BNIILDAPAAC > 0 && MapManager.Instance != null)
			{
				MapManager.Instance.CurrentSocialHelper.CurrentInbox.UpdateScrollContent();
			}
		}

		protected override void POIKGNFHGHM()
		{
			MapUIAnimationController instance = MapUIAnimationController.Instance;
			if (!(instance == null))
			{
				Vector3 coinAnimationStartPosition = NewMapPage.CoinAnimationStartPosition;
				Vector3 kKAHENNAJJD = coinAnimationStartPosition;
				if (DIDFHGBGKFJ > 0 && BNIILDAPAAC > 0)
				{
					coinAnimationStartPosition.x += 1.5f;
					kKAHENNAJJD.x -= 1.5f;
				}
				if (DIDFHGBGKFJ > 0)
				{
					instance.StartCoinCollectAnimation(DIDFHGBGKFJ, Mathf.Min(DIDFHGBGKFJ / 2, 15), coinAnimationStartPosition);
				}
				if (BNIILDAPAAC > 0)
				{
					instance.StartLifeCollectAnimation(BNIILDAPAAC, BNIILDAPAAC, kKAHENNAJJD, DIDFHGBGKFJ == 0);
				}
			}
		}
	}
}
