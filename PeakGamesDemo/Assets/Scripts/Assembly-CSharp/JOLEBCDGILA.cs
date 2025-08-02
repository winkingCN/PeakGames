using System;
using caravan.protobuf.messages;

public class JOLEBCDGILA : IKDMCJPBBIH
{
	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.CALENDAR_CLAIM_MSG;
		}
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		CalendarClaimMessage calendarClaimMessage = new CalendarClaimMessage();
		calendarClaimMessage.duration = BPPNANHCLJI.GABGKBAKHDP.MDEBPEGEMLA();
		CalendarClaimMessage fNHFILKPEDI = calendarClaimMessage;
		IKDMCJPBBIH.MCAAJOHOFGL(fNHFILKPEDI, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.CALENDAR_CLAIM_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(CalendarClaimResponseMessage);
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		new ECGJJNMJBDE(null, this, GBJNCLLOCJB.FailedAndNoReply).AIGOFKAJFBM();
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		CalendarClaimResponseMessage oMJOIIOONMO = (CalendarClaimResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new ECGJJNMJBDE(oMJOIIOONMO, this, NONNALMDLEL.KMJBHHCCJFD());
	}
}
