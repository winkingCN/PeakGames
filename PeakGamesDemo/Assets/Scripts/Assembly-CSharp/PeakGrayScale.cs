using UnityEngine;

public class PeakGrayScale : MonoBehaviour
{
	public Material GrayScaleMaterial;

	public SpriteRenderer CurrentSpriteRenderer;

	private Material BIKAMGDIKPJ;

	private float AEGJNAGNMHG = 1f;

	public void UpdateGrayScale(float GPGDCCMECGF, float HJMBDGKAOBP, float BCIHLCMFAEK)
	{
		if (BIKAMGDIKPJ == null && GrayScaleMaterial != null)
		{
			BIKAMGDIKPJ = new Material(GrayScaleMaterial);
		}
		if (!(CurrentSpriteRenderer == null))
		{
			CurrentSpriteRenderer.sharedMaterial = BIKAMGDIKPJ;
			CurrentSpriteRenderer.sharedMaterial.SetFloat("_Distortion", AEGJNAGNMHG);
			CurrentSpriteRenderer.sharedMaterial.SetFloat("_R", GPGDCCMECGF);
			CurrentSpriteRenderer.sharedMaterial.SetFloat("_G", HJMBDGKAOBP);
			CurrentSpriteRenderer.sharedMaterial.SetFloat("_B", BCIHLCMFAEK);
		}
	}
}
