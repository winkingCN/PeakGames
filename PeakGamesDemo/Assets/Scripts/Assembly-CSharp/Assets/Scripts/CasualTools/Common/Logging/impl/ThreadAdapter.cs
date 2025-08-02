using System.Collections;
using UnityEngine;

namespace Assets.Scripts.CasualTools.Common.Logging.impl
{
	internal class ThreadAdapter : MonoBehaviour
	{
		public static int X;

		private volatile ANIHAALHGAP PKLFKHMNNGF;

		private volatile bool FJBGILKKGGN = true;

		public void Awake()
		{
			Object.DontDestroyOnLoad(base.gameObject);
			base.name = "ThreadAdapter-" + X++;
		}

		public IEnumerator Start()
		{
			while (FJBGILKKGGN)
			{
				yield return new WaitForSeconds(0.05f);
			}
			PKLFKHMNNGF();
			Object.Destroy(base.gameObject);
		}

		public void ExecuteOnUi(ANIHAALHGAP GPLIOLJFDPM)
		{
			PKLFKHMNNGF = GPLIOLJFDPM;
			FJBGILKKGGN = false;
		}
	}
}
