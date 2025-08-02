using System.Collections.Generic;
using System.Text;
using caravan.protobuf.messages;

public class FIFPLICICKP : global::JEDMENFBGJI<OFGGFEJGABH>
{
	private static FIFPLICICKP KNPOFJNFLJB;

	public static FIFPLICICKP GABGKBAKHDP
	{
		get
		{
			return KNPOFJNFLJB ?? (KNPOFJNFLJB = new FIFPLICICKP());
		}
	}

	private FIFPLICICKP()
	{
		KMPGBIKPKOO();
	}

	protected override string CMDKIHPAGPL()
	{
		return "PlayersLeaderboard";
	}

	protected override object[] BMKKJMIKDPO(OFGGFEJGABH LLIEHCKNJEM)
	{
		return new object[10]
		{
			LLIEHCKNJEM.AIAEHPLOFGB(),
			LLIEHCKNJEM.KJACEODCOHN,
			LLIEHCKNJEM.OADDPGNIINO,
			LLIEHCKNJEM.EFHEIFMEJCN,
			LLIEHCKNJEM.FGPGOGEKDAM,
			LLIEHCKNJEM.DJADMBLKBKJ,
			LLIEHCKNJEM.GGBEMNJNAEE,
			LLIEHCKNJEM.GHBJBDACBAH,
			LLIEHCKNJEM.GDMECFECCOM,
			LLIEHCKNJEM.AMKMOFAHFOC
		};
	}

	protected override string MCPNNIHODDL()
	{
		return "CREATE TABLE IF NOT EXISTS `" + CMDKIHPAGPL() + "` (\n            `id`        INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,\n            `nickName`  TEXT NOT NULL,\n            `teamId`\tINTEGER NOT NULL,\n            `teamName`  TEXT NOT NULL,\n            `badge`\t    TEXT NOT NULL,\n            `score`\t    INTEGER NOT NULL,\n            `clScore`   INTEGER NOT NULL DEFAULT(0),\n            `updateTime`    INTEGER NOT NULL,\n            `userId`    INTEGER NOT NULL,\n            `leaderboardType`    INTEGER DEFAULT 1\n        );";
	}

