using System;
using System.IO;
using Org.BouncyCastle.Crypto;

public class DHAFOFMKGGG : KJLBDGGBCCF
{
	private static readonly int OBDGIDCKDFM = 16;

	private readonly JMPFLJGHAIM IEDPBFAFGGJ;

	private readonly byte[] GIMGNHOKFLA;

	private bool MAEALKEJALK;

	private byte[] FHCDMEEPPFG;

	private byte[] JOMGFBIBFNH;

	private int DLFPGGOCGNE;

	private IGMAJHKIIPK AINJCEAIMJE;

	private readonly MemoryStream CKJHHGBELEG = new MemoryStream();

	private readonly MemoryStream MBBPBGHKLJM = new MemoryStream();

	public virtual string KFKMEPMEBND
	{
		get
		{
			return IEDPBFAFGGJ.KFKMEPMEBND + "/CCM";
		}
	}

	public DHAFOFMKGGG(JMPFLJGHAIM IEDPBFAFGGJ)
	{
		this.IEDPBFAFGGJ = IEDPBFAFGGJ;
		GIMGNHOKFLA = new byte[OBDGIDCKDFM];
		if (IEDPBFAFGGJ.BDIGGHEPIIP() != OBDGIDCKDFM)
		{
			throw new ArgumentException("cipher required with a block size of " + OBDGIDCKDFM + ".");
		}
	}

	public virtual JMPFLJGHAIM GBHNDFALCDC()
	{
		return IEDPBFAFGGJ;
	}

