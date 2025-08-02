using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using BestHTTP;
using ProtoBuf;
using UnityEngine;
using caravan.protobuf.messages;

public static class BOKGFGFPOHD
{
	public static IBGBAKAEEKI[] MFINHHGLMNF = new IBGBAKAEEKI[5]
	{
		new IBGBAKAEEKI(100, 1),
		new IBGBAKAEEKI(200, 1),
		new IBGBAKAEEKI(300, 1),
		new IBGBAKAEEKI(400, 1),
		new IBGBAKAEEKI(500, 1)
	};

	public static IBGBAKAEEKI MJFNFFIFHIL = new IBGBAKAEEKI(100, 1);

	public static IBGBAKAEEKI LJLBPNDBOAI = new IBGBAKAEEKI(100, 5);

	public static readonly string[] IOBAEOBIKNC = new string[27]
	{
		"net.peakgames.toonblast.2", "net.peakgames.toonblast.5", "net.peakgames.toonblast.8", "net.peakgames.toonblast.10", "net.peakgames.toonblast.15", "net.peakgames.toonblast.20", "net.peakgames.toonblast.25", "net.peakgames.toonblast.30", "net.peakgames.toonblast.40", "net.peakgames.toonblast.55",
		"net.peakgames.toonblast.80", "net.peakgames.toonblast.bundle2", "net.peakgames.toonblast.bundle7", "net.peakgames.toonblast.bundle13", "net.peakgames.toonblast.bundle25", "net.peakgames.toonblast.bundle50", "net.peakgames.toonblast.bundle100", "net.peakgames.toonblast.bpack4", "net.peakgames.toonblast.bpack10", "net.peakgames.toonblast.bpack20",
		"net.peakgames.toonblast.bpack30", "net.peakgames.toonblast.bpack50", "net.peakgames.toonblast.cpack4", "net.peakgames.toonblast.cpack10", "net.peakgames.toonblast.cpack20", "net.peakgames.toonblast.cpack40", "net.peakgames.toonblast.cpack80"
	};

	private static int? GCMCKGFMKJE;

	public static readonly KHMIKAEKHIG[] PHJEJCEPNPM = new KHMIKAEKHIG[6]
	{
		new KHMIKAEKHIG("net.peakgames.toonblast.2", 150, 0, 1),
		new KHMIKAEKHIG("net.peakgames.toonblast.5", 500, 0, 2),
		new KHMIKAEKHIG("net.peakgames.toonblast.10", 1000, 0, 3),
		new KHMIKAEKHIG("net.peakgames.toonblast.20", 2000, 0, 4),
		new KHMIKAEKHIG("net.peakgames.toonblast.40", 4000, 0, 5),
		new KHMIKAEKHIG("net.peakgames.toonblast.80", 8000, 0, 6)
	};

	public static readonly KHMIKAEKHIG[] JICNIKEDCGM = new KHMIKAEKHIG[6]
	{
		new KHMIKAEKHIG("net.peakgames.toonblast.2", 100, 0, 1),
		new KHMIKAEKHIG("net.peakgames.toonblast.8", 500, 0, 2),
		new KHMIKAEKHIG("net.peakgames.toonblast.15", 1000, 0, 3),
		new KHMIKAEKHIG("net.peakgames.toonblast.25", 2000, 0, 4),
		new KHMIKAEKHIG("net.peakgames.toonblast.40", 4000, 0, 5),
		new KHMIKAEKHIG("net.peakgames.toonblast.80", 8000, 0, 6)
	};

	public static readonly KHMIKAEKHIG[] HKMGKMGBEOJ = new KHMIKAEKHIG[6]
	{
		new KHMIKAEKHIG("net.peakgames.toonblast.2", 100, 0, 1),
		new KHMIKAEKHIG("net.peakgames.toonblast.8", 500, 0, 2),
		new KHMIKAEKHIG("net.peakgames.toonblast.15", 1000, 0, 3),
		new KHMIKAEKHIG("net.peakgames.toonblast.30", 2500, 0, 4),
		new KHMIKAEKHIG("net.peakgames.toonblast.55", 5000, 0, 5),
		new KHMIKAEKHIG("net.peakgames.toonblast.80", 10000, 0, 6)
	};

