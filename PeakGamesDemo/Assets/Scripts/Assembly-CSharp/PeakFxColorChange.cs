using System;
using UnityEngine;

[Serializable]
[ExecuteInEditMode]
public class PeakFxColorChange : MonoBehaviour
{
	public SpriteRenderer CurrentSpriteRenderer;

	public Material DefaultMaterial;

	[Range(0f, 1f)]
	[HideInInspector]
	public float Alpha = 1f;

	[HideInInspector]
	[Range(0f, 1f)]
	public float Tolerance = 1f;

	[HideInInspector]
	[Range(0f, 360f)]
	public float HueShift = 360f;

	[Range(-2f, 2f)]
	[HideInInspector]
	public float Saturation = 1f;

	[Range(-2f, 2f)]
	[HideInInspector]
	public float ValueBrightness = 1f;

	private Material _tempMaterial;

	public void Awake()
	{
		CallUpdate();
	}

	public void CallUpdate()
	{
		if (CurrentSpriteRenderer != null)
		{
			if (_tempMaterial == null)
			{
				_tempMaterial = new Material(DefaultMaterial.shader);
				CurrentSpriteRenderer.material = _tempMaterial;
			}
			_tempMaterial.SetFloat("_Alpha", 1f - Alpha);
			_tempMaterial.SetFloat("_Tolerance", Tolerance);
			_tempMaterial.SetFloat("_HueShift", HueShift);
			_tempMaterial.SetFloat("_Sat", Saturation);
			_tempMaterial.SetFloat("_Val", ValueBrightness);
		}
	}
}
