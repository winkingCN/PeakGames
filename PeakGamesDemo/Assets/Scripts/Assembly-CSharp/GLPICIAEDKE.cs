using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GLPICIAEDKE
{
	private class CLHMDEHEHNB
	{
		public readonly string EHNKLBBAKCA;

		public readonly Action<string, bool> CECMINAKHFJ;

		public readonly bool HAOHFJKKHBO;

		public CLHMDEHEHNB(string FAHBFGOFJGI, Action<string, bool> IMHLFAHONPP, bool JDODJIBJPFH)
		{
			EHNKLBBAKCA = FAHBFGOFJGI;
			CECMINAKHFJ = IMHLFAHONPP;
			HAOHFJKKHBO = JDODJIBJPFH;
		}

		public override bool Equals(object NEMEKIOEOLC)
		{
			CLHMDEHEHNB cLHMDEHEHNB = (CLHMDEHEHNB)NEMEKIOEOLC;
			return cLHMDEHEHNB != null && (this == NEMEKIOEOLC || EHNKLBBAKCA.Equals(cLHMDEHEHNB.EHNKLBBAKCA));
		}

		public override int GetHashCode()
		{
			return EHNKLBBAKCA.GetHashCode();
		}
	}

	private static LinkedList<CLHMDEHEHNB> FNDMAEKCBEM;

	private const int PNBDAGKFOBN = 100;

	public static string KAFGNAFBGJF;

	public static string IOGFDHHKEJA;

	private static bool HGPFMJCDJDN;

	public static bool AONKBLIBOCE(string LOKMKDKABPI)
	{
		if (KAFGNAFBGJF == null)
		{
			KAFGNAFBGJF = Path.Combine(Application.persistentDataPath, "FacebookImages/");
		}
		if (IOGFDHHKEJA == null)
		{
			IOGFDHHKEJA = Path.Combine(Application.persistentDataPath, "TempFacebookImages/");
		}
		return File.Exists(Path.Combine(KAFGNAFBGJF, LOKMKDKABPI)) || File.Exists(Path.Combine(IOGFDHHKEJA, LOKMKDKABPI));
	}

	public static void PGBBKNEAAPH()
	{
		if (IOGFDHHKEJA == null)
		{
			IOGFDHHKEJA = Path.Combine(Application.persistentDataPath, "TempFacebookImages/");
		}
		if (Directory.Exists(IOGFDHHKEJA))
		{
			string[] files = Directory.GetFiles(IOGFDHHKEJA);
			int num = files.Length;
			for (int i = 0; i < num; i++)
			{
				File.Delete(files[i]);
			}
		}
	}

	public static void NDIBOFJAFBJ()
	{
		if (KAFGNAFBGJF == null)
		{
			KAFGNAFBGJF = Path.Combine(Application.persistentDataPath, "FacebookImages/");
		}
		if (Directory.Exists(KAFGNAFBGJF))
		{
			string[] files = Directory.GetFiles(KAFGNAFBGJF);
			int num = files.Length;
			for (int i = 0; i < num; i++)
			{
				File.Delete(files[i]);
			}
		}
	}

	public static void DNOMDLMKDHP(string IGJEENPLFPB, Action<string, bool> IMHLFAHONPP, bool JDODJIBJPFH = false)
	{
		if (!Directory.Exists(KAFGNAFBGJF))
		{
			Directory.CreateDirectory(KAFGNAFBGJF);
		}
		if (!Directory.Exists(IOGFDHHKEJA))
		{
			Directory.CreateDirectory(IOGFDHHKEJA);
		}
		if (FNDMAEKCBEM == null)
		{
			FNDMAEKCBEM = new LinkedList<CLHMDEHEHNB>();
		}
		CLHMDEHEHNB cLHMDEHEHNB = new CLHMDEHEHNB(IGJEENPLFPB, IMHLFAHONPP, JDODJIBJPFH);
		if (!FNDMAEKCBEM.Contains(cLHMDEHEHNB))
		{
			if (cLHMDEHEHNB.EHNKLBBAKCA == LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA)
			{
				FNDMAEKCBEM.AddLast(cLHMDEHEHNB);
			}
			else
			{
				FNDMAEKCBEM.AddFirst(cLHMDEHEHNB);
			}
			if (!HGPFMJCDJDN)
			{
				HGPFMJCDJDN = true;
				GDGINCNCMDD();
			}
		}
	}

	private static void GDGINCNCMDD()
	{
		while (FNDMAEKCBEM.Count != 0)
		{
			try
			{
				CLHMDEHEHNB value = FNDMAEKCBEM.Last.Value;
				FNDMAEKCBEM.RemoveLast();
				string lOKMKDKABPI = DILKBHCCINN.FHKPGGMPOGL(value.EHNKLBBAKCA);
				string text = JMFBBJHFMIM.GABGKBAKHDP.BGCJPEAMBIP(lOKMKDKABPI);
				if (text == null || !File.Exists(text))
				{
					if (value.CECMINAKHFJ != null)
					{
						value.CECMINAKHFJ(value.EHNKLBBAKCA, false);
					}
					continue;
				}
				byte[] data = File.ReadAllBytes(text);
				Texture2D texture2D = new Texture2D(100, 100, TextureFormat.RGB24, false);
				texture2D.filterMode = FilterMode.Bilinear;
				Texture2D texture2D2 = texture2D;
				texture2D2.LoadImage(data);
				int num = Mathf.Min(texture2D2.width, texture2D2.height);
				int num2 = (int)((float)texture2D2.width / (float)num * 100f);
				int num3 = (int)((float)texture2D2.height / (float)num * 100f);
				texture2D2.FKMHHHBDDBF(num2, num3);
				int num4 = (int)((float)num2 * 0.5f);
				int num5 = (int)((float)num3 * 0.5f);
				int bNBIHIPNELH = num4 - 50;
				int dGCLNCKNIMA = num4 + 50;
				int oPACLHFAHLP = num5 - 50;
				int jAAFIIJCDPN = num5 + 50;
				int cAADAHCMGHG = (int)Mathf.Pow(50f, 2f);
				texture2D = new Texture2D(100, 100, TextureFormat.RGBA32, false);
				texture2D.filterMode = FilterMode.Bilinear;
				Texture2D texture2D3 = texture2D;
				JFJMIMFGMDA(texture2D2, texture2D3, bNBIHIPNELH, dGCLNCKNIMA, oPACLHFAHLP, jAAFIIJCDPN, num4, num5, cAADAHCMGHG);
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
				string path = Path.Combine(KAFGNAFBGJF, fileNameWithoutExtension);
				if (value.HAOHFJKKHBO)
				{
					path = Path.Combine(IOGFDHHKEJA, fileNameWithoutExtension);
				}
				File.WriteAllBytes(path, texture2D3.EncodeToPNG());
				JMFBBJHFMIM.GABGKBAKHDP.DBIBKMMPJBM(lOKMKDKABPI);
				UnityEngine.Object.Destroy(texture2D2);
				UnityEngine.Object.Destroy(texture2D3);
				if (value.CECMINAKHFJ != null)
				{
					value.CECMINAKHFJ(value.EHNKLBBAKCA, true);
				}
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.FacebookImageUtils, "Can not process image: {0}", ex.Message);
				HGPFMJCDJDN = false;
				return;
			}
		}
		HGPFMJCDJDN = false;
	}

	private static void JFJMIMFGMDA(Texture2D AMANAGEHKCM, Texture2D HHGEJGMJIDL, int BNBIHIPNELH, int DGCLNCKNIMA, int OPACLHFAHLP, int JAAFIIJCDPN, int NBICBOHFKLO, int PLOLDBCHDHK, int CAADAHCMGHG)
	{
		for (int i = OPACLHFAHLP; i < JAAFIIJCDPN; i++)
		{
			for (int j = BNBIHIPNELH; j < DGCLNCKNIMA; j++)
			{
				int num = j - NBICBOHFKLO;
				int num2 = i - PLOLDBCHDHK;
				int num3 = num * num + num2 * num2;
				Color color = ((num3 >= CAADAHCMGHG) ? new Color(1f, 1f, 1f, 0f) : AMANAGEHKCM.GetPixel(j, i));
				HHGEJGMJIDL.SetPixel(j - BNBIHIPNELH, i - OPACLHFAHLP, color);
			}
		}
		HHGEJGMJIDL.Apply(false);
	}

	public static string ODGJADGNMGD(string LOKMKDKABPI)
	{
		string text = Path.Combine(KAFGNAFBGJF, LOKMKDKABPI);
		if (File.Exists(text))
		{
			return text;
		}
		string text2 = Path.Combine(IOGFDHHKEJA, LOKMKDKABPI);
		return (!File.Exists(text2)) ? null : text2;
	}
}