	public static readonly PMCGNIAAMND[] GKIAPGECDFH = new PMCGNIAAMND[6]
	{
		new PMCGNIAAMND("net.peakgames.toonblast.bundle2", 1, 200, 1, 0, "<size=78%>$</size> 1.99", PMCGNIAAMND.CJMEIJFAHLA.Sale),
		new PMCGNIAAMND("net.peakgames.toonblast.bundle7", 2, 500, 1, 0, "<size=78%>$</size> 6.99", PMCGNIAAMND.CJMEIJFAHLA.None),
		new PMCGNIAAMND("net.peakgames.toonblast.bundle13", 3, 1000, 3, 0, "<size=78%>$</size> 12.99", PMCGNIAAMND.CJMEIJFAHLA.MostPopular),
		new PMCGNIAAMND("net.peakgames.toonblast.bundle25", 4, 2000, 5, 6, "<size=78%>$</size> 24.99", PMCGNIAAMND.CJMEIJFAHLA.None),
		new PMCGNIAAMND("net.peakgames.toonblast.bundle50", 5, 4000, 12, 12, "<size=78%>$</size> 49.99", PMCGNIAAMND.CJMEIJFAHLA.None),
		new PMCGNIAAMND("net.peakgames.toonblast.bundle100", 6, 8000, 25, 24, "<size=78%>$</size> 99.99", PMCGNIAAMND.CJMEIJFAHLA.Best)
	};

	public static readonly PMCGNIAAMND[] EAJABILJANF = new PMCGNIAAMND[6]
	{
		new PMCGNIAAMND("net.peakgames.toonblast.bpack4", 1, 100, 1, 0, "<size=78%>$</size> 3.99", PMCGNIAAMND.CJMEIJFAHLA.Sale),
		new PMCGNIAAMND("net.peakgames.toonblast.bpack10", 2, 500, 1, 0, "<size=78%>$</size> 9.99", PMCGNIAAMND.CJMEIJFAHLA.None),
		new PMCGNIAAMND("net.peakgames.toonblast.bpack20", 3, 1000, 3, 0, "<size=78%>$</size> 19.99", PMCGNIAAMND.CJMEIJFAHLA.MostPopular),
		new PMCGNIAAMND("net.peakgames.toonblast.bpack30", 4, 2000, 5, 6, "<size=78%>$</size> 29.99", PMCGNIAAMND.CJMEIJFAHLA.None),
		new PMCGNIAAMND("net.peakgames.toonblast.bpack50", 5, 4000, 12, 12, "<size=78%>$</size> 49.99", PMCGNIAAMND.CJMEIJFAHLA.None),
		new PMCGNIAAMND("net.peakgames.toonblast.bundle100", 6, 8000, 25, 24, "<size=78%>$</size> 99.99", PMCGNIAAMND.CJMEIJFAHLA.Best)
	};

	public static readonly PMCGNIAAMND[] PMOIPEGCNPJ = new PMCGNIAAMND[6]
	{
		new PMCGNIAAMND("net.peakgames.toonblast.cpack4", 1, 100, 1, 0, "<size=78%>$</size> 3.99", PMCGNIAAMND.CJMEIJFAHLA.Sale),
		new PMCGNIAAMND("net.peakgames.toonblast.cpack10", 2, 500, 1, 0, "<size=78%>$</size> 9.99", PMCGNIAAMND.CJMEIJFAHLA.None),
		new PMCGNIAAMND("net.peakgames.toonblast.cpack20", 3, 1000, 3, 0, "<size=78%>$</size> 19.99", PMCGNIAAMND.CJMEIJFAHLA.MostPopular),
		new PMCGNIAAMND("net.peakgames.toonblast.cpack40", 4, 2500, 5, 6, "<size=78%>$</size> 39.99", PMCGNIAAMND.CJMEIJFAHLA.None),
		new PMCGNIAAMND("net.peakgames.toonblast.cpack80", 5, 5000, 12, 12, "<size=78%>$</size> 79.99", PMCGNIAAMND.CJMEIJFAHLA.None),
		new PMCGNIAAMND("net.peakgames.toonblast.bundle100", 6, 10000, 25, 24, "<size=78%>$</size> 99.99", PMCGNIAAMND.CJMEIJFAHLA.Best)
	};

