using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Fabric.Answers;
using Facebook.MiniJSON;
using Facebook.Unity;
using UnityEngine;

public class PGACJHKJAHA
{
	private const float JHAEIDGAKCE = 180f;

	private static PGACJHKJAHA KNPOFJNFLJB;

	private bool HAEJJJCDCDM;

	private bool GKELKFGKGBB;

	private bool MAGFOFMFMGO = true;

	[CompilerGenerated]
	private static InitDelegate JANLDOMIIEF;

	[CompilerGenerated]
	private static InitDelegate GEBGDBLHLKE;

	[CompilerGenerated]
	private static Action<bool> FNBHFDJDLFP;

	[CompilerGenerated]
	private static FacebookDelegate<IGraphResult> EBCOMJBLIPP;

	public static PGACJHKJAHA GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new PGACJHKJAHA();
			}
			return KNPOFJNFLJB;
		}
	}

	private PGACJHKJAHA()
	{
	}

	public void LAPGGGMFPFB(Action<bool> GPLIOLJFDPM)
	{
		if (FB.IsInitialized && FB.IsLoggedIn && AccessToken.CurrentAccessToken != null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookExecutor, "FB Already Initted and Logged In!");
			BIHOFHIPFGC();
			if (GPLIOLJFDPM != null)
			{
				GPLIOLJFDPM(true);
			}
		}
		else
		{
			new LLCJMMBBLEH(NOGLIIIOGGE(GPLIOLJFDPM));
		}
	}

	public void EEPKEAPGPLH(Action<bool> GPLIOLJFDPM)
	{
		if (FB.IsInitialized && FB.IsLoggedIn)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookExecutor, "ExecuteWithoutLogin FB Already Initted and Logged In!");
			BIHOFHIPFGC();
			if (GPLIOLJFDPM != null)
			{
				GPLIOLJFDPM(true);
			}
		}
		else if (GPLIOLJFDPM != null)
		{
			GPLIOLJFDPM(false);
		}
	}

	private void BIHOFHIPFGC()
	{
		if (AccessToken.CurrentAccessToken == null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookExecutor, "Trace Access Token Problem! Access Token is null.");
			return;
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookExecutor, "Trace Access Token FB Token:{0} , Json{1}, ExpireData:{2}, LastRefresh:{3}, UserId{4}, AccessToken:{5}", AccessToken.CurrentAccessToken.TokenString, AccessToken.CurrentAccessToken.ToJson(), AccessToken.CurrentAccessToken.ExpirationTime, AccessToken.CurrentAccessToken.LastRefresh, AccessToken.CurrentAccessToken.UserId, AccessToken.CurrentAccessToken.ToString());
	}

	public void BJPLENOEKKK(IGraphResult DIDHNNMKJFE)
	{
		try
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.FacebookExecutor, "ProcessError IGraphResult Error:{0} Raw:{1}", DIDHNNMKJFE.Error, DIDHNNMKJFE.RawResult);
			if (DIDHNNMKJFE.Error == null || LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA == null)
			{
				return;
			}
			Dictionary<string, object> dictionary = Json.Deserialize(DIDHNNMKJFE.RawResult) as Dictionary<string, object>;
			if (dictionary == null)
			{
				return;
			}
			Dictionary<string, object> dictionary2 = dictionary["error"] as Dictionary<string, object>;
			if (dictionary2 == null || (dictionary2.ContainsKey("type") && dictionary2.ContainsKey("code")))
			{
				string text = dictionary2["type"].ToString();
				int num = int.Parse(dictionary2["code"].ToString());
				if (text.Equals("OAuthException") && num == 190)
				{
					IIMOEAOONKA.GABGKBAKHDP.OKAAOGJIFKI();
				}
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.FacebookExecutor, "Can  not process error: (2) {0}", ex.Message);
		}
	}

	public void BJPLENOEKKK(IAppRequestResult DIDHNNMKJFE)
	{
		try
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.FacebookExecutor, "ProcessError IAppRequestResult  Error:{0} Raw:{1}", DIDHNNMKJFE.Error, DIDHNNMKJFE.RawResult);
			if (DIDHNNMKJFE.Error != null && LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA != null && DIDHNNMKJFE.Error.Contains("facebookErrorCode: 190"))
			{
				IIMOEAOONKA.GABGKBAKHDP.OKAAOGJIFKI();
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.FacebookExecutor, "Can  not process error: (1) {0}", ex.Message);
		}
	}

	public void DJKMGOCLCHA(Action<bool> BCAHBOOEAEE)
	{
		GKELKFGKGBB = false;
		new LLCJMMBBLEH(JLBOGDMCNOG(BCAHBOOEAEE), true, IAJNLGPHGLO.App);
	}

	private IEnumerator NOGLIIIOGGE(Action<bool> GPLIOLJFDPM)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookHelper, "FB SetContent started!");
		while (HAEJJJCDCDM)
		{
			yield return null;
		}
		HAEJJJCDCDM = true;
		if (!FB.IsInitialized)
		{
			FB.Init(OCILGCNBNKO);
			float time = Time.time;
			while (!FB.IsInitialized)
			{
				float num = Time.time - time;
				if (num > 180f)
				{
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookExecutor, "FB Initialize time out.");
					if (GPLIOLJFDPM != null)
					{
						GPLIOLJFDPM(false);
					}
					HAEJJJCDCDM = false;
					yield break;
				}
				yield return null;
			}
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookHelper, "FB Initialize done.");
		MAGFOFMFMGO = true;
		if (!FB.IsLoggedIn)
		{
			HLHPBNKKHBJ("Start");
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookExecutor, "FB Logging in");
			List<string> list = new List<string>();
			list.Add("public_profile");
			list.Add("user_friends");
			FB.LogInWithReadPermissions(list, delegate(ILoginResult DIDHNNMKJFE)
			{
				if (DIDHNNMKJFE != null)
				{
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookExecutor, "Facebook Login Result > Cancelled:{0} Error:{1} Raw:{2}", DIDHNNMKJFE.Cancelled, DIDHNNMKJFE.Error, DIDHNNMKJFE.RawResult);
					if (!DIDHNNMKJFE.Cancelled && AccessToken.CurrentAccessToken != null)
					{
						double totalMinutes = (AccessToken.CurrentAccessToken.ExpirationTime - DateTime.UtcNow).TotalMinutes;
						if (totalMinutes < 1.0)
						{
							MAGFOFMFMGO = false;
							FB.Mobile.RefreshCurrentAccessToken(delegate(IAccessTokenRefreshResult EAHCAACAHAA)
							{
								GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookExecutor, "Refreshing Facebook Token!");
								if (EAHCAACAHAA != null && EAHCAACAHAA.AccessToken != null)
								{
									GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookExecutor, "Result token:{0}", EAHCAACAHAA.AccessToken.ToString());
								}
								MAGFOFMFMGO = true;
							});
						}
					}
				}
				else
				{
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookExecutor, "Facebook Login Result is null");
				}
				GKELKFGKGBB = true;
			});
			float time2 = Time.time;
			while (!GKELKFGKGBB && Time.time - time2 < 180f)
			{
				yield return MCJHHDACJBG.CHFOIGLAMPN;
			}
			float num2 = Time.realtimeSinceStartup + 3f;
			while (!MAGFOFMFMGO && Time.realtimeSinceStartup < num2)
			{
				yield return MCJHHDACJBG.KNLADMIBAAD;
			}
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookExecutor, "FB Logging completed in {0} seconds", Time.time - time2);
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookExecutor, "Facebook status > IsLoggedIn:{0}", FB.IsLoggedIn);
		BIHOFHIPFGC();
		LECPGNKOABP lECPGNKOABP = LECPGNKOABP.GABGKBAKHDP;
		if (FB.IsLoggedIn && lECPGNKOABP.BJLBIBDKADC() && AccessToken.CurrentAccessToken != null && lECPGNKOABP.EHNKLBBAKCA.Equals(AccessToken.CurrentAccessToken.UserId))
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookExecutor, "User logged in with access token");
			lECPGNKOABP.KMHPHBJCPJH = AccessToken.CurrentAccessToken.TokenString;
		}
		else
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookExecutor, "User First Login");
		}
		if (GPLIOLJFDPM != null)
		{
			GPLIOLJFDPM(FB.IsLoggedIn);
		}
		yield return null;
		HAEJJJCDCDM = false;
		GKELKFGKGBB = false;
		if (FB.IsLoggedIn)
		{
			HLHPBNKKHBJ("Success");
		}
		else
		{
			HLHPBNKKHBJ("Fail");
		}
	}

	public static void OCILGCNBNKO()
	{
		FB.ActivateApp();
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookExecutor, "Facebook Initialize completed.");
	}

	private static IEnumerator JLBOGDMCNOG(Action<bool> BCAHBOOEAEE)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookExecutor, "ExecuteAction Called");
		if (!FB.IsInitialized)
		{
			FB.Init(OCILGCNBNKO);
			float time = Time.time;
			while (!FB.IsInitialized)
			{
				float num = Time.time - time;
				if (num > 180f)
				{
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookExecutor, "FB Initialize time out.");
					if (BCAHBOOEAEE != null)
					{
						BCAHBOOEAEE(false);
					}
					yield break;
				}
				yield return null;
			}
		}
		FB.LogOut();
		PPGOIFOCOAK.FBANJNDJEOG();
		LECPGNKOABP.GABGKBAKHDP.DMFMPDADFJK();
		EIMPOHFHFMO.GBPHBJEJODP();
		OneSignal.DeleteTag("FacebookId");
		if (LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM == 0)
		{
			GEBAAFFGKJG.GABGKBAKHDP.CBANNNKPJAM();
			if (BCAHBOOEAEE != null)
			{
				BCAHBOOEAEE(true);
			}
			yield break;
		}
		List<IKDMCJPBBIH> hDECNOABBDG = new List<IKDMCJPBBIH>
		{
			new OHOMECJJEFI(delegate
			{
				if (BCAHBOOEAEE != null)
				{
					BCAHBOOEAEE(true);
				}
			})
		};
		KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(hDECNOABBDG);
	}

	public static void JOAPFNGHHOP()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookExecutor, "Set name requested. Currently it is {0}", LECPGNKOABP.GABGKBAKHDP.LEOJICDDHHF);
		if (LECPGNKOABP.GABGKBAKHDP.LEOJICDDHHF == null)
		{
			GABGKBAKHDP.EEPKEAPGPLH(HNIFOICHABH);
		}
	}

	private static void HNIFOICHABH(bool NEMEKIOEOLC)
	{
		FB.API("/me?fields=name", HttpMethod.GET, delegate(IGraphResult DIDHNNMKJFE)
		{
			if (DIDHNNMKJFE.Error != null)
			{
				GABGKBAKHDP.BJPLENOEKKK(DIDHNNMKJFE);
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.FacebookExecutor, "Can not retrieve user name");
			}
			else if (!FB.IsLoggedIn)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.FacebookExecutor, "User is not logged in!");
			}
			else if (DIDHNNMKJFE.ResultDictionary != null && DIDHNNMKJFE.ResultDictionary.ContainsKey("name"))
			{
				object value;
				DIDHNNMKJFE.ResultDictionary.TryGetValue("name", out value);
				string text = value as string;
				if (text != null)
				{
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookExecutor, "Setting name as {0}", text);
					LECPGNKOABP.GABGKBAKHDP.LEOJICDDHHF = text;
					LECPGNKOABP.GABGKBAKHDP.EDHAJCFFACD();
				}
			}
		});
	}

	private static void HLHPBNKKHBJ(string GKOHLEGOCGH)
	{
		Answers.LogCustom("Facebook Login", new Dictionary<string, object> { { "Facebook Login", GKOHLEGOCGH } });
	}

	[CompilerGenerated]
	private static void DGMMCNHEDBP(IGraphResult DIDHNNMKJFE)
	{
		if (DIDHNNMKJFE.Error != null)
		{
			GABGKBAKHDP.BJPLENOEKKK(DIDHNNMKJFE);
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.FacebookExecutor, "Can not retrieve user name");
		}
		else if (!FB.IsLoggedIn)
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.FacebookExecutor, "User is not logged in!");
		}
		else if (DIDHNNMKJFE.ResultDictionary != null && DIDHNNMKJFE.ResultDictionary.ContainsKey("name"))
		{
			object value;
			DIDHNNMKJFE.ResultDictionary.TryGetValue("name", out value);
			string text = value as string;
			if (text != null)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookExecutor, "Setting name as {0}", text);
				LECPGNKOABP.GABGKBAKHDP.LEOJICDDHHF = text;
				LECPGNKOABP.GABGKBAKHDP.EDHAJCFFACD();
			}
		}
	}
}
