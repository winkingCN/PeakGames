using System;
using Assets.Scripts.Utils;
using caravan.protobuf.messages;

public class CLFGECOMHHE : NADPOFCHCON
{
	private readonly InventoryMetaData KDOHOANPJGF;

	private readonly Action DJPNBGABBOI;

	private readonly SyncInventoryResponseMessage MDHMNDJKOKP;

	private readonly int IBHDKBDNCMG;

	public CLFGECOMHHE(NCHDJAAJNIG KAGBOIDKAED, GBJNCLLOCJB OJCKIOENBEL, SyncInventoryResponseMessage DIDHNNMKJFE, InventoryMetaData GLHECJGALEP, int EAIKCEDMGCP, Action GPLIOLJFDPM)
		: base(KAGBOIDKAED, OJCKIOENBEL)
	{
		KDOHOANPJGF = GLHECJGALEP;
		DJPNBGABBOI = GPLIOLJFDPM;
		MDHMNDJKOKP = DIDHNNMKJFE;
		IBHDKBDNCMG = EAIKCEDMGCP;
	}

	protected override GBJNCLLOCJB BMMMAFJBJMD()
	{
		return (IBHDKBDNCMG != FocusListener.MOGJKPIEGGL) ? GBJNCLLOCJB.ClientNotInSameFocus : GBJNCLLOCJB.ResultSuccess;
	}

	public override void JLECFJEAFCD()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SyncInventoryReply, "Inventory Reply Success");
		PJPPADHKGHN.GABGKBAKHDP.BOLHHAJPKMH(MDHMNDJKOKP.unlimitedLife, false);
		OIAJPMNJGLK.FCNGEIHAGIB(MDHMNDJKOKP.serverTime);
		if (NCHDJAAJNIG.OPKHPMCHKOD(KDOHOANPJGF))
		{
			GEBAAFFGKJG.GABGKBAKHDP.PKIMELKEMAN();
		}
		if (DJPNBGABBOI != null)
		{
			DJPNBGABBOI();
		}
	}

	public override void AIGOFKAJFBM()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SyncInventoryReply, "Inventory Reply Failed");
		if (DJPNBGABBOI != null)
		{
			DJPNBGABBOI();
		}
	}
}
