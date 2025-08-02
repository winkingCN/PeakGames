using System;
using Assets.Scripts.Utils;
using caravan.protobuf.messages;

public class ILCNNFKJEFG : IKDMCJPBBIH
{
	private readonly long AJPNGAEMOMC;

	private readonly bool NHEIHPMKMMF;

	private readonly Action<bool> JCOKJJGCPHI;

	private int IBHDKBDNCMG;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.ST_STATUS_MSG;
		}
	}

	public ILCNNFKJEFG(long KEKPBEKCPNN, bool IDDNPGOCCOG, Action<bool> IMHLFAHONPP = null)
	{
		AJPNGAEMOMC = KEKPBEKCPNN;
		NHEIHPMKMMF = IDDNPGOCCOG;
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		IBHDKBDNCMG = FocusListener.MOGJKPIEGGL;
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		StStatusMessage stStatusMessage = new StStatusMessage();
		stStatusMessage.groupId = AJPNGAEMOMC;
		stStatusMessage.withList = (NHEIHPMKMMF ? 1 : 0);
		StStatusMessage fNHFILKPEDI = stStatusMessage;
		IKDMCJPBBIH.MCAAJOHOFGL(fNHFILKPEDI, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.ST_STATUS_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(StStatusResponseMessage);
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(false);
		}
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		StStatusResponseMessage oMJOIIOONMO = (StStatusResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new IPKMPAAECOA(oMJOIIOONMO, JCOKJJGCPHI, this, NONNALMDLEL.KMJBHHCCJFD(), IBHDKBDNCMG);
	}
}
