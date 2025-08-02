using System;
using System.IO;
using BestHTTP;
using caravan.protobuf.messages;

public class DDBKKIGOCLO
{
	private readonly Uri PJOGLOOMMIO;

	private readonly int BFHJCLCALDA;

	private readonly Action<RemoteConfigData> NJMBOGKAPPD;

	public DDBKKIGOCLO(Uri CCMKBJDPCGF, int DFCJKBHFPMG, Action<RemoteConfigData> DGCCOCCKJGN)
	{
		PJOGLOOMMIO = CCMKBJDPCGF;
		BFHJCLCALDA = DFCJKBHFPMG;
		NJMBOGKAPPD = DGCCOCCKJGN;
	}

	public void GJIMJIJCBLC()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.RemoteConfigChecker, "Start fetching config data from:{0} for version:{1}", PJOGLOOMMIO, BFHJCLCALDA);
		if (!JHOAHCHHBCH.CCAJIIFJPFF())
		{
			if (NJMBOGKAPPD != null)
			{
				NJMBOGKAPPD(null);
			}
			return;
		}
		HTTPRequest hTTPRequest = new HTTPRequest(PJOGLOOMMIO, HTTPMethods.Post, HGGLKCGHDCH);
		hTTPRequest.ConnectTimeout = TimeSpan.FromSeconds(5.0);
		hTTPRequest.Timeout = TimeSpan.FromSeconds(5.0);
		HTTPRequest hTTPRequest2 = hTTPRequest;
		hTTPRequest2.AddHeader("Accept", "application/x-protobuf");
		hTTPRequest2.AddField("version", BFHJCLCALDA.ToString());
		hTTPRequest2.Send();
	}

	private void HGGLKCGHDCH(HTTPRequest BNICBDDNEAB, HTTPResponse OMJOIIOONMO)
	{
		if (OMJOIIOONMO == null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.RemoteConfigChecker, "Remote data can not be fetched; response is null. Endpoint:{0} Version:{1}", PJOGLOOMMIO, BFHJCLCALDA);
			if (NJMBOGKAPPD != null)
			{
				NJMBOGKAPPD(null);
			}
			return;
		}
		RemoteConfigData obj = null;
		int statusCode = OMJOIIOONMO.StatusCode;
		switch (statusCode)
		{
		case 204:
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.RemoteConfigChecker, "Remote Data seems same since last time. Endpoint:{0} Version:{1}", PJOGLOOMMIO, BFHJCLCALDA);
			break;
		case 200:
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.RemoteConfigChecker, "Remote Data has new content. Endpoint:{0} Version:{1}", PJOGLOOMMIO, BFHJCLCALDA);
			try
			{
				if (OMJOIIOONMO.Data == null)
				{
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.RemoteConfigChecker, "Remote Data has new content but response data is null!");
					break;
				}
				using (Stream source = new MemoryStream(OMJOIIOONMO.Data))
				{
					obj = KIHMBFDKLJM.GABGKBAKHDP.BGGEDOONAPL.Deserialize(source, null, typeof(RemoteConfigData)) as RemoteConfigData;
				}
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.RemoteConfigChecker, "Can not serialize remote data response: {0}.", ex.Message);
			}
			break;
		default:
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.RemoteConfigChecker, "RemoteData protocol problem, status code: {0}, {1}", statusCode, OMJOIIOONMO.Message);
			break;
		}
		if (NJMBOGKAPPD != null)
		{
			NJMBOGKAPPD(obj);
		}
	}
}
