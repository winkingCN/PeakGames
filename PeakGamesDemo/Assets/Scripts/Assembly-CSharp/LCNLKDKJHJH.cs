using System;

public class LCNLKDKJHJH : JMPFLJGHAIM
{
	private readonly JMPFLJGHAIM IEDPBFAFGGJ;

	private readonly int NONHELBCKCH;

	private readonly byte[] CKKJMJHIJBN;

	private readonly byte[] MLKFEGEGALK;

	private byte[] INPOFIMEPGC;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return IEDPBFAFGGJ.KFKMEPMEBND + "/SIC";
		}
	}

	public virtual bool ABNLKPDCGEF
	{
		get
		{
			return true;
		}
	}

	public LCNLKDKJHJH(JMPFLJGHAIM IEDPBFAFGGJ)
	{
		this.IEDPBFAFGGJ = IEDPBFAFGGJ;
		NONHELBCKCH = IEDPBFAFGGJ.BDIGGHEPIIP();
		CKKJMJHIJBN = new byte[NONHELBCKCH];
		MLKFEGEGALK = new byte[NONHELBCKCH];
		INPOFIMEPGC = new byte[NONHELBCKCH];
	}

	public virtual JMPFLJGHAIM GBHNDFALCDC()
	{
		return IEDPBFAFGGJ;
	}

	public virtual void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		CHCELGDKEJG cHCELGDKEJG = IJJHBEECMBP as CHCELGDKEJG;
		if (cHCELGDKEJG == null)
		{
			throw new ArgumentException("CTR/SIC mode requires ParametersWithIV", "parameters");
		}
		INPOFIMEPGC = NOGCEBKPPJE.IKBFGGABMKP(cHCELGDKEJG.OLAEDCABKDH());
		if (NONHELBCKCH < INPOFIMEPGC.Length)
		{
			throw new ArgumentException("CTR/SIC mode requires IV no greater than: " + NONHELBCKCH + " bytes.");
		}
		int num = Math.Min(8, NONHELBCKCH / 2);
		if (NONHELBCKCH - INPOFIMEPGC.Length > num)
		{
			throw new ArgumentException("CTR/SIC mode requires IV of at least: " + (NONHELBCKCH - num) + " bytes.");
		}
		if (cHCELGDKEJG.KPJHHAAOFOH != null)
		{
			IEDPBFAFGGJ.DIOELAHNLKJ(true, cHCELGDKEJG.KPJHHAAOFOH);
		}
		OMOKOKFNBKI();
	}

	public virtual int BDIGGHEPIIP()
	{
		return IEDPBFAFGGJ.BDIGGHEPIIP();
	}

	public virtual int DPACJDFHLKB(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		IEDPBFAFGGJ.DPACJDFHLKB(CKKJMJHIJBN, 0, MLKFEGEGALK, 0);
		for (int i = 0; i < MLKFEGEGALK.Length; i++)
		{
			BILGCJNPJGJ[EMAKNGBIFDC + i] = (byte)(MLKFEGEGALK[i] ^ MOPCLEEGDFB[ELICNEDIBGB + i]);
		}
		int num = CKKJMJHIJBN.Length;
		while (--num >= 0 && ++CKKJMJHIJBN[num] == 0)
		{
		}
		return CKKJMJHIJBN.Length;
	}

	public virtual void OMOKOKFNBKI()
	{
		NOGCEBKPPJE.MEBLOMPDLEJ(CKKJMJHIJBN, 0);
		Array.Copy(INPOFIMEPGC, 0, CKKJMJHIJBN, 0, INPOFIMEPGC.Length);
		IEDPBFAFGGJ.OMOKOKFNBKI();
	}
}
