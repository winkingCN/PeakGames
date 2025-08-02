using System;
using System.Collections;
using System.IO;

public abstract class KINEBFNENMB
{
	public static readonly byte[] JBCONIFELBM = new byte[0];

	public static readonly short[] CMDAJBFHCNK = new short[0];

	public static readonly int[] NEJPMEDGHDN = new int[0];

	public static readonly long[] BEGIDIOLGPE = new long[0];

	internal static readonly byte[] CKMGGIHOGCI = new byte[4] { 67, 76, 78, 84 };

	internal static readonly byte[] MEOEODKCGIG = new byte[4] { 83, 82, 86, 82 };

	internal static readonly byte[][] JNINCJAAHHL = NICNNHJKGJB();

	public static void PMEHMKFPAEC(int PLCFEOMGCFK)
	{
		if (!EIEEEIONBCO(PLCFEOMGCFK))
		{
			throw new DEIDBCPPCMB(80);
		}
	}

	public static void PMEHMKFPAEC(long PLCFEOMGCFK)
	{
		if (!EIEEEIONBCO(PLCFEOMGCFK))
		{
			throw new DEIDBCPPCMB(80);
		}
	}

	public static void AKGIEBIEJJL(int PLCFEOMGCFK)
	{
		if (!BPOIEAFILAH(PLCFEOMGCFK))
		{
			throw new DEIDBCPPCMB(80);
		}
	}

	public static void AKGIEBIEJJL(long PLCFEOMGCFK)
	{
		if (!BPOIEAFILAH(PLCFEOMGCFK))
		{
			throw new DEIDBCPPCMB(80);
		}
	}

	public static void CJIFBMOJIBB(int PLCFEOMGCFK)
	{
		if (!DGOGLEPIPPL(PLCFEOMGCFK))
		{
			throw new DEIDBCPPCMB(80);
		}
	}

	public static void CJIFBMOJIBB(long PLCFEOMGCFK)
	{
		if (!DGOGLEPIPPL(PLCFEOMGCFK))
		{
			throw new DEIDBCPPCMB(80);
		}
	}

	public static void MJDEAOEBLKD(long PLCFEOMGCFK)
	{
		if (!FHAOAMOHJIK(PLCFEOMGCFK))
		{
			throw new DEIDBCPPCMB(80);
		}
	}

	public static void HBCEIMFGIND(long PLCFEOMGCFK)
	{
		if (!EOHMFJCDPEA(PLCFEOMGCFK))
		{
			throw new DEIDBCPPCMB(80);
		}
	}

	public static void HEEBAHPCDNA(long PLCFEOMGCFK)
	{
		if (!KNONGDKPGIF(PLCFEOMGCFK))
		{
			throw new DEIDBCPPCMB(80);
		}
	}

	public static bool EIEEEIONBCO(int PLCFEOMGCFK)
	{
		return (PLCFEOMGCFK & 0xFF) == PLCFEOMGCFK;
	}

	public static bool EIEEEIONBCO(long PLCFEOMGCFK)
	{
		return (PLCFEOMGCFK & 0xFF) == PLCFEOMGCFK;
	}

	public static bool BPOIEAFILAH(int PLCFEOMGCFK)
	{
		return (PLCFEOMGCFK & 0xFFFF) == PLCFEOMGCFK;
	}

	public static bool BPOIEAFILAH(long PLCFEOMGCFK)
	{
		return (PLCFEOMGCFK & 0xFFFF) == PLCFEOMGCFK;
	}

	public static bool DGOGLEPIPPL(int PLCFEOMGCFK)
	{
		return (PLCFEOMGCFK & 0xFFFFFF) == PLCFEOMGCFK;
	}

	public static bool DGOGLEPIPPL(long PLCFEOMGCFK)
	{
		return (PLCFEOMGCFK & 0xFFFFFF) == PLCFEOMGCFK;
	}

	public static bool FHAOAMOHJIK(long PLCFEOMGCFK)
	{
		return (PLCFEOMGCFK & 0xFFFFFFFFu) == PLCFEOMGCFK;
	}

	public static bool EOHMFJCDPEA(long PLCFEOMGCFK)
	{
		return (PLCFEOMGCFK & 0xFFFFFFFFFFFFL) == PLCFEOMGCFK;
	}

	public static bool KNONGDKPGIF(long PLCFEOMGCFK)
	{
		return true;
	}

	public static bool NFEADLBGDGE(CGDEGBGOKJO MBEMNOCDDBC)
	{
		return MBEMNOCDDBC.PJJKOIEAGJN.NFEADLBGDGE;
	}

	public static bool IJOEFFKABJB(OBDIBELBBEO DFCJKBHFPMG)
	{
		return OBDIBELBBEO.FINBKBPMNOH.BMJPEMBKPII(DFCJKBHFPMG.EMPACBICMIM());
	}

	public static bool IJOEFFKABJB(CGDEGBGOKJO MBEMNOCDDBC)
	{
		return IJOEFFKABJB(MBEMNOCDDBC.PJJKOIEAGJN);
	}

	public static bool OHGCLELCPMD(OBDIBELBBEO DFCJKBHFPMG)
	{
		return OBDIBELBBEO.JIBPNECGBPK.BMJPEMBKPII(DFCJKBHFPMG.EMPACBICMIM());
	}

	public static bool OHGCLELCPMD(CGDEGBGOKJO MBEMNOCDDBC)
	{
		return OHGCLELCPMD(MBEMNOCDDBC.PJJKOIEAGJN);
	}

	public static void JBOHOOBEPAM(byte PLCFEOMGCFK, Stream BILGCJNPJGJ)
	{
		BILGCJNPJGJ.WriteByte(PLCFEOMGCFK);
	}

	public static void JBOHOOBEPAM(byte PLCFEOMGCFK, byte[] GHPCHPOHELF, int IBNDGNOIEEF)
	{
		GHPCHPOHELF[IBNDGNOIEEF] = PLCFEOMGCFK;
	}

	public static void PGBAOHFKNHN(int PLCFEOMGCFK, Stream BILGCJNPJGJ)
	{
		BILGCJNPJGJ.WriteByte((byte)(PLCFEOMGCFK >> 8));
		BILGCJNPJGJ.WriteByte((byte)PLCFEOMGCFK);
	}

	public static void PGBAOHFKNHN(int PLCFEOMGCFK, byte[] GHPCHPOHELF, int IBNDGNOIEEF)
	{
		GHPCHPOHELF[IBNDGNOIEEF] = (byte)(PLCFEOMGCFK >> 8);
		GHPCHPOHELF[IBNDGNOIEEF + 1] = (byte)PLCFEOMGCFK;
	}

	public static void HKPEAEDPGAD(int PLCFEOMGCFK, Stream BILGCJNPJGJ)
	{
		BILGCJNPJGJ.WriteByte((byte)(PLCFEOMGCFK >> 16));
		BILGCJNPJGJ.WriteByte((byte)(PLCFEOMGCFK >> 8));
		BILGCJNPJGJ.WriteByte((byte)PLCFEOMGCFK);
	}

	public static void HKPEAEDPGAD(int PLCFEOMGCFK, byte[] GHPCHPOHELF, int IBNDGNOIEEF)
	{
		GHPCHPOHELF[IBNDGNOIEEF] = (byte)(PLCFEOMGCFK >> 16);
		GHPCHPOHELF[IBNDGNOIEEF + 1] = (byte)(PLCFEOMGCFK >> 8);
		GHPCHPOHELF[IBNDGNOIEEF + 2] = (byte)PLCFEOMGCFK;
	}

	public static void FOBOHGGJHJA(long PLCFEOMGCFK, Stream BILGCJNPJGJ)
	{
		BILGCJNPJGJ.WriteByte((byte)(PLCFEOMGCFK >> 24));
		BILGCJNPJGJ.WriteByte((byte)(PLCFEOMGCFK >> 16));
		BILGCJNPJGJ.WriteByte((byte)(PLCFEOMGCFK >> 8));
		BILGCJNPJGJ.WriteByte((byte)PLCFEOMGCFK);
	}

	public static void FOBOHGGJHJA(long PLCFEOMGCFK, byte[] GHPCHPOHELF, int IBNDGNOIEEF)
	{
		GHPCHPOHELF[IBNDGNOIEEF] = (byte)(PLCFEOMGCFK >> 24);
		GHPCHPOHELF[IBNDGNOIEEF + 1] = (byte)(PLCFEOMGCFK >> 16);
		GHPCHPOHELF[IBNDGNOIEEF + 2] = (byte)(PLCFEOMGCFK >> 8);
		GHPCHPOHELF[IBNDGNOIEEF + 3] = (byte)PLCFEOMGCFK;
	}

