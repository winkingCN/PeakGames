using System;
using caravan.protobuf.messages;

public class HMJAPLEHCOO : IKDMCJPBBIH
{
	private readonly Action<bool> JCOKJJGCPHI;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.GET_PLAYERS_LEADERBOARD_MSG;
		}
	}

	public HMJAPLEHCOO(Action<bool> IMHLFAHONPP)
	{
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		return BFEDIIJOFCG(LOICNFDHCJK);
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.GET_PLAYERS_LEADERBOARD_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(GetPlayersLeaderboardResponseMessage);
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		GetPlayersLeaderboardResponseMessage oMJOIIOONMO = (GetPlayersLeaderboardResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new BELGGDIHEAG(JCOKJJGCPHI, oMJOIIOONMO, this, NONNALMDLEL.KMJBHHCCJFD());
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		base.HOBMBHFKMJI(FCFNMGAMKCJ);
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(false);
		}
	}
}
