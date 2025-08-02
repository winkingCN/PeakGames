using System.Collections.Generic;
using System.Text;

public static class JOCMHJEKODI
{
	private static readonly HashSet<char> HCIJEFBEMOF = new HashSet<char>(new char[172]
	{
		'₪', 'È', '$', '(', ',', '0', '4', '8', '<', '@',
		'€', 'D', '₩', 'H', 'L', 'P', '₽', 'T', '₹', 'X',
		'\\', '`', 'd', 'h', '£', 'l', 'p', 't', 'x', '|',
		'ô', '∞', '«', '₺', '#', '\'', '+', '/', '3', '7',
		';', '?', 'C', 'G', 'K', 'O', 'S', 'è', 'W', '[',
		'_', 'Ğ', 'c', '¿', 'g', 'k', 'ì', 'o', 's', 'w',
		'{', '»', 'Ë', 'Ê', 'É', 'à', 'Ï', 'Î', 'Í', 'Ì',
		'Ã', 'Â', 'Á', 'À', 'Ç', 'Ä', 'Û', 'Ú', 'Ù', 'ß',
		'Ü', 'Ó', 'Ò', 'Ñ', 'ä', 'Ö', 'Õ', 'Ô', 'ë', 'ê',
		'é', '"', 'ï', 'î', 'í', '&', 'ã', 'â', 'á', '*',
		'ç', '.', 'û', 'ú', 'ù', '2', 'ÿ', '6', 'ó', 'ò',
		'ñ', ':', 'ö', 'õ', '>', 'B', 'F', 'J', 'N', 'R',
		'V', 'Z', '^', '¥', 'b', '¡', 'f', 'j', 'ª', 'n',
		'r', 'v', 'z', 'º', '~', 'ł', 'ü', 'ş', 'Ş', 'œ',
		'Œ', '!', '%', ')', '-', '1', '5', 'Ÿ', '9', '=',
		'A', 'č', 'E', 'I', 'M', 'Q', 'ğ', 'U', '…', 'Y',
		']', 'a', 'e', 'i', 'm', 'q', 'u', 'y', '}', 'İ',
		'ı', ' '
	});

	private static readonly StringBuilder KEBACPPPIJJ = new StringBuilder(100);

	public static string CCCPHOAEONM(this string EBDCOMKHPBG)
	{
		if (EBDCOMKHPBG == null)
		{
			return null;
		}
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < EBDCOMKHPBG.Length; i++)
		{
			char c = EBDCOMKHPBG[i];
			bool flag3 = HCIJEFBEMOF.Contains(c);
			if (flag)
			{
				if (flag3)
				{
					KEBACPPPIJJ.Append(c);
					flag2 = false;
					continue;
				}
				if (!flag2)
				{
					KEBACPPPIJJ.Append('?');
				}
				flag2 = true;
			}
			else if (!flag3)
			{
				flag = true;
				KEBACPPPIJJ.Length = 0;
				if (i > 0)
				{
					KEBACPPPIJJ.Append(EBDCOMKHPBG.Substring(0, i));
				}
				if (!flag2)
				{
					KEBACPPPIJJ.Append('?');
				}
				flag2 = true;
			}
		}
		return (!flag) ? EBDCOMKHPBG : KEBACPPPIJJ.ToString();
	}
}
