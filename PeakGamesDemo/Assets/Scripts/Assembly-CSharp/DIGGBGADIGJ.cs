using System.Collections.Generic;
using LevelLoaderScene;
using UnityEngine;

public class DIGGBGADIGJ : DLDDFKDFKEF
{
	private static DIGGBGADIGJ KNPOFJNFLJB;

	private const int DBPGKFCDEML = 30;

	private const int ECLENKKEOGD = 51;

	private static int FHIIFBJOKND = 51;

	private const string DOHHMDPIABJ = "CrownRush";

	private const string MOJONFCBOEM = "CrownRushBackup";

	private const int GKLLEABMIKB = 3;

	private readonly string JGFKDIEGAAH;

	private readonly HJBLKNBHMFJ GOEMHMEALGJ;

	private const int FHLLDBIPPCL = 20;

	public int BGKIIAJNHLL { get; private set; }

	public int GKKBMMHNFLE { get; private set; }

	public bool ICNIGMDCCLN { get; private set; }

	public static DIGGBGADIGJ GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new DIGGBGADIGJ();
			}
			return KNPOFJNFLJB;
		}
	}

	public static bool DFGKPMCBFNL
	{
		get
		{
			return MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() >= FHIIFBJOKND && !LevelLoaderController.IsOnlineLevel && !LevelLoaderController.IsOfflineLevel;
		}
	}

	private DIGGBGADIGJ()
	{
		GOEMHMEALGJ = HJBLKNBHMFJ.GABGKBAKHDP;
		JGFKDIEGAAH = EHCFPIHGGFM();
		string text = GOEMHMEALGJ.LIANKDMAHFM(JGFKDIEGAAH);
		FHIIFBJOKND = ((text == null) ? 51 : 30);
		if (DFGKPMCBFNL)
		{
			GLDLFECLFPB();
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Crown, "CrownRushHelper instance is created with MinLevel: {0} for key {1}", FHIIFBJOKND, JGFKDIEGAAH);
	}

	public void OMOKOKFNBKI()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Crown, "CrownRush is reset after user change.");
		GOEMHMEALGJ.KFCIOFNMKDA("CrownRushBackup");
		KNPOFJNFLJB = null;
		FHIIFBJOKND = 51;
	}

	public void LGDBADICPEN()
	{
		ICNIGMDCCLN = false;
	}

	public void MAFEKIKFNIJ()
	{
		FGAFPNCMKIN(0, JGFKDIEGAAH);
		if (BGKIIAJNHLL == 0)
		{
			GOEMHMEALGJ.KFCIOFNMKDA("CrownRushBackup");
		}
		else
		{
			FGAFPNCMKIN(BGKIIAJNHLL, "CrownRushBackup");
		}
	}

	public void NKEOIKOJMMD()
	{
		if (BGKIIAJNHLL >= 3)
		{
			FGAFPNCMKIN(3, JGFKDIEGAAH);
			GKKBMMHNFLE = BGKIIAJNHLL;
			return;
		}
		int @int = PlayerPrefs.GetInt("CrownRush", 0);
		if (@int < 20)
		{
			PlayerPrefs.SetInt("CrownRush", ++@int);
			ICNIGMDCCLN = true;
		}
		PLPKIFKDCOO(BGKIIAJNHLL, BGKIIAJNHLL + 1);
	}

	public void JDHNHIKEOMA()
	{
		if (BGKIIAJNHLL <= 0)
		{
			GKKBMMHNFLE = BGKIIAJNHLL;
		}
		else
		{
			PLPKIFKDCOO(BGKIIAJNHLL, 0);
		}
	}

	private void PLPKIFKDCOO(int BBDOEHOFHGH, int CEPDJPNELND)
	{
		BGKIIAJNHLL = CEPDJPNELND;
		GKKBMMHNFLE = BBDOEHOFHGH;
		FGAFPNCMKIN(CEPDJPNELND, JGFKDIEGAAH);
	}

	private void FGAFPNCMKIN(int EGEPICBFDAE, string IKNCPEPOKGJ)
	{
		string text = EGEPICBFDAE.ToString();
		GOEMHMEALGJ.JGMDDMNGDJO(IKNCPEPOKGJ, text);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Crown, "CrownRush level is persist as {0} for key {1}", text, IKNCPEPOKGJ);
	}

	private void GLDLFECLFPB()
	{
		int result = 0;
		ICNIGMDCCLN = false;
		string text = GOEMHMEALGJ.LIANKDMAHFM(JGFKDIEGAAH);
		if (text == null)
		{
			ICNIGMDCCLN = true;
			PLPKIFKDCOO(result, result);
			return;
		}
		string[] array = text.Split(':');
		if (array.Length == 1)
		{
			int.TryParse(array[0], out result);
		}
		else if (array.Length == 2)
		{
			int.TryParse(array[1], out result);
		}
		BGKIIAJNHLL = result;
		GKKBMMHNFLE = result;
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Crown, "CrownRush level is parsed as {0} for key {1}", text, JGFKDIEGAAH);
	}

	public List<NOALGNJECAD> HKNLBCLNKED()
	{
		return BLIBIINIGAI(BGKIIAJNHLL);
	}

	public static List<NOALGNJECAD> BLIBIINIGAI(int EGEPICBFDAE)
	{
		List<NOALGNJECAD> list = new List<NOALGNJECAD>();
		switch (EGEPICBFDAE)
		{
		case 1:
			list.Add(NOALGNJECAD.Rocket);
			list.Add(NOALGNJECAD.Bomb);
			break;
		case 2:
			list.Add(NOALGNJECAD.Rocket);
			list.Add(NOALGNJECAD.Bomb);
			list.Add(NOALGNJECAD.Rocket);
			list.Add(NOALGNJECAD.Bomb);
			break;
		case 3:
			list.Add(NOALGNJECAD.Rocket);
			list.Add(NOALGNJECAD.Bomb);
			list.Add(NOALGNJECAD.Rocket);
			list.Add(NOALGNJECAD.Bomb);
			list.Add(NOALGNJECAD.Rocket);
			list.Add(NOALGNJECAD.Bomb);
			break;
		}
		return list;
	}

	private static string EHCFPIHGGFM()
	{
		return "CrownRush" + LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
	}

	public static void GDBLPMMEOGF()
	{
		HJBLKNBHMFJ hJBLKNBHMFJ = HJBLKNBHMFJ.GABGKBAKHDP;
		string text = hJBLKNBHMFJ.LIANKDMAHFM("CrownRushBackup");
		if (text != null)
		{
			hJBLKNBHMFJ.JGMDDMNGDJO(EHCFPIHGGFM(), text);
			hJBLKNBHMFJ.KFCIOFNMKDA("CrownRushBackup");
		}
	}

	public static void HCIIGDJOOGF()
	{
		HJBLKNBHMFJ.GABGKBAKHDP.OLGJNHPAGFN("CrownRushDaily%");
	}

	public static void MPGDOEJHCOH(bool AGLBGNNGFME)
	{
		GABGKBAKHDP.OMOKOKFNBKI();
		string text = "CrownRush" + 0;
		string text2 = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM(text);
		if (text2 != null)
		{
			HJBLKNBHMFJ.GABGKBAKHDP.MFKBEDNLCJA(text);
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Crown, "Data is removed for key {0}", text);
			if (!AGLBGNNGFME)
			{
				string text3 = EHCFPIHGGFM();
				HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO(text3, text2);
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Crown, "CrownRush level {0} migrated from CrownRush0 to {1}", text2, text3);
			}
		}
	}
}
