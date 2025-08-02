using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

public class ILAMPCAFGIF
{
	private static bool IMPDPCGJAEB;

	public static Dictionary<string, char> HDHNMOLEHOA;

	public static void EPLFBPBJJBO()
	{
		try
		{
			TextAsset textAsset = Resources.Load("Font/EmojiUnicodeLib") as TextAsset;
			HDHNMOLEHOA = new Dictionary<string, char>();
			using (StringReader stringReader = new StringReader(textAsset.text))
			{
				string text = stringReader.ReadLine();
				while (text != null && text.Length > 1)
				{
					string[] array = text.Split(':');
					int value = int.Parse(array[1]);
					string[] array2 = array[0].Split('-');
					for (int i = 0; i < array2.Length; i++)
					{
						array2[i] = char.ConvertFromUtf32(Convert.ToInt32(array2[i], 16));
					}
					string key = string.Join(string.Empty, array2);
					HDHNMOLEHOA[key] = Convert.ToChar(value);
					text = stringReader.ReadLine();
				}
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.EmojiHelper, "Error Loading Emoji Lib. Error:{0}", ex);
		}
	}

	public static bool ANNGBHLJPNN(string MOPCLEEGDFB)
	{
		char value;
		if (HDHNMOLEHOA.TryGetValue(MOPCLEEGDFB, out value))
		{
			return true;
		}
		return false;
	}

	public static string PJIBGAKHHFI(string MOPCLEEGDFB)
	{
		if (MOPCLEEGDFB == null || MOPCLEEGDFB.Length == 0)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		int length = MOPCLEEGDFB.Length;
		while (num < length)
		{
			bool flag = false;
			for (int num2 = 4; num2 > 0; num2--)
			{
				if (num + num2 <= length)
				{
					string key = MOPCLEEGDFB.Substring(num, num2);
					char value;
					if (HDHNMOLEHOA.TryGetValue(key, out value))
					{
						stringBuilder.Append(value);
						num += num2;
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				if (Convert.ToInt32(MOPCLEEGDFB[num]) != 65039)
				{
					stringBuilder.Append(MOPCLEEGDFB[num]);
				}
				num++;
			}
		}
		return stringBuilder.ToString();
	}
}
