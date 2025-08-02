using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Assets.Scripts.Dialogs;
using Assets.Scripts.SceneTransitions;
using DG.Tweening;
using UnityEngine;
using Utils;

namespace Dialogs.BuyCoins
{
	public class BundleShopDialog : SimpleDialog
	{
		[CompilerGenerated]
		private sealed class MMCNBEKLLMA
		{
			internal string BIHOIMKHIFC;

			internal bool GDCABBLLPKM;

			internal int DIDHNNMKJFE;

			internal BundleShopDialog PDAPIGLEPGC;

			internal bool AGFNGEFDHLA(PMCGNIAAMND HPHBDNBJPHB)
			{
				return HPHBDNBJPHB.FDIOHLPIGAI.Equals(BIHOIMKHIFC);
			}

			internal bool KDACLOKGNAM(KHMIKAEKHIG FMFABAKPMLB)
			{
				return FMFABAKPMLB.INMJKIDMBKB.Equals(BIHOIMKHIFC);
			}

			internal void DBLIJBPNCAN()
			{
				if (GDCABBLLPKM)
				{
					PDAPIGLEPGC.LEAIBDDEDEK(DIDHNNMKJFE);
				}
				else
				{
					PDAPIGLEPGC.ShowDialog(PDAPIGLEPGC.PurchaseSuccesDialog);
				}
			}
		}

		public PurchaseFailedDialog PurchaseFailDialog;

		public SimpleDialog PurchaseSuccesDialog;

		public SimpleDialog NoConnectionDialog;

		public BundleContent CurrentBundleContent;

		public SpriteRenderer BackgroundDialogSpriteRenderer;

		public Transform Top;

		private bool CDHEJHFDGBM;

		private bool HHLOJNJNOBK;

		private Action<NAAHKHPBAPA, bool> GAOABGCOGIL;

		private SimpleDialog AELJLPJBIAH;

		private int LIDIKINBHMB;

		public override void PlayDialogInAnimation()
		{
			base.gameObject.SetActive(true);
			Sequence sequence = DOTween.Sequence();
			sequence.AppendCallback(base.JNHCICHFNHL);
			sequence.AppendInterval(0.2f);
			sequence.SetEase(Ease.Linear);
		}

		public override Sequence PlayDialogOutAnimation()
		{
			base.gameObject.SetActive(false);
			return DOTween.Sequence();
		}

		public void ShowDialog(SimpleDialog HDCNHMFEFLB)
		{
			if (AELJLPJBIAH != null)
			{
				CloseDialog();
			}
			if (!BackgroundDialogSpriteRenderer.enabled)
			{
				BackgroundDialogSpriteRenderer.enabled = true;
			}
			AELJLPJBIAH = HDCNHMFEFLB;
			AELJLPJBIAH.PlayDialogInAnimation();
		}

		public void CloseDialog()
		{
			if (!(AELJLPJBIAH == null))
			{
				BackgroundDialogSpriteRenderer.enabled = false;
				AELJLPJBIAH.PlayDialogOutAnimation();
				MGLPAOHEPGO();
				AELJLPJBIAH = null;
			}
		}

		public void CloseAll()
		{
			if (!(AELJLPJBIAH == null))
			{
				BackgroundDialogSpriteRenderer.enabled = false;
				AELJLPJBIAH.PlayDialogOutAnimation();
				Close();
				AELJLPJBIAH = null;
			}
		}

		public void ChangeSorting(GameObject HCEDAECPCIA, int JFMBGIMCBGE)
		{
			SpriteRenderer[] componentsInChildren = HCEDAECPCIA.transform.GetComponentsInChildren<SpriteRenderer>();
			foreach (SpriteRenderer spriteRenderer in componentsInChildren)
			{
				if (spriteRenderer != null)
				{
					spriteRenderer.sortingOrder += JFMBGIMCBGE;
				}
			}
			MeshRenderer[] componentsInChildren2 = HCEDAECPCIA.transform.GetComponentsInChildren<MeshRenderer>();
			foreach (MeshRenderer meshRenderer in componentsInChildren2)
			{
				if (meshRenderer != null)
				{
					meshRenderer.sortingOrder += JFMBGIMCBGE;
				}
			}
		}

