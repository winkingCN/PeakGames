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

public class GPAFPAEDOHM : IMPIFJOCKBI
{
	[CompilerGenerated]
	private sealed class IBCGDDJFPNI
	{
		internal Action<bool> MGENCOJOJKN;

		internal GPAFPAEDOHM PDAPIGLEPGC;

		internal void AGFNGEFDHLA(bool EEKJMDHEJCK)
		{
			MGENCOJOJKN(EEKJMDHEJCK);
			if (EEKJMDHEJCK)
			{
				PDAPIGLEPGC.BLEMAIJFELL();
			}
		}
	}

	private const string DGDOMDJMONF = "StarTournament";

	private const string CFFLIENJFCC = "Temp";

	public const int CLINMIOGLJK = 10800;

	public const int NJGLHDHBIPC = 0;

	public const int EBNAFCAEDOK = 1;

	public const int MNBMMMHFIEF = 2;

	public const int CPHBFNHEDNL = 3;

	public const int PLEDKAPEIIK = 4;

	private string HDONMHLNCNK;

	private HJBLKNBHMFJ GOEMHMEALGJ;

	private int JAIPNDBEKEL;

	private long AJPNGAEMOMC;

	private int DJJBGNGNLNI;

	private EventEntity PFNLGKJEGNP;

	private bool LIGHDLBBPLK;

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

	public int OHAPPDGAKNG
	{
		get
		{
			return DJJBGNGNLNI;
		}
	}

	public int FHIIFBJOKND
	{
		get
		{
			return PFNLGKJEGNP.MinLevel;
		}
	}

	public bool ADNCLLLLMEO { get; private set; }

	public bool BPDNGDOGLIO { get; private set; }

	public bool LMIPACNFAAB { get; private set; }

	public bool LJGNJNOIAPH
	{
		get
		{
			return MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1 >= FHIIFBJOKND && AEBACBBGHKI > 10800 && LIGHDLBBPLK;
		}
	}

	public List<StMemberInfo> NDABFDHPIBB { get; private set; }

	protected override int ENBPGGCIADN
	{
		get
		{
			return 4;
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

	public override void DDIBMLBPIEH(EventEntity MBIKENNNMKO)
	{
		if (GOEMHMEALGJ == null)
		{
			GOEMHMEALGJ = HJBLKNBHMFJ.GABGKBAKHDP;
		}
		int? num = MBIKENNNMKO.AIAEHPLOFGB();
		if (GODKDOHOHCD != 0 && (GODKDOHOHCD != num.GetValueOrDefault() || !num.HasValue))
		{
			if (JAIPNDBEKEL == 2)
			{
				return;
			}
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "StarTournament will remove old ({0}) event.", GODKDOHOHCD);
			IMPIFJOCKBI.PJHDJKAJAPM.GCLOHJDBLOD(base.IFOAAOCJODG);
			OMOKOKFNBKI();
		}
		GODKDOHOHCD = (num.HasValue ? num.Value : 0);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "StarTournament processed event for id={0}", GODKDOHOHCD);
		PFNLGKJEGNP = MBIKENNNMKO;
		HDONMHLNCNK = HOHMEMIEPGB();
		EJKMIHIEJMB();
	}

