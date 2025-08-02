using System;
using Org.BouncyCastle.Crypto;

public class NDIFOGFDKLL : KPMKFMEEJCJ
{
	public static readonly int CFHOCIMHNPH = 20;

	private const int EAJOPDGPMEO = 16;

	private static readonly uint[] JAOEHEGBIBL = PGOKFBKEOAB.LAJPMLKCDOH(CCGLOIJJMKC.IFHLAPJLHNG("expand 16-byte kexpand 32-byte k"), 0, 8);

	[Obsolete]
	protected static readonly byte[] KLAFDEEEHGG = CCGLOIJJMKC.IFHLAPJLHNG("expand 32-byte k");

	[Obsolete]
	protected static readonly byte[] LIKFPJNJAFB = CCGLOIJJMKC.IFHLAPJLHNG("expand 16-byte k");

	protected int DFKIEEIDJNM;

	private int EHJNMODJEAN;

	internal uint[] EMECPLDAING = new uint[16];

	internal uint[] AMFCENFNAJJ = new uint[16];

	private byte[] CBBDDDBHKIJ = new byte[64];

	private bool HJBGFGMEOOD;

	private uint NNHJILDDPMG;

	private uint CMCMKNHBBEK;

	private uint KKKIMAGKJMN;

	protected virtual int BMPJMJODKPP
	{
		get
		{
			return 8;
		}
	}

	public virtual string KFKMEPMEBND
	{
		get
		{
			string text = "Salsa20";
			if (DFKIEEIDJNM != CFHOCIMHNPH)
			{
				text = text + "/" + DFKIEEIDJNM;
			}
			return text;
		}
	}

	public NDIFOGFDKLL()
		: this(CFHOCIMHNPH)
	{
	}

	public NDIFOGFDKLL(int DFKIEEIDJNM)
	{
		if (DFKIEEIDJNM <= 0 || ((uint)DFKIEEIDJNM & (true ? 1u : 0u)) != 0)
		{
			throw new ArgumentException("'rounds' must be a positive, even number");
		}
		this.DFKIEEIDJNM = DFKIEEIDJNM;
	}

	internal void HIMDNDGCMAP(int HOCKJHFODGN, uint[] BGEDKGLJIGM, int DLONNKMFKOC)
	{
		int num = (HOCKJHFODGN - 16) / 4;
		BGEDKGLJIGM[DLONNKMFKOC] = JAOEHEGBIBL[num];
		BGEDKGLJIGM[DLONNKMFKOC + 1] = JAOEHEGBIBL[num + 1];
		BGEDKGLJIGM[DLONNKMFKOC + 2] = JAOEHEGBIBL[num + 2];
		BGEDKGLJIGM[DLONNKMFKOC + 3] = JAOEHEGBIBL[num + 3];
	}

