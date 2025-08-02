using System;
using Assets.Scripts.Utils;
using caravan.protobuf.messages;

public class AEJCEEFPJIA : IKDMCJPBBIH
{
	private int IBHDKBDNCMG;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.PING_MSG;
		}
	}

	public override GenericMessage DIMAFEDACMK()
	{
		ELBMHNOBHPN.EGINHMIAEOB();
		IBHDKBDNCMG = FocusListener.MOGJKPIEGGL;
		return BFEDIIJOFCG(LOICNFDHCJK);
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.PING_RESPONSE_MSG;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(PingResponseMessage);
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		new KBAPDAADFBA(this, GBJNCLLOCJB.FailedAndNoReply, null, IBHDKBDNCMG).AIGOFKAJFBM();
	}

	protected override void NLMICJNOMCD(object DBAKHMDKCAM, ResultCodes NONNALMDLEL)
	{
		PingResponseMessage lHIEOCECNOJ = (PingResponseMessage)DBAKHMDKCAM;
		ICKPFMKIIBM = new KBAPDAADFBA(this, NONNALMDLEL.KMJBHHCCJFD(), lHIEOCECNOJ, IBHDKBDNCMG);
	}
}
