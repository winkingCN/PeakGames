using System;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace Spine.Unity.Modules
{
	[RequireComponent(typeof(SkeletonRenderer))]
	public class SkeletonGhost : MonoBehaviour
	{
		private const HideFlags IJCFBMMNFPE = HideFlags.HideInHierarchy;

		private const string OKAKFAHEEAJ = "Spine/Special/SkeletonGhost";

		public bool ghostingEnabled = true;

		public float spawnRate = 0.05f;

		public Color32 color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 0);

		[Tooltip("Remember to set color alpha to 0 if Additive is true")]
		public bool additive = true;

		public int maximumGhosts = 10;

		public float fadeSpeed = 10f;

		public Shader ghostShader;

		[Range(0f, 1f)]
		[Tooltip("0 is Color and Alpha, 1 is Alpha only.")]
		public float textureFade = 1f;

		[Header("Sorting")]
		public bool sortWithDistanceOnly;

		public float zOffset;

		private float HOCKLBONOLE;

		private SkeletonGhostRenderer[] GCFPIHOMIGJ;

		private int COFHFCJPHFC;

		private SkeletonRenderer NHPAGGIFGHN;

		private MeshRenderer MKCLCNPKGBC;

		private MeshFilter BOHOPOEDLMA;

		private readonly Dictionary<Material, Material> ADACLJPCEMI = new Dictionary<Material, Material>();

		private void Start()
		{
			if (ghostShader == null)
			{
				ghostShader = Shader.Find("Spine/Special/SkeletonGhost");
			}
			NHPAGGIFGHN = GetComponent<SkeletonRenderer>();
			BOHOPOEDLMA = GetComponent<MeshFilter>();
			MKCLCNPKGBC = GetComponent<MeshRenderer>();
			HOCKLBONOLE = Time.time + spawnRate;
			GCFPIHOMIGJ = new SkeletonGhostRenderer[maximumGhosts];
			for (int i = 0; i < maximumGhosts; i++)
			{
				GameObject gameObject = new GameObject(base.gameObject.name + " Ghost", typeof(SkeletonGhostRenderer));
				GCFPIHOMIGJ[i] = gameObject.GetComponent<SkeletonGhostRenderer>();
				gameObject.SetActive(false);
				gameObject.hideFlags = HideFlags.HideInHierarchy;
			}
			ILGBIBDBIAG iLGBIBDBIAG = NHPAGGIFGHN as ILGBIBDBIAG;
			if (iLGBIBDBIAG != null)
			{
				iLGBIBDBIAG.ANLDIDIBHAM.FAMOCPPGDPK += AAOONJHLMOM;
			}
		}

		private void AAOONJHLMOM(JHFLAELBLPM NBOKLOHDENL, DCBJAMHBAJB EKFOKNPODBK)
		{
			if (EKFOKNPODBK.LJDLCPHOBHB.PNGPLGHKFDI.Equals("Ghosting", StringComparison.Ordinal))
			{
				ghostingEnabled = EKFOKNPODBK.IOCBLKCOMGI > 0;
				if (EKFOKNPODBK.NCGJMNFFOJH > 0f)
				{
					spawnRate = EKFOKNPODBK.NCGJMNFFOJH;
				}
				if (!string.IsNullOrEmpty(EKFOKNPODBK.FGEEHHBILMN))
				{
					color = CJCOGNGABDB(EKFOKNPODBK.BECLAMGPAGN);
				}
			}
		}

		private void GEOFJPDOMCN(float HIMINGHNIKN)
		{
			ghostingEnabled = HIMINGHNIKN > 0f;
		}

		private void Update()
		{
			if (!ghostingEnabled || !(Time.time >= HOCKLBONOLE))
			{
				return;
			}
			GameObject gameObject = GCFPIHOMIGJ[COFHFCJPHFC].gameObject;
			Material[] sharedMaterials = MKCLCNPKGBC.sharedMaterials;
			for (int i = 0; i < sharedMaterials.Length; i++)
			{
				Material material = sharedMaterials[i];
				Material material2;
				if (!ADACLJPCEMI.ContainsKey(material))
				{
					material2 = new Material(material);
					material2.shader = ghostShader;
					material2.color = Color.white;
					if (material2.HasProperty("_TextureFade"))
					{
						material2.SetFloat("_TextureFade", textureFade);
					}
					ADACLJPCEMI.Add(material, material2);
				}
				else
				{
					material2 = ADACLJPCEMI[material];
				}
				sharedMaterials[i] = material2;
			}
			Transform transform = gameObject.transform;
			transform.parent = base.transform;
			GCFPIHOMIGJ[COFHFCJPHFC].Initialize(BOHOPOEDLMA.sharedMesh, sharedMaterials, color, additive, fadeSpeed, MKCLCNPKGBC.sortingLayerID, (!sortWithDistanceOnly) ? (MKCLCNPKGBC.sortingOrder - 1) : MKCLCNPKGBC.sortingOrder);
			transform.localPosition = new Vector3(0f, 0f, zOffset);
			transform.localRotation = Quaternion.identity;
			transform.localScale = Vector3.one;
			transform.parent = null;
			COFHFCJPHFC++;
			if (COFHFCJPHFC == GCFPIHOMIGJ.Length)
			{
				COFHFCJPHFC = 0;
			}
			HOCKLBONOLE = Time.time + spawnRate;
		}

		private void OnDestroy()
		{
			if (GCFPIHOMIGJ != null)
			{
				for (int i = 0; i < maximumGhosts; i++)
				{
					if (GCFPIHOMIGJ[i] != null)
					{
						GCFPIHOMIGJ[i].Cleanup();
					}
				}
			}
			foreach (Material value in ADACLJPCEMI.Values)
			{
				UnityEngine.Object.Destroy(value);
			}
		}

		private static Color32 CJCOGNGABDB(string PEGNALIKDPB)
		{
			if (PEGNALIKDPB.Length < 6)
			{
				return Color.magenta;
			}
			PEGNALIKDPB = PEGNALIKDPB.Replace("#", string.Empty);
			byte r = byte.Parse(PEGNALIKDPB.Substring(0, 2), NumberStyles.HexNumber);
			byte g = byte.Parse(PEGNALIKDPB.Substring(2, 2), NumberStyles.HexNumber);
			byte b = byte.Parse(PEGNALIKDPB.Substring(4, 2), NumberStyles.HexNumber);
			byte a = byte.MaxValue;
			if (PEGNALIKDPB.Length == 8)
			{
				a = byte.Parse(PEGNALIKDPB.Substring(6, 2), NumberStyles.HexNumber);
			}
			return new Color32(r, g, b, a);
		}
	}
}
