using System;

public class KMGNOHNIMEP
{
	public static string GJFCPBIOPKF(string GFPBBLPMOOL)
	{
		return GJFCPBIOPKF(GFPBBLPMOOL, false, true);
	}

	public static string GJFCPBIOPKF(string GFPBBLPMOOL, bool GEFFEJDGBLC)
	{
		if (GEFFEJDGBLC)
		{
			return GJFCPBIOPKF(GFPBBLPMOOL);
		}
		string[] array = GFPBBLPMOOL.Split(' ');
		string text = string.Empty;
		string text2 = string.Empty;
		string[] array2 = array;
		foreach (string text3 in array2)
		{
			if (char.IsLower(text3.ToLower()[text3.Length / 2]))
			{
				text = text + GJFCPBIOPKF(text2) + text3 + " ";
				text2 = string.Empty;
			}
			else
			{
				text2 = text2 + text3 + " ";
			}
		}
		if (text2 != string.Empty)
		{
			text += GJFCPBIOPKF(text2);
		}
		return text;
	}

	public static string GJFCPBIOPKF(string GFPBBLPMOOL, bool GPNELGKHGCE, bool ELLBLCECGPC)
	{
		string text = JPKOGKEMGND.GJFCPBIOPKF(GFPBBLPMOOL);
		if (text != GFPBBLPMOOL)
		{
			return text;
		}
		HCAENLHIMHE.GPNELGKHGCE = GPNELGKHGCE;
		HCAENLHIMHE.ELLBLCECGPC = ELLBLCECGPC;
		if (GFPBBLPMOOL.Contains("\n"))
		{
			GFPBBLPMOOL = GFPBBLPMOOL.Replace("\n", Environment.NewLine);
		}
		if (GFPBBLPMOOL.Contains(Environment.NewLine))
		{
			string[] separator = new string[1] { Environment.NewLine };
			string[] array = GFPBBLPMOOL.Split(separator, StringSplitOptions.None);
			if (array.Length == 0)
			{
				return HCAENLHIMHE.DDKGPAAKLMH(GFPBBLPMOOL);
			}
			if (array.Length == 1)
			{
				return HCAENLHIMHE.DDKGPAAKLMH(GFPBBLPMOOL);
			}
			string text2 = HCAENLHIMHE.DDKGPAAKLMH(array[0]);
			int i = 1;
			if (array.Length > 1)
			{
				for (; i < array.Length; i++)
				{
					text2 = text2 + Environment.NewLine + HCAENLHIMHE.DDKGPAAKLMH(array[i]);
				}
			}
			return text2;
		}
		return HCAENLHIMHE.DDKGPAAKLMH(GFPBBLPMOOL);
	}
}
