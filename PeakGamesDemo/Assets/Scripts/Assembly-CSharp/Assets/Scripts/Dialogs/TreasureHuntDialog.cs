using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.Utils;
using DG.Tweening;
using NewMapScene;
using UnityEngine;

namespace Assets.Scripts.Dialogs
{
	public class TreasureHuntDialog : ToonChestDialog
	{
		private const float MHHINEDBCLB = 1.85f;

		private Action JCOKJJGCPHI;

		private bool GNMOOPNIPNG;

		private bool EKCINKDJPDI;

		[CompilerGenerated]
		private static TweenCallback EBCOMJBLIPP;

		[CompilerGenerated]
		private static TweenCallback DNBOPLHGMHA;

		public override void UpdateAnimationIds()
		{
			JFKGAJEFMNP = new string[5] { "idle_mobile", "idle_mobile2", "idle_mobile3", "idle_mobile4", "idle_mobile5" };
			AKNGCJLOOCA = "open_last";
			KEFDLMDHKBF = "open";
			ICPHLOGLEDE = "open2";
			FKCKMLNPALG = "open_idle";
			CKLPLHKILDJ = "SpineAnimations/TreasureHuntChest/open_chest_SkeletonData";
			MHHELNHGHGM = "SpineAnimations/TreasureHuntChest/open_chest";
			CENGNKJGOGP = "fall1";
		}

		public override void PrepareRewards()
		{
			MBODHMOEJEO = NDGOJGLPIJF.GABGKBAKHDP.LLILLCFDGEB();
		}

		protected override void EENDAPOEEFK(int EHJNMODJEAN, bool KMJFJLCCKDF, float BBDDGAOPJBG = 0f)
		{
			base.EENDAPOEEFK(EHJNMODJEAN, true, (EHJNMODJEAN != 0) ? BBDDGAOPJBG : 1.85f);
		}

		public override void ExecuteOpenChest(Dictionary<NAAHKHPBAPA, int> GKNKMDIPAIK)
		{
			foreach (KeyValuePair<NAAHKHPBAPA, int> item in MBODHMOEJEO)
			{
				NAAHKHPBAPA key = item.Key;
				int value = item.Value;
				switch (key)
				{
				case NAAHKHPBAPA.Coins:
				{
					DIDFHGBGKFJ = value;
					int aCFDIDGFPKJ = GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(key, value, false);
					GEBAAFFGKJG.GABGKBAKHDP.IBFMAELGBGP(aCFDIDGFPKJ);
					break;
				}
				case NAAHKHPBAPA.Life:
					CAGBGIHKHEJ.GABGKBAKHDP.IELIMAJFDKF(value);
					break;
				default:
					GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(key, value, false);
					break;
				}
			}
			CFNKECEHDIC cFNKECEHDIC = DGOMNDMPMBG.GABGKBAKHDP.OEPCIADENMH;
			if (cFNKECEHDIC != null)
			{
				cFNKECEHDIC.LCEPBBLJGCG(MBODHMOEJEO);
			}
			if (OnChestClaimed != null)
			{
				OnChestClaimed();
			}
		}

		public override void OpenChest()
		{
			AudioManager.Play(KOOGPFAPGGD.TreasureChestKeyReveal);
			GNMOOPNIPNG = true;
			DOTween.Sequence().InsertCallback(0.65f, delegate
			{
				AudioManager.Play(KOOGPFAPGGD.TreasureChestKeyFly);
			}).InsertCallback(1.25f, delegate
			{
				AudioManager.Play(KOOGPFAPGGD.TreasureChestKeyUnlock);
			})
				.InsertCallback(1.85f, delegate
				{
					GNMOOPNIPNG = false;
				});
			base.OpenChest();
		}

		public override void SkipAnimation()
		{
			if (!GNMOOPNIPNG)
			{
				base.SkipAnimation();
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

		[CompilerGenerated]
		private static void PILLAFCFBGP()
		{
			AudioManager.Play(KOOGPFAPGGD.TreasureChestKeyFly);
		}

		[CompilerGenerated]
		private static void KFFAFLCLEOD()
		{
			AudioManager.Play(KOOGPFAPGGD.TreasureChestKeyUnlock);
		}

		[CompilerGenerated]
		private void EGJPBEOIDGD()
		{
			GNMOOPNIPNG = false;
		}
	}
}
