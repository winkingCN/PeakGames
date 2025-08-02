using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace I2.Loc
{
	[ExecuteInEditMode]
	[AddComponentMenu("I2/Localization/Source")]
	public class LanguageSource : MonoBehaviour
	{
		public enum DOLAEHNLDAH
		{
			Always = 0,
			Never = 1,
			Daily = 2,
			Weekly = 3,
			Monthly = 4,
			OnlyOnce = 5
		}

		public enum LDGMFHNANJI
		{
			PC = 0,
			Touch = 1,
			Controller = 2
		}

		public enum HNKACGNPDNP
		{
			Empty = 0,
			Fallback = 1,
			ShowWarning = 2
		}

		public string Google_WebServiceURL;

		public string Google_SpreadsheetKey;

		public string Google_SpreadsheetName;

		public string Google_LastUpdatedVersion;

		public DOLAEHNLDAH GoogleUpdateFrequency = DOLAEHNLDAH.Weekly;

		public float GoogleUpdateDelay = 5f;

		public static string EmptyCategory = "Default";

		public static char[] CategorySeparators = "/\\".ToCharArray();

		public List<TermData> mTerms = new List<TermData>();

		public List<LanguageData> mLanguages = new List<LanguageData>();

		public bool CaseInsensitiveTerms;

		[NonSerialized]
		public Dictionary<string, TermData> mDictionary = new Dictionary<string, TermData>(StringComparer.Ordinal);

		[NonSerialized]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary = new Dictionary<string, UnityEngine.Object>(StringComparer.Ordinal);

		public List<UnityEngine.Object> Assets = new List<UnityEngine.Object>();

		public bool NeverDestroy;

		public bool UserAgreesToHaveItOnTheScene;

		public bool UserAgreesToHaveItInsideThePluginsFolder;

		public HNKACGNPDNP OnMissingTranslation = HNKACGNPDNP.Fallback;

		public string mTerm_AppName;

		public bool IgnoreDeviceLanguage;

		[CompilerGenerated]
		private static Predicate<UnityEngine.Object> EBCOMJBLIPP;

		[CompilerGenerated]
		private static Func<UnityEngine.Object, string> DNBOPLHGMHA;

		public event Action<LanguageSource, bool, string> CPFDFJDLKMM;

		public string Export_I2CSV(string LGIJCCHPGKD, char PJCMEAMAHOA = ',')
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Key[*]Type[*]Desc");
			foreach (LanguageData mLanguage in mLanguages)
			{
				stringBuilder.Append("[*]");
				if (!mLanguage.FCIBLDEJAPL())
				{
					stringBuilder.Append('$');
				}
				stringBuilder.Append(PBPPLCKNBDJ.KDJIEIAOCID(mLanguage.Name, mLanguage.Code));
			}
			stringBuilder.Append("[ln]");
			int count = mLanguages.Count;
			bool flag = true;
			foreach (TermData mTerm in mTerms)
			{
				string oNHHAFBOPFG;
				if (string.IsNullOrEmpty(LGIJCCHPGKD) || (LGIJCCHPGKD == EmptyCategory && mTerm.Term.IndexOfAny(CategorySeparators) < 0))
				{
					oNHHAFBOPFG = mTerm.Term;
				}
				else
				{
					if (!mTerm.Term.StartsWith(LGIJCCHPGKD + "/") || !(LGIJCCHPGKD != mTerm.Term))
					{
						continue;
					}
					oNHHAFBOPFG = mTerm.Term.Substring(LGIJCCHPGKD.Length + 1);
				}
				if (!flag)
				{
					stringBuilder.Append("[ln]");
				}
				else
				{
					flag = false;
				}
				LEMOOCNCFGM(stringBuilder, count, oNHHAFBOPFG, mTerm, string.Empty, mTerm.Languages, mTerm.Languages_Touch, PJCMEAMAHOA, 1, 2);
				if (mTerm.IACDIGLMGCO())
				{
					if (!flag)
					{
						stringBuilder.Append("[ln]");
					}
					else
					{
						flag = false;
					}
					LEMOOCNCFGM(stringBuilder, count, oNHHAFBOPFG, mTerm, "[touch]", mTerm.Languages_Touch, null, PJCMEAMAHOA, 2, 1);
				}
			}
			return stringBuilder.ToString();
		}

		private static void LEMOOCNCFGM(StringBuilder DODIPEKPJDM, int PNNGMGIGHGJ, string ONHHAFBOPFG, TermData CIJIDOPMKGH, string JKICBDHIPKE, string[] HDJJOANDCJE, string[] LFCNEMEANHH, char PJCMEAMAHOA, byte DBIBBCMJCBE, byte BOLCCLOINOP)
		{
			DODIPEKPJDM.Append(ONHHAFBOPFG);
			DODIPEKPJDM.Append(JKICBDHIPKE);
			DODIPEKPJDM.Append("[*]");
			DODIPEKPJDM.Append(CIJIDOPMKGH.TermType.ToString());
			DODIPEKPJDM.Append("[*]");
			DODIPEKPJDM.Append(CIJIDOPMKGH.Description);
			for (int i = 0; i < Mathf.Min(PNNGMGIGHGJ, HDJJOANDCJE.Length); i++)
			{
				DODIPEKPJDM.Append("[*]");
				string value = HDJJOANDCJE[i];
				if (string.IsNullOrEmpty(value) && LFCNEMEANHH != null)
				{
					value = LFCNEMEANHH[i];
				}
				DODIPEKPJDM.Append(value);
			}
		}

		public string Export_CSV(string LGIJCCHPGKD, char PJCMEAMAHOA = ',')
		{
			StringBuilder stringBuilder = new StringBuilder();
			int count = mLanguages.Count;
			stringBuilder.AppendFormat("Key{0}Type{0}Desc", PJCMEAMAHOA);
			foreach (LanguageData mLanguage in mLanguages)
			{
				stringBuilder.Append(PJCMEAMAHOA);
				if (!mLanguage.FCIBLDEJAPL())
				{
					stringBuilder.Append('$');
				}
				EOGGIMMMMIJ(stringBuilder, PBPPLCKNBDJ.KDJIEIAOCID(mLanguage.Name, mLanguage.Code), PJCMEAMAHOA);
			}
			stringBuilder.Append("\n");
			for (int i = 0; i < mTerms.Count - 1; i++)
			{
				for (int j = i + 1; j < mTerms.Count; j++)
				{
					if (string.CompareOrdinal(mTerms[i].Term, mTerms[j].Term) > 0)
					{
						TermData value = mTerms[i];
						mTerms[i] = mTerms[j];
						mTerms[j] = value;
					}
				}
			}
			foreach (TermData mTerm in mTerms)
			{
				string oNHHAFBOPFG;
				if (string.IsNullOrEmpty(LGIJCCHPGKD) || (LGIJCCHPGKD == EmptyCategory && mTerm.Term.IndexOfAny(CategorySeparators) < 0))
				{
					oNHHAFBOPFG = mTerm.Term;
				}
				else
				{
					if (!mTerm.Term.StartsWith(LGIJCCHPGKD + "/") || !(LGIJCCHPGKD != mTerm.Term))
					{
						continue;
					}
					oNHHAFBOPFG = mTerm.Term.Substring(LGIJCCHPGKD.Length + 1);
				}
				CIDGOKBHCMN(stringBuilder, count, oNHHAFBOPFG, mTerm, null, mTerm.Languages, mTerm.Languages_Touch, PJCMEAMAHOA, 1, 2);
				if (mTerm.IACDIGLMGCO())
				{
					CIDGOKBHCMN(stringBuilder, count, oNHHAFBOPFG, mTerm, "[touch]", mTerm.Languages_Touch, null, PJCMEAMAHOA, 2, 1);
				}
			}
			return stringBuilder.ToString();
		}

		private static void CIDGOKBHCMN(StringBuilder DODIPEKPJDM, int PNNGMGIGHGJ, string ONHHAFBOPFG, TermData CIJIDOPMKGH, string AEKIHILHNPD, string[] HDJJOANDCJE, string[] LFCNEMEANHH, char PJCMEAMAHOA, byte DBIBBCMJCBE, byte BOLCCLOINOP)
		{
			EOGGIMMMMIJ(DODIPEKPJDM, ONHHAFBOPFG, PJCMEAMAHOA);
			if (!string.IsNullOrEmpty(AEKIHILHNPD))
			{
				DODIPEKPJDM.Append(AEKIHILHNPD);
			}
			DODIPEKPJDM.Append(PJCMEAMAHOA);
			DODIPEKPJDM.Append(CIJIDOPMKGH.TermType.ToString());
			DODIPEKPJDM.Append(PJCMEAMAHOA);
			EOGGIMMMMIJ(DODIPEKPJDM, CIJIDOPMKGH.Description, PJCMEAMAHOA);
			for (int i = 0; i < Mathf.Min(PNNGMGIGHGJ, HDJJOANDCJE.Length); i++)
			{
				DODIPEKPJDM.Append(PJCMEAMAHOA);
				string text = HDJJOANDCJE[i];
				if (string.IsNullOrEmpty(text) && LFCNEMEANHH != null)
				{
					text = LFCNEMEANHH[i];
				}
				FIAPIFJMEKJ(DODIPEKPJDM, text, PJCMEAMAHOA, string.Empty);
			}
			DODIPEKPJDM.Append("\n");
		}

		private static void EOGGIMMMMIJ(StringBuilder DODIPEKPJDM, string NKFGCOFBKMA, char PJCMEAMAHOA)
		{
			if (!string.IsNullOrEmpty(NKFGCOFBKMA))
			{
				NKFGCOFBKMA = NKFGCOFBKMA.Replace("\\n", "\n");
				if (NKFGCOFBKMA.IndexOfAny((PJCMEAMAHOA + "\n\"").ToCharArray()) >= 0)
				{
					NKFGCOFBKMA = NKFGCOFBKMA.Replace("\"", "\"\"");
					DODIPEKPJDM.AppendFormat("\"{0}\"", NKFGCOFBKMA);
				}
				else
				{
					DODIPEKPJDM.Append(NKFGCOFBKMA);
				}
			}
		}

		private static void FIAPIFJMEKJ(StringBuilder DODIPEKPJDM, string NKFGCOFBKMA, char PJCMEAMAHOA, string NIJLMBACDIN)
		{
			if (!string.IsNullOrEmpty(NKFGCOFBKMA))
			{
				NKFGCOFBKMA = NKFGCOFBKMA.Replace("\\n", "\n");
				if (NKFGCOFBKMA.IndexOfAny((PJCMEAMAHOA + "\n\"").ToCharArray()) >= 0)
				{
					NKFGCOFBKMA = NKFGCOFBKMA.Replace("\"", "\"\"");
					DODIPEKPJDM.AppendFormat("\"{0}{1}\"", NIJLMBACDIN, NKFGCOFBKMA);
				}
				else
				{
					DODIPEKPJDM.Append(NIJLMBACDIN);
					DODIPEKPJDM.Append(NKFGCOFBKMA);
				}
			}
		}

		public WWW Export_Google_CreateWWWcall(NKNJNGJLGEC MDFKBHBADLB = NKNJNGJLGEC.Replace)
		{
			string value = KMCIGBOFAOO();
			WWWForm wWWForm = new WWWForm();
			wWWForm.AddField("key", Google_SpreadsheetKey);
			wWWForm.AddField("action", "SetLanguageSource");
			wWWForm.AddField("data", value);
			wWWForm.AddField("updateMode", MDFKBHBADLB.ToString());
			return new WWW(PNAJOCHGJFO.GDCLLONGOFO(this), wWWForm);
		}

		private string KMCIGBOFAOO()
		{
			List<string> categories = GetCategories(true);
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = true;
			foreach (string item in categories)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					stringBuilder.Append("<I2Loc>");
				}
				string value = Export_I2CSV(item);
				stringBuilder.Append(item);
				stringBuilder.Append("<I2Loc>");
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString();
		}

		public string Import_CSV(string LGIJCCHPGKD, string PECFCKMAOMC, NKNJNGJLGEC MDFKBHBADLB = NKNJNGJLGEC.Replace, char PJCMEAMAHOA = ',')
		{
			List<string[]> lOJFLDDGMKM = FGBEECPLAIG.HJNGBJCPPHO(PECFCKMAOMC, PJCMEAMAHOA);
			return Import_CSV(LGIJCCHPGKD, lOJFLDDGMKM, MDFKBHBADLB);
		}

		public string Import_I2CSV(string LGIJCCHPGKD, string OCKACANNKNG, NKNJNGJLGEC MDFKBHBADLB = NKNJNGJLGEC.Replace)
		{
			List<string[]> lOJFLDDGMKM = FGBEECPLAIG.GGAACPHHMKE(OCKACANNKNG);
			return Import_CSV(LGIJCCHPGKD, lOJFLDDGMKM, MDFKBHBADLB);
		}

		public string Import_CSV(string LGIJCCHPGKD, List<string[]> LOJFLDDGMKM, NKNJNGJLGEC MDFKBHBADLB = NKNJNGJLGEC.Replace)
		{
			string[] array = LOJFLDDGMKM[0];
			int num = 1;
			int num2 = -1;
			int num3 = -1;
			string[] dPJOLFHEBFH = new string[1] { "Key" };
			string[] dPJOLFHEBFH2 = new string[1] { "Type" };
			string[] dPJOLFHEBFH3 = new string[2] { "Desc", "Description" };
			if (array.Length > 1 && AJPMCJDHKLF(array[0], dPJOLFHEBFH))
			{
				if (MDFKBHBADLB == NKNJNGJLGEC.Replace)
				{
					ClearAllData();
				}
				if (array.Length > 2)
				{
					if (AJPMCJDHKLF(array[1], dPJOLFHEBFH2))
					{
						num2 = 1;
						num = 2;
					}
					if (AJPMCJDHKLF(array[1], dPJOLFHEBFH3))
					{
						num3 = 1;
						num = 2;
					}
				}
				if (array.Length > 3)
				{
					if (AJPMCJDHKLF(array[2], dPJOLFHEBFH2))
					{
						num2 = 2;
						num = 3;
					}
					if (AJPMCJDHKLF(array[2], dPJOLFHEBFH3))
					{
						num3 = 2;
						num = 3;
					}
				}
				int num4 = Mathf.Max(array.Length - num, 0);
				int[] array2 = new int[num4];
				for (int i = 0; i < num4; i++)
				{
					if (string.IsNullOrEmpty(array[i + num]))
					{
						array2[i] = -1;
						continue;
					}
					string text = array[i + num];
					bool flag = true;
					if (text.StartsWith("$"))
					{
						flag = false;
						text = text.Substring(1);
					}
					string OEMDOLLFPDF;
					string FJCNPLPKFKP;
					PBPPLCKNBDJ.BEBLBHJEMBL(text, out OEMDOLLFPDF, out FJCNPLPKFKP);
					int num5 = -1;
					num5 = (string.IsNullOrEmpty(FJCNPLPKFKP) ? GetLanguageIndex(OEMDOLLFPDF) : GetLanguageIndexFromCode(FJCNPLPKFKP));
					if (num5 < 0)
					{
						LanguageData languageData = new LanguageData();
						languageData.Name = OEMDOLLFPDF;
						languageData.Code = FJCNPLPKFKP;
						languageData.Flags = (byte)(0u | ((!flag) ? 1u : 0u));
						mLanguages.Add(languageData);
						num5 = mLanguages.Count - 1;
					}
					array2[i] = num5;
				}
				num4 = mLanguages.Count;
				int j = 0;
				for (int count = mTerms.Count; j < count; j++)
				{
					TermData termData = mTerms[j];
					if (termData.Languages.Length < num4)
					{
						Array.Resize(ref termData.Languages, num4);
						Array.Resize(ref termData.Languages_Touch, num4);
						Array.Resize(ref termData.Flags, num4);
					}
				}
				int k = 1;
				for (int count2 = LOJFLDDGMKM.Count; k < count2; k++)
				{
					array = LOJFLDDGMKM[k];
					string ONHHAFBOPFG = ((!string.IsNullOrEmpty(LGIJCCHPGKD)) ? (LGIJCCHPGKD + "/" + array[0]) : array[0]);
					bool flag2 = false;
					if (ONHHAFBOPFG.EndsWith("[touch]"))
					{
						ONHHAFBOPFG = ONHHAFBOPFG.Remove(ONHHAFBOPFG.Length - "[touch]".Length);
						flag2 = true;
					}
					ValidateFullTerm(ref ONHHAFBOPFG);
					if (string.IsNullOrEmpty(ONHHAFBOPFG))
					{
						continue;
					}
					TermData termData2 = GetTermData(ONHHAFBOPFG);
					if (termData2 == null)
					{
						termData2 = new TermData();
						termData2.Term = ONHHAFBOPFG;
						termData2.Languages = new string[mLanguages.Count];
						termData2.Languages_Touch = new string[mLanguages.Count];
						termData2.Flags = new byte[mLanguages.Count];
						for (int l = 0; l < mLanguages.Count; l++)
						{
							termData2.Languages[l] = (termData2.Languages_Touch[l] = string.Empty);
						}
						mTerms.Add(termData2);
						mDictionary.Add(ONHHAFBOPFG, termData2);
					}
					else if (MDFKBHBADLB == NKNJNGJLGEC.AddNewTerms)
					{
						continue;
					}
					if (num2 > 0)
					{
						termData2.TermType = GetTermType(array[num2]);
					}
					if (num3 > 0)
					{
						termData2.Description = array[num3];
					}
					for (int m = 0; m < array2.Length && m < array.Length - num; m++)
					{
						if (string.IsNullOrEmpty(array[m + num]))
						{
							continue;
						}
						int num6 = array2[m];
						if (num6 >= 0)
						{
							string text2 = array[m + num];
							if (flag2)
							{
								termData2.Languages_Touch[num6] = text2;
								termData2.Flags[num6] &= 253;
							}
							else
							{
								termData2.Languages[num6] = text2;
								termData2.Flags[num6] &= 254;
							}
						}
					}
				}
				return string.Empty;
			}
			return "Bad Spreadsheet Format.\nFirst columns should be 'Key', 'Type' and 'Desc'";
		}

		private bool AJPMCJDHKLF(string OJKBLMBACFM, params string[] DPJOLFHEBFH)
		{
			int i = 0;
			for (int num = DPJOLFHEBFH.Length; i < num; i++)
			{
				if (OJKBLMBACFM.IndexOf(DPJOLFHEBFH[i], StringComparison.OrdinalIgnoreCase) >= 0)
				{
					return true;
				}
			}
			return false;
		}

		public static LPNCMDLKPHE GetTermType(string NBFBPNNEKMN)
		{
			int i = 0;
			for (int num = 9; i <= num; i++)
			{
				LPNCMDLKPHE lPNCMDLKPHE = (LPNCMDLKPHE)i;
				if (string.Equals(lPNCMDLKPHE.ToString(), NBFBPNNEKMN, StringComparison.OrdinalIgnoreCase))
				{
					return (LPNCMDLKPHE)i;
				}
			}
			return LPNCMDLKPHE.Text;
		}

		public static void FreeUnusedLanguages()
		{
			LanguageSource languageSource = PNAJOCHGJFO.ODEOFDCJHNK[0];
			int languageIndex = languageSource.GetLanguageIndex(PNAJOCHGJFO.LOEHJECLFHL);
			for (int i = 0; i < languageSource.mTerms.Count; i++)
			{
				TermData termData = languageSource.mTerms[i];
				for (int j = 0; j < termData.Languages.Length; j++)
				{
					if (j != languageIndex)
					{
						termData.Languages[j] = (termData.Languages_Touch[j] = null);
					}
				}
			}
		}

		public void Import_Google_FromCache()
		{
			if (GoogleUpdateFrequency == DOLAEHNLDAH.Never || !ODIHEPBMAPE.MIGINPHAHND())
			{
				return;
			}
			string text = EEDHGLOLNLA();
			string text2 = BOEMOLDHCJC.JIKNLJNFPFG("I2Source_" + text);
			if (string.IsNullOrEmpty(text2))
			{
				return;
			}
			if (text2.StartsWith("[i2e]", StringComparison.Ordinal))
			{
				text2 = CMMBKFDMAJO.ILOALOLANOL(text2.Substring(5, text2.Length - 5));
			}
			bool flag = false;
			string text3 = Google_LastUpdatedVersion;
			if (PlayerPrefs.HasKey("I2SourceVersion_" + text))
			{
				text3 = PlayerPrefs.GetString("I2SourceVersion_" + text, Google_LastUpdatedVersion);
				flag = GNLNPADONGH(Google_LastUpdatedVersion, text3);
			}
			if (!flag)
			{
				BOEMOLDHCJC.GIOCEEGBFKL("I2Source_" + text);
				PlayerPrefs.DeleteKey("I2SourceVersion_" + text);
				return;
			}
			if (text3.Length > 19)
			{
				text3 = string.Empty;
			}
			Google_LastUpdatedVersion = text3;
			Import_Google_Result(text2, NKNJNGJLGEC.Replace);
		}

		private bool GNLNPADONGH(string HKMAJLNBJNN, string BOGKBNEIHDB)
		{
			if (string.IsNullOrEmpty(BOGKBNEIHDB))
			{
				return false;
			}
			if (string.IsNullOrEmpty(HKMAJLNBJNN))
			{
				return true;
			}
			long result;
			long result2;
			if (!long.TryParse(BOGKBNEIHDB, out result) || !long.TryParse(HKMAJLNBJNN, out result2))
			{
				return true;
			}
			return result > result2;
		}

		public void Import_Google(bool OGALIALHFMD = false)
		{
			if (!OGALIALHFMD && GoogleUpdateFrequency == DOLAEHNLDAH.Never)
			{
				return;
			}
			string text = EEDHGLOLNLA();
			if (!OGALIALHFMD && GoogleUpdateFrequency != 0)
			{
				string @string = PlayerPrefs.GetString("LastGoogleUpdate_" + text, string.Empty);
				try
				{
					DateTime result;
					if (DateTime.TryParse(@string, out result))
					{
						double totalDays = (DateTime.Now - result).TotalDays;
						switch (GoogleUpdateFrequency)
						{
						case DOLAEHNLDAH.Daily:
							if (totalDays < 1.0)
							{
								return;
							}
							break;
						case DOLAEHNLDAH.Weekly:
							if (totalDays < 8.0)
							{
								return;
							}
							break;
						case DOLAEHNLDAH.Monthly:
							if (totalDays < 31.0)
							{
								return;
							}
							break;
						case DOLAEHNLDAH.OnlyOnce:
							return;
						}
					}
				}
				catch (Exception)
				{
				}
			}
			PlayerPrefs.SetString("LastGoogleUpdate_" + text, DateTime.Now.ToString());
			CoroutineManager.Start(JMALFDAGDJB());
		}

		private string EEDHGLOLNLA()
		{
			if (Array.IndexOf(PNAJOCHGJFO.MKMKPCOBGBF, base.name) >= 0)
			{
				return base.name;
			}
			return SceneManager.GetActiveScene().name + "_" + base.name;
		}

		private IEnumerator JMALFDAGDJB()
		{
			WWW wWW = Import_Google_CreateWWWcall();
			if (wWW == null)
			{
				yield break;
			}
			while (!wWW.isDone)
			{
				yield return null;
			}
			bool flag = string.IsNullOrEmpty(wWW.error);
			string text = null;
			if (flag)
			{
				byte[] bytes = wWW.bytes;
				text = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
			}
			if (flag && !string.IsNullOrEmpty(text) && text != "\"\"")
			{
				string value = Import_Google_Result(text, NKNJNGJLGEC.Replace, true);
				if (string.IsNullOrEmpty(value))
				{
					if (this.CPFDFJDLKMM != null)
					{
						this.CPFDFJDLKMM(this, true, wWW.error);
					}
					PNAJOCHGJFO.EBEBNPMKGEO(true);
					Debug.Log("Done Google Sync");
				}
				else
				{
					if (this.CPFDFJDLKMM != null)
					{
						this.CPFDFJDLKMM(this, false, wWW.error);
					}
					Debug.Log("Done Google Sync: source was up-to-date");
				}
			}
			else
			{
				if (this.CPFDFJDLKMM != null)
				{
					this.CPFDFJDLKMM(this, false, wWW.error);
				}
				Debug.Log("Language Source was up-to-date with Google Spreadsheet");
			}
		}

		public WWW Import_Google_CreateWWWcall(bool OGALIALHFMD = false)
		{
			if (!HasGoogleSpreadsheet())
			{
				return null;
			}
			string text = PlayerPrefs.GetString("I2SourceVersion_" + EEDHGLOLNLA(), Google_LastUpdatedVersion);
			if (text.Length > 19)
			{
				text = string.Empty;
			}
			if (GNLNPADONGH(text, Google_LastUpdatedVersion))
			{
				Google_LastUpdatedVersion = text;
			}
			string url = string.Format("{0}?key={1}&action=GetLanguageSource&version={2}", PNAJOCHGJFO.GDCLLONGOFO(this), Google_SpreadsheetKey, (!OGALIALHFMD) ? Google_LastUpdatedVersion : "0");
			return new WWW(url);
		}

		public bool HasGoogleSpreadsheet()
		{
			return !string.IsNullOrEmpty(PNAJOCHGJFO.GDCLLONGOFO(this)) && !string.IsNullOrEmpty(Google_SpreadsheetKey) && !string.IsNullOrEmpty(Google_SpreadsheetName);
		}

		public string Import_Google_Result(string GPIHNAEECAH, NKNJNGJLGEC MDFKBHBADLB, bool JBDDDFKNADE = false)
		{
			try
			{
				string empty = string.Empty;
				if (string.IsNullOrEmpty(GPIHNAEECAH) || GPIHNAEECAH == "\"\"")
				{
					return empty;
				}
				int num = GPIHNAEECAH.IndexOf("version=", StringComparison.Ordinal);
				int num2 = GPIHNAEECAH.IndexOf("script_version=", StringComparison.Ordinal);
				if (num < 0 || num2 < 0)
				{
					return "Invalid Response from Google, Most likely the WebService needs to be updated";
				}
				num += "version=".Length;
				num2 += "script_version=".Length;
				string text = GPIHNAEECAH.Substring(num, GPIHNAEECAH.IndexOf(",", num, StringComparison.Ordinal) - num);
				int num3 = int.Parse(GPIHNAEECAH.Substring(num2, GPIHNAEECAH.IndexOf(",", num2, StringComparison.Ordinal) - num2));
				if (text.Length > 19)
				{
					text = string.Empty;
				}
				if (num3 != PNAJOCHGJFO.OPGIKMEFJAJ())
				{
					return "The current Google WebService is not supported.\nPlease, delete the WebService from the Google Drive and Install the latest version.";
				}
				if (JBDDDFKNADE && !GNLNPADONGH(Google_LastUpdatedVersion, text))
				{
					return "LanguageSource is up-to-date";
				}
				if (JBDDDFKNADE)
				{
					string text2 = EEDHGLOLNLA();
					BOEMOLDHCJC.GMGIINAJJMK("I2Source_" + text2, "[i2e]" + CMMBKFDMAJO.LMDBBPLCJDM(GPIHNAEECAH));
					PlayerPrefs.SetString("I2SourceVersion_" + text2, text);
					PlayerPrefs.Save();
				}
				Google_LastUpdatedVersion = text;
				if (MDFKBHBADLB == NKNJNGJLGEC.Replace)
				{
					ClearAllData();
				}
				int num4 = GPIHNAEECAH.IndexOf("[i2category]", StringComparison.Ordinal);
				while (num4 > 0)
				{
					num4 += "[i2category]".Length;
					int num5 = GPIHNAEECAH.IndexOf("[/i2category]", num4, StringComparison.Ordinal);
					string lGIJCCHPGKD = GPIHNAEECAH.Substring(num4, num5 - num4);
					num5 += "[/i2category]".Length;
					int num6 = GPIHNAEECAH.IndexOf("[/i2csv]", num5, StringComparison.Ordinal);
					string oCKACANNKNG = GPIHNAEECAH.Substring(num5, num6 - num5);
					num4 = GPIHNAEECAH.IndexOf("[i2category]", num6, StringComparison.Ordinal);
					Import_I2CSV(lGIJCCHPGKD, oCKACANNKNG, MDFKBHBADLB);
					if (MDFKBHBADLB == NKNJNGJLGEC.Replace)
					{
						MDFKBHBADLB = NKNJNGJLGEC.Merge;
					}
				}
				return empty;
			}
			catch (Exception ex)
			{
				Debug.LogWarning(ex);
				return ex.ToString();
			}
		}

		public List<string> GetCategories(bool JNCFFAGDPBJ = false, List<string> KNOJOBIBOPP = null)
		{
			if (KNOJOBIBOPP == null)
			{
				KNOJOBIBOPP = new List<string>();
			}
			foreach (TermData mTerm in mTerms)
			{
				string categoryFromFullTerm = GetCategoryFromFullTerm(mTerm.Term, JNCFFAGDPBJ);
				if (!KNOJOBIBOPP.Contains(categoryFromFullTerm))
				{
					KNOJOBIBOPP.Add(categoryFromFullTerm);
				}
			}
			KNOJOBIBOPP.Sort();
			return KNOJOBIBOPP;
		}

		public static string GetKeyFromFullTerm(string PPLBNNEMHIM, bool JNCFFAGDPBJ = false)
		{
			int num = ((!JNCFFAGDPBJ) ? PPLBNNEMHIM.LastIndexOfAny(CategorySeparators) : PPLBNNEMHIM.IndexOfAny(CategorySeparators));
			return (num >= 0) ? PPLBNNEMHIM.Substring(num + 1) : PPLBNNEMHIM;
		}

		public static string GetCategoryFromFullTerm(string PPLBNNEMHIM, bool JNCFFAGDPBJ = false)
		{
			int num = ((!JNCFFAGDPBJ) ? PPLBNNEMHIM.LastIndexOfAny(CategorySeparators) : PPLBNNEMHIM.IndexOfAny(CategorySeparators));
			return (num >= 0) ? PPLBNNEMHIM.Substring(0, num) : EmptyCategory;
		}

		public static void DeserializeFullTerm(string PPLBNNEMHIM, out string CDEOGMLENPN, out string LGIJCCHPGKD, bool JNCFFAGDPBJ = false)
		{
			int num = ((!JNCFFAGDPBJ) ? PPLBNNEMHIM.LastIndexOfAny(CategorySeparators) : PPLBNNEMHIM.IndexOfAny(CategorySeparators));
			if (num < 0)
			{
				LGIJCCHPGKD = EmptyCategory;
				CDEOGMLENPN = PPLBNNEMHIM;
			}
			else
			{
				LGIJCCHPGKD = PPLBNNEMHIM.Substring(0, num);
				CDEOGMLENPN = PPLBNNEMHIM.Substring(num + 1);
			}
		}

		public static LDGMFHNANJI GetCurrentInputType()
		{
			return LDGMFHNANJI.Touch;
		}

		private void Awake()
		{
			NeverDestroy = false;
			if (NeverDestroy)
			{
				if (OJAJFBODLJN())
				{
					UnityEngine.Object.Destroy(this);
					return;
				}
				if (Application.isPlaying)
				{
					UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
				}
			}
			PNAJOCHGJFO.FPOGOHHDEOB(this);
			UpdateDictionary();
			UpdateAssetDictionary();
			PNAJOCHGJFO.EBEBNPMKGEO(true);
		}

		private void OnDestroy()
		{
			NeverDestroy = false;
			if (!NeverDestroy)
			{
				PNAJOCHGJFO.JKJDOMKCMCJ(this);
			}
		}

		public void UpdateDictionary(bool PNMBCFAEHBH = false)
		{
			if (!PNMBCFAEHBH && mDictionary != null && mDictionary.Count == mTerms.Count)
			{
				return;
			}
			StringComparer stringComparer = ((!CaseInsensitiveTerms) ? StringComparer.Ordinal : StringComparer.OrdinalIgnoreCase);
			if (mDictionary.Comparer != stringComparer)
			{
				mDictionary = new Dictionary<string, TermData>(stringComparer);
			}
			else
			{
				mDictionary.Clear();
			}
			int i = 0;
			for (int count = mTerms.Count; i < count; i++)
			{
				ValidateFullTerm(ref mTerms[i].Term);
				if (mTerms[i].Languages_Touch == null || mTerms[i].Languages_Touch.Length != mTerms[i].Languages.Length)
				{
					mTerms[i].Languages_Touch = new string[mTerms[i].Languages.Length];
				}
				mDictionary[mTerms[i].Term] = mTerms[i];
				mTerms[i].PIBLOPJEGEL();
			}
		}

		public void UpdateAssetDictionary()
		{
			Assets.RemoveAll((UnityEngine.Object AMFCENFNAJJ) => AMFCENFNAJJ == null);
			mAssetDictionary = Assets.ToDictionary((UnityEngine.Object AACCPLMFDIE) => AACCPLMFDIE.name);
		}

		public string GetSourceName()
		{
			string text = base.gameObject.name;
			Transform parent = base.transform.parent;
			while ((bool)parent)
			{
				text = parent.name + "_" + text;
				parent = parent.parent;
			}
			return text;
		}

		public int GetLanguageIndex(string GLFMIMLJAPI, bool LAPHDMBDNMP = true, bool FBMMHIMDOBK = true)
		{
			int i = 0;
			for (int count = mLanguages.Count; i < count; i++)
			{
				if ((!FBMMHIMDOBK || mLanguages[i].FCIBLDEJAPL()) && string.Compare(mLanguages[i].Name, GLFMIMLJAPI, StringComparison.OrdinalIgnoreCase) == 0)
				{
					return i;
				}
			}
			if (LAPHDMBDNMP)
			{
				int num = -1;
				int num2 = 0;
				int j = 0;
				for (int count2 = mLanguages.Count; j < count2; j++)
				{
					if (!FBMMHIMDOBK || mLanguages[j].FCIBLDEJAPL())
					{
						int commonWordInLanguageNames = GetCommonWordInLanguageNames(mLanguages[j].Name, GLFMIMLJAPI);
						if (commonWordInLanguageNames > num2)
						{
							num2 = commonWordInLanguageNames;
							num = j;
						}
					}
				}
				if (num >= 0)
				{
					return num;
				}
			}
			return -1;
		}

		public int GetLanguageIndexFromCode(string OBLPBFEPJCO, bool PEEPLOKGGPG = true)
		{
			int i = 0;
			for (int count = mLanguages.Count; i < count; i++)
			{
				if (string.Compare(mLanguages[i].Code, OBLPBFEPJCO, StringComparison.OrdinalIgnoreCase) == 0)
				{
					return i;
				}
			}
			if (!PEEPLOKGGPG)
			{
				int j = 0;
				for (int count2 = mLanguages.Count; j < count2; j++)
				{
					if (string.Compare(mLanguages[j].Code, 0, OBLPBFEPJCO, 0, 2, StringComparison.OrdinalIgnoreCase) == 0)
					{
						return j;
					}
				}
			}
			return -1;
		}

		public static int GetCommonWordInLanguageNames(string DJJPELHGKGF, string EKHPGMAHKID)
		{
			if (string.IsNullOrEmpty(DJJPELHGKGF) || string.IsNullOrEmpty(EKHPGMAHKID))
			{
				return 0;
			}
			char[] separator = "( )-/\\".ToCharArray();
			string[] array = DJJPELHGKGF.Split(separator);
			string[] array2 = EKHPGMAHKID.Split(separator);
			int num = 0;
			string[] array3 = array;
			foreach (string value in array3)
			{
				if (!string.IsNullOrEmpty(value) && array2.Contains(value))
				{
					num++;
				}
			}
			string[] array4 = array2;
			foreach (string value2 in array4)
			{
				if (!string.IsNullOrEmpty(value2) && array.Contains(value2))
				{
					num++;
				}
			}
			return num;
		}

		public static bool AreTheSameLanguage(string DJJPELHGKGF, string EKHPGMAHKID)
		{
			DJJPELHGKGF = GetLanguageWithoutRegion(DJJPELHGKGF);
			EKHPGMAHKID = GetLanguageWithoutRegion(EKHPGMAHKID);
			return string.Compare(DJJPELHGKGF, EKHPGMAHKID, StringComparison.OrdinalIgnoreCase) == 0;
		}

		public static string GetLanguageWithoutRegion(string OEMDOLLFPDF)
		{
			int num = OEMDOLLFPDF.IndexOfAny("(/\\[,{".ToCharArray());
			if (num < 0)
			{
				return OEMDOLLFPDF;
			}
			return OEMDOLLFPDF.Substring(0, num).Trim();
		}

		public void AddLanguage(string JICFGMNANHA, string HDMDEANOKHN)
		{
			if (GetLanguageIndex(JICFGMNANHA, false) < 0)
			{
				LanguageData languageData = new LanguageData();
				languageData.Name = JICFGMNANHA;
				languageData.Code = HDMDEANOKHN;
				mLanguages.Add(languageData);
				int count = mLanguages.Count;
				int i = 0;
				for (int count2 = mTerms.Count; i < count2; i++)
				{
					Array.Resize(ref mTerms[i].Languages, count);
					Array.Resize(ref mTerms[i].Languages_Touch, count);
					Array.Resize(ref mTerms[i].Flags, count);
				}
			}
		}

		public void RemoveLanguage(string JICFGMNANHA)
		{
			int languageIndex = GetLanguageIndex(JICFGMNANHA, false, false);
			if (languageIndex < 0)
			{
				return;
			}
			int count = mLanguages.Count;
			int i = 0;
			for (int count2 = mTerms.Count; i < count2; i++)
			{
				for (int j = languageIndex + 1; j < count; j++)
				{
					mTerms[i].Languages[j - 1] = mTerms[i].Languages[j];
					mTerms[i].Languages_Touch[j - 1] = mTerms[i].Languages_Touch[j];
					mTerms[i].Flags[j - 1] = mTerms[i].Flags[j];
				}
				Array.Resize(ref mTerms[i].Languages, count - 1);
				Array.Resize(ref mTerms[i].Languages_Touch, count - 1);
				Array.Resize(ref mTerms[i].Flags, count - 1);
			}
			mLanguages.RemoveAt(languageIndex);
		}

		public List<string> GetLanguages(bool OLICBMFOJLB = true)
		{
			List<string> list = new List<string>();
			int i = 0;
			for (int count = mLanguages.Count; i < count; i++)
			{
				if (!OLICBMFOJLB || mLanguages[i].FCIBLDEJAPL())
				{
					list.Add(mLanguages[i].Name);
				}
			}
			return list;
		}

		public List<string> GetLanguagesCode(bool EEINIAFCKHG = true, bool OLICBMFOJLB = true)
		{
			List<string> list = new List<string>();
			int i = 0;
			for (int count = mLanguages.Count; i < count; i++)
			{
				if (!OLICBMFOJLB || mLanguages[i].FCIBLDEJAPL())
				{
					string text = mLanguages[i].Code;
					if (!EEINIAFCKHG && text != null && text.Length > 2)
					{
						text = text.Substring(0, 2);
					}
					if (!string.IsNullOrEmpty(text) && !list.Contains(text))
					{
						list.Add(text);
					}
				}
			}
			return list;
		}

		public bool IsLanguageEnabled(string OEMDOLLFPDF)
		{
			int languageIndex = GetLanguageIndex(OEMDOLLFPDF, false);
			return languageIndex >= 0 && mLanguages[languageIndex].FCIBLDEJAPL();
		}

		public void LoadLanguage(int IMJJGIJBDCJ, bool CHADHAHFIBK)
		{
			if (!ODIHEPBMAPE.MIGINPHAHND())
			{
				return;
			}
			int count = mTerms.Count;
			int count2 = mLanguages.Count;
			bool flag = TermData.HCCKKBNFJOI();
			if (CHADHAHFIBK)
			{
				for (int i = 0; i < count2; i++)
				{
					if (i != IMJJGIJBDCJ && mLanguages[i].FCMBECPCFML() && mLanguages[i].MAEGGNBEFJA())
					{
						mLanguages[i].DHCAIAJNAED(false);
						for (int j = 0; j < count; j++)
						{
							mTerms[j].Languages[i] = (mTerms[j].Languages_Touch[i] = null);
						}
					}
				}
			}
			if (mLanguages[IMJJGIJBDCJ].FCMBECPCFML())
			{
				return;
			}
			string path = EEDHGLOLNLA();
			TextAsset textAsset = Resources.Load<TextAsset>(path);
			if (textAsset == null)
			{
				return;
			}
			string[] separator = new string[1] { "[$i2$]" };
			string[] array = textAsset.text.Split(separator, StringSplitOptions.None);
			for (int k = 0; k < array.Length; k += 2)
			{
				string key = array[k];
				string text = array[k + 1];
				TermData value;
				if (mDictionary.TryGetValue(key, out value))
				{
					string[] array2 = ((!flag) ? value.Languages : value.Languages_Touch);
					array2[IMJJGIJBDCJ] = text;
				}
			}
			mLanguages[IMJJGIJBDCJ].DHCAIAJNAED(true);
		}

		public string GetTranslation(string PPJJIIFOONJ)
		{
			string OCLDJACNGED;
			if (TryGetTranslation(PPJJIIFOONJ, out OCLDJACNGED))
			{
				return OCLDJACNGED;
			}
			return string.Empty;
		}

		public bool TryGetTranslation(string PPJJIIFOONJ, out string OCLDJACNGED, string IAGJJJPOFDA = null)
		{
			int languageIndex = GetLanguageIndex((IAGJJJPOFDA != null) ? IAGJJJPOFDA : PNAJOCHGJFO.LOEHJECLFHL, true, false);
			if (languageIndex >= 0)
			{
				TermData termData = GetTermData(PPJJIIFOONJ);
				if (termData != null)
				{
					OCLDJACNGED = termData.NOGNJJIFAIN(languageIndex);
					if (OCLDJACNGED == "---")
					{
						OCLDJACNGED = string.Empty;
						return true;
					}
					if (!string.IsNullOrEmpty(OCLDJACNGED))
					{
						return true;
					}
					OCLDJACNGED = null;
				}
				if (OnMissingTranslation == HNKACGNPDNP.ShowWarning)
				{
					OCLDJACNGED = string.Format("<!-Missing Translation [{0}]-!>", PPJJIIFOONJ);
					return false;
				}
				if (OnMissingTranslation == HNKACGNPDNP.Fallback && termData != null)
				{
					for (int i = 0; i < mLanguages.Count; i++)
					{
						if (i != languageIndex && mLanguages[i].FCIBLDEJAPL())
						{
							OCLDJACNGED = termData.NOGNJJIFAIN(i);
							if (!string.IsNullOrEmpty(OCLDJACNGED))
							{
								return true;
							}
						}
					}
				}
			}
			OCLDJACNGED = null;
			return false;
		}

		public TermData AddTerm(string PPJJIIFOONJ)
		{
			return AddTerm(PPJJIIFOONJ, LPNCMDLKPHE.Text);
		}

		public TermData GetTermData(string PPJJIIFOONJ, bool OLMPHEAONHA = false)
		{
			if (string.IsNullOrEmpty(PPJJIIFOONJ))
			{
				return null;
			}
			if (mDictionary.Count == 0)
			{
				UpdateDictionary();
			}
			TermData value;
			if (mDictionary.TryGetValue(PPJJIIFOONJ, out value))
			{
				return value;
			}
			TermData termData = null;
			if (OLMPHEAONHA)
			{
				string keyFromFullTerm = GetKeyFromFullTerm(PPJJIIFOONJ);
				foreach (KeyValuePair<string, TermData> item in mDictionary)
				{
					if (item.Value.EBNINFBJGAI(keyFromFullTerm, true))
					{
						if (termData != null)
						{
							return null;
						}
						termData = item.Value;
					}
				}
			}
			return termData;
		}

		public bool ContainsTerm(string PPJJIIFOONJ)
		{
			return GetTermData(PPJJIIFOONJ) != null;
		}

		public List<string> GetTermsList(string LGIJCCHPGKD = null)
		{
			if (mDictionary.Count != mTerms.Count)
			{
				UpdateDictionary();
			}
			if (string.IsNullOrEmpty(LGIJCCHPGKD))
			{
				return new List<string>(mDictionary.Keys);
			}
			List<string> list = new List<string>();
			for (int i = 0; i < mTerms.Count; i++)
			{
				TermData termData = mTerms[i];
				if (GetCategoryFromFullTerm(termData.Term) == LGIJCCHPGKD)
				{
					list.Add(termData.Term);
				}
			}
			return list;
		}

		public TermData AddTerm(string CBMFDBLBEBA, LPNCMDLKPHE EBKEKNIEJGD, bool GLPCPOJCGIN = true)
		{
			ValidateFullTerm(ref CBMFDBLBEBA);
			CBMFDBLBEBA = CBMFDBLBEBA.Trim();
			if (mLanguages.Count == 0)
			{
				AddLanguage("English", "en");
			}
			TermData termData = GetTermData(CBMFDBLBEBA);
			if (termData == null)
			{
				termData = new TermData();
				termData.Term = CBMFDBLBEBA;
				termData.TermType = EBKEKNIEJGD;
				termData.Languages = new string[mLanguages.Count];
				termData.Languages_Touch = new string[mLanguages.Count];
				termData.Flags = new byte[mLanguages.Count];
				mTerms.Add(termData);
				mDictionary.Add(CBMFDBLBEBA, termData);
			}
			return termData;
		}

		public void RemoveTerm(string PPJJIIFOONJ)
		{
			int i = 0;
			for (int count = mTerms.Count; i < count; i++)
			{
				if (mTerms[i].Term == PPJJIIFOONJ)
				{
					mTerms.RemoveAt(i);
					mDictionary.Remove(PPJJIIFOONJ);
					break;
				}
			}
		}

		public static void ValidateFullTerm(ref string ONHHAFBOPFG)
		{
			ONHHAFBOPFG = ONHHAFBOPFG.Replace('\\', '/');
			ONHHAFBOPFG = ONHHAFBOPFG.Trim();
			if (ONHHAFBOPFG.StartsWith(EmptyCategory, StringComparison.Ordinal) && ONHHAFBOPFG.Length > EmptyCategory.Length && ONHHAFBOPFG[EmptyCategory.Length] == '/')
			{
				ONHHAFBOPFG = ONHHAFBOPFG.Substring(EmptyCategory.Length + 1);
			}
			ONHHAFBOPFG = ODIHEPBMAPE.HEIIAPJHGOF(ONHHAFBOPFG, true);
		}

		public bool IsEqualTo(LanguageSource ILLMAGFDLPE)
		{
			if (ILLMAGFDLPE.mLanguages.Count != mLanguages.Count)
			{
				return false;
			}
			int i = 0;
			for (int count = mLanguages.Count; i < count; i++)
			{
				if (ILLMAGFDLPE.GetLanguageIndex(mLanguages[i].Name) < 0)
				{
					return false;
				}
			}
			if (ILLMAGFDLPE.mTerms.Count != mTerms.Count)
			{
				return false;
			}
			for (int j = 0; j < mTerms.Count; j++)
			{
				if (ILLMAGFDLPE.GetTermData(mTerms[j].Term) == null)
				{
					return false;
				}
			}
			return true;
		}

		internal bool OJAJFBODLJN()
		{
			int i = 0;
			for (int count = PNAJOCHGJFO.ODEOFDCJHNK.Count; i < count; i++)
			{
				LanguageSource languageSource = PNAJOCHGJFO.ODEOFDCJHNK[i];
				if (languageSource != null && languageSource.IsEqualTo(this) && languageSource != this)
				{
					return true;
				}
			}
			return false;
		}

		public void ClearAllData()
		{
			mTerms.Clear();
			mLanguages.Clear();
			mDictionary.Clear();
		}

		public UnityEngine.Object FindAsset(string PNGPLGHKFDI)
		{
			if (Assets != null)
			{
				if (mAssetDictionary == null || mAssetDictionary.Count != Assets.Count)
				{
					UpdateAssetDictionary();
				}
				UnityEngine.Object value;
				if (mAssetDictionary.TryGetValue(PNGPLGHKFDI, out value))
				{
					return value;
				}
			}
			return null;
		}

		public bool HasAsset(UnityEngine.Object JNPDINFDEJE)
		{
			return Assets.Contains(JNPDINFDEJE);
		}

		public void AddAsset(UnityEngine.Object JNPDINFDEJE)
		{
			if (!Assets.Contains(JNPDINFDEJE))
			{
				Assets.Add(JNPDINFDEJE);
				UpdateAssetDictionary();
			}
		}

		[CompilerGenerated]
		private static bool BIJMNAPJGGP(UnityEngine.Object AMFCENFNAJJ)
		{
			return AMFCENFNAJJ == null;
		}

		[CompilerGenerated]
		private static string LIFOAGIHDPL(UnityEngine.Object AACCPLMFDIE)
		{
			return AACCPLMFDIE.name;
		}
	}
}
