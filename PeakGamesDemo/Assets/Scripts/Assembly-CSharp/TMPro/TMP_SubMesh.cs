using System;
using UnityEngine;

namespace TMPro
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(MeshFilter))]
	[RequireComponent(typeof(MeshRenderer))]
	public class TMP_SubMesh : MonoBehaviour
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
		private Renderer m_renderer;

		[SerializeField]
		private MeshFilter m_meshFilter;

		private Mesh OPMBPPBMINF;

		[SerializeField]
		private BoxCollider m_boxCollider;

		[SerializeField]
		private TextMeshPro m_TextComponent;

		[NonSerialized]
		private bool FLPABJOEKCL;

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

		public Material GHPFOPNNJOB
		{
			get
			{
				return JNMHGFLJDKP(m_sharedMaterial);
			}
			set
			{
				if (m_sharedMaterial.GetInstanceID() != value.GetInstanceID())
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

		public Renderer GGOAIKFJJEI
		{
			get
			{
				if (m_renderer == null)
				{
					m_renderer = GetComponent<Renderer>();
				}
				return m_renderer;
			}
		}

		public MeshFilter BOHOPOEDLMA
		{
			get
			{
				if (m_meshFilter == null)
				{
					m_meshFilter = GetComponent<MeshFilter>();
				}
				return m_meshFilter;
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
					BOHOPOEDLMA.mesh = OPMBPPBMINF;
				}
				return OPMBPPBMINF;
			}
			set
			{
				OPMBPPBMINF = value;
			}
		}

		public BoxCollider OOOMMMGJABB
		{
			get
			{
				if (m_boxCollider == null)
				{
					m_boxCollider = GetComponent<BoxCollider>();
					if (m_boxCollider == null)
					{
						m_boxCollider = base.gameObject.AddComponent<BoxCollider>();
						base.gameObject.AddComponent<Rigidbody>();
					}
				}
				return m_boxCollider;
			}
		}

		private void OnEnable()
		{
			if (!FLPABJOEKCL)
			{
				FLPABJOEKCL = true;
			}
			BOHOPOEDLMA.sharedMesh = IJKCGGPJDIG;
			if (m_sharedMaterial != null)
			{
				m_sharedMaterial.SetVector(MOHPNOBPBBL.EFFCKFEGLNH, new Vector4(-32767f, -32767f, 32767f, 32767f));
			}
		}

		private void OnDisable()
		{
			m_meshFilter.sharedMesh = null;
			if (INOFONFKEGA != null)
			{
				HPENNIOPLFI.KLMFHLDMKJF(INOFONFKEGA);
				INOFONFKEGA = null;
			}
		}

		private void OnDestroy()
		{
			if (OPMBPPBMINF != null)
			{
				UnityEngine.Object.DestroyImmediate(OPMBPPBMINF);
			}
			if (INOFONFKEGA != null)
			{
				HPENNIOPLFI.KLMFHLDMKJF(INOFONFKEGA);
				INOFONFKEGA = null;
			}
			FLPABJOEKCL = false;
		}

		public static TMP_SubMesh AddSubTextObject(TextMeshPro MHFABDJOCMG, FMOBJPAGLEE EBEMFPNHKMN)
		{
			GameObject gameObject = new GameObject("TMP SubMesh [" + EBEMFPNHKMN.GHPFOPNNJOB.name + "]", typeof(TMP_SubMesh));
			TMP_SubMesh component = gameObject.GetComponent<TMP_SubMesh>();
			gameObject.transform.SetParent(MHFABDJOCMG.ANLKLKAINEO, false);
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localRotation = Quaternion.identity;
			gameObject.transform.localScale = Vector3.one;
			gameObject.layer = MHFABDJOCMG.gameObject.layer;
			component.m_meshFilter = gameObject.GetComponent<MeshFilter>();
			component.m_TextComponent = MHFABDJOCMG;
			component.m_fontAsset = EBEMFPNHKMN.PIJNMJOHBIE;
			component.m_spriteAsset = EBEMFPNHKMN.GKDEMJDOOLB;
			component.m_isDefaultMaterial = EBEMFPNHKMN.PDLHEANIELH;
			component.LFCEIGAFPID(EBEMFPNHKMN.GHPFOPNNJOB);
			component.GGOAIKFJJEI.sortingLayerID = MHFABDJOCMG.GGOAIKFJJEI.sortingLayerID;
			component.GGOAIKFJJEI.sortingOrder = MHFABDJOCMG.GGOAIKFJJEI.sortingOrder;
			return component;
		}

		public void DestroySelf()
		{
			UnityEngine.Object.Destroy(base.gameObject, 1f);
		}

		private Material JNMHGFLJDKP(Material GJDEEBDFEFM)
		{
			if (m_renderer == null)
			{
				m_renderer = GetComponent<Renderer>();
			}
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
			if (m_renderer == null)
			{
				m_renderer = GetComponent<Renderer>();
			}
			return m_renderer.sharedMaterial;
		}

		private void LFCEIGAFPID(Material GJDEEBDFEFM)
		{
			m_sharedMaterial = GJDEEBDFEFM;
			m_padding = GetPaddingForMaterial();
			SetMaterialDirty();
		}

		public void SetSortingOrder(int GDDGFAKOCIL)
		{
			GGOAIKFJJEI.sortingOrder = GDDGFAKOCIL;
		}

		public void SetSortingLayer(int KGABIIAJBHD)
		{
			GGOAIKFJJEI.sortingLayerID = KGABIIAJBHD;
		}

		public float GetPaddingForMaterial()
		{
			return MOHPNOBPBBL.JHMPKCIPPMF(m_sharedMaterial, m_TextComponent.AJLGMMOGEOC, m_TextComponent.HBBBBINCPHE);
		}

		public void UpdateMeshPadding(bool KCLKLHLOBBG, bool HBBBBINCPHE)
		{
			m_padding = MOHPNOBPBBL.JHMPKCIPPMF(m_sharedMaterial, KCLKLHLOBBG, HBBBBINCPHE);
		}

		public void SetVerticesDirty()
		{
			if (base.enabled && m_TextComponent != null)
			{
				m_TextComponent.KEJHLJNMEAH = true;
				m_TextComponent.SetVerticesDirty();
			}
		}

		public void SetMaterialDirty()
		{
			KBNIPKMONGK();
		}

		protected void KBNIPKMONGK()
		{
			if (m_renderer == null)
			{
				m_renderer = GGOAIKFJJEI;
			}
			m_renderer.sharedMaterial = m_sharedMaterial;
		}

		public void UpdateColliders(int BKJOIFFAGKE)
		{
			if (!(OOOMMMGJABB == null))
			{
				Vector2 fDOIHJIHMPC = OBBKAPGMGCN.FDOIHJIHMPC;
				Vector2 jGNHGBBGCKJ = OBBKAPGMGCN.JGNHGBBGCKJ;
				for (int i = 0; i < BKJOIFFAGKE; i++)
				{
					fDOIHJIHMPC.x = Mathf.Min(fDOIHJIHMPC.x, OPMBPPBMINF.vertices[i].x);
					fDOIHJIHMPC.y = Mathf.Min(fDOIHJIHMPC.y, OPMBPPBMINF.vertices[i].y);
					jGNHGBBGCKJ.x = Mathf.Max(jGNHGBBGCKJ.x, OPMBPPBMINF.vertices[i].x);
					jGNHGBBGCKJ.y = Mathf.Max(jGNHGBBGCKJ.y, OPMBPPBMINF.vertices[i].y);
				}
				Vector3 center = (fDOIHJIHMPC + jGNHGBBGCKJ) / 2f;
				Vector3 size = jGNHGBBGCKJ - fDOIHJIHMPC;
				size.z = 0.1f;
				OOOMMMGJABB.center = center;
				OOOMMMGJABB.size = size;
			}
		}
	}
}
