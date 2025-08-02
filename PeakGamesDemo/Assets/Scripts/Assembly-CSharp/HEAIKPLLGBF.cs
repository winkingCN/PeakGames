using System;
using System.IO;
using Org.BouncyCastle.Asn1;

public class HEAIKPLLGBF : OIOGABPKKPH, HGIAHEKANFO
{
	private bool PJNNCIJEOEJ;

	private int CABNFNJHGPK;

	private MKNDIEHOMOI IGCEJBIEACI;

	public bool FHAFCOLHFPD
	{
		get
		{
			return PJNNCIJEOEJ;
		}
	}

	public int JPBIKBDCEKC
	{
		get
		{
			return CABNFNJHGPK;
		}
	}

	[Obsolete]
	internal HEAIKPLLGBF(int OMAMOHJHHDK, int MGICLJGFJHK, Stream KPHHLMBMHEC)
		: this((OMAMOHJHHDK & 0x20) != 0, MGICLJGFJHK, new MKNDIEHOMOI(KPHHLMBMHEC))
	{
	}

	internal HEAIKPLLGBF(bool MKOIEJPCAAF, int MGICLJGFJHK, MKNDIEHOMOI BKOBLIALKKC)
	{
		PJNNCIJEOEJ = MKOIEJPCAAF;
		CABNFNJHGPK = MGICLJGFJHK;
		IGCEJBIEACI = BKOBLIALKKC;
	}

	public HGIAHEKANFO KHNOGGHOBMH(int MOKLDCMGFFB, bool DNBCBHLACCP)
	{
		if (DNBCBHLACCP)
		{
			if (!PJNNCIJEOEJ)
			{
				throw new IOException("Explicit tags must be constructed (see X.690 8.14.2)");
			}
			return IGCEJBIEACI.DMHLIGLGJGI();
		}
		return IGCEJBIEACI.PBFEALGKGBO(PJNNCIJEOEJ, MOKLDCMGFFB);
	}

	public EDOEBJJFOBM IIHKEACDNID()
	{
		try
		{
			return IGCEJBIEACI.OENBKIKIOBM(PJNNCIJEOEJ, CABNFNJHGPK);
		}
		catch (IOException ex)
		{
			throw new Asn1ParsingException(ex.Message);
		}
	}
}
