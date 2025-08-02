using System;
using System.Collections;
using Org.BouncyCastle.Crypto;

public class HJNLHLHBNGF : KJLBDGGBCCF
{
	private const int ANKLOALOPKP = 16;

	private readonly JMPFLJGHAIM DCJIFDJNMJJ;

	private readonly JMPFLJGHAIM MGCHMFBDNPA;

	private bool MAEALKEJALK;

	private int DLFPGGOCGNE;

	private byte[] JOMGFBIBFNH;

	private IList NBFDOJDLKOG;

	private byte[] KJCGJCCPIEI;

	private byte[] LPGKBALPPGF;

	private byte[] IJBEMHIPNND;

	private byte[] KLIPHMPIGJH = new byte[24];

	private byte[] NGOIJMFCCBI = new byte[16];

	private byte[] OMCNIAEHHOO;

	private byte[] FNEEHGKPFKC;

	private int CKJIDGLLODB;

	private int JAEBHBFGJAD;

	private long NLLGAOKALPO;

	private long DBHPACJIGLK;

	private byte[] FECAHJECDKM;

	private byte[] LIMGHFNPACK;

	private byte[] MGEOKLAMHCN = new byte[16];

	private byte[] ACJABBEGOPC;

	private byte[] GIMGNHOKFLA;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return MGCHMFBDNPA.KFKMEPMEBND + "/OCB";
		}
	}

	public HJNLHLHBNGF(JMPFLJGHAIM DCJIFDJNMJJ, JMPFLJGHAIM MGCHMFBDNPA)
	{
		if (DCJIFDJNMJJ == null)
		{
			throw new ArgumentNullException("hashCipher");
		}
		if (DCJIFDJNMJJ.BDIGGHEPIIP() != 16)
		{
			throw new ArgumentException("must have a block size of " + 16, "hashCipher");
		}
		if (MGCHMFBDNPA == null)
		{
			throw new ArgumentNullException("mainCipher");
		}
		if (MGCHMFBDNPA.BDIGGHEPIIP() != 16)
		{
			throw new ArgumentException("must have a block size of " + 16, "mainCipher");
		}
		if (!DCJIFDJNMJJ.KFKMEPMEBND.Equals(MGCHMFBDNPA.KFKMEPMEBND))
		{
			throw new ArgumentException("'hashCipher' and 'mainCipher' must be the same algorithm");
		}
		this.DCJIFDJNMJJ = DCJIFDJNMJJ;
		this.MGCHMFBDNPA = MGCHMFBDNPA;
	}

	public virtual JMPFLJGHAIM GBHNDFALCDC()
	{
		return MGCHMFBDNPA;
	}

	public virtual void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		bool mAEALKEJALK = this.MAEALKEJALK;
		this.MAEALKEJALK = MAEALKEJALK;
		GIMGNHOKFLA = null;
		byte[] array;
		JEMNCGMEABF jEMNCGMEABF;
		if (IJJHBEECMBP is LPDNGJKFEFF)
		{
			LPDNGJKFEFF lPDNGJKFEFF = (LPDNGJKFEFF)IJJHBEECMBP;
			array = lPDNGJKFEFF.JONECFJAAMM();
			JOMGFBIBFNH = lPDNGJKFEFF.IDLCKKPAGAG();
			int num = lPDNGJKFEFF.ILMKNDOFPMK;
			if (num < 64 || num > 128 || num % 8 != 0)
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
				throw new ArgumentException("invalid parameters passed to OCB");
			}
			CHCELGDKEJG cHCELGDKEJG = (CHCELGDKEJG)IJJHBEECMBP;
			array = cHCELGDKEJG.OLAEDCABKDH();
			JOMGFBIBFNH = null;
			DLFPGGOCGNE = 16;
			jEMNCGMEABF = (JEMNCGMEABF)cHCELGDKEJG.KPJHHAAOFOH;
		}
		OMCNIAEHHOO = new byte[16];
		FNEEHGKPFKC = new byte[(!MAEALKEJALK) ? (16 + DLFPGGOCGNE) : 16];
		if (array == null)
		{
			array = new byte[0];
		}
		if (array.Length > 15)
		{
			throw new ArgumentException("IV must be no more than 15 bytes");
		}
		if (jEMNCGMEABF != null)
		{
			DCJIFDJNMJJ.DIOELAHNLKJ(true, jEMNCGMEABF);
			MGCHMFBDNPA.DIOELAHNLKJ(MAEALKEJALK, jEMNCGMEABF);
			IJBEMHIPNND = null;
		}
		else if (mAEALKEJALK != MAEALKEJALK)
		{
			throw new ArgumentException("cannot change encrypting state without providing key.");
		}
		KJCGJCCPIEI = new byte[16];
		DCJIFDJNMJJ.DPACJDFHLKB(KJCGJCCPIEI, 0, KJCGJCCPIEI, 0);
		LPGKBALPPGF = ALGKOGOMIEA(KJCGJCCPIEI);
		NBFDOJDLKOG = LHFGHNFJIKM.PPPFFFBMGML();
		NBFDOJDLKOG.Add(ALGKOGOMIEA(LPGKBALPPGF));
		int num2 = DCDMMKCEKBN(array);
		int num3 = num2 % 8;
		int num4 = num2 / 8;
		if (num3 == 0)
		{
			Array.Copy(KLIPHMPIGJH, num4, NGOIJMFCCBI, 0, 16);
		}
		else
		{
			for (int i = 0; i < 16; i++)
			{
				uint num5 = KLIPHMPIGJH[num4];
				uint num6 = KLIPHMPIGJH[++num4];
				NGOIJMFCCBI[i] = (byte)((num5 << num3) | (num6 >> 8 - num3));
			}
		}
		CKJIDGLLODB = 0;
		JAEBHBFGJAD = 0;
		NLLGAOKALPO = 0L;
		DBHPACJIGLK = 0L;
		FECAHJECDKM = new byte[16];
		LIMGHFNPACK = new byte[16];
		Array.Copy(NGOIJMFCCBI, 0, MGEOKLAMHCN, 0, 16);
		ACJABBEGOPC = new byte[16];
		if (JOMGFBIBFNH != null)
		{
			JCKGDHGGKEH(JOMGFBIBFNH, 0, JOMGFBIBFNH.Length);
		}
	}

	protected virtual int DCDMMKCEKBN(byte[] HNLMGJGNBDD)
	{
		byte[] array = new byte[16];
		Array.Copy(HNLMGJGNBDD, 0, array, array.Length - HNLMGJGNBDD.Length, HNLMGJGNBDD.Length);
		array[0] = (byte)(DLFPGGOCGNE << 4);
		array[15 - HNLMGJGNBDD.Length] |= 1;
		int result = array[15] & 0x3F;
		array[15] &= 192;
		if (IJBEMHIPNND == null || !NOGCEBKPPJE.ICKLINNFHKK(array, IJBEMHIPNND))
		{
			byte[] array2 = new byte[16];
			IJBEMHIPNND = array;
			DCJIFDJNMJJ.DPACJDFHLKB(IJBEMHIPNND, 0, array2, 0);
			Array.Copy(array2, 0, KLIPHMPIGJH, 0, 16);
			for (int i = 0; i < 8; i++)
			{
				KLIPHMPIGJH[16 + i] = (byte)(array2[i] ^ array2[i + 1]);
			}
		}
		return result;
	}

	public virtual int BDIGGHEPIIP()
	{
		return 16;
	}

	public virtual byte[] JIDMPJJAOOI()
	{
		return NOGCEBKPPJE.IKBFGGABMKP(GIMGNHOKFLA);
	}

	public virtual int ACLDAECDPFN(int NBEDPKHALCN)
	{
		int num = NBEDPKHALCN + JAEBHBFGJAD;
		if (MAEALKEJALK)
		{
			return num + DLFPGGOCGNE;
		}
		return (num >= DLFPGGOCGNE) ? (num - DLFPGGOCGNE) : 0;
	}

	public virtual int MIMJCMAODEK(int NBEDPKHALCN)
	{
		int num = NBEDPKHALCN + JAEBHBFGJAD;
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
		OMCNIAEHHOO[CKJIDGLLODB] = MOPCLEEGDFB;
		if (++CKJIDGLLODB == OMCNIAEHHOO.Length)
		{
			KJDEGFKDGJM();
		}
	}

	public virtual void JCKGDHGGKEH(byte[] MOPCLEEGDFB, int JBAJPGIAPFF, int NBEDPKHALCN)
	{
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			OMCNIAEHHOO[CKJIDGLLODB] = MOPCLEEGDFB[JBAJPGIAPFF + i];
			if (++CKJIDGLLODB == OMCNIAEHHOO.Length)
			{
				KJDEGFKDGJM();
			}
		}
	}

	public virtual int HBCJNPGKMDP(byte MOPCLEEGDFB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		FNEEHGKPFKC[JAEBHBFGJAD] = MOPCLEEGDFB;
		if (++JAEBHBFGJAD == FNEEHGKPFKC.Length)
		{
			DGCFAFENCDJ(BILGCJNPJGJ, EMAKNGBIFDC);
			return 16;
		}
		return 0;
	}

	public virtual int POCAGALIPAI(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int NBEDPKHALCN, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		int num = 0;
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			FNEEHGKPFKC[JAEBHBFGJAD] = MOPCLEEGDFB[ELICNEDIBGB + i];
			if (++JAEBHBFGJAD == FNEEHGKPFKC.Length)
			{
				DGCFAFENCDJ(BILGCJNPJGJ, EMAKNGBIFDC + num);
				num += 16;
			}
		}
		return num;
	}

	public virtual int LCNOFBMOHHM(byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		byte[] array = null;
		if (!MAEALKEJALK)
		{
			if (JAEBHBFGJAD < DLFPGGOCGNE)
			{
				throw new InvalidCipherTextException("data too short");
			}
			JAEBHBFGJAD -= DLFPGGOCGNE;
			array = new byte[DLFPGGOCGNE];
			Array.Copy(FNEEHGKPFKC, JAEBHBFGJAD, array, 0, DLFPGGOCGNE);
		}
		if (CKJIDGLLODB > 0)
		{
			LCJNOIADBIE(OMCNIAEHHOO, CKJIDGLLODB);
			NLCDIHHEBOJ(KJCGJCCPIEI);
		}
		if (JAEBHBFGJAD > 0)
		{
			if (MAEALKEJALK)
			{
				LCJNOIADBIE(FNEEHGKPFKC, JAEBHBFGJAD);
				FHLALGENPPH(ACJABBEGOPC, FNEEHGKPFKC);
			}
			FHLALGENPPH(MGEOKLAMHCN, KJCGJCCPIEI);
			byte[] array2 = new byte[16];
			DCJIFDJNMJJ.DPACJDFHLKB(MGEOKLAMHCN, 0, array2, 0);
			FHLALGENPPH(FNEEHGKPFKC, array2);
			AJLDFGNHDCA.KLPNFGNKNKB(BILGCJNPJGJ, EMAKNGBIFDC, JAEBHBFGJAD, "Output buffer too short");
			Array.Copy(FNEEHGKPFKC, 0, BILGCJNPJGJ, EMAKNGBIFDC, JAEBHBFGJAD);
			if (!MAEALKEJALK)
			{
				LCJNOIADBIE(FNEEHGKPFKC, JAEBHBFGJAD);
				FHLALGENPPH(ACJABBEGOPC, FNEEHGKPFKC);
			}
		}
		FHLALGENPPH(ACJABBEGOPC, MGEOKLAMHCN);
		FHLALGENPPH(ACJABBEGOPC, LPGKBALPPGF);
		DCJIFDJNMJJ.DPACJDFHLKB(ACJABBEGOPC, 0, ACJABBEGOPC, 0);
		FHLALGENPPH(ACJABBEGOPC, LIMGHFNPACK);
		GIMGNHOKFLA = new byte[DLFPGGOCGNE];
		Array.Copy(ACJABBEGOPC, 0, GIMGNHOKFLA, 0, DLFPGGOCGNE);
		int num = JAEBHBFGJAD;
		if (MAEALKEJALK)
		{
			AJLDFGNHDCA.KLPNFGNKNKB(BILGCJNPJGJ, EMAKNGBIFDC, num + DLFPGGOCGNE, "Output buffer too short");
			Array.Copy(GIMGNHOKFLA, 0, BILGCJNPJGJ, EMAKNGBIFDC + num, DLFPGGOCGNE);
			num += DLFPGGOCGNE;
		}
		else if (!NOGCEBKPPJE.PBBFCJBKJEN(GIMGNHOKFLA, array))
		{
			throw new InvalidCipherTextException("mac check in OCB failed");
		}
		OMOKOKFNBKI(false);
		return num;
	}

	public virtual void OMOKOKFNBKI()
	{
		OMOKOKFNBKI(true);
	}

	protected virtual void BOPEPLONIFL(byte[] FAPGOCDNGIB)
	{
		if (FAPGOCDNGIB != null)
		{
			Array.Clear(FAPGOCDNGIB, 0, FAPGOCDNGIB.Length);
		}
	}

	protected virtual byte[] MJHCJBDJJCL(int IDHLPOFDLKJ)
	{
		while (IDHLPOFDLKJ >= NBFDOJDLKOG.Count)
		{
			NBFDOJDLKOG.Add(ALGKOGOMIEA((byte[])NBFDOJDLKOG[NBFDOJDLKOG.Count - 1]));
		}
		return (byte[])NBFDOJDLKOG[IDHLPOFDLKJ];
	}

	protected virtual void KJDEGFKDGJM()
	{
		NLCDIHHEBOJ(MJHCJBDJJCL(LMOACJPPJBE(++NLLGAOKALPO)));
		CKJIDGLLODB = 0;
	}

	protected virtual void DGCFAFENCDJ(byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		AJLDFGNHDCA.OONDALLFPOP(BILGCJNPJGJ, EMAKNGBIFDC, 16, "Output buffer too short");
		if (MAEALKEJALK)
		{
			FHLALGENPPH(ACJABBEGOPC, FNEEHGKPFKC);
			JAEBHBFGJAD = 0;
		}
		FHLALGENPPH(MGEOKLAMHCN, MJHCJBDJJCL(LMOACJPPJBE(++DBHPACJIGLK)));
		FHLALGENPPH(FNEEHGKPFKC, MGEOKLAMHCN);
		MGCHMFBDNPA.DPACJDFHLKB(FNEEHGKPFKC, 0, FNEEHGKPFKC, 0);
		FHLALGENPPH(FNEEHGKPFKC, MGEOKLAMHCN);
		Array.Copy(FNEEHGKPFKC, 0, BILGCJNPJGJ, EMAKNGBIFDC, 16);
		if (!MAEALKEJALK)
		{
			FHLALGENPPH(ACJABBEGOPC, FNEEHGKPFKC);
			Array.Copy(FNEEHGKPFKC, 16, FNEEHGKPFKC, 0, DLFPGGOCGNE);
			JAEBHBFGJAD = DLFPGGOCGNE;
		}
	}

	protected virtual void OMOKOKFNBKI(bool JEMGAHCJPEA)
	{
		DCJIFDJNMJJ.OMOKOKFNBKI();
		MGCHMFBDNPA.OMOKOKFNBKI();
		BOPEPLONIFL(OMCNIAEHHOO);
		BOPEPLONIFL(FNEEHGKPFKC);
		CKJIDGLLODB = 0;
		JAEBHBFGJAD = 0;
		NLLGAOKALPO = 0L;
		DBHPACJIGLK = 0L;
		BOPEPLONIFL(FECAHJECDKM);
		BOPEPLONIFL(LIMGHFNPACK);
		Array.Copy(NGOIJMFCCBI, 0, MGEOKLAMHCN, 0, 16);
		BOPEPLONIFL(ACJABBEGOPC);
		if (JEMGAHCJPEA)
		{
			GIMGNHOKFLA = null;
		}
		if (JOMGFBIBFNH != null)
		{
			JCKGDHGGKEH(JOMGFBIBFNH, 0, JOMGFBIBFNH.Length);
		}
	}

	protected virtual void NLCDIHHEBOJ(byte[] PJFHFFBALEI)
	{
		FHLALGENPPH(FECAHJECDKM, PJFHFFBALEI);
		FHLALGENPPH(OMCNIAEHHOO, FECAHJECDKM);
		DCJIFDJNMJJ.DPACJDFHLKB(OMCNIAEHHOO, 0, OMCNIAEHHOO, 0);
		FHLALGENPPH(LIMGHFNPACK, OMCNIAEHHOO);
	}

	protected static byte[] ALGKOGOMIEA(byte[] OJEJPICFOOJ)
	{
		byte[] array = new byte[16];
		int num = DOKHFLENGLF(OJEJPICFOOJ, array);
		array[15] ^= (byte)(135 >> (1 - num << 3));
		return array;
	}

	protected static void LCJNOIADBIE(byte[] OJEJPICFOOJ, int FADJPCHMMBH)
	{
		OJEJPICFOOJ[FADJPCHMMBH] = 128;
		while (++FADJPCHMMBH < 16)
		{
			OJEJPICFOOJ[FADJPCHMMBH] = 0;
		}
	}

	protected static int LMOACJPPJBE(long AMFCENFNAJJ)
	{
		if (AMFCENFNAJJ == 0)
		{
			return 64;
		}
		int num = 0;
		ulong num2 = (ulong)AMFCENFNAJJ;
		while ((num2 & 1) == 0)
		{
			num++;
			num2 >>= 1;
		}
		return num;
	}

	protected static int DOKHFLENGLF(byte[] OJEJPICFOOJ, byte[] BILGCJNPJGJ)
	{
		int num = 16;
		uint num2 = 0u;
		while (--num >= 0)
		{
			uint num3 = OJEJPICFOOJ[num];
			BILGCJNPJGJ[num] = (byte)((num3 << 1) | num2);
			num2 = (num3 >> 7) & 1u;
		}
		return (int)num2;
	}

	protected static void FHLALGENPPH(byte[] OJEJPICFOOJ, byte[] HIMINGHNIKN)
	{
		for (int num = 15; num >= 0; num--)
		{
			OJEJPICFOOJ[num] ^= HIMINGHNIKN[num];
		}
	}
}
