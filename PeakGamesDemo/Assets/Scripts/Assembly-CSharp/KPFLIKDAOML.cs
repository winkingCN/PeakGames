using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using I2.Loc;
using UnityEngine;

public static class KPFLIKDAOML
{
	[CompilerGenerated]
	private sealed class JEKOJIGEEKB
	{
		internal Action<string, string> CIHMDLPAFFJ;

		internal string FCJBBPHFNPJ;

		internal Dictionary<string, KEKAHLEPDKL> FFMPLMDHOOH;

		internal string NFBPJGEGPMJ;

		internal void AGFNGEFDHLA(Dictionary<string, KEKAHLEPDKL> IMAMEFOKGFM, string LENFKJMEBFP)
		{
			if (!string.IsNullOrEmpty(LENFKJMEBFP) || IMAMEFOKGFM.Count == 0)
			{
				CIHMDLPAFFJ(null, LENFKJMEBFP);
				return;
			}
			string arg = MMGDCOBBCHB(FCJBBPHFNPJ, FFMPLMDHOOH, NFBPJGEGPMJ);
			CIHMDLPAFFJ(arg, null);
		}
	}

	private static List<WWW> HOPBHDDCLLN = new List<WWW>();

	public static bool ANIKIPDHFGB()
	{
		return PNAJOCHGJFO.ODEOFDCJHNK.Count > 0 && !string.IsNullOrEmpty(PNAJOCHGJFO.GDCLLONGOFO());
	}

	public static void FDFEBCKHOJD(string FCJBBPHFNPJ, string HLAKOFNJJNP, string NFBPJGEGPMJ, Action<string, string> CIHMDLPAFFJ)
	{
		PNAJOCHGJFO.DCBKDEEHAIG();
		if (!ANIKIPDHFGB())
		{
			CIHMDLPAFFJ(null, "WebService is not set correctly or needs to be reinstalled");
			return;
		}
		if (NFBPJGEGPMJ == HLAKOFNJJNP)
		{
			CIHMDLPAFFJ(FCJBBPHFNPJ, null);
			return;
		}
		Dictionary<string, KEKAHLEPDKL> FFMPLMDHOOH = new Dictionary<string, KEKAHLEPDKL>();
		if (string.IsNullOrEmpty(NFBPJGEGPMJ))
		{
			CIHMDLPAFFJ(string.Empty, null);
			return;
		}
		HAOHCNHALLE(FCJBBPHFNPJ, HLAKOFNJJNP, NFBPJGEGPMJ, FFMPLMDHOOH);
		FDFEBCKHOJD(FFMPLMDHOOH, delegate(Dictionary<string, KEKAHLEPDKL> IMAMEFOKGFM, string LENFKJMEBFP)
		{
			if (!string.IsNullOrEmpty(LENFKJMEBFP) || IMAMEFOKGFM.Count == 0)
			{
				CIHMDLPAFFJ(null, LENFKJMEBFP);
			}
			else
			{
				string arg = MMGDCOBBCHB(FCJBBPHFNPJ, FFMPLMDHOOH, NFBPJGEGPMJ);
				CIHMDLPAFFJ(arg, null);
			}
		});
	}

	public static string HCHJAKGKPPO(string FCJBBPHFNPJ, string HLAKOFNJJNP, string NFBPJGEGPMJ)
	{
		Dictionary<string, KEKAHLEPDKL> dictionary = new Dictionary<string, KEKAHLEPDKL>();
		OOELEJEMGBB(FCJBBPHFNPJ, HLAKOFNJJNP, NFBPJGEGPMJ, dictionary);
		WWW wWW = INLKDPEAHJJ(dictionary);
		while (!wWW.isDone)
		{
		}
		if (!string.IsNullOrEmpty(wWW.error))
		{
			return string.Empty;
		}
		byte[] bytes = wWW.bytes;
		string @string = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
		string value = KNNGEGBCONJ(@string, dictionary);
		if (!string.IsNullOrEmpty(value))
		{
			return null;
		}
		return HKPDJLIBLPG(FCJBBPHFNPJ, NFBPJGEGPMJ, dictionary);
	}