	public static readonly Dictionary<string, string> FAEIHDFPLFI = new Dictionary<string, string>
	{
		{ "net.peakgames.toonblast.2", "<size=78%>$</size> 1.99" },
		{ "net.peakgames.toonblast.5", "<size=78%>$</size> 4.99" },
		{ "net.peakgames.toonblast.8", "<size=78%>$</size> 7.99" },
		{ "net.peakgames.toonblast.10", "<size=78%>$</size> 9.99" },
		{ "net.peakgames.toonblast.15", "<size=78%>$</size> 14.99" },
		{ "net.peakgames.toonblast.20", "<size=78%>$</size> 19.99" },
		{ "net.peakgames.toonblast.25", "<size=78%>$</size> 24.99" },
		{ "net.peakgames.toonblast.30", "<size=78%>$</size> 29.99" },
		{ "net.peakgames.toonblast.40", "<size=78%>$</size> 39.99" },
		{ "net.peakgames.toonblast.55", "<size=78%>$</size> 54.99" },
		{ "net.peakgames.toonblast.80", "<size=78%>$</size> 79.99" },
		{ "net.peakgames.toonblast.bundle2", "<size=78%>$</size> 1.99" },
		{ "net.peakgames.toonblast.bundle7", "<size=78%>$</size> 6.99" },
		{ "net.peakgames.toonblast.bundle13", "<size=78%>$</size> 12.99" },
		{ "net.peakgames.toonblast.bundle25", "<size=78%>$</size> 24.99" },
		{ "net.peakgames.toonblast.bundle50", "<size=78%>$</size> 49.99" },
		{ "net.peakgames.toonblast.bundle100", "<size=78%>$</size> 99.99" },
		{ "net.peakgames.toonblast.bpack4", "<size=78%>$</size> 3.99" },
		{ "net.peakgames.toonblast.bpack10", "<size=78%>$</size> 9.99" },
		{ "net.peakgames.toonblast.bpack20", "<size=78%>$</size> 19.99" },
		{ "net.peakgames.toonblast.bpack30", "<size=78%>$</size> 29.99" },
		{ "net.peakgames.toonblast.bpack50", "<size=78%>$</size> 49.99" },
		{ "net.peakgames.toonblast.cpack4", "<size=78%>$</size> 3.99" },
		{ "net.peakgames.toonblast.cpack10", "<size=78%>$</size> 9.99" },
		{ "net.peakgames.toonblast.cpack20", "<size=78%>$</size> 19.99" },
		{ "net.peakgames.toonblast.cpack40", "<size=78%>$</size> 39.99" },
		{ "net.peakgames.toonblast.cpack80", "<size=78%>$</size> 79.99" }
	};

	public static IBGBAKAEEKI LNMEOGMFLNP = new IBGBAKAEEKI(200, 3);

	public static IBGBAKAEEKI CJDPGEFFEEK = new IBGBAKAEEKI(200, 3);

	public static IBGBAKAEEKI HKCNGEGPEGP = new IBGBAKAEEKI(400, 3);

	public static IBGBAKAEEKI CICAMLNPEPI = new IBGBAKAEEKI(400, 3);

	public static IBGBAKAEEKI LHDLPOFAJJD = new IBGBAKAEEKI(100, 3);

	public static IBGBAKAEEKI NALDKFBNIJI = new IBGBAKAEEKI(150, 3);

	public static IBGBAKAEEKI MLOGCNKAGDM = new IBGBAKAEEKI(100, 1);

	public static IBGBAKAEEKI PBMKPCCPMAH = new IBGBAKAEEKI(100, 3);

	public static IBGBAKAEEKI BANABHFNGPJ = new IBGBAKAEEKI(10, 10);

	public static IBGBAKAEEKI NAPCGOIIFIM = new IBGBAKAEEKI(250, 3);

	public static IBGBAKAEEKI AKELGEHLLNC = new IBGBAKAEEKI(1, 1);

	public static IBGBAKAEEKI JNIADGLOLMP = new IBGBAKAEEKI(100, 1);

	public static IBGBAKAEEKI MFDPEOHIKKH = new IBGBAKAEEKI(100, 1);

	[CompilerGenerated]
	private static Dictionary<string, int> IKMEFHNEOFF;

	[CompilerGenerated]
	private static OnRequestFinishedDelegate JANLDOMIIEF;

	public static int AMEDMLOCCBG { get; private set; }

	private static int IKDOMAFIIBL
	{
		get
		{
			int? gCMCKGFMKJE = GCMCKGFMKJE;
			if (gCMCKGFMKJE.HasValue)
			{
				return GCMCKGFMKJE.Value;
			}
			EAGHHEMOFLE();
			return GCMCKGFMKJE.Value;
		}
	}

