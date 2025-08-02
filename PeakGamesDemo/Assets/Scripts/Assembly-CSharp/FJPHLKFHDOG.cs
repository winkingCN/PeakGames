using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NewMapScene;
using UnityEngine;

public class FJPHLKFHDOG
{
	private class HFNDBEKFFOJ
	{
		public readonly long GDMECFECCOM;

		public string BCJMJBCPCML;

		public bool IBABGEJMKCJ;

		public HFNDBEKFFOJ(string MBBPBGHKLJM)
		{
			string[] array = MBBPBGHKLJM.Split(':');
			if (array.Length == 3)
			{
				long.TryParse(array[0], out GDMECFECCOM);
				BCJMJBCPCML = array[1];
				IBABGEJMKCJ = array[2].Equals("1");
			}
		}

		public HFNDBEKFFOJ(long BPKJLGJDFKG)
		{
			GDMECFECCOM = BPKJLGJDFKG;
		}

		public HFNDBEKFFOJ(long BPKJLGJDFKG, string JPLBFCGBKPM)
		{
			GDMECFECCOM = BPKJLGJDFKG;
			BCJMJBCPCML = JPLBFCGBKPM;
		}

		public override string ToString()
		{
			return GDMECFECCOM + ":" + BCJMJBCPCML + ":" + ((!IBABGEJMKCJ) ? "0" : "1");
		}
	}

	[CompilerGenerated]
	private sealed class FJPKNPBJLKO
	{
		internal long BPKJLGJDFKG;

		internal bool AGFNGEFDHLA(HFNDBEKFFOJ AMFCENFNAJJ)
		{
			return AMFCENFNAJJ.GDMECFECCOM == BPKJLGJDFKG;
		}
	}

	[CompilerGenerated]
	private sealed class GLEKKIHNLLJ
	{
		internal HFNDBEKFFOJ AGGLDDOJBAN;

		internal bool AGFNGEFDHLA(HFNDBEKFFOJ ELNCCDELMMH)
		{
			return ELNCCDELMMH.GDMECFECCOM == AGGLDDOJBAN.GDMECFECCOM;
		}
	}

	private const int BKGECOPIPOP = 0;

	private const int OOFAJHOEKGF = 1;

	private int JAIPNDBEKEL;

	private Action BCNJAFIOFBP;

	private LLCJMMBBLEH CMEILMNDBAL;

	private static FJPHLKFHDOG KNPOFJNFLJB;

	public static FJPHLKFHDOG GABGKBAKHDP
	{
		get
		{
			return KNPOFJNFLJB ?? (KNPOFJNFLJB = new FJPHLKFHDOG());
		}
	}

	private FJPHLKFHDOG()
	{
	}

	public void DIOELAHNLKJ(Action NLIMEBBOEPN)
	{
		DHJKANCBPGG();
		BCNJAFIOFBP = NLIMEBBOEPN;
	}

	public bool FMPALJDNDEN()
	{
		return JAIPNDBEKEL == 0;
	}

