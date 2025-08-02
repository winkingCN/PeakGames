using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

public class NLPADEFLHIA
{
	private static NLPADEFLHIA GGOLOIHLJBM;

	private Queue<GOBAKADFEOD> NIADOHJDKCK;

	private ManualResetEvent CDBOLMBPABD = new ManualResetEvent(false);

	private Dictionary<string, FGGOGJLHPHD> FKFEHMMNBIK = new Dictionary<string, FGGOGJLHPHD>();

	private Thread ADBDBCHNAEJ;

	private bool MMCCBJNBGNL;

	private NLPADEFLHIA()
	{
		NIADOHJDKCK = new Queue<GOBAKADFEOD>();
		ADBDBCHNAEJ = new Thread((ThreadStart)delegate
		{
			try
			{
				AndroidJNI.AttachCurrentThread();
				while (!MMCCBJNBGNL)
				{
					while (!MMCCBJNBGNL && NIADOHJDKCK.Count > 0)
					{
						GOBAKADFEOD gOBAKADFEOD = NIADOHJDKCK.Dequeue();
						try
						{
							BDDICPKMJIL(gOBAKADFEOD);
						}
						catch (Exception ex)
						{
							Debug.Log("Error in : " + gOBAKADFEOD.DFBFLINFFBE + ". Exception : " + ex.Message + ex.StackTrace);
						}
					}
					if (!MMCCBJNBGNL)
					{
						CDBOLMBPABD.WaitOne();
						CDBOLMBPABD.Reset();
					}
				}
			}
			finally
			{
				AndroidJNI.DetachCurrentThread();
			}
		});
		ADBDBCHNAEJ.Name = "HSAsyncThread";
		ADBDBCHNAEJ.Start();
	}

	public static NLPADEFLHIA FFKACBMBNNP()
	{
		if (GGOLOIHLJBM == null)
		{
			GGOLOIHLJBM = new NLPADEFLHIA();
		}
		return GGOLOIHLJBM;
	}

	public void GINHNILIDHL(string GMBNJCKNOBD, FGGOGJLHPHD IACLMEKOOJO)
	{
		if (FKFEHMMNBIK.ContainsKey(GMBNJCKNOBD))
		{
			FKFEHMMNBIK[GMBNJCKNOBD] = IACLMEKOOJO;
		}
		else
		{
			FKFEHMMNBIK.Add(GMBNJCKNOBD, IACLMEKOOJO);
		}
	}

	public void HOGHHPKJOKC(string CFHGJGEGFKC, string JMHBADGAFLN, string CNKJPAGKAMJ, object[] MIDCNFGAIFA)
	{
		NIADOHJDKCK.Enqueue(new GOBAKADFEOD(CFHGJGEGFKC, JMHBADGAFLN, CNKJPAGKAMJ, MIDCNFGAIFA));
		CDBOLMBPABD.Set();
	}

	public void BGONEKPEOJC()
	{
		ManualResetEvent manualResetEvent = new ManualResetEvent(false);
		NIADOHJDKCK.Enqueue(new GOBAKADFEOD(manualResetEvent));
		CDBOLMBPABD.Set();
		manualResetEvent.WaitOne();
	}

	public void BDDICPKMJIL(GOBAKADFEOD IFGJAIKEFDO)
	{
		if (IFGJAIKEFDO.BDMLFCLBHIK != null)
		{
			IFGJAIKEFDO.BDMLFCLBHIK.Set();
		}
		else
		{
			FKFEHMMNBIK[IFGJAIKEFDO.CFHGJGEGFKC].HDDMNMIHBKC(IFGJAIKEFDO.JMHBADGAFLN, IFGJAIKEFDO.DFBFLINFFBE, IFGJAIKEFDO.MIDCNFGAIFA);
		}
	}

	public void MPFKABENODH()
	{
		MMCCBJNBGNL = true;
		CDBOLMBPABD.Set();
		ADBDBCHNAEJ.Join();
	}

	[CompilerGenerated]
	private void PGNCJFJNDMF()
	{
		try
		{
			AndroidJNI.AttachCurrentThread();
			while (!MMCCBJNBGNL)
			{
				while (!MMCCBJNBGNL && NIADOHJDKCK.Count > 0)
				{
					GOBAKADFEOD gOBAKADFEOD = NIADOHJDKCK.Dequeue();
					try
					{
						BDDICPKMJIL(gOBAKADFEOD);
					}
					catch (Exception ex)
					{
						Debug.Log("Error in : " + gOBAKADFEOD.DFBFLINFFBE + ". Exception : " + ex.Message + ex.StackTrace);
					}
				}
				if (!MMCCBJNBGNL)
				{
					CDBOLMBPABD.WaitOne();
					CDBOLMBPABD.Reset();
				}
			}
		}
		finally
		{
			AndroidJNI.DetachCurrentThread();
		}
	}
}
