using System;
using System.Collections.Generic;
using UnityEngine;

public class JFNKCAPCADG : FGGOGJLHPHD, IBODGFKAHLF
{
	private AndroidJavaObject ILEJIADAPII;

	public JFNKCAPCADG()
	{
		NCHNJANOADK.FFKACBMBNNP().AGGHDGKNNGL(this);
		NLPADEFLHIA.FFKACBMBNNP().GINHNILIDHL("inbox", this);
	}

	public void GJGLBDBCJCL()
	{
		NLPADEFLHIA.FFKACBMBNNP().GINHNILIDHL("inbox", this);
		HDFCIAJHNAE("initializeInboxInstance", "getInboxInstance", null);
	}

	private void HDFCIAJHNAE(string JMHBADGAFLN, string CNKJPAGKAMJ, object[] MIDCNFGAIFA)
	{
		NLPADEFLHIA.FFKACBMBNNP().HOGHHPKJOKC("inbox", JMHBADGAFLN, CNKJPAGKAMJ, MIDCNFGAIFA);
	}

	private void NFLKOEDIFLN(string CNKJPAGKAMJ, object[] MIDCNFGAIFA)
	{
		HDFCIAJHNAE("hsInboxApiCall", CNKJPAGKAMJ, MIDCNFGAIFA);
	}

	public void HDDMNMIHBKC(string JMHBADGAFLN, string DFBFLINFFBE, object[] MIDCNFGAIFA)
	{
		if (JMHBADGAFLN.Equals("hsInboxApiCall"))
		{
			ILEJIADAPII.Call(DFBFLINFFBE, MIDCNFGAIFA);
		}
		else if (JMHBADGAFLN.Equals("initializeInboxInstance"))
		{
			ILEJIADAPII = NCHNJANOADK.FFKACBMBNNP().PKHBBNLFKHK().CallStatic<AndroidJavaObject>(DFBFLINFFBE, new object[0]);
		}
	}

	private void ENMPAKPDLNL()
	{
		NLPADEFLHIA.FFKACBMBNNP().BGONEKPEOJC();
	}

	public List<FMFLAPIFIED> MILMOKINMPE()
	{
		ENMPAKPDLNL();
		try
		{
			AndroidJavaObject androidJavaObject = ILEJIADAPII.Call<AndroidJavaObject>("getAllInboxMessages", new object[0]);
			List<FMFLAPIFIED> list = new List<FMFLAPIFIED>();
			int num = androidJavaObject.Call<int>("size", new object[0]);
			for (int i = 0; i < num; i++)
			{
				AndroidJavaObject oEFCOJLNCKP = androidJavaObject.Call<AndroidJavaObject>("get", new object[1] { i });
				list.Add(CNPKMBNDFPD.IAPNPECKPPL(oEFCOJLNCKP));
			}
			return list;
		}
		catch (Exception ex)
		{
			Debug.Log("Helpshift : Error getting all inbox messages : " + ex.Message);
		}
		return null;
	}

	public FMFLAPIFIED MJDAOLKIAMP(string KHAHOPFFEJO)
	{
		ENMPAKPDLNL();
		try
		{
			AndroidJavaObject oEFCOJLNCKP = ILEJIADAPII.Call<AndroidJavaObject>("getInboxMessage", new object[1] { KHAHOPFFEJO });
			return CNPKMBNDFPD.IAPNPECKPPL(oEFCOJLNCKP);
		}
		catch (Exception ex)
		{
			Debug.Log("Helpshift : Error getting inbox message : " + ex.Message);
		}
		return null;
	}

	public void JAGPIDJLDIL(string KHAHOPFFEJO)
	{
		ENMPAKPDLNL();
		ILEJIADAPII.Call("markInboxMessageAsRead", KHAHOPFFEJO);
	}

	public void LPGMEJLDNIP(string KHAHOPFFEJO)
	{
		ENMPAKPDLNL();
		ILEJIADAPII.Call("markInboxMessageAsSeen", KHAHOPFFEJO);
	}

	public void CICIHDPNKOM(string KHAHOPFFEJO)
	{
		ENMPAKPDLNL();
		ILEJIADAPII.Call("deleteInboxMessage", KHAHOPFFEJO);
	}

	public void GHHGOALODBF(DGEFIMEIGKH NBFMBJCKJKO)
	{
		ENMPAKPDLNL();
		KDLNDGMPAIH kDLNDGMPAIH = new KDLNDGMPAIH(NBFMBJCKJKO);
		ILEJIADAPII.Call("setInboxMessageDelegate", kDLNDGMPAIH);
	}

	public void EGKBOHFBBMC(IKHKOODFGMO NBFMBJCKJKO)
	{
		ENMPAKPDLNL();
		PNDMHCHBMBM pNDMHCHBMBM = new PNDMHCHBMBM(NBFMBJCKJKO);
		ILEJIADAPII.Call("setInboxPushNotificationDelegate", pNDMHCHBMBM);
	}
}
