using System;

public class PPHLCNGICDP : BJLAMONNNDD, MIPBJNJHNGA
{
	private static readonly ulong[] DLCFGHFNHMO = DPEPCCJIKHJ();

	private static readonly int[] CKOHHLGAJFK = ICAGELABION();

	protected byte[] BGEDKGLJIGM = new byte[200];

	protected byte[] OCHLDCMIEHD = new byte[192];

	protected int HICEHGBGNJF;

	protected int DKFKFEKOHOJ;

	protected int GHDKCGGHACP;

	protected bool FIHFLDGIADB;

	protected int AELCFGBEBPP;

	protected byte[] LOEFHIFMLJP;

	protected byte[] CNLGMLEAJJN;

	private ulong[] ANGINAGELKI = new ulong[5];

	private ulong[] LFKPLEJFEHC = new ulong[25];

	private ulong[] LKPEDDMLOJA = new ulong[5];

	public virtual string KFKMEPMEBND
	{
		get
		{
			return "Keccak-" + GHDKCGGHACP;
		}
	}

	public PPHLCNGICDP()
		: this(288)
	{
	}

	public PPHLCNGICDP(int EAJFCEBGGIG)
	{
		DIOELAHNLKJ(EAJFCEBGGIG);
	}

	public PPHLCNGICDP(PPHLCNGICDP JKHLMLIANAI)
	{
		AKBPCECABIO(JKHLMLIANAI);
	}

	private static ulong[] DPEPCCJIKHJ()
	{
		ulong[] array = new ulong[24];
		byte b = 1;
		for (int i = 0; i < 24; i++)
		{
			array[i] = 0uL;
			for (int j = 0; j < 7; j++)
			{
				int num = (1 << j) - 1;
				if (((uint)b & (true ? 1u : 0u)) != 0)
				{
					array[i] ^= (ulong)(1L << num);
				}
				bool flag = (b & 0x80) != 0;
				b <<= 1;
				if (flag)
				{
					b = (byte)(b ^ 0x71u);
				}
			}
		}
		return array;
	}

	private static int[] ICAGELABION()
	{
		int[] array = new int[25];
		int num = (array[0] = 0);
		int num2 = 1;
		int num3 = 0;
		for (int i = 1; i < 25; i++)
		{
			num = (num + i) & 0x3F;
			array[num2 % 5 + 5 * (num3 % 5)] = num;
			int num4 = (0 * num2 + num3) % 5;
			int num5 = (2 * num2 + 3 * num3) % 5;
			num2 = num4;
			num3 = num5;
		}
		return array;
	}

	private void OHGPOCPLHEK(int JBAJPGIAPFF, int NBEDPKHALCN)
	{
		for (int i = JBAJPGIAPFF; i != JBAJPGIAPFF + NBEDPKHALCN; i++)
		{
			OCHLDCMIEHD[i] = 0;
		}
	}

	private void AKBPCECABIO(PPHLCNGICDP JKHLMLIANAI)
	{
		Array.Copy(JKHLMLIANAI.BGEDKGLJIGM, 0, BGEDKGLJIGM, 0, JKHLMLIANAI.BGEDKGLJIGM.Length);
		Array.Copy(JKHLMLIANAI.OCHLDCMIEHD, 0, OCHLDCMIEHD, 0, JKHLMLIANAI.OCHLDCMIEHD.Length);
		HICEHGBGNJF = JKHLMLIANAI.HICEHGBGNJF;
		DKFKFEKOHOJ = JKHLMLIANAI.DKFKFEKOHOJ;
		GHDKCGGHACP = JKHLMLIANAI.GHDKCGGHACP;
		FIHFLDGIADB = JKHLMLIANAI.FIHFLDGIADB;
		AELCFGBEBPP = JKHLMLIANAI.AELCFGBEBPP;
		LOEFHIFMLJP = NOGCEBKPPJE.IKBFGGABMKP(JKHLMLIANAI.LOEFHIFMLJP);
		CNLGMLEAJJN = NOGCEBKPPJE.IKBFGGABMKP(JKHLMLIANAI.CNLGMLEAJJN);
	}

	public virtual int EEMLLAMENHO()
	{
		return GHDKCGGHACP / 8;
	}

	public virtual void BPAJGOINFNL(byte MOPCLEEGDFB)
	{
		CNLGMLEAJJN[0] = MOPCLEEGDFB;
		EMBMFDGDCJG(CNLGMLEAJJN, 0, 8L);
	}

	public virtual void GONEEEFEDGF(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int NBEDPKHALCN)
	{
		EMBMFDGDCJG(MOPCLEEGDFB, ELICNEDIBGB, (long)NBEDPKHALCN * 8L);
	}