	public static KHMIKAEKHIG[] FNEABNFILKK
	{
		get
		{
			switch (IKDOMAFIIBL)
			{
			case 1:
				return PHJEJCEPNPM;
			case 2:
				return JICNIKEDCGM;
			case 3:
				return HKMGKMGBEOJ;
			default:
				return PHJEJCEPNPM;
			}
		}
	}

	public static PMCGNIAAMND[] NIAJFDLMNJH
	{
		get
		{
			switch (IKDOMAFIIBL)
			{
			case 1:
				return GKIAPGECDFH;
			case 2:
				return EAJABILJANF;
			case 3:
				return PMOIPEGCNPJ;
			default:
				return GKIAPGECDFH;
			}
		}
	}

	public static void OJCHABJIAGJ(RemoteSaleData MBBPBGHKLJM)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SalesData, "SalesData refreshing..");
		if (MBBPBGHKLJM.purchases != null)
		{
			foreach (RemotePurchase purchase in MBBPBGHKLJM.purchases)
			{
				switch (purchase.Name)
				{
				case "EgoPackage":
					MJFNFFIFHIL = new IBGBAKAEEKI(purchase.Amount, purchase.Count);
					break;
				case "Ego1":
					MFINHHGLMNF[0] = new IBGBAKAEEKI(purchase.Amount, purchase.Count);
					break;
				case "Ego2":
					MFINHHGLMNF[1] = new IBGBAKAEEKI(purchase.Amount, purchase.Count);
					break;
				case "Ego3":
					MFINHHGLMNF[2] = new IBGBAKAEEKI(purchase.Amount, purchase.Count);
					break;
				case "Ego4":
					MFINHHGLMNF[3] = new IBGBAKAEEKI(purchase.Amount, purchase.Count);
					break;
				case "Ego5":
					MFINHHGLMNF[4] = new IBGBAKAEEKI(purchase.Amount, purchase.Count);
					break;
				case "Life":
					LJLBPNDBOAI = new IBGBAKAEEKI(purchase.Amount, purchase.Count);
					break;
				case "Discoball":
					LNMEOGMFLNP = new IBGBAKAEEKI(purchase.Amount, purchase.Count);
					break;
				case "Hammer":
					CJDPGEFFEEK = new IBGBAKAEEKI(purchase.Amount, purchase.Count);
					break;
				case "BoxingGlove":
					HKCNGEGPEGP = new IBGBAKAEEKI(purchase.Amount, purchase.Count);
					break;
				case "Anvil":
					CICAMLNPEPI = new IBGBAKAEEKI(purchase.Amount, purchase.Count);
					break;
				case "Rocket":
					LHDLPOFAJJD = new IBGBAKAEEKI(purchase.Amount, purchase.Count);
					break;
				case "Bomb":
					NALDKFBNIJI = new IBGBAKAEEKI(purchase.Amount, purchase.Count);
					break;
				case "Shuffle":
					PBMKPCCPMAH = new IBGBAKAEEKI(purchase.Amount, purchase.Count);
					break;
				case "PaintBrush":
					BANABHFNGPJ = new IBGBAKAEEKI(purchase.Amount, purchase.Count);
					break;
				case "Others":
					NAPCGOIIFIM = new IBGBAKAEEKI(purchase.Amount, purchase.Count);
					break;
				case "SocialHelp":
					AKELGEHLLNC = new IBGBAKAEEKI(purchase.Amount, purchase.Count);
					break;
				case "TeamCreate":
					JNIADGLOLMP = new IBGBAKAEEKI(purchase.Amount, purchase.Count);
					break;
				case "TeamPrize":
					MFDPEOHIKKH = new IBGBAKAEEKI(purchase.Amount, purchase.Count);
					break;
				}
			}
		}
		AMEDMLOCCBG = MBBPBGHKLJM.version;
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SalesData, "SalesData refreshing done, version:" + AMEDMLOCCBG);
	}

	public static void EAGHHEMOFLE()
	{
		string s = EKGLBJJKNBG.GABGKBAKHDP.PGMJGDOBNGL("KeyAB_Bundle");
		int result;
		int.TryParse(s, out result);
		GCMCKGFMKJE = result;
	}

	public static IBGBAKAEEKI DNCLFKKHEPL(NAAHKHPBAPA HBBIFNLDKPO)
	{
		switch (HBBIFNLDKPO)
		{
		case NAAHKHPBAPA.DiscoBall:
			return LNMEOGMFLNP;
		case NAAHKHPBAPA.Hammer:
			return CJDPGEFFEEK;
		case NAAHKHPBAPA.BoxingGlove:
			return HKCNGEGPEGP;
		case NAAHKHPBAPA.Anvil:
			return CICAMLNPEPI;
		case NAAHKHPBAPA.Rocket:
			return LHDLPOFAJJD;
		case NAAHKHPBAPA.Bomb:
			return NALDKFBNIJI;
		case NAAHKHPBAPA.Extra5Moves:
			return MJFNFFIFHIL;
		case NAAHKHPBAPA.Dice:
			return PBMKPCCPMAH;
		case NAAHKHPBAPA.PaintBrush:
			return BANABHFNGPJ;
		default:
			return NAPCGOIIFIM;
		}
	}

	public static void KNJGDDBPMED()
	{
		HTTPRequest hTTPRequest = new HTTPRequest(CBNMJCLPKPB.PNKLFIOCOCB, HTTPMethods.Post, GEGEGICPLDA);
		hTTPRequest.ConnectTimeout = TimeSpan.FromSeconds(5.0);
		hTTPRequest.Timeout = TimeSpan.FromSeconds(5.0);
		HTTPRequest hTTPRequest2 = hTTPRequest;
		hTTPRequest2.AddHeader("Accept", "application/x-protobuf");
		hTTPRequest2.AddField("version", AMEDMLOCCBG.ToString());
		hTTPRequest2.Send();
	}

	private static void GEGEGICPLDA(HTTPRequest BNICBDDNEAB, HTTPResponse OMJOIIOONMO)
	{
		if (OMJOIIOONMO == null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SalesData, "SalesData can not be fetched; response is null.");
			ANGCNEFIIHE.GABGKBAKHDP.DIOELAHNLKJ();
			return;
		}
		int statusCode = OMJOIIOONMO.StatusCode;
		switch (statusCode)
		{
		case 204:
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SalesData, "SalesData seems same since last time.");
			break;
		case 200:
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SalesData, "SalesData has new content.");
			try
			{
				if (OMJOIIOONMO.Data == null)
				{
					throw new Exception("Backend return 200 without sales data!");
				}
				using (Stream source = new MemoryStream(OMJOIIOONMO.Data))
				{
					RemoteSaleData remoteSaleData = KIHMBFDKLJM.GABGKBAKHDP.BGGEDOONAPL.Deserialize(source, null, typeof(RemoteSaleData)) as RemoteSaleData;
					OJCHABJIAGJ(remoteSaleData);
					HBPEMGMFEIC(remoteSaleData);
				}
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Backend, "Can not parse sales data response: {0}.", ex.Message);
			}
			break;
		default:
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SalesData, "SalesData protocol problem, status code: {0}, {1}", statusCode, OMJOIIOONMO.Message);
			break;
		}
		ANGCNEFIIHE.GABGKBAKHDP.DIOELAHNLKJ();
	}

	public static void IGCBOOCJPGD()
	{
		string path = Application.persistentDataPath + "/sales.dat";
		if (!File.Exists(path))
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SalesData, "No persistent sales data found!");
			return;
		}
		using (FileStream source = new FileStream(path, FileMode.Open))
		{
			try
			{
				RemoteSaleData remoteSaleData = KIHMBFDKLJM.GABGKBAKHDP.BGGEDOONAPL.DeserializeWithLengthPrefix(source, null, typeof(RemoteSaleData), PrefixStyle.Fixed32BigEndian, 3) as RemoteSaleData;
				if (remoteSaleData != null)
				{
					OJCHABJIAGJ(remoteSaleData);
				}
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.SalesData, "Can not read sales data from file system: {0}", ex);
			}
		}
	}

	private static void HBPEMGMFEIC(RemoteSaleData HHMIOGBLPML)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SalesData, "Saving persistent sales data");
		using (FileStream dest = new FileStream(Application.persistentDataPath + "/sales.dat", FileMode.OpenOrCreate))
		{
			try
			{
				KIHMBFDKLJM.GABGKBAKHDP.BGGEDOONAPL.SerializeWithLengthPrefix(dest, HHMIOGBLPML, typeof(RemoteSaleData), PrefixStyle.Fixed32BigEndian, 3);
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.SalesData, "Can not write sales data from file system: {0}", ex);
			}
		}
	}
}
