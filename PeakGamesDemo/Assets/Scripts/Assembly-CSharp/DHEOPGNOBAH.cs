using System;
using System.Collections.Generic;
using caravan.protobuf.messages;

public class DHEOPGNOBAH : IKDMCJPBBIH
{
	private readonly List<string> LDLILEIPEOL;

	private readonly int HKBLPNMGFCE;

	private Action<bool, int> JCOKJJGCPHI;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.REPORT_CHAT_MSG;
		}
	}

	public DHEOPGNOBAH(int PLHMHOFHMHP, List<string> ELHGGCJBBDK, Action<bool, int> IMHLFAHONPP)
	{
		HKBLPNMGFCE = PLHMHOFHMHP;
		LDLILEIPEOL = ELHGGCJBBDK;
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		ReportChatMessage reportChatMessage = new ReportChatMessage();
		reportChatMessage.teamNo = HKBLPNMGFCE;
		ReportChatMessage reportChatMessage2 = reportChatMessage;
		reportChatMessage2.chatIdList.AddRange(LDLILEIPEOL);
		IKDMCJPBBIH.MCAAJOHOFGL(reportChatMessage2, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.REPORT_CHAT_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(ReportChatResponseMessage);
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(false, 1);
		}
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		ReportChatResponseMessage oMJOIIOONMO = (ReportChatResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new CCGPGGNMJFC(JCOKJJGCPHI, oMJOIIOONMO, this, NONNALMDLEL.KMJBHHCCJFD());
	}
}
