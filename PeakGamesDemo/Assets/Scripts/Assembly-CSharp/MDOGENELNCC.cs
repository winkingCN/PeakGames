using System.Collections;
using UnityEngine;

public class MDOGENELNCC : IEnumerator
{
	private bool HHJKHKIKCNG;

	object IEnumerator.Current
	{
		get
		{
			return null;
		}
	}

	public MDOGENELNCC(JHFLAELBLPM NBOKLOHDENL)
	{
		JJEENFLFJIM(NBOKLOHDENL);
	}

	private void GBAJOMAEMOP(JHFLAELBLPM NBOKLOHDENL)
	{
		HHJKHKIKCNG = true;
	}

	private void JJEENFLFJIM(JHFLAELBLPM NBOKLOHDENL)
	{
		if (NBOKLOHDENL == null)
		{
			Debug.LogWarning("TrackEntry was null. Coroutine will continue immediately.");
			HHJKHKIKCNG = true;
		}
		else
		{
			NBOKLOHDENL.DHOFLMAIDKL += GBAJOMAEMOP;
		}
	}

	public MDOGENELNCC CBHBCGFEOOK(JHFLAELBLPM NBOKLOHDENL)
	{
		JJEENFLFJIM(NBOKLOHDENL);
		return this;
	}

	bool IEnumerator.MoveNext()
	{
		if (HHJKHKIKCNG)
		{
			((IEnumerator)this).Reset();
			return false;
		}
		return true;
	}

	void IEnumerator.Reset()
	{
		HHJKHKIKCNG = false;
	}
}
