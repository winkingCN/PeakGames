using System;
using System.Text;

public abstract class CCGLOIJJMKC
{
	internal static bool GFPBNICBHJK(string IBBBMACIBGK, params string[] BLLEHCKDAIJ)
	{
		foreach (string text in BLLEHCKDAIJ)
		{
			if (IBBBMACIBGK == text)
			{
				return true;
			}
		}
		return false;
	}

	public static string HPDCKMOPEMM(byte[] FAPGOCDNGIB)
	{
		char[] array = new char[FAPGOCDNGIB.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = Convert.ToChar(FAPGOCDNGIB[i]);
		}
		return new string(array);
	}

	public static byte[] EDHFCNLPGJC(char[] JBPEGBPPFFO)
	{
		byte[] array = new byte[JBPEGBPPFFO.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = Convert.ToByte(JBPEGBPPFFO[i]);
		}
		return array;
	}

	public static byte[] EDHFCNLPGJC(string IBBBMACIBGK)
	{
		byte[] array = new byte[IBBBMACIBGK.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = Convert.ToByte(IBBBMACIBGK[i]);
		}
		return array;
	}

	public static string DNHBLFMKDDH(byte[] DIPNEDDIHBK)
	{
		return Encoding.ASCII.GetString(DIPNEDDIHBK, 0, DIPNEDDIHBK.Length);
	}

	public static byte[] IFHLAPJLHNG(char[] JBPEGBPPFFO)
	{
		return Encoding.ASCII.GetBytes(JBPEGBPPFFO);
	}

	public static byte[] IFHLAPJLHNG(string IBBBMACIBGK)
	{
		return Encoding.ASCII.GetBytes(IBBBMACIBGK);
	}

	public static string JLEFLJBKGJD(byte[] DIPNEDDIHBK)
	{
		return Encoding.UTF8.GetString(DIPNEDDIHBK, 0, DIPNEDDIHBK.Length);
	}

	public static byte[] KJNGFKIBPAN(char[] JBPEGBPPFFO)
	{
		return Encoding.UTF8.GetBytes(JBPEGBPPFFO);
	}

	public static byte[] KJNGFKIBPAN(string IBBBMACIBGK)
	{
		return Encoding.UTF8.GetBytes(IBBBMACIBGK);
	}
}
