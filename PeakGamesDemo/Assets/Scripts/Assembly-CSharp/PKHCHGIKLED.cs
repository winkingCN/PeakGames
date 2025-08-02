using System;
using caravan.protobuf.messages;

public class PKHCHGIKLED : IKDMCJPBBIH
{
	private readonly Action<bool> JCOKJJGCPHI;

	private readonly int NOCOIFPDNLL;

	private readonly int EADEMDIHGHE;

	private readonly int BHHPJECICHH;

	private readonly int FLHHKMBFCFC;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.CL_SYNC_LEVEL_MSG;
		}
	}

	public PKHCHGIKLED(int FLMKBEFILAB, int KIGOGMKCDKN, int MFFLPDALICD, int FMFBDBCMDBO)
	{
		NOCOIFPDNLL = FLMKBEFILAB;
		EADEMDIHGHE = KIGOGMKCDKN;
		BHHPJECICHH = FMFBDBCMDBO;
		FLHHKMBFCFC = MFFLPDALICD;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		ClSyncLevelMessage clSyncLevelMessage = new ClSyncLevelMessage();
		clSyncLevelMessage.index = NOCOIFPDNLL;
		clSyncLevelMessage.levelId = EADEMDIHGHE;
		clSyncLevelMessage.star = FLHHKMBFCFC;
		clSyncLevelMessage.ClId = BHHPJECICHH;
		ClSyncLevelMessage fNHFILKPEDI = clSyncLevelMessage;
		IKDMCJPBBIH.MCAAJOHOFGL(fNHFILKPEDI, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.CL_SYNC_LEVEL_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return null;
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		ICKPFMKIIBM = new NIGAIKMDMOD(this, NONNALMDLEL.KMJBHHCCJFD());
	}
}
