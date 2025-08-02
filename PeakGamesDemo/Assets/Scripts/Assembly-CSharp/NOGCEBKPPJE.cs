using System;
using System.Text;
using Org.BouncyCastle.Math;

public abstract class NOGCEBKPPJE
{
	public static bool ICKLINNFHKK(bool[] MNIMEAMHNMI, bool[] BCIHLCMFAEK)
	{
		if (MNIMEAMHNMI == BCIHLCMFAEK)
		{
			return true;
		}
		if (MNIMEAMHNMI == null || BCIHLCMFAEK == null)
		{
			return false;
		}
		return HHLPIMMCGAB(MNIMEAMHNMI, BCIHLCMFAEK);
	}

	public static bool ICKLINNFHKK(char[] MNIMEAMHNMI, char[] BCIHLCMFAEK)
	{
		if (MNIMEAMHNMI == BCIHLCMFAEK)
		{
			return true;
		}
		if (MNIMEAMHNMI == null || BCIHLCMFAEK == null)
		{
			return false;
		}
		return HHLPIMMCGAB(MNIMEAMHNMI, BCIHLCMFAEK);
	}

	public static bool ICKLINNFHKK(byte[] MNIMEAMHNMI, byte[] BCIHLCMFAEK)
	{
		if (MNIMEAMHNMI == BCIHLCMFAEK)
		{
			return true;
		}
		if (MNIMEAMHNMI == null || BCIHLCMFAEK == null)
		{
			return false;
		}
		return HHLPIMMCGAB(MNIMEAMHNMI, BCIHLCMFAEK);
	}

	[Obsolete("Use 'AreEqual' method instead")]
	public static bool PDBLINCIMGK(byte[] MNIMEAMHNMI, byte[] BCIHLCMFAEK)
	{
		return ICKLINNFHKK(MNIMEAMHNMI, BCIHLCMFAEK);
	}

	public static bool PBBFCJBKJEN(byte[] MNIMEAMHNMI, byte[] BCIHLCMFAEK)
	{
		int num = MNIMEAMHNMI.Length;
		if (num != BCIHLCMFAEK.Length)
		{
			return false;
		}
		int num2 = 0;
		while (num != 0)
		{
			num--;
			num2 |= MNIMEAMHNMI[num] ^ BCIHLCMFAEK[num];
		}
		return num2 == 0;
	}

	public static bool ICKLINNFHKK(int[] MNIMEAMHNMI, int[] BCIHLCMFAEK)
	{
		if (MNIMEAMHNMI == BCIHLCMFAEK)
		{
			return true;
		}
		if (MNIMEAMHNMI == null || BCIHLCMFAEK == null)
		{
			return false;
		}
		return HHLPIMMCGAB(MNIMEAMHNMI, BCIHLCMFAEK);
	}

	public static bool ICKLINNFHKK(uint[] MNIMEAMHNMI, uint[] BCIHLCMFAEK)
	{
		if (MNIMEAMHNMI == BCIHLCMFAEK)
		{
			return true;
		}
		if (MNIMEAMHNMI == null || BCIHLCMFAEK == null)
		{
			return false;
		}
		return HHLPIMMCGAB(MNIMEAMHNMI, BCIHLCMFAEK);
	}

	private static bool HHLPIMMCGAB(bool[] MNIMEAMHNMI, bool[] BCIHLCMFAEK)
	{
		int num = MNIMEAMHNMI.Length;
		if (num != BCIHLCMFAEK.Length)
		{
			return false;
		}
		while (num != 0)
		{
			num--;
			if (MNIMEAMHNMI[num] != BCIHLCMFAEK[num])
			{
				return false;
			}
		}
		return true;
	}

