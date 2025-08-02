using System.Collections;
using Spine.Unity;
using UnityEngine;

public class OJOAPMFGBJJ : IEnumerator
{
	private MDBINBLMHMC LKJFINLMNJA;

	private string CMCLDIDOOJG;

	private KJKAIEHNGAL MOFHHFENEDP;

	private bool HHJKHKIKCNG;

	private bool EFAOGCJHBGL;

	object IEnumerator.Current
	{
		get
		{
			return null;
		}
	}

	public bool JGCGICFPLBK
	{
		get
		{
			return EFAOGCJHBGL;
		}
		set
		{
			EFAOGCJHBGL = value;
		}
	}

	public OJOAPMFGBJJ(KJKAIEHNGAL BGEDKGLJIGM, MDBINBLMHMC FFNHECMINDH, bool MDPMIDKMJDJ = true)
	{
		ELILAHCOBEA(BGEDKGLJIGM, FFNHECMINDH, MDPMIDKMJDJ);
	}

	public OJOAPMFGBJJ(SkeletonAnimation JCNIBPMAAPG, MDBINBLMHMC FFNHECMINDH, bool MDPMIDKMJDJ = true)
	{
		ELILAHCOBEA(JCNIBPMAAPG.state, FFNHECMINDH, MDPMIDKMJDJ);
	}

	public OJOAPMFGBJJ(KJKAIEHNGAL BGEDKGLJIGM, string PACBNANIAKH, bool MDPMIDKMJDJ = true)
	{
		KNNBEHKLMAP(BGEDKGLJIGM, PACBNANIAKH, MDPMIDKMJDJ);
	}

	public OJOAPMFGBJJ(SkeletonAnimation JCNIBPMAAPG, string PACBNANIAKH, bool MDPMIDKMJDJ = true)
	{
		KNNBEHKLMAP(JCNIBPMAAPG.state, PACBNANIAKH, MDPMIDKMJDJ);
	}

	private void ELILAHCOBEA(KJKAIEHNGAL BGEDKGLJIGM, MDBINBLMHMC FFNHECMINDH, bool GMMCHNJMECH)
	{
		if (BGEDKGLJIGM == null)
		{
			Debug.LogWarning("AnimationState argument was null. Coroutine will continue immediately.");
			HHJKHKIKCNG = true;
			return;
		}
		if (FFNHECMINDH == null)
		{
			Debug.LogWarning("eventDataReference argument was null. Coroutine will continue immediately.");
			HHJKHKIKCNG = true;
			return;
		}
		MOFHHFENEDP = BGEDKGLJIGM;
		LKJFINLMNJA = FFNHECMINDH;
		BGEDKGLJIGM.FAMOCPPGDPK += POKICIAHHLE;
		EFAOGCJHBGL = GMMCHNJMECH;
	}

	private void KNNBEHKLMAP(KJKAIEHNGAL BGEDKGLJIGM, string PACBNANIAKH, bool GMMCHNJMECH)
	{
		if (BGEDKGLJIGM == null)
		{
			Debug.LogWarning("AnimationState argument was null. Coroutine will continue immediately.");
			HHJKHKIKCNG = true;
			return;
		}
		if (string.IsNullOrEmpty(PACBNANIAKH))
		{
			Debug.LogWarning("eventName argument was null. Coroutine will continue immediately.");
			HHJKHKIKCNG = true;
			return;
		}
		MOFHHFENEDP = BGEDKGLJIGM;
		CMCLDIDOOJG = PACBNANIAKH;
		BGEDKGLJIGM.FAMOCPPGDPK += FMGPGHNNNAG;
		EFAOGCJHBGL = GMMCHNJMECH;
	}

	private void FMGPGHNNNAG(JHFLAELBLPM NBOKLOHDENL, DCBJAMHBAJB EKFOKNPODBK)
	{
		HHJKHKIKCNG |= EKFOKNPODBK.LJDLCPHOBHB.PNGPLGHKFDI == CMCLDIDOOJG;
		if (HHJKHKIKCNG && EFAOGCJHBGL)
		{
			MOFHHFENEDP.FAMOCPPGDPK -= FMGPGHNNNAG;
		}
	}

	private void POKICIAHHLE(JHFLAELBLPM NBOKLOHDENL, DCBJAMHBAJB EKFOKNPODBK)
	{
		HHJKHKIKCNG |= EKFOKNPODBK.LJDLCPHOBHB == LKJFINLMNJA;
		if (HHJKHKIKCNG && EFAOGCJHBGL)
		{
			MOFHHFENEDP.FAMOCPPGDPK -= POKICIAHHLE;
		}
	}

	public OJOAPMFGBJJ CBHBCGFEOOK(KJKAIEHNGAL BGEDKGLJIGM, MDBINBLMHMC FFNHECMINDH, bool MDPMIDKMJDJ = true)
	{
		((IEnumerator)this).Reset();
		BOPEPLONIFL(BGEDKGLJIGM);
		ELILAHCOBEA(BGEDKGLJIGM, FFNHECMINDH, MDPMIDKMJDJ);
		return this;
	}

	public OJOAPMFGBJJ CBHBCGFEOOK(KJKAIEHNGAL BGEDKGLJIGM, string PACBNANIAKH, bool MDPMIDKMJDJ = true)
	{
		((IEnumerator)this).Reset();
		BOPEPLONIFL(BGEDKGLJIGM);
		KNNBEHKLMAP(BGEDKGLJIGM, PACBNANIAKH, MDPMIDKMJDJ);
		return this;
	}

	private void BOPEPLONIFL(KJKAIEHNGAL BGEDKGLJIGM)
	{
		BGEDKGLJIGM.FAMOCPPGDPK -= POKICIAHHLE;
		BGEDKGLJIGM.FAMOCPPGDPK -= FMGPGHNNNAG;
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
