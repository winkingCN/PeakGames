using Assets.Scripts.GamePlayScene.Tutorials;

public class CACKIGBBMPB
{
	public const string JLNCKNHPAOD = "Current_Version";

	private static CACKIGBBMPB KNPOFJNFLJB;

	public bool CLNAHDCHOFI;

	public bool DLJPFGHEPLB;

	private readonly HJBLKNBHMFJ ODEGDLHJOFN;

	public static CACKIGBBMPB GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new CACKIGBBMPB();
			}
			return KNPOFJNFLJB;
		}
	}

	public CACKIGBBMPB()
	{
		ODEGDLHJOFN = HJBLKNBHMFJ.GABGKBAKHDP;
	}

	public void PLPEELGIEHN()
	{
		KIIMAOFAIJD();
	}

	private void KIIMAOFAIJD()
	{
		int result;
		if (int.TryParse("4161", out result))
		{
			string text = ODEGDLHJOFN.LIANKDMAHFM("Current_Version");
			ODEGDLHJOFN.JGMDDMNGDJO("Current_Version", "4161");
			if (text == null)
			{
				text = "0";
			}
			int result2;
			int.TryParse(text, out result2);
			if (result2 == 0)
			{
				DLJPFGHEPLB = true;
			}
			if (result2 != result)
			{
				CLNAHDCHOFI = result2 != 0;
				MPGHHIANPFD(result2, result);
			}
		}
	}

	private void MPGHHIANPFD(int ADCAKBLBNEH, int BOGKBNEIHDB)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.VersionUpgrade, "OLD:{0} NEW:{1}", ADCAKBLBNEH, BOGKBNEIHDB);
		if (ADCAKBLBNEH > 0)
		{
			if (ADCAKBLBNEH <= 1431 && BOGKBNEIHDB > 1431)
			{
				CCBHMMPCKJK();
			}
			if (ADCAKBLBNEH <= 1640 && BOGKBNEIHDB > 1640)
			{
				IAJHOODKFAA();
			}
			if (ADCAKBLBNEH <= 2594 && BOGKBNEIHDB > 2594)
			{
				KCAELBCNKFN.GABGKBAKHDP.OMBKLCBCMGP("DROP TABLE IF EXISTS TempInventory");
			}
			if (ADCAKBLBNEH <= 3670 && BOGKBNEIHDB > 3670)
			{
				CFNKECEHDIC.JGOAFANIDME();
			}
			if (ADCAKBLBNEH <= 3912 && BOGKBNEIHDB > 3912)
			{
				IMPIFJOCKBI.ELIHEGAKHOC();
			}
			if (ADCAKBLBNEH <= 3930 && BOGKBNEIHDB > 3930)
			{
				DIGGBGADIGJ.HCIIGDJOOGF();
			}
			if (ADCAKBLBNEH <= 3990 && BOGKBNEIHDB > 3990)
			{
				HJBLKNBHMFJ.GABGKBAKHDP.OLGJNHPAGFN("LevelTryCount%");
			}
			if (BOGKBNEIHDB > ADCAKBLBNEH)
			{
				EKGLBJJKNBG.GABGKBAKHDP.CKHHPNAOAEF();
			}
		}
	}

	private static void IAJHOODKFAA()
	{
		CLJBOPHAOOD cLJBOPHAOOD = CLJBOPHAOOD.GABGKBAKHDP;
		int num = cLJBOPHAOOD.LIANKDMAHFM("TutorialStarChestStart");
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.MapTutorial, "Migrating old user data for Start StarChestTutorial, Key is:{0}", num);
		if (num.Equals(1))
		{
			MapTutorial.CompleteStarChestStartTutorial();
		}
		cLJBOPHAOOD.MFKBEDNLCJA("TutorialStarChestStart");
		int num2 = cLJBOPHAOOD.LIANKDMAHFM("TutorialStarChestOpen");
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.MapTutorial, "Migrating old user data for Open StarChestTutorial, Key is:{0}", num2);
		if (num2.Equals(1))
		{
			MapTutorial.CompleteStarChestOpenTutorial();
		}
		cLJBOPHAOOD.MFKBEDNLCJA("TutorialStarChestOpen");
	}

	private void CCBHMMPCKJK()
	{
		string text = ODEGDLHJOFN.LIANKDMAHFM("number_of_lifes");
		if (text == null)
		{
			return;
		}
		int result;
		int.TryParse(text, out result);
		if (result > 0)
		{
			for (int i = 0; i < result; i++)
			{
				PJPPADHKGHN.GABGKBAKHDP.CJNFILFKEAC();
			}
		}
		ODEGDLHJOFN.MFKBEDNLCJA("number_of_lifes");
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.VersionUpgrade, "Lives Migrated > Lives Count{0}", result);
	}
}
