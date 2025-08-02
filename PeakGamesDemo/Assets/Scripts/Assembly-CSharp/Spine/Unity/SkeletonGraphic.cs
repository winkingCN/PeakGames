using UnityEngine;
using UnityEngine.UI;

namespace Spine.Unity
{
	[RequireComponent(typeof(CanvasRenderer), typeof(RectTransform))]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[AddComponentMenu("Spine/SkeletonGraphic (Unity UI Canvas)")]
	public class SkeletonGraphic : MaskableGraphic, NKPMIHKBBAH, ILGBIBDBIAG, OAGCBGJOPGD
	{
		public SkeletonDataAsset skeletonDataAsset;

		[AJANGGDMDOM("", "skeletonDataAsset", true, false)]
		public string initialSkinName = "default";

		public bool initialFlipX;

		public bool initialFlipY;

		[HPODBBIKPLB("", "skeletonDataAsset", true, false)]
		public string startingAnimation;

		public bool startingLoop;

		public float timeScale = 1f;

		public bool freeze;

		public bool unscaledTime;

		private Texture FNNLGAKDDHO;

		protected GCJKICAPOFL GDNININLMFD;

		protected KJKAIEHNGAL BGEDKGLJIGM;

		[SerializeField]
		protected MeshGenerator meshGenerator = new MeshGenerator();

		private global::ACEOIDJCHFL<BINFNGNPCFJ.FGNAEHNOBLF> GOBJNJDPECN;

		private OOBEMJJCEGO PDFKDIJJGBA = new OOBEMJJCEGO();

		public SkeletonDataAsset OCNJEHLCCDG
		{
			get
			{
				return skeletonDataAsset;
			}
		}

		public Texture JJJMDOCGBBD
		{
			get
			{
				return FNNLGAKDDHO;
			}
			set
			{
				FNNLGAKDDHO = value;
				base.canvasRenderer.SetTexture(mainTexture);
			}
		}

		public override Texture CJNCIEDBHNM
		{
			get
			{
				if (FNNLGAKDDHO != null)
				{
					return FNNLGAKDDHO;
				}
				return (!(skeletonDataAsset == null)) ? skeletonDataAsset.atlasAssets[0].materials[0].mainTexture : null;
			}
		}

		public GCJKICAPOFL LICMNMABJGL
		{
			get
			{
				return GDNININLMFD;
			}
		}

		public KGMHJGFNPFC NKJHFDKAPIE
		{
			get
			{
				return (GDNININLMFD != null) ? GDNININLMFD.MBBPBGHKLJM : null;
			}
		}

		public bool NAFCDEECGEF
		{
			get
			{
				return GDNININLMFD != null;
			}
		}

		public KJKAIEHNGAL ANLDIDIBHAM
		{
			get
			{
				return BGEDKGLJIGM;
			}
		}

		public MeshGenerator ADFCDNMCPDB
		{
			get
			{
				return meshGenerator;
			}
		}

		public event JNGOIOMIBKL HIMOJNHKFMC;

		public event JNGOIOMIBKL MPLLKFLOEHE;

		public event JNGOIOMIBKL MBJAPEPNHNB;

		public event PAIHCCECHLB BGAHEPJNMLN;

		public static SkeletonGraphic NewSkeletonGraphicGameObject(SkeletonDataAsset KAFMHICMBHN, Transform LIMMFGDCLAB)
		{
			SkeletonGraphic skeletonGraphic = AddSkeletonGraphicComponent(new GameObject("New Spine GameObject"), KAFMHICMBHN);
			if (LIMMFGDCLAB != null)
			{
				skeletonGraphic.transform.SetParent(LIMMFGDCLAB, false);
			}
			return skeletonGraphic;
		}

		public static SkeletonGraphic AddSkeletonGraphicComponent(GameObject HCEDAECPCIA, SkeletonDataAsset KAFMHICMBHN)
		{
			SkeletonGraphic skeletonGraphic = HCEDAECPCIA.AddComponent<SkeletonGraphic>();
			if (KAFMHICMBHN != null)
			{
				skeletonGraphic.skeletonDataAsset = KAFMHICMBHN;
				skeletonGraphic.Initialize(false);
			}
			return skeletonGraphic;
		}

		protected override void Awake()
		{
			base.Awake();
			if (!NAFCDEECGEF)
			{
				Initialize(false);
				Rebuild(CanvasUpdate.PreRender);
			}
		}

		public override void Rebuild(CanvasUpdate LMJFIOAJCGK)
		{
			base.Rebuild(LMJFIOAJCGK);
			if (!base.canvasRenderer.cull && LMJFIOAJCGK == CanvasUpdate.PreRender)
			{
				UpdateMesh();
			}
		}