	private static bool HHLPIMMCGAB(char[] MNIMEAMHNMI, char[] BCIHLCMFAEK)
	{
		int num = MNIMEAMHNMI.Length;
		if (num != BCIHLCMFAEK.Length)
		{
			return false;
		}
		while (num != 0)
		{
			num--;
			if (MNIMEAMHNMI[num] != BCIHLCMFAEK[num])
			{
				return false;
			}
		}
		return true;
	}

	private static bool HHLPIMMCGAB(byte[] MNIMEAMHNMI, byte[] BCIHLCMFAEK)
	{
		int num = MNIMEAMHNMI.Length;
		if (num != BCIHLCMFAEK.Length)
		{
			return false;
		}
		while (num != 0)
		{
			num--;
			if (MNIMEAMHNMI[num] != BCIHLCMFAEK[num])
			{
				return false;
			}
		}
		return true;
	}

	private static bool HHLPIMMCGAB(int[] MNIMEAMHNMI, int[] BCIHLCMFAEK)
	{
		int num = MNIMEAMHNMI.Length;
		if (num != BCIHLCMFAEK.Length)
		{
			return false;
		}
		while (num != 0)
		{
			num--;
			if (MNIMEAMHNMI[num] != BCIHLCMFAEK[num])
			{
				return false;
			}
		}
		return true;
	}

	private static bool HHLPIMMCGAB(uint[] MNIMEAMHNMI, uint[] BCIHLCMFAEK)
	{
		int num = MNIMEAMHNMI.Length;
		if (num != BCIHLCMFAEK.Length)
		{
			return false;
		}
		while (num != 0)
		{
			num--;
			if (MNIMEAMHNMI[num] != BCIHLCMFAEK[num])
			{
				return false;
			}
		}
		return true;
	}

	public static string NHMGCGBMCNM(object[] MNIMEAMHNMI)
	{
		StringBuilder stringBuilder = new StringBuilder(91);
		if (MNIMEAMHNMI.Length > 0)
		{
			stringBuilder.Append(MNIMEAMHNMI[0]);
			for (int i = 1; i < MNIMEAMHNMI.Length; i++)
			{
				stringBuilder.Append(", ").Append(MNIMEAMHNMI[i]);
			}
		}
		stringBuilder.Append(']');
		return stringBuilder.ToString();
	}

	public static int ILMFICENEMK(byte[] MBBPBGHKLJM)
	{
		if (MBBPBGHKLJM == null)
		{
			return 0;
		}
		int num = MBBPBGHKLJM.Length;
		int num2 = num + 1;
		while (--num >= 0)
		{
			num2 *= 257;
			num2 ^= MBBPBGHKLJM[num];
		}
		return num2;
	}

	public static int ILMFICENEMK(byte[] MBBPBGHKLJM, int JBAJPGIAPFF, int NBEDPKHALCN)
	{
		if (MBBPBGHKLJM == null)
		{
			return 0;
		}
		int num = NBEDPKHALCN;
		int num2 = num + 1;
		while (--num >= 0)
		{
			num2 *= 257;
			num2 ^= MBBPBGHKLJM[JBAJPGIAPFF + num];
		}
		return num2;
	}

	public static int ILMFICENEMK(int[] MBBPBGHKLJM)
	{
		if (MBBPBGHKLJM == null)
		{
			return 0;
		}
		int num = MBBPBGHKLJM.Length;
		int num2 = num + 1;
		while (--num >= 0)
		{
			num2 *= 257;
			num2 ^= MBBPBGHKLJM[num];
		}
		return num2;
	}

	public static int ILMFICENEMK(int[] MBBPBGHKLJM, int JBAJPGIAPFF, int NBEDPKHALCN)
	{
		if (MBBPBGHKLJM == null)
		{
			return 0;
		}
		int num = NBEDPKHALCN;
		int num2 = num + 1;
		while (--num >= 0)
		{
			num2 *= 257;
			num2 ^= MBBPBGHKLJM[JBAJPGIAPFF + num];
		}
		return num2;
	}

