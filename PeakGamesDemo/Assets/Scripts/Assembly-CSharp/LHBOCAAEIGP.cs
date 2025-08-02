using System.Collections.Generic;
using UnityEngine;

public class LHBOCAAEIGP : FGGOGJLHPHD, IBODGFKAHLF
{
	private AndroidJavaClass ELOJNJAKIHB;

	private AndroidJavaObject OEMDDIPEAGE;

	private AndroidJavaObject HPEHEKHNMCM;

	private AndroidJavaObject EFHHEPAKCPD;

	private AndroidJavaObject GEHCCNCCJOJ;

	private AndroidJavaClass CNLPCMDLJKP;

	private GDPPIIMADKC HBFNDEEAHBJ;

	public LHBOCAAEIGP()
	{
		ELOJNJAKIHB = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		OEMDDIPEAGE = ELOJNJAKIHB.GetStatic<AndroidJavaObject>("currentActivity");
		HPEHEKHNMCM = OEMDDIPEAGE.Call<AndroidJavaObject>("getApplication", new object[0]);
		CNLPCMDLJKP = new AndroidJavaClass("com.helpshift.supportCampaigns.UnityAPIDelegate");
		NLPADEFLHIA.FFKACBMBNNP().GINHNILIDHL("support", this);
		NCHNJANOADK.FFKACBMBNNP().NAAGKIKAGPB(this, HPEHEKHNMCM);
		HBFNDEEAHBJ = GDPPIIMADKC.FFKACBMBNNP();
	}

	private void BKHOBOAKMAJ(string CNKJPAGKAMJ, params object[] MIDCNFGAIFA)
	{
		HDFCIAJHNAE("unityHSApiCallWithArgs", CNKJPAGKAMJ, MIDCNFGAIFA);
	}

	private void INILLGJPNFJ(string CNKJPAGKAMJ, params object[] MIDCNFGAIFA)
	{
		HDFCIAJHNAE("hsApiCallWithArgs", CNKJPAGKAMJ, MIDCNFGAIFA);
	}

	private void INILLGJPNFJ(string CNKJPAGKAMJ)
	{
		HDFCIAJHNAE("hsApiCall", CNKJPAGKAMJ, null);
	}

	private void DMELFHFELJK(string CNKJPAGKAMJ, params object[] MIDCNFGAIFA)
	{
		HDFCIAJHNAE("hsSupportApiCallWithArgs", CNKJPAGKAMJ, MIDCNFGAIFA);
	}

	private void DMELFHFELJK(string CNKJPAGKAMJ)
	{
		HDFCIAJHNAE("hsSupportApiCall", CNKJPAGKAMJ, null);
	}

	private void HDFCIAJHNAE(string JMHBADGAFLN, string CNKJPAGKAMJ, object[] MIDCNFGAIFA)
	{
		NLPADEFLHIA.FFKACBMBNNP().HOGHHPKJOKC("support", JMHBADGAFLN, CNKJPAGKAMJ, MIDCNFGAIFA);
	}

	public void HDDMNMIHBKC(string JMHBADGAFLN, string CNKJPAGKAMJ, object[] MIDCNFGAIFA)
	{
		if (JMHBADGAFLN.Equals("hsApiCallWithArgs"))
		{
			EFHHEPAKCPD.CallStatic(CNKJPAGKAMJ, MIDCNFGAIFA);
		}
		else if (JMHBADGAFLN.Equals("hsApiCall"))
		{
			EFHHEPAKCPD.CallStatic(CNKJPAGKAMJ);
		}
		else if (JMHBADGAFLN.Equals("hsSupportApiCallWithArgs"))
		{
			GEHCCNCCJOJ.CallStatic(CNKJPAGKAMJ, MIDCNFGAIFA);
		}
		else if (JMHBADGAFLN.Equals("hsSupportApiCall"))
		{
			GEHCCNCCJOJ.CallStatic(CNKJPAGKAMJ);
		}
		else if (JMHBADGAFLN.Equals("unityHSApiCallWithArgs"))
		{
			CNLPCMDLJKP.CallStatic(CNKJPAGKAMJ, MIDCNFGAIFA);
		}
	}

	public void GJGLBDBCJCL()
	{
		EFHHEPAKCPD = NCHNJANOADK.FFKACBMBNNP().PKHBBNLFKHK().CallStatic<AndroidJavaObject>("getHelpshiftUnityAPIInstance", new object[0]);
		GEHCCNCCJOJ = NCHNJANOADK.FFKACBMBNNP().PKHBBNLFKHK().CallStatic<AndroidJavaObject>("getHelpshiftSupportInstance", new object[0]);
	}

