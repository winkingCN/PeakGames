using System.Collections.Generic;
using DAO.Entity;

public class JAGPGEPOKFH : global::JEDMENFBGJI<EventEntity>
{
	public List<EventEntity> EDDCKCGJNOA(int NBFBPNNEKMN)
	{
		string nGKFCKIHIPE = string.Format("select * from {0} where type = {1}", CMDKIHPAGPL(), NBFBPNNEKMN);
		return LIGBBHCFEIJ(nGKFCKIHIPE);
	}

	public void COMBPALIEFO(int BDKFNEDHAOJ, int AMGEDPDJPNE)
	{
		ODIPOJCEPEJ(string.Format("update {0} set eligible = {1} where id = {2}", CMDKIHPAGPL(), AMGEDPDJPNE, BDKFNEDHAOJ));
	}

	public List<EventEntity> OKLKMOABOBP()
	{
		string nGKFCKIHIPE = string.Format("select * from {0} where eligible = 1 order by id asc", CMDKIHPAGPL());
		return LIGBBHCFEIJ(nGKFCKIHIPE);
	}

	protected override string CMDKIHPAGPL()
	{
		return "Events";
	}

	protected override object[] BMKKJMIKDPO(EventEntity LLIEHCKNJEM)
	{
		return new object[9]
		{
			LLIEHCKNJEM.AIAEHPLOFGB(),
			LLIEHCKNJEM.Type,
			LLIEHCKNJEM.EndTime,
			LLIEHCKNJEM.MinLevel,
			LLIEHCKNJEM.MaxLevel,
			LLIEHCKNJEM.Filter,
			LLIEHCKNJEM.Version,
			LLIEHCKNJEM.Eligible,
			LLIEHCKNJEM.Data
		};
	}

	protected override string MCPNNIHODDL()
	{
		return "CREATE TABLE IF NOT EXISTS `" + CMDKIHPAGPL() + "` (\n                `id`\tINTEGER NOT NULL PRIMARY KEY,\n                `type`\t     INTEGER,                \n                `endTime`\t INTEGER,                \n                `minLevel`\t INTEGER,                \n                `maxLevel`\t INTEGER,                \n                `filter`\t INTEGER,                \n                `version`\t INTEGER,                \n                `eligible`\t INTEGER,                \n                `data`\t TEXT                \n                );";
	}

	protected override Dictionary<string, object> FHIBIOKHLNE(EventEntity LLIEHCKNJEM)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary["id"] = LLIEHCKNJEM.AIAEHPLOFGB();
		dictionary["type"] = LLIEHCKNJEM.Type;
		dictionary["endTime"] = LLIEHCKNJEM.EndTime;
		dictionary["minLevel"] = LLIEHCKNJEM.MinLevel;
		dictionary["maxLevel"] = LLIEHCKNJEM.MaxLevel;
		dictionary["filter"] = LLIEHCKNJEM.Filter;
		dictionary["version"] = LLIEHCKNJEM.Version;
		dictionary["eligible"] = LLIEHCKNJEM.Eligible;
		dictionary["data"] = LLIEHCKNJEM.Data;
		return dictionary;
	}

	protected override EventEntity EOPGEOIHOAM(DCMNFAKJKCH BCAKHCNOKDH)
	{
		object value;
		BCAKHCNOKDH.TryGetValue("id", out value);
		object value2;
		BCAKHCNOKDH.TryGetValue("type", out value2);
		object value3;
		BCAKHCNOKDH.TryGetValue("endTime", out value3);
		object value4;
		BCAKHCNOKDH.TryGetValue("minLevel", out value4);
		object value5;
		BCAKHCNOKDH.TryGetValue("maxLevel", out value5);
		object value6;
		BCAKHCNOKDH.TryGetValue("filter", out value6);
		object value7;
		BCAKHCNOKDH.TryGetValue("version", out value7);
		object value8;
		BCAKHCNOKDH.TryGetValue("eligible", out value8);
		object value9;
		BCAKHCNOKDH.TryGetValue("data", out value9);
		return new EventEntity((int)value, (int)value2, (int)value3, (int)value4, (int)value5, (int)value6, (int)value7, (int)value8, (string)value9);
	}
}
