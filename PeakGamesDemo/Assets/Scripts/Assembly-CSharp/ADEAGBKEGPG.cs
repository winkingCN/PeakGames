using System;
using caravan.protobuf.messages;

public class ADEAGBKEGPG : NADPOFCHCON
{
	public const int JKJGLAALCDL = 100;

	private readonly Action<bool, bool> BLHAAFNBJHK;

	private FacebookConnectResponseMessage DJFBBNDIKED;

	private bool IEBFDFBKABH;

	public static bool CKOMGKGPEMO;

	public ADEAGBKEGPG(IKDMCJPBBIH KAGBOIDKAED, FacebookConnectResponseMessage CECLOLDKOLC, Action<bool, bool> PGDLCHCEKNF, GBJNCLLOCJB ODCADGABBHJ)
		: base(KAGBOIDKAED, ODCADGABBHJ)
	{
		if (ODCADGABBHJ == GBJNCLLOCJB.ResultSuccess)
		{
			CKOMGKGPEMO = CECLOLDKOLC.newFBUser == 1;
			DJFBBNDIKED = CECLOLDKOLC;
			IEBFDFBKABH = CECLOLDKOLC.consentAccepted == 1;
			BLHAAFNBJHK = PGDLCHCEKNF;
		}
	}

	public override void JLECFJEAFCD()
	{
		UserMetaData user = DJFBBNDIKED.user;
		bool hECCOJJEGCN = DJFBBNDIKED.newFBUser == 2;
		bool arg = COLFLCFNKKL.BIPHGBLNELE(user.userId, user.token, user.fbId, user.fbToken, hECCOJJEGCN);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ConsentHelper, "Facebook Login Reply: IsNewFBLogin:{0}. Consent Accepted:{1}", DJFBBNDIKED.newFBUser, IEBFDFBKABH);
		if (CKOMGKGPEMO)
		{
			int aCFDIDGFPKJ = GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Coins, 100);
			GEBAAFFGKJG.GABGKBAKHDP.IBFMAELGBGP(aCFDIDGFPKJ);
		}
		FJPHLKFHDOG fJPHLKFHDOG = FJPHLKFHDOG.GABGKBAKHDP;
		if (!IEBFDFBKABH)
		{
			fJPHLKFHDOG.JKACIDPMPMA(user.userId);
			fJPHLKFHDOG.CGHAGFOOPPA();
		}
		FJPHLKFHDOG.GABGKBAKHDP.PHHBNNGIKFF();
		if (BLHAAFNBJHK != null)
		{
			BLHAAFNBJHK(true, arg);
		}
	}

	public override void AIGOFKAJFBM()
	{
		if (BLHAAFNBJHK != null)
		{
			BLHAAFNBJHK(false, false);
		}
	}
}
