using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using com.adjust.sdk;
using net.peakgames.analytics;

namespace Assets.Scripts.Utils.Analytics
{
	public class PeakAnalytics : MonoBehaviour
	{
		private const string LJBCENEGHFC = "da3a78e5252b45d0eb33f16428654913";

		private const PeakAnalyticsMode PFCAEKIMNGO = PeakAnalyticsMode.Production;

		private const string KNFADJCBFLC = "InstallDate";

		private const string CJMEOKLKPLG = "DaysRetention";

		public static string SessionId;

		private static string ICJALFBPDOG;

		private static GameObject EJGCPDINNIC;

		private static DateTime PHOIDHNFECK;

		public static Action OnDeviceIdReceived;

		private static string JLGIJGBIKNF;

		[CompilerGenerated]
		private static AdvertisingIdReceivedCallback JANLDOMIIEF;

		public static AnalyticsFacade LOPFOEHECGB { get; private set; }

		public static string CGFKMDLHNHP { get; private set; }

		public static bool NDODOKFECKE { get; private set; }

		public static void SendD1Level25()
		{
			try
			{
				CDGPEOIFNEI();
				if (DateTime.UtcNow.Subtract(PHOIDHNFECK).TotalHours < 48.0)
				{
					DJFPMCMLPJJ.JMHBLDGOOCD();
					NFDHFOAMOCD.ABKFAIDPPOA(25);
				}
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.PeakAnalytics, "Error Updating D1 Levels Error:" + ex.Message + " Stack:" + ex.StackTrace);
			}
		}

