using System;
using Org.BouncyCastle.Crypto;

public class LIPBIBIDEDF : KJLBDGGBCCF
{
	private const int OBDGIDCKDFM = 16;

	private readonly JMPFLJGHAIM IEDPBFAFGGJ;

	private readonly JABKGMPDKHJ AGFONDKEPFO;

	private PBJNLNCIIKM BBCGDLOJNND;

	private bool MAEALKEJALK;

	private int DLFPGGOCGNE;

	private byte[] FHCDMEEPPFG;

	private byte[] JOMGFBIBFNH;

	private byte[] JGOHMOHEFMJ;

	private byte[] DMKBKGAHCKD;

	private byte[] ODEKHLMHPEL;

	private byte[] GIMGNHOKFLA;

	private byte[] PCPPGMNCBJG;

	private byte[] PCNIAJDEICF;

	private byte[] IFNLAIALDEC;

	private byte[] CKKJMJHIJBN;

	private uint EBDBLGKBKAH;

	private int MNIGMJPFNDA;

	private ulong JICHDCHDKIN;

	private byte[] JCOLFBNJPFI;

	private int LGFGKLBDLJE;

	private ulong CEMKHCJAJEP;

	private ulong BIHNDNOEJDK;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return IEDPBFAFGGJ.KFKMEPMEBND + "/GCM";
		}
	}

	public LIPBIBIDEDF(JMPFLJGHAIM FMFABAKPMLB)
		: this(FMFABAKPMLB, null)
	{
	}

	public LIPBIBIDEDF(JMPFLJGHAIM FMFABAKPMLB, JABKGMPDKHJ CEKMAJAHNAG)
	{
		if (FMFABAKPMLB.BDIGGHEPIIP() != 16)
		{
			throw new ArgumentException("cipher required with a block size of " + 16 + ".");
		}
		if (CEKMAJAHNAG == null)
		{
			CEKMAJAHNAG = new CHJPDADMMGA();
		}
		IEDPBFAFGGJ = FMFABAKPMLB;
		AGFONDKEPFO = CEKMAJAHNAG;
	}

	public JMPFLJGHAIM GBHNDFALCDC()
	{
		return IEDPBFAFGGJ;
	}

	public virtual int BDIGGHEPIIP()
	{
		return 16;
	}

	public virtual void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		this.MAEALKEJALK = MAEALKEJALK;
		GIMGNHOKFLA = null;
		JEMNCGMEABF jEMNCGMEABF;
		if (IJJHBEECMBP is LPDNGJKFEFF)
		{
			LPDNGJKFEFF lPDNGJKFEFF = (LPDNGJKFEFF)IJJHBEECMBP;
			FHCDMEEPPFG = lPDNGJKFEFF.JONECFJAAMM();
			JOMGFBIBFNH = lPDNGJKFEFF.IDLCKKPAGAG();
			int num = lPDNGJKFEFF.ILMKNDOFPMK;
			if (num < 32 || num > 128 || num % 8 != 0)
			{
				throw new ArgumentException("Invalid value for MAC size: " + num);
			}
			DLFPGGOCGNE = num / 8;
			jEMNCGMEABF = lPDNGJKFEFF.CDEOGMLENPN;
		}
		else
		{
			if (!(IJJHBEECMBP is CHCELGDKEJG))
			{
				throw new ArgumentException("invalid parameters passed to GCM");
			}
			CHCELGDKEJG cHCELGDKEJG = (CHCELGDKEJG)IJJHBEECMBP;
			FHCDMEEPPFG = cHCELGDKEJG.OLAEDCABKDH();
			JOMGFBIBFNH = null;
			DLFPGGOCGNE = 16;
			jEMNCGMEABF = (JEMNCGMEABF)cHCELGDKEJG.KPJHHAAOFOH;
		}
		int num2 = ((!MAEALKEJALK) ? (16 + DLFPGGOCGNE) : 16);
		ODEKHLMHPEL = new byte[num2];
		if (FHCDMEEPPFG == null || FHCDMEEPPFG.Length < 1)
		{
			throw new ArgumentException("IV must be at least 1 byte");
		}
		if (jEMNCGMEABF != null)
		{
			IEDPBFAFGGJ.DIOELAHNLKJ(true, jEMNCGMEABF);
			JGOHMOHEFMJ = new byte[16];
			IEDPBFAFGGJ.DPACJDFHLKB(JGOHMOHEFMJ, 0, JGOHMOHEFMJ, 0);
			AGFONDKEPFO.DIOELAHNLKJ(JGOHMOHEFMJ);
			BBCGDLOJNND = null;
		}
		else if (JGOHMOHEFMJ == null)
		{
			throw new ArgumentException("Key must be specified in initial init");
		}
		DMKBKGAHCKD = new byte[16];
		if (FHCDMEEPPFG.Length == 12)
		{
			Array.Copy(FHCDMEEPPFG, 0, DMKBKGAHCKD, 0, FHCDMEEPPFG.Length);
			DMKBKGAHCKD[15] = 1;
		}
		else
		{
			HLHILNJGHEF(DMKBKGAHCKD, FHCDMEEPPFG, FHCDMEEPPFG.Length);
			byte[] array = new byte[16];
			PGOKFBKEOAB.LHKOONEHKNH((ulong)FHCDMEEPPFG.Length * 8uL, array, 8);
			ACJPINFCJCF(DMKBKGAHCKD, array);
		}
		PCPPGMNCBJG = new byte[16];
		PCNIAJDEICF = new byte[16];
		IFNLAIALDEC = new byte[16];
		JCOLFBNJPFI = new byte[16];
		LGFGKLBDLJE = 0;
		CEMKHCJAJEP = 0uL;
		BIHNDNOEJDK = 0uL;
		CKKJMJHIJBN = NOGCEBKPPJE.IKBFGGABMKP(DMKBKGAHCKD);
		EBDBLGKBKAH = 4294967294u;
		MNIGMJPFNDA = 0;
		JICHDCHDKIN = 0uL;
		if (JOMGFBIBFNH != null)
		{
			JCKGDHGGKEH(JOMGFBIBFNH, 0, JOMGFBIBFNH.Length);
		}
	}

	public virtual byte[] JIDMPJJAOOI()
	{
		return NOGCEBKPPJE.IKBFGGABMKP(GIMGNHOKFLA);
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
		return num - num % 16;
	}

	public virtual void FBJJIIFIPGA(byte MOPCLEEGDFB)
	{
		JCOLFBNJPFI[LGFGKLBDLJE] = MOPCLEEGDFB;
		if (++LGFGKLBDLJE == 16)
		{
			ACJPINFCJCF(PCNIAJDEICF, JCOLFBNJPFI);
			LGFGKLBDLJE = 0;
			CEMKHCJAJEP += 16uL;
		}
	}

	public virtual void JCKGDHGGKEH(byte[] AIFKJBMJOMK, int ELICNEDIBGB, int NBEDPKHALCN)
	{
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			JCOLFBNJPFI[LGFGKLBDLJE] = AIFKJBMJOMK[ELICNEDIBGB + i];
			if (++LGFGKLBDLJE == 16)
			{
				ACJPINFCJCF(PCNIAJDEICF, JCOLFBNJPFI);
				LGFGKLBDLJE = 0;
				CEMKHCJAJEP += 16uL;
			}
		}
	}

	private void DEDFALKONNI()
	{
		if (CEMKHCJAJEP != 0)
		{
			Array.Copy(PCNIAJDEICF, 0, IFNLAIALDEC, 0, 16);
			BIHNDNOEJDK = CEMKHCJAJEP;
		}
		if (LGFGKLBDLJE > 0)
		{
			LFNGBALIGGO(IFNLAIALDEC, JCOLFBNJPFI, 0, LGFGKLBDLJE);
			BIHNDNOEJDK += (uint)LGFGKLBDLJE;
		}
		if (BIHNDNOEJDK != 0)
		{
			Array.Copy(IFNLAIALDEC, 0, PCPPGMNCBJG, 0, 16);
		}
	}

	public virtual int HBCJNPGKMDP(byte MOPCLEEGDFB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		ODEKHLMHPEL[MNIGMJPFNDA] = MOPCLEEGDFB;
		if (++MNIGMJPFNDA == ODEKHLMHPEL.Length)
		{
			DOHMEFHBHGH(BILGCJNPJGJ, EMAKNGBIFDC);
			return 16;
		}
		return 0;
	}

	public virtual int POCAGALIPAI(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int NBEDPKHALCN, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		if (MOPCLEEGDFB.Length < ELICNEDIBGB + NBEDPKHALCN)
		{
			throw new DataLengthException("Input buffer too short");
		}
		int num = 0;
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			ODEKHLMHPEL[MNIGMJPFNDA] = MOPCLEEGDFB[ELICNEDIBGB + i];
			if (++MNIGMJPFNDA == ODEKHLMHPEL.Length)
			{
				DOHMEFHBHGH(BILGCJNPJGJ, EMAKNGBIFDC + num);
				num += 16;
			}
		}
		return num;
	}

	private void DOHMEFHBHGH(byte[] BILGCJNPJGJ, int IBNDGNOIEEF)
	{
		AJLDFGNHDCA.KLPNFGNKNKB(BILGCJNPJGJ, IBNDGNOIEEF, 16, "Output buffer too short");
		if (JICHDCHDKIN == 0)
		{
			DEDFALKONNI();
		}
		JJEIFLEGFGG(ODEKHLMHPEL, BILGCJNPJGJ, IBNDGNOIEEF);
		if (MAEALKEJALK)
		{
			MNIGMJPFNDA = 0;
			return;
		}
		Array.Copy(ODEKHLMHPEL, 16, ODEKHLMHPEL, 0, DLFPGGOCGNE);
		MNIGMJPFNDA = DLFPGGOCGNE;
	}

	public int LCNOFBMOHHM(byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		if (JICHDCHDKIN == 0)
		{
			DEDFALKONNI();
		}
		int num = MNIGMJPFNDA;
		if (MAEALKEJALK)
		{
			AJLDFGNHDCA.KLPNFGNKNKB(BILGCJNPJGJ, EMAKNGBIFDC, num + DLFPGGOCGNE, "Output buffer too short");
		}
		else
		{
			if (num < DLFPGGOCGNE)
			{
				throw new InvalidCipherTextException("data too short");
			}
			num -= DLFPGGOCGNE;
			AJLDFGNHDCA.KLPNFGNKNKB(BILGCJNPJGJ, EMAKNGBIFDC, num, "Output buffer too short");
		}
		if (num > 0)
		{
			CCKCBBCKLBI(ODEKHLMHPEL, 0, num, BILGCJNPJGJ, EMAKNGBIFDC);
		}
		CEMKHCJAJEP += (uint)LGFGKLBDLJE;
		if (CEMKHCJAJEP > BIHNDNOEJDK)
		{
			if (LGFGKLBDLJE > 0)
			{
				LFNGBALIGGO(PCNIAJDEICF, JCOLFBNJPFI, 0, LGFGKLBDLJE);
			}
			if (BIHNDNOEJDK != 0)
			{
				HIHDNGIBEPL.FHLALGENPPH(PCNIAJDEICF, IFNLAIALDEC);
			}
			long dELAPGFJHAP = (long)(JICHDCHDKIN * 8 + 127 >> 7);
			byte[] array = new byte[16];
			if (BBCGDLOJNND == null)
			{
				BBCGDLOJNND = new ODCOKAIMCDB();
				BBCGDLOJNND.DIOELAHNLKJ(JGOHMOHEFMJ);
			}
			BBCGDLOJNND.GGMLLFLIGDP(dELAPGFJHAP, array);
			HIHDNGIBEPL.IBJBIGNPNEM(PCNIAJDEICF, array);
			HIHDNGIBEPL.FHLALGENPPH(PCPPGMNCBJG, PCNIAJDEICF);
		}
		byte[] array2 = new byte[16];
		PGOKFBKEOAB.LHKOONEHKNH(CEMKHCJAJEP * 8, array2, 0);
		PGOKFBKEOAB.LHKOONEHKNH(JICHDCHDKIN * 8, array2, 8);
		ACJPINFCJCF(PCPPGMNCBJG, array2);
		byte[] array3 = new byte[16];
		IEDPBFAFGGJ.DPACJDFHLKB(DMKBKGAHCKD, 0, array3, 0);
		HIHDNGIBEPL.FHLALGENPPH(array3, PCPPGMNCBJG);
		int num2 = num;
		GIMGNHOKFLA = new byte[DLFPGGOCGNE];
		Array.Copy(array3, 0, GIMGNHOKFLA, 0, DLFPGGOCGNE);
		if (MAEALKEJALK)
		{
			Array.Copy(GIMGNHOKFLA, 0, BILGCJNPJGJ, EMAKNGBIFDC + MNIGMJPFNDA, DLFPGGOCGNE);
			num2 += DLFPGGOCGNE;
		}
		else
		{
			byte[] array4 = new byte[DLFPGGOCGNE];
			Array.Copy(ODEKHLMHPEL, num, array4, 0, DLFPGGOCGNE);
			if (!NOGCEBKPPJE.PBBFCJBKJEN(GIMGNHOKFLA, array4))
			{
				throw new InvalidCipherTextException("mac check in GCM failed");
			}
		}
		OMOKOKFNBKI(false);
		return num2;
	}

	public virtual void OMOKOKFNBKI()
	{
		OMOKOKFNBKI(true);
	}

	private void OMOKOKFNBKI(bool JEMGAHCJPEA)
	{
		IEDPBFAFGGJ.OMOKOKFNBKI();
		PCPPGMNCBJG = new byte[16];
		PCNIAJDEICF = new byte[16];
		IFNLAIALDEC = new byte[16];
		JCOLFBNJPFI = new byte[16];
		LGFGKLBDLJE = 0;
		CEMKHCJAJEP = 0uL;
		BIHNDNOEJDK = 0uL;
		CKKJMJHIJBN = NOGCEBKPPJE.IKBFGGABMKP(DMKBKGAHCKD);
		EBDBLGKBKAH = 4294967294u;
		MNIGMJPFNDA = 0;
		JICHDCHDKIN = 0uL;
		if (ODEKHLMHPEL != null)
		{
			NOGCEBKPPJE.MEBLOMPDLEJ(ODEKHLMHPEL, 0);
		}
		if (JEMGAHCJPEA)
		{
			GIMGNHOKFLA = null;
		}
		if (JOMGFBIBFNH != null)
		{
			JCKGDHGGKEH(JOMGFBIBFNH, 0, JOMGFBIBFNH.Length);
		}
	}

	private void JJEIFLEGFGG(byte[] OJEJPICFOOJ, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		byte[] array = IKLLCOLCOCK();
		HIHDNGIBEPL.FHLALGENPPH(array, OJEJPICFOOJ);
		Array.Copy(array, 0, BILGCJNPJGJ, EMAKNGBIFDC, 16);
		ACJPINFCJCF(PCPPGMNCBJG, (!MAEALKEJALK) ? OJEJPICFOOJ : array);
		JICHDCHDKIN += 16uL;
	}

	private void CCKCBBCKLBI(byte[] GHPCHPOHELF, int JBAJPGIAPFF, int NBEDPKHALCN, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		byte[] array = IKLLCOLCOCK();
		HIHDNGIBEPL.FHLALGENPPH(array, GHPCHPOHELF, JBAJPGIAPFF, NBEDPKHALCN);
		Array.Copy(array, 0, BILGCJNPJGJ, EMAKNGBIFDC, NBEDPKHALCN);
		LFNGBALIGGO(PCPPGMNCBJG, (!MAEALKEJALK) ? GHPCHPOHELF : array, 0, NBEDPKHALCN);
		JICHDCHDKIN += (uint)NBEDPKHALCN;
	}

	private void HLHILNJGHEF(byte[] MOAGLBJDKKL, byte[] BCIHLCMFAEK, int NBEDPKHALCN)
	{
		for (int i = 0; i < NBEDPKHALCN; i += 16)
		{
			int nBEDPKHALCN = Math.Min(NBEDPKHALCN - i, 16);
			LFNGBALIGGO(MOAGLBJDKKL, BCIHLCMFAEK, i, nBEDPKHALCN);
		}
	}

	private void ACJPINFCJCF(byte[] MOAGLBJDKKL, byte[] BCIHLCMFAEK)
	{
		HIHDNGIBEPL.FHLALGENPPH(MOAGLBJDKKL, BCIHLCMFAEK);
		AGFONDKEPFO.BJCNKBAIJHD(MOAGLBJDKKL);
	}

	private void LFNGBALIGGO(byte[] MOAGLBJDKKL, byte[] BCIHLCMFAEK, int JBAJPGIAPFF, int NBEDPKHALCN)
	{
		HIHDNGIBEPL.FHLALGENPPH(MOAGLBJDKKL, BCIHLCMFAEK, JBAJPGIAPFF, NBEDPKHALCN);
		AGFONDKEPFO.BJCNKBAIJHD(MOAGLBJDKKL);
	}

	private byte[] IKLLCOLCOCK()
	{
		if (EBDBLGKBKAH == 0)
		{
			throw new InvalidOperationException("Attempt to process too many blocks");
		}
		EBDBLGKBKAH--;
		uint num = 1u;
		num += CKKJMJHIJBN[15];
		CKKJMJHIJBN[15] = (byte)num;
		num >>= 8;
		num += CKKJMJHIJBN[14];
		CKKJMJHIJBN[14] = (byte)num;
		num >>= 8;
		num += CKKJMJHIJBN[13];
		CKKJMJHIJBN[13] = (byte)num;
		num >>= 8;
		num += CKKJMJHIJBN[12];
		CKKJMJHIJBN[12] = (byte)num;
		byte[] array = new byte[16];
		IEDPBFAFGGJ.DPACJDFHLKB(CKKJMJHIJBN, 0, array, 0);
		return array;
	}
}
