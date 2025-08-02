using System;
using Assets.Scripts.Utils;
using caravan.protobuf.messages;

public class IOCEEPMIBLN : IKDMCJPBBIH
{
	private readonly long KKMIEDBFCOB;

	private readonly int GODKDOHOHCD;

	private readonly bool JPAFOCDDHPM;

	private int IBHDKBDNCMG;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.TC_STATUS_MSG;
		}
	}

	public IOCEEPMIBLN(long EMNOJOHFMEH, int GCKOBKBPOBE, bool FGIHCMCJBPN = false)
	{
		KKMIEDBFCOB = EMNOJOHFMEH;
		GODKDOHOHCD = GCKOBKBPOBE;
		JPAFOCDDHPM = FGIHCMCJBPN;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		IBHDKBDNCMG = FocusListener.MOGJKPIEGGL;
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		TcStatusMessage tcStatusMessage = new TcStatusMessage();
		tcStatusMessage.eventId = GODKDOHOHCD;
		tcStatusMessage.teamId = KKMIEDBFCOB;
		TcStatusMessage fNHFILKPEDI = tcStatusMessage;
		IKDMCJPBBIH.MCAAJOHOFGL(fNHFILKPEDI, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.TC_STATUS_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(TcStatusResponseMessage);
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		TcStatusResponseMessage oMJOIIOONMO = (TcStatusResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new MHHIGGCCMJJ(oMJOIIOONMO, this, NONNALMDLEL.KMJBHHCCJFD(), JPAFOCDDHPM, IBHDKBDNCMG);
	}
}
