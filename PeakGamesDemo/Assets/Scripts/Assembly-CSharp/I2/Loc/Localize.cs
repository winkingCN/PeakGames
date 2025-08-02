using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

namespace I2.Loc
{
	[AddComponentMenu("I2/Localization/I2 Localize")]
	public class Localize : MonoBehaviour
	{
		public enum CJFDBOJHFLC
		{
			DontModify = 0,
			ToUpper = 1,
			ToLower = 2,
			ToUpperFirst = 3,
			ToTitle = 4
		}

		public string mTerm = string.Empty;

		public string mTermSecondary = string.Empty;

		[NonSerialized]
		public string FinalTerm;

		[NonSerialized]
		public string FinalSecondaryTerm;

		public CJFDBOJHFLC PrimaryTermModifier;

		public CJFDBOJHFLC SecondaryTermModifier;

		public string TermPrefix;

		public string TermSuffix;

		public bool LocalizeOnAwake = true;

		private string DOPKABDPDCG;

		public UnityEngine.Object mTarget;

		public bool IgnoreRTL;

		public int MaxCharactersInRTL;

		public bool IgnoreNumbersInRTL = true;

		public bool CorrectAlignmentForRTL = true;

		public bool AddSpacesToJoinedLanguages;

		public List<UnityEngine.Object> TranslatedObjects = new List<UnityEngine.Object>();

		[NonSerialized]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary = new Dictionary<string, UnityEngine.Object>(StringComparer.Ordinal);

		public EventCallback LocalizeCallBack = new EventCallback();

		public static string MainTranslation;

		public static string SecondaryTranslation;

		public static string CallBackTerm;

		public static string CallBackSecondaryTerm;

		public static Localize CurrentLocalizeComponent;

		public bool AlwaysForceLocalize;

		public bool mGUI_ShowReferences;

		public bool mGUI_ShowTems = true;

		public bool mGUI_ShowCallback;

		[NonSerialized]
		public ABOOAELLAEJ mLocalizeTarget;

		[CompilerGenerated]
		private static Predicate<UnityEngine.Object> EBCOMJBLIPP;

		[CompilerGenerated]
		private static Func<UnityEngine.Object, string> DNBOPLHGMHA;

		public string ONHHAFBOPFG
		{
			get
			{
				return mTerm;
			}
			set
			{
				SetTerm(value);
			}
		}

		public string GPCCOBJKJCJ
		{
			get
			{
				return mTermSecondary;
			}
			set
			{
				SetTerm(null, value);
			}
		}

		private void Awake()
		{
			UpdateAssetDictionary();
			FindTarget();
			if (LocalizeOnAwake)
			{
				OnLocalize();
			}
		}

		private void OnEnable()
		{
			OnLocalize();
		}

