using System.Collections.Generic;
using DAO.Entity;

public class DGOMNDMPMBG : IMPIFJOCKBI
{
	private const string GGMPGEBEGNE = "KeyEventDuration";

	public const int ICJMEFCFKHM = 0;

	public const int MFPOPMLCMHA = 3;

	public const int IOIMHKACLNM = 4;

	public const int CJAAAEGEJJI = 6;

	public const int NAFMAFOJPLD = 7;

	private static DGOMNDMPMBG KNPOFJNFLJB;

	private Dictionary<int, IMPIFJOCKBI> CDKINGIACGO;

	private MKINMKEMBPL LNFJCKLKNBD;

	private int BNOGOFGHPAE;

	protected override int ENBPGGCIADN
	{
		get
		{
			return 0;
		}
	}

	public static DGOMNDMPMBG GABGKBAKHDP
	{
		get
		{
			return KNPOFJNFLJB ?? (KNPOFJNFLJB = new DGOMNDMPMBG());
		}
	}

	public AAPMDEEMEMM BHGCBNAMEFK
	{
		get
		{
			return (MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() >= 22) ? DJDDOMOGNIE<AAPMDEEMEMM>(3) : null;
		}
	}

	public GPAFPAEDOHM IIEALLANECJ
	{
		get
		{
			return DJDDOMOGNIE<GPAFPAEDOHM>(4);
		}
	}

	public KCKDNJOMPJH FABKMFCBELE
	{
		get
		{
			return DJDDOMOGNIE<KCKDNJOMPJH>(6);
		}
	}

	public CFNKECEHDIC OEPCIADENMH
	{
		get
		{
			return (MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() >= 27) ? DJDDOMOGNIE<CFNKECEHDIC>(7) : null;
		}
	}

	public override long AEBACBBGHKI
	{
		get
		{
			return BNOGOFGHPAE;
		}
	}

	private T DJDDOMOGNIE<T>(int EDDNOJDPMCF) where T : IMPIFJOCKBI
	{
		IMPIFJOCKBI value;
		CDKINGIACGO.TryGetValue(EDDNOJDPMCF, out value);
		T val = (T)value;
		if (val == null || val.AEBACBBGHKI > 0)
		{
			return val;
		}
		return (!CIOEIIEGHAH(EDDNOJDPMCF)) ? val : ((T)null);
	}

	public void DIOELAHNLKJ()
	{
		LNFJCKLKNBD = MKINMKEMBPL.GABGKBAKHDP;
		BNOGOFGHPAE = LNFJCKLKNBD.CNDHGKBCFAB("KeyEventDuration");
		CDKINGIACGO = new Dictionary<int, IMPIFJOCKBI>();
		MONGKICFIMO();
		DMMDHDKFEEL();
	}

	public void MONGKICFIMO(int DCELGKOIMPK = 0)
	{
		List<EventEntity> list = IMPIFJOCKBI.PJHDJKAJAPM.KKCGHBNLPAB();
		if (list == null)
		{
			return;
		}
		for (int i = 0; i < list.Count; i++)
		{
			if (DCELGKOIMPK == 0 || DCELGKOIMPK == list[i].Type)
			{
				DDIBMLBPIEH(list[i]);
			}
		}
	}

	public override void DDIBMLBPIEH(EventEntity KNCMAMDPAPD)
	{
		int type = KNCMAMDPAPD.Type;
		if (!PGOLAJNOIBC(type))
		{
			return;
		}
		IMPIFJOCKBI value;
		CDKINGIACGO.TryGetValue(type, out value);
		if (value == null)
		{
			value = NPLBGNIAPKB(KNCMAMDPAPD);
			if (value == null)
			{
				return;
			}
			CDKINGIACGO[type] = value;
		}
		value.DDIBMLBPIEH(KNCMAMDPAPD);
		if (BNOGOFGHPAE == 0)
		{
			KNLJKKEHFKH();
		}
	}

	public void PMBHGGMJJJE(int DCELGKOIMPK, int GCKOBKBPOBE = 0)
	{
		IMPIFJOCKBI value;
		CDKINGIACGO.TryGetValue(DCELGKOIMPK, out value);
		if (value != null && (GCKOBKBPOBE == 0 || value.IFOAAOCJODG == GCKOBKBPOBE))
		{
			value.OMOKOKFNBKI();
			CDKINGIACGO.Remove(DCELGKOIMPK);
		}
	}

