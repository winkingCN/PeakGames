using DG.Tweening;
using TMPro;
using UnityEngine;

public class LoadingInfoDialog : MonoBehaviour
{
	public SpriteRenderer BackgroundSpriteRenderer;

	public SpriteRenderer BottomSpriteRenderer;

	public Transform Content;

	public SpriteRenderer[] FadeSpriteRenderers;

	public TextMeshPro[] FadeTextMeshRenderers;

	public bool SingleImage;

	public void Init(Camera LFCBBKIFIJA)
	{
		float num = LFCBBKIFIJA.orthographicSize * 2f;
		float num2 = num * LFCBBKIFIJA.aspect;
		Vector3 vector = LFCBBKIFIJA.ViewportToWorldPoint(new Vector2(0.5f, 0f));
		if (SingleImage)
		{
			float num3 = num2 / 10.24f;
			BackgroundSpriteRenderer.transform.localScale = new Vector3(num3, num3, num3);
			BackgroundSpriteRenderer.transform.position = new Vector3(0f, 0f, 0f);
		}
		else
		{
			float num4 = 1.5f;
			float x = 14.285714f * num2;
			BackgroundSpriteRenderer.transform.localScale = new Vector3(num2, num - num4 * 2f);
			BackgroundSpriteRenderer.transform.position = new Vector3(0f, num4, 0f);
			BottomSpriteRenderer.transform.localScale = new Vector3(x, 1f, 1f);
			BottomSpriteRenderer.transform.position = new Vector3(0f, vector.y + num4, 0f);
		}
		if (ONCMBJKLKIL.PEFHCKMBHOM && Content != null)
		{
			Content.transform.localScale = Vector3.one * 0.8f;
		}
	}

	public void Fade(float LLAEDBFNCCP, float BMIOECELGCA, float FMPBJJMKCIG)
	{
		for (int i = 0; i < FadeSpriteRenderers.Length; i++)
		{
			SpriteRenderer spriteRenderer = FadeSpriteRenderers[i];
			if (spriteRenderer != null)
			{
				Color color = spriteRenderer.color;
				color.a = LLAEDBFNCCP;
				spriteRenderer.color = color;
				spriteRenderer.DOFade(BMIOECELGCA, FMPBJJMKCIG);
			}
		}
		for (int j = 0; j < FadeTextMeshRenderers.Length; j++)
		{
			TextMeshPro textMeshPro = FadeTextMeshRenderers[j];
			if (textMeshPro != null)
			{
				Color color2 = textMeshPro.color;
				color2.a = LLAEDBFNCCP;
				textMeshPro.color = color2;
				textMeshPro.OCHJNKODKNO(BMIOECELGCA, FMPBJJMKCIG);
			}
		}
	}
}
