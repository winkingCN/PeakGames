using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Assets.Scripts.MapScene;
using DAO.Entity;
using EventsManagers;
using MapScene;
using UnityEngine;
using caravan.protobuf.messages;

public class KCKDNJOMPJH : IMPIFJOCKBI
{
	[CompilerGenerated]
	private sealed class PECNEHADBCJ
	{
		internal Action<bool> MGENCOJOJKN;

		internal KCKDNJOMPJH PDAPIGLEPGC;

		internal void AGFNGEFDHLA(bool EEKJMDHEJCK)
		{
			MGENCOJOJKN(EEKJMDHEJCK);
			if (EEKJMDHEJCK)
			{
				PDAPIGLEPGC.BLEMAIJFELL();
			}
		}
	}

	public const int FHIIFBJOKND = 21;

	private const string EDHHDJAFDCG = "TeamTournament";

	private const string CFFLIENJFCC = "TempTeamTournament";

	private const int CLINMIOGLJK = 90000;

	public const int NJGLHDHBIPC = 0;

	public const int EBNAFCAEDOK = 1;

	public const int MNBMMMHFIEF = 2;

	public const int BPGLBMIFDOL = 3;

	public const int PLEDKAPEIIK = 4;

	private string HDONMHLNCNK;

	private HJBLKNBHMFJ GOEMHMEALGJ;

	private int JAIPNDBEKEL;

	private long AJPNGAEMOMC;

	private int LBKPPKEADMM;

	private long EGFIOMFPGCD;

	private EventEntity PFNLGKJEGNP;

	private bool CLPANKDCBCA;

	private bool LIGHDLBBPLK;

	private long IMFIDEGJPDD;

	public int AEPLIGFCGIF
	{
		get
		{
			return JAIPNDBEKEL;
		}
	}

	public long INFAGKCBEHL
	{
		get
		{
			return AJPNGAEMOMC;
		}
	}

	public long EEJGJPLADGB
	{
		get
		{
			return EGFIOMFPGCD;
		}
	}

	public bool NPHGOHLHFKD
	{
		get
		{
			return LBKPPKEADMM == 1;
		}
	}

	public bool ADNCLLLLMEO { get; private set; }

	public int MIIHHONLDOI { get; private set; }

	public List<TtTeamInfo> NDABFDHPIBB { get; private set; }

	public List<TtMemberInfo> ABBDIDFPMON { get; private set; }

	protected override int ENBPGGCIADN
	{
		get
		{
			return 6;
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

	public bool GFEHMHDJKIF
	{
		get
		{
			long num = FIBJIOBINHL.CFBJBKEPGAN() - IMFIDEGJPDD;
			bool flag = IMFIDEGJPDD == 0 || num > 10;
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, (!flag) ? "TeamTournament data is up to date." : "TeamTournament data needs to be updated from backend.");
			return flag;
		}
	}

	private bool AEADPJMOIJI
	{
		get
		{
			return (JAIPNDBEKEL == 2 || JAIPNDBEKEL == 3) && EGFIOMFPGCD == 0;
		}
	}

	private bool GJFEGJNHHNH
	{
		get
		{
			long num = FIBJIOBINHL.CFBJBKEPGAN();
			return EGFIOMFPGCD > num && EGFIOMFPGCD - num <= 3600;
		}
	}

	private bool FALDOPBAGMP
	{
		get
		{
			return LBKPPKEADMM == 1 && (JAIPNDBEKEL < 2 || !GFHPEDILAJG.GABGKBAKHDP.ODMCGBLJFKM);
		}
	}

	public bool NPHPMJFFPGB
	{
		get
		{
			return MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() >= 21 && !FALDOPBAGMP && ((JAIPNDBEKEL <= 1 && AEBACBBGHKI > 90000) || AEADPJMOIJI || GJFEGJNHHNH);
		}
	}

	public bool LJGNJNOIAPH
	{
		get
		{
			return NPHPMJFFPGB && LIGHDLBBPLK;
		}
	}

	public bool BPDNGDOGLIO
	{
		get
		{
			return NPHPMJFFPGB && CLPANKDCBCA;
		}
	}

	public bool LMIPACNFAAB
	{
		get
		{
			return NPHPMJFFPGB && JAIPNDBEKEL == 3 && EGFIOMFPGCD == 0;
		}
	}

	public TtConfigJson GIEDINFFPNJ
	{
		get
		{
			try
			{
				return JsonUtility.FromJson<TtConfigJson>(PFNLGKJEGNP.Data);
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Events, "Error parsing TeamTournament Rewards Error:{0} Stack:{1}", ex.Message, ex.StackTrace);
			}
			return null;
		}
	}

	public bool GPOIALPCEJK()
	{
		if (AEBACBBGHKI > 0)
		{
			return false;
		}
		DGOMNDMPMBG.GABGKBAKHDP.PMBHGGMJJJE(6, base.IFOAAOCJODG);
		DGOMNDMPMBG.GABGKBAKHDP.MONGKICFIMO(6);
		return true;
	}

