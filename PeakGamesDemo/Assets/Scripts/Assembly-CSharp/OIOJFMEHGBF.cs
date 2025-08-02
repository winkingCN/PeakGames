using System.Collections.Generic;

public class OIOJFMEHGBF : global::JEDMENFBGJI<NDDNNJHMMDC>
{
	private static OIOJFMEHGBF KNPOFJNFLJB;

	public static OIOJFMEHGBF GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new OIOJFMEHGBF();
			}
			return KNPOFJNFLJB;
		}
	}

	private OIOJFMEHGBF()
	{
	}

	public void PKIMELKEMAN()
	{
		string nGKFCKIHIPE = string.Format("Update {0} set synced = 1 where synced=0;", CMDKIHPAGPL());
		OMBKLCBCMGP(nGKFCKIHIPE);
	}

	public bool EFPJIIBFLJI()
	{
		string nGKFCKIHIPE = string.Format("select * from {0} where synced = 0 limit 1", CMDKIHPAGPL());
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(nGKFCKIHIPE);
		return mBBJJJGFIKD != null && mBBJJJGFIKD.DFOGCCJCNJJ.Count > 0;
	}

	public int CPPJMCBINBE(NAAHKHPBAPA NBFBPNNEKMN)
	{
		string nGKFCKIHIPE = string.Format("select amount from {0} where itemId={1}", CMDKIHPAGPL(), (int)NBFBPNNEKMN);
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(nGKFCKIHIPE);
		if (mBBJJJGFIKD != null && mBBJJJGFIKD.DFOGCCJCNJJ.Count > 0)
		{
			DCMNFAKJKCH dCMNFAKJKCH = mBBJJJGFIKD.DFOGCCJCNJJ[0];
			return (int)dCMNFAKJKCH.ECNCPJGHBIG("amount");
		}
		NDDNNJHMMDC lLIEHCKNJEM = new NDDNNJHMMDC(null, (int)NBFBPNNEKMN, 0, 0);
		FHIBIOKHLNE(lLIEHCKNJEM);
		return 0;
	}

	public NDDNNJHMMDC AOFOEFNCFIB(NAAHKHPBAPA NBFBPNNEKMN)
	{
		string nGKFCKIHIPE = string.Format("select * from {0} where itemId={1}", CMDKIHPAGPL(), (int)NBFBPNNEKMN);
		NDDNNJHMMDC nDDNNJHMMDC = PEFIHEFDOIE(nGKFCKIHIPE);
		if (nDDNNJHMMDC != null)
		{
			return nDDNNJHMMDC;
		}
		int nNIDKMJGAJO = 0;
		return new NDDNNJHMMDC(null, (int)NBFBPNNEKMN, nNIDKMJGAJO, 0);
	}

	protected override string CMDKIHPAGPL()
	{
		return "Inventory";
	}

	protected override object[] BMKKJMIKDPO(NDDNNJHMMDC LLIEHCKNJEM)
	{
		return new object[4]
		{
			LLIEHCKNJEM.AIAEHPLOFGB(),
			LLIEHCKNJEM.MAFKLHGEBPH,
			LLIEHCKNJEM.DIJPJDFKNCJ,
			LLIEHCKNJEM.FOJDLLGGJID
		};
	}

	protected override string MCPNNIHODDL()
	{
		return "CREATE TABLE IF NOT EXISTS `" + CMDKIHPAGPL() + "` (\n\t`id`\tINTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,\n\t`itemId`\tINTEGER NOT NULL,\n\t`amount`\tINTEGER NOT NULL,\n\t`synced`\tINTEGER NOT NULL\n);";
	}

	protected override Dictionary<string, object> FHIBIOKHLNE(NDDNNJHMMDC LLIEHCKNJEM)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary["itemId"] = LLIEHCKNJEM.MAFKLHGEBPH;
		dictionary["amount"] = LLIEHCKNJEM.DIJPJDFKNCJ;
		dictionary["synced"] = LLIEHCKNJEM.FOJDLLGGJID;
		return dictionary;
	}

	protected override NDDNNJHMMDC EOPGEOIHOAM(DCMNFAKJKCH BCAKHCNOKDH)
	{
		object value;
		BCAKHCNOKDH.TryGetValue("id", out value);
		object value2;
		BCAKHCNOKDH.TryGetValue("itemId", out value2);
		object value3;
		BCAKHCNOKDH.TryGetValue("amount", out value3);
		object value4;
		BCAKHCNOKDH.TryGetValue("synced", out value4);
		return new NDDNNJHMMDC((int)value, (int)value2, (int)value3, (int)value4);
	}

	public bool JDIDFELJKCH(NAAHKHPBAPA NBFBPNNEKMN)
	{
		string nGKFCKIHIPE = string.Format("select * from {0} where itemId={1}", CMDKIHPAGPL(), (int)NBFBPNNEKMN);
		NDDNNJHMMDC nDDNNJHMMDC = PEFIHEFDOIE(nGKFCKIHIPE);
		return nDDNNJHMMDC != null;
	}

	public void HDAJHDLAOME(NAAHKHPBAPA NBFBPNNEKMN)
	{
		string nGKFCKIHIPE = string.Format("delete from {0} where itemId={1}", CMDKIHPAGPL(), (int)NBFBPNNEKMN);
		ODIPOJCEPEJ(nGKFCKIHIPE);
	}
}
