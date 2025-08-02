public class MKINMKEMBPL : DLDDFKDFKEF
{
	public const string FCLMDIGHAGE = "Tutorial10";

	public const string BKPNPGMECNF = "Tutorial13";

	public const string FKFGPGHCGGK = "Tutorial17";

	public const string GEDAJBGEGEL = "Tutorial20";

	public const string LGHFPBCKOHF = "TutorialPrelevel";

	public const string IIKJPEHPAHG = "AnvilUnlocked";

	public const string JGEKMEEEIJH = "BoxingGloveUnlocked";

	public const string ONGDEHJJFGD = "HammerUnlocked";

	public const string LINJNJPAAFC = "ShuffleUnlocked";

	public const string MFEJPPJINAP = "UserEnteredMap";

	public const string CMLDGGKDBKA = "TutorialSocialCompleted";

	public const string GHLEGIDGPPM = "KeyInboxFacebookConnectHasShown";

	private static MKINMKEMBPL KNPOFJNFLJB;

	private readonly CLJBOPHAOOD NJCPCACOCGB;

	private HJBLKNBHMFJ LALNIFAOJBA;

	public static MKINMKEMBPL GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new MKINMKEMBPL();
			}
			return KNPOFJNFLJB;
		}
	}

	private MKINMKEMBPL()
	{
		NJCPCACOCGB = CLJBOPHAOOD.GABGKBAKHDP;
		LALNIFAOJBA = HJBLKNBHMFJ.GABGKBAKHDP;
	}

	public void OMOKOKFNBKI()
	{
		NJCPCACOCGB.BBGLCADIONK();
	}

	public int CNDHGKBCFAB(string IKNCPEPOKGJ)
	{
		return NJCPCACOCGB.LIANKDMAHFM(IKNCPEPOKGJ);
	}

	public bool EEEJGFGENKM(string IKNCPEPOKGJ)
	{
		return NJCPCACOCGB.EEEJGFGENKM(IKNCPEPOKGJ);
	}

	public bool HEANMKDLPGF(string IKNCPEPOKGJ)
	{
		return 1 == NJCPCACOCGB.LIANKDMAHFM(IKNCPEPOKGJ);
	}

	public bool HEANMKDLPGF(string IKNCPEPOKGJ, int HIMINGHNIKN)
	{
		return NJCPCACOCGB.LIANKDMAHFM(IKNCPEPOKGJ) >= HIMINGHNIKN;
	}

	public void KMPGGMKICLB(string IKNCPEPOKGJ)
	{
		NJCPCACOCGB.JGMDDMNGDJO(IKNCPEPOKGJ, 1);
	}

	public void NFFBHHOKFGJ(string IKNCPEPOKGJ)
	{
		GPJDHPEELCP(IKNCPEPOKGJ, 1);
	}

	public void GPJDHPEELCP(string IKNCPEPOKGJ, int HCPGBNNFNCO)
	{
		int num = NJCPCACOCGB.LIANKDMAHFM(IKNCPEPOKGJ);
		num += HCPGBNNFNCO;
		NJCPCACOCGB.JGMDDMNGDJO(IKNCPEPOKGJ, num);
	}

	public void HOKOPPLGJIK(string IKNCPEPOKGJ, int EDDNOJDPMCF)
	{
		NJCPCACOCGB.JGMDDMNGDJO(IKNCPEPOKGJ, EDDNOJDPMCF);
	}

	public bool GOAAKODJMPI(string IKNCPEPOKGJ)
	{
		return "1".Equals(LALNIFAOJBA.LIANKDMAHFM(IKNCPEPOKGJ));
	}

	public void PJOCEPHIEPF(string IKNCPEPOKGJ)
	{
		LALNIFAOJBA.JGMDDMNGDJO(IKNCPEPOKGJ, "1");
	}

	public void CJOHLENDJGO(string IKNCPEPOKGJ)
	{
		NJCPCACOCGB.MFKBEDNLCJA(IKNCPEPOKGJ);
	}

	public void JIIFLHPECME(string MLMDFFLMJCH)
	{
		NJCPCACOCGB.JIIFLHPECME(MLMDFFLMJCH);
	}
}