	public static void NLMGANLNJDC(long PLCFEOMGCFK, Stream BILGCJNPJGJ)
	{
		BILGCJNPJGJ.WriteByte((byte)(PLCFEOMGCFK >> 40));
		BILGCJNPJGJ.WriteByte((byte)(PLCFEOMGCFK >> 32));
		BILGCJNPJGJ.WriteByte((byte)(PLCFEOMGCFK >> 24));
		BILGCJNPJGJ.WriteByte((byte)(PLCFEOMGCFK >> 16));
		BILGCJNPJGJ.WriteByte((byte)(PLCFEOMGCFK >> 8));
		BILGCJNPJGJ.WriteByte((byte)PLCFEOMGCFK);
	}

	public static void NLMGANLNJDC(long PLCFEOMGCFK, byte[] GHPCHPOHELF, int IBNDGNOIEEF)
	{
		GHPCHPOHELF[IBNDGNOIEEF] = (byte)(PLCFEOMGCFK >> 40);
		GHPCHPOHELF[IBNDGNOIEEF + 1] = (byte)(PLCFEOMGCFK >> 32);
		GHPCHPOHELF[IBNDGNOIEEF + 2] = (byte)(PLCFEOMGCFK >> 24);
		GHPCHPOHELF[IBNDGNOIEEF + 3] = (byte)(PLCFEOMGCFK >> 16);
		GHPCHPOHELF[IBNDGNOIEEF + 4] = (byte)(PLCFEOMGCFK >> 8);
		GHPCHPOHELF[IBNDGNOIEEF + 5] = (byte)PLCFEOMGCFK;
	}

	public static void JCMFNDAOIPC(long PLCFEOMGCFK, Stream BILGCJNPJGJ)
	{
		BILGCJNPJGJ.WriteByte((byte)(PLCFEOMGCFK >> 56));
		BILGCJNPJGJ.WriteByte((byte)(PLCFEOMGCFK >> 48));
		BILGCJNPJGJ.WriteByte((byte)(PLCFEOMGCFK >> 40));
		BILGCJNPJGJ.WriteByte((byte)(PLCFEOMGCFK >> 32));
		BILGCJNPJGJ.WriteByte((byte)(PLCFEOMGCFK >> 24));
		BILGCJNPJGJ.WriteByte((byte)(PLCFEOMGCFK >> 16));
		BILGCJNPJGJ.WriteByte((byte)(PLCFEOMGCFK >> 8));
		BILGCJNPJGJ.WriteByte((byte)PLCFEOMGCFK);
	}

	public static void JCMFNDAOIPC(long PLCFEOMGCFK, byte[] GHPCHPOHELF, int IBNDGNOIEEF)
	{
		GHPCHPOHELF[IBNDGNOIEEF] = (byte)(PLCFEOMGCFK >> 56);
		GHPCHPOHELF[IBNDGNOIEEF + 1] = (byte)(PLCFEOMGCFK >> 48);
		GHPCHPOHELF[IBNDGNOIEEF + 2] = (byte)(PLCFEOMGCFK >> 40);
		GHPCHPOHELF[IBNDGNOIEEF + 3] = (byte)(PLCFEOMGCFK >> 32);
		GHPCHPOHELF[IBNDGNOIEEF + 4] = (byte)(PLCFEOMGCFK >> 24);
		GHPCHPOHELF[IBNDGNOIEEF + 5] = (byte)(PLCFEOMGCFK >> 16);
		GHPCHPOHELF[IBNDGNOIEEF + 6] = (byte)(PLCFEOMGCFK >> 8);
		GHPCHPOHELF[IBNDGNOIEEF + 7] = (byte)PLCFEOMGCFK;
	}

	public static void GECPGLGLIBE(byte[] GHPCHPOHELF, Stream BILGCJNPJGJ)
	{
		JBOHOOBEPAM((byte)GHPCHPOHELF.Length, BILGCJNPJGJ);
		BILGCJNPJGJ.Write(GHPCHPOHELF, 0, GHPCHPOHELF.Length);
	}

	public static void HIPJBHBLGEI(byte[] GHPCHPOHELF, Stream BILGCJNPJGJ)
	{
		PGBAOHFKNHN(GHPCHPOHELF.Length, BILGCJNPJGJ);
		BILGCJNPJGJ.Write(GHPCHPOHELF, 0, GHPCHPOHELF.Length);
	}

	public static void GHMOBMODGDF(byte[] GHPCHPOHELF, Stream BILGCJNPJGJ)
	{
		HKPEAEDPGAD(GHPCHPOHELF.Length, BILGCJNPJGJ);
		BILGCJNPJGJ.Write(GHPCHPOHELF, 0, GHPCHPOHELF.Length);
	}

	public static void EGBEIPHFCJG(byte[] EGDMPPLKLDG, Stream BILGCJNPJGJ)
	{
		BILGCJNPJGJ.Write(EGDMPPLKLDG, 0, EGDMPPLKLDG.Length);
	}

	public static void EGBEIPHFCJG(byte[] EGDMPPLKLDG, byte[] GHPCHPOHELF, int IBNDGNOIEEF)
	{
		for (int i = 0; i < EGDMPPLKLDG.Length; i++)
		{
			JBOHOOBEPAM(EGDMPPLKLDG[i], GHPCHPOHELF, IBNDGNOIEEF);
			IBNDGNOIEEF++;
		}
	}

	public static void NKEAKKGFPGB(byte[] EGDMPPLKLDG, Stream BILGCJNPJGJ)
	{
		PMEHMKFPAEC(EGDMPPLKLDG.Length);
		JBOHOOBEPAM((byte)EGDMPPLKLDG.Length, BILGCJNPJGJ);
		EGBEIPHFCJG(EGDMPPLKLDG, BILGCJNPJGJ);
	}

	public static void NKEAKKGFPGB(byte[] EGDMPPLKLDG, byte[] GHPCHPOHELF, int IBNDGNOIEEF)
	{
		PMEHMKFPAEC(EGDMPPLKLDG.Length);
		JBOHOOBEPAM((byte)EGDMPPLKLDG.Length, GHPCHPOHELF, IBNDGNOIEEF);
		EGBEIPHFCJG(EGDMPPLKLDG, GHPCHPOHELF, IBNDGNOIEEF + 1);
	}

	public static void KKCEAJFDHDF(int[] EGDMPPLKLDG, Stream BILGCJNPJGJ)
	{
		for (int i = 0; i < EGDMPPLKLDG.Length; i++)
		{
			PGBAOHFKNHN(EGDMPPLKLDG[i], BILGCJNPJGJ);
		}
	}

	public static void KKCEAJFDHDF(int[] EGDMPPLKLDG, byte[] GHPCHPOHELF, int IBNDGNOIEEF)
	{
		for (int i = 0; i < EGDMPPLKLDG.Length; i++)
		{
			PGBAOHFKNHN(EGDMPPLKLDG[i], GHPCHPOHELF, IBNDGNOIEEF);
			IBNDGNOIEEF += 2;
		}
	}

	public static void KGADCPCFKIN(int[] EGDMPPLKLDG, Stream BILGCJNPJGJ)
	{
		int pLCFEOMGCFK = 2 * EGDMPPLKLDG.Length;
		AKGIEBIEJJL(pLCFEOMGCFK);
		PGBAOHFKNHN(pLCFEOMGCFK, BILGCJNPJGJ);
		KKCEAJFDHDF(EGDMPPLKLDG, BILGCJNPJGJ);
	}

	public static void KGADCPCFKIN(int[] EGDMPPLKLDG, byte[] GHPCHPOHELF, int IBNDGNOIEEF)
	{
		int pLCFEOMGCFK = 2 * EGDMPPLKLDG.Length;
		AKGIEBIEJJL(pLCFEOMGCFK);
		PGBAOHFKNHN(pLCFEOMGCFK, GHPCHPOHELF, IBNDGNOIEEF);
		KKCEAJFDHDF(EGDMPPLKLDG, GHPCHPOHELF, IBNDGNOIEEF + 2);
	}

	public static byte[] HICBNHCILFB(byte[] GHPCHPOHELF)
	{
		PMEHMKFPAEC(GHPCHPOHELF.Length);
		return NOGCEBKPPJE.JLIDOPNDFBO(GHPCHPOHELF, (byte)GHPCHPOHELF.Length);
	}

	public static byte[] CKGMDCDMKIJ(byte[] EGDMPPLKLDG)
	{
		byte[] array = new byte[1 + EGDMPPLKLDG.Length];
		NKEAKKGFPGB(EGDMPPLKLDG, array, 0);
		return array;
	}

	public static byte[] FMONAEDILAB(int[] EGDMPPLKLDG)
	{
		int num = 2 * EGDMPPLKLDG.Length;
		byte[] array = new byte[2 + num];
		KGADCPCFKIN(EGDMPPLKLDG, array, 0);
		return array;
	}

