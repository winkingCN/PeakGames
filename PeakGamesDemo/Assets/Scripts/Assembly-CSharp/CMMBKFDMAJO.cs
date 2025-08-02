using System;
using System.Text;

public class CMMBKFDMAJO
{
	public static char[] PDHOBKPAGGL = "ÝúbUu\u0010\u008b\u00b8CÁÂ§*4\u0013PÚ©-á©¾@T6D\u0089l\u000f±\u0091ÒWâuzÅm4GÐó\u0019Ø$=Í g,¥Q\u0083\të®iKEß r¡\u0019\u009f×6\u00160Ít \u00904öÃ\u0093~^«\u001cy\u0003:\u0090\u0096Èd\u0010\u008f1\u001a<Q\u008f\u0099ÛÝúbUu\u0010\u008b\u00b8CÁÂ§*4\u0013PÚ©-á©¾@T6D\u0089l\u000f±\u0091ÒWâuzÅm4GÐó\u0019Ø$=Í g,¥Q\u0083\të®iKEß r¡\u0019\u009f×6\u00160Ít \u00904öÃ\u0093~^«\u001cy\u0003:\u0090\u0096Èd".ToCharArray();

	public static string LMDBBPLCJDM(string DIIAJFHKDAH)
	{
		try
		{
			string nANNNENPKIG = HNJHNCMENCD(DIIAJFHKDAH);
			return CGIHAPBEFAB(nANNNENPKIG);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static string ILOALOLANOL(string MPNBBKHKPEI)
	{
		try
		{
			string dIIAJFHKDAH = EMICFABIEBP(MPNBBKHKPEI);
			return HNJHNCMENCD(dIIAJFHKDAH);
		}
		catch (Exception)
		{
			return null;
		}
	}

	private static string CGIHAPBEFAB(string NANNNENPKIG)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(NANNNENPKIG);
		return Convert.ToBase64String(bytes);
	}

	private static string EMICFABIEBP(string PAJDMKENBPM)
	{
		byte[] bytes = Convert.FromBase64String(PAJDMKENBPM);
		return Encoding.UTF8.GetString(bytes);
	}

	private static string HNJHNCMENCD(string DIIAJFHKDAH)
	{
		try
		{
			char[] pDHOBKPAGGL = PDHOBKPAGGL;
			char[] array = DIIAJFHKDAH.ToCharArray();
			int num = pDHOBKPAGGL.Length;
			int i = 0;
			for (int num2 = array.Length; i < num2; i++)
			{
				array[i] = (char)(array[i] ^ pDHOBKPAGGL[i % num] ^ (byte)((i % 2 != 0) ? (-i * 51) : (i * 23)));
			}
			return new string(array);
		}
		catch (Exception)
		{
			return null;
		}
	}
}
