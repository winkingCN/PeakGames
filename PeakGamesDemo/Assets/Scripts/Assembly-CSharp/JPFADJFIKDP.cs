using System;
using Assets.Scripts.SceneTransitions;
using caravan.protobuf.messages;

public class JPFADJFIKDP : NADPOFCHCON
{
	private readonly Action<bool, ClGetLeaderboardResponseMessage> JCOKJJGCPHI;

	private readonly ClGetLeaderboardResponseMessage DJFBBNDIKED;

	public JPFADJFIKDP(ClGetLeaderboardResponseMessage OMJOIIOONMO, Action<bool, ClGetLeaderboardResponseMessage> IMHLFAHONPP, IKDMCJPBBIH KAGBOIDKAED, GBJNCLLOCJB KFNJHBPIHOI)
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
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(true, DJFBBNDIKED);
		}
	}

	public override void AIGOFKAJFBM()
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(false, null);
		}
	}
}
