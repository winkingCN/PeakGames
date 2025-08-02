using System.Collections.Generic;
using Assets.Scripts.SceneTransitions;
using Assets.Scripts.Utils;
using caravan.protobuf.messages;

public class HEJJIOFDJFH : NADPOFCHCON
{
	public static bool NIBANLIALFA;

	private readonly GetEventsResponseMessage DJFBBNDIKED;

	private readonly bool JPAFOCDDHPM;

	private readonly int IBHDKBDNCMG;

	public HEJJIOFDJFH(GetEventsResponseMessage OMJOIIOONMO, IKDMCJPBBIH KAGBOIDKAED, GBJNCLLOCJB KFNJHBPIHOI, bool FGIHCMCJBPN, int EAIKCEDMGCP)
		: base(KAGBOIDKAED, KFNJHBPIHOI)
	{
		IBHDKBDNCMG = EAIKCEDMGCP;
		DJFBBNDIKED = OMJOIIOONMO;
		JPAFOCDDHPM = FGIHCMCJBPN;
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
		NIBANLIALFA = false;
		LAPDNLIDHEG.GABGKBAKHDP.CAEIHKPAAKE(DJFBBNDIKED.events);
		AAPMDEEMEMM aAPMDEEMEMM = DGOMNDMPMBG.GABGKBAKHDP.BHGCBNAMEFK;
		if (GFHPEDILAJG.GABGKBAKHDP.ODMCGBLJFKM && aAPMDEEMEMM != null && aAPMDEEMEMM.OPBAEEEGPDE == null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TCGetStatusCommand will be called because a new event is received.");
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
			{
				new IOCEEPMIBLN(LECPGNKOABP.GABGKBAKHDP.OADDPGNIINO, aAPMDEEMEMM.IFOAAOCJODG, JPAFOCDDHPM)
			});
		}
		else if (JPAFOCDDHPM)
		{
			NIBANLIALFA = true;
		}
	}
}
