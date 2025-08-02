using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Assets.Scripts.MapScene;
using DataHelpers;
using LevelLoaderScene;
using NewMapScene;
using UnityEngine;
using caravan.protobuf.messages;

public class IDFPAFEJPPH : DLDDFKDFKEF
{
	public const int JBHBFFOBCHA = 0;

	private const string HEIJEPBLBDK = "ChampionsLeagueId";

	private const string MMBKIAMHBOJ = "ChampionsLeagueEndTime";

	private const string CNNFKEIPLHN = "ChampionsLeagueStatus";

	private const string BNDIELCMCJP = "ChampionsLeagueGroup";

	private const string GGOINEPFHLJ = "ChampionsLeagueLevels";

	private const string DDNCDHDLOLG = "ChampionsLeagueLevelIndex";

	private const string ABHNCIEOBHB = "ChampionsLeagueRank";

	private const string LBCMJJFEDJB = "ChampionsLeagueRewards";

	private const string AFOGPHMCPLN = "Stage";

	public const int IOJIADFHPLP = 3600;

	private MJHDGFJDGOM OMAFAHLOEHF;

	private int[] LFGIAIGKNMO = new int[0];

	private int[] NDJDFBDBEKJ = new int[0];

	private long HNPLOINNECM;

	private int NACOGGLHJDE;

	private readonly HJBLKNBHMFJ GOEMHMEALGJ;

	private readonly CLJBOPHAOOD IJMGKCMGPNC;

	private readonly MGNLLDDOHKN NEOKHIDFNCK;

	private readonly string HNDDIFIANKG;

	private static IDFPAFEJPPH KNPOFJNFLJB;

	[CompilerGenerated]
	private static Func<ClMember, int> EBCOMJBLIPP;

	[CompilerGenerated]
	private static Func<ClMember, long> DNBOPLHGMHA;

	[CompilerGenerated]
	private static Func<ClMember, int> JFHCKLHBBDI;

	[CompilerGenerated]
	private static Func<ClMember, long> NOGHOEBDKAH;

	public ClStatusType AEPLIGFCGIF { get; private set; }

	public int INFAGKCBEHL { get; private set; }

	public int OHAPPDGAKNG { get; private set; }

	public int NBJMMBIGCOB { get; private set; }

	public IList<ClMember> NDABFDHPIBB { get; private set; }

	public bool BKHKOOOFMBI
	{
		get
		{
			return MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() >= 2850 && (AEPLIGFCGIF == ClStatusType.CLOSED || (AEPLIGFCGIF == ClStatusType.OPEN && AEBACBBGHKI <= 3600));
		}
	}

	public bool HFAHKLBJAEC
	{
		get
		{
			return AEPLIGFCGIF == ClStatusType.OPEN && AEBACBBGHKI > 3600 && MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() >= 2850;
		}
	}

	public bool HGNJBHGBLIN
	{
		get
		{
			return (AEPLIGFCGIF == ClStatusType.CONNECTED || AEPLIGFCGIF == ClStatusType.FINISHED) && MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() >= 2850 && IMLNKMACKMF.GABGKBAKHDP.PCBNDMDMAHJ > 0 && IMLNKMACKMF.GABGKBAKHDP.PCBNDMDMAHJ <= 2850 && !LevelLoaderController.IsOnlineLevel;
		}
	}

	public bool GMLKJFHEDPF
	{
		get
		{
			return AEPLIGFCGIF == ClStatusType.FINISHED && NDABFDHPIBB != null;
		}
	}

	public int MMFJEAJBJJG
	{
		get
		{
			return OMAFAHLOEHF.EMNDJNDGANP;
		}
	}

	public int PDGLECFDLJJ
	{
		get
		{
			return (OMAFAHLOEHF.PENJCGPCHHD < 0) ? 1 : (OMAFAHLOEHF.PENJCGPCHHD + 1);
		}
	}

	public int KOPMPMIFHNF
	{
		get
		{
			if (LFGIAIGKNMO == null || LFGIAIGKNMO.Length <= 0 || OMAFAHLOEHF.PENJCGPCHHD < 0)
			{
				return 1;
			}
			return LFGIAIGKNMO[OMAFAHLOEHF.PENJCGPCHHD % LFGIAIGKNMO.Length];
		}
	}

	public int BFBNJLMHPFA
	{
		get
		{
			if (NDJDFBDBEKJ == null || NDJDFBDBEKJ.Length <= 0 || OMAFAHLOEHF.PENJCGPCHHD < 0)
			{
				return 1;
			}
			return NDJDFBDBEKJ[OMAFAHLOEHF.PENJCGPCHHD % NDJDFBDBEKJ.Length];
		}
	}

