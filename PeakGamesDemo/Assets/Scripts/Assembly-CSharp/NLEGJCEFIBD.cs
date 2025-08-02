using System;
using caravan.protobuf.messages;

public class NLEGJCEFIBD : IKDMCJPBBIH
{
	private readonly string BBCIDFDOOGC;

	private readonly Action<int> JCOKJJGCPHI;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.CHANGE_NICKNAME_MSG;
		}
	}

	public NLEGJCEFIBD(string PDEKHNLNOLA, Action<int> IMHLFAHONPP)
	{
		BBCIDFDOOGC = PDEKHNLNOLA;
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(0);
		}
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		ChangeNicknameMessage changeNicknameMessage = new ChangeNicknameMessage();
		changeNicknameMessage.nickname = BBCIDFDOOGC;
		ChangeNicknameMessage fNHFILKPEDI = changeNicknameMessage;
		IKDMCJPBBIH.MCAAJOHOFGL(fNHFILKPEDI, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.CHANGE_NICKNAME_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(ChangeNicknameResponseMessage);
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		ChangeNicknameResponseMessage oMJOIIOONMO = (ChangeNicknameResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new GNFDHEDGOKN(JCOKJJGCPHI, oMJOIIOONMO, this, NONNALMDLEL.KMJBHHCCJFD());
	}
}
