using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Assets.Scripts.PeakAB.Pocos;
using Assets.Scripts.Utils.Analytics;
using BestHTTP;
using UnityEngine;

public class DMEKKNGOCNH
{
	private static DMEKKNGOCNH IACLMEKOOJO;

	private readonly Uri DBBICAIJCIH;

	[CompilerGenerated]
	private static OnRequestFinishedDelegate JANLDOMIIEF;

	[CompilerGenerated]
	private static Dictionary<string, int> ANENBGOHBGM;

	public static DMEKKNGOCNH GABGKBAKHDP
	{
		get
		{
			if (IACLMEKOOJO == null)
			{
				IACLMEKOOJO = new DMEKKNGOCNH(PeakAnalytics.LOPFOEHECGB.GetAnalyticsUserId());
			}
			return IACLMEKOOJO;
		}
	}

	private DMEKKNGOCNH(string BDKFNEDHAOJ)
	{
		string text = "https://ab-api.peakgames.net/api/v1/?jsonrpc=2.0&method=AB.getTests&id=mcc2&params={%22api_key%22:%22425e90d872b14192808bd8e0b4487072%22,%22uid%22:%22" + BDKFNEDHAOJ + "%22}";
		DBBICAIJCIH = new Uri(text);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AbTesting, "User AB Testing Path is:{0}", text);
	}

	public void DJPPLNADDDA()
	{
		HTTPRequest hTTPRequest = new HTTPRequest(DBBICAIJCIH, HTTPMethods.Get, ILECOIMALOI);
		hTTPRequest.ConnectTimeout = TimeSpan.FromSeconds(5.0);
		hTTPRequest.Timeout = TimeSpan.FromSeconds(5.0);
		HTTPRequest hTTPRequest2 = hTTPRequest;
		hTTPRequest2.AddHeader("Accept", "application/json");
		hTTPRequest2.Send();
	}

	private static void ILECOIMALOI(HTTPRequest BNICBDDNEAB, HTTPResponse OMJOIIOONMO)
	{
		try
		{
			if (OMJOIIOONMO == null)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.AbTesting, "Can not download a/b tests due to {0}", BNICBDDNEAB.Exception);
			}
			else if (OMJOIIOONMO.StatusCode < 200 || OMJOIIOONMO.StatusCode >= 300)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.AbTesting, "Can not download a/b tests; response code: {0}", OMJOIIOONMO.StatusCode);
			}
			else
			{
				JJOGJLACGIL(JsonUtility.FromJson<ABTest>(OMJOIIOONMO.DataAsText));
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.AbTesting, "Can not parse a/b test due to {0}", ex.Message);
		}
	}

	private static void JJOGJLACGIL(ABTest OPPMOCCNLGE)
	{
		try
		{
			if (OPPMOCCNLGE == null || OPPMOCCNLGE.result == null)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AbTesting, "No ABTest Found! Is ABTest null?: {0}", OPPMOCCNLGE == null);
				return;
			}
			List<Result> list = new List<Result>();
			List<Result> result = OPPMOCCNLGE.result;
			int count = result.Count;
			int num = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1;
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AbTesting, "Consuming ABTests. Count: {0}", count);
			for (int i = 0; i < count; i++)
			{
				Result result2 = result[i];
				if (result2.OKLNLIMIKBP())
				{
					if (result2.ExecutionLevel > 0)
					{
						if (num < result2.ExecutionLevel)
						{
							GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AbTesting, "All conditions matched for ABTest: {0}, but waiting for level {1} win to progress", result2.abtest_name, result2.ExecutionLevel);
							list.Add(result2);
						}
						else
						{
							GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AbTesting, "Already passed execution level, will not process ABTest: {0}", result2.abtest_name);
						}
					}
					else if (result2.variant != null)
					{
						GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AbTesting, "All conditions matched for ABTest: {0}", result2.abtest_name);
						BGFCMOEINKN(result2.test_types, result2.variant, result2.abtest_name);
					}
				}
				else
				{
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AbTesting, "Not all conditions are met for ABTest: {0}", result2.abtest_name);
				}
			}
			if (list.Count > 0)
			{
				NEEMFKAPFKB(list);
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.AbTesting, "Can not consume ABTest: {0}", ex);
		}
	}

	private static void NEEMFKAPFKB(List<Result> IMAMEFOKGFM)
	{
		try
		{
			using (MemoryStream memoryStream = new MemoryStream())
			{
				new BinaryFormatter().Serialize(memoryStream, IMAMEFOKGFM);
				HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("KeyAB_WaitingABList", Convert.ToBase64String(memoryStream.ToArray()));
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.AbTesting, "Error updating waiting AB list. Error:{0} Stack:{1}", ex.Message, ex.StackTrace);
		}
	}

	public static void HJFAFDBCEMN()
	{
		HJBLKNBHMFJ hJBLKNBHMFJ = HJBLKNBHMFJ.GABGKBAKHDP;
		try
		{
			string text = hJBLKNBHMFJ.LIANKDMAHFM("KeyAB_WaitingABList");
			if (text == null)
			{
				return;
			}
			List<Result> list = new List<Result>();
			byte[] buffer = Convert.FromBase64String(text);
			using (MemoryStream memoryStream = new MemoryStream(buffer))
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				memoryStream.Seek(0L, SeekOrigin.Begin);
				list = (List<Result>)binaryFormatter.Deserialize(memoryStream);
			}
			int count = list.Count;
			if (count == 0)
			{
				return;
			}
			for (int num = count - 1; num >= 0; num--)
			{
				Result result = list[num];
				if (result.ExecutionLevel == MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC())
				{
					BGFCMOEINKN(result.test_types, result.variant, result.abtest_name);
					list.RemoveAt(num);
				}
			}
			if (list.Count == 0)
			{
				HJBLKNBHMFJ.GABGKBAKHDP.MFKBEDNLCJA("KeyAB_WaitingABList");
			}
			else if (count > list.Count)
			{
				NEEMFKAPFKB(list);
			}
		}
		catch (Exception ex)
		{
			hJBLKNBHMFJ.KFCIOFNMKDA("KeyAB_WaitingABList");
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.AbTesting, "Error processing waiting AB list. Error:{0} Stack:{1}", ex.Message, ex.StackTrace);
		}
	}

	public static string MIJKFDGGPKL(string BGLDADAIENO)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(BGLDADAIENO);
		return Convert.ToBase64String(bytes);
	}

	private static void BGFCMOEINKN(List<string> FIHGHGGDCAL, Variant HOHDPCLDPEP, string DEDAPOCMOJG)
	{
		if (FIHGHGGDCAL == null)
		{
			return;
		}
		string text = FIHGHGGDCAL[0].Trim().ToLowerInvariant();
		string file_url = HOHDPCLDPEP.file_url;
		int num = file_url.LastIndexOf("/");
		if (num < 0)
		{
			return;
		}
		string text2 = "ab_" + MIJKFDGGPKL(text + file_url.Substring(0));
		if (MKINMKEMBPL.GABGKBAKHDP.GOAAKODJMPI(text2))
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AbTesting, "PeakAB > {0} is already consumed.", DEDAPOCMOJG);
			return;
		}
		AFJPGLHKOID.CPIGOAGGLBM("ABTestEnter", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), DEDAPOCMOJG, HOHDPCLDPEP.variant_id.ToString());
		EKGLBJJKNBG.GABGKBAKHDP.FMAFNNNJEGI(DEDAPOCMOJG);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AbTesting, "Process variant: test name:{0}  type:{1}", DEDAPOCMOJG, text);
		switch (text)
		{
		case "level":
			new PELGLCFFOHN(HOHDPCLDPEP).GMEJEIGMHOG(text2);
			return;
		case "social":
			new IIEKHGNOIHF(HOHDPCLDPEP).GMEJEIGMHOG(text2);
			return;
		case "buy_coins":
			new CBILMNJENGL(HOHDPCLDPEP).GMEJEIGMHOG(text2);
			return;
		case "level_move":
			new HBNLMOMDICA(HOHDPCLDPEP).GMEJEIGMHOG(text2);
			return;
		case "event":
			new HKDCHFCDBFK(HOHDPCLDPEP).GMEJEIGMHOG(text2);
			return;
		case "map":
			new NJLFPDDNHLO(HOHDPCLDPEP).GMEJEIGMHOG(text2);
			return;
		case "game_play":
			new OJOAIALDDPJ(HOHDPCLDPEP).GMEJEIGMHOG(text2);
			return;
		}
		GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.AbTesting, "Cannot process AB name:{0}  type:{1}", DEDAPOCMOJG, text);
	}
}
