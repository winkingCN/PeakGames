using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using caravan.protobuf.messages;

public class BLEMFIKALJF : NADPOFCHCON
{
	private readonly InventoryMetaData ODIIMFEIGPP;

	private readonly Action<bool, bool> EDCHPJKMOBD;

	private readonly List<UserLevelProgressMetaData> NKOFJPHGJAA;

	private readonly ChestMetaData BLKGJFDFJAO;

	private readonly long DBDLPCKGFLM;

	private readonly bool PCDAFDGCJIF = true;

	private readonly bool IIMOECJAOAB;

	public BLEMFIKALJF(IKDMCJPBBIH KAGBOIDKAED, SyncFullResponseMessage IEJCPMCPHMM, Action<bool, bool> BMHDOOHDKBF, GBJNCLLOCJB OJCKIOENBEL)
		: base(KAGBOIDKAED, OJCKIOENBEL)
	{
		ODIIMFEIGPP = IEJCPMCPHMM.inventory;
		InventoryMetaData deltaInventory = IEJCPMCPHMM.deltaInventory;
		if (deltaInventory != null)
		{
			GEBAAFFGKJG.JPNPCPMAMFL = Time.realtimeSinceStartup;
			PCDAFDGCJIF = false;
			ODIIMFEIGPP.anvil += deltaInventory.anvil;
			if (ODIIMFEIGPP.anvil < 0)
			{
				ODIIMFEIGPP.anvil = 0;
			}
			ODIIMFEIGPP.bomb += deltaInventory.bomb;
			if (ODIIMFEIGPP.bomb < 0)
			{
				ODIIMFEIGPP.bomb = 0;
			}
			ODIIMFEIGPP.boxingGlove += deltaInventory.boxingGlove;
			if (ODIIMFEIGPP.boxingGlove < 0)
			{
				ODIIMFEIGPP.boxingGlove = 0;
			}
			ODIIMFEIGPP.coins += deltaInventory.coins;
			if (ODIIMFEIGPP.coins < 0)
			{
				ODIIMFEIGPP.coins = 0;
			}
			ODIIMFEIGPP.discoBall += deltaInventory.discoBall;
			if (ODIIMFEIGPP.discoBall < 0)
			{
				ODIIMFEIGPP.discoBall = 0;
			}
			ODIIMFEIGPP.extra5Moves += deltaInventory.extra5Moves;
			if (ODIIMFEIGPP.extra5Moves < 0)
			{
				ODIIMFEIGPP.extra5Moves = 0;
			}
			ODIIMFEIGPP.hammer += deltaInventory.hammer;
			if (ODIIMFEIGPP.anvil < 0)
			{
				ODIIMFEIGPP.anvil = 0;
			}
			ODIIMFEIGPP.life += deltaInventory.life;
			if (ODIIMFEIGPP.life > 5)
			{
				ODIIMFEIGPP.life = 5;
			}
			if (ODIIMFEIGPP.life < 0)
			{
				ODIIMFEIGPP.life = 0;
			}
			ODIIMFEIGPP.rocket += deltaInventory.rocket;
			if (ODIIMFEIGPP.rocket < 0)
			{
				ODIIMFEIGPP.rocket = 0;
			}
			ODIIMFEIGPP.shuffle += deltaInventory.shuffle;
			if (ODIIMFEIGPP.shuffle < 0)
			{
				ODIIMFEIGPP.shuffle = 0;
			}
			ODIIMFEIGPP.stars += deltaInventory.stars;
			if (ODIIMFEIGPP.stars < 0)
			{
				ODIIMFEIGPP.stars = 0;
			}
			ODIIMFEIGPP.unlimitedLife += deltaInventory.unlimitedLife;
			if (ODIIMFEIGPP.unlimitedLife < 0)
			{
				ODIIMFEIGPP.unlimitedLife = 0;
			}
			ODIIMFEIGPP.piggyBank += deltaInventory.piggyBank;
			if (ODIIMFEIGPP.piggyBank < 0)
			{
				ODIIMFEIGPP.piggyBank = 0;
			}
		}
		else
		{
			PCDAFDGCJIF = true;
		}
		NKOFJPHGJAA = IEJCPMCPHMM.levelProgress;
		BLKGJFDFJAO = IEJCPMCPHMM.chests;
		EDCHPJKMOBD = BMHDOOHDKBF;
		DBDLPCKGFLM = IEJCPMCPHMM.serverTime;
		IIMOECJAOAB = IEJCPMCPHMM.clientChosen == 1;
	}

