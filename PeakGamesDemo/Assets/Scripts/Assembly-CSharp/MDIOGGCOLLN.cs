using System;
using System.Collections.Generic;
using caravan.protobuf.messages;

public class MDIOGGCOLLN : IKDMCJPBBIH
{
	private readonly List<string> MBBFIIDAAPN;

	private readonly Action<bool> JCOKJJGCPHI;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.GET_FACEBOOK_LEADERBOARD_MSG;
		}
	}

	public MDIOGGCOLLN(List<string> ECFHPJGAFKL, Action<bool> IMHLFAHONPP)
	{
		MBBFIIDAAPN = ECFHPJGAFKL;
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		GetFacebookLeaderboardMessage getFacebookLeaderboardMessage = new GetFacebookLeaderboardMessage();
		for (int i = 0; i < MBBFIIDAAPN.Count; i++)
		{
			getFacebookLeaderboardMessage.facebookIdList.Add(MBBFIIDAAPN[i]);
		}
		IKDMCJPBBIH.MCAAJOHOFGL(getFacebookLeaderboardMessage, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.GET_FACEBOOK_LEADERBOARD_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(GetFacebookLeaderboardResponseMessage);
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		GetFacebookLeaderboardResponseMessage oMJOIIOONMO = (GetFacebookLeaderboardResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new GIMNFBKJEOA(oMJOIIOONMO, JCOKJJGCPHI, this, NONNALMDLEL.KMJBHHCCJFD());
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
