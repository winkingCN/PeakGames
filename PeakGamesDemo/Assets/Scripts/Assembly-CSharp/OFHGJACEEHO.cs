using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Dialogs;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Tutorials;
using Assets.Scripts.SceneTransitions;
using Assets.Scripts.Utils.Analytics;
using caravan.protobuf.messages;

public class OFHGJACEEHO : NADPOFCHCON
{
	private readonly List<IKDMCJPBBIH> OPBKBIKAFPE;

	public UserMetaData CONAHFNOHKC;

	private readonly long DBDLPCKGFLM;

	private readonly bool IEBFDFBKABH;

	private readonly GBJNCLLOCJB AACDKEBDPBF;

	public OFHGJACEEHO(OKGCOMJOMPO KAGBOIDKAED, LoginResponseMessage ODPOKBKAJJE, List<IKDMCJPBBIH> DMBGAGLAIED, GBJNCLLOCJB OJCKIOENBEL)
		: base(KAGBOIDKAED, OJCKIOENBEL)
	{
		AACDKEBDPBF = OJCKIOENBEL;
		OPBKBIKAFPE = DMBGAGLAIED;
		if (OJCKIOENBEL == GBJNCLLOCJB.ResultSuccess)
		{
			CONAHFNOHKC = ODPOKBKAJJE.user;
			DBDLPCKGFLM = ODPOKBKAJJE.serverTime;
			IEBFDFBKABH = ODPOKBKAJJE.consentAccepted == 1;
		}
	}

	public override void AIGOFKAJFBM()
	{
		if (AACDKEBDPBF != GBJNCLLOCJB.ResultDeviceBan)
		{
			KIHMBFDKLJM.DFADLCFOHHN = false;
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Login, "Login in progress completed");
		if (OPBKBIKAFPE == null)
		{
			return;
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Login, "Original commands will called with failure.");
		foreach (IKDMCJPBBIH item in OPBKBIKAFPE)
		{
			item.GKPOLPBJIBG(null);
			item.HBCDLJHLOMK(false, GBJNCLLOCJB.InitFailed);
		}
	}

	public override void JLECFJEAFCD()
	{
		KIHMBFDKLJM.DFADLCFOHHN = false;
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Login, "Login in progress completed");
		LECPGNKOABP lECPGNKOABP = LECPGNKOABP.GABGKBAKHDP;
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Login, "Login Response > **** USER ID IS : {0} **** Local User Id is: {1}", CONAHFNOHKC.userId, lECPGNKOABP.GDMECFECCOM);
		if (lECPGNKOABP.GDMECFECCOM > 0 && lECPGNKOABP.GDMECFECCOM != CONAHFNOHKC.userId)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Login, "Backend is changing user id. This is unexpected. Old:{0} New:{1}", lECPGNKOABP.GDMECFECCOM, CONAHFNOHKC.userId);
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Login, "Consent Accepted{0} for user:{1}. InitialConsent:{2}", IEBFDFBKABH, CONAHFNOHKC.userId, FJPHLKFHDOG.GABGKBAKHDP.AANIHNPAAGN());
		if (lECPGNKOABP.GDMECFECCOM == 0)
		{
			lECPGNKOABP.GDMECFECCOM = CONAHFNOHKC.userId;
			lECPGNKOABP.FIPPLABNDON = CONAHFNOHKC.token;
			lECPGNKOABP.LEOJICDDHHF = null;
			lECPGNKOABP.EDHAJCFFACD();
			try
			{
				if (PeakAnalytics.LOPFOEHECGB != null)
				{
					PeakAnalytics.UpdateAdjustSessionParameters();
					DJFPMCMLPJJ.MKHCFGLBCCD(PeakAnalytics.LOPFOEHECGB.GetAnalyticsUserId(), CONAHFNOHKC.userId.ToString());
				}
				EIMPOHFHFMO.GBPHBJEJODP();
				OneSignal.SendTag("UserIdTag", lECPGNKOABP.GDMECFECCOM.ToString());
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Login, "Exception on login reply when informing third party SDKs: {0}", ex.Message);
			}
		}
		bool flag = CONAHFNOHKC.restore == 1;
		if (flag)
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Login, "Restore requested.");
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
			{
				new OHOMECJJEFI(LIKCJCKGFAL),
				IDFPAFEJPPH.GABGKBAKHDP.EBAMEPLFLKO()
			});
		}
		else
		{
			OIAJPMNJGLK.FCNGEIHAGIB(DBDLPCKGFLM);
			LIKCJCKGFAL(false);
		}
		DIGGBGADIGJ.MPGDOEJHCOH(flag);
		FNBPLBGNBNF.CGILBMHAIFJ(CONAHFNOHKC.userId, flag);
		FJPHLKFHDOG fJPHLKFHDOG = FJPHLKFHDOG.GABGKBAKHDP;
		if (!IEBFDFBKABH)
		{
			fJPHLKFHDOG.JKACIDPMPMA(CONAHFNOHKC.userId);
		}
		if (!fJPHLKFHDOG.AANIHNPAAGN())
		{
			fJPHLKFHDOG.GAHJOBIBKIK();
			fJPHLKFHDOG.NFMELKHELIJ();
		}
		else if (!IEBFDFBKABH)
		{
			fJPHLKFHDOG.CGHAGFOOPPA();
		}
		fJPHLKFHDOG.PHHBNNGIKFF();
		lECPGNKOABP.FBJPAPPABGJ = false;
	}

	private void LIKCJCKGFAL(bool DIDHNNMKJFE, bool EPDLOFHNAKE = false)
	{
		DMEKKNGOCNH.GABGKBAKHDP.DJPPLNADDDA();
		if (OPBKBIKAFPE != null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Login, "Init completed and executing original commands.");
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(OPBKBIKAFPE);
		}
		if (DIDHNNMKJFE)
		{
			new LLCJMMBBLEH(JCGDENBEBAD(), true, IAJNLGPHGLO.App);
		}
	}

	private static IEnumerator JCGDENBEBAD()
	{
		while ((CaravanSceneManager.CurrentScene != GKBHIKONCKJ.GamePlay && CaravanSceneManager.CurrentScene != GKBHIKONCKJ.Map) || CaravanSceneManager.GDLJAINDFOJ)
		{
			yield return null;
		}
		if (GoalsBannerDialog.Instance != null)
		{
			GoalsBannerDialog.Instance.SkipAnimation();
			while (GoalsBannerDialog.Instance != null)
			{
				yield return null;
			}
		}
		if (TutorialManager.Instance != null)
		{
			TutorialManager.Instance.RemoveSelf();
			yield return null;
			while (TutorialManager.Instance != null)
			{
				yield return null;
			}
		}
		bool flag = CaravanSceneManager.CurrentScene == GKBHIKONCKJ.GamePlay && LevelBuilder.GameplayUserId == LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM && LevelBuilder.DidUseLife;
		CaravanSceneManager.Load(GKBHIKONCKJ.Map, "Refreshing");
		if (flag)
		{
			PJPPADHKGHN.GABGKBAKHDP.CJNFILFKEAC();
		}
	}
}
