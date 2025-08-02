using System;
using Org.BouncyCastle.Crypto;

internal class MELAHCOFCEJ : JMPFLJGHAIM
{
	private byte[] INPOFIMEPGC;

	private byte[] LCBJKGGMJKM;

	private byte[] EDGPAFNFMPG;

	private readonly int NONHELBCKCH;

	private readonly JMPFLJGHAIM IEDPBFAFGGJ;

	public string KFKMEPMEBND
	{
		get
		{
			return IEDPBFAFGGJ.KFKMEPMEBND + "/CFB" + NONHELBCKCH * 8;
		}
	}

	public bool ABNLKPDCGEF
	{
		get
		{
			return true;
		}
	}

	public MELAHCOFCEJ(JMPFLJGHAIM IEDPBFAFGGJ, int JIBJCKJCFAC)
	{
		this.IEDPBFAFGGJ = IEDPBFAFGGJ;
		NONHELBCKCH = JIBJCKJCFAC / 8;
		INPOFIMEPGC = new byte[IEDPBFAFGGJ.BDIGGHEPIIP()];
		LCBJKGGMJKM = new byte[IEDPBFAFGGJ.BDIGGHEPIIP()];
		EDGPAFNFMPG = new byte[IEDPBFAFGGJ.BDIGGHEPIIP()];
	}

	public void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		if (IJJHBEECMBP is CHCELGDKEJG)
		{
			CHCELGDKEJG cHCELGDKEJG = (CHCELGDKEJG)IJJHBEECMBP;
			byte[] array = cHCELGDKEJG.OLAEDCABKDH();
			if (array.Length < INPOFIMEPGC.Length)
			{
				Array.Copy(array, 0, INPOFIMEPGC, INPOFIMEPGC.Length - array.Length, array.Length);
			}
			else
			{
				Array.Copy(array, 0, INPOFIMEPGC, 0, INPOFIMEPGC.Length);
			}
			IJJHBEECMBP = cHCELGDKEJG.KPJHHAAOFOH;
		}
		OMOKOKFNBKI();
		IEDPBFAFGGJ.DIOELAHNLKJ(true, IJJHBEECMBP);
	}

	public int BDIGGHEPIIP()
	{
		return NONHELBCKCH;
	}

	public int DPACJDFHLKB(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		if (ELICNEDIBGB + NONHELBCKCH > MOPCLEEGDFB.Length)
		{
			throw new DataLengthException("input buffer too short");
		}
		if (EMAKNGBIFDC + NONHELBCKCH > NGAGMIIBGKA.Length)
		{
			throw new DataLengthException("output buffer too short");
		}
		IEDPBFAFGGJ.DPACJDFHLKB(LCBJKGGMJKM, 0, EDGPAFNFMPG, 0);
		for (int i = 0; i < NONHELBCKCH; i++)
		{
			NGAGMIIBGKA[EMAKNGBIFDC + i] = (byte)(EDGPAFNFMPG[i] ^ MOPCLEEGDFB[ELICNEDIBGB + i]);
		}
		Array.Copy(LCBJKGGMJKM, NONHELBCKCH, LCBJKGGMJKM, 0, LCBJKGGMJKM.Length - NONHELBCKCH);
		Array.Copy(NGAGMIIBGKA, EMAKNGBIFDC, LCBJKGGMJKM, LCBJKGGMJKM.Length - NONHELBCKCH, NONHELBCKCH);
		return NONHELBCKCH;
	}

	public void OMOKOKFNBKI()
	{
		INPOFIMEPGC.CopyTo(LCBJKGGMJKM, 0);
		IEDPBFAFGGJ.OMOKOKFNBKI();
	}

	public void KMAGMBHGHBL(byte[] LGMMFPHDIMH)
	{
		IEDPBFAFGGJ.DPACJDFHLKB(LCBJKGGMJKM, 0, LGMMFPHDIMH, 0);
	}
}
