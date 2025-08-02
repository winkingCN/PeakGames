using System;
using System.IO;
using System.Text;
using UnityEngine;
using caravan.protobuf.messages;

public class MFODECOOJLA : IKDMCJPBBIH
{
	private readonly Action<bool> NMILJNLPIKF;

	private readonly string NDDBGAEBOLA;

	private readonly string DOJJBBLIIDO;

	private readonly string FLEPELKJBGN;

	private readonly bool AMEONKPGKCI;

	private readonly EKPAJFBBAJC MOJHEMIODFL;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.SEND_TICKET_MSG;
		}
	}

	public MFODECOOJLA(string HCMFNNPEKDN, string OEFCOJLNCKP, string NOKFDFNMBMJ, Action<bool> LAMLCODHKBO)
	{
		NDDBGAEBOLA = HCMFNNPEKDN;
		DOJJBBLIIDO = OEFCOJLNCKP;
		FLEPELKJBGN = NOKFDFNMBMJ;
		NMILJNLPIKF = LAMLCODHKBO;
	}

	public MFODECOOJLA(EKPAJFBBAJC NOBNPDKGOLD, string HCMFNNPEKDN, string OEFCOJLNCKP, Action<bool> LAMLCODHKBO)
	{
		AMEONKPGKCI = true;
		MOJHEMIODFL = NOBNPDKGOLD;
		NDDBGAEBOLA = HCMFNNPEKDN;
		DOJJBBLIIDO = OEFCOJLNCKP;
		NMILJNLPIKF = LAMLCODHKBO;
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		if (NMILJNLPIKF != null)
		{
			NMILJNLPIKF(false);
		}
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		SendTicketMessage sendTicketMessage = new SendTicketMessage();
		sendTicketMessage.body = NHLJFKPLKLI(DOJJBBLIIDO, 2048);
		sendTicketMessage.language = NHLJFKPLKLI(MDGKDGMGGCL.GABGKBAKHDP.PHOCMCOHANN(), 10);
		sendTicketMessage.device = SystemInfo.deviceModel + "/" + SystemInfo.operatingSystem;
		sendTicketMessage.platform = NHLJFKPLKLI(Application.platform.ToString(), 10);
		sendTicketMessage.lastUnlockedLevel = (MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1).ToString();
		sendTicketMessage.coins = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins);
		sendTicketMessage.version = "4161";
		sendTicketMessage.paid_user = (LECPGNKOABP.GABGKBAKHDP.ILNAPPDKOOD ? 1 : 0);
		sendTicketMessage.team_id = (int)LECPGNKOABP.GABGKBAKHDP.OADDPGNIINO;
		sendTicketMessage.team_name = NHLJFKPLKLI(LECPGNKOABP.GABGKBAKHDP.EFHEIFMEJCN, 20);
		SendTicketMessage sendTicketMessage2 = sendTicketMessage;
		if (AMEONKPGKCI)
		{
			sendTicketMessage2.email = "toonblast_chat_report@peakgames.net";
			sendTicketMessage2.name = "Chat Message Report";
			sendTicketMessage2.subject = "Toon Blast Chat Message Report";
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Chat Message Report");
			stringBuilder.AppendLine();
			stringBuilder.Append("Message Id:" + MOJHEMIODFL.EEFMIHDPJPG);
			stringBuilder.AppendLine();
			stringBuilder.Append("Message:" + MOJHEMIODFL.HKCNCCIAMEL);
			stringBuilder.AppendLine();
			stringBuilder.Append("Reported Id:" + MOJHEMIODFL.OCHADBCJEDP);
			stringBuilder.AppendLine();
			stringBuilder.Append("Reported Name:" + MOJHEMIODFL.KNMOIMNECKE);
			stringBuilder.AppendLine();
			stringBuilder.Append("User Message: " + NHLJFKPLKLI(DOJJBBLIIDO, 2048));
			stringBuilder.AppendLine();
			stringBuilder.Append("User Email: " + NHLJFKPLKLI(NDDBGAEBOLA, 100));
			sendTicketMessage2.body = stringBuilder.ToString();
		}
		else
		{
			sendTicketMessage2.subject = "Toon Blast Ticket";
			sendTicketMessage2.logFile = File.ReadAllBytes(FLEPELKJBGN);
			sendTicketMessage2.email = NHLJFKPLKLI(NDDBGAEBOLA, 100);
		}
		IKDMCJPBBIH.MCAAJOHOFGL(sendTicketMessage2, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.SEND_TICKET_RESPONSE_MSG;
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
		ICKPFMKIIBM = new KNLPDBACFGB(this, NMILJNLPIKF, NONNALMDLEL.KMJBHHCCJFD());
	}

	private string NHLJFKPLKLI(string KCIJNHPGJKF, int PLCFEOMGCFK)
	{
		if (KCIJNHPGJKF != null && KCIJNHPGJKF.Length > PLCFEOMGCFK)
		{
			KCIJNHPGJKF = KCIJNHPGJKF.Substring(0, PLCFEOMGCFK);
		}
		return KCIJNHPGJKF;
	}
}
