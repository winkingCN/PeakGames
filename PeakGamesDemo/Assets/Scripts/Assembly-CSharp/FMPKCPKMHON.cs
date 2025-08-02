using System;
using Assets.Scripts.SceneTransitions;
using Assets.Scripts.Utils;
using caravan.protobuf.messages;

public class FMPKCPKMHON : NADPOFCHCON
{
	private readonly TtStatusResponseMessage DJFBBNDIKED;

	private readonly Action<bool> JCOKJJGCPHI;

	private readonly int IBHDKBDNCMG;

	private readonly long GODKDOHOHCD;

	public FMPKCPKMHON(TtStatusResponseMessage OMJOIIOONMO, long GCKOBKBPOBE, Action<bool> IMHLFAHONPP, IKDMCJPBBIH KAGBOIDKAED, GBJNCLLOCJB KFNJHBPIHOI, int EAIKCEDMGCP)
		: base(KAGBOIDKAED, KFNJHBPIHOI)
	{
		DJFBBNDIKED = OMJOIIOONMO;
		JCOKJJGCPHI = IMHLFAHONPP;
		IBHDKBDNCMG = EAIKCEDMGCP;
		GODKDOHOHCD = GCKOBKBPOBE;
	}

	protected override GBJNCLLOCJB BMMMAFJBJMD()
	{
		if (IBHDKBDNCMG != FocusListener.MOGJKPIEGGL)
		{
			return GBJNCLLOCJB.ClientNotInSameFocus;
		}
		if (CaravanSceneManager.CurrentScene != GKBHIKONCKJ.Map && CaravanSceneManager.SceneToBeLoaded != GKBHIKONCKJ.Map)
		{
			return GBJNCLLOCJB.ClientNotInSameScene;
		}
		return GBJNCLLOCJB.ResultSuccess;
	}

	public override void JLECFJEAFCD()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TtGetStatusCommand {0} - {1} - {2} - {3} - {4}", DJFBBNDIKED.status, DJFBBNDIKED.groupId, DJFBBNDIKED.teamId, DJFBBNDIKED.claimed, DJFBBNDIKED.disabled);
		KCKDNJOMPJH kCKDNJOMPJH = DGOMNDMPMBG.GABGKBAKHDP.FABKMFCBELE;
		if (kCKDNJOMPJH == null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TtGetStatusCommand no team tournament event exists.");
			CECMINAKHFJ(false);
		}
		else if (DJFBBNDIKED.status == 0)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TtGetStatusCommand received status error.");
			kCKDNJOMPJH.GPOIALPCEJK();
			CECMINAKHFJ(false);
		}
		else if (DJFBBNDIKED.status == 4)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TtGetStatusCommand team tournament status is throttled.");
			kCKDNJOMPJH.LIMGCDCOMAJ();
			CECMINAKHFJ(false);
		}
		else if (GODKDOHOHCD != kCKDNJOMPJH.IFOAAOCJODG)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TtGetStatusCommand status is for previous event: {0} / {1}", GODKDOHOHCD, kCKDNJOMPJH.IFOAAOCJODG);
			CECMINAKHFJ(false);
		}
		else
		{
			kCKDNJOMPJH.ADIMEEPIFBL(DJFBBNDIKED);
			CECMINAKHFJ(true);
		}
	}

	public override void AIGOFKAJFBM()
	{
		CECMINAKHFJ(false);
	}

	private void CECMINAKHFJ(bool EEKJMDHEJCK)
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(EEKJMDHEJCK);
		}
	}
}
