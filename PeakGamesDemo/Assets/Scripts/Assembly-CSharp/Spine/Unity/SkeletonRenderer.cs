using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Spine.Unity
{
	[HelpURL("http://esotericsoftware.com/spine-unity-documentation#Rendering")]
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class SkeletonRenderer : MonoBehaviour, NKPMIHKBBAH
	{
		public delegate void LPJLDMAAAOG(SkeletonRenderer NHPAGGIFGHN);

		public delegate void PKCAPPKCMPP(OOBEMJJCEGO DOFGHNBCBCA);

		public SkeletonDataAsset skeletonDataAsset;

		public string initialSkinName;

		public bool initialFlipX;

		public bool initialFlipY;

		[FormerlySerializedAs("submeshSeparators")]
		[IEEPDCDKDNM("", "", false, true, false)]
		public string[] separatorSlotNames = new string[0];

		[NonSerialized]
		public readonly List<LBBAMMPJKDA> separatorSlots = new List<LBBAMMPJKDA>();

		[Range(-0.1f, 0f)]
		public float zSpacing;

		public bool useClipping = true;

		public bool immutableTriangles;

		public bool pmaVertexColors = true;

		public bool clearStateOnDisable;

		public bool tintBlack;

		public bool singleSubmesh;

		[FormerlySerializedAs("calculateNormals")]
		public bool addNormals;

		public bool calculateTangents;

		public bool logErrors;

		public bool disableRenderingOnOverride = true;

		[NonSerialized]
		private readonly Dictionary<Material, Material> GFPOJPJNIPJ = new Dictionary<Material, Material>();

		[NonSerialized]
		private readonly Dictionary<LBBAMMPJKDA, Material> FICAMCEHGBJ = new Dictionary<LBBAMMPJKDA, Material>();

		private MeshRenderer MKCLCNPKGBC;

		private MeshFilter BOHOPOEDLMA;

		[NonSerialized]
		public bool valid;

		[NonSerialized]
		public GCJKICAPOFL skeleton;

		[NonSerialized]
		private readonly OOBEMJJCEGO PDFKDIJJGBA = new OOBEMJJCEGO();

		private readonly MeshGenerator KBKIENONBJH = new MeshGenerator();

		[NonSerialized]
		private readonly BINFNGNPCFJ FHBDBEJJJDC = new BINFNGNPCFJ();

		public SkeletonDataAsset OCNJEHLCCDG
		{
			get
			{
				return skeletonDataAsset;
			}
		}

		public Dictionary<Material, Material> AEENHDBMKHL
		{
			get
			{
				return GFPOJPJNIPJ;
			}
		}

		public Dictionary<LBBAMMPJKDA, Material> ELKNHEGEMNL
		{
			get
			{
				return FICAMCEHGBJ;
			}
		}

		public GCJKICAPOFL LICMNMABJGL
		{
			get
			{
				Initialize(false);
				return skeleton;
			}
		}

		public event LPJLDMAAAOG BOAKMFAEPME;

		public event PAIHCCECHLB BGAHEPJNMLN;

		private event PKCAPPKCMPP LNEOAKBJFCJ;

		public event PKCAPPKCMPP LEMGBCGDEGA
		{
			add
			{
				LNEOAKBJFCJ += value;
				if (disableRenderingOnOverride && this.LNEOAKBJFCJ != null)
				{
					Initialize(false);
					MKCLCNPKGBC.enabled = false;
				}
			}
			remove
			{
				LNEOAKBJFCJ -= value;
				if (disableRenderingOnOverride && this.LNEOAKBJFCJ == null)
				{
					Initialize(false);
					MKCLCNPKGBC.enabled = true;
				}
			}
		}

		public static T NewSpineGameObject<T>(SkeletonDataAsset KAFMHICMBHN) where T : SkeletonRenderer
		{
			return AddSpineComponent<T>(new GameObject("New Spine GameObject"), KAFMHICMBHN);
		}

		public static T AddSpineComponent<T>(GameObject HCEDAECPCIA, SkeletonDataAsset KAFMHICMBHN) where T : SkeletonRenderer
		{
			T val = HCEDAECPCIA.AddComponent<T>();
			if (KAFMHICMBHN != null)
			{
				val.skeletonDataAsset = KAFMHICMBHN;
				val.Initialize(false);
			}
			return val;
		}

		public void SetMeshSettings(MeshGenerator.Settings EFHGEMMPDPC)
		{
			calculateTangents = EFHGEMMPDPC.calculateTangents;
			immutableTriangles = EFHGEMMPDPC.immutableTriangles;
			pmaVertexColors = EFHGEMMPDPC.pmaVertexColors;
			tintBlack = EFHGEMMPDPC.tintBlack;
			useClipping = EFHGEMMPDPC.useClipping;
			zSpacing = EFHGEMMPDPC.zSpacing;
			KBKIENONBJH.settings = EFHGEMMPDPC;
		}

		public virtual void Awake()
		{
			Initialize(false);
		}

		private void OnDisable()
		{
			if (clearStateOnDisable && valid)
			{
				ClearState();
			}
		}

		private void OnDestroy()
		{
			FHBDBEJJJDC.Dispose();
			valid = false;
		}

		public virtual void ClearState()
		{
			BOHOPOEDLMA.sharedMesh = null;
			PDFKDIJJGBA.BOPEPLONIFL();
			if (skeleton != null)
			{
				skeleton.ODJKPILHIOD();
			}
		}

		public virtual void Initialize(bool AJMAKDEFBOL)
		{
			if (valid && !AJMAKDEFBOL)
			{
				return;
			}
			if (BOHOPOEDLMA != null)
			{
				BOHOPOEDLMA.sharedMesh = null;
			}
			MKCLCNPKGBC = GetComponent<MeshRenderer>();
			if (MKCLCNPKGBC != null)
			{
				MKCLCNPKGBC.sharedMaterial = null;
			}
			PDFKDIJJGBA.BOPEPLONIFL();
			FHBDBEJJJDC.BOPEPLONIFL();
			KBKIENONBJH.JLDDJANACLO();
			skeleton = null;
			valid = false;
			if (!skeletonDataAsset)
			{
				if (logErrors)
				{
					Debug.LogError("Missing SkeletonData asset.", this);
				}
				return;
			}
			KGMHJGFNPFC kGMHJGFNPFC = skeletonDataAsset.CPILINNBJLL(false);
			if (kGMHJGFNPFC != null)
			{
				valid = true;
				BOHOPOEDLMA = GetComponent<MeshFilter>();
				MKCLCNPKGBC = GetComponent<MeshRenderer>();
				FHBDBEJJJDC.JPLFFCHJICB();
				skeleton = new GCJKICAPOFL(kGMHJGFNPFC)
				{
					FNEPOOBKNLF = initialFlipX,
					AIPMEJLIOFD = initialFlipY
				};
				if (!string.IsNullOrEmpty(initialSkinName) && !string.Equals(initialSkinName, "default", StringComparison.Ordinal))
				{
					skeleton.NGKEKDBDPEN(initialSkinName);
				}
				separatorSlots.Clear();
				for (int i = 0; i < separatorSlotNames.Length; i++)
				{
					separatorSlots.Add(skeleton.MEKLNNENPDK(separatorSlotNames[i]));
				}
				LateUpdate();
				if (this.BOAKMFAEPME != null)
				{
					this.BOAKMFAEPME(this);
				}
			}
		}

		public virtual void LateUpdate()
		{
			if (!valid)
			{
				return;
			}
			bool flag = this.LNEOAKBJFCJ != null;
			if (!MKCLCNPKGBC.enabled && !flag)
			{
				return;
			}
			OOBEMJJCEGO pDFKDIJJGBA = PDFKDIJJGBA;
			ExposedList<OFMBOEDKGMI> dJBCCKODCLK = pDFKDIJJGBA.DJBCCKODCLK;
			BINFNGNPCFJ.FGNAEHNOBLF fGNAEHNOBLF = FHBDBEJJJDC.HNNIMBHJGCO();
			bool flag2;
			if (singleSubmesh)
			{
				MeshGenerator.AMPBCIMDBDP(pDFKDIJJGBA, skeleton, skeletonDataAsset.atlasAssets[0].materials[0]);
				if (GFPOJPJNIPJ.Count > 0)
				{
					MeshGenerator.DMIEAEEHMGH(dJBCCKODCLK, GFPOJPJNIPJ);
				}
				KBKIENONBJH.settings = new MeshGenerator.Settings
				{
					pmaVertexColors = pmaVertexColors,
					zSpacing = zSpacing,
					useClipping = useClipping,
					tintBlack = tintBlack,
					calculateTangents = calculateTangents,
					addNormals = addNormals
				};
				KBKIENONBJH.JLDDJANACLO();
				flag2 = OOBEMJJCEGO.EMENOEPELNK(pDFKDIJJGBA, fGNAEHNOBLF.FHHJCFPBCPD);
				if (pDFKDIJJGBA.GHPJDHGHJNO)
				{
					KBKIENONBJH.IIEGHMLKOON(dJBCCKODCLK.Items[0], flag2);
				}
				else
				{
					KBKIENONBJH.PBMPDFLANCG(pDFKDIJJGBA, flag2);
				}
			}
			else
			{
				MeshGenerator.HBIMAGKOPGB(pDFKDIJJGBA, skeleton, FICAMCEHGBJ, separatorSlots, flag, immutableTriangles);
				if (GFPOJPJNIPJ.Count > 0)
				{
					MeshGenerator.DMIEAEEHMGH(dJBCCKODCLK, GFPOJPJNIPJ);
				}
				if (flag)
				{
					this.LNEOAKBJFCJ(pDFKDIJJGBA);
					if (disableRenderingOnOverride)
					{
						return;
					}
				}
				flag2 = OOBEMJJCEGO.EMENOEPELNK(pDFKDIJJGBA, fGNAEHNOBLF.FHHJCFPBCPD);
				KBKIENONBJH.settings = new MeshGenerator.Settings
				{
					pmaVertexColors = pmaVertexColors,
					zSpacing = zSpacing,
					useClipping = useClipping,
					tintBlack = tintBlack,
					calculateTangents = calculateTangents,
					addNormals = addNormals
				};
				KBKIENONBJH.JLDDJANACLO();
				if (pDFKDIJJGBA.GHPJDHGHJNO)
				{
					KBKIENONBJH.AMKBHKLOLMH(pDFKDIJJGBA, flag2);
				}
				else
				{
					KBKIENONBJH.PBMPDFLANCG(pDFKDIJJGBA, flag2);
				}
			}
			if (this.BGAHEPJNMLN != null)
			{
				this.BGAHEPJNMLN(KBKIENONBJH.Buffers);
			}
			Mesh iJKCGGPJDIG = fGNAEHNOBLF.IJKCGGPJDIG;
			KBKIENONBJH.NKMGNENMGDJ(iJKCGGPJDIG);
			FHBDBEJJJDC.FCLCFDNLKDA(dJBCCKODCLK);
			if (flag2)
			{
				KBKIENONBJH.LGJAHPNKGIO(iJKCGGPJDIG);
				MKCLCNPKGBC.sharedMaterials = FHBDBEJJJDC.OJDOIDGNNLP();
			}
			else if (FHBDBEJJJDC.OMPHFIEOOAM())
			{
				MKCLCNPKGBC.sharedMaterials = FHBDBEJJJDC.OJDOIDGNNLP();
			}
			BOHOPOEDLMA.sharedMesh = iJKCGGPJDIG;
			fGNAEHNOBLF.FHHJCFPBCPD.EPKMIBEOIJJ(pDFKDIJJGBA);
		}
	}
}
