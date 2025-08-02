using System.Collections.Generic;
using System.Text;
using caravan.protobuf.messages;

public class HLFNMNPLJCP : global::JEDMENFBGJI<FMHKCJGDPEB>
{
	private static HLFNMNPLJCP KNPOFJNFLJB;

	public static HLFNMNPLJCP GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new HLFNMNPLJCP();
			}
			return KNPOFJNFLJB;
		}
	}

	private HLFNMNPLJCP()
	{
		KMPGBIKPKOO();
	}

	public bool CDIPPLFJFEF(int EMNOJOHFMEH, int MGCMMJPNJPH)
	{
		bool flag = KDNCPBJFMBD(EMNOJOHFMEH, MGCMMJPNJPH);
		bool flag2 = KDNCPBJFMBD(EMNOJOHFMEH, MGCMMJPNJPH, 2);
		return flag || flag2;
	}

	public bool KDNCPBJFMBD(int EMNOJOHFMEH, int MGCMMJPNJPH, int OMOCHOLJCIL = 1)
	{
		string nGKFCKIHIPE = string.Format("SELECT * FROM {0} WHERE teamId ={1} AND leaderboardType ={2}", CMDKIHPAGPL(), EMNOJOHFMEH, OMOCHOLJCIL);
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(nGKFCKIHIPE);
		if (mBBJJJGFIKD != null && mBBJJJGFIKD.DFOGCCJCNJJ.Count > 0)
		{
			FMHKCJGDPEB fMHKCJGDPEB = EOPGEOIHOAM(mBBJJJGFIKD.DFOGCCJCNJJ[0]);
			if (fMHKCJGDPEB.DJADMBLKBKJ != MGCMMJPNJPH)
			{
				fMHKCJGDPEB.DJADMBLKBKJ = MGCMMJPNJPH;
				GDFHLDAKIOM(fMHKCJGDPEB);
				return true;
			}
		}
		return false;
	}

	public void ALOPBFOLFOE(int EMNOJOHFMEH, int GIOFHACJEGA)
	{
		string nGKFCKIHIPE = string.Format("SELECT * FROM {0} WHERE teamId ={1}", CMDKIHPAGPL(), EMNOJOHFMEH);
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(nGKFCKIHIPE);
		if (mBBJJJGFIKD != null && mBBJJJGFIKD.DFOGCCJCNJJ.Count > 0)
		{
			for (int i = 0; i < mBBJJJGFIKD.DFOGCCJCNJJ.Count; i++)
			{
				FMHKCJGDPEB fMHKCJGDPEB = EOPGEOIHOAM(mBBJJJGFIKD.DFOGCCJCNJJ[i]);
				fMHKCJGDPEB.DJADMBLKBKJ += GIOFHACJEGA;
				GDFHLDAKIOM(fMHKCJGDPEB);
			}
		}
	}

	public List<FMHKCJGDPEB> BBINNBKCDIH(int OMOCHOLJCIL = 1)
	{
		string nGKFCKIHIPE = string.Format("SELECT * FROM {0} WHERE leaderboardType={1} ORDER BY score DESC;", CMDKIHPAGPL(), OMOCHOLJCIL);
		return LIGBBHCFEIJ(nGKFCKIHIPE);
	}

	public void ADIMEEPIFBL(GetTeamLeaderboardResponseMessage OMJOIIOONMO, int OMOCHOLJCIL = 1)
	{
		string nGKFCKIHIPE = string.Format("DELETE from {0} WHERE leaderboardType={1};", CMDKIHPAGPL(), OMOCHOLJCIL);
		OMBKLCBCMGP(nGKFCKIHIPE);
		int count = OMJOIIOONMO.teamList.Count;
		if (count == 0)
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("INSERT INTO ");
		stringBuilder.Append(CMDKIHPAGPL());
		stringBuilder.Append(" ('teamId','name','count','badge','score','orderId','leaderboardType') VALUES  ");
		for (int i = 0; i < count; i++)
		{
			TeamLeaderboardEntryData teamLeaderboardEntryData = OMJOIIOONMO.teamList[i];
			string value = teamLeaderboardEntryData.name.Replace("'", "''");
			stringBuilder.Append(" (");
			stringBuilder.Append(teamLeaderboardEntryData.id);
			stringBuilder.Append(", '");
			stringBuilder.Append(value);
			stringBuilder.Append("', ");
			stringBuilder.Append(teamLeaderboardEntryData.count);
			stringBuilder.Append(", '");
			stringBuilder.Append(teamLeaderboardEntryData.badge);
			stringBuilder.Append("', ");
			stringBuilder.Append(teamLeaderboardEntryData.score);
			stringBuilder.Append(", ");
			stringBuilder.Append(teamLeaderboardEntryData.order);
			stringBuilder.Append(", ");
			stringBuilder.Append(OMOCHOLJCIL);
			stringBuilder.Append(" )");
			if (i < count - 1)
			{
				stringBuilder.Append(",");
			}
		}
		OMBKLCBCMGP(stringBuilder.ToString());
	}

	private void KMPGBIKPKOO()
	{
		string nGKFCKIHIPE = string.Format("PRAGMA table_info({0})", CMDKIHPAGPL());
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(nGKFCKIHIPE);
		if (mBBJJJGFIKD != null && mBBJJJGFIKD.DFOGCCJCNJJ.Count == 7)
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Leaderboard, "Migrated from old Team Leaderboard Database.");
			string nGKFCKIHIPE2 = string.Format("ALTER TABLE {0} ADD COLUMN leaderboardType INTEGER DEFAULT 1;", CMDKIHPAGPL());
			OMBKLCBCMGP(nGKFCKIHIPE2);
		}
	}

	protected override string CMDKIHPAGPL()
	{
		return "TeamLeaderboard";
	}

	protected override object[] BMKKJMIKDPO(FMHKCJGDPEB LLIEHCKNJEM)
	{
		return new object[8]
		{
			LLIEHCKNJEM.AIAEHPLOFGB(),
			LLIEHCKNJEM.OADDPGNIINO,
			LLIEHCKNJEM.PNGPLGHKFDI,
			LLIEHCKNJEM.GMCGMPEEHJP,
			LLIEHCKNJEM.FGPGOGEKDAM,
			LLIEHCKNJEM.DJADMBLKBKJ,
			LLIEHCKNJEM.HDENPOJOAKC,
			LLIEHCKNJEM.AMKMOFAHFOC
		};
	}

	protected override string MCPNNIHODDL()
	{
		return "CREATE TABLE IF NOT EXISTS `" + CMDKIHPAGPL() + "` (\n\t`id`\tINTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,\n\t`teamId` INTEGER NOT NULL,\n\t`name`\tTEXT NOT NULL,\n\t`count`\tINTEGER NOT NULL,\n\t`badge`\tTEXT NOT NULL,\n\t`score`\tINTEGER NOT NULL,\n\t`orderId`\tINTEGER NOT NULL,\n\t`leaderboardType` INTEGER DEFAULT 1\n);";
	}

	protected override Dictionary<string, object> FHIBIOKHLNE(FMHKCJGDPEB LLIEHCKNJEM)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary["teamId"] = LLIEHCKNJEM.OADDPGNIINO;
		dictionary["name"] = LLIEHCKNJEM.PNGPLGHKFDI;
		dictionary["count"] = LLIEHCKNJEM.GMCGMPEEHJP;
		dictionary["badge"] = LLIEHCKNJEM.FGPGOGEKDAM;
		dictionary["score"] = LLIEHCKNJEM.DJADMBLKBKJ;
		dictionary["orderId"] = LLIEHCKNJEM.HDENPOJOAKC;
		dictionary["leaderboardType"] = LLIEHCKNJEM.AMKMOFAHFOC;
		return dictionary;
	}

	protected override FMHKCJGDPEB EOPGEOIHOAM(DCMNFAKJKCH BCAKHCNOKDH)
	{
		object value;
		BCAKHCNOKDH.TryGetValue("id", out value);
		object value2;
		BCAKHCNOKDH.TryGetValue("teamId", out value2);
		object value3;
		BCAKHCNOKDH.TryGetValue("name", out value3);
		object value4;
		BCAKHCNOKDH.TryGetValue("count", out value4);
		object value5;
		BCAKHCNOKDH.TryGetValue("badge", out value5);
		object value6;
		BCAKHCNOKDH.TryGetValue("score", out value6);
		object value7;
		BCAKHCNOKDH.TryGetValue("orderId", out value7);
		object value8;
		BCAKHCNOKDH.TryGetValue("leaderboardType", out value8);
		return new FMHKCJGDPEB((int?)value, (int)value2, (string)value3, (int)value4, (string)value5, (int)value6, (int)value7, (int)value8);
	}
}
