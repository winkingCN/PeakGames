using UnityEngine;

namespace Utils
{
	public class BitmapNumberDisplay : MonoBehaviour
	{
		public Sprite[] Sprites;

		public SpriteRenderer[] SpriteRenderers;

		private readonly int[] PNNGJPGJOBD = new int[4] { -1, -1, -1, -1 };

		public void Show(int ONLEJMMJMGK)
		{
			if (ONLEJMMJMGK == 0)
			{
				PNNGJPGJOBD[0] = 0;
				PNNGJPGJOBD[1] = -1;
				PNNGJPGJOBD[2] = -1;
				PNNGJPGJOBD[3] = -1;
			}
			else
			{
				for (int i = 0; i < 4; i++)
				{
					int num = ONLEJMMJMGK % 10;
					PNNGJPGJOBD[i] = ((ONLEJMMJMGK <= 0) ? (-1) : num);
					ONLEJMMJMGK /= 10;
				}
			}
			int num2 = SpriteRenderers.Length;
			int num3 = 0;
			for (int j = 0; j < num2; j++)
			{
				SpriteRenderer spriteRenderer = SpriteRenderers[j];
				if (!(spriteRenderer == null))
				{
					int num4 = PNNGJPGJOBD[j];
					if (num4 == -1)
					{
						spriteRenderer.enabled = false;
						continue;
					}
					spriteRenderer.sprite = Sprites[num4];
					num3++;
				}
			}
			for (int k = 0; k < num2; k++)
			{
				SpriteRenderer spriteRenderer2 = SpriteRenderers[k];
				if (!(spriteRenderer2 == null) && spriteRenderer2.enabled)
				{
					int num5 = num2 - num3;
					spriteRenderer2.transform.localPosition = new Vector3(-0.3f * (float)k - (float)num5 * 0.1f, 0f, 0f);
				}
			}
		}

		public void UpdateSorting(CKKKELDIOLD KHFBHDLBLJH)
		{
			for (int i = 0; i < SpriteRenderers.Length; i++)
			{
				SpriteRenderer spriteRenderer = SpriteRenderers[i];
				if (!(spriteRenderer == null))
				{
					spriteRenderer.sortingLayerID = KHFBHDLBLJH.MMFFDANAEEI;
					spriteRenderer.sortingOrder = KHFBHDLBLJH.BHIJCAOHDCM + i;
				}
			}
		}
	}
}
