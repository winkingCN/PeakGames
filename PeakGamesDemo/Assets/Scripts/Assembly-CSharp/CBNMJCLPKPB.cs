using System;
using System.Collections.Generic;
using Fabric.Answers;
using UnityEngine;

public static class CBNMJCLPKPB
{
	private static bool DEJMIFPOIAP;

	private static float KALMPLAGDJJ;

	private static int HHHLOCPFMLM;

	private static int JKPMGCHDMMC;

	private static int DOODDHHBDOP;

	public static readonly Uri FKCGDKKHKCL = new Uri("https://service.toonblast.net/");

	public static readonly Uri PMDCAHHPDGE = new Uri("https://service-cloudfront.toonblast.net/");

	public static readonly Uri PGOMEKOCFFM = new Uri("https://service.toonblast.net/");

	private static readonly Uri BEPFGNKJCIG = new Uri(string.Concat(FKCGDKKHKCL, "command"));

	private static readonly Uri PDODGBBKBEA = new Uri(string.Concat(FKCGDKKHKCL, "lcommand"));

	private static readonly Uri JKCBPIMHBDF = new Uri(string.Concat(PMDCAHHPDGE, "command"));

	private static readonly Uri CDLFNDMEBCF = new Uri(string.Concat(PMDCAHHPDGE, "lcommand"));

	public static readonly Uri PNKLFIOCOCB = new Uri(string.Concat(FKCGDKKHKCL, "sales"));

	public static readonly Uri OCFMGFNKMMA = new Uri(string.Concat(FKCGDKKHKCL, "badwords"));

	public static bool OAIOGNLPGED
	{
		get
		{
			if (KALMPLAGDJJ <= 0f || Time.realtimeSinceStartup - KALMPLAGDJJ > 120f)
			{
				KALMPLAGDJJ = Time.realtimeSinceStartup;
				if (!DEJMIFPOIAP)
				{
					DEJMIFPOIAP = true;
				}
				else if (HHHLOCPFMLM < -4)
				{
					DEJMIFPOIAP = false;
				}
				Answers.LogCustom("BackendMetrics", new Dictionary<string, object>
				{
					{ "TotalResponseCount", JKPMGCHDMMC },
					{ "ResponseControlCount", HHHLOCPFMLM },
					{
						"ResponseConsecutiveFailCount",
						DOODDHHBDOP.ToString()
					},
					{
						"IsBackendResponsive",
						DEJMIFPOIAP.ToString()
					}
				});
				JKPMGCHDMMC = 0;
				HHHLOCPFMLM = 0;
				return DEJMIFPOIAP;
			}
			return DEJMIFPOIAP;
		}
	}

	public static Uri IFELMHEFNII(int AAKHAPBEGDO, bool PCKLKLJCKCD)
	{
		if (PCKLKLJCKCD)
		{
			return (AAKHAPBEGDO <= 11) ? JKCBPIMHBDF : CDLFNDMEBCF;
		}
		if (DOODDHHBDOP < 5)
		{
			return (AAKHAPBEGDO <= 11) ? BEPFGNKJCIG : PDODGBBKBEA;
		}
		DOODDHHBDOP = 0;
		return (AAKHAPBEGDO <= 11) ? JKCBPIMHBDF : CDLFNDMEBCF;
	}

	public static void HOPBPAIJNNH(Uri JGCMKEGFFCB, bool OGAEECANDHB)
	{
		JKPMGCHDMMC++;
		if (OGAEECANDHB)
		{
			DOODDHHBDOP = 0;
			HHHLOCPFMLM++;
		}
		else
		{
			DOODDHHBDOP++;
			HHHLOCPFMLM--;
		}
		if (JGCMKEGFFCB.IsBaseOf(JKCBPIMHBDF))
		{
			AFJPGLHKOID.LNAGBLOFBIN(OGAEECANDHB);
		}
	}
}
