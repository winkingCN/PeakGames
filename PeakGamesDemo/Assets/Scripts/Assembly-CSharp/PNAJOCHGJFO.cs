using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using I2.Loc;
using UnityEngine;

public static class PNAJOCHGJFO
{
	private delegate object EBJKEHMLDLD(string BOFHHECPKNF);

	public delegate void CNCMOHCEDJF();

	[CompilerGenerated]
	private sealed class OEGMLKKEMKB
	{
		internal List<string> FCAPCDLLNGJ;

		internal bool AGFNGEFDHLA(string AMFCENFNAJJ)
		{
			return !FCAPCDLLNGJ.Contains(AMFCENFNAJJ);
		}
	}

	[CompilerGenerated]
	private sealed class EMCCFDGNBJA
	{
		internal List<string> FCAPCDLLNGJ;

		internal bool AGFNGEFDHLA(string AMFCENFNAJJ)
		{
			return !FCAPCDLLNGJ.Contains(AMFCENFNAJJ);
		}
	}

	[CompilerGenerated]
	private sealed class OKEPDGDKLCA
	{
		internal GameObject AFCMDCDBMIB;

		internal object AGFNGEFDHLA(string HPHBDNBJPHB)
		{
			return EJJABODFBKC(HPHBDNBJPHB, AFCMDCDBMIB);
		}
	}

	[CompilerGenerated]
	private sealed class ANIANMLPNAJ
	{
		internal Dictionary<string, object> IJJHBEECMBP;

		internal object AGFNGEFDHLA(string HPHBDNBJPHB)
		{
			object value = null;
			if (IJJHBEECMBP.TryGetValue(HPHBDNBJPHB, out value))
			{
				return value;
			}
			return null;
		}
	}

	private static string MLPPCKDPODF;

	private static string CMMNPEJMGEG;

	private static bool LLJGAPANEED = false;

	public static bool MNHBNGFDIPC = false;

	public static bool GIJNKMIHMKE = false;

	public static List<JMFAIACBIGP> OAANICEABPL = new List<JMFAIACBIGP>();

	private static string[] GJCGCCFJLNL = new string[20]
	{
		"ar-DZ", "ar", "ar-BH", "ar-EG", "ar-IQ", "ar-JO", "ar-KW", "ar-LB", "ar-LY", "ar-MA",
		"ar-OM", "ar-QA", "ar-SA", "ar-SY", "ar-TN", "ar-AE", "ar-YE", "he", "ur", "ji"
	};

	public static List<LanguageSource> ODEOFDCJHNK = new List<LanguageSource>();

	public static string[] MKMKPCOBGBF = new string[1] { "I2Languages" };

	public static List<ABOOAELLAEJ> MHJDEGPMHJN = new List<ABOOAELLAEJ>();

	private static bool AGJCBEALDNE = false;

	private static bool JLGIKOCDKCK = false;

	[CompilerGenerated]
	private static EBJKEHMLDLD EBCOMJBLIPP;

	[CompilerGenerated]
	private static Comparison<ABOOAELLAEJ> DNBOPLHGMHA;

	public static string LOEHJECLFHL
	{
		get
		{
			DCBKDEEHAIG();
			return MLPPCKDPODF;
		}
		set
		{
			DCBKDEEHAIG();
			string text = PBNGDLDDPPD(value);
			if (!string.IsNullOrEmpty(text) && MLPPCKDPODF != text)
			{
				LMJKBCFGAIN(text, LPFNBCLEHIB(text));
			}
		}
	}

	public static string MKNJPFIDKOA
	{
		get
		{
			DCBKDEEHAIG();
			return CMMNPEJMGEG;
		}
		set
		{
			DCBKDEEHAIG();
			if (CMMNPEJMGEG != value)
			{
				string text = HNJPEIBFHJI(value);
				if (!string.IsNullOrEmpty(text))
				{
					LMJKBCFGAIN(text, value);
				}
			}
		}
	}

