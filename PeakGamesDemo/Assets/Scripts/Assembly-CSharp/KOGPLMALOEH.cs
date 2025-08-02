using System;
using System.Collections;
using System.IO;

public class KOGPLMALOEH : ALLINHNNNJN
{
	public static readonly KOGPLMALOEH JIKOOGGLMBO = new KOGPLMALOEH();

	public KOGPLMALOEH()
		: base(0)
	{
	}

	public KOGPLMALOEH(LNKPCJLANAO NEMEKIOEOLC)
		: base(1)
	{
		HIJCJONMAJO(NEMEKIOEOLC);
	}

	public KOGPLMALOEH(params LNKPCJLANAO[] AAIEJDNAODP)
		: base(AAIEJDNAODP.Length)
	{
		foreach (LNKPCJLANAO nEMEKIOEOLC in AAIEJDNAODP)
		{
			HIJCJONMAJO(nEMEKIOEOLC);
		}
	}

	public KOGPLMALOEH(DLDBGGDLOOO AAIEJDNAODP)
		: base(AAIEJDNAODP.GMCGMPEEHJP)
	{
		foreach (LNKPCJLANAO item in AAIEJDNAODP)
		{
			HIJCJONMAJO(item);
		}
	}

	public static KOGPLMALOEH CGMEKNCLBKE(DLDBGGDLOOO AAIEJDNAODP)
	{
		return (AAIEJDNAODP.GMCGMPEEHJP >= 1) ? new KOGPLMALOEH(AAIEJDNAODP) : JIKOOGGLMBO;
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
		NMHOOGAGLOA.AGNEJPEMPAP(48, dIPNEDDIHBK);
	}
}