	public static void HAOHCNHALLE(string FCJBBPHFNPJ, string HLAKOFNJJNP, string NFBPJGEGPMJ, Dictionary<string, KEKAHLEPDKL> JHDMMCGHKBM)
	{
		if (!FCJBBPHFNPJ.Contains("[i2p_"))
		{
			OOELEJEMGBB(FCJBBPHFNPJ, HLAKOFNJJNP, NFBPJGEGPMJ, JHDMMCGHKBM);
			return;
		}
		int num = 0;
		int num2 = FCJBBPHFNPJ.IndexOf("[i2p_");
		if (num2 == 0)
		{
			num = FCJBBPHFNPJ.IndexOf("]", num2) + 1;
			num2 = FCJBBPHFNPJ.IndexOf("[i2p_");
			if (num2 < 0)
			{
				num2 = FCJBBPHFNPJ.Length;
			}
		}
		string text = FCJBBPHFNPJ.Substring(num, num2 - num);
		Regex regex = new Regex("{\\[(.*?)\\]}");
		for (JHKGFDONMJB jHKGFDONMJB = JHKGFDONMJB.Zero; jHKGFDONMJB <= JHKGFDONMJB.Plural; jHKGFDONMJB++)
		{
			if (PBPPLCKNBDJ.DLJGJMCMKID(NFBPJGEGPMJ, jHKGFDONMJB.ToString()))
			{
				string input = text;
				input = regex.Replace(input, PBPPLCKNBDJ.OGJHLEOPNNJ(NFBPJGEGPMJ, jHKGFDONMJB).ToString());
				OOELEJEMGBB(input, HLAKOFNJJNP, NFBPJGEGPMJ, JHDMMCGHKBM);
			}
		}
	}

	public static void OOELEJEMGBB(string FCJBBPHFNPJ, string HLAKOFNJJNP, string NFBPJGEGPMJ, Dictionary<string, KEKAHLEPDKL> JHDMMCGHKBM)
	{
		if (string.IsNullOrEmpty(FCJBBPHFNPJ))
		{
			return;
		}
		if (!JHDMMCGHKBM.ContainsKey(FCJBBPHFNPJ))
		{
			KEKAHLEPDKL kEKAHLEPDKL = default(KEKAHLEPDKL);
			kEKAHLEPDKL.JELBFBIPMFD = FCJBBPHFNPJ;
			kEKAHLEPDKL.HDMDEANOKHN = HLAKOFNJJNP;
			kEKAHLEPDKL.EDLGOFCGLNJ = new string[1] { NFBPJGEGPMJ };
			KEKAHLEPDKL HKCKEACCMMA = kEKAHLEPDKL;
			HKCKEACCMMA.NKFGCOFBKMA = FCJBBPHFNPJ;
			KEAOAKHMING(ref HKCKEACCMMA);
			JHDMMCGHKBM[FCJBBPHFNPJ] = HKCKEACCMMA;
		}
		else
		{
			KEKAHLEPDKL value = JHDMMCGHKBM[FCJBBPHFNPJ];
			if (Array.IndexOf(value.EDLGOFCGLNJ, NFBPJGEGPMJ) < 0)
			{
				value.EDLGOFCGLNJ = value.EDLGOFCGLNJ.Concat(new string[1] { NFBPJGEGPMJ }).Distinct().ToArray();
			}
			JHDMMCGHKBM[FCJBBPHFNPJ] = value;
		}
	}

	private static int MNHMLJJEANM(string MOKLDCMGFFB, MatchCollection KBMGHBNECGB, int KKMNKJJENIL)
	{
		int i = KKMNKJJENIL;
		for (int count = KBMGHBNECGB.Count; i < count; i++)
		{
			string text = BPFLLFMLCLJ(KBMGHBNECGB[i]);
			if (text[0] == '/' && MOKLDCMGFFB.StartsWith(text.Substring(1)))
			{
				return i;
			}
		}
		return -1;
	}

	private static string BPFLLFMLCLJ(Match GLODLGBDEPB)
	{
		for (int num = GLODLGBDEPB.Groups.Count - 1; num >= 0; num--)
		{
			if (GLODLGBDEPB.Groups[num].Success)
			{
				return GLODLGBDEPB.Groups[num].ToString();
			}
		}
		return GLODLGBDEPB.ToString();
	}

