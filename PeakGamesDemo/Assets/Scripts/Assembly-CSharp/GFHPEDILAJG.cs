public class GFHPEDILAJG : DLDDFKDFKEF
{
	private static GFHPEDILAJG KNPOFJNFLJB;

	private readonly HJBLKNBHMFJ NJCPCACOCGB;

	private const string KMNJBFEENII = "KeyIsInSocialTeam";

	private const string MAIBKOCMPEG = "KeySyncId";

	private const string AAJEHCOIDAP = "KeyAskLifeAvailableTime";

	private int? CEFLMCACNIJ;

	private bool? GOGGCNOGMLI;

	public static GFHPEDILAJG GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB != null)
			{
				return KNPOFJNFLJB;
			}
			KNPOFJNFLJB = new GFHPEDILAJG();
			return KNPOFJNFLJB;
		}
	}

	public int OMBKMIINHMF
	{
		get
		{
			int? cEFLMCACNIJ = CEFLMCACNIJ;
			if (cEFLMCACNIJ.HasValue)
			{
				int? cEFLMCACNIJ2 = CEFLMCACNIJ;
				return cEFLMCACNIJ2.Value;
			}
			int result;
			int.TryParse(NJCPCACOCGB.LIANKDMAHFM("KeySyncId", null), out result);
			CEFLMCACNIJ = result;
			int? cEFLMCACNIJ3 = CEFLMCACNIJ;
			return cEFLMCACNIJ3.Value;
		}
		set
		{
			int? cEFLMCACNIJ = CEFLMCACNIJ;
			if (!cEFLMCACNIJ.HasValue || value != CEFLMCACNIJ)
			{
				NJCPCACOCGB.JGMDDMNGDJO("KeySyncId", value.ToString());
				CEFLMCACNIJ = value;
			}
		}
	}

	public bool ODMCGBLJFKM
	{
		get
		{
			bool? gOGGCNOGMLI = GOGGCNOGMLI;
			if (gOGGCNOGMLI.HasValue)
			{
				bool? gOGGCNOGMLI2 = GOGGCNOGMLI;
				return gOGGCNOGMLI2.Value;
			}
			int result;
			int.TryParse(NJCPCACOCGB.LIANKDMAHFM("KeyIsInSocialTeam", "0"), out result);
			GOGGCNOGMLI = result > 0;
			bool? gOGGCNOGMLI3 = GOGGCNOGMLI;
			return gOGGCNOGMLI3.Value;
		}
		set
		{
			bool? gOGGCNOGMLI = GOGGCNOGMLI;
			if (!gOGGCNOGMLI.HasValue || value != GOGGCNOGMLI)
			{
				NJCPCACOCGB.JGMDDMNGDJO("KeyIsInSocialTeam", (!value) ? "0" : "1");
				GOGGCNOGMLI = value;
			}
		}
	}

	private GFHPEDILAJG()
	{
		NJCPCACOCGB = HJBLKNBHMFJ.GABGKBAKHDP;
	}

	public int DIHIHGCLEKI()
	{
		int result;
		int.TryParse(NJCPCACOCGB.LIANKDMAHFM("KeyAskLifeAvailableTime", null), out result);
		return result;
	}

	public void DAPBGBIBHPD(long JPLBFCGBKPM)
	{
		NJCPCACOCGB.JGMDDMNGDJO("KeyAskLifeAvailableTime", JPLBFCGBKPM.ToString());
	}

	public void OMOKOKFNBKI()
	{
		CEFLMCACNIJ = null;
		GOGGCNOGMLI = null;
		NJCPCACOCGB.MFKBEDNLCJA("KeySyncId");
		NJCPCACOCGB.MFKBEDNLCJA("KeyIsInSocialTeam");
	}
}
