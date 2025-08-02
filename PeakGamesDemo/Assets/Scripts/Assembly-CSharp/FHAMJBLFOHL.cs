using System;
using caravan.protobuf.messages;

public class FHAMJBLFOHL : IKDMCJPBBIH
{
	private readonly string GHGDPCNDMIO;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.AUTO_LOGIN_ID_MSG;
		}
	}

	public FHAMJBLFOHL(string LIDFOJHAOLP)
	{
		GHGDPCNDMIO = LIDFOJHAOLP;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		AutoLoginIdMessage autoLoginIdMessage = new AutoLoginIdMessage();
		autoLoginIdMessage.autoLoginId = GHGDPCNDMIO;
		AutoLoginIdMessage fNHFILKPEDI = autoLoginIdMessage;
		IKDMCJPBBIH.MCAAJOHOFGL(fNHFILKPEDI, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.AUTO_LOGIN_ID_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(AutoLoginIdResponseMessage);
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		AutoLoginIdResponseMessage oMJOIIOONMO = (AutoLoginIdResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new EOMAAEMOAEC(oMJOIIOONMO, GHGDPCNDMIO, this, NONNALMDLEL.KMJBHHCCJFD());
	}
}
