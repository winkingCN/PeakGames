using System;
using UnityEngine;

public class NPLJILMGKFF
{
	private class ELEMHFLNILP : AndroidJavaProxy
	{
		private Action<EPJLEKACDBC> HNJJMFOGAMG;

		public ELEMHFLNILP(Action<EPJLEKACDBC> CHMJFDILGBO)
			: base("com.adjust.sdk.OnAttributionChangedListener")
		{
			HNJJMFOGAMG = CHMJFDILGBO;
		}

		public void LNPJLGODOPG(AndroidJavaObject BJHNFFFICMP)
		{
			if (HNJJMFOGAMG != null)
			{
				EPJLEKACDBC ePJLEKACDBC = new EPJLEKACDBC();
				ePJLEKACDBC.MHJFGFFKMDN = BJHNFFFICMP.Get<string>(FMKNBJCOMGF.JNAJIAIFPFO);
				ePJLEKACDBC.CDIJADNMACH = BJHNFFFICMP.Get<string>(FMKNBJCOMGF.CKIGHBBPIBO);
				ePJLEKACDBC.LKGJHPGEONH = BJHNFFFICMP.Get<string>(FMKNBJCOMGF.ICEALDCHDDP);
				ePJLEKACDBC.FFCCMNJHFCB = BJHNFFFICMP.Get<string>(FMKNBJCOMGF.LAAJOJGGLBP);
				ePJLEKACDBC.GHNGJPDEKMJ = BJHNFFFICMP.Get<string>(FMKNBJCOMGF.LMMHMOKHGHC);
				ePJLEKACDBC.BDBPLJLNDMO = BJHNFFFICMP.Get<string>(FMKNBJCOMGF.HNEOICBLBNP);
				ePJLEKACDBC.CJJFCOAOOME = BJHNFFFICMP.Get<string>(FMKNBJCOMGF.JEGJCNKCDKF);
				ePJLEKACDBC.PJOHFCIOMDA = BJHNFFFICMP.Get<string>(FMKNBJCOMGF.IKIHDNHNJMH);
				HNJJMFOGAMG(ePJLEKACDBC);
			}
		}
	}

	private class JHDANMPOCDN : AndroidJavaProxy
	{
		private Action<string> HNJJMFOGAMG;

		public JHDANMPOCDN(Action<string> CHMJFDILGBO)
			: base("com.adjust.sdk.OnDeeplinkResponseListener")
		{
			HNJJMFOGAMG = CHMJFDILGBO;
		}

		public bool OCNIFBJLMLN(AndroidJavaObject EEILFPNFIOD)
		{
			if (HNJJMFOGAMG == null)
			{
				return BJPJJMDNLFN;
			}
			string obj = EEILFPNFIOD.Call<string>("toString", new object[0]);
			HNJJMFOGAMG(obj);
			return BJPJJMDNLFN;
		}
	}

	private class GIIJGABLMAB : AndroidJavaProxy
	{
		private Action<GJONJCCECNK> HNJJMFOGAMG;

		public GIIJGABLMAB(Action<GJONJCCECNK> CHMJFDILGBO)
			: base("com.adjust.sdk.OnEventTrackingSucceededListener")
		{
			HNJJMFOGAMG = CHMJFDILGBO;
		}

