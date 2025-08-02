using Assets.Scripts.MapScene;
using Assets.Scripts.Utils.Analytics;
using UnityEngine;

public class LECPGNKOABP
{
	private const string HOCNFLLFJPN = "UserId";

	private const string ALFIFKBMDEA = "OldUserId";

	private const string IJJJOBMHKAD = "UserToken";

	private const string NLOIPHHCEBF = "OldUserToken";

	private const string IIIJJEFPDIB = "FBId";

	private const string DJDBLNNNLMK = "FBToken";

	private const string JCBLBDHLMGN = "FBName";

	private const string HLDODCJOKDC = "KeyDeviceId";

	private const string BELEGKCBNLE = "TeamId";

	private const string FIKDABIMNIA = "TeamName";

	private const string OCNJIOEICCI = "NickName";

	private const string OABDDAJACMM = "TeamMemberCount";

	private static LECPGNKOABP KNPOFJNFLJB;

	private readonly HJBLKNBHMFJ NJCPCACOCGB;

	private bool ICOJKJFGNGG;

	private string BLEJGEMEGAH;

	private string JELFOBPBKKM;

	private string ELKOCKPEEAG;

	private long HNDDIFIANKG;

	private string OFEHKAGIMPJ;

	private string DOBGLNDJHPI;

	private long KKMIEDBFCOB;

	private string DNPADLLBDDC;

	private int DLKNMNAOKDI;

	public bool ILNAPPDKOOD;

