using System;
using caravan.protobuf.messages;

public class IGBCNKNCJDI : IKDMCJPBBIH
{
	private readonly Action<bool, ClGetLeaderboardResponseMessage> JCOKJJGCPHI;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.CL_GET_LEADERBOARD_MSG;
		}
	}

	public IGBCNKNCJDI(Action<bool, ClGetLeaderboardResponseMessage> IMHLFAHONPP)
	{
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		ClGetLeaderboardMessage clGetLeaderboardMessage = new ClGetLeaderboardMessage();
		clGetLeaderboardMessage.groupId = IDFPAFEJPPH.GABGKBAKHDP.INFAGKCBEHL;
		ClGetLeaderboardMessage fNHFILKPEDI = clGetLeaderboardMessage;
		IKDMCJPBBIH.MCAAJOHOFGL(fNHFILKPEDI, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.CL_GET_LEADERBOARD_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(ClGetLeaderboardResponseMessage);
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(false, null);
		}
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		ClGetLeaderboardResponseMessage oMJOIIOONMO = (ClGetLeaderboardResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new JPFADJFIKDP(oMJOIIOONMO, JCOKJJGCPHI, this, NONNALMDLEL.KMJBHHCCJFD());
	}
}
