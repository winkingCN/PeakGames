using System;
using System.Collections.Generic;
using DAO.Entity;

public class CAGBGIHKHEJ : DLDDFKDFKEF
{
	public const int BHBMAFNDJJL = 10;

	public const int CLMAPELNOIC = 0;

	public const int NIOFDGEIHEE = 1;

	public const int MMPLFHMAMPE = 2;

	public const int PCPKPAKINGJ = 3;

	private static CAGBGIHKHEJ KNPOFJNFLJB;

	private readonly FAFMKOPDMBB NJCPCACOCGB;

	public static CAGBGIHKHEJ GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new CAGBGIHKHEJ();
			}
			return KNPOFJNFLJB;
		}
	}

	private CAGBGIHKHEJ()
	{
		NJCPCACOCGB = new FAFMKOPDMBB();
	}

	public void APNJAPLPHMB(string CCKEDMJMOJD)
	{
		NJCPCACOCGB.APNJAPLPHMB(CCKEDMJMOJD);
	}

	public void EOCDBIHEMJM(string CCKEDMJMOJD)
	{
		NJCPCACOCGB.EOCDBIHEMJM(CCKEDMJMOJD);
	}

	public int ELEKFHDLKJJ()
	{
		return NJCPCACOCGB.ELEKFHDLKJJ();
	}

	public int IEIHCCBMPPG(int NBFBPNNEKMN)
	{
		return NJCPCACOCGB.IEIHCCBMPPG(NBFBPNNEKMN);
	}

	public List<InboxEntity> LGGAKAHPGFE()
	{
		return NJCPCACOCGB.DFJBKKHAGNC();
	}

	public InboxEntity IBDDFALOHOC(int BDKFNEDHAOJ)
	{
		InboxEntity result = NJCPCACOCGB.BGNCAGELKFL(BDKFNEDHAOJ);
		NJCPCACOCGB.ALKGJAOMMNC(BDKFNEDHAOJ);
		return result;
	}

	public void NOIIEHLLENG(int NBFBPNNEKMN)
	{
		NJCPCACOCGB.NOIIEHLLENG(NBFBPNNEKMN);
	}

	public void OMOKOKFNBKI()
	{
		NJCPCACOCGB.BBGLCADIONK();
	}

	public bool CPDDAPIICDO(string IOCMOCCFALN, string DLALMJPFFMK, long DIKEGACKFFH)
	{
		return NJCPCACOCGB.HLHCFJJPPBK(IOCMOCCFALN, DLALMJPFFMK, DIKEGACKFFH, 0);
	}

	public void LCNJBFJEFNA(int NNIDKMJGAJO)
	{
		string dLALMJPFFMK = "DB" + DateTime.UtcNow.GMEBBNOHJFJ();
		for (int i = 0; i < NNIDKMJGAJO; i++)
		{
			NJCPCACOCGB.HLHCFJJPPBK("DB", dLALMJPFFMK, i, 1);
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Inbox, "Adding lives from Daily Bonus. {0}", this);
	}

	public void IELIMAJFDKF(int NNIDKMJGAJO)
	{
		string text = "TH";
		CFNKECEHDIC cFNKECEHDIC = DGOMNDMPMBG.GABGKBAKHDP.OEPCIADENMH;
		text = ((cFNKECEHDIC == null) ? (text + DateTime.Today.GMEBBNOHJFJ()) : (text + cFNKECEHDIC.IFOAAOCJODG));
		for (int i = 0; i < NNIDKMJGAJO; i++)
		{
			NJCPCACOCGB.HLHCFJJPPBK("TH", text, i, 2);
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Inbox, "Adding lives from Treasure Hunt. {0}", this);
	}

	public void OJHLFGFJFBH(int NNIDKMJGAJO)
	{
		string text = "SC";
		IDFPAFEJPPH iDFPAFEJPPH = IDFPAFEJPPH.GABGKBAKHDP;
		text = ((!iDFPAFEJPPH.HGNJBHGBLIN) ? (text + MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC()) : (text + (iDFPAFEJPPH.NBJMMBIGCOB + iDFPAFEJPPH.PDGLECFDLJJ)));
		for (int i = 0; i < NNIDKMJGAJO; i++)
		{
			NJCPCACOCGB.HLHCFJJPPBK("SC", text, i, 3);
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Inbox, "Adding lives from Star Chest. {0}", this);
	}

	public override string ToString()
	{
		return string.Format("Current Inbox: Social: {0}, Daily: {1}, Treasure: {2}, Star: {3}", IEIHCCBMPPG(0), IEIHCCBMPPG(1), IEIHCCBMPPG(2), IEIHCCBMPPG(3));
	}
}
