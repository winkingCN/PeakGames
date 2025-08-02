using System.IO;

public class LHLJMOICCOC : CPPGAJFHILC
{
	protected readonly byte[] GCMKOGCFLON = new byte[64]
	{
		65, 66, 67, 68, 69, 70, 71, 72, 73, 74,
		75, 76, 77, 78, 79, 80, 81, 82, 83, 84,
		85, 86, 87, 88, 89, 90, 97, 98, 99, 100,
		101, 102, 103, 104, 105, 106, 107, 108, 109, 110,
		111, 112, 113, 114, 115, 116, 117, 118, 119, 120,
		121, 122, 48, 49, 50, 51, 52, 53, 54, 55,
		56, 57, 43, 47
	};

	protected byte HFHKPBBFDFD = 61;

	protected readonly byte[] BJFCKLLOAIE = new byte[128];

	public LHLJMOICCOC()
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
	}

	public int LMDBBPLCJDM(byte[] MBBPBGHKLJM, int JBAJPGIAPFF, int EOFAGACBNFP, Stream OMCALCLJPOD)
	{
		int num = EOFAGACBNFP % 3;
		int num2 = EOFAGACBNFP - num;
		for (int i = JBAJPGIAPFF; i < JBAJPGIAPFF + num2; i += 3)
		{
			int num3 = MBBPBGHKLJM[i] & 0xFF;
			int num4 = MBBPBGHKLJM[i + 1] & 0xFF;
			int num5 = MBBPBGHKLJM[i + 2] & 0xFF;
			OMCALCLJPOD.WriteByte(GCMKOGCFLON[((uint)num3 >> 2) & 0x3F]);
			OMCALCLJPOD.WriteByte(GCMKOGCFLON[((uint)(num3 << 4) | ((uint)num4 >> 4)) & 0x3F]);
			OMCALCLJPOD.WriteByte(GCMKOGCFLON[((uint)(num4 << 2) | ((uint)num5 >> 6)) & 0x3F]);
			OMCALCLJPOD.WriteByte(GCMKOGCFLON[num5 & 0x3F]);
		}
		switch (num)
		{
		case 1:
		{
			int num6 = MBBPBGHKLJM[JBAJPGIAPFF + num2] & 0xFF;
			int num8 = (num6 >> 2) & 0x3F;
			int num9 = (num6 << 4) & 0x3F;
			OMCALCLJPOD.WriteByte(GCMKOGCFLON[num8]);
			OMCALCLJPOD.WriteByte(GCMKOGCFLON[num9]);
			OMCALCLJPOD.WriteByte(HFHKPBBFDFD);
			OMCALCLJPOD.WriteByte(HFHKPBBFDFD);
			break;
		}
		case 2:
		{
			int num6 = MBBPBGHKLJM[JBAJPGIAPFF + num2] & 0xFF;
			int num7 = MBBPBGHKLJM[JBAJPGIAPFF + num2 + 1] & 0xFF;
			int num8 = (num6 >> 2) & 0x3F;
			int num9 = ((num6 << 4) | (num7 >> 4)) & 0x3F;
			int num10 = (num7 << 2) & 0x3F;
			OMCALCLJPOD.WriteByte(GCMKOGCFLON[num8]);
			OMCALCLJPOD.WriteByte(GCMKOGCFLON[num9]);
			OMCALCLJPOD.WriteByte(GCMKOGCFLON[num10]);
			OMCALCLJPOD.WriteByte(HFHKPBBFDFD);
			break;
		}
		}
		return num2 / 3 * 4 + ((num != 0) ? 4 : 0);
	}

	private bool DDHGNKGDFAE(char FMFABAKPMLB)
	{
		return FMFABAKPMLB == '\n' || FMFABAKPMLB == '\r' || FMFABAKPMLB == '\t' || FMFABAKPMLB == ' ';
	}

	public int ILOALOLANOL(byte[] MBBPBGHKLJM, int JBAJPGIAPFF, int EOFAGACBNFP, Stream OMCALCLJPOD)
	{
		int num = 0;
		int num2 = JBAJPGIAPFF + EOFAGACBNFP;
		while (num2 > JBAJPGIAPFF && DDHGNKGDFAE((char)MBBPBGHKLJM[num2 - 1]))
		{
			num2--;
		}
		int pLCFEOMGCFK = JBAJPGIAPFF;
		int num3 = num2 - 4;
		for (pLCFEOMGCFK = PIPKLGKJEHO(MBBPBGHKLJM, pLCFEOMGCFK, num3); pLCFEOMGCFK < num3; pLCFEOMGCFK = PIPKLGKJEHO(MBBPBGHKLJM, pLCFEOMGCFK, num3))
		{
			byte b = BJFCKLLOAIE[MBBPBGHKLJM[pLCFEOMGCFK++]];
			pLCFEOMGCFK = PIPKLGKJEHO(MBBPBGHKLJM, pLCFEOMGCFK, num3);
			byte b2 = BJFCKLLOAIE[MBBPBGHKLJM[pLCFEOMGCFK++]];
			pLCFEOMGCFK = PIPKLGKJEHO(MBBPBGHKLJM, pLCFEOMGCFK, num3);
			byte b3 = BJFCKLLOAIE[MBBPBGHKLJM[pLCFEOMGCFK++]];
			pLCFEOMGCFK = PIPKLGKJEHO(MBBPBGHKLJM, pLCFEOMGCFK, num3);
			byte b4 = BJFCKLLOAIE[MBBPBGHKLJM[pLCFEOMGCFK++]];
			if ((b | b2 | b3 | b4) >= 128)
			{
				throw new IOException("invalid characters encountered in base64 data");
			}
			OMCALCLJPOD.WriteByte((byte)((b << 2) | (b2 >> 4)));
			OMCALCLJPOD.WriteByte((byte)((b2 << 4) | (b3 >> 2)));
			OMCALCLJPOD.WriteByte((byte)((b3 << 6) | b4));
			num += 3;
		}
		return num + LAGOGHNOMCK(OMCALCLJPOD, (char)MBBPBGHKLJM[num2 - 4], (char)MBBPBGHKLJM[num2 - 3], (char)MBBPBGHKLJM[num2 - 2], (char)MBBPBGHKLJM[num2 - 1]);
	}

	private int PIPKLGKJEHO(byte[] MBBPBGHKLJM, int PLCFEOMGCFK, int JGJKCJOJLDG)
	{
		while (PLCFEOMGCFK < JGJKCJOJLDG && DDHGNKGDFAE((char)MBBPBGHKLJM[PLCFEOMGCFK]))
		{
			PLCFEOMGCFK++;
		}
		return PLCFEOMGCFK;
	}

	public int DMJOJHFDLJE(string MBBPBGHKLJM, Stream OMCALCLJPOD)
	{
		int num = 0;
		int num2 = MBBPBGHKLJM.Length;
		while (num2 > 0 && DDHGNKGDFAE(MBBPBGHKLJM[num2 - 1]))
		{
			num2--;
		}
		int pLCFEOMGCFK = 0;
		int num3 = num2 - 4;
		for (pLCFEOMGCFK = PIPKLGKJEHO(MBBPBGHKLJM, pLCFEOMGCFK, num3); pLCFEOMGCFK < num3; pLCFEOMGCFK = PIPKLGKJEHO(MBBPBGHKLJM, pLCFEOMGCFK, num3))
		{
			byte b = BJFCKLLOAIE[(uint)MBBPBGHKLJM[pLCFEOMGCFK++]];
			pLCFEOMGCFK = PIPKLGKJEHO(MBBPBGHKLJM, pLCFEOMGCFK, num3);
			byte b2 = BJFCKLLOAIE[(uint)MBBPBGHKLJM[pLCFEOMGCFK++]];
			pLCFEOMGCFK = PIPKLGKJEHO(MBBPBGHKLJM, pLCFEOMGCFK, num3);
			byte b3 = BJFCKLLOAIE[(uint)MBBPBGHKLJM[pLCFEOMGCFK++]];
			pLCFEOMGCFK = PIPKLGKJEHO(MBBPBGHKLJM, pLCFEOMGCFK, num3);
			byte b4 = BJFCKLLOAIE[(uint)MBBPBGHKLJM[pLCFEOMGCFK++]];
			if ((b | b2 | b3 | b4) >= 128)
			{
				throw new IOException("invalid characters encountered in base64 data");
			}
			OMCALCLJPOD.WriteByte((byte)((b << 2) | (b2 >> 4)));
			OMCALCLJPOD.WriteByte((byte)((b2 << 4) | (b3 >> 2)));
			OMCALCLJPOD.WriteByte((byte)((b3 << 6) | b4));
			num += 3;
		}
		return num + LAGOGHNOMCK(OMCALCLJPOD, MBBPBGHKLJM[num2 - 4], MBBPBGHKLJM[num2 - 3], MBBPBGHKLJM[num2 - 2], MBBPBGHKLJM[num2 - 1]);
	}

	private int LAGOGHNOMCK(Stream OMCALCLJPOD, char DJAFLPBMOGI, char AAGMIAIANDD, char AMEHAADFIFA, char MHIJBIJOFJA)
	{
		if (AMEHAADFIFA == HFHKPBBFDFD)
		{
			byte b = BJFCKLLOAIE[(uint)DJAFLPBMOGI];
			byte b2 = BJFCKLLOAIE[(uint)AAGMIAIANDD];
			if ((b | b2) >= 128)
			{
				throw new IOException("invalid characters encountered at end of base64 data");
			}
			OMCALCLJPOD.WriteByte((byte)((b << 2) | (b2 >> 4)));
			return 1;
		}
		if (MHIJBIJOFJA == HFHKPBBFDFD)
		{
			byte b3 = BJFCKLLOAIE[(uint)DJAFLPBMOGI];
			byte b4 = BJFCKLLOAIE[(uint)AAGMIAIANDD];
			byte b5 = BJFCKLLOAIE[(uint)AMEHAADFIFA];
			if ((b3 | b4 | b5) >= 128)
			{
				throw new IOException("invalid characters encountered at end of base64 data");
			}
			OMCALCLJPOD.WriteByte((byte)((b3 << 2) | (b4 >> 4)));
			OMCALCLJPOD.WriteByte((byte)((b4 << 4) | (b5 >> 2)));
			return 2;
		}
		byte b6 = BJFCKLLOAIE[(uint)DJAFLPBMOGI];
		byte b7 = BJFCKLLOAIE[(uint)AAGMIAIANDD];
		byte b8 = BJFCKLLOAIE[(uint)AMEHAADFIFA];
		byte b9 = BJFCKLLOAIE[(uint)MHIJBIJOFJA];
		if ((b6 | b7 | b8 | b9) >= 128)
		{
			throw new IOException("invalid characters encountered at end of base64 data");
		}
		OMCALCLJPOD.WriteByte((byte)((b6 << 2) | (b7 >> 4)));
		OMCALCLJPOD.WriteByte((byte)((b7 << 4) | (b8 >> 2)));
		OMCALCLJPOD.WriteByte((byte)((b8 << 6) | b9));
		return 3;
	}

	private int PIPKLGKJEHO(string MBBPBGHKLJM, int PLCFEOMGCFK, int JGJKCJOJLDG)
	{
		while (PLCFEOMGCFK < JGJKCJOJLDG && DDHGNKGDFAE(MBBPBGHKLJM[PLCFEOMGCFK]))
		{
			PLCFEOMGCFK++;
		}
		return PLCFEOMGCFK;
	}
}
