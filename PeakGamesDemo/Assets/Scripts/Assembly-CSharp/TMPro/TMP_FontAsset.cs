using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	public class TMP_FontAsset : TMP_Asset
	{
		public enum ACAOGKIIDPG
		{
			None = 0,
			SDF = 1,
			Bitmap = 2
		}

		private static TMP_FontAsset s_defaultFontAsset;

		public ACAOGKIIDPG fontAssetType;

		[SerializeField]
		private FaceInfo m_fontInfo;

		[SerializeField]
		public Texture2D atlas;

		[SerializeField]
		private List<TMP_Glyph> m_glyphInfoList;

		private Dictionary<int, TMP_Glyph> m_characterDictionary;

		private Dictionary<int, KerningPair> m_kerningDictionary;

		[SerializeField]
		private KerningTable m_kerningInfo;

		[SerializeField]
		private KerningPair m_kerningPair;

		[SerializeField]
		public List<TMP_FontAsset> fallbackFontAssets;

		[SerializeField]
		public FontCreationSetting fontCreationSettings;

		[SerializeField]
		public TMP_FontWeights[] fontWeights = new TMP_FontWeights[10];

		private int[] m_characterSet;

		public float normalStyle;

		public float normalSpacingOffset;

		public float boldStyle = 0.75f;

		public float boldSpacing = 7f;

		public byte italicStyle = 35;

		public byte tabSize = 10;

		private byte m_oldTabSize;

		public static TMP_FontAsset defaultFontAsset
		{
			get
			{
				if (s_defaultFontAsset == null)
				{
					s_defaultFontAsset = Resources.Load<TMP_FontAsset>("Fonts & Materials/LiberationSans SDF");
				}
				return s_defaultFontAsset;
			}
		}

		public FaceInfo fontInfo
		{
			get
			{
				return m_fontInfo;
			}
		}

		public Dictionary<int, TMP_Glyph> characterDictionary
		{
			get
			{
				if (m_characterDictionary == null)
				{
					FNACKHNCKJJ();
				}
				return m_characterDictionary;
			}
		}

		public Dictionary<int, KerningPair> kerningDictionary
		{
			get
			{
				return m_kerningDictionary;
			}
		}

		public KerningTable kerningInfo
		{
			get
			{
				return m_kerningInfo;
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void AJEBAPNLEGN(FaceInfo JPGHKADKMEP)
		{
			m_fontInfo = JPGHKADKMEP;
		}

		public void DKCNKMDJOAO(TMP_Glyph[] EFCLMLEAGFK)
		{
			m_glyphInfoList = new List<TMP_Glyph>();
			int num = EFCLMLEAGFK.Length;
			m_fontInfo.CharacterCount = num;
			m_characterSet = new int[num];
			for (int i = 0; i < num; i++)
			{
				TMP_Glyph tMP_Glyph = new TMP_Glyph();
				tMP_Glyph.id = EFCLMLEAGFK[i].id;
				tMP_Glyph.x = EFCLMLEAGFK[i].x;
				tMP_Glyph.y = EFCLMLEAGFK[i].y;
				tMP_Glyph.width = EFCLMLEAGFK[i].width;
				tMP_Glyph.height = EFCLMLEAGFK[i].height;
				tMP_Glyph.xOffset = EFCLMLEAGFK[i].xOffset;
				tMP_Glyph.yOffset = EFCLMLEAGFK[i].yOffset;
				tMP_Glyph.xAdvance = EFCLMLEAGFK[i].xAdvance;
				tMP_Glyph.scale = 1f;
				m_glyphInfoList.Add(tMP_Glyph);
				m_characterSet[i] = tMP_Glyph.id;
			}
			m_glyphInfoList = m_glyphInfoList.OrderBy((TMP_Glyph IBBBMACIBGK) => IBBBMACIBGK.id).ToList();
		}

		public void MKCMMNHDBNJ(KerningTable CKFIFFPAACF)
		{
			m_kerningInfo = CKFIFFPAACF;
		}

		public void FNACKHNCKJJ()
		{
			if (m_fontInfo == null)
			{
				return;
			}
			m_characterDictionary = new Dictionary<int, TMP_Glyph>();
			for (int i = 0; i < m_glyphInfoList.Count; i++)
			{
				TMP_Glyph tMP_Glyph = m_glyphInfoList[i];
				if (!m_characterDictionary.ContainsKey(tMP_Glyph.id))
				{
					m_characterDictionary.Add(tMP_Glyph.id, tMP_Glyph);
				}
				if (tMP_Glyph.scale == 0f)
				{
					tMP_Glyph.scale = 1f;
				}
			}
			TMP_Glyph tMP_Glyph2 = new TMP_Glyph();
			if (m_characterDictionary.ContainsKey(32))
			{
				m_characterDictionary[32].width = m_characterDictionary[32].xAdvance;
				m_characterDictionary[32].height = m_fontInfo.Ascender - m_fontInfo.Descender;
				m_characterDictionary[32].yOffset = m_fontInfo.Ascender;
				m_characterDictionary[32].scale = 1f;
			}
			else
			{
				tMP_Glyph2 = new TMP_Glyph();
				tMP_Glyph2.id = 32;
				tMP_Glyph2.x = 0f;
				tMP_Glyph2.y = 0f;
				tMP_Glyph2.width = m_fontInfo.Ascender / 5f;
				tMP_Glyph2.height = m_fontInfo.Ascender - m_fontInfo.Descender;
				tMP_Glyph2.xOffset = 0f;
				tMP_Glyph2.yOffset = m_fontInfo.Ascender;
				tMP_Glyph2.xAdvance = m_fontInfo.PointSize / 4f;
				tMP_Glyph2.scale = 1f;
				m_characterDictionary.Add(32, tMP_Glyph2);
			}
			if (!m_characterDictionary.ContainsKey(160))
			{
				tMP_Glyph2 = TMP_Glyph.IKBFGGABMKP(m_characterDictionary[32]);
				m_characterDictionary.Add(160, tMP_Glyph2);
			}
			if (!m_characterDictionary.ContainsKey(8203))
			{
				tMP_Glyph2 = TMP_Glyph.IKBFGGABMKP(m_characterDictionary[32]);
				tMP_Glyph2.width = 0f;
				tMP_Glyph2.xAdvance = 0f;
				m_characterDictionary.Add(8203, tMP_Glyph2);
			}
			if (!m_characterDictionary.ContainsKey(8288))
			{
				tMP_Glyph2 = TMP_Glyph.IKBFGGABMKP(m_characterDictionary[32]);
				tMP_Glyph2.width = 0f;
				tMP_Glyph2.xAdvance = 0f;
				m_characterDictionary.Add(8288, tMP_Glyph2);
			}
			if (!m_characterDictionary.ContainsKey(10))
			{
				tMP_Glyph2 = new TMP_Glyph();
				tMP_Glyph2.id = 10;
				tMP_Glyph2.x = 0f;
				tMP_Glyph2.y = 0f;
				tMP_Glyph2.width = 10f;
				tMP_Glyph2.height = m_characterDictionary[32].height;
				tMP_Glyph2.xOffset = 0f;
				tMP_Glyph2.yOffset = m_characterDictionary[32].yOffset;
				tMP_Glyph2.xAdvance = 0f;
				tMP_Glyph2.scale = 1f;
				m_characterDictionary.Add(10, tMP_Glyph2);
				if (!m_characterDictionary.ContainsKey(13))
				{
					m_characterDictionary.Add(13, tMP_Glyph2);
				}
			}
			if (!m_characterDictionary.ContainsKey(9))
			{
				tMP_Glyph2 = new TMP_Glyph();
				tMP_Glyph2.id = 9;
				tMP_Glyph2.x = m_characterDictionary[32].x;
				tMP_Glyph2.y = m_characterDictionary[32].y;
				tMP_Glyph2.width = m_characterDictionary[32].width * (float)(int)tabSize + (m_characterDictionary[32].xAdvance - m_characterDictionary[32].width) * (float)(tabSize - 1);
				tMP_Glyph2.height = m_characterDictionary[32].height;
				tMP_Glyph2.xOffset = m_characterDictionary[32].xOffset;
				tMP_Glyph2.yOffset = m_characterDictionary[32].yOffset;
				tMP_Glyph2.xAdvance = m_characterDictionary[32].xAdvance * (float)(int)tabSize;
				tMP_Glyph2.scale = 1f;
				m_characterDictionary.Add(9, tMP_Glyph2);
			}
			m_fontInfo.TabWidth = m_characterDictionary[9].xAdvance;
			if (m_fontInfo.CapHeight == 0f && m_characterDictionary.ContainsKey(72))
			{
				m_fontInfo.CapHeight = m_characterDictionary[72].yOffset;
			}
			if (m_fontInfo.Scale == 0f)
			{
				m_fontInfo.Scale = 1f;
			}
			if (m_fontInfo.strikethrough == 0f)
			{
				m_fontInfo.strikethrough = m_fontInfo.CapHeight / 2.5f;
			}
			if (m_fontInfo.Padding == 0f && material.HasProperty(MOHPNOBPBBL.APPGFNEOBOF))
			{
				m_fontInfo.Padding = material.GetFloat(MOHPNOBPBBL.APPGFNEOBOF) - 1f;
			}
			m_kerningDictionary = new Dictionary<int, KerningPair>();
			List<KerningPair> kerningPairs = m_kerningInfo.kerningPairs;
			for (int j = 0; j < kerningPairs.Count; j++)
			{
				KerningPair kerningPair = kerningPairs[j];
				OIMKDKKJDIK oIMKDKKJDIK = new OIMKDKKJDIK(kerningPair.AscII_Left, kerningPair.AscII_Right);
				if (!m_kerningDictionary.ContainsKey(oIMKDKKJDIK.IKNCPEPOKGJ))
				{
					m_kerningDictionary.Add(oIMKDKKJDIK.IKNCPEPOKGJ, kerningPair);
				}
				else if (!TMP_Settings.warningsDisabled)
				{
					Debug.LogWarning("Kerning Key for [" + oIMKDKKJDIK.MNBEJMDMOOP + "] and [" + oIMKDKKJDIK.JGHOCLKHMDA + "] already exists.");
				}
			}
			hashCode = LBOEJMDHOEP.OLDMALBCAKF(base.name);
			materialHashCode = LBOEJMDHOEP.OLDMALBCAKF(material.name);
		}

		public void OENPHFOEHDN()
		{
			if (m_glyphInfoList != null && m_glyphInfoList.Count != 0)
			{
				m_glyphInfoList = m_glyphInfoList.OrderBy((TMP_Glyph EJCNAJOHBFI) => EJCNAJOHBFI.id).ToList();
			}
		}

		public bool OBJKDIFMJEO(int AONJCHFEHOM)
		{
			if (m_characterDictionary == null)
			{
				return false;
			}
			if (m_characterDictionary.ContainsKey(AONJCHFEHOM))
			{
				return true;
			}
			return false;
		}

		public bool OBJKDIFMJEO(char AONJCHFEHOM)
		{
			if (m_characterDictionary == null)
			{
				return false;
			}
			if (m_characterDictionary.ContainsKey(AONJCHFEHOM))
			{
				return true;
			}
			return false;
		}

		public bool OBJKDIFMJEO(char AONJCHFEHOM, bool HEPDKEFPPLK)
		{
			if (m_characterDictionary == null)
			{
				return false;
			}
			if (m_characterDictionary.ContainsKey(AONJCHFEHOM))
			{
				return true;
			}
			if (HEPDKEFPPLK)
			{
				if (fallbackFontAssets != null && fallbackFontAssets.Count > 0)
				{
					for (int i = 0; i < fallbackFontAssets.Count && fallbackFontAssets[i] != null; i++)
					{
						if (fallbackFontAssets[i].characterDictionary != null && fallbackFontAssets[i].characterDictionary.ContainsKey(AONJCHFEHOM))
						{
							return true;
						}
					}
				}
				if (TMP_Settings.fallbackFontAssets != null && TMP_Settings.fallbackFontAssets.Count > 0)
				{
					for (int j = 0; j < TMP_Settings.fallbackFontAssets.Count && TMP_Settings.fallbackFontAssets[j] != null; j++)
					{
						if (TMP_Settings.fallbackFontAssets[j].characterDictionary != null && TMP_Settings.fallbackFontAssets[j].characterDictionary.ContainsKey(AONJCHFEHOM))
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		public bool GDEHGBGNCIE(string FCJBBPHFNPJ, out List<char> HCPEFFGAIFO)
		{
			if (m_characterDictionary == null)
			{
				HCPEFFGAIFO = null;
				return false;
			}
			HCPEFFGAIFO = new List<char>();
			for (int i = 0; i < FCJBBPHFNPJ.Length; i++)
			{
				if (!m_characterDictionary.ContainsKey(FCJBBPHFNPJ[i]))
				{
					HCPEFFGAIFO.Add(FCJBBPHFNPJ[i]);
				}
			}
			if (HCPEFFGAIFO.Count == 0)
			{
				return true;
			}
			return false;
		}

		public bool GDEHGBGNCIE(string FCJBBPHFNPJ)
		{
			if (m_characterDictionary == null)
			{
				return false;
			}
			for (int i = 0; i < FCJBBPHFNPJ.Length; i++)
			{
				if (!m_characterDictionary.ContainsKey(FCJBBPHFNPJ[i]))
				{
					return false;
				}
			}
			return true;
		}

		public static string NIJDCJFEJDC(TMP_FontAsset PIJNMJOHBIE)
		{
			string text = string.Empty;
			for (int i = 0; i < PIJNMJOHBIE.m_glyphInfoList.Count; i++)
			{
				text += (char)PIJNMJOHBIE.m_glyphInfoList[i].id;
			}
			return text;
		}

		public static int[] APOLFCIJMMB(TMP_FontAsset PIJNMJOHBIE)
		{
			int[] array = new int[PIJNMJOHBIE.m_glyphInfoList.Count];
			for (int i = 0; i < PIJNMJOHBIE.m_glyphInfoList.Count; i++)
			{
				array[i] = PIJNMJOHBIE.m_glyphInfoList[i].id;
			}
			return array;
		}

		[CompilerGenerated]
		private static int AOFAJBHABEB(TMP_Glyph IBBBMACIBGK)
		{
			return IBBBMACIBGK.id;
		}

		[CompilerGenerated]
		private static int EBMIADCDLIO(TMP_Glyph EJCNAJOHBFI)
		{
			return EJCNAJOHBFI.id;
		}
	}
}
