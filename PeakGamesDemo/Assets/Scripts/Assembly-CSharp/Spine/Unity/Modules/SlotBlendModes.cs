using System.Collections.Generic;
using UnityEngine;

namespace Spine.Unity.Modules
{
	[DisallowMultipleComponent]
	public class SlotBlendModes : MonoBehaviour
	{
		public struct KLAPAKDLGID
		{
			public Texture2D LCNGHANCJPK;

			public Material GHPFOPNNJOB;
		}

		private static Dictionary<KLAPAKDLGID, Material> ADACLJPCEMI;

		public Material multiplyMaterialSource;

		public Material screenMaterialSource;

		private Texture2D CGIOFLEGCHD;

		internal static Dictionary<KLAPAKDLGID, Material> GCDMCLGLPOJ
		{
			get
			{
				if (ADACLJPCEMI == null)
				{
					ADACLJPCEMI = new Dictionary<KLAPAKDLGID, Material>();
				}
				return ADACLJPCEMI;
			}
		}

		public bool KNJFKDNFDCF { get; private set; }

		internal static Material KPDHKMCCMNE(Material AMNINLEKDAH, Texture2D CGIOFLEGCHD)
		{
			if (AMNINLEKDAH == null || CGIOFLEGCHD == null)
			{
				return null;
			}
			Dictionary<KLAPAKDLGID, Material> dictionary = GCDMCLGLPOJ;
			KLAPAKDLGID kLAPAKDLGID = default(KLAPAKDLGID);
			kLAPAKDLGID.GHPFOPNNJOB = AMNINLEKDAH;
			kLAPAKDLGID.LCNGHANCJPK = CGIOFLEGCHD;
			KLAPAKDLGID key = kLAPAKDLGID;
			Material value;
			if (!dictionary.TryGetValue(key, out value))
			{
				value = new Material(AMNINLEKDAH);
				value.name = "(Clone)" + CGIOFLEGCHD.name + "-" + AMNINLEKDAH.name;
				value.mainTexture = CGIOFLEGCHD;
				dictionary[key] = value;
			}
			return value;
		}

		private void Start()
		{
			if (!KNJFKDNFDCF)
			{
				Apply();
			}
		}

		private void OnDestroy()
		{
			if (KNJFKDNFDCF)
			{
				Remove();
			}
		}

		public void Apply()
		{
			GetTexture();
			if (CGIOFLEGCHD == null)
			{
				return;
			}
			SkeletonRenderer component = GetComponent<SkeletonRenderer>();
			if (component == null)
			{
				return;
			}
			Dictionary<LBBAMMPJKDA, Material> customSlotMaterials = component.ELKNHEGEMNL;
			using (ExposedList<LBBAMMPJKDA>.Enumerator enumerator = component.LICMNMABJGL.BKDKEAAAMBB.FIFMNBJLBFK())
			{
				while (enumerator.MoveNext())
				{
					LBBAMMPJKDA current = enumerator.Current;
					switch (current.MBBPBGHKLJM.DNLHLBINHHE)
					{
					case AOOPCGDMICP.Multiply:
						if (multiplyMaterialSource != null)
						{
							customSlotMaterials[current] = KPDHKMCCMNE(multiplyMaterialSource, CGIOFLEGCHD);
						}
						break;
					case AOOPCGDMICP.Screen:
						if (screenMaterialSource != null)
						{
							customSlotMaterials[current] = KPDHKMCCMNE(screenMaterialSource, CGIOFLEGCHD);
						}
						break;
					}
				}
			}
			KNJFKDNFDCF = true;
			component.LateUpdate();
		}

		public void Remove()
		{
			GetTexture();
			if (CGIOFLEGCHD == null)
			{
				return;
			}
			SkeletonRenderer component = GetComponent<SkeletonRenderer>();
			if (component == null)
			{
				return;
			}
			Dictionary<LBBAMMPJKDA, Material> customSlotMaterials = component.ELKNHEGEMNL;
			using (ExposedList<LBBAMMPJKDA>.Enumerator enumerator = component.LICMNMABJGL.BKDKEAAAMBB.FIFMNBJLBFK())
			{
				while (enumerator.MoveNext())
				{
					LBBAMMPJKDA current = enumerator.Current;
					Material value = null;
					switch (current.MBBPBGHKLJM.DNLHLBINHHE)
					{
					case AOOPCGDMICP.Multiply:
						if (customSlotMaterials.TryGetValue(current, out value) && object.ReferenceEquals(value, KPDHKMCCMNE(multiplyMaterialSource, CGIOFLEGCHD)))
						{
							customSlotMaterials.Remove(current);
						}
						break;
					case AOOPCGDMICP.Screen:
						if (customSlotMaterials.TryGetValue(current, out value) && object.ReferenceEquals(value, KPDHKMCCMNE(screenMaterialSource, CGIOFLEGCHD)))
						{
							customSlotMaterials.Remove(current);
						}
						break;
					}
				}
			}
			KNJFKDNFDCF = false;
			if (component.valid)
			{
				component.LateUpdate();
			}
		}

		public void GetTexture()
		{
			if (!(CGIOFLEGCHD == null))
			{
				return;
			}
			SkeletonRenderer component = GetComponent<SkeletonRenderer>();
			if (component == null)
			{
				return;
			}
			SkeletonDataAsset skeletonDataAsset = component.skeletonDataAsset;
			if (skeletonDataAsset == null)
			{
				return;
			}
			AtlasAsset atlasAsset = skeletonDataAsset.atlasAssets[0];
			if (!(atlasAsset == null))
			{
				Material material = atlasAsset.materials[0];
				if (!(material == null))
				{
					CGIOFLEGCHD = material.mainTexture as Texture2D;
				}
			}
		}
	}
}
