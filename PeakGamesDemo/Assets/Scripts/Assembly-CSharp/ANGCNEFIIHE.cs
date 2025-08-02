using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Assets.Scripts.SceneTransitions;
using Assets.Scripts.Utils.Analytics;
using BillingUnityLibraries;
using BillingUnityLibraries.callbacks;
using BillingUnityLibraries.helpers;
using Fabric.Answers;
using NewMapScene;
using UnityEngine;

public class ANGCNEFIIHE
{
	[Serializable]
	private class JsonAndroidTransactionInfo
	{
		public string orderId;

		public string productId;
	}

	[CompilerGenerated]
	private sealed class CLCFMKBFHJF
	{
		internal BillingProduct MHCFFEOFFOB;

		internal bool AGFNGEFDHLA(PMCGNIAAMND FMFABAKPMLB)
		{
			return FMFABAKPMLB.FDIOHLPIGAI == MHCFFEOFFOB.Identifier;
		}
	}

	[CompilerGenerated]
	private sealed class IMGFJDPDNHA
	{
		internal string JELMKJDBGBN;

		internal Action<int, string> EFBFEEELHEG;

		internal ANGCNEFIIHE PDAPIGLEPGC;

		internal void AGFNGEFDHLA(bool DIDHNNMKJFE)
		{
			if (DIDHNNMKJFE)
			{
				if (PDAPIGLEPGC.PDHACDLPMAC.ContainsKey(JELMKJDBGBN))
				{
					GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.CaravanBillingHelper, "There is already an operation for this product waiting: {0}", JELMKJDBGBN);
					if (EFBFEEELHEG != null)
					{
						EFBFEEELHEG(4, null);
					}
				}
				else
				{
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Purchase {0} will be requested from facade", JELMKJDBGBN);
					PDAPIGLEPGC.PDHACDLPMAC.Add(JELMKJDBGBN, EFBFEEELHEG);
					FLPNPJOBJBE.StartPurchase(JELMKJDBGBN, OEBNKGLEEKH());
				}
			}
			else
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.CaravanBillingHelper, "Purchase failed: {0}", JELMKJDBGBN);
				if (EFBFEEELHEG != null)
				{
					EFBFEEELHEG(1, null);
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class LFIAGCFNIOI
	{
		internal string IGPIEBMPMGD;

		internal bool AGFNGEFDHLA(BillingProduct HPHBDNBJPHB)
		{
			return IGPIEBMPMGD.Equals(HPHBDNBJPHB.Identifier);
		}
	}

	public const int GKCMCCPHNIP = 0;

	public const int POOEEJALMBB = 1;

	public const int AOCEDMOBIJI = 2;

	public const int HCIFAKKOEAD = 3;

	public const int HIKDLMLPFIM = 4;

	private const string JHOJGAGGAFE = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAlPX5XIGzEWICzsHJuAwolpHIpNmFFE06LdKTm+HzJEPgFJYYAn3K+zg3c2dy/nVh7A4KSFEImqbqTTuUSGUD0DyGsUBXtK91ksIsNSn7+I4cfglKxTgWsLKz/iN4S9CUbn/0EqryAW8DDjnHlUZvSIrpj4mRc29K5oiyPs+aUto4Rs62ak3+oV9zcee+gJ6pyjgXGuOKS8VlsTIrU+nByp7Xgrf23druagB4VsrwF6uK0P04aS7r52CiWUu+8KX/6JUIr+150ivaZAHuLJopp8OqLyu7wKWrYvyVk8DUn4jMnjNDz1qw8JcQ3QvJJvT49pZYhHqUemff0me40gFQYQIDAQAB";

	private static BillingFacade FLPNPJOBJBE;

	private static BillingConfig LAFIGNCNBNJ;

	private readonly Dictionary<string, Action<int, string>> PDHACDLPMAC = new Dictionary<string, Action<int, string>>();

	private static readonly HashSet<string> GJAOFJIIEHJ = new HashSet<string>();

	private float HGOBMBLNJIE;

	private float PJDFBGNDBGG;

	private LLCJMMBBLEH APNGJCMDMDJ;

	private bool PNHEOKMOHMH;

	private bool PKPFPHCGLBC;

	private bool DHFBGEGMPNK;

	private static ANGCNEFIIHE KNPOFJNFLJB;

	private BillingProduct[] OMLDGHMIGKL;

	private bool APICADEIEIO;

	[CompilerGenerated]
	private static Action<bool> EBCOMJBLIPP;

	[CompilerGenerated]
	private static LogCallback JANLDOMIIEF;

	public bool KBMLOIMHBCB { get; set; }

	public bool JPOJKMBOLIJ
	{
		get
		{
			return PDHACDLPMAC.Count > 0;
		}
	}

	public static ANGCNEFIIHE GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB != null)
			{
				return KNPOFJNFLJB;
			}
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "CaravanBillingHelper created.");
			KNPOFJNFLJB = new ANGCNEFIIHE();
			return KNPOFJNFLJB;
		}
	}

	private ANGCNEFIIHE()
	{
		FLPNPJOBJBE = BillingFacade.Instance;
		FLPNPJOBJBE.OnInitializeResult += GJLEAHBHONN;
		FLPNPJOBJBE.OnPurchaseFail += KFMFDFAAOFH;
		FLPNPJOBJBE.OnPurchaseSuccess += NJCBKPEBEAF;
		FLPNPJOBJBE.OnQueryInventoryResult += KMOCCFAHKCL;
		FLPNPJOBJBE.OnLog += PMLJKHKGPLJ;
		LAFIGNCNBNJ = new BillingConfig();
		LAFIGNCNBNJ.GooglePlayStorePublicKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAlPX5XIGzEWICzsHJuAwolpHIpNmFFE06LdKTm+HzJEPgFJYYAn3K+zg3c2dy/nVh7A4KSFEImqbqTTuUSGUD0DyGsUBXtK91ksIsNSn7+I4cfglKxTgWsLKz/iN4S9CUbn/0EqryAW8DDjnHlUZvSIrpj4mRc29K5oiyPs+aUto4Rs62ak3+oV9zcee+gJ6pyjgXGuOKS8VlsTIrU+nByp7Xgrf23druagB4VsrwF6uK0P04aS7r52CiWUu+8KX/6JUIr+150ivaZAHuLJopp8OqLyu7wKWrYvyVk8DUn4jMnjNDz1qw8JcQ3QvJJvT49pZYhHqUemff0me40gFQYQIDAQAB";
		LAFIGNCNBNJ.MarketType = BillingConfig.Market.Google;
	}

	private void NJCBKPEBEAF(string LFCPPDHKCOA, string JELMKJDBGBN, string AHJMDABAPGK, string CIDGIIHKCFN, string PINNJBGMGOA, bool DLPNHOMMGGF)
	{
		LIFJCNOKKJB();
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Purchase accepted from mobile. Will validate receipt. productId:{0}, transactionId:{1}, isRetry:{2}", JELMKJDBGBN, LFCPPDHKCOA, DLPNHOMMGGF);
		new LLCJMMBBLEH(GALFIOKAGHG(PINNJBGMGOA, CIDGIIHKCFN, LFCPPDHKCOA, JELMKJDBGBN, AHJMDABAPGK, DLPNHOMMGGF), true, IAJNLGPHGLO.App);
		if (!DLPNHOMMGGF)
		{
			JMPPHLHPLHL("PurchaseSuccess", HGOBMBLNJIE);
		}
	}

	private void LIFJCNOKKJB()
	{
		bool flag = false;
		if (APNGJCMDMDJ != null && APNGJCMDMDJ.BPLCLABMIMM)
		{
			flag = true;
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Received Purchase Success while waiting for PerformOnPurchaseFail");
			APNGJCMDMDJ.BPPFBMCJOAH();
		}
		APNGJCMDMDJ = null;
		float num = Time.realtimeSinceStartup - PJDFBGNDBGG;
		if (num > 0f && num < 5f)
		{
			Answers.LogCustom("PurchaseDuration", new Dictionary<string, object>
			{
				{
					"PurchaseRescuedFromFail",
					flag.ToString()
				},
				{
					"PurchaseDurationDiffBetweenFailAndSuccess",
					((int)num).ToString()
				}
			});
		}
	}

	private IEnumerator GALFIOKAGHG(string PINNJBGMGOA, string CIDGIIHKCFN, string LFCPPDHKCOA, string JELMKJDBGBN, string AHJMDABAPGK, bool DLPNHOMMGGF)
	{
		while (APICADEIEIO)
		{
			yield return null;
		}
		APICADEIEIO = true;
		if (PINNJBGMGOA == null || CIDGIIHKCFN == null || LFCPPDHKCOA == null)
		{
			APICADEIEIO = false;
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.CaravanBillingHelper, "Couldn't sent to verification because of missing parameter {0}:{1}:{2}", PINNJBGMGOA, CIDGIIHKCFN, LFCPPDHKCOA);
			Action<int, string> value;
			PDHACDLPMAC.TryGetValue(JELMKJDBGBN, out value);
			if (value != null)
			{
				value(3, JELMKJDBGBN);
			}
			PDHACDLPMAC.Remove(JELMKJDBGBN);
			yield break;
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Verification sent for {0}", LFCPPDHKCOA);
		BMDCGIHCEDE bMDCGIHCEDE = new BMDCGIHCEDE(PINNJBGMGOA, CIDGIIHKCFN, LFCPPDHKCOA, JELMKJDBGBN);
		KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH> { bMDCGIHCEDE });
		while (!bMDCGIHCEDE.GPMFHHMEBOO)
		{
			yield return null;
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Verification ended for {0}. Result:{1} RequestArrived:{2} Advice:{3}", LFCPPDHKCOA, bMDCGIHCEDE.CDLDCBCKJFG, bMDCGIHCEDE.LIGMDMEJIDB, bMDCGIHCEDE.EOHFELACNEA);
		if (!bMDCGIHCEDE.CDLDCBCKJFG && !bMDCGIHCEDE.LIGMDMEJIDB)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Couldn't reach backend for verification, try with fallback URL now.");
			bMDCGIHCEDE = new BMDCGIHCEDE(PINNJBGMGOA, CIDGIIHKCFN, LFCPPDHKCOA, JELMKJDBGBN);
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH> { bMDCGIHCEDE }, true);
			while (!bMDCGIHCEDE.GPMFHHMEBOO)
			{
				yield return null;
			}
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Second verification ended for {0}. Result:{1} RequestArrived:{2} Advice:{3}", LFCPPDHKCOA, bMDCGIHCEDE.CDLDCBCKJFG, bMDCGIHCEDE.LIGMDMEJIDB, bMDCGIHCEDE.EOHFELACNEA);
		}
		bool cDLDCBCKJFG = bMDCGIHCEDE.CDLDCBCKJFG;
		bool lIGMDMEJIDB = bMDCGIHCEDE.LIGMDMEJIDB;
		IEnumerator enumerator = KMAGFDAIAOD(LFCPPDHKCOA, JELMKJDBGBN, DLPNHOMMGGF, cDLDCBCKJFG, lIGMDMEJIDB, bMDCGIHCEDE.IJGFHAKOCNH, bMDCGIHCEDE.EOHFELACNEA, NOHMONBCAKM(CIDGIIHKCFN));
		while (enumerator.MoveNext())
		{
			yield return enumerator.Current;
		}
	}

	private IEnumerator KMAGFDAIAOD(string LFCPPDHKCOA, string JELMKJDBGBN, bool DLPNHOMMGGF, bool EGLGDMMHGDI, bool NBCBHMADGBL, string PDGPDINIPLK, bool AFNKCNLBJNF, string HCJOGBJOGAH)
	{
		Action<int, string> value;
		if (!PDHACDLPMAC.TryGetValue(JELMKJDBGBN, out value))
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "There is no action for productId:{0}", JELMKJDBGBN);
			if (!DLPNHOMMGGF)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Action is not found and not a retry. We will force retry.");
				DLPNHOMMGGF = true;
			}
		}
		BillingProduct billingProduct = BBIMJOIGCLA(JELMKJDBGBN);
		if (!EGLGDMMHGDI || GJAOFJIIEHJ.Contains(LFCPPDHKCOA))
		{
			APICADEIEIO = false;
			if (NBCBHMADGBL && AFNKCNLBJNF)
			{
				FLPNPJOBJBE.ConsumePurchase(LFCPPDHKCOA);
				OJFHMNJGLGB(false, billingProduct, LFCPPDHKCOA, HCJOGBJOGAH, GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins), HLJHIJOGIBN.LKHOELJMLID, "Code=-1 Backend validation failed and consume advised. UserInfo");
			}
			if (value != null)
			{
				value(3, JELMKJDBGBN);
			}
			PDHACDLPMAC.Remove(JELMKJDBGBN);
			yield break;
		}
		yield return null;
		if (JELMKJDBGBN != null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Applying purchase for {0}.", JELMKJDBGBN);
			if (billingProduct == null)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.CaravanBillingHelper, "No real purchase for {0}.", JELMKJDBGBN);
				APICADEIEIO = false;
				if (value != null)
				{
					value(3, JELMKJDBGBN);
				}
				PDHACDLPMAC.Remove(JELMKJDBGBN);
				yield break;
			}
			AGKKCACCEBB(EGLGDMMHGDI, billingProduct);
			if (DLPNHOMMGGF)
			{
				PBPGLMHHAKG(JELMKJDBGBN, billingProduct, value, LFCPPDHKCOA, HCJOGBJOGAH);
			}
			else
			{
				JAJMJBMBPLP(JELMKJDBGBN, billingProduct, value, LFCPPDHKCOA, HCJOGBJOGAH);
			}
			value = null;
		}
		if (PDGPDINIPLK != null)
		{
			string[] array = PDGPDINIPLK.Split(',');
			if (array.Length > 0)
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				string[] array2 = array;
				foreach (string text in array2)
				{
					string[] array3 = text.Split('|');
					if (array3.Length != 2 || array3.Length != 3)
					{
						continue;
					}
					string text2 = array3[0].Trim();
					string text3 = array3[1].Trim();
					bool flag = array3.Length == 3;
					if (JELMKJDBGBN != null && text2.Equals(JELMKJDBGBN))
					{
						GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.CaravanBillingHelper, "Removing inner product id. Transaction id {0} for product {1}, Method transaciton id {2}", text3, JELMKJDBGBN, LFCPPDHKCOA);
						GJAOFJIIEHJ.Add(text3);
						if (!text3.Equals(LFCPPDHKCOA))
						{
							FLPNPJOBJBE.ConsumePurchase(text3);
						}
					}
					else if (flag)
					{
						GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Just consume transaction id {0} for product {1}, it is already applied.", text3, JELMKJDBGBN);
						FLPNPJOBJBE.ConsumePurchase(text3);
					}
					else
					{
						dictionary[text2] = text3;
					}
				}
				Dictionary<string, string>.KeyCollection keys = dictionary.Keys;
				if (keys.Count > 0)
				{
					foreach (string item in keys)
					{
						GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.CaravanBillingHelper, "Also adding an old purchase: {0}", item);
						string text4 = dictionary[item];
						BillingProduct mHCFFEOFFOB = BBIMJOIGCLA(item);
						PBPGLMHHAKG(item, mHCFFEOFFOB, value, text4, HCJOGBJOGAH);
						value = null;
						GJAOFJIIEHJ.Add(text4);
						FLPNPJOBJBE.ConsumePurchase(text4);
						AGKKCACCEBB(EGLGDMMHGDI, mHCFFEOFFOB);
					}
				}
			}
		}
		GJAOFJIIEHJ.Add(LFCPPDHKCOA);
		FLPNPJOBJBE.ConsumePurchase(LFCPPDHKCOA);
		APICADEIEIO = false;
	}

	private void JAJMJBMBPLP(string JELMKJDBGBN, BillingProduct MHCFFEOFFOB, Action<int, string> HHGAIHDIDGC, string LFCPPDHKCOA, string HCJOGBJOGAH)
	{
		try
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Purchase arrived for productId:{0}", JELMKJDBGBN);
			PDHACDLPMAC.Remove(JELMKJDBGBN);
			int jFLJEAAONLI = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins);
			if (HHGAIHDIDGC != null)
			{
				HHGAIHDIDGC(0, JELMKJDBGBN);
			}
			OJFHMNJGLGB(true, MHCFFEOFFOB, LFCPPDHKCOA, HCJOGBJOGAH, jFLJEAAONLI, HLJHIJOGIBN.LKHOELJMLID);
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.CaravanBillingHelper, " Can not apply purchase: {0}", ex.Message);
		}
	}

	private void PBPGLMHHAKG(string JELMKJDBGBN, BillingProduct MHCFFEOFFOB, Action<int, string> HHGAIHDIDGC, string LFCPPDHKCOA, string HCJOGBJOGAH)
	{
		try
		{
			int jFLJEAAONLI = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins);
			if (HHGAIHDIDGC != null)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Retry arrived for productId:{0}, with action to take.", JELMKJDBGBN);
				if (PDHACDLPMAC.ContainsKey(JELMKJDBGBN))
				{
					PDHACDLPMAC.Remove(JELMKJDBGBN);
				}
				HHGAIHDIDGC(0, JELMKJDBGBN);
				OJFHMNJGLGB(true, MHCFFEOFFOB, LFCPPDHKCOA, HCJOGBJOGAH, jFLJEAAONLI, "Retry");
				return;
			}
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Retry arrived for productId:{0}, with no action to take.", JELMKJDBGBN);
			if (MGFODIBKGNA(JELMKJDBGBN) || NGHNGDEMAGP(JELMKJDBGBN))
			{
				KBMLOIMHBCB = true;
				OJFHMNJGLGB(true, MHCFFEOFFOB, LFCPPDHKCOA, HCJOGBJOGAH, jFLJEAAONLI, "Retry");
				if (CaravanSceneManager.CurrentScene == GKBHIKONCKJ.Map && !CaravanSceneManager.GDLJAINDFOJ)
				{
					NewMapAnimationController.AddToFocusAnimations("PurchaseRetrySuccessAnimation");
				}
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.CaravanBillingHelper, " Can not apply retry: {0}", ex.Message);
		}
	}

	private static bool MGFODIBKGNA(string JELMKJDBGBN)
	{
		if (JELMKJDBGBN == BOKGFGFPOHD.PHJEJCEPNPM[0].INMJKIDMBKB)
		{
			return EHIJONKIIHH(JELMKJDBGBN, BOKGFGFPOHD.PHJEJCEPNPM);
		}
		if (JELMKJDBGBN == BOKGFGFPOHD.HKMGKMGBEOJ[5].INMJKIDMBKB)
		{
			return EHIJONKIIHH(JELMKJDBGBN, BOKGFGFPOHD.HKMGKMGBEOJ);
		}
		return EHIJONKIIHH(JELMKJDBGBN, BOKGFGFPOHD.FNEABNFILKK) || EHIJONKIIHH(JELMKJDBGBN, BOKGFGFPOHD.PHJEJCEPNPM) || EHIJONKIIHH(JELMKJDBGBN, BOKGFGFPOHD.JICNIKEDCGM) || EHIJONKIIHH(JELMKJDBGBN, BOKGFGFPOHD.HKMGKMGBEOJ);
	}

	private static bool NGHNGDEMAGP(string JELMKJDBGBN)
	{
		if (JELMKJDBGBN == BOKGFGFPOHD.PMOIPEGCNPJ[5].FDIOHLPIGAI)
		{
			return NGHNGDEMAGP(JELMKJDBGBN, BOKGFGFPOHD.PMOIPEGCNPJ);
		}
		return NGHNGDEMAGP(JELMKJDBGBN, BOKGFGFPOHD.NIAJFDLMNJH) || NGHNGDEMAGP(JELMKJDBGBN, BOKGFGFPOHD.GKIAPGECDFH) || NGHNGDEMAGP(JELMKJDBGBN, BOKGFGFPOHD.EAJABILJANF) || NGHNGDEMAGP(JELMKJDBGBN, BOKGFGFPOHD.PMOIPEGCNPJ);
	}

	private static bool EHIJONKIIHH(string JELMKJDBGBN, KHMIKAEKHIG[] ACFDIDGFPKJ)
	{
		try
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Retry coins for productId:{0}", JELMKJDBGBN);
			int i = 0;
			for (int num = ACFDIDGFPKJ.Length; i < num; i++)
			{
				KHMIKAEKHIG kHMIKAEKHIG = ACFDIDGFPKJ[i];
				if (kHMIKAEKHIG.INMJKIDMBKB.Equals(JELMKJDBGBN))
				{
					int nNIDKMJGAJO = kHMIKAEKHIG.LGCFDCILJFO;
					GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Coins, nNIDKMJGAJO, true, true);
					PJPPADHKGHN.GABGKBAKHDP.ALIHKHMEPPG(kHMIKAEKHIG.PCJLEBBNEKL);
					return true;
				}
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.CaravanBillingHelper, " Can not retry coins : {0}", ex.Message);
		}
		return false;
	}

	private static bool NGHNGDEMAGP(string JELMKJDBGBN, PMCGNIAAMND[] PAHCECEPKFO)
	{
		try
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Retry bundles for productId:{0}", JELMKJDBGBN);
			int i = 0;
			for (int num = PAHCECEPKFO.Length; i < num; i++)
			{
				PMCGNIAAMND pMCGNIAAMND = PAHCECEPKFO[i];
				if (!pMCGNIAAMND.FDIOHLPIGAI.Equals(JELMKJDBGBN))
				{
					continue;
				}
				GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Coins, pMCGNIAAMND.CIOENCFNLKH, true, true);
				int aMKGEHCMHIA = pMCGNIAAMND.AMKGEHCMHIA;
				List<NAAHKHPBAPA> list = ((pMCGNIAAMND.DDILBILNNFN <= 0) ? PMCGNIAAMND.OHDNIPPLMJO : PMCGNIAAMND.KCEHEMOIGHB);
				for (int j = 0; j < list.Count; j++)
				{
					NAAHKHPBAPA nAAHKHPBAPA = list[j];
					if (nAAHKHPBAPA != NAAHKHPBAPA.UnlimitedLife)
					{
						GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(nAAHKHPBAPA, aMKGEHCMHIA, true, true);
					}
					else
					{
						PJPPADHKGHN.GABGKBAKHDP.ALIHKHMEPPG(pMCGNIAAMND.DDILBILNNFN);
					}
				}
				return true;
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.CaravanBillingHelper, " Can not retry bundles : {0}", ex.Message);
		}
		return false;
	}

	private static void AGKKCACCEBB(bool EGLGDMMHGDI, BillingProduct MHCFFEOFFOB)
	{
		try
		{
			if (!EGLGDMMHGDI)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.CaravanBillingHelper, "Validation is failed at server side, will not mark.");
				return;
			}
			if (!LECPGNKOABP.GABGKBAKHDP.ILNAPPDKOOD)
			{
				DJFPMCMLPJJ.CDDEPINEGBP(MHCFFEOFFOB);
			}
			GEBAAFFGKJG.GABGKBAKHDP.LDHHPHHKNHL(NJGLIIMEMBI.USER_TYPE_PAID);
			LECPGNKOABP.GABGKBAKHDP.ILNAPPDKOOD = true;
			CLBKOKIFCFO(BOKGFGFPOHD.NIAJFDLMNJH.FirstOrDefault((PMCGNIAAMND FMFABAKPMLB) => FMFABAKPMLB.FDIOHLPIGAI == MHCFFEOFFOB.Identifier));
			OIAJPMNJGLK.OIOEHLJFLJG();
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.CaravanBillingHelper, "Can not mark user as paid! {0}", ex.Message);
		}
	}

	private static void CLBKOKIFCFO(PMCGNIAAMND BABKFGDIMCH)
	{
		if (BABKFGDIMCH != null)
		{
			GEBAAFFGKJG.GABGKBAKHDP.LDHHPHHKNHL(NJGLIIMEMBI.USER_TYPE_BUNDLE_PAID);
			if (BABKFGDIMCH.BHIJCAOHDCM == BOKGFGFPOHD.NIAJFDLMNJH.Length)
			{
				GEBAAFFGKJG.GABGKBAKHDP.LDHHPHHKNHL(NJGLIIMEMBI.USER_TYPE_HIGH_PAID);
			}
			HJBLKNBHMFJ hJBLKNBHMFJ = HJBLKNBHMFJ.GABGKBAKHDP;
			int result;
			int.TryParse(hJBLKNBHMFJ.LIANKDMAHFM("KeyHighestBoughtBundleNo"), out result);
			if (BABKFGDIMCH.BHIJCAOHDCM > result)
			{
				hJBLKNBHMFJ.JGMDDMNGDJO("KeyHighestBoughtBundleNo", BABKFGDIMCH.BHIJCAOHDCM.ToString());
			}
		}
	}

	private void KFMFDFAAOFH(ErrorCode FJCNPLPKFKP, string IGDFEKFDACB, string JELMKJDBGBN, bool DLPNHOMMGGF)
	{
		PJDFBGNDBGG = Time.realtimeSinceStartup;
		APNGJCMDMDJ = new LLCJMMBBLEH(BBLPGNPNNDC(FJCNPLPKFKP, IGDFEKFDACB, JELMKJDBGBN, DLPNHOMMGGF), true, IAJNLGPHGLO.App);
	}

	private IEnumerator BBLPGNPNNDC(ErrorCode FJCNPLPKFKP, string IGDFEKFDACB, string JELMKJDBGBN, bool DLPNHOMMGGF)
	{
		yield return MCJHHDACJBG.KNLADMIBAAD;
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Fail on productId:{0}, due to:{1}, is retry:{2}", JELMKJDBGBN, IGDFEKFDACB, DLPNHOMMGGF);
		BillingProduct mHCFFEOFFOB = BBIMJOIGCLA(JELMKJDBGBN);
		OJFHMNJGLGB(false, mHCFFEOFFOB, string.Empty, null, GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins), HLJHIJOGIBN.LKHOELJMLID, IGDFEKFDACB);
		if (DLPNHOMMGGF)
		{
			yield break;
		}
		JMPPHLHPLHL("PurchaseFail", HGOBMBLNJIE);
		Action<int, string> value;
		if (JELMKJDBGBN != null && PDHACDLPMAC.TryGetValue(JELMKJDBGBN, out value))
		{
			PDHACDLPMAC.Remove(JELMKJDBGBN);
			if (value != null)
			{
				value((FJCNPLPKFKP != ErrorCode.UserCancelled) ? 1 : 2, JELMKJDBGBN);
			}
		}
	}

	private static void OJFHMNJGLGB(bool EEKJMDHEJCK, BillingProduct MHCFFEOFFOB, string LFCPPDHKCOA, string HCJOGBJOGAH, int JFLJEAAONLI, string IIHLJOKODJG, string LENFKJMEBFP = null)
	{
		AFJPGLHKOID.GOJOHDKEAGC(EEKJMDHEJCK, MHCFFEOFFOB, LFCPPDHKCOA, HCJOGBJOGAH, JFLJEAAONLI, IIHLJOKODJG, LENFKJMEBFP);
		if (EEKJMDHEJCK)
		{
			DJFPMCMLPJJ.CODIOHDGNGC(MHCFFEOFFOB);
			if (MHCFFEOFFOB != null)
			{
				NFDHFOAMOCD.JGKGPFOOFBA(MHCFFEOFFOB.PriceAsFloat(), MHCFFEOFFOB.Currency);
			}
		}
	}

	private static void JMPPHLHPLHL(string GKOHLEGOCGH, float NLAAGMPFDOG)
	{
		if (!(NLAAGMPFDOG <= 0f))
		{
			float num = Time.realtimeSinceStartup - NLAAGMPFDOG;
			if (!(num > 300f))
			{
				Answers.LogCustom("PurchaseDuration", new Dictionary<string, object> { { GKOHLEGOCGH, num } });
			}
		}
	}

	private static void PMLJKHKGPLJ(string OEFCOJLNCKP, bool PMLIMGLMKNO)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, OEFCOJLNCKP);
	}

	public void OLHJPKIBMFF(string JELMKJDBGBN, Action<int, string> EFBFEEELHEG)
	{
		if (JELMKJDBGBN == null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Can not purchase null item");
			EFBFEEELHEG(1, null);
			return;
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Starting purchase for product {0}.", JELMKJDBGBN);
		HGOBMBLNJIE = Time.realtimeSinceStartup;
		FEEMCKCKAAL(delegate(bool DIDHNNMKJFE)
		{
			if (DIDHNNMKJFE)
			{
				if (PDHACDLPMAC.ContainsKey(JELMKJDBGBN))
				{
					GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.CaravanBillingHelper, "There is already an operation for this product waiting: {0}", JELMKJDBGBN);
					if (EFBFEEELHEG != null)
					{
						EFBFEEELHEG(4, null);
					}
				}
				else
				{
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Purchase {0} will be requested from facade", JELMKJDBGBN);
					PDHACDLPMAC.Add(JELMKJDBGBN, EFBFEEELHEG);
					FLPNPJOBJBE.StartPurchase(JELMKJDBGBN, OEBNKGLEEKH());
				}
			}
			else
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.CaravanBillingHelper, "Purchase failed: {0}", JELMKJDBGBN);
				if (EFBFEEELHEG != null)
				{
					EFBFEEELHEG(1, null);
				}
			}
		});
	}

	private static string OEBNKGLEEKH()
	{
		return "toonblast_" + PeakAnalytics.GetDeviceId();
	}

	public void MAJNMFPONHF()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Retry requested!");
		FEEMCKCKAAL(delegate(bool DIDHNNMKJFE)
		{
			if (DIDHNNMKJFE)
			{
				FLPNPJOBJBE.RetryPurchases();
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Retry performing:");
			}
		});
	}

	public bool EKGJCJOLKGP()
	{
		return PNHEOKMOHMH;
	}

	public void FEEMCKCKAAL(Action<bool> GPLIOLJFDPM)
	{
		if (PNHEOKMOHMH)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Billing is ready; executing action.");
			IONFHDLPCKG();
			if (GPLIOLJFDPM != null)
			{
				GPLIOLJFDPM(true);
			}
			return;
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Billing is not ready; execute and wait.:{0}", DHFBGEGMPNK);
		if (!DHFBGEGMPNK)
		{
			DIOELAHNLKJ();
		}
		new LLCJMMBBLEH(BAKEEPPPOAI(GPLIOLJFDPM), true, IAJNLGPHGLO.App);
	}

	private IEnumerator BAKEEPPPOAI(Action<bool> GPLIOLJFDPM)
	{
		while (DHFBGEGMPNK)
		{
			yield return null;
		}
		if (GPLIOLJFDPM != null)
		{
			GPLIOLJFDPM(PNHEOKMOHMH);
		}
	}

	public void DIOELAHNLKJ()
	{
		DHFBGEGMPNK = true;
		if (!PKPFPHCGLBC)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Init requested. {0}", PKPFPHCGLBC);
			FLPNPJOBJBE.InitializeBilling(LAFIGNCNBNJ);
		}
		else
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Already initted and continue with query inventory.");
			FLPNPJOBJBE.QueryInventory(BOKGFGFPOHD.IOBAEOBIKNC);
		}
	}

	public void GIFMDPFFCDH()
	{
		if (PKPFPHCGLBC && (OMLDGHMIGKL == null || OMLDGHMIGKL.Length == 0))
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "QueryInventory: _products is null so try to get it again.");
			FLPNPJOBJBE.QueryInventory(BOKGFGFPOHD.IOBAEOBIKNC);
		}
	}

	private void GJLEAHBHONN(bool DIDHNNMKJFE, string IGDFEKFDACB)
	{
		if (DIDHNNMKJFE)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Init completed and continue with query inventory.");
			FLPNPJOBJBE.QueryInventory(BOKGFGFPOHD.IOBAEOBIKNC);
			PKPFPHCGLBC = true;
		}
		else
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Payment init failed:{0}", IGDFEKFDACB);
			DHFBGEGMPNK = false;
		}
	}

	private void KMOCCFAHKCL(bool DIDHNNMKJFE, BillingProduct[] DOLNPEIHEBF)
	{
		DHFBGEGMPNK = false;
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Payment inventory result: {0}", DIDHNNMKJFE);
		if (!DIDHNNMKJFE)
		{
			return;
		}
		OMLDGHMIGKL = DOLNPEIHEBF;
		if (DOLNPEIHEBF.Length > 0)
		{
			for (int i = 0; i < DOLNPEIHEBF.Length; i++)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Payment inventory product: {0}", DOLNPEIHEBF[i]);
			}
		}
		else
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.CaravanBillingHelper, "No products received.");
		}
		PNHEOKMOHMH = true;
	}

	private BillingProduct BBIMJOIGCLA(string IGPIEBMPMGD)
	{
		if (IGPIEBMPMGD == null)
		{
			return null;
		}
		if (OMLDGHMIGKL != null && OMLDGHMIGKL.Length > 0)
		{
			BillingProduct billingProduct = OMLDGHMIGKL.FirstOrDefault((BillingProduct HPHBDNBJPHB) => IGPIEBMPMGD.Equals(HPHBDNBJPHB.Identifier));
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Product {0} fetched for {1}", IGPIEBMPMGD, (billingProduct != null) ? billingProduct.Identifier : "pw is null");
			return billingProduct;
		}
		if (BOKGFGFPOHD.IOBAEOBIKNC.Contains(IGPIEBMPMGD) && BOKGFGFPOHD.FAEIHDFPLFI.ContainsKey(IGPIEBMPMGD))
		{
			string text = BOKGFGFPOHD.FAEIHDFPLFI[IGPIEBMPMGD];
			string price = text.Split(' ')[1];
			return new BillingProduct("$", IGPIEBMPMGD, price);
		}
		return null;
	}

	public string ENHPFINGJEA(string IGPIEBMPMGD)
	{
		BillingProduct billingProduct = BBIMJOIGCLA(IGPIEBMPMGD);
		if (billingProduct == null)
		{
			return null;
		}
		return JPDKHKELLBA(billingProduct);
	}

	private static string JPDKHKELLBA(BillingProduct PLCFEOMGCFK)
	{
		string price = PLCFEOMGCFK.Price;
		if (PLCFEOMGCFK.Currency == null)
		{
			return price;
		}
		switch (PLCFEOMGCFK.Currency.ToUpperInvariant())
		{
		case "USD":
		case "CAD":
		case "AUD":
			return "<size=78%>$</size> " + price;
		case "EUR":
			return price + " <size=78%>€</size>";
		case "GBP":
			return "<size=78%>£</size> " + price;
		case "TRY":
			return price + " <size=78%>TL</size>";
		default:
			return price + "<size=78%>" + PLCFEOMGCFK.Currency + "</size> ";
		}
	}

	public string JBGJMFHPBDM(string GMBNJCKNOBD)
	{
		return (GMBNJCKNOBD != null) ? HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("prc_" + GMBNJCKNOBD.ToLowerInvariant()) : null;
	}

	private void IONFHDLPCKG()
	{
		if (OMLDGHMIGKL != null)
		{
			for (int i = 0; i < OMLDGHMIGKL.Length; i++)
			{
				BillingProduct billingProduct = OMLDGHMIGKL[i];
				HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("prc_" + billingProduct.Identifier.ToLowerInvariant(), JPDKHKELLBA(billingProduct));
			}
		}
	}

	private static string NOHMONBCAKM(string CIDGIIHKCFN)
	{
		if (!MCJHHDACJBG.MCPELNPBPIF || CIDGIIHKCFN == null)
		{
			return null;
		}
		try
		{
			JsonAndroidTransactionInfo jsonAndroidTransactionInfo = JsonUtility.FromJson<JsonAndroidTransactionInfo>(CIDGIIHKCFN);
			return jsonAndroidTransactionInfo.orderId;
		}
		catch (Exception)
		{
			return null;
		}
	}

	[CompilerGenerated]
	private static void JPNKICHLMAD(bool DIDHNNMKJFE)
	{
		if (DIDHNNMKJFE)
		{
			FLPNPJOBJBE.RetryPurchases();
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CaravanBillingHelper, "Retry performing:");
		}
	}
}