	public static string JBGELEHFEEK
	{
		get
		{
			string text = LOEHJECLFHL;
			int num = text.IndexOfAny("/\\".ToCharArray());
			if (num > 0)
			{
				return text.Substring(num + 1);
			}
			num = text.IndexOfAny("[(".ToCharArray());
			int num2 = text.LastIndexOfAny("])".ToCharArray());
			if (num > 0 && num != num2)
			{
				return text.Substring(num + 1, num2 - num - 1);
			}
			return string.Empty;
		}
		set
		{
			string text = LOEHJECLFHL;
			int num = text.IndexOfAny("/\\".ToCharArray());
			if (num > 0)
			{
				LOEHJECLFHL = text.Substring(num + 1) + value;
				return;
			}
			num = text.IndexOfAny("[(".ToCharArray());
			int num2 = text.LastIndexOfAny("])".ToCharArray());
			if (num > 0 && num != num2)
			{
				text = text.Substring(num);
			}
			LOEHJECLFHL = text + "(" + value + ")";
		}
	}

	public static string AENKPDBKFCN
	{
		get
		{
			string text = MKNJPFIDKOA;
			int num = text.IndexOfAny(" -_/\\".ToCharArray());
			return (num >= 0) ? text.Substring(num + 1) : string.Empty;
		}
		set
		{
			string text = MKNJPFIDKOA;
			int num = text.IndexOfAny(" -_/\\".ToCharArray());
			if (num > 0)
			{
				text = text.Substring(0, num);
			}
			MKNJPFIDKOA = text + "-" + value;
		}
	}

	public static event CNCMOHCEDJF BEBEKBLNBDB;

	public static void DCBKDEEHAIG()
	{
		if (string.IsNullOrEmpty(MLPPCKDPODF) || ODEOFDCJHNK.Count == 0)
		{
			JHMHBFIFFFK();
			PCNGHPDEKCF();
		}
	}

	public static string AFMEABCJFBK()
	{
		return "2.8.2 f2";
	}

	public static int OPGIKMEFJAJ()
	{
		return 5;
	}

	public static string GDCLLONGOFO(LanguageSource JKHLMLIANAI = null)
	{
		if (JKHLMLIANAI != null && !string.IsNullOrEmpty(JKHLMLIANAI.Google_WebServiceURL))
		{
			return JKHLMLIANAI.Google_WebServiceURL;
		}
		DCBKDEEHAIG();
		for (int i = 0; i < ODEOFDCJHNK.Count; i++)
		{
			if (ODEOFDCJHNK[i] != null && !string.IsNullOrEmpty(ODEOFDCJHNK[i].Google_WebServiceURL))
			{
				return ODEOFDCJHNK[i].Google_WebServiceURL;
			}
		}
		return string.Empty;
	}

	public static void LMJKBCFGAIN(string JICFGMNANHA, string HDMDEANOKHN, bool PAPDKFGGKGP = true, bool LLLFMBNNMBG = false)
	{
		if (MLPPCKDPODF != JICFGMNANHA || CMMNPEJMGEG != HDMDEANOKHN || LLLFMBNNMBG)
		{
			if (PAPDKFGGKGP)
			{
				PlayerPrefs.SetString("I2 Language", JICFGMNANHA);
			}
			MLPPCKDPODF = JICFGMNANHA;
			CMMNPEJMGEG = HDMDEANOKHN;
			if (LLJGAPANEED)
			{
				PLGDDGOEHNM();
			}
			else
			{
				MNHBNGFDIPC = NEAEFCFOCPK(CMMNPEJMGEG);
				GIJNKMIHMKE = PBPPLCKNBDJ.NJOADGDIONM(CMMNPEJMGEG);
			}
			EBEBNPMKGEO(LLLFMBNNMBG);
		}
	}

	private static CultureInfo PEPLEKGOJCF(string FJCNPLPKFKP)
	{
		try
		{
			return CultureInfo.CreateSpecificCulture(FJCNPLPKFKP);
		}
		catch (Exception)
		{
			return CultureInfo.InvariantCulture;
		}
	}

	public static void DHCOKKPGMMI(bool PGLHEOJICEO)
	{
		if (!LLJGAPANEED && PGLHEOJICEO)
		{
			PLGDDGOEHNM();
		}
		LLJGAPANEED = PGLHEOJICEO;
	}

	private static void PLGDDGOEHNM()
	{
		Thread.CurrentThread.CurrentCulture = PEPLEKGOJCF(CMMNPEJMGEG);
		MNHBNGFDIPC = CultureInfo.CurrentCulture.TextInfo.IsRightToLeft;
		GIJNKMIHMKE = PBPPLCKNBDJ.NJOADGDIONM(CMMNPEJMGEG);
	}

