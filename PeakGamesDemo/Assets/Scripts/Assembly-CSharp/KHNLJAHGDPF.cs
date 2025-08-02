using System;
using UnityEngine;

public static class KHNLJAHGDPF
{
	private static int HACPBKEHLGF;

	private const int GODNKKBIJKC = 3600;

	private const int ANMCKNJJOFA = 86400;

	private const string JIDBODKIDDJ = "InboxNotificationKey";

	private const string DBEGDPDJCNH = "ToonNotificationKey";

	private const string NKBIFONCJBB = "StarNotificationKey";

	private const string KGEGDPBEGMC = "TeamChestNotificationKey";

	private const string GGOGFHFANNN = "TreasureHuntNotificationKey";

	private const string IEGEPCGOGPD = "CalendarNotificationKey";

	public static void JIMBAPGACIJ()
	{
		if (HACPBKEHLGF != Time.frameCount)
		{
			HACPBKEHLGF = Time.frameCount;
			KIIMLFPJHHD.BOPEPLONIFL();
			if (IJNIIKFFCEM(DateTime.Now))
			{
				DFNBGMLDFBN(1, NKILHODNBDE.GHBGCADFLFB("NotifDay1"));
			}
			DFNBGMLDFBN(2, NKILHODNBDE.GHBGCADFLFB("NotifDay2"));
			DFNBGMLDFBN(3, NKILHODNBDE.GHBGCADFLFB("NotifDay3"));
			DFNBGMLDFBN(7, NKILHODNBDE.GHBGCADFLFB("NotifDay7"));
			DFNBGMLDFBN(14, NKILHODNBDE.GHBGCADFLFB("NotifDay7"));
			DFNBGMLDFBN(28, NKILHODNBDE.GHBGCADFLFB("NotifDay7"));
			DOBAOEGHENG();
			MNADFKEFNHB();
			CPACGAJFHDD();
			BPHGLEIDJNG();
			CJLCALNDGCN();
			MIBAAFAEFBL();
			KONJMPLEAHK();
			CPFDPDEJIEO();
			BNGKAOGJDII();
			ENMPKAMJBNM();
		}
	}

	private static void MNADFKEFNHB()
	{
		if (MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() < 20 || !GFHPEDILAJG.GABGKBAKHDP.ODMCGBLJFKM)
		{
			return;
		}
		int num = GFHPEDILAJG.GABGKBAKHDP.DIHIHGCLEKI();
		long num2 = DateTime.Now.GMEBBNOHJFJ();
		long num3 = num - num2;
		if (num3 > 0)
		{
			DateTime pDOFNANCACN = DateTime.Now.AddSeconds(num3);
			if (!MEMLNIOKINB(pDOFNANCACN))
			{
				int num4 = (int)pDOFNANCACN.Subtract(DateTime.Now).TotalSeconds;
				KIIMLFPJHHD.NPHADJONJOI(num4, NKILHODNBDE.GHBGCADFLFB("NotifAskLife"));
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Set Ask Life Notification: Delay:{0}", num4);
			}
		}
	}

	private static void DFNBGMLDFBN(int CDJGNEDLGEF, string NOIOHIPHFHA)
	{
		DateTime dateTime = CKDAKDPBOPM(DateTime.Now.AddDays(CDJGNEDLGEF));
		int dKIPEJPGACG = (int)dateTime.Subtract(DateTime.Now).TotalSeconds;
		KIIMLFPJHHD.NPHADJONJOI(dKIPEJPGACG, NOIOHIPHFHA);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Day {0}: {1}", CDJGNEDLGEF, dateTime);
	}

