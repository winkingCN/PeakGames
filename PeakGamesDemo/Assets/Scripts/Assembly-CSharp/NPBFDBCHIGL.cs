using System.IO;
using Org.BouncyCastle.Utilities.IO;

public sealed class NPBFDBCHIGL
{
	private const int CGCJKPHBNBN = 512;

	private NPBFDBCHIGL()
	{
	}

	public static void LJBNACEMHEP(Stream FILBOAMBNOP)
	{
		byte[] array = new byte[512];
		while (FILBOAMBNOP.Read(array, 0, array.Length) > 0)
		{
		}
	}

	public static byte[] FOJKFJEEFJN(Stream FILBOAMBNOP)
	{
		MemoryStream memoryStream = new MemoryStream();
		CDMHFNBBNIF(FILBOAMBNOP, memoryStream);
		return memoryStream.ToArray();
	}

	public static byte[] PMJJHBEIGCP(Stream FILBOAMBNOP, int GJHEBCMICMA)
	{
		MemoryStream memoryStream = new MemoryStream();
		DPKCBDFCEBC(FILBOAMBNOP, GJHEBCMICMA, memoryStream);
		return memoryStream.ToArray();
	}

	public static int PCNDKGFHPJN(Stream FILBOAMBNOP, byte[] GHPCHPOHELF)
	{
		return PCNDKGFHPJN(FILBOAMBNOP, GHPCHPOHELF, 0, GHPCHPOHELF.Length);
	}

	public static int PCNDKGFHPJN(Stream FILBOAMBNOP, byte[] GHPCHPOHELF, int JBAJPGIAPFF, int NBEDPKHALCN)
	{
		int i;
		int num;
		for (i = 0; i < NBEDPKHALCN; i += num)
		{
			num = FILBOAMBNOP.Read(GHPCHPOHELF, JBAJPGIAPFF + i, NBEDPKHALCN - i);
			if (num < 1)
			{
				break;
			}
		}
		return i;
	}

	public static void CDMHFNBBNIF(Stream FILBOAMBNOP, Stream OBDBEMFLBID)
	{
		byte[] array = new byte[512];
		int count;
		while ((count = FILBOAMBNOP.Read(array, 0, array.Length)) > 0)
		{
			OBDBEMFLBID.Write(array, 0, count);
		}
	}

	public static long DPKCBDFCEBC(Stream FILBOAMBNOP, long GJHEBCMICMA, Stream OBDBEMFLBID)
	{
		byte[] array = new byte[512];
		long num = 0L;
		int num2;
		while ((num2 = FILBOAMBNOP.Read(array, 0, array.Length)) > 0)
		{
			if (GJHEBCMICMA - num < num2)
			{
				throw new StreamOverflowException("Data Overflow");
			}
			num += num2;
			OBDBEMFLBID.Write(array, 0, num2);
		}
		return num;
	}
}
