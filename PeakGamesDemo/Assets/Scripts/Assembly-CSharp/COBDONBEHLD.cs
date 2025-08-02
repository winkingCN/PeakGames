using System;
using Assets.Scripts.Utils;
using caravan.protobuf.messages;

public class COBDONBEHLD : NADPOFCHCON
{
	private readonly GetInfoResponseMessage DJFBBNDIKED;

	private readonly int IBHDKBDNCMG;

	private readonly Action<bool> JCOKJJGCPHI;

	public COBDONBEHLD(Action<bool> IMHLFAHONPP, GetInfoResponseMessage OMJOIIOONMO, IKDMCJPBBIH KAGBOIDKAED, GBJNCLLOCJB KFNJHBPIHOI, int EAIKCEDMGCP)
		: base(KAGBOIDKAED, KFNJHBPIHOI)
	{
		JCOKJJGCPHI = IMHLFAHONPP;
		IBHDKBDNCMG = EAIKCEDMGCP;
		DJFBBNDIKED = OMJOIIOONMO;
	}

	protected override GBJNCLLOCJB BMMMAFJBJMD()
	{
		return (IBHDKBDNCMG != FocusListener.MOGJKPIEGGL) ? GBJNCLLOCJB.ClientNotInSameFocus : GBJNCLLOCJB.ResultSuccess;
	}

	public override void AIGOFKAJFBM()
	{
		HNKNJHMAIOG();
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(false);
		}
	}

	public override void JLECFJEAFCD()
	{
		IMLNKMACKMF.GABGKBAKHDP.IDHKACACBNG(DJFBBNDIKED);
		DJFEHCGIDGC.GABGKBAKHDP.HCJIILJLEJB(DJFBBNDIKED.dailyBonus == 1);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Bonus, "Calendar: Duration: {0}, NextDuration: {1}, Step: {2}", DJFBBNDIKED.calendarDuration, DJFBBNDIKED.calendarNextDuration, DJFBBNDIKED.calendarStep);
		bool oMJOIIOONMO = DJFBBNDIKED.calendarDuration >= 0 && DJFBBNDIKED.calendarStep > 0;
		BPPNANHCLJI.GABGKBAKHDP.OBHDNHDPFGG(oMJOIIOONMO, DJFBBNDIKED.calendarStep, DJFBBNDIKED.calendarDuration);
		HNKNJHMAIOG();
		DJFEHCGIDGC.GABGKBAKHDP.GOEPBLOOFNN();
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(true);
		}
	}

	private static void HNKNJHMAIOG()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.GetServerInfoReply, "Check force update, currentVersion:{0} forceMinVersion:{1}", "4161", IMLNKMACKMF.GABGKBAKHDP.BCDBJPFBCFJ);
		int result = 0;
		int result2 = 0;
		int.TryParse("4161", out result2);
		int.TryParse(IMLNKMACKMF.GABGKBAKHDP.BCDBJPFBCFJ, out result);
		if (result2 < result)
		{
			NAAGDFCLOPE.GABGKBAKHDP.BNJIGCHGOAJ();
		}
		else
		{
			NAAGDFCLOPE.GABGKBAKHDP.EHHCGDDCFML();
		}
	}
}
