using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using BestHTTP;
using UnityEngine;
using caravan.protobuf.messages;

public class KIHMBFDKLJM
{
	private static KIHMBFDKLJM KNPOFJNFLJB;

	public readonly BackendSerializer BGGEDOONAPL = new BackendSerializer();

	private long KBCCALFCDPL;

	public static bool DFADLCFOHHN;

	public static float IHMGCFKMNIH;

	private bool IDMCDGIFEDA;

	private float NBDCAPMHNJH;

	public static KIHMBFDKLJM GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new KIHMBFDKLJM();
			}
			return KNPOFJNFLJB;
		}
	}

	private KIHMBFDKLJM()
	{
	}

	public void IINKCBOCHBG(List<IKDMCJPBBIH> HDECNOABBDG, bool DMNFCFIBMDM = false)
	{
		long cLDNFEGFEMB = ++KBCCALFCDPL;
		if (!JHOAHCHHBCH.CCAJIIFJPFF())
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Backend, "Unity informs no internet. So fail commands.");
			CDIGGKFJCJP cDIGGKFJCJP = new CDIGGKFJCJP(HDECNOABBDG, cLDNFEGFEMB);
			cDIGGKFJCJP.FEAMHPDCHGF(GBJNCLLOCJB.NoConnection);
			return;
		}
		if (!CBNMJCLPKPB.OAIOGNLPGED)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Backend, "Backend is not responsive. So fail commands.");
			CDIGGKFJCJP cDIGGKFJCJP2 = new CDIGGKFJCJP(HDECNOABBDG, cLDNFEGFEMB);
			cDIGGKFJCJP2.FEAMHPDCHGF(GBJNCLLOCJB.BackendNotResponsive);
			return;
		}
		PHHKFLHAFHG pHHKFLHAFHG = NAAGDFCLOPE.GABGKBAKHDP.BINDEBHMEJC;
		if (pHHKFLHAFHG == null || !pHHKFLHAFHG.HDKJPHIPLPC)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Backend, "Cloud service is not ready yet. So fail commands.");
			CDIGGKFJCJP cDIGGKFJCJP3 = new CDIGGKFJCJP(HDECNOABBDG, cLDNFEGFEMB);
			cDIGGKFJCJP3.FEAMHPDCHGF(GBJNCLLOCJB.WaitingCloudResponse);
		}
		else if (LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM == 0)
		{
			new LLCJMMBBLEH(MPLPOFFABIP(HDECNOABBDG, cLDNFEGFEMB, DMNFCFIBMDM), true, IAJNLGPHGLO.App);
		}
		else if (HDECNOABBDG != null)
		{
			HPNCKPNPOOM(HDECNOABBDG, cLDNFEGFEMB, DMNFCFIBMDM);
		}
	}

	private IEnumerator MPLPOFFABIP(List<IKDMCJPBBIH> HDECNOABBDG, long CLDNFEGFEMB, bool PCKLKLJCKCD)
	{
		while (DFADLCFOHHN && Time.realtimeSinceStartup - IHMGCFKMNIH < 30f)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Backend, "Request no {0} will wait!", CLDNFEGFEMB);
			yield return MCJHHDACJBG.KNLADMIBAAD;
		}
		DFADLCFOHHN = true;
		IHMGCFKMNIH = Time.realtimeSinceStartup;
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Backend, "Request no {0} will not wait!", CLDNFEGFEMB);
		if (LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM > 0)
		{
			DFADLCFOHHN = false;
			if (HDECNOABBDG != null)
			{
				HPNCKPNPOOM(HDECNOABBDG, CLDNFEGFEMB, PCKLKLJCKCD);
			}
		}
		else
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Backend, "Login Command is needed. Performing mobile login.");
			List<IKDMCJPBBIH> list = new List<IKDMCJPBBIH>();
			OKGCOMJOMPO oKGCOMJOMPO = new OKGCOMJOMPO();
			oKGCOMJOMPO.ELADBJNKNME(HDECNOABBDG);
			list.Add(oKGCOMJOMPO);
			HPNCKPNPOOM(list, CLDNFEGFEMB, PCKLKLJCKCD);
		}
	}

	private void HPNCKPNPOOM(List<IKDMCJPBBIH> HDECNOABBDG, long CLDNFEGFEMB, bool PCKLKLJCKCD)
	{
		new LLCJMMBBLEH(BGFDKNHALHL(HDECNOABBDG, CLDNFEGFEMB, PCKLKLJCKCD), true, IAJNLGPHGLO.App);
	}

	public void ADFOMINAMIM()
	{
		IDMCDGIFEDA = false;
	}

	private IEnumerator BGFDKNHALHL(List<IKDMCJPBBIH> HDECNOABBDG, long CLDNFEGFEMB, bool PCKLKLJCKCD)
	{
		if (HDECNOABBDG == null || HDECNOABBDG.Count == 0)
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Backend, "Empty request prevented.");
			yield break;
		}
		while (IDMCDGIFEDA && Time.realtimeSinceStartup - NBDCAPMHNJH < 30f)
		{
			yield return null;
		}
		if (IDMCDGIFEDA)
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Backend, "A parallel request started due to no reply. Req. No.:{0}", CLDNFEGFEMB);
		}
		IDMCDGIFEDA = true;
		NBDCAPMHNJH = Time.realtimeSinceStartup;
		HTTPRequest hTTPRequest = null;
		try
		{
			for (int num = HDECNOABBDG.Count - 1; num >= 0; num--)
			{
				if (!HDECNOABBDG[num].NAFCDEECGEF())
				{
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Backend, "Command is not needed: {0}", HDECNOABBDG[num].LOICNFDHCJK);
					HDECNOABBDG.RemoveAt(num);
				}
			}
			if (HDECNOABBDG.Count == 0)
			{
				IDMCDGIFEDA = false;
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Backend, "Commands are not needed anymore.Req. No.:{0}", CLDNFEGFEMB);
				yield break;
			}
			int num2 = 10;
			string text = string.Empty;
			for (int i = 0; i < HDECNOABBDG.Count; i++)
			{
				HDECNOABBDG[i].LIFPNHAFPHP(i);
				num2 = Mathf.Max(num2, HDECNOABBDG[i].MCFABAAMELG());
				text = string.Concat(text, HDECNOABBDG[i].LOICNFDHCJK, ", ");
			}
			CDIGGKFJCJP @object = new CDIGGKFJCJP(HDECNOABBDG, CLDNFEGFEMB);
			Uri uri = CBNMJCLPKPB.IFELMHEFNII(num2, PCKLKLJCKCD);
			hTTPRequest = new HTTPRequest(uri, HTTPMethods.Post, @object.ECDJIICFGNN)
			{
				RawData = CGKOPFPJPHC(HDECNOABBDG, CLDNFEGFEMB),
				ConnectTimeout = TimeSpan.FromSeconds(5.0),
				Timeout = TimeSpan.FromSeconds(num2)
			};
			hTTPRequest.AddHeader("Accept", "application/x-protobuf");
			hTTPRequest.AddHeader("Content-Type", "application/x-protobuf");
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Backend, "Calling backend with request Id:{0} ({1} SyncId:{2})", CLDNFEGFEMB, text, GFHPEDILAJG.GABGKBAKHDP.OMBKMIINHMF);
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Backend, "An error occured while sending commands. Inform commands as failed. {0}:{1}", ex.Message, ex.StackTrace);
			for (int j = 0; j < HDECNOABBDG.Count; j++)
			{
				try
				{
					IKDMCJPBBIH iKDMCJPBBIH = HDECNOABBDG[j];
					iKDMCJPBBIH.HOBMBHFKMJI(false);
				}
				catch (Exception ex2)
				{
					GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Backend, "Error in fail inform: {0}:{1}", ex2.Message, ex2.StackTrace);
				}
			}
		}
		if (hTTPRequest != null)
		{
			hTTPRequest.Send();
		}
		else
		{
			IDMCDGIFEDA = false;
		}
	}

	private byte[] CGKOPFPJPHC(IEnumerable<IKDMCJPBBIH> HDECNOABBDG, long CLDNFEGFEMB)
	{
		int result;
		int.TryParse("4161", out result);
		Request request = new Request();
		request.syncId = GFHPEDILAJG.GABGKBAKHDP.OMBKMIINHMF;
		request.deviceId = LECPGNKOABP.GABGKBAKHDP.MPIDFEMEEIJ;
		request.versionNo = result;
		Request request2 = request;
		foreach (IKDMCJPBBIH item in HDECNOABBDG)
		{
			request2.messages.Add(item.DIMAFEDACMK());
		}
		LECPGNKOABP lECPGNKOABP = LECPGNKOABP.GABGKBAKHDP;
		if (lECPGNKOABP.GDMECFECCOM > 0)
		{
			UserMetaData userMetaData = new UserMetaData();
			userMetaData.userId = lECPGNKOABP.GDMECFECCOM;
			userMetaData.token = lECPGNKOABP.FIPPLABNDON;
			UserMetaData userMetaData2 = userMetaData;
			if (LECPGNKOABP.GABGKBAKHDP.BJLBIBDKADC())
			{
				userMetaData2.fbId = LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA;
				userMetaData2.fbToken = LECPGNKOABP.GABGKBAKHDP.KMHPHBJCPJH;
			}
			request2.user = userMetaData2;
		}
		using (MemoryStream memoryStream = new MemoryStream())
		{
			BGGEDOONAPL.Serialize(memoryStream, request2);
			return memoryStream.ToArray();
		}
	}
}
