using System.Collections.Generic;

public class MJLNBKKHIPP
{
	public bool MPDHPEIDDOO(object[] MIDCNFGAIFA)
	{
		if (MIDCNFGAIFA[0] == null)
		{
			return true;
		}
		Dictionary<string, object> dictionary = MIDCNFGAIFA[0] as Dictionary<string, object>;
		if (dictionary == null)
		{
			return false;
		}
		object value;
		dictionary.TryGetValue("errNo", out value);
		object value2;
		dictionary.TryGetValue("errorMsg", out value2);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.BaseModule, "Social Handle Error > No:{0} Message:{1}", value, value2);
		return false;
	}

	public NKILAONHNNE ADBKCDPFMGN(object[] MIDCNFGAIFA)
	{
		if (MIDCNFGAIFA[0] == null)
		{
			return null;
		}
		Dictionary<string, object> dictionary = MIDCNFGAIFA[0] as Dictionary<string, object>;
		return (dictionary != null) ? new NKILAONHNNE(dictionary) : null;
	}
}