		public virtual void Update()
		{
			if (!freeze)
			{
				Update((!unscaledTime) ? Time.deltaTime : Time.unscaledDeltaTime);
			}
		}

		public virtual void Update(float CFENOBBDOHG)
		{
			if (NAFCDEECGEF)
			{
				CFENOBBDOHG *= timeScale;
				GDNININLMFD.BPAJGOINFNL(CFENOBBDOHG);
				BGEDKGLJIGM.BPAJGOINFNL(CFENOBBDOHG);
				BGEDKGLJIGM.FCHLOGCODOA(GDNININLMFD);
				if (this.HIMOJNHKFMC != null)
				{
					this.HIMOJNHKFMC(this);
				}
				GDNININLMFD.DGCKCELHAEG();
				if (this.MPLLKFLOEHE != null)
				{
					this.MPLLKFLOEHE(this);
					GDNININLMFD.DGCKCELHAEG();
				}
				if (this.MBJAPEPNHNB != null)
				{
					this.MBJAPEPNHNB(this);
				}
			}
		}

		public void LateUpdate()
		{
			if (!freeze)
			{
				UpdateMesh();
			}
		}

		public Mesh GetLastMesh()
		{
			return GOBJNJDPECN.OAFAPDHKFLP().IJKCGGPJDIG;
		}

		public void Clear()
		{
			GDNININLMFD = null;
			base.canvasRenderer.Clear();
		}

		public void Initialize(bool AJMAKDEFBOL)
		{
			if ((NAFCDEECGEF && !AJMAKDEFBOL) || skeletonDataAsset == null)
			{
				return;
			}
			KGMHJGFNPFC kGMHJGFNPFC = skeletonDataAsset.CPILINNBJLL(false);
			if (kGMHJGFNPFC == null || skeletonDataAsset.atlasAssets.Length <= 0 || skeletonDataAsset.atlasAssets[0].materials.Length <= 0)
			{
				return;
			}
			BGEDKGLJIGM = new KJKAIEHNGAL(skeletonDataAsset.AFBPPBHHKFB());
			if (BGEDKGLJIGM == null)
			{
				Clear();
				return;
			}
			GDNININLMFD = new GCJKICAPOFL(kGMHJGFNPFC)
			{
				FNEPOOBKNLF = initialFlipX,
				AIPMEJLIOFD = initialFlipY
			};
			GOBJNJDPECN = new global::ACEOIDJCHFL<BINFNGNPCFJ.FGNAEHNOBLF>();
			base.canvasRenderer.SetTexture(mainTexture);
			if (!string.IsNullOrEmpty(initialSkinName))
			{
				GDNININLMFD.NGKEKDBDPEN(initialSkinName);
			}
			if (!string.IsNullOrEmpty(startingAnimation))
			{
				BGEDKGLJIGM.LMHOONAMFIJ(0, startingAnimation, startingLoop);
				Update(0f);
			}
		}

		public void UpdateMesh()
		{
			if (NAFCDEECGEF)
			{
				GDNININLMFD.FHGEHEFAHKO(color);
				BINFNGNPCFJ.FGNAEHNOBLF fGNAEHNOBLF = GOBJNJDPECN.ALEKLIDGIEI();
				OOBEMJJCEGO pDFKDIJJGBA = PDFKDIJJGBA;
				MeshGenerator.AMPBCIMDBDP(pDFKDIJJGBA, GDNININLMFD, material);
				bool flag = OOBEMJJCEGO.EMENOEPELNK(pDFKDIJJGBA, fGNAEHNOBLF.FHHJCFPBCPD);
				meshGenerator.JLDDJANACLO();
				if (pDFKDIJJGBA.GHPJDHGHJNO)
				{
					meshGenerator.IIEGHMLKOON(pDFKDIJJGBA.DJBCCKODCLK.Items[0], flag);
				}
				else
				{
					meshGenerator.PBMPDFLANCG(pDFKDIJJGBA, flag);
				}
				if (base.canvas != null)
				{
					meshGenerator.JKJBGDOOLKA(base.canvas.referencePixelsPerUnit);
				}
				if (this.BGAHEPJNMLN != null)
				{
					this.BGAHEPJNMLN(meshGenerator.Buffers);
				}
				Mesh iJKCGGPJDIG = fGNAEHNOBLF.IJKCGGPJDIG;
				meshGenerator.NKMGNENMGDJ(iJKCGGPJDIG);
				if (flag)
				{
					meshGenerator.DOPHHKAJJEJ(iJKCGGPJDIG);
				}
				base.canvasRenderer.SetMesh(iJKCGGPJDIG);
				fGNAEHNOBLF.FHHJCFPBCPD.EPKMIBEOIJJ(pDFKDIJJGBA);
			}
		}
	}
}