	public override bool DBJECBOBGMI()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "StarTournament try reset.");
		if (JAIPNDBEKEL >= 2)
		{
			return false;
		}
		OMOKOKFNBKI();
		return true;
	}

	public override void OMOKOKFNBKI()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "StarTournament is reset.");
		GOEMHMEALGJ.KFCIOFNMKDA(HDONMHLNCNK);
	}

	public override void MBHNMKFPGBH()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "StarTournament is reset after logout.");
		if (JAIPNDBEKEL != 3)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "StarTournament existing event will be stored as temp.");
			try
			{
				HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("Temp" + HDONMHLNCNK, JsonUtility.ToJson(PFNLGKJEGNP));
				return;
			}
			catch (Exception)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Events, "StarTournament exception on storing temp event.");
				return;
			}
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "StarTournament will remove claimed ({0}) event.", GODKDOHOHCD);
		IMPIFJOCKBI.PJHDJKAJAPM.GCLOHJDBLOD(GODKDOHOHCD);
		OMOKOKFNBKI();
	}

	public static void CDGGACPJAPD()
	{
		try
		{
			string text = "Temp" + HOHMEMIEPGB();
			string text2 = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM(text);
			if (text2 != null)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "StarTournament temp event will be stored into actual events table.");
				EventEntity eventEntity = JsonUtility.FromJson<EventEntity>(text2);
				eventEntity.PNLKNJNILDD(eventEntity.Id);
				IMPIFJOCKBI.PJHDJKAJAPM.PBPMICFEKFG(eventEntity);
				DGOMNDMPMBG.GABGKBAKHDP.MONGKICFIMO(4);
				HJBLKNBHMFJ.GABGKBAKHDP.MFKBEDNLCJA(text);
			}
		}
		catch (Exception)
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Events, "StarTournament exception on restoring temp events.");
		}
	}

	private static string HOHMEMIEPGB()
	{
		return "StarTournament" + LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
	}

	private void EJKMIHIEJMB()
	{
		ADNCLLLLMEO = false;
		JAIPNDBEKEL = 0;
		AJPNGAEMOMC = 0L;
		DJJBGNGNLNI = 0;
		string text = GOEMHMEALGJ.LIANKDMAHFM(HDONMHLNCNK);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "StarTournament is parsed as {0}", text);
		if (text == null)
		{
			LIGHDLBBPLK = true;
			GHMHFJEAHOK();
			return;
		}
		string[] array = text.Split(':');
		if (array.Length != 4)
		{
			GHMHFJEAHOK();
			return;
		}
		int.TryParse(array[1], out JAIPNDBEKEL);
		int result = 0;
		int.TryParse(array[0], out result);
		if (GODKDOHOHCD != result && JAIPNDBEKEL != 2)
		{
			LIGHDLBBPLK = true;
			JAIPNDBEKEL = 0;
			GHMHFJEAHOK();
		}
		else
		{
			long.TryParse(array[2], out AJPNGAEMOMC);
			int.TryParse(array[3], out DJJBGNGNLNI);
		}
	}

	private void GHMHFJEAHOK()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(GODKDOHOHCD).Append(':').Append(AEPLIGFCGIF)
			.Append(':')
			.Append(INFAGKCBEHL)
			.Append(':')
			.Append(OHAPPDGAKNG);
		string text = stringBuilder.ToString();
		GOEMHMEALGJ.JGMDDMNGDJO(HDONMHLNCNK, text);
		PMHFHCBEENO();
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "StarTournament state is persist as {0} for key {1}.", text, HDONMHLNCNK);
	}

	public void ADIMEEPIFBL(StStatusResponseMessage OMJOIIOONMO)
	{
		ADNCLLLLMEO = false;
		if (AJPNGAEMOMC != 0 && AJPNGAEMOMC != OMJOIIOONMO.groupId)
		{
			JAIPNDBEKEL = 0;
			DJJBGNGNLNI = 0;
		}
		AJPNGAEMOMC = OMJOIIOONMO.groupId;
		if (JAIPNDBEKEL <= 1 && OMJOIIOONMO.status == 2)
		{
			BPDNGDOGLIO = true;
		}
		if (JAIPNDBEKEL == 2 && OMJOIIOONMO.status == 2 && AEBACBBGHKI <= 0)
		{
			LMIPACNFAAB = true;
		}
		JAIPNDBEKEL = OMJOIIOONMO.status;
		DJJBGNGNLNI = OMJOIIOONMO.rank;
		if (OMJOIIOONMO.members.Count > 0)
		{
			NDABFDHPIBB = OMJOIIOONMO.members;
		}
		if (NDABFDHPIBB == null || NDABFDHPIBB.Count == 0)
		{
			BPDNGDOGLIO = false;
		}
		GHMHFJEAHOK();
	}

	public void LCEPBBLJGCG(Action<bool> MGENCOJOJKN)
	{
		KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
		{
			new PNMIALBOEJO(INFAGKCBEHL, delegate(bool EEKJMDHEJCK)
			{
				MGENCOJOJKN(EEKJMDHEJCK);
				if (EEKJMDHEJCK)
				{
					BLEMAIJFELL();
				}
			})
		});
	}

	public void KALEIGDLEAM()
	{
		KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
		{
			new PNMIALBOEJO(INFAGKCBEHL)
		});
		BLEMAIJFELL();
	}

	private void BLEMAIJFELL()
	{
		JAIPNDBEKEL = 3;
		LMIPACNFAAB = false;
		GHMHFJEAHOK();
	}

	public void BCBDPNPEKFI()
	{
		BPDNGDOGLIO = false;
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
			StarTournamentDisplay starTournamentDisplay = instance.NewMapContent.StarTournamentDisplay;
			if (!(starTournamentDisplay == null))
			{
				starTournamentDisplay.Prepare();
			}
		}
	}

	public StRewardsJson COGMBHJAPNO()
	{
		try
		{
			return JsonUtility.FromJson<StRewardsJson>(PFNLGKJEGNP.Data);
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Events, "Error parsing StarTournament Rewards Error:{0} Stack:{1}", ex.Message, ex.StackTrace);
		}
		return null;
	}

	public void LIMGCDCOMAJ()
	{
		ADNCLLLLMEO = true;
	}
}
