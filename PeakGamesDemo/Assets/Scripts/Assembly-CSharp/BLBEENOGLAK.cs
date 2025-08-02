using System;
using System.Text.RegularExpressions;
using Assets.Scripts.PeakAB.Pocos;
using BestHTTP;

public abstract class BLBEENOGLAK
{
	public Variant HHKPBOMECJP;

	private string JCEBNBPJHEF;

	protected BLBEENOGLAK(Variant HOHDPCLDPEP)
	{
		HHKPBOMECJP = HOHDPCLDPEP;
	}

	public void GMEJEIGMHOG(string IOCMOCCFALN)
	{
		JCEBNBPJHEF = IOCMOCCFALN;
		try
		{
			string text = Regex.Replace(HHKPBOMECJP.file_url.Trim(), "https", "http", RegexOptions.IgnoreCase);
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AbTesting, "Will variant download from: {0}", text);
			Uri uri = new Uri(text);
			HTTPRequest hTTPRequest = new HTTPRequest(uri, HTTPMethods.Get, GODPFKCOIDE);
			hTTPRequest.ConnectTimeout = TimeSpan.FromSeconds(5.0);
			hTTPRequest.Timeout = TimeSpan.FromSeconds(5.0);
			HTTPRequest hTTPRequest2 = hTTPRequest;
			hTTPRequest2.Send();
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.AbTesting, "Can not fetch variant data from {0} due to {1}", HHKPBOMECJP.file_url, ex.Message);
		}
	}

	private void GODPFKCOIDE(HTTPRequest BNICBDDNEAB, HTTPResponse OMJOIIOONMO)
	{
		if (OMJOIIOONMO == null)
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.AbTesting, "Can not fetch variant due to {0}", BNICBDDNEAB.Exception);
			return;
		}
		if (OMJOIIOONMO.StatusCode < 200 || OMJOIIOONMO.StatusCode >= 300)
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.AbTesting, "Can not fetch variant response code: {0}", OMJOIIOONMO.StatusCode);
			return;
		}
		try
		{
			GDGINCNCMDD(OMJOIIOONMO);
			MKINMKEMBPL.GABGKBAKHDP.PJOCEPHIEPF(JCEBNBPJHEF);
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.BaseVariantProcessor, "Exception on processing an ab test: {0}", ex);
		}
	}

	protected abstract void GDGINCNCMDD(HTTPResponse OMJOIIOONMO);
}
