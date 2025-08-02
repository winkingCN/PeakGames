using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using BestHTTP;

public class NOFFPNBJBGC
{
	private readonly CDAKABCMLGA PCODNODNAHN;

	private readonly Dictionary<string, GEDLICHBKMF> LDKNKHLFHJA;

	private HTTPRequest IDFOAOKHJFM;

	public NOFFPNBJBGC(CDAKABCMLGA APKDPGDBNCC, Dictionary<string, GEDLICHBKMF> EIKBFHHFHNG)
	{
		if (!APKDPGDBNCC.AIAEHPLOFGB().HasValue || APKDPGDBNCC.IKNGODJEKEA == 0)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Download, "Passed download metadata is not ready to resume!");
		}
		PCODNODNAHN = APKDPGDBNCC;
		LDKNKHLFHJA = EIKBFHHFHNG;
	}

	public void HIHNHAFDOOO()
	{
		if (!LDKNKHLFHJA.ContainsKey(PCODNODNAHN.DMAGNMIOAEJ))
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Resume download cancelled: {0}", PCODNODNAHN.DMAGNMIOAEJ);
			return;
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Asking content for {0} from byte {1}", PCODNODNAHN.DMAGNMIOAEJ, PCODNODNAHN.BJMDAELAELI);
		IDFOAOKHJFM = new HTTPRequest(new Uri(PCODNODNAHN.BEBMJGNKAPG), HTTPMethods.Get, delegate(HTTPRequest MONIIALMCBH, HTTPResponse OMJOIIOONMO)
		{
			if (OMJOIIOONMO == null)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Response null. Server unreachable? Try again later.");
				LDKNKHLFHJA.Remove(PCODNODNAHN.DMAGNMIOAEJ);
			}
			else if (OMJOIIOONMO.StatusCode >= 200 && OMJOIIOONMO.StatusCode < 300)
			{
				DFLCEPGOGAN(MONIIALMCBH, OMJOIIOONMO);
			}
			else
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Download, "Unexpected response from server: {0}", OMJOIIOONMO.StatusCode);
				LDKNKHLFHJA.Remove(PCODNODNAHN.DMAGNMIOAEJ);
			}
		});
		IDFOAOKHJFM.SetRangeHeader(PCODNODNAHN.BJMDAELAELI, PCODNODNAHN.IKNGODJEKEA);
		IDFOAOKHJFM.UseStreaming = true;
		IDFOAOKHJFM.StreamFragmentSize = 65536;
		IDFOAOKHJFM.DisableCache = true;
		IDFOAOKHJFM.Send();
	}

	public void AKKKHGENAED(bool DLPNHOMMGGF = true)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Cancelling  download purpose {0}", PCODNODNAHN.DMAGNMIOAEJ);
		string path = JMFBBJHFMIM.MBFMMIEMEBM(PCODNODNAHN, true);
		LJNCMANOJMB hIBNMJBJEBI = LDKNKHLFHJA[PCODNODNAHN.DMAGNMIOAEJ].HIBNMJBJEBI;
		LDKNKHLFHJA.Remove(PCODNODNAHN.DMAGNMIOAEJ);
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		FCJAAJLPCMB.GABGKBAKHDP.IKIOFOOBHDM(PCODNODNAHN);
		IDFOAOKHJFM.Abort();
		if (DLPNHOMMGGF)
		{
			JMFBBJHFMIM.GABGKBAKHDP.DKNOFPLNNLI(PCODNODNAHN.DMAGNMIOAEJ, hIBNMJBJEBI.ABCGDHBOFGG, hIBNMJBJEBI.AMEDMLOCCBG);
		}
	}

	private void DFLCEPGOGAN(HTTPRequest MONIIALMCBH, HTTPResponse OMJOIIOONMO)
	{
		if (OMJOIIOONMO == null)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Download, "Response null. Server unreachable, or connection lost? Try again later.");
			LDKNKHLFHJA.Remove(PCODNODNAHN.DMAGNMIOAEJ);
			return;
		}
		if (!LDKNKHLFHJA.ContainsKey(PCODNODNAHN.DMAGNMIOAEJ))
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "A head ended however request seems to be cancelled: {0}", PCODNODNAHN.DMAGNMIOAEJ);
			return;
		}
		string text = JMFBBJHFMIM.MBFMMIEMEBM(PCODNODNAHN, true);
		LJNCMANOJMB hIBNMJBJEBI = LDKNKHLFHJA[PCODNODNAHN.DMAGNMIOAEJ].HIBNMJBJEBI;
		if (!hIBNMJBJEBI.AMEDMLOCCBG.Equals(PCODNODNAHN.AMEDMLOCCBG))
		{
			AKKKHGENAED();
			return;
		}
		try
		{
			List<byte[]> streamedFragments = OMJOIIOONMO.GetStreamedFragments();
			if (streamedFragments != null)
			{
				int num = 0;
				using (FileStream fileStream = new FileStream(text, FileMode.Append))
				{
					foreach (byte[] item in streamedFragments)
					{
						num += item.Length;
						fileStream.Write(item, 0, item.Length);
					}
				}
				PCODNODNAHN.BJMDAELAELI += num;
				PCODNODNAHN.AEPLIGFCGIF = 1;
				FCJAAJLPCMB.GABGKBAKHDP.GDFHLDAKIOM(PCODNODNAHN);
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Download, "An error occured while downloading {0} due to {1}.Cancelling!", PCODNODNAHN.DMAGNMIOAEJ, ex);
			AKKKHGENAED();
			return;
		}
		float num2 = (float)PCODNODNAHN.BJMDAELAELI / (float)PCODNODNAHN.IKNGODJEKEA;
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Download for {0} Status: Range {1}/{2} ({3:0.00})", PCODNODNAHN.DMAGNMIOAEJ, PCODNODNAHN.BJMDAELAELI, PCODNODNAHN.IKNGODJEKEA, num2);
		if (OMJOIIOONMO.IsStreamingFinished && MONIIALMCBH.State == HTTPRequestStates.Finished)
		{
			PCODNODNAHN.AEPLIGFCGIF = 2;
			FCJAAJLPCMB.GABGKBAKHDP.GDFHLDAKIOM(PCODNODNAHN);
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Download finished for: {0}", PCODNODNAHN.DMAGNMIOAEJ);
			string text2 = JMFBBJHFMIM.MBFMMIEMEBM(PCODNODNAHN);
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			File.Move(text, text2);
			LDKNKHLFHJA.Remove(PCODNODNAHN.DMAGNMIOAEJ);
		}
	}

	[CompilerGenerated]
	private void HGEFPHDFGKP(HTTPRequest MONIIALMCBH, HTTPResponse OMJOIIOONMO)
	{
		if (OMJOIIOONMO == null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Response null. Server unreachable? Try again later.");
			LDKNKHLFHJA.Remove(PCODNODNAHN.DMAGNMIOAEJ);
		}
		else if (OMJOIIOONMO.StatusCode >= 200 && OMJOIIOONMO.StatusCode < 300)
		{
			DFLCEPGOGAN(MONIIALMCBH, OMJOIIOONMO);
		}
		else
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Download, "Unexpected response from server: {0}", OMJOIIOONMO.StatusCode);
			LDKNKHLFHJA.Remove(PCODNODNAHN.DMAGNMIOAEJ);
		}
	}
}
