using System;
using Assets.Scripts.Utils.Analytics;
using UnityEngine;

public static class EIMPOHFHFMO
{
	public static void GBPHBJEJODP(bool BNOMLEDAFJI = false)
	{
		try
		{
			long num = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
			PeakAnalytics.SetApplicationUserId(num);
			NHNBFBDHKGN.AJDNJDFOGOH(num.ToString());
			NAAGDFCLOPE.GABGKBAKHDP.BINDEBHMEJC.MPDFGODOLAF();
			if (!BNOMLEDAFJI)
			{
				KIIMLFPJHHD.JEBHHLBDPCF(num);
				PlayerPrefs.DeleteKey("LastDeviceId");
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.UserIdHelper, "Exception on userId change Error:{0} Stack:{1}", ex.Message, ex.StackTrace);
		}
	}
}