	public static byte HEEOKPLLJMG(Stream MOPCLEEGDFB)
	{
		int num = MOPCLEEGDFB.ReadByte();
		if (num < 0)
		{
			throw new EndOfStreamException();
		}
		return (byte)num;
	}

	public static byte HEEOKPLLJMG(byte[] GHPCHPOHELF, int IBNDGNOIEEF)
	{
		return GHPCHPOHELF[IBNDGNOIEEF];
	}

	public static int DMHJEBHACNN(Stream MOPCLEEGDFB)
	{
		int num = MOPCLEEGDFB.ReadByte();
		int num2 = MOPCLEEGDFB.ReadByte();
		if (num2 < 0)
		{
			throw new EndOfStreamException();
		}
		return (num << 8) | num2;
	}

	public static int DMHJEBHACNN(byte[] GHPCHPOHELF, int IBNDGNOIEEF)
	{
		uint num = (uint)(GHPCHPOHELF[IBNDGNOIEEF] << 8);
		return (int)(num | GHPCHPOHELF[++IBNDGNOIEEF]);
	}

	public static int MFIAOJHGMHG(Stream MOPCLEEGDFB)
	{
		int num = MOPCLEEGDFB.ReadByte();
		int num2 = MOPCLEEGDFB.ReadByte();
		int num3 = MOPCLEEGDFB.ReadByte();
		if (num3 < 0)
		{
			throw new EndOfStreamException();
		}
		return (num << 16) | (num2 << 8) | num3;
	}

	public static int MFIAOJHGMHG(byte[] GHPCHPOHELF, int IBNDGNOIEEF)
	{
		uint num = (uint)(GHPCHPOHELF[IBNDGNOIEEF] << 16);
		num |= (uint)(GHPCHPOHELF[++IBNDGNOIEEF] << 8);
		return (int)(num | GHPCHPOHELF[++IBNDGNOIEEF]);
	}

	public static long FBOFKNIKMFC(Stream MOPCLEEGDFB)
	{
		int num = MOPCLEEGDFB.ReadByte();
		int num2 = MOPCLEEGDFB.ReadByte();
		int num3 = MOPCLEEGDFB.ReadByte();
		int num4 = MOPCLEEGDFB.ReadByte();
		if (num4 < 0)
		{
			throw new EndOfStreamException();
		}
		return (uint)((num << 24) | (num2 << 16) | (num3 << 8) | num4);
	}

	public static long FBOFKNIKMFC(byte[] GHPCHPOHELF, int IBNDGNOIEEF)
	{
		uint num = (uint)(GHPCHPOHELF[IBNDGNOIEEF] << 24);
		num |= (uint)(GHPCHPOHELF[++IBNDGNOIEEF] << 16);
		num |= (uint)(GHPCHPOHELF[++IBNDGNOIEEF] << 8);
		num |= GHPCHPOHELF[++IBNDGNOIEEF];
		return num;
	}

	public static long GIDOBFPJMCJ(Stream MOPCLEEGDFB)
	{
		int num = MFIAOJHGMHG(MOPCLEEGDFB);
		int num2 = MFIAOJHGMHG(MOPCLEEGDFB);
		return ((num & 0xFFFFFFFFu) << 24) | (num2 & 0xFFFFFFFFu);
	}

	public static long GIDOBFPJMCJ(byte[] GHPCHPOHELF, int IBNDGNOIEEF)
	{
		int num = MFIAOJHGMHG(GHPCHPOHELF, IBNDGNOIEEF);
		int num2 = MFIAOJHGMHG(GHPCHPOHELF, IBNDGNOIEEF + 3);
		return ((num & 0xFFFFFFFFu) << 24) | (num2 & 0xFFFFFFFFu);
	}

	public static byte[] FAPOJPGMEMJ(int EOFAGACBNFP, Stream MOPCLEEGDFB)
	{
		if (EOFAGACBNFP < 1)
		{
			return JBCONIFELBM;
		}
		byte[] array = new byte[EOFAGACBNFP];
		int num = NPBFDBCHIGL.PCNDKGFHPJN(MOPCLEEGDFB, array);
		if (num == 0)
		{
			return null;
		}
		if (num != EOFAGACBNFP)
		{
			throw new EndOfStreamException();
		}
		return array;
	}

	public static byte[] PCNDKGFHPJN(int EOFAGACBNFP, Stream MOPCLEEGDFB)
	{
		if (EOFAGACBNFP < 1)
		{
			return JBCONIFELBM;
		}
		byte[] array = new byte[EOFAGACBNFP];
		if (EOFAGACBNFP != NPBFDBCHIGL.PCNDKGFHPJN(MOPCLEEGDFB, array))
		{
			throw new EndOfStreamException();
		}
		return array;
	}

	public static void PCNDKGFHPJN(byte[] GHPCHPOHELF, Stream MOPCLEEGDFB)
	{
		if (NPBFDBCHIGL.PCNDKGFHPJN(MOPCLEEGDFB, GHPCHPOHELF, 0, GHPCHPOHELF.Length) < GHPCHPOHELF.Length)
		{
			throw new EndOfStreamException();
		}
	}

	public static byte[] IEIMBOADGLL(Stream MOPCLEEGDFB)
	{
		byte b = HEEOKPLLJMG(MOPCLEEGDFB);
		byte[] array = new byte[b];
		PCNDKGFHPJN(array, MOPCLEEGDFB);
		return array;
	}

	public static byte[] HDGCNMILKAA(Stream MOPCLEEGDFB)
	{
		int num = DMHJEBHACNN(MOPCLEEGDFB);
		byte[] array = new byte[num];
		PCNDKGFHPJN(array, MOPCLEEGDFB);
		return array;
	}

	public static byte[] MCBPCLGJPGF(Stream MOPCLEEGDFB)
	{
		int eOFAGACBNFP = MFIAOJHGMHG(MOPCLEEGDFB);
		return PCNDKGFHPJN(eOFAGACBNFP, MOPCLEEGDFB);
	}

	public static byte[] HACGMELPFGO(int ENMLICFLHAO, Stream MOPCLEEGDFB)
	{
		byte[] array = new byte[ENMLICFLHAO];
		for (int i = 0; i < ENMLICFLHAO; i++)
		{
			array[i] = HEEOKPLLJMG(MOPCLEEGDFB);
		}
		return array;
	}

	public static int[] DNOEBHEJDPG(int ENMLICFLHAO, Stream MOPCLEEGDFB)
	{
		int[] array = new int[ENMLICFLHAO];
		for (int i = 0; i < ENMLICFLHAO; i++)
		{
			array[i] = DMHJEBHACNN(MOPCLEEGDFB);
		}
		return array;
	}

	public static OBDIBELBBEO NGLBPHAOKHO(byte[] GHPCHPOHELF, int IBNDGNOIEEF)
	{
		return OBDIBELBBEO.GHBGCADFLFB(GHPCHPOHELF[IBNDGNOIEEF], GHPCHPOHELF[IBNDGNOIEEF + 1]);
	}

	public static OBDIBELBBEO NGLBPHAOKHO(Stream MOPCLEEGDFB)
	{
		int pNMGIIIFEGM = MOPCLEEGDFB.ReadByte();
		int num = MOPCLEEGDFB.ReadByte();
		if (num < 0)
		{
			throw new EndOfStreamException();
		}
		return OBDIBELBBEO.GHBGCADFLFB(pNMGIIIFEGM, num);
	}

	public static int LBFNBPLKGIM(byte[] GHPCHPOHELF, int IBNDGNOIEEF)
	{
		return (GHPCHPOHELF[IBNDGNOIEEF] << 8) | GHPCHPOHELF[IBNDGNOIEEF + 1];
	}

	public static int LBFNBPLKGIM(Stream MOPCLEEGDFB)
	{
		int num = MOPCLEEGDFB.ReadByte();
		int num2 = MOPCLEEGDFB.ReadByte();
		if (num2 < 0)
		{
			throw new EndOfStreamException();
		}
		return (num << 8) | num2;
	}

	public static EDOEBJJFOBM MDFMIPABIOM(byte[] NJPMJNHGDNE)
	{
		MemoryStream memoryStream = new MemoryStream(NJPMJNHGDNE, false);
		AOKAOIHEKIH aOKAOIHEKIH = new AOKAOIHEKIH(memoryStream, NJPMJNHGDNE.Length);
		EDOEBJJFOBM eDOEBJJFOBM = aOKAOIHEKIH.DMHLIGLGJGI();
		if (eDOEBJJFOBM == null)
		{
			throw new DEIDBCPPCMB(50);
		}
		if (memoryStream.Position != memoryStream.Length)
		{
			throw new DEIDBCPPCMB(50);
		}
		return eDOEBJJFOBM;
	}

