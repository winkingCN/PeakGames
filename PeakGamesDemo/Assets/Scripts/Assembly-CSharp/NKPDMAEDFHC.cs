using System;
using caravan.protobuf.messages;

public class NKPDMAEDFHC : IKDMCJPBBIH
{
	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.SYNC_CHEST_MSG;
		}
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		SyncChestMessage syncChestMessage = new SyncChestMessage();
		ChestMetaData chestMetaData = new ChestMetaData();
		chestMetaData.toonChest = NDGOJGLPIJF.GABGKBAKHDP.KCJHDPCLPDL();
		ChestMetaData chests = chestMetaData;
		syncChestMessage.chests = chests;
		IKDMCJPBBIH.MCAAJOHOFGL(syncChestMessage, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.SYNC_CHEST_RESPONSE;
	}

	protected override Type JLFLPEDHMOE()
	{
		return null;
	}

	protected override void NLMICJNOMCD(object GDFBAKKHFIC, ResultCodes NONNALMDLEL)
	{
		ICKPFMKIIBM = new MFEGKKHHAOP(this, NONNALMDLEL.KMJBHHCCJFD());
	}
}
