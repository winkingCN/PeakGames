using System.Collections;
using UnityEngine;

namespace I2
{
	public class CoroutineManager : MonoBehaviour
	{
		private static CoroutineManager HNLDEFMEICM;

		public static CoroutineManager MGLPOGMOMJM
		{
			get
			{
				if (HNLDEFMEICM == null)
				{
					GameObject gameObject = new GameObject("_Coroutiner");
					gameObject.hideFlags |= HideFlags.HideAndDontSave;
					HNLDEFMEICM = gameObject.AddComponent<CoroutineManager>();
					if (Application.isPlaying)
					{
						Object.DontDestroyOnLoad(gameObject);
					}
				}
				return HNLDEFMEICM;
			}
		}

		public static Coroutine Start(IEnumerator EMEADLCFDFD)
		{
			return MGLPOGMOMJM.StartCoroutine(EMEADLCFDFD);
		}
	}
}
