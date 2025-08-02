using System;
using System.Collections;

public class CKOLIJKKNBA : CFDGIGBLONH
{
	public override void OGNENMNMAIN(string FCEEGNFABAF, string OEFCOJLNCKP, string NIIMJJEBHCA, string LNCBFPEKHDJ)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.NativeToolsSupport, "Editor: Show native force update popup: {0} - {1} - {2} - {3}", FCEEGNFABAF, OEFCOJLNCKP, NIIMJJEBHCA, LNCBFPEKHDJ);
	}

	public override void JNOCJCGINCB()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.NativeToolsSupport, "Editor: Dismiss native force update popup if exists.");
	}

	public override bool KJNBMEGHDGE()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.NativeToolsSupport, "Editor: Native request review popup is not supported.");
		return false;
	}

	public override bool GFMLBLFOHDG()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.NativeToolsSupport, "Editor: Native request review popup is not supported.");
		return false;
	}

	public override bool KPBDKDPAKBC()
	{
		return true;
	}

	public override void NJJBJKCPJLA(string HHIHHPHCEJG)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.NativeToolsSupport, "Editor: Traceroute is not supported.");
	}

	public override void EGGICLINDJH(string IKNCPEPOKGJ, string EDDNOJDPMCF)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.NativeToolsSupport, "Editor: Write to cloud.");
	}

	public override void LMGDDIIJMHF(string IKNCPEPOKGJ, Action<string> CMACNIMFJHP)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.NativeToolsSupport, "Editor: Cloud read triggered.", IKNCPEPOKGJ);
		new LLCJMMBBLEH(PHBOCMCANLG(CMACNIMFJHP), true, IAJNLGPHGLO.App);
	}

	private static IEnumerator PHBOCMCANLG(Action<string> CMACNIMFJHP)
	{
		yield return MCJHHDACJBG.CHFOIGLAMPN;
		CMACNIMFJHP(string.Empty);
	}

	public override void EFBEHJNKFCD(string FCEEGNFABAF, string HOMONAAFMFH, string LDHECNOPBNK, string ICPIDDPDMKP, string KMJJAKAMOKO, string OELLFNCIJFH, string KGKGAEMGFIF)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.NativeToolsSupport, "Editor: Show Consent Popup is not supported.");
		FJPHLKFHDOG.JODHDOKPPCN();
	}

	public override void NKPAGBPCFMI()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.NativeToolsSupport, "Editor: Hide Native Popup is not supported.");
	}

	public override LEJICLFDBAJ BEEIBDODHCD()
	{
		return new LEJICLFDBAJ(0f, 0f);
	}
}
