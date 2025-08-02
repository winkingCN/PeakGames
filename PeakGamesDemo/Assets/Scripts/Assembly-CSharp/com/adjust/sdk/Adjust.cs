using System;
using UnityEngine;

namespace com.adjust.sdk
{
	public class Adjust : MonoBehaviour
	{
		private const string AKAMCOPOKIF = "Adjust: SDK can not be used in Editor.";

		private const string FPCIKBIBIOP = "Adjust: SDK not started. Start it manually using the 'start' method.";

		private const string LLONCNCFKFP = "Adjust: SDK can only be used in Android, iOS, Windows Phone 8.1, Windows Store or Universal Windows apps.";

		private bool PMMEPKLBJPE = true;

		private bool JNNINJBMPGO;

		private bool OGFJGBBEGOC;

		private bool BJPJJMDNLFN = true;

		private string DLBHDKFHPMF = "tzvvpv49aio0";

		public OCINAFLCMOD logLevel = OCINAFLCMOD.Info;

		public LBMNNDHMHOC environment;

		private static bool CGAACGEJPFN;

		public void PrepareAwake()
		{
			if (OCLBKDOFADM() || CGAACGEJPFN)
			{
				return;
			}
			CGAACGEJPFN = true;
			try
			{
				UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
				if (PMMEPKLBJPE)
				{
					LBMNNDHMHOC fABIICFNEKN = LBMNNDHMHOC.Production;
					MCOMPDEIMMJ mCOMPDEIMMJ = new MCOMPDEIMMJ(DLBHDKFHPMF, fABIICFNEKN, logLevel == OCINAFLCMOD.Suppress);
					mCOMPDEIMMJ.ENBPNHHGNJD(2L, 1560721734L, 1034690538L, 223121978L, 1435810638L);
					mCOMPDEIMMJ.JKFJEIHFNCE(logLevel);
					mCOMPDEIMMJ.KNEONHIHGKN(OGFJGBBEGOC);
					mCOMPDEIMMJ.JPGPMDPOEBH(JNNINJBMPGO);
					mCOMPDEIMMJ.DJCMBFAJFEA(BJPJJMDNLFN);
					start(mCOMPDEIMMJ);
				}
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Adjust, "Adjust Awake Error:{0} Stack{1}", ex.Message, ex.StackTrace);
			}
		}

		private void OnApplicationPause(bool APMMLLCMAKI)
		{
			if (!OCLBKDOFADM())
			{
				if (APMMLLCMAKI)
				{
					NPLJILMGKFF.PNFMNBAIDHA();
				}
				else
				{
					NPLJILMGKFF.NCBLKPHBGNH();
				}
			}
		}

		public static void start(MCOMPDEIMMJ DKEIBJHMFPH)
		{
			if (!OCLBKDOFADM())
			{
				if (DKEIBJHMFPH == null)
				{
					Debug.Log("Adjust: Missing config to start.");
				}
				else
				{
					NPLJILMGKFF.BAMKBCHHLGP(DKEIBJHMFPH);
				}
			}
		}

		public static void trackEvent(EHLDLBPDDCA PPNFFEBMCLH)
		{
			if (!OCLBKDOFADM())
			{
				if (PPNFFEBMCLH == null)
				{
					Debug.Log("Adjust: Missing event to track.");
				}
				else
				{
					NPLJILMGKFF.DNDAMIJBAJN(PPNFFEBMCLH);
				}
			}
		}

		public static void setEnabled(bool IEGIOBJMGKJ)
		{
			if (!OCLBKDOFADM())
			{
				NPLJILMGKFF.CBGHPOADKGA(IEGIOBJMGKJ);
			}
		}

		public static bool isEnabled()
		{
			if (OCLBKDOFADM())
			{
				return false;
			}
			return NPLJILMGKFF.FCIBLDEJAPL();
		}

