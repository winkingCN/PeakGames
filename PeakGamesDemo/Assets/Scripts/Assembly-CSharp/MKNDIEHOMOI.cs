using System;
using System.IO;
using Org.BouncyCastle.Asn1;

public class MKNDIEHOMOI
{
	private readonly Stream LDHCAPEAKHM;

	private readonly int JDGBNJLMCBP;

	private readonly byte[][] IDIMNKOMCEK;

	public MKNDIEHOMOI(Stream EPKPLBOMHJL)
		: this(EPKPLBOMHJL, AOKAOIHEKIH.LICDFJKGLDA(EPKPLBOMHJL))
	{
	}

	public MKNDIEHOMOI(Stream EPKPLBOMHJL, int GJHEBCMICMA)
	{
		if (!EPKPLBOMHJL.CanRead)
		{
			throw new ArgumentException("Expected stream to be readable", "inStream");
		}
		LDHCAPEAKHM = EPKPLBOMHJL;
		JDGBNJLMCBP = GJHEBCMICMA;
		IDIMNKOMCEK = new byte[16][];
	}

	public MKNDIEHOMOI(byte[] NJPMJNHGDNE)
		: this(new MemoryStream(NJPMJNHGDNE, false), NJPMJNHGDNE.Length)
	{
	}

	internal HGIAHEKANFO PIPEPNMLFAF(int MNCFEDGGAJM)
	{
		switch (MNCFEDGGAJM)
		{
		case 8:
			return new GIJDCJHDFCO(this);
		case 4:
			return new NEHBNNHKFDM(this);
		case 16:
			return new OJFANPHGCBK(this);
		case 17:
			return new KOBDNDLAIOC(this);
		default:
			throw new Asn1Exception("unknown BER object encountered: 0x" + MNCFEDGGAJM.ToString("X"));
		}
	}

	internal HGIAHEKANFO PBFEALGKGBO(bool MKOIEJPCAAF, int MOKLDCMGFFB)
	{
		if (LDHCAPEAKHM is ENOELOLDAGE)
		{
			if (!MKOIEJPCAAF)
			{
				throw new IOException("indefinite length primitive encoding encountered");
			}
			return PIPEPNMLFAF(MOKLDCMGFFB);
		}
		if (MKOIEJPCAAF)
		{
			switch (MOKLDCMGFFB)
			{
			case 17:
				return new OLMGBCMLIKI(this);
			case 16:
				return new IEOOBPLPNNL(this);
			case 4:
				return new NEHBNNHKFDM(this);
			}
		}
		else
		{
			switch (MOKLDCMGFFB)
			{
			case 17:
				throw new Asn1Exception("sequences must use constructed encoding (see X.690 8.9.1/8.10.1)");
			case 16:
				throw new Asn1Exception("sets must use constructed encoding (see X.690 8.11.1/8.12.1)");
			case 4:
				return new ADFKLCCOCDI((DIKEJAHBNGH)LDHCAPEAKHM);
			}
		}
		throw new Asn1Exception("implicit tagging not implemented");
	}

	internal EDOEBJJFOBM OENBKIKIOBM(bool MKOIEJPCAAF, int MOKLDCMGFFB)
	{
		if (!MKOIEJPCAAF)
		{
			DIKEJAHBNGH dIKEJAHBNGH = (DIKEJAHBNGH)LDHCAPEAKHM;
			return new JIHIOOKBBLB(false, MOKLDCMGFFB, new CFMJBFILJCB(dIKEJAHBNGH.GDPLKNIEGDB()));
		}
		DLDBGGDLOOO dLDBGGDLOOO = IFPAJCFNKGJ();
		if (LDHCAPEAKHM is ENOELOLDAGE)
		{
			return (dLDBGGDLOOO.GMCGMPEEHJP != 1) ? new FOGPHMBLIMH(false, MOKLDCMGFFB, KBOHOKHJFBA.CGMEKNCLBKE(dLDBGGDLOOO)) : new FOGPHMBLIMH(true, MOKLDCMGFFB, dLDBGGDLOOO.ECNCPJGHBIG(0));
		}
		return (dLDBGGDLOOO.GMCGMPEEHJP != 1) ? new JIHIOOKBBLB(false, MOKLDCMGFFB, KOGPLMALOEH.CGMEKNCLBKE(dLDBGGDLOOO)) : new JIHIOOKBBLB(true, MOKLDCMGFFB, dLDBGGDLOOO.ECNCPJGHBIG(0));
	}

