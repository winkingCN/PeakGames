using UnityEngine;

public class WallEffect : MonoBehaviour
{
	public SpriteRenderer SideOverlay;

	public SpriteRenderer[] Overlays;

	public void Init()
	{
		SideOverlay.enabled = false;
		int i = 0;
		for (int num = Overlays.Length; i < num; i++)
		{
			if (Overlays[i] != null)
			{
				Overlays[i].enabled = false;
			}
		}
	}

	public void ShowOverlays(int HICEHGBGNJF)
	{
		SideOverlay.enabled = Random.Range(0, 10) < HICEHGBGNJF;
		int i = 0;
		for (int num = Overlays.Length; i < num; i++)
		{
			if (Overlays[i] != null)
			{
				Overlays[i].enabled = Random.Range(0, 10) < HICEHGBGNJF;
			}
		}
	}

	public void UpdateSorting(CKKKELDIOLD KHFBHDLBLJH)
	{
		SideOverlay.sortingLayerID = KHFBHDLBLJH.MMFFDANAEEI;
		SideOverlay.sortingOrder = KHFBHDLBLJH.BHIJCAOHDCM + 5;
		int i = 0;
		for (int num = Overlays.Length; i < num; i++)
		{
			SpriteRenderer spriteRenderer = Overlays[i];
			if (spriteRenderer != null)
			{
				spriteRenderer.sortingLayerID = KHFBHDLBLJH.MMFFDANAEEI;
				spriteRenderer.sortingOrder = KHFBHDLBLJH.BHIJCAOHDCM + 5;
			}
		}
	}
}
