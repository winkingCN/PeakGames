using System;
using System.Collections.Generic;
using System.Reflection;

[DefaultMember("Item")]
public class MBBJJJGFIKD
{
	public List<string> LDEJFNHFMCI { get; set; }

	public List<DCMNFAKJKCH> DFOGCCJCNJJ { get; set; }

	public DCMNFAKJKCH AHANCLBKKID
	{
		get
		{
			return DFOGCCJCNJJ[BCAKHCNOKDH];
		}
	}

	public MBBJJJGFIKD()
	{
		LDEJFNHFMCI = new List<string>(11);
		DFOGCCJCNJJ = new List<DCMNFAKJKCH>(50);
	}

	public void EFECDJHHKPP(object[] OLNMBMEIBPL)
	{
		if (OLNMBMEIBPL.Length != LDEJFNHFMCI.Count)
		{
			throw new IndexOutOfRangeException("The number of values in the row must match the number of column");
		}
		DCMNFAKJKCH dCMNFAKJKCH = new DCMNFAKJKCH(11);
		int i = 0;
		for (int num = OLNMBMEIBPL.Length; i < num; i++)
		{
			dCMNFAKJKCH.GLAFODPFNBA(LDEJFNHFMCI[i], OLNMBMEIBPL[i]);
		}
		DFOGCCJCNJJ.Add(dCMNFAKJKCH);
	}
}
