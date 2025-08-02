using System;

public class FHMGJEBDMAG : BJLAMONNNDD, MIPBJNJHNGA
{
	private const int FOLLOKAMFEJ = 32;

	private byte[] JGOHMOHEFMJ = new byte[32];

	private byte[] NBFDOJDLKOG = new byte[32];

	private byte[] IGBPKOOBCMA = new byte[32];

	private byte[] LIMGHFNPACK = new byte[32];

	private byte[][] ANGINAGELKI = IPDDNMKPLHH();

	private byte[] LNELIAIKLBD = new byte[32];

	private int KBDJMHLAHLE;

	private ulong NAAHEJKGFAA;

	private readonly JMPFLJGHAIM IEDPBFAFGGJ = new NIAFGAPALCG();

	private byte[] GFKMKGFENOL;

	private byte[] ECPHBOJJFKH = new byte[32];

	private byte[] MNIMEAMHNMI = new byte[8];

	internal short[] PCNAFGJAOEA = new short[16];

	internal short[] JIKHLNIBOKC = new short[16];

	internal byte[] PCPPGMNCBJG = new byte[32];

	internal byte[] PJLDNECDIEI = new byte[32];

	internal byte[] GOCFBLLGPIL = new byte[32];

	internal byte[] NEIMKFNNNOB = new byte[32];

	private static readonly byte[] PLJEFFLCHFO = new byte[32]
	{
		0, 255, 0, 255, 0, 255, 0, 255, 255, 0,
		255, 0, 255, 0, 255, 0, 0, 255, 255, 0,
		255, 0, 0, 255, 255, 0, 0, 0, 255, 255,
		0, 255
	};

	public string KFKMEPMEBND
	{
		get
		{
			return "Gost3411";
		}
	}

	public FHMGJEBDMAG()
	{
		GFKMKGFENOL = NIAFGAPALCG.JCBMNCIEKKG("D-A");
		IEDPBFAFGGJ.DIOELAHNLKJ(true, new KPIGIPHDHAF(null, GFKMKGFENOL));
		OMOKOKFNBKI();
	}

	public FHMGJEBDMAG(byte[] PALHMMMIKDF)
	{
		GFKMKGFENOL = NOGCEBKPPJE.IKBFGGABMKP(PALHMMMIKDF);
		IEDPBFAFGGJ.DIOELAHNLKJ(true, new KPIGIPHDHAF(null, GFKMKGFENOL));
		OMOKOKFNBKI();
	}

	public FHMGJEBDMAG(FHMGJEBDMAG LLIEHCKNJEM)
	{
		OMOKOKFNBKI(LLIEHCKNJEM);
	}

	private static byte[][] IPDDNMKPLHH()
	{
		byte[][] array = new byte[4][];
		for (int i = 0; i < 4; i++)
		{
			array[i] = new byte[32];
		}
		return array;
	}

	public int EEMLLAMENHO()
	{
		return 32;
	}

	public void BPAJGOINFNL(byte MOPCLEEGDFB)
	{
		LNELIAIKLBD[KBDJMHLAHLE++] = MOPCLEEGDFB;
		if (KBDJMHLAHLE == LNELIAIKLBD.Length)
		{
			EHLDAAEKHMC(LNELIAIKLBD);
			PLBMMDHPFLI(LNELIAIKLBD, 0);
			KBDJMHLAHLE = 0;
		}
		NAAHEJKGFAA++;
	}

	public void GONEEEFEDGF(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP)
	{
		while (KBDJMHLAHLE != 0 && EOFAGACBNFP > 0)
		{
			BPAJGOINFNL(MOPCLEEGDFB[ELICNEDIBGB]);
			ELICNEDIBGB++;
			EOFAGACBNFP--;
		}
		while (EOFAGACBNFP > LNELIAIKLBD.Length)
		{
			Array.Copy(MOPCLEEGDFB, ELICNEDIBGB, LNELIAIKLBD, 0, LNELIAIKLBD.Length);
			EHLDAAEKHMC(LNELIAIKLBD);
			PLBMMDHPFLI(LNELIAIKLBD, 0);
			ELICNEDIBGB += LNELIAIKLBD.Length;
			EOFAGACBNFP -= LNELIAIKLBD.Length;
			NAAHEJKGFAA += (uint)LNELIAIKLBD.Length;
		}
		while (EOFAGACBNFP > 0)
		{
			BPAJGOINFNL(MOPCLEEGDFB[ELICNEDIBGB]);
			ELICNEDIBGB++;
			EOFAGACBNFP--;
		}
	}

	private byte[] MBIJHANOCOC(byte[] MOPCLEEGDFB)
	{
		int num = 0;
		for (int i = 0; i < 8; i++)
		{
			ECPHBOJJFKH[num++] = MOPCLEEGDFB[i];
			ECPHBOJJFKH[num++] = MOPCLEEGDFB[8 + i];
			ECPHBOJJFKH[num++] = MOPCLEEGDFB[16 + i];
			ECPHBOJJFKH[num++] = MOPCLEEGDFB[24 + i];
		}
		return ECPHBOJJFKH;
	}

