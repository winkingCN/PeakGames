using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Assets.Scripts.CasualTools.Common.Logging.impl;
using UnityEngine;

internal class MJCGFFMHEDC : IDisposable
{
	[CompilerGenerated]
	private sealed class FOHAEACBPJB
	{
		internal NCHDGFIAHLI MJAHNNPOLHL;

		internal bool DIDHNNMKJFE;

		internal void AGFNGEFDHLA()
		{
			MJAHNNPOLHL(DIDHNNMKJFE, Application.persistentDataPath + "/peak.zip");
		}
	}

	private const int JCHEGOODNEG = 2097152;

	private readonly string GJJFJLEFLLK = "peak-archived.log";

	private readonly string HFLIPJLPEJB = "peak.zip";

	private readonly string ELLCNBPIJOH = "temp/";

	private readonly object KNJOLPIEHHA;

	private readonly string KFAAECODHIA = "peak.log";

	private readonly string NAIPDMKEGHG = "peak-logged.log";

	private bool CBIMHEGFHAM;

	private StreamWriter KGCCGOMDALD;

	public string CKDGIAHLCNJ
	{
		get
		{
			return HFLIPJLPEJB;
		}
	}

	public MJCGFFMHEDC(string LCCKDPIBKPJ)
	{
		KNJOLPIEHHA = new object();
		string text = LCCKDPIBKPJ + "/";
		KFAAECODHIA = text + KFAAECODHIA;
		ELLCNBPIJOH = text + ELLCNBPIJOH;
		NAIPDMKEGHG = ELLCNBPIJOH + NAIPDMKEGHG;
		GJJFJLEFLLK = ELLCNBPIJOH + GJJFJLEFLLK;
		HFLIPJLPEJB = text + HFLIPJLPEJB;
		new FileInfo(ELLCNBPIJOH).Directory.Create();
		try
		{
			lock (KNJOLPIEHHA)
			{
				KGCCGOMDALD = File.AppendText(KFAAECODHIA);
			}
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.LogError("Cannot create streamWriter : " + ex);
		}
	}

	public void Dispose()
	{
		if (KGCCGOMDALD != null)
		{
			KGCCGOMDALD.Flush();
			KGCCGOMDALD.Close();
		}
	}

	public void KBMOJGCCCEN(string OEFCOJLNCKP)
	{
		lock (KNJOLPIEHHA)
		{
			if (KGCCGOMDALD.BaseStream.Length >= 2097152 && !CBIMHEGFHAM)
			{
				LGJBBEFGCFE(GJJFJLEFLLK);
			}
			if (OEFCOJLNCKP != null && KGCCGOMDALD != null)
			{
				KGCCGOMDALD.WriteLine(OEFCOJLNCKP);
				KGCCGOMDALD.Flush();
			}
		}
	}

	public void GIOCEEGBFKL()
	{
		File.Delete(KFAAECODHIA);
		File.Delete(GJJFJLEFLLK);
	}

	public void LGJBBEFGCFE(string IPPHCKILFOA)
	{
		if (CBIMHEGFHAM)
		{
			return;
		}
		CBIMHEGFHAM = true;
		try
		{
			if (File.Exists(IPPHCKILFOA))
			{
				File.Delete(IPPHCKILFOA);
			}
			lock (KNJOLPIEHHA)
			{
				KGCCGOMDALD.Close();
				File.Move(KFAAECODHIA, IPPHCKILFOA);
				KGCCGOMDALD = new StreamWriter(KFAAECODHIA);
			}
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.LogError("Copy Working File Exception : " + ex);
		}
		CBIMHEGFHAM = false;
	}

	public void BACJEDDPKIJ(string IPPHCKILFOA)
	{
		if (CBIMHEGFHAM)
		{
			return;
		}
		CBIMHEGFHAM = true;
		try
		{
			lock (KNJOLPIEHHA)
			{
				File.Copy(KFAAECODHIA, IPPHCKILFOA, true);
			}
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.LogError("Copy Working File Exception : " + ex);
		}
		CBIMHEGFHAM = false;
	}

	internal static ThreadAdapter GOAMDDCPHKB()
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "Threaded Adapter";
		return gameObject.AddComponent<ThreadAdapter>();
	}

	public void LMFHLALOCMD(NCHDGFIAHLI MJAHNNPOLHL = null)
	{
		try
		{
			ThreadAdapter threadAdapter = ((MJAHNNPOLHL != null) ? GOAMDDCPHKB() : null);
			ThreadPool.QueueUserWorkItem(IIHHGNAACEG, new object[2] { threadAdapter, MJAHNNPOLHL });
		}
		catch (IOException ex)
		{
			UnityEngine.Debug.LogError("CANNOT ZIP FILES " + ex);
			if (MJAHNNPOLHL != null)
			{
				MJAHNNPOLHL(false, null);
			}
		}
	}

	private void IIHHGNAACEG(object BGEDKGLJIGM)
	{
		object[] array = (object[])BGEDKGLJIGM;
		NCHDGFIAHLI MJAHNNPOLHL = (NCHDGFIAHLI)array[1];
		BACJEDDPKIJ(NAIPDMKEGHG);
		bool DIDHNNMKJFE = EMPALCMOADM(ELLCNBPIJOH, HFLIPJLPEJB);
		if (MJAHNNPOLHL == null)
		{
			return;
		}
		ThreadAdapter threadAdapter = array[0] as ThreadAdapter;
		if (threadAdapter != null)
		{
			threadAdapter.ExecuteOnUi(delegate
			{
				MJAHNNPOLHL(DIDHNNMKJFE, Application.persistentDataPath + "/peak.zip");
			});
		}
	}

	private static bool EMPALCMOADM(string FBOLFJFDOCH, string OLHODFKJHCC)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		try
		{
			if (!Directory.Exists(FBOLFJFDOCH))
			{
				UnityEngine.Debug.Log("There is no folder at path: " + FBOLFJFDOCH);
				return false;
			}
			List<string> list = new List<string>();
			list.AddRange(Directory.GetFiles(FBOLFJFDOCH));
			switch (list.Count)
			{
			case 1:
				return 0 == ABMHGHAMFDH.KKHJEDMOLGM(list[0], OLHODFKJHCC, 6);
			case 2:
				return 0 == ABMHGHAMFDH.GPMLDMBFDIH(list[0], list[1], OLHODFKJHCC, 6);
			case 3:
				return 0 == ABMHGHAMFDH.DOFEDFMCGOG(list[0], list[1], list[2], OLHODFKJHCC, 6);
			default:
				return false;
			}
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.LogError("Can not compress:" + ex.Message);
			return false;
		}
		finally
		{
			stopwatch.Stop();
		}
	}
}
