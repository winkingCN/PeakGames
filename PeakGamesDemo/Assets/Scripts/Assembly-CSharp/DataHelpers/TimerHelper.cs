using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DataHelpers
{
	public class TimerHelper : MonoBehaviour
	{
		private static TimerHelper KNPOFJNFLJB;

		private Coroutine BIOAPDMEEFC;

		private readonly List<CCGJIPEFOEL> MIOMMMOILCJ = new List<CCGJIPEFOEL>();

		public static TimerHelper GABGKBAKHDP
		{
			get
			{
				if (KNPOFJNFLJB == null)
				{
					GameObject gameObject = new GameObject();
					gameObject.AddComponent<TimerHelper>();
					gameObject.name = "TimerHelper";
					KNPOFJNFLJB = gameObject.GetComponent<TimerHelper>();
				}
				return KNPOFJNFLJB;
			}
		}

		public void RegisterTimer(CCGJIPEFOEL JINJJNAPAKA)
		{
			if (!MIOMMMOILCJ.Contains(JINJJNAPAKA))
			{
				MIOMMMOILCJ.Add(JINJJNAPAKA);
				if (BIOAPDMEEFC == null)
				{
					PABIBDNELIL();
				}
			}
		}

		public void DeregisterTimer(CCGJIPEFOEL JINJJNAPAKA)
		{
			if (MIOMMMOILCJ.Contains(JINJJNAPAKA))
			{
				MIOMMMOILCJ.Remove(JINJJNAPAKA);
			}
		}

		private IEnumerator JLCPBNFKFEH()
		{
			while (true)
			{
				if (MIOMMMOILCJ.Count <= 0)
				{
					OALMCJGPMKJ();
				}
				yield return MCJHHDACJBG.KNLADMIBAAD;
				for (int num = MIOMMMOILCJ.Count - 1; num >= 0; num--)
				{
					MIOMMMOILCJ[num].DecreaseTimeLeft();
				}
			}
		}

		private void PABIBDNELIL()
		{
			BIOAPDMEEFC = StartCoroutine(JLCPBNFKFEH());
		}

		private void OALMCJGPMKJ()
		{
			StopCoroutine(BIOAPDMEEFC);
			BIOAPDMEEFC = null;
		}

		private void OnApplicationPause(bool MMMKENCKOAL)
		{
			if (!MMMKENCKOAL && MIOMMMOILCJ.Count > 0)
			{
				for (int num = MIOMMMOILCJ.Count - 1; num >= 0; num--)
				{
					MIOMMMOILCJ[num].UpdateTimeLeft();
				}
			}
		}

		private void OnDestroy()
		{
			KNPOFJNFLJB = null;
		}
	}
}
