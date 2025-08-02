using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Touches;
using Assets.Scripts.GamePlayScene.UI;
using Assets.Scripts.Utils;
using DG.Tweening;
using Dialogs.BuyCoins;
using TMPro;
using UnityEngine;
using Utils;

namespace Assets.Scripts.Dialogs
{
	public class EgoDialog : SimpleDialog
	{
		public static List<NOALGNJECAD> EGOItems;

		public TextMeshPro UserCoins;

		public TextMeshPro CostText;

		public Transform JapaneseSunContainer;

		public SpriteRenderer[] CrownStages;

		public Transform RemoveFromDialog;

		public Transform CrownRushTransform;

		public Transform CrownSpeech;

		public TextMeshPro CrownMessage;

		public TextMeshPro MoveCountText;

		public TextMeshPro InfoText;

		private KFCEILFGADG LPONNGEPDON;

		private bool KHBHNJMOPLO;

		private bool JGAPCKLPDEO;

		private IBGBAKAEEKI FDPAHFHJCAC;

		private bool PIMFBGOPNEN;

		private string CHDHALMJOJH;

		private int JOEIODEKOCC;

		private bool HLJHFEOGKBJ;

		private Sequence ALIJCNPGNLH;

		[CompilerGenerated]
		private static TweenCallback EBCOMJBLIPP;

		public void SetLevel(KFCEILFGADG GIOFHACJEGA, int EHJNMODJEAN)
		{
			KHBHNJMOPLO = false;
			JGAPCKLPDEO = false;
			PIMFBGOPNEN = false;
			JOEIODEKOCC = Math.Min(EHJNMODJEAN, 5);
			FDPAHFHJCAC = BOKGFGFPOHD.MFINHHGLMNF[JOEIODEKOCC - 1];
			UserCoins.FCJBBPHFNPJ = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins).CMACDGCBKLO();
			CostText.FCJBBPHFNPJ = FDPAHFHJCAC.FDNCJEHPFFJ.ToString();
			LPONNGEPDON = GIOFHACJEGA;
			CHDHALMJOJH = "EGO-" + JOEIODEKOCC;
			KJGNMJDLFPM();
		}

		private void KJGNMJDLFPM()
		{
			int iNGPPJECAMI = KFCEILFGADG.INGPPJECAMI;
			MoveCountText.FCJBBPHFNPJ = string.Format("+{0}", iNGPPJECAMI);
			InfoText.FCJBBPHFNPJ = InfoText.FCJBBPHFNPJ.Replace(">5<", string.Format(">{0}<", iNGPPJECAMI));
		}

