using System;
using System.Collections.Generic;
using UnityEngine;

namespace Spine.Unity.Modules
{
	public class AtlasRegionAttacher : MonoBehaviour
	{
		[Serializable]
		public class SlotRegionPair
		{
			[IEEPDCDKDNM("", "", false, true, false)]
			public string slot;

			[GFANFDCOGPD("")]
			public string region;
		}

		[SerializeField]
		protected AtlasAsset atlasAsset;

		[SerializeField]
		protected bool inheritProperties = true;

		[SerializeField]
		protected List<SlotRegionPair> attachments = new List<SlotRegionPair>();

		private GFNFFCGAGEH PEDNOBPHPHL;

		private void Awake()
		{
			SkeletonRenderer component = GetComponent<SkeletonRenderer>();
			component.BOAKMFAEPME += FCHLOGCODOA;
			if (component.valid)
			{
				FCHLOGCODOA(component);
			}
		}

		private void Start()
		{
		}

		private void FCHLOGCODOA(SkeletonRenderer NHPAGGIFGHN)
		{
			if (!base.enabled)
			{
				return;
			}
			PEDNOBPHPHL = atlasAsset.HBLFJLAAIBA();
			if (PEDNOBPHPHL == null)
			{
				return;
			}
			float scale = NHPAGGIFGHN.skeletonDataAsset.scale;
			foreach (SlotRegionPair attachment in attachments)
			{
				LBBAMMPJKDA lBBAMMPJKDA = NHPAGGIFGHN.LICMNMABJGL.MEKLNNENPDK(attachment.slot);
				OAMNGFLKEFI oAMNGFLKEFI = lBBAMMPJKDA.AIKFOHCPLKG;
				FCPKAKFLFEG fCPKAKFLFEG = PEDNOBPHPHL.GIGKGEPPBCG(attachment.region);
				if (fCPKAKFLFEG == null)
				{
					lBBAMMPJKDA.AIKFOHCPLKG = null;
					continue;
				}
				if (inheritProperties && oAMNGFLKEFI != null)
				{
					lBBAMMPJKDA.AIKFOHCPLKG = oAMNGFLKEFI.HLGNEIDODHP(fCPKAKFLFEG, true, true, scale);
					continue;
				}
				MKEALIMJCFJ eDDNOJDPMCF = fCPKAKFLFEG.GBANGNAEBAH(fCPKAKFLFEG.IOCMOCCFALN, scale);
				lBBAMMPJKDA.AIKFOHCPLKG = eDDNOJDPMCF;
			}
		}
	}
}
