using System;
using Assets.Scripts.Utils;
using UnityEngine;

public class PJPPADHKGHN
{
	private const string KFBGANOCENG = "life_u";

	private const string AJFIOGNFLLD = "life_dt";

	private const string PPFDCFPKGCJ = "life_bf";

	private const string PMADNFJCAEM = "life_in";

	private const string ICDEOFDLHPC = "life_in_time";

	public const int NODPEPPCDFI = 5;

	public const int KMJDOJIJNJJ = 1800;

	private const int PIHBGOPMGGN = 300;

	private static PJPPADHKGHN KNPOFJNFLJB;

	public int EFFMBBAJLCF;

	private readonly HJBLKNBHMFJ NJCPCACOCGB;

	private readonly MKINMKEMBPL LOPLELOLBNO;

	private readonly GEBAAFFGKJG ODIIMFEIGPP;

	private int DEJADGLONND;

	private KDIMALLNOFG OOHDEMABPOF;

	private KDIMALLNOFG JPBJBKODIPD;

	private int HHAKOFHINLI;

	private int OLMOKGAOPDE;

	public int FNJHCNEGNCC { get; private set; }

	public static PJPPADHKGHN GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB != null)
			{
				return KNPOFJNFLJB;
			}
			KNPOFJNFLJB = new PJPPADHKGHN();
			return KNPOFJNFLJB;
		}
	}

	private PJPPADHKGHN()
	{
		FNJHCNEGNCC = 1800;
		NJCPCACOCGB = HJBLKNBHMFJ.GABGKBAKHDP;
		ODIIMFEIGPP = GEBAAFFGKJG.GABGKBAKHDP;
		LOPLELOLBNO = MKINMKEMBPL.GABGKBAKHDP;
		CDOOPEMANMI();
	}

	public void CDOOPEMANMI()
	{
		OOHDEMABPOF = default(KDIMALLNOFG);
		DEJADGLONND = -1;
		JPBJBKODIPD = new KDIMALLNOFG(NJCPCACOCGB.LIANKDMAHFM("life_u"));
		HHAKOFHINLI = ODIIMFEIGPP.JFGLEMPLBKE(NAAHKHPBAPA.UnlimitedLife);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LifeStatusHelper, "Unlimited life until: {0} with duration: {1}", JPBJBKODIPD, HHAKOFHINLI);
	}

	private int OHHMIDDNHBF()
	{
		if (DEJADGLONND >= 0)
		{
			return DEJADGLONND;
		}
		int dEJADGLONND = ODIIMFEIGPP.JFGLEMPLBKE(NAAHKHPBAPA.Life);
		DEJADGLONND = dEJADGLONND;
		return DEJADGLONND;
	}

	public bool MFDIAGADLNJ()
	{
		if (HNBIMJHPIPE() > 0)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LifeStatusHelper, "Using from unlimited lifes. Exp:{0} Dur:{1}", JPBJBKODIPD, HHAKOFHINLI);
			return true;
		}
		MOLCIIAPCMN mOLCIIAPCMN = PMBGCACJIHD();
		if (mOLCIIAPCMN.DLDHNNCGIPI <= 0)
		{
			return false;
		}
		if (mOLCIIAPCMN.DLDHNNCGIPI == 5)
		{
			OOHDEMABPOF = OIAJPMNJGLK.JHJCHDODNMK;
			MNBDCFDOFAM();
		}
		mOLCIIAPCMN.DLDHNNCGIPI--;
		DEJADGLONND = mOLCIIAPCMN.DLDHNNCGIPI;
		GHAKGLNKECB();
		return true;
	}

	public void CJNFILFKEAC(bool HKKFECMGNHL = true)
	{
		DEJADGLONND = OHHMIDDNHBF();
		DEJADGLONND++;
		if (DEJADGLONND > 5)
		{
			DEJADGLONND = 5;
		}
		GHAKGLNKECB(HKKFECMGNHL);
	}

	public MOLCIIAPCMN PMBGCACJIHD()
	{
		int num = OHHMIDDNHBF();
		int cENFCBHJGJP = 0;
		KDIMALLNOFG kDIMALLNOFG = OIAJPMNJGLK.JHJCHDODNMK;
		if (OOHDEMABPOF.ECGBOAIAJOO())
		{
			string text = NJCPCACOCGB.LIANKDMAHFM("life_dt");
			if (text != null)
			{
				OOHDEMABPOF = new KDIMALLNOFG(text);
			}
		}
		if (OOHDEMABPOF.KOOPOIBAFJO())
		{
			if (num >= 5)
			{
				return new MOLCIIAPCMN(FNJHCNEGNCC, num);
			}
			int num2 = (int)KDIMALLNOFG.IHHPDAKLIGF(kDIMALLNOFG, OOHDEMABPOF).TotalSeconds;
			int num3 = (int)Mathf.Floor((float)num2 / (float)FNJHCNEGNCC);
			if (num3 > 0)
			{
				num = Math.Min(5, num + num3);
				TimeSpan fNJHPJDHLPE = TimeSpan.FromSeconds(num2 % FNJHCNEGNCC);
				cENFCBHJGJP = (int)fNJHPJDHLPE.TotalSeconds;
				OOHDEMABPOF = kDIMALLNOFG;
				OOHDEMABPOF.FKBJBNOGFLE(fNJHPJDHLPE);
				DEJADGLONND = num;
				LOPLELOLBNO.GPJDHPEELCP("life_in", num3);
				MNBDCFDOFAM();
				GHAKGLNKECB();
			}
			else if (num2 >= 0)
			{
				OLMOKGAOPDE = 0;
				cENFCBHJGJP = FNJHCNEGNCC - num2;
			}
			else
			{
				if (OLMOKGAOPDE > 2)
				{
					OLMOKGAOPDE = 0;
					num2 = LOPLELOLBNO.CNDHGKBCFAB("life_bf");
					OOHDEMABPOF = kDIMALLNOFG;
					OOHDEMABPOF.FKBJBNOGFLE(new TimeSpan(0, 0, num2));
					MNBDCFDOFAM(false);
				}
				OLMOKGAOPDE++;
			}
		}
		else
		{
			OOHDEMABPOF = OIAJPMNJGLK.JHJCHDODNMK;
			MNBDCFDOFAM();
		}
		return new MOLCIIAPCMN(cENFCBHJGJP, DEJADGLONND);
	}

	private void GHAKGLNKECB(bool HKKFECMGNHL = true)
	{
		if (DEJADGLONND < 0)
		{
			DEJADGLONND = 0;
		}
		ODIIMFEIGPP.MDCKDPBIIEN(NAAHKHPBAPA.Life, DEJADGLONND, true, HKKFECMGNHL);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LifeStatusHelper, "Updating last count  as {0}", DEJADGLONND);
	}

	private void MNBDCFDOFAM(bool IMHPKDDKJMH = true, string LBPLFOKNDJK = null)
	{
		NJCPCACOCGB.JGMDDMNGDJO("life_dt", OOHDEMABPOF.ONBGDIHNPHI());
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LifeStatusHelper, "Updating last life update as {0}", OOHDEMABPOF);
		if (IMHPKDDKJMH)
		{
			OIAJPMNJGLK.NMHNDKBIEJA(LBPLFOKNDJK);
		}
	}

	public void MMECFKDOBDC()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LifeStatusHelper, "Refilling life!");
		OIAJPMNJGLK.OIOEHLJFLJG();
		DEJADGLONND = 5;
		OOHDEMABPOF = OIAJPMNJGLK.JHJCHDODNMK;
		GHAKGLNKECB();
		MNBDCFDOFAM();
	}

	public void ALIHKHMEPPG(int IGPFONDOMLJ)
	{
		if (IGPFONDOMLJ > 0)
		{
			int num = IGPFONDOMLJ * 60 * 60;
			string text = NJCPCACOCGB.LIANKDMAHFM("life_u");
			KDIMALLNOFG jPBJBKODIPD = ((text != null) ? new KDIMALLNOFG(text) : new KDIMALLNOFG(DateTime.MinValue, DateTime.MinValue));
			KDIMALLNOFG kDIMALLNOFG = OIAJPMNJGLK.JHJCHDODNMK;
			if (jPBJBKODIPD.AMFFIMFBOEF(kDIMALLNOFG))
			{
				jPBJBKODIPD = kDIMALLNOFG;
			}
			MMECFKDOBDC();
			jPBJBKODIPD.JMCCKLJCKKH(TimeSpan.FromSeconds(num));
			JPBJBKODIPD = jPBJBKODIPD;
			NJCPCACOCGB.JGMDDMNGDJO("life_u", jPBJBKODIPD.ONBGDIHNPHI());
			int num2 = ODIIMFEIGPP.JFGLEMPLBKE(NAAHKHPBAPA.UnlimitedLife);
			if (num2 == 0)
			{
				num2 = 2;
				FocusListener.MarkTime();
			}
			HHAKOFHINLI = num2 + num;
			ODIIMFEIGPP.MDCKDPBIIEN(NAAHKHPBAPA.UnlimitedLife, HHAKOFHINLI, true);
		}
	}

	public void BOLHHAJPKMH(int FMPBJJMKCIG, bool LFBLEHAGDNL)
	{
		if (FMPBJJMKCIG <= 0)
		{
			JPBJBKODIPD = new KDIMALLNOFG(null);
			HHAKOFHINLI = 0;
			NJCPCACOCGB.MFKBEDNLCJA("life_u");
			ODIIMFEIGPP.MDCKDPBIIEN(NAAHKHPBAPA.UnlimitedLife, 0, LFBLEHAGDNL);
			return;
		}
		KDIMALLNOFG jPBJBKODIPD = OIAJPMNJGLK.JHJCHDODNMK;
		MMECFKDOBDC();
		jPBJBKODIPD.JMCCKLJCKKH(TimeSpan.FromSeconds(FMPBJJMKCIG));
		JPBJBKODIPD = jPBJBKODIPD;
		NJCPCACOCGB.JGMDDMNGDJO("life_u", jPBJBKODIPD.ONBGDIHNPHI());
		FocusListener.MarkTime();
		HHAKOFHINLI = FMPBJJMKCIG;
		ODIIMFEIGPP.MDCKDPBIIEN(NAAHKHPBAPA.UnlimitedLife, FMPBJJMKCIG, LFBLEHAGDNL);
	}

	public int HNBIMJHPIPE()
	{
		double totalSeconds = KDIMALLNOFG.IHHPDAKLIGF(JPBJBKODIPD, OIAJPMNJGLK.JHJCHDODNMK).TotalSeconds;
		float num = (float)HHAKOFHINLI - FocusListener.EOFACIOAGKE;
		double num2 = Math.Min(totalSeconds, num);
		if (num2 >= 0.0)
		{
			return (int)num2;
		}
		return 0;
	}

	public void PIJMPOOEADM()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LifeStatusHelper, "Resetting unlimited life.");
		JPBJBKODIPD = new KDIMALLNOFG(DateTime.MinValue, DateTime.MinValue);
		NJCPCACOCGB.JGMDDMNGDJO("life_u", JPBJBKODIPD.ONBGDIHNPHI());
	}

	public void JFPAMGINAEO()
	{
		DEJADGLONND = 0;
		OOHDEMABPOF = OIAJPMNJGLK.JHJCHDODNMK;
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LifeStatusHelper, "Setting life count as 0.");
		GHAKGLNKECB();
		MNBDCFDOFAM(false);
		PIJMPOOEADM();
	}

	public void GCIDCPDFFCL()
	{
		int num = FNJHCNEGNCC - PMBGCACJIHD().APLNHKHHMEL;
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LifeStatusHelper, "Saving passed time as {0}", num);
		LOPLELOLBNO.HOKOPPLGJIK("life_bf", num);
	}

	public string AINIOIILGBG()
	{
		PMBGCACJIHD();
		return OOHDEMABPOF.ONBGDIHNPHI();
	}

	public void AOKIKEFDGAD(int JICDIPJFEGG, string LBPLFOKNDJK)
	{
		DEJADGLONND = JICDIPJFEGG;
		if (LBPLFOKNDJK != null)
		{
			try
			{
				OOHDEMABPOF = new KDIMALLNOFG(LBPLFOKNDJK);
			}
			catch (Exception ex)
			{
				DEJADGLONND = 5;
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.LifeStatusHelper, "Can not parse time from server: {0}", ex.Message);
			}
		}
		ODIIMFEIGPP.MDCKDPBIIEN(NAAHKHPBAPA.Life, DEJADGLONND);
		PMBGCACJIHD();
		MNBDCFDOFAM(true, LBPLFOKNDJK);
	}

	public bool DGEJJAIINIL(long GMBFFEPCOKG)
	{
		int num = LOPLELOLBNO.CNDHGKBCFAB("life_in_time");
		if (num <= 0)
		{
			num = 2100;
		}
		long num2 = OIAJPMNJGLK.HCBKKCHMJNA() - num;
		if (num2 < 0)
		{
			num2 = 0L;
		}
		long num3 = FIBJIOBINHL.IIDMAMGMAAA(GMBFFEPCOKG).GMEBBNOHJFJ();
		int num4 = DCFKJMLKCPN(num2, num3);
		int num5 = LOPLELOLBNO.CNDHGKBCFAB("life_in");
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LifeStatusHelper, "LifeHack control PassedTime:{0}, BeginTime:{1}, EndTime:{2}, EarnedLife:{3}", num, num2, num3, num5);
		return num5 <= num4;
	}

	private static int DCFKJMLKCPN(long PDLFDGDCKMN, long HMBONMAMAKL)
	{
		long num = HMBONMAMAKL - PDLFDGDCKMN;
		if (num <= 0)
		{
			return 0;
		}
		return (int)num / 1800;
	}

	public void CJDADPHKAFL()
	{
		MOLCIIAPCMN mOLCIIAPCMN = PMBGCACJIHD();
		LOPLELOLBNO.CJOHLENDJGO("life_in");
		int num = FNJHCNEGNCC - mOLCIIAPCMN.APLNHKHHMEL;
		if (num < 0)
		{
			num = 0;
		}
		LOPLELOLBNO.HOKOPPLGJIK("life_in_time", num + 300);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LifeStatusHelper, "LifeHack earned life count is reset, and passed time saved as {0}.", num);
	}
}
