using UnityEngine;
using UnityEngine.EventSystems;

namespace TMPro
{
	[AddComponentMenu("Layout/Text Container")]
	[RequireComponent(typeof(RectTransform))]
	[ExecuteInEditMode]
	public class TextContainer : UIBehaviour
	{
		private bool EMBHHOAHDBD;

		[SerializeField]
		private Vector2 m_pivot;

		[SerializeField]
		private AEHICDJKLLJ m_anchorPosition = AEHICDJKLLJ.Middle;

		[SerializeField]
		private Rect m_rect;

		private bool IBHIHPCJJCN;

		private bool KOOBILJDAJJ;

		private bool GKCFHKCKPIJ;

		private Vector3[] KEFBGDMKHLK = new Vector3[4];

		private Vector3[] AFLKAFNKKMG = new Vector3[4];

		[SerializeField]
		private Vector4 m_margins;

		private RectTransform HBKNOEILBLE;

		private static Vector2 OHEHFAHENCA = new Vector2(100f, 100f);

		private TextMeshPro CJMPLGHHHPI;

		public bool BFLFDOEJOEO
		{
			get
			{
				return EMBHHOAHDBD;
			}
			set
			{
				EMBHHOAHDBD = value;
			}
		}

		public Vector2 IIFBHCMJEKK
		{
			get
			{
				return m_pivot;
			}
			set
			{
				if (m_pivot != value)
				{
					m_pivot = value;
					m_anchorPosition = CAPHLBLNDAF(m_pivot);
					EMBHHOAHDBD = true;
					DEJGICLGEHB();
				}
			}
		}

		public AEHICDJKLLJ HJJGBCINHDL
		{
			get
			{
				return m_anchorPosition;
			}
			set
			{
				if (m_anchorPosition != value)
				{
					m_anchorPosition = value;
					m_pivot = FKKCNPJMBLJ(m_anchorPosition);
					EMBHHOAHDBD = true;
					DEJGICLGEHB();
				}
			}
		}

		public Rect JIBDHLJBMPG
		{
			get
			{
				return m_rect;
			}
			set
			{
				if (m_rect != value)
				{
					m_rect = value;
					EMBHHOAHDBD = true;
					DEJGICLGEHB();
				}
			}
		}

		public Vector2 MOFHAKELNPN
		{
			get
			{
				return new Vector2(m_rect.width, m_rect.height);
			}
			set
			{
				if (new Vector2(m_rect.width, m_rect.height) != value)
				{
					OFGCFAJAMDA(value);
					EMBHHOAHDBD = true;
					IBHIHPCJJCN = false;
					KOOBILJDAJJ = false;
					DEJGICLGEHB();
				}
			}
		}

		public float HHHMOGOKFHF
		{
			get
			{
				return m_rect.width;
			}
			set
			{
				OFGCFAJAMDA(new Vector2(value, m_rect.height));
				EMBHHOAHDBD = true;
				IBHIHPCJJCN = false;
				DEJGICLGEHB();
			}
		}

		public float JKNPBEOPMPK
		{
			get
			{
				return m_rect.height;
			}
			set
			{
				OFGCFAJAMDA(new Vector2(m_rect.width, value));
				EMBHHOAHDBD = true;
				KOOBILJDAJJ = false;
				DEJGICLGEHB();
			}
		}

		public bool CPCONJFDPAA
		{
			get
			{
				return IBHIHPCJJCN;
			}
		}

		public bool KBLMIMBHKBG
		{
			get
			{
				return KOOBILJDAJJ;
			}
		}

		public bool FADDCENIEPG
		{
			get
			{
				return GKCFHKCKPIJ;
			}
			set
			{
				GKCFHKCKPIJ = value;
			}
		}

		public Vector3[] AKKPOPGIPIL
		{
			get
			{
				return KEFBGDMKHLK;
			}
		}

		public Vector3[] KGEFFGOFILL
		{
			get
			{
				return AFLKAFNKKMG;
			}
		}