	protected override Dictionary<string, object> FHIBIOKHLNE(OFGGFEJGABH LLIEHCKNJEM)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary["nickName"] = LLIEHCKNJEM.KJACEODCOHN;
		dictionary["teamId"] = LLIEHCKNJEM.OADDPGNIINO;
		dictionary["teamName"] = LLIEHCKNJEM.EFHEIFMEJCN;
		dictionary["badge"] = LLIEHCKNJEM.FGPGOGEKDAM;
		dictionary["score"] = LLIEHCKNJEM.DJADMBLKBKJ;
		dictionary["clScore"] = LLIEHCKNJEM.GGBEMNJNAEE;
		dictionary["updateTime"] = LLIEHCKNJEM.GHBJBDACBAH;
		dictionary["leaderboardtype"] = LLIEHCKNJEM.AMKMOFAHFOC;
		return dictionary;
	}

	protected override OFGGFEJGABH EOPGEOIHOAM(DCMNFAKJKCH BCAKHCNOKDH)
	{
		object value;
		BCAKHCNOKDH.TryGetValue("id", out value);
		object value2;
		BCAKHCNOKDH.TryGetValue("nickName", out value2);
		object value3;
		BCAKHCNOKDH.TryGetValue("teamId", out value3);
		object value4;
		BCAKHCNOKDH.TryGetValue("teamName", out value4);
		object value5;
		BCAKHCNOKDH.TryGetValue("badge", out value5);
		object value6;
		BCAKHCNOKDH.TryGetValue("score", out value6);
		object value7;
		BCAKHCNOKDH.TryGetValue("clScore", out value7);
		object value8;
		BCAKHCNOKDH.TryGetValue("updateTime", out value8);
		object value9;
		BCAKHCNOKDH.TryGetValue("userId", out value9);
		object value10;
		BCAKHCNOKDH.TryGetValue("leaderboardType", out value10);
		return new OFGGFEJGABH((int?)value, (string)value2, (int)value3, (string)value4, (string)value5, (int)value6, (int)value7, (int)value8, (int)value9, (int)value10);
	}

	public List<OFGGFEJGABH> BBINNBKCDIH(int OMOCHOLJCIL = 1)
	{
		string nGKFCKIHIPE = string.Format("SELECT *, (score + clscore) as total_score FROM {0} WHERE leaderboardType = {1} ORDER BY total_score DESC, score DESC, clScore DESC, updateTime ASC;", CMDKIHPAGPL(), OMOCHOLJCIL);
		return LIGBBHCFEIJ(nGKFCKIHIPE);
	}

	public void ADIMEEPIFBL(GetPlayersLeaderboardResponseMessage OMJOIIOONMO, int OMOCHOLJCIL = 1)
	{
		string nGKFCKIHIPE = string.Format("DELETE from {0} WHERE leaderboardType = {1};", CMDKIHPAGPL(), OMOCHOLJCIL);
		OMBKLCBCMGP(nGKFCKIHIPE);
		int count = OMJOIIOONMO.leaderboard.Count;
		if (count == 0)
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("INSERT INTO ");
		stringBuilder.Append(CMDKIHPAGPL());
		stringBuilder.Append(" ('nickName','teamId','teamName','badge','score','clScore','updateTime', 'userId', 'leaderboardType') VALUES  ");
		for (int i = 0; i < count; i++)
		{
			PlayersLeaderboardEntry playersLeaderboardEntry = OMJOIIOONMO.leaderboard[i];
			string value = playersLeaderboardEntry.nickname.Replace("'", "''");
			string value2 = playersLeaderboardEntry.teamName.Replace("'", "''");
			stringBuilder.Append(" ('");
			stringBuilder.Append(value);
			stringBuilder.Append("', ");
			stringBuilder.Append(playersLeaderboardEntry.teamId);
			stringBuilder.Append(", '");
			stringBuilder.Append(value2);
			stringBuilder.Append("', '");
			stringBuilder.Append(playersLeaderboardEntry.teamBadge);
			stringBuilder.Append("', ");
			stringBuilder.Append(playersLeaderboardEntry.score);
			stringBuilder.Append(", ");
			stringBuilder.Append(playersLeaderboardEntry.clScore);
			stringBuilder.Append(", ");
			stringBuilder.Append(playersLeaderboardEntry.updateTime);
			stringBuilder.Append(", ");
			stringBuilder.Append(playersLeaderboardEntry.userId);
			stringBuilder.Append(", ");
			stringBuilder.Append(OMOCHOLJCIL);
			stringBuilder.Append(" )");
			if (i < count - 1)
			{
				stringBuilder.Append(",");
			}
		}
		OMBKLCBCMGP(stringBuilder.ToString());
		BAFBKBIKHKC();
	}

	private void KMPGBIKPKOO()
	{
		string nGKFCKIHIPE = string.Format("PRAGMA table_info({0})", CMDKIHPAGPL());
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(nGKFCKIHIPE);
		if (mBBJJJGFIKD != null && mBBJJJGFIKD.DFOGCCJCNJJ.Count == 9)
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Leaderboard, "Migrated from old Players Leaderboard Database.");
			string nGKFCKIHIPE2 = string.Format("ALTER TABLE {0} ADD COLUMN leaderboardType INTEGER DEFAULT 1;", CMDKIHPAGPL());
			OMBKLCBCMGP(nGKFCKIHIPE2);
		}
	}

	public void BAFBKBIKHKC()
	{
		string nGKFCKIHIPE = string.Format("select * from {0} where userId={1}", CMDKIHPAGPL(), LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM);
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(nGKFCKIHIPE);
		if (mBBJJJGFIKD == null || mBBJJJGFIKD.DFOGCCJCNJJ.Count == 0)
		{
			return;
		}
		for (int i = 0; i < mBBJJJGFIKD.DFOGCCJCNJJ.Count; i++)
		{
			OFGGFEJGABH oFGGFEJGABH = EOPGEOIHOAM(mBBJJJGFIKD.DFOGCCJCNJJ[i]);
			oFGGFEJGABH.KJACEODCOHN = LECPGNKOABP.GABGKBAKHDP.KJACEODCOHN ?? string.Empty;
			oFGGFEJGABH.DJADMBLKBKJ = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1;
			int num = 0;
			IDFPAFEJPPH iDFPAFEJPPH = IDFPAFEJPPH.GABGKBAKHDP;
			if (iDFPAFEJPPH.HGNJBHGBLIN)
			{
				num = iDFPAFEJPPH.PDGLECFDLJJ;
			}
			if (oFGGFEJGABH.GGBEMNJNAEE < num)
			{
				oFGGFEJGABH.GGBEMNJNAEE = num;
			}
			GDFHLDAKIOM(oFGGFEJGABH);
		}
	}

	public void DIJBPMMKPAE(DKBEJLGEAOA IIIMBFFNNBN)
	{
		string nGKFCKIHIPE = string.Format("SELECT * FROM {0} WHERE userId={1}", CMDKIHPAGPL(), LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM);
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(nGKFCKIHIPE);
		if (mBBJJJGFIKD == null || mBBJJJGFIKD.DFOGCCJCNJJ.Count == 0)
		{
			return;
		}
		for (int i = 0; i < mBBJJJGFIKD.DFOGCCJCNJJ.Count; i++)
		{
			OFGGFEJGABH oFGGFEJGABH = EOPGEOIHOAM(mBBJJJGFIKD.DFOGCCJCNJJ[i]);
			if (IIIMBFFNNBN != null)
			{
				oFGGFEJGABH.OADDPGNIINO = (int)IIIMBFFNNBN.EEFMIHDPJPG;
				oFGGFEJGABH.EFHEIFMEJCN = IIIMBFFNNBN.PNGPLGHKFDI;
				oFGGFEJGABH.FGPGOGEKDAM = IIIMBFFNNBN.FGPGOGEKDAM;
			}
			else
			{
				oFGGFEJGABH.OADDPGNIINO = -1;
				oFGGFEJGABH.EFHEIFMEJCN = string.Empty;
				oFGGFEJGABH.FGPGOGEKDAM = string.Empty;
			}
			GDFHLDAKIOM(oFGGFEJGABH);
		}
	}
}
