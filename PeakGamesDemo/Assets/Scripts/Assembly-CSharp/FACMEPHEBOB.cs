using System;
using caravan.protobuf.messages;

public class FACMEPHEBOB : IKDMCJPBBIH
{
	private readonly long GODKDOHOHCD;

	private readonly int DJJBGNGNLNI;

	private readonly Action<bool> JCOKJJGCPHI;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.TT_CLAIM_MSG;
		}
	}

	public FACMEPHEBOB(long GCKOBKBPOBE, int JEAAHAFHDEG, Action<bool> IMHLFAHONPP = null)
	{
		DJJBGNGNLNI = JEAAHAFHDEG;
		GODKDOHOHCD = GCKOBKBPOBE;
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		TtClaimMessage ttClaimMessage = new TtClaimMessage();
		ttClaimMessage.eventId = GODKDOHOHCD;
		ttClaimMessage.rank = DJJBGNGNLNI;
		TtClaimMessage fNHFILKPEDI = ttClaimMessage;
		IKDMCJPBBIH.MCAAJOHOFGL(fNHFILKPEDI, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.TT_CLAIM_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(TtClaimResponseMessage);
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
		TtClaimResponseMessage oMJOIIOONMO = (TtClaimResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new FLJKGGKGGJL(oMJOIIOONMO, JCOKJJGCPHI, this, NONNALMDLEL.KMJBHHCCJFD());
	}
}
