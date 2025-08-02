using System;
using System.Collections.Generic;
using caravan.protobuf.messages;

public class JOPDCIADIEB : IKDMCJPBBIH
{
	private readonly List<NIGFCEFLHML> GPIGHIKBIIL;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.SYNC_LEVEL_MSG;
		}
	}

	public JOPDCIADIEB()
	{
		GPIGHIKBIIL = MADFPPJCOIM.GABGKBAKHDP.NJHNMKHFJMB();
	}

	public override bool NAFCDEECGEF()
	{
		return MADFPPJCOIM.GABGKBAKHDP.IHIKJJMGNPJ();
	}

	public bool ELDBGPGMBBK()
	{
		return GPIGHIKBIIL != null && GPIGHIKBIIL.Count > 0;
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LevelProgressReply, "PerformFailureOperation (NoReply)");
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		SyncLevelMessage syncLevelMessage = new SyncLevelMessage();
		if (GPIGHIKBIIL != null)
		{
			for (int i = 0; i < GPIGHIKBIIL.Count; i++)
			{
				NIGFCEFLHML nIGFCEFLHML = GPIGHIKBIIL[i];
				UserLevelProgressMetaData userLevelProgressMetaData = new UserLevelProgressMetaData();
				userLevelProgressMetaData.levelNo = nIGFCEFLHML.PDGLECFDLJJ;
				userLevelProgressMetaData.score = nIGFCEFLHML.DJADMBLKBKJ;
				userLevelProgressMetaData.stars = nIGFCEFLHML.EMNDJNDGANP;
				UserLevelProgressMetaData item = userLevelProgressMetaData;
				syncLevelMessage.progress.Add(item);
			}
		}
		IKDMCJPBBIH.MCAAJOHOFGL(syncLevelMessage, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.SYNC_LEVEL_RESPONSE_MSG;
	}

	protected override Type JLFLPEDHMOE()
	{
		return null;
	}

	protected override void NLMICJNOMCD(object INGDJMDGCOO, ResultCodes NONNALMDLEL)
	{
		ICKPFMKIIBM = new BFOEKPLEPHB(this, GPIGHIKBIIL, NONNALMDLEL.KMJBHHCCJFD());
	}
}
