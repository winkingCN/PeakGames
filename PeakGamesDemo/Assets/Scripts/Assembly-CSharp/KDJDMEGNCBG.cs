using System;

public class KDJDMEGNCBG : JMPFLJGHAIM
{
	private const int DFKIEEIDJNM = 32;

	private const int NOCNBNLBJMN = 8;

	private const int IEDLOAAAKAJ = -1640531527;

	private uint[] PCIJPEKJHMB = new uint[4];

	private uint[] ECONGBACNKE = new uint[32];

	private uint[] DEGEPCPMKGJ = new uint[32];

	private bool MOBILIJAIEK;

	private bool FPNNDLKJION;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return "XTEA";
		}
	}

	public virtual bool ABNLKPDCGEF
	{
		get
		{
			return false;
		}
	}

	public KDJDMEGNCBG()
	{
		MOBILIJAIEK = false;
	}

	public virtual int BDIGGHEPIIP()
	{
		return 8;
	}

	public virtual void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		if (!(IJJHBEECMBP is JEMNCGMEABF))
		{
			throw new ArgumentException("invalid parameter passed to TEA init - " + LHFGHNFJIKM.JKHOEKAOLPM(IJJHBEECMBP));
		}
		FPNNDLKJION = MAEALKEJALK;
		MOBILIJAIEK = true;
		JEMNCGMEABF jEMNCGMEABF = (JEMNCGMEABF)IJJHBEECMBP;
		LHCPMMKLJGA(jEMNCGMEABF.MEGBFHFMBFI());
	}

	public virtual int DPACJDFHLKB(byte[] AIFKJBMJOMK, int ELICNEDIBGB, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		if (!MOBILIJAIEK)
		{
			throw new InvalidOperationException(KFKMEPMEBND + " not initialised");
		}
		AJLDFGNHDCA.OONDALLFPOP(AIFKJBMJOMK, ELICNEDIBGB, 8, "input buffer too short");
		AJLDFGNHDCA.KLPNFGNKNKB(NGAGMIIBGKA, EMAKNGBIFDC, 8, "output buffer too short");
		return (!FPNNDLKJION) ? BJOOOKJMPLL(AIFKJBMJOMK, ELICNEDIBGB, NGAGMIIBGKA, EMAKNGBIFDC) : PGBGJCGKNCC(AIFKJBMJOMK, ELICNEDIBGB, NGAGMIIBGKA, EMAKNGBIFDC);
	}

	public virtual void OMOKOKFNBKI()
	{
	}

	private void LHCPMMKLJGA(byte[] IKNCPEPOKGJ)
	{
		int num;
		int num2 = (num = 0);
		while (num2 < 4)
		{
			PCIJPEKJHMB[num2] = PGOKFBKEOAB.EFODDMAJNOA(IKNCPEPOKGJ, num);
			num2++;
			num += 4;
		}
		for (num2 = (num = 0); num2 < 32; num2++)
		{
			ECONGBACNKE[num2] = (uint)num + PCIJPEKJHMB[num & 3];
			num += -1640531527;
			DEGEPCPMKGJ[num2] = (uint)num + PCIJPEKJHMB[(num >> 11) & 3];
		}
	}

	private int PGBGJCGKNCC(byte[] AIFKJBMJOMK, int ELICNEDIBGB, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		uint num = PGOKFBKEOAB.EFODDMAJNOA(AIFKJBMJOMK, ELICNEDIBGB);
		uint num2 = PGOKFBKEOAB.EFODDMAJNOA(AIFKJBMJOMK, ELICNEDIBGB + 4);
		for (int i = 0; i < 32; i++)
		{
			num += (((num2 << 4) ^ (num2 >> 5)) + num2) ^ ECONGBACNKE[i];
			num2 += (((num << 4) ^ (num >> 5)) + num) ^ DEGEPCPMKGJ[i];
		}
		PGOKFBKEOAB.MPMAFPANDLC(num, NGAGMIIBGKA, EMAKNGBIFDC);
		PGOKFBKEOAB.MPMAFPANDLC(num2, NGAGMIIBGKA, EMAKNGBIFDC + 4);
		return 8;
	}

	private int BJOOOKJMPLL(byte[] AIFKJBMJOMK, int ELICNEDIBGB, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		uint num = PGOKFBKEOAB.EFODDMAJNOA(AIFKJBMJOMK, ELICNEDIBGB);
		uint num2 = PGOKFBKEOAB.EFODDMAJNOA(AIFKJBMJOMK, ELICNEDIBGB + 4);
		for (int num3 = 31; num3 >= 0; num3--)
		{
			num2 -= (((num << 4) ^ (num >> 5)) + num) ^ DEGEPCPMKGJ[num3];
			num -= (((num2 << 4) ^ (num2 >> 5)) + num2) ^ ECONGBACNKE[num3];
		}
		PGOKFBKEOAB.MPMAFPANDLC(num, NGAGMIIBGKA, EMAKNGBIFDC);
		PGOKFBKEOAB.MPMAFPANDLC(num2, NGAGMIIBGKA, EMAKNGBIFDC + 4);
		return 8;
	}
}
