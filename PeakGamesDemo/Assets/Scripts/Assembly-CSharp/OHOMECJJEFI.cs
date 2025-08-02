using System;
using System.Collections.Generic;
using caravan.protobuf.messages;

public class OHOMECJJEFI : IKDMCJPBBIH
{
	private readonly Action<bool, bool> EDCHPJKMOBD;

	private readonly List<NIGFCEFLHML> GPIGHIKBIIL;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.SYNC_FULL_MSG;
		}
	}

	public OHOMECJJEFI(Action<bool, bool> BMHDOOHDKBF = null)
	{
		EDCHPJKMOBD = BMHDOOHDKBF;
		if (!ELBMHNOBHPN.DJGMHLLAGLE)
		{
			GPIGHIKBIIL = MADFPPJCOIM.GABGKBAKHDP.NJHNMKHFJMB();
		}
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		if (ELBMHNOBHPN.DJGMHLLAGLE)
		{
			return genericMessage;
		}
		SyncFullMessage syncFullMessage = new SyncFullMessage();
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
				syncFullMessage.levelProgress.Add(item);
			}
		}
		syncFullMessage.inventory = NCHDJAAJNIG.HFCHLIPLMMC();
		syncFullMessage.chests = new ChestMetaData
		{
			toonChest = NDGOJGLPIJF.GABGKBAKHDP.KCJHDPCLPDL()
		};
		IDFPAFEJPPH iDFPAFEJPPH = IDFPAFEJPPH.GABGKBAKHDP;
		if (iDFPAFEJPPH.HGNJBHGBLIN)
		{
			syncFullMessage.clId = iDFPAFEJPPH.NBJMMBIGCOB;
			syncFullMessage.clLevel = iDFPAFEJPPH.PDGLECFDLJJ;
		}
		IKDMCJPBBIH.MCAAJOHOFGL(syncFullMessage, genericMessage);
		return genericMessage;
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		if (EDCHPJKMOBD != null)
		{
			EDCHPJKMOBD(false, false);
		}
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.SYNC_FULL_RESPONSE_MSG;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(SyncFullResponseMessage);
	}

	protected override void NLMICJNOMCD(object DBAKHMDKCAM, ResultCodes NONNALMDLEL)
	{
		SyncFullResponseMessage iEJCPMCPHMM = (SyncFullResponseMessage)DBAKHMDKCAM;
		ICKPFMKIIBM = new BLEMFIKALJF(this, iEJCPMCPHMM, EDCHPJKMOBD, NONNALMDLEL.KMJBHHCCJFD());
	}

	public bool JBGDBIIIPLM()
	{
		return (GPIGHIKBIIL != null && GPIGHIKBIIL.Count > 0) || GEBAAFFGKJG.GABGKBAKHDP.EFPJIIBFLJI();
	}
}