	public override void DDIBMLBPIEH(EventEntity MBIKENNNMKO)
	{
		if (GOEMHMEALGJ == null)
		{
			GOEMHMEALGJ = HJBLKNBHMFJ.GABGKBAKHDP;
		}
		int? num = MBIKENNNMKO.AIAEHPLOFGB();
		if (GODKDOHOHCD != 0 && (GODKDOHOHCD != num.GetValueOrDefault() || !num.HasValue))
		{
			if (AEADPJMOIJI)
			{
				return;
			}
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TeamTournament will remove old ({0}) event.", GODKDOHOHCD);
			IMPIFJOCKBI.PJHDJKAJAPM.GCLOHJDBLOD(base.IFOAAOCJODG);
			OMOKOKFNBKI();
		}
		GODKDOHOHCD = (num.HasValue ? num.Value : 0);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TeamTournament processed event for id={0}", GODKDOHOHCD);
		PFNLGKJEGNP = MBIKENNNMKO;
		HDONMHLNCNK = HOHMEMIEPGB();
		EJKMIHIEJMB();
	}

	public override bool DBJECBOBGMI()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TeamTournament try reset.");
		if (NPHPMJFFPGB)
		{
			return false;
		}
		OMOKOKFNBKI();
		return true;
	}

	public override void OMOKOKFNBKI()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TeamTournament is reset.");
		GOEMHMEALGJ.KFCIOFNMKDA(HDONMHLNCNK);
	}

	public override void MBHNMKFPGBH()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TeamTournament is reset after logout.");
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TeamTournament existing event will be stored as temp.");
		try
		{
			HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("TempTeamTournament" + HDONMHLNCNK, JsonUtility.ToJson(PFNLGKJEGNP));
		}
		catch (Exception)
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Events, "TeamTournament exception on storing temp event.");
		}
	}

	public static void CDGGACPJAPD()
	{
		try
		{
			string text = "TempTeamTournament" + HOHMEMIEPGB();
			string text2 = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM(text);
			if (text2 != null)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TeamTournament temp event will be stored into actual events table.");
				EventEntity eventEntity = JsonUtility.FromJson<EventEntity>(text2);
				eventEntity.PNLKNJNILDD(eventEntity.Id);
				IMPIFJOCKBI.PJHDJKAJAPM.PBPMICFEKFG(eventEntity);
				DGOMNDMPMBG.GABGKBAKHDP.MONGKICFIMO(6);
				HJBLKNBHMFJ.GABGKBAKHDP.MFKBEDNLCJA(text);
			}
		}
		catch (Exception)
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Events, "TeamTournament exception on restoring temp events.");
		}
	}

	private static string HOHMEMIEPGB()
	{
		return "TeamTournament" + LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
	}

	private void EJKMIHIEJMB()
	{
		ADNCLLLLMEO = false;
		LIGHDLBBPLK = false;
		string text = GOEMHMEALGJ.LIANKDMAHFM(HDONMHLNCNK);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TeamTournament is parsed as {0}", text);
		if (text == null)
		{
			LIGHDLBBPLK = true;
			JKIGJBJFKPH();
			return;
		}
		string[] array = text.Split(':');
		if (array.Length != 5)
		{
			JKIGJBJFKPH();
			return;
		}
		int result = 0;
		int.TryParse(array[0], out result);
		int.TryParse(array[1], out JAIPNDBEKEL);
		long.TryParse(array[2], out AJPNGAEMOMC);
		long.TryParse(array[3], out EGFIOMFPGCD);
		int.TryParse(array[4], out LBKPPKEADMM);
		if (GODKDOHOHCD != result && (JAIPNDBEKEL < 2 || EGFIOMFPGCD > 0))
		{
			LIGHDLBBPLK = true;
			JKIGJBJFKPH();
		}
	}

	private void JKIGJBJFKPH(int CBLPOFNKIPO = 0)
	{
		JAIPNDBEKEL = 0;
		AJPNGAEMOMC = 0L;
		EGFIOMFPGCD = 0L;
		LBKPPKEADMM = CBLPOFNKIPO;
		GHMHFJEAHOK();
	}

	private void GHMHFJEAHOK()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(GODKDOHOHCD).Append(':').Append(AEPLIGFCGIF)
			.Append(':')
			.Append(INFAGKCBEHL)
			.Append(':')
			.Append(EGFIOMFPGCD)
			.Append(':')
			.Append(LBKPPKEADMM);
		string text = stringBuilder.ToString();
		GOEMHMEALGJ.JGMDDMNGDJO(HDONMHLNCNK, text);
		PMHFHCBEENO();
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TeamTournament state is persist as {0} for key {1}.", text, HDONMHLNCNK);
	}

	public void ADIMEEPIFBL(TtStatusResponseMessage OMJOIIOONMO)
	{
		ADNCLLLLMEO = false;
		CLPANKDCBCA = false;
		IMFIDEGJPDD = FIBJIOBINHL.CFBJBKEPGAN();
		if (AJPNGAEMOMC != 0 && AJPNGAEMOMC != OMJOIIOONMO.groupId)
		{
			JAIPNDBEKEL = 0;
		}
		AJPNGAEMOMC = OMJOIIOONMO.groupId;
		if (JAIPNDBEKEL <= 1 && (OMJOIIOONMO.status == 2 || (OMJOIIOONMO.status == 3 && OMJOIIOONMO.claimed == 0)))
		{
			LIGHDLBBPLK = false;
			CLPANKDCBCA = true;
		}
		JAIPNDBEKEL = OMJOIIOONMO.status;
		LBKPPKEADMM = OMJOIIOONMO.disabled;
		if (LBKPPKEADMM == 1)
		{
			LIGHDLBBPLK = false;
			CLPANKDCBCA = false;
			if (JAIPNDBEKEL == 3 && EGFIOMFPGCD == 0)
			{
				AJEOHODMOHH();
			}
		}
		if (JAIPNDBEKEL < 2)
		{
			if (!GPOIALPCEJK())
			{
				GHMHFJEAHOK();
			}
			return;
		}
		NDABFDHPIBB = OMJOIIOONMO.teams;
		ABBDIDFPMON = OMJOIIOONMO.members;
		MIIHHONLDOI = OMJOIIOONMO.count;
		if (OMJOIIOONMO.teamId == 0 || NDABFDHPIBB.Count == 0 || ABBDIDFPMON.Count == 0)
		{
			CLPANKDCBCA = false;
		}
		if (OMJOIIOONMO.claimed == 0 && LBKPPKEADMM == 0)
		{
			KGBFKPJKOOD();
		}
		else if (OMJOIIOONMO.claimed == 1 && EGFIOMFPGCD == 0)
		{
			AJEOHODMOHH();
		}
		if (OMJOIIOONMO.teamId == 0)
		{
			LECPGNKOABP.GABGKBAKHDP.AIFPMKNFFJI(0L, string.Empty, 0);
			JKIGJBJFKPH(LBKPPKEADMM);
			return;
		}
		TtTeamInfo ttTeamInfo = FAAILDFEHNF(OMJOIIOONMO.teamId);
		LECPGNKOABP lECPGNKOABP = LECPGNKOABP.GABGKBAKHDP;
		if (ABBDIDFPMON != null && ttTeamInfo != null && (lECPGNKOABP.OADDPGNIINO != ttTeamInfo.teamId || lECPGNKOABP.CPIKDFFHGCI != ABBDIDFPMON.Count))
		{
			LECPGNKOABP.GABGKBAKHDP.AIFPMKNFFJI(ttTeamInfo.teamId, ttTeamInfo.teamName, ABBDIDFPMON.Count);
		}
		GHMHFJEAHOK();
	}

	private void AJEOHODMOHH()
	{
		EGFIOMFPGCD = FIBJIOBINHL.CFBJBKEPGAN() + 3600;
	}

	private void KGBFKPJKOOD()
	{
		EGFIOMFPGCD = 0L;
	}

	private TtTeamInfo FAAILDFEHNF(long EMNOJOHFMEH)
	{
		for (int i = 0; i < NDABFDHPIBB.Count; i++)
		{
			TtTeamInfo ttTeamInfo = NDABFDHPIBB[i];
			if (ttTeamInfo.teamId == EMNOJOHFMEH)
			{
				return ttTeamInfo;
			}
		}
		return null;
	}

	public void LCBIJOLOHKM(bool CBLPOFNKIPO = false)
	{
		if (CBLPOFNKIPO)
		{
			LBKPPKEADMM = 1;
		}
		JKIGJBJFKPH(LBKPPKEADMM);
		PMHFHCBEENO();
	}

	public void LCEPBBLJGCG(int JEAAHAFHDEG, Action<bool> MGENCOJOJKN)
	{
		KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
		{
			new FACMEPHEBOB(base.IFOAAOCJODG, JEAAHAFHDEG, delegate(bool EEKJMDHEJCK)
			{
				MGENCOJOJKN(EEKJMDHEJCK);
				if (EEKJMDHEJCK)
				{
					BLEMAIJFELL();
				}
			})
		});
	}

	public void KALEIGDLEAM(int JEAAHAFHDEG)
	{
		KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
		{
			new FACMEPHEBOB(base.IFOAAOCJODG, JEAAHAFHDEG)
		});
		BLEMAIJFELL();
	}

	private void BLEMAIJFELL()
	{
		AJEOHODMOHH();
		GHMHFJEAHOK();
	}

	public void BCBDPNPEKFI()
	{
		CLPANKDCBCA = false;
	}

	public void JDBFNCMJMCH()
	{
		LIGHDLBBPLK = false;
	}

	public static void PMHFHCBEENO()
	{
		MapManager instance = MapManager.Instance;
		if (!(instance == null))
		{
			TeamTournamentDisplay teamTournamentDisplay = instance.NewMapContent.TeamTournamentDisplay;
			if (!(teamTournamentDisplay == null))
			{
				teamTournamentDisplay.Prepare();
			}
		}
	}

	public void LIMGCDCOMAJ()
	{
		ADNCLLLLMEO = true;
	}
}
