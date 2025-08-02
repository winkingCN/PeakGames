internal abstract class HIHDNGIBEPL
{
	private const uint PLLDFIPOPDG = 3774873600u;

	private const ulong CAFJJPEODCL = 16212958658533785600uL;

	private static readonly uint[] JMCJIPAIPPI = KDMCEKNFDOK();

	private static uint[] KDMCEKNFDOK()
	{
		uint[] array = new uint[256];
		for (int i = 0; i < 256; i++)
		{
			uint num = 0u;
			for (int num2 = 7; num2 >= 0; num2--)
			{
				if ((i & (1 << num2)) != 0)
				{
					num ^= 3774873600u >> 7 - num2;
				}
			}
			array[i] = num;
		}
		return array;
	}

	internal static byte[] NJLKFPLLFHE()
	{
		return new byte[16]
		{
			128, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0
		};
	}

	internal static uint[] NMLPLBDAPDH()
	{
		return new uint[4] { 2147483648u, 0u, 0u, 0u };
	}

	internal static ulong[] APFJKEMCCPP()
	{
		return new ulong[2] { 9223372036854775808uL, 0uL };
	}

	internal static byte[] FAPNKANLPPN(uint[] AMFCENFNAJJ)
	{
		return PGOKFBKEOAB.MPMAFPANDLC(AMFCENFNAJJ);
	}

	internal static void FAPNKANLPPN(uint[] AMFCENFNAJJ, byte[] IGNEOOOFEMO)
	{
		PGOKFBKEOAB.MPMAFPANDLC(AMFCENFNAJJ, IGNEOOOFEMO, 0);
	}

	internal static byte[] FAPNKANLPPN(ulong[] AMFCENFNAJJ)
	{
		byte[] array = new byte[16];
		PGOKFBKEOAB.LHKOONEHKNH(AMFCENFNAJJ, array, 0);
		return array;
	}

	internal static void FAPNKANLPPN(ulong[] AMFCENFNAJJ, byte[] IGNEOOOFEMO)
	{
		PGOKFBKEOAB.LHKOONEHKNH(AMFCENFNAJJ, IGNEOOOFEMO, 0);
	}

	internal static uint[] BGPMEOHBNNA(byte[] FAPGOCDNGIB)
	{
		uint[] array = new uint[4];
		PGOKFBKEOAB.EFODDMAJNOA(FAPGOCDNGIB, 0, array);
		return array;
	}

	internal static void BGPMEOHBNNA(byte[] FAPGOCDNGIB, uint[] BILGCJNPJGJ)
	{
		PGOKFBKEOAB.EFODDMAJNOA(FAPGOCDNGIB, 0, BILGCJNPJGJ);
	}

	internal static ulong[] DAKONGFDCPP(byte[] AMFCENFNAJJ)
	{
		ulong[] array = new ulong[2];
		PGOKFBKEOAB.KAMACIJLJKL(AMFCENFNAJJ, 0, array);
		return array;
	}

	public static void DAKONGFDCPP(byte[] AMFCENFNAJJ, ulong[] IGNEOOOFEMO)
	{
		PGOKFBKEOAB.KAMACIJLJKL(AMFCENFNAJJ, 0, IGNEOOOFEMO);
	}

	internal static void IBJBIGNPNEM(byte[] AMFCENFNAJJ, byte[] CNLILOEEBOJ)
	{
		uint[] aMFCENFNAJJ = BGPMEOHBNNA(AMFCENFNAJJ);
		uint[] cNLILOEEBOJ = BGPMEOHBNNA(CNLILOEEBOJ);
		IBJBIGNPNEM(aMFCENFNAJJ, cNLILOEEBOJ);
		FAPNKANLPPN(aMFCENFNAJJ, AMFCENFNAJJ);
	}

	internal static void IBJBIGNPNEM(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ)
	{
		uint num = AMFCENFNAJJ[0];
		uint num2 = AMFCENFNAJJ[1];
		uint num3 = AMFCENFNAJJ[2];
		uint num4 = AMFCENFNAJJ[3];
		uint num5 = 0u;
		uint num6 = 0u;
		uint num7 = 0u;
		uint num8 = 0u;
		for (int i = 0; i < 4; i++)
		{
			int num9 = (int)CNLILOEEBOJ[i];
			for (int j = 0; j < 32; j++)
			{
				uint num10 = (uint)(num9 >> 31);
				num9 <<= 1;
				num5 ^= num & num10;
				num6 ^= num2 & num10;
				num7 ^= num3 & num10;
				num8 ^= num4 & num10;
				uint num11 = (uint)((int)(num4 << 31) >> 8);
				num4 = (num4 >> 1) | (num3 << 31);
				num3 = (num3 >> 1) | (num2 << 31);
				num2 = (num2 >> 1) | (num << 31);
				num = (num >> 1) ^ (num11 & 0xE1000000u);
			}
		}
		AMFCENFNAJJ[0] = num5;
		AMFCENFNAJJ[1] = num6;
		AMFCENFNAJJ[2] = num7;
		AMFCENFNAJJ[3] = num8;
	}

	internal static void IBJBIGNPNEM(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ)
	{
		ulong num = AMFCENFNAJJ[0];
		ulong num2 = AMFCENFNAJJ[1];
		ulong num3 = 0uL;
		ulong num4 = 0uL;
		for (int i = 0; i < 2; i++)
		{
			long num5 = (long)CNLILOEEBOJ[i];
			for (int j = 0; j < 64; j++)
			{
				ulong num6 = (ulong)(num5 >> 63);
				num5 <<= 1;
				num3 ^= num & num6;
				num4 ^= num2 & num6;
				ulong num7 = (ulong)((long)(num2 << 63) >> 8);
				num2 = (num2 >> 1) | (num << 63);
				num = (num >> 1) ^ (num7 & 0xE100000000000000uL);
			}
		}
		AMFCENFNAJJ[0] = num3;
		AMFCENFNAJJ[1] = num4;
	}

	internal static void EAKOALEEBHG(uint[] AMFCENFNAJJ)
	{
		uint num = (uint)((int)ABOIOKBIANB(AMFCENFNAJJ) >> 8);
		AMFCENFNAJJ[0] ^= num & 0xE1000000u;
	}

	internal static void EAKOALEEBHG(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		uint num = (uint)((int)ABOIOKBIANB(AMFCENFNAJJ, IGNEOOOFEMO) >> 8);
		IGNEOOOFEMO[0] ^= num & 0xE1000000u;
	}

	internal static void BOOLMKNPOON(uint[] AMFCENFNAJJ)
	{
		uint num = PGJCKFOJOJO(AMFCENFNAJJ, 8);
		AMFCENFNAJJ[0] ^= JMCJIPAIPPI[num >> 24];
	}

	internal static void BOOLMKNPOON(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ)
	{
		uint num = PGJCKFOJOJO(AMFCENFNAJJ, 8, CNLILOEEBOJ);
		CNLILOEEBOJ[0] ^= JMCJIPAIPPI[num >> 24];
	}

	internal static uint ABOIOKBIANB(uint[] AMFCENFNAJJ)
	{
		uint num = AMFCENFNAJJ[0];
		AMFCENFNAJJ[0] = num >> 1;
		uint num2 = num << 31;
		num = AMFCENFNAJJ[1];
		AMFCENFNAJJ[1] = (num >> 1) | num2;
		num2 = num << 31;
		num = AMFCENFNAJJ[2];
		AMFCENFNAJJ[2] = (num >> 1) | num2;
		num2 = num << 31;
		num = AMFCENFNAJJ[3];
		AMFCENFNAJJ[3] = (num >> 1) | num2;
		return num << 31;
	}

	internal static uint ABOIOKBIANB(uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		uint num = AMFCENFNAJJ[0];
		IGNEOOOFEMO[0] = num >> 1;
		uint num2 = num << 31;
		num = AMFCENFNAJJ[1];
		IGNEOOOFEMO[1] = (num >> 1) | num2;
		num2 = num << 31;
		num = AMFCENFNAJJ[2];
		IGNEOOOFEMO[2] = (num >> 1) | num2;
		num2 = num << 31;
		num = AMFCENFNAJJ[3];
		IGNEOOOFEMO[3] = (num >> 1) | num2;
		return num << 31;
	}

	internal static uint PGJCKFOJOJO(uint[] AMFCENFNAJJ, int IDHLPOFDLKJ)
	{
		uint num = AMFCENFNAJJ[0];
		int num2 = 32 - IDHLPOFDLKJ;
		AMFCENFNAJJ[0] = num >> IDHLPOFDLKJ;
		uint num3 = num << num2;
		num = AMFCENFNAJJ[1];
		AMFCENFNAJJ[1] = (num >> IDHLPOFDLKJ) | num3;
		num3 = num << num2;
		num = AMFCENFNAJJ[2];
		AMFCENFNAJJ[2] = (num >> IDHLPOFDLKJ) | num3;
		num3 = num << num2;
		num = AMFCENFNAJJ[3];
		AMFCENFNAJJ[3] = (num >> IDHLPOFDLKJ) | num3;
		return num << num2;
	}

	internal static uint PGJCKFOJOJO(uint[] AMFCENFNAJJ, int IDHLPOFDLKJ, uint[] IGNEOOOFEMO)
	{
		uint num = AMFCENFNAJJ[0];
		int num2 = 32 - IDHLPOFDLKJ;
		IGNEOOOFEMO[0] = num >> IDHLPOFDLKJ;
		uint num3 = num << num2;
		num = AMFCENFNAJJ[1];
		IGNEOOOFEMO[1] = (num >> IDHLPOFDLKJ) | num3;
		num3 = num << num2;
		num = AMFCENFNAJJ[2];
		IGNEOOOFEMO[2] = (num >> IDHLPOFDLKJ) | num3;
		num3 = num << num2;
		num = AMFCENFNAJJ[3];
		IGNEOOOFEMO[3] = (num >> IDHLPOFDLKJ) | num3;
		return num << num2;
	}

	internal static void FHLALGENPPH(byte[] AMFCENFNAJJ, byte[] CNLILOEEBOJ)
	{
		int num = 0;
		do
		{
			AMFCENFNAJJ[num] ^= CNLILOEEBOJ[num];
			num++;
			AMFCENFNAJJ[num] ^= CNLILOEEBOJ[num];
			num++;
			AMFCENFNAJJ[num] ^= CNLILOEEBOJ[num];
			num++;
			AMFCENFNAJJ[num] ^= CNLILOEEBOJ[num];
			num++;
		}
		while (num < 16);
	}

	internal static void FHLALGENPPH(byte[] AMFCENFNAJJ, byte[] CNLILOEEBOJ, int HGNFOMNFIDD, int NPPDFKHACLN)
	{
		while (--NPPDFKHACLN >= 0)
		{
			AMFCENFNAJJ[NPPDFKHACLN] ^= CNLILOEEBOJ[HGNFOMNFIDD + NPPDFKHACLN];
		}
	}

	internal static void FHLALGENPPH(byte[] AMFCENFNAJJ, byte[] CNLILOEEBOJ, byte[] IGNEOOOFEMO)
	{
		int num = 0;
		do
		{
			IGNEOOOFEMO[num] = (byte)(AMFCENFNAJJ[num] ^ CNLILOEEBOJ[num]);
			num++;
			IGNEOOOFEMO[num] = (byte)(AMFCENFNAJJ[num] ^ CNLILOEEBOJ[num]);
			num++;
			IGNEOOOFEMO[num] = (byte)(AMFCENFNAJJ[num] ^ CNLILOEEBOJ[num]);
			num++;
			IGNEOOOFEMO[num] = (byte)(AMFCENFNAJJ[num] ^ CNLILOEEBOJ[num]);
			num++;
		}
		while (num < 16);
	}

	internal static void FHLALGENPPH(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ)
	{
		AMFCENFNAJJ[0] ^= CNLILOEEBOJ[0];
		AMFCENFNAJJ[1] ^= CNLILOEEBOJ[1];
		AMFCENFNAJJ[2] ^= CNLILOEEBOJ[2];
		AMFCENFNAJJ[3] ^= CNLILOEEBOJ[3];
	}

	internal static void FHLALGENPPH(uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		IGNEOOOFEMO[0] = AMFCENFNAJJ[0] ^ CNLILOEEBOJ[0];
		IGNEOOOFEMO[1] = AMFCENFNAJJ[1] ^ CNLILOEEBOJ[1];
		IGNEOOOFEMO[2] = AMFCENFNAJJ[2] ^ CNLILOEEBOJ[2];
		IGNEOOOFEMO[3] = AMFCENFNAJJ[3] ^ CNLILOEEBOJ[3];
	}

	internal static void FHLALGENPPH(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ)
	{
		AMFCENFNAJJ[0] ^= CNLILOEEBOJ[0];
		AMFCENFNAJJ[1] ^= CNLILOEEBOJ[1];
	}

	internal static void FHLALGENPPH(ulong[] AMFCENFNAJJ, ulong[] CNLILOEEBOJ, ulong[] IGNEOOOFEMO)
	{
		IGNEOOOFEMO[0] = AMFCENFNAJJ[0] ^ CNLILOEEBOJ[0];
		IGNEOOOFEMO[1] = AMFCENFNAJJ[1] ^ CNLILOEEBOJ[1];
	}
}
