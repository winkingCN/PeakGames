using System;
using UnityEngine;

[Serializable]
[ExecuteInEditMode]
[AddComponentMenu("PeakGames/GrayScale")]
public class PeakFxGrayScale : MonoBehaviour
{
	public Material GrayScaleMaterial;

	public SpriteRenderer CurrentSpriteRenderer;

	private Material _tempMaterial;

	[Range(0f, 1f)]
	public float _Alpha = 1f;

	[Range(0f, 1f)]
	public float _EffectAmount = 1f;

	private void Start()
	{
		UpdateGrayScale();
	}

	public void UpdateGrayScale()
	{
		if (_tempMaterial == null && GrayScaleMaterial != null)
		{
			_tempMaterial = new Material(GrayScaleMaterial);
		}
		if (!(CurrentSpriteRenderer == null))
		{
			CurrentSpriteRenderer.sharedMaterial = _tempMaterial;
			CurrentSpriteRenderer.sharedMaterial.SetFloat("_Alpha", 1f - _Alpha);
			CurrentSpriteRenderer.sharedMaterial.SetFloat("_EffectAmount", _EffectAmount);
		}
	}

	private void OnDestroy()
	{
		if (!Application.isPlaying && Application.isEditor && _tempMaterial != null)
		{
			UnityEngine.Object.DestroyImmediate(_tempMaterial);
		}
	}

	private void OnEnable()
	{
		UpdateGrayScale();
	}
}