	private static void KEAOAKHMING(ref KEKAHLEPDKL HKCKEACCMMA)
	{
		MatchCollection matchCollection = Regex.Matches(HKCKEACCMMA.NKFGCOFBKMA, "\\{\\[(.*?)]}|\\[(.*?)]|\\<(.*?)>");
		if (matchCollection == null || matchCollection.Count == 0)
		{
			return;
		}
		string text = HKCKEACCMMA.NKFGCOFBKMA;
		List<string> list = new List<string>();
		int i = 0;
		for (int count = matchCollection.Count; i < count; i++)
		{
			string text2 = BPFLLFMLCLJ(matchCollection[i]);
			int num = MNHMLJJEANM(text2, matchCollection, i);
			if (num < 0)
			{
				string text3 = matchCollection[i].ToString();
				if (text3.StartsWith("{[") && text3.EndsWith("]}"))
				{
					text = text.Replace(text3, ((char)(9728 + list.Count)).ToString());
					list.Add(text3);
				}
			}
			else if (text2 == "i2nt")
			{
				string text4 = HKCKEACCMMA.NKFGCOFBKMA.Substring(matchCollection[i].Index, matchCollection[num].Index - matchCollection[i].Index + matchCollection[num].Length);
				text = text.Replace(text4, ((char)(9728 + list.Count)).ToString());
				list.Add(text4);
			}
			else
			{
				string text5 = matchCollection[i].ToString();
				text = text.Replace(text5, ((char)(9728 + list.Count)).ToString());
				list.Add(text5);
				string text6 = matchCollection[num].ToString();
				text = text.Replace(text6, ((char)(9728 + list.Count)).ToString());
				list.Add(text6);
			}
		}
		HKCKEACCMMA.NKFGCOFBKMA = text;
		HKCKEACCMMA.NCFHKLLBOEL = list.ToArray();
	}

	public static string HKPDJLIBLPG(string FCJBBPHFNPJ, string NFBPJGEGPMJ, Dictionary<string, KEKAHLEPDKL> JHDMMCGHKBM)
	{
		if (!JHDMMCGHKBM.ContainsKey(FCJBBPHFNPJ))
		{
			return null;
		}
		KEKAHLEPDKL kEKAHLEPDKL = JHDMMCGHKBM[FCJBBPHFNPJ];
		if (kEKAHLEPDKL.FKPHKHKDCPH == null || kEKAHLEPDKL.FKPHKHKDCPH.Length < 0)
		{
			return null;
		}
		if (string.IsNullOrEmpty(NFBPJGEGPMJ))
		{
			return kEKAHLEPDKL.FKPHKHKDCPH[0];
		}
		int num = Array.IndexOf(kEKAHLEPDKL.EDLGOFCGLNJ, NFBPJGEGPMJ);
		if (num < 0)
		{
			return null;
		}
		return kEKAHLEPDKL.FKPHKHKDCPH[num];
	}

	public static string MMGDCOBBCHB(string FCJBBPHFNPJ, Dictionary<string, KEKAHLEPDKL> JHDMMCGHKBM, string NFBPJGEGPMJ)
	{
		if (!FCJBBPHFNPJ.Contains("[i2p_"))
		{
			return NOGNJJIFAIN(FCJBBPHFNPJ, NFBPJGEGPMJ, JHDMMCGHKBM);
		}
		int num = 0;
		int num2 = FCJBBPHFNPJ.IndexOf("[i2p_");
		if (num2 == 0)
		{
			num = FCJBBPHFNPJ.IndexOf("]", num2) + 1;
			num2 = FCJBBPHFNPJ.IndexOf("[i2p_");
			if (num2 < 0)
			{
				num2 = FCJBBPHFNPJ.Length;
			}
		}
		string text = FCJBBPHFNPJ.Substring(num, num2 - num);
		Match match = Regex.Match(text, "{\\[(.*?)\\]}");
		string text2 = ((match != null) ? match.Value : string.Empty);
		StringBuilder stringBuilder = new StringBuilder();
		string text3 = text;
		int num3 = PBPPLCKNBDJ.OGJHLEOPNNJ(NFBPJGEGPMJ, JHKGFDONMJB.Plural);
		text3 = text3.Replace(text2, num3.ToString());
		string text4 = NOGNJJIFAIN(text3, NFBPJGEGPMJ, JHDMMCGHKBM);
		string text5 = text4.Replace(num3.ToString(), text2);
		stringBuilder.Append(text5);
		for (JHKGFDONMJB jHKGFDONMJB = JHKGFDONMJB.Zero; jHKGFDONMJB < JHKGFDONMJB.Plural; jHKGFDONMJB++)
		{
			if (PBPPLCKNBDJ.DLJGJMCMKID(NFBPJGEGPMJ, jHKGFDONMJB.ToString()))
			{
				text3 = text;
				num3 = PBPPLCKNBDJ.OGJHLEOPNNJ(NFBPJGEGPMJ, jHKGFDONMJB);
				text3 = text3.Replace(text2, num3.ToString());
				text4 = NOGNJJIFAIN(text3, NFBPJGEGPMJ, JHDMMCGHKBM);
				text4 = text4.Replace(num3.ToString(), text2);
				if (!string.IsNullOrEmpty(text4) && text4 != text5)
				{
					stringBuilder.Append("[i2p_");
					stringBuilder.Append(jHKGFDONMJB.ToString());
					stringBuilder.Append(']');
					stringBuilder.Append(text4);
				}
			}
		}
		return stringBuilder.ToString();
	}

