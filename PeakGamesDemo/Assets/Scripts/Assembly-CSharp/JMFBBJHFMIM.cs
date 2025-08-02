using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using BestHTTP;
using UnityEngine;

public class JMFBBJHFMIM
{
	[CompilerGenerated]
	private sealed class GPMELDHJNGH
	{
		internal string LOKMKDKABPI;

		internal string LNCBFPEKHDJ;

		internal string DFCJKBHFPMG;

		internal JMFBBJHFMIM PDAPIGLEPGC;

		internal void AGFNGEFDHLA(HTTPRequest MONIIALMCBH, HTTPResponse OMJOIIOONMO)
		{
			if (!PDAPIGLEPGC.EADBENKHBDJ.ContainsKey(LOKMKDKABPI))
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Cancelled purpose: {0}", LOKMKDKABPI);
				return;
			}
			GEDLICHBKMF gEDLICHBKMF = PDAPIGLEPGC.EADBENKHBDJ[LOKMKDKABPI];
			gEDLICHBKMF.IBEBJIBKGOC = null;
			if (OMJOIIOONMO == null)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Download failed due to network for purpose '{0}'", LOKMKDKABPI);
				PDAPIGLEPGC.EADBENKHBDJ.Remove(LOKMKDKABPI);
				return;
			}
			if (OMJOIIOONMO.StatusCode == 200)
			{
				try
				{
					string firstHeaderValue = OMJOIIOONMO.GetFirstHeaderValue("Content-Length");
					CDAKABCMLGA cDAKABCMLGA = new CDAKABCMLGA
					{
						DMAGNMIOAEJ = LOKMKDKABPI,
						BEBMJGNKAPG = LNCBFPEKHDJ,
						AMEDMLOCCBG = DFCJKBHFPMG,
						IKNGODJEKEA = int.Parse(firstHeaderValue),
						FOIACLCGMLF = FIBJIOBINHL.CFBJBKEPGAN().ToString()
					};
					FCJAAJLPCMB.GABGKBAKHDP.LFHHPPDJGDC(cDAKABCMLGA);
					string path = MBFMMIEMEBM(cDAKABCMLGA, true);
					if (File.Exists(path))
					{
						File.Delete(path);
					}
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Will download {0} bytes for  '{1}'", cDAKABCMLGA.IKNGODJEKEA, LOKMKDKABPI);
					(gEDLICHBKMF.LNEDKINAAOD = new NOFFPNBJBGC(cDAKABCMLGA, PDAPIGLEPGC.EADBENKHBDJ)).HIHNHAFDOOO();
					return;
				}
				catch (Exception ex)
				{
					GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Download, "An error occured during download purpose '{0}' due to {1}. Content-Length and Resume Support is mandatory for this downlaoder.", LOKMKDKABPI, ex);
					PDAPIGLEPGC.EADBENKHBDJ.Remove(LOKMKDKABPI);
					return;
				}
			}
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Download, "Response is not ok ({0}) for: {1}", OMJOIIOONMO.StatusCode, LNCBFPEKHDJ);
			PDAPIGLEPGC.EADBENKHBDJ.Remove(LOKMKDKABPI);
		}
	}

	private static string OJFDGICBHAP;

	private static JMFBBJHFMIM KNPOFJNFLJB;

	public Dictionary<string, GEDLICHBKMF> EADBENKHBDJ = new Dictionary<string, GEDLICHBKMF>();

	public static string PPENNIADOEL
	{
		get
		{
			return OJFDGICBHAP;
		}
	}

	public static JMFBBJHFMIM GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new JMFBBJHFMIM();
			}
			return KNPOFJNFLJB;
		}
	}

	private JMFBBJHFMIM()
	{
		OJFDGICBHAP = Application.persistentDataPath + "/CSDownloads";
		if (!Directory.Exists(OJFDGICBHAP))
		{
			Directory.CreateDirectory(OJFDGICBHAP);
		}
	}

	public bool FGEFBNBMOOE(string LOKMKDKABPI)
	{
		CDAKABCMLGA cDAKABCMLGA = FCJAAJLPCMB.GABGKBAKHDP.CMMLPKLDOHL(LOKMKDKABPI);
		return cDAKABCMLGA != null && cDAKABCMLGA.AEPLIGFCGIF == 2;
	}

	public void DBIBKMMPJBM(string LOKMKDKABPI)
	{
		if (EADBENKHBDJ.ContainsKey(LOKMKDKABPI))
		{
			return;
		}
		CDAKABCMLGA cDAKABCMLGA = FCJAAJLPCMB.GABGKBAKHDP.CMMLPKLDOHL(LOKMKDKABPI);
		if (cDAKABCMLGA != null)
		{
			string path = MBFMMIEMEBM(cDAKABCMLGA);
			string path2 = MBFMMIEMEBM(cDAKABCMLGA, true);
			FCJAAJLPCMB.GABGKBAKHDP.IKIOFOOBHDM(cDAKABCMLGA);
			if (File.Exists(path))
			{
				File.Delete(path);
			}
			if (File.Exists(path2))
			{
				File.Delete(path2);
			}
		}
	}

	public bool DKNOFPLNNLI(string LOKMKDKABPI, string LNCBFPEKHDJ, string DFCJKBHFPMG)
	{
		if (EADBENKHBDJ.ContainsKey(LOKMKDKABPI))
		{
			GEDLICHBKMF gEDLICHBKMF = EADBENKHBDJ[LOKMKDKABPI];
			if (gEDLICHBKMF.HIBNMJBJEBI.AMEDMLOCCBG.Equals(DFCJKBHFPMG))
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Download already in progress for purpose '{0}'", LOKMKDKABPI);
				return true;
			}
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Download in progress for purpose '{0}' will be cancelled due to new version download.", LOKMKDKABPI);
			gEDLICHBKMF.HIBNMJBJEBI = new LJNCMANOJMB
			{
				ABCGDHBOFGG = LNCBFPEKHDJ,
				AMEDMLOCCBG = DFCJKBHFPMG,
				DMAGNMIOAEJ = LOKMKDKABPI
			};
			return true;
		}
		LJNCMANOJMB oLLJFDNPFMH = default(LJNCMANOJMB);
		oLLJFDNPFMH.ABCGDHBOFGG = LNCBFPEKHDJ;
		oLLJFDNPFMH.AMEDMLOCCBG = DFCJKBHFPMG;
		oLLJFDNPFMH.DMAGNMIOAEJ = LOKMKDKABPI;
		GEDLICHBKMF value = new GEDLICHBKMF(oLLJFDNPFMH);
		EADBENKHBDJ[LOKMKDKABPI] = value;
		CDAKABCMLGA cDAKABCMLGA = FCJAAJLPCMB.GABGKBAKHDP.CMMLPKLDOHL(LOKMKDKABPI);
		if (cDAKABCMLGA == null)
		{
			IEJEOJLEJGM(LOKMKDKABPI, LNCBFPEKHDJ, DFCJKBHFPMG);
			return true;
		}
		if (cDAKABCMLGA.AMEDMLOCCBG.Equals(DFCJKBHFPMG))
		{
			if (cDAKABCMLGA.AEPLIGFCGIF == 2)
			{
				EADBENKHBDJ.Remove(LOKMKDKABPI);
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Already downloaded purpose '{0}' for version '{1}'", LOKMKDKABPI, DFCJKBHFPMG);
				return false;
			}
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Will resume purpose '{0}' for version '{1}'", LOKMKDKABPI, DFCJKBHFPMG);
			NOFFPNBJBGC nOFFPNBJBGC = new NOFFPNBJBGC(cDAKABCMLGA, EADBENKHBDJ);
			EADBENKHBDJ[LOKMKDKABPI].LNEDKINAAOD = nOFFPNBJBGC;
			nOFFPNBJBGC.HIHNHAFDOOO();
		}
		else
		{
			string path = MBFMMIEMEBM(cDAKABCMLGA, true);
			if (File.Exists(path))
			{
				File.Delete(path);
			}
			FCJAAJLPCMB.GABGKBAKHDP.IKIOFOOBHDM(cDAKABCMLGA);
			IEJEOJLEJGM(LOKMKDKABPI, LNCBFPEKHDJ, DFCJKBHFPMG);
		}
		return true;
	}

	public static string MBFMMIEMEBM(CDAKABCMLGA BEPNFPEIKAN, bool IFIKLFIDOKH = false)
	{
		return string.Format("{0}/{1}{2}", OJFDGICBHAP, BEPNFPEIKAN.DMAGNMIOAEJ, (!IFIKLFIDOKH) ? string.Empty : ".temp");
	}

	private void IEJEOJLEJGM(string LOKMKDKABPI, string LNCBFPEKHDJ, string DFCJKBHFPMG)
	{
		if (!EADBENKHBDJ.ContainsKey(LOKMKDKABPI))
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Cancelled head : {0}", LOKMKDKABPI);
			return;
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Will download for purpose '{0}' from url: {1}", LOKMKDKABPI, LNCBFPEKHDJ);
		HTTPRequest hTTPRequest = new HTTPRequest(new Uri(LNCBFPEKHDJ), HTTPMethods.Get, delegate(HTTPRequest MONIIALMCBH, HTTPResponse OMJOIIOONMO)
		{
			if (!EADBENKHBDJ.ContainsKey(LOKMKDKABPI))
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Cancelled purpose: {0}", LOKMKDKABPI);
			}
			else
			{
				GEDLICHBKMF gEDLICHBKMF = EADBENKHBDJ[LOKMKDKABPI];
				gEDLICHBKMF.IBEBJIBKGOC = null;
				if (OMJOIIOONMO == null)
				{
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Download failed due to network for purpose '{0}'", LOKMKDKABPI);
					EADBENKHBDJ.Remove(LOKMKDKABPI);
				}
				else
				{
					if (OMJOIIOONMO.StatusCode == 200)
					{
						try
						{
							string firstHeaderValue = OMJOIIOONMO.GetFirstHeaderValue("Content-Length");
							CDAKABCMLGA cDAKABCMLGA = new CDAKABCMLGA
							{
								DMAGNMIOAEJ = LOKMKDKABPI,
								BEBMJGNKAPG = LNCBFPEKHDJ,
								AMEDMLOCCBG = DFCJKBHFPMG,
								IKNGODJEKEA = int.Parse(firstHeaderValue),
								FOIACLCGMLF = FIBJIOBINHL.CFBJBKEPGAN().ToString()
							};
							FCJAAJLPCMB.GABGKBAKHDP.LFHHPPDJGDC(cDAKABCMLGA);
							string path = MBFMMIEMEBM(cDAKABCMLGA, true);
							if (File.Exists(path))
							{
								File.Delete(path);
							}
							GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Will download {0} bytes for  '{1}'", cDAKABCMLGA.IKNGODJEKEA, LOKMKDKABPI);
							(gEDLICHBKMF.LNEDKINAAOD = new NOFFPNBJBGC(cDAKABCMLGA, EADBENKHBDJ)).HIHNHAFDOOO();
							return;
						}
						catch (Exception ex)
						{
							GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Download, "An error occured during download purpose '{0}' due to {1}. Content-Length and Resume Support is mandatory for this downlaoder.", LOKMKDKABPI, ex);
							EADBENKHBDJ.Remove(LOKMKDKABPI);
							return;
						}
					}
					GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Download, "Response is not ok ({0}) for: {1}", OMJOIIOONMO.StatusCode, LNCBFPEKHDJ);
					EADBENKHBDJ.Remove(LOKMKDKABPI);
				}
			}
		});
		hTTPRequest.DisableCache = true;
		HTTPRequest hTTPRequest2 = hTTPRequest;
		EADBENKHBDJ[LOKMKDKABPI].IBEBJIBKGOC = hTTPRequest2;
		hTTPRequest2.Send();
	}

	public string BGCJPEAMBIP(string LOKMKDKABPI)
	{
		CDAKABCMLGA cDAKABCMLGA = FCJAAJLPCMB.GABGKBAKHDP.CMMLPKLDOHL(LOKMKDKABPI);
		if (cDAKABCMLGA == null || cDAKABCMLGA.AEPLIGFCGIF != 2)
		{
			return null;
		}
		return Application.persistentDataPath + "/CSDownloads/" + cDAKABCMLGA.DMAGNMIOAEJ;
	}

	public IEnumerator IOOJFNBMNDJ(Action<int, int> BPCKHIBCFKN, Action<bool> IMHLFAHONPP, params string[] KFBLIODHOLC)
	{
		if (KFBLIODHOLC == null)
		{
			if (BPCKHIBCFKN != null)
			{
				BPCKHIBCFKN(1, 1);
			}
			if (IMHLFAHONPP != null)
			{
				IMHLFAHONPP(false);
			}
			yield break;
		}
		int num;
		int num2;
		while (true)
		{
			num = 0;
			num2 = 0;
			bool flag = true;
			foreach (string lOKMKDKABPI in KFBLIODHOLC)
			{
				CDAKABCMLGA cDAKABCMLGA = FCJAAJLPCMB.GABGKBAKHDP.CMMLPKLDOHL(lOKMKDKABPI);
				if (cDAKABCMLGA == null)
				{
					flag = false;
					continue;
				}
				num2 += cDAKABCMLGA.BJMDAELAELI;
				num += cDAKABCMLGA.IKNGODJEKEA;
				if (cDAKABCMLGA.AEPLIGFCGIF != 2)
				{
					flag = false;
				}
				yield return null;
			}
			if (flag)
			{
				break;
			}
			if (num2 >= num)
			{
				num2 = num - 1;
			}
			if (num2 == 0 && num == 0)
			{
				num = 1;
			}
			if (BPCKHIBCFKN != null)
			{
				BPCKHIBCFKN(num2, num);
			}
			yield return null;
		}
		num2 = num;
		if (BPCKHIBCFKN != null)
		{
			BPCKHIBCFKN(num2, num);
		}
		if (IMHLFAHONPP != null)
		{
			IMHLFAHONPP(true);
		}
	}

	public void DMOHBEFHPFP(string AFHNACIFDLF = null)
	{
		List<GEDLICHBKMF> list = new List<GEDLICHBKMF>(EADBENKHBDJ.Values);
		for (int i = 0; i < list.Count; i++)
		{
			GEDLICHBKMF gEDLICHBKMF = list[i];
			if (gEDLICHBKMF != null && (AFHNACIFDLF == null || gEDLICHBKMF.HIBNMJBJEBI.DMAGNMIOAEJ.StartsWith(AFHNACIFDLF)))
			{
				HTTPRequest iBEBJIBKGOC = gEDLICHBKMF.IBEBJIBKGOC;
				if (iBEBJIBKGOC != null)
				{
					iBEBJIBKGOC.Abort();
				}
				if (gEDLICHBKMF.LNEDKINAAOD != null)
				{
					gEDLICHBKMF.LNEDKINAAOD.AKKKHGENAED(false);
				}
				else
				{
					EADBENKHBDJ.Remove(gEDLICHBKMF.HIBNMJBJEBI.DMAGNMIOAEJ);
				}
			}
		}
	}
}