	private byte[] JEHECJGFJEB(byte[] MOPCLEEGDFB)
	{
		for (int i = 0; i < 8; i++)
		{
			MNIMEAMHNMI[i] = (byte)(MOPCLEEGDFB[i] ^ MOPCLEEGDFB[i + 8]);
		}
		Array.Copy(MOPCLEEGDFB, 8, MOPCLEEGDFB, 0, 24);
		Array.Copy(MNIMEAMHNMI, 0, MOPCLEEGDFB, 24, 8);
		return MOPCLEEGDFB;
	}

	private void JNEGBIAFNHK(byte[] IKNCPEPOKGJ, byte[] IBBBMACIBGK, int LBBIOCCGDBO, byte[] MOPCLEEGDFB, int ELICNEDIBGB)
	{
		IEDPBFAFGGJ.DIOELAHNLKJ(true, new JEMNCGMEABF(IKNCPEPOKGJ));
		IEDPBFAFGGJ.DPACJDFHLKB(MOPCLEEGDFB, ELICNEDIBGB, IBBBMACIBGK, LBBIOCCGDBO);
	}

	private void OMBDABFPLPE(byte[] MOPCLEEGDFB)
	{
		LGOOOJJGBHD(MOPCLEEGDFB, PCNAFGJAOEA);
		JIKHLNIBOKC[15] = (short)(PCNAFGJAOEA[0] ^ PCNAFGJAOEA[1] ^ PCNAFGJAOEA[2] ^ PCNAFGJAOEA[3] ^ PCNAFGJAOEA[12] ^ PCNAFGJAOEA[15]);
		Array.Copy(PCNAFGJAOEA, 1, JIKHLNIBOKC, 0, 15);
		CMDKLINGDKI(JIKHLNIBOKC, MOPCLEEGDFB);
	}

	private void PLBMMDHPFLI(byte[] MOPCLEEGDFB, int ELICNEDIBGB)
	{
		Array.Copy(MOPCLEEGDFB, ELICNEDIBGB, IGBPKOOBCMA, 0, 32);
		JGOHMOHEFMJ.CopyTo(PJLDNECDIEI, 0);
		IGBPKOOBCMA.CopyTo(GOCFBLLGPIL, 0);
		for (int i = 0; i < 32; i++)
		{
			NEIMKFNNNOB[i] = (byte)(PJLDNECDIEI[i] ^ GOCFBLLGPIL[i]);
		}
		JNEGBIAFNHK(MBIJHANOCOC(NEIMKFNNNOB), PCPPGMNCBJG, 0, JGOHMOHEFMJ, 0);
		for (int j = 1; j < 4; j++)
		{
			byte[] array = JEHECJGFJEB(PJLDNECDIEI);
			for (int k = 0; k < 32; k++)
			{
				PJLDNECDIEI[k] = (byte)(array[k] ^ ANGINAGELKI[j][k]);
			}
			GOCFBLLGPIL = JEHECJGFJEB(JEHECJGFJEB(GOCFBLLGPIL));
			for (int l = 0; l < 32; l++)
			{
				NEIMKFNNNOB[l] = (byte)(PJLDNECDIEI[l] ^ GOCFBLLGPIL[l]);
			}
			JNEGBIAFNHK(MBIJHANOCOC(NEIMKFNNNOB), PCPPGMNCBJG, j * 8, JGOHMOHEFMJ, j * 8);
		}
		for (int m = 0; m < 12; m++)
		{
			OMBDABFPLPE(PCPPGMNCBJG);
		}
		for (int n = 0; n < 32; n++)
		{
			PCPPGMNCBJG[n] ^= IGBPKOOBCMA[n];
		}
		OMBDABFPLPE(PCPPGMNCBJG);
		for (int num = 0; num < 32; num++)
		{
			PCPPGMNCBJG[num] = (byte)(JGOHMOHEFMJ[num] ^ PCPPGMNCBJG[num]);
		}
		for (int num2 = 0; num2 < 61; num2++)
		{
			OMBDABFPLPE(PCPPGMNCBJG);
		}
		Array.Copy(PCPPGMNCBJG, 0, JGOHMOHEFMJ, 0, JGOHMOHEFMJ.Length);
	}

	private void JGJKCJOJLDG()
	{
		ulong iDHLPOFDLKJ = NAAHEJKGFAA * 8;
		PGOKFBKEOAB.ICLMPOAFJKJ(iDHLPOFDLKJ, NBFDOJDLKOG);
		while (KBDJMHLAHLE != 0)
		{
			BPAJGOINFNL(0);
		}
		PLBMMDHPFLI(NBFDOJDLKOG, 0);
		PLBMMDHPFLI(LIMGHFNPACK, 0);
	}

