using UnityEngine;

namespace Assets.Scripts.SceneTransitions
{
	public class CameraSizer : MonoBehaviour
	{
		public float DesiredWidth = 7f;

		public float HeightOfBottomPanel = 1.5f;

		public float HeightOfTopPanel = 1.5f;

		public Camera CurrentMainCamera;

		public GameObject TopPanel;

		public GameObject CenterPanel;

		public GameObject BottomPanel;

		public SpriteRenderer CurrentBackgroundSpriteRenderer;

		public bool BackgroundScaleToFitWidth;

		public bool ChangeBackgroundPosition;

		public bool ShouldUpdateInsets;

		private bool BDKKOPJCJFM;

		public void Awake()
		{
			LBGNFBINGLF();
		}

		private void JIMBAPGACIJ()
		{
			BDKKOPJCJFM = CaravanSceneManager.SceneToBeLoaded == GKBHIKONCKJ.GamePlay || CaravanSceneManager.SceneToBeLoaded == GKBHIKONCKJ.Map;
			float num = ((!ONCMBJKLKIL.PEFHCKMBHOM) ? 0.5f : 1.5f);
			float num2 = (HeightOfTopPanel + HeightOfBottomPanel + DesiredWidth + num) / 2f;
			float num3 = num2 * 2f * CurrentMainCamera.aspect;
			float num4 = num3 / DesiredWidth;
			if (num4 < 1f)
			{
				num2 = DesiredWidth / (2f * CurrentMainCamera.aspect);
				num4 = 1f;
			}
			CurrentMainCamera.orthographicSize = num2;
			GNOOAKEFFII();
			float topInset = GetTopInset();
			float bottomInset = GetBottomInset();
			if (ShouldUpdateInsets)
			{
				ONCMBJKLKIL.GNGIGAPBFCN = new LEJICLFDBAJ(topInset, bottomInset);
			}
			Vector3 position = CurrentMainCamera.ViewportToWorldPoint(new Vector2(0.5f, 1f));
			if (TopPanel != null)
			{
				position.z = TopPanel.transform.position.z;
				position.y -= HeightOfTopPanel * num4 / 2f;
				position.y -= ((!BDKKOPJCJFM) ? 0f : topInset);
				TopPanel.transform.localScale = Vector3.one * num4;
				TopPanel.transform.rotation = Quaternion.Euler(Vector3.zero);
				TopPanel.transform.position = position;
			}
			Vector3 position2 = CurrentMainCamera.ViewportToWorldPoint(new Vector2(0.5f, 0f));
			if (BottomPanel != null)
			{
				position2.z = BottomPanel.transform.position.z;
				position2.y += HeightOfBottomPanel * num4 / 2f;
				position2.y += ((!BDKKOPJCJFM) ? 0f : bottomInset);
				BottomPanel.transform.localScale = Vector3.one * num4;
				BottomPanel.transform.rotation = Quaternion.Euler(Vector3.zero);
				BottomPanel.transform.position = position2;
			}
			if (CenterPanel != null)
			{
				float num5 = position.y - HeightOfTopPanel * num4 / 2f;
				float num6 = position2.y + HeightOfBottomPanel * num4 / 2f;
				float y = (num6 + num5) / 2f;
				CenterPanel.transform.position = new Vector3(0f, y, 0f);
			}
		}

		public float GetTopInset()
		{
			if (ONCMBJKLKIL.HGJOLCBALEI.ECLBGPBLGMD == 0f)
			{
				return 0f;
			}
			float num = ONCMBJKLKIL.HGJOLCBALEI.ECLBGPBLGMD * (CurrentMainCamera.orthographicSize * 2f) / (float)Screen.height;
			if (MCJHHDACJBG.NDNBMGMPBLF)
			{
				if (CaravanSceneManager.SceneToBeLoaded == GKBHIKONCKJ.GamePlay)
				{
					num += 0.03f;
				}
				num -= 0.4014934f;
			}
			return num;
		}

