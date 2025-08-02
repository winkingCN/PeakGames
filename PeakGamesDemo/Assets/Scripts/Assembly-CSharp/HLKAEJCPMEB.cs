using System;
using System.IO;
using System.Runtime.CompilerServices;
using BestHTTP;
using UnityEngine;

public static class HLKAEJCPMEB
{
	public const string DOJMEGCPOCJ = "NewMap";

	public const string HABHPCMGLPH = "NewMapGame";

	private const string IILHMKPPKCK = "1";

	private const string GLAHMHDAFFG = "http://toon-assets.akamaized.net/production/";

	private const string EHLJHPHBJNG = "maps/";

	private const string PNJDBOPOCPM = ".jpeg";

	private static string IPLKCKDCBOE;

	[CompilerGenerated]
	private static OnRequestFinishedDelegate EBCOMJBLIPP;

	public static string OJOMNKNIAGI
	{
		get
		{
			return PlayerPrefs.GetString(ECHPAAONILO, "1");
		}
	}

	private static string EFDFAOBHKGC
	{
		get
		{
			return PlayerPrefs.GetString("BackgroundDownloadUrl", "http://toon-assets.akamaized.net/production/");
		}
	}

	private static string ECHPAAONILO
	{
		get
		{
			return LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM + 58 + "LastBackgroundId";
		}
	}

	private static string JPFGHFCPJFF
	{
		get
		{
			if (IPLKCKDCBOE != null)
			{
				return IPLKCKDCBOE;
			}
			string text = ((!MCJHHDACJBG.MCPELNPBPIF || MCJHHDACJBG.OCLBKDOFADM) ? "file://" : string.Empty);
			IPLKCKDCBOE = text + Application.streamingAssetsPath;
			return IPLKCKDCBOE;
		}
	}

	public static string JDALCCECHEE(string CHHHPCOIFJJ, string NBFBPNNEKMN)
	{
		string text = CHHHPCOIFJJ.PadLeft(3, '0');
		return NBFBPNNEKMN + text + ".jpeg";
	}

	public static string JJLECKMNALI(string CHHHPCOIFJJ, string NBFBPNNEKMN)
	{
		if (CHHHPCOIFJJ != OJOMNKNIAGI)
		{
			return POHJBJEGMFE(OJOMNKNIAGI, NBFBPNNEKMN);
		}
		GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Download, "Requested default background id is the same value with client already has ({0})!", CHHHPCOIFJJ);
		GMOGKFBMHMK("1");
		return POHJBJEGMFE("1", NBFBPNNEKMN);
	}

	public static string POHJBJEGMFE(string CHHHPCOIFJJ, string NBFBPNNEKMN)
	{
		string text = JDALCCECHEE(CHHHPCOIFJJ, NBFBPNNEKMN);
		string text2 = Path.Combine(JPFGHFCPJFF, "maps/" + text);
		if (JMFBBJHFMIM.GABGKBAKHDP.FGEFBNBMOOE(text))
		{
			text2 = "file://" + JMFBBJHFMIM.GABGKBAKHDP.BGCJPEAMBIP(text);
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Requested background ({0}) path is {1}", CHHHPCOIFJJ, text2);
		return text2;
	}

	public static string CAHJPAECDMJ(string GNBGNEDNJIE, string DFCJKBHFPMG, bool FHFHAIGLEJE)
	{
		if (FHFHAIGLEJE)
		{
			return Path.Combine(Application.streamingAssetsPath, "maps/" + GNBGNEDNJIE);
		}
		string[] array = GNBGNEDNJIE.Split('.');
		string path = string.Format("{0}_v{1}.{2}", array[0], DFCJKBHFPMG, array[1]);
		return Path.Combine(EFDFAOBHKGC, path);
	}

	public static void GMOGKFBMHMK(string CHHHPCOIFJJ)
	{
		PlayerPrefs.SetString(ECHPAAONILO, CHHHPCOIFJJ);
	}

	public static void IIABCIBMHJL()
	{
		HTTPRequest hTTPRequest = new HTTPRequest(new Uri(string.Concat(CBNMJCLPKPB.FKCGDKKHKCL, "mapurl")));
		hTTPRequest.Callback = delegate(HTTPRequest AGIGLGCIOOM, HTTPResponse OMJOIIOONMO)
		{
			if (!OMJOIIOONMO.IsSuccess)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Download, "Couldn't get Background download url. status code: {0}", OMJOIIOONMO.StatusCode);
			}
			else
			{
				string dataAsText = OMJOIIOONMO.DataAsText;
				if (!string.IsNullOrEmpty(dataAsText) && dataAsText.StartsWith("http"))
				{
					PlayerPrefs.SetString("BackgroundDownloadUrl", OMJOIIOONMO.DataAsText);
				}
				else
				{
					GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Download, "Couldn't get Background download url. Data is not a valid url: {0}", dataAsText);
				}
			}
		};
		HTTPRequest hTTPRequest2 = hTTPRequest;
		hTTPRequest2.Send();
	}

	[CompilerGenerated]
	private static void HAOANLPHJIB(HTTPRequest AGIGLGCIOOM, HTTPResponse OMJOIIOONMO)
	{
		if (!OMJOIIOONMO.IsSuccess)
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Download, "Couldn't get Background download url. status code: {0}", OMJOIIOONMO.StatusCode);
			return;
		}
		string dataAsText = OMJOIIOONMO.DataAsText;
		if (!string.IsNullOrEmpty(dataAsText) && dataAsText.StartsWith("http"))
		{
			PlayerPrefs.SetString("BackgroundDownloadUrl", OMJOIIOONMO.DataAsText);
			return;
		}
		GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Download, "Couldn't get Background download url. Data is not a valid url: {0}", dataAsText);
	}
}