	private static void PCNGHPDEKCF()
	{
		if (ODEOFDCJHNK.Count == 0)
		{
			return;
		}
		string @string = PlayerPrefs.GetString("I2 Language", string.Empty);
		string text = Application.systemLanguage.ToString();
		if (text == "ChineseSimplified")
		{
			text = "Chinese (Simplified)";
		}
		if (text == "ChineseTraditional")
		{
			text = "Chinese (Traditional)";
		}
		if (!string.IsNullOrEmpty(@string) && ILPMCAOOFIO(@string, true, false))
		{
			LMJKBCFGAIN(@string, LPFNBCLEHIB(@string));
			return;
		}
		if (!ODEOFDCJHNK[0].IgnoreDeviceLanguage)
		{
			string text2 = PBNGDLDDPPD(text);
			if (!string.IsNullOrEmpty(text2))
			{
				LMJKBCFGAIN(text2, LPFNBCLEHIB(text2), false);
				return;
			}
		}
		int i = 0;
		for (int count = ODEOFDCJHNK.Count; i < count; i++)
		{
			if (ODEOFDCJHNK[i].mLanguages.Count <= 0)
			{
				continue;
			}
			for (int j = 0; j < ODEOFDCJHNK[i].mLanguages.Count; j++)
			{
				if (ODEOFDCJHNK[i].mLanguages[j].FCIBLDEJAPL())
				{
					LMJKBCFGAIN(ODEOFDCJHNK[i].mLanguages[j].Name, ODEOFDCJHNK[i].mLanguages[j].Code, false);
					return;
				}
			}
		}
	}

	public static bool ILPMCAOOFIO(string OEMDOLLFPDF, bool LAPHDMBDNMP = true, bool JPLFFCHJICB = true, bool FBMMHIMDOBK = true)
	{
		if (JPLFFCHJICB)
		{
			DCBKDEEHAIG();
		}
		int i = 0;
		for (int count = ODEOFDCJHNK.Count; i < count; i++)
		{
			if (ODEOFDCJHNK[i].GetLanguageIndex(OEMDOLLFPDF, false, FBMMHIMDOBK) >= 0)
			{
				return true;
			}
		}
		if (LAPHDMBDNMP)
		{
			int j = 0;
			for (int count2 = ODEOFDCJHNK.Count; j < count2; j++)
			{
				if (ODEOFDCJHNK[j].GetLanguageIndex(OEMDOLLFPDF, true, FBMMHIMDOBK) >= 0)
				{
					return true;
				}
			}
		}
		return false;
	}

	public static string PBNGDLDDPPD(string OEMDOLLFPDF)
	{
		int i = 0;
		for (int count = ODEOFDCJHNK.Count; i < count; i++)
		{
			int languageIndex = ODEOFDCJHNK[i].GetLanguageIndex(OEMDOLLFPDF, false);
			if (languageIndex >= 0)
			{
				return ODEOFDCJHNK[i].mLanguages[languageIndex].Name;
			}
		}
		int j = 0;
		for (int count2 = ODEOFDCJHNK.Count; j < count2; j++)
		{
			int languageIndex2 = ODEOFDCJHNK[j].GetLanguageIndex(OEMDOLLFPDF);
			if (languageIndex2 >= 0)
			{
				return ODEOFDCJHNK[j].mLanguages[languageIndex2].Name;
			}
		}
		return string.Empty;
	}

	public static string LPFNBCLEHIB(string OEMDOLLFPDF)
	{
		if (ODEOFDCJHNK.Count == 0)
		{
			JHMHBFIFFFK();
		}
		int i = 0;
		for (int count = ODEOFDCJHNK.Count; i < count; i++)
		{
			int languageIndex = ODEOFDCJHNK[i].GetLanguageIndex(OEMDOLLFPDF);
			if (languageIndex >= 0)
			{
				return ODEOFDCJHNK[i].mLanguages[languageIndex].Code;
			}
		}
		return string.Empty;
	}

	public static string HNJPEIBFHJI(string OBLPBFEPJCO, bool PEEPLOKGGPG = true)
	{
		if (ODEOFDCJHNK.Count == 0)
		{
			JHMHBFIFFFK();
		}
		int i = 0;
		for (int count = ODEOFDCJHNK.Count; i < count; i++)
		{
			int languageIndexFromCode = ODEOFDCJHNK[i].GetLanguageIndexFromCode(OBLPBFEPJCO, PEEPLOKGGPG);
			if (languageIndexFromCode >= 0)
			{
				return ODEOFDCJHNK[i].mLanguages[languageIndexFromCode].Name;
			}
		}
		return string.Empty;
	}

