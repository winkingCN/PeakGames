using System.Collections;
using UnityEngine;

namespace I2.Loc
{
	public class CoroutineManager : MonoBehaviour
	{
		private static CoroutineManager HNLDEFMEICM;

		private static CoroutineManager MGLPOGMOMJM
		{
			get
			{
				if (HNLDEFMEICM == null)
				{
					GameObject gameObject = new GameObject("_Coroutiner");
					gameObject.hideFlags = HideFlags.HideAndDontSave;
					HNLDEFMEICM = gameObject.AddComponent<CoroutineManager>();
					if (Application.isPlaying)
					{
						Object.DontDestroyOnLoad(gameObject);
					}
				}
				return HNLDEFMEICM;
			}
		}

		private void Awake()
		{
			if (Application.isPlaying)
			{
				Object.DontDestroyOnLoad(base.gameObject);
			}
		}

		public static Coroutine Start(IEnumerator EMEADLCFDFD)
		{
			return MGLPOGMOMJM.StartCoroutine(EMEADLCFDFD);
		}
	}
}