		public override void DialogCreated()
		{
			DialogLibrary.GABGKBAKHDP.DarkenBackground();
			LIDIKINBHMB = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins);
			GGLGIBODELM();
		}

		public void Start()
		{
			BackgroundDialogSpriteRenderer.enabled = false;
			float x = base.transform.localScale.x;
			Vector3 localScale = new Vector3(ONCMBJKLKIL.EMFKAPJMDCC / x, ONCMBJKLKIL.FHAMOHDEGMK / x, 1f);
			BackgroundDialogSpriteRenderer.transform.localScale = localScale;
			float num = 1.88f;
			CameraSizer cameraSizer = null;
			float num2 = 0f;
			num += ONCMBJKLKIL.GNGIGAPBFCN.ECLBGPBLGMD * 2f;
			float num3 = num * 0.5f;
			float num4 = num3 * x;
			Top.position = new Vector3(0f, ONCMBJKLKIL.ECLBGPBLGMD.y - num4);
			bool flag = !GEBAAFFGKJG.GABGKBAKHDP.ACBHOCGJHHF(NJGLIIMEMBI.USER_TYPE_BUNDLE_PAID);
			CurrentBundleContent.transform.localPosition = new Vector3(0f, ((!flag) ? (-0.5f) : (-0.6f)) * x, -10f);
			CurrentBundleContent.ScrollController.ScrollArea.size = new Vector2(ONCMBJKLKIL.EMFKAPJMDCC / x, (ONCMBJKLKIL.FHAMOHDEGMK - num) / x);
			CurrentBundleContent.Init(BundleButtonClicked, CoinButtonClicked, delegate
			{
				CurrentBundleContent.ChangeSortingLayer(SortingLayer.NameToID("Dialogs"), "DialogSpriteButton");
				CurrentBundleContent.ShowInitialEntries();
			});
			ChangeSorting(NoConnectionDialog.gameObject, 300);
			ChangeSorting(PurchaseFailDialog.gameObject, 300);
			ChangeSorting(PurchaseSuccesDialog.gameObject, 300);
			FHAAAFAAMDO.ABPLPAEONPN(NoConnectionDialog);
			FHAAAFAAMDO.ABPLPAEONPN(PurchaseFailDialog);
			FHAAAFAAMDO.ABPLPAEONPN(PurchaseSuccesDialog);
			NoConnectionDialog.DialogCreated();
			PurchaseFailDialog.DialogCreated();
			PurchaseSuccesDialog.DialogCreated();
			NoConnectionDialog.ActivateDialog(false);
			PurchaseFailDialog.ActivateDialog(false);
			PurchaseSuccesDialog.ActivateDialog(false);
			CurrentBundleContent.Prepare();
		}

		private void OnDestroy()
		{
			HLJHIJOGIBN.LKHOELJMLID = "Store";
		}

		public void CoinButtonClicked(string NIODHMGCCHH)
		{
			OLHJPKIBMFF(NIODHMGCCHH);
		}

		public void BundleButtonClicked(string NIODHMGCCHH)
		{
			OLHJPKIBMFF(NIODHMGCCHH);
		}

		private void OLHJPKIBMFF(string NIODHMGCCHH)
		{
			JBLHLNCOLHD();
			CurrentBundleContent.DisableColliders();
			if (!JHOAHCHHBCH.CCAJIIFJPFF())
			{
				ShowDialog(NoConnectionDialog);
			}
			else if (!CDHEJHFDGBM)
			{
				CDHEJHFDGBM = true;
				LoadingScreenDisplayer.Instance.ShowLoading(KLKAGJKCKBE.Loading);
				NFDHFOAMOCD.PGDBPMNHEAN();
				ANGCNEFIIHE.GABGKBAKHDP.OLHJPKIBMFF(NIODHMGCCHH, BGIKMFLLODP);
			}
		}

