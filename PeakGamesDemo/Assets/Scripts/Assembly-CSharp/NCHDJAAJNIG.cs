using System;
using Assets.Scripts.Utils;
using caravan.protobuf.messages;

public class NCHDJAAJNIG : IKDMCJPBBIH
{
	private InventoryMetaData LKGELHNGFHI;

	private readonly Action DJPNBGABBOI;

	private int IBHDKBDNCMG;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.SYNC_INVENTORY_MSG;
		}
	}

	public NCHDJAAJNIG(Action JPOGFGMLKJF = null)
	{
		DJPNBGABBOI = JPOGFGMLKJF;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		SyncInventoryMessage syncInventoryMessage = new SyncInventoryMessage();
		LKGELHNGFHI = HFCHLIPLMMC();
		syncInventoryMessage.inventory = LKGELHNGFHI;
		IKDMCJPBBIH.MCAAJOHOFGL(syncInventoryMessage, genericMessage);
		IBHDKBDNCMG = FocusListener.MOGJKPIEGGL;
		return genericMessage;
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		if (DJPNBGABBOI != null)
		{
			DJPNBGABBOI();
		}
	}

	public override bool NAFCDEECGEF()
	{
		bool flag = GEBAAFFGKJG.GABGKBAKHDP.EFPJIIBFLJI();
		if (!flag && DJPNBGABBOI != null)
		{
			DJPNBGABBOI();
		}
		return flag;
	}

	public static InventoryMetaData HFCHLIPLMMC()
	{
		GEBAAFFGKJG gEBAAFFGKJG = GEBAAFFGKJG.GABGKBAKHDP;
		InventoryMetaData inventoryMetaData = new InventoryMetaData();
		inventoryMetaData.anvil = gEBAAFFGKJG.JFGLEMPLBKE(NAAHKHPBAPA.Anvil);
		inventoryMetaData.bomb = gEBAAFFGKJG.JFGLEMPLBKE(NAAHKHPBAPA.Bomb);
		inventoryMetaData.boxingGlove = gEBAAFFGKJG.JFGLEMPLBKE(NAAHKHPBAPA.BoxingGlove);
		inventoryMetaData.coins = gEBAAFFGKJG.JFGLEMPLBKE(NAAHKHPBAPA.Coins);
		inventoryMetaData.discoBall = gEBAAFFGKJG.JFGLEMPLBKE(NAAHKHPBAPA.DiscoBall);
		inventoryMetaData.shuffle = gEBAAFFGKJG.JFGLEMPLBKE(NAAHKHPBAPA.Dice);
		inventoryMetaData.extra5Moves = gEBAAFFGKJG.JFGLEMPLBKE(NAAHKHPBAPA.Extra5Moves);
		inventoryMetaData.hammer = gEBAAFFGKJG.JFGLEMPLBKE(NAAHKHPBAPA.Hammer);
		inventoryMetaData.rocket = gEBAAFFGKJG.JFGLEMPLBKE(NAAHKHPBAPA.Rocket);
		inventoryMetaData.userType = gEBAAFFGKJG.JFGLEMPLBKE(NAAHKHPBAPA.UserType);
		inventoryMetaData.stars = gEBAAFFGKJG.JFGLEMPLBKE(NAAHKHPBAPA.Stars);
		inventoryMetaData.lifeTime = PJPPADHKGHN.GABGKBAKHDP.AINIOIILGBG();
		inventoryMetaData.life = gEBAAFFGKJG.JFGLEMPLBKE(NAAHKHPBAPA.Life);
		inventoryMetaData.piggyBank = gEBAAFFGKJG.JFGLEMPLBKE(NAAHKHPBAPA.Key);
		InventoryMetaData inventoryMetaData2 = inventoryMetaData;
		if (!gEBAAFFGKJG.AAPIPCCINJJ(NAAHKHPBAPA.UnlimitedLife))
		{
			inventoryMetaData2.unlimitedLife = PJPPADHKGHN.GABGKBAKHDP.HNBIMJHPIPE();
			if (inventoryMetaData2.unlimitedLife == 0)
			{
				inventoryMetaData2.unlimitedLife = -1;
			}
		}
		return inventoryMetaData2;
	}

	public static bool OPKHPMCHKOD(InventoryMetaData IPLOADIDNGG)
	{
		return IPLOADIDNGG.anvil == GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Anvil) && IPLOADIDNGG.bomb == GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Bomb) && IPLOADIDNGG.boxingGlove == GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.BoxingGlove) && IPLOADIDNGG.coins == GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins) && IPLOADIDNGG.discoBall == GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.DiscoBall) && IPLOADIDNGG.shuffle == GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Dice) && IPLOADIDNGG.extra5Moves == GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Extra5Moves) && IPLOADIDNGG.hammer == GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Hammer) && IPLOADIDNGG.rocket == GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Rocket) && IPLOADIDNGG.userType == GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.UserType) && IPLOADIDNGG.stars == GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Stars) && IPLOADIDNGG.life == GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Life) && IPLOADIDNGG.piggyBank == GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Key);
	}

	public bool ELDBGPGMBBK()
	{
		return GEBAAFFGKJG.GABGKBAKHDP.EFPJIIBFLJI();
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.SYNC_INVENTORY_RESPONSE_MSG;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(SyncInventoryResponseMessage);
	}

	protected override void NLMICJNOMCD(object DBAKHMDKCAM, ResultCodes NONNALMDLEL)
	{
		SyncInventoryResponseMessage dIDHNNMKJFE = DBAKHMDKCAM as SyncInventoryResponseMessage;
		ICKPFMKIIBM = new CLFGECOMHHE(this, NONNALMDLEL.KMJBHHCCJFD(), dIDHNNMKJFE, LKGELHNGFHI, IBHDKBDNCMG, DJPNBGABBOI);
	}
}
