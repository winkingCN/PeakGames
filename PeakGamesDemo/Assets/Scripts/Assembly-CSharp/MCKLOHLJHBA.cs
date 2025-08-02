using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MCKLOHLJHBA : FGGOGJLHPHD, IBODGFKAHLF
{
	private AndroidJavaObject HCODEBGJLDD;

	private AndroidJavaObject OEMDDIPEAGE;

	private AndroidJavaObject HPEHEKHNMCM;

	[CompilerGenerated]
	private static Func<KeyValuePair<string, object>, bool> EBCOMJBLIPP;

	[CompilerGenerated]
	private static Func<KeyValuePair<string, object>, string> DNBOPLHGMHA;

	[CompilerGenerated]
	private static Func<KeyValuePair<string, object>, object> JFHCKLHBBDI;

	public MCKLOHLJHBA()
	{
		AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		OEMDDIPEAGE = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
		NCHNJANOADK.FFKACBMBNNP().AGGHDGKNNGL(this);
		NLPADEFLHIA.FFKACBMBNNP().GINHNILIDHL("campaigns", this);
	}

	private AndroidJavaObject ICOCKDCLPPH(Dictionary<string, object> NLLGGNNDDLJ)
	{
		AndroidJavaObject androidJavaObject = new AndroidJavaObject("java.util.HashMap");
		if (NLLGGNNDDLJ != null)
		{
			Dictionary<string, object> dictionary = NLLGGNNDDLJ.Where((KeyValuePair<string, object> DBNELFEABME) => DBNELFEABME.Value != null).ToDictionary((KeyValuePair<string, object> DBNELFEABME) => DBNELFEABME.Key, (KeyValuePair<string, object> DBNELFEABME) => DBNELFEABME.Value);
			IntPtr methodID = AndroidJNIHelper.GetMethodID(androidJavaObject.GetRawClass(), "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			object[] array = new object[2];
			array[0] = (array[1] = null);
			foreach (KeyValuePair<string, object> item in dictionary)
			{
				if (item.Key == null || item.Value == null)
				{
					continue;
				}
				using (AndroidJavaObject androidJavaObject2 = new AndroidJavaObject("java.lang.String", item.Key))
				{
					array[0] = androidJavaObject2;
					switch (item.Value.GetType().ToString())
					{
					case "System.String":
						array[1] = new AndroidJavaObject("java.lang.String", item.Value);
						break;
					case "System.Int32":
						array[1] = new AndroidJavaObject("java.lang.Integer", item.Value);
						break;
					case "System.Int64":
						array[1] = new AndroidJavaObject("java.lang.Long", item.Value);
						break;
					case "System.Boolean":
						array[1] = new AndroidJavaObject("java.lang.Boolean", item.Value);
						break;
					case "System.DateTime":
					{
						TimeSpan timeSpan = new TimeSpan(((DateTime)item.Value).Ticks);
						double totalMilliseconds = timeSpan.TotalMilliseconds;
						double num = totalMilliseconds - new TimeSpan(new DateTime(1970, 1, 1).Ticks).TotalMilliseconds;
						AndroidJavaObject androidJavaObject3 = new AndroidJavaObject("java.lang.Double", num);
						long num2 = androidJavaObject3.Call<long>("longValue", new object[0]);
						array[1] = new AndroidJavaObject("java.util.Date", num2);
						break;
					}
					}
					if (array[1] != null)
					{
						AndroidJNI.CallObjectMethod(androidJavaObject.GetRawObject(), methodID, AndroidJNIHelper.CreateJNIArgArray(array));
					}
				}
			}
		}
		return androidJavaObject;
	}

	private void HDFCIAJHNAE(string JMHBADGAFLN, string CNKJPAGKAMJ, object[] MIDCNFGAIFA)
	{
		NLPADEFLHIA.FFKACBMBNNP().HOGHHPKJOKC("campaigns", JMHBADGAFLN, CNKJPAGKAMJ, MIDCNFGAIFA);
	}

	private void ENMPAKPDLNL()
	{
		NLPADEFLHIA.FFKACBMBNNP().BGONEKPEOJC();
	}

	public void GJGLBDBCJCL()
	{
		HCODEBGJLDD = NCHNJANOADK.FFKACBMBNNP().PKHBBNLFKHK().CallStatic<AndroidJavaObject>("getHelpshiftCampaignsInstance", new object[0]);
	}

	public void HDDMNMIHBKC(string JMHBADGAFLN, string CNKJPAGKAMJ, object[] MIDCNFGAIFA)
	{
		if (JMHBADGAFLN.Equals("hsCampaignsApiCall"))
		{
			HCODEBGJLDD.CallStatic(CNKJPAGKAMJ, MIDCNFGAIFA);
		}
		else if (JMHBADGAFLN.Equals("hsCampaignsApiCallWithoutArgs"))
		{
			HCODEBGJLDD.CallStatic(CNKJPAGKAMJ);
		}
	}

	private void HMNKICANDAK(string CNKJPAGKAMJ, params object[] MIDCNFGAIFA)
	{
		HDFCIAJHNAE("hsCampaignsApiCall", CNKJPAGKAMJ, MIDCNFGAIFA);
	}

	private void HMNKICANDAK(string CNKJPAGKAMJ)
	{
		HDFCIAJHNAE("hsCampaignsApiCallWithoutArgs", CNKJPAGKAMJ, null);
	}

	private bool LNAELGPJKJH(string CNKJPAGKAMJ, params object[] MIDCNFGAIFA)
	{
		ENMPAKPDLNL();
		if (MIDCNFGAIFA != null)
		{
			return HCODEBGJLDD.CallStatic<bool>(CNKJPAGKAMJ, MIDCNFGAIFA);
		}
		return HCODEBGJLDD.CallStatic<bool>(CNKJPAGKAMJ, new object[0]);
	}

	private int KEBFBKFEFNH(string CNKJPAGKAMJ, params object[] MIDCNFGAIFA)
	{
		ENMPAKPDLNL();
		if (MIDCNFGAIFA != null)
		{
			return HCODEBGJLDD.CallStatic<int>(CNKJPAGKAMJ, MIDCNFGAIFA);
		}
		return HCODEBGJLDD.CallStatic<int>(CNKJPAGKAMJ, new object[0]);
	}

	private AndroidJavaObject EIHOEANHEAP(string CNKJPAGKAMJ, params object[] MIDCNFGAIFA)
	{
		ENMPAKPDLNL();
		if (MIDCNFGAIFA != null)
		{
			return HCODEBGJLDD.CallStatic<AndroidJavaObject>(CNKJPAGKAMJ, MIDCNFGAIFA);
		}
		return HCODEBGJLDD.CallStatic<AndroidJavaObject>(CNKJPAGKAMJ, new object[0]);
	}

	public bool LKPDEGGEBBJ(string IKNCPEPOKGJ, int EDDNOJDPMCF)
	{
		return LNAELGPJKJH("addProperty", IKNCPEPOKGJ, new AndroidJavaObject("java.lang.Integer", EDDNOJDPMCF));
	}

	public bool LKPDEGGEBBJ(string IKNCPEPOKGJ, long EDDNOJDPMCF)
	{
		return LNAELGPJKJH("addProperty", IKNCPEPOKGJ, new AndroidJavaObject("java.lang.Long", EDDNOJDPMCF));
	}

	public bool LKPDEGGEBBJ(string IKNCPEPOKGJ, string EDDNOJDPMCF)
	{
		return LNAELGPJKJH("addProperty", IKNCPEPOKGJ, new AndroidJavaObject("java.lang.String", EDDNOJDPMCF));
	}

	public bool LKPDEGGEBBJ(string IKNCPEPOKGJ, bool EDDNOJDPMCF)
	{
		return LNAELGPJKJH("addProperty", IKNCPEPOKGJ, new AndroidJavaObject("java.lang.Boolean", EDDNOJDPMCF));
	}

	public bool LKPDEGGEBBJ(string IKNCPEPOKGJ, DateTime EDDNOJDPMCF)
	{
		double totalMilliseconds = new TimeSpan(EDDNOJDPMCF.Ticks).TotalMilliseconds;
		double num = totalMilliseconds - new TimeSpan(new DateTime(1970, 1, 1).Ticks).TotalMilliseconds;
		AndroidJavaObject androidJavaObject = new AndroidJavaObject("java.lang.Double", num);
		long num2 = androidJavaObject.Call<long>("longValue", new object[0]);
		return LNAELGPJKJH("addProperty", IKNCPEPOKGJ, new AndroidJavaObject("java.util.Date", num2));
	}

	public string[] ALIKLBGOFCB(Dictionary<string, object> EDDNOJDPMCF)
	{
		AndroidJavaObject androidJavaObject = EIHOEANHEAP("addProperties", ICOCKDCLPPH(EDDNOJDPMCF));
		return AndroidJNIHelper.ConvertFromJNIArray<string[]>(androidJavaObject.GetRawObject());
	}

	public void AAPNNBELKGD(Dictionary<string, object> MOMNKLKOBKO)
	{
		HMNKICANDAK("showInbox", OEMDDIPEAGE);
	}

	public int ABNFDCLMMFL()
	{
		return KEBFBKFEFNH("getCountOfUnreadMessages", null);
	}

	public void FLHHGJLKNAI()
	{
		HMNKICANDAK("requestUnreadMessagesCount");
	}

	public void DBHJJPLGMHJ(string KHAHOPFFEJO, Dictionary<string, object> MOMNKLKOBKO)
	{
		HMNKICANDAK("showMessage", KHAHOPFFEJO, OEMDDIPEAGE);
	}

	public void IIFBOLANFKL(DGEFIMEIGKH HGGOFJELEIP)
	{
		ENMPAKPDLNL();
		KDLNDGMPAIH kDLNDGMPAIH = new KDLNDGMPAIH(HGGOFJELEIP);
		HMNKICANDAK("setInboxMessageDelegate", kDLNDGMPAIH);
	}

	public void DCBLFJENHPP(MKHIKJLMILF FFDJDJBFCGP)
	{
		ENMPAKPDLNL();
		DDHGNNPHLCP dDHGNNPHLCP = new DDHGNNPHLCP(FFDJDJBFCGP);
		HMNKICANDAK("setCampaignsDelegate", dDHGNNPHLCP);
	}

	[CompilerGenerated]
	private static bool GLEBMCCBCBL(KeyValuePair<string, object> DBNELFEABME)
	{
		return DBNELFEABME.Value != null;
	}

	[CompilerGenerated]
	private static string IOIPHGHBHNE(KeyValuePair<string, object> DBNELFEABME)
	{
		return DBNELFEABME.Key;
	}

	[CompilerGenerated]
	private static object CLFAOKPMPJP(KeyValuePair<string, object> DBNELFEABME)
	{
		return DBNELFEABME.Value;
	}
}