		public void CCPPIALGJJB(AndroidJavaObject LBJAHBIBIJK)
		{
			if (HNJJMFOGAMG != null && LBJAHBIBIJK != null)
			{
				GJONJCCECNK gJONJCCECNK = new GJONJCCECNK();
				gJONJCCECNK.NKKEKBHCFFF = LBJAHBIBIJK.Get<string>(FMKNBJCOMGF.IKIHDNHNJMH);
				gJONJCCECNK.HKCNCCIAMEL = LBJAHBIBIJK.Get<string>(FMKNBJCOMGF.LIDJAANKHHG);
				gJONJCCECNK.BCJMJBCPCML = LBJAHBIBIJK.Get<string>(FMKNBJCOMGF.NMCEFJHKBMH);
				gJONJCCECNK.BEEBMOHHKJO = LBJAHBIBIJK.Get<string>(FMKNBJCOMGF.IEGLOEAAAKC);
				try
				{
					AndroidJavaObject androidJavaObject = LBJAHBIBIJK.Get<AndroidJavaObject>(FMKNBJCOMGF.GLHPCCFHMGA);
					string iPBFAAFEJBC = androidJavaObject.Call<string>("toString", new object[0]);
					gJONJCCECNK.IMMACHKDLEC(iPBFAAFEJBC);
				}
				catch (Exception)
				{
				}
				HNJJMFOGAMG(gJONJCCECNK);
			}
		}
	}

	private class NFHBKLAKMEO : AndroidJavaProxy
	{
		private Action<IIGNELNPHML> HNJJMFOGAMG;

		public NFHBKLAKMEO(Action<IIGNELNPHML> CHMJFDILGBO)
			: base("com.adjust.sdk.OnEventTrackingFailedListener")
		{
			HNJJMFOGAMG = CHMJFDILGBO;
		}

		public void NDAAMOAHCNC(AndroidJavaObject HBCPKEEKDNJ)
		{
			if (HNJJMFOGAMG != null && HBCPKEEKDNJ != null)
			{
				IIGNELNPHML iIGNELNPHML = new IIGNELNPHML();
				iIGNELNPHML.NKKEKBHCFFF = HBCPKEEKDNJ.Get<string>(FMKNBJCOMGF.IKIHDNHNJMH);
				iIGNELNPHML.HKCNCCIAMEL = HBCPKEEKDNJ.Get<string>(FMKNBJCOMGF.LIDJAANKHHG);
				iIGNELNPHML.APGADMJLPNI = HBCPKEEKDNJ.Get<bool>(FMKNBJCOMGF.KAMLHHLKLFA);
				iIGNELNPHML.BCJMJBCPCML = HBCPKEEKDNJ.Get<string>(FMKNBJCOMGF.NMCEFJHKBMH);
				iIGNELNPHML.BEEBMOHHKJO = HBCPKEEKDNJ.Get<string>(FMKNBJCOMGF.IEGLOEAAAKC);
				try
				{
					AndroidJavaObject androidJavaObject = HBCPKEEKDNJ.Get<AndroidJavaObject>(FMKNBJCOMGF.GLHPCCFHMGA);
					string iPBFAAFEJBC = androidJavaObject.Call<string>("toString", new object[0]);
					iIGNELNPHML.IMMACHKDLEC(iPBFAAFEJBC);
				}
				catch (Exception)
				{
				}
				HNJJMFOGAMG(iIGNELNPHML);
			}
		}
	}

	private class MDJJEHDFLBP : AndroidJavaProxy
	{
		private Action<DIAELPNNMEH> HNJJMFOGAMG;

		public MDJJEHDFLBP(Action<DIAELPNNMEH> CHMJFDILGBO)
			: base("com.adjust.sdk.OnSessionTrackingSucceededListener")
		{
			HNJJMFOGAMG = CHMJFDILGBO;
		}

		public void LDCJEJBJHIK(AndroidJavaObject DGLHLHCGEJF)
		{
			if (HNJJMFOGAMG != null && DGLHLHCGEJF != null)
			{
				DIAELPNNMEH dIAELPNNMEH = new DIAELPNNMEH();
				dIAELPNNMEH.NKKEKBHCFFF = DGLHLHCGEJF.Get<string>(FMKNBJCOMGF.IKIHDNHNJMH);
				dIAELPNNMEH.HKCNCCIAMEL = DGLHLHCGEJF.Get<string>(FMKNBJCOMGF.LIDJAANKHHG);
				dIAELPNNMEH.BCJMJBCPCML = DGLHLHCGEJF.Get<string>(FMKNBJCOMGF.NMCEFJHKBMH);
				try
				{
					AndroidJavaObject androidJavaObject = DGLHLHCGEJF.Get<AndroidJavaObject>(FMKNBJCOMGF.GLHPCCFHMGA);
					string iPBFAAFEJBC = androidJavaObject.Call<string>("toString", new object[0]);
					dIAELPNNMEH.IMMACHKDLEC(iPBFAAFEJBC);
				}
				catch (Exception)
				{
				}
				HNJJMFOGAMG(dIAELPNNMEH);
			}
		}
	}

