using System;
using caravan.protobuf.messages;

public class LACCOLIODHB : IKDMCJPBBIH
{
	private readonly Action<bool> JCOKJJGCPHI;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.GET_TEAM_LEADERBOARD_MSG;
		}
	}

	public LACCOLIODHB(Action<bool> IMHLFAHONPP)
	{
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		return BFEDIIJOFCG(LOICNFDHCJK);
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.GET_TEAM_LEADERBOARD_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(GetTeamLeaderboardResponseMessage);
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		GetTeamLeaderboardResponseMessage oMJOIIOONMO = (GetTeamLeaderboardResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new OLEDNCOIDPI(JCOKJJGCPHI, oMJOIIOONMO, this, NONNALMDLEL.KMJBHHCCJFD());
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		base.HOBMBHFKMJI(FCFNMGAMKCJ);
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(true);
		}
	}
}
