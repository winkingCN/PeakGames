using System.Collections.Generic;
using System.Text;
using caravan.protobuf.messages;

public class IONAGMPHNPM : global::JEDMENFBGJI<JJHJHJFNCGC>
{
	private static IONAGMPHNPM KNPOFJNFLJB;

	public static IONAGMPHNPM GABGKBAKHDP
	{
		get
		{
			return KNPOFJNFLJB ?? (KNPOFJNFLJB = new IONAGMPHNPM());
		}
	}

	public void DAKGKAMIOCA()
	{
		string nGKFCKIHIPE = string.Format("UPDATE {0} SET lastStarCount = currentStarCount;", CMDKIHPAGPL());
		ODIPOJCEPEJ(nGKFCKIHIPE);
	}

	public JJHJHJFNCGC LJBNEEGOBMD(long GCKOBKBPOBE)
	{
		string nGKFCKIHIPE = string.Format("SELECT * FROM {0} WHERE userId = {1};", CMDKIHPAGPL(), -GCKOBKBPOBE);
		return PEFIHEFDOIE(nGKFCKIHIPE);
	}

	public List<JJHJHJFNCGC> MEGIIEPGOCC(int GCKOBKBPOBE)
	{
		string nGKFCKIHIPE = string.Format("SELECT * FROM {0} WHERE userId <> {1} ORDER BY currentStarCount DESC;", CMDKIHPAGPL(), -GCKOBKBPOBE);
		return LIGBBHCFEIJ(nGKFCKIHIPE);
	}

	public void NHIJCBKNMKG(TcStatusResponseMessage OMJOIIOONMO)
	{
		JJHJHJFNCGC jJHJHJFNCGC = LJBNEEGOBMD(OMJOIIOONMO.eventId);
		if (jJHJHJFNCGC == null)
		{
			CEHLEFDNPLL(OMJOIIOONMO);
			return;
		}
		int lMJPNCDFAPH = jJHJHJFNCGC.LMJPNCDFAPH;
		CEHLEFDNPLL(OMJOIIOONMO);
		DMKAAJPJPEF(-OMJOIIOONMO.eventId, lMJPNCDFAPH, OMJOIIOONMO.progress, OMJOIIOONMO.status);
	}

	public void FKOCNEMAAAP(long BPKJLGJDFKG, long GCKOBKBPOBE, int MFFLPDALICD)
	{
		string nGKFCKIHIPE = string.Format("Update {0} set currentStarCount = currentStarCount + {1} where userId = {2} OR userId = {3};", CMDKIHPAGPL(), MFFLPDALICD, BPKJLGJDFKG, -GCKOBKBPOBE);
		OMBKLCBCMGP(nGKFCKIHIPE);
	}

	public void GFEMAOFEIEH(long BPKJLGJDFKG, int ODCADGABBHJ)
	{
		string nGKFCKIHIPE = string.Format("Update {0} set status = {1} where userId = {2};", CMDKIHPAGPL(), ODCADGABBHJ, BPKJLGJDFKG);
		OMBKLCBCMGP(nGKFCKIHIPE);
	}

	public void MHBOHLJEBOE(long BPKJLGJDFKG, string FBKDKPCDMMK)
	{
		string nGKFCKIHIPE = string.Format("Update {0} set nickName = '{1}' where userId = {2};", CMDKIHPAGPL(), FBKDKPCDMMK.Replace("'", "''"), BPKJLGJDFKG);
		OMBKLCBCMGP(nGKFCKIHIPE);
	}

	private void DMKAAJPJPEF(long BPKJLGJDFKG, int HCGGHECHHBO, int KHJENCJIGBI, int ODCADGABBHJ)
	{
		string nGKFCKIHIPE = string.Format("Update {0} set lastStarCount = {1}, currentStarCount = {2}, status = {3} where userId = {4};", CMDKIHPAGPL(), HCGGHECHHBO, KHJENCJIGBI, ODCADGABBHJ, BPKJLGJDFKG);
		OMBKLCBCMGP(nGKFCKIHIPE);
	}

