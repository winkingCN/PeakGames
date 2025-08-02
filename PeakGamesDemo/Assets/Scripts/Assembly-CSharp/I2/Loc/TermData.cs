using System;
using UnityEngine;

namespace I2.Loc
{
	[Serializable]
	public class TermData
	{
		public string Term = string.Empty;

		public LPNCMDLKPHE TermType;

		public string Description = string.Empty;

		public string[] Languages = new string[0];

		public string[] Languages_Touch = new string[0];

		public byte[] Flags = new byte[0];

		public string NOGNJJIFAIN(int MMLIOLEILLO, ABJAJGBBEIJ MOPCLEEGDFB = ABJAJGBBEIJ.Any)
		{
			string text = ((!HCCKKBNFJOI()) ? (string.IsNullOrEmpty(Languages[MMLIOLEILLO]) ? Languages_Touch[MMLIOLEILLO] : Languages[MMLIOLEILLO]) : (string.IsNullOrEmpty(Languages_Touch[MMLIOLEILLO]) ? Languages[MMLIOLEILLO] : Languages_Touch[MMLIOLEILLO]));
			if (text != null)
			{
				text = text.Replace("[i2nt]", string.Empty).Replace("[/i2nt]", string.Empty);
			}
			return text;
		}

		public bool GCNDDNJPAMP(int MMLIOLEILLO, bool NHJOEBKKFKH)
		{
			if (NHJOEBKKFKH)
			{
				return (Flags[MMLIOLEILLO] & 2) > 0;
			}
			return (Flags[MMLIOLEILLO] & 1) > 0;
		}

		public bool IACDIGLMGCO()
		{
			int i = 0;
			for (int num = Languages_Touch.Length; i < num; i++)
			{
				if (!string.IsNullOrEmpty(Languages_Touch[i]) && !string.IsNullOrEmpty(Languages[i]) && Languages_Touch[i] != Languages[i])
				{
					return true;
				}
			}
			return false;
		}

		public void PIBLOPJEGEL()
		{
			int num = Mathf.Max(Languages.Length, Mathf.Max(Languages_Touch.Length, Flags.Length));
			if (Languages.Length != num)
			{
				Array.Resize(ref Languages, num);
			}
			if (Languages_Touch.Length != num)
			{
				Array.Resize(ref Languages_Touch, num);
			}
			if (Flags.Length != num)
			{
				Array.Resize(ref Flags, num);
			}
		}

		public static bool HCCKKBNFJOI()
		{
			return true;
		}

		public bool EBNINFBJGAI(string IOCMOCCFALN, bool OLMPHEAONHA)
		{
			if (!OLMPHEAONHA)
			{
				return IOCMOCCFALN == Term;
			}
			return IOCMOCCFALN == LanguageSource.GetKeyFromFullTerm(Term);
		}
	}
}
