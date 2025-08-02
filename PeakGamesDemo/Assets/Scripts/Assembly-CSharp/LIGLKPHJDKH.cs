using System;
using System.IO;

public sealed class LIGLKPHJDKH
{
	private LIGLKPHJDKH()
	{
	}

	public static string IDEBJNEELHF(byte[] MBBPBGHKLJM)
	{
		return Convert.ToBase64String(MBBPBGHKLJM, 0, MBBPBGHKLJM.Length);
	}

	public static string IDEBJNEELHF(byte[] MBBPBGHKLJM, int JBAJPGIAPFF, int EOFAGACBNFP)
	{
		return Convert.ToBase64String(MBBPBGHKLJM, JBAJPGIAPFF, EOFAGACBNFP);
	}

	public static byte[] LMDBBPLCJDM(byte[] MBBPBGHKLJM)
	{
		return LMDBBPLCJDM(MBBPBGHKLJM, 0, MBBPBGHKLJM.Length);
	}

	public static byte[] LMDBBPLCJDM(byte[] MBBPBGHKLJM, int JBAJPGIAPFF, int EOFAGACBNFP)
	{
		string iBBBMACIBGK = Convert.ToBase64String(MBBPBGHKLJM, JBAJPGIAPFF, EOFAGACBNFP);
		return CCGLOIJJMKC.IFHLAPJLHNG(iBBBMACIBGK);
	}

	public static int LMDBBPLCJDM(byte[] MBBPBGHKLJM, Stream OMCALCLJPOD)
	{
		byte[] array = LMDBBPLCJDM(MBBPBGHKLJM);
		OMCALCLJPOD.Write(array, 0, array.Length);
		return array.Length;
	}

	public static int LMDBBPLCJDM(byte[] MBBPBGHKLJM, int JBAJPGIAPFF, int EOFAGACBNFP, Stream OMCALCLJPOD)
	{
		byte[] array = LMDBBPLCJDM(MBBPBGHKLJM, JBAJPGIAPFF, EOFAGACBNFP);
		OMCALCLJPOD.Write(array, 0, array.Length);
		return array.Length;
	}

	public static byte[] ILOALOLANOL(byte[] MBBPBGHKLJM)
	{
		string s = CCGLOIJJMKC.DNHBLFMKDDH(MBBPBGHKLJM);
		return Convert.FromBase64String(s);
	}

	public static byte[] ILOALOLANOL(string MBBPBGHKLJM)
	{
		return Convert.FromBase64String(MBBPBGHKLJM);
	}

	public static int ILOALOLANOL(string MBBPBGHKLJM, Stream OMCALCLJPOD)
	{
		byte[] array = ILOALOLANOL(MBBPBGHKLJM);
		OMCALCLJPOD.Write(array, 0, array.Length);
		return array.Length;
	}
}
