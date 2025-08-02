using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace TMPro
{
	public class TMP_Text : MaskableGraphic
	{
		protected enum MCAFEPOCEPL
		{
			Text = 0,
			SetText = 1,
			SetCharArray = 2,
			String = 3
		}

		[SerializeField]
		protected string m_text;

		[SerializeField]
		protected bool m_isRightToLeft;

		[SerializeField]
		protected TMP_FontAsset m_fontAsset;

		protected TMP_FontAsset AFEJPPDMPHE;

		protected bool NJFPOFBLHCF;

		[SerializeField]
		protected Material m_sharedMaterial;

		protected Material JBPPHIKOJPL;

		protected FMOBJPAGLEE[] NDPGMAPHNNA = new FMOBJPAGLEE[32];

		protected Dictionary<int, int> GJCBEOHAMEH = new Dictionary<int, int>();

		protected global::NEIBAJOHEEC<FMOBJPAGLEE> DBEFOGFNAME = new global::NEIBAJOHEEC<FMOBJPAGLEE>(new FMOBJPAGLEE[16]);

		protected int AIJEDOAJAPI;

		[SerializeField]
		protected Material[] m_fontSharedMaterials;

		[SerializeField]
		protected Material m_fontMaterial;

		[SerializeField]
		protected Material[] m_fontMaterials;

		protected bool BMPKBAOBLDH;

		[SerializeField]
		protected Color32 m_fontColor32 = Color.white;

		[SerializeField]
		protected Color m_fontColor = Color.white;

		protected static Color32 MCCKLLJFKGH = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);

		protected Color32 HEFLDLNICAK = MCCKLLJFKGH;

		protected Color32 DNDMCGFIBJM = MCCKLLJFKGH;

		protected Color32 EDCPEAJCPLG = MCCKLLJFKGH;

		[SerializeField]
		protected bool m_enableVertexGradient;

		[SerializeField]
		protected VertexGradient m_fontColorGradient = new VertexGradient(Color.white);

		[SerializeField]
		protected TMP_ColorGradient m_fontColorGradientPreset;

		[SerializeField]
		protected TMP_SpriteAsset m_spriteAsset;

		[SerializeField]
		protected bool m_tintAllSprites;

		protected bool GKGFOHJGDMD;

		protected Color32 IIHIHIELCKN;

		[SerializeField]
		protected bool m_overrideHtmlColors;

		[SerializeField]
		protected Color32 m_faceColor = Color.white;

		[SerializeField]
		protected Color32 m_outlineColor = Color.black;

		protected float FHKFOELPGPK;

		[SerializeField]
		protected float m_fontSize = 36f;

		protected float MPIGOGEKIPI;

		[SerializeField]
		protected float m_fontSizeBase = 36f;

		protected global::NEIBAJOHEEC<float> FJJAGAJLDJG = new global::NEIBAJOHEEC<float>(new float[16]);

		[SerializeField]
		protected int m_fontWeight = 400;

		protected int ENGCHNIHPBK;

		protected global::NEIBAJOHEEC<int> IOAEEGOLEHI = new global::NEIBAJOHEEC<int>(new int[16]);

		[SerializeField]
		protected bool m_enableAutoSizing;

		protected float KCNAALADKDH;

		protected float FOGJMAGABCF;

		[SerializeField]
		protected float m_fontSizeMin;

		[SerializeField]
		protected float m_fontSizeMax;

		[SerializeField]
		protected BCIEOOJOMDO m_fontStyle;

		protected BCIEOOJOMDO CCLHEBEBBGN;

		protected BAEINJLPJGN MKAJPJFKEPP;

		protected bool JLDKHEKHGKA;

		[FormerlySerializedAs("m_lineJustification")]
		[SerializeField]
		protected KNOECCJHIDP m_textAlignment = KNOECCJHIDP.TopLeft;

		protected KNOECCJHIDP FPDOALAOBLE;

		protected global::NEIBAJOHEEC<KNOECCJHIDP> IBLGHCLBFJG = new global::NEIBAJOHEEC<KNOECCJHIDP>(new KNOECCJHIDP[16]);

		protected Vector3[] ODKLKEBFOIE = new Vector3[4];

		[SerializeField]
		protected bool m_isAlignmentEnumConverted;

		[SerializeField]
		protected float m_characterSpacing;

		protected float OMGEAPDMJBN;

		protected float CADPBEPINNM;

		[SerializeField]
		protected float m_wordSpacing;

		[SerializeField]
		protected float m_lineSpacing;

		protected float FNABNBFMNME;

		protected float KODBBLNBFDO = -32767f;

		[SerializeField]
		protected float m_lineSpacingMax;

		[SerializeField]
		protected float m_paragraphSpacing;

		[SerializeField]
		protected float m_charWidthMaxAdj;

		protected float JDKKGHCOCJK;

		[SerializeField]
		protected bool m_enableWordWrapping;

		protected bool CHPJNOEDAFE;

		protected bool PIABLFACDIO;

		protected bool JEKJCMDPILC;

		[SerializeField]
		protected float m_wordWrappingRatios = 0.4f;

		[SerializeField]
		protected OLMBEAODAPL m_overflowMode;

		[SerializeField]
		protected int m_firstOverflowCharacterIndex = -1;

		[SerializeField]
		protected TMP_Text m_linkedTextComponent;

		[SerializeField]
		protected bool m_isLinkedTextComponent;

		protected bool OHEPFDPOBOF;

		[SerializeField]
		protected bool m_enableKerning;

		[SerializeField]
		protected bool m_enableExtraPadding;

		[SerializeField]
		protected bool checkPaddingRequired;

		[SerializeField]
		protected bool m_isRichText = true;

		[SerializeField]
		protected bool m_parseCtrlCharacters = true;

		protected bool HCFCMKLKOIM;

		[SerializeField]
		protected bool m_isOrthographic;

		[SerializeField]
		protected bool m_isCullingEnabled;

		[SerializeField]
		protected bool m_ignoreRectMaskCulling;

		[SerializeField]
		protected bool m_ignoreCulling = true;

		[SerializeField]
		protected NBJIALGHGKG m_horizontalMapping;

		[SerializeField]
		protected NBJIALGHGKG m_verticalMapping;

		[SerializeField]
		protected float m_uvLineOffset;

		protected HJNAPNHAJCI LNKILMNOLPD = HJNAPNHAJCI.Render;

		[SerializeField]
		protected LLKOCAEGPDG m_geometrySortingOrder;

		[SerializeField]
		protected int m_firstVisibleCharacter;

		protected int NGFIDCLHDJB = 99999;

		protected int KDEGEADEDLP = 99999;

		protected int DJCOAAAJIBO = 99999;

		[SerializeField]
		protected bool m_useMaxVisibleDescender = true;

		[SerializeField]
		protected int m_pageToDisplay = 1;

		protected bool GEGDAJAOKKA;

		[SerializeField]
		protected Vector4 m_margin = new Vector4(0f, 0f, 0f, 0f);

		protected float DPIAMOJPHPK;

		protected float EPPLBJGIFEM;

		protected float IOOMPCBBCNK;

		protected float NNFECNKNNLL;

		protected float IFAFCDFNNJN = -1f;

		[SerializeField]
		protected TMP_TextInfo m_textInfo;

		[SerializeField]
		protected bool m_havePropertiesChanged;

		[SerializeField]
		protected bool m_isUsingLegacyAnimationComponent;

		protected Transform HGNPANDBHBA;

		protected RectTransform HBKNOEILBLE;

		protected bool PCIEPCLHNLM;

		protected Mesh OPMBPPBMINF;

		[SerializeField]
		protected bool m_isVolumetricText;

		[SerializeField]
		protected TMP_SpriteAnimator m_spriteAnimator;

		protected float GFAAMEPFBAD = -1f;

		protected float PILGALGCMEO = -1f;

		protected float HCGCJHJLPJB;

		protected float ILBKJFGJGMH;

		protected float PFMOJEEIOPD;

		protected float MHLKDOGHCOJ;

		protected LayoutElement HCGLEMOMINH;

		protected float HEJJGBFEPCM;

		protected float FMKGKCHEMEC;

		protected bool IKDPKCPAGOC;

		protected float EHHDCBAEJDG;

		protected float OEDGCKDIFCJ;

		protected bool KJFOCCKAAGA;

		protected bool CEOCLEMDMEE;

		private int IAELOBCAKJO;

		protected int LJMLNIJLFJK;

		protected bool DHOELNIONFE;

		protected bool GHPJHKPEOIK;

		protected bool DDIENOMJOHI;

		protected bool ONLMDAHAAID;

		protected bool NHJALNOIJDN;

		[SerializeField]
		protected bool m_isInputParsingRequired;

		[SerializeField]
		protected MCAFEPOCEPL m_inputSource;

		protected string AGKAILPBDFC;

		protected float IPBGPFPMHDO;

		protected float MAAEIFJAONL;

		protected float LEDOMALGBJG;

		protected float MEPDJFGMGOK;

		protected float GEHMOIPKBGD;

		protected char[] LKNOAGBKDDD = new char[128];

		protected CHPENMNNABE[] POAMHMDFAIN = new CHPENMNNABE[8];

		protected float[] AKDGIGDHIGO = new float[16];

		protected float KGDNHOEOOHO;

		protected float GKEHAJKJCEF;

		protected global::NEIBAJOHEEC<float> BNFNFGGNBGJ = new global::NEIBAJOHEEC<float>(new float[16]);

		protected bool FGGFHMLKNJJ;

		protected bool OHKANPJHAFP;

		protected Matrix4x4 DLBOPBIJDIB;

		protected bool HCBFOLNGCFI;

		protected int[] GMALEIECAPN;

		private MGLLLPMKGDA[] JGPBECKLALF;

		protected char[] IEBABBDAELJ = new char[256];

		private int CGCIFDILCLI;

		protected int KOIMFMFOLII;

		protected LAGHBLJIEME BLMLICONBCO = default(LAGHBLJIEME);

		protected LAGHBLJIEME EOKDMGOFOOH = default(LAGHBLJIEME);

		protected int HEEDOMEABKA;

		protected int MIEJCGGDMLJ;

		protected int JGOLJOCMOGD;

		protected int LFEILECBDDB;

		protected int GMLEPIKAEMI;

		protected int FGMGAJAPPJC;

		protected int CILFEEOIDGC;

		protected int BHJLNHKINKN;

		protected float MJMNGPIFHGG;

		protected float JCNIIINOEHG;

		protected float ONHFBKLHJIN;

		protected float NDEAABJECMK;

		protected float ODBAKFJDCCP;

		protected float DMKNFOCBDEG;

		protected float GFIDNINNNAL;

		protected FEBFBNHKLAA NBHJNBHINPH;

		protected Color32 EPCFNBCMCHK = new Color(255f, 255f, 255f, 128f);

		protected global::NEIBAJOHEEC<Color32> EOGFNFBPHHJ = new global::NEIBAJOHEEC<Color32>(new Color32[16]);

		protected global::NEIBAJOHEEC<Color32> FNPOGPIGCIN = new global::NEIBAJOHEEC<Color32>(new Color32[16]);

		protected global::NEIBAJOHEEC<Color32> LEMAEBLIHBK = new global::NEIBAJOHEEC<Color32>(new Color32[16]);

		protected global::NEIBAJOHEEC<Color32> KOOKMGIBAIG = new global::NEIBAJOHEEC<Color32>(new Color32[16]);

		protected float DCKMAGOKJOC;

		protected float GAHOCCBPLAA;

		protected global::NEIBAJOHEEC<int> LHDBHJFCEKJ = new global::NEIBAJOHEEC<int>(new int[16]);

		protected global::NEIBAJOHEEC<int> DJIJDHCEGOA = new global::NEIBAJOHEEC<int>(new int[16]);

		protected float IBKCGEGKGNM;

		protected float HDHGLHPMBPG;

		protected float PLALFBMFEEC;

		protected HIPDBPNMONO FHJFKDGNODI;

		protected TMP_TextElement EOLJHINLKLO;

		protected TMP_Glyph EDEHAJPLEKI;

		protected TMP_Glyph KHNLFLGPDJL;

		protected TMP_SpriteAsset FDAFMNELPNF;

		protected TMP_SpriteAsset HBLKKCJHFFK;

		protected int EACDOBPJMHI;

		protected int OOIILNOMGIL;

		protected InlineGraphicManager ALIGHMAKHKH;

		protected int MLEBLGGBDIA;

		protected bool FOMLPKEMFLJ;

		private readonly float[] BNHNMAALCMM = new float[10] { 0.5f, 0.05f, 0.005f, 0.0005f, 5E-05f, 5E-06f, 5E-07f, 5E-08f, 5E-09f, 5E-10f };

		protected static Vector2 BOAMBILHDEN = new Vector2(2.1474836E+09f, 2.1474836E+09f);

		protected static Vector2 DEAMJJKCNNM = new Vector2(-2.1474836E+09f, -2.1474836E+09f);

		protected static float FEBIFNLEHEG = 32767f;

		protected static float BDOPFJFCOGB = -32767f;

		protected static int BNMOALCNHMC = int.MaxValue;

		protected static int OFFAGHPAIEP = -2147483647;

		public string FCJBBPHFNPJ
		{
			get
			{
				return m_text;
			}
			set
			{
				if (!(m_text == value))
				{
					m_text = (AGKAILPBDFC = value);
					m_inputSource = MCAFEPOCEPL.String;
					m_havePropertiesChanged = true;
					DHOELNIONFE = true;
					m_isInputParsingRequired = true;
					SetVerticesDirty();
					SetLayoutDirty();
				}
			}
		}

		public bool GKDPFEGNICI
		{
			get
			{
				return m_isRightToLeft;
			}
			set
			{
				if (m_isRightToLeft != value)
				{
					m_isRightToLeft = value;
					m_havePropertiesChanged = true;
					DHOELNIONFE = true;
					m_isInputParsingRequired = true;
					SetVerticesDirty();
					SetLayoutDirty();
				}
			}
		}

		public TMP_FontAsset ELKNHALJKNI
		{
			get
			{
				return m_fontAsset;
			}
			set
			{
				if (!(m_fontAsset == value))
				{
					m_fontAsset = value;
					HKPPGOIIJJJ();
					m_havePropertiesChanged = true;
					DHOELNIONFE = true;
					m_isInputParsingRequired = true;
					SetVerticesDirty();
					SetLayoutDirty();
				}
			}
		}

		public virtual Material AENJCFJNHDP
		{
			get
			{
				return m_sharedMaterial;
			}
			set
			{
				if (!(m_sharedMaterial == value))
				{
					LFCEIGAFPID(value);
					m_havePropertiesChanged = true;
					m_isInputParsingRequired = true;
					SetVerticesDirty();
					SetMaterialDirty();
				}
			}
		}

		public virtual Material[] AKIDKMOLNCD
		{
			get
			{
				return DGGOGFBFNEO();
			}
			set
			{
				MMOPIMDKJDE(value);
				m_havePropertiesChanged = true;
				m_isInputParsingRequired = true;
				SetVerticesDirty();
				SetMaterialDirty();
			}
		}

		public Material ODDEOOFJENH
		{
			get
			{
				return JNMHGFLJDKP(m_sharedMaterial);
			}
			set
			{
				if (!(m_sharedMaterial != null) || m_sharedMaterial.GetInstanceID() != value.GetInstanceID())
				{
					m_sharedMaterial = value;
					IBKCGEGKGNM = LEJDCNIKNBD();
					m_havePropertiesChanged = true;
					m_isInputParsingRequired = true;
					SetVerticesDirty();
					SetMaterialDirty();
				}
			}
		}

		public virtual Material[] FLDELAFDBCD
		{
			get
			{
				return EJLJPNINLLO(m_fontSharedMaterials);
			}
			set
			{
				MMOPIMDKJDE(value);
				m_havePropertiesChanged = true;
				m_isInputParsingRequired = true;
				SetVerticesDirty();
				SetMaterialDirty();
			}
		}

		public override Color MFODILBOMGD
		{
			get
			{
				return m_fontColor;
			}
			set
			{
				if (!(m_fontColor == value))
				{
					m_havePropertiesChanged = true;
					m_fontColor = value;
					SetVerticesDirty();
				}
			}
		}

		public float KBKMPEOMABI
		{
			get
			{
				return m_fontColor.a;
			}
			set
			{
				if (m_fontColor.a != value)
				{
					m_fontColor.a = value;
					m_havePropertiesChanged = true;
					SetVerticesDirty();
				}
			}
		}

		public bool BHKHJHAGEIG
		{
			get
			{
				return m_enableVertexGradient;
			}
			set
			{
				if (m_enableVertexGradient != value)
				{
					m_havePropertiesChanged = true;
					m_enableVertexGradient = value;
					SetVerticesDirty();
				}
			}
		}

		public VertexGradient DKOLLGOOKHD
		{
			get
			{
				return m_fontColorGradient;
			}
			set
			{
				m_havePropertiesChanged = true;
				m_fontColorGradient = value;
				SetVerticesDirty();
			}
		}

		public TMP_ColorGradient AEPLIMBMCCE
		{
			get
			{
				return m_fontColorGradientPreset;
			}
			set
			{
				m_havePropertiesChanged = true;
				m_fontColorGradientPreset = value;
				SetVerticesDirty();
			}
		}

		public TMP_SpriteAsset GKDEMJDOOLB
		{
			get
			{
				return m_spriteAsset;
			}
			set
			{
				m_spriteAsset = value;
				m_havePropertiesChanged = true;
				m_isInputParsingRequired = true;
				DHOELNIONFE = true;
				SetVerticesDirty();
				SetLayoutDirty();
			}
		}

		public bool CFLMEJJDJBE
		{
			get
			{
				return m_tintAllSprites;
			}
			set
			{
				if (m_tintAllSprites != value)
				{
					m_tintAllSprites = value;
					m_havePropertiesChanged = true;
					SetVerticesDirty();
				}
			}
		}

		public bool HLGHBNNGLFH
		{
			get
			{
				return m_overrideHtmlColors;
			}
			set
			{
				if (m_overrideHtmlColors != value)
				{
					m_havePropertiesChanged = true;
					m_overrideHtmlColors = value;
					SetVerticesDirty();
				}
			}
		}

		public Color32 LNBJLHMPGDD
		{
			get
			{
				if (m_sharedMaterial == null)
				{
					return m_faceColor;
				}
				m_faceColor = m_sharedMaterial.GetColor(MOHPNOBPBBL.JCABCKFODAG);
				return m_faceColor;
			}
			set
			{
				if (!m_faceColor.ICKHMPOCMAJ(value))
				{
					AKNMLFGLGAJ(value);
					m_havePropertiesChanged = true;
					m_faceColor = value;
					SetVerticesDirty();
					SetMaterialDirty();
				}
			}
		}

		public Color32 NOBGLLBDMHD
		{
			get
			{
				if (m_sharedMaterial == null)
				{
					return m_outlineColor;
				}
				m_outlineColor = m_sharedMaterial.GetColor(MOHPNOBPBBL.LNBDEEHONJE);
				return m_outlineColor;
			}
			set
			{
				if (!m_outlineColor.ICKHMPOCMAJ(value))
				{
					NDBGEGOKCOL(value);
					m_havePropertiesChanged = true;
					m_outlineColor = value;
					SetVerticesDirty();
				}
			}
		}

		public float LPPODCEJOIB
		{
			get
			{
				if (m_sharedMaterial == null)
				{
					return FHKFOELPGPK;
				}
				FHKFOELPGPK = m_sharedMaterial.GetFloat(MOHPNOBPBBL.KOJOEHKKDCC);
				return FHKFOELPGPK;
			}
			set
			{
				if (FHKFOELPGPK != value)
				{
					MIOIBPAPDAN(value);
					m_havePropertiesChanged = true;
					FHKFOELPGPK = value;
					SetVerticesDirty();
				}
			}
		}

		public float DGLOHLPKABM
		{
			get
			{
				return m_fontSize;
			}
			set
			{
				if (m_fontSize != value)
				{
					m_havePropertiesChanged = true;
					DHOELNIONFE = true;
					SetVerticesDirty();
					SetLayoutDirty();
					m_fontSize = value;
					if (!m_enableAutoSizing)
					{
						m_fontSizeBase = m_fontSize;
					}
				}
			}
		}

		public float EJMLONDBAJI
		{
			get
			{
				return MEPDJFGMGOK;
			}
		}

		public int PMJMEBGDBJI
		{
			get
			{
				return m_fontWeight;
			}
			set
			{
				if (m_fontWeight != value)
				{
					m_fontWeight = value;
					DHOELNIONFE = true;
					SetVerticesDirty();
					SetLayoutDirty();
				}
			}
		}

		public float IGMBAPEBFBJ
		{
			get
			{
				Canvas canvas = base.canvas;
				if (!canvas)
				{
					return 1f;
				}
				if (!ELKNHALJKNI)
				{
					return canvas.scaleFactor;
				}
				if (AFEJPPDMPHE == null || AFEJPPDMPHE.fontInfo.PointSize <= 0f || m_fontSize <= 0f)
				{
					return 1f;
				}
				return m_fontSize / AFEJPPDMPHE.fontInfo.PointSize;
			}
		}

		public bool LPMDHKHNOGE
		{
			get
			{
				return m_enableAutoSizing;
			}
			set
			{
				if (m_enableAutoSizing != value)
				{
					m_enableAutoSizing = value;
					SetVerticesDirty();
					SetLayoutDirty();
				}
			}
		}

		public float BIEFHMFPKEP
		{
			get
			{
				return m_fontSizeMin;
			}
			set
			{
				if (m_fontSizeMin != value)
				{
					m_fontSizeMin = value;
					SetVerticesDirty();
					SetLayoutDirty();
				}
			}
		}

		public float KMADLHHGAIH
		{
			get
			{
				return m_fontSizeMax;
			}
			set
			{
				if (m_fontSizeMax != value)
				{
					m_fontSizeMax = value;
					SetVerticesDirty();
					SetLayoutDirty();
				}
			}
		}

		public BCIEOOJOMDO CMFEBDBACDI
		{
			get
			{
				return m_fontStyle;
			}
			set
			{
				if (m_fontStyle != value)
				{
					m_fontStyle = value;
					m_havePropertiesChanged = true;
					checkPaddingRequired = true;
					SetVerticesDirty();
					SetLayoutDirty();
				}
			}
		}

		public bool HBBBBINCPHE
		{
			get
			{
				return JLDKHEKHGKA;
			}
		}

		public KNOECCJHIDP JOPPDFNGJBM
		{
			get
			{
				return m_textAlignment;
			}
			set
			{
				if (m_textAlignment != value)
				{
					m_havePropertiesChanged = true;
					m_textAlignment = value;
					SetVerticesDirty();
				}
			}
		}

		public float FJAABLALDLN
		{
			get
			{
				return m_characterSpacing;
			}
			set
			{
				if (m_characterSpacing != value)
				{
					m_havePropertiesChanged = true;
					DHOELNIONFE = true;
					SetVerticesDirty();
					SetLayoutDirty();
					m_characterSpacing = value;
				}
			}
		}

		public float GCBOIJHGNKO
		{
			get
			{
				return m_wordSpacing;
			}
			set
			{
				if (m_wordSpacing != value)
				{
					m_havePropertiesChanged = true;
					DHOELNIONFE = true;
					SetVerticesDirty();
					SetLayoutDirty();
					m_wordSpacing = value;
				}
			}
		}

		public float EIEEICCMFNC
		{
			get
			{
				return m_lineSpacing;
			}
			set
			{
				if (m_lineSpacing != value)
				{
					m_havePropertiesChanged = true;
					DHOELNIONFE = true;
					SetVerticesDirty();
					SetLayoutDirty();
					m_lineSpacing = value;
				}
			}
		}

		public float IKNAIPPCHCP
		{
			get
			{
				return m_lineSpacingMax;
			}
			set
			{
				if (m_lineSpacingMax != value)
				{
					m_havePropertiesChanged = true;
					DHOELNIONFE = true;
					SetVerticesDirty();
					SetLayoutDirty();
					m_lineSpacingMax = value;
				}
			}
		}

		public float DLJALACHHNI
		{
			get
			{
				return m_paragraphSpacing;
			}
			set
			{
				if (m_paragraphSpacing != value)
				{
					m_havePropertiesChanged = true;
					DHOELNIONFE = true;
					SetVerticesDirty();
					SetLayoutDirty();
					m_paragraphSpacing = value;
				}
			}
		}

		public float DEPJBGHEGNH
		{
			get
			{
				return m_charWidthMaxAdj;
			}
			set
			{
				if (m_charWidthMaxAdj != value)
				{
					m_havePropertiesChanged = true;
					DHOELNIONFE = true;
					SetVerticesDirty();
					SetLayoutDirty();
					m_charWidthMaxAdj = value;
				}
			}
		}

		public bool MHAGENKBNAN
		{
			get
			{
				return m_enableWordWrapping;
			}
			set
			{
				if (m_enableWordWrapping != value)
				{
					m_havePropertiesChanged = true;
					m_isInputParsingRequired = true;
					DHOELNIONFE = true;
					m_enableWordWrapping = value;
					SetVerticesDirty();
					SetLayoutDirty();
				}
			}
		}

		public float FBKDOGALBDM
		{
			get
			{
				return m_wordWrappingRatios;
			}
			set
			{
				if (m_wordWrappingRatios != value)
				{
					m_wordWrappingRatios = value;
					m_havePropertiesChanged = true;
					DHOELNIONFE = true;
					SetVerticesDirty();
					SetLayoutDirty();
				}
			}
		}

		public OLMBEAODAPL FJBKGKBEEGI
		{
			get
			{
				return m_overflowMode;
			}
			set
			{
				if (m_overflowMode != value)
				{
					m_overflowMode = value;
					m_havePropertiesChanged = true;
					DHOELNIONFE = true;
					SetVerticesDirty();
					SetLayoutDirty();
				}
			}
		}

		public bool BGOCFNFKDON
		{
			get
			{
				if (m_firstOverflowCharacterIndex != -1)
				{
					return true;
				}
				return false;
			}
		}

		public int DBCEFLJOHOI
		{
			get
			{
				return m_firstOverflowCharacterIndex;
			}
		}

		public TMP_Text HDAEEHGDAAF
		{
			get
			{
				return m_linkedTextComponent;
			}
			set
			{
				if (m_linkedTextComponent != value)
				{
					if (m_linkedTextComponent != null)
					{
						m_linkedTextComponent.FJBKGKBEEGI = OLMBEAODAPL.Overflow;
						m_linkedTextComponent.HDAEEHGDAAF = null;
						m_linkedTextComponent.GGIMFNGJBHA = false;
					}
					m_linkedTextComponent = value;
					if (m_linkedTextComponent != null)
					{
						m_linkedTextComponent.GGIMFNGJBHA = true;
					}
				}
				m_havePropertiesChanged = true;
				DHOELNIONFE = true;
				SetVerticesDirty();
				SetLayoutDirty();
			}
		}

		public bool GGIMFNGJBHA
		{
			get
			{
				return m_isLinkedTextComponent;
			}
			set
			{
				m_isLinkedTextComponent = value;
				if (!m_isLinkedTextComponent)
				{
					m_firstVisibleCharacter = 0;
				}
				m_havePropertiesChanged = true;
				DHOELNIONFE = true;
				SetVerticesDirty();
				SetLayoutDirty();
			}
		}

		public bool MHECDOKGOCA
		{
			get
			{
				return OHEPFDPOBOF;
			}
		}

		public bool JFIPOPLFEOD
		{
			get
			{
				return m_enableKerning;
			}
			set
			{
				if (m_enableKerning != value)
				{
					m_havePropertiesChanged = true;
					DHOELNIONFE = true;
					SetVerticesDirty();
					SetLayoutDirty();
					m_enableKerning = value;
				}
			}
		}

		public bool AJLGMMOGEOC
		{
			get
			{
				return m_enableExtraPadding;
			}
			set
			{
				if (m_enableExtraPadding != value)
				{
					m_havePropertiesChanged = true;
					m_enableExtraPadding = value;
					UpdateMeshPadding();
					SetVerticesDirty();
				}
			}
		}

		public bool DGCLMBNNONA
		{
			get
			{
				return m_isRichText;
			}
			set
			{
				if (m_isRichText != value)
				{
					m_isRichText = value;
					m_havePropertiesChanged = true;
					DHOELNIONFE = true;
					SetVerticesDirty();
					SetLayoutDirty();
					m_isInputParsingRequired = true;
				}
			}
		}

		public bool DIOJMOENCPG
		{
			get
			{
				return m_parseCtrlCharacters;
			}
			set
			{
				if (m_parseCtrlCharacters != value)
				{
					m_parseCtrlCharacters = value;
					m_havePropertiesChanged = true;
					DHOELNIONFE = true;
					SetVerticesDirty();
					SetLayoutDirty();
					m_isInputParsingRequired = true;
				}
			}
		}

		public bool INIKHAFCKFN
		{
			get
			{
				return HCFCMKLKOIM;
			}
			set
			{
				if (HCFCMKLKOIM != value)
				{
					HCFCMKLKOIM = value;
					AEAIBCHGCNL();
					m_havePropertiesChanged = true;
					SetVerticesDirty();
				}
			}
		}

		public bool FGKGAABAOEM
		{
			get
			{
				return m_isOrthographic;
			}
			set
			{
				if (m_isOrthographic != value)
				{
					m_havePropertiesChanged = true;
					m_isOrthographic = value;
					SetVerticesDirty();
				}
			}
		}

		public bool COOFLFMHOCN
		{
			get
			{
				return m_isCullingEnabled;
			}
			set
			{
				if (m_isCullingEnabled != value)
				{
					m_isCullingEnabled = value;
					GDDGEMIIBDC();
					m_havePropertiesChanged = true;
				}
			}
		}

		public bool CIDGHENKBFI
		{
			get
			{
				return m_ignoreRectMaskCulling;
			}
			set
			{
				if (m_ignoreRectMaskCulling != value)
				{
					m_ignoreRectMaskCulling = value;
					m_havePropertiesChanged = true;
				}
			}
		}

		public bool OOHEDPGPLKF
		{
			get
			{
				return m_ignoreCulling;
			}
			set
			{
				if (m_ignoreCulling != value)
				{
					m_havePropertiesChanged = true;
					m_ignoreCulling = value;
				}
			}
		}

		public NBJIALGHGKG BMHHNKNBAMG
		{
			get
			{
				return m_horizontalMapping;
			}
			set
			{
				if (m_horizontalMapping != value)
				{
					m_havePropertiesChanged = true;
					m_horizontalMapping = value;
					SetVerticesDirty();
				}
			}
		}

		public NBJIALGHGKG DPGIEEDBDFJ
		{
			get
			{
				return m_verticalMapping;
			}
			set
			{
				if (m_verticalMapping != value)
				{
					m_havePropertiesChanged = true;
					m_verticalMapping = value;
					SetVerticesDirty();
				}
			}
		}

		public float ACMOACLLJOE
		{
			get
			{
				return m_uvLineOffset;
			}
			set
			{
				if (m_uvLineOffset != value)
				{
					m_havePropertiesChanged = true;
					m_uvLineOffset = value;
					SetVerticesDirty();
				}
			}
		}

		public HJNAPNHAJCI ODLOMHAPFPE
		{
			get
			{
				return LNKILMNOLPD;
			}
			set
			{
				if (LNKILMNOLPD != value)
				{
					LNKILMNOLPD = value;
					m_havePropertiesChanged = true;
				}
			}
		}

		public LLKOCAEGPDG HMMLNMDKKNK
		{
			get
			{
				return m_geometrySortingOrder;
			}
			set
			{
				m_geometrySortingOrder = value;
				m_havePropertiesChanged = true;
				SetVerticesDirty();
			}
		}

		public int CPAJEAIKNJL
		{
			get
			{
				return m_firstVisibleCharacter;
			}
			set
			{
				if (m_firstVisibleCharacter != value)
				{
					m_havePropertiesChanged = true;
					m_firstVisibleCharacter = value;
					SetVerticesDirty();
				}
			}
		}

		public int EMAEHJHKLBK
		{
			get
			{
				return NGFIDCLHDJB;
			}
			set
			{
				if (NGFIDCLHDJB != value)
				{
					m_havePropertiesChanged = true;
					NGFIDCLHDJB = value;
					SetVerticesDirty();
				}
			}
		}

		public int IDEJLBLMCCE
		{
			get
			{
				return KDEGEADEDLP;
			}
			set
			{
				if (KDEGEADEDLP != value)
				{
					m_havePropertiesChanged = true;
					KDEGEADEDLP = value;
					SetVerticesDirty();
				}
			}
		}

		public int HAGIKDIIIGD
		{
			get
			{
				return DJCOAAAJIBO;
			}
			set
			{
				if (DJCOAAAJIBO != value)
				{
					m_havePropertiesChanged = true;
					m_isInputParsingRequired = true;
					DJCOAAAJIBO = value;
					SetVerticesDirty();
				}
			}
		}

		public bool GLBDPKEDCFB
		{
			get
			{
				return m_useMaxVisibleDescender;
			}
			set
			{
				if (m_useMaxVisibleDescender != value)
				{
					m_havePropertiesChanged = true;
					m_isInputParsingRequired = true;
					SetVerticesDirty();
				}
			}
		}

		public int IEPGKBOEPKP
		{
			get
			{
				return m_pageToDisplay;
			}
			set
			{
				if (m_pageToDisplay != value)
				{
					m_havePropertiesChanged = true;
					m_pageToDisplay = value;
					SetVerticesDirty();
				}
			}
		}

		public virtual Vector4 PNACILIBDDF
		{
			get
			{
				return m_margin;
			}
			set
			{
				if (!(m_margin == value))
				{
					m_margin = value;
					EMKNNKLEEPI();
					m_havePropertiesChanged = true;
					SetVerticesDirty();
				}
			}
		}

		public TMP_TextInfo BIAHJAKEMLM
		{
			get
			{
				return m_textInfo;
			}
		}

		public bool KEJHLJNMEAH
		{
			get
			{
				return m_havePropertiesChanged;
			}
			set
			{
				if (m_havePropertiesChanged != value)
				{
					m_havePropertiesChanged = value;
					m_isInputParsingRequired = true;
					SetAllDirty();
				}
			}
		}

		public bool HEMCPBHCNMI
		{
			get
			{
				return m_isUsingLegacyAnimationComponent;
			}
			set
			{
				m_isUsingLegacyAnimationComponent = value;
			}
		}

		public Transform ANLKLKAINEO
		{
			get
			{
				if (HGNPANDBHBA == null)
				{
					HGNPANDBHBA = GetComponent<Transform>();
				}
				return HGNPANDBHBA;
			}
		}

		public RectTransform GPPKOGCLKPL
		{
			get
			{
				if (HBKNOEILBLE == null)
				{
					HBKNOEILBLE = GetComponent<RectTransform>();
				}
				return HBKNOEILBLE;
			}
		}

		public virtual bool OFBCJEKCLMH { get; set; }

		public virtual Mesh IJKCGGPJDIG
		{
			get
			{
				return OPMBPPBMINF;
			}
		}

		public bool FDFEHFEKFPG
		{
			get
			{
				return m_isVolumetricText;
			}
			set
			{
				if (m_isVolumetricText != value)
				{
					m_havePropertiesChanged = value;
					m_textInfo.PGMGIJGFCNP(value);
					m_isInputParsingRequired = true;
					SetVerticesDirty();
					SetLayoutDirty();
				}
			}
		}

		public Bounds DJKHEGCCHFI
		{
			get
			{
				if (OPMBPPBMINF == null)
				{
					return default(Bounds);
				}
				return LFBLMFICMCK();
			}
		}

		public Bounds LAIBPAIMCNL
		{
			get
			{
				if (m_textInfo == null)
				{
					return default(Bounds);
				}
				return OOANHEKEHDK();
			}
		}

		protected TMP_SpriteAnimator JFMLLDIFICE
		{
			get
			{
				if (m_spriteAnimator == null)
				{
					m_spriteAnimator = GetComponent<TMP_SpriteAnimator>();
					if (m_spriteAnimator == null)
					{
						m_spriteAnimator = base.gameObject.AddComponent<TMP_SpriteAnimator>();
					}
				}
				return m_spriteAnimator;
			}
		}

		public float CPGLADPHGGB
		{
			get
			{
				return GFAAMEPFBAD;
			}
		}

		public float DIHHMNKCIME
		{
			get
			{
				return PILGALGCMEO;
			}
		}

		public float PNMOKJEFIDI
		{
			get
			{
				return HCGCJHJLPJB;
			}
		}

		public float NOIJFGGHCOD
		{
			get
			{
				return ILBKJFGJGMH;
			}
		}

		public float BEMIODKKNIC
		{
			get
			{
				return PFMOJEEIOPD;
			}
		}

		public float JJMLBNAKNED
		{
			get
			{
				return MHLKDOGHCOJ;
			}
		}

		protected LayoutElement IMIGELHEBAK
		{
			get
			{
				if (HCGLEMOMINH == null)
				{
					HCGLEMOMINH = GetComponent<LayoutElement>();
				}
				return HCGLEMOMINH;
			}
		}

		public virtual float AODHJNNEFKF
		{
			get
			{
				if (!IKDPKCPAGOC)
				{
					return HEJJGBFEPCM;
				}
				HEJJGBFEPCM = HNKGNKGIBOB();
				return HEJJGBFEPCM;
			}
		}

		public virtual float ICJOPDNAIJF
		{
			get
			{
				if (!KJFOCCKAAGA)
				{
					return EHHDCBAEJDG;
				}
				EHHDCBAEJDG = PMDDOMPJDPA();
				return EHHDCBAEJDG;
			}
		}

		public virtual float GLODLLFPPCO
		{
			get
			{
				return NCKIMEPFPMC();
			}
		}

		public virtual float LMBIDEJCHLH
		{
			get
			{
				return FBBBIKEEOPL();
			}
		}

		public int KKCEDIOLCLL
		{
			get
			{
				return LJMLNIJLFJK;
			}
		}

		protected virtual void HKPPGOIIJJJ()
		{
		}

		protected virtual void LFCEIGAFPID(Material GJDEEBDFEFM)
		{
		}

		protected virtual Material JNMHGFLJDKP(Material GJDEEBDFEFM)
		{
			return null;
		}

		protected virtual void ANCJMGJIHGN(Material GJDEEBDFEFM)
		{
		}

		protected virtual Material[] DGGOGFBFNEO()
		{
			return null;
		}

		protected virtual void MMOPIMDKJDE(Material[] IDBMABBJCNC)
		{
		}

		protected virtual Material[] EJLJPNINLLO(Material[] BIPEMPFPCKG)
		{
			return null;
		}

		protected virtual Material IEDEFFAONFN(Material JKHLMLIANAI)
		{
			Material material = new Material(JKHLMLIANAI);
			material.shaderKeywords = JKHLMLIANAI.shaderKeywords;
			material.name += " (Instance)";
			return material;
		}

		protected void DIILBAIPDAE(TMP_ColorGradient PLLFLNHOIGK)
		{
			if (!(PLLFLNHOIGK == null))
			{
				m_fontColorGradient.bottomLeft = PLLFLNHOIGK.bottomLeft;
				m_fontColorGradient.bottomRight = PLLFLNHOIGK.bottomRight;
				m_fontColorGradient.topLeft = PLLFLNHOIGK.topLeft;
				m_fontColorGradient.topRight = PLLFLNHOIGK.topRight;
				SetVerticesDirty();
			}
		}

		protected void BBIEAMEHPCN(LLKOCAEGPDG CMAJLIAELDP)
		{
		}

		protected void BBIEAMEHPCN(int[] CMAJLIAELDP)
		{
		}

		protected virtual void AKNMLFGLGAJ(Color32 MFODILBOMGD)
		{
		}

		protected virtual void NDBGEGOKCOL(Color32 MFODILBOMGD)
		{
		}

		protected virtual void MIOIBPAPDAN(float GGANGHBLIPC)
		{
		}

		protected virtual void AEAIBCHGCNL()
		{
		}

		protected virtual void GDDGEMIIBDC()
		{
		}

		protected virtual float LEJDCNIKNBD()
		{
			return 0f;
		}

		protected virtual float LEJDCNIKNBD(Material GJDEEBDFEFM)
		{
			return 0f;
		}

		protected virtual Vector3[] BELKDCLEJKJ()
		{
			return null;
		}

		public virtual void ForceMeshUpdate()
		{
		}

		public virtual void ForceMeshUpdate(bool IJECLLHPMPL)
		{
		}

		internal void AAGKKEJIODG(string FCJBBPHFNPJ)
		{
			m_text = FCJBBPHFNPJ;
			LNKILMNOLPD = HJNAPNHAJCI.DontRender;
			m_isInputParsingRequired = true;
			ForceMeshUpdate();
			LNKILMNOLPD = HJNAPNHAJCI.Render;
		}

		public virtual void UpdateGeometry(Mesh IJKCGGPJDIG, int EHJNMODJEAN)
		{
		}

		public virtual void UpdateVertexData(ELPAMMNJADG KCHENLJCHHH)
		{
		}

		public virtual void UpdateVertexData()
		{
		}

		public virtual void SetVertices(Vector3[] FHBFCAEGPOH)
		{
		}

		public virtual void UpdateMeshPadding()
		{
		}

		public override void CrossFadeColor(Color ICEFPJCHGBJ, float FMPBJJMKCIG, bool AFCNLNOBLKK, bool JNMJBPPJFMJ)
		{
			base.CrossFadeColor(ICEFPJCHGBJ, FMPBJJMKCIG, AFCNLNOBLKK, JNMJBPPJFMJ);
			MMOFEGKNHEF(ICEFPJCHGBJ, FMPBJJMKCIG, AFCNLNOBLKK, JNMJBPPJFMJ);
		}

		public override void CrossFadeAlpha(float KBKMPEOMABI, float FMPBJJMKCIG, bool AFCNLNOBLKK)
		{
			base.CrossFadeAlpha(KBKMPEOMABI, FMPBJJMKCIG, AFCNLNOBLKK);
			PGLHDCOKDNJ(KBKMPEOMABI, FMPBJJMKCIG, AFCNLNOBLKK);
		}

		protected virtual void MMOFEGKNHEF(Color ICEFPJCHGBJ, float FMPBJJMKCIG, bool AFCNLNOBLKK, bool JNMJBPPJFMJ)
		{
		}

		protected virtual void PGLHDCOKDNJ(float KBKMPEOMABI, float FMPBJJMKCIG, bool AFCNLNOBLKK)
		{
		}

		protected void GJKICJDAIIH()
		{
			m_isInputParsingRequired = false;
			switch (m_inputSource)
			{
			case MCAFEPOCEPL.Text:
			case MCAFEPOCEPL.String:
				PDENOOPDPEN(m_text, ref GMALEIECAPN);
				break;
			case MCAFEPOCEPL.SetText:
				HPBLJLAPCFM(IEBABBDAELJ, ref GMALEIECAPN);
				break;
			}
			JAADOMGCOHA(GMALEIECAPN);
		}

		public void SetText(string FCJBBPHFNPJ)
		{
			SetText(FCJBBPHFNPJ, true);
		}

		public void SetText(string FCJBBPHFNPJ, bool JJAAJENHCMB)
		{
			if (!(FCJBBPHFNPJ == AGKAILPBDFC))
			{
				AGKAILPBDFC = FCJBBPHFNPJ;
				m_inputSource = MCAFEPOCEPL.SetCharArray;
				PDENOOPDPEN(FCJBBPHFNPJ, ref GMALEIECAPN);
				m_isInputParsingRequired = true;
				m_havePropertiesChanged = true;
				DHOELNIONFE = true;
				SetVerticesDirty();
				SetLayoutDirty();
			}
		}

		public void SetText(string FCJBBPHFNPJ, float EFAAOFGKEAG)
		{
			SetText(FCJBBPHFNPJ, EFAAOFGKEAG, 255f, 255f);
		}

		public void SetText(string FCJBBPHFNPJ, float EFAAOFGKEAG, float DCPBKENCLHB)
		{
			SetText(FCJBBPHFNPJ, EFAAOFGKEAG, DCPBKENCLHB, 255f);
		}

		public void SetText(string FCJBBPHFNPJ, float EFAAOFGKEAG, float DCPBKENCLHB, float PGICLDABDEF)
		{
			if (FCJBBPHFNPJ == AGKAILPBDFC && EFAAOFGKEAG == IPBGPFPMHDO && DCPBKENCLHB == MAAEIFJAONL && PGICLDABDEF == LEDOMALGBJG)
			{
				return;
			}
			AGKAILPBDFC = FCJBBPHFNPJ;
			MAAEIFJAONL = 255f;
			LEDOMALGBJG = 255f;
			int lBNBDDMJDEE = 0;
			int EHJNMODJEAN = 0;
			for (int i = 0; i < FCJBBPHFNPJ.Length; i++)
			{
				char c = FCJBBPHFNPJ[i];
				if (c == '{')
				{
					if (FCJBBPHFNPJ[i + 2] == ':')
					{
						lBNBDDMJDEE = FCJBBPHFNPJ[i + 3] - 48;
					}
					switch (FCJBBPHFNPJ[i + 1] - 48)
					{
					case 0:
						IPBGPFPMHDO = EFAAOFGKEAG;
						AGACDBMPHJI(EFAAOFGKEAG, ref EHJNMODJEAN, lBNBDDMJDEE);
						break;
					case 1:
						MAAEIFJAONL = DCPBKENCLHB;
						AGACDBMPHJI(DCPBKENCLHB, ref EHJNMODJEAN, lBNBDDMJDEE);
						break;
					case 2:
						LEDOMALGBJG = PGICLDABDEF;
						AGACDBMPHJI(PGICLDABDEF, ref EHJNMODJEAN, lBNBDDMJDEE);
						break;
					}
					i = ((FCJBBPHFNPJ[i + 2] != ':') ? (i + 2) : (i + 4));
				}
				else
				{
					IEBABBDAELJ[EHJNMODJEAN] = c;
					EHJNMODJEAN++;
				}
			}
			IEBABBDAELJ[EHJNMODJEAN] = '\0';
			CGCIFDILCLI = EHJNMODJEAN;
			m_inputSource = MCAFEPOCEPL.SetText;
			m_isInputParsingRequired = true;
			m_havePropertiesChanged = true;
			DHOELNIONFE = true;
			SetVerticesDirty();
			SetLayoutDirty();
		}

		public void SetText(StringBuilder FCJBBPHFNPJ)
		{
			m_inputSource = MCAFEPOCEPL.SetCharArray;
			DFMFAOJEMEE(FCJBBPHFNPJ, ref GMALEIECAPN);
			m_isInputParsingRequired = true;
			m_havePropertiesChanged = true;
			DHOELNIONFE = true;
			SetVerticesDirty();
			SetLayoutDirty();
		}

		public void SetCharArray(char[] GPKEKMAKNFP)
		{
			if (GPKEKMAKNFP == null || GPKEKMAKNFP.Length == 0)
			{
				return;
			}
			LHDBHJFCEKJ.BOPEPLONIFL();
			int OKEANIBKIKK = 0;
			for (int i = 0; i < GPKEKMAKNFP.Length; i++)
			{
				if (GPKEKMAKNFP[i] == '\\' && i < GPKEKMAKNFP.Length - 1)
				{
					switch (GPKEKMAKNFP[i + 1])
					{
					case 'n':
						if (OKEANIBKIKK + 1 > GMALEIECAPN.Length)
						{
							ENHDMJFBIHL(ref GMALEIECAPN);
						}
						GMALEIECAPN[OKEANIBKIKK] = 10;
						i++;
						OKEANIBKIKK++;
						continue;
					case 'r':
						if (OKEANIBKIKK + 1 > GMALEIECAPN.Length)
						{
							ENHDMJFBIHL(ref GMALEIECAPN);
						}
						GMALEIECAPN[OKEANIBKIKK] = 13;
						i++;
						OKEANIBKIKK++;
						continue;
					case 't':
						if (OKEANIBKIKK + 1 > GMALEIECAPN.Length)
						{
							ENHDMJFBIHL(ref GMALEIECAPN);
						}
						GMALEIECAPN[OKEANIBKIKK] = 9;
						i++;
						OKEANIBKIKK++;
						continue;
					}
				}
				if (GPKEKMAKNFP[i] == '<')
				{
					if (JAIDMFJFDEJ(ref GPKEKMAKNFP, "<BR>", i))
					{
						if (OKEANIBKIKK + 1 > GMALEIECAPN.Length)
						{
							ENHDMJFBIHL(ref GMALEIECAPN);
						}
						GMALEIECAPN[OKEANIBKIKK] = 10;
						OKEANIBKIKK++;
						i += 3;
						continue;
					}
					if (JAIDMFJFDEJ(ref GPKEKMAKNFP, "<STYLE=", i))
					{
						int NEAJDKHHNMI = 0;
						if (LKLLHBGMIBI(ref GPKEKMAKNFP, i, out NEAJDKHHNMI, ref GMALEIECAPN, ref OKEANIBKIKK))
						{
							i = NEAJDKHHNMI;
							continue;
						}
					}
					else if (JAIDMFJFDEJ(ref GPKEKMAKNFP, "</STYLE>", i))
					{
						LJDLKAPKDOA(ref GPKEKMAKNFP, i, ref GMALEIECAPN, ref OKEANIBKIKK);
						i += 7;
						continue;
					}
				}
				if (OKEANIBKIKK + 1 > GMALEIECAPN.Length)
				{
					ENHDMJFBIHL(ref GMALEIECAPN);
				}
				GMALEIECAPN[OKEANIBKIKK] = GPKEKMAKNFP[i];
				OKEANIBKIKK++;
			}
			if (OKEANIBKIKK + 1 > GMALEIECAPN.Length)
			{
				ENHDMJFBIHL(ref GMALEIECAPN);
			}
			GMALEIECAPN[OKEANIBKIKK] = 0;
			m_inputSource = MCAFEPOCEPL.SetCharArray;
			m_havePropertiesChanged = true;
			m_isInputParsingRequired = true;
		}

		public void SetCharArray(int[] GPKEKMAKNFP, int EHGOOEHDNMM, int EOFAGACBNFP)
		{
			if (GPKEKMAKNFP == null || GPKEKMAKNFP.Length == 0 || EOFAGACBNFP == 0)
			{
				return;
			}
			LHDBHJFCEKJ.BOPEPLONIFL();
			int OKEANIBKIKK = 0;
			for (int i = 0; i < EOFAGACBNFP; i++)
			{
				if (GPKEKMAKNFP[EHGOOEHDNMM + i] == 92 && i < EOFAGACBNFP - 1)
				{
					switch (GPKEKMAKNFP[EHGOOEHDNMM + i + 1])
					{
					case 110:
						if (OKEANIBKIKK + 1 > GMALEIECAPN.Length)
						{
							ENHDMJFBIHL(ref GMALEIECAPN);
						}
						GMALEIECAPN[OKEANIBKIKK] = 10;
						i++;
						OKEANIBKIKK++;
						continue;
					case 114:
						if (OKEANIBKIKK + 1 > GMALEIECAPN.Length)
						{
							ENHDMJFBIHL(ref GMALEIECAPN);
						}
						GMALEIECAPN[OKEANIBKIKK] = 13;
						i++;
						OKEANIBKIKK++;
						continue;
					case 116:
						if (OKEANIBKIKK + 1 > GMALEIECAPN.Length)
						{
							ENHDMJFBIHL(ref GMALEIECAPN);
						}
						GMALEIECAPN[OKEANIBKIKK] = 9;
						i++;
						OKEANIBKIKK++;
						continue;
					}
				}
				if (GPKEKMAKNFP[i] == 60)
				{
					if (JAIDMFJFDEJ(ref GPKEKMAKNFP, "<BR>", i))
					{
						if (OKEANIBKIKK + 1 > GMALEIECAPN.Length)
						{
							ENHDMJFBIHL(ref GMALEIECAPN);
						}
						GMALEIECAPN[OKEANIBKIKK] = 10;
						OKEANIBKIKK++;
						i += 3;
						continue;
					}
					if (JAIDMFJFDEJ(ref GPKEKMAKNFP, "<STYLE=", i))
					{
						int NEAJDKHHNMI = 0;
						if (LKLLHBGMIBI(ref GPKEKMAKNFP, i, out NEAJDKHHNMI, ref GMALEIECAPN, ref OKEANIBKIKK))
						{
							i = NEAJDKHHNMI;
							continue;
						}
					}
					else if (JAIDMFJFDEJ(ref GPKEKMAKNFP, "</STYLE>", i))
					{
						LJDLKAPKDOA(ref GPKEKMAKNFP, i, ref GMALEIECAPN, ref OKEANIBKIKK);
						i += 7;
						continue;
					}
				}
				if (OKEANIBKIKK + 1 > GMALEIECAPN.Length)
				{
					ENHDMJFBIHL(ref GMALEIECAPN);
				}
				GMALEIECAPN[OKEANIBKIKK] = GPKEKMAKNFP[EHGOOEHDNMM + i];
				OKEANIBKIKK++;
			}
			if (OKEANIBKIKK + 1 > GMALEIECAPN.Length)
			{
				ENHDMJFBIHL(ref GMALEIECAPN);
			}
			GMALEIECAPN[OKEANIBKIKK] = 0;
			m_inputSource = MCAFEPOCEPL.SetCharArray;
			m_havePropertiesChanged = true;
			m_isInputParsingRequired = true;
			DHOELNIONFE = true;
			SetVerticesDirty();
			SetLayoutDirty();
		}

		protected void HPBLJLAPCFM(char[] GPKEKMAKNFP, ref int[] NKFDJBODBDF)
		{
			if (GPKEKMAKNFP == null || CGCIFDILCLI == 0)
			{
				return;
			}
			LHDBHJFCEKJ.BOPEPLONIFL();
			int OKEANIBKIKK = 0;
			for (int i = 0; i < CGCIFDILCLI; i++)
			{
				if (char.IsHighSurrogate(GPKEKMAKNFP[i]) && char.IsLowSurrogate(GPKEKMAKNFP[i + 1]))
				{
					if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
					{
						ENHDMJFBIHL(ref NKFDJBODBDF);
					}
					NKFDJBODBDF[OKEANIBKIKK] = char.ConvertToUtf32(GPKEKMAKNFP[i], GPKEKMAKNFP[i + 1]);
					i++;
					OKEANIBKIKK++;
					continue;
				}
				if (GPKEKMAKNFP[i] == '<')
				{
					if (JAIDMFJFDEJ(ref GPKEKMAKNFP, "<BR>", i))
					{
						if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
						{
							ENHDMJFBIHL(ref NKFDJBODBDF);
						}
						NKFDJBODBDF[OKEANIBKIKK] = 10;
						OKEANIBKIKK++;
						i += 3;
						continue;
					}
					if (JAIDMFJFDEJ(ref GPKEKMAKNFP, "<STYLE=", i))
					{
						int NEAJDKHHNMI = 0;
						if (LKLLHBGMIBI(ref GPKEKMAKNFP, i, out NEAJDKHHNMI, ref NKFDJBODBDF, ref OKEANIBKIKK))
						{
							i = NEAJDKHHNMI;
							continue;
						}
					}
					else if (JAIDMFJFDEJ(ref GPKEKMAKNFP, "</STYLE>", i))
					{
						LJDLKAPKDOA(ref GPKEKMAKNFP, i, ref NKFDJBODBDF, ref OKEANIBKIKK);
						i += 7;
						continue;
					}
				}
				if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
				{
					ENHDMJFBIHL(ref NKFDJBODBDF);
				}
				NKFDJBODBDF[OKEANIBKIKK] = GPKEKMAKNFP[i];
				OKEANIBKIKK++;
			}
			if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
			{
				ENHDMJFBIHL(ref NKFDJBODBDF);
			}
			NKFDJBODBDF[OKEANIBKIKK] = 0;
		}

		protected void PDENOOPDPEN(string GPKEKMAKNFP, ref int[] NKFDJBODBDF)
		{
			if (GPKEKMAKNFP == null)
			{
				NKFDJBODBDF[0] = 0;
				return;
			}
			LHDBHJFCEKJ.GLLKOHHOLLP(0);
			int OKEANIBKIKK = 0;
			for (int i = 0; i < GPKEKMAKNFP.Length; i++)
			{
				if (m_inputSource == MCAFEPOCEPL.Text && GPKEKMAKNFP[i] == '\\' && GPKEKMAKNFP.Length > i + 1)
				{
					switch (GPKEKMAKNFP[i + 1])
					{
					case 'U':
						if (GPKEKMAKNFP.Length > i + 9)
						{
							if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
							{
								ENHDMJFBIHL(ref NKFDJBODBDF);
							}
							NKFDJBODBDF[OKEANIBKIKK] = LDCNILFACEE(i + 2);
							i += 9;
							OKEANIBKIKK++;
							continue;
						}
						break;
					case '\\':
						if (!m_parseCtrlCharacters || GPKEKMAKNFP.Length <= i + 2)
						{
							break;
						}
						if (OKEANIBKIKK + 2 > NKFDJBODBDF.Length)
						{
							ENHDMJFBIHL(ref NKFDJBODBDF);
						}
						NKFDJBODBDF[OKEANIBKIKK] = GPKEKMAKNFP[i + 1];
						NKFDJBODBDF[OKEANIBKIKK + 1] = GPKEKMAKNFP[i + 2];
						i += 2;
						OKEANIBKIKK += 2;
						continue;
					case 'n':
						if (!m_parseCtrlCharacters)
						{
							break;
						}
						if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
						{
							ENHDMJFBIHL(ref NKFDJBODBDF);
						}
						NKFDJBODBDF[OKEANIBKIKK] = 10;
						i++;
						OKEANIBKIKK++;
						continue;
					case 'r':
						if (!m_parseCtrlCharacters)
						{
							break;
						}
						if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
						{
							ENHDMJFBIHL(ref NKFDJBODBDF);
						}
						NKFDJBODBDF[OKEANIBKIKK] = 13;
						i++;
						OKEANIBKIKK++;
						continue;
					case 't':
						if (!m_parseCtrlCharacters)
						{
							break;
						}
						if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
						{
							ENHDMJFBIHL(ref NKFDJBODBDF);
						}
						NKFDJBODBDF[OKEANIBKIKK] = 9;
						i++;
						OKEANIBKIKK++;
						continue;
					case 'u':
						if (GPKEKMAKNFP.Length > i + 5)
						{
							if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
							{
								ENHDMJFBIHL(ref NKFDJBODBDF);
							}
							NKFDJBODBDF[OKEANIBKIKK] = (ushort)PDCBOFAOJBE(i + 2);
							i += 5;
							OKEANIBKIKK++;
							continue;
						}
						break;
					}
				}
				try
				{
					if (char.IsHighSurrogate(GPKEKMAKNFP[i]) && char.IsLowSurrogate(GPKEKMAKNFP[i + 1]))
					{
						if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
						{
							ENHDMJFBIHL(ref NKFDJBODBDF);
						}
						NKFDJBODBDF[OKEANIBKIKK] = char.ConvertToUtf32(GPKEKMAKNFP[i], GPKEKMAKNFP[i + 1]);
						i++;
						OKEANIBKIKK++;
						continue;
					}
				}
				catch (Exception)
				{
					continue;
				}
				if (GPKEKMAKNFP[i] == '<' && m_isRichText)
				{
					if (JAIDMFJFDEJ(ref GPKEKMAKNFP, "<BR>", i))
					{
						if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
						{
							ENHDMJFBIHL(ref NKFDJBODBDF);
						}
						NKFDJBODBDF[OKEANIBKIKK] = 10;
						OKEANIBKIKK++;
						i += 3;
						continue;
					}
					if (JAIDMFJFDEJ(ref GPKEKMAKNFP, "<STYLE=", i))
					{
						int NEAJDKHHNMI = 0;
						if (LKLLHBGMIBI(ref GPKEKMAKNFP, i, out NEAJDKHHNMI, ref NKFDJBODBDF, ref OKEANIBKIKK))
						{
							i = NEAJDKHHNMI;
							continue;
						}
					}
					else if (JAIDMFJFDEJ(ref GPKEKMAKNFP, "</STYLE>", i))
					{
						LJDLKAPKDOA(ref GPKEKMAKNFP, i, ref NKFDJBODBDF, ref OKEANIBKIKK);
						i += 7;
						continue;
					}
				}
				if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
				{
					ENHDMJFBIHL(ref NKFDJBODBDF);
				}
				NKFDJBODBDF[OKEANIBKIKK] = GPKEKMAKNFP[i];
				OKEANIBKIKK++;
			}
			if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
			{
				ENHDMJFBIHL(ref NKFDJBODBDF);
			}
			NKFDJBODBDF[OKEANIBKIKK] = 0;
		}

		protected void DFMFAOJEMEE(StringBuilder GPKEKMAKNFP, ref int[] NKFDJBODBDF)
		{
			if (GPKEKMAKNFP == null)
			{
				NKFDJBODBDF[0] = 0;
				return;
			}
			LHDBHJFCEKJ.BOPEPLONIFL();
			int OKEANIBKIKK = 0;
			for (int i = 0; i < GPKEKMAKNFP.Length; i++)
			{
				if (m_parseCtrlCharacters && GPKEKMAKNFP[i] == '\\' && GPKEKMAKNFP.Length > i + 1)
				{
					switch (GPKEKMAKNFP[i + 1])
					{
					case 'U':
						if (GPKEKMAKNFP.Length > i + 9)
						{
							if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
							{
								ENHDMJFBIHL(ref NKFDJBODBDF);
							}
							NKFDJBODBDF[OKEANIBKIKK] = LDCNILFACEE(i + 2);
							i += 9;
							OKEANIBKIKK++;
							continue;
						}
						break;
					case '\\':
						if (GPKEKMAKNFP.Length <= i + 2)
						{
							break;
						}
						if (OKEANIBKIKK + 2 > NKFDJBODBDF.Length)
						{
							ENHDMJFBIHL(ref NKFDJBODBDF);
						}
						NKFDJBODBDF[OKEANIBKIKK] = GPKEKMAKNFP[i + 1];
						NKFDJBODBDF[OKEANIBKIKK + 1] = GPKEKMAKNFP[i + 2];
						i += 2;
						OKEANIBKIKK += 2;
						continue;
					case 'n':
						if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
						{
							ENHDMJFBIHL(ref NKFDJBODBDF);
						}
						NKFDJBODBDF[OKEANIBKIKK] = 10;
						i++;
						OKEANIBKIKK++;
						continue;
					case 'r':
						if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
						{
							ENHDMJFBIHL(ref NKFDJBODBDF);
						}
						NKFDJBODBDF[OKEANIBKIKK] = 13;
						i++;
						OKEANIBKIKK++;
						continue;
					case 't':
						if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
						{
							ENHDMJFBIHL(ref NKFDJBODBDF);
						}
						NKFDJBODBDF[OKEANIBKIKK] = 9;
						i++;
						OKEANIBKIKK++;
						continue;
					case 'u':
						if (GPKEKMAKNFP.Length > i + 5)
						{
							if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
							{
								ENHDMJFBIHL(ref NKFDJBODBDF);
							}
							NKFDJBODBDF[OKEANIBKIKK] = (ushort)PDCBOFAOJBE(i + 2);
							i += 5;
							OKEANIBKIKK++;
							continue;
						}
						break;
					}
				}
				if (char.IsHighSurrogate(GPKEKMAKNFP[i]) && char.IsLowSurrogate(GPKEKMAKNFP[i + 1]))
				{
					if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
					{
						ENHDMJFBIHL(ref NKFDJBODBDF);
					}
					NKFDJBODBDF[OKEANIBKIKK] = char.ConvertToUtf32(GPKEKMAKNFP[i], GPKEKMAKNFP[i + 1]);
					i++;
					OKEANIBKIKK++;
					continue;
				}
				if (GPKEKMAKNFP[i] == '<')
				{
					if (JAIDMFJFDEJ(ref GPKEKMAKNFP, "<BR>", i))
					{
						if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
						{
							ENHDMJFBIHL(ref NKFDJBODBDF);
						}
						NKFDJBODBDF[OKEANIBKIKK] = 10;
						OKEANIBKIKK++;
						i += 3;
						continue;
					}
					if (JAIDMFJFDEJ(ref GPKEKMAKNFP, "<STYLE=", i))
					{
						int NEAJDKHHNMI = 0;
						if (LKLLHBGMIBI(ref GPKEKMAKNFP, i, out NEAJDKHHNMI, ref NKFDJBODBDF, ref OKEANIBKIKK))
						{
							i = NEAJDKHHNMI;
							continue;
						}
					}
					else if (JAIDMFJFDEJ(ref GPKEKMAKNFP, "</STYLE>", i))
					{
						LJDLKAPKDOA(ref GPKEKMAKNFP, i, ref NKFDJBODBDF, ref OKEANIBKIKK);
						i += 7;
						continue;
					}
				}
				if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
				{
					ENHDMJFBIHL(ref NKFDJBODBDF);
				}
				NKFDJBODBDF[OKEANIBKIKK] = GPKEKMAKNFP[i];
				OKEANIBKIKK++;
			}
			if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
			{
				ENHDMJFBIHL(ref NKFDJBODBDF);
			}
			NKFDJBODBDF[OKEANIBKIKK] = 0;
		}

		private bool LKLLHBGMIBI(ref string GPKEKMAKNFP, int LPOANJMPJMG, out int NEAJDKHHNMI, ref int[] NKFDJBODBDF, ref int OKEANIBKIKK)
		{
			int cKFJKOFGBOL = AMKJEFOJJNP(ref GPKEKMAKNFP, LPOANJMPJMG + 7, out NEAJDKHHNMI);
			TMP_Style tMP_Style = TMP_StyleSheet.FGGDPFBGNFP(cKFJKOFGBOL);
			if (tMP_Style == null || NEAJDKHHNMI == 0)
			{
				return false;
			}
			LHDBHJFCEKJ.JEACJNAKLDJ(tMP_Style.hashCode);
			int num = tMP_Style.styleOpeningTagArray.Length;
			int[] FCJBBPHFNPJ = tMP_Style.styleOpeningTagArray;
			for (int i = 0; i < num; i++)
			{
				int num2 = FCJBBPHFNPJ[i];
				if (num2 == 60)
				{
					if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "<BR>", i))
					{
						if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
						{
							ENHDMJFBIHL(ref NKFDJBODBDF);
						}
						NKFDJBODBDF[OKEANIBKIKK] = 10;
						OKEANIBKIKK++;
						i += 3;
						continue;
					}
					if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "<STYLE=", i))
					{
						int NEAJDKHHNMI2 = 0;
						if (LKLLHBGMIBI(ref FCJBBPHFNPJ, i, out NEAJDKHHNMI2, ref NKFDJBODBDF, ref OKEANIBKIKK))
						{
							i = NEAJDKHHNMI2;
							continue;
						}
					}
					else if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "</STYLE>", i))
					{
						LJDLKAPKDOA(ref FCJBBPHFNPJ, i, ref NKFDJBODBDF, ref OKEANIBKIKK);
						i += 7;
						continue;
					}
				}
				if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
				{
					ENHDMJFBIHL(ref NKFDJBODBDF);
				}
				NKFDJBODBDF[OKEANIBKIKK] = num2;
				OKEANIBKIKK++;
			}
			return true;
		}

		private bool LKLLHBGMIBI(ref int[] GPKEKMAKNFP, int LPOANJMPJMG, out int NEAJDKHHNMI, ref int[] NKFDJBODBDF, ref int OKEANIBKIKK)
		{
			int cKFJKOFGBOL = AMKJEFOJJNP(ref GPKEKMAKNFP, LPOANJMPJMG + 7, out NEAJDKHHNMI);
			TMP_Style tMP_Style = TMP_StyleSheet.FGGDPFBGNFP(cKFJKOFGBOL);
			if (tMP_Style == null || NEAJDKHHNMI == 0)
			{
				return false;
			}
			LHDBHJFCEKJ.JEACJNAKLDJ(tMP_Style.hashCode);
			int num = tMP_Style.styleOpeningTagArray.Length;
			int[] FCJBBPHFNPJ = tMP_Style.styleOpeningTagArray;
			for (int i = 0; i < num; i++)
			{
				int num2 = FCJBBPHFNPJ[i];
				if (num2 == 60)
				{
					if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "<BR>", i))
					{
						if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
						{
							ENHDMJFBIHL(ref NKFDJBODBDF);
						}
						NKFDJBODBDF[OKEANIBKIKK] = 10;
						OKEANIBKIKK++;
						i += 3;
						continue;
					}
					if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "<STYLE=", i))
					{
						int NEAJDKHHNMI2 = 0;
						if (LKLLHBGMIBI(ref FCJBBPHFNPJ, i, out NEAJDKHHNMI2, ref NKFDJBODBDF, ref OKEANIBKIKK))
						{
							i = NEAJDKHHNMI2;
							continue;
						}
					}
					else if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "</STYLE>", i))
					{
						LJDLKAPKDOA(ref FCJBBPHFNPJ, i, ref NKFDJBODBDF, ref OKEANIBKIKK);
						i += 7;
						continue;
					}
				}
				if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
				{
					ENHDMJFBIHL(ref NKFDJBODBDF);
				}
				NKFDJBODBDF[OKEANIBKIKK] = num2;
				OKEANIBKIKK++;
			}
			return true;
		}

		private bool LKLLHBGMIBI(ref char[] GPKEKMAKNFP, int LPOANJMPJMG, out int NEAJDKHHNMI, ref int[] NKFDJBODBDF, ref int OKEANIBKIKK)
		{
			int cKFJKOFGBOL = AMKJEFOJJNP(ref GPKEKMAKNFP, LPOANJMPJMG + 7, out NEAJDKHHNMI);
			TMP_Style tMP_Style = TMP_StyleSheet.FGGDPFBGNFP(cKFJKOFGBOL);
			if (tMP_Style == null || NEAJDKHHNMI == 0)
			{
				return false;
			}
			LHDBHJFCEKJ.JEACJNAKLDJ(tMP_Style.hashCode);
			int num = tMP_Style.styleOpeningTagArray.Length;
			int[] FCJBBPHFNPJ = tMP_Style.styleOpeningTagArray;
			for (int i = 0; i < num; i++)
			{
				int num2 = FCJBBPHFNPJ[i];
				if (num2 == 60)
				{
					if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "<BR>", i))
					{
						if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
						{
							ENHDMJFBIHL(ref NKFDJBODBDF);
						}
						NKFDJBODBDF[OKEANIBKIKK] = 10;
						OKEANIBKIKK++;
						i += 3;
						continue;
					}
					if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "<STYLE=", i))
					{
						int NEAJDKHHNMI2 = 0;
						if (LKLLHBGMIBI(ref FCJBBPHFNPJ, i, out NEAJDKHHNMI2, ref NKFDJBODBDF, ref OKEANIBKIKK))
						{
							i = NEAJDKHHNMI2;
							continue;
						}
					}
					else if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "</STYLE>", i))
					{
						LJDLKAPKDOA(ref FCJBBPHFNPJ, i, ref NKFDJBODBDF, ref OKEANIBKIKK);
						i += 7;
						continue;
					}
				}
				if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
				{
					ENHDMJFBIHL(ref NKFDJBODBDF);
				}
				NKFDJBODBDF[OKEANIBKIKK] = num2;
				OKEANIBKIKK++;
			}
			return true;
		}

		private bool LKLLHBGMIBI(ref StringBuilder GPKEKMAKNFP, int LPOANJMPJMG, out int NEAJDKHHNMI, ref int[] NKFDJBODBDF, ref int OKEANIBKIKK)
		{
			int cKFJKOFGBOL = AMKJEFOJJNP(ref GPKEKMAKNFP, LPOANJMPJMG + 7, out NEAJDKHHNMI);
			TMP_Style tMP_Style = TMP_StyleSheet.FGGDPFBGNFP(cKFJKOFGBOL);
			if (tMP_Style == null || NEAJDKHHNMI == 0)
			{
				return false;
			}
			LHDBHJFCEKJ.JEACJNAKLDJ(tMP_Style.hashCode);
			int num = tMP_Style.styleOpeningTagArray.Length;
			int[] FCJBBPHFNPJ = tMP_Style.styleOpeningTagArray;
			for (int i = 0; i < num; i++)
			{
				int num2 = FCJBBPHFNPJ[i];
				if (num2 == 60)
				{
					if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "<BR>", i))
					{
						if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
						{
							ENHDMJFBIHL(ref NKFDJBODBDF);
						}
						NKFDJBODBDF[OKEANIBKIKK] = 10;
						OKEANIBKIKK++;
						i += 3;
						continue;
					}
					if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "<STYLE=", i))
					{
						int NEAJDKHHNMI2 = 0;
						if (LKLLHBGMIBI(ref FCJBBPHFNPJ, i, out NEAJDKHHNMI2, ref NKFDJBODBDF, ref OKEANIBKIKK))
						{
							i = NEAJDKHHNMI2;
							continue;
						}
					}
					else if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "</STYLE>", i))
					{
						LJDLKAPKDOA(ref FCJBBPHFNPJ, i, ref NKFDJBODBDF, ref OKEANIBKIKK);
						i += 7;
						continue;
					}
				}
				if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
				{
					ENHDMJFBIHL(ref NKFDJBODBDF);
				}
				NKFDJBODBDF[OKEANIBKIKK] = num2;
				OKEANIBKIKK++;
			}
			return true;
		}

		private bool LJDLKAPKDOA(ref string GPKEKMAKNFP, int LPOANJMPJMG, ref int[] NKFDJBODBDF, ref int OKEANIBKIKK)
		{
			int cKFJKOFGBOL = LHDBHJFCEKJ.LBFCDKPCDPB();
			TMP_Style tMP_Style = TMP_StyleSheet.FGGDPFBGNFP(cKFJKOFGBOL);
			LHDBHJFCEKJ.CJOHLENDJGO();
			if (tMP_Style == null)
			{
				return false;
			}
			int num = tMP_Style.styleClosingTagArray.Length;
			int[] FCJBBPHFNPJ = tMP_Style.styleClosingTagArray;
			for (int i = 0; i < num; i++)
			{
				int num2 = FCJBBPHFNPJ[i];
				if (num2 == 60)
				{
					if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "<BR>", i))
					{
						if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
						{
							ENHDMJFBIHL(ref NKFDJBODBDF);
						}
						NKFDJBODBDF[OKEANIBKIKK] = 10;
						OKEANIBKIKK++;
						i += 3;
						continue;
					}
					if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "<STYLE=", i))
					{
						int NEAJDKHHNMI = 0;
						if (LKLLHBGMIBI(ref FCJBBPHFNPJ, i, out NEAJDKHHNMI, ref NKFDJBODBDF, ref OKEANIBKIKK))
						{
							i = NEAJDKHHNMI;
							continue;
						}
					}
					else if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "</STYLE>", i))
					{
						LJDLKAPKDOA(ref FCJBBPHFNPJ, i, ref NKFDJBODBDF, ref OKEANIBKIKK);
						i += 7;
						continue;
					}
				}
				if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
				{
					ENHDMJFBIHL(ref NKFDJBODBDF);
				}
				NKFDJBODBDF[OKEANIBKIKK] = num2;
				OKEANIBKIKK++;
			}
			return true;
		}

		private bool LJDLKAPKDOA(ref int[] GPKEKMAKNFP, int LPOANJMPJMG, ref int[] NKFDJBODBDF, ref int OKEANIBKIKK)
		{
			int cKFJKOFGBOL = LHDBHJFCEKJ.LBFCDKPCDPB();
			TMP_Style tMP_Style = TMP_StyleSheet.FGGDPFBGNFP(cKFJKOFGBOL);
			LHDBHJFCEKJ.CJOHLENDJGO();
			if (tMP_Style == null)
			{
				return false;
			}
			int num = tMP_Style.styleClosingTagArray.Length;
			int[] FCJBBPHFNPJ = tMP_Style.styleClosingTagArray;
			for (int i = 0; i < num; i++)
			{
				int num2 = FCJBBPHFNPJ[i];
				if (num2 == 60)
				{
					if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "<BR>", i))
					{
						if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
						{
							ENHDMJFBIHL(ref NKFDJBODBDF);
						}
						NKFDJBODBDF[OKEANIBKIKK] = 10;
						OKEANIBKIKK++;
						i += 3;
						continue;
					}
					if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "<STYLE=", i))
					{
						int NEAJDKHHNMI = 0;
						if (LKLLHBGMIBI(ref FCJBBPHFNPJ, i, out NEAJDKHHNMI, ref NKFDJBODBDF, ref OKEANIBKIKK))
						{
							i = NEAJDKHHNMI;
							continue;
						}
					}
					else if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "</STYLE>", i))
					{
						LJDLKAPKDOA(ref FCJBBPHFNPJ, i, ref NKFDJBODBDF, ref OKEANIBKIKK);
						i += 7;
						continue;
					}
				}
				if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
				{
					ENHDMJFBIHL(ref NKFDJBODBDF);
				}
				NKFDJBODBDF[OKEANIBKIKK] = num2;
				OKEANIBKIKK++;
			}
			return true;
		}

		private bool LJDLKAPKDOA(ref char[] GPKEKMAKNFP, int LPOANJMPJMG, ref int[] NKFDJBODBDF, ref int OKEANIBKIKK)
		{
			int cKFJKOFGBOL = LHDBHJFCEKJ.LBFCDKPCDPB();
			TMP_Style tMP_Style = TMP_StyleSheet.FGGDPFBGNFP(cKFJKOFGBOL);
			LHDBHJFCEKJ.CJOHLENDJGO();
			if (tMP_Style == null)
			{
				return false;
			}
			int num = tMP_Style.styleClosingTagArray.Length;
			int[] FCJBBPHFNPJ = tMP_Style.styleClosingTagArray;
			for (int i = 0; i < num; i++)
			{
				int num2 = FCJBBPHFNPJ[i];
				if (num2 == 60)
				{
					if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "<BR>", i))
					{
						if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
						{
							ENHDMJFBIHL(ref NKFDJBODBDF);
						}
						NKFDJBODBDF[OKEANIBKIKK] = 10;
						OKEANIBKIKK++;
						i += 3;
						continue;
					}
					if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "<STYLE=", i))
					{
						int NEAJDKHHNMI = 0;
						if (LKLLHBGMIBI(ref FCJBBPHFNPJ, i, out NEAJDKHHNMI, ref NKFDJBODBDF, ref OKEANIBKIKK))
						{
							i = NEAJDKHHNMI;
							continue;
						}
					}
					else if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "</STYLE>", i))
					{
						LJDLKAPKDOA(ref FCJBBPHFNPJ, i, ref NKFDJBODBDF, ref OKEANIBKIKK);
						i += 7;
						continue;
					}
				}
				if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
				{
					ENHDMJFBIHL(ref NKFDJBODBDF);
				}
				NKFDJBODBDF[OKEANIBKIKK] = num2;
				OKEANIBKIKK++;
			}
			return true;
		}

		private bool LJDLKAPKDOA(ref StringBuilder GPKEKMAKNFP, int LPOANJMPJMG, ref int[] NKFDJBODBDF, ref int OKEANIBKIKK)
		{
			int cKFJKOFGBOL = LHDBHJFCEKJ.LBFCDKPCDPB();
			TMP_Style tMP_Style = TMP_StyleSheet.FGGDPFBGNFP(cKFJKOFGBOL);
			LHDBHJFCEKJ.CJOHLENDJGO();
			if (tMP_Style == null)
			{
				return false;
			}
			int num = tMP_Style.styleClosingTagArray.Length;
			int[] FCJBBPHFNPJ = tMP_Style.styleClosingTagArray;
			for (int i = 0; i < num; i++)
			{
				int num2 = FCJBBPHFNPJ[i];
				if (num2 == 60)
				{
					if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "<BR>", i))
					{
						if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
						{
							ENHDMJFBIHL(ref NKFDJBODBDF);
						}
						NKFDJBODBDF[OKEANIBKIKK] = 10;
						OKEANIBKIKK++;
						i += 3;
						continue;
					}
					if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "<STYLE=", i))
					{
						int NEAJDKHHNMI = 0;
						if (LKLLHBGMIBI(ref FCJBBPHFNPJ, i, out NEAJDKHHNMI, ref NKFDJBODBDF, ref OKEANIBKIKK))
						{
							i = NEAJDKHHNMI;
							continue;
						}
					}
					else if (JAIDMFJFDEJ(ref FCJBBPHFNPJ, "</STYLE>", i))
					{
						LJDLKAPKDOA(ref FCJBBPHFNPJ, i, ref NKFDJBODBDF, ref OKEANIBKIKK);
						i += 7;
						continue;
					}
				}
				if (OKEANIBKIKK + 1 > NKFDJBODBDF.Length)
				{
					ENHDMJFBIHL(ref NKFDJBODBDF);
				}
				NKFDJBODBDF[OKEANIBKIKK] = num2;
				OKEANIBKIKK++;
			}
			return true;
		}

		private bool JAIDMFJFDEJ(ref string FCJBBPHFNPJ, string MOKLDCMGFFB, int EHJNMODJEAN)
		{
			if (FCJBBPHFNPJ.Length < EHJNMODJEAN + MOKLDCMGFFB.Length)
			{
				return false;
			}
			for (int i = 0; i < MOKLDCMGFFB.Length; i++)
			{
				if (LBOEJMDHOEP.JNAMKIOPJCE(FCJBBPHFNPJ[EHJNMODJEAN + i]) != MOKLDCMGFFB[i])
				{
					return false;
				}
			}
			return true;
		}

		private bool JAIDMFJFDEJ(ref char[] FCJBBPHFNPJ, string MOKLDCMGFFB, int EHJNMODJEAN)
		{
			if (FCJBBPHFNPJ.Length < EHJNMODJEAN + MOKLDCMGFFB.Length)
			{
				return false;
			}
			for (int i = 0; i < MOKLDCMGFFB.Length; i++)
			{
				if (LBOEJMDHOEP.JNAMKIOPJCE(FCJBBPHFNPJ[EHJNMODJEAN + i]) != MOKLDCMGFFB[i])
				{
					return false;
				}
			}
			return true;
		}

		private bool JAIDMFJFDEJ(ref int[] FCJBBPHFNPJ, string MOKLDCMGFFB, int EHJNMODJEAN)
		{
			if (FCJBBPHFNPJ.Length < EHJNMODJEAN + MOKLDCMGFFB.Length)
			{
				return false;
			}
			for (int i = 0; i < MOKLDCMGFFB.Length; i++)
			{
				if (LBOEJMDHOEP.JNAMKIOPJCE((char)FCJBBPHFNPJ[EHJNMODJEAN + i]) != MOKLDCMGFFB[i])
				{
					return false;
				}
			}
			return true;
		}

		private bool JAIDMFJFDEJ(ref StringBuilder FCJBBPHFNPJ, string MOKLDCMGFFB, int EHJNMODJEAN)
		{
			if (FCJBBPHFNPJ.Length < EHJNMODJEAN + MOKLDCMGFFB.Length)
			{
				return false;
			}
			for (int i = 0; i < MOKLDCMGFFB.Length; i++)
			{
				if (LBOEJMDHOEP.JNAMKIOPJCE(FCJBBPHFNPJ[EHJNMODJEAN + i]) != MOKLDCMGFFB[i])
				{
					return false;
				}
			}
			return true;
		}

		private int AMKJEFOJJNP(ref string FCJBBPHFNPJ, int EHJNMODJEAN, out int CIPJMBFJAGD)
		{
			int num = 0;
			CIPJMBFJAGD = 0;
			for (int i = EHJNMODJEAN; i < FCJBBPHFNPJ.Length; i++)
			{
				if (FCJBBPHFNPJ[i] != '"')
				{
					if (FCJBBPHFNPJ[i] == '>')
					{
						CIPJMBFJAGD = i;
						break;
					}
					num = ((num << 5) + num) ^ FCJBBPHFNPJ[i];
				}
			}
			return num;
		}

		private int AMKJEFOJJNP(ref char[] FCJBBPHFNPJ, int EHJNMODJEAN, out int CIPJMBFJAGD)
		{
			int num = 0;
			CIPJMBFJAGD = 0;
			for (int i = EHJNMODJEAN; i < FCJBBPHFNPJ.Length; i++)
			{
				if (FCJBBPHFNPJ[i] != '"')
				{
					if (FCJBBPHFNPJ[i] == '>')
					{
						CIPJMBFJAGD = i;
						break;
					}
					num = ((num << 5) + num) ^ FCJBBPHFNPJ[i];
				}
			}
			return num;
		}

		private int AMKJEFOJJNP(ref int[] FCJBBPHFNPJ, int EHJNMODJEAN, out int CIPJMBFJAGD)
		{
			int num = 0;
			CIPJMBFJAGD = 0;
			for (int i = EHJNMODJEAN; i < FCJBBPHFNPJ.Length; i++)
			{
				if (FCJBBPHFNPJ[i] != 34)
				{
					if (FCJBBPHFNPJ[i] == 62)
					{
						CIPJMBFJAGD = i;
						break;
					}
					num = ((num << 5) + num) ^ FCJBBPHFNPJ[i];
				}
			}
			return num;
		}

		private int AMKJEFOJJNP(ref StringBuilder FCJBBPHFNPJ, int EHJNMODJEAN, out int CIPJMBFJAGD)
		{
			int num = 0;
			CIPJMBFJAGD = 0;
			for (int i = EHJNMODJEAN; i < FCJBBPHFNPJ.Length; i++)
			{
				if (FCJBBPHFNPJ[i] != '"')
				{
					if (FCJBBPHFNPJ[i] == '>')
					{
						CIPJMBFJAGD = i;
						break;
					}
					num = ((num << 5) + num) ^ FCJBBPHFNPJ[i];
				}
			}
			return num;
		}

		private void ENHDMJFBIHL<T>(ref T[] KDOGMDCDCEN)
		{
			int newSize = Mathf.NextPowerOfTwo(KDOGMDCDCEN.Length + 1);
			Array.Resize(ref KDOGMDCDCEN, newSize);
		}

		protected void AGACDBMPHJI(float CFEHLBIDFCG, ref int EHJNMODJEAN, int LBNBDDMJDEE)
		{
			if (CFEHLBIDFCG < 0f)
			{
				IEBABBDAELJ[EHJNMODJEAN++] = '-';
				CFEHLBIDFCG = 0f - CFEHLBIDFCG;
			}
			CFEHLBIDFCG += BNHNMAALCMM[Mathf.Min(9, LBNBDDMJDEE)];
			int num = (int)CFEHLBIDFCG;
			INPNMEPLDLC(num, ref EHJNMODJEAN, LBNBDDMJDEE);
			if (LBNBDDMJDEE > 0)
			{
				IEBABBDAELJ[EHJNMODJEAN++] = '.';
				CFEHLBIDFCG -= (float)num;
				for (int i = 0; i < LBNBDDMJDEE; i++)
				{
					CFEHLBIDFCG *= 10f;
					int num2 = (int)CFEHLBIDFCG;
					IEBABBDAELJ[EHJNMODJEAN++] = (char)(num2 + 48);
					CFEHLBIDFCG -= (float)num2;
				}
			}
		}

		protected void INPNMEPLDLC(int CFEHLBIDFCG, ref int EHJNMODJEAN, int LBNBDDMJDEE)
		{
			if (CFEHLBIDFCG < 0)
			{
				IEBABBDAELJ[EHJNMODJEAN++] = '-';
				CFEHLBIDFCG = -CFEHLBIDFCG;
			}
			int num = EHJNMODJEAN;
			do
			{
				IEBABBDAELJ[num++] = (char)(CFEHLBIDFCG % 10 + 48);
				CFEHLBIDFCG /= 10;
			}
			while (CFEHLBIDFCG > 0);
			int num2 = num;
			while (EHJNMODJEAN + 1 < num)
			{
				num--;
				char c = IEBABBDAELJ[EHJNMODJEAN];
				IEBABBDAELJ[EHJNMODJEAN] = IEBABBDAELJ[num];
				IEBABBDAELJ[num] = c;
				EHJNMODJEAN++;
			}
			EHJNMODJEAN = num2;
		}

		protected virtual int JAADOMGCOHA(int[] FBPAOINOCHI)
		{
			return 0;
		}

		protected virtual void DLIBNLFHMKF()
		{
		}

		public Vector2 GetPreferredValues()
		{
			if (m_isInputParsingRequired || OHEPFDPOBOF)
			{
				CEOCLEMDMEE = true;
				GJKICJDAIIH();
			}
			float x = HNKGNKGIBOB();
			float y = PMDDOMPJDPA();
			return new Vector2(x, y);
		}

		public Vector2 GetPreferredValues(float HHHMOGOKFHF, float JKNPBEOPMPK)
		{
			if (m_isInputParsingRequired || OHEPFDPOBOF)
			{
				CEOCLEMDMEE = true;
				GJKICJDAIIH();
			}
			Vector2 pNACILIBDDF = new Vector2(HHHMOGOKFHF, JKNPBEOPMPK);
			float x = HNKGNKGIBOB(pNACILIBDDF);
			float y = PMDDOMPJDPA(pNACILIBDDF);
			return new Vector2(x, y);
		}

		public Vector2 GetPreferredValues(string FCJBBPHFNPJ)
		{
			CEOCLEMDMEE = true;
			PDENOOPDPEN(FCJBBPHFNPJ, ref GMALEIECAPN);
			JAADOMGCOHA(GMALEIECAPN);
			Vector2 bOAMBILHDEN = BOAMBILHDEN;
			float x = HNKGNKGIBOB(bOAMBILHDEN);
			float y = PMDDOMPJDPA(bOAMBILHDEN);
			return new Vector2(x, y);
		}

		public Vector2 GetPreferredValues(string FCJBBPHFNPJ, float HHHMOGOKFHF, float JKNPBEOPMPK)
		{
			CEOCLEMDMEE = true;
			PDENOOPDPEN(FCJBBPHFNPJ, ref GMALEIECAPN);
			JAADOMGCOHA(GMALEIECAPN);
			Vector2 pNACILIBDDF = new Vector2(HHHMOGOKFHF, JKNPBEOPMPK);
			float x = HNKGNKGIBOB(pNACILIBDDF);
			float y = PMDDOMPJDPA(pNACILIBDDF);
			return new Vector2(x, y);
		}

		protected float HNKGNKGIBOB()
		{
			float hGNPIMGEMIM = ((!m_enableAutoSizing) ? m_fontSize : m_fontSizeMax);
			FOGJMAGABCF = m_fontSizeMin;
			KCNAALADKDH = m_fontSizeMax;
			Vector2 bOAMBILHDEN = BOAMBILHDEN;
			if (m_isInputParsingRequired || OHEPFDPOBOF)
			{
				CEOCLEMDMEE = true;
				GJKICJDAIIH();
			}
			IAELOBCAKJO = 0;
			float x = EPGGGJGKBGH(hGNPIMGEMIM, bOAMBILHDEN, true).x;
			IKDPKCPAGOC = false;
			return x;
		}

		protected float HNKGNKGIBOB(Vector2 PNACILIBDDF)
		{
			float hGNPIMGEMIM = ((!m_enableAutoSizing) ? m_fontSize : m_fontSizeMax);
			FOGJMAGABCF = m_fontSizeMin;
			KCNAALADKDH = m_fontSizeMax;
			IAELOBCAKJO = 0;
			return EPGGGJGKBGH(hGNPIMGEMIM, PNACILIBDDF, true).x;
		}

		protected float PMDDOMPJDPA()
		{
			float hGNPIMGEMIM = ((!m_enableAutoSizing) ? m_fontSize : m_fontSizeMax);
			FOGJMAGABCF = m_fontSizeMin;
			KCNAALADKDH = m_fontSizeMax;
			Vector2 fHIAOCPKPMM = new Vector2((IOOMPCBBCNK == 0f) ? FEBIFNLEHEG : IOOMPCBBCNK, FEBIFNLEHEG);
			if (m_isInputParsingRequired || OHEPFDPOBOF)
			{
				CEOCLEMDMEE = true;
				GJKICJDAIIH();
			}
			IAELOBCAKJO = 0;
			float y = EPGGGJGKBGH(hGNPIMGEMIM, fHIAOCPKPMM, !m_enableAutoSizing).y;
			KJFOCCKAAGA = false;
			return y;
		}

		protected float PMDDOMPJDPA(Vector2 PNACILIBDDF)
		{
			float hGNPIMGEMIM = ((!m_enableAutoSizing) ? m_fontSize : m_fontSizeMax);
			FOGJMAGABCF = m_fontSizeMin;
			KCNAALADKDH = m_fontSizeMax;
			IAELOBCAKJO = 0;
			return EPGGGJGKBGH(hGNPIMGEMIM, PNACILIBDDF, true).y;
		}

		public Vector2 GetRenderedValues()
		{
			return OOANHEKEHDK().size;
		}

		public Vector2 GetRenderedValues(bool FLOKLHPKHCO)
		{
			return OOANHEKEHDK(FLOKLHPKHCO).size;
		}

		protected float NCKIMEPFPMC()
		{
			return GetRenderedValues().x;
		}

		protected float NCKIMEPFPMC(bool FLOKLHPKHCO)
		{
			return GetRenderedValues(FLOKLHPKHCO).x;
		}

		protected float FBBBIKEEOPL()
		{
			return GetRenderedValues().y;
		}

		protected float FBBBIKEEOPL(bool FLOKLHPKHCO)
		{
			return GetRenderedValues(FLOKLHPKHCO).y;
		}

		protected virtual Vector2 EPGGGJGKBGH(float HGNPIMGEMIM, Vector2 FHIAOCPKPMM, bool JJINNCOPJBA)
		{
			if (m_fontAsset == null || m_fontAsset.characterDictionary == null)
			{
				Debug.LogWarning("Can't Generate Mesh! No Font Asset has been assigned to Object ID: " + GetInstanceID());
				return Vector2.zero;
			}
			if (GMALEIECAPN == null || GMALEIECAPN.Length == 0 || GMALEIECAPN[0] == 0)
			{
				return Vector2.zero;
			}
			AFEJPPDMPHE = m_fontAsset;
			JBPPHIKOJPL = m_sharedMaterial;
			AIJEDOAJAPI = 0;
			DBEFOGFNAME.GLLKOHHOLLP(new FMOBJPAGLEE(0, AFEJPPDMPHE, null, JBPPHIKOJPL, IBKCGEGKGNM));
			int kOIMFMFOLII = KOIMFMFOLII;
			if (JGPBECKLALF == null || kOIMFMFOLII > JGPBECKLALF.Length)
			{
				JGPBECKLALF = new MGLLLPMKGDA[(kOIMFMFOLII <= 1024) ? Mathf.NextPowerOfTwo(kOIMFMFOLII) : (kOIMFMFOLII + 256)];
			}
			MEPDJFGMGOK = HGNPIMGEMIM / AFEJPPDMPHE.fontInfo.PointSize * ((!m_isOrthographic) ? 0.1f : 1f);
			GEHMOIPKBGD = 1f;
			float num = HGNPIMGEMIM / m_fontAsset.fontInfo.PointSize * m_fontAsset.fontInfo.Scale * ((!m_isOrthographic) ? 0.1f : 1f);
			float num2 = MEPDJFGMGOK;
			MPIGOGEKIPI = HGNPIMGEMIM;
			FJJAGAJLDJG.GLLKOHHOLLP(MPIGOGEKIPI);
			float num3 = 0f;
			int num4 = 0;
			CCLHEBEBBGN = m_fontStyle;
			FPDOALAOBLE = m_textAlignment;
			IBLGHCLBFJG.GLLKOHHOLLP(FPDOALAOBLE);
			float num5 = 1f;
			HDHGLHPMBPG = 0f;
			GFIDNINNNAL = 0f;
			KODBBLNBFDO = -32767f;
			float num6 = AFEJPPDMPHE.fontInfo.LineHeight - (AFEJPPDMPHE.fontInfo.Ascender - AFEJPPDMPHE.fontInfo.Descender);
			OMGEAPDMJBN = 0f;
			CADPBEPINNM = 0f;
			float num7 = 0f;
			PLALFBMFEEC = 0f;
			float a = 0f;
			KGDNHOEOOHO = 0f;
			GKEHAJKJCEF = 0f;
			BNFNFGGNBGJ.GLLKOHHOLLP(0f);
			FGGFHMLKNJJ = false;
			HEEDOMEABKA = 0;
			MIEJCGGDMLJ = 0;
			NDEAABJECMK = BDOPFJFCOGB;
			ODBAKFJDCCP = FEBIFNLEHEG;
			FGMGAJAPPJC = 0;
			float x = FHIAOCPKPMM.x;
			DPIAMOJPHPK = 0f;
			EPPLBJGIFEM = 0f;
			IFAFCDFNNJN = -1f;
			float num8 = 0f;
			float num9 = 0f;
			float num10 = 0f;
			CEOCLEMDMEE = true;
			MJMNGPIFHGG = 0f;
			ONHFBKLHJIN = 0f;
			bool flag = true;
			bool flag2 = false;
			LAGHBLJIEME BGEDKGLJIGM = default(LAGHBLJIEME);
			LLBAPJLPCAN(ref BGEDKGLJIGM, 0, 0);
			LAGHBLJIEME BGEDKGLJIGM2 = default(LAGHBLJIEME);
			int num11 = 0;
			IAELOBCAKJO++;
			int OKEFBABJGLB = 0;
			for (int i = 0; GMALEIECAPN[i] != 0; i++)
			{
				num4 = GMALEIECAPN[i];
				FHJFKDGNODI = m_textInfo.characterInfo[HEEDOMEABKA].MGBPNBKJOJL;
				AIJEDOAJAPI = m_textInfo.characterInfo[HEEDOMEABKA].EKBHGEBCJHL;
				AFEJPPDMPHE = NDPGMAPHNNA[AIJEDOAJAPI].PIJNMJOHBIE;
				int aIJEDOAJAPI = AIJEDOAJAPI;
				if (m_isRichText && num4 == 60)
				{
					OHKANPJHAFP = true;
					FHJFKDGNODI = HIPDBPNMONO.Character;
					if (ACLAAHPAFMI(GMALEIECAPN, i + 1, out OKEFBABJGLB))
					{
						i = OKEFBABJGLB;
						if (FHJFKDGNODI == HIPDBPNMONO.Character)
						{
							continue;
						}
					}
				}
				OHKANPJHAFP = false;
				bool nKAJACJKPCM = m_textInfo.characterInfo[HEEDOMEABKA].NKAJACJKPCM;
				float num12 = 1f;
				if (FHJFKDGNODI == HIPDBPNMONO.Character)
				{
					if ((CCLHEBEBBGN & BCIEOOJOMDO.UpperCase) == BCIEOOJOMDO.UpperCase)
					{
						if (char.IsLower((char)num4))
						{
							num4 = char.ToUpper((char)num4);
						}
					}
					else if ((CCLHEBEBBGN & BCIEOOJOMDO.LowerCase) == BCIEOOJOMDO.LowerCase)
					{
						if (char.IsUpper((char)num4))
						{
							num4 = char.ToLower((char)num4);
						}
					}
					else if (((m_fontStyle & BCIEOOJOMDO.SmallCaps) == BCIEOOJOMDO.SmallCaps || (CCLHEBEBBGN & BCIEOOJOMDO.SmallCaps) == BCIEOOJOMDO.SmallCaps) && char.IsLower((char)num4))
					{
						num12 = 0.8f;
						num4 = char.ToUpper((char)num4);
					}
				}
				if (FHJFKDGNODI == HIPDBPNMONO.Sprite)
				{
					HBLKKCJHFFK = m_textInfo.characterInfo[HEEDOMEABKA].GKDEMJDOOLB;
					OOIILNOMGIL = m_textInfo.characterInfo[HEEDOMEABKA].JDMPHFEHPCI;
					TMP_Sprite tMP_Sprite = HBLKKCJHFFK.spriteInfoList[OOIILNOMGIL];
					if (tMP_Sprite == null)
					{
						continue;
					}
					if (num4 == 60)
					{
						num4 = 57344 + OOIILNOMGIL;
					}
					AFEJPPDMPHE = m_fontAsset;
					float num13 = MPIGOGEKIPI / m_fontAsset.fontInfo.PointSize * m_fontAsset.fontInfo.Scale * ((!m_isOrthographic) ? 0.1f : 1f);
					num2 = m_fontAsset.fontInfo.Ascender / tMP_Sprite.height * tMP_Sprite.scale * num13;
					EOLJHINLKLO = tMP_Sprite;
					JGPBECKLALF[HEEDOMEABKA].MGBPNBKJOJL = HIPDBPNMONO.Sprite;
					JGPBECKLALF[HEEDOMEABKA].HJLOCAEAFMJ = num13;
					AIJEDOAJAPI = aIJEDOAJAPI;
				}
				else if (FHJFKDGNODI == HIPDBPNMONO.Character)
				{
					EOLJHINLKLO = m_textInfo.characterInfo[HEEDOMEABKA].EAHALNAKGJP;
					if (EOLJHINLKLO == null)
					{
						continue;
					}
					AIJEDOAJAPI = m_textInfo.characterInfo[HEEDOMEABKA].EKBHGEBCJHL;
					MEPDJFGMGOK = MPIGOGEKIPI * num12 / AFEJPPDMPHE.fontInfo.PointSize * AFEJPPDMPHE.fontInfo.Scale * ((!m_isOrthographic) ? 0.1f : 1f);
					num2 = MEPDJFGMGOK * GEHMOIPKBGD * EOLJHINLKLO.scale;
					JGPBECKLALF[HEEDOMEABKA].MGBPNBKJOJL = HIPDBPNMONO.Character;
				}
				float num14 = num2;
				if (num4 == 173)
				{
					num2 = 0f;
				}
				JGPBECKLALF[HEEDOMEABKA].AONJCHFEHOM = (char)num4;
				if (m_enableKerning && HEEDOMEABKA >= 1)
				{
					int aONJCHFEHOM = JGPBECKLALF[HEEDOMEABKA - 1].AONJCHFEHOM;
					OIMKDKKJDIK oIMKDKKJDIK = new OIMKDKKJDIK(aONJCHFEHOM, num4);
					KerningPair value;
					AFEJPPDMPHE.kerningDictionary.TryGetValue(oIMKDKKJDIK.IKNCPEPOKGJ, out value);
					if (value != null)
					{
						PLALFBMFEEC += value.XadvanceOffset * num2;
					}
				}
				float num15 = 0f;
				if (CADPBEPINNM != 0f)
				{
					num15 = CADPBEPINNM / 2f - (EOLJHINLKLO.width / 2f + EOLJHINLKLO.xOffset) * num2;
					PLALFBMFEEC += num15;
				}
				num5 = ((FHJFKDGNODI != 0 || nKAJACJKPCM || ((CCLHEBEBBGN & BCIEOOJOMDO.Bold) != BCIEOOJOMDO.Bold && (m_fontStyle & BCIEOOJOMDO.Bold) != BCIEOOJOMDO.Bold)) ? 1f : (1f + AFEJPPDMPHE.boldSpacing * 0.01f));
				JGPBECKLALF[HEEDOMEABKA].CGAKKOEPCOG = 0f - GFIDNINNNAL + HDHGLHPMBPG;
				float num16 = AFEJPPDMPHE.fontInfo.Ascender * ((FHJFKDGNODI != 0) ? JGPBECKLALF[HEEDOMEABKA].HJLOCAEAFMJ : num2) + HDHGLHPMBPG;
				JGPBECKLALF[HEEDOMEABKA].MNKFKKODLLM = num16 - GFIDNINNNAL;
				NDEAABJECMK = ((!(num16 > NDEAABJECMK)) ? NDEAABJECMK : num16);
				float num17 = AFEJPPDMPHE.fontInfo.Descender * ((FHJFKDGNODI != 0) ? JGPBECKLALF[HEEDOMEABKA].HJLOCAEAFMJ : num2) + HDHGLHPMBPG;
				float num18 = (JGPBECKLALF[HEEDOMEABKA].CALDBEMMLEA = num17 - GFIDNINNNAL);
				ODBAKFJDCCP = ((!(num17 < ODBAKFJDCCP)) ? ODBAKFJDCCP : num17);
				if ((CCLHEBEBBGN & BCIEOOJOMDO.Subscript) == BCIEOOJOMDO.Subscript || (CCLHEBEBBGN & BCIEOOJOMDO.Superscript) == BCIEOOJOMDO.Superscript)
				{
					float num19 = (num16 - HDHGLHPMBPG) / AFEJPPDMPHE.fontInfo.SubSize;
					num16 = NDEAABJECMK;
					NDEAABJECMK = ((!(num19 > NDEAABJECMK)) ? NDEAABJECMK : num19);
					float num20 = (num17 - HDHGLHPMBPG) / AFEJPPDMPHE.fontInfo.SubSize;
					num17 = ODBAKFJDCCP;
					ODBAKFJDCCP = ((!(num20 < ODBAKFJDCCP)) ? ODBAKFJDCCP : num20);
				}
				if (FGMGAJAPPJC == 0)
				{
					MJMNGPIFHGG = ((!(MJMNGPIFHGG > num16)) ? num16 : MJMNGPIFHGG);
				}
				if (num4 == 9 || (!char.IsWhiteSpace((char)num4) && num4 != 8203) || FHJFKDGNODI == HIPDBPNMONO.Sprite)
				{
					float num21 = ((IFAFCDFNNJN == -1f) ? (x + 0.0001f - DPIAMOJPHPK - EPPLBJGIFEM) : Mathf.Min(x + 0.0001f - DPIAMOJPHPK - EPPLBJGIFEM, IFAFCDFNNJN));
					bool flag3 = (FPDOALAOBLE & (KNOECCJHIDP)16) == (KNOECCJHIDP)16 || (FPDOALAOBLE & (KNOECCJHIDP)8) == (KNOECCJHIDP)8;
					num10 = PLALFBMFEEC + EOLJHINLKLO.xAdvance * ((num4 == 173) ? num14 : num2);
					if (num10 > num21 * ((!flag3) ? 1f : 1.05f))
					{
						if (MHAGENKBNAN && HEEDOMEABKA != MIEJCGGDMLJ)
						{
							if (num11 == BGEDKGLJIGM2.CCDKCOGLFBK || flag)
							{
								if (!CHPJNOEDAFE)
								{
									CHPJNOEDAFE = true;
								}
								else
								{
									flag2 = true;
								}
							}
							i = NACMMBNPFJK(ref BGEDKGLJIGM2);
							num11 = i;
							if (GMALEIECAPN[i] == 173)
							{
								OHEPFDPOBOF = true;
								GMALEIECAPN[i] = 45;
								EPGGGJGKBGH(HGNPIMGEMIM, FHIAOCPKPMM, true);
								return Vector2.zero;
							}
							if (FGMGAJAPPJC > 0 && !OBBKAPGMGCN.ACBFEEBCHCF(NDEAABJECMK, DMKNFOCBDEG) && KODBBLNBFDO == -32767f)
							{
								float num22 = NDEAABJECMK - DMKNFOCBDEG;
								GFIDNINNNAL += num22;
								BGEDKGLJIGM2.BGDIPDPPGOK = GFIDNINNNAL;
								BGEDKGLJIGM2.FBCKCNHPKDH = NDEAABJECMK;
							}
							float num23 = NDEAABJECMK - GFIDNINNNAL;
							float num24 = ODBAKFJDCCP - GFIDNINNNAL;
							ONHFBKLHJIN = ((!(ONHFBKLHJIN < num24)) ? num24 : ONHFBKLHJIN);
							MIEJCGGDMLJ = HEEDOMEABKA;
							num8 += PLALFBMFEEC;
							num9 = ((!m_enableWordWrapping) ? Mathf.Max(num9, num23 - num24) : (MJMNGPIFHGG - ONHFBKLHJIN));
							LLBAPJLPCAN(ref BGEDKGLJIGM, i, HEEDOMEABKA - 1);
							FGMGAJAPPJC++;
							if (KODBBLNBFDO == -32767f)
							{
								float num25 = JGPBECKLALF[HEEDOMEABKA].MNKFKKODLLM - JGPBECKLALF[HEEDOMEABKA].CGAKKOEPCOG;
								num7 = 0f - ODBAKFJDCCP + num25 + (num6 + m_lineSpacing + FNABNBFMNME) * num;
								GFIDNINNNAL += num7;
								DMKNFOCBDEG = num25;
							}
							else
							{
								GFIDNINNNAL += KODBBLNBFDO + m_lineSpacing * num;
							}
							NDEAABJECMK = BDOPFJFCOGB;
							ODBAKFJDCCP = FEBIFNLEHEG;
							PLALFBMFEEC = GKEHAJKJCEF;
							continue;
						}
						if (!JJINNCOPJBA && MPIGOGEKIPI > m_fontSizeMin)
						{
							if (JDKKGHCOCJK < m_charWidthMaxAdj / 100f)
							{
							}
							KCNAALADKDH = MPIGOGEKIPI;
							MPIGOGEKIPI -= Mathf.Max((MPIGOGEKIPI - FOGJMAGABCF) / 2f, 0.05f);
							MPIGOGEKIPI = (float)(int)(Mathf.Max(MPIGOGEKIPI, m_fontSizeMin) * 20f + 0.5f) / 20f;
							if (IAELOBCAKJO > 20)
							{
								return new Vector2(num8, num9);
							}
							return EPGGGJGKBGH(MPIGOGEKIPI, FHIAOCPKPMM, false);
						}
					}
				}
				if (FGMGAJAPPJC > 0 && !OBBKAPGMGCN.ACBFEEBCHCF(NDEAABJECMK, DMKNFOCBDEG) && KODBBLNBFDO == -32767f && !GEGDAJAOKKA)
				{
					float num26 = NDEAABJECMK - DMKNFOCBDEG;
					num18 -= num26;
					GFIDNINNNAL += num26;
					DMKNFOCBDEG += num26;
					BGEDKGLJIGM2.BGDIPDPPGOK = GFIDNINNNAL;
					BGEDKGLJIGM2.FBCKCNHPKDH = DMKNFOCBDEG;
				}
				if (num4 == 9)
				{
					float num27 = AFEJPPDMPHE.fontInfo.TabWidth * num2;
					float num28 = Mathf.Ceil(PLALFBMFEEC / num27) * num27;
					PLALFBMFEEC = ((!(num28 > PLALFBMFEEC)) ? (PLALFBMFEEC + num27) : num28);
				}
				else if (CADPBEPINNM != 0f)
				{
					PLALFBMFEEC += CADPBEPINNM - num15 + (m_characterSpacing + AFEJPPDMPHE.normalSpacingOffset) * num2 + OMGEAPDMJBN;
					if (char.IsWhiteSpace((char)num4) || num4 == 8203)
					{
						PLALFBMFEEC += m_wordSpacing * num2;
					}
				}
				else
				{
					PLALFBMFEEC += (EOLJHINLKLO.xAdvance * num5 + m_characterSpacing + AFEJPPDMPHE.normalSpacingOffset) * num2 + OMGEAPDMJBN;
					if (char.IsWhiteSpace((char)num4) || num4 == 8203)
					{
						PLALFBMFEEC += m_wordSpacing * num2;
					}
				}
				if (num4 == 13)
				{
					a = Mathf.Max(a, num8 + PLALFBMFEEC);
					num8 = 0f;
					PLALFBMFEEC = GKEHAJKJCEF;
				}
				if (num4 == 10 || HEEDOMEABKA == kOIMFMFOLII - 1)
				{
					if (FGMGAJAPPJC > 0 && !OBBKAPGMGCN.ACBFEEBCHCF(NDEAABJECMK, DMKNFOCBDEG) && KODBBLNBFDO == -32767f)
					{
						float num29 = NDEAABJECMK - DMKNFOCBDEG;
						num18 -= num29;
						GFIDNINNNAL += num29;
					}
					float num30 = ODBAKFJDCCP - GFIDNINNNAL;
					ONHFBKLHJIN = ((!(ONHFBKLHJIN < num30)) ? num30 : ONHFBKLHJIN);
					MIEJCGGDMLJ = HEEDOMEABKA + 1;
					if (num4 == 10 && HEEDOMEABKA != kOIMFMFOLII - 1)
					{
						a = Mathf.Max(a, num8 + num10);
						num8 = 0f;
					}
					else
					{
						num8 = Mathf.Max(a, num8 + num10);
					}
					num9 = MJMNGPIFHGG - ONHFBKLHJIN;
					if (num4 == 10)
					{
						LLBAPJLPCAN(ref BGEDKGLJIGM, i, HEEDOMEABKA);
						LLBAPJLPCAN(ref BGEDKGLJIGM2, i, HEEDOMEABKA);
						FGMGAJAPPJC++;
						if (KODBBLNBFDO == -32767f)
						{
							num7 = 0f - ODBAKFJDCCP + num16 + (num6 + m_lineSpacing + m_paragraphSpacing + FNABNBFMNME) * num;
							GFIDNINNNAL += num7;
						}
						else
						{
							GFIDNINNNAL += KODBBLNBFDO + (m_lineSpacing + m_paragraphSpacing) * num;
						}
						NDEAABJECMK = BDOPFJFCOGB;
						ODBAKFJDCCP = FEBIFNLEHEG;
						DMKNFOCBDEG = num16;
						PLALFBMFEEC = KGDNHOEOOHO + GKEHAJKJCEF;
					}
				}
				if (m_enableWordWrapping || m_overflowMode == OLMBEAODAPL.Truncate || m_overflowMode == OLMBEAODAPL.Ellipsis)
				{
					if ((char.IsWhiteSpace((char)num4) || num4 == 8203 || num4 == 45 || num4 == 173) && !PIABLFACDIO && num4 != 160 && num4 != 8209 && num4 != 8239 && num4 != 8288)
					{
						LLBAPJLPCAN(ref BGEDKGLJIGM2, i, HEEDOMEABKA);
						CHPJNOEDAFE = false;
						flag = false;
					}
					else if (((num4 > 4352 && num4 < 4607) || (num4 > 11904 && num4 < 40959) || (num4 > 43360 && num4 < 43391) || (num4 > 44032 && num4 < 55295) || (num4 > 63744 && num4 < 64255) || (num4 > 65072 && num4 < 65103) || (num4 > 65280 && num4 < 65519)) && !PIABLFACDIO)
					{
						if (flag || flag2 || (!TMP_Settings.linebreakingRules.INNIIOIHLLF.ContainsKey(num4) && HEEDOMEABKA < kOIMFMFOLII - 1 && !TMP_Settings.linebreakingRules.GJEMIJJBCOL.ContainsKey(JGPBECKLALF[HEEDOMEABKA + 1].AONJCHFEHOM)))
						{
							LLBAPJLPCAN(ref BGEDKGLJIGM2, i, HEEDOMEABKA);
							CHPJNOEDAFE = false;
							flag = false;
						}
					}
					else if (flag || CHPJNOEDAFE || flag2)
					{
						LLBAPJLPCAN(ref BGEDKGLJIGM2, i, HEEDOMEABKA);
					}
				}
				HEEDOMEABKA++;
			}
			num3 = KCNAALADKDH - FOGJMAGABCF;
			if (!CHPJNOEDAFE && !JJINNCOPJBA && num3 > 0.051f && MPIGOGEKIPI < m_fontSizeMax)
			{
				FOGJMAGABCF = MPIGOGEKIPI;
				MPIGOGEKIPI += Mathf.Max((KCNAALADKDH - MPIGOGEKIPI) / 2f, 0.05f);
				MPIGOGEKIPI = (float)(int)(Mathf.Min(MPIGOGEKIPI, m_fontSizeMax) * 20f + 0.5f) / 20f;
				if (IAELOBCAKJO > 20)
				{
					return new Vector2(num8, num9);
				}
				return EPGGGJGKBGH(MPIGOGEKIPI, FHIAOCPKPMM, false);
			}
			CHPJNOEDAFE = false;
			CEOCLEMDMEE = false;
			num8 += ((!(m_margin.x > 0f)) ? 0f : m_margin.x);
			num8 += ((!(m_margin.z > 0f)) ? 0f : m_margin.z);
			num9 += ((!(m_margin.y > 0f)) ? 0f : m_margin.y);
			num9 += ((!(m_margin.w > 0f)) ? 0f : m_margin.w);
			num8 = (float)(int)(num8 * 100f + 1f) / 100f;
			num9 = (float)(int)(num9 * 100f + 1f) / 100f;
			return new Vector2(num8, num9);
		}

		protected virtual Bounds LFBLMFICMCK()
		{
			return default(Bounds);
		}

		protected Bounds OOANHEKEHDK()
		{
			if (m_textInfo == null || m_textInfo.characterCount > m_textInfo.characterInfo.Length)
			{
				return default(Bounds);
			}
			FEBFBNHKLAA fEBFBNHKLAA = new FEBFBNHKLAA(BOAMBILHDEN, DEAMJJKCNNM);
			for (int i = 0; i < m_textInfo.characterCount && i < m_textInfo.characterInfo.Length; i++)
			{
				if (m_textInfo.characterInfo[i].BACHBACHNOF)
				{
					fEBFBNHKLAA.IJHGDODBFCD.x = Mathf.Min(fEBFBNHKLAA.IJHGDODBFCD.x, m_textInfo.characterInfo[i].GKDEKLOCKNA.x);
					fEBFBNHKLAA.IJHGDODBFCD.y = Mathf.Min(fEBFBNHKLAA.IJHGDODBFCD.y, m_textInfo.characterInfo[i].CALDBEMMLEA);
					fEBFBNHKLAA.NHLJFKPLKLI.x = Mathf.Max(fEBFBNHKLAA.NHLJFKPLKLI.x, m_textInfo.characterInfo[i].MDKGJAGDLHC);
					fEBFBNHKLAA.NHLJFKPLKLI.y = Mathf.Max(fEBFBNHKLAA.NHLJFKPLKLI.y, m_textInfo.characterInfo[i].MNKFKKODLLM);
				}
			}
			Vector2 vector = default(Vector2);
			vector.x = fEBFBNHKLAA.NHLJFKPLKLI.x - fEBFBNHKLAA.IJHGDODBFCD.x;
			vector.y = fEBFBNHKLAA.NHLJFKPLKLI.y - fEBFBNHKLAA.IJHGDODBFCD.y;
			Vector3 center = (fEBFBNHKLAA.IJHGDODBFCD + fEBFBNHKLAA.NHLJFKPLKLI) / 2f;
			return new Bounds(center, vector);
		}

		protected Bounds OOANHEKEHDK(bool FLOKLHPKHCO)
		{
			if (m_textInfo == null)
			{
				return default(Bounds);
			}
			FEBFBNHKLAA fEBFBNHKLAA = new FEBFBNHKLAA(BOAMBILHDEN, DEAMJJKCNNM);
			for (int i = 0; i < m_textInfo.characterCount && i < NGFIDCLHDJB; i++)
			{
				if (m_textInfo.characterInfo[i].BACHBACHNOF)
				{
					if (m_textInfo.characterInfo[i].HGCMIDFMKHD > DJCOAAAJIBO)
					{
						break;
					}
					fEBFBNHKLAA.IJHGDODBFCD.x = Mathf.Min(fEBFBNHKLAA.IJHGDODBFCD.x, m_textInfo.characterInfo[i].EBDCOMKHPBG);
					fEBFBNHKLAA.IJHGDODBFCD.y = Mathf.Min(fEBFBNHKLAA.IJHGDODBFCD.y, m_textInfo.characterInfo[i].CALDBEMMLEA);
					fEBFBNHKLAA.NHLJFKPLKLI.x = Mathf.Max(fEBFBNHKLAA.NHLJFKPLKLI.x, m_textInfo.characterInfo[i].MDKGJAGDLHC);
					fEBFBNHKLAA.NHLJFKPLKLI.y = Mathf.Max(fEBFBNHKLAA.NHLJFKPLKLI.y, m_textInfo.characterInfo[i].MNKFKKODLLM);
				}
			}
			Vector2 vector = default(Vector2);
			vector.x = fEBFBNHKLAA.NHLJFKPLKLI.x - fEBFBNHKLAA.IJHGDODBFCD.x;
			vector.y = fEBFBNHKLAA.NHLJFKPLKLI.y - fEBFBNHKLAA.IJHGDODBFCD.y;
			Vector2 vector2 = (fEBFBNHKLAA.IJHGDODBFCD + fEBFBNHKLAA.NHLJFKPLKLI) / 2f;
			return new Bounds(vector2, vector);
		}

		protected virtual void NEPMEIHOFJI(int KKMNKJJENIL, int OKEFBABJGLB, float IBNDGNOIEEF)
		{
		}

		protected void KAGPEPEFMGI(int MOFHAKELNPN)
		{
			MOFHAKELNPN = ((MOFHAKELNPN <= 1024) ? Mathf.NextPowerOfTwo(MOFHAKELNPN + 1) : (MOFHAKELNPN + 256));
			CFLMKMOJIJI[] array = new CFLMKMOJIJI[MOFHAKELNPN];
			for (int i = 0; i < MOFHAKELNPN; i++)
			{
				if (i < m_textInfo.lineInfo.Length)
				{
					array[i] = m_textInfo.lineInfo[i];
					continue;
				}
				array[i].DIPEKGFBHMP.IJHGDODBFCD = BOAMBILHDEN;
				array[i].DIPEKGFBHMP.NHLJFKPLKLI = DEAMJJKCNNM;
				array[i].MNKFKKODLLM = BDOPFJFCOGB;
				array[i].CALDBEMMLEA = FEBIFNLEHEG;
			}
			m_textInfo.lineInfo = array;
		}

		public virtual TMP_TextInfo GetTextInfo(string FCJBBPHFNPJ)
		{
			return null;
		}

		protected virtual void EMKNNKLEEPI()
		{
		}

		protected void LLBAPJLPCAN(ref LAGHBLJIEME BGEDKGLJIGM, int EHJNMODJEAN, int ENMLICFLHAO)
		{
			BGEDKGLJIGM.NHOEDMKAJAI = AFEJPPDMPHE;
			BGEDKGLJIGM.OIAGLHABEEP = HBLKKCJHFFK;
			BGEDKGLJIGM.DFAKMONALKE = JBPPHIKOJPL;
			BGEDKGLJIGM.LKNEAOOJEHI = AIJEDOAJAPI;
			BGEDKGLJIGM.CCDKCOGLFBK = EHJNMODJEAN;
			BGEDKGLJIGM.FCNJKPIPALM = ENMLICFLHAO;
			BGEDKGLJIGM.NJPMNDLCAGL = CILFEEOIDGC;
			BGEDKGLJIGM.MECKBMACFJB = m_textInfo.linkCount;
			BGEDKGLJIGM.IAJJNNOAMLG = MIEJCGGDMLJ;
			BGEDKGLJIGM.CDLILHODCKP = JGOLJOCMOGD;
			BGEDKGLJIGM.AMIJINFNNFM = GMLEPIKAEMI;
			BGEDKGLJIGM.CMFEBDBACDI = CCLHEBEBBGN;
			BGEDKGLJIGM.EJMLONDBAJI = MEPDJFGMGOK;
			BGEDKGLJIGM.MPMDFPNOAMH = GEHMOIPKBGD;
			BGEDKGLJIGM.HNLEDAEOFAF = MPIGOGEKIPI;
			BGEDKGLJIGM.MDKGJAGDLHC = PLALFBMFEEC;
			BGEDKGLJIGM.FLBNIHNCDHJ = JCNIIINOEHG;
			BGEDKGLJIGM.DLIGIKPNFAM = MJMNGPIFHGG;
			BGEDKGLJIGM.KIDENCEDDGH = ONHFBKLHJIN;
			BGEDKGLJIGM.BNGJMNKOLMP = NDEAABJECMK;
			BGEDKGLJIGM.EIALJMKEGNO = ODBAKFJDCCP;
			BGEDKGLJIGM.FBCKCNHPKDH = DMKNFOCBDEG;
			BGEDKGLJIGM.AODHJNNEFKF = HEJJGBFEPCM;
			BGEDKGLJIGM.ICJOPDNAIJF = EHHDCBAEJDG;
			BGEDKGLJIGM.GANOIONIGLA = NBHJNBHINPH;
			BGEDKGLJIGM.HGCMIDFMKHD = FGMGAJAPPJC;
			BGEDKGLJIGM.BGDIPDPPGOK = GFIDNINNNAL;
			BGEDKGLJIGM.KEAFOFHAKEA = HDHGLHPMBPG;
			BGEDKGLJIGM.NEJNJJAIFNG = EPCFNBCMCHK;
			BGEDKGLJIGM.FNHEFDBFBMN = HEFLDLNICAK;
			BGEDKGLJIGM.NPNKHPFBLBG = DNDMCGFIBJM;
			BGEDKGLJIGM.OFCEJMNBFOJ = EDCPEAJCPLG;
			BGEDKGLJIGM.NIACJHFOPPG = FGGFHMLKNJJ;
			BGEDKGLJIGM.PKBABDOIMDG = MKAJPJFKEPP;
			BGEDKGLJIGM.EMAMAOPMCBO = EOGFNFBPHHJ;
			BGEDKGLJIGM.GNOFNLDDHDJ = FNPOGPIGCIN;
			BGEDKGLJIGM.FFKJKEBIOKN = LEMAEBLIHBK;
			BGEDKGLJIGM.FDKGGBANGGH = KOOKMGIBAIG;
			BGEDKGLJIGM.MCAJOKHDDLL = FJJAGAJLDJG;
			BGEDKGLJIGM.DEHAOHCIIJE = BNFNFGGNBGJ;
			BGEDKGLJIGM.CGBEBIMBOGP = IOAEEGOLEHI;
			BGEDKGLJIGM.APFKKHAMBEP = LHDBHJFCEKJ;
			BGEDKGLJIGM.PLLKPADJJAB = DJIJDHCEGOA;
			BGEDKGLJIGM.KJECFAOBCAL = DBEFOGFNAME;
			BGEDKGLJIGM.DPBJCEIIPOO = IBLGHCLBFJG;
			BGEDKGLJIGM.FJJAILBNIEI = MLEBLGGBDIA;
			if (FGMGAJAPPJC < m_textInfo.lineInfo.Length)
			{
				BGEDKGLJIGM.BJPMCLDCIKK = m_textInfo.lineInfo[FGMGAJAPPJC];
			}
		}

		protected int NACMMBNPFJK(ref LAGHBLJIEME BGEDKGLJIGM)
		{
			int cCDKCOGLFBK = BGEDKGLJIGM.CCDKCOGLFBK;
			AFEJPPDMPHE = BGEDKGLJIGM.NHOEDMKAJAI;
			HBLKKCJHFFK = BGEDKGLJIGM.OIAGLHABEEP;
			JBPPHIKOJPL = BGEDKGLJIGM.DFAKMONALKE;
			AIJEDOAJAPI = BGEDKGLJIGM.LKNEAOOJEHI;
			HEEDOMEABKA = BGEDKGLJIGM.FCNJKPIPALM + 1;
			CILFEEOIDGC = BGEDKGLJIGM.NJPMNDLCAGL;
			m_textInfo.linkCount = BGEDKGLJIGM.MECKBMACFJB;
			MIEJCGGDMLJ = BGEDKGLJIGM.IAJJNNOAMLG;
			JGOLJOCMOGD = BGEDKGLJIGM.CDLILHODCKP;
			GMLEPIKAEMI = BGEDKGLJIGM.AMIJINFNNFM;
			CCLHEBEBBGN = BGEDKGLJIGM.CMFEBDBACDI;
			MEPDJFGMGOK = BGEDKGLJIGM.EJMLONDBAJI;
			GEHMOIPKBGD = BGEDKGLJIGM.MPMDFPNOAMH;
			MPIGOGEKIPI = BGEDKGLJIGM.HNLEDAEOFAF;
			PLALFBMFEEC = BGEDKGLJIGM.MDKGJAGDLHC;
			JCNIIINOEHG = BGEDKGLJIGM.FLBNIHNCDHJ;
			MJMNGPIFHGG = BGEDKGLJIGM.DLIGIKPNFAM;
			ONHFBKLHJIN = BGEDKGLJIGM.KIDENCEDDGH;
			NDEAABJECMK = BGEDKGLJIGM.BNGJMNKOLMP;
			ODBAKFJDCCP = BGEDKGLJIGM.EIALJMKEGNO;
			DMKNFOCBDEG = BGEDKGLJIGM.FBCKCNHPKDH;
			HEJJGBFEPCM = BGEDKGLJIGM.AODHJNNEFKF;
			EHHDCBAEJDG = BGEDKGLJIGM.ICJOPDNAIJF;
			NBHJNBHINPH = BGEDKGLJIGM.GANOIONIGLA;
			FGMGAJAPPJC = BGEDKGLJIGM.HGCMIDFMKHD;
			GFIDNINNNAL = BGEDKGLJIGM.BGDIPDPPGOK;
			HDHGLHPMBPG = BGEDKGLJIGM.KEAFOFHAKEA;
			EPCFNBCMCHK = BGEDKGLJIGM.NEJNJJAIFNG;
			HEFLDLNICAK = BGEDKGLJIGM.FNHEFDBFBMN;
			DNDMCGFIBJM = BGEDKGLJIGM.NPNKHPFBLBG;
			EDCPEAJCPLG = BGEDKGLJIGM.OFCEJMNBFOJ;
			FGGFHMLKNJJ = BGEDKGLJIGM.NIACJHFOPPG;
			MKAJPJFKEPP = BGEDKGLJIGM.PKBABDOIMDG;
			EOGFNFBPHHJ = BGEDKGLJIGM.EMAMAOPMCBO;
			FNPOGPIGCIN = BGEDKGLJIGM.GNOFNLDDHDJ;
			LEMAEBLIHBK = BGEDKGLJIGM.FFKJKEBIOKN;
			KOOKMGIBAIG = BGEDKGLJIGM.FDKGGBANGGH;
			FJJAGAJLDJG = BGEDKGLJIGM.MCAJOKHDDLL;
			BNFNFGGNBGJ = BGEDKGLJIGM.DEHAOHCIIJE;
			IOAEEGOLEHI = BGEDKGLJIGM.CGBEBIMBOGP;
			LHDBHJFCEKJ = BGEDKGLJIGM.APFKKHAMBEP;
			DJIJDHCEGOA = BGEDKGLJIGM.PLLKPADJJAB;
			DBEFOGFNAME = BGEDKGLJIGM.KJECFAOBCAL;
			IBLGHCLBFJG = BGEDKGLJIGM.DPBJCEIIPOO;
			MLEBLGGBDIA = BGEDKGLJIGM.FJJAILBNIEI;
			if (FGMGAJAPPJC < m_textInfo.lineInfo.Length)
			{
				m_textInfo.lineInfo[FGMGAJAPPJC] = BGEDKGLJIGM.BJPMCLDCIKK;
			}
			return cCDKCOGLFBK;
		}

		protected virtual void PKLHKHJKHGM(float HFHKPBBFDFD, float HONABCLFGFF, Color32 NEJNJJAIFNG)
		{
			m_textInfo.characterInfo[HEEDOMEABKA].BEOPBIAPDBP.LDMDBPLADGD = m_textInfo.characterInfo[HEEDOMEABKA].GKDEKLOCKNA;
			m_textInfo.characterInfo[HEEDOMEABKA].DNOLPLGACHH.LDMDBPLADGD = m_textInfo.characterInfo[HEEDOMEABKA].LDJGLAIAPIM;
			m_textInfo.characterInfo[HEEDOMEABKA].HKBAKLGBMDE.LDMDBPLADGD = m_textInfo.characterInfo[HEEDOMEABKA].BJONICNNGLI;
			m_textInfo.characterInfo[HEEDOMEABKA].HOCKPNNAIAL.LDMDBPLADGD = m_textInfo.characterInfo[HEEDOMEABKA].ABIJFLBDMON;
			NEJNJJAIFNG.a = ((m_fontColor32.a >= NEJNJJAIFNG.a) ? NEJNJJAIFNG.a : m_fontColor32.a);
			if (!m_enableVertexGradient)
			{
				m_textInfo.characterInfo[HEEDOMEABKA].BEOPBIAPDBP.MFODILBOMGD = NEJNJJAIFNG;
				m_textInfo.characterInfo[HEEDOMEABKA].DNOLPLGACHH.MFODILBOMGD = NEJNJJAIFNG;
				m_textInfo.characterInfo[HEEDOMEABKA].HKBAKLGBMDE.MFODILBOMGD = NEJNJJAIFNG;
				m_textInfo.characterInfo[HEEDOMEABKA].HOCKPNNAIAL.MFODILBOMGD = NEJNJJAIFNG;
			}
			else if (!m_overrideHtmlColors && EOGFNFBPHHJ.EHJNMODJEAN > 1)
			{
				m_textInfo.characterInfo[HEEDOMEABKA].BEOPBIAPDBP.MFODILBOMGD = NEJNJJAIFNG;
				m_textInfo.characterInfo[HEEDOMEABKA].DNOLPLGACHH.MFODILBOMGD = NEJNJJAIFNG;
				m_textInfo.characterInfo[HEEDOMEABKA].HKBAKLGBMDE.MFODILBOMGD = NEJNJJAIFNG;
				m_textInfo.characterInfo[HEEDOMEABKA].HOCKPNNAIAL.MFODILBOMGD = NEJNJJAIFNG;
			}
			else if (m_fontColorGradientPreset != null)
			{
				m_textInfo.characterInfo[HEEDOMEABKA].BEOPBIAPDBP.MFODILBOMGD = m_fontColorGradientPreset.bottomLeft * NEJNJJAIFNG;
				m_textInfo.characterInfo[HEEDOMEABKA].DNOLPLGACHH.MFODILBOMGD = m_fontColorGradientPreset.topLeft * NEJNJJAIFNG;
				m_textInfo.characterInfo[HEEDOMEABKA].HKBAKLGBMDE.MFODILBOMGD = m_fontColorGradientPreset.topRight * NEJNJJAIFNG;
				m_textInfo.characterInfo[HEEDOMEABKA].HOCKPNNAIAL.MFODILBOMGD = m_fontColorGradientPreset.bottomRight * NEJNJJAIFNG;
			}
			else
			{
				m_textInfo.characterInfo[HEEDOMEABKA].BEOPBIAPDBP.MFODILBOMGD = m_fontColorGradient.bottomLeft * NEJNJJAIFNG;
				m_textInfo.characterInfo[HEEDOMEABKA].DNOLPLGACHH.MFODILBOMGD = m_fontColorGradient.topLeft * NEJNJJAIFNG;
				m_textInfo.characterInfo[HEEDOMEABKA].HKBAKLGBMDE.MFODILBOMGD = m_fontColorGradient.topRight * NEJNJJAIFNG;
				m_textInfo.characterInfo[HEEDOMEABKA].HOCKPNNAIAL.MFODILBOMGD = m_fontColorGradient.bottomRight * NEJNJJAIFNG;
			}
			if (!NJFPOFBLHCF)
			{
				HONABCLFGFF = 0f;
			}
			FaceInfo fontInfo = AFEJPPDMPHE.fontInfo;
			Vector2 nEOLFCHBJOA = default(Vector2);
			nEOLFCHBJOA.x = (EOLJHINLKLO.x - HFHKPBBFDFD - HONABCLFGFF) / fontInfo.AtlasWidth;
			nEOLFCHBJOA.y = 1f - (EOLJHINLKLO.y + HFHKPBBFDFD + HONABCLFGFF + EOLJHINLKLO.height) / fontInfo.AtlasHeight;
			Vector2 nEOLFCHBJOA2 = default(Vector2);
			nEOLFCHBJOA2.x = nEOLFCHBJOA.x;
			nEOLFCHBJOA2.y = 1f - (EOLJHINLKLO.y - HFHKPBBFDFD - HONABCLFGFF) / fontInfo.AtlasHeight;
			Vector2 nEOLFCHBJOA3 = default(Vector2);
			nEOLFCHBJOA3.x = (EOLJHINLKLO.x + HFHKPBBFDFD + HONABCLFGFF + EOLJHINLKLO.width) / fontInfo.AtlasWidth;
			nEOLFCHBJOA3.y = nEOLFCHBJOA2.y;
			Vector2 nEOLFCHBJOA4 = default(Vector2);
			nEOLFCHBJOA4.x = nEOLFCHBJOA3.x;
			nEOLFCHBJOA4.y = nEOLFCHBJOA.y;
			m_textInfo.characterInfo[HEEDOMEABKA].BEOPBIAPDBP.NEOLFCHBJOA = nEOLFCHBJOA;
			m_textInfo.characterInfo[HEEDOMEABKA].DNOLPLGACHH.NEOLFCHBJOA = nEOLFCHBJOA2;
			m_textInfo.characterInfo[HEEDOMEABKA].HKBAKLGBMDE.NEOLFCHBJOA = nEOLFCHBJOA3;
			m_textInfo.characterInfo[HEEDOMEABKA].HOCKPNNAIAL.NEOLFCHBJOA = nEOLFCHBJOA4;
		}

		protected virtual void LIMFCMHGGPI(Color32 NEJNJJAIFNG)
		{
			m_textInfo.characterInfo[HEEDOMEABKA].BEOPBIAPDBP.LDMDBPLADGD = m_textInfo.characterInfo[HEEDOMEABKA].GKDEKLOCKNA;
			m_textInfo.characterInfo[HEEDOMEABKA].DNOLPLGACHH.LDMDBPLADGD = m_textInfo.characterInfo[HEEDOMEABKA].LDJGLAIAPIM;
			m_textInfo.characterInfo[HEEDOMEABKA].HKBAKLGBMDE.LDMDBPLADGD = m_textInfo.characterInfo[HEEDOMEABKA].BJONICNNGLI;
			m_textInfo.characterInfo[HEEDOMEABKA].HOCKPNNAIAL.LDMDBPLADGD = m_textInfo.characterInfo[HEEDOMEABKA].ABIJFLBDMON;
			if (m_tintAllSprites)
			{
				GKGFOHJGDMD = true;
			}
			Color32 color = ((!GKGFOHJGDMD) ? IIHIHIELCKN : IIHIHIELCKN.IBJBIGNPNEM(NEJNJJAIFNG));
			color.a = ((color.a >= m_fontColor32.a) ? m_fontColor32.a : (color.a = ((color.a >= NEJNJJAIFNG.a) ? NEJNJJAIFNG.a : color.a)));
			if (!m_enableVertexGradient)
			{
				m_textInfo.characterInfo[HEEDOMEABKA].BEOPBIAPDBP.MFODILBOMGD = color;
				m_textInfo.characterInfo[HEEDOMEABKA].DNOLPLGACHH.MFODILBOMGD = color;
				m_textInfo.characterInfo[HEEDOMEABKA].HKBAKLGBMDE.MFODILBOMGD = color;
				m_textInfo.characterInfo[HEEDOMEABKA].HOCKPNNAIAL.MFODILBOMGD = color;
			}
			else if (!m_overrideHtmlColors && EOGFNFBPHHJ.EHJNMODJEAN > 1)
			{
				m_textInfo.characterInfo[HEEDOMEABKA].BEOPBIAPDBP.MFODILBOMGD = color;
				m_textInfo.characterInfo[HEEDOMEABKA].DNOLPLGACHH.MFODILBOMGD = color;
				m_textInfo.characterInfo[HEEDOMEABKA].HKBAKLGBMDE.MFODILBOMGD = color;
				m_textInfo.characterInfo[HEEDOMEABKA].HOCKPNNAIAL.MFODILBOMGD = color;
			}
			else if (m_fontColorGradientPreset != null)
			{
				m_textInfo.characterInfo[HEEDOMEABKA].BEOPBIAPDBP.MFODILBOMGD = ((!GKGFOHJGDMD) ? color : color.IBJBIGNPNEM(m_fontColorGradientPreset.bottomLeft));
				m_textInfo.characterInfo[HEEDOMEABKA].DNOLPLGACHH.MFODILBOMGD = ((!GKGFOHJGDMD) ? color : color.IBJBIGNPNEM(m_fontColorGradientPreset.topLeft));
				m_textInfo.characterInfo[HEEDOMEABKA].HKBAKLGBMDE.MFODILBOMGD = ((!GKGFOHJGDMD) ? color : color.IBJBIGNPNEM(m_fontColorGradientPreset.topRight));
				m_textInfo.characterInfo[HEEDOMEABKA].HOCKPNNAIAL.MFODILBOMGD = ((!GKGFOHJGDMD) ? color : color.IBJBIGNPNEM(m_fontColorGradientPreset.bottomRight));
			}
			else
			{
				m_textInfo.characterInfo[HEEDOMEABKA].BEOPBIAPDBP.MFODILBOMGD = ((!GKGFOHJGDMD) ? color : color.IBJBIGNPNEM(m_fontColorGradient.bottomLeft));
				m_textInfo.characterInfo[HEEDOMEABKA].DNOLPLGACHH.MFODILBOMGD = ((!GKGFOHJGDMD) ? color : color.IBJBIGNPNEM(m_fontColorGradient.topLeft));
				m_textInfo.characterInfo[HEEDOMEABKA].HKBAKLGBMDE.MFODILBOMGD = ((!GKGFOHJGDMD) ? color : color.IBJBIGNPNEM(m_fontColorGradient.topRight));
				m_textInfo.characterInfo[HEEDOMEABKA].HOCKPNNAIAL.MFODILBOMGD = ((!GKGFOHJGDMD) ? color : color.IBJBIGNPNEM(m_fontColorGradient.bottomRight));
			}
			Vector2 nEOLFCHBJOA = new Vector2(EOLJHINLKLO.x / (float)HBLKKCJHFFK.spriteSheet.width, EOLJHINLKLO.y / (float)HBLKKCJHFFK.spriteSheet.height);
			Vector2 nEOLFCHBJOA2 = new Vector2(nEOLFCHBJOA.x, (EOLJHINLKLO.y + EOLJHINLKLO.height) / (float)HBLKKCJHFFK.spriteSheet.height);
			Vector2 nEOLFCHBJOA3 = new Vector2((EOLJHINLKLO.x + EOLJHINLKLO.width) / (float)HBLKKCJHFFK.spriteSheet.width, nEOLFCHBJOA2.y);
			Vector2 nEOLFCHBJOA4 = new Vector2(nEOLFCHBJOA3.x, nEOLFCHBJOA.y);
			m_textInfo.characterInfo[HEEDOMEABKA].BEOPBIAPDBP.NEOLFCHBJOA = nEOLFCHBJOA;
			m_textInfo.characterInfo[HEEDOMEABKA].DNOLPLGACHH.NEOLFCHBJOA = nEOLFCHBJOA2;
			m_textInfo.characterInfo[HEEDOMEABKA].HKBAKLGBMDE.NEOLFCHBJOA = nEOLFCHBJOA3;
			m_textInfo.characterInfo[HEEDOMEABKA].HOCKPNNAIAL.NEOLFCHBJOA = nEOLFCHBJOA4;
		}

		protected virtual void ENEAMABFPLB(int PLCFEOMGCFK, int KBAFACHPHMF)
		{
			int eKBHGEBCJHL = m_textInfo.characterInfo[PLCFEOMGCFK].EKBHGEBCJHL;
			KBAFACHPHMF = m_textInfo.meshInfo[eKBHGEBCJHL].BKJOIFFAGKE;
			MGLLLPMKGDA[] characterInfo = m_textInfo.characterInfo;
			m_textInfo.characterInfo[PLCFEOMGCFK].KAKJKCHHBAP = KBAFACHPHMF;
			m_textInfo.meshInfo[eKBHGEBCJHL].FHBFCAEGPOH[KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].BEOPBIAPDBP.LDMDBPLADGD;
			m_textInfo.meshInfo[eKBHGEBCJHL].FHBFCAEGPOH[1 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].DNOLPLGACHH.LDMDBPLADGD;
			m_textInfo.meshInfo[eKBHGEBCJHL].FHBFCAEGPOH[2 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HKBAKLGBMDE.LDMDBPLADGD;
			m_textInfo.meshInfo[eKBHGEBCJHL].FHBFCAEGPOH[3 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HOCKPNNAIAL.LDMDBPLADGD;
			m_textInfo.meshInfo[eKBHGEBCJHL].LFAFOAOKPKA[KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].BEOPBIAPDBP.NEOLFCHBJOA;
			m_textInfo.meshInfo[eKBHGEBCJHL].LFAFOAOKPKA[1 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].DNOLPLGACHH.NEOLFCHBJOA;
			m_textInfo.meshInfo[eKBHGEBCJHL].LFAFOAOKPKA[2 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HKBAKLGBMDE.NEOLFCHBJOA;
			m_textInfo.meshInfo[eKBHGEBCJHL].LFAFOAOKPKA[3 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HOCKPNNAIAL.NEOLFCHBJOA;
			m_textInfo.meshInfo[eKBHGEBCJHL].FJPNPHPFBFJ[KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].BEOPBIAPDBP.NHFBHNEIGIP;
			m_textInfo.meshInfo[eKBHGEBCJHL].FJPNPHPFBFJ[1 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].DNOLPLGACHH.NHFBHNEIGIP;
			m_textInfo.meshInfo[eKBHGEBCJHL].FJPNPHPFBFJ[2 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HKBAKLGBMDE.NHFBHNEIGIP;
			m_textInfo.meshInfo[eKBHGEBCJHL].FJPNPHPFBFJ[3 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HOCKPNNAIAL.NHFBHNEIGIP;
			m_textInfo.meshInfo[eKBHGEBCJHL].PMBHKFBDDND[KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].BEOPBIAPDBP.MFODILBOMGD;
			m_textInfo.meshInfo[eKBHGEBCJHL].PMBHKFBDDND[1 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].DNOLPLGACHH.MFODILBOMGD;
			m_textInfo.meshInfo[eKBHGEBCJHL].PMBHKFBDDND[2 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HKBAKLGBMDE.MFODILBOMGD;
			m_textInfo.meshInfo[eKBHGEBCJHL].PMBHKFBDDND[3 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HOCKPNNAIAL.MFODILBOMGD;
			m_textInfo.meshInfo[eKBHGEBCJHL].BKJOIFFAGKE = KBAFACHPHMF + 4;
		}

		protected virtual void ENEAMABFPLB(int PLCFEOMGCFK, int KBAFACHPHMF, bool JKKNBMKFKAI)
		{
			int eKBHGEBCJHL = m_textInfo.characterInfo[PLCFEOMGCFK].EKBHGEBCJHL;
			KBAFACHPHMF = m_textInfo.meshInfo[eKBHGEBCJHL].BKJOIFFAGKE;
			MGLLLPMKGDA[] characterInfo = m_textInfo.characterInfo;
			m_textInfo.characterInfo[PLCFEOMGCFK].KAKJKCHHBAP = KBAFACHPHMF;
			m_textInfo.meshInfo[eKBHGEBCJHL].FHBFCAEGPOH[KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].BEOPBIAPDBP.LDMDBPLADGD;
			m_textInfo.meshInfo[eKBHGEBCJHL].FHBFCAEGPOH[1 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].DNOLPLGACHH.LDMDBPLADGD;
			m_textInfo.meshInfo[eKBHGEBCJHL].FHBFCAEGPOH[2 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HKBAKLGBMDE.LDMDBPLADGD;
			m_textInfo.meshInfo[eKBHGEBCJHL].FHBFCAEGPOH[3 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HOCKPNNAIAL.LDMDBPLADGD;
			if (JKKNBMKFKAI)
			{
				Vector3 vector = new Vector3(0f, 0f, m_fontSize * MEPDJFGMGOK);
				m_textInfo.meshInfo[eKBHGEBCJHL].FHBFCAEGPOH[4 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].BEOPBIAPDBP.LDMDBPLADGD + vector;
				m_textInfo.meshInfo[eKBHGEBCJHL].FHBFCAEGPOH[5 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].DNOLPLGACHH.LDMDBPLADGD + vector;
				m_textInfo.meshInfo[eKBHGEBCJHL].FHBFCAEGPOH[6 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HKBAKLGBMDE.LDMDBPLADGD + vector;
				m_textInfo.meshInfo[eKBHGEBCJHL].FHBFCAEGPOH[7 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HOCKPNNAIAL.LDMDBPLADGD + vector;
			}
			m_textInfo.meshInfo[eKBHGEBCJHL].LFAFOAOKPKA[KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].BEOPBIAPDBP.NEOLFCHBJOA;
			m_textInfo.meshInfo[eKBHGEBCJHL].LFAFOAOKPKA[1 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].DNOLPLGACHH.NEOLFCHBJOA;
			m_textInfo.meshInfo[eKBHGEBCJHL].LFAFOAOKPKA[2 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HKBAKLGBMDE.NEOLFCHBJOA;
			m_textInfo.meshInfo[eKBHGEBCJHL].LFAFOAOKPKA[3 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HOCKPNNAIAL.NEOLFCHBJOA;
			if (JKKNBMKFKAI)
			{
				m_textInfo.meshInfo[eKBHGEBCJHL].LFAFOAOKPKA[4 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].BEOPBIAPDBP.NEOLFCHBJOA;
				m_textInfo.meshInfo[eKBHGEBCJHL].LFAFOAOKPKA[5 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].DNOLPLGACHH.NEOLFCHBJOA;
				m_textInfo.meshInfo[eKBHGEBCJHL].LFAFOAOKPKA[6 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HKBAKLGBMDE.NEOLFCHBJOA;
				m_textInfo.meshInfo[eKBHGEBCJHL].LFAFOAOKPKA[7 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HOCKPNNAIAL.NEOLFCHBJOA;
			}
			m_textInfo.meshInfo[eKBHGEBCJHL].FJPNPHPFBFJ[KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].BEOPBIAPDBP.NHFBHNEIGIP;
			m_textInfo.meshInfo[eKBHGEBCJHL].FJPNPHPFBFJ[1 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].DNOLPLGACHH.NHFBHNEIGIP;
			m_textInfo.meshInfo[eKBHGEBCJHL].FJPNPHPFBFJ[2 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HKBAKLGBMDE.NHFBHNEIGIP;
			m_textInfo.meshInfo[eKBHGEBCJHL].FJPNPHPFBFJ[3 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HOCKPNNAIAL.NHFBHNEIGIP;
			if (JKKNBMKFKAI)
			{
				m_textInfo.meshInfo[eKBHGEBCJHL].FJPNPHPFBFJ[4 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].BEOPBIAPDBP.NHFBHNEIGIP;
				m_textInfo.meshInfo[eKBHGEBCJHL].FJPNPHPFBFJ[5 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].DNOLPLGACHH.NHFBHNEIGIP;
				m_textInfo.meshInfo[eKBHGEBCJHL].FJPNPHPFBFJ[6 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HKBAKLGBMDE.NHFBHNEIGIP;
				m_textInfo.meshInfo[eKBHGEBCJHL].FJPNPHPFBFJ[7 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HOCKPNNAIAL.NHFBHNEIGIP;
			}
			m_textInfo.meshInfo[eKBHGEBCJHL].PMBHKFBDDND[KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].BEOPBIAPDBP.MFODILBOMGD;
			m_textInfo.meshInfo[eKBHGEBCJHL].PMBHKFBDDND[1 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].DNOLPLGACHH.MFODILBOMGD;
			m_textInfo.meshInfo[eKBHGEBCJHL].PMBHKFBDDND[2 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HKBAKLGBMDE.MFODILBOMGD;
			m_textInfo.meshInfo[eKBHGEBCJHL].PMBHKFBDDND[3 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HOCKPNNAIAL.MFODILBOMGD;
			if (JKKNBMKFKAI)
			{
				Color32 color = new Color32(byte.MaxValue, byte.MaxValue, 128, byte.MaxValue);
				m_textInfo.meshInfo[eKBHGEBCJHL].PMBHKFBDDND[4 + KBAFACHPHMF] = color;
				m_textInfo.meshInfo[eKBHGEBCJHL].PMBHKFBDDND[5 + KBAFACHPHMF] = color;
				m_textInfo.meshInfo[eKBHGEBCJHL].PMBHKFBDDND[6 + KBAFACHPHMF] = color;
				m_textInfo.meshInfo[eKBHGEBCJHL].PMBHKFBDDND[7 + KBAFACHPHMF] = color;
			}
			m_textInfo.meshInfo[eKBHGEBCJHL].BKJOIFFAGKE = KBAFACHPHMF + (JKKNBMKFKAI ? 8 : 4);
		}

		protected virtual void PCMPCIOLPOA(int PLCFEOMGCFK, int KBAFACHPHMF)
		{
			int eKBHGEBCJHL = m_textInfo.characterInfo[PLCFEOMGCFK].EKBHGEBCJHL;
			KBAFACHPHMF = m_textInfo.meshInfo[eKBHGEBCJHL].BKJOIFFAGKE;
			MGLLLPMKGDA[] characterInfo = m_textInfo.characterInfo;
			m_textInfo.characterInfo[PLCFEOMGCFK].KAKJKCHHBAP = KBAFACHPHMF;
			m_textInfo.meshInfo[eKBHGEBCJHL].FHBFCAEGPOH[KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].BEOPBIAPDBP.LDMDBPLADGD;
			m_textInfo.meshInfo[eKBHGEBCJHL].FHBFCAEGPOH[1 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].DNOLPLGACHH.LDMDBPLADGD;
			m_textInfo.meshInfo[eKBHGEBCJHL].FHBFCAEGPOH[2 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HKBAKLGBMDE.LDMDBPLADGD;
			m_textInfo.meshInfo[eKBHGEBCJHL].FHBFCAEGPOH[3 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HOCKPNNAIAL.LDMDBPLADGD;
			m_textInfo.meshInfo[eKBHGEBCJHL].LFAFOAOKPKA[KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].BEOPBIAPDBP.NEOLFCHBJOA;
			m_textInfo.meshInfo[eKBHGEBCJHL].LFAFOAOKPKA[1 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].DNOLPLGACHH.NEOLFCHBJOA;
			m_textInfo.meshInfo[eKBHGEBCJHL].LFAFOAOKPKA[2 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HKBAKLGBMDE.NEOLFCHBJOA;
			m_textInfo.meshInfo[eKBHGEBCJHL].LFAFOAOKPKA[3 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HOCKPNNAIAL.NEOLFCHBJOA;
			m_textInfo.meshInfo[eKBHGEBCJHL].FJPNPHPFBFJ[KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].BEOPBIAPDBP.NHFBHNEIGIP;
			m_textInfo.meshInfo[eKBHGEBCJHL].FJPNPHPFBFJ[1 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].DNOLPLGACHH.NHFBHNEIGIP;
			m_textInfo.meshInfo[eKBHGEBCJHL].FJPNPHPFBFJ[2 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HKBAKLGBMDE.NHFBHNEIGIP;
			m_textInfo.meshInfo[eKBHGEBCJHL].FJPNPHPFBFJ[3 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HOCKPNNAIAL.NHFBHNEIGIP;
			m_textInfo.meshInfo[eKBHGEBCJHL].PMBHKFBDDND[KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].BEOPBIAPDBP.MFODILBOMGD;
			m_textInfo.meshInfo[eKBHGEBCJHL].PMBHKFBDDND[1 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].DNOLPLGACHH.MFODILBOMGD;
			m_textInfo.meshInfo[eKBHGEBCJHL].PMBHKFBDDND[2 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HKBAKLGBMDE.MFODILBOMGD;
			m_textInfo.meshInfo[eKBHGEBCJHL].PMBHKFBDDND[3 + KBAFACHPHMF] = characterInfo[PLCFEOMGCFK].HOCKPNNAIAL.MFODILBOMGD;
			m_textInfo.meshInfo[eKBHGEBCJHL].BKJOIFFAGKE = KBAFACHPHMF + 4;
		}

		protected virtual void BDKMACGGDAO(Vector3 EHGOOEHDNMM, Vector3 AHPGGJALELA, ref int EHJNMODJEAN, float ONFPOAAFMFL, float IALNLNKCJIG, float NANOGOLLGDC, float FKKNEBNCLIB, Color32 FNHEFDBFBMN)
		{
			if (EDEHAJPLEKI == null)
			{
				if (!TMP_Settings.warningsDisabled)
				{
					Debug.LogWarning("Unable to add underline since the Font Asset doesn't contain the underline character.", this);
				}
				return;
			}
			int num = EHJNMODJEAN + 12;
			if (num > m_textInfo.meshInfo[0].FHBFCAEGPOH.Length)
			{
				m_textInfo.meshInfo[0].CMGCBJCIJNB(num / 4);
			}
			EHGOOEHDNMM.y = Mathf.Min(EHGOOEHDNMM.y, AHPGGJALELA.y);
			AHPGGJALELA.y = Mathf.Min(EHGOOEHDNMM.y, AHPGGJALELA.y);
			float num2 = EDEHAJPLEKI.width / 2f * NANOGOLLGDC;
			if (AHPGGJALELA.x - EHGOOEHDNMM.x < EDEHAJPLEKI.width * NANOGOLLGDC)
			{
				num2 = (AHPGGJALELA.x - EHGOOEHDNMM.x) / 2f;
			}
			float num3 = IBKCGEGKGNM * ONFPOAAFMFL / NANOGOLLGDC;
			float num4 = IBKCGEGKGNM * IALNLNKCJIG / NANOGOLLGDC;
			float height = EDEHAJPLEKI.height;
			Vector3[] fHBFCAEGPOH = m_textInfo.meshInfo[0].FHBFCAEGPOH;
			fHBFCAEGPOH[EHJNMODJEAN] = EHGOOEHDNMM + new Vector3(0f, 0f - (height + IBKCGEGKGNM) * NANOGOLLGDC, 0f);
			fHBFCAEGPOH[EHJNMODJEAN + 1] = EHGOOEHDNMM + new Vector3(0f, IBKCGEGKGNM * NANOGOLLGDC, 0f);
			fHBFCAEGPOH[EHJNMODJEAN + 2] = fHBFCAEGPOH[EHJNMODJEAN + 1] + new Vector3(num2, 0f, 0f);
			fHBFCAEGPOH[EHJNMODJEAN + 3] = fHBFCAEGPOH[EHJNMODJEAN] + new Vector3(num2, 0f, 0f);
			fHBFCAEGPOH[EHJNMODJEAN + 4] = fHBFCAEGPOH[EHJNMODJEAN + 3];
			fHBFCAEGPOH[EHJNMODJEAN + 5] = fHBFCAEGPOH[EHJNMODJEAN + 2];
			fHBFCAEGPOH[EHJNMODJEAN + 6] = AHPGGJALELA + new Vector3(0f - num2, IBKCGEGKGNM * NANOGOLLGDC, 0f);
			fHBFCAEGPOH[EHJNMODJEAN + 7] = AHPGGJALELA + new Vector3(0f - num2, (0f - (height + IBKCGEGKGNM)) * NANOGOLLGDC, 0f);
			fHBFCAEGPOH[EHJNMODJEAN + 8] = fHBFCAEGPOH[EHJNMODJEAN + 7];
			fHBFCAEGPOH[EHJNMODJEAN + 9] = fHBFCAEGPOH[EHJNMODJEAN + 6];
			fHBFCAEGPOH[EHJNMODJEAN + 10] = AHPGGJALELA + new Vector3(0f, IBKCGEGKGNM * NANOGOLLGDC, 0f);
			fHBFCAEGPOH[EHJNMODJEAN + 11] = AHPGGJALELA + new Vector3(0f, (0f - (height + IBKCGEGKGNM)) * NANOGOLLGDC, 0f);
			Vector2[] lFAFOAOKPKA = m_textInfo.meshInfo[0].LFAFOAOKPKA;
			Vector2 vector = new Vector2((EDEHAJPLEKI.x - num3) / m_fontAsset.fontInfo.AtlasWidth, 1f - (EDEHAJPLEKI.y + IBKCGEGKGNM + EDEHAJPLEKI.height) / m_fontAsset.fontInfo.AtlasHeight);
			Vector2 vector2 = new Vector2(vector.x, 1f - (EDEHAJPLEKI.y - IBKCGEGKGNM) / m_fontAsset.fontInfo.AtlasHeight);
			Vector2 vector3 = new Vector2((EDEHAJPLEKI.x - num3 + EDEHAJPLEKI.width / 2f) / m_fontAsset.fontInfo.AtlasWidth, vector2.y);
			Vector2 vector4 = new Vector2(vector3.x, vector.y);
			Vector2 vector5 = new Vector2((EDEHAJPLEKI.x + num4 + EDEHAJPLEKI.width / 2f) / m_fontAsset.fontInfo.AtlasWidth, vector2.y);
			Vector2 vector6 = new Vector2(vector5.x, vector.y);
			Vector2 vector7 = new Vector2((EDEHAJPLEKI.x + num4 + EDEHAJPLEKI.width) / m_fontAsset.fontInfo.AtlasWidth, vector2.y);
			Vector2 vector8 = new Vector2(vector7.x, vector.y);
			lFAFOAOKPKA[EHJNMODJEAN] = vector;
			lFAFOAOKPKA[1 + EHJNMODJEAN] = vector2;
			lFAFOAOKPKA[2 + EHJNMODJEAN] = vector3;
			lFAFOAOKPKA[3 + EHJNMODJEAN] = vector4;
			lFAFOAOKPKA[4 + EHJNMODJEAN] = new Vector2(vector3.x - vector3.x * 0.001f, vector.y);
			lFAFOAOKPKA[5 + EHJNMODJEAN] = new Vector2(vector3.x - vector3.x * 0.001f, vector2.y);
			lFAFOAOKPKA[6 + EHJNMODJEAN] = new Vector2(vector3.x + vector3.x * 0.001f, vector2.y);
			lFAFOAOKPKA[7 + EHJNMODJEAN] = new Vector2(vector3.x + vector3.x * 0.001f, vector.y);
			lFAFOAOKPKA[8 + EHJNMODJEAN] = vector6;
			lFAFOAOKPKA[9 + EHJNMODJEAN] = vector5;
			lFAFOAOKPKA[10 + EHJNMODJEAN] = vector7;
			lFAFOAOKPKA[11 + EHJNMODJEAN] = vector8;
			float num5 = 0f;
			float aMFCENFNAJJ = (fHBFCAEGPOH[EHJNMODJEAN + 2].x - EHGOOEHDNMM.x) / (AHPGGJALELA.x - EHGOOEHDNMM.x);
			float hJLOCAEAFMJ = Mathf.Abs(FKKNEBNCLIB);
			Vector2[] fJPNPHPFBFJ = m_textInfo.meshInfo[0].FJPNPHPFBFJ;
			fJPNPHPFBFJ[EHJNMODJEAN] = FAGDCKGGMLJ(0f, 0f, hJLOCAEAFMJ);
			fJPNPHPFBFJ[1 + EHJNMODJEAN] = FAGDCKGGMLJ(0f, 1f, hJLOCAEAFMJ);
			fJPNPHPFBFJ[2 + EHJNMODJEAN] = FAGDCKGGMLJ(aMFCENFNAJJ, 1f, hJLOCAEAFMJ);
			fJPNPHPFBFJ[3 + EHJNMODJEAN] = FAGDCKGGMLJ(aMFCENFNAJJ, 0f, hJLOCAEAFMJ);
			num5 = (fHBFCAEGPOH[EHJNMODJEAN + 4].x - EHGOOEHDNMM.x) / (AHPGGJALELA.x - EHGOOEHDNMM.x);
			aMFCENFNAJJ = (fHBFCAEGPOH[EHJNMODJEAN + 6].x - EHGOOEHDNMM.x) / (AHPGGJALELA.x - EHGOOEHDNMM.x);
			fJPNPHPFBFJ[4 + EHJNMODJEAN] = FAGDCKGGMLJ(num5, 0f, hJLOCAEAFMJ);
			fJPNPHPFBFJ[5 + EHJNMODJEAN] = FAGDCKGGMLJ(num5, 1f, hJLOCAEAFMJ);
			fJPNPHPFBFJ[6 + EHJNMODJEAN] = FAGDCKGGMLJ(aMFCENFNAJJ, 1f, hJLOCAEAFMJ);
			fJPNPHPFBFJ[7 + EHJNMODJEAN] = FAGDCKGGMLJ(aMFCENFNAJJ, 0f, hJLOCAEAFMJ);
			num5 = (fHBFCAEGPOH[EHJNMODJEAN + 8].x - EHGOOEHDNMM.x) / (AHPGGJALELA.x - EHGOOEHDNMM.x);
			aMFCENFNAJJ = (fHBFCAEGPOH[EHJNMODJEAN + 6].x - EHGOOEHDNMM.x) / (AHPGGJALELA.x - EHGOOEHDNMM.x);
			fJPNPHPFBFJ[8 + EHJNMODJEAN] = FAGDCKGGMLJ(num5, 0f, hJLOCAEAFMJ);
			fJPNPHPFBFJ[9 + EHJNMODJEAN] = FAGDCKGGMLJ(num5, 1f, hJLOCAEAFMJ);
			fJPNPHPFBFJ[10 + EHJNMODJEAN] = FAGDCKGGMLJ(1f, 1f, hJLOCAEAFMJ);
			fJPNPHPFBFJ[11 + EHJNMODJEAN] = FAGDCKGGMLJ(1f, 0f, hJLOCAEAFMJ);
			Color32[] pMBHKFBDDND = m_textInfo.meshInfo[0].PMBHKFBDDND;
			pMBHKFBDDND[EHJNMODJEAN] = FNHEFDBFBMN;
			pMBHKFBDDND[1 + EHJNMODJEAN] = FNHEFDBFBMN;
			pMBHKFBDDND[2 + EHJNMODJEAN] = FNHEFDBFBMN;
			pMBHKFBDDND[3 + EHJNMODJEAN] = FNHEFDBFBMN;
			pMBHKFBDDND[4 + EHJNMODJEAN] = FNHEFDBFBMN;
			pMBHKFBDDND[5 + EHJNMODJEAN] = FNHEFDBFBMN;
			pMBHKFBDDND[6 + EHJNMODJEAN] = FNHEFDBFBMN;
			pMBHKFBDDND[7 + EHJNMODJEAN] = FNHEFDBFBMN;
			pMBHKFBDDND[8 + EHJNMODJEAN] = FNHEFDBFBMN;
			pMBHKFBDDND[9 + EHJNMODJEAN] = FNHEFDBFBMN;
			pMBHKFBDDND[10 + EHJNMODJEAN] = FNHEFDBFBMN;
			pMBHKFBDDND[11 + EHJNMODJEAN] = FNHEFDBFBMN;
			EHJNMODJEAN += 12;
		}

		protected virtual void JDEMMNCJGJK(Vector3 EHGOOEHDNMM, Vector3 AHPGGJALELA, ref int EHJNMODJEAN, Color32 OFCEJMNBFOJ)
		{
			if (EDEHAJPLEKI == null)
			{
				if (!TMP_Settings.warningsDisabled)
				{
					Debug.LogWarning("Unable to add underline since the Font Asset doesn't contain the underline character.", this);
				}
				return;
			}
			int num = EHJNMODJEAN + 4;
			if (num > m_textInfo.meshInfo[0].FHBFCAEGPOH.Length)
			{
				m_textInfo.meshInfo[0].CMGCBJCIJNB(num / 4);
			}
			Vector3[] fHBFCAEGPOH = m_textInfo.meshInfo[0].FHBFCAEGPOH;
			fHBFCAEGPOH[EHJNMODJEAN] = EHGOOEHDNMM;
			fHBFCAEGPOH[EHJNMODJEAN + 1] = new Vector3(EHGOOEHDNMM.x, AHPGGJALELA.y, 0f);
			fHBFCAEGPOH[EHJNMODJEAN + 2] = AHPGGJALELA;
			fHBFCAEGPOH[EHJNMODJEAN + 3] = new Vector3(AHPGGJALELA.x, EHGOOEHDNMM.y, 0f);
			Vector2[] lFAFOAOKPKA = m_textInfo.meshInfo[0].LFAFOAOKPKA;
			Vector2 vector = new Vector2((EDEHAJPLEKI.x + EDEHAJPLEKI.width / 2f) / m_fontAsset.fontInfo.AtlasWidth, 1f - (EDEHAJPLEKI.y + EDEHAJPLEKI.height / 2f) / m_fontAsset.fontInfo.AtlasHeight);
			lFAFOAOKPKA[EHJNMODJEAN] = vector;
			lFAFOAOKPKA[1 + EHJNMODJEAN] = vector;
			lFAFOAOKPKA[2 + EHJNMODJEAN] = vector;
			lFAFOAOKPKA[3 + EHJNMODJEAN] = vector;
			Vector2[] fJPNPHPFBFJ = m_textInfo.meshInfo[0].FJPNPHPFBFJ;
			Vector2 vector2 = new Vector2(0f, 1f);
			fJPNPHPFBFJ[EHJNMODJEAN] = vector2;
			fJPNPHPFBFJ[1 + EHJNMODJEAN] = vector2;
			fJPNPHPFBFJ[2 + EHJNMODJEAN] = vector2;
			fJPNPHPFBFJ[3 + EHJNMODJEAN] = vector2;
			Color32[] pMBHKFBDDND = m_textInfo.meshInfo[0].PMBHKFBDDND;
			OFCEJMNBFOJ.a = ((EPCFNBCMCHK.a >= OFCEJMNBFOJ.a) ? OFCEJMNBFOJ.a : EPCFNBCMCHK.a);
			pMBHKFBDDND[EHJNMODJEAN] = OFCEJMNBFOJ;
			pMBHKFBDDND[1 + EHJNMODJEAN] = OFCEJMNBFOJ;
			pMBHKFBDDND[2 + EHJNMODJEAN] = OFCEJMNBFOJ;
			pMBHKFBDDND[3 + EHJNMODJEAN] = OFCEJMNBFOJ;
			EHJNMODJEAN += 4;
		}

		protected void BFCDKEKLEJF()
		{
			if (m_text == null)
			{
				if (TMP_Settings.autoSizeTextContainer)
				{
					OFBCJEKCLMH = true;
				}
				else
				{
					HBKNOEILBLE = GPPKOGCLKPL;
					if (GetType() == typeof(TextMeshPro))
					{
						HBKNOEILBLE.sizeDelta = TMP_Settings.defaultTextMeshProTextContainerSize;
					}
					else
					{
						HBKNOEILBLE.sizeDelta = TMP_Settings.defaultTextMeshProUITextContainerSize;
					}
				}
				m_enableWordWrapping = TMP_Settings.enableWordWrapping;
				m_enableKerning = TMP_Settings.enableKerning;
				m_enableExtraPadding = TMP_Settings.enableExtraPadding;
				m_tintAllSprites = TMP_Settings.enableTintAllSprites;
				m_parseCtrlCharacters = TMP_Settings.enableParseEscapeCharacters;
				m_fontSize = (m_fontSizeBase = TMP_Settings.defaultFontSize);
				m_fontSizeMin = m_fontSize * TMP_Settings.defaultTextAutoSizingMinRatio;
				m_fontSizeMax = m_fontSize * TMP_Settings.defaultTextAutoSizingMaxRatio;
				m_isAlignmentEnumConverted = true;
			}
			else if (!m_isAlignmentEnumConverted)
			{
				m_isAlignmentEnumConverted = true;
				m_textAlignment = NIAJFMEAPJJ.JNPPBGOBGBE(m_textAlignment);
			}
		}

		protected void GCBKMPMCGNO(TMP_FontAsset PIJNMJOHBIE)
		{
			if (!PIJNMJOHBIE.characterDictionary.TryGetValue(95, out EDEHAJPLEKI))
			{
			}
			if (PIJNMJOHBIE.characterDictionary.TryGetValue(8230, out KHNLFLGPDJL))
			{
			}
		}

		protected void ADLJBGMLLOG(int[] FBPAOINOCHI, int POPJPHDIOFL, int AGLDCMJAPHK, char FMFABAKPMLB)
		{
			FBPAOINOCHI[POPJPHDIOFL] = FMFABAKPMLB;
			for (int i = POPJPHDIOFL + AGLDCMJAPHK; i < FBPAOINOCHI.Length; i++)
			{
				FBPAOINOCHI[i - 3] = FBPAOINOCHI[i];
			}
		}

		protected TMP_FontAsset EKCHMDNJLCP(int PMJMEBGDBJI)
		{
			bool flag = (CCLHEBEBBGN & BCIEOOJOMDO.Italic) == BCIEOOJOMDO.Italic || (m_fontStyle & BCIEOOJOMDO.Italic) == BCIEOOJOMDO.Italic;
			TMP_FontAsset tMP_FontAsset = null;
			int num = PMJMEBGDBJI / 100;
			if (flag)
			{
				return AFEJPPDMPHE.fontWeights[num].italicTypeface;
			}
			return AFEJPPDMPHE.fontWeights[num].regularTypeface;
		}

		protected virtual void HPDBJNLMBED(bool BGEDKGLJIGM)
		{
		}

		protected virtual void EACFEBIIMJF()
		{
		}

		public virtual void ClearMesh()
		{
		}

		public virtual void ClearMesh(bool EBOBMKLBCKK)
		{
		}

		public virtual string GetParsedText()
		{
			if (m_textInfo == null)
			{
				return string.Empty;
			}
			int characterCount = m_textInfo.characterCount;
			char[] array = new char[characterCount];
			for (int i = 0; i < characterCount && i < m_textInfo.characterInfo.Length; i++)
			{
				array[i] = m_textInfo.characterInfo[i].AONJCHFEHOM;
			}
			return new string(array);
		}

		protected Vector2 FAGDCKGGMLJ(float AMFCENFNAJJ, float CNLILOEEBOJ, float HJLOCAEAFMJ)
		{
			Vector2 result = default(Vector2);
			result.x = (int)(AMFCENFNAJJ * 511f);
			result.y = (int)(CNLILOEEBOJ * 511f);
			result.x = result.x * 4096f + result.y;
			result.y = HJLOCAEAFMJ;
			return result;
		}

		protected float FAGDCKGGMLJ(float AMFCENFNAJJ, float CNLILOEEBOJ)
		{
			double num = (int)(AMFCENFNAJJ * 511f);
			double num2 = (int)(CNLILOEEBOJ * 511f);
			return (float)(num * 4096.0 + num2);
		}

		protected int ELOPCHGFKGE(char PEGNALIKDPB)
		{
			switch (PEGNALIKDPB)
			{
			case '0':
				return 0;
			case '1':
				return 1;
			case '2':
				return 2;
			case '3':
				return 3;
			case '4':
				return 4;
			case '5':
				return 5;
			case '6':
				return 6;
			case '7':
				return 7;
			case '8':
				return 8;
			case '9':
				return 9;
			case 'A':
				return 10;
			case 'B':
				return 11;
			case 'C':
				return 12;
			case 'D':
				return 13;
			case 'E':
				return 14;
			case 'F':
				return 15;
			case 'a':
				return 10;
			case 'b':
				return 11;
			case 'c':
				return 12;
			case 'd':
				return 13;
			case 'e':
				return 14;
			case 'f':
				return 15;
			default:
				return 15;
			}
		}

		protected int PDCBOFAOJBE(int PLCFEOMGCFK)
		{
			int num = ELOPCHGFKGE(m_text[PLCFEOMGCFK]) << 12;
			num += ELOPCHGFKGE(m_text[PLCFEOMGCFK + 1]) << 8;
			num += ELOPCHGFKGE(m_text[PLCFEOMGCFK + 2]) << 4;
			return num + ELOPCHGFKGE(m_text[PLCFEOMGCFK + 3]);
		}

		protected int LDCNILFACEE(int PLCFEOMGCFK)
		{
			int num = 0;
			num += ELOPCHGFKGE(m_text[PLCFEOMGCFK]) << 30;
			num += ELOPCHGFKGE(m_text[PLCFEOMGCFK + 1]) << 24;
			num += ELOPCHGFKGE(m_text[PLCFEOMGCFK + 2]) << 20;
			num += ELOPCHGFKGE(m_text[PLCFEOMGCFK + 3]) << 16;
			num += ELOPCHGFKGE(m_text[PLCFEOMGCFK + 4]) << 12;
			num += ELOPCHGFKGE(m_text[PLCFEOMGCFK + 5]) << 8;
			num += ELOPCHGFKGE(m_text[PLCFEOMGCFK + 6]) << 4;
			return num + ELOPCHGFKGE(m_text[PLCFEOMGCFK + 7]);
		}

		protected Color32 HJLFKIKFGAH(char[] AEGBHLFFCHP, int IJALBKBCEBD)
		{
			switch (IJALBKBCEBD)
			{
			case 4:
			{
				byte r8 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[1]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[1]));
				byte g8 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[2]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[2]));
				byte b8 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[3]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[3]));
				return new Color32(r8, g8, b8, byte.MaxValue);
			}
			case 5:
			{
				byte r7 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[1]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[1]));
				byte g7 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[2]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[2]));
				byte b7 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[3]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[3]));
				byte a4 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[4]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[4]));
				return new Color32(r7, g7, b7, a4);
			}
			case 7:
			{
				byte r6 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[1]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[2]));
				byte g6 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[3]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[4]));
				byte b6 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[5]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[6]));
				return new Color32(r6, g6, b6, byte.MaxValue);
			}
			case 9:
			{
				byte r5 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[1]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[2]));
				byte g5 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[3]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[4]));
				byte b5 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[5]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[6]));
				byte a3 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[7]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[8]));
				return new Color32(r5, g5, b5, a3);
			}
			case 10:
			{
				byte r4 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[7]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[7]));
				byte g4 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[8]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[8]));
				byte b4 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[9]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[9]));
				return new Color32(r4, g4, b4, byte.MaxValue);
			}
			case 11:
			{
				byte r3 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[7]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[7]));
				byte g3 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[8]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[8]));
				byte b3 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[9]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[9]));
				byte a2 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[10]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[10]));
				return new Color32(r3, g3, b3, a2);
			}
			case 13:
			{
				byte r2 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[7]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[8]));
				byte g2 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[9]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[10]));
				byte b2 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[11]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[12]));
				return new Color32(r2, g2, b2, byte.MaxValue);
			}
			case 15:
			{
				byte r = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[7]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[8]));
				byte g = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[9]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[10]));
				byte b = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[11]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[12]));
				byte a = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[13]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[14]));
				return new Color32(r, g, b, a);
			}
			default:
				return new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
			}
		}

		protected Color32 HJLFKIKFGAH(char[] AEGBHLFFCHP, int KKMNKJJENIL, int EOFAGACBNFP)
		{
			switch (EOFAGACBNFP)
			{
			case 7:
			{
				byte r2 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[KKMNKJJENIL + 1]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[KKMNKJJENIL + 2]));
				byte g2 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[KKMNKJJENIL + 3]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[KKMNKJJENIL + 4]));
				byte b2 = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[KKMNKJJENIL + 5]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[KKMNKJJENIL + 6]));
				return new Color32(r2, g2, b2, byte.MaxValue);
			}
			case 9:
			{
				byte r = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[KKMNKJJENIL + 1]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[KKMNKJJENIL + 2]));
				byte g = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[KKMNKJJENIL + 3]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[KKMNKJJENIL + 4]));
				byte b = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[KKMNKJJENIL + 5]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[KKMNKJJENIL + 6]));
				byte a = (byte)(ELOPCHGFKGE(AEGBHLFFCHP[KKMNKJJENIL + 7]) * 16 + ELOPCHGFKGE(AEGBHLFFCHP[KKMNKJJENIL + 8]));
				return new Color32(r, g, b, a);
			}
			default:
				return MCCKLLJFKGH;
			}
		}

		private int HNNPOGOPBGB(char[] FBPAOINOCHI, int KKMNKJJENIL, int EOFAGACBNFP, ref float[] IJJHBEECMBP)
		{
			int JCOPKLPJJCE = KKMNKJJENIL;
			int num = 0;
			while (JCOPKLPJJCE < KKMNKJJENIL + EOFAGACBNFP)
			{
				IJJHBEECMBP[num] = BIFBJEJOPMB(FBPAOINOCHI, KKMNKJJENIL, EOFAGACBNFP, out JCOPKLPJJCE);
				EOFAGACBNFP -= JCOPKLPJJCE - KKMNKJJENIL + 1;
				KKMNKJJENIL = JCOPKLPJJCE + 1;
				num++;
			}
			return num;
		}

		protected float BIFBJEJOPMB(char[] FBPAOINOCHI, int KKMNKJJENIL, int EOFAGACBNFP)
		{
			int JCOPKLPJJCE = 0;
			return BIFBJEJOPMB(FBPAOINOCHI, KKMNKJJENIL, EOFAGACBNFP, out JCOPKLPJJCE);
		}

		protected float BIFBJEJOPMB(char[] FBPAOINOCHI, int KKMNKJJENIL, int EOFAGACBNFP, out int JCOPKLPJJCE)
		{
			if (KKMNKJJENIL == 0)
			{
				JCOPKLPJJCE = 0;
				return -9999f;
			}
			int num = KKMNKJJENIL + EOFAGACBNFP;
			float num2 = 0f;
			int num3 = 0;
			int num4 = 0;
			int num5 = 1;
			for (int i = KKMNKJJENIL; i < num; i++)
			{
				char c = FBPAOINOCHI[i];
				switch (c)
				{
				case '.':
					num4 = i;
					num3 = -1;
					continue;
				case '-':
					num5 = -1;
					continue;
				case '+':
					num5 = 1;
					continue;
				case ',':
					JCOPKLPJJCE = i;
					return num2 * (float)num5;
				case ' ':
					continue;
				}
				if (!char.IsDigit(c))
				{
					JCOPKLPJJCE = i;
					return -9999f;
				}
				switch (num3)
				{
				case 0:
					num2 = FBPAOINOCHI[i] - 48;
					break;
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
					num2 = num2 * 10f + (float)(int)FBPAOINOCHI[i] - 48f;
					break;
				case -1:
					num2 += (float)(FBPAOINOCHI[i] - 48) * 0.1f;
					break;
				case -2:
					num2 += (float)(FBPAOINOCHI[i] - 48) * 0.01f;
					break;
				case -3:
					num2 += (float)(FBPAOINOCHI[i] - 48) * 0.001f;
					break;
				case -4:
					num2 += (float)(FBPAOINOCHI[i] - 48) * 0.0001f;
					break;
				case -5:
					num2 += (float)(FBPAOINOCHI[i] - 48) * 1E-05f;
					break;
				}
				num3 = ((num4 != 0) ? (num3 - 1) : (num3 + 1));
			}
			JCOPKLPJJCE = num;
			return num2 *= (float)num5;
		}

		protected bool ACLAAHPAFMI(int[] FBPAOINOCHI, int KKMNKJJENIL, out int OKEFBABJGLB)
		{
			int num = 0;
			byte b = 0;
			OLGLEGEMBJD oLGLEGEMBJD = OLGLEGEMBJD.Pixels;
			PKMBJEGOPLI pKMBJEGOPLI = PKMBJEGOPLI.None;
			int num2 = 0;
			POAMHMDFAIN[num2].ABLDGMBADCH = 0;
			POAMHMDFAIN[num2].ONACNKNBLOM = PKMBJEGOPLI.None;
			POAMHMDFAIN[num2].GEACCHGKOFJ = 0;
			POAMHMDFAIN[num2].KBCDHNEGNNI = 0;
			POAMHMDFAIN[num2].CDAMPKLJDEH = 0;
			POAMHMDFAIN[1].ABLDGMBADCH = 0;
			POAMHMDFAIN[2].ABLDGMBADCH = 0;
			POAMHMDFAIN[3].ABLDGMBADCH = 0;
			POAMHMDFAIN[4].ABLDGMBADCH = 0;
			OKEFBABJGLB = KKMNKJJENIL;
			bool flag = false;
			bool flag2 = false;
			for (int i = KKMNKJJENIL; i < FBPAOINOCHI.Length && FBPAOINOCHI[i] != 0; i++)
			{
				if (num >= LKNOAGBKDDD.Length)
				{
					break;
				}
				if (FBPAOINOCHI[i] == 60)
				{
					break;
				}
				if (FBPAOINOCHI[i] == 62)
				{
					flag2 = true;
					OKEFBABJGLB = i;
					LKNOAGBKDDD[num] = '\0';
					break;
				}
				LKNOAGBKDDD[num] = (char)FBPAOINOCHI[i];
				num++;
				if (b == 1)
				{
					switch (pKMBJEGOPLI)
					{
					case PKMBJEGOPLI.None:
						if (FBPAOINOCHI[i] == 43 || FBPAOINOCHI[i] == 45 || char.IsDigit((char)FBPAOINOCHI[i]))
						{
							pKMBJEGOPLI = PKMBJEGOPLI.NumericalValue;
							POAMHMDFAIN[num2].ONACNKNBLOM = PKMBJEGOPLI.NumericalValue;
							POAMHMDFAIN[num2].KBCDHNEGNNI = num - 1;
							POAMHMDFAIN[num2].CDAMPKLJDEH++;
						}
						else if (FBPAOINOCHI[i] == 35)
						{
							pKMBJEGOPLI = PKMBJEGOPLI.ColorValue;
							POAMHMDFAIN[num2].ONACNKNBLOM = PKMBJEGOPLI.ColorValue;
							POAMHMDFAIN[num2].KBCDHNEGNNI = num - 1;
							POAMHMDFAIN[num2].CDAMPKLJDEH++;
						}
						else if (FBPAOINOCHI[i] == 34)
						{
							pKMBJEGOPLI = PKMBJEGOPLI.StringValue;
							POAMHMDFAIN[num2].ONACNKNBLOM = PKMBJEGOPLI.StringValue;
							POAMHMDFAIN[num2].KBCDHNEGNNI = num;
						}
						else
						{
							pKMBJEGOPLI = PKMBJEGOPLI.StringValue;
							POAMHMDFAIN[num2].ONACNKNBLOM = PKMBJEGOPLI.StringValue;
							POAMHMDFAIN[num2].KBCDHNEGNNI = num - 1;
							POAMHMDFAIN[num2].GEACCHGKOFJ = ((POAMHMDFAIN[num2].GEACCHGKOFJ << 5) + POAMHMDFAIN[num2].GEACCHGKOFJ) ^ FBPAOINOCHI[i];
							POAMHMDFAIN[num2].CDAMPKLJDEH++;
						}
						break;
					case PKMBJEGOPLI.NumericalValue:
						if (FBPAOINOCHI[i] == 112 || FBPAOINOCHI[i] == 101 || FBPAOINOCHI[i] == 37 || FBPAOINOCHI[i] == 32)
						{
							b = 2;
							pKMBJEGOPLI = PKMBJEGOPLI.None;
							num2++;
							POAMHMDFAIN[num2].ABLDGMBADCH = 0;
							POAMHMDFAIN[num2].ONACNKNBLOM = PKMBJEGOPLI.None;
							POAMHMDFAIN[num2].GEACCHGKOFJ = 0;
							POAMHMDFAIN[num2].KBCDHNEGNNI = 0;
							POAMHMDFAIN[num2].CDAMPKLJDEH = 0;
							if (FBPAOINOCHI[i] == 101)
							{
								oLGLEGEMBJD = OLGLEGEMBJD.FontUnits;
							}
							else if (FBPAOINOCHI[i] == 37)
							{
								oLGLEGEMBJD = OLGLEGEMBJD.Percentage;
							}
						}
						else if (b != 2)
						{
							POAMHMDFAIN[num2].CDAMPKLJDEH++;
						}
						break;
					case PKMBJEGOPLI.ColorValue:
						if (FBPAOINOCHI[i] != 32)
						{
							POAMHMDFAIN[num2].CDAMPKLJDEH++;
							break;
						}
						b = 2;
						pKMBJEGOPLI = PKMBJEGOPLI.None;
						num2++;
						POAMHMDFAIN[num2].ABLDGMBADCH = 0;
						POAMHMDFAIN[num2].ONACNKNBLOM = PKMBJEGOPLI.None;
						POAMHMDFAIN[num2].GEACCHGKOFJ = 0;
						POAMHMDFAIN[num2].KBCDHNEGNNI = 0;
						POAMHMDFAIN[num2].CDAMPKLJDEH = 0;
						break;
					case PKMBJEGOPLI.StringValue:
						if (FBPAOINOCHI[i] != 34)
						{
							POAMHMDFAIN[num2].GEACCHGKOFJ = ((POAMHMDFAIN[num2].GEACCHGKOFJ << 5) + POAMHMDFAIN[num2].GEACCHGKOFJ) ^ FBPAOINOCHI[i];
							POAMHMDFAIN[num2].CDAMPKLJDEH++;
							break;
						}
						b = 2;
						pKMBJEGOPLI = PKMBJEGOPLI.None;
						num2++;
						POAMHMDFAIN[num2].ABLDGMBADCH = 0;
						POAMHMDFAIN[num2].ONACNKNBLOM = PKMBJEGOPLI.None;
						POAMHMDFAIN[num2].GEACCHGKOFJ = 0;
						POAMHMDFAIN[num2].KBCDHNEGNNI = 0;
						POAMHMDFAIN[num2].CDAMPKLJDEH = 0;
						break;
					}
				}
				if (FBPAOINOCHI[i] == 61)
				{
					b = 1;
				}
				if (b == 0 && FBPAOINOCHI[i] == 32)
				{
					if (flag)
					{
						return false;
					}
					flag = true;
					b = 2;
					pKMBJEGOPLI = PKMBJEGOPLI.None;
					num2++;
					POAMHMDFAIN[num2].ABLDGMBADCH = 0;
					POAMHMDFAIN[num2].ONACNKNBLOM = PKMBJEGOPLI.None;
					POAMHMDFAIN[num2].GEACCHGKOFJ = 0;
					POAMHMDFAIN[num2].KBCDHNEGNNI = 0;
					POAMHMDFAIN[num2].CDAMPKLJDEH = 0;
				}
				if (b == 0)
				{
					POAMHMDFAIN[num2].ABLDGMBADCH = (POAMHMDFAIN[num2].ABLDGMBADCH << 3) - POAMHMDFAIN[num2].ABLDGMBADCH + FBPAOINOCHI[i];
				}
				if (b == 2 && FBPAOINOCHI[i] == 32)
				{
					b = 0;
				}
			}
			if (!flag2)
			{
				return false;
			}
			if (FGGFHMLKNJJ && POAMHMDFAIN[0].ABLDGMBADCH != 53822163 && POAMHMDFAIN[0].ABLDGMBADCH != 49429939)
			{
				return false;
			}
			if (POAMHMDFAIN[0].ABLDGMBADCH == 53822163 || POAMHMDFAIN[0].ABLDGMBADCH == 49429939)
			{
				FGGFHMLKNJJ = false;
				return true;
			}
			if (LKNOAGBKDDD[0] == '#' && num == 4)
			{
				EPCFNBCMCHK = HJLFKIKFGAH(LKNOAGBKDDD, num);
				EOGFNFBPHHJ.JEACJNAKLDJ(EPCFNBCMCHK);
				return true;
			}
			if (LKNOAGBKDDD[0] == '#' && num == 5)
			{
				EPCFNBCMCHK = HJLFKIKFGAH(LKNOAGBKDDD, num);
				EOGFNFBPHHJ.JEACJNAKLDJ(EPCFNBCMCHK);
				return true;
			}
			if (LKNOAGBKDDD[0] == '#' && num == 7)
			{
				EPCFNBCMCHK = HJLFKIKFGAH(LKNOAGBKDDD, num);
				EOGFNFBPHHJ.JEACJNAKLDJ(EPCFNBCMCHK);
				return true;
			}
			if (LKNOAGBKDDD[0] == '#' && num == 9)
			{
				EPCFNBCMCHK = HJLFKIKFGAH(LKNOAGBKDDD, num);
				EOGFNFBPHHJ.JEACJNAKLDJ(EPCFNBCMCHK);
				return true;
			}
			float num3 = 0f;
			Material GHPFOPNNJOB;
			switch (POAMHMDFAIN[0].ABLDGMBADCH)
			{
			case 66:
			case 98:
				CCLHEBEBBGN |= BCIEOOJOMDO.Bold;
				MKAJPJFKEPP.JEACJNAKLDJ(BCIEOOJOMDO.Bold);
				ENGCHNIHPBK = 700;
				IOAEEGOLEHI.JEACJNAKLDJ(700);
				return true;
			case 395:
			case 427:
				if ((m_fontStyle & BCIEOOJOMDO.Bold) != BCIEOOJOMDO.Bold)
				{
					ENGCHNIHPBK = IOAEEGOLEHI.CJOHLENDJGO();
					if (MKAJPJFKEPP.CJOHLENDJGO(BCIEOOJOMDO.Bold) == 0)
					{
						CCLHEBEBBGN &= (BCIEOOJOMDO)(-2);
					}
				}
				return true;
			case 73:
			case 105:
				CCLHEBEBBGN |= BCIEOOJOMDO.Italic;
				MKAJPJFKEPP.JEACJNAKLDJ(BCIEOOJOMDO.Italic);
				return true;
			case 402:
			case 434:
				if (MKAJPJFKEPP.CJOHLENDJGO(BCIEOOJOMDO.Italic) == 0)
				{
					CCLHEBEBBGN &= (BCIEOOJOMDO)(-3);
				}
				return true;
			case 83:
			case 115:
				CCLHEBEBBGN |= BCIEOOJOMDO.Strikethrough;
				MKAJPJFKEPP.JEACJNAKLDJ(BCIEOOJOMDO.Strikethrough);
				if (POAMHMDFAIN[1].ABLDGMBADCH == 281955 || POAMHMDFAIN[1].ABLDGMBADCH == 192323)
				{
					DNDMCGFIBJM = HJLFKIKFGAH(LKNOAGBKDDD, POAMHMDFAIN[1].KBCDHNEGNNI, POAMHMDFAIN[1].CDAMPKLJDEH);
				}
				else
				{
					DNDMCGFIBJM = EPCFNBCMCHK;
				}
				LEMAEBLIHBK.JEACJNAKLDJ(DNDMCGFIBJM);
				return true;
			case 412:
			case 444:
				if ((m_fontStyle & BCIEOOJOMDO.Strikethrough) != BCIEOOJOMDO.Strikethrough && MKAJPJFKEPP.CJOHLENDJGO(BCIEOOJOMDO.Strikethrough) == 0)
				{
					CCLHEBEBBGN &= (BCIEOOJOMDO)(-65);
				}
				return true;
			case 85:
			case 117:
				CCLHEBEBBGN |= BCIEOOJOMDO.Underline;
				MKAJPJFKEPP.JEACJNAKLDJ(BCIEOOJOMDO.Underline);
				if (POAMHMDFAIN[1].ABLDGMBADCH == 281955 || POAMHMDFAIN[1].ABLDGMBADCH == 192323)
				{
					HEFLDLNICAK = HJLFKIKFGAH(LKNOAGBKDDD, POAMHMDFAIN[1].KBCDHNEGNNI, POAMHMDFAIN[1].CDAMPKLJDEH);
				}
				else
				{
					HEFLDLNICAK = EPCFNBCMCHK;
				}
				FNPOGPIGCIN.JEACJNAKLDJ(HEFLDLNICAK);
				return true;
			case 414:
			case 446:
				if ((m_fontStyle & BCIEOOJOMDO.Underline) != BCIEOOJOMDO.Underline)
				{
					HEFLDLNICAK = FNPOGPIGCIN.CJOHLENDJGO();
					if (MKAJPJFKEPP.CJOHLENDJGO(BCIEOOJOMDO.Underline) == 0)
					{
						CCLHEBEBBGN &= (BCIEOOJOMDO)(-5);
					}
				}
				return true;
			case 30245:
			case 43045:
				CCLHEBEBBGN |= BCIEOOJOMDO.Highlight;
				MKAJPJFKEPP.JEACJNAKLDJ(BCIEOOJOMDO.Highlight);
				EDCPEAJCPLG = HJLFKIKFGAH(LKNOAGBKDDD, POAMHMDFAIN[0].KBCDHNEGNNI, POAMHMDFAIN[0].CDAMPKLJDEH);
				KOOKMGIBAIG.JEACJNAKLDJ(EDCPEAJCPLG);
				return true;
			case 143092:
			case 155892:
				if ((m_fontStyle & BCIEOOJOMDO.Highlight) != BCIEOOJOMDO.Highlight)
				{
					EDCPEAJCPLG = KOOKMGIBAIG.CJOHLENDJGO();
					if (MKAJPJFKEPP.CJOHLENDJGO(BCIEOOJOMDO.Highlight) == 0)
					{
						CCLHEBEBBGN &= (BCIEOOJOMDO)(-513);
					}
				}
				return true;
			case 4728:
			case 6552:
				GEHMOIPKBGD *= ((!(AFEJPPDMPHE.fontInfo.SubSize > 0f)) ? 1f : AFEJPPDMPHE.fontInfo.SubSize);
				HDHGLHPMBPG += AFEJPPDMPHE.fontInfo.SubscriptOffset * MEPDJFGMGOK * GEHMOIPKBGD;
				MKAJPJFKEPP.JEACJNAKLDJ(BCIEOOJOMDO.Subscript);
				CCLHEBEBBGN |= BCIEOOJOMDO.Subscript;
				return true;
			case 20849:
			case 22673:
				if ((CCLHEBEBBGN & BCIEOOJOMDO.Subscript) == BCIEOOJOMDO.Subscript)
				{
					if (GEHMOIPKBGD < 1f)
					{
						HDHGLHPMBPG -= AFEJPPDMPHE.fontInfo.SubscriptOffset * MEPDJFGMGOK * GEHMOIPKBGD;
						GEHMOIPKBGD /= ((!(AFEJPPDMPHE.fontInfo.SubSize > 0f)) ? 1f : AFEJPPDMPHE.fontInfo.SubSize);
					}
					if (MKAJPJFKEPP.CJOHLENDJGO(BCIEOOJOMDO.Subscript) == 0)
					{
						CCLHEBEBBGN &= (BCIEOOJOMDO)(-257);
					}
				}
				return true;
			case 4742:
			case 6566:
				GEHMOIPKBGD *= ((!(AFEJPPDMPHE.fontInfo.SubSize > 0f)) ? 1f : AFEJPPDMPHE.fontInfo.SubSize);
				HDHGLHPMBPG += AFEJPPDMPHE.fontInfo.SuperscriptOffset * MEPDJFGMGOK * GEHMOIPKBGD;
				MKAJPJFKEPP.JEACJNAKLDJ(BCIEOOJOMDO.Superscript);
				CCLHEBEBBGN |= BCIEOOJOMDO.Superscript;
				return true;
			case 20863:
			case 22687:
				if ((CCLHEBEBBGN & BCIEOOJOMDO.Superscript) == BCIEOOJOMDO.Superscript)
				{
					if (GEHMOIPKBGD < 1f)
					{
						HDHGLHPMBPG -= AFEJPPDMPHE.fontInfo.SuperscriptOffset * MEPDJFGMGOK * GEHMOIPKBGD;
						GEHMOIPKBGD /= ((!(AFEJPPDMPHE.fontInfo.SubSize > 0f)) ? 1f : AFEJPPDMPHE.fontInfo.SubSize);
					}
					if (MKAJPJFKEPP.CJOHLENDJGO(BCIEOOJOMDO.Superscript) == 0)
					{
						CCLHEBEBBGN &= (BCIEOOJOMDO)(-129);
					}
				}
				return true;
			case -330774850:
			case 2012149182:
				num3 = BIFBJEJOPMB(LKNOAGBKDDD, POAMHMDFAIN[0].KBCDHNEGNNI, POAMHMDFAIN[0].CDAMPKLJDEH);
				if (num3 == -9999f || num3 == 0f)
				{
					return false;
				}
				if ((m_fontStyle & BCIEOOJOMDO.Bold) == BCIEOOJOMDO.Bold)
				{
					return true;
				}
				CCLHEBEBBGN &= (BCIEOOJOMDO)(-2);
				switch ((int)num3)
				{
				case 100:
					ENGCHNIHPBK = 100;
					break;
				case 200:
					ENGCHNIHPBK = 200;
					break;
				case 300:
					ENGCHNIHPBK = 300;
					break;
				case 400:
					ENGCHNIHPBK = 400;
					break;
				case 500:
					ENGCHNIHPBK = 500;
					break;
				case 600:
					ENGCHNIHPBK = 600;
					break;
				case 700:
					ENGCHNIHPBK = 700;
					CCLHEBEBBGN |= BCIEOOJOMDO.Bold;
					break;
				case 800:
					ENGCHNIHPBK = 800;
					break;
				case 900:
					ENGCHNIHPBK = 900;
					break;
				}
				IOAEEGOLEHI.JEACJNAKLDJ(ENGCHNIHPBK);
				return true;
			case -1885698441:
			case 457225591:
				ENGCHNIHPBK = IOAEEGOLEHI.CJOHLENDJGO();
				if (ENGCHNIHPBK == 400)
				{
					CCLHEBEBBGN &= (BCIEOOJOMDO)(-2);
				}
				return true;
			case 4556:
			case 6380:
				num3 = BIFBJEJOPMB(LKNOAGBKDDD, POAMHMDFAIN[0].KBCDHNEGNNI, POAMHMDFAIN[0].CDAMPKLJDEH);
				if (num3 == -9999f)
				{
					return false;
				}
				switch (oLGLEGEMBJD)
				{
				case OLGLEGEMBJD.Pixels:
					PLALFBMFEEC = num3;
					return true;
				case OLGLEGEMBJD.FontUnits:
					PLALFBMFEEC = num3 * MEPDJFGMGOK * m_fontAsset.fontInfo.TabWidth / (float)(int)m_fontAsset.tabSize;
					return true;
				case OLGLEGEMBJD.Percentage:
					PLALFBMFEEC = IOOMPCBBCNK * num3 / 100f;
					return true;
				default:
					return false;
				}
			case 20677:
			case 22501:
				JEKJCMDPILC = false;
				return true;
			case 11642281:
			case 16034505:
				num3 = BIFBJEJOPMB(LKNOAGBKDDD, POAMHMDFAIN[0].KBCDHNEGNNI, POAMHMDFAIN[0].CDAMPKLJDEH);
				if (num3 == -9999f || num3 == 0f)
				{
					return false;
				}
				switch (oLGLEGEMBJD)
				{
				case OLGLEGEMBJD.Pixels:
					HDHGLHPMBPG = num3;
					return true;
				case OLGLEGEMBJD.FontUnits:
					HDHGLHPMBPG = num3 * MEPDJFGMGOK * m_fontAsset.fontInfo.Ascender;
					return true;
				case OLGLEGEMBJD.Percentage:
					return false;
				default:
					return false;
				}
			case 50348802:
			case 54741026:
				HDHGLHPMBPG = 0f;
				return true;
			case 31191:
			case 43991:
				if (m_overflowMode == OLMBEAODAPL.Page)
				{
					PLALFBMFEEC = KGDNHOEOOHO + GKEHAJKJCEF;
					GFIDNINNNAL = 0f;
					BHJLNHKINKN++;
					GEGDAJAOKKA = true;
				}
				return true;
			case 31169:
			case 43969:
				PIABLFACDIO = true;
				return true;
			case 144016:
			case 156816:
				PIABLFACDIO = false;
				return true;
			case 32745:
			case 45545:
				num3 = BIFBJEJOPMB(LKNOAGBKDDD, POAMHMDFAIN[0].KBCDHNEGNNI, POAMHMDFAIN[0].CDAMPKLJDEH);
				if (num3 == -9999f)
				{
					return false;
				}
				switch (oLGLEGEMBJD)
				{
				case OLGLEGEMBJD.Pixels:
					if (LKNOAGBKDDD[5] == '+')
					{
						MPIGOGEKIPI = m_fontSize + num3;
						FJJAGAJLDJG.JEACJNAKLDJ(MPIGOGEKIPI);
						MEPDJFGMGOK = MPIGOGEKIPI / AFEJPPDMPHE.fontInfo.PointSize * AFEJPPDMPHE.fontInfo.Scale * ((!m_isOrthographic) ? 0.1f : 1f);
						return true;
					}
					if (LKNOAGBKDDD[5] == '-')
					{
						MPIGOGEKIPI = m_fontSize + num3;
						FJJAGAJLDJG.JEACJNAKLDJ(MPIGOGEKIPI);
						MEPDJFGMGOK = MPIGOGEKIPI / AFEJPPDMPHE.fontInfo.PointSize * AFEJPPDMPHE.fontInfo.Scale * ((!m_isOrthographic) ? 0.1f : 1f);
						return true;
					}
					MPIGOGEKIPI = num3;
					FJJAGAJLDJG.JEACJNAKLDJ(MPIGOGEKIPI);
					MEPDJFGMGOK = MPIGOGEKIPI / AFEJPPDMPHE.fontInfo.PointSize * AFEJPPDMPHE.fontInfo.Scale * ((!m_isOrthographic) ? 0.1f : 1f);
					return true;
				case OLGLEGEMBJD.FontUnits:
					MPIGOGEKIPI = m_fontSize * num3;
					FJJAGAJLDJG.JEACJNAKLDJ(MPIGOGEKIPI);
					MEPDJFGMGOK = MPIGOGEKIPI / AFEJPPDMPHE.fontInfo.PointSize * AFEJPPDMPHE.fontInfo.Scale * ((!m_isOrthographic) ? 0.1f : 1f);
					return true;
				case OLGLEGEMBJD.Percentage:
					MPIGOGEKIPI = m_fontSize * num3 / 100f;
					FJJAGAJLDJG.JEACJNAKLDJ(MPIGOGEKIPI);
					MEPDJFGMGOK = MPIGOGEKIPI / AFEJPPDMPHE.fontInfo.PointSize * AFEJPPDMPHE.fontInfo.Scale * ((!m_isOrthographic) ? 0.1f : 1f);
					return true;
				default:
					return false;
				}
			case 145592:
			case 158392:
				MPIGOGEKIPI = FJJAGAJLDJG.CJOHLENDJGO();
				MEPDJFGMGOK = MPIGOGEKIPI / AFEJPPDMPHE.fontInfo.PointSize * AFEJPPDMPHE.fontInfo.Scale * ((!m_isOrthographic) ? 0.1f : 1f);
				return true;
			case 28511:
			case 41311:
			{
				int gEACCHGKOFJ3 = POAMHMDFAIN[0].GEACCHGKOFJ;
				int aBLDGMBADCH2 = POAMHMDFAIN[1].ABLDGMBADCH;
				int gEACCHGKOFJ = POAMHMDFAIN[1].GEACCHGKOFJ;
				if (gEACCHGKOFJ3 == 764638571 || gEACCHGKOFJ3 == 523367755)
				{
					AFEJPPDMPHE = NDPGMAPHNNA[0].PIJNMJOHBIE;
					JBPPHIKOJPL = NDPGMAPHNNA[0].GHPFOPNNJOB;
					AIJEDOAJAPI = 0;
					MEPDJFGMGOK = MPIGOGEKIPI / AFEJPPDMPHE.fontInfo.PointSize * AFEJPPDMPHE.fontInfo.Scale * ((!m_isOrthographic) ? 0.1f : 1f);
					DBEFOGFNAME.JEACJNAKLDJ(NDPGMAPHNNA[0]);
					return true;
				}
				TMP_FontAsset PIJNMJOHBIE;
				if (!AGGEDHHPIOK.OIGAADCABKO(gEACCHGKOFJ3, out PIJNMJOHBIE))
				{
					PIJNMJOHBIE = Resources.Load<TMP_FontAsset>(TMP_Settings.defaultFontAssetPath + new string(LKNOAGBKDDD, POAMHMDFAIN[0].KBCDHNEGNNI, POAMHMDFAIN[0].CDAMPKLJDEH));
					if (PIJNMJOHBIE == null)
					{
						return false;
					}
					AGGEDHHPIOK.ELEIKNDCBBE(PIJNMJOHBIE);
				}
				if (aBLDGMBADCH2 == 0 && gEACCHGKOFJ == 0)
				{
					JBPPHIKOJPL = PIJNMJOHBIE.material;
					AIJEDOAJAPI = FMOBJPAGLEE.LBJKNANKAIP(JBPPHIKOJPL, PIJNMJOHBIE, NDPGMAPHNNA, GJCBEOHAMEH);
					DBEFOGFNAME.JEACJNAKLDJ(NDPGMAPHNNA[AIJEDOAJAPI]);
				}
				else
				{
					if (aBLDGMBADCH2 != 103415287 && aBLDGMBADCH2 != 72669687)
					{
						return false;
					}
					if (AGGEDHHPIOK.EOHJHBCMBBC(gEACCHGKOFJ, out GHPFOPNNJOB))
					{
						JBPPHIKOJPL = GHPFOPNNJOB;
						AIJEDOAJAPI = FMOBJPAGLEE.LBJKNANKAIP(JBPPHIKOJPL, PIJNMJOHBIE, NDPGMAPHNNA, GJCBEOHAMEH);
						DBEFOGFNAME.JEACJNAKLDJ(NDPGMAPHNNA[AIJEDOAJAPI]);
					}
					else
					{
						GHPFOPNNJOB = Resources.Load<Material>(TMP_Settings.defaultFontAssetPath + new string(LKNOAGBKDDD, POAMHMDFAIN[1].KBCDHNEGNNI, POAMHMDFAIN[1].CDAMPKLJDEH));
						if (GHPFOPNNJOB == null)
						{
							return false;
						}
						AGGEDHHPIOK.PKICMMCLKJA(gEACCHGKOFJ, GHPFOPNNJOB);
						JBPPHIKOJPL = GHPFOPNNJOB;
						AIJEDOAJAPI = FMOBJPAGLEE.LBJKNANKAIP(JBPPHIKOJPL, PIJNMJOHBIE, NDPGMAPHNNA, GJCBEOHAMEH);
						DBEFOGFNAME.JEACJNAKLDJ(NDPGMAPHNNA[AIJEDOAJAPI]);
					}
				}
				AFEJPPDMPHE = PIJNMJOHBIE;
				MEPDJFGMGOK = MPIGOGEKIPI / AFEJPPDMPHE.fontInfo.PointSize * AFEJPPDMPHE.fontInfo.Scale * ((!m_isOrthographic) ? 0.1f : 1f);
				return true;
			}
			case 141358:
			case 154158:
			{
				FMOBJPAGLEE fMOBJPAGLEE2 = DBEFOGFNAME.CJOHLENDJGO();
				AFEJPPDMPHE = fMOBJPAGLEE2.PIJNMJOHBIE;
				JBPPHIKOJPL = fMOBJPAGLEE2.GHPFOPNNJOB;
				AIJEDOAJAPI = fMOBJPAGLEE2.EHJNMODJEAN;
				MEPDJFGMGOK = MPIGOGEKIPI / AFEJPPDMPHE.fontInfo.PointSize * AFEJPPDMPHE.fontInfo.Scale * ((!m_isOrthographic) ? 0.1f : 1f);
				return true;
			}
			case 72669687:
			case 103415287:
			{
				int gEACCHGKOFJ = POAMHMDFAIN[0].GEACCHGKOFJ;
				if (gEACCHGKOFJ == 764638571 || gEACCHGKOFJ == 523367755)
				{
					if (AFEJPPDMPHE.atlas.GetInstanceID() != JBPPHIKOJPL.GetTexture(MOHPNOBPBBL.GKMMOOGJLHP).GetInstanceID())
					{
						return false;
					}
					JBPPHIKOJPL = NDPGMAPHNNA[0].GHPFOPNNJOB;
					AIJEDOAJAPI = 0;
					DBEFOGFNAME.JEACJNAKLDJ(NDPGMAPHNNA[0]);
					return true;
				}
				if (AGGEDHHPIOK.EOHJHBCMBBC(gEACCHGKOFJ, out GHPFOPNNJOB))
				{
					if (AFEJPPDMPHE.atlas.GetInstanceID() != GHPFOPNNJOB.GetTexture(MOHPNOBPBBL.GKMMOOGJLHP).GetInstanceID())
					{
						return false;
					}
					JBPPHIKOJPL = GHPFOPNNJOB;
					AIJEDOAJAPI = FMOBJPAGLEE.LBJKNANKAIP(JBPPHIKOJPL, AFEJPPDMPHE, NDPGMAPHNNA, GJCBEOHAMEH);
					DBEFOGFNAME.JEACJNAKLDJ(NDPGMAPHNNA[AIJEDOAJAPI]);
				}
				else
				{
					GHPFOPNNJOB = Resources.Load<Material>(TMP_Settings.defaultFontAssetPath + new string(LKNOAGBKDDD, POAMHMDFAIN[0].KBCDHNEGNNI, POAMHMDFAIN[0].CDAMPKLJDEH));
					if (GHPFOPNNJOB == null)
					{
						return false;
					}
					if (AFEJPPDMPHE.atlas.GetInstanceID() != GHPFOPNNJOB.GetTexture(MOHPNOBPBBL.GKMMOOGJLHP).GetInstanceID())
					{
						return false;
					}
					AGGEDHHPIOK.PKICMMCLKJA(gEACCHGKOFJ, GHPFOPNNJOB);
					JBPPHIKOJPL = GHPFOPNNJOB;
					AIJEDOAJAPI = FMOBJPAGLEE.LBJKNANKAIP(JBPPHIKOJPL, AFEJPPDMPHE, NDPGMAPHNNA, GJCBEOHAMEH);
					DBEFOGFNAME.JEACJNAKLDJ(NDPGMAPHNNA[AIJEDOAJAPI]);
				}
				return true;
			}
			case 343615334:
			case 374360934:
			{
				if (JBPPHIKOJPL.GetTexture(MOHPNOBPBBL.GKMMOOGJLHP).GetInstanceID() != DBEFOGFNAME.JHKBMLGGFHH().GHPFOPNNJOB.GetTexture(MOHPNOBPBBL.GKMMOOGJLHP).GetInstanceID())
				{
					return false;
				}
				FMOBJPAGLEE fMOBJPAGLEE = DBEFOGFNAME.CJOHLENDJGO();
				JBPPHIKOJPL = fMOBJPAGLEE.GHPFOPNNJOB;
				AIJEDOAJAPI = fMOBJPAGLEE.EHJNMODJEAN;
				return true;
			}
			case 230446:
			case 320078:
				num3 = BIFBJEJOPMB(LKNOAGBKDDD, POAMHMDFAIN[0].KBCDHNEGNNI, POAMHMDFAIN[0].CDAMPKLJDEH);
				if (num3 == -9999f || num3 == 0f)
				{
					return false;
				}
				switch (oLGLEGEMBJD)
				{
				case OLGLEGEMBJD.Pixels:
					PLALFBMFEEC += num3;
					return true;
				case OLGLEGEMBJD.FontUnits:
					PLALFBMFEEC += num3 * MEPDJFGMGOK * m_fontAsset.fontInfo.TabWidth / (float)(int)m_fontAsset.tabSize;
					return true;
				case OLGLEGEMBJD.Percentage:
					return false;
				default:
					return false;
				}
			case 186622:
			case 276254:
				if (POAMHMDFAIN[0].CDAMPKLJDEH != 3)
				{
					return false;
				}
				EPCFNBCMCHK.a = (byte)(ELOPCHGFKGE(LKNOAGBKDDD[7]) * 16 + ELOPCHGFKGE(LKNOAGBKDDD[8]));
				return true;
			case 1750458:
				return false;
			case 426:
				return true;
			case 30266:
			case 43066:
				if (OHKANPJHAFP && !CEOCLEMDMEE)
				{
					int linkCount = m_textInfo.linkCount;
					if (linkCount + 1 > m_textInfo.linkInfo.Length)
					{
						TMP_TextInfo.NKMKBLFBOFC(ref m_textInfo.linkInfo, linkCount + 1);
					}
					m_textInfo.linkInfo[linkCount].MHFABDJOCMG = this;
					m_textInfo.linkInfo[linkCount].CKFJKOFGBOL = POAMHMDFAIN[0].GEACCHGKOFJ;
					m_textInfo.linkInfo[linkCount].HKBLAGGHCNK = HEEDOMEABKA;
					m_textInfo.linkInfo[linkCount].PEFMNOMMFOA = KKMNKJJENIL + POAMHMDFAIN[0].KBCDHNEGNNI;
					m_textInfo.linkInfo[linkCount].IDBNHBEEAPI = POAMHMDFAIN[0].CDAMPKLJDEH;
					m_textInfo.linkInfo[linkCount].MLNFKBEPNFA(LKNOAGBKDDD, POAMHMDFAIN[0].KBCDHNEGNNI, POAMHMDFAIN[0].CDAMPKLJDEH);
				}
				return true;
			case 143113:
			case 155913:
				if (OHKANPJHAFP && !CEOCLEMDMEE)
				{
					m_textInfo.linkInfo[m_textInfo.linkCount].IAJHNMEHLCA = HEEDOMEABKA - m_textInfo.linkInfo[m_textInfo.linkCount].HKBLAGGHCNK;
					m_textInfo.linkCount++;
				}
				return true;
			case 186285:
			case 275917:
				switch (POAMHMDFAIN[0].GEACCHGKOFJ)
				{
				case 3774683:
					FPDOALAOBLE = KNOECCJHIDP.Left;
					IBLGHCLBFJG.JEACJNAKLDJ(FPDOALAOBLE);
					return true;
				case 136703040:
					FPDOALAOBLE = KNOECCJHIDP.Right;
					IBLGHCLBFJG.JEACJNAKLDJ(FPDOALAOBLE);
					return true;
				case -458210101:
					FPDOALAOBLE = KNOECCJHIDP.Center;
					IBLGHCLBFJG.JEACJNAKLDJ(FPDOALAOBLE);
					return true;
				case -523808257:
					FPDOALAOBLE = KNOECCJHIDP.Justified;
					IBLGHCLBFJG.JEACJNAKLDJ(FPDOALAOBLE);
					return true;
				case 122383428:
					FPDOALAOBLE = KNOECCJHIDP.Flush;
					IBLGHCLBFJG.JEACJNAKLDJ(FPDOALAOBLE);
					return true;
				default:
					return false;
				}
			case 976214:
			case 1065846:
				FPDOALAOBLE = IBLGHCLBFJG.CJOHLENDJGO();
				return true;
			case 237918:
			case 327550:
				num3 = BIFBJEJOPMB(LKNOAGBKDDD, POAMHMDFAIN[0].KBCDHNEGNNI, POAMHMDFAIN[0].CDAMPKLJDEH);
				if (num3 == -9999f || num3 == 0f)
				{
					return false;
				}
				switch (oLGLEGEMBJD)
				{
				case OLGLEGEMBJD.Pixels:
					IFAFCDFNNJN = num3;
					break;
				case OLGLEGEMBJD.FontUnits:
					return false;
				case OLGLEGEMBJD.Percentage:
					IFAFCDFNNJN = IOOMPCBBCNK * num3 / 100f;
					break;
				}
				return true;
			case 1027847:
			case 1117479:
				IFAFCDFNNJN = -1f;
				return true;
			case 192323:
			case 281955:
				if (LKNOAGBKDDD[6] == '#' && num == 10)
				{
					EPCFNBCMCHK = HJLFKIKFGAH(LKNOAGBKDDD, num);
					EOGFNFBPHHJ.JEACJNAKLDJ(EPCFNBCMCHK);
					return true;
				}
				if (LKNOAGBKDDD[6] == '#' && num == 11)
				{
					EPCFNBCMCHK = HJLFKIKFGAH(LKNOAGBKDDD, num);
					EOGFNFBPHHJ.JEACJNAKLDJ(EPCFNBCMCHK);
					return true;
				}
				if (LKNOAGBKDDD[6] == '#' && num == 13)
				{
					EPCFNBCMCHK = HJLFKIKFGAH(LKNOAGBKDDD, num);
					EOGFNFBPHHJ.JEACJNAKLDJ(EPCFNBCMCHK);
					return true;
				}
				if (LKNOAGBKDDD[6] == '#' && num == 15)
				{
					EPCFNBCMCHK = HJLFKIKFGAH(LKNOAGBKDDD, num);
					EOGFNFBPHHJ.JEACJNAKLDJ(EPCFNBCMCHK);
					return true;
				}
				switch (POAMHMDFAIN[0].GEACCHGKOFJ)
				{
				case 125395:
					EPCFNBCMCHK = Color.red;
					EOGFNFBPHHJ.JEACJNAKLDJ(EPCFNBCMCHK);
					return true;
				case 3573310:
					EPCFNBCMCHK = Color.blue;
					EOGFNFBPHHJ.JEACJNAKLDJ(EPCFNBCMCHK);
					return true;
				case 117905991:
					EPCFNBCMCHK = Color.black;
					EOGFNFBPHHJ.JEACJNAKLDJ(EPCFNBCMCHK);
					return true;
				case 121463835:
					EPCFNBCMCHK = Color.green;
					EOGFNFBPHHJ.JEACJNAKLDJ(EPCFNBCMCHK);
					return true;
				case 140357351:
					EPCFNBCMCHK = Color.white;
					EOGFNFBPHHJ.JEACJNAKLDJ(EPCFNBCMCHK);
					return true;
				case 26556144:
					EPCFNBCMCHK = new Color32(byte.MaxValue, 128, 0, byte.MaxValue);
					EOGFNFBPHHJ.JEACJNAKLDJ(EPCFNBCMCHK);
					return true;
				case -36881330:
					EPCFNBCMCHK = new Color32(160, 32, 240, byte.MaxValue);
					EOGFNFBPHHJ.JEACJNAKLDJ(EPCFNBCMCHK);
					return true;
				case 554054276:
					EPCFNBCMCHK = Color.yellow;
					EOGFNFBPHHJ.JEACJNAKLDJ(EPCFNBCMCHK);
					return true;
				default:
					return false;
				}
			case 1356515:
			case 1983971:
				num3 = BIFBJEJOPMB(LKNOAGBKDDD, POAMHMDFAIN[0].KBCDHNEGNNI, POAMHMDFAIN[0].CDAMPKLJDEH);
				if (num3 == -9999f || num3 == 0f)
				{
					return false;
				}
				switch (oLGLEGEMBJD)
				{
				case OLGLEGEMBJD.Pixels:
					OMGEAPDMJBN = num3;
					break;
				case OLGLEGEMBJD.FontUnits:
					OMGEAPDMJBN = num3;
					OMGEAPDMJBN *= MEPDJFGMGOK * m_fontAsset.fontInfo.TabWidth / (float)(int)m_fontAsset.tabSize;
					break;
				case OLGLEGEMBJD.Percentage:
					return false;
				}
				return true;
			case 6886018:
			case 7513474:
				if (!OHKANPJHAFP)
				{
					return true;
				}
				if (HEEDOMEABKA > 0)
				{
					PLALFBMFEEC -= OMGEAPDMJBN;
					m_textInfo.characterInfo[HEEDOMEABKA - 1].MDKGJAGDLHC = PLALFBMFEEC;
				}
				OMGEAPDMJBN = 0f;
				return true;
			case 1524585:
			case 2152041:
				num3 = BIFBJEJOPMB(LKNOAGBKDDD, POAMHMDFAIN[0].KBCDHNEGNNI, POAMHMDFAIN[0].CDAMPKLJDEH);
				if (num3 == -9999f || num3 == 0f)
				{
					return false;
				}
				switch (oLGLEGEMBJD)
				{
				case OLGLEGEMBJD.Pixels:
					CADPBEPINNM = num3;
					break;
				case OLGLEGEMBJD.FontUnits:
					CADPBEPINNM = num3;
					CADPBEPINNM *= MEPDJFGMGOK * m_fontAsset.fontInfo.TabWidth / (float)(int)m_fontAsset.tabSize;
					break;
				case OLGLEGEMBJD.Percentage:
					return false;
				}
				return true;
			case 7054088:
			case 7681544:
				CADPBEPINNM = 0f;
				return true;
			case 280416:
				return false;
			case 982252:
			case 1071884:
				EPCFNBCMCHK = EOGFNFBPHHJ.CJOHLENDJGO();
				return true;
			case 1441524:
			case 2068980:
				num3 = BIFBJEJOPMB(LKNOAGBKDDD, POAMHMDFAIN[0].KBCDHNEGNNI, POAMHMDFAIN[0].CDAMPKLJDEH);
				if (num3 == -9999f || num3 == 0f)
				{
					return false;
				}
				switch (oLGLEGEMBJD)
				{
				case OLGLEGEMBJD.Pixels:
					GKEHAJKJCEF = num3;
					break;
				case OLGLEGEMBJD.FontUnits:
					GKEHAJKJCEF = num3;
					GKEHAJKJCEF *= MEPDJFGMGOK * m_fontAsset.fontInfo.TabWidth / (float)(int)m_fontAsset.tabSize;
					break;
				case OLGLEGEMBJD.Percentage:
					GKEHAJKJCEF = IOOMPCBBCNK * num3 / 100f;
					break;
				}
				BNFNFGGNBGJ.JEACJNAKLDJ(GKEHAJKJCEF);
				PLALFBMFEEC = GKEHAJKJCEF;
				return true;
			case 6971027:
			case 7598483:
				GKEHAJKJCEF = BNFNFGGNBGJ.CJOHLENDJGO();
				return true;
			case -842656867:
			case 1109386397:
				num3 = BIFBJEJOPMB(LKNOAGBKDDD, POAMHMDFAIN[0].KBCDHNEGNNI, POAMHMDFAIN[0].CDAMPKLJDEH);
				if (num3 == -9999f || num3 == 0f)
				{
					return false;
				}
				switch (oLGLEGEMBJD)
				{
				case OLGLEGEMBJD.Pixels:
					KGDNHOEOOHO = num3;
					break;
				case OLGLEGEMBJD.FontUnits:
					KGDNHOEOOHO = num3;
					KGDNHOEOOHO *= MEPDJFGMGOK * m_fontAsset.fontInfo.TabWidth / (float)(int)m_fontAsset.tabSize;
					break;
				case OLGLEGEMBJD.Percentage:
					KGDNHOEOOHO = IOOMPCBBCNK * num3 / 100f;
					break;
				}
				PLALFBMFEEC += KGDNHOEOOHO;
				return true;
			case -445537194:
			case 1897386838:
				KGDNHOEOOHO = 0f;
				return true;
			case 1619421:
			case 2246877:
			{
				int gEACCHGKOFJ4 = POAMHMDFAIN[0].GEACCHGKOFJ;
				OOIILNOMGIL = -1;
				TMP_SpriteAsset GKDEMJDOOLB;
				if (POAMHMDFAIN[0].ONACNKNBLOM == PKMBJEGOPLI.None || POAMHMDFAIN[0].ONACNKNBLOM == PKMBJEGOPLI.NumericalValue)
				{
					if (m_spriteAsset != null)
					{
						HBLKKCJHFFK = m_spriteAsset;
					}
					else if (FDAFMNELPNF != null)
					{
						HBLKKCJHFFK = FDAFMNELPNF;
					}
					else if (FDAFMNELPNF == null)
					{
						if (TMP_Settings.defaultSpriteAsset != null)
						{
							FDAFMNELPNF = TMP_Settings.defaultSpriteAsset;
						}
						else
						{
							FDAFMNELPNF = Resources.Load<TMP_SpriteAsset>("Sprite Assets/Default Sprite Asset");
						}
						HBLKKCJHFFK = FDAFMNELPNF;
					}
					if (HBLKKCJHFFK == null)
					{
						return false;
					}
				}
				else if (AGGEDHHPIOK.KBGHDGBMIJH(gEACCHGKOFJ4, out GKDEMJDOOLB))
				{
					HBLKKCJHFFK = GKDEMJDOOLB;
				}
				else
				{
					if (GKDEMJDOOLB == null)
					{
						GKDEMJDOOLB = Resources.Load<TMP_SpriteAsset>(TMP_Settings.defaultSpriteAssetPath + new string(LKNOAGBKDDD, POAMHMDFAIN[0].KBCDHNEGNNI, POAMHMDFAIN[0].CDAMPKLJDEH));
					}
					if (GKDEMJDOOLB == null)
					{
						return false;
					}
					AGGEDHHPIOK.CNNEKEDEJBB(gEACCHGKOFJ4, GKDEMJDOOLB);
					HBLKKCJHFFK = GKDEMJDOOLB;
				}
				if (POAMHMDFAIN[0].ONACNKNBLOM == PKMBJEGOPLI.NumericalValue)
				{
					int num6 = (int)BIFBJEJOPMB(LKNOAGBKDDD, POAMHMDFAIN[0].KBCDHNEGNNI, POAMHMDFAIN[0].CDAMPKLJDEH);
					if (num6 == -9999)
					{
						return false;
					}
					if (num6 > HBLKKCJHFFK.spriteInfoList.Count - 1)
					{
						return false;
					}
					OOIILNOMGIL = num6;
				}
				IIHIHIELCKN = MCCKLLJFKGH;
				GKGFOHJGDMD = false;
				for (int k = 0; k < POAMHMDFAIN.Length && POAMHMDFAIN[k].ABLDGMBADCH != 0; k++)
				{
					int aBLDGMBADCH3 = POAMHMDFAIN[k].ABLDGMBADCH;
					int num7 = 0;
					switch (aBLDGMBADCH3)
					{
					case 30547:
					case 43347:
						num7 = HBLKKCJHFFK.GKLFEMKCFNH(POAMHMDFAIN[k].GEACCHGKOFJ);
						if (num7 == -1)
						{
							return false;
						}
						OOIILNOMGIL = num7;
						break;
					case 205930:
					case 295562:
						num7 = (int)BIFBJEJOPMB(LKNOAGBKDDD, POAMHMDFAIN[1].KBCDHNEGNNI, POAMHMDFAIN[1].CDAMPKLJDEH);
						if (num7 == -9999)
						{
							return false;
						}
						if (num7 > HBLKKCJHFFK.spriteInfoList.Count - 1)
						{
							return false;
						}
						OOIILNOMGIL = num7;
						break;
					case 33019:
					case 45819:
						GKGFOHJGDMD = BIFBJEJOPMB(LKNOAGBKDDD, POAMHMDFAIN[k].KBCDHNEGNNI, POAMHMDFAIN[k].CDAMPKLJDEH) != 0f;
						break;
					case 192323:
					case 281955:
						IIHIHIELCKN = HJLFKIKFGAH(LKNOAGBKDDD, POAMHMDFAIN[k].KBCDHNEGNNI, POAMHMDFAIN[k].CDAMPKLJDEH);
						break;
					case 26705:
					case 39505:
					{
						int num8 = HNNPOGOPBGB(LKNOAGBKDDD, POAMHMDFAIN[k].KBCDHNEGNNI, POAMHMDFAIN[k].CDAMPKLJDEH, ref AKDGIGDHIGO);
						if (num8 != 3)
						{
							return false;
						}
						OOIILNOMGIL = (int)AKDGIGDHIGO[0];
						if (OHKANPJHAFP)
						{
							JFMLLDIFICE.DoSpriteAnimation(HEEDOMEABKA, HBLKKCJHFFK, OOIILNOMGIL, (int)AKDGIGDHIGO[1], (int)AKDGIGDHIGO[2]);
						}
						break;
					}
					default:
						return false;
					case 1619421:
					case 2246877:
						break;
					}
				}
				if (OOIILNOMGIL == -1)
				{
					return false;
				}
				AIJEDOAJAPI = FMOBJPAGLEE.LBJKNANKAIP(HBLKKCJHFFK.material, HBLKKCJHFFK, NDPGMAPHNNA, GJCBEOHAMEH);
				FHJFKDGNODI = HIPDBPNMONO.Sprite;
				return true;
			}
			case 514803617:
			case 730022849:
				CCLHEBEBBGN |= BCIEOOJOMDO.LowerCase;
				MKAJPJFKEPP.JEACJNAKLDJ(BCIEOOJOMDO.LowerCase);
				return true;
			case -1883544150:
			case -1668324918:
				if (MKAJPJFKEPP.CJOHLENDJGO(BCIEOOJOMDO.LowerCase) == 0)
				{
					CCLHEBEBBGN &= (BCIEOOJOMDO)(-9);
				}
				return true;
			case 9133802:
			case 13526026:
			case 566686826:
			case 781906058:
				CCLHEBEBBGN |= BCIEOOJOMDO.UpperCase;
				MKAJPJFKEPP.JEACJNAKLDJ(BCIEOOJOMDO.UpperCase);
				return true;
			case -1831660941:
			case -1616441709:
			case 47840323:
			case 52232547:
				if (MKAJPJFKEPP.CJOHLENDJGO(BCIEOOJOMDO.UpperCase) == 0)
				{
					CCLHEBEBBGN &= (BCIEOOJOMDO)(-17);
				}
				return true;
			case 551025096:
			case 766244328:
				CCLHEBEBBGN |= BCIEOOJOMDO.SmallCaps;
				MKAJPJFKEPP.JEACJNAKLDJ(BCIEOOJOMDO.SmallCaps);
				return true;
			case -1847322671:
			case -1632103439:
				if (MKAJPJFKEPP.CJOHLENDJGO(BCIEOOJOMDO.SmallCaps) == 0)
				{
					CCLHEBEBBGN &= (BCIEOOJOMDO)(-33);
				}
				return true;
			case 1482398:
			case 2109854:
				num3 = BIFBJEJOPMB(LKNOAGBKDDD, POAMHMDFAIN[0].KBCDHNEGNNI, POAMHMDFAIN[0].CDAMPKLJDEH);
				if (num3 == -9999f || num3 == 0f)
				{
					return false;
				}
				DPIAMOJPHPK = num3;
				switch (oLGLEGEMBJD)
				{
				case OLGLEGEMBJD.FontUnits:
					DPIAMOJPHPK *= MEPDJFGMGOK * m_fontAsset.fontInfo.TabWidth / (float)(int)m_fontAsset.tabSize;
					break;
				case OLGLEGEMBJD.Percentage:
					DPIAMOJPHPK = (IOOMPCBBCNK - ((IFAFCDFNNJN == -1f) ? 0f : IFAFCDFNNJN)) * DPIAMOJPHPK / 100f;
					break;
				}
				DPIAMOJPHPK = ((!(DPIAMOJPHPK >= 0f)) ? 0f : DPIAMOJPHPK);
				EPPLBJGIFEM = DPIAMOJPHPK;
				return true;
			case 7011901:
			case 7639357:
				DPIAMOJPHPK = 0f;
				EPPLBJGIFEM = 0f;
				return true;
			case -855002522:
			case 1100728678:
				num3 = BIFBJEJOPMB(LKNOAGBKDDD, POAMHMDFAIN[0].KBCDHNEGNNI, POAMHMDFAIN[0].CDAMPKLJDEH);
				if (num3 == -9999f || num3 == 0f)
				{
					return false;
				}
				DPIAMOJPHPK = num3;
				switch (oLGLEGEMBJD)
				{
				case OLGLEGEMBJD.FontUnits:
					DPIAMOJPHPK *= MEPDJFGMGOK * m_fontAsset.fontInfo.TabWidth / (float)(int)m_fontAsset.tabSize;
					break;
				case OLGLEGEMBJD.Percentage:
					DPIAMOJPHPK = (IOOMPCBBCNK - ((IFAFCDFNNJN == -1f) ? 0f : IFAFCDFNNJN)) * DPIAMOJPHPK / 100f;
					break;
				}
				DPIAMOJPHPK = ((!(DPIAMOJPHPK >= 0f)) ? 0f : DPIAMOJPHPK);
				return true;
			case -1690034531:
			case -884817987:
				num3 = BIFBJEJOPMB(LKNOAGBKDDD, POAMHMDFAIN[0].KBCDHNEGNNI, POAMHMDFAIN[0].CDAMPKLJDEH);
				if (num3 == -9999f || num3 == 0f)
				{
					return false;
				}
				EPPLBJGIFEM = num3;
				switch (oLGLEGEMBJD)
				{
				case OLGLEGEMBJD.FontUnits:
					EPPLBJGIFEM *= MEPDJFGMGOK * m_fontAsset.fontInfo.TabWidth / (float)(int)m_fontAsset.tabSize;
					break;
				case OLGLEGEMBJD.Percentage:
					EPPLBJGIFEM = (IOOMPCBBCNK - ((IFAFCDFNNJN == -1f) ? 0f : IFAFCDFNNJN)) * EPPLBJGIFEM / 100f;
					break;
				}
				EPPLBJGIFEM = ((!(EPPLBJGIFEM >= 0f)) ? 0f : EPPLBJGIFEM);
				return true;
			case -842693512:
			case 1109349752:
				num3 = BIFBJEJOPMB(LKNOAGBKDDD, POAMHMDFAIN[0].KBCDHNEGNNI, POAMHMDFAIN[0].CDAMPKLJDEH);
				if (num3 == -9999f)
				{
					return false;
				}
				KODBBLNBFDO = num3;
				switch (oLGLEGEMBJD)
				{
				case OLGLEGEMBJD.FontUnits:
					KODBBLNBFDO *= m_fontAsset.fontInfo.LineHeight * MEPDJFGMGOK;
					break;
				case OLGLEGEMBJD.Percentage:
					KODBBLNBFDO = m_fontAsset.fontInfo.LineHeight * KODBBLNBFDO / 100f * MEPDJFGMGOK;
					break;
				}
				return true;
			case -445573839:
			case 1897350193:
				KODBBLNBFDO = -32767f;
				return true;
			case 10723418:
			case 15115642:
				FGGFHMLKNJJ = true;
				return true;
			case 1286342:
			case 1913798:
			{
				int gEACCHGKOFJ2 = POAMHMDFAIN[0].GEACCHGKOFJ;
				if (OHKANPJHAFP)
				{
					DJIJDHCEGOA.JEACJNAKLDJ(gEACCHGKOFJ2);
					Debug.Log("Action ID: [" + gEACCHGKOFJ2 + "] First character index: " + HEEDOMEABKA);
				}
				return true;
			}
			case 6815845:
			case 7443301:
				if (OHKANPJHAFP)
				{
					Debug.Log("Action ID: [" + DJIJDHCEGOA.LBFCDKPCDPB() + "] Last character index: " + (HEEDOMEABKA - 1));
				}
				DJIJDHCEGOA.CJOHLENDJGO();
				return true;
			case 1600507:
			case 2227963:
				num3 = BIFBJEJOPMB(LKNOAGBKDDD, POAMHMDFAIN[0].KBCDHNEGNNI, POAMHMDFAIN[0].CDAMPKLJDEH);
				if (num3 == -9999f)
				{
					return false;
				}
				DLBOPBIJDIB = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(0f, 0f, num3), Vector3.one);
				HCBFOLNGCFI = true;
				return true;
			case 7130010:
			case 7757466:
				HCBFOLNGCFI = false;
				return true;
			case 227814:
			case 317446:
			{
				int aBLDGMBADCH = POAMHMDFAIN[1].ABLDGMBADCH;
				if (aBLDGMBADCH == 327550)
				{
					float num5 = BIFBJEJOPMB(LKNOAGBKDDD, POAMHMDFAIN[1].KBCDHNEGNNI, POAMHMDFAIN[1].CDAMPKLJDEH);
					switch (oLGLEGEMBJD)
					{
					case OLGLEGEMBJD.Pixels:
						Debug.Log("Table width = " + num5 + "px.");
						break;
					case OLGLEGEMBJD.FontUnits:
						Debug.Log("Table width = " + num5 + "em.");
						break;
					case OLGLEGEMBJD.Percentage:
						Debug.Log("Table width = " + num5 + "%.");
						break;
					}
				}
				return true;
			}
			case 1017743:
			case 1107375:
				return true;
			case 670:
			case 926:
				return true;
			case 2973:
			case 3229:
				return true;
			case 660:
			case 916:
				return true;
			case 2963:
			case 3219:
				return true;
			case 656:
			case 912:
			{
				for (int j = 1; j < POAMHMDFAIN.Length && POAMHMDFAIN[j].ABLDGMBADCH != 0; j++)
				{
					switch (POAMHMDFAIN[j].ABLDGMBADCH)
					{
					case 327550:
					{
						float num4 = BIFBJEJOPMB(LKNOAGBKDDD, POAMHMDFAIN[j].KBCDHNEGNNI, POAMHMDFAIN[j].CDAMPKLJDEH);
						switch (oLGLEGEMBJD)
						{
						case OLGLEGEMBJD.Pixels:
							Debug.Log("Table width = " + num4 + "px.");
							break;
						case OLGLEGEMBJD.FontUnits:
							Debug.Log("Table width = " + num4 + "em.");
							break;
						case OLGLEGEMBJD.Percentage:
							Debug.Log("Table width = " + num4 + "%.");
							break;
						}
						break;
					}
					case 275917:
						switch (POAMHMDFAIN[j].GEACCHGKOFJ)
						{
						case 3774683:
							Debug.Log("TD align=\"left\".");
							break;
						case 136703040:
							Debug.Log("TD align=\"right\".");
							break;
						case -458210101:
							Debug.Log("TD align=\"center\".");
							break;
						case -523808257:
							Debug.Log("TD align=\"justified\".");
							break;
						}
						break;
					}
				}
				return true;
			}
			case 2959:
			case 3215:
				return true;
			default:
				return false;
			}
		}
	}
}
