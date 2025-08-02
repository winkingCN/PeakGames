using System;
using caravan.protobuf.messages;

public class GFOFLPPPDOF : IKDMCJPBBIH
{
	private readonly long KKMIEDBFCOB;

	private readonly int GODKDOHOHCD;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.TC_CLAIM_MSG;
		}
	}

	public GFOFLPPPDOF(long EMNOJOHFMEH, int GCKOBKBPOBE)
	{
		KKMIEDBFCOB = EMNOJOHFMEH;
		GODKDOHOHCD = GCKOBKBPOBE;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		TcClaimMessage tcClaimMessage = new TcClaimMessage();
		tcClaimMessage.eventId = GODKDOHOHCD;
		tcClaimMessage.teamId = KKMIEDBFCOB;
		TcClaimMessage fNHFILKPEDI = tcClaimMessage;
		IKDMCJPBBIH.MCAAJOHOFGL(fNHFILKPEDI, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.TC_CLAIM_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(TcClaimResponseMessage);
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		ICKPFMKIIBM = new DNKGIMHJLAD(this, NONNALMDLEL.KMJBHHCCJFD());
	}
}
