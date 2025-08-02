using System;
using Assets.Scripts.SceneTransitions;
using caravan.protobuf.messages;

public class OLEDNCOIDPI : NADPOFCHCON
{
	private readonly Action<bool> JCOKJJGCPHI;

	private readonly GetTeamLeaderboardResponseMessage DJFBBNDIKED;

	public OLEDNCOIDPI(Action<bool> IMHLFAHONPP, GetTeamLeaderboardResponseMessage OMJOIIOONMO, IKDMCJPBBIH KAGBOIDKAED, GBJNCLLOCJB KFNJHBPIHOI)
		: base(KAGBOIDKAED, KFNJHBPIHOI)
	{
		JCOKJJGCPHI = IMHLFAHONPP;
		DJFBBNDIKED = OMJOIIOONMO;
	}

	protected override GBJNCLLOCJB BMMMAFJBJMD()
	{
		return (CaravanSceneManager.CurrentScene != GKBHIKONCKJ.Map) ? GBJNCLLOCJB.ClientNotInSameScene : GBJNCLLOCJB.ResultSuccess;
	}

	public override void JLECFJEAFCD()
	{
		if (DJFBBNDIKED != null && DJFBBNDIKED.teamList != null)
		{
			HLFNMNPLJCP.GABGKBAKHDP.ADIMEEPIFBL(DJFBBNDIKED);
		}
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(true);
		}
	}

	public override void AIGOFKAJFBM()
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(false);
		}
	}
}