		public Vector4 IKLONGIIAKK
		{
			get
			{
				return m_margins;
			}
			set
			{
				if (m_margins != value)
				{
					m_margins = value;
					EMBHHOAHDBD = true;
					DEJGICLGEHB();
				}
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

		public TextMeshPro EBKNMAPNPFA
		{
			get
			{
				if (CJMPLGHHHPI == null)
				{
					CJMPLGHHHPI = GetComponent<TextMeshPro>();
				}
				return CJMPLGHHHPI;
			}
		}

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
			DEJGICLGEHB();
		}

		protected override void OnDisable()
		{
		}

		private void DEJGICLGEHB()
		{
			DCJJOKDIEKF();
			if (HBKNOEILBLE != null)
			{
				HBKNOEILBLE.sizeDelta = MOFHAKELNPN;
				HBKNOEILBLE.hasChanged = true;
			}
			if (EBKNMAPNPFA != null)
			{
				CJMPLGHHHPI.SetVerticesDirty();
				CJMPLGHHHPI.PNACILIBDDF = m_margins;
			}
		}

		protected override void OnRectTransformDimensionsChange()
		{
			if (GPPKOGCLKPL == null)
			{
				HBKNOEILBLE = base.gameObject.AddComponent<RectTransform>();
			}
			if (HBKNOEILBLE.sizeDelta != OHEHFAHENCA)
			{
				MOFHAKELNPN = HBKNOEILBLE.sizeDelta;
			}
			IIFBHCMJEKK = HBKNOEILBLE.pivot;
			EMBHHOAHDBD = true;
			DEJGICLGEHB();
		}

		private void OFGCFAJAMDA(Vector2 MOFHAKELNPN)
		{
			m_rect = new Rect(m_rect.x, m_rect.y, MOFHAKELNPN.x, MOFHAKELNPN.y);
		}

		private void DCJJOKDIEKF()
		{
			KEFBGDMKHLK[0] = new Vector3((0f - m_pivot.x) * m_rect.width, (0f - m_pivot.y) * m_rect.height);
			KEFBGDMKHLK[1] = new Vector3((0f - m_pivot.x) * m_rect.width, (1f - m_pivot.y) * m_rect.height);
			KEFBGDMKHLK[2] = new Vector3((1f - m_pivot.x) * m_rect.width, (1f - m_pivot.y) * m_rect.height);
			KEFBGDMKHLK[3] = new Vector3((1f - m_pivot.x) * m_rect.width, (0f - m_pivot.y) * m_rect.height);
			if (HBKNOEILBLE != null)
			{
				HBKNOEILBLE.pivot = m_pivot;
			}
		}

		private Vector2 FKKCNPJMBLJ(AEHICDJKLLJ EGCACJAPKKB)
		{
			Vector2 result = Vector2.zero;
			switch (EGCACJAPKKB)
			{
			case AEHICDJKLLJ.TopLeft:
				result = new Vector2(0f, 1f);
				break;
			case AEHICDJKLLJ.Top:
				result = new Vector2(0.5f, 1f);
				break;
			case AEHICDJKLLJ.TopRight:
				result = new Vector2(1f, 1f);
				break;
			case AEHICDJKLLJ.Left:
				result = new Vector2(0f, 0.5f);
				break;
			case AEHICDJKLLJ.Middle:
				result = new Vector2(0.5f, 0.5f);
				break;
			case AEHICDJKLLJ.Right:
				result = new Vector2(1f, 0.5f);
				break;
			case AEHICDJKLLJ.BottomLeft:
				result = new Vector2(0f, 0f);
				break;
			case AEHICDJKLLJ.Bottom:
				result = new Vector2(0.5f, 0f);
				break;
			case AEHICDJKLLJ.BottomRight:
				result = new Vector2(1f, 0f);
				break;
			}
			return result;
		}

		private AEHICDJKLLJ CAPHLBLNDAF(Vector2 IIFBHCMJEKK)
		{
			if (IIFBHCMJEKK == new Vector2(0f, 1f))
			{
				return AEHICDJKLLJ.TopLeft;
			}
			if (IIFBHCMJEKK == new Vector2(0.5f, 1f))
			{
				return AEHICDJKLLJ.Top;
			}
			if (IIFBHCMJEKK == new Vector2(1f, 1f))
			{
				return AEHICDJKLLJ.TopRight;
			}
			if (IIFBHCMJEKK == new Vector2(0f, 0.5f))
			{
				return AEHICDJKLLJ.Left;
			}
			if (IIFBHCMJEKK == new Vector2(0.5f, 0.5f))
			{
				return AEHICDJKLLJ.Middle;
			}
			if (IIFBHCMJEKK == new Vector2(1f, 0.5f))
			{
				return AEHICDJKLLJ.Right;
			}
			if (IIFBHCMJEKK == new Vector2(0f, 0f))
			{
				return AEHICDJKLLJ.BottomLeft;
			}
			if (IIFBHCMJEKK == new Vector2(0.5f, 0f))
			{
				return AEHICDJKLLJ.Bottom;
			}
			if (IIFBHCMJEKK == new Vector2(1f, 0f))
			{
				return AEHICDJKLLJ.BottomRight;
			}
			return AEHICDJKLLJ.Custom;
		}
	}
}
