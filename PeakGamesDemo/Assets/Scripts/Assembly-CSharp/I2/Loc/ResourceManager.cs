using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace I2.Loc
{
	public class ResourceManager : MonoBehaviour
	{
		private static ResourceManager HNLDEFMEICM;

		public List<OFDFEABDDLH> mBundleManagers = new List<OFDFEABDDLH>();

		public UnityEngine.Object[] Assets;

		private readonly Dictionary<string, UnityEngine.Object> GKFPOKKBLGF = new Dictionary<string, UnityEngine.Object>(StringComparer.Ordinal);

		[CompilerGenerated]
		private static UnityAction<Scene, LoadSceneMode> JANLDOMIIEF;

		public static ResourceManager MGLPOGMOMJM
		{
			get
			{
				bool flag = HNLDEFMEICM == null;
				if (HNLDEFMEICM == null)
				{
					HNLDEFMEICM = (ResourceManager)UnityEngine.Object.FindObjectOfType(typeof(ResourceManager));
				}
				if (HNLDEFMEICM == null)
				{
					GameObject gameObject = new GameObject("I2ResourceManager", typeof(ResourceManager));
					gameObject.hideFlags |= HideFlags.HideAndDontSave;
					HNLDEFMEICM = gameObject.GetComponent<ResourceManager>();
					SceneManager.sceneLoaded += MyOnLevelWasLoaded;
				}
				if (flag && Application.isPlaying)
				{
					UnityEngine.Object.DontDestroyOnLoad(HNLDEFMEICM.gameObject);
				}
				return HNLDEFMEICM;
			}
		}

		public static void MyOnLevelWasLoaded(Scene HPLOBNMLMMP, LoadSceneMode LJCPOAOKFOE)
		{
			MGLPOGMOMJM.CleanResourceCache();
			PNAJOCHGJFO.JHMHBFIFFFK();
		}

		public T GetAsset<T>(string PNGPLGHKFDI) where T : UnityEngine.Object
		{
			T val = PFGPGNNFFJN(PNGPLGHKFDI) as T;
			if (val != null)
			{
				return val;
			}
			return LoadFromResources<T>(PNGPLGHKFDI);
		}

		private UnityEngine.Object PFGPGNNFFJN(string PNGPLGHKFDI)
		{
			if (Assets != null)
			{
				int i = 0;
				for (int num = Assets.Length; i < num; i++)
				{
					if (Assets[i] != null && Assets[i].name == PNGPLGHKFDI)
					{
						return Assets[i];
					}
				}
			}
			return null;
		}

		public bool HasAsset(UnityEngine.Object JNPDINFDEJE)
		{
			if (Assets == null)
			{
				return false;
			}
			return Array.IndexOf(Assets, JNPDINFDEJE) >= 0;
		}

		public T LoadFromResources<T>(string MJCBDBIDMGF) where T : UnityEngine.Object
		{
			try
			{
				if (string.IsNullOrEmpty(MJCBDBIDMGF))
				{
					return (T)null;
				}
				UnityEngine.Object value;
				if (GKFPOKKBLGF.TryGetValue(MJCBDBIDMGF, out value) && value != null)
				{
					return value as T;
				}
				T val = (T)null;
				if (MJCBDBIDMGF.EndsWith("]", StringComparison.OrdinalIgnoreCase))
				{
					int num = MJCBDBIDMGF.LastIndexOf("[", StringComparison.OrdinalIgnoreCase);
					int length = MJCBDBIDMGF.Length - num - 2;
					string value2 = MJCBDBIDMGF.Substring(num + 1, length);
					MJCBDBIDMGF = MJCBDBIDMGF.Substring(0, num);
					T[] array = Resources.LoadAll<T>(MJCBDBIDMGF);
					int i = 0;
					for (int num2 = array.Length; i < num2; i++)
					{
						if (array[i].name.Equals(value2))
						{
							val = array[i];
							break;
						}
					}
				}
				else
				{
					val = Resources.Load(MJCBDBIDMGF, typeof(T)) as T;
				}
				if (val == null)
				{
					val = LoadFromBundle<T>(MJCBDBIDMGF);
				}
				if (val != null)
				{
					GKFPOKKBLGF[MJCBDBIDMGF] = val;
				}
				return val;
			}
			catch (Exception ex)
			{
				Debug.LogErrorFormat("Unable to load {0} '{1}'\nERROR: {2}", typeof(T), MJCBDBIDMGF, ex.ToString());
				return (T)null;
			}
		}

		public T LoadFromBundle<T>(string LCCKDPIBKPJ) where T : UnityEngine.Object
		{
			int i = 0;
			for (int count = mBundleManagers.Count; i < count; i++)
			{
				if (mBundleManagers[i] != null)
				{
					T val = mBundleManagers[i].FMGDEKDAKMK<T>(LCCKDPIBKPJ);
					if (val != null)
					{
						return val;
					}
				}
			}
			return (T)null;
		}

		public void CleanResourceCache()
		{
			GKFPOKKBLGF.Clear();
			Resources.UnloadUnusedAssets();
			CancelInvoke();
		}
	}
}
