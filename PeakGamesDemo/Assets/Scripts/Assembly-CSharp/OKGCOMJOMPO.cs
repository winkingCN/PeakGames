using System;
using System.Collections.Generic;
using Assets.Scripts.Utils.Analytics;
using caravan.protobuf.messages;

public class OKGCOMJOMPO : IKDMCJPBBIH
{
	private List<IKDMCJPBBIH> OPBKBIKAFPE;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.LOGIN_MSG;
		}
	}

	public override GenericMessage DIMAFEDACMK()
	{
		PHHKFLHAFHG pHHKFLHAFHG = NAAGDFCLOPE.GABGKBAKHDP.BINDEBHMEJC;
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		LoginMessage loginMessage = new LoginMessage();
		loginMessage.autoLoginId = PeakAnalytics.GetDeviceId();
		loginMessage.cloudUserId = pHHKFLHAFHG.NDGDIONKNJF.GDMECFECCOM;
		loginMessage.cloudUserToken = pHHKFLHAFHG.NDGDIONKNJF.AJIFKBCELCA;
		IKDMCJPBBIH.MCAAJOHOFGL(loginMessage, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.LOGIN_RESPONSE_MSG;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(LoginResponseMessage);
	}

	protected override void NLMICJNOMCD(object DBAKHMDKCAM, ResultCodes NONNALMDLEL)
	{
		LoginResponseMessage oDPOKBKAJJE = (LoginResponseMessage)DBAKHMDKCAM;
		ICKPFMKIIBM = new OFHGJACEEHO(this, oDPOKBKAJJE, OPBKBIKAFPE, NONNALMDLEL.KMJBHHCCJFD());
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		OFHGJACEEHO oFHGJACEEHO = new OFHGJACEEHO(this, null, OPBKBIKAFPE, GBJNCLLOCJB.FailedAndNoReply);
		oFHGJACEEHO.AIGOFKAJFBM();
	}

	public void ELADBJNKNME(List<IKDMCJPBBIH> HDECNOABBDG)
	{
		OPBKBIKAFPE = HDECNOABBDG;
	}
}
