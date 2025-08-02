using GamePlayScene.Mechanics.Items;

public class NLMLKADGECN : DLDDFKDFKEF
{
	private static NLMLKADGECN KNPOFJNFLJB;

	private int BKDFGCGOKJG;

	private global::HHNDNFBNICP<BlasterItem> OOMFKAHMMIK;

	private global::HHNDNFBNICP<WallItem> CAPELFAJOKB;

	public int GGLGBLDNMGO
	{
		get
		{
			return BKDFGCGOKJG++;
		}
	}

	public static NLMLKADGECN GABGKBAKHDP
	{
		get
		{
			return KNPOFJNFLJB ?? (KNPOFJNFLJB = new NLMLKADGECN());
		}
	}

	public global::HHNDNFBNICP<BlasterItem> BPHMPBKJJOO()
	{
		return OOMFKAHMMIK ?? (OOMFKAHMMIK = new global::HHNDNFBNICP<BlasterItem>());
	}

	public global::HHNDNFBNICP<WallItem> OAPMNDFNNHB()
	{
		return CAPELFAJOKB ?? (CAPELFAJOKB = new global::HHNDNFBNICP<WallItem>());
	}

	public bool NODDCJJNJEC(LEDBLDKJBAI JOCKKMJBJLL)
	{
		return BPHMPBKJJOO().NODDCJJNJEC(JOCKKMJBJLL) || OAPMNDFNNHB().NODDCJJNJEC(JOCKKMJBJLL);
	}

	public void OMOKOKFNBKI()
	{
		BKDFGCGOKJG = 0;
		if (OOMFKAHMMIK != null)
		{
			OOMFKAHMMIK.OMOKOKFNBKI();
		}
		if (CAPELFAJOKB != null)
		{
			CAPELFAJOKB.OMOKOKFNBKI();
		}
	}

	public static void INJHFIFHKOB()
	{
		if (KNPOFJNFLJB != null)
		{
			KNPOFJNFLJB.OOMFKAHMMIK = null;
			KNPOFJNFLJB.CAPELFAJOKB = null;
		}
		KNPOFJNFLJB = null;
	}
}
