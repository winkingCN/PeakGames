using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[AddComponentMenu("2DxFX/Standard/GrayScale")]
[ExecuteInEditMode]
public class _2dxFX_GrayScale : MonoBehaviour
{
	[HideInInspector]
	public Material ForceMaterial;

	[HideInInspector]
	public bool ActiveChange = true;

	private string shader = "2DxFX/Standard/GrayScale";

	[Range(0f, 1f)]
	[HideInInspector]
	public float _Alpha = 1f;

	[Range(0f, 1f)]
	public float _EffectAmount = 1f;

	[HideInInspector]
	public int ShaderChange;

	private Material tempMaterial;

	private Material defaultMaterial;

	private Image CanvasImage;

	private void Awake()
	{
		if (base.gameObject.GetComponent<Image>() != null)
		{
			CanvasImage = base.gameObject.GetComponent<Image>();
		}
	}

	private void Start()
	{
		ShaderChange = 0;
	}

	public void CallUpdate()
	{
		Update();
	}

	private void Update()
	{
		if (base.gameObject.GetComponent<Image>() != null && CanvasImage == null)
		{
			CanvasImage = base.gameObject.GetComponent<Image>();
		}
		if (ShaderChange == 0 && ForceMaterial != null)
		{
			ShaderChange = 1;
			if (tempMaterial != null)
			{
				UnityEngine.Object.DestroyImmediate(tempMaterial);
			}
			if (base.gameObject.GetComponent<SpriteRenderer>() != null)
			{
				GetComponent<Renderer>().sharedMaterial = ForceMaterial;
			}
			else if (base.gameObject.GetComponent<Image>() != null)
			{
				CanvasImage.material = ForceMaterial;
			}
			ForceMaterial.hideFlags = HideFlags.None;
			ForceMaterial.shader = Shader.Find(shader);
		}
		if (ForceMaterial == null && ShaderChange == 1)
		{
			if (tempMaterial != null)
			{
				UnityEngine.Object.DestroyImmediate(tempMaterial);
			}
			tempMaterial = new Material(Shader.Find(shader));
			tempMaterial.hideFlags = HideFlags.None;
			if (base.gameObject.GetComponent<SpriteRenderer>() != null)
			{
				GetComponent<Renderer>().sharedMaterial = tempMaterial;
			}
			else if (base.gameObject.GetComponent<Image>() != null)
			{
				CanvasImage.material = tempMaterial;
			}
			ShaderChange = 0;
		}
		if (ActiveChange)
		{
			if (base.gameObject.GetComponent<SpriteRenderer>() != null)
			{
				GetComponent<Renderer>().sharedMaterial.SetFloat("_Alpha", 1f - _Alpha);
				GetComponent<Renderer>().sharedMaterial.SetFloat("_EffectAmount", _EffectAmount);
			}
			else if (base.gameObject.GetComponent<Image>() != null)
			{
				CanvasImage.material.SetFloat("_Alpha", 1f - _Alpha);
				CanvasImage.material.SetFloat("_EffectAmount", _EffectAmount);
			}
		}
	}

	private void OnDestroy()
	{
		if (base.gameObject.GetComponent<Image>() != null && CanvasImage == null)
		{
			CanvasImage = base.gameObject.GetComponent<Image>();
		}
		if (Application.isPlaying || !Application.isEditor)
		{
			return;
		}
		if (tempMaterial != null)
		{
			UnityEngine.Object.DestroyImmediate(tempMaterial);
		}
		if (base.gameObject.activeSelf && defaultMaterial != null)
		{
			if (base.gameObject.GetComponent<SpriteRenderer>() != null)
			{
				GetComponent<Renderer>().sharedMaterial = defaultMaterial;
				GetComponent<Renderer>().sharedMaterial.hideFlags = HideFlags.None;
			}
			else if (base.gameObject.GetComponent<Image>() != null)
			{
				CanvasImage.material = defaultMaterial;
				CanvasImage.material.hideFlags = HideFlags.None;
			}
		}
	}

	private void OnDisable()
	{
		if (base.gameObject.GetComponent<Image>() != null && CanvasImage == null)
		{
			CanvasImage = base.gameObject.GetComponent<Image>();
		}
		if (base.gameObject.activeSelf && defaultMaterial != null)
		{
			if (base.gameObject.GetComponent<SpriteRenderer>() != null)
			{
				GetComponent<Renderer>().sharedMaterial = defaultMaterial;
				GetComponent<Renderer>().sharedMaterial.hideFlags = HideFlags.None;
			}
			else if (base.gameObject.GetComponent<Image>() != null)
			{
				CanvasImage.material = defaultMaterial;
				CanvasImage.material.hideFlags = HideFlags.None;
			}
		}
	}

	private void OnEnable()
	{
		if (base.gameObject.GetComponent<Image>() != null && CanvasImage == null)
		{
			CanvasImage = base.gameObject.GetComponent<Image>();
		}
		if (defaultMaterial == null)
		{
			defaultMaterial = new Material(Shader.Find("Sprites/Default"));
		}
		if (ForceMaterial == null)
		{
			ActiveChange = true;
			tempMaterial = new Material(Shader.Find(shader));
			tempMaterial.hideFlags = HideFlags.None;
			if (base.gameObject.GetComponent<SpriteRenderer>() != null)
			{
				GetComponent<Renderer>().sharedMaterial = tempMaterial;
			}
			else if (base.gameObject.GetComponent<Image>() != null)
			{
				CanvasImage.material = tempMaterial;
			}
		}
		else
		{
			ForceMaterial.shader = Shader.Find(shader);
			ForceMaterial.hideFlags = HideFlags.None;
			if (base.gameObject.GetComponent<SpriteRenderer>() != null)
			{
				GetComponent<Renderer>().sharedMaterial = ForceMaterial;
			}
			else if (base.gameObject.GetComponent<Image>() != null)
			{
				CanvasImage.material = ForceMaterial;
			}
		}
	}
}
