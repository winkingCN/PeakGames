using System;

public class IDOLDNHEEMB : JMPFLJGHAIM
{
	private const int DFKIEEIDJNM = 32;

	private const int NOCNBNLBJMN = 8;

	private const uint IEDLOAAAKAJ = 2654435769u;

	private const uint NGBCGAEBCIJ = 3337565984u;

	private uint ACDCFHFGFFN;

	private uint ABDIKAKJACK;

	private uint NBPPEHBAKOC;

	private uint IFABBNKJNHJ;

	private bool MOBILIJAIEK;

	private bool FPNNDLKJION;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return "TEA";
		}
	}

	public virtual bool ABNLKPDCGEF
	{
		get
		{
			return false;
		}
	}

	public IDOLDNHEEMB()
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
		ACDCFHFGFFN = PGOKFBKEOAB.EFODDMAJNOA(IKNCPEPOKGJ, 0);
		ABDIKAKJACK = PGOKFBKEOAB.EFODDMAJNOA(IKNCPEPOKGJ, 4);
		NBPPEHBAKOC = PGOKFBKEOAB.EFODDMAJNOA(IKNCPEPOKGJ, 8);
		IFABBNKJNHJ = PGOKFBKEOAB.EFODDMAJNOA(IKNCPEPOKGJ, 12);
	}

	private int PGBGJCGKNCC(byte[] AIFKJBMJOMK, int ELICNEDIBGB, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		uint num = PGOKFBKEOAB.EFODDMAJNOA(AIFKJBMJOMK, ELICNEDIBGB);
		uint num2 = PGOKFBKEOAB.EFODDMAJNOA(AIFKJBMJOMK, ELICNEDIBGB + 4);
		uint num3 = 0u;
		for (int i = 0; i != 32; i++)
		{
			num3 += 2654435769u;
			num += ((num2 << 4) + ACDCFHFGFFN) ^ (num2 + num3) ^ ((num2 >> 5) + ABDIKAKJACK);
			num2 += ((num << 4) + NBPPEHBAKOC) ^ (num + num3) ^ ((num >> 5) + IFABBNKJNHJ);
		}
		PGOKFBKEOAB.MPMAFPANDLC(num, NGAGMIIBGKA, EMAKNGBIFDC);
		PGOKFBKEOAB.MPMAFPANDLC(num2, NGAGMIIBGKA, EMAKNGBIFDC + 4);
		return 8;
	}

	private int BJOOOKJMPLL(byte[] AIFKJBMJOMK, int ELICNEDIBGB, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		uint num = PGOKFBKEOAB.EFODDMAJNOA(AIFKJBMJOMK, ELICNEDIBGB);
		uint num2 = PGOKFBKEOAB.EFODDMAJNOA(AIFKJBMJOMK, ELICNEDIBGB + 4);
		uint num3 = 3337565984u;
		for (int i = 0; i != 32; i++)
		{
			num2 -= ((num << 4) + NBPPEHBAKOC) ^ (num + num3) ^ ((num >> 5) + IFABBNKJNHJ);
			num -= ((num2 << 4) + ACDCFHFGFFN) ^ (num2 + num3) ^ ((num2 >> 5) + ABDIKAKJACK);
			num3 -= 2654435769u;
		}
		PGOKFBKEOAB.MPMAFPANDLC(num, NGAGMIIBGKA, EMAKNGBIFDC);
		PGOKFBKEOAB.MPMAFPANDLC(num2, NGAGMIIBGKA, EMAKNGBIFDC + 4);
		return 8;
	}
}
