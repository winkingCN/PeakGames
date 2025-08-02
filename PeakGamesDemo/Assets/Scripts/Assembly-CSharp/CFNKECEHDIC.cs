using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Assets.Scripts.MapScene;
using Assets.Scripts.Utils;
using DAO.Entity;
using EventsManagers;
using MapScene;
using UnityEngine;

public class CFNKECEHDIC : IMPIFJOCKBI
{
	public const int FHIIFBJOKND = 27;

	private const int IKPLBMFCFLD = 20;

	public const int EBNAFCAEDOK = 1;

	public const int NLHOCFJIKBG = 2;

	private const int IALIJIALICD = 98;

	private const int CFGKEBEOPEH = 99;

	private const string MBGDENHAGJG = "TreasureHunt";

	private int LHGOHOBNBDG = -1;

	private const int CLINMIOGLJK = 7200;

	private OIOJFMEHGBF ODIIMFEIGPP;

	private MKINMKEMBPL CMMGCFKOEBF;

	private EventEntity PFNLGKJEGNP;

	private long HBKJONGMEGD;

	private int AHEFJDMEKOI;

	[CompilerGenerated]
	private static Func<string, EventEntity, string> EBCOMJBLIPP;

	[CompilerGenerated]
	private static Comparison<ThSegment> DNBOPLHGMHA;

	public int HMHBNDGADKG { get; private set; }

	public bool BPDNGDOGLIO { get; private set; }

	public bool FBKLBPKOOPG { get; private set; }

	public bool HAPNFEFLGBK
	{
		get
		{
			return GFKLBMGGJMK >= 98;
		}
	}

	public bool NPHPMJFFPGB
	{
		get
		{
			int num = GFKLBMGGJMK;
			switch (num)
			{
			case 99:
				return false;
			case 98:
				return EBEALFFCHFB;
			default:
				if (num >= HMHBNDGADKG)
				{
					BINBJOFJAAP(259200);
					return PGMKKMIEBGB > 0;
				}
				if (num >= 0 && AEBACBBGHKI <= 0)
				{
					BINBJOFJAAP(3600);
					return PGMKKMIEBGB > 0;
				}
				if (num >= 0 && AEBACBBGHKI > 0)
				{
					return true;
				}
				return AEBACBBGHKI > 7200;
			}
		}
	}

	public int AEPLIGFCGIF
	{
		get
		{
			int num = GFKLBMGGJMK;
			if (num >= HMHBNDGADKG && num < 98 && !FBKLBPKOOPG)
			{
				return 2;
			}
			return 1;
		}
	}

	public int GFKLBMGGJMK
	{
		get
		{
			return NPDCFNCGHKA(ODIIMFEIGPP.AOFOEFNCFIB(NAAHKHPBAPA.Key));
		}
	}

	protected override int ENBPGGCIADN
	{
		get
		{
			return 7;
		}
	}

	public override long AEBACBBGHKI
	{
		get
		{
			long num = PFNLGKJEGNP.EndTime - FIBJIOBINHL.CFBJBKEPGAN();
			return (num <= 0) ? 0 : num;
		}
	}

	private long PGMKKMIEBGB
	{
		get
		{
			long num = HBKJONGMEGD - FIBJIOBINHL.CFBJBKEPGAN();
			return (num <= 0) ? 0 : num;
		}
	}

	private bool EBEALFFCHFB
	{
		get
		{
			return LHGOHOBNBDG == FocusListener.MOGJKPIEGGL;
		}
	}

	private int LNFJNIKPPLE
	{
		get
		{
			return GODKDOHOHCD % 321;
		}
	}

