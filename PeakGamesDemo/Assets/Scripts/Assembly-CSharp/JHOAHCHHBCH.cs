using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Utils.Analytics;
using BestHTTP;
using Fabric.Answers;
using UnityEngine;
using Utils;

public static class JHOAHCHHBCH
{
	[CompilerGenerated]
	private sealed class INLKLJJFAFE
	{
		internal Action<int> IMHLFAHONPP;

		internal void AGFNGEFDHLA(HTTPRequest MONIIALMCBH, HTTPResponse OMJOIIOONMO)
		{
			PGLBPGFDBJO.Stop();
			IMHLFAHONPP((int)PGLBPGFDBJO.ElapsedMilliseconds);
		}
	}

	private static readonly Uri KEABACKEKHG = new Uri("http://www.google.com");

	private const int LKOKKGJDMLH = 60;

	private static int OOGKNCBIHMK;

	private static float HDOHBHEHHPC;

	private static bool HBAIDFFLOFB;

	private static JsonPingData LEGDBOFPBGF;

	private static readonly int[] FCOGHAOPNEH = new int[6] { 10000, 10000, 10000, 10000, 10000, 10000 };

	private static readonly List<Action<JsonPingData>> FJIBCKCCHJO = new List<Action<JsonPingData>>();

	private static readonly Stopwatch PGLBPGFDBJO = new Stopwatch();

	[CompilerGenerated]
	private static Action<int> EBCOMJBLIPP;

	[CompilerGenerated]
	private static Action<int> DNBOPLHGMHA;

	public static int IGAHBMBJMAB { get; private set; }

	public static void NCOFPCABEMF()
	{
		if (!CCAJIIFJPFF())
		{
			return;
		}
		IGAHBMBJMAB = 0;
		HJGPJFCCAKJ(KEABACKEKHG, 0.5, delegate(int FPCNLOGHFCL)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.NetworkHelper, "Google ping time is {0} ms.", FPCNLOGHFCL);
			IGAHBMBJMAB = FPCNLOGHFCL;
			float num = 100f;
			if (FPCNLOGHFCL > 1000)
			{
				num = 1000f;
			}
			double num2 = Math.Floor((float)FPCNLOGHFCL / num) * (double)num;
			Answers.LogCustom("GooglePingTime", new Dictionary<string, object> { 
			{
				"GooglePingTime",
				num2.ToString()
			} });
		});
	}

	public static void DOEPBGGEEEH(Action<JsonPingData> IMHLFAHONPP)
	{
		if (Time.realtimeSinceStartup < HDOHBHEHHPC + 60f && LEGDBOFPBGF != null)
		{
			IMHLFAHONPP(LEGDBOFPBGF);
			return;
		}
		FJIBCKCCHJO.Add(IMHLFAHONPP);
		if (!HBAIDFFLOFB)
		{
			PGLBPGFDBJO.Reset();
			OOGKNCBIHMK = 0;
			HBAIDFFLOFB = true;
			MDHLECNKFHB();
		}
	}

	private static void BNIAFLHGNCE()
	{
		HDOHBHEHHPC = Time.realtimeSinceStartup;
		JsonPingData jsonPingData = new JsonPingData();
		jsonPingData.google = new JsonPingContent
		{
			result1 = FCOGHAOPNEH[0],
			result2 = FCOGHAOPNEH[1],
			result3 = FCOGHAOPNEH[2]
		};
		jsonPingData.toon = new JsonPingContent
		{
			result1 = FCOGHAOPNEH[3],
			result2 = FCOGHAOPNEH[4],
			result3 = FCOGHAOPNEH[5]
		};
		LEGDBOFPBGF = jsonPingData;
		if (FJIBCKCCHJO.Count <= 0)
		{
			return;
		}
		int count = FJIBCKCCHJO.Count;
		for (int i = 0; i < count; i++)
		{
			if (FJIBCKCCHJO[i] != null)
			{
				FJIBCKCCHJO[i](LEGDBOFPBGF);
			}
		}
		FJIBCKCCHJO.Clear();
		HBAIDFFLOFB = false;
	}

	private static void MDHLECNKFHB()
	{
		Uri cCMKBJDPCGF = ((OOGKNCBIHMK >= 3) ? CBNMJCLPKPB.FKCGDKKHKCL : KEABACKEKHG);
		HJGPJFCCAKJ(cCMKBJDPCGF, 5.0, delegate(int FPCNLOGHFCL)
		{
			if (OOGKNCBIHMK < FCOGHAOPNEH.Length)
			{
				FCOGHAOPNEH[OOGKNCBIHMK] = FPCNLOGHFCL;
			}
			OOGKNCBIHMK++;
			if (OOGKNCBIHMK < 6)
			{
				MDHLECNKFHB();
			}
			else
			{
				BNIAFLHGNCE();
			}
		});
	}

	private static void HJGPJFCCAKJ(Uri CCMKBJDPCGF, double AAKHAPBEGDO, Action<int> IMHLFAHONPP)
	{
		HTTPRequest hTTPRequest = new HTTPRequest(CCMKBJDPCGF, HTTPMethods.Head, false, true, delegate
		{
			PGLBPGFDBJO.Stop();
			IMHLFAHONPP((int)PGLBPGFDBJO.ElapsedMilliseconds);
		});
		hTTPRequest.Timeout = TimeSpan.FromSeconds(AAKHAPBEGDO);
		hTTPRequest.ConnectTimeout = TimeSpan.FromSeconds(AAKHAPBEGDO);
		HTTPRequest hTTPRequest2 = hTTPRequest;
		PGLBPGFDBJO.Reset();
		PGLBPGFDBJO.Start();
		hTTPRequest2.Send();
	}

	public static bool CCAJIIFJPFF()
	{
		return Application.internetReachability != NetworkReachability.NotReachable;
	}

	public static void KBKMIGBDDOC(GameObject NOENEIELBIJ, bool OEMIFJACAGF)
	{
		if (CCAJIIFJPFF())
		{
			FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(NOENEIELBIJ, OEMIFJACAGF);
		}
		else
		{
			FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.NoConnectionDialog, OEMIFJACAGF);
		}
	}

	[CompilerGenerated]
	private static void CANCHCPOEIN(int FPCNLOGHFCL)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.NetworkHelper, "Google ping time is {0} ms.", FPCNLOGHFCL);
		IGAHBMBJMAB = FPCNLOGHFCL;
		float num = 100f;
		if (FPCNLOGHFCL > 1000)
		{
			num = 1000f;
		}
		double num2 = Math.Floor((float)FPCNLOGHFCL / num) * (double)num;
		Answers.LogCustom("GooglePingTime", new Dictionary<string, object> { 
		{
			"GooglePingTime",
			num2.ToString()
		} });
	}

	[CompilerGenerated]
	private static void FDPGANCFIEH(int FPCNLOGHFCL)
	{
		if (OOGKNCBIHMK < FCOGHAOPNEH.Length)
		{
			FCOGHAOPNEH[OOGKNCBIHMK] = FPCNLOGHFCL;
		}
		OOGKNCBIHMK++;
		if (OOGKNCBIHMK < 6)
		{
			MDHLECNKFHB();
		}
		else
		{
			BNIAFLHGNCE();
		}
	}
}
