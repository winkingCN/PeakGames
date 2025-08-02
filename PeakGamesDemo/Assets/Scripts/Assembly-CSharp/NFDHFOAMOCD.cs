using Facebook.Unity;

public class NFDHFOAMOCD
{
	public static void OGIABCPMENP(int NNIDKMJGAJO)
	{
		if (!FB.IsInitialized)
		{
			return;
		}
		try
		{
			FB.LogAppEvent("fb_mobile_spent_credits", NNIDKMJGAJO);
		}
		catch
		{
		}
	}

	public static void PGDBPMNHEAN()
	{
		if (!FB.IsInitialized)
		{
			return;
		}
		try
		{
			FB.LogAppEvent("s2s_d1_level25_end");
		}
		catch
		{
		}
	}

	public static void ABKFAIDPPOA(int KIGOGMKCDKN)
	{
		if (!FB.IsInitialized)
		{
			return;
		}
		try
		{
			FB.LogAppEvent("fb_mobile_level_achieved", KIGOGMKCDKN);
		}
		catch
		{
		}
	}

	public static void BEKHANMCLGP()
	{
		if (!FB.IsInitialized)
		{
			return;
		}
		try
		{
			FB.LogAppEvent("fb_mobile_complete_registration");
		}
		catch
		{
		}
	}

	public static void JGKGPFOOFBA(float NNIDKMJGAJO, string FMGPCBJLMDF)
	{
		if (!FB.IsInitialized)
		{
			return;
		}
		try
		{
			FB.LogPurchase(NNIDKMJGAJO, FMGPCBJLMDF);
		}
		catch
		{
		}
	}
}
