using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

internal class NGLCIALNDGA
{
	private delegate Dictionary<string, string> OECFLNLBNNO(string NHEAHEBCFGP);

	protected const string EMDBBGINDHJ = "Crashlytics";

	private static readonly string EPOKDAJEKKF = "\\s?\\(.*\\)";

	private static readonly string OMGPFIFGKCK = "(?<class>[^\\s]+)\\.(?<method>[^\\s\\.]+)" + EPOKDAJEKKF;

	private static readonly string HDGPNGAPAOA = OMGPFIFGKCK + " .*[/|\\\\](?<file>.+):(?<line>\\d+)";

	private static readonly string PAJOIEGEIOO = "<filename unknown>";

	private static readonly string[] MDJMHIFLECJ = new string[1] { Environment.NewLine };

	public static NGLCIALNDGA PGEHJDFMKII()
	{
		return new MPMPOFJKKEM();
	}

	public virtual void KLOLOMLCLBB(bool LJCPOAOKFOE)
	{
	}

	public virtual void LEKBJGOMHNP()
	{
		AOJMDKPBIKH.ILNNDCGJCKG("Crashlytics", "Method Crash () is unimplemented on this platform");
	}

	public virtual void GCJPFNFPIIB()
	{
		string text = null;
		string oEFCOJLNCKP = text.ToLower();
		AOJMDKPBIKH.ILNNDCGJCKG("Crashlytics", oEFCOJLNCKP);
	}

	public virtual void ILNNDCGJCKG(string OEFCOJLNCKP)
	{
		AOJMDKPBIKH.ILNNDCGJCKG("Crashlytics", "Would log custom message if running on a physical device: " + OEFCOJLNCKP);
	}

	public virtual void JEMODHFMDHO(string IKNCPEPOKGJ, string EDDNOJDPMCF)
	{
		AOJMDKPBIKH.ILNNDCGJCKG("Crashlytics", "Would set key-value if running on a physical device: " + IKNCPEPOKGJ + ":" + EDDNOJDPMCF);
	}

	public virtual void AJDNJDFOGOH(string GMBNJCKNOBD)
	{
		AOJMDKPBIKH.ILNNDCGJCKG("Crashlytics", "Would set user identifier if running on a physical device: " + GMBNJCKNOBD);
	}

	public virtual void CHBONNOODHO(string HCMFNNPEKDN)
	{
		AOJMDKPBIKH.ILNNDCGJCKG("Crashlytics", "Would set user email if running on a physical device: " + HCMFNNPEKDN);
	}

	public virtual void NFKIHNEPNFJ(string IOCMOCCFALN)
	{
		AOJMDKPBIKH.ILNNDCGJCKG("Crashlytics", "Would set user name if running on a physical device: " + IOCMOCCFALN);
	}

	public virtual void JFPLDMEBIJH(string IOCMOCCFALN, string OJCKIOENBEL, StackTrace MECGPCLCGKG)
	{
		AOJMDKPBIKH.ILNNDCGJCKG("Crashlytics", "Would record custom exception if running on a physical device: " + IOCMOCCFALN + ", " + OJCKIOENBEL);
	}

	public virtual void JFPLDMEBIJH(string IOCMOCCFALN, string OJCKIOENBEL, string OEJFCIGGCHA)
	{
		AOJMDKPBIKH.ILNNDCGJCKG("Crashlytics", "Would record custom exception if running on a physical device: " + IOCMOCCFALN + ", " + OJCKIOENBEL);
	}

	private static Dictionary<string, string> NEABGFJPFJN(string KMFPOJPMHBI, string NHEAHEBCFGP)
	{
		MatchCollection matchCollection = Regex.Matches(NHEAHEBCFGP, KMFPOJPMHBI);
		if (matchCollection.Count < 1)
		{
			return null;
		}
		Match match = matchCollection[0];
		if (!match.Groups["class"].Success || !match.Groups["method"].Success)
		{
			return null;
		}
		string text = ((!match.Groups["file"].Success) ? match.Groups["class"].Value : match.Groups["file"].Value);
		string value = ((!match.Groups["line"].Success) ? "0" : match.Groups["line"].Value);
		if (text == PAJOIEGEIOO)
		{
			text = match.Groups["class"].Value;
			value = "0";
		}
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("class", match.Groups["class"].Value);
		dictionary.Add("method", match.Groups["method"].Value);
		dictionary.Add("file", text);
		dictionary.Add("line", value);
		return dictionary;
	}

	protected static Dictionary<string, string>[] EEBPMDNNGFJ(string OEJFCIGGCHA)
	{
		string text = null;
		List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
		string[] array = OEJFCIGGCHA.Split(MDJMHIFLECJ, StringSplitOptions.None);
		if (array.Length < 1)
		{
			return list.ToArray();
		}
		if (Regex.Matches(array[0], HDGPNGAPAOA).Count == 1)
		{
			text = HDGPNGAPAOA;
		}
		else
		{
			if (Regex.Matches(array[0], OMGPFIFGKCK).Count != 1)
			{
				return list.ToArray();
			}
			text = OMGPFIFGKCK;
		}
		string[] array2 = array;
		foreach (string nHEAHEBCFGP in array2)
		{
			Dictionary<string, string> dictionary = NEABGFJPFJN(text, nHEAHEBCFGP);
			if (dictionary != null)
			{
				list.Add(dictionary);
			}
		}
		return list.ToArray();
	}
}
