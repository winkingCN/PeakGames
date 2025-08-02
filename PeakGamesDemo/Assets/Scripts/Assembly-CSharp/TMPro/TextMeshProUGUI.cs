using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	[RequireComponent(typeof(CanvasRenderer))]
	[AddComponentMenu("UI/TextMeshPro - Text (UI)", 11)]
	[RequireComponent(typeof(RectTransform))]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	public class TextMeshProUGUI : TMP_Text, ILayoutElement
	{
		private bool MMCPDFHGCGC;

		[SerializeField]
		private bool m_hasFontAssetChanged;

		[SerializeField]
		protected TMP_SubMeshUI[] m_subTextObjects = new TMP_SubMeshUI[8];

		private float JFGEKNMANOJ = -1f;

		private Vector3[] LJPBNPONJJJ = new Vector3[4];

		private CanvasRenderer JMJNGBJNGGC;

		private Canvas CNEODGLFFPG;

		private bool KCNOKPCMJBI;

		private int BDEKJLMKCGK = 8;

		private bool HFGCJAKMLKE;

		[SerializeField]
		private Material m_baseMaterial;

		private bool HOMPOFMCAKO;

		private int AKADFCPFFOA;

		[SerializeField]
		private Vector4 m_maskOffset;

		private Matrix4x4 MKNFDFEKKHG = default(Matrix4x4);

		[NonSerialized]
		private bool FLPABJOEKCL;

		private int LMJBDAJJLNG;

		private int JEFPIONIJFI;

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

		public override bool OFBCJEKCLMH
		{
			get
			{
				return PCIEPCLHNLM;
			}
			set
			{
				if (PCIEPCLHNLM != value)
				{
					PCIEPCLHNLM = value;
					if (PCIEPCLHNLM)
					{
						CanvasUpdateRegistry.RegisterCanvasElementForLayoutRebuild(this);
						SetLayoutDirty();
					}
				}
			}
		}

		public override Mesh IJKCGGPJDIG
		{
			get
			{
				return OPMBPPBMINF;
			}
		}

		public CanvasRenderer HBIBDFFPKFG
		{
			get
			{
				if (JMJNGBJNGGC == null)
				{
					JMJNGBJNGGC = GetComponent<CanvasRenderer>();
				}
				return JMJNGBJNGGC;
			}
		}

		public InlineGraphicManager NJFOCMCLNOM
		{
			get
			{
				return ALIGHMAKHKH;
			}
		}

		public Vector4 FDIJGDMMIMK
		{
			get
			{
				return m_maskOffset;
			}
			set
			{
				m_maskOffset = value;
				MJODJGEIKDL();
				m_havePropertiesChanged = true;
			}
		}

		public void CalculateLayoutInputHorizontal()
		{
			if (base.gameObject.activeInHierarchy && (DHOELNIONFE || HBKNOEILBLE.hasChanged))
			{
				HEJJGBFEPCM = HNKGNKGIBOB();
				EMKNNKLEEPI();
				GHPJHKPEOIK = true;
			}
		}

		public void CalculateLayoutInputVertical()
		{
			if (base.gameObject.activeInHierarchy)
			{
				if (DHOELNIONFE || HBKNOEILBLE.hasChanged)
				{
					EHHDCBAEJDG = PMDDOMPJDPA();
					EMKNNKLEEPI();
					GHPJHKPEOIK = true;
				}
				DHOELNIONFE = false;
			}
		}

		public override void SetVerticesDirty()
		{
			if (!DDIENOMJOHI && !(this == null) && IsActive() && !CanvasUpdateRegistry.IsRebuildingGraphics())
			{
				DDIENOMJOHI = true;
				CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild(this);
			}
		}

		public override void SetLayoutDirty()
		{
			IKDPKCPAGOC = true;
			KJFOCCKAAGA = true;
			if (!ONLMDAHAAID && !(this == null) && IsActive())
			{
				ONLMDAHAAID = true;
				LayoutRebuilder.MarkLayoutForRebuild(base.GPPKOGCLKPL);
				GHPJHKPEOIK = true;
			}
		}

		public override void SetMaterialDirty()
		{
			if (!(this == null) && IsActive() && !CanvasUpdateRegistry.IsRebuildingGraphics())
			{
				BMPKBAOBLDH = true;
				CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild(this);
			}
		}

		public override void SetAllDirty()
		{
			SetLayoutDirty();
			SetVerticesDirty();
			SetMaterialDirty();
		}

		public override void Rebuild(CanvasUpdate LMJFIOAJCGK)
		{
			if (this == null)
			{
				return;
			}
			switch (LMJFIOAJCGK)
			{
			case CanvasUpdate.Prelayout:
				if (PCIEPCLHNLM)
				{
					HBKNOEILBLE.sizeDelta = GetPreferredValues(float.PositiveInfinity, float.PositiveInfinity);
				}
				break;
			case CanvasUpdate.PreRender:
				LHMMLLDIHMN();
				DDIENOMJOHI = false;
				ONLMDAHAAID = false;
				if (BMPKBAOBLDH)
				{
					UpdateMaterial();
					BMPKBAOBLDH = false;
				}
				break;
			}
		}

		private void MJDJBNBHHKD()
		{
			if (m_textInfo != null)
			{
				for (int i = 1; i < m_subTextObjects.Length && m_subTextObjects[i] != null; i++)
				{
					m_subTextObjects[i].SetPivotDirty();
				}
			}
		}

		public override Material GetModifiedMaterial(Material NGHPJNNBAHP)
		{
			Material material = NGHPJNNBAHP;
			if (m_ShouldRecalculateStencil)
			{
				AKADFCPFFOA = HPENNIOPLFI.IOMBBOBLCMK(base.gameObject);
				m_ShouldRecalculateStencil = false;
			}
			if (AKADFCPFFOA > 0)
			{
				material = HPENNIOPLFI.HJNELAFHOND(NGHPJNNBAHP, AKADFCPFFOA);
				if (m_MaskMaterial != null)
				{
					HPENNIOPLFI.PEENDKMJMPN(m_MaskMaterial);
				}
				m_MaskMaterial = material;
			}
			return material;
		}

		protected override void UpdateMaterial()
		{
			if (!(m_sharedMaterial == null))
			{
				if (JMJNGBJNGGC == null)
				{
					JMJNGBJNGGC = HBIBDFFPKFG;
				}
				JMJNGBJNGGC.materialCount = 1;
				JMJNGBJNGGC.SetMaterial(materialForRendering, m_sharedMaterial.GetTexture(MOHPNOBPBBL.GKMMOOGJLHP));
			}
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

		public override void Cull(Rect BKGOLPGODLE, bool FPNIEBLEOIE)
		{
			if (!m_ignoreRectMaskCulling)
			{
				base.Cull(BKGOLPGODLE, FPNIEBLEOIE);
			}
		}

		public override void UpdateMeshPadding()
		{
			IBKCGEGKGNM = MOHPNOBPBBL.JHMPKCIPPMF(m_sharedMaterial, m_enableExtraPadding, JLDKHEKHGKA);
			HFGCJAKMLKE = MOHPNOBPBBL.DIGKAOJFBDJ(m_sharedMaterial);
			m_havePropertiesChanged = true;
			checkPaddingRequired = false;
			if (m_textInfo != null)
			{
				for (int i = 1; i < m_textInfo.materialCount; i++)
				{
					m_subTextObjects[i].UpdateMeshPadding(m_enableExtraPadding, JLDKHEKHGKA);
				}
			}
		}

		protected override void MMOFEGKNHEF(Color ICEFPJCHGBJ, float FMPBJJMKCIG, bool AFCNLNOBLKK, bool JNMJBPPJFMJ)
		{
			int materialCount = m_textInfo.materialCount;
			for (int i = 1; i < materialCount; i++)
			{
				m_subTextObjects[i].CrossFadeColor(ICEFPJCHGBJ, FMPBJJMKCIG, AFCNLNOBLKK, JNMJBPPJFMJ);
			}
		}

		protected override void PGLHDCOKDNJ(float KBKMPEOMABI, float FMPBJJMKCIG, bool AFCNLNOBLKK)
		{
			int materialCount = m_textInfo.materialCount;
			for (int i = 1; i < materialCount; i++)
			{
				m_subTextObjects[i].CrossFadeAlpha(KBKMPEOMABI, FMPBJJMKCIG, AFCNLNOBLKK);
			}
		}

		public override void ForceMeshUpdate()
		{
			m_havePropertiesChanged = true;
			LHMMLLDIHMN();
		}

		public override void ForceMeshUpdate(bool CGJGPMGBABG)
		{
			m_havePropertiesChanged = true;
			FOMLPKEMFLJ = true;
			LHMMLLDIHMN();
		}

		public override TMP_TextInfo GetTextInfo(string FCJBBPHFNPJ)
		{
			PDENOOPDPEN(FCJBBPHFNPJ, ref GMALEIECAPN);
			JAADOMGCOHA(GMALEIECAPN);
			LNKILMNOLPD = HJNAPNHAJCI.DontRender;
			EMKNNKLEEPI();
			if (CNEODGLFFPG == null)
			{
				CNEODGLFFPG = base.canvas;
			}
			DLIBNLFHMKF();
			LNKILMNOLPD = HJNAPNHAJCI.Render;
			return base.BIAHJAKEMLM;
		}

		public override void ClearMesh()
		{
			JMJNGBJNGGC.SetMesh(null);
			for (int i = 1; i < m_subTextObjects.Length && m_subTextObjects[i] != null; i++)
			{
				m_subTextObjects[i].HBIBDFFPKFG.SetMesh(null);
			}
		}

		public override void UpdateGeometry(Mesh IJKCGGPJDIG, int EHJNMODJEAN)
		{
			IJKCGGPJDIG.RecalculateBounds();
			if (EHJNMODJEAN == 0)
			{
				JMJNGBJNGGC.SetMesh(IJKCGGPJDIG);
			}
			else
			{
				m_subTextObjects[EHJNMODJEAN].HBIBDFFPKFG.SetMesh(IJKCGGPJDIG);
			}
		}

		public override void UpdateVertexData(ELPAMMNJADG KCHENLJCHHH)
		{
			int materialCount = m_textInfo.materialCount;
			for (int i = 0; i < materialCount; i++)
			{
				Mesh mesh = ((i != 0) ? m_subTextObjects[i].IJKCGGPJDIG : OPMBPPBMINF);
				if ((KCHENLJCHHH & ELPAMMNJADG.Vertices) == ELPAMMNJADG.Vertices)
				{
					mesh.vertices = m_textInfo.meshInfo[i].FHBFCAEGPOH;
				}
				if ((KCHENLJCHHH & ELPAMMNJADG.Uv0) == ELPAMMNJADG.Uv0)
				{
					mesh.uv = m_textInfo.meshInfo[i].LFAFOAOKPKA;
				}
				if ((KCHENLJCHHH & ELPAMMNJADG.Uv2) == ELPAMMNJADG.Uv2)
				{
					mesh.uv2 = m_textInfo.meshInfo[i].FJPNPHPFBFJ;
				}
				if ((KCHENLJCHHH & ELPAMMNJADG.Colors32) == ELPAMMNJADG.Colors32)
				{
					mesh.colors32 = m_textInfo.meshInfo[i].PMBHKFBDDND;
				}
				mesh.RecalculateBounds();
				if (i == 0)
				{
					JMJNGBJNGGC.SetMesh(mesh);
				}
				else
				{
					m_subTextObjects[i].HBIBDFFPKFG.SetMesh(mesh);
				}
			}
		}

		public override void UpdateVertexData()
		{
			int materialCount = m_textInfo.materialCount;
			for (int i = 0; i < materialCount; i++)
			{
				Mesh mesh;
				if (i == 0)
				{
					mesh = OPMBPPBMINF;
				}
				else
				{
					m_textInfo.meshInfo[i].NGOKLPFCFAO();
					mesh = m_subTextObjects[i].IJKCGGPJDIG;
				}
				mesh.vertices = m_textInfo.meshInfo[i].FHBFCAEGPOH;
				mesh.uv = m_textInfo.meshInfo[i].LFAFOAOKPKA;
				mesh.uv2 = m_textInfo.meshInfo[i].FJPNPHPFBFJ;
				mesh.colors32 = m_textInfo.meshInfo[i].PMBHKFBDDND;
				mesh.RecalculateBounds();
				if (i == 0)
				{
					JMJNGBJNGGC.SetMesh(mesh);
				}
				else
				{
					m_subTextObjects[i].HBIBDFFPKFG.SetMesh(mesh);
				}
			}
		}

		public void UpdateFontAsset()
		{
			HKPPGOIIJJJ();
		}

		protected override void Awake()
		{
			CNEODGLFFPG = base.canvas;
			m_isOrthographic = true;
			HBKNOEILBLE = base.gameObject.GetComponent<RectTransform>();
			if (HBKNOEILBLE == null)
			{
				HBKNOEILBLE = base.gameObject.AddComponent<RectTransform>();
			}
			JMJNGBJNGGC = GetComponent<CanvasRenderer>();
			if (JMJNGBJNGGC == null)
			{
				JMJNGBJNGGC = base.gameObject.AddComponent<CanvasRenderer>();
			}
			if (OPMBPPBMINF == null)
			{
				OPMBPPBMINF = new Mesh();
				OPMBPPBMINF.hideFlags = HideFlags.HideAndDontSave;
			}
			BFCDKEKLEJF();
			HKPPGOIIJJJ();
			TMP_StyleSheet.DBNNEDBOJAG();
			if (GMALEIECAPN == null)
			{
				GMALEIECAPN = new int[BDEKJLMKCGK];
			}
			EOLJHINLKLO = new TMP_Glyph();
			KCNOKPCMJBI = true;
			if (m_textInfo == null)
			{
				m_textInfo = new TMP_TextInfo(this);
			}
			if (m_fontAsset == null)
			{
				Debug.LogWarning("Please assign a Font Asset to this " + base.ANLKLKAINEO.name + " gameobject.", this);
				return;
			}
			TMP_SubMeshUI[] componentsInChildren = GetComponentsInChildren<TMP_SubMeshUI>();
			if (componentsInChildren.Length > 0)
			{
				for (int i = 0; i < componentsInChildren.Length; i++)
				{
					m_subTextObjects[i + 1] = componentsInChildren[i];
				}
			}
			m_isInputParsingRequired = true;
			m_havePropertiesChanged = true;
			DHOELNIONFE = true;
			NHJALNOIJDN = true;
		}

		protected override void OnEnable()
		{
			if (!FLPABJOEKCL)
			{
				FLPABJOEKCL = true;
			}
			CNEODGLFFPG = GCBMKJJLJBC();
			HPDBJNLMBED(true);
			GraphicRegistry.RegisterGraphicForCanvas(CNEODGLFFPG, this);
			EMKNNKLEEPI();
			DDIENOMJOHI = false;
			ONLMDAHAAID = false;
			m_ShouldRecalculateStencil = true;
			m_isInputParsingRequired = true;
			SetAllDirty();
			RecalculateClipping();
		}

		protected override void OnDisable()
		{
			if (m_MaskMaterial != null)
			{
				HPENNIOPLFI.PEENDKMJMPN(m_MaskMaterial);
				m_MaskMaterial = null;
			}
			GraphicRegistry.UnregisterGraphicForCanvas(CNEODGLFFPG, this);
			CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild(this);
			if (JMJNGBJNGGC != null)
			{
				JMJNGBJNGGC.Clear();
			}
			HPDBJNLMBED(false);
			LayoutRebuilder.MarkLayoutForRebuild(HBKNOEILBLE);
			RecalculateClipping();
		}

		protected override void OnDestroy()
		{
			GraphicRegistry.UnregisterGraphicForCanvas(CNEODGLFFPG, this);
			if (OPMBPPBMINF != null)
			{
				UnityEngine.Object.DestroyImmediate(OPMBPPBMINF);
			}
			if (m_MaskMaterial != null)
			{
				HPENNIOPLFI.PEENDKMJMPN(m_MaskMaterial);
				m_MaskMaterial = null;
			}
			FLPABJOEKCL = false;
		}

		protected override void HKPPGOIIJJJ()
		{
			MOHPNOBPBBL.LNNKOOPFJON();
			if (m_fontAsset == null)
			{
				if (TMP_Settings.defaultFontAsset != null)
				{
					m_fontAsset = TMP_Settings.defaultFontAsset;
				}
				else
				{
					m_fontAsset = Resources.Load("Fonts & Materials/LiberationSans SDF", typeof(TMP_FontAsset)) as TMP_FontAsset;
				}
				if (m_fontAsset == null)
				{
					Debug.LogWarning("The LiberationSans SDF Font Asset was not found. There is no Font Asset assigned to " + base.gameObject.name + ".", this);
					return;
				}
				if (m_fontAsset.characterDictionary == null)
				{
					Debug.Log("Dictionary is Null!");
				}
				m_sharedMaterial = m_fontAsset.material;
			}
			else
			{
				if (m_fontAsset.characterDictionary == null)
				{
					m_fontAsset.FNACKHNCKJJ();
				}
				if (m_sharedMaterial == null && m_baseMaterial != null)
				{
					m_sharedMaterial = m_baseMaterial;
					m_baseMaterial = null;
				}
				if (m_sharedMaterial == null || m_sharedMaterial.GetTexture(MOHPNOBPBBL.GKMMOOGJLHP) == null || m_fontAsset.atlas.GetInstanceID() != m_sharedMaterial.GetTexture(MOHPNOBPBBL.GKMMOOGJLHP).GetInstanceID())
				{
					if (m_fontAsset.material == null)
					{
						Debug.LogWarning("The Font Atlas Texture of the Font Asset " + m_fontAsset.name + " assigned to " + base.gameObject.name + " is missing.", this);
					}
					else
					{
						m_sharedMaterial = m_fontAsset.material;
					}
				}
			}
			GCBKMPMCGNO(m_fontAsset);
			IBKCGEGKGNM = LEJDCNIKNBD();
			SetMaterialDirty();
		}

		private Canvas GCBMKJJLJBC()
		{
			Canvas result = null;
			List<Canvas> list = global::MNGOLNKCDBE<Canvas>.GHBGCADFLFB();
			base.gameObject.GetComponentsInParent(false, list);
			if (list.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].isActiveAndEnabled)
					{
						result = list[i];
						break;
					}
				}
			}
			global::MNGOLNKCDBE<Canvas>.PNCNHFLJCIG(list);
			return result;
		}

		private void AFEPHKLPNOH()
		{
			if (m_sharedMaterial.HasProperty(MOHPNOBPBBL.KICKAJACHHB) && !(m_sharedMaterial.GetTexture(MOHPNOBPBBL.KICKAJACHHB) == null))
			{
				Vector3 euler = m_sharedMaterial.GetVector(MOHPNOBPBBL.PCJMCJBEFGE);
				MKNFDFEKKHG = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(euler), Vector3.one);
				m_sharedMaterial.SetMatrix(MOHPNOBPBBL.FOAKOHEDMJH, MKNFDFEKKHG);
			}
		}

		private void OCIPKCHCGMP()
		{
			if (m_fontMaterial == null)
			{
				m_fontMaterial = IEDEFFAONFN(m_sharedMaterial);
				JMJNGBJNGGC.SetMaterial(m_fontMaterial, m_sharedMaterial.GetTexture(MOHPNOBPBBL.GKMMOOGJLHP));
			}
			m_sharedMaterial = m_fontMaterial;
			if (m_sharedMaterial.HasProperty(MOHPNOBPBBL.EFFCKFEGLNH))
			{
				m_sharedMaterial.EnableKeyword(MOHPNOBPBBL.OINGPAFNGAP);
				m_sharedMaterial.DisableKeyword(MOHPNOBPBBL.GGAODFHBIKC);
				m_sharedMaterial.DisableKeyword(MOHPNOBPBBL.CNHIJMOJIDL);
				MJODJGEIKDL();
			}
			HFGCJAKMLKE = true;
		}

		private void AKMDJLHHHHH()
		{
			if (m_fontMaterial != null)
			{
				if (AKADFCPFFOA > 0)
				{
					m_sharedMaterial = m_MaskMaterial;
				}
				JMJNGBJNGGC.SetMaterial(m_sharedMaterial, m_sharedMaterial.GetTexture(MOHPNOBPBBL.GKMMOOGJLHP));
				UnityEngine.Object.DestroyImmediate(m_fontMaterial);
			}
			HFGCJAKMLKE = false;
		}

		private void MJODJGEIKDL()
		{
			if (HBKNOEILBLE != null)
			{
				if (!MOHPNOBPBBL.EMEGLAFPPNC)
				{
					MOHPNOBPBBL.LNNKOOPFJON();
				}
				HOMPOFMCAKO = true;
				float num = Mathf.Min(Mathf.Min(m_margin.x, m_margin.z), m_sharedMaterial.GetFloat(MOHPNOBPBBL.JPMMJDNBAEK));
				float num2 = Mathf.Min(Mathf.Min(m_margin.y, m_margin.w), m_sharedMaterial.GetFloat(MOHPNOBPBBL.EMNEGMNACHG));
				num = ((!(num > 0f)) ? 0f : num);
				num2 = ((!(num2 > 0f)) ? 0f : num2);
				float z = (HBKNOEILBLE.rect.width - Mathf.Max(m_margin.x, 0f) - Mathf.Max(m_margin.z, 0f)) / 2f + num;
				float w = (HBKNOEILBLE.rect.height - Mathf.Max(m_margin.y, 0f) - Mathf.Max(m_margin.w, 0f)) / 2f + num2;
				Vector2 vector = HBKNOEILBLE.localPosition + new Vector3((0.5f - HBKNOEILBLE.pivot.x) * HBKNOEILBLE.rect.width + (Mathf.Max(m_margin.x, 0f) - Mathf.Max(m_margin.z, 0f)) / 2f, (0.5f - HBKNOEILBLE.pivot.y) * HBKNOEILBLE.rect.height + (0f - Mathf.Max(m_margin.y, 0f) + Mathf.Max(m_margin.w, 0f)) / 2f);
				Vector4 value = new Vector4(vector.x, vector.y, z, w);
				m_sharedMaterial.SetVector(MOHPNOBPBBL.EFFCKFEGLNH, value);
			}
		}

		protected override Material JNMHGFLJDKP(Material GJDEEBDFEFM)
		{
			MOHPNOBPBBL.LNNKOOPFJON();
			if (m_fontMaterial == null || m_fontMaterial.GetInstanceID() != GJDEEBDFEFM.GetInstanceID())
			{
				m_fontMaterial = IEDEFFAONFN(GJDEEBDFEFM);
			}
			m_sharedMaterial = m_fontMaterial;
			IBKCGEGKGNM = LEJDCNIKNBD();
			m_ShouldRecalculateStencil = true;
			SetVerticesDirty();
			SetMaterialDirty();
			return m_sharedMaterial;
		}

		protected override Material[] EJLJPNINLLO(Material[] BIPEMPFPCKG)
		{
			int materialCount = m_textInfo.materialCount;
			if (m_fontMaterials == null)
			{
				m_fontMaterials = new Material[materialCount];
			}
			else if (m_fontMaterials.Length != materialCount)
			{
				TMP_TextInfo.NKMKBLFBOFC(ref m_fontMaterials, materialCount, false);
			}
			for (int i = 0; i < materialCount; i++)
			{
				if (i == 0)
				{
					m_fontMaterials[i] = base.ODDEOOFJENH;
				}
				else
				{
					m_fontMaterials[i] = m_subTextObjects[i].material;
				}
			}
			m_fontSharedMaterials = m_fontMaterials;
			return m_fontMaterials;
		}

		protected override void LFCEIGAFPID(Material GJDEEBDFEFM)
		{
			m_sharedMaterial = GJDEEBDFEFM;
			IBKCGEGKGNM = LEJDCNIKNBD();
			SetMaterialDirty();
		}

		protected override Material[] DGGOGFBFNEO()
		{
			int materialCount = m_textInfo.materialCount;
			if (m_fontSharedMaterials == null)
			{
				m_fontSharedMaterials = new Material[materialCount];
			}
			else if (m_fontSharedMaterials.Length != materialCount)
			{
				TMP_TextInfo.NKMKBLFBOFC(ref m_fontSharedMaterials, materialCount, false);
			}
			for (int i = 0; i < materialCount; i++)
			{
				if (i == 0)
				{
					m_fontSharedMaterials[i] = m_sharedMaterial;
				}
				else
				{
					m_fontSharedMaterials[i] = m_subTextObjects[i].OOMNMKHLJIC;
				}
			}
			return m_fontSharedMaterials;
		}

		protected override void MMOPIMDKJDE(Material[] IDBMABBJCNC)
		{
			int materialCount = m_textInfo.materialCount;
			if (m_fontSharedMaterials == null)
			{
				m_fontSharedMaterials = new Material[materialCount];
			}
			else if (m_fontSharedMaterials.Length != materialCount)
			{
				TMP_TextInfo.NKMKBLFBOFC(ref m_fontSharedMaterials, materialCount, false);
			}
			for (int i = 0; i < materialCount; i++)
			{
				if (i == 0)
				{
					if (!(IDBMABBJCNC[i].GetTexture(MOHPNOBPBBL.GKMMOOGJLHP) == null) && IDBMABBJCNC[i].GetTexture(MOHPNOBPBBL.GKMMOOGJLHP).GetInstanceID() == m_sharedMaterial.GetTexture(MOHPNOBPBBL.GKMMOOGJLHP).GetInstanceID())
					{
						m_sharedMaterial = (m_fontSharedMaterials[i] = IDBMABBJCNC[i]);
						IBKCGEGKGNM = LEJDCNIKNBD(m_sharedMaterial);
					}
				}
				else if (!(IDBMABBJCNC[i].GetTexture(MOHPNOBPBBL.GKMMOOGJLHP) == null) && IDBMABBJCNC[i].GetTexture(MOHPNOBPBBL.GKMMOOGJLHP).GetInstanceID() == m_subTextObjects[i].OOMNMKHLJIC.GetTexture(MOHPNOBPBBL.GKMMOOGJLHP).GetInstanceID() && m_subTextObjects[i].PDLHEANIELH)
				{
					m_subTextObjects[i].OOMNMKHLJIC = (m_fontSharedMaterials[i] = IDBMABBJCNC[i]);
				}
			}
		}

		protected override void MIOIBPAPDAN(float GGANGHBLIPC)
		{
			if (m_fontMaterial != null && m_sharedMaterial.GetInstanceID() != m_fontMaterial.GetInstanceID())
			{
				m_sharedMaterial = m_fontMaterial;
				JMJNGBJNGGC.SetMaterial(m_sharedMaterial, m_sharedMaterial.GetTexture(MOHPNOBPBBL.GKMMOOGJLHP));
			}
			else if (m_fontMaterial == null)
			{
				m_fontMaterial = IEDEFFAONFN(m_sharedMaterial);
				m_sharedMaterial = m_fontMaterial;
				JMJNGBJNGGC.SetMaterial(m_sharedMaterial, m_sharedMaterial.GetTexture(MOHPNOBPBBL.GKMMOOGJLHP));
			}
			GGANGHBLIPC = Mathf.Clamp01(GGANGHBLIPC);
			m_sharedMaterial.SetFloat(MOHPNOBPBBL.KOJOEHKKDCC, GGANGHBLIPC);
			IBKCGEGKGNM = LEJDCNIKNBD();
		}

		protected override void AKNMLFGLGAJ(Color32 MFODILBOMGD)
		{
			if (m_fontMaterial == null)
			{
				m_fontMaterial = IEDEFFAONFN(m_sharedMaterial);
			}
			m_sharedMaterial = m_fontMaterial;
			IBKCGEGKGNM = LEJDCNIKNBD();
			m_sharedMaterial.SetColor(MOHPNOBPBBL.JCABCKFODAG, MFODILBOMGD);
		}

		protected override void NDBGEGOKCOL(Color32 MFODILBOMGD)
		{
			if (m_fontMaterial == null)
			{
				m_fontMaterial = IEDEFFAONFN(m_sharedMaterial);
			}
			m_sharedMaterial = m_fontMaterial;
			IBKCGEGKGNM = LEJDCNIKNBD();
			m_sharedMaterial.SetColor(MOHPNOBPBBL.LNBDEEHONJE, MFODILBOMGD);
		}

		protected override void AEAIBCHGCNL()
		{
			if (!(CNEODGLFFPG == null) && !(m_sharedMaterial == null))
			{
				if (CNEODGLFFPG.renderMode == RenderMode.ScreenSpaceOverlay || HCFCMKLKOIM)
				{
					m_sharedMaterial.SetFloat(MOHPNOBPBBL.PJDLFOCEHLD, 0f);
				}
				else
				{
					m_sharedMaterial.SetFloat(MOHPNOBPBBL.PJDLFOCEHLD, 4f);
				}
			}
		}

		protected override void GDDGEMIIBDC()
		{
			if (m_isCullingEnabled)
			{
				JMJNGBJNGGC.GetMaterial().SetFloat("_CullMode", 2f);
			}
			else
			{
				JMJNGBJNGGC.GetMaterial().SetFloat("_CullMode", 0f);
			}
		}

		private void HPEEPCKAIPH()
		{
			if (m_isOrthographic)
			{
				m_sharedMaterial.SetFloat(MOHPNOBPBBL.DFDFEJJNNJF, 0f);
			}
			else
			{
				m_sharedMaterial.SetFloat(MOHPNOBPBBL.DFDFEJJNNJF, 0.875f);
			}
		}

		protected override float LEJDCNIKNBD(Material GJDEEBDFEFM)
		{
			IBKCGEGKGNM = MOHPNOBPBBL.JHMPKCIPPMF(GJDEEBDFEFM, m_enableExtraPadding, JLDKHEKHGKA);
			HFGCJAKMLKE = MOHPNOBPBBL.DIGKAOJFBDJ(m_sharedMaterial);
			NJFPOFBLHCF = GJDEEBDFEFM.HasProperty(MOHPNOBPBBL.NJPHJKMLDDE);
			return IBKCGEGKGNM;
		}

		protected override float LEJDCNIKNBD()
		{
			MOHPNOBPBBL.LNNKOOPFJON();
			IBKCGEGKGNM = MOHPNOBPBBL.JHMPKCIPPMF(m_sharedMaterial, m_enableExtraPadding, JLDKHEKHGKA);
			HFGCJAKMLKE = MOHPNOBPBBL.DIGKAOJFBDJ(m_sharedMaterial);
			NJFPOFBLHCF = m_sharedMaterial.HasProperty(MOHPNOBPBBL.NJPHJKMLDDE);
			return IBKCGEGKGNM;
		}

		private void BHHADGHFBAO(int MOFHAKELNPN)
		{
			m_textInfo.meshInfo[0].CMGCBJCIJNB(MOFHAKELNPN);
			JMJNGBJNGGC.SetMesh(m_textInfo.meshInfo[0].IJKCGGPJDIG);
		}

		protected override int JAADOMGCOHA(int[] FBPAOINOCHI)
		{
			int OKEFBABJGLB = 0;
			int num = 0;
			KOIMFMFOLII = 0;
			JLDKHEKHGKA = false;
			OHKANPJHAFP = false;
			FGGFHMLKNJJ = false;
			CCLHEBEBBGN = m_fontStyle;
			ENGCHNIHPBK = (((CCLHEBEBBGN & BCIEOOJOMDO.Bold) != BCIEOOJOMDO.Bold) ? m_fontWeight : 700);
			IOAEEGOLEHI.GLLKOHHOLLP(ENGCHNIHPBK);
			AFEJPPDMPHE = m_fontAsset;
			JBPPHIKOJPL = m_sharedMaterial;
			AIJEDOAJAPI = 0;
			DBEFOGFNAME.GLLKOHHOLLP(new FMOBJPAGLEE(AIJEDOAJAPI, AFEJPPDMPHE, null, JBPPHIKOJPL, IBKCGEGKGNM));
			GJCBEOHAMEH.Clear();
			FMOBJPAGLEE.LBJKNANKAIP(JBPPHIKOJPL, AFEJPPDMPHE, NDPGMAPHNNA, GJCBEOHAMEH);
			if (m_textInfo == null)
			{
				m_textInfo = new TMP_TextInfo();
			}
			FHJFKDGNODI = HIPDBPNMONO.Character;
			if (m_linkedTextComponent != null)
			{
				m_linkedTextComponent.FCJBBPHFNPJ = string.Empty;
				m_linkedTextComponent.ForceMeshUpdate();
			}
			for (int i = 0; i < FBPAOINOCHI.Length && FBPAOINOCHI[i] != 0; i++)
			{
				if (m_textInfo.characterInfo == null || KOIMFMFOLII >= m_textInfo.characterInfo.Length)
				{
					TMP_TextInfo.NKMKBLFBOFC(ref m_textInfo.characterInfo, KOIMFMFOLII + 1, true);
				}
				int num2 = FBPAOINOCHI[i];
				if (m_isRichText && num2 == 60)
				{
					int aIJEDOAJAPI = AIJEDOAJAPI;
					if (ACLAAHPAFMI(FBPAOINOCHI, i + 1, out OKEFBABJGLB))
					{
						i = OKEFBABJGLB;
						if ((CCLHEBEBBGN & BCIEOOJOMDO.Bold) == BCIEOOJOMDO.Bold)
						{
							JLDKHEKHGKA = true;
						}
						if (FHJFKDGNODI == HIPDBPNMONO.Sprite)
						{
							NDPGMAPHNNA[AIJEDOAJAPI].OLEEIKHIDIB++;
							m_textInfo.characterInfo[KOIMFMFOLII].AONJCHFEHOM = (char)(57344 + OOIILNOMGIL);
							m_textInfo.characterInfo[KOIMFMFOLII].JDMPHFEHPCI = OOIILNOMGIL;
							m_textInfo.characterInfo[KOIMFMFOLII].PIJNMJOHBIE = AFEJPPDMPHE;
							m_textInfo.characterInfo[KOIMFMFOLII].GKDEMJDOOLB = HBLKKCJHFFK;
							m_textInfo.characterInfo[KOIMFMFOLII].EKBHGEBCJHL = AIJEDOAJAPI;
							m_textInfo.characterInfo[KOIMFMFOLII].MGBPNBKJOJL = FHJFKDGNODI;
							FHJFKDGNODI = HIPDBPNMONO.Character;
							AIJEDOAJAPI = aIJEDOAJAPI;
							num++;
							KOIMFMFOLII++;
						}
						continue;
					}
				}
				bool flag = false;
				bool nKAJACJKPCM = false;
				TMP_FontAsset aFEJPPDMPHE = AFEJPPDMPHE;
				Material jBPPHIKOJPL = JBPPHIKOJPL;
				int aIJEDOAJAPI2 = AIJEDOAJAPI;
				if (FHJFKDGNODI == HIPDBPNMONO.Character)
				{
					if ((CCLHEBEBBGN & BCIEOOJOMDO.UpperCase) == BCIEOOJOMDO.UpperCase)
					{
						if (char.IsLower((char)num2))
						{
							num2 = char.ToUpper((char)num2);
						}
					}
					else if ((CCLHEBEBBGN & BCIEOOJOMDO.LowerCase) == BCIEOOJOMDO.LowerCase)
					{
						if (char.IsUpper((char)num2))
						{
							num2 = char.ToLower((char)num2);
						}
					}
					else if (((m_fontStyle & BCIEOOJOMDO.SmallCaps) == BCIEOOJOMDO.SmallCaps || (CCLHEBEBBGN & BCIEOOJOMDO.SmallCaps) == BCIEOOJOMDO.SmallCaps) && char.IsLower((char)num2))
					{
						num2 = char.ToUpper((char)num2);
					}
				}
				TMP_FontAsset tMP_FontAsset = EKCHMDNJLCP(ENGCHNIHPBK);
				if (tMP_FontAsset != null)
				{
					flag = true;
					nKAJACJKPCM = true;
					AFEJPPDMPHE = tMP_FontAsset;
				}
				TMP_Glyph FLPJKOEKMJJ;
				tMP_FontAsset = LOLKOAINBHK.GOIMLDBOBEN(AFEJPPDMPHE, num2, out FLPJKOEKMJJ);
				if (FLPJKOEKMJJ == null)
				{
					TMP_SpriteAsset spriteAsset = base.GKDEMJDOOLB;
					if (spriteAsset != null)
					{
						int JDMPHFEHPCI = -1;
						spriteAsset = TMP_SpriteAsset.GOGLJPJDMMP(spriteAsset, num2, out JDMPHFEHPCI);
						if (JDMPHFEHPCI != -1)
						{
							FHJFKDGNODI = HIPDBPNMONO.Sprite;
							m_textInfo.characterInfo[KOIMFMFOLII].MGBPNBKJOJL = FHJFKDGNODI;
							AIJEDOAJAPI = FMOBJPAGLEE.LBJKNANKAIP(spriteAsset.material, spriteAsset, NDPGMAPHNNA, GJCBEOHAMEH);
							NDPGMAPHNNA[AIJEDOAJAPI].OLEEIKHIDIB++;
							m_textInfo.characterInfo[KOIMFMFOLII].AONJCHFEHOM = (char)num2;
							m_textInfo.characterInfo[KOIMFMFOLII].JDMPHFEHPCI = JDMPHFEHPCI;
							m_textInfo.characterInfo[KOIMFMFOLII].PIJNMJOHBIE = AFEJPPDMPHE;
							m_textInfo.characterInfo[KOIMFMFOLII].GKDEMJDOOLB = spriteAsset;
							m_textInfo.characterInfo[KOIMFMFOLII].EKBHGEBCJHL = AIJEDOAJAPI;
							FHJFKDGNODI = HIPDBPNMONO.Character;
							AIJEDOAJAPI = aIJEDOAJAPI2;
							num++;
							KOIMFMFOLII++;
							continue;
						}
					}
				}
				if (FLPJKOEKMJJ == null && TMP_Settings.fallbackFontAssets != null && TMP_Settings.fallbackFontAssets.Count > 0)
				{
					tMP_FontAsset = LOLKOAINBHK.GOIMLDBOBEN(TMP_Settings.fallbackFontAssets, num2, out FLPJKOEKMJJ);
				}
				if (FLPJKOEKMJJ == null && TMP_Settings.defaultFontAsset != null)
				{
					tMP_FontAsset = LOLKOAINBHK.GOIMLDBOBEN(TMP_Settings.defaultFontAsset, num2, out FLPJKOEKMJJ);
				}
				if (FLPJKOEKMJJ == null)
				{
					TMP_SpriteAsset defaultSpriteAsset = TMP_Settings.defaultSpriteAsset;
					if (defaultSpriteAsset != null)
					{
						int JDMPHFEHPCI2 = -1;
						defaultSpriteAsset = TMP_SpriteAsset.GOGLJPJDMMP(defaultSpriteAsset, num2, out JDMPHFEHPCI2);
						if (JDMPHFEHPCI2 != -1)
						{
							FHJFKDGNODI = HIPDBPNMONO.Sprite;
							m_textInfo.characterInfo[KOIMFMFOLII].MGBPNBKJOJL = FHJFKDGNODI;
							AIJEDOAJAPI = FMOBJPAGLEE.LBJKNANKAIP(defaultSpriteAsset.material, defaultSpriteAsset, NDPGMAPHNNA, GJCBEOHAMEH);
							NDPGMAPHNNA[AIJEDOAJAPI].OLEEIKHIDIB++;
							m_textInfo.characterInfo[KOIMFMFOLII].AONJCHFEHOM = (char)num2;
							m_textInfo.characterInfo[KOIMFMFOLII].JDMPHFEHPCI = JDMPHFEHPCI2;
							m_textInfo.characterInfo[KOIMFMFOLII].PIJNMJOHBIE = AFEJPPDMPHE;
							m_textInfo.characterInfo[KOIMFMFOLII].GKDEMJDOOLB = defaultSpriteAsset;
							m_textInfo.characterInfo[KOIMFMFOLII].EKBHGEBCJHL = AIJEDOAJAPI;
							FHJFKDGNODI = HIPDBPNMONO.Character;
							AIJEDOAJAPI = aIJEDOAJAPI2;
							num++;
							KOIMFMFOLII++;
							continue;
						}
					}
				}
				if (FLPJKOEKMJJ == null)
				{
					num2 = (FBPAOINOCHI[i] = ((TMP_Settings.missingGlyphCharacter != 0) ? TMP_Settings.missingGlyphCharacter : 9633));
					tMP_FontAsset = LOLKOAINBHK.GOIMLDBOBEN(AFEJPPDMPHE, num2, out FLPJKOEKMJJ);
					if (FLPJKOEKMJJ == null && TMP_Settings.fallbackFontAssets != null && TMP_Settings.fallbackFontAssets.Count > 0)
					{
						tMP_FontAsset = LOLKOAINBHK.GOIMLDBOBEN(TMP_Settings.fallbackFontAssets, num2, out FLPJKOEKMJJ);
					}
					if (FLPJKOEKMJJ == null && TMP_Settings.defaultFontAsset != null)
					{
						tMP_FontAsset = LOLKOAINBHK.GOIMLDBOBEN(TMP_Settings.defaultFontAsset, num2, out FLPJKOEKMJJ);
					}
					if (FLPJKOEKMJJ == null)
					{
						num2 = (FBPAOINOCHI[i] = 32);
						tMP_FontAsset = LOLKOAINBHK.GOIMLDBOBEN(AFEJPPDMPHE, num2, out FLPJKOEKMJJ);
						if (!TMP_Settings.warningsDisabled)
						{
							Debug.LogWarning("Character with ASCII value of " + num2 + " was not found in the Font Asset Glyph Table. It was replaced by a space.", this);
						}
					}
				}
				if (tMP_FontAsset != null && tMP_FontAsset.GetInstanceID() != AFEJPPDMPHE.GetInstanceID())
				{
					flag = true;
					AFEJPPDMPHE = tMP_FontAsset;
				}
				m_textInfo.characterInfo[KOIMFMFOLII].MGBPNBKJOJL = HIPDBPNMONO.Character;
				m_textInfo.characterInfo[KOIMFMFOLII].EAHALNAKGJP = FLPJKOEKMJJ;
				m_textInfo.characterInfo[KOIMFMFOLII].NKAJACJKPCM = nKAJACJKPCM;
				m_textInfo.characterInfo[KOIMFMFOLII].AONJCHFEHOM = (char)num2;
				m_textInfo.characterInfo[KOIMFMFOLII].PIJNMJOHBIE = AFEJPPDMPHE;
				if (flag)
				{
					if (TMP_Settings.matchMaterialPreset)
					{
						JBPPHIKOJPL = HPENNIOPLFI.MFPJJEMDCGJ(JBPPHIKOJPL, AFEJPPDMPHE.material);
					}
					else
					{
						JBPPHIKOJPL = AFEJPPDMPHE.material;
					}
					AIJEDOAJAPI = FMOBJPAGLEE.LBJKNANKAIP(JBPPHIKOJPL, AFEJPPDMPHE, NDPGMAPHNNA, GJCBEOHAMEH);
				}
				if (!char.IsWhiteSpace((char)num2) && num2 != 8203)
				{
					if (NDPGMAPHNNA[AIJEDOAJAPI].OLEEIKHIDIB < 16383)
					{
						NDPGMAPHNNA[AIJEDOAJAPI].OLEEIKHIDIB++;
					}
					else
					{
						AIJEDOAJAPI = FMOBJPAGLEE.LBJKNANKAIP(new Material(JBPPHIKOJPL), AFEJPPDMPHE, NDPGMAPHNNA, GJCBEOHAMEH);
						NDPGMAPHNNA[AIJEDOAJAPI].OLEEIKHIDIB++;
					}
				}
				m_textInfo.characterInfo[KOIMFMFOLII].GHPFOPNNJOB = JBPPHIKOJPL;
				m_textInfo.characterInfo[KOIMFMFOLII].EKBHGEBCJHL = AIJEDOAJAPI;
				NDPGMAPHNNA[AIJEDOAJAPI].MNGFKMKDLPD = flag;
				if (flag)
				{
					NDPGMAPHNNA[AIJEDOAJAPI].PDKNCECBLAJ = jBPPHIKOJPL;
					AFEJPPDMPHE = aFEJPPDMPHE;
					JBPPHIKOJPL = jBPPHIKOJPL;
					AIJEDOAJAPI = aIJEDOAJAPI2;
				}
				KOIMFMFOLII++;
			}
			if (CEOCLEMDMEE)
			{
				CEOCLEMDMEE = false;
				m_isInputParsingRequired = true;
				return KOIMFMFOLII;
			}
			m_textInfo.spriteCount = num;
			int num3 = (m_textInfo.materialCount = GJCBEOHAMEH.Count);
			if (num3 > m_textInfo.meshInfo.Length)
			{
				TMP_TextInfo.NKMKBLFBOFC(ref m_textInfo.meshInfo, num3, false);
			}
			if (num3 > m_subTextObjects.Length)
			{
				TMP_TextInfo.NKMKBLFBOFC(ref m_subTextObjects, Mathf.NextPowerOfTwo(num3 + 1));
			}
			if (m_textInfo.characterInfo.Length - KOIMFMFOLII > 256)
			{
				TMP_TextInfo.NKMKBLFBOFC(ref m_textInfo.characterInfo, Mathf.Max(KOIMFMFOLII + 1, 256), true);
			}
			for (int j = 0; j < num3; j++)
			{
				if (j > 0)
				{
					if (m_subTextObjects[j] == null)
					{
						m_subTextObjects[j] = TMP_SubMeshUI.AddSubTextObject(this, NDPGMAPHNNA[j]);
						m_textInfo.meshInfo[j].FHBFCAEGPOH = null;
					}
					if (HBKNOEILBLE.pivot != m_subTextObjects[j].rectTransform.pivot)
					{
						m_subTextObjects[j].rectTransform.pivot = HBKNOEILBLE.pivot;
					}
					if (m_subTextObjects[j].OOMNMKHLJIC == null || m_subTextObjects[j].OOMNMKHLJIC.GetInstanceID() != NDPGMAPHNNA[j].GHPFOPNNJOB.GetInstanceID())
					{
						bool pDLHEANIELH = NDPGMAPHNNA[j].PDLHEANIELH;
						m_subTextObjects[j].PDLHEANIELH = pDLHEANIELH;
						if (!pDLHEANIELH || m_subTextObjects[j].OOMNMKHLJIC == null || m_subTextObjects[j].OOMNMKHLJIC.GetTexture(MOHPNOBPBBL.GKMMOOGJLHP).GetInstanceID() != NDPGMAPHNNA[j].GHPFOPNNJOB.GetTexture(MOHPNOBPBBL.GKMMOOGJLHP).GetInstanceID())
						{
							m_subTextObjects[j].OOMNMKHLJIC = NDPGMAPHNNA[j].GHPFOPNNJOB;
							m_subTextObjects[j].PIJNMJOHBIE = NDPGMAPHNNA[j].PIJNMJOHBIE;
							m_subTextObjects[j].GKDEMJDOOLB = NDPGMAPHNNA[j].GKDEMJDOOLB;
						}
					}
					if (NDPGMAPHNNA[j].MNGFKMKDLPD)
					{
						m_subTextObjects[j].PDKNCECBLAJ = NDPGMAPHNNA[j].GHPFOPNNJOB;
						m_subTextObjects[j].MHMODIMFCIN = NDPGMAPHNNA[j].PDKNCECBLAJ;
					}
				}
				int oLEEIKHIDIB = NDPGMAPHNNA[j].OLEEIKHIDIB;
				if (m_textInfo.meshInfo[j].FHBFCAEGPOH == null || m_textInfo.meshInfo[j].FHBFCAEGPOH.Length < oLEEIKHIDIB * 4)
				{
					if (m_textInfo.meshInfo[j].FHBFCAEGPOH == null)
					{
						if (j == 0)
						{
							m_textInfo.meshInfo[j] = new IDAPNGDHHBD(OPMBPPBMINF, oLEEIKHIDIB + 1);
						}
						else
						{
							m_textInfo.meshInfo[j] = new IDAPNGDHHBD(m_subTextObjects[j].IJKCGGPJDIG, oLEEIKHIDIB + 1);
						}
					}
					else
					{
						m_textInfo.meshInfo[j].CMGCBJCIJNB((oLEEIKHIDIB <= 1024) ? Mathf.NextPowerOfTwo(oLEEIKHIDIB) : (oLEEIKHIDIB + 256));
					}
				}
				else if (m_textInfo.meshInfo[j].FHBFCAEGPOH.Length - oLEEIKHIDIB * 4 > 1024)
				{
					m_textInfo.meshInfo[j].CMGCBJCIJNB((oLEEIKHIDIB <= 1024) ? Mathf.Max(Mathf.NextPowerOfTwo(oLEEIKHIDIB), 256) : (oLEEIKHIDIB + 256));
				}
			}
			for (int k = num3; k < m_subTextObjects.Length && m_subTextObjects[k] != null; k++)
			{
				if (k < m_textInfo.meshInfo.Length)
				{
					m_subTextObjects[k].HBIBDFFPKFG.SetMesh(null);
				}
			}
			return KOIMFMFOLII;
		}

		protected override void EMKNNKLEEPI()
		{
			if (base.GPPKOGCLKPL != null)
			{
				IOOMPCBBCNK = HBKNOEILBLE.rect.width - m_margin.x - m_margin.z;
				NNFECNKNNLL = HBKNOEILBLE.rect.height - m_margin.y - m_margin.w;
				LJPBNPONJJJ = BELKDCLEJKJ();
			}
		}

		protected override void OnDidApplyAnimationProperties()
		{
			m_havePropertiesChanged = true;
			SetVerticesDirty();
			SetLayoutDirty();
		}

		protected override void OnCanvasHierarchyChanged()
		{
			base.OnCanvasHierarchyChanged();
			CNEODGLFFPG = base.canvas;
		}

		protected override void OnTransformParentChanged()
		{
			base.OnTransformParentChanged();
			CNEODGLFFPG = base.canvas;
			EMKNNKLEEPI();
			m_havePropertiesChanged = true;
		}

		protected override void OnRectTransformDimensionsChange()
		{
			if (base.gameObject.activeInHierarchy)
			{
				EMKNNKLEEPI();
				MJDJBNBHHKD();
				SetVerticesDirty();
				SetLayoutDirty();
			}
		}

		private void LateUpdate()
		{
			if (HBKNOEILBLE.hasChanged)
			{
				float y = HBKNOEILBLE.lossyScale.y;
				if (!m_havePropertiesChanged && y != JFGEKNMANOJ && m_text != string.Empty && m_text != null)
				{
					GFLNMPPCJKM(y);
					JFGEKNMANOJ = y;
				}
				HBKNOEILBLE.hasChanged = false;
			}
			if (m_isUsingLegacyAnimationComponent)
			{
				m_havePropertiesChanged = true;
				LHMMLLDIHMN();
			}
		}

		private void LHMMLLDIHMN()
		{
			if (!NHJALNOIJDN || (!FOMLPKEMFLJ && !IsActive()))
			{
				return;
			}
			if (CNEODGLFFPG == null)
			{
				CNEODGLFFPG = base.canvas;
				if (CNEODGLFFPG == null)
				{
					return;
				}
			}
			JEFPIONIJFI = 0;
			if (m_havePropertiesChanged || GHPJHKPEOIK)
			{
				if (checkPaddingRequired)
				{
					UpdateMeshPadding();
				}
				if (m_isInputParsingRequired || OHEPFDPOBOF)
				{
					GJKICJDAIIH();
				}
				if (m_enableAutoSizing)
				{
					m_fontSize = Mathf.Clamp(m_fontSize, m_fontSizeMin, m_fontSizeMax);
				}
				KCNAALADKDH = m_fontSizeMax;
				FOGJMAGABCF = m_fontSizeMin;
				FNABNBFMNME = 0f;
				JDKKGHCOCJK = 0f;
				CHPJNOEDAFE = false;
				OHEPFDPOBOF = false;
				m_havePropertiesChanged = false;
				GHPJHKPEOIK = false;
				FOMLPKEMFLJ = false;
				DLIBNLFHMKF();
			}
		}

		protected override void DLIBNLFHMKF()
		{
			if (m_fontAsset == null || m_fontAsset.characterDictionary == null)
			{
				Debug.LogWarning("Can't Generate Mesh! No Font Asset has been assigned to Object ID: " + GetInstanceID());
				return;
			}
			if (m_textInfo != null)
			{
				m_textInfo.BOPEPLONIFL();
			}
			if (GMALEIECAPN == null || GMALEIECAPN.Length == 0 || GMALEIECAPN[0] == 0)
			{
				ClearMesh();
				HEJJGBFEPCM = 0f;
				EHHDCBAEJDG = 0f;
				FFCFAICENOB.EDOBMOAFCFA(this);
				return;
			}
			AFEJPPDMPHE = m_fontAsset;
			JBPPHIKOJPL = m_sharedMaterial;
			AIJEDOAJAPI = 0;
			DBEFOGFNAME.GLLKOHHOLLP(new FMOBJPAGLEE(AIJEDOAJAPI, AFEJPPDMPHE, null, JBPPHIKOJPL, IBKCGEGKGNM));
			HBLKKCJHFFK = m_spriteAsset;
			if (m_spriteAnimator != null)
			{
				m_spriteAnimator.StopAllAnimations();
			}
			int kOIMFMFOLII = KOIMFMFOLII;
			MEPDJFGMGOK = m_fontSize / AFEJPPDMPHE.fontInfo.PointSize;
			float num = m_fontSize / m_fontAsset.fontInfo.PointSize * m_fontAsset.fontInfo.Scale;
			float num2 = MEPDJFGMGOK;
			GEHMOIPKBGD = 1f;
			MPIGOGEKIPI = m_fontSize;
			FJJAGAJLDJG.GLLKOHHOLLP(MPIGOGEKIPI);
			float num3 = 0f;
			int num4 = 0;
			CCLHEBEBBGN = m_fontStyle;
			ENGCHNIHPBK = (((CCLHEBEBBGN & BCIEOOJOMDO.Bold) != BCIEOOJOMDO.Bold) ? m_fontWeight : 700);
			IOAEEGOLEHI.GLLKOHHOLLP(ENGCHNIHPBK);
			MKAJPJFKEPP.BOPEPLONIFL();
			FPDOALAOBLE = m_textAlignment;
			IBLGHCLBFJG.GLLKOHHOLLP(FPDOALAOBLE);
			float num5 = 0f;
			float num6 = 0f;
			float num7 = 1f;
			HDHGLHPMBPG = 0f;
			bool flag = false;
			Vector3 eHGOOEHDNMM = Vector3.zero;
			Vector3 zero = Vector3.zero;
			bool flag2 = false;
			Vector3 eHGOOEHDNMM2 = Vector3.zero;
			Vector3 zero2 = Vector3.zero;
			bool flag3 = false;
			Vector3 eHGOOEHDNMM3 = Vector3.zero;
			Vector3 vector = Vector3.zero;
			m_fontColor32 = m_fontColor;
			EPCFNBCMCHK = m_fontColor32;
			HEFLDLNICAK = EPCFNBCMCHK;
			DNDMCGFIBJM = EPCFNBCMCHK;
			EOGFNFBPHHJ.GLLKOHHOLLP(EPCFNBCMCHK);
			FNPOGPIGCIN.GLLKOHHOLLP(EPCFNBCMCHK);
			LEMAEBLIHBK.GLLKOHHOLLP(EPCFNBCMCHK);
			KOOKMGIBAIG.GLLKOHHOLLP(EPCFNBCMCHK);
			DJIJDHCEGOA.BOPEPLONIFL();
			HCBFOLNGCFI = false;
			GFIDNINNNAL = 0f;
			KODBBLNBFDO = -32767f;
			float num8 = AFEJPPDMPHE.fontInfo.LineHeight - (AFEJPPDMPHE.fontInfo.Ascender - AFEJPPDMPHE.fontInfo.Descender);
			OMGEAPDMJBN = 0f;
			CADPBEPINNM = 0f;
			float num9 = 0f;
			PLALFBMFEEC = 0f;
			KGDNHOEOOHO = 0f;
			GKEHAJKJCEF = 0f;
			BNFNFGGNBGJ.GLLKOHHOLLP(0f);
			FGGFHMLKNJJ = false;
			HEEDOMEABKA = 0;
			MIEJCGGDMLJ = 0;
			LFEILECBDDB = 0;
			JGOLJOCMOGD = 0;
			GMLEPIKAEMI = 0;
			NDEAABJECMK = TMP_Text.BDOPFJFCOGB;
			ODBAKFJDCCP = TMP_Text.FEBIFNLEHEG;
			FGMGAJAPPJC = 0;
			CILFEEOIDGC = 0;
			bool flag4 = true;
			m_firstOverflowCharacterIndex = -1;
			BHJLNHKINKN = 0;
			int num10 = Mathf.Clamp(m_pageToDisplay - 1, 0, m_textInfo.pageInfo.Length - 1);
			int num11 = 0;
			int num12 = 0;
			Vector4 margin = m_margin;
			float iOOMPCBBCNK = IOOMPCBBCNK;
			float nNFECNKNNLL = NNFECNKNNLL;
			DPIAMOJPHPK = 0f;
			EPPLBJGIFEM = 0f;
			IFAFCDFNNJN = -1f;
			float num13 = iOOMPCBBCNK + 0.0001f - DPIAMOJPHPK - EPPLBJGIFEM;
			NBHJNBHINPH.IJHGDODBFCD = TMP_Text.BOAMBILHDEN;
			NBHJNBHINPH.NHLJFKPLKLI = TMP_Text.DEAMJJKCNNM;
			m_textInfo.KNPNNLMNFIL();
			JCNIIINOEHG = 0f;
			MJMNGPIFHGG = 0f;
			ONHFBKLHJIN = 0f;
			float num14 = 0f;
			float num15 = 0f;
			bool flag5 = false;
			GEGDAJAOKKA = false;
			bool flag6 = true;
			PIABLFACDIO = false;
			bool flag7 = false;
			bool flag8 = false;
			int num16 = 0;
			LLBAPJLPCAN(ref BLMLICONBCO, -1, -1);
			LLBAPJLPCAN(ref EOKDMGOFOOH, -1, -1);
			JEFPIONIJFI++;
			int OKEFBABJGLB = 0;
			Vector3 vector2 = default(Vector3);
			Vector3 vector3 = default(Vector3);
			Vector3 vector4 = default(Vector3);
			Vector3 vector5 = default(Vector3);
			for (int i = 0; i < GMALEIECAPN.Length && GMALEIECAPN[i] != 0; i++)
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
				if (HEEDOMEABKA < m_firstVisibleCharacter)
				{
					m_textInfo.characterInfo[HEEDOMEABKA].BACHBACHNOF = false;
					m_textInfo.characterInfo[HEEDOMEABKA].AONJCHFEHOM = '\u200b';
					HEEDOMEABKA++;
					continue;
				}
				float num17 = 1f;
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
						num17 = 0.8f;
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
					else
					{
						IIHIHIELCKN = TMP_Text.MCCKLLJFKGH;
					}
					AFEJPPDMPHE = m_fontAsset;
					float num18 = MPIGOGEKIPI / m_fontAsset.fontInfo.PointSize * m_fontAsset.fontInfo.Scale;
					num2 = m_fontAsset.fontInfo.Ascender / tMP_Sprite.height * tMP_Sprite.scale * num18;
					EOLJHINLKLO = tMP_Sprite;
					m_textInfo.characterInfo[HEEDOMEABKA].MGBPNBKJOJL = HIPDBPNMONO.Sprite;
					m_textInfo.characterInfo[HEEDOMEABKA].HJLOCAEAFMJ = num18;
					m_textInfo.characterInfo[HEEDOMEABKA].GKDEMJDOOLB = HBLKKCJHFFK;
					m_textInfo.characterInfo[HEEDOMEABKA].PIJNMJOHBIE = AFEJPPDMPHE;
					m_textInfo.characterInfo[HEEDOMEABKA].EKBHGEBCJHL = AIJEDOAJAPI;
					AIJEDOAJAPI = aIJEDOAJAPI;
					num5 = 0f;
				}
				else if (FHJFKDGNODI == HIPDBPNMONO.Character)
				{
					EOLJHINLKLO = m_textInfo.characterInfo[HEEDOMEABKA].EAHALNAKGJP;
					if (EOLJHINLKLO == null)
					{
						continue;
					}
					AFEJPPDMPHE = m_textInfo.characterInfo[HEEDOMEABKA].PIJNMJOHBIE;
					JBPPHIKOJPL = m_textInfo.characterInfo[HEEDOMEABKA].GHPFOPNNJOB;
					AIJEDOAJAPI = m_textInfo.characterInfo[HEEDOMEABKA].EKBHGEBCJHL;
					MEPDJFGMGOK = MPIGOGEKIPI * num17 / AFEJPPDMPHE.fontInfo.PointSize * AFEJPPDMPHE.fontInfo.Scale;
					num2 = MEPDJFGMGOK * GEHMOIPKBGD * EOLJHINLKLO.scale;
					m_textInfo.characterInfo[HEEDOMEABKA].MGBPNBKJOJL = HIPDBPNMONO.Character;
					m_textInfo.characterInfo[HEEDOMEABKA].HJLOCAEAFMJ = num2;
					num5 = ((AIJEDOAJAPI != 0) ? m_subTextObjects[AIJEDOAJAPI].HFHKPBBFDFD : IBKCGEGKGNM);
				}
				float num19 = num2;
				if (num4 == 173)
				{
					num2 = 0f;
				}
				if (m_isRightToLeft)
				{
					PLALFBMFEEC -= ((EOLJHINLKLO.xAdvance * num7 + m_characterSpacing + m_wordSpacing + AFEJPPDMPHE.normalSpacingOffset) * num2 + OMGEAPDMJBN) * (1f - JDKKGHCOCJK);
					if (char.IsWhiteSpace((char)num4) || num4 == 8203)
					{
						PLALFBMFEEC -= m_wordSpacing * num2;
					}
				}
				m_textInfo.characterInfo[HEEDOMEABKA].AONJCHFEHOM = (char)num4;
				m_textInfo.characterInfo[HEEDOMEABKA].EKNOFGHHCPJ = MPIGOGEKIPI;
				m_textInfo.characterInfo[HEEDOMEABKA].MFODILBOMGD = EPCFNBCMCHK;
				m_textInfo.characterInfo[HEEDOMEABKA].FNHEFDBFBMN = HEFLDLNICAK;
				m_textInfo.characterInfo[HEEDOMEABKA].NPNKHPFBLBG = DNDMCGFIBJM;
				m_textInfo.characterInfo[HEEDOMEABKA].OFCEJMNBFOJ = EDCPEAJCPLG;
				m_textInfo.characterInfo[HEEDOMEABKA].LMNINFLOCIB = CCLHEBEBBGN;
				m_textInfo.characterInfo[HEEDOMEABKA].EHJNMODJEAN = (short)i;
				if (m_enableKerning && HEEDOMEABKA >= 1)
				{
					int aONJCHFEHOM = m_textInfo.characterInfo[HEEDOMEABKA - 1].AONJCHFEHOM;
					OIMKDKKJDIK oIMKDKKJDIK = new OIMKDKKJDIK(aONJCHFEHOM, num4);
					KerningPair value;
					AFEJPPDMPHE.kerningDictionary.TryGetValue(oIMKDKKJDIK.IKNCPEPOKGJ, out value);
					if (value != null)
					{
						PLALFBMFEEC += value.XadvanceOffset * num2;
					}
				}
				float num20 = 0f;
				if (CADPBEPINNM != 0f)
				{
					num20 = (CADPBEPINNM / 2f - (EOLJHINLKLO.width / 2f + EOLJHINLKLO.xOffset) * num2) * (1f - JDKKGHCOCJK);
					PLALFBMFEEC += num20;
				}
				if (FHJFKDGNODI == HIPDBPNMONO.Character && !nKAJACJKPCM && ((CCLHEBEBBGN & BCIEOOJOMDO.Bold) == BCIEOOJOMDO.Bold || (m_fontStyle & BCIEOOJOMDO.Bold) == BCIEOOJOMDO.Bold))
				{
					if (JBPPHIKOJPL.HasProperty(MOHPNOBPBBL.APPGFNEOBOF))
					{
						float @float = JBPPHIKOJPL.GetFloat(MOHPNOBPBBL.APPGFNEOBOF);
						num6 = AFEJPPDMPHE.boldStyle / 4f * @float * JBPPHIKOJPL.GetFloat(MOHPNOBPBBL.BNDHPJPMOLH);
						if (num6 + num5 > @float)
						{
							num5 = @float - num6;
						}
					}
					else
					{
						num6 = 0f;
					}
					num7 = 1f + AFEJPPDMPHE.boldSpacing * 0.01f;
				}
				else
				{
					if (JBPPHIKOJPL.HasProperty(MOHPNOBPBBL.APPGFNEOBOF))
					{
						float float2 = JBPPHIKOJPL.GetFloat(MOHPNOBPBBL.APPGFNEOBOF);
						num6 = AFEJPPDMPHE.normalStyle / 4f * float2 * JBPPHIKOJPL.GetFloat(MOHPNOBPBBL.BNDHPJPMOLH);
						if (num6 + num5 > float2)
						{
							num5 = float2 - num6;
						}
					}
					else
					{
						num6 = 0f;
					}
					num7 = 1f;
				}
				float baseline = AFEJPPDMPHE.fontInfo.Baseline;
				vector2.x = PLALFBMFEEC + (EOLJHINLKLO.xOffset - num5 - num6) * num2 * (1f - JDKKGHCOCJK);
				vector2.y = (baseline + EOLJHINLKLO.yOffset + num5) * num2 - GFIDNINNNAL + HDHGLHPMBPG;
				vector2.z = 0f;
				vector3.x = vector2.x;
				vector3.y = vector2.y - (EOLJHINLKLO.height + num5 * 2f) * num2;
				vector3.z = 0f;
				vector4.x = vector3.x + (EOLJHINLKLO.width + num5 * 2f + num6 * 2f) * num2 * (1f - JDKKGHCOCJK);
				vector4.y = vector2.y;
				vector4.z = 0f;
				vector5.x = vector4.x;
				vector5.y = vector3.y;
				vector5.z = 0f;
				if (FHJFKDGNODI == HIPDBPNMONO.Character && !nKAJACJKPCM && ((CCLHEBEBBGN & BCIEOOJOMDO.Italic) == BCIEOOJOMDO.Italic || (m_fontStyle & BCIEOOJOMDO.Italic) == BCIEOOJOMDO.Italic))
				{
					float num21 = (float)(int)AFEJPPDMPHE.italicStyle * 0.01f;
					Vector3 vector6 = new Vector3(num21 * ((EOLJHINLKLO.yOffset + num5 + num6) * num2), 0f, 0f);
					Vector3 vector7 = new Vector3(num21 * ((EOLJHINLKLO.yOffset - EOLJHINLKLO.height - num5 - num6) * num2), 0f, 0f);
					vector2 += vector6;
					vector3 += vector7;
					vector4 += vector6;
					vector5 += vector7;
				}
				if (HCBFOLNGCFI)
				{
					Vector3 vector8 = (vector4 + vector3) / 2f;
					vector2 = DLBOPBIJDIB.MultiplyPoint3x4(vector2 - vector8) + vector8;
					vector3 = DLBOPBIJDIB.MultiplyPoint3x4(vector3 - vector8) + vector8;
					vector4 = DLBOPBIJDIB.MultiplyPoint3x4(vector4 - vector8) + vector8;
					vector5 = DLBOPBIJDIB.MultiplyPoint3x4(vector5 - vector8) + vector8;
				}
				m_textInfo.characterInfo[HEEDOMEABKA].GKDEKLOCKNA = vector3;
				m_textInfo.characterInfo[HEEDOMEABKA].LDJGLAIAPIM = vector2;
				m_textInfo.characterInfo[HEEDOMEABKA].BJONICNNGLI = vector4;
				m_textInfo.characterInfo[HEEDOMEABKA].ABIJFLBDMON = vector5;
				m_textInfo.characterInfo[HEEDOMEABKA].EBDCOMKHPBG = PLALFBMFEEC;
				m_textInfo.characterInfo[HEEDOMEABKA].CGAKKOEPCOG = 0f - GFIDNINNNAL + HDHGLHPMBPG;
				m_textInfo.characterInfo[HEEDOMEABKA].LJKMGEBBDBI = (vector4.x - vector3.x) / (vector2.y - vector3.y);
				float num22 = AFEJPPDMPHE.fontInfo.Ascender * ((FHJFKDGNODI != 0) ? m_textInfo.characterInfo[HEEDOMEABKA].HJLOCAEAFMJ : num2) + HDHGLHPMBPG;
				m_textInfo.characterInfo[HEEDOMEABKA].MNKFKKODLLM = num22 - GFIDNINNNAL;
				NDEAABJECMK = ((!(num22 > NDEAABJECMK)) ? NDEAABJECMK : num22);
				float num23 = AFEJPPDMPHE.fontInfo.Descender * ((FHJFKDGNODI != 0) ? m_textInfo.characterInfo[HEEDOMEABKA].HJLOCAEAFMJ : num2) + HDHGLHPMBPG;
				float num24 = (m_textInfo.characterInfo[HEEDOMEABKA].CALDBEMMLEA = num23 - GFIDNINNNAL);
				ODBAKFJDCCP = ((!(num23 < ODBAKFJDCCP)) ? ODBAKFJDCCP : num23);
				if ((CCLHEBEBBGN & BCIEOOJOMDO.Subscript) == BCIEOOJOMDO.Subscript || (CCLHEBEBBGN & BCIEOOJOMDO.Superscript) == BCIEOOJOMDO.Superscript)
				{
					float num25 = (num22 - HDHGLHPMBPG) / AFEJPPDMPHE.fontInfo.SubSize;
					num22 = NDEAABJECMK;
					NDEAABJECMK = ((!(num25 > NDEAABJECMK)) ? NDEAABJECMK : num25);
					float num26 = (num23 - HDHGLHPMBPG) / AFEJPPDMPHE.fontInfo.SubSize;
					num23 = ODBAKFJDCCP;
					ODBAKFJDCCP = ((!(num26 < ODBAKFJDCCP)) ? ODBAKFJDCCP : num26);
				}
				if (FGMGAJAPPJC == 0 || GEGDAJAOKKA)
				{
					MJMNGPIFHGG = ((!(MJMNGPIFHGG > num22)) ? num22 : MJMNGPIFHGG);
					JCNIIINOEHG = Mathf.Max(JCNIIINOEHG, AFEJPPDMPHE.fontInfo.CapHeight * num2);
				}
				if (GFIDNINNNAL == 0f)
				{
					num14 = ((!(num14 > num22)) ? num22 : num14);
				}
				m_textInfo.characterInfo[HEEDOMEABKA].BACHBACHNOF = false;
				if (num4 == 9 || (!char.IsWhiteSpace((char)num4) && num4 != 8203) || FHJFKDGNODI == HIPDBPNMONO.Sprite)
				{
					m_textInfo.characterInfo[HEEDOMEABKA].BACHBACHNOF = true;
					num13 = ((IFAFCDFNNJN == -1f) ? (iOOMPCBBCNK + 0.0001f - DPIAMOJPHPK - EPPLBJGIFEM) : Mathf.Min(iOOMPCBBCNK + 0.0001f - DPIAMOJPHPK - EPPLBJGIFEM, IFAFCDFNNJN));
					m_textInfo.lineInfo[FGMGAJAPPJC].PMKPIPBJCPI = DPIAMOJPHPK;
					bool flag9 = (FPDOALAOBLE & (KNOECCJHIDP)16) == (KNOECCJHIDP)16 || (FPDOALAOBLE & (KNOECCJHIDP)8) == (KNOECCJHIDP)8;
					if (Mathf.Abs(PLALFBMFEEC) + (m_isRightToLeft ? 0f : EOLJHINLKLO.xAdvance) * (1f - JDKKGHCOCJK) * ((num4 == 173) ? num19 : num2) > num13 * ((!flag9) ? 1f : 1.05f))
					{
						num12 = HEEDOMEABKA - 1;
						if (base.MHAGENKBNAN && HEEDOMEABKA != MIEJCGGDMLJ)
						{
							if (num16 == BLMLICONBCO.CCDKCOGLFBK || flag6)
							{
								if (m_enableAutoSizing && m_fontSize > m_fontSizeMin)
								{
									if (JDKKGHCOCJK < m_charWidthMaxAdj / 100f)
									{
										JEFPIONIJFI = 0;
										JDKKGHCOCJK += 0.01f;
										DLIBNLFHMKF();
										return;
									}
									KCNAALADKDH = m_fontSize;
									m_fontSize -= Mathf.Max((m_fontSize - FOGJMAGABCF) / 2f, 0.05f);
									m_fontSize = (float)(int)(Mathf.Max(m_fontSize, m_fontSizeMin) * 20f + 0.5f) / 20f;
									if (JEFPIONIJFI <= 20)
									{
										DLIBNLFHMKF();
									}
									return;
								}
								if (!CHPJNOEDAFE)
								{
									if (!flag7)
									{
										flag7 = true;
									}
									else
									{
										CHPJNOEDAFE = true;
									}
								}
								else
								{
									flag8 = true;
								}
							}
							i = NACMMBNPFJK(ref BLMLICONBCO);
							num16 = i;
							if (GMALEIECAPN[i] == 173)
							{
								OHEPFDPOBOF = true;
								GMALEIECAPN[i] = 45;
								DLIBNLFHMKF();
								return;
							}
							if (FGMGAJAPPJC > 0 && !OBBKAPGMGCN.ACBFEEBCHCF(NDEAABJECMK, DMKNFOCBDEG) && KODBBLNBFDO == -32767f && !GEGDAJAOKKA)
							{
								float num27 = NDEAABJECMK - DMKNFOCBDEG;
								NEPMEIHOFJI(MIEJCGGDMLJ, HEEDOMEABKA, num27);
								GFIDNINNNAL += num27;
								BLMLICONBCO.BGDIPDPPGOK = GFIDNINNNAL;
								BLMLICONBCO.FBCKCNHPKDH = NDEAABJECMK;
							}
							GEGDAJAOKKA = false;
							float num28 = NDEAABJECMK - GFIDNINNNAL;
							float num29 = ODBAKFJDCCP - GFIDNINNNAL;
							ONHFBKLHJIN = ((!(ONHFBKLHJIN < num29)) ? num29 : ONHFBKLHJIN);
							if (!flag5)
							{
								num15 = ONHFBKLHJIN;
							}
							if (m_useMaxVisibleDescender && (HEEDOMEABKA >= NGFIDCLHDJB || FGMGAJAPPJC >= DJCOAAAJIBO))
							{
								flag5 = true;
							}
							m_textInfo.lineInfo[FGMGAJAPPJC].IAJJNNOAMLG = MIEJCGGDMLJ;
							m_textInfo.lineInfo[FGMGAJAPPJC].CDLILHODCKP = (JGOLJOCMOGD = ((MIEJCGGDMLJ <= JGOLJOCMOGD) ? JGOLJOCMOGD : MIEJCGGDMLJ));
							m_textInfo.lineInfo[FGMGAJAPPJC].FNOFPOMADEM = (LFEILECBDDB = ((HEEDOMEABKA - 1 > 0) ? (HEEDOMEABKA - 1) : 0));
							m_textInfo.lineInfo[FGMGAJAPPJC].IKKAPEMFJBC = (GMLEPIKAEMI = ((GMLEPIKAEMI >= JGOLJOCMOGD) ? GMLEPIKAEMI : JGOLJOCMOGD));
							m_textInfo.lineInfo[FGMGAJAPPJC].NGNCDLJAEFL = m_textInfo.lineInfo[FGMGAJAPPJC].FNOFPOMADEM - m_textInfo.lineInfo[FGMGAJAPPJC].IAJJNNOAMLG + 1;
							m_textInfo.lineInfo[FGMGAJAPPJC].GKFMAOFOPOC = CILFEEOIDGC;
							m_textInfo.lineInfo[FGMGAJAPPJC].DIPEKGFBHMP.IJHGDODBFCD = new Vector2(m_textInfo.characterInfo[JGOLJOCMOGD].GKDEKLOCKNA.x, num29);
							m_textInfo.lineInfo[FGMGAJAPPJC].DIPEKGFBHMP.NHLJFKPLKLI = new Vector2(m_textInfo.characterInfo[GMLEPIKAEMI].BJONICNNGLI.x, num28);
							m_textInfo.lineInfo[FGMGAJAPPJC].EOFAGACBNFP = m_textInfo.lineInfo[FGMGAJAPPJC].DIPEKGFBHMP.NHLJFKPLKLI.x;
							m_textInfo.lineInfo[FGMGAJAPPJC].HHHMOGOKFHF = num13;
							m_textInfo.lineInfo[FGMGAJAPPJC].HDDCEFKKDHE = m_textInfo.characterInfo[GMLEPIKAEMI].MDKGJAGDLHC - (m_characterSpacing + AFEJPPDMPHE.normalSpacingOffset) * num2 - OMGEAPDMJBN;
							m_textInfo.lineInfo[FGMGAJAPPJC].EEGJFJDMBGN = 0f - GFIDNINNNAL;
							m_textInfo.lineInfo[FGMGAJAPPJC].MNKFKKODLLM = num28;
							m_textInfo.lineInfo[FGMGAJAPPJC].CALDBEMMLEA = num29;
							m_textInfo.lineInfo[FGMGAJAPPJC].HMEEHNLNJDD = num28 - num29 + num8 * num;
							MIEJCGGDMLJ = HEEDOMEABKA;
							CILFEEOIDGC = 0;
							LLBAPJLPCAN(ref EOKDMGOFOOH, i, HEEDOMEABKA - 1);
							FGMGAJAPPJC++;
							flag4 = true;
							if (FGMGAJAPPJC >= m_textInfo.lineInfo.Length)
							{
								KAGPEPEFMGI(FGMGAJAPPJC);
							}
							if (KODBBLNBFDO == -32767f)
							{
								float num30 = m_textInfo.characterInfo[HEEDOMEABKA].MNKFKKODLLM - m_textInfo.characterInfo[HEEDOMEABKA].CGAKKOEPCOG;
								num9 = 0f - ODBAKFJDCCP + num30 + (num8 + m_lineSpacing + FNABNBFMNME) * num;
								GFIDNINNNAL += num9;
								DMKNFOCBDEG = num30;
							}
							else
							{
								GFIDNINNNAL += KODBBLNBFDO + m_lineSpacing * num;
							}
							NDEAABJECMK = TMP_Text.BDOPFJFCOGB;
							ODBAKFJDCCP = TMP_Text.FEBIFNLEHEG;
							PLALFBMFEEC = GKEHAJKJCEF;
							continue;
						}
						if (m_enableAutoSizing && m_fontSize > m_fontSizeMin)
						{
							if (JDKKGHCOCJK < m_charWidthMaxAdj / 100f)
							{
								JEFPIONIJFI = 0;
								JDKKGHCOCJK += 0.01f;
								DLIBNLFHMKF();
								return;
							}
							KCNAALADKDH = m_fontSize;
							m_fontSize -= Mathf.Max((m_fontSize - FOGJMAGABCF) / 2f, 0.05f);
							m_fontSize = (float)(int)(Mathf.Max(m_fontSize, m_fontSizeMin) * 20f + 0.5f) / 20f;
							if (JEFPIONIJFI <= 20)
							{
								DLIBNLFHMKF();
							}
							return;
						}
						switch (m_overflowMode)
						{
						case OLMBEAODAPL.Overflow:
							if (HFGCJAKMLKE)
							{
								AKMDJLHHHHH();
							}
							break;
						case OLMBEAODAPL.Ellipsis:
							if (HFGCJAKMLKE)
							{
								AKMDJLHHHHH();
							}
							OHEPFDPOBOF = true;
							if (HEEDOMEABKA < 1)
							{
								m_textInfo.characterInfo[HEEDOMEABKA].BACHBACHNOF = false;
								break;
							}
							GMALEIECAPN[i - 1] = 8230;
							GMALEIECAPN[i] = 0;
							if (KHNLFLGPDJL != null)
							{
								m_textInfo.characterInfo[num12].AONJCHFEHOM = '…';
								m_textInfo.characterInfo[num12].EAHALNAKGJP = KHNLFLGPDJL;
								m_textInfo.characterInfo[num12].PIJNMJOHBIE = NDPGMAPHNNA[0].PIJNMJOHBIE;
								m_textInfo.characterInfo[num12].GHPFOPNNJOB = NDPGMAPHNNA[0].GHPFOPNNJOB;
								m_textInfo.characterInfo[num12].EKBHGEBCJHL = 0;
							}
							else
							{
								Debug.LogWarning("Unable to use Ellipsis character since it wasn't found in the current Font Asset [" + m_fontAsset.name + "]. Consider regenerating this font asset to include the Ellipsis character (u+2026).\nNote: Warnings can be disabled in the TMP Settings file.", this);
							}
							KOIMFMFOLII = num12 + 1;
							DLIBNLFHMKF();
							return;
						case OLMBEAODAPL.Masking:
							if (!HFGCJAKMLKE)
							{
								OCIPKCHCGMP();
							}
							break;
						case OLMBEAODAPL.ScrollRect:
							if (!HFGCJAKMLKE)
							{
								OCIPKCHCGMP();
							}
							break;
						case OLMBEAODAPL.Truncate:
							if (HFGCJAKMLKE)
							{
								AKMDJLHHHHH();
							}
							m_textInfo.characterInfo[HEEDOMEABKA].BACHBACHNOF = false;
							break;
						}
					}
					if (num4 != 9)
					{
						Color32 nEJNJJAIFNG = ((!m_overrideHtmlColors) ? EPCFNBCMCHK : m_fontColor32);
						if (FHJFKDGNODI == HIPDBPNMONO.Character)
						{
							PKLHKHJKHGM(num5, num6, nEJNJJAIFNG);
						}
						else if (FHJFKDGNODI == HIPDBPNMONO.Sprite)
						{
							LIMFCMHGGPI(nEJNJJAIFNG);
						}
					}
					else
					{
						m_textInfo.characterInfo[HEEDOMEABKA].BACHBACHNOF = false;
						GMLEPIKAEMI = HEEDOMEABKA;
						m_textInfo.lineInfo[FGMGAJAPPJC].EAMAFAMPCGE++;
						m_textInfo.spaceCount++;
					}
					if (m_textInfo.characterInfo[HEEDOMEABKA].BACHBACHNOF && num4 != 173)
					{
						if (flag4)
						{
							flag4 = false;
							JGOLJOCMOGD = HEEDOMEABKA;
						}
						CILFEEOIDGC++;
						GMLEPIKAEMI = HEEDOMEABKA;
					}
				}
				else if ((num4 == 10 || char.IsSeparator((char)num4)) && num4 != 173 && num4 != 8203 && num4 != 8288)
				{
					m_textInfo.lineInfo[FGMGAJAPPJC].EAMAFAMPCGE++;
					m_textInfo.spaceCount++;
				}
				if (FGMGAJAPPJC > 0 && !OBBKAPGMGCN.ACBFEEBCHCF(NDEAABJECMK, DMKNFOCBDEG) && KODBBLNBFDO == -32767f && !GEGDAJAOKKA)
				{
					float num31 = NDEAABJECMK - DMKNFOCBDEG;
					NEPMEIHOFJI(MIEJCGGDMLJ, HEEDOMEABKA, num31);
					num24 -= num31;
					GFIDNINNNAL += num31;
					DMKNFOCBDEG += num31;
					BLMLICONBCO.BGDIPDPPGOK = GFIDNINNNAL;
					BLMLICONBCO.FBCKCNHPKDH = DMKNFOCBDEG;
				}
				m_textInfo.characterInfo[HEEDOMEABKA].HGCMIDFMKHD = (short)FGMGAJAPPJC;
				m_textInfo.characterInfo[HEEDOMEABKA].LJABKMPPOML = (short)BHJLNHKINKN;
				if ((num4 != 10 && num4 != 13 && num4 != 8230) || m_textInfo.lineInfo[FGMGAJAPPJC].NGNCDLJAEFL == 1)
				{
					m_textInfo.lineInfo[FGMGAJAPPJC].JOPPDFNGJBM = FPDOALAOBLE;
				}
				if (MJMNGPIFHGG - num24 > nNFECNKNNLL + 0.0001f)
				{
					if (m_enableAutoSizing && FNABNBFMNME > m_lineSpacingMax && FGMGAJAPPJC > 0)
					{
						JEFPIONIJFI = 0;
						FNABNBFMNME -= 1f;
						DLIBNLFHMKF();
						return;
					}
					if (m_enableAutoSizing && m_fontSize > m_fontSizeMin)
					{
						KCNAALADKDH = m_fontSize;
						m_fontSize -= Mathf.Max((m_fontSize - FOGJMAGABCF) / 2f, 0.05f);
						m_fontSize = (float)(int)(Mathf.Max(m_fontSize, m_fontSizeMin) * 20f + 0.5f) / 20f;
						if (JEFPIONIJFI <= 20)
						{
							DLIBNLFHMKF();
						}
						return;
					}
					if (m_firstOverflowCharacterIndex == -1)
					{
						m_firstOverflowCharacterIndex = HEEDOMEABKA;
					}
					switch (m_overflowMode)
					{
					case OLMBEAODAPL.Overflow:
						if (HFGCJAKMLKE)
						{
							AKMDJLHHHHH();
						}
						break;
					case OLMBEAODAPL.Ellipsis:
						if (HFGCJAKMLKE)
						{
							AKMDJLHHHHH();
						}
						if (FGMGAJAPPJC > 0)
						{
							GMALEIECAPN[m_textInfo.characterInfo[num12].EHJNMODJEAN] = 8230;
							GMALEIECAPN[m_textInfo.characterInfo[num12].EHJNMODJEAN + 1] = 0;
							if (KHNLFLGPDJL != null)
							{
								m_textInfo.characterInfo[num12].AONJCHFEHOM = '…';
								m_textInfo.characterInfo[num12].EAHALNAKGJP = KHNLFLGPDJL;
								m_textInfo.characterInfo[num12].PIJNMJOHBIE = NDPGMAPHNNA[0].PIJNMJOHBIE;
								m_textInfo.characterInfo[num12].GHPFOPNNJOB = NDPGMAPHNNA[0].GHPFOPNNJOB;
								m_textInfo.characterInfo[num12].EKBHGEBCJHL = 0;
							}
							else
							{
								Debug.LogWarning("Unable to use Ellipsis character since it wasn't found in the current Font Asset [" + m_fontAsset.name + "]. Consider regenerating this font asset to include the Ellipsis character (u+2026).\nNote: Warnings can be disabled in the TMP Settings file.", this);
							}
							KOIMFMFOLII = num12 + 1;
							DLIBNLFHMKF();
							OHEPFDPOBOF = true;
						}
						else
						{
							ClearMesh();
						}
						return;
					case OLMBEAODAPL.Masking:
						if (!HFGCJAKMLKE)
						{
							OCIPKCHCGMP();
						}
						break;
					case OLMBEAODAPL.ScrollRect:
						if (!HFGCJAKMLKE)
						{
							OCIPKCHCGMP();
						}
						break;
					case OLMBEAODAPL.Truncate:
						if (HFGCJAKMLKE)
						{
							AKMDJLHHHHH();
						}
						if (FGMGAJAPPJC > 0)
						{
							GMALEIECAPN[m_textInfo.characterInfo[num12].EHJNMODJEAN + 1] = 0;
							KOIMFMFOLII = num12 + 1;
							DLIBNLFHMKF();
							OHEPFDPOBOF = true;
						}
						else
						{
							ClearMesh();
						}
						return;
					case OLMBEAODAPL.Page:
						if (HFGCJAKMLKE)
						{
							AKMDJLHHHHH();
						}
						if (num4 == 13 || num4 == 10)
						{
							break;
						}
						if (i == 0)
						{
							ClearMesh();
							return;
						}
						if (num11 == i)
						{
							GMALEIECAPN[i] = 0;
							OHEPFDPOBOF = true;
						}
						num11 = i;
						i = NACMMBNPFJK(ref EOKDMGOFOOH);
						GEGDAJAOKKA = true;
						PLALFBMFEEC = GKEHAJKJCEF;
						GFIDNINNNAL = 0f;
						MJMNGPIFHGG = 0f;
						num14 = 0f;
						FGMGAJAPPJC++;
						BHJLNHKINKN++;
						continue;
					case OLMBEAODAPL.Linked:
						if (m_linkedTextComponent != null)
						{
							m_linkedTextComponent.FCJBBPHFNPJ = base.FCJBBPHFNPJ;
							m_linkedTextComponent.CPAJEAIKNJL = HEEDOMEABKA;
							m_linkedTextComponent.ForceMeshUpdate();
						}
						if (FGMGAJAPPJC > 0)
						{
							GMALEIECAPN[i] = 0;
							KOIMFMFOLII = HEEDOMEABKA;
							DLIBNLFHMKF();
							OHEPFDPOBOF = true;
						}
						else
						{
							ClearMesh();
						}
						return;
					}
				}
				if (num4 == 9)
				{
					float num32 = AFEJPPDMPHE.fontInfo.TabWidth * num2;
					float num33 = Mathf.Ceil(PLALFBMFEEC / num32) * num32;
					PLALFBMFEEC = ((!(num33 > PLALFBMFEEC)) ? (PLALFBMFEEC + num32) : num33);
				}
				else if (CADPBEPINNM != 0f)
				{
					PLALFBMFEEC += (CADPBEPINNM - num20 + (m_characterSpacing + AFEJPPDMPHE.normalSpacingOffset) * num2 + OMGEAPDMJBN) * (1f - JDKKGHCOCJK);
					if (char.IsWhiteSpace((char)num4) || num4 == 8203)
					{
						PLALFBMFEEC += m_wordSpacing * num2;
					}
				}
				else if (!m_isRightToLeft)
				{
					PLALFBMFEEC += ((EOLJHINLKLO.xAdvance * num7 + m_characterSpacing + AFEJPPDMPHE.normalSpacingOffset) * num2 + OMGEAPDMJBN) * (1f - JDKKGHCOCJK);
					if (char.IsWhiteSpace((char)num4) || num4 == 8203)
					{
						PLALFBMFEEC += m_wordSpacing * num2;
					}
				}
				m_textInfo.characterInfo[HEEDOMEABKA].MDKGJAGDLHC = PLALFBMFEEC;
				if (num4 == 13)
				{
					PLALFBMFEEC = GKEHAJKJCEF;
				}
				if (num4 == 10 || HEEDOMEABKA == kOIMFMFOLII - 1)
				{
					if (FGMGAJAPPJC > 0 && !OBBKAPGMGCN.ACBFEEBCHCF(NDEAABJECMK, DMKNFOCBDEG) && KODBBLNBFDO == -32767f && !GEGDAJAOKKA)
					{
						float num34 = NDEAABJECMK - DMKNFOCBDEG;
						NEPMEIHOFJI(MIEJCGGDMLJ, HEEDOMEABKA, num34);
						num24 -= num34;
						GFIDNINNNAL += num34;
					}
					GEGDAJAOKKA = false;
					float num35 = NDEAABJECMK - GFIDNINNNAL;
					float num36 = ODBAKFJDCCP - GFIDNINNNAL;
					ONHFBKLHJIN = ((!(ONHFBKLHJIN < num36)) ? num36 : ONHFBKLHJIN);
					if (!flag5)
					{
						num15 = ONHFBKLHJIN;
					}
					if (m_useMaxVisibleDescender && (HEEDOMEABKA >= NGFIDCLHDJB || FGMGAJAPPJC >= DJCOAAAJIBO))
					{
						flag5 = true;
					}
					m_textInfo.lineInfo[FGMGAJAPPJC].IAJJNNOAMLG = MIEJCGGDMLJ;
					m_textInfo.lineInfo[FGMGAJAPPJC].CDLILHODCKP = (JGOLJOCMOGD = ((MIEJCGGDMLJ <= JGOLJOCMOGD) ? JGOLJOCMOGD : MIEJCGGDMLJ));
					m_textInfo.lineInfo[FGMGAJAPPJC].FNOFPOMADEM = (LFEILECBDDB = HEEDOMEABKA);
					m_textInfo.lineInfo[FGMGAJAPPJC].IKKAPEMFJBC = (GMLEPIKAEMI = ((GMLEPIKAEMI >= JGOLJOCMOGD) ? GMLEPIKAEMI : JGOLJOCMOGD));
					m_textInfo.lineInfo[FGMGAJAPPJC].NGNCDLJAEFL = m_textInfo.lineInfo[FGMGAJAPPJC].FNOFPOMADEM - m_textInfo.lineInfo[FGMGAJAPPJC].IAJJNNOAMLG + 1;
					m_textInfo.lineInfo[FGMGAJAPPJC].GKFMAOFOPOC = CILFEEOIDGC;
					m_textInfo.lineInfo[FGMGAJAPPJC].DIPEKGFBHMP.IJHGDODBFCD = new Vector2(m_textInfo.characterInfo[JGOLJOCMOGD].GKDEKLOCKNA.x, num36);
					m_textInfo.lineInfo[FGMGAJAPPJC].DIPEKGFBHMP.NHLJFKPLKLI = new Vector2(m_textInfo.characterInfo[GMLEPIKAEMI].BJONICNNGLI.x, num35);
					m_textInfo.lineInfo[FGMGAJAPPJC].EOFAGACBNFP = m_textInfo.lineInfo[FGMGAJAPPJC].DIPEKGFBHMP.NHLJFKPLKLI.x - num5 * num2;
					m_textInfo.lineInfo[FGMGAJAPPJC].HHHMOGOKFHF = num13;
					if (m_textInfo.lineInfo[FGMGAJAPPJC].NGNCDLJAEFL == 1)
					{
						m_textInfo.lineInfo[FGMGAJAPPJC].JOPPDFNGJBM = FPDOALAOBLE;
					}
					if (m_textInfo.characterInfo[GMLEPIKAEMI].BACHBACHNOF)
					{
						m_textInfo.lineInfo[FGMGAJAPPJC].HDDCEFKKDHE = m_textInfo.characterInfo[GMLEPIKAEMI].MDKGJAGDLHC - (m_characterSpacing + AFEJPPDMPHE.normalSpacingOffset) * num2 - OMGEAPDMJBN;
					}
					else
					{
						m_textInfo.lineInfo[FGMGAJAPPJC].HDDCEFKKDHE = m_textInfo.characterInfo[LFEILECBDDB].MDKGJAGDLHC - (m_characterSpacing + AFEJPPDMPHE.normalSpacingOffset) * num2 - OMGEAPDMJBN;
					}
					m_textInfo.lineInfo[FGMGAJAPPJC].EEGJFJDMBGN = 0f - GFIDNINNNAL;
					m_textInfo.lineInfo[FGMGAJAPPJC].MNKFKKODLLM = num35;
					m_textInfo.lineInfo[FGMGAJAPPJC].CALDBEMMLEA = num36;
					m_textInfo.lineInfo[FGMGAJAPPJC].HMEEHNLNJDD = num35 - num36 + num8 * num;
					MIEJCGGDMLJ = HEEDOMEABKA + 1;
					CILFEEOIDGC = 0;
					if (num4 == 10)
					{
						LLBAPJLPCAN(ref EOKDMGOFOOH, i, HEEDOMEABKA);
						LLBAPJLPCAN(ref BLMLICONBCO, i, HEEDOMEABKA);
						FGMGAJAPPJC++;
						flag4 = true;
						if (FGMGAJAPPJC >= m_textInfo.lineInfo.Length)
						{
							KAGPEPEFMGI(FGMGAJAPPJC);
						}
						if (KODBBLNBFDO == -32767f)
						{
							num9 = 0f - ODBAKFJDCCP + num22 + (num8 + m_lineSpacing + m_paragraphSpacing + FNABNBFMNME) * num;
							GFIDNINNNAL += num9;
						}
						else
						{
							GFIDNINNNAL += KODBBLNBFDO + (m_lineSpacing + m_paragraphSpacing) * num;
						}
						NDEAABJECMK = TMP_Text.BDOPFJFCOGB;
						ODBAKFJDCCP = TMP_Text.FEBIFNLEHEG;
						DMKNFOCBDEG = num22;
						PLALFBMFEEC = KGDNHOEOOHO + GKEHAJKJCEF;
						num12 = HEEDOMEABKA - 1;
						HEEDOMEABKA++;
						continue;
					}
				}
				if (m_textInfo.characterInfo[HEEDOMEABKA].BACHBACHNOF)
				{
					NBHJNBHINPH.IJHGDODBFCD.x = Mathf.Min(NBHJNBHINPH.IJHGDODBFCD.x, m_textInfo.characterInfo[HEEDOMEABKA].GKDEKLOCKNA.x);
					NBHJNBHINPH.IJHGDODBFCD.y = Mathf.Min(NBHJNBHINPH.IJHGDODBFCD.y, m_textInfo.characterInfo[HEEDOMEABKA].GKDEKLOCKNA.y);
					NBHJNBHINPH.NHLJFKPLKLI.x = Mathf.Max(NBHJNBHINPH.NHLJFKPLKLI.x, m_textInfo.characterInfo[HEEDOMEABKA].BJONICNNGLI.x);
					NBHJNBHINPH.NHLJFKPLKLI.y = Mathf.Max(NBHJNBHINPH.NHLJFKPLKLI.y, m_textInfo.characterInfo[HEEDOMEABKA].BJONICNNGLI.y);
				}
				if (m_overflowMode == OLMBEAODAPL.Page && num4 != 13 && num4 != 10)
				{
					if (BHJLNHKINKN + 1 > m_textInfo.pageInfo.Length)
					{
						TMP_TextInfo.NKMKBLFBOFC(ref m_textInfo.pageInfo, BHJLNHKINKN + 1, true);
					}
					m_textInfo.pageInfo[BHJLNHKINKN].MNKFKKODLLM = num14;
					m_textInfo.pageInfo[BHJLNHKINKN].CALDBEMMLEA = ((!(num23 < m_textInfo.pageInfo[BHJLNHKINKN].CALDBEMMLEA)) ? m_textInfo.pageInfo[BHJLNHKINKN].CALDBEMMLEA : num23);
					if (BHJLNHKINKN == 0 && HEEDOMEABKA == 0)
					{
						m_textInfo.pageInfo[BHJLNHKINKN].IAJJNNOAMLG = HEEDOMEABKA;
					}
					else if (HEEDOMEABKA > 0 && BHJLNHKINKN != m_textInfo.characterInfo[HEEDOMEABKA - 1].LJABKMPPOML)
					{
						m_textInfo.pageInfo[BHJLNHKINKN - 1].FNOFPOMADEM = HEEDOMEABKA - 1;
						m_textInfo.pageInfo[BHJLNHKINKN].IAJJNNOAMLG = HEEDOMEABKA;
					}
					else if (HEEDOMEABKA == kOIMFMFOLII - 1)
					{
						m_textInfo.pageInfo[BHJLNHKINKN].FNOFPOMADEM = HEEDOMEABKA;
					}
				}
				if (m_enableWordWrapping || m_overflowMode == OLMBEAODAPL.Truncate || m_overflowMode == OLMBEAODAPL.Ellipsis)
				{
					if ((char.IsWhiteSpace((char)num4) || num4 == 8203 || num4 == 45 || num4 == 173) && (!PIABLFACDIO || flag7) && num4 != 160 && num4 != 8209 && num4 != 8239 && num4 != 8288)
					{
						LLBAPJLPCAN(ref BLMLICONBCO, i, HEEDOMEABKA);
						CHPJNOEDAFE = false;
						flag6 = false;
					}
					else if (((num4 > 4352 && num4 < 4607) || (num4 > 11904 && num4 < 40959) || (num4 > 43360 && num4 < 43391) || (num4 > 44032 && num4 < 55295) || (num4 > 63744 && num4 < 64255) || (num4 > 65072 && num4 < 65103) || (num4 > 65280 && num4 < 65519)) && !PIABLFACDIO)
					{
						if (flag6 || flag8 || (!TMP_Settings.linebreakingRules.INNIIOIHLLF.ContainsKey(num4) && HEEDOMEABKA < kOIMFMFOLII - 1 && !TMP_Settings.linebreakingRules.GJEMIJJBCOL.ContainsKey(m_textInfo.characterInfo[HEEDOMEABKA + 1].AONJCHFEHOM)))
						{
							LLBAPJLPCAN(ref BLMLICONBCO, i, HEEDOMEABKA);
							CHPJNOEDAFE = false;
							flag6 = false;
						}
					}
					else if (flag6 || CHPJNOEDAFE || flag8)
					{
						LLBAPJLPCAN(ref BLMLICONBCO, i, HEEDOMEABKA);
					}
				}
				HEEDOMEABKA++;
			}
			num3 = KCNAALADKDH - FOGJMAGABCF;
			if (!CHPJNOEDAFE && m_enableAutoSizing && num3 > 0.051f && m_fontSize < m_fontSizeMax)
			{
				FOGJMAGABCF = m_fontSize;
				m_fontSize += Mathf.Max((KCNAALADKDH - m_fontSize) / 2f, 0.05f);
				m_fontSize = (float)(int)(Mathf.Min(m_fontSize, m_fontSizeMax) * 20f + 0.5f) / 20f;
				if (JEFPIONIJFI <= 20)
				{
					DLIBNLFHMKF();
				}
				return;
			}
			CHPJNOEDAFE = false;
			if (HEEDOMEABKA == 0)
			{
				ClearMesh();
				FFCFAICENOB.EDOBMOAFCFA(this);
				return;
			}
			int EHJNMODJEAN = NDPGMAPHNNA[0].OLEEIKHIDIB * 4;
			m_textInfo.meshInfo[0].BOPEPLONIFL(false);
			Vector3 vector9 = Vector3.zero;
			Vector3[] lJPBNPONJJJ = LJPBNPONJJJ;
			switch (m_textAlignment)
			{
			case KNOECCJHIDP.TopLeft:
			case KNOECCJHIDP.Top:
			case KNOECCJHIDP.TopRight:
			case KNOECCJHIDP.TopJustified:
			case KNOECCJHIDP.TopFlush:
			case KNOECCJHIDP.TopGeoAligned:
				vector9 = ((m_overflowMode == OLMBEAODAPL.Page) ? (lJPBNPONJJJ[1] + new Vector3(margin.x, 0f - m_textInfo.pageInfo[num10].MNKFKKODLLM - margin.y, 0f)) : (lJPBNPONJJJ[1] + new Vector3(margin.x, 0f - MJMNGPIFHGG - margin.y, 0f)));
				break;
			case KNOECCJHIDP.Left:
			case KNOECCJHIDP.Center:
			case KNOECCJHIDP.Right:
			case KNOECCJHIDP.Justified:
			case KNOECCJHIDP.Flush:
			case KNOECCJHIDP.CenterGeoAligned:
				vector9 = ((m_overflowMode == OLMBEAODAPL.Page) ? ((lJPBNPONJJJ[0] + lJPBNPONJJJ[1]) / 2f + new Vector3(margin.x, 0f - (m_textInfo.pageInfo[num10].MNKFKKODLLM + margin.y + m_textInfo.pageInfo[num10].CALDBEMMLEA - margin.w) / 2f, 0f)) : ((lJPBNPONJJJ[0] + lJPBNPONJJJ[1]) / 2f + new Vector3(margin.x, 0f - (MJMNGPIFHGG + margin.y + num15 - margin.w) / 2f, 0f)));
				break;
			case KNOECCJHIDP.BottomLeft:
			case KNOECCJHIDP.Bottom:
			case KNOECCJHIDP.BottomRight:
			case KNOECCJHIDP.BottomJustified:
			case KNOECCJHIDP.BottomFlush:
			case KNOECCJHIDP.BottomGeoAligned:
				vector9 = ((m_overflowMode == OLMBEAODAPL.Page) ? (lJPBNPONJJJ[0] + new Vector3(margin.x, 0f - m_textInfo.pageInfo[num10].CALDBEMMLEA + margin.w, 0f)) : (lJPBNPONJJJ[0] + new Vector3(margin.x, 0f - num15 + margin.w, 0f)));
				break;
			case KNOECCJHIDP.BaselineLeft:
			case KNOECCJHIDP.Baseline:
			case KNOECCJHIDP.BaselineRight:
			case KNOECCJHIDP.BaselineJustified:
			case KNOECCJHIDP.BaselineFlush:
			case KNOECCJHIDP.BaselineGeoAligned:
				vector9 = (lJPBNPONJJJ[0] + lJPBNPONJJJ[1]) / 2f + new Vector3(margin.x, 0f, 0f);
				break;
			case KNOECCJHIDP.MidlineLeft:
			case KNOECCJHIDP.Midline:
			case KNOECCJHIDP.MidlineRight:
			case KNOECCJHIDP.MidlineJustified:
			case KNOECCJHIDP.MidlineFlush:
			case KNOECCJHIDP.MidlineGeoAligned:
				vector9 = (lJPBNPONJJJ[0] + lJPBNPONJJJ[1]) / 2f + new Vector3(margin.x, 0f - (NBHJNBHINPH.NHLJFKPLKLI.y + margin.y + NBHJNBHINPH.IJHGDODBFCD.y - margin.w) / 2f, 0f);
				break;
			case KNOECCJHIDP.CaplineLeft:
			case KNOECCJHIDP.Capline:
			case KNOECCJHIDP.CaplineRight:
			case KNOECCJHIDP.CaplineJustified:
			case KNOECCJHIDP.CaplineFlush:
			case KNOECCJHIDP.CaplineGeoAligned:
				vector9 = (lJPBNPONJJJ[0] + lJPBNPONJJJ[1]) / 2f + new Vector3(margin.x, 0f - (JCNIIINOEHG - margin.y - margin.w) / 2f, 0f);
				break;
			}
			Vector3 vector10 = Vector3.zero;
			Vector3 zero3 = Vector3.zero;
			int kBAFACHPHMF = 0;
			int kBAFACHPHMF2 = 0;
			int num37 = 0;
			int num38 = 0;
			int num39 = 0;
			bool flag10 = false;
			bool flag11 = false;
			int num40 = 0;
			int num41 = 0;
			bool flag12 = !(CNEODGLFFPG.worldCamera == null);
			float num42 = (JFGEKNMANOJ = base.ANLKLKAINEO.lossyScale.y);
			RenderMode renderMode = CNEODGLFFPG.renderMode;
			float scaleFactor = CNEODGLFFPG.scaleFactor;
			Color32 color = Color.white;
			Color32 fNHEFDBFBMN = Color.white;
			Color32 color2 = new Color32(byte.MaxValue, byte.MaxValue, 0, 64);
			float num43 = 0f;
			float num44 = 0f;
			float num45 = 0f;
			float num46 = 0f;
			float num47 = TMP_Text.FEBIFNLEHEG;
			int num48 = 0;
			float num49 = 0f;
			float num50 = 0f;
			float bCIHLCMFAEK = 0f;
			MGLLLPMKGDA[] characterInfo = m_textInfo.characterInfo;
			for (int j = 0; j < HEEDOMEABKA; j++)
			{
				TMP_FontAsset pIJNMJOHBIE = characterInfo[j].PIJNMJOHBIE;
				char aONJCHFEHOM2 = characterInfo[j].AONJCHFEHOM;
				int hGCMIDFMKHD = characterInfo[j].HGCMIDFMKHD;
				CFLMKMOJIJI cFLMKMOJIJI = m_textInfo.lineInfo[hGCMIDFMKHD];
				num38 = hGCMIDFMKHD + 1;
				KNOECCJHIDP jOPPDFNGJBM = cFLMKMOJIJI.JOPPDFNGJBM;
				switch (jOPPDFNGJBM)
				{
				case KNOECCJHIDP.TopLeft:
				case KNOECCJHIDP.Left:
				case KNOECCJHIDP.BottomLeft:
				case KNOECCJHIDP.BaselineLeft:
				case KNOECCJHIDP.MidlineLeft:
				case KNOECCJHIDP.CaplineLeft:
					vector10 = (m_isRightToLeft ? new Vector3(0f - cFLMKMOJIJI.HDDCEFKKDHE, 0f, 0f) : new Vector3(cFLMKMOJIJI.PMKPIPBJCPI, 0f, 0f));
					break;
				case KNOECCJHIDP.Top:
				case KNOECCJHIDP.Center:
				case KNOECCJHIDP.Bottom:
				case KNOECCJHIDP.Baseline:
				case KNOECCJHIDP.Midline:
				case KNOECCJHIDP.Capline:
					vector10 = new Vector3(cFLMKMOJIJI.PMKPIPBJCPI + cFLMKMOJIJI.HHHMOGOKFHF / 2f - cFLMKMOJIJI.HDDCEFKKDHE / 2f, 0f, 0f);
					break;
				case KNOECCJHIDP.TopGeoAligned:
				case KNOECCJHIDP.CenterGeoAligned:
				case KNOECCJHIDP.BottomGeoAligned:
				case KNOECCJHIDP.BaselineGeoAligned:
				case KNOECCJHIDP.MidlineGeoAligned:
				case KNOECCJHIDP.CaplineGeoAligned:
					vector10 = new Vector3(cFLMKMOJIJI.PMKPIPBJCPI + cFLMKMOJIJI.HHHMOGOKFHF / 2f - (cFLMKMOJIJI.DIPEKGFBHMP.IJHGDODBFCD.x + cFLMKMOJIJI.DIPEKGFBHMP.NHLJFKPLKLI.x) / 2f, 0f, 0f);
					break;
				case KNOECCJHIDP.TopRight:
				case KNOECCJHIDP.Right:
				case KNOECCJHIDP.BottomRight:
				case KNOECCJHIDP.BaselineRight:
				case KNOECCJHIDP.MidlineRight:
				case KNOECCJHIDP.CaplineRight:
					vector10 = (m_isRightToLeft ? new Vector3(cFLMKMOJIJI.PMKPIPBJCPI + cFLMKMOJIJI.HHHMOGOKFHF, 0f, 0f) : new Vector3(cFLMKMOJIJI.PMKPIPBJCPI + cFLMKMOJIJI.HHHMOGOKFHF - cFLMKMOJIJI.HDDCEFKKDHE, 0f, 0f));
					break;
				case KNOECCJHIDP.TopJustified:
				case KNOECCJHIDP.TopFlush:
				case KNOECCJHIDP.Justified:
				case KNOECCJHIDP.Flush:
				case KNOECCJHIDP.BottomJustified:
				case KNOECCJHIDP.BottomFlush:
				case KNOECCJHIDP.BaselineJustified:
				case KNOECCJHIDP.BaselineFlush:
				case KNOECCJHIDP.MidlineJustified:
				case KNOECCJHIDP.MidlineFlush:
				case KNOECCJHIDP.CaplineJustified:
				case KNOECCJHIDP.CaplineFlush:
				{
					if (aONJCHFEHOM2 == '\u00ad' || aONJCHFEHOM2 == '\u200b' || aONJCHFEHOM2 == '\u2060')
					{
						break;
					}
					char aONJCHFEHOM3 = characterInfo[cFLMKMOJIJI.FNOFPOMADEM].AONJCHFEHOM;
					bool flag13 = (jOPPDFNGJBM & (KNOECCJHIDP)16) == (KNOECCJHIDP)16;
					if ((!char.IsControl(aONJCHFEHOM3) && hGCMIDFMKHD < FGMGAJAPPJC) || flag13 || cFLMKMOJIJI.HDDCEFKKDHE > cFLMKMOJIJI.HHHMOGOKFHF)
					{
						if (hGCMIDFMKHD != num39 || j == 0 || j == m_firstVisibleCharacter)
						{
							vector10 = (m_isRightToLeft ? new Vector3(cFLMKMOJIJI.PMKPIPBJCPI + cFLMKMOJIJI.HHHMOGOKFHF, 0f, 0f) : new Vector3(cFLMKMOJIJI.PMKPIPBJCPI, 0f, 0f));
							flag10 = (char.IsSeparator(aONJCHFEHOM2) ? true : false);
							break;
						}
						float num51 = (m_isRightToLeft ? (cFLMKMOJIJI.HHHMOGOKFHF + cFLMKMOJIJI.HDDCEFKKDHE) : (cFLMKMOJIJI.HHHMOGOKFHF - cFLMKMOJIJI.HDDCEFKKDHE));
						int num52 = cFLMKMOJIJI.GKFMAOFOPOC - 1;
						int num53 = ((!characterInfo[cFLMKMOJIJI.FNOFPOMADEM].BACHBACHNOF) ? (cFLMKMOJIJI.EAMAFAMPCGE - 1) : cFLMKMOJIJI.EAMAFAMPCGE);
						if (flag10)
						{
							num53--;
							num52++;
						}
						float num54 = ((num53 <= 0) ? 1f : m_wordWrappingRatios);
						if (num53 < 1)
						{
							num53 = 1;
						}
						if (aONJCHFEHOM2 == '\t' || char.IsSeparator(aONJCHFEHOM2))
						{
							if (!m_isRightToLeft)
							{
								vector10 += new Vector3(num51 * (1f - num54) / (float)num53, 0f, 0f);
							}
							else
							{
								vector10 -= new Vector3(num51 * (1f - num54) / (float)num53, 0f, 0f);
							}
						}
						else if (!m_isRightToLeft)
						{
							vector10 += new Vector3(num51 * num54 / (float)num52, 0f, 0f);
						}
						else
						{
							vector10 -= new Vector3(num51 * num54 / (float)num52, 0f, 0f);
						}
					}
					else
					{
						vector10 = (m_isRightToLeft ? new Vector3(cFLMKMOJIJI.PMKPIPBJCPI + cFLMKMOJIJI.HHHMOGOKFHF, 0f, 0f) : new Vector3(cFLMKMOJIJI.PMKPIPBJCPI, 0f, 0f));
					}
					break;
				}
				}
				zero3 = vector9 + vector10;
				bool bACHBACHNOF = characterInfo[j].BACHBACHNOF;
				if (bACHBACHNOF)
				{
					HIPDBPNMONO mGBPNBKJOJL = characterInfo[j].MGBPNBKJOJL;
					switch (mGBPNBKJOJL)
					{
					case HIPDBPNMONO.Character:
					{
						FEBFBNHKLAA dIPEKGFBHMP = cFLMKMOJIJI.DIPEKGFBHMP;
						float num55 = m_uvLineOffset * (float)hGCMIDFMKHD % 1f;
						switch (m_horizontalMapping)
						{
						case NBJIALGHGKG.Character:
							characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.x = 0f;
							characterInfo[j].DNOLPLGACHH.NHFBHNEIGIP.x = 0f;
							characterInfo[j].HKBAKLGBMDE.NHFBHNEIGIP.x = 1f;
							characterInfo[j].HOCKPNNAIAL.NHFBHNEIGIP.x = 1f;
							break;
						case NBJIALGHGKG.Line:
							if (m_textAlignment != KNOECCJHIDP.Justified)
							{
								characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.x = (characterInfo[j].BEOPBIAPDBP.LDMDBPLADGD.x - dIPEKGFBHMP.IJHGDODBFCD.x) / (dIPEKGFBHMP.NHLJFKPLKLI.x - dIPEKGFBHMP.IJHGDODBFCD.x) + num55;
								characterInfo[j].DNOLPLGACHH.NHFBHNEIGIP.x = (characterInfo[j].DNOLPLGACHH.LDMDBPLADGD.x - dIPEKGFBHMP.IJHGDODBFCD.x) / (dIPEKGFBHMP.NHLJFKPLKLI.x - dIPEKGFBHMP.IJHGDODBFCD.x) + num55;
								characterInfo[j].HKBAKLGBMDE.NHFBHNEIGIP.x = (characterInfo[j].HKBAKLGBMDE.LDMDBPLADGD.x - dIPEKGFBHMP.IJHGDODBFCD.x) / (dIPEKGFBHMP.NHLJFKPLKLI.x - dIPEKGFBHMP.IJHGDODBFCD.x) + num55;
								characterInfo[j].HOCKPNNAIAL.NHFBHNEIGIP.x = (characterInfo[j].HOCKPNNAIAL.LDMDBPLADGD.x - dIPEKGFBHMP.IJHGDODBFCD.x) / (dIPEKGFBHMP.NHLJFKPLKLI.x - dIPEKGFBHMP.IJHGDODBFCD.x) + num55;
							}
							else
							{
								characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.x = (characterInfo[j].BEOPBIAPDBP.LDMDBPLADGD.x + vector10.x - NBHJNBHINPH.IJHGDODBFCD.x) / (NBHJNBHINPH.NHLJFKPLKLI.x - NBHJNBHINPH.IJHGDODBFCD.x) + num55;
								characterInfo[j].DNOLPLGACHH.NHFBHNEIGIP.x = (characterInfo[j].DNOLPLGACHH.LDMDBPLADGD.x + vector10.x - NBHJNBHINPH.IJHGDODBFCD.x) / (NBHJNBHINPH.NHLJFKPLKLI.x - NBHJNBHINPH.IJHGDODBFCD.x) + num55;
								characterInfo[j].HKBAKLGBMDE.NHFBHNEIGIP.x = (characterInfo[j].HKBAKLGBMDE.LDMDBPLADGD.x + vector10.x - NBHJNBHINPH.IJHGDODBFCD.x) / (NBHJNBHINPH.NHLJFKPLKLI.x - NBHJNBHINPH.IJHGDODBFCD.x) + num55;
								characterInfo[j].HOCKPNNAIAL.NHFBHNEIGIP.x = (characterInfo[j].HOCKPNNAIAL.LDMDBPLADGD.x + vector10.x - NBHJNBHINPH.IJHGDODBFCD.x) / (NBHJNBHINPH.NHLJFKPLKLI.x - NBHJNBHINPH.IJHGDODBFCD.x) + num55;
							}
							break;
						case NBJIALGHGKG.Paragraph:
							characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.x = (characterInfo[j].BEOPBIAPDBP.LDMDBPLADGD.x + vector10.x - NBHJNBHINPH.IJHGDODBFCD.x) / (NBHJNBHINPH.NHLJFKPLKLI.x - NBHJNBHINPH.IJHGDODBFCD.x) + num55;
							characterInfo[j].DNOLPLGACHH.NHFBHNEIGIP.x = (characterInfo[j].DNOLPLGACHH.LDMDBPLADGD.x + vector10.x - NBHJNBHINPH.IJHGDODBFCD.x) / (NBHJNBHINPH.NHLJFKPLKLI.x - NBHJNBHINPH.IJHGDODBFCD.x) + num55;
							characterInfo[j].HKBAKLGBMDE.NHFBHNEIGIP.x = (characterInfo[j].HKBAKLGBMDE.LDMDBPLADGD.x + vector10.x - NBHJNBHINPH.IJHGDODBFCD.x) / (NBHJNBHINPH.NHLJFKPLKLI.x - NBHJNBHINPH.IJHGDODBFCD.x) + num55;
							characterInfo[j].HOCKPNNAIAL.NHFBHNEIGIP.x = (characterInfo[j].HOCKPNNAIAL.LDMDBPLADGD.x + vector10.x - NBHJNBHINPH.IJHGDODBFCD.x) / (NBHJNBHINPH.NHLJFKPLKLI.x - NBHJNBHINPH.IJHGDODBFCD.x) + num55;
							break;
						case NBJIALGHGKG.MatchAspect:
						{
							switch (m_verticalMapping)
							{
							case NBJIALGHGKG.Character:
								characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.y = 0f;
								characterInfo[j].DNOLPLGACHH.NHFBHNEIGIP.y = 1f;
								characterInfo[j].HKBAKLGBMDE.NHFBHNEIGIP.y = 0f;
								characterInfo[j].HOCKPNNAIAL.NHFBHNEIGIP.y = 1f;
								break;
							case NBJIALGHGKG.Line:
								characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.y = (characterInfo[j].BEOPBIAPDBP.LDMDBPLADGD.y - dIPEKGFBHMP.IJHGDODBFCD.y) / (dIPEKGFBHMP.NHLJFKPLKLI.y - dIPEKGFBHMP.IJHGDODBFCD.y) + num55;
								characterInfo[j].DNOLPLGACHH.NHFBHNEIGIP.y = (characterInfo[j].DNOLPLGACHH.LDMDBPLADGD.y - dIPEKGFBHMP.IJHGDODBFCD.y) / (dIPEKGFBHMP.NHLJFKPLKLI.y - dIPEKGFBHMP.IJHGDODBFCD.y) + num55;
								characterInfo[j].HKBAKLGBMDE.NHFBHNEIGIP.y = characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.y;
								characterInfo[j].HOCKPNNAIAL.NHFBHNEIGIP.y = characterInfo[j].DNOLPLGACHH.NHFBHNEIGIP.y;
								break;
							case NBJIALGHGKG.Paragraph:
								characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.y = (characterInfo[j].BEOPBIAPDBP.LDMDBPLADGD.y - NBHJNBHINPH.IJHGDODBFCD.y) / (NBHJNBHINPH.NHLJFKPLKLI.y - NBHJNBHINPH.IJHGDODBFCD.y) + num55;
								characterInfo[j].DNOLPLGACHH.NHFBHNEIGIP.y = (characterInfo[j].DNOLPLGACHH.LDMDBPLADGD.y - NBHJNBHINPH.IJHGDODBFCD.y) / (NBHJNBHINPH.NHLJFKPLKLI.y - NBHJNBHINPH.IJHGDODBFCD.y) + num55;
								characterInfo[j].HKBAKLGBMDE.NHFBHNEIGIP.y = characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.y;
								characterInfo[j].HOCKPNNAIAL.NHFBHNEIGIP.y = characterInfo[j].DNOLPLGACHH.NHFBHNEIGIP.y;
								break;
							case NBJIALGHGKG.MatchAspect:
								Debug.Log("ERROR: Cannot Match both Vertical & Horizontal.");
								break;
							}
							float num56 = (1f - (characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.y + characterInfo[j].DNOLPLGACHH.NHFBHNEIGIP.y) * characterInfo[j].LJKMGEBBDBI) / 2f;
							characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.x = characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.y * characterInfo[j].LJKMGEBBDBI + num56 + num55;
							characterInfo[j].DNOLPLGACHH.NHFBHNEIGIP.x = characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.x;
							characterInfo[j].HKBAKLGBMDE.NHFBHNEIGIP.x = characterInfo[j].DNOLPLGACHH.NHFBHNEIGIP.y * characterInfo[j].LJKMGEBBDBI + num56 + num55;
							characterInfo[j].HOCKPNNAIAL.NHFBHNEIGIP.x = characterInfo[j].HKBAKLGBMDE.NHFBHNEIGIP.x;
							break;
						}
						}
						switch (m_verticalMapping)
						{
						case NBJIALGHGKG.Character:
							characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.y = 0f;
							characterInfo[j].DNOLPLGACHH.NHFBHNEIGIP.y = 1f;
							characterInfo[j].HKBAKLGBMDE.NHFBHNEIGIP.y = 1f;
							characterInfo[j].HOCKPNNAIAL.NHFBHNEIGIP.y = 0f;
							break;
						case NBJIALGHGKG.Line:
							characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.y = (characterInfo[j].BEOPBIAPDBP.LDMDBPLADGD.y - cFLMKMOJIJI.CALDBEMMLEA) / (cFLMKMOJIJI.MNKFKKODLLM - cFLMKMOJIJI.CALDBEMMLEA);
							characterInfo[j].DNOLPLGACHH.NHFBHNEIGIP.y = (characterInfo[j].DNOLPLGACHH.LDMDBPLADGD.y - cFLMKMOJIJI.CALDBEMMLEA) / (cFLMKMOJIJI.MNKFKKODLLM - cFLMKMOJIJI.CALDBEMMLEA);
							characterInfo[j].HKBAKLGBMDE.NHFBHNEIGIP.y = characterInfo[j].DNOLPLGACHH.NHFBHNEIGIP.y;
							characterInfo[j].HOCKPNNAIAL.NHFBHNEIGIP.y = characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.y;
							break;
						case NBJIALGHGKG.Paragraph:
							characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.y = (characterInfo[j].BEOPBIAPDBP.LDMDBPLADGD.y - NBHJNBHINPH.IJHGDODBFCD.y) / (NBHJNBHINPH.NHLJFKPLKLI.y - NBHJNBHINPH.IJHGDODBFCD.y);
							characterInfo[j].DNOLPLGACHH.NHFBHNEIGIP.y = (characterInfo[j].DNOLPLGACHH.LDMDBPLADGD.y - NBHJNBHINPH.IJHGDODBFCD.y) / (NBHJNBHINPH.NHLJFKPLKLI.y - NBHJNBHINPH.IJHGDODBFCD.y);
							characterInfo[j].HKBAKLGBMDE.NHFBHNEIGIP.y = characterInfo[j].DNOLPLGACHH.NHFBHNEIGIP.y;
							characterInfo[j].HOCKPNNAIAL.NHFBHNEIGIP.y = characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.y;
							break;
						case NBJIALGHGKG.MatchAspect:
						{
							float num57 = (1f - (characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.x + characterInfo[j].HKBAKLGBMDE.NHFBHNEIGIP.x) / characterInfo[j].LJKMGEBBDBI) / 2f;
							characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.y = num57 + characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.x / characterInfo[j].LJKMGEBBDBI;
							characterInfo[j].DNOLPLGACHH.NHFBHNEIGIP.y = num57 + characterInfo[j].HKBAKLGBMDE.NHFBHNEIGIP.x / characterInfo[j].LJKMGEBBDBI;
							characterInfo[j].HOCKPNNAIAL.NHFBHNEIGIP.y = characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.y;
							characterInfo[j].HKBAKLGBMDE.NHFBHNEIGIP.y = characterInfo[j].DNOLPLGACHH.NHFBHNEIGIP.y;
							break;
						}
						}
						num43 = characterInfo[j].HJLOCAEAFMJ * (1f - JDKKGHCOCJK);
						if (!characterInfo[j].NKAJACJKPCM && (characterInfo[j].LMNINFLOCIB & BCIEOOJOMDO.Bold) == BCIEOOJOMDO.Bold)
						{
							num43 *= -1f;
						}
						switch (renderMode)
						{
						case RenderMode.ScreenSpaceOverlay:
							num43 *= num42 / scaleFactor;
							break;
						case RenderMode.ScreenSpaceCamera:
							num43 *= ((!flag12) ? 1f : num42);
							break;
						case RenderMode.WorldSpace:
							num43 *= num42;
							break;
						}
						float x = characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.x;
						float y = characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.y;
						float x2 = characterInfo[j].HKBAKLGBMDE.NHFBHNEIGIP.x;
						float y2 = characterInfo[j].HKBAKLGBMDE.NHFBHNEIGIP.y;
						float num58 = (int)x;
						float num59 = (int)y;
						x -= num58;
						x2 -= num58;
						y -= num59;
						y2 -= num59;
						characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.x = FAGDCKGGMLJ(x, y);
						characterInfo[j].BEOPBIAPDBP.NHFBHNEIGIP.y = num43;
						characterInfo[j].DNOLPLGACHH.NHFBHNEIGIP.x = FAGDCKGGMLJ(x, y2);
						characterInfo[j].DNOLPLGACHH.NHFBHNEIGIP.y = num43;
						characterInfo[j].HKBAKLGBMDE.NHFBHNEIGIP.x = FAGDCKGGMLJ(x2, y2);
						characterInfo[j].HKBAKLGBMDE.NHFBHNEIGIP.y = num43;
						characterInfo[j].HOCKPNNAIAL.NHFBHNEIGIP.x = FAGDCKGGMLJ(x2, y);
						characterInfo[j].HOCKPNNAIAL.NHFBHNEIGIP.y = num43;
						break;
					}
					}
					if (j < NGFIDCLHDJB && num37 < KDEGEADEDLP && hGCMIDFMKHD < DJCOAAAJIBO && m_overflowMode != OLMBEAODAPL.Page)
					{
						characterInfo[j].BEOPBIAPDBP.LDMDBPLADGD += zero3;
						characterInfo[j].DNOLPLGACHH.LDMDBPLADGD += zero3;
						characterInfo[j].HKBAKLGBMDE.LDMDBPLADGD += zero3;
						characterInfo[j].HOCKPNNAIAL.LDMDBPLADGD += zero3;
					}
					else if (j < NGFIDCLHDJB && num37 < KDEGEADEDLP && hGCMIDFMKHD < DJCOAAAJIBO && m_overflowMode == OLMBEAODAPL.Page && characterInfo[j].LJABKMPPOML == num10)
					{
						characterInfo[j].BEOPBIAPDBP.LDMDBPLADGD += zero3;
						characterInfo[j].DNOLPLGACHH.LDMDBPLADGD += zero3;
						characterInfo[j].HKBAKLGBMDE.LDMDBPLADGD += zero3;
						characterInfo[j].HOCKPNNAIAL.LDMDBPLADGD += zero3;
					}
					else
					{
						characterInfo[j].BEOPBIAPDBP.LDMDBPLADGD = Vector3.zero;
						characterInfo[j].DNOLPLGACHH.LDMDBPLADGD = Vector3.zero;
						characterInfo[j].HKBAKLGBMDE.LDMDBPLADGD = Vector3.zero;
						characterInfo[j].HOCKPNNAIAL.LDMDBPLADGD = Vector3.zero;
						characterInfo[j].BACHBACHNOF = false;
					}
					switch (mGBPNBKJOJL)
					{
					case HIPDBPNMONO.Character:
						ENEAMABFPLB(j, kBAFACHPHMF);
						break;
					case HIPDBPNMONO.Sprite:
						PCMPCIOLPOA(j, kBAFACHPHMF2);
						break;
					}
				}
				m_textInfo.characterInfo[j].GKDEKLOCKNA += zero3;
				m_textInfo.characterInfo[j].LDJGLAIAPIM += zero3;
				m_textInfo.characterInfo[j].BJONICNNGLI += zero3;
				m_textInfo.characterInfo[j].ABIJFLBDMON += zero3;
				m_textInfo.characterInfo[j].EBDCOMKHPBG += zero3.x;
				m_textInfo.characterInfo[j].MDKGJAGDLHC += zero3.x;
				m_textInfo.characterInfo[j].MNKFKKODLLM += zero3.y;
				m_textInfo.characterInfo[j].CALDBEMMLEA += zero3.y;
				m_textInfo.characterInfo[j].CGAKKOEPCOG += zero3.y;
				if (bACHBACHNOF)
				{
				}
				if (hGCMIDFMKHD != num39 || j == HEEDOMEABKA - 1)
				{
					if (hGCMIDFMKHD != num39)
					{
						m_textInfo.lineInfo[num39].EEGJFJDMBGN += zero3.y;
						m_textInfo.lineInfo[num39].MNKFKKODLLM += zero3.y;
						m_textInfo.lineInfo[num39].CALDBEMMLEA += zero3.y;
						m_textInfo.lineInfo[num39].DIPEKGFBHMP.IJHGDODBFCD = new Vector2(m_textInfo.characterInfo[m_textInfo.lineInfo[num39].IAJJNNOAMLG].GKDEKLOCKNA.x, m_textInfo.lineInfo[num39].CALDBEMMLEA);
						m_textInfo.lineInfo[num39].DIPEKGFBHMP.NHLJFKPLKLI = new Vector2(m_textInfo.characterInfo[m_textInfo.lineInfo[num39].IKKAPEMFJBC].BJONICNNGLI.x, m_textInfo.lineInfo[num39].MNKFKKODLLM);
					}
					if (j == HEEDOMEABKA - 1)
					{
						m_textInfo.lineInfo[hGCMIDFMKHD].EEGJFJDMBGN += zero3.y;
						m_textInfo.lineInfo[hGCMIDFMKHD].MNKFKKODLLM += zero3.y;
						m_textInfo.lineInfo[hGCMIDFMKHD].CALDBEMMLEA += zero3.y;
						m_textInfo.lineInfo[hGCMIDFMKHD].DIPEKGFBHMP.IJHGDODBFCD = new Vector2(m_textInfo.characterInfo[m_textInfo.lineInfo[hGCMIDFMKHD].IAJJNNOAMLG].GKDEKLOCKNA.x, m_textInfo.lineInfo[hGCMIDFMKHD].CALDBEMMLEA);
						m_textInfo.lineInfo[hGCMIDFMKHD].DIPEKGFBHMP.NHLJFKPLKLI = new Vector2(m_textInfo.characterInfo[m_textInfo.lineInfo[hGCMIDFMKHD].IKKAPEMFJBC].BJONICNNGLI.x, m_textInfo.lineInfo[hGCMIDFMKHD].MNKFKKODLLM);
					}
				}
				if (char.IsLetterOrDigit(aONJCHFEHOM2) || aONJCHFEHOM2 == '-' || aONJCHFEHOM2 == '\u00ad' || aONJCHFEHOM2 == '‐' || aONJCHFEHOM2 == '‑')
				{
					if (!flag11)
					{
						flag11 = true;
						num40 = j;
					}
					if (flag11 && j == HEEDOMEABKA - 1)
					{
						int num60 = m_textInfo.wordInfo.Length;
						int wordCount = m_textInfo.wordCount;
						if (m_textInfo.wordCount + 1 > num60)
						{
							TMP_TextInfo.NKMKBLFBOFC(ref m_textInfo.wordInfo, num60 + 1);
						}
						num41 = j;
						m_textInfo.wordInfo[wordCount].IAJJNNOAMLG = num40;
						m_textInfo.wordInfo[wordCount].FNOFPOMADEM = num41;
						m_textInfo.wordInfo[wordCount].NGNCDLJAEFL = num41 - num40 + 1;
						m_textInfo.wordInfo[wordCount].MHFABDJOCMG = this;
						num37++;
						m_textInfo.wordCount++;
						m_textInfo.lineInfo[hGCMIDFMKHD].HGPDAPOOJMO++;
					}
				}
				else if ((flag11 || (j == 0 && (!char.IsPunctuation(aONJCHFEHOM2) || char.IsWhiteSpace(aONJCHFEHOM2) || aONJCHFEHOM2 == '\u200b' || j == HEEDOMEABKA - 1))) && (j <= 0 || j >= characterInfo.Length - 1 || j >= HEEDOMEABKA || (aONJCHFEHOM2 != '\'' && aONJCHFEHOM2 != '’') || !char.IsLetterOrDigit(characterInfo[j - 1].AONJCHFEHOM) || !char.IsLetterOrDigit(characterInfo[j + 1].AONJCHFEHOM)))
				{
					num41 = ((j != HEEDOMEABKA - 1 || !char.IsLetterOrDigit(aONJCHFEHOM2)) ? (j - 1) : j);
					flag11 = false;
					int num61 = m_textInfo.wordInfo.Length;
					int wordCount2 = m_textInfo.wordCount;
					if (m_textInfo.wordCount + 1 > num61)
					{
						TMP_TextInfo.NKMKBLFBOFC(ref m_textInfo.wordInfo, num61 + 1);
					}
					m_textInfo.wordInfo[wordCount2].IAJJNNOAMLG = num40;
					m_textInfo.wordInfo[wordCount2].FNOFPOMADEM = num41;
					m_textInfo.wordInfo[wordCount2].NGNCDLJAEFL = num41 - num40 + 1;
					m_textInfo.wordInfo[wordCount2].MHFABDJOCMG = this;
					num37++;
					m_textInfo.wordCount++;
					m_textInfo.lineInfo[hGCMIDFMKHD].HGPDAPOOJMO++;
				}
				if ((m_textInfo.characterInfo[j].LMNINFLOCIB & BCIEOOJOMDO.Underline) == BCIEOOJOMDO.Underline)
				{
					bool flag14 = true;
					int lJABKMPPOML = m_textInfo.characterInfo[j].LJABKMPPOML;
					if (j > NGFIDCLHDJB || hGCMIDFMKHD > DJCOAAAJIBO || (m_overflowMode == OLMBEAODAPL.Page && lJABKMPPOML + 1 != m_pageToDisplay))
					{
						flag14 = false;
					}
					if (!char.IsWhiteSpace(aONJCHFEHOM2) && aONJCHFEHOM2 != '\u200b')
					{
						num46 = Mathf.Max(num46, m_textInfo.characterInfo[j].HJLOCAEAFMJ);
						num47 = Mathf.Min((lJABKMPPOML != num48) ? TMP_Text.FEBIFNLEHEG : num47, m_textInfo.characterInfo[j].CGAKKOEPCOG + base.ELKNHALJKNI.fontInfo.Underline * num46);
						num48 = lJABKMPPOML;
					}
					if (!flag && flag14 && j <= cFLMKMOJIJI.IKKAPEMFJBC && aONJCHFEHOM2 != '\n' && aONJCHFEHOM2 != '\r' && (j != cFLMKMOJIJI.IKKAPEMFJBC || !char.IsSeparator(aONJCHFEHOM2)))
					{
						flag = true;
						num44 = m_textInfo.characterInfo[j].HJLOCAEAFMJ;
						if (num46 == 0f)
						{
							num46 = num44;
						}
						eHGOOEHDNMM = new Vector3(m_textInfo.characterInfo[j].GKDEKLOCKNA.x, num47, 0f);
						color = m_textInfo.characterInfo[j].FNHEFDBFBMN;
					}
					if (flag && HEEDOMEABKA == 1)
					{
						flag = false;
						zero = new Vector3(m_textInfo.characterInfo[j].BJONICNNGLI.x, num47, 0f);
						num45 = m_textInfo.characterInfo[j].HJLOCAEAFMJ;
						BDKMACGGDAO(eHGOOEHDNMM, zero, ref EHJNMODJEAN, num44, num45, num46, num43, color);
						num46 = 0f;
						num47 = TMP_Text.FEBIFNLEHEG;
					}
					else if (flag && (j == cFLMKMOJIJI.FNOFPOMADEM || j >= cFLMKMOJIJI.IKKAPEMFJBC))
					{
						if (char.IsWhiteSpace(aONJCHFEHOM2) || aONJCHFEHOM2 == '\u200b')
						{
							int iKKAPEMFJBC = cFLMKMOJIJI.IKKAPEMFJBC;
							zero = new Vector3(m_textInfo.characterInfo[iKKAPEMFJBC].BJONICNNGLI.x, num47, 0f);
							num45 = m_textInfo.characterInfo[iKKAPEMFJBC].HJLOCAEAFMJ;
						}
						else
						{
							zero = new Vector3(m_textInfo.characterInfo[j].BJONICNNGLI.x, num47, 0f);
							num45 = m_textInfo.characterInfo[j].HJLOCAEAFMJ;
						}
						flag = false;
						BDKMACGGDAO(eHGOOEHDNMM, zero, ref EHJNMODJEAN, num44, num45, num46, num43, color);
						num46 = 0f;
						num47 = TMP_Text.FEBIFNLEHEG;
					}
					else if (flag && !flag14)
					{
						flag = false;
						zero = new Vector3(m_textInfo.characterInfo[j - 1].BJONICNNGLI.x, num47, 0f);
						num45 = m_textInfo.characterInfo[j - 1].HJLOCAEAFMJ;
						BDKMACGGDAO(eHGOOEHDNMM, zero, ref EHJNMODJEAN, num44, num45, num46, num43, color);
						num46 = 0f;
						num47 = TMP_Text.FEBIFNLEHEG;
					}
					else if (flag && j < HEEDOMEABKA - 1 && !color.ICKHMPOCMAJ(m_textInfo.characterInfo[j + 1].FNHEFDBFBMN))
					{
						flag = false;
						zero = new Vector3(m_textInfo.characterInfo[j].BJONICNNGLI.x, num47, 0f);
						num45 = m_textInfo.characterInfo[j].HJLOCAEAFMJ;
						BDKMACGGDAO(eHGOOEHDNMM, zero, ref EHJNMODJEAN, num44, num45, num46, num43, color);
						num46 = 0f;
						num47 = TMP_Text.FEBIFNLEHEG;
					}
				}
				else if (flag)
				{
					flag = false;
					zero = new Vector3(m_textInfo.characterInfo[j - 1].BJONICNNGLI.x, num47, 0f);
					num45 = m_textInfo.characterInfo[j - 1].HJLOCAEAFMJ;
					BDKMACGGDAO(eHGOOEHDNMM, zero, ref EHJNMODJEAN, num44, num45, num46, num43, color);
					num46 = 0f;
					num47 = TMP_Text.FEBIFNLEHEG;
				}
				bool flag15 = (m_textInfo.characterInfo[j].LMNINFLOCIB & BCIEOOJOMDO.Strikethrough) == BCIEOOJOMDO.Strikethrough;
				float strikethrough = pIJNMJOHBIE.fontInfo.strikethrough;
				if (flag15)
				{
					bool flag16 = true;
					if (j > NGFIDCLHDJB || hGCMIDFMKHD > DJCOAAAJIBO || (m_overflowMode == OLMBEAODAPL.Page && m_textInfo.characterInfo[j].LJABKMPPOML + 1 != m_pageToDisplay))
					{
						flag16 = false;
					}
					if (!flag2 && flag16 && j <= cFLMKMOJIJI.IKKAPEMFJBC && aONJCHFEHOM2 != '\n' && aONJCHFEHOM2 != '\r' && (j != cFLMKMOJIJI.IKKAPEMFJBC || !char.IsSeparator(aONJCHFEHOM2)))
					{
						flag2 = true;
						num49 = m_textInfo.characterInfo[j].EKNOFGHHCPJ;
						num50 = m_textInfo.characterInfo[j].HJLOCAEAFMJ;
						eHGOOEHDNMM2 = new Vector3(m_textInfo.characterInfo[j].GKDEKLOCKNA.x, m_textInfo.characterInfo[j].CGAKKOEPCOG + strikethrough * num50, 0f);
						fNHEFDBFBMN = m_textInfo.characterInfo[j].NPNKHPFBLBG;
						bCIHLCMFAEK = m_textInfo.characterInfo[j].CGAKKOEPCOG;
					}
					if (flag2 && HEEDOMEABKA == 1)
					{
						flag2 = false;
						zero2 = new Vector3(m_textInfo.characterInfo[j].BJONICNNGLI.x, m_textInfo.characterInfo[j].CGAKKOEPCOG + strikethrough * num50, 0f);
						BDKMACGGDAO(eHGOOEHDNMM2, zero2, ref EHJNMODJEAN, num50, num50, num50, num43, fNHEFDBFBMN);
					}
					else if (flag2 && j == cFLMKMOJIJI.FNOFPOMADEM)
					{
						if (char.IsWhiteSpace(aONJCHFEHOM2) || aONJCHFEHOM2 == '\u200b')
						{
							int iKKAPEMFJBC2 = cFLMKMOJIJI.IKKAPEMFJBC;
							zero2 = new Vector3(m_textInfo.characterInfo[iKKAPEMFJBC2].BJONICNNGLI.x, m_textInfo.characterInfo[iKKAPEMFJBC2].CGAKKOEPCOG + strikethrough * num50, 0f);
						}
						else
						{
							zero2 = new Vector3(m_textInfo.characterInfo[j].BJONICNNGLI.x, m_textInfo.characterInfo[j].CGAKKOEPCOG + strikethrough * num50, 0f);
						}
						flag2 = false;
						BDKMACGGDAO(eHGOOEHDNMM2, zero2, ref EHJNMODJEAN, num50, num50, num50, num43, fNHEFDBFBMN);
					}
					else if (flag2 && j < HEEDOMEABKA && (m_textInfo.characterInfo[j + 1].EKNOFGHHCPJ != num49 || !OBBKAPGMGCN.ACBFEEBCHCF(m_textInfo.characterInfo[j + 1].CGAKKOEPCOG + zero3.y, bCIHLCMFAEK)))
					{
						flag2 = false;
						int iKKAPEMFJBC3 = cFLMKMOJIJI.IKKAPEMFJBC;
						zero2 = ((j <= iKKAPEMFJBC3) ? new Vector3(m_textInfo.characterInfo[j].BJONICNNGLI.x, m_textInfo.characterInfo[j].CGAKKOEPCOG + strikethrough * num50, 0f) : new Vector3(m_textInfo.characterInfo[iKKAPEMFJBC3].BJONICNNGLI.x, m_textInfo.characterInfo[iKKAPEMFJBC3].CGAKKOEPCOG + strikethrough * num50, 0f));
						BDKMACGGDAO(eHGOOEHDNMM2, zero2, ref EHJNMODJEAN, num50, num50, num50, num43, fNHEFDBFBMN);
					}
					else if (flag2 && j < HEEDOMEABKA && pIJNMJOHBIE.GetInstanceID() != characterInfo[j + 1].PIJNMJOHBIE.GetInstanceID())
					{
						flag2 = false;
						zero2 = new Vector3(m_textInfo.characterInfo[j].BJONICNNGLI.x, m_textInfo.characterInfo[j].CGAKKOEPCOG + strikethrough * num50, 0f);
						BDKMACGGDAO(eHGOOEHDNMM2, zero2, ref EHJNMODJEAN, num50, num50, num50, num43, fNHEFDBFBMN);
					}
					else if (flag2 && !flag16)
					{
						flag2 = false;
						zero2 = new Vector3(m_textInfo.characterInfo[j - 1].BJONICNNGLI.x, m_textInfo.characterInfo[j - 1].CGAKKOEPCOG + strikethrough * num50, 0f);
						BDKMACGGDAO(eHGOOEHDNMM2, zero2, ref EHJNMODJEAN, num50, num50, num50, num43, fNHEFDBFBMN);
					}
				}
				else if (flag2)
				{
					flag2 = false;
					zero2 = new Vector3(m_textInfo.characterInfo[j - 1].BJONICNNGLI.x, m_textInfo.characterInfo[j - 1].CGAKKOEPCOG + strikethrough * num50, 0f);
					BDKMACGGDAO(eHGOOEHDNMM2, zero2, ref EHJNMODJEAN, num50, num50, num50, num43, fNHEFDBFBMN);
				}
				if ((m_textInfo.characterInfo[j].LMNINFLOCIB & BCIEOOJOMDO.Highlight) == BCIEOOJOMDO.Highlight)
				{
					bool flag17 = true;
					int lJABKMPPOML2 = m_textInfo.characterInfo[j].LJABKMPPOML;
					if (j > NGFIDCLHDJB || hGCMIDFMKHD > DJCOAAAJIBO || (m_overflowMode == OLMBEAODAPL.Page && lJABKMPPOML2 + 1 != m_pageToDisplay))
					{
						flag17 = false;
					}
					if (!flag3 && flag17 && j <= cFLMKMOJIJI.IKKAPEMFJBC && aONJCHFEHOM2 != '\n' && aONJCHFEHOM2 != '\r' && (j != cFLMKMOJIJI.IKKAPEMFJBC || !char.IsSeparator(aONJCHFEHOM2)))
					{
						flag3 = true;
						eHGOOEHDNMM3 = TMP_Text.BOAMBILHDEN;
						vector = TMP_Text.DEAMJJKCNNM;
						color2 = m_textInfo.characterInfo[j].OFCEJMNBFOJ;
					}
					if (flag3)
					{
						Color32 oFCEJMNBFOJ = m_textInfo.characterInfo[j].OFCEJMNBFOJ;
						bool flag18 = false;
						if (!color2.ICKHMPOCMAJ(oFCEJMNBFOJ))
						{
							vector.x = (vector.x + m_textInfo.characterInfo[j].GKDEKLOCKNA.x) / 2f;
							eHGOOEHDNMM3.y = Mathf.Min(eHGOOEHDNMM3.y, m_textInfo.characterInfo[j].CALDBEMMLEA);
							vector.y = Mathf.Max(vector.y, m_textInfo.characterInfo[j].MNKFKKODLLM);
							JDEMMNCJGJK(eHGOOEHDNMM3, vector, ref EHJNMODJEAN, color2);
							flag3 = true;
							eHGOOEHDNMM3 = vector;
							vector = new Vector3(m_textInfo.characterInfo[j].BJONICNNGLI.x, m_textInfo.characterInfo[j].CALDBEMMLEA, 0f);
							color2 = m_textInfo.characterInfo[j].OFCEJMNBFOJ;
							flag18 = true;
						}
						if (!flag18)
						{
							eHGOOEHDNMM3.x = Mathf.Min(eHGOOEHDNMM3.x, m_textInfo.characterInfo[j].GKDEKLOCKNA.x);
							eHGOOEHDNMM3.y = Mathf.Min(eHGOOEHDNMM3.y, m_textInfo.characterInfo[j].CALDBEMMLEA);
							vector.x = Mathf.Max(vector.x, m_textInfo.characterInfo[j].BJONICNNGLI.x);
							vector.y = Mathf.Max(vector.y, m_textInfo.characterInfo[j].MNKFKKODLLM);
						}
					}
					if (flag3 && HEEDOMEABKA == 1)
					{
						flag3 = false;
						JDEMMNCJGJK(eHGOOEHDNMM3, vector, ref EHJNMODJEAN, color2);
					}
					else if (flag3 && (j == cFLMKMOJIJI.FNOFPOMADEM || j >= cFLMKMOJIJI.IKKAPEMFJBC))
					{
						flag3 = false;
						JDEMMNCJGJK(eHGOOEHDNMM3, vector, ref EHJNMODJEAN, color2);
					}
					else if (flag3 && !flag17)
					{
						flag3 = false;
						JDEMMNCJGJK(eHGOOEHDNMM3, vector, ref EHJNMODJEAN, color2);
					}
				}
				else if (flag3)
				{
					flag3 = false;
					JDEMMNCJGJK(eHGOOEHDNMM3, vector, ref EHJNMODJEAN, color2);
				}
				num39 = hGCMIDFMKHD;
			}
			m_textInfo.characterCount = (short)HEEDOMEABKA;
			m_textInfo.spriteCount = EACDOBPJMHI;
			m_textInfo.lineCount = (short)num38;
			m_textInfo.wordCount = ((num37 == 0 || HEEDOMEABKA <= 0) ? 1 : ((short)num37));
			m_textInfo.pageCount = BHJLNHKINKN + 1;
			if (LNKILMNOLPD == HJNAPNHAJCI.Render)
			{
				if (CNEODGLFFPG.additionalShaderChannels != (AdditionalCanvasShaderChannels.TexCoord1 | AdditionalCanvasShaderChannels.TexCoord2 | AdditionalCanvasShaderChannels.Normal | AdditionalCanvasShaderChannels.Tangent))
				{
					CNEODGLFFPG.additionalShaderChannels = AdditionalCanvasShaderChannels.TexCoord1 | AdditionalCanvasShaderChannels.TexCoord2 | AdditionalCanvasShaderChannels.Normal | AdditionalCanvasShaderChannels.Tangent;
				}
				if (m_geometrySortingOrder != 0)
				{
					m_textInfo.meshInfo[0].HJDKIIGKKNG(LLKOCAEGPDG.Reverse);
				}
				OPMBPPBMINF.MarkDynamic();
				OPMBPPBMINF.vertices = m_textInfo.meshInfo[0].FHBFCAEGPOH;
				OPMBPPBMINF.uv = m_textInfo.meshInfo[0].LFAFOAOKPKA;
				OPMBPPBMINF.uv2 = m_textInfo.meshInfo[0].FJPNPHPFBFJ;
				OPMBPPBMINF.colors32 = m_textInfo.meshInfo[0].PMBHKFBDDND;
				OPMBPPBMINF.RecalculateBounds();
				JMJNGBJNGGC.SetMesh(OPMBPPBMINF);
				Color color3 = JMJNGBJNGGC.GetColor();
				for (int k = 1; k < m_textInfo.materialCount; k++)
				{
					m_textInfo.meshInfo[k].NGOKLPFCFAO();
					if (!(m_subTextObjects[k] == null))
					{
						if (m_geometrySortingOrder != 0)
						{
							m_textInfo.meshInfo[k].HJDKIIGKKNG(LLKOCAEGPDG.Reverse);
						}
						m_subTextObjects[k].IJKCGGPJDIG.vertices = m_textInfo.meshInfo[k].FHBFCAEGPOH;
						m_subTextObjects[k].IJKCGGPJDIG.uv = m_textInfo.meshInfo[k].LFAFOAOKPKA;
						m_subTextObjects[k].IJKCGGPJDIG.uv2 = m_textInfo.meshInfo[k].FJPNPHPFBFJ;
						m_subTextObjects[k].IJKCGGPJDIG.colors32 = m_textInfo.meshInfo[k].PMBHKFBDDND;
						m_subTextObjects[k].IJKCGGPJDIG.RecalculateBounds();
						m_subTextObjects[k].HBIBDFFPKFG.SetMesh(m_subTextObjects[k].IJKCGGPJDIG);
						m_subTextObjects[k].HBIBDFFPKFG.SetColor(color3);
					}
				}
			}
			FFCFAICENOB.EDOBMOAFCFA(this);
		}

		protected override Vector3[] BELKDCLEJKJ()
		{
			if (HBKNOEILBLE == null)
			{
				HBKNOEILBLE = base.GPPKOGCLKPL;
			}
			HBKNOEILBLE.GetLocalCorners(LJPBNPONJJJ);
			return LJPBNPONJJJ;
		}

		protected override void HPDBJNLMBED(bool BGEDKGLJIGM)
		{
			for (int i = 1; i < m_subTextObjects.Length && m_subTextObjects[i] != null; i++)
			{
				if (m_subTextObjects[i].enabled != BGEDKGLJIGM)
				{
					m_subTextObjects[i].enabled = BGEDKGLJIGM;
				}
			}
		}

		protected override Bounds LFBLMFICMCK()
		{
			Bounds bounds = OPMBPPBMINF.bounds;
			Vector3 min = bounds.min;
			Vector3 max = bounds.max;
			for (int i = 1; i < m_subTextObjects.Length && m_subTextObjects[i] != null; i++)
			{
				Bounds bounds2 = m_subTextObjects[i].IJKCGGPJDIG.bounds;
				min.x = ((!(min.x < bounds2.min.x)) ? bounds2.min.x : min.x);
				min.y = ((!(min.y < bounds2.min.y)) ? bounds2.min.y : min.y);
				max.x = ((!(max.x > bounds2.max.x)) ? bounds2.max.x : max.x);
				max.y = ((!(max.y > bounds2.max.y)) ? bounds2.max.y : max.y);
			}
			Vector3 center = (min + max) / 2f;
			Vector2 vector = max - min;
			return new Bounds(center, vector);
		}

		private void GFLNMPPCJKM(float FCCMJOKDDEA)
		{
			if (CNEODGLFFPG == null)
			{
				CNEODGLFFPG = GCBMKJJLJBC();
				if (CNEODGLFFPG == null)
				{
					return;
				}
			}
			FCCMJOKDDEA = ((FCCMJOKDDEA != 0f) ? FCCMJOKDDEA : 1f);
			float num = 0f;
			float scaleFactor = CNEODGLFFPG.scaleFactor;
			num = ((CNEODGLFFPG.renderMode == RenderMode.ScreenSpaceOverlay) ? (FCCMJOKDDEA / scaleFactor) : ((CNEODGLFFPG.renderMode != RenderMode.ScreenSpaceCamera) ? FCCMJOKDDEA : ((!(CNEODGLFFPG.worldCamera != null)) ? 1f : FCCMJOKDDEA)));
			for (int i = 0; i < m_textInfo.characterCount; i++)
			{
				if (m_textInfo.characterInfo[i].BACHBACHNOF && m_textInfo.characterInfo[i].MGBPNBKJOJL == HIPDBPNMONO.Character)
				{
					float num2 = num * m_textInfo.characterInfo[i].HJLOCAEAFMJ * (1f - JDKKGHCOCJK);
					if (!m_textInfo.characterInfo[i].NKAJACJKPCM && (m_textInfo.characterInfo[i].LMNINFLOCIB & BCIEOOJOMDO.Bold) == BCIEOOJOMDO.Bold)
					{
						num2 *= -1f;
					}
					int eKBHGEBCJHL = m_textInfo.characterInfo[i].EKBHGEBCJHL;
					int kAKJKCHHBAP = m_textInfo.characterInfo[i].KAKJKCHHBAP;
					m_textInfo.meshInfo[eKBHGEBCJHL].FJPNPHPFBFJ[kAKJKCHHBAP].y = num2;
					m_textInfo.meshInfo[eKBHGEBCJHL].FJPNPHPFBFJ[kAKJKCHHBAP + 1].y = num2;
					m_textInfo.meshInfo[eKBHGEBCJHL].FJPNPHPFBFJ[kAKJKCHHBAP + 2].y = num2;
					m_textInfo.meshInfo[eKBHGEBCJHL].FJPNPHPFBFJ[kAKJKCHHBAP + 3].y = num2;
				}
			}
			for (int j = 0; j < m_textInfo.materialCount; j++)
			{
				if (j == 0)
				{
					OPMBPPBMINF.uv2 = m_textInfo.meshInfo[0].FJPNPHPFBFJ;
					JMJNGBJNGGC.SetMesh(OPMBPPBMINF);
				}
				else
				{
					m_subTextObjects[j].IJKCGGPJDIG.uv2 = m_textInfo.meshInfo[j].FJPNPHPFBFJ;
					m_subTextObjects[j].HBIBDFFPKFG.SetMesh(m_subTextObjects[j].IJKCGGPJDIG);
				}
			}
		}

		protected override void NEPMEIHOFJI(int KKMNKJJENIL, int OKEFBABJGLB, float IBNDGNOIEEF)
		{
			Vector3 vector = new Vector3(0f, IBNDGNOIEEF, 0f);
			for (int i = KKMNKJJENIL; i <= OKEFBABJGLB; i++)
			{
				m_textInfo.characterInfo[i].GKDEKLOCKNA -= vector;
				m_textInfo.characterInfo[i].LDJGLAIAPIM -= vector;
				m_textInfo.characterInfo[i].BJONICNNGLI -= vector;
				m_textInfo.characterInfo[i].ABIJFLBDMON -= vector;
				m_textInfo.characterInfo[i].MNKFKKODLLM -= vector.y;
				m_textInfo.characterInfo[i].CGAKKOEPCOG -= vector.y;
				m_textInfo.characterInfo[i].CALDBEMMLEA -= vector.y;
				if (m_textInfo.characterInfo[i].BACHBACHNOF)
				{
					m_textInfo.characterInfo[i].BEOPBIAPDBP.LDMDBPLADGD -= vector;
					m_textInfo.characterInfo[i].DNOLPLGACHH.LDMDBPLADGD -= vector;
					m_textInfo.characterInfo[i].HKBAKLGBMDE.LDMDBPLADGD -= vector;
					m_textInfo.characterInfo[i].HOCKPNNAIAL.LDMDBPLADGD -= vector;
				}
			}
		}
	}
}
