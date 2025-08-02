using System;
using UnityEngine;

[Serializable]
[AddComponentMenu("2DxFX/Standard/Shiny Reflect")]
[ExecuteInEditMode]
public class PeakShine : MonoBehaviour
{
	public SpriteRenderer CurrentSpriteRenderer;

	private const string shader = "2DxFX/Standard/Shiny_Reflect";

	[HideInInspector]
	public Material ForceMaterial;

	[HideInInspector]
	public bool ActiveChange = true;

	[HideInInspector]
	public Texture2D __MainTex2;

	[HideInInspector]
	[Range(0f, 1f)]
	public float _Alpha = 1f;

	[Range(-0.5f, 1.5f)]
	[HideInInspector]
	public float Light = 1f;

	[HideInInspector]
	[Range(0.05f, 1f)]
	public float LightSize = 0.5f;

	[HideInInspector]
	public bool UseShinyCurve = true;

	[HideInInspector]
	public AnimationCurve ShinyLightCurve;

	[HideInInspector]
	[Range(0f, 32f)]
	public float AnimationSpeedReduction = 3f;

	[HideInInspector]
	[Range(0f, 2f)]
	public float Intensity = 1f;

	[Range(0f, 1f)]
	[HideInInspector]
	public float OnlyLight;

	[HideInInspector]
	[Range(-1f, 1f)]
	public float LightBump = 0.05f;

	private float ShinyLightCurveTime;

	[HideInInspector]
	public int ShaderChange;

	private Material tempMaterial;

	private Material defaultMaterial;

	private void Start()
	{
		__MainTex2 = Resources.Load("_2dxFX_Gradient") as Texture2D;
		CurrentSpriteRenderer.sharedMaterial.SetTexture("_MainTex2", __MainTex2);
		if (ShinyLightCurve == null)
		{
			ShinyLightCurve = new AnimationCurve();
		}
		if (ShinyLightCurve.length == 0)
		{
			ShinyLightCurve.AddKey(7.780734E-06f, -0.4416301f);
			ShinyLightCurve.keys[0].tangentMode = 0;
			ShinyLightCurve.keys[0].inTangent = 0f;
			ShinyLightCurve.keys[0].outTangent = 0f;
			ShinyLightCurve.AddKey(0.4310643f, 1.113406f);
			ShinyLightCurve.keys[1].tangentMode = 0;
			ShinyLightCurve.keys[1].inTangent = 0.2280953f;
			ShinyLightCurve.keys[1].outTangent = 0.2280953f;
			ShinyLightCurve.AddKey(0.5258899f, 1.229086f);
			ShinyLightCurve.keys[2].tangentMode = 0;
			ShinyLightCurve.keys[2].inTangent = -0.1474274f;
			ShinyLightCurve.keys[2].outTangent = -0.1474274f;
			ShinyLightCurve.AddKey(0.6136486f, 1.113075f);
			ShinyLightCurve.keys[3].tangentMode = 0;
			ShinyLightCurve.keys[3].inTangent = 0.005268873f;
			ShinyLightCurve.keys[3].outTangent = 0.005268873f;
			ShinyLightCurve.AddKey(0.9367767f, -0.4775873f);
			ShinyLightCurve.keys[4].tangentMode = 0;
			ShinyLightCurve.keys[4].inTangent = -3.890693f;
			ShinyLightCurve.keys[4].outTangent = -3.890693f;
			ShinyLightCurve.AddKey(1.144408f, -0.4976555f);
			ShinyLightCurve.keys[5].tangentMode = 0;
			ShinyLightCurve.keys[5].inTangent = 0f;
			ShinyLightCurve.keys[5].outTangent = 0f;
			ShinyLightCurve.postWrapMode = WrapMode.Loop;
			ShinyLightCurve.preWrapMode = WrapMode.Loop;
		}
	}

	private void OnDestroy()
	{
		if (!Application.isPlaying && Application.isEditor)
		{
			if (tempMaterial != null)
			{
				UnityEngine.Object.DestroyImmediate(tempMaterial);
			}
			if (base.gameObject.activeSelf && defaultMaterial != null && CurrentSpriteRenderer != null)
			{
				CurrentSpriteRenderer.sharedMaterial = defaultMaterial;
				CurrentSpriteRenderer.sharedMaterial.hideFlags = HideFlags.None;
			}
		}
	}

	private void OnDisable()
	{
		if (base.gameObject.activeSelf && defaultMaterial != null && CurrentSpriteRenderer != null)
		{
			CurrentSpriteRenderer.sharedMaterial = defaultMaterial;
			CurrentSpriteRenderer.sharedMaterial.hideFlags = HideFlags.None;
		}
	}

	private void OnEnable()
	{
		if (defaultMaterial == null)
		{
			defaultMaterial = new Material(Shader.Find("Sprites/Default"));
		}
		bool flag = CurrentSpriteRenderer != null;
		if (ForceMaterial == null)
		{
			ActiveChange = true;
			tempMaterial = new Material(Shader.Find("2DxFX/Standard/Shiny_Reflect"));
			tempMaterial.hideFlags = HideFlags.None;
			if (flag)
			{
				CurrentSpriteRenderer.sharedMaterial = tempMaterial;
			}
			__MainTex2 = Resources.Load("_2dxFX_Gradient") as Texture2D;
		}
		else
		{
			ForceMaterial.shader = Shader.Find("2DxFX/Standard/Shiny_Reflect");
			ForceMaterial.hideFlags = HideFlags.None;
			if (flag)
			{
				CurrentSpriteRenderer.sharedMaterial = ForceMaterial;
			}
			__MainTex2 = Resources.Load("_2dxFX_Gradient") as Texture2D;
		}
		if ((bool)__MainTex2)
		{
			__MainTex2.wrapMode = TextureWrapMode.Repeat;
			if (flag)
			{
				CurrentSpriteRenderer.sharedMaterial.SetTexture("_MainTex2", __MainTex2);
			}
		}
	}

	private void Update()
	{
		bool flag = CurrentSpriteRenderer != null;
		if (ShaderChange == 0 && ForceMaterial != null)
		{
			ShaderChange = 1;
			if (tempMaterial != null)
			{
				UnityEngine.Object.DestroyImmediate(tempMaterial);
			}
			if (flag)
			{
				CurrentSpriteRenderer.sharedMaterial = ForceMaterial;
			}
			ForceMaterial.hideFlags = HideFlags.None;
			ForceMaterial.shader = Shader.Find("2DxFX/Standard/Shiny_Reflect");
		}
		if (ForceMaterial == null && ShaderChange == 1)
		{
			if (tempMaterial != null)
			{
				UnityEngine.Object.DestroyImmediate(tempMaterial);
			}
			tempMaterial = new Material(Shader.Find("2DxFX/Standard/Shiny_Reflect"));
			tempMaterial.hideFlags = HideFlags.None;
			if (flag)
			{
				CurrentSpriteRenderer.sharedMaterial = tempMaterial;
			}
			ShaderChange = 0;
		}
	}

	public void CallUpdate()
	{
		Update();
	}
}