	public static int ILMFICENEMK(uint[] MBBPBGHKLJM)
	{
		if (MBBPBGHKLJM == null)
		{
			return 0;
		}
		int num = MBBPBGHKLJM.Length;
		int num2 = num + 1;
		while (--num >= 0)
		{
			num2 *= 257;
			num2 ^= (int)MBBPBGHKLJM[num];
		}
		return num2;
	}

	public static int ILMFICENEMK(uint[] MBBPBGHKLJM, int JBAJPGIAPFF, int NBEDPKHALCN)
	{
		if (MBBPBGHKLJM == null)
		{
			return 0;
		}
		int num = NBEDPKHALCN;
		int num2 = num + 1;
		while (--num >= 0)
		{
			num2 *= 257;
			num2 ^= (int)MBBPBGHKLJM[JBAJPGIAPFF + num];
		}
		return num2;
	}

	public static int ILMFICENEMK(ulong[] MBBPBGHKLJM)
	{
		if (MBBPBGHKLJM == null)
		{
			return 0;
		}
		int num = MBBPBGHKLJM.Length;
		int num2 = num + 1;
		while (--num >= 0)
		{
			ulong num3 = MBBPBGHKLJM[num];
			num2 *= 257;
			num2 ^= (int)num3;
			num2 *= 257;
			num2 ^= (int)(num3 >> 32);
		}
		return num2;
	}

	public static int ILMFICENEMK(ulong[] MBBPBGHKLJM, int JBAJPGIAPFF, int NBEDPKHALCN)
	{
		if (MBBPBGHKLJM == null)
		{
			return 0;
		}
		int num = NBEDPKHALCN;
		int num2 = num + 1;
		while (--num >= 0)
		{
			ulong num3 = MBBPBGHKLJM[JBAJPGIAPFF + num];
			num2 *= 257;
			num2 ^= (int)num3;
			num2 *= 257;
			num2 ^= (int)(num3 >> 32);
		}
		return num2;
	}

	public static byte[] IKBFGGABMKP(byte[] MBBPBGHKLJM)
	{
		return (MBBPBGHKLJM != null) ? ((byte[])MBBPBGHKLJM.Clone()) : null;
	}

	public static byte[] IKBFGGABMKP(byte[] MBBPBGHKLJM, byte[] IEADPMNHHIA)
	{
		if (MBBPBGHKLJM == null)
		{
			return null;
		}
		if (IEADPMNHHIA == null || IEADPMNHHIA.Length != MBBPBGHKLJM.Length)
		{
			return IKBFGGABMKP(MBBPBGHKLJM);
		}
		Array.Copy(MBBPBGHKLJM, 0, IEADPMNHHIA, 0, IEADPMNHHIA.Length);
		return IEADPMNHHIA;
	}

	public static int[] IKBFGGABMKP(int[] MBBPBGHKLJM)
	{
		return (MBBPBGHKLJM != null) ? ((int[])MBBPBGHKLJM.Clone()) : null;
	}

	internal static uint[] IKBFGGABMKP(uint[] MBBPBGHKLJM)
	{
		return (MBBPBGHKLJM != null) ? ((uint[])MBBPBGHKLJM.Clone()) : null;
	}

	public static long[] IKBFGGABMKP(long[] MBBPBGHKLJM)
	{
		return (MBBPBGHKLJM != null) ? ((long[])MBBPBGHKLJM.Clone()) : null;
	}

	public static ulong[] IKBFGGABMKP(ulong[] MBBPBGHKLJM)
	{
		return (MBBPBGHKLJM != null) ? ((ulong[])MBBPBGHKLJM.Clone()) : null;
	}

	public static ulong[] IKBFGGABMKP(ulong[] MBBPBGHKLJM, ulong[] IEADPMNHHIA)
	{
		if (MBBPBGHKLJM == null)
		{
			return null;
		}
		if (IEADPMNHHIA == null || IEADPMNHHIA.Length != MBBPBGHKLJM.Length)
		{
			return IKBFGGABMKP(MBBPBGHKLJM);
		}
		Array.Copy(MBBPBGHKLJM, 0, IEADPMNHHIA, 0, IEADPMNHHIA.Length);
		return IEADPMNHHIA;
	}

