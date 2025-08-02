using System.Collections;
using System.Collections.Generic;

public abstract class DIDKFJGJDPC : KOJFINJEKOE, AFKEOGBFCBE, NGBFPFEHHNG
{
	protected CJCKDELDNLB MACENOLLICJ;

	protected JFEIHACOLNL COOBIGONLDK;

	protected IList CFGIHFFACPK;

	protected int[] AJMLOOJHBBO;

	protected byte[] HLPGDFLIDKC;

	protected byte[] OEOBANOOGDJ;

	protected int HOGFBOADFJJ;

	protected short JBOFDCJMHOK;

	public List<string> KCGKBOHNIPE { get; set; }

	public virtual OBDIBELBBEO ONMBHGAEFAP
	{
		get
		{
			return BEHNDIMGDKM;
		}
	}

	public virtual OBDIBELBBEO BEHNDIMGDKM
	{
		get
		{
			return OBDIBELBBEO.JIBPNECGBPK;
		}
	}

	public virtual bool NABMKHFPEJE
	{
		get
		{
			return false;
		}
	}

	public virtual OBDIBELBBEO DCDFJOJMPKC
	{
		get
		{
			return OBDIBELBBEO.PBNEGCKIBHE;
		}
	}

	public DIDKFJGJDPC()
		: this(new LMIJMHPEHJJ())
	{
	}

	public DIDKFJGJDPC(CJCKDELDNLB HOPNNDNDFMC)
	{
		MACENOLLICJ = HOPNNDNDFMC;
	}

	protected virtual bool DLBECAEOEMM(int LJCOCHEBHLD, byte[] NIHLDDGDKGP)
	{
		if (LJCOCHEBHLD == 10)
		{
			NKCEMDBADJF.KKNHEHDAHKB(NIHLDDGDKGP);
			return true;
		}
		return false;
	}

	protected virtual void MNNGGEHBOBH(IDictionary LJDFGPJGHFH, int LJCOCHEBHLD)
	{
		byte[] array = KINEBFNENMB.MHMMGPFEAJM(LJDFGPJGHFH, LJCOCHEBHLD);
		if (array != null && !DLBECAEOEMM(LJCOCHEBHLD, array))
		{
			throw new DEIDBCPPCMB(47);
		}
	}

	public virtual void DIOELAHNLKJ(JFEIHACOLNL MBEMNOCDDBC)
	{
		COOBIGONLDK = MBEMNOCDDBC;
	}

	public virtual POBPBLILLLP LACFMMKMGIO()
	{
		return null;
	}

	public virtual IDictionary BHNEJODLNJI()
	{
		IDictionary dictionary = null;
		OBDIBELBBEO aNFOFLFNDAK = COOBIGONLDK.BEHNDIMGDKM;
		if (KINEBFNENMB.ABIOLEEPEHN(aNFOFLFNDAK))
		{
			CFGIHFFACPK = KINEBFNENMB.EHFEAFLEMHN();
			dictionary = APHMHGMCEML.GHEDPOHNGFO(dictionary);
			KINEBFNENMB.HLCHLMCMMGN(dictionary, CFGIHFFACPK);
		}
		if (NKCEMDBADJF.FAAOILCCCKB(JJABFAMPIIB()))
		{
			AJMLOOJHBBO = new int[2] { 23, 24 };
			HLPGDFLIDKC = new byte[3] { 0, 1, 2 };
			dictionary = APHMHGMCEML.GHEDPOHNGFO(dictionary);
			NKCEMDBADJF.DJHEKAPGBFL(dictionary, AJMLOOJHBBO);
			NKCEMDBADJF.JFCKEJADMLN(dictionary, HLPGDFLIDKC);
		}
		if (KCGKBOHNIPE != null && KCGKBOHNIPE.Count > 0)
		{
			List<OAJOIGPAFEJ> list = new List<OAJOIGPAFEJ>(KCGKBOHNIPE.Count);
			for (int i = 0; i < KCGKBOHNIPE.Count; i++)
			{
				list.Add(new OAJOIGPAFEJ(0, KCGKBOHNIPE[i]));
			}
			APHMHGMCEML.FBAMBBMFJAL(dictionary, new IGNCGHEOJIP(list));
		}
		return dictionary;
	}

	public virtual void OFBJOJNMMKO(OBDIBELBBEO AJKHHEOLCMD)
	{
		if (!DCDFJOJMPKC.BMJPEMBKPII(AJKHHEOLCMD))
		{
			throw new DEIDBCPPCMB(70);
		}
	}

	public abstract int[] JJABFAMPIIB();

	public virtual byte[] CPIOFBAJBGI()
	{
		return new byte[1];
	}

	public virtual void AGBLBIICBDC(byte[] OEPIOANFJDF)
	{
	}

	public virtual void GHMPCEPDDAB(int MCBKAEMNHAF)
	{
		HOGFBOADFJJ = MCBKAEMNHAF;
	}

	public virtual void NMBKKHBCEKJ(byte IFNHDMDCLHE)
	{
		JBOFDCJMHOK = IFNHDMDCLHE;
	}

	public virtual void BEAKIHMNDJG(IDictionary LJDFGPJGHFH)
	{
		if (LJDFGPJGHFH != null)
		{
			MNNGGEHBOBH(LJDFGPJGHFH, 13);
			MNNGGEHBOBH(LJDFGPJGHFH, 10);
			if (NKCEMDBADJF.BIBJBEEPJMP(HOGFBOADFJJ))
			{
				OEOBANOOGDJ = NKCEMDBADJF.PIINMMAGLHI(LJDFGPJGHFH);
			}
			else
			{
				MNNGGEHBOBH(LJDFGPJGHFH, 11);
			}
			MNNGGEHBOBH(LJDFGPJGHFH, 21);
		}
	}

	public virtual void BIMLMGADCAL(IList FNAIBLIAKCB)
	{
		if (FNAIBLIAKCB != null)
		{
			throw new DEIDBCPPCMB(10);
		}
	}

	public abstract HMPLNBAPPNE CNJBDCLEKNL();

	public abstract HFLDELFJCEE DNHBFEBDMPF();

	public virtual IList BBJOJOFIFCO()
	{
		return null;
	}

	public override EIMOMMNKKEG MCBOEBCAGAN()
	{
		switch (JBOFDCJMHOK)
		{
		case 0:
			return new DGELJFKJOPB();
		case 1:
			return new NMEDJHNADDK();
		default:
			throw new DEIDBCPPCMB(80);
		}
	}

	public override ECBKNMOGLEG FKNFDDEJJFO()
	{
		int eELDCJOKNOM = KINEBFNENMB.LJMKNAKPGEB(HOGFBOADFJJ);
		int oELMNFIJNEJ = KINEBFNENMB.HPGGOHAOHNH(HOGFBOADFJJ);
		return MACENOLLICJ.NBOGEPALJBP(COOBIGONLDK, eELDCJOKNOM, oELMNFIJNEJ);
	}

	public virtual void COOBDCPKGBF(GDAIELDPMAD PIPDHBFKMLP)
	{
	}
}
