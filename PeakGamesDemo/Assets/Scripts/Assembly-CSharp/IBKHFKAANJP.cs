using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using PeakGames.Amy.Core.Helpers.Managed;
using UnityEngine;

public class IBKHFKAANJP
{
	private const string LAIPJDDNHOF = " ";

	private const string FNKPHMOIFMG = "^";

	private static readonly char[] NHJFOFKKNPC = new char[1] { ' ' };

	private static IBKHFKAANJP KNPOFJNFLJB;

	private static Dictionary<string, BadWordLanguageNode> CJLDGDDOLAL;

	public static bool INPPGINLBFC;

	private IBKHFKAANJP()
	{
	}

	public bool DCLMPEPDNKJ(string BIPAJFCNEOB)
	{
		try
		{
			BadWordListRoot badWordListRoot = JsonUtility.FromJson<BadWordListRoot>(BIPAJFCNEOB);
			INPPGINLBFC = badWordListRoot.freeChat;
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.BadWordController, "Free Chat is:" + INPPGINLBFC);
			Dictionary<string, BadWordLanguageNode> dictionary = new Dictionary<string, BadWordLanguageNode>();
			dictionary.Add("en", badWordListRoot.en);
			dictionary.Add("tr", badWordListRoot.tr);
			dictionary.Add("it", badWordListRoot.it);
			dictionary.Add("fr", badWordListRoot.fr);
			dictionary.Add("pt", badWordListRoot.pt);
			dictionary.Add("pt-br", badWordListRoot.pt);
			dictionary.Add("de", badWordListRoot.de);
			dictionary.Add("es", badWordListRoot.es);
			dictionary.Add("dflt", badWordListRoot.dflt);
			dictionary.Add("ru", badWordListRoot.dflt);
			dictionary.Add("ja", badWordListRoot.dflt);
			CJLDGDDOLAL = dictionary;
			return true;
		}
		catch (Exception ex)
		{
			Debug.LogError("There is an error loading bad word filter data! " + ex.Message + " Stack:" + ex.StackTrace);
			return false;
		}
	}

	public static IBKHFKAANJP DGGDDILJFBJ()
	{
		return KNPOFJNFLJB ?? (KNPOFJNFLJB = new IBKHFKAANJP());
	}

	public string ABNBNIEEAAF(string NOIOHIPHFHA, char PDLECGACLBO, string GLFMIMLJAPI)
	{
		string[] array = NOIOHIPHFHA.Split(' ');
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i];
			if (text.Length > 2 && !HLDLGIJPJML(text, GLFMIMLJAPI))
			{
				text = Regex.Replace(text, "[^\\d]", "*");
			}
			stringBuilder.Append(text);
			stringBuilder.Append(" ");
		}
		return stringBuilder.ToString();
	}

	public bool OJEHDCCGHNC(string OEFCOJLNCKP, string GLFMIMLJAPI)
	{
		string[] array = OEFCOJLNCKP.Split(' ');
		foreach (string text in array)
		{
			if (text.Length >= 2 && !HBKMKHDLEBI(text, GLFMIMLJAPI))
			{
				return false;
			}
		}
		return true;
	}

	public bool HBKMKHDLEBI(string BKKMJAIKJAL, string GLFMIMLJAPI)
	{
		string key = GLFMIMLJAPI.ToLower();
		if (!CJLDGDDOLAL.ContainsKey(key))
		{
			return true;
		}
		string input = BKKMJAIKJAL.ToLower();
		input = Regex.Replace(input, "[_+-.,!@#$%^&*();\\/|<>\"']", string.Empty);
		BadWordLanguageNode badWordLanguageNode = CJLDGDDOLAL[key];
		if (badWordLanguageNode != null && !JAAINNEOEND(input, badWordLanguageNode))
		{
			return PDOLNALFJIL(input, badWordLanguageNode);
		}
		bool flag = JAAINNEOEND(input, CJLDGDDOLAL["dflt"]);
		if (!flag)
		{
			return PDOLNALFJIL(input, CJLDGDDOLAL["dflt"]);
		}
		return flag;
	}

	private bool HLDLGIJPJML(string BKKMJAIKJAL, string GLFMIMLJAPI)
	{
		string key = GLFMIMLJAPI.ToLower();
		if (!CJLDGDDOLAL.ContainsKey(key))
		{
			return true;
		}
		string input = BKKMJAIKJAL.ToLower();
		input = Regex.Replace(input, "[_+-.,!@#$%^&*();\\/|<>\"']", string.Empty);
		BadWordLanguageNode badWordLanguageNode = CJLDGDDOLAL[key];
		if (badWordLanguageNode != null && !IBPKJHCDLAH(input, badWordLanguageNode))
		{
			return PDOLNALFJIL(input, CJLDGDDOLAL["dflt"]);
		}
		bool flag = IBPKJHCDLAH(input, CJLDGDDOLAL["dflt"]);
		if (!flag)
		{
			return PDOLNALFJIL(input, CJLDGDDOLAL["dflt"]);
		}
		return flag;
	}

	private static bool PDOLNALFJIL(string LIFLPMHCBIM, BadWordLanguageNode GLFMIMLJAPI)
	{
		string text = LIFLPMHCBIM.Replace(" ", string.Empty);
		for (int i = 0; i < GLFMIMLJAPI.whitelist.Length; i++)
		{
			if (text.Contains(GLFMIMLJAPI.whitelist[i]))
			{
				return true;
			}
		}
		return false;
	}

	private bool IBPKJHCDLAH(string LIFLPMHCBIM, BadWordLanguageNode GLFMIMLJAPI)
	{
		string[] array = LIFLPMHCBIM.Split(NHJFOFKKNPC, 100);
		string text = LIFLPMHCBIM.Replace(" ", string.Empty);
		for (int i = 0; i < GLFMIMLJAPI.justWord.Length; i++)
		{
			string value = GLFMIMLJAPI.justWord[i];
			for (int j = 0; j < array.Length; j++)
			{
				bool flag = true;
				string text2 = array[j];
				if (!(flag & (!array[j].Equals(value) || text2.Length - GLFMIMLJAPI.justWord[i].Length > 1)))
				{
					return false;
				}
			}
		}
		for (int k = 0; k < GLFMIMLJAPI.wholeSentence.Length; k++)
		{
			bool flag2 = true;
			if (!(flag2 & !text.Contains(GLFMIMLJAPI.wholeSentence[k])))
			{
				return false;
			}
		}
		for (int l = 0; l < GLFMIMLJAPI.regex.Length; l++)
		{
			bool flag3 = true;
			if (!(flag3 & !Regex.IsMatch(text, GLFMIMLJAPI.regex[l])))
			{
				return false;
			}
		}
		return true;
	}

	private bool JAAINNEOEND(string LIFLPMHCBIM, BadWordLanguageNode GLFMIMLJAPI)
	{
		string[] array = LIFLPMHCBIM.Split(NHJFOFKKNPC, 100);
		string text = LIFLPMHCBIM.Replace(" ", string.Empty);
		for (int i = 0; i < GLFMIMLJAPI.justWord.Length; i++)
		{
			string pattern = PDGIBIAEMPM(GLFMIMLJAPI.justWord[i]);
			for (int j = 0; j < array.Length; j++)
			{
				bool flag = true;
				string text2 = array[j];
				if (!(flag & (!Regex.IsMatch(array[j], pattern) || text2.Length - GLFMIMLJAPI.justWord[i].Length > 1)))
				{
					return false;
				}
			}
		}
		for (int k = 0; k < GLFMIMLJAPI.wholeSentence.Length; k++)
		{
			bool flag2 = true;
			if (!(flag2 & !text.Contains(GLFMIMLJAPI.wholeSentence[k])))
			{
				return false;
			}
		}
		for (int l = 0; l < GLFMIMLJAPI.regex.Length; l++)
		{
			bool flag3 = true;
			if (!(flag3 & !Regex.IsMatch(text, GLFMIMLJAPI.regex[l])))
			{
				return false;
			}
		}
		return true;
	}

	private string PDGIBIAEMPM(string IKNCPEPOKGJ)
	{
		string text = "^";
		foreach (char c in IKNCPEPOKGJ)
		{
			switch (c)
			{
			case 'a':
				text += "[a @]";
				break;
			case 'b':
				text += "[b I3 l3]";
				break;
			case 'c':
				text += "(?:[c (]|[k])";
				break;
			case 'd':
				text += "[d]";
				break;
			case 'e':
				text += "[e 3]";
				break;
			case 'f':
				text += "(?:[f]|(ph))";
				break;
			case 'g':
				text += "[g 6]";
				break;
			case 'i':
				text += "[i I l 1]";
				break;
			case 'k':
				text += "(?:[c ( q]|[k])";
				break;
			case 'l':
				text += "[l 1]";
				break;
			case 'o':
				text += "[o 0]";
				break;
			case 's':
				text += "[s $ 5]";
				break;
			case 't':
				text += "[t 7]";
				break;
			case 'u':
				text += "[u v]";
				break;
			case 'v':
				text += "[v u]";
				break;
			case 'w':
				text += "[w vv]";
				break;
			case 'z':
				text += "[z 2]";
				break;
			default:
				text += c;
				break;
			case ' ':
				break;
			}
		}
		return text;
	}
}