	private class ELFJOHBMJPC : AndroidJavaProxy
	{
		private Action<LOHACGBPPIN> HNJJMFOGAMG;

		public ELFJOHBMJPC(Action<LOHACGBPPIN> CHMJFDILGBO)
			: base("com.adjust.sdk.OnSessionTrackingFailedListener")
		{
			HNJJMFOGAMG = CHMJFDILGBO;
		}

		public void GCLOAPDLNBN(AndroidJavaObject FKPOFACLBJG)
		{
			if (HNJJMFOGAMG != null && FKPOFACLBJG != null)
			{
				LOHACGBPPIN lOHACGBPPIN = new LOHACGBPPIN();
				lOHACGBPPIN.NKKEKBHCFFF = FKPOFACLBJG.Get<string>(FMKNBJCOMGF.IKIHDNHNJMH);
				lOHACGBPPIN.HKCNCCIAMEL = FKPOFACLBJG.Get<string>(FMKNBJCOMGF.LIDJAANKHHG);
				lOHACGBPPIN.APGADMJLPNI = FKPOFACLBJG.Get<bool>(FMKNBJCOMGF.KAMLHHLKLFA);
				lOHACGBPPIN.BCJMJBCPCML = FKPOFACLBJG.Get<string>(FMKNBJCOMGF.NMCEFJHKBMH);
				try
				{
					AndroidJavaObject androidJavaObject = FKPOFACLBJG.Get<AndroidJavaObject>(FMKNBJCOMGF.GLHPCCFHMGA);
					string iPBFAAFEJBC = androidJavaObject.Call<string>("toString", new object[0]);
					lOHACGBPPIN.IMMACHKDLEC(iPBFAAFEJBC);
				}
				catch (Exception)
				{
				}
				HNJJMFOGAMG(lOHACGBPPIN);
			}
		}
	}

	private class FMDLNPDGAOD : AndroidJavaProxy
	{
		private Action<string> DODDBDNELJA;

		public FMDLNPDGAOD(Action<string> CHMJFDILGBO)
			: base("com.adjust.sdk.OnDeviceIdsRead")
		{
			DODDBDNELJA = CHMJFDILGBO;
		}

		public void FIGFDOHGIEB(string PLDAOJDJODM)
		{
			if (DODDBDNELJA != null)
			{
				DODDBDNELJA(PLDAOJDJODM);
			}
		}

		public void FIGFDOHGIEB(AndroidJavaObject HBCNJFNLGNN)
		{
			if (HBCNJFNLGNN == null)
			{
				string pLDAOJDJODM = null;
				FIGFDOHGIEB(pLDAOJDJODM);
			}
			else
			{
				FIGFDOHGIEB(HBCNJFNLGNN.Call<string>("toString", new object[0]));
			}
		}
	}

	private const string OAKFKCHJIHD = "unity4.12.5";

	private static bool BJPJJMDNLFN = true;

	private static AndroidJavaClass PINCLBDOLBE = new AndroidJavaClass("com.adjust.sdk.Adjust");

	private static AndroidJavaObject BDBFBPLJGBJ = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");

	private static JHDANMPOCDN BDHELKNLAGN;

	private static ELEMHFLNILP BLECDCGGLDC;

	private static NFHBKLAKMEO JOGLLMEALDC;

	private static GIIJGABLMAB LBBNAJFMBCH;

	private static ELFJOHBMJPC FPJHBCNIKBG;

