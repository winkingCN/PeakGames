using System;
using Assets.Scripts.Utils;
using caravan.protobuf.messages;

public class FBNFMCGHLEE : IKDMCJPBBIH
{
	private readonly long GODKDOHOHCD;

	private readonly long AJPNGAEMOMC;

	private readonly long KKMIEDBFCOB;

	private readonly Action<bool> JCOKJJGCPHI;

	private int IBHDKBDNCMG;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.TT_STATUS_MSG;
		}
	}

	public FBNFMCGHLEE(long GCKOBKBPOBE, long KEKPBEKCPNN, long EMNOJOHFMEH, Action<bool> IMHLFAHONPP = null)
	{
		GODKDOHOHCD = GCKOBKBPOBE;
		AJPNGAEMOMC = KEKPBEKCPNN;
		KKMIEDBFCOB = EMNOJOHFMEH;
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		IBHDKBDNCMG = FocusListener.MOGJKPIEGGL;
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		TtStatusMessage ttStatusMessage = new TtStatusMessage();
		ttStatusMessage.eventId = GODKDOHOHCD;
		ttStatusMessage.groupId = AJPNGAEMOMC;
		ttStatusMessage.teamId = KKMIEDBFCOB;
		TtStatusMessage fNHFILKPEDI = ttStatusMessage;
		IKDMCJPBBIH.MCAAJOHOFGL(fNHFILKPEDI, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.TT_STATUS_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(TtStatusResponseMessage);
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
		TtStatusResponseMessage oMJOIIOONMO = (TtStatusResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new FMPKCPKMHON(oMJOIIOONMO, GODKDOHOHCD, JCOKJJGCPHI, this, NONNALMDLEL.KMJBHHCCJFD(), IBHDKBDNCMG);
	}
}