	public int LCNOFBMOHHM(byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		JGJKCJOJLDG();
		JGOHMOHEFMJ.CopyTo(BILGCJNPJGJ, EMAKNGBIFDC);
		OMOKOKFNBKI();
		return 32;
	}

	public void OMOKOKFNBKI()
	{
		NAAHEJKGFAA = 0uL;
		KBDJMHLAHLE = 0;
		Array.Clear(JGOHMOHEFMJ, 0, JGOHMOHEFMJ.Length);
		Array.Clear(NBFDOJDLKOG, 0, NBFDOJDLKOG.Length);
		Array.Clear(IGBPKOOBCMA, 0, IGBPKOOBCMA.Length);
		Array.Clear(ANGINAGELKI[1], 0, ANGINAGELKI[1].Length);
		Array.Clear(ANGINAGELKI[3], 0, ANGINAGELKI[3].Length);
		Array.Clear(LIMGHFNPACK, 0, LIMGHFNPACK.Length);
		Array.Clear(LNELIAIKLBD, 0, LNELIAIKLBD.Length);
		PLJEFFLCHFO.CopyTo(ANGINAGELKI[2], 0);
	}

	private void EHLDAAEKHMC(byte[] MOPCLEEGDFB)
	{
		int num = 0;
		for (int i = 0; i != LIMGHFNPACK.Length; i++)
		{
			int num2 = (LIMGHFNPACK[i] & 0xFF) + (MOPCLEEGDFB[i] & 0xFF) + num;
			LIMGHFNPACK[i] = (byte)num2;
			num = num2 >> 8;
		}
	}

	private static void LGOOOJJGBHD(byte[] PCPPGMNCBJG, short[] PCNAFGJAOEA)
	{
		for (int i = 0; i < PCPPGMNCBJG.Length / 2; i++)
		{
			PCNAFGJAOEA[i] = (short)(((PCPPGMNCBJG[i * 2 + 1] << 8) & 0xFF00) | (PCPPGMNCBJG[i * 2] & 0xFF));
		}
	}

	private static void CMDKLINGDKI(short[] PCNAFGJAOEA, byte[] PCPPGMNCBJG)
	{
		for (int i = 0; i < PCPPGMNCBJG.Length / 2; i++)
		{
			PCPPGMNCBJG[i * 2 + 1] = (byte)(PCNAFGJAOEA[i] >> 8);
			PCPPGMNCBJG[i * 2] = (byte)PCNAFGJAOEA[i];
		}
	}

	public int MNAIJEEKPCP()
	{
		return 32;
	}

	public MIPBJNJHNGA FDCFKGAEJFF()
	{
		return new FHMGJEBDMAG(this);
	}

	public void OMOKOKFNBKI(MIPBJNJHNGA CJHEIBNHNNE)
	{
		FHMGJEBDMAG fHMGJEBDMAG = (FHMGJEBDMAG)CJHEIBNHNNE;
		GFKMKGFENOL = fHMGJEBDMAG.GFKMKGFENOL;
		IEDPBFAFGGJ.DIOELAHNLKJ(true, new KPIGIPHDHAF(null, GFKMKGFENOL));
		OMOKOKFNBKI();
		Array.Copy(fHMGJEBDMAG.JGOHMOHEFMJ, 0, JGOHMOHEFMJ, 0, fHMGJEBDMAG.JGOHMOHEFMJ.Length);
		Array.Copy(fHMGJEBDMAG.NBFDOJDLKOG, 0, NBFDOJDLKOG, 0, fHMGJEBDMAG.NBFDOJDLKOG.Length);
		Array.Copy(fHMGJEBDMAG.IGBPKOOBCMA, 0, IGBPKOOBCMA, 0, fHMGJEBDMAG.IGBPKOOBCMA.Length);
		Array.Copy(fHMGJEBDMAG.LIMGHFNPACK, 0, LIMGHFNPACK, 0, fHMGJEBDMAG.LIMGHFNPACK.Length);
		Array.Copy(fHMGJEBDMAG.ANGINAGELKI[1], 0, ANGINAGELKI[1], 0, fHMGJEBDMAG.ANGINAGELKI[1].Length);
		Array.Copy(fHMGJEBDMAG.ANGINAGELKI[2], 0, ANGINAGELKI[2], 0, fHMGJEBDMAG.ANGINAGELKI[2].Length);
		Array.Copy(fHMGJEBDMAG.ANGINAGELKI[3], 0, ANGINAGELKI[3], 0, fHMGJEBDMAG.ANGINAGELKI[3].Length);
		Array.Copy(fHMGJEBDMAG.LNELIAIKLBD, 0, LNELIAIKLBD, 0, fHMGJEBDMAG.LNELIAIKLBD.Length);
		KBDJMHLAHLE = fHMGJEBDMAG.KBDJMHLAHLE;
		NAAHEJKGFAA = fHMGJEBDMAG.NAAHEJKGFAA;
	}
}