	private static string NOGNJJIFAIN(string FCJBBPHFNPJ, string NFBPJGEGPMJ, Dictionary<string, KEKAHLEPDKL> JHDMMCGHKBM)
	{
		if (!JHDMMCGHKBM.ContainsKey(FCJBBPHFNPJ))
		{
			return null;
		}
		KEKAHLEPDKL kEKAHLEPDKL = JHDMMCGHKBM[FCJBBPHFNPJ];
		int num = Array.IndexOf(kEKAHLEPDKL.EDLGOFCGLNJ, NFBPJGEGPMJ);
		if (num < 0)
		{
			return string.Empty;
		}
		if (kEKAHLEPDKL.FKPHKHKDCPH == null)
		{
			return string.Empty;
		}
		return kEKAHLEPDKL.FKPHKHKDCPH[num];
	}

	public static string OIIKEIMEFMK(string IBBBMACIBGK)
	{
		if (string.IsNullOrEmpty(IBBBMACIBGK))
		{
			return string.Empty;
		}
		char[] array = IBBBMACIBGK.ToLower().ToCharArray();
		array[0] = char.ToUpper(array[0]);
		return new string(array);
	}

	public static string ODOANDALGCC(string IBBBMACIBGK)
	{
		if (string.IsNullOrEmpty(IBBBMACIBGK))
		{
			return string.Empty;
		}
		return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(IBBBMACIBGK);
	}

	public static void FDFEBCKHOJD(Dictionary<string, KEKAHLEPDKL> OPDOEGDCCLP, Action<Dictionary<string, KEKAHLEPDKL>, string> CIHMDLPAFFJ, bool KHBNGNKDENJ = true)
	{
		WWW jMGIFPLKMKB = INLKDPEAHJJ(OPDOEGDCCLP, KHBNGNKDENJ);
		CoroutineManager.Start(AFIONFIHCPC(jMGIFPLKMKB, CIHMDLPAFFJ, OPDOEGDCCLP));
	}

	public static bool HCHJAKGKPPO(Dictionary<string, KEKAHLEPDKL> OPDOEGDCCLP, bool KHBNGNKDENJ = true)
	{
		WWW wWW = INLKDPEAHJJ(OPDOEGDCCLP, KHBNGNKDENJ);
		while (!wWW.isDone)
		{
		}
		string error = wWW.error;
		if (!string.IsNullOrEmpty(error))
		{
			if (error.Contains("rewind"))
			{
				return HCHJAKGKPPO(OPDOEGDCCLP, false);
			}
			return false;
		}
		byte[] bytes = wWW.bytes;
		string @string = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
		string value = KNNGEGBCONJ(@string, OPDOEGDCCLP);
		return string.IsNullOrEmpty(value);
	}

