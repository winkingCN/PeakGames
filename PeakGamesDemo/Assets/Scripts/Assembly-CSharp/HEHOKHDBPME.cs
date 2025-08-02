using System;

public class HEHOKHDBPME : NDIFOGFDKLL
{
	public override string KFKMEPMEBND
	{
		get
		{
			return "ChaCha" + DFKIEEIDJNM;
		}
	}

	public HEHOKHDBPME()
	{
	}

	public HEHOKHDBPME(int DFKIEEIDJNM)
		: base(DFKIEEIDJNM)
	{
	}

	protected override void PFOIANPLIKG()
	{
		if (++EMECPLDAING[12] == 0)
		{
			EMECPLDAING[13]++;
		}
	}

	protected override void IFCPCMANPPN()
	{
		EMECPLDAING[12] = (EMECPLDAING[13] = 0u);
	}

	protected override void KBEFMBDOIJH(byte[] EGJBACEEHAK, byte[] MIMCBAKIPJC)
	{
		if (EGJBACEEHAK != null)
		{
			if (EGJBACEEHAK.Length != 16 && EGJBACEEHAK.Length != 32)
			{
				throw new ArgumentException(KFKMEPMEBND + " requires 128 bit or 256 bit key");
			}
			HIMDNDGCMAP(EGJBACEEHAK.Length, EMECPLDAING, 0);
			PGOKFBKEOAB.LAJPMLKCDOH(EGJBACEEHAK, 0, EMECPLDAING, 4, 4);
			PGOKFBKEOAB.LAJPMLKCDOH(EGJBACEEHAK, EGJBACEEHAK.Length - 16, EMECPLDAING, 8, 4);
		}
		PGOKFBKEOAB.LAJPMLKCDOH(MIMCBAKIPJC, 0, EMECPLDAING, 14, 2);
	}

	protected override void EJPOGNHMIMH(byte[] BILGCJNPJGJ)
	{
		OEMMEMGGABO(DFKIEEIDJNM, EMECPLDAING, AMFCENFNAJJ);
		PGOKFBKEOAB.LGJFKMLLKLN(AMFCENFNAJJ, BILGCJNPJGJ, 0);
	}

