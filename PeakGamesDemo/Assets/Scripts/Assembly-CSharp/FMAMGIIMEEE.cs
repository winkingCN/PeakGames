using System;
using Assets.Scripts.SceneTransitions;
using caravan.protobuf.messages;

public class FMAMGIIMEEE : NADPOFCHCON
{
	private readonly GetTeamInfoResponseMessage GELLEKINDPC;

	private readonly Action<GetTeamInfoResponseMessage> JCOKJJGCPHI;

	public FMAMGIIMEEE(GetTeamInfoResponseMessage ACLLEBEMJPE, Action<GetTeamInfoResponseMessage> IMHLFAHONPP, IKDMCJPBBIH KAGBOIDKAED, GBJNCLLOCJB KFNJHBPIHOI)
		: base(KAGBOIDKAED, KFNJHBPIHOI)
	{
		GELLEKINDPC = ACLLEBEMJPE;
		JCOKJJGCPHI = IMHLFAHONPP;
		if (GELLEKINDPC == null || GELLEKINDPC.teamMembers == null || GELLEKINDPC.teamMembers.Count <= 0)
		{
			return;
		}
		int count = GELLEKINDPC.teamMembers.Count;
		int num = OIAJPMNJGLK.HOGCELOOGEP();
		for (int i = 0; i < count; i++)
		{
			if (num > 0 && GELLEKINDPC.teamMembers[i].helpWeek < num)
			{
				GELLEKINDPC.teamMembers[i].helpCount = 0;
			}
		}
	}

	protected override GBJNCLLOCJB BMMMAFJBJMD()
	{
		if (CaravanSceneManager.CurrentScene == GKBHIKONCKJ.Map || CaravanSceneManager.SceneToBeLoaded == GKBHIKONCKJ.Map)
		{
			return GBJNCLLOCJB.ResultSuccess;
		}
		return GBJNCLLOCJB.ClientNotInSameScene;
	}

	public override void JLECFJEAFCD()
	{
		JCOKJJGCPHI(GELLEKINDPC);
	}

	public override void AIGOFKAJFBM()
	{
		JCOKJJGCPHI(null);
	}
}
