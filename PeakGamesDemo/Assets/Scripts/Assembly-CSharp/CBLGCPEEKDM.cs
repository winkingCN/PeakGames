using System;
using Assets.Scripts.Utils;
using caravan.protobuf.messages;

public class CBLGCPEEKDM : IKDMCJPBBIH
{
	private int IBHDKBDNCMG;

	private Action<bool> JCOKJJGCPHI;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.GET_INFO_MSG;
		}
	}

	public CBLGCPEEKDM(Action<bool> IMHLFAHONPP = null)
	{
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		IBHDKBDNCMG = FocusListener.MOGJKPIEGGL;
		return BFEDIIJOFCG(LOICNFDHCJK);
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.GET_INFO_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(GetInfoResponseMessage);
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		new COBDONBEHLD(JCOKJJGCPHI, null, this, GBJNCLLOCJB.FailedAndNoReply, IBHDKBDNCMG).AIGOFKAJFBM();
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		GetInfoResponseMessage oMJOIIOONMO = (GetInfoResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new COBDONBEHLD(JCOKJJGCPHI, oMJOIIOONMO, this, NONNALMDLEL.KMJBHHCCJFD(), IBHDKBDNCMG);
	}
}
