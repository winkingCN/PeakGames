using System;
using System.Collections;
using Assets.Scripts.SceneTransitions;
using NewMapScene;
using caravan.protobuf.messages;

public class LIPMPJCKBBL : NADPOFCHCON
{
	private readonly GetAllLeaderboardsResponseMessage JCCIHFEPIID;

	private readonly Action<bool> JCOKJJGCPHI;

	public LIPMPJCKBBL(Action<bool> IMHLFAHONPP, GetAllLeaderboardsResponseMessage MBBPBGHKLJM, IKDMCJPBBIH KAGBOIDKAED, GBJNCLLOCJB KFNJHBPIHOI)
		: base(KAGBOIDKAED, KFNJHBPIHOI)
	{
		JCOKJJGCPHI = IMHLFAHONPP;
		JCCIHFEPIID = MBBPBGHKLJM;
	}

	protected override GBJNCLLOCJB BMMMAFJBJMD()
	{
		return (CaravanSceneManager.CurrentScene != GKBHIKONCKJ.Map) ? GBJNCLLOCJB.ClientNotInSameScene : GBJNCLLOCJB.ResultSuccess;
	}

	public override void JLECFJEAFCD()
	{
		new LLCJMMBBLEH(CPOCEFIKMHJ(), true, IAJNLGPHGLO.App);
	}

	private IEnumerator CPOCEFIKMHJ()
	{
		LeaderboardPageController.UpdateLocalizedCountry(JCCIHFEPIID.nativeName);
		HLFNMNPLJCP hLFNMNPLJCP = HLFNMNPLJCP.GABGKBAKHDP;
		hLFNMNPLJCP.ADIMEEPIFBL(JCCIHFEPIID.globalTeamLeaderboard);
		yield return null;
		hLFNMNPLJCP.ADIMEEPIFBL(JCCIHFEPIID.localTeamLeaderboard, 2);
		yield return null;
		FIFPLICICKP fIFPLICICKP = FIFPLICICKP.GABGKBAKHDP;
		fIFPLICICKP.ADIMEEPIFBL(JCCIHFEPIID.globalPlayerLeaderboard);
		yield return null;
		fIFPLICICKP.ADIMEEPIFBL(JCCIHFEPIID.localPlayerLeaderboard, 2);
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
