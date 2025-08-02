using System;
using caravan.protobuf.messages;

public class BDLCDEKAPHA : IKDMCJPBBIH
{
	private readonly Action<bool> JCOKJJGCPHI;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.CL_CLAIM_MSG;
		}
	}

	public BDLCDEKAPHA(Action<bool> IMHLFAHONPP)
	{
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(FCFNMGAMKCJ);
		}
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		ClClaimMessage clClaimMessage = new ClClaimMessage();
		clClaimMessage.ClId = IDFPAFEJPPH.GABGKBAKHDP.NBJMMBIGCOB;
		ClClaimMessage fNHFILKPEDI = clClaimMessage;
		IKDMCJPBBIH.MCAAJOHOFGL(fNHFILKPEDI, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.CL_CLAIM_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return null;
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		ICKPFMKIIBM = new EOPIPJELLLH(JCOKJJGCPHI, this, NONNALMDLEL.KMJBHHCCJFD());
	}
}