		public void OnLocalize(bool LLLFMBNNMBG = false)
		{
			if ((!LLLFMBNNMBG && (!base.enabled || base.gameObject == null || !base.gameObject.activeInHierarchy)) || string.IsNullOrEmpty(PNAJOCHGJFO.LOEHJECLFHL) || (!AlwaysForceLocalize && !LLLFMBNNMBG && !LocalizeCallBack.KLONFPGKCOH() && DOPKABDPDCG == PNAJOCHGJFO.LOEHJECLFHL))
			{
				return;
			}
			DOPKABDPDCG = PNAJOCHGJFO.LOEHJECLFHL;
			if (string.IsNullOrEmpty(FinalTerm) || string.IsNullOrEmpty(FinalSecondaryTerm))
			{
				GetFinalTerms(out FinalTerm, out FinalSecondaryTerm);
			}
			bool flag = ODIHEPBMAPE.MIGINPHAHND() && LocalizeCallBack.KLONFPGKCOH();
			if (!flag && string.IsNullOrEmpty(FinalTerm) && string.IsNullOrEmpty(FinalSecondaryTerm))
			{
				return;
			}
			CallBackTerm = FinalTerm;
			CallBackSecondaryTerm = FinalSecondaryTerm;
			MainTranslation = ((!string.IsNullOrEmpty(FinalTerm) && !(FinalTerm == "-")) ? PNAJOCHGJFO.NOGNJJIFAIN(FinalTerm, false) : null);
			SecondaryTranslation = ((!string.IsNullOrEmpty(FinalSecondaryTerm) && !(FinalSecondaryTerm == "-")) ? PNAJOCHGJFO.NOGNJJIFAIN(FinalSecondaryTerm, false) : null);
			if (!flag && string.IsNullOrEmpty(FinalTerm) && string.IsNullOrEmpty(SecondaryTranslation))
			{
				return;
			}
			CurrentLocalizeComponent = this;
			LocalizeCallBack.LAPGGGMFPFB(this);
			PNAJOCHGJFO.DNDINFAAJFL(ref MainTranslation, base.gameObject);
			if (!EHLPJHPCALN() && !FindTarget())
			{
				return;
			}
			bool flag2 = PNAJOCHGJFO.MNHBNGFDIPC && !IgnoreRTL;
			if (flag2)
			{
				if (mLocalizeTarget.EPEEEAJJCEM() && !string.IsNullOrEmpty(MainTranslation))
				{
					MainTranslation = PNAJOCHGJFO.IFCCJDKHIHP(MainTranslation, MaxCharactersInRTL, IgnoreNumbersInRTL);
				}
				if (mLocalizeTarget.ILELPLPENPA() && !string.IsNullOrEmpty(SecondaryTranslation))
				{
					SecondaryTranslation = PNAJOCHGJFO.IFCCJDKHIHP(SecondaryTranslation);
				}
			}
			if (PrimaryTermModifier != 0)
			{
				MainTranslation = MainTranslation ?? string.Empty;
			}
			switch (PrimaryTermModifier)
			{
			case CJFDBOJHFLC.ToUpper:
				MainTranslation = MainTranslation.ToUpper();
				break;
			case CJFDBOJHFLC.ToLower:
				MainTranslation = MainTranslation.ToLower();
				break;
			case CJFDBOJHFLC.ToUpperFirst:
				MainTranslation = KPFLIKDAOML.OIIKEIMEFMK(MainTranslation);
				break;
			case CJFDBOJHFLC.ToTitle:
				MainTranslation = KPFLIKDAOML.ODOANDALGCC(MainTranslation);
				break;
			}
			if (SecondaryTermModifier != 0)
			{
				SecondaryTranslation = SecondaryTranslation ?? string.Empty;
			}
			switch (SecondaryTermModifier)
			{
			case CJFDBOJHFLC.ToUpper:
				SecondaryTranslation = SecondaryTranslation.ToUpper();
				break;
			case CJFDBOJHFLC.ToLower:
				SecondaryTranslation = SecondaryTranslation.ToLower();
				break;
			case CJFDBOJHFLC.ToUpperFirst:
				SecondaryTranslation = KPFLIKDAOML.OIIKEIMEFMK(SecondaryTranslation);
				break;
			case CJFDBOJHFLC.ToTitle:
				SecondaryTranslation = KPFLIKDAOML.ODOANDALGCC(SecondaryTranslation);
				break;
			}
			if (!string.IsNullOrEmpty(TermPrefix))
			{
				MainTranslation = ((!flag2) ? (TermPrefix + MainTranslation) : (MainTranslation + TermPrefix));
			}
			if (!string.IsNullOrEmpty(TermSuffix))
			{
				MainTranslation = ((!flag2) ? (MainTranslation + TermSuffix) : (TermSuffix + MainTranslation));
			}
			if (AddSpacesToJoinedLanguages && PNAJOCHGJFO.GIJNKMIHMKE && !string.IsNullOrEmpty(MainTranslation))
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(MainTranslation[0]);
				int i = 1;
				for (int length = MainTranslation.Length; i < length; i++)
				{
					stringBuilder.Append(' ');
					stringBuilder.Append(MainTranslation[i]);
				}
				MainTranslation = stringBuilder.ToString();
			}
			mLocalizeTarget.FPJOJNKLJHL(this, MainTranslation, SecondaryTranslation);
			CurrentLocalizeComponent = null;
		}

