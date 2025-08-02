using System.IO;

public sealed class DCDJMDOEKHC
{
	private static readonly CPPGAJFHILC FBIKMFBIMIK = new KCKDHDPHEKC();

	private DCDJMDOEKHC()
	{
	}

	public static string ALIGGGKEJEN(byte[] MBBPBGHKLJM)
	{
		return ALIGGGKEJEN(MBBPBGHKLJM, 0, MBBPBGHKLJM.Length);
	}

	public static string ALIGGGKEJEN(byte[] MBBPBGHKLJM, int JBAJPGIAPFF, int EOFAGACBNFP)
	{
		byte[] dIPNEDDIHBK = LMDBBPLCJDM(MBBPBGHKLJM, JBAJPGIAPFF, EOFAGACBNFP);
		return CCGLOIJJMKC.DNHBLFMKDDH(dIPNEDDIHBK);
	}

	public static byte[] LMDBBPLCJDM(byte[] MBBPBGHKLJM)
	{
		return LMDBBPLCJDM(MBBPBGHKLJM, 0, MBBPBGHKLJM.Length);
	}

	public static byte[] LMDBBPLCJDM(byte[] MBBPBGHKLJM, int JBAJPGIAPFF, int EOFAGACBNFP)
	{
		MemoryStream memoryStream = new MemoryStream(EOFAGACBNFP * 2);
		FBIKMFBIMIK.LMDBBPLCJDM(MBBPBGHKLJM, JBAJPGIAPFF, EOFAGACBNFP, memoryStream);
		return memoryStream.ToArray();
	}

	public static int LMDBBPLCJDM(byte[] MBBPBGHKLJM, Stream OMCALCLJPOD)
	{
		return FBIKMFBIMIK.LMDBBPLCJDM(MBBPBGHKLJM, 0, MBBPBGHKLJM.Length, OMCALCLJPOD);
	}

	public static int LMDBBPLCJDM(byte[] MBBPBGHKLJM, int JBAJPGIAPFF, int EOFAGACBNFP, Stream OMCALCLJPOD)
	{
		return FBIKMFBIMIK.LMDBBPLCJDM(MBBPBGHKLJM, JBAJPGIAPFF, EOFAGACBNFP, OMCALCLJPOD);
	}

	public static byte[] ILOALOLANOL(byte[] MBBPBGHKLJM)
	{
		MemoryStream memoryStream = new MemoryStream((MBBPBGHKLJM.Length + 1) / 2);
		FBIKMFBIMIK.ILOALOLANOL(MBBPBGHKLJM, 0, MBBPBGHKLJM.Length, memoryStream);
		return memoryStream.ToArray();
	}

	public static byte[] ILOALOLANOL(string MBBPBGHKLJM)
	{
		MemoryStream memoryStream = new MemoryStream((MBBPBGHKLJM.Length + 1) / 2);
		FBIKMFBIMIK.DMJOJHFDLJE(MBBPBGHKLJM, memoryStream);
		return memoryStream.ToArray();
	}

	public static int ILOALOLANOL(string MBBPBGHKLJM, Stream OMCALCLJPOD)
	{
		return FBIKMFBIMIK.DMJOJHFDLJE(MBBPBGHKLJM, OMCALCLJPOD);
	}
}