	public static List<string> JKANFJOGPBF(bool FBMMHIMDOBK = true)
	{
		if (ODEOFDCJHNK.Count == 0)
		{
			JHMHBFIFFFK();
		}
		List<string> FCAPCDLLNGJ = new List<string>();
		int i = 0;
		for (int count = ODEOFDCJHNK.Count; i < count; i++)
		{
			FCAPCDLLNGJ.AddRange(from AMFCENFNAJJ in ODEOFDCJHNK[i].GetLanguages(FBMMHIMDOBK)
				where !FCAPCDLLNGJ.Contains(AMFCENFNAJJ)
				select AMFCENFNAJJ);
		}
		return FCAPCDLLNGJ;
	}

	public static List<string> BFEAENGNPJG(bool EEINIAFCKHG = true, bool FBMMHIMDOBK = true)
	{
		List<string> FCAPCDLLNGJ = new List<string>();
		int i = 0;
		for (int count = ODEOFDCJHNK.Count; i < count; i++)
		{
			FCAPCDLLNGJ.AddRange(from AMFCENFNAJJ in ODEOFDCJHNK[i].GetLanguagesCode(EEINIAFCKHG, FBMMHIMDOBK)
				where !FCAPCDLLNGJ.Contains(AMFCENFNAJJ)
				select AMFCENFNAJJ);
		}
		return FCAPCDLLNGJ;
	}

	public static bool GHKILNMKKJG(string OEMDOLLFPDF)
	{
		int i = 0;
		for (int count = ODEOFDCJHNK.Count; i < count; i++)
		{
			if (!ODEOFDCJHNK[i].IsLanguageEnabled(OEMDOLLFPDF))
			{
				return false;
			}
		}
		return true;
	}

	public static void DNDINFAAJFL(ref string JFPDNFFBLFI)
	{
		NPPNBLAIIKG(ref JFPDNFFBLFI, (string HPHBDNBJPHB) => EJJABODFBKC(HPHBDNBJPHB, null));
	}

	public static void DNDINFAAJFL(ref string JFPDNFFBLFI, GameObject AFCMDCDBMIB)
	{
		NPPNBLAIIKG(ref JFPDNFFBLFI, (string HPHBDNBJPHB) => EJJABODFBKC(HPHBDNBJPHB, AFCMDCDBMIB));
	}

	public static void DNDINFAAJFL(ref string JFPDNFFBLFI, Dictionary<string, object> IJJHBEECMBP)
	{
		NPPNBLAIIKG(ref JFPDNFFBLFI, delegate(string HPHBDNBJPHB)
		{
			object value = null;
			return IJJHBEECMBP.TryGetValue(HPHBDNBJPHB, out value) ? value : null;
		});
	}

	private static void NPPNBLAIIKG(ref string JFPDNFFBLFI, EBJKEHMLDLD HCHLEFJKFFO)
	{
		if (JFPDNFFBLFI == null)
		{
			return;
		}
		string text = null;
		int num = 0;
		int length = JFPDNFFBLFI.Length;
		int num2 = 0;
		while (num2 >= 0 && num2 < JFPDNFFBLFI.Length)
		{
			int num3 = JFPDNFFBLFI.IndexOf("{[", num2);
			if (num3 < 0)
			{
				break;
			}
			int num4 = JFPDNFFBLFI.IndexOf("]}", num3);
			if (num4 < 0)
			{
				break;
			}
			int num5 = JFPDNFFBLFI.IndexOf("{[", num3 + 1);
			if (num5 > 0 && num5 < num4)
			{
				num2 = num5;
				continue;
			}
			string bOFHHECPKNF = JFPDNFFBLFI.Substring(num3 + 2, num4 - num3 - 2);
			string text2 = (string)HCHLEFJKFFO(bOFHHECPKNF);
			if (text2 != null)
			{
				string oldValue = JFPDNFFBLFI.Substring(num3, num4 - num3 + 2);
				JFPDNFFBLFI = JFPDNFFBLFI.Replace(oldValue, text2);
				int result = 0;
				if (int.TryParse(text2, out result))
				{
					text = PBPPLCKNBDJ.IJGJDGOFGFE(MKNJPFIDKOA, result).ToString();
				}
			}
			num2 = num4 + 2;
		}
		if (text != null)
		{
			string text3 = "[i2p_" + text + "]";
			num = JFPDNFFBLFI.IndexOf(text3, StringComparison.OrdinalIgnoreCase);
			num = ((num >= 0) ? (num + text3.Length) : 0);
			length = JFPDNFFBLFI.IndexOf("[i2p_", num + 1, StringComparison.OrdinalIgnoreCase);
			if (length < 0)
			{
				length = JFPDNFFBLFI.Length;
			}
			JFPDNFFBLFI = JFPDNFFBLFI.Substring(num, length - num);
		}
	}