	public void NNGPBLGDBFG(string PKBMMGJLBFP, string PBLMDIMOLIC, string LIHABAIIMFD, Dictionary<string, object> MOMNKLKOBKO)
	{
		MOMNKLKOBKO.Add("sdkType", "unity");
		MOMNKLKOBKO.Add("pluginVersion", "3.0.0");
		MOMNKLKOBKO.Add("runtimeVersion", Application.unityVersion);
		string text = LGONDFDHPFD.LFIJNCAPDMO(MOMNKLKOBKO);
		INILLGJPNFJ("install", HPEHEKHNMCM, PKBMMGJLBFP, PBLMDIMOLIC, LIHABAIIMFD, text);
		HBFNDEEAHBJ.ELNCCDELMMH("Install called  : ApiKey : " + PKBMMGJLBFP + ", Domain :" + PBLMDIMOLIC + ", AppId: " + LIHABAIIMFD + ", Config : " + text);
	}

	public void NNGPBLGDBFG()
	{
		INILLGJPNFJ("install", HPEHEKHNMCM);
		HBFNDEEAHBJ.ELNCCDELMMH("Install called without config");
	}

	public int DGKIDDLECOM(bool KBBEIEPJJLG)
	{
		NLPADEFLHIA.FFKACBMBNNP().BGONEKPEOJC();
		HBFNDEEAHBJ.ELNCCDELMMH("Call getNotificationCount: isAsync : " + KBBEIEPJJLG);
		return EFHHEPAKCPD.CallStatic<int>("getNotificationCount", new object[1] { KBBEIEPJJLG });
	}

	public void IJCFKPNEKBP(bool KBBEIEPJJLG)
	{
		HBFNDEEAHBJ.ELNCCDELMMH("Call requestUnreadMessagesCount: isAsync : " + KBBEIEPJJLG);
		INILLGJPNFJ("requestUnreadMessagesCount", KBBEIEPJJLG);
	}

	public void MMIFDJIHPKN(string KBKKPLBKLNA, string HCMFNNPEKDN)
	{
		INILLGJPNFJ("setNameAndEmail", KBKKPLBKLNA, HCMFNNPEKDN);
	}

	public void HGCEHFNLLAG(string GMBNJCKNOBD)
	{
		INILLGJPNFJ("setUserIdentifier", GMBNJCKNOBD);
	}

	public void GIPAOONBAPG(string AOCAIMFMJBI)
	{
		HBFNDEEAHBJ.ELNCCDELMMH("Register device token :" + AOCAIMFMJBI);
		INILLGJPNFJ("registerDeviceToken", OEMDDIPEAGE, AOCAIMFMJBI);
	}

	public void POIKCNPGIJH(string GDONFHPGPBL)
	{
		INILLGJPNFJ("leaveBreadCrumb", GDONFHPGPBL);
	}

	public void EMFEDJHILOO()
	{
		INILLGJPNFJ("clearBreadCrumbs");
	}

	public void PDAGIHKGIOM(string GMBNJCKNOBD, string KBKKPLBKLNA, string HCMFNNPEKDN)
	{
		HBFNDEEAHBJ.ELNCCDELMMH("Login called : " + KBKKPLBKLNA);
		INILLGJPNFJ("login", GMBNJCKNOBD, KBKKPLBKLNA, HCMFNNPEKDN);
	}

	public void HFEPMPBBJDK()
	{
		INILLGJPNFJ("logout");
	}

	public void JDOEPIMFLEH(Dictionary<string, object> MOMNKLKOBKO)
	{
		INILLGJPNFJ("showConversationUnity", OEMDDIPEAGE, LGONDFDHPFD.LFIJNCAPDMO(EMGKPFFEAGG(MOMNKLKOBKO)));
	}

	public void AHMEKKJBGGP(string NHKNFIKPFHJ, Dictionary<string, object> MOMNKLKOBKO)
	{
		INILLGJPNFJ("showFAQSectionUnity", OEMDDIPEAGE, NHKNFIKPFHJ, LGONDFDHPFD.LFIJNCAPDMO(EMGKPFFEAGG(MOMNKLKOBKO)));
	}

	public void AMDGDJHLFFA(string AEFPDBLCJHA, Dictionary<string, object> MOMNKLKOBKO)
	{
		INILLGJPNFJ("showSingleFAQUnity", OEMDDIPEAGE, AEFPDBLCJHA, LGONDFDHPFD.LFIJNCAPDMO(EMGKPFFEAGG(MOMNKLKOBKO)));
	}

	public void JCJJEFGELBM(Dictionary<string, object> MOMNKLKOBKO)
	{
		INILLGJPNFJ("showFAQsUnity", OEMDDIPEAGE, LGONDFDHPFD.LFIJNCAPDMO(EMGKPFFEAGG(MOMNKLKOBKO)));
	}

	public void JDOEPIMFLEH()
	{
		INILLGJPNFJ("showConversationUnity", OEMDDIPEAGE, null);
	}

	public void AHMEKKJBGGP(string NHKNFIKPFHJ)
	{
		INILLGJPNFJ("showFAQSectionUnity", OEMDDIPEAGE, NHKNFIKPFHJ, null);
	}