		public override void OnDialogClosed()
		{
			if (JGAPCKLPDEO)
			{
				int eJICKCGPFAH = FDPAHFHJCAC.FDNCJEHPFFJ - GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins);
				HLJHIJOGIBN.LKHOELJMLID = HLJHIJOGIBN.DAHOEMOBBKF(JOEIODEKOCC);
				GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.BuyCoinsBundleDialog, false);
				BundleShopDialog component = gameObject.GetComponent<BundleShopDialog>();
				component.DoNotDisplayUnder(eJICKCGPFAH);
				component.AfterCloseDo(delegate(NAAHKHPBAPA NBFBPNNEKMN, bool GKHLKDONJEF)
				{
					try
					{
						int jFLJEAAONLI = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins);
						if (NBFBPNNEKMN != 0 && GEBAAFFGKJG.GABGKBAKHDP.DCAKPPKFOEP(NAAHKHPBAPA.Coins, FDPAHFHJCAC.FDNCJEHPFFJ))
						{
							if (LPONNGEPDON != null)
							{
								OPJPCELEBAL(JOEIODEKOCC);
								AudioManager.PlayStinger(KOOGPFAPGGD.StingerEndGameOfferAccepted, true);
								LPONNGEPDON.INPDCFLCIIE(0.2f);
							}
							TapListener.Instance.DecreaseBlockRequests();
							AFJPGLHKOID.GEEIAHDELAO(CHDHALMJOJH, jFLJEAAONLI, FDPAHFHJCAC.FDNCJEHPFFJ, true);
						}
						else
						{
							GameObject gameObject3 = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.EgoDialogs[JOEIODEKOCC - 1], false);
							EgoDialog component3 = gameObject3.GetComponent<EgoDialog>();
							if (component3 != null)
							{
								component3.SetLevel(LPONNGEPDON, JOEIODEKOCC);
							}
						}
						if (SettingsPanel.Instance != null && SettingsPanel.Instance.CurrentBoosterManager != null)
						{
							SettingsPanel.Instance.CurrentBoosterManager.UpdateBoosterCounts();
						}
					}
					catch (Exception ex)
					{
						GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.EgoDialog, "Error after closing purchase dialog. Error:{0} Stack:{1", ex.Message, ex.StackTrace);
					}
				});
			}
			else if (!KHBHNJMOPLO)
			{
				GameObject gameObject2 = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK((!LevelBuilder.LastLevel.EKGHEGKILLC) ? DialogLibrary.GABGKBAKHDP.LostDialog : DialogLibrary.GABGKBAKHDP.CLLostDialog, true);
				LostDialog component2 = gameObject2.GetComponent<LostDialog>();
				component2.SetContent(LPONNGEPDON);
				TapListener.Instance.DecreaseBlockRequests();
			}
			else if (PIMFBGOPNEN)
			{
				OPJPCELEBAL(JOEIODEKOCC);
				AudioManager.PlayStinger(KOOGPFAPGGD.StingerEndGameOfferAccepted, true);
				LPONNGEPDON.INPDCFLCIIE(0.2f);
			}
		}

		public void OnBuyClicked()
		{
			int jFLJEAAONLI = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins);
			bool eEKJMDHEJCK = false;
			if (GEBAAFFGKJG.GABGKBAKHDP.DCAKPPKFOEP(NAAHKHPBAPA.Coins, FDPAHFHJCAC.FDNCJEHPFFJ))
			{
				eEKJMDHEJCK = true;
				KHBHNJMOPLO = true;
				if (LPONNGEPDON != null)
				{
					PIMFBGOPNEN = true;
				}
				TapListener.Instance.DecreaseBlockRequests();
			}
			else
			{
				JGAPCKLPDEO = true;
			}
			AFJPGLHKOID.GEEIAHDELAO(CHDHALMJOJH, jFLJEAAONLI, FDPAHFHJCAC.FDNCJEHPFFJ, eEKJMDHEJCK);
			HLJHFEOGKBJ = true;
			Close();
		}

		private void OPJPCELEBAL(int NCOHJPBDDKB)
		{
			EGOItems = new List<NOALGNJECAD>();
			switch (NCOHJPBDDKB)
			{
			case 2:
				EGOItems.Add(NOALGNJECAD.Rocket);
				break;
			case 3:
				EGOItems.Add(NOALGNJECAD.Rocket);
				EGOItems.Add(NOALGNJECAD.Bomb);
				break;
			case 4:
				EGOItems.Add(NOALGNJECAD.Rocket);
				EGOItems.Add(NOALGNJECAD.Bomb);
				EGOItems.Add(NOALGNJECAD.DiscoBall);
				break;
			case 5:
				EGOItems.Add(NOALGNJECAD.Rocket);
				EGOItems.Add(NOALGNJECAD.Bomb);
				EGOItems.Add(NOALGNJECAD.DiscoBall);
				EGOItems.Add(NOALGNJECAD.Rocket);
				EGOItems.Add(NOALGNJECAD.Bomb);
				EGOItems.Add(NOALGNJECAD.DiscoBall);
				break;
			}
		}

		public override void DialogCreated()
		{
			PAFEEFLGDCN();
			JBLHLNCOLHD();
			base.gameObject.transform.position = new Vector3(ONCMBJKLKIL.JDBOMLADPFF.x - ONCMBJKLKIL.EMFKAPJMDCC, 0f, -2f);
			JapaneseSunContainer.DORotate(new Vector3(0f, 0f, -360f), 24f, RotateMode.LocalAxisAdd).SetLoops(1000, LoopType.Incremental).SetEase(Ease.Linear);
		}

		public override void PlayDialogInAnimation()
		{
			Sequence sequence = DOTween.Sequence();
			Tweener tweener = base.transform.DOMoveX(0f, 1.5f);
			tweener.SetEase(Ease.OutBack);
			tweener.easeOvershootOrAmplitude = 0.8f;
			sequence.Append(tweener);
			sequence.InsertCallback(0.5f, base.JNHCICHFNHL);
			sequence.SetEase(Ease.Linear);
		}

		public override Sequence PlayDialogOutAnimation()
		{
			JBLHLNCOLHD();
			Sequence sequence = DOTween.Sequence();
			Tweener tweener = base.transform.DOMoveX(ONCMBJKLKIL.ABDNNJLJKJD.x + ONCMBJKLKIL.EMFKAPJMDCC, 0.6f);
			tweener.SetEase(Ease.InBack);
			tweener.easeOvershootOrAmplitude = 0.8f;
			sequence.Append(tweener);
			return sequence;
		}

		public override void Close()
		{
			if (ALIJCNPGNLH != null)
			{
				ALIJCNPGNLH.timeScale = 3f;
			}
			if (HLJHFEOGKBJ)
			{
				base.Close();
				return;
			}
			DIGGBGADIGJ dIGGBGADIGJ = DIGGBGADIGJ.GABGKBAKHDP;
			if (dIGGBGADIGJ.BGKIIAJNHLL <= 0)
			{
				base.Close();
				return;
			}
			HLJHFEOGKBJ = true;
			LPBJMEALEPK(dIGGBGADIGJ.BGKIIAJNHLL);
		}

		private void LPBJMEALEPK(int EGEPICBFDAE)
		{
			CrownMessage.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("CrownRushGiveUp");
			CrownRushTransform.gameObject.SetActive(true);
			PrepareCrown(EGEPICBFDAE);
			GGBNCOJCJCA();
		}

		public void PrepareCrown(int GEMCBIEANPE)
		{
			for (int i = 0; i < GEMCBIEANPE - 1; i++)
			{
				CrownStages[i].enabled = true;
			}
		}

		private void GGBNCOJCJCA()
		{
			ALIJCNPGNLH = DOTween.Sequence();
			Tweener tweener = RemoveFromDialog.DOMoveX(ONCMBJKLKIL.ABDNNJLJKJD.x + ONCMBJKLKIL.EMFKAPJMDCC, 0.4f);
			tweener.SetEase(Ease.InBack);
			tweener.easeOvershootOrAmplitude = 0.8f;
			ALIJCNPGNLH.Append(tweener);
			Tweener tweener2 = CrownRushTransform.DOMoveX(0f, 0.6f);
			tweener2.SetEase(Ease.OutBack);
			tweener2.easeOvershootOrAmplitude = 0.8f;
			ALIJCNPGNLH.Append(tweener2);
			ALIJCNPGNLH.Append(CrownSpeech.DOScale(Vector3.one, 0.3f).SetEase(Ease.OutBack));
			ALIJCNPGNLH.InsertCallback(0.5f, delegate
			{
				AudioManager.Play(KOOGPFAPGGD.CrownEgoDialog);
			});
		}

		private void PAFEEFLGDCN()
		{
			CrownRushTransform.gameObject.SetActive(false);
			CrownRushTransform.localPosition = Vector3.right * 10f;
			CrownSpeech.localScale = Vector3.zero;
		}

		public override bool CanCloseOnBlackPanelTouch()
		{
			return false;
		}

		[CompilerGenerated]
		private void OAGBODOPKFK(NAAHKHPBAPA NBFBPNNEKMN, bool GKHLKDONJEF)
		{
			try
			{
				int jFLJEAAONLI = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins);
				if (NBFBPNNEKMN != 0 && GEBAAFFGKJG.GABGKBAKHDP.DCAKPPKFOEP(NAAHKHPBAPA.Coins, FDPAHFHJCAC.FDNCJEHPFFJ))
				{
					if (LPONNGEPDON != null)
					{
						OPJPCELEBAL(JOEIODEKOCC);
						AudioManager.PlayStinger(KOOGPFAPGGD.StingerEndGameOfferAccepted, true);
						LPONNGEPDON.INPDCFLCIIE(0.2f);
					}
					TapListener.Instance.DecreaseBlockRequests();
					AFJPGLHKOID.GEEIAHDELAO(CHDHALMJOJH, jFLJEAAONLI, FDPAHFHJCAC.FDNCJEHPFFJ, true);
				}
				else
				{
					GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.EgoDialogs[JOEIODEKOCC - 1], false);
					EgoDialog component = gameObject.GetComponent<EgoDialog>();
					if (component != null)
					{
						component.SetLevel(LPONNGEPDON, JOEIODEKOCC);
					}
				}
				if (SettingsPanel.Instance != null && SettingsPanel.Instance.CurrentBoosterManager != null)
				{
					SettingsPanel.Instance.CurrentBoosterManager.UpdateBoosterCounts();
				}
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.EgoDialog, "Error after closing purchase dialog. Error:{0} Stack:{1", ex.Message, ex.StackTrace);
			}
		}

		[CompilerGenerated]
		private static void PNJFDDNMJOE()
		{
			AudioManager.Play(KOOGPFAPGGD.CrownEgoDialog);
		}
	}
}