	private static MDJJEHDFLBP POLEPFPFNNI;

	public static void BAMKBCHHLGP(MCOMPDEIMMJ DKEIBJHMFPH)
	{
		AndroidJavaObject androidJavaObject = ((DKEIBJHMFPH.FABIICFNEKN != 0) ? new AndroidJavaClass("com.adjust.sdk.AdjustConfig").GetStatic<AndroidJavaObject>("ENVIRONMENT_PRODUCTION") : new AndroidJavaClass("com.adjust.sdk.AdjustConfig").GetStatic<AndroidJavaObject>("ENVIRONMENT_SANDBOX"));
		bool? dMHNNOMDNGA = DKEIBJHMFPH.DMHNNOMDNGA;
		AndroidJavaObject androidJavaObject2 = ((!dMHNNOMDNGA.HasValue) ? new AndroidJavaObject("com.adjust.sdk.AdjustConfig", BDBFBPLJGBJ, DKEIBJHMFPH.DLBHDKFHPMF, androidJavaObject) : new AndroidJavaObject("com.adjust.sdk.AdjustConfig", BDBFBPLJGBJ, DKEIBJHMFPH.DLBHDKFHPMF, androidJavaObject, DKEIBJHMFPH.DMHNNOMDNGA));
		BJPJJMDNLFN = DKEIBJHMFPH.BJPJJMDNLFN;
		OCINAFLCMOD? pDGNEDBOGLE = DKEIBJHMFPH.PDGNEDBOGLE;
		if (pDGNEDBOGLE.HasValue)
		{
			AndroidJavaObject androidJavaObject3 = ((!DKEIBJHMFPH.PDGNEDBOGLE.Value.CGEDGGABGBN().Equals("SUPPRESS")) ? new AndroidJavaClass("com.adjust.sdk.LogLevel").GetStatic<AndroidJavaObject>(DKEIBJHMFPH.PDGNEDBOGLE.Value.CGEDGGABGBN()) : new AndroidJavaClass("com.adjust.sdk.LogLevel").GetStatic<AndroidJavaObject>("SUPRESS"));
			if (androidJavaObject3 != null)
			{
				androidJavaObject2.Call("setLogLevel", androidJavaObject3);
			}
		}
		double? nPHGJJEMLIE = DKEIBJHMFPH.NPHGJJEMLIE;
		if (nPHGJJEMLIE.HasValue)
		{
			androidJavaObject2.Call("setDelayStart", DKEIBJHMFPH.NPHGJJEMLIE);
		}
		bool? aCEBOEBPPIG = DKEIBJHMFPH.ACEBOEBPPIG;
		if (aCEBOEBPPIG.HasValue)
		{
			AndroidJavaObject androidJavaObject4 = new AndroidJavaObject("java.lang.Boolean", DKEIBJHMFPH.ACEBOEBPPIG.Value);
			androidJavaObject2.Call("setEventBufferingEnabled", androidJavaObject4);
		}
		bool? oGFJGBBEGOC = DKEIBJHMFPH.OGFJGBBEGOC;
		if (oGFJGBBEGOC.HasValue)
		{
			androidJavaObject2.Call("setSendInBackground", DKEIBJHMFPH.OGFJGBBEGOC.Value);
		}
		if (DKEIBJHMFPH.BACPOLKIMMO != null)
		{
			androidJavaObject2.Call("setUserAgent", DKEIBJHMFPH.BACPOLKIMMO);
		}
		if (!string.IsNullOrEmpty(DKEIBJHMFPH.BFHJLOILJBB))
		{
			androidJavaObject2.Call("setProcessName", DKEIBJHMFPH.BFHJLOILJBB);
		}
		if (DKEIBJHMFPH.CPGMDMICEHF != null)
		{
			androidJavaObject2.Call("setDefaultTracker", DKEIBJHMFPH.CPGMDMICEHF);
		}
		if (DKEIBJHMFPH.FENOBIPNFIM != null)
		{
			BLECDCGGLDC = new ELEMHFLNILP(DKEIBJHMFPH.FENOBIPNFIM);
			androidJavaObject2.Call("setOnAttributionChangedListener", BLECDCGGLDC);
		}
		if (DKEIBJHMFPH.EFIDHMEDFIC != null)
		{
			LBBNAJFMBCH = new GIIJGABLMAB(DKEIBJHMFPH.EFIDHMEDFIC);
			androidJavaObject2.Call("setOnEventTrackingSucceededListener", LBBNAJFMBCH);
		}
		if (DKEIBJHMFPH.DHLBHGJEOIE != null)
		{
			JOGLLMEALDC = new NFHBKLAKMEO(DKEIBJHMFPH.DHLBHGJEOIE);
			androidJavaObject2.Call("setOnEventTrackingFailedListener", JOGLLMEALDC);
		}
		if (DKEIBJHMFPH.DEKCEOHFMMJ != null)
		{
			POLEPFPFNNI = new MDJJEHDFLBP(DKEIBJHMFPH.DEKCEOHFMMJ);
			androidJavaObject2.Call("setOnSessionTrackingSucceededListener", POLEPFPFNNI);
		}
		if (DKEIBJHMFPH.KNPBJDGKNFC != null)
		{
			FPJHBCNIKBG = new ELFJOHBMJPC(DKEIBJHMFPH.KNPBJDGKNFC);
			androidJavaObject2.Call("setOnSessionTrackingFailedListener", FPJHBCNIKBG);
		}
		if (DKEIBJHMFPH.DPEHODMADMM != null)
		{
			BDHELKNLAGN = new JHDANMPOCDN(DKEIBJHMFPH.DPEHODMADMM);
			androidJavaObject2.Call("setOnDeeplinkResponseListener", BDHELKNLAGN);
		}
		androidJavaObject2.Call("setSdkPrefix", "unity4.12.5");
		if (BFOLGHDIBMK(DKEIBJHMFPH))
		{
			androidJavaObject2.Call("setAppSecret", DKEIBJHMFPH.NHHEJLHLGOG.Value, DKEIBJHMFPH.LCPEEGNIPCL.Value, DKEIBJHMFPH.PHJKNJFJDGO.Value, DKEIBJHMFPH.NACBFDKLBMD.Value, DKEIBJHMFPH.ACDAJFEKFKG.Value);
		}
		if (DKEIBJHMFPH.EAOFBGOOBEH.HasValue)
		{
			androidJavaObject2.Call("setDeviceKnown", DKEIBJHMFPH.EAOFBGOOBEH.Value);
		}
		if (DKEIBJHMFPH.LHLKJJEGABB.HasValue)
		{
			androidJavaObject2.Call("setReadMobileEquipmentIdentity", DKEIBJHMFPH.LHLKJJEGABB.Value);
		}
		PINCLBDOLBE.CallStatic("onCreate", androidJavaObject2);
		PINCLBDOLBE.CallStatic("onResume");
	}

