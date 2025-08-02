using System;
using caravan.protobuf.messages;

public class PNMIALBOEJO : IKDMCJPBBIH
{
	private readonly long AJPNGAEMOMC;

	private readonly Action<bool> JCOKJJGCPHI;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.ST_CLAIM_MSG;
		}
	}

	public PNMIALBOEJO(long KEKPBEKCPNN, Action<bool> IMHLFAHONPP = null)
	{
		AJPNGAEMOMC = KEKPBEKCPNN;
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		StClaimMessage stClaimMessage = new StClaimMessage();
		stClaimMessage.groupId = AJPNGAEMOMC;
		StClaimMessage fNHFILKPEDI = stClaimMessage;
		IKDMCJPBBIH.MCAAJOHOFGL(fNHFILKPEDI, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.ST_CLAIM_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(StClaimResponseMessage);
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(FCFNMGAMKCJ);
		}
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		StClaimResponseMessage oMJOIIOONMO = (StClaimResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new JMFKIFOGOIM(oMJOIIOONMO, JCOKJJGCPHI, this, NONNALMDLEL.KMJBHHCCJFD());
	}
}
