using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

public class FGBEECPLAIG
{
	public static Dictionary<string, string> GMPLJMGEAAA(TextAsset HKLFKEFJAAE)
	{
		string @string = Encoding.UTF8.GetString(HKLFKEFJAAE.bytes, 0, HKLFKEFJAAE.bytes.Length);
		@string = @string.Replace("\r\n", "\n");
		@string = @string.Replace("\r", "\n");
		StringReader stringReader = new StringReader(@string);
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.Ordinal);
		string bBIEJBIHPLE;
		while ((bBIEJBIHPLE = stringReader.ReadLine()) != null)
		{
			string IKNCPEPOKGJ;
			string EDDNOJDPMCF;
			string OECAPAGLMAB;
			string CHBGAGCLPMO;
			string EBKEKNIEJGD;
			if (FNIADEIBFCB(bBIEJBIHPLE, out IKNCPEPOKGJ, out EDDNOJDPMCF, out OECAPAGLMAB, out CHBGAGCLPMO, out EBKEKNIEJGD) && !string.IsNullOrEmpty(IKNCPEPOKGJ) && !string.IsNullOrEmpty(EDDNOJDPMCF))
			{
				dictionary[IKNCPEPOKGJ] = EDDNOJDPMCF;
			}
		}
		return dictionary;
	}

	public static bool FNIADEIBFCB(string BBIEJBIHPLE, out string IKNCPEPOKGJ, out string EDDNOJDPMCF, out string OECAPAGLMAB, out string CHBGAGCLPMO, out string EBKEKNIEJGD)
	{
		IKNCPEPOKGJ = string.Empty;
		OECAPAGLMAB = string.Empty;
		CHBGAGCLPMO = string.Empty;
		EBKEKNIEJGD = string.Empty;
		EDDNOJDPMCF = string.Empty;
		int num = BBIEJBIHPLE.LastIndexOf("//");
		if (num >= 0)
		{
			CHBGAGCLPMO = BBIEJBIHPLE.Substring(num + 2).Trim();
			CHBGAGCLPMO = DMJOJHFDLJE(CHBGAGCLPMO);
			BBIEJBIHPLE = BBIEJBIHPLE.Substring(0, num);
		}
		int num2 = BBIEJBIHPLE.IndexOf("=");
		if (num2 < 0)
		{
			return false;
		}
		IKNCPEPOKGJ = BBIEJBIHPLE.Substring(0, num2).Trim();
		EDDNOJDPMCF = BBIEJBIHPLE.Substring(num2 + 1).Trim();
		EDDNOJDPMCF = EDDNOJDPMCF.Replace("\r\n", "\n").Replace("\n", "\\n");
		EDDNOJDPMCF = DMJOJHFDLJE(EDDNOJDPMCF);
		if (IKNCPEPOKGJ.Length > 2 && IKNCPEPOKGJ[0] == '[')
		{
			int num3 = IKNCPEPOKGJ.IndexOf(']');
			if (num3 >= 0)
			{
				EBKEKNIEJGD = IKNCPEPOKGJ.Substring(1, num3 - 1);
				IKNCPEPOKGJ = IKNCPEPOKGJ.Substring(num3 + 1);
			}
		}
		OAAIMAMHALF(ref IKNCPEPOKGJ);
		return true;
	}

	public static string KKMHGMAHLHH(string MJCBDBIDMGF, Encoding NJPMJNHGDNE)
	{
		string text = string.Empty;
		using (StreamReader streamReader = new StreamReader(MJCBDBIDMGF, NJPMJNHGDNE))
		{
			text = streamReader.ReadToEnd();
		}
		text = text.Replace("\r\n", "\n");
		return text.Replace("\r", "\n");
	}

	public static List<string[]> HJNGBJCPPHO(string NKFGCOFBKMA, char PJCMEAMAHOA = ',')
	{
		int ILKCPLDOEFA = 0;
		List<string[]> list = new List<string[]>();
		while (ILKCPLDOEFA < NKFGCOFBKMA.Length)
		{
			string[] array = FMOCOBODDII(NKFGCOFBKMA, ref ILKCPLDOEFA, PJCMEAMAHOA);
			if (array == null)
			{
				break;
			}
			list.Add(array);
		}
		return list;
	}

	private static string[] FMOCOBODDII(string BEHMDOENJPN, ref int ILKCPLDOEFA, char PJCMEAMAHOA)
	{
		List<string> PNKBIONHGEJ = new List<string>();
		int length = BEHMDOENJPN.Length;
		int LEGJEDBKGMP = ILKCPLDOEFA;
		bool flag = false;
		while (ILKCPLDOEFA < length)
		{
			char c = BEHMDOENJPN[ILKCPLDOEFA];
			if (flag)
			{
				if (c == '"')
				{
					if (ILKCPLDOEFA + 1 >= length || BEHMDOENJPN[ILKCPLDOEFA + 1] != '"')
					{
						flag = false;
					}
					else if (ILKCPLDOEFA + 2 < length && BEHMDOENJPN[ILKCPLDOEFA + 2] == '"')
					{
						flag = false;
						ILKCPLDOEFA += 2;
					}
					else
					{
						ILKCPLDOEFA++;
					}
				}
			}
			else if (c == '\n' || c == PJCMEAMAHOA)
			{
				KOCLEGOMIMP(ref PNKBIONHGEJ, ref BEHMDOENJPN, ILKCPLDOEFA, ref LEGJEDBKGMP);
				if (c == '\n')
				{
					ILKCPLDOEFA++;
					break;
				}
			}
			else if (c == '"')
			{
				flag = true;
			}
			ILKCPLDOEFA++;
		}
		if (ILKCPLDOEFA > LEGJEDBKGMP)
		{
			KOCLEGOMIMP(ref PNKBIONHGEJ, ref BEHMDOENJPN, ILKCPLDOEFA, ref LEGJEDBKGMP);
		}
		return PNKBIONHGEJ.ToArray();
	}

	private static void KOCLEGOMIMP(ref List<string> PNKBIONHGEJ, ref string BEHMDOENJPN, int PFJFBLFKGOF, ref int LEGJEDBKGMP)
	{
		string text = BEHMDOENJPN.Substring(LEGJEDBKGMP, PFJFBLFKGOF - LEGJEDBKGMP);
		LEGJEDBKGMP = PFJFBLFKGOF + 1;
		text = text.Replace("\"\"", "\"");
		if (text.Length > 1 && text[0] == '"' && text[text.Length - 1] == '"')
		{
			text = text.Substring(1, text.Length - 2);
		}
		PNKBIONHGEJ.Add(text);
	}

	public static List<string[]> GGAACPHHMKE(string NKFGCOFBKMA)
	{
		string[] separator = new string[1] { "[*]" };
		string[] separator2 = new string[1] { "[ln]" };
		List<string[]> list = new List<string[]>();
		string[] array = NKFGCOFBKMA.Split(separator2, StringSplitOptions.None);
		foreach (string text in array)
		{
			list.Add(text.Split(separator, StringSplitOptions.None));
		}
		return list;
	}

	public static void OAAIMAMHALF(ref string ONHHAFBOPFG)
	{
		ONHHAFBOPFG = ONHHAFBOPFG.Replace('\\', '/');
		int num = ONHHAFBOPFG.IndexOf('/');
		if (num >= 0)
		{
			int startIndex;
			while ((startIndex = ONHHAFBOPFG.LastIndexOf('/')) != num)
			{
				ONHHAFBOPFG = ONHHAFBOPFG.Remove(startIndex, 1);
			}
		}
	}

	public static string HFJBOKNECOE(string GFPBBLPMOOL)
	{
		if (string.IsNullOrEmpty(GFPBBLPMOOL))
		{
			return string.Empty;
		}
		return GFPBBLPMOOL.Replace("\r\n", "<\\n>").Replace("\r", "<\\n>").Replace("\n", "<\\n>");
	}

	public static string DMJOJHFDLJE(string GFPBBLPMOOL)
	{
		if (string.IsNullOrEmpty(GFPBBLPMOOL))
		{
			return string.Empty;
		}
		return GFPBBLPMOOL.Replace("<\\n>", "\r\n");
	}
}
