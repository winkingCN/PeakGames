using System;
using System.IO;
using caravan.protobuf.messages;

public class GJKNNDNIBMC : IKDMCJPBBIH
{
	private readonly string LILGEOAMMGN;

	private readonly string FLEPELKJBGN;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.SEND_LOG_FILE_MSG;
		}
	}

	public GJKNNDNIBMC(string CGHOFPJMKFM, string NOKFDFNMBMJ)
	{
		LILGEOAMMGN = CGHOFPJMKFM;
		FLEPELKJBGN = NOKFDFNMBMJ;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		SendLogFileMessage sendLogFileMessage = new SendLogFileMessage();
		sendLogFileMessage.filename = LILGEOAMMGN;
		sendLogFileMessage.body = File.ReadAllBytes(FLEPELKJBGN);
		SendLogFileMessage fNHFILKPEDI = sendLogFileMessage;
		IKDMCJPBBIH.MCAAJOHOFGL(fNHFILKPEDI, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.SEND_LOG_FILE_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return null;
	}

	public override int MCFABAAMELG()
	{
		return 20;
	}

	protected override void NLMICJNOMCD(object INGDJMDGCOO, ResultCodes NONNALMDLEL)
	{
		ICKPFMKIIBM = new HMLGPPFNDOD(this, NONNALMDLEL.KMJBHHCCJFD());
	}
}
