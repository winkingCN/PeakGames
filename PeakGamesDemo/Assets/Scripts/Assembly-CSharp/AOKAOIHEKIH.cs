using System;
using System.IO;
using Org.BouncyCastle.Asn1;

public class AOKAOIHEKIH : JJOLEANMIHG
{
	private readonly int GJHEBCMICMA;

	private readonly byte[][] IDIMNKOMCEK;

	public AOKAOIHEKIH(Stream KOAGMLLMNLB)
		: this(KOAGMLLMNLB, LICDFJKGLDA(KOAGMLLMNLB))
	{
	}

	public AOKAOIHEKIH(Stream KOAGMLLMNLB, int GJHEBCMICMA)
		: base(KOAGMLLMNLB)
	{
		this.GJHEBCMICMA = GJHEBCMICMA;
		IDIMNKOMCEK = new byte[16][];
	}

	public AOKAOIHEKIH(byte[] MOPCLEEGDFB)
		: this(new MemoryStream(MOPCLEEGDFB, false), MOPCLEEGDFB.Length)
	{
	}

	internal static int LICDFJKGLDA(Stream MOPCLEEGDFB)
	{
		if (MOPCLEEGDFB is GLHKJAKEPFB)
		{
			return ((GLHKJAKEPFB)MOPCLEEGDFB).KMNMMFJIFEL();
		}
		if (MOPCLEEGDFB is MemoryStream)
		{
			MemoryStream memoryStream = (MemoryStream)MOPCLEEGDFB;
			return (int)(memoryStream.Length - memoryStream.Position);
		}
		return int.MaxValue;
	}

	private EDOEBJJFOBM PKDIGPNNDMN(int MOKLDCMGFFB, int LGPKPEMILHA, int EOFAGACBNFP)
	{
		bool flag = (MOKLDCMGFFB & 0x20) != 0;
		DIKEJAHBNGH dIKEJAHBNGH = new DIKEJAHBNGH(IBBBMACIBGK, EOFAGACBNFP);
		if (((uint)MOKLDCMGFFB & 0x40u) != 0)
		{
			return new PDDLHBNCLNM(flag, LGPKPEMILHA, dIKEJAHBNGH.GDPLKNIEGDB());
		}
		if (((uint)MOKLDCMGFFB & 0x80u) != 0)
		{
			return new MKNDIEHOMOI(dIKEJAHBNGH).OENBKIKIOBM(flag, LGPKPEMILHA);
		}
		if (flag)
		{
			switch (LGPKPEMILHA)
			{
			case 4:
				return new OHNBHCLIOEI(MHDAKAPFOLG(dIKEJAHBNGH));
			case 16:
				return NOMAAAMBLJI(dIKEJAHBNGH);
			case 17:
				return NDJFAPHNLGJ(dIKEJAHBNGH);
			case 8:
				return new EKNLINDFMIM(MHDAKAPFOLG(dIKEJAHBNGH));
			default:
				throw new IOException("unknown tag " + LGPKPEMILHA + " encountered");
			}
		}
		return OLJCMLECKJB(LGPKPEMILHA, dIKEJAHBNGH, IDIMNKOMCEK);
	}

	internal DLDBGGDLOOO CGKKAPDENOB()
	{
		DLDBGGDLOOO dLDBGGDLOOO = new DLDBGGDLOOO();
		EDOEBJJFOBM eDOEBJJFOBM;
		while ((eDOEBJJFOBM = DMHLIGLGJGI()) != null)
		{
			dLDBGGDLOOO.JEACJNAKLDJ(eDOEBJJFOBM);
		}
		return dLDBGGDLOOO;
	}

	internal virtual DLDBGGDLOOO MHDAKAPFOLG(DIKEJAHBNGH IJFDHDOHBEF)
	{
		return new AOKAOIHEKIH(IJFDHDOHBEF).CGKKAPDENOB();
	}

	internal virtual KOGPLMALOEH NOMAAAMBLJI(DIKEJAHBNGH IJFDHDOHBEF)
	{
		return KOGPLMALOEH.CGMEKNCLBKE(MHDAKAPFOLG(IJFDHDOHBEF));
	}

	internal virtual CDHAHIDPGBP NDJFAPHNLGJ(DIKEJAHBNGH IJFDHDOHBEF)
	{
		return CDHAHIDPGBP.CGMEKNCLBKE(MHDAKAPFOLG(IJFDHDOHBEF), false);
	}

	public EDOEBJJFOBM DMHLIGLGJGI()
	{
		int num = ReadByte();
		if (num <= 0)
		{
			if (num == 0)
			{
				throw new IOException("unexpected end-of-contents marker");
			}
			return null;
		}
		int num2 = HDBPHEOFOBO(IBBBMACIBGK, num);
		bool flag = (num & 0x20) != 0;
		int num3 = OFBADDHGOEA(IBBBMACIBGK, GJHEBCMICMA);
		if (num3 < 0)
		{
			if (!flag)
			{
				throw new IOException("indefinite length primitive encoding encountered");
			}
			ENOELOLDAGE ePKPLBOMHJL = new ENOELOLDAGE(IBBBMACIBGK, GJHEBCMICMA);
			MKNDIEHOMOI bKOBLIALKKC = new MKNDIEHOMOI(ePKPLBOMHJL, GJHEBCMICMA);
			if (((uint)num & 0x40u) != 0)
			{
				return new HLOAHBDHDHK(num2, bKOBLIALKKC).IIHKEACDNID();
			}
			if (((uint)num & 0x80u) != 0)
			{
				return new HEAIKPLLGBF(true, num2, bKOBLIALKKC).IIHKEACDNID();
			}
			switch (num2)
			{
			case 4:
				return new NEHBNNHKFDM(bKOBLIALKKC).IIHKEACDNID();
			case 16:
				return new OJFANPHGCBK(bKOBLIALKKC).IIHKEACDNID();
			case 17:
				return new KOBDNDLAIOC(bKOBLIALKKC).IIHKEACDNID();
			case 8:
				return new GIJDCJHDFCO(bKOBLIALKKC).IIHKEACDNID();
			default:
				throw new IOException("unknown BER object encountered");
			}
		}
		try
		{
			return PKDIGPNNDMN(num, num2, num3);
		}
		catch (ArgumentException fGDHECKFFDP)
		{
			throw new Asn1Exception("corrupted stream detected", fGDHECKFFDP);
		}
	}