	internal static void OEMMEMGGABO(int DFKIEEIDJNM, uint[] MOPCLEEGDFB, uint[] AMFCENFNAJJ)
	{
		if (MOPCLEEGDFB.Length != 16)
		{
			throw new ArgumentException();
		}
		if (AMFCENFNAJJ.Length != 16)
		{
			throw new ArgumentException();
		}
		if (DFKIEEIDJNM % 2 != 0)
		{
			throw new ArgumentException("Number of rounds must be even");
		}
		uint num = MOPCLEEGDFB[0];
		uint num2 = MOPCLEEGDFB[1];
		uint num3 = MOPCLEEGDFB[2];
		uint num4 = MOPCLEEGDFB[3];
		uint num5 = MOPCLEEGDFB[4];
		uint num6 = MOPCLEEGDFB[5];
		uint num7 = MOPCLEEGDFB[6];
		uint num8 = MOPCLEEGDFB[7];
		uint num9 = MOPCLEEGDFB[8];
		uint num10 = MOPCLEEGDFB[9];
		uint num11 = MOPCLEEGDFB[10];
		uint num12 = MOPCLEEGDFB[11];
		uint num13 = MOPCLEEGDFB[12];
		uint num14 = MOPCLEEGDFB[13];
		uint num15 = MOPCLEEGDFB[14];
		uint num16 = MOPCLEEGDFB[15];
		for (int num17 = DFKIEEIDJNM; num17 > 0; num17 -= 2)
		{
			num += num5;
			num13 = NDIFOGFDKLL.GOEFJMNOBHA(num13 ^ num, 16);
			num9 += num13;
			num5 = NDIFOGFDKLL.GOEFJMNOBHA(num5 ^ num9, 12);
			num += num5;
			num13 = NDIFOGFDKLL.GOEFJMNOBHA(num13 ^ num, 8);
			num9 += num13;
			num5 = NDIFOGFDKLL.GOEFJMNOBHA(num5 ^ num9, 7);
			num2 += num6;
			num14 = NDIFOGFDKLL.GOEFJMNOBHA(num14 ^ num2, 16);
			num10 += num14;
			num6 = NDIFOGFDKLL.GOEFJMNOBHA(num6 ^ num10, 12);
			num2 += num6;
			num14 = NDIFOGFDKLL.GOEFJMNOBHA(num14 ^ num2, 8);
			num10 += num14;
			num6 = NDIFOGFDKLL.GOEFJMNOBHA(num6 ^ num10, 7);
			num3 += num7;
			num15 = NDIFOGFDKLL.GOEFJMNOBHA(num15 ^ num3, 16);
			num11 += num15;
			num7 = NDIFOGFDKLL.GOEFJMNOBHA(num7 ^ num11, 12);
			num3 += num7;
			num15 = NDIFOGFDKLL.GOEFJMNOBHA(num15 ^ num3, 8);
			num11 += num15;
			num7 = NDIFOGFDKLL.GOEFJMNOBHA(num7 ^ num11, 7);
			num4 += num8;
			num16 = NDIFOGFDKLL.GOEFJMNOBHA(num16 ^ num4, 16);
			num12 += num16;
			num8 = NDIFOGFDKLL.GOEFJMNOBHA(num8 ^ num12, 12);
			num4 += num8;
			num16 = NDIFOGFDKLL.GOEFJMNOBHA(num16 ^ num4, 8);
			num12 += num16;
			num8 = NDIFOGFDKLL.GOEFJMNOBHA(num8 ^ num12, 7);
			num += num6;
			num16 = NDIFOGFDKLL.GOEFJMNOBHA(num16 ^ num, 16);
			num11 += num16;
			num6 = NDIFOGFDKLL.GOEFJMNOBHA(num6 ^ num11, 12);
			num += num6;
			num16 = NDIFOGFDKLL.GOEFJMNOBHA(num16 ^ num, 8);
			num11 += num16;
			num6 = NDIFOGFDKLL.GOEFJMNOBHA(num6 ^ num11, 7);
			num2 += num7;
			num13 = NDIFOGFDKLL.GOEFJMNOBHA(num13 ^ num2, 16);
			num12 += num13;
			num7 = NDIFOGFDKLL.GOEFJMNOBHA(num7 ^ num12, 12);
			num2 += num7;
			num13 = NDIFOGFDKLL.GOEFJMNOBHA(num13 ^ num2, 8);
			num12 += num13;
			num7 = NDIFOGFDKLL.GOEFJMNOBHA(num7 ^ num12, 7);
			num3 += num8;
			num14 = NDIFOGFDKLL.GOEFJMNOBHA(num14 ^ num3, 16);
			num9 += num14;
			num8 = NDIFOGFDKLL.GOEFJMNOBHA(num8 ^ num9, 12);
			num3 += num8;
			num14 = NDIFOGFDKLL.GOEFJMNOBHA(num14 ^ num3, 8);
			num9 += num14;
			num8 = NDIFOGFDKLL.GOEFJMNOBHA(num8 ^ num9, 7);
			num4 += num5;
			num15 = NDIFOGFDKLL.GOEFJMNOBHA(num15 ^ num4, 16);
			num10 += num15;
			num5 = NDIFOGFDKLL.GOEFJMNOBHA(num5 ^ num10, 12);
			num4 += num5;
			num15 = NDIFOGFDKLL.GOEFJMNOBHA(num15 ^ num4, 8);
			num10 += num15;
			num5 = NDIFOGFDKLL.GOEFJMNOBHA(num5 ^ num10, 7);
		}
		AMFCENFNAJJ[0] = num + MOPCLEEGDFB[0];
		AMFCENFNAJJ[1] = num2 + MOPCLEEGDFB[1];
		AMFCENFNAJJ[2] = num3 + MOPCLEEGDFB[2];
		AMFCENFNAJJ[3] = num4 + MOPCLEEGDFB[3];
		AMFCENFNAJJ[4] = num5 + MOPCLEEGDFB[4];
		AMFCENFNAJJ[5] = num6 + MOPCLEEGDFB[5];
		AMFCENFNAJJ[6] = num7 + MOPCLEEGDFB[6];
		AMFCENFNAJJ[7] = num8 + MOPCLEEGDFB[7];
		AMFCENFNAJJ[8] = num9 + MOPCLEEGDFB[8];
		AMFCENFNAJJ[9] = num10 + MOPCLEEGDFB[9];
		AMFCENFNAJJ[10] = num11 + MOPCLEEGDFB[10];
		AMFCENFNAJJ[11] = num12 + MOPCLEEGDFB[11];
		AMFCENFNAJJ[12] = num13 + MOPCLEEGDFB[12];
		AMFCENFNAJJ[13] = num14 + MOPCLEEGDFB[13];
		AMFCENFNAJJ[14] = num15 + MOPCLEEGDFB[14];
		AMFCENFNAJJ[15] = num16 + MOPCLEEGDFB[15];
	}
}