	public static void DNDAMIJBAJN(EHLDLBPDDCA PPNFFEBMCLH)
	{
		AndroidJavaObject androidJavaObject = new AndroidJavaObject("com.adjust.sdk.AdjustEvent", PPNFFEBMCLH.BCBPCIDMPKH);
		double? cLJGNAOABFP = PPNFFEBMCLH.CLJGNAOABFP;
		if (cLJGNAOABFP.HasValue)
		{
			object[] array = new object[2];
			double? cLJGNAOABFP2 = PPNFFEBMCLH.CLJGNAOABFP;
			array[0] = cLJGNAOABFP2.Value;
			array[1] = PPNFFEBMCLH.FMGPCBJLMDF;
			androidJavaObject.Call("setRevenue", array);
		}
		if (PPNFFEBMCLH.DGIKNAGBEKB != null)
		{
			for (int i = 0; i < PPNFFEBMCLH.DGIKNAGBEKB.Count; i += 2)
			{
				string text = PPNFFEBMCLH.DGIKNAGBEKB[i];
				string text2 = PPNFFEBMCLH.DGIKNAGBEKB[i + 1];
				androidJavaObject.Call("addCallbackParameter", text, text2);
			}
		}
		if (PPNFFEBMCLH.BICOOJBKIGD != null)
		{
			for (int j = 0; j < PPNFFEBMCLH.BICOOJBKIGD.Count; j += 2)
			{
				string text3 = PPNFFEBMCLH.BICOOJBKIGD[j];
				string text4 = PPNFFEBMCLH.BICOOJBKIGD[j + 1];
				androidJavaObject.Call("addPartnerParameter", text3, text4);
			}
		}
		if (PPNFFEBMCLH.LFCPPDHKCOA != null)
		{
			androidJavaObject.Call("setOrderId", PPNFFEBMCLH.LFCPPDHKCOA);
		}
		PINCLBDOLBE.CallStatic("trackEvent", androidJavaObject);
	}