	public static EDOEBJJFOBM LCEOAGADAFB(byte[] NJPMJNHGDNE)
	{
		EDOEBJJFOBM eDOEBJJFOBM = MDFMIPABIOM(NJPMJNHGDNE);
		byte[] mNIMEAMHNMI = eDOEBJJFOBM.PPCPBIEGJKM("DER");
		if (!NOGCEBKPPJE.ICKLINNFHKK(mNIMEAMHNMI, NJPMJNHGDNE))
		{
			throw new DEIDBCPPCMB(50);
		}
		return eDOEBJJFOBM;
	}

	public static void FDLKFNBAEBP(byte[] GHPCHPOHELF, int IBNDGNOIEEF)
	{
		int num = (int)(MBHFAHIPABH.NGABLLHKHJJ() / 1000);
		GHPCHPOHELF[IBNDGNOIEEF] = (byte)(num >> 24);
		GHPCHPOHELF[IBNDGNOIEEF + 1] = (byte)(num >> 16);
		GHPCHPOHELF[IBNDGNOIEEF + 2] = (byte)(num >> 8);
		GHPCHPOHELF[IBNDGNOIEEF + 3] = (byte)num;
	}

	public static void PPCDKILMGFD(OBDIBELBBEO DFCJKBHFPMG, Stream BILGCJNPJGJ)
	{
		BILGCJNPJGJ.WriteByte((byte)DFCJKBHFPMG.LHJCOHDLJAO);
		BILGCJNPJGJ.WriteByte((byte)DFCJKBHFPMG.JBFBIHMBNDA);
	}

	public static void PPCDKILMGFD(OBDIBELBBEO DFCJKBHFPMG, byte[] GHPCHPOHELF, int IBNDGNOIEEF)
	{
		GHPCHPOHELF[IBNDGNOIEEF] = (byte)DFCJKBHFPMG.LHJCOHDLJAO;
		GHPCHPOHELF[IBNDGNOIEEF + 1] = (byte)DFCJKBHFPMG.JBFBIHMBNDA;
	}

	public static IList IDCKEKJKMMF()
	{
		return BKHKGIBCHMK(new FBMKOGABPFL(2, 2));
	}

	public static IList OAHOCHINHOL()
	{
		return BKHKGIBCHMK(new FBMKOGABPFL(2, 3));
	}

	public static IList ELNLEELJJCJ()
	{
		return BKHKGIBCHMK(new FBMKOGABPFL(2, 1));
	}

	public static byte[] MHMMGPFEAJM(IDictionary GPFBAMMMLIA, int LJCOCHEBHLD)
	{
		return (GPFBAMMMLIA != null) ? ((byte[])GPFBAMMMLIA[LJCOCHEBHLD]) : null;
	}

	public static IList EHFEAFLEMHN()
	{
		byte[] array = new byte[5] { 2, 3, 4, 5, 6 };
		byte[] array2 = new byte[3] { 1, 2, 3 };
		IList list = LHFGHNFJIKM.PPPFFFBMGML();
		for (int i = 0; i < array2.Length; i++)
		{
			for (int j = 0; j < array.Length; j++)
			{
				list.Add(new FBMKOGABPFL(array[j], array2[i]));
			}
		}
		return list;
	}

	public static FBMKOGABPFL CBMIGMCGDJL(CGDEGBGOKJO MBEMNOCDDBC, IAJODODPMMG OPOKEEHGHFD)
	{
		FBMKOGABPFL fBMKOGABPFL = null;
		if (OHGCLELCPMD(MBEMNOCDDBC))
		{
			fBMKOGABPFL = OPOKEEHGHFD.GANJGAOCHJL;
			if (fBMKOGABPFL == null)
			{
				throw new DEIDBCPPCMB(80);
			}
		}
		return fBMKOGABPFL;
	}

	public static bool NJLIKBLEEFJ(IDictionary GPFBAMMMLIA, int LJCOCHEBHLD, byte LHIDNPKMPPJ)
	{
		byte[] array = MHMMGPFEAJM(GPFBAMMMLIA, LJCOCHEBHLD);
		if (array == null)
		{
			return false;
		}
		if (array.Length != 0)
		{
			throw new DEIDBCPPCMB(LHIDNPKMPPJ);
		}
		return true;
	}

	public static POBPBLILLLP GABGEDPDOBF(byte[] OEPIOANFJDF, CBKKCJFENJM PPPNGBDMPGG)
	{
		return new IIFHCHFCCDK(OEPIOANFJDF, PPPNGBDMPGG);
	}

	public static bool ABIOLEEPEHN(OBDIBELBBEO ANFOFLFNDAK)
	{
		return OBDIBELBBEO.JIBPNECGBPK.BMJPEMBKPII(ANFOFLFNDAK.EMPACBICMIM());
	}

	public static void HLCHLMCMMGN(IDictionary GPFBAMMMLIA, IList GMLLEBDADDP)
	{
		GPFBAMMMLIA[13] = BGJKMBKECPI(GMLLEBDADDP);
	}

	public static IList HCDNOKDFKIG(IDictionary GPFBAMMMLIA)
	{
		byte[] array = MHMMGPFEAJM(GPFBAMMMLIA, 13);
		return (array != null) ? IOLOLMHKNFE(array) : null;
	}

	public static byte[] BGJKMBKECPI(IList GMLLEBDADDP)
	{
		MemoryStream memoryStream = new MemoryStream();
		CCIJOGKGICD(GMLLEBDADDP, false, memoryStream);
		return memoryStream.ToArray();
	}

