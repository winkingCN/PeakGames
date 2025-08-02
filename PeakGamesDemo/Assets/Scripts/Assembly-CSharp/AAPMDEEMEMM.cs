using System.Collections.Generic;
using System.Text;
using Assets.Scripts.MapScene;
using Assets.Scripts.Utils;
using DAO.Entity;
using MapScene;
using caravan.protobuf.messages;

public class AAPMDEEMEMM : IMPIFJOCKBI
{
	public const int FHIIFBJOKND = 22;

	public const int PMOKIJEHMKO = 1;

	public const int KNIEACNAAIB = 2;

	public const int ILLAJLGIAKG = 3;

	public const int LDFHGHGAHEI = 0;

	public const int ICLFEPFECFB = 1;

	public const int DILEIBLKOHA = 2;

	public const int AIKGJNEAPDM = 3;

	public const int PFBEAHLFLPA = 4;

	public const int CNBNEOHIKNE = 0;

	public const int EFHOPPKDDGI = 1;

	public const int KFAOCHCOOEN = 2;

	private const string HJEEKHLCBNH = "TeamChestDisplayStatus";

	private const string PMKFKAIAHKD = "TeamChestInfo";

	private long HNPLOINNECM;

	private long HBKJONGMEGD;

	private string HDONMHLNCNK;

	private bool PAPKJICKCKF;

	private int LHGOHOBNBDG = -1;

	private HJBLKNBHMFJ GOEMHMEALGJ;

	private MGNLLDDOHKN NEOKHIDFNCK;

	private IONAGMPHNPM HDHCIJGMBIL;

	public int FLFDJCHPGAJ { get; private set; }

	public long IGFDHCGLKBN { get; private set; }

	public string GCELBDIDEAI { get; private set; }

	public int KKGHMHHILNF { get; private set; }

	public bool ICNIGMDCCLN { get; private set; }

	public JJHJHJFNCGC OPBAEEEGPDE
	{
		get
		{
			return HDHCIJGMBIL.LJBNEEGOBMD(GODKDOHOHCD);
		}
	}

	public List<JJHJHJFNCGC> IPHCMAJGCIG
	{
		get
		{
			return HDHCIJGMBIL.MEGIIEPGOCC(GODKDOHOHCD);
		}
	}

	protected override int ENBPGGCIADN
	{
		get
		{
			return 3;
		}
	}

	public override long AEBACBBGHKI
	{
		get
		{
			long num = HNPLOINNECM - FIBJIOBINHL.CFBJBKEPGAN();
			return (num <= 0) ? 0 : num;
		}
	}

	public long PGMKKMIEBGB
	{
		get
		{
			long num = HBKJONGMEGD - FIBJIOBINHL.CFBJBKEPGAN();
			return (num <= 0) ? 0 : num;
		}
	}

	public bool EBEALFFCHFB
	{
		get
		{
			return LHGOHOBNBDG == FocusListener.MOGJKPIEGGL;
		}
	}

