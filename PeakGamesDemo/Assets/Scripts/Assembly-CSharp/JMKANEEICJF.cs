using System;
using caravan.protobuf.messages;

public class JMKANEEICJF : IKDMCJPBBIH
{
	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.DAILY_CLAIM_MSG;
		}
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		DailyClaimMessage dailyClaimMessage = new DailyClaimMessage();
		dailyClaimMessage.duration = DJFEHCGIDGC.GABGKBAKHDP.MDEBPEGEMLA();
		DailyClaimMessage fNHFILKPEDI = dailyClaimMessage;
		IKDMCJPBBIH.MCAAJOHOFGL(fNHFILKPEDI, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.DAILY_CLAIM_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(DailyClaimResponseMessage);
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		new HNECJPKKCJK(null, this, GBJNCLLOCJB.FailedAndNoReply).AIGOFKAJFBM();
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		DailyClaimResponseMessage oMJOIIOONMO = (DailyClaimResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new HNECJPKKCJK(oMJOIIOONMO, this, NONNALMDLEL.KMJBHHCCJFD());
	}
}