	internal static int HDBPHEOFOBO(Stream IBBBMACIBGK, int MOKLDCMGFFB)
	{
		int num = MOKLDCMGFFB & 0x1F;
		if (num == 31)
		{
			num = 0;
			int num2 = IBBBMACIBGK.ReadByte();
			if ((num2 & 0x7F) == 0)
			{
				throw new IOException("Corrupted stream - invalid high tag number found");
			}
			while (num2 >= 0 && ((uint)num2 & 0x80u) != 0)
			{
				num |= num2 & 0x7F;
				num <<= 7;
				num2 = IBBBMACIBGK.ReadByte();
			}
			if (num2 < 0)
			{
				throw new EndOfStreamException("EOF found inside tag value.");
			}
			num |= num2 & 0x7F;
		}
		return num;
	}

	internal static int OFBADDHGOEA(Stream IBBBMACIBGK, int GJHEBCMICMA)
	{
		int num = IBBBMACIBGK.ReadByte();
		if (num < 0)
		{
			throw new EndOfStreamException("EOF found when length expected");
		}
		if (num == 128)
		{
			return -1;
		}
		if (num > 127)
		{
			int num2 = num & 0x7F;
			if (num2 > 4)
			{
				throw new IOException("DER length more than 4 bytes: " + num2);
			}
			num = 0;
			for (int i = 0; i < num2; i++)
			{
				int num3 = IBBBMACIBGK.ReadByte();
				if (num3 < 0)
				{
					throw new EndOfStreamException("EOF found reading length");
				}
				num = (num << 8) + num3;
			}
			if (num < 0)
			{
				throw new IOException("Corrupted stream - negative length found");
			}
			if (num >= GJHEBCMICMA)
			{
				throw new IOException("Corrupted stream - out of bounds length found");
			}
		}
		return num;
	}

	internal static byte[] FCFKFLGCENL(DIKEJAHBNGH AOLADPLLDMN, byte[][] IDIMNKOMCEK)
	{
		int num = AOLADPLLDMN.KMNMMFJIFEL();
		if (num >= IDIMNKOMCEK.Length)
		{
			return AOLADPLLDMN.GDPLKNIEGDB();
		}
		byte[] array = IDIMNKOMCEK[num];
		if (array == null)
		{
			array = (IDIMNKOMCEK[num] = new byte[num]);
		}
		AOLADPLLDMN.LHKGEPBLMFH(array);
		return array;
	}

	internal static EDOEBJJFOBM OLJCMLECKJB(int LGPKPEMILHA, DIKEJAHBNGH AOLADPLLDMN, byte[][] IDIMNKOMCEK)
	{
		switch (LGPKPEMILHA)
		{
		case 1:
			return PNKAJJJPEPA.DADPGGIAGHN(FCFKFLGCENL(AOLADPLLDMN, IDIMNKOMCEK));
		case 10:
			return DLICBBHNDFH.DADPGGIAGHN(FCFKFLGCENL(AOLADPLLDMN, IDIMNKOMCEK));
		case 6:
			return KLKJHFKJLEM.DADPGGIAGHN(FCFKFLGCENL(AOLADPLLDMN, IDIMNKOMCEK));
		default:
		{
			byte[] array = AOLADPLLDMN.GDPLKNIEGDB();
			switch (LGPKPEMILHA)
			{
			case 3:
				return FJMKMKNJKOI.NKNAANNFPLL(array);
			case 30:
				return new GFMDJNIDEDM(array);
			case 24:
				return new DHKNJKJFPIP(array);
			case 27:
				return new CKOJHMOCKPI(array);
			case 25:
				return new NKGGMLLJNEJ(array);
			case 22:
				return new KCKEFHLLGIO(array);
			case 2:
				return new GLFDIPNOLKN(array);
			case 5:
				return HLAKNNHGPNP.GABGKBAKHDP;
			case 18:
				return new LDEOEEPIHGE(array);
			case 4:
				return new CFMJBFILJCB(array);
			case 19:
				return new JLGEDJAOAIJ(array);
			case 20:
				return new KLJAEMAGFDL(array);
			case 28:
				return new KPGIEFDJAEM(array);
			case 23:
				return new ECAOIPMOFLJ(array);
			case 12:
				return new GKCJIKGJBJA(array);
			case 21:
				return new MNJEPIOLBFG(array);
			case 26:
				return new EKOPFPAFGJO(array);
			default:
				throw new IOException("unknown tag " + LGPKPEMILHA + " encountered");
			}
		}
		}
	}
}