		public static void setOfflineMode(bool IEGIOBJMGKJ)
		{
			if (!OCLBKDOFADM())
			{
				NPLJILMGKFF.NJJJMDBHALF(IEGIOBJMGKJ);
			}
		}

		public static void setDeviceToken(string AOCAIMFMJBI)
		{
			if (!OCLBKDOFADM())
			{
				NPLJILMGKFF.MMNBGBFJILH(AOCAIMFMJBI);
			}
		}

		public static void appWillOpenUrl(string LNCBFPEKHDJ)
		{
			if (!OCLBKDOFADM())
			{
				NPLJILMGKFF.CHLOMHGPDAF(LNCBFPEKHDJ);
			}
		}

		public static void sendFirstPackages()
		{
			if (!OCLBKDOFADM())
			{
				NPLJILMGKFF.MJGDPHEAAJI();
			}
		}

		public static void addSessionPartnerParameter(string IKNCPEPOKGJ, string EDDNOJDPMCF)
		{
			if (!OCLBKDOFADM())
			{
				NPLJILMGKFF.NBHNIFAGIJF(IKNCPEPOKGJ, EDDNOJDPMCF);
			}
		}

		public static void addSessionCallbackParameter(string IKNCPEPOKGJ, string EDDNOJDPMCF)
		{
			if (!OCLBKDOFADM())
			{
				NPLJILMGKFF.HOBJHDJLNCM(IKNCPEPOKGJ, EDDNOJDPMCF);
			}
		}

		public static void removeSessionPartnerParameter(string IKNCPEPOKGJ)
		{
			if (!OCLBKDOFADM())
			{
				NPLJILMGKFF.EECPAFPKDHH(IKNCPEPOKGJ);
			}
		}

		public static void removeSessionCallbackParameter(string IKNCPEPOKGJ)
		{
			if (!OCLBKDOFADM())
			{
				NPLJILMGKFF.CGCJBJDGCMM(IKNCPEPOKGJ);
			}
		}

		public static void resetSessionPartnerParameters()
		{
			if (!OCLBKDOFADM())
			{
				NPLJILMGKFF.EAOKELNKBNL();
			}
		}

		public static void resetSessionCallbackParameters()
		{
			if (!OCLBKDOFADM())
			{
				NPLJILMGKFF.EGOMKANPHOD();
			}
		}

		public static string getAdid()
		{
			if (OCLBKDOFADM())
			{
				return string.Empty;
			}
			return NPLJILMGKFF.IEACFDPPKPN();
		}

		public static EPJLEKACDBC getAttribution()
		{
			if (OCLBKDOFADM())
			{
				return null;
			}
			return NPLJILMGKFF.NLDNPDMMIKF();
		}

		public static string getWinAdid()
		{
			if (OCLBKDOFADM())
			{
				return string.Empty;
			}
			Debug.Log("Adjust: Error! Windows Advertising ID is not available on Android platform.");
			return string.Empty;
		}

		public static string getIdfa()
		{
			if (OCLBKDOFADM())
			{
				return string.Empty;
			}
			Debug.Log("Adjust: Error! IDFA is not available on Android platform.");
			return string.Empty;
		}

		[Obsolete("This method is intended for testing purposes only. Do not use it.")]
		public static void setReferrer(string MJIOMBCHMNO)
		{
			if (!OCLBKDOFADM())
			{
				NPLJILMGKFF.AIGGLALIJFL(MJIOMBCHMNO);
			}
		}

		public static void getGoogleAdId(Action<string> EFJECEHGEFI)
		{
			if (!OCLBKDOFADM())
			{
				NPLJILMGKFF.KAMAKEIJELC(EFJECEHGEFI);
			}
		}

		public static string getAmazonAdId()
		{
			if (OCLBKDOFADM())
			{
				return string.Empty;
			}
			return NPLJILMGKFF.PCIIBFCJAJG();
		}

		private static bool OCLBKDOFADM()
		{
			return false;
		}
	}
}
