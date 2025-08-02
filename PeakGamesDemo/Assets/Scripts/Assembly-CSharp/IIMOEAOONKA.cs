using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.SceneTransitions;
using Facebook.Unity;
using UnityEngine.SceneManagement;
using Utils;

public class IIMOEAOONKA
{
	[CompilerGenerated]
	private sealed class NKIBDBJNNAJ
	{
		internal KAKOONJCENE LINOJBKHEOP;

		internal Action<bool> CNHMAFDJDGB;

		internal void AGFNGEFDHLA(bool DIDHNNMKJFE)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookHelper, "Facebook Login Result:{0}", DIDHNNMKJFE);
			if (DIDHNNMKJFE)
			{
				OHOMECJJEFI oHOMECJJEFI = new OHOMECJJEFI(delegate
				{
					PKJLDFEONLE(LINOJBKHEOP, CNHMAFDJDGB);
				});
				if (oHOMECJJEFI.JBGDBIIIPLM())
				{
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Login, "Full sync is needed!");
					KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH> { oHOMECJJEFI });
				}
				else
				{
					PKJLDFEONLE(LINOJBKHEOP, CNHMAFDJDGB);
				}
			}
			else
			{
				CIFBMADOOBJ(false, false, KAKOONJCENE.LoginInOk, CNHMAFDJDGB);
			}
		}

		internal void KDACLOKGNAM(bool ODCADGABBHJ, bool EPDLOFHNAKE)
		{
			PKJLDFEONLE(LINOJBKHEOP, CNHMAFDJDGB);
		}
	}

	[CompilerGenerated]
	private sealed class PHNJINEHJNF
	{
		internal KAKOONJCENE LINOJBKHEOP;

		internal Action<bool> CNHMAFDJDGB;

		internal void AGFNGEFDHLA(bool FJMBGIHMADE, bool MBLFKFGCHCK)
		{
			CIFBMADOOBJ(FJMBGIHMADE, MBLFKFGCHCK, LINOJBKHEOP, CNHMAFDJDGB);
		}
	}

	[CompilerGenerated]
	private sealed class MDBENPBGJPD
	{
		internal Action<bool> CNHMAFDJDGB;

		internal KAKOONJCENE OHIJFDCEPMP;

		internal void AGFNGEFDHLA(bool ODCADGABBHJ, bool EPDLOFHNAKE)
		{
			if (CNHMAFDJDGB != null)
			{
				CNHMAFDJDGB(true);
			}
			AFJPGLHKOID.LCLPALMIKKO(OFIAJMAPOCC, MEEBKKCGIGI, DCCBNOFACAN);
			if (OHIJFDCEPMP != KAKOONJCENE.NoSceneLoadNoDialog)
			{
				if (OHIJFDCEPMP != KAKOONJCENE.NoSceneLoad)
				{
					CaravanSceneManager.Load(GKBHIKONCKJ.Map);
					IKIAIFNKFBK = OHIJFDCEPMP;
				}
				else if (CaravanSceneManager.CurrentScene.Equals(GKBHIKONCKJ.GamePlay))
				{
					IKIAIFNKFBK = KAKOONJCENE.LoginInOk;
					CaravanSceneManager.Load(GKBHIKONCKJ.Map);
				}
				else
				{
					LoadingScreenDisplayer.Instance.StartFadeOut();
					FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.FacebookConnectedDialog, false);
				}
			}
			HGABPIDMBEK = false;
		}
	}

	public const string AHMPDAHHKBE = "fail";

	public const string HFAIILFGAKK = "popup";

	public const string LLBPPILIEGH = "leaderboard";

	public const string BCJAEMIPGKI = "prelevel_leaderboard";

	public const string BOHLPJMCDOK = "levelcompleted_leaderboard";

	public const string OIMGLEKMFHI = "settings";

	private static IIMOEAOONKA KNPOFJNFLJB;

	public static KAKOONJCENE IKIAIFNKFBK;

	private static bool NFOCLPEJFJI;

	private static string DCCBNOFACAN;

	private static string NBPLMDENJFG;

	private static string MEEBKKCGIGI;

	private static int OFIAJMAPOCC;

	[CompilerGenerated]
	private static Action<bool, bool> JANLDOMIIEF;

	[CompilerGenerated]
	private static Action<bool> GEBGDBLHLKE;

	public static bool HGABPIDMBEK { get; set; }

	public static IIMOEAOONKA GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new IIMOEAOONKA();
			}
			return KNPOFJNFLJB;
		}
	}

	private IIMOEAOONKA()
	{
	}

	public bool LCDPJOIPJJI()
	{
		return FB.IsInitialized && FB.IsLoggedIn && LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA == null && LECPGNKOABP.GABGKBAKHDP.KMHPHBJCPJH == null;
	}

	public void OKAAOGJIFKI()
	{
		GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Login, "Facebook id invalidated. Do soft logout");
		CLLBHONCEBE();
	}

	private void CLLBHONCEBE()
	{
		if (FB.IsLoggedIn || LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA != null || LECPGNKOABP.GABGKBAKHDP.KMHPHBJCPJH != null)
		{
			FB.LogOut();
			JCGLFEMHECF.GABGKBAKHDP.OMOKOKFNBKI();
			LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA = null;
			LECPGNKOABP.GABGKBAKHDP.KMHPHBJCPJH = null;
			LECPGNKOABP.GABGKBAKHDP.EDHAJCFFACD();
		}
	}

	public void KCLJAABIMED(string MJIOMBCHMNO, KAKOONJCENE LINOJBKHEOP = KAKOONJCENE.LoginInOk, Action<bool> CNHMAFDJDGB = null)
	{
		AIGGLALIJFL(MJIOMBCHMNO);
		if (!JHOAHCHHBCH.CCAJIIFJPFF())
		{
			FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.NoConnectionDialog, false);
			if (CNHMAFDJDGB != null)
			{
				CNHMAFDJDGB(false);
			}
			return;
		}
		if (ELBMHNOBHPN.EDAFBCMCHDH)
		{
			FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.FacebookConnectFailedDialog, false);
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
			{
				new AEJCEEFPJIA()
			});
			if (CNHMAFDJDGB != null)
			{
				CNHMAFDJDGB(true);
			}
			return;
		}
		MEEBKKCGIGI = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString();
		OFIAJMAPOCC = BOHDPGGAJMG();
		NFOCLPEJFJI = SceneManager.GetActiveScene().name == "StartScene";
		if (!NFOCLPEJFJI)
		{
			LoadingScreenDisplayer.Instance.ShowLoading(KLKAGJKCKBE.FacebookLoading);
		}
		else
		{
			LoadingScreenDisplayer.Instance.ShowLoading(KLKAGJKCKBE.Initial);
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Login, "Facebook Login Started");
		OKBBFMBDFDF(LINOJBKHEOP, CNHMAFDJDGB);
	}

	private static void AIGGLALIJFL(string MJIOMBCHMNO)
	{
		if (MJIOMBCHMNO != "fail")
		{
			DCCBNOFACAN = MJIOMBCHMNO;
		}
		if (DCCBNOFACAN == null)
		{
			DCCBNOFACAN = "popup";
		}
	}

	private static void OKBBFMBDFDF(KAKOONJCENE LINOJBKHEOP, Action<bool> CNHMAFDJDGB)
	{
		HGABPIDMBEK = true;
		PGACJHKJAHA.GABGKBAKHDP.LAPGGGMFPFB(delegate(bool DIDHNNMKJFE)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.FacebookHelper, "Facebook Login Result:{0}", DIDHNNMKJFE);
			if (DIDHNNMKJFE)
			{
				OHOMECJJEFI oHOMECJJEFI = new OHOMECJJEFI(delegate
				{
					PKJLDFEONLE(LINOJBKHEOP, CNHMAFDJDGB);
				});
				if (oHOMECJJEFI.JBGDBIIIPLM())
				{
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Login, "Full sync is needed!");
					KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH> { oHOMECJJEFI });
				}
				else
				{
					PKJLDFEONLE(LINOJBKHEOP, CNHMAFDJDGB);
				}
			}
			else
			{
				CIFBMADOOBJ(false, false, KAKOONJCENE.LoginInOk, CNHMAFDJDGB);
			}
		});
	}

	private static void PKJLDFEONLE(KAKOONJCENE LINOJBKHEOP, Action<bool> CNHMAFDJDGB)
	{
		List<IKDMCJPBBIH> list = new List<IKDMCJPBBIH>();
		list.Add(new CIOEMMAFNDM(delegate(bool FJMBGIHMADE, bool MBLFKFGCHCK)
		{
			CIFBMADOOBJ(FJMBGIHMADE, MBLFKFGCHCK, LINOJBKHEOP, CNHMAFDJDGB);
		}));
		List<IKDMCJPBBIH> hDECNOABBDG = list;
		KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(hDECNOABBDG);
	}

	private static void CIFBMADOOBJ(bool DIDHNNMKJFE, bool PFKJIKEBDGG, KAKOONJCENE OHIJFDCEPMP = KAKOONJCENE.LoginInOk, Action<bool> CNHMAFDJDGB = null)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Login, "Facebook attempt resulted: {0} (Sync: {1})", DIDHNNMKJFE, PFKJIKEBDGG);
		if (DIDHNNMKJFE)
		{
			if (PFKJIKEBDGG)
			{
				KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
				{
					new OHOMECJJEFI(delegate
					{
						if (CNHMAFDJDGB != null)
						{
							CNHMAFDJDGB(true);
						}
						AFJPGLHKOID.LCLPALMIKKO(OFIAJMAPOCC, MEEBKKCGIGI, DCCBNOFACAN);
						if (OHIJFDCEPMP != KAKOONJCENE.NoSceneLoadNoDialog)
						{
							if (OHIJFDCEPMP != KAKOONJCENE.NoSceneLoad)
							{
								CaravanSceneManager.Load(GKBHIKONCKJ.Map);
								IKIAIFNKFBK = OHIJFDCEPMP;
							}
							else if (CaravanSceneManager.CurrentScene.Equals(GKBHIKONCKJ.GamePlay))
							{
								IKIAIFNKFBK = KAKOONJCENE.LoginInOk;
								CaravanSceneManager.Load(GKBHIKONCKJ.Map);
							}
							else
							{
								LoadingScreenDisplayer.Instance.StartFadeOut();
								FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.FacebookConnectedDialog, false);
							}
						}
						HGABPIDMBEK = false;
					})
				});
				return;
			}
			if (CNHMAFDJDGB != null)
			{
				CNHMAFDJDGB(true);
			}
			AFJPGLHKOID.LCLPALMIKKO(OFIAJMAPOCC, MEEBKKCGIGI, DCCBNOFACAN);
			if (OHIJFDCEPMP != KAKOONJCENE.NoSceneLoadNoDialog)
			{
				if (OHIJFDCEPMP != KAKOONJCENE.NoSceneLoad)
				{
					CaravanSceneManager.Load(GKBHIKONCKJ.Map);
					IKIAIFNKFBK = OHIJFDCEPMP;
				}
				else
				{
					LoadingScreenDisplayer.Instance.StartFadeOut();
					FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.FacebookConnectedDialog, false);
				}
			}
			HGABPIDMBEK = false;
		}
		else
		{
			LoadingScreenDisplayer.Instance.StartFadeOut(null, true);
			IKIAIFNKFBK = KAKOONJCENE.None;
			if (CNHMAFDJDGB != null)
			{
				CNHMAFDJDGB(false);
			}
			if (!NFOCLPEJFJI)
			{
				DialogLibrary.GABGKBAKHDP.ShowDialogBackgroundFast();
				FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.FacebookConnectFailedDialog, false);
			}
			HGABPIDMBEK = false;
		}
	}

	public void DNNNNBBFNDG()
	{
		if (!JHOAHCHHBCH.CCAJIIFJPFF())
		{
			FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.NoConnectionDialog, false);
			return;
		}
		if (ELBMHNOBHPN.EDAFBCMCHDH)
		{
			FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.FacebookLogoutFailedDialog, false);
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
			{
				new AEJCEEFPJIA()
			});
			return;
		}
		NBPLMDENJFG = LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA;
		OFIAJMAPOCC = BOHDPGGAJMG();
		MEEBKKCGIGI = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString();
		if (!LoadingScreenDisplayer.Instance.CDIJIMCMCOE)
		{
			LoadingScreenDisplayer.Instance.ShowLoading(KLKAGJKCKBE.FacebookLoading);
		}
		OHOMECJJEFI oHOMECJJEFI = new OHOMECJJEFI(PLIJGCCCKCB);
		if (oHOMECJJEFI.JBGDBIIIPLM())
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Login, "Full sync is needed!");
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH> { oHOMECJJEFI });
		}
		else
		{
			PLIJGCCCKCB(true);
		}
	}

	private static void PLIJGCCCKCB(bool ODCADGABBHJ, bool EPDLOFHNAKE = false)
	{
		if (ODCADGABBHJ)
		{
			PGACJHKJAHA.GABGKBAKHDP.DJKMGOCLCHA(CFDLMLEADBK);
			return;
		}
		LoadingScreenDisplayer.Instance.StartFadeOut();
		FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.FacebookLogoutFailedDialog, false);
		IKIAIFNKFBK = KAKOONJCENE.None;
	}

	private static void CFDLMLEADBK(bool DIDHNNMKJFE)
	{
		if (DIDHNNMKJFE)
		{
			FMEFHCIEJDO.OIOPIEFFMFM();
			GLPICIAEDKE.PGBBKNEAAPH();
			GLPICIAEDKE.NDIBOFJAFBJ();
			AFJPGLHKOID.GIGKJIFHNIF(OFIAJMAPOCC, NBPLMDENJFG, MEEBKKCGIGI);
		}
		IKIAIFNKFBK = ((!DIDHNNMKJFE) ? KAKOONJCENE.LogoutFailed : KAKOONJCENE.LogOutOk);
		CaravanSceneManager.Load(GKBHIKONCKJ.Map);
	}

	private static int BOHDPGGAJMG()
	{
		IDFPAFEJPPH iDFPAFEJPPH = IDFPAFEJPPH.GABGKBAKHDP;
		return (!iDFPAFEJPPH.HGNJBHGBLIN) ? (MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1) : (-1 * iDFPAFEJPPH.KOPMPMIFHNF);
	}
}
