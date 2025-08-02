using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace InitialScene
{
	public class InitialSceneController : MonoBehaviour
	{
		public Camera CurrentCamera;

		public SpriteRenderer LoadingSpriteRenderer;

		public SpriteRenderer LoadingTopSpriteRenderer;

		public SpriteRenderer LoadingBottomSpriteRenderer;

		public static InitialSceneController Instance;

		private static bool NHLJPPPIIOA;

		private void Awake()
		{
			GBFAPADEBEC.CPGJCKCOABM();
			Object.DontDestroyOnLoad(this);
			Instance = this;
			OAJPDPLHKNK();
			GBFAPADEBEC.HCADONMOIDE = false;
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.InitialManager, "Initial Scene Started @:" + Time.realtimeSinceStartup);
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.InitialManager, "Current Game Version is: {0}", "4161");
			Screen.sleepTimeout = -2;
			Application.targetFrameRate = 60;
			QualitySettings.SetQualityLevel(0, true);
			QualitySettings.vSyncCount = 1;
			Input.multiTouchEnabled = false;
			ONCMBJKLKIL.HGJOLCBALEI = NAAGDFCLOPE.GABGKBAKHDP.BEEIBDODHCD();
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.InitialManager, "Safe Area: Top={0} Bottom={1}", ONCMBJKLKIL.HGJOLCBALEI.ECLBGPBLGMD, ONCMBJKLKIL.HGJOLCBALEI.HINDAIPFFJL);
		}

		public IEnumerator Start()
		{
			Resolution currentResolution = Screen.currentResolution;
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.InitialManager, "Resolution of device: {0}x{1}", currentResolution.height, currentResolution.width);
			if (NHLJPPPIIOA)
			{
				SceneManager.LoadScene("StartScene");
			}
			else
			{
				yield return MCJHHDACJBG.CNDGGNLKOOC;
				FILHOAEELBG.CGBOGMJLOGD(delegate(string IBBBMACIBGK, float GNGLLMMGOJI)
				{
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.InitialManager, "SetResolution Result:{0} Timeout:{1}", IBBBMACIBGK, GNGLLMMGOJI);
					CurrentCamera.clearFlags = CameraClearFlags.Depth;
					SceneManager.LoadScene("StartScene");
				});
				NHLJPPPIIOA = true;
			}
			yield return null;
		}

		private void OAJPDPLHKNK()
		{
			TextAsset hKLFKEFJAAE = Resources.Load<TextAsset>("Loading/Splash_Screen");
			Sprite sprite = LJDGBAMMEAM.FPAMEPBLDPL(hKLFKEFJAAE, 1024, 1822);
			LoadingSpriteRenderer.sprite = sprite;
			hKLFKEFJAAE = Resources.Load<TextAsset>("Loading/Splash_Screen_Up");
			sprite = LJDGBAMMEAM.FPAMEPBLDPL(hKLFKEFJAAE, 1024, 215);
			LoadingTopSpriteRenderer.sprite = sprite;
			hKLFKEFJAAE = Resources.Load<TextAsset>("Loading/Splash_Screen_Down");
			sprite = LJDGBAMMEAM.FPAMEPBLDPL(hKLFKEFJAAE, 1024, 215);
			LoadingBottomSpriteRenderer.sprite = sprite;
		}
	}
}
