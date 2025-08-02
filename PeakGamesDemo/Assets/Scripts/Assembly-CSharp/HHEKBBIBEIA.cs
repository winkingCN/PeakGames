using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

public static class HHEKBBIBEIA
{
	public delegate T NCCCNHCBEDD<out T>();

	public delegate void CBOEHJKEFBH<in T>(T DIDHNNMKJFE);

	internal class JCOAJGNBEDC : MonoBehaviour
	{
		private static int KGNOGPIGOCD;

		private volatile Action PKLFKHMNNGF;

		private volatile bool FJBGILKKGGN = true;

		public void Awake()
		{
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			base.name = "ThreadAdapter-" + KGNOGPIGOCD++;
			StartCoroutine(CheckControls());
		}

		public IEnumerator CheckControls()
		{
			while (FJBGILKKGGN)
			{
				yield return null;
			}
			if (PKLFKHMNNGF != null)
			{
				PKLFKHMNNGF();
			}
			UnityEngine.Object.Destroy(base.gameObject);
		}

		public void ExecuteOnUi(Action GPLIOLJFDPM)
		{
			PKLFKHMNNGF = GPLIOLJFDPM;
			FJBGILKKGGN = false;
		}
	}

	[CompilerGenerated]
	private sealed class FCOBLOJANNA<T>
	{
		internal CBOEHJKEFBH<T> HNJJMFOGAMG;

		internal T DIDHNNMKJFE;

		internal void AGFNGEFDHLA()
		{
			HNJJMFOGAMG(DIDHNNMKJFE);
		}
	}

	public static void COMBEBPMPKN<T>(NCCCNHCBEDD<T> LDDNGLAKLIC, CBOEHJKEFBH<T> AFGJEIAKPKC = null)
	{
		JCOAJGNBEDC jCOAJGNBEDC = ((AFGJEIAKPKC != null) ? GOAMDDCPHKB() : null);
		ThreadPool.QueueUserWorkItem(LAGJMDJOBLO<T>, new object[3] { LDDNGLAKLIC, jCOAJGNBEDC, AFGJEIAKPKC });
	}

	private static void LAGJMDJOBLO<T>(object BGEDKGLJIGM)
	{
		object[] array = BGEDKGLJIGM as object[];
		NCCCNHCBEDD<T> nCCCNHCBEDD = (NCCCNHCBEDD<T>)array[0];
		JCOAJGNBEDC jCOAJGNBEDC = array[1] as JCOAJGNBEDC;
		CBOEHJKEFBH<T> HNJJMFOGAMG = array[2] as CBOEHJKEFBH<T>;
		T DIDHNNMKJFE = nCCCNHCBEDD();
		if (jCOAJGNBEDC != null)
		{
			jCOAJGNBEDC.ExecuteOnUi(delegate
			{
				HNJJMFOGAMG(DIDHNNMKJFE);
			});
		}
	}

	internal static JCOAJGNBEDC GOAMDDCPHKB()
	{
		GameObject gameObject = new GameObject();
		return gameObject.AddComponent<JCOAJGNBEDC>();
	}
}