	private static void DOBAOEGHENG()
	{
		PJPPADHKGHN pJPPADHKGHN = PJPPADHKGHN.GABGKBAKHDP;
		MOLCIIAPCMN mOLCIIAPCMN = pJPPADHKGHN.PMBGCACJIHD();
		int aPLNHKHHMEL = mOLCIIAPCMN.APLNHKHHMEL;
		int dLDHNNCGIPI = mOLCIIAPCMN.DLDHNNCGIPI;
		int num = PJPPADHKGHN.GABGKBAKHDP.HNBIMJHPIPE();
		if (num > 0)
		{
			int num2 = num - 7200;
			if (num2 > 5)
			{
				DateTime dateTime = DateTime.Now.AddSeconds(num2);
				if (!MEMLNIOKINB(dateTime))
				{
					int dKIPEJPGACG = (int)dateTime.Subtract(DateTime.Now).TotalSeconds;
					KIIMLFPJHHD.NPHADJONJOI(dKIPEJPGACG, NKILHODNBDE.GHBGCADFLFB("NotifUnlimitedLives"));
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Notification Unlimited life set for {0}", dateTime);
				}
			}
		}
		else
		{
			if (dLDHNNCGIPI >= 5)
			{
				return;
			}
			int num3 = (5 - (dLDHNNCGIPI + 1)) * PJPPADHKGHN.GABGKBAKHDP.FNJHCNEGNCC + aPLNHKHHMEL + 10;
			DateTime dateTime2 = DateTime.Now.AddSeconds(num3);
			if (!MEMLNIOKINB(dateTime2))
			{
				num3 = (int)dateTime2.Subtract(DateTime.Now).TotalSeconds;
				KIIMLFPJHHD.NPHADJONJOI(num3, NKILHODNBDE.GHBGCADFLFB("NotifAllLives"));
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Notification Full Life Set: {0}", dateTime2);
			}
			if (dLDHNNCGIPI <= 0)
			{
				DateTime dateTime3 = DateTime.Now.AddSeconds(aPLNHKHHMEL + 5);
				if (!MEMLNIOKINB(dateTime3))
				{
					KIIMLFPJHHD.NPHADJONJOI(aPLNHKHHMEL + 5, NKILHODNBDE.GHBGCADFLFB("NotifFirstLife"));
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Notification 1st Life Set: {0}", dateTime3);
				}
			}
		}
	}

	private static void CPACGAJFHDD()
	{
		if (MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() < 20 || (NDFJALJNGNK("TeamChestNotificationKey") && MFPGJKCBKGG()) || (NDFJALJNGNK("TreasureHuntNotificationKey") && OINDOLCDNGK()))
		{
			return;
		}
		if (UnityEngine.Random.value < 0.5f)
		{
			if ((!NDFJALJNGNK("InboxNotificationKey") || !JBCPCNCAEPD()) && (!NDFJALJNGNK("StarNotificationKey") || !GNAFNKMDKDI()) && NDFJALJNGNK("ToonNotificationKey"))
			{
				MLKBNFMCMNO();
			}
		}
		else if ((!NDFJALJNGNK("ToonNotificationKey") || !MLKBNFMCMNO()) && (!NDFJALJNGNK("StarNotificationKey") || !GNAFNKMDKDI()) && NDFJALJNGNK("InboxNotificationKey"))
		{
			JBCPCNCAEPD();
		}
	}

	private static bool JBCPCNCAEPD()
	{
		if (PJPPADHKGHN.GABGKBAKHDP.PMBGCACJIHD().DLDHNNCGIPI != 0 || CAGBGIHKHEJ.GABGKBAKHDP.ELEKFHDLKJJ() == 0)
		{
			return false;
		}
		if (MEMLNIOKINB(DateTime.Now.AddSeconds(60.0)))
		{
			return false;
		}
		KIIMLFPJHHD.NPHADJONJOI(60, NKILHODNBDE.GHBGCADFLFB("NotifInboxLife"));
		PDMDNHBCDDE("InboxNotificationKey");
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Notification Inbox reminder set. Delay: 60");
		return true;
	}