	public static bool KMDACNACKII(byte[] MNIMEAMHNMI, byte IDHLPOFDLKJ)
	{
		for (int i = 0; i < MNIMEAMHNMI.Length; i++)
		{
			if (MNIMEAMHNMI[i] == IDHLPOFDLKJ)
			{
				return true;
			}
		}
		return false;
	}

	public static bool KMDACNACKII(short[] MNIMEAMHNMI, short IDHLPOFDLKJ)
	{
		for (int i = 0; i < MNIMEAMHNMI.Length; i++)
		{
			if (MNIMEAMHNMI[i] == IDHLPOFDLKJ)
			{
				return true;
			}
		}
		return false;
	}

	public static bool KMDACNACKII(int[] MNIMEAMHNMI, int IDHLPOFDLKJ)
	{
		for (int i = 0; i < MNIMEAMHNMI.Length; i++)
		{
			if (MNIMEAMHNMI[i] == IDHLPOFDLKJ)
			{
				return true;
			}
		}
		return false;
	}

	public static void MEBLOMPDLEJ(byte[] GHPCHPOHELF, byte BCIHLCMFAEK)
	{
		int num = GHPCHPOHELF.Length;
		while (num > 0)
		{
			GHPCHPOHELF[--num] = BCIHLCMFAEK;
		}
	}

	public static byte[] OICFAJBLHEA(byte[] MBBPBGHKLJM, int EJMAIHMFHHO)
	{
		byte[] array = new byte[EJMAIHMFHHO];
		Array.Copy(MBBPBGHKLJM, 0, array, 0, Math.Min(EJMAIHMFHHO, MBBPBGHKLJM.Length));
		return array;
	}

	public static char[] OICFAJBLHEA(char[] MBBPBGHKLJM, int EJMAIHMFHHO)
	{
		char[] array = new char[EJMAIHMFHHO];
		Array.Copy(MBBPBGHKLJM, 0, array, 0, Math.Min(EJMAIHMFHHO, MBBPBGHKLJM.Length));
		return array;
	}

	public static int[] OICFAJBLHEA(int[] MBBPBGHKLJM, int EJMAIHMFHHO)
	{
		int[] array = new int[EJMAIHMFHHO];
		Array.Copy(MBBPBGHKLJM, 0, array, 0, Math.Min(EJMAIHMFHHO, MBBPBGHKLJM.Length));
		return array;
	}

	public static long[] OICFAJBLHEA(long[] MBBPBGHKLJM, int EJMAIHMFHHO)
	{
		long[] array = new long[EJMAIHMFHHO];
		Array.Copy(MBBPBGHKLJM, 0, array, 0, Math.Min(EJMAIHMFHHO, MBBPBGHKLJM.Length));
		return array;
	}

	public static BigInteger[] OICFAJBLHEA(BigInteger[] MBBPBGHKLJM, int EJMAIHMFHHO)
	{
		BigInteger[] array = new BigInteger[EJMAIHMFHHO];
		Array.Copy(MBBPBGHKLJM, 0, array, 0, Math.Min(EJMAIHMFHHO, MBBPBGHKLJM.Length));
		return array;
	}

	public static byte[] EHLHBAMJLNI(byte[] MBBPBGHKLJM, int LLAEDBFNCCP, int BMIOECELGCA)
	{
		int num = NDCMNGCNPFP(LLAEDBFNCCP, BMIOECELGCA);
		byte[] array = new byte[num];
		Array.Copy(MBBPBGHKLJM, LLAEDBFNCCP, array, 0, Math.Min(num, MBBPBGHKLJM.Length - LLAEDBFNCCP));
		return array;
	}

