using System.IO;
using System.Threading;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.PeakAB.Pocos;
using BestHTTP;
using UnityEngine;

public class PELGLCFFOHN : BLBEENOGLAK
{
	public PELGLCFFOHN(Variant HOHDPCLDPEP)
		: base(HOHDPCLDPEP)
	{
	}

	protected override void GDGINCNCMDD(HTTPResponse OMJOIIOONMO)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AbTesting, "Process LevelProcessor in Background");
		ThreadPool.QueueUserWorkItem(state: new object[2]
		{
			OMJOIIOONMO,
			Application.persistentDataPath
		}, callBack: KCJDEFMDEOE);
	}

	private void KCJDEFMDEOE(object BGEDKGLJIGM)
	{
		object[] array = BGEDKGLJIGM as object[];
		HTTPResponse hTTPResponse = array[0] as HTTPResponse;
		string text = array[1] as string;
		string text2 = Path.Combine(text, "ablevels/");
		byte[] data = hTTPResponse.Data;
		string text3 = text + "/ablevels.zip";
		if (File.Exists(text3))
		{
			File.Delete(text3);
		}
		using (FileStream fileStream = new FileStream(text3, FileMode.OpenOrCreate))
		{
			byte[] array2 = data;
			foreach (byte value in array2)
			{
				fileStream.WriteByte(value);
			}
		}
		if (Directory.Exists(text2))
		{
			Directory.Delete(text2, true);
		}
		Directory.CreateDirectory(text2);
		ABMHGHAMFDH.MMHJJNIGKFD(text3, text2);
		LevelBuilder.HashABLevels(text);
		File.Delete(text3);
	}
}