	internal static string EJJABODFBKC(string GFIIAOBDDPB, GameObject AFCMDCDBMIB)
	{
		string text = null;
		if ((bool)AFCMDCDBMIB)
		{
			MonoBehaviour[] components = AFCMDCDBMIB.GetComponents<MonoBehaviour>();
			int i = 0;
			for (int num = components.Length; i < num; i++)
			{
				JMFAIACBIGP jMFAIACBIGP = components[i] as JMFAIACBIGP;
				if (jMFAIACBIGP != null)
				{
					text = jMFAIACBIGP.GetParameterValue(GFIIAOBDDPB);
					if (text != null)
					{
						return text;
					}
				}
			}
		}
		int j = 0;
		for (int count = OAANICEABPL.Count; j < count; j++)
		{
			text = OAANICEABPL[j].GetParameterValue(GFIIAOBDDPB);
			if (text != null)
			{
				return text;
			}
		}
		return null;
	}

	private static string IJGJDGOFGFE(MatchCollection KBMGHBNECGB, string OFNOFMKOMIJ, EBJKEHMLDLD HCHLEFJKFFO)
	{
		int i = 0;
		for (int count = KBMGHBNECGB.Count; i < count; i++)
		{
			Match match = KBMGHBNECGB[i];
			string value = match.Groups[match.Groups.Count - 1].Value;
			string text = (string)HCHLEFJKFFO(value);
			if (text != null)
			{
				int result = 0;
				if (int.TryParse(text, out result))
				{
					return PBPPLCKNBDJ.IJGJDGOFGFE(OFNOFMKOMIJ, result).ToString();
				}
			}
		}
		return null;
	}

	public static string IFCCJDKHIHP(string BBIEJBIHPLE)
	{
		return IFCCJDKHIHP(BBIEJBIHPLE, 0, true);
	}

	public static string IFCCJDKHIHP(string BBIEJBIHPLE, int DOPDNKDIGEI, bool NHLDCIHMAMK)
	{
		if (string.IsNullOrEmpty(BBIEJBIHPLE))
		{
			return BBIEJBIHPLE;
		}
		char c = BBIEJBIHPLE[0];
		if (c == '!' || c == '.' || c == '?')
		{
			BBIEJBIHPLE = BBIEJBIHPLE.Substring(1) + c;
		}
		int PHEGOMMPNIL = -1;
		int num = 0;
		int num2 = 40000;
		num = 0;
		List<string> list = new List<string>();
		while (ODIHEPBMAPE.MEILPENBFOJ(BBIEJBIHPLE, num, out PHEGOMMPNIL, out num))
		{
			string text = "@@" + (char)(num2 + list.Count) + "@@";
			list.Add(BBIEJBIHPLE.Substring(PHEGOMMPNIL, num - PHEGOMMPNIL + 1));
			BBIEJBIHPLE = BBIEJBIHPLE.Substring(0, PHEGOMMPNIL) + text + BBIEJBIHPLE.Substring(num + 1);
			num = PHEGOMMPNIL + 5;
		}
		BBIEJBIHPLE = BBIEJBIHPLE.Replace("\r\n", "\n");
		BBIEJBIHPLE = ODIHEPBMAPE.KPGFEPAPBHJ(BBIEJBIHPLE, DOPDNKDIGEI);
		BBIEJBIHPLE = KMGNOHNIMEP.GJFCPBIOPKF(BBIEJBIHPLE, true, !NHLDCIHMAMK);
		for (int i = 0; i < list.Count; i++)
		{
			int length = BBIEJBIHPLE.Length;
			for (int j = 0; j < length; j++)
			{
				if (BBIEJBIHPLE[j] == '@' && BBIEJBIHPLE[j + 1] == '@' && BBIEJBIHPLE[j + 2] >= num2 && BBIEJBIHPLE[j + 3] == '@' && BBIEJBIHPLE[j + 4] == '@')
				{
					int num3 = BBIEJBIHPLE[j + 2] - num2;
					num3 = ((num3 % 2 != 0) ? (num3 - 1) : (num3 + 1));
					if (num3 >= list.Count)
					{
						num3 = list.Count - 1;
					}
					BBIEJBIHPLE = BBIEJBIHPLE.Substring(0, j) + list[num3] + BBIEJBIHPLE.Substring(j + 5);
					break;
				}
			}
		}
		return BBIEJBIHPLE;
	}

