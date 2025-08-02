using System;
using System.IO;
using System.Runtime.CompilerServices;
using ProtoBuf;
using UnityEngine;
using caravan.protobuf.messages;

public class IHMNJDMKMCN
{
	private const string KONHMDICBNE = "badwords.dat";

	private const string GBLFBOKGMIG = "Config/badwords";

	private static int NIIKGEGLLNC = 40;

	private static string MNMGKHELBKP;

	[CompilerGenerated]
	private static Action<RemoteConfigData> JANLDOMIIEF;

	public static void DIOELAHNLKJ()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.BadWordController, "BadWordController Inited");
		MNMGKHELBKP = Path.Combine(Application.persistentDataPath, "badwords.dat");
		IBKHFKAANJP iBKHFKAANJP = IBKHFKAANJP.DGGDDILJFBJ();
		RemoteConfigData remoteConfigData = null;
		TextAsset textAsset = Resources.Load("Config/badwords") as TextAsset;
		if (textAsset.bytes.Length != 0)
		{
			using (MemoryStream source = new MemoryStream(textAsset.bytes))
			{
				remoteConfigData = KIHMBFDKLJM.GABGKBAKHDP.BGGEDOONAPL.DeserializeWithLengthPrefix(source, null, typeof(RemoteConfigData), PrefixStyle.Fixed32BigEndian, 2) as RemoteConfigData;
				NIIKGEGLLNC = remoteConfigData.version;
			}
		}
		Resources.UnloadAsset(textAsset);
		RemoteConfigData remoteConfigData2 = ENEPOBDEKFN();
		if (remoteConfigData2 != null && remoteConfigData2.version > NIIKGEGLLNC && iBKHFKAANJP.DCLMPEPDNKJ(remoteConfigData2.jsonData))
		{
			remoteConfigData = remoteConfigData2;
			NIIKGEGLLNC = remoteConfigData2.version;
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.BadWordController, "Current version is:" + NIIKGEGLLNC);
		iBKHFKAANJP.DCLMPEPDNKJ(remoteConfigData.jsonData);
		new DDBKKIGOCLO(CBNMJCLPKPB.OCFMGFNKMMA, NIIKGEGLLNC, DOMGBDDFFJA).GJIMJIJCBLC();
	}

	private static void DOMGBDDFFJA(RemoteConfigData MBBPBGHKLJM)
	{
		if (MBBPBGHKLJM != null && NIIKGEGLLNC < MBBPBGHKLJM.version)
		{
			NIIKGEGLLNC = MBBPBGHKLJM.version;
			NKBKEGOGNDN(MBBPBGHKLJM);
			IBKHFKAANJP.DGGDDILJFBJ().DCLMPEPDNKJ(MBBPBGHKLJM.jsonData);
		}
	}

	private static void NKBKEGOGNDN(RemoteConfigData MBBPBGHKLJM)
	{
		if (File.Exists(MNMGKHELBKP))
		{
			File.Delete(MNMGKHELBKP);
		}
		using (FileStream dest = new FileStream(MNMGKHELBKP, FileMode.OpenOrCreate))
		{
			KIHMBFDKLJM.GABGKBAKHDP.BGGEDOONAPL.SerializeWithLengthPrefix(dest, MBBPBGHKLJM, typeof(RemoteConfigData), PrefixStyle.Fixed32BigEndian, 2);
		}
	}

	private static RemoteConfigData ENEPOBDEKFN()
	{
		if (!File.Exists(MNMGKHELBKP))
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.BadWordController, "There is no downloaded bad word list!");
			return null;
		}
		using (FileStream source = new FileStream(MNMGKHELBKP, FileMode.Open))
		{
			try
			{
				return KIHMBFDKLJM.GABGKBAKHDP.BGGEDOONAPL.DeserializeWithLengthPrefix(source, null, typeof(RemoteConfigData), PrefixStyle.Fixed32BigEndian, 2) as RemoteConfigData;
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.BadWordController, "Can not read sales data from file system: {0}", ex);
			}
		}
		return null;
	}
}
