using Assets.Scripts.SceneTransitions;
using UnityEngine;

namespace InitialScene
{
	public class LoadingLogo : MonoBehaviour
	{
		public CameraSizer CurrentCameraSizer;

		public void Start()
		{
			Camera currentMainCamera = CurrentCameraSizer.CurrentMainCamera;
			float num = currentMainCamera.orthographicSize * 2f;
			float num2 = num * currentMainCamera.aspect;
			float num3 = 0.916f;
			float num4;
			float num5;
			if (ONCMBJKLKIL.HGJOLCBALEI.ECLBGPBLGMD > 0f)
			{
				num4 = 0.425f;
				num5 = 0.9f + CurrentCameraSizer.GetTopInset();
			}
			else if (currentMainCamera.aspect >= 0.75f)
			{
				num3 = 0.76f;
				num4 = 0.3026f;
				num5 = 0.4452f;
			}
			else if ((double)currentMainCamera.aspect >= 0.6666666)
			{
				num4 = 0.325f;
				num5 = 0.504f;
			}
			else
			{
				num4 = 0.425f;
				num5 = 0.804f;
			}
			float x = (0f - num2 + 4.23f * num3) * 0.5f + num4;
			float y = (num - 4.03f * num3) * 0.5f - num5;
			base.transform.localScale = Vector3.one * num3;
			base.transform.localPosition = new Vector3(x, y, 0f);
		}
	}
}
