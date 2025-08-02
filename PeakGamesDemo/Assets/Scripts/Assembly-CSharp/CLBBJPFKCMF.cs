using System;

public class CLBBJPFKCMF : PHFBFDEAHMD
{
	private const byte KGKMCAODJKD = 135;

	private const byte NMJMCPALMHN = 27;

	private byte[] FDLLLPJAPGF;

	private byte[] LGMMFPHDIMH;

	private byte[] GHPCHPOHELF;

	private int MNIGMJPFNDA;

	private JMPFLJGHAIM IEDPBFAFGGJ;

	private int DLFPGGOCGNE;

	private byte[] NBFDOJDLKOG;

	private byte[] HFMAKICMGKB;

	private byte[] BJDGHHEJECN;

	public string KFKMEPMEBND
	{
		get
		{
			return IEDPBFAFGGJ.KFKMEPMEBND;
		}
	}

	public CLBBJPFKCMF(JMPFLJGHAIM IEDPBFAFGGJ)
		: this(IEDPBFAFGGJ, IEDPBFAFGGJ.BDIGGHEPIIP() * 8)
	{
	}

	public CLBBJPFKCMF(JMPFLJGHAIM IEDPBFAFGGJ, int DOPHJMLEJPG)
	{
		if (DOPHJMLEJPG % 8 != 0)
		{
			throw new ArgumentException("MAC size must be multiple of 8");
		}
		if (DOPHJMLEJPG > IEDPBFAFGGJ.BDIGGHEPIIP() * 8)
		{
			throw new ArgumentException("MAC size must be less or equal to " + IEDPBFAFGGJ.BDIGGHEPIIP() * 8);
		}
		if (IEDPBFAFGGJ.BDIGGHEPIIP() != 8 && IEDPBFAFGGJ.BDIGGHEPIIP() != 16)
		{
			throw new ArgumentException("Block size must be either 64 or 128 bits");
		}
		this.IEDPBFAFGGJ = new OJGBFLKAPOB(IEDPBFAFGGJ);
		DLFPGGOCGNE = DOPHJMLEJPG / 8;
		LGMMFPHDIMH = new byte[IEDPBFAFGGJ.BDIGGHEPIIP()];
		GHPCHPOHELF = new byte[IEDPBFAFGGJ.BDIGGHEPIIP()];
		FDLLLPJAPGF = new byte[IEDPBFAFGGJ.BDIGGHEPIIP()];
		MNIGMJPFNDA = 0;
	}

	private static int DOKHFLENGLF(byte[] OJEJPICFOOJ, byte[] BILGCJNPJGJ)
	{
		int num = OJEJPICFOOJ.Length;
		uint num2 = 0u;
		while (--num >= 0)
		{
			uint num3 = OJEJPICFOOJ[num];
			BILGCJNPJGJ[num] = (byte)((num3 << 1) | num2);
			num2 = (num3 >> 7) & 1u;
		}
		return (int)num2;
	}

	private static byte[] OENJLKBKNML(byte[] MOPCLEEGDFB)
	{
		byte[] array = new byte[MOPCLEEGDFB.Length];
		int num = DOKHFLENGLF(MOPCLEEGDFB, array);
		int num2 = ((MOPCLEEGDFB.Length != 16) ? 27 : 135);
		array[MOPCLEEGDFB.Length - 1] ^= (byte)(num2 >> (1 - num << 3));
		return array;
	}

	public void DIOELAHNLKJ(IGMAJHKIIPK IJJHBEECMBP)
	{
		if (IJJHBEECMBP is JEMNCGMEABF)
		{
			IEDPBFAFGGJ.DIOELAHNLKJ(true, IJJHBEECMBP);
			NBFDOJDLKOG = new byte[FDLLLPJAPGF.Length];
			IEDPBFAFGGJ.DPACJDFHLKB(FDLLLPJAPGF, 0, NBFDOJDLKOG, 0);
			HFMAKICMGKB = OENJLKBKNML(NBFDOJDLKOG);
			BJDGHHEJECN = OENJLKBKNML(HFMAKICMGKB);
		}
		else if (IJJHBEECMBP != null)
		{
			throw new ArgumentException("CMac mode only permits key to be set.", "parameters");
		}
		OMOKOKFNBKI();
	}

	public int BKGLOJPPBIG()
	{
		return DLFPGGOCGNE;
	}

	public void BPAJGOINFNL(byte MOPCLEEGDFB)
	{
		if (MNIGMJPFNDA == GHPCHPOHELF.Length)
		{
			IEDPBFAFGGJ.DPACJDFHLKB(GHPCHPOHELF, 0, LGMMFPHDIMH, 0);
			MNIGMJPFNDA = 0;
		}
		GHPCHPOHELF[MNIGMJPFNDA++] = MOPCLEEGDFB;
	}

	public void GONEEEFEDGF(byte[] AIFKJBMJOMK, int ELICNEDIBGB, int NBEDPKHALCN)
	{
		if (NBEDPKHALCN < 0)
		{
			throw new ArgumentException("Can't have a negative input length!");
		}
		int num = IEDPBFAFGGJ.BDIGGHEPIIP();
		int num2 = num - MNIGMJPFNDA;
		if (NBEDPKHALCN > num2)
		{
			Array.Copy(AIFKJBMJOMK, ELICNEDIBGB, GHPCHPOHELF, MNIGMJPFNDA, num2);
			IEDPBFAFGGJ.DPACJDFHLKB(GHPCHPOHELF, 0, LGMMFPHDIMH, 0);
			MNIGMJPFNDA = 0;
			NBEDPKHALCN -= num2;
			ELICNEDIBGB += num2;
			while (NBEDPKHALCN > num)
			{
				IEDPBFAFGGJ.DPACJDFHLKB(AIFKJBMJOMK, ELICNEDIBGB, LGMMFPHDIMH, 0);
				NBEDPKHALCN -= num;
				ELICNEDIBGB += num;
			}
		}
		Array.Copy(AIFKJBMJOMK, ELICNEDIBGB, GHPCHPOHELF, MNIGMJPFNDA, NBEDPKHALCN);
		MNIGMJPFNDA += NBEDPKHALCN;
	}

	public int LCNOFBMOHHM(byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		int num = IEDPBFAFGGJ.BDIGGHEPIIP();
		byte[] array;
		if (MNIGMJPFNDA == num)
		{
			array = HFMAKICMGKB;
		}
		else
		{
			new HCKOBAHHNFD().MDNFIGPPOFC(GHPCHPOHELF, MNIGMJPFNDA);
			array = BJDGHHEJECN;
		}
		for (int i = 0; i < LGMMFPHDIMH.Length; i++)
		{
			GHPCHPOHELF[i] ^= array[i];
		}
		IEDPBFAFGGJ.DPACJDFHLKB(GHPCHPOHELF, 0, LGMMFPHDIMH, 0);
		Array.Copy(LGMMFPHDIMH, 0, NGAGMIIBGKA, EMAKNGBIFDC, DLFPGGOCGNE);
		OMOKOKFNBKI();
		return DLFPGGOCGNE;
	}

	public void OMOKOKFNBKI()
	{
		Array.Clear(GHPCHPOHELF, 0, GHPCHPOHELF.Length);
		MNIGMJPFNDA = 0;
		IEDPBFAFGGJ.OMOKOKFNBKI();
	}
}
