using System;
using System.Collections.Generic;
using UnityEngine;

public class DFJECMCCJGC : MFCJIFNNIHI
{
	private static AndroidJavaObject JCMBGNIEDNB;

	public DFJECMCCJGC(string HIFGMOMJMLH, string MPHIKFAGGOO, string LIHABAIIMFD, OneSignal.NDNHJFICCIA LPLGECLFJBG, OneSignal.IGBMNDNCLPK PDGNEDBOGLE, OneSignal.IGBMNDNCLPK IMIGIBOPIGO, bool DCMEAEEBJLH)
	{
		JCMBGNIEDNB = new AndroidJavaObject("com.onesignal.OneSignalUnityProxy", HIFGMOMJMLH, MPHIKFAGGOO, LIHABAIIMFD, (int)PDGNEDBOGLE, (int)IMIGIBOPIGO, DCMEAEEBJLH);
		AIJCJPAPNCP(LPLGECLFJBG);
	}

	public void PEDGBHJOOHK(OneSignal.IGBMNDNCLPK PDGNEDBOGLE, OneSignal.IGBMNDNCLPK IMIGIBOPIGO)
	{
		JCMBGNIEDNB.Call("setLogLevel", (int)PDGNEDBOGLE, (int)IMIGIBOPIGO);
	}

	public void EHAGACDCKFK(bool DIHAHEPGCLB)
	{
		JCMBGNIEDNB.Call("setLocationShared", DIHAHEPGCLB);
	}

	public void EFMGJJAMOLL(string MELLKFCHLCG, string MNCFEDGGAJM)
	{
		JCMBGNIEDNB.Call("sendTag", MELLKFCHLCG, MNCFEDGGAJM);
	}

	public void FFHDGIBPADH(IDictionary<string, string> NIJLMBACDIN)
	{
		JCMBGNIEDNB.Call("sendTags", DINBABILEHB.LFIJNCAPDMO(NIJLMBACDIN));
	}

	public void MGKBPJLBNLA()
	{
		JCMBGNIEDNB.Call("getTags");
	}

	public void GJMCAGHFOAO(string IKNCPEPOKGJ)
	{
		JCMBGNIEDNB.Call("deleteTag", IKNCPEPOKGJ);
	}

	public void ENHDPFKMALA(IList<string> JFPPHGPOOAA)
	{
		JCMBGNIEDNB.Call("deleteTags", DINBABILEHB.LFIJNCAPDMO(JFPPHGPOOAA));
	}

	public void ILOJEBPJOBD()
	{
		JCMBGNIEDNB.Call("idsAvailable");
	}

	public void CGPGIHFFLLI()
	{
	}

	public void KINGLACPPID()
	{
	}

	public void JNMHIBFHPJF(bool DOKMPEOLBGO)
	{
		JCMBGNIEDNB.Call("enableVibrate", DOKMPEOLBGO);
	}

	public void MIPHODFHOGJ(bool DOKMPEOLBGO)
	{
		JCMBGNIEDNB.Call("enableSound", DOKMPEOLBGO);
	}

	public void AIJCJPAPNCP(OneSignal.NDNHJFICCIA KACNEFJPIPK)
	{
		JCMBGNIEDNB.Call("setInFocusDisplaying", (int)KACNEFJPIPK);
	}

	public void NNNGBMJPBDG(bool DOKMPEOLBGO)
	{
		JCMBGNIEDNB.Call("setSubscription", DOKMPEOLBGO);
	}

	public void DHJLPDPDNEB(Dictionary<string, object> MBBPBGHKLJM)
	{
		JCMBGNIEDNB.Call("postNotification", DINBABILEHB.LFIJNCAPDMO(MBBPBGHKLJM));
	}

	public void FFEJJJNDGDH(string HCMFNNPEKDN)
	{
		JCMBGNIEDNB.Call("syncHashedEmail", HCMFNNPEKDN);
	}

	public void HBHFHKNLPEN()
	{
		JCMBGNIEDNB.Call("promptLocation");
	}

	public void GHBDDIGJLBL()
	{
		JCMBGNIEDNB.Call("clearOneSignalNotifications");
	}

	public void COEAOFJJANM()
	{
		JCMBGNIEDNB.Call("addPermissionObserver");
	}

	public void IJKJFPJHFHD()
	{
		JCMBGNIEDNB.Call("removePermissionObserver");
	}

	public void BFFJKLFFKBF()
	{
		JCMBGNIEDNB.Call("addSubscriptionObserver");
	}

