using System.Collections.Generic;

public class CLJBOPHAOOD : global::JEDMENFBGJI<EHMCHKNPHOC>
{
	private static CLJBOPHAOOD KNPOFJNFLJB;

	public static CLJBOPHAOOD GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new CLJBOPHAOOD();
			}
			return KNPOFJNFLJB;
		}
	}

	private CLJBOPHAOOD()
	{
	}

	public bool EEEJGFGENKM(string IKNCPEPOKGJ)
	{
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(string.Format("select pvalue from {0} where pkey={1}", CMDKIHPAGPL(), HCNJKKJJPFI(IKNCPEPOKGJ)));
		return mBBJJJGFIKD != null && mBBJJJGFIKD.DFOGCCJCNJJ.Count > 0;
	}

	public int LIANKDMAHFM(string IKNCPEPOKGJ)
	{
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(string.Format("select pvalue from {0} where pkey={1}", CMDKIHPAGPL(), HCNJKKJJPFI(IKNCPEPOKGJ)));
		if (mBBJJJGFIKD == null || mBBJJJGFIKD.DFOGCCJCNJJ.Count == 0)
		{
			return 0;
		}
		return (int)mBBJJJGFIKD.DFOGCCJCNJJ[0].ECNCPJGHBIG("pvalue");
	}

	public int LIANKDMAHFM(string IKNCPEPOKGJ, int DLJMKKALKBD)
	{
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(string.Format("select pvalue from {0} where pkey={1}", CMDKIHPAGPL(), HCNJKKJJPFI(IKNCPEPOKGJ)));
		if (mBBJJJGFIKD != null && mBBJJJGFIKD.DFOGCCJCNJJ.Count != 0)
		{
			return (int)mBBJJJGFIKD.DFOGCCJCNJJ[0].ECNCPJGHBIG("pvalue");
		}
		LFHHPPDJGDC(new EHMCHKNPHOC(null, IKNCPEPOKGJ, DLJMKKALKBD));
		return DLJMKKALKBD;
	}

	public void JGMDDMNGDJO(string IKNCPEPOKGJ, int EDDNOJDPMCF)
	{
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(string.Format("select * from {0} where pkey={1}", CMDKIHPAGPL(), HCNJKKJJPFI(IKNCPEPOKGJ)));
		if (mBBJJJGFIKD == null || mBBJJJGFIKD.DFOGCCJCNJJ.Count == 0)
		{
			LFHHPPDJGDC(new EHMCHKNPHOC(null, IKNCPEPOKGJ, EDDNOJDPMCF));
			return;
		}
		EHMCHKNPHOC eHMCHKNPHOC = EOPGEOIHOAM(mBBJJJGFIKD.DFOGCCJCNJJ[0]);
		eHMCHKNPHOC.JBGOANMLBFA = EDDNOJDPMCF;
		GDFHLDAKIOM(eHMCHKNPHOC);
	}

	public void MFKBEDNLCJA(string NDDKGBHCNBB)
	{
		ODIPOJCEPEJ(string.Format("delete from {0} where pkey={1}", CMDKIHPAGPL(), HCNJKKJJPFI(NDDKGBHCNBB)));
	}

	protected override string CMDKIHPAGPL()
	{
		return "once_operations";
	}

	protected override string MCPNNIHODDL()
	{
		return "CREATE TABLE IF NOT EXISTS '" + CMDKIHPAGPL() + "' (\n\t\t\t\t'id'\tINTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,\n\t\t\t\t'pkey'\tTEXT NOT NULL UNIQUE,\n\t\t\t\t'pvalue' INTEGER NOT NULL DEFAULT 0\n\t\t\t);";
	}

	protected override object[] BMKKJMIKDPO(EHMCHKNPHOC EJCNAJOHBFI)
	{
		return new object[3]
		{
			EJCNAJOHBFI.AIAEHPLOFGB(),
			EJCNAJOHBFI.CDEOGMLENPN,
			EJCNAJOHBFI.JBGOANMLBFA
		};
	}

	protected override Dictionary<string, object> FHIBIOKHLNE(EHMCHKNPHOC LLIEHCKNJEM)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary["pkey"] = LLIEHCKNJEM.CDEOGMLENPN;
		dictionary["pvalue"] = LLIEHCKNJEM.JBGOANMLBFA;
		return dictionary;
	}

	protected override EHMCHKNPHOC EOPGEOIHOAM(DCMNFAKJKCH BCAKHCNOKDH)
	{
		object value;
		BCAKHCNOKDH.TryGetValue("id", out value);
		object value2;
		BCAKHCNOKDH.TryGetValue("pkey", out value2);
		object value3;
		BCAKHCNOKDH.TryGetValue("pvalue", out value3);
		return new EHMCHKNPHOC((int)value, (string)value2, (int)value3);
	}

	public void JIIFLHPECME(string MLMDFFLMJCH)
	{
		ODIPOJCEPEJ(string.Format("delete from {0} where pkey like '{1}'", CMDKIHPAGPL(), MLMDFFLMJCH.Replace("'", "''") + "%"));
	}
}
