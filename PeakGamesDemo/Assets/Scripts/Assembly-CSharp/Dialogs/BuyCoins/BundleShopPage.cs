using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Assets.Scripts.Dialogs;
using Assets.Scripts.SceneTransitions;
using NewMapScene;
using UnityEngine;
using Utils;

namespace Dialogs.BuyCoins
{
	public class BundleShopPage : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class JJNHBNKFNGM
		{
			internal string MGKHGJGKMAP;

			internal bool AGFNGEFDHLA(PMCGNIAAMND FMFABAKPMLB)
			{
				return FMFABAKPMLB.FDIOHLPIGAI == MGKHGJGKMAP;
			}
		}

		[CompilerGenerated]
		private sealed class DGLHJPGBKOD
		{
			internal string BIHOIMKHIFC;

			internal int DIDHNNMKJFE;

			internal BundleShopPage PDAPIGLEPGC;

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
				DialogLibrary.GABGKBAKHDP.ShowDialogBackgroundFast();
				PurchaseFailedDialog component = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.PurchaseFailedDialog, false, false, false, null, false).GetComponent<PurchaseFailedDialog>();
				component.OnDialogClosedAction = PDAPIGLEPGC.CurrentBundleContent.EnableColliders;
				component.SetErrorText(DIDHNNMKJFE);
			}
		}

		public BundleContent CurrentBundleContent;

		private int CEMNJEFHGFJ;

		private int MNPADPHEKJF;

		public void Awake()
		{
			NMJJFHDGICI();
			BundleContent.Instance = CurrentBundleContent;
			CurrentBundleContent.Init(BundleButtonClicked, CoinButtonClicked);
		}

		private static void NMJJFHDGICI()
		{
			HJBLKNBHMFJ hJBLKNBHMFJ = HJBLKNBHMFJ.GABGKBAKHDP;
			GEBAAFFGKJG gEBAAFFGKJG = GEBAAFFGKJG.GABGKBAKHDP;
			string MGKHGJGKMAP = hJBLKNBHMFJ.LIANKDMAHFM("KeyHighestBoughtBundleNo");
			if (MGKHGJGKMAP != null)
			{
				int result = 0;
				int.TryParse(MGKHGJGKMAP, out result);
				if (result == BOKGFGFPOHD.NIAJFDLMNJH.Length)
				{
					gEBAAFFGKJG.LDHHPHHKNHL(NJGLIIMEMBI.USER_TYPE_HIGH_PAID, false);
				}
				return;
			}
			MGKHGJGKMAP = hJBLKNBHMFJ.LIANKDMAHFM("KeyHighestBoughtPackage");
			if (MGKHGJGKMAP == null)
			{
				int num = 0;
				if (gEBAAFFGKJG.ACBHOCGJHHF(NJGLIIMEMBI.USER_TYPE_BUNDLE_PAID))
				{
					num = 1;
				}
				if (gEBAAFFGKJG.ACBHOCGJHHF(NJGLIIMEMBI.USER_TYPE_HIGH_PAID))
				{
					num = BOKGFGFPOHD.NIAJFDLMNJH.Length;
				}
				hJBLKNBHMFJ.JGMDDMNGDJO("KeyHighestBoughtBundleNo", num.ToString());
				return;
			}
			hJBLKNBHMFJ.KFCIOFNMKDA("KeyHighestBoughtPackage");
			PMCGNIAAMND pMCGNIAAMND = BOKGFGFPOHD.NIAJFDLMNJH.FirstOrDefault((PMCGNIAAMND FMFABAKPMLB) => FMFABAKPMLB.FDIOHLPIGAI == MGKHGJGKMAP);
			int num2 = ((pMCGNIAAMND != null) ? pMCGNIAAMND.BHIJCAOHDCM : 0);
			hJBLKNBHMFJ.JGMDDMNGDJO("KeyHighestBoughtBundleNo", num2.ToString());
			if (num2 > 0)
			{
				gEBAAFFGKJG.LDHHPHHKNHL(NJGLIIMEMBI.USER_TYPE_BUNDLE_PAID, false);
			}
			if (num2 == BOKGFGFPOHD.NIAJFDLMNJH.Length)
			{
				gEBAAFFGKJG.LDHHPHHKNHL(NJGLIIMEMBI.USER_TYPE_HIGH_PAID, false);
			}
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
			if (!JHOAHCHHBCH.CCAJIIFJPFF())
			{
				FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.NoConnectionDialog, false);
				return;
			}
			CurrentBundleContent.DisableColliders();
			LoadingScreenDisplayer.Instance.ShowLoading(KLKAGJKCKBE.Loading);
			NFDHFOAMOCD.PGDBPMNHEAN();
			ANGCNEFIIHE.GABGKBAKHDP.OLHJPKIBMFF(NIODHMGCCHH, BGIKMFLLODP);
		}

		private void BGIKMFLLODP(int DIDHNNMKJFE, string BIHOIMKHIFC)
		{
			LoadingScreenDisplayer.Instance.StartFadeOut();
			CurrentBundleContent.EnableColliders();
			if (DIDHNNMKJFE == 0)
			{
				PMCGNIAAMND pMCGNIAAMND = BOKGFGFPOHD.NIAJFDLMNJH.FirstOrDefault((PMCGNIAAMND HPHBDNBJPHB) => HPHBDNBJPHB.FDIOHLPIGAI.Equals(BIHOIMKHIFC));
				if (pMCGNIAAMND != null)
				{
					AddToInventory(pMCGNIAAMND);
					CurrentBundleContent.UpdateHighestBoughtPackageOrder();
					CurrentBundleContent.MakePayerAndUpdateOffers();
					return;
				}
				KHMIKAEKHIG kHMIKAEKHIG = BOKGFGFPOHD.FNEABNFILKK.FirstOrDefault((KHMIKAEKHIG FMFABAKPMLB) => FMFABAKPMLB.INMJKIDMBKB.Equals(BIHOIMKHIFC));
				if (kHMIKAEKHIG.INMJKIDMBKB != null)
				{
					MNPADPHEKJF = kHMIKAEKHIG.FDHJCJEBGMJ;
					AddToInventory(kHMIKAEKHIG.LGCFDCILJFO);
					return;
				}
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.BuyCoinsDialog, "User has been charged however that package can not be found!");
				CurrentBundleContent.EnableColliders();
				DialogLibrary.GABGKBAKHDP.ShowDialogBackgroundFast();
				PurchaseFailedDialog component = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.PurchaseFailedDialog, false, false, false, null, false).GetComponent<PurchaseFailedDialog>();
				component.SetErrorText(DIDHNNMKJFE);
			}
			else
			{
				StartCoroutine(FGACHPMAHBD(delegate
				{
					DialogLibrary.GABGKBAKHDP.ShowDialogBackgroundFast();
					PurchaseFailedDialog component2 = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.PurchaseFailedDialog, false, false, false, null, false).GetComponent<PurchaseFailedDialog>();
					component2.OnDialogClosedAction = CurrentBundleContent.EnableColliders;
					component2.SetErrorText(DIDHNNMKJFE);
				}));
			}
		}

		private IEnumerator FGACHPMAHBD(Action IMHLFAHONPP)
		{
			while (LoadingScreenDisplayer.Instance.CDIJIMCMCOE)
			{
				yield return null;
			}
			if (IMHLFAHONPP != null)
			{
				IMHLFAHONPP();
			}
		}

		public void AddToInventory(int AGKAAMJKIMN)
		{
			GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Coins, AGKAAMJKIMN, true, true);
			CEMNJEFHGFJ = AGKAAMJKIMN;
			GEBAAFFGKJG.GABGKBAKHDP.IBFMAELGBGP(AGKAAMJKIMN);
			StartCoroutine(FGACHPMAHBD(delegate
			{
				DialogLibrary.GABGKBAKHDP.ShowDialogBackgroundFast();
				GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.PurchaseSuccessDialog, false, false, false, null, false);
				PurchaseSuccessDialog component = gameObject.GetComponent<PurchaseSuccessDialog>();
				component.Init(NAAHKHPBAPA.Coins, MKCIBHENGFI);
			}));
		}

		public void AddToInventory(PMCGNIAAMND ECCBKJNBHMH)
		{
			CEMNJEFHGFJ = ECCBKJNBHMH.CIOENCFNLKH;
			MNPADPHEKJF = ECCBKJNBHMH.BHIJCAOHDCM;
			GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Coins, ECCBKJNBHMH.CIOENCFNLKH, true, true);
			GEBAAFFGKJG.GABGKBAKHDP.IBFMAELGBGP(ECCBKJNBHMH.CIOENCFNLKH);
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
			StartCoroutine(FGACHPMAHBD(delegate
			{
				DialogLibrary.GABGKBAKHDP.ShowDialogBackgroundFast();
				GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.PurchaseSuccessDialog, false, false, false, null, false);
				PurchaseSuccessDialog component = gameObject.GetComponent<PurchaseSuccessDialog>();
				component.Init(NAAHKHPBAPA.Coins, MKCIBHENGFI);
			}));
		}

		private void MKCIBHENGFI(NAAHKHPBAPA NEMEKIOEOLC)
		{
			IJIMKNBDAKJ();
			CurrentBundleContent.EnableColliders();
		}

		private void IJIMKNBDAKJ()
		{
			MapUIAnimationController instance = MapUIAnimationController.Instance;
			if (!(instance == null))
			{
				int cEMNJEFHGFJ = CEMNJEFHGFJ;
				Vector3 zero = Vector3.zero;
				zero.x = -0.2f;
				int eNMLICFLHAO = 5 + 3 * MNPADPHEKJF;
				instance.StartCoinCollectAnimation(cEMNJEFHGFJ, eNMLICFLHAO, zero);
			}
		}

		[CompilerGenerated]
		private void IEBLHDEBEKP()
		{
			DialogLibrary.GABGKBAKHDP.ShowDialogBackgroundFast();
			GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.PurchaseSuccessDialog, false, false, false, null, false);
			PurchaseSuccessDialog component = gameObject.GetComponent<PurchaseSuccessDialog>();
			component.Init(NAAHKHPBAPA.Coins, MKCIBHENGFI);
		}

		[CompilerGenerated]
		private void DELKPDECFBK()
		{
			DialogLibrary.GABGKBAKHDP.ShowDialogBackgroundFast();
			GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.PurchaseSuccessDialog, false, false, false, null, false);
			PurchaseSuccessDialog component = gameObject.GetComponent<PurchaseSuccessDialog>();
			component.Init(NAAHKHPBAPA.Coins, MKCIBHENGFI);
		}
	}
}
