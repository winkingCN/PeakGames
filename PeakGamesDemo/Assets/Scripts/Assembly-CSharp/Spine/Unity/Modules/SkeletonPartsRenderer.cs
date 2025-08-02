using UnityEngine;

namespace Spine.Unity.Modules
{
	[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
	public class SkeletonPartsRenderer : MonoBehaviour
	{
		private MeshGenerator KBKIENONBJH;

		private MeshRenderer MKCLCNPKGBC;

		private MeshFilter BOHOPOEDLMA;

		private BINFNGNPCFJ KAMOOEFFFKM;

		private OOBEMJJCEGO PDFKDIJJGBA = new OOBEMJJCEGO();

		public MeshGenerator ADFCDNMCPDB
		{
			get
			{
				BBGDBMBPLAO();
				return KBKIENONBJH;
			}
		}

		public MeshRenderer GADGIJJDPOL
		{
			get
			{
				BBGDBMBPLAO();
				return MKCLCNPKGBC;
			}
		}

		public MeshFilter CPDONAMGKNE
		{
			get
			{
				BBGDBMBPLAO();
				return BOHOPOEDLMA;
			}
		}

		private void BBGDBMBPLAO()
		{
			if (KAMOOEFFFKM == null)
			{
				KAMOOEFFFKM = new BINFNGNPCFJ();
				KAMOOEFFFKM.JPLFFCHJICB();
				if (KBKIENONBJH == null)
				{
					KBKIENONBJH = new MeshGenerator();
					BOHOPOEDLMA = GetComponent<MeshFilter>();
					MKCLCNPKGBC = GetComponent<MeshRenderer>();
					PDFKDIJJGBA.BOPEPLONIFL();
				}
			}
		}

		public void ClearMesh()
		{
			BBGDBMBPLAO();
			BOHOPOEDLMA.sharedMesh = null;
		}

		public void RenderParts(ExposedList<OFMBOEDKGMI> NFGCPEEIEJN, int KMDMNBKBMCH, int HJLDJNLOPBB)
		{
			BBGDBMBPLAO();
			BINFNGNPCFJ.FGNAEHNOBLF fGNAEHNOBLF = KAMOOEFFFKM.HNNIMBHJGCO();
			PDFKDIJJGBA.OLPLFILLDNC(NFGCPEEIEJN, KMDMNBKBMCH, HJLDJNLOPBB);
			bool flag = OOBEMJJCEGO.EMENOEPELNK(PDFKDIJJGBA, fGNAEHNOBLF.FHHJCFPBCPD);
			OFMBOEDKGMI[] items = PDFKDIJJGBA.DJBCCKODCLK.Items;
			KBKIENONBJH.JLDDJANACLO();
			if (PDFKDIJJGBA.GHPJDHGHJNO)
			{
				for (int i = 0; i < PDFKDIJJGBA.DJBCCKODCLK.Count; i++)
				{
					KBKIENONBJH.IIEGHMLKOON(items[i], flag);
				}
			}
			else
			{
				KBKIENONBJH.PBMPDFLANCG(PDFKDIJJGBA, flag);
			}
			KAMOOEFFFKM.FCLCFDNLKDA(PDFKDIJJGBA.DJBCCKODCLK);
			Mesh iJKCGGPJDIG = fGNAEHNOBLF.IJKCGGPJDIG;
			if (KBKIENONBJH.VertexCount <= 0)
			{
				flag = false;
				iJKCGGPJDIG.Clear();
			}
			else
			{
				KBKIENONBJH.NKMGNENMGDJ(iJKCGGPJDIG);
				if (flag)
				{
					KBKIENONBJH.LGJAHPNKGIO(iJKCGGPJDIG);
					MKCLCNPKGBC.sharedMaterials = KAMOOEFFFKM.OJDOIDGNNLP();
				}
				else if (KAMOOEFFFKM.OMPHFIEOOAM())
				{
					MKCLCNPKGBC.sharedMaterials = KAMOOEFFFKM.OJDOIDGNNLP();
				}
			}
			BOHOPOEDLMA.sharedMesh = iJKCGGPJDIG;
			fGNAEHNOBLF.FHHJCFPBCPD.EPKMIBEOIJJ(PDFKDIJJGBA);
		}

		public void SetPropertyBlock(MaterialPropertyBlock OJEJPICFOOJ)
		{
			BBGDBMBPLAO();
			MKCLCNPKGBC.SetPropertyBlock(OJEJPICFOOJ);
		}

		public static SkeletonPartsRenderer NewPartsRendererGameObject(Transform LIMMFGDCLAB, string IOCMOCCFALN)
		{
			GameObject gameObject = new GameObject(IOCMOCCFALN, typeof(MeshFilter), typeof(MeshRenderer));
			gameObject.transform.SetParent(LIMMFGDCLAB, false);
			return gameObject.AddComponent<SkeletonPartsRenderer>();
		}
	}
}
