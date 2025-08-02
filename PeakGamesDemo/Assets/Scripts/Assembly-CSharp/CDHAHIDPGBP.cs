using System;
using System.Collections;
using System.IO;

public class CDHAHIDPGBP : FAGODOKGMEH
{
	public static readonly CDHAHIDPGBP JIKOOGGLMBO = new CDHAHIDPGBP();

	public CDHAHIDPGBP()
		: base(0)
	{
	}

	public CDHAHIDPGBP(LNKPCJLANAO NEMEKIOEOLC)
		: base(1)
	{
		HIJCJONMAJO(NEMEKIOEOLC);
	}

	public CDHAHIDPGBP(params LNKPCJLANAO[] AAIEJDNAODP)
		: base(AAIEJDNAODP.Length)
	{
		foreach (LNKPCJLANAO nEMEKIOEOLC in AAIEJDNAODP)
		{
			HIJCJONMAJO(nEMEKIOEOLC);
		}
		FCNOEDGGBBO();
	}

	public CDHAHIDPGBP(DLDBGGDLOOO AAIEJDNAODP)
		: this(AAIEJDNAODP, true)
	{
	}

	internal CDHAHIDPGBP(DLDBGGDLOOO AAIEJDNAODP, bool KGGNPPNNLFD)
		: base(AAIEJDNAODP.GMCGMPEEHJP)
	{
		foreach (LNKPCJLANAO item in AAIEJDNAODP)
		{
			HIJCJONMAJO(item);
		}
		if (KGGNPPNNLFD)
		{
			FCNOEDGGBBO();
		}
	}

	public static CDHAHIDPGBP CGMEKNCLBKE(DLDBGGDLOOO AAIEJDNAODP)
	{
		return (AAIEJDNAODP.GMCGMPEEHJP >= 1) ? new CDHAHIDPGBP(AAIEJDNAODP) : JIKOOGGLMBO;
	}

	internal static CDHAHIDPGBP CGMEKNCLBKE(DLDBGGDLOOO AAIEJDNAODP, bool KGGNPPNNLFD)
	{
		return (AAIEJDNAODP.GMCGMPEEHJP >= 1) ? new CDHAHIDPGBP(AAIEJDNAODP, KGGNPPNNLFD) : JIKOOGGLMBO;
	}

	internal override void LMDBBPLCJDM(JBLJHINPLMC NMHOOGAGLOA)
	{
		MemoryStream memoryStream = new MemoryStream();
		JBLJHINPLMC jBLJHINPLMC = new JBLJHINPLMC(memoryStream);
		IEnumerator enumerator = GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				LNKPCJLANAO nEMEKIOEOLC = (LNKPCJLANAO)enumerator.Current;
				jBLJHINPLMC.ELPOLPFGCHA(nEMEKIOEOLC);
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
		LHFGHNFJIKM.PCHCAFHEJJM(jBLJHINPLMC);
		byte[] dIPNEDDIHBK = memoryStream.ToArray();
		NMHOOGAGLOA.AGNEJPEMPAP(49, dIPNEDDIHBK);
	}
}