	public virtual void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		CHCELGDKEJG cHCELGDKEJG = IJJHBEECMBP as CHCELGDKEJG;
		if (cHCELGDKEJG == null)
		{
			throw new ArgumentException(KFKMEPMEBND + " Init requires an IV", "parameters");
		}
		byte[] array = cHCELGDKEJG.OLAEDCABKDH();
		if (array == null || array.Length != BMPJMJODKPP)
		{
			throw new ArgumentException(KFKMEPMEBND + " requires exactly " + BMPJMJODKPP + " bytes of IV");
		}
		IGMAJHKIIPK iGMAJHKIIPK = cHCELGDKEJG.KPJHHAAOFOH;
		if (iGMAJHKIIPK == null)
		{
			if (!HJBGFGMEOOD)
			{
				throw new InvalidOperationException(KFKMEPMEBND + " KeyParameter can not be null for first initialisation");
			}
			KBEFMBDOIJH(null, array);
		}
		else
		{
			if (!(iGMAJHKIIPK is JEMNCGMEABF))
			{
				throw new ArgumentException(KFKMEPMEBND + " Init parameters must contain a KeyParameter (or null for re-init)");
			}
			KBEFMBDOIJH(((JEMNCGMEABF)iGMAJHKIIPK).MEGBFHFMBFI(), array);
		}
		OMOKOKFNBKI();
		HJBGFGMEOOD = true;
	}

	public virtual byte IODEANDNHIP(byte MOPCLEEGDFB)
	{
		if (LEJJOPIHPKA())
		{
			throw new MaxBytesExceededException("2^70 byte limit per IV; Change IV");
		}
		if (EHJNMODJEAN == 0)
		{
			EJPOGNHMIMH(CBBDDDBHKIJ);
			PFOIANPLIKG();
		}
		byte result = (byte)(CBBDDDBHKIJ[EHJNMODJEAN] ^ MOPCLEEGDFB);
		EHJNMODJEAN = (EHJNMODJEAN + 1) & 0x3F;
		return result;
	}

	protected virtual void PFOIANPLIKG()
	{
		if (++EMECPLDAING[8] == 0)
		{
			EMECPLDAING[9]++;
		}
	}

	public virtual void POCAGALIPAI(byte[] AIFKJBMJOMK, int ELICNEDIBGB, int NBEDPKHALCN, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		if (!HJBGFGMEOOD)
		{
			throw new InvalidOperationException(KFKMEPMEBND + " not initialised");
		}
		AJLDFGNHDCA.OONDALLFPOP(AIFKJBMJOMK, ELICNEDIBGB, NBEDPKHALCN, "input buffer too short");
		AJLDFGNHDCA.KLPNFGNKNKB(NGAGMIIBGKA, EMAKNGBIFDC, NBEDPKHALCN, "output buffer too short");
		if (LEJJOPIHPKA((uint)NBEDPKHALCN))
		{
			throw new MaxBytesExceededException("2^70 byte limit per IV would be exceeded; Change IV");
		}
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			if (EHJNMODJEAN == 0)
			{
				EJPOGNHMIMH(CBBDDDBHKIJ);
				PFOIANPLIKG();
			}
			NGAGMIIBGKA[i + EMAKNGBIFDC] = (byte)(CBBDDDBHKIJ[EHJNMODJEAN] ^ AIFKJBMJOMK[i + ELICNEDIBGB]);
			EHJNMODJEAN = (EHJNMODJEAN + 1) & 0x3F;
		}
	}

	public virtual void OMOKOKFNBKI()
	{
		EHJNMODJEAN = 0;
		HNHEGLICGIK();
		IFCPCMANPPN();
	}

	protected virtual void IFCPCMANPPN()
	{
		EMECPLDAING[8] = (EMECPLDAING[9] = 0u);
	}

	protected virtual void KBEFMBDOIJH(byte[] EGJBACEEHAK, byte[] MIMCBAKIPJC)
	{
		if (EGJBACEEHAK != null)
		{
			if (EGJBACEEHAK.Length != 16 && EGJBACEEHAK.Length != 32)
			{
				throw new ArgumentException(KFKMEPMEBND + " requires 128 bit or 256 bit key");
			}
			int num = (EGJBACEEHAK.Length - 16) / 4;
			EMECPLDAING[0] = JAOEHEGBIBL[num];
			EMECPLDAING[5] = JAOEHEGBIBL[num + 1];
			EMECPLDAING[10] = JAOEHEGBIBL[num + 2];
			EMECPLDAING[15] = JAOEHEGBIBL[num + 3];
			PGOKFBKEOAB.LAJPMLKCDOH(EGJBACEEHAK, 0, EMECPLDAING, 1, 4);
			PGOKFBKEOAB.LAJPMLKCDOH(EGJBACEEHAK, EGJBACEEHAK.Length - 16, EMECPLDAING, 11, 4);
		}
		PGOKFBKEOAB.LAJPMLKCDOH(MIMCBAKIPJC, 0, EMECPLDAING, 6, 2);
	}

	protected virtual void EJPOGNHMIMH(byte[] BILGCJNPJGJ)
	{
		EOJHBHOGCKF(DFKIEEIDJNM, EMECPLDAING, AMFCENFNAJJ);
		PGOKFBKEOAB.LGJFKMLLKLN(AMFCENFNAJJ, BILGCJNPJGJ, 0);
	}

	internal static void EOJHBHOGCKF(int DFKIEEIDJNM, uint[] MOPCLEEGDFB, uint[] AMFCENFNAJJ)
	{
		if (MOPCLEEGDFB.Length != 16)
		{
			throw new ArgumentException();
		}
		if (AMFCENFNAJJ.Length != 16)
		{
			throw new ArgumentException();
		}
		if (DFKIEEIDJNM % 2 != 0)
		{
			throw new ArgumentException("Number of rounds must be even");
		}
		uint num = MOPCLEEGDFB[0];
		uint num2 = MOPCLEEGDFB[1];
		uint num3 = MOPCLEEGDFB[2];
		uint num4 = MOPCLEEGDFB[3];
		uint num5 = MOPCLEEGDFB[4];
		uint num6 = MOPCLEEGDFB[5];
		uint num7 = MOPCLEEGDFB[6];
		uint num8 = MOPCLEEGDFB[7];
		uint num9 = MOPCLEEGDFB[8];
		uint num10 = MOPCLEEGDFB[9];
		uint num11 = MOPCLEEGDFB[10];
		uint num12 = MOPCLEEGDFB[11];
		uint num13 = MOPCLEEGDFB[12];
		uint num14 = MOPCLEEGDFB[13];
		uint num15 = MOPCLEEGDFB[14];
		uint num16 = MOPCLEEGDFB[15];
		for (int num17 = DFKIEEIDJNM; num17 > 0; num17 -= 2)
		{
			num5 ^= GOEFJMNOBHA(num + num13, 7);
			num9 ^= GOEFJMNOBHA(num5 + num, 9);
			num13 ^= GOEFJMNOBHA(num9 + num5, 13);
			num ^= GOEFJMNOBHA(num13 + num9, 18);
			num10 ^= GOEFJMNOBHA(num6 + num2, 7);
			num14 ^= GOEFJMNOBHA(num10 + num6, 9);
			num2 ^= GOEFJMNOBHA(num14 + num10, 13);
			num6 ^= GOEFJMNOBHA(num2 + num14, 18);
			num15 ^= GOEFJMNOBHA(num11 + num7, 7);
			num3 ^= GOEFJMNOBHA(num15 + num11, 9);
			num7 ^= GOEFJMNOBHA(num3 + num15, 13);
			num11 ^= GOEFJMNOBHA(num7 + num3, 18);
			num4 ^= GOEFJMNOBHA(num16 + num12, 7);
			num8 ^= GOEFJMNOBHA(num4 + num16, 9);
			num12 ^= GOEFJMNOBHA(num8 + num4, 13);
			num16 ^= GOEFJMNOBHA(num12 + num8, 18);
			num2 ^= GOEFJMNOBHA(num + num4, 7);
			num3 ^= GOEFJMNOBHA(num2 + num, 9);
			num4 ^= GOEFJMNOBHA(num3 + num2, 13);
			num ^= GOEFJMNOBHA(num4 + num3, 18);
			num7 ^= GOEFJMNOBHA(num6 + num5, 7);
			num8 ^= GOEFJMNOBHA(num7 + num6, 9);
			num5 ^= GOEFJMNOBHA(num8 + num7, 13);
			num6 ^= GOEFJMNOBHA(num5 + num8, 18);
			num12 ^= GOEFJMNOBHA(num11 + num10, 7);
			num9 ^= GOEFJMNOBHA(num12 + num11, 9);
			num10 ^= GOEFJMNOBHA(num9 + num12, 13);
			num11 ^= GOEFJMNOBHA(num10 + num9, 18);
			num13 ^= GOEFJMNOBHA(num16 + num15, 7);
			num14 ^= GOEFJMNOBHA(num13 + num16, 9);
			num15 ^= GOEFJMNOBHA(num14 + num13, 13);
			num16 ^= GOEFJMNOBHA(num15 + num14, 18);
		}
		AMFCENFNAJJ[0] = num + MOPCLEEGDFB[0];
		AMFCENFNAJJ[1] = num2 + MOPCLEEGDFB[1];
		AMFCENFNAJJ[2] = num3 + MOPCLEEGDFB[2];
		AMFCENFNAJJ[3] = num4 + MOPCLEEGDFB[3];
		AMFCENFNAJJ[4] = num5 + MOPCLEEGDFB[4];
		AMFCENFNAJJ[5] = num6 + MOPCLEEGDFB[5];
		AMFCENFNAJJ[6] = num7 + MOPCLEEGDFB[6];
		AMFCENFNAJJ[7] = num8 + MOPCLEEGDFB[7];
		AMFCENFNAJJ[8] = num9 + MOPCLEEGDFB[8];
		AMFCENFNAJJ[9] = num10 + MOPCLEEGDFB[9];
		AMFCENFNAJJ[10] = num11 + MOPCLEEGDFB[10];
		AMFCENFNAJJ[11] = num12 + MOPCLEEGDFB[11];
		AMFCENFNAJJ[12] = num13 + MOPCLEEGDFB[12];
		AMFCENFNAJJ[13] = num14 + MOPCLEEGDFB[13];
		AMFCENFNAJJ[14] = num15 + MOPCLEEGDFB[14];
		AMFCENFNAJJ[15] = num16 + MOPCLEEGDFB[15];
	}

	internal static uint GOEFJMNOBHA(uint AMFCENFNAJJ, int CNLILOEEBOJ)
	{
		return (AMFCENFNAJJ << CNLILOEEBOJ) | (AMFCENFNAJJ >> 32 - CNLILOEEBOJ);
	}

	private void HNHEGLICGIK()
	{
		NNHJILDDPMG = 0u;
		CMCMKNHBBEK = 0u;
		KKKIMAGKJMN = 0u;
	}

	private bool LEJJOPIHPKA()
	{
		if (++NNHJILDDPMG == 0 && ++CMCMKNHBBEK == 0)
		{
			return (++KKKIMAGKJMN & 0x20) != 0;
		}
		return false;
	}

	private bool LEJJOPIHPKA(uint NBEDPKHALCN)
	{
		uint nNHJILDDPMG = NNHJILDDPMG;
		NNHJILDDPMG += NBEDPKHALCN;
		if (NNHJILDDPMG < nNHJILDDPMG && ++CMCMKNHBBEK == 0)
		{
			return (++KKKIMAGKJMN & 0x20) != 0;
		}
		return false;
	}
}
