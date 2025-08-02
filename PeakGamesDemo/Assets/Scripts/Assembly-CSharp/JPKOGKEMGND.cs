using System;
using System.Linq;
using System.Runtime.CompilerServices;

public class JPKOGKEMGND
{
	[CompilerGenerated]
	private static Func<char, bool> EBCOMJBLIPP;

	internal static string GJFCPBIOPKF(string FCJBBPHFNPJ)
	{
		char[] array = FCJBBPHFNPJ.ToArray();
		bool flag = false;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == '\u093f' && !char.IsWhiteSpace(array[i - 1]) && array[i - 1] != 0)
			{
				array[i] = array[i - 1];
				array[i - 1] = '\u093f';
				flag = true;
			}
			if (i != array.Length - 1)
			{
				if (array[i] == 'इ' && array[i + 1] == '\u093c')
				{
					array[i] = 'ऌ';
					array[i + 1] = '\0';
					flag = true;
				}
				if (array[i] == '\u0943' && array[i + 1] == '\u093c')
				{
					array[i] = '\u0944';
					array[i + 1] = '\0';
					flag = true;
				}
				if (array[i] == '\u0901' && array[i + 1] == '\u093c')
				{
					array[i] = 'ॐ';
					array[i + 1] = '\0';
					flag = true;
				}
				if (array[i] == 'ऋ' && array[i + 1] == '\u093c')
				{
					array[i] = 'ॠ';
					array[i + 1] = '\0';
					flag = true;
				}
				if (array[i] == 'ई' && array[i + 1] == '\u093c')
				{
					array[i] = 'ॡ';
					array[i + 1] = '\0';
					flag = true;
				}
				if (array[i] == '\u093f' && array[i + 1] == '\u093c')
				{
					array[i] = '\u0962';
					array[i + 1] = '\0';
					flag = true;
				}
				if (array[i] == '\u0940' && array[i + 1] == '\u093c')
				{
					array[i] = '\u0963';
					array[i + 1] = '\0';
					flag = true;
				}
				if (array[i] == '।' && array[i + 1] == '\u093c')
				{
					array[i] = 'ऽ';
					array[i + 1] = '\0';
					flag = true;
				}
			}
		}
		if (!flag)
		{
			return FCJBBPHFNPJ;
		}
		string text = new string(array.Where((char AMFCENFNAJJ) => AMFCENFNAJJ != '\0').ToArray());
		if (text == FCJBBPHFNPJ)
		{
			return text;
		}
		FCJBBPHFNPJ = text;
		return FCJBBPHFNPJ;
	}

	[CompilerGenerated]
	private static bool HEGLPJIPBEH(char AMFCENFNAJJ)
	{
		return AMFCENFNAJJ != '\0';
	}
}