		public static void SendRetentionEvents()
		{
			try
			{
				CDGPEOIFNEI();
				HJBLKNBHMFJ hJBLKNBHMFJ = HJBLKNBHMFJ.GABGKBAKHDP;
				double totalHours = DateTime.UtcNow.Subtract(PHOIDHNFECK).TotalHours;
				if (totalHours >= 96.0)
				{
					return;
				}
				string text = hJBLKNBHMFJ.LIANKDMAHFM("DaysRetention", string.Empty);
				if (totalHours >= 24.0 && totalHours < 48.0 && text.Length == 0)
				{
					DJFPMCMLPJJ.FFKDBKDOJEJ();
					hJBLKNBHMFJ.JGMDDMNGDJO("DaysRetention", text + 1);
				}
				else if (totalHours >= 48.0 && totalHours < 72.0 && text.Length == 1)
				{
					hJBLKNBHMFJ.JGMDDMNGDJO("DaysRetention", text + 1);
				}
				else if (totalHours >= 72.0 && totalHours < 96.0 && text.Length < 3)
				{
					DJFPMCMLPJJ.HFKPGFGHEAK();
					if (text.Length == 2)
					{
						DJFPMCMLPJJ.CEKGGBMNANA();
					}
					hJBLKNBHMFJ.JGMDDMNGDJO("DaysRetention", text + 111);
				}
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.PeakAnalytics, "Error sending retention to Adjust Error:" + ex.Message + " Stack:" + ex.StackTrace);
			}
		}

		private static void CDGPEOIFNEI()
		{
			if (PHOIDHNFECK.Year <= 1)
			{
				string s = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("InstallDate");
				long result;
				long.TryParse(s, out result);
				PHOIDHNFECK = FIBJIOBINHL.IIDMAMGMAAA(result);
			}
		}

		public static string GetDeviceId()
		{
			if (JLGIJGBIKNF != null)
			{
				return JLGIJGBIKNF;
			}
			JLGIJGBIKNF = LOPFOEHECGB.GetDeviceId();
			if (JLGIJGBIKNF.Equals(string.Empty) || JLGIJGBIKNF.Equals("0") || JLGIJGBIKNF.Equals("00") || JLGIJGBIKNF.Equals("00000000") || JLGIJGBIKNF.Equals("0000000000000000") || JLGIJGBIKNF.Equals("0000000000000202"))
			{
				JLGIJGBIKNF = CGFKMDLHNHP;
				if (string.IsNullOrEmpty(JLGIJGBIKNF))
				{
					JLGIJGBIKNF = LOPFOEHECGB.GetAnalyticsUserId();
					if (string.IsNullOrEmpty(JLGIJGBIKNF))
					{
						JLGIJGBIKNF = Guid.NewGuid().ToString();
					}
				}
			}
			return JLGIJGBIKNF;
		}

		public static string GetSharedId()
		{
			return LOPFOEHECGB.GetSharedDeviceId();
		}

		public static void Init()
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PeakAnalytics, "Peak Analytics Inited");
			string text = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("InstallDate");
			if (text == null)
			{
				PHOIDHNFECK = DateTime.UtcNow;
				string eDDNOJDPMCF = (PHOIDHNFECK.GMEBBNOHJFJ() * 1000).ToString();
				HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("InstallDate", eDDNOJDPMCF);
			}
			SendD1Level25();
			if (EJGCPDINNIC == null)
			{
				EJGCPDINNIC = new GameObject("Peak Analytics");
				EJGCPDINNIC.AddComponent<PeakAnalytics>().JIMBAPGACIJ();
				UnityEngine.Object.DontDestroyOnLoad(EJGCPDINNIC);
			}
			UpdateSessionId();
			if (LOPFOEHECGB != null)
			{
				LOPFOEHECGB.SetOffline();
			}
			StartAnalytics();
			AFJPGLHKOID.BAMKBCHHLGP();
			if (LOPFOEHECGB != null)
			{
				LOPFOEHECGB.SendDeviceInfo(ICJALFBPDOG);
				long num = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
				if (num > 0)
				{
					LOPFOEHECGB.SetApplicationUserId(num);
				}
				else
				{
					LOPFOEHECGB.ResetApplicationUserId();
				}
			}
			else
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.PeakAnalytics, "Cannot send CPU and Adjust Login event because Facade is null");
			}
			new LLCJMMBBLEH(DDLMDLFBFDL(), true, IAJNLGPHGLO.App);
		}

		private static IEnumerator DDLMDLFBFDL()
		{
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			while (Time.realtimeSinceStartup - realtimeSinceStartup < 1f && (LOPFOEHECGB == null || LOPFOEHECGB.GetAnalyticsUserId() == null || LOPFOEHECGB.GetAnalyticsUserId().Equals(string.Empty)))
			{
				yield return MCJHHDACJBG.CNDGGNLKOOC;
			}
			LEDKLDFPGBO();
			realtimeSinceStartup = Time.realtimeSinceStartup;
			while (Time.realtimeSinceStartup - realtimeSinceStartup < 1f && (LOPFOEHECGB == null || CGFKMDLHNHP == null))
			{
				yield return MCJHHDACJBG.CNDGGNLKOOC;
			}
			if (OnDeviceIdReceived != null)
			{
				OnDeviceIdReceived();
				OnDeviceIdReceived = null;
			}
		}

		private static void LEDKLDFPGBO()
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PeakAnalytics, "Adjust Login sent with AnalyticsUserId:{0}", LOPFOEHECGB.GetAnalyticsUserId());
			Adjust.addSessionCallbackParameter("device_id", MJJHFBBMHAO.CJENHJMDHFN(GetDeviceId()));
			UpdateAdjustSessionParameters();
			EJGCPDINNIC.AddComponent<Adjust>().PrepareAwake();
			DJFPMCMLPJJ.JMJBMFODBLO(LOPFOEHECGB.GetAnalyticsUserId());
			if (LECPGNKOABP.GABGKBAKHDP != null && LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM != 0)
			{
				DJFPMCMLPJJ.MKHCFGLBCCD(LOPFOEHECGB.GetAnalyticsUserId(), LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString());
			}
		}

		public static void UpdateAdjustSessionParameters()
		{
			Adjust.removeSessionCallbackParameter("s");
			Adjust.removeSessionCallbackParameter("user_id");
			Adjust.addSessionCallbackParameter("s", LOPFOEHECGB.GetAnalyticsUserId());
			Adjust.addSessionCallbackParameter("user_id", LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString());
		}

		public static void StartAnalytics()
		{
			if (LOPFOEHECGB == null)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.PeakAnalytics, "Trying to start but Facade is not ready!");
				return;
			}
			NDODOKFECKE = true;
			ICJALFBPDOG = JsonUtility.ToJson(new JsonCpu());
			LOPFOEHECGB.StartPeakAPISession("da3a78e5252b45d0eb33f16428654913", PeakAnalyticsMode.Production);
			AFJPGLHKOID.LLAHEOHDBJD();
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PeakAnalytics, "Peak Analytics Started.");
		}

		public static void StopAnalytics()
		{
			if (LOPFOEHECGB == null)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.PeakAnalytics, "Trying to stop but Facade is not ready!");
				return;
			}
			NDODOKFECKE = false;
			LOPFOEHECGB.StopSession();
		}

		public static void SetOnlineStatus(bool OEBDKHBBPGK)
		{
			if (LOPFOEHECGB != null)
			{
				if (OEBDKHBBPGK)
				{
					LOPFOEHECGB.SetOnline();
				}
				else
				{
					LOPFOEHECGB.SetOffline();
				}
			}
		}

		public static void UpdateSessionId()
		{
			SessionId = Guid.NewGuid().ToString();
		}

		private void JIMBAPGACIJ()
		{
			LOPFOEHECGB = AnalyticsFacade.Instance;
			LOPFOEHECGB.OnAdvertisingIdReceived += JOFACKOHHPK;
			LOPFOEHECGB.RequestAdvertisingId();
		}

		private static void JOFACKOHHPK(string PJOHFCIOMDA)
		{
			CGFKMDLHNHP = PJOHFCIOMDA;
		}

		public static void SetApplicationUserId(long BPKJLGJDFKG)
		{
			if (LOPFOEHECGB != null)
			{
				LOPFOEHECGB.SetApplicationUserId(BPKJLGJDFKG);
			}
		}

		public static void ResetApplicationUserId()
		{
			if (LOPFOEHECGB != null)
			{
				LOPFOEHECGB.ResetApplicationUserId();
			}
		}

		public static void ClearData()
		{
			LOPFOEHECGB.ClearData();
		}
	}
}