	public virtual int LCNOFBMOHHM(byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		IOBPJDNCOGD(BILGCJNPJGJ, EMAKNGBIFDC, GHDKCGGHACP);
		OMOKOKFNBKI();
		return EEMLLAMENHO();
	}

	protected virtual int LCNOFBMOHHM(byte[] BILGCJNPJGJ, int EMAKNGBIFDC, byte AHPFMEIDAGJ, int EMKPJGGIPPL)
	{
		if (EMKPJGGIPPL > 0)
		{
			CNLGMLEAJJN[0] = AHPFMEIDAGJ;
			EMBMFDGDCJG(CNLGMLEAJJN, 0, EMKPJGGIPPL);
		}
		IOBPJDNCOGD(BILGCJNPJGJ, EMAKNGBIFDC, GHDKCGGHACP);
		OMOKOKFNBKI();
		return EEMLLAMENHO();
	}

	public virtual void OMOKOKFNBKI()
	{
		DIOELAHNLKJ(GHDKCGGHACP);
	}

	public virtual int MNAIJEEKPCP()
	{
		return HICEHGBGNJF / 8;
	}

	private void DIOELAHNLKJ(int EAJFCEBGGIG)
	{
		switch (EAJFCEBGGIG)
		{
		case 128:
			CKCJCMPMPIL(1344, 256);
			break;
		case 224:
			CKCJCMPMPIL(1152, 448);
			break;
		case 256:
			CKCJCMPMPIL(1088, 512);
			break;
		case 288:
			CKCJCMPMPIL(1024, 576);
			break;
		case 384:
			CKCJCMPMPIL(832, 768);
			break;
		case 512:
			CKCJCMPMPIL(576, 1024);
			break;
		default:
			throw new ArgumentException("must be one of 128, 224, 256, 288, 384, or 512.", "bitLength");
		}
	}

	private void CKCJCMPMPIL(int HICEHGBGNJF, int MDPEMCMPAMB)
	{
		if (HICEHGBGNJF + MDPEMCMPAMB != 1600)
		{
			throw new InvalidOperationException("rate + capacity != 1600");
		}
		if (HICEHGBGNJF <= 0 || HICEHGBGNJF >= 1600 || HICEHGBGNJF % 64 != 0)
		{
			throw new InvalidOperationException("invalid rate value");
		}
		this.HICEHGBGNJF = HICEHGBGNJF;
		GHDKCGGHACP = 0;
		NOGCEBKPPJE.MEBLOMPDLEJ(BGEDKGLJIGM, 0);
		NOGCEBKPPJE.MEBLOMPDLEJ(OCHLDCMIEHD, 0);
		DKFKFEKOHOJ = 0;
		FIHFLDGIADB = false;
		AELCFGBEBPP = 0;
		GHDKCGGHACP = MDPEMCMPAMB / 2;
		LOEFHIFMLJP = new byte[HICEHGBGNJF / 8];
		CNLGMLEAJJN = new byte[1];
	}

	private void FEMKBHIJGPD()
	{
		ALJFDGGPHIG(BGEDKGLJIGM, OCHLDCMIEHD, HICEHGBGNJF / 8);
		DKFKFEKOHOJ = 0;
	}

	protected virtual void EMBMFDGDCJG(byte[] MBBPBGHKLJM, int JBAJPGIAPFF, long KOPMDCAOMMO)
	{
		if (DKFKFEKOHOJ % 8 != 0)
		{
			throw new InvalidOperationException("attempt to absorb with odd length queue");
		}
		if (FIHFLDGIADB)
		{
			throw new InvalidOperationException("attempt to absorb while squeezing");
		}
		long num = 0L;
		while (num < KOPMDCAOMMO)
		{
			if (DKFKFEKOHOJ == 0 && KOPMDCAOMMO >= HICEHGBGNJF && num <= KOPMDCAOMMO - HICEHGBGNJF)
			{
				long num2 = (KOPMDCAOMMO - num) / HICEHGBGNJF;
				for (long num3 = 0L; num3 < num2; num3++)
				{
					Array.Copy(MBBPBGHKLJM, (int)(JBAJPGIAPFF + num / 8 + num3 * LOEFHIFMLJP.Length), LOEFHIFMLJP, 0, LOEFHIFMLJP.Length);
					ALJFDGGPHIG(BGEDKGLJIGM, LOEFHIFMLJP, LOEFHIFMLJP.Length);
				}
				num += num2 * HICEHGBGNJF;
				continue;
			}
			int num4 = (int)(KOPMDCAOMMO - num);
			if (num4 + DKFKFEKOHOJ > HICEHGBGNJF)
			{
				num4 = HICEHGBGNJF - DKFKFEKOHOJ;
			}
			int num5 = num4 % 8;
			num4 -= num5;
			Array.Copy(MBBPBGHKLJM, JBAJPGIAPFF + (int)(num / 8), OCHLDCMIEHD, DKFKFEKOHOJ / 8, num4 / 8);
			DKFKFEKOHOJ += num4;
			num += num4;
			if (DKFKFEKOHOJ == HICEHGBGNJF)
			{
				FEMKBHIJGPD();
			}
			if (num5 > 0)
			{
				int num6 = (1 << num5) - 1;
				OCHLDCMIEHD[DKFKFEKOHOJ / 8] = (byte)(MBBPBGHKLJM[JBAJPGIAPFF + (int)(num / 8)] & num6);
				DKFKFEKOHOJ += num5;
				num += num5;
			}
		}
	}

