using System;
using Assets.Scripts.SceneTransitions;
using caravan.protobuf.messages;

public class KMEMDKODNKA : NADPOFCHCON
{
	private readonly Action<bool, ClUserScoresResponseMessage> JCOKJJGCPHI;

	private readonly ClUserScoresResponseMessage DJFBBNDIKED;

	public KMEMDKODNKA(ClUserScoresResponseMessage OMJOIIOONMO, Action<bool, ClUserScoresResponseMessage> IMHLFAHONPP, IKDMCJPBBIH KAGBOIDKAED, GBJNCLLOCJB KFNJHBPIHOI)
		: base(KAGBOIDKAED, KFNJHBPIHOI)
	{
		JCOKJJGCPHI = IMHLFAHONPP;
		DJFBBNDIKED = OMJOIIOONMO;
	}

	protected override GBJNCLLOCJB BMMMAFJBJMD()
	{
		return (CaravanSceneManager.CurrentScene != GKBHIKONCKJ.Map) ? GBJNCLLOCJB.ClientNotInSameScene : GBJNCLLOCJB.ResultSuccess;
	}

	public override void AIGOFKAJFBM()
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(false, null);
		}
	}

	public override void JLECFJEAFCD()
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(true, DJFBBNDIKED);
		}
	}
}
