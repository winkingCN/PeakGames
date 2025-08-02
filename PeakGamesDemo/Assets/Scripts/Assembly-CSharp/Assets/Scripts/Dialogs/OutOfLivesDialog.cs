using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.MapScene;
using Assets.Scripts.SceneTransitions;
using Assets.Scripts.Utils;
using Dialogs.BuyCoins;
using TMPro;
using UnityEngine;
using Utils;

namespace Assets.Scripts.Dialogs
{
	public class OutOfLivesDialog : SimpleDialog
	{
		public static string RefillStatus;

		public TextMeshPro LifeCountText;

		public TextMeshPro TimeLeftText;

		public TextMeshPro TitleText;

		public Action ActionToPerformOnClose;

		public EventBasedSpriteButton RefillButton;

		private bool JGAPCKLPDEO;

		private bool PIGCJDKPMFL;

		private bool POAJDPGMINP;

		public void Refill()
		{
			bool eEKJMDHEJCK = false;
			int num = BOKGFGFPOHD.LJLBPNDBOAI.FDNCJEHPFFJ;
			int jFLJEAAONLI = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins);
			if (GEBAAFFGKJG.GABGKBAKHDP.DCAKPPKFOEP(NAAHKHPBAPA.Coins, num))
			{
				eEKJMDHEJCK = true;
				AudioManager.Play(KOOGPFAPGGD.UiLifeFill);
				PJPPADHKGHN.GABGKBAKHDP.MMECFKDOBDC();
				Close();
			}
			else
			{
				JGAPCKLPDEO = true;
				Close();
			}
			AFJPGLHKOID.GEEIAHDELAO("Life", jFLJEAAONLI, num, eEKJMDHEJCK, RefillStatus);
		}

		public override void DialogCreated()
		{
			base.DialogCreated();
			if (RefillStatus == "play" || RefillStatus == "tryagain")
			{
				RefillButton.CanBeClicked = false;
				StartCoroutine(GFFCHKEAKNF());
			}
		}

		private void KKBJIJBJCED(NAAHKHPBAPA NEMEKIOEOLC)
		{
			if (NEMEKIOEOLC == NAAHKHPBAPA.Coins)
			{
				int num = BOKGFGFPOHD.LJLBPNDBOAI.FDNCJEHPFFJ;
				int jFLJEAAONLI = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins);
				if (GEBAAFFGKJG.GABGKBAKHDP.DCAKPPKFOEP(NAAHKHPBAPA.Coins, num))
				{
					AudioManager.Play(KOOGPFAPGGD.UiLifeFill);
					PJPPADHKGHN.GABGKBAKHDP.MMECFKDOBDC();
					AFJPGLHKOID.GEEIAHDELAO("Life", jFLJEAAONLI, num, true, RefillStatus);
				}
			}
		}

		public override void OnDialogClosed()
		{
			base.OnDialogClosed();
			if (JGAPCKLPDEO)
			{
				int eJICKCGPFAH = BOKGFGFPOHD.LJLBPNDBOAI.FDNCJEHPFFJ - GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins);
				HLJHIJOGIBN.LKHOELJMLID = "Life";
				GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.BuyCoinsBundleDialog, false);
				BundleShopDialog component = gameObject.GetComponent<BundleShopDialog>();
				component.DoNotDisplayUnder(eJICKCGPFAH);
				component.AfterCloseDo(delegate(NAAHKHPBAPA NBFBPNNEKMN, bool GKHLKDONJEF)
				{
					if (NBFBPNNEKMN == NAAHKHPBAPA.None)
					{
						CreateAndShowOutOfLivesDialog(ActionToPerformOnClose);
					}
					else
					{
						KKBJIJBJCED(NBFBPNNEKMN);
						if (ActionToPerformOnClose != null)
						{
							ActionToPerformOnClose();
						}
					}
				});
			}
			else if (ActionToPerformOnClose != null)
			{
				ActionToPerformOnClose();
			}
		}

		public override void PlayDialogInAnimation()
		{
			base.PlayDialogInAnimation();
			if (!base.gameObject.activeSelf)
			{
				base.gameObject.SetActive(true);
			}
		}

		public void Start()
		{
			StartCoroutine(IEJIGILOFIE());
		}

		public void AskFriends()
		{
			if (!PIGCJDKPMFL)
			{
				PIGCJDKPMFL = true;
				FHAAAFAAMDO.GABGKBAKHDP.GLHIMFPOKHD();
				Close();
				if (MapManager.Instance != null)
				{
					MapManager.Instance.CurrentContainerManager.SlideToPosition(-1);
				}
			}
		}

		private IEnumerator GFFCHKEAKNF()
		{
			yield return new WaitForSeconds(0.8f);
			RefillButton.CanBeClicked = true;
		}

		private IEnumerator IEJIGILOFIE()
		{
			while (true)
			{
				MOLCIIAPCMN mOLCIIAPCMN = PJPPADHKGHN.GABGKBAKHDP.PMBGCACJIHD();
				int num = mOLCIIAPCMN.DLDHNNCGIPI;
				if (num < 0)
				{
					num = 0;
				}
				if (num > 0)
				{
					TitleText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("MoreLives");
				}
				if (num == 5)
				{
					break;
				}
				LifeCountText.FCJBBPHFNPJ = num.ToString();
				TimeLeftText.FCJBBPHFNPJ = mOLCIIAPCMN.APLNHKHHMEL.LNJPHFHNGCO("<size=90%>:</size>");
				yield return MCJHHDACJBG.KNLADMIBAAD;
			}
			LifeCountText.FCJBBPHFNPJ = 5.ToString();
			TimeLeftText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Full");
		}

		public static void CreateAndShowOutOfLivesDialog(Action NIAJFHLLMPB)
		{
			OutOfLivesDialog outOfLivesDialog = ((CaravanSceneManager.CurrentScene != GKBHIKONCKJ.GamePlay) ? FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.NoLivesLeftMapDialog, false).GetComponent<OutOfLivesDialog>() : FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.NoLivesLeftGamePlayDialog, false).GetComponent<OutOfLivesDialog>());
			outOfLivesDialog.ActionToPerformOnClose = NIAJFHLLMPB;
		}

		[CompilerGenerated]
		private void OAGBODOPKFK(NAAHKHPBAPA NBFBPNNEKMN, bool GKHLKDONJEF)
		{
			if (NBFBPNNEKMN == NAAHKHPBAPA.None)
			{
				CreateAndShowOutOfLivesDialog(ActionToPerformOnClose);
				return;
			}
			KKBJIJBJCED(NBFBPNNEKMN);
			if (ActionToPerformOnClose != null)
			{
				ActionToPerformOnClose();
			}
		}
	}
}