	private static bool GNAFNKMDKDI()
	{
		int dGIKLPPBGHJ = NDGOJGLPIJF.DGIKLPPBGHJ;
		int num = Math.Min(GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Stars), dGIKLPPBGHJ);
		if (num != dGIKLPPBGHJ)
		{
			return false;
		}
		int num2 = NGCMBNGFECF(60);
		KIIMLFPJHHD.NPHADJONJOI(num2, NKILHODNBDE.GHBGCADFLFB("NotifStarChest"));
		PDMDNHBCDDE("StarNotificationKey");
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Notification Star Chest not open set. Delay: {0}", num2);
		return true;
	}

	private static bool MLKBNFMCMNO()
	{
		if (!NDGOJGLPIJF.GABGKBAKHDP.BMKIICIJGEK() || IDFPAFEJPPH.GABGKBAKHDP.HGNJBHGBLIN)
		{
			return false;
		}
		int num = NGCMBNGFECF(60);
		KIIMLFPJHHD.NPHADJONJOI(num, NKILHODNBDE.GHBGCADFLFB("NotifToonChest"));
		PDMDNHBCDDE("ToonNotificationKey");
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Notification Toon Chest not open set. Delay: {0}", num);
		return true;
	}

	private static void BPHGLEIDJNG()
	{
		int num = DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60;
		int num2 = 68100 - num;
		if (num2 <= 0 || !DJFEHCGIDGC.GABGKBAKHDP.NPDHFFPKPLF())
		{
			num2 += 86400;
		}
		KIIMLFPJHHD.NPHADJONJOI(num2, NKILHODNBDE.GHBGCADFLFB("NotifDailyBonus"), NKILHODNBDE.GHBGCADFLFB("NotifDailyBonusTitle"));
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Notification Daily Bonus set. Delay: {0}", num2);
	}

	private static void CJLCALNDGCN()
	{
		AAPMDEEMEMM aAPMDEEMEMM = DGOMNDMPMBG.GABGKBAKHDP.BHGCBNAMEFK;
		if (aAPMDEEMEMM != null && aAPMDEEMEMM.AEBACBBGHKI > 0 && aAPMDEEMEMM.KKGHMHHILNF == 1)
		{
			int num = (int)aAPMDEEMEMM.AEBACBBGHKI + 5;
			if (num > 3600 && !MEMLNIOKINB(DateTime.Now.AddSeconds(num - 3600)))
			{
				KIIMLFPJHHD.NPHADJONJOI(num - 3600, NKILHODNBDE.GHBGCADFLFB("NotifTeamChest1H"), NKILHODNBDE.GHBGCADFLFB("NotifTeamChest1HTitle"));
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Notification Team Chest 1 hour left set. Delay: {0}", num - 3600);
			}
		}
	}

	private static bool MFPGJKCBKGG()
	{
		AAPMDEEMEMM aAPMDEEMEMM = DGOMNDMPMBG.GABGKBAKHDP.BHGCBNAMEFK;
		if (aAPMDEEMEMM == null || aAPMDEEMEMM.KKGHMHHILNF != 2)
		{
			return false;
		}
		int num = NGCMBNGFECF(60);
		KIIMLFPJHHD.NPHADJONJOI(num, NKILHODNBDE.GHBGCADFLFB("NotifTeamChestReminder"));
		PDMDNHBCDDE("TeamChestNotificationKey");
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Team Chest reminder set. Delay: {0}", num);
		return true;
	}

	private static void MIBAAFAEFBL()
	{
		GPAFPAEDOHM gPAFPAEDOHM = DGOMNDMPMBG.GABGKBAKHDP.IIEALLANECJ;
		if (gPAFPAEDOHM != null && gPAFPAEDOHM.AEBACBBGHKI > 0 && gPAFPAEDOHM.AEPLIGFCGIF == 2)
		{
			int num = (int)gPAFPAEDOHM.AEBACBBGHKI + 5;
			if (num > 3600 && !MEMLNIOKINB(DateTime.Now.AddSeconds(num - 3600)))
			{
				KIIMLFPJHHD.NPHADJONJOI(num - 3600, NKILHODNBDE.GHBGCADFLFB("NotifStarTournament1H"), NKILHODNBDE.GHBGCADFLFB("NotifStarTournament1HTitle"));
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Notification Star Tournament 1 hour left set. Delay: {0}", num - 3600);
			}
			int num2 = NGCMBNGFECF(num);
			KIIMLFPJHHD.NPHADJONJOI(num2, NKILHODNBDE.GHBGCADFLFB("NotifStarTournamentEnd"), NKILHODNBDE.GHBGCADFLFB("NotifStarTournamentEndTitle"));
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Notification Star Tournament end set. Delay: {0}", num2);
		}
	}

	private static void KONJMPLEAHK()
	{
		if (IDFPAFEJPPH.GABGKBAKHDP.HGNJBHGBLIN && IDFPAFEJPPH.GABGKBAKHDP.AEBACBBGHKI > 0)
		{
			int num = (int)IDFPAFEJPPH.GABGKBAKHDP.AEBACBBGHKI + 5;
			if (num > 172800)
			{
				int num2 = num - 172800;
				KIIMLFPJHHD.NPHADJONJOI(num2, NKILHODNBDE.GHBGCADFLFB("NotifChampionsLeague2D"), NKILHODNBDE.GHBGCADFLFB("NotifChampionsLeague2DTitle"));
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Notification Champions League 2 days left set. Delay: {0}", num2);
			}
			int num3 = NGCMBNGFECF(num);
			KIIMLFPJHHD.NPHADJONJOI(num3, NKILHODNBDE.GHBGCADFLFB("NotifChampionsLeagueEnd"), NKILHODNBDE.GHBGCADFLFB("NotifChampionsLeagueEndTitle"));
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Notification Champions League end set. Delay: {0}", num3);
		}
	}

	private static void CPFDPDEJIEO()
	{
		KCKDNJOMPJH kCKDNJOMPJH = DGOMNDMPMBG.GABGKBAKHDP.FABKMFCBELE;
		if (kCKDNJOMPJH != null && kCKDNJOMPJH.AEBACBBGHKI > 0 && kCKDNJOMPJH.AEPLIGFCGIF == 2)
		{
			int num = (int)kCKDNJOMPJH.AEBACBBGHKI + 5;
			if (num > 86400)
			{
				int num2 = NGCMBNGFECF(num - 86400);
				KIIMLFPJHHD.NPHADJONJOI(num2, NKILHODNBDE.GHBGCADFLFB("NotifTeamTournament24H"), NKILHODNBDE.GHBGCADFLFB("NotifTeamTournament24HTitle"));
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Notification Team Tournament 1 day left set. Delay: {0}", num2);
			}
			if (num > 3600 && !MEMLNIOKINB(DateTime.Now.AddSeconds(num - 3600)))
			{
				KIIMLFPJHHD.NPHADJONJOI(num - 3600, NKILHODNBDE.GHBGCADFLFB("NotifTeamTournament1H"), NKILHODNBDE.GHBGCADFLFB("NotifTeamTournament1HTitle"));
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Notification Team Tournament 1 hour left set. Delay: {0}", num - 3600);
			}
			int num3 = NGCMBNGFECF(num);
			KIIMLFPJHHD.NPHADJONJOI(num3, NKILHODNBDE.GHBGCADFLFB("NotifTeamTournamentEnd"), NKILHODNBDE.GHBGCADFLFB("NotifTeamTournamentEndTitle"));
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Notification Team Tournament end set. Delay: {0}", num3);
		}
	}

	private static void BNGKAOGJDII()
	{
		CFNKECEHDIC cFNKECEHDIC = DGOMNDMPMBG.GABGKBAKHDP.OEPCIADENMH;
		if (cFNKECEHDIC != null && cFNKECEHDIC.AEBACBBGHKI > 0 && !cFNKECEHDIC.HAPNFEFLGBK)
		{
			int num = (int)cFNKECEHDIC.AEBACBBGHKI + 5;
			if (num > 86400)
			{
				int num2 = NGCMBNGFECF(num - 86400);
				KIIMLFPJHHD.NPHADJONJOI(num2, NKILHODNBDE.GHBGCADFLFB("NotifTreasureHunt24H"), NKILHODNBDE.GHBGCADFLFB("NotifTreasureHunt24HTitle"));
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Notification Treasure Hunt 1 day left set. Delay: {0}", num2);
			}
			if (num > 3600 && !MEMLNIOKINB(DateTime.Now.AddSeconds(num - 3600)))
			{
				KIIMLFPJHHD.NPHADJONJOI(num - 3600, NKILHODNBDE.GHBGCADFLFB("NotifTreasureHunt1H"), NKILHODNBDE.GHBGCADFLFB("NotifTreasureHunt1HTitle"));
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Notification Treasure Hunt 1 hour left set. Delay: {0}", num - 3600);
			}
		}
	}

	private static bool OINDOLCDNGK()
	{
		CFNKECEHDIC cFNKECEHDIC = DGOMNDMPMBG.GABGKBAKHDP.OEPCIADENMH;
		if (cFNKECEHDIC == null || cFNKECEHDIC.AEPLIGFCGIF != 2)
		{
			return false;
		}
		int num = NGCMBNGFECF(60);
		KIIMLFPJHHD.NPHADJONJOI(num, NKILHODNBDE.GHBGCADFLFB("NotifTreasureHuntReminder"));
		PDMDNHBCDDE("TreasureHuntNotificationKey");
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Treasure Hunt reminder set. Delay: {0}", num);
		return true;
	}

	private static void ENMPKAMJBNM()
	{
		string text = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("KeyAB_Calendar");
		if (text == null || text.Equals("0"))
		{
			return;
		}
		int result = 0;
		long result2 = 0L;
		string iKNCPEPOKGJ = LDPCLGLPELI();
		string text2 = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM(iKNCPEPOKGJ);
		if (text2 != null)
		{
			string[] array = text2.Split(':');
			if (array.Length == 2)
			{
				int.TryParse(array[0], out result);
				long.TryParse(array[1], out result2);
			}
		}
		long num = DateTime.UtcNow.GMEBBNOHJFJ() / 86400;
		long num2 = num - 1;
		int num3 = DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60;
		int num4 = 64500 - num3;
		if (num4 > 0)
		{
			if (result2 != num)
			{
				result = ((result2 != num2) ? 1 : (result + 1));
			}
			else
			{
				num4 += 86400;
				result++;
			}
		}
		else
		{
			num4 += 86400;
			result = ((result2 != num) ? 1 : (result + 1));
		}
		if (result > 7)
		{
			result = 1;
		}
		string fCEEGNFABAF = ((result != 1) ? string.Format(NKILHODNBDE.GHBGCADFLFB("NotifToonCalendarProgressTitle"), result) : NKILHODNBDE.GHBGCADFLFB("NotifToonCalendarDay1Title"));
		string oEFCOJLNCKP = ((result != 1) ? NKILHODNBDE.GHBGCADFLFB("NotifToonCalendarProgress") : NKILHODNBDE.GHBGCADFLFB("NotifToonCalendarDay1"));
		KIIMLFPJHHD.NPHADJONJOI(num4, oEFCOJLNCKP, fCEEGNFABAF);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Notification, "Notification Calendar set. Reward Step: {0} Delay: {1}", result, num4);
	}

	public static string LDPCLGLPELI()
	{
		return "CalendarNotificationKey" + LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
	}

	private static void PDMDNHBCDDE(string IKNCPEPOKGJ)
	{
		long num = DateTime.Now.GMEBBNOHJFJ() + 86400 + 60;
		HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO(IKNCPEPOKGJ, num.ToString());
	}

	private static bool NDFJALJNGNK(string IKNCPEPOKGJ)
	{
		long result;
		long.TryParse(HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM(IKNCPEPOKGJ), out result);
		return DateTime.Now.GMEBBNOHJFJ() > result || DateTime.Now.GMEBBNOHJFJ() < result - 86400;
	}

	private static int NGCMBNGFECF(int FPNHDNGIOCC)
	{
		return (int)CKDAKDPBOPM(DateTime.Now.AddSeconds(FPNHDNGIOCC)).Subtract(DateTime.Now).TotalSeconds;
	}

	private static bool MEMLNIOKINB(DateTime PDOFNANCACN)
	{
		return PDOFNANCACN.Hour >= 0 && PDOFNANCACN.Hour < 10;
	}

	private static bool IJNIIKFFCEM(DateTime PDOFNANCACN)
	{
		if (PDOFNANCACN.Hour != 18)
		{
			return true;
		}
		return PDOFNANCACN.Minute < 50;
	}

	private static DateTime CKDAKDPBOPM(DateTime PDOFNANCACN)
	{
		while (MEMLNIOKINB(PDOFNANCACN))
		{
			PDOFNANCACN = PDOFNANCACN.AddHours(1.0);
		}
		return PDOFNANCACN;
	}
}
