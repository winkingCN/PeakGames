using System;
using caravan.protobuf.messages;

public class ABDJJDHMENI : IKDMCJPBBIH
{
	private readonly Action<bool, ClJoinResponseMessage> JCOKJJGCPHI;

	private readonly string DNPADLLBDDC;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.CL_JOIN_MSG;
		}
	}

	public ABDJJDHMENI(Action<bool, ClJoinResponseMessage> IMHLFAHONPP, string PDEKHNLNOLA = null)
	{
		DNPADLLBDDC = PDEKHNLNOLA;
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(false, null);
		}
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		ClJoinMessage clJoinMessage = new ClJoinMessage();
		if (DNPADLLBDDC != null && !DNPADLLBDDC.Equals(string.Empty))
		{
			clJoinMessage.nickname = DNPADLLBDDC;
		}
		clJoinMessage.ClId = IDFPAFEJPPH.GABGKBAKHDP.NBJMMBIGCOB;
		IKDMCJPBBIH.MCAAJOHOFGL(clJoinMessage, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.CL_JOIN_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(ClJoinResponseMessage);
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		ClJoinResponseMessage oMJOIIOONMO = (ClJoinResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new JIGMEBAKDLH(oMJOIIOONMO, JCOKJJGCPHI, this, NONNALMDLEL.KMJBHHCCJFD());
	}
}
