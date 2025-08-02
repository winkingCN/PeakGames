using System;
using Assets.Scripts.SceneTransitions;
using Assets.Scripts.Utils;
using NewMapScene;
using caravan.protobuf.messages;

public class IPKMPAAECOA : NADPOFCHCON
{
	private readonly StStatusResponseMessage DJFBBNDIKED;

	private readonly Action<bool> JCOKJJGCPHI;

	private readonly int IBHDKBDNCMG;

	public IPKMPAAECOA(StStatusResponseMessage OMJOIIOONMO, Action<bool> IMHLFAHONPP, IKDMCJPBBIH KAGBOIDKAED, GBJNCLLOCJB KFNJHBPIHOI, int EAIKCEDMGCP)
		: base(KAGBOIDKAED, KFNJHBPIHOI)
	{
		DJFBBNDIKED = OMJOIIOONMO;
		JCOKJJGCPHI = IMHLFAHONPP;
		IBHDKBDNCMG = EAIKCEDMGCP;
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
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "StGetStatusCommand {0} - {1} - {2} - {3}", DJFBBNDIKED.status, DJFBBNDIKED.groupId, DJFBBNDIKED.rank, DJFBBNDIKED.members.Count);
		if (DJFBBNDIKED.status == 0)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "StGetStatusCommand received status error.");
			BJLCGFBBLOH(false);
			return;
		}
		GPAFPAEDOHM gPAFPAEDOHM = DGOMNDMPMBG.GABGKBAKHDP.IIEALLANECJ;
		if (gPAFPAEDOHM == null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "StGetStatusCommand no star tournament event exists.");
			BJLCGFBBLOH(false);
		}
		else if (DJFBBNDIKED.status == 4)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "StGetStatusCommand star tournament status is throttled.");
			gPAFPAEDOHM.LIMGCDCOMAJ();
			BJLCGFBBLOH(false);
		}
		else
		{
			gPAFPAEDOHM.ADIMEEPIFBL(DJFBBNDIKED);
			BJLCGFBBLOH(true);
		}
	}

	public override void AIGOFKAJFBM()
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(false);
		}
	}

	private void BJLCGFBBLOH(bool EEKJMDHEJCK)
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(EEKJMDHEJCK);
		}
		if (HEJJIOFDJFH.NIBANLIALFA)
		{
			NewMapAnimationController.AddToFocusAnimations("StarTournamentAnimation");
		}
		HEJJIOFDJFH.NIBANLIALFA = false;
	}
}