	public void PFCFFFLDMDE()
	{
		JCMBGNIEDNB.Call("removeSubscriptionObserver");
	}

	public void CDFIEJNIDEA()
	{
		JCMBGNIEDNB.Call("addEmailSubscriptionObserver");
	}

	public void JJBOHMCEBPH()
	{
		JCMBGNIEDNB.Call("removeEmailSubscriptionObserver");
	}

	public void GBJHBBFCFHG(bool JCDGKPPFIMO)
	{
		JCMBGNIEDNB.Call("provideUserConsent", JCDGKPPFIMO);
	}

	public bool CDPNAOABJOF()
	{
		return JCMBGNIEDNB.Call<bool>("userProvidedPrivacyConsent", new object[0]);
	}

	public void DDJHDBCEMLC(bool HBEHEELHKLP)
	{
		JCMBGNIEDNB.Call("setRequiresUserPrivacyConsent", HBEHEELHKLP);
	}

	public AMLCGIGPHEJ IIDINNBDNLD()
	{
		return CIOFLCIJOHK.FCBGBJMGMBD(this, JCMBGNIEDNB.Call<string>("getPermissionSubscriptionState", new object[0]));
	}

	public MIKPOELFDIL GMBFGDFNDHL(string ACLJCOPJFJF)
	{
		return CIOFLCIJOHK.GMBFGDFNDHL(this, ACLJCOPJFJF);
	}

	public OAEFFLGOHEC HBJBJGILCLI(string ACLJCOPJFJF)
	{
		return CIOFLCIJOHK.HBJBJGILCLI(this, ACLJCOPJFJF);
	}

	public EJJOFNDGMNL HILMODDJFFC(string HIFJGDEFPOF)
	{
		return CIOFLCIJOHK.HILMODDJFFC(this, HIFJGDEFPOF);
	}

	public OCFGDKAAKAM EFHCBOFFHGG(object NDPDAGBHBMI)
	{
		Dictionary<string, object> dictionary = NDPDAGBHBMI as Dictionary<string, object>;
		OCFGDKAAKAM oCFGDKAAKAM = new OCFGDKAAKAM();
		oCFGDKAAKAM.PHOBPMLPLGI = true;
		bool flag = Convert.ToBoolean(dictionary["enabled"]);
		oCFGDKAAKAM.ODCADGABBHJ = ((!flag) ? NLCGGECDOMA.Denied : NLCGGECDOMA.Authorized);
		return oCFGDKAAKAM;
	}

	public ANEMLFEAJAP LFODGFFOCOP(object NDPDAGBHBMI)
	{
		Dictionary<string, object> dictionary = NDPDAGBHBMI as Dictionary<string, object>;
		ANEMLFEAJAP aNEMLFEAJAP = new ANEMLFEAJAP();
		aNEMLFEAJAP.NNBBIPPCJKC = Convert.ToBoolean(dictionary["subscribed"]);
		aNEMLFEAJAP.CNJFCNKLILN = Convert.ToBoolean(dictionary["userSubscriptionSetting"]);
		aNEMLFEAJAP.BPKJLGJDFKG = dictionary["userId"] as string;
		aNEMLFEAJAP.IEOMNLGGALD = dictionary["pushToken"] as string;
		return aNEMLFEAJAP;
	}

	public DPEOGFEJGPI BPMPMJAFDMC(object NDPDAGBHBMI)
	{
		Dictionary<string, object> dictionary = NDPDAGBHBMI as Dictionary<string, object>;
		DPEOGFEJGPI dPEOGFEJGPI = new DPEOGFEJGPI();
		dPEOGFEJGPI.NNBBIPPCJKC = Convert.ToBoolean(dictionary["subscribed"]);
		dPEOGFEJGPI.KJPGAGILMAJ = dictionary["emailUserId"] as string;
		dPEOGFEJGPI.JOCELKPFDNK = dictionary["emailAddress"] as string;
		return dPEOGFEJGPI;
	}

	public void MABLPNJIOMF(string HCMFNNPEKDN, string DCGGIMJEMGH)
	{
		JCMBGNIEDNB.Call("setEmail", HCMFNNPEKDN, DCGGIMJEMGH);
	}

	public void MABLPNJIOMF(string HCMFNNPEKDN)
	{
		JCMBGNIEDNB.Call("setEmail", HCMFNNPEKDN, null);
	}

	public void NFGIGGCADPP()
	{
		JCMBGNIEDNB.Call("logoutEmail");
	}
}