	public override void DDIBMLBPIEH(EventEntity MBIKENNNMKO)
	{
		int? num = MBIKENNNMKO.AIAEHPLOFGB();
		if (GOEMHMEALGJ == null)
		{
			GOEMHMEALGJ = HJBLKNBHMFJ.GABGKBAKHDP;
		}
		if (HDHCIJGMBIL == null)
		{
			HDHCIJGMBIL = IONAGMPHNPM.GABGKBAKHDP;
		}
		if (NEOKHIDFNCK == null)
		{
			NEOKHIDFNCK = MGNLLDDOHKN.GABGKBAKHDP;
		}
		if (GODKDOHOHCD != 0 && (GODKDOHOHCD != num.GetValueOrDefault() || !num.HasValue))
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TeamChestEventManager will remove old ({0}) event.", GODKDOHOHCD);
			IMPIFJOCKBI.PJHDJKAJAPM.GCLOHJDBLOD(GODKDOHOHCD);
			OMOKOKFNBKI();
		}
		GODKDOHOHCD = (num.HasValue ? num.Value : 0);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TeamChestEventManager processed event for id={0}", GODKDOHOHCD);
		HNPLOINNECM = MBIKENNNMKO.EndTime;
		HDONMHLNCNK = "TeamChestDisplayStatus" + LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
		HNNAFCHDIFN();
		MHOCOAPEMJH();
	}

	public override void OMOKOKFNBKI()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TeamChestEventManager is reset.");
		GOEMHMEALGJ.KFCIOFNMKDA(HDONMHLNCNK);
		GOEMHMEALGJ.KFCIOFNMKDA("TeamChestInfo");
		NEOKHIDFNCK.MFKBEDNLCJA("TeamChestInfo");
		HDHCIJGMBIL.BBGLCADIONK();
		PAPKJICKCKF = false;
	}

	public override void MBHNMKFPGBH()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TeamChestEventManager is reset after logout.");
		GOEMHMEALGJ.KFCIOFNMKDA("TeamChestInfo");
		NEOKHIDFNCK.MFKBEDNLCJA("TeamChestInfo");
		HDHCIJGMBIL.BBGLCADIONK();
	}

	public override bool DBJECBOBGMI()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TeamChestEventManager try reset.");
		if (GFHPEDILAJG.GABGKBAKHDP.ODMCGBLJFKM && (EBEALFFCHFB || HBKJONGMEGD == HNPLOINNECM || HBKJONGMEGD > FIBJIOBINHL.CFBJBKEPGAN()))
		{
			if (KKGHMHHILNF != 2)
			{
				DOGOCBAPBAD(3);
			}
			return false;
		}
		OMOKOKFNBKI();
		return true;
	}

	public void NMBAAHJEPGB(TcStatusResponseMessage OMJOIIOONMO)
	{
		int num = OMJOIIOONMO.status;
		if (num == 4)
		{
			num = ((OMJOIIOONMO.progress < OMJOIIOONMO.target) ? 1 : 3);
		}
		FLFDJCHPGAJ = OMJOIIOONMO.target;
		IGFDHCGLKBN = OMJOIIOONMO.teamInfo.manager;
		GCELBDIDEAI = OMJOIIOONMO.teamInfo.badge;
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(FLFDJCHPGAJ).Append(':').Append(IGFDHCGLKBN)
			.Append(':')
			.Append(GCELBDIDEAI);
		GOEMHMEALGJ.JGMDDMNGDJO("TeamChestInfo", stringBuilder.ToString());
		HDHCIJGMBIL.NHIJCBKNMKG(OMJOIIOONMO);
		if (num != KKGHMHHILNF)
		{
			DOGOCBAPBAD(num);
		}
	}

	public void MMHLOMIACEK()
	{
		HDHCIJGMBIL.DAKGKAMIOCA();
	}

	public void JDHNHIKEOMA()
	{
		LHGOHOBNBDG = -1;
	}

	public void NKEOIKOJMMD(int HCCBDFMKLHN)
	{
		LHGOHOBNBDG = -1;
		LECPGNKOABP lECPGNKOABP = LECPGNKOABP.GABGKBAKHDP;
		if (KKGHMHHILNF == 1 && GFHPEDILAJG.GABGKBAKHDP.ODMCGBLJFKM)
		{
			HDHCIJGMBIL.FKOCNEMAAAP(lECPGNKOABP.GDMECFECCOM, GODKDOHOHCD, HCCBDFMKLHN);
		}
	}

	public void LCBIJOLOHKM(bool PIOPLEGPOJO)
	{
		if (HNPLOINNECM < FIBJIOBINHL.CFBJBKEPGAN())
		{
			DGOMNDMPMBG.GABGKBAKHDP.PMBHGGMJJJE(3, GODKDOHOHCD);
			IMPIFJOCKBI.PJHDJKAJAPM.GCLOHJDBLOD(GODKDOHOHCD);
			BKDMLALPOEN();
		}
		else
		{
			HDHCIJGMBIL.BBGLCADIONK();
			DOGOCBAPBAD((!PIOPLEGPOJO) ? 1 : KKGHMHHILNF);
		}
	}

	public void MHBOHLJEBOE()
	{
		IONAGMPHNPM.GABGKBAKHDP.MHBOHLJEBOE(LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM, LECPGNKOABP.GABGKBAKHDP.KJACEODCOHN);
	}

	public void LCEPBBLJGCG(Dictionary<NAAHKHPBAPA, int> GKNKMDIPAIK)
	{
		LECPGNKOABP lECPGNKOABP = LECPGNKOABP.GABGKBAKHDP;
		HDHCIJGMBIL.GFEMAOFEIEH(lECPGNKOABP.GDMECFECCOM, 1);
		HPHEOJFHKBG(GKNKMDIPAIK);
		long eMNOJOHFMEH = lECPGNKOABP.OADDPGNIINO;
		NEOKHIDFNCK.JGMDDMNGDJO("TeamChestInfo", eMNOJOHFMEH.ToString() + ':' + GODKDOHOHCD);
		OneSignal.SendTag("TcClaimedTag", GODKDOHOHCD.ToString());
		List<IKDMCJPBBIH> list = new List<IKDMCJPBBIH>();
		list.Add(new NCHDJAAJNIG());
		list.Add(new GFOFLPPPDOF(eMNOJOHFMEH, GODKDOHOHCD));
		List<IKDMCJPBBIH> hDECNOABBDG = list;
		KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(hDECNOABBDG);
	}

	public static void GHPPDPBLAOL(out long EMNOJOHFMEH, out int GCKOBKBPOBE)
	{
		string text = MGNLLDDOHKN.GABGKBAKHDP.LIANKDMAHFM("TeamChestInfo") ?? string.Empty;
		string[] array = text.Split(':');
		switch (array.Length)
		{
		case 1:
			long.TryParse(array[0], out EMNOJOHFMEH);
			GCKOBKBPOBE = 0;
			break;
		case 2:
			long.TryParse(array[0], out EMNOJOHFMEH);
			int.TryParse(array[1], out GCKOBKBPOBE);
			break;
		default:
			EMNOJOHFMEH = 0L;
			GCKOBKBPOBE = 0;
			break;
		}
	}

	public static void LLOONDAAAEK()
	{
		MGNLLDDOHKN.GABGKBAKHDP.MFKBEDNLCJA("TeamChestInfo");
	}

	public void LGDBADICPEN()
	{
		ICNIGMDCCLN = false;
	}

	private void DOGOCBAPBAD(int BGEDKGLJIGM, Dictionary<NAAHKHPBAPA, int> GKNKMDIPAIK = null)
	{
		int num = KKGHMHHILNF;
		KKGHMHHILNF = BGEDKGLJIGM;
		switch (KKGHMHHILNF)
		{
		case 1:
			HBKJONGMEGD = HNPLOINNECM;
			break;
		case 2:
			HBKJONGMEGD = HNPLOINNECM + 259200;
			break;
		case 3:
			JIGNMFEAEAB(GKNKMDIPAIK);
			if (!LECPGNKOABP.GABGKBAKHDP.LJEIKNAKAJD)
			{
				HBKJONGMEGD = HNPLOINNECM;
			}
			else if (HBKJONGMEGD == HNPLOINNECM)
			{
				HBKJONGMEGD = FIBJIOBINHL.CFBJBKEPGAN() + 3600;
			}
			break;
		}
		BHPOJAJJADP();
		if (num != KKGHMHHILNF)
		{
			BKDMLALPOEN();
		}
	}

	private void BHPOJAJJADP()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(GODKDOHOHCD).Append(':').Append(KKGHMHHILNF)
			.Append(':')
			.Append(HBKJONGMEGD);
		string text = stringBuilder.ToString();
		GOEMHMEALGJ.JGMDDMNGDJO(HDONMHLNCNK, text);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TeamChestEventManager is persist as {0} for key {1}.", text, HDONMHLNCNK);
	}

	private void HNNAFCHDIFN()
	{
		ICNIGMDCCLN = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() < 22;
		string text = GOEMHMEALGJ.LIANKDMAHFM(HDONMHLNCNK);
		if (text == null)
		{
			ICNIGMDCCLN = true;
			DOGOCBAPBAD(1);
			return;
		}
		string[] array = text.Split(':');
		if (array.Length != 3)
		{
			DOGOCBAPBAD(1);
			return;
		}
		int result;
		int.TryParse(array[0], out result);
		if (GODKDOHOHCD != result)
		{
			ICNIGMDCCLN = true;
			DOGOCBAPBAD(1);
			return;
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TeamChestEventManager is parsed as {0}", text);
		int result2;
		int.TryParse(array[1], out result2);
		KKGHMHHILNF = result2;
		long.TryParse(array[2], out HBKJONGMEGD);
		DOGOCBAPBAD(KKGHMHHILNF);
	}

	public static void BKDMLALPOEN()
	{
		MapManager instance = MapManager.Instance;
		if (!(instance == null))
		{
			TeamChestDisplay teamChestDisplay = instance.NewMapContent.TeamChestDisplay;
			if (!(teamChestDisplay == null))
			{
				teamChestDisplay.Prepare();
			}
		}
	}

	public void HPHEOJFHKBG(Dictionary<NAAHKHPBAPA, int> GKNKMDIPAIK = null)
	{
		LHGOHOBNBDG = FocusListener.MOGJKPIEGGL;
		HBKJONGMEGD = FIBJIOBINHL.CFBJBKEPGAN() + 1;
		DOGOCBAPBAD(3, GKNKMDIPAIK);
	}

	private void MHOCOAPEMJH()
	{
		FLFDJCHPGAJ = 0;
		IGFDHCGLKBN = 0L;
		GCELBDIDEAI = null;
		string text = GOEMHMEALGJ.LIANKDMAHFM("TeamChestInfo");
		if (text != null)
		{
			string[] array = text.Split(':');
			if (array.Length == 3)
			{
				FLFDJCHPGAJ = int.Parse(array[0]);
				IGFDHCGLKBN = long.Parse(array[1]);
				GCELBDIDEAI = array[2];
			}
		}
	}

	private void JIGNMFEAEAB(Dictionary<NAAHKHPBAPA, int> GKNKMDIPAIK)
	{
		if (PAPKJICKCKF)
		{
			return;
		}
		int num = MKINMKEMBPL.GABGKBAKHDP.CNDHGKBCFAB("TeamChestInfo");
		PAPKJICKCKF = num == GODKDOHOHCD;
		if (!PAPKJICKCKF)
		{
			int num2 = 0;
			int num3 = 0;
			JJHJHJFNCGC jJHJHJFNCGC = OPBAEEEGPDE;
			if (jJHJHJFNCGC != null)
			{
				num2 = jJHJHJFNCGC.INOKNDGFNLK;
				num3 = FLFDJCHPGAJ;
			}
			if (GKNKMDIPAIK != null || num2 < num3)
			{
				AFJPGLHKOID.AGEANPJMOHG(LECPGNKOABP.GABGKBAKHDP.OADDPGNIINO, GODKDOHOHCD, num2, num3, GKNKMDIPAIK);
				PAPKJICKCKF = true;
				MKINMKEMBPL.GABGKBAKHDP.HOKOPPLGJIK("TeamChestInfo", GODKDOHOHCD);
			}
		}
	}
}
