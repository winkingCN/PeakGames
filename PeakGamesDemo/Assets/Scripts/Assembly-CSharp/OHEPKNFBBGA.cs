using System;
using System.Globalization;

public class OHEPKNFBBGA
{
	public static bool NAFCDEECGEF(string MGLLCJGFOLN)
	{
		return BDFOHKBEGGO(MGLLCJGFOLN) || KCGCNFBKCMC(MGLLCJGFOLN);
	}

	public static bool AGIPKPIEEJC(string MGLLCJGFOLN)
	{
		return COHDBICODLD(MGLLCJGFOLN) || BLKDNADEBJJ(MGLLCJGFOLN);
	}

	public static bool BDFOHKBEGGO(string MGLLCJGFOLN)
	{
		try
		{
			return LIFGDOEEFIO(MGLLCJGFOLN);
		}
		catch (FormatException)
		{
		}
		catch (OverflowException)
		{
		}
		return false;
	}

	private static bool LIFGDOEEFIO(string MGLLCJGFOLN)
	{
		if (MGLLCJGFOLN.Length == 0)
		{
			return false;
		}
		int num = 0;
		string text = MGLLCJGFOLN + ".";
		int num2 = 0;
		int num3;
		while (num2 < text.Length && (num3 = text.IndexOf('.', num2)) > num2)
		{
			if (num == 4)
			{
				return false;
			}
			string s = text.Substring(num2, num3 - num2);
			int num4 = int.Parse(s);
			if (num4 < 0 || num4 > 255)
			{
				return false;
			}
			num2 = num3 + 1;
			num++;
		}
		return num == 4;
	}

	public static bool COHDBICODLD(string MGLLCJGFOLN)
	{
		int num = MGLLCJGFOLN.IndexOf('/');
		string text = MGLLCJGFOLN.Substring(num + 1);
		return num > 0 && BDFOHKBEGGO(MGLLCJGFOLN.Substring(0, num)) && (BDFOHKBEGGO(text) || GJIJIDNNHGF(text, 32));
	}

	public static bool BLKDNADEBJJ(string MGLLCJGFOLN)
	{
		int num = MGLLCJGFOLN.IndexOf('/');
		string text = MGLLCJGFOLN.Substring(num + 1);
		return num > 0 && KCGCNFBKCMC(MGLLCJGFOLN.Substring(0, num)) && (KCGCNFBKCMC(text) || GJIJIDNNHGF(text, 128));
	}

	private static bool GJIJIDNNHGF(string IGBAPJEMPKN, int MOFHAKELNPN)
	{
		int num = int.Parse(IGBAPJEMPKN);
		try
		{
			return num >= 0 && num <= MOFHAKELNPN;
		}
		catch (FormatException)
		{
		}
		catch (OverflowException)
		{
		}
		return false;
	}

	public static bool KCGCNFBKCMC(string MGLLCJGFOLN)
	{
		try
		{
			return ALMFMMMIJLL(MGLLCJGFOLN);
		}
		catch (FormatException)
		{
		}
		catch (OverflowException)
		{
		}
		return false;
	}

	private static bool ALMFMMMIJLL(string MGLLCJGFOLN)
	{
		if (MGLLCJGFOLN.Length == 0)
		{
			return false;
		}
		int num = 0;
		string text = MGLLCJGFOLN + ":";
		bool flag = false;
		int num2 = 0;
		int num3;
		while (num2 < text.Length && (num3 = text.IndexOf(':', num2)) >= num2)
		{
			if (num == 8)
			{
				return false;
			}
			if (num2 != num3)
			{
				string text2 = text.Substring(num2, num3 - num2);
				if (num3 == text.Length - 1 && text2.IndexOf('.') > 0)
				{
					if (!BDFOHKBEGGO(text2))
					{
						return false;
					}
					num++;
				}
				else
				{
					string s = text.Substring(num2, num3 - num2);
					int num4 = int.Parse(s, NumberStyles.AllowHexSpecifier);
					if (num4 < 0 || num4 > 65535)
					{
						return false;
					}
				}
			}
			else
			{
				if (num3 != 1 && num3 != text.Length - 1 && flag)
				{
					return false;
				}
				flag = true;
			}
			num2 = num3 + 1;
			num++;
		}
		return num == 8 || flag;
	}
}
