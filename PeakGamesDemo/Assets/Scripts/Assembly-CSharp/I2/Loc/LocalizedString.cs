using System;
using System.Runtime.CompilerServices;

namespace I2.Loc
{
	[Serializable]
	public struct LocalizedString
	{
		public string mTerm;

		public bool mRTL_IgnoreArabicFix;

		public int mRTL_MaxLineLength;

		public bool mRTL_ConvertNumbers;

		public LocalizedString(LocalizedString GFPBBLPMOOL)
		{
			mTerm = GFPBBLPMOOL.mTerm;
			mRTL_IgnoreArabicFix = GFPBBLPMOOL.mRTL_IgnoreArabicFix;
			mRTL_MaxLineLength = GFPBBLPMOOL.mRTL_MaxLineLength;
			mRTL_ConvertNumbers = GFPBBLPMOOL.mRTL_ConvertNumbers;
		}

		[SpecialName]
		public static string AGIIAGNEIKI(LocalizedString IBBBMACIBGK)
		{
			return IBBBMACIBGK.ToString();
		}

		[SpecialName]
		public static LocalizedString AGIIAGNEIKI(string PPJJIIFOONJ)
		{
			LocalizedString result = default(LocalizedString);
			result.mTerm = PPJJIIFOONJ;
			return result;
		}

		public override string ToString()
		{
			string JFPDNFFBLFI = PNAJOCHGJFO.NOGNJJIFAIN(mTerm, !mRTL_IgnoreArabicFix, mRTL_MaxLineLength, !mRTL_ConvertNumbers, true);
			PNAJOCHGJFO.DNDINFAAJFL(ref JFPDNFFBLFI);
			return JFPDNFFBLFI;
		}
	}
}
