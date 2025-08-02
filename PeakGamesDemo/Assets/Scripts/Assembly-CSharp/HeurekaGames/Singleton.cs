using UnityEngine;

namespace HeurekaGames
{
	public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		private static T KNPOFJNFLJB;

		private static object KNJOLPIEHHA = new object();

		private static bool ANKKPIOGPAE = false;

		public static T GABGKBAKHDP
		{
			get
			{
				if (ANKKPIOGPAE)
				{
					Debug.LogWarning(string.Concat("[Singleton] Instance '", typeof(T), "' already destroyed on application quit. Won't create again - returning null."));
					return (T)null;
				}
				lock (KNJOLPIEHHA)
				{
					if (KNPOFJNFLJB == null)
					{
						KNPOFJNFLJB = (T)Object.FindObjectOfType(typeof(T));
						if (Object.FindObjectsOfType(typeof(T)).Length > 1)
						{
							Debug.LogError("[Singleton] Something went really wrong  - there should never be more than 1 singleton! Reopenning the scene might fix it.");
							return KNPOFJNFLJB;
						}
						if (KNPOFJNFLJB == null)
						{
							GameObject gameObject = new GameObject();
							KNPOFJNFLJB = gameObject.AddComponent<T>();
							gameObject.name = "(singleton) " + typeof(T).ToString();
							Debug.Log(string.Concat("[Singleton] An instance of ", typeof(T), " was created."));
						}
						else
						{
							Debug.Log("[Singleton] Using instance already created: " + KNPOFJNFLJB.gameObject.name);
						}
					}
					return KNPOFJNFLJB;
				}
			}
		}

		public void OnDestroy()
		{
			ANKKPIOGPAE = true;
		}
	}
}
