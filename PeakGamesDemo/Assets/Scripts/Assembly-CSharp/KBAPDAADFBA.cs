using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Utils;
using UnityEngine;
using caravan.protobuf.messages;

public class KBAPDAADFBA : NADPOFCHCON
{
	private const string EKLILGBGLGD = "skip";

	private const string OMMKKKHLBPB = "forced";

	private readonly PingResponseMessage OPGMFKFIBNB;

	private readonly int IBHDKBDNCMG;

	[CompilerGenerated]
	private static Action<bool> JANLDOMIIEF;

	[CompilerGenerated]
	private static Action<bool, bool> GEBGDBLHLKE;

	[CompilerGenerated]
	private static NCHDGFIAHLI FNBHFDJDLFP;

	public KBAPDAADFBA(IKDMCJPBBIH KAGBOIDKAED, GBJNCLLOCJB OJCKIOENBEL, PingResponseMessage LHIEOCECNOJ, int EAIKCEDMGCP)
		: base(KAGBOIDKAED, OJCKIOENBEL)
	{
		IBHDKBDNCMG = EAIKCEDMGCP;
		OPGMFKFIBNB = LHIEOCECNOJ;
	}

	protected override GBJNCLLOCJB BMMMAFJBJMD()
	{
		return (IBHDKBDNCMG != FocusListener.MOGJKPIEGGL) ? GBJNCLLOCJB.ClientNotInSameFocus : GBJNCLLOCJB.ResultSuccess;
	}

	public override void JLECFJEAFCD()
	{
		int command = OPGMFKFIBNB.command;
		CHGJFENGDIA(command);
		BCADJHDDIJB(command);
		if (!ELBMHNOBHPN.LIGNHNEACJE)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PingReply, "LifeHack control is disabled by backend.");
			OBJABHBEDGP();
			return;
		}
		PJPPADHKGHN.GABGKBAKHDP.PMBGCACJIHD();
		if (ELBMHNOBHPN.DJGMHLLAGLE && !ELBMHNOBHPN.GHDNFKHHCPP)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PingReply, "Previous hack check is on, no need to process this ping reply.");
			return;
		}
		bool flag = !PJPPADHKGHN.GABGKBAKHDP.DGEJJAIINIL(OPGMFKFIBNB.serverTime);
		ELBMHNOBHPN.KEIAPEBEGPL(flag);
		if (flag)
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.PingReply, "Full sync is needed because of life hack.");
			CAGBGIHKHEJ.GABGKBAKHDP.NOIIEHLLENG(2);
			DNNAECANJFN();
		}
		else
		{
			OBJABHBEDGP();
		}
	}

	private void OBJABHBEDGP()
	{
		OIAJPMNJGLK.FCNGEIHAGIB(OPGMFKFIBNB.serverTime);
		string text = LECPGNKOABP.GABGKBAKHDP.MPIDFEMEEIJ;
		int num = GFHPEDILAJG.GABGKBAKHDP.OMBKMIINHMF;
		if (!(Time.realtimeSinceStartup - GEBAAFFGKJG.JPNPCPMAMFL < 5f))
		{
			if (!"skip".Equals(OPGMFKFIBNB.lastDeviceId) && text != null && !text.Equals(OPGMFKFIBNB.lastDeviceId))
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PingReply, "Full sync is needed, because deviceId is different. MyDeviceId:{0}, ServerDeviceId:{1}", text, OPGMFKFIBNB.lastDeviceId);
				DNNAECANJFN();
			}
			else if (OPGMFKFIBNB.syncId != num && OPGMFKFIBNB.syncId - 1 != num)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PingReply, "Full sync is needed, because syncId is different.MySyncId:{0}, ServerSyncId:{1}", num, OPGMFKFIBNB.syncId);
				DNNAECANJFN();
			}
			else
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PingReply, "Ping is healthy, send start commands.");
				KBEGNPKLMDE.IAEBCJLMJJO();
			}
		}
	}

	private static void IBDBPGIEAJE(bool ODCADGABBHJ, string NOKFDFNMBMJ)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PingReply, "Forced log compress result: {0}", ODCADGABBHJ);
		if (ODCADGABBHJ)
		{
			MFODECOOJLA item = new MFODECOOJLA("forced@peakgames.net", "FORCED Ticket", NOKFDFNMBMJ, BFAGEPJFCDN);
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH> { item });
		}
	}

	private static void BFAGEPJFCDN(bool DIDHNNMKJFE)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PingReply, "Forced log result: {0}", DIDHNNMKJFE);
	}

	public override void AIGOFKAJFBM()
	{
		OIAJPMNJGLK.DAGBPPPFPPK();
		OIAJPMNJGLK.NMHNDKBIEJA();
		if (ELBMHNOBHPN.LEIIEJAJCHN())
		{
			new LLCJMMBBLEH(CJLBPGBADBH(), true, IAJNLGPHGLO.App);
		}
	}

	private static void DNNAECANJFN()
	{
		List<IKDMCJPBBIH> list = new List<IKDMCJPBBIH>();
		list.Add(new OHOMECJJEFI(CDIGGKFJCJP.CCBPMBBOAKE));
		List<IKDMCJPBBIH> list2 = list;
		if (IDFPAFEJPPH.APCILMENFLJ())
		{
			list2.Add(IDFPAFEJPPH.GABGKBAKHDP.EBAMEPLFLKO());
		}
		KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(list2);
	}

	private static IEnumerator CJLBPGBADBH()
	{
		yield return MCJHHDACJBG.CHFOIGLAMPN;
		KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
		{
			new AEJCEEFPJIA()
		});
	}

	private static void CHGJFENGDIA(int INAJDKINGHH)
	{
		if (CCJBDEGNEAL.GKIBJAOFBHB(INAJDKINGHH, 0))
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PingReply, "Forced log requested.");
			GBFAPADEBEC.IIHHGNAACEG(IBDBPGIEAJE);
		}
		if (CCJBDEGNEAL.GKIBJAOFBHB(INAJDKINGHH, 1))
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PingReply, "Clear cloud data requested.");
			PHHKFLHAFHG.PEDBOELHCPG();
		}
	}

	private static void BCADJHDDIJB(int INAJDKINGHH)
	{
		ELBMHNOBHPN.LIGNHNEACJE = CCJBDEGNEAL.GKIBJAOFBHB(INAJDKINGHH, 8);
		KMBNIBGIHGH.LFPDGNCFIMP(CCJBDEGNEAL.GKIBJAOFBHB(INAJDKINGHH, 9));
		EIPCLBONPLC.FLBLFCFFBNM = CCJBDEGNEAL.GKIBJAOFBHB(INAJDKINGHH, 10);
		PlayerPrefs.SetInt("InventoryLimitFlag", CCJBDEGNEAL.GKIBJAOFBHB(INAJDKINGHH, 12) ? 1 : 0);
		PlayerPrefs.SetInt("PeakNotifications", CCJBDEGNEAL.GKIBJAOFBHB(INAJDKINGHH, 13) ? 1 : 0);
	}
}
