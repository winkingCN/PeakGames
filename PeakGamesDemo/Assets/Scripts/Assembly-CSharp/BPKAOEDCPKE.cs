using System;
using caravan.protobuf.messages;

public class BPKAOEDCPKE : IKDMCJPBBIH
{
	private readonly Action<bool> JCOKJJGCPHI;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.GET_ALL_LEADERBOARDS_MSG;
		}
	}

	public BPKAOEDCPKE(Action<bool> IMHLFAHONPP)
	{
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		return BFEDIIJOFCG(LOICNFDHCJK);
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.GET_ALL_LEADERBOARDS_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(GetAllLeaderboardsResponseMessage);
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		GetAllLeaderboardsResponseMessage mBBPBGHKLJM = OMJOIIOONMO as GetAllLeaderboardsResponseMessage;
		ICKPFMKIIBM = new LIPMPJCKBBL(JCOKJJGCPHI, mBBPBGHKLJM, this, NONNALMDLEL.KMJBHHCCJFD());
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(false);
		}
	}
}
