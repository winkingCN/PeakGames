using System;
using caravan.protobuf.messages;

public class AKHDMHCPFPJ : IKDMCJPBBIH
{
	private readonly int KKMIEDBFCOB;

	private readonly Action<GetTeamInfoResponseMessage> JCOKJJGCPHI;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.GET_TEAM_INFO_MSG;
		}
	}

	public AKHDMHCPFPJ(int EMNOJOHFMEH, Action<GetTeamInfoResponseMessage> IMHLFAHONPP)
	{
		KKMIEDBFCOB = EMNOJOHFMEH;
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GetTeamInfoMessage getTeamInfoMessage = new GetTeamInfoMessage();
		getTeamInfoMessage.teamId = KKMIEDBFCOB;
		GetTeamInfoMessage fNHFILKPEDI = getTeamInfoMessage;
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		IKDMCJPBBIH.MCAAJOHOFGL(fNHFILKPEDI, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.GET_TEAM_INFO_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(GetTeamInfoResponseMessage);
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		GetTeamInfoResponseMessage aCLLEBEMJPE = (GetTeamInfoResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new FMAMGIIMEEE(aCLLEBEMJPE, JCOKJJGCPHI, this, NONNALMDLEL.KMJBHHCCJFD());
	}
}
