using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace TMPro
{
	[ExecuteInEditMode]
	public class InlineGraphicManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class DHBFJDCLIDJ
		{
			internal int CKFJKOFGBOL;

			internal bool AGFNGEFDHLA(TMP_Sprite EJCNAJOHBFI)
			{
				return EJCNAJOHBFI.hashCode == CKFJKOFGBOL;
			}
		}

		[CompilerGenerated]
		private sealed class PHDKIMGFPBL
		{
			internal int EHJNMODJEAN;

			internal bool AGFNGEFDHLA(TMP_Sprite EJCNAJOHBFI)
			{
				return EJCNAJOHBFI.id == EHJNMODJEAN;
			}
		}

		[SerializeField]
		private TMP_SpriteAsset m_spriteAsset;

		[SerializeField]
		[HideInInspector]
		private InlineGraphic m_inlineGraphic;

		[HideInInspector]
		[SerializeField]
		private CanvasRenderer m_inlineGraphicCanvasRenderer;

		private UIVertex[] OJCEMAHMLGL;

		private RectTransform JKKOACFNKJM;

		private TMP_Text LNHMPALLKNK;

		private bool JAIFOMBJBHI;

		public TMP_SpriteAsset GKDEMJDOOLB
		{
			get
			{
				return m_spriteAsset;
			}
			set
			{
				OGDJGEBJGPE(value);
			}
		}

		public InlineGraphic PCLAGGACGLD
		{
			get
			{
				return m_inlineGraphic;
			}
			set
			{
				if (m_inlineGraphic != value)
				{
					m_inlineGraphic = value;
				}
			}
		}

		public CanvasRenderer HBIBDFFPKFG
		{
			get
			{
				return m_inlineGraphicCanvasRenderer;
			}
		}

		public UIVertex[] CMOABLBOGDH
		{
			get
			{
				return OJCEMAHMLGL;
			}
		}

		private void Awake()
		{
			if (!TMP_Settings.warningsDisabled)
			{
				Debug.LogWarning("InlineGraphicManager component is now Obsolete and has been removed from [" + base.gameObject.name + "] along with its InlineGraphic child.", this);
			}
			if (PCLAGGACGLD.gameObject != null)
			{
				UnityEngine.Object.DestroyImmediate(PCLAGGACGLD.gameObject);
				PCLAGGACGLD = null;
			}
			UnityEngine.Object.DestroyImmediate(this);
		}

		private void OnEnable()
		{
			base.enabled = false;
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void OGDJGEBJGPE(TMP_SpriteAsset GKDEMJDOOLB)
		{
			if (GKDEMJDOOLB == null)
			{
				GKDEMJDOOLB = ((!(TMP_Settings.defaultSpriteAsset != null)) ? (Resources.Load("Sprite Assets/Default Sprite Asset") as TMP_SpriteAsset) : TMP_Settings.defaultSpriteAsset);
			}
			m_spriteAsset = GKDEMJDOOLB;
			m_inlineGraphic.texture = m_spriteAsset.spriteSheet;
			if (LNHMPALLKNK != null && JAIFOMBJBHI)
			{
				LNHMPALLKNK.KEJHLJNMEAH = true;
				LNHMPALLKNK.SetVerticesDirty();
			}
		}

		public void AddInlineGraphicsChild()
		{
			if (!(m_inlineGraphic != null))
			{
				GameObject gameObject = new GameObject("Inline Graphic");
				m_inlineGraphic = gameObject.AddComponent<InlineGraphic>();
				JKKOACFNKJM = gameObject.GetComponent<RectTransform>();
				m_inlineGraphicCanvasRenderer = gameObject.GetComponent<CanvasRenderer>();
				JKKOACFNKJM.SetParent(base.transform, false);
				JKKOACFNKJM.localPosition = Vector3.zero;
				JKKOACFNKJM.anchoredPosition3D = Vector3.zero;
				JKKOACFNKJM.sizeDelta = Vector2.zero;
				JKKOACFNKJM.anchorMin = Vector2.zero;
				JKKOACFNKJM.anchorMax = Vector2.one;
				LNHMPALLKNK = GetComponent<TMP_Text>();
			}
		}

		public void AllocatedVertexBuffers(int MOFHAKELNPN)
		{
			if (m_inlineGraphic == null)
			{
				AddInlineGraphicsChild();
				OGDJGEBJGPE(m_spriteAsset);
			}
			if (OJCEMAHMLGL == null)
			{
				OJCEMAHMLGL = new UIVertex[4];
			}
			int num = MOFHAKELNPN * 4;
			if (num > OJCEMAHMLGL.Length)
			{
				OJCEMAHMLGL = new UIVertex[Mathf.NextPowerOfTwo(num)];
			}
		}

		public void UpdatePivot(Vector2 IIFBHCMJEKK)
		{
			if (JKKOACFNKJM == null)
			{
				JKKOACFNKJM = m_inlineGraphic.GetComponent<RectTransform>();
			}
			JKKOACFNKJM.pivot = IIFBHCMJEKK;
		}

		public void ClearUIVertex()
		{
			if (CMOABLBOGDH != null && CMOABLBOGDH.Length > 0)
			{
				Array.Clear(CMOABLBOGDH, 0, CMOABLBOGDH.Length);
				m_inlineGraphicCanvasRenderer.Clear();
			}
		}

		public void DrawSprite(UIVertex[] NAEGKAOIIHH, int KBKDHENMPDN)
		{
			if (m_inlineGraphicCanvasRenderer == null)
			{
				m_inlineGraphicCanvasRenderer = m_inlineGraphic.GetComponent<CanvasRenderer>();
			}
			m_inlineGraphicCanvasRenderer.SetVertices(NAEGKAOIIHH, KBKDHENMPDN * 4);
			m_inlineGraphic.UpdateMaterial();
		}

		public TMP_Sprite GetSprite(int EHJNMODJEAN)
		{
			if (m_spriteAsset == null)
			{
				Debug.LogWarning("No Sprite Asset is assigned.", this);
				return null;
			}
			if (m_spriteAsset.spriteInfoList == null || EHJNMODJEAN > m_spriteAsset.spriteInfoList.Count - 1)
			{
				Debug.LogWarning("Sprite index exceeds the number of sprites in this Sprite Asset.", this);
				return null;
			}
			return m_spriteAsset.spriteInfoList[EHJNMODJEAN];
		}

		public int GetSpriteIndexByHashCode(int CKFJKOFGBOL)
		{
			if (m_spriteAsset == null || m_spriteAsset.spriteInfoList == null)
			{
				Debug.LogWarning("No Sprite Asset is assigned.", this);
				return -1;
			}
			return m_spriteAsset.spriteInfoList.FindIndex((TMP_Sprite EJCNAJOHBFI) => EJCNAJOHBFI.hashCode == CKFJKOFGBOL);
		}

		public int GetSpriteIndexByIndex(int EHJNMODJEAN)
		{
			if (m_spriteAsset == null || m_spriteAsset.spriteInfoList == null)
			{
				Debug.LogWarning("No Sprite Asset is assigned.", this);
				return -1;
			}
			return m_spriteAsset.spriteInfoList.FindIndex((TMP_Sprite EJCNAJOHBFI) => EJCNAJOHBFI.id == EHJNMODJEAN);
		}

		public void SetUIVertex(UIVertex[] CMOABLBOGDH)
		{
			OJCEMAHMLGL = CMOABLBOGDH;
		}
	}
}
