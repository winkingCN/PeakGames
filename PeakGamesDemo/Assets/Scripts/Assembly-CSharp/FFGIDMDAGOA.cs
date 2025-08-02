using System.Collections.Generic;
using System.Text;
using ToonSocial;
using caravan.protobuf.messages;

public class FFGIDMDAGOA : global::JEDMENFBGJI<IENHAKEMDPM>
{
	private static FFGIDMDAGOA KNPOFJNFLJB;

	public static FFGIDMDAGOA GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new FFGIDMDAGOA();
			}
			return KNPOFJNFLJB;
		}
	}

	private FFGIDMDAGOA()
	{
		KMPGBIKPKOO();
	}

	public int PLKAJICLGJB()
	{
		if (!LECPGNKOABP.GABGKBAKHDP.BJLBIBDKADC())
		{
			return -1;
		}
		string nGKFCKIHIPE = string.Format("SELECT level FROM {0} WHERE facebookId !='{1}' ORDER BY level DESC LIMIT 1;", CMDKIHPAGPL(), LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA);
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(nGKFCKIHIPE);
		if (mBBJJJGFIKD != null && mBBJJJGFIKD.DFOGCCJCNJJ.Count > 0)
		{
			return (int)mBBJJJGFIKD.DFOGCCJCNJJ[0].ECNCPJGHBIG("level");
		}
		return -1;
	}

	public int ADNBNEFJGFF()
	{
		if (!LECPGNKOABP.GABGKBAKHDP.BJLBIBDKADC())
		{
			return -1;
		}
		string nGKFCKIHIPE = string.Format("SELECT COUNT(*) as cnt FROM {0}  WHERE facebookId !='{1}';", CMDKIHPAGPL(), LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA);
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(nGKFCKIHIPE);
		if (mBBJJJGFIKD != null && mBBJJJGFIKD.DFOGCCJCNJJ.Count > 0)
		{
			return (int)mBBJJJGFIKD.DFOGCCJCNJJ[0].ECNCPJGHBIG("cnt");
		}
		return 0;
	}

	public List<IENHAKEMDPM> BBINNBKCDIH()
	{
		string nGKFCKIHIPE = string.Format("SELECT * , (level + clscore) as total_score FROM {0} ORDER BY total_score DESC, level DESC, clScore DESC, name ASC;", CMDKIHPAGPL());
		return LIGBBHCFEIJ(nGKFCKIHIPE);
	}

	public void OMOKOKFNBKI()
	{
		BBGLCADIONK();
	}

	public void PLGCGKINCFA(Dictionary<string, string> GAGDOGJGNDI)
	{
		List<IENHAKEMDPM> list = BBINNBKCDIH();
		int num = ((list != null) ? list.Count : 0);
		string arg = CMDKIHPAGPL();
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		stringBuilder2.Append(string.Format("INSERT INTO {0} ('facebookId','name','level','teamId','badge','score','teamName','nickName', 'clScore') VALUES ", arg));
		bool flag = false;
		bool flag2 = false;
		foreach (KeyValuePair<string, string> item in GAGDOGJGNDI)
		{
			bool flag3 = false;
			string text = item.Value.Replace("'", "''");
			for (int i = 0; i < num; i++)
			{
				if (list[i].EHNKLBBAKCA.Equals(item.Key))
				{
					flag3 = true;
					flag = true;
					stringBuilder.Append(string.Format("UPDATE {0} SET name = '{1}' WHERE facebookId={2};", arg, text, item.Key));
				}
			}
			if (!flag3)
			{
				flag2 = true;
				stringBuilder2.Append(string.Format("('{0}','{1}',{2},{3},'{4}',{5},'{6}','{7}',{8}),", item.Key, text, 0, -1, string.Empty, 0, string.Empty, string.Empty, 0));
			}
		}
		if (flag)
		{
			OMBKLCBCMGP(stringBuilder.ToString());
		}
		if (flag2)
		{
			string text2 = stringBuilder2.ToString();
			text2 = text2.Substring(0, text2.Length - 1);
			text2 += ";";
			OMBKLCBCMGP(text2);
		}
	}

	public void IPALLACDGFF(List<FriendScore> EMAHLNKGLMC)
	{
		int count = EMAHLNKGLMC.Count;
		if (count >= 1)
		{
			string text = string.Empty;
			string arg = CMDKIHPAGPL();
			for (int i = 0; i < count; i++)
			{
				text += string.Format("UPDATE {0} SET score = {1} WHERE facebookId='{2}';", arg, EMAHLNKGLMC[i].score, EMAHLNKGLMC[i].facebookId);
			}
			OMBKLCBCMGP(text);
		}
	}

	public void ADIMEEPIFBL(GetFacebookLeaderboardResponseMessage OMJOIIOONMO)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(string.Format("INSERT OR REPLACE INTO {0} ('id','facebookId','level','teamId','badge','score','teamName','nickName','clScore','name') VALUES", CMDKIHPAGPL()));
		for (int i = 0; i < OMJOIIOONMO.leaderboard.Count; i++)
		{
			FacebookLeaderboardEntry facebookLeaderboardEntry = OMJOIIOONMO.leaderboard[i];
			string text = facebookLeaderboardEntry.teamName.Replace("'", "''");
			string text2 = facebookLeaderboardEntry.nickname.Replace("'", "''");
			stringBuilder.Append(string.Format("( (SELECT id from {0} where facebookId='{1}') ,'{1}',{2},{3},'{4}',{5},'{6}','{7}',{8},(SELECT name from {0} WHERE facebookId='{1}')) ", CMDKIHPAGPL(), facebookLeaderboardEntry.facebookId, facebookLeaderboardEntry.level, facebookLeaderboardEntry.teamId, facebookLeaderboardEntry.badge, facebookLeaderboardEntry.score, text, text2, facebookLeaderboardEntry.clScore));
			if (i < OMJOIIOONMO.leaderboard.Count - 1)
			{
				stringBuilder.Append(",");
			}
		}
		stringBuilder.Append(";");
		OMBKLCBCMGP(stringBuilder.ToString());
	}

	private void KMPGBIKPKOO()
	{
		string nGKFCKIHIPE = string.Format("PRAGMA table_info({0})", CMDKIHPAGPL());
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(nGKFCKIHIPE);
		if (mBBJJJGFIKD != null)
		{
			if (mBBJJJGFIKD.DFOGCCJCNJJ.Count == 7)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Leaderboard, "Migrated from old Leaderboard Database. This table has teamname column!");
				string nGKFCKIHIPE2 = string.Format("ALTER TABLE {0} ADD COLUMN teamName TEXT;", CMDKIHPAGPL());
				OMBKLCBCMGP(nGKFCKIHIPE2);
				string nGKFCKIHIPE3 = string.Format("ALTER TABLE {0} ADD COLUMN nickName TEXT;", CMDKIHPAGPL());
				OMBKLCBCMGP(nGKFCKIHIPE3);
			}
			if (mBBJJJGFIKD.DFOGCCJCNJJ.Count == 7 || mBBJJJGFIKD.DFOGCCJCNJJ.Count == 9)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.InboxDao, "Migrated from old Inbox Database. This table has clScore column!");
				string nGKFCKIHIPE4 = string.Format("ALTER TABLE {0} ADD COLUMN clScore INTEGER NOT NULL DEFAULT(0);", CMDKIHPAGPL());
				OMBKLCBCMGP(nGKFCKIHIPE4);
			}
		}
	}

	protected override string CMDKIHPAGPL()
	{
		return "Leaderboard";
	}

	protected override object[] BMKKJMIKDPO(IENHAKEMDPM LLIEHCKNJEM)
	{
		return new object[10]
		{
			LLIEHCKNJEM.AIAEHPLOFGB(),
			LLIEHCKNJEM.EHNKLBBAKCA,
			LLIEHCKNJEM.PNGPLGHKFDI,
			LLIEHCKNJEM.KOPMPMIFHNF,
			LLIEHCKNJEM.OADDPGNIINO,
			LLIEHCKNJEM.FGPGOGEKDAM,
			LLIEHCKNJEM.DJADMBLKBKJ,
			LLIEHCKNJEM.EFHEIFMEJCN,
			LLIEHCKNJEM.KJACEODCOHN,
			LLIEHCKNJEM.GGBEMNJNAEE
		};
	}

	protected override string MCPNNIHODDL()
	{
		return "CREATE TABLE IF NOT EXISTS `" + CMDKIHPAGPL() + "` (\n\t`id`\tINTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,\n\t`facebookId`\tTEXT NOT NULL,\n\t`name`\tTEXT NOT NULL,\n\t`level`\tINTEGER NOT NULL,\n\t`teamId`\tINTEGER NOT NULL,\n\t`badge`\tTEXT NOT NULL,\n\t`score`\tINTEGER NOT NULL,\n\t`teamName` TEXT NOT NULL,\n\t`nickName` TEXT NOT NULL,\n\t`clScore` INTEGER NOT NULL DEFAULT(0)\n);";
	}

	protected override Dictionary<string, object> FHIBIOKHLNE(IENHAKEMDPM LLIEHCKNJEM)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary["facebookId"] = LLIEHCKNJEM.EHNKLBBAKCA;
		dictionary["name"] = LLIEHCKNJEM.PNGPLGHKFDI;
		dictionary["level"] = LLIEHCKNJEM.KOPMPMIFHNF;
		dictionary["teamId"] = LLIEHCKNJEM.OADDPGNIINO;
		dictionary["badge"] = LLIEHCKNJEM.FGPGOGEKDAM;
		dictionary["score"] = LLIEHCKNJEM.DJADMBLKBKJ;
		dictionary["teamName"] = LLIEHCKNJEM.EFHEIFMEJCN;
		dictionary["nickName"] = LLIEHCKNJEM.KJACEODCOHN;
		dictionary["clScore"] = LLIEHCKNJEM.GGBEMNJNAEE;
		return dictionary;
	}

	protected override IENHAKEMDPM EOPGEOIHOAM(DCMNFAKJKCH BCAKHCNOKDH)
	{
		object value;
		BCAKHCNOKDH.TryGetValue("id", out value);
		object value2;
		BCAKHCNOKDH.TryGetValue("facebookId", out value2);
		object value3;
		BCAKHCNOKDH.TryGetValue("name", out value3);
		object value4;
		BCAKHCNOKDH.TryGetValue("level", out value4);
		object value5;
		BCAKHCNOKDH.TryGetValue("teamId", out value5);
		object value6;
		BCAKHCNOKDH.TryGetValue("badge", out value6);
		object value7;
		BCAKHCNOKDH.TryGetValue("score", out value7);
		object value8;
		BCAKHCNOKDH.TryGetValue("teamName", out value8);
		object value9;
		BCAKHCNOKDH.TryGetValue("nickName", out value9);
		object value10;
		BCAKHCNOKDH.TryGetValue("clScore", out value10);
		return new IENHAKEMDPM((int?)value, (string)value2, (string)value3, (int)value4, (int)value5, (string)value6, (int)value7, (string)value8, (string)value9, (int)value10);
	}

	public void ENGGNDDFFOI(SocialHelper JANPCBNIGFG)
	{
		BAFBKBIKHKC();
		if (JANPCBNIGFG != null && JANPCBNIGFG.CurrentSession != null && JANPCBNIGFG.CurrentSession.COPDAKACHFM != null)
		{
			DIJBPMMKPAE(JANPCBNIGFG.CurrentSession.COPDAKACHFM);
		}
	}

	public void BAFBKBIKHKC()
	{
		if (!LECPGNKOABP.GABGKBAKHDP.BJLBIBDKADC())
		{
			return;
		}
		string text = LECPGNKOABP.GABGKBAKHDP.LEOJICDDHHF ?? " ";
		string kJACEODCOHN = LECPGNKOABP.GABGKBAKHDP.KJACEODCOHN ?? string.Empty;
		int num = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC();
		string text2 = LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA;
		int num2 = 0;
		IDFPAFEJPPH iDFPAFEJPPH = IDFPAFEJPPH.GABGKBAKHDP;
		if (iDFPAFEJPPH.HGNJBHGBLIN)
		{
			num2 = iDFPAFEJPPH.PDGLECFDLJJ;
		}
		string nGKFCKIHIPE = string.Format("select * from {0} where facebookId={1}", CMDKIHPAGPL(), text2);
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(nGKFCKIHIPE);
		if (mBBJJJGFIKD == null || mBBJJJGFIKD.DFOGCCJCNJJ.Count == 0)
		{
			IENHAKEMDPM iENHAKEMDPM = new IENHAKEMDPM(null, text2, text, num, -1, "none", 0, string.Empty, string.Empty);
			iENHAKEMDPM.KJACEODCOHN = kJACEODCOHN;
			iENHAKEMDPM.GGBEMNJNAEE = num2;
			IENHAKEMDPM lLIEHCKNJEM = iENHAKEMDPM;
			LFHHPPDJGDC(lLIEHCKNJEM);
			return;
		}
		IENHAKEMDPM iENHAKEMDPM2 = EOPGEOIHOAM(mBBJJJGFIKD.DFOGCCJCNJJ[0]);
		iENHAKEMDPM2.PNGPLGHKFDI = text;
		iENHAKEMDPM2.KOPMPMIFHNF = num;
		iENHAKEMDPM2.KJACEODCOHN = kJACEODCOHN;
		if (iENHAKEMDPM2.GGBEMNJNAEE < num2)
		{
			iENHAKEMDPM2.GGBEMNJNAEE = num2;
		}
		GDFHLDAKIOM(iENHAKEMDPM2);
	}

	public void DIJBPMMKPAE(DKBEJLGEAOA IIIMBFFNNBN)
	{
		if (!LECPGNKOABP.GABGKBAKHDP.BJLBIBDKADC())
		{
			return;
		}
		string nGKFCKIHIPE = string.Format("SELECT * FROM {0} WHERE facebookId={1}", CMDKIHPAGPL(), LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA);
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(nGKFCKIHIPE);
		if (mBBJJJGFIKD != null && mBBJJJGFIKD.DFOGCCJCNJJ.Count != 0)
		{
			IENHAKEMDPM iENHAKEMDPM = EOPGEOIHOAM(mBBJJJGFIKD.DFOGCCJCNJJ[0]);
			if (IIIMBFFNNBN != null)
			{
				iENHAKEMDPM.OADDPGNIINO = (int)IIIMBFFNNBN.EEFMIHDPJPG;
				iENHAKEMDPM.EFHEIFMEJCN = IIIMBFFNNBN.PNGPLGHKFDI;
				iENHAKEMDPM.FGPGOGEKDAM = IIIMBFFNNBN.FGPGOGEKDAM;
			}
			else
			{
				iENHAKEMDPM.OADDPGNIINO = -1;
				iENHAKEMDPM.EFHEIFMEJCN = string.Empty;
				iENHAKEMDPM.FGPGOGEKDAM = string.Empty;
			}
			GDFHLDAKIOM(iENHAKEMDPM);
		}
	}
}
