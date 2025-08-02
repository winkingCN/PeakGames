internal sealed class PGOKFBKEOAB
{
	private PGOKFBKEOAB()
	{
	}

	internal static void NIFFKODJCKI(ushort IDHLPOFDLKJ, byte[] FAPGOCDNGIB)
	{
		FAPGOCDNGIB[0] = (byte)(IDHLPOFDLKJ >> 8);
		FAPGOCDNGIB[1] = (byte)IDHLPOFDLKJ;
	}

	internal static void NIFFKODJCKI(ushort IDHLPOFDLKJ, byte[] FAPGOCDNGIB, int JBAJPGIAPFF)
	{
		FAPGOCDNGIB[JBAJPGIAPFF] = (byte)(IDHLPOFDLKJ >> 8);
		FAPGOCDNGIB[JBAJPGIAPFF + 1] = (byte)IDHLPOFDLKJ;
	}

	internal static ushort LNIMPGHAJPH(byte[] FAPGOCDNGIB)
	{
		uint num = (uint)((FAPGOCDNGIB[0] << 8) | FAPGOCDNGIB[1]);
		return (ushort)num;
	}

	internal static ushort LNIMPGHAJPH(byte[] FAPGOCDNGIB, int JBAJPGIAPFF)
	{
		uint num = (uint)((FAPGOCDNGIB[JBAJPGIAPFF] << 8) | FAPGOCDNGIB[JBAJPGIAPFF + 1]);
		return (ushort)num;
	}

	internal static byte[] MPMAFPANDLC(uint IDHLPOFDLKJ)
	{
		byte[] array = new byte[4];
		MPMAFPANDLC(IDHLPOFDLKJ, array, 0);
		return array;
	}

	internal static void MPMAFPANDLC(uint IDHLPOFDLKJ, byte[] FAPGOCDNGIB)
	{
		FAPGOCDNGIB[0] = (byte)(IDHLPOFDLKJ >> 24);
		FAPGOCDNGIB[1] = (byte)(IDHLPOFDLKJ >> 16);
		FAPGOCDNGIB[2] = (byte)(IDHLPOFDLKJ >> 8);
		FAPGOCDNGIB[3] = (byte)IDHLPOFDLKJ;
	}

	internal static void MPMAFPANDLC(uint IDHLPOFDLKJ, byte[] FAPGOCDNGIB, int JBAJPGIAPFF)
	{
		FAPGOCDNGIB[JBAJPGIAPFF] = (byte)(IDHLPOFDLKJ >> 24);
		FAPGOCDNGIB[JBAJPGIAPFF + 1] = (byte)(IDHLPOFDLKJ >> 16);
		FAPGOCDNGIB[JBAJPGIAPFF + 2] = (byte)(IDHLPOFDLKJ >> 8);
		FAPGOCDNGIB[JBAJPGIAPFF + 3] = (byte)IDHLPOFDLKJ;
	}

	internal static byte[] MPMAFPANDLC(uint[] DHMJBKJAIGC)
	{
		byte[] array = new byte[4 * DHMJBKJAIGC.Length];
		MPMAFPANDLC(DHMJBKJAIGC, array, 0);
		return array;
	}

	internal static void MPMAFPANDLC(uint[] DHMJBKJAIGC, byte[] FAPGOCDNGIB, int JBAJPGIAPFF)
	{
		for (int i = 0; i < DHMJBKJAIGC.Length; i++)
		{
			MPMAFPANDLC(DHMJBKJAIGC[i], FAPGOCDNGIB, JBAJPGIAPFF);
			JBAJPGIAPFF += 4;
		}
	}

	internal static uint EFODDMAJNOA(byte[] FAPGOCDNGIB)
	{
		return (uint)((FAPGOCDNGIB[0] << 24) | (FAPGOCDNGIB[1] << 16) | (FAPGOCDNGIB[2] << 8) | FAPGOCDNGIB[3]);
	}

	internal static uint EFODDMAJNOA(byte[] FAPGOCDNGIB, int JBAJPGIAPFF)
	{
		return (uint)((FAPGOCDNGIB[JBAJPGIAPFF] << 24) | (FAPGOCDNGIB[JBAJPGIAPFF + 1] << 16) | (FAPGOCDNGIB[JBAJPGIAPFF + 2] << 8) | FAPGOCDNGIB[JBAJPGIAPFF + 3]);
	}

	internal static void EFODDMAJNOA(byte[] FAPGOCDNGIB, int JBAJPGIAPFF, uint[] DHMJBKJAIGC)
	{
		for (int i = 0; i < DHMJBKJAIGC.Length; i++)
		{
			DHMJBKJAIGC[i] = EFODDMAJNOA(FAPGOCDNGIB, JBAJPGIAPFF);
			JBAJPGIAPFF += 4;
		}
	}

	internal static byte[] LHKOONEHKNH(ulong IDHLPOFDLKJ)
	{
		byte[] array = new byte[8];
		LHKOONEHKNH(IDHLPOFDLKJ, array, 0);
		return array;
	}

	internal static void LHKOONEHKNH(ulong IDHLPOFDLKJ, byte[] FAPGOCDNGIB)
	{
		MPMAFPANDLC((uint)(IDHLPOFDLKJ >> 32), FAPGOCDNGIB);
		MPMAFPANDLC((uint)IDHLPOFDLKJ, FAPGOCDNGIB, 4);
	}

	internal static void LHKOONEHKNH(ulong IDHLPOFDLKJ, byte[] FAPGOCDNGIB, int JBAJPGIAPFF)
	{
		MPMAFPANDLC((uint)(IDHLPOFDLKJ >> 32), FAPGOCDNGIB, JBAJPGIAPFF);
		MPMAFPANDLC((uint)IDHLPOFDLKJ, FAPGOCDNGIB, JBAJPGIAPFF + 4);
	}

	internal static byte[] LHKOONEHKNH(ulong[] DHMJBKJAIGC)
	{
		byte[] array = new byte[8 * DHMJBKJAIGC.Length];
		LHKOONEHKNH(DHMJBKJAIGC, array, 0);
		return array;
	}

	internal static void LHKOONEHKNH(ulong[] DHMJBKJAIGC, byte[] FAPGOCDNGIB, int JBAJPGIAPFF)
	{
		for (int i = 0; i < DHMJBKJAIGC.Length; i++)
		{
			LHKOONEHKNH(DHMJBKJAIGC[i], FAPGOCDNGIB, JBAJPGIAPFF);
			JBAJPGIAPFF += 8;
		}
	}

	internal static ulong KAMACIJLJKL(byte[] FAPGOCDNGIB)
	{
		uint num = EFODDMAJNOA(FAPGOCDNGIB);
		uint num2 = EFODDMAJNOA(FAPGOCDNGIB, 4);
		return ((ulong)num << 32) | num2;
	}

	internal static ulong KAMACIJLJKL(byte[] FAPGOCDNGIB, int JBAJPGIAPFF)
	{
		uint num = EFODDMAJNOA(FAPGOCDNGIB, JBAJPGIAPFF);
		uint num2 = EFODDMAJNOA(FAPGOCDNGIB, JBAJPGIAPFF + 4);
		return ((ulong)num << 32) | num2;
	}

	internal static void KAMACIJLJKL(byte[] FAPGOCDNGIB, int JBAJPGIAPFF, ulong[] DHMJBKJAIGC)
	{
		for (int i = 0; i < DHMJBKJAIGC.Length; i++)
		{
			DHMJBKJAIGC[i] = KAMACIJLJKL(FAPGOCDNGIB, JBAJPGIAPFF);
			JBAJPGIAPFF += 8;
		}
	}

	internal static void PNEKLKOGLNM(ushort IDHLPOFDLKJ, byte[] FAPGOCDNGIB)
	{
		FAPGOCDNGIB[0] = (byte)IDHLPOFDLKJ;
		FAPGOCDNGIB[1] = (byte)(IDHLPOFDLKJ >> 8);
	}

	internal static void PNEKLKOGLNM(ushort IDHLPOFDLKJ, byte[] FAPGOCDNGIB, int JBAJPGIAPFF)
	{
		FAPGOCDNGIB[JBAJPGIAPFF] = (byte)IDHLPOFDLKJ;
		FAPGOCDNGIB[JBAJPGIAPFF + 1] = (byte)(IDHLPOFDLKJ >> 8);
	}

	internal static ushort MHIPBBNIOHA(byte[] FAPGOCDNGIB)
	{
		uint num = (uint)(FAPGOCDNGIB[0] | (FAPGOCDNGIB[1] << 8));
		return (ushort)num;
	}

	internal static ushort MHIPBBNIOHA(byte[] FAPGOCDNGIB, int JBAJPGIAPFF)
	{
		uint num = (uint)(FAPGOCDNGIB[JBAJPGIAPFF] | (FAPGOCDNGIB[JBAJPGIAPFF + 1] << 8));
		return (ushort)num;
	}

	internal static byte[] LGJFKMLLKLN(uint IDHLPOFDLKJ)
	{
		byte[] array = new byte[4];
		LGJFKMLLKLN(IDHLPOFDLKJ, array, 0);
		return array;
	}

	internal static void LGJFKMLLKLN(uint IDHLPOFDLKJ, byte[] FAPGOCDNGIB)
	{
		FAPGOCDNGIB[0] = (byte)IDHLPOFDLKJ;
		FAPGOCDNGIB[1] = (byte)(IDHLPOFDLKJ >> 8);
		FAPGOCDNGIB[2] = (byte)(IDHLPOFDLKJ >> 16);
		FAPGOCDNGIB[3] = (byte)(IDHLPOFDLKJ >> 24);
	}

	internal static void LGJFKMLLKLN(uint IDHLPOFDLKJ, byte[] FAPGOCDNGIB, int JBAJPGIAPFF)
	{
		FAPGOCDNGIB[JBAJPGIAPFF] = (byte)IDHLPOFDLKJ;
		FAPGOCDNGIB[JBAJPGIAPFF + 1] = (byte)(IDHLPOFDLKJ >> 8);
		FAPGOCDNGIB[JBAJPGIAPFF + 2] = (byte)(IDHLPOFDLKJ >> 16);
		FAPGOCDNGIB[JBAJPGIAPFF + 3] = (byte)(IDHLPOFDLKJ >> 24);
	}

	internal static byte[] LGJFKMLLKLN(uint[] DHMJBKJAIGC)
	{
		byte[] array = new byte[4 * DHMJBKJAIGC.Length];
		LGJFKMLLKLN(DHMJBKJAIGC, array, 0);
		return array;
	}

	internal static void LGJFKMLLKLN(uint[] DHMJBKJAIGC, byte[] FAPGOCDNGIB, int JBAJPGIAPFF)
	{
		for (int i = 0; i < DHMJBKJAIGC.Length; i++)
		{
			LGJFKMLLKLN(DHMJBKJAIGC[i], FAPGOCDNGIB, JBAJPGIAPFF);
			JBAJPGIAPFF += 4;
		}
	}

	internal static uint LAJPMLKCDOH(byte[] FAPGOCDNGIB)
	{
		return (uint)(FAPGOCDNGIB[0] | (FAPGOCDNGIB[1] << 8) | (FAPGOCDNGIB[2] << 16) | (FAPGOCDNGIB[3] << 24));
	}

	internal static uint LAJPMLKCDOH(byte[] FAPGOCDNGIB, int JBAJPGIAPFF)
	{
		return (uint)(FAPGOCDNGIB[JBAJPGIAPFF] | (FAPGOCDNGIB[JBAJPGIAPFF + 1] << 8) | (FAPGOCDNGIB[JBAJPGIAPFF + 2] << 16) | (FAPGOCDNGIB[JBAJPGIAPFF + 3] << 24));
	}

	internal static void LAJPMLKCDOH(byte[] FAPGOCDNGIB, int JBAJPGIAPFF, uint[] DHMJBKJAIGC)
	{
		for (int i = 0; i < DHMJBKJAIGC.Length; i++)
		{
			DHMJBKJAIGC[i] = LAJPMLKCDOH(FAPGOCDNGIB, JBAJPGIAPFF);
			JBAJPGIAPFF += 4;
		}
	}

	internal static void LAJPMLKCDOH(byte[] FAPGOCDNGIB, int GPKPKBELEPL, uint[] DHMJBKJAIGC, int GMHHINCECKG, int ENMLICFLHAO)
	{
		for (int i = 0; i < ENMLICFLHAO; i++)
		{
			DHMJBKJAIGC[GMHHINCECKG + i] = LAJPMLKCDOH(FAPGOCDNGIB, GPKPKBELEPL);
			GPKPKBELEPL += 4;
		}
	}

	internal static uint[] LAJPMLKCDOH(byte[] FAPGOCDNGIB, int JBAJPGIAPFF, int ENMLICFLHAO)
	{
		uint[] array = new uint[ENMLICFLHAO];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = LAJPMLKCDOH(FAPGOCDNGIB, JBAJPGIAPFF);
			JBAJPGIAPFF += 4;
		}
		return array;
	}

	internal static byte[] ICLMPOAFJKJ(ulong IDHLPOFDLKJ)
	{
		byte[] array = new byte[8];
		ICLMPOAFJKJ(IDHLPOFDLKJ, array, 0);
		return array;
	}

	internal static void ICLMPOAFJKJ(ulong IDHLPOFDLKJ, byte[] FAPGOCDNGIB)
	{
		LGJFKMLLKLN((uint)IDHLPOFDLKJ, FAPGOCDNGIB);
		LGJFKMLLKLN((uint)(IDHLPOFDLKJ >> 32), FAPGOCDNGIB, 4);
	}

	internal static void ICLMPOAFJKJ(ulong IDHLPOFDLKJ, byte[] FAPGOCDNGIB, int JBAJPGIAPFF)
	{
		LGJFKMLLKLN((uint)IDHLPOFDLKJ, FAPGOCDNGIB, JBAJPGIAPFF);
		LGJFKMLLKLN((uint)(IDHLPOFDLKJ >> 32), FAPGOCDNGIB, JBAJPGIAPFF + 4);
	}

	internal static ulong HLAFFGIFLEA(byte[] FAPGOCDNGIB)
	{
		uint num = LAJPMLKCDOH(FAPGOCDNGIB);
		uint num2 = LAJPMLKCDOH(FAPGOCDNGIB, 4);
		return ((ulong)num2 << 32) | num;
	}

	internal static ulong HLAFFGIFLEA(byte[] FAPGOCDNGIB, int JBAJPGIAPFF)
	{
		uint num = LAJPMLKCDOH(FAPGOCDNGIB, JBAJPGIAPFF);
		uint num2 = LAJPMLKCDOH(FAPGOCDNGIB, JBAJPGIAPFF + 4);
		return ((ulong)num2 << 32) | num;
	}
}
