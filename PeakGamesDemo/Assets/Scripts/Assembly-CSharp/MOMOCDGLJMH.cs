using System;
using Org.BouncyCastle.Crypto;

public class MOMOCDGLJMH : KJLBDGGBCCF
{
	private enum MHMFGNKJCJJ : byte
	{
		N = 0,
		H = 1,
		C = 2
	}

	private LCNLKDKJHJH IEDPBFAFGGJ;

	private bool MAEALKEJALK;

	private int NONHELBCKCH;

	private PHFBFDEAHMD LGMMFPHDIMH;

	private byte[] MIFBGHFNGDB;

	private byte[] IHKDLFHOIOM;

	private byte[] GIMGNHOKFLA;

	private int DLFPGGOCGNE;

	private byte[] ODEKHLMHPEL;

	private int MNIGMJPFNDA;

	private bool FFOPLMHEPFC;

	private byte[] JOMGFBIBFNH;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return IEDPBFAFGGJ.GBHNDFALCDC().KFKMEPMEBND + "/EAX";
		}
	}

	public MOMOCDGLJMH(JMPFLJGHAIM IEDPBFAFGGJ)
	{
		NONHELBCKCH = IEDPBFAFGGJ.BDIGGHEPIIP();
		LGMMFPHDIMH = new CLBBJPFKCMF(IEDPBFAFGGJ);
		GIMGNHOKFLA = new byte[NONHELBCKCH];
		IHKDLFHOIOM = new byte[LGMMFPHDIMH.BKGLOJPPBIG()];
		MIFBGHFNGDB = new byte[LGMMFPHDIMH.BKGLOJPPBIG()];
		this.IEDPBFAFGGJ = new LCNLKDKJHJH(IEDPBFAFGGJ);
	}

	public virtual JMPFLJGHAIM GBHNDFALCDC()
	{
		return IEDPBFAFGGJ;
	}

	public virtual int BDIGGHEPIIP()
	{
		return IEDPBFAFGGJ.BDIGGHEPIIP();
	}

	public virtual void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		this.MAEALKEJALK = MAEALKEJALK;
		byte[] array;
		IGMAJHKIIPK iJJHBEECMBP;
		if (IJJHBEECMBP is LPDNGJKFEFF)
		{
			LPDNGJKFEFF lPDNGJKFEFF = (LPDNGJKFEFF)IJJHBEECMBP;
			array = lPDNGJKFEFF.JONECFJAAMM();
			JOMGFBIBFNH = lPDNGJKFEFF.IDLCKKPAGAG();
			DLFPGGOCGNE = lPDNGJKFEFF.ILMKNDOFPMK / 8;
			iJJHBEECMBP = lPDNGJKFEFF.CDEOGMLENPN;
		}
		else
		{
			if (!(IJJHBEECMBP is CHCELGDKEJG))
			{
				throw new ArgumentException("invalid parameters passed to EAX");
			}
			CHCELGDKEJG cHCELGDKEJG = (CHCELGDKEJG)IJJHBEECMBP;
			array = cHCELGDKEJG.OLAEDCABKDH();
			JOMGFBIBFNH = null;
			DLFPGGOCGNE = LGMMFPHDIMH.BKGLOJPPBIG() / 2;
			iJJHBEECMBP = cHCELGDKEJG.KPJHHAAOFOH;
		}
		ODEKHLMHPEL = new byte[(!MAEALKEJALK) ? (NONHELBCKCH + DLFPGGOCGNE) : NONHELBCKCH];
		byte[] array2 = new byte[NONHELBCKCH];
		LGMMFPHDIMH.DIOELAHNLKJ(iJJHBEECMBP);
		array2[NONHELBCKCH - 1] = 0;
		LGMMFPHDIMH.GONEEEFEDGF(array2, 0, NONHELBCKCH);
		LGMMFPHDIMH.GONEEEFEDGF(array, 0, array.Length);
		LGMMFPHDIMH.LCNOFBMOHHM(MIFBGHFNGDB, 0);
		IEDPBFAFGGJ.DIOELAHNLKJ(true, new CHCELGDKEJG(null, MIFBGHFNGDB));
		OMOKOKFNBKI();
	}

	private void DEDFALKONNI()
	{
		if (!FFOPLMHEPFC)
		{
			FFOPLMHEPFC = true;
			LGMMFPHDIMH.LCNOFBMOHHM(IHKDLFHOIOM, 0);
			byte[] array = new byte[NONHELBCKCH];
			array[NONHELBCKCH - 1] = 2;
			LGMMFPHDIMH.GONEEEFEDGF(array, 0, NONHELBCKCH);
		}
	}

	private void OFLKIODCBJJ()
	{
		byte[] array = new byte[NONHELBCKCH];
		LGMMFPHDIMH.LCNOFBMOHHM(array, 0);
		for (int i = 0; i < GIMGNHOKFLA.Length; i++)
		{
			GIMGNHOKFLA[i] = (byte)(MIFBGHFNGDB[i] ^ IHKDLFHOIOM[i] ^ array[i]);
		}
	}

	public virtual void OMOKOKFNBKI()
	{
		OMOKOKFNBKI(true);
	}

	private void OMOKOKFNBKI(bool JEMGAHCJPEA)
	{
		IEDPBFAFGGJ.OMOKOKFNBKI();
		LGMMFPHDIMH.OMOKOKFNBKI();
		MNIGMJPFNDA = 0;
		Array.Clear(ODEKHLMHPEL, 0, ODEKHLMHPEL.Length);
		if (JEMGAHCJPEA)
		{
			Array.Clear(GIMGNHOKFLA, 0, GIMGNHOKFLA.Length);
		}
		byte[] array = new byte[NONHELBCKCH];
		array[NONHELBCKCH - 1] = 1;
		LGMMFPHDIMH.GONEEEFEDGF(array, 0, NONHELBCKCH);
		FFOPLMHEPFC = false;
		if (JOMGFBIBFNH != null)
		{
			JCKGDHGGKEH(JOMGFBIBFNH, 0, JOMGFBIBFNH.Length);
		}
	}

	public virtual void FBJJIIFIPGA(byte MOPCLEEGDFB)
	{
		if (FFOPLMHEPFC)
		{
			throw new InvalidOperationException("AAD data cannot be added after encryption/decryption processing has begun.");
		}
		LGMMFPHDIMH.BPAJGOINFNL(MOPCLEEGDFB);
	}

	public virtual void JCKGDHGGKEH(byte[] AIFKJBMJOMK, int ELICNEDIBGB, int NBEDPKHALCN)
	{
		if (FFOPLMHEPFC)
		{
			throw new InvalidOperationException("AAD data cannot be added after encryption/decryption processing has begun.");
		}
		LGMMFPHDIMH.GONEEEFEDGF(AIFKJBMJOMK, ELICNEDIBGB, NBEDPKHALCN);
	}

	public virtual int HBCJNPGKMDP(byte MOPCLEEGDFB, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		DEDFALKONNI();
		return GDGINCNCMDD(MOPCLEEGDFB, NGAGMIIBGKA, EMAKNGBIFDC);
	}

	public virtual int POCAGALIPAI(byte[] AIFKJBMJOMK, int ELICNEDIBGB, int NBEDPKHALCN, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		DEDFALKONNI();
		int num = 0;
		for (int i = 0; i != NBEDPKHALCN; i++)
		{
			num += GDGINCNCMDD(AIFKJBMJOMK[ELICNEDIBGB + i], NGAGMIIBGKA, EMAKNGBIFDC + num);
		}
		return num;
	}

	public virtual int LCNOFBMOHHM(byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		DEDFALKONNI();
		int mNIGMJPFNDA = MNIGMJPFNDA;
		byte[] array = new byte[ODEKHLMHPEL.Length];
		MNIGMJPFNDA = 0;
		if (MAEALKEJALK)
		{
			AJLDFGNHDCA.KLPNFGNKNKB(NGAGMIIBGKA, EMAKNGBIFDC, mNIGMJPFNDA + DLFPGGOCGNE, "Output buffer too short");
			IEDPBFAFGGJ.DPACJDFHLKB(ODEKHLMHPEL, 0, array, 0);
			Array.Copy(array, 0, NGAGMIIBGKA, EMAKNGBIFDC, mNIGMJPFNDA);
			LGMMFPHDIMH.GONEEEFEDGF(array, 0, mNIGMJPFNDA);
			OFLKIODCBJJ();
			Array.Copy(GIMGNHOKFLA, 0, NGAGMIIBGKA, EMAKNGBIFDC + mNIGMJPFNDA, DLFPGGOCGNE);
			OMOKOKFNBKI(false);
			return mNIGMJPFNDA + DLFPGGOCGNE;
		}
		if (mNIGMJPFNDA < DLFPGGOCGNE)
		{
			throw new InvalidCipherTextException("data too short");
		}
		AJLDFGNHDCA.KLPNFGNKNKB(NGAGMIIBGKA, EMAKNGBIFDC, mNIGMJPFNDA - DLFPGGOCGNE, "Output buffer too short");
		if (mNIGMJPFNDA > DLFPGGOCGNE)
		{
			LGMMFPHDIMH.GONEEEFEDGF(ODEKHLMHPEL, 0, mNIGMJPFNDA - DLFPGGOCGNE);
			IEDPBFAFGGJ.DPACJDFHLKB(ODEKHLMHPEL, 0, array, 0);
			Array.Copy(array, 0, NGAGMIIBGKA, EMAKNGBIFDC, mNIGMJPFNDA - DLFPGGOCGNE);
		}
		OFLKIODCBJJ();
		if (!HLJCBLPIKEL(ODEKHLMHPEL, mNIGMJPFNDA - DLFPGGOCGNE))
		{
			throw new InvalidCipherTextException("mac check in EAX failed");
		}
		OMOKOKFNBKI(false);
		return mNIGMJPFNDA - DLFPGGOCGNE;
	}

	public virtual byte[] JIDMPJJAOOI()
	{
		byte[] array = new byte[DLFPGGOCGNE];
		Array.Copy(GIMGNHOKFLA, 0, array, 0, DLFPGGOCGNE);
		return array;
	}

	public virtual int MIMJCMAODEK(int NBEDPKHALCN)
	{
		int num = NBEDPKHALCN + MNIGMJPFNDA;
		if (!MAEALKEJALK)
		{
			if (num < DLFPGGOCGNE)
			{
				return 0;
			}
			num -= DLFPGGOCGNE;
		}
		return num - num % NONHELBCKCH;
	}

	public virtual int ACLDAECDPFN(int NBEDPKHALCN)
	{
		int num = NBEDPKHALCN + MNIGMJPFNDA;
		if (MAEALKEJALK)
		{
			return num + DLFPGGOCGNE;
		}
		return (num >= DLFPGGOCGNE) ? (num - DLFPGGOCGNE) : 0;
	}

	private int GDGINCNCMDD(byte BCIHLCMFAEK, byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		ODEKHLMHPEL[MNIGMJPFNDA++] = BCIHLCMFAEK;
		if (MNIGMJPFNDA == ODEKHLMHPEL.Length)
		{
			AJLDFGNHDCA.KLPNFGNKNKB(NGAGMIIBGKA, EMAKNGBIFDC, NONHELBCKCH, "Output buffer is too short");
			int result;
			if (MAEALKEJALK)
			{
				result = IEDPBFAFGGJ.DPACJDFHLKB(ODEKHLMHPEL, 0, NGAGMIIBGKA, EMAKNGBIFDC);
				LGMMFPHDIMH.GONEEEFEDGF(NGAGMIIBGKA, EMAKNGBIFDC, NONHELBCKCH);
			}
			else
			{
				LGMMFPHDIMH.GONEEEFEDGF(ODEKHLMHPEL, 0, NONHELBCKCH);
				result = IEDPBFAFGGJ.DPACJDFHLKB(ODEKHLMHPEL, 0, NGAGMIIBGKA, EMAKNGBIFDC);
			}
			MNIGMJPFNDA = 0;
			if (!MAEALKEJALK)
			{
				Array.Copy(ODEKHLMHPEL, NONHELBCKCH, ODEKHLMHPEL, 0, DLFPGGOCGNE);
				MNIGMJPFNDA = DLFPGGOCGNE;
			}
			return result;
		}
		return 0;
	}

	private bool HLJCBLPIKEL(byte[] LGMMFPHDIMH, int JBAJPGIAPFF)
	{
		int num = 0;
		for (int i = 0; i < DLFPGGOCGNE; i++)
		{
			num |= GIMGNHOKFLA[i] ^ LGMMFPHDIMH[JBAJPGIAPFF + i];
		}
		return num == 0;
	}
}
