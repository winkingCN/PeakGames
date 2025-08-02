using System;
using Assets.Scripts.Utils;
using caravan.protobuf.messages;

public class KBBPGCKJHNJ : IKDMCJPBBIH
{
	public bool OOKBNILGMAN;

	private int IBHDKBDNCMG;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.GET_EVENTS_MSG;
		}
	}

	public override GenericMessage DIMAFEDACMK()
	{
		IBHDKBDNCMG = FocusListener.MOGJKPIEGGL;
		return BFEDIIJOFCG(LOICNFDHCJK);
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.GET_EVENTS_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(GetEventsResponseMessage);
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		GetEventsResponseMessage oMJOIIOONMO = (GetEventsResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new HEJJIOFDJFH(oMJOIIOONMO, this, NONNALMDLEL.KMJBHHCCJFD(), OOKBNILGMAN, IBHDKBDNCMG);
	}
}
