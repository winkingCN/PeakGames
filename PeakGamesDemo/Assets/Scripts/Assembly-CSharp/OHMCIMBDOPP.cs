using System;
using System.Collections;

internal class OHMCIMBDOPP : KKMFHDBDNLF, BJLAMONNNDD
{
	protected const int PBFJKGBIDEB = 4;

	protected CGDEGBGOKJO COOBIGONLDK;

	private DANGFIDLKOF ELMKEGBBDON;

	private IDictionary MHHFOKCEJNJ;

	private int GHNGGMMIJPC;

	public virtual string KFKMEPMEBND
	{
		get
		{
			throw new InvalidOperationException("Use Fork() to get a definite IDigest");
		}
	}

	internal OHMCIMBDOPP()
	{
		ELMKEGBBDON = new DANGFIDLKOF();
		MHHFOKCEJNJ = LHFGHNFJIKM.JBEOCJEMGCE();
		GHNGGMMIJPC = -1;
	}

	private OHMCIMBDOPP(byte CLGLEBDKMMJ, BJLAMONNNDD EBHDIDBPDKB)
	{
		ELMKEGBBDON = null;
		MHHFOKCEJNJ = LHFGHNFJIKM.JBEOCJEMGCE();
		GHNGGMMIJPC = CLGLEBDKMMJ;
		MHHFOKCEJNJ[CLGLEBDKMMJ] = EBHDIDBPDKB;
	}

	public virtual void DIOELAHNLKJ(CGDEGBGOKJO MBEMNOCDDBC)
	{
		COOBIGONLDK = MBEMNOCDDBC;
	}

	public virtual KKMFHDBDNLF NFEDILFGOFB()
	{
		int num = COOBIGONLDK.HFMNBFOAPOP.BBHJHPLCMGM;
		if (num == 0)
		{
			JDNANIIIFGM jDNANIIIFGM = new JDNANIIIFGM();
			jDNANIIIFGM.DIOELAHNLKJ(COOBIGONLDK);
			ELMKEGBBDON.CHOLLICODBI(jDNANIIIFGM);
			return jDNANIIIFGM.NFEDILFGOFB();
		}
		GHNGGMMIJPC = KINEBFNENMB.NOMPGNMMDBO(num);
		JOBHPAMOJIB((byte)GHNGGMMIJPC);
		return this;
	}

	public virtual void PDDLLDKPKOC(byte JMCLOFPGGNN)
	{
		if (ELMKEGBBDON == null)
		{
			throw new InvalidOperationException("Too late to track more hash algorithms");
		}
		JOBHPAMOJIB(JMCLOFPGGNN);
	}

	public virtual void OLDLMNLPAMN()
	{
		MKDNBGHNBAI();
	}

	public virtual KKMFHDBDNLF ANPICCCJCIH()
	{
		byte b = (byte)GHNGGMMIJPC;
		BJLAMONNNDD bJLAMONNNDD = KINEBFNENMB.JIDIDNFBFKJ(b, (BJLAMONNNDD)MHHFOKCEJNJ[b]);
		if (ELMKEGBBDON != null)
		{
			ELMKEGBBDON.CHOLLICODBI(bJLAMONNNDD);
		}
		OHMCIMBDOPP oHMCIMBDOPP = new OHMCIMBDOPP(b, bJLAMONNNDD);
		oHMCIMBDOPP.DIOELAHNLKJ(COOBIGONLDK);
		return oHMCIMBDOPP;
	}

	public virtual BJLAMONNNDD IFHHBFPJJHN()
	{
		MKDNBGHNBAI();
		byte b = (byte)GHNGGMMIJPC;
		if (ELMKEGBBDON != null)
		{
			BJLAMONNNDD bJLAMONNNDD = KINEBFNENMB.KNADNPDKLGD(b);
			ELMKEGBBDON.CHOLLICODBI(bJLAMONNNDD);
			return bJLAMONNNDD;
		}
		return KINEBFNENMB.JIDIDNFBFKJ(b, (BJLAMONNNDD)MHHFOKCEJNJ[b]);
	}

	public virtual byte[] LGOMGMANPHC(byte JMCLOFPGGNN)
	{
		BJLAMONNNDD bJLAMONNNDD = (BJLAMONNNDD)MHHFOKCEJNJ[JMCLOFPGGNN];
		if (bJLAMONNNDD == null)
		{
			throw new InvalidOperationException("HashAlgorithm." + CHAPPEIIDHD.GMPMIOJECLI(JMCLOFPGGNN) + " is not being tracked");
		}
		bJLAMONNNDD = KINEBFNENMB.JIDIDNFBFKJ(JMCLOFPGGNN, bJLAMONNNDD);
		if (ELMKEGBBDON != null)
		{
			ELMKEGBBDON.CHOLLICODBI(bJLAMONNNDD);
		}
		return KDDIIEMIPKF.LCNOFBMOHHM(bJLAMONNNDD);
	}

	public virtual int MNAIJEEKPCP()
	{
		throw new InvalidOperationException("Use Fork() to get a definite IDigest");
	}

	public virtual int EEMLLAMENHO()
	{
		throw new InvalidOperationException("Use Fork() to get a definite IDigest");
	}

	public virtual void BPAJGOINFNL(byte MOPCLEEGDFB)
	{
		if (ELMKEGBBDON != null)
		{
			ELMKEGBBDON.WriteByte(MOPCLEEGDFB);
			return;
		}
		foreach (BJLAMONNNDD value in MHHFOKCEJNJ.Values)
		{
			value.BPAJGOINFNL(MOPCLEEGDFB);
		}
	}

	public virtual void GONEEEFEDGF(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int NBEDPKHALCN)
	{
		if (ELMKEGBBDON != null)
		{
			ELMKEGBBDON.Write(MOPCLEEGDFB, ELICNEDIBGB, NBEDPKHALCN);
			return;
		}
		foreach (BJLAMONNNDD value in MHHFOKCEJNJ.Values)
		{
			value.GONEEEFEDGF(MOPCLEEGDFB, ELICNEDIBGB, NBEDPKHALCN);
		}
	}

	public virtual int LCNOFBMOHHM(byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		throw new InvalidOperationException("Use Fork() to get a definite IDigest");
	}

	public virtual void OMOKOKFNBKI()
	{
		if (ELMKEGBBDON != null)
		{
			ELMKEGBBDON.SetLength(0L);
			return;
		}
		foreach (BJLAMONNNDD value in MHHFOKCEJNJ.Values)
		{
			value.OMOKOKFNBKI();
		}
	}

	protected virtual void MKDNBGHNBAI()
	{
		if (ELMKEGBBDON == null || MHHFOKCEJNJ.Count > 4)
		{
			return;
		}
		foreach (BJLAMONNNDD value in MHHFOKCEJNJ.Values)
		{
			ELMKEGBBDON.CHOLLICODBI(value);
		}
		ELMKEGBBDON = null;
	}

	protected virtual void JOBHPAMOJIB(byte JMCLOFPGGNN)
	{
		if (!MHHFOKCEJNJ.Contains(JMCLOFPGGNN))
		{
			BJLAMONNNDD value = KINEBFNENMB.KNADNPDKLGD(JMCLOFPGGNN);
			MHHFOKCEJNJ[JMCLOFPGGNN] = value;
		}
	}
}
