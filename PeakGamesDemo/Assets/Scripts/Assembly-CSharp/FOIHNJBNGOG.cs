using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math;

public class FOIHNJBNGOG : DGCIOOEELCP
{
	private static readonly BigInteger KDMNCPMKAEB = BigInteger.AGLOJCOAJIK(16L);

	private static readonly BigInteger GKFELMANPEH = BigInteger.AGLOJCOAJIK(6L);

	private static readonly byte[] JFPLDMIPEFH = new byte[16]
	{
		14, 3, 5, 8, 9, 4, 2, 15, 0, 13,
		11, 6, 7, 10, 12, 1
	};

	private static readonly byte[] OFBGKMOIIBD = new byte[16]
	{
		8, 15, 6, 1, 5, 2, 11, 12, 3, 4,
		13, 10, 14, 9, 0, 7
	};

	private readonly DGCIOOEELCP MFMIFDMEPPO;

	private bool MAEALKEJALK;

	private int FFLMHILGJIP;

	private int FOIHIFLKIPF;

	private BigInteger ACOFJAHAMHM;

	public string KFKMEPMEBND
	{
		get
		{
			return MFMIFDMEPPO.KFKMEPMEBND + "/ISO9796-1Padding";
		}
	}

	public FOIHNJBNGOG(DGCIOOEELCP IEDPBFAFGGJ)
	{
		MFMIFDMEPPO = IEDPBFAFGGJ;
	}

	public DGCIOOEELCP GBHNDFALCDC()
	{
		return MFMIFDMEPPO;
	}

