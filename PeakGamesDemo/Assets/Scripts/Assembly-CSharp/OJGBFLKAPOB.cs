using System;
using Org.BouncyCastle.Crypto;

public class OJGBFLKAPOB : JMPFLJGHAIM
{
	private byte[] INPOFIMEPGC;

	private byte[] JNFGGNKDLMM;

	private byte[] IGLEADPNIID;

	private int NONHELBCKCH;

	private JMPFLJGHAIM IEDPBFAFGGJ;

	private bool LFBBFLCMAHI;

	public string KFKMEPMEBND
	{
		get
		{
			return IEDPBFAFGGJ.KFKMEPMEBND + "/CBC";
		}
	}

	public bool ABNLKPDCGEF
	{
		get
		{
			return false;
		}
	}

	public OJGBFLKAPOB(JMPFLJGHAIM IEDPBFAFGGJ)
	{
		this.IEDPBFAFGGJ = IEDPBFAFGGJ;
		NONHELBCKCH = IEDPBFAFGGJ.BDIGGHEPIIP();
		INPOFIMEPGC = new byte[NONHELBCKCH];
		JNFGGNKDLMM = new byte[NONHELBCKCH];
		IGLEADPNIID = new byte[NONHELBCKCH];
	}

	public JMPFLJGHAIM GBHNDFALCDC()
	{
		return IEDPBFAFGGJ;
	}

	public void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		bool lFBBFLCMAHI = LFBBFLCMAHI;
		LFBBFLCMAHI = MAEALKEJALK;
		if (IJJHBEECMBP is CHCELGDKEJG)
		{
			CHCELGDKEJG cHCELGDKEJG = (CHCELGDKEJG)IJJHBEECMBP;
			byte[] array = cHCELGDKEJG.OLAEDCABKDH();
			if (array.Length != NONHELBCKCH)
			{
				throw new ArgumentException("initialisation vector must be the same length as block size");
			}
			Array.Copy(array, 0, INPOFIMEPGC, 0, array.Length);
			IJJHBEECMBP = cHCELGDKEJG.KPJHHAAOFOH;
		}
		OMOKOKFNBKI();
		if (IJJHBEECMBP != null)
		{
			IEDPBFAFGGJ.DIOELAHNLKJ(LFBBFLCMAHI, IJJHBEECMBP);
		}
		else if (lFBBFLCMAHI != LFBBFLCMAHI)
		{
			throw new ArgumentException("cannot change encrypting state without providing key.");
		}
	}

	public int BDIGGHEPIIP()
	{
		return IEDPBFAFGGJ.BDIGGHEPIIP();
	}

	public int DPACJDFHLKB(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		return (!LFBBFLCMAHI) ? GFKALHGNIOJ(MOPCLEEGDFB, ELICNEDIBGB, BILGCJNPJGJ, EMAKNGBIFDC) : HDOLNBOHAJA(MOPCLEEGDFB, ELICNEDIBGB, BILGCJNPJGJ, EMAKNGBIFDC);
	}

	public void OMOKOKFNBKI()
	{
		Array.Copy(INPOFIMEPGC, 0, JNFGGNKDLMM, 0, INPOFIMEPGC.Length);
		Array.Clear(IGLEADPNIID, 0, IGLEADPNIID.Length);
		IEDPBFAFGGJ.OMOKOKFNBKI();
	}

	private int HDOLNBOHAJA(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		if (ELICNEDIBGB + NONHELBCKCH > MOPCLEEGDFB.Length)
		{
			throw new DataLengthException("input buffer too short");
		}
		for (int i = 0; i < NONHELBCKCH; i++)
		{
			JNFGGNKDLMM[i] ^= MOPCLEEGDFB[ELICNEDIBGB + i];
		}
		int result = IEDPBFAFGGJ.DPACJDFHLKB(JNFGGNKDLMM, 0, NGAGMIIBGKA, EMAKNGBIFDC);
		Array.Copy(NGAGMIIBGKA, EMAKNGBIFDC, JNFGGNKDLMM, 0, JNFGGNKDLMM.Length);
		return result;
	}

	private int GFKALHGNIOJ(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		if (ELICNEDIBGB + NONHELBCKCH > MOPCLEEGDFB.Length)
		{
			throw new DataLengthException("input buffer too short");
		}
		Array.Copy(MOPCLEEGDFB, ELICNEDIBGB, IGLEADPNIID, 0, NONHELBCKCH);
		int result = IEDPBFAFGGJ.DPACJDFHLKB(MOPCLEEGDFB, ELICNEDIBGB, NGAGMIIBGKA, EMAKNGBIFDC);
		for (int i = 0; i < NONHELBCKCH; i++)
		{
			NGAGMIIBGKA[EMAKNGBIFDC + i] ^= JNFGGNKDLMM[i];
		}
		byte[] jNFGGNKDLMM = JNFGGNKDLMM;
		JNFGGNKDLMM = IGLEADPNIID;
		IGLEADPNIID = jNFGGNKDLMM;
		return result;
	}
}
