using System.Collections.Generic;

public class APPIMCFMFNG : global::JEDMENFBGJI<NIGFCEFLHML>
{
	public NIGFCEFLHML ACDBBJACJOE(int KIGOGMKCDKN)
	{
		string nGKFCKIHIPE = string.Format("select * from {0} where levelNo={1}", CMDKIHPAGPL(), KIGOGMKCDKN);
		NIGFCEFLHML nIGFCEFLHML = PEFIHEFDOIE(nGKFCKIHIPE);
		if (nIGFCEFLHML == null)
		{
			return new NIGFCEFLHML(null, KIGOGMKCDKN, 0, 0, 0);
		}
		return nIGFCEFLHML;
	}

	public int NAJIPFBGLLC()
	{
		string nGKFCKIHIPE = string.Format("select levelNo from {0} order by levelNo DESC limit 1", CMDKIHPAGPL());
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(nGKFCKIHIPE);
		if (mBBJJJGFIKD == null || mBBJJJGFIKD.DFOGCCJCNJJ.Count <= 0)
		{
			return 0;
		}
		DCMNFAKJKCH dCMNFAKJKCH = mBBJJJGFIKD.DFOGCCJCNJJ[0];
		return (int)dCMNFAKJKCH.ECNCPJGHBIG("levelNo");
	}

	public bool IHIKJJMGNPJ()
	{
		string nGKFCKIHIPE = string.Format("select * from {0} where synced = 0 limit 1", CMDKIHPAGPL());
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(nGKFCKIHIPE);
		return mBBJJJGFIKD != null && mBBJJJGFIKD.DFOGCCJCNJJ.Count > 0;
	}

	public List<NIGFCEFLHML> NJHNMKHFJMB()
	{
		string nGKFCKIHIPE = string.Format("select * from {0} where synced = 0", CMDKIHPAGPL());
		return LIGBBHCFEIJ(nGKFCKIHIPE);
	}

	public void LNDHDLFFFBM()
	{
		string nGKFCKIHIPE = string.Format("DELETE FROM {0} WHERE id IN (SELECT id FROM {0} WHERE synced = 1 LIMIT 300)", CMDKIHPAGPL());
		OMBKLCBCMGP(nGKFCKIHIPE);
	}

	protected override string CMDKIHPAGPL()
	{
		return "Levels";
	}

	protected override object[] BMKKJMIKDPO(NIGFCEFLHML LLIEHCKNJEM)
	{
		return new object[5]
		{
			LLIEHCKNJEM.AIAEHPLOFGB(),
			LLIEHCKNJEM.PDGLECFDLJJ,
			LLIEHCKNJEM.DJADMBLKBKJ,
			LLIEHCKNJEM.EMNDJNDGANP,
			LLIEHCKNJEM.FOJDLLGGJID
		};
	}

	protected override string MCPNNIHODDL()
	{
		return "CREATE TABLE IF NOT EXISTS `" + CMDKIHPAGPL() + "` (\n                `id`\tINTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,\n                `levelNo`\tINTEGER NOT NULL,\n                `score`\tINTEGER NOT NULL DEFAULT 0,\n                `stars`\tINTEGER NOT NULL DEFAULT 0,\n                `synced`\tINTEGER NOT NULL DEFAULT 0\n            );";
	}

	protected override Dictionary<string, object> FHIBIOKHLNE(NIGFCEFLHML LLIEHCKNJEM)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary["levelNo"] = LLIEHCKNJEM.PDGLECFDLJJ;
		dictionary["score"] = LLIEHCKNJEM.DJADMBLKBKJ;
		dictionary["stars"] = LLIEHCKNJEM.EMNDJNDGANP;
		dictionary["synced"] = LLIEHCKNJEM.FOJDLLGGJID;
		return dictionary;
	}

	protected override NIGFCEFLHML EOPGEOIHOAM(DCMNFAKJKCH BCAKHCNOKDH)
	{
		object value;
		BCAKHCNOKDH.TryGetValue("id", out value);
		object value2;
		BCAKHCNOKDH.TryGetValue("levelNo", out value2);
		object value3;
		BCAKHCNOKDH.TryGetValue("score", out value3);
		object value4;
		BCAKHCNOKDH.TryGetValue("stars", out value4);
		object value5;
		BCAKHCNOKDH.TryGetValue("synced", out value5);
		return new NIGFCEFLHML((int)value, (int)value2, (int)value3, (int)value4, (int)value5);
	}
}
