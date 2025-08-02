using System;
using System.Collections;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace TMPro
{
	[AddComponentMenu("UI/TextMeshPro - Input Field", 11)]
	public class TMP_InputField : Selectable, IUpdateSelectedHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, IScrollHandler, IEventSystemHandler
	{
		public enum JGKHNLKJGPC
		{
			Standard = 0,
			Autocorrected = 1,
			IntegerNumber = 2,
			DecimalNumber = 3,
			Alphanumeric = 4,
			Name = 5,
			EmailAddress = 6,
			Password = 7,
			Pin = 8,
			Custom = 9
		}

		public enum IDCNHFIGNMA
		{
			Standard = 0,
			AutoCorrect = 1,
			Password = 2
		}

		public enum AIDAPPLANOP
		{
			None = 0,
			Digit = 1,
			Integer = 2,
			Decimal = 3,
			Alphanumeric = 4,
			Name = 5,
			Regex = 6,
			EmailAddress = 7,
			CustomValidator = 8
		}

		public enum FOPOPAMAHNM
		{
			SingleLine = 0,
			MultiLineSubmit = 1,
			MultiLineNewline = 2
		}

		public delegate char HKPIOCACLEF(string FCJBBPHFNPJ, int DDKIGJHCBMH, char MEAEHCFMGCD);

		[Serializable]
		public class SubmitEvent : UnityEvent<string>
		{
		}

		[Serializable]
		public class OnChangeEvent : UnityEvent<string>
		{
		}

		[Serializable]
		public class SelectionEvent : UnityEvent<string>
		{
		}

		[Serializable]
		public class TextSelectionEvent : UnityEvent<string, int, int>
		{
		}

		protected enum JDLMOJHAAJI
		{
			Continue = 0,
			Finish = 1
		}

		protected TouchScreenKeyboard CHDDIHFNGNM;

		private static readonly char[] HODDFIHDOPP = new char[6] { ' ', '.', ',', '\t', '\r', '\n' };

		[SerializeField]
		protected RectTransform m_TextViewport;

		[SerializeField]
		protected TMP_Text m_TextComponent;

		protected RectTransform PCONPLGFJPN;

		[SerializeField]
		protected Graphic m_Placeholder;

		[SerializeField]
		protected Scrollbar m_VerticalScrollbar;

		[SerializeField]
		protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler;

		private float CIEKFNNAEIB;

		[SerializeField]
		protected float m_ScrollSensitivity = 1f;

		[SerializeField]
		private JGKHNLKJGPC m_ContentType;

		[SerializeField]
		private IDCNHFIGNMA m_InputType;

		[SerializeField]
		private char m_AsteriskChar = '*';

		[SerializeField]
		private TouchScreenKeyboardType m_KeyboardType;

		[SerializeField]
		private FOPOPAMAHNM m_LineType;

		[SerializeField]
		private bool m_HideMobileInput;

		[SerializeField]
		private AIDAPPLANOP m_CharacterValidation;

		[SerializeField]
		private string m_RegexValue = string.Empty;

		[SerializeField]
		private float m_GlobalPointSize = 14f;

		[SerializeField]
		private int m_CharacterLimit;

		[SerializeField]
		private SubmitEvent m_OnEndEdit = new SubmitEvent();

		[SerializeField]
		private SubmitEvent m_OnSubmit = new SubmitEvent();

		[SerializeField]
		private SelectionEvent m_OnSelect = new SelectionEvent();

		[SerializeField]
		private SelectionEvent m_OnDeselect = new SelectionEvent();

		[SerializeField]
		private TextSelectionEvent m_OnTextSelection = new TextSelectionEvent();

		[SerializeField]
		private TextSelectionEvent m_OnEndTextSelection = new TextSelectionEvent();

		[SerializeField]
		private OnChangeEvent m_OnValueChanged = new OnChangeEvent();

		[SerializeField]
		private HKPIOCACLEF m_OnValidateInput;

		[SerializeField]
		private Color m_CaretColor = new Color(10f / 51f, 10f / 51f, 10f / 51f, 1f);

		[SerializeField]
		private bool m_CustomCaretColor;

		[SerializeField]
		private Color m_SelectionColor = new Color(56f / 85f, 0.80784315f, 1f, 64f / 85f);

		[SerializeField]
		protected string m_Text = string.Empty;

		[Range(0f, 4f)]
		[SerializeField]
		private float m_CaretBlinkRate = 0.85f;

		[SerializeField]
		[Range(1f, 5f)]
		private int m_CaretWidth = 1;

		[SerializeField]
		private bool m_ReadOnly;

		[SerializeField]
		private bool m_RichText = true;

		protected int GKHDHPLMMIC;

		protected int CMCOLAMGEKA;

		protected int LINDIJIBFNA;

		protected int NPFBLBEEAAN;

		private RectTransform GKGALKFEGDO;

		protected UIVertex[] FENKCOFCPLK;

		private CanvasRenderer JAADDJKDLKJ;

		private Vector2 KHEDAKAKDEI;

		private Vector2 FIGBIOGOCHL;

		[NonSerialized]
		protected Mesh HHEDHHFOLDA;

		private bool JNELODLHIOE;

		private bool CONDEJOKKKP;

		private bool MGNNDJFIMHE;

		private bool NGDBBAOEJLK;

		private const float GICAPLJOJIK = 0.05f;

		private const float JPIKCAIMJJE = 0.1f;

		protected bool MNHLCOGBNML;

		private Coroutine IIKEKPBNLGF;

		private float PEPBJDKAJEK;

		private Coroutine AJLPMLPGEBB;

		private string LDMOJPBIIMJ = string.Empty;

		private bool BCCBLOOBKPL;

		private bool KDJLPKDBCDA;

		private bool HECLPCCLHFB;

		private bool MIHAKKHBHEH;

		private bool BFGPLHJLILB;

		private float ABKEJPLHNOJ;

		private float KIFNFAEFFIJ = 0.5f;

		private const string LEGIIHKGDLE = "!#$%&'*+-/=?^_`{|}~";

		[SerializeField]
		protected TMP_FontAsset m_GlobalFontAsset;

		[SerializeField]
		protected bool m_OnFocusSelectAll = true;

		protected bool ELFFFDFNNNL;

		[SerializeField]
		protected bool m_ResetOnDeActivation = true;

		[SerializeField]
		private bool m_RestoreOriginalTextOnEscape = true;

		[SerializeField]
		protected bool m_isRichTextEditingAllowed = true;

		[SerializeField]
		protected TMP_InputValidator m_InputValidator;

		private bool MKEPAMLKEHF;

		private bool NPOJHDCLMGF;

		private Event JGFKFJBEICJ = new Event();

		protected Mesh IJKCGGPJDIG
		{
			get
			{
				if (HHEDHHFOLDA == null)
				{
					HHEDHHFOLDA = new Mesh();
				}
				return HHEDHHFOLDA;
			}
		}

		public bool BLOPDMFLKBF
		{
			get
			{
				switch (Application.platform)
				{
				case RuntimePlatform.IPhonePlayer:
				case RuntimePlatform.Android:
				case RuntimePlatform.TizenPlayer:
				case RuntimePlatform.tvOS:
					return m_HideMobileInput;
				default:
					return true;
				}
			}
			set
			{
				GEILEFJEADA.KCBJBBNPGCI(ref m_HideMobileInput, value);
			}
		}

		public string FCJBBPHFNPJ
		{
			get
			{
				return m_Text;
			}
			set
			{
				if (!(FCJBBPHFNPJ == value))
				{
					m_Text = value;
					if (CHDDIHFNGNM != null)
					{
						CHDDIHFNGNM.text = m_Text;
					}
					if (GKHDHPLMMIC > m_Text.Length)
					{
						GKHDHPLMMIC = (CMCOLAMGEKA = m_Text.Length);
					}
					DPMKICHFGCO();
				}
			}
		}

		public bool MKAKFOEBMDF
		{
			get
			{
				return JNELODLHIOE;
			}
		}

		public float FEMAJBBCGNG
		{
			get
			{
				return m_CaretBlinkRate;
			}
			set
			{
				if (GEILEFJEADA.KCBJBBNPGCI(ref m_CaretBlinkRate, value) && JNELODLHIOE)
				{
					FHIJGCICEFJ();
				}
			}
		}

		public int JDLEFFLJPDK
		{
			get
			{
				return m_CaretWidth;
			}
			set
			{
				if (GEILEFJEADA.KCBJBBNPGCI(ref m_CaretWidth, value))
				{
					FDLJMIAKKJB();
				}
			}
		}

		public RectTransform KLOMNOALHCH
		{
			get
			{
				return m_TextViewport;
			}
			set
			{
				GEILEFJEADA.MNFFPBCNGEL(ref m_TextViewport, value);
			}
		}

		public TMP_Text MHFABDJOCMG
		{
			get
			{
				return m_TextComponent;
			}
			set
			{
				GEILEFJEADA.MNFFPBCNGEL(ref m_TextComponent, value);
			}
		}

		public Graphic IALPAELMGPL
		{
			get
			{
				return m_Placeholder;
			}
			set
			{
				GEILEFJEADA.MNFFPBCNGEL(ref m_Placeholder, value);
			}
		}

		public Scrollbar NIFIGOGBNLE
		{
			get
			{
				return m_VerticalScrollbar;
			}
			set
			{
				if (m_VerticalScrollbar != null)
				{
					m_VerticalScrollbar.onValueChanged.RemoveListener(OIAILAKGPAO);
				}
				GEILEFJEADA.MNFFPBCNGEL(ref m_VerticalScrollbar, value);
				if ((bool)m_VerticalScrollbar)
				{
					m_VerticalScrollbar.onValueChanged.AddListener(OIAILAKGPAO);
				}
			}
		}

		public float ENFEILAJEEG
		{
			get
			{
				return m_ScrollSensitivity;
			}
			set
			{
				if (GEILEFJEADA.KCBJBBNPGCI(ref m_ScrollSensitivity, value))
				{
					FDLJMIAKKJB();
				}
			}
		}

		public Color FEMMDBBLOPI
		{
			get
			{
				return (!LEJNIEJADFJ) ? MHFABDJOCMG.color : m_CaretColor;
			}
			set
			{
				if (GEILEFJEADA.FHGEHEFAHKO(ref m_CaretColor, value))
				{
					FDLJMIAKKJB();
				}
			}
		}

		public bool LEJNIEJADFJ
		{
			get
			{
				return m_CustomCaretColor;
			}
			set
			{
				if (m_CustomCaretColor != value)
				{
					m_CustomCaretColor = value;
					FDLJMIAKKJB();
				}
			}
		}

		public Color JFGJJMMBMEB
		{
			get
			{
				return m_SelectionColor;
			}
			set
			{
				if (GEILEFJEADA.FHGEHEFAHKO(ref m_SelectionColor, value))
				{
					FDLJMIAKKJB();
				}
			}
		}

		public SubmitEvent PHPADJKLJFF
		{
			get
			{
				return m_OnEndEdit;
			}
			set
			{
				GEILEFJEADA.MNFFPBCNGEL(ref m_OnEndEdit, value);
			}
		}

		public SubmitEvent AFBAPAHBJAA
		{
			get
			{
				return m_OnSubmit;
			}
			set
			{
				GEILEFJEADA.MNFFPBCNGEL(ref m_OnSubmit, value);
			}
		}

		public SelectionEvent EGAKHLKHAKJ
		{
			get
			{
				return m_OnSelect;
			}
			set
			{
				GEILEFJEADA.MNFFPBCNGEL(ref m_OnSelect, value);
			}
		}

		public SelectionEvent LKBPBEHDHAG
		{
			get
			{
				return m_OnDeselect;
			}
			set
			{
				GEILEFJEADA.MNFFPBCNGEL(ref m_OnDeselect, value);
			}
		}

		public TextSelectionEvent OPKHAJEJKOF
		{
			get
			{
				return m_OnTextSelection;
			}
			set
			{
				GEILEFJEADA.MNFFPBCNGEL(ref m_OnTextSelection, value);
			}
		}

		public TextSelectionEvent JDAPPDMOHDN
		{
			get
			{
				return m_OnEndTextSelection;
			}
			set
			{
				GEILEFJEADA.MNFFPBCNGEL(ref m_OnEndTextSelection, value);
			}
		}

		public OnChangeEvent DMIIPGENFFL
		{
			get
			{
				return m_OnValueChanged;
			}
			set
			{
				GEILEFJEADA.MNFFPBCNGEL(ref m_OnValueChanged, value);
			}
		}

		public HKPIOCACLEF BMAJAEDMLHI
		{
			get
			{
				return m_OnValidateInput;
			}
			set
			{
				GEILEFJEADA.MNFFPBCNGEL(ref m_OnValidateInput, value);
			}
		}

		public int NCGHJDIFGBJ
		{
			get
			{
				return m_CharacterLimit;
			}
			set
			{
				if (GEILEFJEADA.KCBJBBNPGCI(ref m_CharacterLimit, Math.Max(0, value)))
				{
					BDFANJGPPHB();
				}
			}
		}

		public float EKNOFGHHCPJ
		{
			get
			{
				return m_GlobalPointSize;
			}
			set
			{
				if (GEILEFJEADA.KCBJBBNPGCI(ref m_GlobalPointSize, Math.Max(0f, value)))
				{
					SetGlobalPointSize(m_GlobalPointSize);
					BDFANJGPPHB();
				}
			}
		}

		public TMP_FontAsset PIJNMJOHBIE
		{
			get
			{
				return m_GlobalFontAsset;
			}
			set
			{
				if (GEILEFJEADA.MNFFPBCNGEL(ref m_GlobalFontAsset, value))
				{
					SetGlobalFontAsset(m_GlobalFontAsset);
					BDFANJGPPHB();
				}
			}
		}

		public bool ECCAHEBAKBG
		{
			get
			{
				return m_OnFocusSelectAll;
			}
			set
			{
				m_OnFocusSelectAll = value;
			}
		}

		public bool DCKICKHBHGC
		{
			get
			{
				return m_ResetOnDeActivation;
			}
			set
			{
				m_ResetOnDeActivation = value;
			}
		}

		public bool EMLLDGEBNGE
		{
			get
			{
				return m_RestoreOriginalTextOnEscape;
			}
			set
			{
				m_RestoreOriginalTextOnEscape = value;
			}
		}

		public bool BHLAMKBCIOG
		{
			get
			{
				return m_isRichTextEditingAllowed;
			}
			set
			{
				m_isRichTextEditingAllowed = value;
			}
		}

		public JGKHNLKJGPC JAFLHIJPFKD
		{
			get
			{
				return m_ContentType;
			}
			set
			{
				if (GEILEFJEADA.KCBJBBNPGCI(ref m_ContentType, value))
				{
					ONFPPGHEGHJ();
				}
			}
		}

		public FOPOPAMAHNM JDOMIOBBEAA
		{
			get
			{
				return m_LineType;
			}
			set
			{
				if (GEILEFJEADA.KCBJBBNPGCI(ref m_LineType, value))
				{
					LGDCKKPEMNO();
				}
				LDFJMHOGILD(JGKHNLKJGPC.Standard, JGKHNLKJGPC.Autocorrected);
			}
		}

		public IDCNHFIGNMA JBLLAJJIPLO
		{
			get
			{
				return m_InputType;
			}
			set
			{
				if (GEILEFJEADA.KCBJBBNPGCI(ref m_InputType, value))
				{
					NNIOCEAJCNJ();
				}
			}
		}

		public TouchScreenKeyboardType CMFKPLMFJAE
		{
			get
			{
				return m_KeyboardType;
			}
			set
			{
				if (GEILEFJEADA.KCBJBBNPGCI(ref m_KeyboardType, value))
				{
					NNIOCEAJCNJ();
				}
			}
		}

		public AIDAPPLANOP ELECECIHMHO
		{
			get
			{
				return m_CharacterValidation;
			}
			set
			{
				if (GEILEFJEADA.KCBJBBNPGCI(ref m_CharacterValidation, value))
				{
					NNIOCEAJCNJ();
				}
			}
		}

		public TMP_InputValidator DBMJMLKLPPN
		{
			get
			{
				return m_InputValidator;
			}
			set
			{
				if (GEILEFJEADA.MNFFPBCNGEL(ref m_InputValidator, value))
				{
					NNIOCEAJCNJ(AIDAPPLANOP.CustomValidator);
				}
			}
		}

		public bool CAENOFCCLAG
		{
			get
			{
				return m_ReadOnly;
			}
			set
			{
				m_ReadOnly = value;
			}
		}

		public bool DGCLMBNNONA
		{
			get
			{
				return m_RichText;
			}
			set
			{
				m_RichText = value;
				APGKMOOEGED();
			}
		}

		public bool DFICAMNBEJL
		{
			get
			{
				return m_LineType == FOPOPAMAHNM.MultiLineNewline || JDOMIOBBEAA == FOPOPAMAHNM.MultiLineSubmit;
			}
		}

		public char LACBCNDLGOK
		{
			get
			{
				return m_AsteriskChar;
			}
			set
			{
				if (GEILEFJEADA.KCBJBBNPGCI(ref m_AsteriskChar, value))
				{
					BDFANJGPPHB();
				}
			}
		}

		public bool ONMCHHBGNFP
		{
			get
			{
				return BCCBLOOBKPL;
			}
		}

		protected int DBKLFBEGCHH
		{
			get
			{
				return LINDIJIBFNA + Input.compositionString.Length;
			}
			set
			{
				LINDIJIBFNA = value;
				EPKOLADCKOO(ref LINDIJIBFNA);
			}
		}

		protected int CIEKBEHJNBP
		{
			get
			{
				return GKHDHPLMMIC + Input.compositionString.Length;
			}
			set
			{
				GKHDHPLMMIC = value;
				DBHAOFKDHLC(ref GKHDHPLMMIC);
			}
		}

		protected int KNLONNOEOJG
		{
			get
			{
				return NPFBLBEEAAN + Input.compositionString.Length;
			}
			set
			{
				NPFBLBEEAAN = value;
				EPKOLADCKOO(ref NPFBLBEEAAN);
			}
		}

		protected int OGEJLKAFLCJ
		{
			get
			{
				return CMCOLAMGEKA + Input.compositionString.Length;
			}
			set
			{
				CMCOLAMGEKA = value;
				DBHAOFKDHLC(ref CMCOLAMGEKA);
			}
		}

		private bool JDOJHNLJGAA
		{
			get
			{
				return CIEKBEHJNBP != OGEJLKAFLCJ;
			}
		}

		public int CNBIEMAAIKB
		{
			get
			{
				return KNLONNOEOJG;
			}
			set
			{
				IPDNGDJACMK = value;
				IFJNPBHEDPF = value;
				NPOJHDCLMGF = true;
			}
		}

		public int IPDNGDJACMK
		{
			get
			{
				return DBKLFBEGCHH;
			}
			set
			{
				if (Input.compositionString.Length == 0)
				{
					DBKLFBEGCHH = value;
					NPOJHDCLMGF = true;
				}
			}
		}

		public int IFJNPBHEDPF
		{
			get
			{
				return KNLONNOEOJG;
			}
			set
			{
				if (Input.compositionString.Length == 0)
				{
					KNLONNOEOJG = value;
					NPOJHDCLMGF = true;
				}
			}
		}

		public int KCKKHCMCPDJ
		{
			get
			{
				return OGEJLKAFLCJ;
			}
			set
			{
				DABEOMJBACB = value;
				JKBACECNGCF = value;
			}
		}

		public int DABEOMJBACB
		{
			get
			{
				return CIEKBEHJNBP;
			}
			set
			{
				if (Input.compositionString.Length == 0)
				{
					CIEKBEHJNBP = value;
				}
			}
		}

		public int JKBACECNGCF
		{
			get
			{
				return OGEJLKAFLCJ;
			}
			set
			{
				if (Input.compositionString.Length == 0)
				{
					OGEJLKAFLCJ = value;
				}
			}
		}

		private static string LJNGKGMJKML
		{
			get
			{
				return GUIUtility.systemCopyBuffer;
			}
			set
			{
				GUIUtility.systemCopyBuffer = value;
			}
		}

		protected TMP_InputField()
		{
		}

		protected void DBHAOFKDHLC(ref int FADJPCHMMBH)
		{
			if (FADJPCHMMBH < 0)
			{
				FADJPCHMMBH = 0;
			}
			else if (FADJPCHMMBH > FCJBBPHFNPJ.Length)
			{
				FADJPCHMMBH = FCJBBPHFNPJ.Length;
			}
		}

		protected void EPKOLADCKOO(ref int FADJPCHMMBH)
		{
			if (FADJPCHMMBH < 0)
			{
				FADJPCHMMBH = 0;
			}
			else if (FADJPCHMMBH > m_TextComponent.BIAHJAKEMLM.characterCount - 1)
			{
				FADJPCHMMBH = m_TextComponent.BIAHJAKEMLM.characterCount - 1;
			}
		}

		protected override void OnEnable()
		{
			base.OnEnable();
			if (m_Text == null)
			{
				m_Text = string.Empty;
			}
			if (Application.isPlaying && JAADDJKDLKJ == null && m_TextComponent != null)
			{
				GameObject gameObject = new GameObject(base.transform.name + " Input Caret", typeof(RectTransform));
				TMP_SelectionCaret tMP_SelectionCaret = gameObject.AddComponent<TMP_SelectionCaret>();
				tMP_SelectionCaret.color = Color.clear;
				gameObject.hideFlags = HideFlags.DontSave;
				gameObject.transform.SetParent(m_TextComponent.ANLKLKAINEO.parent);
				gameObject.transform.SetAsFirstSibling();
				gameObject.layer = base.gameObject.layer;
				GKGALKFEGDO = gameObject.GetComponent<RectTransform>();
				JAADDJKDLKJ = gameObject.GetComponent<CanvasRenderer>();
				JAADDJKDLKJ.SetMaterial(Graphic.defaultGraphicMaterial, Texture2D.whiteTexture);
				gameObject.AddComponent<LayoutElement>().ignoreLayout = true;
				OOCDPDNEPFP();
			}
			if (JAADDJKDLKJ != null)
			{
				JAADDJKDLKJ.SetMaterial(Graphic.defaultGraphicMaterial, Texture2D.whiteTexture);
			}
			if (m_TextComponent != null)
			{
				m_TextComponent.RegisterDirtyVerticesCallback(FDLJMIAKKJB);
				m_TextComponent.RegisterDirtyVerticesCallback(BDFANJGPPHB);
				m_TextComponent.CIDGHENKBFI = true;
				KHEDAKAKDEI = m_TextComponent.GPPKOGCLKPL.localPosition;
				if (m_VerticalScrollbar != null)
				{
					m_VerticalScrollbar.onValueChanged.AddListener(OIAILAKGPAO);
				}
				BDFANJGPPHB();
			}
			FFCFAICENOB.GGJFLCNKOLB.JEACJNAKLDJ(EDOBMOAFCFA);
		}

		protected override void OnDisable()
		{
			IIKEKPBNLGF = null;
			DeactivateInputField();
			if (m_TextComponent != null)
			{
				m_TextComponent.UnregisterDirtyVerticesCallback(FDLJMIAKKJB);
				m_TextComponent.UnregisterDirtyVerticesCallback(BDFANJGPPHB);
				if (m_VerticalScrollbar != null)
				{
					m_VerticalScrollbar.onValueChanged.RemoveListener(OIAILAKGPAO);
				}
			}
			CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild(this);
			if (JAADDJKDLKJ != null)
			{
				JAADDJKDLKJ.Clear();
			}
			if (HHEDHHFOLDA != null)
			{
				UnityEngine.Object.DestroyImmediate(HHEDHHFOLDA);
			}
			HHEDHHFOLDA = null;
			FFCFAICENOB.GGJFLCNKOLB.CJOHLENDJGO(EDOBMOAFCFA);
			base.OnDisable();
		}

		private void EDOBMOAFCFA(UnityEngine.Object NEMEKIOEOLC)
		{
			if (NEMEKIOEOLC == m_TextComponent && Application.isPlaying)
			{
				DBKLFBEGCHH = FPHHDGLJDFE(CIEKBEHJNBP);
				KNLONNOEOJG = FPHHDGLJDFE(OGEJLKAFLCJ);
			}
		}

		private IEnumerator ECMFHAKNHMD()
		{
			MNHLCOGBNML = true;
			yield return null;
			while (m_CaretBlinkRate > 0f)
			{
				float num = 1f / m_CaretBlinkRate;
				bool flag = (Time.unscaledTime - PEPBJDKAJEK) % num < num / 2f;
				if (MNHLCOGBNML != flag)
				{
					MNHLCOGBNML = flag;
					if (!JDOJHNLJGAA)
					{
						FDLJMIAKKJB();
					}
				}
				yield return null;
			}
			IIKEKPBNLGF = null;
		}

		private void JJPFLKPKNML()
		{
			if (JNELODLHIOE)
			{
				MNHLCOGBNML = true;
				PEPBJDKAJEK = Time.unscaledTime;
				FHIJGCICEFJ();
			}
		}

		private void FHIJGCICEFJ()
		{
			if (!JNELODLHIOE)
			{
				return;
			}
			if (m_CaretBlinkRate > 0f)
			{
				if (IIKEKPBNLGF == null)
				{
					IIKEKPBNLGF = StartCoroutine(ECMFHAKNHMD());
				}
			}
			else
			{
				MNHLCOGBNML = true;
			}
		}

		protected void FKFFJCHNGOA()
		{
			if (m_OnFocusSelectAll)
			{
				FLCOJDGAFIK();
			}
		}

		protected void FLCOJDGAFIK()
		{
			ELFFFDFNNNL = true;
			CIEKBEHJNBP = FCJBBPHFNPJ.Length;
			OGEJLKAFLCJ = 0;
		}

		public void MoveTextEnd(bool IMLCPJDGOEO)
		{
			if (m_isRichTextEditingAllowed)
			{
				int length = FCJBBPHFNPJ.Length;
				if (IMLCPJDGOEO)
				{
					OGEJLKAFLCJ = length;
				}
				else
				{
					CIEKBEHJNBP = length;
					OGEJLKAFLCJ = CIEKBEHJNBP;
				}
			}
			else
			{
				int num = m_TextComponent.BIAHJAKEMLM.characterCount - 1;
				if (IMLCPJDGOEO)
				{
					KNLONNOEOJG = num;
					OGEJLKAFLCJ = AFGLLEPCLAO(num);
				}
				else
				{
					int eDDNOJDPMCF = (KNLONNOEOJG = num);
					DBKLFBEGCHH = eDDNOJDPMCF;
					eDDNOJDPMCF = (CIEKBEHJNBP = AFGLLEPCLAO(num));
					OGEJLKAFLCJ = eDDNOJDPMCF;
				}
			}
			BDFANJGPPHB();
		}

		public void MoveTextStart(bool IMLCPJDGOEO)
		{
			if (m_isRichTextEditingAllowed)
			{
				int eDDNOJDPMCF = 0;
				if (IMLCPJDGOEO)
				{
					OGEJLKAFLCJ = eDDNOJDPMCF;
				}
				else
				{
					CIEKBEHJNBP = eDDNOJDPMCF;
					OGEJLKAFLCJ = CIEKBEHJNBP;
				}
			}
			else
			{
				int num = 0;
				if (IMLCPJDGOEO)
				{
					KNLONNOEOJG = num;
					OGEJLKAFLCJ = AFGLLEPCLAO(num);
				}
				else
				{
					int eDDNOJDPMCF2 = (KNLONNOEOJG = num);
					DBKLFBEGCHH = eDDNOJDPMCF2;
					eDDNOJDPMCF2 = (CIEKBEHJNBP = AFGLLEPCLAO(num));
					OGEJLKAFLCJ = eDDNOJDPMCF2;
				}
			}
			BDFANJGPPHB();
		}

		public void MoveToEndOfLine(bool IMLCPJDGOEO, bool OBFECIHEJHM)
		{
			int hGCMIDFMKHD = m_TextComponent.BIAHJAKEMLM.characterInfo[DBKLFBEGCHH].HGCMIDFMKHD;
			int cNBIEMAAIKB = ((!OBFECIHEJHM) ? m_TextComponent.BIAHJAKEMLM.lineInfo[hGCMIDFMKHD].FNOFPOMADEM : (m_TextComponent.BIAHJAKEMLM.characterCount - 1));
			cNBIEMAAIKB = AFGLLEPCLAO(cNBIEMAAIKB);
			if (IMLCPJDGOEO)
			{
				OGEJLKAFLCJ = cNBIEMAAIKB;
			}
			else
			{
				CIEKBEHJNBP = cNBIEMAAIKB;
				OGEJLKAFLCJ = CIEKBEHJNBP;
			}
			BDFANJGPPHB();
		}

		public void MoveToStartOfLine(bool IMLCPJDGOEO, bool OBFECIHEJHM)
		{
			int hGCMIDFMKHD = m_TextComponent.BIAHJAKEMLM.characterInfo[DBKLFBEGCHH].HGCMIDFMKHD;
			int cNBIEMAAIKB = ((!OBFECIHEJHM) ? m_TextComponent.BIAHJAKEMLM.lineInfo[hGCMIDFMKHD].IAJJNNOAMLG : 0);
			cNBIEMAAIKB = AFGLLEPCLAO(cNBIEMAAIKB);
			if (IMLCPJDGOEO)
			{
				OGEJLKAFLCJ = cNBIEMAAIKB;
			}
			else
			{
				CIEKBEHJNBP = cNBIEMAAIKB;
				OGEJLKAFLCJ = CIEKBEHJNBP;
			}
			BDFANJGPPHB();
		}

		private bool BPPKCLAAOJE()
		{
			return !TouchScreenKeyboard.isSupported;
		}

		protected virtual void LateUpdate()
		{
			if (CONDEJOKKKP)
			{
				if (!MKAKFOEBMDF)
				{
					DNGDALEICCI();
					CONDEJOKKKP = false;
					return;
				}
				CONDEJOKKKP = false;
			}
			if (HECLPCCLHFB)
			{
				DAHDPMCLIEB();
				HECLPCCLHFB = false;
			}
			if (BPPKCLAAOJE() || !MKAKFOEBMDF)
			{
				return;
			}
			OOCDPDNEPFP();
			if (CHDDIHFNGNM == null || !CHDDIHFNGNM.active)
			{
				if (CHDDIHFNGNM != null)
				{
					if (!m_ReadOnly)
					{
						FCJBBPHFNPJ = CHDDIHFNGNM.text;
					}
					if (CHDDIHFNGNM.wasCanceled)
					{
						BCCBLOOBKPL = true;
					}
					if (CHDDIHFNGNM.done)
					{
						OnSubmit(null);
					}
				}
				OnDeselect(null);
				return;
			}
			string text = CHDDIHFNGNM.text;
			if (m_Text != text)
			{
				if (m_ReadOnly)
				{
					CHDDIHFNGNM.text = m_Text;
				}
				else
				{
					m_Text = string.Empty;
					for (int i = 0; i < text.Length; i++)
					{
						char c = text[i];
						if (c == '\r' || c == '\u0003')
						{
							c = '\n';
						}
						if (BMAJAEDMLHI != null)
						{
							c = BMAJAEDMLHI(m_Text, m_Text.Length, c);
						}
						else if (ELECECIHMHO != 0)
						{
							c = PIBLOPJEGEL(m_Text, m_Text.Length, c);
						}
						if (JDOMIOBBEAA == FOPOPAMAHNM.MultiLineSubmit && c == '\n')
						{
							CHDDIHFNGNM.text = m_Text;
							OnSubmit(null);
							OnDeselect(null);
							return;
						}
						if (c != 0)
						{
							m_Text += c;
						}
					}
					if (NCGHJDIFGBJ > 0 && m_Text.Length > NCGHJDIFGBJ)
					{
						m_Text = m_Text.Substring(0, NCGHJDIFGBJ);
					}
					int eDDNOJDPMCF = (OGEJLKAFLCJ = m_Text.Length);
					CIEKBEHJNBP = eDDNOJDPMCF;
					if (m_Text != text)
					{
						CHDDIHFNGNM.text = m_Text;
					}
					DPMKICHFGCO();
				}
			}
			if (CHDDIHFNGNM.done)
			{
				if (CHDDIHFNGNM.wasCanceled)
				{
					BCCBLOOBKPL = true;
				}
				OnDeselect(null);
			}
		}

		private bool ONECJNGMCJB(PointerEventData HMIFPEJKHHH)
		{
			return IsActive() && IsInteractable() && HMIFPEJKHHH.button == PointerEventData.InputButton.Left && m_TextComponent != null && CHDDIHFNGNM == null;
		}

		public virtual void OnBeginDrag(PointerEventData HMIFPEJKHHH)
		{
			if (ONECJNGMCJB(HMIFPEJKHHH))
			{
				MGNNDJFIMHE = true;
			}
		}

		public virtual void OnDrag(PointerEventData HMIFPEJKHHH)
		{
			if (ONECJNGMCJB(HMIFPEJKHHH))
			{
				FKJCPPFCKFE AELKOEGPIKN;
				int cNBIEMAAIKB = LBOEJMDHOEP.IJCGMADBIPC(m_TextComponent, HMIFPEJKHHH.position, HMIFPEJKHHH.pressEventCamera, out AELKOEGPIKN);
				switch (AELKOEGPIKN)
				{
				case FKJCPPFCKFE.Left:
					OGEJLKAFLCJ = AFGLLEPCLAO(cNBIEMAAIKB);
					break;
				case FKJCPPFCKFE.Right:
					OGEJLKAFLCJ = AFGLLEPCLAO(cNBIEMAAIKB) + 1;
					break;
				}
				KNLONNOEOJG = FPHHDGLJDFE(OGEJLKAFLCJ);
				FDLJMIAKKJB();
				NGDBBAOEJLK = !RectTransformUtility.RectangleContainsScreenPoint(KLOMNOALHCH, HMIFPEJKHHH.position, HMIFPEJKHHH.pressEventCamera);
				if (NGDBBAOEJLK && AJLPMLPGEBB == null)
				{
					AJLPMLPGEBB = StartCoroutine(FPNCDLLHCLN(HMIFPEJKHHH));
				}
				HMIFPEJKHHH.Use();
			}
		}

		private IEnumerator FPNCDLLHCLN(PointerEventData HMIFPEJKHHH)
		{
			while (MGNNDJFIMHE && NGDBBAOEJLK)
			{
				Vector2 localPoint;
				RectTransformUtility.ScreenPointToLocalPointInRectangle(KLOMNOALHCH, HMIFPEJKHHH.position, HMIFPEJKHHH.pressEventCamera, out localPoint);
				Rect rect = KLOMNOALHCH.rect;
				if (DFICAMNBEJL)
				{
					if (localPoint.y > rect.yMax)
					{
						LIPFHILMNHH(true, true);
					}
					else if (localPoint.y < rect.yMin)
					{
						AODGFDBIHOB(true, true);
					}
				}
				else if (localPoint.x < rect.xMin)
				{
					NJCJAGPIHJG(true, false);
				}
				else if (localPoint.x > rect.xMax)
				{
					HLFBCPMMIKF(true, false);
				}
				BDFANJGPPHB();
				float seconds = ((!DFICAMNBEJL) ? 0.05f : 0.1f);
				yield return new WaitForSeconds(seconds);
			}
			AJLPMLPGEBB = null;
		}

		public virtual void OnEndDrag(PointerEventData HMIFPEJKHHH)
		{
			if (ONECJNGMCJB(HMIFPEJKHHH))
			{
				MGNNDJFIMHE = false;
			}
		}

		public override void OnPointerDown(PointerEventData HMIFPEJKHHH)
		{
			if (!ONECJNGMCJB(HMIFPEJKHHH))
			{
				return;
			}
			EventSystem.current.SetSelectedGameObject(base.gameObject, HMIFPEJKHHH);
			bool jNELODLHIOE = JNELODLHIOE;
			base.OnPointerDown(HMIFPEJKHHH);
			if (!BPPKCLAAOJE() && (CHDDIHFNGNM == null || !CHDDIHFNGNM.active))
			{
				OnSelect(HMIFPEJKHHH);
				return;
			}
			bool flag = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
			bool flag2 = false;
			float unscaledTime = Time.unscaledTime;
			if (ABKEJPLHNOJ + KIFNFAEFFIJ > unscaledTime)
			{
				flag2 = true;
			}
			ABKEJPLHNOJ = unscaledTime;
			if (jNELODLHIOE || !m_OnFocusSelectAll)
			{
				FKJCPPFCKFE AELKOEGPIKN;
				int cNBIEMAAIKB = LBOEJMDHOEP.IJCGMADBIPC(m_TextComponent, HMIFPEJKHHH.position, HMIFPEJKHHH.pressEventCamera, out AELKOEGPIKN);
				if (flag)
				{
					switch (AELKOEGPIKN)
					{
					case FKJCPPFCKFE.Left:
						OGEJLKAFLCJ = AFGLLEPCLAO(cNBIEMAAIKB);
						break;
					case FKJCPPFCKFE.Right:
						OGEJLKAFLCJ = AFGLLEPCLAO(cNBIEMAAIKB) + 1;
						break;
					}
				}
				else
				{
					switch (AELKOEGPIKN)
					{
					case FKJCPPFCKFE.Left:
					{
						int eDDNOJDPMCF = (OGEJLKAFLCJ = AFGLLEPCLAO(cNBIEMAAIKB));
						CIEKBEHJNBP = eDDNOJDPMCF;
						break;
					}
					case FKJCPPFCKFE.Right:
					{
						int eDDNOJDPMCF = (OGEJLKAFLCJ = AFGLLEPCLAO(cNBIEMAAIKB) + 1);
						CIEKBEHJNBP = eDDNOJDPMCF;
						break;
					}
					}
				}
				if (flag2)
				{
					int num3 = LBOEJMDHOEP.PLBPMPBDMPH(m_TextComponent, HMIFPEJKHHH.position, HMIFPEJKHHH.pressEventCamera);
					if (num3 != -1)
					{
						DBKLFBEGCHH = m_TextComponent.BIAHJAKEMLM.wordInfo[num3].IAJJNNOAMLG;
						KNLONNOEOJG = m_TextComponent.BIAHJAKEMLM.wordInfo[num3].FNOFPOMADEM + 1;
						CIEKBEHJNBP = AFGLLEPCLAO(DBKLFBEGCHH);
						OGEJLKAFLCJ = AFGLLEPCLAO(KNLONNOEOJG);
					}
					else
					{
						DBKLFBEGCHH = FPHHDGLJDFE(CIEKBEHJNBP);
						OGEJLKAFLCJ++;
						KNLONNOEOJG = DBKLFBEGCHH + 1;
						KNLONNOEOJG = FPHHDGLJDFE(OGEJLKAFLCJ);
					}
				}
				else
				{
					int eDDNOJDPMCF = (KNLONNOEOJG = FPHHDGLJDFE(CIEKBEHJNBP));
					DBKLFBEGCHH = eDDNOJDPMCF;
				}
			}
			BDFANJGPPHB();
			HMIFPEJKHHH.Use();
		}

		protected JDLMOJHAAJI MBGNAOKKCAK(Event JIBDPGIEKMJ)
		{
			EventModifiers modifiers = JIBDPGIEKMJ.modifiers;
			RuntimePlatform platform = Application.platform;
			bool flag = ((platform != 0 && platform != RuntimePlatform.OSXPlayer) ? ((modifiers & EventModifiers.Control) != 0) : ((modifiers & EventModifiers.Command) != 0));
			bool flag2 = (modifiers & EventModifiers.Shift) != 0;
			bool flag3 = (modifiers & EventModifiers.Alt) != 0;
			bool flag4 = flag && !flag3 && !flag2;
			switch (JIBDPGIEKMJ.keyCode)
			{
			case KeyCode.Backspace:
				LCJDGMMNGNM();
				return JDLMOJHAAJI.Continue;
			case KeyCode.Delete:
				MJDDNENMJED();
				return JDLMOJHAAJI.Continue;
			case KeyCode.Home:
				MoveToStartOfLine(flag2, flag);
				return JDLMOJHAAJI.Continue;
			case KeyCode.End:
				MoveToEndOfLine(flag2, flag);
				return JDLMOJHAAJI.Continue;
			case KeyCode.A:
				if (flag4)
				{
					FLCOJDGAFIK();
					return JDLMOJHAAJI.Continue;
				}
				break;
			case KeyCode.C:
				if (flag4)
				{
					if (JBLLAJJIPLO != IDCNHFIGNMA.Password)
					{
						LJNGKGMJKML = DFLOGBNDPON();
					}
					else
					{
						LJNGKGMJKML = string.Empty;
					}
					return JDLMOJHAAJI.Continue;
				}
				break;
			case KeyCode.V:
				if (flag4)
				{
					GBKNDKCPBEH(LJNGKGMJKML);
					return JDLMOJHAAJI.Continue;
				}
				break;
			case KeyCode.X:
				if (flag4)
				{
					if (JBLLAJJIPLO != IDCNHFIGNMA.Password)
					{
						LJNGKGMJKML = DFLOGBNDPON();
					}
					else
					{
						LJNGKGMJKML = string.Empty;
					}
					GIOCEEGBFKL();
					DPMKICHFGCO();
					return JDLMOJHAAJI.Continue;
				}
				break;
			case KeyCode.LeftArrow:
				NJCJAGPIHJG(flag2, flag);
				return JDLMOJHAAJI.Continue;
			case KeyCode.RightArrow:
				HLFBCPMMIKF(flag2, flag);
				return JDLMOJHAAJI.Continue;
			case KeyCode.UpArrow:
				LIPFHILMNHH(flag2);
				return JDLMOJHAAJI.Continue;
			case KeyCode.DownArrow:
				AODGFDBIHOB(flag2);
				return JDLMOJHAAJI.Continue;
			case KeyCode.PageUp:
				MCHCAFAPPEA(flag2);
				return JDLMOJHAAJI.Continue;
			case KeyCode.PageDown:
				CFBOBCLFOED(flag2);
				return JDLMOJHAAJI.Continue;
			case KeyCode.Return:
			case KeyCode.KeypadEnter:
				if (JDOMIOBBEAA != FOPOPAMAHNM.MultiLineNewline)
				{
					return JDLMOJHAAJI.Finish;
				}
				break;
			case KeyCode.Escape:
				BCCBLOOBKPL = true;
				return JDLMOJHAAJI.Finish;
			}
			char c = JIBDPGIEKMJ.character;
			if (!DFICAMNBEJL && (c == '\t' || c == '\r' || c == '\n'))
			{
				return JDLMOJHAAJI.Continue;
			}
			if (c == '\r' || c == '\u0003')
			{
				c = '\n';
			}
			if (PPNGKHALLPE(c))
			{
				GBKNDKCPBEH(c);
			}
			if (c == '\0' && Input.compositionString.Length > 0)
			{
				BDFANJGPPHB();
			}
			return JDLMOJHAAJI.Continue;
		}

		private bool PPNGKHALLPE(char FMFABAKPMLB)
		{
			switch (FMFABAKPMLB)
			{
			case '\u007f':
				return false;
			case '\t':
			case '\n':
				return true;
			default:
				return m_TextComponent.ELKNHALJKNI.OBJKDIFMJEO(FMFABAKPMLB, true);
			}
		}

		public void ProcessEvent(Event EKFOKNPODBK)
		{
			MBGNAOKKCAK(EKFOKNPODBK);
		}

		public virtual void OnUpdateSelected(BaseEventData HMIFPEJKHHH)
		{
			if (!MKAKFOEBMDF)
			{
				return;
			}
			bool flag = false;
			while (Event.PopEvent(JGFKFJBEICJ))
			{
				if (JGFKFJBEICJ.rawType == EventType.KeyDown)
				{
					flag = true;
					JDLMOJHAAJI jDLMOJHAAJI = MBGNAOKKCAK(JGFKFJBEICJ);
					if (jDLMOJHAAJI == JDLMOJHAAJI.Finish)
					{
						BAFOKDNCILJ();
						DeactivateInputField();
						break;
					}
				}
				EventType type = JGFKFJBEICJ.type;
				if (type == EventType.ValidateCommand || type == EventType.ExecuteCommand)
				{
					string commandName = JGFKFJBEICJ.commandName;
					if (commandName != null && commandName == "SelectAll")
					{
						FLCOJDGAFIK();
						flag = true;
					}
				}
			}
			if (flag)
			{
				BDFANJGPPHB();
			}
			HMIFPEJKHHH.Use();
		}

		public virtual void OnScroll(PointerEventData HMIFPEJKHHH)
		{
			if (!(m_TextComponent.ICJOPDNAIJF < m_TextViewport.rect.height))
			{
				float num = 0f - HMIFPEJKHHH.scrollDelta.y;
				CIEKFNNAEIB += 1f / (float)m_TextComponent.BIAHJAKEMLM.lineCount * num * m_ScrollSensitivity;
				CIEKFNNAEIB = Mathf.Clamp01(CIEKFNNAEIB);
				DCGKMDPNIIJ(CIEKFNNAEIB);
				JNELODLHIOE = false;
				if ((bool)m_VerticalScrollbar)
				{
					MIHAKKHBHEH = true;
					m_VerticalScrollbar.value = CIEKFNNAEIB;
				}
			}
		}

		private string DFLOGBNDPON()
		{
			if (!JDOJHNLJGAA)
			{
				return string.Empty;
			}
			int num = CIEKBEHJNBP;
			int num2 = OGEJLKAFLCJ;
			if (num > num2)
			{
				int num3 = num;
				num = num2;
				num2 = num3;
			}
			return FCJBBPHFNPJ.Substring(num, num2 - num);
		}

		private int NEGCGMKADKD()
		{
			if (OGEJLKAFLCJ + 1 >= FCJBBPHFNPJ.Length)
			{
				return FCJBBPHFNPJ.Length;
			}
			int num = FCJBBPHFNPJ.IndexOfAny(HODDFIHDOPP, OGEJLKAFLCJ + 1);
			if (num == -1)
			{
				return FCJBBPHFNPJ.Length;
			}
			return num + 1;
		}

		private void HLFBCPMMIKF(bool IMLCPJDGOEO, bool OBFECIHEJHM)
		{
			int eDDNOJDPMCF;
			if (JDOJHNLJGAA && !IMLCPJDGOEO)
			{
				eDDNOJDPMCF = (OGEJLKAFLCJ = Mathf.Max(CIEKBEHJNBP, OGEJLKAFLCJ));
				CIEKBEHJNBP = eDDNOJDPMCF;
				eDDNOJDPMCF = (KNLONNOEOJG = FPHHDGLJDFE(OGEJLKAFLCJ));
				DBKLFBEGCHH = eDDNOJDPMCF;
				return;
			}
			int num3 = (OBFECIHEJHM ? NEGCGMKADKD() : ((!m_isRichTextEditingAllowed) ? AFGLLEPCLAO(KNLONNOEOJG + 1) : (OGEJLKAFLCJ + 1)));
			if (IMLCPJDGOEO)
			{
				OGEJLKAFLCJ = num3;
				KNLONNOEOJG = FPHHDGLJDFE(OGEJLKAFLCJ);
				return;
			}
			eDDNOJDPMCF = (CIEKBEHJNBP = num3);
			OGEJLKAFLCJ = eDDNOJDPMCF;
			eDDNOJDPMCF = (DBKLFBEGCHH = FPHHDGLJDFE(OGEJLKAFLCJ));
			KNLONNOEOJG = eDDNOJDPMCF;
		}

		private int LPMBHILOGDH()
		{
			if (OGEJLKAFLCJ - 2 < 0)
			{
				return 0;
			}
			int num = FCJBBPHFNPJ.LastIndexOfAny(HODDFIHDOPP, OGEJLKAFLCJ - 2);
			if (num == -1)
			{
				return 0;
			}
			return num + 1;
		}

		private void NJCJAGPIHJG(bool IMLCPJDGOEO, bool OBFECIHEJHM)
		{
			int eDDNOJDPMCF;
			if (JDOJHNLJGAA && !IMLCPJDGOEO)
			{
				eDDNOJDPMCF = (OGEJLKAFLCJ = Mathf.Min(CIEKBEHJNBP, OGEJLKAFLCJ));
				CIEKBEHJNBP = eDDNOJDPMCF;
				eDDNOJDPMCF = (KNLONNOEOJG = FPHHDGLJDFE(OGEJLKAFLCJ));
				DBKLFBEGCHH = eDDNOJDPMCF;
				return;
			}
			int num3 = (OBFECIHEJHM ? LPMBHILOGDH() : ((!m_isRichTextEditingAllowed) ? AFGLLEPCLAO(KNLONNOEOJG - 1) : (OGEJLKAFLCJ - 1)));
			if (IMLCPJDGOEO)
			{
				OGEJLKAFLCJ = num3;
				KNLONNOEOJG = FPHHDGLJDFE(OGEJLKAFLCJ);
				return;
			}
			eDDNOJDPMCF = (CIEKBEHJNBP = num3);
			OGEJLKAFLCJ = eDDNOJDPMCF;
			eDDNOJDPMCF = (DBKLFBEGCHH = FPHHDGLJDFE(OGEJLKAFLCJ));
			KNLONNOEOJG = eDDNOJDPMCF;
		}

		private int KLFEAFKMKCO(int LOPAFEGFAGG, bool ACOJHNCFILB)
		{
			if (LOPAFEGFAGG >= m_TextComponent.BIAHJAKEMLM.characterCount)
			{
				LOPAFEGFAGG--;
			}
			MGLLLPMKGDA mGLLLPMKGDA = m_TextComponent.BIAHJAKEMLM.characterInfo[LOPAFEGFAGG];
			int hGCMIDFMKHD = mGLLLPMKGDA.HGCMIDFMKHD;
			if (hGCMIDFMKHD - 1 < 0)
			{
				return (!ACOJHNCFILB) ? LOPAFEGFAGG : 0;
			}
			int num = m_TextComponent.BIAHJAKEMLM.lineInfo[hGCMIDFMKHD].IAJJNNOAMLG - 1;
			int num2 = -1;
			float num3 = 32767f;
			float num4 = 0f;
			for (int i = m_TextComponent.BIAHJAKEMLM.lineInfo[hGCMIDFMKHD - 1].IAJJNNOAMLG; i < num; i++)
			{
				MGLLLPMKGDA mGLLLPMKGDA2 = m_TextComponent.BIAHJAKEMLM.characterInfo[i];
				float num5 = mGLLLPMKGDA.EBDCOMKHPBG - mGLLLPMKGDA2.EBDCOMKHPBG;
				float num6 = num5 / (mGLLLPMKGDA2.MDKGJAGDLHC - mGLLLPMKGDA2.EBDCOMKHPBG);
				if (num6 >= 0f && num6 <= 1f)
				{
					if (num6 < 0.5f)
					{
						return i;
					}
					return i + 1;
				}
				num5 = Mathf.Abs(num5);
				if (num5 < num3)
				{
					num2 = i;
					num3 = num5;
					num4 = num6;
				}
			}
			if (num2 == -1)
			{
				return num;
			}
			if (num4 < 0.5f)
			{
				return num2;
			}
			return num2 + 1;
		}

		private int GLLCHGDIPOB(int LOPAFEGFAGG, bool HCMKOGPFHCJ)
		{
			if (LOPAFEGFAGG >= m_TextComponent.BIAHJAKEMLM.characterCount)
			{
				return m_TextComponent.BIAHJAKEMLM.characterCount - 1;
			}
			MGLLLPMKGDA mGLLLPMKGDA = m_TextComponent.BIAHJAKEMLM.characterInfo[LOPAFEGFAGG];
			int hGCMIDFMKHD = mGLLLPMKGDA.HGCMIDFMKHD;
			if (hGCMIDFMKHD + 1 >= m_TextComponent.BIAHJAKEMLM.lineCount)
			{
				return (!HCMKOGPFHCJ) ? LOPAFEGFAGG : (m_TextComponent.BIAHJAKEMLM.characterCount - 1);
			}
			int fNOFPOMADEM = m_TextComponent.BIAHJAKEMLM.lineInfo[hGCMIDFMKHD + 1].FNOFPOMADEM;
			int num = -1;
			float num2 = 32767f;
			float num3 = 0f;
			for (int i = m_TextComponent.BIAHJAKEMLM.lineInfo[hGCMIDFMKHD + 1].IAJJNNOAMLG; i < fNOFPOMADEM; i++)
			{
				MGLLLPMKGDA mGLLLPMKGDA2 = m_TextComponent.BIAHJAKEMLM.characterInfo[i];
				float num4 = mGLLLPMKGDA.EBDCOMKHPBG - mGLLLPMKGDA2.EBDCOMKHPBG;
				float num5 = num4 / (mGLLLPMKGDA2.MDKGJAGDLHC - mGLLLPMKGDA2.EBDCOMKHPBG);
				if (num5 >= 0f && num5 <= 1f)
				{
					if (num5 < 0.5f)
					{
						return i;
					}
					return i + 1;
				}
				num4 = Mathf.Abs(num4);
				if (num4 < num2)
				{
					num = i;
					num2 = num4;
					num3 = num5;
				}
			}
			if (num == -1)
			{
				return fNOFPOMADEM;
			}
			if (num3 < 0.5f)
			{
				return num;
			}
			return num + 1;
		}

		private int GIBOOPAFIFD(int LOPAFEGFAGG, bool ACOJHNCFILB)
		{
			if (LOPAFEGFAGG >= m_TextComponent.BIAHJAKEMLM.characterCount)
			{
				LOPAFEGFAGG--;
			}
			MGLLLPMKGDA mGLLLPMKGDA = m_TextComponent.BIAHJAKEMLM.characterInfo[LOPAFEGFAGG];
			int hGCMIDFMKHD = mGLLLPMKGDA.HGCMIDFMKHD;
			if (hGCMIDFMKHD - 1 < 0)
			{
				return (!ACOJHNCFILB) ? LOPAFEGFAGG : 0;
			}
			float height = m_TextViewport.rect.height;
			int num = hGCMIDFMKHD - 1;
			while (num > 0 && !(m_TextComponent.BIAHJAKEMLM.lineInfo[num].EEGJFJDMBGN > m_TextComponent.BIAHJAKEMLM.lineInfo[hGCMIDFMKHD].EEGJFJDMBGN + height))
			{
				num--;
			}
			int fNOFPOMADEM = m_TextComponent.BIAHJAKEMLM.lineInfo[num].FNOFPOMADEM;
			int num2 = -1;
			float num3 = 32767f;
			float num4 = 0f;
			for (int i = m_TextComponent.BIAHJAKEMLM.lineInfo[num].IAJJNNOAMLG; i < fNOFPOMADEM; i++)
			{
				MGLLLPMKGDA mGLLLPMKGDA2 = m_TextComponent.BIAHJAKEMLM.characterInfo[i];
				float num5 = mGLLLPMKGDA.EBDCOMKHPBG - mGLLLPMKGDA2.EBDCOMKHPBG;
				float num6 = num5 / (mGLLLPMKGDA2.MDKGJAGDLHC - mGLLLPMKGDA2.EBDCOMKHPBG);
				if (num6 >= 0f && num6 <= 1f)
				{
					if (num6 < 0.5f)
					{
						return i;
					}
					return i + 1;
				}
				num5 = Mathf.Abs(num5);
				if (num5 < num3)
				{
					num2 = i;
					num3 = num5;
					num4 = num6;
				}
			}
			if (num2 == -1)
			{
				return fNOFPOMADEM;
			}
			if (num4 < 0.5f)
			{
				return num2;
			}
			return num2 + 1;
		}

		private int EOBMPCBEOAF(int LOPAFEGFAGG, bool HCMKOGPFHCJ)
		{
			if (LOPAFEGFAGG >= m_TextComponent.BIAHJAKEMLM.characterCount)
			{
				return m_TextComponent.BIAHJAKEMLM.characterCount - 1;
			}
			MGLLLPMKGDA mGLLLPMKGDA = m_TextComponent.BIAHJAKEMLM.characterInfo[LOPAFEGFAGG];
			int hGCMIDFMKHD = mGLLLPMKGDA.HGCMIDFMKHD;
			if (hGCMIDFMKHD + 1 >= m_TextComponent.BIAHJAKEMLM.lineCount)
			{
				return (!HCMKOGPFHCJ) ? LOPAFEGFAGG : (m_TextComponent.BIAHJAKEMLM.characterCount - 1);
			}
			float height = m_TextViewport.rect.height;
			int i;
			for (i = hGCMIDFMKHD + 1; i < m_TextComponent.BIAHJAKEMLM.lineCount - 1 && !(m_TextComponent.BIAHJAKEMLM.lineInfo[i].EEGJFJDMBGN < m_TextComponent.BIAHJAKEMLM.lineInfo[hGCMIDFMKHD].EEGJFJDMBGN - height); i++)
			{
			}
			int fNOFPOMADEM = m_TextComponent.BIAHJAKEMLM.lineInfo[i].FNOFPOMADEM;
			int num = -1;
			float num2 = 32767f;
			float num3 = 0f;
			for (int j = m_TextComponent.BIAHJAKEMLM.lineInfo[i].IAJJNNOAMLG; j < fNOFPOMADEM; j++)
			{
				MGLLLPMKGDA mGLLLPMKGDA2 = m_TextComponent.BIAHJAKEMLM.characterInfo[j];
				float num4 = mGLLLPMKGDA.EBDCOMKHPBG - mGLLLPMKGDA2.EBDCOMKHPBG;
				float num5 = num4 / (mGLLLPMKGDA2.MDKGJAGDLHC - mGLLLPMKGDA2.EBDCOMKHPBG);
				if (num5 >= 0f && num5 <= 1f)
				{
					if (num5 < 0.5f)
					{
						return j;
					}
					return j + 1;
				}
				num4 = Mathf.Abs(num4);
				if (num4 < num2)
				{
					num = j;
					num2 = num4;
					num3 = num5;
				}
			}
			if (num == -1)
			{
				return fNOFPOMADEM;
			}
			if (num3 < 0.5f)
			{
				return num;
			}
			return num + 1;
		}

		private void AODGFDBIHOB(bool IMLCPJDGOEO)
		{
			AODGFDBIHOB(IMLCPJDGOEO, true);
		}

		private void AODGFDBIHOB(bool IMLCPJDGOEO, bool HCMKOGPFHCJ)
		{
			int eDDNOJDPMCF;
			if (JDOJHNLJGAA && !IMLCPJDGOEO)
			{
				eDDNOJDPMCF = (KNLONNOEOJG = Mathf.Max(DBKLFBEGCHH, KNLONNOEOJG));
				DBKLFBEGCHH = eDDNOJDPMCF;
			}
			int num2 = ((!DFICAMNBEJL) ? (m_TextComponent.BIAHJAKEMLM.characterCount - 1) : GLLCHGDIPOB(KNLONNOEOJG, HCMKOGPFHCJ));
			if (IMLCPJDGOEO)
			{
				KNLONNOEOJG = num2;
				OGEJLKAFLCJ = AFGLLEPCLAO(KNLONNOEOJG);
				return;
			}
			eDDNOJDPMCF = (DBKLFBEGCHH = num2);
			KNLONNOEOJG = eDDNOJDPMCF;
			eDDNOJDPMCF = (CIEKBEHJNBP = AFGLLEPCLAO(KNLONNOEOJG));
			OGEJLKAFLCJ = eDDNOJDPMCF;
		}

		private void LIPFHILMNHH(bool IMLCPJDGOEO)
		{
			LIPFHILMNHH(IMLCPJDGOEO, true);
		}

		private void LIPFHILMNHH(bool IMLCPJDGOEO, bool ACOJHNCFILB)
		{
			int eDDNOJDPMCF;
			if (JDOJHNLJGAA && !IMLCPJDGOEO)
			{
				eDDNOJDPMCF = (KNLONNOEOJG = Mathf.Min(DBKLFBEGCHH, KNLONNOEOJG));
				DBKLFBEGCHH = eDDNOJDPMCF;
			}
			int num2 = (DFICAMNBEJL ? KLFEAFKMKCO(KNLONNOEOJG, ACOJHNCFILB) : 0);
			if (IMLCPJDGOEO)
			{
				KNLONNOEOJG = num2;
				OGEJLKAFLCJ = AFGLLEPCLAO(KNLONNOEOJG);
				return;
			}
			eDDNOJDPMCF = (DBKLFBEGCHH = num2);
			KNLONNOEOJG = eDDNOJDPMCF;
			eDDNOJDPMCF = (CIEKBEHJNBP = AFGLLEPCLAO(KNLONNOEOJG));
			OGEJLKAFLCJ = eDDNOJDPMCF;
		}

		private void MCHCAFAPPEA(bool IMLCPJDGOEO)
		{
			MCHCAFAPPEA(IMLCPJDGOEO, true);
		}

		private void MCHCAFAPPEA(bool IMLCPJDGOEO, bool ACOJHNCFILB)
		{
			if (JDOJHNLJGAA && !IMLCPJDGOEO)
			{
				int eDDNOJDPMCF = (KNLONNOEOJG = Mathf.Min(DBKLFBEGCHH, KNLONNOEOJG));
				DBKLFBEGCHH = eDDNOJDPMCF;
			}
			int num2 = (DFICAMNBEJL ? GIBOOPAFIFD(KNLONNOEOJG, ACOJHNCFILB) : 0);
			if (IMLCPJDGOEO)
			{
				KNLONNOEOJG = num2;
				OGEJLKAFLCJ = AFGLLEPCLAO(KNLONNOEOJG);
			}
			else
			{
				int eDDNOJDPMCF = (DBKLFBEGCHH = num2);
				KNLONNOEOJG = eDDNOJDPMCF;
				eDDNOJDPMCF = (CIEKBEHJNBP = AFGLLEPCLAO(KNLONNOEOJG));
				OGEJLKAFLCJ = eDDNOJDPMCF;
			}
			if (m_LineType != 0)
			{
				float height = m_TextViewport.rect.height;
				float num5 = m_TextComponent.GPPKOGCLKPL.position.y + m_TextComponent.LAIBPAIMCNL.max.y;
				float num6 = m_TextViewport.position.y + m_TextViewport.rect.yMax;
				height = ((!(num6 > num5 + height)) ? (num6 - num5) : height);
				m_TextComponent.GPPKOGCLKPL.anchoredPosition += new Vector2(0f, height);
				OOCDPDNEPFP();
				HECLPCCLHFB = true;
			}
		}

		private void CFBOBCLFOED(bool IMLCPJDGOEO)
		{
			CFBOBCLFOED(IMLCPJDGOEO, true);
		}

		private void CFBOBCLFOED(bool IMLCPJDGOEO, bool HCMKOGPFHCJ)
		{
			if (JDOJHNLJGAA && !IMLCPJDGOEO)
			{
				int eDDNOJDPMCF = (KNLONNOEOJG = Mathf.Max(DBKLFBEGCHH, KNLONNOEOJG));
				DBKLFBEGCHH = eDDNOJDPMCF;
			}
			int num2 = ((!DFICAMNBEJL) ? (m_TextComponent.BIAHJAKEMLM.characterCount - 1) : EOBMPCBEOAF(KNLONNOEOJG, HCMKOGPFHCJ));
			if (IMLCPJDGOEO)
			{
				KNLONNOEOJG = num2;
				OGEJLKAFLCJ = AFGLLEPCLAO(KNLONNOEOJG);
			}
			else
			{
				int eDDNOJDPMCF = (DBKLFBEGCHH = num2);
				KNLONNOEOJG = eDDNOJDPMCF;
				eDDNOJDPMCF = (CIEKBEHJNBP = AFGLLEPCLAO(KNLONNOEOJG));
				OGEJLKAFLCJ = eDDNOJDPMCF;
			}
			if (m_LineType != 0)
			{
				float height = m_TextViewport.rect.height;
				float num5 = m_TextComponent.GPPKOGCLKPL.position.y + m_TextComponent.LAIBPAIMCNL.min.y;
				float num6 = m_TextViewport.position.y + m_TextViewport.rect.yMin;
				height = ((!(num6 > num5 + height)) ? (num6 - num5) : height);
				m_TextComponent.GPPKOGCLKPL.anchoredPosition += new Vector2(0f, height);
				OOCDPDNEPFP();
				HECLPCCLHFB = true;
			}
		}

		private void GIOCEEGBFKL()
		{
			if (m_ReadOnly || CIEKBEHJNBP == OGEJLKAFLCJ)
			{
				return;
			}
			if (m_isRichTextEditingAllowed || ELFFFDFNNNL)
			{
				if (CIEKBEHJNBP < OGEJLKAFLCJ)
				{
					m_Text = FCJBBPHFNPJ.Substring(0, CIEKBEHJNBP) + FCJBBPHFNPJ.Substring(OGEJLKAFLCJ, FCJBBPHFNPJ.Length - OGEJLKAFLCJ);
					OGEJLKAFLCJ = CIEKBEHJNBP;
				}
				else
				{
					m_Text = FCJBBPHFNPJ.Substring(0, OGEJLKAFLCJ) + FCJBBPHFNPJ.Substring(CIEKBEHJNBP, FCJBBPHFNPJ.Length - CIEKBEHJNBP);
					CIEKBEHJNBP = OGEJLKAFLCJ;
				}
				ELFFFDFNNNL = false;
				return;
			}
			CIEKBEHJNBP = AFGLLEPCLAO(DBKLFBEGCHH);
			OGEJLKAFLCJ = AFGLLEPCLAO(KNLONNOEOJG);
			if (DBKLFBEGCHH < KNLONNOEOJG)
			{
				m_Text = FCJBBPHFNPJ.Substring(0, CIEKBEHJNBP) + FCJBBPHFNPJ.Substring(OGEJLKAFLCJ, FCJBBPHFNPJ.Length - OGEJLKAFLCJ);
				OGEJLKAFLCJ = CIEKBEHJNBP;
				KNLONNOEOJG = DBKLFBEGCHH;
			}
			else
			{
				m_Text = FCJBBPHFNPJ.Substring(0, OGEJLKAFLCJ) + FCJBBPHFNPJ.Substring(CIEKBEHJNBP, FCJBBPHFNPJ.Length - CIEKBEHJNBP);
				CIEKBEHJNBP = OGEJLKAFLCJ;
				CIEKBEHJNBP = OGEJLKAFLCJ;
				DBKLFBEGCHH = KNLONNOEOJG;
			}
		}

		private void MJDDNENMJED()
		{
			if (m_ReadOnly)
			{
				return;
			}
			if (JDOJHNLJGAA)
			{
				GIOCEEGBFKL();
				DPMKICHFGCO();
			}
			else if (m_isRichTextEditingAllowed)
			{
				if (CIEKBEHJNBP < FCJBBPHFNPJ.Length)
				{
					m_Text = FCJBBPHFNPJ.Remove(CIEKBEHJNBP, 1);
					DPMKICHFGCO();
				}
			}
			else if (DBKLFBEGCHH < m_TextComponent.BIAHJAKEMLM.characterCount - 1)
			{
				int eDDNOJDPMCF = (CIEKBEHJNBP = AFGLLEPCLAO(DBKLFBEGCHH));
				OGEJLKAFLCJ = eDDNOJDPMCF;
				m_Text = FCJBBPHFNPJ.Remove(CIEKBEHJNBP, 1);
				DPMKICHFGCO();
			}
		}

		private void LCJDGMMNGNM()
		{
			if (m_ReadOnly)
			{
				return;
			}
			if (JDOJHNLJGAA)
			{
				GIOCEEGBFKL();
				DPMKICHFGCO();
				return;
			}
			if (m_isRichTextEditingAllowed)
			{
				if (CIEKBEHJNBP > 0)
				{
					m_Text = FCJBBPHFNPJ.Remove(CIEKBEHJNBP - 1, 1);
					OGEJLKAFLCJ = --CIEKBEHJNBP;
					BFGPLHJLILB = true;
					DPMKICHFGCO();
				}
				return;
			}
			if (DBKLFBEGCHH > 0)
			{
				m_Text = FCJBBPHFNPJ.Remove(AFGLLEPCLAO(DBKLFBEGCHH - 1), 1);
				KNLONNOEOJG = --DBKLFBEGCHH;
				int eDDNOJDPMCF = (CIEKBEHJNBP = AFGLLEPCLAO(DBKLFBEGCHH));
				OGEJLKAFLCJ = eDDNOJDPMCF;
			}
			BFGPLHJLILB = true;
			DPMKICHFGCO();
		}

		protected virtual void GBKNDKCPBEH(string MOPCLEEGDFB)
		{
			if (m_ReadOnly || !BPPKCLAAOJE())
			{
				return;
			}
			int i = 0;
			for (int length = MOPCLEEGDFB.Length; i < length; i++)
			{
				char c = MOPCLEEGDFB[i];
				if (c >= ' ' || c == '\t' || c == '\r' || c == '\n' || c == '\n')
				{
					GBKNDKCPBEH(c);
				}
			}
		}

		protected virtual void GBKNDKCPBEH(char MOPCLEEGDFB)
		{
			if (m_ReadOnly || !BPPKCLAAOJE())
			{
				return;
			}
			if (BMAJAEDMLHI != null)
			{
				MOPCLEEGDFB = BMAJAEDMLHI(FCJBBPHFNPJ, CIEKBEHJNBP, MOPCLEEGDFB);
			}
			else
			{
				if (ELECECIHMHO == AIDAPPLANOP.CustomValidator)
				{
					MOPCLEEGDFB = PIBLOPJEGEL(FCJBBPHFNPJ, CIEKBEHJNBP, MOPCLEEGDFB);
					if (MOPCLEEGDFB != 0)
					{
						PENBDAGKIPK();
						BDFANJGPPHB();
					}
					return;
				}
				if (ELECECIHMHO != 0)
				{
					MOPCLEEGDFB = PIBLOPJEGEL(FCJBBPHFNPJ, CIEKBEHJNBP, MOPCLEEGDFB);
				}
			}
			if (MOPCLEEGDFB != 0)
			{
				GKEGKCPCKJG(MOPCLEEGDFB);
			}
		}

		private void GKEGKCPCKJG(char FMFABAKPMLB)
		{
			if (!m_ReadOnly)
			{
				string text = FMFABAKPMLB.ToString();
				GIOCEEGBFKL();
				if (NCGHJDIFGBJ <= 0 || FCJBBPHFNPJ.Length < NCGHJDIFGBJ)
				{
					m_Text = FCJBBPHFNPJ.Insert(GKHDHPLMMIC, text);
					OGEJLKAFLCJ = (CIEKBEHJNBP += text.Length);
					PENBDAGKIPK();
				}
			}
		}

		private void DPMKICHFGCO()
		{
			PENBDAGKIPK();
			BDFANJGPPHB();
		}

		private void PENBDAGKIPK()
		{
			if (DMIIPGENFFL != null)
			{
				DMIIPGENFFL.Invoke(FCJBBPHFNPJ);
			}
		}

		protected void BBPFDDHCDEA()
		{
			if (PHPADJKLJFF != null)
			{
				PHPADJKLJFF.Invoke(m_Text);
			}
		}

		protected void BAFOKDNCILJ()
		{
			if (AFBAPAHBJAA != null)
			{
				AFBAPAHBJAA.Invoke(m_Text);
			}
		}

		protected void JDEABENMCOC()
		{
			if (EGAKHLKHAKJ != null)
			{
				EGAKHLKHAKJ.Invoke(m_Text);
			}
		}

		protected void JAHMIKGMALI()
		{
			if (LKBPBEHDHAG != null)
			{
				LKBPBEHDHAG.Invoke(m_Text);
			}
		}

		protected void BDLCDACADBO()
		{
			MKEPAMLKEHF = true;
			if (OPKHAJEJKOF != null)
			{
				OPKHAJEJKOF.Invoke(m_Text, CIEKBEHJNBP, OGEJLKAFLCJ);
			}
		}

		protected void EMCFGFKCDCD()
		{
			if (MKEPAMLKEHF)
			{
				if (JDAPPDMOHDN != null)
				{
					JDAPPDMOHDN.Invoke(m_Text, CIEKBEHJNBP, OGEJLKAFLCJ);
				}
				MKEPAMLKEHF = false;
			}
		}

		protected void BDFANJGPPHB()
		{
			if (m_TextComponent != null && m_TextComponent.ELKNHALJKNI != null)
			{
				string text = ((Input.compositionString.Length <= 0) ? FCJBBPHFNPJ : (FCJBBPHFNPJ.Substring(0, GKHDHPLMMIC) + Input.compositionString + FCJBBPHFNPJ.Substring(GKHDHPLMMIC)));
				string text2 = ((JBLLAJJIPLO != IDCNHFIGNMA.Password) ? text : new string(LACBCNDLGOK, text.Length));
				bool flag = string.IsNullOrEmpty(text);
				if (m_Placeholder != null)
				{
					m_Placeholder.enabled = flag;
				}
				if (!flag)
				{
					JJPFLKPKNML();
				}
				m_TextComponent.FCJBBPHFNPJ = text2 + "\u200b";
				FDLJMIAKKJB();
				HECLPCCLHFB = true;
			}
		}

		private void DAHDPMCLIEB()
		{
			if ((bool)m_VerticalScrollbar)
			{
				float size = m_TextViewport.rect.height / m_TextComponent.ICJOPDNAIJF;
				MIHAKKHBHEH = true;
				m_VerticalScrollbar.size = size;
				m_VerticalScrollbar.value = m_TextComponent.GPPKOGCLKPL.anchoredPosition.y / (m_TextComponent.ICJOPDNAIJF - m_TextViewport.rect.height);
			}
		}

		private void OIAILAKGPAO(float EDDNOJDPMCF)
		{
			if (MIHAKKHBHEH)
			{
				MIHAKKHBHEH = false;
			}
			else if (!(EDDNOJDPMCF < 0f) && !(EDDNOJDPMCF > 1f))
			{
				DCGKMDPNIIJ(EDDNOJDPMCF);
				CIEKFNNAEIB = EDDNOJDPMCF;
			}
		}

		private void DCGKMDPNIIJ(float KGAFKOGJFFI)
		{
			TMP_TextInfo textInfo = m_TextComponent.BIAHJAKEMLM;
			if (textInfo != null && textInfo.lineInfo != null && textInfo.lineCount != 0 && textInfo.lineCount <= textInfo.lineInfo.Length)
			{
				m_TextComponent.GPPKOGCLKPL.anchoredPosition = new Vector2(m_TextComponent.GPPKOGCLKPL.anchoredPosition.x, (m_TextComponent.ICJOPDNAIJF - m_TextViewport.rect.height) * KGAFKOGJFFI);
				OOCDPDNEPFP();
			}
		}

		private int FPHHDGLJDFE(int NNKMMCGKJED)
		{
			int characterCount = m_TextComponent.BIAHJAKEMLM.characterCount;
			for (int i = 0; i < characterCount; i++)
			{
				if (m_TextComponent.BIAHJAKEMLM.characterInfo[i].EHJNMODJEAN >= NNKMMCGKJED)
				{
					return i;
				}
			}
			return characterCount;
		}

		private int AFGLLEPCLAO(int CNBIEMAAIKB)
		{
			EPKOLADCKOO(ref CNBIEMAAIKB);
			return m_TextComponent.BIAHJAKEMLM.characterInfo[CNBIEMAAIKB].EHJNMODJEAN;
		}

		public void ForceLabelUpdate()
		{
			BDFANJGPPHB();
		}

		private void FDLJMIAKKJB()
		{
			CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild(this);
		}

		public virtual void Rebuild(CanvasUpdate LMJFIOAJCGK)
		{
			if (LMJFIOAJCGK == CanvasUpdate.LatePreRender)
			{
				PHHDBIJJLEG();
			}
		}

		public virtual void LayoutComplete()
		{
		}

		public virtual void GraphicUpdateComplete()
		{
		}

		private void PHHDBIJJLEG()
		{
			if (BLOPDMFLKBF && !(JAADDJKDLKJ == null))
			{
				KMLFHCNGAAN(IJKCGGPJDIG);
				JAADDJKDLKJ.SetMesh(IJKCGGPJDIG);
			}
		}

		private void OOCDPDNEPFP()
		{
			if (m_TextComponent != null && GKGALKFEGDO != null && (GKGALKFEGDO.localPosition != m_TextComponent.GPPKOGCLKPL.localPosition || GKGALKFEGDO.localRotation != m_TextComponent.GPPKOGCLKPL.localRotation || GKGALKFEGDO.localScale != m_TextComponent.GPPKOGCLKPL.localScale || GKGALKFEGDO.anchorMin != m_TextComponent.GPPKOGCLKPL.anchorMin || GKGALKFEGDO.anchorMax != m_TextComponent.GPPKOGCLKPL.anchorMax || GKGALKFEGDO.anchoredPosition != m_TextComponent.GPPKOGCLKPL.anchoredPosition || GKGALKFEGDO.sizeDelta != m_TextComponent.GPPKOGCLKPL.sizeDelta || GKGALKFEGDO.pivot != m_TextComponent.GPPKOGCLKPL.pivot))
			{
				GKGALKFEGDO.localPosition = m_TextComponent.GPPKOGCLKPL.localPosition;
				GKGALKFEGDO.localRotation = m_TextComponent.GPPKOGCLKPL.localRotation;
				GKGALKFEGDO.localScale = m_TextComponent.GPPKOGCLKPL.localScale;
				GKGALKFEGDO.anchorMin = m_TextComponent.GPPKOGCLKPL.anchorMin;
				GKGALKFEGDO.anchorMax = m_TextComponent.GPPKOGCLKPL.anchorMax;
				GKGALKFEGDO.anchoredPosition = m_TextComponent.GPPKOGCLKPL.anchoredPosition;
				GKGALKFEGDO.sizeDelta = m_TextComponent.GPPKOGCLKPL.sizeDelta;
				GKGALKFEGDO.pivot = m_TextComponent.GPPKOGCLKPL.pivot;
			}
		}

		private void KMLFHCNGAAN(Mesh AKKHCAECCAN)
		{
			using (VertexHelper vertexHelper = new VertexHelper())
			{
				if (!MKAKFOEBMDF && m_ResetOnDeActivation)
				{
					vertexHelper.FillMesh(AKKHCAECCAN);
					return;
				}
				if (NPOJHDCLMGF)
				{
					CIEKBEHJNBP = AFGLLEPCLAO(LINDIJIBFNA);
					OGEJLKAFLCJ = AFGLLEPCLAO(NPFBLBEEAAN);
					NPOJHDCLMGF = false;
				}
				if (!JDOJHNLJGAA)
				{
					HCBNCOKAPIF(vertexHelper, Vector2.zero);
					EMCFGFKCDCD();
				}
				else
				{
					GNHJMHCMLAI(vertexHelper, Vector2.zero);
					BDLCDACADBO();
				}
				vertexHelper.FillMesh(AKKHCAECCAN);
			}
		}

		private void HCBNCOKAPIF(VertexHelper AKKHCAECCAN, Vector2 NJMMJABJJGA)
		{
			if (MNHLCOGBNML)
			{
				if (FENKCOFCPLK == null)
				{
					ALINDJJEJPE();
				}
				float num = m_CaretWidth;
				int characterCount = m_TextComponent.BIAHJAKEMLM.characterCount;
				Vector2 zero = Vector2.zero;
				float num2 = 0f;
				DBKLFBEGCHH = FPHHDGLJDFE(CIEKBEHJNBP);
				MGLLLPMKGDA mGLLLPMKGDA;
				if (DBKLFBEGCHH == 0)
				{
					mGLLLPMKGDA = m_TextComponent.BIAHJAKEMLM.characterInfo[0];
					zero = new Vector2(mGLLLPMKGDA.EBDCOMKHPBG, mGLLLPMKGDA.CALDBEMMLEA);
					num2 = mGLLLPMKGDA.MNKFKKODLLM - mGLLLPMKGDA.CALDBEMMLEA;
				}
				else if (DBKLFBEGCHH < characterCount)
				{
					mGLLLPMKGDA = m_TextComponent.BIAHJAKEMLM.characterInfo[DBKLFBEGCHH];
					zero = new Vector2(mGLLLPMKGDA.EBDCOMKHPBG, mGLLLPMKGDA.CALDBEMMLEA);
					num2 = mGLLLPMKGDA.MNKFKKODLLM - mGLLLPMKGDA.CALDBEMMLEA;
				}
				else
				{
					mGLLLPMKGDA = m_TextComponent.BIAHJAKEMLM.characterInfo[characterCount - 1];
					zero = new Vector2(mGLLLPMKGDA.MDKGJAGDLHC, mGLLLPMKGDA.CALDBEMMLEA);
					num2 = mGLLLPMKGDA.MNKFKKODLLM - mGLLLPMKGDA.CALDBEMMLEA;
				}
				if (MKAKFOEBMDF && zero != FIGBIOGOCHL)
				{
					CHCMIBDFNAP(zero, num2, mGLLLPMKGDA.BACHBACHNOF);
				}
				FIGBIOGOCHL = zero;
				float num3 = zero.y + num2;
				float y = num3 - num2;
				FENKCOFCPLK[0].position = new Vector3(zero.x, y, 0f);
				FENKCOFCPLK[1].position = new Vector3(zero.x, num3, 0f);
				FENKCOFCPLK[2].position = new Vector3(zero.x + num, num3, 0f);
				FENKCOFCPLK[3].position = new Vector3(zero.x + num, y, 0f);
				FENKCOFCPLK[0].color = FEMMDBBLOPI;
				FENKCOFCPLK[1].color = FEMMDBBLOPI;
				FENKCOFCPLK[2].color = FEMMDBBLOPI;
				FENKCOFCPLK[3].color = FEMMDBBLOPI;
				AKKHCAECCAN.AddUIVertexQuad(FENKCOFCPLK);
				int height = Screen.height;
				zero.y = (float)height - zero.y;
				Input.compositionCursorPos = zero;
			}
		}

		private void ALINDJJEJPE()
		{
			FENKCOFCPLK = new UIVertex[4];
			for (int i = 0; i < FENKCOFCPLK.Length; i++)
			{
				FENKCOFCPLK[i] = UIVertex.simpleVert;
				FENKCOFCPLK[i].uv0 = Vector2.zero;
			}
		}

		private void GNHJMHCMLAI(VertexHelper AKKHCAECCAN, Vector2 NJMMJABJJGA)
		{
			TMP_TextInfo textInfo = m_TextComponent.BIAHJAKEMLM;
			DBKLFBEGCHH = (LINDIJIBFNA = FPHHDGLJDFE(CIEKBEHJNBP));
			KNLONNOEOJG = (NPFBLBEEAAN = FPHHDGLJDFE(OGEJLKAFLCJ));
			float num = 0f;
			Vector2 kKAHENNAJJD;
			if (KNLONNOEOJG < textInfo.characterCount)
			{
				kKAHENNAJJD = new Vector2(textInfo.characterInfo[KNLONNOEOJG].EBDCOMKHPBG, textInfo.characterInfo[KNLONNOEOJG].CALDBEMMLEA);
				num = textInfo.characterInfo[KNLONNOEOJG].MNKFKKODLLM - textInfo.characterInfo[KNLONNOEOJG].CALDBEMMLEA;
			}
			else
			{
				kKAHENNAJJD = new Vector2(textInfo.characterInfo[KNLONNOEOJG - 1].MDKGJAGDLHC, textInfo.characterInfo[KNLONNOEOJG - 1].CALDBEMMLEA);
				num = textInfo.characterInfo[KNLONNOEOJG - 1].MNKFKKODLLM - textInfo.characterInfo[KNLONNOEOJG - 1].CALDBEMMLEA;
			}
			CHCMIBDFNAP(kKAHENNAJJD, num, true);
			int num2 = Mathf.Max(0, DBKLFBEGCHH);
			int num3 = Mathf.Max(0, KNLONNOEOJG);
			if (num2 > num3)
			{
				int num4 = num2;
				num2 = num3;
				num3 = num4;
			}
			num3--;
			int num5 = textInfo.characterInfo[num2].HGCMIDFMKHD;
			int fNOFPOMADEM = textInfo.lineInfo[num5].FNOFPOMADEM;
			UIVertex simpleVert = UIVertex.simpleVert;
			simpleVert.uv0 = Vector2.zero;
			simpleVert.color = JFGJJMMBMEB;
			for (int i = num2; i <= num3 && i < textInfo.characterCount; i++)
			{
				if (i == fNOFPOMADEM || i == num3)
				{
					MGLLLPMKGDA mGLLLPMKGDA = textInfo.characterInfo[num2];
					MGLLLPMKGDA mGLLLPMKGDA2 = textInfo.characterInfo[i];
					if (i > 0 && mGLLLPMKGDA2.AONJCHFEHOM == '\n' && textInfo.characterInfo[i - 1].AONJCHFEHOM == '\r')
					{
						mGLLLPMKGDA2 = textInfo.characterInfo[i - 1];
					}
					Vector2 vector = new Vector2(mGLLLPMKGDA.EBDCOMKHPBG, textInfo.lineInfo[num5].MNKFKKODLLM);
					Vector2 vector2 = new Vector2(mGLLLPMKGDA2.MDKGJAGDLHC, textInfo.lineInfo[num5].CALDBEMMLEA);
					int currentVertCount = AKKHCAECCAN.currentVertCount;
					simpleVert.position = new Vector3(vector.x, vector2.y, 0f);
					AKKHCAECCAN.AddVert(simpleVert);
					simpleVert.position = new Vector3(vector2.x, vector2.y, 0f);
					AKKHCAECCAN.AddVert(simpleVert);
					simpleVert.position = new Vector3(vector2.x, vector.y, 0f);
					AKKHCAECCAN.AddVert(simpleVert);
					simpleVert.position = new Vector3(vector.x, vector.y, 0f);
					AKKHCAECCAN.AddVert(simpleVert);
					AKKHCAECCAN.AddTriangle(currentVertCount, currentVertCount + 1, currentVertCount + 2);
					AKKHCAECCAN.AddTriangle(currentVertCount + 2, currentVertCount + 3, currentVertCount);
					num2 = i + 1;
					num5++;
					if (num5 < textInfo.lineCount)
					{
						fNOFPOMADEM = textInfo.lineInfo[num5].FNOFPOMADEM;
					}
				}
			}
			HECLPCCLHFB = true;
		}

		private void CHCMIBDFNAP(Vector2 KKAHENNAJJD, float JKNPBEOPMPK, bool IPNJNAKNADN)
		{
			float xMin = m_TextViewport.rect.xMin;
			float xMax = m_TextViewport.rect.xMax;
			float num = xMax - (m_TextComponent.GPPKOGCLKPL.anchoredPosition.x + KKAHENNAJJD.x + m_TextComponent.PNACILIBDDF.z + (float)m_CaretWidth);
			if (num < 0f && (!DFICAMNBEJL || (DFICAMNBEJL && IPNJNAKNADN)))
			{
				m_TextComponent.GPPKOGCLKPL.anchoredPosition += new Vector2(num, 0f);
				OOCDPDNEPFP();
			}
			float num2 = m_TextComponent.GPPKOGCLKPL.anchoredPosition.x + KKAHENNAJJD.x - m_TextComponent.PNACILIBDDF.x - xMin;
			if (num2 < 0f)
			{
				m_TextComponent.GPPKOGCLKPL.anchoredPosition += new Vector2(0f - num2, 0f);
				OOCDPDNEPFP();
			}
			if (m_LineType != 0)
			{
				float num3 = m_TextViewport.rect.yMax - (m_TextComponent.GPPKOGCLKPL.anchoredPosition.y + KKAHENNAJJD.y + JKNPBEOPMPK);
				if (num3 < -0.0001f)
				{
					m_TextComponent.GPPKOGCLKPL.anchoredPosition += new Vector2(0f, num3);
					OOCDPDNEPFP();
					HECLPCCLHFB = true;
				}
				float num4 = m_TextComponent.GPPKOGCLKPL.anchoredPosition.y + KKAHENNAJJD.y - m_TextViewport.rect.yMin;
				if (num4 < 0f)
				{
					m_TextComponent.GPPKOGCLKPL.anchoredPosition -= new Vector2(0f, num4);
					OOCDPDNEPFP();
					HECLPCCLHFB = true;
				}
			}
			if (!BFGPLHJLILB)
			{
				return;
			}
			float num5 = m_TextComponent.GPPKOGCLKPL.anchoredPosition.x + m_TextComponent.BIAHJAKEMLM.characterInfo[0].EBDCOMKHPBG - m_TextComponent.PNACILIBDDF.x;
			float num6 = m_TextComponent.GPPKOGCLKPL.anchoredPosition.x + m_TextComponent.BIAHJAKEMLM.characterInfo[m_TextComponent.BIAHJAKEMLM.characterCount - 1].EBDCOMKHPBG + m_TextComponent.PNACILIBDDF.z;
			if (m_TextComponent.GPPKOGCLKPL.anchoredPosition.x + KKAHENNAJJD.x <= xMin + 0.0001f)
			{
				if (num5 < xMin)
				{
					float x = Mathf.Min((xMax - xMin) / 2f, xMin - num5);
					m_TextComponent.GPPKOGCLKPL.anchoredPosition += new Vector2(x, 0f);
					OOCDPDNEPFP();
				}
			}
			else if (num6 < xMax && num5 < xMin)
			{
				float x2 = Mathf.Min(xMax - num6, xMin - num5);
				m_TextComponent.GPPKOGCLKPL.anchoredPosition += new Vector2(x2, 0f);
				OOCDPDNEPFP();
			}
			BFGPLHJLILB = false;
		}

		protected char PIBLOPJEGEL(string FCJBBPHFNPJ, int FADJPCHMMBH, char GKDKBFOPOJG)
		{
			if (ELECECIHMHO == AIDAPPLANOP.None || !base.enabled)
			{
				return GKDKBFOPOJG;
			}
			if (ELECECIHMHO == AIDAPPLANOP.Integer || ELECECIHMHO == AIDAPPLANOP.Decimal)
			{
				bool flag = FADJPCHMMBH == 0 && FCJBBPHFNPJ.Length > 0 && FCJBBPHFNPJ[0] == '-';
				bool flag2 = CIEKBEHJNBP == 0 || OGEJLKAFLCJ == 0;
				if (!flag)
				{
					if (GKDKBFOPOJG >= '0' && GKDKBFOPOJG <= '9')
					{
						return GKDKBFOPOJG;
					}
					if (GKDKBFOPOJG == '-' && (FADJPCHMMBH == 0 || flag2))
					{
						return GKDKBFOPOJG;
					}
					if (GKDKBFOPOJG == '.' && ELECECIHMHO == AIDAPPLANOP.Decimal && !FCJBBPHFNPJ.Contains("."))
					{
						return GKDKBFOPOJG;
					}
				}
			}
			else if (ELECECIHMHO == AIDAPPLANOP.Digit)
			{
				if (GKDKBFOPOJG >= '0' && GKDKBFOPOJG <= '9')
				{
					return GKDKBFOPOJG;
				}
			}
			else if (ELECECIHMHO == AIDAPPLANOP.Alphanumeric)
			{
				if (GKDKBFOPOJG >= 'A' && GKDKBFOPOJG <= 'Z')
				{
					return GKDKBFOPOJG;
				}
				if (GKDKBFOPOJG >= 'a' && GKDKBFOPOJG <= 'z')
				{
					return GKDKBFOPOJG;
				}
				if (GKDKBFOPOJG >= '0' && GKDKBFOPOJG <= '9')
				{
					return GKDKBFOPOJG;
				}
			}
			else if (ELECECIHMHO == AIDAPPLANOP.Name)
			{
				char c = ((FCJBBPHFNPJ.Length <= 0) ? ' ' : FCJBBPHFNPJ[Mathf.Clamp(FADJPCHMMBH, 0, FCJBBPHFNPJ.Length - 1)]);
				char c2 = ((FCJBBPHFNPJ.Length <= 0) ? '\n' : FCJBBPHFNPJ[Mathf.Clamp(FADJPCHMMBH + 1, 0, FCJBBPHFNPJ.Length - 1)]);
				if (char.IsLetter(GKDKBFOPOJG))
				{
					if (char.IsLower(GKDKBFOPOJG) && c == ' ')
					{
						return char.ToUpper(GKDKBFOPOJG);
					}
					if (char.IsUpper(GKDKBFOPOJG) && c != ' ' && c != '\'')
					{
						return char.ToLower(GKDKBFOPOJG);
					}
					return GKDKBFOPOJG;
				}
				switch (GKDKBFOPOJG)
				{
				case '\'':
					if (c != ' ' && c != '\'' && c2 != '\'' && !FCJBBPHFNPJ.Contains("'"))
					{
						return GKDKBFOPOJG;
					}
					break;
				case ' ':
					if (c != ' ' && c != '\'' && c2 != ' ' && c2 != '\'')
					{
						return GKDKBFOPOJG;
					}
					break;
				}
			}
			else if (ELECECIHMHO == AIDAPPLANOP.EmailAddress)
			{
				if (GKDKBFOPOJG >= 'A' && GKDKBFOPOJG <= 'Z')
				{
					return GKDKBFOPOJG;
				}
				if (GKDKBFOPOJG >= 'a' && GKDKBFOPOJG <= 'z')
				{
					return GKDKBFOPOJG;
				}
				if (GKDKBFOPOJG >= '0' && GKDKBFOPOJG <= '9')
				{
					return GKDKBFOPOJG;
				}
				if (GKDKBFOPOJG == '@' && FCJBBPHFNPJ.IndexOf('@') == -1)
				{
					return GKDKBFOPOJG;
				}
				if ("!#$%&'*+-/=?^_`{|}~".IndexOf(GKDKBFOPOJG) != -1)
				{
					return GKDKBFOPOJG;
				}
				if (GKDKBFOPOJG == '.')
				{
					char c3 = ((FCJBBPHFNPJ.Length <= 0) ? ' ' : FCJBBPHFNPJ[Mathf.Clamp(FADJPCHMMBH, 0, FCJBBPHFNPJ.Length - 1)]);
					char c4 = ((FCJBBPHFNPJ.Length <= 0) ? '\n' : FCJBBPHFNPJ[Mathf.Clamp(FADJPCHMMBH + 1, 0, FCJBBPHFNPJ.Length - 1)]);
					if (c3 != '.' && c4 != '.')
					{
						return GKDKBFOPOJG;
					}
				}
			}
			else if (ELECECIHMHO == AIDAPPLANOP.Regex)
			{
				if (Regex.IsMatch(GKDKBFOPOJG.ToString(), m_RegexValue))
				{
					return GKDKBFOPOJG;
				}
			}
			else if (ELECECIHMHO == AIDAPPLANOP.CustomValidator && m_InputValidator != null)
			{
				char result = m_InputValidator.PIBLOPJEGEL(ref FCJBBPHFNPJ, ref FADJPCHMMBH, GKDKBFOPOJG);
				m_Text = FCJBBPHFNPJ;
				int eDDNOJDPMCF = (CIEKBEHJNBP = FADJPCHMMBH);
				OGEJLKAFLCJ = eDDNOJDPMCF;
				return result;
			}
			return '\0';
		}

		public void ActivateInputField()
		{
			if (!(m_TextComponent == null) && !(m_TextComponent.ELKNHALJKNI == null) && IsActive() && IsInteractable())
			{
				if (MKAKFOEBMDF && CHDDIHFNGNM != null && !CHDDIHFNGNM.active)
				{
					CHDDIHFNGNM.active = true;
					CHDDIHFNGNM.text = m_Text;
				}
				CONDEJOKKKP = true;
			}
		}

		private void DNGDALEICCI()
		{
			if (EventSystem.current == null)
			{
				return;
			}
			if (EventSystem.current.currentSelectedGameObject != base.gameObject)
			{
				EventSystem.current.SetSelectedGameObject(base.gameObject);
			}
			if (TouchScreenKeyboard.isSupported)
			{
				if (Input.touchSupported)
				{
					TouchScreenKeyboard.hideInput = BLOPDMFLKBF;
				}
				CHDDIHFNGNM = ((JBLLAJJIPLO != IDCNHFIGNMA.Password) ? TouchScreenKeyboard.Open(m_Text, CMFKPLMFJAE, JBLLAJJIPLO == IDCNHFIGNMA.AutoCorrect, DFICAMNBEJL) : TouchScreenKeyboard.Open(m_Text, CMFKPLMFJAE, false, DFICAMNBEJL, true));
				MoveTextEnd(false);
			}
			else
			{
				Input.imeCompositionMode = IMECompositionMode.On;
				FKFFJCHNGOA();
			}
			JNELODLHIOE = true;
			LDMOJPBIIMJ = FCJBBPHFNPJ;
			BCCBLOOBKPL = false;
			JJPFLKPKNML();
			BDFANJGPPHB();
		}

		public override void OnSelect(BaseEventData HMIFPEJKHHH)
		{
			base.OnSelect(HMIFPEJKHHH);
			JDEABENMCOC();
			ActivateInputField();
		}

		public virtual void OnPointerClick(PointerEventData HMIFPEJKHHH)
		{
			if (HMIFPEJKHHH.button == PointerEventData.InputButton.Left)
			{
				ActivateInputField();
			}
		}

		public void OnControlClick()
		{
		}

		public void DeactivateInputField()
		{
			if (!JNELODLHIOE)
			{
				return;
			}
			KDJLPKDBCDA = false;
			JNELODLHIOE = false;
			if (m_Placeholder != null)
			{
				m_Placeholder.enabled = string.IsNullOrEmpty(m_Text);
			}
			if (m_TextComponent != null && IsInteractable())
			{
				if (BCCBLOOBKPL && m_RestoreOriginalTextOnEscape)
				{
					FCJBBPHFNPJ = LDMOJPBIIMJ;
				}
				if (CHDDIHFNGNM != null)
				{
					CHDDIHFNGNM.active = false;
					CHDDIHFNGNM = null;
				}
				if (m_ResetOnDeActivation)
				{
					GKHDHPLMMIC = (CMCOLAMGEKA = 0);
					LINDIJIBFNA = (NPFBLBEEAAN = 0);
					m_TextComponent.GPPKOGCLKPL.localPosition = KHEDAKAKDEI;
					if (GKGALKFEGDO != null)
					{
						GKGALKFEGDO.localPosition = Vector3.zero;
					}
				}
				BBPFDDHCDEA();
				EMCFGFKCDCD();
				Input.imeCompositionMode = IMECompositionMode.Auto;
			}
			FDLJMIAKKJB();
			HECLPCCLHFB = true;
		}

		public override void OnDeselect(BaseEventData HMIFPEJKHHH)
		{
			DeactivateInputField();
			base.OnDeselect(HMIFPEJKHHH);
			JAHMIKGMALI();
		}

		public virtual void OnSubmit(BaseEventData HMIFPEJKHHH)
		{
			if (IsActive() && IsInteractable())
			{
				if (!MKAKFOEBMDF)
				{
					CONDEJOKKKP = true;
				}
				BAFOKDNCILJ();
			}
		}

		private void ONFPPGHEGHJ()
		{
			switch (JAFLHIJPFKD)
			{
			case JGKHNLKJGPC.Standard:
				m_InputType = IDCNHFIGNMA.Standard;
				m_KeyboardType = TouchScreenKeyboardType.Default;
				m_CharacterValidation = AIDAPPLANOP.None;
				break;
			case JGKHNLKJGPC.Autocorrected:
				m_InputType = IDCNHFIGNMA.AutoCorrect;
				m_KeyboardType = TouchScreenKeyboardType.Default;
				m_CharacterValidation = AIDAPPLANOP.None;
				break;
			case JGKHNLKJGPC.IntegerNumber:
				m_LineType = FOPOPAMAHNM.SingleLine;
				m_TextComponent.MHAGENKBNAN = false;
				m_InputType = IDCNHFIGNMA.Standard;
				m_KeyboardType = TouchScreenKeyboardType.NumberPad;
				m_CharacterValidation = AIDAPPLANOP.Integer;
				break;
			case JGKHNLKJGPC.DecimalNumber:
				m_LineType = FOPOPAMAHNM.SingleLine;
				m_TextComponent.MHAGENKBNAN = false;
				m_InputType = IDCNHFIGNMA.Standard;
				m_KeyboardType = TouchScreenKeyboardType.NumbersAndPunctuation;
				m_CharacterValidation = AIDAPPLANOP.Decimal;
				break;
			case JGKHNLKJGPC.Alphanumeric:
				m_LineType = FOPOPAMAHNM.SingleLine;
				m_TextComponent.MHAGENKBNAN = false;
				m_InputType = IDCNHFIGNMA.Standard;
				m_KeyboardType = TouchScreenKeyboardType.ASCIICapable;
				m_CharacterValidation = AIDAPPLANOP.Alphanumeric;
				break;
			case JGKHNLKJGPC.Name:
				m_LineType = FOPOPAMAHNM.SingleLine;
				m_TextComponent.MHAGENKBNAN = false;
				m_InputType = IDCNHFIGNMA.Standard;
				m_KeyboardType = TouchScreenKeyboardType.Default;
				m_CharacterValidation = AIDAPPLANOP.Name;
				break;
			case JGKHNLKJGPC.EmailAddress:
				m_LineType = FOPOPAMAHNM.SingleLine;
				m_TextComponent.MHAGENKBNAN = false;
				m_InputType = IDCNHFIGNMA.Standard;
				m_KeyboardType = TouchScreenKeyboardType.EmailAddress;
				m_CharacterValidation = AIDAPPLANOP.EmailAddress;
				break;
			case JGKHNLKJGPC.Password:
				m_LineType = FOPOPAMAHNM.SingleLine;
				m_TextComponent.MHAGENKBNAN = false;
				m_InputType = IDCNHFIGNMA.Password;
				m_KeyboardType = TouchScreenKeyboardType.Default;
				m_CharacterValidation = AIDAPPLANOP.None;
				break;
			case JGKHNLKJGPC.Pin:
				m_LineType = FOPOPAMAHNM.SingleLine;
				m_TextComponent.MHAGENKBNAN = false;
				m_InputType = IDCNHFIGNMA.Password;
				m_KeyboardType = TouchScreenKeyboardType.NumberPad;
				m_CharacterValidation = AIDAPPLANOP.Digit;
				break;
			}
		}

		private void LGDCKKPEMNO()
		{
			if (!(m_TextComponent == null))
			{
				if (m_LineType == FOPOPAMAHNM.SingleLine)
				{
					m_TextComponent.MHAGENKBNAN = false;
				}
				else
				{
					m_TextComponent.MHAGENKBNAN = true;
				}
			}
		}

		private void APGKMOOEGED()
		{
			if (!(m_TextComponent == null))
			{
				m_TextComponent.DGCLMBNNONA = m_RichText;
			}
		}

		private void LDFJMHOGILD(params JGKHNLKJGPC[] ODGFAFAKDIM)
		{
			if (JAFLHIJPFKD == JGKHNLKJGPC.Custom)
			{
				return;
			}
			for (int i = 0; i < ODGFAFAKDIM.Length; i++)
			{
				if (JAFLHIJPFKD == ODGFAFAKDIM[i])
				{
					return;
				}
			}
			JAFLHIJPFKD = JGKHNLKJGPC.Custom;
		}

		private void NNIOCEAJCNJ()
		{
			if (JAFLHIJPFKD != JGKHNLKJGPC.Custom)
			{
				JAFLHIJPFKD = JGKHNLKJGPC.Custom;
			}
		}

		private void NNIOCEAJCNJ(AIDAPPLANOP ELECECIHMHO)
		{
			if (JAFLHIJPFKD == JGKHNLKJGPC.Custom)
			{
				ELECECIHMHO = AIDAPPLANOP.CustomValidator;
				return;
			}
			JAFLHIJPFKD = JGKHNLKJGPC.Custom;
			ELECECIHMHO = AIDAPPLANOP.CustomValidator;
		}

		protected override void DoStateTransition(SelectionState BGEDKGLJIGM, bool ALKBJGIPKEE)
		{
			if (KDJLPKDBCDA)
			{
				BGEDKGLJIGM = SelectionState.Highlighted;
			}
			else if (BGEDKGLJIGM == SelectionState.Pressed)
			{
				KDJLPKDBCDA = true;
			}
			base.DoStateTransition(BGEDKGLJIGM, ALKBJGIPKEE);
		}

		public void SetGlobalPointSize(float EKNOFGHHCPJ)
		{
			TMP_Text tMP_Text = m_Placeholder as TMP_Text;
			if (tMP_Text != null)
			{
				tMP_Text.DGLOHLPKABM = EKNOFGHHCPJ;
			}
			MHFABDJOCMG.DGLOHLPKABM = EKNOFGHHCPJ;
		}

		public void SetGlobalFontAsset(TMP_FontAsset PIJNMJOHBIE)
		{
			TMP_Text tMP_Text = m_Placeholder as TMP_Text;
			if (tMP_Text != null)
			{
				tMP_Text.ELKNHALJKNI = PIJNMJOHBIE;
			}
			MHFABDJOCMG.ELKNHALJKNI = PIJNMJOHBIE;
		}

		Transform ICanvasElement.get_transform()
		{
			return base.transform;
		}

		bool ICanvasElement.IsDestroyed()
		{
			return IsDestroyed();
		}
	}
}
