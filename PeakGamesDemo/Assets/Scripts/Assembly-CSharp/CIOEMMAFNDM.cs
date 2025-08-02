using System;
using Assets.Scripts.Utils.Analytics;
using Facebook.Unity;
using caravan.protobuf.messages;

public class CIOEMMAFNDM : IKDMCJPBBIH
{
	private readonly Action<bool, bool> BLHAAFNBJHK;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.FB_CONNECT_MSG;
		}
	}

	public CIOEMMAFNDM(Action<bool, bool> PGDLCHCEKNF)
	{
		BLHAAFNBJHK = PGDLCHCEKNF;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		if (!FB.IsLoggedIn)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.ConnectToFacebookCommand, "Facebook is not logged in!");
			throw new Exception("Not connected to FB but!");
		}
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		FacebookConnectMessage facebookConnectMessage = new FacebookConnectMessage();
		facebookConnectMessage.fbToken = AccessToken.CurrentAccessToken.TokenString;
		facebookConnectMessage.autoLoginId = PeakAnalytics.GetDeviceId();
		FacebookConnectMessage fNHFILKPEDI = facebookConnectMessage;
		IKDMCJPBBIH.MCAAJOHOFGL(fNHFILKPEDI, genericMessage);
		return genericMessage;
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		if (BLHAAFNBJHK != null)
		{
			BLHAAFNBJHK(false, false);
		}
	}

	protected override void NLMICJNOMCD(object GDFBAKKHFIC, ResultCodes NONNALMDLEL)
	{
		FacebookConnectResponseMessage cECLOLDKOLC = (FacebookConnectResponseMessage)GDFBAKKHFIC;
		ICKPFMKIIBM = new ADEAGBKEGPG(this, cECLOLDKOLC, BLHAAFNBJHK, NONNALMDLEL.KMJBHHCCJFD());
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.FB_CONNECT_RESPONSE_MSG;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(FacebookConnectResponseMessage);
	}
}
