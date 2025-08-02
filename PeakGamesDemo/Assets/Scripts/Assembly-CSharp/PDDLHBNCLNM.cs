using System;
using System.IO;

public class PDDLHBNCLNM : EDOEBJJFOBM
{
	private readonly bool HGIFFGGMEPH;

	private readonly int MOKLDCMGFFB;

	private readonly byte[] KBOOEAPJGEL;

	public int IDDOGOEKBPN
	{
		get
		{
			return MOKLDCMGFFB;
		}
	}

	internal PDDLHBNCLNM(bool HGIFFGGMEPH, int MOKLDCMGFFB, byte[] KBOOEAPJGEL)
	{
		this.HGIFFGGMEPH = HGIFFGGMEPH;
		this.MOKLDCMGFFB = MOKLDCMGFFB;
		this.KBOOEAPJGEL = KBOOEAPJGEL;
	}

	public PDDLHBNCLNM(int MOKLDCMGFFB, byte[] KBOOEAPJGEL)
		: this(false, MOKLDCMGFFB, KBOOEAPJGEL)
	{
	}

	public PDDLHBNCLNM(int MOKLDCMGFFB, LNKPCJLANAO NEMEKIOEOLC)
		: this(true, MOKLDCMGFFB, NEMEKIOEOLC)
	{
	}

	public PDDLHBNCLNM(bool DNBCBHLACCP, int MOKLDCMGFFB, LNKPCJLANAO NEMEKIOEOLC)
	{
		EDOEBJJFOBM eDOEBJJFOBM = NEMEKIOEOLC.IIHKEACDNID();
		byte[] array = eDOEBJJFOBM.KMBJLPOKIAC();
		HGIFFGGMEPH = PAANMJLACEF.FHAFCOLHFPD(DNBCBHLACCP, eDOEBJJFOBM);
		this.MOKLDCMGFFB = MOKLDCMGFFB;
		if (DNBCBHLACCP)
		{
			KBOOEAPJGEL = array;
			return;
		}
		int num = BDGKNHOGAJE(array);
		byte[] array2 = new byte[array.Length - num];
		Array.Copy(array, num, array2, 0, array2.Length);
		KBOOEAPJGEL = array2;
	}

	public PDDLHBNCLNM(int LGPKPEMILHA, DLDBGGDLOOO NHAPONCIGFD)
	{
		MOKLDCMGFFB = LGPKPEMILHA;
		HGIFFGGMEPH = true;
		MemoryStream memoryStream = new MemoryStream();
		for (int i = 0; i != NHAPONCIGFD.GMCGMPEEHJP; i++)
		{
			try
			{
				byte[] array = NHAPONCIGFD.ECNCPJGHBIG(i).KMBJLPOKIAC();
				memoryStream.Write(array, 0, array.Length);
			}
			catch (IOException innerException)
			{
				throw new InvalidOperationException("malformed object", innerException);
			}
		}
		KBOOEAPJGEL = memoryStream.ToArray();
	}

	private int BDGKNHOGAJE(byte[] MBBPBGHKLJM)
	{
		int num = MBBPBGHKLJM[1];
		if (num == 128)
		{
			return 2;
		}
		if (num > 127)
		{
			int num2 = num & 0x7F;
			if (num2 > 4)
			{
				throw new InvalidOperationException("DER length more than 4 bytes: " + num2);
			}
			return num2 + 2;
		}
		return 2;
	}

	public bool FHAFCOLHFPD()
	{
		return HGIFFGGMEPH;
	}

	public byte[] EPCAJJBBAMO()
	{
		return KBOOEAPJGEL;
	}

	public EDOEBJJFOBM NFMFKPLPLLH()
	{
		return EDOEBJJFOBM.HPDCKMOPEMM(EPCAJJBBAMO());
	}

	public EDOEBJJFOBM NFMFKPLPLLH(int MCJBJOCHFPA)
	{
		if (MCJBJOCHFPA >= 31)
		{
			throw new IOException("unsupported tag number");
		}
		byte[] array = PPCPBIEGJKM();
		byte[] array2 = DNKGHHNGDIO(MCJBJOCHFPA, array);
		if ((array[0] & 0x20u) != 0)
		{
			array2[0] |= 32;
		}
		return EDOEBJJFOBM.HPDCKMOPEMM(array2);
	}

	internal override void LMDBBPLCJDM(JBLJHINPLMC NMHOOGAGLOA)
	{
		int num = 64;
		if (HGIFFGGMEPH)
		{
			num |= 0x20;
		}
		NMHOOGAGLOA.AGNEJPEMPAP(num, MOKLDCMGFFB, KBOOEAPJGEL);
	}

	protected override bool IMHPDJGGAGJ(EDOEBJJFOBM LABMKGMAEGK)
	{
		PDDLHBNCLNM pDDLHBNCLNM = LABMKGMAEGK as PDDLHBNCLNM;
		if (pDDLHBNCLNM == null)
		{
			return false;
		}
		return HGIFFGGMEPH == pDDLHBNCLNM.HGIFFGGMEPH && MOKLDCMGFFB == pDDLHBNCLNM.MOKLDCMGFFB && NOGCEBKPPJE.ICKLINNFHKK(KBOOEAPJGEL, pDDLHBNCLNM.KBOOEAPJGEL);
	}

	protected override int BGFGDLGFEPI()
	{
		return HGIFFGGMEPH.GetHashCode() ^ MOKLDCMGFFB.GetHashCode() ^ NOGCEBKPPJE.ILMFICENEMK(KBOOEAPJGEL);
	}

	private byte[] DNKGHHNGDIO(int MAEMMKCEHKG, byte[] MOPCLEEGDFB)
	{
		int num = MOPCLEEGDFB[0] & 0x1F;
		int num2 = 1;
		if (num == 31)
		{
			num = 0;
			int num3 = MOPCLEEGDFB[num2++] & 0xFF;
			if ((num3 & 0x7F) == 0)
			{
				throw new InvalidOperationException("corrupted stream - invalid high tag number found");
			}
			while (num3 >= 0 && ((uint)num3 & 0x80u) != 0)
			{
				num |= num3 & 0x7F;
				num <<= 7;
				num3 = MOPCLEEGDFB[num2++] & 0xFF;
			}
			num |= num3 & 0x7F;
		}
		byte[] array = new byte[MOPCLEEGDFB.Length - num2 + 1];
		Array.Copy(MOPCLEEGDFB, num2, array, 1, array.Length - 1);
		array[0] = (byte)MAEMMKCEHKG;
		return array;
	}
}