	private void LLHKPHDFIAJ()
	{
		if (DKFKFEKOHOJ + 1 == HICEHGBGNJF)
		{
			OCHLDCMIEHD[DKFKFEKOHOJ / 8] |= (byte)(1 << DKFKFEKOHOJ % 8);
			FEMKBHIJGPD();
			OHGPOCPLHEK(0, HICEHGBGNJF / 8);
		}
		else
		{
			OHGPOCPLHEK((DKFKFEKOHOJ + 7) / 8, HICEHGBGNJF / 8 - (DKFKFEKOHOJ + 7) / 8);
			OCHLDCMIEHD[DKFKFEKOHOJ / 8] |= (byte)(1 << DKFKFEKOHOJ % 8);
		}
		OCHLDCMIEHD[(HICEHGBGNJF - 1) / 8] |= (byte)(1 << (HICEHGBGNJF - 1) % 8);
		FEMKBHIJGPD();
		if (HICEHGBGNJF == 1024)
		{
			BBCCGBOFAMK(BGEDKGLJIGM, OCHLDCMIEHD);
			AELCFGBEBPP = 1024;
		}
		else
		{
			LDAJCFPKFOG(BGEDKGLJIGM, OCHLDCMIEHD, HICEHGBGNJF / 64);
			AELCFGBEBPP = HICEHGBGNJF;
		}
		FIHFLDGIADB = true;
	}

	protected virtual void IOBPJDNCOGD(byte[] BILGCJNPJGJ, int IBNDGNOIEEF, long BDKBCELHFCN)
	{
		if (!FIHFLDGIADB)
		{
			LLHKPHDFIAJ();
		}
		if (BDKBCELHFCN % 8 != 0)
		{
			throw new InvalidOperationException("outputLength not a multiple of 8");
		}
		int num2;
		for (long num = 0L; num < BDKBCELHFCN; num += num2)
		{
			if (AELCFGBEBPP == 0)
			{
				NLGMNOCAGGF(BGEDKGLJIGM);
				if (HICEHGBGNJF == 1024)
				{
					BBCCGBOFAMK(BGEDKGLJIGM, OCHLDCMIEHD);
					AELCFGBEBPP = 1024;
				}
				else
				{
					LDAJCFPKFOG(BGEDKGLJIGM, OCHLDCMIEHD, HICEHGBGNJF / 64);
					AELCFGBEBPP = HICEHGBGNJF;
				}
			}
			num2 = AELCFGBEBPP;
			if (num2 > BDKBCELHFCN - num)
			{
				num2 = (int)(BDKBCELHFCN - num);
			}
			Array.Copy(OCHLDCMIEHD, (HICEHGBGNJF - AELCFGBEBPP) / 8, BILGCJNPJGJ, IBNDGNOIEEF + (int)(num / 8), num2 / 8);
			AELCFGBEBPP -= num2;
		}
	}

	private static void JPNPKKCMNDN(ulong[] HLMLKPPHBCO, byte[] BGEDKGLJIGM)
	{
		for (int i = 0; i < 25; i++)
		{
			HLMLKPPHBCO[i] = 0uL;
			int num = i * 8;
			for (int j = 0; j < 8; j++)
			{
				HLMLKPPHBCO[i] |= ((ulong)BGEDKGLJIGM[num + j] & 0xFFuL) << 8 * j;
			}
		}
	}

	private static void AKPBPMOGLAE(byte[] BGEDKGLJIGM, ulong[] HLMLKPPHBCO)
	{
		for (int i = 0; i < 25; i++)
		{
			int num = i * 8;
			for (int j = 0; j < 8; j++)
			{
				BGEDKGLJIGM[num + j] = (byte)(HLMLKPPHBCO[i] >> 8 * j);
			}
		}
	}

	private void NLGMNOCAGGF(byte[] BGEDKGLJIGM)
	{
		ulong[] array = new ulong[BGEDKGLJIGM.Length / 8];
		JPNPKKCMNDN(array, BGEDKGLJIGM);
		JCGEJEGHIAL(array);
		AKPBPMOGLAE(BGEDKGLJIGM, array);
	}