	public void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		PLGGNEJEIIP pLGGNEJEIIP;
		if (IJJHBEECMBP is MDAKJDOFCEP)
		{
			MDAKJDOFCEP mDAKJDOFCEP = (MDAKJDOFCEP)IJJHBEECMBP;
			pLGGNEJEIIP = (PLGGNEJEIIP)mDAKJDOFCEP.KPJHHAAOFOH;
		}
		else
		{
			pLGGNEJEIIP = (PLGGNEJEIIP)IJJHBEECMBP;
		}
		MFMIFDMEPPO.DIOELAHNLKJ(MAEALKEJALK, IJJHBEECMBP);
		ACOFJAHAMHM = pLGGNEJEIIP.FILOMPHGFKD;
		FFLMHILGJIP = ACOFJAHAMHM.BitLength;
		this.MAEALKEJALK = MAEALKEJALK;
	}

	public int IBGFCPAGGON()
	{
		int num = MFMIFDMEPPO.IBGFCPAGGON();
		if (MAEALKEJALK)
		{
			return (num + 1) / 2;
		}
		return num;
	}

	public int JOKDJPBGMFH()
	{
		int num = MFMIFDMEPPO.JOKDJPBGMFH();
		if (MAEALKEJALK)
		{
			return num;
		}
		return (num + 1) / 2;
	}

	public void MNNLFPPKNMG(int FOIHIFLKIPF)
	{
		if (FOIHIFLKIPF > 7)
		{
			throw new ArgumentException("padBits > 7");
		}
		this.FOIHIFLKIPF = FOIHIFLKIPF;
	}

	public int CMIJPGJJHIL()
	{
		return FOIHIFLKIPF;
	}

	public byte[] DPACJDFHLKB(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP)
	{
		if (MAEALKEJALK)
		{
			return KFCHAKENJOM(MOPCLEEGDFB, ELICNEDIBGB, EOFAGACBNFP);
		}
		return APBCDPDBFPO(MOPCLEEGDFB, ELICNEDIBGB, EOFAGACBNFP);
	}

	private byte[] KFCHAKENJOM(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int DBGBBFPPDCE)
	{
		byte[] array = new byte[(FFLMHILGJIP + 7) / 8];
		int num = FOIHIFLKIPF + 1;
		int num2 = (FFLMHILGJIP + 13) / 16;
		for (int i = 0; i < num2; i += DBGBBFPPDCE)
		{
			if (i > num2 - DBGBBFPPDCE)
			{
				Array.Copy(MOPCLEEGDFB, ELICNEDIBGB + DBGBBFPPDCE - (num2 - i), array, array.Length - num2, num2 - i);
			}
			else
			{
				Array.Copy(MOPCLEEGDFB, ELICNEDIBGB, array, array.Length - (i + DBGBBFPPDCE), DBGBBFPPDCE);
			}
		}
		for (int j = array.Length - 2 * num2; j != array.Length; j += 2)
		{
			byte b = array[array.Length - num2 + j / 2];
			array[j] = (byte)((JFPLDMIPEFH[(uint)(b & 0xFF) >> 4] << 4) | JFPLDMIPEFH[b & 0xF]);
			array[j + 1] = b;
		}
		array[array.Length - 2 * DBGBBFPPDCE] ^= (byte)num;
		array[array.Length - 1] = (byte)((uint)(array[array.Length - 1] << 4) | 6u);
		int num3 = 8 - (FFLMHILGJIP - 1) % 8;
		int num4 = 0;
		if (num3 != 8)
		{
			array[0] &= (byte)(255 >> num3);
			array[0] |= (byte)(128 >> num3);
		}
		else
		{
			array[0] = 0;
			array[1] |= 128;
			num4 = 1;
		}
		return MFMIFDMEPPO.DPACJDFHLKB(array, num4, array.Length - num4);
	}

	private byte[] APBCDPDBFPO(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int DBGBBFPPDCE)
	{
		byte[] dIPNEDDIHBK = MFMIFDMEPPO.DPACJDFHLKB(MOPCLEEGDFB, ELICNEDIBGB, DBGBBFPPDCE);
		int num = 1;
		int num2 = (FFLMHILGJIP + 13) / 16;
		BigInteger bigInteger = new BigInteger(1, dIPNEDDIHBK);
		BigInteger bigInteger2;
		if (bigInteger.MODIHOCEKBK(KDMNCPMKAEB).Equals(GKFELMANPEH))
		{
			bigInteger2 = bigInteger;
		}
		else
		{
			bigInteger2 = ACOFJAHAMHM.FBGIHKPECCO(bigInteger);
			if (!bigInteger2.MODIHOCEKBK(KDMNCPMKAEB).Equals(GKFELMANPEH))
			{
				throw new InvalidCipherTextException("resulting integer iS or (modulus - iS) is not congruent to 6 mod 16");
			}
		}
		dIPNEDDIHBK = bigInteger2.MEOCDOOKOLH();
		if ((dIPNEDDIHBK[dIPNEDDIHBK.Length - 1] & 0xF) != 6)
		{
			throw new InvalidCipherTextException("invalid forcing byte in block");
		}
		dIPNEDDIHBK[dIPNEDDIHBK.Length - 1] = (byte)(((ushort)(dIPNEDDIHBK[dIPNEDDIHBK.Length - 1] & 0xFF) >> 4) | (OFBGKMOIIBD[(dIPNEDDIHBK[dIPNEDDIHBK.Length - 2] & 0xFF) >> 4] << 4));
		dIPNEDDIHBK[0] = (byte)((JFPLDMIPEFH[(uint)(dIPNEDDIHBK[1] & 0xFF) >> 4] << 4) | JFPLDMIPEFH[dIPNEDDIHBK[1] & 0xF]);
		bool flag = false;
		int num3 = 0;
		for (int num4 = dIPNEDDIHBK.Length - 1; num4 >= dIPNEDDIHBK.Length - 2 * num2; num4 -= 2)
		{
			int num5 = (JFPLDMIPEFH[(uint)(dIPNEDDIHBK[num4] & 0xFF) >> 4] << 4) | JFPLDMIPEFH[dIPNEDDIHBK[num4] & 0xF];
			if (((uint)(dIPNEDDIHBK[num4 - 1] ^ num5) & 0xFFu) != 0)
			{
				if (flag)
				{
					throw new InvalidCipherTextException("invalid tsums in block");
				}
				flag = true;
				num = (dIPNEDDIHBK[num4 - 1] ^ num5) & 0xFF;
				num3 = num4 - 1;
			}
		}
		dIPNEDDIHBK[num3] = 0;
		byte[] array = new byte[(dIPNEDDIHBK.Length - num3) / 2];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = dIPNEDDIHBK[2 * i + num3 + 1];
		}
		FOIHIFLKIPF = num - 1;
		return array;
	}
}