	private void DHJKANCBPGG()
	{
		JAIPNDBEKEL = PlayerPrefs.GetInt("ConsentStatus");
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ConsentHelper, "UpdateStatus:{0}", JAIPNDBEKEL);
	}

	public void CGHAGFOOPPA()
	{
		JAIPNDBEKEL = 0;
		PlayerPrefs.SetInt("ConsentStatus", JAIPNDBEKEL);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ConsentHelper, "MarkShowConsent");
		NewMapAnimationController.AddToFocusAnimations("ConsentPopupAnimation");
	}

	public bool AANIHNPAAGN()
	{
		return PlayerPrefs.GetInt("ConsentInitial") == 1;
	}

	public void GAHJOBIBKIK()
	{
		PlayerPrefs.SetInt("ConsentInitial", 1);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ConsentHelper, "AcceptInitialConsent");
	}

	public void NPNAMAGJCIM(Action GPLIOLJFDPM)
	{
		BCNJAFIOFBP = GPLIOLJFDPM;
	}

	public void JKACIDPMPMA(long BPKJLGJDFKG)
	{
		if (BPKJLGJDFKG != 0)
		{
			HFNDBEKFFOJ hFNDBEKFFOJ = new HFNDBEKFFOJ(BPKJLGJDFKG);
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ConsentHelper, "Add Consent User. UserId:{0} Timestamp:{1}", hFNDBEKFFOJ.GDMECFECCOM, hFNDBEKFFOJ.BCJMJBCPCML);
			OCHFEEHEDMP(hFNDBEKFFOJ);
		}
	}

	public void NFMELKHELIJ()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ConsentHelper, "UpdateConsentUserTimestamps");
		List<HFNDBEKFFOJ> list = KNIMMAAPEHE();
		if (list == null || list.Count == 0)
		{
			return;
		}
		string @string = PlayerPrefs.GetString("ConsentTimestamp");
		for (int i = 0; i < list.Count; i++)
		{
			HFNDBEKFFOJ hFNDBEKFFOJ = list[i];
			if (hFNDBEKFFOJ != null)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ConsentHelper, "Update Consent Data: UserId:{0} TimeStamp:{1} IsTimestampNull:{2}", hFNDBEKFFOJ.GDMECFECCOM, hFNDBEKFFOJ.BCJMJBCPCML, string.IsNullOrEmpty(hFNDBEKFFOJ.BCJMJBCPCML));
				if (string.IsNullOrEmpty(hFNDBEKFFOJ.BCJMJBCPCML))
				{
					hFNDBEKFFOJ.BCJMJBCPCML = @string;
				}
			}
		}
		IFCNABKOFGN(list);
	}

	public void KOJKOMDHBBB(long BPKJLGJDFKG)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ConsentHelper, "Consume Consent User");
		List<HFNDBEKFFOJ> list = KNIMMAAPEHE();
		if (list != null && list.Count != 0)
		{
			HFNDBEKFFOJ hFNDBEKFFOJ = list.Find((HFNDBEKFFOJ AMFCENFNAJJ) => AMFCENFNAJJ.GDMECFECCOM == BPKJLGJDFKG);
			if (hFNDBEKFFOJ != null)
			{
				hFNDBEKFFOJ.IBABGEJMKCJ = true;
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ConsentHelper, "Consume Consent User. UserId:{0} Timestamp:{1} Sent:{2} ", hFNDBEKFFOJ.GDMECFECCOM, hFNDBEKFFOJ.BCJMJBCPCML, hFNDBEKFFOJ.IBABGEJMKCJ);
				IFCNABKOFGN(list);
			}
		}
	}

	public void PHHBNNGIKFF()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ConsentHelper, "SendConsentData");
		List<HFNDBEKFFOJ> list = KNIMMAAPEHE();
		if (list == null || list.Count == 0)
		{
			return;
		}
		List<IKDMCJPBBIH> list2 = new List<IKDMCJPBBIH>();
		for (int i = 0; i < list.Count; i++)
		{
			HFNDBEKFFOJ hFNDBEKFFOJ = list[i];
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ConsentHelper, "DataList> i:{0} UserId:{1} Timestamp:{2} Sent:{3} ", i, hFNDBEKFFOJ.GDMECFECCOM, hFNDBEKFFOJ.BCJMJBCPCML, hFNDBEKFFOJ.IBABGEJMKCJ);
			long result;
			long.TryParse(hFNDBEKFFOJ.BCJMJBCPCML, out result);
			if (result > 0 && !hFNDBEKFFOJ.IBABGEJMKCJ)
			{
				list2.Add(new EADAHGNPMDB(result, hFNDBEKFFOJ.GDMECFECCOM));
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ConsentHelper, "Send Consent Data. UserId:{0} Timestamp:{1} ", hFNDBEKFFOJ.GDMECFECCOM, hFNDBEKFFOJ.BCJMJBCPCML);
			}
		}
		if (list2.Count != 0)
		{
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(list2);
		}
	}

	private void OCHFEEHEDMP(HFNDBEKFFOJ AGGLDDOJBAN)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ConsentHelper, "Add Consent Data. UserId:{0} Timestamp:{1} Sent:{2}", AGGLDDOJBAN.GDMECFECCOM, AGGLDDOJBAN.BCJMJBCPCML, AGGLDDOJBAN.IBABGEJMKCJ);
		List<HFNDBEKFFOJ> list = KNIMMAAPEHE();
		if (list == null || list.Count == 0)
		{
			List<HFNDBEKFFOJ> list2 = new List<HFNDBEKFFOJ>();
			list2.Add(AGGLDDOJBAN);
			list = list2;
		}
		else if (!list.Exists((HFNDBEKFFOJ ELNCCDELMMH) => ELNCCDELMMH.GDMECFECCOM == AGGLDDOJBAN.GDMECFECCOM))
		{
			list.Add(AGGLDDOJBAN);
		}
		IFCNABKOFGN(list);
	}

	private void IFCNABKOFGN(List<HFNDBEKFFOJ> ECFLCOMAEOB)
	{
		string text = string.Empty;
		int i = 0;
		for (int count = ECFLCOMAEOB.Count; i < count; i++)
		{
			text += ECFLCOMAEOB[i].ToString();
			if (i < count - 1)
			{
				text += ",";
			}
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ConsentHelper, "Save consent data:{0} ", text);
		PlayerPrefs.SetString("ConsentUsers", text);
	}

	private List<HFNDBEKFFOJ> KNIMMAAPEHE()
	{
		string @string = PlayerPrefs.GetString("ConsentUsers");
		if (string.IsNullOrEmpty(@string))
		{
			return null;
		}
		string[] array = @string.Split(',');
		if (array == null || array.Length == 0)
		{
			return null;
		}
		List<HFNDBEKFFOJ> list = new List<HFNDBEKFFOJ>();
		foreach (string text in array)
		{
			if (text != null)
			{
				list.Add(new HFNDBEKFFOJ(text));
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ConsentHelper, "Process local data:{0}", text);
			}
		}
		return list;
	}

	public void EDHGHANJPAO()
	{
		if (CMEILMNDBAL != null && !CMEILMNDBAL.BPLCLABMIMM)
		{
			CMEILMNDBAL = new LLCJMMBBLEH(IDNFCCDBAKD(), true, IAJNLGPHGLO.App);
		}
	}

	private IEnumerator IDNFCCDBAKD()
	{
		yield return MCJHHDACJBG.KNLADMIBAAD;
		yield return PHHKFLHAFHG.ANOHPAIFLCI;
		PHHBNNGIKFF();
		CMEILMNDBAL = null;
	}

	public void EFBEHJNKFCD()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ConsentHelper, "ShowConsentPopup");
		string fCEEGNFABAF = NKILHODNBDE.GHBGCADFLFB("ConsentTitle");
		string hOMONAAFMFH = NKILHODNBDE.GHBGCADFLFB("ConsentContent");
		string lDHECNOPBNK = NKILHODNBDE.GHBGCADFLFB("ConsentOkButton");
		string iCPIDDPDMKP = NKILHODNBDE.GHBGCADFLFB("ConsentTerms");
		string kMJJAKAMOKO = NKILHODNBDE.GHBGCADFLFB("ConsentPrivacy");
		NAAGDFCLOPE.GABGKBAKHDP.EFBEHJNKFCD(fCEEGNFABAF, hOMONAAFMFH, lDHECNOPBNK, iCPIDDPDMKP, kMJJAKAMOKO, "https://peak.com/en/privacy", "https://peak.com/en/terms");
	}

	public static void MDDJLEGCJFO()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ConsentHelper, "OnTapConsentPopup");
		AFJPGLHKOID.CPIGOAGGLBM("ConsentPopup", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, 0, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString());
	}

	public static void JODHDOKPPCN()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ConsentHelper, "OnAcceptConsentPopup");
		AFJPGLHKOID.CPIGOAGGLBM("ConsentPopup", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, 1, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString());
		string text = (FIBJIOBINHL.CFBJBKEPGAN() * 1000).ToString();
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ConsentHelper, "Consent Accepted. Timestamp:{0}", text);
		PlayerPrefs.SetString("ConsentTimestamp", text);
		PlayerPrefs.SetInt("ConsentStatus", 1);
		PlayerPrefs.Save();
		KNPOFJNFLJB.DHJKANCBPGG();
		KNPOFJNFLJB.NFMELKHELIJ();
		if (LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM != 0)
		{
			if (!KNPOFJNFLJB.AANIHNPAAGN())
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ConsentHelper, "IsInitialConsentAccepted:");
				KNPOFJNFLJB.GAHJOBIBKIK();
			}
			HFNDBEKFFOJ aGGLDDOJBAN = new HFNDBEKFFOJ(LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM, text);
			KNPOFJNFLJB.OCHFEEHEDMP(aGGLDDOJBAN);
			KNPOFJNFLJB.PHHBNNGIKFF();
		}
		if (KNPOFJNFLJB.BCNJAFIOFBP != null)
		{
			KNPOFJNFLJB.BCNJAFIOFBP();
		}
		KNPOFJNFLJB.BCNJAFIOFBP = null;
	}
}
