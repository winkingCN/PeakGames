using caravan.protobuf.messages;

public class IMLNKMACKMF
{
	private const string EPLKHCFEKAB = "ServerMaxLevel";

	private const string KAABLJIJECP = "ServerVersion";

	private const string HKMJOAPHAAB = "ClientMinVersion";

	private const string PHFHCOOKBIL = "SyncInventoryInterval";

	private static IMLNKMACKMF KNPOFJNFLJB;

	private readonly HJBLKNBHMFJ NJCPCACOCGB;

	public static IMLNKMACKMF GABGKBAKHDP
	{
		get
		{
			return KNPOFJNFLJB ?? (KNPOFJNFLJB = new IMLNKMACKMF());
		}
	}

	public int PCBNDMDMAHJ { get; private set; }

	public string PJJKOIEAGJN { get; private set; }

	public string BCDBJPFBCFJ { get; private set; }

	public int AHGIOEDLGEE { get; private set; }

	private IMLNKMACKMF()
	{
		NJCPCACOCGB = HJBLKNBHMFJ.GABGKBAKHDP;
		BCDBJPFBCFJ = NJCPCACOCGB.LIANKDMAHFM("ClientMinVersion");
		PJJKOIEAGJN = NJCPCACOCGB.LIANKDMAHFM("ServerVersion");
		int result;
		int.TryParse(NJCPCACOCGB.LIANKDMAHFM("ServerMaxLevel"), out result);
		PCBNDMDMAHJ = result;
		int result2;
		int.TryParse(NJCPCACOCGB.LIANKDMAHFM("SyncInventoryInterval"), out result2);
		AHGIOEDLGEE = result2;
	}

	public void IDHKACACBNG(GetInfoResponseMessage OGDMPMNABEO)
	{
		PCBNDMDMAHJ = OGDMPMNABEO.clientInfo.maxLevel;
		PJJKOIEAGJN = OGDMPMNABEO.serverVersion;
		AHGIOEDLGEE = OGDMPMNABEO.clientInfo.syncInventoryInterval;
		BCDBJPFBCFJ = EGOHBHDLCFL(OGDMPMNABEO).ToString();
		NJCPCACOCGB.JGMDDMNGDJO("ServerMaxLevel", PCBNDMDMAHJ.ToString());
		NJCPCACOCGB.JGMDDMNGDJO("ServerVersion", PJJKOIEAGJN);
		NJCPCACOCGB.JGMDDMNGDJO("ClientMinVersion", BCDBJPFBCFJ);
		NJCPCACOCGB.JGMDDMNGDJO("SyncInventoryInterval", AHGIOEDLGEE.ToString());
	}

	private int EGOHBHDLCFL(GetInfoResponseMessage OGDMPMNABEO)
	{
		return OGDMPMNABEO.clientInfo.forceMinAndroidVersion;
	}
}