		public bool FindTarget()
		{
			if (EHLPJHPCALN())
			{
				return true;
			}
			if (mLocalizeTarget == null || !mLocalizeTarget.LDJDFHAKJLC(this))
			{
				mLocalizeTarget = null;
				foreach (ABOOAELLAEJ item in PNAJOCHGJFO.MHJDEGPMHJN)
				{
					if (item.LDJDFHAKJLC(this))
					{
						mLocalizeTarget = item.IKBFGGABMKP(this);
						break;
					}
				}
			}
			return EHLPJHPCALN();
		}

		public void ReleaseTarget()
		{
			mTarget = null;
		}

		private bool EHLPJHPCALN()
		{
			return mLocalizeTarget != null && mLocalizeTarget.OBBBEAMBJAG(this);
		}

		public void GetFinalTerms(out string FDNJMNMHGEG, out string ENOPBIOGPCL)
		{
			FDNJMNMHGEG = string.Empty;
			ENOPBIOGPCL = string.Empty;
			if (EHLPJHPCALN() || FindTarget())
			{
				if (mTarget != null && (string.IsNullOrEmpty(mTerm) || string.IsNullOrEmpty(mTermSecondary)) && mLocalizeTarget != null)
				{
					mLocalizeTarget.HKKDHLOJLGN(this, mTerm, mTermSecondary, out FDNJMNMHGEG, out ENOPBIOGPCL);
					FDNJMNMHGEG = ODIHEPBMAPE.HEIIAPJHGOF(FDNJMNMHGEG);
				}
				if (!string.IsNullOrEmpty(mTerm))
				{
					FDNJMNMHGEG = mTerm;
				}
				if (!string.IsNullOrEmpty(mTermSecondary))
				{
					ENOPBIOGPCL = mTermSecondary;
				}
				if (FDNJMNMHGEG != null)
				{
					FDNJMNMHGEG = FDNJMNMHGEG.Trim();
				}
				if (ENOPBIOGPCL != null)
				{
					ENOPBIOGPCL = ENOPBIOGPCL.Trim();
				}
			}
		}

		public string GetMainTargetsText()
		{
			string FDNJMNMHGEG = null;
			string ENOPBIOGPCL = null;
			if (mLocalizeTarget != null)
			{
				mLocalizeTarget.HKKDHLOJLGN(this, null, null, out FDNJMNMHGEG, out ENOPBIOGPCL);
			}
			return (!string.IsNullOrEmpty(FDNJMNMHGEG)) ? FDNJMNMHGEG : mTerm;
		}

		public void SetFinalTerms(string AMMAIADJFIM, string HDNBPGDPDAJ, out string FDNJMNMHGEG, out string ENOPBIOGPCL, bool HEIIAPJHGOF)
		{
			FDNJMNMHGEG = ((!HEIIAPJHGOF) ? AMMAIADJFIM : ODIHEPBMAPE.HEIIAPJHGOF(AMMAIADJFIM));
			ENOPBIOGPCL = HDNBPGDPDAJ;
		}

		public void SetTerm(string BLIFOMMLFDF)
		{
			if (!string.IsNullOrEmpty(BLIFOMMLFDF))
			{
				FinalTerm = (mTerm = BLIFOMMLFDF);
			}
			OnLocalize(true);
		}

		public void SetTerm(string BLIFOMMLFDF, string HABIHGFLIBJ)
		{
			if (!string.IsNullOrEmpty(BLIFOMMLFDF))
			{
				FinalTerm = (mTerm = BLIFOMMLFDF);
			}
			FinalSecondaryTerm = (mTermSecondary = HABIHGFLIBJ);
			OnLocalize(true);
		}

