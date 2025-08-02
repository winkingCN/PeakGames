using System;
using System.Collections.Generic;

internal class HCAENLHIMHE
{
	internal static bool GPNELGKHGCE = true;

	internal static bool ELLBLCECGPC;

	internal static string NIANMFLLJIE(string GFPBBLPMOOL, out List<DGCNKDMFNPG> AJNAKKGEDNM)
	{
		AJNAKKGEDNM = new List<DGCNKDMFNPG>();
		char[] array = GFPBBLPMOOL.ToCharArray();
		int num = 0;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == '\u064b')
			{
				AJNAKKGEDNM.Add(new DGCNKDMFNPG('\u064b', i));
				num++;
			}
			else if (array[i] == '\u064c')
			{
				AJNAKKGEDNM.Add(new DGCNKDMFNPG('\u064c', i));
				num++;
			}
			else if (array[i] == '\u064d')
			{
				AJNAKKGEDNM.Add(new DGCNKDMFNPG('\u064d', i));
				num++;
			}
			else if (array[i] == '\u064e')
			{
				if (num > 0 && AJNAKKGEDNM[num - 1].HGINOPNKMND == '\u0651')
				{
					AJNAKKGEDNM[num - 1].HGINOPNKMND = 'ﱠ';
					continue;
				}
				AJNAKKGEDNM.Add(new DGCNKDMFNPG('\u064e', i));
				num++;
			}
			else if (array[i] == '\u064f')
			{
				if (num > 0 && AJNAKKGEDNM[num - 1].HGINOPNKMND == '\u0651')
				{
					AJNAKKGEDNM[num - 1].HGINOPNKMND = 'ﱡ';
					continue;
				}
				AJNAKKGEDNM.Add(new DGCNKDMFNPG('\u064f', i));
				num++;
			}
			else if (array[i] == '\u0650')
			{
				if (num > 0 && AJNAKKGEDNM[num - 1].HGINOPNKMND == '\u0651')
				{
					AJNAKKGEDNM[num - 1].HGINOPNKMND = 'ﱢ';
					continue;
				}
				AJNAKKGEDNM.Add(new DGCNKDMFNPG('\u0650', i));
				num++;
			}
			else if (array[i] == '\u0651')
			{
				if (num > 0)
				{
					if (AJNAKKGEDNM[num - 1].HGINOPNKMND == '\u064e')
					{
						AJNAKKGEDNM[num - 1].HGINOPNKMND = 'ﱠ';
						continue;
					}
					if (AJNAKKGEDNM[num - 1].HGINOPNKMND == '\u064f')
					{
						AJNAKKGEDNM[num - 1].HGINOPNKMND = 'ﱡ';
						continue;
					}
					if (AJNAKKGEDNM[num - 1].HGINOPNKMND == '\u0650')
					{
						AJNAKKGEDNM[num - 1].HGINOPNKMND = 'ﱢ';
						continue;
					}
				}
				AJNAKKGEDNM.Add(new DGCNKDMFNPG('\u0651', i));
				num++;
			}
			else if (array[i] == '\u0652')
			{
				AJNAKKGEDNM.Add(new DGCNKDMFNPG('\u0652', i));
				num++;
			}
			else if (array[i] == '\u0653')
			{
				AJNAKKGEDNM.Add(new DGCNKDMFNPG('\u0653', i));
				num++;
			}
		}
		string[] array2 = GFPBBLPMOOL.Split('\u064b', '\u064c', '\u064d', '\u064e', '\u064f', '\u0650', '\u0651', '\u0652', '\u0653', 'ﱠ', 'ﱡ', 'ﱢ');
		GFPBBLPMOOL = string.Empty;
		string[] array3 = array2;
		foreach (string text in array3)
		{
			GFPBBLPMOOL += text;
		}
		return GFPBBLPMOOL;
	}

	internal static char[] LJDHMOFBJID(char[] GBPHNMKJBOD, List<DGCNKDMFNPG> AJNAKKGEDNM)
	{
		char[] array = new char[GBPHNMKJBOD.Length + AJNAKKGEDNM.Count];
		int num = 0;
		for (int i = 0; i < GBPHNMKJBOD.Length; i++)
		{
			array[num] = GBPHNMKJBOD[i];
			num++;
			foreach (DGCNKDMFNPG item in AJNAKKGEDNM)
			{
				if (item.LDMDBPLADGD == num)
				{
					array[num] = item.HGINOPNKMND;
					num++;
				}
			}
		}
		return array;
	}

	internal static string DDKGPAAKLMH(string GFPBBLPMOOL)
	{
		string text = string.Empty;
		List<DGCNKDMFNPG> AJNAKKGEDNM;
		string text2 = NIANMFLLJIE(GFPBBLPMOOL, out AJNAKKGEDNM);
		char[] array = text2.ToCharArray();
		char[] array2 = text2.ToCharArray();
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (char)DNFNKNNDNDF.CKEGHMGGLLA.JEFLOGJKAMH(array[i]);
		}
		for (int j = 0; j < array.Length; j++)
		{
			bool flag = false;
			if (array[j] == 'ﻝ' && j < array.Length - 1)
			{
				if (array[j + 1] == 'ﺇ')
				{
					array[j] = 'ﻷ';
					array2[j + 1] = '\uffff';
					flag = true;
				}
				else if (array[j + 1] == 'ﺍ')
				{
					array[j] = 'ﻹ';
					array2[j + 1] = '\uffff';
					flag = true;
				}
				else if (array[j + 1] == 'ﺃ')
				{
					array[j] = 'ﻵ';
					array2[j + 1] = '\uffff';
					flag = true;
				}
				else if (array[j + 1] == 'ﺁ')
				{
					array[j] = 'ﻳ';
					array2[j + 1] = '\uffff';
					flag = true;
				}
			}
			if (!ODDEHCEJLHG(array[j]))
			{
				if (OMIFDLFALNC(array, j))
				{
					array2[j] = (char)(array[j] + 3);
				}
				else if (LAPEJELJBFK(array, j))
				{
					array2[j] = (char)(array[j] + 1);
				}
				else if (FBLIGIKIAIM(array, j))
				{
					array2[j] = (char)(array[j] + 2);
				}
			}
			text = text + Convert.ToString(array[j], 16) + " ";
			if (flag)
			{
				j++;
			}
			if (ELLBLCECGPC)
			{
				if (array[j] == '0')
				{
					array2[j] = '٠';
				}
				else if (array[j] == '1')
				{
					array2[j] = '١';
				}
				else if (array[j] == '2')
				{
					array2[j] = '٢';
				}
				else if (array[j] == '3')
				{
					array2[j] = '٣';
				}
				else if (array[j] == '4')
				{
					array2[j] = '٤';
				}
				else if (array[j] == '5')
				{
					array2[j] = '٥';
				}
				else if (array[j] == '6')
				{
					array2[j] = '٦';
				}
				else if (array[j] == '7')
				{
					array2[j] = '٧';
				}
				else if (array[j] == '8')
				{
					array2[j] = '٨';
				}
				else if (array[j] == '9')
				{
					array2[j] = '٩';
				}
			}
		}
		if (GPNELGKHGCE)
		{
			array2 = LJDHMOFBJID(array2, AJNAKKGEDNM);
		}
		List<char> list = new List<char>();
		List<char> list2 = new List<char>();
		for (int num = array2.Length - 1; num >= 0; num--)
		{
			if (char.IsPunctuation(array2[num]) && num > 0 && num < array2.Length - 1 && (char.IsPunctuation(array2[num - 1]) || char.IsPunctuation(array2[num + 1])))
			{
				if (array2[num] == '(')
				{
					list.Add(')');
				}
				else if (array2[num] == ')')
				{
					list.Add('(');
				}
				else if (array2[num] == '<')
				{
					list.Add('>');
				}
				else if (array2[num] == '>')
				{
					list.Add('<');
				}
				else if (array2[num] == '[')
				{
					list.Add(']');
				}
				else if (array2[num] == ']')
				{
					list.Add('[');
				}
				else if (array2[num] != '\uffff')
				{
					list.Add(array2[num]);
				}
			}
			else if (array2[num] == ' ' && num > 0 && num < array2.Length - 1 && (char.IsLower(array2[num - 1]) || char.IsUpper(array2[num - 1]) || char.IsNumber(array2[num - 1])) && (char.IsLower(array2[num + 1]) || char.IsUpper(array2[num + 1]) || char.IsNumber(array2[num + 1])))
			{
				list2.Add(array2[num]);
			}
			else if (char.IsNumber(array2[num]) || char.IsLower(array2[num]) || char.IsUpper(array2[num]) || char.IsSymbol(array2[num]) || char.IsPunctuation(array2[num]))
			{
				if (array2[num] == '(')
				{
					list2.Add(')');
				}
				else if (array2[num] == ')')
				{
					list2.Add('(');
				}
				else if (array2[num] == '<')
				{
					list2.Add('>');
				}
				else if (array2[num] == '>')
				{
					list2.Add('<');
				}
				else if (array2[num] == '[')
				{
					list.Add(']');
				}
				else if (array2[num] == ']')
				{
					list.Add('[');
				}
				else
				{
					list2.Add(array2[num]);
				}
			}
			else if ((array2[num] >= '\ud800' && array2[num] <= '\udbff') || (array2[num] >= '\udc00' && array2[num] <= '\udfff'))
			{
				list2.Add(array2[num]);
			}
			else
			{
				if (list2.Count > 0)
				{
					for (int k = 0; k < list2.Count; k++)
					{
						list.Add(list2[list2.Count - 1 - k]);
					}
					list2.Clear();
				}
				if (array2[num] != '\uffff')
				{
					list.Add(array2[num]);
				}
			}
		}
		if (list2.Count > 0)
		{
			for (int l = 0; l < list2.Count; l++)
			{
				list.Add(list2[list2.Count - 1 - l]);
			}
			list2.Clear();
		}
		array2 = new char[list.Count];
		for (int m = 0; m < array2.Length; m++)
		{
			array2[m] = list[m];
		}
		GFPBBLPMOOL = new string(array2);
		return GFPBBLPMOOL;
	}

	internal static bool ODDEHCEJLHG(char GKDKBFOPOJG)
	{
		bool flag = char.IsPunctuation(GKDKBFOPOJG);
		bool flag2 = char.IsNumber(GKDKBFOPOJG);
		bool flag3 = char.IsLower(GKDKBFOPOJG);
		bool flag4 = char.IsUpper(GKDKBFOPOJG);
		bool flag5 = char.IsSymbol(GKDKBFOPOJG);
		bool flag6 = GKDKBFOPOJG == 'ﭖ' || GKDKBFOPOJG == 'ﭺ' || GKDKBFOPOJG == 'ﮊ' || GKDKBFOPOJG == 'ﮒ' || GKDKBFOPOJG == 'ﮎ';
		bool flag7 = (GKDKBFOPOJG <= '\ufeff' && GKDKBFOPOJG >= 'ﹰ') || flag6 || GKDKBFOPOJG == 'ﯼ';
		return flag || flag2 || flag3 || flag4 || flag5 || !flag7 || GKDKBFOPOJG == 'a' || GKDKBFOPOJG == '>' || GKDKBFOPOJG == '<' || GKDKBFOPOJG == '؛';
	}

	internal static bool FBLIGIKIAIM(char[] GBPHNMKJBOD, int EHJNMODJEAN)
	{
		bool flag = EHJNMODJEAN == 0 || GBPHNMKJBOD[EHJNMODJEAN - 1] == ' ' || GBPHNMKJBOD[EHJNMODJEAN - 1] == '*' || GBPHNMKJBOD[EHJNMODJEAN - 1] == 'A' || char.IsPunctuation(GBPHNMKJBOD[EHJNMODJEAN - 1]) || GBPHNMKJBOD[EHJNMODJEAN - 1] == '>' || GBPHNMKJBOD[EHJNMODJEAN - 1] == '<' || GBPHNMKJBOD[EHJNMODJEAN - 1] == 'ﺍ' || GBPHNMKJBOD[EHJNMODJEAN - 1] == 'ﺩ' || GBPHNMKJBOD[EHJNMODJEAN - 1] == 'ﺫ' || GBPHNMKJBOD[EHJNMODJEAN - 1] == 'ﺭ' || GBPHNMKJBOD[EHJNMODJEAN - 1] == 'ﺯ' || GBPHNMKJBOD[EHJNMODJEAN - 1] == 'ﮊ' || GBPHNMKJBOD[EHJNMODJEAN - 1] == 'ﻭ' || GBPHNMKJBOD[EHJNMODJEAN - 1] == 'ﺁ' || GBPHNMKJBOD[EHJNMODJEAN - 1] == 'ﺃ' || GBPHNMKJBOD[EHJNMODJEAN - 1] == 'ﺇ' || GBPHNMKJBOD[EHJNMODJEAN - 1] == 'ﺅ';
		bool flag2 = GBPHNMKJBOD[EHJNMODJEAN] != ' ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﺩ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﺫ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﺭ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﺯ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﮊ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﺍ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﺃ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﺇ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﺁ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﺅ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﻭ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﺀ';
		bool flag3 = EHJNMODJEAN < GBPHNMKJBOD.Length - 1 && GBPHNMKJBOD[EHJNMODJEAN + 1] != ' ' && !char.IsPunctuation(GBPHNMKJBOD[EHJNMODJEAN + 1]) && !char.IsNumber(GBPHNMKJBOD[EHJNMODJEAN + 1]) && !char.IsSymbol(GBPHNMKJBOD[EHJNMODJEAN + 1]) && !char.IsLower(GBPHNMKJBOD[EHJNMODJEAN + 1]) && !char.IsUpper(GBPHNMKJBOD[EHJNMODJEAN + 1]) && GBPHNMKJBOD[EHJNMODJEAN + 1] != 'ﺀ';
		if (flag && flag2 && flag3)
		{
			return true;
		}
		return false;
	}

	internal static bool LAPEJELJBFK(char[] GBPHNMKJBOD, int EHJNMODJEAN)
	{
		bool flag = EHJNMODJEAN != 0 && GBPHNMKJBOD[EHJNMODJEAN - 1] != ' ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﺩ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﺫ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﺭ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﺯ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﮊ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﻭ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﺍ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﺁ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﺃ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﺇ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﺅ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﺀ' && !char.IsPunctuation(GBPHNMKJBOD[EHJNMODJEAN - 1]) && GBPHNMKJBOD[EHJNMODJEAN - 1] != '>' && GBPHNMKJBOD[EHJNMODJEAN - 1] != '<';
		bool flag2 = GBPHNMKJBOD[EHJNMODJEAN] != ' ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﺀ';
		if (flag && flag2)
		{
			return true;
		}
		return false;
	}

	internal static bool OMIFDLFALNC(char[] GBPHNMKJBOD, int EHJNMODJEAN)
	{
		bool flag = EHJNMODJEAN != 0 && GBPHNMKJBOD[EHJNMODJEAN] != 'ﺍ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﺩ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﺫ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﺭ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﺯ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﮊ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﻭ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﺁ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﺃ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﺇ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﺅ' && GBPHNMKJBOD[EHJNMODJEAN] != 'ﺀ';
		bool flag2 = EHJNMODJEAN != 0 && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﺍ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﺩ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﺫ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﺭ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﺯ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﮊ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﻭ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﺁ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﺃ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﺇ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﺅ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != 'ﺀ' && !char.IsPunctuation(GBPHNMKJBOD[EHJNMODJEAN - 1]) && GBPHNMKJBOD[EHJNMODJEAN - 1] != '>' && GBPHNMKJBOD[EHJNMODJEAN - 1] != '<' && GBPHNMKJBOD[EHJNMODJEAN - 1] != ' ' && GBPHNMKJBOD[EHJNMODJEAN - 1] != '*';
		if (EHJNMODJEAN < GBPHNMKJBOD.Length - 1 && GBPHNMKJBOD[EHJNMODJEAN + 1] != ' ' && GBPHNMKJBOD[EHJNMODJEAN + 1] != '\r' && GBPHNMKJBOD[EHJNMODJEAN + 1] != 'ﺀ' && !char.IsNumber(GBPHNMKJBOD[EHJNMODJEAN + 1]) && !char.IsSymbol(GBPHNMKJBOD[EHJNMODJEAN + 1]) && !char.IsPunctuation(GBPHNMKJBOD[EHJNMODJEAN + 1]) && flag2 && flag)
		{
			try
			{
				if (char.IsPunctuation(GBPHNMKJBOD[EHJNMODJEAN + 1]))
				{
					return false;
				}
				return true;
			}
			catch
			{
				return false;
			}
		}
		return false;
	}
}
