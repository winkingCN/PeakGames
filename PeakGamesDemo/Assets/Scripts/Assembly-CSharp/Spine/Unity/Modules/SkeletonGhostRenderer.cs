using System.Collections;
using UnityEngine;

namespace Spine.Unity.Modules
{
	public class SkeletonGhostRenderer : MonoBehaviour
	{
		public float fadeSpeed = 10f;

		private Color32[] MABENDNHDPI;

		private Color32 MBBJLKLHAEI = new Color32(0, 0, 0, 0);

		private MeshFilter BOHOPOEDLMA;

		private MeshRenderer MKCLCNPKGBC;

		private void Awake()
		{
			MKCLCNPKGBC = base.gameObject.AddComponent<MeshRenderer>();
			BOHOPOEDLMA = base.gameObject.AddComponent<MeshFilter>();
		}

		public void Initialize(Mesh IJKCGGPJDIG, Material[] IDBMABBJCNC, Color32 MFODILBOMGD, bool JFOAOMCACHG, float NMEFMHLPOFH, int IKJGCDCDCCJ, int GDDGFAKOCIL)
		{
			StopAllCoroutines();
			base.gameObject.SetActive(true);
			MKCLCNPKGBC.sharedMaterials = IDBMABBJCNC;
			MKCLCNPKGBC.sortingLayerID = IKJGCDCDCCJ;
			MKCLCNPKGBC.sortingOrder = GDDGFAKOCIL;
			BOHOPOEDLMA.sharedMesh = Object.Instantiate(IJKCGGPJDIG);
			MABENDNHDPI = BOHOPOEDLMA.sharedMesh.colors32;
			if (MFODILBOMGD.a + MFODILBOMGD.r + MFODILBOMGD.g + MFODILBOMGD.b > 0)
			{
				for (int i = 0; i < MABENDNHDPI.Length; i++)
				{
					MABENDNHDPI[i] = MFODILBOMGD;
				}
			}
			fadeSpeed = NMEFMHLPOFH;
			if (JFOAOMCACHG)
			{
				StartCoroutine(BPPAFCFADBM());
			}
			else
			{
				StartCoroutine(EAMKGMFJJNA());
			}
		}

		private IEnumerator EAMKGMFJJNA()
		{
			for (int i = 0; i < 500; i++)
			{
				bool flag = true;
				for (int j = 0; j < MABENDNHDPI.Length; j++)
				{
					Color32 a = MABENDNHDPI[j];
					if (a.a > 0)
					{
						flag = false;
					}
					MABENDNHDPI[j] = Color32.Lerp(a, MBBJLKLHAEI, Time.deltaTime * fadeSpeed);
				}
				BOHOPOEDLMA.sharedMesh.colors32 = MABENDNHDPI;
				if (flag)
				{
					break;
				}
				yield return null;
			}
			Object.Destroy(BOHOPOEDLMA.sharedMesh);
			base.gameObject.SetActive(false);
		}

		private IEnumerator BPPAFCFADBM()
		{
			Color32 mBBJLKLHAEI = MBBJLKLHAEI;
			for (int i = 0; i < 500; i++)
			{
				bool flag = true;
				for (int j = 0; j < MABENDNHDPI.Length; j++)
				{
					Color32 a = MABENDNHDPI[j];
					mBBJLKLHAEI.a = a.a;
					if (a.r > 0 || a.g > 0 || a.b > 0)
					{
						flag = false;
					}
					MABENDNHDPI[j] = Color32.Lerp(a, mBBJLKLHAEI, Time.deltaTime * fadeSpeed);
				}
				BOHOPOEDLMA.sharedMesh.colors32 = MABENDNHDPI;
				if (flag)
				{
					break;
				}
				yield return null;
			}
			Object.Destroy(BOHOPOEDLMA.sharedMesh);
			base.gameObject.SetActive(false);
		}

		public void Cleanup()
		{
			if (BOHOPOEDLMA != null && BOHOPOEDLMA.sharedMesh != null)
			{
				Object.Destroy(BOHOPOEDLMA.sharedMesh);
			}
			Object.Destroy(base.gameObject);
		}
	}
}
