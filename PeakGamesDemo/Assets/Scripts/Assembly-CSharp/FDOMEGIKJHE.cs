using System.Collections;
using UnityEngine;

public class FDOMEGIKJHE : IEnumerator
{
	private bool HHJKHKIKCNG;

	object IEnumerator.Current
	{
		get
		{
			return null;
		}
	}

	public FDOMEGIKJHE(JHFLAELBLPM NBOKLOHDENL)
	{
		JJEENFLFJIM(NBOKLOHDENL);
	}

	private void EKKJKMDMBMI(JHFLAELBLPM NBOKLOHDENL)
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
			NBOKLOHDENL.BBLBNCKNGDL += EKKJKMDMBMI;
		}
	}

	public FDOMEGIKJHE CBHBCGFEOOK(JHFLAELBLPM NBOKLOHDENL)
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
