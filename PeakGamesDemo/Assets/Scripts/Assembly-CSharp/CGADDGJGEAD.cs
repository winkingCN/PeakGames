using System;
using Org.BouncyCastle.Crypto;

public class CGADDGJGEAD : JMPFLJGHAIM
{
	private byte[] INPOFIMEPGC;

	private byte[] GCDDJOOHBAN;

	private byte[] CJHCJHCDCHA;

	private readonly int NONHELBCKCH;

	private readonly JMPFLJGHAIM IEDPBFAFGGJ;

	public string KFKMEPMEBND
	{
		get
		{
			return IEDPBFAFGGJ.KFKMEPMEBND + "/OFB" + NONHELBCKCH * 8;
		}
	}

	public bool ABNLKPDCGEF
	{
		get
		{
			return true;
		}
	}

	public CGADDGJGEAD(JMPFLJGHAIM IEDPBFAFGGJ, int NONHELBCKCH)
	{
		this.IEDPBFAFGGJ = IEDPBFAFGGJ;
		this.NONHELBCKCH = NONHELBCKCH / 8;
		INPOFIMEPGC = new byte[IEDPBFAFGGJ.BDIGGHEPIIP()];
		GCDDJOOHBAN = new byte[IEDPBFAFGGJ.BDIGGHEPIIP()];
		CJHCJHCDCHA = new byte[IEDPBFAFGGJ.BDIGGHEPIIP()];
	}

	public JMPFLJGHAIM GBHNDFALCDC()
	{
		return IEDPBFAFGGJ;
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
				for (int i = 0; i < INPOFIMEPGC.Length - array.Length; i++)
				{
					INPOFIMEPGC[i] = 0;
				}
			}
			else
			{
				Array.Copy(array, 0, INPOFIMEPGC, 0, INPOFIMEPGC.Length);
			}
			IJJHBEECMBP = cHCELGDKEJG.KPJHHAAOFOH;
		}
		OMOKOKFNBKI();
		if (IJJHBEECMBP != null)
		{
			IEDPBFAFGGJ.DIOELAHNLKJ(true, IJJHBEECMBP);
		}
	}

	public int BDIGGHEPIIP()
	{
		return NONHELBCKCH;
	}

	public int DPACJDFHLKB(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		if (ELICNEDIBGB + NONHELBCKCH > MOPCLEEGDFB.Length)
		{
			throw new DataLengthException("input buffer too short");
		}
		if (EMAKNGBIFDC + NONHELBCKCH > BILGCJNPJGJ.Length)
		{
			throw new DataLengthException("output buffer too short");
		}
		IEDPBFAFGGJ.DPACJDFHLKB(GCDDJOOHBAN, 0, CJHCJHCDCHA, 0);
		for (int i = 0; i < NONHELBCKCH; i++)
		{
			BILGCJNPJGJ[EMAKNGBIFDC + i] = (byte)(CJHCJHCDCHA[i] ^ MOPCLEEGDFB[ELICNEDIBGB + i]);
		}
		Array.Copy(GCDDJOOHBAN, NONHELBCKCH, GCDDJOOHBAN, 0, GCDDJOOHBAN.Length - NONHELBCKCH);
		Array.Copy(CJHCJHCDCHA, 0, GCDDJOOHBAN, GCDDJOOHBAN.Length - NONHELBCKCH, NONHELBCKCH);
		return NONHELBCKCH;
	}

	public void OMOKOKFNBKI()
	{
		Array.Copy(INPOFIMEPGC, 0, GCDDJOOHBAN, 0, INPOFIMEPGC.Length);
		IEDPBFAFGGJ.OMOKOKFNBKI();
	}
}