	private void NNAGMFLLMAK(byte[] BGEDKGLJIGM, byte[] MBBPBGHKLJM, int IJKMDEBDHPN)
	{
		for (int i = 0; i < IJKMDEBDHPN; i++)
		{
			BGEDKGLJIGM[i] ^= MBBPBGHKLJM[i];
		}
		NLGMNOCAGGF(BGEDKGLJIGM);
	}

	private void JCGEJEGHIAL(ulong[] BGEDKGLJIGM)
	{
		for (int i = 0; i < 24; i++)
		{
			NKPOEGCJELN(BGEDKGLJIGM);
			DJOKAEKNNGC(BGEDKGLJIGM);
			KIIBFEHFHFB(BGEDKGLJIGM);
			FPONDMJGJFF(BGEDKGLJIGM);
			DLDHLDGNPHO(BGEDKGLJIGM, i);
		}
	}

	private void NKPOEGCJELN(ulong[] JEHECJGFJEB)
	{
		for (int i = 0; i < 5; i++)
		{
			ANGINAGELKI[i] = 0uL;
			for (int j = 0; j < 5; j++)
			{
				ANGINAGELKI[i] ^= JEHECJGFJEB[i + 5 * j];
			}
		}
		for (int k = 0; k < 5; k++)
		{
			ulong num = (ANGINAGELKI[(k + 1) % 5] << 1) ^ (ANGINAGELKI[(k + 1) % 5] >> 63) ^ ANGINAGELKI[(k + 4) % 5];
			for (int l = 0; l < 5; l++)
			{
				JEHECJGFJEB[k + 5 * l] ^= num;
			}
		}
	}

	private void DJOKAEKNNGC(ulong[] JEHECJGFJEB)
	{
		for (int i = 0; i < 5; i++)
		{
			for (int j = 0; j < 5; j++)
			{
				int num = i + 5 * j;
				JEHECJGFJEB[num] = ((CKOHHLGAJFK[num] == 0) ? JEHECJGFJEB[num] : ((JEHECJGFJEB[num] << CKOHHLGAJFK[num]) ^ (JEHECJGFJEB[num] >> 64 - CKOHHLGAJFK[num])));
			}
		}
	}

	private void KIIBFEHFHFB(ulong[] JEHECJGFJEB)
	{
		Array.Copy(JEHECJGFJEB, 0, LFKPLEJFEHC, 0, LFKPLEJFEHC.Length);
		for (int i = 0; i < 5; i++)
		{
			for (int j = 0; j < 5; j++)
			{
				JEHECJGFJEB[j + 5 * ((2 * i + 3 * j) % 5)] = LFKPLEJFEHC[i + 5 * j];
			}
		}
	}

	private void FPONDMJGJFF(ulong[] JEHECJGFJEB)
	{
		for (int i = 0; i < 5; i++)
		{
			for (int j = 0; j < 5; j++)
			{
				LKPEDDMLOJA[j] = JEHECJGFJEB[j + 5 * i] ^ (~JEHECJGFJEB[(j + 1) % 5 + 5 * i] & JEHECJGFJEB[(j + 2) % 5 + 5 * i]);
			}
			for (int k = 0; k < 5; k++)
			{
				JEHECJGFJEB[k + 5 * i] = LKPEDDMLOJA[k];
			}
		}
	}

	private static void DLDHLDGNPHO(ulong[] JEHECJGFJEB, int BALPJEPKBAN)
	{
		JEHECJGFJEB[0] ^= DLCFGHFNHMO[BALPJEPKBAN];
	}

	private void ALJFDGGPHIG(byte[] PHLFKFJHNNM, byte[] MBBPBGHKLJM, int CNLDBHDEGJI)
	{
		NNAGMFLLMAK(PHLFKFJHNNM, MBBPBGHKLJM, CNLDBHDEGJI);
	}

	private void BBCCGBOFAMK(byte[] PHLFKFJHNNM, byte[] MBBPBGHKLJM)
	{
		Array.Copy(PHLFKFJHNNM, 0, MBBPBGHKLJM, 0, 128);
	}

	private void LDAJCFPKFOG(byte[] PHLFKFJHNNM, byte[] MBBPBGHKLJM, int DNGAKAJICHD)
	{
		Array.Copy(PHLFKFJHNNM, 0, MBBPBGHKLJM, 0, DNGAKAJICHD * 8);
	}

	public virtual MIPBJNJHNGA FDCFKGAEJFF()
	{
		return new PPHLCNGICDP(this);
	}

	public virtual void OMOKOKFNBKI(MIPBJNJHNGA CJHEIBNHNNE)
	{
		PPHLCNGICDP jKHLMLIANAI = (PPHLCNGICDP)CJHEIBNHNNE;
		AKBPCECABIO(jKHLMLIANAI);
	}
}