	public override void DDIBMLBPIEH(EventEntity MBIKENNNMKO)
	{
		if (ODIIMFEIGPP == null)
		{
			ODIIMFEIGPP = OIOJFMEHGBF.GABGKBAKHDP;
		}
		if (CMMGCFKOEBF == null)
		{
			CMMGCFKOEBF = MKINMKEMBPL.GABGKBAKHDP;
		}
		int? num = MBIKENNNMKO.AIAEHPLOFGB();
		if (GODKDOHOHCD != 0 && (GODKDOHOHCD != num.GetValueOrDefault() || !num.HasValue))
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TreasureHunt will remove old ({0}-{1}) event.", GODKDOHOHCD, LNFJNIKPPLE);
			IMPIFJOCKBI.PJHDJKAJAPM.GCLOHJDBLOD(base.IFOAAOCJODG);
			OMOKOKFNBKI();
		}
		GODKDOHOHCD = (num.HasValue ? num.Value : 0);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TreasureHunt processed event for id={0}-{1}", GODKDOHOHCD, LNFJNIKPPLE);
		PFNLGKJEGNP = MBIKENNNMKO;
		EJKMIHIEJMB();
	}

	public override bool DBJECBOBGMI()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TreasureHunt try reset.");
		if (AEBACBBGHKI <= 10)
		{
			BINBJOFJAAP(3600);
		}
		if (PGMKKMIEBGB > 0 || EBEALFFCHFB)
		{
			return false;
		}
		OMOKOKFNBKI();
		return true;
	}

	public override void OMOKOKFNBKI()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TreasureHunt is reset.");
		HJBLKNBHMFJ.GABGKBAKHDP.KFCIOFNMKDA("TreasureHunt");
		CMMGCFKOEBF.CJOHLENDJGO("TreasureHunt");
	}

	public override void MBHNMKFPGBH()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TreasureHunt is reset after logout removes once data automatically.");
	}

	public static void JGOAFANIDME()
	{
		HJBLKNBHMFJ hJBLKNBHMFJ = HJBLKNBHMFJ.GABGKBAKHDP;
		hJBLKNBHMFJ.KFCIOFNMKDA("TreasureHunt");
		List<EventEntity> list = IMPIFJOCKBI.PJHDJKAJAPM.CKCAEMDMLFC(7);
		if (list != null && list.Count != 0)
		{
			string text = list.Aggregate(string.Empty, (string CEPDJPNELND, EventEntity LLIEHCKNJEM) => CEPDJPNELND + LLIEHCKNJEM.Id);
			if (!string.IsNullOrEmpty(text))
			{
				hJBLKNBHMFJ.JGMDDMNGDJO("TreasureHunt", text);
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TreasureHunt older version eventIds: {0}", text);
			}
		}
	}

	private void DFGLAEELFHE()
	{
		LHGOHOBNBDG = FocusListener.MOGJKPIEGGL;
		BINBJOFJAAP(1, true);
	}

	private void BINBJOFJAAP(int JAEMCJCFBJK, bool KOOGKIIIKAJ = false)
	{
		if (HBKJONGMEGD == 0 || KOOGKIIIKAJ)
		{
			HBKJONGMEGD = FIBJIOBINHL.CFBJBKEPGAN() + JAEMCJCFBJK;
			CMMGCFKOEBF.HOKOPPLGJIK("TreasureHunt", (int)HBKJONGMEGD);
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TreasureHunt duration is extended to {0}", HBKJONGMEGD);
			if (JAEMCJCFBJK == 3600)
			{
				JIGNMFEAEAB(ODIIMFEIGPP.AOFOEFNCFIB(NAAHKHPBAPA.Key), null);
			}
		}
	}

	private void EJKMIHIEJMB()
	{
		NDDNNJHMMDC nDDNNJHMMDC = ODIIMFEIGPP.AOFOEFNCFIB(NAAHKHPBAPA.Key);
		int num = JDMINHGNBCD(nDDNNJHMMDC);
		if (LNFJNIKPPLE != num && AEBACBBGHKI > 7200)
		{
			BPDNGDOGLIO = true;
			GHMHFJEAHOK(nDDNNJHMMDC, 0);
		}
		HMHBNDGADKG = MJNKMPLOPJC(NPDCFNCGHKA(nDDNNJHMMDC));
		HBKJONGMEGD = CMMGCFKOEBF.CNDHGKBCFAB("TreasureHunt");
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TreasureHunt is parsed as {0}:{1}:{2}", nDDNNJHMMDC.DIJPJDFKNCJ, HBKJONGMEGD, HMHBNDGADKG);
		PMHFHCBEENO();
	}

	private int MJNKMPLOPJC(int HKCHADGGNOD)
	{
		int result = 20;
		string text = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("TreasureHunt");
		if (!string.IsNullOrEmpty(text) && text.Contains(GODKDOHOHCD.ToString()))
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TreasureHunt event was in an older version.");
			return result;
		}
		try
		{
			int num = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() - HKCHADGGNOD;
			ThSegments thSegments = JsonUtility.FromJson<ThSegments>(PFNLGKJEGNP.Data);
			IDFPAFEJPPH iDFPAFEJPPH = IDFPAFEJPPH.GABGKBAKHDP;
			if (iDFPAFEJPPH.HGNJBHGBLIN)
			{
				int num2 = iDFPAFEJPPH.PDGLECFDLJJ - 1 - HKCHADGGNOD;
				if (num2 >= 0 && thSegments.cl > 0)
				{
					return thSegments.cl;
				}
				num = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + num2;
			}
			int num3 = 0;
			List<ThSegment> segments = thSegments.segments;
			segments.Sort((ThSegment MNIMEAMHNMI, ThSegment BCIHLCMFAEK) => (MNIMEAMHNMI.level > BCIHLCMFAEK.level) ? 1 : ((MNIMEAMHNMI.level < BCIHLCMFAEK.level) ? (-1) : 0));
			foreach (ThSegment item in segments)
			{
				if (num >= item.level)
				{
					num3 = item.target;
				}
			}
			if (num3 > 0)
			{
				result = num3;
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TreasureHunt exception on max key count parse: {0}", ex.Message);
		}
		return result;
	}

	private int NPDCFNCGHKA(NDDNNJHMMDC EJCNAJOHBFI)
	{
		int GCKOBKBPOBE;
		int AEOLICFHBFL;
		FHGONHEPNID(EJCNAJOHBFI, out GCKOBKBPOBE, out AEOLICFHBFL);
		return AEOLICFHBFL;
	}

	private int JDMINHGNBCD(NDDNNJHMMDC EJCNAJOHBFI)
	{
		int GCKOBKBPOBE;
		int AEOLICFHBFL;
		FHGONHEPNID(EJCNAJOHBFI, out GCKOBKBPOBE, out AEOLICFHBFL);
		return GCKOBKBPOBE;
	}

	private void FHGONHEPNID(NDDNNJHMMDC EJCNAJOHBFI, out int GCKOBKBPOBE, out int AEOLICFHBFL)
	{
		int dIJPJDFKNCJ = EJCNAJOHBFI.DIJPJDFKNCJ;
		GCKOBKBPOBE = (dIJPJDFKNCJ - (AEOLICFHBFL = dIJPJDFKNCJ % 100)) / 100;
		if (LNFJNIKPPLE != GCKOBKBPOBE)
		{
			AEOLICFHBFL = -1;
		}
	}

	private void GHMHFJEAHOK(NDDNNJHMMDC EJCNAJOHBFI, int AEOLICFHBFL)
	{
		EJCNAJOHBFI.DIJPJDFKNCJ = LNFJNIKPPLE * 100 + AEOLICFHBFL;
		EJCNAJOHBFI.FOJDLLGGJID = 1;
		ODIIMFEIGPP.BJNFGAFBCGJ(EJCNAJOHBFI);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TreasureHunt is persist as {0}:{1}", EJCNAJOHBFI.DIJPJDFKNCJ, HBKJONGMEGD);
	}

	public void JDHNHIKEOMA()
	{
		LHGOHOBNBDG = -1;
	}

	public void NKEOIKOJMMD()
	{
		LHGOHOBNBDG = -1;
		if (AEBACBBGHKI <= 0)
		{
			return;
		}
		NDDNNJHMMDC eJCNAJOHBFI = ODIIMFEIGPP.AOFOEFNCFIB(NAAHKHPBAPA.Key);
		int num = NPDCFNCGHKA(eJCNAJOHBFI);
		if (num >= HMHBNDGADKG)
		{
			return;
		}
		if (num == -1)
		{
			if (AEBACBBGHKI >= 7200)
			{
				FBKLBPKOOPG = true;
				BPDNGDOGLIO = true;
				GHMHFJEAHOK(eJCNAJOHBFI, 1);
			}
		}
		else
		{
			FBKLBPKOOPG = true;
			GHMHFJEAHOK(eJCNAJOHBFI, num + 1);
		}
	}

	public void LCEPBBLJGCG(Dictionary<NAAHKHPBAPA, int> GKNKMDIPAIK)
	{
		NDDNNJHMMDC eJCNAJOHBFI = ODIIMFEIGPP.AOFOEFNCFIB(NAAHKHPBAPA.Key);
		if (NPDCFNCGHKA(eJCNAJOHBFI) != 99)
		{
			JIGNMFEAEAB(eJCNAJOHBFI, GKNKMDIPAIK);
			GHMHFJEAHOK(eJCNAJOHBFI, 99);
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
			{
				new NCHDJAAJNIG()
			});
			PMHFHCBEENO();
		}
	}

	public int HPHEOJFHKBG()
	{
		NDDNNJHMMDC eJCNAJOHBFI = ODIIMFEIGPP.AOFOEFNCFIB(NAAHKHPBAPA.Key);
		int num = NPDCFNCGHKA(eJCNAJOHBFI);
		if (num == 98)
		{
			return AHEFJDMEKOI;
		}
		AHEFJDMEKOI = num;
		DFGLAEELFHE();
		GHMHFJEAHOK(eJCNAJOHBFI, 98);
		PMHFHCBEENO();
		return AHEFJDMEKOI;
	}

	public void BCBDPNPEKFI()
	{
		BPDNGDOGLIO = false;
	}

	public void ALIDHGIHPGF()
	{
		FBKLBPKOOPG = false;
	}

	public static void PMHFHCBEENO()
	{
		MapManager instance = MapManager.Instance;
		if (!(instance == null))
		{
			TreasureHuntDisplay treasureHuntDisplay = instance.NewMapContent.TreasureHuntDisplay;
			if (!(treasureHuntDisplay == null))
			{
				treasureHuntDisplay.Prepare();
			}
		}
	}

	private void JIGNMFEAEAB(NDDNNJHMMDC EJCNAJOHBFI, Dictionary<NAAHKHPBAPA, int> GKNKMDIPAIK)
	{
		int kHJFCFLFCCN = NPDCFNCGHKA(EJCNAJOHBFI);
		AFJPGLHKOID.BKFLNLDNEPM(GODKDOHOHCD, kHJFCFLFCCN, HMHBNDGADKG, GKNKMDIPAIK);
	}

	[CompilerGenerated]
	private static string MEAAGBLCBFB(string CEPDJPNELND, EventEntity LLIEHCKNJEM)
	{
		return CEPDJPNELND + LLIEHCKNJEM.Id;
	}

	[CompilerGenerated]
	private static int PGJAPEMEDKD(ThSegment MNIMEAMHNMI, ThSegment BCIHLCMFAEK)
	{
		return (MNIMEAMHNMI.level > BCIHLCMFAEK.level) ? 1 : ((MNIMEAMHNMI.level < BCIHLCMFAEK.level) ? (-1) : 0);
	}
}
