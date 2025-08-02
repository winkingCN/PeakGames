using System;
using caravan.protobuf.messages;

public class EADAHGNPMDB : IKDMCJPBBIH
{
	private readonly long MGAPFBHKDOB;

	private readonly long HNDDIFIANKG;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.CONSENT_ADD_MSG;
		}
	}

	public EADAHGNPMDB(long JPLBFCGBKPM, long BPKJLGJDFKG)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Command, "ConsentAddCommand: timestamp:{0}", JPLBFCGBKPM);
		MGAPFBHKDOB = JPLBFCGBKPM;
		HNDDIFIANKG = BPKJLGJDFKG;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		ConsentAddMessage consentAddMessage = new ConsentAddMessage();
		consentAddMessage.timestamp = MGAPFBHKDOB;
		consentAddMessage.userId = HNDDIFIANKG;
		ConsentAddMessage fNHFILKPEDI = consentAddMessage;
		IKDMCJPBBIH.MCAAJOHOFGL(fNHFILKPEDI, genericMessage);
		return genericMessage;
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		FJPHLKFHDOG.GABGKBAKHDP.EDHGHANJPAO();
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.CONSENT_ADD_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(ConsentAddResponseMessage);
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		ConsentAddResponseMessage oMJOIIOONMO = (ConsentAddResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new EAENEOKFGNB(oMJOIIOONMO, this, NONNALMDLEL.KMJBHHCCJFD());
	}
}