	public static string FLMKMHLPMFD(string FCJBBPHFNPJ, int DOPDNKDIGEI = 0, bool FFNHDEDHAAN = false)
	{
		if (MNHBNGFDIPC)
		{
			return IFCCJDKHIHP(FCJBBPHFNPJ, DOPDNKDIGEI, FFNHDEDHAAN);
		}
		return FCJBBPHFNPJ;
	}

	public static bool NEAEFCFOCPK(string OBLPBFEPJCO)
	{
		return Array.IndexOf(GJCGCCFJLNL, OBLPBFEPJCO) >= 0;
	}

	public static bool JHMHBFIFFFK()
	{
		AFKMJLANJMJ();
		KGFABDNLEFK();
		IGALMCCPJEC();
		return ODEOFDCJHNK.Count > 0;
	}

	private static void AFKMJLANJMJ()
	{
		for (int num = ODEOFDCJHNK.Count - 1; num >= 0; num--)
		{
			if (ODEOFDCJHNK[num] == null)
			{
				JKJDOMKCMCJ(ODEOFDCJHNK[num]);
			}
		}
	}

	private static void IGALMCCPJEC()
	{
		LanguageSource[] array = (LanguageSource[])Resources.FindObjectsOfTypeAll(typeof(LanguageSource));
		int i = 0;
		for (int num = array.Length; i < num; i++)
		{
			if (!ODEOFDCJHNK.Contains(array[i]))
			{
				FPOGOHHDEOB(array[i]);
			}
		}
	}

	private static void KGFABDNLEFK()
	{
		string[] mKMKPCOBGBF = MKMKPCOBGBF;
		foreach (string pNGPLGHKFDI in mKMKPCOBGBF)
		{
			GameObject asset = ResourceManager.MGLPOGMOMJM.GetAsset<GameObject>(pNGPLGHKFDI);
			LanguageSource languageSource = ((!asset) ? null : asset.GetComponent<LanguageSource>());
			if ((bool)languageSource && !ODEOFDCJHNK.Contains(languageSource))
			{
				FPOGOHHDEOB(languageSource);
			}
		}
	}

	internal static void FPOGOHHDEOB(LanguageSource ILLMAGFDLPE)
	{
		if (ODEOFDCJHNK.Contains(ILLMAGFDLPE))
		{
			return;
		}
		ODEOFDCJHNK.Add(ILLMAGFDLPE);
		if (ILLMAGFDLPE.HasGoogleSpreadsheet() && ILLMAGFDLPE.GoogleUpdateFrequency != LanguageSource.DOLAEHNLDAH.Never)
		{
			ILLMAGFDLPE.Import_Google_FromCache();
			if (ILLMAGFDLPE.GoogleUpdateDelay > 0f)
			{
				CoroutineManager.Start(CDBBHLHLNFB(ILLMAGFDLPE, ILLMAGFDLPE.GoogleUpdateDelay));
			}
			else
			{
				ILLMAGFDLPE.Import_Google();
			}
		}
		if (ILLMAGFDLPE.mDictionary.Count == 0)
		{
			ILLMAGFDLPE.UpdateDictionary(true);
		}
	}

	private static IEnumerator CDBBHLHLNFB(LanguageSource JKHLMLIANAI, float DKIPEJPGACG)
	{
		yield return new WaitForSeconds(DKIPEJPGACG);
		JKHLMLIANAI.Import_Google();
	}

	internal static void JKJDOMKCMCJ(LanguageSource ILLMAGFDLPE)
	{
		ODEOFDCJHNK.Remove(ILLMAGFDLPE);
	}