	public static WWW INLKDPEAHJJ(Dictionary<string, KEKAHLEPDKL> OPDOEGDCCLP, bool KHBNGNKDENJ = true)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (KeyValuePair<string, KEKAHLEPDKL> item in OPDOEGDCCLP)
		{
			KEKAHLEPDKL value = item.Value;
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append("<I2Loc>");
			}
			stringBuilder.Append(PBPPLCKNBDJ.KKFBAPEMHIE(value.HDMDEANOKHN));
			stringBuilder.Append(":");
			for (int i = 0; i < value.EDLGOFCGLNJ.Length; i++)
			{
				if (i != 0)
				{
					stringBuilder.Append(",");
				}
				stringBuilder.Append(PBPPLCKNBDJ.KKFBAPEMHIE(value.EDLGOFCGLNJ[i]));
			}
			stringBuilder.Append("=");
			string text = ((!(ODOANDALGCC(value.NKFGCOFBKMA) == value.NKFGCOFBKMA)) ? value.NKFGCOFBKMA : value.NKFGCOFBKMA.ToLowerInvariant());
			if (KHBNGNKDENJ)
			{
				stringBuilder.Append(text);
				continue;
			}
			stringBuilder.Append(Uri.EscapeDataString(text));
			if (stringBuilder.Length <= 4000)
			{
				continue;
			}
			break;
		}
		if (KHBNGNKDENJ)
		{
			WWWForm wWWForm = new WWWForm();
			wWWForm.AddField("action", "Translate");
			wWWForm.AddField("list", stringBuilder.ToString());
			return new WWW(PNAJOCHGJFO.GDCLLONGOFO(), wWWForm);
		}
		string url = string.Format("{0}?action=Translate&list={1}", PNAJOCHGJFO.GDCLLONGOFO(), stringBuilder.ToString());
		return new WWW(url);
	}

	private static IEnumerator AFIONFIHCPC(WWW JMGIFPLKMKB, Action<Dictionary<string, KEKAHLEPDKL>, string> CIHMDLPAFFJ, Dictionary<string, KEKAHLEPDKL> OPDOEGDCCLP)
	{
		HOPBHDDCLLN.Add(JMGIFPLKMKB);
		while (!JMGIFPLKMKB.isDone)
		{
			yield return null;
		}
		int count = HOPBHDDCLLN.Count;
		HOPBHDDCLLN.Remove(JMGIFPLKMKB);
		if (count == HOPBHDDCLLN.Count)
		{
			yield break;
		}
		string error = JMGIFPLKMKB.error;
		if (!string.IsNullOrEmpty(error))
		{
			if (error.Contains("rewind"))
			{
				FDFEBCKHOJD(OPDOEGDCCLP, CIHMDLPAFFJ, false);
			}
			else
			{
				CIHMDLPAFFJ(OPDOEGDCCLP, JMGIFPLKMKB.error);
			}
		}
		else
		{
			byte[] bytes = JMGIFPLKMKB.bytes;
			string @string = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
			error = KNNGEGBCONJ(@string, OPDOEGDCCLP);
			CIHMDLPAFFJ(OPDOEGDCCLP, error);
		}
	}

	public static string KNNGEGBCONJ(string IAJIABDMHCI, Dictionary<string, KEKAHLEPDKL> OPDOEGDCCLP)
	{
		if (IAJIABDMHCI.StartsWith("<!DOCTYPE html>") || IAJIABDMHCI.StartsWith("<HTML>"))
		{
			if (IAJIABDMHCI.Contains("The script completed but did not return anything"))
			{
				return "The current Google WebService is not supported.\nPlease, delete the WebService from the Google Drive and Install the latest version.";
			}
			if (IAJIABDMHCI.Contains("Service invoked too many times in a short time"))
			{
				return string.Empty;
			}
			return "There was a problem contacting the WebService. Please try again later\n" + IAJIABDMHCI;
		}
		string[] array = IAJIABDMHCI.Split(new string[1] { "<I2Loc>" }, StringSplitOptions.None);
		string[] separator = new string[1] { "<i2>" };
		int num = 0;
		string[] array2 = OPDOEGDCCLP.Keys.ToArray();
		string[] array3 = array2;
		foreach (string text in array3)
		{
			KEKAHLEPDKL value = FFJPACLFLCL(text, OPDOEGDCCLP);
			string text2 = array[num++];
			if (value.NCFHKLLBOEL != null)
			{
				int j = 0;
				for (int num2 = value.NCFHKLLBOEL.Length; j < num2; j++)
				{
					text2 = text2.Replace(((char)(9728 + j)).ToString(), value.NCFHKLLBOEL[j]);
				}
			}
			value.FKPHKHKDCPH = text2.Split(separator, StringSplitOptions.None);
			if (ODOANDALGCC(text) == text)
			{
				for (int k = 0; k < value.FKPHKHKDCPH.Length; k++)
				{
					value.FKPHKHKDCPH[k] = ODOANDALGCC(value.FKPHKHKDCPH[k]);
				}
			}
			OPDOEGDCCLP[value.JELBFBIPMFD] = value;
		}
		return null;
	}

	private static KEKAHLEPDKL FFJPACLFLCL(string KKDHAOODMND, Dictionary<string, KEKAHLEPDKL> JHDMMCGHKBM)
	{
		foreach (KeyValuePair<string, KEKAHLEPDKL> item in JHDMMCGHKBM)
		{
			if (item.Value.JELBFBIPMFD == KKDHAOODMND)
			{
				return item.Value;
			}
		}
		return default(KEKAHLEPDKL);
	}

	public static bool BEFBICIHJFP()
	{
		return HOPBHDDCLLN.Count > 0;
	}

	public static void JBPOPEDLHJK()
	{
		HOPBHDDCLLN.Clear();
	}
}
