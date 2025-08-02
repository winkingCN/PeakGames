using System;
using caravan.protobuf.messages;

public class OMMPHPJNNBD : IKDMCJPBBIH
{
	private readonly Action<bool, ClStatusResponseMessage> JCOKJJGCPHI;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.CL_STATUS_MSG;
		}
	}

	public OMMPHPJNNBD(Action<bool, ClStatusResponseMessage> IMHLFAHONPP)
	{
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		IDFPAFEJPPH iDFPAFEJPPH = IDFPAFEJPPH.GABGKBAKHDP;
		ClStatusMessage clStatusMessage = new ClStatusMessage();
		clStatusMessage.maxLevel = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC();
		ClStatusMessage clStatusMessage2 = clStatusMessage;
		if (iDFPAFEJPPH.HGNJBHGBLIN)
		{
			clStatusMessage2.groupId = iDFPAFEJPPH.INFAGKCBEHL;
		}
		IKDMCJPBBIH.MCAAJOHOFGL(clStatusMessage2, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.CL_STATUS_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(ClStatusResponseMessage);
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
		ClStatusResponseMessage oMJOIIOONMO = (ClStatusResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new IHDDEELLFIA(oMJOIIOONMO, JCOKJJGCPHI, this, NONNALMDLEL.KMJBHHCCJFD());
	}
}
