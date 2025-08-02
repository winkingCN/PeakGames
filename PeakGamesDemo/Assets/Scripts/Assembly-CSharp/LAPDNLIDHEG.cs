using System.Collections.Generic;
using System.Text;
using DAO.Entity;
using caravan.protobuf.messages;

public class LAPDNLIDHEG : DLDDFKDFKEF
{
	public const char LOAGPLLLFAN = ':';

	private static LAPDNLIDHEG KNPOFJNFLJB;

	private readonly JAGPGEPOKFH LEIAHGJDNHN;

	public static LAPDNLIDHEG GABGKBAKHDP
	{
		get
		{
			return KNPOFJNFLJB ?? (KNPOFJNFLJB = new LAPDNLIDHEG());
		}
	}

	private LAPDNLIDHEG()
	{
		LEIAHGJDNHN = new JAGPGEPOKFH();
	}

	public List<EventEntity> KKCGHBNLPAB()
	{
		return LEIAHGJDNHN.OKLKMOABOBP();
	}

	public void CAEIHKPAAKE(List<EventData> NJOHMGMPGBE)
	{
		if (NJOHMGMPGBE.Count <= 0)
		{
			FPHMFHGIBGP(string.Empty);
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < NJOHMGMPGBE.Count; i++)
		{
			EventData eventData = NJOHMGMPGBE[i];
			EventEntity eventEntity = LEIAHGJDNHN.BGNCAGELKFL((int)eventData.id);
			stringBuilder.Append(eventData.id).Append(':');
			if (PDEPLMHJDKK(eventEntity, eventData))
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "New or updated event ({0}) will be stored.", eventData.id);
				EventEntity eventEntity2 = new EventEntity((int)eventData.id, eventData.type, (int)OMAJJLEOGIM(eventData.duration), eventData.minLevel, eventData.maxLevel, eventData.filter, eventData.version, DFGKPMCBFNL(eventData) ? 1 : 0, eventData.data);
				if (eventEntity == null)
				{
					LEIAHGJDNHN.LFHHPPDJGDC(eventEntity2);
				}
				else
				{
					LEIAHGJDNHN.GDFHLDAKIOM(eventEntity2);
				}
				if (eventEntity2.Eligible == 1)
				{
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "Event ({0}) is eligible to be processed.", eventData.id);
					DGOMNDMPMBG.GABGKBAKHDP.DDIBMLBPIEH(eventEntity2);
				}
			}
		}
		FPHMFHGIBGP(stringBuilder.ToString());
	}

	private static long OMAJJLEOGIM(long FMPBJJMKCIG)
	{
		return FIBJIOBINHL.CFBJBKEPGAN() + FMPBJJMKCIG;
	}

	private static bool PDEPLMHJDKK(EventEntity KNCMAMDPAPD, EventData MKIDBBBHBIC)
	{
		if (KNCMAMDPAPD == null || KNCMAMDPAPD.Version != MKIDBBBHBIC.version)
		{
			return true;
		}
		if (KNCMAMDPAPD.Eligible != 1)
		{
			return false;
		}
		long num = KNCMAMDPAPD.EndTime - FIBJIOBINHL.CFBJBKEPGAN();
		return num - 5 > MKIDBBBHBIC.duration || MKIDBBBHBIC.duration > num + 5;
	}

	private static bool DFGKPMCBFNL(EventData MKIDBBBHBIC)
	{
		int result = 0;
		int.TryParse("4161", out result);
		if (MKIDBBBHBIC.minClientVersion > result)
		{
			return false;
		}
		if (MKIDBBBHBIC.maxClientVersion != 0 && MKIDBBBHBIC.maxClientVersion < result)
		{
			return false;
		}
		if (MKIDBBBHBIC.type != 4)
		{
			if (MKIDBBBHBIC.minLevel > MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1)
			{
				return false;
			}
			if (MKIDBBBHBIC.maxLevel != 0 && MKIDBBBHBIC.maxLevel < MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1)
			{
				return false;
			}
		}
		if ((!MCJHHDACJBG.MCPELNPBPIF || !CCJBDEGNEAL.GKIBJAOFBHB(MKIDBBBHBIC.filter, 3)) && (!MCJHHDACJBG.NDNBMGMPBLF || !CCJBDEGNEAL.GKIBJAOFBHB(MKIDBBBHBIC.filter, 2)))
		{
			return false;
		}
		return (LECPGNKOABP.GABGKBAKHDP.ILNAPPDKOOD && CCJBDEGNEAL.GKIBJAOFBHB(MKIDBBBHBIC.filter, 1)) || (!LECPGNKOABP.GABGKBAKHDP.ILNAPPDKOOD && CCJBDEGNEAL.GKIBJAOFBHB(MKIDBBBHBIC.filter, 0));
	}

	private void FPHMFHGIBGP(string HOGKILACAJC)
	{
		List<EventEntity> list = LEIAHGJDNHN.BGBNJNLDBNP();
		if (list.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < list.Count; i++)
		{
			EventEntity eventEntity = list[i];
			int? num = eventEntity.AIAEHPLOFGB();
			DGOMNDMPMBG dGOMNDMPMBG = DGOMNDMPMBG.GABGKBAKHDP;
			if (HOGKILACAJC.Contains(num.ToString()))
			{
				if (eventEntity.Eligible == 0)
				{
					dGOMNDMPMBG.PMBHGGMJJJE(list[i].Type, num.Value);
				}
			}
			else if (!dGOMNDMPMBG.CIOEIIEGHAH(list[i].Type, num.Value))
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "Event ({0}) will be kept in the client.", num);
			}
			else
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "Event ({0}) will be removed.", num);
				LEIAHGJDNHN.IKIOFOOBHDM(num.Value);
			}
		}
	}

	public void OMOKOKFNBKI()
	{
		LEIAHGJDNHN.BBGLCADIONK();
	}

	public void COMBPALIEFO(int BDKFNEDHAOJ, bool AMGEDPDJPNE)
	{
		LEIAHGJDNHN.COMBPALIEFO(BDKFNEDHAOJ, AMGEDPDJPNE ? 1 : 0);
	}

	public void GCLOHJDBLOD(int GCKOBKBPOBE)
	{
		LEIAHGJDNHN.IKIOFOOBHDM(GCKOBKBPOBE);
	}

	public void PBPMICFEKFG(EventEntity KNCMAMDPAPD)
	{
		LEIAHGJDNHN.LFHHPPDJGDC(KNCMAMDPAPD);
	}

	public List<EventEntity> CKCAEMDMLFC(int NBFBPNNEKMN)
	{
		return LEIAHGJDNHN.EDDCKCGJNOA(NBFBPNNEKMN);
	}
}