	public static bool FCIBLDEJAPL()
	{
		return PINCLBDOLBE.CallStatic<bool>("isEnabled", new object[0]);
	}

	public static void CBGHPOADKGA(bool IEGIOBJMGKJ)
	{
		PINCLBDOLBE.CallStatic("setEnabled", IEGIOBJMGKJ);
	}

	public static void NJJJMDBHALF(bool IEGIOBJMGKJ)
	{
		PINCLBDOLBE.CallStatic("setOfflineMode", IEGIOBJMGKJ);
	}

	public static void MJGDPHEAAJI()
	{
		PINCLBDOLBE.CallStatic("sendFirstPackages");
	}

	public static void MMNBGBFJILH(string AOCAIMFMJBI)
	{
		PINCLBDOLBE.CallStatic("setPushToken", AOCAIMFMJBI);
	}

	public static string IEACFDPPKPN()
	{
		return PINCLBDOLBE.CallStatic<string>("getAdid", new object[0]);
	}

	public static EPJLEKACDBC NLDNPDMMIKF()
	{
		try
		{
			AndroidJavaObject androidJavaObject = PINCLBDOLBE.CallStatic<AndroidJavaObject>("getAttribution", new object[0]);
			if (androidJavaObject == null)
			{
				return null;
			}
			EPJLEKACDBC ePJLEKACDBC = new EPJLEKACDBC();
			ePJLEKACDBC.MHJFGFFKMDN = androidJavaObject.Get<string>(FMKNBJCOMGF.JNAJIAIFPFO);
			ePJLEKACDBC.CDIJADNMACH = androidJavaObject.Get<string>(FMKNBJCOMGF.CKIGHBBPIBO);
			ePJLEKACDBC.LKGJHPGEONH = androidJavaObject.Get<string>(FMKNBJCOMGF.ICEALDCHDDP);
			ePJLEKACDBC.FFCCMNJHFCB = androidJavaObject.Get<string>(FMKNBJCOMGF.LAAJOJGGLBP);
			ePJLEKACDBC.GHNGJPDEKMJ = androidJavaObject.Get<string>(FMKNBJCOMGF.LMMHMOKHGHC);
			ePJLEKACDBC.BDBPLJLNDMO = androidJavaObject.Get<string>(FMKNBJCOMGF.HNEOICBLBNP);
			ePJLEKACDBC.CJJFCOAOOME = androidJavaObject.Get<string>(FMKNBJCOMGF.JEGJCNKCDKF);
			ePJLEKACDBC.PJOHFCIOMDA = androidJavaObject.Get<string>(FMKNBJCOMGF.IKIHDNHNJMH);
			return ePJLEKACDBC;
		}
		catch (Exception)
		{
		}
		return null;
	}

