using System;
using System.Collections.Generic;
using caravan.protobuf.messages;

public class NCJDJEAGMLL : IKDMCJPBBIH
{
	private readonly Action<bool, ClUserScoresResponseMessage> JCOKJJGCPHI;

	private readonly List<long> BMMMCNPAEJK;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.CL_USER_SCORES_MSG;
		}
	}

	public NCJDJEAGMLL(List<long> MMDFMHHMKLN, Action<bool, ClUserScoresResponseMessage> IMHLFAHONPP)
	{
		JCOKJJGCPHI = IMHLFAHONPP;
		BMMMCNPAEJK = MMDFMHHMKLN;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		ClUserScoresMessage clUserScoresMessage = new ClUserScoresMessage();
		clUserScoresMessage.idList.AddRange(BMMMCNPAEJK);
		IKDMCJPBBIH.MCAAJOHOFGL(clUserScoresMessage, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.CL_USER_SCORES_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(ClUserScoresResponseMessage);
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(false, null);
		}
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		ClUserScoresResponseMessage oMJOIIOONMO = (ClUserScoresResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new KMEMDKODNKA(oMJOIIOONMO, JCOKJJGCPHI, this, NONNALMDLEL.KMJBHHCCJFD());
	}
}
