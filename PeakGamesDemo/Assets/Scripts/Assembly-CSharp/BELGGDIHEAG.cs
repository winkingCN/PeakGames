using System;
using Assets.Scripts.SceneTransitions;
using caravan.protobuf.messages;

public class BELGGDIHEAG : NADPOFCHCON
{
	private readonly Action<bool> JCOKJJGCPHI;

	private readonly GetPlayersLeaderboardResponseMessage DJFBBNDIKED;

	public BELGGDIHEAG(Action<bool> IMHLFAHONPP, GetPlayersLeaderboardResponseMessage OMJOIIOONMO, IKDMCJPBBIH KAGBOIDKAED, GBJNCLLOCJB KFNJHBPIHOI)
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
		if (DJFBBNDIKED != null && DJFBBNDIKED.leaderboard != null)
		{
			FIFPLICICKP.GABGKBAKHDP.ADIMEEPIFBL(DJFBBNDIKED);
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
