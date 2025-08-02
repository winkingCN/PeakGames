using System.Collections.Generic;

public class HJBLKNBHMFJ : global::JEDMENFBGJI<DEDNLGAFIDJ>
{
	private static HJBLKNBHMFJ KNPOFJNFLJB;

	public static HJBLKNBHMFJ GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new HJBLKNBHMFJ();
			}
			return KNPOFJNFLJB;
		}
	}

	private HJBLKNBHMFJ()
	{
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

	public string LIANKDMAHFM(string IKNCPEPOKGJ, string DLJMKKALKBD)
	{
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(string.Format("select pvalue from {0} where pkey={1}", CMDKIHPAGPL(), HCNJKKJJPFI(IKNCPEPOKGJ)));
		if (mBBJJJGFIKD == null || mBBJJJGFIKD.DFOGCCJCNJJ.Count == 0)
		{
			LFHHPPDJGDC(new DEDNLGAFIDJ(null, IKNCPEPOKGJ, DLJMKKALKBD));
			return DLJMKKALKBD;
		}
		return (string)mBBJJJGFIKD.DFOGCCJCNJJ[0].ECNCPJGHBIG("pvalue");
	}

	public void JGMDDMNGDJO(string IKNCPEPOKGJ, string EDDNOJDPMCF)
	{
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(string.Format("select * from {0} where pkey={1}", CMDKIHPAGPL(), HCNJKKJJPFI(IKNCPEPOKGJ)));
		if (mBBJJJGFIKD == null || mBBJJJGFIKD.DFOGCCJCNJJ.Count == 0)
		{
			LFHHPPDJGDC(new DEDNLGAFIDJ(null, IKNCPEPOKGJ, EDDNOJDPMCF));
			return;
		}
		DEDNLGAFIDJ dEDNLGAFIDJ = EOPGEOIHOAM(mBBJJJGFIKD.DFOGCCJCNJJ[0]);
		dEDNLGAFIDJ.JBGOANMLBFA = EDDNOJDPMCF;
		GDFHLDAKIOM(dEDNLGAFIDJ);
	}

	public void MFKBEDNLCJA(string NDDKGBHCNBB)
	{
		ODIPOJCEPEJ(string.Format("delete from {0} where pkey={1}", CMDKIHPAGPL(), HCNJKKJJPFI(NDDKGBHCNBB)));
	}

	public void OLGJNHPAGFN(string JENJPIAAKDN)
	{
		ODIPOJCEPEJ(string.Format("delete from {0} where pkey like {1}", CMDKIHPAGPL(), HCNJKKJJPFI(JENJPIAAKDN)));
	}

	protected override string CMDKIHPAGPL()
	{
		return "simple_properties";
	}

	protected override string MCPNNIHODDL()
	{
		return "CREATE TABLE IF NOT EXISTS '" + CMDKIHPAGPL() + "' (\n\t\t\t\t'id'\tINTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,\n\t\t\t\t'pkey'\tTEXT NOT NULL UNIQUE,\n\t\t\t\t'pvalue'\tTEXT\n\t\t\t);";
	}

	protected override object[] BMKKJMIKDPO(DEDNLGAFIDJ EJCNAJOHBFI)
	{
		return new object[3]
		{
			EJCNAJOHBFI.AIAEHPLOFGB(),
			EJCNAJOHBFI.CDEOGMLENPN,
			EJCNAJOHBFI.JBGOANMLBFA
		};
	}

	protected override Dictionary<string, object> FHIBIOKHLNE(DEDNLGAFIDJ LLIEHCKNJEM)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary["pkey"] = LLIEHCKNJEM.CDEOGMLENPN;
		dictionary["pvalue"] = LLIEHCKNJEM.JBGOANMLBFA;
		return dictionary;
	}

	protected override DEDNLGAFIDJ EOPGEOIHOAM(DCMNFAKJKCH BCAKHCNOKDH)
	{
		object value;
		BCAKHCNOKDH.TryGetValue("id", out value);
		object value2;
		BCAKHCNOKDH.TryGetValue("pkey", out value2);
		object value3;
		BCAKHCNOKDH.TryGetValue("pvalue", out value3);
		return new DEDNLGAFIDJ((int)value, (string)value2, (string)value3);
	}

	public void KFCIOFNMKDA(string IKNCPEPOKGJ)
	{
		string hKCKEACCMMA = string.Format("delete from {0} where pkey={1}", CMDKIHPAGPL(), HCNJKKJJPFI(IKNCPEPOKGJ));
		KCAELBCNKFN.GABGKBAKHDP.OMBKLCBCMGP(hKCKEACCMMA);
	}
}
