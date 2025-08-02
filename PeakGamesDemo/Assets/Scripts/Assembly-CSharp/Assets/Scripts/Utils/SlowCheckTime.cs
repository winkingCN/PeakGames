using UnityEngine;

namespace Assets.Scripts.Utils
{
	public class SlowCheckTime : MonoBehaviour
	{
		private static SlowCheckTime KNPOFJNFLJB;

		private bool GKDDKEKBAJC;

		public static void Init()
		{
			if (KNPOFJNFLJB != null)
			{
				Object.Destroy(KNPOFJNFLJB.gameObject);
			}
			GameObject gameObject = new GameObject();
			gameObject.name = "SlowTimeChecker";
			GameObject gameObject2 = gameObject;
			KNPOFJNFLJB = gameObject2.AddComponent<SlowCheckTime>();
			Object.DontDestroyOnLoad(gameObject2);
		}

		public void Update()
		{
			GKDDKEKBAJC = Time.frameCount % 20 == 0;
		}

		public static bool ShouldPass()
		{
			return KNPOFJNFLJB.GKDDKEKBAJC;
		}
	}
}
