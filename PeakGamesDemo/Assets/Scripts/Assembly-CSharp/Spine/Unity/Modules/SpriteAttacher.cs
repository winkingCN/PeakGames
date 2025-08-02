using System.Collections.Generic;
using UnityEngine;

namespace Spine.Unity.Modules
{
	public class SpriteAttacher : MonoBehaviour
	{
		public const string DefaultPMAShader = "Spine/Skeleton";

		public const string DefaultStraightAlphaShader = "Sprites/Default";

		public bool attachOnStart = true;

		public bool overrideAnimation = true;

		public Sprite sprite;

		[IEEPDCDKDNM("", "", false, true, false)]
		public string slot;

		private MKEALIMJCFJ DFHHMKMLCFF;

		private LBBAMMPJKDA ECNFNDBDDKK;

		private bool PFGDLFPJMBA;

		private static Dictionary<Texture, LLLHGJNHPML> FLJCIMLEGCD;

		private static LLLHGJNHPML BPINCOGMMNO(Texture CGIOFLEGCHD, Shader BLCFLFHNKFG)
		{
			if (FLJCIMLEGCD == null)
			{
				FLJCIMLEGCD = new Dictionary<Texture, LLLHGJNHPML>();
			}
			LLLHGJNHPML value;
			FLJCIMLEGCD.TryGetValue(CGIOFLEGCHD, out value);
			if (value == null)
			{
				Material cEKMAJAHNAG = new Material(BLCFLFHNKFG);
				value = cEKMAJAHNAG.PAOAGJDAHME();
				FLJCIMLEGCD[CGIOFLEGCHD] = value;
			}
			return value;
		}

		private void Start()
		{
			Initialize(false);
			if (attachOnStart)
			{
				Attach();
			}
		}

		private void PKHJFCOALNG(OAGCBGJOPGD ODJGLICBNKH)
		{
			if (overrideAnimation && base.isActiveAndEnabled)
			{
				Attach();
			}
		}

		public void Initialize(bool AJMAKDEFBOL = true)
		{
			if (!AJMAKDEFBOL && DFHHMKMLCFF != null)
			{
				return;
			}
			NKPMIHKBBAH component = GetComponent<NKPMIHKBBAH>();
			SkeletonRenderer skeletonRenderer = component as SkeletonRenderer;
			if (skeletonRenderer != null)
			{
				PFGDLFPJMBA = skeletonRenderer.pmaVertexColors;
			}
			else
			{
				SkeletonGraphic skeletonGraphic = component as SkeletonGraphic;
				if (skeletonGraphic != null)
				{
					PFGDLFPJMBA = skeletonGraphic.ADFCDNMCPDB.settings.pmaVertexColors;
				}
			}
			if (overrideAnimation)
			{
				OAGCBGJOPGD oAGCBGJOPGD = component as OAGCBGJOPGD;
				if (oAGCBGJOPGD != null)
				{
					oAGCBGJOPGD.MBJAPEPNHNB -= PKHJFCOALNG;
					oAGCBGJOPGD.MBJAPEPNHNB += PKHJFCOALNG;
				}
			}
			ECNFNDBDDKK = ECNFNDBDDKK ?? component.LICMNMABJGL.MEKLNNENPDK(slot);
			Shader bLCFLFHNKFG = ((!PFGDLFPJMBA) ? Shader.Find("Sprites/Default") : Shader.Find("Spine/Skeleton"));
			DFHHMKMLCFF = ((!PFGDLFPJMBA) ? sprite.GBANGNAEBAH(BPINCOGMMNO(sprite.texture, bLCFLFHNKFG)) : sprite.GCAIEFLKMON(bLCFLFHNKFG));
		}

		private void OnDestroy()
		{
			OAGCBGJOPGD component = GetComponent<OAGCBGJOPGD>();
			if (component != null)
			{
				component.MBJAPEPNHNB -= PKHJFCOALNG;
			}
		}

		public void Attach()
		{
			if (ECNFNDBDDKK != null)
			{
				ECNFNDBDDKK.AIKFOHCPLKG = DFHHMKMLCFF;
			}
		}
	}
}
