using UnityEngine;

namespace Assets.Scripts.SceneTransitions
{
	public class GamePlayCameraSizer : CameraSizer
	{
		public SpriteRenderer BackgroundSpriteRenderer1;

		public SpriteRenderer BackgroundSpriteRenderer2;

		protected override void GNOOAKEFFII()
		{
			if (!(BackgroundSpriteRenderer1 == null) && !(BackgroundSpriteRenderer2 == null))
			{
				float num = 2f * CurrentMainCamera.orthographicSize * 100f * CurrentMainCamera.aspect;
				float num2 = num / 1024f;
				BackgroundSpriteRenderer1.transform.localScale = new Vector3(num2, num2, num2);
				BackgroundSpriteRenderer2.transform.localScale = new Vector3(num2, num2, num2);
				float orthographicSize = CurrentMainCamera.orthographicSize;
				float num3 = num2 * 10.24f * 0.5f;
				float num4 = 0f - orthographicSize + num3;
				float y = num4 + num3 * 2f;
				BackgroundSpriteRenderer1.transform.position = new Vector3(0f, num4, 10f);
				BackgroundSpriteRenderer2.transform.position = new Vector3(0f, y, 10f);
			}
		}
	}
}
