using System.Collections.Generic;

public class FMKNBJCOMGF
{
	public static string IKIHDNHNJMH = "adid";

	public static string LIDJAANKHHG = "message";

	public static string ICEALDCHDDP = "network";

	public static string LMMHMOKHGHC = "adgroup";

	public static string LAAJOJGGLBP = "campaign";

	public static string HNEOICBLBNP = "creative";

	public static string KAMLHHLKLFA = "willRetry";

	public static string NMCEFJHKBMH = "timestamp";

	public static string IEGLOEAAAKC = "eventToken";

	public static string JEGJCNKCDKF = "clickLabel";

	public static string JNAJIAIFPFO = "trackerName";

	public static string CKIGHBBPIBO = "trackerToken";

	public static string GLHPCCFHMGA = "jsonResponse";

	public static int ILGEPBCLBLC(OCINAFLCMOD? PDGNEDBOGLE)
	{
		if (!PDGNEDBOGLE.HasValue)
		{
			return -1;
		}
		return (int)PDGNEDBOGLE.Value;
	}

	public static int NAOOEMKEGAF(bool? EDDNOJDPMCF)
	{
		if (!EDDNOJDPMCF.HasValue)
		{
			return -1;
		}
		if (EDDNOJDPMCF.Value)
		{
			return 1;
		}
		return 0;
	}

	public static double MFDFJLMLOBM(double? EDDNOJDPMCF)
	{
		if (!EDDNOJDPMCF.HasValue)
		{
			return -1.0;
		}
		return EDDNOJDPMCF.Value;
	}

	public static long JHFGHJAEAJH(long? EDDNOJDPMCF)
	{
		if (!EDDNOJDPMCF.HasValue)
		{
			return -1L;
		}
		return EDDNOJDPMCF.Value;
	}

	public static string IFIDNNFOKMP(List<string> PNKBIONHGEJ)
	{
		if (PNKBIONHGEJ == null)
		{
			return null;
		}
		OMOOJCDPFEL oMOOJCDPFEL = new OMOOJCDPFEL();
		foreach (string item in PNKBIONHGEJ)
		{
			oMOOJCDPFEL.JEACJNAKLDJ(new EOMIKBDENCM(item));
		}
		return oMOOJCDPFEL.ToString();
	}

	public static string DPJGPBJKFJA(Dictionary<string, object> EAPGOBAJLJE)
	{
		string empty = string.Empty;
		if (EAPGOBAJLJE == null)
		{
			return empty;
		}
		int num = 0;
		empty += "{";
		foreach (KeyValuePair<string, object> item in EAPGOBAJLJE)
		{
			string text = item.Value as string;
			if (text != null)
			{
				if (++num > 1)
				{
					empty += ",";
				}
				string text2 = empty;
				empty = text2 + "\"" + item.Key + "\":\"" + text + "\"";
			}
			else
			{
				Dictionary<string, object> eAPGOBAJLJE = item.Value as Dictionary<string, object>;
				if (++num > 1)
				{
					empty += ",";
				}
				empty = empty + "\"" + item.Key + "\":";
				empty += DPJGPBJKFJA(eAPGOBAJLJE);
			}
		}
		return empty + "}";
	}

	public static string FNFGIMGMIEM(DPKJGBCDECA EGBLCIPMDNG, string IKNCPEPOKGJ)
	{
		if (DPKJGBCDECA.OCAFFLHPIMM(EGBLCIPMDNG, null))
		{
			return null;
		}
		EOMIKBDENCM eOMIKBDENCM = EGBLCIPMDNG.ECNCPJGHBIG(IKNCPEPOKGJ) as EOMIKBDENCM;
		if (DPKJGBCDECA.OCAFFLHPIMM(eOMIKBDENCM, null))
		{
			return null;
		}
		return eOMIKBDENCM.JBGOANMLBFA;
	}

	public static void LMHFPJICNLH(ICCEIIKBABF NMFKGJMADEK, Dictionary<string, object> BILGCJNPJGJ)
	{
		foreach (KeyValuePair<string, DPKJGBCDECA> item in NMFKGJMADEK)
		{
			ICCEIIKBABF iCCEIIKBABF = item.Value.JPIHKOGIKHA;
			string key = item.Key;
			if (DPKJGBCDECA.OCAFFLHPIMM(iCCEIIKBABF, null))
			{
				string value = item.Value.JBGOANMLBFA;
				BILGCJNPJGJ.Add(key, value);
			}
			else
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				BILGCJNPJGJ.Add(key, dictionary);
				LMHFPJICNLH(iCCEIIKBABF, dictionary);
			}
		}
	}

	public static string NMLBPNNMFLP(Dictionary<string, string> ELNCCDELMMH, string IKNCPEPOKGJ)
	{
		string value;
		if (ELNCCDELMMH.TryGetValue(IKNCPEPOKGJ, out value))
		{
			return value;
		}
		return null;
	}
}