		public float GetBottomInset()
		{
			if (ONCMBJKLKIL.HGJOLCBALEI.HINDAIPFFJL == 0f)
			{
				return 0f;
			}
			float num = ONCMBJKLKIL.HGJOLCBALEI.HINDAIPFFJL * (CurrentMainCamera.orthographicSize * 2f) / (float)Screen.height;
			if (MCJHHDACJBG.NDNBMGMPBLF)
			{
				if (CaravanSceneManager.SceneToBeLoaded == GKBHIKONCKJ.GamePlay)
				{
					num += ((!ONCMBJKLKIL.PEFHCKMBHOM) ? 0.06f : 0.03f);
				}
				num -= ((!ONCMBJKLKIL.PEFHCKMBHOM) ? 0.4284267f : (-0.05f));
			}
			return num;
		}

		protected virtual void GNOOAKEFFII()
		{
			if (CurrentBackgroundSpriteRenderer == null)
			{
				return;
			}
			if (BackgroundScaleToFitWidth)
			{
				float num = 2f * CurrentMainCamera.orthographicSize * 100f * CurrentMainCamera.aspect;
				float num2 = num / 1024f;
				CurrentBackgroundSpriteRenderer.transform.localScale = new Vector3(num2, num2, num2);
				Vector3 localPosition = CurrentBackgroundSpriteRenderer.transform.localPosition;
				if (ChangeBackgroundPosition)
				{
					localPosition.y = (0f - (ONCMBJKLKIL.FHAMOHDEGMK - 16.4f)) * 0.5f;
					CurrentBackgroundSpriteRenderer.transform.localPosition = localPosition;
				}
			}
			else
			{
				float num3 = 2f * CurrentMainCamera.orthographicSize * 100f;
				float num4 = num3 / 1024f;
				CurrentBackgroundSpriteRenderer.transform.localScale = new Vector3(num4, num4, num4);
			}
		}

		private void LBGNFBINGLF()
		{
			JIMBAPGACIJ();
			ONCMBJKLKIL.ILFBJBBBFID = CurrentMainCamera;
			ONCMBJKLKIL.JMICAJINDLL = CurrentMainCamera.aspect;
			ONCMBJKLKIL.NNOBNMCLIBC = CurrentMainCamera.orthographicSize;
			ONCMBJKLKIL.FHAMOHDEGMK = CurrentMainCamera.orthographicSize * 2f;
			ONCMBJKLKIL.EMFKAPJMDCC = CurrentMainCamera.aspect * ONCMBJKLKIL.FHAMOHDEGMK;
			ONCMBJKLKIL.ABDNNJLJKJD = CurrentMainCamera.ViewportToWorldPoint(new Vector2(1f, 0.5f));
			ONCMBJKLKIL.JDBOMLADPFF = CurrentMainCamera.ViewportToWorldPoint(new Vector2(0f, 0.5f));
			ONCMBJKLKIL.ECLBGPBLGMD = CurrentMainCamera.ViewportToWorldPoint(new Vector2(0.5f, 1f));
			ONCMBJKLKIL.HINDAIPFFJL = CurrentMainCamera.ViewportToWorldPoint(new Vector2(0.5f, 0f));
			ONCMBJKLKIL.EAECKBNBAJC = CurrentMainCamera.ViewportToWorldPoint(new Vector2(0.5f, 0.5f));
			ONCMBJKLKIL.PEFHCKMBHOM = (double)ONCMBJKLKIL.JMICAJINDLL > 0.6676666666666666;
			ONCMBJKLKIL.GGPFFOOIGHG = ONCMBJKLKIL.JMICAJINDLL > 0.665f;
			ONCMBJKLKIL.HLDNKOLGDGE = (double)ONCMBJKLKIL.JMICAJINDLL > 0.5635;
			ONCMBJKLKIL.KLEKJMEOPEH = ONCMBJKLKIL.JMICAJINDLL < 0.5622f;
		}
	}
}