	public override void JLECFJEAFCD()
	{
		if (ELBMHNOBHPN.DJGMHLLAGLE)
		{
			ELBMHNOBHPN.EIIELGHFBBG();
		}
		new LLCJMMBBLEH(JIGAOIMHLHM(), true, IAJNLGPHGLO.App);
	}

	private IEnumerator JIGAOIMHLHM()
	{
		MADFPPJCOIM.GABGKBAKHDP.OMOKOKFNBKI();
		if (NKOFJPHGJAA != null && NKOFJPHGJAA.Count > 0)
		{
			NKOFJPHGJAA.Sort((UserLevelProgressMetaData MNIMEAMHNMI, UserLevelProgressMetaData BCIHLCMFAEK) => (MNIMEAMHNMI.levelNo > BCIHLCMFAEK.levelNo) ? (-1) : ((MNIMEAMHNMI.levelNo != BCIHLCMFAEK.levelNo) ? 1 : 0));
			UserLevelProgressMetaData userLevelProgressMetaData = NKOFJPHGJAA[0];
			MADFPPJCOIM.GABGKBAKHDP.CGINNGBOKAP(userLevelProgressMetaData.levelNo, userLevelProgressMetaData.score, userLevelProgressMetaData.stars);
		}
		OIAJPMNJGLK.FCNGEIHAGIB(DBDLPCKGFLM, ODIIMFEIGPP.lifeTime);
		GEBAAFFGKJG.GABGKBAKHDP.ENEBPKFEOJN(ODIIMFEIGPP, PCDAFDGCJIF);
		OIAJPMNJGLK.FCNGEIHAGIB(DBDLPCKGFLM);
		PJPPADHKGHN.GABGKBAKHDP.CDOOPEMANMI();
		PJPPADHKGHN.GABGKBAKHDP.BOLHHAJPKMH(ODIIMFEIGPP.unlimitedLife, true);
		NDGOJGLPIJF.GABGKBAKHDP.PJNCDCKHGDK(BLKGJFDFJAO);
		if (!PCDAFDGCJIF)
		{
			GEBAAFFGKJG.GABGKBAKHDP.EBDHNAICMIB();
		}
		yield return null;
		if (EDCHPJKMOBD != null)
		{
			EDCHPJKMOBD(true, IIMOECJAOAB);
		}
		KCJEIIEBGEN();
		OneSignal.SendTag("LevelTag", (MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1).ToString());
	}

	public override void AIGOFKAJFBM()
	{
		if (EDCHPJKMOBD != null)
		{
			EDCHPJKMOBD(false, false);
		}
	}

	private static void KCJEIIEBGEN()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ChampionsLeague, "SyncLevelCommand and CheckStatusCommand called after SyncFullCommand.");
		List<IKDMCJPBBIH> list = new List<IKDMCJPBBIH>();
		IDFPAFEJPPH iDFPAFEJPPH = IDFPAFEJPPH.GABGKBAKHDP;
		if (iDFPAFEJPPH.HGNJBHGBLIN && !IDFPAFEJPPH.GABGKBAKHDP.KDFCPCAHFPC())
		{
			PKHCHGIKLED item = new PKHCHGIKLED(iDFPAFEJPPH.PDGLECFDLJJ, iDFPAFEJPPH.KOPMPMIFHNF, iDFPAFEJPPH.MMFJEAJBJJG, iDFPAFEJPPH.NBJMMBIGCOB);
			list.Add(item);
		}
		list.Add(iDFPAFEJPPH.EBAMEPLFLKO());
		KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(list);
	}
}
