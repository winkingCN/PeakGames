using Assets.Scripts.Utils.Analytics;
using ToonSocial;

public static class COLFLCFNKKL
{
	public static void CDOOPEMANMI(bool HECCOJJEGCN)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ConnectToFacebookCommand, "Applying re-init operation.");
		if (HECCOJJEGCN)
		{
			LECPGNKOABP.GABGKBAKHDP.IIAEIGEFCEN();
		}
		PPGOIFOCOAK.FBANJNDJEOG();
	}

	public static bool BIPHGBLNELE(long GBAFKHKFOOP, string MEBHMGHGLAL, string BBFINPBOBOE, string MOOILKBFHLC, bool HECCOJJEGCN)
	{
		LECPGNKOABP lECPGNKOABP = LECPGNKOABP.GABGKBAKHDP;
		long num = lECPGNKOABP.GDMECFECCOM;
		bool result = false;
		bool flag = GBAFKHKFOOP != num;
		if (flag)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ConnectToFacebookCommand, "User Id is changed. Old:{0} New:{1}", num, GBAFKHKFOOP);
			if (num != 0)
			{
				CDOOPEMANMI(HECCOJJEGCN);
				result = true;
			}
		}
		lECPGNKOABP.GDMECFECCOM = GBAFKHKFOOP;
		lECPGNKOABP.FIPPLABNDON = MEBHMGHGLAL;
		lECPGNKOABP.EHNKLBBAKCA = BBFINPBOBOE;
		lECPGNKOABP.KMHPHBJCPJH = MOOILKBFHLC;
		lECPGNKOABP.LEOJICDDHHF = null;
		lECPGNKOABP.EDHAJCFFACD();
		CAGBGIHKHEJ.GABGKBAKHDP.EOCDBIHEMJM(lECPGNKOABP.GDMECFECCOM.ToString());
		PeakAnalytics.UpdateAdjustSessionParameters();
		OneSignal.SendTag("FacebookId", BBFINPBOBOE);
		OneSignal.SendTag("UserIdTag", lECPGNKOABP.GDMECFECCOM.ToString());
		EIMPOHFHFMO.GBPHBJEJODP();
		if (flag)
		{
			SocialHelper.RefreshUser();
		}
		return result;
	}
}
