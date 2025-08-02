using System.Collections;
using Assets.Scripts.Dialogs;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.SceneTransitions;
using UnityEngine;

namespace Assets.Scripts.LevelLoaderScene
{
	public class LevelScreenShotTaker : MonoBehaviour
	{
		public int CurrentLevel = 1;

		private Object ENCPLHFKKJM;

		public void Start()
		{
			NextLevel();
		}

		private void DPFCGMDNHFG(Object EPGLDBCJOKJ)
		{
			Time.timeScale = 5f;
			LevelBuilder.CurrentLevelNo = CurrentLevel;
			LevelBuilder.KDBDBMBAKEL = "Map";
			CaravanSceneManager.Load(GKBHIKONCKJ.GamePlay);
			StartCoroutine(IAOMKOOBEBG());
		}

		private IEnumerator IAOMKOOBEBG()
		{
			yield return null;
			Time.timeScale = 5f;
			while (CaravanSceneManager.GDLJAINDFOJ)
			{
				yield return null;
			}
			while (GoalsBannerDialog.Instance != null)
			{
				yield return null;
			}
			yield return MCJHHDACJBG.CHFOIGLAMPN;
			ScreenCapture.CaptureScreenshot(string.Format("Level_{0:D4}.png", CurrentLevel));
			CurrentLevel++;
			Invoke("NextLevel", 0.1f);
		}

		public void NextLevel()
		{
			StartCoroutine(HJDLAJHHFPA.LCHNACPGJFN(1, DPFCGMDNHFG));
		}
	}
}