	public static int[] EHLHBAMJLNI(int[] MBBPBGHKLJM, int LLAEDBFNCCP, int BMIOECELGCA)
	{
		int num = NDCMNGCNPFP(LLAEDBFNCCP, BMIOECELGCA);
		int[] array = new int[num];
		Array.Copy(MBBPBGHKLJM, LLAEDBFNCCP, array, 0, Math.Min(num, MBBPBGHKLJM.Length - LLAEDBFNCCP));
		return array;
	}

	public static long[] EHLHBAMJLNI(long[] MBBPBGHKLJM, int LLAEDBFNCCP, int BMIOECELGCA)
	{
		int num = NDCMNGCNPFP(LLAEDBFNCCP, BMIOECELGCA);
		long[] array = new long[num];
		Array.Copy(MBBPBGHKLJM, LLAEDBFNCCP, array, 0, Math.Min(num, MBBPBGHKLJM.Length - LLAEDBFNCCP));
		return array;
	}

	public static BigInteger[] EHLHBAMJLNI(BigInteger[] MBBPBGHKLJM, int LLAEDBFNCCP, int BMIOECELGCA)
	{
		int num = NDCMNGCNPFP(LLAEDBFNCCP, BMIOECELGCA);
		BigInteger[] array = new BigInteger[num];
		Array.Copy(MBBPBGHKLJM, LLAEDBFNCCP, array, 0, Math.Min(num, MBBPBGHKLJM.Length - LLAEDBFNCCP));
		return array;
	}

	private static int NDCMNGCNPFP(int LLAEDBFNCCP, int BMIOECELGCA)
	{
		int num = BMIOECELGCA - LLAEDBFNCCP;
		if (num < 0)
		{
			throw new ArgumentException(LLAEDBFNCCP + " > " + BMIOECELGCA);
		}
		return num;
	}

	public static byte[] GBKNDKCPBEH(byte[] MNIMEAMHNMI, byte BCIHLCMFAEK)
	{
		if (MNIMEAMHNMI == null)
		{
			return new byte[1] { BCIHLCMFAEK };
		}
		int num = MNIMEAMHNMI.Length;
		byte[] array = new byte[num + 1];
		Array.Copy(MNIMEAMHNMI, 0, array, 0, num);
		array[num] = BCIHLCMFAEK;
		return array;
	}

	public static short[] GBKNDKCPBEH(short[] MNIMEAMHNMI, short BCIHLCMFAEK)
	{
		if (MNIMEAMHNMI == null)
		{
			return new short[1] { BCIHLCMFAEK };
		}
		int num = MNIMEAMHNMI.Length;
		short[] array = new short[num + 1];
		Array.Copy(MNIMEAMHNMI, 0, array, 0, num);
		array[num] = BCIHLCMFAEK;
		return array;
	}

	public static int[] GBKNDKCPBEH(int[] MNIMEAMHNMI, int BCIHLCMFAEK)
	{
		if (MNIMEAMHNMI == null)
		{
			return new int[1] { BCIHLCMFAEK };
		}
		int num = MNIMEAMHNMI.Length;
		int[] array = new int[num + 1];
		Array.Copy(MNIMEAMHNMI, 0, array, 0, num);
		array[num] = BCIHLCMFAEK;
		return array;
	}

	public static byte[] PHNDEHFNLGG(byte[] MNIMEAMHNMI, byte[] BCIHLCMFAEK)
	{
		if (MNIMEAMHNMI == null)
		{
			return IKBFGGABMKP(BCIHLCMFAEK);
		}
		if (BCIHLCMFAEK == null)
		{
			return IKBFGGABMKP(MNIMEAMHNMI);
		}
		byte[] array = new byte[MNIMEAMHNMI.Length + BCIHLCMFAEK.Length];
		Array.Copy(MNIMEAMHNMI, 0, array, 0, MNIMEAMHNMI.Length);
		Array.Copy(BCIHLCMFAEK, 0, array, MNIMEAMHNMI.Length, BCIHLCMFAEK.Length);
		return array;
	}

