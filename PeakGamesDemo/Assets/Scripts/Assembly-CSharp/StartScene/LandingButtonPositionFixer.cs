using UnityEngine;

namespace StartScene
{
	public class LandingButtonPositionFixer : MonoBehaviour
	{
		public Camera CurrentCamera;

		private void Start()
		{
			float num = CurrentCamera.orthographicSize * 2f;
			float num2;
			float num3;
			if (CurrentCamera.aspect >= 0.75f)
			{
				num2 = 0.6612f;
				num3 = -0.35f;
			}
			else if ((double)CurrentCamera.aspect >= 0.6666666)
			{
				num2 = 0.916f;
				num3 = -0.664f;
			}
			else
			{
				num2 = 1f;
				num3 = -1.5f;
			}
			float y = (0f - num + 2f * num2) * 0.5f - num3;
			base.transform.localScale = Vector3.one * num2;
			base.transform.localPosition = new Vector3(0f, y, 0f);
		}
	}
}
