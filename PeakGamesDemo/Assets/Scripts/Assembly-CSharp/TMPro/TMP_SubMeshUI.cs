using System;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	[ExecuteInEditMode]
	public class TMP_SubMeshUI : MaskableGraphic, IClippable, IMaskable, IMaterialModifier
	{
		[SerializeField]
		private TMP_FontAsset m_fontAsset;

		[SerializeField]
		private TMP_SpriteAsset m_spriteAsset;

		[SerializeField]
		private Material m_material;

		[SerializeField]
		private Material m_sharedMaterial;

		private Material INOFONFKEGA;

		private Material DABEIGLBAMG;

		[SerializeField]
		private bool m_isDefaultMaterial;

		[SerializeField]
		private float m_padding;

		[SerializeField]
		private CanvasRenderer m_canvasRenderer;

		private Mesh OPMBPPBMINF;

		[SerializeField]
		private TextMeshProUGUI m_TextComponent;

		[NonSerialized]
		private bool FLPABJOEKCL;

		private bool BHFBIPNJNPG;

		[SerializeField]
		private int m_materialReferenceIndex;

		public TMP_FontAsset PIJNMJOHBIE
		{
			get
			{
				return m_fontAsset;
			}
			set
			{
				m_fontAsset = value;
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
			}
		}

		public override Texture CJNCIEDBHNM
		{
			get
			{
				if (OOMNMKHLJIC != null)
				{
					return OOMNMKHLJIC.GetTexture(MOHPNOBPBBL.GKMMOOGJLHP);
				}
				return null;
			}
		}

		public override Material GHPFOPNNJOB
		{
			get
			{
				return JNMHGFLJDKP(m_sharedMaterial);
			}
			set
			{
				if (!(m_sharedMaterial != null) || m_sharedMaterial.GetInstanceID() != value.GetInstanceID())
				{
					m_sharedMaterial = (m_material = value);
					m_padding = GetPaddingForMaterial();
					SetVerticesDirty();
					SetMaterialDirty();
				}
			}
		}

		public Material OOMNMKHLJIC
		{
			get
			{
				return m_sharedMaterial;
			}
			set
			{
				LFCEIGAFPID(value);
			}
		}

		public Material PDKNCECBLAJ
		{
			get
			{
				return INOFONFKEGA;
			}
			set
			{
				if (!(INOFONFKEGA == value))
				{
					if (INOFONFKEGA != null && INOFONFKEGA != value)
					{
						HPENNIOPLFI.KLMFHLDMKJF(INOFONFKEGA);
					}
					INOFONFKEGA = value;
					HPENNIOPLFI.FOCNKHFDMIM(INOFONFKEGA);
					LFCEIGAFPID(INOFONFKEGA);
				}
			}
		}

		public Material MHMODIMFCIN
		{
			get
			{
				return DABEIGLBAMG;
			}
			set
			{
				DABEIGLBAMG = value;
			}
		}

		public override Material GPENEGIIOAC
		{
			get
			{
				if (m_sharedMaterial == null)
				{
					return null;
				}
				return GetModifiedMaterial(m_sharedMaterial);
			}
		}

		public bool PDLHEANIELH
		{
			get
			{
				return m_isDefaultMaterial;
			}
			set
			{
				m_isDefaultMaterial = value;
			}
		}

		public float HFHKPBBFDFD
		{
			get
			{
				return m_padding;
			}
			set
			{
				m_padding = value;
			}
		}

		public CanvasRenderer HBIBDFFPKFG
		{
			get
			{
				if (m_canvasRenderer == null)
				{
					m_canvasRenderer = GetComponent<CanvasRenderer>();
				}
				return m_canvasRenderer;
			}
		}

		public Mesh IJKCGGPJDIG
		{
			get
			{
				if (OPMBPPBMINF == null)
				{
					OPMBPPBMINF = new Mesh();
					OPMBPPBMINF.hideFlags = HideFlags.HideAndDontSave;
				}
				return OPMBPPBMINF;
			}
			set
			{
				OPMBPPBMINF = value;
			}
		}

		public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI MHFABDJOCMG, FMOBJPAGLEE EBEMFPNHKMN)
		{
			GameObject gameObject = new GameObject("TMP UI SubObject [" + EBEMFPNHKMN.GHPFOPNNJOB.name + "]", typeof(RectTransform));
			gameObject.transform.SetParent(MHFABDJOCMG.ANLKLKAINEO, false);
			gameObject.layer = MHFABDJOCMG.gameObject.layer;
			RectTransform component = gameObject.GetComponent<RectTransform>();
			component.anchorMin = Vector2.zero;
			component.anchorMax = Vector2.one;
			component.sizeDelta = Vector2.zero;
			component.pivot = MHFABDJOCMG.GPPKOGCLKPL.pivot;
			TMP_SubMeshUI tMP_SubMeshUI = gameObject.AddComponent<TMP_SubMeshUI>();
			tMP_SubMeshUI.m_canvasRenderer = tMP_SubMeshUI.HBIBDFFPKFG;
			tMP_SubMeshUI.m_TextComponent = MHFABDJOCMG;
			tMP_SubMeshUI.m_materialReferenceIndex = EBEMFPNHKMN.EHJNMODJEAN;
			tMP_SubMeshUI.m_fontAsset = EBEMFPNHKMN.PIJNMJOHBIE;
			tMP_SubMeshUI.m_spriteAsset = EBEMFPNHKMN.GKDEMJDOOLB;
			tMP_SubMeshUI.m_isDefaultMaterial = EBEMFPNHKMN.PDLHEANIELH;
			tMP_SubMeshUI.LFCEIGAFPID(EBEMFPNHKMN.GHPFOPNNJOB);
			return tMP_SubMeshUI;
		}

		protected override void OnEnable()
		{
			if (!FLPABJOEKCL)
			{
				FLPABJOEKCL = true;
			}
			m_ShouldRecalculateStencil = true;
			RecalculateClipping();
			RecalculateMasking();
		}

		protected override void OnDisable()
		{
			ANOADDOEKMH.NJILFNJMDJF(this);
			if (m_MaskMaterial != null)
			{
				HPENNIOPLFI.PEENDKMJMPN(m_MaskMaterial);
				m_MaskMaterial = null;
			}
			if (INOFONFKEGA != null)
			{
				HPENNIOPLFI.KLMFHLDMKJF(INOFONFKEGA);
				INOFONFKEGA = null;
			}
			base.OnDisable();
		}

		protected override void OnDestroy()
		{
			if (OPMBPPBMINF != null)
			{
				UnityEngine.Object.DestroyImmediate(OPMBPPBMINF);
			}
			if (m_MaskMaterial != null)
			{
				HPENNIOPLFI.PEENDKMJMPN(m_MaskMaterial);
			}
			if (INOFONFKEGA != null)
			{
				HPENNIOPLFI.KLMFHLDMKJF(INOFONFKEGA);
				INOFONFKEGA = null;
			}
			FLPABJOEKCL = false;
			RecalculateClipping();
		}

		protected override void OnTransformParentChanged()
		{
			if (IsActive())
			{
				m_ShouldRecalculateStencil = true;
				RecalculateClipping();
				RecalculateMasking();
			}
		}

		public override Material GetModifiedMaterial(Material NGHPJNNBAHP)
		{
			Material material = NGHPJNNBAHP;
			if (m_ShouldRecalculateStencil)
			{
				m_StencilValue = HPENNIOPLFI.IOMBBOBLCMK(base.gameObject);
				m_ShouldRecalculateStencil = false;
			}
			if (m_StencilValue > 0)
			{
				material = HPENNIOPLFI.HJNELAFHOND(NGHPJNNBAHP, m_StencilValue);
				if (m_MaskMaterial != null)
				{
					HPENNIOPLFI.PEENDKMJMPN(m_MaskMaterial);
				}
				m_MaskMaterial = material;
			}
			return material;
		}

		public float GetPaddingForMaterial()
		{
			return MOHPNOBPBBL.JHMPKCIPPMF(m_sharedMaterial, m_TextComponent.AJLGMMOGEOC, m_TextComponent.HBBBBINCPHE);
		}

		public float GetPaddingForMaterial(Material GJDEEBDFEFM)
		{
			return MOHPNOBPBBL.JHMPKCIPPMF(GJDEEBDFEFM, m_TextComponent.AJLGMMOGEOC, m_TextComponent.HBBBBINCPHE);
		}

		public void UpdateMeshPadding(bool KCLKLHLOBBG, bool HBBBBINCPHE)
		{
			m_padding = MOHPNOBPBBL.JHMPKCIPPMF(m_sharedMaterial, KCLKLHLOBBG, HBBBBINCPHE);
		}

		public override void SetAllDirty()
		{
		}

		public override void SetVerticesDirty()
		{
			if (IsActive() && m_TextComponent != null)
			{
				m_TextComponent.KEJHLJNMEAH = true;
				m_TextComponent.SetVerticesDirty();
			}
		}

		public override void SetLayoutDirty()
		{
		}

		public override void SetMaterialDirty()
		{
			BHFBIPNJNPG = true;
			UpdateMaterial();
		}

		public void SetPivotDirty()
		{
			if (IsActive())
			{
				base.rectTransform.pivot = m_TextComponent.GPPKOGCLKPL.pivot;
			}
		}

		public override void Cull(Rect BKGOLPGODLE, bool FPNIEBLEOIE)
		{
			if (!m_TextComponent.CIDGHENKBFI)
			{
				base.Cull(BKGOLPGODLE, FPNIEBLEOIE);
			}
		}

		protected override void UpdateGeometry()
		{
			Debug.Log("UpdateGeometry()");
		}

		public override void Rebuild(CanvasUpdate LMJFIOAJCGK)
		{
			if (LMJFIOAJCGK == CanvasUpdate.PreRender && BHFBIPNJNPG)
			{
				UpdateMaterial();
				BHFBIPNJNPG = false;
			}
		}

		public void RefreshMaterial()
		{
			UpdateMaterial();
		}

		protected override void UpdateMaterial()
		{
			if (m_canvasRenderer == null)
			{
				m_canvasRenderer = HBIBDFFPKFG;
			}
			m_canvasRenderer.materialCount = 1;
			m_canvasRenderer.SetMaterial(materialForRendering, 0);
			m_canvasRenderer.SetTexture(mainTexture);
		}

		public override void RecalculateClipping()
		{
			base.RecalculateClipping();
		}

		public override void RecalculateMasking()
		{
			m_ShouldRecalculateStencil = true;
			SetMaterialDirty();
		}

		private Material JNMHGFLJDKP()
		{
			return m_sharedMaterial;
		}

		private Material JNMHGFLJDKP(Material GJDEEBDFEFM)
		{
			if (m_material == null || m_material.GetInstanceID() != GJDEEBDFEFM.GetInstanceID())
			{
				m_material = IEDEFFAONFN(GJDEEBDFEFM);
			}
			m_sharedMaterial = m_material;
			m_padding = GetPaddingForMaterial();
			SetVerticesDirty();
			SetMaterialDirty();
			return m_sharedMaterial;
		}

		private Material IEDEFFAONFN(Material JKHLMLIANAI)
		{
			Material material = new Material(JKHLMLIANAI);
			material.shaderKeywords = JKHLMLIANAI.shaderKeywords;
			material.name += " (Instance)";
			return material;
		}

		private Material BDMLHMFAAJO()
		{
			if (m_canvasRenderer == null)
			{
				m_canvasRenderer = GetComponent<CanvasRenderer>();
			}
			return m_canvasRenderer.GetMaterial();
		}

		private void LFCEIGAFPID(Material GJDEEBDFEFM)
		{
			m_sharedMaterial = GJDEEBDFEFM;
			m_Material = m_sharedMaterial;
			m_padding = GetPaddingForMaterial();
			SetMaterialDirty();
		}
	}
}