	public static byte[] CCMHPFGEKEF(params byte[][] HABANFGJKKI)
	{
		byte[][] array = new byte[HABANFGJKKI.Length][];
		int num = 0;
		int num2 = 0;
		foreach (byte[] array2 in HABANFGJKKI)
		{
			if (array2 != null)
			{
				array[num++] = array2;
				num2 += array2.Length;
			}
		}
		byte[] array3 = new byte[num2];
		int num3 = 0;
		for (int j = 0; j < num; j++)
		{
			byte[] array4 = array[j];
			Array.Copy(array4, 0, array3, num3, array4.Length);
			num3 += array4.Length;
		}
		return array3;
	}

	public static int[] PHNDEHFNLGG(int[] MNIMEAMHNMI, int[] BCIHLCMFAEK)
	{
		if (MNIMEAMHNMI == null)
		{
			return IKBFGGABMKP(BCIHLCMFAEK);
		}
		if (BCIHLCMFAEK == null)
		{
			return IKBFGGABMKP(MNIMEAMHNMI);
		}
		int[] array = new int[MNIMEAMHNMI.Length + BCIHLCMFAEK.Length];
		Array.Copy(MNIMEAMHNMI, 0, array, 0, MNIMEAMHNMI.Length);
		Array.Copy(BCIHLCMFAEK, 0, array, MNIMEAMHNMI.Length, BCIHLCMFAEK.Length);
		return array;
	}

	public static byte[] JLIDOPNDFBO(byte[] MNIMEAMHNMI, byte BCIHLCMFAEK)
	{
		if (MNIMEAMHNMI == null)
		{
			return new byte[1] { BCIHLCMFAEK };
		}
		int num = MNIMEAMHNMI.Length;
		byte[] array = new byte[num + 1];
		Array.Copy(MNIMEAMHNMI, 0, array, 1, num);
		array[0] = BCIHLCMFAEK;
		return array;
	}

	public static short[] JLIDOPNDFBO(short[] MNIMEAMHNMI, short BCIHLCMFAEK)
	{
		if (MNIMEAMHNMI == null)
		{
			return new short[1] { BCIHLCMFAEK };
		}
		int num = MNIMEAMHNMI.Length;
		short[] array = new short[num + 1];
		Array.Copy(MNIMEAMHNMI, 0, array, 1, num);
		array[0] = BCIHLCMFAEK;
		return array;
	}

	public static int[] JLIDOPNDFBO(int[] MNIMEAMHNMI, int BCIHLCMFAEK)
	{
		if (MNIMEAMHNMI == null)
		{
			return new int[1] { BCIHLCMFAEK };
		}
		int num = MNIMEAMHNMI.Length;
		int[] array = new int[num + 1];
		Array.Copy(MNIMEAMHNMI, 0, array, 1, num);
		array[0] = BCIHLCMFAEK;
		return array;
	}

	public static byte[] GLGGGAHFEGL(byte[] MNIMEAMHNMI)
	{
		if (MNIMEAMHNMI == null)
		{
			return null;
		}
		int num = 0;
		int num2 = MNIMEAMHNMI.Length;
		byte[] array = new byte[num2];
		while (--num2 >= 0)
		{
			array[num2] = MNIMEAMHNMI[num++];
		}
		return array;
	}

	public static int[] GLGGGAHFEGL(int[] MNIMEAMHNMI)
	{
		if (MNIMEAMHNMI == null)
		{
			return null;
		}
		int num = 0;
		int num2 = MNIMEAMHNMI.Length;
		int[] array = new int[num2];
		while (--num2 >= 0)
		{
			array[num2] = MNIMEAMHNMI[num++];
		}
		return array;
	}
}
