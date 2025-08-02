using System;
using System.Collections.Generic;
using UnityEngine;

namespace Spine.Unity.Modules
{
	[ExecuteInEditMode]
	public class SkeletonRendererCustomMaterials : MonoBehaviour
	{
		[Serializable]
		public struct SlotMaterialOverride : IEquatable<SlotMaterialOverride>
		{
			public bool overrideDisabled;

			[IEEPDCDKDNM("", "", false, true, false)]
			public string slotName;

			public Material material;

			public bool Equals(SlotMaterialOverride CJHEIBNHNNE)
			{
				return overrideDisabled == CJHEIBNHNNE.overrideDisabled && slotName == CJHEIBNHNNE.slotName && material == CJHEIBNHNNE.material;
			}
		}

		[Serializable]
		public struct AtlasMaterialOverride : IEquatable<AtlasMaterialOverride>
		{
			public bool overrideDisabled;

			public Material originalMaterial;

			public Material replacementMaterial;

			public bool Equals(AtlasMaterialOverride CJHEIBNHNNE)
			{
				return overrideDisabled == CJHEIBNHNNE.overrideDisabled && originalMaterial == CJHEIBNHNNE.originalMaterial && replacementMaterial == CJHEIBNHNNE.replacementMaterial;
			}
		}

		public SkeletonRenderer skeletonRenderer;

		[SerializeField]
		protected List<SlotMaterialOverride> customSlotMaterials = new List<SlotMaterialOverride>();

		[SerializeField]
		protected List<AtlasMaterialOverride> customMaterialOverrides = new List<AtlasMaterialOverride>();

		private void LFGMJCDFJPN()
		{
			if (skeletonRenderer == null)
			{
				Debug.LogError("skeletonRenderer == null");
				return;
			}
			for (int i = 0; i < customSlotMaterials.Count; i++)
			{
				SlotMaterialOverride slotMaterialOverride = customSlotMaterials[i];
				if (!slotMaterialOverride.overrideDisabled && !string.IsNullOrEmpty(slotMaterialOverride.slotName))
				{
					LBBAMMPJKDA key = skeletonRenderer.skeleton.MEKLNNENPDK(slotMaterialOverride.slotName);
					skeletonRenderer.ELKNHEGEMNL[key] = slotMaterialOverride.material;
				}
			}
		}

		private void KDPANJBLNAN()
		{
			if (skeletonRenderer == null)
			{
				Debug.LogError("skeletonRenderer == null");
				return;
			}
			for (int i = 0; i < customSlotMaterials.Count; i++)
			{
				SlotMaterialOverride slotMaterialOverride = customSlotMaterials[i];
				if (!string.IsNullOrEmpty(slotMaterialOverride.slotName))
				{
					LBBAMMPJKDA key = skeletonRenderer.skeleton.MEKLNNENPDK(slotMaterialOverride.slotName);
					Material value;
					if (skeletonRenderer.ELKNHEGEMNL.TryGetValue(key, out value) && !(value != slotMaterialOverride.material))
					{
						skeletonRenderer.ELKNHEGEMNL.Remove(key);
					}
				}
			}
		}

		private void EGKEAFPJCAD()
		{
			if (skeletonRenderer == null)
			{
				Debug.LogError("skeletonRenderer == null");
				return;
			}
			for (int i = 0; i < customMaterialOverrides.Count; i++)
			{
				AtlasMaterialOverride atlasMaterialOverride = customMaterialOverrides[i];
				if (!atlasMaterialOverride.overrideDisabled)
				{
					skeletonRenderer.AEENHDBMKHL[atlasMaterialOverride.originalMaterial] = atlasMaterialOverride.replacementMaterial;
				}
			}
		}

		private void DFDBMINDDGN()
		{
			if (skeletonRenderer == null)
			{
				Debug.LogError("skeletonRenderer == null");
				return;
			}
			for (int i = 0; i < customMaterialOverrides.Count; i++)
			{
				AtlasMaterialOverride atlasMaterialOverride = customMaterialOverrides[i];
				Material value;
				if (skeletonRenderer.AEENHDBMKHL.TryGetValue(atlasMaterialOverride.originalMaterial, out value) && !(value != atlasMaterialOverride.replacementMaterial))
				{
					skeletonRenderer.AEENHDBMKHL.Remove(atlasMaterialOverride.originalMaterial);
				}
			}
		}

		private void OnEnable()
		{
			if (skeletonRenderer == null)
			{
				skeletonRenderer = GetComponent<SkeletonRenderer>();
			}
			if (skeletonRenderer == null)
			{
				Debug.LogError("skeletonRenderer == null");
				return;
			}
			skeletonRenderer.Initialize(false);
			EGKEAFPJCAD();
			LFGMJCDFJPN();
		}

		private void OnDisable()
		{
			if (skeletonRenderer == null)
			{
				Debug.LogError("skeletonRenderer == null");
				return;
			}
			DFDBMINDDGN();
			KDPANJBLNAN();
		}
	}
}