	public static bool KDAFBMAGBNP(string EENAMCLMIGJ)
	{
		return Array.IndexOf(MKMKPCOBGBF, EENAMCLMIGJ) >= 0;
	}

	public static LanguageSource FEAGEEBAKCP(string PPJJIIFOONJ, bool IEEBFGCGLPC = true)
	{
		if (!string.IsNullOrEmpty(PPJJIIFOONJ))
		{
			int i = 0;
			for (int count = ODEOFDCJHNK.Count; i < count; i++)
			{
				if (ODEOFDCJHNK[i].GetTermData(PPJJIIFOONJ) != null)
				{
					return ODEOFDCJHNK[i];
				}
			}
		}
		return (!IEEBFGCGLPC || ODEOFDCJHNK.Count <= 0) ? null : ODEOFDCJHNK[0];
	}

	public static UnityEngine.Object PFGPGNNFFJN(string EDDNOJDPMCF)
	{
		int i = 0;
		for (int count = ODEOFDCJHNK.Count; i < count; i++)
		{
			UnityEngine.Object @object = ODEOFDCJHNK[i].FindAsset(EDDNOJDPMCF);
			if ((bool)@object)
			{
				return @object;
			}
		}
		return null;
	}

	public static string NOGNJJIFAIN(string ONHHAFBOPFG, bool JBPBIOHLLKP = true, int KOOENHBOKPL = 0, bool GOOLKAODJAH = true, bool MDMKNKHCIAH = false, GameObject GHJKCLDLFLP = null, string IAGJJJPOFDA = null)
	{
		string OCLDJACNGED = null;
		NHAEJBOMEIC(ONHHAFBOPFG, out OCLDJACNGED, JBPBIOHLLKP, KOOENHBOKPL, GOOLKAODJAH, MDMKNKHCIAH, GHJKCLDLFLP, IAGJJJPOFDA);
		return OCLDJACNGED;
	}

	public static string PCGLGBPCBFP(string ONHHAFBOPFG, bool JBPBIOHLLKP = true, int KOOENHBOKPL = 0, bool GOOLKAODJAH = true, bool MDMKNKHCIAH = false, GameObject GHJKCLDLFLP = null, string IAGJJJPOFDA = null)
	{
		return NOGNJJIFAIN(ONHHAFBOPFG, JBPBIOHLLKP, KOOENHBOKPL, GOOLKAODJAH, MDMKNKHCIAH, GHJKCLDLFLP, IAGJJJPOFDA);
	}

	public static bool NHAEJBOMEIC(string ONHHAFBOPFG, out string OCLDJACNGED, bool JBPBIOHLLKP = true, int KOOENHBOKPL = 0, bool GOOLKAODJAH = true, bool MDMKNKHCIAH = false, GameObject GHJKCLDLFLP = null, string IAGJJJPOFDA = null)
	{
		OCLDJACNGED = null;
		if (string.IsNullOrEmpty(ONHHAFBOPFG))
		{
			return false;
		}
		DCBKDEEHAIG();
		int i = 0;
		for (int count = ODEOFDCJHNK.Count; i < count; i++)
		{
			if (ODEOFDCJHNK[i].TryGetTranslation(ONHHAFBOPFG, out OCLDJACNGED, IAGJJJPOFDA))
			{
				if (MDMKNKHCIAH)
				{
					DNDINFAAJFL(ref OCLDJACNGED, GHJKCLDLFLP);
				}
				if (MNHBNGFDIPC && JBPBIOHLLKP)
				{
					OCLDJACNGED = IFCCJDKHIHP(OCLDJACNGED, KOOENHBOKPL, GOOLKAODJAH);
				}
				return true;
			}
		}
		return false;
	}

	public static string MKECOBFGKOP(string KPHNEGOLNGA)
	{
		if (!string.IsNullOrEmpty(KPHNEGOLNGA))
		{
			for (int i = 0; i < ODEOFDCJHNK.Count; i++)
			{
				if (string.IsNullOrEmpty(ODEOFDCJHNK[i].mTerm_AppName))
				{
					continue;
				}
				int languageIndexFromCode = ODEOFDCJHNK[i].GetLanguageIndexFromCode(KPHNEGOLNGA, false);
				if (languageIndexFromCode < 0)
				{
					continue;
				}
				TermData termData = ODEOFDCJHNK[i].GetTermData(ODEOFDCJHNK[i].mTerm_AppName);
				if (termData != null)
				{
					string text = termData.NOGNJJIFAIN(languageIndexFromCode);
					if (!string.IsNullOrEmpty(text))
					{
						return text;
					}
				}
			}
		}
		return Application.productName;
	}

