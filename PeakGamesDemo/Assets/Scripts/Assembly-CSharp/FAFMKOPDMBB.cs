using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using DAO.Entity;
using UnityEngine;

public class FAFMKOPDMBB : global::JEDMENFBGJI<InboxEntity>
{
	public FAFMKOPDMBB()
	{
		KMPGBIKPKOO();
	}

	public void APNJAPLPHMB(string CCKEDMJMOJD)
	{
		try
		{
			string path = Path.Combine(Application.persistentDataPath, CCKEDMJMOJD + ".dat");
			if (File.Exists(path))
			{
				File.Delete(path);
			}
			List<InboxEntity> list = DFJBKKHAGNC();
			if (list == null || list.Count == 0)
			{
				return;
			}
			using (FileStream serializationStream = new FileStream(path, FileMode.Create))
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				binaryFormatter.Serialize(serializationStream, list);
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.InboxDao, "Inbox Dao Save to local file Error:{0} Stack:{1}", ex.Message, ex.StackTrace);
		}
	}

	public void EOCDBIHEMJM(string CCKEDMJMOJD)
	{
		string path = Path.Combine(Application.persistentDataPath, CCKEDMJMOJD + ".dat");
		if (!File.Exists(path))
		{
			return;
		}
		List<InboxEntity> list;
		using (FileStream serializationStream = new FileStream(path, FileMode.Open))
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			list = (List<InboxEntity>)binaryFormatter.Deserialize(serializationStream);
		}
		if (list != null && list.Count > 0)
		{
			int count = list.Count;
			for (int i = 0; i < count; i++)
			{
				BJNFGAFBCGJ(list[i]);
			}
			File.Delete(path);
		}
	}

	public int IEIHCCBMPPG(int GIFJMKBDAIO)
	{
		string nGKFCKIHIPE = string.Format("Select COUNT(*) From {0} WHERE type={1}", CMDKIHPAGPL(), GIFJMKBDAIO);
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(nGKFCKIHIPE);
		if (mBBJJJGFIKD == null || mBBJJJGFIKD.DFOGCCJCNJJ.Count == 0)
		{
			return 0;
		}
		return (int)mBBJJJGFIKD.DFOGCCJCNJJ[0].ECNCPJGHBIG("COUNT(*)");
	}

	public int ELEKFHDLKJJ()
	{
		string nGKFCKIHIPE = string.Format("Select COUNT(*) From {0}", CMDKIHPAGPL());
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(nGKFCKIHIPE);
		if (mBBJJJGFIKD == null || mBBJJJGFIKD.DFOGCCJCNJJ.Count == 0)
		{
			return 0;
		}
		return (int)mBBJJJGFIKD.DFOGCCJCNJJ[0].ECNCPJGHBIG("COUNT(*)");
	}

	private int MMJOGFCBCCJ(string DLALMJPFFMK, long DIKEGACKFFH)
	{
		string nGKFCKIHIPE = string.Format("select COUNT(*) from {0} WHERE messageId='{1}' and fromId={2}", CMDKIHPAGPL(), DLALMJPFFMK, DIKEGACKFFH);
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(nGKFCKIHIPE);
		if (mBBJJJGFIKD == null || mBBJJJGFIKD.DFOGCCJCNJJ.Count == 0)
		{
			return 0;
		}
		return (int)mBBJJJGFIKD.DFOGCCJCNJJ[0].ECNCPJGHBIG("COUNT(*)");
	}

	public List<InboxEntity> DFJBKKHAGNC()
	{
		string nGKFCKIHIPE = string.Format("select * from {0} order by id ASC", CMDKIHPAGPL());
		return LIGBBHCFEIJ(nGKFCKIHIPE);
	}

	public void ALKGJAOMMNC(int? BDKFNEDHAOJ)
	{
		ODIPOJCEPEJ(string.Format("delete from {0} where id={1}", CMDKIHPAGPL(), BDKFNEDHAOJ));
	}

	public void NOIIEHLLENG(int NBFBPNNEKMN)
	{
		ODIPOJCEPEJ(string.Format("delete from {0} where type={1}", CMDKIHPAGPL(), NBFBPNNEKMN));
	}

	public bool HLHCFJJPPBK(string LLAEDBFNCCP, string DLALMJPFFMK, long DIKEGACKFFH, int NBFBPNNEKMN)
	{
		if (MMJOGFCBCCJ(DLALMJPFFMK, DIKEGACKFFH) > 0)
		{
			return false;
		}
		LFHHPPDJGDC(new InboxEntity(null, LLAEDBFNCCP, DLALMJPFFMK, (int)DIKEGACKFFH, NBFBPNNEKMN));
		return true;
	}

	protected override string CMDKIHPAGPL()
	{
		return "InboxEntries";
	}

	protected override object[] BMKKJMIKDPO(InboxEntity LLIEHCKNJEM)
	{
		return new object[5]
		{
			LLIEHCKNJEM.AIAEHPLOFGB(),
			LLIEHCKNJEM.From,
			LLIEHCKNJEM.MessageId,
			LLIEHCKNJEM.FromId,
			LLIEHCKNJEM.Type
		};
	}

	private void KMPGBIKPKOO()
	{
		string nGKFCKIHIPE = string.Format("PRAGMA table_info({0})", CMDKIHPAGPL());
		MBBJJJGFIKD mBBJJJGFIKD = ODIPOJCEPEJ(nGKFCKIHIPE);
		if (mBBJJJGFIKD != null)
		{
			if (mBBJJJGFIKD.DFOGCCJCNJJ.Count == 2)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.InboxDao, "Migrated from old Inbox Database. This table has messageId column!");
				string nGKFCKIHIPE2 = string.Format("ALTER TABLE {0} ADD COLUMN messageId TEXT;", CMDKIHPAGPL());
				OMBKLCBCMGP(nGKFCKIHIPE2);
			}
			if (mBBJJJGFIKD.DFOGCCJCNJJ.Count == 2 || mBBJJJGFIKD.DFOGCCJCNJJ.Count == 3)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.InboxDao, "Migrated from old Inbox Database. This table has fromId column!");
				string nGKFCKIHIPE3 = string.Format("ALTER TABLE {0} ADD COLUMN fromId INTEGER NOT NULL DEFAULT(0);", CMDKIHPAGPL());
				OMBKLCBCMGP(nGKFCKIHIPE3);
			}
			if (mBBJJJGFIKD.DFOGCCJCNJJ.Count == 2 || mBBJJJGFIKD.DFOGCCJCNJJ.Count == 3 || mBBJJJGFIKD.DFOGCCJCNJJ.Count == 4)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.InboxDao, "Migrated from old Inbox Database. This table has type column!");
				string nGKFCKIHIPE4 = string.Format("ALTER TABLE {0} ADD COLUMN type INTEGER DEFAULT(0);", CMDKIHPAGPL());
				OMBKLCBCMGP(nGKFCKIHIPE4);
			}
		}
	}

	protected override string MCPNNIHODDL()
	{
		return "CREATE TABLE IF NOT EXISTS `" + CMDKIHPAGPL() + "` (\n                `id`\tINTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,\n                `from`\t TEXT NOT NULL,                \n                `messageId`\t TEXT,\n                `fromId` INTEGER,\n                `type` INTEGER\n                );";
	}

	protected override Dictionary<string, object> FHIBIOKHLNE(InboxEntity LLIEHCKNJEM)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary["from"] = LLIEHCKNJEM.From;
		dictionary["messageId"] = LLIEHCKNJEM.MessageId;
		dictionary["fromId"] = LLIEHCKNJEM.FromId;
		dictionary["type"] = LLIEHCKNJEM.Type;
		return dictionary;
	}

	protected override InboxEntity EOPGEOIHOAM(DCMNFAKJKCH BCAKHCNOKDH)
	{
		object value;
		BCAKHCNOKDH.TryGetValue("id", out value);
		object value2;
		BCAKHCNOKDH.TryGetValue("from", out value2);
		object value3;
		BCAKHCNOKDH.TryGetValue("messageId", out value3);
		object value4;
		BCAKHCNOKDH.TryGetValue("fromId", out value4);
		object value5;
		BCAKHCNOKDH.TryGetValue("type", out value5);
		return new InboxEntity((int)value, (string)value2, (string)value3, (int)value4, (int)value5);
	}
}
