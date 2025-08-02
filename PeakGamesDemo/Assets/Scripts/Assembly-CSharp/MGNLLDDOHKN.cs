using System.Collections.Generic;

public class MGNLLDDOHKN : global::JEDMENFBGJI<ABFBFJOFLKO>
{
	private static MGNLLDDOHKN KNPOFJNFLJB;

	public static MGNLLDDOHKN GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new MGNLLDDOHKN();
			}
			return KNPOFJNFLJB;
		}
	}

	private MGNLLDDOHKN()
	{
	}

	public bool LDKAMIIEFMN(string IKNCPEPOKGJ)
	{
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(string.Format("select synced from {0} where pkey={1} and synced=0", CMDKIHPAGPL(), HCNJKKJJPFI(IKNCPEPOKGJ)));
		if (mBBJJJGFIKD == null || mBBJJJGFIKD.DFOGCCJCNJJ.Count == 0)
		{
			return true;
		}
		return false;
	}

	public string LIANKDMAHFM(string IKNCPEPOKGJ)
	{
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(string.Format("select pvalue from {0} where pkey={1}", CMDKIHPAGPL(), HCNJKKJJPFI(IKNCPEPOKGJ)));
		if (mBBJJJGFIKD == null || mBBJJJGFIKD.DFOGCCJCNJJ.Count == 0)
		{
			return null;
		}
		return (string)mBBJJJGFIKD.DFOGCCJCNJJ[0].ECNCPJGHBIG("pvalue");
	}

	public string LIANKDMAHFM(string IKNCPEPOKGJ, string DLJMKKALKBD, int POKMOKOPEKI = 0)
	{
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(string.Format("select pvalue from {0} where pkey={1}", CMDKIHPAGPL(), HCNJKKJJPFI(IKNCPEPOKGJ)));
		if (mBBJJJGFIKD == null || mBBJJJGFIKD.DFOGCCJCNJJ.Count == 0)
		{
			LFHHPPDJGDC(new ABFBFJOFLKO(null, IKNCPEPOKGJ, DLJMKKALKBD, POKMOKOPEKI));
			return DLJMKKALKBD;
		}
		return (string)mBBJJJGFIKD.DFOGCCJCNJJ[0].ECNCPJGHBIG("pvalue");
	}

	public void JGMDDMNGDJO(string IKNCPEPOKGJ, string EDDNOJDPMCF, int POKMOKOPEKI = 0)
	{
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(string.Format("select * from {0} where pkey={1}", CMDKIHPAGPL(), HCNJKKJJPFI(IKNCPEPOKGJ)));
		if (mBBJJJGFIKD == null || mBBJJJGFIKD.DFOGCCJCNJJ.Count == 0)
		{
			LFHHPPDJGDC(new ABFBFJOFLKO(null, IKNCPEPOKGJ, EDDNOJDPMCF, POKMOKOPEKI));
			return;
		}
		ABFBFJOFLKO aBFBFJOFLKO = EOPGEOIHOAM(mBBJJJGFIKD.DFOGCCJCNJJ[0]);
		aBFBFJOFLKO.PPKCBFFEDED = EDDNOJDPMCF;
		aBFBFJOFLKO.FOJDLLGGJID = POKMOKOPEKI;
		GDFHLDAKIOM(aBFBFJOFLKO);
	}

	public void MFKBEDNLCJA(string NDDKGBHCNBB)
	{
		ODIPOJCEPEJ(string.Format("delete from {0} where pkey={1}", CMDKIHPAGPL(), HCNJKKJJPFI(NDDKGBHCNBB)));
	}

	protected override string CMDKIHPAGPL()
	{
		return "simple_sync_properties";
	}

	protected override object[] BMKKJMIKDPO(ABFBFJOFLKO LLIEHCKNJEM)
	{
		return new object[4]
		{
			LLIEHCKNJEM.AIAEHPLOFGB(),
			LLIEHCKNJEM.CDEOGMLENPN,
			LLIEHCKNJEM.PPKCBFFEDED,
			LLIEHCKNJEM.FOJDLLGGJID
		};
	}

	protected override string MCPNNIHODDL()
	{
		return "CREATE TABLE IF NOT EXISTS '" + CMDKIHPAGPL() + "' (\n\t\t\t\t'id'\tINTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,\n\t\t\t\t'pkey'\tTEXT NOT NULL UNIQUE,\n\t\t\t\t'pvalue'\tTEXT,\n                'synced'\tINTEGER NOT NULL DEFAULT 0\n\t\t\t);";
	}

	protected override Dictionary<string, object> FHIBIOKHLNE(ABFBFJOFLKO LLIEHCKNJEM)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary["pkey"] = LLIEHCKNJEM.CDEOGMLENPN;
		dictionary["pvalue"] = LLIEHCKNJEM.PPKCBFFEDED;
		dictionary["synced"] = LLIEHCKNJEM.FOJDLLGGJID;
		return dictionary;
	}

	protected override ABFBFJOFLKO EOPGEOIHOAM(DCMNFAKJKCH BCAKHCNOKDH)
	{
		object value;
		BCAKHCNOKDH.TryGetValue("id", out value);
		object value2;
		BCAKHCNOKDH.TryGetValue("pkey", out value2);
		object value3;
		BCAKHCNOKDH.TryGetValue("pvalue", out value3);
		object value4;
		BCAKHCNOKDH.TryGetValue("synced", out value4);
		return new ABFBFJOFLKO((int)value, (string)value2, (string)value3, (int)value4);
	}

	public void KFCIOFNMKDA(string IKNCPEPOKGJ)
	{
		string hKCKEACCMMA = string.Format("delete from {0} where pkey={1}", CMDKIHPAGPL(), HCNJKKJJPFI(IKNCPEPOKGJ));
		KCAELBCNKFN.GABGKBAKHDP.OMBKLCBCMGP(hKCKEACCMMA);
	}
}
