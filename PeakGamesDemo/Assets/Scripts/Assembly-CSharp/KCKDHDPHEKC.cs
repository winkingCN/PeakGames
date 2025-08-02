using System.IO;

public class KCKDHDPHEKC : CPPGAJFHILC
{
	protected readonly byte[] GCMKOGCFLON = new byte[16]
	{
		48, 49, 50, 51, 52, 53, 54, 55, 56, 57,
		97, 98, 99, 100, 101, 102
	};

	protected readonly byte[] BJFCKLLOAIE = new byte[128];

	public KCKDHDPHEKC()
	{
		CKMEJMJHGJJ();
	}

	protected void CKMEJMJHGJJ()
	{
		NOGCEBKPPJE.MEBLOMPDLEJ(BJFCKLLOAIE, byte.MaxValue);
		for (int i = 0; i < GCMKOGCFLON.Length; i++)
		{
			BJFCKLLOAIE[GCMKOGCFLON[i]] = (byte)i;
		}
		BJFCKLLOAIE[65] = BJFCKLLOAIE[97];
		BJFCKLLOAIE[66] = BJFCKLLOAIE[98];
		BJFCKLLOAIE[67] = BJFCKLLOAIE[99];
		BJFCKLLOAIE[68] = BJFCKLLOAIE[100];
		BJFCKLLOAIE[69] = BJFCKLLOAIE[101];
		BJFCKLLOAIE[70] = BJFCKLLOAIE[102];
	}

	public int LMDBBPLCJDM(byte[] MBBPBGHKLJM, int JBAJPGIAPFF, int EOFAGACBNFP, Stream OMCALCLJPOD)
	{
		for (int i = JBAJPGIAPFF; i < JBAJPGIAPFF + EOFAGACBNFP; i++)
		{
			int num = MBBPBGHKLJM[i];
			OMCALCLJPOD.WriteByte(GCMKOGCFLON[num >> 4]);
			OMCALCLJPOD.WriteByte(GCMKOGCFLON[num & 0xF]);
		}
		return EOFAGACBNFP * 2;
	}

	private static bool HBLANGIDMFP(char FMFABAKPMLB)
	{
		return FMFABAKPMLB == '\n' || FMFABAKPMLB == '\r' || FMFABAKPMLB == '\t' || FMFABAKPMLB == ' ';
	}

	public int ILOALOLANOL(byte[] MBBPBGHKLJM, int JBAJPGIAPFF, int EOFAGACBNFP, Stream OMCALCLJPOD)
	{
		int num = 0;
		int num2 = JBAJPGIAPFF + EOFAGACBNFP;
		while (num2 > JBAJPGIAPFF && HBLANGIDMFP((char)MBBPBGHKLJM[num2 - 1]))
		{
			num2--;
		}
		int i = JBAJPGIAPFF;
		while (i < num2)
		{
			for (; i < num2 && HBLANGIDMFP((char)MBBPBGHKLJM[i]); i++)
			{
			}
			byte b = BJFCKLLOAIE[MBBPBGHKLJM[i++]];
			for (; i < num2 && HBLANGIDMFP((char)MBBPBGHKLJM[i]); i++)
			{
			}
			byte b2 = BJFCKLLOAIE[MBBPBGHKLJM[i++]];
			if ((b | b2) >= 128)
			{
				throw new IOException("invalid characters encountered in Hex data");
			}
			OMCALCLJPOD.WriteByte((byte)((b << 4) | b2));
			num++;
		}
		return num;
	}

	public int DMJOJHFDLJE(string MBBPBGHKLJM, Stream OMCALCLJPOD)
	{
		int num = 0;
		int num2 = MBBPBGHKLJM.Length;
		while (num2 > 0 && HBLANGIDMFP(MBBPBGHKLJM[num2 - 1]))
		{
			num2--;
		}
		int i = 0;
		while (i < num2)
		{
			for (; i < num2 && HBLANGIDMFP(MBBPBGHKLJM[i]); i++)
			{
			}
			byte b = BJFCKLLOAIE[(uint)MBBPBGHKLJM[i++]];
			for (; i < num2 && HBLANGIDMFP(MBBPBGHKLJM[i]); i++)
			{
			}
			byte b2 = BJFCKLLOAIE[(uint)MBBPBGHKLJM[i++]];
			if ((b | b2) >= 128)
			{
				throw new IOException("invalid characters encountered in Hex data");
			}
			OMCALCLJPOD.WriteByte((byte)((b << 4) | b2));
			num++;
		}
		return num;
	}
}
