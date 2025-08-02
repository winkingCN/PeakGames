using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

internal class BILHEHGBDLK<T> where T : new()
{
	private readonly Stack<T> GMPHMPNPOKM = new Stack<T>();

	private readonly UnityAction<T> DHBMNMOJCCK;

	private readonly UnityAction<T> MFACFPBMMPO;

	public int DOFGDMHBGHM { get; private set; }

	public int KACAFKBHJME
	{
		get
		{
			return DOFGDMHBGHM - HDNIBLCDOHL;
		}
	}

	public int HDNIBLCDOHL
	{
		get
		{
			return GMPHMPNPOKM.Count;
		}
	}

	public BILHEHGBDLK(UnityAction<T> GFGDDHKDBJE, UnityAction<T> FJPLMFPJING)
	{
		DHBMNMOJCCK = GFGDDHKDBJE;
		MFACFPBMMPO = FJPLMFPJING;
	}

	public T GHBGCADFLFB()
	{
		T val;
		if (GMPHMPNPOKM.Count == 0)
		{
			val = new T();
			DOFGDMHBGHM++;
		}
		else
		{
			val = GMPHMPNPOKM.Pop();
		}
		if (DHBMNMOJCCK != null)
		{
			DHBMNMOJCCK(val);
		}
		return val;
	}

	public void PNCNHFLJCIG(T KHLONKALNLL)
	{
		if (GMPHMPNPOKM.Count > 0 && object.ReferenceEquals(GMPHMPNPOKM.Peek(), KHLONKALNLL))
		{
			Debug.LogError("Internal error. Trying to destroy object that is already released to pool.");
		}
		if (MFACFPBMMPO != null)
		{
			MFACFPBMMPO(KHLONKALNLL);
		}
		GMPHMPNPOKM.Push(KHLONKALNLL);
	}
}