	public static void NBHNIFAGIJF(string IKNCPEPOKGJ, string EDDNOJDPMCF)
	{
		if (PINCLBDOLBE == null)
		{
			PINCLBDOLBE = new AndroidJavaClass("com.adjust.sdk.Adjust");
		}
		PINCLBDOLBE.CallStatic("addSessionPartnerParameter", IKNCPEPOKGJ, EDDNOJDPMCF);
	}

	public static void HOBJHDJLNCM(string IKNCPEPOKGJ, string EDDNOJDPMCF)
	{
		if (PINCLBDOLBE == null)
		{
			PINCLBDOLBE = new AndroidJavaClass("com.adjust.sdk.Adjust");
		}
		PINCLBDOLBE.CallStatic("addSessionCallbackParameter", IKNCPEPOKGJ, EDDNOJDPMCF);
	}

	public static void EECPAFPKDHH(string IKNCPEPOKGJ)
	{
		if (PINCLBDOLBE == null)
		{
			PINCLBDOLBE = new AndroidJavaClass("com.adjust.sdk.Adjust");
		}
		PINCLBDOLBE.CallStatic("removeSessionPartnerParameter", IKNCPEPOKGJ);
	}

	public static void CGCJBJDGCMM(string IKNCPEPOKGJ)
	{
		if (PINCLBDOLBE == null)
		{
			PINCLBDOLBE = new AndroidJavaClass("com.adjust.sdk.Adjust");
		}
		PINCLBDOLBE.CallStatic("removeSessionCallbackParameter", IKNCPEPOKGJ);
	}

	public static void EAOKELNKBNL()
	{
		if (PINCLBDOLBE == null)
		{
			PINCLBDOLBE = new AndroidJavaClass("com.adjust.sdk.Adjust");
		}
		PINCLBDOLBE.CallStatic("resetSessionPartnerParameters");
	}

	public static void EGOMKANPHOD()
	{
		if (PINCLBDOLBE == null)
		{
			PINCLBDOLBE = new AndroidJavaClass("com.adjust.sdk.Adjust");
		}
		PINCLBDOLBE.CallStatic("resetSessionCallbackParameters");
	}

	public static void PNFMNBAIDHA()
	{
		PINCLBDOLBE.CallStatic("onPause");
	}

	public static void NCBLKPHBGNH()
	{
		PINCLBDOLBE.CallStatic("onResume");
	}

	public static void AIGGLALIJFL(string MJIOMBCHMNO)
	{
		PINCLBDOLBE.CallStatic("setReferrer", MJIOMBCHMNO);
	}

	public static void KAMAKEIJELC(Action<string> EFJECEHGEFI)
	{
		FMDLNPDGAOD fMDLNPDGAOD = new FMDLNPDGAOD(EFJECEHGEFI);
		PINCLBDOLBE.CallStatic("getGoogleAdId", BDBFBPLJGBJ, fMDLNPDGAOD);
	}

	public static void CHLOMHGPDAF(string LNCBFPEKHDJ)
	{
		AndroidJavaClass androidJavaClass = new AndroidJavaClass("android.net.Uri");
		AndroidJavaObject androidJavaObject = androidJavaClass.CallStatic<AndroidJavaObject>("parse", new object[1] { LNCBFPEKHDJ });
		PINCLBDOLBE.CallStatic("appWillOpenUrl", androidJavaObject);
	}

	public static string PCIIBFCJAJG()
	{
		return PINCLBDOLBE.CallStatic<string>("getAmazonAdId", new object[1] { BDBFBPLJGBJ });
	}

	private static bool BFOLGHDIBMK(MCOMPDEIMMJ DKEIBJHMFPH)
	{
		return DKEIBJHMFPH.NHHEJLHLGOG.HasValue && DKEIBJHMFPH.LCPEEGNIPCL.HasValue && DKEIBJHMFPH.PHJKNJFJDGO.HasValue && DKEIBJHMFPH.NACBFDKLBMD.HasValue && DKEIBJHMFPH.ACDAJFEKFKG.HasValue;
	}
}
