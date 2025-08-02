using System;
using System.Collections.Generic;
using Facebook.Unity;

public class GJPKLKPODPI
{
	private readonly Action<List<FMCCBPELMEO>> LKDPECKODNA;

	public GJPKLKPODPI(Action<List<FMCCBPELMEO>> MPPAKJCBAPB)
	{
		LKDPECKODNA = MPPAKJCBAPB;
	}

	public void JPCFKOLPLDH(IGraphResult DIDHNNMKJFE)
	{
		try
		{
			bool flag = false;
			if (DIDHNNMKJFE.Error != null || DIDHNNMKJFE.Cancelled)
			{
				if (LKDPECKODNA != null)
				{
					LKDPECKODNA(null);
				}
			}
			else
			{
				IDictionary<string, object> resultDictionary = DIDHNNMKJFE.ResultDictionary;
				if (resultDictionary != null)
				{
					List<object> list = ((!resultDictionary.ContainsKey("data")) ? null : ((List<object>)resultDictionary["data"]));
					if (list != null)
					{
						List<FMCCBPELMEO> list2 = new List<FMCCBPELMEO>(8);
						for (int i = 0; i < list.Count; i++)
						{
							if (list[i] != null)
							{
								IDictionary<string, object> dictionary = (IDictionary<string, object>)list[i];
								IDictionary<string, object> dictionary2 = ((!dictionary.ContainsKey("from")) ? null : ((IDictionary<string, object>)dictionary["from"]));
								if (dictionary2 != null)
								{
									string iOCMOCCFALN = ((!dictionary2.ContainsKey("name")) ? string.Empty : ((string)dictionary2["name"]));
									string bDKFNEDHAOJ = ((!dictionary2.ContainsKey("id")) ? string.Empty : ((string)dictionary2["id"]));
									string mBBPBGHKLJM = ((!dictionary.ContainsKey("data")) ? string.Empty : ((string)dictionary["data"]));
									string oCDAMLLBKEL = ((!dictionary.ContainsKey("id")) ? string.Empty : ((string)dictionary["id"]));
									list2.Add(new FMCCBPELMEO(bDKFNEDHAOJ, iOCMOCCFALN, mBBPBGHKLJM, oCDAMLLBKEL));
								}
							}
						}
						if (LKDPECKODNA != null)
						{
							LKDPECKODNA(list2);
						}
					}
					else
					{
						flag = true;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (LKDPECKODNA != null && flag)
			{
				LKDPECKODNA(null);
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.FetchRequestsProcessor, "Error Fetching Facebook Requests: Error:{0}, Stack:{1}", ex.Message, ex.StackTrace);
		}
	}
}
