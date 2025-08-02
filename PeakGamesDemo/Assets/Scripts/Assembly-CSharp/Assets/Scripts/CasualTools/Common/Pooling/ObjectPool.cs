using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CasualTools.Common.Pooling
{
	public sealed class ObjectPool : MonoBehaviour
	{
		public enum AKAMJGDDIPG
		{
			Awake = 0,
			Start = 1,
			CallManually = 2
		}

		[Serializable]
		public class StartupPool
		{
			public GameObject Prefab;

			public int Size;
		}

		private static ObjectPool KNPOFJNFLJB;

		private static readonly List<GameObject> KKJJPADJBFM = new List<GameObject>();

		private readonly Dictionary<GameObject, List<GameObject>> EFIMINCNLKK = new Dictionary<GameObject, List<GameObject>>();

		private readonly Dictionary<GameObject, GameObject> CGDPNKMDBEI = new Dictionary<GameObject, GameObject>();

		private bool GABAFJGGJCA;

		public StartupPool[] StartupPools;

		public AKAMJGDDIPG TheStartupPoolMode;

		public static ObjectPool GABGKBAKHDP
		{
			get
			{
				if (KNPOFJNFLJB != null)
				{
					return KNPOFJNFLJB;
				}
				KNPOFJNFLJB = UnityEngine.Object.FindObjectOfType<ObjectPool>();
				if (KNPOFJNFLJB != null)
				{
					return KNPOFJNFLJB;
				}
				GameObject gameObject = new GameObject("ObjectPool");
				gameObject.transform.localPosition = Vector3.zero;
				gameObject.transform.localRotation = Quaternion.identity;
				gameObject.transform.localScale = Vector3.one;
				KNPOFJNFLJB = gameObject.AddComponent<ObjectPool>();
				return KNPOFJNFLJB;
			}
		}

		public void Awake()
		{
			KNPOFJNFLJB = this;
			if (TheStartupPoolMode == AKAMJGDDIPG.Awake)
			{
				CreateStartupPools();
			}
		}

		public void Start()
		{
			if (TheStartupPoolMode == AKAMJGDDIPG.Start)
			{
				CreateStartupPools();
			}
		}

		public static void CreateStartupPools()
		{
			if (GABGKBAKHDP.GABAFJGGJCA)
			{
				return;
			}
			GABGKBAKHDP.GABAFJGGJCA = true;
			StartupPool[] startupPools = GABGKBAKHDP.StartupPools;
			if (startupPools != null && startupPools.Length > 0)
			{
				for (int i = 0; i < startupPools.Length; i++)
				{
					CreatePool(startupPools[i].Prefab, startupPools[i].Size);
				}
			}
		}

		public static void CreatePool<T>(T AGIOLFBGANM, int KMCCJKEKLEA) where T : Component
		{
			CreatePool(AGIOLFBGANM.gameObject, KMCCJKEKLEA);
		}

		public static void CreatePool(GameObject AGIOLFBGANM, int KMCCJKEKLEA)
		{
			if (AGIOLFBGANM == null || GABGKBAKHDP.EFIMINCNLKK.ContainsKey(AGIOLFBGANM))
			{
				return;
			}
			List<GameObject> list = new List<GameObject>();
			GABGKBAKHDP.EFIMINCNLKK.Add(AGIOLFBGANM, list);
			if (KMCCJKEKLEA > 0)
			{
				bool activeSelf = AGIOLFBGANM.activeSelf;
				AGIOLFBGANM.SetActive(false);
				while (list.Count < KMCCJKEKLEA)
				{
					GameObject item = UnityEngine.Object.Instantiate(AGIOLFBGANM);
					list.Add(item);
				}
				AGIOLFBGANM.SetActive(activeSelf);
			}
		}

		public static void DoActionInPool(GameObject AGIOLFBGANM, Action<GameObject> GPLIOLJFDPM)
		{
			List<GameObject> value;
			if (AGIOLFBGANM == null || !GABGKBAKHDP.EFIMINCNLKK.TryGetValue(AGIOLFBGANM, out value))
			{
				return;
			}
			for (int i = 0; i < value.Count; i++)
			{
				GameObject gameObject = value[i];
				if (gameObject != null && GPLIOLJFDPM != null)
				{
					GPLIOLJFDPM(gameObject);
				}
			}
		}

		public static T Spawn<T>(T AGIOLFBGANM, Vector3 LDMDBPLADGD, Quaternion ODLHFMOPCHL) where T : Component
		{
			return Spawn(AGIOLFBGANM.gameObject, LDMDBPLADGD, ODLHFMOPCHL).GetComponent<T>();
		}

		public static T Spawn<T>(T AGIOLFBGANM, Vector3 LDMDBPLADGD) where T : Component
		{
			return Spawn(AGIOLFBGANM.gameObject, LDMDBPLADGD, Quaternion.identity).GetComponent<T>();
		}

		public static T Spawn<T>(T AGIOLFBGANM) where T : Component
		{
			return Spawn(AGIOLFBGANM.gameObject, Vector3.zero, Quaternion.identity).GetComponent<T>();
		}

		public static GameObject Spawn(GameObject AGIOLFBGANM, Vector3 LDMDBPLADGD, Quaternion ODLHFMOPCHL)
		{
			List<GameObject> value;
			GameObject gameObject;
			Transform transform;
			if (GABGKBAKHDP.EFIMINCNLKK.TryGetValue(AGIOLFBGANM, out value))
			{
				gameObject = null;
				if (value.Count > 0)
				{
					while (gameObject == null && value.Count > 0)
					{
						gameObject = value[0];
						value.RemoveAt(0);
					}
					if (gameObject != null)
					{
						transform = gameObject.transform;
						transform.localPosition = LDMDBPLADGD;
						transform.localRotation = ODLHFMOPCHL;
						gameObject.SetActive(true);
						GABGKBAKHDP.CGDPNKMDBEI.Add(gameObject, AGIOLFBGANM);
						return gameObject;
					}
				}
				gameObject = UnityEngine.Object.Instantiate(AGIOLFBGANM);
				transform = gameObject.transform;
				transform.localPosition = LDMDBPLADGD;
				transform.localRotation = ODLHFMOPCHL;
				GABGKBAKHDP.CGDPNKMDBEI.Add(gameObject, AGIOLFBGANM);
				return gameObject;
			}
			gameObject = UnityEngine.Object.Instantiate(AGIOLFBGANM);
			transform = gameObject.GetComponent<Transform>();
			transform.localPosition = LDMDBPLADGD;
			transform.localRotation = ODLHFMOPCHL;
			return gameObject;
		}

		public static void Recycle<T>(T NEMEKIOEOLC) where T : Component
		{
			Recycle(NEMEKIOEOLC.gameObject);
		}

		public static void Recycle(GameObject NEMEKIOEOLC)
		{
			if (!(NEMEKIOEOLC == null))
			{
				GameObject value;
				if (GABGKBAKHDP.CGDPNKMDBEI.TryGetValue(NEMEKIOEOLC, out value))
				{
					MEJPNNFDEBD(NEMEKIOEOLC, value);
				}
				else
				{
					UnityEngine.Object.Destroy(NEMEKIOEOLC);
				}
			}
		}

		private static void MEJPNNFDEBD(GameObject NEMEKIOEOLC, GameObject AGIOLFBGANM)
		{
			GABGKBAKHDP.EFIMINCNLKK[AGIOLFBGANM].Add(NEMEKIOEOLC);
			GABGKBAKHDP.CGDPNKMDBEI.Remove(NEMEKIOEOLC);
			NEMEKIOEOLC.SetActive(false);
		}

		public static void RecycleAll<T>(T AGIOLFBGANM) where T : Component
		{
			RecycleAll(AGIOLFBGANM.gameObject);
		}

		public static void RecycleAll(GameObject AGIOLFBGANM)
		{
			foreach (KeyValuePair<GameObject, GameObject> item in GABGKBAKHDP.CGDPNKMDBEI)
			{
				if (item.Value == AGIOLFBGANM)
				{
					KKJJPADJBFM.Add(item.Key);
				}
			}
			for (int i = 0; i < KKJJPADJBFM.Count; i++)
			{
				Recycle(KKJJPADJBFM[i]);
			}
			KKJJPADJBFM.Clear();
		}

		public static void RecycleAll()
		{
			KKJJPADJBFM.AddRange(GABGKBAKHDP.CGDPNKMDBEI.Keys);
			for (int i = 0; i < KKJJPADJBFM.Count; i++)
			{
				Recycle(KKJJPADJBFM[i]);
			}
			KKJJPADJBFM.Clear();
		}

		public static bool IsSpawned(GameObject NEMEKIOEOLC)
		{
			return GABGKBAKHDP.CGDPNKMDBEI.ContainsKey(NEMEKIOEOLC);
		}

		public static int CountPooled<T>(T AGIOLFBGANM) where T : Component
		{
			return CountPooled(AGIOLFBGANM.gameObject);
		}

		public static int CountPooled(GameObject AGIOLFBGANM)
		{
			List<GameObject> value;
			return GABGKBAKHDP.EFIMINCNLKK.TryGetValue(AGIOLFBGANM, out value) ? value.Count : 0;
		}

		public static int CountSpawned<T>(T AGIOLFBGANM) where T : Component
		{
			return CountSpawned(AGIOLFBGANM.gameObject);
		}

		public static int CountSpawned(GameObject AGIOLFBGANM)
		{
			int num = 0;
			foreach (GameObject value in GABGKBAKHDP.CGDPNKMDBEI.Values)
			{
				if (AGIOLFBGANM == value)
				{
					num++;
				}
			}
			return num;
		}

		public static int CountAllPooled()
		{
			int num = 0;
			foreach (List<GameObject> value in GABGKBAKHDP.EFIMINCNLKK.Values)
			{
				num += value.Count;
			}
			return num;
		}

		public static List<GameObject> GetPooled(GameObject AGIOLFBGANM, List<GameObject> PNKBIONHGEJ, bool CCGMMLGPNMB)
		{
			if (PNKBIONHGEJ == null)
			{
				PNKBIONHGEJ = new List<GameObject>();
			}
			if (!CCGMMLGPNMB)
			{
				PNKBIONHGEJ.Clear();
			}
			List<GameObject> value;
			if (GABGKBAKHDP.EFIMINCNLKK.TryGetValue(AGIOLFBGANM, out value))
			{
				PNKBIONHGEJ.AddRange(value);
			}
			return PNKBIONHGEJ;
		}

		public static List<T> GetPooled<T>(T AGIOLFBGANM, List<T> PNKBIONHGEJ, bool CCGMMLGPNMB) where T : Component
		{
			if (PNKBIONHGEJ == null)
			{
				PNKBIONHGEJ = new List<T>();
			}
			if (!CCGMMLGPNMB)
			{
				PNKBIONHGEJ.Clear();
			}
			List<GameObject> value;
			if (!GABGKBAKHDP.EFIMINCNLKK.TryGetValue(AGIOLFBGANM.gameObject, out value))
			{
				return PNKBIONHGEJ;
			}
			for (int i = 0; i < value.Count; i++)
			{
				PNKBIONHGEJ.Add(value[i].GetComponent<T>());
			}
			return PNKBIONHGEJ;
		}

		public static List<GameObject> GetSpawned(GameObject AGIOLFBGANM, List<GameObject> PNKBIONHGEJ, bool CCGMMLGPNMB)
		{
			if (PNKBIONHGEJ == null)
			{
				PNKBIONHGEJ = new List<GameObject>();
			}
			if (!CCGMMLGPNMB)
			{
				PNKBIONHGEJ.Clear();
			}
			foreach (KeyValuePair<GameObject, GameObject> item in GABGKBAKHDP.CGDPNKMDBEI)
			{
				if (item.Value == AGIOLFBGANM)
				{
					PNKBIONHGEJ.Add(item.Key);
				}
			}
			return PNKBIONHGEJ;
		}

		public static List<T> GetSpawned<T>(T AGIOLFBGANM, List<T> PNKBIONHGEJ, bool CCGMMLGPNMB) where T : Component
		{
			if (PNKBIONHGEJ == null)
			{
				PNKBIONHGEJ = new List<T>();
			}
			if (!CCGMMLGPNMB)
			{
				PNKBIONHGEJ.Clear();
			}
			GameObject gameObject = AGIOLFBGANM.gameObject;
			foreach (KeyValuePair<GameObject, GameObject> item in GABGKBAKHDP.CGDPNKMDBEI)
			{
				if (item.Value == gameObject)
				{
					PNKBIONHGEJ.Add(item.Key.GetComponent<T>());
				}
			}
			return PNKBIONHGEJ;
		}

		public static void DestroyPooled(GameObject AGIOLFBGANM)
		{
			List<GameObject> value;
			if (GABGKBAKHDP.EFIMINCNLKK.TryGetValue(AGIOLFBGANM, out value))
			{
				for (int i = 0; i < value.Count; i++)
				{
					UnityEngine.Object.Destroy(value[i]);
				}
				value.Clear();
			}
		}

		public static void DestroyPooled<T>(T AGIOLFBGANM) where T : Component
		{
			DestroyPooled(AGIOLFBGANM.gameObject);
		}

		public static void DestroyAll(GameObject AGIOLFBGANM)
		{
			RecycleAll(AGIOLFBGANM);
			DestroyPooled(AGIOLFBGANM);
		}

		public static void DestroyAll<T>(T AGIOLFBGANM) where T : Component
		{
			DestroyAll(AGIOLFBGANM.gameObject);
		}
	}
}
