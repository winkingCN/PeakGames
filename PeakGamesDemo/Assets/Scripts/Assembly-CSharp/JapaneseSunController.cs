using System;
using UnityEngine;
using UnityEngine.Rendering;

[ExecuteInEditMode]
public class JapaneseSunController : MonoBehaviour
{
	public int Count = 5;

	public float Radius = 5f;

	public int RotationOffset;

	public Color TintColor = new Color(1f, 1f, 1f, 1f);

	public Sprite Sprite;

	public int RaySortingLayer;

	public int RaySortingOrder;

	public float RayAngle;

	public float RaySize;

	public Color32 RayColor1 = new Color(1f, 1f, 1f, 1f);

	public Color32 RayColor2 = new Color(1f, 1f, 1f, 1f);

	public Material RayMaterial;

	public Gradient RayGradient;

	public bool UseMesh = true;

	public Mesh RayMesh;

	private Vector3[] GDKEFOICAEC;

	private Vector2[] DHEIJBBMNIL;

	private int[] DLECHHJBDLE;

	private GameObject KDELHAAMHIA;

	public string[] SortingLayerNames;

	public void Awake()
	{
		DHEIJBBMNIL = new Vector2[3];
		DHEIJBBMNIL[0] = new Vector2(0f, 0f);
		DHEIJBBMNIL[1] = new Vector2(1f, 0f);
		DHEIJBBMNIL[2] = new Vector2(0f, 1f);
		DLECHHJBDLE = new int[3];
		DLECHHJBDLE[0] = 0;
		DLECHHJBDLE[1] = 1;
		DLECHHJBDLE[2] = 2;
		ADGIIEHLFLK();
		UpdateRays();
	}

	public void CreateMesh()
	{
		GDKEFOICAEC = new Vector3[3];
		GDKEFOICAEC[0] = new Vector3(0f, 0f, 0f);
		GDKEFOICAEC[1] = new Vector3(RaySize, (0f - Mathf.Tan((0f - RayAngle) * 0.5f * (float)Math.PI / 180f)) * RaySize, 0f);
		GDKEFOICAEC[2] = new Vector3(RaySize, Mathf.Tan((0f - RayAngle) * 0.5f * (float)Math.PI / 180f) * RaySize, 0f);
		Color32[] colors = new Color32[3] { RayColor1, RayColor2, RayColor2 };
		if (RayMesh == null)
		{
			RayMesh = new Mesh();
			RayMesh.name = "RayMesh:" + GetHashCode();
			RayMesh.MarkDynamic();
		}
		RayMesh.vertices = GDKEFOICAEC;
		RayMesh.triangles = DLECHHJBDLE;
		RayMesh.uv = DHEIJBBMNIL;
		RayMesh.colors32 = colors;
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
		CreateMesh();
		BAMEHDKPEMM();
	}

	private void BAMEHDKPEMM()
	{
		float num = 360f / (float)Count;
		float num2 = (float)Math.PI / 180f;
		for (int i = 0; i < Count; i++)
		{
			Quaternion localRotation = default(Quaternion);
			float num3 = num * (float)i;
			float f = (num3 + (float)RotationOffset) * num2;
			localRotation.eulerAngles = new Vector3(0f, 0f, num3);
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
