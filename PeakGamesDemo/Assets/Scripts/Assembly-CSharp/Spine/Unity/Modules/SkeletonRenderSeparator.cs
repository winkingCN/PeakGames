using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace Spine.Unity.Modules
{
	[HelpURL("https://github.com/pharan/spine-unity-docs/blob/master/SkeletonRenderSeparator.md")]
	[ExecuteInEditMode]
	public class SkeletonRenderSeparator : MonoBehaviour
	{
		public const int DefaultSortingOrderIncrement = 5;

		[SerializeField]
		protected SkeletonRenderer skeletonRenderer;

		private MeshRenderer IMOEBFCPIAB;

		public bool copyPropertyBlock = true;

		[Tooltip("Copies MeshRenderer flags into each parts renderer")]
		public bool copyMeshRendererFlags = true;

		public List<SkeletonPartsRenderer> partsRenderers = new List<SkeletonPartsRenderer>();

		private MaterialPropertyBlock DLHCECFGFED;

		public SkeletonRenderer ALNKFMCPIIB
		{
			get
			{
				return skeletonRenderer;
			}
			set
			{
				if (skeletonRenderer != null)
				{
					skeletonRenderer.LEMGBCGDEGA -= FNCMBMGODDB;
				}
				skeletonRenderer = value;
				base.enabled = false;
			}
		}

		public static SkeletonRenderSeparator AddToSkeletonRenderer(SkeletonRenderer NHPAGGIFGHN, int IKJGCDCDCCJ = 0, int BJEKMKPCNNC = 0, int HLOPFAPONOK = 5, int DFFAMMLLFBL = 0, bool MEFJIHJOHFG = true)
		{
			if (NHPAGGIFGHN == null)
			{
				Debug.Log("Tried to add SkeletonRenderSeparator to a null SkeletonRenderer reference.");
				return null;
			}
			SkeletonRenderSeparator skeletonRenderSeparator = NHPAGGIFGHN.gameObject.AddComponent<SkeletonRenderSeparator>();
			skeletonRenderSeparator.skeletonRenderer = NHPAGGIFGHN;
			NHPAGGIFGHN.Initialize(false);
			int num = BJEKMKPCNNC;
			if (MEFJIHJOHFG)
			{
				num = BJEKMKPCNNC + NHPAGGIFGHN.separatorSlots.Count + 1;
			}
			Transform lIMMFGDCLAB = NHPAGGIFGHN.transform;
			List<SkeletonPartsRenderer> list = skeletonRenderSeparator.partsRenderers;
			for (int i = 0; i < num; i++)
			{
				SkeletonPartsRenderer skeletonPartsRenderer = SkeletonPartsRenderer.NewPartsRendererGameObject(lIMMFGDCLAB, i.ToString());
				MeshRenderer meshRenderer = skeletonPartsRenderer.GADGIJJDPOL;
				meshRenderer.sortingLayerID = IKJGCDCDCCJ;
				meshRenderer.sortingOrder = DFFAMMLLFBL + i * HLOPFAPONOK;
				list.Add(skeletonPartsRenderer);
			}
			return skeletonRenderSeparator;
		}

		public void AddPartsRenderer(int HLOPFAPONOK = 5)
		{
			int sortingLayerID = 0;
			int sortingOrder = 0;
			if (partsRenderers.Count > 0)
			{
				SkeletonPartsRenderer skeletonPartsRenderer = partsRenderers[partsRenderers.Count - 1];
				MeshRenderer meshRenderer = skeletonPartsRenderer.GADGIJJDPOL;
				sortingLayerID = meshRenderer.sortingLayerID;
				sortingOrder = meshRenderer.sortingOrder + HLOPFAPONOK;
			}
			SkeletonPartsRenderer skeletonPartsRenderer2 = SkeletonPartsRenderer.NewPartsRendererGameObject(skeletonRenderer.transform, partsRenderers.Count.ToString());
			partsRenderers.Add(skeletonPartsRenderer2);
			MeshRenderer meshRenderer2 = skeletonPartsRenderer2.GADGIJJDPOL;
			meshRenderer2.sortingLayerID = sortingLayerID;
			meshRenderer2.sortingOrder = sortingOrder;
		}

		private void OnEnable()
		{
			if (skeletonRenderer == null)
			{
				return;
			}
			if (DLHCECFGFED == null)
			{
				DLHCECFGFED = new MaterialPropertyBlock();
			}
			IMOEBFCPIAB = skeletonRenderer.GetComponent<MeshRenderer>();
			skeletonRenderer.LEMGBCGDEGA -= FNCMBMGODDB;
			skeletonRenderer.LEMGBCGDEGA += FNCMBMGODDB;
			if (!copyMeshRendererFlags)
			{
				return;
			}
			LightProbeUsage lightProbeUsage = IMOEBFCPIAB.lightProbeUsage;
			bool receiveShadows = IMOEBFCPIAB.receiveShadows;
			ReflectionProbeUsage reflectionProbeUsage = IMOEBFCPIAB.reflectionProbeUsage;
			ShadowCastingMode shadowCastingMode = IMOEBFCPIAB.shadowCastingMode;
			MotionVectorGenerationMode motionVectorGenerationMode = IMOEBFCPIAB.motionVectorGenerationMode;
			Transform probeAnchor = IMOEBFCPIAB.probeAnchor;
			for (int i = 0; i < partsRenderers.Count; i++)
			{
				SkeletonPartsRenderer skeletonPartsRenderer = partsRenderers[i];
				if (!(skeletonPartsRenderer == null))
				{
					MeshRenderer meshRenderer = skeletonPartsRenderer.GADGIJJDPOL;
					meshRenderer.lightProbeUsage = lightProbeUsage;
					meshRenderer.receiveShadows = receiveShadows;
					meshRenderer.reflectionProbeUsage = reflectionProbeUsage;
					meshRenderer.shadowCastingMode = shadowCastingMode;
					meshRenderer.motionVectorGenerationMode = motionVectorGenerationMode;
					meshRenderer.probeAnchor = probeAnchor;
				}
			}
		}

		private void OnDisable()
		{
			if (skeletonRenderer == null)
			{
				return;
			}
			skeletonRenderer.LEMGBCGDEGA -= FNCMBMGODDB;
			foreach (SkeletonPartsRenderer partsRenderer in partsRenderers)
			{
				partsRenderer.ClearMesh();
			}
		}

		private void FNCMBMGODDB(OOBEMJJCEGO DOFGHNBCBCA)
		{
			int count = partsRenderers.Count;
			if (count <= 0)
			{
				return;
			}
			if (copyPropertyBlock)
			{
				IMOEBFCPIAB.GetPropertyBlock(DLHCECFGFED);
			}
			MeshGenerator.Settings settings = default(MeshGenerator.Settings);
			settings.addNormals = skeletonRenderer.addNormals;
			settings.calculateTangents = skeletonRenderer.calculateTangents;
			settings.immutableTriangles = false;
			settings.pmaVertexColors = skeletonRenderer.pmaVertexColors;
			settings.tintBlack = skeletonRenderer.tintBlack;
			settings.useClipping = true;
			settings.zSpacing = skeletonRenderer.zSpacing;
			MeshGenerator.Settings settings2 = settings;
			ExposedList<OFMBOEDKGMI> dJBCCKODCLK = DOFGHNBCBCA.DJBCCKODCLK;
			OFMBOEDKGMI[] items = dJBCCKODCLK.Items;
			int num = dJBCCKODCLK.Count - 1;
			int i = 0;
			SkeletonPartsRenderer skeletonPartsRenderer = partsRenderers[i];
			int j = 0;
			int kMDMNBKBMCH = 0;
			for (; j <= num; j++)
			{
				if (items[j].JLIINNOLOLC || j == num)
				{
					MeshGenerator meshGenerator = skeletonPartsRenderer.ADFCDNMCPDB;
					meshGenerator.settings = settings2;
					if (copyPropertyBlock)
					{
						skeletonPartsRenderer.SetPropertyBlock(DLHCECFGFED);
					}
					skeletonPartsRenderer.RenderParts(DOFGHNBCBCA.DJBCCKODCLK, kMDMNBKBMCH, j + 1);
					kMDMNBKBMCH = j + 1;
					i++;
					if (i >= count)
					{
						break;
					}
					skeletonPartsRenderer = partsRenderers[i];
				}
			}
			for (; i < count; i++)
			{
				partsRenderers[i].ClearMesh();
			}
		}
	}
}