	public void AMDGDJHLFFA(string AEFPDBLCJHA)
	{
		INILLGJPNFJ("showSingleFAQUnity", OEMDDIPEAGE, AEFPDBLCJHA, null);
	}

	public void JCJJEFGELBM()
	{
		INILLGJPNFJ("showFAQsUnity", OEMDDIPEAGE, null);
	}

	public void FPAANMKDDII(Dictionary<string, object> MOMNKLKOBKO)
	{
		INILLGJPNFJ("showConversationWithMetaUnity", OEMDDIPEAGE, LGONDFDHPFD.LFIJNCAPDMO(EMGKPFFEAGG(MOMNKLKOBKO)));
	}

	public void NJKMEGINCMH(string NHKNFIKPFHJ, Dictionary<string, object> MOMNKLKOBKO)
	{
		INILLGJPNFJ("showFAQSectionWithMetaUnity", OEMDDIPEAGE, NHKNFIKPFHJ, LGONDFDHPFD.LFIJNCAPDMO(EMGKPFFEAGG(MOMNKLKOBKO)));
	}

	public void OLGEAMBKDKC(string AEFPDBLCJHA, Dictionary<string, object> MOMNKLKOBKO)
	{
		INILLGJPNFJ("showSingleFAQWithMetaUnity", OEMDDIPEAGE, AEFPDBLCJHA, LGONDFDHPFD.LFIJNCAPDMO(EMGKPFFEAGG(MOMNKLKOBKO)));
	}

	public void CDGFCPKHAOL(Dictionary<string, object> MOMNKLKOBKO)
	{
		INILLGJPNFJ("showFAQsWithMetaUnity", OEMDDIPEAGE, LGONDFDHPFD.LFIJNCAPDMO(EMGKPFFEAGG(MOMNKLKOBKO)));
	}

	public void PLLEHNFAOLF(Dictionary<string, object> HEHBDBOGGJL)
	{
		INILLGJPNFJ("setMetaData", LGONDFDHPFD.LFIJNCAPDMO(HEHBDBOGGJL));
	}

	private Dictionary<string, object> EMGKPFFEAGG(Dictionary<string, object> MOMNKLKOBKO)
	{
		if (MOMNKLKOBKO.ContainsKey("customIssueFields"))
		{
			MOMNKLKOBKO["hs-custom-issue-field"] = MOMNKLKOBKO["customIssueFields"];
			MOMNKLKOBKO.Remove("customIssueFields");
		}
		return MOMNKLKOBKO;
	}

	public void KDMMAFEGBCA(string PHBFIHKLPKO)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add("issue_id", PHBFIHKLPKO);
		HBFNDEEAHBJ.ELNCCDELMMH("Handle push notification : issueId " + PHBFIHKLPKO);
		KDMMAFEGBCA(dictionary);
	}

	public void KDMMAFEGBCA(Dictionary<string, object> OBHPOBLBHCM)
	{
		HBFNDEEAHBJ.ELNCCDELMMH("Handle push notification : data :" + OBHPOBLBHCM.ToString());
		BKHOBOAKMAJ("handlePush", OEMDDIPEAGE, LGONDFDHPFD.LFIJNCAPDMO(OBHPOBLBHCM));
	}

	public void AMDPOODECMK(string LNCBFPEKHDJ)
	{
		INILLGJPNFJ("showAlertToRateApp", LNCBFPEKHDJ);
	}

	public void IJIHEHCKMDE()
	{
		HBFNDEEAHBJ.ELNCCDELMMH("Registering delegates");
		INILLGJPNFJ("registerDelegates");
	}

	public void LFKJAAMKOBP(string KNLNKIGKOIP)
	{
		HBFNDEEAHBJ.ELNCCDELMMH("Registering for push notification : GCM ID : " + KNLNKIGKOIP);
		INILLGJPNFJ("registerGcmKey", KNLNKIGKOIP, OEMDDIPEAGE);
	}

	public void OONGLKCNEPJ(string JGDCPMDBMBD)
	{
		INILLGJPNFJ("setSDKLanguage", JGDCPMDBMBD);
	}

	public void GOONIFNEAPN(string FCEEGNFABAF, Dictionary<string, object>[] PBBFIAHAKCG)
	{
		INILLGJPNFJ("showDynamicFormFromDataJson", OEMDDIPEAGE, FCEEGNFABAF, LGONDFDHPFD.LFIJNCAPDMO(PBBFIAHAKCG));
	}

	public bool BJAGFFNHMOL()
	{
		NLPADEFLHIA.FFKACBMBNNP().BGONEKPEOJC();
		return GEHCCNCCJOJ.CallStatic<bool>("isConversationActive", new object[0]);
	}

	public void DPOMBKDCCBA()
	{
		EFHHEPAKCPD.CallStatic("checkIfConversationActive");
	}

	public void MPFKABENODH()
	{
		HBFNDEEAHBJ.ELNCCDELMMH("onApplicationQuit");
		NLPADEFLHIA.FFKACBMBNNP().MPFKABENODH();
	}
}