		internal T FDCNEPAOCIA<T>(ref string JJMAEFKBEIL, ref string NAIBKJDAOHL) where T : UnityEngine.Object
		{
			string EDDNOJDPMCF;
			string HABIHGFLIBJ;
			PDEDHPAJDGM(JJMAEFKBEIL, out EDDNOJDPMCF, out HABIHGFLIBJ);
			T val = (T)null;
			if (!string.IsNullOrEmpty(HABIHGFLIBJ))
			{
				val = NFMFKPLPLLH<T>(HABIHGFLIBJ);
				if (val != null)
				{
					JJMAEFKBEIL = EDDNOJDPMCF;
					NAIBKJDAOHL = HABIHGFLIBJ;
				}
			}
			if (val == null)
			{
				val = NFMFKPLPLLH<T>(NAIBKJDAOHL);
			}
			return val;
		}

		public void UpdateAssetDictionary()
		{
			TranslatedObjects.RemoveAll((UnityEngine.Object AMFCENFNAJJ) => AMFCENFNAJJ == null);
			mAssetDictionary = TranslatedObjects.ToDictionary((UnityEngine.Object AACCPLMFDIE) => AACCPLMFDIE.name);
		}

		internal T NFMFKPLPLLH<T>(string OCLDJACNGED) where T : UnityEngine.Object
		{
			if (string.IsNullOrEmpty(OCLDJACNGED))
			{
				return (T)null;
			}
			T val = JLNLPMACFOO<T>(OCLDJACNGED);
			if (val == null)
			{
				val = JLNLPMACFOO<T>(OCLDJACNGED);
			}
			return val;
		}

		private T JLNLPMACFOO<T>(string OCLDJACNGED) where T : UnityEngine.Object
		{
			return FindTranslatedObject<T>(OCLDJACNGED);
		}

		private void PDEDHPAJDGM(string JFPDNFFBLFI, out string EDDNOJDPMCF, out string HABIHGFLIBJ)
		{
			if (!string.IsNullOrEmpty(JFPDNFFBLFI) && JFPDNFFBLFI.Length > 1 && JFPDNFFBLFI[0] == '[')
			{
				int num = JFPDNFFBLFI.IndexOf(']');
				if (num > 0)
				{
					HABIHGFLIBJ = JFPDNFFBLFI.Substring(1, num - 1);
					EDDNOJDPMCF = JFPDNFFBLFI.Substring(num + 1);
					return;
				}
			}
			EDDNOJDPMCF = JFPDNFFBLFI;
			HABIHGFLIBJ = string.Empty;
		}

		public T FindTranslatedObject<T>(string EDDNOJDPMCF) where T : UnityEngine.Object
		{
			if (string.IsNullOrEmpty(EDDNOJDPMCF))
			{
				return (T)null;
			}
			if (mAssetDictionary == null || mAssetDictionary.Count != TranslatedObjects.Count)
			{
				UpdateAssetDictionary();
			}
			foreach (KeyValuePair<string, UnityEngine.Object> item in mAssetDictionary)
			{
				if (item.Value is T && EDDNOJDPMCF.EndsWith(item.Key, StringComparison.OrdinalIgnoreCase) && string.Compare(EDDNOJDPMCF, item.Key, StringComparison.OrdinalIgnoreCase) == 0)
				{
					return (T)item.Value;
				}
			}
			T val = PNAJOCHGJFO.PFGPGNNFFJN(EDDNOJDPMCF) as T;
			if ((bool)val)
			{
				return val;
			}
			return ResourceManager.MGLPOGMOMJM.GetAsset<T>(EDDNOJDPMCF);
		}

		public bool HasTranslatedObject(UnityEngine.Object JNPDINFDEJE)
		{
			if (TranslatedObjects.Contains(JNPDINFDEJE))
			{
				return true;
			}
			return ResourceManager.MGLPOGMOMJM.HasAsset(JNPDINFDEJE);
		}

		public void AddTranslatedObject(UnityEngine.Object JNPDINFDEJE)
		{
			TranslatedObjects.Add(JNPDINFDEJE);
			UpdateAssetDictionary();
		}

		public void SetGlobalLanguage(string OEMDOLLFPDF)
		{
			PNAJOCHGJFO.LOEHJECLFHL = OEMDOLLFPDF;
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
