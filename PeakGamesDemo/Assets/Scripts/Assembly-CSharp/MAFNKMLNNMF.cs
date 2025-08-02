using System;
using caravan.protobuf.messages;

public class MAFNKMLNNMF : IKDMCJPBBIH
{
	private readonly string BBCIDFDOOGC;

	private readonly Action<int> JCOKJJGCPHI;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.CREATE_SOCIAL_USER_MSG;
		}
	}

	public MAFNKMLNNMF(string PDEKHNLNOLA, Action<int> IMHLFAHONPP)
	{
		BBCIDFDOOGC = PDEKHNLNOLA;
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(1);
		}
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		CreateSocialUserMessage createSocialUserMessage = new CreateSocialUserMessage();
		createSocialUserMessage.nickname = BBCIDFDOOGC;
		CreateSocialUserMessage fNHFILKPEDI = createSocialUserMessage;
		IKDMCJPBBIH.MCAAJOHOFGL(fNHFILKPEDI, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.CREATE_SOCIAL_USER_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(CreateSocialUserResponseMessage);
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		CreateSocialUserResponseMessage oMJOIIOONMO = (CreateSocialUserResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new PIEGFDGCIGA(oMJOIIOONMO, JCOKJJGCPHI, this, NONNALMDLEL.KMJBHHCCJFD());
	}
}