	public bool CIOEIIEGHAH(int DCELGKOIMPK, int GCKOBKBPOBE = 0)
	{
		IMPIFJOCKBI value;
		CDKINGIACGO.TryGetValue(DCELGKOIMPK, out value);
		if (value == null)
		{
			return true;
		}
		if (GCKOBKBPOBE != 0 && value.IFOAAOCJODG != GCKOBKBPOBE)
		{
			return true;
		}
		bool flag = value.DBJECBOBGMI();
		if (flag)
		{
			CDKINGIACGO.Remove(DCELGKOIMPK);
		}
		return flag;
	}

	public override void OMOKOKFNBKI()
	{
		foreach (KeyValuePair<int, IMPIFJOCKBI> item in CDKINGIACGO)
		{
			item.Value.MBHNMKFPGBH();
		}
		BNOGOFGHPAE = 0;
		CDKINGIACGO.Clear();
		LNFJCKLKNBD.CJOHLENDJGO("KeyEventDuration");
		IMPIFJOCKBI.PJHDJKAJAPM.OMOKOKFNBKI();
	}

	public void JJEPNNKPNBP(int DCELGKOIMPK, int GCKOBKBPOBE)
	{
		PMBHGGMJJJE(DCELGKOIMPK, GCKOBKBPOBE);
		IMPIFJOCKBI.PJHDJKAJAPM.GCLOHJDBLOD(GCKOBKBPOBE);
	}

	private static bool PGOLAJNOIBC(int DCELGKOIMPK)
	{
		return DCELGKOIMPK <= 7;
	}

	private static IMPIFJOCKBI NPLBGNIAPKB(EventEntity KNCMAMDPAPD)
	{
		switch (KNCMAMDPAPD.Type)
		{
		case 3:
			return new AAPMDEEMEMM();
		case 4:
			return new GPAFPAEDOHM();
		case 6:
			return new KCKDNJOMPJH();
		case 7:
			return new CFNKECEHDIC();
		default:
			return null;
		}
	}

	public void GBDFBLGCNLI(int NBFBPNNEKMN)
	{
		CDKINGIACGO.Remove(NBFBPNNEKMN);
		MONGKICFIMO(NBFBPNNEKMN);
	}

	public void ONKHPNEGKMD()
	{
		if (BNOGOFGHPAE != 0)
		{
			KNLJKKEHFKH();
		}
	}

	public void DMMDHDKFEEL()
	{
		if (BNOGOFGHPAE == 0)
		{
			return;
		}
		int num = int.MaxValue - (int)FIBJIOBINHL.CFBJBKEPGAN();
		if (num - BNOGOFGHPAE < 120)
		{
			return;
		}
		GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Events, "GeneralEventManager decided to reset events because of time difference {0} - {1}", num, BNOGOFGHPAE);
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, IMPIFJOCKBI> item in CDKINGIACGO)
		{
			IMPIFJOCKBI value = item.Value;
			if (value.DBJECBOBGMI())
			{
				list.Add(item.Key);
				IMPIFJOCKBI.PJHDJKAJAPM.COMBPALIEFO(value.IFOAAOCJODG, false);
			}
		}
		foreach (int item2 in list)
		{
			CDKINGIACGO.Remove(item2);
		}
		BNOGOFGHPAE = 0;
		LNFJCKLKNBD.CJOHLENDJGO("KeyEventDuration");
	}

	private void KNLJKKEHFKH()
	{
		BNOGOFGHPAE = int.MaxValue - (int)FIBJIOBINHL.CFBJBKEPGAN();
		LNFJCKLKNBD.HOKOPPLGJIK("KeyEventDuration", BNOGOFGHPAE);
	}

	public void NKEOIKOJMMD(int HCCBDFMKLHN)
	{
		if (BHGCBNAMEFK != null)
		{
			BHGCBNAMEFK.NKEOIKOJMMD(HCCBDFMKLHN);
		}
		if (OEPCIADENMH != null)
		{
			OEPCIADENMH.NKEOIKOJMMD();
		}
	}

	public void JDHNHIKEOMA()
	{
		if (BHGCBNAMEFK != null)
		{
			BHGCBNAMEFK.JDHNHIKEOMA();
		}
		if (OEPCIADENMH != null)
		{
			OEPCIADENMH.JDHNHIKEOMA();
		}
	}
}