	public static void EBEBNPMKGEO(bool LLLFMBNNMBG = false)
	{
		if (!Application.isPlaying)
		{
			GKEFMHJEPBD(LLLFMBNNMBG);
			return;
		}
		JLGIKOCDKCK |= LLLFMBNNMBG;
		if (!AGJCBEALDNE)
		{
			CoroutineManager.Start(EJHHLHHGAGC());
		}
	}

	private static IEnumerator EJHHLHHGAGC()
	{
		AGJCBEALDNE = true;
		yield return null;
		AGJCBEALDNE = false;
		bool jLGIKOCDKCK = JLGIKOCDKCK;
		JLGIKOCDKCK = false;
		GKEFMHJEPBD(jLGIKOCDKCK);
	}

	private static void GKEFMHJEPBD(bool LLLFMBNNMBG = false)
	{
		Localize[] array = (Localize[])Resources.FindObjectsOfTypeAll(typeof(Localize));
		int i = 0;
		for (int num = array.Length; i < num; i++)
		{
			Localize localize = array[i];
			localize.OnLocalize(LLLFMBNNMBG);
		}
		if (PNAJOCHGJFO.BEBEKBLNBDB != null)
		{
			PNAJOCHGJFO.BEBEKBLNBDB();
		}
		ResourceManager.MGLPOGMOMJM.CleanResourceCache();
	}

	public static List<string> NGFIEPJHCJN()
	{
		List<string> list = new List<string>();
		int i = 0;
		for (int count = ODEOFDCJHNK.Count; i < count; i++)
		{
			ODEOFDCJHNK[i].GetCategories(false, list);
		}
		return list;
	}

	public static List<string> EDEPKOEEOGL(string LGIJCCHPGKD = null)
	{
		if (ODEOFDCJHNK.Count == 0)
		{
			JHMHBFIFFFK();
		}
		if (ODEOFDCJHNK.Count == 1)
		{
			return ODEOFDCJHNK[0].GetTermsList(LGIJCCHPGKD);
		}
		HashSet<string> hashSet = new HashSet<string>();
		int i = 0;
		for (int count = ODEOFDCJHNK.Count; i < count; i++)
		{
			hashSet.UnionWith(ODEOFDCJHNK[i].GetTermsList(LGIJCCHPGKD));
		}
		return new List<string>(hashSet);
	}

	public static TermData MJFCJBJIFHC(string PPJJIIFOONJ)
	{
		DCBKDEEHAIG();
		int i = 0;
		for (int count = ODEOFDCJHNK.Count; i < count; i++)
		{
			TermData termData = ODEOFDCJHNK[i].GetTermData(PPJJIIFOONJ);
			if (termData != null)
			{
				return termData;
			}
		}
		return null;
	}

	public static void JNCGFCADPNN(ABOOAELLAEJ NEMEKIOEOLC)
	{
		foreach (ABOOAELLAEJ item in MHJDEGPMHJN)
		{
			if (item.GetType() == NEMEKIOEOLC.GetType())
			{
				return;
			}
		}
		MHJDEGPMHJN.Add(NEMEKIOEOLC);
		MHJDEGPMHJN.Sort((ABOOAELLAEJ MNIMEAMHNMI, ABOOAELLAEJ BCIHLCMFAEK) => MNIMEAMHNMI.ENPNBOFBDLJ().CompareTo(BCIHLCMFAEK.ENPNBOFBDLJ()));
	}

	[CompilerGenerated]
	private static object KLNIPACDCBP(string HPHBDNBJPHB)
	{
		return EJJABODFBKC(HPHBDNBJPHB, null);
	}

	[CompilerGenerated]
	private static int NOBALLCELBL(ABOOAELLAEJ MNIMEAMHNMI, ABOOAELLAEJ BCIHLCMFAEK)
	{
		return MNIMEAMHNMI.ENPNBOFBDLJ().CompareTo(BCIHLCMFAEK.ENPNBOFBDLJ());
	}
}
