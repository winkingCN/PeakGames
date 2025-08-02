using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Facebook.Unity;

public class JCGLFEMHECF : DLDDFKDFKEF
{
	[CompilerGenerated]
	private sealed class FJILDPAHKLA
	{
		internal Action<KNAKIANHFJN[]> IMHLFAHONPP;

		internal JCGLFEMHECF PDAPIGLEPGC;

		internal void AGFNGEFDHLA(bool EEKJMDHEJCK)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FBFriendsManager, "GetOrRequestGameFriendList: Getting friends from facebook. Success:" + EEKJMDHEJCK);
			if (EEKJMDHEJCK)
			{
				FB.API("/me?fields=id,name,friends.fields(picture.height(100).width(100),name).limit(1000)", HttpMethod.GET, delegate(IGraphResult DIDHNNMKJFE)
				{
					if (DIDHNNMKJFE.Error != null)
					{
						PGACJHKJAHA.GABGKBAKHDP.BJPLENOEKKK(DIDHNNMKJFE);
						GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.FBFriendsManager, "There is an error at GetOrRequestGameFriendList :{0} RawData:{1}", DIDHNNMKJFE.Error, DIDHNNMKJFE.RawResult);
					}
					if (DIDHNNMKJFE.Error == null && DIDHNNMKJFE.ResultDictionary != null && DIDHNNMKJFE.ResultDictionary.ContainsKey("friends"))
					{
						PDAPIGLEPGC.IOKKDKKCKLI = PDAPIGLEPGC.EPMADMGGCJF(DIDHNNMKJFE, "friends", true, true);
					}
					if (IMHLFAHONPP != null)
					{
						IMHLFAHONPP(PDAPIGLEPGC.OHGJJONIHKM);
					}
				});
			}
			else
			{
				IMHLFAHONPP(null);
			}
		}

		internal void KDACLOKGNAM(IGraphResult DIDHNNMKJFE)
		{
			if (DIDHNNMKJFE.Error != null)
			{
				PGACJHKJAHA.GABGKBAKHDP.BJPLENOEKKK(DIDHNNMKJFE);
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.FBFriendsManager, "There is an error at GetOrRequestGameFriendList :{0} RawData:{1}", DIDHNNMKJFE.Error, DIDHNNMKJFE.RawResult);
			}
			if (DIDHNNMKJFE.Error == null && DIDHNNMKJFE.ResultDictionary != null && DIDHNNMKJFE.ResultDictionary.ContainsKey("friends"))
			{
				PDAPIGLEPGC.IOKKDKKCKLI = PDAPIGLEPGC.EPMADMGGCJF(DIDHNNMKJFE, "friends", true, true);
			}
			if (IMHLFAHONPP != null)
			{
				IMHLFAHONPP(PDAPIGLEPGC.OHGJJONIHKM);
			}
		}
	}

	[CompilerGenerated]
	private sealed class PIHGBJBAFIC
	{
		internal Action<KNAKIANHFJN[]> IMHLFAHONPP;

		internal JCGLFEMHECF PDAPIGLEPGC;

		internal void AGFNGEFDHLA(bool EEKJMDHEJCK)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FBFriendsManager, "GetOrRequestInvitableFriendList: Getting friends from facebook. Success:" + EEKJMDHEJCK);
			if (EEKJMDHEJCK)
			{
				FB.API("/me?fields=id,name,invitable_friends.fields(picture.height(100).width(100),name).limit(1000)", HttpMethod.GET, delegate(IGraphResult DIDHNNMKJFE)
				{
					if (DIDHNNMKJFE.Error != null)
					{
						PGACJHKJAHA.GABGKBAKHDP.BJPLENOEKKK(DIDHNNMKJFE);
						GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.FBFriendsManager, "There is an error at GetOrRequestInvitableFriendList :{0} RawData:{1}", DIDHNNMKJFE.Error, DIDHNNMKJFE.RawResult);
					}
					if (DIDHNNMKJFE.Error == null && DIDHNNMKJFE.ResultDictionary != null && DIDHNNMKJFE.ResultDictionary.ContainsKey("invitable_friends"))
					{
						PDAPIGLEPGC.LHPHFDLGNMB = PDAPIGLEPGC.EPMADMGGCJF(DIDHNNMKJFE, "invitable_friends", false);
					}
					if (IMHLFAHONPP != null)
					{
						IMHLFAHONPP(PDAPIGLEPGC.CAGHAKHHFFP);
					}
				});
			}
			else
			{
				IMHLFAHONPP(null);
			}
		}

		internal void KDACLOKGNAM(IGraphResult DIDHNNMKJFE)
		{
			if (DIDHNNMKJFE.Error != null)
			{
				PGACJHKJAHA.GABGKBAKHDP.BJPLENOEKKK(DIDHNNMKJFE);
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.FBFriendsManager, "There is an error at GetOrRequestInvitableFriendList :{0} RawData:{1}", DIDHNNMKJFE.Error, DIDHNNMKJFE.RawResult);
			}
			if (DIDHNNMKJFE.Error == null && DIDHNNMKJFE.ResultDictionary != null && DIDHNNMKJFE.ResultDictionary.ContainsKey("invitable_friends"))
			{
				PDAPIGLEPGC.LHPHFDLGNMB = PDAPIGLEPGC.EPMADMGGCJF(DIDHNNMKJFE, "invitable_friends", false);
			}
			if (IMHLFAHONPP != null)
			{
				IMHLFAHONPP(PDAPIGLEPGC.CAGHAKHHFFP);
			}
		}
	}

	public const string EFIEJBDFNAK = "GameFriendsCount";

	private readonly HJBLKNBHMFJ NJCPCACOCGB;

	private readonly FFGIDMDAGOA IBIFOCEKDBF;

	private static JCGLFEMHECF KNPOFJNFLJB;

	private readonly Dictionary<string, string> EHJGHNDIOFG = new Dictionary<string, string>();

	private readonly Dictionary<string, string> GFCAGCAHGKF = new Dictionary<string, string>();

	private List<KNAKIANHFJN> IOKKDKKCKLI;

	private List<KNAKIANHFJN> LHPHFDLGNMB;

	[CompilerGenerated]
	private static Comparison<KNAKIANHFJN> EBCOMJBLIPP;

	public static JCGLFEMHECF GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new JCGLFEMHECF();
			}
			return KNPOFJNFLJB;
		}
	}

	public KNAKIANHFJN[] OHGJJONIHKM
	{
		get
		{
			return (IOKKDKKCKLI != null) ? IOKKDKKCKLI.ToArray() : null;
		}
	}

	public KNAKIANHFJN[] CAGHAKHHFFP
	{
		get
		{
			return (LHPHFDLGNMB != null) ? LHPHFDLGNMB.ToArray() : null;
		}
	}

	private JCGLFEMHECF()
	{
		NJCPCACOCGB = HJBLKNBHMFJ.GABGKBAKHDP;
		IBIFOCEKDBF = FFGIDMDAGOA.GABGKBAKHDP;
	}

	public string GJOKOCMIICE(string FAHBFGOFJGI)
	{
		string value = "No Name";
		EHJGHNDIOFG.TryGetValue(FAHBFGOFJGI, out value);
		return value;
	}

	public string MEPJPBBIHJF(string FAHBFGOFJGI)
	{
		string value = "No Name";
		GFCAGCAHGKF.TryGetValue(FAHBFGOFJGI, out value);
		return value;
	}

	public static string KLAFFBMDCLM(string ICIFDLJLAOB)
	{
		if (string.IsNullOrEmpty(ICIFDLJLAOB) || ICIFDLJLAOB.Trim().Length == 0)
		{
			return string.Empty;
		}
		try
		{
			ICIFDLJLAOB = ICIFDLJLAOB.Trim();
			ICIFDLJLAOB = Regex.Replace(ICIFDLJLAOB, "\\s{2,}", " ");
			string[] array = ICIFDLJLAOB.Split(' ');
			if (array.Length > 0)
			{
				string text = array[0] + " ";
				if (array.Length > 1)
				{
					text = text + array[array.Length - 1].Substring(0, 1) + ".";
				}
				return text;
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.FBFriendsManager, "FormatFacebookName Exception! Message:{0} Stack:{1}", ex.Message, ex.StackTrace);
		}
		return ICIFDLJLAOB;
	}

	public void LNFNDHKCKOP(Action<KNAKIANHFJN[]> IMHLFAHONPP)
	{
		if (IOKKDKKCKLI != null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FBFriendsManager, "GetOrRequestGameFriendList: Returning cached friends");
			if (IMHLFAHONPP != null)
			{
				IMHLFAHONPP(OHGJJONIHKM);
			}
			return;
		}
		PGACJHKJAHA.GABGKBAKHDP.EEPKEAPGPLH(delegate(bool EEKJMDHEJCK)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FBFriendsManager, "GetOrRequestGameFriendList: Getting friends from facebook. Success:" + EEKJMDHEJCK);
			if (EEKJMDHEJCK)
			{
				FB.API("/me?fields=id,name,friends.fields(picture.height(100).width(100),name).limit(1000)", HttpMethod.GET, delegate(IGraphResult DIDHNNMKJFE)
				{
					if (DIDHNNMKJFE.Error != null)
					{
						PGACJHKJAHA.GABGKBAKHDP.BJPLENOEKKK(DIDHNNMKJFE);
						GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.FBFriendsManager, "There is an error at GetOrRequestGameFriendList :{0} RawData:{1}", DIDHNNMKJFE.Error, DIDHNNMKJFE.RawResult);
					}
					if (DIDHNNMKJFE.Error == null && DIDHNNMKJFE.ResultDictionary != null && DIDHNNMKJFE.ResultDictionary.ContainsKey("friends"))
					{
						IOKKDKKCKLI = EPMADMGGCJF(DIDHNNMKJFE, "friends", true, true);
					}
					if (IMHLFAHONPP != null)
					{
						IMHLFAHONPP(OHGJJONIHKM);
					}
				});
			}
			else
			{
				IMHLFAHONPP(null);
			}
		});
	}

	public void EFOOEOGELDP(Action<KNAKIANHFJN[]> IMHLFAHONPP)
	{
		if (LHPHFDLGNMB != null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FBFriendsManager, "GetOrRequestInvitableFriendList: Returning cached friends");
			if (IMHLFAHONPP != null)
			{
				IMHLFAHONPP(CAGHAKHHFFP);
			}
			return;
		}
		PGACJHKJAHA.GABGKBAKHDP.EEPKEAPGPLH(delegate(bool EEKJMDHEJCK)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FBFriendsManager, "GetOrRequestInvitableFriendList: Getting friends from facebook. Success:" + EEKJMDHEJCK);
			if (EEKJMDHEJCK)
			{
				FB.API("/me?fields=id,name,invitable_friends.fields(picture.height(100).width(100),name).limit(1000)", HttpMethod.GET, delegate(IGraphResult DIDHNNMKJFE)
				{
					if (DIDHNNMKJFE.Error != null)
					{
						PGACJHKJAHA.GABGKBAKHDP.BJPLENOEKKK(DIDHNNMKJFE);
						GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.FBFriendsManager, "There is an error at GetOrRequestInvitableFriendList :{0} RawData:{1}", DIDHNNMKJFE.Error, DIDHNNMKJFE.RawResult);
					}
					if (DIDHNNMKJFE.Error == null && DIDHNNMKJFE.ResultDictionary != null && DIDHNNMKJFE.ResultDictionary.ContainsKey("invitable_friends"))
					{
						LHPHFDLGNMB = EPMADMGGCJF(DIDHNNMKJFE, "invitable_friends", false);
					}
					if (IMHLFAHONPP != null)
					{
						IMHLFAHONPP(CAGHAKHHFFP);
					}
				});
			}
			else
			{
				IMHLFAHONPP(null);
			}
		});
	}

	private List<KNAKIANHFJN> EPMADMGGCJF(IGraphResult DIDHNNMKJFE, string OOPAEFBBHEA, bool OADKAPJLIAC = true, bool PBDJLMMHPJO = false)
	{
		try
		{
			Dictionary<string, object> dictionary = DIDHNNMKJFE.ResultDictionary[OOPAEFBBHEA] as Dictionary<string, object>;
			if (dictionary == null)
			{
				return null;
			}
			List<object> list = dictionary["data"] as List<object>;
			if (list == null)
			{
				return null;
			}
			List<KNAKIANHFJN> list2 = new List<KNAKIANHFJN>();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			foreach (Dictionary<string, object> item in list)
			{
				string text = item["name"].ToString().CCCPHOAEONM();
				string text2 = text.Split(' ')[0];
				if (text2.Length > 10)
				{
					text2 = text2.Substring(0, 9) + ".";
				}
				EHJGHNDIOFG[item["id"].ToString()] = text2;
				GFCAGCAHGKF[item["id"].ToString()] = text;
				Dictionary<string, object> dictionary4 = item["picture"] as Dictionary<string, object>;
				Dictionary<string, object> dictionary5 = dictionary4["data"] as Dictionary<string, object>;
				list2.Add(new KNAKIANHFJN
				{
					PNGPLGHKFDI = text,
					EEFMIHDPJPG = item["id"].ToString(),
					PEGACMMPPBC = dictionary5["url"].ToString()
				});
				if (PBDJLMMHPJO)
				{
					dictionary2.Add(item["id"].ToString(), text);
				}
			}
			if (PBDJLMMHPJO)
			{
				IBIFOCEKDBF.PLGCGKINCFA(dictionary2);
			}
			if (OADKAPJLIAC)
			{
				list2.KFGEEKGAPDP();
			}
			else
			{
				list2.Sort((KNAKIANHFJN MNIMEAMHNMI, KNAKIANHFJN BCIHLCMFAEK) => MNIMEAMHNMI.PNGPLGHKFDI.CompareTo(BCIHLCMFAEK.PNGPLGHKFDI));
			}
			return list2;
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.FBFriendsManager, "There is an error parsing Friend list from facebook: Error:{0}, Stack:{1}", ex.Message, ex.StackTrace);
		}
		return null;
	}

	public void OMOKOKFNBKI()
	{
		EHJGHNDIOFG.Clear();
		GFCAGCAHGKF.Clear();
		IOKKDKKCKLI = null;
		LHPHFDLGNMB = null;
		IBIFOCEKDBF.OMOKOKFNBKI();
		NJCPCACOCGB.MFKBEDNLCJA("GameFriendsCount");
	}

	[CompilerGenerated]
	private static int OLNOIFEJKEI(KNAKIANHFJN MNIMEAMHNMI, KNAKIANHFJN BCIHLCMFAEK)
	{
		return MNIMEAMHNMI.PNGPLGHKFDI.CompareTo(BCIHLCMFAEK.PNGPLGHKFDI);
	}
}
