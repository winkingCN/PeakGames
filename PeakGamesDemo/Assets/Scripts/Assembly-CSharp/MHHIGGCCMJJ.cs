using Assets.Scripts.SceneTransitions;
using Assets.Scripts.Utils;
using NewMapScene;
using caravan.protobuf.messages;

public class MHHIGGCCMJJ : NADPOFCHCON
{
	private readonly TcStatusResponseMessage DJFBBNDIKED;

	private readonly bool JPAFOCDDHPM;

	private readonly int IBHDKBDNCMG;

	public MHHIGGCCMJJ(TcStatusResponseMessage OMJOIIOONMO, IKDMCJPBBIH KAGBOIDKAED, GBJNCLLOCJB KFNJHBPIHOI, bool FGIHCMCJBPN, int EAIKCEDMGCP)
		: base(KAGBOIDKAED, KFNJHBPIHOI)
	{
		DJFBBNDIKED = OMJOIIOONMO;
		JPAFOCDDHPM = FGIHCMCJBPN;
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
		if (DJFBBNDIKED == null || DJFBBNDIKED.teamInfo == null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TcGetStatusCommand unexpected response received.");
			BJLCGFBBLOH();
			return;
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TcGetStatusCommand {0} - {1} - {2}/{3} for team {4}/{5}", DJFBBNDIKED.eventId, DJFBBNDIKED.status, DJFBBNDIKED.progress, DJFBBNDIKED.target, DJFBBNDIKED.teamInfo.id, DJFBBNDIKED.teamInfo.name);
		if (DJFBBNDIKED.status == 0)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TCGetStatusCommand received status error.");
			BJLCGFBBLOH();
			return;
		}
		AAPMDEEMEMM aAPMDEEMEMM = DGOMNDMPMBG.GABGKBAKHDP.BHGCBNAMEFK;
		if (aAPMDEEMEMM == null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TcGetStatusCommand no team chest event exists.");
			BJLCGFBBLOH();
		}
		else
		{
			aAPMDEEMEMM.NMBAAHJEPGB(DJFBBNDIKED);
			BJLCGFBBLOH();
		}
	}

	private void BJLCGFBBLOH()
	{
		if (JPAFOCDDHPM)
		{
			NewMapAnimationController.AddToFocusAnimations("TeamChestAnimation");
		}
	}
}
