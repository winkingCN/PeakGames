using System;
using System.Collections;
using System.IO;
using UnityEngine;

public class IHHHNJOCAIF
{
	protected const float KMJDOGFCJNI = 70f;

	public bool CNOKCIMMADO;

	protected int MDEPHGIOAOL;

	protected string FDAKMBBCAGP;

	public IHHHNJOCAIF(string HMAGBFLKNIE)
	{
		FDAKMBBCAGP = HMAGBFLKNIE;
	}

	public IEnumerator BCDAPKBDDKA(string LCCKDPIBKPJ, string OKBDJEMBOPP, KOJOLKEIAHO LAGFIIMNEDO)
	{
		string text = Guid.NewGuid().ToString() + ".zip";
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("filename", text);
		wWWForm.AddField("crmId", OKBDJEMBOPP);
		wWWForm.AddBinaryData("log", File.ReadAllBytes(LCCKDPIBKPJ), LCCKDPIBKPJ, "text/plain");
		WWW wWW = new WWW(FDAKMBBCAGP, wWWForm);
		float num = Time.time + 70f;
		while (!(Time.time > num))
		{
			yield return null;
			if (wWW.isDone)
			{
				break;
			}
		}
		bool oDCADGABBHJ = wWW.isDone && string.IsNullOrEmpty(wWW.error);
		if (LAGFIIMNEDO != null)
		{
			LAGFIIMNEDO(oDCADGABBHJ, text);
		}
	}
}