	public static LECPGNKOABP GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new LECPGNKOABP();
			}
			return KNPOFJNFLJB;
		}
	}

	public string MPIDFEMEEIJ { get; private set; }

	public long GDMECFECCOM
	{
		get
		{
			if (ICOJKJFGNGG)
			{
				return HNDDIFIANKG;
			}
			FBIENBBONFD();
			return HNDDIFIANKG;
		}
		set
		{
			HNDDIFIANKG = value;
		}
	}

	public string FIPPLABNDON
	{
		get
		{
			if (ICOJKJFGNGG)
			{
				return ELKOCKPEEAG;
			}
			FBIENBBONFD();
			return ELKOCKPEEAG;
		}
		set
		{
			ELKOCKPEEAG = value;
		}
	}

	public string LEOJICDDHHF
	{
		get
		{
			if (ICOJKJFGNGG)
			{
				return OFEHKAGIMPJ;
			}
			FBIENBBONFD();
			return OFEHKAGIMPJ;
		}
		set
		{
			OFEHKAGIMPJ = value;
		}
	}

	public bool FBJPAPPABGJ
	{
		get
		{
			return PlayerPrefs.HasKey("DeviceBan");
		}
		set
		{
			if (value)
			{
				GDMECFECCOM = 0L;
				PlayerPrefs.SetInt("DeviceBan", 1);
			}
			else
			{
				PlayerPrefs.DeleteKey("DeviceBan");
			}
		}
	}

	public string EHNKLBBAKCA
	{
		get
		{
			if (ICOJKJFGNGG)
			{
				return BLEJGEMEGAH;
			}
			FBIENBBONFD();
			return BLEJGEMEGAH;
		}
		set
		{
			BLEJGEMEGAH = value;
		}
	}

	public string KMHPHBJCPJH
	{
		get
		{
			if (ICOJKJFGNGG)
			{
				return JELFOBPBKKM;
			}
			FBIENBBONFD();
			return JELFOBPBKKM;
		}
		set
		{
			JELFOBPBKKM = value;
		}
	}

	public string KJACEODCOHN
	{
		get
		{
			return DNPADLLBDDC;
		}
	}

	public string EFHEIFMEJCN
	{
		get
		{
			return DOBGLNDJHPI;
		}
	}

	public long OADDPGNIINO
	{
		get
		{
			return KKMIEDBFCOB;
		}
	}

	public int CPIKDFFHGCI
	{
		get
		{
			return DLKNMNAOKDI;
		}
	}

	public string BKPHBOCNCGO
	{
		get
		{
			return NJCPCACOCGB.LIANKDMAHFM("OldUserId");
		}
		set
		{
			NJCPCACOCGB.JGMDDMNGDJO("OldUserId", value);
		}
	}

	public string DBMLEMDDNCE
	{
		get
		{
			return NJCPCACOCGB.LIANKDMAHFM("OldUserToken");
		}
		set
		{
			NJCPCACOCGB.JGMDDMNGDJO("OldUserToken", value);
		}
	}

	public bool LJEIKNAKAJD
	{
		get
		{
			return GFHPEDILAJG.GABGKBAKHDP.ODMCGBLJFKM || GEMKAINJDFE(GDMECFECCOM) != 0;
		}
	}

	private LECPGNKOABP()
	{
		NJCPCACOCGB = HJBLKNBHMFJ.GABGKBAKHDP;
		ILNAPPDKOOD = GEBAAFFGKJG.GABGKBAKHDP.ACBHOCGJHHF(NJGLIIMEMBI.USER_TYPE_PAID);
		AEMKFKIBDGO(false);
	}

	public void AEMKFKIBDGO(bool PBFKBIJFOJK)
	{
		if (PBFKBIJFOJK)
		{
			NJCPCACOCGB.MFKBEDNLCJA("KeyDeviceId");
		}
		MPIDFEMEEIJ = NJCPCACOCGB.LIANKDMAHFM("KeyDeviceId");
		if (MPIDFEMEEIJ == null)
		{
			DEDNLGAFIDJ dEDNLGAFIDJ = new DEDNLGAFIDJ(null, "KeyDeviceId", LEGLDMIFBLN.NMLEKDPKNLB().JBGOANMLBFA);
			NJCPCACOCGB.LFHHPPDJGDC(dEDNLGAFIDJ);
			MPIDFEMEEIJ = dEDNLGAFIDJ.JBGOANMLBFA;
		}
	}

	private void FBIENBBONFD()
	{
		string text = NJCPCACOCGB.LIANKDMAHFM("UserId");
		if (text == null)
		{
			HNDDIFIANKG = 0L;
		}
		else
		{
			long.TryParse(text, out HNDDIFIANKG);
		}
		ELKOCKPEEAG = NJCPCACOCGB.LIANKDMAHFM("UserToken");
		BLEJGEMEGAH = NJCPCACOCGB.LIANKDMAHFM("FBId");
		JELFOBPBKKM = NJCPCACOCGB.LIANKDMAHFM("FBToken");
		OFEHKAGIMPJ = NJCPCACOCGB.LIANKDMAHFM("FBName");
		long.TryParse(NJCPCACOCGB.LIANKDMAHFM("TeamId"), out KKMIEDBFCOB);
		int.TryParse(NJCPCACOCGB.LIANKDMAHFM("TeamMemberCount"), out DLKNMNAOKDI);
		DOBGLNDJHPI = NJCPCACOCGB.LIANKDMAHFM("TeamName");
		DNPADLLBDDC = NJCPCACOCGB.LIANKDMAHFM("NickName");
		ICOJKJFGNGG = true;
	}

	public void EDHAJCFFACD()
	{
		NJCPCACOCGB.JGMDDMNGDJO("UserId", HNDDIFIANKG.ToString());
		NJCPCACOCGB.JGMDDMNGDJO("UserToken", ELKOCKPEEAG);
		NJCPCACOCGB.JGMDDMNGDJO("FBId", BLEJGEMEGAH);
		NJCPCACOCGB.JGMDDMNGDJO("FBToken", JELFOBPBKKM);
		NJCPCACOCGB.JGMDDMNGDJO("FBName", OFEHKAGIMPJ);
		NJCPCACOCGB.JGMDDMNGDJO("TeamId", KKMIEDBFCOB.ToString());
		NJCPCACOCGB.JGMDDMNGDJO("TeamName", EFHEIFMEJCN);
		NJCPCACOCGB.JGMDDMNGDJO("NickName", DNPADLLBDDC);
		NJCPCACOCGB.JGMDDMNGDJO("TeamMemberCount", DLKNMNAOKDI.ToString());
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.UserIdHelper, "User Id {0} (FB:{1}) and Tokens Updated to DB.", HNDDIFIANKG, BLEJGEMEGAH);
	}

	public void AIFPMKNFFJI(long EMNOJOHFMEH, string GKNCJMICJEL, int MIJNCHHBBCA)
	{
		string text = EMNOJOHFMEH.ToString();
		string text2 = MIJNCHHBBCA.ToString();
		NJCPCACOCGB.JGMDDMNGDJO("TeamId", text);
		NJCPCACOCGB.JGMDDMNGDJO("TeamId" + GDMECFECCOM, text);
		NJCPCACOCGB.JGMDDMNGDJO("TeamName", GKNCJMICJEL);
		NJCPCACOCGB.JGMDDMNGDJO("TeamMemberCount", text2);
		OneSignal.SendTag("TeamIdTag", EMNOJOHFMEH.ToString());
		KKMIEDBFCOB = EMNOJOHFMEH;
		DOBGLNDJHPI = GKNCJMICJEL;
		DLKNMNAOKDI = MIJNCHHBBCA;
		if (KKMIEDBFCOB == 0)
		{
			GFHPEDILAJG.GABGKBAKHDP.ODMCGBLJFKM = false;
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.UserIdHelper, "Team is {0}-{1}-{2} stored.", text, GKNCJMICJEL, text2);
	}

	public void MHBOHLJEBOE(string FBKDKPCDMMK)
	{
		if (!string.IsNullOrEmpty(FBKDKPCDMMK) && !(FBKDKPCDMMK == DNPADLLBDDC))
		{
			NJCPCACOCGB.JGMDDMNGDJO("NickName", FBKDKPCDMMK);
			DNPADLLBDDC = FBKDKPCDMMK;
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.UserIdHelper, "Nick Name:{0} stored.", FBKDKPCDMMK);
			FIFPLICICKP.GABGKBAKHDP.BAFBKBIKHKC();
			FFGIDMDAGOA.GABGKBAKHDP.BAFBKBIKHKC();
			if (MapManager.Instance != null)
			{
				MapManager.Instance.CurrentLeaderboardPageController.CurrentFacebookLeaderboardTabPage.UpdateLeaderboardData();
				MapManager.Instance.CurrentLeaderboardPageController.CurrentPlayersLeaderboardTabPage.UpdateLeaderboardData();
			}
			AAPMDEEMEMM aAPMDEEMEMM = DGOMNDMPMBG.GABGKBAKHDP.BHGCBNAMEFK;
			if (aAPMDEEMEMM != null)
			{
				aAPMDEEMEMM.MHBOHLJEBOE();
			}
		}
	}

	public void IIAEIGEFCEN()
	{
		NJCPCACOCGB.JGMDDMNGDJO("OldUserId", HNDDIFIANKG.ToString());
		NJCPCACOCGB.JGMDDMNGDJO("OldUserToken", ELKOCKPEEAG);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.UserIdHelper, "User Id {0} and Token {0} stored as old userId.", HNDDIFIANKG);
	}

	public bool BJLBIBDKADC()
	{
		return EHNKLBBAKCA != null;
	}

	public void DMFMPDADFJK()
	{
		string text = NJCPCACOCGB.LIANKDMAHFM("OldUserId");
		HNDDIFIANKG = 0L;
		JELFOBPBKKM = null;
		EHNKLBBAKCA = null;
		OFEHKAGIMPJ = null;
		FIPPLABNDON = null;
		long.TryParse(text, out HNDDIFIANKG);
		if (HNDDIFIANKG > 0)
		{
			FIPPLABNDON = NJCPCACOCGB.LIANKDMAHFM("OldUserToken");
			CAGBGIHKHEJ.GABGKBAKHDP.EOCDBIHEMJM(text);
			OneSignal.SendTag("UserIdTag", GDMECFECCOM.ToString());
		}
		NAAGDFCLOPE.GABGKBAKHDP.BINDEBHMEJC.FJHHIDCICNG();
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.UserIdHelper, "Id {0} selected as old user.", GDMECFECCOM);
		NJCPCACOCGB.MFKBEDNLCJA("OldUserId");
		NJCPCACOCGB.MFKBEDNLCJA("OldUserToken");
		EDHAJCFFACD();
	}

	public static long GEMKAINJDFE(long BPKJLGJDFKG)
	{
		long result = 0L;
		long.TryParse(HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("TeamId" + BPKJLGJDFKG), out result);
		return result;
	}

	public void OMOKOKFNBKI()
	{
		AEMKFKIBDGO(true);
		GDMECFECCOM = 0L;
		FIPPLABNDON = null;
		EHNKLBBAKCA = null;
		KMHPHBJCPJH = null;
		LEOJICDDHHF = null;
		ILNAPPDKOOD = false;
		DNPADLLBDDC = null;
		DOBGLNDJHPI = null;
		KKMIEDBFCOB = 0L;
		EDHAJCFFACD();
		PeakAnalytics.ResetApplicationUserId();
	}
}
