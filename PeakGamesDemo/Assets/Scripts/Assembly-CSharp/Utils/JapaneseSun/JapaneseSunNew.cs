using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace Utils.JapaneseSun
{
	[ExecuteInEditMode]
	public class JapaneseSunNew : MonoBehaviour
	{
		public int Count = 5;

		public float Radius;

		public int RotationOffset;

		public Color TintColor = new Color(1f, 1f, 1f, 1f);

		public Sprite Sprite;

		public string[] SortingLayerNames;

		public int RaySortingLayer;

		public int RaySortingOrder;

		public float RayAngle;

		public float RayLength;

		public float MidPos = 0.5f;

		public Color32 RayColorInner = new Color(1f, 1f, 1f, 1f);

		public Color32 RayColorMid = new Color(1f, 1f, 1f, 1f);

		public Color32 RayColorOuter = new Color(1f, 1f, 1f, 1f);

		public Material RayMaterial;

		public bool UseMesh = true;

		public Mesh RayMesh;

		private GameObject KDELHAAMHIA;

		private Vector3[] GDKEFOICAEC;

		private Vector2[] DHEIJBBMNIL;

		private int[] DLECHHJBDLE;

		private Color32[] PCKCPMOOAMI;

		private bool CGAACGEJPFN;

		public void Awake()
		{
			ADGIIEHLFLK();
			UpdateRays();
		}

		private void HOOLMBDNJAC()
		{
			if (!CGAACGEJPFN)
			{
				CGAACGEJPFN = true;
				DHEIJBBMNIL = new Vector2[5];
				DLECHHJBDLE = new int[9];
				DLECHHJBDLE[0] = 0;
				DLECHHJBDLE[1] = 1;
				DLECHHJBDLE[2] = 2;
				DLECHHJBDLE[3] = 1;
				DLECHHJBDLE[4] = 3;
				DLECHHJBDLE[5] = 2;
				DLECHHJBDLE[6] = 3;
				DLECHHJBDLE[7] = 4;
				DLECHHJBDLE[8] = 2;
				PCKCPMOOAMI = new Color32[5];
			}
			float num = (0f - Mathf.Tan((0f - RayAngle) * 0.5f * ((float)Math.PI / 180f))) * RayLength;
			GDKEFOICAEC = new Vector3[5];
			GDKEFOICAEC[0] = new Vector3(0f, 0f, 0f);
			GDKEFOICAEC[1] = new Vector3(RayLength * MidPos, num * MidPos, 0f);
			GDKEFOICAEC[2] = new Vector3(RayLength * MidPos, (0f - num) * MidPos, 0f);
			GDKEFOICAEC[3] = new Vector3(RayLength, num, 0f);
			GDKEFOICAEC[4] = new Vector3(RayLength, 0f - num, 0f);
			PCKCPMOOAMI[0] = RayColorInner;
			PCKCPMOOAMI[1] = RayColorMid;
			PCKCPMOOAMI[2] = RayColorMid;
			PCKCPMOOAMI[3] = RayColorOuter;
			PCKCPMOOAMI[4] = RayColorOuter;
			if (RayMesh == null)
			{
				RayMesh = new Mesh
				{
					name = "RayMesh:" + GetHashCode()
				};
				RayMesh.MarkDynamic();
			}
			RayMesh.vertices = GDKEFOICAEC;
			RayMesh.triangles = DLECHHJBDLE;
			RayMesh.uv = DHEIJBBMNIL;
			RayMesh.colors32 = PCKCPMOOAMI;
			RayMesh.RecalculateBounds();
		}

		public void UpdateRays()
		{
			for (int num = base.transform.childCount - 1; num >= 0; num--)
			{
				Transform child = base.transform.GetChild(num);
				if (child.name == "Container")
				{
					KDELHAAMHIA = child.gameObject;
					for (int num2 = child.childCount - 1; num2 >= 0; num2--)
					{
						UnityEngine.Object.DestroyImmediate(child.GetChild(num).gameObject);
					}
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(child.gameObject);
				}
			}
			if (KDELHAAMHIA == null)
			{
				KDELHAAMHIA = new GameObject("Container");
				KDELHAAMHIA.transform.SetParent(base.transform);
				KDELHAAMHIA.transform.localPosition = Vector3.zero;
			}
			HOOLMBDNJAC();
			BAMEHDKPEMM();
		}

		private void BAMEHDKPEMM()
		{
			float num = 360f / (float)Count;
			for (int i = 0; i < Count; i++)
			{
				Quaternion localRotation = default(Quaternion);
				float num2 = num * (float)i;
				float f = (num2 + (float)RotationOffset) * ((float)Math.PI / 180f);
				localRotation.eulerAngles = new Vector3(0f, 0f, num2);
				GameObject gameObject = new GameObject("Ray_" + i);
				gameObject.transform.SetParent(KDELHAAMHIA.transform);
				if (UseMesh)
				{
					MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();
					meshRenderer.receiveShadows = false;
					meshRenderer.shadowCastingMode = ShadowCastingMode.Off;
					meshRenderer.lightProbeUsage = LightProbeUsage.Off;
					meshRenderer.reflectionProbeUsage = ReflectionProbeUsage.Off;
					meshRenderer.sortingLayerName = SortingLayerNames[RaySortingLayer];
					meshRenderer.sortingOrder = RaySortingOrder;
					meshRenderer.sharedMaterial = RayMaterial;
					MeshFilter meshFilter = gameObject.AddComponent<MeshFilter>();
					meshFilter.sharedMesh = RayMesh;
				}
				else
				{
					SpriteRenderer spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
					spriteRenderer.sprite = Sprite;
					spriteRenderer.color = TintColor;
					spriteRenderer.sortingLayerName = SortingLayerNames[RaySortingLayer];
					spriteRenderer.sortingOrder = RaySortingOrder;
				}
				gameObject.transform.localPosition = new Vector3((0f - Mathf.Cos(f)) * Radius, (0f - Mathf.Sin(f)) * Radius, 0f);
				gameObject.transform.localRotation = localRotation;
			}
		}

		private void ADGIIEHLFLK()
		{
			int num = SortingLayer.layers.Length;
			SortingLayerNames = new string[num];
			for (int i = 0; i < num; i++)
			{
				SortingLayerNames[i] = SortingLayer.layers[i].name;
			}
		}
	}
}