	public static IList IOLOLMHKNFE(byte[] NIHLDDGDKGP)
	{
		if (NIHLDDGDKGP == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		MemoryStream memoryStream = new MemoryStream(NIHLDDGDKGP, false);
		IList result = GKPICDDIKHJ(false, memoryStream);
		HEMGBKNMOKB.JILHFDBGNGE(memoryStream);
		return result;
	}

	public static void CCIJOGKGICD(IList GMLLEBDADDP, bool AIPIABIKFFC, Stream BILGCJNPJGJ)
	{
		if (GMLLEBDADDP == null)
		{
			throw new ArgumentNullException("supportedSignatureAlgorithms");
		}
		if (GMLLEBDADDP.Count < 1 || GMLLEBDADDP.Count >= 32768)
		{
			throw new ArgumentException("must have length from 1 to (2^15 - 1)", "supportedSignatureAlgorithms");
		}
		int pLCFEOMGCFK = 2 * GMLLEBDADDP.Count;
		AKGIEBIEJJL(pLCFEOMGCFK);
		PGBAOHFKNHN(pLCFEOMGCFK, BILGCJNPJGJ);
		foreach (FBMKOGABPFL item in GMLLEBDADDP)
		{
			if (!AIPIABIKFFC && item.ACMDKLDPDLB == 0)
			{
				throw new ArgumentException("SignatureAlgorithm.anonymous MUST NOT appear in the signature_algorithms extension");
			}
			item.LMDBBPLCJDM(BILGCJNPJGJ);
		}
	}

	public static IList GKPICDDIKHJ(bool AIPIABIKFFC, Stream MOPCLEEGDFB)
	{
		int num = DMHJEBHACNN(MOPCLEEGDFB);
		if (num < 2 || ((uint)num & (true ? 1u : 0u)) != 0)
		{
			throw new DEIDBCPPCMB(50);
		}
		int num2 = num / 2;
		IList list = LHFGHNFJIKM.PPPFFFBMGML(num2);
		for (int i = 0; i < num2; i++)
		{
			FBMKOGABPFL fBMKOGABPFL = FBMKOGABPFL.DHCLOMIANOE(MOPCLEEGDFB);
			if (!AIPIABIKFFC && fBMKOGABPFL.ACMDKLDPDLB == 0)
			{
				throw new DEIDBCPPCMB(47);
			}
			list.Add(fBMKOGABPFL);
		}
		return list;
	}

	public static void EFCELAHEJPB(IList GMLLEBDADDP, FBMKOGABPFL MAHGCGFNMON)
	{
		if (GMLLEBDADDP == null)
		{
			throw new ArgumentNullException("supportedSignatureAlgorithms");
		}
		if (GMLLEBDADDP.Count < 1 || GMLLEBDADDP.Count >= 32768)
		{
			throw new ArgumentException("must have length from 1 to (2^15 - 1)", "supportedSignatureAlgorithms");
		}
		if (MAHGCGFNMON == null)
		{
			throw new ArgumentNullException("signatureAlgorithm");
		}
		if (MAHGCGFNMON.ACMDKLDPDLB != 0)
		{
			foreach (FBMKOGABPFL item in GMLLEBDADDP)
			{
				if (item.GHMJJKMGKKB == MAHGCGFNMON.GHMJJKMGKKB && item.ACMDKLDPDLB == MAHGCGFNMON.ACMDKLDPDLB)
				{
					return;
				}
			}
		}
		throw new DEIDBCPPCMB(47);
	}

	public static byte[] NHKMLDKHIIH(CGDEGBGOKJO MBEMNOCDDBC, byte[] JPCIJINDHIH, string FEHKBFBPJIF, byte[] HJBOEOOLOOE, int MOFHAKELNPN)
	{
		OBDIBELBBEO oBDIBELBBEO = MBEMNOCDDBC.PJJKOIEAGJN;
		if (oBDIBELBBEO.NFEADLBGDGE)
		{
			throw new InvalidOperationException("No PRF available for SSLv3 session");
		}
		byte[] array = CCGLOIJJMKC.EDHFCNLPGJC(FEHKBFBPJIF);
		byte[] array2 = IDICKILHACN(array, HJBOEOOLOOE);
		int num = MBEMNOCDDBC.HFMNBFOAPOP.BBHJHPLCMGM;
		if (num == 0)
		{
			return LLHKICOHBBC(JPCIJINDHIH, array, array2, MOFHAKELNPN);
		}
		BJLAMONNNDD hABFKBCEIBN = KONCNMLPMAK(num);
		byte[] array3 = new byte[MOFHAKELNPN];
		LPLJINPHGNI(hABFKBCEIBN, JPCIJINDHIH, array2, array3);
		return array3;
	}

	public static byte[] LLHKICOHBBC(byte[] JPCIJINDHIH, string FEHKBFBPJIF, byte[] HJBOEOOLOOE, int MOFHAKELNPN)
	{
		byte[] array = CCGLOIJJMKC.EDHFCNLPGJC(FEHKBFBPJIF);
		byte[] hGAAPIPCFKG = IDICKILHACN(array, HJBOEOOLOOE);
		return LLHKICOHBBC(JPCIJINDHIH, array, hGAAPIPCFKG, MOFHAKELNPN);
	}

	internal static byte[] LLHKICOHBBC(byte[] JPCIJINDHIH, byte[] LEAEMLPICBL, byte[] HGAAPIPCFKG, int MOFHAKELNPN)
	{
		int num = (JPCIJINDHIH.Length + 1) / 2;
		byte[] array = new byte[num];
		byte[] array2 = new byte[num];
		Array.Copy(JPCIJINDHIH, 0, array, 0, num);
		Array.Copy(JPCIJINDHIH, JPCIJINDHIH.Length - num, array2, 0, num);
		byte[] array3 = new byte[MOFHAKELNPN];
		byte[] array4 = new byte[MOFHAKELNPN];
		LPLJINPHGNI(KNADNPDKLGD(1), array, HGAAPIPCFKG, array3);
		LPLJINPHGNI(KNADNPDKLGD(2), array2, HGAAPIPCFKG, array4);
		for (int i = 0; i < MOFHAKELNPN; i++)
		{
			array3[i] ^= array4[i];
		}
		return array3;
	}

	internal static byte[] IDICKILHACN(byte[] MNIMEAMHNMI, byte[] BCIHLCMFAEK)
	{
		byte[] array = new byte[MNIMEAMHNMI.Length + BCIHLCMFAEK.Length];
		Array.Copy(MNIMEAMHNMI, 0, array, 0, MNIMEAMHNMI.Length);
		Array.Copy(BCIHLCMFAEK, 0, array, MNIMEAMHNMI.Length, BCIHLCMFAEK.Length);
		return array;
	}

	internal static void LPLJINPHGNI(BJLAMONNNDD HABFKBCEIBN, byte[] JPCIJINDHIH, byte[] HJBOEOOLOOE, byte[] BILGCJNPJGJ)
	{
		PGNLPNFKAPJ pGNLPNFKAPJ = new PGNLPNFKAPJ(HABFKBCEIBN);
		pGNLPNFKAPJ.DIOELAHNLKJ(new JEMNCGMEABF(JPCIJINDHIH));
		byte[] array = HJBOEOOLOOE;
		int num = HABFKBCEIBN.EEMLLAMENHO();
		int num2 = (BILGCJNPJGJ.Length + num - 1) / num;
		byte[] array2 = new byte[pGNLPNFKAPJ.BKGLOJPPBIG()];
		byte[] array3 = new byte[pGNLPNFKAPJ.BKGLOJPPBIG()];
		for (int i = 0; i < num2; i++)
		{
			pGNLPNFKAPJ.GONEEEFEDGF(array, 0, array.Length);
			pGNLPNFKAPJ.LCNOFBMOHHM(array2, 0);
			array = array2;
			pGNLPNFKAPJ.GONEEEFEDGF(array, 0, array.Length);
			pGNLPNFKAPJ.GONEEEFEDGF(HJBOEOOLOOE, 0, HJBOEOOLOOE.Length);
			pGNLPNFKAPJ.LCNOFBMOHHM(array3, 0);
			Array.Copy(array3, 0, BILGCJNPJGJ, num * i, Math.Min(num, BILGCJNPJGJ.Length - num * i));
		}
	}

	internal static void EPMGOMGGBIE(NGNPCPDMGBC FMFABAKPMLB, int BBIMCMHADFM)
	{
		HLAHBGANIKK hLAHBGANIKK = FMFABAKPMLB.LCNGICNPPPP.GBGIDCHPICA;
		if (hLAHBGANIKK == null)
		{
			return;
		}
		BJHANHIGLGB bJHANHIGLGB = hLAHBGANIKK.GLMCDHHLBOB(HLAHBGANIKK.CCBGCJNNMEA);
		if (bJHANHIGLGB != null)
		{
			FJMKMKNJKOI fJMKMKNJKOI = MNKJKHEBBOA.BJLJCGFMFOO(bJHANHIGLGB);
			int num = fJMKMKNJKOI.MIBPLNJNEGA()[0];
			if ((num & BBIMCMHADFM) != BBIMCMHADFM)
			{
				throw new DEIDBCPPCMB(46);
			}
		}
	}

	internal static byte[] IJLFLBPLJHD(CGDEGBGOKJO MBEMNOCDDBC, int MOFHAKELNPN)
	{
		PDCALMCFKGD pDCALMCFKGD = MBEMNOCDDBC.HFMNBFOAPOP;
		byte[] array = pDCALMCFKGD.EFKBHGKOMBB;
		byte[] array2 = IDICKILHACN(pDCALMCFKGD.NGDLBBHPGPA, pDCALMCFKGD.BABNEJKEAHH);
		if (NFEADLBGDGE(MBEMNOCDDBC))
		{
			return GLPEAFGONKJ(array, array2, MOFHAKELNPN);
		}
		return NHKMLDKHIIH(MBEMNOCDDBC, array, "key expansion", array2, MOFHAKELNPN);
	}

	internal static byte[] GLPEAFGONKJ(byte[] GDOHBDBFNHA, byte[] GECCLOFELEC, int MOFHAKELNPN)
	{
		BJLAMONNNDD bJLAMONNNDD = KNADNPDKLGD(1);
		BJLAMONNNDD bJLAMONNNDD2 = KNADNPDKLGD(2);
		int num = bJLAMONNNDD.EEMLLAMENHO();
		byte[] array = new byte[bJLAMONNNDD2.EEMLLAMENHO()];
		byte[] array2 = new byte[MOFHAKELNPN + num];
		int num2 = 0;
		int num3 = 0;
		while (num3 < MOFHAKELNPN)
		{
			byte[] array3 = JNINCJAAHHL[num2];
			bJLAMONNNDD2.GONEEEFEDGF(array3, 0, array3.Length);
			bJLAMONNNDD2.GONEEEFEDGF(GDOHBDBFNHA, 0, GDOHBDBFNHA.Length);
			bJLAMONNNDD2.GONEEEFEDGF(GECCLOFELEC, 0, GECCLOFELEC.Length);
			bJLAMONNNDD2.LCNOFBMOHHM(array, 0);
			bJLAMONNNDD.GONEEEFEDGF(GDOHBDBFNHA, 0, GDOHBDBFNHA.Length);
			bJLAMONNNDD.GONEEEFEDGF(array, 0, array.Length);
			bJLAMONNNDD.LCNOFBMOHHM(array2, num3);
			num3 += num;
			num2++;
		}
		return NOGCEBKPPJE.EHLHBAMJLNI(array2, 0, MOFHAKELNPN);
	}

	internal static byte[] JOAILMIJAHC(CGDEGBGOKJO MBEMNOCDDBC, byte[] KJIEBMNLANC)
	{
		PDCALMCFKGD pDCALMCFKGD = MBEMNOCDDBC.HFMNBFOAPOP;
		byte[] array = ((!pDCALMCFKGD.EFPCMNGHEHF) ? IDICKILHACN(pDCALMCFKGD.BABNEJKEAHH, pDCALMCFKGD.NGDLBBHPGPA) : pDCALMCFKGD.EPLFAIDNFEH);
		if (NFEADLBGDGE(MBEMNOCDDBC))
		{
			return MJIGIBNOPLC(KJIEBMNLANC, array);
		}
		string fEHKBFBPJIF = ((!pDCALMCFKGD.EFPCMNGHEHF) ? "master secret" : GLLHIDKJDOH.MKLJIMJKLNC);
		return NHKMLDKHIIH(MBEMNOCDDBC, KJIEBMNLANC, fEHKBFBPJIF, array, 48);
	}

	internal static byte[] MJIGIBNOPLC(byte[] KJIEBMNLANC, byte[] GECCLOFELEC)
	{
		BJLAMONNNDD bJLAMONNNDD = KNADNPDKLGD(1);
		BJLAMONNNDD bJLAMONNNDD2 = KNADNPDKLGD(2);
		int num = bJLAMONNNDD.EEMLLAMENHO();
		byte[] array = new byte[bJLAMONNNDD2.EEMLLAMENHO()];
		byte[] array2 = new byte[num * 3];
		int num2 = 0;
		for (int i = 0; i < 3; i++)
		{
			byte[] array3 = JNINCJAAHHL[i];
			bJLAMONNNDD2.GONEEEFEDGF(array3, 0, array3.Length);
			bJLAMONNNDD2.GONEEEFEDGF(KJIEBMNLANC, 0, KJIEBMNLANC.Length);
			bJLAMONNNDD2.GONEEEFEDGF(GECCLOFELEC, 0, GECCLOFELEC.Length);
			bJLAMONNNDD2.LCNOFBMOHHM(array, 0);
			bJLAMONNNDD.GONEEEFEDGF(KJIEBMNLANC, 0, KJIEBMNLANC.Length);
			bJLAMONNNDD.GONEEEFEDGF(array, 0, array.Length);
			bJLAMONNNDD.LCNOFBMOHHM(array2, num2);
			num2 += num;
		}
		return array2;
	}

	internal static byte[] NDGAINDDJCD(CGDEGBGOKJO MBEMNOCDDBC, string FEHKBFBPJIF, byte[] EOPGFGOFODJ)
	{
		if (NFEADLBGDGE(MBEMNOCDDBC))
		{
			return EOPGFGOFODJ;
		}
		PDCALMCFKGD pDCALMCFKGD = MBEMNOCDDBC.HFMNBFOAPOP;
		byte[] jPCIJINDHIH = pDCALMCFKGD.EFKBHGKOMBB;
		int mOFHAKELNPN = pDCALMCFKGD.CJJNIKLMFAI;
		return NHKMLDKHIIH(MBEMNOCDDBC, jPCIJINDHIH, FEHKBFBPJIF, EOPGFGOFODJ, mOFHAKELNPN);
	}

	public static BJLAMONNNDD KNADNPDKLGD(byte JMCLOFPGGNN)
	{
		switch (JMCLOFPGGNN)
		{
		case 1:
			return new DDPKOBCIGDJ();
		case 2:
			return new KALMDEHGEAC();
		case 3:
			return new JAHCGEGGLMA();
		case 4:
			return new AFKIHPLKGEE();
		case 5:
			return new JIDIPOBKBGH();
		case 6:
			return new NLPHAELCKOJ();
		default:
			throw new ArgumentException("unknown HashAlgorithm", "hashAlgorithm");
		}
	}

	public static BJLAMONNNDD KNADNPDKLGD(FBMKOGABPFL MLHHNCOJOFA)
	{
		return (MLHHNCOJOFA != null) ? KNADNPDKLGD(MLHHNCOJOFA.GHMJJKMGKKB) : new JDNANIIIFGM();
	}

	public static BJLAMONNNDD JIDIDNFBFKJ(byte JMCLOFPGGNN, BJLAMONNNDD AIELCDIFLFB)
	{
		switch (JMCLOFPGGNN)
		{
		case 1:
			return new DDPKOBCIGDJ((DDPKOBCIGDJ)AIELCDIFLFB);
		case 2:
			return new KALMDEHGEAC((KALMDEHGEAC)AIELCDIFLFB);
		case 3:
			return new JAHCGEGGLMA((JAHCGEGGLMA)AIELCDIFLFB);
		case 4:
			return new AFKIHPLKGEE((AFKIHPLKGEE)AIELCDIFLFB);
		case 5:
			return new JIDIPOBKBGH((JIDIPOBKBGH)AIELCDIFLFB);
		case 6:
			return new NLPHAELCKOJ((NLPHAELCKOJ)AIELCDIFLFB);
		default:
			throw new ArgumentException("unknown HashAlgorithm", "hashAlgorithm");
		}
	}

	public static BJLAMONNNDD KONCNMLPMAK(int BCEHFMJLEFK)
	{
		if (BCEHFMJLEFK == 0)
		{
			return new JDNANIIIFGM();
		}
		return KNADNPDKLGD(NOMPGNMMDBO(BCEHFMJLEFK));
	}

	public static BJLAMONNNDD IPCOJMNLFMC(int BCEHFMJLEFK, BJLAMONNNDD AIELCDIFLFB)
	{
		if (BCEHFMJLEFK == 0)
		{
			return new JDNANIIIFGM((JDNANIIIFGM)AIELCDIFLFB);
		}
		return JIDIDNFBFKJ(NOMPGNMMDBO(BCEHFMJLEFK), AIELCDIFLFB);
	}

	public static byte NOMPGNMMDBO(int BCEHFMJLEFK)
	{
		switch (BCEHFMJLEFK)
		{
		case 0:
			throw new ArgumentException("legacy PRF not a valid algorithm", "prfAlgorithm");
		case 1:
			return 4;
		case 2:
			return 5;
		default:
			throw new ArgumentException("unknown PrfAlgorithm", "prfAlgorithm");
		}
	}

	public static KLKJHFKJLEM FKPJBANDKKF(byte JMCLOFPGGNN)
	{
		switch (JMCLOFPGGNN)
		{
		case 1:
			return NLPPJKFFBON.HCEBKEDMKGI;
		case 2:
			return FBFBJFFFNOF.MEBPJCLMCDA;
		case 3:
			return HHKLFIFJNFO.NGAKIGLLNMJ;
		case 4:
			return HHKLFIFJNFO.OKLEKJJIGME;
		case 5:
			return HHKLFIFJNFO.EJIHFCHFMLO;
		case 6:
			return HHKLFIFJNFO.HBLLHCKNOKB;
		default:
			throw new ArgumentException("unknown HashAlgorithm", "hashAlgorithm");
		}
	}

	internal static short EEKDEBDNIAE(PAJJBHMEFKE HDJIOCGDIKM, PAJJBHMEFKE EIMEPDCAJLE)
	{
		if (HDJIOCGDIKM.DHIKCKFGKID)
		{
			return -1;
		}
		NGNPCPDMGBC nGNPCPDMGBC = HDJIOCGDIKM.IGGCPKOFOMP(0);
		MHBCFNELGOJ mJHHKCCPFEE = nGNPCPDMGBC.KBGJHCMPCGH;
		try
		{
			COEMJAGOFJJ cOEMJAGOFJJ = JHGHHFDFJEG.HCBKCKKDGCP(mJHHKCCPFEE);
			if (cOEMJAGOFJJ.CCLHEKOIIKM)
			{
				throw new DEIDBCPPCMB(80);
			}
			if (cOEMJAGOFJJ is PLGGNEJEIIP)
			{
				EPMGOMGGBIE(nGNPCPDMGBC, 128);
				return 1;
			}
			if (cOEMJAGOFJJ is NFJLHCNCCHB)
			{
				EPMGOMGGBIE(nGNPCPDMGBC, 128);
				return 2;
			}
			if (cOEMJAGOFJJ is EGEBOHHBFLK)
			{
				EPMGOMGGBIE(nGNPCPDMGBC, 128);
				return 64;
			}
			throw new DEIDBCPPCMB(43);
		}
		catch (Exception cEDNDOAMNOC)
		{
			throw new DEIDBCPPCMB(43, cEDNDOAMNOC);
		}
	}

	internal static void NBKEFELHCFK(KKMFHDBDNLF EOPGFGOFODJ, IList GMLLEBDADDP)
	{
		if (GMLLEBDADDP == null)
		{
			return;
		}
		foreach (FBMKOGABPFL item in GMLLEBDADDP)
		{
			byte jMCLOFPGGNN = item.GHMJJKMGKKB;
			if (!CHAPPEIIDHD.CCLHEKOIIKM(jMCLOFPGGNN))
			{
				EOPGFGOFODJ.PDDLLDKPKOC(jMCLOFPGGNN);
			}
		}
	}

	public static bool NCAEMEKGHFI(byte FFANOLMCDJD)
	{
		if (FFANOLMCDJD == 1 || FFANOLMCDJD == 2 || FFANOLMCDJD == 64)
		{
			return true;
		}
		return false;
	}

	public static EKFAMINKCJP LMIPNAMCEAJ(byte FFANOLMCDJD)
	{
		switch (FFANOLMCDJD)
		{
		case 2:
			return new KBJEGPDMPNE();
		case 64:
			return new LKIBBJMDILG();
		case 1:
			return new MIKBJEJODHC();
		default:
			throw new ArgumentException("not a type with signing capability", "clientCertificateType");
		}
	}

	private static byte[][] NICNNHJKGJB()
	{
		int num = 10;
		byte[][] array = new byte[num][];
		for (int i = 0; i < num; i++)
		{
			byte[] array2 = new byte[i + 1];
			NOGCEBKPPJE.MEBLOMPDLEJ(array2, (byte)(65 + i));
			array[i] = array2;
		}
		return array;
	}

	private static IList BKHKGIBCHMK(object NEMEKIOEOLC)
	{
		IList list = LHFGHNFJIKM.PPPFFFBMGML(1);
		list.Add(NEMEKIOEOLC);
		return list;
	}

	public static int MCGDLFEECAE(int ANPNEODAJHA)
	{
		switch (LJMKNAKPGEB(ANPNEODAJHA))
		{
		case 10:
		case 11:
		case 15:
		case 16:
		case 17:
		case 18:
		case 19:
		case 20:
		case 102:
		case 103:
		case 104:
			return 2;
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
		case 12:
		case 13:
		case 14:
			return 1;
		case 1:
		case 2:
			return 0;
		default:
			throw new DEIDBCPPCMB(80);
		}
	}

	public static int LJMKNAKPGEB(int ANPNEODAJHA)
	{
		switch (ANPNEODAJHA)
		{
		case 10:
		case 13:
		case 16:
		case 19:
		case 22:
		case 139:
		case 143:
		case 147:
		case 49155:
		case 49160:
		case 49165:
		case 49170:
		case 49175:
		case 49178:
		case 49179:
		case 49180:
		case 49204:
			return 7;
		case 47:
		case 48:
		case 49:
		case 50:
		case 51:
		case 60:
		case 62:
		case 63:
		case 64:
		case 103:
		case 140:
		case 144:
		case 148:
		case 174:
		case 178:
		case 182:
		case 49156:
		case 49161:
		case 49166:
		case 49171:
		case 49176:
		case 49181:
		case 49182:
		case 49183:
		case 49187:
		case 49189:
		case 49191:
		case 49193:
		case 49205:
		case 49207:
			return 8;
		case 49308:
		case 49310:
		case 49316:
		case 49318:
		case 49324:
			return 15;
		case 49312:
		case 49314:
		case 49320:
		case 49322:
		case 49326:
			return 16;
		case 156:
		case 158:
		case 160:
		case 162:
		case 164:
		case 168:
		case 170:
		case 172:
		case 49195:
		case 49197:
		case 49199:
		case 49201:
			return 10;
		case 65280:
		case 65282:
		case 65284:
		case 65296:
		case 65298:
		case 65300:
			return 103;
		case 53:
		case 54:
		case 55:
		case 56:
		case 57:
		case 61:
		case 104:
		case 105:
		case 106:
		case 107:
		case 141:
		case 145:
		case 149:
		case 175:
		case 179:
		case 183:
		case 49157:
		case 49162:
		case 49167:
		case 49172:
		case 49177:
		case 49184:
		case 49185:
		case 49186:
		case 49188:
		case 49190:
		case 49192:
		case 49194:
		case 49206:
		case 49208:
			return 9;
		case 49309:
		case 49311:
		case 49317:
		case 49319:
		case 49325:
			return 17;
		case 49313:
		case 49315:
		case 49321:
		case 49323:
		case 49327:
			return 18;
		case 157:
		case 159:
		case 161:
		case 163:
		case 165:
		case 169:
		case 171:
		case 173:
		case 49196:
		case 49198:
		case 49200:
		case 49202:
			return 11;
		case 65281:
		case 65283:
		case 65285:
		case 65297:
		case 65299:
		case 65301:
			return 104;
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
			return 12;
		case 186:
		case 187:
		case 188:
		case 189:
		case 190:
		case 49266:
		case 49268:
		case 49270:
		case 49272:
		case 49300:
		case 49302:
		case 49304:
		case 49306:
			return 12;
		case 49274:
		case 49276:
		case 49278:
		case 49280:
		case 49282:
		case 49286:
		case 49288:
		case 49290:
		case 49292:
		case 49294:
		case 49296:
		case 49298:
			return 19;
		case 132:
		case 133:
		case 134:
		case 135:
		case 136:
			return 13;
		case 192:
		case 193:
		case 194:
		case 195:
		case 196:
			return 13;
		case 49267:
		case 49269:
		case 49271:
		case 49273:
		case 49301:
		case 49303:
		case 49305:
		case 49307:
			return 13;
		case 49275:
		case 49277:
		case 49279:
		case 49281:
		case 49283:
		case 49287:
		case 49289:
		case 49291:
		case 49293:
		case 49295:
		case 49297:
		case 49299:
			return 20;
		case 52392:
		case 52393:
		case 52394:
		case 52395:
		case 52396:
		case 52397:
		case 52398:
			return 102;
		case 1:
			return 0;
		case 2:
		case 44:
		case 45:
		case 46:
		case 49153:
		case 49158:
		case 49163:
		case 49168:
		case 49173:
		case 49209:
			return 0;
		case 59:
		case 176:
		case 180:
		case 184:
		case 49210:
			return 0;
		case 177:
		case 181:
		case 185:
		case 49211:
			return 0;
		case 4:
		case 24:
			return 2;
		case 5:
		case 138:
		case 142:
		case 146:
		case 49154:
		case 49159:
		case 49164:
		case 49169:
		case 49174:
		case 49203:
			return 2;
		case 150:
		case 151:
		case 152:
		case 153:
		case 154:
			return 14;
		default:
			throw new DEIDBCPPCMB(80);
		}
	}

	public static int DPIKBAJJABM(int ANPNEODAJHA)
	{
		switch (ANPNEODAJHA)
		{
		case 13:
		case 48:
		case 54:
		case 62:
		case 66:
		case 104:
		case 133:
		case 151:
		case 164:
		case 165:
		case 187:
		case 193:
		case 49282:
		case 49283:
			return 7;
		case 16:
		case 49:
		case 55:
		case 63:
		case 67:
		case 105:
		case 134:
		case 152:
		case 160:
		case 161:
		case 188:
		case 194:
		case 49278:
		case 49279:
			return 9;
		case 19:
		case 50:
		case 56:
		case 64:
		case 68:
		case 106:
		case 135:
		case 153:
		case 162:
		case 163:
		case 189:
		case 195:
		case 49280:
		case 49281:
			return 3;
		case 45:
		case 142:
		case 143:
		case 144:
		case 145:
		case 170:
		case 171:
		case 178:
		case 179:
		case 180:
		case 181:
		case 49296:
		case 49297:
		case 49302:
		case 49303:
		case 49318:
		case 49319:
		case 49322:
		case 49323:
		case 52397:
		case 65298:
		case 65299:
			return 14;
		case 22:
		case 51:
		case 57:
		case 69:
		case 103:
		case 107:
		case 136:
		case 154:
		case 158:
		case 159:
		case 190:
		case 196:
		case 49276:
		case 49277:
		case 49310:
		case 49311:
		case 49314:
		case 49315:
		case 52394:
		case 65280:
		case 65281:
			return 5;
		case 49173:
		case 49174:
		case 49175:
		case 49176:
		case 49177:
			return 20;
		case 49153:
		case 49154:
		case 49155:
		case 49156:
		case 49157:
		case 49189:
		case 49190:
		case 49197:
		case 49198:
		case 49268:
		case 49269:
		case 49288:
		case 49289:
		case 65284:
		case 65285:
			return 16;
		case 49163:
		case 49164:
		case 49165:
		case 49166:
		case 49167:
		case 49193:
		case 49194:
		case 49201:
		case 49202:
		case 49272:
		case 49273:
		case 49292:
		case 49293:
			return 18;
		case 49158:
		case 49159:
		case 49160:
		case 49161:
		case 49162:
		case 49187:
		case 49188:
		case 49195:
		case 49196:
		case 49266:
		case 49267:
		case 49286:
		case 49287:
		case 49324:
		case 49325:
		case 49326:
		case 49327:
		case 52393:
			return 17;
		case 49203:
		case 49204:
		case 49205:
		case 49206:
		case 49207:
		case 49208:
		case 49209:
		case 49210:
		case 49211:
		case 49306:
		case 49307:
		case 52396:
		case 65300:
		case 65301:
			return 24;
		case 49168:
		case 49169:
		case 49170:
		case 49171:
		case 49172:
		case 49191:
		case 49192:
		case 49199:
		case 49200:
		case 49270:
		case 49271:
		case 49290:
		case 49291:
		case 52392:
		case 65282:
		case 65283:
			return 19;
		case 44:
		case 138:
		case 139:
		case 140:
		case 141:
		case 168:
		case 169:
		case 174:
		case 175:
		case 176:
		case 177:
		case 49294:
		case 49295:
		case 49300:
		case 49301:
		case 49316:
		case 49317:
		case 49320:
		case 49321:
		case 52395:
		case 65296:
		case 65297:
			return 13;
		case 1:
		case 2:
		case 4:
		case 5:
		case 10:
		case 47:
		case 53:
		case 59:
		case 60:
		case 61:
		case 65:
		case 132:
		case 150:
		case 156:
		case 157:
		case 186:
		case 192:
		case 49274:
		case 49275:
		case 49308:
		case 49309:
		case 49312:
		case 49313:
		case 52398:
			return 1;
		case 46:
		case 146:
		case 147:
		case 148:
		case 149:
		case 172:
		case 173:
		case 182:
		case 183:
		case 184:
		case 185:
		case 49298:
		case 49299:
		case 49304:
		case 49305:
			return 15;
		case 49178:
		case 49181:
		case 49184:
			return 21;
		case 49180:
		case 49183:
		case 49186:
			return 22;
		case 49179:
		case 49182:
		case 49185:
			return 23;
		default:
			throw new DEIDBCPPCMB(80);
		}
	}

	public static int HPGGOHAOHNH(int ANPNEODAJHA)
	{
		switch (ANPNEODAJHA)
		{
		case 156:
		case 157:
		case 158:
		case 159:
		case 160:
		case 161:
		case 162:
		case 163:
		case 164:
		case 165:
		case 168:
		case 169:
		case 170:
		case 171:
		case 172:
		case 173:
		case 49195:
		case 49196:
		case 49197:
		case 49198:
		case 49199:
		case 49200:
		case 49201:
		case 49202:
		case 49274:
		case 49275:
		case 49276:
		case 49277:
		case 49278:
		case 49279:
		case 49280:
		case 49281:
		case 49282:
		case 49283:
		case 49286:
		case 49287:
		case 49288:
		case 49289:
		case 49290:
		case 49291:
		case 49292:
		case 49293:
		case 49294:
		case 49295:
		case 49296:
		case 49297:
		case 49298:
		case 49299:
		case 49308:
		case 49309:
		case 49310:
		case 49311:
		case 49312:
		case 49313:
		case 49314:
		case 49315:
		case 49316:
		case 49317:
		case 49318:
		case 49319:
		case 49320:
		case 49321:
		case 49322:
		case 49323:
		case 49324:
		case 49325:
		case 49326:
		case 49327:
		case 52392:
		case 52393:
		case 52394:
		case 52395:
		case 52396:
		case 52397:
		case 52398:
		case 65280:
		case 65281:
		case 65282:
		case 65283:
		case 65284:
		case 65285:
		case 65296:
		case 65297:
		case 65298:
		case 65299:
		case 65300:
		case 65301:
			return 0;
		case 1:
		case 4:
			return 1;
		case 2:
		case 5:
		case 10:
		case 13:
		case 16:
		case 19:
		case 22:
		case 44:
		case 45:
		case 46:
		case 47:
		case 48:
		case 49:
		case 50:
		case 51:
		case 53:
		case 54:
		case 55:
		case 56:
		case 57:
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
		case 132:
		case 133:
		case 134:
		case 135:
		case 136:
		case 138:
		case 139:
		case 140:
		case 141:
		case 142:
		case 143:
		case 144:
		case 145:
		case 146:
		case 147:
		case 148:
		case 149:
		case 150:
		case 151:
		case 152:
		case 153:
		case 154:
		case 49153:
		case 49154:
		case 49155:
		case 49156:
		case 49157:
		case 49158:
		case 49159:
		case 49160:
		case 49161:
		case 49162:
		case 49163:
		case 49164:
		case 49165:
		case 49166:
		case 49167:
		case 49168:
		case 49169:
		case 49170:
		case 49171:
		case 49172:
		case 49173:
		case 49174:
		case 49175:
		case 49176:
		case 49177:
		case 49178:
		case 49179:
		case 49180:
		case 49181:
		case 49182:
		case 49183:
		case 49184:
		case 49185:
		case 49186:
		case 49203:
		case 49204:
		case 49205:
		case 49206:
		case 49209:
			return 2;
		case 59:
		case 60:
		case 61:
		case 62:
		case 63:
		case 64:
		case 103:
		case 104:
		case 105:
		case 106:
		case 107:
		case 174:
		case 176:
		case 178:
		case 180:
		case 182:
		case 184:
		case 186:
		case 187:
		case 188:
		case 189:
		case 190:
		case 192:
		case 193:
		case 194:
		case 195:
		case 196:
		case 49187:
		case 49189:
		case 49191:
		case 49193:
		case 49207:
		case 49210:
		case 49266:
		case 49268:
		case 49270:
		case 49272:
		case 49300:
		case 49302:
		case 49304:
		case 49306:
			return 3;
		case 175:
		case 177:
		case 179:
		case 181:
		case 183:
		case 185:
		case 49188:
		case 49190:
		case 49192:
		case 49194:
		case 49208:
		case 49211:
		case 49267:
		case 49269:
		case 49271:
		case 49273:
		case 49301:
		case 49303:
		case 49305:
		case 49307:
			return 4;
		default:
			throw new DEIDBCPPCMB(80);
		}
	}

	public static OBDIBELBBEO KGJLBEICBMN(int ANPNEODAJHA)
	{
		switch (ANPNEODAJHA)
		{
		default:
			switch (ANPNEODAJHA)
			{
			case 59:
			case 60:
			case 61:
			case 62:
			case 63:
			case 64:
			case 103:
			case 104:
			case 105:
			case 106:
			case 107:
			case 156:
			case 157:
			case 158:
			case 159:
			case 160:
			case 161:
			case 162:
			case 163:
			case 164:
			case 165:
			case 168:
			case 169:
			case 170:
			case 171:
			case 172:
			case 173:
			case 186:
			case 187:
			case 188:
			case 189:
			case 190:
			case 191:
			case 192:
			case 193:
			case 194:
			case 195:
			case 196:
			case 197:
			case 49187:
			case 49188:
			case 49189:
			case 49190:
			case 49191:
			case 49192:
			case 49193:
			case 49194:
			case 49195:
			case 49196:
			case 49197:
			case 49198:
			case 49199:
			case 49200:
			case 49201:
			case 49202:
			case 52392:
			case 52393:
			case 52394:
			case 52395:
			case 52396:
			case 52397:
			case 52398:
			case 65280:
			case 65281:
			case 65282:
			case 65283:
			case 65284:
			case 65285:
			case 65296:
			case 65297:
			case 65298:
			case 65299:
			case 65300:
			case 65301:
				break;
			default:
				return OBDIBELBBEO.IMMFLDCIBJC;
			}
			break;
		case 49266:
		case 49267:
		case 49268:
		case 49269:
		case 49270:
		case 49271:
		case 49272:
		case 49273:
		case 49274:
		case 49275:
		case 49276:
		case 49277:
		case 49278:
		case 49279:
		case 49280:
		case 49281:
		case 49282:
		case 49283:
		case 49284:
		case 49285:
		case 49286:
		case 49287:
		case 49288:
		case 49289:
		case 49290:
		case 49291:
		case 49292:
		case 49293:
		case 49294:
		case 49295:
		case 49296:
		case 49297:
		case 49298:
		case 49299:
		case 49308:
		case 49309:
		case 49310:
		case 49311:
		case 49312:
		case 49313:
		case 49314:
		case 49315:
		case 49316:
		case 49317:
		case 49318:
		case 49319:
		case 49320:
		case 49321:
		case 49322:
		case 49323:
		case 49324:
		case 49325:
		case 49326:
		case 49327:
			break;
		}
		return OBDIBELBBEO.JIBPNECGBPK;
	}

	public static bool ALPACLOOEJN(int ANPNEODAJHA)
	{
		return 2 == MCGDLFEECAE(ANPNEODAJHA);
	}

	public static bool IGJPPGFHMJG(int ANPNEODAJHA)
	{
		return 1 == MCGDLFEECAE(ANPNEODAJHA);
	}

	public static bool EBIKHNNPDIP(int ANPNEODAJHA)
	{
		return 0 == MCGDLFEECAE(ANPNEODAJHA);
	}

	public static bool JCCJBBOLIDE(int DHDNFGLNBGJ, OBDIBELBBEO AJKHHEOLCMD)
	{
		return KGJLBEICBMN(DHDNFGLNBGJ).BMJPEMBKPII(AJKHHEOLCMD.EMPACBICMIM());
	}
}
