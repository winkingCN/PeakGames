using System.Collections.Generic;

public class FCJAAJLPCMB : global::JEDMENFBGJI<CDAKABCMLGA>
{
	private static FCJAAJLPCMB KNPOFJNFLJB;

	public static FCJAAJLPCMB GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new FCJAAJLPCMB();
			}
			return KNPOFJNFLJB;
		}
	}

	private FCJAAJLPCMB()
	{
	}

	public CDAKABCMLGA CMMLPKLDOHL(string LOKMKDKABPI)
	{
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(string.Format("select * from {0} where purpose={1}", CMDKIHPAGPL(), HCNJKKJJPFI(LOKMKDKABPI)));
		if (mBBJJJGFIKD == null || mBBJJJGFIKD.DFOGCCJCNJJ.Count == 0)
		{
			return null;
		}
		return EOPGEOIHOAM(mBBJJJGFIKD.DFOGCCJCNJJ[0]);
	}

	protected override string CMDKIHPAGPL()
	{
		return "download_metadata";
	}

	public override void GDFHLDAKIOM(CDAKABCMLGA LLIEHCKNJEM)
	{
		LLIEHCKNJEM.FOIACLCGMLF = FIBJIOBINHL.CFBJBKEPGAN().ToString();
		base.GDFHLDAKIOM(LLIEHCKNJEM);
	}

	protected override object[] BMKKJMIKDPO(CDAKABCMLGA EJCNAJOHBFI)
	{
		return new object[8]
		{
			EJCNAJOHBFI.AIAEHPLOFGB(),
			EJCNAJOHBFI.BEBMJGNKAPG,
			EJCNAJOHBFI.IKNGODJEKEA,
			EJCNAJOHBFI.BJMDAELAELI,
			EJCNAJOHBFI.AMEDMLOCCBG,
			EJCNAJOHBFI.DMAGNMIOAEJ,
			EJCNAJOHBFI.AEPLIGFCGIF,
			EJCNAJOHBFI.FOIACLCGMLF
		};
	}

	protected override string MCPNNIHODDL()
	{
		return "CREATE TABLE IF NOT EXISTS '" + CMDKIHPAGPL() + "' (\n\t\t\t\t\t\t'id'\tINTEGER PRIMARY KEY AUTOINCREMENT UNIQUE,\n\t\t\t\t\t\t'content_url'\tTEXT,\n\t\t\t\t\t\t'download_size'\tINTEGER NOT NULL,\n\t\t\t\t\t\t'downloaded_size'\tINTEGER NOT NULL,\n\t\t\t\t\t\t'version'\tTEXT,\n\t\t\t\t\t\t'purpose' TEXT NOT NULL UNIQUE,\n\t\t\t\t\t\t'status'\tINTEGER NOT NULL,\n\t\t\t\t\t\t'last_update'\tTEXT NOT NULL\n\t\t\t\t\t\t\n\t\t\t\t\t);";
	}

	protected override CDAKABCMLGA EOPGEOIHOAM(DCMNFAKJKCH BCAKHCNOKDH)
	{
		object value;
		BCAKHCNOKDH.TryGetValue("content_url", out value);
		object value2;
		BCAKHCNOKDH.TryGetValue("download_size", out value2);
		object value3;
		BCAKHCNOKDH.TryGetValue("downloaded_size", out value3);
		object value4;
		BCAKHCNOKDH.TryGetValue("version", out value4);
		object value5;
		BCAKHCNOKDH.TryGetValue("purpose", out value5);
		object value6;
		BCAKHCNOKDH.TryGetValue("id", out value6);
		object value7;
		BCAKHCNOKDH.TryGetValue("status", out value7);
		object value8;
		BCAKHCNOKDH.TryGetValue("last_update", out value8);
		return new CDAKABCMLGA((int)value6, (string)value, (int)value2, (string)value4, (string)value5, (int)value7, (int)value3, (string)value8);
	}

	protected override Dictionary<string, object> FHIBIOKHLNE(CDAKABCMLGA LLIEHCKNJEM)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary["content_url"] = LLIEHCKNJEM.BEBMJGNKAPG;
		dictionary["download_size"] = LLIEHCKNJEM.IKNGODJEKEA;
		dictionary["downloaded_size"] = LLIEHCKNJEM.BJMDAELAELI;
		dictionary["version"] = LLIEHCKNJEM.AMEDMLOCCBG;
		dictionary["purpose"] = LLIEHCKNJEM.DMAGNMIOAEJ;
		dictionary["status"] = LLIEHCKNJEM.AEPLIGFCGIF;
		dictionary["last_update"] = LLIEHCKNJEM.FOIACLCGMLF;
		return dictionary;
	}
}
