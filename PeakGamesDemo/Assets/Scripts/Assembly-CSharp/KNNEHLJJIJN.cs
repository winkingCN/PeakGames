using System;
using caravan.protobuf.messages;

public class KNNEHLJJIJN : IKDMCJPBBIH
{
	private readonly KNAKIANHFJN[] INIFABHGHED;

	private readonly int EADEMDIHGHE;

	private readonly Action<bool> JCOKJJGCPHI;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.GET_FRIENDS_SCORES_MSG;
		}
	}

	public KNNEHLJJIJN(int KIGOGMKCDKN, KNAKIANHFJN[] LAJKEHONIPK, Action<bool> IMHLFAHONPP)
	{
		INIFABHGHED = LAJKEHONIPK;
		EADEMDIHGHE = KIGOGMKCDKN;
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.GetFriendsScoresCommand, "CreateBackendGenericMessage levelno:{0}", EADEMDIHGHE);
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		GetFriendsScoresMessage getFriendsScoresMessage = new GetFriendsScoresMessage();
		getFriendsScoresMessage.levelNo = EADEMDIHGHE;
		GetFriendsScoresMessage getFriendsScoresMessage2 = getFriendsScoresMessage;
		for (int i = 0; i < INIFABHGHED.Length; i++)
		{
			getFriendsScoresMessage2.friends.Add(INIFABHGHED[i].EEFMIHDPJPG);
		}
		IKDMCJPBBIH.MCAAJOHOFGL(getFriendsScoresMessage2, genericMessage);
		return genericMessage;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(GetFriendsScoresResponseMessage);
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.GET_FRIENDS_SCORES_RESPONSE_MSG;
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.GetFriendsScoresCommand, "FailedAndNoReply levelno:{0}", EADEMDIHGHE);
	}

	protected override void NLMICJNOMCD(object GDFBAKKHFIC, ResultCodes NONNALMDLEL)
	{
		GetFriendsScoresResponseMessage oMJOIIOONMO = (GetFriendsScoresResponseMessage)GDFBAKKHFIC;
		ICKPFMKIIBM = new BEHPKBCFMFP(this, EADEMDIHGHE, JCOKJJGCPHI, oMJOIIOONMO, NONNALMDLEL.KMJBHHCCJFD());
	}
}
