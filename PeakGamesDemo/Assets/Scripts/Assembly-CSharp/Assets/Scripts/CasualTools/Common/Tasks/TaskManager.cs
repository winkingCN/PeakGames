using System.Collections;
using UnityEngine;

namespace Assets.Scripts.CasualTools.Common.Tasks
{
	public class TaskManager : MonoBehaviour
	{
		public class PJJFKCFOKDI
		{
			public delegate void LPHBPDAOANH(bool FCNNBNOMAEM);

			private readonly IEnumerator JDPMHEPHHCC;

			private readonly bool DLKICIBLBAJ;

			private bool NJFFLDHALCG;

			public bool BPLCLABMIMM { get; private set; }

			public bool CKBKJIGINHP { get; private set; }

			public event LPHBPDAOANH LDFKMBBIDMP;

			public PJJFKCFOKDI(IEnumerator FMFABAKPMLB, bool GHAFHGHANLG)
			{
				JDPMHEPHHCC = FMFABAKPMLB;
				DLKICIBLBAJ = GHAFHGHANLG;
				CKBKJIGINHP = false;
				BPLCLABMIMM = false;
				NJFFLDHALCG = false;
				this.LDFKMBBIDMP = null;
			}

			public void LGDIMLEGDJB()
			{
				CKBKJIGINHP = true;
			}

			public void HKLEKMPMJGF()
			{
				CKBKJIGINHP = false;
			}

			public void BAMKBCHHLGP()
			{
				BPLCLABMIMM = true;
				if (DLKICIBLBAJ)
				{
					DNLCCNIKJPE.StartCoroutine(NJJKMLGMHCO());
				}
				else
				{
					NOGEAPAIOLK.StartCoroutine(NJJKMLGMHCO());
				}
			}

			public void BPPFBMCJOAH()
			{
				NJFFLDHALCG = true;
				BPLCLABMIMM = false;
			}

			private IEnumerator NJJKMLGMHCO()
			{
				IEnumerator jDPMHEPHHCC = JDPMHEPHHCC;
				while (BPLCLABMIMM)
				{
					if (CKBKJIGINHP)
					{
						yield return null;
					}
					else if (jDPMHEPHHCC != null && jDPMHEPHHCC.MoveNext())
					{
						yield return jDPMHEPHHCC.Current;
					}
					else
					{
						BPLCLABMIMM = false;
					}
				}
				LPHBPDAOANH lDFKMBBIDMP = this.LDFKMBBIDMP;
				if (lDFKMBBIDMP != null)
				{
					lDFKMBBIDMP(NJFFLDHALCG);
				}
			}
		}

		private static TaskManager NOGEAPAIOLK;

		private static TaskManager DNLCCNIKJPE;

		public static void Prepare()
		{
			if (NOGEAPAIOLK == null)
			{
				GameObject gameObject = new GameObject("TaskManager");
				NOGEAPAIOLK = gameObject.AddComponent<TaskManager>();
			}
			if (DNLCCNIKJPE == null)
			{
				GameObject gameObject2 = new GameObject("ZombieTaskManager");
				Object.DontDestroyOnLoad(gameObject2);
				DNLCCNIKJPE = gameObject2.AddComponent<TaskManager>();
			}
		}

		public static PJJFKCFOKDI CreateTask(IEnumerator EMEADLCFDFD)
		{
			Prepare();
			return new PJJFKCFOKDI(EMEADLCFDFD, false);
		}

		public static PJJFKCFOKDI CreateZombieTask(IEnumerator EMEADLCFDFD)
		{
			Prepare();
			return new PJJFKCFOKDI(EMEADLCFDFD, true);
		}
	}
}