	public virtual HGIAHEKANFO DMHLIGLGJGI()
	{
		int num = LDHCAPEAKHM.ReadByte();
		if (num == -1)
		{
			return null;
		}
		PIKAEGGLCBB(false);
		int num2 = AOKAOIHEKIH.HDBPHEOFOBO(LDHCAPEAKHM, num);
		bool flag = (num & 0x20) != 0;
		int num3 = AOKAOIHEKIH.OFBADDHGOEA(LDHCAPEAKHM, JDGBNJLMCBP);
		if (num3 < 0)
		{
			if (!flag)
			{
				throw new IOException("indefinite length primitive encoding encountered");
			}
			ENOELOLDAGE ePKPLBOMHJL = new ENOELOLDAGE(LDHCAPEAKHM, JDGBNJLMCBP);
			MKNDIEHOMOI mKNDIEHOMOI = new MKNDIEHOMOI(ePKPLBOMHJL, JDGBNJLMCBP);
			if (((uint)num & 0x40u) != 0)
			{
				return new HLOAHBDHDHK(num2, mKNDIEHOMOI);
			}
			if (((uint)num & 0x80u) != 0)
			{
				return new HEAIKPLLGBF(true, num2, mKNDIEHOMOI);
			}
			return mKNDIEHOMOI.PIPEPNMLFAF(num2);
		}
		DIKEJAHBNGH dIKEJAHBNGH = new DIKEJAHBNGH(LDHCAPEAKHM, num3);
		if (((uint)num & 0x40u) != 0)
		{
			return new PDDLHBNCLNM(flag, num2, dIKEJAHBNGH.GDPLKNIEGDB());
		}
		if (((uint)num & 0x80u) != 0)
		{
			return new HEAIKPLLGBF(flag, num2, new MKNDIEHOMOI(dIKEJAHBNGH));
		}
		if (flag)
		{
			switch (num2)
			{
			case 4:
				return new NEHBNNHKFDM(new MKNDIEHOMOI(dIKEJAHBNGH));
			case 16:
				return new IEOOBPLPNNL(new MKNDIEHOMOI(dIKEJAHBNGH));
			case 17:
				return new OLMGBCMLIKI(new MKNDIEHOMOI(dIKEJAHBNGH));
			case 8:
				return new GIJDCJHDFCO(new MKNDIEHOMOI(dIKEJAHBNGH));
			default:
				throw new IOException("unknown tag " + num2 + " encountered");
			}
		}
		if (num2 == 4)
		{
			return new ADFKLCCOCDI(dIKEJAHBNGH);
		}
		try
		{
			return AOKAOIHEKIH.OLJCMLECKJB(num2, dIKEJAHBNGH, IDIMNKOMCEK);
		}
		catch (ArgumentException fGDHECKFFDP)
		{
			throw new Asn1Exception("corrupted stream detected", fGDHECKFFDP);
		}
	}

	private void PIKAEGGLCBB(bool IEGIOBJMGKJ)
	{
		if (LDHCAPEAKHM is ENOELOLDAGE)
		{
			((ENOELOLDAGE)LDHCAPEAKHM).PFJFBEFJIHC(IEGIOBJMGKJ);
		}
	}

	internal DLDBGGDLOOO IFPAJCFNKGJ()
	{
		DLDBGGDLOOO dLDBGGDLOOO = new DLDBGGDLOOO();
		HGIAHEKANFO hGIAHEKANFO;
		while ((hGIAHEKANFO = DMHLIGLGJGI()) != null)
		{
			dLDBGGDLOOO.JEACJNAKLDJ(hGIAHEKANFO.IIHKEACDNID());
		}
		return dLDBGGDLOOO;
	}
}
