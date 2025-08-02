using System;

public abstract class PAANMJLACEF : EDOEBJJFOBM, OIOGABPKKPH, HGIAHEKANFO
{
	internal int LGPKPEMILHA;

	internal bool DHGLJHFEJFL = true;

	internal LNKPCJLANAO NEMEKIOEOLC;

	public int JPBIKBDCEKC
	{
		get
		{
			return LGPKPEMILHA;
		}
	}

	protected PAANMJLACEF(int LGPKPEMILHA, LNKPCJLANAO NEMEKIOEOLC)
	{
		DHGLJHFEJFL = true;
		this.LGPKPEMILHA = LGPKPEMILHA;
		this.NEMEKIOEOLC = NEMEKIOEOLC;
	}

	protected PAANMJLACEF(bool DHGLJHFEJFL, int LGPKPEMILHA, LNKPCJLANAO NEMEKIOEOLC)
	{
		this.DHGLJHFEJFL = DHGLJHFEJFL || NEMEKIOEOLC is MFHFAODDMLI;
		this.LGPKPEMILHA = LGPKPEMILHA;
		this.NEMEKIOEOLC = NEMEKIOEOLC;
	}

	internal static bool FHAFCOLHFPD(bool DNBCBHLACCP, EDOEBJJFOBM NEMEKIOEOLC)
	{
		if (DNBCBHLACCP || NEMEKIOEOLC is ALLINHNNNJN || NEMEKIOEOLC is FAGODOKGMEH)
		{
			return true;
		}
		PAANMJLACEF pAANMJLACEF = NEMEKIOEOLC as PAANMJLACEF;
		if (pAANMJLACEF == null)
		{
			return false;
		}
		return FHAFCOLHFPD(pAANMJLACEF.PEMPMPFCPFN(), pAANMJLACEF.NFMFKPLPLLH());
	}

	public static PAANMJLACEF BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DHGLJHFEJFL)
	{
		if (DHGLJHFEJFL)
		{
			return (PAANMJLACEF)NEMEKIOEOLC.NFMFKPLPLLH();
		}
		throw new ArgumentException("implicitly tagged tagged object");
	}

	public static PAANMJLACEF BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is PAANMJLACEF)
		{
			return (PAANMJLACEF)NEMEKIOEOLC;
		}
		throw new ArgumentException("Unknown object in GetInstance: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC), "obj");
	}

	protected override bool IMHPDJGGAGJ(EDOEBJJFOBM LABMKGMAEGK)
	{
		PAANMJLACEF pAANMJLACEF = LABMKGMAEGK as PAANMJLACEF;
		if (pAANMJLACEF == null)
		{
			return false;
		}
		return LGPKPEMILHA == pAANMJLACEF.LGPKPEMILHA && DHGLJHFEJFL == pAANMJLACEF.DHGLJHFEJFL && object.Equals(NFMFKPLPLLH(), pAANMJLACEF.NFMFKPLPLLH());
	}

	protected override int BGFGDLGFEPI()
	{
		int num = LGPKPEMILHA.GetHashCode();
		if (NEMEKIOEOLC != null)
		{
			num ^= NEMEKIOEOLC.GetHashCode();
		}
		return num;
	}

	public bool PEMPMPFCPFN()
	{
		return DHGLJHFEJFL;
	}

	public bool DHIKCKFGKID()
	{
		return false;
	}

	public EDOEBJJFOBM NFMFKPLPLLH()
	{
		if (NEMEKIOEOLC != null)
		{
			return NEMEKIOEOLC.IIHKEACDNID();
		}
		return null;
	}

	public HGIAHEKANFO KHNOGGHOBMH(int MOKLDCMGFFB, bool DNBCBHLACCP)
	{
		switch (MOKLDCMGFFB)
		{
		case 17:
			return FAGODOKGMEH.BJLJCGFMFOO(this, DNBCBHLACCP).NIJNIHGOKCA;
		case 16:
			return ALLINHNNNJN.BJLJCGFMFOO(this, DNBCBHLACCP).NIJNIHGOKCA;
		case 4:
			return PJGIGKJFGFI.BJLJCGFMFOO(this, DNBCBHLACCP).NIJNIHGOKCA;
		default:
			if (DNBCBHLACCP)
			{
				return NFMFKPLPLLH();
			}
			throw LHFGHNFJIKM.HOAJHBJIAIC("implicit tagging for tag: " + MOKLDCMGFFB);
		}
	}

	public override string ToString()
	{
		return "[" + LGPKPEMILHA + "]" + NEMEKIOEOLC;
	}
}