	public virtual void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		this.MAEALKEJALK = MAEALKEJALK;
		IGMAJHKIIPK iGMAJHKIIPK;
		if (IJJHBEECMBP is LPDNGJKFEFF)
		{
			LPDNGJKFEFF lPDNGJKFEFF = (LPDNGJKFEFF)IJJHBEECMBP;
			FHCDMEEPPFG = lPDNGJKFEFF.JONECFJAAMM();
			JOMGFBIBFNH = lPDNGJKFEFF.IDLCKKPAGAG();
			DLFPGGOCGNE = lPDNGJKFEFF.ILMKNDOFPMK / 8;
			iGMAJHKIIPK = lPDNGJKFEFF.CDEOGMLENPN;
		}
		else
		{
			if (!(IJJHBEECMBP is CHCELGDKEJG))
			{
				throw new ArgumentException("invalid parameters passed to CCM");
			}
			CHCELGDKEJG cHCELGDKEJG = (CHCELGDKEJG)IJJHBEECMBP;
			FHCDMEEPPFG = cHCELGDKEJG.OLAEDCABKDH();
			JOMGFBIBFNH = null;
			DLFPGGOCGNE = GIMGNHOKFLA.Length / 2;
			iGMAJHKIIPK = cHCELGDKEJG.KPJHHAAOFOH;
		}
		if (iGMAJHKIIPK != null)
		{
			AINJCEAIMJE = iGMAJHKIIPK;
		}
		if (FHCDMEEPPFG == null || FHCDMEEPPFG.Length < 7 || FHCDMEEPPFG.Length > 13)
		{
			throw new ArgumentException("nonce must have length from 7 to 13 octets");
		}
		OMOKOKFNBKI();
	}

	public virtual int BDIGGHEPIIP()
	{
		return IEDPBFAFGGJ.BDIGGHEPIIP();
	}

	public virtual void FBJJIIFIPGA(byte MOPCLEEGDFB)
	{
		CKJHHGBELEG.WriteByte(MOPCLEEGDFB);
	}

	public virtual void JCKGDHGGKEH(byte[] AIFKJBMJOMK, int ELICNEDIBGB, int NBEDPKHALCN)
	{
		CKJHHGBELEG.Write(AIFKJBMJOMK, ELICNEDIBGB, NBEDPKHALCN);
	}

	public virtual int HBCJNPGKMDP(byte MOPCLEEGDFB, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		MBBPBGHKLJM.WriteByte(MOPCLEEGDFB);
		return 0;
	}

	public virtual int POCAGALIPAI(byte[] AIFKJBMJOMK, int ELICNEDIBGB, int DBGBBFPPDCE, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		AJLDFGNHDCA.OONDALLFPOP(AIFKJBMJOMK, ELICNEDIBGB, DBGBBFPPDCE, "Input buffer too short");
		MBBPBGHKLJM.Write(AIFKJBMJOMK, ELICNEDIBGB, DBGBBFPPDCE);
		return 0;
	}

	public virtual int LCNOFBMOHHM(byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		byte[] buffer = MBBPBGHKLJM.GetBuffer();
		int dBGBBFPPDCE = (int)MBBPBGHKLJM.Position;
		int result = ADBDDEGEHBM(buffer, 0, dBGBBFPPDCE, NGAGMIIBGKA, EMAKNGBIFDC);
		OMOKOKFNBKI();
		return result;
	}

	public virtual void OMOKOKFNBKI()
	{
		IEDPBFAFGGJ.OMOKOKFNBKI();
		CKJHHGBELEG.SetLength(0L);
		MBBPBGHKLJM.SetLength(0L);
	}

	public virtual byte[] JIDMPJJAOOI()
	{
		return NOGCEBKPPJE.EHLHBAMJLNI(GIMGNHOKFLA, 0, DLFPGGOCGNE);
	}

	public virtual int MIMJCMAODEK(int NBEDPKHALCN)
	{
		return 0;
	}

	public virtual int ACLDAECDPFN(int NBEDPKHALCN)
	{
		int num = (int)MBBPBGHKLJM.Length + NBEDPKHALCN;
		if (MAEALKEJALK)
		{
			return num + DLFPGGOCGNE;
		}
		return (num >= DLFPGGOCGNE) ? (num - DLFPGGOCGNE) : 0;
	}

	public virtual byte[] ADBDDEGEHBM(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int DBGBBFPPDCE)
	{
		byte[] array;
		if (MAEALKEJALK)
		{
			array = new byte[DBGBBFPPDCE + DLFPGGOCGNE];
		}
		else
		{
			if (DBGBBFPPDCE < DLFPGGOCGNE)
			{
				throw new InvalidCipherTextException("data too short");
			}
			array = new byte[DBGBBFPPDCE - DLFPGGOCGNE];
		}
		ADBDDEGEHBM(MOPCLEEGDFB, ELICNEDIBGB, DBGBBFPPDCE, array, 0);
		return array;
	}

	public virtual int ADBDDEGEHBM(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int DBGBBFPPDCE, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		if (AINJCEAIMJE == null)
		{
			throw new InvalidOperationException("CCM cipher unitialized.");
		}
		int num = FHCDMEEPPFG.Length;
		int num2 = 15 - num;
		if (num2 < 4)
		{
			int num3 = 1 << 8 * num2;
			if (DBGBBFPPDCE >= num3)
			{
				throw new InvalidOperationException("CCM packet too large for choice of q.");
			}
		}
		byte[] array = new byte[OBDGIDCKDFM];
		array[0] = (byte)((uint)(num2 - 1) & 7u);
		FHCDMEEPPFG.CopyTo(array, 1);
		JMPFLJGHAIM jMPFLJGHAIM = new LCNLKDKJHJH(IEDPBFAFGGJ);
		jMPFLJGHAIM.DIOELAHNLKJ(MAEALKEJALK, new CHCELGDKEJG(AINJCEAIMJE, array));
		int i = ELICNEDIBGB;
		int num4 = EMAKNGBIFDC;
		int num5;
		if (MAEALKEJALK)
		{
			num5 = DBGBBFPPDCE + DLFPGGOCGNE;
			AJLDFGNHDCA.KLPNFGNKNKB(BILGCJNPJGJ, EMAKNGBIFDC, num5, "Output buffer too short.");
			OFLKIODCBJJ(MOPCLEEGDFB, ELICNEDIBGB, DBGBBFPPDCE, GIMGNHOKFLA);
			byte[] array2 = new byte[OBDGIDCKDFM];
			jMPFLJGHAIM.DPACJDFHLKB(GIMGNHOKFLA, 0, array2, 0);
			for (; i < ELICNEDIBGB + DBGBBFPPDCE - OBDGIDCKDFM; i += OBDGIDCKDFM)
			{
				jMPFLJGHAIM.DPACJDFHLKB(MOPCLEEGDFB, i, BILGCJNPJGJ, num4);
				num4 += OBDGIDCKDFM;
			}
			byte[] array3 = new byte[OBDGIDCKDFM];
			Array.Copy(MOPCLEEGDFB, i, array3, 0, DBGBBFPPDCE + ELICNEDIBGB - i);
			jMPFLJGHAIM.DPACJDFHLKB(array3, 0, array3, 0);
			Array.Copy(array3, 0, BILGCJNPJGJ, num4, DBGBBFPPDCE + ELICNEDIBGB - i);
			Array.Copy(array2, 0, BILGCJNPJGJ, EMAKNGBIFDC + DBGBBFPPDCE, DLFPGGOCGNE);
		}
		else
		{
			if (DBGBBFPPDCE < DLFPGGOCGNE)
			{
				throw new InvalidCipherTextException("data too short");
			}
			num5 = DBGBBFPPDCE - DLFPGGOCGNE;
			AJLDFGNHDCA.KLPNFGNKNKB(BILGCJNPJGJ, EMAKNGBIFDC, num5, "Output buffer too short.");
			Array.Copy(MOPCLEEGDFB, ELICNEDIBGB + num5, GIMGNHOKFLA, 0, DLFPGGOCGNE);
			jMPFLJGHAIM.DPACJDFHLKB(GIMGNHOKFLA, 0, GIMGNHOKFLA, 0);
			for (int j = DLFPGGOCGNE; j != GIMGNHOKFLA.Length; j++)
			{
				GIMGNHOKFLA[j] = 0;
			}
			for (; i < ELICNEDIBGB + num5 - OBDGIDCKDFM; i += OBDGIDCKDFM)
			{
				jMPFLJGHAIM.DPACJDFHLKB(MOPCLEEGDFB, i, BILGCJNPJGJ, num4);
				num4 += OBDGIDCKDFM;
			}
			byte[] array4 = new byte[OBDGIDCKDFM];
			Array.Copy(MOPCLEEGDFB, i, array4, 0, num5 - (i - ELICNEDIBGB));
			jMPFLJGHAIM.DPACJDFHLKB(array4, 0, array4, 0);
			Array.Copy(array4, 0, BILGCJNPJGJ, num4, num5 - (i - ELICNEDIBGB));
			byte[] array5 = new byte[OBDGIDCKDFM];
			OFLKIODCBJJ(BILGCJNPJGJ, EMAKNGBIFDC, num5, array5);
			if (!NOGCEBKPPJE.PBBFCJBKJEN(GIMGNHOKFLA, array5))
			{
				throw new InvalidCipherTextException("mac check in CCM failed");
			}
		}
		return num5;
	}

	private int OFLKIODCBJJ(byte[] MBBPBGHKLJM, int GCPLMLPIIJJ, int LNKLBKHPGGI, byte[] GIMGNHOKFLA)
	{
		PHFBFDEAHMD pHFBFDEAHMD = new GDNPKPCHNBE(IEDPBFAFGGJ, DLFPGGOCGNE * 8);
		pHFBFDEAHMD.DIOELAHNLKJ(AINJCEAIMJE);
		byte[] array = new byte[16];
		if (JFPIMAADLGJ())
		{
			array[0] |= 64;
		}
		array[0] |= (byte)((((pHFBFDEAHMD.BKGLOJPPBIG() - 2) / 2) & 7) << 3);
		array[0] |= (byte)((15 - FHCDMEEPPFG.Length - 1) & 7);
		Array.Copy(FHCDMEEPPFG, 0, array, 1, FHCDMEEPPFG.Length);
		int num = LNKLBKHPGGI;
		int num2 = 1;
		while (num > 0)
		{
			array[array.Length - num2] = (byte)((uint)num & 0xFFu);
			num >>= 8;
			num2++;
		}
		pHFBFDEAHMD.GONEEEFEDGF(array, 0, array.Length);
		if (JFPIMAADLGJ())
		{
			int num3 = DBPPEBEFLLF();
			int num4;
			if (num3 < 65280)
			{
				pHFBFDEAHMD.BPAJGOINFNL((byte)(num3 >> 8));
				pHFBFDEAHMD.BPAJGOINFNL((byte)num3);
				num4 = 2;
			}
			else
			{
				pHFBFDEAHMD.BPAJGOINFNL(byte.MaxValue);
				pHFBFDEAHMD.BPAJGOINFNL(254);
				pHFBFDEAHMD.BPAJGOINFNL((byte)(num3 >> 24));
				pHFBFDEAHMD.BPAJGOINFNL((byte)(num3 >> 16));
				pHFBFDEAHMD.BPAJGOINFNL((byte)(num3 >> 8));
				pHFBFDEAHMD.BPAJGOINFNL((byte)num3);
				num4 = 6;
			}
			if (JOMGFBIBFNH != null)
			{
				pHFBFDEAHMD.GONEEEFEDGF(JOMGFBIBFNH, 0, JOMGFBIBFNH.Length);
			}
			if (CKJHHGBELEG.Position > 0)
			{
				byte[] buffer = CKJHHGBELEG.GetBuffer();
				int nBEDPKHALCN = (int)CKJHHGBELEG.Position;
				pHFBFDEAHMD.GONEEEFEDGF(buffer, 0, nBEDPKHALCN);
			}
			num4 = (num4 + num3) % 16;
			if (num4 != 0)
			{
				for (int i = num4; i < 16; i++)
				{
					pHFBFDEAHMD.BPAJGOINFNL(0);
				}
			}
		}
		pHFBFDEAHMD.GONEEEFEDGF(MBBPBGHKLJM, GCPLMLPIIJJ, LNKLBKHPGGI);
		return pHFBFDEAHMD.LCNOFBMOHHM(GIMGNHOKFLA, 0);
	}

	private int DBPPEBEFLLF()
	{
		return (int)CKJHHGBELEG.Length + ((JOMGFBIBFNH != null) ? JOMGFBIBFNH.Length : 0);
	}

	private bool JFPIMAADLGJ()
	{
		return DBPPEBEFLLF() > 0;
	}
}
