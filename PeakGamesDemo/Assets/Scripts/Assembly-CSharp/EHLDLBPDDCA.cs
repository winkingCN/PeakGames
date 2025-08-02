using System;
using System.Collections.Generic;

public class EHLDLBPDDCA
{
	internal string FMGPCBJLMDF;

	internal string BCBPCIDMPKH;

	internal List<string> BICOOJBKIGD;

	internal List<string> DGIKNAGBEKB;

	internal double? CLJGNAOABFP;

	internal string CIDGIIHKCFN;

	internal string LFCPPDHKCOA;

	internal bool JEOGFGDLGPP;

	public EHLDLBPDDCA(string BCBPCIDMPKH)
	{
		this.BCBPCIDMPKH = BCBPCIDMPKH;
		JEOGFGDLGPP = false;
	}

	public void KKIFGBLLNEK(double NNIDKMJGAJO, string FMGPCBJLMDF)
	{
		CLJGNAOABFP = NNIDKMJGAJO;
		this.FMGPCBJLMDF = FMGPCBJLMDF;
	}

	public void DECKANCHOJE(string IKNCPEPOKGJ, string EDDNOJDPMCF)
	{
		if (DGIKNAGBEKB == null)
		{
			DGIKNAGBEKB = new List<string>();
		}
		DGIKNAGBEKB.Add(IKNCPEPOKGJ);
		DGIKNAGBEKB.Add(EDDNOJDPMCF);
	}

	public void APHCHNMBEPA(string IKNCPEPOKGJ, string EDDNOJDPMCF)
	{
		if (BICOOJBKIGD == null)
		{
			BICOOJBKIGD = new List<string>();
		}
		BICOOJBKIGD.Add(IKNCPEPOKGJ);
		BICOOJBKIGD.Add(EDDNOJDPMCF);
	}

	public void LGNBAKFFCNP(string LFCPPDHKCOA)
	{
		this.LFCPPDHKCOA = LFCPPDHKCOA;
	}

	[Obsolete("This is an obsolete method. Please use the adjust purchase SDK for purchase verification (https://github.com/adjust/unity_purchase_sdk)")]
	public void NFAJIIEPOPA(string CIDGIIHKCFN, string LFCPPDHKCOA)
	{
		this.CIDGIIHKCFN = CIDGIIHKCFN;
		this.LFCPPDHKCOA = LFCPPDHKCOA;
		JEOGFGDLGPP = true;
	}
}
