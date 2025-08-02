using System;
using Assets.Scripts.SceneTransitions;
using caravan.protobuf.messages;

public class GIMNFBKJEOA : NADPOFCHCON
{
	private readonly GetFacebookLeaderboardResponseMessage DJFBBNDIKED;

	private readonly Action<bool> JCOKJJGCPHI;

	public GIMNFBKJEOA(GetFacebookLeaderboardResponseMessage OMJOIIOONMO, Action<bool> IMHLFAHONPP, IKDMCJPBBIH KAGBOIDKAED, GBJNCLLOCJB KFNJHBPIHOI)
		: base(KAGBOIDKAED, KFNJHBPIHOI)
	{
		DJFBBNDIKED = OMJOIIOONMO;
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	protected override GBJNCLLOCJB BMMMAFJBJMD()
	{
		return (CaravanSceneManager.CurrentScene != GKBHIKONCKJ.Map) ? GBJNCLLOCJB.ClientNotInSameScene : GBJNCLLOCJB.ResultSuccess;
	}

	public override void JLECFJEAFCD()
	{
		FFGIDMDAGOA.GABGKBAKHDP.ADIMEEPIFBL(DJFBBNDIKED);
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(true);
		}
	}

	public override void AIGOFKAJFBM()
	{
		base.AIGOFKAJFBM();
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(false);
		}
	}
}