		private void BGIKMFLLODP(int DIDHNNMKJFE, string BIHOIMKHIFC)
		{
			bool GDCABBLLPKM = false;
			if (DIDHNNMKJFE == 0)
			{
				PMCGNIAAMND pMCGNIAAMND = BOKGFGFPOHD.NIAJFDLMNJH.FirstOrDefault((PMCGNIAAMND HPHBDNBJPHB) => HPHBDNBJPHB.FDIOHLPIGAI.Equals(BIHOIMKHIFC));
				if (pMCGNIAAMND != null)
				{
					HHLOJNJNOBK = true;
					CurrentBundleContent.UpdateHighestBoughtPackageOrder();
					INHKCMOAPFM(pMCGNIAAMND);
				}
				else
				{
					KHMIKAEKHIG kHMIKAEKHIG = BOKGFGFPOHD.FNEABNFILKK.FirstOrDefault((KHMIKAEKHIG FMFABAKPMLB) => FMFABAKPMLB.INMJKIDMBKB.Equals(BIHOIMKHIFC));
					if (kHMIKAEKHIG.INMJKIDMBKB != null)
					{
						INHKCMOAPFM(kHMIKAEKHIG.LGCFDCILJFO);
					}
					else
					{
						GDCABBLLPKM = true;
						DIDHNNMKJFE = 3;
					}
				}
			}
			else
			{
				GDCABBLLPKM = true;
			}
			LoadingScreenDisplayer.Instance.StartFadeOut(delegate
			{
				if (GDCABBLLPKM)
				{
					LEAIBDDEDEK(DIDHNNMKJFE);
				}
				else
				{
					ShowDialog(PurchaseSuccesDialog);
				}
			});
		}

		private void LEAIBDDEDEK(int DIDHNNMKJFE)
		{
			CDHEJHFDGBM = false;
			ShowDialog(PurchaseFailDialog);
			PurchaseFailDialog.SetErrorText(DIDHNNMKJFE);
		}

		private void MGLPAOHEPGO()
		{
			JNHCICHFNHL();
			CurrentBundleContent.EnableColliders();
		}

		public void AfterCloseDo(Action<NAAHKHPBAPA, bool> DPLHHJKOBJO)
		{
			GAOABGCOGIL = DPLHHJKOBJO;
		}

		public override void OnDialogClosed()
		{
			NAAHKHPBAPA arg = (CDHEJHFDGBM ? NAAHKHPBAPA.Coins : NAAHKHPBAPA.None);
			if (GAOABGCOGIL != null)
			{
				GAOABGCOGIL(arg, HHLOJNJNOBK);
			}
		}

		private void INHKCMOAPFM(int AGKAAMJKIMN)
		{
			GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Coins, AGKAAMJKIMN, true, true);
			CDHEJHFDGBM = true;
		}

		private void INHKCMOAPFM(PMCGNIAAMND ECCBKJNBHMH)
		{
			GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Coins, ECCBKJNBHMH.CIOENCFNLKH, true, true);
			int aMKGEHCMHIA = ECCBKJNBHMH.AMKGEHCMHIA;
			List<NAAHKHPBAPA> list = ((ECCBKJNBHMH.DDILBILNNFN <= 0) ? PMCGNIAAMND.OHDNIPPLMJO : PMCGNIAAMND.KCEHEMOIGHB);
			for (int i = 0; i < list.Count; i++)
			{
				NAAHKHPBAPA nAAHKHPBAPA = list[i];
				if (nAAHKHPBAPA != NAAHKHPBAPA.UnlimitedLife)
				{
					GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(nAAHKHPBAPA, aMKGEHCMHIA, true, true);
				}
				else
				{
					PJPPADHKGHN.GABGKBAKHDP.ALIHKHMEPPG(ECCBKJNBHMH.DDILBILNNFN);
				}
			}
			CDHEJHFDGBM = true;
		}

		public void DoNotDisplayUnder(int EJICKCGPFAH)
		{
			CurrentBundleContent.DontDisplayUnder(EJICKCGPFAH);
		}

		private void GGLGIBODELM()
		{
			AFJPGLHKOID.FKKAMHFBIFI(LIDIKINBHMB, HLJHIJOGIBN.LKHOELJMLID);
		}

		public override bool CanCloseOnBlackPanelTouch()
		{
			return false;
		}

		[CompilerGenerated]
		private void NKKKOFOCGNJ()
		{
			CurrentBundleContent.ChangeSortingLayer(SortingLayer.NameToID("Dialogs"), "DialogSpriteButton");
			CurrentBundleContent.ShowInitialEntries();
		}
	}
}