	private void CEHLEFDNPLL(TcStatusResponseMessage OMJOIIOONMO)
	{
		BBGLCADIONK();
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("INSERT INTO ");
		stringBuilder.Append(CMDKIHPAGPL());
		stringBuilder.Append(" ('userId', 'nickName', 'lastStarCount', 'currentStarCount', 'status') VALUES  ");
		stringBuilder.Append(" (");
		stringBuilder.Append(-OMJOIIOONMO.eventId);
		stringBuilder.Append(", '");
		stringBuilder.Append(OMJOIIOONMO.teamInfo.name.Replace("'", "''"));
		stringBuilder.Append("', ");
		stringBuilder.Append(OMJOIIOONMO.progress);
		stringBuilder.Append(", ");
		stringBuilder.Append(OMJOIIOONMO.progress);
		stringBuilder.Append(", ");
		stringBuilder.Append(OMJOIIOONMO.status);
		stringBuilder.Append(" )");
		int i = 0;
		int count;
		for (count = OMJOIIOONMO.teamMembers.Count; i < count; i++)
		{
			TeamMemberInfo teamMemberInfo = OMJOIIOONMO.teamMembers[i];
			stringBuilder.Append(", (");
			stringBuilder.Append(teamMemberInfo.Id);
			stringBuilder.Append(", '");
			stringBuilder.Append(teamMemberInfo.nick.Replace("'", "''"));
			stringBuilder.Append("', ");
			stringBuilder.Append(0);
			stringBuilder.Append(", ");
			stringBuilder.Append(0);
			stringBuilder.Append(", ");
			stringBuilder.Append(0);
			stringBuilder.Append(" )");
		}
		OMBKLCBCMGP(stringBuilder.ToString());
		count = OMJOIIOONMO.chestMembers.Count;
		for (i = 0; i < count; i++)
		{
			TcMemberInfo tcMemberInfo = OMJOIIOONMO.chestMembers[i];
			DMKAAJPJPEF(tcMemberInfo.id, tcMemberInfo.progress, tcMemberInfo.progress, tcMemberInfo.claimed);
		}
	}

	protected override string CMDKIHPAGPL()
	{
		return "TeamChest";
	}

	protected override object[] BMKKJMIKDPO(JJHJHJFNCGC LLIEHCKNJEM)
	{
		return new object[6]
		{
			LLIEHCKNJEM.AIAEHPLOFGB(),
			LLIEHCKNJEM.GDMECFECCOM,
			LLIEHCKNJEM.KJACEODCOHN,
			LLIEHCKNJEM.LMJPNCDFAPH,
			LLIEHCKNJEM.INOKNDGFNLK,
			LLIEHCKNJEM.AEPLIGFCGIF
		};
	}

	protected override string MCPNNIHODDL()
	{
		return "CREATE TABLE IF NOT EXISTS `" + CMDKIHPAGPL() + "` (\n                `id`\t             INTEGER NOT NULL PRIMARY KEY,\n                `userId`             INTEGER NOT NULL,  \n                `nickName`           TEXT NOT NULL,              \n                `lastStarCount`      INTEGER NOT NULL,                \n                `currentStarCount`\t INTEGER NOT NULL,                \n                `status`\t         INTEGER\n                );";
	}

	protected override Dictionary<string, object> FHIBIOKHLNE(JJHJHJFNCGC LLIEHCKNJEM)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary["id"] = LLIEHCKNJEM.AIAEHPLOFGB();
		dictionary["userId"] = LLIEHCKNJEM.GDMECFECCOM;
		dictionary["nickName"] = LLIEHCKNJEM.KJACEODCOHN;
		dictionary["lastStarCount"] = LLIEHCKNJEM.LMJPNCDFAPH;
		dictionary["currentStarCount"] = LLIEHCKNJEM.INOKNDGFNLK;
		dictionary["status"] = LLIEHCKNJEM.AEPLIGFCGIF;
		return dictionary;
	}

	protected override JJHJHJFNCGC EOPGEOIHOAM(DCMNFAKJKCH BCAKHCNOKDH)
	{
		object value;
		BCAKHCNOKDH.TryGetValue("id", out value);
		object value2;
		BCAKHCNOKDH.TryGetValue("userId", out value2);
		object value3;
		BCAKHCNOKDH.TryGetValue("nickName", out value3);
		object value4;
		BCAKHCNOKDH.TryGetValue("lastStarCount", out value4);
		object value5;
		BCAKHCNOKDH.TryGetValue("currentStarCount", out value5);
		object value6;
		BCAKHCNOKDH.TryGetValue("status", out value6);
		return new JJHJHJFNCGC((int)value, (int)value2, (string)value3, (int)value4, (int)value5, (int)value6);
	}
}