	public long AEBACBBGHKI
	{
		get
		{
			long num = HNPLOINNECM - FIBJIOBINHL.CFBJBKEPGAN();
			return (num <= 0) ? 0 : num;
		}
	}

	public string EGLOCAFPJCJ
	{
		get
		{
			return NKILHODNBDE.GHBGCADFLFB("Stage") + PDGLECFDLJJ;
		}
	}

	public static IDFPAFEJPPH GABGKBAKHDP
	{
		get
		{
			return KNPOFJNFLJB ?? (KNPOFJNFLJB = new IDFPAFEJPPH());
		}
	}

	private IDFPAFEJPPH()
	{
		GOEMHMEALGJ = HJBLKNBHMFJ.GABGKBAKHDP;
		IJMGKCMGPNC = CLJBOPHAOOD.GABGKBAKHDP;
		NEOKHIDFNCK = MGNLLDDOHKN.GABGKBAKHDP;
		HNDDIFIANKG = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString();
		LKCHPMJGEJD();
	}

	private void NFJLCNBOGEF()
	{
		string text = GOEMHMEALGJ.LIANKDMAHFM("ChampionsLeagueLevels");
		if (text != null)
		{
			HJLEALADJMP(text);
		}
	}

	private void HJLEALADJMP(string BAMAKPODMHM)
	{
		if (!string.IsNullOrEmpty(BAMAKPODMHM))
		{
			string[] array = BAMAKPODMHM.Split('\n');
			LFGIAIGKNMO = new int[array.Length];
			NDJDFBDBEKJ = new int[array.Length];
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				string[] array2 = array[i].Split(',');
				LFGIAIGKNMO[i] = int.Parse(array2[0]);
				NDJDFBDBEKJ[i] = int.Parse(array2[1]);
			}
		}
	}

	public void DIAHJABEJPC()
	{
		OMAFAHLOEHF.EMNDJNDGANP = 0;
	}

	private void ACFAKOCLJKD(string CGNGMKJIGAC)
	{
		GOEMHMEALGJ.JGMDDMNGDJO("ChampionsLeagueLevels", CGNGMKJIGAC);
		HJLEALADJMP(CGNGMKJIGAC);
	}

	public void JBHEPDBAEBP(int HCCBDFMKLHN)
	{
		OMAFAHLOEHF.PENJCGPCHHD++;
		OMAFAHLOEHF.EMNDJNDGANP += HCCBDFMKLHN;
		NEOKHIDFNCK.JGMDDMNGDJO("ChampionsLeagueLevelIndex", OMAFAHLOEHF.ToString());
	}

	private void LKCHPMJGEJD()
	{
		HNPLOINNECM = FIAHJHNMKAF("ChampionsLeagueEndTime");
		NBJMMBIGCOB = FPENEMMAKPP("ChampionsLeagueId");
		INFAGKCBEHL = EKIKNLBEOOH();
		AEPLIGFCGIF = AFLGIABHGEO();
		OHAPPDGAKNG = DGJEOJJLPFK();
		OMAFAHLOEHF = new MJHDGFJDGOM(NEOKHIDFNCK.LIANKDMAHFM("ChampionsLeagueLevelIndex"));
		NFJLCNBOGEF();
	}

	private int FPENEMMAKPP(string IKNCPEPOKGJ)
	{
		string text = GOEMHMEALGJ.LIANKDMAHFM(IKNCPEPOKGJ);
		if (text != null)
		{
			return int.Parse(text);
		}
		return -1;
	}

	private long FIAHJHNMKAF(string IKNCPEPOKGJ)
	{
		string text = GOEMHMEALGJ.LIANKDMAHFM(IKNCPEPOKGJ);
		if (text != null)
		{
			return long.Parse(text);
		}
		return -1L;
	}

	private ClStatusType AFLGIABHGEO()
	{
		ClStatusType result = ClStatusType.CLOSED;
		string text = GOEMHMEALGJ.LIANKDMAHFM("ChampionsLeagueStatus");
		if (text != null)
		{
			result = (ClStatusType)Enum.Parse(typeof(ClStatusType), text);
		}
		return result;
	}

	private int EKIKNLBEOOH()
	{
		int num = FPENEMMAKPP("ChampionsLeagueGroup");
		if (num <= 0)
		{
			num = FPENEMMAKPP("ChampionsLeagueGroup" + HNDDIFIANKG);
		}
		return num;
	}

	private int DGJEOJJLPFK()
	{
		int num = IJMGKCMGPNC.LIANKDMAHFM("ChampionsLeagueRank");
		if (num <= 0)
		{
			num = FPENEMMAKPP("ChampionsLeagueRank" + HNDDIFIANKG);
		}
		return num;
	}

	public IKDMCJPBBIH EBAMEPLFLKO()
	{
		return new OMMPHPJNNBD(delegate(bool EEKJMDHEJCK, ClStatusResponseMessage OMJOIIOONMO)
		{
			if (EEKJMDHEJCK)
			{
				if (OMJOIIOONMO.status == ClStatusType.CLOSED)
				{
					OMOKOKFNBKI();
				}
				else
				{
					MGDJKABHDGJ(OMJOIIOONMO);
				}
				if (MapManager.Instance != null)
				{
					MapManager.Instance.ShouldShowChampionsLeague();
				}
			}
		});
	}

	public IKDMCJPBBIH CGOOBAHCDDK()
	{
		return new OMMPHPJNNBD(delegate(bool EEKJMDHEJCK, ClStatusResponseMessage OMJOIIOONMO)
		{
			MapManager instance = MapManager.Instance;
			if (!EEKJMDHEJCK)
			{
				if (instance != null)
				{
					instance.ShouldShowChampionsLeague();
				}
			}
			else
			{
				if (OMJOIIOONMO.status == ClStatusType.CLOSED)
				{
					OMOKOKFNBKI();
				}
				else
				{
					MGDJKABHDGJ(OMJOIIOONMO);
					NewMapAnimationController.AddToFocusAnimations("ChampionsLeagueAnimation");
				}
				if (instance != null)
				{
					instance.ShouldShowChampionsLeague();
				}
			}
		});
	}

	public void HBFHBJADBGL(ClLeaderboard IDPKMBFHBPC)
	{
		OHAPPDGAKNG = 0;
		INFAGKCBEHL = 0;
		NBJMMBIGCOB = 0;
		OMAFAHLOEHF = new MJHDGFJDGOM(string.Empty);
		GOEMHMEALGJ.MFKBEDNLCJA("ChampionsLeagueId");
		GOEMHMEALGJ.MFKBEDNLCJA("ChampionsLeagueEndTime");
		GOEMHMEALGJ.MFKBEDNLCJA("ChampionsLeagueStatus");
		GOEMHMEALGJ.MFKBEDNLCJA("ChampionsLeagueGroup");
		GOEMHMEALGJ.MFKBEDNLCJA("ChampionsLeagueLevels");
		IJMGKCMGPNC.MFKBEDNLCJA("ChampionsLeagueRank");
		NEOKHIDFNCK.MFKBEDNLCJA("ChampionsLeagueLevelIndex");
		GOEMHMEALGJ.MFKBEDNLCJA("ChampionsLeagueRank" + HNDDIFIANKG);
		GOEMHMEALGJ.MFKBEDNLCJA("ChampionsLeagueGroup" + HNDDIFIANKG);
		AEPLIGFCGIF = ClStatusType.CONNECTED;
		GOEMHMEALGJ.JGMDDMNGDJO("ChampionsLeagueStatus", AEPLIGFCGIF.ToString());
		CMEDAHCGBAN(IDPKMBFHBPC, false);
	}

	public void MGDJKABHDGJ(ClStatusResponseMessage BNKLFFOMBIO)
	{
		HNPLOINNECM = FIBJIOBINHL.CFBJBKEPGAN() + BNKLFFOMBIO.duration;
		bool pKMLEMIJBKA = NBJMMBIGCOB != BNKLFFOMBIO.ClId;
		NBJMMBIGCOB = BNKLFFOMBIO.ClId;
		AEPLIGFCGIF = BNKLFFOMBIO.status;
		GOEMHMEALGJ.JGMDDMNGDJO("ChampionsLeagueEndTime", HNPLOINNECM.ToString());
		GOEMHMEALGJ.JGMDDMNGDJO("ChampionsLeagueId", NBJMMBIGCOB.ToString());
		GOEMHMEALGJ.JGMDDMNGDJO("ChampionsLeagueStatus", AEPLIGFCGIF.ToString());
		GOEMHMEALGJ.JGMDDMNGDJO("ChampionsLeagueRewards", BNKLFFOMBIO.rewards);
		ACFAKOCLJKD(BNKLFFOMBIO.levels);
		CMEDAHCGBAN(BNKLFFOMBIO.leaderboard, pKMLEMIJBKA);
	}

	public void NMOPBGEBEMN(ClLeaderboard IDPKMBFHBPC)
	{
		if (IDPKMBFHBPC != null)
		{
			NDABFDHPIBB = (from MNIMEAMHNMI in IDPKMBFHBPC.members
				orderby MNIMEAMHNMI.score descending, MNIMEAMHNMI.enterDate
				select MNIMEAMHNMI).ToList();
			HAIOJAJHNBM(false, false);
		}
	}

	private void CMEDAHCGBAN(ClLeaderboard IDPKMBFHBPC, bool PKMLEMIJBKA)
	{
		if (IDPKMBFHBPC != null)
		{
			INFAGKCBEHL = IDPKMBFHBPC.groupId;
			GOEMHMEALGJ.JGMDDMNGDJO("ChampionsLeagueGroup", INFAGKCBEHL.ToString());
			NDABFDHPIBB = (from MNIMEAMHNMI in IDPKMBFHBPC.members
				orderby MNIMEAMHNMI.score descending, MNIMEAMHNMI.enterDate
				select MNIMEAMHNMI).ToList();
			HAIOJAJHNBM(true, PKMLEMIJBKA);
		}
	}

	private void HAIOJAJHNBM(bool BLLEBNGCJFE, bool PKMLEMIJBKA)
	{
		bool flag = false;
		int fLMKBEFILAB = 0;
		int num = 0;
		NACOGGLHJDE = 4;
		foreach (ClMember item in NDABFDHPIBB)
		{
			if (!flag)
			{
				num++;
			}
			if (item.id == HNDDIFIANKG)
			{
				fLMKBEFILAB = item.score - 1;
				flag = true;
			}
			if (item.segment < NACOGGLHJDE)
			{
				NACOGGLHJDE = item.segment;
			}
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ChampionsLeague, "Segment: {0}", NACOGGLHJDE);
		ALNHBLPIABB(num);
		HPJAADEKADL(BLLEBNGCJFE, PKMLEMIJBKA, fLMKBEFILAB);
	}

	private void HPJAADEKADL(bool BLLEBNGCJFE, bool PKMLEMIJBKA, int FLMKBEFILAB)
	{
		if (BLLEBNGCJFE && (PKMLEMIJBKA || OMAFAHLOEHF.PENJCGPCHHD < FLMKBEFILAB || ELBMHNOBHPN.DJGMHLLAGLE))
		{
			OMAFAHLOEHF.PENJCGPCHHD = FLMKBEFILAB;
			OMAFAHLOEHF.EMNDJNDGANP = 0;
			NEOKHIDFNCK.JGMDDMNGDJO("ChampionsLeagueLevelIndex", OMAFAHLOEHF.ToString(), 1);
		}
	}

	private void ALNHBLPIABB(int JEAAHAFHDEG)
	{
		if (OHAPPDGAKNG != JEAAHAFHDEG)
		{
			OHAPPDGAKNG = JEAAHAFHDEG;
			IJMGKCMGPNC.JGMDDMNGDJO("ChampionsLeagueRank", OHAPPDGAKNG);
			if (MapManager.Instance != null)
			{
				MapManager.Instance.UpdateChampionsLeagueRank(OHAPPDGAKNG);
			}
		}
	}

	public void OMOKOKFNBKI()
	{
		GOEMHMEALGJ.MFKBEDNLCJA("ChampionsLeagueId");
		GOEMHMEALGJ.MFKBEDNLCJA("ChampionsLeagueEndTime");
		GOEMHMEALGJ.MFKBEDNLCJA("ChampionsLeagueStatus");
		GOEMHMEALGJ.MFKBEDNLCJA("ChampionsLeagueGroup");
		GOEMHMEALGJ.MFKBEDNLCJA("ChampionsLeagueLevels");
		IJMGKCMGPNC.MFKBEDNLCJA("ChampionsLeagueRank");
		NEOKHIDFNCK.MFKBEDNLCJA("ChampionsLeagueLevelIndex");
		if (INFAGKCBEHL > 0 && OHAPPDGAKNG > 0)
		{
			GOEMHMEALGJ.JGMDDMNGDJO("ChampionsLeagueGroup" + HNDDIFIANKG, INFAGKCBEHL.ToString());
			GOEMHMEALGJ.JGMDDMNGDJO("ChampionsLeagueRank" + HNDDIFIANKG, OHAPPDGAKNG.ToString());
		}
		else
		{
			GOEMHMEALGJ.MFKBEDNLCJA("ChampionsLeagueRewards");
		}
		KNPOFJNFLJB = null;
	}

	public bool KDFCPCAHFPC()
	{
		return NEOKHIDFNCK.LDKAMIIEFMN("ChampionsLeagueLevelIndex");
	}

	public CLRewardsJson COGMBHJAPNO()
	{
		CLRewardsJson cLRewardsJson = null;
		try
		{
			string text = GOEMHMEALGJ.LIANKDMAHFM("ChampionsLeagueRewards");
			if (text == null)
			{
				return null;
			}
			switch (NACOGGLHJDE)
			{
			case 2:
				cLRewardsJson = JsonUtility.FromJson<CLSegmentsJson>(text).segment2;
				break;
			case 3:
				cLRewardsJson = JsonUtility.FromJson<CLSegmentsJson>(text).segment3;
				break;
			default:
				cLRewardsJson = JsonUtility.FromJson<CLSegmentsJson>(text).segment1;
				break;
			}
			if (cLRewardsJson == null || cLRewardsJson.rewards == null)
			{
				cLRewardsJson = JsonUtility.FromJson<CLRewardsJson>(text);
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.ChampionsLeague, "Error parsing Error:{0} Stack:{1}", ex.Message, ex.StackTrace);
		}
		return cLRewardsJson;
	}

	public void MNJCFNHNILM()
	{
		OMOKOKFNBKI();
	}

	public static bool APCILMENFLJ()
	{
		return MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() >= 2845;
	}

	public void BHABBFGFPFB()
	{
		OMAFAHLOEHF.EMNDJNDGANP = 0;
		NEOKHIDFNCK.JGMDDMNGDJO("ChampionsLeagueLevelIndex", OMAFAHLOEHF.ToString(), 1);
	}

	public bool OFGLLFMFMHB()
	{
		bool flag = OHAPPDGAKNG > 0 && INFAGKCBEHL > 0 && MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() >= 2850 && GOEMHMEALGJ.LIANKDMAHFM("ChampionsLeagueRewards") != null;
		if (!flag)
		{
			GOEMHMEALGJ.MFKBEDNLCJA("ChampionsLeagueRank" + HNDDIFIANKG);
			GOEMHMEALGJ.MFKBEDNLCJA("ChampionsLeagueGroup" + HNDDIFIANKG);
		}
		return flag;
	}

	public static string DALMNNKGINA(int GIOFHACJEGA)
	{
		return NKILHODNBDE.GHBGCADFLFB("Stage") + GIOFHACJEGA;
	}

	[CompilerGenerated]
	private void KIJAHIONIDC(bool EEKJMDHEJCK, ClStatusResponseMessage OMJOIIOONMO)
	{
		if (EEKJMDHEJCK)
		{
			if (OMJOIIOONMO.status == ClStatusType.CLOSED)
			{
				OMOKOKFNBKI();
			}
			else
			{
				MGDJKABHDGJ(OMJOIIOONMO);
			}
			if (MapManager.Instance != null)
			{
				MapManager.Instance.ShouldShowChampionsLeague();
			}
		}
	}

	[CompilerGenerated]
	private void DHIGMGFKEOJ(bool EEKJMDHEJCK, ClStatusResponseMessage OMJOIIOONMO)
	{
		MapManager instance = MapManager.Instance;
		if (!EEKJMDHEJCK)
		{
			if (instance != null)
			{
				instance.ShouldShowChampionsLeague();
			}
			return;
		}
		if (OMJOIIOONMO.status == ClStatusType.CLOSED)
		{
			OMOKOKFNBKI();
		}
		else
		{
			MGDJKABHDGJ(OMJOIIOONMO);
			NewMapAnimationController.AddToFocusAnimations("ChampionsLeagueAnimation");
		}
		if (instance != null)
		{
			instance.ShouldShowChampionsLeague();
		}
	}

	[CompilerGenerated]
	private static int IHMCNMDGDDC(ClMember MNIMEAMHNMI)
	{
		return MNIMEAMHNMI.score;
	}

	[CompilerGenerated]
	private static long AKOLOPOLECC(ClMember MNIMEAMHNMI)
	{
		return MNIMEAMHNMI.enterDate;
	}

	[CompilerGenerated]
	private static int IMFNIMCDPPB(ClMember MNIMEAMHNMI)
	{
		return MNIMEAMHNMI.score;
	}

	[CompilerGenerated]
	private static long OPONNAFGPPM(ClMember MNIMEAMHNMI)
	{
		return MNIMEAMHNMI.enterDate;
	}
}
